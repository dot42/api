#pragma warning disable 1717
namespace Java.Lang.Annotation
{
		/// <java-name>
		/// java/lang/annotation/AnnotationFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/AnnotationFormatError", AccessFlags = 33)]
		public partial class AnnotationFormatError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AnnotationFormatError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AnnotationFormatError(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AnnotationFormatError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AnnotationFormatError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/annotation/AnnotationTypeMismatchException
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/AnnotationTypeMismatchException", AccessFlags = 33)]
		public partial class AnnotationTypeMismatchException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/Method;Ljava/lang/String;)V", AccessFlags = 1)]
				public AnnotationTypeMismatchException(global::Java.Lang.Reflect.Method method, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// element
				/// </java-name>
				[Dot42.DexImport("element", "()Ljava/lang/reflect/Method;", AccessFlags = 1)]
				public virtual global::Java.Lang.Reflect.Method Element() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method);
				}

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

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/lang/annotation/ElementType;", AccessFlags = 9)]
				public static global::Java.Lang.Annotation.ElementType[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.ElementType[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/ElementType;", AccessFlags = 9)]
				public static global::Java.Lang.Annotation.ElementType ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.ElementType);
				}

		}

		/// <java-name>
		/// java/lang/annotation/Annotation
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Annotation", AccessFlags = 1537)]
		public partial interface IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// annotationType
				/// </java-name>
				[Dot42.DexImport("annotationType", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
				global::System.Type AnnotationType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/annotation/Documented
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Documented", AccessFlags = 9729)]
		public partial interface IDocumented : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/annotation/Inherited
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/Inherited", AccessFlags = 9729)]
		public partial interface IInherited : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/annotation/IncompleteAnnotationException
		/// </java-name>
		[Dot42.DexImport("java/lang/annotation/IncompleteAnnotationException", AccessFlags = 33)]
		public partial class IncompleteAnnotationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;Ljava/lang/String;)V")]
				public IncompleteAnnotationException(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// annotationType
				/// </java-name>
				[Dot42.DexImport("annotationType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
				public virtual global::System.Type AnnotationType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

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

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 9)]
				public static global::Java.Lang.Annotation.RetentionPolicy[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.RetentionPolicy[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;", AccessFlags = 9)]
				public static global::Java.Lang.Annotation.RetentionPolicy ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.RetentionPolicy);
				}

		}

}

