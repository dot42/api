#pragma warning disable 1717
namespace Javax.Security.Auth.Login
{
		/// <summary>
		///  <para>Base class for exceptions that are thrown when a login error occurs. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/login/LoginException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/login/LoginException", AccessFlags = 33)]
		public partial class LoginException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new exception instance and initializes it with default values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LoginException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new exception instance and initializes it with a given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LoginException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

}

