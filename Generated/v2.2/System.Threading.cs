#pragma warning disable 1717
namespace System.Threading
{
		/// <summary>
		///  <para>A <c>Thread </c> is a concurrent unit of execution. It has its own call stack for methods being invoked, their arguments and local variables. Each application has at least one thread running when it is started, the main thread, in the main ThreadGroup. The runtime keeps its own threads in the system thread group.</para> <para>There are two ways to execute code in a new thread. You can either subclass <c>Thread </c> and overriding its run() method, or construct a new <c>Thread </c> and pass a Runnable to the constructor. In either case, the start() method must be called to actually execute the new <c>Thread </c> .</para> <para>Each <c>Thread </c> has an integer priority that affect how the thread is scheduled by the OS. A new thread inherits the priority of its parent. A thread's priority can be set using the setPriority(int) method. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Thread
		/// </java-name>
		[Dot42.DexImport("java/lang/Thread", AccessFlags = 33)]
		public partial class Thread : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The maximum priority value allowed for a thread. This corresponds to (but does not have the same value as)  <c>android.os.Process.THREAD_PRIORITY_URGENT_DISPLAY </c> . </para>        
				/// </summary>
				/// <java-name>
				/// MAX_PRIORITY
				/// </java-name>
				[Dot42.DexImport("MAX_PRIORITY", "I", AccessFlags = 25)]
				public const int MAX_PRIORITY = 10;
				/// <summary>
				///  <para>The minimum priority value allowed for a thread. This corresponds to (but does not have the same value as)  <c>android.os.Process.THREAD_PRIORITY_LOWEST </c> . </para>        
				/// </summary>
				/// <java-name>
				/// MIN_PRIORITY
				/// </java-name>
				[Dot42.DexImport("MIN_PRIORITY", "I", AccessFlags = 25)]
				public const int MIN_PRIORITY = 1;
				/// <summary>
				///  <para>The normal (default) priority value assigned to the main thread. This corresponds to (but does not have the same value as)  <c>android.os.Process.THREAD_PRIORITY_DEFAULT </c> . </para>        
				/// </summary>
				/// <java-name>
				/// NORM_PRIORITY
				/// </java-name>
				[Dot42.DexImport("NORM_PRIORITY", "I", AccessFlags = 25)]
				public const int NORM_PRIORITY = 5;
				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with no <c>Runnable </c> object and a newly generated name. The new <c>Thread </c> will belong to the same  <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Thread() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object and a newly generated name. The new <c>Thread </c> will belong to the same  <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object and name provided. The new <c>Thread </c> will belong to the same <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.IRunnable runnable, string threadName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object and a newly generated name. The new <c>Thread </c> will belong to the same  <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(string runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object and name provided. The new <c>Thread </c> will belong to the same <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup runnable, global::Java.Lang.IRunnable threadName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object, the given name and belonging to the <c>ThreadGroup </c> passed as parameter.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup group, global::Java.Lang.IRunnable runnable, string threadName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object and name provided. The new <c>Thread </c> will belong to the same <c>ThreadGroup </c> as the <c>Thread </c> calling this constructor.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup runnable, string threadName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Thread </c> with a <c>Runnable </c> object, the given name and belonging to the <c>ThreadGroup </c> passed as parameter.</para> <para> <para>java.lang.ThreadGroup </para> <para>java.lang.Runnable </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V", AccessFlags = 1)]
				public Thread(global::Java.Lang.ThreadGroup group, global::Java.Lang.IRunnable runnable, string threadName, long stackSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of active <c>Thread </c> s in the running <c>Thread </c> 's group and its subgroups.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Thread </c> s </para>
				/// </returns>
				/// <java-name>
				/// activeCount
				/// </java-name>
				[Dot42.DexImport("activeCount", "()I", AccessFlags = 9)]
				public static int ActiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 17)]
				public void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of stack frames in this thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The results of this call were never well defined. To make things worse, it would depend on whether the Thread was suspended or not, and suspend was deprecated too. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Number of stack frames </para>
				/// </returns>
				/// <java-name>
				/// countStackFrames
				/// </java-name>
				[Dot42.DexImport("countStackFrames", "()I", AccessFlags = 1)]
				public virtual int CountStackFrames() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Throws <c>UnsupportedOperationException </c> .  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Not implemented. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints to the standard error stream a text representation of the current stack for this Thread.</para> <para> <para>Throwable::printStackTrace() </para></para>        
				/// </summary>
				/// <java-name>
				/// dumpStack
				/// </java-name>
				[Dot42.DexImport("dumpStack", "()V", AccessFlags = 9)]
				public static void DumpStack() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies an array with all Threads which are in the same ThreadGroup as the receiver - and subgroups - into the array  <code>threads</code> passed as parameter. If the array passed as parameter is too small no exception is thrown - the extra elements are simply not copied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>How many Threads were copied over </para>
				/// </returns>
				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;)I", AccessFlags = 9)]
				public static int Enumerate(global::System.Threading.Thread[] threads) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the current state of the Thread. This method is useful for monitoring purposes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a State value. </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Ljava/lang/Thread$State;", AccessFlags = 1)]
				public virtual global::System.Threading.Thread.State GetState() /* MethodBuilder.Create */ 
				{
						return default(global::System.Threading.Thread.State);
				}

				/// <summary>
				///  <para>Posts an interrupt request to this <c>Thread </c> . The behavior depends on the state of this <c>Thread </c> :  <ul> <li> <para> <c>Thread </c> s blocked in one of <c>Object </c> 's <c>wait() </c> methods or one of <c>Thread </c> 's <c>join() </c> or <c>sleep() </c> methods will be woken up, their interrupt status will be cleared, and they receive an InterruptedException. </para></li> <li> <para> <c>Thread </c> s blocked in an I/O operation of an java.nio.channels.InterruptibleChannel will have their interrupt status set and receive an java.nio.channels.ClosedByInterruptException. Also, the channel will be closed. </para></li> <li> <para> <c>Thread </c> s blocked in a java.nio.channels.Selector will have their interrupt status set and return immediately. They don't receive an exception in this case.  <ul> <li></li></ul>Thread::interrupted  <para>Thread::isInterrupted </para></para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public virtual void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a  <code>boolean</code> indicating whether the current Thread (  <code>currentThread()</code>) has a pending interrupt request ( <code> true</code>) or not ( <code>false</code>). It also has the side-effect of clearing the flag.</para> <para> <para>Thread::currentThread </para> <para>Thread::interrupt </para> <para>Thread::isInterrupted </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>boolean</code> indicating the interrupt status </para>
				/// </returns>
				/// <java-name>
				/// interrupted
				/// </java-name>
				[Dot42.DexImport("interrupted", "()Z", AccessFlags = 9)]
				public static bool Interrupted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Blocks the current Thread ( <code>Thread.currentThread()</code>) until the receiver finishes its execution and dies.</para> <para> <para>Object::notifyAll </para> <para>java.lang.ThreadDeath </para></para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "()V", AccessFlags = 17)]
				public void Join() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Blocks the current Thread ( <code>Thread.currentThread()</code>) until the receiver finishes its execution and dies or the specified timeout expires, whatever happens first.</para> <para> <para>Object::notifyAll </para> <para>java.lang.ThreadDeath </para></para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(J)V", AccessFlags = 17)]
				public void Join(long millis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Blocks the current Thread ( <code>Thread.currentThread()</code>) until the receiver finishes its execution and dies or the specified timeout expires, whatever happens first.</para> <para> <para>Object::notifyAll </para> <para>java.lang.ThreadDeath </para></para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(JI)V", AccessFlags = 17)]
				public void Join(long millis, int nanos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Throws <c>UnsupportedOperationException </c> .  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Only useful in conjunction with deprecated method Thread#suspend. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 17)]
				public void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calls the  <code>run()</code> method of the Runnable object the receiver holds. If no Runnable is set, does nothing.</para> <para> <para>Thread::start </para></para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes the thread which sent this message to sleep for the given interval of time (given in milliseconds). The precision is not guaranteed - the Thread may sleep more or less than requested.</para> <para> <para>Thread::interrupt() </para></para>        
				/// </summary>
				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(J)V", AccessFlags = 9)]
				public static void Sleep(long time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes the thread which sent this message to sleep for the given interval of time (given in milliseconds and nanoseconds). The precision is not guaranteed - the Thread may sleep more or less than requested.</para> <para> <para>Thread::interrupt() </para></para>        
				/// </summary>
				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(JI)V", AccessFlags = 9)]
				public static void Sleep(long millis, int nanos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts the new Thread of execution. The  <code>run()</code> method of the receiver will be called by the receiver Thread itself (and not the Thread calling  <code>start()</code>).</para> <para> <para>Thread::run </para></para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 33)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Requests the receiver Thread to stop and throw ThreadDeath. The Thread is resumed if it was suspended and awakened if it was sleeping, so that it can proceed to throw ThreadDeath.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Stopping a thread in this manner is unsafe and can leave your application and the VM in an unpredictable state. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 17)]
				public void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Throws <c>UnsupportedOperationException </c> .  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Stopping a thread in this manner is unsafe and can leave your application and the VM in an unpredictable state. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "(Ljava/lang/Throwable;)V", AccessFlags = 49)]
				public void Stop(global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Throws <c>UnsupportedOperationException </c> .  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>May cause deadlocks. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// suspend
				/// </java-name>
				[Dot42.DexImport("suspend", "()V", AccessFlags = 17)]
				public void Suspend() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of the Thread. It includes the Thread's name, priority, and group name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for the receiver. </para>
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
				///  <para>Causes the calling Thread to yield execution time to another Thread that is ready to run. The actual scheduling is implementation-dependent. </para>        
				/// </summary>
				/// <java-name>
				/// yield
				/// </java-name>
				[Dot42.DexImport("yield", "()V", AccessFlags = 9)]
				public static void Yield() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether the current Thread has a monitor lock on the specified object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the current thread has a monitor lock on the specified object; false otherwise </para>
				/// </returns>
				/// <java-name>
				/// holdsLock
				/// </java-name>
				[Dot42.DexImport("holdsLock", "(Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool HoldsLock(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the Thread of the caller, that is, the current Thread.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current Thread. </para>
				/// </returns>
				/// <java-name>
				/// currentThread
				/// </java-name>
				public static global::System.Threading.Thread CurrentThread
				{
						[Dot42.DexImport("currentThread", "()Ljava/lang/Thread;", AccessFlags = 9)]
						get{ return default(global::System.Threading.Thread); }
				}

				/// <summary>
				///  <para>Returns a map of all the currently live threads to their stack traces. </para>        
				/// </summary>
				/// <java-name>
				/// getAllStackTraces
				/// </java-name>
				public static global::Java.Util.IMap<global::System.Threading.Thread, global::Java.Lang.StackTraceElement[]> AllStackTraces
				{
						[Dot42.DexImport("getAllStackTraces", "()Ljava/util/Map;", AccessFlags = 9, Signature = "()Ljava/util/Map<Ljava/lang/Thread;[Ljava/lang/StackTraceElement;>;")]
						get{ return default(global::Java.Util.IMap<global::System.Threading.Thread, global::Java.Lang.StackTraceElement[]>); }
				}

				/// <summary>
				///  <para>Returns the context ClassLoader for this Thread.</para> <para> <para>java.lang.ClassLoader </para> <para>getContextClassLoader() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ClassLoader The context ClassLoader </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the default exception handler that's executed when uncaught exception terminates a thread.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an UncaughtExceptionHandler or  <code>null</code> if none exists. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the thread's identifier. The ID is a positive  <code>long</code> generated on thread creation, is unique to the thread, and doesn't change during the lifetime of the thread; the ID may be reused after the thread has been terminated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the thread's ID. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public virtual long Id
				{
						[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the name of the Thread. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns the priority of the Thread. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns an array of StackTraceElement representing the current thread's stack. </para>        
				/// </summary>
				/// <java-name>
				/// getStackTrace
				/// </java-name>
				public virtual global::Java.Lang.StackTraceElement[] StackTrace
				{
						[Dot42.DexImport("getStackTrace", "()[Ljava/lang/StackTraceElement;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.StackTraceElement[]); }
				}

				/// <summary>
				///  <para>Returns the ThreadGroup to which this Thread belongs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Thread's ThreadGroup </para>
				/// </returns>
				/// <java-name>
				/// getThreadGroup
				/// </java-name>
				public global::Java.Lang.ThreadGroup ThreadGroup
				{
						[Dot42.DexImport("getThreadGroup", "()Ljava/lang/ThreadGroup;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ThreadGroup); }
				}

				/// <summary>
				///  <para>Returns the thread's uncaught exception handler. If not explicitly set, then the ThreadGroup's handler is returned. If the thread is terminated, then  <code>null</code> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an UncaughtExceptionHandler instance or <c>null </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns  <code>true</code> if the receiver has already been started and still runs code (hasn't died yet). Returns  <code>false</code> either if the receiver hasn't been started yet or if it has already started and run to completion and died.</para> <para> <para>Thread::start </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>boolean</code> indicating the liveness of the Thread </para>
				/// </returns>
				/// <java-name>
				/// isAlive
				/// </java-name>
				public bool IsAlive
				{
						[Dot42.DexImport("isAlive", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Tests whether this is a daemon thread. A daemon thread only runs as long as there are non-daemon threads running. When the last non-daemon thread ends, the runtime will exit. This is not normally relevant to applications with a UI. </para>        
				/// </summary>
				/// <java-name>
				/// isDaemon
				/// </java-name>
				public bool IsDaemon
				{
						[Dot42.DexImport("isDaemon", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setDaemon", "(Z)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Returns a  <code>boolean</code> indicating whether the receiver has a pending interrupt request ( <code>true</code>) or not (  <code>false</code>)</para> <para> <para>Thread::interrupt </para> <para>Thread::interrupted </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>boolean</code> indicating the interrupt status </para>
				/// </returns>
				/// <java-name>
				/// isInterrupted
				/// </java-name>
				public virtual bool IsInterrupted
				{
						[Dot42.DexImport("isInterrupted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Implemented by objects that want to handle cases where a thread is being terminated by an uncaught exception. Upon such termination, the handler is notified of the terminating thread and causal exception. If there is no explicit handler set then the thread's group is the default handler. </para>    
				/// </summary>
				/// <java-name>
				/// java/lang/Thread$UncaughtExceptionHandler
				/// </java-name>
				[Dot42.DexImport("java/lang/Thread$UncaughtExceptionHandler", AccessFlags = 1545)]
				public partial interface IUncaughtExceptionHandler
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The thread is being terminated by an uncaught exception. Further exceptions thrown in this method are prevent the remainder of the method from executing, but are otherwise ignored.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// uncaughtException
						/// </java-name>
						[Dot42.DexImport("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", AccessFlags = 1025)]
						void UncaughtException(global::System.Threading.Thread thread, global::System.Exception ex) /* MethodBuilder.Create */ ;

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
						[Dot42.DexImport("values", "()[Ljava/lang/Thread$State;", AccessFlags = 25)]
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

