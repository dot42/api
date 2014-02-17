// Copyright (C) 2014 dot42
//
// Original filename: Console.cs
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
using System.Diagnostics;
using System.IO;
using Java.Io;
using JSystem = Java.Lang.System;

namespace System
{
	public static partial class Console
	{
	    private static TextWriter error = null;
	    private static TextReader @in = null;
        private static TextWriter @out = null;

        public static void WriteLine()
        {
            WriteLine(string.Empty);
        }

        public static void WriteLine(object obj)
        {
            WriteLine(obj.ToString());
        }

	    public static void WriteLine(string message)
	    {
#if ANDROID_9P
	        var console = JSystem.Console();

	        if (console != null)
	        {
	            console.Format(message + Environment.NewLine);
	        }
	        else
#endif
	        {
	            Debug.WriteLine(message);
	        }
	    }

        /// <summary>
        /// Gets the standard error output stream.
        /// </summary>
	    public static TextWriter Error
	    {
	        get
	        {
                if (error == null)
                {
                    var wrapper = new JavaOutputStreamWrapper(JSystem.Err);
                    error = new StreamWriter(wrapper);
                }

	            return error;
	        }
	    }

        /// <summary>
        /// Gets the standard error input stream.
        /// </summary>
        public static TextReader In
        {
            get
            {
                if (@in == null)
                {
                    var wrapper = new JavaInputStreamWrapper(JSystem.In);
                    @in = new StreamReader(wrapper);
                }

                return @in;
            }
        }

        /// <summary>
        /// Gets the standard output stream.
        /// </summary>
        public static TextWriter Out
        {
            get
            {
                if (@out == null)
                {
                    var wrapper = new JavaOutputStreamWrapper(JSystem.Out);
                    @out = new StreamWriter(wrapper);
                }

                return @out;
            }
        }
	}
}

