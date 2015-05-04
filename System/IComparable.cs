// Copyright (C) 2014 dot42
//
// Original filename: IComparable.cs
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

namespace System
{
    /// <summary>
    /// Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
    /// </summary>
    [ComVisible(true)]
    [Dot42.DexImport("java/lang/Comparable", IgnoreFromJava = true, Priority = 1)]
    public interface IComparable
    {
        [Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I")]
        int CompareTo(object obj);
    }
}

