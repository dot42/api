// Copyright (C) 2014 dot42
//
// Original filename: WcfProxyBase.cs
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
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;

namespace Dot42.Internal
{
    [EditorBrowsable(EditorBrowsableState.Never)]
	public class WcfProxyBase : CommunicationObject, IContextChannel
    {
        protected Uri baseAddress;

        public EndpointAddress RemoteAddress
        {
            get { return new EndpointAddress(baseAddress); }
        }

        public string SessionId
        {
            get { throw new NotImplementedException(); }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static class WebHelper
        {
            public enum Verb
            {
                Get,
                Post,
                Put,
                Delete
            }

            public static Stream WebInvoke(Uri uri, Verb verb, Stream input, WebMessageFormat requestFormat, bool hasOutput)
            {
                var request = WebRequest.Create(uri);
                switch (verb)
                {
                    case Verb.Get:
                        request.Method = "GET";
                        break;
                    case Verb.Post:
                        request.Method = "POST";
                        break;
                    case Verb.Put:
                        request.Method = "PUT";
                        break;
                    case Verb.Delete:
                        request.Method = "DELETE";
                        break;
                    default:
                        throw new NotSupportedException();
                }

                if (input != null)
                {
                    input.Seek(0L, SeekOrigin.Begin);

                    switch (requestFormat)
                    {
                        case WebMessageFormat.Xml:
                            request.ContentType = "application/xml";
                            break;

                        case WebMessageFormat.Json:
                            request.ContentType = "application/json";
                            break;
                    }

                    request.ContentLength = input.Length;

                    using (var requestStream = request.GetRequestStream())
                    {
                        var bytes = new byte[1024];
                        var read = 1;
                        while (read > 0)
                        {
                            read = input.Read(bytes, 0, bytes.Length);
                            requestStream.Write(bytes, 0, read);
                        }
                    }
                }

                try
                {
                    using (var response = request.GetResponse())
                    {
                        if (!hasOutput)
                            return null;
                        var length = (int) response.ContentLength;
                        var copy = (length > 0) ? new MemoryStream(length) : new MemoryStream();
                        response.GetResponseStream().CopyTo(copy);
                        copy.Seek(0L, SeekOrigin.Begin);
                        return copy;
                    }
                }
                catch (WebException ex)
                {
                    var message = string.Format("The remote server returned an unexpected response: {0}", ex.Message);
                    throw new CommunicationException(message, ex);
                }
            }
        }
    }
}

