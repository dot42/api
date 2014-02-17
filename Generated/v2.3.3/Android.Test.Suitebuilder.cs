// Copyright (C) 2014 dot42
//
// Original filename: Android.Test.Suitebuilder.cs
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
namespace Android.Test.Suitebuilder
{
		/// <summary>
		/// <para>Represents a test to be run. Can be constructed without instantiating the TestCase or even loading the class. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/TestMethod
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/TestMethod", AccessFlags = 33)]
		public partial class TestMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/reflect/Method;Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
				public TestMethod(global::System.Reflection.MethodInfo method, global::System.Type enclosingClass) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
				public TestMethod(string method, global::System.Type enclosingClass) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljunit/framework/TestCase;)V", AccessFlags = 1)]
				public TestMethod(global::Junit.Framework.TestCase testCase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getEnclosingClassname
				/// </java-name>
				[Dot42.DexImport("getEnclosingClassname", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEnclosingClassname() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				public virtual T GetAnnotation<T>(global::System.Type annotationClass) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getEnclosingClass
				/// </java-name>
				[Dot42.DexImport("getEnclosingClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljunit/framework/TestCase;>;")]
				public virtual global::System.Type GetEnclosingClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// createTest
				/// </java-name>
				[Dot42.DexImport("createTest", "()Ljunit/framework/TestCase;", AccessFlags = 1)]
				public virtual global::Junit.Framework.TestCase CreateTest() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestCase);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TestMethod() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getEnclosingClassname
				/// </java-name>
				public string EnclosingClassname
				{
				[Dot42.DexImport("getEnclosingClassname", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEnclosingClassname(); }
				}

				/// <java-name>
				/// getEnclosingClass
				/// </java-name>
				public global::System.Type EnclosingClass
				{
				[Dot42.DexImport("getEnclosingClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljunit/framework/TestCase;>;")]
						get{ return GetEnclosingClass(); }
				}

		}

		/// <summary>
		/// <para>Build suites based on a combination of included packages, excluded packages, and predicates that must be satisfied. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/suitebuilder/TestSuiteBuilder
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/TestSuiteBuilder", AccessFlags = 33)]
		public partial class TestSuiteBuilder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The given name is automatically prefixed with the package containing the tests to be run. If more than one package is specified, the first is used.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1)]
				public TestSuiteBuilder(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public TestSuiteBuilder(string name, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Include all tests that satisfy the requirements in the given packages and all sub-packages, unless otherwise specified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// includePackages
				/// </java-name>
				[Dot42.DexImport("includePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 129)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder IncludePackages(params string[] packageNames) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <summary>
				/// <para>Exclude all tests in the given packages and all sub-packages, unless otherwise specified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// excludePackages
				/// </java-name>
				[Dot42.DexImport("excludePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 129)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder ExcludePackages(params string[] packageNames) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <summary>
				/// <para>Exclude tests that fail to satisfy all of the given predicates.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// addRequirements
				/// </java-name>
				[Dot42.DexImport("addRequirements", "(Ljava/util/List;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 1, Signature = "(Ljava/util/List<Lcom/android/internal/util/Predicate<Landroid/test/suitebuilder/" +
    "TestMethod;>;>;)Landroid/test/suitebuilder/TestSuiteBuilder;")]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder AddRequirements(global::Java.Util.IList<global::Com.Android.Internal.Util.IPredicate<global::Android.Test.Suitebuilder.TestMethod>> predicates) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <summary>
				/// <para>Include all junit tests that satisfy the requirements in the calling class' package and all sub-packages.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// includeAllPackagesUnderHere
				/// </java-name>
				[Dot42.DexImport("includeAllPackagesUnderHere", "()Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 17)]
				public global::Android.Test.Suitebuilder.TestSuiteBuilder IncludeAllPackagesUnderHere() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <summary>
				/// <para>Override the default name for the suite being built. This should generally be called if you call addRequirements(com.android.internal.util.Predicate[]) to make it clear which tests will be included. The name you specify is automatically prefixed with the package containing the tests to be run. If more than one package is specified, the first is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// named
				/// </java-name>
				[Dot42.DexImport("named", "(Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 1)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder Named(string newSuiteName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <summary>
				/// <para>Call this method once you've configured your builder as desired.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The suite containing the requested tests. </para>
				/// </returns>
				/// <java-name>
				/// build
				/// </java-name>
				[Dot42.DexImport("build", "()Ljunit/framework/TestSuite;", AccessFlags = 17)]
				public global::Junit.Framework.TestSuite Build() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestSuite);
				}

				/// <summary>
				/// <para>Subclasses use this method to determine the name of the suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package and suite name combined. </para>
				/// </returns>
				/// <java-name>
				/// getSuiteName
				/// </java-name>
				[Dot42.DexImport("getSuiteName", "()Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetSuiteName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Exclude tests that fail to satisfy all of the given predicates.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The builder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// addRequirements
				/// </java-name>
				[Dot42.DexImport("addRequirements", "([Lcom/android/internal/util/Predicate;)Landroid/test/suitebuilder/TestSuiteBuild" +
    "er;", AccessFlags = 145, Signature = "([Lcom/android/internal/util/Predicate<Landroid/test/suitebuilder/TestMethod;>;)L" +
    "android/test/suitebuilder/TestSuiteBuilder;")]
				public global::Android.Test.Suitebuilder.TestSuiteBuilder AddRequirements(params global::Com.Android.Internal.Util.IPredicate<global::Android.Test.Suitebuilder.TestMethod>[] predicates) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TestSuiteBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Subclasses use this method to determine the name of the suite.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package and suite name combined. </para>
				/// </returns>
				/// <java-name>
				/// getSuiteName
				/// </java-name>
				protected internal string SuiteName
				{
				[Dot42.DexImport("getSuiteName", "()Ljava/lang/String;", AccessFlags = 4)]
						get{ return GetSuiteName(); }
				}

				/// <summary>
				/// <para>A special junit.framework.TestCase used to indicate a failure during the build() step. </para>    
				/// </summary>
				/// <java-name>
				/// android/test/suitebuilder/TestSuiteBuilder$FailedToCreateTests
				/// </java-name>
				[Dot42.DexImport("android/test/suitebuilder/TestSuiteBuilder$FailedToCreateTests", AccessFlags = 9)]
				public partial class FailedToCreateTests : global::Junit.Framework.TestCase
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
						public FailedToCreateTests(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// testSuiteConstructionFailed
						/// </java-name>
						[Dot42.DexImport("testSuiteConstructionFailed", "()V", AccessFlags = 1)]
						public virtual void TestSuiteConstructionFailed() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal FailedToCreateTests() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

}


