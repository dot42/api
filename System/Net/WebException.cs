// Copyright (C) 2014 dot42
//
// Original filename: WebException.cs
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
namespace System.Net
{
    [SerializableAttribute]
    public class WebException : InvalidOperationException
    {
        private readonly WebExceptionStatus status;
        private readonly WebResponse response;

        public WebException()
        {
        }

        public WebException(string message)
            : base(message)
        {
        }

        public WebException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public WebException(string message, WebExceptionStatus status)
            : base(message)
        {
            this.status = status;
        }
        
        public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
            : base(message, innerException)
        {
            this.status = status;
            this.response = response;
        }

        /// <summary>
        /// The response that the remote host returned (can be null).
        /// </summary>
        public WebResponse Response
        {
            get { return response; }
        }

        /// <summary>
        /// The status of the response.
        /// </summary>
        public WebExceptionStatus Status 
        {
            get { return status; }
        }
    }
}


