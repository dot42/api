#pragma warning disable 1717
namespace System.Threading
{
		/// <java-name>
		/// java/lang/Thread
		/// </java-name>
		[Dot42.DexImport("java/lang/Thread", AccessFlags = 33)]
		public partial class Thread : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_PRIORITY
				/// </java-name>
				[Dot42.DexImport("MAX_PRIORITY", "I", AccessFlags = 25)]
				public const int MAX_PRIORITY = 10;
				/// <java-name>
				/// MIN_PRIORITY
				/// </java-name>
				[Dot42.DexImport("MIN_PRIORITY", "I", AccessFlags = 25)]
				public const int MIN_PRIORITY = 1;
				/// <java-name>
				/// NORM_PRIORITY
				/// </java-name>
				[Dot42.DexImport("NORM_PRIORITY", "I", AccessFlags = 25)]
				public const int NORM_PRIORITY = 5;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Thread() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.IRunnable runnable, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup threadGroup, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup threadGroup, global::Java.Lang.IRunnable runnable, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup threadGroup, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup threadGroup, global::Java.Lang.IRunnable runnable, string @string, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// activeCount
				/// </java-name>
				[Dot42.DexImport("activeCount", "()I", AccessFlags = 9)]
				public static int ActiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 17)]
				public void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countStackFrames
				/// </java-name>
				[Dot42.DexImport("countStackFrames", "()I", AccessFlags = 1)]
				public virtual int CountStackFrames() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpStack
				/// </java-name>
				[Dot42.DexImport("dumpStack", "()V", AccessFlags = 9)]
				public static void DumpStack() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;)I", AccessFlags = 9)]
				public static int Enumerate(global::System.Threading.Thread[] thread) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Thread$State;", AccessFlags = 1)]
				public virtual global::System.Threading.Thread.State GetState() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread.State);
				}

				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public virtual void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// interrupted
				/// </java-name>
				[Dot42.DexImport("interrupted", "()Z", AccessFlags = 9)]
				public static bool Interrupted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "()V", AccessFlags = 17)]
				public void Join() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(J)V", AccessFlags = 17)]
				public void Join(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(JI)V", AccessFlags = 17)]
				public void Join(long int64, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 17)]
				public void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDaemon
				/// </java-name>
				[Dot42.DexImport("setDaemon", "(Z)V", AccessFlags = 17)]
				public void SetDaemon(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(J)V", AccessFlags = 9)]
				public static void Sleep(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(JI)V", AccessFlags = 9)]
				public static void Sleep(long int64, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 33)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 17)]
				public void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "(Ljava/lang/Throwable;)V", AccessFlags = 49)]
				public void Stop(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// suspend
				/// </java-name>
				[Dot42.DexImport("suspend", "()V", AccessFlags = 17)]
				public void Suspend() /* MethodBuilder.Create */ 
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
				/// yield
				/// </java-name>
				[Dot42.DexImport("yield", "()V", AccessFlags = 9)]
				public static void Yield() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// holdsLock
				/// </java-name>
				[Dot42.DexImport("holdsLock", "(Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool HoldsLock(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// currentThread
				/// </java-name>
				public static global::System.Threading.Thread CurrentThread
				{
						[Dot42.DexImport("currentThread", "()Ljava/lang/Thread;", AccessFlags = 9)]
						get{ return default(global::System.Threading.Thread); }
				}

				/// <java-name>
				/// getAllStackTraces
				/// </java-name>
				public static global::Java.Util.IMap<global::System.Threading.Thread, global::Java.Lang.StackTraceElement[]> AllStackTraces
				{
						[Dot42.DexImport("getAllStackTraces", "()Ljava/util/Map;", AccessFlags = 9, Signature = "()Ljava/util/Map<Ljava/lang/Thread;[Ljava/lang/StackTraceElement;>;")]
						get{ return default(global::Java.Util.IMap<global::System.Threading.Thread, global::Java.Lang.StackTraceElement[]>); }
				}

				/// <java-name>
				/// getContextClassLoader
				/// </java-name>
				public virtual global::Java.Lang.ClassLoader ContextClassLoader
				{
						[Dot42.DexImport("getContextClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
						[Dot42.DexImport("setContextClassLoader", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDefaultUncaughtExceptionHandler
				/// </java-name>
				public static global::System.Threading.Thread.IUncaughtExceptionHandler DefaultUncaughtExceptionHandler
				{
						[Dot42.DexImport("getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;", AccessFlags = 9)]
						get{ return default(global::System.Threading.Thread.IUncaughtExceptionHandler); }
						[Dot42.DexImport("setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V", AccessFlags = 9)]
						set{ }
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public virtual long Id
				{
						[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
						[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getPriority
				/// </java-name>
				public int Priority
				{
						[Dot42.DexImport("getPriority", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setPriority", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getStackTrace
				/// </java-name>
				public virtual global::Java.Lang.StackTraceElement[] StackTrace
				{
						[Dot42.DexImport("getStackTrace", "()[Ljava/lang/StackTraceElement;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.StackTraceElement[]); }
				}

				/// <java-name>
				/// getThreadGroup
				/// </java-name>
				public global::Java.Lang.ThreadGroup ThreadGroup
				{
						[Dot42.DexImport("getThreadGroup", "()Ljava/lang/ThreadGroup;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ThreadGroup); }
				}

				/// <java-name>
				/// getUncaughtExceptionHandler
				/// </java-name>
				public virtual global::System.Threading.Thread.IUncaughtExceptionHandler UncaughtExceptionHandler
				{
						[Dot42.DexImport("getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;", AccessFlags = 1)]
						get{ return default(global::System.Threading.Thread.IUncaughtExceptionHandler); }
						[Dot42.DexImport("setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isAlive
				/// </java-name>
				public bool IsAlive
				{
						[Dot42.DexImport("isAlive", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDaemon
				/// </java-name>
				public bool IsDaemon
				{
						[Dot42.DexImport("isDaemon", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isInterrupted
				/// </java-name>
				public virtual bool IsInterrupted
				{
						[Dot42.DexImport("isInterrupted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// java/lang/Thread$UncaughtExceptionHandler
				/// </java-name>
				[Dot42.DexImport("java/lang/Thread$UncaughtExceptionHandler", AccessFlags = 1545)]
				public partial interface IUncaughtExceptionHandler
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// uncaughtException
						/// </java-name>
						[Dot42.DexImport("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
						void UncaughtException(global::System.Threading.Thread thread, global::System.Exception exception) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// java/lang/Thread$State
				/// </java-name>
				[Dot42.DexImport("java/lang/Thread$State", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/lang/Thread$State;>;")]
				public sealed class State
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BLOCKED
						/// </java-name>
						[Dot42.DexImport("BLOCKED", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State BLOCKED;
						/// <java-name>
						/// NEW
						/// </java-name>
						[Dot42.DexImport("NEW", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State NEW;
						/// <java-name>
						/// RUNNABLE
						/// </java-name>
						[Dot42.DexImport("RUNNABLE", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State RUNNABLE;
						/// <java-name>
						/// TERMINATED
						/// </java-name>
						[Dot42.DexImport("TERMINATED", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State TERMINATED;
						/// <java-name>
						/// TIMED_WAITING
						/// </java-name>
						[Dot42.DexImport("TIMED_WAITING", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State TIMED_WAITING;
						/// <java-name>
						/// WAITING
						/// </java-name>
						[Dot42.DexImport("WAITING", "Ljava/lang/Thread$State;", AccessFlags = 16409)]
						public static readonly State WAITING;
						private State() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/lang/Thread$State;", AccessFlags = 9)]
						public static State[] Values() /* MethodBuilder.Create */ 
						{
								return default(State[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;", AccessFlags = 9)]
						public static State ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(State);
						}

				}

		}

}

