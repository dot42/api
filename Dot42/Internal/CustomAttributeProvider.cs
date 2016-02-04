// Copyright (C) 2014 dot42
//
// Original filename: CustomAttributeProvider.cs
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
using System.Reflection;
using Android.Util;
using Java.Lang.Reflect;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
    /// <summary>
    /// Helper for obtaining custom attributes.
    /// </summary>
	internal static class CustomAttributeProvider
	{
        /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static object[] GetCustomAttributes(IAnnotatedElement member, bool inherit)
        {
            var attributes = GetAttributes(member, inherit);
            return GetCustomAttributes(attributes);
        }

        /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static object[] GetCustomAttributes(IAttributesProvider member, bool inherit)
        {
            return GetCustomAttributes(member.Attributes());
        }

        private static object[] GetCustomAttributes(IAttributes attributes)
        {
            if (attributes == null)
                return new object[0];
            var list = new ArrayList<object>();
            foreach (var attr in attributes.Attributes())
            {
                list.Add(GetAttribute(attr));
            }
            return list.ToArray();
        }

        /// <summary>
        /// Returns an array of all attributes defined on this member of the given attribute type.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static object[] GetCustomAttributes(IAnnotatedElement member, Type attributeType, bool inherit)
        {
            var attributes = GetAttributes(member, inherit);
            return GetCustomAttributes(attributeType, attributes);
        }

        /// <summary>
        /// Returns an array of all attributes defined on this member of the given attribute type.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.[note: this parameter is ignored]</param>
        public static object[] GetCustomAttributes(IAttributesProvider member, Type attributeType, bool inherit)
        {
            var attributes = member.Attributes();
            return GetCustomAttributes(attributeType, attributes);
        }

        private static object[] GetCustomAttributes(Type attributeType, IAttributes attributes)
        {
            if (attributes == null)
                return new object[0];
            var list = new ArrayList<object>();

            foreach (var attr in attributes.Attributes())
            {
                if (attributeType.JavaIsAssignableFrom(attr.AttributeType()))
                {
                    list.Add(GetAttribute(attr));
                }
            }
            return list.ToArray();
        }

        /// <summary>
        /// are one or more attributes of the given type defined on this member.
        /// </summary>
        /// <param name="attributeType">The type of the custom attribute</param>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static bool IsDefined(IAnnotatedElement member, Type attributeType, bool inherit)
        {
            var attributes = GetAttributes(member, inherit);
            return IsDefined(attributeType, attributes);
        }

        /// <summary>
        /// are one or more attributes of the given type defined on this member.
        /// </summary>
        /// <param name="attributeType">The type of the custom attribute</param>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static bool IsDefined(IAttributesProvider member, Type attributeType, bool inherit)
        {
            var attributes = member.Attributes();
            return IsDefined(attributeType, attributes);
        }

        private static bool IsDefined(Type attributeType, IAttributes attributes)
        {
            if (attributes == null)
                return false;

            foreach (var attr in attributes.Attributes())
            {
                if (attributeType.JavaIsAssignableFrom(attr.AttributeType()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the IAttributes annotation declared in the given member (if any).
        /// </summary>
        private static IAttributes GetAttributes(IAnnotatedElement member, bool inherit)
        {
            try
            {
                return member.GetAnnotation<IAttributes>(typeof(IAttributes));
            }
            catch (Exception ex)
            {
                Log.E("dot42", string.Format("unable to retrieve CustomAttributes for '{0}'",
                             member), ex);

                return null;
            }
            
        }

        /// <summary>
        /// build a custom ttribute
        /// </summary>
        private static Attribute GetAttribute(IAttribute attr)
        {
            // This code used to return a cached instance if available.
            // While this might or might not provide a slight performance
            // advantage, it breaks the attribute contract. Even though
            // a caller might modify a returned attribute, each succeeding
            // caller must get an unmodified instance of the attribute nonetheless.
            
            // I also believe that there is little to no measurable performance 
            // benefit in caching, as the neccessary thread safety is not cheap anyway.
            // Furthermore, everybody relying heavily on reflection does his own
            // caching anyway.

            Type attributeType = attr.AttributeType();
            string factoryName = attr.FactoryMethod();

            Attribute result;
            try
            {
                var factoryMethod = attributeType.JavaGetDeclaredMethod(factoryName);
                result = (Attribute)factoryMethod.Invoke(null);
            }
            catch (TargetInvocationException ex)
            {
                Log.E("dot42", string.Format("unable create attribute from annotation. build class '{0}' / method '{1}'",
                                             attributeType.FullName, factoryName), ex.InnerException);
                result = new Attribute();
            }
            catch (Exception ex)
            {
                Log.E("dot42", string.Format("unable create attribute from annotation. build class '{0}' / method '{1}'",
                                             attributeType.FullName, factoryName), ex.InnerException);
                result = new Attribute();
            }

            return result;
        }
	}
}

