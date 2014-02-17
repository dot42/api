// Copyright (C) 2014 dot42
//
// Original filename: Path.cs
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
using System.Text;
using Dot42;
using JFile = Java.Io.File;

namespace System.IO
{
	public static class Path
	{
        /// <summary>
        /// Separator character used to separate path strings in environment variables.
        /// </summary>
	    [DexImport("java/io/File", "pathSeparatorChar", "C")]
        public static readonly char PathSeparator;

        /// <summary>
        /// Separator character used to separate directory levels in a full path.
        /// </summary>
        [DexImport("java/io/File", "separatorChar", "C")]
        public static readonly char DirectorySeparatorChar;

        /// <summary>
        /// Provides a platform-specific volume separator character.
        /// </summary>
	    public const char VolumeSeparatorChar = '/';

        /// <summary>
        ///  Gets all characters that are not allowed in a path name.
        /// </summary>
	    [ObsoleteAttribute("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")] 
        public static readonly char[] InvalidPathChars = GetInvalidPathChars();

        /// <summary>
        /// Change the extension of the given path.
        /// </summary>
        public static string ChangeExtension(string path, string extension)
        {
            if (string.IsNullOrEmpty(path))
                return path;
            var index = GetExtensionIndex(path);
            if (extension == null)
            {
                // Remove extension
                return (index < 0) ? path : path.JavaSubstring(0, index);
            }
            // Replace extension
            var stripped = (index < 0) ? path + '.' : path.JavaSubstring(0, index + 1);
            if (extension.Length == 0)
                return stripped;
            if (extension[0] == '.')
                extension = extension.JavaSubstring(1);
            return stripped + extension;
        }

        /// <summary>
        /// Combine the given elements into a path.
        /// </summary>
        public static string Combine(string part1, string part2)
        {
            if (part1 == null)
                throw new ArgumentNullException("part1");
            if (part2 == null)
                throw new ArgumentNullException("part2");
            if (part1.Length == 0)
                return part2;
            if (part2.Length == 0)
                return part1;
            return new JFile(part1, part2).GetPath();
        }

        /// <summary>
        /// Gets the parent of the specified path.
        /// </summary>
        public static string GetDirectoryName(string path)
        {
            return new JFile(path).GetParent();
        }

        /// <summary>
        /// Gets the enxtesion of the given path.
        /// </summary>
        /// <returns>The extension of the given path including the period. If path is null, null is returned. If path does not have an extension, an empty string is returned.</returns>
        public static string GetExtension(string path)
        {
            if (path == null)
                return null;
            var index = GetExtensionIndex(path);
            return (index >= 0) ? path.JavaSubstring(index) : string.Empty;
        }

        /// <summary>
        /// Find the index of the start of the extension ('.') in the given path.
        /// </summary>
        private static int GetExtensionIndex(string path)
        {
            if (path == null)
                return -1;
            var index = path.Length - 1;
            while (index >= 0)
            {
                var ch = path[index];
                if (ch == '.')
                    return index;
                if (ch == DirectorySeparatorChar)
                    return -1;
                index--;
            }
            return -1;
        }

        /// <summary>
        /// Gets the file name and extension part of the specified path.
        /// </summary>
        public static string GetFileName(string path)
        {
            return new JFile(path).GetName();
        }

        /// <summary>
        /// Gets the file name part (without extension) of the specified path.
        /// </summary>
        public static string GetFileNameWithoutExtension(string path)
        {
            var name = new JFile(path).GetName();
            var index = GetExtensionIndex(name);
            return (index >= 0) ? name.JavaSubstring(0, index) : name;
        }

        /// <summary>
        /// Gets the absolute path for the given path.
        /// </summary>
        public static string GetFullPath(string path)
        {
            return new JFile(path).GetAbsolutePath();            
        }

        /// <summary>
        /// Gets all characters that are not allowed in a file name.
        /// </summary>
        public static char[] GetInvalidFileNameChars()
        {
            return new[] { '\0', '/' };
        }

        /// <summary>
        /// Gets all characters that are not allowed in a path name.
        /// </summary>
        public static char[] GetInvalidPathChars()
        {
            return new[] { '\0' };
        }

        /// <summary>
        /// Gets the root directory of the specified path.
        /// </summary>
        public static string GetPathRoot(string path)
        {
            if (path == null)
                return null;
            return string.Empty;
        }

        /// <summary>
        /// Gets a random directory of file name.
        /// </summary>
        public static string GetRandomFileName()
        {
            const int length = 11;
            var rnd = new Random();
            var bytes = new byte[length];
            rnd.NextBytes(bytes);
            var sb = new StringBuilder(length + 1);
            for (var i = 0; i < length; i++)
            {
                if (i == 8)
                    sb.Append('.');
                var x = bytes[i] % 36;
                char c = (char)(x < 26 ? (x + 'a') : (x - 26 + '0'));
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a unique named zero-byte length temporary file on disk and returns it's path.
        /// </summary>
        public static string GetTempFileName()
        {
            var rndName = GetRandomFileName();
            var index = rndName.IndexOf('.');
            return JFile.CreateTempFile(rndName.JavaSubstring(0, index), rndName.JavaSubstring(index)).GetAbsolutePath();
        }

        /// <summary>
        /// Returns the path of the current users temporary folder.
        /// </summary>
        public static string GetTempPath()
        {
            return Java.Lang.System.GetProperty("java.io.tmpdir");
        }

        /// <summary>
        /// Does the given path have an extension?
        /// </summary>
        public static bool HasExtension(string path)
        {
            return (GetExtensionIndex(path) >= 0);
        }

        /// <summary>
        /// Does the given path contain a filesystem root?
        /// </summary>
        public static bool IsPathRooted(string path)
        {
            if ((path == null) || (path.Length == 0))
                return false;
            return (path[0] == DirectorySeparatorChar);
        }
    }
}

