#pragma warning disable 1717
namespace Java.Lang.Reflect
{
		/// <java-name>
		/// java/lang/reflect/AccessibleObject
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AccessibleObject", AccessFlags = 33)]
		public partial class AccessibleObject : global::Java.Lang.Reflect.IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AccessibleObject() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAccessible
				/// </java-name>
				[Dot42.DexImport("setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V", AccessFlags = 9)]
				public static void SetAccessible(global::Java.Lang.Reflect.AccessibleObject[] accessibleObject, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAccessible
				/// </java-name>
				[Dot42.DexImport("setAccessible", "(Z)V", AccessFlags = 1)]
				public virtual void SetAccessible(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public virtual bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				public virtual T GetAnnotation<T>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// isAccessible
				/// </java-name>
				public virtual bool IsAccessible
				{
						[Dot42.DexImport("isAccessible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

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
		/// java/lang/reflect/Constructor
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Constructor", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/reflect/AccessibleObject;Ljava/lang/reflect/Gene" +
    "ricDeclaration;Ljava/lang/reflect/Member;")]
		public sealed partial class Constructor : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Constructor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable[]);
				}

				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public override A GetAnnotation<A>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 129, Signature = "([Ljava/lang/Object;)TT;")]
				public object NewInstance(params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
						[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
						[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
						[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Annotation.IAnnotation[][]); }
				}

				/// <java-name>
				/// isVarArgs
				/// </java-name>
				public bool IsVarArgs
				{
						[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
						get{ return default(global::System.Type); }
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
						[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
						[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/Field
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Field", AccessFlags = 49)]
		public sealed partial class Field : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Field() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public override A GetAnnotation<A>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool GetBoolean(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;)B", AccessFlags = 1)]
				public sbyte JavaGetByte(object @object) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;)B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte GetByte(object @object) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/Object;)C", AccessFlags = 1)]
				public char GetChar(object @object) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/Object;)D", AccessFlags = 1)]
				public double GetDouble(object @object) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/Object;)F", AccessFlags = 1)]
				public float GetFloat(object @object) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public int GetInt(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/Object;)J", AccessFlags = 1)]
				public long GetLong(object @object) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/Object;)S", AccessFlags = 1)]
				public short GetShort(object @object) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void Set(object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public void SetBoolean(object @object, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1)]
				public void SetByte(object @object, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void SetByte(object @object, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;C)V", AccessFlags = 1)]
				public void SetChar(object @object, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;D)V", AccessFlags = 1)]
				public void SetDouble(object @object, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;F)V", AccessFlags = 1)]
				public void SetFloat(object @object, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;I)V", AccessFlags = 1)]
				public void SetInt(object @object, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;J)V", AccessFlags = 1)]
				public void SetLong(object @object, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/Object;S)V", AccessFlags = 1)]
				public void SetShort(object @object, short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isEnumConstant
				/// </java-name>
				public bool IsEnumConstant
				{
						[Dot42.DexImport("isEnumConstant", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getGenericType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericType
				{
						[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
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
		/// java/lang/reflect/GenericArrayType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericArrayType", AccessFlags = 1537)]
		public partial interface IGenericArrayType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getGenericComponentType
				/// </java-name>
				global::Java.Lang.Reflect.IType GenericComponentType
				{
						[Dot42.DexImport("getGenericComponentType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

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
				global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ ;

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
				object Invoke(object @object, global::Java.Lang.Reflect.Method method, object[] object1) /* MethodBuilder.Create */ ;

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
				global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<*>;")]
						get;
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1025)]
						get;
				}

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
		/// java/lang/reflect/ParameterizedType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ParameterizedType", AccessFlags = 1537)]
		public partial interface IParameterizedType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getActualTypeArguments
				/// </java-name>
				global::Java.Lang.Reflect.IType[] ActualTypeArguments
				{
						[Dot42.DexImport("getActualTypeArguments", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOwnerType
				/// </java-name>
				global::Java.Lang.Reflect.IType OwnerType
				{
						[Dot42.DexImport("getOwnerType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRawType
				/// </java-name>
				global::Java.Lang.Reflect.IType RawType
				{
						[Dot42.DexImport("getRawType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
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
		/// java/lang/reflect/TypeVariable
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/TypeVariable", AccessFlags = 1537, Signature = "<D::Ljava/lang/reflect/GenericDeclaration;>Ljava/lang/Object;Ljava/lang/reflect/T" +
    "ype;")]
		public partial interface ITypeVariable : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBounds
				/// </java-name>
				global::Java.Lang.Reflect.IType[] Bounds
				{
						[Dot42.DexImport("getBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getGenericDeclaration
				/// </java-name>
				object GenericDeclaration
				{
						[Dot42.DexImport("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", AccessFlags = 1025, Signature = "()TD;")]
						get;
				}

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
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
				global::Java.Lang.Reflect.IType[] UpperBounds
				{
						[Dot42.DexImport("getUpperBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLowerBounds
				/// </java-name>
				global::Java.Lang.Reflect.IType[] LowerBounds
				{
						[Dot42.DexImport("getLowerBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
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
		/// java/lang/reflect/Method
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Method", AccessFlags = 49)]
		public sealed partial class Method : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Method() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
				public global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable[]);
				}

				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public override A GetAnnotation<A>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 129)]
				public object Invoke(object @object, params object[] object1) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
						[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
						[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericReturnType
				{
						[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType); }
				}

				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
						[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Annotation.IAnnotation[][]); }
				}

				/// <java-name>
				/// isVarArgs
				/// </java-name>
				public bool IsVarArgs
				{
						[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isBridge
				/// </java-name>
				public bool IsBridge
				{
						[Dot42.DexImport("isBridge", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				public object DefaultValue
				{
						[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
						[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
						[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <java-name>
				/// getReturnType
				/// </java-name>
				public global::System.Type ReturnType
				{
						[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

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
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UndeclaredThrowableException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				public virtual global::System.Exception UndeclaredThrowable
				{
						[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

}

