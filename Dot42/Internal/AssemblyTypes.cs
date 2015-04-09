﻿using System;
using System.Reflection;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
    /// <summary>
    /// this class retrieves and caches type per assembly.
    /// </summary>
    internal static class AssemblyTypes
    {
        private static ConcurrentHashMap<Type, Assembly> _typesPerAssembly = null;
        public static readonly Assembly DefaultAssembly = new Assembly(null);

        public static Assembly GetAssemblyFromType(Type type)
        {
            if (_typesPerAssembly != null)
                return _typesPerAssembly.Get(type) ?? DefaultAssembly;
            
            lock(typeof(AssemblyTypes))
            {
                if (_typesPerAssembly != null)
                    return _typesPerAssembly.Get(type) ?? DefaultAssembly;

                _typesPerAssembly = new ConcurrentHashMap<Type, Assembly>();

                HashMap<string, Assembly> assemblies = new HashMap<string, Assembly>();

                var annos = typeof (AssemblyTypes).GetAnnotation<IAssemblyTypes>(typeof (IAssemblyTypes));
                if (annos != null)
                {
                    foreach (var anno in annos.Types())
                    {
                        var assemblyName = anno.AssemblyName();
                        var assembly = assemblies.Get(assemblyName);
                        
                        if (assembly == null)
                            assemblies.Put(assemblyName, assembly = new Assembly(assemblyName));

                        assembly.AddType(anno.Type());
                        _typesPerAssembly.Put(anno.Type(), assembly);
                    }
                }
            }

            return _typesPerAssembly.Get(type) ?? DefaultAssembly;
        }

    }
}
