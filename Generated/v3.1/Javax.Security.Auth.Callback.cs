// Copyright (C) 2014 dot42
//
// Original filename: Javax.Security.Auth.Callback.cs
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
namespace Javax.Security.Auth.Callback
{
		/// <summary>
		/// <para>Used in conjunction with a CallbackHandler to retrieve a password when needed. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/callback/PasswordCallback
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/PasswordCallback", AccessFlags = 33)]
		public partial class PasswordCallback : global::Javax.Security.Auth.Callback.ICallback, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> PasswordCallback </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public PasswordCallback(string prompt, bool echoOn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the prompt that was specified when creating this <c>       PasswordCallback </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prompt </para>
				/// </returns>
				/// <java-name>
				/// getPrompt
				/// </java-name>
				[Dot42.DexImport("getPrompt", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPrompt() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Queries whether this <c> PasswordCallback </c> expects user input to be echoed, which is specified during the creation of the object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if (and only if) user input should be echoed </para>
				/// </returns>
				/// <java-name>
				/// isEchoOn
				/// </java-name>
				[Dot42.DexImport("isEchoOn", "()Z", AccessFlags = 1)]
				public virtual bool IsEchoOn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the password. The CallbackHandler that performs the actual provisioning or input of the password needs to call this method to hand back the password to the security service that requested it.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "([C)V", AccessFlags = 1)]
				public virtual void SetPassword(char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the password. The security service that needs the password usually calls this method once the CallbackHandler has finished its work.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the password. A copy of the internal password is created and returned, so subsequent changes to the internal password do not affect the result. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
				public virtual char[] GetPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Clears the password stored in this <c> PasswordCallback </c> . </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the prompt that was specified when creating this <c>       PasswordCallback </c></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prompt </para>
				/// </returns>
				/// <java-name>
				/// getPrompt
				/// </java-name>
				public string Prompt
				{
				[Dot42.DexImport("getPrompt", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPrompt(); }
				}

				/// <summary>
				/// <para>Returns the password. The security service that needs the password usually calls this method once the CallbackHandler has finished its work.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the password. A copy of the internal password is created and returned, so subsequent changes to the internal password do not affect the result. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				public char[] Password
				{
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1)]
						get{ return GetPassword(); }
				[Dot42.DexImport("setPassword", "([C)V", AccessFlags = 1)]
						set{ SetPassword(value); }
				}

		}

		/// <summary>
		/// <para>Thrown when a CallbackHandler does not support a particular Callback. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/callback/UnsupportedCallbackException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/UnsupportedCallbackException", AccessFlags = 33)]
		public partial class UnsupportedCallbackException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new exception instance and initializes it with just the unsupported <c> Callback </c> , but no error message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/security/auth/callback/Callback;)V", AccessFlags = 1)]
				public UnsupportedCallbackException(global::Javax.Security.Auth.Callback.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new exception instance and initializes it with both the unsupported <c> Callback </c> and an error message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/security/auth/callback/Callback;Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedCallbackException(global::Javax.Security.Auth.Callback.ICallback callback, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the unsupported <c> Callback </c> that triggered this exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Callback </c> </para>
				/// </returns>
				/// <java-name>
				/// getCallback
				/// </java-name>
				[Dot42.DexImport("getCallback", "()Ljavax/security/auth/callback/Callback;", AccessFlags = 1)]
				public virtual global::Javax.Security.Auth.Callback.ICallback GetCallback() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Auth.Callback.ICallback);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnsupportedCallbackException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the unsupported <c> Callback </c> that triggered this exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Callback </c> </para>
				/// </returns>
				/// <java-name>
				/// getCallback
				/// </java-name>
				public global::Javax.Security.Auth.Callback.ICallback Callback
				{
				[Dot42.DexImport("getCallback", "()Ljavax/security/auth/callback/Callback;", AccessFlags = 1)]
						get{ return GetCallback(); }
				}

		}

		/// <summary>
		/// <para>Needs to be implemented by classes that want to handle authentication Callbacks. A single method handle(Callback[]) must be provided that checks the type of the incoming <c> Callback </c> s and reacts accordingly. <c> CallbackHandler </c> s can be installed per application. It is also possible to configure a system-default <c> CallbackHandler </c> by setting the <c> auth.login.defaultCallbackHandler </c> property in the standard <c> security.properties </c> file. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/callback/CallbackHandler
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/CallbackHandler", AccessFlags = 1537)]
		public partial interface ICallbackHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Handles the actual Callback. A <c> CallbackHandler </c> needs to implement this method. In the method, it is free to select which <c>       Callback </c> s it actually wants to handle and in which way. For example, a console-based <c> CallbackHandler </c> might choose to sequentially ask the user for login and password, if it implements these <c> Callback </c> s, whereas a GUI-based one might open a single dialog window for both values. If a <c> CallbackHandler </c> is not able to handle a specific <c> Callback </c> , it needs to throw an UnsupportedCallbackException.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// handle
				/// </java-name>
				[Dot42.DexImport("handle", "([Ljavax/security/auth/callback/Callback;)V", AccessFlags = 1025)]
				void Handle(global::Javax.Security.Auth.Callback.ICallback[] callbacks) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Defines an empty base interface for all <c> Callback </c> s used during authentication. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/callback/Callback
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/callback/Callback", AccessFlags = 1537)]
		public partial interface ICallback
 /* scope: __dot42__ */ 
		{
		}

}


