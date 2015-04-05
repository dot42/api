// Copyright (C) 2014 dot42
//
// Original filename: AggregateException.cs
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace System
{
    public class AggregateException : Exception
    {
        private ReadOnlyCollection<Exception> innerExceptions;

        /// <summary>
        /// Default ctor
        /// </summary>
        public AggregateException()
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public AggregateException(IEnumerable<Exception> innerExceptions)
        {
            if (innerExceptions == null)
                throw new ArgumentNullException("innerExceptions");

            var list = new List<Exception>(innerExceptions);
            this.innerExceptions = new ReadOnlyCollection<Exception>(list);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public AggregateException(params Exception[] innerExceptions)
        {
            if (innerExceptions == null)
                throw new ArgumentNullException("innerExceptions");

            this.innerExceptions = new ReadOnlyCollection<Exception>(innerExceptions);
        }

        /// <summary>
        /// Gets a read-only collection of the Exception instances that caused the current exception.
        /// </summary>
        public ReadOnlyCollection<Exception> InnerExceptions { get { return innerExceptions; } }

        public override string Message
        {
            get
            {
                if (innerExceptions.Count == 1)
                {
                    foreach (Exception innerException in InnerExceptions)
                    {
                        return innerException.Message;
                    }
                }

                var builder = new StringBuilder("AggregateExceptions: ");
                foreach (Exception innerException in InnerExceptions)
                {
                    builder.Append("[");
                    builder.Append(innerException.Message);
                    builder.Append("]");
                }

                return builder.ToString();
            }
        }

        public override Exception InnerException
        {
            get
            {
                if (innerExceptions.Count > 0)
                    return innerExceptions[0];
                return base.InnerException;
            }
        }
    }
}

