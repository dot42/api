// Copyright (C) 2014 dot42
//
// Original filename: FreeAppsKeyAttribute.cs
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

namespace Dot42
{
    /// <summary>
    /// Use this attribute to specify your Free Apps Key.
    /// With such a key you can build Free apps that can be published in an apps market.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    [Ignore]
    public sealed class FreeAppsKeyAttribute : Attribute
    {
		public FreeAppsKeyAttribute(string key) { }
    }
}

