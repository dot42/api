// Copyright (C) 2014 dot42
//
// Original filename: HttpRequestHeader.cs
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
    //     The HTTP headers that may be specified in a client request.
    public enum HttpRequestHeader
    {
        // Summary:
        //     The Cache-Control header, which specifies directives that must be obeyed
        //     by all cache control mechanisms along the request/response chain.
        CacheControl = 0,
        //
        // Summary:
        //     The Connection header, which specifies options that are desired for a particular
        //     connection.
        Connection = 1,
        //
        // Summary:
        //     The Date header, which specifies the date and time at which the request originated.
        Date = 2,
        //
        // Summary:
        //     The Keep-Alive header, which specifies a parameter used into order to maintain
        //     a persistent connection.
        KeepAlive = 3,
        //
        // Summary:
        //     The Pragma header, which specifies implementation-specific directives that
        //     might apply to any agent along the request/response chain.
        Pragma = 4,
        //
        // Summary:
        //     The Trailer header, which specifies the header fields present in the trailer
        //     of a message encoded with chunked transfer-coding.
        Trailer = 5,
        //
        // Summary:
        //     The Transfer-Encoding header, which specifies what (if any) type of transformation
        //     that has been applied to the message body.
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
        //     The Allow header, which specifies the set of HTTP methods supported.
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
        //     The Content-Langauge header, which specifies the natural language(s) of the
        //     accompanying body data.
        ContentLanguage = 14,
        //
        // Summary:
        //     The Content-Location header, which specifies a URI from which the accompanying
        //     body may be obtained.
        ContentLocation = 15,
        //
        // Summary:
        //     The Content-MD5 header, which specifies the MD5 digest of the accompanying
        //     body data, for the purpose of providing an end-to-end message integrity check.
        ContentMd5 = 16,
        //
        // Summary:
        //     The Content-Range header, which specifies where in the full body the accompanying
        //     partial body data should be applied.
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
        //     The Accept header, which specifies the MIME types that are acceptable for
        //     the response.
        Accept = 20,
        //
        // Summary:
        //     The Accept-Charset header, which specifies the character sets that are acceptable
        //     for the response.
        AcceptCharset = 21,
        //
        // Summary:
        //     The Accept-Encoding header, which specifies the content encodings that are
        //     acceptable for the response.
        AcceptEncoding = 22,
        //
        // Summary:
        //     The Accept-Langauge header, which specifies that natural languages that are
        //     preferred for the response.
        AcceptLanguage = 23,
        //
        // Summary:
        //     The Authorization header, which specifies the credentials that the client
        //     presents in order to authenticate itself to the server.
        Authorization = 24,
        //
        // Summary:
        //     The Cookie header, which specifies cookie data presented to the server.
        Cookie = 25,
        //
        // Summary:
        //     The Expect header, which specifies particular server behaviors that are required
        //     by the client.
        Expect = 26,
        //
        // Summary:
        //     The From header, which specifies an Internet E-mail address for the human
        //     user who controls the requesting user agent.
        From = 27,
        //
        // Summary:
        //     The Host header, which specifies the host name and port number of the resource
        //     being requested.
        Host = 28,
        //
        // Summary:
        //     The If-Match header, which specifies that the requested operation should
        //     be performed only if the client's cached copy of the indicated resource is
        //     current.
        IfMatch = 29,
        //
        // Summary:
        //     The If-Modified-Since header, which specifies that the requested operation
        //     should be performed only if the requested resource has been modified since
        //     the indicated data and time.
        IfModifiedSince = 30,
        //
        // Summary:
        //     The If-None-Match header, which specifies that the requested operation should
        //     be performed only if none of client's cached copies of the indicated resources
        //     are current.
        IfNoneMatch = 31,
        //
        // Summary:
        //     The If-Range header, which specifies that only the specified range of the
        //     requested resource should be sent, if the client's cached copy is current.
        IfRange = 32,
        //
        // Summary:
        //     The If-Unmodified-Since header, which specifies that the requested operation
        //     should be performed only if the requested resource has not been modified
        //     since the indicated date and time.
        IfUnmodifiedSince = 33,
        //
        // Summary:
        //     The Max-Forwards header, which specifies an integer indicating the remaining
        //     number of times that this request may be forwarded.
        MaxForwards = 34,
        //
        // Summary:
        //     The Proxy-Authorization header, which specifies the credentials that the
        //     client presents in order to authenticate itself to a proxy.
        ProxyAuthorization = 35,
        //
        // Summary:
        //     The Referer header, which specifies the URI of the resource from which the
        //     request URI was obtained.
        Referer = 36,
        //
        // Summary:
        //     The Range header, which specifies the the sub-range(s) of the response that
        //     the client requests be returned in lieu of the entire response.
        Range = 37,
        //
        // Summary:
        //     The TE header, which specifies the transfer encodings that are acceptable
        //     for the response.
        Te = 38,
        //
        // Summary:
        //     The Translate header, a Microsoft extension to the HTTP specification used
        //     in conjunction with WebDAV functionality.
        Translate = 39,
        //
        // Summary:
        //     The User-Agent header, which specifies information about the client agent.
        UserAgent = 40,
    }
}

