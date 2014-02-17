// Copyright (C) 2014 dot42
//
// Original filename: StructLayoutAttribute.cs
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

namespace System.Runtime.InteropServices
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    [Ignore]
    public sealed class StructLayoutAttribute : Attribute
    {
        private readonly LayoutKind kind;
        public int Pack;
        public int Size;

        public StructLayoutAttribute(LayoutKind kind)
        {
            this.kind = kind;
        }

        public StructLayoutAttribute(short kind)
        {
            this.kind = (LayoutKind) kind;
        }

        public LayoutKind Value { get { return kind; } }
    }
}

