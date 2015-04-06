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
using System.Collections.Generic;
using Java.Io;
using Java.Lang;
using Java.Util;
using JFile = Java.Io.File;
using JSystem = Java.Lang.System;

namespace System.IO
{
	public static class File
	{
        /// <summary>
        /// Delete the file with the given path.
        /// </summary>
        public static void Delete(string path)
        {
            var file = new JFile(path);
            if (file.IsFile)
                file.Delete();
        }

        /// <summary>
        /// Does a file with given path exist on the filesystem?
        /// </summary>
        public static bool Exists(string path)
        {
            var file = new JFile(path);
            return file.IsFile && file.Exists();
        }

        /// <summary>
        /// Read a file with given path and return a byte-array with it's entire contents.
        /// </summary>
        public static byte[] ReadAllBytes(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            var file = new JFile(path);
            if (!file.Exists() || !file.IsFile)
                throw new FileNotFoundException(path);
            if (!file.CanRead)
                throw new UnauthorizedAccessException(path);
            var stream = new FileInputStream(file);
            try
            {
                var array = new byte[file.Length()];
                stream.Read(array, 0, array.Length);
                return array;
            }
            finally
            {
                stream.Close();
            }
        }

        /// <summary>
        /// Read a file with given path and return a string array with it's entire contents.
        /// </summary>
        public static string[] ReadAllLines(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            var file = new JFile(path);
            if (!file.Exists() || !file.IsFile)
                throw new FileNotFoundException(path);
            if (!file.CanRead)
                throw new UnauthorizedAccessException(path);
            var reader = new BufferedReader(new FileReader(file));
            try
            {
                var list = new ArrayList<string>();
                string line;
                 while ((line = reader.ReadLine()) != null)
                 {
                     list.Add(line);
                 }
                return list.ToArray(new string[list.Count]);
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Read a file with given path and return a string with it's entire contents.
        /// </summary>
        public static string ReadAllText(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            var file = new JFile(path);
            if (!file.Exists() || !file.IsFile)
                throw new FileNotFoundException(path);
            if (!file.CanRead)
                throw new UnauthorizedAccessException(path);
            var reader = new FileReader(file);
            try
            {
                var array = new char[4096];
                var buffer = new StringBuffer();
                int len;
                while ((len = reader.Read(array, 0, array.Length)) > 0)
                {
                    buffer.Append(array, 0, len);
                }
                return buffer.ToString();
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Write all given bytes to a file with given path.
        /// </summary>
        public static void WriteAllBytes(string path, byte[] bytes)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            var file = new JFile(path);
            var stream = new FileOutputStream(file);
            try
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                stream.Close();
            }
        }

        /// <summary>
        /// Write all lines to a file with given path.
        /// </summary>
        public static void WriteAllLines(string path, string[] lines)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            if (lines == null)
                throw new ArgumentNullException("lines");
            var file = new JFile(path);
            var writer = new FileWriter(file);
            try
            {
                var nl = JSystem.GetProperty("line.separator");
                foreach (var line in lines)
                {
                    if (line != null)
                        writer.Write(line, 0, line.Length);
                    writer.Write(nl, 0, nl.Length);
                }
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Write all lines to a file with given path.
        /// </summary>
        public static void WriteAllLines(string path, IEnumerable<string> lines)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            if (lines == null)
                throw new ArgumentNullException("lines");
            var file = new JFile(path);
            var writer = new FileWriter(file);
            try
            {
                var nl = JSystem.GetProperty("line.separator");
                foreach (var line in lines)
                {
                    if (line != null)
                        writer.Write(line, 0, line.Length);
                    writer.Write(nl, 0, nl.Length);
                }
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Write all given text to a file with given path.
        /// </summary>
        public static void WriteAllText(string path, string text)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            if (text == null)
                throw new ArgumentNullException("text");
            var file = new JFile(path);
            var writer = new FileWriter(file);
            try
            {
                writer.Write(text, 0, text.Length);
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Opens a FileStream on the specified path with read/write access.
        /// </summary>
        public static FileStream Open(string path, FileMode mode)
        {
            return Open(path, mode, FileAccess.ReadWrite);
        }

        /// <summary>
        /// Opens a FileStream on the specified path.
        /// </summary>
        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return new FileStream(path, mode, access);
        }

        /// <summary>
        /// Opens a FileStream on the specified path.
        /// </summary>
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return new FileStream(path, mode, access, share);
        }

        /// <summary>
        /// Opens a file for reading.
        /// </summary>
        public static FileStream OpenRead(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.Read);
        }

        /// <summary>
        /// Opens a file for writing.
        /// </summary>
        public static FileStream OpenWrite(string path)
        {
            return new FileStream(path, FileMode.Open, FileAccess.Write);
        }

        /// <summary>
        /// Creates or overwrites a file.
        /// </summary>
        public static FileStream Create(string path)
        {
            return new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
        }
    }
}

