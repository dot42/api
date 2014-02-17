// Copyright (C) 2014 dot42
//
// Original filename: XObjectChange.cs
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
namespace System.Xml.Linq
{
	public enum XObjectChange
	{
        /// <summary>
        /// An object has been or will be added to a container.
        /// </summary>
        Add,

        /// <summary>
        /// An object has been or will be removed from a container.
        /// </summary>
        Remove,

        /// <summary>
        /// An object has been or will be renamed.
        /// </summary>
        Name,

        /// <summary>
        /// The value of an object has been or will be changed.
        /// </summary>
        Value
	}
}

