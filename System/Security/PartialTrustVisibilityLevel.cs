// Copyright (C) 2014 dot42
//
// Original filename: PartialTrustVisibilityLevel.cs
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
namespace System.Security
{
    // Summary:
    //     Specifies the default partial-trust visibility for code that is marked with
    //     the System.Security.AllowPartiallyTrustedCallersAttribute (APTCA) attribute.
    public enum PartialTrustVisibilityLevel
    {
        // Summary:
        //     The assembly can always be called by partial-trust code.
        VisibleToAllHosts = 0,
        //
        // Summary:
        //     The assembly has been audited for partial trust, but it is not visible to
        //     partial-trust code in all hosts. To make the assembly visible to partial-trust
        //     code, add it to the System.AppDomainSetup.PartialTrustVisibleAssemblies property.
        NotVisibleByDefault = 1,
    }
}
