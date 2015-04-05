#pragma warning disable 1717
namespace Org.Apache.Commons.Logging
{
		/// <java-name>
		/// org/apache/commons/logging/Log
		/// </java-name>
		[Dot42.DexImport("org/apache/commons/logging/Log", AccessFlags = 1537)]
		public partial interface ILog
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Trace(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Trace(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Debug(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Debug(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Info(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// info
				/// </java-name>
				[Dot42.DexImport("info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Info(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// warn
				/// </java-name>
				[Dot42.DexImport("warn", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Warn(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// warn
				/// </java-name>
				[Dot42.DexImport("warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Warn(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Error(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Error(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fatal
				/// </java-name>
				[Dot42.DexImport("fatal", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void Fatal(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fatal
				/// </java-name>
				[Dot42.DexImport("fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
				void Fatal(object @object, global::System.Exception exception) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDebugEnabled
				/// </java-name>
				bool IsDebugEnabled
				{
						[Dot42.DexImport("isDebugEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isErrorEnabled
				/// </java-name>
				bool IsErrorEnabled
				{
						[Dot42.DexImport("isErrorEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isFatalEnabled
				/// </java-name>
				bool IsFatalEnabled
				{
						[Dot42.DexImport("isFatalEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isInfoEnabled
				/// </java-name>
				bool IsInfoEnabled
				{
						[Dot42.DexImport("isInfoEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isTraceEnabled
				/// </java-name>
				bool IsTraceEnabled
				{
						[Dot42.DexImport("isTraceEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isWarnEnabled
				/// </java-name>
				bool IsWarnEnabled
				{
						[Dot42.DexImport("isWarnEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

		}

}

