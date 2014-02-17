// Copyright (C) 2014 dot42
//
// Original filename: Java.Lang.Annotation.cs
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
namespace Java.Lang.Annotation
{
		/// <java-name>
		/// java/lang/annotation/ElementType
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/ElementType", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/lang/annotation/ElementType;>;")]
		public sealed class ElementType
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ANNOTATION_TYPE
				/// </java-name>
				[Dot42.DexImport("ANNOTATION_TYPE", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType ANNOTATION_TYPE;
				/// <java-name>
				/// CONSTRUCTOR
				/// </java-name>
				[Dot42.DexImport("CONSTRUCTOR", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType CONSTRUCTOR;
				/// <java-name>
				/// FIELD
				/// </java-name>
				[Dot42.DexImport("FIELD", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType FIELD;
				/// <java-name>
				/// LOCAL_VARIABLE
				/// </java-name>
				[Dot42.DexImport("LOCAL_VARIABLE", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType LOCAL_VARIABLE;
				/// <java-name>
				/// METHOD
				/// </java-name>
				[Dot42.DexImport("METHOD", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType METHOD;
				/// <java-name>
				/// PACKAGE
				/// </java-name>
				[Dot42.DexImport("PACKAGE", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType PACKAGE;
				/// <java-name>
				/// PARAMETER
				/// </java-name>
				[Dot42.DexImport("PARAMETER", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType PARAMETER;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/annotation/ElementType;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.ElementType TYPE;
				private ElementType() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

		}

		/// <summary>
		/// <para>Indicates that an annotation type has changed since it was compiled or serialized.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/AnnotationTypeMismatchException
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/AnnotationTypeMismatchException", AccessFlags = 33)]
		public partial class AnnotationTypeMismatchException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an instance for the given type element and the type found.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/Method;Ljava/lang/String;)V", AccessFlags = 1)]
				public AnnotationTypeMismatchException(global::System.Reflection.MethodInfo element, string foundType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the method object for the invalid type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Method instance. </para>
				/// </returns>
				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/reflect/Method;", AccessFlags = 1)]
				public virtual global::System.Reflection.MethodInfo Element() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo);
				}

				/// <summary>
				/// <para>Returns the invalid type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string describing the invalid data. </para>
				/// </returns>
				/// <java-name>
				/// foundType
				/// </java-name>
				[Dot42.DexImport("foundType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string FoundType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AnnotationTypeMismatchException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines a meta-annotation for indicating that an annotation is documented and considered part of the public API.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/Documented
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Documented", AccessFlags = 9729)]
		public partial interface IDocumented : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Indicates that an annotation in the binary representation of a class is syntactically incorrect and the annotation parser is unable to process it. This exception is unlikely to ever occur, given that the code has been compiled by an ordinary Java compiler.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/AnnotationFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/AnnotationFormatError", AccessFlags = 33)]
		public partial class AnnotationFormatError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an instance with the message provided.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AnnotationFormatError(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an instance with a message and a cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AnnotationFormatError(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an instance with the message provided.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AnnotationFormatError(global::System.Exception message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AnnotationFormatError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines the interface implemented by all annotations. Note that the interface itself is <b>not</b> an annotation, and neither is an interface that simply extends this one. Only the compiler is able to create proper annotation types.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/Annotation
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Annotation", AccessFlags = 1537)]
		public partial interface IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the type of this annotation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A <c> Class </c> instance representing the annotation type. </para>
				/// </returns>
				/// <java-name>
				/// annotationType
				/// </java-name>
				[Dot42.DexImport("annotationType", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
				global::System.Type AnnotationType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Determines whether or not this annotation is equivalent to the annotation passed. This is determined according to the following rules:</para><para><ul><li><para>Two annotations <c> x </c> and <c> y </c> are equal if and only if they are members of the same annotation type and all the member values of <c> x </c> are equal to the corresponding member values of <c> y </c> .  </para></li><li><para>The equality of primitive member values <c> x </c> and <c> y </c> is determined (in a way similar to) using the corresponding wrapper classes. For example, <c> Integer.valueOf(x).equals(Integer.valueOf(y) </c> is used for <c> int </c> values. Note: The behavior is identical to the <c> == </c> operator for all but the floating point type, so the implementation may as well use <c> == </c> in these cases for performance reasons. Only for the <c> float </c> and <c> double </c> types the result will be slightly different: <c> NaN </c> is equal to <c> NaN </c> , and <c> -0.0 </c> is equal to <c> 0.0 </c> , both of which is normally not the case.  </para></li><li><para>The equality of two array member values <c> x </c> and <c> y </c> is determined using the corresponding <c> equals(x, y) </c> helper function in java.util.Arrays.  </para></li><li><para>The hash code for all other member values is determined by simply calling their <c> equals() </c> method.  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> obj </c> is equal to this annotation, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object obj) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the hash code of this annotation. The hash code is determined according to the following rules:</para><para><ul><li><para>The hash code of an annotation is the sum of the hash codes of its annotation members.  </para></li><li><para>The hash code of an annotation member is calculated as <c>               (0x7f * n.hashCode()) ^ v.hashCode()) </c> , where <c> n </c> is the name of the member (as a <c> String </c> ) and <c> v </c> its value.  </para></li><li><para>The hash code for a primitive member value is determined using the corresponding wrapper type. For example, <c>               Integer.valueOf(v).hashCode() </c> is used for an <c> int </c> value <c> v </c> .  </para></li><li><para>The hash code for an array member value <c> v </c> is determined using the corresponding <c> hashCode(v) </c> helper function in java.util.Arrays.  </para></li><li><para>The hash code for all other member values is determined by simply calling their <c> hashCode </c> method.  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <c> String </c> representation of this annotation. It is not strictly defined what the representation has to look like, but it usually consists of the name of the annotation, preceded by a "@". If the annotation contains field members, their names and values are also included in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> String </c> that represents this annotation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates that an element of an annotation type was accessed that was added after the type was compiled or serialized. This does not apply to new elements that have default values.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/IncompleteAnnotationException
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/IncompleteAnnotationException", AccessFlags = 33)]
		public partial class IncompleteAnnotationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an instance with the incomplete annotation type and the name of the element that's missing.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;Ljava/lang/String;)V")]
				public IncompleteAnnotationException(global::System.Type annotationType, string elementName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the annotation type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Class instance. </para>
				/// </returns>
				/// <java-name>
				/// annotationType
				/// </java-name>
				[Dot42.DexImport("annotationType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
				public virtual global::System.Type AnnotationType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the incomplete element's name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the element. </para>
				/// </returns>
				/// <java-name>
				/// elementName
				/// </java-name>
				[Dot42.DexImport("elementName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ElementName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IncompleteAnnotationException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines a meta-annotation for determining the scope of retention for an annotation. If the retention annotation is not set <c>   RetentionPolicy.CLASS </c> is used as default retention.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/Retention
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Retention", AccessFlags = 9729)]
		public partial interface IRetention : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.RetentionPolicy Value() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/annotation/RetentionPolicy
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/RetentionPolicy", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/lang/annotation/RetentionPolicy;>;")]
		public sealed class RetentionPolicy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CLASS
				/// </java-name>
				[Dot42.DexImport("CLASS", "Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.RetentionPolicy CLASS;
				/// <java-name>
				/// RUNTIME
				/// </java-name>
				[Dot42.DexImport("RUNTIME", "Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.RetentionPolicy RUNTIME;
				/// <java-name>
				/// SOURCE
				/// </java-name>
				[Dot42.DexImport("SOURCE", "Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 16409)]
				public static readonly global::Java.Lang.Annotation.RetentionPolicy SOURCE;
				private RetentionPolicy() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines a meta-annotation for determining what ElementTypes an annotation can be applied to.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/Target
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Target", AccessFlags = 9729)]
		public partial interface ITarget : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()[Ljava/lang/annotation/ElementType;", AccessFlags = 1025)]
				global::Java.Lang.Annotation.ElementType[] Value() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Defines a meta-annotation for indicating that an annotation is automatically inherited.</para><para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/annotation/Inherited
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Inherited", AccessFlags = 9729)]
		public partial interface IInherited : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

}


