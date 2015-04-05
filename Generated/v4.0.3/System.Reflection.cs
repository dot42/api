#pragma warning disable 1717
namespace System.Reflection
{
		/// <java-name>
		/// java/lang/reflect/InvocationTargetException
		/// </java-name>
		[Dot42.DexImport("java/lang/reflect/InvocationTargetException", AccessFlags = 33)]
		public partial class TargetInvocationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TargetInvocationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TargetInvocationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;Ljava/lang/String;)V", AccessFlags = 1)]
				public TargetInvocationException(global::System.Exception exception, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetException
				/// </java-name>
				public virtual global::System.Exception TargetException
				{
						[Dot42.DexImport("getTargetException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
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

