#pragma warning disable 1717
namespace Android.Test.Suitebuilder
{
		/// <java-name>
		/// android/test/suitebuilder/TestSuiteBuilder
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/TestSuiteBuilder", AccessFlags = 33)]
		public partial class TestSuiteBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1)]
				public TestSuiteBuilder(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public TestSuiteBuilder(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// includePackages
				/// </java-name>
				[Dot42.DexImport("includePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 129)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder IncludePackages(params string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <java-name>
				/// excludePackages
				/// </java-name>
				[Dot42.DexImport("excludePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 129)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder ExcludePackages(params string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <java-name>
				/// addRequirements
				/// </java-name>
				[Dot42.DexImport("addRequirements", "(Ljava/util/List;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 1, Signature = "(Ljava/util/List<Lcom/android/internal/util/Predicate<Landroid/test/suitebuilder/" +
    "TestMethod;>;>;)Landroid/test/suitebuilder/TestSuiteBuilder;")]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder AddRequirements(global::Java.Util.IList<global::Com.Android.Internal.Util.IPredicate<global::Android.Test.Suitebuilder.TestMethod>> list) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <java-name>
				/// includeAllPackagesUnderHere
				/// </java-name>
				[Dot42.DexImport("includeAllPackagesUnderHere", "()Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 17)]
				public global::Android.Test.Suitebuilder.TestSuiteBuilder IncludeAllPackagesUnderHere() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <java-name>
				/// named
				/// </java-name>
				[Dot42.DexImport("named", "(Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", AccessFlags = 1)]
				public virtual global::Android.Test.Suitebuilder.TestSuiteBuilder Named(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				/// <java-name>
				/// build
				/// </java-name>
				[Dot42.DexImport("build", "()Ljunit/framework/TestSuite;", AccessFlags = 17)]
				public global::Junit.Framework.TestSuite Build() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestSuite);
				}

				/// <java-name>
				/// getSuiteName
				/// </java-name>
				[Dot42.DexImport("getSuiteName", "()Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetSuiteName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// addRequirements
				/// </java-name>
				[Dot42.DexImport("addRequirements", "([Lcom/android/internal/util/Predicate;)Landroid/test/suitebuilder/TestSuiteBuild" +
    "er;", AccessFlags = 145, Signature = "([Lcom/android/internal/util/Predicate<Landroid/test/suitebuilder/TestMethod;>;)L" +
    "android/test/suitebuilder/TestSuiteBuilder;")]
				public global::Android.Test.Suitebuilder.TestSuiteBuilder AddRequirements(params global::Com.Android.Internal.Util.IPredicate<global::Android.Test.Suitebuilder.TestMethod>[] predicate) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Test.Suitebuilder.TestSuiteBuilder);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TestSuiteBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSuiteName
				/// </java-name>
				protected internal string SuiteName
				{
				[Dot42.DexImport("getSuiteName", "()Ljava/lang/String;", AccessFlags = 4)]
						get{ return GetSuiteName(); }
				}

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

		/// <java-name>
		/// android/test/suitebuilder/TestMethod
		/// </java-name>
		[Dot42.DexImport("android/test/suitebuilder/TestMethod", AccessFlags = 33)]
		public partial class TestMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/reflect/Method;Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
				public TestMethod(global::System.Reflection.JavaMethod javaMethod, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
				public TestMethod(string @string, global::System.Type type) /* MethodBuilder.Create */ 
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
				public virtual T GetAnnotation<T>(global::System.Type type) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

}

