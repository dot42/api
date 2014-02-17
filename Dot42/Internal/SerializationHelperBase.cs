// Copyright (C) 2014 dot42
//
// Original filename: SerializationHelperBase.cs
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
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using Org.Json;

namespace Dot42.Internal
{
    [EditorBrowsable(EditorBrowsableState.Never)]
	public class SerializationHelperBase
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum SerializationFormat
        {
            DataContract,
            XmlSerializer
        }

        #region Boolean

        public static Stream SerializeSystemBoolean(bool obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Boolean"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemBooleanArray(bool[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("BooleanArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Boolean"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemBoolean(bool obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemBoolean(bool[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, bool obj)
        {
            jsonObject.Put(name, obj);
        }

        public static bool DeserializeSystemBoolean(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemBoolean(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                var tokenizer = new JSONTokener(json);
                return bool.Parse(tokenizer.NextValue().ToString());
            }
        }

        [Inline]
        public static bool DeserializeSystemBoolean(XElement xElement)
        {
            return XmlConvert.ToBoolean(xElement.Value);
        }

        [Inline]
        public static bool DeserializeSystemBoolean(XAttribute xAttribute)
        {
            return XmlConvert.ToBoolean(xAttribute.Value);
        }

        [Inline]
        public static bool DeserializeSystemBoolean(JSONObject jsonObject, string name)
        {
            return jsonObject.GetBoolean(name);
        }

        public static bool[] DeserializeSystemBooleanArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        { 
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemBooleanArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemBooleanArray(jsonArray);
            } 
        }

        public static bool[] DeserializeSystemBooleanArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static bool[] DeserializeSystemBooleanArray(JSONArray jsonArray)
        {
            var result = new bool[jsonArray.Length()];

            for (var i =0; i<result.Length; i++)
            {
                result[i] = jsonArray.OptBoolean(i);
            }

            return result;
        }

        #endregion

        #region Byte
        public static Stream SerializeSystemByte(byte obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Byte"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemByteArray(byte[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("ByteArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Byte"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemByte(byte obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemByte(byte[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, byte obj)
        {
            jsonObject.Put(name, obj);
        }

        public static byte DeserializeSystemByte(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemByte(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return byte.Parse(json);
            }
        }

        [Inline]
        public static byte DeserializeSystemByte(XElement xElement)
        {
            return XmlConvert.ToByte(xElement.Value);
        }

        [Inline]
        public static byte DeserializeSystemByte(XAttribute xAttribute)
        {
            return XmlConvert.ToByte(xAttribute.Value);
        }

        [Inline]
        public static byte DeserializeSystemByte(JSONObject jsonObject, string name)
        {
            return jsonObject.GetByte(name);
        }

        public static byte[] DeserializeSystemByteArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemByteArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemByteArray(jsonArray);
            }
        }

        public static byte[] DeserializeSystemByteArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static byte[] DeserializeSystemByteArray(JSONArray jsonArray)
        {
            var result = new byte[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (byte)jsonArray.OptInt(i);
            }

            return result;
        }
        #endregion

        #region Char
        public static Stream SerializeSystemChar(char obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Char"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemCharArray(char[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("CharArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Char"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemChar(char obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemChar(char[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj.ToString());
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, char obj)
        {
            jsonObject.Put(name, obj.ToString());
        }

        public static char DeserializeSystemChar(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream); 
                return DeserializeSystemChar(doc.Root);
            }
            else
            {
                var json = GetString(stream, true);
                return char.Parse(json);
            }
        }

        [Inline]
        public static char DeserializeSystemChar(XElement xElement)
        {
            return XmlConvert.ToChar(xElement.Value);
        }

        [Inline]
        public static char DeserializeSystemChar(XAttribute xAttribute)
        {
            return XmlConvert.ToChar(xAttribute.Value);
        }

        [Inline]
        public static char DeserializeSystemChar(JSONObject jsonObject, string name)
        {
            return jsonObject.GetChar(name);
        }

        public static char[] DeserializeSystemCharArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemCharArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemCharArray(jsonArray);
            }
        }

        public static char[] DeserializeSystemCharArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static char[] DeserializeSystemCharArray(JSONArray jsonArray)
        {
            var result = new char[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = jsonArray.OptString(i)[0];
            }

            return result;
        }
        #endregion

        #region DateTime
        public static Stream SerializeSystemDateTime(DateTime obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("DateTime"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemDateTimeArray(DateTime[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("DateTimeArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("DateTime"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemDateTime(DateTime obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemDateTime(DateTime[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(JsonConvert.ToString(obj));
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, DateTime obj)
        {
            jsonObject.Put(name, JsonConvert.ToString(obj));
        }

        public static DateTime DeserializeSystemDateTime(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDateTime(doc.Root);
            }
            else
            {
                var json = GetString(stream, true);
                return JsonConvert.ToDateTime(json);
            }
        }

        [Inline]
        public static DateTime DeserializeSystemDateTime(XElement xElement)
        {
            return XmlConvert.ToDateTime(xElement.Value);
        }

        [Inline]
        public static DateTime DeserializeSystemDateTime(XAttribute xAttribute)
        {
            return XmlConvert.ToDateTime(xAttribute.Value);
        }

        [Inline]
        public static DateTime DeserializeSystemDateTime(JSONObject jsonObject, string name)
        {
            return jsonObject.GetDateTime(name);
        }

        public static DateTime[] DeserializeSystemDateTimeArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDateTimeArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemDateTimeArray(jsonArray);
            }
        }

        public static DateTime[] DeserializeSystemDateTimeArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static DateTime[] DeserializeSystemDateTimeArray(JSONArray jsonArray)
        {
            var result = new DateTime[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = JsonConvert.ToDateTime(jsonArray.OptString(i));
            }

            return result;
        }
        #endregion

        #region Decimal
        public static Stream SerializeSystemDecimal(decimal obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Decimal"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemDecimalArray(decimal[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("DecimalArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Decimal"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemDecimal(decimal obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemDecimal(decimal[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, decimal obj)
        {
            jsonObject.Put(name, obj);
        }

        public static decimal DeserializeSystemDecimal(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDecimal(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return decimal.Parse(json);
            }
        }

        [Inline]
        public static decimal DeserializeSystemDecimal(XElement xElement)
        {
            return XmlConvert.ToDecimal(xElement.Value);
        }

        [Inline]
        public static decimal DeserializeSystemDecimal(XAttribute xAttribute)
        {
            return XmlConvert.ToDecimal(xAttribute.Value);
        }

        [Inline]
        public static decimal DeserializeSystemDecimal(JSONObject jsonObject, string name)
        {
            return jsonObject.GetDecimal(name);
        }

        public static decimal[] DeserializeSystemDecimalArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDecimalArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemDecimalArray(jsonArray);
            }
        }

        public static decimal[] DeserializeSystemDecimalArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static decimal[] DeserializeSystemDecimalArray(JSONArray jsonArray)
        {
            var result = new decimal[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (decimal)jsonArray.OptLong(i);
            }

            return result;
        }
        #endregion

        #region Double
        public static Stream SerializeSystemDouble(double obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Double"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemDoubleArray(double[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("DoubleArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Double"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemDouble(double obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemDouble(double[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, double obj)
        {
            jsonObject.Put(name, obj);
        }

        public static double DeserializeSystemDouble(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDouble(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return double.Parse(json);
            }
        }

        [Inline]
        public static double DeserializeSystemDouble(XElement xElement)
        {
            return XmlConvert.ToDouble(xElement.Value);
        }

        [Inline]
        public static double DeserializeSystemDouble(XAttribute xAttribute)
        {
            return XmlConvert.ToDouble(xAttribute.Value);
        }

        [Inline]
        public static double DeserializeSystemDouble(JSONObject jsonObject, string name)
        {
            return jsonObject.GetDouble(name);
        }

        public static double[] DeserializeSystemDoubleArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemDoubleArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemDoubleArray(jsonArray);
            }
        }

        public static double[] DeserializeSystemDoubleArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static double[] DeserializeSystemDoubleArray(JSONArray jsonArray)
        {
            var result = new double[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = jsonArray.OptDouble(i);
            }

            return result;
        }
        #endregion

        #region Guid
        public static Stream SerializeSystemGuid(Guid obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Guid"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemGuidArray(Guid[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("GuidArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Guid"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemGuid(Guid obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemGuid(Guid[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj.ToString());
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, Guid obj)
        {
            jsonObject.Put(name, obj.ToString());
        }

        public static Guid DeserializeSystemGuid(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream); 
                return DeserializeSystemGuid(doc.Root);
            }
            else
            {
                var json = GetString(stream, true);
                return new Guid(json);
            }
        }

        [Inline]
        public static Guid DeserializeSystemGuid(XElement xElement)
        {
            return XmlConvert.ToGuid(xElement.Value);
        }

        [Inline]
        public static Guid DeserializeSystemGuid(XAttribute xAttribute)
        {
            return XmlConvert.ToGuid(xAttribute.Value);
        }

        [Inline]
        public static Guid DeserializeSystemGuid(JSONObject jsonObject, string name)
        {
            return jsonObject.GetGuid(name);
        }

        public static Guid[] DeserializeSystemGuidArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemGuidArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemGuidArray(jsonArray);
            }
        }

        public static Guid[] DeserializeSystemGuidArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static Guid[] DeserializeSystemGuidArray(JSONArray jsonArray)
        {
            var result = new Guid[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = new Guid(jsonArray.OptString(i));
            }

            return result;
        }
        #endregion

        #region Int16
        public static Stream SerializeSystemInt16(short obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int16"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemInt16Array(short[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int16Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Int16"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemInt16(short obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemInt16(short[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, short obj)
        {
            jsonObject.Put(name, obj);
        }

        public static short DeserializeSystemInt16(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt16(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return short.Parse(json);
            }
        }

        [Inline]
        public static short DeserializeSystemInt16(XElement xElement)
        {
            return XmlConvert.ToInt16(xElement.Value);
        }

        [Inline]
        public static short DeserializeSystemInt16(XAttribute xAttribute)
        {
            return XmlConvert.ToInt16(xAttribute.Value);
        }

        [Inline]
        public static short DeserializeSystemInt16(JSONObject jsonObject, string name)
        {
            return jsonObject.GetInt16(name);
        }

        public static short[] DeserializeSystemInt16Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt16Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemInt16Array(jsonArray);
            }
        }

        public static short[] DeserializeSystemInt16Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static short[] DeserializeSystemInt16Array(JSONArray jsonArray)
        {
            var result = new short[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (short)jsonArray.OptInt(i);
            }

            return result;
        }
        #endregion

        #region Int32
        public static Stream SerializeSystemInt32(int obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int32"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemInt32Array(int[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int32Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Int32"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemInt32(int obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemInt32(int[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, int obj)
        {
            jsonObject.Put(name, obj);
        }

        public static int DeserializeSystemInt32(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt32(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return int.Parse(json);
            }
        }

        [Inline]
        public static int DeserializeSystemInt32(XElement xElement)
        {
            return XmlConvert.ToInt32(xElement.Value);
        }

        [Inline]
        public static int DeserializeSystemInt32(XAttribute xAttribute)
        {
            return XmlConvert.ToInt32(xAttribute.Value);
        }

        [Inline]
        public static int DeserializeSystemInt32(JSONObject jsonObject, string name)
        {
            return jsonObject.GetInt32(name);
        }

        public static int[] DeserializeSystemInt32Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt32Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemInt32Array(jsonArray);
            }
        }

        public static int[] DeserializeSystemInt32Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static int[] DeserializeSystemInt32Array(JSONArray jsonArray)
        {
            var result = new int[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = jsonArray.OptInt(i);
            }

            return result;
        }
        #endregion

        #region Int64
        public static Stream SerializeSystemInt64(long obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int64"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemInt64Array(long[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Int64Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Int64"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemInt64(long obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemInt64(long[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, long obj)
        {
            jsonObject.Put(name, obj);
        }

        public static long DeserializeSystemInt64(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt64(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return long.Parse(json);
            }
        }

        [Inline]
        public static long DeserializeSystemInt64(XElement xElement)
        {
            return XmlConvert.ToInt64(xElement.Value);
        }

        [Inline]
        public static long DeserializeSystemInt64(XAttribute xAttribute)
        {
            return XmlConvert.ToInt64(xAttribute.Value);
        }

        [Inline]
        public static long DeserializeSystemInt64(JSONObject jsonObject, string name)
        {
            return jsonObject.GetInt64(name);
        }

        public static long[] DeserializeSystemInt64Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemInt64Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemInt64Array(jsonArray);
            }
        }

        public static long[] DeserializeSystemInt64Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static long[] DeserializeSystemInt64Array(JSONArray jsonArray)
        {
            var result = new long[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = jsonArray.OptLong(i);
            }

            return result;
        }
        #endregion

        #region SByte
        public static Stream SerializeSystemSByte(sbyte obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("SByte"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemSByteArray(sbyte[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("SByteArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("SByte"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemSByte(sbyte obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemSByte(sbyte[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, sbyte obj)
        {
            jsonObject.Put(name, obj);
        }

        public static sbyte DeserializeSystemSByte(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemSByte(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return sbyte.Parse(json);
            }
        }

        [Inline]
        public static sbyte DeserializeSystemSByte(XElement xElement)
        {
            return XmlConvert.ToSByte(xElement.Value);
        }

        [Inline]
        public static sbyte DeserializeSystemSByte(XAttribute xAttribute)
        {
            return XmlConvert.ToSByte(xAttribute.Value);
        }

        [Inline]
        public static sbyte DeserializeSystemSByte(JSONObject jsonObject, string name)
        {
            return jsonObject.GetSByte(name);
        }

        public static sbyte[] DeserializeSystemSByteArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemSByteArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemSByteArray(jsonArray);
            }
        }

        public static sbyte[] DeserializeSystemSByteArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static sbyte[] DeserializeSystemSByteArray(JSONArray jsonArray)
        {
            var result = new sbyte[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (sbyte)jsonArray.OptInt(i);
            }

            return result;
        }
        #endregion

        #region Single
        public static Stream SerializeSystemSingle(float obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("Single"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemSingleArray(float[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("SingleArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("Single"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemSingle(float obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemSingle(float[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, float obj)
        {
            jsonObject.Put(name, obj);
        }

        public static float DeserializeSystemSingle(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemSingle(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return float.Parse(json);
            }
        }

        [Inline]
        public static float DeserializeSystemSingle(XElement xElement)
        {
            return XmlConvert.ToSingle(xElement.Value);
        }

        [Inline]
        public static float DeserializeSystemSingle(XAttribute xAttribute)
        {
            return XmlConvert.ToSingle(xAttribute.Value);
        }

        [Inline]
        public static float DeserializeSystemSingle(JSONObject jsonObject, string name)
        {
            return jsonObject.GetSingle(name);
        }

        public static float[] DeserializeSystemSingleArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemSingleArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemSingleArray(jsonArray);
            }
        }

        public static float[] DeserializeSystemSingleArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static float[] DeserializeSystemSingleArray(JSONArray jsonArray)
        {
            var result = new float[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (float)jsonArray.OptDouble(i);
            }

            return result;
        }
        #endregion

        #region String
        public static Stream SerializeSystemString(string obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("byte"));
                var xDocument = new XDocument(root);
                root.Add(obj);
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemStringArray(string[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("StringArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("String"));
                    child.Add(obj);
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemString(string obj, XElement xElement)
        {
            xElement.Value = obj;
        }

        public static void SerializeSystemString(string[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, string obj)
        {
            jsonObject.Put(name, obj);
        }

        public static string DeserializeSystemString(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemString(doc.Root);
            }
            else
            {
                var json = GetString(stream, true);
                return json;
            }
        }

        [Inline]
        public static string DeserializeSystemString(XElement xElement)
        {
            return xElement.Value;
        }

        [Inline]
        public static string DeserializeSystemString(XAttribute xAttribute)
        {
            return xAttribute.Value;
        }

        [Inline]
        public static string DeserializeSystemString(JSONObject jsonObject, string name)
        {
            return jsonObject.GetString(name);
        }

        public static string[] DeserializeSystemStringArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemStringArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemStringArray(jsonArray);
            }
        }

        public static string[] DeserializeSystemStringArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static string[] DeserializeSystemStringArray(JSONArray jsonArray)
        {
            var result = new string[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = jsonArray.OptString(i);
            }

            return result;
        }
        #endregion

        #region TimeSpan
        public static Stream SerializeSystemTimeSpan(TimeSpan obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("TimeSpan"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemTimeSpanArray(TimeSpan[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("TimeSpanArray"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("TimeSpan"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemTimeSpan(TimeSpan obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemTimeSpan(TimeSpan[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(JsonConvert.ToString(obj));
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, TimeSpan obj)
        {
            jsonObject.Put(name, JsonConvert.ToString(obj));
        }

        public static TimeSpan DeserializeSystemTimeSpan(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemTimeSpan(doc.Root);
            }
            else
            {
                var json = GetString(stream, true);
                return JsonConvert.ToTimeSpan(json);
            }
        }

        [Inline]
        public static TimeSpan DeserializeSystemTimeSpan(XElement xElement)
        {
            return XmlConvert.ToTimeSpan(xElement.Value);
        }

        [Inline]
        public static TimeSpan DeserializeSystemTimeSpan(XAttribute xAttribute)
        {
            return XmlConvert.ToTimeSpan(xAttribute.Value);
        }

        [Inline]
        public static TimeSpan DeserializeSystemTimeSpan(JSONObject jsonObject, string name)
        {
            return jsonObject.GetTimeSpan(name);
        }

        public static TimeSpan[] DeserializeSystemTimeSpanArray(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemTimeSpanArray(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemTimeSpanArray(jsonArray);
            }
        }

        public static TimeSpan[] DeserializeSystemTimeSpanArray(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static TimeSpan[] DeserializeSystemTimeSpanArray(JSONArray jsonArray)
        {
            var result = new TimeSpan[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = JsonConvert.ToTimeSpan(jsonArray.OptString(i));
            }

            return result;
        }
        #endregion

        #region UInt16
        public static Stream SerializeSystemUInt16(ushort obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt16"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemUInt16Array(ushort[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt16Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("UInt16"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemUInt16(ushort obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemUInt16(ushort[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, ushort obj)
        {
            jsonObject.Put(name, obj);
        }

        public static ushort DeserializeSystemUInt16(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemUInt16(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return ushort.Parse(json);
            }
        }

        [Inline]
        public static ushort DeserializeSystemUInt16(XElement xElement)
        {
            return XmlConvert.ToUInt16(xElement.Value);
        }

        [Inline]
        public static ushort DeserializeSystemUInt16(XAttribute xAttribute)
        {
            return XmlConvert.ToUInt16(xAttribute.Value);
        }

        [Inline]
        public static ushort DeserializeSystemUInt16(JSONObject jsonObject, string name)
        {
            return jsonObject.GetUInt16(name);
        }

        public static ushort[] DeserializeSystemUInt16Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemUInt16Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemUInt16Array(jsonArray);
            }
        }

        public static ushort[] DeserializeSystemUInt16Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static ushort[] DeserializeSystemUInt16Array(JSONArray jsonArray)
        {
            var result = new ushort[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (ushort)jsonArray.OptInt(i);
            }

            return result;
        }
        #endregion

        #region UInt32
        public static Stream SerializeSystemUInt32(uint obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt32"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemUInt32Array(uint[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt32Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("UInt32"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemUInt32(uint obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemUInt32(uint[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, uint obj)
        {
            jsonObject.Put(name, obj);
        }

        public static uint DeserializeSystemUInt32(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemUInt32(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return uint.Parse(json);
            }
        }

        [Inline]
        public static uint DeserializeSystemUInt32(XElement xElement)
        {
            return XmlConvert.ToUInt32(xElement.Value);
        }

        [Inline]
        public static uint DeserializeSystemUInt32(XAttribute xAttribute)
        {
            return XmlConvert.ToUInt32(xAttribute.Value);
        }

        [Inline]
        public static uint DeserializeSystemUInt32(JSONObject jsonObject, string name)
        {
            return jsonObject.GetUInt32(name);
        }

        public static uint[] DeserializeSystemUInt32Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemUInt32Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemUInt32Array(jsonArray);
            }
        }

        public static uint[] DeserializeSystemUInt32Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static uint[] DeserializeSystemUInt32Array(JSONArray jsonArray)
        {
            var result = new uint[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (uint)jsonArray.OptLong(i);
            }

            return result;
        }
        #endregion

        #region UInt64
        public static Stream SerializeSystemUInt64(ulong obj, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt64"));
                var xDocument = new XDocument(root);
                root.Add(XmlConvert.ToString(obj));
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(obj.ToJsonString());
            }
        }

        public static Stream SerializeSystemUInt64Array(ulong[] objs, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var root = new XElement(XName.Get("UInt64Array"));
                var xDocument = new XDocument(root);
                foreach (var obj in objs)
                {
                    var child = new XElement(XName.Get("UInt64"));
                    child.Add(XmlConvert.ToString(obj));
                }
                var stream = GetStream(xDocument);
                return stream;
            }
            else
            {
                return GetStream(objs.ToJsonString());
            }
        }

        public static void SerializeSystemUInt64(ulong obj, XElement xElement)
        {
            xElement.Value = XmlConvert.ToString(obj);
        }

        public static void SerializeSystemUInt64(ulong[] objs, JSONArray jsonArray)
        {
            foreach (var obj in objs)
            {
                jsonArray.Put(obj);
            }
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, ulong obj)
        {
            jsonObject.Put(name, obj);
        }

        public static ulong DeserializeSystemUInt64(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream); 
                return DeserializeSystemUInt64(doc.Root);
            }
            else
            {
                var json = GetString(stream);
                return ulong.Parse(json);
            }
        }

        [Inline]
        public static ulong DeserializeSystemUInt64(XElement xElement)
        {
            return XmlConvert.ToUInt64(xElement.Value);
        }

        [Inline]
        public static ulong DeserializeSystemUInt64(XAttribute xAttribute)
        {
            return XmlConvert.ToUInt64(xAttribute.Value);
        }

        [Inline]
        public static ulong DeserializeSystemUInt64(JSONObject jsonObject, string name)
        {
            return jsonObject.GetUInt64(name);
        }

        public static ulong[] DeserializeSystemUInt64Array(Stream stream, SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            if (IsXml(serializationFormat, webMessageFormat))
            {
                var doc = GetXDocument(stream);
                return DeserializeSystemUInt64Array(doc.Root);
            }
            else
            {
                var jsonArray = GetJSONArray(stream);
                return DeserializeSystemUInt64Array(jsonArray);
            }
        }

        public static ulong[] DeserializeSystemUInt64Array(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public static ulong[] DeserializeSystemUInt64Array(JSONArray jsonArray)
        {
            var result = new ulong[jsonArray.Length()];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (ulong)jsonArray.OptLong(i);
            }

            return result;
        }
        #endregion

        private static bool IsXml(SerializationFormat serializationFormat, WebMessageFormat webMessageFormat)
        {
            switch (serializationFormat)
            {
                case SerializationFormat.DataContract:
                    switch (webMessageFormat)
                    {
                        case WebMessageFormat.Xml:
                            return true;

                        case WebMessageFormat.Json:
                            return false;

                        default:
                            throw new NotSupportedException("Unknown WebMessageFormat found: " + webMessageFormat);
                    }
                case SerializationFormat.XmlSerializer:
                    switch (webMessageFormat)
                    {
                        case WebMessageFormat.Xml:
                            return true;

                        case WebMessageFormat.Json:
                            throw new NotSupportedException("WebMessageFormat.Json is not supported in relation with XmlSerializerFormatAttribute");

                        default:
                            throw new NotSupportedException("Unknown WebMessageFormat found: " + webMessageFormat);
                    }
                default:
                    throw new NotSupportedException("Unknown SerializationFormat found: " + serializationFormat);
            }
        }

        protected static XDocument GetXDocument(Stream stream)
        {
            return XDocument.Load(stream);
        }

        protected static Stream GetStream(XDocument document)
        {
            var stream = new MemoryStream();
            document.Save(stream);
            return stream;
        }

        protected static JSONObject GetJSONObject(Stream stream)
        {
            var json = GetString(stream);
            return new JSONObject(json);
        }

        protected static JSONArray GetJSONArray(Stream stream)
        {
            var json = GetString(stream);
            return new JSONArray(json);
        }

        protected static long GetLong(Stream stream)
        {
            var json = GetString(stream);
            return long.Parse(json);
        }

        [Inline]
        private static string GetString(Stream stream)
        {
            return GetString(stream, false);
        }

        private static string GetString(Stream stream, bool unquote)
        {
            byte[] bytes;
            MemoryStream memStream;
            if ((memStream = stream as MemoryStream) != null)
            {
                bytes = memStream.ToArray();
            }
            else if (stream.CanSeek)
            {
                bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
            }
            else
            {
                memStream = new MemoryStream();
                stream.CopyTo(memStream);
                bytes = memStream.ToArray();
            }

            var json = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            return unquote ? JsonConvert.Unescape(json) : json;
        }

        [Inline]
        protected static Stream GetStream(JSONObject jsonObject)
        {
            var json = jsonObject.ToString();
            return GetStream(json);
        }

        [Inline]
        protected static Stream GetStream(JSONArray jsonArray)
        {
            var json = jsonArray.ToString();
            return GetStream(json);
        }

        protected static Stream GetStream(string json)
        {
            var bytes = Encoding.UTF8.GetBytes(json);
            var stream = new MemoryStream(bytes);
            return stream;
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, JSONObject obj)
        {
            jsonObject.Put(name, obj);
        }

        [Inline]
        protected static void AddToJsonObject(JSONObject jsonObject, string name, JSONArray obj)
        {
            jsonObject.Put(name, obj);
        }

        [Inline]
        protected static void AddToJsonArray(JSONArray jsonArray, JSONObject obj)
        {
            jsonArray.Put(obj);
        }

        [Inline]  //enum support
        protected static void AddToJsonArray(JSONArray jsonArray, ulong obj)
        {
            jsonArray.Put((long)obj);
        }

        [Inline]  //enum support
        protected static void AddToJsonArray(JSONArray jsonArray, long obj)
        {
            jsonArray.Put(obj);
        }
    }
}

