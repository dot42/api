using System;
using System.Reflection;
using Java.Util;

namespace Dot42.Internal
{
    /// <summary>
    /// This class retrieves and caches types per assembly.
    /// </summary>
    internal static class AssemblyTypes
    {
        // This field is initialized by the compiler.
        private static readonly string  EntryAssembly;

        public static readonly Assembly DefaultAssembly;

        // We only hold the (so called binary) type-names here. Holding the names
        // instead of the types means we do not hold strong references to the 
        // types. Additionaly, we do not need to load all classes at startup.
        private static readonly HashMap<string, Assembly> TypesPerAssembly = null;
        private static Assembly _entryAssembly;

        public static Assembly GetEntryAssembly()
        {
            return _entryAssembly ?? DefaultAssembly;
        }

        public static Assembly GetAssemblyFromType(Type type)
        {
            if (TypesPerAssembly == null)
                return DefaultAssembly;

            return TypesPerAssembly.Get(type.JavaGetName()) ?? DefaultAssembly;
        }

        static AssemblyTypes()
        {
            DefaultAssembly = Assembly.DefaultAssembly;

            var types = GetAssemblyTypeList();

            if (types == null)
            { 
                _entryAssembly = DefaultAssembly;
                return;
            }
            
            TypesPerAssembly = new HashMap<string, Assembly>();

            int len = types.Length;
            string curAssemblyName = null;

            ArrayList<string> curTypeNames = new ArrayList<string>();

            for (int i = 0; i < len; i++)
            {
                var val = types[i];

                if (val[0] == '!')
                {
                    FinializeAssembly(curAssemblyName, curTypeNames);
                    curAssemblyName = val.Substring(1);
                    continue;
                }

                curTypeNames.Add(val);
            }

            FinializeAssembly(curAssemblyName, curTypeNames);

            if (_entryAssembly == null)
                _entryAssembly = DefaultAssembly;
        }

        private static string[] GetAssemblyTypeList()
        {
            var anno = typeof(AssemblyTypes).GetAnnotation<IAssemblyTypes>(typeof(IAssemblyTypes));
            return anno != null ? anno.AssemblyTypeList() : null;
        }

        private static void FinializeAssembly(string curAssemblyName, ArrayList<string> curTypes)
        {
            if (curTypes.Count == 0)
                return;
            
            // curAssemblyName == null is not used by the compiler at the moment, but could be.
            var assm = curAssemblyName == null ? DefaultAssembly : new Assembly(curAssemblyName);

            if (curAssemblyName == EntryAssembly)
                _entryAssembly = assm;

            if (curAssemblyName == null)
            {
                foreach (var type in curTypes.AsEnumerable())
                    DefaultAssembly.AddType(type);
            }
            else
            {
                foreach (var type in curTypes.AsEnumerable())
                {
                    assm.AddType(type);
                    TypesPerAssembly.Put(type, assm);
                }
            }

            curTypes.Clear();
        }
    }
}
