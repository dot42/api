// Copyright (C) 2014 dot42
//
// Original filename: RequestCacheLevel.cs
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
namespace System.Net.Cache
{
    /// <summary>
    /// Specifies caching behavior for resources obtained using System.Net.WebRequest and its derived classes.
    /// </summary>
    public enum RequestCacheLevel
    {
        // Summary:
        //     Satisfies a request for a resource either by using the cached copy of the
        //     resource or by sending a request for the resource to the server. The action
        //     taken is determined by the current cache policy and the age of the content
        //     in the cache. This is the cache level that should be used by most applications.
        Default = 0,
        //
        // Summary:
        //     Satisfies a request by using the server. No entries are taken from caches,
        //     added to caches, or removed from caches between the client and server. This
        //     is the default cache behavior specified in the machine configuration file
        //     that ships with the .NET Framework.
        BypassCache = 1,
        //
        // Summary:
        //     Satisfies a request using the locally cached resource; does not send a request
        //     for an item that is not in the cache. When this cache policy level is specified,
        //     a System.Net.WebException exception is thrown if the item is not in the client
        //     cache.
        CacheOnly = 2,
        //
        // Summary:
        //     Satisfies a request for a resource from the cache, if the resource is available;
        //     otherwise, sends a request for a resource to the server. If the requested
        //     item is available in any cache between the client and the server, the request
        //     might be satisfied by the intermediate cache.
        CacheIfAvailable = 3,
        //
        // Summary:
        //     Satisfies a request by using the cached copy of the resource if the timestamp
        //     is the same as the timestamp of the resource on the server; otherwise, the
        //     resource is downloaded from the server, presented to the caller, and stored
        //     in the cache.
        Revalidate = 4,
        //
        // Summary:
        //     Satisfies a request by using the server. The response might be saved in the
        //     cache. In the HTTP caching protocol, this is achieved using the no-cache
        //     cache control directive and the no-cache Pragma header.
        Reload = 5,
        //
        // Summary:
        //     Never satisfies a request by using resources from the cache and does not
        //     cache resources. If the resource is present in the local cache, it is removed.
        //     This policy level indicates to intermediate caches that they should remove
        //     the resource. In the HTTP caching protocol, this is achieved using the no-cache
        //     cache control directive.
        NoCacheNoStore = 6,
    }
}
