// Copyright (C) 2014 dot42
//
// Original filename: Junit.Framework.cs
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
namespace Junit.Framework
{
		/// <summary>
		/// <para>A Listener for test progress </para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/TestListener
		/// </java-name>
		[Dot42.DexImport("junit/framework/TestListener", AccessFlags = 1537)]
		public partial interface ITestListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>An error occurred. </para>        
				/// </summary>
				/// <java-name>
				/// addError
				/// </java-name>
				[Dot42.DexImport("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void AddError(global::Junit.Framework.ITest test, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>A failure occurred. </para>        
				/// </summary>
				/// <java-name>
				/// addFailure
				/// </java-name>
				[Dot42.DexImport("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", AccessFlags = 1025)]
				void AddFailure(global::Junit.Framework.ITest test, global::Junit.Framework.AssertionFailedError t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>A test ended. </para>        
				/// </summary>
				/// <java-name>
				/// endTest
				/// </java-name>
				[Dot42.DexImport("endTest", "(Ljunit/framework/Test;)V", AccessFlags = 1025)]
				void EndTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>A test started. </para>        
				/// </summary>
				/// <java-name>
				/// startTest
				/// </java-name>
				[Dot42.DexImport("startTest", "(Ljunit/framework/Test;)V", AccessFlags = 1025)]
				void StartTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Thrown when an assert equals for Strings failed.</para><para>Inspired by a patch from Alex Chaffee  </para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/ComparisonFailure
		/// </java-name>
		[Dot42.DexImport("junit/framework/ComparisonFailure", AccessFlags = 33)]
		public partial class ComparisonFailure : global::Junit.Framework.AssertionFailedError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a comparison failure. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ComparisonFailure(string message, string expected, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns "..." in place of common prefix and "..." in place of common suffix between expected and actual.</para><para><para>Throwable::getMessage() </para></para>        
				/// </summary>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the actual string value </para>        
				/// </summary>
				/// <returns>
				/// <para>the actual string value </para>
				/// </returns>
				/// <java-name>
				/// getActual
				/// </java-name>
				[Dot42.DexImport("getActual", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetActual() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the expected string value </para>        
				/// </summary>
				/// <returns>
				/// <para>the expected string value </para>
				/// </returns>
				/// <java-name>
				/// getExpected
				/// </java-name>
				[Dot42.DexImport("getExpected", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetExpected() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComparisonFailure() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the actual string value </para>        
				/// </summary>
				/// <returns>
				/// <para>the actual string value </para>
				/// </returns>
				/// <java-name>
				/// getActual
				/// </java-name>
				public string Actual
				{
				[Dot42.DexImport("getActual", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActual(); }
				}

				/// <summary>
				/// <para>Gets the expected string value </para>        
				/// </summary>
				/// <returns>
				/// <para>the expected string value </para>
				/// </returns>
				/// <java-name>
				/// getExpected
				/// </java-name>
				public string Expected
				{
				[Dot42.DexImport("getExpected", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetExpected(); }
				}

		}

		/// <summary>
		/// <para>A test case defines the fixture to run multiple tests. To define a test case<br></br> <ol><li><para>implement a subclass of <code>TestCase</code> </para></li><li><para>define instance variables that store the state of the fixture </para></li><li><para>initialize the fixture state by overriding setUp() </para></li><li><para>clean-up after a test by overriding tearDown(). </para></li></ol>Each test runs in its own fixture so there can be no side effects among test runs. Here is an example: <pre>
		///    public class MathTest extends TestCase {
		///       protected double fValue1;
		///       protected double fValue2;
		/// 
		///       protected void setUp() {
		///          fValue1= 2.0;
		///          fValue2= 3.0;
		///       }
		///    }
		///    </pre></para><para>For each test implement a method which interacts with the fixture. Verify the expected results with assertions specified by calling junit.framework.Assert#assertTrue(String, boolean) with a boolean. <pre>
		///       public void testAdd() {
		///          double result= fValue1 + fValue2;
		///          assertTrue(result == 5.0);
		///       }
		///    </pre></para><para>Once the methods are defined you can run them. The framework supports both a static type safe and more dynamic way to run a test. In the static way you override the runTest method and define the method to be invoked. A convenient way to do so is with an anonymous inner class. <pre>
		///    TestCase test= new MathTest("add") {
		///       public void runTest() {
		///          testAdd();
		///       }
		///    };
		///    test.run();
		///    </pre></para><para>The dynamic way uses reflection to implement runTest(). It dynamically finds and invokes a method. In this case the name of the test case has to correspond to the test method to be run. <pre>
		///    TestCase test= new MathTest("testAdd");
		///    test.run();
		///    </pre></para><para>The tests to be run can be collected into a TestSuite. JUnit provides different <b>test runners</b> which can run a test suite and collect the results. A test runner either expects a static method <code>suite</code> as the entry point to get a test to run or it will extract the suite automatically. <pre>
		///    public static Test suite() {
		///       suite.addTest(new MathTest("testAdd"));
		///       suite.addTest(new MathTest("testDivideByZero"));
		///       return suite;
		///    }
		///    </pre> <para>TestResult </para><simplesectsep></simplesectsep><para>TestSuite </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/TestCase
		/// </java-name>
		[Dot42.DexImport("junit/framework/TestCase", AccessFlags = 1057)]
		public abstract partial class TestCase : global::Junit.Framework.Assert, global::Junit.Framework.ITest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>No-arg constructor to enable serialization. This method is not intended to be used by mere mortals without calling setName(). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TestCase() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a test case with the given name. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TestCase(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Counts the number of test cases executed by run(TestResult result). </para>        
				/// </summary>
				/// <java-name>
				/// countTestCases
				/// </java-name>
				[Dot42.DexImport("countTestCases", "()I", AccessFlags = 1)]
				public virtual int CountTestCases() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Creates a default TestResult object</para><para><para>TestResult </para></para>        
				/// </summary>
				/// <java-name>
				/// createResult
				/// </java-name>
				[Dot42.DexImport("createResult", "()Ljunit/framework/TestResult;", AccessFlags = 4)]
				protected internal virtual global::Junit.Framework.TestResult CreateResult() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestResult);
				}

				/// <summary>
				/// <para>A convenience method to run this test, collecting the results with a default TestResult object.</para><para><para>TestResult </para></para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()Ljunit/framework/TestResult;", AccessFlags = 1)]
				public virtual global::Junit.Framework.TestResult Run() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.TestResult);
				}

				/// <summary>
				/// <para>Runs the test case and collects the results in TestResult. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "(Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public virtual void Run(global::Junit.Framework.TestResult result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Runs the bare test sequence. </para>        
				/// </summary>
				/// <java-name>
				/// runBare
				/// </java-name>
				[Dot42.DexImport("runBare", "()V", AccessFlags = 1)]
				public virtual void RunBare() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override to run the test and assert its state. </para>        
				/// </summary>
				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "()V", AccessFlags = 4)]
				protected internal virtual void RunTest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets up the fixture, for example, open a network connection. This method is called before a test is executed. </para>        
				/// </summary>
				/// <java-name>
				/// setUp
				/// </java-name>
				[Dot42.DexImport("setUp", "()V", AccessFlags = 4)]
				protected internal virtual void SetUp() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tears down the fixture, for example, close a network connection. This method is called after a test is executed. </para>        
				/// </summary>
				/// <java-name>
				/// tearDown
				/// </java-name>
				[Dot42.DexImport("tearDown", "()V", AccessFlags = 4)]
				protected internal virtual void TearDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a string representation of the test case </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the name of a TestCase </para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the TestCase </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the name of a TestCase </para>        
				/// </summary>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the name of a TestCase </para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the TestCase </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetName(value); }
				}

		}

		/// <summary>
		/// <para>A set of assert methods. Messages are only displayed when an assert fails. </para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/Assert
		/// </java-name>
		[Dot42.DexImport("junit/framework/Assert", AccessFlags = 33)]
		public partial class Assert
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protect constructor since it is a static only class </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Assert() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that a condition is true. If it isn't it throws an AssertionFailedError with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertTrue
				/// </java-name>
				[Dot42.DexImport("assertTrue", "(Ljava/lang/String;Z)V", AccessFlags = 9)]
				public static void AssertTrue(string message, bool condition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that a condition is true. If it isn't it throws an AssertionFailedError. </para>        
				/// </summary>
				/// <java-name>
				/// assertTrue
				/// </java-name>
				[Dot42.DexImport("assertTrue", "(Z)V", AccessFlags = 9)]
				public static void AssertTrue(bool condition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that a condition is false. If it isn't it throws an AssertionFailedError with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertFalse
				/// </java-name>
				[Dot42.DexImport("assertFalse", "(Ljava/lang/String;Z)V", AccessFlags = 9)]
				public static void AssertFalse(string message, bool condition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that a condition is false. If it isn't it throws an AssertionFailedError. </para>        
				/// </summary>
				/// <java-name>
				/// assertFalse
				/// </java-name>
				[Dot42.DexImport("assertFalse", "(Z)V", AccessFlags = 9)]
				public static void AssertFalse(bool condition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Fails a test with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// fail
				/// </java-name>
				[Dot42.DexImport("fail", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Fail(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Fails a test with no message. </para>        
				/// </summary>
				/// <java-name>
				/// fail
				/// </java-name>
				[Dot42.DexImport("fail", "()V", AccessFlags = 9)]
				public static void Fail() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, object @object, object object1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertEquals(object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AssertEquals(string expected, string actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;DDD)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, double @double, double double1, double double2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(DDD)V", AccessFlags = 9)]
				public static void AssertEquals(double @double, double double1, double double2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;FFF)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(FFF)V", AccessFlags = 9)]
				public static void AssertEquals(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;JJ)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(JJ)V", AccessFlags = 9)]
				public static void AssertEquals(long expected, long actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;ZZ)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(ZZ)V", AccessFlags = 9)]
				public static void AssertEquals(bool expected, bool actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;BB)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, sbyte sByte, sbyte sByte1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;BB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(string @string, byte @byte, byte byte1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(BB)V", AccessFlags = 9)]
				public static void AssertEquals(sbyte expected, sbyte actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(BB)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void AssertEquals(byte expected, byte actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;CC)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, char @char, char char1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(CC)V", AccessFlags = 9)]
				public static void AssertEquals(char expected, char actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;SS)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, short int16, short int161) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(SS)V", AccessFlags = 9)]
				public static void AssertEquals(short expected, short actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(Ljava/lang/String;II)V", AccessFlags = 9)]
				public static void AssertEquals(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two ints are equal. </para>        
				/// </summary>
				/// <java-name>
				/// assertEquals
				/// </java-name>
				[Dot42.DexImport("assertEquals", "(II)V", AccessFlags = 9)]
				public static void AssertEquals(int expected, int actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that an object isn't null. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotNull
				/// </java-name>
				[Dot42.DexImport("assertNotNull", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotNull(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that an object isn't null. If it is an AssertionFailedError is thrown with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotNull
				/// </java-name>
				[Dot42.DexImport("assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotNull(string message, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that an object is null. If it isn't an AssertionError is thrown. Message contains: Expected: &lt;null&gt; but was: object</para><para></para>        
				/// </summary>
				/// <java-name>
				/// assertNull
				/// </java-name>
				[Dot42.DexImport("assertNull", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNull(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that an object is null. If it is not an AssertionFailedError is thrown with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNull
				/// </java-name>
				[Dot42.DexImport("assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNull(string message, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two objects refer to the same object. If they are not an AssertionFailedError is thrown with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertSame
				/// </java-name>
				[Dot42.DexImport("assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertSame(string message, object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two objects refer to the same object. If they are not the same an AssertionFailedError is thrown. </para>        
				/// </summary>
				/// <java-name>
				/// assertSame
				/// </java-name>
				[Dot42.DexImport("assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertSame(object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two objects do not refer to the same object. If they do refer to the same object an AssertionFailedError is thrown with the given message. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotSame
				/// </java-name>
				[Dot42.DexImport("assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotSame(string message, object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Asserts that two objects do not refer to the same object. If they do refer to the same object an AssertionFailedError is thrown. </para>        
				/// </summary>
				/// <java-name>
				/// assertNotSame
				/// </java-name>
				[Dot42.DexImport("assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void AssertNotSame(object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// failSame
				/// </java-name>
				[Dot42.DexImport("failSame", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void FailSame(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// failNotSame
				/// </java-name>
				[Dot42.DexImport("failNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void FailNotSame(string message, object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// failNotEquals
				/// </java-name>
				[Dot42.DexImport("failNotEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void FailNotEquals(string message, object expected, object actual) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Format(string message, object expected, object actual) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Thrown when an assertion failed. </para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/AssertionFailedError
		/// </java-name>
		[Dot42.DexImport("junit/framework/AssertionFailedError", AccessFlags = 33)]
		public partial class AssertionFailedError : global::Java.Lang.AssertionError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AssertionFailedError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AssertionFailedError(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A <b>Protectable</b> can be run and can throw a Throwable.</para><para><para>TestResult </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/Protectable
		/// </java-name>
		[Dot42.DexImport("junit/framework/Protectable", AccessFlags = 1537)]
		public partial interface IProtectable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Run the the following method protected. </para>        
				/// </summary>
				/// <java-name>
				/// protect
				/// </java-name>
				[Dot42.DexImport("protect", "()V", AccessFlags = 1025)]
				void Protect() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <code>TestFailure</code> collects a failed test together with the caught exception. <para>TestResult </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/TestFailure
		/// </java-name>
		[Dot42.DexImport("junit/framework/TestFailure", AccessFlags = 33)]
		public partial class TestFailure
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// fFailedTest
				/// </java-name>
				[Dot42.DexImport("fFailedTest", "Ljunit/framework/Test;", AccessFlags = 4)]
				protected internal global::Junit.Framework.ITest FFailedTest;
				/// <java-name>
				/// fThrownException
				/// </java-name>
				[Dot42.DexImport("fThrownException", "Ljava/lang/Throwable;", AccessFlags = 4)]
				protected internal global::System.Exception FThrownException;
				/// <summary>
				/// <para>Constructs a TestFailure with the given test and exception. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TestFailure(global::Junit.Framework.ITest failedTest, global::System.Exception thrownException) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the failed test. </para>        
				/// </summary>
				/// <java-name>
				/// failedTest
				/// </java-name>
				[Dot42.DexImport("failedTest", "()Ljunit/framework/Test;", AccessFlags = 1)]
				public virtual global::Junit.Framework.ITest FailedTest() /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.ITest);
				}

				/// <summary>
				/// <para>Gets the thrown exception. </para>        
				/// </summary>
				/// <java-name>
				/// thrownException
				/// </java-name>
				[Dot42.DexImport("thrownException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception ThrownException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns a short description of the failure. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Trace() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// exceptionMessage
				/// </java-name>
				[Dot42.DexImport("exceptionMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ExceptionMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isFailure
				/// </java-name>
				[Dot42.DexImport("isFailure", "()Z", AccessFlags = 1)]
				public virtual bool IsFailure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TestFailure() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A <b>Test</b> can be run and collect its results.</para><para><para>TestResult </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/Test
		/// </java-name>
		[Dot42.DexImport("junit/framework/Test", AccessFlags = 1537)]
		public partial interface ITest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Counts the number of test cases that will be run by this test. </para>        
				/// </summary>
				/// <java-name>
				/// countTestCases
				/// </java-name>
				[Dot42.DexImport("countTestCases", "()I", AccessFlags = 1025)]
				int CountTestCases() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Runs a test and collects its result in a TestResult instance. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "(Ljunit/framework/TestResult;)V", AccessFlags = 1025)]
				void Run(global::Junit.Framework.TestResult result) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <code>TestResult</code> collects the results of executing a test case. It is an instance of the Collecting Parameter pattern. The test framework distinguishes between <b>failures</b> and <b>errors</b>. A failure is anticipated and checked for with assertions. Errors are unanticipated problems like an ArrayIndexOutOfBoundsException.</para><para><para>Test </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/TestResult
		/// </java-name>
		[Dot42.DexImport("junit/framework/TestResult", AccessFlags = 33)]
		public partial class TestResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// fFailures
				/// </java-name>
				[Dot42.DexImport("fFailures", "Ljava/util/Vector;", AccessFlags = 4)]
				protected internal global::Java.Util.Vector<global::Junit.Framework.TestFailure> FFailures;
				/// <java-name>
				/// fErrors
				/// </java-name>
				[Dot42.DexImport("fErrors", "Ljava/util/Vector;", AccessFlags = 4)]
				protected internal global::Java.Util.Vector<global::Junit.Framework.TestFailure> FErrors;
				/// <java-name>
				/// fListeners
				/// </java-name>
				[Dot42.DexImport("fListeners", "Ljava/util/Vector;", AccessFlags = 4)]
				protected internal global::Java.Util.Vector<global::Junit.Framework.ITestListener> FListeners;
				/// <java-name>
				/// fRunTests
				/// </java-name>
				[Dot42.DexImport("fRunTests", "I", AccessFlags = 4)]
				protected internal int FRunTests;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TestResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds an error to the list of errors. The passed in exception caused the error. </para>        
				/// </summary>
				/// <java-name>
				/// addError
				/// </java-name>
				[Dot42.DexImport("addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", AccessFlags = 33)]
				public virtual void AddError(global::Junit.Framework.ITest test, global::System.Exception t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a failure to the list of failures. The passed in exception caused the failure. </para>        
				/// </summary>
				/// <java-name>
				/// addFailure
				/// </java-name>
				[Dot42.DexImport("addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", AccessFlags = 33)]
				public virtual void AddFailure(global::Junit.Framework.ITest test, global::Junit.Framework.AssertionFailedError t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a TestListener </para>        
				/// </summary>
				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Ljunit/framework/TestListener;)V", AccessFlags = 33)]
				public virtual void AddListener(global::Junit.Framework.ITestListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a TestListener </para>        
				/// </summary>
				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Ljunit/framework/TestListener;)V", AccessFlags = 33)]
				public virtual void RemoveListener(global::Junit.Framework.ITestListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Informs the result that a test was completed. </para>        
				/// </summary>
				/// <java-name>
				/// endTest
				/// </java-name>
				[Dot42.DexImport("endTest", "(Ljunit/framework/Test;)V", AccessFlags = 1)]
				public virtual void EndTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of detected errors. </para>        
				/// </summary>
				/// <java-name>
				/// errorCount
				/// </java-name>
				[Dot42.DexImport("errorCount", "()I", AccessFlags = 33)]
				public virtual int ErrorCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an Enumeration for the errors </para>        
				/// </summary>
				/// <java-name>
				/// errors
				/// </java-name>
				[Dot42.DexImport("errors", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<Ljunit/framework/TestFailure;>;")]
				public virtual global::Java.Util.IEnumeration<global::Junit.Framework.TestFailure> Errors() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Junit.Framework.TestFailure>);
				}

				/// <summary>
				/// <para>Gets the number of detected failures. </para>        
				/// </summary>
				/// <java-name>
				/// failureCount
				/// </java-name>
				[Dot42.DexImport("failureCount", "()I", AccessFlags = 33)]
				public virtual int FailureCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an Enumeration for the failures </para>        
				/// </summary>
				/// <java-name>
				/// failures
				/// </java-name>
				[Dot42.DexImport("failures", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<Ljunit/framework/TestFailure;>;")]
				public virtual global::Java.Util.IEnumeration<global::Junit.Framework.TestFailure> Failures() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Junit.Framework.TestFailure>);
				}

				/// <summary>
				/// <para>Runs a TestCase. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "(Ljunit/framework/TestCase;)V", AccessFlags = 4)]
				protected internal virtual void Run(global::Junit.Framework.TestCase test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of run tests. </para>        
				/// </summary>
				/// <java-name>
				/// runCount
				/// </java-name>
				[Dot42.DexImport("runCount", "()I", AccessFlags = 33)]
				public virtual int RunCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Runs a TestCase. </para>        
				/// </summary>
				/// <java-name>
				/// runProtected
				/// </java-name>
				[Dot42.DexImport("runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V", AccessFlags = 1)]
				public virtual void RunProtected(global::Junit.Framework.ITest test, global::Junit.Framework.IProtectable p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether the test run should stop </para>        
				/// </summary>
				/// <java-name>
				/// shouldStop
				/// </java-name>
				[Dot42.DexImport("shouldStop", "()Z", AccessFlags = 33)]
				public virtual bool ShouldStop() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Informs the result that a test will be started. </para>        
				/// </summary>
				/// <java-name>
				/// startTest
				/// </java-name>
				[Dot42.DexImport("startTest", "(Ljunit/framework/Test;)V", AccessFlags = 1)]
				public virtual void StartTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Marks that the test run should stop. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 33)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the entire test was successful or not. </para>        
				/// </summary>
				/// <java-name>
				/// wasSuccessful
				/// </java-name>
				[Dot42.DexImport("wasSuccessful", "()Z", AccessFlags = 33)]
				public virtual bool WasSuccessful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>A <code>TestSuite</code> is a <code>Composite</code> of Tests. It runs a collection of test cases. Here is an example using the dynamic test definition. <pre>
		///    TestSuite suite= new TestSuite();
		///    suite.addTest(new MathTest("testAdd"));
		///    suite.addTest(new MathTest("testDivideByZero"));
		///    </pre> </para><para>Alternatively, a TestSuite can extract the tests to be run automatically. To do so you pass the class of your TestCase class to the TestSuite constructor. <pre>
		///    TestSuite suite= new TestSuite(MathTest.class);
		///    </pre> </para><para>This constructor creates a suite with all the methods starting with "test" that take no arguments.</para><para>A final option is to do the same for a large array of test classes. <pre>
		///    Class[] testClasses = { MathTest.class, AnotherTest.class }
		///    TestSuite suite= new TestSuite(testClasses);
		///    </pre> </para><para><para>Test </para></para>    
		/// </summary>
		/// <java-name>
		/// junit/framework/TestSuite
		/// </java-name>
		[Dot42.DexImport("junit/framework/TestSuite", AccessFlags = 33)]
		public partial class TestSuite : global::Junit.Framework.ITest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an empty TestSuite. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TestSuite() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<*>;)V")]
				public TestSuite(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljunit/framework/TestCase;>;Ljava/lang/String;)V")]
				public TestSuite(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TestSuite(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/Class;)V", AccessFlags = 129, Signature = "([Ljava/lang/Class<*>;)V")]
				public TestSuite(params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "([Ljava/lang/Class<+Ljunit/framework/TestCase;>;Ljava/lang/String;)V")]
				public TestSuite(global::System.Type[] type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>...as the moon sets over the early morning Merlin, Oregon mountains, our intrepid adventurers type... </para>        
				/// </summary>
				/// <java-name>
				/// createTest
				/// </java-name>
				[Dot42.DexImport("createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;Ljava/lang/String;)Ljunit/framework/Test;")]
				public static global::Junit.Framework.ITest CreateTest(global::System.Type theClass, string name) /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.ITest);
				}

				/// <summary>
				/// <para>Gets a constructor which takes a single String as its argument or a no arg constructor. </para>        
				/// </summary>
				/// <java-name>
				/// getTestConstructor
				/// </java-name>
				[Dot42.DexImport("getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<*>;")]
				public static global::System.Reflection.ConstructorInfo GetTestConstructor(global::System.Type theClass) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo);
				}

				/// <summary>
				/// <para>Returns a test which will fail and log a warning message. </para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Ljava/lang/String;)Ljunit/framework/Test;", AccessFlags = 9)]
				public static global::Junit.Framework.ITest Warning(string message) /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.ITest);
				}

				/// <summary>
				/// <para>Adds a test to the suite. </para>        
				/// </summary>
				/// <java-name>
				/// addTest
				/// </java-name>
				[Dot42.DexImport("addTest", "(Ljunit/framework/Test;)V", AccessFlags = 1)]
				public virtual void AddTest(global::Junit.Framework.ITest test) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the tests from the given class to the suite </para>        
				/// </summary>
				/// <java-name>
				/// addTestSuite
				/// </java-name>
				[Dot42.DexImport("addTestSuite", "(Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
				public virtual void AddTestSuite(global::System.Type testClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Counts the number of test cases that will be run by this test. </para>        
				/// </summary>
				/// <java-name>
				/// countTestCases
				/// </java-name>
				[Dot42.DexImport("countTestCases", "()I", AccessFlags = 1)]
				public virtual int CountTestCases() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the suite. Not all test suites have a name and this method can return null. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Runs the tests and collects their result in a TestResult. </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "(Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public virtual void Run(global::Junit.Framework.TestResult result) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runTest
				/// </java-name>
				[Dot42.DexImport("runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", AccessFlags = 1)]
				public virtual void RunTest(global::Junit.Framework.ITest test, global::Junit.Framework.TestResult result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the name of the suite. </para>        
				/// </summary>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the test at the given index </para>        
				/// </summary>
				/// <java-name>
				/// testAt
				/// </java-name>
				[Dot42.DexImport("testAt", "(I)Ljunit/framework/Test;", AccessFlags = 1)]
				public virtual global::Junit.Framework.ITest TestAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Junit.Framework.ITest);
				}

				/// <summary>
				/// <para>Returns the number of tests in this suite </para>        
				/// </summary>
				/// <java-name>
				/// testCount
				/// </java-name>
				[Dot42.DexImport("testCount", "()I", AccessFlags = 1)]
				public virtual int TestCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the tests as an enumeration </para>        
				/// </summary>
				/// <java-name>
				/// tests
				/// </java-name>
				[Dot42.DexImport("tests", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljunit/framework/Test;>;")]
				public virtual global::Java.Util.IEnumeration<global::Junit.Framework.ITest> Tests() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Junit.Framework.ITest>);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of the suite. Not all test suites have a name and this method can return null. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetName(value); }
				}

		}

}


