#pragma warning disable 1717
namespace Android.Test
{
		/// <summary>
		///  <para>This class provides functional testing of a single activity. The activity under test will be created using the system infrastructure (by calling InstrumentationTestCase.launchActivity()) and you will then be able to manipulate your Activity directly. Most of the work is handled automatically here by setUp and tearDown.</para> <para>If you prefer an isolated unit test, see android.test.ActivityUnitTestCase.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>new tests should be written using android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/test/ActivityInstrumentationTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityInstrumentationTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityInstrumentationTestCase<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an ActivityInstrumentationTestCase in non-touch mode.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase(string pkg, global::System.Type activityClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an ActivityInstrumentationTestCase.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;Z)V")]
				public ActivityInstrumentationTestCase(string pkg, global::System.Type activityClass, bool initialTouchMode) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Called after run() is called, even if run() threw an exception, but not if setUp() threw an execption. </para>        
				/// </summary>
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
				protected internal ActivityInstrumentationTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This class provides functional testing of a single activity. The activity under test will be created using the system infrastructure (by calling InstrumentationTestCase.launchActivity()) and you will then be able to manipulate your Activity directly.</para> <para>Other options supported by this test case include:  <ul> <li> <para>You can run any test method on the UI thread (see android.test.UiThreadTest). </para></li> <li> <para>You can inject custom Intents into your Activity (see setActivityIntent(Intent)). </para></li></ul></para> <para>This class replaces android.test.ActivityInstrumentationTestCase, which is deprecated. New tests should be written using this base class.</para> <para>If you prefer an isolated unit test, see android.test.ActivityUnitTestCase.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about application testing, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/test/ActivityInstrumentationTestCase2
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityInstrumentationTestCase2", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityInstrumentationTestCase2<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an ActivityInstrumentationTestCase2.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ActivityInstrumentationTestCase2(Class) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase2(string pkg, global::System.Type activityClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an ActivityInstrumentationTestCase2.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ActivityInstrumentationTestCase2(global::System.Type activityClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the Activity under test, starting it if necessary.</para> <para>For each test method invocation, the Activity will not actually be created until the first time this method is called.</para> <para>If you wish to provide custom setup values to your Activity, you may call setActivityIntent(Intent) and/or setActivityInitialTouchMode(boolean) before your first call to getActivity(). Calling them after your Activity has started will have no effect.</para> <para> <b>NOTE:</b> Activities under test may not be started from within the UI thread. If your test method is annotated with android.test.UiThreadTest, then your Activity will be started automatically just before your test method is run. You still call this method in order to get the Activity under test.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Activity under test </para>
				/// </returns>
				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 1, Signature = "()TT;")]
				public new virtual T GetActivity() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Call this method before the first call to getActivity to inject a customized Intent into the Activity under test.</para> <para>If you do not call this, the default intent will be provided. If you call this after your Activity has been started, it will have no effect.</para> <para> <b>NOTE:</b> Activities under test may not be started from within the UI thread. If your test method is annotated with android.test.UiThreadTest, then you must call setActivityIntent(Intent) from setUp().</para> <para>The default Intent (if this method is not called) is: action = Intent#ACTION_MAIN flags = Intent#FLAG_ACTIVITY_NEW_TASK All other fields are null or empty.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setActivityIntent
				/// </java-name>
				[Dot42.DexImport("setActivityIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetActivityIntent(global::Android.Content.Intent i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this method before the first call to getActivity to set the initial touch mode for the Activity under test.</para> <para>If you do not call this, the touch mode will be false. If you call this after your Activity has been started, it will have no effect.</para> <para> <b>NOTE:</b> Activities under test may not be started from within the UI thread. If your test method is annotated with android.test.UiThreadTest, then you must call setActivityInitialTouchMode(boolean) from setUp().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setActivityInitialTouchMode
				/// </java-name>
				[Dot42.DexImport("setActivityInitialTouchMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetActivityInitialTouchMode(bool initialTouchMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after run() is called, even if run() threw an exception, but not if setUp() threw an execption. </para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs the current unit test. If the unit test is annotated with android.test.UiThreadTest, force the Activity to be created before switching to the UI thread. </para>        
				/// </summary>
				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "()V", AccessFlags = 4)]
				protected internal override void RunTest() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ActivityInstrumentationTestCase2() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This is common code used to support Activity test cases. For more useful classes, please see android.test.ActivityUnitTestCase and android.test.ActivityInstrumentationTestCase. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>This function is called by various TestCase implementations, at tearDown() time, in order to scrub out any class variables. This protects against memory leaks in the case where a test case creates a non-static inner class (thus referencing the test case) and gives it to someone else to hold onto.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scrubClass
				/// </java-name>
				[Dot42.DexImport("scrubClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void ScrubClass(global::System.Type testCaseClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the activity under test. </para>
				/// </returns>
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

		/// <summary>
		///  <para>This class provides isolated testing of a single activity. The activity under test will be created with minimal connection to the system infrastructure, and you can inject mocked or wrappered versions of many of Activity's dependencies. Most of the work is handled automatically here by setUp and tearDown.</para> <para>If you prefer a functional test, see android.test.ActivityInstrumentationTestCase.</para> <para>It must be noted that, as a true unit test, your Activity will not be running in the normal system and will not participate in the normal interactions with other Activities. The following methods should not be called in this configuration - most of them will throw exceptions:  <ul> <li> <para>android.app.Activity#createPendingResult(int, Intent, int) </para></li> <li> <para>android.app.Activity#startActivityIfNeeded(Intent, int) </para></li> <li> <para>android.app.Activity#startActivityFromChild(Activity, Intent, int) </para></li> <li> <para>android.app.Activity#startNextMatchingActivity(Intent) </para></li> <li> <para>android.app.Activity#getCallingActivity() </para></li> <li> <para>android.app.Activity#getCallingPackage() </para></li> <li> <para>android.app.Activity#createPendingResult(int, Intent, int) </para></li> <li> <para>android.app.Activity#getTaskId() </para></li> <li> <para>android.app.Activity#isTaskRoot() </para></li> <li> <para>android.app.Activity#moveTaskToBack(boolean) </para></li></ul></para> <para>The following methods may be called but will not do anything. For test purposes, you can use the methods getStartedActivityIntent() and getStartedActivityRequest() to inspect the parameters that they were called with.  <ul> <li> <para>android.app.Activity#startActivity(Intent) </para></li> <li> <para>android.app.Activity#startActivityForResult(Intent, int) </para></li></ul></para> <para>The following methods may be called but will not do anything. For test purposes, you can use the methods isFinishCalled() and getFinishedActivityRequest() to inspect the parameters that they were called with.  <ul> <li> <para>android.app.Activity#finish() </para></li> <li> <para>android.app.Activity#finishFromChild(Activity child) </para></li> <li> <para>android.app.Activity#finishActivity(int requestCode) </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/test/ActivityUnitTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ActivityUnitTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/ActivityTestCase;")]
		public abstract partial class ActivityUnitTestCase<T> : global::Android.Test.ActivityTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ActivityUnitTestCase(global::System.Type activityClass) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Start the activity under test, in the same way as if it was started by Context.startActivity(), providing the arguments it supplied. When you use this method to start the activity, it will automatically be stopped by tearDown.</para> <para>This method will call onCreate(), but if you wish to further exercise Activity life cycle methods, you must call them yourself from your test case.</para> <para> <b>Do not call from your setUp() method. You must call this method from each of your test methods.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the Activity that was created </para>
				/// </returns>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)Landroid/app/Activ" +
    "ity;", AccessFlags = 4, Signature = "(Landroid/content/Intent;Landroid/os/Bundle;Ljava/lang/Object;)TT;")]
				protected internal virtual T StartActivity(global::Android.Content.Intent intent, global::Android.OS.Bundle savedInstanceState, object lastNonConfigurationInstance) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Called after run() is called, even if run() threw an exception, but not if setUp() threw an execption. </para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the application for use during the test. You must call this function before calling startActivity. If your test does not call this method, </para>        
				/// </summary>
				/// <java-name>
				/// setApplication
				/// </java-name>
				[Dot42.DexImport("setApplication", "(Landroid/app/Application;)V", AccessFlags = 1)]
				public virtual void SetApplication(global::Android.App.Application application) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If you wish to inject a Mock, Isolated, or otherwise altered context, you can do so here. You must call this function before calling startActivity. If you wish to obtain a real Context, as a building block, use getInstrumentation().getTargetContext(). </para>        
				/// </summary>
				/// <java-name>
				/// setActivityContext
				/// </java-name>
				[Dot42.DexImport("setActivityContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void SetActivityContext(global::Android.Content.Context activityContext) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ActivityUnitTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>This method will return the value if your Activity under test calls android.app.Activity#setRequestedOrientation. </para>        
				/// </summary>
				/// <java-name>
				/// getRequestedOrientation
				/// </java-name>
				public virtual int RequestedOrientation
				{
						[Dot42.DexImport("getRequestedOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method will return the launch intent if your Activity under test calls android.app.Activity#startActivity(Intent) or android.app.Activity#startActivityForResult(Intent, int). </para>        
				/// </summary>
				/// <returns>
				///  <para>The Intent provided in the start call, or null if no start call was made. </para>
				/// </returns>
				/// <java-name>
				/// getStartedActivityIntent
				/// </java-name>
				public virtual global::Android.Content.Intent StartedActivityIntent
				{
						[Dot42.DexImport("getStartedActivityIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent); }
				}

				/// <summary>
				///  <para>This method will return the launch request code if your Activity under test calls android.app.Activity#startActivityForResult(Intent, int). </para>        
				/// </summary>
				/// <returns>
				///  <para>The request code provided in the start call, or -1 if no start call was made. </para>
				/// </returns>
				/// <java-name>
				/// getStartedActivityRequest
				/// </java-name>
				public virtual int StartedActivityRequest
				{
						[Dot42.DexImport("getStartedActivityRequest", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method will notify you if the Activity under test called android.app.Activity#finish(), android.app.Activity#finishFromChild(Activity), or android.app.Activity#finishActivity(int). </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if one of the listed finish methods was called. </para>
				/// </returns>
				/// <java-name>
				/// isFinishCalled
				/// </java-name>
				public virtual bool IsFinishCalled
				{
						[Dot42.DexImport("isFinishCalled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>This method will return the request code if the Activity under test called android.app.Activity#finishActivity(int). </para>        
				/// </summary>
				/// <returns>
				///  <para>The request code provided in the start call, or -1 if no finish call was made. </para>
				/// </returns>
				/// <java-name>
				/// getFinishedActivityRequest
				/// </java-name>
				public virtual int FinishedActivityRequest
				{
						[Dot42.DexImport("getFinishedActivityRequest", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Extend this if you need to access Resources or other things that depend on Activity Context. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Called after run() is called, even if run() threw an exception, but not if setUp() threw an execption. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Asserts that launching a given activity is protected by a particular permission by attempting to start the activity and validating that a SecurityException is thrown that mentions the permission in its error message.</para> <para>Note that an instrumentation isn't needed because all we are looking for is a security error and we don't need to wait for the activity to launch and get a handle to the activity.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertActivityRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertActivityRequiresPermission(string packageName, string className, string permission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that reading from the content uri requires a particular permission by querying the uri and ensuring a SecurityException is thrown mentioning the particular permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertReadingContentUriRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertReadingContentUriRequiresPermission(global::Android.Net.Uri uri, string permission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that writing to the content uri requires a particular permission by inserting into the uri and ensuring a SecurityException is thrown mentioning the particular permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertWritingContentUriRequiresPermission
				/// </java-name>
				[Dot42.DexImport("assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AssertWritingContentUriRequiresPermission(global::Android.Net.Uri uri, string permission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function is called by various TestCase implementations, at tearDown() time, in order to scrub out any class variables. This protects against memory leaks in the case where a test case creates a non-static inner class (thus referencing the test case) and gives it to someone else to hold onto.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scrubClass
				/// </java-name>
				[Dot42.DexImport("scrubClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void ScrubClass(global::System.Type testCaseClass) /* MethodBuilder.Create */ 
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
				public virtual void SetTestClassName(string testClassName, string testMethodName) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Incorrect spelling, use setInstrumentation(android.app.Instrumentation) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
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
				protected internal override global::System.Type LoadSuiteClass(string suiteClassName) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// testStarted
				/// </java-name>
				[Dot42.DexImport("testStarted", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void TestStarted(string testName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testEnded
				/// </java-name>
				[Dot42.DexImport("testEnded", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void TestEnded(string testName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testFailed
				/// </java-name>
				[Dot42.DexImport("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public override void TestFailed(int status, global::Junit.Framework.ITest test, global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFailed
				/// </java-name>
				[Dot42.DexImport("runFailed", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void RunFailed(string message) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>This test case provides a framework in which you can test Application classes in a controlled environment. It provides basic support for the lifecycle of a Application, and hooks by which you can inject various dependencies and control the environment in which your Application is tested.</para> <para> <b>Lifecycle Support.</b> Every Application is designed to be accessed within a specific sequence of method calls (see android.app.Application for more details). In order to support the lifecycle of a Application, this test case will make the following calls at the following times.</para> <para> <ul> <li> <para>The test case will not call onCreate() until your test calls createApplication(). This gives you a chance to set up or adjust any additional framework or test logic before onCreate(). </para></li> <li> <para>After your test completes, the test case tearDown method is automatically called, and it will stop &amp; destroy your application by calling its onDestroy() method. </para></li></ul></para> <para> <b>Dependency Injection.</b> Every Application has one inherent dependency, the Context in which it runs. This framework allows you to inject a modified, mock, or isolated replacement for this dependencies, and thus perform a true unit test.</para> <para>If simply run your tests as-is, your Application will be injected with a fully-functional Context. You can create and inject alternative types of Contexts by calling setContext(). You must do this  <b>before</b> calling createApplication(). The test framework provides a number of alternatives for Context, including MockContext, RenamingDelegatingContext, and ContextWrapper. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/ApplicationTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ApplicationTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Application;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ApplicationTestCase<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ApplicationTestCase(global::System.Type applicationClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This will do the work to instantiate the Application under test. After this, your test code must also start and stop the Application. </para>        
				/// </summary>
				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start the Application under test, in the same way as if it was started by the system. If you use this method to start the Application, it will automatically be stopped by tearDown. If you wish to inject a specialized Context for your test, by calling setContext(), you must do so before calling this method. </para>        
				/// </summary>
				/// <java-name>
				/// createApplication
				/// </java-name>
				[Dot42.DexImport("createApplication", "()V", AccessFlags = 20)]
				protected internal void CreateApplication() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This will make the necessary calls to terminate the Application under test (it will call onTerminate(). Ordinarily this will be called automatically (by tearDown, but you can call it directly from your test in order to check for proper shutdown behaviors. </para>        
				/// </summary>
				/// <java-name>
				/// terminateApplication
				/// </java-name>
				[Dot42.DexImport("terminateApplication", "()V", AccessFlags = 20)]
				protected internal void TerminateApplication() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Shuts down the Application under test. Also makes sure all resources are cleaned up and garbage collected before moving on to the next test. Subclasses that override this method should make sure they call super.tearDown() at the end of the overriding method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This test simply confirms that the Application class can be instantiated properly.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// testApplicationTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testApplicationTestCaseSetUpProperly", "()V", AccessFlags = 17)]
				public void TestApplicationTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ApplicationTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the actual Application under test. </para>
				/// </returns>
				/// <java-name>
				/// getApplication
				/// </java-name>
				public virtual T Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <summary>
				///  <para>Return a real (not mocked or instrumented) system Context that can be used when generating Mock or other Context objects for your Application under test.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to a normal Context. </para>
				/// </returns>
				/// <java-name>
				/// getSystemContext
				/// </java-name>
				public virtual global::Android.Content.Context SystemContext
				{
						[Dot42.DexImport("getSystemContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

		}

		/// <summary>
		///  <para>Thrown when an assertion failed.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use junit.framework.AssertionFailedError </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/test/AssertionFailedError
		/// </java-name>
		[Dot42.DexImport("android/test/AssertionFailedError", AccessFlags = 33)]
		public partial class AssertionFailedError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>It is more typical to call AssertionFailedError(String). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AssertionFailedError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AssertionFailedError(string errorMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an assert equals for Strings failed.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use junit.framework.ComparisonFailure </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/test/ComparisonFailure
		/// </java-name>
		[Dot42.DexImport("android/test/ComparisonFailure", AccessFlags = 33)]
		public partial class ComparisonFailure : global::Android.Test.AssertionFailedError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ComparisonFailure(string message, string expected, string actual) /* MethodBuilder.Create */ 
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
				protected internal ComparisonFailure() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This annotation can be used on an android.test.InstrumentationTestCase's test methods. When the annotation is present, the test method is re-executed if the test fails. The total number of executions is specified by the tolerance and defaults to 1. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/FlakyTest
		/// </java-name>
		[Dot42.DexImport("android/test/FlakyTest", AccessFlags = 9729)]
		public partial interface IFlakyTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates how many times a test can run and fail before being reported as a failed test. If the tolerance factor is less than 1, the test runs only once.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The total number of allowed run, the default is 1. </para>
				/// </returns>
				/// <java-name>
				/// tolerance
				/// </java-name>
				[Dot42.DexImport("tolerance", "()I", AccessFlags = 1025)]
				int Tolerance() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A test case that has access to Instrumentation. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Injects instrumentation into this test case. This method is called by the test runner during test setup.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// injectInstrumentation
				/// </java-name>
				[Dot42.DexImport("injectInstrumentation", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void InjectInstrumentation(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Injects instrumentation into this test case. This method is called by the test runner during test setup.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Incorrect spelling, use injectInstrumentation(android.app.Instrumentation) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// injectInsrumentation
				/// </java-name>
				[Dot42.DexImport("injectInsrumentation", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public virtual void InjectInsrumentation(global::Android.App.Instrumentation instrumentation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Utility method for launching an activity.</para> <para>The Intent used to launch the Activity is: action = Intent#ACTION_MAIN extras = null, unless a custom bundle is provided here All other fields are null or empty.</para> <para> <b>NOTE:</b> The parameter  <b>pkg</b> must refer to the package identifier of the package hosting the activity to be launched, which is specified in the AndroidManifest.xml file. This is not necessarily the same as the java package name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The activity, or null if non launched. </para>
				/// </returns>
				/// <java-name>
				/// launchActivity
				/// </java-name>
				[Dot42.DexImport("launchActivity", "(Ljava/lang/String;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/app/Activity;", AccessFlags = 17, Signature = "<T:Landroid/app/Activity;>(Ljava/lang/String;Ljava/lang/Class<TT;>;Landroid/os/Bu" +
    "ndle;)TT;")]
				public T LaunchActivity<T>(string pkg, global::System.Type activityCls, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Utility method for launching an activity with a specific Intent.</para> <para> <b>NOTE:</b> The parameter  <b>pkg</b> must refer to the package identifier of the package hosting the activity to be launched, which is specified in the AndroidManifest.xml file. This is not necessarily the same as the java package name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The activity, or null if non launched. </para>
				/// </returns>
				/// <java-name>
				/// launchActivityWithIntent
				/// </java-name>
				[Dot42.DexImport("launchActivityWithIntent", "(Ljava/lang/String;Ljava/lang/Class;Landroid/content/Intent;)Landroid/app/Activit" +
    "y;", AccessFlags = 17, Signature = "<T:Landroid/app/Activity;>(Ljava/lang/String;Ljava/lang/Class<TT;>;Landroid/conte" +
    "nt/Intent;)TT;")]
				public T LaunchActivityWithIntent<T>(string pkg, global::System.Type activityCls, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Helper for running portions of a test on the UI thread.</para> <para>Note, in most cases it is simpler to annotate the test method with android.test.UiThreadTest, which will run the entire test method on the UI thread. Use this method if you need to switch in and out of the UI thread to perform your test.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// runTestOnUiThread
				/// </java-name>
				[Dot42.DexImport("runTestOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void RunTestOnUiThread(global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs the current unit test. If the unit test is annotated with android.test.UiThreadTest, the test is run on the UI thread. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Sends a series of key events through instrumentation and waits for idle. Each key code must be preceded by the number of times the key code must be sent. For instance: sendRepeatedKeys(1, KEYCODE_DPAD_CENTER, 2, KEYCODE_DPAD_LEFT).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendRepeatedKeys
				/// </java-name>
				[Dot42.DexImport("sendRepeatedKeys", "([I)V", AccessFlags = 129)]
				public virtual void SendRepeatedKeys(params int[] keys) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make sure all resources are cleaned up and garbage collected before moving on to the next test. Subclasses that override this method should make sure they call super.tearDown() at the end of the overriding method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inheritors can access the instrumentation using this. </para>        
				/// </summary>
				/// <returns>
				///  <para>instrumentation </para>
				/// </returns>
				/// <java-name>
				/// getInstrumentation
				/// </java-name>
				public virtual global::Android.App.Instrumentation Instrumentation
				{
						[Dot42.DexImport("getInstrumentation", "()Landroid/app/Instrumentation;", AccessFlags = 1)]
						get{ return default(global::Android.App.Instrumentation); }
				}

		}

		/// <summary>
		///  <para>An Instrumentation that runs various types of junit.framework.TestCases against an Android package (application).</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about application testing, read the  developer guide.</para> <para> </para> <para> <h3>Typical Usage</h3></para> <para> <ol> <li> <para>Write junit.framework.TestCases that perform unit, functional, or performance tests against the classes in your package. Typically these are subclassed from:  <ul> <li> <para>android.test.ActivityInstrumentationTestCase2 </para></li> <li> <para>android.test.ActivityUnitTestCase </para></li> <li> <para>android.test.AndroidTestCase </para></li> <li> <para>android.test.ApplicationTestCase </para></li> <li> <para>android.test.InstrumentationTestCase </para></li> <li> <para>android.test.ProviderTestCase </para></li> <li> <para>android.test.ServiceTestCase </para></li> <li> <para>android.test.SingleLaunchActivityTestCase</para></li></ul></para></li> <li> <para>In an appropriate AndroidManifest.xml, define the this instrumentation with the appropriate android:targetPackage set. </para></li> <li> <para>Run the instrumentation using "adb shell am instrument -w", with no optional arguments, to run all tests (except performance tests). </para></li> <li> <para>Run the instrumentation using "adb shell am instrument -w", with the argument '-e func true' to run all functional tests. These are tests that derive from android.test.InstrumentationTestCase. </para></li> <li> <para>Run the instrumentation using "adb shell am instrument -w", with the argument '-e unit true' to run all unit tests. These are tests that  <b>do not</b>derive from android.test.InstrumentationTestCase (and are not performance tests). </para></li> <li> <para>Run the instrumentation using "adb shell am instrument -w", with the argument '-e class' set to run an individual junit.framework.TestCase. </para></li></ol></para> <para> <b>Running all tests:</b> adb shell am instrument -w com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running all small tests:</b> adb shell am instrument -w -e size small com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running all medium tests:</b> adb shell am instrument -w -e size medium com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running all large tests:</b> adb shell am instrument -w -e size large com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Filter test run to tests with given annotation:</b> adb shell am instrument -w -e annotation com.android.foo.MyAnnotation com.android.foo/android.test.InstrumentationTestRunner </para> <para>If used with other options, the resulting test run will contain the union of the two options. e.g. "-e size large -e annotation com.android.foo.MyAnnotation" will run only tests with both the LargeTest and "com.android.foo.MyAnnotation" annotations. </para> <para> <b>Filter test run to tests  <b>without</b> given annotation:</b> adb shell am instrument -w -e notAnnotation com.android.foo.MyAnnotation com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running a single testcase:</b> adb shell am instrument -w -e class com.android.foo.FooTest com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running a single test:</b> adb shell am instrument -w -e class com.android.foo.FooTest::testFoo com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running multiple tests:</b> adb shell am instrument -w -e class com.android.foo.FooTest,com.android.foo.TooTest com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Running all tests in a java package:</b> adb shell am instrument -w -e package com.android.foo.subpkg com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>Including performance tests:</b> adb shell am instrument -w -e perf true com.android.foo/android.test.InstrumentationTestRunner </para> <para> <b>To debug your tests, set a break point in your code and pass:</b> -e debug true </para> <para> <b>To run in 'log only' mode</b> -e log true This option will load and iterate through all test classes and methods, but will bypass actual test execution. Useful for quickly obtaining info on the tests to be executed by an instrumentation command. </para> <para> <b>To generate EMMA code coverage:</b> -e coverage true Note: this requires an emma instrumented build. By default, the code coverage results file will be saved in a /data/&lt;app&gt;/coverage.ec file, unless overridden by coverageFile flag (see below) </para> <para> <b> To specify EMMA code coverage results file path:</b> -e coverageFile /sdcard/myFile.ec  <br></br> in addition to the other arguments. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/InstrumentationTestRunner
		/// </java-name>
		[Dot42.DexImport("android/test/InstrumentationTestRunner", AccessFlags = 33)]
		public partial class InstrumentationTestRunner : global::Android.App.Instrumentation, global::Android.Test.ITestSuiteProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The following keys are used in the status bundle to provide structured reports to an IInstrumentationWatcher. This value, if stored with key android.app.Instrumentation#REPORT_KEY_IDENTIFIER, identifies InstrumentationTestRunner as the source of the report. This is sent with all status messages. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_VALUE_ID
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_VALUE_ID = "InstrumentationTestRunner";
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies the total number of tests that are being run. This is sent with all status messages. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_NUM_TOTAL
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NUM_TOTAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NUM_TOTAL = "numtests";
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies the sequence number of the current test. This is sent with any status message describing a specific test being started or completed. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_NUM_CURRENT
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NUM_CURRENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NUM_CURRENT = "current";
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies the name of the current test class. This is sent with any status message describing a specific test being started or completed. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_NAME_CLASS
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NAME_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NAME_CLASS = "class";
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies the name of the current test. This is sent with any status message describing a specific test being started or completed. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_NAME_TEST
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_NAME_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_NAME_TEST = "test";
				/// <summary>
				///  <para>The test is starting. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_VALUE_RESULT_START
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_START", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_START = 1;
				/// <summary>
				///  <para>The test completed successfully. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_VALUE_RESULT_OK
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_OK", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_OK = 0;
				/// <summary>
				///  <para>The test completed with an error. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_VALUE_RESULT_ERROR
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_ERROR", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_ERROR = -1;
				/// <summary>
				///  <para>The test completed with a failure. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_VALUE_RESULT_FAILURE
				/// </java-name>
				[Dot42.DexImport("REPORT_VALUE_RESULT_FAILURE", "I", AccessFlags = 25)]
				public const int REPORT_VALUE_RESULT_FAILURE = -2;
				/// <summary>
				///  <para>If included in the status bundle sent to an IInstrumentationWatcher, this key identifies a stack trace describing an error or failure. This is sent with any status message describing a specific test being completed. </para>        
				/// </summary>
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
				public override void OnCreate(global::Android.OS.Bundle arguments) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Override this to define all of the tests to run in your package. </para>        
				/// </summary>
				/// <java-name>
				/// getAllTests
				/// </java-name>
				public virtual global::Junit.Framework.TestSuite AllTests
				{
						[Dot42.DexImport("getAllTests", "()Ljunit/framework/TestSuite;", AccessFlags = 1)]
						get{ return default(global::Junit.Framework.TestSuite); }
				}

				/// <summary>
				///  <para>Override this to provide access to the class loader of your package. </para>        
				/// </summary>
				/// <java-name>
				/// getLoader
				/// </java-name>
				public virtual global::Java.Lang.ClassLoader Loader
				{
						[Dot42.DexImport("getLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

		}

		/// <summary>
		///  <para>A junit.framework.TestSuite that injects android.app.Instrumentation into InstrumentationTestCase before running them. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/InstrumentationTestSuite
		/// </java-name>
		[Dot42.DexImport("android/test/InstrumentationTestSuite", AccessFlags = 33)]
		public partial class InstrumentationTestSuite : global::Junit.Framework.TestSuite
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/app/Instrumentation;)V", AccessFlags = 1)]
				public InstrumentationTestSuite(global::Android.App.Instrumentation instr) /* MethodBuilder.Create */ 
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
				public override void AddTestSuite(global::System.Type testClass) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public override void RunTest(global::Junit.Framework.ITest test, global::Junit.Framework.TestResult result) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal InstrumentationTestSuite() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>More complex interface performance for test cases.</para> <para>If you want your test to be used as a performance test, you must implement this interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/PerformanceTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/PerformanceTestCase", AccessFlags = 1537)]
		public partial interface IPerformanceTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Set up to begin performance tests. The 'intermediates' is a communication channel to send back intermediate performance numbers  if you use it, you will probably want to ensure your test is only executed once by returning 1. Otherwise, return 0 to allow the test harness to decide the number of iterations.</para> <para>If you return a non-zero iteration count, you should call intermediates.startTiming and intermediates.endTiming to report the duration of the test whose performance should actually be measured.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int Maximum number of iterations to run, or 0 to let the caller decide. </para>
				/// </returns>
				/// <java-name>
				/// startPerformance
				/// </java-name>
				[Dot42.DexImport("startPerformance", "(Landroid/test/PerformanceTestCase$Intermediates;)I", AccessFlags = 1025)]
				int StartPerformance(global::Android.Test.IPerformanceTestCase_IIntermediates intermediates) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is used to determine what modes this test case can run in.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this test case can only be run in performance mode. </para>
				/// </returns>
				/// <java-name>
				/// isPerformanceOnly
				/// </java-name>
				bool IsPerformanceOnly
				{
						[Dot42.DexImport("isPerformanceOnly", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Callbacks for PerformanceTestCase. </para>    
		/// </summary>
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
				void SetInternalIterations(int count) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startTiming
				/// </java-name>
				[Dot42.DexImport("startTiming", "(Z)V", AccessFlags = 1025)]
				void StartTiming(bool realTime) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIntermediate
				/// </java-name>
				[Dot42.DexImport("addIntermediate", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddIntermediate(string name) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIntermediate
				/// </java-name>
				[Dot42.DexImport("addIntermediate", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void AddIntermediate(string name, long timeInNS) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// finishTiming
				/// </java-name>
				[Dot42.DexImport("finishTiming", "(Z)V", AccessFlags = 1025)]
				void FinishTiming(bool realTime) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A mock context which prevents its users from talking to the rest of the device while stubbing enough methods to satify code that tries to talk to other packages. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/IsolatedContext
		/// </java-name>
		[Dot42.DexImport("android/test/IsolatedContext", AccessFlags = 33)]
		public partial class IsolatedContext : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentResolver;Landroid/content/Context;)V", AccessFlags = 1)]
				public IsolatedContext(global::Android.Content.ContentResolver resolver, global::Android.Content.Context targetContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver receiver) /* MethodBuilder.Create */ 
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
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal IsolatedContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the list of intents that were broadcast since the last call to this method. </para>        
				/// </summary>
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
				public override global::Java.IO.File FilesDir
				{
						[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

		}

		/// <summary>
		///  <para>Implementors will know how to get a test suite. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>This annotation can be used on an InstrumentationTestCase's test methods. When the annotation is present, the test method is executed on the application's main thread (or UI thread.) Note that instrumentation methods may not be used when this annotation is present. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/UiThreadTest
		/// </java-name>
		[Dot42.DexImport("android/test/UiThreadTest", AccessFlags = 9729)]
		public partial interface IUiThreadTest : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>A convenience class for testing Loaders. This test case provides a simple way to synchronously get the result from a Loader making it easy to assert that the Loader returns the expected result. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Runs a Loader synchronously and returns the result of the load. The loader will be started, stopped, and destroyed by this method so it cannot be reused.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The result from the loader </para>
				/// </returns>
				/// <java-name>
				/// getLoaderResultSynchronously
				/// </java-name>
				[Dot42.DexImport("getLoaderResultSynchronously", "(Landroid/content/Loader;)Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Landroid/content/Loader<TT;>;)TT;")]
				public virtual T GetLoaderResultSynchronously<T>(global::Android.Content.Loader<T> loader) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

		}

		/// <summary>
		///  <para>Contains additional assertion methods not found in JUnit. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Asserts that <c>actual </c> is not equal <c>unexpected </c> , according to both <c>== </c> and Object#equals. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotEqual
				/// </java-name>
				[Dot42.DexImport("assertNotEqual", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotEqual(string message, object unexpected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertNotEqual(String,Object,Object) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotEqual
				/// </java-name>
				[Dot42.DexImport("assertNotEqual", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotEqual(object unexpected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[B[B)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(string @string, sbyte[] sByte, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[B[B)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, byte[] @byte, byte[] byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([B[B)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(sbyte[] expected, sbyte[] actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([B[B)V", AccessFlags = 9)]
				public static void AssertEquals(byte[] expected, byte[] actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[I[I)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([I[I)V", AccessFlags = 9)]
				public static void AssertEquals(int[] expected, int[] actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[D[D)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, double[] @double, double[] double1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([D[D)V", AccessFlags = 9)]
				public static void AssertEquals(double[] expected, double[] actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(object[] expected, object[] actual) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Asserts that two sets contain the same elements. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/util/Set;Ljava/util/Set;)V", AccessFlags = 9, Signature = "(Ljava/util/Set<+Ljava/lang/Object;>;Ljava/util/Set<+Ljava/lang/Object;>;)V")]
				public static void AssertEquals(global::Java.Util.ISet<object> expected, global::Java.Util.ISet<object> actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that <c>expectedRegex </c> exactly matches <c>actual </c> and fails with <c>message </c> if it does not. The MatchResult is returned in case the test needs access to any captured groups. Note that you can also use this for a literal string, by wrapping your expected string in Pattern#quote. </para>        
				/// </summary>
				/// <java-name>
				/// assertMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchRes" +
    "ult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertMatchesRegex(string message, string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				///  <para>Variant of assertMatchesRegex(String,String,String) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertMatchesRegex(string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				///  <para>Asserts that <c>expectedRegex </c> matches any substring of <c>actual </c> and fails with <c>message </c> if it does not. The Matcher is returned in case the test needs access to any captured groups. Note that you can also use this for a literal string, by wrapping your expected string in Pattern#quote. </para>        
				/// </summary>
				/// <java-name>
				/// assertContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchRes" +
    "ult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertContainsRegex(string message, string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				///  <para>Variant of assertContainsRegex(String,String,String) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/regex/MatchResult;", AccessFlags = 9)]
				public static global::Java.Util.Regex.IMatchResult AssertContainsRegex(string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				///  <para>Asserts that <c>expectedRegex </c> does not exactly match <c>actual </c> , and fails with <c>message </c> if it does. Note that you can also use this for a literal string, by wrapping your expected string in Pattern#quote. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotMatchesRegex(string message, string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertNotMatchesRegex(String,String,String) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotMatchesRegex
				/// </java-name>
				[Dot42.DexImport("assertNotMatchesRegex", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotMatchesRegex(string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that <c>expectedRegex </c> does not match any substring of  <c>actual </c> , and fails with <c>message </c> if it does. Note that you can also use this for a literal string, by wrapping your expected string in Pattern#quote. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotContainsRegex(string message, string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertNotContainsRegex(String,String,String) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotContainsRegex
				/// </java-name>
				[Dot42.DexImport("assertNotContainsRegex", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertNotContainsRegex(string expectedRegex, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that <c>actual </c> contains precisely the elements  <c>expected </c> , and in the same order. </para>        
				/// </summary>
				/// <java-name>
				/// assertContentsInOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInOrder(string message, global::Java.Lang.IIterable<object> actual, params object[] expected) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertContentsInOrder(String, Iterable&lt;?&gt;, Object...) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertContentsInOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInOrder(global::Java.Lang.IIterable<object> actual, params object[] expected) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Asserts that <c>actual </c> contains precisely the elements  <c>expected </c> , but in any order. </para>        
				/// </summary>
				/// <java-name>
				/// assertContentsInAnyOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInAnyOrder", "(Ljava/lang/String;Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInAnyOrder(string message, global::Java.Lang.IIterable<object> actual, params object[] expected) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertContentsInAnyOrder(String, Iterable&lt;?&gt;, Object...) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertContentsInAnyOrder
				/// </java-name>
				[Dot42.DexImport("assertContentsInAnyOrder", "(Ljava/lang/Iterable;[Ljava/lang/Object;)V", AccessFlags = 137, Signature = "(Ljava/lang/Iterable<*>;[Ljava/lang/Object;)V")]
				public static void AssertContentsInAnyOrder(global::Java.Lang.IIterable<object> actual, params object[] expected) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/String;Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/lang/Iterable<*>;)V")]
				public static void AssertEmpty(string @string, global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertEmpty(String, Map) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/Iterable<*>;)V")]
				public static void AssertEmpty(global::Java.Lang.IIterable<object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEmpty
				/// </java-name>
				[Dot42.DexImport("assertEmpty", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<**>;)V")]
				public static void AssertEmpty(string @string, global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertEmpty(String, Map) using a generic message. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Variant of assertNotEmpty(String, Map) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/lang/Iterable;)V", AccessFlags = 9, Signature = "(Ljava/lang/Iterable<*>;)V")]
				public static void AssertNotEmpty(global::Java.Lang.IIterable<object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<**>;)V")]
				public static void AssertNotEmpty(string @string, global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of assertNotEmpty(String, Map) using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotEmpty
				/// </java-name>
				[Dot42.DexImport("assertNotEmpty", "(Ljava/util/Map;)V", AccessFlags = 9, Signature = "(Ljava/util/Map<**>;)V")]
				public static void AssertNotEmpty(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Utility for testing equals() and hashCode() results at once. Tests that lhs.equals(rhs) matches expectedResult, as well as rhs.equals(lhs). Also tests that hashCode() return values are equal if expectedResult is true. (hashCode() is not tested if expectedResult is false, as unequal objects can have equal hashCodes.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// checkEqualsAndHashCodeMethods
				/// </java-name>
				[Dot42.DexImport("checkEqualsAndHashCodeMethods", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Z)V", AccessFlags = 9)]
				public static void CheckEqualsAndHashCodeMethods(string message, object lhs, object rhs, bool expectedResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Variant of checkEqualsAndHashCodeMethods(String,Object,Object,boolean...)} using a generic message. </para>        
				/// </summary>
				/// <java-name>
				/// checkEqualsAndHashCodeMethods
				/// </java-name>
				[Dot42.DexImport("checkEqualsAndHashCodeMethods", "(Ljava/lang/Object;Ljava/lang/Object;Z)V", AccessFlags = 9)]
				public static void CheckEqualsAndHashCodeMethods(object lhs, object rhs, bool expectedResult) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>If you would like to test a single content provider with an InstrumentationTestCase, this provides some of the boiler plate in setUp and tearDown.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this class extends InstrumentationTestCase but should extend AndroidTestCase. Use ProviderTestCase2, which corrects this problem, instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/test/ProviderTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ProviderTestCase", AccessFlags = 1057, Signature = "<T:Landroid/content/ContentProvider;>Landroid/test/InstrumentationTestCase;")]
		public abstract partial class ProviderTestCase<T> : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;Ljava/lang/String;)V")]
				public ProviderTestCase(global::System.Type providerClass, string providerAuthority) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tears down the environment for the test fixture. </para> <para>Calls android.content.ContentProvider#shutdown() on the android.content.ContentProvider represented by mProvider. </para>        
				/// </summary>
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
				public static global::Android.Content.ContentResolver NewResolverWithContentProviderFromSql<JavaT>(global::Android.Content.Context targetContext, global::System.Type providerClass, string authority, string databaseName, int databaseVersion, string sql) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ProviderTestCase() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <summary>
		///  <para>This test case class provides a framework for testing a single ContentProvider and for testing your app code with an isolated content provider. Instead of using the system map of providers that is based on the manifests of other applications, the test case creates its own internal map. It then uses this map to resolve providers given an authority. This allows you to inject test providers and to null out providers that you do not want to use. </para> <para>This test case also sets up the following mock objects: </para> <para> <ul> <li> <para>An android.test.IsolatedContext that stubs out Context methods that might affect the rest of the running system, while allowing tests to do real file and database work.  </para></li> <li> <para>A android.test.mock.MockContentResolver that provides the functionality of a regular content resolver, but uses IsolatedContext. It stubs out ContentResolver#notifyChange(Uri, ContentObserver, boolean) to prevent the test from affecting the running system.  </para></li> <li> <para>An instance of the provider under test, running in an IsolatedContext.  </para></li></ul></para> <para>This framework is set up automatically by the base class' setUp() method. If you override this method, you must call the super method as the first statement in your override. </para> <para>In order for their tests to be run, concrete subclasses must provide their own constructor with no arguments. This constructor must call ProviderTestCase2(Class, String) as its first operation. </para> <para>For more information on content provider testing, please see . </para>    
		/// </summary>
		/// <java-name>
		/// android/test/ProviderTestCase2
		/// </java-name>
		[Dot42.DexImport("android/test/ProviderTestCase2", AccessFlags = 1057, Signature = "<T:Landroid/content/ContentProvider;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ProviderTestCase2<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;Ljava/lang/String;)V")]
				public ProviderTestCase2(global::System.Type providerClass, string providerAuthority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets up the environment for the test fixture. </para> <para>Creates a new android.test.mock.MockContentResolver, a new IsolatedContext that isolates the provider's file operations, and a new instance of the provider under test within the isolated environment. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tears down the environment for the test fixture. </para> <para>Calls android.content.ContentProvider#shutdown() on the android.content.ContentProvider represented by mProvider. </para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new content provider of the same type as that passed to the test case class, with an authority name set to the authority parameter, and using an SQLite database as the underlying data source. The SQL statement parameter is used to create the database. This method also creates a new MockContentResolver and adds the provider to it. </para> <para>Both the new provider and the new resolver are put into an IsolatedContext that uses the targetContext parameter for file operations and a MockContext for everything else. The IsolatedContext prepends the filenamePrefix parameter to file, database, and directory names. </para> <para>This is a convenience method for creating a "mock" provider that can contain test data. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ContentResolver A new MockContentResolver linked to the provider</para>
				/// </returns>
				/// <java-name>
				/// newResolverWithContentProviderFromSql
				/// </java-name>
				[Dot42.DexImport("newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Lj" +
    "ava/lang/String;ILjava/lang/String;)Landroid/content/ContentResolver;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Landroid/content/Context;Ljava/lang/String;" +
    "Ljava/lang/Class<TT;>;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)La" +
    "ndroid/content/ContentResolver;")]
				public static global::Android.Content.ContentResolver NewResolverWithContentProviderFromSql<JavaT>(global::Android.Content.Context targetContext, string filenamePrefix, global::System.Type providerClass, string authority, string databaseName, int databaseVersion, string sql) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ProviderTestCase2() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the content provider created by this class in the setUp() method. </para>        
				/// </summary>
				/// <returns>
				///  <para>T An instance of the provider class given as a parameter to the test case class. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public virtual T Provider
				{
						[Dot42.DexImport("getProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <summary>
				///  <para>Gets the MockContentResolver created by this class during initialization. You must use the methods of this resolver to access the provider under test.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A MockContentResolver instance. </para>
				/// </returns>
				/// <java-name>
				/// getMockContentResolver
				/// </java-name>
				public virtual global::Android.Test.Mock.MockContentResolver MockContentResolver
				{
						[Dot42.DexImport("getMockContentResolver", "()Landroid/test/mock/MockContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Test.Mock.MockContentResolver); }
				}

				/// <summary>
				///  <para>Gets the IsolatedContext created by this class during initialization. </para>        
				/// </summary>
				/// <returns>
				///  <para>The IsolatedContext instance </para>
				/// </returns>
				/// <java-name>
				/// getMockContext
				/// </java-name>
				public virtual global::Android.Test.IsolatedContext MockContext
				{
						[Dot42.DexImport("getMockContext", "()Landroid/test/IsolatedContext;", AccessFlags = 1)]
						get{ return default(global::Android.Test.IsolatedContext); }
				}

		}

		/// <summary>
		///  <para>This is a class which delegates to the given context, but performs database and file operations with a renamed database/file name (prefixes default names with a given prefix). </para>    
		/// </summary>
		/// <java-name>
		/// android/test/RenamingDelegatingContext
		/// </java-name>
		[Dot42.DexImport("android/test/RenamingDelegatingContext", AccessFlags = 33)]
		public partial class RenamingDelegatingContext : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 1)]
				public RenamingDelegatingContext(global::Android.Content.Context context, string filePrefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 1)]
				public RenamingDelegatingContext(global::Android.Content.Context context, global::Android.Content.Context fileContext, string filePrefix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// providerWithRenamedContext
				/// </java-name>
				[Dot42.DexImport("providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;)Landroid/content/Co" +
    "ntentProvider;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Ljava/lang/Class<TT;>;Landroid/content/Cont" +
    "ext;Ljava/lang/String;)TT;")]
				public static T ProviderWithRenamedContext<T>(global::System.Type contentProvider, global::Android.Content.Context c, string filePrefix) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// providerWithRenamedContext
				/// </java-name>
				[Dot42.DexImport("providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;Z)Landroid/content/C" +
    "ontentProvider;", AccessFlags = 9, Signature = "<T:Landroid/content/ContentProvider;>(Ljava/lang/Class<TT;>;Landroid/content/Cont" +
    "ext;Ljava/lang/String;Z)TT;")]
				public static T ProviderWithRenamedContext<T>(global::System.Type contentProvider, global::Android.Content.Context c, string filePrefix, bool allowAccessToExistingFilesAndDbs) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Makes accessible all files and databases whose names match the filePrefix that was passed to the constructor. Normally only files and databases that were created through this context are accessible. </para>        
				/// </summary>
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
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetDatabasePath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
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
				public override global::Java.IO.FileInputStream OpenFileInput(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.IO.FileOutputStream OpenFileOutput(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileOutputStream);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetFileStreamPath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string name) /* MethodBuilder.Create */ 
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
				protected internal RenamingDelegatingContext() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para>In order to support calls to getCacheDir(), we create a temp cache dir (inside the real one) and return it instead. This code is basically getCacheDir(), except it uses the real cache dir as the parent directory and creates a test cache dir inside that. </para>        
				/// </summary>
				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public override global::Java.IO.File CacheDir
				{
						[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

		}

		/// <summary>
		///  <para>This test case provides a framework in which you can test Service classes in a controlled environment. It provides basic support for the lifecycle of a Service, and hooks with which you can inject various dependencies and control the environment in which your Service is tested.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about application testing, read the  developer guide.</para> <para> </para> <para> <b>Lifecycle Support.</b> A Service is accessed with a specific sequence of calls, as described in the  document. In order to support the lifecycle of a Service,  <code>ServiceTestCase</code> enforces this protocol:</para> <para> <ul> <li> <para>The setUp() method is called before each test method. The base implementation gets the system context. If you override  <code>setUp()</code>, you must call  <code>super.setUp()</code> as the first statement in your override.  </para></li> <li> <para>The test case waits to call android.app.Service#onCreate() until one of your test methods calls startService or bindService. This gives you an opportunity to set up or adjust any additional framework or test logic before you test the running service.  </para></li> <li> <para>When one of your test methods calls ServiceTestCase.startService() or ServiceTestCase.bindService(), the test case calls Service.onCreate() and then calls either Service.startService(Intent) or Service.bindService(Intent, ServiceConnection, int), as appropriate. It also stores values needed to track and support the lifecycle.  </para></li> <li> <para>After each test method finishes, the test case calls the tearDown method. This method stops and destroys the service with the appropriate calls, depending on how the service was started. If you override  <code>tearDown()</code>, your must call the  <code>super.tearDown()</code> as the last statement in your override.  </para></li></ul></para> <para> <b>Dependency Injection.</b> A service has two inherent dependencies, its Context and its associated Application. The ServiceTestCase framework allows you to inject modified, mock, or isolated replacements for these dependencies, and thus perform unit tests with controlled dependencies in an isolated environment. </para> <para>By default, the test case is injected with a full system context and a generic MockApplication object. You can inject alternatives to either of these by invoking setContext() or setApplication(). You must do this  <b>before</b> calling startService() or bindService(). The test framework provides a number of alternatives for Context, including MockContext, RenamingDelegatingContext, ContextWrapper, and android.test.IsolatedContext. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/ServiceTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/ServiceTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Service;>Landroid/test/AndroidTestCase;")]
		public abstract partial class ServiceTestCase<T> : global::Android.Test.AndroidTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<TT;>;)V")]
				public ServiceTestCase(global::System.Type serviceClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the current system context and stores it.</para> <para>Extend this method to do your own test initialization. If you do so, you must call  <code>super.setUp()</code> as the first statement in your override. The method is called before each test method is executed. </para>        
				/// </summary>
				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates the service under test and attaches all injected dependencies (Context, Application) to it. This is called automatically by startService or by bindService. If you need to call setContext() or setApplication(), do so before calling this method. </para>        
				/// </summary>
				/// <java-name>
				/// setupService
				/// </java-name>
				[Dot42.DexImport("setupService", "()V", AccessFlags = 4)]
				protected internal virtual void SetupService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts the service under test, in the same way as if it were started by Context.startService(Intent) with an android.content.Intent that identifies a service. If you use this method to start the service, it is automatically stopped by tearDown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void StartService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts the service under test, in the same way as if it were started by Context.bindService(Intent, ServiceConnection, flags) with an android.content.Intent that identifies a service. </para> <para>Notice that the parameters are different. You do not provide a android.content.ServiceConnection object or the flags parameter. Instead, you only provide the Intent. The method returns an object whose type is a subclass of android.os.IBinder, or null if the method fails. An IBinder object refers to a communication channel between the application and the service. The flag is assumed to be android.content.Context#BIND_AUTO_CREATE. </para> <para>See  for more information about the communication channel object returned by this method. </para> <para>Note: To be able to use bindService in a test, the service must implement getService() method. An example of this is in the ApiDemos sample application, in the LocalService demo.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An object whose type is a subclass of IBinder, for making further calls into the service. </para>
				/// </returns>
				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 4)]
				protected internal virtual global::Android.OS.IBinder BindService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Makes the necessary calls to stop (or unbind) the service under test, and calls onDestroy(). Ordinarily this is called automatically (by tearDown, but you can call it directly from your test in order to check for proper shutdown behavior. </para>        
				/// </summary>
				/// <java-name>
				/// shutdownService
				/// </java-name>
				[Dot42.DexImport("shutdownService", "()V", AccessFlags = 4)]
				protected internal virtual void ShutdownService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Shuts down the service under test. Ensures all resources are cleaned up and garbage collected before moving on to the next test. This method is called after each test method. </para> <para>Subclasses that override this method must call  <code>super.tearDown()</code> as their last statement. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal override void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tests that setupService() runs correctly and issues an junit.framework.Assert#assertNotNull(String, Object) if it does. You can override this test method if you wish.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// testServiceTestCaseSetUpProperly
				/// </java-name>
				[Dot42.DexImport("testServiceTestCaseSetUpProperly", "()V", AccessFlags = 1)]
				public virtual void TestServiceTestCaseSetUpProperly() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ServiceTestCase() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An instance of the service under test. This instance is created automatically when a test calls startService or bindService. </para>
				/// </returns>
				/// <java-name>
				/// getService
				/// </java-name>
				public virtual T Service
				{
						[Dot42.DexImport("getService", "()Landroid/app/Service;", AccessFlags = 1, Signature = "()TT;")]
						get{ return default(T); }
				}

				/// <summary>
				///  <para>Returns the Application object in use by the service under test.</para> <para> <para>setApplication </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The application object.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the real system context that is saved by setUp(). Use it to create mock or other types of context objects for the service under test.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A normal system context. </para>
				/// </returns>
				/// <java-name>
				/// getSystemContext
				/// </java-name>
				public virtual global::Android.Content.Context SystemContext
				{
						[Dot42.DexImport("getSystemContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

		}

		/// <summary>
		///  <para>If you would like to test a single activity with an android.test.InstrumentationTestCase, this provides some of the boiler plate to launch and finish the activity in setUp and tearDown.</para> <para>This launches the activity only once for the entire class instead of doing it in every setup / teardown call. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/SingleLaunchActivityTestCase
		/// </java-name>
		[Dot42.DexImport("android/test/SingleLaunchActivityTestCase", AccessFlags = 1057, Signature = "<T:Landroid/app/Activity;>Landroid/test/InstrumentationTestCase;")]
		public abstract partial class SingleLaunchActivityTestCase<T> : global::Android.Test.InstrumentationTestCase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <b>NOTE:</b> The parameter  <b>pkg</b> must refer to the package identifier of the package hosting the activity to be launched, which is specified in the AndroidManifest.xml file. This is not necessarily the same as the java package name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<TT;>;)V")]
				public SingleLaunchActivityTestCase(string pkg, global::System.Type activityClass) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal override void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after run() is called, even if run() threw an exception, but not if setUp() threw an execption. </para>        
				/// </summary>
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
				protected internal SingleLaunchActivityTestCase() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <summary>
		///  <para>If you would like to test sync a single provider with an InstrumentationTestCase, this provides some of the boiler plate in setUp and tearDown. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Syncs the specified provider. </para>        
				/// </summary>
				/// <java-name>
				/// syncProvider
				/// </java-name>
				[Dot42.DexImport("syncProvider", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SyncProvider(global::Android.Net.Uri uri, string accountName, string authority) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Reusable methods for generating touch events. These methods can be used with InstrumentationTestCase or ActivityInstrumentationTestCase2 to simulate user interaction with the application through a touch screen. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Simulate touching in the center of the screen and dragging one quarter of the way down  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragQuarterScreenDown
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenDown", "(Landroid/test/ActivityInstrumentationTestCase;)V", AccessFlags = 9)]
				public static void DragQuarterScreenDown(global::Android.Test.ActivityInstrumentationTestCase<object> test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching in the center of the screen and dragging one quarter of the way down </para>        
				/// </summary>
				/// <java-name>
				/// dragQuarterScreenDown
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenDown", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V", AccessFlags = 9)]
				public static void DragQuarterScreenDown(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching in the center of the screen and dragging one quarter of the way up  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragQuarterScreenUp
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenUp", "(Landroid/test/ActivityInstrumentationTestCase;)V", AccessFlags = 9)]
				public static void DragQuarterScreenUp(global::Android.Test.ActivityInstrumentationTestCase<object> test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching in the center of the screen and dragging one quarter of the way up </para>        
				/// </summary>
				/// <java-name>
				/// dragQuarterScreenUp
				/// </java-name>
				[Dot42.DexImport("dragQuarterScreenUp", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V", AccessFlags = 9)]
				public static void DragQuarterScreenUp(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scroll a ViewGroup to the bottom by repeatedly calling dragQuarterScreenUp(InstrumentationTestCase, Activity)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// scrollToBottom
				/// </java-name>
				[Dot42.DexImport("scrollToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void ScrollToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.ViewGroup v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scroll a ViewGroup to the bottom by repeatedly calling dragQuarterScreenUp(InstrumentationTestCase, Activity)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scrollToBottom
				/// </java-name>
				[Dot42.DexImport("scrollToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGr" +
    "oup;)V", AccessFlags = 9)]
				public static void ScrollToBottom(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity, global::Android.Views.ViewGroup v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scroll a ViewGroup to the top by repeatedly calling dragQuarterScreenDown(InstrumentationTestCase, Activity)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// scrollToTop
				/// </java-name>
				[Dot42.DexImport("scrollToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void ScrollToTop(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.ViewGroup v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scroll a ViewGroup to the top by repeatedly calling dragQuarterScreenDown(InstrumentationTestCase, Activity)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scrollToTop
				/// </java-name>
				[Dot42.DexImport("scrollToTop", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGr" +
    "oup;)V", AccessFlags = 9)]
				public static void ScrollToTop(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity, global::Android.Views.ViewGroup v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the bottom of the screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the bottom of the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;)" +
    "V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the bottom of the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View activity, int v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the bottom of the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToBottom
				/// </java-name>
				[Dot42.DexImport("dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;I" +
    ")V", AccessFlags = 9)]
				public static void DragViewToBottom(global::Android.Test.InstrumentationTestCase test, global::Android.App.Activity activity, global::Android.Views.View v, int stepCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and releasing quickly (before the tap timeout).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// tapView
				/// </java-name>
				[Dot42.DexImport("tapView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void TapView(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and cancelling (so no onClick should fire, etc).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// touchAndCancelView
				/// </java-name>
				[Dot42.DexImport("touchAndCancelView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void TouchAndCancelView(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and releasing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clickView
				/// </java-name>
				[Dot42.DexImport("clickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void ClickView(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view, holding until it is a long press, and then releasing.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// longClickView
				/// </java-name>
				[Dot42.DexImport("longClickView", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void LongClickView(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view, holding until it is a long press, and then releasing.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// longClickView
				/// </java-name>
				[Dot42.DexImport("longClickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void LongClickView(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the top of the screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the top of the screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v, int stepCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the top of the screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching the center of a view and dragging to the top of the screen.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dragViewToTop
				/// </java-name>
				[Dot42.DexImport("dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void DragViewToTop(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v, int stepCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it by the specified amount.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewBy
				/// </java-name>
				[Dot42.DexImport("dragViewBy", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewBy(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v, int gravity, int deltaX, int deltaY) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it by the specified amount.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewBy
				/// </java-name>
				[Dot42.DexImport("dragViewBy", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewBy(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v, int gravity, int deltaX, int deltaY) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewTo
				/// </java-name>
				[Dot42.DexImport("dragViewTo", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewTo(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v, int gravity, int toX, int toY) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewTo
				/// </java-name>
				[Dot42.DexImport("dragViewTo", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I", AccessFlags = 9)]
				public static int DragViewTo(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v, int gravity, int toX, int toY) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location. Only moves horizontally.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewToX
				/// </java-name>
				[Dot42.DexImport("dragViewToX", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToX(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v, int gravity, int toX) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location. Only moves horizontally.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewToX
				/// </java-name>
				[Dot42.DexImport("dragViewToX", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToX(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v, int gravity, int toX) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location. Only moves vertically.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewToY
				/// </java-name>
				[Dot42.DexImport("dragViewToY", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToY(global::Android.Test.ActivityInstrumentationTestCase<object> test, global::Android.Views.View v, int gravity, int toY) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Simulate touching a view and dragging it to a specified location. Only moves vertically.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>android.test.ActivityInstrumentationTestCase is deprecated in favor of android.test.ActivityInstrumentationTestCase2, which provides more options for configuring the Activity under test </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>distance in pixels covered by the drag</para>
				/// </returns>
				/// <java-name>
				/// dragViewToY
				/// </java-name>
				[Dot42.DexImport("dragViewToY", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I", AccessFlags = 9)]
				public static int DragViewToY(global::Android.Test.InstrumentationTestCase test, global::Android.Views.View v, int gravity, int toY) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Some useful assertions about views. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Assert that view is on the screen. </para>        
				/// </summary>
				/// <java-name>
				/// assertOnScreen
				/// </java-name>
				[Dot42.DexImport("assertOnScreen", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOnScreen(global::Android.Views.View origin, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that view is below the visible screen. </para>        
				/// </summary>
				/// <java-name>
				/// assertOffScreenBelow
				/// </java-name>
				[Dot42.DexImport("assertOffScreenBelow", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOffScreenBelow(global::Android.Views.View origin, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that view is above the visible screen. </para>        
				/// </summary>
				/// <java-name>
				/// assertOffScreenAbove
				/// </java-name>
				[Dot42.DexImport("assertOffScreenAbove", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertOffScreenAbove(global::Android.Views.View origin, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that a view has a particular x and y position on the visible screen. </para>        
				/// </summary>
				/// <java-name>
				/// assertHasScreenCoordinates
				/// </java-name>
				[Dot42.DexImport("assertHasScreenCoordinates", "(Landroid/view/View;Landroid/view/View;II)V", AccessFlags = 9)]
				public static void AssertHasScreenCoordinates(global::Android.Views.View origin, global::Android.Views.View view, int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are aligned on their baseline, that is that their baselines are on the same y location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertBaselineAligned
				/// </java-name>
				[Dot42.DexImport("assertBaselineAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertBaselineAligned(global::Android.Views.View first, global::Android.Views.View second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are right aligned, that is that their right edges are on the same x location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertRightAligned
				/// </java-name>
				[Dot42.DexImport("assertRightAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertRightAligned(global::Android.Views.View first, global::Android.Views.View second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are right aligned, that is that their right edges are on the same x location, with respect to the specified margin.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertRightAligned
				/// </java-name>
				[Dot42.DexImport("assertRightAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertRightAligned(global::Android.Views.View first, global::Android.Views.View second, int margin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are left aligned, that is that their left edges are on the same x location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertLeftAligned
				/// </java-name>
				[Dot42.DexImport("assertLeftAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertLeftAligned(global::Android.Views.View first, global::Android.Views.View second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are left aligned, that is that their left edges are on the same x location, with respect to the specified margin.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertLeftAligned
				/// </java-name>
				[Dot42.DexImport("assertLeftAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertLeftAligned(global::Android.Views.View first, global::Android.Views.View second, int margin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are bottom aligned, that is that their bottom edges are on the same y location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertBottomAligned
				/// </java-name>
				[Dot42.DexImport("assertBottomAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertBottomAligned(global::Android.Views.View first, global::Android.Views.View second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are bottom aligned, that is that their bottom edges are on the same y location, with respect to the specified margin.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertBottomAligned
				/// </java-name>
				[Dot42.DexImport("assertBottomAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertBottomAligned(global::Android.Views.View first, global::Android.Views.View second, int margin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are top aligned, that is that their top edges are on the same y location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertTopAligned
				/// </java-name>
				[Dot42.DexImport("assertTopAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertTopAligned(global::Android.Views.View first, global::Android.Views.View second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that two views are top aligned, that is that their top edges are on the same y location, with respect to the specified margin.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertTopAligned
				/// </java-name>
				[Dot42.DexImport("assertTopAligned", "(Landroid/view/View;Landroid/view/View;I)V", AccessFlags = 9)]
				public static void AssertTopAligned(global::Android.Views.View first, global::Android.Views.View second, int margin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that the  <code>test</code> view is horizontally center aligned with respect to the  <code>reference</code> view.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertHorizontalCenterAligned
				/// </java-name>
				[Dot42.DexImport("assertHorizontalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertHorizontalCenterAligned(global::Android.Views.View reference, global::Android.Views.View test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that the  <code>test</code> view is vertically center aligned with respect to the  <code>reference</code> view.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertVerticalCenterAligned
				/// </java-name>
				[Dot42.DexImport("assertVerticalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertVerticalCenterAligned(global::Android.Views.View reference, global::Android.Views.View test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert the specified group's integrity. The children count should be &gt;= 0 and each child should be non-null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertGroupIntegrity
				/// </java-name>
				[Dot42.DexImport("assertGroupIntegrity", "(Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void AssertGroupIntegrity(global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that the specified group contains a specific child once and only once.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertGroupContains
				/// </java-name>
				[Dot42.DexImport("assertGroupContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertGroupContains(global::Android.Views.ViewGroup parent, global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assert that the specified group does not contain a specific child.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assertGroupNotContains
				/// </java-name>
				[Dot42.DexImport("assertGroupNotContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 9)]
				public static void AssertGroupNotContains(global::Android.Views.ViewGroup parent, global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

		}

}

