// Copyright (C) 2014 dot42
//
// Original filename: Android.Annotation.cs
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
namespace Android.Annotation
{
		/// <summary>
		/// <para>Indicates that Lint should treat this type as targeting a given API level, no matter what the project target is. </para>    
		/// </summary>
		/// <java-name>
		/// android/annotation/TargetApi
		/// </java-name>
		[Dot42.DexImport("android/annotation/TargetApi", AccessFlags = 9729)]
		public partial interface ITargetApi : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This sets the target api level for the type.. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()I", AccessFlags = 1025)]
				int Value() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates that Lint should ignore the specified warnings for the annotated element. </para>    
		/// </summary>
		/// <java-name>
		/// android/annotation/SuppressLint
		/// </java-name>
		[Dot42.DexImport("android/annotation/SuppressLint", AccessFlags = 9729)]
		public partial interface ISuppressLint : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The set of warnings (identified by the lint issue id) that should be ignored by lint. It is not an error to specify an unrecognized name. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] Value() /* MethodBuilder.Create */ ;

		}

}


