// Copyright (C) 2014 dot42
//
// Original filename: OperationContextScope.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.ServiceModel
{
    /// <summary>
    /// Creates a block within which an IContextChannel  object is in scope.
    /// </summary>
    public sealed class OperationContextScope : IDisposable
    {
        private OperationContext previous;

        /// <summary>
        /// Initializes a new instance of the OperationContextScope
        /// </summary>
        public OperationContextScope(IContextChannel channel)
            : this (new OperationContext (channel, false))
        {
           
        }
       
        /// <summary>
        /// Initializes a new instance of the OperationContextScope
        /// </summary>
        public OperationContextScope(OperationContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            previous = OperationContext.Current;
            OperationContext.Current = context;
        }

        /// <summary>
        /// Restores the original OperationContext to the active context
        /// </summary>
        public void Dispose()
        {
            OperationContext.Current = previous;
        }
    }
}

