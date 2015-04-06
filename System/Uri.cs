// Copyright (C) 2014 dot42
//
// Original filename: Uri.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
	partial class Uri
	{
        private static readonly string _hexUpperChars = "0123456789ABCDEF";
        private static readonly string _schemeDelimiterMailtoAndNews = ":";
        
        public static readonly string SchemeDelimiter = "://";
        public static readonly string UriSchemeFile = "file";
        public static readonly string UriSchemeFtp = "ftp";
        public static readonly string UriSchemeGopher = "gopher";
        public static readonly string UriSchemeHttp = "http";
        public static readonly string UriSchemeHttps = "https";
        public static readonly string UriSchemeMailto = "mailto";
        public static readonly string UriSchemeNews = "news";
        public static readonly string UriSchemeNntp = "nntp";
        public static readonly string UriSchemeNetPipe = "net.pipe";
        public static readonly string UriSchemeNetTcp = "net.tcp";

        internal static string GetSchemeDelimiter (string scheme)
        {
            if (scheme == UriSchemeMailto || scheme == UriSchemeNews) return _schemeDelimiterMailtoAndNews;
			return SchemeDelimiter;
		}

        /// <summary>
        /// Create an uri based on a base uri and a relative part.
        /// </summary>
        public Uri(Uri baseUri, string relativeUri)
            : this(Combine(baseUri, new Uri(relativeUri)))
        {
            
        }

        /// <summary>
        /// Create an uri based on a base uri and a relative part.
        /// </summary>
        public Uri(Uri baseUri, Uri relativeUri)
            : this(Combine(baseUri, relativeUri))
        {

        }

        private static string Combine(Uri baseUri, Uri relativeUri)
        {
            return baseUri.ToString() + relativeUri.ToString();
        }

        public Uri(string uriString, UriKind uriKind)
            : this(uriString)
        {
            switch (uriKind)
            {
                case UriKind.Absolute:
                    if(!IsAbsolute) throw new UriFormatException();
                    break;

                case UriKind.Relative:
                    if (IsAbsolute) throw new UriFormatException();
                    break;
            }
        }

	    public static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
	    {
            try
            {
                result = new Uri(uriString);
                switch (uriKind)
                {
                    case UriKind.Absolute:
                        if (!result.IsAbsolute) throw new UriFormatException();
                        break;

                    case UriKind.Relative:
                        if (result.IsAbsolute) throw new UriFormatException();
                        break;
                }
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
	    }

	    public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
	    {
            try
            {
                result = baseUri.Resolve(relativeUri);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
	    }

	    public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
	    {
            try
            {
                result = baseUri.Resolve(relativeUri);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
	    }

        public static string EscapeUriString(string stringToEscape)
        {
            if (stringToEscape == null)
                throw new ArgumentNullException("stringToEscape");

            var escape = false;
            foreach (char c in stringToEscape)
            {
                if (NeedToEscapeUriChar(c))
                {
                    escape = true;
                    break;
                }
            }
            if (!escape)
                return stringToEscape;

            var sb = new StringBuilder();
            var bytes = Encoding.UTF8.GetBytes(stringToEscape);
            foreach (var b in bytes)
            {
                if (NeedToEscapeUriChar((char)b))
                    sb.Append(HexEscape((char)b));
                else
                    sb.Append((char)b);
            }
            return sb.ToString();
        }

        private static bool NeedToEscapeUriChar(char b)
        {
            if ((b >= 'A' && b <= 'Z') || (b >= 'a' && b <= 'z') || (b >= '&' && b <= ';'))
                return false;

            switch (b)
            {
                case '!':
                case '#':
                case '$':
                case '=':
                case '?':
                case '@':
                case '_':
                case '~':
			    case '[':
			    case ']':

                    return false;
                default:
                    return true;
            }
        }

        public static string HexEscape(char character)
        {
            if (character > 255)
            {
                throw new ArgumentOutOfRangeException("character");
            }

            return "%" + _hexUpperChars[((character & 0xf0) >> 4)]
                       + _hexUpperChars[((character & 0x0f))];
        }

        public bool IsFile
        {
            get
            {
                return (Scheme == UriSchemeFile);
            }
        }

	    public string LocalPath
	    {
            get { return ToASCIIString(); }
	    }

	    public string OriginalString
	    {
            get { return this.ToString(); }
	    }

        public static implicit operator Java.Net.URL(Uri uri)
        {
            return uri.ToURL();
        }
	}
}

