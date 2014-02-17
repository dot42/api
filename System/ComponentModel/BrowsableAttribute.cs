// Copyright (C) 2014 dot42
//
// Original filename: BrowsableAttribute.cs
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
namespace System.ComponentModel
{
    /// <summary>
    /// Should a property be displayed in a properties grid?
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute
	{
        private readonly bool browsable;

        /// <summary>
        /// Default ctor
        /// </summary>
        public BrowsableAttribute(bool browsable)
        {
            this.browsable = browsable;
        }

        /// <summary>
        /// Is the object browsable?
        /// </summary>
        public bool Browsable
        {
            get { return browsable; }
        }
	}
}

