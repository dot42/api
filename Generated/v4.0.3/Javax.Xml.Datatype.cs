#pragma warning disable 1717
namespace Javax.Xml.Datatype
{
		/// <java-name>
		/// javax/xml/datatype/DatatypeConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeConfigurationException", AccessFlags = 33)]
		public partial class DatatypeConfigurationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatatypeConfigurationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DatatypeConfigurationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public override void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.IO.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.IO.PrintWriter printWriter) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/xml/datatype/DatatypeConstants
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeConstants", AccessFlags = 49)]
		public sealed partial class DatatypeConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// JANUARY
				/// </java-name>
				[Dot42.DexImport("JANUARY", "I", AccessFlags = 25)]
				public const int JANUARY = 1;
				/// <java-name>
				/// FEBRUARY
				/// </java-name>
				[Dot42.DexImport("FEBRUARY", "I", AccessFlags = 25)]
				public const int FEBRUARY = 2;
				/// <java-name>
				/// MARCH
				/// </java-name>
				[Dot42.DexImport("MARCH", "I", AccessFlags = 25)]
				public const int MARCH = 3;
				/// <java-name>
				/// APRIL
				/// </java-name>
				[Dot42.DexImport("APRIL", "I", AccessFlags = 25)]
				public const int APRIL = 4;
				/// <java-name>
				/// MAY
				/// </java-name>
				[Dot42.DexImport("MAY", "I", AccessFlags = 25)]
				public const int MAY = 5;
				/// <java-name>
				/// JUNE
				/// </java-name>
				[Dot42.DexImport("JUNE", "I", AccessFlags = 25)]
				public const int JUNE = 6;
				/// <java-name>
				/// JULY
				/// </java-name>
				[Dot42.DexImport("JULY", "I", AccessFlags = 25)]
				public const int JULY = 7;
				/// <java-name>
				/// AUGUST
				/// </java-name>
				[Dot42.DexImport("AUGUST", "I", AccessFlags = 25)]
				public const int AUGUST = 8;
				/// <java-name>
				/// SEPTEMBER
				/// </java-name>
				[Dot42.DexImport("SEPTEMBER", "I", AccessFlags = 25)]
				public const int SEPTEMBER = 9;
				/// <java-name>
				/// OCTOBER
				/// </java-name>
				[Dot42.DexImport("OCTOBER", "I", AccessFlags = 25)]
				public const int OCTOBER = 10;
				/// <java-name>
				/// NOVEMBER
				/// </java-name>
				[Dot42.DexImport("NOVEMBER", "I", AccessFlags = 25)]
				public const int NOVEMBER = 11;
				/// <java-name>
				/// DECEMBER
				/// </java-name>
				[Dot42.DexImport("DECEMBER", "I", AccessFlags = 25)]
				public const int DECEMBER = 12;
				/// <java-name>
				/// LESSER
				/// </java-name>
				[Dot42.DexImport("LESSER", "I", AccessFlags = 25)]
				public const int LESSER = -1;
				/// <java-name>
				/// EQUAL
				/// </java-name>
				[Dot42.DexImport("EQUAL", "I", AccessFlags = 25)]
				public const int EQUAL = 0;
				/// <java-name>
				/// GREATER
				/// </java-name>
				[Dot42.DexImport("GREATER", "I", AccessFlags = 25)]
				public const int GREATER = 1;
				/// <java-name>
				/// INDETERMINATE
				/// </java-name>
				[Dot42.DexImport("INDETERMINATE", "I", AccessFlags = 25)]
				public const int INDETERMINATE = 2;
				/// <java-name>
				/// FIELD_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("FIELD_UNDEFINED", "I", AccessFlags = 25)]
				public const int FIELD_UNDEFINED = -2147483648;
				/// <java-name>
				/// YEARS
				/// </java-name>
				[Dot42.DexImport("YEARS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field YEARS;
				/// <java-name>
				/// MONTHS
				/// </java-name>
				[Dot42.DexImport("MONTHS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field MONTHS;
				/// <java-name>
				/// DAYS
				/// </java-name>
				[Dot42.DexImport("DAYS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field DAYS;
				/// <java-name>
				/// HOURS
				/// </java-name>
				[Dot42.DexImport("HOURS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field HOURS;
				/// <java-name>
				/// MINUTES
				/// </java-name>
				[Dot42.DexImport("MINUTES", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field MINUTES;
				/// <java-name>
				/// SECONDS
				/// </java-name>
				[Dot42.DexImport("SECONDS", "Ljavax/xml/datatype/DatatypeConstants$Field;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Datatype.DatatypeConstants.Field SECONDS;
				/// <java-name>
				/// DATETIME
				/// </java-name>
				[Dot42.DexImport("DATETIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DATETIME;
				/// <java-name>
				/// TIME
				/// </java-name>
				[Dot42.DexImport("TIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName TIME;
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DATE;
				/// <java-name>
				/// GYEARMONTH
				/// </java-name>
				[Dot42.DexImport("GYEARMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GYEARMONTH;
				/// <java-name>
				/// GMONTHDAY
				/// </java-name>
				[Dot42.DexImport("GMONTHDAY", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GMONTHDAY;
				/// <java-name>
				/// GYEAR
				/// </java-name>
				[Dot42.DexImport("GYEAR", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GYEAR;
				/// <java-name>
				/// GMONTH
				/// </java-name>
				[Dot42.DexImport("GMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GMONTH;
				/// <java-name>
				/// GDAY
				/// </java-name>
				[Dot42.DexImport("GDAY", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName GDAY;
				/// <java-name>
				/// DURATION
				/// </java-name>
				[Dot42.DexImport("DURATION", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION;
				/// <java-name>
				/// DURATION_DAYTIME
				/// </java-name>
				[Dot42.DexImport("DURATION_DAYTIME", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION_DAYTIME;
				/// <java-name>
				/// DURATION_YEARMONTH
				/// </java-name>
				[Dot42.DexImport("DURATION_YEARMONTH", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName DURATION_YEARMONTH;
				/// <java-name>
				/// MAX_TIMEZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("MAX_TIMEZONE_OFFSET", "I", AccessFlags = 25)]
				public const int MAX_TIMEZONE_OFFSET = -840;
				/// <java-name>
				/// MIN_TIMEZONE_OFFSET
				/// </java-name>
				[Dot42.DexImport("MIN_TIMEZONE_OFFSET", "I", AccessFlags = 25)]
				public const int MIN_TIMEZONE_OFFSET = 840;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DatatypeConstants() /* MethodBuilder.Create */ 
				{
				}

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

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getId
						/// </java-name>
						public int Id
						{
								[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

		}

		/// <java-name>
		/// javax/xml/datatype/DatatypeFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/datatype/DatatypeFactory", AccessFlags = 1057)]
		public abstract partial class DatatypeFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DATATYPEFACTORY_PROPERTY
				/// </java-name>
				[Dot42.DexImport("DATATYPEFACTORY_PROPERTY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DATATYPEFACTORY_PROPERTY = "javax.xml.datatype.DatatypeFactory";
				/// <java-name>
				/// DATATYPEFACTORY_IMPLEMENTATION_CLASS
				/// </java-name>
				[Dot42.DexImport("DATATYPEFACTORY_IMPLEMENTATION_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DATATYPEFACTORY_IMPLEMENTATION_CLASS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DatatypeFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/datatype/DatatypeFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Datatype.DatatypeFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.DatatypeFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Datatype.DatatypeFactory NewInstance(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendar(global::Java.Util.GregorianCalendar gregorianCalendar) /* MethodBuilder.Create */ ;

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

				/// <java-name>
				/// newXMLGregorianCalendarDate
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarDate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.XMLGregorianCalendar);
				}

				/// <java-name>
				/// newXMLGregorianCalendarTime
				/// </java-name>
				[Dot42.DexImport("newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.XMLGregorianCalendar NewXMLGregorianCalendarTime(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				[Dot42.DexImport("getTimeInMillis", "(Ljava/util/Calendar;)J", AccessFlags = 1)]
				public virtual long GetTimeInMillis(global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getTimeInMillis
				/// </java-name>
				[Dot42.DexImport("getTimeInMillis", "(Ljava/util/Date;)J", AccessFlags = 1)]
				public virtual long GetTimeInMillis(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;", AccessFlags = 1025)]
				public abstract global::Java.Lang.Number GetField(global::Javax.Xml.Datatype.DatatypeConstants.Field field) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSet
				/// </java-name>
				[Dot42.DexImport("isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z", AccessFlags = 1025)]
				public abstract bool IsSet(global::Javax.Xml.Datatype.DatatypeConstants.Field field) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Add(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTo
				/// </java-name>
				[Dot42.DexImport("addTo", "(Ljava/util/Calendar;)V", AccessFlags = 1025)]
				public abstract void AddTo(global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTo
				/// </java-name>
				[Dot42.DexImport("addTo", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void AddTo(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration Subtract(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(I)Ljavax/xml/datatype/Duration;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Datatype.Duration Multiply(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Datatype.Duration);
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Multiply(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration Negate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// normalizeWith
				/// </java-name>
				[Dot42.DexImport("normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.Duration NormalizeWith(global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljavax/xml/datatype/Duration;)I", AccessFlags = 1025)]
				public abstract int Compare(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLongerThan
				/// </java-name>
				[Dot42.DexImport("isLongerThan", "(Ljavax/xml/datatype/Duration;)Z", AccessFlags = 1)]
				public virtual bool IsLongerThan(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isShorterThan
				/// </java-name>
				[Dot42.DexImport("isShorterThan", "(Ljavax/xml/datatype/Duration;)Z", AccessFlags = 1)]
				public virtual bool IsShorterThan(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				public virtual global::Javax.Xml.Namespace.QName XMLSchemaType
				{
						[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Namespace.QName); }
				}

				/// <java-name>
				/// getSign
				/// </java-name>
				public abstract int Sign
				{
						[Dot42.DexImport("getSign", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getYears
				/// </java-name>
				public virtual int Years
				{
						[Dot42.DexImport("getYears", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMonths
				/// </java-name>
				public virtual int Months
				{
						[Dot42.DexImport("getMonths", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDays
				/// </java-name>
				public virtual int Days
				{
						[Dot42.DexImport("getDays", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHours
				/// </java-name>
				public virtual int Hours
				{
						[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMinutes
				/// </java-name>
				public virtual int Minutes
				{
						[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSeconds
				/// </java-name>
				public virtual int Seconds
				{
						[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

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

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				public abstract void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				public abstract void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setYear
				/// </java-name>
				[Dot42.DexImport("setYear", "(Ljava/math/BigInteger;)V", AccessFlags = 1025)]
				public abstract void SetYear(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(III)V", AccessFlags = 1)]
				public virtual void SetTime(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(IIILjava/math/BigDecimal;)V", AccessFlags = 1)]
				public virtual void SetTime(int int32, int int321, int int322, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(IIII)V", AccessFlags = 1)]
				public virtual void SetTime(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I", AccessFlags = 1025)]
				public abstract int Compare(global::Javax.Xml.Datatype.XMLGregorianCalendar xMLGregorianCalendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Datatype.XMLGregorianCalendar Normalize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toXMLFormat
				/// </java-name>
				[Dot42.DexImport("toXMLFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string ToXMLFormat() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljavax/xml/datatype/Duration;)V", AccessFlags = 1025)]
				public abstract void Add(global::Javax.Xml.Datatype.Duration duration) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("toGregorianCalendar", "()Ljava/util/GregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Java.Util.GregorianCalendar ToGregorianCalendar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toGregorianCalendar
				/// </java-name>
				[Dot42.DexImport("toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)" +
    "Ljava/util/GregorianCalendar;", AccessFlags = 1025)]
				public abstract global::Java.Util.GregorianCalendar ToGregorianCalendar(global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale, global::Javax.Xml.Datatype.XMLGregorianCalendar xMLGregorianCalendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(I)Ljava/util/TimeZone;", AccessFlags = 1025)]
				public abstract global::Java.Util.TimeZone GetTimeZone(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEon
				/// </java-name>
				public abstract global::Java.Math.BigInteger Eon
				{
						[Dot42.DexImport("getEon", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public abstract int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getEonAndYear
				/// </java-name>
				public abstract global::Java.Math.BigInteger EonAndYear
				{
						[Dot42.DexImport("getEonAndYear", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public abstract int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getDay
				/// </java-name>
				public abstract int Day
				{
						[Dot42.DexImport("getDay", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setDay", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getTimezone
				/// </java-name>
				public abstract int Timezone
				{
						[Dot42.DexImport("getTimezone", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setTimezone", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getHour
				/// </java-name>
				public abstract int Hour
				{
						[Dot42.DexImport("getHour", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setHour", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMinute
				/// </java-name>
				public abstract int Minute
				{
						[Dot42.DexImport("getMinute", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setMinute", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getSecond
				/// </java-name>
				public abstract int Second
				{
						[Dot42.DexImport("getSecond", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSecond", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMillisecond
				/// </java-name>
				public virtual int Millisecond
				{
						[Dot42.DexImport("getMillisecond", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMillisecond", "(I)V", AccessFlags = 1025)]
						set{ }
				}

				/// <java-name>
				/// getFractionalSecond
				/// </java-name>
				public abstract global::Java.Math.BigDecimal FractionalSecond
				{
						[Dot42.DexImport("getFractionalSecond", "()Ljava/math/BigDecimal;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFractionalSecond", "(Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getXMLSchemaType
				/// </java-name>
				public abstract global::Javax.Xml.Namespace.QName XMLSchemaType
				{
						[Dot42.DexImport("getXMLSchemaType", "()Ljavax/xml/namespace/QName;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				public abstract bool IsValid
				{
						[Dot42.DexImport("isValid", "()Z", AccessFlags = 1025)]
						get;
				}

		}

}

