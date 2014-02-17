// Copyright (C) 2014 dot42
//
// Original filename: UriTemplate.cs
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
using System.Collections.Specialized;

namespace System
{
	public class UriTemplate
	{
	    private string template;
        /// <summary>
        /// Creates an uri template class with the specified template.
        /// </summary>
        public UriTemplate(string template)
        {
            this.template = template;
        }

        /// <summary>
        ///  Creates a new URI from the template and the collection of parameters.
        /// </summary>
        public Uri BindByName(Uri baseAddress, NameValueCollection parameters)
        {
            var resolvedTemplate = template;

            foreach (var parameterKey in parameters.AllKeys)
            {
                var parameterValue = parameters[parameterKey];

                resolvedTemplate = resolvedTemplate.Replace("{" + parameterKey + "}", parameterValue);
            }

            return new Uri(baseAddress, resolvedTemplate);
        }

        public override string ToString()
        {
            return template;
        }

	}
}

