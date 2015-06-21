using System;
using System.Reflection;
using Dot42.Collections.Specialized;
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

        // TODO: Think about not holding strong references to the types.
        //       To make this effective, this would have to be extended 
        //       to the assemblies as well. We could just hold the type
        //       names instead.
        private static readonly OpenIdentityHashMap<Type, Assembly> TypesPerAssembly = null;
        private static Assembly _entryAssembly;

        public static Assembly GetEntryAssembly()
        {
            return _entryAssembly ?? DefaultAssembly;
        }

        public static Assembly GetAssemblyFromType(Type type)
        {
            if (TypesPerAssembly == null)
                return DefaultAssembly;

            return TypesPerAssembly.Get(type) ?? DefaultAssembly;
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
            
            TypesPerAssembly = new OpenIdentityHashMap<Type, Assembly>();

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
                    TypesPerAssembly.Put(type, assm);
                }
            }

            curTypes.Clear();
        }
    }
}
