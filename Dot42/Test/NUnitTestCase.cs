// Copyright (C) 2014 dot42
//
// Original filename: NUnitTestCase.cs
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
using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Android.Util;
using Java.Lang;
using Java.Lang.Reflect;
using Junit.Framework;
using NUnit.Framework;

namespace Dot42.Test
{
    /// <summary>
    /// TestCase that supports the most commonly used NUnit test attributes.
    /// </summary>
    [Include(TypeCondition = typeof(TestFixtureAttribute))]
    public class NUnitTestCase : TestCase
    {
        private TestSuite suite;
        private MethodInfo method;
        private MethodInfo setupMethod;
        private MethodInfo teardownMethod;
        private object instance;
        private ExpectedExceptionAttribute expectedException;
        private NUnit.Framework.IgnoreAttribute ignore;
        private bool isAsync;

        /// <summary>
        /// Create the test suite.
        /// </summary>
        private TestSuite GetTestSuite(Type type)
        {
            var suite = new TestSuite();
            suite.Name = GetType().GetSimpleName();
            MethodInfo localSetupMethod = null;
            MethodInfo localTeardownMethod = null;
            foreach (var method in type.GetMethods())
            {
                if (GetCustomAttribute<SetUpAttribute>(method) == null)
                    continue;
                localSetupMethod = method;
                break;
            }
            foreach (var method in type.GetMethods())
            {
                if (GetCustomAttribute<TearDownAttribute>(method) == null)
                    continue;
                localTeardownMethod = method;
                break;
            }
            foreach (var method in type.GetMethods())
            {
                if (GetCustomAttribute<TestAttribute>(method) == null)
                    continue;
                var instance = (NUnitTestCase)type.NewInstance();
                instance.SetTestMethod(method, localSetupMethod, localTeardownMethod, this);
                suite.AddTest(instance);
            }
            return suite;
        }

        /// <summary>
        /// Include 1 dummy test to trigger this class to be included.
        /// </summary>
        //[Include]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void test()
        {
        }

        /// <summary>
        /// Prepare the suite.
        /// </summary>
        protected internal sealed override void SetUp()
        {
            if (method == null)
            {
                suite = GetTestSuite(GetType());
                suite.Name = GetType().Name;
            }
            else
            {
                base.SetUp();
                try
                {
                    if (setupMethod != null)
                    {
                        setupMethod.Invoke(instance, null);
                    }
                }
                catch (TargetInvocationException ex)
                {
                    ex.FillInStackTrace();
                    throw ex.TargetException;
                }
            }
        }

        protected internal override void TearDown()
        {
            base.TearDown();
            try
            {
                if (teardownMethod != null)
                {
                    teardownMethod.Invoke(instance, null);
                }
            }
            catch (TargetInvocationException ex)
            {
                ex.FillInStackTrace();
                throw ex.TargetException;
            }
        }

        /// <summary>
        /// Prepare the suite and run the tests.
        /// </summary>
        public override void Run(TestResult result)
        {
            if (method == null)
            {
                SetUp();
                if (suite == null)
                    throw new InvalidOperationException("Suite not created");
                suite.Run(result);
            }
            else 
            {
                if (ignore != null)
                {
                    // Ignore this test
                    //result.
                }
                else
                {
                    base.Run(result);
                }
            }
        }

        /// <summary>
        /// Gets the number of tests.
        /// </summary>
        public sealed override int CountTestCases()
        {
            if (method == null)
            {
                return suite.CountTestCases();
            }
            return base.CountTestCases();
        }

        /// <summary>
        /// Gets the first attribute of type T that is attached to the given method.
        /// </summary>
        /// <returns>Null if there is not such attribute.</returns>
        private static T GetCustomAttribute<T>(MethodInfo method)
        {
            var attr = method.GetCustomAttributes(typeof (T), false);
            if (attr.Length == 0)
                return default(T);
            return (T) attr[0];
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public void SetTestMethod(MethodInfo method, MethodInfo setupMethod, MethodInfo teardownMethod, object instance)
        {
            Name = method.Name;
            this.method = method;
            this.setupMethod = setupMethod;
            this.teardownMethod = teardownMethod;
            this.instance = instance;
            expectedException = GetCustomAttribute<ExpectedExceptionAttribute>(method);
            ignore = GetCustomAttribute<NUnit.Framework.IgnoreAttribute>(method);
            isAsync = GetCustomAttribute<System.Runtime.CompilerServices.AsyncStateMachineAttribute>(method) != null;
        }

        /// <summary>
        /// Override to run the test and assert its state. 
        /// </summary>
        protected internal override void RunTest()
        {
            try
            {
                if (isAsync)
                {
                    if (method.ReturnType == typeof(void)) //-- see case 874
                    //if (method.ReturnType == JavaVoid.TYPE)
                    {
                        RunVoidAsyncMethod();
                    }
                    else
                    {
                        RunTaskAsyncMethod();
                    }
                }
                else
                {
                    RunMethod();
                }

                if (expectedException != null)
                {
                    throw new AssertionFailedError("Expected exception");
                }
            }
            catch (TargetInvocationException ex)
            {
                // Method has thrown an exception.
                ex.FillInStackTrace();
                var exception = ex.TargetException;

                // Is this an expected exception
                if (expectedException != null)
                {
                    if (expectedException.ExpectedException == exception.GetType())
                    {
                        // It is the expected exception
                        return;
                    }
                }

                throw exception;
            }
            catch (IllegalAccessException ex)
            {
                // Cannot invoke the method
                ex.FillInStackTrace();
                throw ex;
            }
        }

        private void RunMethod()
        {
            method.Invoke(instance, null);
            
        }

        private void RunVoidAsyncMethod()
        {
            var previousContext = SynchronizationContext.Current;
            var currentContext = new AsyncSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(currentContext);

            try
            {
                method.Invoke(instance, null);
                currentContext.WaitForPendingOperationsToComplete();
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(previousContext);
            }
        }

        private void RunTaskAsyncMethod()
        {
            object result = method.Invoke(instance, null);
         
            var task = result as Task;
            if (task != null)
            {
                task.Wait();
            }
            else
            {
                throw new InvalidCastException("async result cannot be cast to Task or Task<T>");
            }
        }
    }
}

