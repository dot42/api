// Copyright (C) 2014 dot42
//
// Original filename: System.Reflection.cs
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
namespace System.Reflection
{
		/// <summary>
		/// <para>This class represents a field. Information about the field can be accessed, and the field's value can be accessed dynamically. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Field
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Field", AccessFlags = 49)]
		public sealed partial class FieldInfo : global::System.Reflection.MemberInfo, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FieldInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not this field is synthetic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this field is synthetic, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the string representation of this field, including the field's generic type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this field </para>
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
				/// <para>Indicates whether or not this field is an enumeration constant.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this field is an enumeration constant, <c>               false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isEnumConstant
				/// </java-name>
				[Dot42.DexImport("isEnumConstant", "()Z", AccessFlags = 1)]
				public bool IsEnumConstant() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the generic type of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generic type </para>
				/// </returns>
				/// <java-name>
				/// getGenericType
				/// </java-name>
				[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified <c> object </c> is equal to this field. To be equal, the specified object must be an instance of <c> Field </c> with the same declaring class, type and name as this field.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this method, <c> false </c> otherwise </para>
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
				/// <para>Returns the value of the field in the specified object. This reproduces the effect of <c> object.fieldName </c></para><para>If the type of this field is a primitive type, the field value is automatically boxed.</para><para>If this field is static, the object argument is ignored. Otherwise, if the object is null, a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown.</para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value, possibly boxed </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public object GetValue(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the value of the field in the specified object as a <c>       boolean </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as a <c> byte </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as a <c> byte </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as a <c> char </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the class that declares this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the value of the field in the specified object as a <c>       double </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as a <c> float </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as an <c> int </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the value of the field in the specified object as a <c> long </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Returns the modifiers for this field. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this field </para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this field </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value of the field in the specified object as a <c> short </c> . This reproduces the effect of <c> object.fieldName </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the field value </para>
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
				/// <para>Return the Class associated with the type of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the type of this field </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public new global::System.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an integer hash code for this field. Objects which are equal return the same value for this method. </para><para>The hash code for a Field is the exclusive-or combination of the hash code of the field's name and the hash code of the name of its declaring class.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code for this field </para>
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
				/// <para>Sets the value of the field in the specified object to the value. This reproduces the effect of <c> object.fieldName = value </c></para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown.</para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown.</para><para>If the field type is a primitive type, the value is automatically unboxed. If the unboxing fails, an IllegalArgumentException is thrown. If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void Set(object @object, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c>       boolean </c> value. This reproduces the effect of <c> object.fieldName =       value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public void SetBoolean(object @object, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> byte </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1)]
				public void SetByte(object @object, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> byte </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/Object;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void SetByte(object @object, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> char </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(Ljava/lang/Object;C)V", AccessFlags = 1)]
				public void SetChar(object @object, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> double </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/Object;D)V", AccessFlags = 1)]
				public void SetDouble(object @object, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> float </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/Object;F)V", AccessFlags = 1)]
				public void SetFloat(object @object, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the value of the field in the specified object to the <c> int </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/Object;I)V", AccessFlags = 1)]
				public void SetInt(object @object, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> long </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/Object;J)V", AccessFlags = 1)]
				public void SetLong(object @object, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value of the field in the specified object to the <c> short </c> value. This reproduces the effect of <c> object.fieldName = value </c> </para><para>If this field is static, the object argument is ignored. Otherwise, if the object is <c> null </c> , a NullPointerException is thrown. If the object is not an instance of the declaring class of the method, an IllegalArgumentException is thrown. </para><para>If this Field object is enforcing access control (see AccessibleObject) and this field is not accessible from the current context, an IllegalAccessException is thrown. </para><para>If the value cannot be converted to the field type via a widening conversion, an IllegalArgumentException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/Object;S)V", AccessFlags = 1)]
				public void SetShort(object @object, short value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of this field. </para><para>The format of the string is: <ol><li><para>modifiers (if any) </para></li><li><para>type </para></li><li><para>declaring class name </para></li><li><para>'.' </para></li><li><para>field name </para></li></ol></para><para>For example: <c> public static java.io.InputStream       java.lang.System.in </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this field </para>
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
				/// <para>Returns the generic type of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generic type </para>
				/// </returns>
				/// <java-name>
				/// getGenericType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericType
				{
				[Dot42.DexImport("getGenericType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericType(); }
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <summary>
				/// <para>Returns the class that declares this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <summary>
				/// <para>Returns the modifiers for this field. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this field </para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <summary>
				/// <para>Returns the name of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this field </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Return the Class associated with the type of this field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the type of this field </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetType(); }
				}

		}

		/// <summary>
		/// <para>This class represents a method. Information about the method can be accessed, and the method can be invoked dynamically. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Method
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Method", AccessFlags = 49)]
		public sealed partial class MethodInfo : global::System.Reflection.MemberInfo, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MethodInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.MethodInfo>[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.MethodInfo>[]);
				}

				/// <summary>
				/// <para>Returns the string representation of the method's declaration, including the type parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this method </para>
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
				/// <para>Returns the parameter types as an array of <c> Type </c> instances, in declaration order. If this method has no parameters, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Type </c> instances. If this method has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <summary>
				/// <para>Returns the return type of this method as a <c> Type </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return type of this method</para>
				/// </returns>
				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericReturnType() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				/// <para>Returns an array of arrays that represent the annotations of the formal parameters of this method. If there are no parameters on this method, then an empty array is returned. If there are no annotations set, then and array of empty arrays is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of arrays of <c> Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[][] GetParameterAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[][]);
				}

				/// <summary>
				/// <para>Indicates whether or not this method takes a variable number argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if a vararg is declared, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isVarArgs
				/// </java-name>
				[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
				public bool IsVarArgs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this method is a bridge.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this method is a bridge, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBridge
				/// </java-name>
				[Dot42.DexImport("isBridge", "()Z", AccessFlags = 1)]
				public bool IsBridge() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this method is synthetic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this method is synthetic, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the default value for the annotation member represented by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default value, or <c> null </c> if none</para>
				/// </returns>
				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object GetDefaultValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified <c> object </c> is equal to this method. To be equal, the specified object must be an instance of <c> Method </c> with the same declaring class and parameter types as this method.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this method, <c> false </c> otherwise</para>
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
				/// <para>Returns the class that declares this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Class </c> instances. If this method has no declared exceptions, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns the modifiers for this method. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this method</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the method represented by this <c> Method </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this method </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an array of <c> Class </c> objects associated with the parameter types of this method. If the method was declared with no parameters, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns the <c> Class </c> associated with the return type of this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return type </para>
				/// </returns>
				/// <java-name>
				/// getReturnType
				/// </java-name>
				[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetReturnType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an integer hash code for this method. Objects which are equal return the same value for this method. The hash code for this Method is the hash code of the name of this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>hash code for this method</para>
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
				/// <para>Returns the result of dynamically invoking this method. Equivalent to <c> receiver.methodName(arg1, arg2, ... , argN) </c> .</para><para>If the method is static, the receiver argument is ignored (and may be null).</para><para>If the method takes no arguments, you can pass <c> (Object[]) null </c> instead of allocating an empty array.</para><para>If you're calling a varargs method, you need to pass an <c> Object[] </c> for the varargs parameter: that conversion is usually done in <c> javac </c> , not the VM, and the reflection machinery does not do this for you. (It couldn't, because it would be ambiguous.)</para><para>Reflective method invocation follows the usual process for method lookup.</para><para>If an exception is thrown during the invocation it is caught and wrapped in an InvocationTargetException. This exception is then thrown.</para><para>If the invocation completes normally, the return value itself is returned. If the method is declared to return a primitive type, the return value is boxed. If the return type is void, null is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result</para>
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
				/// <para>Returns a string containing a concise, human-readable description of this method. The format of the string is:</para><para><ol><li><para>modifiers (if any) </para></li><li><para>return type or 'void' </para></li><li><para>declaring class name </para></li><li><para>'(' </para></li><li><para>parameter types, separated by ',' (if any) </para></li><li><para>')' </para></li><li><para>'throws' plus exception types, separated by ',' (if any) </para></li></ol></para><para>For example: <c> public native Object       java.lang.Method.invoke(Object,Object) throws       IllegalAccessException,IllegalArgumentException       ,InvocationTargetException </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this method </para>
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
				/// <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.MethodInfo>[] TypeParameters
				{
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Method;>;")]
						get{ return GetTypeParameters(); }
				}

				/// <summary>
				/// <para>Returns the parameter types as an array of <c> Type </c> instances, in declaration order. If this method has no parameters, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericParameterTypes(); }
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Type </c> instances. If this method has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericExceptionTypes(); }
				}

				/// <summary>
				/// <para>Returns the return type of this method as a <c> Type </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return type of this method</para>
				/// </returns>
				/// <java-name>
				/// getGenericReturnType
				/// </java-name>
				public global::Java.Lang.Reflect.IType GenericReturnType
				{
				[Dot42.DexImport("getGenericReturnType", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericReturnType(); }
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <summary>
				/// <para>Returns an array of arrays that represent the annotations of the formal parameters of this method. If there are no parameters on this method, then an empty array is returned. If there are no annotations set, then and array of empty arrays is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of arrays of <c> Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetParameterAnnotations(); }
				}

				/// <summary>
				/// <para>Returns the default value for the annotation member represented by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default value, or <c> null </c> if none</para>
				/// </returns>
				/// <java-name>
				/// getDefaultValue
				/// </java-name>
				public object DefaultValue
				{
				[Dot42.DexImport("getDefaultValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetDefaultValue(); }
				}

				/// <summary>
				/// <para>Returns the class that declares this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Class </c> instances. If this method has no declared exceptions, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetExceptionTypes(); }
				}

				/// <summary>
				/// <para>Returns the modifiers for this method. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this method</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <summary>
				/// <para>Returns the name of the method represented by this <c> Method </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this method </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns an array of <c> Class </c> objects associated with the parameter types of this method. If the method was declared with no parameters, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetParameterTypes(); }
				}

				/// <summary>
				/// <para>Returns the <c> Class </c> associated with the return type of this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return type </para>
				/// </returns>
				/// <java-name>
				/// getReturnType
				/// </java-name>
				public global::System.Type ReturnType
				{
				[Dot42.DexImport("getReturnType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetReturnType(); }
				}

		}

		/// <summary>
		/// <para><c> AccessibleObject </c> is the superclass of all member reflection classes (Field, Constructor, Method). AccessibleObject provides the ability to toggle a flag controlling access checks for these objects. By default, accessing a member (for example, setting a field or invoking a method) checks the validity of the access (for example, invoking a private method from outside the defining class is prohibited) and throws IllegalAccessException if the operation is not permitted. If the accessible flag is set to true, these checks are omitted. This allows privileged code, such as Java object serialization, object inspectors, and debuggers to have complete access to objects.</para><para><para>Field </para><simplesectsep></simplesectsep><para>Constructor </para><simplesectsep></simplesectsep><para>Method </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/AccessibleObject
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/AccessibleObject", AccessFlags = 33)]
		public partial class MemberInfo : global::Java.Lang.Reflect.IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> AccessibleObject </c> instance. <c>       AccessibleObject </c> instances can only be constructed by the virtual machine. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal MemberInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to set the value of the accessible flag for all the objects in the array provided. Setting this flag to <c> false </c> will enable access checks, setting to <c> true </c> will disable them.</para><para><para>setAccessible(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setAccessible
				/// </java-name>
				[Dot42.DexImport("setAccessible", "([Ljava/lang/reflect/AccessibleObject;Z)V", AccessFlags = 9)]
				public static void SetAccessible(global::System.Reflection.MemberInfo[] objects, bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this object is accessible without access checks being performed. Returns the accessible flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this object is accessible without access checks, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAccessible
				/// </java-name>
				[Dot42.DexImport("isAccessible", "()Z", AccessFlags = 1)]
				public virtual bool IsAccessible() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to set the value of the accessible flag. Setting this flag to <c> false </c> will enable access checks, setting to <c> true </c> will disable them.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAccessible
				/// </java-name>
				[Dot42.DexImport("setAccessible", "(Z)V", AccessFlags = 1)]
				public virtual void SetAccessible(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the annotation exists, <c> false </c> otherwise </para>
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
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
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
				/// <para>Returns, for this element, an array containing all annotations (including inherited annotations). If there are no annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of all annotations for this element </para>
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
				/// <para>Returns, for this element, the annotation with the specified type, or <c> null </c> if no annotation with the specified type is present (including inherited annotations).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the annotation with the specified type or <c> null </c> </para>
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
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <summary>
				/// <para>Returns, for this element, an array containing all annotations (including inherited annotations). If there are no annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of all annotations for this element </para>
				/// </returns>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] Annotations
				{
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetAnnotations(); }
				}

		}

		/// <summary>
		/// <para>This class represents a constructor. Information about the constructor can be accessed, and the constructor can be invoked dynamically.</para><para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/reflect/Constructor
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/Constructor", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/reflect/AccessibleObject;Ljava/lang/reflect/Gene" +
    "ricDeclaration;Ljava/lang/reflect/Member;")]
		public sealed partial class ConstructorInfo : global::System.Reflection.MemberInfo, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IMember
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Prevent this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConstructorInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.ConstructorInfo>[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.ConstructorInfo>[]);
				}

				/// <summary>
				/// <para>Returns the string representation of the constructor's declaration, including the type parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of the constructor's declaration </para>
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
				/// <para>Returns the generic parameter types as an array of <c> Type </c> instances, in declaration order. If this constructor has no generic parameters, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Type </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public override global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				/// <para>Returns an array of arrays that represent the annotations of the formal parameters of this constructor. If there are no parameters on this constructor, then an empty array is returned. If there are no annotations set, then an array of empty arrays is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of arrays of <c> Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[][] GetParameterAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[][]);
				}

				/// <summary>
				/// <para>Indicates whether or not this constructor takes a variable number of arguments.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if a vararg is declare, otherwise <c> false </c> </para>
				/// </returns>
				/// <java-name>
				/// isVarArgs
				/// </java-name>
				[Dot42.DexImport("isVarArgs", "()Z", AccessFlags = 1)]
				public bool IsVarArgs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this constructor is synthetic (artificially introduced by the compiler).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this constructor is synthetic, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool IsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the specified <c> object </c> is equal to this constructor. To be equal, the specified object must be an instance of <c> Constructor </c> with the same declaring class and parameter types as this constructor.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this constructor, <c> false </c> otherwise</para>
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
				/// <para>Returns the class that declares this constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Class </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetExceptionTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns the modifiers for this constructor. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this constructor</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of this constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this constructor </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an array of the <c> Class </c> objects associated with the parameter types of this constructor. If the constructor was declared with no parameters, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetParameterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns an integer hash code for this constructor. Constructors which are equal return the same value for this method. The hash code for a Constructor is the hash code of the name of the declaring class.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code</para>
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
				/// <para>Returns a new instance of the declaring class, initialized by dynamically invoking the constructor represented by this <c> Constructor </c> object. This reproduces the effect of <c> new declaringClass(arg1, arg2, ... ,       argN) </c> This method performs the following: <ul><li><para>A new instance of the declaring class is created. If the declaring class cannot be instantiated (i.e. abstract class, an interface, an array type, or a primitive type) then an InstantiationException is thrown. </para></li><li><para>If this Constructor object is enforcing access control (see AccessibleObject) and this constructor is not accessible from the current context, an IllegalAccessException is thrown. </para></li><li><para>If the number of arguments passed and the number of parameters do not match, an IllegalArgumentException is thrown. </para></li><li><para>For each argument passed: <ul><li><para>If the corresponding parameter type is a primitive type, the argument is unboxed. If the unboxing fails, an IllegalArgumentException is thrown. </para></li><li><para>If the resulting argument cannot be converted to the parameter type via a widening conversion, an IllegalArgumentException is thrown. </para></li></ul></para></li><li><para>The constructor represented by this <c> Constructor </c> object is then invoked. If an exception is thrown during the invocation, it is caught and wrapped in an InvocationTargetException. This exception is then thrown. If the invocation completes normally, the newly initialized object is returned. </para></li></ul></para><para><para>AccessibleObject </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new, initialized, object</para>
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
				/// <para>Returns a string containing a concise, human-readable description of this constructor. The format of the string is:</para><para><ol><li><para>modifiers (if any) </para></li><li><para>declaring class name </para></li><li><para>'(' </para></li><li><para>parameter types, separated by ',' (if any) </para></li><li><para>')' </para></li><li><para>'throws' plus exception types, separated by ',' (if any) </para></li></ol></para><para>For example: <c> public String(byte[],String) throws UnsupportedEncodingException </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this constructor </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("java/lang/reflect/GenericDeclaration", "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1025, Signature = "()[Ljava/lang/reflect/TypeVariable<*>;")]
				global::Java.Lang.Reflect.ITypeVariable<object>[] global::Java.Lang.Reflect.IGenericDeclaration.GetTypeParameters() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<object>[]);
				}

				/// <summary>
				/// <para>Returns the declared type parameters in declaration order. If there are no type parameters, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared type parameters in declaration order </para>
				/// </returns>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Reflection.ConstructorInfo>[] TypeParameters
				{
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/reflect/Constructor<TT;>;>;")]
						get{ return GetTypeParameters(); }
				}

				/// <summary>
				/// <para>Returns the generic parameter types as an array of <c> Type </c> instances, in declaration order. If this constructor has no generic parameters, an empty array is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types</para>
				/// </returns>
				/// <java-name>
				/// getGenericParameterTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericParameterTypes
				{
				[Dot42.DexImport("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericParameterTypes(); }
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Type </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of generic exception types</para>
				/// </returns>
				/// <java-name>
				/// getGenericExceptionTypes
				/// </java-name>
				public global::Java.Lang.Reflect.IType[] GenericExceptionTypes
				{
				[Dot42.DexImport("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
						get{ return GetGenericExceptionTypes(); }
				}

				/// <summary>
				/// <para>Returns, for this element, all annotations that are explicitly declared (not inherited). If there are no declared annotations present, this method returns a zero length array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of annotations declared for this element </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[] DeclaredAnnotations
				{
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetDeclaredAnnotations(); }
				}

				/// <summary>
				/// <para>Returns an array of arrays that represent the annotations of the formal parameters of this constructor. If there are no parameters on this constructor, then an empty array is returned. If there are no annotations set, then an array of empty arrays is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of arrays of <c> Annotation </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getParameterAnnotations
				/// </java-name>
				public global::Java.Lang.Annotation.IAnnotation[][] ParameterAnnotations
				{
				[Dot42.DexImport("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
						get{ return GetParameterAnnotations(); }
				}

				/// <summary>
				/// <para>Returns the class that declares this constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declaring class </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<TT;>;")]
						get{ return GetDeclaringClass(); }
				}

				/// <summary>
				/// <para>Returns the exception types as an array of <c> Class </c> instances. If this constructor has no declared exceptions, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the declared exception classes </para>
				/// </returns>
				/// <java-name>
				/// getExceptionTypes
				/// </java-name>
				public global::System.Type[] ExceptionTypes
				{
				[Dot42.DexImport("getExceptionTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetExceptionTypes(); }
				}

				/// <summary>
				/// <para>Returns the modifiers for this constructor. The Modifier class should be used to decode the result.</para><para><para>Modifier </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modifiers for this constructor</para>
				/// </returns>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
						get{ return GetModifiers(); }
				}

				/// <summary>
				/// <para>Returns the name of this constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this constructor </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns an array of the <c> Class </c> objects associated with the parameter types of this constructor. If the constructor was declared with no parameters, an empty array will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter types </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypes
				/// </java-name>
				public global::System.Type[] ParameterTypes
				{
				[Dot42.DexImport("getParameterTypes", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
						get{ return GetParameterTypes(); }
				}

		}

}


