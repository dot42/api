#pragma warning disable 1717
namespace Dalvik.Annotation
{
		/// <java-name>
		/// dalvik/annotation/TestTarget
		/// </java-name>
		[Dot42.DexImport("dalvik/annotation/TestTarget", AccessFlags = 9729)]
		public partial interface ITestTarget : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// methodName
				/// </java-name>
				[Dot42.DexImport("methodName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string MethodName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// conceptName
				/// </java-name>
				[Dot42.DexImport("conceptName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ConceptName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// methodArgs
				/// </java-name>
				[Dot42.DexImport("methodArgs", "()[Ljava/lang/Class;", AccessFlags = 1025, Signature = "()[Ljava/lang/Class<*>;")]
				global::System.Type[] MethodArgs() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// dalvik/annotation/TestTargetClass
		/// </java-name>
		[Dot42.DexImport("dalvik/annotation/TestTargetClass", AccessFlags = 9729)]
		public partial interface ITestTargetClass : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<*>;")]
				global::System.Type Value() /* MethodBuilder.Create */ ;

		}

}

