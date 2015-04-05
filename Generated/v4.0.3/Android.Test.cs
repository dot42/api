#pragma warning disable 1717
namespace Android.Test
{
		/// <java-name>
		/// android/test/ActivityInstrumentationTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityInstrumentationTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityInstrumentationTestCase<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;Z)V")]
				public ActivityInstrumentationTestCase(string @string, global::System.Type type, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 1, Signature = "()TT;")]
				public new virtual T GetActivity() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testActivityTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testActivityTestCaseSetUpProperly", "()V", AccessFlags = 1)]
				public virtual void TestActivityTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ActivityInstrumentationTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/test/ActivityInstrumentationTestCase2
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityInstrumentationTestCase2", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityInstrumentationTestCase2<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase2(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase2(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 1, Signature = "()TT;")]
				public new virtual T GetActivity() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// setActivityIntent
				/// </java-name>
				[Dot42.DexImport("setActivityIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetActivityIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setActivityInitialTouchMode
				/// </java-name>
				[Dot42.DexImport("setActivityInitialTouchMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetActivityInitialTouchMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "()V", AccessFlags = 4)]
				protected internal override void RunTest() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ActivityInstrumentationTestCase2() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/test/ActivityTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityTestCase", AccessFlags = 1057)]
		public abstract partial class ActivityTestCase : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActivityTestCase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrubClass
				/// </java-name>
				[Dot42.DexImport("scrubClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void ScrubClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				protected internal virtual global::Android.App.Activity Activity
				{
						[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 4)]
						get{ return default(global::Android.App.Activity); }
						[Dot42.DexImport("setActivity", "(Landroid/app/Activity;)V", AccessFlags = 4)]
						set{ }
				}

		}

		/// <java-name>
		/// android/test/ActivityUnitTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityUnitTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityUnitTestCase<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ActivityUnitTestCase(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 1, Signature = "()TT;")]
				public new virtual T GetActivity() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)Landroid/app/Activ" +
    "ity;", AccessFlags = 4, Signature = "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)TT;")]
				protected internal virtual T StartActivity(global::Android.Content.Intent intent, global::Android.OS.Bundle bundle, object @object) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setApplication
				/// </java-name>
				[Dot42.DexImport("setApplication", "(Landroid/app/Application;)V", AccessFlags = 1)]
				public virtual void SetApplication(global::Android.App.Application application) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setActivityContext
				/// </java-name>
				[Dot42.DexImport("setActivityContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void SetActivityContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ActivityUnitTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRequestedOrientation
				/// </java-name>
				public virtual int RequestedOrientation
				{
						[Dot42.DexImport("getRequestedOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStartedActivityIntent
				/// </java-name>
				public virtual global::Android.Content.Intent StartedActivityIntent
				{
						[Dot42.DexImport("getStartedActivityIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent); }
				}

				/// <java-name>
				/// getStartedActivityRequest
				/// </java-name>
				public virtual int StartedActivityRequest
				{
						[Dot42.DexImport("getStartedActivityRequest", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isFinishCalled
				/// </java-name>
				public virtual bool IsFinishCalled
				{
						[Dot42.DexImport("isFinishCalled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getFinishedActivityRequest
				/// </java-name>
				public virtual int FinishedActivityRequest
				{
						[Dot42.DexImport("getFinishedActivityRequest", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/test/AndroidTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/AndroidTestCase", AccessFlags = 33)]
		public partial class AndroidTestCase : global::Junit.Framework.TestCase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mContext
				/// </java-name>
				[Dot42.DexImport("mContext", "Landroid/content/Context;", AccessFlags = 4)]
				protected internal global::Android.Content.Context MContext;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidTestCase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testAndroidTestCaseSetupProperly
				/// </java-name>
				[Dot42.DexImport("testAndroidTestCaseSetupProperly", "()V", AccessFlags = 1)]
				public virtual void TestAndroidTestCaseSetupProperly() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertActivityRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertActivityRequiresPermission(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertReadingContentUriRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertReadingContentUriRequiresPermission(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertWritingContentUriRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertWritingContentUriRequiresPermission(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrubClass
				/// </java-name>
				[Dot42.DexImport("scrubClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void ScrubClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
						[Dot42.DexImport("setContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/test/AndroidTestRunner
		/// </java-name>
		[Dot42.DexImport("android/test/AndroidTestRunner", AccessFlags = 33)]
		public partial class AndroidTestRunner : global::Junit.Runner.BaseTestRunner
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidTestRunner() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTestClassName
				/// </java-name>
				[Dot42.DexImport("setTestClassName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTestClassName(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTest
				/// </java-name>
				[Dot42.DexImport("setTest", "(Ljunit/framework/Test;)V", AccessFlags = 1)]
				public virtual void SetTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearTestListeners
				/// </java-name>
				[Dot42.DexImport("clearTestListeners", "()V", AccessFlags = 1)]
				public virtual void ClearTestListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTestListener
				/// </java-name>
				[Dot42.DexImport("addTestListener", "(Ljunit/framework/TestListener;)V", AccessFlags = 1)]
				public virtual void AddTestListener(global::Junit.Framework.ITestListener testListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createTestResult
				/// </java-name>
				[Dot42.DexImport("createTestResult", "()Ljunit/framework/TestResult;", AccessFlags = 4)]
				protected internal virtual global::Junit.Framework.TestResult CreateTestResult() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestResult);
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "()V", AccessFlags = 1)]
				public virtual void RunTest() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "(Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public virtual void RunTest(global::Junit.Framework.TestResult testResult) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContext
				/// </java-name>
				[Dot42.DexImport("setContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void SetContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInstrumentation
				/// </java-name>
				[Dot42.DexImport("setInstrumentation", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void SetInstrumentation(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInstrumentaiton
				/// </java-name>
				[Dot42.DexImport("setInstrumentaiton", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void SetInstrumentaiton(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadSuiteClass
				/// </java-name>
				[Dot42.DexImport("loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4)]
				protected internal override global::System.Type LoadSuiteClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// testStarted
				/// </java-name>
				[Dot42.DexImport("testStarted", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void TestStarted(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testEnded
				/// </java-name>
				[Dot42.DexImport("testEnded", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void TestEnded(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testFailed
				/// </java-name>
				[Dot42.DexImport("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public override void TestFailed(int int32, global::Junit.Framework.ITest test, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFailed
				/// </java-name>
				[Dot42.DexImport("runFailed", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void RunFailed(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTestCases
				/// </java-name>
				public virtual global::Java.Util.IList<global::Junit.Framework.TestCase> TestCases
				{
						[Dot42.DexImport("getTestCases", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljunit/framework/TestCase;>;")]
						get{ return default(global::Java.Util.IList<global::Junit.Framework.TestCase>); }
				}

				/// <java-name>
				/// getTestClassName
				/// </java-name>
				public virtual string TestClassName
				{
						[Dot42.DexImport("getTestClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getTestResult
				/// </java-name>
				public virtual global::Junit.Framework.TestResult TestResult
				{
						[Dot42.DexImport("getTestResult", "()Ljunit/framework/TestResult;", AccessFlags = 1)]
						get{ return default(global::Junit.Framework.TestResult); }
				}

		}

		/// <java-name>
		/// android/test/ApplicationTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ApplicationTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Application;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ApplicationTestCase<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ApplicationTestCase(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createApplication
				/// </java-name>
				[Dot42.DexImport("createApplication", "()V", AccessFlags = 20)]
				protected internal void CreateApplication() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// terminateApplication
				/// </java-name>
				[Dot42.DexImport("terminateApplication", "()V", AccessFlags = 20)]
				protected internal void TerminateApplication() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testApplicationTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testApplicationTestCaseSetUpProperly", "()V", AccessFlags = 17)]
				public void TestApplicationTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ApplicationTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getApplication
				/// </java-name>
				public virtual T Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <java-name>
				/// getSystemContext
				/// </java-name>
				public virtual global::Android.Content.Context SystemContext
				{
						[Dot42.DexImport("getSystemContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

		}

		/// <java-name>
		/// android/test/AssertionFailedError
		/// </java-name>
		[Dot42.DexImport("android/test/AssertionFailedError", AccessFlags = 33)]
		public partial class AssertionFailedError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AssertionFailedError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AssertionFailedError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/test/ComparisonFailure
		/// </java-name>
		[Dot42.DexImport("android/test/ComparisonFailure", AccessFlags = 33)]
		public partial class ComparisonFailure : global::Android.Test.AssertionFailedError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ComparisonFailure(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComparisonFailure() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/test/FlakyTest
		/// </java-name>
		[Dot42.DexImport("android/test/FlakyTest", AccessFlags = 9729)]
		public partial interface IFlakyTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// tolerance
				/// </java-name>
				[Dot42.DexImport("tolerance", "()I", AccessFlags = 1025)]
				int Tolerance() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/test/InstrumentationTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/InstrumentationTestCase", AccessFlags = 33)]
		public partial class InstrumentationTestCase : global::Junit.Framework.TestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstrumentationTestCase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// injectInstrumentation
				/// </java-name>
				[Dot42.DexImport("injectInstrumentation", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void InjectInstrumentation(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// injectInsrumentation
				/// </java-name>
				[Dot42.DexImport("injectInsrumentation", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void InjectInsrumentation(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// launchActivity
				/// </java-name>
				[Dot42.DexImport("launchActivity", "(Ljava/lang/String;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/app/Activity;", AccessFlags = 17, Signature = "<T:Landroid/app/Activity;>(Ljava/lang/String;Ljava/lang/Class<TT;>;Landroid/os/Bu" +
    "ndle;)TT;")]
				public T LaunchActivity<T>(string @string, global::System.Type type, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// launchActivityWithIntent
				/// </java-name>
				[Dot42.DexImport("launchActivityWithIntent", "(Ljava/lang/String;Ljava/lang/Class;Landroid/content/Intent;)Landroid/app/Activit" +
    "y;", AccessFlags = 17, Signature = "<T:Landroid/app/Activity;>(Ljava/lang/String;Ljava/lang/Class<TT;>;Landroid/conte" +
    "nt/Intent;)TT;")]
				public T LaunchActivityWithIntent<T>(string @string, global::System.Type type, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// runTestOnUiThread
				/// </java-name>
				[Dot42.DexImport("runTestOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void RunTestOnUiThread(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "()V", AccessFlags = 4)]
				protected internal override void RunTest() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendKeys
				/// </java-name>
				[Dot42.DexImport("sendKeys", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SendKeys(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendKeys
				/// </java-name>
				[Dot42.DexImport("sendKeys", "([I)V", AccessFlags = 129)]
				public virtual void SendKeys(params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendRepeatedKeys
				/// </java-name>
				[Dot42.DexImport("sendRepeatedKeys", "([I)V", AccessFlags = 129)]
				public virtual void SendRepeatedKeys(params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstrumentation
				/// </java-name>
				public virtual global::Android.App.Instrumentation Instrumentation
				{
						[Dot42.DexImport("getInstrumentation", "()Landroid/app/Instrumentation;", AccessFlags = 1)]
						get{ return default(global::Android.App.Instrumentation); }
				}

		}

		/// <java-name>
		/// android/test/InstrumentationTestRunner
		/// </java-name>
		[Dot42.DexImport("android/test/InstrumentationTestRunner", AccessFlags = 33)]
		public partial class InstrumentationTestRunner : global::Android.App.Instrumentation, global::Android.Test.ITestSuiteProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// REPORT_VALUE_ID
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_VALUE_ID = "InstrumentationTestRunner";
				/// <java-name>
				/// REPORT_KEY_NUM_TOTAL
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NUM_TOTAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NUM_TOTAL = "numtests";
				/// <java-name>
				/// REPORT_KEY_NUM_CURRENT
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NUM_CURRENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NUM_CURRENT = "current";
				/// <java-name>
				/// REPORT_KEY_NAME_CLASS
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NAME_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NAME_CLASS = "class";
				/// <java-name>
				/// REPORT_KEY_NAME_TEST
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NAME_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NAME_TEST = "test";
				/// <java-name>
				/// REPORT_VALUE_RESULT_START
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_START", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_START = 1;
				/// <java-name>
				/// REPORT_VALUE_RESULT_OK
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_OK", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_OK = 0;
				/// <java-name>
				/// REPORT_VALUE_RESULT_ERROR
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_ERROR", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_ERROR = -1;
				/// <java-name>
				/// REPORT_VALUE_RESULT_FAILURE
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_FAILURE", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_FAILURE = -2;
				/// <java-name>
				/// REPORT_KEY_STACK
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_STACK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_STACK = "stack";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstrumentationTestRunner() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAndroidTestRunner
				/// </java-name>
				protected internal virtual global::Android.Test.AndroidTestRunner AndroidTestRunner
				{
						[Dot42.DexImport("getAndroidTestRunner", "()Landroid/test/AndroidTestRunner;", AccessFlags = 4)]
						get{ return default(global::Android.Test.AndroidTestRunner); }
				}

				/// <java-name>
				/// getTestSuite
				/// </java-name>
				public virtual global::Junit.Framework.TestSuite TestSuite
				{
						[Dot42.DexImport("getTestSuite", "()Ljunit/framework/TestSuite;", AccessFlags = 1)]
						get{ return default(global::Junit.Framework.TestSuite); }
				}

				/// <java-name>
				/// getAllTests
				/// </java-name>
				public virtual global::Junit.Framework.TestSuite AllTests
				{
						[Dot42.DexImport("getAllTests", "()Ljunit/framework/TestSuite;", AccessFlags = 1)]
						get{ return default(global::Junit.Framework.TestSuite); }
				}

				/// <java-name>
				/// getLoader
				/// </java-name>
				public virtual global::Java.Lang.ClassLoader Loader
				{
						[Dot42.DexImport("getLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

		}

		/// <java-name>
		/// android/test/InstrumentationTestSuite
		/// </java-name>
		[Dot42.DexImport("android/test/InstrumentationTestSuite", AccessFlags = 33)]
		public partial class InstrumentationTestSuite : global::Junit.Framework.TestSuite
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public InstrumentationTestSuite(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public InstrumentationTestSuite(string @string, global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public InstrumentationTestSuite(global::System.Type type, global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTestSuite
				/// </java-name>
				[Dot42.DexImport("addTestSuite", "(Ljava/lang/Class;)V", AccessFlags = 1)]
				public override void AddTestSuite(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public override void RunTest(global::Junit.Framework.ITest test, global::Junit.Framework.TestResult testResult) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InstrumentationTestSuite() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/test/PerformanceTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/PerformanceTestCase", AccessFlags = 1537)]
		public partial interface IPerformanceTestCase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// startPerformance
				/// </java-name>
				[Dot42.DexImport("startPerformance", "(Landroid/test/PerformanceTestCase$Intermediates;)I", AccessFlags = 1025)]
				int StartPerformance(global::Android.Test.IPerformanceTestCase_IIntermediates performanceTestCase_IIntermediates) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isPerformanceOnly
				/// </java-name>
				bool IsPerformanceOnly
				{
						[Dot42.DexImport("isPerformanceOnly", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/test/PerformanceTestCase$Intermediates
		/// </java-name>
		[Dot42.DexImport("android/test/PerformanceTestCase$Intermediates", AccessFlags = 1545)]
		public partial interface IPerformanceTestCase_IIntermediates
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setInternalIterations
				/// </java-name>
				[Dot42.DexImport("setInternalIterations", "(I)V", AccessFlags = 1025)]
				void SetInternalIterations(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startTiming
				/// </java-name>
				[Dot42.DexImport("startTiming", "(Z)V", AccessFlags = 1025)]
				void StartTiming(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIntermediate
				/// </java-name>
				[Dot42.DexImport("addIntermediate", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddIntermediate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIntermediate
				/// </java-name>
				[Dot42.DexImport("addIntermediate", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void AddIntermediate(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// finishTiming
				/// </java-name>
				[Dot42.DexImport("finishTiming", "(Z)V", AccessFlags = 1025)]
				void FinishTiming(bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/test/IsolatedContext
		/// </java-name>
		[Dot42.DexImport("android/test/IsolatedContext", AccessFlags = 33)]
		public partial class IsolatedContext : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentResolver;Landroid/content/Context;)V", AccessFlags = 1)]
				public IsolatedContext(global::Android.Content.ContentResolver contentResolver, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent intent, global::Android.Content.IServiceConnection serviceConnection, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IsolatedContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAndClearBroadcastIntents
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Content.Intent> AndClearBroadcastIntents
				{
						[Dot42.DexImport("getAndClearBroadcastIntents", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/Intent;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.Intent>); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public override global::Android.Content.ContentResolver ContentResolver
				{
						[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ContentResolver); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public override global::Java.Io.File FilesDir
				{
						[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.Io.File); }
				}

		}

		/// <java-name>
		/// android/test/TestSuiteProvider
		/// </java-name>
		[Dot42.DexImport("android/test/TestSuiteProvider", AccessFlags = 1537)]
		public partial interface ITestSuiteProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTestSuite
				/// </java-name>
				global::Junit.Framework.TestSuite TestSuite
				{
						[Dot42.DexImport("getTestSuite", "()Ljunit/framework/TestSuite;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/test/UiThreadTest
		/// </java-name>
		[Dot42.DexImport("android/test/UiThreadTest", AccessFlags = 9729)]
		public partial interface IUiThreadTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/test/LoaderTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/LoaderTestCase", AccessFlags = 33)]
		public partial class LoaderTestCase : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LoaderTestCase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLoaderResultSynchronously
				/// </java-name>
				[Dot42.DexImport("getLoaderResultSynchronously", "(Landroid/content/Loader;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Landroid/content/Loader<TT;>;)TT;")]
				public virtual T GetLoaderResultSynchronously<T>(global::Android.Content.Loader<T> loader) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

		}

		/// <java-name>
		/// android/test/MoreAsserts
		/// </java-name>
		[Dot42.DexImport("android/test/MoreAsserts", AccessFlags = 49)]
		public sealed partial class MoreAsserts
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MoreAsserts() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertAssignableFrom
				/// </java-name>
				[Dot42.DexImport("assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Object;)V", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;Ljava/lang/Object;)V")]
				public static void AssertAssignableFrom(global::System.Type type, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertAssignableFrom
				/// </java-name>
				[Dot42.DexImport("assertAssignableFrom", "(Ljava/lang/Class;Ljava/lang/Class;)V", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;Ljava/lang/Class<*>;)V")]
				public static void AssertAssignableFrom(global::System.Type type, global::System.Type type1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEqual
				/// </java-name>
				[Dot42.DexImport("assertNotEqual", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotEqual(string @string, object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEqual
				/// </java-name>
				[Dot42.DexImport("assertNotEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotEqual(object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[B[B)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, sbyte[] sByte, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[B[B)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(string @string, byte[] @byte, byte[] byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([B[B)V", AccessFlags = 9)]
				public static void AssertEquals(sbyte[] sByte, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([B[B)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(byte[] @byte, byte[] byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[I[I)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([I[I)V", AccessFlags = 9)]
				public static void AssertEquals(int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[D[D)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, double[] @double, double[] double1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([D[D)V", AccessFlags = 9)]
				public static void AssertEquals(double[] @double, double[] double1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;Ljava/util/Set;Ljava/util/Set;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Set<+Ljava/lang/Object;>;Ljava/util/Set<+Ljava/lang" +
    "/Object;>;)V")]
				public static void AssertEquals(string @string, global::Java.Util.ISet<object> set, global::Java.Util.ISet<object> set1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/util/Set;Ljava/util/Set;)V", AccessFlags = 9, Signature = "(Ljava/util/Set<+Ljava/lang/Object;>;Ljava/util/Set<+Ljava/lang/Object;>;)V")]
				public static void AssertEquals(global::Java.Util.ISet<object> set, global::Java.Util.ISet<object> set1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchRes" +
    "ult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertMatchesRegex(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// assertMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertMatchesRegex(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// assertContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchRes" +
    "ult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertContainsRegex(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// assertContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertContainsRegex(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// assertNotMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotMatchesRegex(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotMatchesRegex(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotContainsRegex(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotContainsRegex(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertContentsInOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInOrder(string @string, global::Java.Lang.IIterable<object> iterable, params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertContentsInOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInOrder(global::Java.Lang.IIterable<object> iterable, params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertContentsInAnyOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInAnyOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInAnyOrder(string @string, global::Java.Lang.IIterable<object> iterable, params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertContentsInAnyOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInAnyOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInAnyOrder(global::Java.Lang.IIterable<object> iterable, params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;)V")]
				public static void AssertEmpty(string @string, global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/Iterable<*>;)V")]
				public static void AssertEmpty(global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<**>;)V")]
				public static void AssertEmpty(string @string, global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/util/Map<**>;)V")]
				public static void AssertEmpty(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;)V")]
				public static void AssertNotEmpty(string @string, global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/Iterable<*>;)V")]
				public static void AssertNotEmpty(global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<**>;)V")]
				public static void AssertNotEmpty(string @string, global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/util/Map<**>;)V")]
				public static void AssertNotEmpty(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkEqualsAndHashCodeMethods
				/// </java-name>
				[Dot42.DexImport("checkEqualsAndHashCodeMethods", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Z)V", AccessFlags = 9)]
				public static void CheckEqualsAndHashCodeMethods(string @string, object @object, object object1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkEqualsAndHashCodeMethods
				/// </java-name>
				[Dot42.DexImport("checkEqualsAndHashCodeMethods", "(Ljava/lang/Object;Ljava/lang/Object;Z)V", AccessFlags = 9)]
				public static void CheckEqualsAndHashCodeMethods(object @object, object object1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/test/ProviderTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ProviderTestCase", AccessFlags = 1057, Signature = "<T:Landroid/content/ContentProvider;>Landroid/test/InstrumentationTestCase;")]
		public abstract partial class ProviderTestCase<T> : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;Ljava/lang/String;)V")]
				public ProviderTestCase(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newResolverWithContentProviderFromSql
				/// </java-name>
				[Dot42.DexImport("newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;IL" +
    "java/lang/String;)Landroid/content/ContentResolver;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Landroid/content/Context;Ljava/lang/Class<T" +
    "T;>;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Landroid/content/Con" +
    "tentResolver;")]
				public static global::Android.Content.ContentResolver NewResolverWithContentProviderFromSql<JavaT>(global::Android.Content.Context context, global::System.Type type, string @string, string string1, int int32, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProviderTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public virtual T Provider
				{
						[Dot42.DexImport("getProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <java-name>
				/// getMockContentResolver
				/// </java-name>
				public virtual global::Android.Test.Mock.MockContentResolver MockContentResolver
				{
						[Dot42.DexImport("getMockContentResolver", "()Landroid/test/mock/MockContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Test.Mock.MockContentResolver); }
				}

				/// <java-name>
				/// getMockContext
				/// </java-name>
				public virtual global::Android.Test.IsolatedContext MockContext
				{
						[Dot42.DexImport("getMockContext", "()Landroid/test/IsolatedContext;", AccessFlags = 1)]
						get{ return default(global::Android.Test.IsolatedContext); }
				}

		}

		/// <java-name>
		/// android/test/ProviderTestCase2
		/// </java-name>
		[Dot42.DexImport("android/test/ProviderTestCase2", AccessFlags = 1057, Signature = "<T:Landroid/content/ContentProvider;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ProviderTestCase2<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;Ljava/lang/String;)V")]
				public ProviderTestCase2(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newResolverWithContentProviderFromSql
				/// </java-name>
				[Dot42.DexImport("newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Lj" +
    "ava/lang/String;ILjava/lang/String;)Landroid/content/ContentResolver;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Landroid/content/Context;Ljava/lang/String;" +
    "Ljava/lang/Class<TT;>;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)La" +
    "ndroid/content/ContentResolver;")]
				public static global::Android.Content.ContentResolver NewResolverWithContentProviderFromSql<JavaT>(global::Android.Content.Context context, string @string, global::System.Type type, string string1, string string2, int int32, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProviderTestCase2() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public virtual T Provider
				{
						[Dot42.DexImport("getProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <java-name>
				/// getMockContentResolver
				/// </java-name>
				public virtual global::Android.Test.Mock.MockContentResolver MockContentResolver
				{
						[Dot42.DexImport("getMockContentResolver", "()Landroid/test/mock/MockContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Test.Mock.MockContentResolver); }
				}

				/// <java-name>
				/// getMockContext
				/// </java-name>
				public virtual global::Android.Test.IsolatedContext MockContext
				{
						[Dot42.DexImport("getMockContext", "()Landroid/test/IsolatedContext;", AccessFlags = 1)]
						get{ return default(global::Android.Test.IsolatedContext); }
				}

		}

		/// <java-name>
		/// android/test/RenamingDelegatingContext
		/// </java-name>
		[Dot42.DexImport("android/test/RenamingDelegatingContext", AccessFlags = 33)]
		public partial class RenamingDelegatingContext : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 1)]
				public RenamingDelegatingContext(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 1)]
				public RenamingDelegatingContext(global::Android.Content.Context context, global::Android.Content.Context context1, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// providerWithRenamedContext
				/// </java-name>
				[Dot42.DexImport("providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;)Landroid/content/Co" +
    "ntentProvider;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Ljava/lang/Class<TT;>;Landroid/content/Cont" +
    "ext;Ljava/lang/String;)TT;")]
				public static T ProviderWithRenamedContext<T>(global::System.Type type, global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// providerWithRenamedContext
				/// </java-name>
				[Dot42.DexImport("providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;Z)Landroid/content/C" +
    "ontentProvider;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Ljava/lang/Class<TT;>;Landroid/content/Cont" +
    "ext;Ljava/lang/String;Z)TT;")]
				public static T ProviderWithRenamedContext<T>(global::System.Type type, global::Android.Content.Context context, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// makeExistingFilesAndDbsAccessible
				/// </java-name>
				[Dot42.DexImport("makeExistingFilesAndDbsAccessible", "()V", AccessFlags = 1)]
				public virtual void MakeExistingFilesAndDbsAccessible() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDatabasePath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] DatabaseList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileInputStream OpenFileInput(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileOutputStream OpenFileOutput(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileOutputStream);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFileStreamPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] FileList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RenamingDelegatingContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDatabasePrefix
				/// </java-name>
				public virtual string DatabasePrefix
				{
						[Dot42.DexImport("getDatabasePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public override global::Java.Io.File CacheDir
				{
						[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.Io.File); }
				}

		}

		/// <java-name>
		/// android/test/ServiceTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ServiceTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Service;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ServiceTestCase<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ServiceTestCase(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupService
				/// </java-name>
				[Dot42.DexImport("setupService", "()V", AccessFlags = 4)]
				protected internal virtual void SetupService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void StartService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 4)]
				protected internal virtual global::Android.OS.IBinder BindService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// shutdownService
				/// </java-name>
				[Dot42.DexImport("shutdownService", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testServiceTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testServiceTestCaseSetUpProperly", "()V", AccessFlags = 1)]
				public virtual void TestServiceTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ServiceTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getService
				/// </java-name>
				public virtual T Service
				{
						[Dot42.DexImport("getService", "()Landroid/app/Service;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <java-name>
				/// getApplication
				/// </java-name>
				public virtual global::Android.App.Application Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 1)]
						get{ return default(global::Android.App.Application); }
						[Dot42.DexImport("setApplication", "(Landroid/app/Application;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemContext
				/// </java-name>
				public virtual global::Android.Content.Context SystemContext
				{
						[Dot42.DexImport("getSystemContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

		}

		/// <java-name>
		/// android/test/SingleLaunchActivityTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/SingleLaunchActivityTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/InstrumentationTestCase;")]
		public abstract partial class SingleLaunchActivityTestCase<T> : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public SingleLaunchActivityTestCase(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testActivityTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testActivityTestCaseSetUpProperly", "()V", AccessFlags = 1)]
				public virtual void TestActivityTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SingleLaunchActivityTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				public virtual T Activity
				{
						[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

		}

		/// <java-name>
		/// android/test/SyncBaseInstrumentation
		/// </java-name>
		[Dot42.DexImport("android/test/SyncBaseInstrumentation", AccessFlags = 33)]
		public partial class SyncBaseInstrumentation : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncBaseInstrumentation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// syncProvider
				/// </java-name>
				[Dot42.DexImport("syncProvider", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SyncProvider(global::Android.Net.Uri uri, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelSyncsandDisableAutoSync
				/// </java-name>
				[Dot42.DexImport("cancelSyncsandDisableAutoSync", "()V", AccessFlags = 4)]
				protected internal virtual void CancelSyncsandDisableAutoSync() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/test/TouchUtils
		/// </java-name>
		[Dot42.DexImport("android/test/TouchUtils", AccessFlags = 33)]
		public partial class TouchUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TouchUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragQuarterScreenDown
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenDown", "(Landroid/test/ActivityInstrumentationTestCase;)V", AccessFlags = 9)]
				public static void DragQuarterScreenDown(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragQuarterScreenDown
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenDown", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V", AccessFlags = 9)]
				public static void DragQuarterScreenDown(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragQuarterScreenUp
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenUp", "(Landroid/test/ActivityInstrumentationTestCase;)V", AccessFlags = 9)]
				public static void DragQuarterScreenUp(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragQuarterScreenUp
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenUp", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V", AccessFlags = 9)]
				public static void DragQuarterScreenUp(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollToBottom
				/// </java-name>
				[Dot42.DexImport("scrollToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void ScrollToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollToBottom
				/// </java-name>
				[Dot42.DexImport("scrollToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGr" +
    "oup;)V", AccessFlags = 9)]
				public static void ScrollToBottom(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollToTop
				/// </java-name>
				[Dot42.DexImport("scrollToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void ScrollToTop(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollToTop
				/// </java-name>
				[Dot42.DexImport("scrollToTop", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGr" +
    "oup;)V", AccessFlags = 9)]
				public static void ScrollToTop(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;)" +
    "V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;I" +
    ")V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.App.Activity activity, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tapView
				/// </java-name>
				[Dot42.DexImport("tapView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void TapView(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// touchAndCancelView
				/// </java-name>
				[Dot42.DexImport("touchAndCancelView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void TouchAndCancelView(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clickView
				/// </java-name>
				[Dot42.DexImport("clickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void ClickView(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// longClickView
				/// </java-name>
				[Dot42.DexImport("longClickView", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void LongClickView(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// longClickView
				/// </java-name>
				[Dot42.DexImport("longClickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void LongClickView(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dragViewBy
				/// </java-name>
				[Dot42.DexImport("dragViewBy", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewBy(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewBy
				/// </java-name>
				[Dot42.DexImport("dragViewBy", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewBy(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewTo
				/// </java-name>
				[Dot42.DexImport("dragViewTo", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewTo(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewTo
				/// </java-name>
				[Dot42.DexImport("dragViewTo", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewTo(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewToX
				/// </java-name>
				[Dot42.DexImport("dragViewToX", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToX(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewToX
				/// </java-name>
				[Dot42.DexImport("dragViewToX", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToX(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewToY
				/// </java-name>
				[Dot42.DexImport("dragViewToY", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToY(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dragViewToY
				/// </java-name>
				[Dot42.DexImport("dragViewToY", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToY(global::Android.Test.InstrumentationTestCase instrumentationTestCase, global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drag
				/// </java-name>
				[Dot42.DexImport("drag", "(Landroid/test/ActivityInstrumentationTestCase;FFFFI)V", AccessFlags = 9)]
				public static void Drag(global::Android.Test.ActivityInstrumentationTestCase<object> activityInstrumentationTestCase, float single, float single1, float single2, float single3, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drag
				/// </java-name>
				[Dot42.DexImport("drag", "(Landroid/test/InstrumentationTestCase;FFFFI)V", AccessFlags = 9)]
				public static void Drag(global::Android.Test.InstrumentationTestCase instrumentationTestCase, float single, float single1, float single2, float single3, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/test/ViewAsserts
		/// </java-name>
		[Dot42.DexImport("android/test/ViewAsserts", AccessFlags = 33)]
		public partial class ViewAsserts
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ViewAsserts() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOnScreen
				/// </java-name>
				[Dot42.DexImport("assertOnScreen", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOnScreen(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOffScreenBelow
				/// </java-name>
				[Dot42.DexImport("assertOffScreenBelow", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOffScreenBelow(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertOffScreenAbove
				/// </java-name>
				[Dot42.DexImport("assertOffScreenAbove", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOffScreenAbove(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertHasScreenCoordinates
				/// </java-name>
				[Dot42.DexImport("assertHasScreenCoordinates", "(Landroid/view/View;Landroid/view/View;II)V", AccessFlags = 9)]
				public static void AssertHasScreenCoordinates(global::Android.Views.View view, global::Android.Views.View view1, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertBaselineAligned
				/// </java-name>
				[Dot42.DexImport("assertBaselineAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertBaselineAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertRightAligned
				/// </java-name>
				[Dot42.DexImport("assertRightAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertRightAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertRightAligned
				/// </java-name>
				[Dot42.DexImport("assertRightAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertRightAligned(global::Android.Views.View view, global::Android.Views.View view1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertLeftAligned
				/// </java-name>
				[Dot42.DexImport("assertLeftAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertLeftAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertLeftAligned
				/// </java-name>
				[Dot42.DexImport("assertLeftAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertLeftAligned(global::Android.Views.View view, global::Android.Views.View view1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertBottomAligned
				/// </java-name>
				[Dot42.DexImport("assertBottomAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertBottomAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertBottomAligned
				/// </java-name>
				[Dot42.DexImport("assertBottomAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertBottomAligned(global::Android.Views.View view, global::Android.Views.View view1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertTopAligned
				/// </java-name>
				[Dot42.DexImport("assertTopAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertTopAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertTopAligned
				/// </java-name>
				[Dot42.DexImport("assertTopAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertTopAligned(global::Android.Views.View view, global::Android.Views.View view1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertHorizontalCenterAligned
				/// </java-name>
				[Dot42.DexImport("assertHorizontalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertHorizontalCenterAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertVerticalCenterAligned
				/// </java-name>
				[Dot42.DexImport("assertVerticalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertVerticalCenterAligned(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertGroupIntegrity
				/// </java-name>
				[Dot42.DexImport("assertGroupIntegrity", "(Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void AssertGroupIntegrity(global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertGroupContains
				/// </java-name>
				[Dot42.DexImport("assertGroupContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertGroupContains(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertGroupNotContains
				/// </java-name>
				[Dot42.DexImport("assertGroupNotContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertGroupNotContains(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

		}

}

