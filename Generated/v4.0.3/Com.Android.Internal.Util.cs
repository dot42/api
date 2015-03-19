// Copyright (C) 2014 dot42
//
// Original filename: Com.Android.Internal.Util.cs
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
#pragma warning disable 1717
namespace Com.Android.Internal.Util
{
		/// <summary>
		/// <para>A Predicate can determine a true or false value for any input of its parameterized type. For example, a <c> RegexPredicate </c> might implement <c> Predicate&lt;String&gt; </c> , and return true for any String that matches its given regular expression. </para><para>Implementors of Predicate which may cause side effects upon evaluation are strongly encouraged to state this fact clearly in their API documentation. </para>    
		/// </summary>
		/// <java-name>
		/// com/android/internal/util/Predicate
		/// </java-name>
		[Dot42.DexImport("com/android/internal/util/Predicate", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IPredicate<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Ljava/lang/Object;)Z", AccessFlags = 1025, Signature = "(TT;)Z")]
				bool Apply(T t) /* MethodBuilder.Create */ ;

		}

}


