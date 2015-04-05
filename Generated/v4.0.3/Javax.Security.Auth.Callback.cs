#pragma warning disable 1717
namespace Javax.Security.Auth.Callback
{
		/// <java-name>
		/// javax/security/auth/callback/Callback
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/Callback", AccessFlags = 1537)]
		public partial interface ICallback
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/security/auth/callback/CallbackHandler
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/CallbackHandler", AccessFlags = 1537)]
		public partial interface ICallbackHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handle
				/// </java-name>
				[Dot42.DexImport("handle", "([Ljavax/security/auth/callback/Callback;)V", AccessFlags = 1025)]
				void Handle(global::Javax.Security.Auth.Callback.ICallback[] callback) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/security/auth/callback/PasswordCallback
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/PasswordCallback", AccessFlags = 33)]
		public partial class PasswordCallback : global::Javax.Security.Auth.Callback.ICallback, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public PasswordCallback(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearPassword
				/// </java-name>
				[Dot42.DexImport("clearPassword", "()V", AccessFlags = 1)]
				public virtual void ClearPassword() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PasswordCallback() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrompt
				/// </java-name>
				public virtual string Prompt
				{
						[Dot42.DexImport("getPrompt", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isEchoOn
				/// </java-name>
				public virtual bool IsEchoOn
				{
						[Dot42.DexImport("isEchoOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public virtual char[] Password
				{
						[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
						get{ return default(char[]); }
						[Dot42.DexImport("setPassword", "([C)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// javax/security/auth/callback/UnsupportedCallbackException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/UnsupportedCallbackException", AccessFlags = 33)]
		public partial class UnsupportedCallbackException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/security/auth/callback/Callback;)V", AccessFlags = 1)]
				public UnsupportedCallbackException(global::Javax.Security.Auth.Callback.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/security/auth/callback/Callback;Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedCallbackException(global::Javax.Security.Auth.Callback.ICallback callback, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnsupportedCallbackException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCallback
				/// </java-name>
				public virtual global::Javax.Security.Auth.Callback.ICallback Callback
				{
						[Dot42.DexImport("getCallback", "()Ljavax/security/auth/callback/Callback;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.Callback.ICallback); }
				}

		}

}

