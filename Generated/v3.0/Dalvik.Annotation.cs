// Copyright (C) 2014 dot42
//
// Original filename: Dalvik.Annotation.cs
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
namespace Dalvik.Annotation
{
		/// <summary>
		/// <para>Defines an annotation for test classes that allows to link them to the class that is being tested. The current assumption is that the test are somewhat organized according to the API classes they test. Might be too strict for some cases.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Obsolete </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// dalvik/annotation/TestTargetClass
		/// </java-name>
		[Dot42.DexImport("dalvik/annotation/TestTargetClass", AccessFlags = 9729)]
		public partial interface ITestTargetClass : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Specifies the class being tested. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()Ljava/lang/Class;", AccessFlags = 1025, Signature = "()Ljava/lang/Class<*>;")]
				global::System.Type Value() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Defines an annotation used be used within the TestInfo annotation. It specifies a single method target for the test (but can be used multiple times).</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Obsolete </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// dalvik/annotation/TestTarget
		/// </java-name>
		[Dot42.DexImport("dalvik/annotation/TestTarget", AccessFlags = 9729)]
		public partial interface ITestTarget : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Specifies the name of the method that is being tested. </para>        
				/// </summary>
				/// <java-name>
				/// methodName
				/// </java-name>
				[Dot42.DexImport("methodName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string MethodName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specifies the name of a concept being tested. Use this if <c> methodName </c> is not accurate enough. E.g. for java.util.regex.Pattern#compile(String) <c> methodName </c> is not sufficient since the String contains a pattern with its own syntax which has to be tested with different aspects. Areas concerned are e.g. JDBC (SELECT, INSERT, UPDATE, DELETE, ...), regex (character sets, operators,...), formatters (DecimalFormat, DateFormat, ChoiceFormat, ...), ... </para>        
				/// </summary>
				/// <java-name>
				/// conceptName
				/// </java-name>
				[Dot42.DexImport("conceptName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ConceptName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specifies the signature of the method that is being tested, in terms of Java classes. </para>        
				/// </summary>
				/// <java-name>
				/// methodArgs
				/// </java-name>
				[Dot42.DexImport("methodArgs", "()[Ljava/lang/Class;", AccessFlags = 1025, Signature = "()[Ljava/lang/Class<*>;")]
				global::System.Type[] MethodArgs() /* MethodBuilder.Create */ ;

		}

}


