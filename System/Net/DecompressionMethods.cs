// Copyright (C) 2014 dot42
//
// Original filename: DecompressionMethods.cs
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
namespace System.Net
{
    /// <summary>
    /// Represents the file compression and decompression encoding format to be used
    /// to compress the data received in response to an System.Net.HttpWebRequest.
    /// </summary>
    [Flags]
    public enum DecompressionMethods
    {

        /// <summary>
        /// Do not use compression.
        /// </summary>
        None = 0,

        /// <summary>
        /// Use the gZip compression-decompression algorithm.
        /// </summary>
        GZip = 1,

        /// <summary>
        /// Use the deflate compression-decompression algorithm.
        /// </summary>
        Deflate = 2,
    }
}

