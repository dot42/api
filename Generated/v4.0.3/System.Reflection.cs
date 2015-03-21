#pragma warning disable 1717
namespace System.Reflection
{
		/// <java-name>
		/// java/lang/reflect/Constructor
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Constructor", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/reflect/AccessibleObject;Ljava/lang/reflect/Gene" +
    "ricDeclaration;Ljava/lang/reflect/Member;")]
		public sealed partial class JavaConstructor : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JavaConstructor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable<object>[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<object>[]);
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
				/// getGenericParameterTypes
				/// </java-name>
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
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
				/// getParameterAnnotations
				/// </java-name>
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[][] GetParameterAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[][]);
				}

				/// <java-name>
				/// isVarArgs
				/// </java-name>
				[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
				public bool IsVarArgs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
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
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
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
				/// getTypeParameters
				/// </java-name>
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.JavaConstructor>[] TypeParameters
				{
				        [Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
						get{ return null; }
				}

				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericParameterTypes(); }
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericExceptionTypes(); }
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetParameterAnnotations(); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetExceptionTypes(); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetParameterTypes(); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/Field
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Field", AccessFlags = 49)]
		public sealed partial class JavaField : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JavaField() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// isEnumConstant
				/// </java-name>
				[Dot42.DexImport("isEnumConstant", "()Z", AccessFlags = 1)]
				public bool IsEnumConstant() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getGenericType
				/// </java-name>
				[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
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
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
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
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetTypeJava() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
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
				/// getGenericType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericType
				{
				[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericType(); }
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetTypeJava(); }
				}

		}

		/// <java-name>
		/// java/lang/reflect/Method
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Method", AccessFlags = 49)]
		public sealed partial class JavaMethod : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JavaMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
				public global::Java.Lang.Reflect.ITypeVariable<object>[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<object>[]);
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
				/// getGenericParameterTypes
				/// </java-name>
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericReturnType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
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
				/// getParameterAnnotations
				/// </java-name>
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[][] GetParameterAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[][]);
				}

				/// <java-name>
				/// isVarArgs
				/// </java-name>
				[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
				public bool IsVarArgs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBridge
				/// </java-name>
				[Dot42.DexImport("isBridge", "()Z", AccessFlags = 1)]
				public bool IsBridge() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object GetDefaultValue() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getReturnType
				/// </java-name>
				[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetReturnType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
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
				/// getTypeParameters
				/// </java-name>
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.JavaMethod>[] TypeParameters
				{
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
						get{ return null; }
				}

				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericParameterTypes(); }
				}

				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericExceptionTypes(); }
				}

				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericReturnType
				{
				[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericReturnType(); }
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetParameterAnnotations(); }
				}

				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				public object DefaultValue
				{
				[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetDefaultValue(); }
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetExceptionTypes(); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetParameterTypes(); }
				}

				/// <java-name>
				/// getReturnType
				/// </java-name>
				public global::System.Type ReturnType
				{
				[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetReturnType(); }
				}

		}

}

