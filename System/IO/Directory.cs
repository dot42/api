// Copyright (C) 2014 dot42
//
// Original filename: Directory.cs
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
using JFile = Java.Io.File;

namespace System.IO
{
	public static class Directory
	{
        /// <summary>
        /// Delete the directory with the given path.
        /// </summary>
        public static void Delete(string path)
        {
            var file = new JFile(path);
            if (file.IsDirectory)
                file.Delete();
        }

        /// <summary>
        /// Delete the directory with the given path.
        /// </summary>
        public static void Delete(string path, bool recursive)
        {
            var file = new JFile(path);
            if (file.IsDirectory)
            {
                if (recursive)
                {
                    var children = file.List();
                    foreach (var child in children)
                    {
                        var childFile = new JFile(child);
                        if (childFile.IsFile) childFile.Delete();
                        if (childFile.IsDirectory) Delete(child, recursive);
                    }
                }
                file.Delete();
            }
        }

        /// <summary>
        /// Does a directory with given path exist on the filesystem?
        /// </summary>
        public static bool Exists(string path)
        {
            var file = new JFile(path);
            return file.IsDirectory && file.Exists();
        }

        public static /*DirectoryInfo*/ void CreateDirectory(string path)
        {
            var file = new JFile(path);
            var isCreated = file.Mkdirs();
        }
	}
}

