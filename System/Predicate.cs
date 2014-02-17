// Copyright (C) 2014 dot42
//
// Original filename: Predicate.cs
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
    /// Method representing some criteria and determines if the specified object meet those criteria.
    /// </summary>
    public delegate bool Predicate<in T>(T obj);
}

