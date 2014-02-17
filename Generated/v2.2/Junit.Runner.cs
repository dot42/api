// Copyright (C) 2014 dot42
//
// Original filename: Junit.Runner.cs
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
namespace Junit.Runner
{
		/// <summary>
		/// <para>This class defines the current version of JUnit </para>    
		/// </summary>
		/// <java-name>
		/// junit/runner/Version
		/// </java-name>
		[Dot42.DexImport("junit/runner/Version", AccessFlags = 33)]
		public partial class Version
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Version() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// id
				/// </java-name>
				[Dot42.DexImport("id", "()Ljava/lang/String;", AccessFlags = 9)]
				public static string Id() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>An interface to define how a test suite should be loaded. </para>    
		/// </summary>
		/// <java-name>
		/// junit/runner/TestSuiteLoader
		/// </java-name>
		[Dot42.DexImport("junit/runner/TestSuiteLoader", AccessFlags = 1537)]
		public partial interface ITestSuiteLoader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 1025)]
				global::System.Type Load(string suiteClassName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// reload
				/// </java-name>
				[Dot42.DexImport("reload", "(Ljava/lang/Class;)Ljava/lang/Class;", AccessFlags = 1025)]
				global::System.Type Reload(global::System.Type aClass) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Base class for all test runners. This class was born live on stage in Sardinia during XP2000. </para>    
		/// </summary>
		/// <java-name>
		/// junit/runner/BaseTestRunner
		/// </java-name>
		[Dot42.DexImport("junit/runner/BaseTestRunner", AccessFlags = 1057)]
		public abstract partial class BaseTestRunner : global::Junit.Framework.ITestListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SUITE_METHODNAME
				/// </java-name>
				[Dot42.DexImport("SUITE_METHODNAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUITE_METHODNAME = "suite";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseTestRunner() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A test started. </para>        
				/// </summary>
				/// <java-name>
				/// startTest
				/// </java-name>
				[Dot42.DexImport("startTest", "(Ljunit/framework/Test;)V", AccessFlags = 33)]
				public virtual void StartTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreferences
				/// </java-name>
				[Dot42.DexImport("setPreferences", "(Ljava/util/Properties;)V", AccessFlags = 12)]
				protected internal static void SetPreferences(global::Java.Util.Properties preferences) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreferences
				/// </java-name>
				[Dot42.DexImport("getPreferences", "()Ljava/util/Properties;", AccessFlags = 12)]
				protected internal static global::Java.Util.Properties GetPreferences() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Properties);
				}

				/// <java-name>
				/// savePreferences
				/// </java-name>
				[Dot42.DexImport("savePreferences", "()V", AccessFlags = 9)]
				public static void SavePreferences() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreference
				/// </java-name>
				[Dot42.DexImport("setPreference", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPreference(string key, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A test ended. </para>        
				/// </summary>
				/// <java-name>
				/// endTest
				/// </java-name>
				[Dot42.DexImport("endTest", "(Ljunit/framework/Test;)V", AccessFlags = 33)]
				public virtual void EndTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addError
				/// </java-name>
				[Dot42.DexImport("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 33)]
				public virtual void AddError(global::Junit.Framework.ITest test, global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFailure
				/// </java-name>
				[Dot42.DexImport("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", AccessFlags = 33)]
				public virtual void AddFailure(global::Junit.Framework.ITest test, global::Junit.Framework.AssertionFailedError t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// testStarted
				/// </java-name>
				[Dot42.DexImport("testStarted", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void TestStarted(string testName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// testEnded
				/// </java-name>
				[Dot42.DexImport("testEnded", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void TestEnded(string testName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// testFailed
				/// </java-name>
				[Dot42.DexImport("testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				public abstract void TestFailed(int status, global::Junit.Framework.ITest test, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the Test corresponding to the given suite. This is a template method, subclasses override runFailed(), clearStatus(). </para>        
				/// </summary>
				/// <java-name>
				/// getTest
				/// </java-name>
				[Dot42.DexImport("getTest", "(Ljava/lang/String;)Ljunit/framework/Test;", AccessFlags = 1)]
				public virtual global::Junit.Framework.ITest GetTest(string suiteClassName) /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.ITest);
				}

				/// <summary>
				/// <para>Returns the formatted string of the elapsed time. </para>        
				/// </summary>
				/// <java-name>
				/// elapsedTimeAsString
				/// </java-name>
				[Dot42.DexImport("elapsedTimeAsString", "(J)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ElapsedTimeAsString(long runTime) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Processes the command line arguments and returns the name of the suite class to run or null </para>        
				/// </summary>
				/// <java-name>
				/// processArguments
				/// </java-name>
				[Dot42.DexImport("processArguments", "([Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string ProcessArguments(string[] args) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the loading behaviour of the test runner </para>        
				/// </summary>
				/// <java-name>
				/// setLoading
				/// </java-name>
				[Dot42.DexImport("setLoading", "(Z)V", AccessFlags = 1)]
				public virtual void SetLoading(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Extract the class name from a String in VA/Java style </para>        
				/// </summary>
				/// <java-name>
				/// extractClassName
				/// </java-name>
				[Dot42.DexImport("extractClassName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ExtractClassName(string className) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Truncates a String to the maximum length. </para>        
				/// </summary>
				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Truncate(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Override to define how to handle a failed loading of a test suite. </para>        
				/// </summary>
				/// <java-name>
				/// runFailed
				/// </java-name>
				[Dot42.DexImport("runFailed", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void RunFailed(string message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the loaded Class for a suite name. </para>        
				/// </summary>
				/// <java-name>
				/// loadSuiteClass
				/// </java-name>
				[Dot42.DexImport("loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4)]
				protected internal virtual global::System.Type LoadSuiteClass(string suiteClassName) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Clears the status message. </para>        
				/// </summary>
				/// <java-name>
				/// clearStatus
				/// </java-name>
				[Dot42.DexImport("clearStatus", "()V", AccessFlags = 4)]
				protected internal virtual void ClearStatus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the loader to be used.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>not present in JUnit4.10 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getLoader
				/// </java-name>
				[Dot42.DexImport("getLoader", "()Ljunit/runner/TestSuiteLoader;", AccessFlags = 1)]
				public virtual global::Junit.Runner.ITestSuiteLoader GetLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Runner.ITestSuiteLoader);
				}

				/// <java-name>
				/// useReloadingTestSuiteLoader
				/// </java-name>
				[Dot42.DexImport("useReloadingTestSuiteLoader", "()Z", AccessFlags = 4)]
				protected internal virtual bool UseReloadingTestSuiteLoader() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPreference
				/// </java-name>
				[Dot42.DexImport("getPreference", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetPreference(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPreference
				/// </java-name>
				[Dot42.DexImport("getPreference", "(Ljava/lang/String;I)I", AccessFlags = 9)]
				public static int GetPreference(string key, int dflt) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>not present in JUnit4.10 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// inVAJava
				/// </java-name>
				[Dot42.DexImport("inVAJava", "()Z", AccessFlags = 9)]
				public static bool InVAJava() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFilteredTrace
				/// </java-name>
				[Dot42.DexImport("getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetFilteredTrace(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFilteredTrace
				/// </java-name>
				[Dot42.DexImport("getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetFilteredTrace(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// showStackRaw
				/// </java-name>
				[Dot42.DexImport("showStackRaw", "()Z", AccessFlags = 12)]
				protected internal static bool ShowStackRaw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPreferences
				/// </java-name>
				protected internal static global::Java.Util.Properties Preferences
				{
				[Dot42.DexImport("getPreferences", "()Ljava/util/Properties;", AccessFlags = 12)]
						get{ return GetPreferences(); }
				[Dot42.DexImport("setPreferences", "(Ljava/util/Properties;)V", AccessFlags = 12)]
						set{ SetPreferences(value); }
				}

				/// <summary>
				/// <para>Returns the loader to be used.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>not present in JUnit4.10 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getLoader
				/// </java-name>
				public global::Junit.Runner.ITestSuiteLoader Loader
				{
				[Dot42.DexImport("getLoader", "()Ljunit/runner/TestSuiteLoader;", AccessFlags = 1)]
						get{ return GetLoader(); }
				}

		}

}


