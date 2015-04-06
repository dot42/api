// Copyright (C) 2014 dot42
//
// Original filename: WebClient.cs
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
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Dot42;
using Java.Io;
using Java.Net;

namespace System.Net
{
    /// <summary>
    /// Web connection helper
    /// </summary>
	public class WebClient : Component
	{
	    private const int BUFFER_SIZE = 4096;
        private Encoding encoding;

        /// <summary>
        /// Gets/sets the encoding used for converting bytes to/from strings.
        /// </summary>
        public Encoding Encoding
        {
            get { return encoding ?? Encoding.Default; }
            set { encoding = value; }
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public byte[] DownloadData(string address)
        {
            return DownloadData(new URL(address));
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public byte[] DownloadData(Uri address)
        {
            return DownloadData(address.ToURL());
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        public byte[] DownloadData(URL address)
        {
            URLConnection connection = null;
            InputStream inputStream = null;
            try
            {
                connection = OpenConnection(address);
                inputStream = connection.InputStream;
                var memStream = new ByteArrayOutputStream();
                var buffer = new byte[BUFFER_SIZE];
                int len;

                while ((len = inputStream.Read(buffer, 0, BUFFER_SIZE)) > 0)
                {
                    memStream.Write(buffer, 0, len);
                }

                return memStream.ToByteArray();
            }
            finally
            {
                if (inputStream != null)
                    inputStream.Close();
                var httpConnection = connection as HttpURLConnection;
                if (httpConnection != null)
                    httpConnection.Disconnect();
            }
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public Task<byte[]> DownloadDataTaskAsync(string address)
        {
            return DownloadDataTaskAsync(new URL(address));
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public Task<byte[]> DownloadDataTaskAsync(Uri address)
        {
            return DownloadDataTaskAsync(address.ToURL());
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        public Task<byte[]> DownloadDataTaskAsync(URL address)
        {
            return Task.Factory.StartNewIO(() => DownloadData(address));
        }

        /// <summary>
        /// Download a string from the specified URI.
        /// </summary>
        [Inline]
        public string DownloadString(string address)
        {
            return DownloadString(new URL(address));
        }

        /// <summary>
        /// Download a string from the specified URI.
        /// </summary>
        [Inline]
        public string DownloadString(Uri address)
        {
            return DownloadString(address.ToURL());
        }

        /// <summary>
        /// Download a string from the specified URI.
        /// </summary>
        public string DownloadString(URL address)
        {
            URLConnection connection = null;
            InputStream inputStream = null;
            try
            {
                connection = OpenConnection(address);
                inputStream = connection.InputStream;
                var reader = new InputStreamReader(inputStream);
                var buffer = new char[BUFFER_SIZE];
                var builder = new StringBuilder();
                int len;                

                while ((len = reader.Read(buffer, 0, BUFFER_SIZE)) > 0)
                {
                    builder.Append(buffer, 0, len);
                }

                return builder.ToString();
            }
            finally
            {
                if (inputStream != null)
                    inputStream.Close();
                var httpConnection = connection as HttpURLConnection;
                if (httpConnection != null)
                    httpConnection.Disconnect();
            }
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public Task<string> DownloadStringTaskAsync(string address)
        {
            return DownloadStringTaskAsync(new URL(address));
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        [Inline]
        public Task<string> DownloadStringTaskAsync(Uri address)
        {
            return DownloadStringTaskAsync(address.ToURL());
        }

        /// <summary>
        /// Download a resource from the specified URI.
        /// </summary>
        public Task<string> DownloadStringTaskAsync(URL address)
        {
            return Task.Factory.StartNewIO(() => DownloadString(address));
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        [Inline]
        public void DownloadFile(string address, string fileName)
        {
            DownloadFile(new URL(address), fileName);
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        [Inline]
        public void DownloadFile(Uri address, string fileName)
        {
            DownloadFile(address.ToURL(), fileName);
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        public void DownloadFile(URL address, string fileName)
        {
            URLConnection connection = null;
            InputStream inputStream = null;
            OutputStream outputStream = new FileOutputStream(fileName);
            try
            {
                connection = OpenConnection(address);
                inputStream = connection.InputStream;
                var buffer = new byte[BUFFER_SIZE];
                int len;

                while ((len = inputStream.Read(buffer, 0, BUFFER_SIZE)) > 0)
                {
                    outputStream.Write(buffer, 0, len);
                }

                outputStream.Flush();
            }
            finally
            {
                if (inputStream != null)
                    inputStream.Close();
                var httpConnection = connection as HttpURLConnection;
                if (httpConnection != null)
                    httpConnection.Disconnect();
                outputStream.Close();
            }
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        [Inline]
        public Task DownloadFileTaskAsync(string address, string fileName)
        {
            return DownloadFileTaskAsync(new URL(address), fileName);
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        [Inline]
        public Task DownloadFileTaskAsync(Uri address, string fileName)
        {
            return DownloadFileTaskAsync(address.ToURL(), fileName);
        }

        /// <summary>
        /// Downloads the resource with the specified URI to a local file.
        /// </summary>
        public Task DownloadFileTaskAsync(URL address, string fileName)
        {
            return Task.Factory.StartNewIO(() => DownloadFileTaskAsync(address, fileName));
        }

        /// <summary>
        /// Open a connection and initialize it.
        /// </summary>
        private static URLConnection OpenConnection(URL url)
        {
            var connection = url.OpenConnection();
            var httpConnection = connection as HttpURLConnection;
            if (httpConnection != null)
            {
                httpConnection.InstanceFollowRedirects = true;
            }
            return connection;
        }
    }
}

