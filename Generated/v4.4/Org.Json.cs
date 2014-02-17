// Copyright (C) 2014 dot42
//
// Original filename: Org.Json.cs
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
#pragma warning disable 1717
namespace Org.Json
{
		/// <summary>
		/// <para>Thrown to indicate a problem with the JSON API. Such problems include: <ul><li><para>Attempts to parse or construct malformed documents </para></li><li><para>Use of null as a name </para></li><li><para>Use of numeric types not available to JSON, such as NaNs or infinities. </para></li><li><para>Lookups using an out of range index or nonexistent name </para></li><li><para>Type mismatches on lookups </para></li></ul></para><para>Although this is a checked exception, it is rarely recoverable. Most callers should simply wrap this exception in an unchecked exception and rethrow: <pre>  public JSONArray toJSONObject() {
		///        try {
		///            JSONObject result = new JSONObject();
		///            ...
		///        } catch (JSONException e) {
		///            throw new RuntimeException(e);
		///        }
		///    }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// org/json/JSONException
		/// </java-name>
		[Dot42.DexImport("org/json/JSONException", AccessFlags = 33)]
		public partial class JSONException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JSONException(string s) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JSONException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Implements JSONObject#toString and JSONArray#toString. Most application developers should use those methods directly and disregard this API. For example:<pre>
		///    JSONObject object = ...
		///    String json = object.toString();</pre></para><para>Stringers only encode well-formed JSON strings. In particular: <ul><li><para>The stringer must have exactly one top-level array or object. </para></li><li><para>Lexical scopes must be balanced: every call to array must have a matching call to endArray and every call to object must have a matching call to endObject. </para></li><li><para>Arrays may not contain keys (property names). </para></li><li><para>Objects must alternate keys (property names) and values. </para></li><li><para>Values are inserted with either literal value calls, or by nesting arrays or objects. </para></li></ul>Calls that would result in a malformed JSON string will fail with a JSONException.</para><para>This class provides no facility for pretty-printing (ie. indenting) output. To encode indented output, use JSONObject#toString(int) or JSONArray#toString(int).</para><para>Some implementations of the API support at most 20 levels of nesting. Attempts to create more than 20 levels of nesting may fail with a JSONException.</para><para>Each stringer may be used to encode a single top level value. Instances of this class are not thread safe. Although this class is nonfinal, it was not designed for inheritance and should not be subclassed. In particular, self-use by overrideable methods is not specified. See <b>Effective Java</b> Item 17, "Design and Document or inheritance or else prohibit it" for further information. </para>    
		/// </summary>
		/// <java-name>
		/// org/json/JSONStringer
		/// </java-name>
		[Dot42.DexImport("org/json/JSONStringer", AccessFlags = 33)]
		public partial class JSONStringer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public JSONStringer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begins encoding a new array. Each call to this method must be paired with a call to endArray.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this stringer. </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Array() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <summary>
				/// <para>Ends encoding the current array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this stringer. </para>
				/// </returns>
				/// <java-name>
				/// endArray
				/// </java-name>
				[Dot42.DexImport("endArray", "()Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer EndArray() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <summary>
				/// <para>Begins encoding a new object. Each call to this method must be paired with a call to endObject.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this stringer. </para>
				/// </returns>
				/// <java-name>
				/// object
				/// </java-name>
				[Dot42.DexImport("object", "()Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Object() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <summary>
				/// <para>Ends encoding the current object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this stringer. </para>
				/// </returns>
				/// <java-name>
				/// endObject
				/// </java-name>
				[Dot42.DexImport("endObject", "()Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer EndObject() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(Ljava/lang/Object;)Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Value(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(Z)Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Value(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(D)Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Value(double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "(J)Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Value(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <summary>
				/// <para>Encodes the key (property name) to this stringer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this stringer. </para>
				/// </returns>
				/// <java-name>
				/// key
				/// </java-name>
				[Dot42.DexImport("key", "(Ljava/lang/String;)Lorg/json/JSONStringer;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONStringer Key(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONStringer);
				}

				/// <summary>
				/// <para>Returns the encoded JSON string.</para><para>If invoked with unterminated arrays or unclosed objects, this method's return value is undefined.</para><para><b>Warning:</b> although it contradicts the general contract of Object#toString, this method returns null if the stringer contains no data. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>A modifiable set of name/value mappings. Names are unique, non-null strings. Values may be any mix of JSONObjects, JSONArrays, Strings, Booleans, Integers, Longs, Doubles or NULL. Values may not be <c> null </c> , NaNs, infinities, or of any type not listed here.</para><para>This class can coerce values to another type when requested. <ul><li><para>When the requested type is a boolean, strings will be coerced using a case-insensitive comparison to "true" and "false". </para></li><li><para>When the requested type is a double, other Number types will be coerced using doubleValue. Strings that can be coerced using Double#valueOf(String) will be. </para></li><li><para>When the requested type is an int, other Number types will be coerced using intValue. Strings that can be coerced using Double#valueOf(String) will be, and then cast to int. </para></li><li><para>When the requested type is a long, other Number types will be coerced using longValue. Strings that can be coerced using Double#valueOf(String) will be, and then cast to long. This two-step conversion is lossy for very large values. For example, the string "9223372036854775806" yields the long 9223372036854775807. </para></li><li><para>When the requested type is a String, other non-null values will be coerced using String#valueOf(Object). Although null cannot be coerced, the sentinel value JSONObject#NULL is coerced to the string "null". </para></li></ul></para><para>This class can look up both mandatory and optional values: <ul><li><para>Use <code>get<b>Type</b>()</code> to retrieve a mandatory value. This fails with a <c> JSONException </c> if the requested name has no value or if the value cannot be coerced to the requested type. </para></li><li><para>Use <code>opt<b>Type</b>()</code> to retrieve an optional value. This returns a system- or user-supplied default if the requested name has no value or if the value cannot be coerced to the requested type. </para></li></ul></para><para><b>Warning:</b> this class represents null in two incompatible ways: the standard Java <c> null </c> reference, and the sentinel value JSONObject#NULL. In particular, calling <c> put(name, null) </c> removes the named entry from the object but <c> put(name, JSONObject.NULL) </c> stores an entry whose value is <c> JSONObject.NULL </c> .</para><para>Instances of this class are not thread safe. Although this class is nonfinal, it was not designed for inheritance and should not be subclassed. In particular, self-use by overrideable methods is not specified. See <b>Effective Java</b> Item 17, "Design and Document or inheritance or else   prohibit it" for further information. </para>    
		/// </summary>
		/// <java-name>
		/// org/json/JSONObject
		/// </java-name>
		[Dot42.DexImport("org/json/JSONObject", AccessFlags = 33)]
		public partial class JSONObject
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A sentinel value used to explicitly define a name with no value. Unlike <c> null </c> , names with this value: <ul><li><para>show up in the names array </para></li><li><para>show up in the keys iterator </para></li><li><para>return <c> true </c> for has(String) </para></li><li><para>do not throw on get(String) </para></li><li><para>are included in the encoded JSON string. </para></li></ul></para><para>This value violates the general contract of Object#equals by returning true when compared to <c> null </c> . Its toString method returns "null". </para>        
				/// </summary>
				/// <java-name>
				/// NULL
				/// </java-name>
				[Dot42.DexImport("NULL", "Ljava/lang/Object;", AccessFlags = 25)]
				public static readonly object NULL;
				/// <summary>
				/// <para>Creates a <c> JSONObject </c> with no name/value mappings. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public JSONObject() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONObject </c> with name/value mappings from the next object in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1)]
				public JSONObject(global::Java.Util.IMap<object, object> readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONObject </c> with name/value mappings from the next object in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/json/JSONTokener;)V", AccessFlags = 1)]
				public JSONObject(global::Org.Json.JSONTokener readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONObject </c> with name/value mappings from the next object in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JSONObject(string readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONObject </c> by copying mappings for the listed names from the given object. Names that aren't present in <c> copyFrom </c> will be skipped. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/json/JSONObject;[Ljava/lang/String;)V", AccessFlags = 1)]
				public JSONObject(global::Org.Json.JSONObject copyFrom, string[] names) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of name/value mappings in this object. </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Z)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Put(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;D)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Put(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;I)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Put(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;J)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Put(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Put(string @string, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Equivalent to <c> put(name, value) </c> when both parameters are non-null; does nothing otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// putOpt
				/// </java-name>
				[Dot42.DexImport("putOpt", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject PutOpt(string name, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the array already mapped to <c> name </c> . If this object has no mapping for <c> name </c> , this inserts a new mapping. If the mapping exists but its value is not an array, the existing and new values are inserted in order into a new array which is itself mapped to <c> name </c> . In aggregate, this allows values to be added to a mapping one at a time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// accumulate
				/// </java-name>
				[Dot42.DexImport("accumulate", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject Accumulate(string name, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Removes the named mapping if it exists; does nothing otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value previously mapped by <c> name </c> , or null if there was no such mapping. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Remove(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns true if this object has no mapping for <c> name </c> or if it has a mapping whose value is NULL. </para>        
				/// </summary>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsNull(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this object has a mapping for <c> name </c> . The mapping may be NULL. </para>        
				/// </summary>
				/// <java-name>
				/// has
				/// </java-name>
				[Dot42.DexImport("has", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Has(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> , or null if no such mapping exists. </para>        
				/// </summary>
				/// <java-name>
				/// opt
				/// </java-name>
				[Dot42.DexImport("opt", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Opt(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a boolean or can be coerced to a boolean.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a boolean or can be coerced to a boolean. Returns false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optBoolean
				/// </java-name>
				[Dot42.DexImport("optBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool OptBoolean(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a boolean or can be coerced to a boolean. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optBoolean
				/// </java-name>
				[Dot42.DexImport("optBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool OptBoolean(string name, bool fallback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a double or can be coerced to a double.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1)]
				public virtual double GetDouble(string name) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a double or can be coerced to a double. Returns <c> NaN </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optDouble
				/// </java-name>
				[Dot42.DexImport("optDouble", "(Ljava/lang/String;)D", AccessFlags = 1)]
				public virtual double OptDouble(string name) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a double or can be coerced to a double. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optDouble
				/// </java-name>
				[Dot42.DexImport("optDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double OptDouble(string name, double fallback) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is an int or can be coerced to an int.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetInt(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is an int or can be coerced to an int. Returns 0 otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optInt
				/// </java-name>
				[Dot42.DexImport("optInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int OptInt(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is an int or can be coerced to an int. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optInt
				/// </java-name>
				[Dot42.DexImport("optInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int OptInt(string name, int fallback) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a long or can be coerced to a long. Note that JSON represents numbers as doubles, so this is ; use strings to transfer numbers via JSON.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1)]
				public virtual long GetLong(string name) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a long or can be coerced to a long. Returns 0 otherwise. Note that JSON represents numbers as doubles, so this is ; use strings to transfer numbers via JSON. </para>        
				/// </summary>
				/// <java-name>
				/// optLong
				/// </java-name>
				[Dot42.DexImport("optLong", "(Ljava/lang/String;)J", AccessFlags = 1)]
				public virtual long OptLong(string name) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a long or can be coerced to a long. Returns <c> fallback </c> otherwise. Note that JSON represents numbers as doubles, so this is ; use strings to transfer numbers via JSON. </para>        
				/// </summary>
				/// <java-name>
				/// optLong
				/// </java-name>
				[Dot42.DexImport("optLong", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long OptLong(string name, long fallback) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists, coercing it if necessary.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists, coercing it if necessary. Returns the empty string if no such mapping exists. </para>        
				/// </summary>
				/// <java-name>
				/// optString
				/// </java-name>
				[Dot42.DexImport("optString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string OptString(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists, coercing it if necessary. Returns <c> fallback </c> if no such mapping exists. </para>        
				/// </summary>
				/// <java-name>
				/// optString
				/// </java-name>
				[Dot42.DexImport("optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string OptString(string name, string fallback) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a <c>       JSONArray </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getJSONArray
				/// </java-name>
				[Dot42.DexImport("getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray GetJSONArray(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a <c>       JSONArray </c> . Returns null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optJSONArray
				/// </java-name>
				[Dot42.DexImport("optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray OptJSONArray(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a <c>       JSONObject </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getJSONObject
				/// </java-name>
				[Dot42.DexImport("getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject GetJSONObject(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Returns the value mapped by <c> name </c> if it exists and is a <c>       JSONObject </c> . Returns null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optJSONObject
				/// </java-name>
				[Dot42.DexImport("optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject OptJSONObject(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Returns an array with the values corresponding to <c> names </c> . The array contains null for names that aren't mapped. This method returns null if <c> names </c> is either null or empty. </para>        
				/// </summary>
				/// <java-name>
				/// toJSONArray
				/// </java-name>
				[Dot42.DexImport("toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray ToJSONArray(global::Org.Json.JSONArray names) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns an iterator of the <c> String </c> names in this object. The returned iterator supports remove, which will remove the corresponding mapping from this object. If this object is modified after the iterator is returned, the iterator's behavior is undefined. The order of the keys is undefined. </para>        
				/// </summary>
				/// <java-name>
				/// keys
				/// </java-name>
				[Dot42.DexImport("keys", "()Ljava/util/Iterator;", AccessFlags = 1)]
				public virtual global::Java.Util.IIterator<object> Keys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<object>);
				}

				/// <summary>
				/// <para>Returns an array containing the string names in this object. This method returns null if this object contains no mappings. </para>        
				/// </summary>
				/// <java-name>
				/// names
				/// </java-name>
				[Dot42.DexImport("names", "()Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Names() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Encodes this object as a compact JSON string, such as: <pre>{"query":"Pizza","locations":[94043,90210]}</pre> </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes this object as a human readable JSON string for debugging, such as: <pre>
				///        {
				///            "query": "Pizza",
				///            "locations": [
				///                94043,
				///                90210
				///            ]
				///        }</pre></para><para></para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int indentSpaces) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes the number as a JSON string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// numberToString
				/// </java-name>
				[Dot42.DexImport("numberToString", "(Ljava/lang/Number;)Ljava/lang/String;", AccessFlags = 9)]
				public static string NumberToString(global::Java.Lang.Number number) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes <c> data </c> as a JSON string. This applies quotes and any necessary character escaping.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// quote
				/// </java-name>
				[Dot42.DexImport("quote", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Quote(string data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Wrap(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>Parses a JSON () encoded string into the corresponding object. Most clients of this class will use only need the constructor and nextValue method. Example usage: <pre>
		///    String json = "{"<ul>
		/// <li><para>"  \"query": "Pizza", "
		///            + "  "locations": [ 94043, 90210 ] "
		///            + "}";</para></li></ul>
		/// 
		/// 
		///    JSONObject object = (JSONObject) new JSONTokener(json).nextValue();
		///    String query = object.getString("query");
		///    JSONArray locations = object.getJSONArray("locations");</pre></para><para>For best interoperability and performance use JSON that complies with RFC 4627, such as that generated by JSONStringer. For legacy reasons this parser is lenient, so a successful parse does not indicate that the input string was valid JSON. All of the following syntax errors will be ignored: <ul><li><para>End of line comments starting with <c> // </c> or <c> # </c> and ending with a newline character. </para></li><li><para>C-style comments starting with <c> /* </c> and ending with <c> * </c> <c> / </c> . Such comments may not be nested. </para></li><li><para>Strings that are unquoted or <c> 'single quoted' </c> . </para></li><li><para>Hexadecimal integers prefixed with <c> 0x </c> or <c> 0X </c> . </para></li><li><para>Octal integers prefixed with <c> 0 </c> . </para></li><li><para>Array elements separated by <c> ; </c> . </para></li><li><para>Unnecessary array separators. These are interpreted as if null was the omitted value. </para></li><li><para>Key-value pairs separated by <c> = </c> or <c> =&gt; </c> . </para></li><li><para>Key-value pairs separated by <c> ; </c> . </para></li></ul></para><para>Each tokener may be used to parse a single JSON string. Instances of this class are not thread safe. Although this class is nonfinal, it was not designed for inheritance and should not be subclassed. In particular, self-use by overrideable methods is not specified. See <b>Effective Java</b> Item 17, "Design and Document or inheritance or else prohibit it" for further information. </para>    
		/// </summary>
		/// <java-name>
		/// org/json/JSONTokener
		/// </java-name>
		[Dot42.DexImport("org/json/JSONTokener", AccessFlags = 33)]
		public partial class JSONTokener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JSONTokener(string @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the next value from the input.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a JSONObject, JSONArray, String, Boolean, Integer, Long, Double or JSONObject#NULL. </para>
				/// </returns>
				/// <java-name>
				/// nextValue
				/// </java-name>
				[Dot42.DexImport("nextValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object NextValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the string up to but not including <c> quote </c> , unescaping any character escape sequences encountered along the way. The opening quote should have already been read. This consumes the closing quote, but does not include it in the returned string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// nextString
				/// </java-name>
				[Dot42.DexImport("nextString", "(C)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextString(char quote) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an exception containing the given message plus the current position and the entire input string. </para>        
				/// </summary>
				/// <java-name>
				/// syntaxError
				/// </java-name>
				[Dot42.DexImport("syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONException SyntaxError(string message) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONException);
				}

				/// <summary>
				/// <para>Returns the current position and the entire input string. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns true until the input has been exhausted. </para>        
				/// </summary>
				/// <java-name>
				/// more
				/// </java-name>
				[Dot42.DexImport("more", "()Z", AccessFlags = 1)]
				public virtual bool More() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the next available character, or the null character '\0' if all input has been exhausted. The return value of this method is ambiguous for JSON strings that contain the character '\0'. </para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()C", AccessFlags = 1)]
				public virtual char Next() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the next <c> length </c> characters of the input.</para><para>The returned string shares its backing character array with this tokener's input string. If a reference to the returned string may be held indefinitely, you should use <c> new String(result) </c> to copy it first to avoid memory leaks.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(C)C", AccessFlags = 1)]
				public virtual char Next(char length) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the next character that is not whitespace and does not belong to a comment. If the input is exhausted before such a character can be found, the null character '\0' is returned. The return value of this method is ambiguous for JSON strings that contain the character '\0'. </para>        
				/// </summary>
				/// <java-name>
				/// nextClean
				/// </java-name>
				[Dot42.DexImport("nextClean", "()C", AccessFlags = 1)]
				public virtual char NextClean() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the next <c> length </c> characters of the input.</para><para>The returned string shares its backing character array with this tokener's input string. If a reference to the returned string may be held indefinitely, you should use <c> new String(result) </c> to copy it first to avoid memory leaks.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Next(int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextTo
				/// </java-name>
				[Dot42.DexImport("nextTo", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextTo(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// nextTo
				/// </java-name>
				[Dot42.DexImport("nextTo", "(C)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextTo(char @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Advances past all input up to and including the next occurrence of <c> thru </c> . If the remaining input doesn't contain <c> thru </c> , the input is exhausted. </para>        
				/// </summary>
				/// <java-name>
				/// skipPast
				/// </java-name>
				[Dot42.DexImport("skipPast", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkipPast(string thru) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Advances past all input up to but not including the next occurrence of <c> to </c> . If the remaining input doesn't contain <c> to </c> , the input is unchanged. </para>        
				/// </summary>
				/// <java-name>
				/// skipTo
				/// </java-name>
				[Dot42.DexImport("skipTo", "(C)C", AccessFlags = 1)]
				public virtual char SkipTo(char to) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Unreads the most recent character of input. If no input characters have been read, the input is unchanged. </para>        
				/// </summary>
				/// <java-name>
				/// back
				/// </java-name>
				[Dot42.DexImport("back", "()V", AccessFlags = 1)]
				public virtual void Back() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the integer [0..15] value for the given hex character, or -1 for non-hex input.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// dehexchar
				/// </java-name>
				[Dot42.DexImport("dehexchar", "(C)I", AccessFlags = 9)]
				public static int Dehexchar(char hex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal JSONTokener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A dense indexed sequence of values. Values may be any mix of JSONObjects, other JSONArrays, Strings, Booleans, Integers, Longs, Doubles, <c> null </c> or JSONObject#NULL. Values may not be NaNs, infinities, or of any type not listed here.</para><para><c> JSONArray </c> has the same type coercion behavior and optional/mandatory accessors as JSONObject. See that class' documentation for details.</para><para><b>Warning:</b> this class represents null in two incompatible ways: the standard Java <c> null </c> reference, and the sentinel value JSONObject#NULL. In particular, <c> get </c> fails if the requested index holds the null reference, but succeeds if it holds <c> JSONObject.NULL </c> .</para><para>Instances of this class are not thread safe. Although this class is nonfinal, it was not designed for inheritance and should not be subclassed. In particular, self-use by overridable methods is not specified. See <b>Effective Java</b> Item 17, "Design and Document or inheritance or else   prohibit it" for further information. </para>    
		/// </summary>
		/// <java-name>
		/// org/json/JSONArray
		/// </java-name>
		[Dot42.DexImport("org/json/JSONArray", AccessFlags = 33)]
		public partial class JSONArray
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> JSONArray </c> with no values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public JSONArray() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONArray </c> with values from the next array in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1)]
				public JSONArray(global::Java.Util.ICollection<object> readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONArray </c> with values from the next array in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/json/JSONTokener;)V", AccessFlags = 1)]
				public JSONArray(global::Org.Json.JSONTokener readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONArray </c> with values from the next array in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public JSONArray(string readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> JSONArray </c> with values from the next array in the tokener.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public JSONArray(object readFrom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of values in this array. </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the end of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Z)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(bool value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the end of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(D)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(double value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the end of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(I)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the end of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(J)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(long value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Appends <c> value </c> to the end of this array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Sets the value at <c> index </c> to <c> value </c> , null padding this array to the required length if necessary. If a value already exists at <c>       index </c> , it will be replaced.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IZ)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int index, bool value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Sets the value at <c> index </c> to <c> value </c> , null padding this array to the required length if necessary. If a value already exists at <c>       index </c> , it will be replaced.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ID)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int index, double value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Sets the value at <c> index </c> to <c> value </c> , null padding this array to the required length if necessary. If a value already exists at <c>       index </c> , it will be replaced.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(II)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int index, int value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Sets the value at <c> index </c> to <c> value </c> , null padding this array to the required length if necessary. If a value already exists at <c>       index </c> , it will be replaced.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IJ)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int index, long value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Sets the value at <c> index </c> to <c> value </c> , null padding this array to the required length if necessary. If a value already exists at <c>       index </c> , it will be replaced.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this array. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ILjava/lang/Object;)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray Put(int index, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns true if this array has no value at <c> index </c> , or if its value is the <c> null </c> reference or JSONObject#NULL. </para>        
				/// </summary>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public virtual bool IsNull(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> , or null if the array has no value at <c> index </c> . </para>        
				/// </summary>
				/// <java-name>
				/// opt
				/// </java-name>
				[Dot42.DexImport("opt", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Opt(int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Remove(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a boolean or can be coerced to a boolean.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a boolean or can be coerced to a boolean. Returns false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optBoolean
				/// </java-name>
				[Dot42.DexImport("optBoolean", "(I)Z", AccessFlags = 1)]
				public virtual bool OptBoolean(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a boolean or can be coerced to a boolean. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optBoolean
				/// </java-name>
				[Dot42.DexImport("optBoolean", "(IZ)Z", AccessFlags = 1)]
				public virtual bool OptBoolean(int index, bool fallback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a double or can be coerced to a double.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public virtual double GetDouble(int index) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a double or can be coerced to a double. Returns <c> NaN </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optDouble
				/// </java-name>
				[Dot42.DexImport("optDouble", "(I)D", AccessFlags = 1)]
				public virtual double OptDouble(int index) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a double or can be coerced to a double. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optDouble
				/// </java-name>
				[Dot42.DexImport("optDouble", "(ID)D", AccessFlags = 1)]
				public virtual double OptDouble(int index, double fallback) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is an int or can be coerced to an int.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public virtual int GetInt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is an int or can be coerced to an int. Returns 0 otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optInt
				/// </java-name>
				[Dot42.DexImport("optInt", "(I)I", AccessFlags = 1)]
				public virtual int OptInt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is an int or can be coerced to an int. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optInt
				/// </java-name>
				[Dot42.DexImport("optInt", "(II)I", AccessFlags = 1)]
				public virtual int OptInt(int index, int fallback) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a long or can be coerced to a long.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public virtual long GetLong(int index) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a long or can be coerced to a long. Returns 0 otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optLong
				/// </java-name>
				[Dot42.DexImport("optLong", "(I)J", AccessFlags = 1)]
				public virtual long OptLong(int index) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a long or can be coerced to a long. Returns <c> fallback </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optLong
				/// </java-name>
				[Dot42.DexImport("optLong", "(IJ)J", AccessFlags = 1)]
				public virtual long OptLong(int index, long fallback) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists, coercing it if necessary.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists, coercing it if necessary. Returns the empty string if no such value exists. </para>        
				/// </summary>
				/// <java-name>
				/// optString
				/// </java-name>
				[Dot42.DexImport("optString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string OptString(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists, coercing it if necessary. Returns <c> fallback </c> if no such value exists. </para>        
				/// </summary>
				/// <java-name>
				/// optString
				/// </java-name>
				[Dot42.DexImport("optString", "(ILjava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string OptString(int index, string fallback) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a <c>       JSONArray </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getJSONArray
				/// </java-name>
				[Dot42.DexImport("getJSONArray", "(I)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray GetJSONArray(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a <c>       JSONArray </c> . Returns null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optJSONArray
				/// </java-name>
				[Dot42.DexImport("optJSONArray", "(I)Lorg/json/JSONArray;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONArray OptJSONArray(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONArray);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a <c>       JSONObject </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getJSONObject
				/// </java-name>
				[Dot42.DexImport("getJSONObject", "(I)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject GetJSONObject(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Returns the value at <c> index </c> if it exists and is a <c>       JSONObject </c> . Returns null otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// optJSONObject
				/// </java-name>
				[Dot42.DexImport("optJSONObject", "(I)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject OptJSONObject(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Returns a new object whose values are the values in this array, and whose names are the values in <c> names </c> . Names and values are paired up by index from 0 through to the shorter array's length. Names that are not strings will be coerced to strings. This method returns null if either array is empty. </para>        
				/// </summary>
				/// <java-name>
				/// toJSONObject
				/// </java-name>
				[Dot42.DexImport("toJSONObject", "(Lorg/json/JSONArray;)Lorg/json/JSONObject;", AccessFlags = 1)]
				public virtual global::Org.Json.JSONObject ToJSONObject(global::Org.Json.JSONArray names) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Json.JSONObject);
				}

				/// <summary>
				/// <para>Returns a new string by alternating this array's values with <c>       separator </c> . This array's string values are quoted and have their special characters escaped. For example, the array containing the strings '12" pizza', 'taco' and 'soda' joined on '+' returns this: <pre>"12\" pizza"+"taco"+"soda"</pre> </para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Join(string separator) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes this array as a compact JSON string, such as: <pre>[94043,90210]</pre> </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Encodes this array as a human readable JSON string for debugging, such as: <pre>
				///        [
				///            94043,
				///            90210
				///        ]</pre></para><para></para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int indentSpaces) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

}


