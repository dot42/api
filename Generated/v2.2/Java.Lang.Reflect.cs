// Copyright (C) 2014 dot42
//
// Original filename: Java.Lang.Reflect.cs
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
#pragma warning disable 1717
namespace Java.Lang.Reflect
{
		/// <summary>
		/// <para>Provides static methods to create and access arrays dynamically. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Array
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Array", AccessFlags = 49)]
		public sealed partial class Array
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Array() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the element of the array at the specified index. Equivalent to <c> array[index] </c> . If the array component is a primitive type, the result is automatically boxed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;I)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Get(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the boolean at the given index in the given boolean array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/Object;I)Z", AccessFlags = 9)]
				public static bool GetBoolean(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte at the given index in the given byte array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;I)B", AccessFlags = 9)]
				public static sbyte JavaGetByte(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns the byte at the given index in the given byte array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;I)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetByte(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Returns the char at the given index in the given char array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/Object;I)C", AccessFlags = 9)]
				public static char GetChar(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the double at the given index in the given array. Applies to byte, char, float, double, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/Object;I)D", AccessFlags = 9)]
				public static double GetDouble(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the float at the given index in the given array. Applies to byte, char, float, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/Object;I)F", AccessFlags = 9)]
				public static float GetFloat(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the int at the given index in the given array. Applies to byte, char, int, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/Object;I)I", AccessFlags = 9)]
				public static int GetInt(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the length of the array. Equivalent to <c> array.length </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "(Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int GetLength(object array) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the long at the given index in the given array. Applies to byte, char, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/Object;I)J", AccessFlags = 9)]
				public static long GetLong(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the short at the given index in the given array. Applies to byte and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/Object;I)S", AccessFlags = 9)]
				public static short GetShort(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;[I)Ljava/lang/Object;")]
				public static object NewInstance(global::System.Type type, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;I)Ljava/lang/Object;")]
				public static object NewInstance(global::System.Type type, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the element of the array at the specified index to the value. Equivalent to <c> array[index] = value </c> . If the array component is a primitive type, the value is automatically unboxed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;ILjava/lang/Object;)V", AccessFlags = 9)]
				public static void Set(object array, int index, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to boolean arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;IZ)V", AccessFlags = 9)]
				public static void SetBoolean(object array, int index, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to byte, double, float, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9)]
				public static void SetByte(object array, int index, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to byte, double, float, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void SetByte(object array, int index, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to char, double, float, int, and long arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;IC)V", AccessFlags = 9)]
				public static void SetChar(object array, int index, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to double arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;ID)V", AccessFlags = 9)]
				public static void SetDouble(object array, int index, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to double and float arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;IF)V", AccessFlags = 9)]
				public static void SetFloat(object array, int index, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to double, float, int, and long arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void SetInt(object array, int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to double, float, and long arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;IJ)V", AccessFlags = 9)]
				public static void SetLong(object array, int index, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets <c> array[index] = value </c> . Applies to double, float, int, long, and short arrays.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/Object;IS)V", AccessFlags = 9)]
				public static void SetShort(object array, int index, short value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This interface represents a type variables such as <c> 'T' </c> in <c>   'public interface Comparable&lt;T&gt;' </c> , the bounded <c> 'T' </c> in <c>   'public interface A&lt;T extends Number&gt;' </c> or the multiple bounded <c>   'T' </c> in <c> 'public interface B&lt;T extends Number &amp; Cloneable&gt;' </c> .</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/TypeVariable
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/TypeVariable", AccessFlags = 1537, Signature = "<D::Ljava/lang/reflect/GenericDeclaration;>Ljava/lang/Object;Ljava/lang/reflect/T" +
    "ype;")]
		public partial interface ITypeVariable<D> : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the upper bounds of this type variable. <c> Object </c> is the implicit upper bound if no other bounds are declared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the upper bounds of this type variable</para>
				/// </returns>
				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetBounds() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the language construct that declares this type variable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generic declaration </para>
				/// </returns>
				/// <java-name>
				/// getGenericDeclaration
				/// </java-name>
				[Dot42.DexImport("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", AccessFlags = 1025, Signature = "()TD;")]
				D GetGenericDeclaration() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of this type variable as it is specified in source code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this type variable </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Implementors of this interface dispatch methods invoked on proxy instances.</para><para><para>Proxy </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/InvocationHandler
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationHandler", AccessFlags = 1537)]
		public partial interface IInvocationHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Handles the method which was originally invoked on the proxy instance. A typical usage pattern follows below:</para><para><pre>
				///        public Object invoke(Object proxy, Method method, Object[] args) throws Throwable {
				///            //do some processing before the method invocation
				/// 
				///            //invoke the method
				///            Object result = method.invoke(proxy, args);
				/// 
				///            //do some processing after the method invocation
				///            return result;
				///        }</pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result of executing the method. Primitive types are boxed.</para>
				/// </returns>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Objec" +
    "t;", AccessFlags = 1025)]
				object Invoke(object proxy, global::System.Reflection.MethodInfo method, object[] args) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Common interface implemented by all Java types.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Type
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Type", AccessFlags = 1537)]
		public partial interface IType
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>This interface represents a parameterized type such as <c>   'Set&amp;lt;String&amp;gt;' </c> .</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/ParameterizedType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ParameterizedType", AccessFlags = 1537)]
		public partial interface IParameterizedType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns an array of the actual type arguments for this type. </para><para>If this type models a non parameterized type nested within a parameterized type, this method returns a zero length array. The generic type of the following <c> field </c> declaration is an example for a parameterized type without type arguments.</para><para><pre>
				///        A&lt;String&gt;.B field;
				/// 
				///        class A&lt;T&gt; {
				///            class B {
				///            }
				///        }</pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the actual type arguments</para>
				/// </returns>
				/// <java-name>
				/// getActualTypeArguments
				/// </java-name>
				[Dot42.DexImport("getActualTypeArguments", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetActualTypeArguments() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parent / owner type, if this type is an inner type, otherwise <c> null </c> is returned if this is a top-level type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the owner type or <c> null </c> if this is a top-level type</para>
				/// </returns>
				/// <java-name>
				/// getOwnerType
				/// </java-name>
				[Dot42.DexImport("getOwnerType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetOwnerType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the declaring type of this parameterized type. </para><para>The raw type of <c> Set&lt;String&gt; field; </c> is <c> Set </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the raw type of this parameterized type </para>
				/// </returns>
				/// <java-name>
				/// getRawType
				/// </java-name>
				[Dot42.DexImport("getRawType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetRawType() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class provides a wrapper for an undeclared, checked exception thrown by an InvocationHandler.</para><para><para>java.lang.reflect.InvocationHandler::invoke </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/UndeclaredThrowableException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/UndeclaredThrowableException", AccessFlags = 33)]
		public partial class UndeclaredThrowableException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> UndeclaredThrowableException </c> instance with the undeclared, checked exception that occurred.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> UndeclaredThrowableException </c> instance with the undeclared, checked exception that occurred and a message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception, string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the undeclared, checked exception that occurred, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the undeclared, checked exception that occurred </para>
				/// </returns>
				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetUndeclaredThrowable() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the undeclared, checked exception that occurred, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the undeclared, checked exception that occurred </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public override global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UndeclaredThrowableException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the undeclared, checked exception that occurred, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the undeclared, checked exception that occurred </para>
				/// </returns>
				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				public global::System.Exception UndeclaredThrowable
				{
				[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetUndeclaredThrowable(); }
				}

		}

		/// <summary>
		/// <para><c> Proxy </c> defines methods for creating dynamic proxy classes and instances. A proxy class implements a declared set of interfaces and delegates method invocations to an <c> InvocationHandler </c> .</para><para><para>InvocationHandler </para><para>1.3 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Proxy
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Proxy", AccessFlags = 33)]
		public partial class Proxy : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The invocation handler on which the method calls are dispatched. </para>        
				/// </summary>
				/// <java-name>
				/// h
				/// </java-name>
				[Dot42.DexImport("h", "Ljava/lang/reflect/InvocationHandler;", AccessFlags = 4)]
				protected internal global::Java.Lang.Reflect.IInvocationHandler H;
				/// <summary>
				/// <para>Constructs a new <c> Proxy </c> instance with the specified invocation handler.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/InvocationHandler;)V", AccessFlags = 4)]
				protected internal Proxy(global::Java.Lang.Reflect.IInvocationHandler h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the dynamically built <c> Class </c> for the specified interfaces. Creates a new <c> Class </c> when necessary. The order of the interfaces is relevant. Invocations of this method with the same interfaces but different order result in different generated classes. The interfaces must be visible from the supplied class loader; no duplicates are permitted. All non-public interfaces must be defined in the same package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a proxy class that implements all of the interfaces referred to in the contents of <c> interfaces </c> </para>
				/// </returns>
				/// <java-name>
				/// getProxyClass
				/// </java-name>
				[Dot42.DexImport("getProxyClass", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;", AccessFlags = 137, Signature = "(Ljava/lang/ClassLoader;[Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
				public static global::System.Type GetProxyClass(global::Java.Lang.ClassLoader loader, params global::System.Type[] interfaces) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an instance of the dynamically built class for the specified interfaces. Method invocations on the returned instance are forwarded to the specified invocation handler. The interfaces must be visible from the supplied class loader; no duplicates are permitted. All non-public interfaces must be defined in the same package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new proxy object that delegates to the handler <c> h </c> </para>
				/// </returns>
				/// <java-name>
				/// newProxyInstance
				/// </java-name>
				[Dot42.DexImport("newProxyInstance", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)L" +
    "java/lang/Object;", AccessFlags = 9, Signature = "(Ljava/lang/ClassLoader;[Ljava/lang/Class<*>;Ljava/lang/reflect/InvocationHandler" +
    ";)Ljava/lang/Object;")]
				public static object NewProxyInstance(global::Java.Lang.ClassLoader loader, global::System.Type[] interfaces, global::Java.Lang.Reflect.IInvocationHandler h) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified class is a dynamically generated proxy class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the class is a proxy class, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isProxyClass
				/// </java-name>
				[Dot42.DexImport("isProxyClass", "(Ljava/lang/Class;)Z", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Z")]
				public static bool IsProxyClass(global::System.Type cl) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the invocation handler of the specified proxy instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the invocation handler of the specified proxy instance </para>
				/// </returns>
				/// <java-name>
				/// getInvocationHandler
				/// </java-name>
				[Dot42.DexImport("getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;", AccessFlags = 9)]
				public static global::Java.Lang.Reflect.IInvocationHandler GetInvocationHandler(object proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IInvocationHandler);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Proxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Indicates that a malformed signature has been encountered via a reflective method.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericSignatureFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericSignatureFormatError", AccessFlags = 33)]
		public partial class GenericSignatureFormatError : global::Java.Lang.ClassFormatError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> GenericSignatureFormatError </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GenericSignatureFormatError() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides a wrapper for an exception thrown by a <c> Method </c> or <c> Constructor </c> invocation.</para><para><para>Method::invoke </para><simplesectsep></simplesectsep><para>Constructor::newInstance </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/InvocationTargetException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationTargetException", AccessFlags = 33)]
		public partial class InvocationTargetException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> InvocationTargetException </c> instance with a <c> null </c> cause / target exception. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal InvocationTargetException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> InvocationTargetException </c> instance with its cause / target exception filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvocationTargetException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> InvocationTargetException </c> instance with its cause / target exception and message filled in.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public InvocationTargetException(global::System.Exception exception, string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the target exception, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target exception </para>
				/// </returns>
				/// <java-name>
				/// getTargetException
				/// </java-name>
				[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetTargetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the cause of this exception, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cause of this exception </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public override global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the target exception, which may be <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the target exception </para>
				/// </returns>
				/// <java-name>
				/// getTargetException
				/// </java-name>
				public global::System.Exception TargetException
				{
				[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetTargetException(); }
				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/ReflectPermission
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ReflectPermission", AccessFlags = 49)]
		public sealed partial class ReflectPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ReflectPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ReflectPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ReflectPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Common interface providing access to reflective information on class members.</para><para><para>Field </para><simplesectsep></simplesectsep><para>Constructor </para><simplesectsep></simplesectsep><para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMemberConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Designates all public members of a class or interface (including inherited members). </para>        
				/// </summary>
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 0;
				/// <summary>
				/// <para>Designates all declared members of a class or interface (without inherited members). </para>        
				/// </summary>
				/// <java-name>
				/// DECLARED
				/// </java-name>
				[Dot42.DexImport("DECLARED", "I", AccessFlags = 25)]
				public const int DECLARED = 1;
		}

		/// <summary>
		/// <para>Common interface providing access to reflective information on class members.</para><para><para>Field </para><simplesectsep></simplesectsep><para>Constructor </para><simplesectsep></simplesectsep><para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537)]
		public partial interface IMember
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the class that declares this member.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1025)]
				global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the modifiers for this member. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this member</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1025)]
				int GetModifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of this member.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this member </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this member is synthetic (artificially introduced by the compiler).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this member is synthetic, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1025)]
				bool IsSynthetic() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A pattern type, such as the upper bounded wildcard <c>   ? extends Closeable </c> or the lower bounded wildcard <c> ? super String </c> .</para><para>Although this interface permits an arbitrary number of upper and lower bounds, all wildcard types of Java language programs are in one of two forms: <ol><li><para><b>No lower bound and one upper bound.</b> Such types are written like <c> ? extends java.lang.Number </c> . When the upper bound is <c> java.lang.Object </c> , the <c> extends java.lang.Object </c> suffix is optional: <c> Set&lt;?&gt; </c> is shorthand for <c>       Set&lt;? extends java.lang.Object&gt; </c> . </para></li><li><para><b>One lower bound and an upper bound of <c>       java.lang.Object </c> .</b> Such types are written like <c>       ? super java.lang.String </c> . </para></li></ol></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/WildcardType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/WildcardType", AccessFlags = 1537)]
		public partial interface IWildcardType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the array of types that represent the upper bounds of this type. The default upper bound is <c> Object </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array containing the upper bounds types</para>
				/// </returns>
				/// <java-name>
				/// getUpperBounds
				/// </java-name>
				[Dot42.DexImport("getUpperBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetUpperBounds() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the array of types that represent the lower bounds of this type. The default lower bound is <c> null </c> , in which case an empty array is returned. Since only one lower bound is allowed, the returned array's length will never exceed one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array containing the lower bounds types</para>
				/// </returns>
				/// <java-name>
				/// getLowerBounds
				/// </java-name>
				[Dot42.DexImport("getLowerBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetLowerBounds() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates that a malformed parameterized type has been encountered by a reflective method.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/MalformedParameterizedTypeException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/MalformedParameterizedTypeException", AccessFlags = 33)]
		public partial class MalformedParameterizedTypeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> MalformedParameterizedTypeException </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedParameterizedTypeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides static methods to decode class and member modifiers.</para><para><para>Class::getModifiers() </para><simplesectsep></simplesectsep><para>Member::getModifiers() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Modifier
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Modifier", AccessFlags = 33)]
		public partial class Modifier
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> public </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 1;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> private </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PRIVATE
				/// </java-name>
				[Dot42.DexImport("PRIVATE", "I", AccessFlags = 25)]
				public const int PRIVATE = 2;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> protected </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTED
				/// </java-name>
				[Dot42.DexImport("PROTECTED", "I", AccessFlags = 25)]
				public const int PROTECTED = 4;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> static </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// STATIC
				/// </java-name>
				[Dot42.DexImport("STATIC", "I", AccessFlags = 25)]
				public const int STATIC = 8;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> final </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// FINAL
				/// </java-name>
				[Dot42.DexImport("FINAL", "I", AccessFlags = 25)]
				public const int FINAL = 16;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> synchronized </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// SYNCHRONIZED
				/// </java-name>
				[Dot42.DexImport("SYNCHRONIZED", "I", AccessFlags = 25)]
				public const int SYNCHRONIZED = 32;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> volatile </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// VOLATILE
				/// </java-name>
				[Dot42.DexImport("VOLATILE", "I", AccessFlags = 25)]
				public const int VOLATILE = 64;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> transient </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIENT
				/// </java-name>
				[Dot42.DexImport("TRANSIENT", "I", AccessFlags = 25)]
				public const int TRANSIENT = 128;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> native </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// NATIVE
				/// </java-name>
				[Dot42.DexImport("NATIVE", "I", AccessFlags = 25)]
				public const int NATIVE = 256;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> interface </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// INTERFACE
				/// </java-name>
				[Dot42.DexImport("INTERFACE", "I", AccessFlags = 25)]
				public const int INTERFACE = 512;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> abstract </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// ABSTRACT
				/// </java-name>
				[Dot42.DexImport("ABSTRACT", "I", AccessFlags = 25)]
				public const int ABSTRACT = 1024;
				/// <summary>
				/// <para>The <c> int </c> value representing the <c> strict </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// STRICT
				/// </java-name>
				[Dot42.DexImport("STRICT", "I", AccessFlags = 25)]
				public const int STRICT = 2048;
				/// <summary>
				/// <para>Constructs a new <c> Modifier </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Modifier() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       abstract </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               abstract </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAbstract
				/// </java-name>
				[Dot42.DexImport("isAbstract", "(I)Z", AccessFlags = 9)]
				public static bool IsAbstract(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       final </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               final </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isFinal
				/// </java-name>
				[Dot42.DexImport("isFinal", "(I)Z", AccessFlags = 9)]
				public static bool IsFinal(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       interface </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               interface </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isInterface
				/// </java-name>
				[Dot42.DexImport("isInterface", "(I)Z", AccessFlags = 9)]
				public static bool IsInterface(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       native </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               native </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isNative
				/// </java-name>
				[Dot42.DexImport("isNative", "(I)Z", AccessFlags = 9)]
				public static bool IsNative(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       private </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               private </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPrivate
				/// </java-name>
				[Dot42.DexImport("isPrivate", "(I)Z", AccessFlags = 9)]
				public static bool IsPrivate(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       protected </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               protected </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isProtected
				/// </java-name>
				[Dot42.DexImport("isProtected", "(I)Z", AccessFlags = 9)]
				public static bool IsProtected(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       public </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               public </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPublic
				/// </java-name>
				[Dot42.DexImport("isPublic", "(I)Z", AccessFlags = 9)]
				public static bool IsPublic(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       static </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               static </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStatic
				/// </java-name>
				[Dot42.DexImport("isStatic", "(I)Z", AccessFlags = 9)]
				public static bool IsStatic(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       strict </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               strict </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStrict
				/// </java-name>
				[Dot42.DexImport("isStrict", "(I)Z", AccessFlags = 9)]
				public static bool IsStrict(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       synchronized </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               synchronized </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynchronized
				/// </java-name>
				[Dot42.DexImport("isSynchronized", "(I)Z", AccessFlags = 9)]
				public static bool IsSynchronized(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       transient </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               transient </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTransient
				/// </java-name>
				[Dot42.DexImport("isTransient", "(I)Z", AccessFlags = 9)]
				public static bool IsTransient(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified modifiers contain the <c>       volatile </c> modifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified modifiers contain the <c>               volatile </c> modifier, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isVolatile
				/// </java-name>
				[Dot42.DexImport("isVolatile", "(I)Z", AccessFlags = 9)]
				public static bool IsVolatile(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing the string representation of all modifiers present in the specified modifiers. Modifiers appear in the order specified by the Java Language Specification:</para><para><c> public private protected abstract static final transient volatile native synchronized interface strict </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of the modifiers </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>This interface provides reflective access to annotation information.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/AnnotatedElement
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AnnotatedElement", AccessFlags = 1537)]
		public partial interface IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns, for this element, the annotation with the specified type, or <c> null </c> if no annotation with the specified type is present (including inherited annotations).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the annotation with the specified type or <c> null </c> </para>
				/// </returns>
				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T GetAnnotation<T>(global::System.Type annotationType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns, for this element, an array containing all annotations (including inherited annotations). If there are no annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of all annotations for this element </para>
				/// </returns>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the annotation exists, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1025, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Common interface for language constructs that declare type parameters.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericDeclaration
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericDeclaration", AccessFlags = 1537)]
		public partial interface IGenericDeclaration
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1025, Signature = "()[Ljava/lang/reflect/TypeVariable<*>;")]
				global::Java.Lang.Reflect.ITypeVariable<object>[] GetTypeParameters() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This interface represents an array type with a component type that is either a parameterized type or a type variable.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericArrayType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericArrayType", AccessFlags = 1537)]
		public partial interface IGenericArrayType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the component type of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the component type of this array</para>
				/// </returns>
				/// <java-name>
				/// getGenericComponentType
				/// </java-name>
				[Dot42.DexImport("getGenericComponentType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetGenericComponentType() /* MethodBuilder.Create */ ;

		}

}


