// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Commons.Logging.cs
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
namespace Org.Apache.Commons.Logging
{
		/// <summary>
		/// <para>A simple logging interface abstracting logging APIs. In order to be instantiated successfully by LogFactory, classes that implement this interface must have a constructor that takes a single String parameter representing the "name" of this Log.</para><para>The six logging levels used by <code>Log</code> are (in order): <ol><li><para>trace (the least serious) </para></li><li><para>debug </para></li><li><para>info </para></li><li><para>warn </para></li><li><para>error </para></li><li><para>fatal (the most serious) </para></li></ol>The mapping of these log levels to the concepts used by the underlying logging system is implementation dependent. The implemention should ensure, though, that this ordering behaves as expected.</para><para>Performance is often a logging concern. By examining the appropriate property, a component can avoid expensive operations (producing information to be logged).</para><para>For example, <code><pre>
		///       if (log.isDebugEnabled()) {
		///           ... do something expensive ...
		///           log.debug(theResult);
		///       }
		///    </pre></code> </para><para>Configuration of the underlying logging system will generally be done external to the Logging APIs, through whatever mechanism is supported by that system.</para><para><para> </para><simplesectsep></simplesectsep><para>Rod Waldhoff </para><para></para><title>Id:</title><para>Log.java 381838 2006-02-28 23:57:11Z skitching </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/commons/logging/Log
		/// </java-name>
		[Dot42.DexImport("org/apache/commons/logging/Log", AccessFlags = 1537)]
		public partial interface ILog
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Is debug logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than debug. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if debug is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isDebugEnabled
				/// </java-name>
				[Dot42.DexImport("isDebugEnabled", "()Z", AccessFlags = 1025)]
				bool IsDebugEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Is error logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than error. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if error is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isErrorEnabled
				/// </java-name>
				[Dot42.DexImport("isErrorEnabled", "()Z", AccessFlags = 1025)]
				bool IsErrorEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Is fatal logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than fatal. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if fatal is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isFatalEnabled
				/// </java-name>
				[Dot42.DexImport("isFatalEnabled", "()Z", AccessFlags = 1025)]
				bool IsFatalEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Is info logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than info. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if info is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isInfoEnabled
				/// </java-name>
				[Dot42.DexImport("isInfoEnabled", "()Z", AccessFlags = 1025)]
				bool IsInfoEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Is trace logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than trace. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if trace is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isTraceEnabled
				/// </java-name>
				[Dot42.DexImport("isTraceEnabled", "()Z", AccessFlags = 1025)]
				bool IsTraceEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Is warn logging currently enabled? </para><para>Call this method to prevent having to perform expensive operations (for example, <code>String</code> concatenation) when the log level is more than warn. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if warn is enabled in the underlying logger. </para>
				/// </returns>
				/// <java-name>
				/// isWarnEnabled
				/// </java-name>
				[Dot42.DexImport("isWarnEnabled", "()Z", AccessFlags = 1025)]
				bool IsWarnEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with trace log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Trace(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with trace log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Trace(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with debug log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Debug(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with debug log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Debug(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with info log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Info(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with info log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Info(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with warn log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// warn
				/// </java-name>
				[Dot42.DexImport("warn", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Warn(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with warn log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// warn
				/// </java-name>
				[Dot42.DexImport("warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Warn(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with error log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Error(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with error log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Error(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log a message with fatal log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// fatal
				/// </java-name>
				[Dot42.DexImport("fatal", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Fatal(object message) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Log an error with fatal log level. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// fatal
				/// </java-name>
				[Dot42.DexImport("fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Fatal(object message, global::System.Exception t) /* MethodBuilder.Create */ ;

		}

}


