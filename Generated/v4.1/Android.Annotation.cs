#pragma warning disable 1717
namespace Android.Annotation
{
		/// <summary>
		///  <para>Indicates that Lint should ignore the specified warnings for the annotated element. </para>    
		/// </summary>
		/// <java-name>
		/// android/annotation/SuppressLint
		/// </java-name>
		[Dot42.DexImport("android/annotation/SuppressLint", AccessFlags = 9729)]
		public partial interface ISuppressLint : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The set of warnings (identified by the lint issue id) that should be ignored by lint. It is not an error to specify an unrecognized name. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] Value() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Indicates that Lint should treat this type as targeting a given API level, no matter what the project target is. </para>    
		/// </summary>
		/// <java-name>
		/// android/annotation/TargetApi
		/// </java-name>
		[Dot42.DexImport("android/annotation/TargetApi", AccessFlags = 9729)]
		public partial interface ITargetApi : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This sets the target api level for the type.. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()I", AccessFlags = 1025)]
				int Value() /* MethodBuilder.Create */ ;

		}

}

