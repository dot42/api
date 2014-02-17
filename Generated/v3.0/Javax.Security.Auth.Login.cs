// Copyright (C) 2014 dot42
//
// Original filename: Javax.Security.Auth.Login.cs
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
namespace Javax.Security.Auth.Login
{
		/// <summary>
		/// <para>Base class for exceptions that are thrown when a login error occurs. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/login/LoginException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/login/LoginException", AccessFlags = 33)]
		public partial class LoginException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new exception instance and initializes it with default values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LoginException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new exception instance and initializes it with a given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LoginException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

}


