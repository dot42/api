// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Datatype.cs
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
namespace Javax.Xml.Datatype
{
		/// <summary>
		/// <para>Factory that creates new <code>javax.xml.datatype</code> <code>Object</code>s that map XML to/from Java <code>Object</code>s.</para><para>newInstance() is used to create a new <code>DatatypeFactory</code>. The following implementation resolution mechanisms are used in the following order:</para><para><ol><li><para>If the system property specified by DATATYPEFACTORY_PROPERTY, "&lt;code&gt;javax.xml.datatype.DatatypeFactory&lt;/code&gt;", exists, a class with the name of the property's value is instantiated. Any Exception thrown during the instantiation process is wrapped as a DatatypeConfigurationException.  </para></li><li><para>If the file ${JAVA_HOME}/lib/jaxp.properties exists, it is loaded in a java.util.Properties <code>Object</code>. The <code>Properties</code> <code>Object </code> is then queried for the property as documented in the prior step and processed as documented in the prior step.  </para></li><li><para>The services resolution mechanism is used, e.g. <code>META-INF/services/java.xml.datatype.DatatypeFactory</code>. Any Exception thrown during the instantiation process is wrapped as a DatatypeConfigurationException.  </para></li><li><para>The final mechanism is to attempt to instantiate the <code>Class</code> specified by DATATYPEFACTORY_IMPLEMENTATION_CLASS, "&lt;code&gt;javax.xml.datatype.DatatypeFactoryImpl&lt;/code&gt;". Any Exception thrown during the instantiation process is wrapped as a DatatypeConfigurationException.  </para></li></ol></para><para>Note that you must supply your own implementation (such as Xerces); Android does not ship with a default implementation.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>884950 </para>, <title>Date:</title><para>2009-11-27 10:46:18 -0800 (Fri, 27 Nov 2009) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/datatype/DatatypeFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeFactory", AccessFlags = 1057)]
		public abstract partial class DatatypeFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default property name as defined in JSR 206: Java(TM) API for XML Processing (JAXP) 1.3.</para><para>Default value is <code>javax.xml.datatype.DatatypeFactory</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DATATYPEFACTORY_PROPERTY
				/// </java-name>
				[Dot42.DexImport("DATATYPEFACTORY_PROPERTY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DATATYPEFACTORY_PROPERTY = "javax.xml.datatype.DatatypeFactory";
				/// <summary>
				/// <para>Default implementation class name as defined in JSR 206: Java(TM) API for XML Processing (JAXP) 1.3.</para><para>Default value is <code>org.apache.xerces.jaxp.datatype.DatatypeFactoryImpl</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DATATYPEFACTORY_IMPLEMENTATION_CLASS
				/// </java-name>
				[Dot42.DexImport("DATATYPEFACTORY_IMPLEMENTATION_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DATATYPEFACTORY_IMPLEMENTATION_CLASS;
				/// <summary>
				/// <para>Protected constructor to prevent instantiation outside of package.</para><para>Use newInstance() to create a <code>DatatypeFactory</code>.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DatatypeFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtain a new instance of a <code>DatatypeFactory</code>.</para><para>The implementation resolution mechanisms are  in this <code>Class</code>'s documentation.</para><para>Note that you must supply your own implementation (such as Xerces); Android does not ship with a default implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New instance of a <code>DocumentBuilderFactory</code></para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/datatype/DatatypeFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Datatype.DatatypeFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.DatatypeFactory);
				}

				/// <summary>
				/// <para>Returns an instance of the named implementation of <c> DatatypeFactory </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Datatype.DatatypeFactory NewInstance(string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.DatatypeFactory);
				}

				/// <java-name>
				/// newDuration
				/// </java-name>
				[Dot42.DexImport("newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration NewDuration(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDuration
				/// </java-name>
				[Dot42.DexImport("newDuration", "(J)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration NewDuration(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDuration
				/// </java-name>
				[Dot42.DexImport("newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Bi" +
    "gInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Durati" +
    "on;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration NewDuration(bool boolean, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3, global::Java.Math.BigInteger bigInteger4, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDuration
				/// </java-name>
				[Dot42.DexImport("newDuration", "(ZIIIIII)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDuration(bool boolean, int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationDayTime
				/// </java-name>
				[Dot42.DexImport("newDurationDayTime", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationDayTime(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationDayTime
				/// </java-name>
				[Dot42.DexImport("newDurationDayTime", "(J)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationDayTime(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationDayTime
				/// </java-name>
				[Dot42.DexImport("newDurationDayTime", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Bi" +
    "gInteger;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationDayTime(bool boolean, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationDayTime
				/// </java-name>
				[Dot42.DexImport("newDurationDayTime", "(ZIIII)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationDayTime(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationYearMonth
				/// </java-name>
				[Dot42.DexImport("newDurationYearMonth", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationYearMonth(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationYearMonth
				/// </java-name>
				[Dot42.DexImport("newDurationYearMonth", "(J)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationYearMonth(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationYearMonth
				/// </java-name>
				[Dot42.DexImport("newDurationYearMonth", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationYearMonth(bool boolean, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// newDurationYearMonth
				/// </java-name>
				[Dot42.DexImport("newDurationYearMonth", "(ZII)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration NewDurationYearMonth(bool boolean, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <summary>
				/// <para>Create a new instance of an <code>XMLGregorianCalendar</code>.</para><para>All date/time datatype fields set to DatatypeConstants#FIELD_UNDEFINED or null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>XMLGregorianCalendar</code> with all date/time datatype fields set to DatatypeConstants#FIELD_UNDEFINED or null. </para>
				/// </returns>
				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create an <code>XMLGregorianCalendar</code> from a GregorianCalendar.</para><para><table></table></para><para>Field by Field Conversion from GregorianCalendar to an XMLGregorianCalendar   </para><para><code>java.util.GregorianCalendar</code> field </para><para><code>javax.xml.datatype.XMLGregorianCalendar</code> field  &lt;/thead&gt; &lt;tbody&gt; </para><para><code>ERA == GregorianCalendar.BC ? -YEAR : YEAR</code> </para><para>XMLGregorianCalendar#setYear(int year)  </para><para><code>MONTH + 1</code> </para><para>XMLGregorianCalendar#setMonth(int month)  </para><para><code>DAY_OF_MONTH</code> </para><para>XMLGregorianCalendar#setDay(int day)  </para><para><code>HOUR_OF_DAY, MINUTE, SECOND, MILLISECOND</code> </para><para>XMLGregorianCalendar#setTime(int hour, int minute, int second, BigDecimal fractional)  </para><para><code>(ZONE_OFFSET + DST_OFFSET) / (60*1000)</code><br></br> <b>(in minutes)</b>  </para><para>XMLGregorianCalendar#setTimezone(int offset)<span><b>*</b></span>   &lt;/tbody&gt; </para><para><b>*</b>conversion loss of information. It is not possible to represent a <code>java.util.GregorianCalendar</code> daylight savings timezone id in the XML Schema 1.0 date/time datatype representation.</para><para>To compute the return value's <code>TimeZone</code> field, <ul><li><para>when <code>this.getTimezone() != FIELD_UNDEFINED</code>, create a <code>java.util.TimeZone</code> with a custom timezone id using the <code>this.getTimezone()</code>. </para></li><li><para>else use the <code>GregorianCalendar</code> default timezone value for the host is defined as specified by <code>java.util.TimeZone.getDefault()</code>.</para><para></para><para></para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para><code>XMLGregorianCalendar</code> created from <code>java.util.GregorianCalendar</code></para>
				/// </returns>
				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(string cal) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create an <code>XMLGregorianCalendar</code> from a GregorianCalendar.</para><para><table></table></para><para>Field by Field Conversion from GregorianCalendar to an XMLGregorianCalendar   </para><para><code>java.util.GregorianCalendar</code> field </para><para><code>javax.xml.datatype.XMLGregorianCalendar</code> field  &lt;/thead&gt; &lt;tbody&gt; </para><para><code>ERA == GregorianCalendar.BC ? -YEAR : YEAR</code> </para><para>XMLGregorianCalendar#setYear(int year)  </para><para><code>MONTH + 1</code> </para><para>XMLGregorianCalendar#setMonth(int month)  </para><para><code>DAY_OF_MONTH</code> </para><para>XMLGregorianCalendar#setDay(int day)  </para><para><code>HOUR_OF_DAY, MINUTE, SECOND, MILLISECOND</code> </para><para>XMLGregorianCalendar#setTime(int hour, int minute, int second, BigDecimal fractional)  </para><para><code>(ZONE_OFFSET + DST_OFFSET) / (60*1000)</code><br></br> <b>(in minutes)</b>  </para><para>XMLGregorianCalendar#setTimezone(int offset)<span><b>*</b></span>   &lt;/tbody&gt; </para><para><b>*</b>conversion loss of information. It is not possible to represent a <code>java.util.GregorianCalendar</code> daylight savings timezone id in the XML Schema 1.0 date/time datatype representation.</para><para>To compute the return value's <code>TimeZone</code> field, <ul><li><para>when <code>this.getTimezone() != FIELD_UNDEFINED</code>, create a <code>java.util.TimeZone</code> with a custom timezone id using the <code>this.getTimezone()</code>. </para></li><li><para>else use the <code>GregorianCalendar</code> default timezone value for the host is defined as specified by <code>java.util.TimeZone.getDefault()</code>.</para><para></para><para></para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para><code>XMLGregorianCalendar</code> created from <code>java.util.GregorianCalendar</code></para>
				/// </returns>
				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(global::Java.Util.GregorianCalendar cal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregor" +
    "ianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(global::Java.Math.BigInteger bigInteger, int int32, int int321, int int322, int int323, int int324, global::Java.Math.BigDecimal bigDecimal, int int325) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(IIIIIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

				/// <summary>
				/// <para>Create a Java representation of XML Schema builtin datatype <code>date</code> or <code>g*</code>.</para><para>For example, an instance of <code>gYear</code> can be created invoking this factory with <code>month</code> and <code>day</code> parameters set to DatatypeConstants#FIELD_UNDEFINED.</para><para>A DatatypeConstants#FIELD_UNDEFINED value indicates that field is not set.</para><para><para>DatatypeConstants::FIELD_UNDEFINED</para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>XMLGregorianCalendar</code> created from parameter values.</para>
				/// </returns>
				/// <java-name>
				/// newXMLGregorianCalendarDate
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarDate(int year, int month, int day, int timezone) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

				/// <summary>
				/// <para>Create a Java instance of XML Schema builtin datatype <code>time</code>.</para><para>A DatatypeConstants#FIELD_UNDEFINED value indicates that field is not set.</para><para><para>DatatypeConstants::FIELD_UNDEFINED </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>XMLGregorianCalendar</code> created from parameter values.</para>
				/// </returns>
				/// <java-name>
				/// newXMLGregorianCalendarTime
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int hours, int minutes, int seconds, int timezone) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

				/// <java-name>
				/// newXMLGregorianCalendarTime
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarTime", "(IIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int int32, int int321, int int322, global::Java.Math.BigDecimal bigDecimal, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

				/// <java-name>
				/// newXMLGregorianCalendarTime
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarTime", "(IIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

		}

		/// <summary>
		/// <para>Immutable representation of a time span as defined in the W3C XML Schema 1.0 specification.</para><para>A Duration object represents a period of Gregorian time, which consists of six fields (years, months, days, hours, minutes, and seconds) plus a sign (+/-) field.</para><para>The first five fields have non-negative (&gt;=0) integers or null (which represents that the field is not set), and the seconds field has a non-negative decimal or null. A negative sign indicates a negative duration.</para><para>This class provides a number of methods that make it easy to use for the duration datatype of XML Schema 1.0 with the errata.</para><para><h2>Order relationship</h2></para><para>Duration objects only have partial order, where two values A and B maybe either:</para><para><ol><li><para>A&lt;B (A is shorter than B) </para></li><li><para>A&gt;B (A is longer than B) </para></li><li><para>A==B (A and B are of the same duration) </para></li><li><para>A&lt;&gt;B (Comparison between A and B is indeterminate) </para></li></ol></para><para>For example, 30 days cannot be meaningfully compared to one month. The compare(Duration duration) method implements this relationship.</para><para>See the isLongerThan(Duration) method for details about the order relationship among <code>Duration</code> objects.</para><para><h2>Operations over Duration</h2></para><para>This class provides a set of basic arithmetic operations, such as addition, subtraction and multiplication. Because durations don't have total order, an operation could fail for some combinations of operations. For example, you cannot subtract 15 days from 1 month. See the javadoc of those methods for detailed conditions where this could happen.</para><para>Also, division of a duration by a number is not provided because the <code>Duration</code> class can only deal with finite precision decimal numbers. For example, one cannot represent 1 sec divided by 3.</para><para>However, you could substitute a division by 3 with multiplying by numbers such as 0.3 or 0.333.</para><para><h2>Range of allowed values</h2></para><para>Because some operations of <code>Duration</code> rely on Calendar even though Duration can hold very large or very small values, some of the methods may not work correctly on such <code>Duration</code>s. The impacted methods document their dependency on Calendar.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>759828 </para>, <title>Date:</title><para>2009-03-29 18:26:29 -0700 (Sun, 29 Mar 2009) </para><para>XMLGregorianCalendar::add(Duration) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/datatype/Duration
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/Duration", AccessFlags = 1057)]
		public abstract partial class Duration
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Duration() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the name of the XML Schema date/time type that this instance maps to. Type is computed based on fields that are set, i.e. isSet(DatatypeConstants.Field field) == <code>true</code>.</para><para><table></table></para><para>Required fields for XML Schema 1.0 Date/Time Datatypes.<br></br> <b>(timezone is optional for all date/time datatypes)</b>   &lt;/thead&gt; &lt;tbody&gt; </para><para>Datatype </para><para>year </para><para>month </para><para>day </para><para>hour </para><para>minute </para><para>second  </para><para>DatatypeConstants#DURATION </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DURATION_DAYTIME </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DURATION_YEARMONTH </para><para>X </para><para>X </para><para>&lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the following constants: DatatypeConstants#DURATION, DatatypeConstants#DURATION_DAYTIME or DatatypeConstants#DURATION_YEARMONTH.</para>
				/// </returns>
				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Namespace.QName GetXMLSchemaType() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Namespace.QName);
				}

				/// <summary>
				/// <para>Returns the sign of this duration in -1,0, or 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>-1 if this duration is negative, 0 if the duration is zero, and 1 if the duration is positive. </para>
				/// </returns>
				/// <java-name>
				/// getSign
				/// </java-name>
				[Dot42.DexImport("getSign", "()I", AccessFlags = 1025)]
				public abstract int GetSign() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the years value of this <code>Duration</code> as an <code>int</code> or <code>0</code> if not present.</para><para><code>getYears()</code> is a convenience method for getField(DatatypeConstants.YEARS).</para><para>As the return value is an <code>int</code>, an incorrect value will be returned for <code>Duration</code>s with years that go beyond the range of an <code>int</code>. Use getField(DatatypeConstants.YEARS) to avoid possible loss of precision.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>If the years field is present, return its value as an <code>int</code>, else return <code>0</code>. </para>
				/// </returns>
				/// <java-name>
				/// getYears
				/// </java-name>
				[Dot42.DexImport("getYears", "()I", AccessFlags = 1)]
				public virtual int GetYears() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the value of the MONTHS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the MONTHS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Months of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMonths
				/// </java-name>
				[Dot42.DexImport("getMonths", "()I", AccessFlags = 1)]
				public virtual int GetMonths() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the value of the DAYS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the DAYS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Days of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getDays
				/// </java-name>
				[Dot42.DexImport("getDays", "()I", AccessFlags = 1)]
				public virtual int GetDays() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the value of the HOURS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the HOURS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Hours of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getHours
				/// </java-name>
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
				public virtual int GetHours() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the value of the MINUTES field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the MINUTES field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Minutes of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMinutes
				/// </java-name>
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
				public virtual int GetMinutes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the value of the SECONDS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the SECONDS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>seconds in the integer value. The fraction of seconds will be discarded (for example, if the actual value is 2.5, this method returns 2) </para>
				/// </returns>
				/// <java-name>
				/// getSeconds
				/// </java-name>
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
				public virtual int GetSeconds() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the length of the duration in milliseconds.</para><para>If the seconds field carries more digits than millisecond order, those will be simply discarded (or in other words, rounded to zero.) For example, for any Calendar value <code>x</code>,</para><para><pre>
				///        <code>new Duration("PT10.00099S").getTimeInMills(x) == 10000</code>.
				///        <code>new Duration("-PT10.00099S").getTimeInMills(x) == -10000</code>.
				///        </pre></para><para>Note that this method uses the addTo(Calendar) method, which may work incorrectly with <code>Duration</code> objects with very large values in its fields. See the addTo(Calendar) method for details.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>milliseconds between <code>startInstant</code> and <code>startInstant</code> plus this <code>Duration</code></para>
				/// </returns>
				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				[Dot42.DexImport("getTimeInMillis", "(Ljava/util/Calendar;)J", AccessFlags = 1)]
				public virtual long GetTimeInMillis(global::Java.Util.Calendar startInstant) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the length of the duration in milliseconds.</para><para>If the seconds field carries more digits than millisecond order, those will be simply discarded (or in other words, rounded to zero.) For example, for any Calendar value <code>x</code>,</para><para><pre>
				///        <code>new Duration("PT10.00099S").getTimeInMills(x) == 10000</code>.
				///        <code>new Duration("-PT10.00099S").getTimeInMills(x) == -10000</code>.
				///        </pre></para><para>Note that this method uses the addTo(Calendar) method, which may work incorrectly with <code>Duration</code> objects with very large values in its fields. See the addTo(Calendar) method for details.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>milliseconds between <code>startInstant</code> and <code>startInstant</code> plus this <code>Duration</code></para>
				/// </returns>
				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				[Dot42.DexImport("getTimeInMillis", "(Ljava/util/Date;)J", AccessFlags = 1)]
				public virtual long GetTimeInMillis(global::Java.Util.Date startInstant) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Gets the value of a field.</para><para>Fields of a duration object may contain arbitrary large value. Therefore this method is designed to return a Number object.</para><para>In case of YEARS, MONTHS, DAYS, HOURS, and MINUTES, the returned number will be a non-negative integer. In case of seconds, the returned number may be a non-negative decimal value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>If the specified field is present, this method returns a non-null non-negative Number object that represents its value. If it is not present, return null. For YEARS, MONTHS, DAYS, HOURS, and MINUTES, this method returns a java.math.BigInteger object. For SECONDS, this method returns a java.math.BigDecimal.</para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;", AccessFlags = 1025)]
				public abstract global::Java.Lang.Number GetField(global::Javax.Xml.Datatype.DatatypeConstants.Field field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if a field is set.</para><para>A field of a duration object may or may not be present. This method can be used to test if a field is present.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the field is present. false if not.</para>
				/// </returns>
				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z", AccessFlags = 1025)]
				public abstract bool IsSet(global::Javax.Xml.Datatype.DatatypeConstants.Field field) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Computes a new duration whose value is <code>this+rhs</code>.</para><para>For example,</para><para><pre>
				///        "1 day" + "-3 days" = "-2 days"
				///        "1 year" + "1 day" = "1 year and 1 day"
				///        "-(1 hour,50 minutes)" + "-20 minutes" = "-(1 hours,70 minutes)"
				///        "15 hours" + "-3 days" = "-(2 days,9 hours)"
				///        "1 year" + "-1 day" = IllegalStateException
				///        </pre></para><para>Since there's no way to meaningfully subtract 1 day from 1 month, there are cases where the operation fails in IllegalStateException.</para><para>Formally, the computation is defined as follows.</para><para>Firstly, we can assume that two <code>Duration</code>s to be added are both positive without losing generality (i.e., <code>(-X)+Y=Y-X</code>, <code>X+(-Y)=X-Y</code>, <code>(-X)+(-Y)=-(X+Y)</code>)</para><para>Addition of two positive <code>Duration</code>s are simply defined as field by field addition where missing fields are treated as 0. </para><para>A field of the resulting <code>Duration</code> will be unset if and only if respective fields of two input <code>Duration</code>s are unset. </para><para>Note that <code>lhs.add(rhs)</code> will be always successful if <code>lhs.signum()*rhs.signum()!=-1</code> or both of them are normalized.</para><para><para>#subtract(Duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>non-null valid Duration object.</para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Add(global::Javax.Xml.Datatype.Duration rhs) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds this duration to a Calendar object.</para><para>Calls java.util.Calendar#add(int,int) in the order of YEARS, MONTHS, DAYS, HOURS, MINUTES, SECONDS, and MILLISECONDS if those fields are present. Because the Calendar class uses int to hold values, there are cases where this method won't work correctly (for example if values of fields exceed the range of int.) </para><para>Also, since this duration class is a Gregorian duration, this method will not work correctly if the given Calendar object is based on some other calendar systems. </para><para>Any fractional parts of this <code>Duration</code> object beyond milliseconds will be simply ignored. For example, if this duration is "P1.23456S", then 1 is added to SECONDS, 234 is added to MILLISECONDS, and the rest will be unused. </para><para>Note that because Calendar#add(int, int) is using <code>int</code>, <code>Duration</code> with values beyond the range of <code>int</code> in its fields will cause overflow/underflow to the given Calendar. XMLGregorianCalendar#add(Duration) provides the same basic operation as this method while avoiding the overflow/underflow issues.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addTo
				/// </java-name>
				[Dot42.DexImport("addTo", "(Ljava/util/Calendar;)V", AccessFlags = 1025)]
				public abstract void AddTo(global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds this duration to a Calendar object.</para><para>Calls java.util.Calendar#add(int,int) in the order of YEARS, MONTHS, DAYS, HOURS, MINUTES, SECONDS, and MILLISECONDS if those fields are present. Because the Calendar class uses int to hold values, there are cases where this method won't work correctly (for example if values of fields exceed the range of int.) </para><para>Also, since this duration class is a Gregorian duration, this method will not work correctly if the given Calendar object is based on some other calendar systems. </para><para>Any fractional parts of this <code>Duration</code> object beyond milliseconds will be simply ignored. For example, if this duration is "P1.23456S", then 1 is added to SECONDS, 234 is added to MILLISECONDS, and the rest will be unused. </para><para>Note that because Calendar#add(int, int) is using <code>int</code>, <code>Duration</code> with values beyond the range of <code>int</code> in its fields will cause overflow/underflow to the given Calendar. XMLGregorianCalendar#add(Duration) provides the same basic operation as this method while avoiding the overflow/underflow issues.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addTo
				/// </java-name>
				[Dot42.DexImport("addTo", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void AddTo(global::Java.Util.Date calendar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes a new duration whose value is <code>this-rhs</code>.</para><para>For example:</para><para><pre>
				///        "1 day" - "-3 days" = "4 days"
				///        "1 year" - "1 day" = IllegalStateException
				///        "-(1 hour,50 minutes)" - "-20 minutes" = "-(1hours,30 minutes)"
				///        "15 hours" - "-3 days" = "3 days and 15 hours"
				///        "1 year" - "-1 day" = "1 year and 1 day"
				///        </pre></para><para>Since there's no way to meaningfully subtract 1 day from 1 month, there are cases where the operation fails in IllegalStateException.</para><para>Formally the computation is defined as follows. First, we can assume that two <code>Duration</code>s are both positive without losing generality. (i.e., <code>(-X)-Y=-(X+Y)</code>, <code>X-(-Y)=X+Y</code>, <code>(-X)-(-Y)=-(X-Y)</code>)</para><para>Then two durations are subtracted field by field. If the sign of any non-zero field <code>F</code> is different from the sign of the most significant field, 1 (if <code>F</code> is negative) or -1 (otherwise) will be borrowed from the next bigger unit of <code>F</code>.</para><para>This process is repeated until all the non-zero fields have the same sign.</para><para>If a borrow occurs in the days field (in other words, if the computation needs to borrow 1 or -1 month to compensate days), then the computation fails by throwing an IllegalStateException.</para><para><para>#add(Duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Duration</code> created from subtracting <code>rhs</code> from this <code>Duration</code>.</para>
				/// </returns>
				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration Subtract(global::Javax.Xml.Datatype.Duration rhs) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <summary>
				/// <para>Computes a new duration whose value is <code>factor</code> times longer than the value of this duration.</para><para>This method is provided for the convenience. It is functionally equivalent to the following code:</para><para><pre>
				///        multiply(new BigDecimal(String.valueOf(factor)))
				///        </pre></para><para><para>#multiply(BigDecimal) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Duration</code> that is <code>factor</code>times longer than this <code>Duration</code>.</para>
				/// </returns>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(I)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration Multiply(int factor) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <summary>
				/// <para>Computes a new duration whose value is <code>factor</code> times longer than the value of this duration.</para><para>This method is provided for the convenience. It is functionally equivalent to the following code:</para><para><pre>
				///        multiply(new BigDecimal(String.valueOf(factor)))
				///        </pre></para><para><para>#multiply(BigDecimal) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Duration</code> that is <code>factor</code>times longer than this <code>Duration</code>.</para>
				/// </returns>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Multiply(global::Java.Math.BigDecimal factor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new <code>Duration</code> object whose value is <code>-this</code>.</para><para>Since the <code>Duration</code> class is immutable, this method doesn't change the value of this object. It simply computes a new Duration object and returns it.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>always return a non-null valid <code>Duration</code> object. </para>
				/// </returns>
				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Negate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Converts the years and months fields into the days field by using a specific time instant as the reference point.</para><para>For example, duration of one month normalizes to 31 days given the start time instance "July 8th 2003, 17:40:32".</para><para>Formally, the computation is done as follows:</para><para><ol><li><para>the given Calendar object is cloned </para></li><li><para>the years, months and days fields will be added to the Calendar object by using the Calendar#add(int,int) method </para></li><li><para>the difference between the two Calendars in computed in milliseconds and converted to days, if a remainder occurs due to Daylight Savings Time, it is discarded </para></li><li><para>the computed days, along with the hours, minutes and seconds fields of this duration object is used to construct a new Duration object. </para></li></ol></para><para>Note that since the Calendar class uses <code>int</code> to hold the value of year and month, this method may produce an unexpected result if this duration object holds a very large value in the years or months fields.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Duration</code> of years and months of this <code>Duration</code> as days.</para>
				/// </returns>
				/// <java-name>
				/// normalizeWith
				/// </java-name>
				[Dot42.DexImport("normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration NormalizeWith(global::Java.Util.Calendar startTimeInstant) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Partial order relation comparison with this <code>Duration</code> instance.</para><para>Comparison result must be in accordance with .</para><para>Return:</para><para><ul><li><para>DatatypeConstants#LESSER if this <code>Duration</code> is shorter than <code>duration</code> parameter </para></li><li><para>DatatypeConstants#EQUAL if this <code>Duration</code> is equal to <code>duration</code> parameter </para></li><li><para>DatatypeConstants#GREATER if this <code>Duration</code> is longer than <code>duration</code> parameter </para></li><li><para>DatatypeConstants#INDETERMINATE if a conclusive partial order relation cannot be determined </para></li></ul></para><para><para>#isShorterThan(Duration) </para><simplesectsep></simplesectsep><para>#isLongerThan(Duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the relationship between <code>this</code> <code>Duration</code>and <code>duration</code> parameter as DatatypeConstants#LESSER, DatatypeConstants#EQUAL, DatatypeConstants#GREATER or DatatypeConstants#INDETERMINATE.</para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljavax/xml/datatype/Duration;)I", AccessFlags = 1025)]
				public abstract int Compare(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if this duration object is strictly longer than another <code>Duration</code> object.</para><para>Duration X is "longer" than Y if and only if X&gt;Y as defined in the section 3.2.6.2 of the XML Schema 1.0 specification.</para><para>For example, "P1D" (one day) &gt; "PT12H" (12 hours) and "P2Y" (two years) &gt; "P23M" (23 months).</para><para><para>#isShorterThan(Duration) </para><simplesectsep></simplesectsep><para>#compare(Duration duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the duration represented by this object is longer than the given duration. false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isLongerThan
				/// </java-name>
				[Dot42.DexImport("isLongerThan", "(Ljavax/xml/datatype/Duration;)Z", AccessFlags = 1)]
				public virtual bool IsLongerThan(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks if this duration object is strictly shorter than another <code>Duration</code> object.</para><para><para>#isLongerThan(Duration duration) </para><simplesectsep></simplesectsep><para>#compare(Duration duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>duration</code> parameter is shorter than this <code>Duration</code>, else <code>false</code>.</para>
				/// </returns>
				/// <java-name>
				/// isShorterThan
				/// </java-name>
				[Dot42.DexImport("isShorterThan", "(Ljavax/xml/datatype/Duration;)Z", AccessFlags = 1)]
				public virtual bool IsShorterThan(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks if this duration object has the same duration as another <code>Duration</code> object.</para><para>For example, "P1D" (1 day) is equal to "PT24H" (24 hours).</para><para>Duration X is equal to Y if and only if time instant t+X and t+Y are the same for all the test time instants specified in the section 3.2.6.2 of the XML Schema 1.0 specification.</para><para>Note that there are cases where two <code>Duration</code>s are "incomparable" to each other, like one month and 30 days. For example,</para><para><pre>
				///        !new Duration("P1M").isShorterThan(new Duration("P30D"))
				///        !new Duration("P1M").isLongerThan(new Duration("P30D"))
				///        !new Duration("P1M").equals(new Duration("P30D"))
				///        </pre></para><para><para>#compare(Duration duration) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this duration is the same length as <code>duration</code>. <code>false</code> if <code>duration</code> is not a <code>Duration</code> object, is <code>null</code>, or its length is different from this duration.</para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object duration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a hash code consistent with the definition of the equals method.</para><para><para>Object::hashCode() </para></para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a <code>String</code> representation of this <code>Duration</code> <code>Object</code>.</para><para>The result is formatted according to the XML Schema 1.0 specification and can be always parsed back later into the equivalent <code>Duration</code> <code>Object</code> by DatatypeFactory#newDuration(String  lexicalRepresentation).</para><para>Formally, the following holds for any <code>Duration</code> <code>Object</code> x:</para><para><pre>
				///        new Duration(x.toString()).equals(x)
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A non-<code>null</code> valid <code>String</code> representation of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the name of the XML Schema date/time type that this instance maps to. Type is computed based on fields that are set, i.e. isSet(DatatypeConstants.Field field) == <code>true</code>.</para><para><table></table></para><para>Required fields for XML Schema 1.0 Date/Time Datatypes.<br></br> <b>(timezone is optional for all date/time datatypes)</b>   &lt;/thead&gt; &lt;tbody&gt; </para><para>Datatype </para><para>year </para><para>month </para><para>day </para><para>hour </para><para>minute </para><para>second  </para><para>DatatypeConstants#DURATION </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DURATION_DAYTIME </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DURATION_YEARMONTH </para><para>X </para><para>X </para><para>&lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the following constants: DatatypeConstants#DURATION, DatatypeConstants#DURATION_DAYTIME or DatatypeConstants#DURATION_YEARMONTH.</para>
				/// </returns>
				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				public global::Javax.Xml.Namespace.QName XMLSchemaType
				{
				[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1)]
						get{ return GetXMLSchemaType(); }
				}

				/// <summary>
				/// <para>Returns the sign of this duration in -1,0, or 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>-1 if this duration is negative, 0 if the duration is zero, and 1 if the duration is positive. </para>
				/// </returns>
				/// <java-name>
				/// getSign
				/// </java-name>
				public int Sign
				{
				[Dot42.DexImport("getSign", "()I", AccessFlags = 1025)]
						get{ return GetSign(); }
				}

				/// <summary>
				/// <para>Get the years value of this <code>Duration</code> as an <code>int</code> or <code>0</code> if not present.</para><para><code>getYears()</code> is a convenience method for getField(DatatypeConstants.YEARS).</para><para>As the return value is an <code>int</code>, an incorrect value will be returned for <code>Duration</code>s with years that go beyond the range of an <code>int</code>. Use getField(DatatypeConstants.YEARS) to avoid possible loss of precision.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>If the years field is present, return its value as an <code>int</code>, else return <code>0</code>. </para>
				/// </returns>
				/// <java-name>
				/// getYears
				/// </java-name>
				public int Years
				{
				[Dot42.DexImport("getYears", "()I", AccessFlags = 1)]
						get{ return GetYears(); }
				}

				/// <summary>
				/// <para>Obtains the value of the MONTHS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the MONTHS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Months of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMonths
				/// </java-name>
				public int Months
				{
				[Dot42.DexImport("getMonths", "()I", AccessFlags = 1)]
						get{ return GetMonths(); }
				}

				/// <summary>
				/// <para>Obtains the value of the DAYS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the DAYS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Days of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getDays
				/// </java-name>
				public int Days
				{
				[Dot42.DexImport("getDays", "()I", AccessFlags = 1)]
						get{ return GetDays(); }
				}

				/// <summary>
				/// <para>Obtains the value of the HOURS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the HOURS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Hours of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getHours
				/// </java-name>
				public int Hours
				{
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return GetHours(); }
				}

				/// <summary>
				/// <para>Obtains the value of the MINUTES field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the MINUTES field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Minutes of this <code>Duration</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMinutes
				/// </java-name>
				public int Minutes
				{
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return GetMinutes(); }
				}

				/// <summary>
				/// <para>Obtains the value of the SECONDS field as an integer value, or 0 if not present.</para><para>This method works just like getYears() except that this method works on the SECONDS field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>seconds in the integer value. The fraction of seconds will be discarded (for example, if the actual value is 2.5, this method returns 2) </para>
				/// </returns>
				/// <java-name>
				/// getSeconds
				/// </java-name>
				public int Seconds
				{
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return GetSeconds(); }
				}

		}

		/// <summary>
		/// <para>Indicates a serious configuration error.</para><para><para> </para><para></para><title>Revision:</title><para>569987 </para>, <title>Date:</title><para>2007-08-26 21:08:46 -0700 (Sun, 26 Aug 2007) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/datatype/DatatypeConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeConfigurationException", AccessFlags = 33)]
		public partial class DatatypeConfigurationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new <code>DatatypeConfigurationException</code> with no specified detail message and cause.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatatypeConfigurationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new <code>DatatypeConfigurationException</code> with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public override void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintStream s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintWriter s) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Utility class to contain basic Datatype values as constants.</para><para><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/datatype/DatatypeConstants
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeConstants", AccessFlags = 49)]
		public sealed partial class DatatypeConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Value for first month of year. </para>        
				/// </summary>
				/// <java-name>
				/// JANUARY
				/// </java-name>
				[Dot42.DexImport("JANUARY", "I", AccessFlags = 25)]
				public const int JANUARY = 1;
				/// <summary>
				/// <para>Value for second month of year. </para>        
				/// </summary>
				/// <java-name>
				/// FEBRUARY
				/// </java-name>
				[Dot42.DexImport("FEBRUARY", "I", AccessFlags = 25)]
				public const int FEBRUARY = 2;
				/// <summary>
				/// <para>Value for third month of year. </para>        
				/// </summary>
				/// <java-name>
				/// MARCH
				/// </java-name>
				[Dot42.DexImport("MARCH", "I", AccessFlags = 25)]
				public const int MARCH = 3;
				/// <summary>
				/// <para>Value for fourth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// APRIL
				/// </java-name>
				[Dot42.DexImport("APRIL", "I", AccessFlags = 25)]
				public const int APRIL = 4;
				/// <summary>
				/// <para>Value for fifth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// MAY
				/// </java-name>
				[Dot42.DexImport("MAY", "I", AccessFlags = 25)]
				public const int MAY = 5;
				/// <summary>
				/// <para>Value for sixth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// JUNE
				/// </java-name>
				[Dot42.DexImport("JUNE", "I", AccessFlags = 25)]
				public const int JUNE = 6;
				/// <summary>
				/// <para>Value for seventh month of year. </para>        
				/// </summary>
				/// <java-name>
				/// JULY
				/// </java-name>
				[Dot42.DexImport("JULY", "I", AccessFlags = 25)]
				public const int JULY = 7;
				/// <summary>
				/// <para>Value for eighth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// AUGUST
				/// </java-name>
				[Dot42.DexImport("AUGUST", "I", AccessFlags = 25)]
				public const int AUGUST = 8;
				/// <summary>
				/// <para>Value for ninth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// SEPTEMBER
				/// </java-name>
				[Dot42.DexImport("SEPTEMBER", "I", AccessFlags = 25)]
				public const int SEPTEMBER = 9;
				/// <summary>
				/// <para>Value for tenth month of year. </para>        
				/// </summary>
				/// <java-name>
				/// OCTOBER
				/// </java-name>
				[Dot42.DexImport("OCTOBER", "I", AccessFlags = 25)]
				public const int OCTOBER = 10;
				/// <summary>
				/// <para>Value for eleven month of year. </para>        
				/// </summary>
				/// <java-name>
				/// NOVEMBER
				/// </java-name>
				[Dot42.DexImport("NOVEMBER", "I", AccessFlags = 25)]
				public const int NOVEMBER = 11;
				/// <summary>
				/// <para>Value for twelve month of year. </para>        
				/// </summary>
				/// <java-name>
				/// DECEMBER
				/// </java-name>
				[Dot42.DexImport("DECEMBER", "I", AccessFlags = 25)]
				public const int DECEMBER = 12;
				/// <summary>
				/// <para>Comparison result.</para>        
				/// </summary>
				/// <java-name>
				/// LESSER
				/// </java-name>
				[Dot42.DexImport("LESSER", "I", AccessFlags = 25)]
				public const int LESSER = -1;
				/// <summary>
				/// <para>Comparison result.</para>        
				/// </summary>
				/// <java-name>
				/// EQUAL
				/// </java-name>
				[Dot42.DexImport("EQUAL", "I", AccessFlags = 25)]
				public const int EQUAL = 0;
				/// <summary>
				/// <para>Comparison result.</para>        
				/// </summary>
				/// <java-name>
				/// GREATER
				/// </java-name>
				[Dot42.DexImport("GREATER", "I", AccessFlags = 25)]
				public const int GREATER = 1;
				/// <summary>
				/// <para>Comparison result.</para>        
				/// </summary>
				/// <java-name>
				/// INDETERMINATE
				/// </java-name>
				[Dot42.DexImport("INDETERMINATE", "I", AccessFlags = 25)]
				public const int INDETERMINATE = 2;
				/// <summary>
				/// <para>Designation that an "int" field is not set. </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("FIELD_UNDEFINED", "I", AccessFlags = 25)]
				public const int FIELD_UNDEFINED = -2147483648;
				/// <summary>
				/// <para>A constant that represents the years field.</para>        
				/// </summary>
				/// <java-name>
				/// YEARS
				/// </java-name>
				[Dot42.DexImport("YEARS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field YEARS;
				/// <summary>
				/// <para>A constant that represents the months field.</para>        
				/// </summary>
				/// <java-name>
				/// MONTHS
				/// </java-name>
				[Dot42.DexImport("MONTHS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field MONTHS;
				/// <summary>
				/// <para>A constant that represents the days field.</para>        
				/// </summary>
				/// <java-name>
				/// DAYS
				/// </java-name>
				[Dot42.DexImport("DAYS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field DAYS;
				/// <summary>
				/// <para>A constant that represents the hours field.</para>        
				/// </summary>
				/// <java-name>
				/// HOURS
				/// </java-name>
				[Dot42.DexImport("HOURS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field HOURS;
				/// <summary>
				/// <para>A constant that represents the minutes field.</para>        
				/// </summary>
				/// <java-name>
				/// MINUTES
				/// </java-name>
				[Dot42.DexImport("MINUTES", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field MINUTES;
				/// <summary>
				/// <para>A constant that represents the seconds field.</para>        
				/// </summary>
				/// <java-name>
				/// SECONDS
				/// </java-name>
				[Dot42.DexImport("SECONDS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field SECONDS;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>dateTime</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DATETIME
				/// </java-name>
				[Dot42.DexImport("DATETIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DATETIME;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>time</code>.</para>        
				/// </summary>
				/// <java-name>
				/// TIME
				/// </java-name>
				[Dot42.DexImport("TIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName TIME;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>date</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DATE;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>gYearMonth</code>.</para>        
				/// </summary>
				/// <java-name>
				/// GYEARMONTH
				/// </java-name>
				[Dot42.DexImport("GYEARMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GYEARMONTH;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>gMonthDay</code>.</para>        
				/// </summary>
				/// <java-name>
				/// GMONTHDAY
				/// </java-name>
				[Dot42.DexImport("GMONTHDAY", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GMONTHDAY;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>gYear</code>.</para>        
				/// </summary>
				/// <java-name>
				/// GYEAR
				/// </java-name>
				[Dot42.DexImport("GYEAR", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GYEAR;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>gMonth</code>.</para>        
				/// </summary>
				/// <java-name>
				/// GMONTH
				/// </java-name>
				[Dot42.DexImport("GMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GMONTH;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema 1.0 datatype <code>gDay</code>.</para>        
				/// </summary>
				/// <java-name>
				/// GDAY
				/// </java-name>
				[Dot42.DexImport("GDAY", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GDAY;
				/// <summary>
				/// <para>Fully qualified name for W3C XML Schema datatype <code>duration</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DURATION
				/// </java-name>
				[Dot42.DexImport("DURATION", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION;
				/// <summary>
				/// <para>Fully qualified name for XQuery 1.0 and XPath 2.0 datatype <code>dayTimeDuration</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DURATION_DAYTIME
				/// </java-name>
				[Dot42.DexImport("DURATION_DAYTIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION_DAYTIME;
				/// <summary>
				/// <para>Fully qualified name for XQuery 1.0 and XPath 2.0 datatype <code>yearMonthDuration</code>.</para>        
				/// </summary>
				/// <java-name>
				/// DURATION_YEARMONTH
				/// </java-name>
				[Dot42.DexImport("DURATION_YEARMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION_YEARMONTH;
				/// <summary>
				/// <para>W3C XML Schema max timezone offset is -14:00. Zone offset is in minutes. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_TIMEZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("MAX_TIMEZONE_OFFSET", "I", AccessFlags = 25)]
				public const int MAX_TIMEZONE_OFFSET = -840;
				/// <summary>
				/// <para>W3C XML Schema min timezone offset is +14:00. Zone offset is in minutes. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_TIMEZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("MIN_TIMEZONE_OFFSET", "I", AccessFlags = 25)]
				public const int MIN_TIMEZONE_OFFSET = 840;
				/// <summary>
				/// <para>Private constructor to prevent instantiation.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DatatypeConstants() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Type-safe enum class that represents six fields of the Duration class. </para>    
				/// </summary>
				/// <java-name>
				/// javax/xml/datatype/DatatypeConstants$Field
				/// </java-name>
				[Dot42.DexImport("javax/xml/datatype/DatatypeConstants$Field", AccessFlags = 25)]
				public sealed partial class Field
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Field() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns a field name in English. This method is intended to be used for debugging/diagnosis and not for display to end-users.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a non-null valid String constant. </para>
						/// </returns>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Get id of this Field.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Id of field. </para>
						/// </returns>
						/// <java-name>
						/// getId
						/// </java-name>
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						public int GetId() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Get id of this Field.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Id of field. </para>
						/// </returns>
						/// <java-name>
						/// getId
						/// </java-name>
						public int Id
						{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
								get{ return GetId(); }
						}

				}

		}

		/// <summary>
		/// <para>Representation for W3C XML Schema 1.0 date/time datatypes. Specifically, these date/time datatypes are , , , , ,   and  defined in the XML Namespace <code>"http://www.w3.org/2001/XMLSchema"</code>. These datatypes are normatively defined in .</para><para>The table below defines the mapping between XML Schema 1.0 date/time datatype fields and this class' fields. It also summarizes the value constraints for the date and time fields defined in .</para><para> <table></table></para><para>Date/Time Datatype Field Mapping Between XML Schema 1.0 and Java Representation   &lt;/thead&gt; &lt;tbody&gt; </para><para>XML Schema 1.0<br></br> datatype<br></br> field </para><para>Related<br></br>XMLGregorianCalendar<br></br>Accessor(s) </para><para>Value Range   </para><para>year  </para><para>getYear() + getEon() or<br></br> getEonAndYear  </para><para><code>getYear()</code> is a value between -(10^9-1) to (10^9)-1 or DatatypeConstants#FIELD_UNDEFINED.<br></br> getEon() is high order year value in billion of years.<br></br> <code>getEon()</code> has values greater than or equal to (10^9) or less than or equal to -(10^9). A value of null indicates field is undefined. Given that  states that the year zero will be a valid lexical value in a future version of XML Schema, this class allows the year field to be set to zero. Otherwise, the year field value is handled exactly as described in the errata and [ISO-8601-1988]. Note that W3C XML Schema 1.0 validation does not allow for the year field to have a value of zero.    </para><para>month  </para><para>getMonth()  </para><para>1 to 12 or DatatypeConstants#FIELD_UNDEFINED    </para><para>day  </para><para>getDay()  </para><para>Independent of month, max range is 1 to 31 or DatatypeConstants#FIELD_UNDEFINED.<br></br> The normative value constraint stated relative to month field's value is in .   </para><para>hour </para><para>getHour() </para><para>0 to 24 or DatatypeConstants#FIELD_UNDEFINED. For a value of 24, the minute and second field must be zero per .    </para><para>minute  </para><para>getMinute()  </para><para>0 to 59 or DatatypeConstants#FIELD_UNDEFINED    </para><para>second </para><para>getSecond() + getMillisecond()/1000 or<br></br> getSecond() + getFractionalSecond()  </para><para>getSecond() from 0 to 60 or DatatypeConstants#FIELD_UNDEFINED.<br></br> <b>(Note: 60 only allowable for leap second.)</b><br></br> getFractionalSecond() allows for infinite precision over the range from 0.0 to 1.0 when the getSecond() is defined.<br></br> <code>FractionalSecond</code> is optional and has a value of <code>null</code> when it is undefined.<br></br> getMillisecond() is the convenience millisecond precision of value of getFractionalSecond().   </para><para>timezone  </para><para>getTimezone()  </para><para>Number of minutes or DatatypeConstants#FIELD_UNDEFINED. Value range from -14 hours (-14 * 60 minutes) to 14 hours (14 * 60 minutes).   &lt;/tbody&gt; </para><para>All maximum value space constraints listed for the fields in the table above are checked by factory methods,link DatatypeFactory}, setter methods and parse methods of this class. <code>IllegalArgumentException</code> is thrown when a parameter's value is outside the value constraint for the field or if the composite values constitute an invalid XMLGregorianCalendar instance (for example, if the 31st of June is specified). </para><para>The following operations are defined for this class: <ul><li><para>accessors/mutators for independent date/time fields </para></li><li><para>conversion between this class and W3C XML Schema 1.0 lexical representation, toString(), DatatypeFactory#newXMLGregorianCalendar(String lexicalRepresentation) </para></li><li><para>conversion between this class and GregorianCalendar, toGregorianCalendar(java.util.TimeZone timezone, java.util.Locale aLocale, XMLGregorianCalendar defaults), DatatypeFactory </para></li><li><para>partial order relation comparator method, compare(XMLGregorianCalendar xmlGregorianCalendar) </para></li><li><para>equals(Object) defined relative to compare(XMLGregorianCalendar xmlGregorianCalendar). </para></li><li><para>addition operation with Duration instance as defined in .  </para></li></ul></para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>759822 </para>, <title>Date:</title><para>2009-03-29 18:15:11 -0700 (Sun, 29 Mar 2009) </para><para>Duration </para><simplesectsep></simplesectsep><para>DatatypeFactory </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/datatype/XMLGregorianCalendar
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/XMLGregorianCalendar", AccessFlags = 1057)]
		public abstract partial class XMLGregorianCalendar : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLGregorianCalendar() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unset all fields to undefined.</para><para>Set all int fields to DatatypeConstants#FIELD_UNDEFINED and reference fields to null.</para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				public abstract void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reset this <code>XMLGregorianCalendar</code> to its original values.</para><para><code>XMLGregorianCalendar</code> is reset to the same values as when it was created with DatatypeFactory#newXMLGregorianCalendar(), DatatypeFactory#newXMLGregorianCalendar(String lexicalRepresentation), BigInteger year, int month, int day, int hour, int minute, int second, BigDecimal fractionalSecond, int timezone), int year, int month, int day, int hour, int minute, int second, int millisecond, int timezone), DatatypeFactory#newXMLGregorianCalendar(GregorianCalendar cal), int year, int month, int day, int timezone), int hours, int minutes, int seconds, int timezone), int hours, int minutes, int seconds, BigDecimal fractionalSecond, int timezone) or int hours, int minutes, int seconds, int milliseconds, int timezone). </para><para><code>reset()</code> is designed to allow the reuse of existing <code>XMLGregorianCalendar</code>s thus saving resources associated with the creation of new <code>XMLGregorianCalendar</code>s.</para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				public abstract void Reset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set low and high order component of XSD <code>dateTime</code> year field.</para><para>Unset this field by invoking the setter with a parameter value of <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setYear
				/// </java-name>
				[Dot42.DexImport("setYear", "(Ljava/math/BigInteger;)V", AccessFlags = 1025)]
				public abstract void SetYear(global::Java.Math.BigInteger year) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set low and high order component of XSD <code>dateTime</code> year field.</para><para>Unset this field by invoking the setter with a parameter value of <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setYear
				/// </java-name>
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1025)]
				public abstract void SetYear(int year) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set month.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMonth
				/// </java-name>
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1025)]
				public abstract void SetMonth(int month) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set days in month.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDay
				/// </java-name>
				[Dot42.DexImport("setDay", "(I)V", AccessFlags = 1025)]
				public abstract void SetDay(int day) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the number of minutes in the timezone offset.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimezone
				/// </java-name>
				[Dot42.DexImport("setTimezone", "(I)V", AccessFlags = 1025)]
				public abstract void SetTimezone(int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set time as one unit.</para><para><para>setTime(int, int, int, BigDecimal)</para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(III)V", AccessFlags = 1)]
				public virtual void SetTime(int hour, int minute, int second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set hours.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHour
				/// </java-name>
				[Dot42.DexImport("setHour", "(I)V", AccessFlags = 1025)]
				public abstract void SetHour(int hour) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set minutes.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinute
				/// </java-name>
				[Dot42.DexImport("setMinute", "(I)V", AccessFlags = 1025)]
				public abstract void SetMinute(int minute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set seconds.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSecond
				/// </java-name>
				[Dot42.DexImport("setSecond", "(I)V", AccessFlags = 1025)]
				public abstract void SetSecond(int second) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set milliseconds.</para><para>Unset this field by invoking the setter with a parameter value of DatatypeConstants#FIELD_UNDEFINED.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMillisecond
				/// </java-name>
				[Dot42.DexImport("setMillisecond", "(I)V", AccessFlags = 1025)]
				public abstract void SetMillisecond(int millisecond) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set fractional seconds.</para><para>Unset this field by invoking the setter with a parameter value of <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFractionalSecond
				/// </java-name>
				[Dot42.DexImport("setFractionalSecond", "(Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				public abstract void SetFractionalSecond(global::Java.Math.BigDecimal fractional) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set time as one unit, including the optional infinite precision fractional seconds.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(IIILjava/math/BigDecimal;)V", AccessFlags = 1)]
				public virtual void SetTime(int hour, int minute, int second, global::Java.Math.BigDecimal fractional) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set time as one unit, including the optional infinite precision fractional seconds.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(IIII)V", AccessFlags = 1)]
				public virtual void SetTime(int hour, int minute, int second, int fractional) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return high order component for XML Schema 1.0 dateTime datatype field for <code>year</code>. <code>null</code> if this optional part of the year field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>getYear() </para><simplesectsep></simplesectsep><para>getEonAndYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>eon of this <code>XMLGregorianCalendar</code>. The value returned is an integer multiple of 10^9.</para>
				/// </returns>
				/// <java-name>
				/// getEon
				/// </java-name>
				[Dot42.DexImport("getEon", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				public abstract global::Java.Math.BigInteger GetEon() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return low order component for XML Schema 1.0 dateTime datatype field for <code>year</code> or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>getEon() </para><simplesectsep></simplesectsep><para>getEonAndYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>year of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1025)]
				public abstract int GetYear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return XML Schema 1.0 dateTime datatype field for <code>year</code>.</para><para>Value constraints for this value are summarized in .</para><para><para>getEon() </para><simplesectsep></simplesectsep><para>getYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>sum of <code>eon</code> and <code>BigInteger.valueOf(year)</code> when both fields are defined. When only <code>year</code> is defined, return it. When both <code>eon</code> and <code>year</code> are not defined, return <code>null</code>.</para>
				/// </returns>
				/// <java-name>
				/// getEonAndYear
				/// </java-name>
				[Dot42.DexImport("getEonAndYear", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				public abstract global::Java.Math.BigInteger GetEonAndYear() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return number of month or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>year of this <code>XMLGregorianCalendar</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1025)]
				public abstract int GetMonth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return day in month or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>setDay(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDay
				/// </java-name>
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1025)]
				public abstract int GetDay() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return timezone offset in minutes or DatatypeConstants#FIELD_UNDEFINED if this optional field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTimezone(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getTimezone
				/// </java-name>
				[Dot42.DexImport("getTimezone", "()I", AccessFlags = 1025)]
				public abstract int GetTimezone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return hours or DatatypeConstants#FIELD_UNDEFINED. Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getHour
				/// </java-name>
				[Dot42.DexImport("getHour", "()I", AccessFlags = 1025)]
				public abstract int GetHour() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return minutes or DatatypeConstants#FIELD_UNDEFINED.</para><para>Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getMinute
				/// </java-name>
				[Dot42.DexImport("getMinute", "()I", AccessFlags = 1025)]
				public abstract int GetMinute() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return seconds or DatatypeConstants#FIELD_UNDEFINED.</para><para>Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined. When this field is not defined, the optional xs:dateTime fractional seconds field, represented by getFractionalSecond() and getMillisecond(), must not be defined.</para><para>Value constraints for this value are summarized in .</para><para><para>getFractionalSecond() </para><simplesectsep></simplesectsep><para>getMillisecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Second of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getSecond
				/// </java-name>
				[Dot42.DexImport("getSecond", "()I", AccessFlags = 1025)]
				public abstract int GetSecond() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return millisecond precision of getFractionalSecond().</para><para>This method represents a convenience accessor to infinite precision fractional second value returned by getFractionalSecond(). The returned value is the rounded down to milliseconds value of getFractionalSecond(). When getFractionalSecond() returns <code>null</code>, this method must return DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>getFractionalSecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Millisecond of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getMillisecond
				/// </java-name>
				[Dot42.DexImport("getMillisecond", "()I", AccessFlags = 1)]
				public virtual int GetMillisecond() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return fractional seconds.</para><para><code>null</code> is returned when this optional field is not defined.</para><para>Value constraints are detailed in .</para><para>This optional field can only have a defined value when the xs:dateTime second field, represented by getSecond(), does not return DatatypeConstants#FIELD_UNDEFINED.</para><para><para>getSecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int, BigDecimal) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>fractional seconds of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getFractionalSecond
				/// </java-name>
				[Dot42.DexImport("getFractionalSecond", "()Ljava/math/BigDecimal;", AccessFlags = 1025)]
				public abstract global::Java.Math.BigDecimal GetFractionalSecond() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare two instances of W3C XML Schema 1.0 date/time datatypes according to partial order relation defined in .</para><para><code>xsd:dateTime</code> datatype field mapping to accessors of this class are defined in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The relationship between <code>this</code> <code>XMLGregorianCalendar</code> and the specified <code>xmlGregorianCalendar</code> as DatatypeConstants#LESSER, DatatypeConstants#EQUAL, DatatypeConstants#GREATER or DatatypeConstants#INDETERMINATE.</para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I", AccessFlags = 1025)]
				public abstract int Compare(global::Javax.Xml.Datatype.XMLGregorianCalendar xmlGregorianCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Normalize this instance to UTC.</para><para>2000-03-04T23:00:00+03:00 normalizes to 2000-03-04T20:00:00Z</para><para>Implements W3C XML Schema Part 2, Section 3.2.7.3 (A).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>this</code> <code>XMLGregorianCalendar</code> normalized to UTC. </para>
				/// </returns>
				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar Normalize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether parameter <code>obj</code> is "equal to" this one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> when <code>obj</code> is an instance of <code>XMLGregorianCalendar</code> and compare(XMLGregorianCalendar obj) returns DatatypeConstants#EQUAL, otherwise <code>false</code>. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a hash code consistent with the definition of the equals method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>hash code of this object. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the lexical representation of <code>this</code> instance. The format is specified in </para><para>Specific target lexical representation format is determined by getXMLSchemaType().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>XML, as <code>String</code>, representation of this <code>XMLGregorianCalendar</code></para>
				/// </returns>
				/// <java-name>
				/// toXMLFormat
				/// </java-name>
				[Dot42.DexImport("toXMLFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string ToXMLFormat() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the name of the XML Schema date/time type that this instance maps to. Type is computed based on fields that are set.</para><para><table></table></para><para>Required fields for XML Schema 1.0 Date/Time Datatypes.<br></br> <b>(timezone is optional for all date/time datatypes)</b>   &lt;/thead&gt; &lt;tbody&gt; </para><para>Datatype </para><para>year </para><para>month </para><para>day </para><para>hour </para><para>minute </para><para>second  </para><para>DatatypeConstants#DATETIME </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DATE </para><para>X </para><para>X </para><para>X </para><para>DatatypeConstants#TIME </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#GYEARMONTH </para><para>X </para><para>X </para><para>DatatypeConstants#GMONTHDAY </para><para>X </para><para>X </para><para>DatatypeConstants#GYEAR </para><para>X </para><para>DatatypeConstants#GMONTH </para><para>X </para><para>DatatypeConstants#GDAY </para><para>X </para><para>&lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>One of the following class constants: DatatypeConstants#DATETIME, DatatypeConstants#TIME, DatatypeConstants#DATE, DatatypeConstants#GYEARMONTH, DatatypeConstants#GMONTHDAY, DatatypeConstants#GYEAR, DatatypeConstants#GMONTH or DatatypeConstants#GDAY. </para>
				/// </returns>
				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Namespace.QName GetXMLSchemaType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <code>String</code> representation of this <code>XMLGregorianCalendar</code> <code>Object</code>.</para><para>The result is a lexical representation generated by toXMLFormat().</para><para><para>toXMLFormat() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A non-<code>null</code> valid <code>String</code> representation of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Validate instance by <code>getXMLSchemaType()</code> constraints. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if data values are valid. </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
				public abstract bool IsValid() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Add <code>duration</code> to this instance.</para><para>The computation is specified in .  defines the mapping from XML Schema 1.0 <code>dateTime</code> fields to this class' representation of those fields.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljavax/xml/datatype/Duration;)V", AccessFlags = 1025)]
				public abstract void Add(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Convert this <code>XMLGregorianCalendar</code> to a GregorianCalendar.</para><para>When <code>this</code> instance has an undefined field, this conversion relies on the <code>java.util.GregorianCalendar</code> default for its corresponding field. A notable difference between XML Schema 1.0 date/time datatypes and <code>java.util.GregorianCalendar</code> is that Timezone value is optional for date/time datatypes and it is a required field for <code>java.util.GregorianCalendar</code>. See javadoc for <code>java.util.TimeZone.getDefault()</code> on how the default is determined. To explicitly specify the <code>TimeZone</code> instance, see toGregorianCalendar(TimeZone, Locale, XMLGregorianCalendar).</para><para><table></table></para><para>Field by Field Conversion from this class to <code>java.util.GregorianCalendar</code>   &lt;/thead&gt; &lt;tbody&gt; </para><para><code>java.util.GregorianCalendar</code> field </para><para><code>javax.xml.datatype.XMLGregorianCalendar</code> field  </para><para><code>ERA</code> </para><para>getEonAndYear()<code>.signum() &lt; 0 ? GregorianCalendar.BC : GregorianCalendar.AD</code>  </para><para><code>YEAR</code> </para><para>getEonAndYear()<code>.abs().intValue()</code><b>*</b>  </para><para><code>MONTH</code> </para><para>getMonth() - DatatypeConstants#JANUARY + GregorianCalendar#JANUARY  </para><para><code>DAY_OF_MONTH</code> </para><para>getDay()  </para><para><code>HOUR_OF_DAY</code> </para><para>getHour()  </para><para><code>MINUTE</code> </para><para>getMinute()  </para><para><code>SECOND</code> </para><para>getSecond()  </para><para><code>MILLISECOND</code> </para><para>get millisecond order from getFractionalSecond()<b>*</b>   </para><para><code>GregorianCalendar.setTimeZone(TimeZone)</code> </para><para>getTimezone() formatted into Custom timezone id  &lt;/tbody&gt; </para><para><b>*</b> designates possible loss of precision during the conversion due to source datatype having higher precision than target datatype.</para><para>To ensure consistency in conversion implementations, the new <code>GregorianCalendar</code> should be instantiated in following manner. <ul><li><para>Using <code>timeZone</code> value as defined above, create a new <code>java.util.GregorianCalendar(timeZone,Locale.getDefault())</code>.  </para></li><li><para>Initialize all GregorianCalendar fields by calling {(}. </para></li><li><para>Obtain a pure Gregorian Calendar by invoking <code>GregorianCalendar.setGregorianChange( new Date(Long.MIN_VALUE))</code>. </para></li><li><para>Its fields ERA, YEAR, MONTH, DAY_OF_MONTH, HOUR_OF_DAY, MINUTE, SECOND and MILLISECOND are set using the method <code>Calendar.set(int,int)</code> </para></li></ul></para><para><para>toGregorianCalendar(java.util.TimeZone, java.util.Locale, XMLGregorianCalendar) </para></para>        
				/// </summary>
				/// <java-name>
				/// toGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("toGregorianCalendar", "()Ljava/util/GregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Java.Util.GregorianCalendar ToGregorianCalendar() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Convert this <code>XMLGregorianCalendar</code> along with provided parameters to a GregorianCalendar instance.</para><para>Since XML Schema 1.0 date/time datetypes has no concept of timezone ids or daylight savings timezone ids, this conversion operation allows the user to explicitly specify one with <code>timezone</code> parameter.</para><para>To compute the return value's <code>TimeZone</code> field, <ul><li><para>when parameter <code>timeZone</code> is non-null, it is the timezone field. </para></li><li><para>else when <code>this.getTimezone() != FIELD_UNDEFINED</code>, create a <code>java.util.TimeZone</code> with a custom timezone id using the <code>this.getTimezone()</code>. </para></li><li><para>else when <code>defaults.getTimezone() != FIELD_UNDEFINED</code>, create a <code>java.util.TimeZone</code> with a custom timezone id using <code>defaults.getTimezone()</code>. </para></li><li><para>else use the <code>GregorianCalendar</code> default timezone value for the host is defined as specified by <code>java.util.TimeZone.getDefault()</code>.</para></li></ul></para><para>To ensure consistency in conversion implementations, the new <code>GregorianCalendar</code> should be instantiated in following manner. <ul><li><para>Create a new <code>java.util.GregorianCalendar(TimeZone, Locale)</code> with TimeZone set as specified above and the <code>Locale</code> parameter.  </para></li><li><para>Initialize all GregorianCalendar fields by calling GregorianCalendar#clear() </para></li><li><para>Obtain a pure Gregorian Calendar by invoking <code>GregorianCalendar.setGregorianChange( new Date(Long.MIN_VALUE))</code>. </para></li><li><para>Its fields ERA, YEAR, MONTH, DAY_OF_MONTH, HOUR_OF_DAY, MINUTE, SECOND and MILLISECOND are set using the method <code>Calendar.set(int,int)</code> </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a java.util.GregorianCalendar conversion of this instance. </para>
				/// </returns>
				/// <java-name>
				/// toGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)" +
    "Ljava/util/GregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Java.Util.GregorianCalendar ToGregorianCalendar(global::Java.Util.TimeZone timezone, global::Java.Util.Locale aLocale, global::Javax.Xml.Datatype.XMLGregorianCalendar defaults) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a <code>java.util.TimeZone</code> for this class.</para><para>If timezone field is defined for this instance, returns TimeZone initialized with custom timezone id of zoneoffset. If timezone field is undefined, try the defaultZoneoffset that was passed in. If defaultZoneoffset is FIELD_UNDEFINED, return default timezone for this host. (Same default as java.util.GregorianCalendar).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TimeZone for this. </para>
				/// </returns>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(I)Ljava/util/TimeZone;", AccessFlags = 1025)]
				public abstract global::Java.Util.TimeZone GetTimeZone(int defaultZoneoffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates and returns a copy of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>copy of this <code>Object</code> </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return high order component for XML Schema 1.0 dateTime datatype field for <code>year</code>. <code>null</code> if this optional part of the year field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>getYear() </para><simplesectsep></simplesectsep><para>getEonAndYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>eon of this <code>XMLGregorianCalendar</code>. The value returned is an integer multiple of 10^9.</para>
				/// </returns>
				/// <java-name>
				/// getEon
				/// </java-name>
				public global::Java.Math.BigInteger Eon
				{
				[Dot42.DexImport("getEon", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get{ return GetEon(); }
				}

				/// <summary>
				/// <para>Return low order component for XML Schema 1.0 dateTime datatype field for <code>year</code> or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>getEon() </para><simplesectsep></simplesectsep><para>getEonAndYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>year of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				public int Year
				{
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1025)]
						get{ return GetYear(); }
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1025)]
						set{ SetYear(value); }
				}

				/// <summary>
				/// <para>Return XML Schema 1.0 dateTime datatype field for <code>year</code>.</para><para>Value constraints for this value are summarized in .</para><para><para>getEon() </para><simplesectsep></simplesectsep><para>getYear() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>sum of <code>eon</code> and <code>BigInteger.valueOf(year)</code> when both fields are defined. When only <code>year</code> is defined, return it. When both <code>eon</code> and <code>year</code> are not defined, return <code>null</code>.</para>
				/// </returns>
				/// <java-name>
				/// getEonAndYear
				/// </java-name>
				public global::Java.Math.BigInteger EonAndYear
				{
				[Dot42.DexImport("getEonAndYear", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get{ return GetEonAndYear(); }
				}

				/// <summary>
				/// <para>Return number of month or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>year of this <code>XMLGregorianCalendar</code>. </para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				public int Month
				{
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1025)]
						get{ return GetMonth(); }
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1025)]
						set{ SetMonth(value); }
				}

				/// <summary>
				/// <para>Return day in month or DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>setDay(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDay
				/// </java-name>
				public int Day
				{
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1025)]
						get{ return GetDay(); }
				[Dot42.DexImport("setDay", "(I)V", AccessFlags = 1025)]
						set{ SetDay(value); }
				}

				/// <summary>
				/// <para>Return timezone offset in minutes or DatatypeConstants#FIELD_UNDEFINED if this optional field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTimezone(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getTimezone
				/// </java-name>
				public int Timezone
				{
				[Dot42.DexImport("getTimezone", "()I", AccessFlags = 1025)]
						get{ return GetTimezone(); }
				[Dot42.DexImport("setTimezone", "(I)V", AccessFlags = 1025)]
						set{ SetTimezone(value); }
				}

				/// <summary>
				/// <para>Return hours or DatatypeConstants#FIELD_UNDEFINED. Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getHour
				/// </java-name>
				public int Hour
				{
				[Dot42.DexImport("getHour", "()I", AccessFlags = 1025)]
						get{ return GetHour(); }
				[Dot42.DexImport("setHour", "(I)V", AccessFlags = 1025)]
						set{ SetHour(value); }
				}

				/// <summary>
				/// <para>Return minutes or DatatypeConstants#FIELD_UNDEFINED.</para><para>Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined.</para><para>Value constraints for this value are summarized in .</para><para><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getMinute
				/// </java-name>
				public int Minute
				{
				[Dot42.DexImport("getMinute", "()I", AccessFlags = 1025)]
						get{ return GetMinute(); }
				[Dot42.DexImport("setMinute", "(I)V", AccessFlags = 1025)]
						set{ SetMinute(value); }
				}

				/// <summary>
				/// <para>Return seconds or DatatypeConstants#FIELD_UNDEFINED.</para><para>Returns DatatypeConstants#FIELD_UNDEFINED if this field is not defined. When this field is not defined, the optional xs:dateTime fractional seconds field, represented by getFractionalSecond() and getMillisecond(), must not be defined.</para><para>Value constraints for this value are summarized in .</para><para><para>getFractionalSecond() </para><simplesectsep></simplesectsep><para>getMillisecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Second of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getSecond
				/// </java-name>
				public int Second
				{
				[Dot42.DexImport("getSecond", "()I", AccessFlags = 1025)]
						get{ return GetSecond(); }
				[Dot42.DexImport("setSecond", "(I)V", AccessFlags = 1025)]
						set{ SetSecond(value); }
				}

				/// <summary>
				/// <para>Return millisecond precision of getFractionalSecond().</para><para>This method represents a convenience accessor to infinite precision fractional second value returned by getFractionalSecond(). The returned value is the rounded down to milliseconds value of getFractionalSecond(). When getFractionalSecond() returns <code>null</code>, this method must return DatatypeConstants#FIELD_UNDEFINED.</para><para>Value constraints for this value are summarized in .</para><para><para>getFractionalSecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Millisecond of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getMillisecond
				/// </java-name>
				public int Millisecond
				{
				[Dot42.DexImport("getMillisecond", "()I", AccessFlags = 1)]
						get{ return GetMillisecond(); }
				[Dot42.DexImport("setMillisecond", "(I)V", AccessFlags = 1025)]
						set{ SetMillisecond(value); }
				}

				/// <summary>
				/// <para>Return fractional seconds.</para><para><code>null</code> is returned when this optional field is not defined.</para><para>Value constraints are detailed in .</para><para>This optional field can only have a defined value when the xs:dateTime second field, represented by getSecond(), does not return DatatypeConstants#FIELD_UNDEFINED.</para><para><para>getSecond() </para><simplesectsep></simplesectsep><para>setTime(int, int, int, BigDecimal) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>fractional seconds of this <code>XMLGregorianCalendar</code>.</para>
				/// </returns>
				/// <java-name>
				/// getFractionalSecond
				/// </java-name>
				public global::Java.Math.BigDecimal FractionalSecond
				{
				[Dot42.DexImport("getFractionalSecond", "()Ljava/math/BigDecimal;", AccessFlags = 1025)]
						get{ return GetFractionalSecond(); }
				[Dot42.DexImport("setFractionalSecond", "(Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
						set{ SetFractionalSecond(value); }
				}

				/// <summary>
				/// <para>Return the name of the XML Schema date/time type that this instance maps to. Type is computed based on fields that are set.</para><para><table></table></para><para>Required fields for XML Schema 1.0 Date/Time Datatypes.<br></br> <b>(timezone is optional for all date/time datatypes)</b>   &lt;/thead&gt; &lt;tbody&gt; </para><para>Datatype </para><para>year </para><para>month </para><para>day </para><para>hour </para><para>minute </para><para>second  </para><para>DatatypeConstants#DATETIME </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#DATE </para><para>X </para><para>X </para><para>X </para><para>DatatypeConstants#TIME </para><para>X </para><para>X </para><para>X  </para><para>DatatypeConstants#GYEARMONTH </para><para>X </para><para>X </para><para>DatatypeConstants#GMONTHDAY </para><para>X </para><para>X </para><para>DatatypeConstants#GYEAR </para><para>X </para><para>DatatypeConstants#GMONTH </para><para>X </para><para>DatatypeConstants#GDAY </para><para>X </para><para>&lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>One of the following class constants: DatatypeConstants#DATETIME, DatatypeConstants#TIME, DatatypeConstants#DATE, DatatypeConstants#GYEARMONTH, DatatypeConstants#GMONTHDAY, DatatypeConstants#GYEAR, DatatypeConstants#GMONTH or DatatypeConstants#GDAY. </para>
				/// </returns>
				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				public global::Javax.Xml.Namespace.QName XMLSchemaType
				{
				[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1025)]
						get{ return GetXMLSchemaType(); }
				}

		}

}


