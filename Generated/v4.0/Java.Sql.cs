#pragma warning disable 1717
namespace Java.Sql
{
		/// <summary>
		///  <para>This exception is thrown if a problem occurs during a batch update operation. </para> <para>A <c>BatchUpdateException </c> provides additional information about the problem that occurred, compared with a standard <c>SQLException </c> . It supplies update counts for successful commands which were executed before the exception was encountered. </para> <para>The element order in the array of update counts matches the order that the commands were added to the batch operation. </para> <para>Once a batch update command fails and a <c>BatchUpdateException </c> is thrown, the JDBC driver may continue processing the remaining commands in the batch. If the driver does process more commands after the problem occurs, the array returned by <c>BatchUpdateException.getUpdateCounts </c> has an element for every command in the batch, not only those that executed successfully. In this case, the array element for any command which encountered a problem is set to <c>Statement.EXECUTE_FAILED </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/BatchUpdateException
		/// </java-name>
		[Dot42.DexImport("java/sql/BatchUpdateException", AccessFlags = 33)]
		public partial class BatchUpdateException : global::Java.Sql.SQLException, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a default <c>BatchUpdateException </c> with the parameters  <b>reason</b>,  <b>SQLState</b>, and  <b>update counts</b> set to <c>null </c> and the  <b>vendor code</b> set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an BatchUpdateException object. The cause Throwable object is set to the given cause Throwable object and the updateCounts array set to the int array parameter. VendorCode is set to the given vendorCode. SQLState is initialized to null while vendorCode is zero.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public BatchUpdateException(string reason, string SQLState, int vendorCode, int[] updateCounts, global::System.Exception cause) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Gets the  <b>update count</b> array giving status information for every command that was attempted in the batch. </para> <para>If a batch update command fails and a <c>BatchUpdateException </c> is thrown, the JDBC driver may continue processing the remaining commands in the batch. If the driver does so, the array returned by <c>BatchUpdateException.getUpdateCounts </c> has an element for every command in the batch, not only those that executed successfully. In this case, the array element for any command which encountered a problem is set to  <c>Statement.EXECUTE_FAILED </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array that contains the successful update counts, before this exception was thrown. Alternatively, if the driver continues to process commands following an error, for each successive command there is a corresponding element in the array giving one of the following status values:  <ol> <li> <para>the number of successful updates </para></li> <li> <para> <c>Statement.SUCCESS_NO_INFO </c> indicating that the command completed successfully, but the amount of altered rows is unknown. </para></li> <li> <para> <c>Statement.EXECUTE_FAILED </c> indicating that the command was unsuccessful. </para></li></ol></para>
				/// </returns>
				/// <java-name>
				/// getUpdateCounts
				/// </java-name>
				public virtual int[] UpdateCounts
				{
						[Dot42.DexImport("getUpdateCounts", "()[I", AccessFlags = 1)]
						get{ return default(int[]); }
				}

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

		/// <summary>
		///  <para>An exception which is thrown when a JDBC driver unexpectedly truncates a data value either when reading (resulting in warning), or when writing data (resulting in an error). The <c>SQLState </c> error code for truncated data is <c>01004 </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/DataTruncation
		/// </java-name>
		[Dot42.DexImport("java/sql/DataTruncation", AccessFlags = 33)]
		public partial class DataTruncation : global::Java.Sql.SQLWarning, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates the <c>DataTruncation </c> object. The reason is set to <c>"Data truncation" </c> , the error code is set to the <c>SQLException </c> default value, and the other fields are set to the values supplied as arguments.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZZII)V", AccessFlags = 1)]
				public DataTruncation(int index, bool parameter, bool read, int dataSize, int transferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a DataTruncation. The Reason is set to "Data truncation", the error code is set to the SQLException default value and other fields are set to the values supplied on this method.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZZIILjava/lang/Throwable;)V", AccessFlags = 1)]
				public DataTruncation(int index, bool parameter, bool read, int dataSize, int transferSize, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DataTruncation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the number of bytes of data that should have been read/written.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes that should have been read or written. The value is set to <c>-1 </c> if the size is unknown. </para>
				/// </returns>
				/// <java-name>
				/// getDataSize
				/// </java-name>
				public virtual int DataSize
				{
						[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the index of the column or of the parameter that was truncated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index number of the column or of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets whether the value truncated was a parameter value or a column value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value truncated was a parameter value,  <c>false </c> if it was a column value. </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				public virtual bool Parameter
				{
						[Dot42.DexImport("getParameter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether the value was truncated on a read operation or a write operation</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value was truncated on a read operation,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getRead
				/// </java-name>
				public virtual bool Read
				{
						[Dot42.DexImport("getRead", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the number of bytes of data that was actually read or written.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually read/written. The value may be set to <c>-1 </c> if the size is unknown. </para>
				/// </returns>
				/// <java-name>
				/// getTransferSize
				/// </java-name>
				public virtual int TransferSize
				{
						[Dot42.DexImport("getTransferSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>A class which can consume and produce dates in SQL <c>Date </c> format. </para> <para>Dates are represented in SQL as <c>yyyy-MM-dd </c> . Note that this date format only deals with year, month and day values. There are no values for hours, minutes, seconds. </para> <para>This is unlike the familiar <c>java.util.Date </c> object, which also includes values for hours, minutes, seconds, and milliseconds. </para> <para>Time points are handled as millisecond values - milliseconds since the Epoch, January 1st 1970, 00:00:00.000 GMT. Time values passed to the <c>java.sql.Date </c> class are "normalized" to the time 00:00:00.000 GMT on the date implied by the time value. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Date
		/// </java-name>
		[Dot42.DexImport("java/sql/Date", AccessFlags = 33)]
		public partial class Date : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>Date </c> object corresponding to the supplied year, month and day.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the constructor Date(long) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Date(int theYear, int theMonth, int theDay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a date which corresponds to the day determined by the supplied milliseconds time value <c>theDate </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Date(long theDate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Produces a string representation of the date in SQL format</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of the date in SQL format - <c>"yyyy-MM-dd" </c> . </para>
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
				///  <para>Creates a <c>Date </c> from a string representation of a date in SQL format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Date </c> object. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Date;", AccessFlags = 9)]
				public static global::Java.Sql.Date ValueOf(string dateString) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Date);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Date() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. SQL <c>Date </c> values do not have an hours component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getHours
				/// </java-name>
				public override int Hours
				{
						[Dot42.DexImport("getHours", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHours", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. SQL <c>Date </c> values do not have a minutes component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getMinutes
				/// </java-name>
				public override int Minutes
				{
						[Dot42.DexImport("getMinutes", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinutes", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. SQL <c>Date </c> values do not have a seconds component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getSeconds
				/// </java-name>
				public override int Seconds
				{
						[Dot42.DexImport("getSeconds", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSeconds", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Sets this date to a date supplied as a milliseconds value. The date is set based on the supplied time value and rounded to zero GMT for that day.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				public override long Time
				{
						[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Provides facilities for managing JDBC drivers. The  <code>android.database</code> and  <code>android.database.sqlite</code> packages offer a higher-performance alternative for new code.</para> <para>Note that Android does not include any JDBC drivers by default; you must provide your own.</para> <para>The <c>DriverManager </c> class loads JDBC drivers during its initialization, from the list of drivers referenced by the system property <c>"jdbc.drivers" </c> . </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Removes a driver from the <c>DriverManager </c> 's registered driver list. This will only succeed when the caller's class loader loaded the driver that is to be removed. If the driver was loaded by a different class loader, the removal of the driver fails silently. </para> <para>If the removal succeeds, the <c>DriverManager </c> will not use this driver in the future when asked to get a <c>Connection </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// deregisterDriver
				/// </java-name>
				[Dot42.DexImport("deregisterDriver", "(Ljava/sql/Driver;)V", AccessFlags = 9)]
				public static void DeregisterDriver(global::Java.Sql.IDriver driver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to establish a connection to the given database URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Connection </c> to the database identified by the URL.  <c>null </c> if no connection can be established. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string url) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <summary>
				///  <para>Attempts to establish a connection to the given database URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Connection </c> to the database identified by the URL.  <c>null </c> if no connection can be established. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string url, global::Java.Util.Properties info) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <summary>
				///  <para>Attempts to establish a connection to the given database URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Connection </c> to the database identified by the URL.  <c>null </c> if no connection can be established. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", AccessFlags = 9)]
				public static global::Java.Sql.IConnection GetConnection(string url, string user, string password) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IConnection);
				}

				/// <summary>
				///  <para>Tries to find a driver that can interpret the supplied URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Driver </c> that matches the provided URL. <c>null </c> if no <c>Driver </c> understands the URL </para>
				/// </returns>
				/// <java-name>
				/// getDriver
				/// </java-name>
				[Dot42.DexImport("getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;", AccessFlags = 9)]
				public static global::Java.Sql.IDriver GetDriver(string url) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.IDriver);
				}

				/// <summary>
				///  <para>Prints a message to the current JDBC log stream. This is either the  <c>PrintWriter </c> or (deprecated) the <c>PrintStream </c> , if set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Println(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers a given JDBC driver with the <c>DriverManager </c> . </para> <para>A newly loaded JDBC driver class should register itself with the  <c>DriverManager </c> by calling this method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// registerDriver
				/// </java-name>
				[Dot42.DexImport("registerDriver", "(Ljava/sql/Driver;)V", AccessFlags = 9)]
				public static void RegisterDriver(global::Java.Sql.IDriver driver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an <c>Enumeration </c> that contains all of the loaded JDBC drivers that the current caller can access.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An <c>Enumeration </c> containing all the currently loaded JDBC  <c>Drivers </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDrivers
				/// </java-name>
				public static global::Java.Util.IEnumeration<global::Java.Sql.IDriver> Drivers
				{
						[Dot42.DexImport("getDrivers", "()Ljava/util/Enumeration;", AccessFlags = 9, Signature = "()Ljava/util/Enumeration<Ljava/sql/Driver;>;")]
						get{ return default(global::Java.Util.IEnumeration<global::Java.Sql.IDriver>); }
				}

				/// <summary>
				///  <para>Returns the login timeout when connecting to a database in seconds.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the login timeout in seconds. </para>
				/// </returns>
				/// <java-name>
				/// getLoginTimeout
				/// </java-name>
				public static int LoginTimeout
				{
						[Dot42.DexImport("getLoginTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
						[Dot42.DexImport("setLoginTimeout", "(I)V", AccessFlags = 9)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the log <c>PrintStream </c> used by the <c>DriverManager </c> and all the JDBC Drivers.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getLogWriter() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>PrintStream </c> used for logging activities. </para>
				/// </returns>
				/// <java-name>
				/// getLogStream
				/// </java-name>
				public static global::Java.IO.PrintStream LogStream
				{
						[Dot42.DexImport("getLogStream", "()Ljava/io/PrintStream;", AccessFlags = 9)]
						get{ return default(global::Java.IO.PrintStream); }
						[Dot42.DexImport("setLogStream", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
						set{ }
				}

				/// <summary>
				///  <para>Retrieves the log writer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A <c>PrintWriter </c> object used as the log writer. <c>null </c> if no log writer is set. </para>
				/// </returns>
				/// <java-name>
				/// getLogWriter
				/// </java-name>
				public static global::Java.IO.PrintWriter LogWriter
				{
						[Dot42.DexImport("getLogWriter", "()Ljava/io/PrintWriter;", AccessFlags = 9)]
						get{ return default(global::Java.IO.PrintWriter); }
						[Dot42.DexImport("setLogWriter", "(Ljava/io/PrintWriter;)V", AccessFlags = 9)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A class holding information about driver properties of a database connection. This class is returned by the Driver#getPropertyInfo(String, java.util.Properties) method and allows for the advanced connection handling. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/DriverPropertyInfo
		/// </java-name>
		[Dot42.DexImport("java/sql/DriverPropertyInfo", AccessFlags = 33)]
		public partial class DriverPropertyInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If the value member can be chosen from a set of possible values, they are contained here. Otherwise choices is <c>null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// choices
				/// </java-name>
				[Dot42.DexImport("choices", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Choices;
				/// <summary>
				///  <para>A description of the property. May be <c>null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// description
				/// </java-name>
				[Dot42.DexImport("description", "Ljava/lang/String;", AccessFlags = 1)]
				public string Description;
				/// <summary>
				///  <para>The name of the property. </para>        
				/// </summary>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <summary>
				///  <para> <c>true </c> when the value member must be provided during <c>Driver.connect </c> . <c>false </c> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// required
				/// </java-name>
				[Dot42.DexImport("required", "Z", AccessFlags = 1)]
				public bool Required;
				/// <summary>
				///  <para>The current value associated with this property. It is depending on the data gathered by the <c>getPropertyInfo </c> method, the general Java environment and the driver's default values. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "Ljava/lang/String;", AccessFlags = 1)]
				public string Value;
				/// <summary>
				///  <para>Creates a <c>DriverPropertyInfo </c> instance with the supplied name and value. Other class members take their default values.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DriverPropertyInfo(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DriverPropertyInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A Java representation of the SQL <c>ARRAY </c> type. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Array
		/// </java-name>
		[Dot42.DexImport("java/sql/Array", AccessFlags = 1537)]
		public partial interface IArray
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns part of the SQL <c>ARRAY </c> associated with this array, starting at a particular <c>index </c> and comprising up to <c>count </c> successive elements of the SQL array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Java array containing the desired set of elements from this Array </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(JI)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetArray(long index, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns part of the SQL <c>ARRAY </c> associated with this array, starting at a particular <c>index </c> and comprising up to <c>count </c> successive elements of the SQL array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Java array containing the desired set of elements from this Array </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(JILjava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetArray(long index, int count, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the data from the underlying SQL <c>ARRAY </c> as a Java array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Java array containing the elements of this array </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetArray(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>ResultSet </c> object that holds the entries of a subarray, beginning at a particular index and comprising up to <c>count </c> successive entries.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the elements of the array as a <c>ResultSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(JI)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetResultSet(long index, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>ResultSet </c> object that holds the entries of a subarray, beginning at a particular index and comprising up to <c>count </c> successive entries.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>ResultSet </c> the array's custom type values. if a database error has occurred. </para>
				/// </returns>
				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(JILjava/util/Map;)Ljava/sql/ResultSet;", AccessFlags = 1025, Signature = "(JILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/sql/ResultSet;")]
				global::Java.Sql.IResultSet GetResultSet(long index, int count, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>ResultSet </c> object which holds the entries of the SQL  <c>ARRAY </c> associated with this array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the array as a <c>ResultSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// getResultSet
				/// </java-name>
				[Dot42.DexImport("getResultSet", "(Ljava/util/Map;)Ljava/sql/ResultSet;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/sql/ResultSet;")]
				global::Java.Sql.IResultSet GetResultSet(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Frees any resources held by this array. After <c>free </c> is called, calling method other than <c>free </c> will throw <c>SQLException </c> (calling <c>free </c> repeatedly will do nothing). </para>        
				/// </summary>
				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves the contents of the SQL <c>ARRAY </c> value as a Java array object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Java array containing the elements of this Array </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				object Array
				{
						[Dot42.DexImport("getArray", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the JDBC type of the entries in this array's underlying SQL array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer constant from the <c>java.sql.Types </c> class </para>
				/// </returns>
				/// <java-name>
				/// getBaseType
				/// </java-name>
				int BaseType
				{
						[Dot42.DexImport("getBaseType", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the SQL type name of the entries in this array's underlying SQL array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The database specific name or a fully-qualified SQL type name. </para>
				/// </returns>
				/// <java-name>
				/// getBaseTypeName
				/// </java-name>
				string BaseTypeName
				{
						[Dot42.DexImport("getBaseTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a ResultSet object which holds the entries of the SQL <c>ARRAY </c> associated with this array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the elements of the array as a <c>ResultSet </c> . </para>
				/// </returns>
				/// <java-name>
				/// getResultSet
				/// </java-name>
				global::Java.Sql.IResultSet ResultSet
				{
						[Dot42.DexImport("getResultSet", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A Java interface representing the SQL <c>BLOB </c> type. </para> <para>An SQL <c>BLOB </c> type stores a large array of binary data (bytes) as the value in a column of a database. </para> <para>The <c>java.sql.Blob </c> interface provides methods for setting and retrieving data in the <c>Blob </c> , for querying <c>Blob </c> data length, and for searching for data within the <c>Blob </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Blob
		/// </java-name>
		[Dot42.DexImport("java/sql/Blob", AccessFlags = 1537)]
		public partial interface IBlob
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Retrieves <c>length </c> bytes from this <c>Blob </c> , starting at 1-based offset <c>pos </c> , and returns them as a binary stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a binary <c>InputStream </c> giving access to the <c>Blob </c> data. </para>
				/// </returns>
				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "(JJ)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream GetBinaryStream(long pos, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a portion of the value of this <c>Blob </c> as an array of bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte array containing the data from the <c>Blob </c> , starting at <c>pos </c> and is up to <c>length </c> bytes long. </para>
				/// </returns>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(JI)[B", AccessFlags = 1025)]
				byte[] GetBytes(long pos, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of bytes in this <c>Blob </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>long </c> value with the length of the <c>Blob </c> in bytes. </para>
				/// </returns>
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
				long Position(byte[] @byte, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a stream that can be used to write binary data to this <c>Blob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a binary <c>InputStream </c> which can be used to write data into the <c>Blob </c> starting at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(J)Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.IO.OutputStream SetBinaryStream(long pos) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes a specified array of bytes to this <c>Blob </c> object, starting at a specified position. Returns the number of bytes written.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an integer containing the number of bytes written to the <c>Blob </c> . </para>
				/// </returns>
				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(J[B)I", AccessFlags = 1025)]
				int SetBytes(long pos, byte[] theBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes a portion of a specified byte array to this <c>Blob </c> . Returns the number of bytes written.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an integer containing the number of bytes written to the <c>Blob </c> . </para>
				/// </returns>
				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(J[BII)I", AccessFlags = 1025)]
				int SetBytes(long pos, byte[] theBytes, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Truncate the value of this <c>Blob </c> object to a specified length in bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)V", AccessFlags = 1025)]
				void Truncate(long len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Frees any resources held by this blob. After <c>free </c> is called, calling method other than <c>free </c> will throw <c>SQLException </c> (calling <c>free </c> repeatedly will do nothing).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves this <c>Blob </c> object as a binary stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a binary <c>InputStream </c> giving access to the <c>Blob </c> data. </para>
				/// </returns>
				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				global::Java.IO.InputStream BinaryStream
				{
						[Dot42.DexImport("getBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An interface used to call  <b>Stored Procedures</b>. </para> <para>The JDBC API provides an SQL escape syntax allowing  <b>Stored Procedures</b> to be called in a standard way for all databases. The JDBC escape syntax has two forms. One form includes a result parameter. The second form does not include a result parameter. Where the result parameter is used, it must be declared as an <c>OUT </c> parameter. Other parameters can be declared as  <c>IN </c> , <c>OUT </c> , or <c>INOUT </c> . Parameters are referenced either by name or by a numerical index starting at 1. </para> <para>The correct syntax is:  ?= call &lt;procedurename&gt; [( [parameter1,parameter2,...] )] } </para> <para>call &lt;procedurename&gt; [( [parameter1,parameter2,...] )] } </para> <para> <c>IN </c> parameters are set before calling the procedure, using the setter methods which are inherited from <c>PreparedStatement </c> . For <c>OUT </c> parameters, their type must be registered before executing the stored procedure. The values are retrieved using the getter methods defined in the <c>CallableStatement </c> interface. </para> <para> <c>CallableStatement </c> s can return one or more <c>ResultSets </c> . In the event that multiple <c>ResultSets </c> are returned, they are accessed using the methods inherited from the <c>Statement </c> interface. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/CallableStatement
		/// </java-name>
		[Dot42.DexImport("java/sql/CallableStatement", AccessFlags = 1537)]
		public partial interface ICallableStatement : global::Java.Sql.IPreparedStatement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>ARRAY </c> parameter as a  <c>java.sql.Array </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Array </c> containing the parameter value. </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(I)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>ARRAY </c> parameter as a  <c>java.sql.Array </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Array </c> containing the parameter value. </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "(Ljava/lang/String;)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray GetArray(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new BigDecimal representation of the JDBC <c>NUMERIC </c> parameter specified by the input index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.math.BigDecimal </c> representing the value of the specified parameter. The value <c>null </c> is returned if the parameter in question is an SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(I)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new BigDecimal representation of the JDBC <c>NUMERIC </c> parameter specified by the input index. The number of digits after the decimal point is specified by <c>scale </c> .</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getBigDecimal(int) or getBigDecimal(String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.math.BigDecimal </c> representing the value of the specified parameter. The value <c>null </c> is returned if the parameter in question is an SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(II)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex, int scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new BigDecimal representation of the JDBC <c>NUMERIC </c> parameter specified by the input index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.math.BigDecimal </c> representing the value of the specified parameter. The value <c>null </c> is returned if the parameter in question is an SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBigDecimal
				/// </java-name>
				[Dot42.DexImport("getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal GetBigDecimal(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>BLOB </c> parameter as a <c>java.sql.Blob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Blob </c> representing the value of the specified parameter. The value <c>null </c> is returned if the parameter in question is an SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>BLOB </c> parameter as a <c>java.sql.Blob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Blob </c> representing the value of the specified parameter. The value <c>null </c> is returned if the parameter in question is an SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob GetBlob(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>BIT </c> parameter as a boolean.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>boolean </c> representing the parameter value. <c>false </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1025)]
				bool GetBoolean(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>BIT </c> parameter as a boolean.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>boolean </c> representing the parameter value. <c>false </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetBoolean(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TINYINT </c> parameter as a <c>byte </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>byte </c> representation of the value of the parameter.  <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(I)B", AccessFlags = 1025)]
				byte GetByte(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TINYINT </c> parameter as a <c>byte </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>byte </c> representation of the value of the parameter.  <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1025)]
				byte GetByte(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a byte array representation of the indexed JDBC <c>BINARY </c> or  <c>VARBINARY </c> parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of bytes giving the value of the parameter. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(I)[B", AccessFlags = 1025)]
				byte[] GetBytes(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a byte array representation of the indexed JDBC <c>BINARY </c> or  <c>VARBINARY </c> parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of bytes giving the value of the parameter. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				byte[] GetBytes(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>CLOB </c> parameter as a <c>java.sql.Clob </c> .</para> <para> <para>Clob </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Clob </c> representing the value of the parameter. <c>null </c> is returned if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(I)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>CLOB </c> parameter as a <c>java.sql.Clob </c> .</para> <para> <para>Clob </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Clob </c> representing the value of the parameter. <c>null </c> is returned if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getClob
				/// </java-name>
				[Dot42.DexImport("getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob GetClob(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DATE </c> parameter as a <c>java.sql.Date </c> .</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>java.sql.Date </c> representing the parameter's value.  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(I)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DATE </c> parameter as a <c>java.sql.Date </c> , using the specified <c>Calendar </c> to construct the date.</para> <para>The JDBC driver uses the calendar to create the Date using a particular timezone and locale. The default behavior of the driver is to use the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>java.sql.Date </c> giving the parameter's value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(int parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DATE </c> parameter as a <c>java.sql.Date </c> .</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>java.sql.Date </c> representing the parameter's value.  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DATE </c> parameter as a <c>java.sql.Date </c> , using the specified <c>Calendar </c> to construct the date.</para> <para>The JDBC driver uses the calendar to create the Date using a particular timezone and locale. The default behavior of the driver is to use the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>java.sql.Date </c> giving the parameter's value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date GetDate(string parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DOUBLE </c> parameter as a  <c>double </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>double </c> . <c>0.0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				double GetDouble(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>DOUBLE </c> parameter as a  <c>double </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>double </c> . <c>0.0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1025)]
				double GetDouble(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>FLOAT </c> parameter as a <c>float </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>float </c> . <c>0.0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				float GetFloat(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>FLOAT </c> parameter as a <c>float </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>float </c> . <c>0.0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;)F", AccessFlags = 1025)]
				float GetFloat(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>INTEGER </c> parameter as an  <c>int </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>int </c> giving the parameter's value. <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				int GetInt(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>INTEGER </c> parameter as an  <c>int </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>int </c> giving the parameter's value. <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetInt(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>BIGINT </c> parameter as a  <c>long </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>long </c> giving the parameter's value. <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				long GetLong(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified JDBC <c>BIGINT </c> parameter as a  <c>long </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>long </c> giving the parameter's value. <c>0 </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1025)]
				long GetLong(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified parameter as a Java <c>Object </c> . </para> <para>The object type returned is the JDBC type registered for the parameter with a <c>registerOutParameter </c> call. If a parameter was registered as a <c>java.sql.Types.OTHER </c> then it may hold abstract types that are particular to the connected database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object holding the value of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified parameter as an <c>Object </c> . The  <c>Map </c> gives the correspondence between SQL types and Java classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object holding the value of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(ILjava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(ILjava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetObject(int parameterIndex, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified parameter as a Java <c>Object </c> . </para> <para>The object type returned is the JDBC type registered for the parameter with a <c>registerOutParameter </c> call. If a parameter was registered as a <c>java.sql.Types.OTHER </c> then it may hold abstract types that are particular to the connected database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object holding the value of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetObject(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of the specified parameter as an <c>Object </c> . The  <c>Map </c> gives the correspondence between SQL types and Java classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object holding the value of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/" +
    "lang/Object;")]
				object GetObject(string parameterIndex, global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified SQL <c>REF(&lt;structured type&gt;) </c> parameter as a <c>java.sql.Ref </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Ref </c> with the parameter value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(I)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified SQL <c>REF(&lt;structured type&gt;) </c> parameter as a <c>java.sql.Ref </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>java.sql.Ref </c> with the parameter value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getRef
				/// </java-name>
				[Dot42.DexImport("getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef GetRef(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>SMALLINT </c> parameter as a  <c>short </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>short </c> . 0 is returned if the parameter's value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				short GetShort(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>SMALLINT </c> parameter as a  <c>short </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>short </c> . 0 is returned if the parameter's value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;)S", AccessFlags = 1025)]
				short GetShort(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's value as a <c>String </c> . The parameter value must be one of the JDBC types <c>CHAR </c> ,  <c>VARCHAR </c> or <c>LONGVARCHAR </c> . </para> <para>The <c>String </c> corresponding to a <c>CHAR </c> of fixed length will be of identical length to the value in the database inclusive of padding characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>String </c> . <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's value as a <c>String </c> . The parameter value must be one of the JDBC types <c>CHAR </c> ,  <c>VARCHAR </c> or <c>LONGVARCHAR </c> . </para> <para>The <c>String </c> corresponding to a <c>CHAR </c> of fixed length will be of identical length to the value in the database inclusive of padding characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>String </c> . <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TIME </c> parameter as a <c>java.sql.Time </c> .</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Time </c> .  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(I)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TIME </c> parameter as a <c>java.sql.Time </c> , using the supplied <c>Calendar </c> to construct the time. The JDBC driver uses the calendar to handle specific timezones and locales in order to determine <c>Time </c> .</para> <para> <para>Time </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Time </c> .  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(int parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TIME </c> parameter as a <c>java.sql.Time </c> .</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Time </c> .  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>TIME </c> parameter as a <c>java.sql.Time </c> , using the supplied <c>Calendar </c> to construct the time. The JDBC driver uses the calendar to handle specific timezones and locales in order to determine <c>Time </c> .</para> <para> <para>Time </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Time </c> .  <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time GetTime(string parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's <c>TIMESTAMP </c> value as a <c>java.sql.Timestamp </c> .</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Timestamp </c> . A  <c>null </c> reference is returned for an SQL value of <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(I)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's <c>TIMESTAMP </c> value as a <c>java.sql.Timestamp </c> . The JDBC driver uses the supplied <c>Calendar </c> to handle specific timezones and locales when creating the result.</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Timestamp </c> . A  <c>null </c> reference is returned for an SQL value of <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(int parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's <c>TIMESTAMP </c> value as a <c>java.sql.Timestamp </c> .</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Timestamp </c> . A  <c>null </c> reference is returned for an SQL value of <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed parameter's <c>TIMESTAMP </c> value as a <c>java.sql.Timestamp </c> . The JDBC driver uses the supplied <c>Calendar </c> to handle specific timezones and locales when creating the result.</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's value as a <c>java.sql.Timestamp </c> . A  <c>null </c> reference is returned for an SQL value of <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp GetTimestamp(string parameterIndex, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>DATALINK </c> parameter as a  <c>java.net.URL </c> .</para> <para> <para>java.net.URL </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>URL </c> giving the parameter's value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(I)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified JDBC <c>DATALINK </c> parameter as a  <c>java.net.URL </c> .</para> <para> <para>java.net.URL </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>URL </c> giving the parameter's value. <c>null </c> is returned if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// getURL
				/// </java-name>
				[Dot42.DexImport("getURL", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL GetURL(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> . If a database specific type is expected for a parameter, the Type <c>java.sql.Types.OTHER </c> should be used. Note that there is another variant of this method for User Defined Types or a <c>REF </c> type.</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(II)V", AccessFlags = 1025)]
				void RegisterOutParameter(int parameterIndex, int sqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the Type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. This version of the <c>registerOutParameter </c> method, which has a scale parameter, should be used for the JDBC types <c>NUMERIC </c> and <c>DECIMAL </c> , where there is a need to specify the number of digits expected after the decimal point. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> .</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(III)V", AccessFlags = 1025)]
				void RegisterOutParameter(int parameterIndex, int sqlType, int scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the Type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. This version of the <c>registerOutParameter </c> method, which has a scale parameter, should be used for the JDBC types <c>NUMERIC </c> and <c>DECIMAL </c> , where there is a need to specify the number of digits expected after the decimal point. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> .</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void RegisterOutParameter(int parameterIndex, int sqlType, string scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> . If a database specific type is expected for a parameter, the Type <c>java.sql.Types.OTHER </c> should be used. Note that there is another variant of this method for User Defined Types or a <c>REF </c> type.</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void RegisterOutParameter(string parameterIndex, int sqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the Type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. This version of the <c>registerOutParameter </c> method, which has a scale parameter, should be used for the JDBC types <c>NUMERIC </c> and <c>DECIMAL </c> , where there is a need to specify the number of digits expected after the decimal point. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> .</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;II)V", AccessFlags = 1025)]
				void RegisterOutParameter(string parameterIndex, int sqlType, int scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Defines the Type of a specified <c>OUT </c> parameter. All <c>OUT </c> parameters must have their type defined before a stored procedure is executed. This version of the <c>registerOutParameter </c> method, which has a scale parameter, should be used for the JDBC types <c>NUMERIC </c> and <c>DECIMAL </c> , where there is a need to specify the number of digits expected after the decimal point. </para> <para>The type supplied in the <c>sqlType </c> parameter fixes the type that will be returned by the getter methods of  <c>CallableStatement </c> .</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOutParameter
				/// </java-name>
				[Dot42.DexImport("registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void RegisterOutParameter(string parameterIndex, int sqlType, string scale) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(string @string, global::Java.IO.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.math.BigDecimal </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(string parameterName, global::Java.Math.BigDecimal theBigDecimal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.IO.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>boolean </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetBoolean(string parameterName, bool theBoolean) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>byte </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
				void SetByte(string parameterName, byte theByte) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied array of bytes. The array is mapped to <c>VARBINARY </c> or else <c>LONGVARBINARY </c> in the connected database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				void SetBytes(string parameterName, byte[] theBytes) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.IO.Reader reader, int int32) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Date </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(string parameterName, global::Java.Sql.Date theDate) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Date </c> value, using a supplied calendar to map the date. The calendar allows the application to control the timezone used to compute the SQL <c>DATE </c> in the database. In case that no calendar is supplied, the driver uses the default timezone of the Java virtual machine.</para> <para> <para>java.util.Calendar </para> <para>Date </para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(string parameterName, global::Java.Sql.Date theDate, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>double </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
				void SetDouble(string parameterName, double theDouble) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to to a supplied <c>float </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
				void SetFloat(string parameterName, float theFloat) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>int </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetInt(string parameterName, int theInt) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>long </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void SetLong(string parameterName, long theLong) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to SQL <c>NULL </c> . Don't use this version of <c>setNull </c> for  <b>User Defined Types</b> (UDT) or for <c>REF </c> type parameters.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				void SetNull(string parameterName, int sqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to be SQL <c>NULL </c> where the parameter type is either <c>REF </c> or user defined (e.g. <c>STRUCT </c> , <c>JAVA_OBJECT </c> etc). </para> <para>For reasons of portability, the caller is expected to supply both the SQL type code and type name (which is just the parameter name if the type is user defined, referred to as a <c>UDT </c> , or the name of the referenced type in case of a <c>REF </c> type).</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNull(string parameterName, int sqlType, string typeName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. Prior to issuing this request to the connected database <c>theObject </c> is transformed to the corresponding SQL type according to the standard Java to SQL mapping rules. </para> <para>If the object's class implements the interface <c>SQLData </c> , the JDBC driver calls <c>SQLData.writeSQL </c> to write it to the SQL data stream. If <c>theObject </c> implements any of the following interfaces then the driver is in charge of mapping the value to the appropriate SQL type.  <ul> <li> <para>Ref </para></li> <li> <para>Struct </para></li> <li> <para>Array </para></li> <li> <para>Clob </para></li> <li> <para>Blob </para></li></ul></para> <para> <para>SQLData </para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetObject(string parameterName, object theObject) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. </para> <para>The parameter <c>theObject </c> is converted to the given <c>targetSqlType </c> before it is sent to the database. If the object has a custom mapping (its class implements the interface <c>SQLData </c> ), the JDBC driver calls the method <c>SQLData.writeSQL </c> to write it to the SQL data stream. If <c>theObject </c> is an instance of one of the following types  <ul> <li> <para>Ref </para></li> <li> <para>Struct </para></li> <li> <para>Array </para></li> <li> <para>Clob </para></li> <li> <para>Blob </para></li></ul>then the driver is in charge of mapping the value to the appropriate SQL type and deliver it to the database.</para> <para> <para>SQLData </para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", AccessFlags = 1025)]
				void SetObject(string parameterName, object theObject, int targetSqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. </para> <para>The object is converted to the given <c>targetSqlType </c> before it is sent to the database. If the object has a custom mapping (its class implements the interface <c>SQLData </c> ), the JDBC driver calls the method <c>SQLData.writeSQL </c> to write it to the SQL data stream. If  <c>theObject </c> implements any of the following interfaces  <ul> <li> <para>Ref </para></li> <li> <para>Struct </para></li> <li> <para>Array </para></li> <li> <para>Clob </para></li> <li> <para>Blob </para></li></ul>then the driver is charge of mapping the value to the appropriate SQL type.</para> <para> <para>SQLData </para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void SetObject(string parameterName, object theObject, int targetSqlType, int scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>short </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(Ljava/lang/String;S)V", AccessFlags = 1025)]
				void SetShort(string parameterName, short theShort) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>String </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetString(string parameterName, string theString) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the parameter named <c>parameterName </c> to the value of the supplied <c>java.sql.Time </c> .</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(string parameterName, global::Java.Sql.Time theTime) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the parameter named <c>parameterName </c> to the value of the supplied <c>java.sql.Time </c> using the supplied calendar.</para> <para>The driver uses the supplied <c>Calendar </c> to create the SQL  <c>TIME </c> value, which allows it to use a custom timezone - otherwise the driver uses the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(string parameterName, global::Java.Sql.Time theTime, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Timestamp </c> value.</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(string parameterName, global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Timestamp </c> value, using the supplied calendar.</para> <para>The driver uses the supplied calendar to create the SQL <c>TIMESTAMP </c> value, which allows it to use a custom timezone - otherwise the driver uses the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Timestamp </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(string parameterName, global::Java.Sql.Timestamp theTimestamp, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the supplied <c>java.net.URL </c> .</para> <para> <para>java.net.URL </para></para>        
				/// </summary>
				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(Ljava/lang/String;Ljava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(string parameterName, global::Java.Net.URL theURL) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets whether the value of the last <c>OUT </c> parameter read was SQL  <c>NULL </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the last parameter was SQL <c>NULL </c> , <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// wasNull
				/// </java-name>
				[Dot42.DexImport("wasNull", "()Z", AccessFlags = 1025)]
				bool WasNull() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified <c>ROWID </c> parameter as a <c>java.sql.RowId </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(I)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of a specified <c>ROWID </c> parameter as a <c>java.sql.RowId </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getRowId
				/// </java-name>
				[Dot42.DexImport("getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId GetRowId(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the given <c>rowId </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(string parameterName, global::Java.Sql.IRowId rowId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the given <c>string </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(string parameterName, string @string) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the characters from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(string parameterName, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.Sql.INClob nClob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the next <c>length </c> characters from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(string parameterName, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the next <c>length </c> bytes from the given <c>inputStream </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(string parameterName, global::Java.IO.InputStream inputStream, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the next <c>length </c> characters from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(string parameterName, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCLOB parameter as a <c>java.sql.NClob </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(I)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCLOB parameter as a <c>java.sql.NClob </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNClob
				/// </java-name>
				[Dot42.DexImport("getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob GetNClob(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the given <c>sqlXml </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(string parameterName, global::Java.Sql.ISQLXML sqlXml) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL XML parameter as a <c>java.sql.SQLXML </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(I)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL XML parameter as a <c>java.sql.SQLXML </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getSQLXML
				/// </java-name>
				[Dot42.DexImport("getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML GetSQLXML(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCHAR, NVARCHAR, or LONGNVARCHAR parameter as a  <c>java.lang.String </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCHAR, NVARCHAR, or LONGNVARCHAR parameter as a  <c>java.lang.String </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNString
				/// </java-name>
				[Dot42.DexImport("getNString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNString(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCHAR, NVARCHAR, or LONGNVARCHAR parameter as a Reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetNCharacterStream(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified SQL NCHAR, NVARCHAR, or LONGNVARCHAR parameter as a Reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetNCharacterStream(string parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified parameter as a <c>java.io.Reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetCharacterStream(int parameterIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified parameter as a <c>java.io.Reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetCharacterStream(string parameterIndex) /* MethodBuilder.Create */ ;

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
				void SetAsciiStream(string @string, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the bytes from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(string parameterName, global::Java.IO.InputStream x) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBinaryStream(string @string, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the bytes from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(string parameterName, global::Java.IO.InputStream x) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void SetCharacterStream(string @string, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the characters from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(string parameterName, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the named parameter to the characters from the given <c>reader </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(string parameterName, global::Java.IO.Reader value) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(string @string, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A Java interface mapping for the SQL CLOB type. </para> <para>An SQL <c>CLOB </c> type stores a large array of characters as the value in a column of a database. </para> <para>The <c>java.sql.Clob </c> interface provides methods for setting and retrieving data in the <c>Clob </c> , for querying <c>Clob </c> data length, for searching for data within the <c>Clob </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Clob
		/// </java-name>
		[Dot42.DexImport("java/sql/Clob", AccessFlags = 1537)]
		public partial interface IClob
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Gets a copy of a specified substring in this <c>Clob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string containing the requested data. </para>
				/// </returns>
				/// <java-name>
				/// getSubString
				/// </java-name>
				[Dot42.DexImport("getSubString", "(JI)Ljava/lang/String;", AccessFlags = 1025)]
				string GetSubString(long pos, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves the number of characters in this <c>Clob </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a long value with the number of character in this <c>Clob </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Retrieves a stream which can be used to write Ascii characters to this  <c>Clob </c> object, starting at specified position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an OutputStream which can be used to write ASCII characters to this <c>Clob </c> . </para>
				/// </returns>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(J)Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.IO.OutputStream SetAsciiStream(long pos) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves a stream which can be used to write a stream of unicode characters to this <c>Clob </c> object, at a specified position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Writer which can be used to write unicode characters to this  <c>Clob </c> . </para>
				/// </returns>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(J)Ljava/io/Writer;", AccessFlags = 1025)]
				global::Java.IO.Writer SetCharacterStream(long pos) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes a given Java String to this <c>Clob </c> object at a specified position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters written. </para>
				/// </returns>
				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(JLjava/lang/String;)I", AccessFlags = 1025)]
				int SetString(long pos, string str) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes <c>len </c> characters of a string, starting at a specified character offset, to this <c>Clob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters written. </para>
				/// </returns>
				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(JLjava/lang/String;II)I", AccessFlags = 1025)]
				int SetString(long pos, string str, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Truncates this <c>Clob </c> after the specified number of characters.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// truncate
				/// </java-name>
				[Dot42.DexImport("truncate", "(J)V", AccessFlags = 1025)]
				void Truncate(long len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Frees any resources held by this clob. After <c>free </c> is called, calling method other than <c>free </c> will throw <c>SQLException </c> (calling <c>free </c> repeatedly will do nothing).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a Reader that reads <c>length </c> characters from this clob, starting at 1-based offset {code pos}. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(JJ)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetCharacterStream(long pos, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the value of this <c>Clob </c> object as an ASCII stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ASCII <c>InputStream </c> giving access to the  <c>Clob </c> data. </para>
				/// </returns>
				/// <java-name>
				/// getAsciiStream
				/// </java-name>
				global::Java.IO.InputStream AsciiStream
				{
						[Dot42.DexImport("getAsciiStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the data of this <c>Clob </c> object in a <c>java.io.Reader </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a character stream Reader object giving access to the <c>Clob </c> data. </para>
				/// </returns>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Reader CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A connection represents a link from a Java application to a database. All SQL statements and results are returned within the context of a connection. Database statements that are executed within this context form a database session which forms one or more closed transactions. Especially in distributed applications, multiple concurrent connections may exist accessing the same values of the database. which may lead to the following phenomena (referred to as  <b>transaction isolation levels</b>):  <ul> <li> <para> <b>dirty reads</b>: <br></br> reading values from table rows that are not committed. </para></li> <li> <para> <b>non-repeatable reads</b>: <br></br> reading table rows more than once in a transaction but getting back different data because other transactions have altered the rows between the reads. </para></li> <li> <para> <b>phantom reads</b>: <br></br> retrieving additional "phantom" rows in the course of repeated table reads because other transactions have inserted additional rows that satisfy an SQL <c>WHERE </c> clause </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Connection
		/// </java-name>
		[Dot42.DexImport("java/sql/Connection", AccessFlags = 1537)]
		public partial interface IConnection : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Discards all warnings that may have arisen for this connection. Subsequent calls to getWarnings() will return <c>null </c> up until a new warning condition occurs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearWarnings
				/// </java-name>
				[Dot42.DexImport("clearWarnings", "()V", AccessFlags = 1025)]
				void ClearWarnings() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Causes the instant release of all database and driver connection resources associated with this object. Any subsequent invocations of this method have no effect. </para> <para>It is strongly recommended that all connections are closed before they are dereferenced by the application ready for garbage collection. Although the <c>finalize </c> method of the connection closes the connection before garbage collection takes place, it is not advisable to leave the <c>close </c> operation to take place in this way. Mainly because undesired side-effects may appear.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Commits all of the changes made since the last <c>commit </c> or  <c>rollback </c> of the associated transaction. All locks in the database held by this connection are also relinquished. Calling this operation on connection objects in <c>auto-commit </c> mode leads to an error.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()V", AccessFlags = 1025)]
				void Commit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>Statement </c> for issuing SQL commands to the remote database. </para> <para> <c>ResultSets </c> generated by the returned statement will default to type <c>ResultSet.TYPE_FORWARD_ONLY </c> and concurrency level <c>ResultSet.CONCUR_READ_ONLY </c> .</para> <para> <para>ResultSet </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Statement </c> object with default settings. </para>
				/// </returns>
				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "()Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>Statement </c> whose associated <c>ResultSet </c> s have the characteristics specified in the type and concurrency arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>Statement </c> capable of manufacturing  <c>ResultSet </c> s that satisfy the specified <c>resultSetType </c> and <c>resultSetConcurrency </c> values. </para>
				/// </returns>
				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "(II)Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement(int resultSetType, int resultSetConcurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>Statement </c> whose associated  <c>ResultSet </c> s will have the characteristics specified in the type, concurrency and holdability arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>Statement </c> capable of manufacturing <c>ResultSet </c> s that satisfy the specified <c>resultSetType </c> ,  <c>resultSetConcurrency </c> and  <c>resultSetHoldability </c> values. </para>
				/// </returns>
				/// <java-name>
				/// createStatement
				/// </java-name>
				[Dot42.DexImport("createStatement", "(III)Ljava/sql/Statement;", AccessFlags = 1025)]
				global::Java.Sql.IStatement CreateStatement(int resultSetType, int resultSetConcurrency, int resultSetHoldability) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string representation of the input SQL statement  <c>sql </c> expressed in the underlying system's native SQL syntax.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SQL statement in native database format. </para>
				/// </returns>
				/// <java-name>
				/// nativeSQL
				/// </java-name>
				[Dot42.DexImport("nativeSQL", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string NativeSQL(string sql) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>CallableStatement </c> that may be used for making stored procedure calls to the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>CallableStatement </c> representing the SQL statement. <c>ResultSet </c> s emitted from this <c>CallableStatement </c> will default to type ResultSet#TYPE_FORWARD_ONLY and concurrency ResultSet#CONCUR_READ_ONLY. </para>
				/// </returns>
				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string sql) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>CallableStatement </c> that may be used for making stored procedure calls to the database. <c>ResultSet </c> s emitted from this <c>CallableStatement </c> will satisfy the specified <c>resultSetType </c> and <c>resultSetConcurrency </c> values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>CallableStatement </c> representing the precompiled SQL statement. <c>ResultSet </c> s emitted from this  <c>CallableStatement </c> will satisfy the specified <c>resultSetType </c> and <c>resultSetConcurrency </c> values. </para>
				/// </returns>
				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;II)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string sql, int resultSetType, int resultSetConcurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>CallableStatement </c> that may be used for making stored procedure calls to the database. <c>ResultSet </c> s created from this <c>CallableStatement </c> will have characteristics determined by the specified type, concurrency and holdability arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>CallableStatement </c> representing the precompiled SQL statement. <c>ResultSet </c> s emitted from this  <c>CallableStatement </c> will satisfy the specified <c>resultSetType </c> , <c>resultSetConcurrency </c> and <c>resultSetHoldability </c> values. </para>
				/// </returns>
				/// <java-name>
				/// prepareCall
				/// </java-name>
				[Dot42.DexImport("prepareCall", "(Ljava/lang/String;III)Ljava/sql/CallableStatement;", AccessFlags = 1025)]
				global::Java.Sql.ICallableStatement PrepareCall(string sql, int resultSetType, int resultSetConcurrency, int resultSetHoldability) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new instance of <c>PreparedStatement </c> that may be used any number of times to execute parameterized requests on the database server. </para> <para>Subject to JDBC driver support, this operation will attempt to send the precompiled version of the statement to the database. If the driver does not support precompiled statements, the statement will not reach the database server until it is executed. This distinction determines the moment when <c>SQLException </c> s get raised. </para> <para>By default, <c>ResultSet </c> s from the returned object will be ResultSet#TYPE_FORWARD_ONLY type with a ResultSet#CONCUR_READ_ONLY mode of concurrency.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>PreparedStatement </c> containing the supplied SQL statement. </para>
				/// </returns>
				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string sql) /* MethodBuilder.Create */ ;

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

				/// <summary>
				///  <para>Creates a <c>PreparedStatement </c> that generates <c>ResultSet </c> s with the specified values of <c>resultSetType </c> and <c>resultSetConcurrency </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>PreparedStatement </c> containing the SQL statement <c>sql </c> . <c>ResultSet </c> s emitted from this  <c>PreparedStatement </c> will satisfy the specified <c>resultSetType </c> and <c>resultSetConcurrency </c> values. </para>
				/// </returns>
				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;II)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string sql, int resultSetType, int resultSetConcurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a <c>PreparedStatement </c> that generates <c>ResultSet </c> s with the specified type, concurrency and holdability</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>PreparedStatement </c> containing the SQL statement <c>sql </c> . <c>ResultSet </c> s emitted from this  <c>PreparedStatement </c> will satisfy the specified <c>resultSetType </c> , <c>resultSetConcurrency </c> and <c>resultSetHoldability </c> values. </para>
				/// </returns>
				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;III)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string sql, int resultSetType, int resultSetConcurrency, int resultSetHoldability) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// prepareStatement
				/// </java-name>
				[Dot42.DexImport("prepareStatement", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/PreparedStatement;", AccessFlags = 1025)]
				global::Java.Sql.IPreparedStatement PrepareStatement(string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Releases the specified <c>savepoint </c> from the present transaction. Once removed, the <c>Savepoint </c> is considered invalid and should not be referenced further.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// releaseSavepoint
				/// </java-name>
				[Dot42.DexImport("releaseSavepoint", "(Ljava/sql/Savepoint;)V", AccessFlags = 1025)]
				void ReleaseSavepoint(global::Java.Sql.ISavepoint savepoint) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Rolls back all updates made so far in this transaction and relinquishes all acquired database locks. It is an error to invoke this operation when in auto-commit mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rollback
				/// </java-name>
				[Dot42.DexImport("rollback", "()V", AccessFlags = 1025)]
				void Rollback() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Undoes all changes made after the supplied <c>Savepoint </c> object was set. This method should only be used when auto-commit mode is disabled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rollback
				/// </java-name>
				[Dot42.DexImport("rollback", "(Ljava/sql/Savepoint;)V", AccessFlags = 1025)]
				void Rollback(global::Java.Sql.ISavepoint savepoint) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an unnamed <c>Savepoint </c> in the current transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Savepoint </c> object for this savepoint. </para>
				/// </returns>
				/// <java-name>
				/// setSavepoint
				/// </java-name>
				[Dot42.DexImport("setSavepoint", "()Ljava/sql/Savepoint;", AccessFlags = 1025)]
				global::Java.Sql.ISavepoint SetSavepoint() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a named <c>Savepoint </c> in the current transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Savepoint </c> object for this savepoint. </para>
				/// </returns>
				/// <java-name>
				/// setSavepoint
				/// </java-name>
				[Dot42.DexImport("setSavepoint", "(Ljava/lang/String;)Ljava/sql/Savepoint;", AccessFlags = 1025)]
				global::Java.Sql.ISavepoint SetSavepoint(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new empty Clob. </para>        
				/// </summary>
				/// <java-name>
				/// createClob
				/// </java-name>
				[Dot42.DexImport("createClob", "()Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob CreateClob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new empty Blob. </para>        
				/// </summary>
				/// <java-name>
				/// createBlob
				/// </java-name>
				[Dot42.DexImport("createBlob", "()Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob CreateBlob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new empty NClob. </para>        
				/// </summary>
				/// <java-name>
				/// createNClob
				/// </java-name>
				[Dot42.DexImport("createNClob", "()Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob CreateNClob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new empty SQLXML. </para>        
				/// </summary>
				/// <java-name>
				/// createSQLXML
				/// </java-name>
				[Dot42.DexImport("createSQLXML", "()Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML CreateSQLXML() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if this connection is still open and valid, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "(I)Z", AccessFlags = 1025)]
				bool IsValid(int timeout) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the client info property <c>name </c> to <c>value </c> . A value of null clears the client info property. </para>        
				/// </summary>
				/// <java-name>
				/// setClientInfo
				/// </java-name>
				[Dot42.DexImport("setClientInfo", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetClientInfo(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value corresponding to the given client info property, or null if unset. </para>        
				/// </summary>
				/// <java-name>
				/// getClientInfo
				/// </java-name>
				[Dot42.DexImport("getClientInfo", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetClientInfo(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new Array containing the given <c>elements </c> . </para>        
				/// </summary>
				/// <java-name>
				/// createArrayOf
				/// </java-name>
				[Dot42.DexImport("createArrayOf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray CreateArrayOf(string typeName, object[] elements) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a new Struct containing the given <c>attributes </c> . </para>        
				/// </summary>
				/// <java-name>
				/// createStruct
				/// </java-name>
				[Dot42.DexImport("createStruct", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Struct;", AccessFlags = 1025)]
				global::Java.Sql.IStruct CreateStruct(string typeName, object[] attributes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>boolean </c> indicating whether or not this connection is in the <c>auto-commit </c> operating mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>auto-commit </c> is on, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAutoCommit
				/// </java-name>
				bool AutoCommit
				{
						[Dot42.DexImport("getAutoCommit", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setAutoCommit", "(Z)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Gets this <c>Connection </c> object's current catalog name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the catalog name. <c>null </c> if there is no catalog name. </para>
				/// </returns>
				/// <java-name>
				/// getCatalog
				/// </java-name>
				string Catalog
				{
						[Dot42.DexImport("getCatalog", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCatalog", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Returns the holdability property that any <c>ResultSet </c> produced by this instance will have.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>one of the following holdability mode specifiers:  <ul> <li> <para>ResultSet#HOLD_CURSORS_OVER_COMMIT </para></li> <li> <para>ResultSet#CLOSE_CURSORS_AT_COMMIT </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getHoldability
				/// </java-name>
				int Holdability
				{
						[Dot42.DexImport("getHoldability", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setHoldability", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Gets the metadata about the database referenced by this connection. The returned <c>DatabaseMetaData </c> describes the database topography, available stored procedures, SQL syntax and so on.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>DatabaseMetaData </c> object containing the database description. </para>
				/// </returns>
				/// <java-name>
				/// getMetaData
				/// </java-name>
				global::Java.Sql.IDatabaseMetaData MetaData
				{
						[Dot42.DexImport("getMetaData", "()Ljava/sql/DatabaseMetaData;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the transaction isolation level for this connection.</para> <para> <para>TRANSACTION_NONE </para> <para>TRANSACTION_READ_COMMITTED </para> <para>TRANSACTION_READ_UNCOMMITTED </para> <para>TRANSACTION_REPEATABLE_READ </para> <para>TRANSACTION_SERIALIZABLE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the transaction isolation value. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the type mapping associated with this <c>Connection </c> object. The type mapping must be set on the application level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Type Map as a <c>java.util.Map </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the first instance of any <c>SQLWarning </c> objects that may have been created in the use of this connection. If at least one warning has occurred then this operation returns the first one reported. A <c>null </c> indicates that no warnings have occurred. </para> <para>By invoking the SQLWarning#getNextWarning() method of the returned <c>SQLWarning </c> object it is possible to obtain all of this connection's warning objects.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the first warning as an SQLWarning object (may be <c>null </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getWarnings
				/// </java-name>
				global::Java.Sql.SQLWarning Warnings
				{
						[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a <c>boolean </c> indicating whether or not this connection is in the <c>closed </c> state. The <c>closed </c> state may be entered into as a consequence of a successful invocation of the close() method or else if an error has occurred that prevents the connection from functioning normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if closed, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a <c>boolean </c> indicating whether or not this connection is currently in the <c>read-only </c> state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if in read-only state, otherwise <c>false </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns a Properties object containing all client info properties. </para>        
				/// </summary>
				/// <java-name>
				/// getClientInfo
				/// </java-name>
				global::Java.Util.Properties ClientInfo
				{
						[Dot42.DexImport("getClientInfo", "()Ljava/util/Properties;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setClientInfo", "(Ljava/util/Properties;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>A connection represents a link from a Java application to a database. All SQL statements and results are returned within the context of a connection. Database statements that are executed within this context form a database session which forms one or more closed transactions. Especially in distributed applications, multiple concurrent connections may exist accessing the same values of the database. which may lead to the following phenomena (referred to as  <b>transaction isolation levels</b>):  <ul> <li> <para> <b>dirty reads</b>: <br></br> reading values from table rows that are not committed. </para></li> <li> <para> <b>non-repeatable reads</b>: <br></br> reading table rows more than once in a transaction but getting back different data because other transactions have altered the rows between the reads. </para></li> <li> <para> <b>phantom reads</b>: <br></br> retrieving additional "phantom" rows in the course of repeated table reads because other transactions have inserted additional rows that satisfy an SQL <c>WHERE </c> clause </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Connection
		/// </java-name>
		[Dot42.DexImport("java/sql/Connection", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IConnectionConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A constant indicating that transactions are not supported. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_NONE
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_NONE", "I", AccessFlags = 25)]
				public const int TRANSACTION_NONE = 0;
				/// <summary>
				///  <para>No  <b>dirty reads</b> are permitted, therefore transactions may not read a row containing uncommitted values - but does not prevent an application from  <b>non-repeatable reads</b> and  <b>phantom reads</b>. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_READ_COMMITTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_READ_COMMITTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_READ_COMMITTED = 2;
				/// <summary>
				///  <para>In the case that reading uncommitted values is allowed, the following incidents may happen which may lead to an invalid results:  <ul> <li> <para> <b>dirty reads</b> </para></li> <li> <para> <b>non-repeatable reads</b> </para></li> <li> <para> <b>phantom reads</b> </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_READ_UNCOMMITTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_READ_UNCOMMITTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_READ_UNCOMMITTED = 1;
				/// <summary>
				///  <para>A constant indicating that  <b>dirty reads</b> and  <b>non-repeatable reads</b> are  <b>prevented</b> but  <b>phantom reads</b> can occur. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_REPEATABLE_READ
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_REPEATABLE_READ", "I", AccessFlags = 25)]
				public const int TRANSACTION_REPEATABLE_READ = 4;
				/// <summary>
				///  <para>The constant that indicates that the following incidents are  <b>all prevented</b> (the opposite of TRANSACTION_READ_UNCOMMITTED):  <ul> <li> <para> <b>dirty reads</b> </para></li> <li> <para> <b>non-repeatable reads</b> </para></li> <li> <para> <b>phantom reads</b> </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_SERIALIZABLE
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_SERIALIZABLE", "I", AccessFlags = 25)]
				public const int TRANSACTION_SERIALIZABLE = 8;
		}

		/// <summary>
		///  <para>An interface which provides comprehensive information about the database management system and its supported features. </para> <para>This interface is implemented by JDBC driver vendors in order to provide information about the underlying database capabilities in association with the JDBC driver. </para> <para>Some of the methods in this interface take string parameters which are patterns. Within these string patterns, <c>'%' </c> and <c>'_' </c> characters have special meanings. <c>'%' </c> means "match any substring of 0 or more characters". <c>'_' </c> means "match any character". Only metadata entries that match the pattern are returned. If such a search pattern string is set to <c>null </c> , that argument's criteria are dropped from the search. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/DatabaseMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/DatabaseMetaData", AccessFlags = 1537)]
		public partial interface IDatabaseMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns whether all procedures returned by getProcedures can be called by the current user.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all procedures can be called by the current user,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// allProceduresAreCallable
				/// </java-name>
				[Dot42.DexImport("allProceduresAreCallable", "()Z", AccessFlags = 1025)]
				bool AllProceduresAreCallable() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether all the tables returned by <c>getTables </c> can be used by the current user in a <c>SELECT </c> statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all the tables can be used, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// allTablesAreSelectable
				/// </java-name>
				[Dot42.DexImport("allTablesAreSelectable", "()Z", AccessFlags = 1025)]
				bool AllTablesAreSelectable() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether a data definition statement in a transaction forces a <c>commit </c> of the transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the statement forces a commit, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dataDefinitionCausesTransactionCommit
				/// </java-name>
				[Dot42.DexImport("dataDefinitionCausesTransactionCommit", "()Z", AccessFlags = 1025)]
				bool DataDefinitionCausesTransactionCommit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether the database ignores data definition statements within a transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database ignores a data definition statement,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dataDefinitionIgnoredInTransactions
				/// </java-name>
				[Dot42.DexImport("dataDefinitionIgnoredInTransactions", "()Z", AccessFlags = 1025)]
				bool DataDefinitionIgnoredInTransactions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether a visible row delete can be detected by calling ResultSet#rowDeleted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the visible row delete can be detected, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// deletesAreDetected
				/// </java-name>
				[Dot42.DexImport("deletesAreDetected", "(I)Z", AccessFlags = 1025)]
				bool DeletesAreDetected(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether the return value of <c>getMaxRowSize </c> includes the SQL data types <c>LONGVARCHAR </c> and <c>LONGVARBINARY </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the return value includes <c>LONGVARBINARY </c> and <c>LONGVARCHAR </c> , otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// doesMaxRowSizeIncludeBlobs
				/// </java-name>
				[Dot42.DexImport("doesMaxRowSizeIncludeBlobs", "()Z", AccessFlags = 1025)]
				bool DoesMaxRowSizeIncludeBlobs() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>ResultSet </c> describing a subset of the attributes of a specified SQL User Defined Type (UDT) for a specified schema and catalog. The subset is determined by restricting to those attributes whose name matches the <c>attributeNamePattern </c> and whose type name matches the <c>typeNamePattern </c> . Each row of the <c>ResultSet </c> describes one attribute, and the rows are ordered by the columns <c>TYPE_SCHEM </c> ,  <c>TYPE_NAME </c> and <c>ORDINAL_POSITION </c> . Inherited attributes are not included. </para> <para>The columns of the returned <c>ResultSet </c> object have the following names and meanings:  <ol> <li> <para> <c>TYPE_CAT </c> - String - the type catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_SCHEM </c> - String - the type schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_NAME </c> - String - the type name </para></li> <li> <para> <c>ATTR_NAME </c> - String - the attribute name </para></li> <li> <para> <c>DATA_TYPE </c> - int - the attribute type as defined in <c>java.sql.Types </c>  </para></li> <li> <para> <c>ATTR_TYPE_NAME </c> - String - the attribute type name. This depends on the data source. For a <c>UDT </c> the name is fully qualified. For a <c>REF </c> it is both fully qualified and represents the target type of the reference. </para></li> <li> <para> <c>ATTR_SIZE </c> - int - the column size. When referring to char and date types this value is the maximum number of characters. When referring to numeric types is is the precision. </para></li> <li> <para> <c>DECIMAL_DIGITS </c> - int - how many fractional digits are supported </para></li> <li> <para> <c>NUM_PREC_RADIX </c> - int - numeric values radix </para></li> <li> <para> <c>NULLABLE </c> - int - whether <c>NULL </c> is permitted:  <ul> <li> <para>DatabaseMetaData.attributeNoNulls - <c>NULL </c> values not permitted </para></li> <li> <para>DatabaseMetaData.attributeNullable - <c>NULL </c> values definitely permitted </para></li> <li> <para>DatabaseMetaData.attributeNullableUnknown - unknown </para></li></ul></para></li> <li> <para> <c>REMARKS </c> - String - a comment describing the attribute (possibly <c>null </c> ) </para></li> <li> <para>ATTR_DEF - String - Default value for the attribute (possibly <c>null </c> ) </para></li> <li> <para> <c>SQL_DATA_TYPE </c> - int - not used </para></li> <li> <para>SQL_DATETIME_SUB - int - not used </para></li> <li> <para>CHAR_OCTET_LENGTH - int - for <c>CHAR </c> types, the max number of bytes in the column </para></li> <li> <para>ORDINAL_POSITION - int - The index of the column in the table (where the count starts from 1, not 0) </para></li> <li> <para>IS_NULLABLE - String - <c>"NO" </c> = the column does not allow <c>NULL </c> s, <c>"YES" </c> = the column allows <c>NULL </c> s, "" = status unknown </para></li> <li> <para> <c>SCOPE_CATALOG </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the catalog of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SCOPE_SCHEMA </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the schema of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SCOPE_TABLE </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the name of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SOURCE_DATA_TYPE </c> - String - The source type for a user generated REF type or for a Distinct type. ( <c>NULL </c> if <c>DATA_TYPE </c> is not DISTINCT or a user generated REF) </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> , where each row is an attribute description. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetAttributes(string catalog, string schemaPattern, string typeNamePattern, string attributeNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of a table's optimal set of columns that uniquely identify the rows. The results are ordered by <c>SCOPE </c> (see below). </para> <para>The results are returned as a table, with one entry for each column, as follows:  <ol> <li> <para> <c>SCOPE </c> - short - the <c>SCOPE </c> of the result, as follows:  <ul> <li> <para> <c>DatabaseMetaData.bestRowTemporary </c> - the result is very temporary, only valid while on the current row </para></li> <li> <para> <c>DatabaseMetaData.bestRowTransaction </c> - the result is good for remainder of current transaction </para></li> <li> <para> <c>DatabaseMetaData.bestRowSession </c> - the result is good for remainder of database session </para></li></ul></para></li> <li> <para> <c>COLUMN_NAME </c> - String - the column name </para></li> <li> <para> <c>DATA_TYPE </c> - int - the Type of the data, as defined in <c>java.sql.Types </c>  </para></li> <li> <para> <c>TYPE_NAME </c> - String - the Name of the type - database dependent. For UDT types the name is fully qualified </para></li> <li> <para> <c>COLUMN_SIZE </c> - int - the precision of the data in the column </para></li> <li> <para> <c>BUFFER_LENGTH </c> - int - not used </para></li> <li> <para> <c>DECIMAL_DIGITS </c> - short - number of fractional digits </para></li> <li> <para> <c>PSEUDO_COLUMN </c> - short - whether this is a pseudo column (e.g. an Oracle <c>ROWID </c> ):  <ul> <li> <para> <c>DatabaseMetaData.bestRowUnknown </c> - it is not known whether this is a pseudo column </para></li> <li> <para> <c>DatabaseMetaData.bestRowNotPseudo </c> - the column is not pseudo </para></li> <li> <para> <c>DatabaseMetaData.bestRowPseudo </c> - the column is a pseudo column </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> where each row is a description of a column and the complete set of rows is the optimal set for this table. </para>
				/// </returns>
				/// <java-name>
				/// getBestRowIdentifier
				/// </java-name>
				[Dot42.DexImport("getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetBestRowIdentifier(string catalog, string schema, string table, int scope, bool nullable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of access rights for a table's columns. Only access rights matching the criteria for the column name are returned. </para> <para>The description is returned as a <c>ResultSet </c> with rows of data for each access right, with columns as follows:  <ol> <li> <para> <c>TABLE_CAT </c> - String - the catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - the schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - the table name </para></li> <li> <para> <c>COLUMN_NAME </c> - String - the Column name </para></li> <li> <para> <c>GRANTOR </c> - String - the grantor of access (possibly <c>null </c> ) </para></li> <li> <para> <c>PRIVILEGE </c> - String - Access right - one of SELECT, INSERT, UPDATE, REFERENCES,... </para></li> <li> <para> <c>IS_GRANTABLE </c> - String - <c>"YES" </c> implies that the receiver can grant access to others, <c>"NO" </c> if the receiver cannot grant access to others, <c>null </c> if unknown. </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the access rights, one row for each privilege description. </para>
				/// </returns>
				/// <java-name>
				/// getColumnPrivileges
				/// </java-name>
				[Dot42.DexImport("getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetColumnPrivileges(string catalog, string schema, string table, string columnNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of table columns available in a specified catalog. Only descriptions meeting the specified catalog, schema, table, and column names are returned. </para> <para>The descriptions are returned as a <c>ResultSet </c> conforming to the following data layout, with one row per table column:  <ol> <li> <para> <c>TABLE_CAT </c> - String - the catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - the schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - the table name </para></li> <li> <para> <c>COLUMN_NAME </c> - String - the column name </para></li> <li> <para> <c>DATA_TYPE </c> - int - the SQL type as specified in <c>java.sql.Types </c>  </para></li> <li> <para> <c>TYPE_NAME </c> - String - the name of the data type, (database-dependent, UDT names are fully qualified) </para></li> <li> <para> <c>COLUMN_SIZE </c> - int - the column size (the precision for numeric types, max characters for <c>char </c> and <c>date </c> types) </para></li> <li> <para> <c>BUFFER_LENGTH </c> - int - Not used </para></li> <li> <para> <c>DECIMAL_DIGITS </c> - int - maximum number of fractional digits </para></li> <li> <para> <c>NUM_PREC_RADIX </c> - int - the radix for numerical types </para></li> <li> <para> <c>NULLABLE </c> - int - whether the column allows <c>null </c> s:  <ul> <li> <para>DatabaseMetaData.columnNoNulls = may not allow <c>NULL </c> s </para></li> <li> <para>DatabaseMetaData.columnNullable = does allow <c>NULL </c> s </para></li> <li> <para>DatabaseMetaData.columnNullableUnknown = unknown <c>NULL </c> status </para></li></ul></para></li> <li> <para> <c>REMARKS </c> - String - A description of the column (possibly  <c>null </c> ) </para></li> <li> <para> <c>COLUMN_DEF </c> - String - Default value for the column (possibly  <c>null </c> ) </para></li> <li> <para> <c>SQL_DATA_TYPE </c> - int - not used </para></li> <li> <para> <c>SQL_DATETIME_SUB </c> - int - not used </para></li> <li> <para> <c>CHAR_OCTET_LENGTH </c> - int - maximum number of bytes in the  <c>char </c> type columns </para></li> <li> <para> <c>ORDINAL_POSITION </c> - int - the column index in the table (1 based) </para></li> <li> <para> <c>IS_NULLABLE </c> - String - <c>"NO" </c> = column does not allow NULLs, <c>"YES" </c> = column allows NULLs, "" = <c>NULL </c> status unknown </para></li> <li> <para> <c>SCOPE_CATALOG </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the catalog of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SCOPE_SCHEMA </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the schema of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SCOPE_TABLE </c> - String - if the <c>DATA_TYPE </c> is <c>REF </c> , this gives the name of the table corresponding to the attribute's scope. NULL if the <c>DATA_TYPE </c> is not REF. </para></li> <li> <para> <c>SOURCE_DATA_TYPE </c> - String - The source type for a user generated REF type or for a Distinct type. ( <c>NULL </c> if <c>DATA_TYPE </c> is not DISTINCT or a user generated REF) </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the descriptions as a <c>ResultSet </c> with rows in the form defined above. </para>
				/// </returns>
				/// <java-name>
				/// getColumns
				/// </java-name>
				[Dot42.DexImport("getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetColumns(string catalog, string schemaPattern, string tableNamePattern, string columnNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of foreign key columns in a given foreign key table that reference the primary key columns of a supplied primary key table. This describes how one table imports the key of another table. It would be expected to return a single foreign key - primary key pair in most cases. </para> <para>The descriptions are returned as a <c>ResultSet </c> with one row for each foreign key, with the following layout:  <ol> <li> <para> <c>PKTABLE_CAT </c> - String - from the primary key table : Catalog (possibly <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_SCHEM </c> - String - from the primary key table : Schema (possibly <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_NAME </c> - String - from the primary key table : name </para></li> <li> <para> <c>PKCOLUMN_NAME </c> - String - from the primary key column : name </para></li> <li> <para> <c>FKTABLE_CAT </c> - String - from the foreign key table : the catalog name being exported (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_SCHEM </c> - String - from the foreign key table : the schema name being exported (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_NAME </c> - String - from the foreign key table : the name being exported </para></li> <li> <para> <c>FKCOLUMN_NAME </c> - String - from the foreign key column : the name being exported </para></li> <li> <para> <c>KEY_SEQ </c> - short - the sequence number (in the foreign key) </para></li> <li> <para> <c>UPDATE_RULE </c> - short - a value giving the rule for how to treat the corresponding foreign key when a primary key is updated:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow the primary key to be updated if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - change the imported key to match the updated primary key </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - set the imported key to  <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - set the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as <c>importedKeyNoAction </c>  </para></li></ul></para></li> <li> <para> <c>DELETE_RULE </c> - short - a value giving the rule for how to treat the foreign key when the corresponding primary key is deleted:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow the primary key to be deleted if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - delete those rows that import a deleted key </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - set the imported key to  <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - set the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as importedKeyNoAction </para></li></ul></para></li> <li> <para> <c>FK_NAME </c> - String - the foreign key name (possibly <c>null </c> ) </para></li> <li> <para> <c>PK_NAME </c> - String - the primary key name (possibly <c>null </c> ) </para></li> <li> <para> <c>DEFERRABILITY </c> - short - whether foreign key constraints can be deferred until commit (see the SQL92 specification for definitions):  <ul> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyDeferred </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyImmediate </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyNotDeferrable </c>  </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing rows with the descriptions of the foreign keys laid out according to the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getCrossReference
				/// </java-name>
				[Dot42.DexImport("getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetCrossReference(string primaryCatalog, string primarySchema, string primaryTable, string foreignCatalog, string foreignSchema, string foreignTable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of the foreign key columns that reference the primary key columns of a specified table (the foreign keys exported by a table). </para> <para>The list is returned as a <c>ResultSet </c> with a row for each of the foreign key columns, ordered by <c>FKTABLE_CAT </c> , <c>FKTABLE_SCHEM </c> , <c>FKTABLE_NAME </c> , and <c>KEY_SEQ </c> , with the format for each row being:  <ol> <li> <para> <c>PKTABLE_CAT </c> - String - from the primary key table : the catalog (possibly  <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_SCHEM </c> - String - from the primary key table : the schema (possibly  <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_NAME </c> - String - from the primary key table : the name </para></li> <li> <para> <c>PKCOLUMN_NAME </c> - String - from the primary key column : the name </para></li> <li> <para> <c>FKTABLE_CAT </c> - String - from the foreign key table : the catalog name being exported (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_SCHEM </c> - String - from the foreign key table : the schema name being exported (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_NAME </c> - String - from the foreign key table : the name being exported </para></li> <li> <para> <c>FKCOLUMN_NAME </c> - String - from the foreign key column : the name being exported </para></li> <li> <para> <c>KEY_SEQ </c> - short - the sequence number (in the foreign key) </para></li> <li> <para> <c>UPDATE_RULE </c> - short - a value giving the rule for how to treat the foreign key when the corresponding primary key is updated:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow the primary key to be updated if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - change the imported key to match the primary key update </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - set the imported key to  <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - set the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as importedKeyNoAction </para></li></ul></para></li> <li> <para> <c>DELETE_RULE </c> - short - how to treat the foreign key when the corresponding primary key is deleted:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow the primary key to be deleted if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - the deletion should also delete rows that import a deleted key </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - the deletion sets the imported key to <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - the deletion sets the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as importedKeyNoAction </para></li></ul></para></li> <li> <para> <c>FK_NAME </c> - String - the foreign key name (possibly <c>null </c> ) </para></li> <li> <para> <c>PK_NAME </c> - String - the primary key name (possibly <c>null </c> ) </para></li> <li> <para> <c>DEFERRABILITY </c> - short - defines whether the foreign key constraints can be deferred until commit (see the SQL92 specification for definitions):  <ul> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyDeferred </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyImmediate </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyNotDeferrable </c>  </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing a row for each of the foreign key columns, as defined above </para>
				/// </returns>
				/// <java-name>
				/// getExportedKeys
				/// </java-name>
				[Dot42.DexImport("getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetExportedKeys(string catalog, string schema, string table) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list columns in a table that are both primary keys and referenced by the table's foreign key columns (that is, the primary keys imported by a table). </para> <para>The list returned is a <c>ResultSet </c> with a row entry for each primary key column, ordered by <c>PKTABLE_CAT </c> , <c>PKTABLE_SCHEM </c> ,  <c>PKTABLE_NAME </c> , and <c>KEY_SEQ </c> , with the following format:  <ol> <li> <para> <c>PKTABLE_CAT </c> - String - primary key catalog name being imported (possibly <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_SCHEM </c> - String - primary key schema name being imported (possibly <c>null </c> ) </para></li> <li> <para> <c>PKTABLE_NAME </c> - String - primary key table name being imported  </para></li> <li> <para> <c>PKCOLUMN_NAME </c> - String - primary key column name being imported </para></li> <li> <para> <c>FKTABLE_CAT </c> - String - foreign key table catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_SCHEM </c> - String - foreign key table schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>FKTABLE_NAME </c> - String - foreign key table name </para></li> <li> <para> <c>FKCOLUMN_NAME </c> - String - foreign key column name </para></li> <li> <para> <c>KEY_SEQ </c> - short - sequence number (in the foreign key) </para></li> <li> <para> <c>UPDATE_RULE </c> - short - how to treat the foreign key when the corresponding primary key is updated:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow any update of the primary key if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - change imported key to match the primary key update </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - set the imported key to  <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - set the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as importedKeyNoAction </para></li></ul></para></li> <li> <para> <c>DELETE_RULE </c> - short - how to treat the foreign key when the corresponding primary key is deleted:  <ul> <li> <para> <c>DatabaseMetaData.importedKeyNoAction </c> - don't allow the primary key to be deleted if it is imported as a foreign key </para></li> <li> <para> <c>DatabaseMetaData.importedKeyCascade </c> - delete those rows that import a deleted key </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetNull </c> - set the imported key to  <c>null </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeySetDefault </c> - set the imported key to its default value </para></li> <li> <para> <c>DatabaseMetaData.importedKeyRestrict </c> - same as <c>importedKeyNoAction </c>  </para></li></ul></para></li> <li> <para> <c>FK_NAME </c> - String - foreign key name (possibly <c>null </c> ) </para></li> <li> <para> <c>PK_NAME </c> - String - primary key name (possibly <c>null </c> ) </para></li> <li> <para> <c>DEFERRABILITY </c> - short - defines whether foreign key constraints can be deferred until commit (see SQL92 specification for definitions):  <ul> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyDeferred </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyInitiallyImmediate </c>  </para></li> <li> <para> <c>DatabaseMetaData.importedKeyNotDeferrable </c>  </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the list of primary key columns as rows in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getImportedKeys
				/// </java-name>
				[Dot42.DexImport("getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetImportedKeys(string catalog, string schema, string table) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of indices and statistics for a specified table. </para> <para>The list is returned as a <c>ResultSet </c> , with one row for each index or statistic. The list is ordered by <c>NON_UNIQUE </c> , <c>TYPE </c> ,  <c>INDEX_NAME </c> , and <c>ORDINAL_POSITION </c> . Each row has the following format:  <ol> <li> <para> <c>TABLE_CAT </c> - String - table catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - table schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para> <c>NON_UNIQUE </c> - boolean - <c>true </c> when index values can be non-unique. Must be <c>false </c> when the TYPE is tableIndexStatistic </para></li> <li> <para> <c>INDEX_QUALIFIER </c> - String : index catalog name. <c>null </c> when the TYPE is 'tableIndexStatistic' </para></li> <li> <para> <c>INDEX_NAME </c> - String : index name. <c>null </c> when TYPE is 'tableIndexStatistic' </para></li> <li> <para> <c>TYPE </c> - short - the index type. One of:  <ul> <li> <para> <c>DatabaseMetaData.tableIndexStatistic </c> - table statistics returned with Index descriptions </para></li> <li> <para> <c>DatabaseMetaData.tableIndexClustered </c> - a clustered Index </para></li> <li> <para> <c>DatabaseMetaData.tableIndexHashed </c> - a hashed Index </para></li> <li> <para> <c>DatabaseMetaData.tableIndexOther </c> - other style of Index </para></li></ul></para></li> <li> <para> <c>ORDINAL_POSITION </c> - short - column sequence within Index. 0 when TYPE is tableIndexStatistic </para></li> <li> <para> <c>COLUMN_NAME </c> - String - the column name. <c>null </c> when TYPE is tableIndexStatistic </para></li> <li> <para> <c>ASC_OR_DESC </c> - String - column sort sequence. <c>null </c> if sequencing not supported or TYPE is tableIndexStatistic; otherwise "A" means sort ascending and "D" means sort descending. </para></li> <li> <para> <c>CARDINALITY </c> - int - Number of unique values in the Index. If TYPE is tableIndexStatistic, this is number of rows in the table. </para></li> <li> <para> <c>PAGES </c> - int - Number of pages for current Index. If TYPE is tableIndexStatistic, this is number of pages used for the table. </para></li> <li> <para> <c>FILTER_CONDITION </c> - String - Filter condition. (possibly null)  </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the list of indices and statistics for the table, in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getIndexInfo
				/// </java-name>
				[Dot42.DexImport("getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetIndexInfo(string catalog, string schema, string table, bool unique, bool approximate) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of the primary key columns of a specified table. </para> <para>The list is returned as a <c>ResultSet </c> with one row for each primary key column, ordered by <c>COLUMN_NAME </c> , with each row having the structure as follows:  <ol> <li> <para> <c>TABLE_CAT </c> - String - table catalog name (possibly null) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - table schema name (possibly null) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para> <c>COLUMN_NAME </c> - String - The column name </para></li> <li> <para> <c>KEY_SEQ </c> - short - the sequence number for this column in the primary key </para></li> <li> <para> <c>PK_NAME </c> - String - the primary key name (possibly null) </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the list of keys in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getPrimaryKeys
				/// </java-name>
				[Dot42.DexImport("getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetPrimaryKeys(string catalog, string schema, string table) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of parameter and result columns for the stored procedures belonging to a specified catalog. </para> <para>The list is returned as a <c>ResultSet </c> with one row for each parameter or result column. The data is ordered by <c>PROCEDURE_SCHEM </c> and <c>PROCEDURE_NAME </c> , while for each procedure, the return value (if any) is first, followed by the parameters in the order they appear in the stored procedure call, followed by <c>ResultSet </c> columns in column number order. Each row has the following structure:  <ol> <li> <para> <c>PROCEDURE_CAT </c> - String - the procedure catalog name </para></li> <li> <para> <c>PROCEDURE_SCHEM </c> - String - the procedure schema name (possibly null) </para></li> <li> <para> <c>PROCEDURE_NAME </c> - String - the procedure name </para></li> <li> <para> <c>COLUMN_NAME </c> - String - the name of the column </para></li> <li> <para> <c>COLUMN_TYPE </c> - short - the kind of column or parameter, as follows:  <ul> <li> <para> <c>DatabaseMetaData.procedureColumnUnknown </c> - type unknown </para></li> <li> <para> <c>DatabaseMetaData.procedureColumnIn </c> - an <c>IN </c> parameter </para></li> <li> <para> <c>DatabaseMetaData.procedureColumnInOut </c> - an <c>INOUT </c> parameter </para></li> <li> <para> <c>DatabaseMetaData.procedureColumnOut </c> - an <c>OUT </c> parameter </para></li> <li> <para> <c>DatabaseMetaData.procedureColumnReturn </c> - a return value </para></li> <li> <para> <c>DatabaseMetaData.procedureReturnsResult </c> - a result column in a result set </para></li></ul></para></li> <li> <para> <c>DATA_TYPE </c> - int - the SQL type of the data, as in <c>java.sql.Types </c>  </para></li> <li> <para> <c>TYPE_NAME </c> - String - the SQL type name, for a UDT it is fully qualified </para></li> <li> <para> <c>PRECISION </c> - int - the precision </para></li> <li> <para> <c>LENGTH </c> - int - the length of the data in bytes </para></li> <li> <para> <c>SCALE </c> - short - the scale for numeric types </para></li> <li> <para> <c>RADIX </c> - short - the Radix for numeric data (typically 2 or 10) </para></li> <li> <para> <c>NULLABLE </c> - short - can the data contain <c>null </c> :  <ul> <li> <para> <c>DatabaseMetaData.procedureNoNulls </c> - <c>NULL </c> s not permitted </para></li> <li> <para> <c>DatabaseMetaData.procedureNullable </c> - <c>NULL </c> s are permitted </para></li> <li> <para> <c>DatabaseMetaData.procedureNullableUnknown </c> - <c>NULL </c> status unknown </para></li></ul></para></li> <li> <para> <c>REMARKS </c> - String - an explanatory comment about the data item  </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> with the list of parameter and result columns in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getProcedureColumns
				/// </java-name>
				[Dot42.DexImport("getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetProcedureColumns(string catalog, string schemaPattern, string procedureNamePattern, string columnNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a list of the stored procedures available in a specified catalog. </para> <para>The list is returned as a <c>ResultSet </c> with one row for each stored procedure, ordered by PROCEDURE_SCHEM and PROCEDURE_NAME, with the data in each row as follows:  <ol> <li> <para> <c>PROCEDURE_CAT </c> - String : the procedure catalog name </para></li> <li> <para> <c>PROCEDURE_SCHEM </c> - String : the procedure schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>PROCEDURE_NAME </c> - String : the procedure name </para></li> <li> <para> <c>Reserved </c>  </para></li> <li> <para> <c>Reserved </c>  </para></li> <li> <para> <c>Reserved </c>  </para></li> <li> <para> <c>REMARKS </c> - String - information about the procedure </para></li> <li> <para> <c>PROCEDURE_TYPE </c> - short : one of:  <ul> <li> <para> <c>DatabaseMetaData.procedureResultUnknown </c> - procedure may return a result </para></li> <li> <para> <c>DatabaseMetaData.procedureNoResult </c> - procedure does not return a result </para></li> <li> <para> <c>DatabaseMetaData.procedureReturnsResult </c> - procedure definitely returns a result </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> where each row is a description of a stored procedure in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getProcedures
				/// </java-name>
				[Dot42.DexImport("getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetProcedures(string catalog, string schemaPattern, string procedureNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a listing of the hierarchies of tables in a specified schema in the database. </para> <para>The listing only contains entries for tables that have a super table. Super tables and corresponding subtables must be defined in the same catalog and schema. The list is returned as a <c>ResultSet </c> , with one row for each table that has a super table, in the following format:  <ol> <li> <para> <c>TABLE_CAT </c> - String - table catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - Table schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para>SUPER <c>TABLE_NAME </c> - String - The super table name </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> with one row for each table which has a super table, in the format defined above. An empty <c>ResultSet </c> is returned if the database does not support table hierarchies. </para>
				/// </returns>
				/// <java-name>
				/// getSuperTables
				/// </java-name>
				[Dot42.DexImport("getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSuperTables(string catalog, string schemaPattern, string tableNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the User Defined Type (UDT) hierarchies for a given schema. Only the immediate parent/child relationship is described. If a UDT does not have a direct supertype, it is not listed. </para> <para>The listing is returned as a <c>ResultSet </c> where there is one row for a specific UDT which describes its supertype, with the data organized in columns as follows:  <ol> <li> <para> <c>TYPE_CAT </c> - String - the UDT catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_SCHEM </c> - String - the UDT schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_NAME </c> - String - the UDT type name </para></li> <li> <para>SUPER <c>TYPE_CAT </c> - String - direct supertype's catalog name (possibly <c>null </c> ) </para></li> <li> <para>SUPER <c>TYPE_SCHEM </c> - String - direct supertype's schema name (possibly <c>null </c> ) </para></li> <li> <para>SUPER <c>TYPE_NAME </c> - String - direct supertype's name </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> in which each row gives information about a particular UDT in the format defined above. An empty ResultSet is returned for a database that does not support type hierarchies. </para>
				/// </returns>
				/// <java-name>
				/// getSuperTypes
				/// </java-name>
				[Dot42.DexImport("getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSuperTypes(string catalog, string schemaPattern, string typeNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of access rights for each table present in a catalog. Table privileges can apply to one or more columns in the table - but are not guaranteed to apply to all columns. </para> <para>The privileges are returned as a <c>ResultSet </c> , with one row for each privilege, ordered by <c>TABLE_SCHEM </c> , <c>TABLE_NAME </c> , <c>PRIVILEGE </c> , and each row has data as defined in the following column definitions:  <ol> <li> <para> <c>TABLE_CAT </c> - String - table catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - Table schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para>GRANTOR - String - who granted the access </para></li> <li> <para>GRANTEE - String - who received the access grant </para></li> <li> <para>PRIVILEGE - String - the type of access granted - one of SELECT, INSERT, UPDATE, REFERENCES,... </para></li> <li> <para>IS_GRANTABLE - String - <c>"YES" </c> implies the grantee can grant access to others, <c>"NO" </c> implies guarantee cannot grant access to others, <c>null </c> means this status is unknown </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing a list with one row for each table in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getTablePrivileges
				/// </java-name>
				[Dot42.DexImport("getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTablePrivileges(string catalog, string schemaPattern, string tableNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of the tables in a specified catalog. </para> <para>The descriptions are returned as rows in a <c>ResultSet </c> , one row for each Table. The ResultSet is ordered by <c>TABLE_TYPE </c> , <c>TABLE_SCHEM </c> and <c>TABLE_NAME </c> . Each row in the ResultSet consists of a series of columns as follows:  <ol> <li> <para> <c>TABLE_CAT </c> - String - table catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - Table schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para> <c>TABLE_TYPE </c> - String - Typical names include "TABLE", "VIEW", "SYSTEM TABLE", "ALIAS", "SYNONYM", "GLOBAL TEMPORARY" </para></li> <li> <para> <c>REMARKS </c> - String - A comment describing the table </para></li> <li> <para> <c>TYPE_CAT </c> - String - the 'Types' catalog(possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_SCHEM </c> - String - the 'Types' schema(possibly <c>null </c> ) </para></li> <li> <para> <c>TYPE_NAME </c> - String - the 'Types' name (possibly <c>null </c> )  </para></li> <li> <para> <c>SELF_REFERENCING_COL_NAME </c> - String - the name of a designated identifier column in a typed table (possibly <c>null </c> ) </para></li> <li> <para>REF_GENERATION - String - one of the following values : "SYSTEM" | "USER" | "DERIVED" - specifies how values in the <c>SELF_REFERENCING_COL_NAME </c> are created (possibly <c>null </c> ) </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> with one row per table in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getTables
				/// </java-name>
				[Dot42.DexImport("getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/" +
    "sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetTables(string catalog, string schemaPattern, string tableNamePattern, string[] types) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of the User Defined Types (UDTs) defined in a given schema, which includes the types <c>DISTINCT </c> , <c>STRUCT </c> and  <c>JAVA_OBJECT </c> . </para> <para>The types matching the supplied the specified catalog, schema, type name and type are returned as rows in a <c>ResultSet </c> with columns of information as follows:  <ol> <li> <para> <c>TABLE_CAT </c> - String - catalog name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_SCHEM </c> - String - schema name (possibly <c>null </c> ) </para></li> <li> <para> <c>TABLE_NAME </c> - String - The table name </para></li> <li> <para> <c>CLASS_NAME </c> - String - The Java class name </para></li> <li> <para> <c>DATA_TYPE </c> - int - The SQL type as specified in <c>java.sql.Types </c> . One of DISTINCT, STRUCT, and JAVA_OBJECT </para></li> <li> <para> <c>REMARKS </c> - String - A comment which describes the type </para></li> <li> <para> <c>BASE_TYPE </c> - short - A type code. For a DISTINCT type, the source type. For a structured type this is the type that implements the user generated reference type of the <c>SELF_REFERENCING_COLUMN </c> . This is defined in <c>java.sql.Types </c> , and will be <c>null </c> if the <c>DATA_TYPE </c> does not match these criteria. </para></li></ol></para> <para>If the driver does not support UDTs, the <c>ResultSet </c> is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> in the format described above. </para>
				/// </returns>
				/// <java-name>
				/// getUDTs
				/// </java-name>
				[Dot42.DexImport("getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetUDTs(string catalog, string schemaPattern, string typeNamePattern, int[] types) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns which of a table's columns are automatically updated when any value in a row is updated. </para> <para>The result is laid-out in the following columns:  <ol> <li> <para> <c>SCOPE </c> - short - not used </para></li> <li> <para> <c>COLUMN_NAME </c> - String - Column name </para></li> <li> <para> <c>DATA_TYPE </c> - int - The SQL data type, as defined in <c>java.sql.Types </c>  </para></li> <li> <para> <c>TYPE_NAME </c> - String - The SQL type name, data source dependent  </para></li> <li> <para> <c>COLUMN_SIZE </c> - int - Precision for numeric types </para></li> <li> <para> <c>BUFFER_LENGTH </c> - int - Length of a column value in bytes </para></li> <li> <para> <c>DECIMAL_DIGITS </c> - short - Number of digits after the decimal point </para></li> <li> <para> <c>PSEUDO_COLUMN </c> - short - If this is a pseudo-column (for example, an Oracle <c>ROWID </c> ):  <ul> <li> <para> <c>DatabaseMetaData.bestRowUnknown </c> - don't know whether this is a pseudo column </para></li> <li> <para> <c>DatabaseMetaData.bestRowNotPseudo </c> - column is not pseudo </para></li> <li> <para> <c>DatabaseMetaData.bestRowPseudo </c> - column is a pseudo column </para></li></ul></para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the descriptions, one row for each column, in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getVersionColumns
				/// </java-name>
				[Dot42.DexImport("getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetVersionColumns(string catalog, string schema, string table) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a visible row insert can be detected by calling <c>ResultSet.rowInserted </c> .</para> <para> <para>ResultSet::rowInserted() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>ResultSet.rowInserted </c> detects a visible row insert otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// insertsAreDetected
				/// </java-name>
				[Dot42.DexImport("insertsAreDetected", "(I)Z", AccessFlags = 1025)]
				bool InsertsAreDetected(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether updates are made to a copy of, or directly on, Large Objects ( <c>LOB </c> s).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if updates are made to a copy of the Large Object,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// locatorsUpdateCopy
				/// </java-name>
				[Dot42.DexImport("locatorsUpdateCopy", "()Z", AccessFlags = 1025)]
				bool LocatorsUpdateCopy() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database handles concatenations between <c>NULL </c> and non- <c>NULL </c> values by producing a <c>NULL </c> output.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>NULL </c> to non- <c>NULL </c> concatenations produce a <c>NULL </c> result, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nullPlusNonNullIsNull
				/// </java-name>
				[Dot42.DexImport("nullPlusNonNullIsNull", "()Z", AccessFlags = 1025)]
				bool NullPlusNonNullIsNull() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether <c>NULL </c> values are always sorted to the end of sorted results regardless of requested sort order. This means that they will appear at the end of sorted lists whatever other non- <c>NULL </c> values may be present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>NULL </c> values are sorted at the end,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nullsAreSortedAtEnd
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedAtEnd", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedAtEnd() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether <c>NULL </c> values are always sorted at the start of the sorted list, irrespective of the sort order. This means that they appear at the start of sorted lists, whatever other values may be present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>NULL </c> values are sorted at the start,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nullsAreSortedAtStart
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedAtStart", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedAtStart() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether <c>NULL </c> values are sorted high - i.e. they are sorted as if they are higher than any other values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>NULL </c> values are sorted high, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nullsAreSortedHigh
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedHigh", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedHigh() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether <c>NULL </c> values are sorted low - i.e. they are sorted as if they are lower than any other values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>NULL </c> values are sorted low, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// nullsAreSortedLow
				/// </java-name>
				[Dot42.DexImport("nullsAreSortedLow", "()Z", AccessFlags = 1025)]
				bool NullsAreSortedLow() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether deletes made by others are visible, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if others' deletes are visible, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// othersDeletesAreVisible
				/// </java-name>
				[Dot42.DexImport("othersDeletesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersDeletesAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether inserts made by others are visible, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if others' inserts are visible, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// othersInsertsAreVisible
				/// </java-name>
				[Dot42.DexImport("othersInsertsAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersInsertsAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether updates made by others are visible, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if others' inserts are visible, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// othersUpdatesAreVisible
				/// </java-name>
				[Dot42.DexImport("othersUpdatesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OthersUpdatesAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a <c>ResultSet </c> can see its own deletes, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the deletes are seen by the <c>ResultSet </c> itself, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// ownDeletesAreVisible
				/// </java-name>
				[Dot42.DexImport("ownDeletesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnDeletesAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a <c>ResultSet </c> can see its own inserts, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the inserts are seen by the <c>ResultSet </c> itself, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// ownInsertsAreVisible
				/// </java-name>
				[Dot42.DexImport("ownInsertsAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnInsertsAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a <c>ResultSet </c> can see its own updates, for a specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the updates are seen by the <c>ResultSet </c> itself, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// ownUpdatesAreVisible
				/// </java-name>
				[Dot42.DexImport("ownUpdatesAreVisible", "(I)Z", AccessFlags = 1025)]
				bool OwnUpdatesAreVisible(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database treats SQL identifiers that are in mixed case (and unquoted) as case insensitive. If <c>true </c> then the database stores them in lower case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if unquoted SQL identifiers are stored in lower case, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesLowerCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesLowerCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresLowerCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers mixed case quoted SQL identifiers as case insensitive and stores them in lower case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if quoted SQL identifiers are stored in lower case,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesLowerCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesLowerCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresLowerCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers mixed case unquoted SQL identifiers as case insensitive and stores them in mixed case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if unquoted SQL identifiers as stored in mixed case,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesMixedCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesMixedCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresMixedCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers identifiers as case insensitive if they are mixed case quoted SQL. The database stores them in mixed case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if quoted SQL identifiers are stored in mixed case,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesMixedCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesMixedCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresMixedCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers mixed case unquoted SQL identifiers as case insensitive and stores them in upper case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if unquoted SQL identifiers are stored in upper case, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesUpperCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesUpperCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresUpperCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers mixed case quoted SQL identifiers as case insensitive and stores them in upper case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if quoted SQL identifiers are stored in upper case,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// storesUpperCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("storesUpperCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool StoresUpperCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports <c>ALTER TABLE </c> operation with  <c>ADD COLUMN </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>ALTER TABLE </c> with <c>ADD COLUMN </c> is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsAlterTableWithAddColumn
				/// </java-name>
				[Dot42.DexImport("supportsAlterTableWithAddColumn", "()Z", AccessFlags = 1025)]
				bool SupportsAlterTableWithAddColumn() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports <c>ALTER TABLE </c> operation with  <c>DROP COLUMN </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>ALTER TABLE </c> with <c>DROP COLUMN </c> is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsAlterTableWithDropColumn
				/// </java-name>
				[Dot42.DexImport("supportsAlterTableWithDropColumn", "()Z", AccessFlags = 1025)]
				bool SupportsAlterTableWithDropColumn() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports the ANSI92 entry level SQL grammar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the ANSI92 entry level SQL grammar is supported,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsANSI92EntryLevelSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92EntryLevelSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92EntryLevelSQL() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports the ANSI92 full SQL grammar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the ANSI92 full SQL grammar is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsANSI92FullSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92FullSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92FullSQL() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports the ANSI92 intermediate SQL Grammar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the ANSI92 intermediate SQL grammar is supported,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsANSI92IntermediateSQL
				/// </java-name>
				[Dot42.DexImport("supportsANSI92IntermediateSQL", "()Z", AccessFlags = 1025)]
				bool SupportsANSI92IntermediateSQL() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports batch updates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if batch updates are supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsBatchUpdates
				/// </java-name>
				[Dot42.DexImport("supportsBatchUpdates", "()Z", AccessFlags = 1025)]
				bool SupportsBatchUpdates() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether catalog names may be used in data manipulation statements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if catalog names can be used in data manipulation statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCatalogsInDataManipulation
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInDataManipulation", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInDataManipulation() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether catalog names can be used in index definition statements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if catalog names can be used in index definition statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCatalogsInIndexDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInIndexDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInIndexDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether catalog names can be used in privilege definition statements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if catalog names can be used in privilege definition statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCatalogsInPrivilegeDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInPrivilegeDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInPrivilegeDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether catalog names can be used in procedure call statements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if catalog names can be used in procedure call statements. </para>
				/// </returns>
				/// <java-name>
				/// supportsCatalogsInProcedureCalls
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInProcedureCalls", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInProcedureCalls() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether catalog names may be used in table definition statements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if catalog names can be used in definition statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCatalogsInTableDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsCatalogsInTableDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsCatalogsInTableDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports column aliasing. </para> <para>If aliasing is supported, then the SQL AS clause is used to provide names for computed columns and provide alias names for columns.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if column aliasing is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsColumnAliasing
				/// </java-name>
				[Dot42.DexImport("supportsColumnAliasing", "()Z", AccessFlags = 1025)]
				bool SupportsColumnAliasing() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports the <c>CONVERT </c> operation between SQL types.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>CONVERT </c> operation is supported,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsConvert
				/// </java-name>
				[Dot42.DexImport("supportsConvert", "()Z", AccessFlags = 1025)]
				bool SupportsConvert() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports <c>CONVERT </c> operation for two supplied SQL types.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>CONVERT </c> operation is supported for these types, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsConvert
				/// </java-name>
				[Dot42.DexImport("supportsConvert", "(II)Z", AccessFlags = 1025)]
				bool SupportsConvert(int fromType, int toType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports the Core SQL Grammar for ODBC.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the Core SQL Grammar is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCoreSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsCoreSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsCoreSQLGrammar() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports correlated sub-queries.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database does support correlated sub-queries and <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsCorrelatedSubqueries
				/// </java-name>
				[Dot42.DexImport("supportsCorrelatedSubqueries", "()Z", AccessFlags = 1025)]
				bool SupportsCorrelatedSubqueries() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database allows both data definition and data manipulation statements inside a transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if both types of statement are permitted, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsDataDefinitionAndDataManipulationTransactions
				/// </java-name>
				[Dot42.DexImport("supportsDataDefinitionAndDataManipulationTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsDataDefinitionAndDataManipulationTransactions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database only allows data manipulation statements inside a transaction.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if data manipulation statements are permitted only within a transaction,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsDataManipulationTransactionsOnly
				/// </java-name>
				[Dot42.DexImport("supportsDataManipulationTransactionsOnly", "()Z", AccessFlags = 1025)]
				bool SupportsDataManipulationTransactionsOnly() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether table correlation names are required to be different from the names of the tables, when they are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if correlation names must be different from table names, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsDifferentTableCorrelationNames
				/// </java-name>
				[Dot42.DexImport("supportsDifferentTableCorrelationNames", "()Z", AccessFlags = 1025)]
				bool SupportsDifferentTableCorrelationNames() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether expressions in <c>ORDER BY </c> lists are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if expressions in <c>ORDER BY </c> lists are supported. </para>
				/// </returns>
				/// <java-name>
				/// supportsExpressionsInOrderBy
				/// </java-name>
				[Dot42.DexImport("supportsExpressionsInOrderBy", "()Z", AccessFlags = 1025)]
				bool SupportsExpressionsInOrderBy() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the Extended SQL Grammar for ODBC is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the Extended SQL Grammar is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsExtendedSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsExtendedSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsExtendedSQLGrammar() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports full nested outer joins.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if full nested outer joins are supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsFullOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsFullOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsFullOuterJoins() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether auto generated keys can be returned when a statement executes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if auto generated keys can be returned, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsGetGeneratedKeys
				/// </java-name>
				[Dot42.DexImport("supportsGetGeneratedKeys", "()Z", AccessFlags = 1025)]
				bool SupportsGetGeneratedKeys() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports <c>GROUP BY </c> clauses.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>GROUP BY </c> clause is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsGroupBy
				/// </java-name>
				[Dot42.DexImport("supportsGroupBy", "()Z", AccessFlags = 1025)]
				bool SupportsGroupBy() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports using a column name in a <c> GROUPBY </c> clause not included in the <c>SELECT </c> statement as long as all of the columns in the <c>SELECT </c> statement are used in the <c> GROUPBY </c> clause.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>GROUP BY </c> clauses can use column names in this way, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsGroupByBeyondSelect
				/// </java-name>
				[Dot42.DexImport("supportsGroupByBeyondSelect", "()Z", AccessFlags = 1025)]
				bool SupportsGroupByBeyondSelect() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports using a column name in a <c> GROUPBY </c> clause that is not in the <c>SELECT </c> statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>GROUP BY </c> clause can use a column name not in the <c>SELECT </c> statement, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsGroupByUnrelated
				/// </java-name>
				[Dot42.DexImport("supportsGroupByUnrelated", "()Z", AccessFlags = 1025)]
				bool SupportsGroupByUnrelated() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports SQL Integrity Enhancement Facility.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the Integrity Enhancement Facility is supported,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsIntegrityEnhancementFacility
				/// </java-name>
				[Dot42.DexImport("supportsIntegrityEnhancementFacility", "()Z", AccessFlags = 1025)]
				bool SupportsIntegrityEnhancementFacility() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports a <c>LIKE </c> escape clause.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if LIKE escape clause is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsLikeEscapeClause
				/// </java-name>
				[Dot42.DexImport("supportsLikeEscapeClause", "()Z", AccessFlags = 1025)]
				bool SupportsLikeEscapeClause() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database provides limited support for outer join operations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if there is limited support for outer join operations, <c>false </c> otherwise. This will be <c>true </c> if  <c>supportsFullOuterJoins </c> returns <c>true </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsLimitedOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsLimitedOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsLimitedOuterJoins() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database supports Minimum SQL Grammar for ODBC.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the Minimum SQL Grammar is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMinimumSQLGrammar
				/// </java-name>
				[Dot42.DexImport("supportsMinimumSQLGrammar", "()Z", AccessFlags = 1025)]
				bool SupportsMinimumSQLGrammar() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database treats mixed case unquoted SQL identifiers as case sensitive storing them in mixed case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if unquoted SQL identifiers are stored in mixed case, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMixedCaseIdentifiers
				/// </java-name>
				[Dot42.DexImport("supportsMixedCaseIdentifiers", "()Z", AccessFlags = 1025)]
				bool SupportsMixedCaseIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database considers mixed case quoted SQL identifiers as case sensitive, storing them in mixed case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if quoted SQL identifiers are stored in mixed case,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMixedCaseQuotedIdentifiers
				/// </java-name>
				[Dot42.DexImport("supportsMixedCaseQuotedIdentifiers", "()Z", AccessFlags = 1025)]
				bool SupportsMixedCaseQuotedIdentifiers() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether it is possible for a single <c>CallableStatement </c> to return multiple <c>ResultSet </c> s simultaneously.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a single <c>CallableStatement </c> can return multiple <c>ResultSet </c> s simultaneously, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMultipleOpenResults
				/// </java-name>
				[Dot42.DexImport("supportsMultipleOpenResults", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleOpenResults() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether retrieving multiple <c>ResultSet </c> s from a single call to the <c>execute </c> method is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if multiple <c>ResultSet </c> s can be retrieved,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMultipleResultSets
				/// </java-name>
				[Dot42.DexImport("supportsMultipleResultSets", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleResultSets() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether multiple simultaneous transactions on different connections are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if multiple open transactions are supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsMultipleTransactions
				/// </java-name>
				[Dot42.DexImport("supportsMultipleTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsMultipleTransactions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether callable statements with named parameters is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if named parameters can be used with callable statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsNamedParameters
				/// </java-name>
				[Dot42.DexImport("supportsNamedParameters", "()Z", AccessFlags = 1025)]
				bool SupportsNamedParameters() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether columns in the database can be defined as non-nullable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if columns can be defined non-nullable, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsNonNullableColumns
				/// </java-name>
				[Dot42.DexImport("supportsNonNullableColumns", "()Z", AccessFlags = 1025)]
				bool SupportsNonNullableColumns() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether keeping cursors open across commit operations is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if cursors can be kept open across commit operations, <c>false </c> if they might get closed. </para>
				/// </returns>
				/// <java-name>
				/// supportsOpenCursorsAcrossCommit
				/// </java-name>
				[Dot42.DexImport("supportsOpenCursorsAcrossCommit", "()Z", AccessFlags = 1025)]
				bool SupportsOpenCursorsAcrossCommit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database can keep cursors open across rollback operations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if cursors can be kept open across rollback operations, <c>false </c> if they might get closed. </para>
				/// </returns>
				/// <java-name>
				/// supportsOpenCursorsAcrossRollback
				/// </java-name>
				[Dot42.DexImport("supportsOpenCursorsAcrossRollback", "()Z", AccessFlags = 1025)]
				bool SupportsOpenCursorsAcrossRollback() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether keeping statements open across commit operations is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if statements can be kept open, <c>false </c> if they might not. </para>
				/// </returns>
				/// <java-name>
				/// supportsOpenStatementsAcrossCommit
				/// </java-name>
				[Dot42.DexImport("supportsOpenStatementsAcrossCommit", "()Z", AccessFlags = 1025)]
				bool SupportsOpenStatementsAcrossCommit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether keeping statements open across rollback operations is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if statements can be kept open, <c>false </c> if they might not. </para>
				/// </returns>
				/// <java-name>
				/// supportsOpenStatementsAcrossRollback
				/// </java-name>
				[Dot42.DexImport("supportsOpenStatementsAcrossRollback", "()Z", AccessFlags = 1025)]
				bool SupportsOpenStatementsAcrossRollback() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether using a column in an <c>ORDER BY </c> clause that is not in the <c>SELECT </c> statement is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if it is possible to <c>ORDER </c> using a column not in the <c>SELECT </c> , <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsOrderByUnrelated
				/// </java-name>
				[Dot42.DexImport("supportsOrderByUnrelated", "()Z", AccessFlags = 1025)]
				bool SupportsOrderByUnrelated() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether outer join operations are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if outer join operations are supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsOuterJoins
				/// </java-name>
				[Dot42.DexImport("supportsOuterJoins", "()Z", AccessFlags = 1025)]
				bool SupportsOuterJoins() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether positioned <c>DELETE </c> statements are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database supports positioned <c>DELETE </c> statements. </para>
				/// </returns>
				/// <java-name>
				/// supportsPositionedDelete
				/// </java-name>
				[Dot42.DexImport("supportsPositionedDelete", "()Z", AccessFlags = 1025)]
				bool SupportsPositionedDelete() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether positioned <c>UPDATE </c> statements are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database supports positioned <c>UPDATE </c> statements, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsPositionedUpdate
				/// </java-name>
				[Dot42.DexImport("supportsPositionedUpdate", "()Z", AccessFlags = 1025)]
				bool SupportsPositionedUpdate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether there is support for a given concurrency style for the given <c>ResultSet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if that concurrency and <c>ResultSet </c> type pairing is supported otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsResultSetConcurrency
				/// </java-name>
				[Dot42.DexImport("supportsResultSetConcurrency", "(II)Z", AccessFlags = 1025)]
				bool SupportsResultSetConcurrency(int type, int concurrency) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the supplied <c>ResultSet </c> holdability mode is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the given ResultSet holdability is supported and if it isn't then <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsResultSetHoldability
				/// </java-name>
				[Dot42.DexImport("supportsResultSetHoldability", "(I)Z", AccessFlags = 1025)]
				bool SupportsResultSetHoldability(int holdability) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the supplied <c>ResultSet </c> type is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>ResultSet </c> type is supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsResultSetType
				/// </java-name>
				[Dot42.DexImport("supportsResultSetType", "(I)Z", AccessFlags = 1025)]
				bool SupportsResultSetType(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether savepoints for transactions are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if savepoints are supported, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// supportsSavepoints
				/// </java-name>
				[Dot42.DexImport("supportsSavepoints", "()Z", AccessFlags = 1025)]
				bool SupportsSavepoints() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a schema name may be used in a data manipulation statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a schema name can be used in a data manipulation, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSchemasInDataManipulation
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInDataManipulation", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInDataManipulation() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a schema name may be used in an index definition statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a schema name can be used in an index definition, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSchemasInIndexDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInIndexDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInIndexDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a database schema name can be used in a privilege definition statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a database schema name may be used in a privilege definition, otherwise <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// supportsSchemasInPrivilegeDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInPrivilegeDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInPrivilegeDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a procedure call statement may be contain in a schema name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a schema name can be used in a procedure call, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSchemasInProcedureCalls
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInProcedureCalls", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInProcedureCalls() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a schema name can be used in a table definition statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a schema name can be used in a table definition, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSchemasInTableDefinitions
				/// </java-name>
				[Dot42.DexImport("supportsSchemasInTableDefinitions", "()Z", AccessFlags = 1025)]
				bool SupportsSchemasInTableDefinitions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the <c>SELECT FOR UPDATE </c> statement is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>SELECT FOR UPDATE </c> statements are supported, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSelectForUpdate
				/// </java-name>
				[Dot42.DexImport("supportsSelectForUpdate", "()Z", AccessFlags = 1025)]
				bool SupportsSelectForUpdate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether statement pooling is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> of the database does support statement pooling, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsStatementPooling
				/// </java-name>
				[Dot42.DexImport("supportsStatementPooling", "()Z", AccessFlags = 1025)]
				bool SupportsStatementPooling() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether stored procedure calls using the stored procedure escape syntax is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if stored procedure calls using the stored procedure escape syntax are supported, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsStoredProcedures
				/// </java-name>
				[Dot42.DexImport("supportsStoredProcedures", "()Z", AccessFlags = 1025)]
				bool SupportsStoredProcedures() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether subqueries in comparison expressions are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if subqueries are supported in comparison expressions. </para>
				/// </returns>
				/// <java-name>
				/// supportsSubqueriesInComparisons
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInComparisons", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInComparisons() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether subqueries in <c>EXISTS </c> expressions are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if subqueries are supported in <c>EXISTS </c> expressions, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSubqueriesInExists
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInExists", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInExists() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether subqueries in <c>IN </c> statements are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if subqueries are supported in <c>IN </c> statements, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSubqueriesInIns
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInIns", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInIns() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether subqueries in quantified expressions are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if subqueries are supported, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsSubqueriesInQuantifieds
				/// </java-name>
				[Dot42.DexImport("supportsSubqueriesInQuantifieds", "()Z", AccessFlags = 1025)]
				bool SupportsSubqueriesInQuantifieds() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the database has table correlation names support.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if table correlation names are supported, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsTableCorrelationNames
				/// </java-name>
				[Dot42.DexImport("supportsTableCorrelationNames", "()Z", AccessFlags = 1025)]
				bool SupportsTableCorrelationNames() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether a specified transaction isolation level is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specific isolation level is supported, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsTransactionIsolationLevel
				/// </java-name>
				[Dot42.DexImport("supportsTransactionIsolationLevel", "(I)Z", AccessFlags = 1025)]
				bool SupportsTransactionIsolationLevel(int level) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether transactions are supported. </para> <para>If transactions are not supported, then the <c>commit </c> method does nothing and the transaction isolation level is always <c>TRANSACTION_NONE </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if transactions are supported, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsTransactions
				/// </java-name>
				[Dot42.DexImport("supportsTransactions", "()Z", AccessFlags = 1025)]
				bool SupportsTransactions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the <c>SQL UNION </c> operation is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> of the database does support <c>UNION </c> , otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsUnion
				/// </java-name>
				[Dot42.DexImport("supportsUnion", "()Z", AccessFlags = 1025)]
				bool SupportsUnion() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the <c>SQL UNION ALL </c> operation is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database does support <c>UNION ALL </c> , otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// supportsUnionAll
				/// </java-name>
				[Dot42.DexImport("supportsUnionAll", "()Z", AccessFlags = 1025)]
				bool SupportsUnionAll() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the method <c>ResultSet.rowUpdated </c> can detect a visible row update for the specified <c>ResultSet </c> type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> detecting changes is possible, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// updatesAreDetected
				/// </java-name>
				[Dot42.DexImport("updatesAreDetected", "(I)Z", AccessFlags = 1025)]
				bool UpdatesAreDetected(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether this database uses a file for each table.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database uses one file for each table, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// usesLocalFilePerTable
				/// </java-name>
				[Dot42.DexImport("usesLocalFilePerTable", "()Z", AccessFlags = 1025)]
				bool UsesLocalFilePerTable() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether this database uses a local file to store tables.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database stores tables in a local file, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// usesLocalFiles
				/// </java-name>
				[Dot42.DexImport("usesLocalFiles", "()Z", AccessFlags = 1025)]
				bool UsesLocalFiles() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine if a SQLException while autoCommit is true indicates that all open ResultSets are closed, even ones that are holdable</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if all open ResultSets are closed </para>
				/// </returns>
				/// <java-name>
				/// autoCommitFailureClosesAllResultSets
				/// </java-name>
				[Dot42.DexImport("autoCommitFailureClosesAllResultSets", "()Z", AccessFlags = 1025)]
				bool AutoCommitFailureClosesAllResultSets() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description according to the given catalog's system or user function parameters and return type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a description of user functions </para>
				/// </returns>
				/// <java-name>
				/// getFunctionColumns
				/// </java-name>
				[Dot42.DexImport("getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/s" +
    "ql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetFunctionColumns(string catalog, string schemaPattern, string functionNamePattern, string columnNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a description of the system and user functions available according to the given catalog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>user functions </para>
				/// </returns>
				/// <java-name>
				/// getFunctions
				/// </java-name>
				[Dot42.DexImport("getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetFunctions(string catalog, string schemaPattern, string functionNamePattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the schema names ordered by TABLE_CATALOG and TABLE_SCHEMA.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the schema names </para>
				/// </returns>
				/// <java-name>
				/// getSchemas
				/// </java-name>
				[Dot42.DexImport("getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet GetSchemas(string catalog, string schemaPattern) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine if this database supports invoking user-defined or vendor functions using the stored procedure escape syntax.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this database supports invoking user-defined or vendor functions using the stored procedure escape syntax. </para>
				/// </returns>
				/// <java-name>
				/// supportsStoredFunctionsUsingCallSyntax
				/// </java-name>
				[Dot42.DexImport("supportsStoredFunctionsUsingCallSyntax", "()Z", AccessFlags = 1025)]
				bool SupportsStoredFunctionsUsingCallSyntax() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the set of catalog names available in this database. The set is returned ordered by catalog name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the catalog names, with each row containing one catalog name (as a <c>String </c> ) in the single column named <c>TABLE_CAT </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCatalogs
				/// </java-name>
				global::Java.Sql.IResultSet Catalogs
				{
						[Dot42.DexImport("getCatalogs", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the separator that this database uses between a catalog name and table name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the separator. </para>
				/// </returns>
				/// <java-name>
				/// getCatalogSeparator
				/// </java-name>
				string CatalogSeparator
				{
						[Dot42.DexImport("getCatalogSeparator", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the term that the database vendor prefers term for "catalog".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String with the vendor's term for "catalog". </para>
				/// </returns>
				/// <java-name>
				/// getCatalogTerm
				/// </java-name>
				string CatalogTerm
				{
						[Dot42.DexImport("getCatalogTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the database connection that created this metadata.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				global::Java.Sql.IConnection Connection
				{
						[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the major version number of the database software.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the major version number of the database software. </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseMajorVersion
				/// </java-name>
				int DatabaseMajorVersion
				{
						[Dot42.DexImport("getDatabaseMajorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the minor version number of the database software.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the minor version number of the database software. </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseMinorVersion
				/// </java-name>
				int DatabaseMinorVersion
				{
						[Dot42.DexImport("getDatabaseMinorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of the database software.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> with the name of the database software. </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseProductName
				/// </java-name>
				string DatabaseProductName
				{
						[Dot42.DexImport("getDatabaseProductName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the version number of this database software.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> with the version number of the database software. </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseProductVersion
				/// </java-name>
				string DatabaseProductVersion
				{
						[Dot42.DexImport("getDatabaseProductVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the default transaction isolation level for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default transaction isolation level. One of the following values:  <ul> <li> <para> <c>TRANSACTION_NONE </c>  </para></li> <li> <para> <c>TRANSACTION_READ_COMMITTED </c>  </para></li> <li> <para> <c>TRANSACTION_READ_UNCOMMITTED </c>  </para></li> <li> <para> <c>TRANSACTION_REPEATABLE_READ </c>  </para></li> <li> <para> <c>TRANSACTION_SERIALIZABLE </c>  </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getDefaultTransactionIsolation
				/// </java-name>
				int DefaultTransactionIsolation
				{
						[Dot42.DexImport("getDefaultTransactionIsolation", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the JDBC driver's major version number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the driver's major version number. </para>
				/// </returns>
				/// <java-name>
				/// getDriverMajorVersion
				/// </java-name>
				int DriverMajorVersion
				{
						[Dot42.DexImport("getDriverMajorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the JDBC driver's minor version number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the driver's minor version number. </para>
				/// </returns>
				/// <java-name>
				/// getDriverMinorVersion
				/// </java-name>
				int DriverMinorVersion
				{
						[Dot42.DexImport("getDriverMinorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of this JDBC driver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> containing the name of the JDBC driver </para>
				/// </returns>
				/// <java-name>
				/// getDriverName
				/// </java-name>
				string DriverName
				{
						[Dot42.DexImport("getDriverName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the version number of this JDBC driver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> containing the complete version number of the JDBC driver. </para>
				/// </returns>
				/// <java-name>
				/// getDriverVersion
				/// </java-name>
				string DriverVersion
				{
						[Dot42.DexImport("getDriverVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a string of characters that may be used in unquoted identifier names. The characters <c>a-z </c> , <c>A-Z </c> , <c>0-9 </c> and <c>_ </c> are always permitted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing all the additional permitted characters. </para>
				/// </returns>
				/// <java-name>
				/// getExtraNameCharacters
				/// </java-name>
				string ExtraNameCharacters
				{
						[Dot42.DexImport("getExtraNameCharacters", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the string used to quote SQL identifiers. Returns " " (space) if identifier quoting not supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the String used to quote SQL identifiers. </para>
				/// </returns>
				/// <java-name>
				/// getIdentifierQuoteString
				/// </java-name>
				string IdentifierQuoteString
				{
						[Dot42.DexImport("getIdentifierQuoteString", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns this driver's major JDBC version number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the major JDBC version number. </para>
				/// </returns>
				/// <java-name>
				/// getJDBCMajorVersion
				/// </java-name>
				int JDBCMajorVersion
				{
						[Dot42.DexImport("getJDBCMajorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the minor JDBC version number for this driver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Minor JDBC Version Number. </para>
				/// </returns>
				/// <java-name>
				/// getJDBCMinorVersion
				/// </java-name>
				int JDBCMinorVersion
				{
						[Dot42.DexImport("getJDBCMinorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the maximum number of hex characters in an in-line binary literal for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of hex characters in an in-line binary literal. If the number is unlimited then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxBinaryLiteralLength
				/// </java-name>
				int MaxBinaryLiteralLength
				{
						[Dot42.DexImport("getMaxBinaryLiteralLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum size of a catalog name in this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum size in characters for a catalog name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxCatalogNameLength
				/// </java-name>
				int MaxCatalogNameLength
				{
						[Dot42.DexImport("getMaxCatalogNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum size for a character literal in this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum size in characters for a character literal. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxCharLiteralLength
				/// </java-name>
				int MaxCharLiteralLength
				{
						[Dot42.DexImport("getMaxCharLiteralLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum size for a Column name for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of characters for a Column name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnNameLength
				/// </java-name>
				int MaxColumnNameLength
				{
						[Dot42.DexImport("getMaxColumnNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the maximum number of columns in a <c>GROUP BY </c> clause for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of columns in a <c>GROUP BY </c> clause. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnsInGroupBy
				/// </java-name>
				int MaxColumnsInGroupBy
				{
						[Dot42.DexImport("getMaxColumnsInGroupBy", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of columns in an Index for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of columns in an Index. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnsInIndex
				/// </java-name>
				int MaxColumnsInIndex
				{
						[Dot42.DexImport("getMaxColumnsInIndex", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of columns in an <c>ORDER BY </c> clause for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of columns in an <c>ORDER BY </c> clause. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnsInOrderBy
				/// </java-name>
				int MaxColumnsInOrderBy
				{
						[Dot42.DexImport("getMaxColumnsInOrderBy", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of columns in a <c>SELECT </c> list for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of columns in a <c>SELECT </c> list. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnsInSelect
				/// </java-name>
				int MaxColumnsInSelect
				{
						[Dot42.DexImport("getMaxColumnsInSelect", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of columns in a table for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of columns in a table. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxColumnsInTable
				/// </java-name>
				int MaxColumnsInTable
				{
						[Dot42.DexImport("getMaxColumnsInTable", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the database's maximum number of concurrent connections.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of connections. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxConnections
				/// </java-name>
				int MaxConnections
				{
						[Dot42.DexImport("getMaxConnections", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum length of a cursor name for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of characters in a cursor name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxCursorNameLength
				/// </java-name>
				int MaxCursorNameLength
				{
						[Dot42.DexImport("getMaxCursorNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum length in bytes for an Index for this database. This covers all the parts of a composite index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum length in bytes for an Index. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxIndexLength
				/// </java-name>
				int MaxIndexLength
				{
						[Dot42.DexImport("getMaxIndexLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of characters for a procedure name in this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of character for a procedure name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxProcedureNameLength
				/// </java-name>
				int MaxProcedureNameLength
				{
						[Dot42.DexImport("getMaxProcedureNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of bytes within a single row for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of bytes for a single row. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxRowSize
				/// </java-name>
				int MaxRowSize
				{
						[Dot42.DexImport("getMaxRowSize", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of characters in a schema name for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of characters in a schema name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxSchemaNameLength
				/// </java-name>
				int MaxSchemaNameLength
				{
						[Dot42.DexImport("getMaxSchemaNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of characters in an SQL statement for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of characters in an SQL statement. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxStatementLength
				/// </java-name>
				int MaxStatementLength
				{
						[Dot42.DexImport("getMaxStatementLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the maximum number of simultaneously open active statements for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of open active statements. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxStatements
				/// </java-name>
				int MaxStatements
				{
						[Dot42.DexImport("getMaxStatements", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum size for a table name in the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum size in characters for a table name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxTableNameLength
				/// </java-name>
				int MaxTableNameLength
				{
						[Dot42.DexImport("getMaxTableNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of tables permitted in a <c>SELECT </c> statement for the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of tables permitted in a <c>SELECT </c> statement. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxTablesInSelect
				/// </java-name>
				int MaxTablesInSelect
				{
						[Dot42.DexImport("getMaxTablesInSelect", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the maximum number of characters in a user name for the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum number of characters in a user name. If the limit is unknown, or the value is unlimited, then the result is zero. </para>
				/// </returns>
				/// <java-name>
				/// getMaxUserNameLength
				/// </java-name>
				int MaxUserNameLength
				{
						[Dot42.DexImport("getMaxUserNameLength", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of the math functions available with this database. These are used in the JDBC function escape clause and are the Open Group CLI math function names.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String which contains the list of math functions as a comma separated list. </para>
				/// </returns>
				/// <java-name>
				/// getNumericFunctions
				/// </java-name>
				string NumericFunctions
				{
						[Dot42.DexImport("getNumericFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the database vendor's preferred name for "procedure".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String with the vendor's preferred name for "procedure". </para>
				/// </returns>
				/// <java-name>
				/// getProcedureTerm
				/// </java-name>
				string ProcedureTerm
				{
						[Dot42.DexImport("getProcedureTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the result set's default holdability.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>one of <c>ResultSet.HOLD_CURSORS_OVER_COMMIT </c> or <c>ResultSet.CLOSE_CURSORS_AT_COMMIT </c> . </para>
				/// </returns>
				/// <java-name>
				/// getResultSetHoldability
				/// </java-name>
				int ResultSetHoldability
				{
						[Dot42.DexImport("getResultSetHoldability", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of the schema names in the database. The list is returned as a <c>ResultSet </c> , ordered by the schema name, with one row per schema in the following format:  <ol> <li> <para> <c>TABLE_SCHEM </c> - String - the schema name </para></li> <li> <para> <c>TABLE_CATALOG </c> - String - the catalog name (possibly <c>null </c> )  </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> with one row for each schema in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getSchemas
				/// </java-name>
				global::Java.Sql.IResultSet Schemas
				{
						[Dot42.DexImport("getSchemas", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the database vendor's preferred term for "schema".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String which is the vendor's preferred term for schema. </para>
				/// </returns>
				/// <java-name>
				/// getSchemaTerm
				/// </java-name>
				string SchemaTerm
				{
						[Dot42.DexImport("getSchemaTerm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the string that is used to escape wildcard characters. This string is used to escape the <c>'_' </c> and <c>'%' </c> wildcard characters in catalog search pattern strings. <c>'_' </c> is used to represent any single character while <c>'%' </c> is used for a sequence of zero or more characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String used to escape the wildcard characters. </para>
				/// </returns>
				/// <java-name>
				/// getSearchStringEscape
				/// </java-name>
				string SearchStringEscape
				{
						[Dot42.DexImport("getSearchStringEscape", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of all the SQL keywords that are NOT also SQL92 keywords for the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the list of SQL keywords in a comma separated format. </para>
				/// </returns>
				/// <java-name>
				/// getSQLKeywords
				/// </java-name>
				string SQLKeywords
				{
						[Dot42.DexImport("getSQLKeywords", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>States the type of <c>SQLState </c> value returned by <c>SQLException.getSQLState </c> . This can either be the X/Open (now known as Open Group) SQL CLI form or the SQL99 form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an integer, which is either <c>DatabaseMetaData.sqlStateSQL99 </c> or <c>DatabaseMetaData.sqlStateXOpen </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSQLStateType
				/// </java-name>
				int SQLStateType
				{
						[Dot42.DexImport("getSQLStateType", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of string functions available with the database. These functions are used in JDBC function escape clause and follow the Open Group CLI string function names definition.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the list of string functions in comma separated format. </para>
				/// </returns>
				/// <java-name>
				/// getStringFunctions
				/// </java-name>
				string StringFunctions
				{
						[Dot42.DexImport("getStringFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of system functions available with the database. These are names used in the JDBC function escape clause and are Open Group CLI function names.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the list of system functions in a comma separated format. </para>
				/// </returns>
				/// <java-name>
				/// getSystemFunctions
				/// </java-name>
				string SystemFunctions
				{
						[Dot42.DexImport("getSystemFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of table types supported by the database. </para> <para>The list is returned as a <c>ResultSet </c> with one row per table type, ordered by the table type. The information in the <c>ResultSet </c> is structured into a single column per row, as follows:  <ol> <li> <para> <c>TABLE_TYPE </c> - String - the table type. Typical names include  <c>"TABLE" </c> , <c>"VIEW" </c> , "@code SYSTEM TABLE"  , <c>"ALIAS" </c> ,  <c>"SYNONYM" </c> , <c>"GLOBAL TEMPORARY" </c>  </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> with one row per table type in the format defined above. </para>
				/// </returns>
				/// <java-name>
				/// getTableTypes
				/// </java-name>
				global::Java.Sql.IResultSet TableTypes
				{
						[Dot42.DexImport("getTableTypes", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of time and date functions available for the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string containing a comma separated list of the time and date functions. </para>
				/// </returns>
				/// <java-name>
				/// getTimeDateFunctions
				/// </java-name>
				string TimeDateFunctions
				{
						[Dot42.DexImport("getTimeDateFunctions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get a list of the standard SQL types supported by this database. The list is returned as a <c>ResultSet </c> , with one row for each type, ordered by the <c>DATA_TYPE </c> value, where the data in each row is structured into the following columns:  <ol> <li> <para> <c>TYPE_NAME </c> - String : the type name </para></li> <li> <para> <c>DATA_TYPE </c> - int : the SQL data type value as defined in  <c>java.sql.Types </c>  </para></li> <li> <para> <c>PRECISION </c> - int - the maximum precision of the type </para></li> <li> <para> <c>LITERAL_PREFIX </c> - String : the prefix to be used when quoting a literal value (possibly <c>null </c> ) </para></li> <li> <para> <c>LITERAL_SUFFIX </c> - String : the suffix to be used when quoting a literal value (possibly <c>null </c> ) </para></li> <li> <para> <c>CREATE_PARAMS </c> - String : params used when creating the type (possibly <c>null </c> ) </para></li> <li> <para> <c>NULLABLE </c> - short : shows if the value is nullable:  <ul> <li> <para> <c>DatabaseMetaData.typeNoNulls </c> : <c>NULL </c> s not permitted </para></li> <li> <para> <c>DatabaseMetaData.typeNullable </c> : <c>NULL </c> s are permitted </para></li> <li> <para> <c>DatabaseMetaData.typeNullableUnknown </c> : <c>NULL </c> status unknown </para></li></ul></para></li> <li> <para> <c>CASE_SENSITIVE </c> - boolean : true if the type is case sensitive  </para></li> <li> <para> <c>SEARCHABLE </c> - short : how this type can be used with <c>WHERE </c> clauses:  <ul> <li> <para> <c>DatabaseMetaData.typePredNone </c> - <c>WHERE </c> clauses cannot be used </para></li> <li> <para> <c>DatabaseMetaData.typePredChar </c> - support for <c>WHERE...LIKE </c> only </para></li> <li> <para> <c>DatabaseMetaData.typePredBasic </c> - support except for <c>WHERE...LIKE </c>  </para></li> <li> <para> <c>DatabaseMetaData.typeSearchable </c> - support for all <c>WHERE </c> clauses </para></li></ul></para></li> <li> <para> <c>UNSIGNED_ATTRIBUTE </c> - boolean - the type is unsigned or not </para></li> <li> <para> <c>FIXED_PREC_SCALE </c> - boolean - fixed precision = it can be used as a money value </para></li> <li> <para> <c>AUTO_INCREMENT </c> - boolean - can be used as an auto-increment value </para></li> <li> <para> <c>LOCAL_TYPE_NAME </c> - String - a localized version of the type name (possibly <c>null </c> ) </para></li> <li> <para> <c>MINIMUM_SCALE </c> - short - the minimum scale supported </para></li> <li> <para> <c>MAXIMUM_SCALE </c> - short - the maximum scale supported </para></li> <li> <para> <c>SQL_DATA_TYPE </c> - int - not used </para></li> <li> <para> <c>SQL_DATETIME_SUB </c> - int - not used </para></li> <li> <para> <c>NUM_PREC_RADIX </c> - int - number radix (typically 2 or 10) </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> which is structured as described above. </para>
				/// </returns>
				/// <java-name>
				/// getTypeInfo
				/// </java-name>
				global::Java.Sql.IResultSet TypeInfo
				{
						[Dot42.DexImport("getTypeInfo", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the URL for this database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the URL for the database. <c>null </c> if it cannot be generated. </para>
				/// </returns>
				/// <java-name>
				/// getURL
				/// </java-name>
				string URL
				{
						[Dot42.DexImport("getURL", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Determine the user name as known by the database.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the user name. </para>
				/// </returns>
				/// <java-name>
				/// getUserName
				/// </java-name>
				string UserName
				{
						[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Determine whether a fully qualified table name is prefixed or suffixed to a fully qualified table name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the catalog appears at the start of a fully qualified table name, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isCatalogAtStart
				/// </java-name>
				bool IsCatalogAtStart
				{
						[Dot42.DexImport("isCatalogAtStart", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Determines whether the database is in read-only mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database is in read-only mode, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				bool IsReadOnly
				{
						[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a list of the client info properties of the driver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of the client info </para>
				/// </returns>
				/// <java-name>
				/// getClientInfoProperties
				/// </java-name>
				global::Java.Sql.IResultSet ClientInfoProperties
				{
						[Dot42.DexImport("getClientInfoProperties", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the lifetime for which a RowId object remains valid if this data source supports the SQL ROWID type</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time of a RowId object that remains valid. </para>
				/// </returns>
				/// <java-name>
				/// getRowIdLifetime
				/// </java-name>
				global::Java.Sql.RowIdLifetime RowIdLifetime
				{
						[Dot42.DexImport("getRowIdLifetime", "()Ljava/sql/RowIdLifetime;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An interface which provides comprehensive information about the database management system and its supported features. </para> <para>This interface is implemented by JDBC driver vendors in order to provide information about the underlying database capabilities in association with the JDBC driver. </para> <para>Some of the methods in this interface take string parameters which are patterns. Within these string patterns, <c>'%' </c> and <c>'_' </c> characters have special meanings. <c>'%' </c> means "match any substring of 0 or more characters". <c>'_' </c> means "match any character". Only metadata entries that match the pattern are returned. If such a search pattern string is set to <c>null </c> , that argument's criteria are dropped from the search. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/DatabaseMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/DatabaseMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDatabaseMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>States that it may not be permitted to store <c>NULL </c> values. </para>        
				/// </summary>
				/// <java-name>
				/// attributeNoNulls
				/// </java-name>
				[Dot42.DexImport("attributeNoNulls", "S", AccessFlags = 25)]
				public const short AttributeNoNulls = 0;
				/// <summary>
				///  <para>States that <c>NULL </c> values are definitely permitted. </para>        
				/// </summary>
				/// <java-name>
				/// attributeNullable
				/// </java-name>
				[Dot42.DexImport("attributeNullable", "S", AccessFlags = 25)]
				public const short AttributeNullable = 1;
				/// <summary>
				///  <para>States that whether <c>NULL </c> values are permitted is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// attributeNullableUnknown
				/// </java-name>
				[Dot42.DexImport("attributeNullableUnknown", "S", AccessFlags = 25)]
				public const short AttributeNullableUnknown = 2;
				/// <summary>
				///  <para>States the best row identifier is  <b>NOT</b> a pseudo column. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowNotPseudo
				/// </java-name>
				[Dot42.DexImport("bestRowNotPseudo", "I", AccessFlags = 25)]
				public const int BestRowNotPseudo = 1;
				/// <summary>
				///  <para>States that the best row identifier is a pseudo column. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowPseudo
				/// </java-name>
				[Dot42.DexImport("bestRowPseudo", "I", AccessFlags = 25)]
				public const int BestRowPseudo = 2;
				/// <summary>
				///  <para>States that the remainder of the current session is used as the scope for the best row identifier. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowSession
				/// </java-name>
				[Dot42.DexImport("bestRowSession", "I", AccessFlags = 25)]
				public const int BestRowSession = 2;
				/// <summary>
				///  <para>States that best row identifier scope lasts only while the row is being used. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowTemporary
				/// </java-name>
				[Dot42.DexImport("bestRowTemporary", "I", AccessFlags = 25)]
				public const int BestRowTemporary = 0;
				/// <summary>
				///  <para>States that the remainder of the current transaction is used as the scope for the best row identifier. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowTransaction
				/// </java-name>
				[Dot42.DexImport("bestRowTransaction", "I", AccessFlags = 25)]
				public const int BestRowTransaction = 1;
				/// <summary>
				///  <para>States that the best row identifier may or may not be a pseudo column. </para>        
				/// </summary>
				/// <java-name>
				/// bestRowUnknown
				/// </java-name>
				[Dot42.DexImport("bestRowUnknown", "I", AccessFlags = 25)]
				public const int BestRowUnknown = 0;
				/// <summary>
				///  <para>States that the column must not allow <c>NULL </c> values. </para>        
				/// </summary>
				/// <java-name>
				/// columnNoNulls
				/// </java-name>
				[Dot42.DexImport("columnNoNulls", "I", AccessFlags = 25)]
				public const int ColumnNoNulls = 0;
				/// <summary>
				///  <para>States that the column definitely allows <c>NULL </c> values. </para>        
				/// </summary>
				/// <java-name>
				/// columnNullable
				/// </java-name>
				[Dot42.DexImport("columnNullable", "I", AccessFlags = 25)]
				public const int ColumnNullable = 1;
				/// <summary>
				///  <para>States that it is unknown whether the columns may be nulled. </para>        
				/// </summary>
				/// <java-name>
				/// columnNullableUnknown
				/// </java-name>
				[Dot42.DexImport("columnNullableUnknown", "I", AccessFlags = 25)]
				public const int ColumnNullableUnknown = 2;
				/// <summary>
				///  <para>For the column <c>UPDATE_RULE </c> , states that when the primary key is updated, the foreign key (imported key) is changed accordingly. </para>        
				/// </summary>
				/// <java-name>
				/// importedKeyCascade
				/// </java-name>
				[Dot42.DexImport("importedKeyCascade", "I", AccessFlags = 25)]
				public const int ImportedKeyCascade = 0;
				/// <summary>
				///  <para>States that the evaluation of foreign key constraints is deferred (delayed until commit). </para>        
				/// </summary>
				/// <java-name>
				/// importedKeyInitiallyDeferred
				/// </java-name>
				[Dot42.DexImport("importedKeyInitiallyDeferred", "I", AccessFlags = 25)]
				public const int ImportedKeyInitiallyDeferred = 5;
				/// <summary>
				///  <para>States that the evaluation of foreign key constraint is <c>IMMEDIATE </c></para>        
				/// </summary>
				/// <java-name>
				/// importedKeyInitiallyImmediate
				/// </java-name>
				[Dot42.DexImport("importedKeyInitiallyImmediate", "I", AccessFlags = 25)]
				public const int ImportedKeyInitiallyImmediate = 6;
				/// <summary>
				///  <para>For the columns <c>UPDATE_RULE </c> and <c>DELETE_RULE </c> , states that if the primary key has been imported, it cannot be updated or deleted. </para>        
				/// </summary>
				/// <java-name>
				/// importedKeyNoAction
				/// </java-name>
				[Dot42.DexImport("importedKeyNoAction", "I", AccessFlags = 25)]
				public const int ImportedKeyNoAction = 3;
				/// <summary>
				///  <para>States that the evaluation of foreign key constraint must not be <c>DEFERRED </c> . </para>        
				/// </summary>
				/// <java-name>
				/// importedKeyNotDeferrable
				/// </java-name>
				[Dot42.DexImport("importedKeyNotDeferrable", "I", AccessFlags = 25)]
				public const int ImportedKeyNotDeferrable = 7;
				/// <summary>
				///  <para>States that a primary key must not be updated when imported as a foreign key by some other table. Used for the column <c>UPDATE_RULE </c> . </para>        
				/// </summary>
				/// <java-name>
				/// importedKeyRestrict
				/// </java-name>
				[Dot42.DexImport("importedKeyRestrict", "I", AccessFlags = 25)]
				public const int ImportedKeyRestrict = 1;
				/// <summary>
				///  <para>States that when the primary key is modified (updated or deleted) the foreign (imported) key is changed to its default value. Applies to the  <c>UPDATE_RULE </c> and <c>DELETE_RULE </c> columns. </para>        
				/// </summary>
				/// <java-name>
				/// importedKeySetDefault
				/// </java-name>
				[Dot42.DexImport("importedKeySetDefault", "I", AccessFlags = 25)]
				public const int ImportedKeySetDefault = 4;
				/// <summary>
				///  <para>States that when the primary key is modified (updated or deleted) the foreign (imported) key is changed to <c>NULL </c> . Applies to the <c>UPDATE_RULE </c> and <c>DELETE_RULE </c> columns. </para>        
				/// </summary>
				/// <java-name>
				/// importedKeySetNull
				/// </java-name>
				[Dot42.DexImport("importedKeySetNull", "I", AccessFlags = 25)]
				public const int ImportedKeySetNull = 2;
				/// <summary>
				///  <para>States that the column stores <c>IN </c> type parameters. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnIn
				/// </java-name>
				[Dot42.DexImport("procedureColumnIn", "I", AccessFlags = 25)]
				public const int ProcedureColumnIn = 1;
				/// <summary>
				///  <para>States that this column stores <c>INOUT </c> type parameters. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnInOut
				/// </java-name>
				[Dot42.DexImport("procedureColumnInOut", "I", AccessFlags = 25)]
				public const int ProcedureColumnInOut = 2;
				/// <summary>
				///  <para>States that this column stores <c>OUT </c> type parameters. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnOut
				/// </java-name>
				[Dot42.DexImport("procedureColumnOut", "I", AccessFlags = 25)]
				public const int ProcedureColumnOut = 4;
				/// <summary>
				///  <para>States that the column stores results. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnResult
				/// </java-name>
				[Dot42.DexImport("procedureColumnResult", "I", AccessFlags = 25)]
				public const int ProcedureColumnResult = 3;
				/// <summary>
				///  <para>States that the column stores return values. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnReturn
				/// </java-name>
				[Dot42.DexImport("procedureColumnReturn", "I", AccessFlags = 25)]
				public const int ProcedureColumnReturn = 5;
				/// <summary>
				///  <para>States that type of the column is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// procedureColumnUnknown
				/// </java-name>
				[Dot42.DexImport("procedureColumnUnknown", "I", AccessFlags = 25)]
				public const int ProcedureColumnUnknown = 0;
				/// <summary>
				///  <para>States that <c>NULL </c> values are not permitted. </para>        
				/// </summary>
				/// <java-name>
				/// procedureNoNulls
				/// </java-name>
				[Dot42.DexImport("procedureNoNulls", "I", AccessFlags = 25)]
				public const int ProcedureNoNulls = 0;
				/// <summary>
				///  <para>States that the procedure does not return a result. </para>        
				/// </summary>
				/// <java-name>
				/// procedureNoResult
				/// </java-name>
				[Dot42.DexImport("procedureNoResult", "I", AccessFlags = 25)]
				public const int ProcedureNoResult = 1;
				/// <summary>
				///  <para>States that <c>NULL </c> values are permitted. </para>        
				/// </summary>
				/// <java-name>
				/// procedureNullable
				/// </java-name>
				[Dot42.DexImport("procedureNullable", "I", AccessFlags = 25)]
				public const int ProcedureNullable = 1;
				/// <summary>
				///  <para>States that it is unknown whether <c>NULL </c> values are permitted. </para>        
				/// </summary>
				/// <java-name>
				/// procedureNullableUnknown
				/// </java-name>
				[Dot42.DexImport("procedureNullableUnknown", "I", AccessFlags = 25)]
				public const int ProcedureNullableUnknown = 2;
				/// <summary>
				///  <para>States that it is unknown whether or not the procedure returns a result. </para>        
				/// </summary>
				/// <java-name>
				/// procedureResultUnknown
				/// </java-name>
				[Dot42.DexImport("procedureResultUnknown", "I", AccessFlags = 25)]
				public const int ProcedureResultUnknown = 0;
				/// <summary>
				///  <para>States that the procedure returns a result. </para>        
				/// </summary>
				/// <java-name>
				/// procedureReturnsResult
				/// </java-name>
				[Dot42.DexImport("procedureReturnsResult", "I", AccessFlags = 25)]
				public const int ProcedureReturnsResult = 2;
				/// <summary>
				///  <para>States that the value is an SQL99 <c>SQLSTATE </c> value. </para>        
				/// </summary>
				/// <java-name>
				/// sqlStateSQL99
				/// </java-name>
				[Dot42.DexImport("sqlStateSQL99", "I", AccessFlags = 25)]
				public const int SqlStateSQL99 = 2;
				/// <summary>
				///  <para>States that the value is an SQL <c>CLI SQLSTATE </c> value as defined by the X/Open standard. </para>        
				/// </summary>
				/// <java-name>
				/// sqlStateXOpen
				/// </java-name>
				[Dot42.DexImport("sqlStateXOpen", "I", AccessFlags = 25)]
				public const int SqlStateXOpen = 1;
				/// <summary>
				///  <para>States that this table index is a clustered index. </para>        
				/// </summary>
				/// <java-name>
				/// tableIndexClustered
				/// </java-name>
				[Dot42.DexImport("tableIndexClustered", "S", AccessFlags = 25)]
				public const short TableIndexClustered = 1;
				/// <summary>
				///  <para>States that this table index is a hashed index. </para>        
				/// </summary>
				/// <java-name>
				/// tableIndexHashed
				/// </java-name>
				[Dot42.DexImport("tableIndexHashed", "S", AccessFlags = 25)]
				public const short TableIndexHashed = 2;
				/// <summary>
				///  <para>States this table's index is neither a clustered index, not a hashed index, and not a table statistics index; i.e. it is something else. </para>        
				/// </summary>
				/// <java-name>
				/// tableIndexOther
				/// </java-name>
				[Dot42.DexImport("tableIndexOther", "S", AccessFlags = 25)]
				public const short TableIndexOther = 3;
				/// <summary>
				///  <para>States this column has the table's statistics, and that it is returned in conjunction with the table's index description. </para>        
				/// </summary>
				/// <java-name>
				/// tableIndexStatistic
				/// </java-name>
				[Dot42.DexImport("tableIndexStatistic", "S", AccessFlags = 25)]
				public const short TableIndexStatistic = 0;
				/// <summary>
				///  <para>States that a <c>NULL </c> value is  <b>NOT</b> permitted for this data type. </para>        
				/// </summary>
				/// <java-name>
				/// typeNoNulls
				/// </java-name>
				[Dot42.DexImport("typeNoNulls", "I", AccessFlags = 25)]
				public const int TypeNoNulls = 0;
				/// <summary>
				///  <para>States that a <c>NULL </c> value is permitted for this data type. </para>        
				/// </summary>
				/// <java-name>
				/// typeNullable
				/// </java-name>
				[Dot42.DexImport("typeNullable", "I", AccessFlags = 25)]
				public const int TypeNullable = 1;
				/// <summary>
				///  <para>States that it is unknown if a <c>NULL </c> value is permitted for this data type. </para>        
				/// </summary>
				/// <java-name>
				/// typeNullableUnknown
				/// </java-name>
				[Dot42.DexImport("typeNullableUnknown", "I", AccessFlags = 25)]
				public const int TypeNullableUnknown = 2;
				/// <summary>
				///  <para>States that this column shall not be used for <c>WHERE </c> statements with a <c>LIKE </c> clause. </para>        
				/// </summary>
				/// <java-name>
				/// typePredBasic
				/// </java-name>
				[Dot42.DexImport("typePredBasic", "I", AccessFlags = 25)]
				public const int TypePredBasic = 2;
				/// <summary>
				///  <para>States that this column can only be used in a <c>WHERE...LIKE </c> statement. </para>        
				/// </summary>
				/// <java-name>
				/// typePredChar
				/// </java-name>
				[Dot42.DexImport("typePredChar", "I", AccessFlags = 25)]
				public const int TypePredChar = 1;
				/// <summary>
				///  <para>States that this column does not support searches. </para>        
				/// </summary>
				/// <java-name>
				/// typePredNone
				/// </java-name>
				[Dot42.DexImport("typePredNone", "I", AccessFlags = 25)]
				public const int TypePredNone = 0;
				/// <summary>
				///  <para>States that the column is searchable. </para>        
				/// </summary>
				/// <java-name>
				/// typeSearchable
				/// </java-name>
				[Dot42.DexImport("typeSearchable", "I", AccessFlags = 25)]
				public const int TypeSearchable = 3;
				/// <summary>
				///  <para>States that the version column is known to be not a pseudo column. </para>        
				/// </summary>
				/// <java-name>
				/// versionColumnNotPseudo
				/// </java-name>
				[Dot42.DexImport("versionColumnNotPseudo", "I", AccessFlags = 25)]
				public const int VersionColumnNotPseudo = 1;
				/// <summary>
				///  <para>States that this version column is known to be a pseudo column. </para>        
				/// </summary>
				/// <java-name>
				/// versionColumnPseudo
				/// </java-name>
				[Dot42.DexImport("versionColumnPseudo", "I", AccessFlags = 25)]
				public const int VersionColumnPseudo = 2;
				/// <summary>
				///  <para>States that the version column may be a pseudo column or not. </para>        
				/// </summary>
				/// <java-name>
				/// versionColumnUnknown
				/// </java-name>
				[Dot42.DexImport("versionColumnUnknown", "I", AccessFlags = 25)]
				public const int VersionColumnUnknown = 0;
				/// <summary>
				///  <para>States that the method DatabaseMetaData.getSQLStateType may returns an SQLSTATE value or not. </para>        
				/// </summary>
				/// <java-name>
				/// sqlStateSQL
				/// </java-name>
				[Dot42.DexImport("sqlStateSQL", "I", AccessFlags = 25)]
				public const int SqlStateSQL = 2;
				/// <summary>
				///  <para>States that the parameter or column is an IN parameter </para>        
				/// </summary>
				/// <java-name>
				/// functionColumnIn
				/// </java-name>
				[Dot42.DexImport("functionColumnIn", "I", AccessFlags = 25)]
				public const int FunctionColumnIn = 1;
				/// <summary>
				///  <para>States that the parameter or column is an INOUT parameter </para>        
				/// </summary>
				/// <java-name>
				/// functionColumnInOut
				/// </java-name>
				[Dot42.DexImport("functionColumnInOut", "I", AccessFlags = 25)]
				public const int FunctionColumnInOut = 2;
				/// <summary>
				///  <para>States that the parameter or column is an OUT parameter </para>        
				/// </summary>
				/// <java-name>
				/// functionColumnOut
				/// </java-name>
				[Dot42.DexImport("functionColumnOut", "I", AccessFlags = 25)]
				public const int FunctionColumnOut = 3;
				/// <summary>
				///  <para>States that the parameter or column is a return value </para>        
				/// </summary>
				/// <java-name>
				/// functionReturn
				/// </java-name>
				[Dot42.DexImport("functionReturn", "I", AccessFlags = 25)]
				public const int FunctionReturn = 4;
				/// <summary>
				///  <para>States that the parameter of function is unknown </para>        
				/// </summary>
				/// <java-name>
				/// functionColumnUnknown
				/// </java-name>
				[Dot42.DexImport("functionColumnUnknown", "I", AccessFlags = 25)]
				public const int FunctionColumnUnknown = 0;
				/// <summary>
				///  <para>States that the parameter or column is a column in a result set </para>        
				/// </summary>
				/// <java-name>
				/// functionColumnResult
				/// </java-name>
				[Dot42.DexImport("functionColumnResult", "I", AccessFlags = 25)]
				public const int FunctionColumnResult = 5;
				/// <summary>
				///  <para>States that NULL values are not allowed </para>        
				/// </summary>
				/// <java-name>
				/// functionNoNulls
				/// </java-name>
				[Dot42.DexImport("functionNoNulls", "I", AccessFlags = 25)]
				public const int FunctionNoNulls = 0;
				/// <summary>
				///  <para>States that NULL values are allowed </para>        
				/// </summary>
				/// <java-name>
				/// functionNullable
				/// </java-name>
				[Dot42.DexImport("functionNullable", "I", AccessFlags = 25)]
				public const int FunctionNullable = 1;
				/// <summary>
				///  <para>States that whether NULL values are allowed is unknown </para>        
				/// </summary>
				/// <java-name>
				/// functionNullableUnknown
				/// </java-name>
				[Dot42.DexImport("functionNullableUnknown", "I", AccessFlags = 25)]
				public const int FunctionNullableUnknown = 2;
				/// <summary>
				///  <para>States that it is not known whether the function returns a result or a table </para>        
				/// </summary>
				/// <java-name>
				/// functionResultUnknown
				/// </java-name>
				[Dot42.DexImport("functionResultUnknown", "I", AccessFlags = 25)]
				public const int FunctionResultUnknown = 0;
				/// <summary>
				///  <para>States that the function does not return a table </para>        
				/// </summary>
				/// <java-name>
				/// functionNoTable
				/// </java-name>
				[Dot42.DexImport("functionNoTable", "I", AccessFlags = 25)]
				public const int FunctionNoTable = 1;
				/// <summary>
				///  <para>States that the function returns a table. </para>        
				/// </summary>
				/// <java-name>
				/// functionReturnsTable
				/// </java-name>
				[Dot42.DexImport("functionReturnsTable", "I", AccessFlags = 25)]
				public const int FunctionReturnsTable = 2;
		}

		/// <summary>
		///  <para>An interface to a JDBC driver. Instances are returned by DriverManager.</para> <para>The JDBC driver uses URLs to specify the location of specific data. URL format typically takes the form " @code xxxx:yyyy:SpecificData @endcode ", where "@code xxxx:yyyy @endcode " is referred to as the  <b>subprotocol</b> and is normally the same for all of a particular driver. " @code SpecificData @endcode " is a string which identifies the particular data source that the driver should use.</para> <para> <para>DriverManager </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Driver
		/// </java-name>
		[Dot42.DexImport("java/sql/Driver", AccessFlags = 1537)]
		public partial interface IDriver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns whether the driver thinks that it can open a connection to the given URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the driver thinks that is can open a connection to the supplied URL, <c>false </c> otherwise. Typically, the driver will respond <c>true </c> if it thinks that it can handle the subprotocol specified by the driver. </para>
				/// </returns>
				/// <java-name>
				/// acceptsURL
				/// </java-name>
				[Dot42.DexImport("acceptsURL", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool AcceptsURL(string url) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Attempts to make a database connection to a data source specified by a supplied URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", AccessFlags = 1025)]
				global::Java.Sql.IConnection Connect(string url, global::Java.Util.Properties info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets information about possible properties for this driver. </para> <para>This method is intended to provide a listing of possible properties that the client of the driver must supply in order to establish a connection to a database. Note that the returned array of properties may change depending on the supplied list of property values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of <c>DriverPropertyInfo </c> records which provide details on which additional properties are required (in addition to those supplied in the <c>info </c> parameter) in order to connect to the database. </para>
				/// </returns>
				/// <java-name>
				/// getPropertyInfo
				/// </java-name>
				[Dot42.DexImport("getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;", AccessFlags = 1025)]
				global::Java.Sql.DriverPropertyInfo[] GetPropertyInfo(string url, global::Java.Util.Properties info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reports whether this driver is a genuine JDBC CompliantTM driver. The driver may only return <c>true </c> if it passes all the JDBC compliance tests. </para> <para>A driver may not be fully compliant if the underlying database has limited functionality.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the driver is fully JDBC compliant, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// jdbcCompliant
				/// </java-name>
				[Dot42.DexImport("jdbcCompliant", "()Z", AccessFlags = 1025)]
				bool JdbcCompliant() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the driver's major version number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the major version number of the driver - typically starts at 1. </para>
				/// </returns>
				/// <java-name>
				/// getMajorVersion
				/// </java-name>
				int MajorVersion
				{
						[Dot42.DexImport("getMajorVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the driver's minor version number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the minor version number of the driver - typically starts at 0. </para>
				/// </returns>
				/// <java-name>
				/// getMinorVersion
				/// </java-name>
				int MinorVersion
				{
						[Dot42.DexImport("getMinorVersion", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/sql/NClob
		/// </java-name>
		[Dot42.DexImport("java/sql/NClob", AccessFlags = 1537)]
		public partial interface INClob : global::Java.Sql.IClob
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>An interface used to get information about the types and properties of parameters in a <c>PreparedStatement </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/ParameterMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ParameterMetaData", AccessFlags = 1537)]
		public partial interface IParameterMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Gets the fully-qualified name of the Java class which should be passed as a parameter to the method <c>PreparedStatement.setObject </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully qualified Java class name of the parameter with the specified index. This class name is used for custom mapping between SQL types and Java objects. </para>
				/// </returns>
				/// <java-name>
				/// getParameterClassName
				/// </java-name>
				[Dot42.DexImport("getParameterClassName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameterClassName(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the mode of the specified parameter. Can be one of:  <ul> <li> <para>ParameterMetaData.parameterModeIn </para></li> <li> <para>ParameterMetaData.parameterModeOut </para></li> <li> <para>ParameterMetaData.parameterModeInOut </para></li> <li> <para>ParameterMetaData.parameterModeUnknown </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameter's mode. </para>
				/// </returns>
				/// <java-name>
				/// getParameterMode
				/// </java-name>
				[Dot42.DexImport("getParameterMode", "(I)I", AccessFlags = 1025)]
				int GetParameterMode(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the SQL type of a specified parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SQL type of the parameter as defined in <c>java.sql.Types </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParameterType
				/// </java-name>
				[Dot42.DexImport("getParameterType", "(I)I", AccessFlags = 1025)]
				int GetParameterType(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the database-specific type name of a specified parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type name for the parameter as used by the database. A fully-qualified name is returned if the parameter is a  <b>User Defined Type</b> (UDT). </para>
				/// </returns>
				/// <java-name>
				/// getParameterTypeName
				/// </java-name>
				[Dot42.DexImport("getParameterTypeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameterTypeName(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of decimal digits for a specified parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of decimal digits ("the precision") for the parameter.  <c>0 </c> if the parameter is not a numeric type. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "(I)I", AccessFlags = 1025)]
				int GetPrecision(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of digits after the decimal point for a specified parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of digits after the decimal point ("the scale") for the parameter. <c>0 </c> if the parameter is not a numeric type. </para>
				/// </returns>
				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "(I)I", AccessFlags = 1025)]
				int GetScale(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets whether <c>null </c> values are allowed for the specified parameter. The returned value is one of:  <ul> <li> <para>ParameterMetaData.parameterNoNulls </para></li> <li> <para>ParameterMetaData.parameterNullable </para></li> <li> <para>ParameterMetaData.parameterNullableUnknown </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the int code indicating the nullability of the parameter. </para>
				/// </returns>
				/// <java-name>
				/// isNullable
				/// </java-name>
				[Dot42.DexImport("isNullable", "(I)I", AccessFlags = 1025)]
				int IsNullable(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets whether values for the specified parameter can be signed numbers.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if values can be signed numbers for this parameter,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSigned
				/// </java-name>
				[Dot42.DexImport("isSigned", "(I)Z", AccessFlags = 1025)]
				bool IsSigned(int paramIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of parameters in the <c>PreparedStatement </c> for which this <c>ParameterMetaData </c> contains information.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameterCount
				/// </java-name>
				int ParameterCount
				{
						[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An interface used to get information about the types and properties of parameters in a <c>PreparedStatement </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/ParameterMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ParameterMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IParameterMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates that the parameter mode is <c>IN </c> . </para>        
				/// </summary>
				/// <java-name>
				/// parameterModeIn
				/// </java-name>
				[Dot42.DexImport("parameterModeIn", "I", AccessFlags = 25)]
				public const int ParameterModeIn = 1;
				/// <summary>
				///  <para>Indicates that the parameter mode is <c>INOUT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// parameterModeInOut
				/// </java-name>
				[Dot42.DexImport("parameterModeInOut", "I", AccessFlags = 25)]
				public const int ParameterModeInOut = 2;
				/// <summary>
				///  <para>Indicates that the parameter mode is <c>OUT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// parameterModeOut
				/// </java-name>
				[Dot42.DexImport("parameterModeOut", "I", AccessFlags = 25)]
				public const int ParameterModeOut = 4;
				/// <summary>
				///  <para>Indicates that the parameter mode is not known. </para>        
				/// </summary>
				/// <java-name>
				/// parameterModeUnknown
				/// </java-name>
				[Dot42.DexImport("parameterModeUnknown", "I", AccessFlags = 25)]
				public const int ParameterModeUnknown = 0;
				/// <summary>
				///  <para>Indicates that a parameter is not permitted to be <c>NULL </c> . </para>        
				/// </summary>
				/// <java-name>
				/// parameterNoNulls
				/// </java-name>
				[Dot42.DexImport("parameterNoNulls", "I", AccessFlags = 25)]
				public const int ParameterNoNulls = 0;
				/// <summary>
				///  <para>Indicates that a parameter is permitted to be <c>NULL </c> . </para>        
				/// </summary>
				/// <java-name>
				/// parameterNullable
				/// </java-name>
				[Dot42.DexImport("parameterNullable", "I", AccessFlags = 25)]
				public const int ParameterNullable = 1;
				/// <summary>
				///  <para>Indicates that whether a parameter is allowed to be <c>null </c> or not is not known. </para>        
				/// </summary>
				/// <java-name>
				/// parameterNullableUnknown
				/// </java-name>
				[Dot42.DexImport("parameterNullableUnknown", "I", AccessFlags = 25)]
				public const int ParameterNullableUnknown = 2;
		}

		/// <summary>
		///  <para>An interface for a precompiled SQL Statement. </para> <para>An SQL Statement is put into a <c>PreparedStatement </c> and is precompiled so that it can be executed efficiently multiple times. </para> <para>Setter methods are supplied in the <c>PreparedStatement </c> interface for the setting of <c>IN </c> parameters for the statement. The setter method used for each <c>IN </c> parameter must match the parameter's type. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/PreparedStatement
		/// </java-name>
		[Dot42.DexImport("java/sql/PreparedStatement", AccessFlags = 1537)]
		public partial interface IPreparedStatement : global::Java.Sql.IStatement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Add a set of parameters to the <c>PreparedStatement </c> 's command batch.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "()V", AccessFlags = 1025)]
				void AddBatch() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Clear the current parameter values. </para> <para>Typically, parameter values are retained for multiple executions of the  <c>Statement </c> . Setting a parameter value replaces the previous value. This method clears the values for all parameters, releasing all resources used by those parameters.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				void ClearParameters() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the SQL statement in this <c>PreparedStatement </c> . </para> <para>A <c>PreparedStatement </c> may return multiple results. The execute method executes the <c>PreparedStatement </c> and returns a flag indicating the kind of result produced by the action. The methods  <c>getResultSet </c> or <c>getUpdateCount </c> are used to retrieve the first result, and the second and subsequent results are retrieved with <c>getMoreResults </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the result of the execution is a <c>ResultSet </c> , <c>false </c> if there is no result or if the result is an update count. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()Z", AccessFlags = 1025)]
				bool Execute() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the SQL query in the <c>PreparedStatement </c> and returns the  <c>ResultSet </c> generated by the query.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>ResultSet </c> generated by the query, never <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// executeQuery
				/// </java-name>
				[Dot42.DexImport("executeQuery", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet ExecuteQuery() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Invokes the SQL command contained within the prepared statement. This must be <c>INSERT </c> , <c>UPDATE </c> , <c>DELETE </c> , or a command that returns nothing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of affected rows for <c>INSERT </c> , <c>UPDATE </c> or <c>DELETE </c> statements, <c>0 </c> for statements that return nothing. </para>
				/// </returns>
				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "()I", AccessFlags = 1025)]
				int ExecuteUpdate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the supplied <c>Array </c> .</para> <para> <para>Array </para></para>        
				/// </summary>
				/// <java-name>
				/// setArray
				/// </java-name>
				[Dot42.DexImport("setArray", "(ILjava/sql/Array;)V", AccessFlags = 1025)]
				void SetArray(int parameterIndex, global::Java.Sql.IArray theArray) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the content of a supplied  <c>InputStream </c> , which has a specified number of bytes. </para> <para>This is a good method for setting an SQL <c>LONGVARCHAR </c> parameter where the length of the data is large. Data is read from the <c>InputStream </c> until end-of-file is reached or the specified number of bytes is copied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetAsciiStream(int parameterIndex, global::Java.IO.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.math.BigDecimal </c> value.</para> <para> <para>java.math.BigDecimal </para></para>        
				/// </summary>
				/// <java-name>
				/// setBigDecimal
				/// </java-name>
				[Dot42.DexImport("setBigDecimal", "(ILjava/math/BigDecimal;)V", AccessFlags = 1025)]
				void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal theBigDecimal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the content of a supplied binary <c>InputStream </c> , which has a specified number of bytes. </para> <para>Use this method when a large amount of data needs to be set into a  <c>LONGVARBINARY </c> parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetBinaryStream(int parameterIndex, global::Java.IO.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the given <c>Blob </c> object.</para> <para> <para>Blob </para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/sql/Blob;)V", AccessFlags = 1025)]
				void SetBlob(int parameterIndex, global::Java.Sql.IBlob theBlob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>boolean </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(IZ)V", AccessFlags = 1025)]
				void SetBoolean(int parameterIndex, bool theBoolean) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>byte </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(IB)V", AccessFlags = 1025)]
				void SetByte(int parameterIndex, byte theByte) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied array of bytes. The array is mapped to a <c>VARBINARY </c> or <c>LONGVARBINARY </c> in the database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBytes
				/// </java-name>
				[Dot42.DexImport("setBytes", "(I[B)V", AccessFlags = 1025)]
				void SetBytes(int parameterIndex, byte[] theBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the character content of a  <c>Reader </c> object, with the specified length of character data. </para> <para>Data is read from the <c>Reader </c> until end-of-file is reached or the specified number of characters are copied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void SetCharacterStream(int parameterIndex, global::Java.IO.Reader reader, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the given <c>Clob </c> object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/sql/Clob;)V", AccessFlags = 1025)]
				void SetClob(int parameterIndex, global::Java.Sql.IClob theClob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Date </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;)V", AccessFlags = 1025)]
				void SetDate(int parameterIndex, global::Java.Sql.Date theDate) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Date </c> value, using a supplied <c>Calendar </c> to map the Date. The <c>Calendar </c> allows the application to control the timezone used to compute the SQL <c>DATE </c> in the database - without the supplied  <c>Calendar </c> , the driver uses the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Date </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetDate(int parameterIndex, global::Java.Sql.Date theDate, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>double </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(ID)V", AccessFlags = 1025)]
				void SetDouble(int parameterIndex, double theDouble) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to to a supplied <c>float </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(IF)V", AccessFlags = 1025)]
				void SetFloat(int parameterIndex, float theFloat) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>int </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(II)V", AccessFlags = 1025)]
				void SetInt(int parameterIndex, int theInt) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>long </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(IJ)V", AccessFlags = 1025)]
				void SetLong(int parameterIndex, long theLong) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to SQL <c>NULL </c> . Don't use this version of <c>setNull </c> for  <b>User Defined Types</b> (UDT) or for REF type parameters.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(II)V", AccessFlags = 1025)]
				void SetNull(int parameterIndex, int sqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to SQL <c>NULL </c> . This version of <c>setNull </c> should be used for  <b>User Defined Types</b> (UDTs) and also REF types. UDTs can be <c>STRUCT </c> , <c>DISTINCT </c> , <c>JAVA_OBJECT </c> and named array types. </para> <para>Applications must provide the SQL type code and also a fully qualified SQL type name when supplying a <c>NULL </c> UDT or REF. For a UDT, the type name is the type name of the parameter itself, but for a REF parameter the type name is the type name of the referenced type.</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <java-name>
				/// setNull
				/// </java-name>
				[Dot42.DexImport("setNull", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNull(int paramIndex, int sqlType, string typeName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. </para> <para>There is a standard mapping from Java types to SQL types, defined in the JDBC specification. The passed object is then transformed into the appropriate SQL type, and then transferred to the database. <c>setObject </c> can be used to pass abstract data types unique to the database, by using a JDBC driver specific Java type. If the object's class implements the interface <c>SQLData </c> , the JDBC driver calls  <c>SQLData.writeSQL </c> to write it to the SQL data stream. If the object's class implements <c>Ref </c> , <c>Blob </c> , <c>Clob </c> ,  <c>Struct </c> , or <c>Array </c> , the driver passes it to the database as a value of the corresponding SQL type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;)V", AccessFlags = 1025)]
				void SetObject(int parameterIndex, object theObject) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. </para> <para>The object is converted to the given <c>targetSqlType </c> before it is sent to the database. If the object has a custom mapping (its class implements the interface <c>SQLData </c> ), the JDBC driver will call the method  <c>SQLData.writeSQL </c> to write it to the SQL data stream. If the object's class implements <c>Ref </c> , <c>Blob </c> , <c>Clob </c> ,  <c>Struct </c> , or <c>Array </c> , the driver will pass it to the database in the form of the relevant SQL type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;I)V", AccessFlags = 1025)]
				void SetObject(int parameterIndex, object theObject, int targetSqlType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter using a supplied object. </para> <para>The object is converted to the given <c>targetSqlType </c> before it is sent to the database. If the object has a custom mapping (its class implements the interface <c>SQLData </c> ), the JDBC driver will call the method  <c>SQLData.writeSQL </c> to write it to the SQL data stream. If the object's class implements <c>Ref </c> , <c>Blob </c> , <c>Clob </c> ,  <c>Struct </c> , or <c>Array </c> , the driver will pass it to the database in the form of the relevant SQL type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setObject
				/// </java-name>
				[Dot42.DexImport("setObject", "(ILjava/lang/Object;II)V", AccessFlags = 1025)]
				void SetObject(int parameterIndex, object theObject, int targetSqlType, int scale) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>REF(&lt;structured-type&gt;) </c> value. This is stored as an SQL <c>REF </c> .</para> <para> <para>Ref </para></para>        
				/// </summary>
				/// <java-name>
				/// setRef
				/// </java-name>
				[Dot42.DexImport("setRef", "(ILjava/sql/Ref;)V", AccessFlags = 1025)]
				void SetRef(int parameterIndex, global::Java.Sql.IRef theRef) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>short </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(IS)V", AccessFlags = 1025)]
				void SetShort(int parameterIndex, short theShort) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetString(int parameterIndex, string theString) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Time </c> value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;)V", AccessFlags = 1025)]
				void SetTime(int parameterIndex, global::Java.Sql.Time theTime) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Time </c> value, using a supplied <c>Calendar </c> . </para> <para>The driver uses the supplied <c>Calendar </c> to create the SQL <c>TIME </c> value, which allows it to use a custom timezone - otherwise the driver uses the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Time </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTime(int parameterIndex, global::Java.Sql.Time theTime, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied java.sql.Timestamp value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;)V", AccessFlags = 1025)]
				void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.Timestamp </c> value, using the supplied <c>Calendar </c> . </para> <para>The driver uses the supplied <c>Calendar </c> to create the SQL <c>TIMESTAMP </c> value, which allows it to use a custom timezone - otherwise the driver uses the VM defaults. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para> <para>Timestamp </para> <para>java.util.Calendar </para></para>        
				/// </summary>
				/// <java-name>
				/// setTimestamp
				/// </java-name>
				[Dot42.DexImport("setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", AccessFlags = 1025)]
				void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp theTimestamp, global::Java.Util.Calendar cal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the characters from a supplied  <c>InputStream </c> , with a specified number of bytes.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use setCharacterStream(int, Reader, int) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setUnicodeStream
				/// </java-name>
				[Dot42.DexImport("setUnicodeStream", "(ILjava/io/InputStream;I)V", AccessFlags = 1025)]
				void SetUnicodeStream(int parameterIndex, global::Java.IO.InputStream theInputStream, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.net.URL </c> .</para> <para> <para>URL </para></para>        
				/// </summary>
				/// <java-name>
				/// setURL
				/// </java-name>
				[Dot42.DexImport("setURL", "(ILjava/net/URL;)V", AccessFlags = 1025)]
				void SetURL(int parameterIndex, global::Java.Net.URL theURL) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied <c>java.sql.RowId </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRowId
				/// </java-name>
				[Dot42.DexImport("setRowId", "(ILjava/sql/RowId;)V", AccessFlags = 1025)]
				void SetRowId(int parameterIndex, global::Java.Sql.IRowId theRowId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to a supplied string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNString
				/// </java-name>
				[Dot42.DexImport("setNString", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetNString(int parameterIndex, string theString) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the next <c>length </c> characters from <c>reader </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNCharacterStream(int parameterIndex, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to <c>value </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/sql/NClob;)V", AccessFlags = 1025)]
				void SetNClob(int parameterIndex, global::Java.Sql.INClob value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the next <c>length </c> characters from <c>reader </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetClob(int parameterIndex, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the next <c>length </c> bytes from <c>inputStream </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBlob(int parameterIndex, global::Java.IO.InputStream inputStream, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the next <c>length </c> characters from <c>reader </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetNClob(int parameterIndex, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the value of <c>xmlObject </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSQLXML
				/// </java-name>
				[Dot42.DexImport("setSQLXML", "(ILjava/sql/SQLXML;)V", AccessFlags = 1025)]
				void SetSQLXML(int parameterIndex, global::Java.Sql.ISQLXML xmlObject) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the content of a supplied  <c>InputStream </c> , which has a specified number of bytes. </para> <para>This is a good method for setting an SQL <c>LONGVARCHAR </c> parameter where the length of the data is large. Data is read from the <c>InputStream </c> until end-of-file is reached or the specified number of bytes is copied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetAsciiStream(int parameterIndex, global::Java.IO.InputStream theInputStream, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the content of a supplied binary <c>InputStream </c> , which has a specified number of bytes. </para> <para>Use this method when a large amount of data needs to be set into a  <c>LONGVARBINARY </c> parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void SetBinaryStream(int parameterIndex, global::Java.IO.InputStream theInputStream, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the character content of a  <c>Reader </c> object, with the specified length of character data. </para> <para>Data is read from the <c>Reader </c> until end-of-file is reached or the specified number of characters are copied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void SetCharacterStream(int parameterIndex, global::Java.IO.Reader reader, long length) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the bytes from <c>inputStream </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAsciiStream
				/// </java-name>
				[Dot42.DexImport("setAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetAsciiStream(int parameterIndex, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the bytes from <c>inputStream </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBinaryStream(int parameterIndex, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the characters from <c>reader </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(int parameterIndex, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to the characters from <c>reader </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNCharacterStream
				/// </java-name>
				[Dot42.DexImport("setNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNCharacterStream(int parameterIndex, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the given <c>Clob </c> object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClob
				/// </java-name>
				[Dot42.DexImport("setClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetClob(int parameterIndex, global::Java.IO.Reader theClob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of a specified parameter to the given <c>Blob </c> object.</para> <para> <para>Blob </para></para>        
				/// </summary>
				/// <java-name>
				/// setBlob
				/// </java-name>
				[Dot42.DexImport("setBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void SetBlob(int parameterIndex, global::Java.IO.InputStream theBlob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the value of the specified parameter to <c>value </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNClob
				/// </java-name>
				[Dot42.DexImport("setNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void SetNClob(int parameterIndex, global::Java.IO.Reader value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>ResultSetMetaData </c> describing the <c>ResultSet </c> that would be produced by execution of the <c>PreparedStatement </c> . </para> <para>It is possible to know the metadata for the <c>ResultSet </c> without executing the <c>PreparedStatement </c> , because the <c>PreparedStatement </c> is precompiled. As a result the metadata can be queried ahead of time without actually executing the statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSetMetaData </c> object with the information about the columns of the <c>ResultSet </c> , if the driver can return a  <c>ResultSetMetaData </c> . <c>null </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getMetaData
				/// </java-name>
				global::Java.Sql.IResultSetMetaData MetaData
				{
						[Dot42.DexImport("getMetaData", "()Ljava/sql/ResultSetMetaData;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets information about the parameters of the <c>PreparedStatement </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ParameterMetaData </c> object which holds information about the number, type, and properties of the parameters of this <c>PreparedStatement </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParameterMetaData
				/// </java-name>
				global::Java.Sql.IParameterMetaData ParameterMetaData
				{
						[Dot42.DexImport("getParameterMetaData", "()Ljava/sql/ParameterMetaData;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface represents an SQL Ref - a data object containing a cursor or pointer to a result table. </para> <para>The data structure identified by an instance of Ref is held in the database, so the data is not necessarily read and converted into a Java object until <c>getObject </c> is called. However, if the database supports the <c>Ref </c> type, it is not typically necessary to get the underlying object before using it in a method call - the <c>Ref </c> object can be used in place of the data structure. </para> <para>A <c>Ref </c> object is stored into the database using the PreparedStatement#setRef(int, Ref) method. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Ref
		/// </java-name>
		[Dot42.DexImport("java/sql/Ref", AccessFlags = 1537)]
		public partial interface IRef
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the associated object and uses the relevant mapping to convert it to a Java type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Java object whose type is defined by the mapping for the SQL structured type. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/util/Map;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)Ljava/lang/Object;")]
				object GetObject(global::Java.Util.IMap<string, global::System.Type> map) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the fully-qualified SQL name of the SQL structured type that this  <c>Ref </c> references.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully qualified name of the SQL structured type. </para>
				/// </returns>
				/// <java-name>
				/// getBaseTypeName
				/// </java-name>
				string BaseTypeName
				{
						[Dot42.DexImport("getBaseTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the SQL structured type instance referenced by this <c>Ref </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Java object whose type is defined by the mapping for the SQL structured type. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				object Object
				{
						[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setObject", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
						set;
				}

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
				global::Java.IO.InputStream GetAsciiStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAsciiStream
				/// </java-name>
				[Dot42.DexImport("getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream GetAsciiStream(string @string) /* MethodBuilder.Create */ ;

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
				global::Java.IO.InputStream GetBinaryStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				[Dot42.DexImport("getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream GetBinaryStream(string @string) /* MethodBuilder.Create */ ;

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
				[Dot42.DexImport("getByte", "(I)B", AccessFlags = 1025)]
				byte GetByte(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1025)]
				byte GetByte(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(I)[B", AccessFlags = 1025)]
				byte[] GetBytes(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				byte[] GetBytes(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(I)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetCharacterStream(string @string) /* MethodBuilder.Create */ ;

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
				/// getUnicodeStream
				/// </java-name>
				[Dot42.DexImport("getUnicodeStream", "(I)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream GetUnicodeStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUnicodeStream
				/// </java-name>
				[Dot42.DexImport("getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream GetUnicodeStream(string @string) /* MethodBuilder.Create */ ;

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
				/// insertRow
				/// </java-name>
				[Dot42.DexImport("insertRow", "()V", AccessFlags = 1025)]
				void InsertRow() /* MethodBuilder.Create */ ;

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
				void UpdateAsciiStream(int int32, global::Java.IO.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.IO.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

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
				void UpdateBinaryStream(int int32, global::Java.IO.InputStream inputStream, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.IO.InputStream inputStream, int int32) /* MethodBuilder.Create */ ;

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
				void UpdateByte(int int32, byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateByte
				/// </java-name>
				[Dot42.DexImport("updateByte", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
				void UpdateByte(string @string, byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBytes
				/// </java-name>
				[Dot42.DexImport("updateBytes", "(I[B)V", AccessFlags = 1025)]
				void UpdateBytes(int int32, byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBytes
				/// </java-name>
				[Dot42.DexImport("updateBytes", "(Ljava/lang/String;[B)V", AccessFlags = 1025)]
				void UpdateBytes(string @string, byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;I)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.IO.Reader reader, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.IO.Reader reader, int int32) /* MethodBuilder.Create */ ;

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
				global::Java.IO.Reader GetNCharacterStream(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNCharacterStream
				/// </java-name>
				[Dot42.DexImport("getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader GetNCharacterStream(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(int int32, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(string @string, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateAsciiStream(int int32, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBinaryStream(int int32, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(ILjava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBlob(int int32, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", AccessFlags = 1025)]
				void UpdateBlob(string @string, global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateClob(int int32, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateClob(string @string, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(ILjava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNClob(int int32, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", AccessFlags = 1025)]
				void UpdateNClob(string @string, global::Java.IO.Reader reader, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(int int32, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNCharacterStream(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateAsciiStream(int int32, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBinaryStream(int int32, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateCharacterStream(int int32, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateAsciiStream
				/// </java-name>
				[Dot42.DexImport("updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateAsciiStream(string @string, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBinaryStream
				/// </java-name>
				[Dot42.DexImport("updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBinaryStream(string @string, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCharacterStream
				/// </java-name>
				[Dot42.DexImport("updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateCharacterStream(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(ILjava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBlob(int int32, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateBlob
				/// </java-name>
				[Dot42.DexImport("updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void UpdateBlob(string @string, global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateClob(int int32, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateClob
				/// </java-name>
				[Dot42.DexImport("updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateClob(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(ILjava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNClob(int int32, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateNClob
				/// </java-name>
				[Dot42.DexImport("updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", AccessFlags = 1025)]
				void UpdateNClob(string @string, global::Java.IO.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConcurrency
				/// </java-name>
				int Concurrency
				{
						[Dot42.DexImport("getConcurrency", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getCursorName
				/// </java-name>
				string CursorName
				{
						[Dot42.DexImport("getCursorName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFetchDirection
				/// </java-name>
				int FetchDirection
				{
						[Dot42.DexImport("getFetchDirection", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFetchDirection", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getFetchSize
				/// </java-name>
				int FetchSize
				{
						[Dot42.DexImport("getFetchSize", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFetchSize", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMetaData
				/// </java-name>
				global::Java.Sql.IResultSetMetaData MetaData
				{
						[Dot42.DexImport("getMetaData", "()Ljava/sql/ResultSetMetaData;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRow
				/// </java-name>
				int Row
				{
						[Dot42.DexImport("getRow", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getStatement
				/// </java-name>
				global::Java.Sql.IStatement Statement
				{
						[Dot42.DexImport("getStatement", "()Ljava/sql/Statement;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getType
				/// </java-name>
				int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getWarnings
				/// </java-name>
				global::Java.Sql.SQLWarning Warnings
				{
						[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				bool IsAfterLast
				{
						[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				bool IsBeforeFirst
				{
						[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isFirst
				/// </java-name>
				bool IsFirst
				{
						[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isLast
				/// </java-name>
				bool IsLast
				{
						[Dot42.DexImport("isLast", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getHoldability
				/// </java-name>
				int Holdability
				{
						[Dot42.DexImport("getHoldability", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
						get;
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

		/// <summary>
		///  <para>Provides information about the columns returned in a <c>ResultSet </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/ResultSetMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSetMetaData", AccessFlags = 1537)]
		public partial interface IResultSetMetaData : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the title of an indexed column's catalog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the catalog title. </para>
				/// </returns>
				/// <java-name>
				/// getCatalogName
				/// </java-name>
				[Dot42.DexImport("getCatalogName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetCatalogName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the fully-qualified type of the class that is produced when invoking <c>ResultSet.getObject </c> to recover this column's value.</para> <para> <para>ResultSet::getObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully-qualified class name. </para>
				/// </returns>
				/// <java-name>
				/// getColumnClassName
				/// </java-name>
				[Dot42.DexImport("getColumnClassName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnClassName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the indexed column's standard maximum width, expressed in number of characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column's max width. </para>
				/// </returns>
				/// <java-name>
				/// getColumnDisplaySize
				/// </java-name>
				[Dot42.DexImport("getColumnDisplaySize", "(I)I", AccessFlags = 1025)]
				int GetColumnDisplaySize(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a recommended title for the indexed column, to be used when the title needs to be displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column's title. </para>
				/// </returns>
				/// <java-name>
				/// getColumnLabel
				/// </java-name>
				[Dot42.DexImport("getColumnLabel", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnLabel(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the title of the indexed column.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column title. </para>
				/// </returns>
				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the type of the indexed column as SQL type code.</para> <para> <para>Types </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column type code. </para>
				/// </returns>
				/// <java-name>
				/// getColumnType
				/// </java-name>
				[Dot42.DexImport("getColumnType", "(I)I", AccessFlags = 1025)]
				int GetColumnType(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the type name of the indexed column.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type name. </para>
				/// </returns>
				/// <java-name>
				/// getColumnTypeName
				/// </java-name>
				[Dot42.DexImport("getColumnTypeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnTypeName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the decimal precision of the indexed column.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "(I)I", AccessFlags = 1025)]
				int GetPrecision(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of digits to the right of the decimal point of the indexed column.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of decimal places. </para>
				/// </returns>
				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "(I)I", AccessFlags = 1025)]
				int GetScale(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the name of the indexed columns schema.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the columns schema. </para>
				/// </returns>
				/// <java-name>
				/// getSchemaName
				/// </java-name>
				[Dot42.DexImport("getSchemaName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetSchemaName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the title of the indexed columns table.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the table title. </para>
				/// </returns>
				/// <java-name>
				/// getTableName
				/// </java-name>
				[Dot42.DexImport("getTableName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetTableName(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether the indexed column is automatically incremented and is therefore read-only.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if it is automatically numbered, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAutoIncrement
				/// </java-name>
				[Dot42.DexImport("isAutoIncrement", "(I)Z", AccessFlags = 1025)]
				bool IsAutoIncrement(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether the case of the indexed column is important.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if case matters, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isCaseSensitive
				/// </java-name>
				[Dot42.DexImport("isCaseSensitive", "(I)Z", AccessFlags = 1025)]
				bool IsCaseSensitive(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether the indexed column contains a monetary amount.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if it is a monetary value, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isCurrency
				/// </java-name>
				[Dot42.DexImport("isCurrency", "(I)Z", AccessFlags = 1025)]
				bool IsCurrency(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether writing to the indexed column is guaranteed to be successful.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the write is guaranteed, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDefinitelyWritable
				/// </java-name>
				[Dot42.DexImport("isDefinitelyWritable", "(I)Z", AccessFlags = 1025)]
				bool IsDefinitelyWritable(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether the indexed column is nullable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if it is nullable, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNullable
				/// </java-name>
				[Dot42.DexImport("isNullable", "(I)I", AccessFlags = 1025)]
				int IsNullable(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether writing to the indexed column is guaranteed to be unsuccessful.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the column is read-only, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "(I)Z", AccessFlags = 1025)]
				bool IsReadOnly(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether the indexed column is searchable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the indexed column is searchable, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSearchable
				/// </java-name>
				[Dot42.DexImport("isSearchable", "(I)Z", AccessFlags = 1025)]
				bool IsSearchable(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether the values contained in the indexed column are signed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if they are signed, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSigned
				/// </java-name>
				[Dot42.DexImport("isSigned", "(I)Z", AccessFlags = 1025)]
				bool IsSigned(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an indication of whether writing to the indexed column is possible.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if it is possible to write, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isWritable
				/// </java-name>
				[Dot42.DexImport("isWritable", "(I)Z", AccessFlags = 1025)]
				bool IsWritable(int column) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns number of columns contained in the associated result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column count. </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Provides information about the columns returned in a <c>ResultSet </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/ResultSetMetaData
		/// </java-name>
		[Dot42.DexImport("java/sql/ResultSetMetaData", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IResultSetMetaDataConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates that a column cannot contain <c>NULL </c> values. </para>        
				/// </summary>
				/// <java-name>
				/// columnNoNulls
				/// </java-name>
				[Dot42.DexImport("columnNoNulls", "I", AccessFlags = 25)]
				public const int ColumnNoNulls = 0;
				/// <summary>
				///  <para>Indicates that a column can contain <c>NULL </c> values. </para>        
				/// </summary>
				/// <java-name>
				/// columnNullable
				/// </java-name>
				[Dot42.DexImport("columnNullable", "I", AccessFlags = 25)]
				public const int ColumnNullable = 1;
				/// <summary>
				///  <para>Indicates that it is unknown whether a column can contain <c>NULL </c> s or not. </para>        
				/// </summary>
				/// <java-name>
				/// columnNullableUnknown
				/// </java-name>
				[Dot42.DexImport("columnNullableUnknown", "I", AccessFlags = 25)]
				public const int ColumnNullableUnknown = 2;
		}

		/// <summary>
		///  <para>Maps SQL's ROWID type into Java.  <para>1.6 </para></para>    
		/// </summary>
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
				bool Equals(object obj) /* MethodBuilder.Create */ ;

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

				/// <summary>
				///  <para>Returns an array of bytes representing the value of the corresponding SQL ROWID. </para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				byte[] Bytes
				{
						[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A savepoint is an instant during the current transaction that can be utilized by a rollback via the Connection#rollback command. Rolling back to a particular savepoint means that all changes that occurred after that savepoint are undone. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Savepoint
		/// </java-name>
		[Dot42.DexImport("java/sql/Savepoint", AccessFlags = 1537)]
		public partial interface ISavepoint
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the constructed ID for this savepoint.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID for this savepoint. </para>
				/// </returns>
				/// <java-name>
				/// getSavepointId
				/// </java-name>
				int SavepointId
				{
						[Dot42.DexImport("getSavepointId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name for this savepoint.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this savepoint. </para>
				/// </returns>
				/// <java-name>
				/// getSavepointName
				/// </java-name>
				string SavepointName
				{
						[Dot42.DexImport("getSavepointName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An interface for the custom mapping of an SQL  <b>User Defined Type</b> (UDT) to a Java class. The Java class object is added to the connection's type map paired with the SQL name of the corresponding UDT. </para> <para>Usually within an implementation of <c>SQLData </c> , there is a corresponding field for every attribute of an SQL type, but only one field, if the type is SQL <c>DISTINCT </c> . When the UDT is returned within a <c>ResultSet </c> , it is accessed with the ResultSet#getObject method and is returned as an object which is an instance of the class defined by the <c>SQLData </c> mapping. The application can use this object just like any other Java object and can store changes back into the database using the PreparedStatement#setObject method which performs the reverse mapping into the SQL <c>UDT </c> . </para> <para>Normally the implementation of a custom mapping is generated by a tool requiring the name of the SQL <c>UDT </c> , the name of the class which it is going to be mapped to, and the field names to which the UDT attributes are mapped. The tool can then implement the <c>SQLData </c> , <c>readSQL </c> , and <c>writeSQL </c> methods. <c>readSQL </c> reads attributes from an <c>SQLInput </c> object, and <c>writeSQL </c> writes them. This is done via <c>SQLInput </c> and <c>SQLOutput </c> method calls respectively. </para> <para>Ordinarily an application would not call <c>SQLData </c> methods directly. Similarly <c>SQLInput </c> and <c>SQLOutput </c> methods are not usually called directly. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLData
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLData", AccessFlags = 1537)]
		public partial interface ISQLData
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Reads data from the database into this object. This method follows these steps: </para> <para> <ul> <li> <para>Utilize the passed input stream to read the attributes or entries of the SQL type </para></li> <li> <para>This is carried out by reading each entry from the input stream, ordered as they are in the SQL definition. </para></li> <li> <para>Assign the data to the appropriate fields or elements. This is done by calling the relevant reader method for the type involved (e.g. <c>SQLInput.readString </c> , <c>SQLInputreadBigDecimal </c> ). If the type is distinct, then read its only data entry. For structured types, read every entry. </para></li></ul></para> <para>The supplied input stream is typically initialized by the calling JDBC driver with the type map before <c>readSQL </c> is called.</para> <para> <para>SQLInput </para></para>        
				/// </summary>
				/// <java-name>
				/// readSQL
				/// </java-name>
				[Dot42.DexImport("readSQL", "(Ljava/sql/SQLInput;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ReadSQL(global::Java.Sql.ISQLInput stream, string typeName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the object to a supplied <c>SQLOutput </c> data stream, writing it out as an SQL value to the data source. </para> <para>This method follows the following steps:  <ul> <li> <para>Write each attribute of the SQL type to the output stream. </para></li> <li> <para>Write each item by calling a method on the output stream, in the order they appear in the SQL definition of the type. Use the appropriate  <c>SQLOutput </c> methods (e.g. <c>writeInt </c> , <c>writeString </c> ). Write a single data element for a distinct type. For a structured type, write a value for each attribute of the the SQL type. </para></li></ul></para> <para> <para>SQLOutput </para></para>        
				/// </summary>
				/// <java-name>
				/// writeSQL
				/// </java-name>
				[Dot42.DexImport("writeSQL", "(Ljava/sql/SQLOutput;)V", AccessFlags = 1025)]
				void WriteSQL(global::Java.Sql.ISQLOutput stream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the SQL name of the  <b>User Defined Type</b> (UDT) that this object represents. This method, usually invoked by the JDBC driver, retrieves the name of the UDT instance associated with this <c>SQLData </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string with UDT type name for this object mapping, passed to  <c>readSQL </c> when the object was created. </para>
				/// </returns>
				/// <java-name>
				/// getSQLTypeName
				/// </java-name>
				string SQLTypeName
				{
						[Dot42.DexImport("getSQLTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The <c>SQLInput </c> interface defines operations which apply to a type of input stream which carries a series of values representing an instance of an SQL structured type or SQL distinct type. </para> <para>This interface is used to define custom mappings of SQL  <b>User Defined Types</b> (UDTs) to Java classes. It is used by JDBC drivers, therefore application programmers do not normally use the <c>SQLInput </c> methods directly. Reader methods such as <c>readLong </c> and <c>readBytes </c> provide means to read values from an <c>SQLInput </c> stream. </para> <para>When the <c>getObject </c> method is called with an object which implements the <c>SQLData </c> interface, the JDBC driver determines the SQL type of the UDT being mapped by calling the <c>SQLData.getSQLType </c> method. The driver creates an instance of an <c>SQLInput </c> stream, filling the stream with the attributes of the UDT. The <c>SQLInput </c> stream is passed to the  <c>SQLData.readSQL </c> method which then calls the <c>SQLInput </c> reader methods to read the attributes.</para> <para> <para>SQLData </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLInput
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLInput", AccessFlags = 1537)]
		public partial interface ISQLInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>String </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute. <c>null </c> if the value is SQL <c>NULL </c> .</para>
				/// </returns>
				/// <java-name>
				/// readString
				/// </java-name>
				[Dot42.DexImport("readString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadString() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>boolean </c> </para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>boolean </c> . <c>false </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1025)]
				bool ReadBoolean() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>byte </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>byte </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1025)]
				byte ReadByte() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>short </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>short </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1025)]
				short ReadShort() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of an <c>int </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as an <c>int </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1025)]
				int ReadInt() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>long </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>long </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1025)]
				long ReadLong() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>float </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>float </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1025)]
				float ReadFloat() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>double </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>double </c> . 0 if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1025)]
				double ReadDouble() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.math.BigDecimal </c> .</para> <para> <para>java.math.BigDecimal </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the attribute as a <c>java.math.BigDecimal </c> . <c>null </c> if the read returns SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readBigDecimal
				/// </java-name>
				[Dot42.DexImport("readBigDecimal", "()Ljava/math/BigDecimal;", AccessFlags = 1025)]
				global::Java.Math.BigDecimal ReadBigDecimal() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a byte array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the attribute as a byte array. <c>null </c> if the read returns SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "()[B", AccessFlags = 1025)]
				byte[] ReadBytes() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Date </c> .</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.Date </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readDate
				/// </java-name>
				[Dot42.DexImport("readDate", "()Ljava/sql/Date;", AccessFlags = 1025)]
				global::Java.Sql.Date ReadDate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Time </c> .</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the attribute as a <c>java.sql.Time </c> . <c>null </c> if the read returns SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readTime
				/// </java-name>
				[Dot42.DexImport("readTime", "()Ljava/sql/Time;", AccessFlags = 1025)]
				global::Java.Sql.Time ReadTime() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Timestamp </c> .</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the attribute as a <c>java.sql.Timestamp </c> . <c>null </c> if the read returns SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readTimestamp
				/// </java-name>
				[Dot42.DexImport("readTimestamp", "()Ljava/sql/Timestamp;", AccessFlags = 1025)]
				global::Java.Sql.Timestamp ReadTimestamp() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a Unicode character stream embodied as a <c>java.io.Reader </c> .</para> <para> <para>java.io.Reader </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.io.Reader </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readCharacterStream
				/// </java-name>
				[Dot42.DexImport("readCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.IO.Reader ReadCharacterStream() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of an ASCII character stream embodied as a <c>java.io.InputStream </c> .</para> <para> <para>java.io.InputStream </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.io.InputStream </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readAsciiStream
				/// </java-name>
				[Dot42.DexImport("readAsciiStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream ReadAsciiStream() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a stream of bytes embodied as a <c>java.io.InputStream </c> .</para> <para> <para>java.io.InputStream </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.io.InputStream </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readBinaryStream
				/// </java-name>
				[Dot42.DexImport("readBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.IO.InputStream ReadBinaryStream() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.lang.Object </c> . </para> <para>The type of the <c>Object </c> returned is determined by the type mapping for this JDBC driver, including any customized mappings, if present. A type map is given to the <c>SQLInput </c> by the JDBC driver before the  <c>SQLInput </c> is given to the application. </para> <para>If the attribute is an SQL structured or distinct type, its SQL type is determined. If the stream's type map contains an element for that SQL type, the driver creates an object for the relevant type and invokes the method <c>SQLData.readSQL </c> on it, which reads supplementary data from the stream using whichever protocol is defined for that method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as an Object. <c>null </c> if the value is SQL  <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object ReadObject() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Ref </c> .</para> <para> <para>Ref </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.Ref </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readRef
				/// </java-name>
				[Dot42.DexImport("readRef", "()Ljava/sql/Ref;", AccessFlags = 1025)]
				global::Java.Sql.IRef ReadRef() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Blob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.Blob </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readBlob
				/// </java-name>
				[Dot42.DexImport("readBlob", "()Ljava/sql/Blob;", AccessFlags = 1025)]
				global::Java.Sql.IBlob ReadBlob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Clob </c> .</para> <para> <para>Clob </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.Clob </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readClob
				/// </java-name>
				[Dot42.DexImport("readClob", "()Ljava/sql/Clob;", AccessFlags = 1025)]
				global::Java.Sql.IClob ReadClob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.Array </c> .</para> <para> <para>Array </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as an <c>Array </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readArray
				/// </java-name>
				[Dot42.DexImport("readArray", "()Ljava/sql/Array;", AccessFlags = 1025)]
				global::Java.Sql.IArray ReadArray() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reports whether the last value read was SQL <c>NULL </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the last value read was SQL <c>NULL </c> , <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// wasNull
				/// </java-name>
				[Dot42.DexImport("wasNull", "()Z", AccessFlags = 1025)]
				bool WasNull() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads the next attribute in the stream (SQL DATALINK value) and returns it as a <c>java.net.URL </c> object.</para> <para> <para>java.net.URL </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.net.URL </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readURL
				/// </java-name>
				[Dot42.DexImport("readURL", "()Ljava/net/URL;", AccessFlags = 1025)]
				global::Java.Net.URL ReadURL() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.NClob </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.NClob </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readNClob
				/// </java-name>
				[Dot42.DexImport("readNClob", "()Ljava/sql/NClob;", AccessFlags = 1025)]
				global::Java.Sql.INClob ReadNClob() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.lang.String </c> . Used for the NCHAR, NVARCHAR and LONGNVARCHAR types. See readString otherwise.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.lang.String </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readNString
				/// </java-name>
				[Dot42.DexImport("readNString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadNString() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.SQLXML </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.SQLXML </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readSQLXML
				/// </java-name>
				[Dot42.DexImport("readSQLXML", "()Ljava/sql/SQLXML;", AccessFlags = 1025)]
				global::Java.Sql.ISQLXML ReadSQLXML() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the next attribute in the stream in the form of a <c>java.sql.RowId </c> . Used for the ROWID type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next attribute as a <c>java.sql.RowId </c> . <c>null </c> if the value is SQL <c>NULL </c> . </para>
				/// </returns>
				/// <java-name>
				/// readRowId
				/// </java-name>
				[Dot42.DexImport("readRowId", "()Ljava/sql/RowId;", AccessFlags = 1025)]
				global::Java.Sql.IRowId ReadRowId() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The interface for an output stream used to write attributes of an SQL  <b>User Defined Type</b> (UDT) to the database. This interface is used for custom mapping of types and is called by the JDBC driver. It is not intended to be used by applications. </para> <para>When an object which implements the <c>SQLData </c> interface is used as an argument to an SQL statement, the JDBC driver calls the method <c>SQLData.getSQLType </c> to establish the type of the SQL UDT that is being passed. The driver then creates an <c>SQLOutput </c> stream and passes it to the <c>SQLData.writeSQL </c> method, which in turn uses the appropriate  <c>SQLOutput </c> writer methods to write the data from the <c>SQLData </c> object into the stream according to the defined mapping.</para> <para> <para>SQLData </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLOutput
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLOutput", AccessFlags = 1537)]
		public partial interface ISQLOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Write a <c>String </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeString
				/// </java-name>
				[Dot42.DexImport("writeString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteString(string theString) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>boolean </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1025)]
				void WriteBoolean(bool theFlag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>byte </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 1025)]
				void WriteByte(byte theByte) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>short </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(S)V", AccessFlags = 1025)]
				void WriteShort(short theShort) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an <c>int </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1025)]
				void WriteInt(int theInt) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>long </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1025)]
				void WriteLong(long theLong) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>float </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1025)]
				void WriteFloat(float theFloat) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>double </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1025)]
				void WriteDouble(double theDouble) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>java.math.BigDecimal </c> value into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBigDecimal
				/// </java-name>
				[Dot42.DexImport("writeBigDecimal", "(Ljava/math/BigDecimal;)V", AccessFlags = 1025)]
				void WriteBigDecimal(global::Java.Math.BigDecimal theBigDecimal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an array of bytes into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([B)V", AccessFlags = 1025)]
				void WriteBytes(byte[] theBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>java.sql.Date </c> value into the output stream.</para> <para> <para>Date </para></para>        
				/// </summary>
				/// <java-name>
				/// writeDate
				/// </java-name>
				[Dot42.DexImport("writeDate", "(Ljava/sql/Date;)V", AccessFlags = 1025)]
				void WriteDate(global::Java.Sql.Date theDate) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>java.sql.Time </c> value into the output stream.</para> <para> <para>Time </para></para>        
				/// </summary>
				/// <java-name>
				/// writeTime
				/// </java-name>
				[Dot42.DexImport("writeTime", "(Ljava/sql/Time;)V", AccessFlags = 1025)]
				void WriteTime(global::Java.Sql.Time theTime) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>java.sql.Timestamp </c> value into the output stream.</para> <para> <para>Timestamp </para></para>        
				/// </summary>
				/// <java-name>
				/// writeTimestamp
				/// </java-name>
				[Dot42.DexImport("writeTimestamp", "(Ljava/sql/Timestamp;)V", AccessFlags = 1025)]
				void WriteTimestamp(global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a stream of unicode characters into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeCharacterStream
				/// </java-name>
				[Dot42.DexImport("writeCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
				void WriteCharacterStream(global::Java.IO.Reader theStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a stream of ASCII characters into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeAsciiStream
				/// </java-name>
				[Dot42.DexImport("writeAsciiStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void WriteAsciiStream(global::Java.IO.InputStream theStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a stream of uninterpreted bytes into the output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBinaryStream
				/// </java-name>
				[Dot42.DexImport("writeBinaryStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void WriteBinaryStream(global::Java.IO.InputStream theStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an <c>SQLData </c> object into the output stream. </para> <para>If the <c>SQLData </c> object is null, writes <c>NULL </c> to the stream. </para> <para>Otherwise, calls the <c>SQLData.writeSQL </c> method of the object, which writes the object's attributes to the stream by calling the appropriate SQLOutput writer methods for each attribute, in order. The order of the attributes is the order they are listed in the SQL definition of the User Defined Type.</para> <para> <para>SQLData </para></para>        
				/// </summary>
				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/sql/SQLData;)V", AccessFlags = 1025)]
				void WriteObject(global::Java.Sql.ISQLData theObject) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an SQL <c>Ref </c> value into the output stream.</para> <para> <para>Ref </para></para>        
				/// </summary>
				/// <java-name>
				/// writeRef
				/// </java-name>
				[Dot42.DexImport("writeRef", "(Ljava/sql/Ref;)V", AccessFlags = 1025)]
				void WriteRef(global::Java.Sql.IRef theRef) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an SQL <c>Blob </c> value into the output stream.</para> <para> <para>Blob </para></para>        
				/// </summary>
				/// <java-name>
				/// writeBlob
				/// </java-name>
				[Dot42.DexImport("writeBlob", "(Ljava/sql/Blob;)V", AccessFlags = 1025)]
				void WriteBlob(global::Java.Sql.IBlob theBlob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an SQL <c>Clob </c> value into the output stream.</para> <para> <para>Clob </para></para>        
				/// </summary>
				/// <java-name>
				/// writeClob
				/// </java-name>
				[Dot42.DexImport("writeClob", "(Ljava/sql/Clob;)V", AccessFlags = 1025)]
				void WriteClob(global::Java.Sql.IClob theClob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an SQL <c>Struct </c> value into the output stream.</para> <para> <para>Struct </para></para>        
				/// </summary>
				/// <java-name>
				/// writeStruct
				/// </java-name>
				[Dot42.DexImport("writeStruct", "(Ljava/sql/Struct;)V", AccessFlags = 1025)]
				void WriteStruct(global::Java.Sql.IStruct theStruct) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write an SQL <c>Array </c> value into the output stream.</para> <para> <para>Array </para></para>        
				/// </summary>
				/// <java-name>
				/// writeArray
				/// </java-name>
				[Dot42.DexImport("writeArray", "(Ljava/sql/Array;)V", AccessFlags = 1025)]
				void WriteArray(global::Java.Sql.IArray theArray) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>URL </c> into the output stream as an SQL DATALINK.</para> <para> <para>java.net.URL </para></para>        
				/// </summary>
				/// <java-name>
				/// writeURL
				/// </java-name>
				[Dot42.DexImport("writeURL", "(Ljava/net/URL;)V", AccessFlags = 1025)]
				void WriteURL(global::Java.Net.URL theURL) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>String </c> into the output stream as an SQL NCHAR, NVARCHAR, or LONGNVARCHAR.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeNString
				/// </java-name>
				[Dot42.DexImport("writeNString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteNString(string theString) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>Clob </c> into the output stream as an SQL NCLOB.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeNClob
				/// </java-name>
				[Dot42.DexImport("writeNClob", "(Ljava/sql/NClob;)V", AccessFlags = 1025)]
				void WriteNClob(global::Java.Sql.INClob theNClob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>RowId </c> into the output stream as an SQL ROWID.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeRowId
				/// </java-name>
				[Dot42.DexImport("writeRowId", "(Ljava/sql/RowId;)V", AccessFlags = 1025)]
				void WriteRowId(global::Java.Sql.IRowId theRowId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Write a <c>SQLXML </c> into the output stream as an SQL XML.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeSQLXML
				/// </java-name>
				[Dot42.DexImport("writeSQLXML", "(Ljava/sql/SQLXML;)V", AccessFlags = 1025)]
				void WriteSQLXML(global::Java.Sql.ISQLXML theXml) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Maps SQL's XML type into Java. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLXML
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLXML", AccessFlags = 1537)]
		public partial interface ISQLXML
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Frees any resources held by this object. After <c>free </c> is called, calling method other than <c>free </c> will throw <c>SQLException </c> (calling <c>free </c> repeatedly will do nothing). </para>        
				/// </summary>
				/// <java-name>
				/// free
				/// </java-name>
				[Dot42.DexImport("free", "()V", AccessFlags = 1025)]
				void Free() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a stream that can be used to write binary data to this SQL <c>XML </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// setBinaryStream
				/// </java-name>
				[Dot42.DexImport("setBinaryStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.IO.OutputStream SetBinaryStream() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a writer that can be used to write character data to this SQL <c>XML </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "()Ljava/io/Writer;", AccessFlags = 1025)]
				global::Java.IO.Writer SetCharacterStream() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a Source for reading this object's data. </para>        
				/// </summary>
				/// <java-name>
				/// getSource
				/// </java-name>
				[Dot42.DexImport("getSource", "(Ljava/lang/Class;)Ljavax/xml/transform/Source;", AccessFlags = 1025, Signature = "<T::Ljavax/xml/transform/Source;>(Ljava/lang/Class<TT;>;)TT;")]
				T GetSource<T>(global::System.Type sourceClass) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a Result for writing this object's data. </para>        
				/// </summary>
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(Ljava/lang/Class;)Ljavax/xml/transform/Result;", AccessFlags = 1025, Signature = "<T::Ljavax/xml/transform/Result;>(Ljava/lang/Class<TT;>;)TT;")]
				T SetResult<T>(global::System.Type resultClass) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a stream that can be used to read binary data from this SQL <c>XML </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// getBinaryStream
				/// </java-name>
				global::Java.IO.InputStream BinaryStream
				{
						[Dot42.DexImport("getBinaryStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a reader that can be used to read character data from this SQL <c>XML </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Reader CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns this object's data as an XML string. </para>        
				/// </summary>
				/// <java-name>
				/// getString
				/// </java-name>
				string String
				{
						[Dot42.DexImport("getString", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Interface used for executing static SQL statements to retrieve query results. The resulting table rows are returned as <c>ResultSet </c> s. For any given  <c>Statement </c> object, only one <c>ResultSet </c> can be opened at one time. A call to any of the execution methods of <c>Statement </c> will cause any previously created <c>ResultSet </c> object for that <c>Statement </c> to be closed implicitly. </para> <para>To have multiple <c>ResultSet </c> objects opened concurrently, multiple  <c>Statement </c> objects must be created and then executed. </para> <para>To obtain such an executable statement one needs to invoke <c>Connection#createStatement </c> .</para> <para> <para>ResultSet </para> <para>Connection::createStatement </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Statement
		/// </java-name>
		[Dot42.DexImport("java/sql/Statement", AccessFlags = 1537)]
		public partial interface IStatement : global::Java.Sql.IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Adds a specified SQL command to the list of commands for this <c>Statement </c> . </para> <para>The list of commands is executed by invoking the <c>executeBatch </c> method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddBatch(string sql) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Cancels this statement's execution if both the database and the JDBC driver support aborting an SQL statement in flight. This method can be used by one thread to stop a statement that is executed on another thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				void Cancel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Clears the current list of SQL commands for this statement.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearBatch
				/// </java-name>
				[Dot42.DexImport("clearBatch", "()V", AccessFlags = 1025)]
				void ClearBatch() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Clears all <c>SQLWarnings </c> from this statement.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearWarnings
				/// </java-name>
				[Dot42.DexImport("clearWarnings", "()V", AccessFlags = 1025)]
				void ClearWarnings() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Releases this statement's database and JDBC driver resources. </para> <para>Using this method to release these resources as soon as possible is strongly recommended. </para> <para>One should not rely on the resources being automatically released when finalized during garbage collection. Doing so can result in unpredictable behavior for the application.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes a supplied SQL statement. This may return multiple <c>ResultSet </c> s. </para> <para>Use the <c>getResultSet </c> or <c>getUpdateCount </c> methods to get the first result and <c>getMoreResults </c> to get any subsequent results.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the first result is a <c>ResultSet </c> , <c>false </c> if the first result is an update count or if there is no result. </para>
				/// </returns>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Execute(string sql) /* MethodBuilder.Create */ ;

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

				/// <summary>
				///  <para>Submits a batch of SQL commands to the database. Returns an array of update counts, if all the commands execute successfully. </para> <para>If one of the commands in the batch fails, this method can throw a BatchUpdateException and the JDBC driver may or may not process the remaining commands. The JDBC driver must behave consistently with the underlying database, following the "all or nothing" principle. If the driver continues processing, the array of results returned contains the same number of elements as there are commands in the batch, with a minimum of one of the elements having the <c>EXECUTE_FAILED </c> value.</para> <para> <ol> <li> <para>If the value of an element is  <ge></ge> 0, the corresponding command completed successfully and the value is the  <b>update count</b> (the number of rows in the database affected by the command) for that command. </para></li> <li> <para>If the value is <c>SUCCESS_NO_INFO </c> , the command completed successfully but the number of rows affected is unknown. </para></li> <li> <para></para></li> <li> <para>If the value is <c>EXECUTE_FAILED </c> , the command failed. </para></li></ol></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of update counts, with one entry for each command in the batch. The elements are ordered according to the order in which the commands were added to the batch. </para>
				/// </returns>
				/// <java-name>
				/// executeBatch
				/// </java-name>
				[Dot42.DexImport("executeBatch", "()[I", AccessFlags = 1025)]
				int[] ExecuteBatch() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes a supplied SQL statement. Returns a single <c>ResultSet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the data produced by the SQL statement. Never null. </para>
				/// </returns>
				/// <java-name>
				/// executeQuery
				/// </java-name>
				[Dot42.DexImport("executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", AccessFlags = 1025)]
				global::Java.Sql.IResultSet ExecuteQuery(string sql) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Executes the supplied SQL statement. The statement may be an <c>INSERT </c> , <c>UPDATE </c> or <c>DELETE </c> statement or a statement which returns nothing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the count of updated rows, or 0 for a statement that returns nothing. </para>
				/// </returns>
				/// <java-name>
				/// executeUpdate
				/// </java-name>
				[Dot42.DexImport("executeUpdate", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int ExecuteUpdate(string sql) /* MethodBuilder.Create */ ;

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

				/// <summary>
				///  <para>Moves to this statement's next result. Returns <c>true </c> if the next result is a <c>ResultSet </c> . Any current <c>ResultSet </c> objects previously obtained with <c>getResultSet() </c> are handled as indicated by a supplied Flag parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the next result exists and is a <c>ResultSet </c> , <c>false </c> if the next result is not a <c>ResultSet </c> or if there are no more results. Note that if there is no more data, this method will return <c>false </c> and <c>getUpdateCount </c> will return -1. </para>
				/// </returns>
				/// <java-name>
				/// getMoreResults
				/// </java-name>
				[Dot42.DexImport("getMoreResults", "(I)Z", AccessFlags = 1025)]
				bool GetMoreResults(int current) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the SQL cursor name. This name is used by subsequent statement execute methods. </para> <para>Cursor names must be unique within one Connection. </para> <para>With the cursor name set, it can then be used in SQL positioned update or delete statements to determine the current row in a <c>ResultSet </c> generated from this statement. The positioned update or delete must be done with a different statement than this one.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCursorName
				/// </java-name>
				[Dot42.DexImport("setCursorName", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCursorName(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets Escape Processing mode. </para> <para>If Escape Processing is on, the JDBC driver will do escape substitution on an SQL statement before sending it for execution. This does not apply to PreparedStatements since they are processed when created, before this method can be called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setEscapeProcessing
				/// </java-name>
				[Dot42.DexImport("setEscapeProcessing", "(Z)V", AccessFlags = 1025)]
				void SetEscapeProcessing(bool enable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the <c>Connection </c> object which created this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Connection </c> through which this statement is transmitted to the database. </para>
				/// </returns>
				/// <java-name>
				/// getConnection
				/// </java-name>
				global::Java.Sql.IConnection Connection
				{
						[Dot42.DexImport("getConnection", "()Ljava/sql/Connection;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the default direction for fetching rows for <c>ResultSet </c> s generated from this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default fetch direction, one of:  <ul> <li> <para>ResultSet.FETCH_FORWARD </para></li> <li> <para>ResultSet.FETCH_REVERSE </para></li> <li> <para>ResultSet.FETCH_UNKNOWN </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getFetchDirection
				/// </java-name>
				int FetchDirection
				{
						[Dot42.DexImport("getFetchDirection", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFetchDirection", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Gets the default number of rows for a fetch for the <c>ResultSet </c> objects returned from this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default fetch size for <c>ResultSet </c> s produced by this statement. </para>
				/// </returns>
				/// <java-name>
				/// getFetchSize
				/// </java-name>
				int FetchSize
				{
						[Dot42.DexImport("getFetchSize", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFetchSize", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Returns auto generated keys created by executing this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>ResultSet </c> containing the auto generated keys - empty if no keys are generated by this statement. </para>
				/// </returns>
				/// <java-name>
				/// getGeneratedKeys
				/// </java-name>
				global::Java.Sql.IResultSet GeneratedKeys
				{
						[Dot42.DexImport("getGeneratedKeys", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the maximum number of bytes which can be returned as values from character and binary type columns in a <c>ResultSet </c> derived from this statement. This limit applies to <c>BINARY </c> , <c>VARBINARY </c> ,  <c>LONGVARBINARY </c> , <c>CHAR </c> , <c>VARCHAR </c> , and <c>LONGVARCHAR </c> types. Any data exceeding the maximum size is abandoned without announcement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current size limit, where <c>0 </c> means that there is no limit. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the maximum number of rows that a <c>ResultSet </c> can contain when produced from this statement. If the limit is exceeded, the excess rows are discarded silently.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current row limit, where <c>0 </c> means that there is no limit. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Moves to this statement's next result. Returns <c>true </c> if it is a  <c>ResultSet </c> . Any current <c>ResultSet </c> objects previously obtained with <c>getResultSet() </c> are closed implicitly.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the next result is a <c>ResultSet </c> , <c>false </c> if the next result is not a <c>ResultSet </c> or if there are no more results. Note that if there is no more data, this method will return <c>false </c> and <c>getUpdateCount </c> will return -1. </para>
				/// </returns>
				/// <java-name>
				/// getMoreResults
				/// </java-name>
				bool MoreResults
				{
						[Dot42.DexImport("getMoreResults", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the timeout value for the statement's execution time. The JDBC driver will wait up to this value for the execution to complete - after the limit is exceeded an SQL <c>Exception </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current query timeout value, where <c>0 </c> indicates that there is no current timeout. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the current result. Should only be called once per result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>ResultSet </c> for the current result. <c>null </c> if the result is an update count or if there are no more results. </para>
				/// </returns>
				/// <java-name>
				/// getResultSet
				/// </java-name>
				global::Java.Sql.IResultSet ResultSet
				{
						[Dot42.DexImport("getResultSet", "()Ljava/sql/ResultSet;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the concurrency setting for <c>ResultSet </c> objects generated by this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>ResultSet.CONCUR_READ_ONLY </c> or <c>ResultSet.CONCUR_UPDATABLE </c> . </para>
				/// </returns>
				/// <java-name>
				/// getResultSetConcurrency
				/// </java-name>
				int ResultSetConcurrency
				{
						[Dot42.DexImport("getResultSetConcurrency", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the cursor hold setting for <c>ResultSet </c> objects generated by this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>ResultSet.HOLD_CURSORS_OVER_COMMIT </c> or <c>ResultSet.CLOSE_CURSORS_AT_COMMIT </c> </para>
				/// </returns>
				/// <java-name>
				/// getResultSetHoldability
				/// </java-name>
				int ResultSetHoldability
				{
						[Dot42.DexImport("getResultSetHoldability", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the <c>ResultSet </c> type setting for <c>ResultSet </c> s derived from this statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>ResultSet.TYPE_FORWARD_ONLY </c> for a <c>ResultSet </c> where the cursor can only move forwards, <c>ResultSet.TYPE_SCROLL_INSENSITIVE </c> for a <c>ResultSet </c> which is scrollable but is not sensitive to changes made by others,  <c>ResultSet.TYPE_SCROLL_SENSITIVE </c> for a <c>ResultSet </c> which is scrollable but is sensitive to changes made by others. </para>
				/// </returns>
				/// <java-name>
				/// getResultSetType
				/// </java-name>
				int ResultSetType
				{
						[Dot42.DexImport("getResultSetType", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets an update count for the current result if it is not a <c>ResultSet </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current result as an update count. <c>-1 </c> if the current result is a <c>ResultSet </c> or if there are no more results. </para>
				/// </returns>
				/// <java-name>
				/// getUpdateCount
				/// </java-name>
				int UpdateCount
				{
						[Dot42.DexImport("getUpdateCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieves the first <c>SQLWarning </c> reported by calls on this statement. If there are multiple warnings, subsequent warnings are chained to the first one. The chain of warnings is cleared each time the statement is executed. </para> <para>Warnings associated with reads from the <c>ResultSet </c> returned from executing the statement will be attached to the <c>ResultSet </c> , not the statement object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an SQLWarning, null if there are no warnings </para>
				/// </returns>
				/// <java-name>
				/// getWarnings
				/// </java-name>
				global::Java.Sql.SQLWarning Warnings
				{
						[Dot42.DexImport("getWarnings", "()Ljava/sql/SQLWarning;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if this statement has been closed, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// isClosed
				/// </java-name>
				bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if this statement is poolable, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// isPoolable
				/// </java-name>
				bool IsPoolable
				{
						[Dot42.DexImport("isPoolable", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setPoolable", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Interface used for executing static SQL statements to retrieve query results. The resulting table rows are returned as <c>ResultSet </c> s. For any given  <c>Statement </c> object, only one <c>ResultSet </c> can be opened at one time. A call to any of the execution methods of <c>Statement </c> will cause any previously created <c>ResultSet </c> object for that <c>Statement </c> to be closed implicitly. </para> <para>To have multiple <c>ResultSet </c> objects opened concurrently, multiple  <c>Statement </c> objects must be created and then executed. </para> <para>To obtain such an executable statement one needs to invoke <c>Connection#createStatement </c> .</para> <para> <para>ResultSet </para> <para>Connection::createStatement </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Statement
		/// </java-name>
		[Dot42.DexImport("java/sql/Statement", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IStatementConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Passing this constant to getMoreResults implies that all <c>ResultSet </c> objects previously kept open should be closed. </para>        
				/// </summary>
				/// <java-name>
				/// CLOSE_ALL_RESULTS
				/// </java-name>
				[Dot42.DexImport("CLOSE_ALL_RESULTS", "I", AccessFlags = 25)]
				public const int CLOSE_ALL_RESULTS = 3;
				/// <summary>
				///  <para>Passing this constant to getMoreResults implies that the current  <c>ResultSet </c> object should be closed. </para>        
				/// </summary>
				/// <java-name>
				/// CLOSE_CURRENT_RESULT
				/// </java-name>
				[Dot42.DexImport("CLOSE_CURRENT_RESULT", "I", AccessFlags = 25)]
				public const int CLOSE_CURRENT_RESULT = 1;
				/// <summary>
				///  <para>Indicates that an error was encountered during execution of a batch statement. </para>        
				/// </summary>
				/// <java-name>
				/// EXECUTE_FAILED
				/// </java-name>
				[Dot42.DexImport("EXECUTE_FAILED", "I", AccessFlags = 25)]
				public const int EXECUTE_FAILED = -3;
				/// <summary>
				///  <para>Passing this constant to  <b>getMoreResults</b> implies that the current  <c>ResultSet </c> object should not be closed. </para>        
				/// </summary>
				/// <java-name>
				/// KEEP_CURRENT_RESULT
				/// </java-name>
				[Dot42.DexImport("KEEP_CURRENT_RESULT", "I", AccessFlags = 25)]
				public const int KEEP_CURRENT_RESULT = 2;
				/// <summary>
				///  <para>Indicates that generated keys should not be accessible for retrieval. </para>        
				/// </summary>
				/// <java-name>
				/// NO_GENERATED_KEYS
				/// </java-name>
				[Dot42.DexImport("NO_GENERATED_KEYS", "I", AccessFlags = 25)]
				public const int NO_GENERATED_KEYS = 2;
				/// <summary>
				///  <para>Indicates that generated keys should be accessible for retrieval. </para>        
				/// </summary>
				/// <java-name>
				/// RETURN_GENERATED_KEYS
				/// </java-name>
				[Dot42.DexImport("RETURN_GENERATED_KEYS", "I", AccessFlags = 25)]
				public const int RETURN_GENERATED_KEYS = 1;
				/// <summary>
				///  <para>Indicates that a batch statement was executed with a successful result, but a count of the number of rows it affected is unavailable. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS_NO_INFO
				/// </java-name>
				[Dot42.DexImport("SUCCESS_NO_INFO", "I", AccessFlags = 25)]
				public const int SUCCESS_NO_INFO = -2;
		}

		/// <summary>
		///  <para>An interface which provides facilities for manipulating an SQL structured type as a Java object. The <c>Struct </c> object has a value for each attribute of the SQL structured type. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Struct
		/// </java-name>
		[Dot42.DexImport("java/sql/Struct", AccessFlags = 1537)]
		public partial interface IStruct
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Gets the values of the attributes of this SQL structured type. This method uses the supplied type mapping to determine how to map SQL types to their corresponding Java objects. In the case where there is no entry in the type mapping which matches this structured type, the JDBC driver uses the default mapping. The <c>Connection </c> type map is  <b>never</b> utilized by this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object array containing the ordered attributes,. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Class<*>;>;)[Ljava/lang/Object;")]
				object[] GetAttributes(global::Java.Util.IMap<string, global::System.Type> theMap) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the SQL Type name of the SQL structured type that this <c>Struct </c> represents.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully qualified name of SQL structured type. </para>
				/// </returns>
				/// <java-name>
				/// getSQLTypeName
				/// </java-name>
				string SQLTypeName
				{
						[Dot42.DexImport("getSQLTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the values of the attributes of this SQL structured type. This method uses the type map associated with the Connection for customized type mappings. Where there is no entry in the type mapping which matches this structured type, the JDBC driver uses the standard mapping.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>Object </c> array containing the ordered attributes. </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				object[] Attributes
				{
						[Dot42.DexImport("getAttributes", "()[Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This class is an actual usage of the wrapper pattern for JDBC classes. Developers can get the delegate instance when the instance may be a proxy class.</para> <para> <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Wrapper
		/// </java-name>
		[Dot42.DexImport("java/sql/Wrapper", AccessFlags = 1537)]
		public partial interface IWrapper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns an object that implements the given interface. If the caller is not a wrapper, a SQLException will be thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>- an object that implements the interface </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "(Ljava/lang/Class;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)TT;")]
				T Unwrap<T>(global::System.Type iface) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the caller is a wrapper of the class or implements the given interface, the methods return false and vice versa.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>- true if the instance implements the interface </para>
				/// </returns>
				/// <java-name>
				/// isWrapperFor
				/// </java-name>
				[Dot42.DexImport("isWrapperFor", "(Ljava/lang/Class;)Z", AccessFlags = 1025, Signature = "(Ljava/lang/Class<*>;)Z")]
				bool IsWrapperFor(global::System.Type iface) /* MethodBuilder.Create */ ;

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

		/// <summary>
		///  <para>An exception, which is subclass of SQLException, is thrown when one or more client info properties could not be set on a Connection. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLClientInfoException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLClientInfoException", AccessFlags = 33)]
		public partial class SQLClientInfoException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLClientInfoException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLClientInfoException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an SQLClientInfoException object. The Reason string is set to the given reason string, the SQLState string is set to null and the Error Code is set to 0, and the Map&lt;String,ClientInfoStatus&gt; object is set to the failed properties.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;)V")]
				public SQLClientInfoException(global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> failedProperties) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Creates an SQLClientInfoException object. The Reason string is set to reason, the SQLState string is set to the sqlState, the Error Code is set to the vendorCode the cause Throwable object is set to the given cause Throwable object, and the Map&lt;String,ClientInfoStatus&gt; object is set to the failed properties.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;Ljava/lang/Throwable;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map<Ljava/lang/String;Ljava/sql/" +
    "ClientInfoStatus;>;Ljava/lang/Throwable;)V")]
				public SQLClientInfoException(string reason, string sqlState, int vendorCode, global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> failedProperties, global::System.Exception cause) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>returns that the client info properties which could not be set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of ClientInfoStatus objects indicate client info properties </para>
				/// </returns>
				/// <java-name>
				/// getFailedProperties
				/// </java-name>
				public virtual global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus> FailedProperties
				{
						[Dot42.DexImport("getFailedProperties", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/sql/ClientInfoStatus;>;")]
						get{ return default(global::Java.Util.IMap<string, global::Java.Sql.ClientInfoStatus>); }
				}

		}

		/// <summary>
		///  <para>An exception, which is subclass of SQLException, is thrown when various data errors arise. These errors including division by 0 and invalid arguments to functions </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLDataException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLDataException", AccessFlags = 33)]
		public partial class SQLDataException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLDataException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLDataException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLDataException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception that indicates a failed JDBC operation. It provides the following information about problems encountered with database access:  <ul> <li> <para>A message string. </para></li> <li> <para>A <c>SQLState </c> error description string following either  or X/OPEN <c>SQLState </c> conventions. DatabaseMetaData#getSQLStateType exposes the specific convention in use. </para></li> <li> <para>A database-specific error code. </para></li> <li> <para>The next exception in the chain. </para></li></ul></para> <para> <para>DatabaseMetaData </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLException", AccessFlags = 33, Signature = "Ljava/lang/Exception;Ljava/io/Serializable;Ljava/lang/Iterable<Ljava/lang/Throwab" +
    "le;>;")]
		public partial class SQLException : global::System.Exception, global::Java.IO.ISerializable, global::Java.Lang.IIterable<global::System.Exception>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an <c>SQLException </c> object. The reason string is set to  <c>null </c> , the <c>SQLState </c> string is set to <c>null </c> and the error code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLException(string theReason, string theSQLState, int theErrorCode, global::System.Exception theCause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Obsolete. getCause() should be used instead of this iterator. Returns an iterator over the exceptions added with setNextException. </para>        
				/// </summary>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Throwable;>;")]
				public virtual global::Java.Util.IIterator<global::System.Exception> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::System.Exception>);
				}

				/// <summary>
				///  <para>Returns the integer error code for this <c>SQLException </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The integer error code for this <c>SQLException </c> . The meaning of the code is specific to the vendor of the database. </para>
				/// </returns>
				/// <java-name>
				/// getErrorCode
				/// </java-name>
				public virtual int ErrorCode
				{
						[Dot42.DexImport("getErrorCode", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieves the <c>SQLException </c> chained to this <c>SQLException </c> , if any.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The <c>SQLException </c> chained to this <c>SQLException </c> .  <c>null </c> if there is no <c>SQLException </c> chained to this  <c>SQLException </c> . </para>
				/// </returns>
				/// <java-name>
				/// getNextException
				/// </java-name>
				public virtual global::Java.Sql.SQLException NextException
				{
						[Dot42.DexImport("getNextException", "()Ljava/sql/SQLException;", AccessFlags = 1)]
						get{ return default(global::Java.Sql.SQLException); }
						[Dot42.DexImport("setNextException", "(Ljava/sql/SQLException;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Retrieves the <c>SQLState </c> description string for this <c>SQLException </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The <c>SQLState </c> string for this <c>SQLException </c> object. This is an error description string which follows either the SQL 99 conventions or the X/OPEN <c>SQLstate </c> conventions. The potential values of the <c>SQLState </c> string are described in each of the specifications. Which of the conventions is being used by the <c>SQLState </c> string can be discovered by using the <c>getSQLStateType </c> method of the <c>DatabaseMetaData </c> interface. </para>
				/// </returns>
				/// <java-name>
				/// getSQLState
				/// </java-name>
				public virtual string SQLState
				{
						[Dot42.DexImport("getSQLState", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>An exception, which is subclass of SQLNonTransientException, is thrown when various the JDBC driver does not support an optional JDBC feature. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLFeatureNotSupportedException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLFeatureNotSupportedException", AccessFlags = 33)]
		public partial class SQLFeatureNotSupportedException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLFeatureNotSupportedException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLFeatureNotSupportedException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLFeatureNotSupportedException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception, which is subclass of SQLNonTransientException, is thrown when various the an integrity constraint (foreign key, primary key or unique key) has been violated. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLIntegrityConstraintViolationException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLIntegrityConstraintViolationException", AccessFlags = 33)]
		public partial class SQLIntegrityConstraintViolationException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLIntegrityConstraintViolationException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLIntegrityConstraintViolationException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLIntegrityConstraintViolationException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception, which is subclass of SQLNonTransientException, is thrown when the authorization credentials presented during connection establishment are not valid. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLInvalidAuthorizationSpecException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLInvalidAuthorizationSpecException", AccessFlags = 33)]
		public partial class SQLInvalidAuthorizationSpecException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLInvalidAuthorizationSpecException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLInvalidAuthorizationSpecException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLInvalidAuthorizationSpecException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception, which is subclass of SQLException, is thrown when the connection operation that failed will not succeed when the operation is retried without the cause of the failure being corrected. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLNonTransientConnectionException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLNonTransientConnectionException", AccessFlags = 33)]
		public partial class SQLNonTransientConnectionException : global::Java.Sql.SQLNonTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLNonTransientConnectionException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLNonTransientConnectionException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientConnectionException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLNonTransientException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLNonTransientException", AccessFlags = 33)]
		public partial class SQLNonTransientException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLNonTransientException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLNonTransientException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLNonTransientException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLPermission
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLPermission", AccessFlags = 49)]
		public sealed partial class SQLPermission : global::Java.Security.BasicPermission, global::Java.Security.IGuard, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
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
				protected internal SQLPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/security/Guard", "checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public override void CheckGuard(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/sql/SQLRecoverableException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLRecoverableException", AccessFlags = 33)]
		public partial class SQLRecoverableException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLRecoverableException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLRecoverableException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLRecoverableException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Creates an SQLSyntaxErrorException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLSyntaxErrorException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLSyntaxErrorException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Creates an SQLTimeoutException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLTimeoutException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTimeoutException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Creates an SQLTransactionRollbackException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLTransactionRollbackException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransactionRollbackException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLTransientConnectionException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTransientConnectionException", AccessFlags = 33)]
		public partial class SQLTransientConnectionException : global::Java.Sql.SQLTransientException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLTransientConnectionException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLTransientConnectionException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientConnectionException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/sql/SQLTransientException
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLTransientException", AccessFlags = 33)]
		public partial class SQLTransientException : global::Java.Sql.SQLException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an SQLTransientException object. The Reason string is set to null, the SQLState string is set to null and the Error Code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLTransientException object. The Reason string is set to the given reason string, the SQLState string is set to the given SQLState string , the Error Code is set to the given error code value, and the cause Throwable object is set to the given cause Throwable object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLTransientException(string reason, string sqlState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception class that holds information about Database access warnings. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/SQLWarning
		/// </java-name>
		[Dot42.DexImport("java/sql/SQLWarning", AccessFlags = 33)]
		public partial class SQLWarning : global::Java.Sql.SQLException, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an <c>SQLWarning </c> object. The reason string is set to <c>null </c> , the <c>SQLState </c> string is set to <c>null </c> and the error code is set to 0. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Creates an SQLWarning object. The Reason string is set to reason, the SQLState string is set to given SQLState and the Error Code is set to vendorCode, cause is set to the given cause</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", AccessFlags = 1)]
				public SQLWarning(string reason, string SQLState, int vendorCode, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the next <c>SQLWarning </c> chained to this <c>SQLWarning </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>SQLWarning </c> chained to this <c>SQLWarning </c> .  <c>null </c> if no <c>SQLWarning </c> is chained to this <c>SQLWarning </c> . </para>
				/// </returns>
				/// <java-name>
				/// getNextWarning
				/// </java-name>
				public virtual global::Java.Sql.SQLWarning NextWarning
				{
						[Dot42.DexImport("getNextWarning", "()Ljava/sql/SQLWarning;", AccessFlags = 1)]
						get{ return default(global::Java.Sql.SQLWarning); }
						[Dot42.DexImport("setNextWarning", "(Ljava/sql/SQLWarning;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Java representation of an SQL <c>TIME </c> value. Provides utilities to format and parse the time's representation as a String in JDBC escape format. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Time
		/// </java-name>
		[Dot42.DexImport("java/sql/Time", AccessFlags = 33)]
		public partial class Time : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>Time </c> object using the supplied values for  <b>Hour</b>,  <b>Minute</b> and  <b>Second</b>. The  <b>Year</b>,  <b>Month</b> and  <b>Day</b> elements of the <c>Time </c> object are set to the date of the Epoch (January 1, 1970). </para> <para>Any attempt to access the  <b>Year</b>,  <b>Month</b> or  <b>Day</b> elements of a <c>Time </c> object will result in an <c>IllegalArgumentException </c> . </para> <para>The result is undefined if any argument is out of bounds.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the constructor Time(long) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Time(int theHour, int theMinute, int theSecond) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>Time </c> object using a supplied time specified in milliseconds.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Time(long theTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. An SQL  <c>Time </c> object does not have a date component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				[Dot42.DexImport("getDate", "()I", AccessFlags = 1)]
				public override int GetDate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. An SQL  <c>Time </c> object does not have a date component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(I)V", AccessFlags = 1)]
				public override void SetDate(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats the <c>Time </c> as a String in JDBC escape format: <c>hh:mm:ss </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String representing the <c>Time </c> value in JDBC escape format: <c>HH:mm:ss </c> </para>
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
				///  <para>Creates a <c>Time </c> object from a string holding a time represented in JDBC escape format: <c>hh:mm:ss </c> . </para> <para>An exception occurs if the input string does not comply with this format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The <c>Time </c> object set to a time corresponding to the given time. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Time;", AccessFlags = 9)]
				public static global::Java.Sql.Time ValueOf(string timeString) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Time);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Time() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. An SQL  <c>Time </c> object does not have a day component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getDay
				/// </java-name>
				public override int Day
				{
						[Dot42.DexImport("getDay", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. An SQL  <c>Time </c> object does not have a month component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				public override int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMonth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated and must not be used. An SQL  <c>Time </c> object does not have a year component. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return anything. </para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				public override int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setYear", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A Java representation of the SQL <c>TIMESTAMP </c> type. It provides the capability of representing the SQL <c>TIMESTAMP </c> nanosecond value, in addition to the regular date/time value which has millisecond resolution. </para> <para>The <c>Timestamp </c> class consists of a regular date/time value, where only the integral seconds value is stored, plus a nanoseconds value where the fractional seconds are stored. </para> <para>The addition of the nanosecond value field to the <c>Timestamp </c> object makes it significantly different from the <c>java.util.Date </c> object which it extends. Users should be aware that <c>Timestamp </c> objects are not interchangable with <c>java.util.Date </c> objects when used outside the confines of the <c>java.sql </c> package.</para> <para> <para>Date </para> <para>Time </para> <para>java.util.Date </para></para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Timestamp
		/// </java-name>
		[Dot42.DexImport("java/sql/Timestamp", AccessFlags = 33)]
		public partial class Timestamp : global::Java.Util.Date
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns a <c>Timestamp </c> corresponding to the time specified by the supplied values for  <b>Year</b>,  <b>Month</b>,  <b>Date</b>,  <b>Hour</b>,  <b>Minutes</b>,  <b>Seconds</b> and  <b>Nanoseconds</b>.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the constructor Timestamp(long) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIIIII)V", AccessFlags = 1)]
				public Timestamp(int theYear, int theMonth, int theDate, int theHour, int theMinute, int theSecond, int theNano) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a <c>Timestamp </c> object corresponding to the time represented by a supplied time value.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Timestamp(long theTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this timestamp object is later than the supplied timestamp, otherwise returns <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>Timestamp </c> object is later than the supplied timestamp, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// after
				/// </java-name>
				[Dot42.DexImport("after", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool After(global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns <c>true </c> if this <c>Timestamp </c> object is earlier than the supplied timestamp, otherwise returns <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>Timestamp </c> object is earlier than the supplied timestamp, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// before
				/// </java-name>
				[Dot42.DexImport("before", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool Before(global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Compares this <c>Timestamp </c> object with a supplied <c>Timestamp </c> object.</para> <para></para> <para>value <c>&lt; 0 </c> if this <c>Timestamp </c> object is before the supplied <c>Timestamp </c> and a value </para> <para>&gt; 0  if this <c>Timestamp </c> object is after the supplied <c>Timestamp </c> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>0  if the two <c>Timestamp </c> objects are equal in time </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/util/Date;)I", AccessFlags = 1)]
				public override int CompareTo(global::Java.Util.Date theObject) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compares this <c>Timestamp </c> object with a supplied <c>Timestamp </c> object.</para> <para></para> <para>value <c>&lt; 0 </c> if this <c>Timestamp </c> object is before the supplied <c>Timestamp </c> and a value </para> <para>&gt; 0  if this <c>Timestamp </c> object is after the supplied <c>Timestamp </c> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>0  if the two <c>Timestamp </c> objects are equal in time </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/sql/Timestamp;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Sql.Timestamp theObject) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Tests to see if this timestamp is equal to a supplied timestamp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>Timestamp </c> object is equal to the supplied <c>Timestamp </c> object, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object theTimestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tests to see if this timestamp is equal to a supplied timestamp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>Timestamp </c> object is equal to the supplied <c>Timestamp </c> object, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/sql/Timestamp;)Z", AccessFlags = 1)]
				public virtual bool Equals(global::Java.Sql.Timestamp theTimestamp) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the timestamp formatted as a String in the JDBC Timestamp Escape format, which is <c>"yyyy-MM-dd HH:mm:ss.nnnnnnnnn" </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string representing the instant defined by the <c>Timestamp </c> , in JDBC Timestamp escape format. </para>
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
				///  <para>Creates a <c>Timestamp </c> object with a time value equal to the time specified by a supplied String holding the time in JDBC timestamp escape format, which is <c>"yyyy-MM-dd HH:mm:ss.nnnnnnnnn </c> "</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A <c>Timestamp </c> object with time value as defined by the supplied <c>String </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/sql/Timestamp;", AccessFlags = 9)]
				public static global::Java.Sql.Timestamp ValueOf(string s) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Sql.Timestamp);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Timestamp() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets this <c>Timestamp </c> 's nanosecond value</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The timestamp's nanosecond value, an integer between 0 and 999,999,999. </para>
				/// </returns>
				/// <java-name>
				/// getNanos
				/// </java-name>
				public virtual int Nanos
				{
						[Dot42.DexImport("getNanos", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNanos", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the time represented by this <c>Timestamp </c> object, as a long value containing the number of milliseconds since the Epoch (January 1 1970, 00:00:00.000 GMT).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of milliseconds that have passed since January 1 1970, 00:00:00.000 GMT. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				public override long Time
				{
						[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A class which defines constants used to identify generic SQL types, also called JDBC types. The type constant values are equivalent to those defined by X/OPEN. </para>    
		/// </summary>
		/// <java-name>
		/// java/sql/Types
		/// </java-name>
		[Dot42.DexImport("java/sql/Types", AccessFlags = 33)]
		public partial class Types
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>ARRAY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// ARRAY
				/// </java-name>
				[Dot42.DexImport("ARRAY", "I", AccessFlags = 25)]
				public const int ARRAY = 2003;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>BIGINT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// BIGINT
				/// </java-name>
				[Dot42.DexImport("BIGINT", "I", AccessFlags = 25)]
				public const int BIGINT = -5;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>BINARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// BINARY
				/// </java-name>
				[Dot42.DexImport("BINARY", "I", AccessFlags = 25)]
				public const int BINARY = -2;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>BIT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// BIT
				/// </java-name>
				[Dot42.DexImport("BIT", "I", AccessFlags = 25)]
				public const int BIT = -7;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>BLOB </c> . </para>        
				/// </summary>
				/// <java-name>
				/// BLOB
				/// </java-name>
				[Dot42.DexImport("BLOB", "I", AccessFlags = 25)]
				public const int BLOB = 2004;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>BOOLEAN </c> . </para>        
				/// </summary>
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "I", AccessFlags = 25)]
				public const int BOOLEAN = 16;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>CHAR </c> . </para>        
				/// </summary>
				/// <java-name>
				/// CHAR
				/// </java-name>
				[Dot42.DexImport("CHAR", "I", AccessFlags = 25)]
				public const int CHAR = 1;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>CLOB </c> . </para>        
				/// </summary>
				/// <java-name>
				/// CLOB
				/// </java-name>
				[Dot42.DexImport("CLOB", "I", AccessFlags = 25)]
				public const int CLOB = 2005;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>DATALINK </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DATALINK
				/// </java-name>
				[Dot42.DexImport("DATALINK", "I", AccessFlags = 25)]
				public const int DATALINK = 70;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>DATE </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DATE
				/// </java-name>
				[Dot42.DexImport("DATE", "I", AccessFlags = 25)]
				public const int DATE = 91;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>DECIMAL </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL
				/// </java-name>
				[Dot42.DexImport("DECIMAL", "I", AccessFlags = 25)]
				public const int DECIMAL = 3;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>DISTINCT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DISTINCT
				/// </java-name>
				[Dot42.DexImport("DISTINCT", "I", AccessFlags = 25)]
				public const int DISTINCT = 2001;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>DOUBLE </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DOUBLE
				/// </java-name>
				[Dot42.DexImport("DOUBLE", "I", AccessFlags = 25)]
				public const int DOUBLE = 8;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>FLOAT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// FLOAT
				/// </java-name>
				[Dot42.DexImport("FLOAT", "I", AccessFlags = 25)]
				public const int FLOAT = 6;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>INTEGER </c> . </para>        
				/// </summary>
				/// <java-name>
				/// INTEGER
				/// </java-name>
				[Dot42.DexImport("INTEGER", "I", AccessFlags = 25)]
				public const int INTEGER = 4;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>JAVA_OBJECT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// JAVA_OBJECT
				/// </java-name>
				[Dot42.DexImport("JAVA_OBJECT", "I", AccessFlags = 25)]
				public const int JAVA_OBJECT = 2000;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>LONGVARBINARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// LONGVARBINARY
				/// </java-name>
				[Dot42.DexImport("LONGVARBINARY", "I", AccessFlags = 25)]
				public const int LONGVARBINARY = -4;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>LONGVARCHAR </c> . </para>        
				/// </summary>
				/// <java-name>
				/// LONGVARCHAR
				/// </java-name>
				[Dot42.DexImport("LONGVARCHAR", "I", AccessFlags = 25)]
				public const int LONGVARCHAR = -1;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>NULL </c> . </para>        
				/// </summary>
				/// <java-name>
				/// NULL
				/// </java-name>
				[Dot42.DexImport("NULL", "I", AccessFlags = 25)]
				public const int NULL = 0;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>NUMERIC </c> . </para>        
				/// </summary>
				/// <java-name>
				/// NUMERIC
				/// </java-name>
				[Dot42.DexImport("NUMERIC", "I", AccessFlags = 25)]
				public const int NUMERIC = 2;
				/// <summary>
				///  <para>The type code that identifies that the SQL type is database specific and is mapped to a Java object, accessed via the methods  <c>getObject </c> and <c>setObject </c> . </para>        
				/// </summary>
				/// <java-name>
				/// OTHER
				/// </java-name>
				[Dot42.DexImport("OTHER", "I", AccessFlags = 25)]
				public const int OTHER = 1111;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>REAL </c> . </para>        
				/// </summary>
				/// <java-name>
				/// REAL
				/// </java-name>
				[Dot42.DexImport("REAL", "I", AccessFlags = 25)]
				public const int REAL = 7;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>REF </c> . </para>        
				/// </summary>
				/// <java-name>
				/// REF
				/// </java-name>
				[Dot42.DexImport("REF", "I", AccessFlags = 25)]
				public const int REF = 2006;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>SMALLINT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// SMALLINT
				/// </java-name>
				[Dot42.DexImport("SMALLINT", "I", AccessFlags = 25)]
				public const int SMALLINT = 5;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>STRUCT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// STRUCT
				/// </java-name>
				[Dot42.DexImport("STRUCT", "I", AccessFlags = 25)]
				public const int STRUCT = 2002;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>TIME </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TIME
				/// </java-name>
				[Dot42.DexImport("TIME", "I", AccessFlags = 25)]
				public const int TIME = 92;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>TIMESTAMP </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("TIMESTAMP", "I", AccessFlags = 25)]
				public const int TIMESTAMP = 93;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>TINYINT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TINYINT
				/// </java-name>
				[Dot42.DexImport("TINYINT", "I", AccessFlags = 25)]
				public const int TINYINT = -6;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>VARBINARY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// VARBINARY
				/// </java-name>
				[Dot42.DexImport("VARBINARY", "I", AccessFlags = 25)]
				public const int VARBINARY = -3;
				/// <summary>
				///  <para>The type code that identifies the SQL type <c>VARCHAR </c> . </para>        
				/// </summary>
				/// <java-name>
				/// VARCHAR
				/// </java-name>
				[Dot42.DexImport("VARCHAR", "I", AccessFlags = 25)]
				public const int VARCHAR = 12;
				/// <summary>
				///  <para>The type code that identifies the SQL type ROWID. </para>        
				/// </summary>
				/// <java-name>
				/// ROWID
				/// </java-name>
				[Dot42.DexImport("ROWID", "I", AccessFlags = 25)]
				public const int ROWID = -8;
				/// <summary>
				///  <para>The type code that identifies the SQL type NCHAR. </para>        
				/// </summary>
				/// <java-name>
				/// NCHAR
				/// </java-name>
				[Dot42.DexImport("NCHAR", "I", AccessFlags = 25)]
				public const int NCHAR = -15;
				/// <summary>
				///  <para>The type code that identifies the SQL type NVARCHAR. </para>        
				/// </summary>
				/// <java-name>
				/// NVARCHAR
				/// </java-name>
				[Dot42.DexImport("NVARCHAR", "I", AccessFlags = 25)]
				public const int NVARCHAR = -9;
				/// <summary>
				///  <para>The type code that identifies the SQL type LONGNVARCHAR. </para>        
				/// </summary>
				/// <java-name>
				/// LONGNVARCHAR
				/// </java-name>
				[Dot42.DexImport("LONGNVARCHAR", "I", AccessFlags = 25)]
				public const int LONGNVARCHAR = -16;
				/// <summary>
				///  <para>The type code that identifies the SQL type NCLOB. </para>        
				/// </summary>
				/// <java-name>
				/// NCLOB
				/// </java-name>
				[Dot42.DexImport("NCLOB", "I", AccessFlags = 25)]
				public const int NCLOB = 2011;
				/// <summary>
				///  <para>The type code that identifies the SQL type SQLXML. </para>        
				/// </summary>
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

}

