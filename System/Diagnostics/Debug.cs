// Copyright (C) 2014 dot42
//
// Original filename: Debug.cs
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
using Android.Util;
using Dot42;
using Dot42.Internal;

namespace System.Diagnostics
{
    /// <summary>
    /// Debug helpers
    /// </summary>
	public static class Debug
	{
	    private const string Tag = @"dot42";
        private const string Null = @"null";

        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Write(object value)
        {
            value = value ?? Null;
            Log.D(Tag, value.ToString());
        }
#if false
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Write(object value, string category)
        {
            value = value ?? Null;
            Log.D(category, value.ToString());
        }
#endif
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Write(string message)
        {
            Log.D(Tag, message);
        }
#if false
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Write(string message, string category)
        {
            Log.D(category, message);
        }
#endif
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void WriteLine(object value)
        {
            value = value ?? Null;
            Log.D(Tag, value.ToString());
        }
#if false
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void WriteLine(object value, string category)
        {
            value = value ?? Null;
            Log.D(category, value.ToString());
        }
#endif
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void WriteLine(string message)
        {
            Log.D(Tag, message);
        }
#if false
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void WriteLine(string message, string category)
        {
            Log.D(category, message);
        }
#endif
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void WriteLine(string format, params object[] args)
        {
            Log.D(Tag, string.Format(format, args));
        }

        /// <summary>
        /// Checks for a condition; if the condition is false, throw an exception
        /// </summary>
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Assert(bool condition)
        {
            if (!condition) throw new AssertFailedException();
        }

        /// <summary>
        /// Checks for a condition; if the condition is false, throw an exception
        /// </summary>
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Assert(bool condition, string message)
        {
            if (!condition) throw new AssertFailedException(message);
        }

        /// <summary>
        /// Checks for a condition; if the condition is false, throw an exception
        /// </summary>
        [ConditionalAttribute("DEBUG")]
        [Inline]
        public static void Assert(bool condition, string message, string detailedMessage)
        {
            if (!condition) throw new AssertFailedException(message, detailedMessage);
        }
    }
}

