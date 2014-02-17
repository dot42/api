// Copyright (C) 2014 dot42
//
// Original filename: FileSystemInfo.cs
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

namespace System.IO
{
    /// <summary>
    /// The base class for both FileInfo and DirectoryInfo
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public abstract class FileSystemInfo : MarshalByRefObject
    {
        private readonly string originalPath;

        protected FileSystemInfo()
        {}

        internal FileSystemInfo(string originalPath)
        {
            this.originalPath = originalPath;
        }
  
        /// <summary>
        /// The path originally specified by the user, whether relative or absolute.
        /// </summary>
        protected string OriginalPath
        {
            get { return originalPath; }
        }

        /// <summary>
        /// Retrieves the full name (absolute).
        /// </summary>
        public virtual string FullName
        {
            get { return Path.GetFullPath(originalPath); }
        }
    }
}
