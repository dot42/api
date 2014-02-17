// Copyright (C) 2014 dot42
//
// Original filename: XObjectChangeEventArgs.cs
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
	public class XObjectChangeEventArgs : EventArgs
	{
	    private readonly XObjectChange change;

        public static readonly XObjectChangeEventArgs Add = new XObjectChangeEventArgs(XObjectChange.Add);
        public static readonly XObjectChangeEventArgs Remove = new XObjectChangeEventArgs(XObjectChange.Remove);
        public static readonly XObjectChangeEventArgs Name = new XObjectChangeEventArgs(XObjectChange.Name);
        public static readonly XObjectChangeEventArgs Value = new XObjectChangeEventArgs(XObjectChange.Value);

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="change">Type of change</param>
	    public XObjectChangeEventArgs(XObjectChange change)
	    {
	        this.change = change;
	    }

        /// <summary>
        /// The type of change.
        /// </summary>
	    public XObjectChange ObjectChange
	    {
	        get { return change; }
	    }
	}
}

