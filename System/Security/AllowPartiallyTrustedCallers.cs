// Copyright (C) 2014 dot42
//
// Original filename: AllowPartiallyTrustedCallers.cs
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

namespace System.Security
{
    // Summary:
    //     Allows an assembly to be called by partially trusted code. Without this declaration,
    //     only fully trusted callers are able to use the assembly. This class cannot
    //     be inherited.
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    [ComVisible(true)]
    public sealed class AllowPartiallyTrustedCallersAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Security.AllowPartiallyTrustedCallersAttribute
        //     class.
        public AllowPartiallyTrustedCallersAttribute()
        {}

        // Summary:
        //     Gets or sets the default partial trust visibility for code that is marked
        //     with the System.Security.AllowPartiallyTrustedCallersAttribute (APTCA) attribute.
        //
        // Returns:
        //     One of the enumeration values. The default is System.Security.PartialTrustVisibilityLevel.VisibleToAllHosts.
        public PartialTrustVisibilityLevel PartialTrustVisibilityLevel { get; set; }
    }
}

