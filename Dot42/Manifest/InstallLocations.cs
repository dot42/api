// Copyright (C) 2014 dot42
//
// Original filename: InstallLocations.cs
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
namespace Dot42.Manifest
{
	public enum InstallLocations
	{
        /// <summary>
        /// The application must be installed on internal device storage only.
        /// This is the default value.
        /// </summary>
        InternalOnly = 0,

        /// <summary>
        /// The application can be installed on internal device storage and external device storage.
        /// By default internal device storage is used.
        /// </summary>
        Auto = 1,

        /// <summary>
        /// The application can be installed on internal device storage and external device storage.
        /// By default external device storage is used when that is available.
        /// </summary>
        PreferExternal = 2
	}
}

