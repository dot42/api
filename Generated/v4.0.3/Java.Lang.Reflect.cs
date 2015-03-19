#pragma warning disable 1717
namespace Java.Lang.Reflect
{
		/// <java-name>
		/// java/lang/reflect/InvocationTargetException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationTargetException", AccessFlags = 33)]
		public partial class InvocationTargetException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal InvocationTargetException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvocationTargetException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public InvocationTargetException(global::System.Exception exception, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetException
				/// </java-name>
				[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetTargetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public override global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getTargetException
				/// </java-name>
				public global::System.Exception TargetException
				{
				[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetTargetException(); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/GenericSignatureFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericSignatureFormatError", AccessFlags = 33)]
		public partial class GenericSignatureFormatError : global::Java.Lang.ClassFormatError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GenericSignatureFormatError() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/reflect/MalformedParameterizedTypeException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/MalformedParameterizedTypeException", AccessFlags = 33)]
		public partial class MalformedParameterizedTypeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedParameterizedTypeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/reflect/TypeVariable
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/TypeVariable", AccessFlags = 1537, Signature = "<D::Ljava/lang/reflect/GenericDeclaration;>Ljava/lang/Object;Ljava/lang/reflect/T" +
    "ype;")]
		public partial interface ITypeVariable<D> : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetBounds() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGenericDeclaration
				/// </java-name>
				[Dot42.DexImport("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", AccessFlags = 1025, Signature = "()TD;")]
				D GetGenericDeclaration() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;I)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Get(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/Object;I)Z", AccessFlags = 9)]
				public static bool GetBoolean(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;I)B", AccessFlags = 9)]
				public static sbyte JavaGetByte(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;I)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetByte(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/Object;I)C", AccessFlags = 9)]
				public static char GetChar(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/Object;I)D", AccessFlags = 9)]
				public static double GetDouble(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/Object;I)F", AccessFlags = 9)]
				public static float GetFloat(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/Object;I)I", AccessFlags = 9)]
				public static int GetInt(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "(Ljava/lang/Object;)I", AccessFlags = 9)]
				public static int GetLength(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/Object;I)J", AccessFlags = 9)]
				public static long GetLong(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/Object;I)S", AccessFlags = 9)]
				public static short GetShort(object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;", AccessFlags = 137, Signature = "(Ljava/lang/Class<*>;[I)Ljava/lang/Object;")]
				public static object NewInstance(global::System.Type type, params int[] int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;ILjava/lang/Object;)V", AccessFlags = 9)]
				public static void Set(object @object, int int32, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;IZ)V", AccessFlags = 9)]
				public static void SetBoolean(object @object, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9)]
				public static void SetByte(object @object, int int32, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void SetByte(object @object, int int32, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;IC)V", AccessFlags = 9)]
				public static void SetChar(object @object, int int32, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;ID)V", AccessFlags = 9)]
				public static void SetDouble(object @object, int int32, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;IF)V", AccessFlags = 9)]
				public static void SetFloat(object @object, int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void SetInt(object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;IJ)V", AccessFlags = 9)]
				public static void SetLong(object @object, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/Object;IS)V", AccessFlags = 9)]
				public static void SetShort(object @object, int int32, short int16) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/reflect/UndeclaredThrowableException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/UndeclaredThrowableException", AccessFlags = 33)]
		public partial class UndeclaredThrowableException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetUndeclaredThrowable() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

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

				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				public global::System.Exception UndeclaredThrowable
				{
				[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetUndeclaredThrowable(); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/WildcardType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/WildcardType", AccessFlags = 1537)]
		public partial interface IWildcardType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getUpperBounds
				/// </java-name>
				[Dot42.DexImport("getUpperBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetUpperBounds() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLowerBounds
				/// </java-name>
				[Dot42.DexImport("getLowerBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetLowerBounds() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/Modifier
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Modifier", AccessFlags = 33)]
		public partial class Modifier
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 1;
				/// <java-name>
				/// PRIVATE
				/// </java-name>
				[Dot42.DexImport("PRIVATE", "I", AccessFlags = 25)]
				public const int PRIVATE = 2;
				/// <java-name>
				/// PROTECTED
				/// </java-name>
				[Dot42.DexImport("PROTECTED", "I", AccessFlags = 25)]
				public const int PROTECTED = 4;
				/// <java-name>
				/// STATIC
				/// </java-name>
				[Dot42.DexImport("STATIC", "I", AccessFlags = 25)]
				public const int STATIC = 8;
				/// <java-name>
				/// FINAL
				/// </java-name>
				[Dot42.DexImport("FINAL", "I", AccessFlags = 25)]
				public const int FINAL = 16;
				/// <java-name>
				/// SYNCHRONIZED
				/// </java-name>
				[Dot42.DexImport("SYNCHRONIZED", "I", AccessFlags = 25)]
				public const int SYNCHRONIZED = 32;
				/// <java-name>
				/// VOLATILE
				/// </java-name>
				[Dot42.DexImport("VOLATILE", "I", AccessFlags = 25)]
				public const int VOLATILE = 64;
				/// <java-name>
				/// TRANSIENT
				/// </java-name>
				[Dot42.DexImport("TRANSIENT", "I", AccessFlags = 25)]
				public const int TRANSIENT = 128;
				/// <java-name>
				/// NATIVE
				/// </java-name>
				[Dot42.DexImport("NATIVE", "I", AccessFlags = 25)]
				public const int NATIVE = 256;
				/// <java-name>
				/// INTERFACE
				/// </java-name>
				[Dot42.DexImport("INTERFACE", "I", AccessFlags = 25)]
				public const int INTERFACE = 512;
				/// <java-name>
				/// ABSTRACT
				/// </java-name>
				[Dot42.DexImport("ABSTRACT", "I", AccessFlags = 25)]
				public const int ABSTRACT = 1024;
				/// <java-name>
				/// STRICT
				/// </java-name>
				[Dot42.DexImport("STRICT", "I", AccessFlags = 25)]
				public const int STRICT = 2048;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Modifier() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAbstract
				/// </java-name>
				[Dot42.DexImport("isAbstract", "(I)Z", AccessFlags = 9)]
				public static bool IsAbstract(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFinal
				/// </java-name>
				[Dot42.DexImport("isFinal", "(I)Z", AccessFlags = 9)]
				public static bool IsFinal(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInterface
				/// </java-name>
				[Dot42.DexImport("isInterface", "(I)Z", AccessFlags = 9)]
				public static bool IsInterface(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNative
				/// </java-name>
				[Dot42.DexImport("isNative", "(I)Z", AccessFlags = 9)]
				public static bool IsNative(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isPrivate
				/// </java-name>
				[Dot42.DexImport("isPrivate", "(I)Z", AccessFlags = 9)]
				public static bool IsPrivate(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isProtected
				/// </java-name>
				[Dot42.DexImport("isProtected", "(I)Z", AccessFlags = 9)]
				public static bool IsProtected(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isPublic
				/// </java-name>
				[Dot42.DexImport("isPublic", "(I)Z", AccessFlags = 9)]
				public static bool IsPublic(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStatic
				/// </java-name>
				[Dot42.DexImport("isStatic", "(I)Z", AccessFlags = 9)]
				public static bool IsStatic(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStrict
				/// </java-name>
				[Dot42.DexImport("isStrict", "(I)Z", AccessFlags = 9)]
				public static bool IsStrict(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSynchronized
				/// </java-name>
				[Dot42.DexImport("isSynchronized", "(I)Z", AccessFlags = 9)]
				public static bool IsSynchronized(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTransient
				/// </java-name>
				[Dot42.DexImport("isTransient", "(I)Z", AccessFlags = 9)]
				public static bool IsTransient(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isVolatile
				/// </java-name>
				[Dot42.DexImport("isVolatile", "(I)Z", AccessFlags = 9)]
				public static bool IsVolatile(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/lang/reflect/Type
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Type", AccessFlags = 1537)]
		public partial interface IType
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/reflect/ParameterizedType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ParameterizedType", AccessFlags = 1537)]
		public partial interface IParameterizedType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getActualTypeArguments
				/// </java-name>
				[Dot42.DexImport("getActualTypeArguments", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType[] GetActualTypeArguments() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getOwnerType
				/// </java-name>
				[Dot42.DexImport("getOwnerType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetOwnerType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRawType
				/// </java-name>
				[Dot42.DexImport("getRawType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetRawType() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/ReflectPermission
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ReflectPermission", AccessFlags = 49)]
		public sealed partial class ReflectPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ReflectPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ReflectPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ReflectPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/Proxy
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Proxy", AccessFlags = 33)]
		public partial class Proxy : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// h
				/// </java-name>
				[Dot42.DexImport("h", "Ljava/lang/reflect/InvocationHandler;", AccessFlags = 4)]
				protected internal global::Java.Lang.Reflect.IInvocationHandler H;
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/InvocationHandler;)V", AccessFlags = 4)]
				protected internal Proxy(global::Java.Lang.Reflect.IInvocationHandler invocationHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProxyClass
				/// </java-name>
				[Dot42.DexImport("getProxyClass", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;", AccessFlags = 137, Signature = "(Ljava/lang/ClassLoader;[Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
				public static global::System.Type GetProxyClass(global::Java.Lang.ClassLoader classLoader, params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// newProxyInstance
				/// </java-name>
				[Dot42.DexImport("newProxyInstance", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)L" +
    "java/lang/Object;", AccessFlags = 9, Signature = "(Ljava/lang/ClassLoader;[Ljava/lang/Class<*>;Ljava/lang/reflect/InvocationHandler" +
    ";)Ljava/lang/Object;")]
				public static object NewProxyInstance(global::Java.Lang.ClassLoader classLoader, global::System.Type[] type, global::Java.Lang.Reflect.IInvocationHandler invocationHandler) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// isProxyClass
				/// </java-name>
				[Dot42.DexImport("isProxyClass", "(Ljava/lang/Class;)Z", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Z")]
				public static bool IsProxyClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInvocationHandler
				/// </java-name>
				[Dot42.DexImport("getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;", AccessFlags = 9)]
				public static global::Java.Lang.Reflect.IInvocationHandler GetInvocationHandler(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IInvocationHandler);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Proxy() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/reflect/InvocationHandler
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationHandler", AccessFlags = 1537)]
		public partial interface IInvocationHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Objec" +
    "t;", AccessFlags = 1025)]
				object Invoke(object @object, global::System.Reflection.MethodInfo methodInfo, object[] object1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMemberConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 0;
				/// <java-name>
				/// DECLARED
				/// </java-name>
				[Dot42.DexImport("DECLARED", "I", AccessFlags = 25)]
				public const int DECLARED = 1;
		}

		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537)]
		public partial interface IMember
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<*>;")]
				global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1025)]
				int GetModifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1025)]
				bool IsSynthetic() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/AnnotatedElement
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AnnotatedElement", AccessFlags = 1537)]
		public partial interface IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T GetAnnotation<T>(global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1025, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/GenericDeclaration
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericDeclaration", AccessFlags = 1537)]
		public partial interface IGenericDeclaration
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1025, Signature = "()[Ljava/lang/reflect/TypeVariable<*>;")]
				global::Java.Lang.Reflect.ITypeVariable<object>[] GetTypeParameters() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/reflect/GenericArrayType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericArrayType", AccessFlags = 1537)]
		public partial interface IGenericArrayType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getGenericComponentType
				/// </java-name>
				[Dot42.DexImport("getGenericComponentType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
				global::Java.Lang.Reflect.IType GetGenericComponentType() /* MethodBuilder.Create */ ;

		}

}

