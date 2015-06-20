// Copyright (C) 2014 dot42
//
// Original filename: PropertyInfoProvider.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Util;
using Dot42.Collections.Specialized;
using Java.Util.Concurrent;
using Exception = System.Exception;

namespace Dot42.Internal.ReflectionInfo
{
    /// <summary>
    /// Helper for obtaining PropertyInfos based on attributes.
    /// </summary>
	internal class PropertyInfoProvider 
	{
        internal static readonly PropertyInfo[] Empty = new PropertyInfo[0];
        internal static readonly PropertyInfo[] EmptyError = new PropertyInfo[0];
        internal static readonly PropertyInfo[] None = new PropertyInfo[0];

        private static readonly List<PropertyInfoProvider> Instances;
        private static readonly ConcurrentTypeHashMap<PropertyInfo[]> LoadedProperties = new ConcurrentTypeHashMap<PropertyInfo[]>();

        static PropertyInfoProvider()
        {
            Instances = new List<PropertyInfoProvider> {new PropertyInfoProvider()};
         
            // Try to instantiate FrameworkPropertyInfoProvider.
            // Note that it is no failure if the provider is not available.
            var fwProps = TryCreateClass<PropertyInfoProvider>("dot42.Internal.ReflectionInfo.FrameworkPropertyInfoProvider");
            if (fwProps != null)
                Instances.Add(fwProps);

            Application.ReleaseCaches += (s, e) => LoadedProperties.Clear();
        }

        /// <summary>
        /// Returns an array of all declared properties of this member.
        /// Returns an empty array if no properties are declared on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static PropertyInfo[] GetProperties(Type definingType, Type declaringType)
        {
            var result = LoadedProperties.Get(declaringType);
            if (result != null) 
                return result;

            result = None;

            try
            {
                // Not found, build it
                for(int i = 0; i < Instances.Count && result == None; ++i)
                {
                    result = Instances[i].BuildProperties(definingType, declaringType);
                }
            }
            catch (Exception ex)
            {
                Log.E("dot42", string.Format("unable build property info for class '{0}'",
                                             definingType.FullName), ex);

                result = EmptyError;
            }

            // Store in cache.
            LoadedProperties.Put(declaringType, result);

            return result ;
        }

        /// <summary>
        /// Build all properties for a given definingType.
        /// </summary>
        public virtual PropertyInfo[] BuildProperties(Type definingType, Type declaringType)
        {
            var ann = definingType.GetAnnotation<IProperties>(typeof (IProperties));
            if (ann == null)
                return None;

            var properties = ann.Properties();
            return BuildProperties(definingType, declaringType, properties);
        }

        protected static PropertyInfo[] BuildProperties(Type definingType, Type declaringType, IProperty[] properties, string defGetPrefix=null, string defSetPrefix=null)
        {
            var count = properties.Length;
            if (count == 0)
                return Empty;

            var declTypeMethods = declaringType.GetMethods(Type.BindFlags.AllMembers);
            // Build PropertyInfo structures
            var infos = new PropertyInfo[count];
            for (var i = 0; i < count; i++)
            {
                var p = properties[i];
                var propName = p.Name();

                var getName = !string.IsNullOrEmpty(p.Get()) ? p.Get() : ((defGetPrefix ?? "get_") + propName);
                var setName = !string.IsNullOrEmpty(p.Set()) ? p.Set() : ((defSetPrefix ?? "set_") + propName);

                var getter = declTypeMethods.FirstOrDefault(m => m.JavaMethod.Name == getName && m.JavaMethod.ParameterTypes.Length == 0);
                var setter = declTypeMethods.FirstOrDefault(m => m.JavaMethod.Name == setName 
                                                              && m.JavaMethod.ParameterTypes.Length == 1
                                                              && (getter == null || getter.ReturnType == m.GetParameters()[0].ParameterType));

                if (getter == null && setter == null)
                {
                    Log.E("dot42", "property has neither getter nor setter: " + propName + " / class" + definingType.FullName);
                    // we can not leave an entry in the array null
                    //continue;
                }

                IAttribute[] attributes = p.Attributes();
                infos[i] = new PropertyInfo(declaringType, p.Name(), getter, setter, attributes);
            }
            return infos;
        }

        private static T TryCreateClass<T>(string className) where T : class
        {
            try
            {
                var frameworkProps = typeof(PropertyInfoProvider).GetClassLoader()
                                                                 .LoadClass(className);
                if (frameworkProps == null)
                    return default(T);
                return Activator.CreateInstance(frameworkProps) as T;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

	}
}

