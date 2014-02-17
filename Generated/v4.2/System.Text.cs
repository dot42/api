// Copyright (C) 2014 dot42
//
// Original filename: System.Text.cs
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
namespace System.Text
{
		/// <summary>
		/// <para>A modifiable sequence of characters for use in creating strings. This class is intended as a direct replacement of StringBuffer for non-concurrent use; unlike <c> StringBuffer </c> this class is not synchronized.</para><para>For particularly complex string-building needs, consider java.util.Formatter.</para><para>The majority of the modification methods on this class return <c>   this </c> so that method calls can be chained together. For example: <c> new StringBuilder("a").append("b").append("c").toString() </c> .</para><para><para>CharSequence </para><simplesectsep></simplesectsep><para>Appendable </para><simplesectsep></simplesectsep><para>StringBuffer </para><simplesectsep></simplesectsep><para>String </para><simplesectsep></simplesectsep><para>String::format </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StringBuilder
		/// </java-name>
		[Dot42.DexImport("java/lang/StringBuilder", AccessFlags = 49)]
		public sealed partial class StringBuilder : global::Java.Lang.IAppendable, global::Java.Lang.ICharSequence, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an instance with an initial capacity of <c> 16 </c> .</para><para><para>#capacity() </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an instance with the specified capacity.</para><para><para>#capacity() </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringBuilder(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an instance with the specified capacity.</para><para><para>#capacity() </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public StringBuilder(global::Java.Lang.ICharSequence capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs an instance with the specified capacity.</para><para><para>#capacity() </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringBuilder(string capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Z)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(bool b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(char b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(I)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(int b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(J)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(long b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(F)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(float b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(D)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(double b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/Object;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(object b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(string b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(global::Java.Lang.StringBuffer b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([C)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(char[] b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified subset of the <c>       char[] </c> . The <c> char[] </c> value is converted to a String according to the rule defined by String#valueOf(char[],int,int).</para><para><para>String::valueOf(char[],int,int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(char[] str, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified <c> boolean </c> value. The <c> boolean </c> value is converted to a String according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Append(global::Java.Lang.ICharSequence b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the string representation of the specified subset of the <c>       char[] </c> . The <c> char[] </c> value is converted to a String according to the rule defined by String#valueOf(char[],int,int).</para><para><para>String::valueOf(char[],int,int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public global::System.Text.StringBuilder JavaAppend(global::Java.Lang.ICharSequence str, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Appends the encoded Unicode code point. The code point is converted to a <c> char[] </c> as defined by Character#toChars(int).</para><para><para>Character::toChars(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// appendCodePoint
				/// </java-name>
				[Dot42.DexImport("appendCodePoint", "(I)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder AppendCodePoint(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Deletes a sequence of characters specified by <c> start </c> and <c>       end </c> . Shifts any remaining characters to the left.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public global::System.Text.StringBuilder JavaDelete(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Deletes the character at the specified index. shifts any remaining characters to the left.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// deleteCharAt
				/// </java-name>
				[Dot42.DexImport("deleteCharAt", "(I)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder DeleteCharAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IZ)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, bool b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IC)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, char b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(II)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, int b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IJ)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, long b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IF)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, float b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ID)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, double b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/Object;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, object b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/String;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, string b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[C)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, char[] b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified subsequence of the <c> char[] </c> at the specified <c> offset </c> . The <c> char[] </c> value is converted to a String according to the rule defined by String#valueOf(char[],int,int).</para><para><para>String::valueOf(char[],int,int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[CII)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, char[] str, int strOffset, int strLen) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified <c> boolean </c> value at the specified <c> offset </c> . The <c> boolean </c> value is converted to a string according to the rule defined by String#valueOf(boolean).</para><para><para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Insert(int offset, global::Java.Lang.ICharSequence b) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Inserts the string representation of the specified subsequence of the <c> char[] </c> at the specified <c> offset </c> . The <c> char[] </c> value is converted to a String according to the rule defined by String#valueOf(char[],int,int).</para><para><para>String::valueOf(char[],int,int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public global::System.Text.StringBuilder JavaInsert(int offset, global::Java.Lang.ICharSequence str, int strOffset, int strLen) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Replaces the specified subsequence in this builder with the specified string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this builder. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/String;)Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Replace(int start, int end, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Reverses the order of characters in this builder.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "()Ljava/lang/StringBuilder;", AccessFlags = 1)]
				public global::System.Text.StringBuilder Reverse() /* MethodBuilder.Create */ 
				{
						return default(global::System.Text.StringBuilder);
				}

				/// <summary>
				/// <para>Returns the contents of this builder.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of the data in this builder. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 1)]
				public int GetCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCharAt
				/// </java-name>
				[Dot42.DexImport("setCharAt", "(IC)V", AccessFlags = 1)]
				public void SetCharAt(int int32, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string Substring(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public string JavaSubstring(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int IndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int IndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int LastIndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int LastIndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 1)]
				public void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 1)]
				public int CodePointAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 1)]
				public int CodePointBefore(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 1)]
				public int CodePointCount(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 1)]
				public int OffsetByCodePoints(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				/// <java-name>
				/// capacity
				/// </java-name>
				public int Capacity
				{
				[Dot42.DexImport("capacity", "()I", AccessFlags = 1)]
						get{ return GetCapacity(); }
				}

				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
						set{ SetLength(value); }
				}

		}

}


