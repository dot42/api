// Copyright (C) 2014 dot42
//
// Original filename: Boolean.cs
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
namespace System
{
    partial struct Boolean
    {
        public const string FalseString = "False";
        public const string TrueString = "True";

        public int CompareTo(object obj)
        {
            if (!(obj is bool)) throw new ArgumentException("obj is not a bool");

            return CompareTo((bool) obj);
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Boolean;
        }

        /// <summary>
        /// Parse the given string into a boolean value.
        /// </summary>
        public static bool Parse(string s)
        {
            if (s == null) throw new ArgumentNullException();
            return JavaParse(s.Trim());
        }
    }
}

