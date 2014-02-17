// Copyright (C) 2014 dot42
//
// Original filename: ReliabilityContractAttribute.cs
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
using Dot42;

namespace System.Runtime.ConstrainedExecution
{
    [AttributeUsage(
        AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor |
        AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
    [Ignore]
    public sealed class ReliabilityContractAttribute : Attribute
    {
        private readonly Consistency consistencyGuarantee;
        private readonly Cer cer;

        public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
        {
            this.consistencyGuarantee = consistencyGuarantee;
            this.cer = cer;
        }

        public Cer Cer
        {
            get { return cer; }
        }

        public Consistency ConsistencyGuarantee
        {
            get { return consistencyGuarantee; }
        }
    }
}

