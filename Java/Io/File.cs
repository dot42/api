// Copyright (C) 2014 dot42
//
// Original filename: File.cs
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
using Java.Lang;

namespace Java.IO
{
	partial class File
	{
        /// <summary>
        /// Gets the absolute path of the given <see cref="Java.Io.File"/>.
        /// </summary>
        public static implicit operator string(File file)
        {
            if (ReferenceEquals(file, null))
                return null;
            return file.AbsolutePath;
        }
    }
}

