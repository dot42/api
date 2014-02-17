// Copyright (C) 2014 dot42
//
// Original filename: HttpResponseHeader.cs
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
    // Summary:
    //     The HTTP headers that can be specified in a server response.
    public enum HttpResponseHeader
    {
        // Summary:
        //     The Cache-Control header, which specifies caching directives that must be
        //     obeyed by all caching mechanisms along the request/response chain.
        CacheControl = 0,
        //
        // Summary:
        //     The Connection header, which specifies options that are desired for a particular
        //     connection.
        Connection = 1,
        //
        // Summary:
        //     The Date header, which specifies the date and time at which the response
        //     originated.
        Date = 2,
        //
        // Summary:
        //     The Keep-Alive header, which specifies a parameter to be used to maintain
        //     a persistent connection.
        KeepAlive = 3,
        //
        // Summary:
        //     The Pragma header, which specifies implementation-specific directives that
        //     might apply to any agent along the request/response chain.
        Pragma = 4,
        //
        // Summary:
        //     The Trailer header, which specifies that the indicated header fields are
        //     present in the trailer of a message that is encoded with chunked transfer-coding.
        Trailer = 5,
        //
        // Summary:
        //     The Transfer-Encoding header, which specifies what (if any) type of transformation
        //     has been applied to the message body.
        TransferEncoding = 6,
        //
        // Summary:
        //     The Upgrade header, which specifies additional communications protocols that
        //     the client supports.
        Upgrade = 7,
        //
        // Summary:
        //     The Via header, which specifies intermediate protocols to be used by gateway
        //     and proxy agents.
        Via = 8,
        //
        // Summary:
        //     The Warning header, which specifies additional information about that status
        //     or transformation of a message that might not be reflected in the message.
        Warning = 9,
        //
        // Summary:
        //     The Allow header, which specifies the set of HTTP methods that are supported.
        Allow = 10,
        //
        // Summary:
        //     The Content-Length header, which specifies the length, in bytes, of the accompanying
        //     body data.
        ContentLength = 11,
        //
        // Summary:
        //     The Content-Type header, which specifies the MIME type of the accompanying
        //     body data.
        ContentType = 12,
        //
        // Summary:
        //     The Content-Encoding header, which specifies the encodings that have been
        //     applied to the accompanying body data.
        ContentEncoding = 13,
        //
        // Summary:
        //     The Content-Langauge header, which specifies the natural language or languages
        //     of the accompanying body data.
        ContentLanguage = 14,
        //
        // Summary:
        //     The Content-Location header, which specifies a URI from which the accompanying
        //     body can be obtained.
        ContentLocation = 15,
        //
        // Summary:
        //     The Content-MD5 header, which specifies the MD5 digest of the accompanying
        //     body data, for the purpose of providing an end-to-end message integrity check.
        ContentMd5 = 16,
        //
        // Summary:
        //     The Range header, which specifies the subrange or subranges of the response
        //     that the client requests be returned in lieu of the entire response.
        ContentRange = 17,
        //
        // Summary:
        //     The Expires header, which specifies the date and time after which the accompanying
        //     body data should be considered stale.
        Expires = 18,
        //
        // Summary:
        //     The Last-Modified header, which specifies the date and time at which the
        //     accompanying body data was last modified.
        LastModified = 19,
        //
        // Summary:
        //     The Accept-Ranges header, which specifies the range that is accepted by the
        //     server.
        AcceptRanges = 20,
        //
        // Summary:
        //     The Age header, which specifies the time, in seconds, since the response
        //     was generated by the originating server.
        Age = 21,
        //
        // Summary:
        //     The Etag header, which specifies the current value for the requested variant.
        ETag = 22,
        //
        // Summary:
        //     The Location header, which specifies a URI to which the client is redirected
        //     to obtain the requested resource.
        Location = 23,
        //
        // Summary:
        //     The Proxy-Authenticate header, which specifies that the client must authenticate
        //     itself to a proxy.
        ProxyAuthenticate = 24,
        //
        // Summary:
        //     The Retry-After header, which specifies a time (in seconds), or a date and
        //     time, after which the client can retry its request.
        RetryAfter = 25,
        //
        // Summary:
        //     The Server header, which specifies information about the originating server
        //     agent.
        Server = 26,
        //
        // Summary:
        //     The Set-Cookie header, which specifies cookie data that is presented to the
        //     client.
        SetCookie = 27,
        //
        // Summary:
        //     The Vary header, which specifies the request headers that are used to determine
        //     whether a cached response is fresh.
        Vary = 28,
        //
        // Summary:
        //     The WWW-Authenticate header, which specifies that the client must authenticate
        //     itself to the server.
        WwwAuthenticate = 29,
    }
}


