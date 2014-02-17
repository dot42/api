// Copyright (C) 2014 dot42
//
// Original filename: Android.Test.Suitebuilder.Annotation.cs
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
namespace Android.Test.Suitebuilder.Annotation
{
		/// <summary>
		/// <para>Use this annotation on test classes or test methods that should not be included in a test suite. If the annotation appears on the class then no tests in that class will be included. If the annotation appears only on a test method then only that method will be excluded. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/annotation/Suppress
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/annotation/Suppress", AccessFlags = 9729)]
		public partial interface ISuppress : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Marks a test that should run as part of the small tests. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/annotation/SmallTest
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/annotation/SmallTest", AccessFlags = 9729)]
		public partial interface ISmallTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Marks a test that should run as part of the large tests. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/annotation/LargeTest
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/annotation/LargeTest", AccessFlags = 9729)]
		public partial interface ILargeTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Marks a test that should run as part of the medium tests. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/annotation/MediumTest
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/annotation/MediumTest", AccessFlags = 9729)]
		public partial interface IMediumTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Marks a test that should run as part of the smoke tests. The <code>android.test.suitebuilder.SmokeTestSuiteBuilder</code> will run all tests with this annotation.</para><para><para>android.test.suitebuilder.SmokeTestSuiteBuilder </para></para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/annotation/Smoke
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/annotation/Smoke", AccessFlags = 9729)]
		public partial interface ISmoke : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

}


