#pragma warning disable 1717
namespace Java.Sql
{
		/// <java-name>
		/// java/sql/SQLInvalidAuthorizationSpecException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLInvalidAuthorizationSpecException", AccessFlags = 33)]
		public partial class SQLInvalidAuthorizationSpecException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLException", AccessFlags = 33, Signature = "Ljava/lang/Exception;Ljava/io/Serializable;Ljava/lang/Iterable<Ljava/lang/Throwab" +
    "le;>;")]
		public partial class SQLException : global::System.Exception, global::Java.Io.ISerializable, global::Java.Lang.IIterable<global::System.Exception>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getErrorCode
				/// </java-name>
				[Dot42.DexImport("getErrorCode", "()I", AccessFlags = 1)]
				public virtual int GetErrorCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNextException
				/// </java-name>
				[Dot42.DexImport("getNextException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
				public virtual global::Java.Sql.SQLException GetNextException() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.SQLException);
				}

				/// <java-name>
				/// getSQLState
				/// </java-name>
				[Dot42.DexImport("getSQLState", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSQLState() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setNextException
				/// </java-name>
				[Dot42.DexImport("setNextException", "(Ljava/sql/SQLException;)V", AccessFlags = 1)]
				public virtual void SetNextException(global::Java.Sql.SQLException sQLException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Throwable;>;")]
				public virtual global::Java.Util.IIterator<global::System.Exception> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::System.Exception>);
				}

				/// <java-name>
				/// getErrorCode
				/// </java-name>
				public int ErrorCode
				{
				[Dot42.DexImport("getErrorCode", "()I", AccessFlags = 1)]
						get{ return GetErrorCode(); }
				}

				/// <java-name>
				/// getNextException
				/// </java-name>
				public global::Java.Sql.SQLException NextException
				{
				[Dot42.DexImport("getNextException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return GetNextException(); }
				[Dot42.DexImport("setNextException", "(Ljava/sql/SQLException;)V", AccessFlags = 1)]
						set{ SetNextException(value); }
				}

				/// <java-name>
				/// getSQLState
				/// </java-name>
				public string SQLState
				{
				[Dot42.DexImport("getSQLState", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSQLState(); }
				}

		}

		/// <java-name>
		/// java/sql/Driver
		/// </java-name>
		[Dot42.DexImport("java/sql/Driver", AccessFlags = 1537)]
		public partial interface IDriver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// acceptsURL
				/// </java-name>
				[Dot42.DexImport("acceptsURL", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool AcceptsURL(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection Connect(string @string, global::Java.Util.Properties properties) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMajorVersion
				/// </java-name>
				[Dot42.DexImport("getMajorVersion", "()I", AccessFlags = 1025)]
				int GetMajorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMinorVersion
				/// </java-name>
				[Dot42.DexImport("getMinorVersion", "()I", AccessFlags = 1025)]
				int GetMinorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPropertyInfo
				/// </java-name>
				[Dot42.DexImport("getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;", AccessFlags = 1025)]
				global::Java.Sql.DriverPropertyInfo[] GetPropertyInfo(string @string, global::Java.Util.Properties properties) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// jdbcCompliant
				/// </java-name>
				[Dot42.DexImport("jdbcCompliant", "()Z", AccessFlags = 1025)]
				bool JdbcCompliant() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/ParameterMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ParameterMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IParameterMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parameterModeIn
				/// </java-name>
				[Dot42.DexImport("parameterModeIn", "I", AccessFlags = 25)]
				public const int ParameterModeIn = 1;
				/// <java-name>
				/// parameterModeInOut
				/// </java-name>
				[Dot42.DexImport("parameterModeInOut", "I", AccessFlags = 25)]
				public const int ParameterModeInOut = 2;
				/// <java-name>
				/// parameterModeOut
				/// </java-name>
				[Dot42.DexImport("parameterModeOut", "I", AccessFlags = 25)]
				public const int ParameterModeOut = 4;
				/// <java-name>
				/// parameterModeUnknown
				/// </java-name>
				[Dot42.DexImport("parameterModeUnknown", "I", AccessFlags = 25)]
				public const int ParameterModeUnknown = 0;
				/// <java-name>
				/// parameterNoNulls
				/// </java-name>
				[Dot42.DexImport("parameterNoNulls", "I", AccessFlags = 25)]
				public const int ParameterNoNulls = 0;
				/// <java-name>
				/// parameterNullable
				/// </java-name>
				[Dot42.DexImport("parameterNullable", "I", AccessFlags = 25)]
				public const int ParameterNullable = 1;
				/// <java-name>
				/// parameterNullableUnknown
				/// </java-name>
				[Dot42.DexImport("parameterNullableUnknown", "I", AccessFlags = 25)]
				public const int ParameterNullableUnknown = 2;
		}

		/// <java-name>
		/// java/sql/ParameterMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ParameterMetaData", AccessFlags = 1537)]
		public partial interface IParameterMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParameterClassName
				/// </java-name>
				[Dot42.DexImport("getParameterClassName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameterClassName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterCount
				/// </java-name>
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1025)]
				int GetParameterCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterMode
				/// </java-name>
				[Dot42.DexImport("getParameterMode", "(I)I", AccessFlags = 1025)]
				int GetParameterMode(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterType
				/// </java-name>
				[Dot42.DexImport("getParameterType", "(I)I", AccessFlags = 1025)]
				int GetParameterType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterTypeName
				/// </java-name>
				[Dot42.DexImport("getParameterTypeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameterTypeName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "(I)I", AccessFlags = 1025)]
				int GetPrecision(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "(I)I", AccessFlags = 1025)]
				int GetScale(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNullable
				/// </java-name>
				[Dot42.DexImport("isNullable", "(I)I", AccessFlags = 1025)]
				int IsNullable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSigned
				/// </java-name>
				[Dot42.DexImport("isSigned", "(I)Z", AccessFlags = 1025)]
				bool IsSigned(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Types
		/// </java-name>
		[Dot42.DexImport("java/sql/Types", AccessFlags = 33)]
		public partial class Types
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ARRAY
				/// </java-name>
				[Dot42.DexImport("ARRAY", "I", AccessFlags = 25)]
				public const int ARRAY = 2003;
				/// <java-name>
				/// BIGINT
				/// </java-name>
				[Dot42.DexImport("BIGINT", "I", AccessFlags = 25)]
				public const int BIGINT = -5;
				/// <java-name>
				/// BINARY
				/// </java-name>
				[Dot42.DexImport("BINARY", "I", AccessFlags = 25)]
				public const int BINARY = -2;
				/// <java-name>
				/// BIT
				/// </java-name>
				[Dot42.DexImport("BIT", "I", AccessFlags = 25)]
				public const int BIT = -7;
				/// <java-name>
				/// BLOB
				/// </java-name>
				[Dot42.DexImport("BLOB", "I", AccessFlags = 25)]
				public const int BLOB = 2004;
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "I", AccessFlags = 25)]
				public const int BOOLEAN = 16;
				/// <java-name>
				/// CHAR
				/// </java-name>
				[Dot42.DexImport("CHAR", "I", AccessFlags = 25)]
				public const int CHAR = 1;
				/// <java-name>
				/// CLOB
				/// </java-name>
				[Dot42.DexImport("CLOB", "I", AccessFlags = 25)]
				public const int CLOB = 2005;
				/// <java-name>
				/// DATALINK
				/// </java-name>
				[Dot42.DexImport("DATALINK", "I", AccessFlags = 25)]
				public const int DATALINK = 70;
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "I", AccessFlags = 25)]
				public const int DATE = 91;
				/// <java-name>
				/// DECIMAL
				/// </java-name>
				[Dot42.DexImport("DECIMAL", "I", AccessFlags = 25)]
				public const int DECIMAL = 3;
				/// <java-name>
				/// DISTINCT
				/// </java-name>
				[Dot42.DexImport("DISTINCT", "I", AccessFlags = 25)]
				public const int DISTINCT = 2001;
				/// <java-name>
				/// DOUBLE
				/// </java-name>
				[Dot42.DexImport("DOUBLE", "I", AccessFlags = 25)]
				public const int DOUBLE = 8;
				/// <java-name>
				/// FLOAT
				/// </java-name>
				[Dot42.DexImport("FLOAT", "I", AccessFlags = 25)]
				public const int FLOAT = 6;
				/// <java-name>
				/// INTEGER
				/// </java-name>
				[Dot42.DexImport("INTEGER", "I", AccessFlags = 25)]
				public const int INTEGER = 4;
				/// <java-name>
				/// JAVA_OBJECT
				/// </java-name>
				[Dot42.DexImport("JAVA_OBJECT", "I", AccessFlags = 25)]
				public const int JAVA_OBJECT = 2000;
				/// <java-name>
				/// LONGVARBINARY
				/// </java-name>
				[Dot42.DexImport("LONGVARBINARY", "I", AccessFlags = 25)]
				public const int LONGVARBINARY = -4;
				/// <java-name>
				/// LONGVARCHAR
				/// </java-name>
				[Dot42.DexImport("LONGVARCHAR", "I", AccessFlags = 25)]
				public const int LONGVARCHAR = -1;
				/// <java-name>
				/// NULL
				/// </java-name>
				[Dot42.DexImport("NULL", "I", AccessFlags = 25)]
				public const int NULL = 0;
				/// <java-name>
				/// NUMERIC
				/// </java-name>
				[Dot42.DexImport("NUMERIC", "I", AccessFlags = 25)]
				public const int NUMERIC = 2;
				/// <java-name>
				/// OTHER
				/// </java-name>
				[Dot42.DexImport("OTHER", "I", AccessFlags = 25)]
				public const int OTHER = 1111;
				/// <java-name>
				/// REAL
				/// </java-name>
				[Dot42.DexImport("REAL", "I", AccessFlags = 25)]
				public const int REAL = 7;
				/// <java-name>
				/// REF
				/// </java-name>
				[Dot42.DexImport("REF", "I", AccessFlags = 25)]
				public const int REF = 2006;
				/// <java-name>
				/// SMALLINT
				/// </java-name>
				[Dot42.DexImport("SMALLINT", "I", AccessFlags = 25)]
				public const int SMALLINT = 5;
				/// <java-name>
				/// STRUCT
				/// </java-name>
				[Dot42.DexImport("STRUCT", "I", AccessFlags = 25)]
				public const int STRUCT = 2002;
				/// <java-name>
				/// TIME
				/// </java-name>
				[Dot42.DexImport("TIME", "I", AccessFlags = 25)]
				public const int TIME = 92;
				/// <java-name>
				/// TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("TIMESTAMP", "I", AccessFlags = 25)]
				public const int TIMESTAMP = 93;
				/// <java-name>
				/// TINYINT
				/// </java-name>
				[Dot42.DexImport("TINYINT", "I", AccessFlags = 25)]
				public const int TINYINT = -6;
				/// <java-name>
				/// VARBINARY
				/// </java-name>
				[Dot42.DexImport("VARBINARY", "I", AccessFlags = 25)]
				public const int VARBINARY = -3;
				/// <java-name>
				/// VARCHAR
				/// </java-name>
				[Dot42.DexImport("VARCHAR", "I", AccessFlags = 25)]
				public const int VARCHAR = 12;
				/// <java-name>
				/// ROWID
				/// </java-name>
				[Dot42.DexImport("ROWID", "I", AccessFlags = 25)]
				public const int ROWID = -8;
				/// <java-name>
				/// NCHAR
				/// </java-name>
				[Dot42.DexImport("NCHAR", "I", AccessFlags = 25)]
				public const int NCHAR = -15;
				/// <java-name>
				/// NVARCHAR
				/// </java-name>
				[Dot42.DexImport("NVARCHAR", "I", AccessFlags = 25)]
				public const int NVARCHAR = -9;
				/// <java-name>
				/// LONGNVARCHAR
				/// </java-name>
				[Dot42.DexImport("LONGNVARCHAR", "I", AccessFlags = 25)]
				public const int LONGNVARCHAR = -16;
				/// <java-name>
				/// NCLOB
				/// </java-name>
				[Dot42.DexImport("NCLOB", "I", AccessFlags = 25)]
				public const int NCLOB = 2011;
				/// <java-name>
				/// SQLXML
				/// </java-name>
				[Dot42.DexImport("SQLXML", "I", AccessFlags = 25)]
				public const int SQLXML = 2009;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Types() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/ResultSetMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSetMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IResultSetMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// columnNoNulls
				/// </java-name>
				[Dot42.DexImport("columnNoNulls", "I", AccessFlags = 25)]
				public const int ColumnNoNulls = 0;
				/// <java-name>
				/// columnNullable
				/// </java-name>
				[Dot42.DexImport("columnNullable", "I", AccessFlags = 25)]
				public const int ColumnNullable = 1;
				/// <java-name>
				/// columnNullableUnknown
				/// </java-name>
				[Dot42.DexImport("columnNullableUnknown", "I", AccessFlags = 25)]
				public const int ColumnNullableUnknown = 2;
		}

		/// <java-name>
		/// java/sql/ResultSetMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSetMetaData", AccessFlags = 1537)]
		public partial interface IResultSetMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCatalogName
				/// </java-name>
				[Dot42.DexImport("getCatalogName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetCatalogName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnClassName
				/// </java-name>
				[Dot42.DexImport("getColumnClassName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnClassName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1025)]
				int GetColumnCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnDisplaySize
				/// </java-name>
				[Dot42.DexImport("getColumnDisplaySize", "(I)I", AccessFlags = 1025)]
				int GetColumnDisplaySize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnLabel
				/// </java-name>
				[Dot42.DexImport("getColumnLabel", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnLabel(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnType
				/// </java-name>
				[Dot42.DexImport("getColumnType", "(I)I", AccessFlags = 1025)]
				int GetColumnType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnTypeName
				/// </java-name>
				[Dot42.DexImport("getColumnTypeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnTypeName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "(I)I", AccessFlags = 1025)]
				int GetPrecision(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "(I)I", AccessFlags = 1025)]
				int GetScale(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemaName
				/// </java-name>
				[Dot42.DexImport("getSchemaName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetSchemaName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTableName
				/// </java-name>
				[Dot42.DexImport("getTableName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetTableName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAutoIncrement
				/// </java-name>
				[Dot42.DexImport("isAutoIncrement", "(I)Z", AccessFlags = 1025)]
				bool IsAutoIncrement(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCaseSensitive
				/// </java-name>
				[Dot42.DexImport("isCaseSensitive", "(I)Z", AccessFlags = 1025)]
				bool IsCaseSensitive(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCurrency
				/// </java-name>
				[Dot42.DexImport("isCurrency", "(I)Z", AccessFlags = 1025)]
				bool IsCurrency(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDefinitelyWritable
				/// </java-name>
				[Dot42.DexImport("isDefinitelyWritable", "(I)Z", AccessFlags = 1025)]
				bool IsDefinitelyWritable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNullable
				/// </java-name>
				[Dot42.DexImport("isNullable", "(I)I", AccessFlags = 1025)]
				int IsNullable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "(I)Z", AccessFlags = 1025)]
				bool IsReadOnly(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSearchable
				/// </java-name>
				[Dot42.DexImport("isSearchable", "(I)Z", AccessFlags = 1025)]
				bool IsSearchable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSigned
				/// </java-name>
				[Dot42.DexImport("isSigned", "(I)Z", AccessFlags = 1025)]
				bool IsSigned(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isWritable
				/// </java-name>
				[Dot42.DexImport("isWritable", "(I)Z", AccessFlags = 1025)]
				bool IsWritable(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/DatabaseMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/DatabaseMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDatabaseMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// attributeNoNulls
				/// </java-name>
				[Dot42.DexImport("attributeNoNulls", "S", AccessFlags = 25)]
				public const short AttributeNoNulls = 0;
				/// <java-name>
				/// attributeNullable
				/// </java-name>
				[Dot42.DexImport("attributeNullable", "S", AccessFlags = 25)]
				public const short AttributeNullable = 1;
				/// <java-name>
				/// attributeNullableUnknown
				/// </java-name>
				[Dot42.DexImport("attributeNullableUnknown", "S", AccessFlags = 25)]
				public const short AttributeNullableUnknown = 2;
				/// <java-name>
				/// bestRowNotPseudo
				/// </java-name>
				[Dot42.DexImport("bestRowNotPseudo", "I", AccessFlags = 25)]
				public const int BestRowNotPseudo = 1;
				/// <java-name>
				/// bestRowPseudo
				/// </java-name>
				[Dot42.DexImport("bestRowPseudo", "I", AccessFlags = 25)]
				public const int BestRowPseudo = 2;
				/// <java-name>
				/// bestRowSession
				/// </java-name>
				[Dot42.DexImport("bestRowSession", "I", AccessFlags = 25)]
				public const int BestRowSession = 2;
				/// <java-name>
				/// bestRowTemporary
				/// </java-name>
				[Dot42.DexImport("bestRowTemporary", "I", AccessFlags = 25)]
				public const int BestRowTemporary = 0;
				/// <java-name>
				/// bestRowTransaction
				/// </java-name>
				[Dot42.DexImport("bestRowTransaction", "I", AccessFlags = 25)]
				public const int BestRowTransaction = 1;
				/// <java-name>
				/// bestRowUnknown
				/// </java-name>
				[Dot42.DexImport("bestRowUnknown", "I", AccessFlags = 25)]
				public const int BestRowUnknown = 0;
				/// <java-name>
				/// columnNoNulls
				/// </java-name>
				[Dot42.DexImport("columnNoNulls", "I", AccessFlags = 25)]
				public const int ColumnNoNulls = 0;
				/// <java-name>
				/// columnNullable
				/// </java-name>
				[Dot42.DexImport("columnNullable", "I", AccessFlags = 25)]
				public const int ColumnNullable = 1;
				/// <java-name>
				/// columnNullableUnknown
				/// </java-name>
				[Dot42.DexImport("columnNullableUnknown", "I", AccessFlags = 25)]
				public const int ColumnNullableUnknown = 2;
				/// <java-name>
				/// importedKeyCascade
				/// </java-name>
				[Dot42.DexImport("importedKeyCascade", "I", AccessFlags = 25)]
				public const int ImportedKeyCascade = 0;
				/// <java-name>
				/// importedKeyInitiallyDeferred
				/// </java-name>
				[Dot42.DexImport("importedKeyInitiallyDeferred", "I", AccessFlags = 25)]
				public const int ImportedKeyInitiallyDeferred = 5;
				/// <java-name>
				/// importedKeyInitiallyImmediate
				/// </java-name>
				[Dot42.DexImport("importedKeyInitiallyImmediate", "I", AccessFlags = 25)]
				public const int ImportedKeyInitiallyImmediate = 6;
				/// <java-name>
				/// importedKeyNoAction
				/// </java-name>
				[Dot42.DexImport("importedKeyNoAction", "I", AccessFlags = 25)]
				public const int ImportedKeyNoAction = 3;
				/// <java-name>
				/// importedKeyNotDeferrable
				/// </java-name>
				[Dot42.DexImport("importedKeyNotDeferrable", "I", AccessFlags = 25)]
				public const int ImportedKeyNotDeferrable = 7;
				/// <java-name>
				/// importedKeyRestrict
				/// </java-name>
				[Dot42.DexImport("importedKeyRestrict", "I", AccessFlags = 25)]
				public const int ImportedKeyRestrict = 1;
				/// <java-name>
				/// importedKeySetDefault
				/// </java-name>
				[Dot42.DexImport("importedKeySetDefault", "I", AccessFlags = 25)]
				public const int ImportedKeySetDefault = 4;
				/// <java-name>
				/// importedKeySetNull
				/// </java-name>
				[Dot42.DexImport("importedKeySetNull", "I", AccessFlags = 25)]
				public const int ImportedKeySetNull = 2;
				/// <java-name>
				/// procedureColumnIn
				/// </java-name>
				[Dot42.DexImport("procedureColumnIn", "I", AccessFlags = 25)]
				public const int ProcedureColumnIn = 1;
				/// <java-name>
				/// procedureColumnInOut
				/// </java-name>
				[Dot42.DexImport("procedureColumnInOut", "I", AccessFlags = 25)]
				public const int ProcedureColumnInOut = 2;
				/// <java-name>
				/// procedureColumnOut
				/// </java-name>
				[Dot42.DexImport("procedureColumnOut", "I", AccessFlags = 25)]
				public const int ProcedureColumnOut = 4;
				/// <java-name>
				/// procedureColumnResult
				/// </java-name>
				[Dot42.DexImport("procedureColumnResult", "I", AccessFlags = 25)]
				public const int ProcedureColumnResult = 3;
				/// <java-name>
				/// procedureColumnReturn
				/// </java-name>
				[Dot42.DexImport("procedureColumnReturn", "I", AccessFlags = 25)]
				public const int ProcedureColumnReturn = 5;
				/// <java-name>
				/// procedureColumnUnknown
				/// </java-name>
				[Dot42.DexImport("procedureColumnUnknown", "I", AccessFlags = 25)]
				public const int ProcedureColumnUnknown = 0;
				/// <java-name>
				/// procedureNoNulls
				/// </java-name>
				[Dot42.DexImport("procedureNoNulls", "I", AccessFlags = 25)]
				public const int ProcedureNoNulls = 0;
				/// <java-name>
				/// procedureNoResult
				/// </java-name>
				[Dot42.DexImport("procedureNoResult", "I", AccessFlags = 25)]
				public const int ProcedureNoResult = 1;
				/// <java-name>
				/// procedureNullable
				/// </java-name>
				[Dot42.DexImport("procedureNullable", "I", AccessFlags = 25)]
				public const int ProcedureNullable = 1;
				/// <java-name>
				/// procedureNullableUnknown
				/// </java-name>
				[Dot42.DexImport("procedureNullableUnknown", "I", AccessFlags = 25)]
				public const int ProcedureNullableUnknown = 2;
				/// <java-name>
				/// procedureResultUnknown
				/// </java-name>
				[Dot42.DexImport("procedureResultUnknown", "I", AccessFlags = 25)]
				public const int ProcedureResultUnknown = 0;
				/// <java-name>
				/// procedureReturnsResult
				/// </java-name>
				[Dot42.DexImport("procedureReturnsResult", "I", AccessFlags = 25)]
				public const int ProcedureReturnsResult = 2;
				/// <java-name>
				/// sqlStateSQL99
				/// </java-name>
				[Dot42.DexImport("sqlStateSQL99", "I", AccessFlags = 25)]
				public const int SqlStateSQL99 = 2;
				/// <java-name>
				/// sqlStateXOpen
				/// </java-name>
				[Dot42.DexImport("sqlStateXOpen", "I", AccessFlags = 25)]
				public const int SqlStateXOpen = 1;
				/// <java-name>
				/// tableIndexClustered
				/// </java-name>
				[Dot42.DexImport("tableIndexClustered", "S", AccessFlags = 25)]
				public const short TableIndexClustered = 1;
				/// <java-name>
				/// tableIndexHashed
				/// </java-name>
				[Dot42.DexImport("tableIndexHashed", "S", AccessFlags = 25)]
				public const short TableIndexHashed = 2;
				/// <java-name>
				/// tableIndexOther
				/// </java-name>
				[Dot42.DexImport("tableIndexOther", "S", AccessFlags = 25)]
				public const short TableIndexOther = 3;
				/// <java-name>
				/// tableIndexStatistic
				/// </java-name>
				[Dot42.DexImport("tableIndexStatistic", "S", AccessFlags = 25)]
				public const short TableIndexStatistic = 0;
				/// <java-name>
				/// typeNoNulls
				/// </java-name>
				[Dot42.DexImport("typeNoNulls", "I", AccessFlags = 25)]
				public const int TypeNoNulls = 0;
				/// <java-name>
				/// typeNullable
				/// </java-name>
				[Dot42.DexImport("typeNullable", "I", AccessFlags = 25)]
				public const int TypeNullable = 1;
				/// <java-name>
				/// typeNullableUnknown
				/// </java-name>
				[Dot42.DexImport("typeNullableUnknown", "I", AccessFlags = 25)]
				public const int TypeNullableUnknown = 2;
				/// <java-name>
				/// typePredBasic
				/// </java-name>
				[Dot42.DexImport("typePredBasic", "I", AccessFlags = 25)]
				public const int TypePredBasic = 2;
				/// <java-name>
				/// typePredChar
				/// </java-name>
				[Dot42.DexImport("typePredChar", "I", AccessFlags = 25)]
				public const int TypePredChar = 1;
				/// <java-name>
				/// typePredNone
				/// </java-name>
				[Dot42.DexImport("typePredNone", "I", AccessFlags = 25)]
				public const int TypePredNone = 0;
				/// <java-name>
				/// typeSearchable
				/// </java-name>
				[Dot42.DexImport("typeSearchable", "I", AccessFlags = 25)]
				public const int TypeSearchable = 3;
				/// <java-name>
				/// versionColumnNotPseudo
				/// </java-name>
				[Dot42.DexImport("versionColumnNotPseudo", "I", AccessFlags = 25)]
				public const int VersionColumnNotPseudo = 1;
				/// <java-name>
				/// versionColumnPseudo
				/// </java-name>
				[Dot42.DexImport("versionColumnPseudo", "I", AccessFlags = 25)]
				public const int VersionColumnPseudo = 2;
				/// <java-name>
				/// versionColumnUnknown
				/// </java-name>
				[Dot42.DexImport("versionColumnUnknown", "I", AccessFlags = 25)]
				public const int VersionColumnUnknown = 0;
				/// <java-name>
				/// sqlStateSQL
				/// </java-name>
				[Dot42.DexImport("sqlStateSQL", "I", AccessFlags = 25)]
				public const int SqlStateSQL = 2;
				/// <java-name>
				/// functionColumnIn
				/// </java-name>
				[Dot42.DexImport("functionColumnIn", "I", AccessFlags = 25)]
				public const int FunctionColumnIn = 1;
				/// <java-name>
				/// functionColumnInOut
				/// </java-name>
				[Dot42.DexImport("functionColumnInOut", "I", AccessFlags = 25)]
				public const int FunctionColumnInOut = 2;
				/// <java-name>
				/// functionColumnOut
				/// </java-name>
				[Dot42.DexImport("functionColumnOut", "I", AccessFlags = 25)]
				public const int FunctionColumnOut = 3;
				/// <java-name>
				/// functionReturn
				/// </java-name>
				[Dot42.DexImport("functionReturn", "I", AccessFlags = 25)]
				public const int FunctionReturn = 4;
				/// <java-name>
				/// functionColumnUnknown
				/// </java-name>
				[Dot42.DexImport("functionColumnUnknown", "I", AccessFlags = 25)]
				public const int FunctionColumnUnknown = 0;
				/// <java-name>
				/// functionColumnResult
				/// </java-name>
				[Dot42.DexImport("functionColumnResult", "I", AccessFlags = 25)]
				public const int FunctionColumnResult = 5;
				/// <java-name>
				/// functionNoNulls
				/// </java-name>
				[Dot42.DexImport("functionNoNulls", "I", AccessFlags = 25)]
				public const int FunctionNoNulls = 0;
				/// <java-name>
				/// functionNullable
				/// </java-name>
				[Dot42.DexImport("functionNullable", "I", AccessFlags = 25)]
				public const int FunctionNullable = 1;
				/// <java-name>
				/// functionNullableUnknown
				/// </java-name>
				[Dot42.DexImport("functionNullableUnknown", "I", AccessFlags = 25)]
				public const int FunctionNullableUnknown = 2;
				/// <java-name>
				/// functionResultUnknown
				/// </java-name>
				[Dot42.DexImport("functionResultUnknown", "I", AccessFlags = 25)]
				public const int FunctionResultUnknown = 0;
				/// <java-name>
				/// functionNoTable
				/// </java-name>
				[Dot42.DexImport("functionNoTable", "I", AccessFlags = 25)]
				public const int FunctionNoTable = 1;
				/// <java-name>
				/// functionReturnsTable
				/// </java-name>
				[Dot42.DexImport("functionReturnsTable", "I", AccessFlags = 25)]
				public const int FunctionReturnsTable = 2;
		}

		/// <java-name>
		/// java/sql/DatabaseMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/DatabaseMetaData", AccessFlags = 1537)]
		public partial interface IDatabaseMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// allProceduresAreCallable
				/// </java-name>
				[Dot42.DexImport("allProceduresAreCallable", "()Z", AccessFlags = 1025)]
				bool AllProceduresAreCallable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// allTablesAreSelectable
				/// </java-name>
				[Dot42.DexImport("allTablesAreSelectable", "()Z", AccessFlags = 1025)]
				bool AllTablesAreSelectable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dataDefinitionCausesTransactionCommit
				/// </java-name>
				[Dot42.DexImport("dataDefinitionCausesTransactionCommit", "()Z", AccessFlags = 1025)]
				bool DataDefinitionCausesTransactionCommit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dataDefinitionIgnoredInTransactions
				/// </java-name>
				[Dot42.DexImport("dataDefinitionIgnoredInTransactions", "()Z", AccessFlags = 1025)]
				bool DataDefinitionIgnoredInTransactions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deletesAreDetected
				/// </java-name>
				[Dot42.DexImport("deletesAreDetected", "(I)Z", AccessFlags = 1025)]
				bool DeletesAreDetected(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// doesMaxRowSizeIncludeBlobs
				/// </java-name>
				[Dot42.DexImport("doesMaxRowSizeIncludeBlobs", "()Z", AccessFlags = 1025)]
				bool DoesMaxRowSizeIncludeBlobs() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetAttributes(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBestRowIdentifier
				/// </java-name>
				[Dot42.DexImport("getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetBestRowIdentifier(string @string, string string1, string string2, int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCatalogs
				/// </java-name>
				[Dot42.DexImport("getCatalogs", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetCatalogs() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCatalogSeparator
				/// </java-name>
				[Dot42.DexImport("getCatalogSeparator", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCatalogSeparator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCatalogTerm
				/// </java-name>
				[Dot42.DexImport("getCatalogTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCatalogTerm() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnPrivileges
				/// </java-name>
				[Dot42.DexImport("getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetColumnPrivileges(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumns
				/// </java-name>
				[Dot42.DexImport("getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetColumns(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCrossReference
				/// </java-name>
				[Dot42.DexImport("getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetCrossReference(string @string, string string1, string string2, string string3, string string4, string string5) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDatabaseMajorVersion
				/// </java-name>
				[Dot42.DexImport("getDatabaseMajorVersion", "()I", AccessFlags = 1025)]
				int GetDatabaseMajorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDatabaseMinorVersion
				/// </java-name>
				[Dot42.DexImport("getDatabaseMinorVersion", "()I", AccessFlags = 1025)]
				int GetDatabaseMinorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDatabaseProductName
				/// </java-name>
				[Dot42.DexImport("getDatabaseProductName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDatabaseProductName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDatabaseProductVersion
				/// </java-name>
				[Dot42.DexImport("getDatabaseProductVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDatabaseProductVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefaultTransactionIsolation
				/// </java-name>
				[Dot42.DexImport("getDefaultTransactionIsolation", "()I", AccessFlags = 1025)]
				int GetDefaultTransactionIsolation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDriverMajorVersion
				/// </java-name>
				[Dot42.DexImport("getDriverMajorVersion", "()I", AccessFlags = 1025)]
				int GetDriverMajorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDriverMinorVersion
				/// </java-name>
				[Dot42.DexImport("getDriverMinorVersion", "()I", AccessFlags = 1025)]
				int GetDriverMinorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDriverName
				/// </java-name>
				[Dot42.DexImport("getDriverName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDriverName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDriverVersion
				/// </java-name>
				[Dot42.DexImport("getDriverVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDriverVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExportedKeys
				/// </java-name>
				[Dot42.DexImport("getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetExportedKeys(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExtraNameCharacters
				/// </java-name>
				[Dot42.DexImport("getExtraNameCharacters", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetExtraNameCharacters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIdentifierQuoteString
				/// </java-name>
				[Dot42.DexImport("getIdentifierQuoteString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetIdentifierQuoteString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getImportedKeys
				/// </java-name>
				[Dot42.DexImport("getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetImportedKeys(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIndexInfo
				/// </java-name>
				[Dot42.DexImport("getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetIndexInfo(string @string, string string1, string string2, bool boolean, bool boolean1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getJDBCMajorVersion
				/// </java-name>
				[Dot42.DexImport("getJDBCMajorVersion", "()I", AccessFlags = 1025)]
				int GetJDBCMajorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getJDBCMinorVersion
				/// </java-name>
				[Dot42.DexImport("getJDBCMinorVersion", "()I", AccessFlags = 1025)]
				int GetJDBCMinorVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxBinaryLiteralLength
				/// </java-name>
				[Dot42.DexImport("getMaxBinaryLiteralLength", "()I", AccessFlags = 1025)]
				int GetMaxBinaryLiteralLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxCatalogNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxCatalogNameLength", "()I", AccessFlags = 1025)]
				int GetMaxCatalogNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxCharLiteralLength
				/// </java-name>
				[Dot42.DexImport("getMaxCharLiteralLength", "()I", AccessFlags = 1025)]
				int GetMaxCharLiteralLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxColumnNameLength", "()I", AccessFlags = 1025)]
				int GetMaxColumnNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnsInGroupBy
				/// </java-name>
				[Dot42.DexImport("getMaxColumnsInGroupBy", "()I", AccessFlags = 1025)]
				int GetMaxColumnsInGroupBy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnsInIndex
				/// </java-name>
				[Dot42.DexImport("getMaxColumnsInIndex", "()I", AccessFlags = 1025)]
				int GetMaxColumnsInIndex() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnsInOrderBy
				/// </java-name>
				[Dot42.DexImport("getMaxColumnsInOrderBy", "()I", AccessFlags = 1025)]
				int GetMaxColumnsInOrderBy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnsInSelect
				/// </java-name>
				[Dot42.DexImport("getMaxColumnsInSelect", "()I", AccessFlags = 1025)]
				int GetMaxColumnsInSelect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxColumnsInTable
				/// </java-name>
				[Dot42.DexImport("getMaxColumnsInTable", "()I", AccessFlags = 1025)]
				int GetMaxColumnsInTable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxConnections
				/// </java-name>
				[Dot42.DexImport("getMaxConnections", "()I", AccessFlags = 1025)]
				int GetMaxConnections() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxCursorNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxCursorNameLength", "()I", AccessFlags = 1025)]
				int GetMaxCursorNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxIndexLength
				/// </java-name>
				[Dot42.DexImport("getMaxIndexLength", "()I", AccessFlags = 1025)]
				int GetMaxIndexLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxProcedureNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxProcedureNameLength", "()I", AccessFlags = 1025)]
				int GetMaxProcedureNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxRowSize
				/// </java-name>
				[Dot42.DexImport("getMaxRowSize", "()I", AccessFlags = 1025)]
				int GetMaxRowSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxSchemaNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxSchemaNameLength", "()I", AccessFlags = 1025)]
				int GetMaxSchemaNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxStatementLength
				/// </java-name>
				[Dot42.DexImport("getMaxStatementLength", "()I", AccessFlags = 1025)]
				int GetMaxStatementLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxStatements
				/// </java-name>
				[Dot42.DexImport("getMaxStatements", "()I", AccessFlags = 1025)]
				int GetMaxStatements() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxTableNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxTableNameLength", "()I", AccessFlags = 1025)]
				int GetMaxTableNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxTablesInSelect
				/// </java-name>
				[Dot42.DexImport("getMaxTablesInSelect", "()I", AccessFlags = 1025)]
				int GetMaxTablesInSelect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxUserNameLength
				/// </java-name>
				[Dot42.DexImport("getMaxUserNameLength", "()I", AccessFlags = 1025)]
				int GetMaxUserNameLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNumericFunctions
				/// </java-name>
				[Dot42.DexImport("getNumericFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetNumericFunctions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrimaryKeys
				/// </java-name>
				[Dot42.DexImport("getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetPrimaryKeys(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProcedureColumns
				/// </java-name>
				[Dot42.DexImport("getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetProcedureColumns(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProcedures
				/// </java-name>
				[Dot42.DexImport("getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetProcedures(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProcedureTerm
				/// </java-name>
				[Dot42.DexImport("getProcedureTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetProcedureTerm() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSetHoldability
				/// </java-name>
				[Dot42.DexImport("getResultSetHoldability", "()I", AccessFlags = 1025)]
				int GetResultSetHoldability() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemas
				/// </java-name>
				[Dot42.DexImport("getSchemas", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSchemas() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemaTerm
				/// </java-name>
				[Dot42.DexImport("getSchemaTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSchemaTerm() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSearchStringEscape
				/// </java-name>
				[Dot42.DexImport("getSearchStringEscape", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSearchStringEscape() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLKeywords
				/// </java-name>
				[Dot42.DexImport("getSQLKeywords", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSQLKeywords() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLStateType
				/// </java-name>
				[Dot42.DexImport("getSQLStateType", "()I", AccessFlags = 1025)]
				int GetSQLStateType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStringFunctions
				/// </java-name>
				[Dot42.DexImport("getStringFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetStringFunctions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSuperTables
				/// </java-name>
				[Dot42.DexImport("getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSuperTables(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSuperTypes
				/// </java-name>
				[Dot42.DexImport("getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSuperTypes(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemFunctions
				/// </java-name>
				[Dot42.DexImport("getSystemFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemFunctions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTablePrivileges
				/// </java-name>
				[Dot42.DexImport("getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTablePrivileges(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTables
				/// </java-name>
				[Dot42.DexImport("getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/" +
    "sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTables(string @string, string string1, string string2, string[] string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTableTypes
				/// </java-name>
				[Dot42.DexImport("getTableTypes", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTableTypes() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimeDateFunctions
				/// </java-name>
				[Dot42.DexImport("getTimeDateFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetTimeDateFunctions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTypeInfo
				/// </java-name>
				[Dot42.DexImport("getTypeInfo", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTypeInfo() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUDTs
				/// </java-name>
				[Dot42.DexImport("getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetUDTs(string @string, string string1, string string2, int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetURL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetUserName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getVersionColumns
				/// </java-name>
				[Dot42.DexImport("getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetVersionColumns(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insertsAreDetected
				/// </java-name>
				[Dot42.DexImport("insertsAreDetected", "(I)Z", AccessFlags = 1025)]
				bool InsertsAreDetected(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCatalogAtStart
				/// </java-name>
				[Dot42.DexImport("isCatalogAtStart", "()Z", AccessFlags = 1025)]
				bool IsCatalogAtStart() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
				bool IsReadOnly() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// locatorsUpdateCopy
				/// </java-name>
				[Dot42.DexImport("locatorsUpdateCopy", "()Z", AccessFlags = 1025)]
				bool LocatorsUpdateCopy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nullPlusNonNullIsNull
				/// </java-name>
				[Dot42.DexImport("nullPlusNonNullIsNull", "()Z", AccessFlags = 1025)]
				bool NullPlusNonNullIsNull() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nullsAreSortedAtEnd
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedAtEnd", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedAtEnd() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nullsAreSortedAtStart
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedAtStart", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedAtStart() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nullsAreSortedHigh
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedHigh", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedHigh() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nullsAreSortedLow
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedLow", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedLow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// othersDeletesAreVisible
				/// </java-name>
				[Dot42.DexImport("othersDeletesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersDeletesAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// othersInsertsAreVisible
				/// </java-name>
				[Dot42.DexImport("othersInsertsAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersInsertsAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// othersUpdatesAreVisible
				/// </java-name>
				[Dot42.DexImport("othersUpdatesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersUpdatesAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ownDeletesAreVisible
				/// </java-name>
				[Dot42.DexImport("ownDeletesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnDeletesAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ownInsertsAreVisible
				/// </java-name>
				[Dot42.DexImport("ownInsertsAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnInsertsAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ownUpdatesAreVisible
				/// </java-name>
				[Dot42.DexImport("ownUpdatesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnUpdatesAreVisible(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesLowerCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesLowerCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresLowerCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesLowerCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesLowerCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresLowerCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesMixedCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesMixedCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresMixedCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesMixedCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesMixedCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresMixedCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesUpperCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesUpperCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresUpperCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// storesUpperCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesUpperCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresUpperCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsAlterTableWithAddColumn
				/// </java-name>
				[Dot42.DexImport("supportsAlterTableWithAddColumn", "()Z", AccessFlags = 1025)]
				bool SupportsAlterTableWithAddColumn() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsAlterTableWithDropColumn
				/// </java-name>
				[Dot42.DexImport("supportsAlterTableWithDropColumn", "()Z", AccessFlags = 1025)]
				bool SupportsAlterTableWithDropColumn() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsANSI92EntryLevelSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92EntryLevelSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92EntryLevelSQL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsANSI92FullSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92FullSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92FullSQL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsANSI92IntermediateSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92IntermediateSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92IntermediateSQL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsBatchUpdates
				/// </java-name>
				[Dot42.DexImport("supportsBatchUpdates", "()Z", AccessFlags = 1025)]
				bool SupportsBatchUpdates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCatalogsInDataManipulation
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInDataManipulation", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInDataManipulation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCatalogsInIndexDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInIndexDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInIndexDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCatalogsInPrivilegeDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInPrivilegeDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInPrivilegeDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCatalogsInProcedureCalls
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInProcedureCalls", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInProcedureCalls() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCatalogsInTableDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInTableDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInTableDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsColumnAliasing
				/// </java-name>
				[Dot42.DexImport("supportsColumnAliasing", "()Z", AccessFlags = 1025)]
				bool SupportsColumnAliasing() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsConvert
				/// </java-name>
				[Dot42.DexImport("supportsConvert", "()Z", AccessFlags = 1025)]
				bool SupportsConvert() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsConvert
				/// </java-name>
				[Dot42.DexImport("supportsConvert", "(II)Z", AccessFlags = 1025)]
				bool SupportsConvert(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCoreSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsCoreSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsCoreSQLGrammar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsCorrelatedSubqueries
				/// </java-name>
				[Dot42.DexImport("supportsCorrelatedSubqueries", "()Z", AccessFlags = 1025)]
				bool SupportsCorrelatedSubqueries() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsDataDefinitionAndDataManipulationTransactions
				/// </java-name>
				[Dot42.DexImport("supportsDataDefinitionAndDataManipulationTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsDataDefinitionAndDataManipulationTransactions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsDataManipulationTransactionsOnly
				/// </java-name>
				[Dot42.DexImport("supportsDataManipulationTransactionsOnly", "()Z", AccessFlags = 1025)]
				bool SupportsDataManipulationTransactionsOnly() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsDifferentTableCorrelationNames
				/// </java-name>
				[Dot42.DexImport("supportsDifferentTableCorrelationNames", "()Z", AccessFlags = 1025)]
				bool SupportsDifferentTableCorrelationNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsExpressionsInOrderBy
				/// </java-name>
				[Dot42.DexImport("supportsExpressionsInOrderBy", "()Z", AccessFlags = 1025)]
				bool SupportsExpressionsInOrderBy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsExtendedSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsExtendedSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsExtendedSQLGrammar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsFullOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsFullOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsFullOuterJoins() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsGetGeneratedKeys
				/// </java-name>
				[Dot42.DexImport("supportsGetGeneratedKeys", "()Z", AccessFlags = 1025)]
				bool SupportsGetGeneratedKeys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsGroupBy
				/// </java-name>
				[Dot42.DexImport("supportsGroupBy", "()Z", AccessFlags = 1025)]
				bool SupportsGroupBy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsGroupByBeyondSelect
				/// </java-name>
				[Dot42.DexImport("supportsGroupByBeyondSelect", "()Z", AccessFlags = 1025)]
				bool SupportsGroupByBeyondSelect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsGroupByUnrelated
				/// </java-name>
				[Dot42.DexImport("supportsGroupByUnrelated", "()Z", AccessFlags = 1025)]
				bool SupportsGroupByUnrelated() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsIntegrityEnhancementFacility
				/// </java-name>
				[Dot42.DexImport("supportsIntegrityEnhancementFacility", "()Z", AccessFlags = 1025)]
				bool SupportsIntegrityEnhancementFacility() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsLikeEscapeClause
				/// </java-name>
				[Dot42.DexImport("supportsLikeEscapeClause", "()Z", AccessFlags = 1025)]
				bool SupportsLikeEscapeClause() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsLimitedOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsLimitedOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsLimitedOuterJoins() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMinimumSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsMinimumSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsMinimumSQLGrammar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMixedCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("supportsMixedCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool SupportsMixedCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMixedCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("supportsMixedCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool SupportsMixedCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMultipleOpenResults
				/// </java-name>
				[Dot42.DexImport("supportsMultipleOpenResults", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleOpenResults() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMultipleResultSets
				/// </java-name>
				[Dot42.DexImport("supportsMultipleResultSets", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleResultSets() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsMultipleTransactions
				/// </java-name>
				[Dot42.DexImport("supportsMultipleTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleTransactions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsNamedParameters
				/// </java-name>
				[Dot42.DexImport("supportsNamedParameters", "()Z", AccessFlags = 1025)]
				bool SupportsNamedParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsNonNullableColumns
				/// </java-name>
				[Dot42.DexImport("supportsNonNullableColumns", "()Z", AccessFlags = 1025)]
				bool SupportsNonNullableColumns() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOpenCursorsAcrossCommit
				/// </java-name>
				[Dot42.DexImport("supportsOpenCursorsAcrossCommit", "()Z", AccessFlags = 1025)]
				bool SupportsOpenCursorsAcrossCommit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOpenCursorsAcrossRollback
				/// </java-name>
				[Dot42.DexImport("supportsOpenCursorsAcrossRollback", "()Z", AccessFlags = 1025)]
				bool SupportsOpenCursorsAcrossRollback() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOpenStatementsAcrossCommit
				/// </java-name>
				[Dot42.DexImport("supportsOpenStatementsAcrossCommit", "()Z", AccessFlags = 1025)]
				bool SupportsOpenStatementsAcrossCommit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOpenStatementsAcrossRollback
				/// </java-name>
				[Dot42.DexImport("supportsOpenStatementsAcrossRollback", "()Z", AccessFlags = 1025)]
				bool SupportsOpenStatementsAcrossRollback() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOrderByUnrelated
				/// </java-name>
				[Dot42.DexImport("supportsOrderByUnrelated", "()Z", AccessFlags = 1025)]
				bool SupportsOrderByUnrelated() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsOuterJoins() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsPositionedDelete
				/// </java-name>
				[Dot42.DexImport("supportsPositionedDelete", "()Z", AccessFlags = 1025)]
				bool SupportsPositionedDelete() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsPositionedUpdate
				/// </java-name>
				[Dot42.DexImport("supportsPositionedUpdate", "()Z", AccessFlags = 1025)]
				bool SupportsPositionedUpdate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsResultSetConcurrency
				/// </java-name>
				[Dot42.DexImport("supportsResultSetConcurrency", "(II)Z", AccessFlags = 1025)]
				bool SupportsResultSetConcurrency(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsResultSetHoldability
				/// </java-name>
				[Dot42.DexImport("supportsResultSetHoldability", "(I)Z", AccessFlags = 1025)]
				bool SupportsResultSetHoldability(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsResultSetType
				/// </java-name>
				[Dot42.DexImport("supportsResultSetType", "(I)Z", AccessFlags = 1025)]
				bool SupportsResultSetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSavepoints
				/// </java-name>
				[Dot42.DexImport("supportsSavepoints", "()Z", AccessFlags = 1025)]
				bool SupportsSavepoints() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSchemasInDataManipulation
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInDataManipulation", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInDataManipulation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSchemasInIndexDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInIndexDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInIndexDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSchemasInPrivilegeDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInPrivilegeDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInPrivilegeDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSchemasInProcedureCalls
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInProcedureCalls", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInProcedureCalls() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSchemasInTableDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInTableDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInTableDefinitions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSelectForUpdate
				/// </java-name>
				[Dot42.DexImport("supportsSelectForUpdate", "()Z", AccessFlags = 1025)]
				bool SupportsSelectForUpdate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsStatementPooling
				/// </java-name>
				[Dot42.DexImport("supportsStatementPooling", "()Z", AccessFlags = 1025)]
				bool SupportsStatementPooling() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsStoredProcedures
				/// </java-name>
				[Dot42.DexImport("supportsStoredProcedures", "()Z", AccessFlags = 1025)]
				bool SupportsStoredProcedures() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSubqueriesInComparisons
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInComparisons", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInComparisons() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSubqueriesInExists
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInExists", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInExists() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSubqueriesInIns
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInIns", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInIns() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSubqueriesInQuantifieds
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInQuantifieds", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInQuantifieds() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsTableCorrelationNames
				/// </java-name>
				[Dot42.DexImport("supportsTableCorrelationNames", "()Z", AccessFlags = 1025)]
				bool SupportsTableCorrelationNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsTransactionIsolationLevel
				/// </java-name>
				[Dot42.DexImport("supportsTransactionIsolationLevel", "(I)Z", AccessFlags = 1025)]
				bool SupportsTransactionIsolationLevel(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsTransactions
				/// </java-name>
				[Dot42.DexImport("supportsTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsTransactions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsUnion
				/// </java-name>
				[Dot42.DexImport("supportsUnion", "()Z", AccessFlags = 1025)]
				bool SupportsUnion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsUnionAll
				/// </java-name>
				[Dot42.DexImport("supportsUnionAll", "()Z", AccessFlags = 1025)]
				bool SupportsUnionAll() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updatesAreDetected
				/// </java-name>
				[Dot42.DexImport("updatesAreDetected", "(I)Z", AccessFlags = 1025)]
				bool UpdatesAreDetected(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// usesLocalFilePerTable
				/// </java-name>
				[Dot42.DexImport("usesLocalFilePerTable", "()Z", AccessFlags = 1025)]
				bool UsesLocalFilePerTable() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// usesLocalFiles
				/// </java-name>
				[Dot42.DexImport("usesLocalFiles", "()Z", AccessFlags = 1025)]
				bool UsesLocalFiles() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// autoCommitFailureClosesAllResultSets
				/// </java-name>
				[Dot42.DexImport("autoCommitFailureClosesAllResultSets", "()Z", AccessFlags = 1025)]
				bool AutoCommitFailureClosesAllResultSets() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClientInfoProperties
				/// </java-name>
				[Dot42.DexImport("getClientInfoProperties", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetClientInfoProperties() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFunctionColumns
				/// </java-name>
				[Dot42.DexImport("getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetFunctionColumns(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFunctions
				/// </java-name>
				[Dot42.DexImport("getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetFunctions(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRowIdLifetime
				/// </java-name>
				[Dot42.DexImport("getRowIdLifetime", "()Ljava/sql/RowIdLifetime;", AccessFlags = 1025)]
				global::Java.Sql.RowIdLifetime GetRowIdLifetime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemas
				/// </java-name>
				[Dot42.DexImport("getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSchemas(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsStoredFunctionsUsingCallSyntax
				/// </java-name>
				[Dot42.DexImport("supportsStoredFunctionsUsingCallSyntax", "()Z", AccessFlags = 1025)]
				bool SupportsStoredFunctionsUsingCallSyntax() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLTransientException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTransientException", AccessFlags = 33)]
		public partial class SQLTransientException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLTransientException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransientException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransientException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLTransientException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLInput
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLInput", AccessFlags = 1537)]
		public partial interface ISQLInput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// readString
				/// </java-name>
				[Dot42.DexImport("readString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1025)]
				bool ReadBoolean() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte ReadByte() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1025)]
				short ReadShort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1025)]
				int ReadInt() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1025)]
				long ReadLong() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1025)]
				float ReadFloat() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1025)]
				double ReadDouble() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readBigDecimal
				/// </java-name>
				[Dot42.DexImport("readBigDecimal", "()Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal ReadBigDecimal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] ReadBytes() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readDate
				/// </java-name>
				[Dot42.DexImport("readDate", "()Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date ReadDate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readTime
				/// </java-name>
				[Dot42.DexImport("readTime", "()Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time ReadTime() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readTimestamp
				/// </java-name>
				[Dot42.DexImport("readTimestamp", "()Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp ReadTimestamp() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readCharacterStream
				/// </java-name>
				[Dot42.DexImport("readCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader ReadCharacterStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readAsciiStream
				/// </java-name>
				[Dot42.DexImport("readAsciiStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream ReadAsciiStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readBinaryStream
				/// </java-name>
				[Dot42.DexImport("readBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream ReadBinaryStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object ReadObject() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readRef
				/// </java-name>
				[Dot42.DexImport("readRef", "()Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef ReadRef() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readBlob
				/// </java-name>
				[Dot42.DexImport("readBlob", "()Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob ReadBlob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readClob
				/// </java-name>
				[Dot42.DexImport("readClob", "()Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob ReadClob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readArray
				/// </java-name>
				[Dot42.DexImport("readArray", "()Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray ReadArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wasNull
				/// </java-name>
				[Dot42.DexImport("wasNull", "()Z", AccessFlags = 1025)]
				bool WasNull() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readURL
				/// </java-name>
				[Dot42.DexImport("readURL", "()Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL ReadURL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readNClob
				/// </java-name>
				[Dot42.DexImport("readNClob", "()Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob ReadNClob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readNString
				/// </java-name>
				[Dot42.DexImport("readNString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadNString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readSQLXML
				/// </java-name>
				[Dot42.DexImport("readSQLXML", "()Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML ReadSQLXML() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readRowId
				/// </java-name>
				[Dot42.DexImport("readRowId", "()Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId ReadRowId() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/BatchUpdateException
		/// </java-name>
		[Dot42.DexImport("java/sql/BatchUpdateException", AccessFlags = 33)]
		public partial class BatchUpdateException : global::Java.Sql.SQLException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BatchUpdateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(int[] int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;[ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, int[] int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, string string1, int[] int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, string string1, int int32, int[] int321, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([I)V", AccessFlags = 1)]
				public BatchUpdateException(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;[I)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;[I)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, string string1, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I[I)V", AccessFlags = 1)]
				public BatchUpdateException(string @string, string string1, int int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUpdateCounts
				/// </java-name>
				[Dot42.DexImport("getUpdateCounts", "()[I", AccessFlags = 1)]
				public virtual int[] GetUpdateCounts() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getUpdateCounts
				/// </java-name>
				public int[] UpdateCounts
				{
				[Dot42.DexImport("getUpdateCounts", "()[I", AccessFlags = 1)]
						get{ return GetUpdateCounts(); }
				}

		}

		/// <java-name>
		/// java/sql/Clob
		/// </java-name>
		[Dot42.DexImport("java/sql/Clob", AccessFlags = 1537)]
		public partial interface IClob
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAsciiStream
				/// </java-name>
				[Dot42.DexImport("getAsciiStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetAsciiStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSubString
				/// </java-name>
				[Dot42.DexImport("getSubString", "(JI)Ljava/lang/String;", AccessFlags = 1025)]
				string GetSubString(long int64, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1025)]
				long Length() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(Ljava/sql/Clob;J)J", AccessFlags = 1025)]
				long Position(global::Java.Sql.IClob clob, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				long Position(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(J)Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.Io.OutputStream SetAsciiStream(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(J)Ljava/io/Writer;", AccessFlags = 1025)]
				global::Java.Io.Writer SetCharacterStream(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(JLjava/lang/String;)I", AccessFlags = 1025)]
				int SetString(long int64, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(JLjava/lang/String;II)I", AccessFlags = 1025)]
				int SetString(long int64, string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)V", AccessFlags = 1025)]
				void Truncate(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(JJ)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream(long int64, long int641) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Blob
		/// </java-name>
		[Dot42.DexImport("java/sql/Blob", AccessFlags = 1537)]
		public partial interface IBlob
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetBinaryStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "(JJ)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetBinaryStream(long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(JI)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes(long int64, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1025)]
				long Length() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(Ljava/sql/Blob;J)J", AccessFlags = 1025)]
				long Position(global::Java.Sql.IBlob blob, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "([BJ)J", AccessFlags = 1025)]
				long Position(sbyte[] sByte, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(J)Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.Io.OutputStream SetBinaryStream(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(J[B)I", AccessFlags = 1025)]
				int SetBytes(long int64, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(J[BII)I", AccessFlags = 1025)]
				int SetBytes(long int64, sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)V", AccessFlags = 1025)]
				void Truncate(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLRecoverableException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLRecoverableException", AccessFlags = 33)]
		public partial class SQLRecoverableException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLRecoverableException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLRecoverableException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLRecoverableException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLNonTransientConnectionException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLNonTransientConnectionException", AccessFlags = 33)]
		public partial class SQLNonTransientConnectionException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLNonTransientConnectionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLClientInfoException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLClientInfoException", AccessFlags = 33)]
		public partial class SQLClientInfoException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLClientInfoException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;)V")]
				public SQLClientInfoException(global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Map;Ljava/lang/Throwable;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;Ljava/lang/Throwab" +
    "le;)V")]
				public SQLClientInfoException(global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;" +
    ")V")]
				public SQLClientInfoException(string @string, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Throwable;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;" +
    "Ljava/lang/Throwable;)V")]
				public SQLClientInfoException(string @string, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map<Ljava/lang/String;Ljava/sql/" +
    "ClientInfoStatus;>;)V")]
				public SQLClientInfoException(string @string, string string1, int int32, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;Ljava/lang/Throwable;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map<Ljava/lang/String;Ljava/sql/" +
    "ClientInfoStatus;>;Ljava/lang/Throwable;)V")]
				public SQLClientInfoException(string @string, string string1, int int32, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/sql/C" +
    "lientInfoStatus;>;)V")]
				public SQLClientInfoException(string @string, string string1, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/Throwable;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/sql/C" +
    "lientInfoStatus;>;Ljava/lang/Throwable;)V")]
				public SQLClientInfoException(string @string, string string1, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> map, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFailedProperties
				/// </java-name>
				[Dot42.DexImport("getFailedProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;")]
				public virtual global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> GetFailedProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus>);
				}

				/// <java-name>
				/// getFailedProperties
				/// </java-name>
				public global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> FailedProperties
				{
				[Dot42.DexImport("getFailedProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;")]
						get{ return GetFailedProperties(); }
				}

		}

		/// <java-name>
		/// java/sql/Array
		/// </java-name>
		[Dot42.DexImport("java/sql/Array", AccessFlags = 1537)]
		public partial interface IArray
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object GetArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(JI)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetArray(long int64, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(JILjava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetArray(long int64, int int32, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetArray(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBaseType
				/// </java-name>
				[Dot42.DexImport("getBaseType", "()I", AccessFlags = 1025)]
				int GetBaseType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBaseTypeName
				/// </java-name>
				[Dot42.DexImport("getBaseTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetBaseTypeName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetResultSet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(JI)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetResultSet(long int64, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(JILjava/util/Map;)Ljava/sql/ResultSet;", AccessFlags = 1025, Signature = "(JILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/sql/ResultSet;")]
				global::Java.Sql.IResultSet GetResultSet(long int64, int int32, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(Ljava/util/Map;)Ljava/sql/ResultSet;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/sql/ResultSet;")]
				global::Java.Sql.IResultSet GetResultSet(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/NClob
		/// </java-name>
		[Dot42.DexImport("java/sql/NClob", AccessFlags = 1537)]
		public partial interface INClob : global::Java.Sql.IClob
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/sql/PreparedStatement
		/// </java-name>
		[Dot42.DexImport("java/sql/PreparedStatement", AccessFlags = 1537)]
		public partial interface IPreparedStatement : global::Java.Sql.IStatement
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "()V", AccessFlags = 1025)]
				void AddBatch() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				void ClearParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()Z", AccessFlags = 1025)]
				bool Execute() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeQuery
				/// </java-name>
				[Dot42.DexImport("executeQuery", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet ExecuteQuery() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "()I", AccessFlags = 1025)]
				int ExecuteUpdate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetaData
				/// </java-name>
				[Dot42.DexImport("getMetaData", "()Ljava/sql/ResultSetMetaData;", AccessFlags = 1025)]
				global::Java.Sql.IResultSetMetaData GetMetaData() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterMetaData
				/// </java-name>
				[Dot42.DexImport("getParameterMetaData", "()Ljava/sql/ParameterMetaData;", AccessFlags = 1025)]
				global::Java.Sql.IParameterMetaData GetParameterMetaData() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setArray
				/// </java-name>
				[Dot42.DexImport("setArray", "(ILjava/sql/Array;)V", AccessFlags = 1025)]
				void SetArray(int int32, global::Java.Sql.IArray array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(ILjava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(int int32, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(IZ)V", AccessFlags = 1025)]
				void SetBoolean(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(IB)V", AccessFlags = 1025)]
				void SetByte(int int32, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(I[B)V", AccessFlags = 1025)]
				void SetBytes(int int32, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(int int32, global::Java.Io.Reader reader, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(int int32, global::Java.Sql.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(int int32, global::Java.Sql.Date date, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(ID)V", AccessFlags = 1025)]
				void SetDouble(int int32, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(IF)V", AccessFlags = 1025)]
				void SetFloat(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(II)V", AccessFlags = 1025)]
				void SetInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(IJ)V", AccessFlags = 1025)]
				void SetLong(int int32, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(II)V", AccessFlags = 1025)]
				void SetNull(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNull(int int32, int int321, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				void SetObject(int int32, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;I)V", AccessFlags = 1025)]
				void SetObject(int int32, object @object, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;II)V", AccessFlags = 1025)]
				void SetObject(int int32, object @object, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setRef
				/// </java-name>
				[Dot42.DexImport("setRef", "(ILjava/sql/Ref;)V", AccessFlags = 1025)]
				void SetRef(int int32, global::Java.Sql.IRef @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(IS)V", AccessFlags = 1025)]
				void SetShort(int int32, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(int int32, global::Java.Sql.Time time) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(int int32, global::Java.Sql.Time time, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(int int32, global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(int int32, global::Java.Sql.Timestamp timestamp, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUnicodeStream
				/// </java-name>
				[Dot42.DexImport("setUnicodeStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetUnicodeStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(ILjava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(int int32, global::Java.Net.URL uRL) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(ILjava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(int int32, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(ILjava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(int int32, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetAsciiStream(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBinaryStream(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Wrapper
		/// </java-name>
		[Dot42.DexImport("java/sql/Wrapper", AccessFlags = 1537)]
		public partial interface IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)TT;")]
				T Unwrap<T>(global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isWrapperFor
				/// </java-name>
				[Dot42.DexImport("isWrapperFor", "(Ljava/lang/Class;)Z", AccessFlags = 1025, Signature = "(Ljava/lang/Class<*>;)Z")]
				bool IsWrapperFor(global::System.Type type) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Connection
		/// </java-name>
		[Dot42.DexImport("java/sql/Connection", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnectionConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRANSACTION_NONE
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_NONE", "I", AccessFlags = 25)]
				public const int TRANSACTION_NONE = 0;
				/// <java-name>
				/// TRANSACTION_READ_COMMITTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_READ_COMMITTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_READ_COMMITTED = 2;
				/// <java-name>
				/// TRANSACTION_READ_UNCOMMITTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_READ_UNCOMMITTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_READ_UNCOMMITTED = 1;
				/// <java-name>
				/// TRANSACTION_REPEATABLE_READ
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_REPEATABLE_READ", "I", AccessFlags = 25)]
				public const int TRANSACTION_REPEATABLE_READ = 4;
				/// <java-name>
				/// TRANSACTION_SERIALIZABLE
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_SERIALIZABLE", "I", AccessFlags = 25)]
				public const int TRANSACTION_SERIALIZABLE = 8;
		}

		/// <java-name>
		/// java/sql/Connection
		/// </java-name>
		[Dot42.DexImport("java/sql/Connection", AccessFlags = 1537)]
		public partial interface IConnection : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clearWarnings
				/// </java-name>
				[Dot42.DexImport("clearWarnings", "()V", AccessFlags = 1025)]
				void ClearWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()V", AccessFlags = 1025)]
				void Commit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "()Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "(II)Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "(III)Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement(int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAutoCommit
				/// </java-name>
				[Dot42.DexImport("getAutoCommit", "()Z", AccessFlags = 1025)]
				bool GetAutoCommit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCatalog
				/// </java-name>
				[Dot42.DexImport("getCatalog", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCatalog() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHoldability
				/// </java-name>
				[Dot42.DexImport("getHoldability", "()I", AccessFlags = 1025)]
				int GetHoldability() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetaData
				/// </java-name>
				[Dot42.DexImport("getMetaData", "()Ljava/sql/DatabaseMetaData;", AccessFlags = 1025)]
				global::Java.Sql.IDatabaseMetaData GetMetaData() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTransactionIsolation
				/// </java-name>
				[Dot42.DexImport("getTransactionIsolation", "()I", AccessFlags = 1025)]
				int GetTransactionIsolation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTypeMap
				/// </java-name>
				[Dot42.DexImport("getTypeMap", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;")]
				global::Java.Util.IMap<string, global::System.Type> GetTypeMap() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWarnings
				/// </java-name>
				[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
				global::Java.Sql.SQLWarning GetWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
				bool IsClosed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
				bool IsReadOnly() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nativeSQL
				/// </java-name>
				[Dot42.DexImport("nativeSQL", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string NativeSQL(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;II)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;III)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string @string, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;I)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;[I)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;II)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;III)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// releaseSavepoint
				/// </java-name>
				[Dot42.DexImport("releaseSavepoint", "(Ljava/sql/Savepoint;)V", AccessFlags = 1025)]
				void ReleaseSavepoint(global::Java.Sql.ISavepoint savepoint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rollback
				/// </java-name>
				[Dot42.DexImport("rollback", "()V", AccessFlags = 1025)]
				void Rollback() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rollback
				/// </java-name>
				[Dot42.DexImport("rollback", "(Ljava/sql/Savepoint;)V", AccessFlags = 1025)]
				void Rollback(global::Java.Sql.ISavepoint savepoint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAutoCommit
				/// </java-name>
				[Dot42.DexImport("setAutoCommit", "(Z)V", AccessFlags = 1025)]
				void SetAutoCommit(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCatalog
				/// </java-name>
				[Dot42.DexImport("setCatalog", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCatalog(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHoldability
				/// </java-name>
				[Dot42.DexImport("setHoldability", "(I)V", AccessFlags = 1025)]
				void SetHoldability(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "(Z)V", AccessFlags = 1025)]
				void SetReadOnly(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSavepoint
				/// </java-name>
				[Dot42.DexImport("setSavepoint", "()Ljava/sql/Savepoint;", AccessFlags = 1025)]
				global::Java.Sql.ISavepoint SetSavepoint() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSavepoint
				/// </java-name>
				[Dot42.DexImport("setSavepoint", "(Ljava/lang/String;)Ljava/sql/Savepoint;", AccessFlags = 1025)]
				global::Java.Sql.ISavepoint SetSavepoint(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTransactionIsolation
				/// </java-name>
				[Dot42.DexImport("setTransactionIsolation", "(I)V", AccessFlags = 1025)]
				void SetTransactionIsolation(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTypeMap
				/// </java-name>
				[Dot42.DexImport("setTypeMap", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)V")]
				void SetTypeMap(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createClob
				/// </java-name>
				[Dot42.DexImport("createClob", "()Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob CreateClob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createBlob
				/// </java-name>
				[Dot42.DexImport("createBlob", "()Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob CreateBlob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createNClob
				/// </java-name>
				[Dot42.DexImport("createNClob", "()Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob CreateNClob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSQLXML
				/// </java-name>
				[Dot42.DexImport("createSQLXML", "()Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML CreateSQLXML() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "(I)Z", AccessFlags = 1025)]
				bool IsValid(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClientInfo
				/// </java-name>
				[Dot42.DexImport("setClientInfo", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetClientInfo(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClientInfo
				/// </java-name>
				[Dot42.DexImport("setClientInfo", "(Ljava/util/Properties;)V", AccessFlags = 1025)]
				void SetClientInfo(global::Java.Util.Properties properties) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClientInfo
				/// </java-name>
				[Dot42.DexImport("getClientInfo", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetClientInfo(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClientInfo
				/// </java-name>
				[Dot42.DexImport("getClientInfo", "()Ljava/util/Properties;", AccessFlags = 1025)]
				global::Java.Util.Properties GetClientInfo() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createArrayOf
				/// </java-name>
				[Dot42.DexImport("createArrayOf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray CreateArrayOf(string @string, object[] @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createStruct
				/// </java-name>
				[Dot42.DexImport("createStruct", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Struct;", AccessFlags = 1025)]
				global::Java.Sql.IStruct CreateStruct(string @string, object[] @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/RowIdLifetime
		/// </java-name>
		[Dot42.DexImport("java/sql/RowIdLifetime", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/sql/RowIdLifetime;>;")]
		public sealed class RowIdLifetime
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ROWID_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("ROWID_UNSUPPORTED", "Ljava/sql/RowIdLifetime;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.RowIdLifetime ROWID_UNSUPPORTED;
				/// <java-name>
				/// ROWID_VALID_FOREVER
				/// </java-name>
				[Dot42.DexImport("ROWID_VALID_FOREVER", "Ljava/sql/RowIdLifetime;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.RowIdLifetime ROWID_VALID_FOREVER;
				/// <java-name>
				/// ROWID_VALID_OTHER
				/// </java-name>
				[Dot42.DexImport("ROWID_VALID_OTHER", "Ljava/sql/RowIdLifetime;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.RowIdLifetime ROWID_VALID_OTHER;
				/// <java-name>
				/// ROWID_VALID_SESSION
				/// </java-name>
				[Dot42.DexImport("ROWID_VALID_SESSION", "Ljava/sql/RowIdLifetime;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.RowIdLifetime ROWID_VALID_SESSION;
				/// <java-name>
				/// ROWID_VALID_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("ROWID_VALID_TRANSACTION", "Ljava/sql/RowIdLifetime;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.RowIdLifetime ROWID_VALID_TRANSACTION;
				private RowIdLifetime() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/sql/RowIdLifetime;", AccessFlags = 9)]
				public static global::Java.Sql.RowIdLifetime[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.RowIdLifetime[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/RowIdLifetime;", AccessFlags = 9)]
				public static global::Java.Sql.RowIdLifetime ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.RowIdLifetime);
				}

		}

		/// <java-name>
		/// java/sql/DataTruncation
		/// </java-name>
		[Dot42.DexImport("java/sql/DataTruncation", AccessFlags = 33)]
		public partial class DataTruncation : global::Java.Sql.SQLWarning, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IZZII)V", AccessFlags = 1)]
				public DataTruncation(int int32, bool boolean, bool boolean1, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZZIILjava/lang/Throwable;)V", AccessFlags = 1)]
				public DataTruncation(int int32, bool boolean, bool boolean1, int int321, int int322, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDataSize
				/// </java-name>
				[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
				public virtual int GetDataSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "()Z", AccessFlags = 1)]
				public virtual bool GetParameter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getRead
				/// </java-name>
				[Dot42.DexImport("getRead", "()Z", AccessFlags = 1)]
				public virtual bool GetRead() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTransferSize
				/// </java-name>
				[Dot42.DexImport("getTransferSize", "()I", AccessFlags = 1)]
				public virtual int GetTransferSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DataTruncation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDataSize
				/// </java-name>
				public int DataSize
				{
				[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
						get{ return GetDataSize(); }
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				public bool IsParameter
				{
				[Dot42.DexImport("getParameter", "()Z", AccessFlags = 1)]
						get{ return GetParameter(); }
				}

				/// <java-name>
				/// getRead
				/// </java-name>
				public bool IsRead
				{
				[Dot42.DexImport("getRead", "()Z", AccessFlags = 1)]
						get{ return GetRead(); }
				}

				/// <java-name>
				/// getTransferSize
				/// </java-name>
				public int TransferSize
				{
				[Dot42.DexImport("getTransferSize", "()I", AccessFlags = 1)]
						get{ return GetTransferSize(); }
				}

		}

		/// <java-name>
		/// java/sql/Ref
		/// </java-name>
		[Dot42.DexImport("java/sql/Ref", AccessFlags = 1537)]
		public partial interface IRef
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBaseTypeName
				/// </java-name>
				[Dot42.DexImport("getBaseTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetBaseTypeName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetObject(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetObject(object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLFeatureNotSupportedException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLFeatureNotSupportedException", AccessFlags = 33)]
		public partial class SQLFeatureNotSupportedException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLTimeoutException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTimeoutException", AccessFlags = 33)]
		public partial class SQLTimeoutException : global::Java.Sql.SQLTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLTimeoutException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTimeoutException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTimeoutException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/Time
		/// </java-name>
		[Dot42.DexImport("java/sql/Time", AccessFlags = 33)]
		public partial class Time : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Time(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Time(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()I", AccessFlags = 1)]
				public override int GetDate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDay
				/// </java-name>
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
				public override int GetDay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
				public override int GetMonth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
				public override int GetYear() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(I)V", AccessFlags = 1)]
				public override void SetDate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMonth
				/// </java-name>
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
				public override void SetMonth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setYear
				/// </java-name>
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
				public override void SetYear(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public override void SetTime(long int64) /* MethodBuilder.Create */ 
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
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Time;", AccessFlags = 9)]
				public static global::Java.Sql.Time ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Time);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Time() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDay
				/// </java-name>
				public int Day
				{
				[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
						get{ return GetDay(); }
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public int Month
				{
				[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return GetMonth(); }
				[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
						set{ SetMonth(value); }
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public int Year
				{
				[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return GetYear(); }
				[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
						set{ SetYear(value); }
				}

		}

		/// <java-name>
		/// java/sql/SQLDataException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLDataException", AccessFlags = 33)]
		public partial class SQLDataException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLDataException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLDataException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLDataException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLDataException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLDataException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLDataException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLDataException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLDataException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLIntegrityConstraintViolationException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLIntegrityConstraintViolationException", AccessFlags = 33)]
		public partial class SQLIntegrityConstraintViolationException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/ResultSet
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSet", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IResultSetConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CLOSE_CURSORS_AT_COMMIT
				/// </java-name>
				[Dot42.DexImport("CLOSE_CURSORS_AT_COMMIT", "I", AccessFlags = 25)]
				public const int CLOSE_CURSORS_AT_COMMIT = 2;
				/// <java-name>
				/// HOLD_CURSORS_OVER_COMMIT
				/// </java-name>
				[Dot42.DexImport("HOLD_CURSORS_OVER_COMMIT", "I", AccessFlags = 25)]
				public const int HOLD_CURSORS_OVER_COMMIT = 1;
				/// <java-name>
				/// CONCUR_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("CONCUR_READ_ONLY", "I", AccessFlags = 25)]
				public const int CONCUR_READ_ONLY = 1007;
				/// <java-name>
				/// CONCUR_UPDATABLE
				/// </java-name>
				[Dot42.DexImport("CONCUR_UPDATABLE", "I", AccessFlags = 25)]
				public const int CONCUR_UPDATABLE = 1008;
				/// <java-name>
				/// FETCH_FORWARD
				/// </java-name>
				[Dot42.DexImport("FETCH_FORWARD", "I", AccessFlags = 25)]
				public const int FETCH_FORWARD = 1000;
				/// <java-name>
				/// FETCH_REVERSE
				/// </java-name>
				[Dot42.DexImport("FETCH_REVERSE", "I", AccessFlags = 25)]
				public const int FETCH_REVERSE = 1001;
				/// <java-name>
				/// FETCH_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("FETCH_UNKNOWN", "I", AccessFlags = 25)]
				public const int FETCH_UNKNOWN = 1002;
				/// <java-name>
				/// TYPE_FORWARD_ONLY
				/// </java-name>
				[Dot42.DexImport("TYPE_FORWARD_ONLY", "I", AccessFlags = 25)]
				public const int TYPE_FORWARD_ONLY = 1003;
				/// <java-name>
				/// TYPE_SCROLL_INSENSITIVE
				/// </java-name>
				[Dot42.DexImport("TYPE_SCROLL_INSENSITIVE", "I", AccessFlags = 25)]
				public const int TYPE_SCROLL_INSENSITIVE = 1004;
				/// <java-name>
				/// TYPE_SCROLL_SENSITIVE
				/// </java-name>
				[Dot42.DexImport("TYPE_SCROLL_SENSITIVE", "I", AccessFlags = 25)]
				public const int TYPE_SCROLL_SENSITIVE = 1005;
		}

		/// <java-name>
		/// java/sql/ResultSet
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSet", AccessFlags = 1537)]
		public partial interface IResultSet : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// absolute
				/// </java-name>
				[Dot42.DexImport("absolute", "(I)Z", AccessFlags = 1025)]
				bool Absolute(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// afterLast
				/// </java-name>
				[Dot42.DexImport("afterLast", "()V", AccessFlags = 1025)]
				void AfterLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// beforeFirst
				/// </java-name>
				[Dot42.DexImport("beforeFirst", "()V", AccessFlags = 1025)]
				void BeforeFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cancelRowUpdates
				/// </java-name>
				[Dot42.DexImport("cancelRowUpdates", "()V", AccessFlags = 1025)]
				void CancelRowUpdates() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearWarnings
				/// </java-name>
				[Dot42.DexImport("clearWarnings", "()V", AccessFlags = 1025)]
				void ClearWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteRow
				/// </java-name>
				[Dot42.DexImport("deleteRow", "()V", AccessFlags = 1025)]
				void DeleteRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// findColumn
				/// </java-name>
				[Dot42.DexImport("findColumn", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int FindColumn(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()Z", AccessFlags = 1025)]
				bool First() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(I)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(Ljava/lang/String;)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAsciiStream
				/// </java-name>
				[Dot42.DexImport("getAsciiStream", "(I)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetAsciiStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAsciiStream
				/// </java-name>
				[Dot42.DexImport("getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetAsciiStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(I)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(II)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "(I)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetBinaryStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetBinaryStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1025)]
				bool GetBoolean(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetBoolean(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(I)B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte GetByte(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte GetByte(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(I)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConcurrency
				/// </java-name>
				[Dot42.DexImport("getConcurrency", "()I", AccessFlags = 1025)]
				int GetConcurrency() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCursorName
				/// </java-name>
				[Dot42.DexImport("getCursorName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCursorName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(I)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				double GetDouble(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1025)]
				double GetDouble(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFetchDirection
				/// </java-name>
				[Dot42.DexImport("getFetchDirection", "()I", AccessFlags = 1025)]
				int GetFetchDirection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFetchSize
				/// </java-name>
				[Dot42.DexImport("getFetchSize", "()I", AccessFlags = 1025)]
				int GetFetchSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				float GetFloat(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;)F", AccessFlags = 1025)]
				float GetFloat(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				int GetInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetInt(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				long GetLong(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1025)]
				long GetLong(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetaData
				/// </java-name>
				[Dot42.DexImport("getMetaData", "()Ljava/sql/ResultSetMetaData;", AccessFlags = 1025)]
				global::Java.Sql.IResultSetMetaData GetMetaData() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(ILjava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(ILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetObject(int int32, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/" +
    "lang/Object;")]
				object GetObject(string @string, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(I)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRow
				/// </java-name>
				[Dot42.DexImport("getRow", "()I", AccessFlags = 1025)]
				int GetRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				short GetShort(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;)S", AccessFlags = 1025)]
				short GetShort(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStatement
				/// </java-name>
				[Dot42.DexImport("getStatement", "()Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement GetStatement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(I)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(I)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()I", AccessFlags = 1025)]
				int GetType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUnicodeStream
				/// </java-name>
				[Dot42.DexImport("getUnicodeStream", "(I)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetUnicodeStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUnicodeStream
				/// </java-name>
				[Dot42.DexImport("getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetUnicodeStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(I)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWarnings
				/// </java-name>
				[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
				global::Java.Sql.SQLWarning GetWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insertRow
				/// </java-name>
				[Dot42.DexImport("insertRow", "()V", AccessFlags = 1025)]
				void InsertRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1025)]
				bool IsAfterLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1025)]
				bool IsBeforeFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1025)]
				bool IsFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 1025)]
				bool IsLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()Z", AccessFlags = 1025)]
				bool Last() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToCurrentRow
				/// </java-name>
				[Dot42.DexImport("moveToCurrentRow", "()V", AccessFlags = 1025)]
				void MoveToCurrentRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToInsertRow
				/// </java-name>
				[Dot42.DexImport("moveToInsertRow", "()V", AccessFlags = 1025)]
				void MoveToInsertRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Z", AccessFlags = 1025)]
				bool Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()Z", AccessFlags = 1025)]
				bool Previous() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// refreshRow
				/// </java-name>
				[Dot42.DexImport("refreshRow", "()V", AccessFlags = 1025)]
				void RefreshRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// relative
				/// </java-name>
				[Dot42.DexImport("relative", "(I)Z", AccessFlags = 1025)]
				bool Relative(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rowDeleted
				/// </java-name>
				[Dot42.DexImport("rowDeleted", "()Z", AccessFlags = 1025)]
				bool RowDeleted() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rowInserted
				/// </java-name>
				[Dot42.DexImport("rowInserted", "()Z", AccessFlags = 1025)]
				bool RowInserted() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rowUpdated
				/// </java-name>
				[Dot42.DexImport("rowUpdated", "()Z", AccessFlags = 1025)]
				bool RowUpdated() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFetchDirection
				/// </java-name>
				[Dot42.DexImport("setFetchDirection", "(I)V", AccessFlags = 1025)]
				void SetFetchDirection(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFetchSize
				/// </java-name>
				[Dot42.DexImport("setFetchSize", "(I)V", AccessFlags = 1025)]
				void SetFetchSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateArray
				/// </java-name>
				[Dot42.DexImport("updateArray", "(ILjava/sql/Array;)V", AccessFlags = 1025)]
				void UpdateArray(int int32, global::Java.Sql.IArray array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateArray
				/// </java-name>
				[Dot42.DexImport("updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V", AccessFlags = 1025)]
				void UpdateArray(string @string, global::Java.Sql.IArray array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateAsciiStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBigDecimal
				/// </java-name>
				[Dot42.DexImport("updateBigDecimal", "(ILjava/math/BigDecimal;)V", AccessFlags = 1025)]
				void UpdateBigDecimal(int int32, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBigDecimal
				/// </java-name>
				[Dot42.DexImport("updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void UpdateBigDecimal(string @string, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateBinaryStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(ILjava/sql/Blob;)V", AccessFlags = 1025)]
				void UpdateBlob(int int32, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void UpdateBlob(string @string, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBoolean
				/// </java-name>
				[Dot42.DexImport("updateBoolean", "(IZ)V", AccessFlags = 1025)]
				void UpdateBoolean(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBoolean
				/// </java-name>
				[Dot42.DexImport("updateBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void UpdateBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateByte
				/// </java-name>
				[Dot42.DexImport("updateByte", "(IB)V", AccessFlags = 1025)]
				void UpdateByte(int int32, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateByte
				/// </java-name>
				[Dot42.DexImport("updateByte", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
				void UpdateByte(string @string, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBytes
				/// </java-name>
				[Dot42.DexImport("updateBytes", "(I[B)V", AccessFlags = 1025)]
				void UpdateBytes(int int32, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBytes
				/// </java-name>
				[Dot42.DexImport("updateBytes", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				void UpdateBytes(string @string, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.Io.Reader reader, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(ILjava/sql/Clob;)V", AccessFlags = 1025)]
				void UpdateClob(int int32, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void UpdateClob(string @string, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(ILjava/sql/Date;)V", AccessFlags = 1025)]
				void UpdateDate(int int32, global::Java.Sql.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V", AccessFlags = 1025)]
				void UpdateDate(string @string, global::Java.Sql.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateDouble
				/// </java-name>
				[Dot42.DexImport("updateDouble", "(ID)V", AccessFlags = 1025)]
				void UpdateDouble(int int32, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateDouble
				/// </java-name>
				[Dot42.DexImport("updateDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				void UpdateDouble(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateFloat
				/// </java-name>
				[Dot42.DexImport("updateFloat", "(IF)V", AccessFlags = 1025)]
				void UpdateFloat(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateFloat
				/// </java-name>
				[Dot42.DexImport("updateFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				void UpdateFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateInt
				/// </java-name>
				[Dot42.DexImport("updateInt", "(II)V", AccessFlags = 1025)]
				void UpdateInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateInt
				/// </java-name>
				[Dot42.DexImport("updateInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void UpdateInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateLong
				/// </java-name>
				[Dot42.DexImport("updateLong", "(IJ)V", AccessFlags = 1025)]
				void UpdateLong(int int32, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateLong
				/// </java-name>
				[Dot42.DexImport("updateLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void UpdateLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNull
				/// </java-name>
				[Dot42.DexImport("updateNull", "(I)V", AccessFlags = 1025)]
				void UpdateNull(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNull
				/// </java-name>
				[Dot42.DexImport("updateNull", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void UpdateNull(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateObject
				/// </java-name>
				[Dot42.DexImport("updateObject", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				void UpdateObject(int int32, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateObject
				/// </java-name>
				[Dot42.DexImport("updateObject", "(ILjava/lang/Object;I)V", AccessFlags = 1025)]
				void UpdateObject(int int32, object @object, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateObject
				/// </java-name>
				[Dot42.DexImport("updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void UpdateObject(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateObject
				/// </java-name>
				[Dot42.DexImport("updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", AccessFlags = 1025)]
				void UpdateObject(string @string, object @object, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateRef
				/// </java-name>
				[Dot42.DexImport("updateRef", "(ILjava/sql/Ref;)V", AccessFlags = 1025)]
				void UpdateRef(int int32, global::Java.Sql.IRef @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateRef
				/// </java-name>
				[Dot42.DexImport("updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V", AccessFlags = 1025)]
				void UpdateRef(string @string, global::Java.Sql.IRef @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateRow
				/// </java-name>
				[Dot42.DexImport("updateRow", "()V", AccessFlags = 1025)]
				void UpdateRow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateShort
				/// </java-name>
				[Dot42.DexImport("updateShort", "(IS)V", AccessFlags = 1025)]
				void UpdateShort(int int32, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateShort
				/// </java-name>
				[Dot42.DexImport("updateShort", "(Ljava/lang/String;S)V", AccessFlags = 1025)]
				void UpdateShort(string @string, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateString
				/// </java-name>
				[Dot42.DexImport("updateString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void UpdateString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateString
				/// </java-name>
				[Dot42.DexImport("updateString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void UpdateString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateTime
				/// </java-name>
				[Dot42.DexImport("updateTime", "(ILjava/sql/Time;)V", AccessFlags = 1025)]
				void UpdateTime(int int32, global::Java.Sql.Time time) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateTime
				/// </java-name>
				[Dot42.DexImport("updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V", AccessFlags = 1025)]
				void UpdateTime(string @string, global::Java.Sql.Time time) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateTimestamp
				/// </java-name>
				[Dot42.DexImport("updateTimestamp", "(ILjava/sql/Timestamp;)V", AccessFlags = 1025)]
				void UpdateTimestamp(int int32, global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateTimestamp
				/// </java-name>
				[Dot42.DexImport("updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void UpdateTimestamp(string @string, global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wasNull
				/// </java-name>
				[Dot42.DexImport("wasNull", "()Z", AccessFlags = 1025)]
				bool WasNull() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(I)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateRowId
				/// </java-name>
				[Dot42.DexImport("updateRowId", "(ILjava/sql/RowId;)V", AccessFlags = 1025)]
				void UpdateRowId(int int32, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateRowId
				/// </java-name>
				[Dot42.DexImport("updateRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void UpdateRowId(string @string, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getHoldability
				/// </java-name>
				[Dot42.DexImport("getHoldability", "()I", AccessFlags = 1025)]
				int GetHoldability() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
				bool IsClosed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNString
				/// </java-name>
				[Dot42.DexImport("updateNString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void UpdateNString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNString
				/// </java-name>
				[Dot42.DexImport("updateNString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void UpdateNString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(ILjava/sql/NClob;)V", AccessFlags = 1025)]
				void UpdateNClob(int int32, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void UpdateNClob(string @string, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(I)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(I)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateSQLXML
				/// </java-name>
				[Dot42.DexImport("updateSQLXML", "(ILjava/sql/SQLXML;)V", AccessFlags = 1025)]
				void UpdateSQLXML(int int32, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateSQLXML
				/// </java-name>
				[Dot42.DexImport("updateSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void UpdateSQLXML(string @string, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetNCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetNCharacterStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateAsciiStream(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBinaryStream(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBlob(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBlob(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateAsciiStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBinaryStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBlob(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBlob(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLNonTransientException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLNonTransientException", AccessFlags = 33)]
		public partial class SQLNonTransientException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLNonTransientException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLSyntaxErrorException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLSyntaxErrorException", AccessFlags = 33)]
		public partial class SQLSyntaxErrorException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLSyntaxErrorException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLTransactionRollbackException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTransactionRollbackException", AccessFlags = 33)]
		public partial class SQLTransactionRollbackException : global::Java.Sql.SQLTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLTransactionRollbackException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/Struct
		/// </java-name>
		[Dot42.DexImport("java/sql/Struct", AccessFlags = 1537)]
		public partial interface IStruct
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSQLTypeName
				/// </java-name>
				[Dot42.DexImport("getSQLTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSQLTypeName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] GetAttributes() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)[Ljava/lang/Object;")]
				object[] GetAttributes(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/ClientInfoStatus
		/// </java-name>
		[Dot42.DexImport("java/sql/ClientInfoStatus", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/sql/ClientInfoStatus;>;")]
		public sealed class ClientInfoStatus
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// REASON_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("REASON_UNKNOWN", "Ljava/sql/ClientInfoStatus;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.ClientInfoStatus REASON_UNKNOWN;
				/// <java-name>
				/// REASON_UNKNOWN_PROPERTY
				/// </java-name>
				[Dot42.DexImport("REASON_UNKNOWN_PROPERTY", "Ljava/sql/ClientInfoStatus;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.ClientInfoStatus REASON_UNKNOWN_PROPERTY;
				/// <java-name>
				/// REASON_VALUE_INVALID
				/// </java-name>
				[Dot42.DexImport("REASON_VALUE_INVALID", "Ljava/sql/ClientInfoStatus;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.ClientInfoStatus REASON_VALUE_INVALID;
				/// <java-name>
				/// REASON_VALUE_TRUNCATED
				/// </java-name>
				[Dot42.DexImport("REASON_VALUE_TRUNCATED", "Ljava/sql/ClientInfoStatus;", AccessFlags = 16409)]
				public static readonly global::Java.Sql.ClientInfoStatus REASON_VALUE_TRUNCATED;
				private ClientInfoStatus() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/sql/ClientInfoStatus;", AccessFlags = 9)]
				public static global::Java.Sql.ClientInfoStatus[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.ClientInfoStatus[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/ClientInfoStatus;", AccessFlags = 9)]
				public static global::Java.Sql.ClientInfoStatus ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.ClientInfoStatus);
				}

		}

		/// <java-name>
		/// java/sql/Timestamp
		/// </java-name>
		[Dot42.DexImport("java/sql/Timestamp", AccessFlags = 33)]
		public partial class Timestamp : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IIIIIII)V", AccessFlags = 1)]
				public Timestamp(int int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Timestamp(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool After(global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Date;)I", AccessFlags = 1)]
				public override int CompareTo(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/sql/Timestamp;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool Equals(global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getNanos
				/// </java-name>
				[Dot42.DexImport("getNanos", "()I", AccessFlags = 1)]
				public virtual int GetNanos() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
				public override long GetTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setNanos
				/// </java-name>
				[Dot42.DexImport("setNanos", "(I)V", AccessFlags = 1)]
				public virtual void SetNanos(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public override void SetTime(long int64) /* MethodBuilder.Create */ 
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
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Timestamp;", AccessFlags = 9)]
				public static global::Java.Sql.Timestamp ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Timestamp);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Timestamp() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNanos
				/// </java-name>
				public int Nanos
				{
				[Dot42.DexImport("getNanos", "()I", AccessFlags = 1)]
						get{ return GetNanos(); }
				[Dot42.DexImport("setNanos", "(I)V", AccessFlags = 1)]
						set{ SetNanos(value); }
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				public long Time
				{
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return GetTime(); }
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ SetTime(value); }
				}

		}

		/// <java-name>
		/// java/sql/SQLOutput
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLOutput", AccessFlags = 1537)]
		public partial interface ISQLOutput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// writeString
				/// </java-name>
				[Dot42.DexImport("writeString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1025)]
				void WriteBoolean(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 1025)]
				void WriteByte(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(S)V", AccessFlags = 1025)]
				void WriteShort(short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1025)]
				void WriteInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1025)]
				void WriteLong(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1025)]
				void WriteFloat(float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1025)]
				void WriteDouble(double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBigDecimal
				/// </java-name>
				[Dot42.DexImport("writeBigDecimal", "(Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void WriteBigDecimal(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([B)V", AccessFlags = 1025)]
				void WriteBytes(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeDate
				/// </java-name>
				[Dot42.DexImport("writeDate", "(Ljava/sql/Date;)V", AccessFlags = 1025)]
				void WriteDate(global::Java.Sql.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeTime
				/// </java-name>
				[Dot42.DexImport("writeTime", "(Ljava/sql/Time;)V", AccessFlags = 1025)]
				void WriteTime(global::Java.Sql.Time time) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeTimestamp
				/// </java-name>
				[Dot42.DexImport("writeTimestamp", "(Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void WriteTimestamp(global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeCharacterStream
				/// </java-name>
				[Dot42.DexImport("writeCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
				void WriteCharacterStream(global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeAsciiStream
				/// </java-name>
				[Dot42.DexImport("writeAsciiStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void WriteAsciiStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBinaryStream
				/// </java-name>
				[Dot42.DexImport("writeBinaryStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void WriteBinaryStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/sql/SQLData;)V", AccessFlags = 1025)]
				void WriteObject(global::Java.Sql.ISQLData sQLData) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeRef
				/// </java-name>
				[Dot42.DexImport("writeRef", "(Ljava/sql/Ref;)V", AccessFlags = 1025)]
				void WriteRef(global::Java.Sql.IRef @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBlob
				/// </java-name>
				[Dot42.DexImport("writeBlob", "(Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void WriteBlob(global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeClob
				/// </java-name>
				[Dot42.DexImport("writeClob", "(Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void WriteClob(global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeStruct
				/// </java-name>
				[Dot42.DexImport("writeStruct", "(Ljava/sql/Struct;)V", AccessFlags = 1025)]
				void WriteStruct(global::Java.Sql.IStruct @struct) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeArray
				/// </java-name>
				[Dot42.DexImport("writeArray", "(Ljava/sql/Array;)V", AccessFlags = 1025)]
				void WriteArray(global::Java.Sql.IArray array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeURL
				/// </java-name>
				[Dot42.DexImport("writeURL", "(Ljava/net/URL;)V", AccessFlags = 1025)]
				void WriteURL(global::Java.Net.URL uRL) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNString
				/// </java-name>
				[Dot42.DexImport("writeNString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteNString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNClob
				/// </java-name>
				[Dot42.DexImport("writeNClob", "(Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void WriteNClob(global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeRowId
				/// </java-name>
				[Dot42.DexImport("writeRowId", "(Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void WriteRowId(global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeSQLXML
				/// </java-name>
				[Dot42.DexImport("writeSQLXML", "(Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void WriteSQLXML(global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/CallableStatement
		/// </java-name>
		[Dot42.DexImport("java/sql/CallableStatement", AccessFlags = 1537)]
		public partial interface ICallableStatement : global::Java.Sql.IPreparedStatement
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(I)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(Ljava/lang/String;)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(I)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(II)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1025)]
				bool GetBoolean(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetBoolean(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(I)B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte GetByte(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte GetByte(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(I)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(I)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				double GetDouble(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1025)]
				double GetDouble(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				float GetFloat(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;)F", AccessFlags = 1025)]
				float GetFloat(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				int GetInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetInt(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				long GetLong(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1025)]
				long GetLong(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(ILjava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(ILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetObject(int int32, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/" +
    "lang/Object;")]
				object GetObject(string @string, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(I)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				short GetShort(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;)S", AccessFlags = 1025)]
				short GetShort(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(I)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(I)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int int32, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string @string, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(I)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(II)V", AccessFlags = 1025)]
				void RegisterOutParameter(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(III)V", AccessFlags = 1025)]
				void RegisterOutParameter(int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void RegisterOutParameter(int int32, int int321, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void RegisterOutParameter(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;II)V", AccessFlags = 1025)]
				void RegisterOutParameter(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void RegisterOutParameter(string @string, int int32, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(string @string, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
				void SetByte(string @string, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				void SetBytes(string @string, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(string @string, global::Java.Sql.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(string @string, global::Java.Sql.Date date, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				void SetDouble(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				void SetFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void SetLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetNull(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNull(string @string, int int32, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetObject(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", AccessFlags = 1025)]
				void SetObject(string @string, object @object, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void SetObject(string @string, object @object, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/String;S)V", AccessFlags = 1025)]
				void SetShort(string @string, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(string @string, global::Java.Sql.Time time) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(string @string, global::Java.Sql.Time time, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(string @string, global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(string @string, global::Java.Sql.Timestamp timestamp, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/lang/String;Ljava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(string @string, global::Java.Net.URL uRL) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wasNull
				/// </java-name>
				[Dot42.DexImport("wasNull", "()Z", AccessFlags = 1025)]
				bool WasNull() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(I)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(string @string, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(I)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(string @string, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(I)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetNCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetNCharacterStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Statement
		/// </java-name>
		[Dot42.DexImport("java/sql/Statement", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IStatementConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CLOSE_ALL_RESULTS
				/// </java-name>
				[Dot42.DexImport("CLOSE_ALL_RESULTS", "I", AccessFlags = 25)]
				public const int CLOSE_ALL_RESULTS = 3;
				/// <java-name>
				/// CLOSE_CURRENT_RESULT
				/// </java-name>
				[Dot42.DexImport("CLOSE_CURRENT_RESULT", "I", AccessFlags = 25)]
				public const int CLOSE_CURRENT_RESULT = 1;
				/// <java-name>
				/// EXECUTE_FAILED
				/// </java-name>
				[Dot42.DexImport("EXECUTE_FAILED", "I", AccessFlags = 25)]
				public const int EXECUTE_FAILED = -3;
				/// <java-name>
				/// KEEP_CURRENT_RESULT
				/// </java-name>
				[Dot42.DexImport("KEEP_CURRENT_RESULT", "I", AccessFlags = 25)]
				public const int KEEP_CURRENT_RESULT = 2;
				/// <java-name>
				/// NO_GENERATED_KEYS
				/// </java-name>
				[Dot42.DexImport("NO_GENERATED_KEYS", "I", AccessFlags = 25)]
				public const int NO_GENERATED_KEYS = 2;
				/// <java-name>
				/// RETURN_GENERATED_KEYS
				/// </java-name>
				[Dot42.DexImport("RETURN_GENERATED_KEYS", "I", AccessFlags = 25)]
				public const int RETURN_GENERATED_KEYS = 1;
				/// <java-name>
				/// SUCCESS_NO_INFO
				/// </java-name>
				[Dot42.DexImport("SUCCESS_NO_INFO", "I", AccessFlags = 25)]
				public const int SUCCESS_NO_INFO = -2;
		}

		/// <java-name>
		/// java/sql/Statement
		/// </java-name>
		[Dot42.DexImport("java/sql/Statement", AccessFlags = 1537)]
		public partial interface IStatement : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddBatch(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				void Cancel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearBatch
				/// </java-name>
				[Dot42.DexImport("clearBatch", "()V", AccessFlags = 1025)]
				void ClearBatch() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearWarnings
				/// </java-name>
				[Dot42.DexImport("clearWarnings", "()V", AccessFlags = 1025)]
				void ClearWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Execute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/String;I)Z", AccessFlags = 1025)]
				bool Execute(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/String;[I)Z", AccessFlags = 1025)]
				bool Execute(string @string, int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/String;[Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Execute(string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeBatch
				/// </java-name>
				[Dot42.DexImport("executeBatch", "()[I", AccessFlags = 1025)]
				int[] ExecuteBatch() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeQuery
				/// </java-name>
				[Dot42.DexImport("executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet ExecuteQuery(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int ExecuteUpdate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				int ExecuteUpdate(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "(Ljava/lang/String;[I)I", AccessFlags = 1025)]
				int ExecuteUpdate(string @string, int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1025)]
				int ExecuteUpdate(string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFetchDirection
				/// </java-name>
				[Dot42.DexImport("getFetchDirection", "()I", AccessFlags = 1025)]
				int GetFetchDirection() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFetchSize
				/// </java-name>
				[Dot42.DexImport("getFetchSize", "()I", AccessFlags = 1025)]
				int GetFetchSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGeneratedKeys
				/// </java-name>
				[Dot42.DexImport("getGeneratedKeys", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetGeneratedKeys() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxFieldSize
				/// </java-name>
				[Dot42.DexImport("getMaxFieldSize", "()I", AccessFlags = 1025)]
				int GetMaxFieldSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxRows
				/// </java-name>
				[Dot42.DexImport("getMaxRows", "()I", AccessFlags = 1025)]
				int GetMaxRows() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMoreResults
				/// </java-name>
				[Dot42.DexImport("getMoreResults", "()Z", AccessFlags = 1025)]
				bool GetMoreResults() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMoreResults
				/// </java-name>
				[Dot42.DexImport("getMoreResults", "(I)Z", AccessFlags = 1025)]
				bool GetMoreResults(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getQueryTimeout
				/// </java-name>
				[Dot42.DexImport("getQueryTimeout", "()I", AccessFlags = 1025)]
				int GetQueryTimeout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetResultSet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSetConcurrency
				/// </java-name>
				[Dot42.DexImport("getResultSetConcurrency", "()I", AccessFlags = 1025)]
				int GetResultSetConcurrency() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSetHoldability
				/// </java-name>
				[Dot42.DexImport("getResultSetHoldability", "()I", AccessFlags = 1025)]
				int GetResultSetHoldability() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResultSetType
				/// </java-name>
				[Dot42.DexImport("getResultSetType", "()I", AccessFlags = 1025)]
				int GetResultSetType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUpdateCount
				/// </java-name>
				[Dot42.DexImport("getUpdateCount", "()I", AccessFlags = 1025)]
				int GetUpdateCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWarnings
				/// </java-name>
				[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
				global::Java.Sql.SQLWarning GetWarnings() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCursorName
				/// </java-name>
				[Dot42.DexImport("setCursorName", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCursorName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEscapeProcessing
				/// </java-name>
				[Dot42.DexImport("setEscapeProcessing", "(Z)V", AccessFlags = 1025)]
				void SetEscapeProcessing(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFetchDirection
				/// </java-name>
				[Dot42.DexImport("setFetchDirection", "(I)V", AccessFlags = 1025)]
				void SetFetchDirection(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFetchSize
				/// </java-name>
				[Dot42.DexImport("setFetchSize", "(I)V", AccessFlags = 1025)]
				void SetFetchSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setMaxFieldSize
				/// </java-name>
				[Dot42.DexImport("setMaxFieldSize", "(I)V", AccessFlags = 1025)]
				void SetMaxFieldSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setMaxRows
				/// </java-name>
				[Dot42.DexImport("setMaxRows", "(I)V", AccessFlags = 1025)]
				void SetMaxRows(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setQueryTimeout
				/// </java-name>
				[Dot42.DexImport("setQueryTimeout", "(I)V", AccessFlags = 1025)]
				void SetQueryTimeout(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
				bool IsClosed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPoolable
				/// </java-name>
				[Dot42.DexImport("setPoolable", "(Z)V", AccessFlags = 1025)]
				void SetPoolable(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isPoolable
				/// </java-name>
				[Dot42.DexImport("isPoolable", "()Z", AccessFlags = 1025)]
				bool IsPoolable() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/RowId
		/// </java-name>
		[Dot42.DexImport("java/sql/RowId", AccessFlags = 1537)]
		public partial interface IRowId
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBytes() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLPermission
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLPermission", AccessFlags = 49)]
		public sealed partial class SQLPermission : global::Java.Security.BasicPermission, global::Java.Security.IGuard, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SQLPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/security/Guard", "checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public override void CheckGuard(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/sql/SQLTransientConnectionException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTransientConnectionException", AccessFlags = 33)]
		public partial class SQLTransientConnectionException : global::Java.Sql.SQLTransientException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLTransientConnectionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/DriverPropertyInfo
		/// </java-name>
		[Dot42.DexImport("java/sql/DriverPropertyInfo", AccessFlags = 33)]
		public partial class DriverPropertyInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// choices
				/// </java-name>
				[Dot42.DexImport("choices", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Choices;
				/// <java-name>
				/// description
				/// </java-name>
				[Dot42.DexImport("description", "Ljava/lang/String;", AccessFlags = 1)]
				public string Description;
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <java-name>
				/// required
				/// </java-name>
				[Dot42.DexImport("required", "Z", AccessFlags = 1)]
				public bool Required;
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "Ljava/lang/String;", AccessFlags = 1)]
				public string Value;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DriverPropertyInfo(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DriverPropertyInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLData
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLData", AccessFlags = 1537)]
		public partial interface ISQLData
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSQLTypeName
				/// </java-name>
				[Dot42.DexImport("getSQLTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSQLTypeName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readSQL
				/// </java-name>
				[Dot42.DexImport("readSQL", "(Ljava/sql/SQLInput;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ReadSQL(global::Java.Sql.ISQLInput sQLInput, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeSQL
				/// </java-name>
				[Dot42.DexImport("writeSQL", "(Ljava/sql/SQLOutput;)V", AccessFlags = 1025)]
				void WriteSQL(global::Java.Sql.ISQLOutput sQLOutput) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/DriverManager
		/// </java-name>
		[Dot42.DexImport("java/sql/DriverManager", AccessFlags = 33)]
		public partial class DriverManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DriverManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deregisterDriver
				/// </java-name>
				[Dot42.DexImport("deregisterDriver", "(Ljava/sql/Driver;)V", AccessFlags = 9)]
				public static void DeregisterDriver(global::Java.Sql.IDriver driver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string @string, global::Java.Util.Properties properties) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <java-name>
				/// getDriver
				/// </java-name>
				[Dot42.DexImport("getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;", AccessFlags = 9)]
				public static global::Java.Sql.IDriver GetDriver(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IDriver);
				}

				/// <java-name>
				/// getDrivers
				/// </java-name>
				[Dot42.DexImport("getDrivers", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/sql/Driver;>;")]
				public static global::Java.Util.IEnumeration<global::Java.Sql.IDriver> GetDrivers() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Sql.IDriver>);
				}

				/// <java-name>
				/// getLoginTimeout
				/// </java-name>
				[Dot42.DexImport("getLoginTimeout", "()I", AccessFlags = 9)]
				public static int GetLoginTimeout() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLogStream
				/// </java-name>
				[Dot42.DexImport("getLogStream", "()Ljava/io/PrintStream;", AccessFlags = 9)]
				public static global::Java.Io.PrintStream GetLogStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// getLogWriter
				/// </java-name>
				[Dot42.DexImport("getLogWriter", "()Ljava/io/PrintWriter;", AccessFlags = 9)]
				public static global::Java.Io.PrintWriter GetLogWriter() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDriver
				/// </java-name>
				[Dot42.DexImport("registerDriver", "(Ljava/sql/Driver;)V", AccessFlags = 9)]
				public static void RegisterDriver(global::Java.Sql.IDriver driver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLoginTimeout
				/// </java-name>
				[Dot42.DexImport("setLoginTimeout", "(I)V", AccessFlags = 9)]
				public static void SetLoginTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLogStream
				/// </java-name>
				[Dot42.DexImport("setLogStream", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void SetLogStream(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLogWriter
				/// </java-name>
				[Dot42.DexImport("setLogWriter", "(Ljava/io/PrintWriter;)V", AccessFlags = 9)]
				public static void SetLogWriter(global::Java.Io.PrintWriter printWriter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrivers
				/// </java-name>
				public static global::Java.Util.IEnumeration<global::Java.Sql.IDriver> Drivers
				{
				[Dot42.DexImport("getDrivers", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/sql/Driver;>;")]
						get{ return GetDrivers(); }
				}

				/// <java-name>
				/// getLoginTimeout
				/// </java-name>
				public static int LoginTimeout
				{
				[Dot42.DexImport("getLoginTimeout", "()I", AccessFlags = 9)]
						get{ return GetLoginTimeout(); }
				[Dot42.DexImport("setLoginTimeout", "(I)V", AccessFlags = 9)]
						set{ SetLoginTimeout(value); }
				}

				/// <java-name>
				/// getLogStream
				/// </java-name>
				public static global::Java.Io.PrintStream LogStream
				{
				[Dot42.DexImport("getLogStream", "()Ljava/io/PrintStream;", AccessFlags = 9)]
						get{ return GetLogStream(); }
				[Dot42.DexImport("setLogStream", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
						set{ SetLogStream(value); }
				}

				/// <java-name>
				/// getLogWriter
				/// </java-name>
				public static global::Java.Io.PrintWriter LogWriter
				{
				[Dot42.DexImport("getLogWriter", "()Ljava/io/PrintWriter;", AccessFlags = 9)]
						get{ return GetLogWriter(); }
				[Dot42.DexImport("setLogWriter", "(Ljava/io/PrintWriter;)V", AccessFlags = 9)]
						set{ SetLogWriter(value); }
				}

		}

		/// <java-name>
		/// java/sql/SQLXML
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLXML", AccessFlags = 1537)]
		public partial interface ISQLXML
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetBinaryStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.Io.OutputStream SetBinaryStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "()Ljava/io/Writer;", AccessFlags = 1025)]
				global::Java.Io.Writer SetCharacterStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetString(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSource
				/// </java-name>
				[Dot42.DexImport("getSource", "(Ljava/lang/Class;)Ljavax/xml/transform/Source;", AccessFlags = 1025, Signature = "<T::Ljavax/xml/transform/Source;>(Ljava/lang/Class<TT;>;)TT;")]
				T GetSource<T>(global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(Ljava/lang/Class;)Ljavax/xml/transform/Result;", AccessFlags = 1025, Signature = "<T::Ljavax/xml/transform/Result;>(Ljava/lang/Class<TT;>;)TT;")]
				T SetResult<T>(global::System.Type type) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/Date
		/// </java-name>
		[Dot42.DexImport("java/sql/Date", AccessFlags = 33)]
		public partial class Date : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Date(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Date(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHours
				/// </java-name>
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
				public override int GetHours() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinutes
				/// </java-name>
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
				public override int GetMinutes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSeconds
				/// </java-name>
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
				public override int GetSeconds() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setHours
				/// </java-name>
				[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
				public override void SetHours(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinutes
				/// </java-name>
				[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
				public override void SetMinutes(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSeconds
				/// </java-name>
				[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
				public override void SetSeconds(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public override void SetTime(long int64) /* MethodBuilder.Create */ 
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
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Date;", AccessFlags = 9)]
				public static global::Java.Sql.Date ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Date);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Date() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHours
				/// </java-name>
				public int Hours
				{
				[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return GetHours(); }
				[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
						set{ SetHours(value); }
				}

				/// <java-name>
				/// getMinutes
				/// </java-name>
				public int Minutes
				{
				[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return GetMinutes(); }
				[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
						set{ SetMinutes(value); }
				}

				/// <java-name>
				/// getSeconds
				/// </java-name>
				public int Seconds
				{
				[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return GetSeconds(); }
				[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
						set{ SetSeconds(value); }
				}

		}

		/// <java-name>
		/// java/sql/Savepoint
		/// </java-name>
		[Dot42.DexImport("java/sql/Savepoint", AccessFlags = 1537)]
		public partial interface ISavepoint
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSavepointId
				/// </java-name>
				[Dot42.DexImport("getSavepointId", "()I", AccessFlags = 1025)]
				int GetSavepointId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSavepointName
				/// </java-name>
				[Dot42.DexImport("getSavepointName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSavepointName() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/sql/SQLWarning
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLWarning", AccessFlags = 33)]
		public partial class SQLWarning : global::Java.Sql.SQLException, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLWarning() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLWarning(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLWarning(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public SQLWarning(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLWarning(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLWarning(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLWarning(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLWarning(string @string, string string1, int int32, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNextWarning
				/// </java-name>
				[Dot42.DexImport("getNextWarning", "()Ljava/sql/SQLWarning;", AccessFlags = 1)]
				public virtual global::Java.Sql.SQLWarning GetNextWarning() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.SQLWarning);
				}

				/// <java-name>
				/// setNextWarning
				/// </java-name>
				[Dot42.DexImport("setNextWarning", "(Ljava/sql/SQLWarning;)V", AccessFlags = 1)]
				public virtual void SetNextWarning(global::Java.Sql.SQLWarning sQLWarning) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNextWarning
				/// </java-name>
				public global::Java.Sql.SQLWarning NextWarning
				{
				[Dot42.DexImport("getNextWarning", "()Ljava/sql/SQLWarning;", AccessFlags = 1)]
						get{ return GetNextWarning(); }
				[Dot42.DexImport("setNextWarning", "(Ljava/sql/SQLWarning;)V", AccessFlags = 1)]
						set{ SetNextWarning(value); }
				}

		}

}

