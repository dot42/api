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
using Java.Lang.Reflect;
using Java.Util;

namespace Dot42.Internal
{
    /// <summary>
    /// Helper for obtaining custom attributes.
    /// </summary>
	internal static class CustomAttributeProvider
	{
        private static readonly HashMap<IAttribute, Attribute> loadedAttributes = new HashMap<IAttribute, Attribute>();
        private static readonly object dataLock = new object();

        /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public static object[] GetCustomAttributes(IAnnotatedElement member, bool inherit)
        {
            var attributes = GetAttributes(member, inherit);
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
            if (attributes == null)
                return new object[0];
            var list = new ArrayList<object>();
            foreach (var attr in attributes.Attributes())
            {
                if (Equals(attr.AttributeType(), attributeType))
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
            if (attributes == null)
                return false;
            foreach (var attr in attributes.Attributes())
            {
                if (Equals(attr.AttributeType(), attributeType))
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
            var provider = member as IAttributesProvider;
            if (provider != null) return provider.Attributes();
            return member.GetAnnotation<IAttributes>(typeof(IAttributes));
        }

        /// <summary>
        /// Gets a custom attribute from cache or build it.
        /// </summary>
        private static Attribute GetAttribute(IAttribute attr)
        {
            Attribute result;
            lock (dataLock)
            {
                result = loadedAttributes.Get(attr);
                if (result != null) return result;
            }

            // Not found, build it
            var builder = attr.AttributeBuilder();
            result = (Attribute) builder.Invoke(null, new[] { attr.Annotation() });

            // Store in loaded map
            lock (dataLock)
            {
                loadedAttributes.Put(attr, result);
            }

            return result;
        }
	}
}

