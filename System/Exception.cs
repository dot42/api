// Copyright (C) 2014 dot42
//
// Original filename: Exception.cs
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
using Java.Io;

namespace System
{
	public partial class Exception
	{
        /// <summary>
        /// The message for this exception.
        /// </summary>
        public virtual string Message 
        { 
            [Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)] 
            get { return default(string); }
        }

        /// <summary>
        /// Gets a string representation of the immediate frames on the call stack.
        /// </summary>
        public string StackTrace 
        { 
            get
            {
                var sw = new StringWriter();
                var pw = new PrintWriter(sw);
                PrintStackTrace(pw);
                return sw.ToString(); 
            }
        }

        public virtual Exception InnerException
        {
            [Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
            get { return Cause; }
        }

	}
}

