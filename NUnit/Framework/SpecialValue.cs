// Copyright (C) 2014 dot42
//
// Original filename: SpecialValue.cs
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
// ****************************************************************
// Copyright 2009, Charlie Poole
// This is free software licensed under the NUnit license. You may
// obtain a copy of the license at http://nunit.org
// ****************************************************************

using System;

namespace NUnit.Framework
{
    /// <summary>
    /// The SpecialValue enum is used to represent TestCase arguments
    /// that cannot be used as arguments to an Attribute.
    /// </summary>
	public enum SpecialValue
	{
        /// <summary>
        /// Null represents a null value, which cannot be used as an 
        /// argument to an attriute under .NET 1.x
        /// </summary>
        Null
	}
}

