// Copyright (C) 2014 dot42
//
// Original filename: Object.cs
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
using System.ComponentModel;
using Dot42;
using Dot42.Internal;
using Dot42.Internal.Generics;

namespace System
{
	partial class Object
	{
        /// <summary>
        /// Are both arguments the same instance.
        /// </summary>
        [DexNative]
        public extern static bool ReferenceEquals(Object objA, Object objB);

        /// <summary>
        /// Are both instances considered equal?
        /// </summary>
        public static bool Equals(object a, object b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.Equals(b);
        }

        /// <summary>
        /// <para>Returns the unique instance of Class that represents this object's class. Note that <c> getClass() </c> is a special case in that it actually returns <c> Class&lt;? extends Foo&gt; </c> where <c> Foo </c> is the erasure of the type of the expression <c> getClass() </c> was called upon. </para><para>As an example, the following code actually compiles, although one might think it shouldn't: </para><para><pre>         List&lt;Integer&gt; l = new ArrayList&lt;Integer&gt;();
        /// 
        ///          Class&lt;? extends List&gt; c = l.getClass(); 
        /// 
        ///  </pre></para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>this object's <c> Class </c> instance. </para>
        /// </returns>
        /// <java-name>
        /// getClass
        /// </java-name>
        [Dot42.DexImport("getClass", "()Ljava/lang/Class;", AccessFlags = 273, Signature = "()Ljava/lang/Class<*>;")]
	    public Type GetType()
	    {
	        return JavaGetClass();
	    }

        /// <summary>
        /// In contrast to GetType(), which returns the Java-Runtime type, this method
        /// returns a type tht can properly be used in reflection: Boxed types return their 
        /// primitive counterparts, and generic instances have their proper generic 
        /// information.
        /// </summary>
        public Type GetTypeReflectionSafe()
	    {
            // We have to make sure we return the correct primitive type
            // if the object was boxed.
            //

	        var type = JavaGetClass();

	        if (type == TypeHelper.BooleanType())
	            return typeof (bool);
            if (type == TypeHelper.CharacterType())
                return typeof(char);
            if (type == TypeHelper.ByteType())
                return typeof(byte);
            if (type == TypeHelper.ShortType())
                return typeof(short);
            if (type == TypeHelper.IntegerType())
                return typeof(int);
            if (type == TypeHelper.LongType())
                return typeof(long);
            if (type == TypeHelper.FloatType())
                return typeof(float);
            if (type == TypeHelper.DoubleType())
                return typeof(double);

            return GenericsReflection.GetReflectionSafeType(type, this);
	    }


        /// <summary>
        /// Create a memberwise clone of this object.
        /// </summary>
        /// <returns></returns>
        [Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
        protected virtual object MemberwiseClone()
        {
            return default(object);
        }
	}
}

namespace Java.Lang
{
    /// <summary>
    /// This is the same as System.Object.
    /// </summary>
    [Dot42.DexImport("java/lang/Object", IgnoreFromJava = true, Priority = 1)]
    [Obsolete("use System.Object")]
    public partial class Object : global::System.Object
    {
        [Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
        public Object() /* MethodBuilder.Create */
        {
        }
    }
}

