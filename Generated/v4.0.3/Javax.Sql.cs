#pragma warning disable 1717
namespace Javax.Sql
{
		/// <java-name>
		/// javax/sql/ConnectionEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionEvent", AccessFlags = 33)]
		public partial class ConnectionEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;)V", AccessFlags = 1)]
				public ConnectionEvent(global::Javax.Sql.IPooledConnection pooledConnection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/SQLException;)V", AccessFlags = 1)]
				public ConnectionEvent(global::Javax.Sql.IPooledConnection pooledConnection, global::Java.Sql.SQLException sQLException) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnectionEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSQLException
				/// </java-name>
				public virtual global::Java.Sql.SQLException SQLException
				{
						[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return default(global::Java.Sql.SQLException); }
				}

		}

		/// <java-name>
		/// javax/sql/CommonDataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/CommonDataSource", AccessFlags = 1537)]
		public partial interface ICommonDataSource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLoginTimeout
				/// </java-name>
				int LoginTimeout
				{
						[Dot42.DexImport("getLoginTimeout", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setLoginTimeout", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getLogWriter
				/// </java-name>
				global::Java.Io.PrintWriter LogWriter
				{
						[Dot42.DexImport("getLogWriter", "()Ljava/io/PrintWriter;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setLogWriter", "(Ljava/io/PrintWriter;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/sql/ConnectionEventListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionEventListener", AccessFlags = 1537)]
		public partial interface IConnectionEventListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// connectionClosed
				/// </java-name>
				[Dot42.DexImport("connectionClosed", "(Ljavax/sql/ConnectionEvent;)V", AccessFlags = 1025)]
				void ConnectionClosed(global::Javax.Sql.ConnectionEvent connectionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// connectionErrorOccurred
				/// </java-name>
				[Dot42.DexImport("connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V", AccessFlags = 1025)]
				void ConnectionErrorOccurred(global::Javax.Sql.ConnectionEvent connectionEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/ConnectionPoolDataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionPoolDataSource", AccessFlags = 1537)]
		public partial interface IConnectionPoolDataSource : global::Javax.Sql.ICommonDataSource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPooledConnection
				/// </java-name>
				[Dot42.DexImport("getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;", AccessFlags = 1025)]
				global::Javax.Sql.IPooledConnection GetPooledConnection(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPooledConnection
				/// </java-name>
				global::Javax.Sql.IPooledConnection PooledConnection
				{
						[Dot42.DexImport("getPooledConnection", "()Ljavax/sql/PooledConnection;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/sql/DataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/DataSource", AccessFlags = 1537)]
		public partial interface IDataSource : global::Javax.Sql.ICommonDataSource, global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnection
				/// </java-name>
				global::Java.Sql.IConnection Connection
				{
						[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/sql/PooledConnection
		/// </java-name>
		[Dot42.DexImport("javax/sql/PooledConnection", AccessFlags = 1537)]
		public partial interface IPooledConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addConnectionEventListener
				/// </java-name>
				[Dot42.DexImport("addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", AccessFlags = 1025)]
				void AddConnectionEventListener(global::Javax.Sql.IConnectionEventListener connectionEventListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeConnectionEventListener
				/// </java-name>
				[Dot42.DexImport("removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", AccessFlags = 1025)]
				void RemoveConnectionEventListener(global::Javax.Sql.IConnectionEventListener connectionEventListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addStatementEventListener
				/// </java-name>
				[Dot42.DexImport("addStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", AccessFlags = 1025)]
				void AddStatementEventListener(global::Javax.Sql.IStatementEventListener statementEventListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeStatementEventListener
				/// </java-name>
				[Dot42.DexImport("removeStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", AccessFlags = 1025)]
				void RemoveStatementEventListener(global::Javax.Sql.IStatementEventListener statementEventListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnection
				/// </java-name>
				global::Java.Sql.IConnection Connection
				{
						[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/sql/RowSet
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSet", AccessFlags = 1537)]
		public partial interface IRowSet : global::Java.Sql.IResultSet
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addRowSetListener
				/// </java-name>
				[Dot42.DexImport("addRowSetListener", "(Ljavax/sql/RowSetListener;)V", AccessFlags = 1025)]
				void AddRowSetListener(global::Javax.Sql.IRowSetListener rowSetListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				void ClearParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1025)]
				void Execute() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeRowSetListener
				/// </java-name>
				[Dot42.DexImport("removeRowSetListener", "(Ljavax/sql/RowSetListener;)V", AccessFlags = 1025)]
				void RemoveRowSetListener(global::Javax.Sql.IRowSetListener rowSetListener) /* MethodBuilder.Create */ ;

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
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(ILjava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(int int32, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(string @string, global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(int int32, global::Java.Io.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Sql.IBlob blob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(IZ)V", AccessFlags = 1025)]
				void SetBoolean(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(IB)V", AccessFlags = 1025)]
				void SetByte(int int32, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
				void SetByte(string @string, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(I[B)V", AccessFlags = 1025)]
				void SetBytes(int int32, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				void SetBytes(string @string, sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(int int32, global::Java.Io.Reader reader, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Sql.IClob clob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setConcurrency
				/// </java-name>
				[Dot42.DexImport("setConcurrency", "(I)V", AccessFlags = 1025)]
				void SetConcurrency(int int32) /* MethodBuilder.Create */ ;

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
				[Dot42.DexImport("setDouble", "(ID)V", AccessFlags = 1025)]
				void SetDouble(int int32, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				void SetDouble(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(IF)V", AccessFlags = 1025)]
				void SetFloat(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				void SetFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(II)V", AccessFlags = 1025)]
				void SetInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(IJ)V", AccessFlags = 1025)]
				void SetLong(int int32, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void SetLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(string @string, string string1) /* MethodBuilder.Create */ ;

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
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/String;S)V", AccessFlags = 1025)]
				void SetShort(string @string, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetString(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(ILjava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(int int32, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(string @string, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(ILjava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(int int32, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(string @string, global::Java.Sql.ISQLXML sQLXML) /* MethodBuilder.Create */ ;

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
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(int int32, global::Java.Sql.Timestamp timestamp) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(int int32, global::Java.Sql.Timestamp timestamp, global::Java.Util.Calendar calendar) /* MethodBuilder.Create */ ;

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
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1025)]
				void SetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(ILjava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(int int32, global::Java.Net.URL uRL) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCommand
				/// </java-name>
				string Command
				{
						[Dot42.DexImport("getCommand", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCommand", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getDataSourceName
				/// </java-name>
				string DataSourceName
				{
						[Dot42.DexImport("getDataSourceName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setDataSourceName", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getEscapeProcessing
				/// </java-name>
				bool IsEscapeProcessing
				{
						[Dot42.DexImport("getEscapeProcessing", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEscapeProcessing", "(Z)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMaxFieldSize
				/// </java-name>
				int MaxFieldSize
				{
						[Dot42.DexImport("getMaxFieldSize", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setMaxFieldSize", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMaxRows
				/// </java-name>
				int MaxRows
				{
						[Dot42.DexImport("getMaxRows", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setMaxRows", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				string Password
				{
						[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setPassword", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getQueryTimeout
				/// </java-name>
				int QueryTimeout
				{
						[Dot42.DexImport("getQueryTimeout", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setQueryTimeout", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getTransactionIsolation
				/// </java-name>
				int TransactionIsolation
				{
						[Dot42.DexImport("getTransactionIsolation", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setTransactionIsolation", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getTypeMap
				/// </java-name>
				global::Java.Util.IMap<string, global::System.Type> TypeMap
				{
						[Dot42.DexImport("getTypeMap", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;")]
						get;
						[Dot42.DexImport("setTypeMap", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)V")]
						set;
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				string Url
				{
						[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getUsername
				/// </java-name>
				string Username
				{
						[Dot42.DexImport("getUsername", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setUsername", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				bool IsReadOnly
				{
						[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setReadOnly", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/sql/RowSetInternal
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetInternal", AccessFlags = 1537)]
		public partial interface IRowSetInternal
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setMetaData
				/// </java-name>
				[Dot42.DexImport("setMetaData", "(Ljavax/sql/RowSetMetaData;)V", AccessFlags = 1025)]
				void SetMetaData(global::Javax.Sql.IRowSetMetaData rowSetMetaData) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnection
				/// </java-name>
				global::Java.Sql.IConnection Connection
				{
						[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOriginal
				/// </java-name>
				global::Java.Sql.IResultSet Original
				{
						[Dot42.DexImport("getOriginal", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOriginalRow
				/// </java-name>
				global::Java.Sql.IResultSet OriginalRow
				{
						[Dot42.DexImport("getOriginalRow", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				object[] Params
				{
						[Dot42.DexImport("getParams", "()[Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/sql/RowSetListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetListener", AccessFlags = 1537)]
		public partial interface IRowSetListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// cursorMoved
				/// </java-name>
				[Dot42.DexImport("cursorMoved", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void CursorMoved(global::Javax.Sql.RowSetEvent rowSetEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rowChanged
				/// </java-name>
				[Dot42.DexImport("rowChanged", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void RowChanged(global::Javax.Sql.RowSetEvent rowSetEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// rowSetChanged
				/// </java-name>
				[Dot42.DexImport("rowSetChanged", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void RowSetChanged(global::Javax.Sql.RowSetEvent rowSetEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/RowSetMetaData
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetMetaData", AccessFlags = 1537)]
		public partial interface IRowSetMetaData : global::Java.Sql.IResultSetMetaData
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setAutoIncrement
				/// </java-name>
				[Dot42.DexImport("setAutoIncrement", "(IZ)V", AccessFlags = 1025)]
				void SetAutoIncrement(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCaseSensitive
				/// </java-name>
				[Dot42.DexImport("setCaseSensitive", "(IZ)V", AccessFlags = 1025)]
				void SetCaseSensitive(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCatalogName
				/// </java-name>
				[Dot42.DexImport("setCatalogName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetCatalogName(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnCount
				/// </java-name>
				[Dot42.DexImport("setColumnCount", "(I)V", AccessFlags = 1025)]
				void SetColumnCount(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnDisplaySize
				/// </java-name>
				[Dot42.DexImport("setColumnDisplaySize", "(II)V", AccessFlags = 1025)]
				void SetColumnDisplaySize(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnLabel
				/// </java-name>
				[Dot42.DexImport("setColumnLabel", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnLabel(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnName
				/// </java-name>
				[Dot42.DexImport("setColumnName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnName(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnType
				/// </java-name>
				[Dot42.DexImport("setColumnType", "(II)V", AccessFlags = 1025)]
				void SetColumnType(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColumnTypeName
				/// </java-name>
				[Dot42.DexImport("setColumnTypeName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnTypeName(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCurrency
				/// </java-name>
				[Dot42.DexImport("setCurrency", "(IZ)V", AccessFlags = 1025)]
				void SetCurrency(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNullable
				/// </java-name>
				[Dot42.DexImport("setNullable", "(II)V", AccessFlags = 1025)]
				void SetNullable(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPrecision
				/// </java-name>
				[Dot42.DexImport("setPrecision", "(II)V", AccessFlags = 1025)]
				void SetPrecision(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(II)V", AccessFlags = 1025)]
				void SetScale(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSchemaName
				/// </java-name>
				[Dot42.DexImport("setSchemaName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetSchemaName(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSearchable
				/// </java-name>
				[Dot42.DexImport("setSearchable", "(IZ)V", AccessFlags = 1025)]
				void SetSearchable(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSigned
				/// </java-name>
				[Dot42.DexImport("setSigned", "(IZ)V", AccessFlags = 1025)]
				void SetSigned(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTableName
				/// </java-name>
				[Dot42.DexImport("setTableName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetTableName(int int32, string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/RowSetReader
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetReader", AccessFlags = 1537)]
		public partial interface IRowSetReader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// readData
				/// </java-name>
				[Dot42.DexImport("readData", "(Ljavax/sql/RowSetInternal;)V", AccessFlags = 1025)]
				void ReadData(global::Javax.Sql.IRowSetInternal rowSetInternal) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/RowSetWriter
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetWriter", AccessFlags = 1537)]
		public partial interface IRowSetWriter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// writeData
				/// </java-name>
				[Dot42.DexImport("writeData", "(Ljavax/sql/RowSetInternal;)Z", AccessFlags = 1025)]
				bool WriteData(global::Javax.Sql.IRowSetInternal rowSetInternal) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/StatementEventListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/StatementEventListener", AccessFlags = 1537)]
		public partial interface IStatementEventListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// statementClosed
				/// </java-name>
				[Dot42.DexImport("statementClosed", "(Ljavax/sql/StatementEvent;)V", AccessFlags = 1025)]
				void StatementClosed(global::Javax.Sql.StatementEvent statementEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// statementErrorOccurred
				/// </java-name>
				[Dot42.DexImport("statementErrorOccurred", "(Ljavax/sql/StatementEvent;)V", AccessFlags = 1025)]
				void StatementErrorOccurred(global::Javax.Sql.StatementEvent statementEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/sql/RowSetEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetEvent", AccessFlags = 33)]
		public partial class RowSetEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/sql/RowSet;)V", AccessFlags = 1)]
				public RowSetEvent(global::Javax.Sql.IRowSet rowSet) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RowSetEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/sql/StatementEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/StatementEvent", AccessFlags = 33)]
		public partial class StatementEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/PreparedStatement;Ljava/sql/SQLException;)" +
    "V", AccessFlags = 1)]
				public StatementEvent(global::Javax.Sql.IPooledConnection pooledConnection, global::Java.Sql.IPreparedStatement preparedStatement, global::Java.Sql.SQLException sQLException) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/PreparedStatement;)V", AccessFlags = 1)]
				public StatementEvent(global::Javax.Sql.IPooledConnection pooledConnection, global::Java.Sql.IPreparedStatement preparedStatement) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StatementEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStatement
				/// </java-name>
				public virtual global::Java.Sql.IPreparedStatement Statement
				{
						[Dot42.DexImport("getStatement", "()Ljava/sql/PreparedStatement;", AccessFlags = 1)]
						get{ return default(global::Java.Sql.IPreparedStatement); }
				}

				/// <java-name>
				/// getSQLException
				/// </java-name>
				public virtual global::Java.Sql.SQLException SQLException
				{
						[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return default(global::Java.Sql.SQLException); }
				}

		}

}

