// Copyright (C) 2014 dot42
//
// Original filename: OperationCanceledException.cs
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
using System.Threading;
using Dot42;

namespace System
{
    public class OperationCanceledException : SystemException
    {
        private CancellationToken cancellationToken;

        public OperationCanceledException ()
        {
        }

        public OperationCanceledException(string message)
            : base(message)
        {            
        }

        public OperationCanceledException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public OperationCanceledException(CancellationToken token)
        {
            cancellationToken = token;
        }

        public OperationCanceledException(string message, CancellationToken token)
            : base(message)
        {
            cancellationToken = token;
        }

        public OperationCanceledException(string message, Exception inner, CancellationToken token)
            : base(message, inner)
        {
            cancellationToken = token;
        }

        /// <summary>
        /// Gets a token associated with the operation that was canceled.
        /// </summary>
        public CancellationToken CancellationToken 
        {
            get { return cancellationToken; }
        }
	}
}

