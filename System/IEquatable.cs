// Copyright (C) 2014 dot42
//
// Original filename: IEquatable.cs
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
    /// <summary>
    /// Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.
    /// </summary>
    public interface IEquatable<T>
    {
        bool Equals(T other);
    }
}

