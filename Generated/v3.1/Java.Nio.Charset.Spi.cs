// Copyright (C) 2014 dot42
//
// Original filename: Java.Nio.Charset.Spi.cs
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
namespace Java.Nio.Charset.Spi
{
		/// <summary>
		/// <para>The service provider class for character sets. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/charset/spi/CharsetProvider
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/spi/CharsetProvider", AccessFlags = 1057)]
		public abstract partial class CharsetProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for subclassing with concrete types. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal CharsetProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an iterator over all the available charsets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iterator. </para>
				/// </returns>
				/// <java-name>
				/// charsets
				/// </java-name>
				[Dot42.DexImport("charsets", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<Ljava/nio/charset/Charset;>;")]
				public abstract global::Java.Util.IIterator<global::Java.Nio.Charset.Charset> Charsets() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the named charset. </para><para>If the charset is unavailable the method returns <code>null</code>. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the charset, or <code>null</code> if unavailable. </para>
				/// </returns>
				/// <java-name>
				/// charsetForName
				/// </java-name>
				[Dot42.DexImport("charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.Charset CharsetForName(string charsetName) /* MethodBuilder.Create */ ;

		}

}


