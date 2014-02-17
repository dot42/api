// Copyright (C) 2014 dot42
//
// Original filename: IDictionaryEnumerator.cs
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
    //     Enumerates the elements of a nongeneric dictionary.
    [ComVisible(true)]
    public interface IDictionaryEnumerator : IEnumerator
    {
        // Summary:
        //     Gets both the key and the value of the current dictionary entry.
        //
        // Returns:
        //     A System.Collections.DictionaryEntry containing both the key and the value
        //     of the current dictionary entry.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.Collections.IDictionaryEnumerator is positioned before the first
        //     entry of the dictionary or after the last entry.
        DictionaryEntry Entry { get; }
        //
        // Summary:
        //     Gets the key of the current dictionary entry.
        //
        // Returns:
        //     The key of the current element of the enumeration.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.Collections.IDictionaryEnumerator is positioned before the first
        //     entry of the dictionary or after the last entry.
        object Key { get; }
        //
        // Summary:
        //     Gets the value of the current dictionary entry.
        //
        // Returns:
        //     The value of the current element of the enumeration.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.Collections.IDictionaryEnumerator is positioned before the first
        //     entry of the dictionary or after the last entry.
        object Value { get; }
    }
}
