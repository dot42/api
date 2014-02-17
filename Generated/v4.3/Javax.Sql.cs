// Copyright (C) 2014 dot42
//
// Original filename: Javax.Sql.cs
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
namespace Javax.Sql
{
		/// <summary>
		/// <para>An event which is sent when specific events happen to a RowSet object. The events are sent to inform registered listeners that changes have occurred to the <c> RowSet </c> . The events covered are: <ol><li><para>A single row in the <c> RowSet </c> changes. </para></li><li><para>The whole set of data in the <c> RowSet </c> changes. </para></li><li><para>The <c> RowSet </c> cursor position changes. </para></li></ol></para><para>The event contains a reference to the <c> RowSet </c> object which generated the message so that the listeners can extract whatever information they need from that reference. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetEvent", AccessFlags = 33)]
		public partial class RowSetEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> RowSetEvent </c> object containing a reference to the RowSet object that generated the event. Information about the changes that have occurred to the <c> RowSet </c> can be extracted from the <c> RowSet </c> using one or more of the query methods available on the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/sql/RowSet;)V", AccessFlags = 1)]
				public RowSetEvent(global::Javax.Sql.IRowSet theSource) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RowSetEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An interface provided by a <c> RowSet </c> object to let either a <c>   RowSetReader </c> or a <c> RowSetWriter </c> access its internal state, thereby providing facilities to read and update the state of the <c> RowSet </c> . </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetInternal
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetInternal", AccessFlags = 1537)]
		public partial interface IRowSetInternal
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Gets the connection associated with this <c> RowSet </c> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the connection or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> ResultSet </c> that was the original (unmodified) content of the <c> RowSet </c> . </para><para>The <c> ResultSet </c> 's cursor is positioned before the first row of data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> ResultSet </c> that contained the original data value of the <c> RowSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetOriginal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the original value of the current row only. If the current row did not have an original value, then an empty value is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> ResultSet </c> containing the value of the current row only. </para>
				/// </returns>
				/// <java-name>
				/// getOriginalRow
				/// </java-name>
				[Dot42.DexImport("getOriginalRow", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetOriginalRow() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the parameter values that have been set for this <c> RowSet </c> 's command.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the values of parameters that have been set. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()[Ljava/lang/Object;", AccessFlags = 1025)]
				object[] GetParams() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets <c> RowSetMetaData </c> for this <c> RowSet </c> . The <c>       RowSetMetaData </c> is used by a <c> RowSetReader </c> to set values giving information about the <c> RowSet </c> 's columns.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMetaData
				/// </java-name>
				[Dot42.DexImport("setMetaData", "(Ljavax/sql/RowSetMetaData;)V", AccessFlags = 1025)]
				void SetMetaData(global::Javax.Sql.IRowSetMetaData theMetaData) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An object that registers to be notified of events that occur on PreparedStatements that are in the Statement pool. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/StatementEventListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/StatementEventListener", AccessFlags = 1537)]
		public partial interface IStatementEventListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The driver calls this method on all StatementEventListeners registered on the connection when it detects that a PreparedStatement is closed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// statementClosed
				/// </java-name>
				[Dot42.DexImport("statementClosed", "(Ljavax/sql/StatementEvent;)V", AccessFlags = 1025)]
				void StatementClosed(global::Javax.Sql.StatementEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The driver calls this method on all StatementEventListeners registered on the connection when it detects that a PreparedStatement is invalid, before a SQLException is thrown</para><para></para>        
				/// </summary>
				/// <java-name>
				/// statementErrorOccurred
				/// </java-name>
				[Dot42.DexImport("statementErrorOccurred", "(Ljavax/sql/StatementEvent;)V", AccessFlags = 1025)]
				void StatementErrorOccurred(global::Javax.Sql.StatementEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface which provides means to access data which persists on a database. It extends the functionality of ResultSet into a form that it can be used as a JavaBean component, suited for a visual programming environment. </para><para><c> RowSet </c> provides getters and setters for properties relating to the general database environment together with the getters and setters for distinct data values which constitute the row set. The <c> RowSet </c> class supports JavaBean events so that other components in an application can be informed when changes happen such as changes in data values. </para><para><c> RowSet </c> is a facility implemented on top of the remainder of the JDBC API. It may be <b>connected</b>, maintaining a connection to the database throughout its lifecycle. The changes made on a <b>disconnected</b> <c>   RowSet </c> on the other hand can be persisted only establishing a new connection with the database each time. </para><para>Disconnected <c> RowSets </c> make use of <c> RowSetReaders </c> to populate the <c> RowSet </c> with data, possibly from a non-relational database source. They may also use <c> RowSetWriters </c> to send data back to the underlying data store. There is considerable freedom in the way that <c>   RowSetReaders </c> and <c> RowSetWriters </c> may be implemented to retrieve and store data.</para><para><para>RowSetReader </para><simplesectsep></simplesectsep><para>RowSetWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSet
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSet", AccessFlags = 1537)]
		public partial interface IRowSet : global::Java.Sql.IResultSet
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Registers the supplied RowSetListener with this <c> RowSet </c> . Once registered, the RowSetListener is notified of events generated by the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addRowSetListener
				/// </java-name>
				[Dot42.DexImport("addRowSetListener", "(Ljavax/sql/RowSetListener;)V", AccessFlags = 1025)]
				void AddRowSetListener(global::Javax.Sql.IRowSetListener theListener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clears the parameters previously set for this <c> RowSet </c> . </para><para>The <c> RowSet </c> object retains its value until either a new value for a parameter is set or its value is actively reset. <c>       clearParameters </c> provides a facility to clear the values for all parameters with one method call.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				void ClearParameters() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Fetches data for this <c> RowSet </c> from the database. If successful, any existing data for the <c> RowSet </c> is discarded and its metadata is overwritten. </para><para>Data is retrieved connecting to the database and executing an according SQL statement. This requires some or all of the following properties to be set: URL, database name, user name, password, transaction isolation, type map; plus some or all of the properties: command, read only, maximum field size, maximum rows, escape processing, and query timeout. </para><para>The <c> RowSet </c> may use a <c> RowSetReader </c> to access the database it will then invoke the RowSetReader#readData method on the reader to fetch the data. When the new data is fetched all the listeners are notified to take appropriate measures.</para><para><para>RowSetMetaData </para><simplesectsep></simplesectsep><para>RowSetReader </para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1025)]
				void Execute() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the <c> RowSet </c> 's command property.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string containing the <c> RowSet </c> 's command property. A command is a SQL statement which is executed to fetch required data into the <c> RowSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCommand
				/// </java-name>
				[Dot42.DexImport("getCommand", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCommand() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the ODBC Data Source Name property associated with this <c>       RowSet </c> . The database name can be used to find a DataSource which has been registered with a naming service - the DataSource can then be used to create a connection to the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the database. </para>
				/// </returns>
				/// <java-name>
				/// getDataSourceName
				/// </java-name>
				[Dot42.DexImport("getDataSourceName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDataSourceName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reports if escape processing is enabled for this <c> RowSet </c> . If escape processing is on, the driver performs a substitution of the escape syntax with the applicable code before sending an SQL command to the database. The default value for escape processing is <c> true </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if escape processing is enabled, <c>               false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getEscapeProcessing
				/// </java-name>
				[Dot42.DexImport("getEscapeProcessing", "()Z", AccessFlags = 1025)]
				bool GetEscapeProcessing() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the maximum number of bytes that can be returned for column values which are of type <c> BINARY </c> , <c> VARBINARY </c> , <c>       LONGVARBINARYBINARY </c> , <c> CHAR </c> , <c> VARCHAR </c> , or <c>       LONGVARCHAR </c> . Excess data is silently discarded if the number is exceeded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current maximum size in bytes. 0 implies no size limit. </para>
				/// </returns>
				/// <java-name>
				/// getMaxFieldSize
				/// </java-name>
				[Dot42.DexImport("getMaxFieldSize", "()I", AccessFlags = 1025)]
				int GetMaxFieldSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the maximum number of rows for this <c> RowSet </c> . Excess rows are discarded silently if the limit is exceeded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the previous maximum number of rows. 0 implies no row limit. </para>
				/// </returns>
				/// <java-name>
				/// getMaxRows
				/// </java-name>
				[Dot42.DexImport("getMaxRows", "()I", AccessFlags = 1025)]
				int GetMaxRows() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the value of the password property for this <c> RowSet </c> . This property is used when a connection to the database is established. Therefore it should be set prior to invoking the execute method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the password property. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPassword() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the timeout for the driver when a query operation is executed. If a query takes longer than the timeout then a <c> SQLException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the timeout value in seconds. </para>
				/// </returns>
				/// <java-name>
				/// getQueryTimeout
				/// </java-name>
				[Dot42.DexImport("getQueryTimeout", "()I", AccessFlags = 1025)]
				int GetQueryTimeout() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the transaction isolation level property set for this <c> RowSet </c> . The transaction isolation level defines the policy implemented on the database for maintaining the data values consistent.</para><para><para>java.sql.Connection </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current transaction isolation level. Must be one of: <ul><li><para><c> Connection.TRANSACTION_READ_UNCOMMITTED </c>  </para></li><li><para><c> Connection.TRANSACTION_READ_COMMITTED </c>  </para></li><li><para><c> Connection.TRANSACTION_REPEATABLE_READ </c>  </para></li><li><para><c> Connection.TRANSACTION_SERIALIZABLE </c>  </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getTransactionIsolation
				/// </java-name>
				[Dot42.DexImport("getTransactionIsolation", "()I", AccessFlags = 1025)]
				int GetTransactionIsolation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the custom mapping of SQL User-Defined Types (UDTs) and Java classes for this <c> RowSet </c> , if applicable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the custom mappings of SQL types to Java classes. </para>
				/// </returns>
				/// <java-name>
				/// getTypeMap
				/// </java-name>
				[Dot42.DexImport("getTypeMap", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;")]
				global::Java.Util.IMap<string, global::System.Type> GetTypeMap() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the URL property value for this <c> RowSet </c> . If there is no <c> DataSource </c> object specified, the <c> RowSet </c> uses the URL to establish a connection to the database. The default value for the URL is <c> null </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a String holding the value of the URL property. </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetUrl() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the value of the <c> username </c> property for this <c> RowSet </c> . The <c> username </c> is used when establishing a connection to the database and should be set before the <c> execute </c> method is invoked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> String </c> holding the value of the <c> username </c> property. </para>
				/// </returns>
				/// <java-name>
				/// getUsername
				/// </java-name>
				[Dot42.DexImport("getUsername", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetUsername() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates if this <c> RowSet </c> is read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> RowSet </c> is read-only, <c> false </c> if it is updatable. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
				bool IsReadOnly() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes a specified RowSetListener object from the set of listeners which will be notified of events by this <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeRowSetListener
				/// </java-name>
				[Dot42.DexImport("removeRowSetListener", "(Ljavax/sql/RowSetListener;)V", AccessFlags = 1025)]
				void RemoveRowSetListener(global::Javax.Sql.IRowSetListener theListener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the specified <c> ARRAY </c> parameter in the <c> RowSet </c> command with the supplied <c> java.sql.Array </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setArray
				/// </java-name>
				[Dot42.DexImport("setArray", "(ILjava/sql/Array;)V", AccessFlags = 1025)]
				void SetArray(int parameterIndex, global::Java.Sql.IArray theArray) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the ASCII data in the supplied <c> java.io.InputStream </c> value. Data is read from the <c> InputStream </c> until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the ASCII data in the supplied java.io.InputStream value. Data is read from the InputStream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream theInputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the ASCII data in the supplied java.io.InputStream value. Data is read from the InputStream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(string parameterIndex, global::Java.Io.InputStream theInputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the ASCII data in the supplied <c> java.io.InputStream </c> value. Data is read from the <c> InputStream </c> until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(string parameterIndex, global::Java.Io.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified SQL <c> NUMERIC </c> parameter in the <c> RowSet </c> command with the data in the supplied <c>       java.math.BigDecimal </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(ILjava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal theBigDecimal) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified SQL <c> NUMERIC </c> parameter in the <c> RowSet </c> command with the data in the supplied <c>       java.math.BigDecimal </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(string parameterIndex, global::Java.Math.BigDecimal theBigDecimal) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the binary data in the supplied input stream. Data is read from the input stream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the binary data in the supplied java.io.InputStream value. Data is read from the InputStream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream theInputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the binary data in the supplied java.io.InputStream value. Data is read from the InputStream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(string parameterIndex, global::Java.Io.InputStream theInputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the binary data in the supplied input stream. Data is read from the input stream until end-of-file is reached.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(string parameterIndex, global::Java.Io.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the supplied <c> Blob </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(int parameterIndex, global::Java.Sql.IBlob theBlob) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the supplied <c> Blob </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(int parameterIndex, global::Java.Io.InputStream theBlob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(int int32, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the supplied <c> Blob </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(string parameterIndex, global::Java.Io.InputStream theBlob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.Io.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the supplied <c> Blob </c> value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(string parameterIndex, global::Java.Sql.IBlob theBlob) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the sequence of Unicode characters carried by the supplied <c>       java.io.Reader </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(int parameterIndex, global::Java.Io.Reader theReader, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the sequence of Unicode characters carried by the supplied java.io.Reader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(int parameterIndex, global::Java.Io.Reader theReader) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the sequence of Unicode characters carried by the supplied java.io.Reader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(string parameterIndex, global::Java.Io.Reader theReader) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to the sequence of Unicode characters carried by the supplied <c>       java.io.Reader </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(string parameterIndex, global::Java.Io.Reader theReader, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Clob </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(int parameterIndex, global::Java.Sql.IClob theClob) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Clob </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(int parameterIndex, global::Java.Io.Reader theClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Clob </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(string parameterIndex, global::Java.Sql.IClob theClob) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Clob </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(string parameterIndex, global::Java.Io.Reader theClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the Command property for this <c> RowSet </c> - the command is an SQL query which runs when the <c> execute </c> method is invoked. This property is optional for databases that do not support commands.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCommand
				/// </java-name>
				[Dot42.DexImport("setCommand", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCommand(string cmd) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the concurrency property of this <c> RowSet </c> . The default value is <c> ResultSet.CONCUR_READ_ONLY </c> .</para><para><para>java.sql.ResultSet </para></para>        
				/// </summary>
				/// <java-name>
				/// setConcurrency
				/// </java-name>
				[Dot42.DexImport("setConcurrency", "(I)V", AccessFlags = 1025)]
				void SetConcurrency(int concurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the database name property for the <c> RowSet </c> . </para><para>The database name can be used to find a DataSource which has been registered with a naming service - the DataSource can then be used to create a connection to the database.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSourceName
				/// </java-name>
				[Dot42.DexImport("setDataSourceName", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetDataSourceName(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Date </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(int parameterIndex, global::Java.Sql.Date theDate) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Date </c> , where the conversion of the date to an SQL <c> DATE </c> value is calculated using a supplied <c> Calendar </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(int parameterIndex, global::Java.Sql.Date theDate, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Date </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(string parameterIndex, global::Java.Sql.Date theDate) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the value of a supplied <c> java.sql.Date </c> , where the conversion of the date to an SQL <c> DATE </c> value is calculated using a supplied <c> Calendar </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(string parameterIndex, global::Java.Sql.Date theDate, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the escape processing status for this <c> RowSet </c> . If escape processing is on, the driver performs a substitution of the escape syntax with the applicable code before sending an SQL command to the database. The default value for escape processing is <c> true </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEscapeProcessing
				/// </java-name>
				[Dot42.DexImport("setEscapeProcessing", "(Z)V", AccessFlags = 1025)]
				void SetEscapeProcessing(bool enable) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the supplied <c> integer </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(II)V", AccessFlags = 1025)]
				void SetInt(int parameterIndex, int theInteger) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command with the supplied <c> integer </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetInt(string parameterIndex, int theInteger) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the maximum number of bytes which can be returned for a column value where the column type is one of <c> BINARY </c> , <c> VARBINARY </c> , <c> LONGVARBINARYBINARY </c> , <c> CHAR </c> , <c> VARCHAR </c> , or <c>       LONGVARCHAR </c> . Data which exceeds this limit is silently discarded. For portability, a value greater than 256 is recommended.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxFieldSize
				/// </java-name>
				[Dot42.DexImport("setMaxFieldSize", "(I)V", AccessFlags = 1025)]
				void SetMaxFieldSize(int max) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the maximum number of rows which can be held by the <c> RowSet </c> . Any additional rows are silently discarded.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxRows
				/// </java-name>
				[Dot42.DexImport("setMaxRows", "(I)V", AccessFlags = 1025)]
				void SetMaxRows(int max) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.io.Reader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader theReader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.io.Reader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(string parameterIndex, global::Java.Io.Reader theReader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(string @string, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.sql.NClob.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(int parameterIndex, global::Java.Sql.INClob theNClob) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.sql.NClob.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(int parameterIndex, global::Java.Io.Reader theNClob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(int int32, global::Java.Io.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.sql.NClob.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(string parameterIndex, global::Java.Sql.INClob theNClob) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command with the value of a supplied java.sql.NClob.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(string parameterIndex, global::Java.Io.Reader theNClob) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to SQL <c> NULL </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(II)V", AccessFlags = 1025)]
				void SetNull(int parameterIndex, int sqlType) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNull(int int32, int int321, string @string) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to SQL <c> NULL </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetNull(string parameterIndex, int sqlType) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the database Password for this <c> RowSet </c> . This property is used when a connection to the database is established. Therefore it should be set prior to invoking the execute method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPassword(string password) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the timeout for the driver when a query operation is executed. If a query takes longer than the timeout, a <c> SQLException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setQueryTimeout
				/// </java-name>
				[Dot42.DexImport("setQueryTimeout", "(I)V", AccessFlags = 1025)]
				void SetQueryTimeout(int seconds) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether the <c> RowSet </c> is read-only or updatable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "(Z)V", AccessFlags = 1025)]
				void SetReadOnly(bool readOnly) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Ref </c> . This is sent to the database as an SQL <c> REF </c> value.</para><para><para>java.sql.Ref </para></para>        
				/// </summary>
				/// <java-name>
				/// setRef
				/// </java-name>
				[Dot42.DexImport("setRef", "(ILjava/sql/Ref;)V", AccessFlags = 1025)]
				void SetRef(int parameterIndex, global::Java.Sql.IRef theRef) /* MethodBuilder.Create */ ;

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

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the supplied RowId</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(ILjava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(int parameterIndex, global::Java.Sql.IRowId theRowId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the supplied RowId</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(string parameterIndex, global::Java.Sql.IRowId theRowId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the supplied SQLXML</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(ILjava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(int parameterIndex, global::Java.Sql.ISQLXML theSQLXML) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the RowSet command to the supplied SQLXML</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(string parameterIndex, global::Java.Sql.ISQLXML theSQLXML) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Time </c> , converting it to an SQL <c> TIME </c> value using the system default <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(int parameterIndex, global::Java.Sql.Time theTime) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Time </c> , converting it to an SQL <c> TIME </c> value using a supplied <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(int parameterIndex, global::Java.Sql.Time theTime, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Time </c> , converting it to an SQL <c> TIME </c> value using the system default <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(string parameterIndex, global::Java.Sql.Time theTime) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Time </c> , converting it to an SQL <c> TIME </c> value using a supplied <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(string parameterIndex, global::Java.Sql.Time theTime, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Timestamp </c> , converting it to an SQL <c>       TIMESTAMP </c> value using the system default <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Timestamp </c> , converting it to an SQL <c>       TIMESTAMP </c> value using a supplied <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp theTimestamp, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Timestamp </c> , converting it to an SQL <c>       TIMESTAMP </c> value using the system default <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(string parameterIndex, global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value of the specified parameter in the <c> RowSet </c> command to a supplied <c> java.sql.Timestamp </c> , converting it to an SQL <c>       TIMESTAMP </c> value using a supplied <c> Calendar </c> .</para><para><para>java.util.Calendar </para><simplesectsep></simplesectsep><para>java.sql.Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(string parameterIndex, global::Java.Sql.Timestamp theTimestamp, global::Java.Util.Calendar theCalendar) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the target instance's transaction isolation level to one of a discrete set of possible values. The transaction isolation level defines the policy implemented on the database for maintaining the data values consistent. </para><para>Keep in mind that setting a transaction isolation level has no effect unless your driver and DBMS support it.</para><para><para>java.sql.Connection </para></para>        
				/// </summary>
				/// <java-name>
				/// setTransactionIsolation
				/// </java-name>
				[Dot42.DexImport("setTransactionIsolation", "(I)V", AccessFlags = 1025)]
				void SetTransactionIsolation(int level) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the type of this <c> RowSet </c> . By default, the type is non-scrollable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1025)]
				void SetType(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the mapping of SQL User Defined Types (UDTs) to Java classes. The Java classes must all implement the SQLData interface.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTypeMap
				/// </java-name>
				[Dot42.DexImport("setTypeMap", "(Ljava/util/Map;)V", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)V")]
				void SetTypeMap(global::Java.Util.IMap<string, global::System.Type> theTypeMap) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the URL used by this <c> RowSet </c> to access the database via a <c> DriverManager </c> . The URL is optional - an alternative is to use a database name to create a connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUrl
				/// </java-name>
				[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetUrl(string theURL) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the URL used by this RowSet to access the database via a <code>DriverManager</code>. The URL is optional - an alternative is to use a Data Source Name to create a connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(ILjava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(int parameterIndex, global::Java.Net.URL theURL) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the <c> Username </c> property for the <c> RowSet </c> , used to authenticate a connection to the database.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUsername
				/// </java-name>
				[Dot42.DexImport("setUsername", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetUsername(string theUsername) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface which provides functionality for a disconnected <c> RowSet </c> to get data from a database into its rows. The <c> RowSet </c> calls the <c> RowSetReader </c> interface when the <c> RowSet </c> 's execute method is invoked - a <c> RowSetReader </c> must first be registered with the <c>   RowSet </c> for this to work.</para><para><para>RowSet </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetReader
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetReader", AccessFlags = 1537)]
		public partial interface IRowSetReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Reads new data into the <c> RowSet </c> . The calling <c> RowSet </c> object must itself implement the <c> RowSetInternal </c> interface and the <c> RowSetReader </c> must be registered as a reader on the <c> RowSet </c> . </para><para>This method adds rows into the calling <c> RowSet </c> . The reader may invoke any of the <c> RowSet </c> 's methods except for the <c> execute </c> method (calling <c> execute </c> will cause an <c> SQLException </c> to be thrown). However, when the reader calls the <c> RowSet </c> 's methods, no events are sent to listeners - any listeners are informed by the calling <c> RowSet </c> 's <c> execute </c> method once the reader returns from the <c> readData </c> method.</para><para><para>RowSetInternal </para></para>        
				/// </summary>
				/// <java-name>
				/// readData
				/// </java-name>
				[Dot42.DexImport("readData", "(Ljavax/sql/RowSetInternal;)V", AccessFlags = 1025)]
				void ReadData(global::Javax.Sql.IRowSetInternal theCaller) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A statement event that a PreparedStatement is closed</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/StatementEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/StatementEvent", AccessFlags = 33)]
		public partial class StatementEvent : global::Java.Util.EventObject
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>the constructor</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/PreparedStatement;Ljava/sql/SQLException;)" +
    "V", AccessFlags = 1)]
				public StatementEvent(global::Javax.Sql.IPooledConnection con, global::Java.Sql.IPreparedStatement statement, global::Java.Sql.SQLException exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>the constructor with null exception</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/PreparedStatement;)V", AccessFlags = 1)]
				public StatementEvent(global::Javax.Sql.IPooledConnection con, global::Java.Sql.IPreparedStatement statement) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the statement of this event </para>        
				/// </summary>
				/// <java-name>
				/// getStatement
				/// </java-name>
				[Dot42.DexImport("getStatement", "()Ljava/sql/PreparedStatement;", AccessFlags = 1)]
				public virtual global::Java.Sql.IPreparedStatement GetStatement() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IPreparedStatement);
				}

				/// <summary>
				/// <para>Returns the exception to be thrown</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exception of this event </para>
				/// </returns>
				/// <java-name>
				/// getSQLException
				/// </java-name>
				[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
				public virtual global::Java.Sql.SQLException GetSQLException() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.SQLException);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StatementEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the statement of this event </para>        
				/// </summary>
				/// <java-name>
				/// getStatement
				/// </java-name>
				public global::Java.Sql.IPreparedStatement Statement
				{
				[Dot42.DexImport("getStatement", "()Ljava/sql/PreparedStatement;", AccessFlags = 1)]
						get{ return GetStatement(); }
				}

				/// <summary>
				/// <para>Returns the exception to be thrown</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exception of this event </para>
				/// </returns>
				/// <java-name>
				/// getSQLException
				/// </java-name>
				public global::Java.Sql.SQLException SQLException
				{
				[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return GetSQLException(); }
				}

		}

		/// <summary>
		/// <para>An interface which provides facilities for handling connections to a database which are pooled. </para><para>Typically, a <c> PooledConnection </c> is recycled when it is no longer required by an application, rather than being closed and discarded. The reason for treating connections in this way is that it can be an expensive process both to establish a connection to a database and to destroy the connection. Reusing connections through a pool is a way of improving system performance and reducing overhead. </para><para>It is not intended that an application uses the <c> PooledConnection </c> interface directly. The <c> PooledConnection </c> interface is intended for use by a component called a connection pool manager, typically part of the infrastructure that supports use of the database by applications. </para><para>Applications obtain connections to the database by calling the DataSource#getConnection method. Behind the scenes, the connection pool manager will get a <c> PooledConnection </c> object from its connection pool and passes back a connection object that wraps or references the <c>   PooledConnection </c> object. A new <c> PooledConnection </c> object will only be created if the pool is empty. </para><para>When the application is finished using a <c> PooledConnection </c> , the application calls the Connection#close method. The connection pool manager is notified via a ConnectionEvent from the connection that this has happened (the pool manager registers itself with the connection before the connection is given to the application). The pool manager removes the underlying <c> PooledConnection </c> object from the connection and returns it to the pool for reuse - the <c> PooledConnection </c> is thus recycled rather than being destroyed. </para><para>The connection to the database represented by the <c> PooledConnection </c> is kept open until the <c> PooledConnection </c> object itself is deactivated by the connection pool manager, which calls <c> PooledConnection.close() </c> . This is typically done if there are too many inactive connections in the pool, if the <c> PooledConnection </c> encounters a problem that makes it unusable or if the whole system is being shut down. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/PooledConnection
		/// </java-name>
		[Dot42.DexImport("javax/sql/PooledConnection", AccessFlags = 1537)]
		public partial interface IPooledConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Registers the supplied <c> ConnectionEventListener </c> with this <c>       PooledConnection </c> . Once registered, the <c> ConnectionEventListener </c> will receive ConnectionEvent events when they occur in the <c> PooledConnection </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addConnectionEventListener
				/// </java-name>
				[Dot42.DexImport("addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", AccessFlags = 1025)]
				void AddConnectionEventListener(global::Javax.Sql.IConnectionEventListener theListener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Closes the connection to the database held by this <c>       PooledConnection </c> . This method should not be called directly by application code - it is intended only for the connection pool manager component.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a connection to the database. This method is typically called by the connection pool manager when an application invokes the method <c> DataSource.getConnection() </c> and there are no <c>       PooledConnection </c> objects available in the connection pool.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Connection </c> object. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Unregisters the supplied <c> ConnectionEventListener </c> from this <c>       PooledConnection </c> . Once unregistered, the <c> ConnectionEventListener </c> will no longer receive events occurring in the <c> PooledConnection </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeConnectionEventListener
				/// </java-name>
				[Dot42.DexImport("removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", AccessFlags = 1025)]
				void RemoveConnectionEventListener(global::Javax.Sql.IConnectionEventListener theListener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Add a StatementEventListener to this PooledConnection object.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// addStatementEventListener
				/// </java-name>
				[Dot42.DexImport("addStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", AccessFlags = 1025)]
				void AddStatementEventListener(global::Javax.Sql.IStatementEventListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Remove a StatementEventListener from this PooledConnection object.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// removeStatementEventListener
				/// </java-name>
				[Dot42.DexImport("removeStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", AccessFlags = 1025)]
				void RemoveStatementEventListener(global::Javax.Sql.IStatementEventListener listener) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Sent when specific events happen on a PooledConnection object. These events are a facility to report when an application closes the pooled connection or when an error occurs in the pooled connection. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/ConnectionEvent
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionEvent", AccessFlags = 33)]
		public partial class ConnectionEvent : global::Java.Util.EventObject, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a connection event initialized with the supplied <c>       PooledConnection </c> reporting that the application has closed the connection.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;)V", AccessFlags = 1)]
				public ConnectionEvent(global::Javax.Sql.IPooledConnection theConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a <c> ConnectionEvent </c> initialized with the supplied <c>       PooledConnection </c> and with the supplied <c> SQLException </c> indicating that an error has occurred within the <c> PooledConnection </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/sql/PooledConnection;Ljava/sql/SQLException;)V", AccessFlags = 1)]
				public ConnectionEvent(global::Javax.Sql.IPooledConnection theConnection, global::Java.Sql.SQLException theException) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> SQLException </c> which holds information about the error which occurred in the <c> PooledConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> SQLException </c> containing information about the error. May be <c> null </c> if no error has occurred. </para>
				/// </returns>
				/// <java-name>
				/// getSQLException
				/// </java-name>
				[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
				public virtual global::Java.Sql.SQLException GetSQLException() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.SQLException);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnectionEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the <c> SQLException </c> which holds information about the error which occurred in the <c> PooledConnection </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> SQLException </c> containing information about the error. May be <c> null </c> if no error has occurred. </para>
				/// </returns>
				/// <java-name>
				/// getSQLException
				/// </java-name>
				public global::Java.Sql.SQLException SQLException
				{
				[Dot42.DexImport("getSQLException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return GetSQLException(); }
				}

		}

		/// <summary>
		/// <para>An interface for the creation of <c> Connection </c> objects which represent a connection to a database. This interface is an alternative to the <c>   java.sql.DriverManager </c> . </para><para>A class which implements the <c> DataSource </c> interface is typically registered with a JNDI naming service directory and is retrieved from there by name. </para><para>The <c> DataSource </c> interface is typically implemented by the writer of a JDBC driver. There are three variants of the <c> DataSource </c> interface, which produce connections with different characteristics: <ol><li><para><b>Standard <c> DataSource </c> </b>: produces standard <c> Connection </c> objects with no special features. </para></li><li><para><b>Connection Pool <c> DataSource </c> </b>: produces <c>   PooledConnection </c> objects which require a connection pool manager as an intermediary component. </para></li><li><para><b>Distributed transaction <c> DataSource </c> ("XADataSource")</b>: produces <c> XAConnection </c> objects which can be used to handle distributed transactions which typically require an intermediary transaction manager component. <c> XAConnection </c> objects also provide connection pooling capabilities as well as distributed transaction capabilities. </para></li></ol></para><para>Note that a JDBC driver which is accessed via the <c> DataSource </c> interface is loaded via a JNDI lookup process. A driver loaded in this way does not register itself with the <c> DriverManager </c> . </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/DataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/DataSource", AccessFlags = 1537)]
		public partial interface IDataSource : global::Javax.Sql.ICommonDataSource, global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a connection to the database represented by this <c>       DataSource </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Connection </c> object which is a connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a connection to the database represented by this <c>       DataSource </c> , using the supplied user name and password.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Connection </c> object which is the connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection GetConnection(string theUsername, string thePassword) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface used to receive events generated by a PooledConnection. </para><para>This interface would typically be implemented by a component which manages a connection pool (a connection pool manager). A connection triggers an event to a <c> ConnectionEventListener </c> either when the application closes a connection it has been using or when a significant error occurs while the connection is being used. </para><para>The connection pool manager can return closed connections to the pool for later reuse. Connections experiencing an error should be discarded. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/ConnectionEventListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionEventListener", AccessFlags = 1537)]
		public partial interface IConnectionEventListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Notifies the <c> ConnectionEventListener </c> that an application has called the <c> close </c> method on a pooled connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectionClosed
				/// </java-name>
				[Dot42.DexImport("connectionClosed", "(Ljavax/sql/ConnectionEvent;)V", AccessFlags = 1025)]
				void ConnectionClosed(global::Javax.Sql.ConnectionEvent theEvent) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the <c> ConnectionEventListener </c> that an error has occurred on a <c> PooledConnection </c> . This notification is triggered <b>before</b> the <c> SQLException </c> , which is available through the event argument, is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// connectionErrorOccurred
				/// </java-name>
				[Dot42.DexImport("connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V", AccessFlags = 1025)]
				void ConnectionErrorOccurred(global::Javax.Sql.ConnectionEvent theEvent) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface for the creation of <c> ConnectionPoolDataSource </c> objects. Used internally within the package. </para><para>A class which implements the <c> ConnectionPoolDataSource </c> interface is typically registered with a JNDI naming service directory and is retrieved from there by name. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/ConnectionPoolDataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/ConnectionPoolDataSource", AccessFlags = 1537)]
		public partial interface IConnectionPoolDataSource : global::Javax.Sql.ICommonDataSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a connection to a database which can then be used as a pooled connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> PooledConnection </c> which represents the connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// getPooledConnection
				/// </java-name>
				[Dot42.DexImport("getPooledConnection", "()Ljavax/sql/PooledConnection;", AccessFlags = 1025)]
				global::Javax.Sql.IPooledConnection GetPooledConnection() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a connection to a database, using the supplied user name and password, which can then be used as a pooled connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> PooledConnection </c> object which represents the connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// getPooledConnection
				/// </java-name>
				[Dot42.DexImport("getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;", AccessFlags = 1025)]
				global::Javax.Sql.IPooledConnection GetPooledConnection(string theUser, string thePassword) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface which provides facilities for getting information about the columns in a <c> RowSet </c> . </para><para><c> RowSetMetaData </c> extends java.sql.ResultSetMetaData, adding new operations for carrying out value sets. </para><para>Application code would not normally call this interface directly. It would be called internally when <c> RowSet.execute </c> is called.</para><para><para>RowSetInternal::setMetaData(RowSetMetaData) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetMetaData
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetMetaData", AccessFlags = 1537)]
		public partial interface IRowSetMetaData : global::Java.Sql.IResultSetMetaData
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sets automatic numbering for a specified column in the <c> RowSet </c> . If automatic numbering is on, the column is read-only. The default value for the auto increment parameter is <c> false </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAutoIncrement
				/// </java-name>
				[Dot42.DexImport("setAutoIncrement", "(IZ)V", AccessFlags = 1025)]
				void SetAutoIncrement(int columnIndex, bool autoIncrement) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the case sensitive property for a specified column in the <c>       RowSet </c> . The default is that the column is not case sensitive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCaseSensitive
				/// </java-name>
				[Dot42.DexImport("setCaseSensitive", "(IZ)V", AccessFlags = 1025)]
				void SetCaseSensitive(int columnIndex, bool caseSensitive) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the catalog name for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCatalogName
				/// </java-name>
				[Dot42.DexImport("setCatalogName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetCatalogName(int columnIndex, string catalogName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the number of columns contained in the row set.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnCount
				/// </java-name>
				[Dot42.DexImport("setColumnCount", "(I)V", AccessFlags = 1025)]
				void SetColumnCount(int columnCount) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the normal maximum width in characters for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnDisplaySize
				/// </java-name>
				[Dot42.DexImport("setColumnDisplaySize", "(II)V", AccessFlags = 1025)]
				void SetColumnDisplaySize(int columnIndex, int displaySize) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the suggested name as label for the column contained in the <c>       RowSet </c> . The label is an alias for printing and displaying purposes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnLabel
				/// </java-name>
				[Dot42.DexImport("setColumnLabel", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnLabel(int columnIndex, string theLabel) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the column name for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnName
				/// </java-name>
				[Dot42.DexImport("setColumnName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnName(int columnIndex, string theColumnName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the SQL type for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnType
				/// </java-name>
				[Dot42.DexImport("setColumnType", "(II)V", AccessFlags = 1025)]
				void SetColumnType(int columnIndex, int theSQLType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the type name for a specified column in the <c> RowSet </c> , where the data type is specific to the data source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnTypeName
				/// </java-name>
				[Dot42.DexImport("setColumnTypeName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetColumnTypeName(int columnIndex, string theTypeName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether a specified column is a currency value. The default value is <c> false </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrency
				/// </java-name>
				[Dot42.DexImport("setCurrency", "(IZ)V", AccessFlags = 1025)]
				void SetCurrency(int columnIndex, bool isCurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether a specified column can contain SQL <c> NULL </c> values.</para><para>The default value is <c>                  ResultSetMetaData.columnNullableUnknown </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setNullable
				/// </java-name>
				[Dot42.DexImport("setNullable", "(II)V", AccessFlags = 1025)]
				void SetNullable(int columnIndex, int nullability) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the number of decimal digits for a specified column in the <c>       RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPrecision
				/// </java-name>
				[Dot42.DexImport("setPrecision", "(II)V", AccessFlags = 1025)]
				void SetPrecision(int columnIndex, int thePrecision) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Declares how many decimal digits there should be after a decimal point for the column specified by <c> columnIndex </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(II)V", AccessFlags = 1025)]
				void SetScale(int columnIndex, int theScale) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the schema name for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSchemaName
				/// </java-name>
				[Dot42.DexImport("setSchemaName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetSchemaName(int columnIndex, string theSchemaName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets whether a specified column can be used in a search involving a <c> WHERE </c> clause. The default value is <c> false </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSearchable
				/// </java-name>
				[Dot42.DexImport("setSearchable", "(IZ)V", AccessFlags = 1025)]
				void SetSearchable(int columnIndex, bool isSearchable) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets if a specified column can contain signed numbers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSigned
				/// </java-name>
				[Dot42.DexImport("setSigned", "(IZ)V", AccessFlags = 1025)]
				void SetSigned(int columnIndex, bool isSigned) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the table name for a specified column in the <c> RowSet </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTableName
				/// </java-name>
				[Dot42.DexImport("setTableName", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetTableName(int columnIndex, string theTableName) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface which provides functionality for a disconnected <c> RowSet </c> to put data updates back to the data source from which the <c> RowSet </c> was originally populated. An object implementing this interface is called a writer. </para><para>The writer must establish a connection to the <c> RowSet </c> 's database before writing the data. The <c> RowSet </c> calling this interface must implement the <c> RowSetInternal </c> interface. </para><para>The writer may encounter a situation where the updated data needs to be written back to the database, but has already been updated there in the mean time. How a conflict of this kind is handled is determined by the implementation of this writer.</para><para><para>RowSetInternal </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetWriter
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetWriter", AccessFlags = 1537)]
		public partial interface IRowSetWriter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Writes changes made in the <c> RowSet </c> , which is associated with this <c> RowSetWriter </c> , back to the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the modified data was written, <c> false </c> otherwise (which typically implies some form of conflict). </para>
				/// </returns>
				/// <java-name>
				/// writeData
				/// </java-name>
				[Dot42.DexImport("writeData", "(Ljavax/sql/RowSetInternal;)Z", AccessFlags = 1025)]
				bool WriteData(global::Javax.Sql.IRowSetInternal theRowSet) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An interface used to send notification of events occurring in the context of a RowSet. To receive the notification events, an object must implement the <c> RowSetListener </c> interface and then register itself with the <c> RowSet </c> of interest using the RowSet#addRowSetListener(RowSetListener) method. </para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/RowSetListener
		/// </java-name>
		[Dot42.DexImport("javax/sql/RowSetListener", AccessFlags = 1537)]
		public partial interface IRowSetListener : global::Java.Util.IEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Notifies the listener that the <c> RowSet </c> 's cursor in <c>       theEvent.getSource </c> has moved.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// cursorMoved
				/// </java-name>
				[Dot42.DexImport("cursorMoved", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void CursorMoved(global::Javax.Sql.RowSetEvent theEvent) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the listener that one of the <c> RowSet </c> 's rows in <c>       theEvent.getSource </c> has changed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rowChanged
				/// </java-name>
				[Dot42.DexImport("rowChanged", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void RowChanged(global::Javax.Sql.RowSetEvent theEvent) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the listener that the <c> RowSet </c> 's entire contents in <c> theEvent.getSource </c> have been updated (an example is the execution of a command which retrieves new data from the database).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rowSetChanged
				/// </java-name>
				[Dot42.DexImport("rowSetChanged", "(Ljavax/sql/RowSetEvent;)V", AccessFlags = 1025)]
				void RowSetChanged(global::Javax.Sql.RowSetEvent theEvent) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface that defines the methods which are common between DataSource, XADataSource and ConnectionPoolDataSource.</para><para><para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/sql/CommonDataSource
		/// </java-name>
		[Dot42.DexImport("javax/sql/CommonDataSource", AccessFlags = 1537)]
		public partial interface ICommonDataSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>While attempting to connect to a database, this method get the maximum time in seconds that this data source can wait.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An integer value to indicate the maximum time. </para>
				/// </returns>
				/// <java-name>
				/// getLoginTimeout
				/// </java-name>
				[Dot42.DexImport("getLoginTimeout", "()I", AccessFlags = 1025)]
				int GetLoginTimeout() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieves a log writer which is a character output stream to which all logging and tracing messages for this data source will be printed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The PrintWriter object for this DataSource. </para>
				/// </returns>
				/// <java-name>
				/// getLogWriter
				/// </java-name>
				[Dot42.DexImport("getLogWriter", "()Ljava/io/PrintWriter;", AccessFlags = 1025)]
				global::Java.Io.PrintWriter GetLogWriter() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>While attempting to connect to a database, this method set the maximum time in seconds that this data source can wait.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLoginTimeout
				/// </java-name>
				[Dot42.DexImport("setLoginTimeout", "(I)V", AccessFlags = 1025)]
				void SetLoginTimeout(int seconds) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set a log writer which is a character output stream to which all logging and tracing messages for this data source will be printed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLogWriter
				/// </java-name>
				[Dot42.DexImport("setLogWriter", "(Ljava/io/PrintWriter;)V", AccessFlags = 1025)]
				void SetLogWriter(global::Java.Io.PrintWriter @out) /* MethodBuilder.Create */ ;

		}

}


