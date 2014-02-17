// Copyright (C) 2014 dot42
//
// Original filename: GeneratedCodeAttribute.cs
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

namespace System.CodeDom.Compiler
{
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    [Ignore]
	public sealed class GeneratedCodeAttribute : Attribute
	{
        private readonly string tool;
        private readonly string version;

        public GeneratedCodeAttribute(string tool, string version)
        {
            this.tool = tool;
            this.version = version;
        }

        public string Tool
        {
            get { return tool; }
        }

        public string Version
        {
            get { return version; }
        }
	}
}

