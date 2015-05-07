#pragma warning disable 1717
namespace Java.Util.Logging
{
		/// <summary>
		///  <para>A handler that writes log messages to the standard output stream  <c>System.err </c> . </para> <para>This handler reads the following properties from the log manager to initialize itself:  <ul> <li> <para>java.util.logging.ConsoleHandler.level specifies the logging level, defaults to <c>Level.INFO </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.ConsoleHandler.filter specifies the name of the filter class to be associated with this handler, defaults to <c>null </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.ConsoleHandler.formatter specifies the name of the formatter class to be associated with this handler, defaults to  <c>java.util.logging.SimpleFormatter </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.ConsoleHandler.encoding specifies the encoding this handler will use to encode log messages, defaults to <c>null </c> if this property is not found or has an invalid value. </para></li></ul></para> <para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/ConsoleHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/ConsoleHandler", AccessFlags = 33)]
		public partial class ConsoleHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>ConsoleHandler </c> object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConsoleHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this handler. The <c>System.err </c> is flushed but not closed. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a record if necessary. A flush operation will be done.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public override void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An error reporting facility for Handler implementations to record any error that may happen during logging. <c>Handlers </c> should report errors to an <c>ErrorManager </c> , instead of throwing exceptions, which would interfere with the log issuer's execution. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/ErrorManager
		/// </java-name>
		[Dot42.DexImport("java/util/logging/ErrorManager", AccessFlags = 33)]
		public partial class ErrorManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The error code indicating a failure that does not fit in any of the specific types of failures that follow. </para>        
				/// </summary>
				/// <java-name>
				/// GENERIC_FAILURE
				/// </java-name>
				[Dot42.DexImport("GENERIC_FAILURE", "I", AccessFlags = 25)]
				public const int GENERIC_FAILURE = 0;
				/// <summary>
				///  <para>The error code indicating a failure when writing to an output stream. </para>        
				/// </summary>
				/// <java-name>
				/// WRITE_FAILURE
				/// </java-name>
				[Dot42.DexImport("WRITE_FAILURE", "I", AccessFlags = 25)]
				public const int WRITE_FAILURE = 1;
				/// <summary>
				///  <para>The error code indicating a failure when flushing an output stream. </para>        
				/// </summary>
				/// <java-name>
				/// FLUSH_FAILURE
				/// </java-name>
				[Dot42.DexImport("FLUSH_FAILURE", "I", AccessFlags = 25)]
				public const int FLUSH_FAILURE = 2;
				/// <summary>
				///  <para>The error code indicating a failure when closing an output stream. </para>        
				/// </summary>
				/// <java-name>
				/// CLOSE_FAILURE
				/// </java-name>
				[Dot42.DexImport("CLOSE_FAILURE", "I", AccessFlags = 25)]
				public const int CLOSE_FAILURE = 3;
				/// <summary>
				///  <para>The error code indicating a failure when opening an output stream. </para>        
				/// </summary>
				/// <java-name>
				/// OPEN_FAILURE
				/// </java-name>
				[Dot42.DexImport("OPEN_FAILURE", "I", AccessFlags = 25)]
				public const int OPEN_FAILURE = 4;
				/// <summary>
				///  <para>The error code indicating a failure when formatting the error messages. </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_FAILURE
				/// </java-name>
				[Dot42.DexImport("FORMAT_FAILURE", "I", AccessFlags = 25)]
				public const int FORMAT_FAILURE = 5;
				/// <summary>
				///  <para>Constructs an instance of <c>ErrorManager </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ErrorManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reports an error using the given message, exception and error code. This implementation will write out the message to System#err on the first call and all subsequent calls are ignored. A subclass of this class should override this method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/String;Ljava/lang/Exception;I)V", AccessFlags = 1)]
				public virtual void Error(string message, global::System.Exception exception, int errorCode) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A <c>FileHandler </c> writes logging records into a specified file or a rotating set of files. </para> <para>When a set of files is used and a given amount of data has been written to one file, then this file is closed and another file is opened. The name of these files are generated by given name pattern, see below for details. When the files have all been filled the Handler returns to the first and goes through the set again. </para> <para>By default, the I/O buffering mechanism is enabled, but when each log record is complete, it is flushed out. </para> <para> <c>XMLFormatter </c> is the default formatter for <c>FileHandler </c> . </para> <para> <c>FileHandler </c> reads the following <c>LogManager </c> properties for initialization; if a property is not defined or has an invalid value, a default value is used.  <ul> <li> <para>java.util.logging.FileHandler.append specifies whether this  <c>FileHandler </c> should append onto existing files, defaults to  <c>false </c> . </para></li> <li> <para>java.util.logging.FileHandler.count specifies how many output files to rotate, defaults to 1. </para></li> <li> <para>java.util.logging.FileHandler.filter specifies the <c>Filter </c> class name, defaults to no <c>Filter </c> . </para></li> <li> <para>java.util.logging.FileHandler.formatter specifies the <c>Formatter </c> class, defaults to <c>java.util.logging.XMLFormatter </c> . </para></li> <li> <para>java.util.logging.FileHandler.encoding specifies the character set encoding name, defaults to the default platform encoding. </para></li> <li> <para>java.util.logging.FileHandler.level specifies the level for this  <c>Handler </c> , defaults to <c>Level.ALL </c> . </para></li> <li> <para>java.util.logging.FileHandler.limit specifies the maximum number of bytes to write to any one file, defaults to zero, which means no limit. </para></li> <li> <para>java.util.logging.FileHandler.pattern specifies name pattern for the output files. See below for details. Defaults to "%h/java%u.log". </para></li></ul></para> <para>Name pattern is a string that may include some special substrings, which will be replaced to generate output files:  <ul> <li> <para>"/" represents the local pathname separator </para></li> <li> <para>"%g" represents the generation number to distinguish rotated logs </para></li> <li> <para>"%h" represents the home directory of the current user, which is specified by "user.home" system property </para></li> <li> <para>"%t" represents the system's temporary directory </para></li> <li> <para>"%u" represents a unique number to resolve conflicts </para></li> <li> <para>"%%" represents the percent sign character '' </para></li></ul></para> <para>Normally, the generation numbers are not larger than the given file count and follow the sequence 0, 1, 2.... If the file count is larger than one, but the generation field("%g") has not been specified in the pattern, then the generation number after a dot will be added to the end of the file name. </para> <para>The "%u" unique field is used to avoid conflicts and is set to 0 at first. If one <c>FileHandler </c> tries to open the filename which is currently in use by another process, it will repeatedly increment the unique number field and try again. If the "%u" component has not been included in the file name pattern and some contention on a file does occur, then a unique numerical value will be added to the end of the filename in question immediately to the right of a dot. The generation of unique IDs for avoiding conflicts is only guaranteed to work reliably when using a local disk file system. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/FileHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/FileHandler", AccessFlags = 33)]
		public partial class FileHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a <c>FileHandler </c> using <c>LogManager </c> properties or their default value.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileHandler </c> . The given name pattern is used as output filename, the file limit is set to zero (no limit), the file count is set to one; the remaining configuration is done using  <c>LogManager </c> properties or their default values. This handler writes to only one file with no size limit.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileHandler(string pattern) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a new <c>FileHandler </c> . The given name pattern is used as output filename, the file limit is set to zero (no limit), the file count is initialized to one and the value of <c>append </c> becomes the new instance's append mode. The remaining configuration is done using  <c>LogManager </c> properties. This handler writes to only one file with no size limit.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public FileHandler(string pattern, bool append) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a new <c>FileHandler </c> . The given name pattern is used as output filename, the maximum file size is set to <c>limit </c> and the file count is initialized to <c>count </c> . The remaining configuration is done using <c>LogManager </c> properties. This handler is configured to write to a rotating set of count files, when the limit of bytes has been written to one output file, another file will be opened instead.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public FileHandler(string pattern, int limit, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a new <c>FileHandler </c> . The given name pattern is used as output filename, the maximum file size is set to <c>limit </c> , the file count is initialized to <c>count </c> and the append mode is set to  <c>append </c> . The remaining configuration is done using  <c>LogManager </c> properties. This handler is configured to write to a rotating set of count files, when the limit of bytes has been written to one output file, another file will be opened instead.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;IIZ)V", AccessFlags = 1)]
				public FileHandler(string pattern, int limit, int count, bool append) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes and closes all opened files. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Publish a <c>LogRecord </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>Formatter </c> objects are used to format LogRecord objects into a string representation. Head and tail strings are sometimes used to wrap a set of records. The <c>getHead </c> and <c>getTail </c> methods are used for this purpose. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/Formatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Formatter", AccessFlags = 1057)]
		public abstract partial class Formatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>Formatter </c> object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Formatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts a LogRecord object into a string representation. The resulted string is usually localized and includes the message field of the record.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Format(global::Java.Util.Logging.LogRecord r) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Formats a <c>LogRecord </c> object into a localized string representation. This is a convenience method for subclasses of <c>Formatter </c> . </para> <para>The message string is firstly localized using the <c>ResourceBundle </c> object associated with the supplied <c>LogRecord </c> . </para> <para>Notice : if message contains "{0", then java.text.MessageFormat is used. Otherwise no formatting is performed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string resulted from the formatting. </para>
				/// </returns>
				/// <java-name>
				/// formatMessage
				/// </java-name>
				[Dot42.DexImport("formatMessage", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string FormatMessage(global::Java.Util.Logging.LogRecord r) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the head string used to wrap a set of log records. This base class always returns an empty string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the head string used to wrap a set of log records, empty in this implementation. </para>
				/// </returns>
				/// <java-name>
				/// getHead
				/// </java-name>
				[Dot42.DexImport("getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHead(global::Java.Util.Logging.Handler h) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the tail string used to wrap a set of log records. This base class always returns the empty string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail string used to wrap a set of log records, empty in this implementation. </para>
				/// </returns>
				/// <java-name>
				/// getTail
				/// </java-name>
				[Dot42.DexImport("getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTail(global::Java.Util.Logging.Handler h) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>A <c>Handler </c> object accepts a logging request and exports the desired messages to a target, for example, a file, the console, etc. It can be disabled by setting its logging level to <c>Level.OFF </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/Handler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Handler", AccessFlags = 1057)]
		public abstract partial class Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>Handler </c> object with a default error manager instance  <c>ErrorManager </c> , the default encoding, and the default logging level <c>Level.ALL </c> . It has no filter and no formatter. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Handler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this handler. A flush operation will be performed and all the associated resources will be freed. Client applications should not use this handler after closing it. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public abstract void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Flushes any buffered output. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public abstract void Flush() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Accepts a logging request and sends it to the the target.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1025)]
				public abstract void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determines whether the supplied log record needs to be logged. The logging levels will be checked as well as the filter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the supplied log record needs to be logged, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public virtual bool IsLoggable(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reports an error to the error manager associated with this handler,  <c>ErrorManager </c> is used for that purpose. No security checks are done, therefore this is compatible with environments where the caller is non-privileged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reportError
				/// </java-name>
				[Dot42.DexImport("reportError", "(Ljava/lang/String;Ljava/lang/Exception;I)V", AccessFlags = 4)]
				protected internal virtual void ReportError(string msg, global::System.Exception ex, int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the character encoding used by this handler, <c>null </c> for default encoding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character encoding used by this handler. </para>
				/// </returns>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				public virtual string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the error manager used by this handler to report errors during logging.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the error manager used by this handler. </para>
				/// </returns>
				/// <java-name>
				/// getErrorManager
				/// </java-name>
				public virtual global::Java.Util.Logging.ErrorManager ErrorManager
				{
						[Dot42.DexImport("getErrorManager", "()Ljava/util/logging/ErrorManager;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.ErrorManager); }
						[Dot42.DexImport("setErrorManager", "(Ljava/util/logging/ErrorManager;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the filter used by this handler.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the filter used by this handler (possibly <c>null </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Java.Util.Logging.IFilter Filter
				{
						[Dot42.DexImport("getFilter", "()Ljava/util/logging/Filter;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.IFilter); }
						[Dot42.DexImport("setFilter", "(Ljava/util/logging/Filter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the formatter used by this handler to format the logging messages.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the formatter used by this handler (possibly <c>null </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getFormatter
				/// </java-name>
				public virtual global::Java.Util.Logging.Formatter Formatter
				{
						[Dot42.DexImport("getFormatter", "()Ljava/util/logging/Formatter;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Formatter); }
						[Dot42.DexImport("setFormatter", "(Ljava/util/logging/Formatter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the logging level of this handler, records with levels lower than this value will be dropped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the logging level of this handler. </para>
				/// </returns>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public virtual global::Java.Util.Logging.Level Level
				{
						[Dot42.DexImport("getLevel", "()Ljava/util/logging/Level;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Level); }
						[Dot42.DexImport("setLevel", "(Ljava/util/logging/Level;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A <c>Filter </c> provides a mechanism for exercising fine-grained control over which records get logged. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/Filter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Filter", AccessFlags = 1537)]
		public partial interface IFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Checks <c>record </c> to determine if it should be logged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the supplied log record needs to be logged,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1025)]
				bool IsLoggable(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>LoggingMXBean </c> is the management interface for the logging sub-system. </para> <para>The ObjectName for identifying the <c>LoggingMXBean </c> in a bean server is LogManager#LOGGING_MXBEAN_NAME. </para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/LoggingMXBean
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LoggingMXBean", AccessFlags = 1537)]
		public partial interface ILoggingMXBean
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Gets the string value of the logging level of a logger. An empty string is returned when the logger's level is defined by its parent. A  <c>null </c> is returned if the specified logger does not exist.</para> <para> <para>Level::getName() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> if the logger is found, otherwise <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLoggerLevel
				/// </java-name>
				[Dot42.DexImport("getLoggerLevel", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetLoggerLevel(string loggerName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the name of the parent logger of a logger. If the logger doesn't exist then <c>null </c> is returned. If the logger is the root logger, then an empty <c>String </c> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>String </c> if the logger was found, otherwise <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParentLoggerName
				/// </java-name>
				[Dot42.DexImport("getParentLoggerName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParentLoggerName(string loggerName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the log level of a logger. LevelName set to <c>null </c> means the level is inherited from the nearest non-null ancestor.</para> <para> <para>Level::parse(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setLoggerLevel
				/// </java-name>
				[Dot42.DexImport("setLoggerLevel", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetLoggerLevel(string loggerName, string levelName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a list of all currently registered logger names. This is performed using the LogManager#getLoggerNames().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of logger names. </para>
				/// </returns>
				/// <java-name>
				/// getLoggerNames
				/// </java-name>
				global::Java.Util.IList<string> LoggerNames
				{
						[Dot42.DexImport("getLoggerNames", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get;
				}

		}

		/// <summary>
		///  <para> <c>Level </c> objects are used to indicate the level of logging. There are a set of predefined logging levels, each associated with an integer value. Enabling a certain logging level also enables all logging levels with larger values. </para> <para>The predefined levels in ascending order are FINEST, FINER, FINE, CONFIG, INFO, WARNING, SEVERE. There are two additional predefined levels, which are ALL and OFF. ALL indicates logging all messages, and OFF indicates logging no messages. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/Level
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Level", AccessFlags = 33)]
		public partial class Level : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The OFF level provides no logging messages. </para>        
				/// </summary>
				/// <java-name>
				/// OFF
				/// </java-name>
				[Dot42.DexImport("OFF", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level OFF;
				/// <summary>
				///  <para>The SEVERE level provides severe failure messages. </para>        
				/// </summary>
				/// <java-name>
				/// SEVERE
				/// </java-name>
				[Dot42.DexImport("SEVERE", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level SEVERE;
				/// <summary>
				///  <para>The WARNING level provides warnings. </para>        
				/// </summary>
				/// <java-name>
				/// WARNING
				/// </java-name>
				[Dot42.DexImport("WARNING", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level WARNING;
				/// <summary>
				///  <para>The INFO level provides informative messages. </para>        
				/// </summary>
				/// <java-name>
				/// INFO
				/// </java-name>
				[Dot42.DexImport("INFO", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level INFO;
				/// <summary>
				///  <para>The CONFIG level provides static configuration messages. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG
				/// </java-name>
				[Dot42.DexImport("CONFIG", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level CONFIG;
				/// <summary>
				///  <para>The FINE level provides tracing messages. </para>        
				/// </summary>
				/// <java-name>
				/// FINE
				/// </java-name>
				[Dot42.DexImport("FINE", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINE;
				/// <summary>
				///  <para>The FINER level provides more detailed tracing messages. </para>        
				/// </summary>
				/// <java-name>
				/// FINER
				/// </java-name>
				[Dot42.DexImport("FINER", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINER;
				/// <summary>
				///  <para>The FINEST level provides highly detailed tracing messages. </para>        
				/// </summary>
				/// <java-name>
				/// FINEST
				/// </java-name>
				[Dot42.DexImport("FINEST", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINEST;
				/// <summary>
				///  <para>The ALL level provides all logging messages. </para>        
				/// </summary>
				/// <java-name>
				/// ALL
				/// </java-name>
				[Dot42.DexImport("ALL", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level ALL;
				/// <summary>
				///  <para>Constructs an instance of <c>Level </c> taking the supplied name and level value.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal Level(string name, int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs an instance of <c>Level </c> taking the supplied name, level value and resource bundle name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 4)]
				protected internal Level(string name, int level, string resourceBundleName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses a level name into a <c>Level </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the level with the specified name. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/logging/Level;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Level Parse(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Level);
				}

				/// <summary>
				///  <para>Gets the integer value indicating this level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this level's integer value. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 17)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compares two <c>Level </c> objects for equality. They are considered to be equal if they have the same level value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this object equals to the supplied object,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hash code of this <c>Level </c> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this level's hash code. </para>
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
				///  <para>Returns the string representation of this <c>Level </c> object. In this case, it is the level's name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this level. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Level() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the name of this level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this level's name. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the name of the resource bundle associated with this level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this level's resource bundle. </para>
				/// </returns>
				/// <java-name>
				/// getResourceBundleName
				/// </java-name>
				public virtual string ResourceBundleName
				{
						[Dot42.DexImport("getResourceBundleName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the localized name of this level. The default locale is used. If no resource bundle is associated with this level then the original level name is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the localized name of this level. </para>
				/// </returns>
				/// <java-name>
				/// getLocalizedName
				/// </java-name>
				public virtual string LocalizedName
				{
						[Dot42.DexImport("getLocalizedName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Loggers are used to log records to a variety of destinations such as log files or the console. They use instances of Handler to actually do the destination-specific operations.</para> <para>Client applications can get named loggers by calling the <c>getLogger </c> methods. They can also get anonymous loggers by calling the  <c>getAnonymousLogger </c> methods. Named loggers are organized in a namespace hierarchy managed by a log manager. The naming convention is usually the Java package naming convention. Anonymous loggers do not belong to any namespace.</para> <para>Developers should use named loggers to enable logging to be controlled on a per- <c>Logger </c> granularity. The recommended idiom is to create and assign the logger to a <c>static final </c> field. This ensures that there's always a strong reference to the logger, preventing it from being garbage collected. In particular, LogManager#addLogger(Logger) will  <b>not</b> keep your logger live.</para> <para>Loggers "inherit" log level setting from their parent if their own level is set to <c>null </c> . This is also true for the resource bundle. The logger's resource bundle is used to localize the log messages if no resource bundle name is given when a log method is called. If <c>getUseParentHandlers() </c> returns <c>true </c> , loggers also inherit their parent's handlers. In this context, "inherit" only means that "behavior" is inherited. The internal field values will not change, for example, <c>getLevel() </c> still returns  <c>null </c> . </para> <para>When loading a given resource bundle, the logger first tries to use the context <c>ClassLoader </c> . If that fails, it tries the system <c>ClassLoader </c> . And if that still fails, it searches up the class stack and uses each class's  <c>ClassLoader </c> to try to locate the resource bundle. </para> <para>Some log methods accept log requests that do not specify the source class and source method. In these cases, the logging framework will automatically infer the calling class and method, but this is not guaranteed to be accurate. </para> <para>Once a <c>LogRecord </c> object has been passed into the logging framework, it is owned by the logging framework and the client applications should not use it any longer. </para> <para>All methods of this class are thread-safe.</para> <para> <para>LogManager </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/Logger
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Logger", AccessFlags = 33)]
		public partial class Logger
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of the global logger. Before using this, see the discussion of how to use  <c>Logger </c> in the class documentation.  <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// GLOBAL_LOGGER_NAME
				/// </java-name>
				[Dot42.DexImport("GLOBAL_LOGGER_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GLOBAL_LOGGER_NAME = "global";
				/// <summary>
				///  <para>The global logger is provided as convenience for casual use.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This is deadlock-prone. Use <c>Logger.getLogger(Logger.GLOBAL_LOGGER_NAME) </c> as a direct replacement, but read the discussion of how to use Logger in the class documentation. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// global
				/// </java-name>
				[Dot42.DexImport("global", "Ljava/util/logging/Logger;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Logger Global;
				/// <summary>
				///  <para>Constructs a <c>Logger </c> object with the supplied name and resource bundle name; <c>notifiyParentHandlers </c> is set to <c>true </c> . </para> <para>Notice : Loggers use a naming hierarchy. Thus "z.x.y" is a child of "z.x".</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Logger(string name, string resourceBundleName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets an anonymous logger to use internally in a thread. Anonymous loggers are not registered in the log manager's namespace. No security checks will be performed when updating an anonymous logger's control settings. </para> <para>The anonymous loggers' parent is set to be the root logger. This way it inherits default logging level and handlers from the root logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of anonymous logger. </para>
				/// </returns>
				/// <java-name>
				/// getAnonymousLogger
				/// </java-name>
				[Dot42.DexImport("getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetAnonymousLogger(string resourceBundleName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <summary>
				///  <para>Gets a named logger. The returned logger may already exist or may be newly created. In the latter case, its level will be set to the configured level according to the <c>LogManager </c> 's properties.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a named logger. </para>
				/// </returns>
				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetLogger(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <summary>
				///  <para>Gets a named logger associated with the supplied resource bundle. The resource bundle will be used to localize logging messages.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a named logger. </para>
				/// </returns>
				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetLogger(string name, string resourceBundleName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <summary>
				///  <para>Adds a handler to this logger. The <c>name </c> will be fed with log records received by this logger.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addHandler
				/// </java-name>
				[Dot42.DexImport("addHandler", "(Ljava/util/logging/Handler;)V", AccessFlags = 1)]
				public virtual void AddHandler(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a handler from this logger. If the specified handler does not exist then this method has no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeHandler
				/// </java-name>
				[Dot42.DexImport("removeHandler", "(Ljava/util/logging/Handler;)V", AccessFlags = 1)]
				public virtual void RemoveHandler(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Determines whether this logger will actually log messages of the specified level. The effective level used to do the determination may be inherited from its parent. The default level is <c>Level.INFO </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this logger will actually log this level, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/Level;)Z", AccessFlags = 1)]
				public virtual bool IsLoggable(global::Java.Util.Logging.Level l) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Logs a message indicating that a method has been entered. A log record with log level <c>Level.FINER </c> , log message "ENTRY", the specified source class name and source method name is submitted for logging.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// entering
				/// </java-name>
				[Dot42.DexImport("entering", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Entering(string sourceClass, string sourceMethod) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entering
				/// </java-name>
				[Dot42.DexImport("entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Entering(string @string, string string1, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entering
				/// </java-name>
				[Dot42.DexImport("entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Entering(string @string, string string1, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message indicating that a method is exited. A log record with log level <c>Level.FINER </c> , log message "RETURN", the specified source class name and source method name is submitted for logging.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// exiting
				/// </java-name>
				[Dot42.DexImport("exiting", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Exiting(string sourceClass, string sourceMethod) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message indicating that a method is exited. A log record with log level <c>Level.FINER </c> , log message "RETURN", the specified source class name, source method name and return value is submitted for logging.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// exiting
				/// </java-name>
				[Dot42.DexImport("exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Exiting(string sourceClass, string sourceMethod, object result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message indicating that an exception is thrown. A log record with log level <c>Level.FINER </c> , log message "THROW", the specified source class name, source method name and the <c>Throwable </c> object is submitted for logging.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// throwing
				/// </java-name>
				[Dot42.DexImport("throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void Throwing(string sourceClass, string sourceMethod, global::System.Exception thrown) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.SEVERE </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// severe
				/// </java-name>
				[Dot42.DexImport("severe", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Severe(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.WARNING </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Warning(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.INFO </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Info(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.CONFIG </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// config
				/// </java-name>
				[Dot42.DexImport("config", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Config(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.FINE </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fine
				/// </java-name>
				[Dot42.DexImport("fine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Fine(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.FINER </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finer
				/// </java-name>
				[Dot42.DexImport("finer", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Finer(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of level <c>Level.FINEST </c> ; the message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finest
				/// </java-name>
				[Dot42.DexImport("finest", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Finest(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of the specified level. The message is transmitted to all subscribed handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.Level logLevel, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.Level level, string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/Level;Ljava/lang/String;[Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.Level level, string @string, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.Level level, string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a given log record. Only records with a logging level that is equal or greater than this logger's level will be submitted to this logger's handlers for logging. If <c>getUseParentHandlers() </c> returns <c>true </c> , the log record will also be submitted to the handlers of this logger's parent, potentially recursively up the namespace. </para> <para>Since all other log methods call this method to actually perform the logging action, subclasses of this class can override this method to catch all logging activities. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of the given level with the specified source class name and source method name.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// logp
				/// </java-name>
				[Dot42.DexImport("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)" +
    "V", AccessFlags = 1)]
				public virtual void Logp(global::Java.Util.Logging.Level logLevel, string sourceClass, string sourceMethod, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logp
				/// </java-name>
				[Dot42.DexImport("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/Object;)V", AccessFlags = 1)]
				public virtual void Logp(global::Java.Util.Logging.Level level, string @string, string string1, string string2, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logp
				/// </java-name>
				[Dot42.DexImport("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[" +
    "Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Logp(global::Java.Util.Logging.Level level, string @string, string string1, string string2, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logp
				/// </java-name>
				[Dot42.DexImport("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void Logp(global::Java.Util.Logging.Level level, string @string, string string1, string string2, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a message of the given level with the specified source class name and source method name, using the given resource bundle to localize the message. If <c>bundleName </c> is null, the empty string or not valid then the message is not localized.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// logrb
				/// </java-name>
				[Dot42.DexImport("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/String;)V", AccessFlags = 1)]
				public virtual void Logrb(global::Java.Util.Logging.Level logLevel, string sourceClass, string sourceMethod, string bundleName, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logrb
				/// </java-name>
				[Dot42.DexImport("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Logrb(global::Java.Util.Logging.Level level, string @string, string string1, string string2, string string3, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logrb
				/// </java-name>
				[Dot42.DexImport("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/String;[Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Logrb(global::Java.Util.Logging.Level level, string @string, string string1, string string2, string string3, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logrb
				/// </java-name>
				[Dot42.DexImport("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void Logrb(global::Java.Util.Logging.Level level, string @string, string string1, string string2, string string3, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Logger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets an anonymous logger to use internally in a thread. Anonymous loggers are not registered in the log manager's namespace. No security checks will be performed when updating an anonymous logger's control settings. </para> <para>The anonymous loggers' parent is set to be the root logger. This way it inherits the default logging level and handlers from the root logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of anonymous logger. </para>
				/// </returns>
				/// <java-name>
				/// getAnonymousLogger
				/// </java-name>
				public static global::Java.Util.Logging.Logger AnonymousLogger
				{
						[Dot42.DexImport("getAnonymousLogger", "()Ljava/util/logging/Logger;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Logging.Logger); }
				}

				/// <summary>
				///  <para>Gets all the handlers associated with this logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of all the handlers associated with this logger. </para>
				/// </returns>
				/// <java-name>
				/// getHandlers
				/// </java-name>
				public virtual global::Java.Util.Logging.Handler[] Handlers
				{
						[Dot42.DexImport("getHandlers", "()[Ljava/util/logging/Handler;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Handler[]); }
				}

				/// <summary>
				///  <para>Gets the filter used by this logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the filter used by this logger, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Java.Util.Logging.IFilter Filter
				{
						[Dot42.DexImport("getFilter", "()Ljava/util/logging/Filter;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.IFilter); }
						[Dot42.DexImport("setFilter", "(Ljava/util/logging/Filter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the logging level of this logger. A <c>null </c> level indicates that this logger inherits its parent's level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the logging level of this logger. </para>
				/// </returns>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public virtual global::Java.Util.Logging.Level Level
				{
						[Dot42.DexImport("getLevel", "()Ljava/util/logging/Level;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Level); }
						[Dot42.DexImport("setLevel", "(Ljava/util/logging/Level;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the flag which indicates whether to use the handlers of this logger's parent to publish incoming log records, potentially recursively up the namespace.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if set to use parent's handlers, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getUseParentHandlers
				/// </java-name>
				public virtual bool UseParentHandlers
				{
						[Dot42.DexImport("getUseParentHandlers", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setUseParentHandlers", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the nearest parent of this logger in the namespace, a <c>null </c> value will be returned if called on the root logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parent of this logger in the namespace. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public virtual global::Java.Util.Logging.Logger Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/util/logging/Logger;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Logger); }
						[Dot42.DexImport("setParent", "(Ljava/util/logging/Logger;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of this logger, <c>null </c> for anonymous loggers.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this logger. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the loaded resource bundle used by this logger to localize logging messages. If the value is <c>null </c> , the parent's resource bundle will be inherited.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the loaded resource bundle used by this logger. </para>
				/// </returns>
				/// <java-name>
				/// getResourceBundle
				/// </java-name>
				public virtual global::Java.Util.ResourceBundle ResourceBundle
				{
						[Dot42.DexImport("getResourceBundle", "()Ljava/util/ResourceBundle;", AccessFlags = 1)]
						get{ return default(global::Java.Util.ResourceBundle); }
				}

				/// <summary>
				///  <para>Gets the name of the loaded resource bundle used by this logger to localize logging messages. If the value is <c>null </c> , the parent's resource bundle name will be inherited.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the loaded resource bundle used by this logger. </para>
				/// </returns>
				/// <java-name>
				/// getResourceBundleName
				/// </java-name>
				public virtual string ResourceBundleName
				{
						[Dot42.DexImport("getResourceBundleName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/LoggingPermission
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LoggingPermission", AccessFlags = 49)]
		public sealed partial class LoggingPermission : global::Java.Security.BasicPermission, global::Java.Security.IGuard, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public LoggingPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LoggingPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/security/Guard", "checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public override void CheckGuard(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>LogManager </c> is used to maintain configuration properties of the logging framework, and to manage a hierarchical namespace of all named  <c>Logger </c> objects. </para> <para>There is only one global <c>LogManager </c> instance in the application, which can be get by calling static method getLogManager(). This instance is created and initialized during class initialization and cannot be changed. </para> <para>The <c>LogManager </c> class can be specified by java.util.logging.manager system property, if the property is unavailable or invalid, the default class java.util.logging.LogManager will be used. </para> <para>On initialization, <c>LogManager </c> reads its configuration from a properties file, which by default is the "lib/logging.properties" in the JRE directory. </para> <para>However, two optional system properties can be used to customize the initial configuration process of <c>LogManager </c> .  <ul> <li> <para>"java.util.logging.config.class" </para></li> <li> <para>"java.util.logging.config.file" </para></li></ul></para> <para>These two properties can be set in three ways, by the Preferences API, by the "java" command line property definitions, or by system property definitions passed to JNI_CreateJavaVM. </para> <para>The "java.util.logging.config.class" should specifies a class name. If it is set, this given class will be loaded and instantiated during  <c>LogManager </c> initialization, so that this object's default constructor can read the initial configuration and define properties for  <c>LogManager </c> . </para> <para>If "java.util.logging.config.class" property is not set, or it is invalid, or some exception is thrown during the instantiation, then the "java.util.logging.config.file" system property can be used to specify a properties file. The <c>LogManager </c> will read initial configuration from this file. </para> <para>If neither of these properties is defined, or some exception is thrown during these two properties using, the <c>LogManager </c> will read its initial configuration from default properties file, as described above. </para> <para>The global logging properties may include:  <ul> <li> <para>"handlers". This property's values should be a list of class names for handler classes separated by whitespace, these classes must be subclasses of  <c>Handler </c> and each must have a default constructor, these classes will be loaded, instantiated and registered as handlers on the root  <c>Logger </c> (the <c>Logger </c> named ""). These  <c>Handler </c> s maybe initialized lazily. </para></li> <li> <para>"config". The property defines a list of class names separated by whitespace. Each class must have a default constructor, in which it can update the logging configuration, such as levels, handlers, or filters for some logger, etc. These classes will be loaded and instantiated during  <c>LogManager </c> configuration </para></li></ul></para> <para>This class, together with any handler and configuration classes associated with it,  <b>must</b> be loaded from the system classpath when  <c>LogManager </c> configuration occurs. </para> <para>Besides global properties, the properties for loggers and Handlers can be specified in the property files. The names of these properties will start with the complete dot separated names for the handlers or loggers. </para> <para>In the <c>LogManager </c> 's hierarchical namespace,  <c>Loggers </c> are organized based on their dot separated names. For example, "x.y.z" is child of "x.y". </para> <para>Levels for <c>Loggers </c> can be defined by properties whose name end with ".level". Thus "alogger.level" defines a level for the logger named as "alogger" and for all its children in the naming hierarchy. Log levels properties are read and applied in the same order as they are specified in the property file. The root logger's level can be defined by the property named as ".level". </para> <para>This class is thread safe. It is an error to synchronize on a  <c>LogManager </c> while synchronized on a <c>Logger </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/LogManager
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LogManager", AccessFlags = 33)]
		public partial class LogManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>String </c> value of the LoggingMXBean's ObjectName. </para>        
				/// </summary>
				/// <java-name>
				/// LOGGING_MXBEAN_NAME
				/// </java-name>
				[Dot42.DexImport("LOGGING_MXBEAN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOGGING_MXBEAN_NAME = "java.util.logging:type=Logging";
				/// <summary>
				///  <para>Default constructor. This is not public because there should be only one  <c>LogManager </c> instance, which can be get by  <c>LogManager.getLogManager() </c> . This is protected so that application can subclass the object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal LogManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 1)]
				public virtual void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a given logger into the hierarchical namespace. The  <c>Logger.addLogger() </c> factory methods call this method to add newly created Logger. This returns false if a logger with the given name has existed in the namespace </para> <para>Note that the <c>LogManager </c> may only retain weak references to registered loggers. In order to prevent <c>Logger </c> objects from being unexpectedly garbage collected it is necessary for  <b>applications</b> to maintain references to them. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the given logger is added into the namespace successfully, false if the given logger exists in the namespace. </para>
				/// </returns>
				/// <java-name>
				/// addLogger
				/// </java-name>
				[Dot42.DexImport("addLogger", "(Ljava/util/logging/Logger;)Z", AccessFlags = 33)]
				public virtual bool AddLogger(global::Java.Util.Logging.Logger logger) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get the logger with the given name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>logger with given name, or <c>null </c> if nothing is found. </para>
				/// </returns>
				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 33)]
				public virtual global::Java.Util.Logging.Logger GetLogger(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <summary>
				///  <para>Get the global <c>LogManager </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the global <c>LogManager </c> instance </para>
				/// </returns>
				/// <java-name>
				/// getLogManager
				/// </java-name>
				[Dot42.DexImport("getLogManager", "()Ljava/util/logging/LogManager;", AccessFlags = 9)]
				public static global::Java.Util.Logging.LogManager GetLogManager() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.LogManager);
				}

				/// <summary>
				///  <para>Get the value of property with given name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of property </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Re-initialize the properties and configuration. The initialization process is same as the <c>LogManager </c> instantiation. </para> <para>Notice : No <c>PropertyChangeEvent </c> are fired. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readConfiguration
				/// </java-name>
				[Dot42.DexImport("readConfiguration", "()V", AccessFlags = 1)]
				public virtual void ReadConfiguration() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Re-initialize the properties and configuration from the given  <c>InputStream </c> </para> <para>Notice : No <c>PropertyChangeEvent </c> are fired. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readConfiguration
				/// </java-name>
				[Dot42.DexImport("readConfiguration", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void ReadConfiguration(global::Java.IO.InputStream ins) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset configuration.</para> <para>All handlers are closed and removed from any named loggers. All loggers' level is set to null, except the root logger's level is set to  <c>Level.INFO </c> . </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a <c>PropertyChangeListener </c> , which will be invoked when the properties are reread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a <c>PropertyChangeListener </c> , do nothing if the given listener is not found.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the <c>LoggingMXBean </c> instance. this implementation always throws an UnsupportedOperationException.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>LoggingMXBean </c> instance </para>
				/// </returns>
				/// <java-name>
				/// getLoggingMXBean
				/// </java-name>
				public static global::Java.Util.Logging.ILoggingMXBean LoggingMXBean
				{
						[Dot42.DexImport("getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Logging.ILoggingMXBean); }
				}

				/// <summary>
				///  <para>Get a <c>Enumeration </c> of all registered logger names.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>enumeration of registered logger names </para>
				/// </returns>
				/// <java-name>
				/// getLoggerNames
				/// </java-name>
				public virtual global::Java.Util.IEnumeration<string> LoggerNames
				{
						[Dot42.DexImport("getLoggerNames", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IEnumeration<string>); }
				}

		}

		/// <summary>
		///  <para>A <c>LogRecord </c> object represents a logging request. It is passed between the logging framework and individual logging handlers. Client applications should not modify a <c>LogRecord </c> object that has been passed into the logging framework. </para> <para>The <c>LogRecord </c> class will infer the source method name and source class name the first time they are accessed if the client application didn't specify them explicitly. This automatic inference is based on the analysis of the call stack and is not guaranteed to be precise. Client applications should force the initialization of these two fields by calling  <c>getSourceClassName </c> or <c>getSourceMethodName </c> if they expect to use them after passing the <c>LogRecord </c> object to another thread or transmitting it over RMI. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/LogRecord
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LogRecord", AccessFlags = 33)]
		public partial class LogRecord : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>LogRecord </c> object using the supplied the logging level and message. The millis property is set to the current time. The sequence property is set to a new unique value, allocated in increasing order within the VM. The thread ID is set to a unique value for the current thread. All other properties are set to <c>null </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/logging/Level;Ljava/lang/String;)V", AccessFlags = 1)]
				public LogRecord(global::Java.Util.Logging.Level level, string msg) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LogRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the logging level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the logging level. </para>
				/// </returns>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public virtual global::Java.Util.Logging.Level Level
				{
						[Dot42.DexImport("getLevel", "()Ljava/util/logging/Level;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Level); }
						[Dot42.DexImport("setLevel", "(Ljava/util/logging/Level;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of the logger.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the logger name. </para>
				/// </returns>
				/// <java-name>
				/// getLoggerName
				/// </java-name>
				public virtual string LoggerName
				{
						[Dot42.DexImport("getLoggerName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setLoggerName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the raw message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw message, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				public virtual string Message
				{
						[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setMessage", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the time when this event occurred, in milliseconds since 1970.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time when this event occurred, in milliseconds since 1970. </para>
				/// </returns>
				/// <java-name>
				/// getMillis
				/// </java-name>
				public virtual long Millis
				{
						[Dot42.DexImport("getMillis", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setMillis", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the array of parameters or <c>null </c> if there are no parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public virtual object[] Parameters
				{
						[Dot42.DexImport("getParameters", "()[Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object[]); }
						[Dot42.DexImport("setParameters", "([Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the resource bundle used to localize the raw message during formatting.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the associated resource bundle, <c>null </c> if none is available or the message is not localizable. </para>
				/// </returns>
				/// <java-name>
				/// getResourceBundle
				/// </java-name>
				public virtual global::Java.Util.ResourceBundle ResourceBundle
				{
						[Dot42.DexImport("getResourceBundle", "()Ljava/util/ResourceBundle;", AccessFlags = 1)]
						get{ return default(global::Java.Util.ResourceBundle); }
						[Dot42.DexImport("setResourceBundle", "(Ljava/util/ResourceBundle;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of the resource bundle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the resource bundle, <c>null </c> if none is available or the message is not localizable. </para>
				/// </returns>
				/// <java-name>
				/// getResourceBundleName
				/// </java-name>
				public virtual string ResourceBundleName
				{
						[Dot42.DexImport("getResourceBundleName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setResourceBundleName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the sequence number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the sequence number. </para>
				/// </returns>
				/// <java-name>
				/// getSequenceNumber
				/// </java-name>
				public virtual long SequenceNumber
				{
						[Dot42.DexImport("getSequenceNumber", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setSequenceNumber", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of the class that is the source of this log record. This information can be changed, may be <c>null </c> and is untrusted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the source class of this log record (possiblity <c>null </c> ) </para>
				/// </returns>
				/// <java-name>
				/// getSourceClassName
				/// </java-name>
				public virtual string SourceClassName
				{
						[Dot42.DexImport("getSourceClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSourceClassName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of the method that is the source of this log record.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the source method of this log record. </para>
				/// </returns>
				/// <java-name>
				/// getSourceMethodName
				/// </java-name>
				public virtual string SourceMethodName
				{
						[Dot42.DexImport("getSourceMethodName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSourceMethodName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets a unique ID of the thread originating the log record. Every thread becomes a different ID. </para> <para>Notice : the ID doesn't necessary map the OS thread ID </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID of the thread originating this log record. </para>
				/// </returns>
				/// <java-name>
				/// getThreadID
				/// </java-name>
				public virtual int ThreadID
				{
						[Dot42.DexImport("getThreadID", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setThreadID", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the <c>Throwable </c> object associated with this log record.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Throwable </c> object associated with this log record. </para>
				/// </returns>
				/// <java-name>
				/// getThrown
				/// </java-name>
				public virtual global::System.Exception Thrown
				{
						[Dot42.DexImport("getThrown", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
						[Dot42.DexImport("setThrown", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A <c>Handler </c> put the description of log events into a cycled memory buffer. </para> <para>Mostly this <c>MemoryHandler </c> just puts the given <c>LogRecord </c> into the internal buffer and doesn't perform any formatting or any other process. When the buffer is full, the earliest buffered records will be discarded. </para> <para>Every <c>MemoryHandler </c> has a target handler, and push action can be triggered so that all buffered records will be output to the target handler and normally the latter will publish the records. After the push action, the buffer will be cleared. </para> <para>The push method can be called directly, but will also be called automatically if a new  <code>LogRecord</code> is added that has a level greater than or equal to than the value defined for the property java.util.logging.MemoryHandler.push. </para> <para> <c>MemoryHandler </c> will read following <c>LogManager </c> properties for initialization, if given properties are not defined or has invalid values, default value will be used.  <ul> <li> <para>java.util.logging.MemoryHandler.filter specifies the <c>Filter </c> class name, defaults to no <c>Filter </c> . </para></li> <li> <para>java.util.logging.MemoryHandler.level specifies the level for this  <c>Handler </c> , defaults to <c>Level.ALL </c> . </para></li> <li> <para>java.util.logging.MemoryHandler.push specifies the push level, defaults to level.SEVERE. </para></li> <li> <para>java.util.logging.MemoryHandler.size specifies the buffer size in number of <c>LogRecord </c> , defaults to 1000. </para></li> <li> <para>java.util.logging.MemoryHandler.target specifies the class of the target  <c>Handler </c> , no default value, which means this property must be specified either by property setting or by constructor. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/MemoryHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/MemoryHandler", AccessFlags = 33)]
		public partial class MemoryHandler : global::Java.Util.Logging.Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor, construct and init a <c>MemoryHandler </c> using  <c>LogManager </c> properties or default values.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MemoryHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct and init a <c>MemoryHandler </c> using given target, size and push level, other properties using <c>LogManager </c> properties or default values.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V", AccessFlags = 1)]
				public MemoryHandler(global::Java.Util.Logging.Handler target, int size, global::Java.Util.Logging.Level pushLevel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Close this handler and target handler, free all associated resources. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call target handler to flush any buffered output. Note that this doesn't cause this <c>MemoryHandler </c> to push. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Put a given <c>LogRecord </c> into internal buffer. If given record is not loggable, just return. Otherwise it is stored in the buffer. Furthermore if the record's level is not less than the push level, the push action is triggered to output all the buffered records to the target handler, and the target handler will publish them.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Check if given <c>LogRecord </c> would be put into this  <c>MemoryHandler </c> 's internal buffer. </para> <para>The given <c>LogRecord </c> is loggable if and only if it has appropriate level and it pass any associated filter's check. </para> <para>Note that the push level is not used for this check.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the given <c>LogRecord </c> if it should be logged, <c>false </c> if <c>LogRecord </c> is <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public override bool IsLoggable(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Triggers a push action to output all buffered records to the target handler, and the target handler will publish them. Then the buffer is cleared. </para>        
				/// </summary>
				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "()V", AccessFlags = 1)]
				public virtual void Push() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the push level.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the push level </para>
				/// </returns>
				/// <java-name>
				/// getPushLevel
				/// </java-name>
				public virtual global::Java.Util.Logging.Level PushLevel
				{
						[Dot42.DexImport("getPushLevel", "()Ljava/util/logging/Level;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Level); }
						[Dot42.DexImport("setPushLevel", "(Ljava/util/logging/Level;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para> <c>SimpleFormatter </c> can be used to print a summary of the information contained in a <c>LogRecord </c> object in a human readable format. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/SimpleFormatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/SimpleFormatter", AccessFlags = 33)]
		public partial class SimpleFormatter : global::Java.Util.Logging.Formatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SimpleFormatter </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SimpleFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts a LogRecord object into a human readable string representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Format(global::Java.Util.Logging.LogRecord r) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>A handler that writes log messages to a socket connection. </para> <para>This handler reads the following properties from the log manager to initialize itself:  <ul> <li> <para>java.util.logging.ConsoleHandler.level specifies the logging level, defaults to <c>Level.ALL </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.SocketHandler.filter specifies the name of the filter class to be associated with this handler, defaults to <c>null </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.SocketHandler.formatter specifies the name of the formatter class to be associated with this handler, defaults to  <c>java.util.logging.XMLFormatter </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.SocketHandler.encoding specifies the encoding this handler will use to encode log messages, defaults to <c>null </c> if this property is not found or has an invalid value. </para></li> <li> <para>java.util.logging.SocketHandler.host specifies the name of the host that this handler should connect to. There's no default value for this property. </para></li> <li> <para>java.util.logging.SocketHandler.encoding specifies the port number that this handler should connect to. There's no default value for this property. </para></li></ul></para> <para>This handler buffers the outgoing messages, but flushes each time a log record has been published. </para> <para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/SocketHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/SocketHandler", AccessFlags = 33)]
		public partial class SocketHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>SocketHandler </c> object using the properties read by the log manager, including the host name and port number. Default formatting uses the XMLFormatter class and level is set to ALL.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>SocketHandler </c> object using the specified host name and port number together with other properties read by the log manager. Default formatting uses the XMLFormatter class and level is set to ALL.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public SocketHandler(string host, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this handler. The network connection to the host is also closed. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Logs a record if necessary. A flush operation will be done afterwards.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public override void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A <c>StreamHandler </c> object writes log messages to an output stream, that is, objects of the class java.io.OutputStream. </para> <para>A <c>StreamHandler </c> object reads the following properties from the log manager to initialize itself. A default value will be used if a property is not found or has an invalid value.  <ul> <li> <para>java.util.logging.StreamHandler.encoding specifies the encoding this handler will use to encode log messages. Default is the encoding used by the current platform. </para></li> <li> <para>java.util.logging.StreamHandler.filter specifies the name of the filter class to be associated with this handler. No  <code>Filter</code> is used by default. </para></li> <li> <para>java.util.logging.StreamHandler.formatter specifies the name of the formatter class to be associated with this handler. Default is  <c>java.util.logging.SimpleFormatter </c> . </para></li> <li> <para>java.util.logging.StreamHandler.level specifies the logging level. Defaults is <c>Level.INFO </c> . </para></li></ul></para> <para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/StreamHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/StreamHandler", AccessFlags = 33)]
		public partial class StreamHandler : global::Java.Util.Logging.Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a <c>StreamHandler </c> object. The new stream handler does not have an associated output stream. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a <c>StreamHandler </c> object with the supplied output stream and formatter.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V", AccessFlags = 1)]
				public StreamHandler(global::Java.IO.OutputStream os, global::Java.Util.Logging.Formatter formatter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the output stream this handler writes to. If there's an existing output stream, the tail string of the associated formatter will be written to it. Then it will be flushed, closed and replaced with  <c>os </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputStream
				/// </java-name>
				[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 4)]
				protected internal virtual void SetOutputStream(global::Java.IO.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this handler. The tail string of the formatter associated with this handler is written out. A flush operation and a subsequent close operation is then performed upon the output stream. Client applications should not use a handler after closing it. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes any buffered output. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Accepts a logging request. The log record is formatted and written to the output stream if the following three conditions are met:  <ul> <li> <para>the supplied log record has at least the required logging level; </para></li> <li> <para>the supplied log record passes the filter associated with this handler, if any; </para></li> <li> <para>the output stream associated with this handler is not <c>null </c> . </para></li></ul>If it is the first time a log record is written out, the head string of the formatter associated with this handler is written out first.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Determines whether the supplied log record needs to be logged. The logging levels are checked as well as the filter. The output stream of this handler is also checked. If it is <c>null </c> , this method returns  <c>false </c> . </para> <para>Notice : Case of no output stream will return <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>record </c> needs to be logged, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public override bool IsLoggable(global::Java.Util.Logging.LogRecord record) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the character encoding used by this handler. A <c>null </c> value indicates that the default encoding should be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				public override string Encoding
				{
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Formatter to convert a LogRecord into an XML string. The DTD specified in Appendix A to the Java Logging APIs specification is used.  <c>XMLFormatter </c> uses the output handler's encoding if it is specified, otherwise the default platform encoding is used instead. UTF-8 is the recommended encoding. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/logging/XMLFormatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/XMLFormatter", AccessFlags = 33)]
		public partial class XMLFormatter : global::Java.Util.Logging.Formatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>XMLFormatter </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts a <c>LogRecord </c> into an XML string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the log record formatted as an XML string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Format(global::Java.Util.Logging.LogRecord r) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the header string for a set of log records formatted as XML strings, using the output handler's encoding if it is defined, otherwise using the default platform encoding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the header string for log records formatted as XML strings. </para>
				/// </returns>
				/// <java-name>
				/// getHead
				/// </java-name>
				[Dot42.DexImport("getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetHead(global::Java.Util.Logging.Handler h) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the tail string for a set of log records formatted as XML strings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tail string for log records formatted as XML strings. </para>
				/// </returns>
				/// <java-name>
				/// getTail
				/// </java-name>
				[Dot42.DexImport("getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetTail(global::Java.Util.Logging.Handler h) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}

