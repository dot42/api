// Copyright (C) 2014 dot42
//
// Original filename: DictionaryEntry.cs
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

namespace System.Collections
{
    // Summary:
    //     Defines a dictionary key/value pair that can be set or retrieved.
    [Serializable]
    [ComVisible(true)]
    public struct DictionaryEntry
    {
        //
        // Summary:
        //     Initializes an instance of the System.Collections.DictionaryEntry type with
        //     the specified key and value.
        //
        // Parameters:
        //   key:
        //     The object defined in each key/value pair.
        //
        //   value:
        //     The definition associated with key.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     key is null and the .NET Framework version is 1.0 or 1.1.
        public DictionaryEntry(object key, object value)
            :this()
        {
            Key = key;
            Value = value;
        }

        // Summary:
        //     Gets or sets the key in the key/value pair.
        //
        // Returns:
        //     The key in the key/value pair.
        public object Key { get; set; }
        //
        // Summary:
        //     Gets or sets the value in the key/value pair.
        //
        // Returns:
        //     The value in the key/value pair.
        public object Value { get; set; }
    }
}
