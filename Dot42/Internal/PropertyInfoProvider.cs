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
using System.Linq;
using System.Reflection;
using Android.Util;
using Java.Lang;
using Java.Util;
using Exception = System.Exception;

namespace Dot42.Internal
{
    /// <summary>
    /// Helper for obtaining custom attributes.
    /// </summary>
	internal static class PropertyInfoProvider
	{
        private static readonly PropertyInfo[] Empty = new PropertyInfo[0];
        private static readonly HashMap<Type, PropertyInfo[]> loadedProperties = new HashMap<Type, PropertyInfo[]>();
        private static readonly object dataLock = new object();

        /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        internal static PropertyInfo[] GetProperties(Type type)
        {
            PropertyInfo[] result;
            lock (dataLock)
            {
                result = loadedProperties.Get(type);
                if (result != null) return result;
            }
            try
            {
                // Not found, build it
                result = BuildProperties(type);
            }
            catch (Exception ex)
            {
                Log.E("dot42", string.Format("unable create property info from annotation for class '{0}'",
                                             type.FullName), ex);

                result = new PropertyInfo[0];
            }

            // Store in loaded map
            lock (dataLock)
            {
                loadedProperties.Put(type, result);
            }

            return result;
        }

        /// <summary>
        /// Build all properties for a given type.
        /// </summary>
        private static PropertyInfo[] BuildProperties(Type type)
        {
            var ann = type.GetAnnotation<IProperties>(typeof (IProperties));
            if (ann == null) return Empty;

            var properties = ann.Properties();
            var count = properties.Length;
            if (count == 0) return Empty;

            // Build PropertyInfo structures
            var infos = new PropertyInfo[count];
            for (var i = 0; i < count; i++)
            {
                var p = properties[i];
                var propName = p.Name();

                var getName = !string.IsNullOrEmpty(p.Get()) ? p.Get() : ("get_" + propName);
                var setName = !string.IsNullOrEmpty(p.Set()) ? p.Set() : ("set_" + propName);

                JavaMethod getter = null, setter = null;
                try
                {
                    getter = type.JavaGetDeclaredMethod(getName);
                }
                catch (MissingMethodException )
                {
                }

                try
                {
                    setter = type.JavaGetDeclaredMethods().FirstOrDefault(m => m.Name == setName && m.ParameterTypes.Length == 1);
                }
                catch (MissingMethodException)
                {
                }

                if (getter == null && setter == null)
                {
                    Log.E("dot42", "property has neither getter nor setter: " + propName + " / class" + type.FullName);
                    continue;
                }

                //var attributes = p.Attributes();
                infos[i] = new PropertyInfo(type, p.Name(),
                                            getter != null?new MethodInfo(getter):null, 
                                            setter != null?new MethodInfo(setter):null, 
                                            new IAttribute[0]);
            }
            return infos;
        }
	}
}

