// Copyright (C) 2014 dot42
//
// Original filename: IndexerNameAttribute.cs
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
using System.Runtime.InteropServices;
using Dot42;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Indicates the name by which an indexer is known in programming languages that do not support indexers directly.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    [Ignore]
    public sealed class IndexerNameAttribute : Attribute
    {
        public IndexerNameAttribute(string indexerName) {}
    }
}
