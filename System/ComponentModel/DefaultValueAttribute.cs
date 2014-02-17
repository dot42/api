// Copyright (C) 2014 dot42
//
// Original filename: DefaultValueAttribute.cs
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
namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
    {
        private object value;

        public DefaultValueAttribute(bool value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(byte value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(char value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(short value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(int value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(long value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(float value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(double value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(string value)
        {
            this.value = value;
        }

        public DefaultValueAttribute(object value)
        {
            this.value = value;
        }

        /// <summary>
        /// Gets the initialized value.
        /// </summary>
        public object Value { get { return value; } }

        /// <summary>
        /// Overwrite the initialized value
        /// </summary>
        protected void SetValue(object value)
        {
            this.value = value;
        }
    }
}

