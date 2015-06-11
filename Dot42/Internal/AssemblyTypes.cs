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
        private static readonly string   EntryAssembly;

        public static readonly Assembly DefaultAssembly;

        private static volatile HashMap<Type, Assembly> _typesPerAssembly = null;
        private static volatile Assembly _entryAssembly;

        public static Assembly GetEntryAssembly()
        {
            return _entryAssembly ?? DefaultAssembly;
        }

        public static Assembly GetAssemblyFromType(Type type)
        {
            if (_typesPerAssembly == null)
                return DefaultAssembly;

            return _typesPerAssembly.Get(type) ?? DefaultAssembly;
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
            
            _typesPerAssembly = new HashMap<Type, Assembly>();

            int len = types.Length;
            string curAssemblyName = null;

            ArrayList<Type> curTypes = new ArrayList<Type>();

            for (int i = 0; i < len; i++)
            {
                var val = types[i];

                if (val is string)
                {
                    FinializeAssembly(curAssemblyName, curTypes);
                    curAssemblyName = (string) val;
                    continue;
                }

                curTypes.Add((Type) val);
            }

            FinializeAssembly(curAssemblyName, curTypes);

            if (_entryAssembly == null)
                _entryAssembly = DefaultAssembly;
        }

        private static object[] GetAssemblyTypeList()
        {
            var anno = typeof(AssemblyTypes).GetAnnotation<IAssemblyTypes>(typeof(IAssemblyTypes));
            return anno != null ? anno.AssemblyTypeList() : null;
        }

        private static void FinializeAssembly(string curAssemblyName, ArrayList<Type> curTypes)
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
                    _typesPerAssembly.Put(type, assm);
                }
            }

            curTypes.Clear();
        }
    }
}
