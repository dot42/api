#pragma warning disable 1717
namespace Java.Lang.Reflect
{
		/// <summary>
		///  <para> <c>AccessibleObject </c> is the superclass of all member reflection classes (Field, Constructor, Method). AccessibleObject provides the ability to toggle a flag controlling access checks for these objects. By default, accessing a member (for example, setting a field or invoking a method) checks the validity of the access (for example, invoking a private method from outside the defining class is prohibited) and throws IllegalAccessException if the operation is not permitted. If the accessible flag is set to true, these checks are omitted. This allows privileged code, such as Java object serialization, object inspectors, and debuggers to have complete access to objects.</para> <para> <para>Field </para> <para>Constructor </para> <para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/AccessibleObject
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AccessibleObject", AccessFlags = 33)]
		public partial class AccessibleObject : global::Java.Lang.Reflect.IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>AccessibleObject </c> instance. <c>AccessibleObject </c> instances can only be constructed by the virtual machine. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AccessibleObject() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to set the value of the accessible flag for all the objects in the array provided. Setting this flag to <c>false </c> will enable access checks, setting to <c>true </c> will disable them.</para> <para> <para>setAccessible(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setAccessible
				/// </java-name>
				[Dot42.DexImport("setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V", AccessFlags = 9)]
				public static void SetAccessible(global::Java.Lang.Reflect.AccessibleObject[] objects, bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation exists, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public virtual bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				///  <para>Returns, for this element, an array containing all annotations (including inherited annotations). If there are no annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of all annotations for this element </para>
				/// </returns>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				///  <para>Returns, for this element, the annotation with the specified type, or  <c>null </c> if no annotation with the specified type is present (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the annotation with the specified type or <c>null </c> </para>
				/// </returns>
				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				public virtual T GetAnnotation<T>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Indicates whether this object is accessible without access checks being performed. Returns the accessible flag.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this object is accessible without access checks, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAccessible
				/// </java-name>
				public virtual bool IsAccessible
				{
						[Dot42.DexImport("isAccessible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAccessible", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Provides static methods to create and access arrays dynamically. </para>    
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
				///  <para>Returns the element of the array at the specified index. Equivalent to <c>array[index] </c> . If the array component is a primitive type, the result is automatically boxed.</para> <para></para>        
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
				///  <para>Returns the boolean at the given index in the given boolean array.</para> <para></para>        
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
				///  <para>Returns the byte at the given index in the given byte array.</para> <para></para>        
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
				///  <para>Returns the byte at the given index in the given byte array.</para> <para></para>        
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
				///  <para>Returns the char at the given index in the given char array.</para> <para></para>        
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
				///  <para>Returns the double at the given index in the given array. Applies to byte, char, float, double, int, long, and short arrays.</para> <para></para>        
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
				///  <para>Returns the float at the given index in the given array. Applies to byte, char, float, int, long, and short arrays.</para> <para></para>        
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
				///  <para>Returns the int at the given index in the given array. Applies to byte, char, int, and short arrays.</para> <para></para>        
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
				///  <para>Returns the length of the array. Equivalent to <c>array.length </c> .</para> <para></para>        
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
				///  <para>Returns the long at the given index in the given array. Applies to byte, char, int, long, and short arrays.</para> <para></para>        
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
				///  <para>Returns the short at the given index in the given array. Applies to byte and short arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/Object;I)S", AccessFlags = 9)]
				public static short GetShort(object array, int index) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns a new array of the specified component type and length. Equivalent to <c>new componentType[size] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/Class;[I)Ljava/lang/Object;", AccessFlags = 137, Signature = "(Ljava/lang/Class<*>;[I)Ljava/lang/Object;")]
				public static object NewInstance(global::System.Type componentType, params int[] size) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns a new array of the specified component type and length. Equivalent to <c>new componentType[size] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/Class;I)Ljava/lang/Object;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;I)Ljava/lang/Object;")]
				public static object NewInstance(global::System.Type componentType, int size) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Sets the element of the array at the specified index to the value. Equivalent to <c>array[index] = value </c> . If the array component is a primitive type, the value is automatically unboxed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;ILjava/lang/Object;)V", AccessFlags = 9)]
				public static void Set(object array, int index, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to boolean arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;IZ)V", AccessFlags = 9)]
				public static void SetBoolean(object array, int index, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to byte, double, float, int, long, and short arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9)]
				public static void SetByte(object array, int index, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to byte, double, float, int, long, and short arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;IB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void SetByte(object array, int index, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to char, double, float, int, and long arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;IC)V", AccessFlags = 9)]
				public static void SetChar(object array, int index, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to double arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;ID)V", AccessFlags = 9)]
				public static void SetDouble(object array, int index, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to double and float arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;IF)V", AccessFlags = 9)]
				public static void SetFloat(object array, int index, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to double, float, int, and long arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void SetInt(object array, int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to double, float, and long arrays.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;IJ)V", AccessFlags = 9)]
				public static void SetLong(object array, int index, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets <c>array[index] = value </c> . Applies to double, float, int, long, and short arrays.</para> <para></para>        
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
		///  <para>This class represents a constructor. Information about the constructor can be accessed, and the constructor can be invoked dynamically.</para> <para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Constructor
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Constructor", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/reflect/AccessibleObject;Ljava/lang/reflect/Gene" +
    "ricDeclaration;Ljava/lang/reflect/Member;")]
		public sealed partial class Constructor : global::Java.Lang.Reflect.AccessibleObject, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Prevent this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Constructor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable[]);
				}

				/// <summary>
				///  <para>Returns the string representation of the constructor's declaration, including the type parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of the constructor's declaration </para>
				/// </returns>
				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of annotations declared for this element </para>
				/// </returns>
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
				public override A GetAnnotation<A>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <summary>
				///  <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation exists, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether or not the specified <c>object </c> is equal to this constructor. To be equal, the specified object must be an instance of <c>Constructor </c> with the same declaring class and parameter types as this constructor.</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this constructor, <c>false </c> otherwise</para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an integer hash code for this constructor. Constructors which are equal return the same value for this method. The hash code for a Constructor is the hash code of the name of the declaring class.</para> <para> <para>equals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a new instance of the declaring class, initialized by dynamically invoking the constructor represented by this <c>Constructor </c> object. This reproduces the effect of <c> new declaringClass(arg1, arg2, ... ,argN) </c> This method performs the following:  <ul> <li> <para>A new instance of the declaring class is created. If the declaring class cannot be instantiated (i.e. abstract class, an interface, an array type, or a primitive type) then an InstantiationException is thrown. </para></li> <li> <para>If this Constructor object is enforcing access control (see AccessibleObject) and this constructor is not accessible from the current context, an IllegalAccessException is thrown. </para></li> <li> <para>If the number of arguments passed and the number of parameters do not match, an IllegalArgumentException is thrown. </para></li> <li> <para>For each argument passed:  <ul> <li> <para>If the corresponding parameter type is a primitive type, the argument is unboxed. If the unboxing fails, an IllegalArgumentException is thrown. </para></li> <li> <para>If the resulting argument cannot be converted to the parameter type via a widening conversion, an IllegalArgumentException is thrown. </para></li></ul></para></li> <li> <para>The constructor represented by this <c>Constructor </c> object is then invoked. If an exception is thrown during the invocation, it is caught and wrapped in an InvocationTargetException. This exception is then thrown. If the invocation completes normally, the newly initialized object is returned. </para></li></ul></para> <para> <para>AccessibleObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new, initialized, object</para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 129, Signature = "([Ljava/lang/Object;)TT;")]
				public object NewInstance(params object[] args) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this constructor. The format of the string is:</para> <para> <ol> <li> <para>modifiers (if any) </para></li> <li> <para>declaring class name </para></li> <li> <para>'(' </para></li> <li> <para>parameter types, separated by ',' (if any) </para></li> <li> <para>')' </para></li> <li> <para>'throws' plus exception types, separated by ',' (if any) </para></li></ol></para> <para>For example:  <c>public String(byte[],String) throws UnsupportedEncodingException </c></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this constructor </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the generic parameter types as an array of <c>Type </c> instances, in declaration order. If this constructor has no generic parameters, an empty array is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
						[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <summary>
				///  <para>Returns the exception types as an array of <c>Type </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
						[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <summary>
				///  <para>Returns an array of arrays that represent the annotations of the formal parameters of this constructor. If there are no parameters on this constructor, then an empty array is returned. If there are no annotations set, then an array of empty arrays is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of arrays of <c>Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
						[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Annotation.IAnnotation[][]); }
				}

				/// <summary>
				///  <para>Indicates whether or not this constructor takes a variable number of arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a vararg is declare, otherwise  <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// isVarArgs
				/// </java-name>
				public bool IsVarArgs
				{
						[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether or not this constructor is synthetic (artificially introduced by the compiler).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this constructor is synthetic, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the class that declares this constructor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
						get{ return default(global::System.Type); }
				}

				/// <summary>
				///  <para>Returns the exception types as an array of <c>Class </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
						[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <summary>
				///  <para>Returns the modifiers for this constructor. The Modifier class should be used to decode the result.</para> <para> <para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modifiers for this constructor</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the name of this constructor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this constructor </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns an array of the <c>Class </c> objects associated with the parameter types of this constructor. If the constructor was declared with no parameters, an empty array will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
						[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

		}

		/// <summary>
		///  <para>This class represents a field. Information about the field can be accessed, and the field's value can be accessed dynamically. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the string representation of this field, including the field's generic type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this field </para>
				/// </returns>
				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of annotations declared for this element </para>
				/// </returns>
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
				public override A GetAnnotation<A>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <summary>
				///  <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation exists, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether or not the specified <c>object </c> is equal to this field. To be equal, the specified object must be an instance of  <c>Field </c> with the same declaring class, type and name as this field.</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this method,  <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object. This reproduces the effect of <c>object.fieldName </c></para> <para>If the type of this field is a primitive type, the field value is automatically boxed.</para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is null, a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown.</para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value, possibly boxed </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>boolean </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool GetBoolean(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>byte </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;)B", AccessFlags = 1)]
				public sbyte JavaGetByte(object @object) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>byte </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/Object;)B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte GetByte(object @object) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>char </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/Object;)C", AccessFlags = 1)]
				public char GetChar(object @object) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>double </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/Object;)D", AccessFlags = 1)]
				public double GetDouble(object @object) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>float </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/Object;)F", AccessFlags = 1)]
				public float GetFloat(object @object) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as an <c>int </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public int GetInt(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>long </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/Object;)J", AccessFlags = 1)]
				public long GetLong(object @object) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the field in the specified object as a <c>short </c> . This reproduces the effect of <c>object.fieldName </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field value </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/Object;)S", AccessFlags = 1)]
				public short GetShort(object @object) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns an integer hash code for this field. Objects which are equal return the same value for this method. </para> <para>The hash code for a Field is the exclusive-or combination of the hash code of the field's name and the hash code of the name of its declaring class.</para> <para> <para>equals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code for this field </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the value. This reproduces the effect of <c>object.fieldName = value </c></para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown.</para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para> <para>If the field type is a primitive type, the value is automatically unboxed. If the unboxing fails, an IllegalArgumentException is thrown. If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void Set(object @object, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>boolean </c> value. This reproduces the effect of <c> object.fieldName =value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public void SetBoolean(object @object, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>byte </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1)]
				public void SetByte(object @object, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>byte </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void SetByte(object @object, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>char </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;C)V", AccessFlags = 1)]
				public void SetChar(object @object, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>double </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;D)V", AccessFlags = 1)]
				public void SetDouble(object @object, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>float </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;F)V", AccessFlags = 1)]
				public void SetFloat(object @object, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the value of the field in the specified object to the <c>int </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;I)V", AccessFlags = 1)]
				public void SetInt(object @object, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>long </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;J)V", AccessFlags = 1)]
				public void SetLong(object @object, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the value of the field in the specified object to the <c>short </c> value. This reproduces the effect of <c>object.fieldName = value </c> </para> <para>If this field is static, the object argument is ignored. Otherwise, if the object is <c>null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para> <para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para> <para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/Object;S)V", AccessFlags = 1)]
				public void SetShort(object @object, short value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this field. </para> <para>The format of the string is:  <ol> <li> <para>modifiers (if any) </para></li> <li> <para>type </para></li> <li> <para>declaring class name </para></li> <li> <para>'.' </para></li> <li> <para>field name </para></li></ol></para> <para>For example: <c> public static java.io.InputStreamjava.lang.System.in </c></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this field </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Indicates whether or not this field is synthetic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this field is synthetic, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether or not this field is an enumeration constant.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this field is an enumeration constant, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isEnumConstant
				/// </java-name>
				public bool IsEnumConstant
				{
						[Dot42.DexImport("isEnumConstant", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the generic type of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the generic type </para>
				/// </returns>
				/// <java-name>
				/// getGenericType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericType
				{
						[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType); }
				}

				/// <summary>
				///  <para>Returns the class that declares this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <summary>
				///  <para>Returns the modifiers for this field. The Modifier class should be used to decode the result.</para> <para> <para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modifiers for this field </para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the name of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this field </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the Class associated with the type of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type of this field </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

		}

		/// <summary>
		///  <para>Indicates that a malformed signature has been encountered via a reflective method.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericSignatureFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericSignatureFormatError", AccessFlags = 33)]
		public partial class GenericSignatureFormatError : global::Java.Lang.ClassFormatError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>GenericSignatureFormatError </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GenericSignatureFormatError() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This interface provides reflective access to annotation information.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/AnnotatedElement
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AnnotatedElement", AccessFlags = 1537)]
		public partial interface IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns, for this element, the annotation with the specified type, or  <c>null </c> if no annotation with the specified type is present (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the annotation with the specified type or <c>null </c> </para>
				/// </returns>
				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T GetAnnotation<T>(global::System.Type annotationType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns, for this element, an array containing all annotations (including inherited annotations). If there are no annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of all annotations for this element </para>
				/// </returns>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation exists, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1025, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This interface represents an array type with a component type that is either a parameterized type or a type variable.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericArrayType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericArrayType", AccessFlags = 1537)]
		public partial interface IGenericArrayType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the component type of this array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the component type of this array</para>
				/// </returns>
				/// <java-name>
				/// getGenericComponentType
				/// </java-name>
				global::Java.Lang.Reflect.IType GenericComponentType
				{
						[Dot42.DexImport("getGenericComponentType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Common interface for language constructs that declare type parameters.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/GenericDeclaration
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/GenericDeclaration", AccessFlags = 1537)]
		public partial interface IGenericDeclaration
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1025, Signature = "()[Ljava/lang/reflect/TypeVariable<*>;")]
				global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Implementors of this interface dispatch methods invoked on proxy instances.</para> <para> <para>Proxy </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/InvocationHandler
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationHandler", AccessFlags = 1537)]
		public partial interface IInvocationHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Handles the method which was originally invoked on the proxy instance. A typical usage pattern follows below:</para> <para> <pre>
				/// public Object invoke(Object proxy, Method method, Object[] args) throws Throwable {
				///     //do some processing before the method invocation</pre></para> <para> <pre>    //invoke the method
				///     Object result = method.invoke(proxy, args);</pre></para> <para> <pre>    //do some processing after the method invocation
				///     return result;
				/// }</pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result of executing the method. Primitive types are boxed.</para>
				/// </returns>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Objec" +
    "t;", AccessFlags = 1025)]
				object Invoke(object proxy, global::Java.Lang.Reflect.Method method, object[] args) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Common interface providing access to reflective information on class members.</para> <para> <para>Field </para> <para>Constructor </para> <para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537)]
		public partial interface IMember
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the class that declares this member.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<*>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the modifiers for this member. The Modifier class should be used to decode the result.</para> <para> <para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modifiers for this member</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of this member.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this member </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Indicates whether or not this member is synthetic (artificially introduced by the compiler).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this member is synthetic, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Common interface providing access to reflective information on class members.</para> <para> <para>Field </para> <para>Constructor </para> <para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Member
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Member", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMemberConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Designates all public members of a class or interface (including inherited members). </para>        
				/// </summary>
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 0;
				/// <summary>
				///  <para>Designates all declared members of a class or interface (without inherited members). </para>        
				/// </summary>
				/// <java-name>
				/// DECLARED
				/// </java-name>
				[Dot42.DexImport("DECLARED", "I", AccessFlags = 25)]
				public const int DECLARED = 1;
		}

		/// <summary>
		///  <para>This interface represents a parameterized type such as <c>'Set&amp;lt;String&amp;gt;' </c> .</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/ParameterizedType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/ParameterizedType", AccessFlags = 1537)]
		public partial interface IParameterizedType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns an array of the actual type arguments for this type. </para> <para>If this type models a non parameterized type nested within a parameterized type, this method returns a zero length array. The generic type of the following <c>field </c> declaration is an example for a parameterized type without type arguments.</para> <para> <pre>
				/// A&lt;String&gt;.B field;</pre></para> <para> <pre>class A&lt;T&gt; {
				///     class B {
				///     }
				/// }</pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the actual type arguments</para>
				/// </returns>
				/// <java-name>
				/// getActualTypeArguments
				/// </java-name>
				global::Java.Lang.Reflect.IType[] ActualTypeArguments
				{
						[Dot42.DexImport("getActualTypeArguments", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the parent / owner type, if this type is an inner type, otherwise  <c>null </c> is returned if this is a top-level type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the owner type or <c>null </c> if this is a top-level type</para>
				/// </returns>
				/// <java-name>
				/// getOwnerType
				/// </java-name>
				global::Java.Lang.Reflect.IType OwnerType
				{
						[Dot42.DexImport("getOwnerType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the declaring type of this parameterized type. </para> <para>The raw type of <c>Set&lt;String&gt; field; </c> is <c>Set </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw type of this parameterized type </para>
				/// </returns>
				/// <java-name>
				/// getRawType
				/// </java-name>
				global::Java.Lang.Reflect.IType RawType
				{
						[Dot42.DexImport("getRawType", "()Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Common interface implemented by all Java types.</para> <para> <para>1.5 </para></para>    
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
		///  <para>This interface represents a type variables such as <c>'T' </c> in <c>'public interface Comparable&lt;T&gt;' </c> , the bounded <c>'T' </c> in <c>'public interface A&lt;T extends Number&gt;' </c> or the multiple bounded <c>'T' </c> in <c>'public interface B&lt;T extends Number &amp; Cloneable&gt;' </c> .</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/TypeVariable
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/TypeVariable", AccessFlags = 1537, Signature = "<D::Ljava/lang/reflect/GenericDeclaration;>Ljava/lang/Object;Ljava/lang/reflect/T" +
    "ype;")]
		public partial interface ITypeVariable : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the upper bounds of this type variable. <c>Object </c> is the implicit upper bound if no other bounds are declared.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the upper bounds of this type variable</para>
				/// </returns>
				/// <java-name>
				/// getBounds
				/// </java-name>
				global::Java.Lang.Reflect.IType[] Bounds
				{
						[Dot42.DexImport("getBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the language construct that declares this type variable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the generic declaration </para>
				/// </returns>
				/// <java-name>
				/// getGenericDeclaration
				/// </java-name>
				object GenericDeclaration
				{
						[Dot42.DexImport("getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", AccessFlags = 1025, Signature = "()TD;")]
						get;
				}

				/// <summary>
				///  <para>Returns the name of this type variable as it is specified in source code.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this type variable </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A pattern type, such as the upper bounded wildcard <c>? extends Closeable </c> or the lower bounded wildcard <c>? super String </c> .</para> <para>Although this interface permits an arbitrary number of upper and lower bounds, all wildcard types of Java language programs are in one of two forms:  <ol> <li> <para> <b>No lower bound and one upper bound.</b> Such types are written like <c>? extends java.lang.Number </c> . When the upper bound is  <c>java.lang.Object </c> , the <c>extends java.lang.Object </c> suffix is optional: <c>Set&lt;?&gt; </c> is shorthand for <c>Set&lt;? extends java.lang.Object&gt; </c> . </para></li> <li> <para> <b>One lower bound and an upper bound of <c>java.lang.Object </c> .</b> Such types are written like <c>? super java.lang.String </c> . </para></li></ol></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/WildcardType
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/WildcardType", AccessFlags = 1537)]
		public partial interface IWildcardType : global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the array of types that represent the upper bounds of this type. The default upper bound is <c>Object </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing the upper bounds types</para>
				/// </returns>
				/// <java-name>
				/// getUpperBounds
				/// </java-name>
				global::Java.Lang.Reflect.IType[] UpperBounds
				{
						[Dot42.DexImport("getUpperBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the array of types that represent the lower bounds of this type. The default lower bound is <c>null </c> , in which case an empty array is returned. Since only one lower bound is allowed, the returned array's length will never exceed one.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing the lower bounds types</para>
				/// </returns>
				/// <java-name>
				/// getLowerBounds
				/// </java-name>
				global::Java.Lang.Reflect.IType[] LowerBounds
				{
						[Dot42.DexImport("getLowerBounds", "()[Ljava/lang/reflect/Type;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Indicates that a malformed parameterized type has been encountered by a reflective method.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/MalformedParameterizedTypeException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/MalformedParameterizedTypeException", AccessFlags = 33)]
		public partial class MalformedParameterizedTypeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>MalformedParameterizedTypeException </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedParameterizedTypeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class represents a method. Information about the method can be accessed, and the method can be invoked dynamically. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
				public global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable[]);
				}

				/// <summary>
				///  <para>Returns the string representation of the method's declaration, including the type parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this method </para>
				/// </returns>
				/// <java-name>
				/// toGenericString
				/// </java-name>
				[Dot42.DexImport("toGenericString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToGenericString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of annotations declared for this element </para>
				/// </returns>
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
				public override A GetAnnotation<A>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <summary>
				///  <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation exists, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public override bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether or not the specified <c>object </c> is equal to this method. To be equal, the specified object must be an instance of <c>Method </c> with the same declaring class and parameter types as this method.</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this method, <c>false </c> otherwise</para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an integer hash code for this method. Objects which are equal return the same value for this method. The hash code for this Method is the hash code of the name of this method.</para> <para> <para>equals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>hash code for this method</para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the result of dynamically invoking this method. Equivalent to  <c>receiver.methodName(arg1, arg2, ... , argN) </c> .</para> <para>If the method is static, the receiver argument is ignored (and may be null).</para> <para>If the method takes no arguments, you can pass <c>(Object[]) null </c> instead of allocating an empty array.</para> <para>If you're calling a varargs method, you need to pass an <c>Object[] </c> for the varargs parameter: that conversion is usually done in <c>javac </c> , not the VM, and the reflection machinery does not do this for you. (It couldn't, because it would be ambiguous.)</para> <para>Reflective method invocation follows the usual process for method lookup.</para> <para>If an exception is thrown during the invocation it is caught and wrapped in an InvocationTargetException. This exception is then thrown.</para> <para>If the invocation completes normally, the return value itself is returned. If the method is declared to return a primitive type, the return value is boxed. If the return type is void, null is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result</para>
				/// </returns>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 129)]
				public object Invoke(object receiver, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this method. The format of the string is:</para> <para> <ol> <li> <para>modifiers (if any) </para></li> <li> <para>return type or 'void' </para></li> <li> <para>declaring class name </para></li> <li> <para>'(' </para></li> <li> <para>parameter types, separated by ',' (if any) </para></li> <li> <para>')' </para></li> <li> <para>'throws' plus exception types, separated by ',' (if any) </para></li></ol></para> <para>For example: <c> public native Objectjava.lang.Method.invoke(Object,Object) throwsIllegalAccessException,IllegalArgumentException,InvocationTargetException </c></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this method </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the parameter types as an array of <c>Type </c> instances, in declaration order. If this method has no parameters, an empty array is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
						[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <summary>
				///  <para>Returns the exception types as an array of <c>Type </c> instances. If this method has no declared exceptions, an empty array will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
						[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType[]); }
				}

				/// <summary>
				///  <para>Returns the return type of this method as a <c>Type </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the return type of this method</para>
				/// </returns>
				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericReturnType
				{
						[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Reflect.IType); }
				}

				/// <summary>
				///  <para>Returns an array of arrays that represent the annotations of the formal parameters of this method. If there are no parameters on this method, then an empty array is returned. If there are no annotations set, then and array of empty arrays is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of arrays of <c>Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
						[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.Annotation.IAnnotation[][]); }
				}

				/// <summary>
				///  <para>Indicates whether or not this method takes a variable number argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a vararg is declared, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isVarArgs
				/// </java-name>
				public bool IsVarArgs
				{
						[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether or not this method is a bridge.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this method is a bridge, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBridge
				/// </java-name>
				public bool IsBridge
				{
						[Dot42.DexImport("isBridge", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether or not this method is synthetic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this method is synthetic, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the default value for the annotation member represented by this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default value, or <c>null </c> if none</para>
				/// </returns>
				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				public object DefaultValue
				{
						[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <summary>
				///  <para>Returns the class that declares this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <summary>
				///  <para>Returns the exception types as an array of <c>Class </c> instances. If this method has no declared exceptions, an empty array is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
						[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <summary>
				///  <para>Returns the modifiers for this method. The Modifier class should be used to decode the result.</para> <para> <para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modifiers for this method</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the name of the method represented by this <c>Method </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this method </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns an array of <c>Class </c> objects associated with the parameter types of this method. If the method was declared with no parameters, an empty array will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
						[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type[]); }
				}

				/// <summary>
				///  <para>Returns the <c>Class </c> associated with the return type of this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the return type </para>
				/// </returns>
				/// <java-name>
				/// getReturnType
				/// </java-name>
				public global::System.Type ReturnType
				{
						[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

		}

		/// <summary>
		///  <para>This class provides static methods to decode class and member modifiers.</para> <para> <para>Class::getModifiers() </para> <para>Member::getModifiers() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Modifier
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Modifier", AccessFlags = 33)]
		public partial class Modifier
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>public </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PUBLIC
				/// </java-name>
				[Dot42.DexImport("PUBLIC", "I", AccessFlags = 25)]
				public const int PUBLIC = 1;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>private </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PRIVATE
				/// </java-name>
				[Dot42.DexImport("PRIVATE", "I", AccessFlags = 25)]
				public const int PRIVATE = 2;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>protected </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTED
				/// </java-name>
				[Dot42.DexImport("PROTECTED", "I", AccessFlags = 25)]
				public const int PROTECTED = 4;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>static </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// STATIC
				/// </java-name>
				[Dot42.DexImport("STATIC", "I", AccessFlags = 25)]
				public const int STATIC = 8;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>final </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// FINAL
				/// </java-name>
				[Dot42.DexImport("FINAL", "I", AccessFlags = 25)]
				public const int FINAL = 16;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>synchronized </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// SYNCHRONIZED
				/// </java-name>
				[Dot42.DexImport("SYNCHRONIZED", "I", AccessFlags = 25)]
				public const int SYNCHRONIZED = 32;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>volatile </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// VOLATILE
				/// </java-name>
				[Dot42.DexImport("VOLATILE", "I", AccessFlags = 25)]
				public const int VOLATILE = 64;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>transient </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIENT
				/// </java-name>
				[Dot42.DexImport("TRANSIENT", "I", AccessFlags = 25)]
				public const int TRANSIENT = 128;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>native </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// NATIVE
				/// </java-name>
				[Dot42.DexImport("NATIVE", "I", AccessFlags = 25)]
				public const int NATIVE = 256;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>interface </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// INTERFACE
				/// </java-name>
				[Dot42.DexImport("INTERFACE", "I", AccessFlags = 25)]
				public const int INTERFACE = 512;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>abstract </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// ABSTRACT
				/// </java-name>
				[Dot42.DexImport("ABSTRACT", "I", AccessFlags = 25)]
				public const int ABSTRACT = 1024;
				/// <summary>
				///  <para>The <c>int </c> value representing the <c>strictfp </c> modifier. </para>        
				/// </summary>
				/// <java-name>
				/// STRICT
				/// </java-name>
				[Dot42.DexImport("STRICT", "I", AccessFlags = 25)]
				public const int STRICT = 2048;
				/// <summary>
				///  <para>Constructs a new <c>Modifier </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Modifier() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a mask of all the modifiers that may be applied to classes.  <para>1.7 </para></para>        
				/// </summary>
				/// <java-name>
				/// classModifiers
				/// </java-name>
				[Dot42.DexImport("classModifiers", "()I", AccessFlags = 9)]
				public static int ClassModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a mask of all the modifiers that may be applied to constructors.  <para>1.7 </para></para>        
				/// </summary>
				/// <java-name>
				/// constructorModifiers
				/// </java-name>
				[Dot42.DexImport("constructorModifiers", "()I", AccessFlags = 9)]
				public static int ConstructorModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a mask of all the modifiers that may be applied to fields.  <para>1.7 </para></para>        
				/// </summary>
				/// <java-name>
				/// fieldModifiers
				/// </java-name>
				[Dot42.DexImport("fieldModifiers", "()I", AccessFlags = 9)]
				public static int FieldModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a mask of all the modifiers that may be applied to interfaces.  <para>1.7 </para></para>        
				/// </summary>
				/// <java-name>
				/// interfaceModifiers
				/// </java-name>
				[Dot42.DexImport("interfaceModifiers", "()I", AccessFlags = 9)]
				public static int InterfaceModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a mask of all the modifiers that may be applied to methods.  <para>1.7 </para></para>        
				/// </summary>
				/// <java-name>
				/// methodModifiers
				/// </java-name>
				[Dot42.DexImport("methodModifiers", "()I", AccessFlags = 9)]
				public static int MethodModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain ABSTRACT. </para>        
				/// </summary>
				/// <java-name>
				/// isAbstract
				/// </java-name>
				[Dot42.DexImport("isAbstract", "(I)Z", AccessFlags = 9)]
				public static bool IsAbstract(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain FINAL. </para>        
				/// </summary>
				/// <java-name>
				/// isFinal
				/// </java-name>
				[Dot42.DexImport("isFinal", "(I)Z", AccessFlags = 9)]
				public static bool IsFinal(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain INTERFACE. </para>        
				/// </summary>
				/// <java-name>
				/// isInterface
				/// </java-name>
				[Dot42.DexImport("isInterface", "(I)Z", AccessFlags = 9)]
				public static bool IsInterface(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain NATIVE. </para>        
				/// </summary>
				/// <java-name>
				/// isNative
				/// </java-name>
				[Dot42.DexImport("isNative", "(I)Z", AccessFlags = 9)]
				public static bool IsNative(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain PRIVATE. </para>        
				/// </summary>
				/// <java-name>
				/// isPrivate
				/// </java-name>
				[Dot42.DexImport("isPrivate", "(I)Z", AccessFlags = 9)]
				public static bool IsPrivate(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain PROTECTED. </para>        
				/// </summary>
				/// <java-name>
				/// isProtected
				/// </java-name>
				[Dot42.DexImport("isProtected", "(I)Z", AccessFlags = 9)]
				public static bool IsProtected(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain PUBLIC. </para>        
				/// </summary>
				/// <java-name>
				/// isPublic
				/// </java-name>
				[Dot42.DexImport("isPublic", "(I)Z", AccessFlags = 9)]
				public static bool IsPublic(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain STATIC. </para>        
				/// </summary>
				/// <java-name>
				/// isStatic
				/// </java-name>
				[Dot42.DexImport("isStatic", "(I)Z", AccessFlags = 9)]
				public static bool IsStatic(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain STRICT. </para>        
				/// </summary>
				/// <java-name>
				/// isStrict
				/// </java-name>
				[Dot42.DexImport("isStrict", "(I)Z", AccessFlags = 9)]
				public static bool IsStrict(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain SYNCHRONIZED. </para>        
				/// </summary>
				/// <java-name>
				/// isSynchronized
				/// </java-name>
				[Dot42.DexImport("isSynchronized", "(I)Z", AccessFlags = 9)]
				public static bool IsSynchronized(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain TRANSIENT. </para>        
				/// </summary>
				/// <java-name>
				/// isTransient
				/// </java-name>
				[Dot42.DexImport("isTransient", "(I)Z", AccessFlags = 9)]
				public static bool IsTransient(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the given modifiers contain VOLATILE. </para>        
				/// </summary>
				/// <java-name>
				/// isVolatile
				/// </java-name>
				[Dot42.DexImport("isVolatile", "(I)Z", AccessFlags = 9)]
				public static bool IsVolatile(int modifiers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a string containing the string representation of all modifiers present in the specified modifiers. Modifiers appear in the order specified by the Java Language Specification. </para>        
				/// </summary>
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
		///  <para> <c>Proxy </c> defines methods for creating dynamic proxy classes and instances. A proxy class implements a declared set of interfaces and delegates method invocations to an <c>InvocationHandler </c> .</para> <para> <para>InvocationHandler </para> <para>1.3 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Proxy
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Proxy", AccessFlags = 33)]
		public partial class Proxy : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The invocation handler on which the method calls are dispatched. </para>        
				/// </summary>
				/// <java-name>
				/// h
				/// </java-name>
				[Dot42.DexImport("h", "Ljava/lang/reflect/InvocationHandler;", AccessFlags = 4)]
				protected internal global::Java.Lang.Reflect.IInvocationHandler H;
				/// <summary>
				///  <para>Constructs a new <c>Proxy </c> instance with the specified invocation handler.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/InvocationHandler;)V", AccessFlags = 4)]
				protected internal Proxy(global::Java.Lang.Reflect.IInvocationHandler h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the dynamically built <c>Class </c> for the specified interfaces. Creates a new <c>Class </c> when necessary. The order of the interfaces is relevant. Invocations of this method with the same interfaces but different order result in different generated classes. The interfaces must be visible from the supplied class loader; no duplicates are permitted. All non-public interfaces must be defined in the same package.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a proxy class that implements all of the interfaces referred to in the contents of <c>interfaces </c> </para>
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
				///  <para>Returns an instance of the dynamically built class for the specified interfaces. Method invocations on the returned instance are forwarded to the specified invocation handler. The interfaces must be visible from the supplied class loader; no duplicates are permitted. All non-public interfaces must be defined in the same package.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new proxy object that delegates to the handler <c>h </c> </para>
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
				///  <para>Indicates whether or not the specified class is a dynamically generated proxy class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the class is a proxy class, <c>false </c> otherwise </para>
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
				///  <para>Returns the invocation handler of the specified proxy instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the invocation handler of the specified proxy instance </para>
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
		///  <para>Legacy security code; do not use. </para>    
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

		/// <summary>
		///  <para>This class provides a wrapper for an undeclared, checked exception thrown by an InvocationHandler.</para> <para> <para>java.lang.reflect.InvocationHandler::invoke </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/UndeclaredThrowableException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/UndeclaredThrowableException", AccessFlags = 33)]
		public partial class UndeclaredThrowableException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UndeclaredThrowableException </c> instance with the undeclared, checked exception that occurred.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UndeclaredThrowableException </c> instance with the undeclared, checked exception that occurred and a message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public UndeclaredThrowableException(global::System.Exception exception, string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UndeclaredThrowableException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the undeclared, checked exception that occurred, which may be  <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the undeclared, checked exception that occurred </para>
				/// </returns>
				/// <java-name>
				/// getUndeclaredThrowable
				/// </java-name>
				public virtual global::System.Exception UndeclaredThrowable
				{
						[Dot42.DexImport("getUndeclaredThrowable", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Returns the undeclared, checked exception that occurred, which may be  <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the undeclared, checked exception that occurred </para>
				/// </returns>
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

