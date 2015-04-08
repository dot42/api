// Copyright (C) 2014 dot42
//
// Original filename: Activator.cs
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

using System.Collections.Generic;
using System.Linq;
using Dot42.Internal;
using Dot42.Internal.Generics;
using Dot42;
using Java.Lang.Reflect;

namespace System
{
	public sealed class Activator
	{
        /// <summary>
        /// Create an instance of the given type using it's default constructor.
        /// </summary>
        public static object CreateInstance(Type type)
        {
            if (NullableReflection.TreatAsSystemNullableT(type))
                return null;

            var genericInstance = GenericInstanceFactory.CreateGenericInstance(type);
            if (genericInstance != null) 
                return genericInstance;

            return  type.NewInstance();
        }

        /// <summary>
        /// Create an instance of the given type using the best matching constructor.
        /// </summary>
        public static object CreateInstance(Type type, params object[] args)
        {
            if (NullableReflection.TreatAsSystemNullableT(type))
                return null;

            var genericInstance = GenericInstanceFactory.CreateGenericInstance(type, args);
            if (genericInstance != null)
                return genericInstance;

            var constructor = GetBestMatchingConstructor(type, args);

            return constructor.NewInstance(args);
        }

        /// <summary>
        /// Create an instance of the given type T using it's default constructor.
        /// </summary>
        public static T CreateInstance<T>()
        {
            if (NullableReflection.TreatAsSystemNullableT(typeof(T)))
                return default(T);

            return (T)typeof(T).NewInstance();
        }

        /// <summary>
        /// throws MissingMethodsException atm, if a constructor could not be found.
        /// </summary>
	    internal static Constructor GetBestMatchingConstructor(Type type, object[] args)
	    {
            List<Tuple<Constructor, int>> matches = new List<Tuple<Constructor, int>>();
        
            // this code does not take into account nullable structs.
            // this could be provided as well easily, if anybody ever cares...

	        foreach (var c in type.JavaGetDeclaredConstructors())
	        {
	            var cargs = c.ParameterTypes;
                if(cargs.Length != args.Length) 
                    continue;

	            int match = 0;
	            for (int i = 0; i < args.Length; ++i)
	            {
	                if (args[i] == null)
	                {
	                    if (cargs[i].IsValueType)
	                        goto nomatch;
                        continue;
	                }

	                var argType = args[i].GetType();

	                if (cargs[i] == argType)
	                    match += 3;
                    else if (cargs[i].IsAssignableFrom(argType))
                        match += 1;
                    else if (cargs[i].IsAssignableFrom(TypeHelper.EnsurePrimitiveType(type)))
                        match += 2;
                    else
                        goto nomatch;
	            }
                
                matches.Add(Tuple.Create(c, match));
                
            nomatch:;
	        }

	        var bestMatch =  matches.OrderByDescending(p => p.Item2)
                                    .Select(p => p.Item1)
                                    .FirstOrDefault();

            if (bestMatch != null) 
                return bestMatch;

            var argumentTypes = args.Select(a => a == null 
                                                ? "null"
                                                : a.JavaGetClass().FullName);
            string msg = string.Format("Could not find a matching constructor for type {0}({1})", type.FullName, string.Join(",", argumentTypes));
            throw new MissingMethodException(msg);
	    }
    }
}

