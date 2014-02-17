// Copyright (C) 2014 dot42
//
// Original filename: Character.cs
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
namespace Java.Lang
{
    [Dot42.DexImport("java/lang/Character", AccessFlags = 49, IgnoreFromJava = true)]
    internal class Character
	{
        /// <summary>
        /// <para>Gets the primitive value of this character.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>this object's primitive value. </para>
        /// </returns>
        /// <java-name>
        /// charValue
        /// </java-name>
        [Dot42.DexImport("charValue", "()C", AccessFlags = 1)]
        public char CharValue() /* MethodBuilder.Create */
        {
            return default(char);
        }
	}
}

