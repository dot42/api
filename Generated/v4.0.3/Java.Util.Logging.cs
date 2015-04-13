#pragma warning disable 1717
namespace Java.Util.Logging
{
		/// <java-name>
		/// java/util/logging/ConsoleHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/ConsoleHandler", AccessFlags = 33)]
		public partial class ConsoleHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConsoleHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public override void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/logging/ErrorManager
		/// </java-name>
		[Dot42.DexImport("java/util/logging/ErrorManager", AccessFlags = 33)]
		public partial class ErrorManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GENERIC_FAILURE
				/// </java-name>
				[Dot42.DexImport("GENERIC_FAILURE", "I", AccessFlags = 25)]
				public const int GENERIC_FAILURE = 0;
				/// <java-name>
				/// WRITE_FAILURE
				/// </java-name>
				[Dot42.DexImport("WRITE_FAILURE", "I", AccessFlags = 25)]
				public const int WRITE_FAILURE = 1;
				/// <java-name>
				/// FLUSH_FAILURE
				/// </java-name>
				[Dot42.DexImport("FLUSH_FAILURE", "I", AccessFlags = 25)]
				public const int FLUSH_FAILURE = 2;
				/// <java-name>
				/// CLOSE_FAILURE
				/// </java-name>
				[Dot42.DexImport("CLOSE_FAILURE", "I", AccessFlags = 25)]
				public const int CLOSE_FAILURE = 3;
				/// <java-name>
				/// OPEN_FAILURE
				/// </java-name>
				[Dot42.DexImport("OPEN_FAILURE", "I", AccessFlags = 25)]
				public const int OPEN_FAILURE = 4;
				/// <java-name>
				/// FORMAT_FAILURE
				/// </java-name>
				[Dot42.DexImport("FORMAT_FAILURE", "I", AccessFlags = 25)]
				public const int FORMAT_FAILURE = 5;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ErrorManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/String;Ljava/lang/Exception;I)V", AccessFlags = 1)]
				public virtual void Error(string @string, global::System.Exception exception, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/logging/FileHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/FileHandler", AccessFlags = 33)]
		public partial class FileHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileHandler() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileHandler(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public FileHandler(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public FileHandler(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;IIZ)V", AccessFlags = 1)]
				public FileHandler(string @string, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/logging/Formatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Formatter", AccessFlags = 1057)]
		public abstract partial class Formatter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Formatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string Format(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatMessage
				/// </java-name>
				[Dot42.DexImport("formatMessage", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string FormatMessage(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHead
				/// </java-name>
				[Dot42.DexImport("getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHead(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTail
				/// </java-name>
				[Dot42.DexImport("getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTail(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/util/logging/Handler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Handler", AccessFlags = 1057)]
		public abstract partial class Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Handler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public abstract void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public abstract void Flush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1025)]
				public abstract void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public virtual bool IsLoggable(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reportError
				/// </java-name>
				[Dot42.DexImport("reportError", "(Ljava/lang/String;Ljava/lang/Exception;I)V", AccessFlags = 4)]
				protected internal virtual void ReportError(string @string, global::System.Exception exception, int int32) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// java/util/logging/Filter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Filter", AccessFlags = 1537)]
		public partial interface IFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1025)]
				bool IsLoggable(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/logging/LoggingMXBean
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LoggingMXBean", AccessFlags = 1537)]
		public partial interface ILoggingMXBean
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLoggerLevel
				/// </java-name>
				[Dot42.DexImport("getLoggerLevel", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetLoggerLevel(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParentLoggerName
				/// </java-name>
				[Dot42.DexImport("getParentLoggerName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParentLoggerName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLoggerLevel
				/// </java-name>
				[Dot42.DexImport("setLoggerLevel", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetLoggerLevel(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLoggerNames
				/// </java-name>
				global::Java.Util.IList<string> LoggerNames
				{
						[Dot42.DexImport("getLoggerNames", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get;
				}

		}

		/// <java-name>
		/// java/util/logging/Level
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Level", AccessFlags = 33)]
		public partial class Level : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OFF
				/// </java-name>
				[Dot42.DexImport("OFF", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level OFF;
				/// <java-name>
				/// SEVERE
				/// </java-name>
				[Dot42.DexImport("SEVERE", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level SEVERE;
				/// <java-name>
				/// WARNING
				/// </java-name>
				[Dot42.DexImport("WARNING", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level WARNING;
				/// <java-name>
				/// INFO
				/// </java-name>
				[Dot42.DexImport("INFO", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level INFO;
				/// <java-name>
				/// CONFIG
				/// </java-name>
				[Dot42.DexImport("CONFIG", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level CONFIG;
				/// <java-name>
				/// FINE
				/// </java-name>
				[Dot42.DexImport("FINE", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINE;
				/// <java-name>
				/// FINER
				/// </java-name>
				[Dot42.DexImport("FINER", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINER;
				/// <java-name>
				/// FINEST
				/// </java-name>
				[Dot42.DexImport("FINEST", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level FINEST;
				/// <java-name>
				/// ALL
				/// </java-name>
				[Dot42.DexImport("ALL", "Ljava/util/logging/Level;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Level ALL;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal Level(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 4)]
				protected internal Level(string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/logging/Level;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Level Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Level);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 17)]
				public int IntValue() /* MethodBuilder.Create */ 
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getResourceBundleName
				/// </java-name>
				public virtual string ResourceBundleName
				{
						[Dot42.DexImport("getResourceBundleName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLocalizedName
				/// </java-name>
				public virtual string LocalizedName
				{
						[Dot42.DexImport("getLocalizedName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/logging/Logger
		/// </java-name>
		[Dot42.DexImport("java/util/logging/Logger", AccessFlags = 33)]
		public partial class Logger
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GLOBAL_LOGGER_NAME
				/// </java-name>
				[Dot42.DexImport("GLOBAL_LOGGER_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GLOBAL_LOGGER_NAME = "global";
				/// <java-name>
				/// global
				/// </java-name>
				[Dot42.DexImport("global", "Ljava/util/logging/Logger;", AccessFlags = 25)]
				public static readonly global::Java.Util.Logging.Logger Global;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Logger(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAnonymousLogger
				/// </java-name>
				[Dot42.DexImport("getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetAnonymousLogger(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetLogger(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 9)]
				public static global::Java.Util.Logging.Logger GetLogger(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <java-name>
				/// addHandler
				/// </java-name>
				[Dot42.DexImport("addHandler", "(Ljava/util/logging/Handler;)V", AccessFlags = 1)]
				public virtual void AddHandler(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHandler
				/// </java-name>
				[Dot42.DexImport("removeHandler", "(Ljava/util/logging/Handler;)V", AccessFlags = 1)]
				public virtual void RemoveHandler(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/Level;)Z", AccessFlags = 1)]
				public virtual bool IsLoggable(global::Java.Util.Logging.Level level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// entering
				/// </java-name>
				[Dot42.DexImport("entering", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Entering(string @string, string string1) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// exiting
				/// </java-name>
				[Dot42.DexImport("exiting", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Exiting(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// exiting
				/// </java-name>
				[Dot42.DexImport("exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Exiting(string @string, string string1, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// throwing
				/// </java-name>
				[Dot42.DexImport("throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void Throwing(string @string, string string1, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// severe
				/// </java-name>
				[Dot42.DexImport("severe", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Severe(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Warning(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Info(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// config
				/// </java-name>
				[Dot42.DexImport("config", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Config(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fine
				/// </java-name>
				[Dot42.DexImport("fine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Fine(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finer
				/// </java-name>
				[Dot42.DexImport("finer", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Finer(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finest
				/// </java-name>
				[Dot42.DexImport("finest", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Finest(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/Level;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.Level level, string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public virtual void Log(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// logp
				/// </java-name>
				[Dot42.DexImport("logp", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)" +
    "V", AccessFlags = 1)]
				public virtual void Logp(global::Java.Util.Logging.Level level, string @string, string string1, string string2) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// logrb
				/// </java-name>
				[Dot42.DexImport("logrb", "(Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;L" +
    "java/lang/String;)V", AccessFlags = 1)]
				public virtual void Logrb(global::Java.Util.Logging.Level level, string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getAnonymousLogger
				/// </java-name>
				public static global::Java.Util.Logging.Logger AnonymousLogger
				{
						[Dot42.DexImport("getAnonymousLogger", "()Ljava/util/logging/Logger;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Logging.Logger); }
				}

				/// <java-name>
				/// getHandlers
				/// </java-name>
				public virtual global::Java.Util.Logging.Handler[] Handlers
				{
						[Dot42.DexImport("getHandlers", "()[Ljava/util/logging/Handler;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Logging.Handler[]); }
				}

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

				/// <java-name>
				/// getUseParentHandlers
				/// </java-name>
				public virtual bool IsUseParentHandlers
				{
						[Dot42.DexImport("getUseParentHandlers", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setUseParentHandlers", "(Z)V", AccessFlags = 1)]
						set{ }
				}

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

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getResourceBundle
				/// </java-name>
				public virtual global::Java.Util.ResourceBundle ResourceBundle
				{
						[Dot42.DexImport("getResourceBundle", "()Ljava/util/ResourceBundle;", AccessFlags = 1)]
						get{ return default(global::Java.Util.ResourceBundle); }
				}

				/// <java-name>
				/// getResourceBundleName
				/// </java-name>
				public virtual string ResourceBundleName
				{
						[Dot42.DexImport("getResourceBundleName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/logging/LoggingPermission
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LoggingPermission", AccessFlags = 49)]
		public sealed partial class LoggingPermission : global::Java.Security.BasicPermission, global::Java.Security.IGuard, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public LoggingPermission(string @string, string string1) /* MethodBuilder.Create */ 
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
				internal LoggingPermission() /* TypeBuilder.AddDefaultConstructor */ 
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
		/// java/util/logging/LogManager
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LogManager", AccessFlags = 33)]
		public partial class LogManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LOGGING_MXBEAN_NAME
				/// </java-name>
				[Dot42.DexImport("LOGGING_MXBEAN_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOGGING_MXBEAN_NAME = "java.util.logging:type=Logging";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal LogManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 1)]
				public virtual void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLogger
				/// </java-name>
				[Dot42.DexImport("addLogger", "(Ljava/util/logging/Logger;)Z", AccessFlags = 33)]
				public virtual bool AddLogger(global::Java.Util.Logging.Logger logger) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLogger
				/// </java-name>
				[Dot42.DexImport("getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", AccessFlags = 33)]
				public virtual global::Java.Util.Logging.Logger GetLogger(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.Logger);
				}

				/// <java-name>
				/// getLogManager
				/// </java-name>
				[Dot42.DexImport("getLogManager", "()Ljava/util/logging/LogManager;", AccessFlags = 9)]
				public static global::Java.Util.Logging.LogManager GetLogManager() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Logging.LogManager);
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readConfiguration
				/// </java-name>
				[Dot42.DexImport("readConfiguration", "()V", AccessFlags = 1)]
				public virtual void ReadConfiguration() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readConfiguration
				/// </java-name>
				[Dot42.DexImport("readConfiguration", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void ReadConfiguration(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void AddPropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePropertyChangeListener
				/// </java-name>
				[Dot42.DexImport("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", AccessFlags = 1)]
				public virtual void RemovePropertyChangeListener(global::Java.Beans.IPropertyChangeListener propertyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLoggingMXBean
				/// </java-name>
				public static global::Java.Util.Logging.ILoggingMXBean LoggingMXBean
				{
						[Dot42.DexImport("getLoggingMXBean", "()Ljava/util/logging/LoggingMXBean;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Logging.ILoggingMXBean); }
				}

				/// <java-name>
				/// getLoggerNames
				/// </java-name>
				public virtual global::Java.Util.IEnumeration<string> LoggerNames
				{
						[Dot42.DexImport("getLoggerNames", "()Ljava/util/Enumeration;", AccessFlags = 33, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IEnumeration<string>); }
				}

		}

		/// <java-name>
		/// java/util/logging/LogRecord
		/// </java-name>
		[Dot42.DexImport("java/util/logging/LogRecord", AccessFlags = 33)]
		public partial class LogRecord : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/logging/Level;Ljava/lang/String;)V", AccessFlags = 1)]
				public LogRecord(global::Java.Util.Logging.Level level, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LogRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

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

		/// <java-name>
		/// java/util/logging/MemoryHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/MemoryHandler", AccessFlags = 33)]
		public partial class MemoryHandler : global::Java.Util.Logging.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MemoryHandler() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V", AccessFlags = 1)]
				public MemoryHandler(global::Java.Util.Logging.Handler handler, int int32, global::Java.Util.Logging.Level level) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public override bool IsLoggable(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// push
				/// </java-name>
				[Dot42.DexImport("push", "()V", AccessFlags = 1)]
				public virtual void Push() /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// java/util/logging/SimpleFormatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/SimpleFormatter", AccessFlags = 33)]
		public partial class SimpleFormatter : global::Java.Util.Logging.Formatter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SimpleFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Format(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// java/util/logging/SocketHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/SocketHandler", AccessFlags = 33)]
		public partial class SocketHandler : global::Java.Util.Logging.StreamHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SocketHandler() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public SocketHandler(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 1)]
				public override void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/logging/StreamHandler
		/// </java-name>
		[Dot42.DexImport("java/util/logging/StreamHandler", AccessFlags = 33)]
		public partial class StreamHandler : global::Java.Util.Logging.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamHandler() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/logging/Formatter;)V", AccessFlags = 1)]
				public StreamHandler(global::Java.IO.OutputStream outputStream, global::Java.Util.Logging.Formatter formatter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutputStream
				/// </java-name>
				[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 4)]
				protected internal virtual void SetOutputStream(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// publish
				/// </java-name>
				[Dot42.DexImport("publish", "(Ljava/util/logging/LogRecord;)V", AccessFlags = 33)]
				public override void Publish(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/util/logging/LogRecord;)Z", AccessFlags = 1)]
				public override bool IsLoggable(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEncoding
				/// </java-name>
				public override string Encoding
				{
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/util/logging/XMLFormatter
		/// </java-name>
		[Dot42.DexImport("java/util/logging/XMLFormatter", AccessFlags = 33)]
		public partial class XMLFormatter : global::Java.Util.Logging.Formatter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", AccessFlags = 1)]
				public override string Format(global::Java.Util.Logging.LogRecord logRecord) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHead
				/// </java-name>
				[Dot42.DexImport("getHead", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetHead(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTail
				/// </java-name>
				[Dot42.DexImport("getTail", "(Ljava/util/logging/Handler;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetTail(global::Java.Util.Logging.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}

