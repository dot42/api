// Copyright (C) 2014 dot42
//
// Original filename: System.Collections.cs
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
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: Dot42.FrameworkLibrary]
[assembly: AssemblyFlags(AssemblyNameFlags.Retargetable)]

[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Comparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.Dictionary<,>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.EqualityComparer<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.HashSet<>))]
[assembly: TypeForwardedTo(typeof(System.Collections.Generic.List<>))]

