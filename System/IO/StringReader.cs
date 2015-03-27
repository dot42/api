// Copyright (C) 2014 dot42
//
// Original filename: StringReader.cs
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

namespace System.IO
{
    public class StringReader : TextReader
    {
        private Java.Io.StringReader _reader;

        /// <summary>
        /// Default constructor
        /// </summary>
        public StringReader(string s)
        {
            _reader= new Java.Io.StringReader(s);
        }

        public override int Peek()
        {
            _reader.Mark(1);
            int ret = _reader.Read();
            _reader.Reset();
            return ret;
        }

        public override int Read()
        {
            return _reader.Read();
        }

        public override int Read(char[] buffer, int index, int count)
        {
            var read = _reader.Read(buffer, index, count);
            return read == -1 ? 0 : read;
        }
    }
}

