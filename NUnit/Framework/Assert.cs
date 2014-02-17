// Copyright (C) 2014 dot42
//
// Original filename: Assert.cs
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

namespace NUnit.Framework
{
	public class Assert : Junit.Framework.Assert
    {
#region IsTrue/False
        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsTrue(bool condition, string message, params object[] args)
        {
            if (!condition)
            {                
                Fail(string.Format(message, args));
            }
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsTrue(bool condition, string message)
        {
            if (!condition)
            {
                Fail(message);
            }
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        public static void IsTrue(bool condition)
        {
            if (!condition)
            {
                Fail();
            }
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsFalse(bool condition, string message, params object[] args)
        {
            if (condition)
            {
                Fail(string.Format(message, args));
            }
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsFalse(bool condition, string message)
        {
            if (condition)
            {
                Fail(message);
            }
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="AssertionException"/>.
        /// </summary>
        public static void IsFalse(bool condition)
        {
            if (condition)
            {
                Fail();
            }
        }
        #endregion

#region IsNull/IsNotNull 
        public static void IsNull(object anObject)
        {
            AssertNull(anObject);
        }

        public static void IsNull(object anObject, string message)
        {
            AssertNull(message, anObject);
        }

        public static void IsNull(object anObject, string message, object[] parms)
        {
            AssertNull(string.Format(message, parms), anObject);
        }

        public static void Null(object anObject)
        {
            AssertNull(anObject);
        }

        public static void Null(object anObject, string message)
        {
            AssertNull(message, anObject);
        }

        public static void Null(object anObject, string message, object[] parms)
        {
            AssertNull(string.Format(message, parms), anObject);
        }

        public static void IsNotNull(object anObject)
        {
            AssertNotNull(anObject);
        }

        public static void IsNotNull(object anObject, string message)
        {
            AssertNotNull(message, anObject);
        }

        public static void IsNotNull(object anObject, string message, object[] parms)
        {
            AssertNotNull(string.Format(message, parms), anObject);
        }

        public static void NotNull(object anObject)
        {
            AssertNotNull(anObject);
        }

        public static void NotNull(object anObject, string message)
        {
            AssertNotNull(message, anObject);
        }

        public static void NotNull(object anObject, string message, object[] parms)
        {
            AssertNotNull(string.Format(message, parms), anObject);
        }

        #endregion

#region AreEqual/AreNotEqual

        public static void AreEqual(int expected, int actual)
        {
            AssertEquals(expected, actual);
        }

        public static void AreEqual(int expected, int actual, string message)
        {
            AssertEquals(message, expected, actual);
        }

        public static void AreEqual(int expected, int actual, string message, params object[] parms)
        {
            AssertEquals(string.Format(message, parms), expected, actual);
        }


	    public static void AreEqual(uint expected, uint actual)
	    {
	        AssertEquals(expected, actual);
	    }

	    public static void AreEqual(uint expected, uint actual, string message)
	    {
	        AssertEquals(message, expected, actual);
	    }

	    public static void AreEqual(uint expected, uint actual, string message, params object[] parms)
	    {
	        AssertEquals(string.Format(message, parms), expected, actual);
	    }

        public static void AreEqual(long expected, long actual)
        {
            AssertEquals(expected, actual);
        }

        public static void AreEqual(long expected, long actual, string message)
        {
            AssertEquals(message, expected, actual);
        }

        public static void AreEqual(long expected, long actual, string message, params object[] parms)
        {
            AssertEquals(string.Format(message, parms), expected, actual);
        }

        public static void AreEqual(ulong expected, ulong actual)
        {
            AssertEquals(expected, actual);
        }

        public static void AreEqual(ulong expected, ulong actual, string message)
        {
            AssertEquals(message, expected, actual);
        }

        public static void AreEqual(ulong expected, ulong actual, string message, params object[] parms)
        {
            AssertEquals(string.Format(message, parms), expected, actual);
        }

        public static void AreEqual(decimal expected, decimal actual)
	    {
	        AssertEquals(expected, actual);
	    }

        public static void AreEqual(decimal expected, decimal actual, string message)
        {
            AssertEquals(message, expected, actual);
        }

	    public static void AreEqual(decimal expected, decimal actual, string message, params object[] parms)
	    {
	        AssertEquals(string.Format(message, parms), expected, actual);
	    }

	    public static void AreEqual(float expected, float actual, float tolerance)
	    {
	        AssertEquals(expected, actual, tolerance);
	    }

	    public static void AreEqual(float expected, float actual, float tolerance, string message)
	    {
	        AssertEquals(message, expected, actual, tolerance);
	    }

	    public static void AreEqual(float expected, float actual, float tolerance, string message, params object[] parms)
	    {
	        AssertEquals(string.Format(message, parms), expected, actual, tolerance);
	    }

        public static void AreEqual(double expected, double actual, double tolerance)
        {
            AssertEquals(expected, actual, tolerance);
        }

	    public static void AreEqual(double expected, double actual, double tolerance, string message)
	    {
	        AssertEquals(message, expected, actual, tolerance);
	    }

	    public static void AreEqual(double expected, double actual, double tolerance, string message, params object[] parms)
	    {
	        AssertEquals(string.Format(message, parms), expected, actual, tolerance);
	    }

	    public static void AreEqual(object expected, object actual)
	    {
            AreEqual(expected, actual, string.Empty);
	    }

	    public static void AreEqual(object expected, object actual, string message)
	    {
            var expectedArray = expected as Array;
            var actualArray = actual as Array;

            if (expectedArray == null || actualArray == null)
            {
                AssertEquals(message, expected, actual);
            }
            else
            {
                //both are an array.
                AssertEquals(message + " [incorrect Length]", expectedArray.Length, actualArray.Length);

                for (var i = 0; i < expectedArray.Length; i++)
                {
                    AssertEquals(message + " [element at position '"+ i +"' incorrect]", expectedArray[i], actualArray[i]);
                }
            }
	        
	    }

	    public static void AreEqual(object expected, object actual, string message, params object[] parms)
	    {
            AreEqual(expected, actual, string.Format(message, parms));
	    }

	    public static void AreNotEqual( int expected, int actual )
	    {
	        AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(int expected, int actual, string message)
	    {
	        AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(int expected, int actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(long expected, long actual)
	    {
	        AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(long expected, long actual, string message)
	    {
            AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(long expected, long actual, string message, params object[] parms)
	    {
	        AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(uint expected, uint actual)
	    {
            AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(uint expected, uint actual, string message)
	    {
	        AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(uint expected, uint actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(ulong expected, ulong actual)
	    {
	        AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(ulong expected, ulong actual, string message)
	    {
            AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(ulong expected, ulong actual, string message, params object[] parms)
	    {
	        AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(decimal expected, decimal actual)
	    {
            AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(decimal expected, decimal actual, string message)
	    {
	        AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(decimal expected, decimal actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(float expected, float actual)
	    {
	        AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(float expected, float actual, string message)
	    {
            AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(float expected, float actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(double expected, double actual)
	    {
            AssertFalse(expected == actual);
	    }

	    public static void AreNotEqual(double expected, double actual, string message)
	    {
	        AssertFalse(message, expected == actual);
	    }

	    public static void AreNotEqual(double expected, double actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), expected == actual);
	    }

	    public static void AreNotEqual(object expected, object actual)
	    {
            AssertFalse(Equals(expected, actual));
	    }

	    public static void AreNotEqual(object expected, object actual, string message)
	    {
            AssertFalse(message, Equals(expected, actual));	        
	    }

	    public static void AreNotEqual(object expected, object actual, string message, params object[] parms)
	    {
            AssertFalse(string.Format(message, parms), Equals(expected, actual));
	    }

	    #endregion

#region AreSame/AreNotSame
        public static void AreSame(object expected, object actual)
        {
            AssertSame(expected, actual);
        }

	    public static void AreSame(object expected, object actual, string message)
	    {
	        AssertSame(message, expected, actual);
	    }

	    public static void AreSame(object expected, object actual, string message, params object[] parms)
	    {
            AssertSame(string.Format(message, parms), expected, actual);	        
	    }

	    public static void AreNotSame(object expected, object actual)
	    {
            AssertNotSame(expected, actual);	        
	    }

	    public static void AreNotSame(object expected, object actual, string message)
	    {
            AssertNotSame(message, expected, actual);	        
	    }

	    public static void AreNotSame(object expected, object actual, string message, params object[] parms)
	    {
	        AssertNotSame(string.Format(message, parms), expected, actual);
	    }

	    #endregion

    }
}

