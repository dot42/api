// Copyright (C) 2014 dot42
//
// Original filename: RequestCachePolicy.cs
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
    /// Defines an application's caching requirements for resources obtained by using System.Net.WebRequest objects.
    /// </summary>
    public class RequestCachePolicy
    {
        private readonly RequestCacheLevel _level;

        /// <summary>
        ///  Creates a new instance of the System.Net.Cache.RequestCachePolicy class.
        /// </summary>
        public RequestCachePolicy()
        {
            _level = RequestCacheLevel.Default;
        }

        /// <summary>
        /// Creates a new instance of the System.Net.Cache.RequestCachePolicy class using the specified cache policy.
        /// </summary>
        /// <param name="level">The requested cache level</param>
        public RequestCachePolicy(RequestCacheLevel level)
        {
            _level = level;
        }

        /// <summary>
        /// Get the RequestCacheLevel provided in the constuctor.
        /// </summary>
        public RequestCacheLevel Level { get { return _level; } }

        /// <summary>
        /// Returns a string representation of this instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _level.ToString();
        }
    }
}

