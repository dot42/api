#pragma warning disable 1717
namespace Android.OS
{
		/// <summary>
		///  <para>AsyncTask enables proper and easy use of the UI thread. This class allows to perform background operations and publish results on the UI thread without having to manipulate threads and/or handlers.</para> <para>AsyncTask is designed to be a helper class around Thread and Handler and does not constitute a generic threading framework. AsyncTasks should ideally be used for short operations (a few seconds at the most.) If you need to keep threads running for long periods of time, it is highly recommended you use the various APIs provided by the  <code>java.util.concurrent</code> pacakge such as Executor, ThreadPoolExecutor and FutureTask.</para> <para>An asynchronous task is defined by a computation that runs on a background thread and whose result is published on the UI thread. An asynchronous task is defined by 3 generic types, called  <code>Params</code>,  <code>Progress</code> and  <code>Result</code>, and 4 steps, called  <code>onPreExecute</code>,  <code>doInBackground</code>,  <code>onProgressUpdate</code> and  <code>onPostExecute</code>.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using tasks and threads, read the  developer guide.</para> <para> </para> <para> <h2>Usage</h2></para> <para>AsyncTask must be subclassed to be used. The subclass will override at least one method (doInBackground), and most often will override a second one (onPostExecute.)</para> <para>Here is an example of subclassing:</para> <para> <pre>
		/// private class DownloadFilesTask extends AsyncTask&lt;URL, Integer, Long&gt; {
		///     protected Long doInBackground(URL... urls) {
		///         int count = urls.length;
		///         long totalSize = 0;
		///         for (int i = 0; i &lt; count; i++) {
		///             totalSize += Downloader.downloadFile(urls[i]);
		///             publishProgress((int) ((i / (float) count) * 100));
		///             // Escape early if cancel() is called
		///             if (isCancelled()) break;
		///         }
		///         return totalSize;
		///     }</pre></para> <para> <pre>    protected void onProgressUpdate(Integer... progress) {
		///         setProgressPercent(progress[0]);
		///     }</pre></para> <para> <pre>    protected void onPostExecute(Long result) {
		///         showDialog("Downloaded " + result + " bytes");
		///     }
		/// }
		/// </pre></para> <para>Once created, a task is executed very simply:</para> <para> <pre>
		/// new DownloadFilesTask().execute(url1, url2, url3);
		/// </pre></para> <para> <h2>AsyncTask's generic types</h2></para> <para>The three types used by an asynchronous task are the following:</para> <para> <ol> <li> <para> <code>Params</code>, the type of the parameters sent to the task upon execution. </para></li> <li> <para> <code>Progress</code>, the type of the progress units published during the background computation. </para></li> <li> <para> <code>Result</code>, the type of the result of the background computation. </para></li></ol></para> <para>Not all types are always used by an asynchronous task. To mark a type as unused, simply use the type Void:</para> <para> <pre>
		/// private class MyTask extends AsyncTask&lt;Void, Void, Void&gt; { ... }
		/// </pre></para> <para> <h2>The 4 steps</h2></para> <para>When an asynchronous task is executed, the task goes through 4 steps:</para> <para> <ol> <li> <para>onPreExecute(), invoked on the UI thread before the task is executed. This step is normally used to setup the task, for instance by showing a progress bar in the user interface. </para></li> <li> <para>doInBackground, invoked on the background thread immediately after onPreExecute() finishes executing. This step is used to perform background computation that can take a long time. The parameters of the asynchronous task are passed to this step. The result of the computation must be returned by this step and will be passed back to the last step. This step can also use publishProgress to publish one or more units of progress. These values are published on the UI thread, in the onProgressUpdate step. </para></li> <li> <para>onProgressUpdate, invoked on the UI thread after a call to publishProgress. The timing of the execution is undefined. This method is used to display any form of progress in the user interface while the background computation is still executing. For instance, it can be used to animate a progress bar or show logs in a text field. </para></li> <li> <para>onPostExecute, invoked on the UI thread after the background computation finishes. The result of the background computation is passed to this step as a parameter. </para></li></ol></para> <para> <h2>Cancelling a task</h2></para> <para>A task can be cancelled at any time by invoking cancel(boolean). Invoking this method will cause subsequent calls to isCancelled() to return true. After invoking this method, onCancelled(Object), instead of onPostExecute(Object) will be invoked after doInBackground(Object[]) returns. To ensure that a task is cancelled as quickly as possible, you should always check the return value of isCancelled() periodically from doInBackground(Object[]), if possible (inside a loop for instance.)</para> <para> <h2>Threading rules</h2></para> <para>There are a few threading rules that must be followed for this class to work properly:</para> <para> <ul> <li> <para>The AsyncTask class must be loaded on the UI thread. This is done automatically as of android.os.Build.VERSION_CODES#JELLY_BEAN. </para></li> <li> <para>The task instance must be created on the UI thread. </para></li> <li> <para>execute must be invoked on the UI thread. </para></li> <li> <para>Do not call onPreExecute(), onPostExecute, doInBackground, onProgressUpdate manually. </para></li> <li> <para>The task can be executed only once (an exception will be thrown if a second execution is attempted.) </para></li></ul></para> <para> <h2>Memory observability</h2></para> <para>AsyncTask guarantees that all callback calls are synchronized in such a way that the following operations are safe without explicit synchronizations.</para> <para> <ul> <li> <para>Set member fields in the constructor or onPreExecute, and refer to them in doInBackground. </para></li> <li> <para>Set member fields in doInBackground, and refer to them in onProgressUpdate and onPostExecute. </para></li></ul></para> <para> <h2>Order of execution</h2></para> <para>When first introduced, AsyncTasks were executed serially on a single background thread. Starting with android.os.Build.VERSION_CODES#DONUT, this was changed to a pool of threads allowing multiple tasks to operate in parallel. Starting with android.os.Build.VERSION_CODES#HONEYCOMB, tasks are executed on a single thread to avoid common application errors caused by parallel execution.</para> <para>If you truly want parallel execution, you can invoke executeOnExecutor(java.util.concurrent.Executor, Object[]) with THREAD_POOL_EXECUTOR.</para>    
		/// </summary>
		/// <java-name>
		/// android/os/AsyncTask
		/// </java-name>
		[Dot42.DexImport("android/os/AsyncTask", AccessFlags = 1057, Signature = "<Params:Ljava/lang/Object;Progress:Ljava/lang/Object;Result:Ljava/lang/Object;>Lj" +
    "ava/lang/Object;")]
		public abstract partial class AsyncTask<Params, Progress, Result>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An Executor that can be used to execute tasks in parallel. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_POOL_EXECUTOR
				/// </java-name>
				[Dot42.DexImport("THREAD_POOL_EXECUTOR", "Ljava/util/concurrent/Executor;", AccessFlags = 25)]
				public static readonly global::Java.Util.Concurrent.IExecutor THREAD_POOL_EXECUTOR;
				/// <summary>
				///  <para>An Executor that executes tasks one at a time in serial order. This serialization is global to a particular process. </para>        
				/// </summary>
				/// <java-name>
				/// SERIAL_EXECUTOR
				/// </java-name>
				[Dot42.DexImport("SERIAL_EXECUTOR", "Ljava/util/concurrent/Executor;", AccessFlags = 25)]
				public static readonly global::Java.Util.Concurrent.IExecutor SERIAL_EXECUTOR;
				/// <summary>
				///  <para>Creates a new asynchronous task. This constructor must be invoked on the UI thread. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AsyncTask() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current status of this task.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current status. </para>
				/// </returns>
				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()Landroid/os/AsyncTask$Status;", AccessFlags = 17)]
				public global::Android.OS.AsyncTask<Params, Progress, Result>.Status GetStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.AsyncTask<Params, Progress, Result>.Status);
				}

				/// <summary>
				///  <para>Override this method to perform a computation on a background thread. The specified parameters are the parameters passed to execute by the caller of this task.</para> <para>This method can call publishProgress to publish updates on the UI thread.</para> <para> <para>onPreExecute() </para> <para>onPostExecute </para> <para>publishProgress </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A result, defined by the subclass of this task.</para>
				/// </returns>
				/// <java-name>
				/// doInBackground
				/// </java-name>
				[Dot42.DexImport("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1156, Signature = "([TParams;)TResult;")]
				protected internal abstract Result DoInBackground(params Params[] @params) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Runs on the UI thread before doInBackground.</para> <para> <para>onPostExecute </para> <para>doInBackground </para></para>        
				/// </summary>
				/// <java-name>
				/// onPreExecute
				/// </java-name>
				[Dot42.DexImport("onPreExecute", "()V", AccessFlags = 4)]
				protected internal virtual void OnPreExecute() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs on the UI thread after doInBackground. The specified result is the value returned by doInBackground.</para> <para>This method won't be invoked if the task was cancelled.</para> <para> <para>onPreExecute </para> <para>doInBackground </para> <para>#onCancelled(Object) </para></para>        
				/// </summary>
				/// <java-name>
				/// onPostExecute
				/// </java-name>
				[Dot42.DexImport("onPostExecute", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TResult;)V")]
				protected internal virtual void OnPostExecute(Result result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs on the UI thread after publishProgress is invoked. The specified values are the values passed to publishProgress.</para> <para> <para>publishProgress </para> <para>doInBackground </para></para>        
				/// </summary>
				/// <java-name>
				/// onProgressUpdate
				/// </java-name>
				[Dot42.DexImport("onProgressUpdate", "([Ljava/lang/Object;)V", AccessFlags = 132, Signature = "([TProgress;)V")]
				protected internal virtual void OnProgressUpdate(params Progress[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs on the UI thread after cancel(boolean) is invoked and doInBackground(Object[]) has finished.</para> <para>The default implementation simply invokes onCancelled() and ignores the result. If you write your own implementation, do not call  <code>super.onCancelled(result)</code>.</para> <para> <para>cancel(boolean) </para> <para>isCancelled() </para></para>        
				/// </summary>
				/// <java-name>
				/// onCancelled
				/// </java-name>
				[Dot42.DexImport("onCancelled", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TResult;)V")]
				protected internal virtual void OnCancelled(Result result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applications should preferably override onCancelled(Object). This method is invoked by the default implementation of onCancelled(Object).</para> <para>Runs on the UI thread after cancel(boolean) is invoked and doInBackground(Object[]) has finished.</para> <para> <para>#onCancelled(Object) </para> <para>cancel(boolean) </para> <para>isCancelled() </para></para>        
				/// </summary>
				/// <java-name>
				/// onCancelled
				/// </java-name>
				[Dot42.DexImport("onCancelled", "()V", AccessFlags = 4)]
				protected internal virtual void OnCancelled() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to cancel execution of this task. This attempt will fail if the task has already completed, already been cancelled, or could not be cancelled for some other reason. If successful, and this task has not started when  <code>cancel</code> is called, this task should never run. If the task has already started, then the  <code>mayInterruptIfRunning</code> parameter determines whether the thread executing this task should be interrupted in an attempt to stop the task.</para> <para>Calling this method will result in onCancelled(Object) being invoked on the UI thread after doInBackground(Object[]) returns. Calling this method guarantees that onPostExecute(Object) is never invoked. After invoking this method, you should check the value returned by isCancelled() periodically from doInBackground(Object[]) to finish the task as early as possible.</para> <para> <para>isCancelled() </para> <para>#onCancelled(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>false</code> if the task could not be cancelled, typically because it has already completed normally;  <code>true</code> otherwise</para>
				/// </returns>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 17)]
				public bool Cancel(bool mayInterruptIfRunning) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Waits if necessary for the computation to complete, and then retrieves its result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The computed result.</para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 17, Signature = "()TResult;")]
				public Result Get() /* MethodBuilder.Create */ 
				{
						return default(Result);
				}

				/// <summary>
				///  <para>Waits if necessary for at most the given time for the computation to complete, and then retrieves its result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The computed result.</para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(JLjava/util/concurrent/TimeUnit;)TResult;")]
				public Result Get(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ 
				{
						return default(Result);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;", AccessFlags = 145, Signature = "([TParams;)Landroid/os/AsyncTask<TParams;TProgress;TResult;>;")]
				public global::Android.OS.AsyncTask<Params, Progress, Result> Execute(params Params[] p) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.AsyncTask<Params, Progress, Result>);
				}

				/// <summary>
				///  <para>Executes the task with the specified parameters. The task returns itself (this) so that the caller can keep a reference to it.</para> <para>This method is typically used with THREAD_POOL_EXECUTOR to allow multiple tasks to run in parallel on a pool of threads managed by AsyncTask, however you can also use your own Executor for custom behavior.</para> <para> <b>Warning:</b> Allowing multiple tasks to run in parallel from a thread pool is generally  <b>not</b> what one wants, because the order of their operation is not defined. For example, if these tasks are used to modify any state in common (such as writing a file due to a button click), there are no guarantees on the order of the modifications. Without careful work it is possible in rare cases for the newer version of the data to be over-written by an older one, leading to obscure data loss and stability issues. Such changes are best executed in serial; to guarantee such work is serialized regardless of platform version you can use this function with SERIAL_EXECUTOR.</para> <para>This method must be invoked on the UI thread.</para> <para> <para>#execute(Object[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This instance of AsyncTask.</para>
				/// </returns>
				/// <java-name>
				/// executeOnExecutor
				/// </java-name>
				[Dot42.DexImport("executeOnExecutor", "(Ljava/util/concurrent/Executor;[Ljava/lang/Object;)Landroid/os/AsyncTask;", AccessFlags = 145, Signature = "(Ljava/util/concurrent/Executor;[TParams;)Landroid/os/AsyncTask<TParams;TProgress" +
    ";TResult;>;")]
				public global::Android.OS.AsyncTask<Params, Progress, Result> ExecuteOnExecutor(global::Java.Util.Concurrent.IExecutor exec, params Params[] @params) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.AsyncTask<Params, Progress, Result>);
				}

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 9)]
				public static void Execute(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method can be invoked from doInBackground to publish updates on the UI thread while the background computation is still running. Each call to this method will trigger the execution of onProgressUpdate on the UI thread.</para> <para>onProgressUpdate will note be called if the task has been canceled.</para> <para> <para>onProgressUpdate </para> <para>doInBackground </para></para>        
				/// </summary>
				/// <java-name>
				/// publishProgress
				/// </java-name>
				[Dot42.DexImport("publishProgress", "([Ljava/lang/Object;)V", AccessFlags = 148, Signature = "([TProgress;)V")]
				protected internal void PublishProgress(params Progress[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if this task was cancelled before it completed normally. If you are calling cancel(boolean) on the task, the value returned by this method should be checked periodically from doInBackground(Object[]) to end the task as soon as possible.</para> <para> <para>cancel(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if task was cancelled before it completed</para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				public bool IsCancelled
				{
						[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/os/AsyncTask$Status
				/// </java-name>
				[Dot42.DexImport("android/os/AsyncTask$Status", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/os/AsyncTask$Status;>;")]
				public sealed class Status
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FINISHED
						/// </java-name>
						[Dot42.DexImport("FINISHED", "Landroid/os/AsyncTask$Status;", AccessFlags = 16409)]
						public static readonly Status FINISHED;
						/// <java-name>
						/// PENDING
						/// </java-name>
						[Dot42.DexImport("PENDING", "Landroid/os/AsyncTask$Status;", AccessFlags = 16409)]
						public static readonly Status PENDING;
						/// <java-name>
						/// RUNNING
						/// </java-name>
						[Dot42.DexImport("RUNNING", "Landroid/os/AsyncTask$Status;", AccessFlags = 16409)]
						public static readonly Status RUNNING;
						private Status() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/os/AsyncTask$Status;", AccessFlags = 9)]
						public static Status[] Values() /* MethodBuilder.Create */ 
						{
								return default(Status[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;", AccessFlags = 9)]
						public static Status ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Status);
						}

				}

		}

		/// <summary>
		///  <para>The object you are calling has died, because its hosting process no longer exists. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/BadParcelableException
		/// </java-name>
		[Dot42.DexImport("android/os/BadParcelableException", AccessFlags = 33)]
		public partial class BadParcelableException : global::Android.Util.AndroidRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BadParcelableException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public BadParcelableException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal BadParcelableException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The BatteryManager class contains strings and constants used for values in the android.content.Intent#ACTION_BATTERY_CHANGED Intent. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/BatteryManager
		/// </java-name>
		[Dot42.DexImport("android/os/BatteryManager", AccessFlags = 33)]
		public partial class BatteryManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the current status constant. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STATUS
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATUS = "status";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the current health constant. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_HEALTH
				/// </java-name>
				[Dot42.DexImport("EXTRA_HEALTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_HEALTH = "health";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: boolean indicating whether a battery is present. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PRESENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_PRESENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PRESENT = "present";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer field containing the current battery level, from 0 to EXTRA_SCALE. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LEVEL
				/// </java-name>
				[Dot42.DexImport("EXTRA_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LEVEL = "level";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the maximum battery level. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SCALE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCALE = "scale";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the resource ID of a small status bar icon indicating the current battery state. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ICON_SMALL
				/// </java-name>
				[Dot42.DexImport("EXTRA_ICON_SMALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ICON_SMALL = "icon-small";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer indicating whether the device is plugged in to a power source; 0 means it is on battery, other constants are different types of power sources. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PLUGGED
				/// </java-name>
				[Dot42.DexImport("EXTRA_PLUGGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PLUGGED = "plugged";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the current battery voltage level. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOLTAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOLTAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOLTAGE = "voltage";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: integer containing the current battery temperature. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEMPERATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEMPERATURE = "temperature";
				/// <summary>
				///  <para>Extra for android.content.Intent#ACTION_BATTERY_CHANGED: String describing the technology of the current battery. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("EXTRA_TECHNOLOGY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TECHNOLOGY = "technology";
				/// <java-name>
				/// BATTERY_STATUS_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("BATTERY_STATUS_UNKNOWN", "I", AccessFlags = 25)]
				public const int BATTERY_STATUS_UNKNOWN = 1;
				/// <java-name>
				/// BATTERY_STATUS_CHARGING
				/// </java-name>
				[Dot42.DexImport("BATTERY_STATUS_CHARGING", "I", AccessFlags = 25)]
				public const int BATTERY_STATUS_CHARGING = 2;
				/// <java-name>
				/// BATTERY_STATUS_DISCHARGING
				/// </java-name>
				[Dot42.DexImport("BATTERY_STATUS_DISCHARGING", "I", AccessFlags = 25)]
				public const int BATTERY_STATUS_DISCHARGING = 3;
				/// <java-name>
				/// BATTERY_STATUS_NOT_CHARGING
				/// </java-name>
				[Dot42.DexImport("BATTERY_STATUS_NOT_CHARGING", "I", AccessFlags = 25)]
				public const int BATTERY_STATUS_NOT_CHARGING = 4;
				/// <java-name>
				/// BATTERY_STATUS_FULL
				/// </java-name>
				[Dot42.DexImport("BATTERY_STATUS_FULL", "I", AccessFlags = 25)]
				public const int BATTERY_STATUS_FULL = 5;
				/// <java-name>
				/// BATTERY_HEALTH_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_UNKNOWN", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_UNKNOWN = 1;
				/// <java-name>
				/// BATTERY_HEALTH_GOOD
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_GOOD", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_GOOD = 2;
				/// <java-name>
				/// BATTERY_HEALTH_OVERHEAT
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_OVERHEAT", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_OVERHEAT = 3;
				/// <java-name>
				/// BATTERY_HEALTH_DEAD
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_DEAD", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_DEAD = 4;
				/// <java-name>
				/// BATTERY_HEALTH_OVER_VOLTAGE
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_OVER_VOLTAGE", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_OVER_VOLTAGE = 5;
				/// <java-name>
				/// BATTERY_HEALTH_UNSPECIFIED_FAILURE
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_UNSPECIFIED_FAILURE", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_UNSPECIFIED_FAILURE = 6;
				/// <java-name>
				/// BATTERY_HEALTH_COLD
				/// </java-name>
				[Dot42.DexImport("BATTERY_HEALTH_COLD", "I", AccessFlags = 25)]
				public const int BATTERY_HEALTH_COLD = 7;
				/// <summary>
				///  <para>Power source is an AC charger. </para>        
				/// </summary>
				/// <java-name>
				/// BATTERY_PLUGGED_AC
				/// </java-name>
				[Dot42.DexImport("BATTERY_PLUGGED_AC", "I", AccessFlags = 25)]
				public const int BATTERY_PLUGGED_AC = 1;
				/// <summary>
				///  <para>Power source is a USB port. </para>        
				/// </summary>
				/// <java-name>
				/// BATTERY_PLUGGED_USB
				/// </java-name>
				[Dot42.DexImport("BATTERY_PLUGGED_USB", "I", AccessFlags = 25)]
				public const int BATTERY_PLUGGED_USB = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BatteryManager() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Base class for a remotable object, the core part of a lightweight remote procedure call mechanism defined by IBinder. This class is an implementation of IBinder that provides the standard support creating a local implementation of such an object.</para> <para>Most developers will not implement this class directly, instead using the  tool to describe the desired interface, having it generate the appropriate Binder subclass. You can, however, derive directly from Binder to implement your own custom RPC protocol or simply instantiate a raw Binder object directly to use as a token that can be shared across processes.</para> <para> <para>IBinder </para></para>    
		/// </summary>
		/// <java-name>
		/// android/os/Binder
		/// </java-name>
		[Dot42.DexImport("android/os/Binder", AccessFlags = 33)]
		public partial class Binder : global::Android.OS.IBinder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor initializes the object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Binder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the identity of the incoming IPC on the current thread. This can be useful if, while handling an incoming call, you will be calling on interfaces of other objects that may be local to your process and need to do permission checks on the calls coming into them (so they will check the permission of your own local process, and not whatever process originally called you).</para> <para> <para>getCallingPid() </para> <para>getCallingUid() </para> <para>restoreCallingIdentity(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an opaque token that can be used to restore the original calling identity by passing it to restoreCallingIdentity(long).</para>
				/// </returns>
				/// <java-name>
				/// clearCallingIdentity
				/// </java-name>
				[Dot42.DexImport("clearCallingIdentity", "()J", AccessFlags = 281)]
				public static long ClearCallingIdentity() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Restore the identity of the incoming IPC on the current thread back to a previously identity that was returned by clearCallingIdentity.</para> <para> <para>clearCallingIdentity </para></para>        
				/// </summary>
				/// <java-name>
				/// restoreCallingIdentity
				/// </java-name>
				[Dot42.DexImport("restoreCallingIdentity", "(J)V", AccessFlags = 281)]
				public static void RestoreCallingIdentity(long token) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flush any Binder commands pending in the current thread to the kernel driver. This can be useful to call before performing an operation that may block for a long time, to ensure that any pending object references have been released in order to prevent the process from holding on to objects longer than it needs to. </para>        
				/// </summary>
				/// <java-name>
				/// flushPendingCommands
				/// </java-name>
				[Dot42.DexImport("flushPendingCommands", "()V", AccessFlags = 281)]
				public static void FlushPendingCommands() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add the calling thread to the IPC thread pool. This function does not return until the current process is exiting. </para>        
				/// </summary>
				/// <java-name>
				/// joinThreadPool
				/// </java-name>
				[Dot42.DexImport("joinThreadPool", "()V", AccessFlags = 281)]
				public static void JoinThreadPool() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method for associating a specific interface with the Binder. After calling, queryLocalInterface() will be implemented for you to return the given owner IInterface when the corresponding descriptor is requested. </para>        
				/// </summary>
				/// <java-name>
				/// attachInterface
				/// </java-name>
				[Dot42.DexImport("attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AttachInterface(global::Android.OS.IInterface owner, string descriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Default implementation always returns true  if you got here, the object is alive. </para>        
				/// </summary>
				/// <java-name>
				/// pingBinder
				/// </java-name>
				[Dot42.DexImport("pingBinder", "()Z", AccessFlags = 1)]
				public virtual bool PingBinder() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Use information supplied to attachInterface() to return the associated IInterface if it matches the requested descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// queryLocalInterface
				/// </java-name>
				[Dot42.DexImport("queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", AccessFlags = 1)]
				public virtual global::Android.OS.IInterface QueryLocalInterface(string descriptor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IInterface);
				}

				/// <summary>
				///  <para>Default implementation is a stub that returns false. You will want to override this to do the appropriate unmarshalling of transactions.</para> <para>If you want to call this, call transact(). </para>        
				/// </summary>
				/// <java-name>
				/// onTransact
				/// </java-name>
				[Dot42.DexImport("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 4)]
				protected internal virtual bool OnTransact(int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Implemented to call the more convenient version dump(FileDescriptor, PrintWriter, String[]). </para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Java.IO.FileDescriptor fd, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like dump(FileDescriptor, String[]), but ensures the target executes asynchronously. </para>        
				/// </summary>
				/// <java-name>
				/// dumpAsync
				/// </java-name>
				[Dot42.DexImport("dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void DumpAsync(global::Java.IO.FileDescriptor fd, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Print the object's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void Dump(global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter fout, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Default implementation rewinds the parcels and calls onTransact. On the remote side, transact calls into the binder to do the IPC. </para>        
				/// </summary>
				/// <java-name>
				/// transact
				/// </java-name>
				[Dot42.DexImport("transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 17)]
				public bool Transact(int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Local implementation is a no-op. </para>        
				/// </summary>
				/// <java-name>
				/// linkToDeath
				/// </java-name>
				[Dot42.DexImport("linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", AccessFlags = 1)]
				public virtual void LinkToDeath(global::Android.OS.IBinder_IDeathRecipient recipient, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Local implementation is a no-op. </para>        
				/// </summary>
				/// <java-name>
				/// unlinkToDeath
				/// </java-name>
				[Dot42.DexImport("unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", AccessFlags = 1)]
				public virtual bool UnlinkToDeath(global::Android.OS.IBinder_IDeathRecipient recipient, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Binder() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the ID of the process that sent you the current transaction that is being processed. This pid can be used with higher-level system services to determine its identity and check permissions. If the current thread is not currently executing an incoming transaction, then its own pid is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getCallingPid
				/// </java-name>
				public static int CallingPid
				{
						[Dot42.DexImport("getCallingPid", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the Linux uid assigned to the process that sent you the current transaction that is being processed. This uid can be used with higher-level system services to determine its identity and check permissions. If the current thread is not currently executing an incoming transaction, then its own uid is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getCallingUid
				/// </java-name>
				public static int CallingUid
				{
						[Dot42.DexImport("getCallingUid", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Default implementation returns an empty interface name. </para>        
				/// </summary>
				/// <java-name>
				/// getInterfaceDescriptor
				/// </java-name>
				public virtual string InterfaceDescriptor
				{
						[Dot42.DexImport("getInterfaceDescriptor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para> <para>Check to see if the process that the binder is in is still alive.</para> <para></para></para> <para>Note that if you're calling on a local binder, this always returns true because your process is alive if you're calling it. </para>        
				/// </summary>
				/// <returns>
				///  <para>false if the process is not alive. Note that if it returns true, the process may have died while the call is returning.</para>
				/// </returns>
				/// <java-name>
				/// isBinderAlive
				/// </java-name>
				public virtual bool IsBinderAlive
				{
						[Dot42.DexImport("isBinderAlive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Information about the current build, extracted from system properties. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Build
		/// </java-name>
		[Dot42.DexImport("android/os/Build", AccessFlags = 33)]
		public partial class Build
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Value used for when a build property is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// UNKNOWN
				/// </java-name>
				[Dot42.DexImport("UNKNOWN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNKNOWN = "unknown";
				/// <summary>
				///  <para>Either a changelist number, or a label like "M4-rc20". </para>        
				/// </summary>
				/// <java-name>
				/// ID
				/// </java-name>
				[Dot42.DexImport("ID", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ID;
				/// <summary>
				///  <para>A build ID string meant for displaying to the user </para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY
				/// </java-name>
				[Dot42.DexImport("DISPLAY", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DISPLAY;
				/// <summary>
				///  <para>The name of the overall product. </para>        
				/// </summary>
				/// <java-name>
				/// PRODUCT
				/// </java-name>
				[Dot42.DexImport("PRODUCT", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string PRODUCT;
				/// <summary>
				///  <para>The name of the industrial design. </para>        
				/// </summary>
				/// <java-name>
				/// DEVICE
				/// </java-name>
				[Dot42.DexImport("DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DEVICE;
				/// <summary>
				///  <para>The name of the underlying board, like "goldfish". </para>        
				/// </summary>
				/// <java-name>
				/// BOARD
				/// </java-name>
				[Dot42.DexImport("BOARD", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BOARD;
				/// <summary>
				///  <para>The name of the instruction set (CPU type + ABI convention) of native code. </para>        
				/// </summary>
				/// <java-name>
				/// CPU_ABI
				/// </java-name>
				[Dot42.DexImport("CPU_ABI", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string CPU_ABI;
				/// <summary>
				///  <para>The name of the second instruction set (CPU type + ABI convention) of native code. </para>        
				/// </summary>
				/// <java-name>
				/// CPU_ABI2
				/// </java-name>
				[Dot42.DexImport("CPU_ABI2", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string CPU_ABI2;
				/// <summary>
				///  <para>The manufacturer of the product/hardware. </para>        
				/// </summary>
				/// <java-name>
				/// MANUFACTURER
				/// </java-name>
				[Dot42.DexImport("MANUFACTURER", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string MANUFACTURER;
				/// <summary>
				///  <para>The brand (e.g., carrier) the software is customized for, if any. </para>        
				/// </summary>
				/// <java-name>
				/// BRAND
				/// </java-name>
				[Dot42.DexImport("BRAND", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BRAND;
				/// <summary>
				///  <para>The end-user-visible name for the end product. </para>        
				/// </summary>
				/// <java-name>
				/// MODEL
				/// </java-name>
				[Dot42.DexImport("MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string MODEL;
				/// <summary>
				///  <para>The system bootloader version number. </para>        
				/// </summary>
				/// <java-name>
				/// BOOTLOADER
				/// </java-name>
				[Dot42.DexImport("BOOTLOADER", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BOOTLOADER;
				/// <summary>
				///  <para>The radio firmware version number.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The radio firmware version is frequently not available when this class is initialized, leading to a blank or "unknown" value for this string. Use getRadioVersion instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RADIO
				/// </java-name>
				[Dot42.DexImport("RADIO", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string RADIO;
				/// <summary>
				///  <para>The name of the hardware (from the kernel command line or /proc). </para>        
				/// </summary>
				/// <java-name>
				/// HARDWARE
				/// </java-name>
				[Dot42.DexImport("HARDWARE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string HARDWARE;
				/// <summary>
				///  <para>A hardware serial number, if available. Alphanumeric only, case-insensitive. </para>        
				/// </summary>
				/// <java-name>
				/// SERIAL
				/// </java-name>
				[Dot42.DexImport("SERIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string SERIAL;
				/// <summary>
				///  <para>The type of build, like "user" or "eng". </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string TYPE;
				/// <summary>
				///  <para>Comma-separated tags describing the build, like "unsigned,debug". </para>        
				/// </summary>
				/// <java-name>
				/// TAGS
				/// </java-name>
				[Dot42.DexImport("TAGS", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string TAGS;
				/// <summary>
				///  <para>A string that uniquely identifies this build. Do not attempt to parse this value. </para>        
				/// </summary>
				/// <java-name>
				/// FINGERPRINT
				/// </java-name>
				[Dot42.DexImport("FINGERPRINT", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string FINGERPRINT;
				/// <java-name>
				/// TIME
				/// </java-name>
				[Dot42.DexImport("TIME", "J", AccessFlags = 25)]
				public static readonly long TIME;
				/// <java-name>
				/// USER
				/// </java-name>
				[Dot42.DexImport("USER", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string USER;
				/// <java-name>
				/// HOST
				/// </java-name>
				[Dot42.DexImport("HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string HOST;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Build() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the version string for the radio firmware. May return null (if, for instance, the radio is not currently on). </para>        
				/// </summary>
				/// <java-name>
				/// getRadioVersion
				/// </java-name>
				public static string RadioVersion
				{
						[Dot42.DexImport("getRadioVersion", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Enumeration of the currently known SDK version codes. These are the values that can be found in VERSION#SDK. Version numbers increment monotonically with each official platform release. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/Build$VERSION_CODES
				/// </java-name>
				[Dot42.DexImport("android/os/Build$VERSION_CODES", AccessFlags = 9)]
				public partial class VERSION_CODES
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Magic version number for a current development build, which has not yet turned into an official release. </para>        
						/// </summary>
						/// <java-name>
						/// CUR_DEVELOPMENT
						/// </java-name>
						[Dot42.DexImport("CUR_DEVELOPMENT", "I", AccessFlags = 25)]
						public const int CUR_DEVELOPMENT = 10000;
						/// <summary>
						///  <para>October 2008: The original, first, version of Android. Yay! </para>        
						/// </summary>
						/// <java-name>
						/// BASE
						/// </java-name>
						[Dot42.DexImport("BASE", "I", AccessFlags = 25)]
						public const int BASE = 1;
						/// <summary>
						///  <para>February 2009: First Android update, officially called 1.1. </para>        
						/// </summary>
						/// <java-name>
						/// BASE_1_1
						/// </java-name>
						[Dot42.DexImport("BASE_1_1", "I", AccessFlags = 25)]
						public const int BASE_1_1 = 2;
						/// <summary>
						///  <para>May 2009: Android 1.5. </para>        
						/// </summary>
						/// <java-name>
						/// CUPCAKE
						/// </java-name>
						[Dot42.DexImport("CUPCAKE", "I", AccessFlags = 25)]
						public const int CUPCAKE = 3;
						/// <summary>
						///  <para>September 2009: Android 1.6.</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>They must explicitly request the android.Manifest.permission#WRITE_EXTERNAL_STORAGE permission to be able to modify the contents of the SD card. (Apps targeting earlier versions will always request the permission.) </para></li> <li> <para>They must explicitly request the android.Manifest.permission#READ_PHONE_STATE permission to be able to be able to retrieve phone state info. (Apps targeting earlier versions will always request the permission.) </para></li> <li> <para>They are assumed to support different screen densities and sizes. (Apps targeting earlier versions are assumed to only support medium density normal size screens unless otherwise indicated). They can still explicitly specify screen support either way with the supports-screens manifest tag. </para></li> <li> <para>android.widget.TabHost will use the new dark tab background design. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// DONUT
						/// </java-name>
						[Dot42.DexImport("DONUT", "I", AccessFlags = 25)]
						public const int DONUT = 4;
						/// <summary>
						///  <para>November 2009: Android 2.0</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>The Service.onStartCommand function will return the new android.app.Service#START_STICKY behavior instead of the old compatibility android.app.Service#START_STICKY_COMPATIBILITY. </para></li> <li> <para>The android.app.Activity class will now execute back key presses on the key up instead of key down, to be able to detect canceled presses from virtual keys. </para></li> <li> <para>The android.widget.TabWidget class will use a new color scheme for tabs. In the new scheme, the foreground tab has a medium gray background the background tabs have a dark gray background. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ECLAIR
						/// </java-name>
						[Dot42.DexImport("ECLAIR", "I", AccessFlags = 25)]
						public const int ECLAIR = 5;
						/// <summary>
						///  <para>December 2009: Android 2.0.1 </para>        
						/// </summary>
						/// <java-name>
						/// ECLAIR_0_1
						/// </java-name>
						[Dot42.DexImport("ECLAIR_0_1", "I", AccessFlags = 25)]
						public const int ECLAIR_0_1 = 6;
						/// <summary>
						///  <para>January 2010: Android 2.1 </para>        
						/// </summary>
						/// <java-name>
						/// ECLAIR_MR1
						/// </java-name>
						[Dot42.DexImport("ECLAIR_MR1", "I", AccessFlags = 25)]
						public const int ECLAIR_MR1 = 7;
						/// <summary>
						///  <para>June 2010: Android 2.2 </para>        
						/// </summary>
						/// <java-name>
						/// FROYO
						/// </java-name>
						[Dot42.DexImport("FROYO", "I", AccessFlags = 25)]
						public const int FROYO = 8;
						/// <summary>
						///  <para>November 2010: Android 2.3</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>The application's notification icons will be shown on the new dark status bar background, so must be visible in this situation. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// GINGERBREAD
						/// </java-name>
						[Dot42.DexImport("GINGERBREAD", "I", AccessFlags = 25)]
						public const int GINGERBREAD = 9;
						/// <summary>
						///  <para>February 2011: Android 2.3.3. </para>        
						/// </summary>
						/// <java-name>
						/// GINGERBREAD_MR1
						/// </java-name>
						[Dot42.DexImport("GINGERBREAD_MR1", "I", AccessFlags = 25)]
						public const int GINGERBREAD_MR1 = 10;
						/// <summary>
						///  <para>February 2011: Android 3.0.</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>The default theme for applications is now dark holographic: android.R.style#Theme_Holo. </para></li> <li> <para>On large screen devices that do not have a physical menu button, the soft (compatibility) menu is disabled. </para></li> <li> <para>The activity lifecycle has changed slightly as per android.app.Activity. </para></li> <li> <para>An application will crash if it does not call through to the super implementation of its Activity.onPause() method. </para></li> <li> <para>When an application requires a permission to access one of its components (activity, receiver, service, provider), this permission is no longer enforced when the application wants to access its own component. This means it can require a permission on a component that it does not itself hold and still access that component. </para></li> <li> <para>Context.getSharedPreferences() will not automatically reload the preferences if they have changed on storage, unless android.content.Context#MODE_MULTI_PROCESS is used. </para></li> <li> <para>android.view.ViewGroup#setMotionEventSplittingEnabled will default to true. </para></li> <li> <para>android.view.WindowManager.LayoutParams#FLAG_SPLIT_TOUCH is enabled by default on windows. </para></li> <li> <para>PopupWindow.isSplitTouchEnabled() will return true by default. </para></li> <li> <para>android.widget.GridView and android.widget.ListView will use View.setActivated for selected items if they do not implement android.widget.Checkable. </para></li> <li> <para>android.widget.Scroller will be constructed with "flywheel" behavior enabled by default. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// HONEYCOMB
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB", "I", AccessFlags = 25)]
						public const int HONEYCOMB = 11;
						/// <summary>
						///  <para>May 2011: Android 3.1. </para>        
						/// </summary>
						/// <java-name>
						/// HONEYCOMB_MR1
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB_MR1", "I", AccessFlags = 25)]
						public const int HONEYCOMB_MR1 = 12;
						/// <summary>
						///  <para>June 2011: Android 3.2.</para> <para>Update to Honeycomb MR1 to support 7 inch tablets, improve screen compatibility mode, etc.</para> <para>As of this version, applications that don't say whether they support XLARGE screens will be assumed to do so only if they target HONEYCOMB or later; it had been GINGERBREAD or later. Applications that don't support a screen size at least as large as the current screen will provide the user with a UI to switch them in to screen size compatibility mode.</para> <para>This version introduces new screen size resource qualifiers based on the screen size in dp: see android.content.res.Configuration#screenWidthDp, android.content.res.Configuration#screenHeightDp, and android.content.res.Configuration#smallestScreenWidthDp. Supplying these in &lt;supports-screens&gt; as per android.content.pm.ApplicationInfo#requiresSmallestWidthDp, android.content.pm.ApplicationInfo#compatibleWidthLimitDp, and android.content.pm.ApplicationInfo#largestWidthLimitDp is preferred over the older screen size buckets and for older devices the appropriate buckets will be inferred from them.</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para></para> <para>New android.content.pm.PackageManager#FEATURE_SCREEN_PORTRAIT and android.content.pm.PackageManager#FEATURE_SCREEN_LANDSCAPE features were introduced in this release. Applications that target previous platform versions are assumed to require both portrait and landscape support in the device; when targeting Honeycomb MR1 or greater the application is responsible for specifying any specific orientation it requires.</para> <para></para></li> <li> <para></para> <para>android.os.AsyncTask will use the serial executor by default when calling android.os.AsyncTask#execute.</para> <para></para></li> <li> <para></para> <para>ActivityInfo.configChanges will have the android.content.pm.ActivityInfo#CONFIG_SCREEN_SIZE and android.content.pm.ActivityInfo#CONFIG_SMALLEST_SCREEN_SIZE bits set; these need to be cleared for older applications because some developers have done absolute comparisons against this value instead of correctly masking the bits they are interested in. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// HONEYCOMB_MR2
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB_MR2", "I", AccessFlags = 25)]
						public const int HONEYCOMB_MR2 = 13;
						/// <summary>
						///  <para>October 2011: Android 4.0.</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>For devices without a dedicated menu key, the software compatibility menu key will not be shown even on phones. By targeting Ice Cream Sandwich or later, your UI must always have its own menu UI affordance if needed, on both tablets and phones. The ActionBar will take care of this for you. </para></li> <li> <para>2d drawing hardware acceleration is now turned on by default. You can use android:hardwareAccelerated to turn it off if needed, although this is strongly discouraged since it will result in poor performance on larger screen devices. </para></li> <li> <para>The default theme for applications is now the "device default" theme: android.R.style#Theme_DeviceDefault. This may be the holo dark theme or a different dark theme defined by the specific device. The android.R.style#Theme_Holo family must not be modified for a device to be considered compatible. Applications that explicitly request a theme from the Holo family will be guaranteed that these themes will not change character within the same platform version. Applications that wish to blend in with the device should use a theme from the android.R.style#Theme_DeviceDefault family. </para></li> <li> <para>Managed cursors can now throw an exception if you directly close the cursor yourself without stopping the management of it; previously failures would be silently ignored. </para></li> <li> <para>The fadingEdge attribute on views will be ignored (fading edges is no longer a standard part of the UI). A new requiresFadingEdge attribute allows applications to still force fading edges on for special cases. </para></li> <li> <para>Context.bindService() will not automatically add in android.content.Context#BIND_WAIVE_PRIORITY. </para></li> <li> <para>App Widgets will have standard padding automatically added around them, rather than relying on the padding being baked into the widget itself. </para></li> <li> <para>An exception will be thrown if you try to change the type of a window after it has been added to the window manager. Previously this would result in random incorrect behavior. </para></li> <li> <para>android.view.animation.AnimationSet will parse out the duration, fillBefore, fillAfter, repeatMode, and startOffset XML attributes that are defined. </para></li> <li> <para>ActionBar.setHomeButtonEnabled() is false by default. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ICE_CREAM_SANDWICH
						/// </java-name>
						[Dot42.DexImport("ICE_CREAM_SANDWICH", "I", AccessFlags = 25)]
						public const int ICE_CREAM_SANDWICH = 14;
						/// <summary>
						///  <para>December 2011: Android 4.0.3. </para>        
						/// </summary>
						/// <java-name>
						/// ICE_CREAM_SANDWICH_MR1
						/// </java-name>
						[Dot42.DexImport("ICE_CREAM_SANDWICH_MR1", "I", AccessFlags = 25)]
						public const int ICE_CREAM_SANDWICH_MR1 = 15;
						/// <summary>
						///  <para>June 2012: Android 4.1.</para> <para>Applications targeting this or a later release will get these new changes in behavior:</para> <para> <ul> <li> <para>You must explicitly request the android.Manifest.permission#READ_CALL_LOG and/or android.Manifest.permission#WRITE_CALL_LOG permissions; access to the call log is no longer implicitly provided through android.Manifest.permission#READ_CONTACTS and android.Manifest.permission#WRITE_CONTACTS. </para></li> <li> <para>android.widget.RemoteViews will throw an exception if setting an onClick handler for views being generated by a android.widget.RemoteViewsService for a collection container; previously this just resulted in a warning log message. </para></li> <li> <para>New android.app.ActionBar policy for embedded tabs: embedded tabs are now always stacked in the action bar when in portrait mode, regardless of the size of the screen. </para></li> <li> <para>WebSettings.setAllowFileAccessFromFileURLs and WebSettings.setAllowUniversalAccessFromFileURLs default to false. </para></li> <li> <para>Calls to PackageManager.setComponentEnabledSetting will now throw an IllegalArgumentException if the given component class name does not exist in the application's manifest. </para></li> <li> <para>NfcAdapter.setNdefPushMessage, NfcAdapter.setNdefPushMessageCallback and NfcAdapter.setOnNdefPushCompleteCallback will throw IllegalStateException if called after the Activity has been destroyed. </para></li> <li> <para>Accessibility services must require the new android.Manifest.permission#BIND_ACCESSIBILITY_SERVICE permission or they will not be available for use. </para></li> <li> <para>AccessibilityServiceInfo.FLAG_INCLUDE_NOT_IMPORTANT_VIEWS must be set for unimportant views to be included in queries. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// JELLY_BEAN
						/// </java-name>
						[Dot42.DexImport("JELLY_BEAN", "I", AccessFlags = 25)]
						public const int JELLY_BEAN = 16;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public VERSION_CODES() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Various version strings. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/Build$VERSION
				/// </java-name>
				[Dot42.DexImport("android/os/Build$VERSION", AccessFlags = 9)]
				public partial class VERSION
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The internal value used by the underlying source control to represent this build. E.g., a perforce changelist number or a git hash. </para>        
						/// </summary>
						/// <java-name>
						/// INCREMENTAL
						/// </java-name>
						[Dot42.DexImport("INCREMENTAL", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string INCREMENTAL;
						/// <summary>
						///  <para>The user-visible version string. E.g., "1.0" or "3.4b5". </para>        
						/// </summary>
						/// <java-name>
						/// RELEASE
						/// </java-name>
						[Dot42.DexImport("RELEASE", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string RELEASE;
						/// <summary>
						///  <para>The user-visible SDK version of the framework in its raw String representation; use SDK_INT instead.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use SDK_INT to easily get this as an integer. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SDK
						/// </java-name>
						[Dot42.DexImport("SDK", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string SDK;
						/// <summary>
						///  <para>The user-visible SDK version of the framework; its possible values are defined in Build.VERSION_CODES. </para>        
						/// </summary>
						/// <java-name>
						/// SDK_INT
						/// </java-name>
						[Dot42.DexImport("SDK_INT", "I", AccessFlags = 25)]
						public static readonly int SDK_INT;
						/// <summary>
						///  <para>The current development codename, or the string "REL" if this is a release build. </para>        
						/// </summary>
						/// <java-name>
						/// CODENAME
						/// </java-name>
						[Dot42.DexImport("CODENAME", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string CODENAME;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public VERSION() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A mapping from String values to various Parcelable types. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Bundle
		/// </java-name>
		[Dot42.DexImport("android/os/Bundle", AccessFlags = 49)]
		public sealed partial class Bundle : global::Android.OS.IParcelable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EMPTY
				/// </java-name>
				[Dot42.DexImport("EMPTY", "Landroid/os/Bundle;", AccessFlags = 25)]
				public static readonly global::Android.OS.Bundle EMPTY;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.Bundle> CREATOR;
				/// <summary>
				///  <para>Constructs a new, empty Bundle. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Bundle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty Bundle sized to hold the given number of elements. The Bundle will grow as needed.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public Bundle(global::Java.Lang.ClassLoader capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty Bundle sized to hold the given number of elements. The Bundle will grow as needed.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Bundle(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new, empty Bundle sized to hold the given number of elements. The Bundle will grow as needed.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public Bundle(global::Android.OS.Bundle capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones the current Bundle. The internal map is cloned, but the keys and values to which it refers are copied by reference. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the number of mappings contained in this Bundle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of mappings as an int. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all elements from the mapping of this Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the given key is contained in the mapping of this Bundle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the key is part of the mapping, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsKey(string key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the entry with the given key as an object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an Object, or null </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Removes any entry with the given key from the mapping of this Bundle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Remove(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts all mappings from the given Bundle into this Bundle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void PutAll(global::Android.OS.Bundle map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a Set containing the Strings used as keys in this Bundle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Set of String keys </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				///  <para>Inserts a Boolean value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public void PutBoolean(string key, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a byte value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putByte
				/// </java-name>
				[Dot42.DexImport("putByte", "(Ljava/lang/String;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void PutByte(string key, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a byte value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putByte
				/// </java-name>
				[Dot42.DexImport("putByte", "(Ljava/lang/String;B)V", AccessFlags = 1)]
				public void PutByte(string key, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a char value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(Ljava/lang/String;C)V", AccessFlags = 1)]
				public void PutChar(string key, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a short value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(Ljava/lang/String;S)V", AccessFlags = 1)]
				public void PutShort(string key, short value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an int value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void PutInt(string key, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a long value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public void PutLong(string key, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a float value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1)]
				public void PutFloat(string key, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a double value into the mapping of this Bundle, replacing any existing value for the given key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1)]
				public void PutDouble(string key, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a String value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutString(string key, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a CharSequence value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putCharSequence
				/// </java-name>
				[Dot42.DexImport("putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void PutCharSequence(string key, global::Java.Lang.ICharSequence value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a Parcelable value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putParcelable
				/// </java-name>
				[Dot42.DexImport("putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public void PutParcelable(string key, global::Android.OS.IParcelable value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an array of Parcelable values into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putParcelableArray
				/// </java-name>
				[Dot42.DexImport("putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public void PutParcelableArray(string key, global::Android.OS.IParcelable[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a List of Parcelable values into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putParcelableArrayList
				/// </java-name>
				[Dot42.DexImport("putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<+Landroid/os/Parcelable;>;)V")]
				public void PutParcelableArrayList(string key, global::Java.Util.ArrayList<global::Android.OS.IParcelable> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a SparceArray of Parcelable values into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putSparseParcelableArray
				/// </java-name>
				[Dot42.DexImport("putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/util/SparseArray<+Landroid/os/Parcelable;>;)V")]
				public void PutSparseParcelableArray(string key, global::Android.Util.SparseArray<global::Android.OS.IParcelable> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an ArrayList&lt;Integer&gt; value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putIntegerArrayList
				/// </java-name>
				[Dot42.DexImport("putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/Integer;>;)V")]
				public void PutIntegerArrayList(string key, global::Java.Util.ArrayList<int?> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an ArrayList&lt;String&gt; value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putStringArrayList
				/// </java-name>
				[Dot42.DexImport("putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;)V")]
				public void PutStringArrayList(string key, global::Java.Util.ArrayList<string> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an ArrayList&lt;CharSequence&gt; value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putCharSequenceArrayList
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/CharSequence;>;)V")]
				public void PutCharSequenceArrayList(string key, global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a Serializable value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putSerializable
				/// </java-name>
				[Dot42.DexImport("putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V", AccessFlags = 1)]
				public void PutSerializable(string key, global::Java.IO.ISerializable value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a boolean array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putBooleanArray
				/// </java-name>
				[Dot42.DexImport("putBooleanArray", "(Ljava/lang/String;[Z)V", AccessFlags = 1)]
				public void PutBooleanArray(string key, bool[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a byte array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void PutByteArray(string key, sbyte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a byte array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public void PutByteArray(string key, byte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a short array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putShortArray
				/// </java-name>
				[Dot42.DexImport("putShortArray", "(Ljava/lang/String;[S)V", AccessFlags = 1)]
				public void PutShortArray(string key, short[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a char array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putCharArray
				/// </java-name>
				[Dot42.DexImport("putCharArray", "(Ljava/lang/String;[C)V", AccessFlags = 1)]
				public void PutCharArray(string key, char[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an int array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putIntArray
				/// </java-name>
				[Dot42.DexImport("putIntArray", "(Ljava/lang/String;[I)V", AccessFlags = 1)]
				public void PutIntArray(string key, int[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a long array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putLongArray
				/// </java-name>
				[Dot42.DexImport("putLongArray", "(Ljava/lang/String;[J)V", AccessFlags = 1)]
				public void PutLongArray(string key, long[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a float array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putFloatArray
				/// </java-name>
				[Dot42.DexImport("putFloatArray", "(Ljava/lang/String;[F)V", AccessFlags = 1)]
				public void PutFloatArray(string key, float[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a double array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putDoubleArray
				/// </java-name>
				[Dot42.DexImport("putDoubleArray", "(Ljava/lang/String;[D)V", AccessFlags = 1)]
				public void PutDoubleArray(string key, double[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a String array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putStringArray
				/// </java-name>
				[Dot42.DexImport("putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutStringArray(string key, string[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a CharSequence array value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putCharSequenceArray
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void PutCharSequenceArray(string key, global::Java.Lang.ICharSequence[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts a Bundle value into the mapping of this Bundle, replacing any existing value for the given key. Either key or value may be null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putBundle
				/// </java-name>
				[Dot42.DexImport("putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void PutBundle(string key, global::Android.OS.Bundle value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or false if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a boolean value </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool GetBoolean(string key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a boolean value </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public bool GetBoolean(string key, bool defaultValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or (byte) 0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte JavaGetByte(string key) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or (byte) 0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1)]
				public byte GetByte(string key) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte? GetByte(string key, sbyte defaultValue) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte value </para>
				/// </returns>
				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", AccessFlags = 1)]
				public sbyte? GetByte(string key, byte defaultValue) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or (char) 0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a char value </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/String;)C", AccessFlags = 1)]
				public char GetChar(string key) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a char value </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/String;C)C", AccessFlags = 1)]
				public char GetChar(string key, char defaultValue) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or (short) 0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a short value </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;)S", AccessFlags = 1)]
				public short GetShort(string key) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a short value </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;S)S", AccessFlags = 1)]
				public short GetShort(string key, short defaultValue) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or 0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an int value </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetInt(string key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an int value </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int GetInt(string key, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or 0L if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a long value </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1)]
				public long GetLong(string key) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a long value </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public long GetLong(string key, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or 0.0f if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a float value </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;)F", AccessFlags = 1)]
				public float GetFloat(string key) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a float value </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public float GetFloat(string key, float defaultValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or 0.0 if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a double value </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1)]
				public double GetDouble(string key) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a double value </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public double GetDouble(string key, double defaultValue) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String value, or null </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetString(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the String value associated with the given key, or defaultValue if no valid String object is currently mapped to that key. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetString(string key, string defaultValue) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a CharSequence value, or null </para>
				/// </returns>
				/// <java-name>
				/// getCharSequence
				/// </java-name>
				[Dot42.DexImport("getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetCharSequence(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or defaultValue if no mapping of the desired type exists for the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the CharSequence value associated with the given key, or defaultValue if no valid CharSequence object is currently mapped to that key. </para>
				/// </returns>
				/// <java-name>
				/// getCharSequence
				/// </java-name>
				[Dot42.DexImport("getCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetCharSequence(string key, global::Java.Lang.ICharSequence defaultValue) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Bundle value, or null </para>
				/// </returns>
				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle GetBundle(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Parcelable value, or null </para>
				/// </returns>
				/// <java-name>
				/// getParcelable
				/// </java-name>
				[Dot42.DexImport("getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)TT;")]
				public T GetParcelable<T>(string key) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Parcelable[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getParcelableArray
				/// </java-name>
				[Dot42.DexImport("getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;", AccessFlags = 1)]
				public global::Android.OS.IParcelable[] GetParcelableArray(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ArrayList&lt;T&gt; value, or null </para>
				/// </returns>
				/// <java-name>
				/// getParcelableArrayList
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Ljava/util/ArrayList<TT;>;")]
				public global::Java.Util.ArrayList<T> GetParcelableArrayList<T>(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a SparseArray of T values, or null </para>
				/// </returns>
				/// <java-name>
				/// getSparseParcelableArray
				/// </java-name>
				[Dot42.DexImport("getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Landroid/util/SparseArray<TT;>;")]
				public global::Android.Util.SparseArray<T> GetSparseParcelableArray<T>(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseArray<T>);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Serializable value, or null </para>
				/// </returns>
				/// <java-name>
				/// getSerializable
				/// </java-name>
				[Dot42.DexImport("getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;", AccessFlags = 1)]
				public global::Java.IO.ISerializable GetSerializable(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ISerializable);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ArrayList&lt;String&gt; value, or null </para>
				/// </returns>
				/// <java-name>
				/// getIntegerArrayList
				/// </java-name>
				[Dot42.DexImport("getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/Integer;>;")]
				public global::Java.Util.ArrayList<int?> GetIntegerArrayList(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<int?>);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ArrayList&lt;String&gt; value, or null </para>
				/// </returns>
				/// <java-name>
				/// getStringArrayList
				/// </java-name>
				[Dot42.DexImport("getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> GetStringArrayList(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ArrayList&lt;CharSequence&gt; value, or null </para>
				/// </returns>
				/// <java-name>
				/// getCharSequenceArrayList
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/CharSequence;>;")]
				public global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> GetCharSequenceArrayList(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Java.Lang.ICharSequence>);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a boolean[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getBooleanArray
				/// </java-name>
				[Dot42.DexImport("getBooleanArray", "(Ljava/lang/String;)[Z", AccessFlags = 1)]
				public bool[] GetBooleanArray(string key) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetByteArray(string key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public byte[] GetByteArray(string key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a short[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getShortArray
				/// </java-name>
				[Dot42.DexImport("getShortArray", "(Ljava/lang/String;)[S", AccessFlags = 1)]
				public short[] GetShortArray(string key) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a char[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getCharArray
				/// </java-name>
				[Dot42.DexImport("getCharArray", "(Ljava/lang/String;)[C", AccessFlags = 1)]
				public char[] GetCharArray(string key) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an int[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public int[] GetIntArray(string key) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a long[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getLongArray
				/// </java-name>
				[Dot42.DexImport("getLongArray", "(Ljava/lang/String;)[J", AccessFlags = 1)]
				public long[] GetLongArray(string key) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a float[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getFloatArray
				/// </java-name>
				[Dot42.DexImport("getFloatArray", "(Ljava/lang/String;)[F", AccessFlags = 1)]
				public float[] GetFloatArray(string key) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a double[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getDoubleArray
				/// </java-name>
				[Dot42.DexImport("getDoubleArray", "(Ljava/lang/String;)[D", AccessFlags = 1)]
				public double[] GetDoubleArray(string key) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] GetStringArray(string key) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Returns the value associated with the given key, or null if no mapping of the desired type exists for the given key or a null value is explicitly associated with the key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a CharSequence[] value, or null </para>
				/// </returns>
				/// <java-name>
				/// getCharSequenceArray
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence[] GetCharSequenceArray(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				///  <para>Report the nature of this Parcelable's contents </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Writes the Bundle contents to a Parcel, typically in order for it to be passed through an IBinder connection. </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads the Parcel contents into this Bundle, typically in order for it to be passed through an IBinder connection. </para>        
				/// </summary>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the ClassLoader currently associated with this Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
						[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
						[Dot42.DexImport("setClassLoader", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns true if the mapping of this Bundle is empty, false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Reports whether the bundle contains any parcelled file descriptors. </para>        
				/// </summary>
				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				public bool HasFileDescriptors
				{
						[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Provides the ability to cancel an operation in progress. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/CancellationSignal
		/// </java-name>
		[Dot42.DexImport("android/os/CancellationSignal", AccessFlags = 49)]
		public sealed partial class CancellationSignal
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a cancellation signal, initially not canceled. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CancellationSignal() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Throws OperationCanceledException if the operation has been canceled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// throwIfCanceled
				/// </java-name>
				[Dot42.DexImport("throwIfCanceled", "()V", AccessFlags = 1)]
				public void ThrowIfCanceled() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancels the operation and signals the cancellation listener. If the operation has not yet started, then it will be canceled as soon as it does. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the cancellation listener to be called when canceled.</para> <para>This method is intended to be used by the recipient of a cancellation signal such as a database or a content provider to handle cancellation requests while performing a long-running operation. This method is not intended to be used by applications themselves.</para> <para>If CancellationSignal#cancel has already been called, then the provided listener is invoked immediately.</para> <para>This method is guaranteed that the listener will not be called after it has been removed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCancelListener
				/// </java-name>
				[Dot42.DexImport("setOnCancelListener", "(Landroid/os/CancellationSignal$OnCancelListener;)V", AccessFlags = 1)]
				public void SetOnCancelListener(global::Android.OS.CancellationSignal.IOnCancelListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the operation has been canceled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the operation has been canceled. </para>
				/// </returns>
				/// <java-name>
				/// isCanceled
				/// </java-name>
				public bool IsCanceled
				{
						[Dot42.DexImport("isCanceled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Listens for cancellation. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/CancellationSignal$OnCancelListener
				/// </java-name>
				[Dot42.DexImport("android/os/CancellationSignal$OnCancelListener", AccessFlags = 1545)]
				public partial interface IOnCancelListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when CancellationSignal#cancel is invoked. </para>        
						/// </summary>
						/// <java-name>
						/// onCancel
						/// </java-name>
						[Dot42.DexImport("onCancel", "()V", AccessFlags = 1025)]
						void OnCancel() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Class that implements the condition variable locking paradigm.</para> <para>This differs from the built-in java.lang.Object wait() and notify() in that this class contains the condition to wait on itself. That means open(), close() and block() are sticky. If open() is called before block(), block() will not block, and instead return immediately.</para> <para>This class uses itself as the object to wait on, so if you wait() or notify() on a ConditionVariable, the results are undefined. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/ConditionVariable
		/// </java-name>
		[Dot42.DexImport("android/os/ConditionVariable", AccessFlags = 33)]
		public partial class ConditionVariable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create the ConditionVariable in the default closed state. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConditionVariable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create the ConditionVariable with the given state.</para> <para>Pass true for opened and false for closed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ConditionVariable(bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Open the condition, and release all threads that are blocked.</para> <para>Any threads that later approach block() will not block unless close() is called. </para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()V", AccessFlags = 1)]
				public virtual void Open() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the condition to the closed state.</para> <para>Any threads that call block() will block until someone calls open. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Block the current thread until the condition is opened.</para> <para>If the condition is already opened, return immediately. </para>        
				/// </summary>
				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "()V", AccessFlags = 1)]
				public virtual void Block() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Block the current thread until the condition is opened or until timeout milliseconds have passed.</para> <para>If the condition is already opened, return immediately.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the condition was opened, false if the call returns because of the timeout. </para>
				/// </returns>
				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "(J)Z", AccessFlags = 1)]
				public virtual bool Block(long timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>Schedule a countdown until a time in the future, with regular notifications on intervals along the way.</para> <para>Example of showing a 30 second countdown in a text field:</para> <para> <pre>
		/// new CountDownTimer(30000, 1000) {</pre></para> <para> <pre>    public void onTick(long millisUntilFinished) {
		///         mTextField.setText("seconds remaining: " + millisUntilFinished / 1000);
		///     }</pre></para> <para> <pre>    public void onFinish() {
		///         mTextField.setText("done!");
		///     }
		///  }.start();
		/// </pre></para> <para>The calls to onTick(long) are synchronized to this object so that one call to onTick(long) won't ever occur before the previous callback is complete. This is only relevant when the implementation of onTick(long) takes an amount of time to execute that is significant compared to the countdown interval. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/CountDownTimer
		/// </java-name>
		[Dot42.DexImport("android/os/CountDownTimer", AccessFlags = 1057)]
		public abstract partial class CountDownTimer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJ)V", AccessFlags = 1)]
				public CountDownTimer(long millisInFuture, long countDownInterval) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel the countdown. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start the countdown. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Landroid/os/CountDownTimer;", AccessFlags = 49)]
				public global::Android.OS.CountDownTimer Start() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.CountDownTimer);
				}

				/// <summary>
				///  <para>Callback fired on regular interval. </para>        
				/// </summary>
				/// <java-name>
				/// onTick
				/// </java-name>
				[Dot42.DexImport("onTick", "(J)V", AccessFlags = 1025)]
				public abstract void OnTick(long millisUntilFinished) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback fired when the time is up. </para>        
				/// </summary>
				/// <java-name>
				/// onFinish
				/// </java-name>
				[Dot42.DexImport("onFinish", "()V", AccessFlags = 1025)]
				public abstract void OnFinish() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CountDownTimer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The object you are calling has died, because its hosting process no longer exists. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/DeadObjectException
		/// </java-name>
		[Dot42.DexImport("android/os/DeadObjectException", AccessFlags = 33)]
		public partial class DeadObjectException : global::Android.OS.RemoteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DeadObjectException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Provides various debugging methods for Android applications, including tracing and allocation counts. </para> <para> <b>Logging Trace Files</b></para> <para>Debug can create log files that give details about an application, such as a call stack and start/stop times for any running methods. See  for information about reading trace files. To start logging trace files, call one of the startMethodTracing() methods. To stop tracing, call stopMethodTracing(). </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Debug
		/// </java-name>
		[Dot42.DexImport("android/os/Debug", AccessFlags = 49)]
		public sealed partial class Debug
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flags for startMethodTracing(). These can be ORed together.</para> <para>TRACE_COUNT_ALLOCS adds the results from startAllocCounting to the trace key file. </para>        
				/// </summary>
				/// <java-name>
				/// TRACE_COUNT_ALLOCS
				/// </java-name>
				[Dot42.DexImport("TRACE_COUNT_ALLOCS", "I", AccessFlags = 25)]
				public const int TRACE_COUNT_ALLOCS = 1;
				/// <summary>
				///  <para>Flags for printLoadedClasses(). Default behavior is to only show the class name. </para>        
				/// </summary>
				/// <java-name>
				/// SHOW_FULL_DETAIL
				/// </java-name>
				[Dot42.DexImport("SHOW_FULL_DETAIL", "I", AccessFlags = 25)]
				public const int SHOW_FULL_DETAIL = 1;
				/// <java-name>
				/// SHOW_CLASSLOADER
				/// </java-name>
				[Dot42.DexImport("SHOW_CLASSLOADER", "I", AccessFlags = 25)]
				public const int SHOW_CLASSLOADER = 2;
				/// <java-name>
				/// SHOW_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("SHOW_INITIALIZED", "I", AccessFlags = 25)]
				public const int SHOW_INITIALIZED = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Debug() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Wait until a debugger attaches. As soon as the debugger attaches, this returns, so you will need to place a breakpoint after the waitForDebugger() call if you want to start tracing immediately. </para>        
				/// </summary>
				/// <java-name>
				/// waitForDebugger
				/// </java-name>
				[Dot42.DexImport("waitForDebugger", "()V", AccessFlags = 9)]
				public static void WaitForDebugger() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns "true" if one or more threads is waiting for a debugger to attach. </para>        
				/// </summary>
				/// <java-name>
				/// waitingForDebugger
				/// </java-name>
				[Dot42.DexImport("waitingForDebugger", "()Z", AccessFlags = 9)]
				public static bool WaitingForDebugger() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Change the JDWP port.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>no longer needed or useful </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// changeDebugPort
				/// </java-name>
				[Dot42.DexImport("changeDebugPort", "(I)V", AccessFlags = 9)]
				public static void ChangeDebugPort(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable qemu tracing. For this to work requires running everything inside the qemu emulator; otherwise, this method will have no effect. The trace file is specified on the command line when the emulator is started. For example, the following command line  <br></br>  <code>emulator -trace foo</code> <br></br> will start running the emulator and create a trace file named "foo". This method simply enables writing the trace records to the trace file.</para> <para>The main differences between this and startMethodTracing() are that tracing in the qemu emulator traces every cpu instruction of every process, including kernel code, so we have more complete information, including all context switches. We can also get more detailed information such as cache misses. The sequence of calls is determined by post-processing the instruction trace. The qemu tracing is also done without modifying the application or perturbing the timing of calls because no instrumentation is added to the application being traced. </para> <para>One limitation of using this method compared to using startMethodTracing() on the real device is that the emulator does not model all of the real hardware effects such as memory and bus contention. The emulator also has a simple cache model and cannot capture all the complexities of a real cache. </para>        
				/// </summary>
				/// <java-name>
				/// startNativeTracing
				/// </java-name>
				[Dot42.DexImport("startNativeTracing", "()V", AccessFlags = 9)]
				public static void StartNativeTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop qemu tracing. See startNativeTracing() to start tracing.</para> <para>Tracing can be started and stopped as many times as desired. When the qemu emulator itself is stopped then the buffered trace records are flushed and written to the trace file. In fact, it is not necessary to call this method at all; simply killing qemu is sufficient. But starting and stopping a trace is useful for examining a specific region of code.</para>        
				/// </summary>
				/// <java-name>
				/// stopNativeTracing
				/// </java-name>
				[Dot42.DexImport("stopNativeTracing", "()V", AccessFlags = 9)]
				public static void StopNativeTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable "emulator traces", in which information about the current method is made available to the "emulator -trace" feature. There is no corresponding "disable" call  this is intended for use by the framework when tracing should be turned on and left that way, so that traces captured with F9/F10 will include the necessary data.</para> <para>This puts the VM into "profile" mode, which has performance consequences.</para> <para>To temporarily enable tracing, use startNativeTracing(). </para>        
				/// </summary>
				/// <java-name>
				/// enableEmulatorTraceOutput
				/// </java-name>
				[Dot42.DexImport("enableEmulatorTraceOutput", "()V", AccessFlags = 9)]
				public static void EnableEmulatorTraceOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start method tracing with default log name and buffer size. See  for information about reading these files. Call stopMethodTracing() to stop tracing. </para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "()V", AccessFlags = 9)]
				public static void StartMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start method tracing, specifying the trace log file name. The trace file will be put under "/sdcard" unless an absolute path is given. See  for information about reading trace files.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void StartMethodTracing(string traceName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start method tracing, specifying the trace log file name and the buffer size. The trace files will be put under "/sdcard" unless an absolute path is given. See  for information about reading trace files. </para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;I)V", AccessFlags = 9)]
				public static void StartMethodTracing(string traceName, int bufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start method tracing, specifying the trace log file name and the buffer size. The trace files will be put under "/sdcard" unless an absolute path is given. See  for information about reading trace files.</para> <para>When method tracing is enabled, the VM will run more slowly than usual, so the timings from the trace files should only be considered in relative terms (e.g. was run #1 faster than run #2). The times for native methods will not change, so don't try to use this to compare the performance of interpreted and native implementations of the same method. As an alternative, consider using "native" tracing in the emulator via startNativeTracing(). </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;II)V", AccessFlags = 9)]
				public static void StartMethodTracing(string traceName, int bufferSize, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop method tracing. </para>        
				/// </summary>
				/// <java-name>
				/// stopMethodTracing
				/// </java-name>
				[Dot42.DexImport("stopMethodTracing", "()V", AccessFlags = 9)]
				public static void StopMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an indication of thread CPU usage. The value returned indicates the amount of time that the current thread has spent executing code or waiting for certain types of I/O.</para> <para>The time is expressed in nanoseconds, and is only meaningful when compared to the result from an earlier call. Note that nanosecond resolution does not imply nanosecond accuracy.</para> <para>On system which don't support this operation, the call returns -1. </para>        
				/// </summary>
				/// <java-name>
				/// threadCpuTimeNanos
				/// </java-name>
				[Dot42.DexImport("threadCpuTimeNanos", "()J", AccessFlags = 9)]
				public static long ThreadCpuTimeNanos() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Start counting the number and aggregate size of memory allocations.</para> <para>The start method resets the counts and enables counting. The stop method disables the counting so that the analysis code doesn't cause additional allocations. The various  <code>get</code> methods return the specified value. And the various  <code>reset</code> methods reset the specified count.</para> <para>Counts are kept for the system as a whole (global) and for each thread. The per-thread counts for threads other than the current thread are not cleared by the "reset" or "start" calls.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Accurate counting is a burden on the runtime and may be removed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startAllocCounting
				/// </java-name>
				[Dot42.DexImport("startAllocCounting", "()V", AccessFlags = 9)]
				public static void StartAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop counting the number and aggregate size of memory allocations.</para> <para> <para>startAllocCounting() </para></para>        
				/// </summary>
				/// <java-name>
				/// stopAllocCounting
				/// </java-name>
				[Dot42.DexImport("stopAllocCounting", "()V", AccessFlags = 9)]
				public static void StopAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the global count of objects allocated.  <para>getGlobalAllocCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the global size of objects allocated.  <para>getGlobalAllocSize() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the global count of objects freed.  <para>getGlobalFreedCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalFreedCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalFreedCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalFreedCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the global size of objects freed.  <para>getGlobalFreedSize() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalFreedSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalFreedSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalFreedSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the count of classes initialized.  <para>getGlobalClassInitCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalClassInitCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalClassInitCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalClassInitCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the count of time spent initializing classes.  <para>getGlobalClassInitTime() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalClassInitTime
				/// </java-name>
				[Dot42.DexImport("resetGlobalClassInitTime", "()V", AccessFlags = 9)]
				public static void ResetGlobalClassInitTime() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalExternalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalExternalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalExternalFreedCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalFreedCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalFreedCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalExternalFreedSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalFreedSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalFreedSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the count of non-concurrent GC invocations.  <para>getGlobalGcInvocationCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetGlobalGcInvocationCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalGcInvocationCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalGcInvocationCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the thread-local count of objects allocated.  <para>getThreadAllocCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetThreadAllocCount
				/// </java-name>
				[Dot42.DexImport("resetThreadAllocCount", "()V", AccessFlags = 9)]
				public static void ResetThreadAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the thread-local count of objects allocated.  <para>getThreadAllocSize() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetThreadAllocSize
				/// </java-name>
				[Dot42.DexImport("resetThreadAllocSize", "()V", AccessFlags = 9)]
				public static void ResetThreadAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetThreadExternalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetThreadExternalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetThreadExternalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resetThreadExternalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetThreadExternalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetThreadExternalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the thread-local count of non-concurrent GC invocations.  <para>getThreadGcInvocationCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetThreadGcInvocationCount
				/// </java-name>
				[Dot42.DexImport("resetThreadGcInvocationCount", "()V", AccessFlags = 9)]
				public static void ResetThreadGcInvocationCount() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears all the global and thread-local memory allocation counters.  <para>startAllocCounting() </para></para>        
				/// </summary>
				/// <java-name>
				/// resetAllCounts
				/// </java-name>
				[Dot42.DexImport("resetAllCounts", "()V", AccessFlags = 9)]
				public static void ResetAllCounts() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves information about this processes memory usages. This information is broken down by how much is in use by dalivk, the native heap, and everything else. </para>        
				/// </summary>
				/// <java-name>
				/// getMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V", AccessFlags = 265)]
				public static void GetMemoryInfo(global::Android.OS.Debug.MemoryInfo memoryInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Establish an object allocation limit in the current thread. This feature was never enabled in release builds. The allocation limits feature was removed in Honeycomb. This method exists for compatibility and always returns -1 and has no effect.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setAllocationLimit", "(I)I", AccessFlags = 9)]
				public static int SetAllocationLimit(int limit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Establish a global object allocation limit. This feature was never enabled in release builds. The allocation limits feature was removed in Honeycomb. This method exists for compatibility and always returns -1 and has no effect.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setGlobalAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setGlobalAllocationLimit", "(I)I", AccessFlags = 9)]
				public static int SetGlobalAllocationLimit(int limit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Dump a list of all currently loaded class to the log file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// printLoadedClasses
				/// </java-name>
				[Dot42.DexImport("printLoadedClasses", "(I)V", AccessFlags = 9)]
				public static void PrintLoadedClasses(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dump "hprof" data to the specified file. This may cause a GC.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpHprofData
				/// </java-name>
				[Dot42.DexImport("dumpHprofData", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DumpHprofData(string fileName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a debugging dump of a system service by name.</para> <para>Most services require the caller to hold android.permission.DUMP.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the service was dumped successfully, false if the service could not be found or had an error while dumping </para>
				/// </returns>
				/// <java-name>
				/// dumpService
				/// </java-name>
				[Dot42.DexImport("dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool DumpService(string name, global::Java.IO.FileDescriptor fd, string[] args) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Determine if a debugger is currently attached. </para>        
				/// </summary>
				/// <java-name>
				/// isDebuggerConnected
				/// </java-name>
				public static bool IsDebuggerConnected
				{
						[Dot42.DexImport("isDebuggerConnected", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the global count of objects allocated by the runtime between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalAllocCount
				/// </java-name>
				public static int GlobalAllocCount
				{
						[Dot42.DexImport("getGlobalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the global size, in bytes, of objects allocated by the runtime between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalAllocSize
				/// </java-name>
				public static int GlobalAllocSize
				{
						[Dot42.DexImport("getGlobalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the global count of objects freed by the runtime between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalFreedCount
				/// </java-name>
				public static int GlobalFreedCount
				{
						[Dot42.DexImport("getGlobalFreedCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the global size, in bytes, of objects freed by the runtime between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalFreedSize
				/// </java-name>
				public static int GlobalFreedSize
				{
						[Dot42.DexImport("getGlobalFreedSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of classes successfully initialized (ie those that executed without throwing an exception) between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalClassInitCount
				/// </java-name>
				public static int GlobalClassInitCount
				{
						[Dot42.DexImport("getGlobalClassInitCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the time spent successfully initializing classes between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalClassInitTime
				/// </java-name>
				public static int GlobalClassInitTime
				{
						[Dot42.DexImport("getGlobalClassInitTime", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and always returns 0.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getGlobalExternalAllocCount
				/// </java-name>
				public static int GlobalExternalAllocCount
				{
						[Dot42.DexImport("getGlobalExternalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and always returns 0.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getGlobalExternalAllocSize
				/// </java-name>
				public static int GlobalExternalAllocSize
				{
						[Dot42.DexImport("getGlobalExternalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and always returns 0.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getGlobalExternalFreedCount
				/// </java-name>
				public static int GlobalExternalFreedCount
				{
						[Dot42.DexImport("getGlobalExternalFreedCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getGlobalExternalFreedSize
				/// </java-name>
				public static int GlobalExternalFreedSize
				{
						[Dot42.DexImport("getGlobalExternalFreedSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of non-concurrent GC invocations between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalGcInvocationCount
				/// </java-name>
				public static int GlobalGcInvocationCount
				{
						[Dot42.DexImport("getGlobalGcInvocationCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the thread-local count of objects allocated by the runtime between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getThreadAllocCount
				/// </java-name>
				public static int ThreadAllocCount
				{
						[Dot42.DexImport("getThreadAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the thread-local size of objects allocated by the runtime between a start and stop. </para>        
				/// </summary>
				/// <returns>
				///  <para>The allocated size in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getThreadAllocSize
				/// </java-name>
				public static int ThreadAllocSize
				{
						[Dot42.DexImport("getThreadAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getThreadExternalAllocCount
				/// </java-name>
				public static int ThreadExternalAllocCount
				{
						[Dot42.DexImport("getThreadExternalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>This method exists for compatibility and has no effect.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getThreadExternalAllocSize
				/// </java-name>
				public static int ThreadExternalAllocSize
				{
						[Dot42.DexImport("getThreadExternalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of thread-local non-concurrent GC invocations between a start and stop. </para>        
				/// </summary>
				/// <java-name>
				/// getThreadGcInvocationCount
				/// </java-name>
				public static int ThreadGcInvocationCount
				{
						[Dot42.DexImport("getThreadGcInvocationCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the size of the native heap. </para>        
				/// </summary>
				/// <returns>
				///  <para>The size of the native heap in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getNativeHeapSize
				/// </java-name>
				public static long NativeHeapSize
				{
						[Dot42.DexImport("getNativeHeapSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the amount of allocated memory in the native heap. </para>        
				/// </summary>
				/// <returns>
				///  <para>The allocated size in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getNativeHeapAllocatedSize
				/// </java-name>
				public static long NativeHeapAllocatedSize
				{
						[Dot42.DexImport("getNativeHeapAllocatedSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the amount of free memory in the native heap. </para>        
				/// </summary>
				/// <returns>
				///  <para>The freed size in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getNativeHeapFreeSize
				/// </java-name>
				public static long NativeHeapFreeSize
				{
						[Dot42.DexImport("getNativeHeapFreeSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Retrieves the PSS memory used by the process as given by the smaps. </para>        
				/// </summary>
				/// <java-name>
				/// getPss
				/// </java-name>
				public static long Pss
				{
						[Dot42.DexImport("getPss", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Get the number of loaded classes. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of loaded classes. </para>
				/// </returns>
				/// <java-name>
				/// getLoadedClassCount
				/// </java-name>
				public static int LoadedClassCount
				{
						[Dot42.DexImport("getLoadedClassCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of sent transactions from this process. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of sent transactions or -1 if it could not read t. </para>
				/// </returns>
				/// <java-name>
				/// getBinderSentTransactions
				/// </java-name>
				public static int BinderSentTransactions
				{
						[Dot42.DexImport("getBinderSentTransactions", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of received transactions from the binder driver. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of received transactions or -1 if it could not read the stats. </para>
				/// </returns>
				/// <java-name>
				/// getBinderReceivedTransactions
				/// </java-name>
				public static int BinderReceivedTransactions
				{
						[Dot42.DexImport("getBinderReceivedTransactions", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of active local Binder objects that exist in the current process. </para>        
				/// </summary>
				/// <java-name>
				/// getBinderLocalObjectCount
				/// </java-name>
				public static int BinderLocalObjectCount
				{
						[Dot42.DexImport("getBinderLocalObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of references to remote proxy Binder objects that exist in the current process. </para>        
				/// </summary>
				/// <java-name>
				/// getBinderProxyObjectCount
				/// </java-name>
				public static int BinderProxyObjectCount
				{
						[Dot42.DexImport("getBinderProxyObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of death notification links to Binder objects that exist in the current process. </para>        
				/// </summary>
				/// <java-name>
				/// getBinderDeathObjectCount
				/// </java-name>
				public static int BinderDeathObjectCount
				{
						[Dot42.DexImport("getBinderDeathObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>API for gathering and querying instruction counts.</para> <para>Example usage:  <pre>
				///   Debug.InstructionCount icount = new Debug.InstructionCount();
				///   icount.resetAndStart();
				///    [... do lots of stuff ...]
				///   if (icount.collect()) {
				///       System.out.println("Total instructions executed: "
				///           + icount.globalTotal());
				///       System.out.println("Method invocations: "
				///           + icount.globalMethodInvocations());
				///   }
				/// </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/os/Debug$InstructionCount
				/// </java-name>
				[Dot42.DexImport("android/os/Debug$InstructionCount", AccessFlags = 9)]
				public partial class InstructionCount
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public InstructionCount() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Reset counters and ensure counts are running. Counts may have already been running.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if counting was started </para>
						/// </returns>
						/// <java-name>
						/// resetAndStart
						/// </java-name>
						[Dot42.DexImport("resetAndStart", "()Z", AccessFlags = 1)]
						public virtual bool ResetAndStart() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Collect instruction counts. May or may not stop the counting process. </para>        
						/// </summary>
						/// <java-name>
						/// collect
						/// </java-name>
						[Dot42.DexImport("collect", "()Z", AccessFlags = 1)]
						public virtual bool Collect() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Return the total number of instructions executed globally (i.e. in all threads). </para>        
						/// </summary>
						/// <java-name>
						/// globalTotal
						/// </java-name>
						[Dot42.DexImport("globalTotal", "()I", AccessFlags = 1)]
						public virtual int GlobalTotal() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Return the total number of method-invocation instructions executed globally. </para>        
						/// </summary>
						/// <java-name>
						/// globalMethodInvocations
						/// </java-name>
						[Dot42.DexImport("globalMethodInvocations", "()I", AccessFlags = 1)]
						public virtual int GlobalMethodInvocations() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

				}

				/// <summary>
				///  <para>This class is used to retrieved various statistics about the memory mappings for this process. The returns info broken down by dalvik, native, and other. All results are in kB. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/Debug$MemoryInfo
				/// </java-name>
				[Dot42.DexImport("android/os/Debug$MemoryInfo", AccessFlags = 9)]
				public partial class MemoryInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The proportional set size for dalvik heap. (Doesn't include other Dalvik overhead.) </para>        
						/// </summary>
						/// <java-name>
						/// dalvikPss
						/// </java-name>
						[Dot42.DexImport("dalvikPss", "I", AccessFlags = 1)]
						public int DalvikPss;
						/// <summary>
						///  <para>The private dirty pages used by dalvik heap. </para>        
						/// </summary>
						/// <java-name>
						/// dalvikPrivateDirty
						/// </java-name>
						[Dot42.DexImport("dalvikPrivateDirty", "I", AccessFlags = 1)]
						public int DalvikPrivateDirty;
						/// <summary>
						///  <para>The shared dirty pages used by dalvik heap. </para>        
						/// </summary>
						/// <java-name>
						/// dalvikSharedDirty
						/// </java-name>
						[Dot42.DexImport("dalvikSharedDirty", "I", AccessFlags = 1)]
						public int DalvikSharedDirty;
						/// <summary>
						///  <para>The proportional set size for the native heap. </para>        
						/// </summary>
						/// <java-name>
						/// nativePss
						/// </java-name>
						[Dot42.DexImport("nativePss", "I", AccessFlags = 1)]
						public int NativePss;
						/// <summary>
						///  <para>The private dirty pages used by the native heap. </para>        
						/// </summary>
						/// <java-name>
						/// nativePrivateDirty
						/// </java-name>
						[Dot42.DexImport("nativePrivateDirty", "I", AccessFlags = 1)]
						public int NativePrivateDirty;
						/// <summary>
						///  <para>The shared dirty pages used by the native heap. </para>        
						/// </summary>
						/// <java-name>
						/// nativeSharedDirty
						/// </java-name>
						[Dot42.DexImport("nativeSharedDirty", "I", AccessFlags = 1)]
						public int NativeSharedDirty;
						/// <summary>
						///  <para>The proportional set size for everything else. </para>        
						/// </summary>
						/// <java-name>
						/// otherPss
						/// </java-name>
						[Dot42.DexImport("otherPss", "I", AccessFlags = 1)]
						public int OtherPss;
						/// <summary>
						///  <para>The private dirty pages used by everything else. </para>        
						/// </summary>
						/// <java-name>
						/// otherPrivateDirty
						/// </java-name>
						[Dot42.DexImport("otherPrivateDirty", "I", AccessFlags = 1)]
						public int OtherPrivateDirty;
						/// <summary>
						///  <para>The shared dirty pages used by everything else. </para>        
						/// </summary>
						/// <java-name>
						/// otherSharedDirty
						/// </java-name>
						[Dot42.DexImport("otherSharedDirty", "I", AccessFlags = 1)]
						public int OtherSharedDirty;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<MemoryInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public MemoryInfo() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getOtherPss
						/// </java-name>
						[Dot42.DexImport("getOtherPss", "(I)I", AccessFlags = 1)]
						public virtual int GetOtherPss(int which) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherPrivateDirty
						/// </java-name>
						[Dot42.DexImport("getOtherPrivateDirty", "(I)I", AccessFlags = 1)]
						public virtual int GetOtherPrivateDirty(int which) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherSharedDirty
						/// </java-name>
						[Dot42.DexImport("getOtherSharedDirty", "(I)I", AccessFlags = 1)]
						public virtual int GetOtherSharedDirty(int which) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherLabel
						/// </java-name>
						[Dot42.DexImport("getOtherLabel", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string GetOtherLabel(int which) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
						/// </returns>
						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Flatten this object in to a Parcel.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Return total PSS memory usage in kB. </para>        
						/// </summary>
						/// <java-name>
						/// getTotalPss
						/// </java-name>
						public virtual int TotalPss
						{
								[Dot42.DexImport("getTotalPss", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Return total private dirty memory usage in kB. </para>        
						/// </summary>
						/// <java-name>
						/// getTotalPrivateDirty
						/// </java-name>
						public virtual int TotalPrivateDirty
						{
								[Dot42.DexImport("getTotalPrivateDirty", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Return total shared dirty memory usage in kB. </para>        
						/// </summary>
						/// <java-name>
						/// getTotalSharedDirty
						/// </java-name>
						public virtual int TotalSharedDirty
						{
								[Dot42.DexImport("getTotalSharedDirty", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

		}

		/// <summary>
		///  <para>Enqueues chunks of data (from various sources  application crashes, kernel log records, etc.). The queue is size bounded and will drop old data if the enqueued data exceeds the maximum size. You can think of this as a persistent, system-wide, blob-oriented "logcat".</para> <para>You can obtain an instance of this class by calling android.content.Context#getSystemService with android.content.Context#DROPBOX_SERVICE.</para> <para>DropBoxManager entries are not sent anywhere directly, but other system services and debugging tools may scan and upload entries for processing. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/DropBoxManager
		/// </java-name>
		[Dot42.DexImport("android/os/DropBoxManager", AccessFlags = 33)]
		public partial class DropBoxManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag value: Entry's content was deleted to save space. </para>        
				/// </summary>
				/// <java-name>
				/// IS_EMPTY
				/// </java-name>
				[Dot42.DexImport("IS_EMPTY", "I", AccessFlags = 25)]
				public const int IS_EMPTY = 1;
				/// <summary>
				///  <para>Flag value: Content is human-readable UTF-8 text (can be combined with IS_GZIPPED). </para>        
				/// </summary>
				/// <java-name>
				/// IS_TEXT
				/// </java-name>
				[Dot42.DexImport("IS_TEXT", "I", AccessFlags = 25)]
				public const int IS_TEXT = 2;
				/// <summary>
				///  <para>Flag value: Content can be decompressed with java.util.zip.GZIPOutputStream. </para>        
				/// </summary>
				/// <java-name>
				/// IS_GZIPPED
				/// </java-name>
				[Dot42.DexImport("IS_GZIPPED", "I", AccessFlags = 25)]
				public const int IS_GZIPPED = 4;
				/// <summary>
				///  <para>Broadcast Action: This is broadcast when a new entry is added in the dropbox. You must hold the android.Manifest.permission#READ_LOGS permission in order to receive this broadcast.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DROPBOX_ENTRY_ADDED
				/// </java-name>
				[Dot42.DexImport("ACTION_DROPBOX_ENTRY_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DROPBOX_ENTRY_ADDED = "android.intent.action.DROPBOX_ENTRY_ADDED";
				/// <summary>
				///  <para>Extra for android.os.DropBoxManager#ACTION_DROPBOX_ENTRY_ADDED: string containing the dropbox tag. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TAG
				/// </java-name>
				[Dot42.DexImport("EXTRA_TAG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TAG = "tag";
				/// <summary>
				///  <para>Extra for android.os.DropBoxManager#ACTION_DROPBOX_ENTRY_ADDED: long integer value containing time (in milliseconds since January 1, 1970 00:00:00 UTC) when the entry was created. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TIME
				/// </java-name>
				[Dot42.DexImport("EXTRA_TIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TIME = "time";
				/// <summary>
				///  <para>Create a dummy instance for testing. All methods will fail unless overridden with an appropriate mock implementation. To obtain a functional instance, use android.content.Context#getSystemService. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DropBoxManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stores human-readable text. The data may be discarded eventually (or even immediately) if space is limited, or ignored entirely if the tag has been blocked (see isTagEnabled).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addText
				/// </java-name>
				[Dot42.DexImport("addText", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddText(string tag, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stores binary data, which may be ignored or discarded as with addText.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addData
				/// </java-name>
				[Dot42.DexImport("addData", "(Ljava/lang/String;[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddData(string tag, sbyte[] data, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stores binary data, which may be ignored or discarded as with addText.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addData
				/// </java-name>
				[Dot42.DexImport("addData", "(Ljava/lang/String;[BI)V", AccessFlags = 1)]
				public virtual void AddData(string tag, byte[] data, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stores the contents of a file, which may be ignored or discarded as with addText.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFile
				/// </java-name>
				[Dot42.DexImport("addFile", "(Ljava/lang/String;Ljava/io/File;I)V", AccessFlags = 1)]
				public virtual void AddFile(string tag, global::Java.IO.File file, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks any blacklists (set in system settings) to see whether a certain tag is allowed. Entries with disabled tags will be dropped immediately, so you can save the work of actually constructing and sending the data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether events with that tag would be accepted </para>
				/// </returns>
				/// <java-name>
				/// isTagEnabled
				/// </java-name>
				[Dot42.DexImport("isTagEnabled", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsTagEnabled(string tag) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the next entry from the drop box  <b>after</b> the specified time. Requires  <code>android.permission.READ_LOGS</code>. You must always call Entry#close() on the return value!</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next entry, or null if there are no more entries </para>
				/// </returns>
				/// <java-name>
				/// getNextEntry
				/// </java-name>
				[Dot42.DexImport("getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;", AccessFlags = 1)]
				public virtual global::Android.OS.DropBoxManager.Entry GetNextEntry(string tag, long msec) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.DropBoxManager.Entry);
				}

				/// <summary>
				///  <para>A single entry retrieved from the drop box. This may include a reference to a stream, so you must call close() when you are done using it. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/DropBoxManager$Entry
				/// </java-name>
				[Dot42.DexImport("android/os/DropBoxManager$Entry", AccessFlags = 9)]
				public partial class Entry : global::Android.OS.IParcelable, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<Entry> CREATOR;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;J)V", AccessFlags = 1)]
						public Entry(string @string, long int64) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;JLjava/lang/String;)V", AccessFlags = 1)]
						public Entry(string @string, long int64, string string1) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;J[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
						public Entry(string @string, long int64, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;J[BI)V", AccessFlags = 1)]
						public Entry(string @string, long int64, byte[] @byte, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V", AccessFlags = 1)]
						public Entry(string @string, long int64, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;JLjava/io/File;I)V", AccessFlags = 1)]
						public Entry(string @string, long int64, global::Java.IO.File file, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Close the input stream associated with this entry. </para>        
						/// </summary>
						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public virtual void Close() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the uncompressed text contents of the entry, null if the entry is not text. </para>
						/// </returns>
						/// <java-name>
						/// getText
						/// </java-name>
						[Dot42.DexImport("getText", "(I)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetText(int maxBytes) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
						/// </returns>
						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Flatten this object in to a Parcel.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal Entry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the tag originally attached to the entry. </para>
						/// </returns>
						/// <java-name>
						/// getTag
						/// </java-name>
						public virtual string Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>time when the entry was originally created. </para>
						/// </returns>
						/// <java-name>
						/// getTimeMillis
						/// </java-name>
						public virtual long TimeMillis
						{
								[Dot42.DexImport("getTimeMillis", "()J", AccessFlags = 1)]
								get{ return default(long); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>flags describing the content returned by getInputStream(). </para>
						/// </returns>
						/// <java-name>
						/// getFlags
						/// </java-name>
						public virtual int Flags
						{
								[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the uncompressed contents of the entry, or null if the contents were lost </para>
						/// </returns>
						/// <java-name>
						/// getInputStream
						/// </java-name>
						public virtual global::Java.IO.InputStream InputStream
						{
								[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
								get{ return default(global::Java.IO.InputStream); }
						}

				}

		}

		/// <summary>
		///  <para>Provides access to environment variables. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Environment
		/// </java-name>
		[Dot42.DexImport("android/os/Environment", AccessFlags = 33)]
		public partial class Environment
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Standard directory in which to place any audio files that should be in the regular list of music for the user. This may be combined with DIRECTORY_PODCASTS, DIRECTORY_NOTIFICATIONS, DIRECTORY_ALARMS, and DIRECTORY_RINGTONES as a series of directories to categories a particular audio file as more than one type. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_MUSIC
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_MUSIC", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_MUSIC;
				/// <summary>
				///  <para>Standard directory in which to place any audio files that should be in the list of podcasts that the user can select (not as regular music). This may be combined with DIRECTORY_MUSIC, DIRECTORY_NOTIFICATIONS, DIRECTORY_ALARMS, and DIRECTORY_RINGTONES as a series of directories to categories a particular audio file as more than one type. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_PODCASTS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PODCASTS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_PODCASTS;
				/// <summary>
				///  <para>Standard directory in which to place any audio files that should be in the list of ringtones that the user can select (not as regular music). This may be combined with DIRECTORY_MUSIC, DIRECTORY_PODCASTS, DIRECTORY_NOTIFICATIONS, and DIRECTORY_ALARMS as a series of directories to categories a particular audio file as more than one type. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_RINGTONES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_RINGTONES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_RINGTONES;
				/// <summary>
				///  <para>Standard directory in which to place any audio files that should be in the list of alarms that the user can select (not as regular music). This may be combined with DIRECTORY_MUSIC, DIRECTORY_PODCASTS, DIRECTORY_NOTIFICATIONS, and DIRECTORY_RINGTONES as a series of directories to categories a particular audio file as more than one type. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_ALARMS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_ALARMS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_ALARMS;
				/// <summary>
				///  <para>Standard directory in which to place any audio files that should be in the list of notifications that the user can select (not as regular music). This may be combined with DIRECTORY_MUSIC, DIRECTORY_PODCASTS, DIRECTORY_ALARMS, and DIRECTORY_RINGTONES as a series of directories to categories a particular audio file as more than one type. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_NOTIFICATIONS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_NOTIFICATIONS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_NOTIFICATIONS;
				/// <summary>
				///  <para>Standard directory in which to place pictures that are available to the user. Note that this is primarily a convention for the top-level public directory, as the media scanner will find and collect pictures in any directory. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_PICTURES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PICTURES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_PICTURES;
				/// <summary>
				///  <para>Standard directory in which to place movies that are available to the user. Note that this is primarily a convention for the top-level public directory, as the media scanner will find and collect movies in any directory. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_MOVIES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_MOVIES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_MOVIES;
				/// <summary>
				///  <para>Standard directory in which to place files that have been downloaded by the user. Note that this is primarily a convention for the top-level public directory, you are free to download files anywhere in your own private directories. Also note that though the constant here is named DIRECTORY_DOWNLOADS (plural), the actual file name is non-plural for backwards compatibility reasons. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_DOWNLOADS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_DOWNLOADS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_DOWNLOADS;
				/// <summary>
				///  <para>The traditional location for pictures and videos when mounting the device as a camera. Note that this is primarily a convention for the top-level public directory, as this convention makes no sense elsewhere. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTORY_DCIM
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_DCIM", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_DCIM;
				/// <summary>
				///  <para>Storage state if the media is not present.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_REMOVED
				/// </java-name>
				[Dot42.DexImport("MEDIA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_REMOVED = "removed";
				/// <summary>
				///  <para>Storage state if the media is present but not mounted.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("MEDIA_UNMOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_UNMOUNTED = "unmounted";
				/// <summary>
				///  <para>Storage state if the media is present and being disk-checked.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_CHECKING
				/// </java-name>
				[Dot42.DexImport("MEDIA_CHECKING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_CHECKING = "checking";
				/// <summary>
				///  <para>Storage state if the media is present but is blank or is using an unsupported filesystem.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_NOFS
				/// </java-name>
				[Dot42.DexImport("MEDIA_NOFS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_NOFS = "nofs";
				/// <summary>
				///  <para>Storage state if the media is present and mounted at its mount point with read/write access.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_MOUNTED
				/// </java-name>
				[Dot42.DexImport("MEDIA_MOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_MOUNTED = "mounted";
				/// <summary>
				///  <para>Storage state if the media is present and mounted at its mount point with read-only access.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_MOUNTED_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("MEDIA_MOUNTED_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_MOUNTED_READ_ONLY = "mounted_ro";
				/// <summary>
				///  <para>Storage state if the media is present not mounted, and shared via USB mass storage.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_SHARED
				/// </java-name>
				[Dot42.DexImport("MEDIA_SHARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_SHARED = "shared";
				/// <summary>
				///  <para>Storage state if the media was removed before it was unmounted.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_BAD_REMOVAL
				/// </java-name>
				[Dot42.DexImport("MEDIA_BAD_REMOVAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_BAD_REMOVAL = "bad_removal";
				/// <summary>
				///  <para>Storage state if the media is present but cannot be mounted. Typically this happens if the file system on the media is corrupted.</para> <para> <para>getStorageState(File) </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_UNMOUNTABLE
				/// </java-name>
				[Dot42.DexImport("MEDIA_UNMOUNTABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_UNMOUNTABLE = "unmountable";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Environment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a top-level public external storage directory for placing files of a particular type. This is where the user will typically place and manage their own files, so you should be careful about what you put here to ensure you don't erase their files or get in the way of their own organization.</para> <para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para> <para>Here is an example of typical code to manipulate a picture on the public external storage:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java public_picture}</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the File path for the directory. Note that this directory may not yet exist, so you must make sure it exists before using it such as with File.mkdirs(). </para>
				/// </returns>
				/// <java-name>
				/// getExternalStoragePublicDirectory
				/// </java-name>
				[Dot42.DexImport("getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.IO.File GetExternalStoragePublicDirectory(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <summary>
				///  <para>Gets the Android root directory. </para>        
				/// </summary>
				/// <java-name>
				/// getRootDirectory
				/// </java-name>
				public static global::Java.IO.File RootDirectory
				{
						[Dot42.DexImport("getRootDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Return the user data directory. </para>        
				/// </summary>
				/// <java-name>
				/// getDataDirectory
				/// </java-name>
				public static global::Java.IO.File DataDirectory
				{
						[Dot42.DexImport("getDataDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Return the primary external storage directory. This directory may not currently be accessible if it has been mounted by the user on their computer, has been removed from the device, or some other problem has happened. You can determine its current state with getExternalStorageState(). </para> <para> <b>Note: don't be confused by the word "external" here. This directory can better be thought as media/shared storage. It is a filesystem that can hold a relatively large amount of data and that is shared across all applications (does not enforce permissions). Traditionally this is an SD card, but it may also be implemented as built-in storage in a device that is distinct from the protected internal storage and can be mounted as a filesystem on a computer.</b> </para> <para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as. </para> <para>In devices with multiple "external" storage directories, this directory represents the "primary" external storage that the user will interact with. Access to secondary storage is available through </para> <para>Applications should not directly use this top-level directory, in order to avoid polluting the user's root namespace. Any files that are private to the application should be placed in a directory returned by Context.getExternalFilesDir, which the system will take care of deleting if the application is uninstalled. Other shared files should be placed in one of the directories returned by getExternalStoragePublicDirectory. </para> <para>Writing to this path requires the android.Manifest.permission#WRITE_EXTERNAL_STORAGE permission, and starting in read access requires the android.Manifest.permission#READ_EXTERNAL_STORAGE permission, which is automatically granted if you hold the write permission. </para> <para>Starting in android.os.Build.VERSION_CODES#KITKAT, if your application only needs to store internal data, consider using Context#getExternalFilesDir(String) or Context#getExternalCacheDir(), which require no permissions to read or write. </para> <para>This path may change between platform versions, so applications should only persist relative paths. </para> <para>Here is an example of typical code to monitor the state of external storage: </para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java monitor_storage}</para> <para> <para>getExternalStorageState() </para> <para>isExternalStorageRemovable() </para></para>        
				/// </summary>
				/// <java-name>
				/// getExternalStorageDirectory
				/// </java-name>
				public static global::Java.IO.File ExternalStorageDirectory
				{
						[Dot42.DexImport("getExternalStorageDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Return the download/cache content directory. </para>        
				/// </summary>
				/// <java-name>
				/// getDownloadCacheDirectory
				/// </java-name>
				public static global::Java.IO.File DownloadCacheDirectory
				{
						[Dot42.DexImport("getDownloadCacheDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Returns the current state of the primary "external" storage device.</para> <para> <para>getExternalStorageDirectory() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>one of MEDIA_UNKNOWN, MEDIA_REMOVED, MEDIA_UNMOUNTED, MEDIA_CHECKING, MEDIA_NOFS, MEDIA_MOUNTED, MEDIA_MOUNTED_READ_ONLY, MEDIA_SHARED, MEDIA_BAD_REMOVAL, or MEDIA_UNMOUNTABLE. </para>
				/// </returns>
				/// <java-name>
				/// getExternalStorageState
				/// </java-name>
				public static string ExternalStorageState
				{
						[Dot42.DexImport("getExternalStorageState", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns whether the primary "external" storage device is removable. If true is returned, this device is for example an SD card that the user can remove. If false is returned, the storage is built into the device and can not be physically removed.</para> <para>See getExternalStorageDirectory() for more information. </para>        
				/// </summary>
				/// <java-name>
				/// isExternalStorageRemovable
				/// </java-name>
				public static bool IsExternalStorageRemovable
				{
						[Dot42.DexImport("isExternalStorageRemovable", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the device has an external storage device which is emulated. If true, the device does not have real external storage, and the directory returned by getExternalStorageDirectory() will be allocated using a portion of the internal storage system.</para> <para>Certain system services, such as the package manager, use this to determine where to install an application.</para> <para>Emulated external storage may also be encrypted - see android.content.ComponentName, boolean) for additional details. </para>        
				/// </summary>
				/// <java-name>
				/// isExternalStorageEmulated
				/// </java-name>
				public static bool IsExternalStorageEmulated
				{
						[Dot42.DexImport("isExternalStorageEmulated", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Monitors files (using ) to fire an event after files are accessed or changed by by any process on the device (including this one). FileObserver is an abstract class; subclasses must implement the event handler onEvent(int, String).</para> <para>Each FileObserver instance monitors a single file or directory. If a directory is monitored, events will be triggered for all files and subdirectories inside the monitored directory.</para> <para>An event mask is used to specify which changes or actions to report. Event type constants are used to describe the possible changes in the event mask as well as what actually happened in event callbacks.</para> <para> <b>Warning</b>: If a FileObserver is garbage collected, it will stop sending events. To ensure you keep receiving events, you must keep a reference to the FileObserver instance from some other live object.</para>    
		/// </summary>
		/// <java-name>
		/// android/os/FileObserver
		/// </java-name>
		[Dot42.DexImport("android/os/FileObserver", AccessFlags = 1057)]
		public abstract partial class FileObserver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Event type: Data was read from a file </para>        
				/// </summary>
				/// <java-name>
				/// ACCESS
				/// </java-name>
				[Dot42.DexImport("ACCESS", "I", AccessFlags = 25)]
				public const int ACCESS = 1;
				/// <summary>
				///  <para>Event type: Data was written to a file </para>        
				/// </summary>
				/// <java-name>
				/// MODIFY
				/// </java-name>
				[Dot42.DexImport("MODIFY", "I", AccessFlags = 25)]
				public const int MODIFY = 2;
				/// <summary>
				///  <para>Event type: Metadata (permissions, owner, timestamp) was changed explicitly </para>        
				/// </summary>
				/// <java-name>
				/// ATTRIB
				/// </java-name>
				[Dot42.DexImport("ATTRIB", "I", AccessFlags = 25)]
				public const int ATTRIB = 4;
				/// <summary>
				///  <para>Event type: Someone had a file or directory open for writing, and closed it </para>        
				/// </summary>
				/// <java-name>
				/// CLOSE_WRITE
				/// </java-name>
				[Dot42.DexImport("CLOSE_WRITE", "I", AccessFlags = 25)]
				public const int CLOSE_WRITE = 8;
				/// <summary>
				///  <para>Event type: Someone had a file or directory open read-only, and closed it </para>        
				/// </summary>
				/// <java-name>
				/// CLOSE_NOWRITE
				/// </java-name>
				[Dot42.DexImport("CLOSE_NOWRITE", "I", AccessFlags = 25)]
				public const int CLOSE_NOWRITE = 16;
				/// <summary>
				///  <para>Event type: A file or directory was opened </para>        
				/// </summary>
				/// <java-name>
				/// OPEN
				/// </java-name>
				[Dot42.DexImport("OPEN", "I", AccessFlags = 25)]
				public const int OPEN = 32;
				/// <summary>
				///  <para>Event type: A file or subdirectory was moved from the monitored directory </para>        
				/// </summary>
				/// <java-name>
				/// MOVED_FROM
				/// </java-name>
				[Dot42.DexImport("MOVED_FROM", "I", AccessFlags = 25)]
				public const int MOVED_FROM = 64;
				/// <summary>
				///  <para>Event type: A file or subdirectory was moved to the monitored directory </para>        
				/// </summary>
				/// <java-name>
				/// MOVED_TO
				/// </java-name>
				[Dot42.DexImport("MOVED_TO", "I", AccessFlags = 25)]
				public const int MOVED_TO = 128;
				/// <summary>
				///  <para>Event type: A new file or subdirectory was created under the monitored directory </para>        
				/// </summary>
				/// <java-name>
				/// CREATE
				/// </java-name>
				[Dot42.DexImport("CREATE", "I", AccessFlags = 25)]
				public const int CREATE = 256;
				/// <summary>
				///  <para>Event type: A file was deleted from the monitored directory </para>        
				/// </summary>
				/// <java-name>
				/// DELETE
				/// </java-name>
				[Dot42.DexImport("DELETE", "I", AccessFlags = 25)]
				public const int DELETE = 512;
				/// <summary>
				///  <para>Event type: The monitored file or directory was deleted; monitoring effectively stops </para>        
				/// </summary>
				/// <java-name>
				/// DELETE_SELF
				/// </java-name>
				[Dot42.DexImport("DELETE_SELF", "I", AccessFlags = 25)]
				public const int DELETE_SELF = 1024;
				/// <summary>
				///  <para>Event type: The monitored file or directory was moved; monitoring continues </para>        
				/// </summary>
				/// <java-name>
				/// MOVE_SELF
				/// </java-name>
				[Dot42.DexImport("MOVE_SELF", "I", AccessFlags = 25)]
				public const int MOVE_SELF = 2048;
				/// <summary>
				///  <para>Event mask: All valid event types, combined </para>        
				/// </summary>
				/// <java-name>
				/// ALL_EVENTS
				/// </java-name>
				[Dot42.DexImport("ALL_EVENTS", "I", AccessFlags = 25)]
				public const int ALL_EVENTS = 4095;
				/// <summary>
				///  <para>Equivalent to FileObserver(path, FileObserver.ALL_EVENTS). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileObserver(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new file observer for a certain file or directory. Monitoring does not start on creation! You must call startWatching() before you will receive events.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public FileObserver(string path, int mask) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileObserver() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Start watching for events. The monitored file or directory must exist at this time, or else no events will be reported (even if it appears later). If monitoring is already started, this call has no effect. </para>        
				/// </summary>
				/// <java-name>
				/// startWatching
				/// </java-name>
				[Dot42.DexImport("startWatching", "()V", AccessFlags = 1)]
				public virtual void StartWatching() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop watching for events. Some events may be in process, so events may continue to be reported even after this method completes. If monitoring is already stopped, this call has no effect. </para>        
				/// </summary>
				/// <java-name>
				/// stopWatching
				/// </java-name>
				[Dot42.DexImport("stopWatching", "()V", AccessFlags = 1)]
				public virtual void StopWatching() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The event handler, which must be implemented by subclasses.</para> <para>This method is invoked on a special FileObserver thread. It runs independently of any threads, so take care to use appropriate synchronization! Consider using Handler#post(Runnable) to shift event handling work to the main thread to avoid concurrency problems.</para> <para>Event handlers must not throw exceptions.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onEvent
				/// </java-name>
				[Dot42.DexImport("onEvent", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnEvent(int @event, string path) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal FileObserver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A Handler allows you to send and process Message and Runnable objects associated with a thread's MessageQueue. Each Handler instance is associated with a single thread and that thread's message queue. When you create a new Handler, it is bound to the thread / message queue of the thread that is creating it  from that point on, it will deliver messages and runnables to that message queue and execute them as they come out of the message queue.</para> <para>There are two main uses for a Handler: (1) to schedule messages and runnables to be executed as some point in the future; and (2) to enqueue an action to be performed on a different thread than your own.</para> <para>Scheduling messages is accomplished with the post, postAtTime(Runnable, long), postDelayed, sendEmptyMessage, sendMessage, sendMessageAtTime, and sendMessageDelayed methods. The  <b>post</b> versions allow you to enqueue Runnable objects to be called by the message queue when they are received; the  <b>sendMessage</b> versions allow you to enqueue a Message object containing a bundle of data that will be processed by the Handler's handleMessage method (requiring that you implement a subclass of Handler).</para> <para>When posting or sending to a Handler, you can either allow the item to be processed as soon as the message queue is ready to do so, or specify a delay before it gets processed or absolute time for it to be processed. The latter two allow you to implement timeouts, ticks, and other timing-based behavior.</para> <para>When a process is created for your application, its main thread is dedicated to running a message queue that takes care of managing the top-level application objects (activities, broadcast receivers, etc) and any windows they create. You can create your own threads, and communicate back with the main application thread through a Handler. This is done by calling the same  <b>post</b> or  <b>sendMessage</b> methods as before, but from your new thread. The given Runnable or Message will then be scheduled in the Handler's message queue and processed when appropriate. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Handler
		/// </java-name>
		[Dot42.DexImport("android/os/Handler", AccessFlags = 33)]
		public partial class Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor associates this handler with the Looper for the current thread.</para> <para>If this thread does not have a looper, this handler won't be able to receive messages so an exception is thrown. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Handler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor associates this handler with the Looper for the current thread and takes a callback interface in which you can handle messages.</para> <para>If this thread does not have a looper, this handler won't be able to receive messages so an exception is thrown.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Handler$Callback;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Handler.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor associates this handler with the Looper for the current thread and takes a callback interface in which you can handle messages.</para> <para>If this thread does not have a looper, this handler won't be able to receive messages so an exception is thrown.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Looper;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Looper callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use the provided Looper instead of the default one and take a callback interface in which to handle messages.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Looper looper, global::Android.OS.Handler.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must implement this to receive messages. </para>        
				/// </summary>
				/// <java-name>
				/// handleMessage
				/// </java-name>
				[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void HandleMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Handle system messages here. </para>        
				/// </summary>
				/// <java-name>
				/// dispatchMessage
				/// </java-name>
				[Dot42.DexImport("dispatchMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void DispatchMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string representing the name of the specified message. The default implementation will either return the class name of the message callback if any, or the hexadecimal representation of the message "what" field.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getMessageName
				/// </java-name>
				[Dot42.DexImport("getMessageName", "(Landroid/os/Message;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMessageName(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a new Message from the global message pool. More efficient than creating and allocating new instances. The retrieved message has its handler set to this instance (Message.target == this). If you don't want that facility, just call Message.obtain() instead. </para>        
				/// </summary>
				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "()Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtainMessage(), except that it also sets the what member of the returned Message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Message from the global message pool. </para>
				/// </returns>
				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(I)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int what) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtainMessage(), except that it also sets the what and obj members of the returned Message.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Message from the global message pool. </para>
				/// </returns>
				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int what, object obj) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtainMessage(), except that it also sets the what, arg1 and arg2 members of the returned Message. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message from the global message pool. </para>
				/// </returns>
				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(III)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int what, int arg1, int arg2) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtainMessage(), except that it also sets the what, obj, arg1,and arg2 values on the returned Message. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message from the global message pool. </para>
				/// </returns>
				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int what, int arg1, int arg2, object obj) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Causes the Runnable r to be added to the message queue. The runnable will be run on the thread to which this handler is attached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// post
				/// </java-name>
				[Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 17)]
				public bool Post(global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Causes the Runnable r to be added to the message queue, to be run at a specific time given by  <b>uptimeMillis</b>.  <b>The time-base is android.os.SystemClock#uptimeMillis.</b> The runnable will be run on the thread to which this handler is attached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Runnable will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
				/// </returns>
				/// <java-name>
				/// postAtTime
				/// </java-name>
				[Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17)]
				public bool PostAtTime(global::Java.Lang.IRunnable r, long uptimeMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Causes the Runnable r to be added to the message queue, to be run at a specific time given by  <b>uptimeMillis</b>.  <b>The time-base is android.os.SystemClock#uptimeMillis.</b> The runnable will be run on the thread to which this handler is attached.</para> <para> <para>android.os.SystemClock::uptimeMillis </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Runnable will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped.</para>
				/// </returns>
				/// <java-name>
				/// postAtTime
				/// </java-name>
				[Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z", AccessFlags = 17)]
				public bool PostAtTime(global::Java.Lang.IRunnable r, object token, long uptimeMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Causes the Runnable r to be added to the message queue, to be run after the specified amount of time elapses. The runnable will be run on the thread to which this handler is attached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Runnable will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
				/// </returns>
				/// <java-name>
				/// postDelayed
				/// </java-name>
				[Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17)]
				public bool PostDelayed(global::Java.Lang.IRunnable r, long delayMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Posts a message to an object that implements Runnable. Causes the Runnable r to executed on the next iteration through the message queue. The runnable will be run on the thread to which this handler is attached.  <b>This method is only for use in very special circumstances  it can easily starve the message queue, cause ordering problems, or have other unexpected side-effects.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// postAtFrontOfQueue
				/// </java-name>
				[Dot42.DexImport("postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", AccessFlags = 17)]
				public bool PostAtFrontOfQueue(global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Remove any pending posts of Runnable r that are in the message queue. </para>        
				/// </summary>
				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)V", AccessFlags = 17)]
				public void RemoveCallbacks(global::Java.Lang.IRunnable r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove any pending posts of Runnable  <b>r</b> with Object  <b>token</b> that are in the message queue. If  <b>token</b> is null, all callbacks will be removed. </para>        
				/// </summary>
				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveCallbacks(global::Java.Lang.IRunnable r, object token) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes a message onto the end of the message queue after all pending messages before the current time. It will be received in handleMessage, in the thread attached to this handler.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// sendMessage
				/// </java-name>
				[Dot42.DexImport("sendMessage", "(Landroid/os/Message;)Z", AccessFlags = 17)]
				public bool SendMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sends a Message containing only the what value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// sendEmptyMessage
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessage", "(I)Z", AccessFlags = 17)]
				public bool SendEmptyMessage(int what) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sends a Message containing only the what value, to be delivered after the specified amount of time elapses.  <para>sendMessageDelayed(android.os.Message, long)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// sendEmptyMessageDelayed
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessageDelayed", "(IJ)Z", AccessFlags = 17)]
				public bool SendEmptyMessageDelayed(int what, long delayMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sends a Message containing only the what value, to be delivered at a specific time.  <para>sendMessageAtTime(android.os.Message, long)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// sendEmptyMessageAtTime
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessageAtTime", "(IJ)Z", AccessFlags = 17)]
				public bool SendEmptyMessageAtTime(int what, long uptimeMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Enqueue a message into the message queue after all pending messages before (current time + delayMillis). You will receive it in handleMessage, in the thread attached to this handler.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the message will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
				/// </returns>
				/// <java-name>
				/// sendMessageDelayed
				/// </java-name>
				[Dot42.DexImport("sendMessageDelayed", "(Landroid/os/Message;J)Z", AccessFlags = 17)]
				public bool SendMessageDelayed(global::Android.OS.Message msg, long delayMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Enqueue a message into the message queue after all pending messages before the absolute time (in milliseconds)  <b>uptimeMillis</b>.  <b>The time-base is android.os.SystemClock#uptimeMillis.</b> You will receive it in handleMessage, in the thread attached to this handler.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the message will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped. </para>
				/// </returns>
				/// <java-name>
				/// sendMessageAtTime
				/// </java-name>
				[Dot42.DexImport("sendMessageAtTime", "(Landroid/os/Message;J)Z", AccessFlags = 1)]
				public virtual bool SendMessageAtTime(global::Android.OS.Message msg, long uptimeMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Enqueue a message at the front of the message queue, to be processed on the next iteration of the message loop. You will receive it in handleMessage, in the thread attached to this handler.  <b>This method is only for use in very special circumstances  it can easily starve the message queue, cause ordering problems, or have other unexpected side-effects.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the message was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. </para>
				/// </returns>
				/// <java-name>
				/// sendMessageAtFrontOfQueue
				/// </java-name>
				[Dot42.DexImport("sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z", AccessFlags = 17)]
				public bool SendMessageAtFrontOfQueue(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Remove any pending posts of messages with code 'what' that are in the message queue. </para>        
				/// </summary>
				/// <java-name>
				/// removeMessages
				/// </java-name>
				[Dot42.DexImport("removeMessages", "(I)V", AccessFlags = 17)]
				public void RemoveMessages(int what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove any pending posts of messages with code 'what' and whose obj is 'object' that are in the message queue. If  <b>object</b> is null, all messages will be removed. </para>        
				/// </summary>
				/// <java-name>
				/// removeMessages
				/// </java-name>
				[Dot42.DexImport("removeMessages", "(ILjava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveMessages(int what, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove any pending posts of callbacks and sent messages whose  <b>obj</b> is  <b>token</b>. If  <b>token</b> is null, all callbacks and messages will be removed. </para>        
				/// </summary>
				/// <java-name>
				/// removeCallbacksAndMessages
				/// </java-name>
				[Dot42.DexImport("removeCallbacksAndMessages", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveCallbacksAndMessages(object token) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Check if there are any pending posts of messages with code 'what' in the message queue. </para>        
				/// </summary>
				/// <java-name>
				/// hasMessages
				/// </java-name>
				[Dot42.DexImport("hasMessages", "(I)Z", AccessFlags = 17)]
				public bool HasMessages(int what) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Check if there are any pending posts of messages with code 'what' and whose obj is 'object' in the message queue. </para>        
				/// </summary>
				/// <java-name>
				/// hasMessages
				/// </java-name>
				[Dot42.DexImport("hasMessages", "(ILjava/lang/Object;)Z", AccessFlags = 17)]
				public bool HasMessages(int what, object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 17)]
				public void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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
				/// getLooper
				/// </java-name>
				public global::Android.OS.Looper Looper
				{
						[Dot42.DexImport("getLooper", "()Landroid/os/Looper;", AccessFlags = 17)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <summary>
				///  <para>Callback interface you can use when instantiating a Handler to avoid having to implement your own subclass of Handler.</para> <para></para>    
				/// </summary>
				/// <returns>
				///  <para>True if no further handling is desired </para>
				/// </returns>
				/// <java-name>
				/// android/os/Handler$Callback
				/// </java-name>
				[Dot42.DexImport("android/os/Handler$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// handleMessage
						/// </java-name>
						[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)Z", AccessFlags = 1025)]
						bool HandleMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Handy class for starting a new thread that has a looper. The looper can then be used to create handler classes. Note that start() must still be called. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/HandlerThread
		/// </java-name>
		[Dot42.DexImport("android/os/HandlerThread", AccessFlags = 33)]
		public partial class HandlerThread : global::System.Threading.Thread
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HandlerThread(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a HandlerThread. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HandlerThread(string name, int priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call back method that can be explicitly overridden if needed to execute some setup before Looper loops. </para>        
				/// </summary>
				/// <java-name>
				/// onLooperPrepared
				/// </java-name>
				[Dot42.DexImport("onLooperPrepared", "()V", AccessFlags = 4)]
				protected internal virtual void OnLooperPrepared() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public override void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Quits the handler thread's looper. </para> <para>Causes the handler thread's looper to terminate without processing any more messages in the message queue. </para> <para>Any attempt to post messages to the queue after the looper is asked to quit will fail. For example, the Handler#sendMessage(Message) method will return false. </para> <para>Using this method may be unsafe because some messages may not be delivered before the looper terminates. Consider using quitSafely instead to ensure that all pending work is completed in an orderly manner. </para> <para> <para>quitSafely </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the looper looper has been asked to quit or false if the thread had not yet started running.</para>
				/// </returns>
				/// <java-name>
				/// quit
				/// </java-name>
				[Dot42.DexImport("quit", "()Z", AccessFlags = 1)]
				public virtual bool Quit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HandlerThread() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>This method returns the Looper associated with this thread. If this thread not been started or for any reason is isAlive() returns false, this method will return null. If this thread has been started, this method will block until the looper has been initialized. </para>        
				/// </summary>
				/// <returns>
				///  <para>The looper. </para>
				/// </returns>
				/// <java-name>
				/// getLooper
				/// </java-name>
				public virtual global::Android.OS.Looper Looper
				{
						[Dot42.DexImport("getLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <summary>
				///  <para>Returns the identifier of this thread. See Process.myTid(). </para>        
				/// </summary>
				/// <java-name>
				/// getThreadId
				/// </java-name>
				public virtual int ThreadId
				{
						[Dot42.DexImport("getThreadId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Base interface for a remotable object, the core part of a lightweight remote procedure call mechanism designed for high performance when performing in-process and cross-process calls. This interface describes the abstract protocol for interacting with a remotable object. Do not implement this interface directly, instead extend from Binder.</para> <para>The key IBinder API is transact() matched by Binder.onTransact(). These methods allow you to send a call to an IBinder object and receive a call coming in to a Binder object, respectively. This transaction API is synchronous, such that a call to transact() does not return until the target has returned from Binder.onTransact(); this is the expected behavior when calling an object that exists in the local process, and the underlying inter-process communication (IPC) mechanism ensures that these same semantics apply when going across processes.</para> <para>The data sent through transact() is a Parcel, a generic buffer of data that also maintains some meta-data about its contents. The meta data is used to manage IBinder object references in the buffer, so that those references can be maintained as the buffer moves across processes. This mechanism ensures that when an IBinder is written into a Parcel and sent to another process, if that other process sends a reference to that same IBinder back to the original process, then the original process will receive the same IBinder object back. These semantics allow IBinder/Binder objects to be used as a unique identity (to serve as a token or for other purposes) that can be managed across processes.</para> <para>The system maintains a pool of transaction threads in each process that it runs in. These threads are used to dispatch all IPCs coming in from other processes. For example, when an IPC is made from process A to process B, the calling thread in A blocks in transact() as it sends the transaction to process B. The next available pool thread in B receives the incoming transaction, calls Binder.onTransact() on the target object, and replies with the result Parcel. Upon receiving its result, the thread in process A returns to allow its execution to continue. In effect, other processes appear to use as additional threads that you did not create executing in your own process.</para> <para>The Binder system also supports recursion across processes. For example if process A performs a transaction to process B, and process B while handling that transaction calls transact() on an IBinder that is implemented in A, then the thread in A that is currently waiting for the original transaction to finish will take care of calling Binder.onTransact() on the object being called by B. This ensures that the recursion semantics when calling remote binder object are the same as when calling local objects.</para> <para>When working with remote objects, you often want to find out when they are no longer valid. There are three ways this can be determined:  <ul> <li> <para>The transact() method will throw a RemoteException exception if you try to call it on an IBinder whose process no longer exists. </para></li> <li> <para>The pingBinder() method can be called, and will return false if the remote process no longer exists. </para></li> <li> <para>The linkToDeath() method can be used to register a DeathRecipient with the IBinder, which will be called when its containing process goes away. </para></li></ul></para> <para> <para>Binder </para></para>    
		/// </summary>
		/// <java-name>
		/// android/os/IBinder
		/// </java-name>
		[Dot42.DexImport("android/os/IBinder", AccessFlags = 1537)]
		public partial interface IBinder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Check to see if the object still exists.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns false if the hosting process is gone, otherwise the result (always by default true) returned by the pingBinder() implementation on the other side. </para>
				/// </returns>
				/// <java-name>
				/// pingBinder
				/// </java-name>
				[Dot42.DexImport("pingBinder", "()Z", AccessFlags = 1025)]
				bool PingBinder() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Attempt to retrieve a local implementation of an interface for this Binder object. If null is returned, you will need to instantiate a proxy class to marshall calls through the transact() method. </para>        
				/// </summary>
				/// <java-name>
				/// queryLocalInterface
				/// </java-name>
				[Dot42.DexImport("queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", AccessFlags = 1025)]
				global::Android.OS.IInterface QueryLocalInterface(string descriptor) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Print the object's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void Dump(global::Java.IO.FileDescriptor fd, string[] args) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like dump(FileDescriptor, String[]) but always executes asynchronously. If the object is local, a new thread is created to perform the dump.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpAsync
				/// </java-name>
				[Dot42.DexImport("dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void DumpAsync(global::Java.IO.FileDescriptor fd, string[] args) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Perform a generic operation with the object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// transact
				/// </java-name>
				[Dot42.DexImport("transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 1025)]
				bool Transact(int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register the recipient for a notification if this binder goes away. If this binder object unexpectedly goes away (typically because its hosting process has been killed), then the given DeathRecipient's DeathRecipient.binderDied() method will be called.</para> <para>You will only receive death notifications for remote binders, as local binders by definition can't die without you dying as well.</para> <para> <para>unlinkToDeath </para></para>        
				/// </summary>
				/// <java-name>
				/// linkToDeath
				/// </java-name>
				[Dot42.DexImport("linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", AccessFlags = 1025)]
				void LinkToDeath(global::Android.OS.IBinder_IDeathRecipient recipient, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a previously registered death notification. The recipient will no longer be called if this object dies.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the  <b>recipient</b> is successfully unlinked, assuring you that its DeathRecipient.binderDied() method will not be called; <c>false </c> if the target IBinder has already died, meaning the method has been (or soon will be) called.</para>
				/// </returns>
				/// <java-name>
				/// unlinkToDeath
				/// </java-name>
				[Dot42.DexImport("unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", AccessFlags = 1025)]
				bool UnlinkToDeath(global::Android.OS.IBinder_IDeathRecipient recipient, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the canonical name of the interface supported by this binder. </para>        
				/// </summary>
				/// <java-name>
				/// getInterfaceDescriptor
				/// </java-name>
				string InterfaceDescriptor
				{
						[Dot42.DexImport("getInterfaceDescriptor", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Check to see if the process that the binder is in is still alive.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>false if the process is not alive. Note that if it returns true, the process may have died while the call is returning. </para>
				/// </returns>
				/// <java-name>
				/// isBinderAlive
				/// </java-name>
				bool IsBinderAlive
				{
						[Dot42.DexImport("isBinderAlive", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Interface for receiving a callback when the process hosting an IBinder has gone away.</para> <para> <para>linkToDeath </para></para>    
		/// </summary>
		/// <java-name>
		/// android/os/IBinder$DeathRecipient
		/// </java-name>
		[Dot42.DexImport("android/os/IBinder$DeathRecipient", AccessFlags = 1545)]
		public partial interface IBinder_IDeathRecipient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// binderDied
				/// </java-name>
				[Dot42.DexImport("binderDied", "()V", AccessFlags = 1025)]
				void BinderDied() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Base interface for a remotable object, the core part of a lightweight remote procedure call mechanism designed for high performance when performing in-process and cross-process calls. This interface describes the abstract protocol for interacting with a remotable object. Do not implement this interface directly, instead extend from Binder.</para> <para>The key IBinder API is transact() matched by Binder.onTransact(). These methods allow you to send a call to an IBinder object and receive a call coming in to a Binder object, respectively. This transaction API is synchronous, such that a call to transact() does not return until the target has returned from Binder.onTransact(); this is the expected behavior when calling an object that exists in the local process, and the underlying inter-process communication (IPC) mechanism ensures that these same semantics apply when going across processes.</para> <para>The data sent through transact() is a Parcel, a generic buffer of data that also maintains some meta-data about its contents. The meta data is used to manage IBinder object references in the buffer, so that those references can be maintained as the buffer moves across processes. This mechanism ensures that when an IBinder is written into a Parcel and sent to another process, if that other process sends a reference to that same IBinder back to the original process, then the original process will receive the same IBinder object back. These semantics allow IBinder/Binder objects to be used as a unique identity (to serve as a token or for other purposes) that can be managed across processes.</para> <para>The system maintains a pool of transaction threads in each process that it runs in. These threads are used to dispatch all IPCs coming in from other processes. For example, when an IPC is made from process A to process B, the calling thread in A blocks in transact() as it sends the transaction to process B. The next available pool thread in B receives the incoming transaction, calls Binder.onTransact() on the target object, and replies with the result Parcel. Upon receiving its result, the thread in process A returns to allow its execution to continue. In effect, other processes appear to use as additional threads that you did not create executing in your own process.</para> <para>The Binder system also supports recursion across processes. For example if process A performs a transaction to process B, and process B while handling that transaction calls transact() on an IBinder that is implemented in A, then the thread in A that is currently waiting for the original transaction to finish will take care of calling Binder.onTransact() on the object being called by B. This ensures that the recursion semantics when calling remote binder object are the same as when calling local objects.</para> <para>When working with remote objects, you often want to find out when they are no longer valid. There are three ways this can be determined:  <ul> <li> <para>The transact() method will throw a RemoteException exception if you try to call it on an IBinder whose process no longer exists. </para></li> <li> <para>The pingBinder() method can be called, and will return false if the remote process no longer exists. </para></li> <li> <para>The linkToDeath() method can be used to register a DeathRecipient with the IBinder, which will be called when its containing process goes away. </para></li></ul></para> <para> <para>Binder </para></para>    
		/// </summary>
		/// <java-name>
		/// android/os/IBinder
		/// </java-name>
		[Dot42.DexImport("android/os/IBinder", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBinderConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The first transaction code available for user commands. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST_CALL_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("FIRST_CALL_TRANSACTION", "I", AccessFlags = 25)]
				public const int FIRST_CALL_TRANSACTION = 1;
				/// <summary>
				///  <para>The last transaction code available for user commands. </para>        
				/// </summary>
				/// <java-name>
				/// LAST_CALL_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("LAST_CALL_TRANSACTION", "I", AccessFlags = 25)]
				public const int LAST_CALL_TRANSACTION = 16777215;
				/// <summary>
				///  <para>IBinder protocol transaction code: pingBinder(). </para>        
				/// </summary>
				/// <java-name>
				/// PING_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("PING_TRANSACTION", "I", AccessFlags = 25)]
				public const int PING_TRANSACTION = 1599098439;
				/// <summary>
				///  <para>IBinder protocol transaction code: dump internal state. </para>        
				/// </summary>
				/// <java-name>
				/// DUMP_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("DUMP_TRANSACTION", "I", AccessFlags = 25)]
				public const int DUMP_TRANSACTION = 1598311760;
				/// <summary>
				///  <para>IBinder protocol transaction code: interrogate the recipient side of the transaction for its canonical interface descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// INTERFACE_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("INTERFACE_TRANSACTION", "I", AccessFlags = 25)]
				public const int INTERFACE_TRANSACTION = 1598968902;
				/// <summary>
				///  <para>IBinder protocol transaction code: send a tweet to the target object. The data in the parcel is intended to be delivered to a shared messaging service associated with the object; it can be anything, as long as it is not more than 130 UTF-8 characters to conservatively fit within common messaging services. As part of Build.VERSION_CODES#HONEYCOMB_MR2, all Binder objects are expected to support this protocol for fully integrated tweeting across the platform. To support older code, the default implementation logs the tweet to the main log as a simple emulation of broadcasting it publicly over the Internet.</para> <para>Also, upon completing the dispatch, the object must make a cup of tea, return it to the caller, and exclaim "jolly good messageold boy!". </para>        
				/// </summary>
				/// <java-name>
				/// TWEET_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("TWEET_TRANSACTION", "I", AccessFlags = 25)]
				public const int TWEET_TRANSACTION = 1599362900;
				/// <summary>
				///  <para>IBinder protocol transaction code: tell an app asynchronously that the caller likes it. The app is responsible for incrementing and maintaining its own like counter, and may display this value to the user to indicate the quality of the app. This is an optional command that applications do not need to handle, so the default implementation is to do nothing.</para> <para>There is no response returned and nothing about the system will be functionally affected by it, but it will improve the app's self-esteem. </para>        
				/// </summary>
				/// <java-name>
				/// LIKE_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("LIKE_TRANSACTION", "I", AccessFlags = 25)]
				public const int LIKE_TRANSACTION = 1598835019;
				/// <summary>
				///  <para>Flag to transact: this is a one-way call, meaning that the caller returns immediately, without waiting for a result from the callee. Applies only if the caller and callee are in different processes. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ONEWAY
				/// </java-name>
				[Dot42.DexImport("FLAG_ONEWAY", "I", AccessFlags = 25)]
				public const int FLAG_ONEWAY = 1;
		}

		/// <summary>
		///  <para>Base class for Binder interfaces. When defining a new interface, you must derive it from IInterface. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/IInterface
		/// </java-name>
		[Dot42.DexImport("android/os/IInterface", AccessFlags = 1537)]
		public partial interface IInterface
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Retrieve the Binder object associated with this interface. You must use this instead of a plain cast, so that proxy objects can return the correct result. </para>        
				/// </summary>
				/// <java-name>
				/// asBinder
				/// </java-name>
				[Dot42.DexImport("asBinder", "()Landroid/os/IBinder;", AccessFlags = 1025)]
				global::Android.OS.IBinder AsBinder() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface for classes whose instances can be written to and restored from a Parcel. Classes implementing the Parcelable interface must also have a static field called  <code>CREATOR</code>, which is an object implementing the Parcelable.Creator interface.</para> <para>A typical implementation of Parcelable is:</para> <para> <pre>
		/// public class MyParcelable implements Parcelable {
		///     private int mData;</pre></para> <para> <pre>    public int describeContents() {
		///         return 0;
		///     }</pre></para> <para> <pre>    public void writeToParcel(Parcel out, int flags) {
		///         out.writeInt(mData);
		///     }</pre></para> <para> <pre>    public static final Parcelable.Creator&lt;MyParcelable&gt; CREATOR
		///             = new Parcelable.Creator&lt;MyParcelable&gt;() {
		///         public MyParcelable createFromParcel(Parcel in) {
		///             return new MyParcelable(in);
		///         }</pre></para> <para> <pre>        public MyParcelable[] newArray(int size) {
		///             return new MyParcelable[size];
		///         }
		///     };</pre></para> <para> <pre>    private MyParcelable(Parcel in) {
		///         mData = in.readInt();
		///     }
		/// }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Parcelable
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable", AccessFlags = 1537)]
		public partial interface IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1025)]
				int DescribeContents() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Specialization of Creator that allows you to receive the ClassLoader the object is being created in. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Parcelable$ClassLoaderCreator
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable$ClassLoaderCreator", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;Landroid/os/Parcelable$Creator<TT;>;")]
		public partial interface IParcelable_IClassLoaderCreator<T> : global::Android.OS.IParcelable_ICreator<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new instance of the Parcelable class, instantiating it from the given Parcel whose data had previously been written by Parcelable.writeToParcel() and using the given ClassLoader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new instance of the Parcelable class. </para>
				/// </returns>
				/// <java-name>
				/// createFromParcel
				/// </java-name>
				[Dot42.DexImport("createFromParcel", "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)TT;")]
				T CreateFromParcel(global::Android.OS.Parcel source, global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface that must be implemented and provided as a public CREATOR field that generates instances of your Parcelable class from a Parcel. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Parcelable$Creator
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable$Creator", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IParcelable_ICreator<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new instance of the Parcelable class, instantiating it from the given Parcel whose data had previously been written by Parcelable.writeToParcel().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new instance of the Parcelable class. </para>
				/// </returns>
				/// <java-name>
				/// createFromParcel
				/// </java-name>
				[Dot42.DexImport("createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Landroid/os/Parcel;)TT;")]
				T CreateFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new array of the Parcelable class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of the Parcelable class, with every entry initialized to null. </para>
				/// </returns>
				/// <java-name>
				/// newArray
				/// </java-name>
				[Dot42.DexImport("newArray", "(I)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)[TT;")]
				T[] NewArray(int size) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface for classes whose instances can be written to and restored from a Parcel. Classes implementing the Parcelable interface must also have a static field called  <code>CREATOR</code>, which is an object implementing the Parcelable.Creator interface.</para> <para>A typical implementation of Parcelable is:</para> <para> <pre>
		/// public class MyParcelable implements Parcelable {
		///     private int mData;</pre></para> <para> <pre>    public int describeContents() {
		///         return 0;
		///     }</pre></para> <para> <pre>    public void writeToParcel(Parcel out, int flags) {
		///         out.writeInt(mData);
		///     }</pre></para> <para> <pre>    public static final Parcelable.Creator&lt;MyParcelable&gt; CREATOR
		///             = new Parcelable.Creator&lt;MyParcelable&gt;() {
		///         public MyParcelable createFromParcel(Parcel in) {
		///             return new MyParcelable(in);
		///         }</pre></para> <para> <pre>        public MyParcelable[] newArray(int size) {
		///             return new MyParcelable[size];
		///         }
		///     };</pre></para> <para> <pre>    private MyParcelable(Parcel in) {
		///         mData = in.readInt();
		///     }
		/// }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Parcelable
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IParcelableConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag for use with writeToParcel: the object being written is a return value, that is the result of a function such as "&lt;code&gt;Parcelable someFunction()&lt;/code&gt;", "&lt;code&gt;void someFunction(out Parcelable)&lt;/code&gt;", or "&lt;code&gt;void someFunction(inout Parcelable)&lt;/code&gt;". Some implementations may want to release resources at this point. </para>        
				/// </summary>
				/// <java-name>
				/// PARCELABLE_WRITE_RETURN_VALUE
				/// </java-name>
				[Dot42.DexImport("PARCELABLE_WRITE_RETURN_VALUE", "I", AccessFlags = 25)]
				public const int PARCELABLE_WRITE_RETURN_VALUE = 1;
				/// <summary>
				///  <para>Bit masks for use with describeContents: each bit represents a kind of object considered to have potential special significance when marshalled. </para>        
				/// </summary>
				/// <java-name>
				/// CONTENTS_FILE_DESCRIPTOR
				/// </java-name>
				[Dot42.DexImport("CONTENTS_FILE_DESCRIPTOR", "I", AccessFlags = 25)]
				public const int CONTENTS_FILE_DESCRIPTOR = 1;
		}

		/// <summary>
		///  <para>Class used to run a message loop for a thread. Threads by default do not have a message loop associated with them; to create one, call prepare in the thread that is to run the loop, and then loop to have it process messages until the loop is stopped.</para> <para>Most interaction with a message loop is through the Handler class.</para> <para>This is a typical example of the implementation of a Looper thread, using the separation of prepare and loop to create an initial Handler to communicate with the Looper.</para> <para> <pre>
		///  class LooperThread extends Thread {
		///      public Handler mHandler;</pre></para> <para> <pre>     public void run() {
		///          Looper.prepare();</pre></para> <para> <pre>         mHandler = new Handler() {
		///              public void handleMessage(Message msg) {
		///                  // process incoming messages here
		///              }
		///          };</pre></para> <para> <pre>         Looper.loop();
		///      }
		///  }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Looper
		/// </java-name>
		[Dot42.DexImport("android/os/Looper", AccessFlags = 33)]
		public partial class Looper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Looper() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the current thread as a looper. This gives you a chance to create handlers that then reference this looper, before actually starting the loop. Be sure to call loop() after calling this method, and end it by calling quit(). </para>        
				/// </summary>
				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 9)]
				public static void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the current thread as a looper, marking it as an application's main looper. The main looper for your application is created by the Android environment, so you should never need to call this function yourself. See also: prepare() </para>        
				/// </summary>
				/// <java-name>
				/// prepareMainLooper
				/// </java-name>
				[Dot42.DexImport("prepareMainLooper", "()V", AccessFlags = 9)]
				public static void PrepareMainLooper() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Run the message queue in this thread. Be sure to call quit() to end the loop. </para>        
				/// </summary>
				/// <java-name>
				/// loop
				/// </java-name>
				[Dot42.DexImport("loop", "()V", AccessFlags = 9)]
				public static void Loop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the Looper object associated with the current thread. Returns null if the calling thread is not associated with a Looper. </para>        
				/// </summary>
				/// <java-name>
				/// myLooper
				/// </java-name>
				[Dot42.DexImport("myLooper", "()Landroid/os/Looper;", AccessFlags = 9)]
				public static global::Android.OS.Looper MyLooper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Looper);
				}

				/// <summary>
				///  <para>Control logging of messages as they are processed by this Looper. If enabled, a log message will be written to  <b>printer</b> at the beginning and ending of each message dispatch, identifying the target Handler and message contents.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMessageLogging
				/// </java-name>
				[Dot42.DexImport("setMessageLogging", "(Landroid/util/Printer;)V", AccessFlags = 1)]
				public virtual void SetMessageLogging(global::Android.Util.IPrinter printer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the MessageQueue object associated with the current thread. This must be called from a thread running a Looper, or a NullPointerException will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// myQueue
				/// </java-name>
				[Dot42.DexImport("myQueue", "()Landroid/os/MessageQueue;", AccessFlags = 9)]
				public static global::Android.OS.MessageQueue MyQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.MessageQueue);
				}

				/// <summary>
				///  <para>Quits the looper. </para> <para>Causes the loop method to terminate without processing any more messages in the message queue. </para> <para>Any attempt to post messages to the queue after the looper is asked to quit will fail. For example, the Handler#sendMessage(Message) method will return false. </para> <para>Using this method may be unsafe because some messages may not be delivered before the looper terminates. Consider using quitSafely instead to ensure that all pending work is completed in an orderly manner. </para> <para> <para>quitSafely </para></para>        
				/// </summary>
				/// <java-name>
				/// quit
				/// </java-name>
				[Dot42.DexImport("quit", "()V", AccessFlags = 1)]
				public virtual void Quit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the application's main looper, which lives in the main thread of the application. </para>        
				/// </summary>
				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public static global::Android.OS.Looper MainLooper
				{
						[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 9)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <summary>
				///  <para>Return the Thread associated with this Looper. </para>        
				/// </summary>
				/// <java-name>
				/// getThread
				/// </java-name>
				public virtual global::System.Threading.Thread Thread
				{
						[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 1)]
						get{ return default(global::System.Threading.Thread); }
				}

		}

		/// <summary>
		///  <para>MemoryFile is a wrapper for the Linux ashmem driver. MemoryFiles are backed by shared memory, which can be optionally set to be purgeable. Purgeable files may have their contents reclaimed by the kernel in low memory conditions (only if allowPurging is set to true). After a file is purged, attempts to read or write the file will cause an IOException to be thrown. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/MemoryFile
		/// </java-name>
		[Dot42.DexImport("android/os/MemoryFile", AccessFlags = 33)]
		public partial class MemoryFile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Allocates a new ashmem region. The region is initially not purgable.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public MemoryFile(string name, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the memory file. If there are no other open references to the memory file, it will be deleted. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MemoryFile() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the length of the memory file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>file length. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Enables or disables purging of the memory file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>previous value of allowPurging </para>
				/// </returns>
				/// <java-name>
				/// allowPurging
				/// </java-name>
				[Dot42.DexImport("allowPurging", "(Z)Z", AccessFlags = 33)]
				public virtual bool AllowPurging(bool allowPurging) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads bytes from the memory file. Will throw an IOException if the file has been purged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of bytes read. </para>
				/// </returns>
				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "([BIII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ReadBytes(sbyte[] buffer, int srcOffset, int destOffset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads bytes from the memory file. Will throw an IOException if the file has been purged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of bytes read. </para>
				/// </returns>
				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "([BIII)I", AccessFlags = 1)]
				public virtual int ReadBytes(byte[] buffer, int srcOffset, int destOffset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Write bytes to the memory file. Will throw an IOException if the file has been purged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void WriteBytes(sbyte[] buffer, int srcOffset, int destOffset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write bytes to the memory file. Will throw an IOException if the file has been purged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([BIII)V", AccessFlags = 1)]
				public virtual void WriteBytes(byte[] buffer, int srcOffset, int destOffset, int count) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal MemoryFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Is memory file purging enabled?</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the file may be purged. </para>
				/// </returns>
				/// <java-name>
				/// isPurgingAllowed
				/// </java-name>
				public virtual bool IsPurgingAllowed
				{
						[Dot42.DexImport("isPurgingAllowed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Creates a new InputStream for reading from the memory file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>InputStream </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.IO.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <summary>
				///  <para>Creates a new OutputStream for writing to the memory file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>OutputStream </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.IO.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.OutputStream); }
				}

		}

		/// <summary>
		///  <para>Defines a message containing a description and arbitrary data object that can be sent to a Handler. This object contains two extra int fields and an extra object field that allow you to not do allocations in many cases.</para> <para>While the constructor of Message is public, the best way to get one of these is to call Message.obtain() or one of the Handler.obtainMessage() methods, which will pull them from a pool of recycled objects.</para>    
		/// </summary>
		/// <java-name>
		/// android/os/Message
		/// </java-name>
		[Dot42.DexImport("android/os/Message", AccessFlags = 49)]
		public sealed partial class Message : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>User-defined message code so that the recipient can identify what this message is about. Each Handler has its own name-space for message codes, so you do not need to worry about yours conflicting with other handlers. </para>        
				/// </summary>
				/// <java-name>
				/// what
				/// </java-name>
				[Dot42.DexImport("what", "I", AccessFlags = 1)]
				public int What;
				/// <summary>
				///  <para>arg1 and arg2 are lower-cost alternatives to using setData() if you only need to store a few integer values. </para>        
				/// </summary>
				/// <java-name>
				/// arg1
				/// </java-name>
				[Dot42.DexImport("arg1", "I", AccessFlags = 1)]
				public int Arg1;
				/// <summary>
				///  <para>arg1 and arg2 are lower-cost alternatives to using setData() if you only need to store a few integer values. </para>        
				/// </summary>
				/// <java-name>
				/// arg2
				/// </java-name>
				[Dot42.DexImport("arg2", "I", AccessFlags = 1)]
				public int Arg2;
				/// <summary>
				///  <para>An arbitrary object to send to the recipient. When using Messenger to send the message across processes this can only be non-null if it contains a Parcelable of a framework class (not one implemented by the application). For other data transfer use setData.</para> <para>Note that Parcelable objects here are not supported prior to the android.os.Build.VERSION_CODES#FROYO release. </para>        
				/// </summary>
				/// <java-name>
				/// obj
				/// </java-name>
				[Dot42.DexImport("obj", "Ljava/lang/Object;", AccessFlags = 1)]
				public object Obj;
				/// <summary>
				///  <para>Optional Messenger where replies to this message can be sent. The semantics of exactly how this is used are up to the sender and receiver. </para>        
				/// </summary>
				/// <java-name>
				/// replyTo
				/// </java-name>
				[Dot42.DexImport("replyTo", "Landroid/os/Messenger;", AccessFlags = 1)]
				public global::Android.OS.Messenger ReplyTo;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.Message> CREATOR;
				/// <summary>
				///  <para>Constructor (but the preferred way to get a Message is to call Message.obtain()). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Message() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a new Message instance from the global pool. Allows us to avoid allocating new objects in many cases. </para>        
				/// </summary>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but copies the values of an existing message (including its target) into the new one. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Message;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Message orig) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but copies the values of an existing message (including its target) into the new one. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler orig) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but sets the values for both  <b>target</b> and  <b>what</b> members on the Message. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler h, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but sets the values for both  <b>target</b> and  <b>what</b> members on the Message. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;I)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler h, int what) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but sets the values of the  <b>target</b>,  <b>what</b>, and  <b>obj</b> members. </para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler h, int what, object obj) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but sets the values of the  <b>target</b>,  <b>what</b>,  <b>arg1</b>, and  <b>arg2</b> members.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;III)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler h, int what, int arg1, int arg2) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Same as obtain(), but sets the values of the  <b>target</b>,  <b>what</b>,  <b>arg1</b>,  <b>arg2</b>, and  <b>obj</b> members.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Message object from the global pool. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler h, int what, int arg1, int arg2, object obj) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <summary>
				///  <para>Return a Message instance to the global pool. You MUST NOT touch the Message after calling this function  it has effectively been freed. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make this message like o. Performs a shallow copy of the data field. Does not copy the linked list fields, nor the timestamp or target/callback of the original message. </para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public void CopyFrom(global::Android.OS.Message o) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like getData(), but does not lazily create the Bundle. A null is returned if the Bundle does not already exist. See getData for further information on this.  <para>getData() </para> <para>setData(Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// peekData
				/// </java-name>
				[Dot42.DexImport("peekData", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle PeekData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Sends this Message to the Handler specified by getTarget. Throws a null pointer exception if this field has not been set. </para>        
				/// </summary>
				/// <java-name>
				/// sendToTarget
				/// </java-name>
				[Dot42.DexImport("sendToTarget", "()V", AccessFlags = 1)]
				public void SendToTarget() /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the targeted delivery time of this message, in milliseconds. </para>        
				/// </summary>
				/// <java-name>
				/// getWhen
				/// </java-name>
				public long When
				{
						[Dot42.DexImport("getWhen", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Retrieve the a Handler implementation that will receive this message. The object must implement Handler.handleMessage(). Each Handler has its own name-space for message codes, so you do not need to worry about yours conflicting with other handlers. </para>        
				/// </summary>
				/// <java-name>
				/// getTarget
				/// </java-name>
				public global::Android.OS.Handler Target
				{
						[Dot42.DexImport("getTarget", "()Landroid/os/Handler;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Handler); }
						[Dot42.DexImport("setTarget", "(Landroid/os/Handler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Retrieve callback object that will execute when this message is handled. This object must implement Runnable. This is called by the  <b>target</b> Handler that is receiving this Message to dispatch it. If not set, the message will be dispatched to the receiving Handler's ). </para>        
				/// </summary>
				/// <java-name>
				/// getCallback
				/// </java-name>
				public global::Java.Lang.IRunnable Callback
				{
						[Dot42.DexImport("getCallback", "()Ljava/lang/Runnable;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.IRunnable); }
				}

				/// <summary>
				///  <para>Obtains a Bundle of arbitrary data associated with this event, lazily creating it if necessary. Set this value by calling setData(Bundle). Note that when transferring data across processes via Messenger, you will need to set your ClassLoader on the Bundle via Bundle.setClassLoader() so that it can instantiate your objects when you retrieve them.  <para>peekData() </para> <para>setData(Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// getData
				/// </java-name>
				public global::Android.OS.Bundle Data
				{
						[Dot42.DexImport("getData", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
						[Dot42.DexImport("setData", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Low-level class holding the list of messages to be dispatched by a Looper. Messages are not added directly to a MessageQueue, but rather through Handler objects associated with the Looper.</para> <para>You can retrieve the MessageQueue for the current thread with Looper.myQueue(). </para>    
		/// </summary>
		/// <java-name>
		/// android/os/MessageQueue
		/// </java-name>
		[Dot42.DexImport("android/os/MessageQueue", AccessFlags = 33)]
		public partial class MessageQueue
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MessageQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a new IdleHandler to this message queue. This may be removed automatically for you by returning false from IdleHandler.queueIdle() when it is invoked, or explicitly removing it with removeIdleHandler.</para> <para>This method is safe to call from any thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addIdleHandler
				/// </java-name>
				[Dot42.DexImport("addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", AccessFlags = 17)]
				public void AddIdleHandler(global::Android.OS.MessageQueue.IIdleHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove an IdleHandler from the queue that was previously added with addIdleHandler. If the given object is not currently in the idle list, nothing is done.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeIdleHandler
				/// </java-name>
				[Dot42.DexImport("removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", AccessFlags = 17)]
				public void RemoveIdleHandler(global::Android.OS.MessageQueue.IIdleHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MessageQueue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback interface for discovering when a thread is going to block waiting for more messages. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/MessageQueue$IdleHandler
				/// </java-name>
				[Dot42.DexImport("android/os/MessageQueue$IdleHandler", AccessFlags = 1545)]
				public partial interface IIdleHandler
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the message queue has run out of messages and will now wait for more. Return true to keep your idle handler active, false to have it removed. This may be called if there are still messages pending in the queue, but they are all scheduled to be dispatched after the current time. </para>        
						/// </summary>
						/// <java-name>
						/// queueIdle
						/// </java-name>
						[Dot42.DexImport("queueIdle", "()Z", AccessFlags = 1025)]
						bool QueueIdle() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Reference to a Handler, which others can use to send messages to it. This allows for the implementation of message-based communication across processes, by creating a Messenger pointing to a Handler in one process, and handing that Messenger to another process. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Messenger
		/// </java-name>
		[Dot42.DexImport("android/os/Messenger", AccessFlags = 49)]
		public sealed partial class Messenger : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.Messenger> CREATOR;
				/// <summary>
				///  <para>Create a new Messenger pointing to the given Handler. Any Message objects sent through this Messenger will appear in the Handler as if Handler.sendMessage(Message) had been called directly.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public Messenger(global::Android.OS.Handler target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new Messenger pointing to the given Handler. Any Message objects sent through this Messenger will appear in the Handler as if Handler.sendMessage(Message) had been called directly.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public Messenger(global::Android.OS.IBinder target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a Message to this Messenger's Handler.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public void Send(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Comparison operator on two Messenger objects, such that true is returned then they both point to the same Handler. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object otherObj) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function for writing either a Messenger or null pointer to a Parcel. You must use this with readMessengerOrNullFromParcel for later reading it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeMessengerOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteMessengerOrNullToParcel(global::Android.OS.Messenger messenger, global::Android.OS.Parcel @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function for reading either a Messenger or null pointer from a Parcel. You must have previously written the Messenger with writeMessengerOrNullToParcel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the Messenger read from the Parcel, or null if null had been written. </para>
				/// </returns>
				/// <java-name>
				/// readMessengerOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;", AccessFlags = 9)]
				public static global::Android.OS.Messenger ReadMessengerOrNullFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Messenger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Messenger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the IBinder that this Messenger is using to communicate with its associated Handler.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the IBinder backing this Messenger. </para>
				/// </returns>
				/// <java-name>
				/// getBinder
				/// </java-name>
				public global::Android.OS.IBinder Binder
				{
						[Dot42.DexImport("getBinder", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when an application attempts to perform a networking operation on its main thread.</para> <para>This is only thrown for applications targeting the Honeycomb SDK or higher. Applications targeting earlier SDK versions are allowed to do networking on their main event loop threads, but it's heavily discouraged. See the document .</para> <para>Also see StrictMode. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/NetworkOnMainThreadException
		/// </java-name>
		[Dot42.DexImport("android/os/NetworkOnMainThreadException", AccessFlags = 33)]
		public partial class NetworkOnMainThreadException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetworkOnMainThreadException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception type that is thrown when an operation in progress is canceled.</para> <para> <para>CancellationSignal </para></para>    
		/// </summary>
		/// <java-name>
		/// android/os/OperationCanceledException
		/// </java-name>
		[Dot42.DexImport("android/os/OperationCanceledException", AccessFlags = 33)]
		public partial class OperationCanceledException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OperationCanceledException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public OperationCanceledException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Container for a message (data and object references) that can be sent through an IBinder. A Parcel can contain both flattened data that will be unflattened on the other side of the IPC (using the various methods here for writing specific types, or the general Parcelable interface), and references to live IBinder objects that will result in the other side receiving a proxy IBinder connected with the original IBinder in the Parcel.</para> <para>Parcel is  <b>not</b> a general-purpose serialization mechanism. This class (and the corresponding Parcelable API for placing arbitrary objects into a Parcel) is designed as a high-performance IPC transport. As such, it is not appropriate to place any Parcel data in to persistent storage: changes in the underlying implementation of any of the data in the Parcel can render older data unreadable.</para> <para>The bulk of the Parcel API revolves around reading and writing data of various types. There are six major classes of such functions available.</para> <para> <h3>Primitives</h3></para> <para>The most basic data functions are for writing and reading primitive data types: writeByte, readByte, writeDouble, readDouble, writeFloat, readFloat, writeInt, readInt, writeLong, readLong, writeString, readString. Most other data operations are built on top of these. The given data is written and read using the endianess of the host CPU.</para> <para> <h3>Primitive Arrays</h3></para> <para>There are a variety of methods for reading and writing raw arrays of primitive objects, which generally result in writing a 4-byte length followed by the primitive data items. The methods for reading can either read the data into an existing array, or create and return a new array. These available types are:</para> <para> <ul> <li> <para>writeBooleanArray(boolean[]), readBooleanArray(boolean[]), createBooleanArray() </para></li> <li> <para>writeByteArray(byte[]), writeByteArray(byte[], int, int), readByteArray(byte[]), createByteArray() </para></li> <li> <para>writeCharArray(char[]), readCharArray(char[]), createCharArray() </para></li> <li> <para>writeDoubleArray(double[]), readDoubleArray(double[]), createDoubleArray() </para></li> <li> <para>writeFloatArray(float[]), readFloatArray(float[]), createFloatArray() </para></li> <li> <para>writeIntArray(int[]), readIntArray(int[]), createIntArray() </para></li> <li> <para>writeLongArray(long[]), readLongArray(long[]), createLongArray() </para></li> <li> <para>writeStringArray(String[]), readStringArray(String[]), createStringArray(). </para></li> <li> <para>writeSparseBooleanArray(SparseBooleanArray), readSparseBooleanArray(). </para></li></ul></para> <para> <h3>Parcelables</h3></para> <para>The Parcelable protocol provides an extremely efficient (but low-level) protocol for objects to write and read themselves from Parcels. You can use the direct methods writeParcelable(Parcelable, int) and readParcelable(ClassLoader) or writeParcelableArray and readParcelableArray(ClassLoader) to write or read. These methods write both the class type and its data to the Parcel, allowing that class to be reconstructed from the appropriate class loader when later reading.</para> <para>There are also some methods that provide a more efficient way to work with Parcelables: writeTypedArray, writeTypedList(List), readTypedArray and readTypedList. These methods do not write the class information of the original object: instead, the caller of the read function must know what type to expect and pass in the appropriate Parcelable.Creator instead to properly construct the new object and read its data. (To more efficient write and read a single Parceable object, you can directly call Parcelable.writeToParcel and Parcelable.Creator.createFromParcel yourself.)</para> <para> <h3>Bundles</h3></para> <para>A special type-safe container, called Bundle, is available for key/value maps of heterogeneous values. This has many optimizations for improved performance when reading and writing data, and its type-safe API avoids difficult to debug type errors when finally marshalling the data contents into a Parcel. The methods to use are writeBundle(Bundle), readBundle(), and readBundle(ClassLoader).</para> <para> <h3>Active Objects</h3></para> <para>An unusual feature of Parcel is the ability to read and write active objects. For these objects the actual contents of the object is not written, rather a special token referencing the object is written. When reading the object back from the Parcel, you do not get a new instance of the object, but rather a handle that operates on the exact same object that was originally written. There are two forms of active objects available.</para> <para>Binder objects are a core facility of Android's general cross-process communication system. The IBinder interface describes an abstract protocol with a Binder object. Any such interface can be written in to a Parcel, and upon reading you will receive either the original object implementing that interface or a special proxy implementation that communicates calls back to the original object. The methods to use are writeStrongBinder(IBinder), writeStrongInterface(IInterface), readStrongBinder(), writeBinderArray(IBinder[]), readBinderArray(IBinder[]), createBinderArray(), writeBinderList(List), readBinderList(List), createBinderArrayList().</para> <para>FileDescriptor objects, representing raw Linux file descriptor identifiers, can be written and ParcelFileDescriptor objects returned to operate on the original file descriptor. The returned file descriptor is a dup of the original file descriptor: the object and fd is different, but operating on the same underlying file stream, with the same position, etc. The methods to use are writeFileDescriptor(FileDescriptor), readFileDescriptor().</para> <para> <h3>Untyped Containers</h3></para> <para>A final class of methods are for writing and reading standard Java containers of arbitrary types. These all revolve around the writeValue(Object) and readValue(ClassLoader) methods which define the types of objects allowed. The container methods are writeArray(Object[]), readArray(ClassLoader), writeList(List), readList(List, ClassLoader), readArrayList(ClassLoader), writeMap(Map), readMap(Map, ClassLoader), writeSparseArray(SparseArray), readSparseArray(ClassLoader). </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Parcel
		/// </java-name>
		[Dot42.DexImport("android/os/Parcel", AccessFlags = 49)]
		public sealed partial class Parcel
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STRING_CREATOR
				/// </java-name>
				[Dot42.DexImport("STRING_CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<string> STRING_CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Parcel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve a new Parcel object from the pool. </para>        
				/// </summary>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/os/Parcel;", AccessFlags = 9)]
				public static global::Android.OS.Parcel Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Parcel);
				}

				/// <summary>
				///  <para>Put a Parcel object back into the pool. You must not touch the object after this call. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 17)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the total amount of data contained in the parcel. </para>        
				/// </summary>
				/// <java-name>
				/// dataSize
				/// </java-name>
				[Dot42.DexImport("dataSize", "()I", AccessFlags = 17)]
				public int DataSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the amount of data remaining to be read from the parcel. That is, dataSize-dataPosition. </para>        
				/// </summary>
				/// <java-name>
				/// dataAvail
				/// </java-name>
				[Dot42.DexImport("dataAvail", "()I", AccessFlags = 17)]
				public int DataAvail() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the current position in the parcel data. Never more than dataSize. </para>        
				/// </summary>
				/// <java-name>
				/// dataPosition
				/// </java-name>
				[Dot42.DexImport("dataPosition", "()I", AccessFlags = 17)]
				public int DataPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the total amount of space in the parcel. This is always &gt;= dataSize. The difference between it and dataSize() is the amount of room left until the parcel needs to re-allocate its data buffer. </para>        
				/// </summary>
				/// <java-name>
				/// dataCapacity
				/// </java-name>
				[Dot42.DexImport("dataCapacity", "()I", AccessFlags = 17)]
				public int DataCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Change the amount of data in the parcel. Can be either smaller or larger than the current size. If larger than the current capacity, more memory will be allocated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSize
				/// </java-name>
				[Dot42.DexImport("setDataSize", "(I)V", AccessFlags = 17)]
				public void SetDataSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the current read/write position in the parcel. </para>        
				/// </summary>
				/// <java-name>
				/// setDataPosition
				/// </java-name>
				[Dot42.DexImport("setDataPosition", "(I)V", AccessFlags = 17)]
				public void SetDataPosition(int pos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the capacity (current available space) of the parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataCapacity
				/// </java-name>
				[Dot42.DexImport("setDataCapacity", "(I)V", AccessFlags = 17)]
				public void SetDataCapacity(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the raw bytes of the parcel.</para> <para>The data you retrieve here  <b>must not</b> be placed in any kind of persistent storage (on local disk, across a network, etc). For that, you should use standard serialization or another kind of general serialization mechanism. The Parcel marshalled representation is highly optimized for local IPC, and as such does not attempt to maintain compatibility with data created in different versions of the platform. </para>        
				/// </summary>
				/// <java-name>
				/// marshall
				/// </java-name>
				[Dot42.DexImport("marshall", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte[] JavaMarshall() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the raw bytes of the parcel.</para> <para>The data you retrieve here  <b>must not</b> be placed in any kind of persistent storage (on local disk, across a network, etc). For that, you should use standard serialization or another kind of general serialization mechanism. The Parcel marshalled representation is highly optimized for local IPC, and as such does not attempt to maintain compatibility with data created in different versions of the platform. </para>        
				/// </summary>
				/// <java-name>
				/// marshall
				/// </java-name>
				[Dot42.DexImport("marshall", "()[B", AccessFlags = 17)]
				public byte[] Marshall() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Set the bytes in data to be the raw bytes of this Parcel. </para>        
				/// </summary>
				/// <java-name>
				/// unmarshall
				/// </java-name>
				[Dot42.DexImport("unmarshall", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Unmarshall(sbyte[] data, int offest, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the bytes in data to be the raw bytes of this Parcel. </para>        
				/// </summary>
				/// <java-name>
				/// unmarshall
				/// </java-name>
				[Dot42.DexImport("unmarshall", "([BII)V", AccessFlags = 17)]
				public void Unmarshall(byte[] data, int offest, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendFrom
				/// </java-name>
				[Dot42.DexImport("appendFrom", "(Landroid/os/Parcel;II)V", AccessFlags = 17)]
				public void AppendFrom(global::Android.OS.Parcel parcel, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Store or read an IBinder interface token in the parcel at the current dataPosition. This is used to validate that the marshalled transaction is intended for the target interface. </para>        
				/// </summary>
				/// <java-name>
				/// writeInterfaceToken
				/// </java-name>
				[Dot42.DexImport("writeInterfaceToken", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteInterfaceToken(string interfaceName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceInterface
				/// </java-name>
				[Dot42.DexImport("enforceInterface", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void EnforceInterface(string interfaceName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte array into the parcel at the current dataPosition, growing dataCapacity if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByteArray(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte array into the parcel at the current dataPosition, growing dataCapacity if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([B)V", AccessFlags = 17)]
				public void WriteByteArray(byte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte array into the parcel at the current dataPosition, growing dataCapacity if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByteArray(sbyte[] b, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte array into the parcel at the current dataPosition, growing dataCapacity if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([BII)V", AccessFlags = 17)]
				public void WriteByteArray(byte[] b, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write an integer value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 17)]
				public void WriteInt(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a long integer value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 17)]
				public void WriteLong(long val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a floating point value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 17)]
				public void WriteFloat(float val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a double precision floating point value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 17)]
				public void WriteDouble(double val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a string value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeString
				/// </java-name>
				[Dot42.DexImport("writeString", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteString(string val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write an object into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeStrongBinder
				/// </java-name>
				[Dot42.DexImport("writeStrongBinder", "(Landroid/os/IBinder;)V", AccessFlags = 17)]
				public void WriteStrongBinder(global::Android.OS.IBinder val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write an object into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeStrongInterface
				/// </java-name>
				[Dot42.DexImport("writeStrongInterface", "(Landroid/os/IInterface;)V", AccessFlags = 17)]
				public void WriteStrongInterface(global::Android.OS.IInterface val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a FileDescriptor into the parcel at the current dataPosition(), growing dataCapacity() if needed.</para> <para>The file descriptor will not be closed, which may result in file descriptor leaks when objects are returned from Binder calls. Use ParcelFileDescriptor#writeToParcel instead, which accepts contextual flags and will close the original file descriptor if Parcelable#PARCELABLE_WRITE_RETURN_VALUE is set.</para>        
				/// </summary>
				/// <java-name>
				/// writeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("writeFileDescriptor", "(Ljava/io/FileDescriptor;)V", AccessFlags = 17)]
				public void WriteFileDescriptor(global::Java.IO.FileDescriptor val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByte(sbyte val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a byte value into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 17)]
				public void WriteByte(byte val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Please use writeBundle instead. Flattens a Map into the parcel at the current dataPosition(), growing dataCapacity() if needed. The Map keys must be String objects. The Map values are written using writeValue and must follow the specification there.</para> <para>It is strongly recommended to use writeBundle instead of this method, since the Bundle class provides a type-safe API that allows you to avoid mysterious type errors at the point of marshalling. </para>        
				/// </summary>
				/// <java-name>
				/// writeMap
				/// </java-name>
				[Dot42.DexImport("writeMap", "(Ljava/util/Map;)V", AccessFlags = 17)]
				public void WriteMap(global::Java.Util.IMap<object, object> val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a Bundle into the parcel at the current dataPosition(), growing dataCapacity() if needed. </para>        
				/// </summary>
				/// <java-name>
				/// writeBundle
				/// </java-name>
				[Dot42.DexImport("writeBundle", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void WriteBundle(global::Android.OS.Bundle val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a List into the parcel at the current dataPosition(), growing dataCapacity() if needed. The List values are written using writeValue and must follow the specification there. </para>        
				/// </summary>
				/// <java-name>
				/// writeList
				/// </java-name>
				[Dot42.DexImport("writeList", "(Ljava/util/List;)V", AccessFlags = 17)]
				public void WriteList(global::Java.Util.IList<object> val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten an Object array into the parcel at the current dataPosition(), growing dataCapacity() if needed. The array values are written using writeValue and must follow the specification there. </para>        
				/// </summary>
				/// <java-name>
				/// writeArray
				/// </java-name>
				[Dot42.DexImport("writeArray", "([Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteArray(object[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a generic SparseArray into the parcel at the current dataPosition(), growing dataCapacity() if needed. The SparseArray values are written using writeValue and must follow the specification there. </para>        
				/// </summary>
				/// <java-name>
				/// writeSparseArray
				/// </java-name>
				[Dot42.DexImport("writeSparseArray", "(Landroid/util/SparseArray;)V", AccessFlags = 17, Signature = "(Landroid/util/SparseArray<Ljava/lang/Object;>;)V")]
				public void WriteSparseArray(global::Android.Util.SparseArray<object> val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeSparseBooleanArray
				/// </java-name>
				[Dot42.DexImport("writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V", AccessFlags = 17)]
				public void WriteSparseBooleanArray(global::Android.Util.SparseBooleanArray val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBooleanArray
				/// </java-name>
				[Dot42.DexImport("writeBooleanArray", "([Z)V", AccessFlags = 17)]
				public void WriteBooleanArray(bool[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createBooleanArray
				/// </java-name>
				[Dot42.DexImport("createBooleanArray", "()[Z", AccessFlags = 17)]
				public bool[] CreateBooleanArray() /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// readBooleanArray
				/// </java-name>
				[Dot42.DexImport("readBooleanArray", "([Z)V", AccessFlags = 17)]
				public void ReadBooleanArray(bool[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeCharArray
				/// </java-name>
				[Dot42.DexImport("writeCharArray", "([C)V", AccessFlags = 17)]
				public void WriteCharArray(char[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createCharArray
				/// </java-name>
				[Dot42.DexImport("createCharArray", "()[C", AccessFlags = 17)]
				public char[] CreateCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// readCharArray
				/// </java-name>
				[Dot42.DexImport("readCharArray", "([C)V", AccessFlags = 17)]
				public void ReadCharArray(char[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeIntArray
				/// </java-name>
				[Dot42.DexImport("writeIntArray", "([I)V", AccessFlags = 17)]
				public void WriteIntArray(int[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createIntArray
				/// </java-name>
				[Dot42.DexImport("createIntArray", "()[I", AccessFlags = 17)]
				public int[] CreateIntArray() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// readIntArray
				/// </java-name>
				[Dot42.DexImport("readIntArray", "([I)V", AccessFlags = 17)]
				public void ReadIntArray(int[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLongArray
				/// </java-name>
				[Dot42.DexImport("writeLongArray", "([J)V", AccessFlags = 17)]
				public void WriteLongArray(long[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createLongArray
				/// </java-name>
				[Dot42.DexImport("createLongArray", "()[J", AccessFlags = 17)]
				public long[] CreateLongArray() /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <java-name>
				/// readLongArray
				/// </java-name>
				[Dot42.DexImport("readLongArray", "([J)V", AccessFlags = 17)]
				public void ReadLongArray(long[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloatArray
				/// </java-name>
				[Dot42.DexImport("writeFloatArray", "([F)V", AccessFlags = 17)]
				public void WriteFloatArray(float[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFloatArray
				/// </java-name>
				[Dot42.DexImport("createFloatArray", "()[F", AccessFlags = 17)]
				public float[] CreateFloatArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// readFloatArray
				/// </java-name>
				[Dot42.DexImport("readFloatArray", "([F)V", AccessFlags = 17)]
				public void ReadFloatArray(float[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDoubleArray
				/// </java-name>
				[Dot42.DexImport("writeDoubleArray", "([D)V", AccessFlags = 17)]
				public void WriteDoubleArray(double[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createDoubleArray
				/// </java-name>
				[Dot42.DexImport("createDoubleArray", "()[D", AccessFlags = 17)]
				public double[] CreateDoubleArray() /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <java-name>
				/// readDoubleArray
				/// </java-name>
				[Dot42.DexImport("readDoubleArray", "([D)V", AccessFlags = 17)]
				public void ReadDoubleArray(double[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStringArray
				/// </java-name>
				[Dot42.DexImport("writeStringArray", "([Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteStringArray(string[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createStringArray
				/// </java-name>
				[Dot42.DexImport("createStringArray", "()[Ljava/lang/String;", AccessFlags = 17)]
				public string[] CreateStringArray() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// readStringArray
				/// </java-name>
				[Dot42.DexImport("readStringArray", "([Ljava/lang/String;)V", AccessFlags = 17)]
				public void ReadStringArray(string[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBinderArray
				/// </java-name>
				[Dot42.DexImport("writeBinderArray", "([Landroid/os/IBinder;)V", AccessFlags = 17)]
				public void WriteBinderArray(global::Android.OS.IBinder[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createBinderArray
				/// </java-name>
				[Dot42.DexImport("createBinderArray", "()[Landroid/os/IBinder;", AccessFlags = 17)]
				public global::Android.OS.IBinder[] CreateBinderArray() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder[]);
				}

				/// <java-name>
				/// readBinderArray
				/// </java-name>
				[Dot42.DexImport("readBinderArray", "([Landroid/os/IBinder;)V", AccessFlags = 17)]
				public void ReadBinderArray(global::Android.OS.IBinder[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a List containing a particular object type into the parcel, at the current dataPosition() and growing dataCapacity() if needed. The type of the objects in the list must be one that implements Parcelable. Unlike the generic writeList() method, however, only the raw data of the objects is written and not their type, so you must use the corresponding readTypedList() to unmarshall them.</para> <para> <para>createTypedArrayList </para> <para>readTypedList </para> <para>Parcelable </para></para>        
				/// </summary>
				/// <java-name>
				/// writeTypedList
				/// </java-name>
				[Dot42.DexImport("writeTypedList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>(Ljava/util/List<TT;>;)V")]
				public void WriteTypedList<T>(global::Java.Util.IList<T> val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a List containing String objects into the parcel, at the current dataPosition() and growing dataCapacity() if needed. They can later be retrieved with createStringArrayList or readStringList.</para> <para> <para>createStringArrayList </para> <para>readStringList </para></para>        
				/// </summary>
				/// <java-name>
				/// writeStringList
				/// </java-name>
				[Dot42.DexImport("writeStringList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public void WriteStringList(global::Java.Util.IList<string> val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a List containing IBinder objects into the parcel, at the current dataPosition() and growing dataCapacity() if needed. They can later be retrieved with createBinderArrayList or readBinderList.</para> <para> <para>createBinderArrayList </para> <para>readBinderList </para></para>        
				/// </summary>
				/// <java-name>
				/// writeBinderList
				/// </java-name>
				[Dot42.DexImport("writeBinderList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/os/IBinder;>;)V")]
				public void WriteBinderList(global::Java.Util.IList<global::Android.OS.IBinder> val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a heterogeneous array containing a particular object type into the parcel, at the current dataPosition() and growing dataCapacity() if needed. The type of the objects in the array must be one that implements Parcelable. Unlike the writeParcelableArray method, however, only the raw data of the objects is written and not their type, so you must use readTypedArray with the correct corresponding Parcelable.Creator implementation to unmarshall them.</para> <para> <para>readTypedArray </para> <para>writeParcelableArray </para> <para>Parcelable.Creator </para></para>        
				/// </summary>
				/// <java-name>
				/// writeTypedArray
				/// </java-name>
				[Dot42.DexImport("writeTypedArray", "([Landroid/os/Parcelable;I)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>([TT;I)V")]
				public void WriteTypedArray<T>(T[] val, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten a generic object in to a parcel. The given Object value may currently be one of the following types:</para> <para> <ul> <li> <para>null </para></li> <li> <para>String </para></li> <li> <para>Byte </para></li> <li> <para>Short </para></li> <li> <para>Integer </para></li> <li> <para>Long </para></li> <li> <para>Float </para></li> <li> <para>Double </para></li> <li> <para>Boolean </para></li> <li> <para>String[] </para></li> <li> <para>boolean[] </para></li> <li> <para>byte[] </para></li> <li> <para>int[] </para></li> <li> <para>long[] </para></li> <li> <para>Object[] (supporting objects of the same type defined here). </para></li> <li> <para>Bundle </para></li> <li> <para>Map (as supported by writeMap). </para></li> <li> <para>Any object that implements the Parcelable protocol. </para></li> <li> <para>Parcelable[] </para></li> <li> <para>CharSequence (as supported by TextUtils#writeToParcel). </para></li> <li> <para>List (as supported by writeList). </para></li> <li> <para>SparseArray (as supported by writeSparseArray(SparseArray)). </para></li> <li> <para>IBinder </para></li> <li> <para>Any object that implements Serializable (but see writeSerializable for caveats). Note that all of the previous types have relatively efficient implementations for writing to a Parcel; having to rely on the generic serialization approach is much less efficient and should be avoided whenever possible. </para></li></ul></para> <para>Parcelable objects are written with Parcelable#writeToParcel using contextual flags of 0. When serializing objects containing ParcelFileDescriptors, this may result in file descriptor leaks when they are returned from Binder calls (where Parcelable#PARCELABLE_WRITE_RETURN_VALUE should be used).</para>        
				/// </summary>
				/// <java-name>
				/// writeValue
				/// </java-name>
				[Dot42.DexImport("writeValue", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteValue(object v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten the name of the class of the Parcelable and its contents into the parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeParcelable
				/// </java-name>
				[Dot42.DexImport("writeParcelable", "(Landroid/os/Parcelable;I)V", AccessFlags = 17)]
				public void WriteParcelable(global::Android.OS.IParcelable p, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a generic serializable object in to a Parcel. It is strongly recommended that this method be avoided, since the serialization overhead is extremely large, and this approach will be much slower than using the other approaches to writing data in to a Parcel. </para>        
				/// </summary>
				/// <java-name>
				/// writeSerializable
				/// </java-name>
				[Dot42.DexImport("writeSerializable", "(Ljava/io/Serializable;)V", AccessFlags = 17)]
				public void WriteSerializable(global::Java.IO.ISerializable s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Special function for writing an exception result at the header of a parcel, to be used when returning an exception from a transaction. Note that this currently only supports a few exception types; any other exception will be re-thrown by this function as a RuntimeException (to be caught by the system's last-resort exception handling when dispatching a transaction).</para> <para>The supported exception types are:  <ul> <li> <para>BadParcelableException </para></li> <li> <para>IllegalArgumentException </para></li> <li> <para>IllegalStateException </para></li> <li> <para>NullPointerException </para></li> <li> <para>SecurityException </para></li> <li> <para>NetworkOnMainThreadException </para></li></ul></para> <para> <para>writeNoException </para> <para>readException </para></para>        
				/// </summary>
				/// <java-name>
				/// writeException
				/// </java-name>
				[Dot42.DexImport("writeException", "(Ljava/lang/Exception;)V", AccessFlags = 17)]
				public void WriteException(global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Special function for writing information at the front of the Parcel indicating that no exception occurred.</para> <para> <para>writeException </para> <para>readException </para></para>        
				/// </summary>
				/// <java-name>
				/// writeNoException
				/// </java-name>
				[Dot42.DexImport("writeNoException", "()V", AccessFlags = 17)]
				public void WriteNoException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Special function for reading an exception result from the header of a parcel, to be used after receiving the result of a transaction. This will throw the exception for you if it had been written to the Parcel, otherwise return and let you read the normal result data from the Parcel.</para> <para> <para>writeException </para> <para>writeNoException </para></para>        
				/// </summary>
				/// <java-name>
				/// readException
				/// </java-name>
				[Dot42.DexImport("readException", "()V", AccessFlags = 17)]
				public void ReadException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use this function for customized exception handling. customized method call this method for all unknown case </para>        
				/// </summary>
				/// <java-name>
				/// readException
				/// </java-name>
				[Dot42.DexImport("readException", "(ILjava/lang/String;)V", AccessFlags = 17)]
				public void ReadException(int code, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read an integer value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 17)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Read a long integer value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 17)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Read a floating point value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 17)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Read a double precision floating point value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 17)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Read a string value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readString
				/// </java-name>
				[Dot42.DexImport("readString", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Read an object from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readStrongBinder
				/// </java-name>
				[Dot42.DexImport("readStrongBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
				public global::Android.OS.IBinder ReadStrongBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Read a FileDescriptor from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readFileDescriptor
				/// </java-name>
				[Dot42.DexImport("readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 17)]
				public global::Android.OS.ParcelFileDescriptor ReadFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Read a byte value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Read a byte value from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Please use readBundle(ClassLoader) instead (whose data must have been written with writeBundle. Read into an existing Map object from the parcel at the current dataPosition(). </para>        
				/// </summary>
				/// <java-name>
				/// readMap
				/// </java-name>
				[Dot42.DexImport("readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V", AccessFlags = 17)]
				public void ReadMap(global::Java.Util.IMap<object, object> outVal, global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read into an existing List object from the parcel at the current dataPosition(), using the given class loader to load any enclosed Parcelables. If it is null, the default class loader is used. </para>        
				/// </summary>
				/// <java-name>
				/// readList
				/// </java-name>
				[Dot42.DexImport("readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V", AccessFlags = 17)]
				public void ReadList(global::Java.Util.IList<object> outVal, global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Please use readBundle(ClassLoader) instead (whose data must have been written with writeBundle. Read and return a new HashMap object from the parcel at the current dataPosition(), using the given class loader to load any enclosed Parcelables. Returns null if the previously written map object was null. </para>        
				/// </summary>
				/// <java-name>
				/// readHashMap
				/// </java-name>
				[Dot42.DexImport("readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;", AccessFlags = 17)]
				public global::Java.Util.HashMap<object, object> ReadHashMap(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.HashMap<object, object>);
				}

				/// <summary>
				///  <para>Read and return a new Bundle object from the parcel at the current dataPosition(). Returns null if the previously written Bundle object was null. </para>        
				/// </summary>
				/// <java-name>
				/// readBundle
				/// </java-name>
				[Dot42.DexImport("readBundle", "()Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle ReadBundle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Read and return a new Bundle object from the parcel at the current dataPosition(), using the given class loader to initialize the class loader of the Bundle for later retrieval of Parcelable objects. Returns null if the previously written Bundle object was null. </para>        
				/// </summary>
				/// <java-name>
				/// readBundle
				/// </java-name>
				[Dot42.DexImport("readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle ReadBundle(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Read and return a byte[] object from the parcel. </para>        
				/// </summary>
				/// <java-name>
				/// createByteArray
				/// </java-name>
				[Dot42.DexImport("createByteArray", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte[] JavaCreateByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Read and return a byte[] object from the parcel. </para>        
				/// </summary>
				/// <java-name>
				/// createByteArray
				/// </java-name>
				[Dot42.DexImport("createByteArray", "()[B", AccessFlags = 17)]
				public byte[] CreateByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Read a byte[] object from the parcel and copy it into the given byte array. </para>        
				/// </summary>
				/// <java-name>
				/// readByteArray
				/// </java-name>
				[Dot42.DexImport("readByteArray", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadByteArray(sbyte[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read a byte[] object from the parcel and copy it into the given byte array. </para>        
				/// </summary>
				/// <java-name>
				/// readByteArray
				/// </java-name>
				[Dot42.DexImport("readByteArray", "([B)V", AccessFlags = 17)]
				public void ReadByteArray(byte[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read and return a new ArrayList object from the parcel at the current dataPosition(). Returns null if the previously written list object was null. The given class loader will be used to load any enclosed Parcelables. </para>        
				/// </summary>
				/// <java-name>
				/// readArrayList
				/// </java-name>
				[Dot42.DexImport("readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;", AccessFlags = 17)]
				public global::Java.Util.ArrayList<object> ReadArrayList(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<object>);
				}

				/// <summary>
				///  <para>Read and return a new Object array from the parcel at the current dataPosition(). Returns null if the previously written array was null. The given class loader will be used to load any enclosed Parcelables. </para>        
				/// </summary>
				/// <java-name>
				/// readArray
				/// </java-name>
				[Dot42.DexImport("readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;", AccessFlags = 17)]
				public object[] ReadArray(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				///  <para>Read and return a new SparseArray object from the parcel at the current dataPosition(). Returns null if the previously written list object was null. The given class loader will be used to load any enclosed Parcelables. </para>        
				/// </summary>
				/// <java-name>
				/// readSparseArray
				/// </java-name>
				[Dot42.DexImport("readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;", AccessFlags = 17)]
				public global::Android.Util.SparseArray<object> ReadSparseArray(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseArray<object>);
				}

				/// <summary>
				///  <para>Read and return a new SparseBooleanArray object from the parcel at the current dataPosition(). Returns null if the previously written list object was null. </para>        
				/// </summary>
				/// <java-name>
				/// readSparseBooleanArray
				/// </java-name>
				[Dot42.DexImport("readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;", AccessFlags = 17)]
				public global::Android.Util.SparseBooleanArray ReadSparseBooleanArray() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseBooleanArray);
				}

				/// <summary>
				///  <para>Read and return a new ArrayList containing a particular object type from the parcel that was written with writeTypedList at the current dataPosition(). Returns null if the previously written list object was null. The list  <b>must</b> have previously been written via writeTypedList with the same object type.</para> <para> <para>writeTypedList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing objects with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// createTypedArrayList
				/// </java-name>
				[Dot42.DexImport("createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Landroid/os/Parcelable$Creator<TT;>;)Ljava/util/ArrayList<" +
    "TT;>;")]
				public global::Java.Util.ArrayList<T> CreateTypedArrayList<T>(global::Android.OS.IParcelable_ICreator<T> c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <summary>
				///  <para>Read into the given List items containing a particular object type that were written with writeTypedList at the current dataPosition(). The list  <b>must</b> have previously been written via writeTypedList with the same object type.</para> <para> <para>writeTypedList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing objects with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// readTypedList
				/// </java-name>
				[Dot42.DexImport("readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;Landroid/os/Parcelable$Creator<TT;>;)" +
    "V")]
				public void ReadTypedList<T>(global::Java.Util.IList<T> list, global::Android.OS.IParcelable_ICreator<T> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read and return a new ArrayList containing String objects from the parcel that was written with writeStringList at the current dataPosition(). Returns null if the previously written list object was null.</para> <para> <para>writeStringList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing strings with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// createStringArrayList
				/// </java-name>
				[Dot42.DexImport("createStringArrayList", "()Ljava/util/ArrayList;", AccessFlags = 17, Signature = "()Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> CreateStringArrayList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <summary>
				///  <para>Read and return a new ArrayList containing IBinder objects from the parcel that was written with writeBinderList at the current dataPosition(). Returns null if the previously written list object was null.</para> <para> <para>writeBinderList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing strings with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// createBinderArrayList
				/// </java-name>
				[Dot42.DexImport("createBinderArrayList", "()Ljava/util/ArrayList;", AccessFlags = 17, Signature = "()Ljava/util/ArrayList<Landroid/os/IBinder;>;")]
				public global::Java.Util.ArrayList<global::Android.OS.IBinder> CreateBinderArrayList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.OS.IBinder>);
				}

				/// <summary>
				///  <para>Read into the given List items String objects that were written with writeStringList at the current dataPosition().</para> <para> <para>writeStringList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing strings with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// readStringList
				/// </java-name>
				[Dot42.DexImport("readStringList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public void ReadStringList(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read into the given List items IBinder objects that were written with writeBinderList at the current dataPosition().</para> <para> <para>writeBinderList </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created ArrayList containing strings with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// readBinderList
				/// </java-name>
				[Dot42.DexImport("readBinderList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/os/IBinder;>;)V")]
				public void ReadBinderList(global::Java.Util.IList<global::Android.OS.IBinder> list) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read and return a new array containing a particular object type from the parcel at the current dataPosition(). Returns null if the previously written array was null. The array  <b>must</b> have previously been written via writeTypedArray with the same object type.</para> <para> <para>writeTypedArray </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A newly created array containing objects with the same data as those that were previously written.</para>
				/// </returns>
				/// <java-name>
				/// createTypedArray
				/// </java-name>
				[Dot42.DexImport("createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Landroid/os/Parcelable$Creator<TT;>;)[TT;")]
				public T[] CreateTypedArray<T>(global::Android.OS.IParcelable_ICreator<T> c) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// readTypedArray
				/// </java-name>
				[Dot42.DexImport("readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>([TT;Landroid/os/Parcelable$Creator<TT;>;)V")]
				public void ReadTypedArray<T>(T[] val, global::Android.OS.IParcelable_ICreator<T> c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a heterogeneous array of Parcelable objects into the Parcel. Each object in the array is written along with its class name, so that the correct class can later be instantiated. As a result, this has significantly more overhead than writeTypedArray, but will correctly handle an array containing more than one type of object.</para> <para> <para>writeTypedArray </para></para>        
				/// </summary>
				/// <java-name>
				/// writeParcelableArray
				/// </java-name>
				[Dot42.DexImport("writeParcelableArray", "([Landroid/os/Parcelable;I)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>([TT;I)V")]
				public void WriteParcelableArray<T>(T[] value, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read a typed object from a parcel. The given class loader will be used to load any enclosed Parcelables. If it is null, the default class loader will be used. </para>        
				/// </summary>
				/// <java-name>
				/// readValue
				/// </java-name>
				[Dot42.DexImport("readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;", AccessFlags = 17)]
				public object ReadValue(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Read and return a new Parcelable from the parcel. The given class loader will be used to load any enclosed Parcelables. If it is null, the default class loader will be used. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the newly created Parcelable, or null if a null object has been written. </para>
				/// </returns>
				/// <java-name>
				/// readParcelable
				/// </java-name>
				[Dot42.DexImport("readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/ClassLoader;)TT;")]
				public T ReadParcelable<T>(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Read and return a new Parcelable array from the parcel. The given class loader will be used to load any enclosed Parcelables. </para>        
				/// </summary>
				/// <returns>
				///  <para>the Parcelable array, or null if the array is null </para>
				/// </returns>
				/// <java-name>
				/// readParcelableArray
				/// </java-name>
				[Dot42.DexImport("readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;", AccessFlags = 17)]
				public global::Android.OS.IParcelable[] ReadParcelableArray(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable[]);
				}

				/// <summary>
				///  <para>Read and return a new Serializable object from the parcel. </para>        
				/// </summary>
				/// <returns>
				///  <para>the Serializable object, or null if the Serializable name wasn't found in the parcel. </para>
				/// </returns>
				/// <java-name>
				/// readSerializable
				/// </java-name>
				[Dot42.DexImport("readSerializable", "()Ljava/io/Serializable;", AccessFlags = 17)]
				public global::Java.IO.ISerializable ReadSerializable() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ISerializable);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/os/Parcel;", AccessFlags = 28)]
				internal static global::Android.OS.Parcel Obtain(int obj) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Parcel);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Parcel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Report whether the parcel contains any marshalled file descriptors. </para>        
				/// </summary>
				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				public bool HasFileDescriptors
				{
						[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>The FileDescriptor returned by Parcel#readFileDescriptor, allowing you to close it when done with it. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/ParcelFileDescriptor
		/// </java-name>
		[Dot42.DexImport("android/os/ParcelFileDescriptor", AccessFlags = 33)]
		public partial class ParcelFileDescriptor : global::Android.OS.IParcelable, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>For use with open: if MODE_CREATE has been supplied and this file doesn't already exist, then create the file with permissions such that any application can read it.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Creating world-readable files is very dangerous, and likely to cause security holes in applications. It is strongly discouraged; instead, applications should use more formal mechanism for interactions such as ContentProvider, BroadcastReceiver, and android.app.Service. There are no guarantees that this access mode will remain on a file, such as when it goes through a backup and restore. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MODE_WORLD_READABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_READABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_READABLE = 1;
				/// <summary>
				///  <para>For use with open: if MODE_CREATE has been supplied and this file doesn't already exist, then create the file with permissions such that any application can write it.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Creating world-writable files is very dangerous, and likely to cause security holes in applications. It is strongly discouraged; instead, applications should use more formal mechanism for interactions such as ContentProvider, BroadcastReceiver, and android.app.Service. There are no guarantees that this access mode will remain on a file, such as when it goes through a backup and restore. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MODE_WORLD_WRITEABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_WRITEABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_WRITEABLE = 2;
				/// <summary>
				///  <para>For use with open: open the file with read-only access. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_READ_ONLY", "I", AccessFlags = 25)]
				public const int MODE_READ_ONLY = 268435456;
				/// <summary>
				///  <para>For use with open: open the file with write-only access. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_WRITE_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_WRITE_ONLY", "I", AccessFlags = 25)]
				public const int MODE_WRITE_ONLY = 536870912;
				/// <summary>
				///  <para>For use with open: open the file with read and write access. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_READ_WRITE
				/// </java-name>
				[Dot42.DexImport("MODE_READ_WRITE", "I", AccessFlags = 25)]
				public const int MODE_READ_WRITE = 805306368;
				/// <summary>
				///  <para>For use with open: create the file if it doesn't already exist. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_CREATE
				/// </java-name>
				[Dot42.DexImport("MODE_CREATE", "I", AccessFlags = 25)]
				public const int MODE_CREATE = 134217728;
				/// <summary>
				///  <para>For use with open: erase contents of file when opening. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_TRUNCATE
				/// </java-name>
				[Dot42.DexImport("MODE_TRUNCATE", "I", AccessFlags = 25)]
				public const int MODE_TRUNCATE = 67108864;
				/// <summary>
				///  <para>For use with open: append to end of file while writing. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_APPEND
				/// </java-name>
				[Dot42.DexImport("MODE_APPEND", "I", AccessFlags = 25)]
				public const int MODE_APPEND = 33554432;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.ParcelFileDescriptor> CREATOR;
				/// <summary>
				///  <para>Create a new ParcelFileDescriptor wrapped around another descriptor. By default all method calls are delegated to the wrapped descriptor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public ParcelFileDescriptor(global::Android.OS.ParcelFileDescriptor wrapped) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor accessing a given file.</para> <para> <para>parseMode(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new ParcelFileDescriptor pointing to the given file. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/io/File;I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor Open(global::Java.IO.File file, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor that is a dup of an existing FileDescriptor. This obeys standard POSIX semantics, where the new file descriptor shared state such as file position with the original file descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// dup
				/// </java-name>
				[Dot42.DexImport("dup", "(Ljava/io/FileDescriptor;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor Dup(global::Java.IO.FileDescriptor orig) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor that is a dup of the existing FileDescriptor. This obeys standard POSIX semantics, where the new file descriptor shared state such as file position with the original file descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// dup
				/// </java-name>
				[Dot42.DexImport("dup", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor Dup() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor from a raw native fd. The new ParcelFileDescriptor holds a dup of the original fd passed in here, so you must still close that fd as well as the new ParcelFileDescriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor holding a FileDescriptor for a dup of the given fd. </para>
				/// </returns>
				/// <java-name>
				/// fromFd
				/// </java-name>
				[Dot42.DexImport("fromFd", "(I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromFd(int fd) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Take ownership of a raw native fd in to a new ParcelFileDescriptor. The returned ParcelFileDescriptor now owns the given fd, and will be responsible for closing it. You must not close the fd yourself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor holding a FileDescriptor for the given fd. </para>
				/// </returns>
				/// <java-name>
				/// adoptFd
				/// </java-name>
				[Dot42.DexImport("adoptFd", "(I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor AdoptFd(int fd) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor from the specified Socket. The new ParcelFileDescriptor holds a dup of the original FileDescriptor in the Socket, so you must still close the Socket as well as the new ParcelFileDescriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new ParcelFileDescriptor with the FileDescriptor of the specified Socket. </para>
				/// </returns>
				/// <java-name>
				/// fromSocket
				/// </java-name>
				[Dot42.DexImport("fromSocket", "(Ljava/net/Socket;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromSocket(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create a new ParcelFileDescriptor from the specified DatagramSocket.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new ParcelFileDescriptor with the FileDescriptor of the specified DatagramSocket. </para>
				/// </returns>
				/// <java-name>
				/// fromDatagramSocket
				/// </java-name>
				[Dot42.DexImport("fromDatagramSocket", "(Ljava/net/DatagramSocket;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromDatagramSocket(global::Java.Net.DatagramSocket datagramSocket) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Create two ParcelFileDescriptors structured as a data pipe. The first ParcelFileDescriptor in the returned array is the read side; the second is the write side. </para>        
				/// </summary>
				/// <java-name>
				/// createPipe
				/// </java-name>
				[Dot42.DexImport("createPipe", "()[Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor[] CreatePipe() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor[]);
				}

				/// <summary>
				///  <para>Return the native fd int for this ParcelFileDescriptor and detach it from the object here. You are now responsible for closing the fd in native code. </para> <para>You should not detach when the original creator of the descriptor is expecting a reliable signal through close() or closeWithError(String).</para> <para> <para>canDetectErrors() </para></para>        
				/// </summary>
				/// <java-name>
				/// detachFd
				/// </java-name>
				[Dot42.DexImport("detachFd", "()I", AccessFlags = 1)]
				public virtual int DetachFd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Close the ParcelFileDescriptor. This implementation closes the underlying OS resources allocated to represent this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ParcelFileDescriptor() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <para>Flatten this object in to a Parcel.</para> <para></para> If Parcelable#PARCELABLE_WRITE_RETURN_VALUE is set in flags, the file descriptor will be closed after a copy is written to the Parcel. </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ParcelFileDescriptor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the actual FileDescriptor associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the FileDescriptor associated with this object. </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

				/// <summary>
				///  <para>Return the total size of the file representing this fd, as determined by  <c>stat() </c> . Returns -1 if the fd is not a file. </para>        
				/// </summary>
				/// <java-name>
				/// getStatSize
				/// </java-name>
				public virtual long StatSize
				{
						[Dot42.DexImport("getStatSize", "()J", AccessFlags = 257)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return the native fd int for this ParcelFileDescriptor. The ParcelFileDescriptor still owns the fd, and it still must be closed through this API. </para>        
				/// </summary>
				/// <java-name>
				/// getFd
				/// </java-name>
				public virtual int Fd
				{
						[Dot42.DexImport("getFd", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>An OutputStream you can create on a ParcelFileDescriptor, which will take care of calling ParcelFileDescriptor.close() for you when the stream is closed. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/ParcelFileDescriptor$AutoCloseOutputStream
				/// </java-name>
				[Dot42.DexImport("android/os/ParcelFileDescriptor$AutoCloseOutputStream", AccessFlags = 9)]
				public partial class AutoCloseOutputStream : global::Java.IO.FileOutputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseOutputStream(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
						/// </summary>
						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public override void Close() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AutoCloseOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>An InputStream you can create on a ParcelFileDescriptor, which will take care of calling ParcelFileDescriptor.close() for you when the stream is closed. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/ParcelFileDescriptor$AutoCloseInputStream
				/// </java-name>
				[Dot42.DexImport("android/os/ParcelFileDescriptor$AutoCloseInputStream", AccessFlags = 9)]
				public partial class AutoCloseInputStream : global::Java.IO.FileInputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseInputStream(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
						/// </summary>
						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public override void Close() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AutoCloseInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>The contents of a Parcel (usually during unmarshalling) does not contain the expected data. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/ParcelFormatException
		/// </java-name>
		[Dot42.DexImport("android/os/ParcelFormatException", AccessFlags = 33)]
		public partial class ParcelFormatException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParcelFormatException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ParcelFormatException(string reason) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class is a Parcelable wrapper around UUID which is an immutable representation of a 128-bit universally unique identifier. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/ParcelUuid
		/// </java-name>
		[Dot42.DexImport("android/os/ParcelUuid", AccessFlags = 49)]
		public sealed partial class ParcelUuid : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.ParcelUuid> CREATOR;
				/// <summary>
				///  <para>Constructor creates a ParcelUuid instance from the given UUID.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/UUID;)V", AccessFlags = 1)]
				public ParcelUuid(global::Java.Util.UUID uuid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new ParcelUuid from a string representation of UUID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ParcelUuid instance. </para>
				/// </returns>
				/// <java-name>
				/// fromString
				/// </java-name>
				[Dot42.DexImport("fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;", AccessFlags = 9)]
				public static global::Android.OS.ParcelUuid FromString(string uuid) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelUuid);
				}

				/// <summary>
				///  <para>Returns a string representation of the ParcelUuid For example: 0000110B-0000-1000-8000-00805F9B34FB will be the return value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String instance. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compares this ParcelUuid to another object for equality. If <c>object </c> is not <c>null </c> , is a ParcelUuid instance, and all bits are equal, then  <c>true </c> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this ParcelUuid is equal to <c>object </c> or <c>false </c> if not. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ParcelUuid() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Get the UUID represented by the ParcelUuid.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>UUID contained in the ParcelUuid. </para>
				/// </returns>
				/// <java-name>
				/// getUuid
				/// </java-name>
				public global::Java.Util.UUID Uuid
				{
						[Dot42.DexImport("getUuid", "()Ljava/util/UUID;", AccessFlags = 1)]
						get{ return default(global::Java.Util.UUID); }
				}

		}

		/// <summary>
		///  <para>A simple pattern matcher, which is safe to use on untrusted data: it does not provide full reg-exp support, only simple globbing that can not be used maliciously. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/PatternMatcher
		/// </java-name>
		[Dot42.DexImport("android/os/PatternMatcher", AccessFlags = 33)]
		public partial class PatternMatcher : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Pattern type: the given pattern must exactly match the string it is tested against. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_LITERAL
				/// </java-name>
				[Dot42.DexImport("PATTERN_LITERAL", "I", AccessFlags = 25)]
				public const int PATTERN_LITERAL = 0;
				/// <summary>
				///  <para>Pattern type: the given pattern must match the beginning of the string it is tested against. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_PREFIX
				/// </java-name>
				[Dot42.DexImport("PATTERN_PREFIX", "I", AccessFlags = 25)]
				public const int PATTERN_PREFIX = 1;
				/// <summary>
				///  <para>Pattern type: the given pattern is interpreted with a simple glob syntax for matching against the string it is tested against. In this syntax, you can use the '*' character to match against zero or more occurrences of the character immediately before. If the character before it is '.' it will match any character. The character '\' can be used as an escape. This essentially provides only the '*' wildcard part of a normal regexp. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_SIMPLE_GLOB
				/// </java-name>
				[Dot42.DexImport("PATTERN_SIMPLE_GLOB", "I", AccessFlags = 25)]
				public const int PATTERN_SIMPLE_GLOB = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.PatternMatcher> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public PatternMatcher(string pattern, int type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PatternMatcher(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Match(string str) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PatternMatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class gives you control of the power state of the device.</para> <para> <b>Device battery life will be significantly affected by the use of this API.</b> Do not acquire WakeLocks unless you really need them, use the minimum levels possible, and be sure to release them as soon as possible. </para> <para>You can obtain an instance of this class by calling Context.getSystemService(). </para> <para>The primary API you'll use is newWakeLock(). This will create a PowerManager.WakeLock object. You can then use methods on the wake lock object to control the power state of the device. </para> <para>In practice it's quite simple: { PowerManager pm = (PowerManager) getSystemService(Context.POWER_SERVICE); PowerManager.WakeLock wl = pm.newWakeLock(PowerManager.SCREEN_DIM_WAKE_LOCK, "My Tag"); wl.acquire(); ..screen will stay on during this section.. wl.release(); } </para> <para>The following wake lock levels are defined, with varying effects on system power.  <b>These levels are mutually exclusive - you may only specify one of them.</b></para> <para> <table> <row> <entry> <para>Flag Value </para></entry> <entry> <para>CPU </para></entry> <entry> <para>Screen </para></entry> <entry> <para>Keyboard</para> <para></para></entry></row> <row> <entry> <para>PARTIAL_WAKE_LOCK </para></entry> <entry> <para>On* </para></entry> <entry> <para>Off </para></entry> <entry> <para>Off </para> <para></para></entry></row> <row> <entry> <para>SCREEN_DIM_WAKE_LOCK </para></entry> <entry> <para>On </para></entry> <entry> <para>Dim </para></entry> <entry> <para>Off </para> <para></para></entry></row> <row> <entry> <para>SCREEN_BRIGHT_WAKE_LOCK </para></entry> <entry> <para>On </para></entry> <entry> <para>Bright </para></entry> <entry> <para>Off </para> <para></para></entry></row> <row> <entry> <para>FULL_WAKE_LOCK </para></entry> <entry> <para>On </para></entry> <entry> <para>Bright </para></entry> <entry> <para>Bright  </para></entry></row></table></para> <para>* <b>If you hold a partial wake lock, the CPU will continue to run, regardless of any display timeouts or the state of the screen and even after the user presses the power button. In all other wake locks, the CPU will run, but the user can still put the device to sleep using the power button.</b> </para> <para>In addition, you can add two more flags, which affect behavior of the screen only.  <b>These flags have no effect when combined with a PARTIAL_WAKE_LOCK.</b></para> <para> <table> <row> <entry> <para>Flag Value </para></entry> <entry> <para>Description</para> <para></para></entry></row> <row> <entry> <para>ACQUIRE_CAUSES_WAKEUP </para></entry> <entry> <para>Normal wake locks don't actually turn on the illumination. Instead, they cause the illumination to remain on once it turns on (e.g. from user activity). This flag will force the screen and/or keyboard to turn on immediately, when the WakeLock is acquired. A typical use would be for notifications which are important for the user to see immediately. </para> <para></para></entry></row> <row> <entry> <para>ON_AFTER_RELEASE </para></entry> <entry> <para>If this flag is set, the user activity timer will be reset when the WakeLock is released, causing the illumination to remain on a bit longer. This can be used to reduce flicker if you are cycling between wake lock conditions.  </para></entry></row></table></para> <para>Any application using a WakeLock must request the <c>android.permission.WAKE_LOCK </c> permission in an <c>&amp;lt;uses-permission&amp;gt; </c> element of the application's manifest. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/PowerManager
		/// </java-name>
		[Dot42.DexImport("android/os/PowerManager", AccessFlags = 33)]
		public partial class PowerManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Wake lock level: Ensures that the CPU is running; the screen and keyboard backlight will be allowed to go off. </para> <para>If the user presses the power button, then the screen will be turned off but the CPU will be kept on until all partial wake locks have been released. </para>        
				/// </summary>
				/// <java-name>
				/// PARTIAL_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("PARTIAL_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int PARTIAL_WAKE_LOCK = 1;
				/// <summary>
				///  <para>Wake lock level: Ensures that the screen and keyboard backlight are on at full brightness. </para> <para>If the user presses the power button, then the FULL_WAKE_LOCK will be implicitly released by the system, causing both the screen and the CPU to be turned off. Contrast with PARTIAL_WAKE_LOCK. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Most applications should use android.view.WindowManager.LayoutParams#FLAG_KEEP_SCREEN_ON instead of this type of wake lock, as it will be correctly managed by the platform as the user moves between applications and doesn't require a special permission. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// FULL_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("FULL_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int FULL_WAKE_LOCK = 26;
				/// <summary>
				///  <para>Wake lock level: Ensures that the screen is on at full brightness; the keyboard backlight will be allowed to go off. </para> <para>If the user presses the power button, then the SCREEN_BRIGHT_WAKE_LOCK will be implicitly released by the system, causing both the screen and the CPU to be turned off. Contrast with PARTIAL_WAKE_LOCK. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Most applications should use android.view.WindowManager.LayoutParams#FLAG_KEEP_SCREEN_ON instead of this type of wake lock, as it will be correctly managed by the platform as the user moves between applications and doesn't require a special permission. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_BRIGHT_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("SCREEN_BRIGHT_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int SCREEN_BRIGHT_WAKE_LOCK = 10;
				/// <summary>
				///  <para>Wake lock level: Ensures that the screen is on (but may be dimmed); the keyboard backlight will be allowed to go off. </para> <para>If the user presses the power button, then the SCREEN_DIM_WAKE_LOCK will be implicitly released by the system, causing both the screen and the CPU to be turned off. Contrast with PARTIAL_WAKE_LOCK. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Most applications should use android.view.WindowManager.LayoutParams#FLAG_KEEP_SCREEN_ON instead of this type of wake lock, as it will be correctly managed by the platform as the user moves between applications and doesn't require a special permission. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_DIM_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("SCREEN_DIM_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int SCREEN_DIM_WAKE_LOCK = 6;
				/// <summary>
				///  <para>Wake lock flag: Turn the screen on when the wake lock is acquired. </para> <para>Normally wake locks don't actually wake the device, they just cause the screen to remain on once it's already on. Think of the video player application as the normal behavior. Notifications that pop up and want the device to be on are the exception; use this flag to be like them. </para> <para>Cannot be used with PARTIAL_WAKE_LOCK. </para>        
				/// </summary>
				/// <java-name>
				/// ACQUIRE_CAUSES_WAKEUP
				/// </java-name>
				[Dot42.DexImport("ACQUIRE_CAUSES_WAKEUP", "I", AccessFlags = 25)]
				public const int ACQUIRE_CAUSES_WAKEUP = 268435456;
				/// <summary>
				///  <para>Wake lock flag: When this wake lock is released, poke the user activity timer so the screen stays on for a little longer. </para> <para>Will not turn the screen on if it is not already on. See ACQUIRE_CAUSES_WAKEUP if you want that. </para> <para>Cannot be used with PARTIAL_WAKE_LOCK. </para>        
				/// </summary>
				/// <java-name>
				/// ON_AFTER_RELEASE
				/// </java-name>
				[Dot42.DexImport("ON_AFTER_RELEASE", "I", AccessFlags = 25)]
				public const int ON_AFTER_RELEASE = 536870912;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PowerManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new wake lock with the specified level and flags. </para> <para>The <c>levelAndFlags </c> parameter specifies a wake lock level and optional flags combined using the logical OR operator. </para> <para>The wake lock levels are: PARTIAL_WAKE_LOCK, FULL_WAKE_LOCK, SCREEN_DIM_WAKE_LOCK and SCREEN_BRIGHT_WAKE_LOCK. Exactly one wake lock level must be specified as part of the <c>levelAndFlags </c> parameter. </para> <para>The wake lock flags are: ACQUIRE_CAUSES_WAKEUP and ON_AFTER_RELEASE. Multiple flags can be combined as part of the  <c>levelAndFlags </c> parameters. </para> <para>Call acquire() on the object to acquire the wake lock, and release() when you are done. </para> <para>{ PowerManager pm = (PowerManager)mContext.getSystemService( Context.POWER_SERVICE); PowerManager.WakeLock wl = pm.newWakeLock( PowerManager.SCREEN_DIM_WAKE_LOCK | PowerManager.ON_AFTER_RELEASE, TAG); wl.acquire(); // ... do work... wl.release(); } </para> <para>Although a wake lock can be created without special permissions, the android.Manifest.permission#WAKE_LOCK permission is required to actually acquire or release the wake lock that is returned. </para> <para>If using this to keep the screen on, you should strongly consider using android.view.WindowManager.LayoutParams#FLAG_KEEP_SCREEN_ON instead. This window flag will be correctly managed by the platform as the user moves between applications and doesn't require a special permission. </para> <para> <para>WakeLock::acquire() </para> <para>WakeLock::release() </para> <para>PARTIAL_WAKE_LOCK </para> <para>FULL_WAKE_LOCK </para> <para>SCREEN_DIM_WAKE_LOCK </para> <para>SCREEN_BRIGHT_WAKE_LOCK </para> <para>ACQUIRE_CAUSES_WAKEUP </para> <para>ON_AFTER_RELEASE </para></para>        
				/// </summary>
				/// <java-name>
				/// newWakeLock
				/// </java-name>
				[Dot42.DexImport("newWakeLock", "(ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;", AccessFlags = 1)]
				public virtual global::Android.OS.PowerManager.WakeLock NewWakeLock(int levelAndFlags, string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.PowerManager.WakeLock);
				}

				/// <summary>
				///  <para>Notifies the power manager that user activity happened. </para> <para>Resets the auto-off timer and brightens the screen if the device is not asleep. This is what happens normally when a key or the touch screen is pressed or when some other user activity occurs. This method does not wake up the device if it has been put to sleep. </para> <para>Requires the android.Manifest.permission#DEVICE_POWER permission. </para> <para> <para>wakeUp </para> <para>goToSleep </para></para>        
				/// </summary>
				/// <java-name>
				/// userActivity
				/// </java-name>
				[Dot42.DexImport("userActivity", "(JZ)V", AccessFlags = 1)]
				public virtual void UserActivity(long when, bool noChangeLights) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Forces the device to go to sleep. </para> <para>Overrides all the wake locks that are held. This is what happens when the power key is pressed to turn off the screen. </para> <para>Requires the android.Manifest.permission#DEVICE_POWER permission. </para> <para> <para>userActivity </para> <para>wakeUp </para></para>        
				/// </summary>
				/// <java-name>
				/// goToSleep
				/// </java-name>
				[Dot42.DexImport("goToSleep", "(J)V", AccessFlags = 1)]
				public virtual void GoToSleep(long time) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reboot the device. Will not return if the reboot is successful. </para> <para>Requires the android.Manifest.permission#REBOOT permission. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reboot
				/// </java-name>
				[Dot42.DexImport("reboot", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Reboot(string reason) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the screen is currently on. </para> <para>Only indicates whether the screen is on. The screen could be either bright or dim. </para> <para>{ PowerManager pm = (PowerManager) getSystemService(Context.POWER_SERVICE); boolean isScreenOn = pm.isScreenOn(); } </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the screen is on (bright or dim). </para>
				/// </returns>
				/// <java-name>
				/// isScreenOn
				/// </java-name>
				public virtual bool IsScreenOn
				{
						[Dot42.DexImport("isScreenOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>A wake lock is a mechanism to indicate that your application needs to have the device stay on. </para> <para>Any application using a WakeLock must request the <c>android.permission.WAKE_LOCK </c> permission in an <c>&amp;lt;uses-permission&amp;gt; </c> element of the application's manifest. Obtain a wake lock by calling PowerManager#newWakeLock(int, String). </para> <para>Call acquire() to acquire the wake lock and force the device to stay on at the level that was requested when the wake lock was created. </para> <para>Call release() when you are done and don't need the lock anymore. It is very important to do this as soon as possible to avoid running down the device's battery excessively. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/PowerManager$WakeLock
				/// </java-name>
				[Dot42.DexImport("android/os/PowerManager$WakeLock", AccessFlags = 1)]
				public partial class WakeLock
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/os/PowerManager;", AccessFlags = 4112)]
						internal readonly global::Android.OS.PowerManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/os/PowerManager;)V", AccessFlags = 0)]
						internal WakeLock(global::Android.OS.PowerManager powerManager) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets whether this WakeLock is reference counted. </para> <para>Wake locks are reference counted by default. If a wake lock is reference counted, then each call to acquire() must be balanced by an equal number of calls to release(). If a wake lock is not reference counted, then one call to release() is sufficient to undo the effect of all previous calls to acquire(). </para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Acquires the wake lock. </para> <para>Ensures that the device is on at the level requested when the wake lock was created. </para>        
						/// </summary>
						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Acquires the wake lock with a timeout. </para> <para>Ensures that the device is on at the level requested when the wake lock was created. The lock will be released after the given timeout expires. </para> <para></para>        
						/// </summary>
						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "(J)V", AccessFlags = 1)]
						public virtual void Acquire(long timeout) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Releases the wake lock. </para> <para>This method releases your claim to the CPU or screen being on. The screen may turn off shortly after you release the wake lock, or it may not if there are other wake locks still held. </para>        
						/// </summary>
						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the work source associated with the wake lock. </para> <para>The work source is used to determine on behalf of which application the wake lock is being held. This is useful in the case where a service is performing work on behalf of an application so that the cost of that work can be accounted to the application. </para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setWorkSource
						/// </java-name>
						[Dot42.DexImport("setWorkSource", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
						public virtual void SetWorkSource(global::Android.OS.WorkSource ws) /* MethodBuilder.Create */ 
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
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~WakeLock() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal WakeLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Returns true if the wake lock has been acquired but not yet released.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the wake lock is held. </para>
						/// </returns>
						/// <java-name>
						/// isHeld
						/// </java-name>
						public virtual bool IsHeld
						{
								[Dot42.DexImport("isHeld", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

		}

		/// <summary>
		///  <para>Tools for managing OS processes. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Process
		/// </java-name>
		[Dot42.DexImport("android/os/Process", AccessFlags = 33)]
		public partial class Process
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Defines the UID/GID under which system code runs. </para>        
				/// </summary>
				/// <java-name>
				/// SYSTEM_UID
				/// </java-name>
				[Dot42.DexImport("SYSTEM_UID", "I", AccessFlags = 25)]
				public const int SYSTEM_UID = 1000;
				/// <summary>
				///  <para>Defines the UID/GID under which the telephony code runs. </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_UID
				/// </java-name>
				[Dot42.DexImport("PHONE_UID", "I", AccessFlags = 25)]
				public const int PHONE_UID = 1001;
				/// <summary>
				///  <para>Defines the start of a range of UIDs (and GIDs), going from this number to LAST_APPLICATION_UID that are reserved for assigning to applications. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST_APPLICATION_UID
				/// </java-name>
				[Dot42.DexImport("FIRST_APPLICATION_UID", "I", AccessFlags = 25)]
				public const int FIRST_APPLICATION_UID = 10000;
				/// <summary>
				///  <para>Last of application-specific UIDs starting at FIRST_APPLICATION_UID. </para>        
				/// </summary>
				/// <java-name>
				/// LAST_APPLICATION_UID
				/// </java-name>
				[Dot42.DexImport("LAST_APPLICATION_UID", "I", AccessFlags = 25)]
				public const int LAST_APPLICATION_UID = 19999;
				/// <java-name>
				/// BLUETOOTH_GID
				/// </java-name>
				[Dot42.DexImport("BLUETOOTH_GID", "I", AccessFlags = 25)]
				public const int BLUETOOTH_GID = 2000;
				/// <summary>
				///  <para>Standard priority of application threads. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_DEFAULT", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_DEFAULT = 0;
				/// <summary>
				///  <para>Lowest available thread priority. Only for those who really, really don't want to run if anything else is happening. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_LOWEST
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_LOWEST", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_LOWEST = 19;
				/// <summary>
				///  <para>Standard priority background threads. This gives your thread a slightly lower than normal priority, so that it will have less chance of impacting the responsiveness of the user interface. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_BACKGROUND
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_BACKGROUND", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_BACKGROUND = 10;
				/// <summary>
				///  <para>Standard priority of threads that are currently running a user interface that the user is interacting with. Applications can not normally change to this priority; the system will automatically adjust your application threads as the user moves through the UI. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_FOREGROUND
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_FOREGROUND", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_FOREGROUND = -2;
				/// <summary>
				///  <para>Standard priority of system display threads, involved in updating the user interface. Applications can not normally change to this priority. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_DISPLAY
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_DISPLAY", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_DISPLAY = -4;
				/// <summary>
				///  <para>Standard priority of the most important display threads, for compositing the screen and retrieving input events. Applications can not normally change to this priority. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_URGENT_DISPLAY
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_URGENT_DISPLAY", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_URGENT_DISPLAY = -8;
				/// <summary>
				///  <para>Standard priority of audio threads. Applications can not normally change to this priority. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_AUDIO
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_AUDIO", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_AUDIO = -16;
				/// <summary>
				///  <para>Standard priority of the most important audio threads. Applications can not normally change to this priority. Use with setThreadPriority(int) and setThreadPriority(int, int),  <b>not</b> with the normal java.lang.Thread class. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_URGENT_AUDIO
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_URGENT_AUDIO", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_URGENT_AUDIO = -19;
				/// <summary>
				///  <para>Minimum increment to make a priority more favorable. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_MORE_FAVORABLE
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_MORE_FAVORABLE", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_MORE_FAVORABLE = -1;
				/// <summary>
				///  <para>Minimum increment to make a priority less favorable. </para>        
				/// </summary>
				/// <java-name>
				/// THREAD_PRIORITY_LESS_FAVORABLE
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_LESS_FAVORABLE", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_LESS_FAVORABLE = 1;
				/// <java-name>
				/// SIGNAL_QUIT
				/// </java-name>
				[Dot42.DexImport("SIGNAL_QUIT", "I", AccessFlags = 25)]
				public const int SIGNAL_QUIT = 3;
				/// <java-name>
				/// SIGNAL_KILL
				/// </java-name>
				[Dot42.DexImport("SIGNAL_KILL", "I", AccessFlags = 25)]
				public const int SIGNAL_KILL = 9;
				/// <java-name>
				/// SIGNAL_USR1
				/// </java-name>
				[Dot42.DexImport("SIGNAL_USR1", "I", AccessFlags = 25)]
				public const int SIGNAL_USR1 = 10;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Process() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the identifier of this process, which can be used with killProcess and sendSignal. </para>        
				/// </summary>
				/// <java-name>
				/// myPid
				/// </java-name>
				[Dot42.DexImport("myPid", "()I", AccessFlags = 281)]
				public static int MyPid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the identifier of the calling thread, which be used with setThreadPriority(int, int). </para>        
				/// </summary>
				/// <java-name>
				/// myTid
				/// </java-name>
				[Dot42.DexImport("myTid", "()I", AccessFlags = 281)]
				public static int MyTid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the identifier of this process's uid. This is the kernel uid that the process is running under, which is the identity of its app-specific sandbox. It is different from myUserHandle in that a uid identifies a specific app sandbox in a specific user. </para>        
				/// </summary>
				/// <java-name>
				/// myUid
				/// </java-name>
				[Dot42.DexImport("myUid", "()I", AccessFlags = 281)]
				public static int MyUid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the UID assigned to a particular user name, or -1 if there is none. If the given string consists of only numbers, it is converted directly to a uid. </para>        
				/// </summary>
				/// <java-name>
				/// getUidForName
				/// </java-name>
				[Dot42.DexImport("getUidForName", "(Ljava/lang/String;)I", AccessFlags = 281)]
				public static int GetUidForName(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the GID assigned to a particular user name, or -1 if there is none. If the given string consists of only numbers, it is converted directly to a gid. </para>        
				/// </summary>
				/// <java-name>
				/// getGidForName
				/// </java-name>
				[Dot42.DexImport("getGidForName", "(Ljava/lang/String;)I", AccessFlags = 281)]
				public static int GetGidForName(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Set the priority of a thread, based on Linux priorities.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setThreadPriority
				/// </java-name>
				[Dot42.DexImport("setThreadPriority", "(II)V", AccessFlags = 281)]
				public static void SetThreadPriority(int tid, int priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the priority of the calling thread, based on Linux priorities. See setThreadPriority(int, int) for more information.</para> <para> <para>setThreadPriority(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setThreadPriority
				/// </java-name>
				[Dot42.DexImport("setThreadPriority", "(I)V", AccessFlags = 281)]
				public static void SetThreadPriority(int priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the current priority of a thread, based on Linux priorities.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current priority, as a Linux priority level, from -20 for highest scheduling priority to 19 for lowest scheduling priority.</para>
				/// </returns>
				/// <java-name>
				/// getThreadPriority
				/// </java-name>
				[Dot42.DexImport("getThreadPriority", "(I)I", AccessFlags = 281)]
				public static int GetThreadPriority(int tid) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Determine whether the current environment supports multiple processes.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method always returns true. Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the system can run in multiple processes, else false if everything is running in a single process.</para>
				/// </returns>
				/// <java-name>
				/// supportsProcesses
				/// </java-name>
				[Dot42.DexImport("supportsProcesses", "()Z", AccessFlags = 25)]
				public static bool SupportsProcesses() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Kill the process with the given PID. Note that, though this API allows us to request to kill any process based on its PID, the kernel will still impose standard restrictions on which PIDs you are actually able to kill. Typically this means only the process running the caller's packages/application and any additional processes created by that app; packages sharing a common UID will also be able to kill each other's processes. </para>        
				/// </summary>
				/// <java-name>
				/// killProcess
				/// </java-name>
				[Dot42.DexImport("killProcess", "(I)V", AccessFlags = 25)]
				public static void KillProcess(int pid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a signal to the given process.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendSignal
				/// </java-name>
				[Dot42.DexImport("sendSignal", "(II)V", AccessFlags = 281)]
				public static void SendSignal(int pid, int signal) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns elapsed milliseconds of the time this process has run. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the number of milliseconds this process has return. </para>
				/// </returns>
				/// <java-name>
				/// getElapsedCpuTime
				/// </java-name>
				public static long ElapsedCpuTime
				{
						[Dot42.DexImport("getElapsedCpuTime", "()J", AccessFlags = 281)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>RecoverySystem contains methods for interacting with the Android recovery system (the separate partition that can be used to install system updates, wipe user data, etc.) </para>    
		/// </summary>
		/// <java-name>
		/// android/os/RecoverySystem
		/// </java-name>
		[Dot42.DexImport("android/os/RecoverySystem", AccessFlags = 33)]
		public partial class RecoverySystem
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RecoverySystem() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Verify the cryptographic signature of a system update package before installing it. Note that the package is also verified separately by the installer once the device is rebooted into the recovery system. This function will return only if the package was successfully verified; otherwise it will throw an exception.</para> <para>Verification of a package can take significant time, so this function should not be called from a UI thread. Interrupting the thread while this function is in progress will result in a SecurityException being thrown (and the thread's interrupt flag will be cleared).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// verifyPackage
				/// </java-name>
				[Dot42.DexImport("verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V", AccessFlags = 9)]
				public static void VerifyPackage(global::Java.IO.File packageFile, global::Android.OS.RecoverySystem.IProgressListener listener, global::Java.IO.File deviceCertsZipFile) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reboots the device in order to install the given update package. Requires the android.Manifest.permission#REBOOT permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// installPackage
				/// </java-name>
				[Dot42.DexImport("installPackage", "(Landroid/content/Context;Ljava/io/File;)V", AccessFlags = 9)]
				public static void InstallPackage(global::Android.Content.Context context, global::Java.IO.File packageFile) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reboots the device and wipes the user data partition. This is sometimes called a "factory reset", which is something of a misnomer because the system partition is not restored to its factory state. Requires the android.Manifest.permission#REBOOT permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rebootWipeUserData
				/// </java-name>
				[Dot42.DexImport("rebootWipeUserData", "(Landroid/content/Context;)V", AccessFlags = 9)]
				public static void RebootWipeUserData(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reboot into the recovery system to wipe the /cache partition. </para>        
				/// </summary>
				/// <java-name>
				/// rebootWipeCache
				/// </java-name>
				[Dot42.DexImport("rebootWipeCache", "(Landroid/content/Context;)V", AccessFlags = 9)]
				public static void RebootWipeCache(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked regularly as verification proceeds. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/RecoverySystem$ProgressListener
				/// </java-name>
				[Dot42.DexImport("android/os/RecoverySystem$ProgressListener", AccessFlags = 1545)]
				public partial interface IProgressListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called periodically as the verification progresses.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onProgress
						/// </java-name>
						[Dot42.DexImport("onProgress", "(I)V", AccessFlags = 1025)]
						void OnProgress(int progress) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Takes care of the grunt work of maintaining a list of remote interfaces, typically for the use of performing callbacks from a android.app.Service to its clients. In particular, this:</para> <para> <ul> <li> <para>Keeps track of a set of registered IInterface callbacks, taking care to identify them through their underlying unique IBinder (by calling IInterface.asBinder(). </para></li> <li> <para>Attaches a IBinder.DeathRecipient to each registered interface, so that it can be cleaned out of the list if its process goes away. </para></li> <li> <para>Performs locking of the underlying list of interfaces to deal with multithreaded incoming calls, and a thread-safe way to iterate over a snapshot of the list without holding its lock. </para></li></ul></para> <para>To use this class, simply create a single instance along with your service, and call its register and unregister methods as client register and unregister with your service. To call back on to the registered clients, use beginBroadcast, getBroadcastItem, and finishBroadcast.</para> <para>If a registered callback's process goes away, this class will take care of automatically removing it from the list. If you want to do additional work in this situation, you can create a subclass that implements the onCallbackDied method. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/RemoteCallbackList
		/// </java-name>
		[Dot42.DexImport("android/os/RemoteCallbackList", AccessFlags = 33, Signature = "<E::Landroid/os/IInterface;>Ljava/lang/Object;")]
		public partial class RemoteCallbackList<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RemoteCallbackList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simple version of RemoteCallbackList#register(E, Object) that does not take a cookie object. </para>        
				/// </summary>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/os/IInterface;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Register(E callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Add a new callback to the list. This callback will remain in the list until a corresponding call to unregister or its hosting process goes away. If the callback was already registered (determined by checking to see if the callback.asBinder() object is already in the list), then it will be left as-is. Registrations are not counted; a single call to unregister will remove a callback after any number calls to register it.</para> <para> <para>unregister </para> <para>kill </para> <para>onCallbackDied </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the callback was successfully added to the list. Returns false if it was not added, either because kill had previously been called or the callback's process has gone away.</para>
				/// </returns>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;Ljava/lang/Object;)Z")]
				public virtual bool Register(E callback, object cookie) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Remove from the list a callback that was previously added with register. This uses the callback.asBinder() object to correctly find the previous registration. Registrations are not counted; a single unregister call will remove a callback after any number calls to register for it.</para> <para> <para>register </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the callback was found and unregistered. Returns false if the given callback was not found on the list.</para>
				/// </returns>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Landroid/os/IInterface;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Unregister(E callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Disable this callback list. All registered callbacks are unregistered, and the list is disabled so that future calls to register will fail. This should be used when a Service is stopping, to prevent clients from registering callbacks after it is stopped.</para> <para> <para>register </para></para>        
				/// </summary>
				/// <java-name>
				/// kill
				/// </java-name>
				[Dot42.DexImport("kill", "()V", AccessFlags = 1)]
				public virtual void Kill() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Old version of onCallbackDied(E, Object) that does not provide a cookie. </para>        
				/// </summary>
				/// <java-name>
				/// onCallbackDied
				/// </java-name>
				[Dot42.DexImport("onCallbackDied", "(Landroid/os/IInterface;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void OnCallbackDied(E callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the process hosting a callback in the list has gone away. The default implementation calls onCallbackDied(E) for backwards compatibility.</para> <para> <para>register </para></para>        
				/// </summary>
				/// <java-name>
				/// onCallbackDied
				/// </java-name>
				[Dot42.DexImport("onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;Ljava/lang/Object;)V")]
				public virtual void OnCallbackDied(E callback, object cookie) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepare to start making calls to the currently registered callbacks. This creates a copy of the callback list, which you can retrieve items from using getBroadcastItem. Note that only one broadcast can be active at a time, so you must be sure to always call this from the same thread (usually by scheduling with Handler) or do your own synchronization. You must call finishBroadcast when done.</para> <para>A typical loop delivering a broadcast looks like this:</para> <para> <pre>
				/// int i = callbacks.beginBroadcast();
				/// while (i &gt; 0) {
				///     i--;
				///     try {
				///         callbacks.getBroadcastItem(i).somethingHappened();
				///     } catch (RemoteException e) {
				///         // The RemoteCallbackList will take care of removing
				///         // the dead object for us.
				///     }
				/// }
				/// callbacks.finishBroadcast();</pre></para> <para> <para>getBroadcastItem </para> <para>finishBroadcast </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the number of callbacks in the broadcast, to be used with getBroadcastItem to determine the range of indices you can supply.</para>
				/// </returns>
				/// <java-name>
				/// beginBroadcast
				/// </java-name>
				[Dot42.DexImport("beginBroadcast", "()I", AccessFlags = 1)]
				public virtual int BeginBroadcast() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve an item in the active broadcast that was previously started with beginBroadcast. This can  <b>only</b> be called after the broadcast is started, and its data is no longer valid after calling finishBroadcast.</para> <para>Note that it is possible for the process of one of the returned callbacks to go away before you call it, so you will need to catch RemoteException when calling on to the returned object. The callback list itself, however, will take care of unregistering these objects once it detects that it is no longer valid, so you can handle such an exception by simply ignoring it.</para> <para> <para>beginBroadcast </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the callback interface that you can call. This will always be non-null.</para>
				/// </returns>
				/// <java-name>
				/// getBroadcastItem
				/// </java-name>
				[Dot42.DexImport("getBroadcastItem", "(I)Landroid/os/IInterface;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E GetBroadcastItem(int index) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Retrieve the cookie associated with the item returned by getBroadcastItem(int).</para> <para> <para>getBroadcastItem </para></para>        
				/// </summary>
				/// <java-name>
				/// getBroadcastCookie
				/// </java-name>
				[Dot42.DexImport("getBroadcastCookie", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetBroadcastCookie(int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Clean up the state of a broadcast previously initiated by calling beginBroadcast. This must always be called when you are done with a broadcast.</para> <para> <para>beginBroadcast </para></para>        
				/// </summary>
				/// <java-name>
				/// finishBroadcast
				/// </java-name>
				[Dot42.DexImport("finishBroadcast", "()V", AccessFlags = 1)]
				public virtual void FinishBroadcast() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Parent exception for all Binder remote-invocation errors </para>    
		/// </summary>
		/// <java-name>
		/// android/os/RemoteException
		/// </java-name>
		[Dot42.DexImport("android/os/RemoteException", AccessFlags = 33)]
		public partial class RemoteException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RemoteException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RemoteException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Generic interface for receiving a callback result from someone. Use this by creating a subclass and implement onReceiveResult, which you can then pass to others and send through IPC, and receive results they supply with send. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/ResultReceiver
		/// </java-name>
		[Dot42.DexImport("android/os/ResultReceiver", AccessFlags = 33)]
		public partial class ResultReceiver : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.ResultReceiver> CREATOR;
				/// <summary>
				///  <para>Create a new ResultReceive to receive results. Your onReceiveResult method will be called from the thread running  <b>handler</b> if given, or from an arbitrary thread if null. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public ResultReceiver(global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Deliver a result to this receiver. Will call onReceiveResult, always asynchronously if the receiver has supplied a Handler in which to dispatch the result. </para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void Send(int resultCode, global::Android.OS.Bundle resultData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to receive results delivered to this object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onReceiveResult
				/// </java-name>
				[Dot42.DexImport("onReceiveResult", "(ILandroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnReceiveResult(int resultCode, global::Android.OS.Bundle resultData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ResultReceiver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Retrieve overall information about the space on a filesystem. This is a wrapper for Unix statvfs(). </para>    
		/// </summary>
		/// <java-name>
		/// android/os/StatFs
		/// </java-name>
		[Dot42.DexImport("android/os/StatFs", AccessFlags = 33)]
		public partial class StatFs
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a new StatFs for looking at the stats of the filesystem at  <c>path </c> . Upon construction, the stat of the file system will be performed, and the values retrieved available from the methods on this class.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StatFs(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform a restat of the file system referenced by this object. This is the same as re-constructing the object with the same file system path, and the new stat values are available upon return. </para>        
				/// </summary>
				/// <java-name>
				/// restat
				/// </java-name>
				[Dot42.DexImport("restat", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Restat(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~StatFs() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal StatFs() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getBlockSizeLong() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getBlockSize
				/// </java-name>
				public virtual int BlockSize
				{
						[Dot42.DexImport("getBlockSize", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getBlockCountLong() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getBlockCount
				/// </java-name>
				public virtual int BlockCount
				{
						[Dot42.DexImport("getBlockCount", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getFreeBlocksLong() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getFreeBlocks
				/// </java-name>
				public virtual int FreeBlocks
				{
						[Dot42.DexImport("getFreeBlocks", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getAvailableBlocksLong() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getAvailableBlocks
				/// </java-name>
				public virtual int AvailableBlocks
				{
						[Dot42.DexImport("getAvailableBlocks", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>StrictMode is a developer tool which detects things you might be doing by accident and brings them to your attention so you can fix them.</para> <para>StrictMode is most commonly used to catch accidental disk or network access on the application's main thread, where UI operations are received and animations take place. Keeping disk and network operations off the main thread makes for much smoother, more responsive applications. By keeping your application's main thread responsive, you also prevent  from being shown to users.</para> <para>Note that even though an Android device's disk is often on flash memory, many devices run a filesystem on top of that memory with very limited concurrency. It's often the case that almost all disk accesses are fast, but may in individual cases be dramatically slower when certain I/O is happening in the background from other processes. If possible, it's best to assume that such things are not fast.</para> <para>Example code to enable from early in your android.app.Application, android.app.Activity, or other application component's android.app.Application#onCreate method:</para> <para> <pre>
		/// public void onCreate() {
		///     if (DEVELOPER_MODE) {
		///         StrictMode.setThreadPolicy(new  StrictMode.ThreadPolicy.Builder()
		///                 .detectDiskReads()
		///                 .detectDiskWrites()
		///                 .detectNetwork()   // or .detectAll() for all detectable problems
		///                 .penaltyLog()
		///                 .build());
		///         StrictMode.setVmPolicy(new  StrictMode.VmPolicy.Builder()
		///                 .detectLeakedSqlLiteObjects()
		///                 .detectLeakedClosableObjects()
		///                 .penaltyLog()
		///                 .penaltyDeath()
		///                 .build());
		///     }
		///     super.onCreate();
		/// }
		/// </pre></para> <para>You can decide what should happen when a violation is detected. For example, using ThreadPolicy.Builder#penaltyLog you can watch the output of  <code>adb logcat</code> while you use your application to see the violations as they happen.</para> <para>If you find violations that you feel are problematic, there are a variety of tools to help solve them: threads, android.os.Handler, android.os.AsyncTask, android.app.IntentService, etc. But don't feel compelled to fix everything that StrictMode finds. In particular, many cases of disk access are often necessary during the normal activity lifecycle. Use StrictMode to find things you did by accident. Network requests on the UI thread are almost always a problem, though.</para> <para>StrictMode is not a security mechanism and is not guaranteed to find all disk or network accesses. While it does propagate its state across process boundaries when doing android.os.Binder calls, it's still ultimately a best effort mechanism. Notably, disk or network access from JNI calls won't necessarily trigger it. Future versions of Android may catch more (or fewer) operations, so you should never leave StrictMode enabled in applications distributed on Google Play. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/StrictMode
		/// </java-name>
		[Dot42.DexImport("android/os/StrictMode", AccessFlags = 49)]
		public sealed partial class StrictMode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal StrictMode() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the policy for what actions on the current thread should be detected, as well as the penalty if such actions occur.</para> <para>Internally this sets a thread-local variable which is propagated across cross-process IPC calls, meaning you can catch violations when a system service or another process accesses the disk or network on your behalf.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setThreadPolicy
				/// </java-name>
				[Dot42.DexImport("setThreadPolicy", "(Landroid/os/StrictMode$ThreadPolicy;)V", AccessFlags = 9)]
				public static void SetThreadPolicy(global::Android.OS.StrictMode.ThreadPolicy policy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current thread's policy. </para>        
				/// </summary>
				/// <java-name>
				/// getThreadPolicy
				/// </java-name>
				[Dot42.DexImport("getThreadPolicy", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy GetThreadPolicy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <summary>
				///  <para>A convenience wrapper that takes the current ThreadPolicy from getThreadPolicy, modifies it to permit both disk reads &amp; writes, and sets the new policy with setThreadPolicy, returning the old policy so you can restore it at the end of a block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the old policy, to be passed to setThreadPolicy to restore the policy at the end of a block </para>
				/// </returns>
				/// <java-name>
				/// allowThreadDiskWrites
				/// </java-name>
				[Dot42.DexImport("allowThreadDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy AllowThreadDiskWrites() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <summary>
				///  <para>A convenience wrapper that takes the current ThreadPolicy from getThreadPolicy, modifies it to permit disk reads, and sets the new policy with setThreadPolicy, returning the old policy so you can restore it at the end of a block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the old policy, to be passed to setThreadPolicy to restore the policy. </para>
				/// </returns>
				/// <java-name>
				/// allowThreadDiskReads
				/// </java-name>
				[Dot42.DexImport("allowThreadDiskReads", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy AllowThreadDiskReads() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <summary>
				///  <para>Sets the policy for what actions in the VM process (on any thread) should be detected, as well as the penalty if such actions occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setVmPolicy
				/// </java-name>
				[Dot42.DexImport("setVmPolicy", "(Landroid/os/StrictMode$VmPolicy;)V", AccessFlags = 9)]
				public static void SetVmPolicy(global::Android.OS.StrictMode.VmPolicy policy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the current VM policy. </para>        
				/// </summary>
				/// <java-name>
				/// getVmPolicy
				/// </java-name>
				[Dot42.DexImport("getVmPolicy", "()Landroid/os/StrictMode$VmPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.VmPolicy GetVmPolicy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.VmPolicy);
				}

				/// <summary>
				///  <para>Enable the recommended StrictMode defaults, with violations just being logged.</para> <para>This catches disk and network access on the main thread, as well as leaked SQLite cursors and unclosed resources. This is simply a wrapper around setVmPolicy and setThreadPolicy. </para>        
				/// </summary>
				/// <java-name>
				/// enableDefaults
				/// </java-name>
				[Dot42.DexImport("enableDefaults", "()V", AccessFlags = 9)]
				public static void EnableDefaults() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For code to note that it's slow. This is a no-op unless the current thread's android.os.StrictMode.ThreadPolicy has android.os.StrictMode.ThreadPolicy.Builder#detectCustomSlowCalls enabled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// noteSlowCall
				/// </java-name>
				[Dot42.DexImport("noteSlowCall", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void NoteSlowCall(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>StrictMode policy applied to all threads in the virtual machine's process.</para> <para>The policy is enabled by setVmPolicy. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/StrictMode$VmPolicy
				/// </java-name>
				[Dot42.DexImport("android/os/StrictMode$VmPolicy", AccessFlags = 25)]
				public sealed partial class VmPolicy
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The default, lax policy which doesn't catch anything. </para>        
						/// </summary>
						/// <java-name>
						/// LAX
						/// </java-name>
						[Dot42.DexImport("LAX", "Landroid/os/StrictMode$VmPolicy;", AccessFlags = 25)]
						public static readonly VmPolicy LAX;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal VmPolicy() /* MethodBuilder.Create */ 
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

						/// <summary>
						///  <para>Creates VmPolicy instances. Methods whose names start with <c>detect </c> specify what problems we should look for. Methods whose names start with <c>penalty </c> specify what we should do when we detect a problem.</para> <para>You can call as many <c>detect </c> and <c>penalty </c> methods as you like. Currently order is insignificant: all penalties apply to all detected problems.</para> <para>For example, detect everything and log anything that's found:  <pre>
						/// StrictMode.VmPolicy policy = new StrictMode.VmPolicy.Builder()
						///     .detectAll()
						///     .penaltyLog()
						///     .build();
						/// StrictMode.setVmPolicy(policy);
						/// </pre> </para>    
						/// </summary>
						/// <java-name>
						/// android/os/StrictMode$VmPolicy$Builder
						/// </java-name>
						[Dot42.DexImport("android/os/StrictMode$VmPolicy$Builder", AccessFlags = 25)]
						public sealed partial class Builder
 /* scope: __dot42__ */ 
						{
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Builder() /* MethodBuilder.Create */ 
								{
								}

								[Dot42.DexImport("<init>", "(Landroid/os/StrictMode$VmPolicy;)V", AccessFlags = 1)]
								public Builder(global::Android.OS.StrictMode.VmPolicy vmPolicy) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Set an upper bound on how many instances of a class can be in memory at once. Helps to prevent object leaks. </para>        
								/// </summary>
								/// <java-name>
								/// setClassInstanceLimit
								/// </java-name>
								[Dot42.DexImport("setClassInstanceLimit", "(Ljava/lang/Class;I)Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder SetClassInstanceLimit(global::System.Type klass, int instanceLimit) /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Detect leaks of android.app.Activity subclasses. </para>        
								/// </summary>
								/// <java-name>
								/// detectActivityLeaks
								/// </java-name>
								[Dot42.DexImport("detectActivityLeaks", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectActivityLeaks() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Detect everything that's potentially suspect.</para> <para>In the Honeycomb release this includes leaks of SQLite cursors, Activities, and other closable objects but will likely expand in future releases. </para>        
								/// </summary>
								/// <java-name>
								/// detectAll
								/// </java-name>
								[Dot42.DexImport("detectAll", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Detect when an android.database.sqlite.SQLiteCursor or other SQLite object is finalized without having been closed.</para> <para>You always want to explicitly close your SQLite cursors to avoid unnecessary database contention and temporary memory leaks. </para>        
								/// </summary>
								/// <java-name>
								/// detectLeakedSqlLiteObjects
								/// </java-name>
								[Dot42.DexImport("detectLeakedSqlLiteObjects", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectLeakedSqlLiteObjects() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Detect when an java.io.Closeable or other object with a explict termination method is finalized without having been closed.</para> <para>You always want to explicitly close such objects to avoid unnecessary resources leaks. </para>        
								/// </summary>
								/// <java-name>
								/// detectLeakedClosableObjects
								/// </java-name>
								[Dot42.DexImport("detectLeakedClosableObjects", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectLeakedClosableObjects() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Detect when a BroadcastReceiver or ServiceConnection is leaked during Context teardown. </para>        
								/// </summary>
								/// <java-name>
								/// detectLeakedRegistrationObjects
								/// </java-name>
								[Dot42.DexImport("detectLeakedRegistrationObjects", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectLeakedRegistrationObjects() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Crashes the whole process on violation. This penalty runs at the end of all enabled penalties so yo you'll still get your logging or other violations before the process dies. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDeath
								/// </java-name>
								[Dot42.DexImport("penaltyDeath", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeath() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Log detected violations to the system log. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyLog
								/// </java-name>
								[Dot42.DexImport("penaltyLog", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyLog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detected violations log a stacktrace and timing data to the DropBox on policy violation. Intended mostly for platform integrators doing beta user field data collection. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDropBox
								/// </java-name>
								[Dot42.DexImport("penaltyDropBox", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDropBox() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Construct the VmPolicy instance.</para> <para>Note: if no penalties are enabled before calling  <code>build</code>, penaltyLog is implicitly set. </para>        
								/// </summary>
								/// <java-name>
								/// build
								/// </java-name>
								[Dot42.DexImport("build", "()Landroid/os/StrictMode$VmPolicy;", AccessFlags = 1)]
								public global::Android.OS.StrictMode.VmPolicy Build() /* MethodBuilder.Create */ 
								{
										return default(global::Android.OS.StrictMode.VmPolicy);
								}

						}

				}

				/// <summary>
				///  <para>StrictMode policy applied to a certain thread.</para> <para>The policy is enabled by setThreadPolicy. The current policy can be retrieved with getThreadPolicy.</para> <para>Note that multiple penalties may be provided and they're run in order from least to most severe (logging before process death, for example). There's currently no mechanism to choose different penalties for different detected actions. </para>    
				/// </summary>
				/// <java-name>
				/// android/os/StrictMode$ThreadPolicy
				/// </java-name>
				[Dot42.DexImport("android/os/StrictMode$ThreadPolicy", AccessFlags = 25)]
				public sealed partial class ThreadPolicy
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The default, lax policy which doesn't catch anything. </para>        
						/// </summary>
						/// <java-name>
						/// LAX
						/// </java-name>
						[Dot42.DexImport("LAX", "Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 25)]
						public static readonly ThreadPolicy LAX;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ThreadPolicy() /* MethodBuilder.Create */ 
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

						/// <summary>
						///  <para>Creates ThreadPolicy instances. Methods whose names start with <c>detect </c> specify what problems we should look for. Methods whose names start with <c>penalty </c> specify what we should do when we detect a problem.</para> <para>You can call as many <c>detect </c> and <c>penalty </c> methods as you like. Currently order is insignificant: all penalties apply to all detected problems.</para> <para>For example, detect everything and log anything that's found:  <pre>
						/// StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder()
						///     .detectAll()
						///     .penaltyLog()
						///     .build();
						/// StrictMode.setThreadPolicy(policy);
						/// </pre> </para>    
						/// </summary>
						/// <java-name>
						/// android/os/StrictMode$ThreadPolicy$Builder
						/// </java-name>
						[Dot42.DexImport("android/os/StrictMode$ThreadPolicy$Builder", AccessFlags = 25)]
						public sealed partial class Builder
 /* scope: __dot42__ */ 
						{
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Builder() /* MethodBuilder.Create */ 
								{
								}

								[Dot42.DexImport("<init>", "(Landroid/os/StrictMode$ThreadPolicy;)V", AccessFlags = 1)]
								public Builder(global::Android.OS.StrictMode.ThreadPolicy threadPolicy) /* MethodBuilder.Create */ 
								{
								}

								/// <summary>
								///  <para>Detect everything that's potentially suspect.</para> <para>As of the Gingerbread release this includes network and disk operations but will likely expand in future releases. </para>        
								/// </summary>
								/// <java-name>
								/// detectAll
								/// </java-name>
								[Dot42.DexImport("detectAll", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Disable the detection of everything. </para>        
								/// </summary>
								/// <java-name>
								/// permitAll
								/// </java-name>
								[Dot42.DexImport("permitAll", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detection of network operations. </para>        
								/// </summary>
								/// <java-name>
								/// detectNetwork
								/// </java-name>
								[Dot42.DexImport("detectNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Disable detection of network operations. </para>        
								/// </summary>
								/// <java-name>
								/// permitNetwork
								/// </java-name>
								[Dot42.DexImport("permitNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detection of disk reads. </para>        
								/// </summary>
								/// <java-name>
								/// detectDiskReads
								/// </java-name>
								[Dot42.DexImport("detectDiskReads", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectDiskReads() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Disable detection of disk reads. </para>        
								/// </summary>
								/// <java-name>
								/// permitDiskReads
								/// </java-name>
								[Dot42.DexImport("permitDiskReads", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitDiskReads() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detection of slow calls. </para>        
								/// </summary>
								/// <java-name>
								/// detectCustomSlowCalls
								/// </java-name>
								[Dot42.DexImport("detectCustomSlowCalls", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectCustomSlowCalls() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Disable detection of slow calls. </para>        
								/// </summary>
								/// <java-name>
								/// permitCustomSlowCalls
								/// </java-name>
								[Dot42.DexImport("permitCustomSlowCalls", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitCustomSlowCalls() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detection of disk writes. </para>        
								/// </summary>
								/// <java-name>
								/// detectDiskWrites
								/// </java-name>
								[Dot42.DexImport("detectDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectDiskWrites() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Disable detection of disk writes. </para>        
								/// </summary>
								/// <java-name>
								/// permitDiskWrites
								/// </java-name>
								[Dot42.DexImport("permitDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitDiskWrites() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Show an annoying dialog to the developer on detected violations, rate-limited to be only a little annoying. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDialog
								/// </java-name>
								[Dot42.DexImport("penaltyDialog", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDialog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Crash the whole process on violation. This penalty runs at the end of all enabled penalties so you'll still get see logging or other violations before the process dies.</para> <para>Unlike penaltyDeathOnNetwork, this applies to disk reads, disk writes, and network usage if their corresponding detect flags are set. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDeath
								/// </java-name>
								[Dot42.DexImport("penaltyDeath", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeath() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Crash the whole process on any network usage. Unlike penaltyDeath, this penalty runs  <b>before</b> anything else. You must still have called detectNetwork to enable this.</para> <para>In the Honeycomb or later SDKs, this is on by default. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDeathOnNetwork
								/// </java-name>
								[Dot42.DexImport("penaltyDeathOnNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeathOnNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Flash the screen during a violation. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyFlashScreen
								/// </java-name>
								[Dot42.DexImport("penaltyFlashScreen", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyFlashScreen() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Log detected violations to the system log. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyLog
								/// </java-name>
								[Dot42.DexImport("penaltyLog", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyLog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Enable detected violations log a stacktrace and timing data to the DropBox on policy violation. Intended mostly for platform integrators doing beta user field data collection. </para>        
								/// </summary>
								/// <java-name>
								/// penaltyDropBox
								/// </java-name>
								[Dot42.DexImport("penaltyDropBox", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDropBox() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <summary>
								///  <para>Construct the ThreadPolicy instance.</para> <para>Note: if no penalties are enabled before calling  <code>build</code>, penaltyLog is implicitly set. </para>        
								/// </summary>
								/// <java-name>
								/// build
								/// </java-name>
								[Dot42.DexImport("build", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 1)]
								public global::Android.OS.StrictMode.ThreadPolicy Build() /* MethodBuilder.Create */ 
								{
										return default(global::Android.OS.StrictMode.ThreadPolicy);
								}

						}

				}

		}

		/// <summary>
		///  <para>Core timekeeping facilities.</para> <para>Three different clocks are available, and they should not be confused:</para> <para> <ul> <li> <para></para> <para>System.currentTimeMillis() is the standard "wall" clock (time and date) expressing milliseconds since the epoch. The wall clock can be set by the user or the phone network (see setCurrentTimeMillis), so the time may jump backwards or forwards unpredictably. This clock should only be used when correspondence with real-world dates and times is important, such as in a calendar or alarm clock application. Interval or elapsed time measurements should use a different clock. If you are using System.currentTimeMillis(), consider listening to the ACTION_TIME_TICK, ACTION_TIME_CHANGED and ACTION_TIMEZONE_CHANGED Intent broadcasts to find out when the time changes.</para> <para></para></li> <li> <para></para> <para>uptimeMillis is counted in milliseconds since the system was booted. This clock stops when the system enters deep sleep (CPU off, display dark, device waiting for external input), but is not affected by clock scaling, idle, or other power saving mechanisms. This is the basis for most interval timing such as Thread.sleep(millls), Object.wait(millis), and System.nanoTime(). This clock is guaranteed to be monotonic, and is suitable for interval timing when the interval does not span device sleep. Most methods that accept a timestamp value currently expect the uptimeMillis clock.</para> <para></para></li> <li> <para></para> <para>elapsedRealtime and elapsedRealtimeNanos return the time since the system was booted, and include deep sleep. This clock is guaranteed to be monotonic, and continues to tick even when the CPU is in power saving modes, so is the recommend basis for general purpose interval timing.</para> <para></para></li></ul></para> <para>There are several mechanisms for controlling the timing of events:</para> <para> <ul> <li> <para></para> <para>Standard functions like Thread.sleep(millis) and Object.wait(millis) are always available. These functions use the uptimeMillis clock; if the device enters sleep, the remainder of the time will be postponed until the device wakes up. These synchronous functions may be interrupted with Thread.interrupt(), and you must handle InterruptedException.</para> <para></para></li> <li> <para></para> <para>SystemClock.sleep(millis) is a utility function very similar to Thread.sleep(millis), but it ignores InterruptedException. Use this function for delays if you do not use Thread.interrupt(), as it will preserve the interrupted state of the thread.</para> <para></para></li> <li> <para></para> <para>The android.os.Handler class can schedule asynchronous callbacks at an absolute or relative time. Handler objects also use the uptimeMillis clock, and require an event loop (normally present in any GUI application).</para> <para></para></li> <li> <para></para> <para>The android.app.AlarmManager can trigger one-time or recurring events which occur even when the device is in deep sleep or your application is not running. Events may be scheduled with your choice of java.lang.System#currentTimeMillis (RTC) or elapsedRealtime (ELAPSED_REALTIME), and cause an android.content.Intent broadcast when they occur. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/os/SystemClock
		/// </java-name>
		[Dot42.DexImport("android/os/SystemClock", AccessFlags = 49)]
		public sealed partial class SystemClock
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This class is uninstantiable. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SystemClock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Waits a given number of milliseconds (of uptimeMillis) before returning. Similar to java.lang.Thread#sleep(long), but does not throw InterruptedException; Thread#interrupt() events are deferred until the next interruptible operation. Does not return until at least the specified number of milliseconds has elapsed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sleep
				/// </java-name>
				[Dot42.DexImport("sleep", "(J)V", AccessFlags = 9)]
				public static void Sleep(long ms) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current wall time, in milliseconds. Requires the calling process to have appropriate permissions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>if the clock was successfully set to the specified time. </para>
				/// </returns>
				/// <java-name>
				/// setCurrentTimeMillis
				/// </java-name>
				[Dot42.DexImport("setCurrentTimeMillis", "(J)Z", AccessFlags = 265)]
				public static bool SetCurrentTimeMillis(long millis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns milliseconds since boot, not counting time spent in deep sleep.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>milliseconds of non-sleep uptime since boot. </para>
				/// </returns>
				/// <java-name>
				/// uptimeMillis
				/// </java-name>
				[Dot42.DexImport("uptimeMillis", "()J", AccessFlags = 265)]
				public static long UptimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns milliseconds since boot, including time spent in sleep.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>elapsed milliseconds since boot. </para>
				/// </returns>
				/// <java-name>
				/// elapsedRealtime
				/// </java-name>
				[Dot42.DexImport("elapsedRealtime", "()J", AccessFlags = 265)]
				public static long ElapsedRealtime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns milliseconds running in the current thread.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>elapsed milliseconds in the thread </para>
				/// </returns>
				/// <java-name>
				/// currentThreadTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentThreadTimeMillis", "()J", AccessFlags = 265)]
				public static long CurrentThreadTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		///  <para>Helper class that helps you use IBinder objects as reference counted tokens. IBinders make good tokens because we find out when they are removed </para>    
		/// </summary>
		/// <java-name>
		/// android/os/TokenWatcher
		/// </java-name>
		[Dot42.DexImport("android/os/TokenWatcher", AccessFlags = 1057)]
		public abstract partial class TokenWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct the TokenWatcher</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;Ljava/lang/String;)V", AccessFlags = 1)]
				public TokenWatcher(global::Android.OS.Handler h, string tag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the number of active tokens goes from 0 to 1. </para>        
				/// </summary>
				/// <java-name>
				/// acquired
				/// </java-name>
				[Dot42.DexImport("acquired", "()V", AccessFlags = 1025)]
				public abstract void Acquired() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when the number of active tokens goes from 1 to 0. </para>        
				/// </summary>
				/// <java-name>
				/// released
				/// </java-name>
				[Dot42.DexImport("released", "()V", AccessFlags = 1025)]
				public abstract void Released() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Record that this token has been acquired. When acquire is called, and the current count is 0, the acquired method is called on the given handler.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Acquire(global::Android.OS.IBinder token, string tag) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cleanup
				/// </java-name>
				[Dot42.DexImport("cleanup", "(Landroid/os/IBinder;Z)V", AccessFlags = 1)]
				public virtual void Cleanup(global::Android.OS.IBinder token, bool unlink) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void Release(global::Android.OS.IBinder token) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "()V", AccessFlags = 1)]
				public virtual void Dump() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public virtual void Dump(global::Java.IO.PrintWriter pw) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TokenWatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isAcquired
				/// </java-name>
				public virtual bool IsAcquired
				{
						[Dot42.DexImport("isAcquired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>The Binder transaction failed because it was too large. </para> <para>During a remote procedure call, the arguments and the return value of the call are transferred as Parcel objects stored in the Binder transaction buffer. If the arguments or the return value are too large to fit in the transaction buffer, then the call will fail and TransactionTooLargeException will be thrown. </para> <para>The Binder transaction buffer has a limited fixed size, currently 1Mb, which is shared by all transactions in progress for the process. Consequently this exception can be thrown when there are many transactions in progress even when most of the individual transactions are of moderate size. </para> <para>There are two possible outcomes when a remote procedure call throws TransactionTooLargeException. Either the client was unable to send its request to the service (most likely if the arguments were too large to fit in the transaction buffer), or the service was unable to send its response back to the client (most likely if the return value was too large to fit in the transaction buffer). It is not possible to tell which of these outcomes actually occurred. The client should assume that a partial failure occurred. </para> <para>The key to avoiding TransactionTooLargeException is to keep all transactions relatively small. Try to minimize the amount of memory needed to create a Parcel for the arguments and the return value of the remote procedure call. Avoid transferring huge arrays of strings or large bitmaps. If possible, try to break up big requests into smaller pieces. </para> <para>If you are implementing a service, it may help to impose size or complexity contraints on the queries that clients can perform. For example, if the result set could become large, then don't allow the client to request more than a few records at a time. Alternately, instead of returning all of the available data all at once, return the essential information first and make the client ask for additional information later as needed. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/TransactionTooLargeException
		/// </java-name>
		[Dot42.DexImport("android/os/TransactionTooLargeException", AccessFlags = 33)]
		public partial class TransactionTooLargeException : global::Android.OS.RemoteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransactionTooLargeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class that operates the vibrator on the device. </para> <para>If your process exits, any vibration you started with will stop. </para> <para>To obtain an instance of the system vibrator, call Context#getSystemService with Context#VIBRATOR_SERVICE as argument. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/Vibrator
		/// </java-name>
		[Dot42.DexImport("android/os/Vibrator", AccessFlags = 1057)]
		public abstract partial class Vibrator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>to prevent subclassing from outside of the framework </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Vibrator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Vibrate constantly for the specified period of time. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#VIBRATE.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "(J)V", AccessFlags = 1025)]
				public abstract void Vibrate(long milliseconds) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Vibrate with a given pattern.</para> <para>Pass in an array of ints that are the durations for which to turn on or off the vibrator in milliseconds. The first value indicates the number of milliseconds to wait before turning the vibrator on. The next value indicates the number of milliseconds for which to keep the vibrator on before turning it off. Subsequent values alternate between durations in milliseconds to turn the vibrator off or to turn the vibrator on. </para> <para>To cause the pattern to repeat, pass the index into the pattern array at which to start the repeat, or -1 to disable repeating. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#VIBRATE.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "([JI)V", AccessFlags = 1025)]
				public abstract void Vibrate(long[] pattern, int repeat) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Turn the vibrator off. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#VIBRATE. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				public abstract void Cancel() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Check whether the hardware has a vibrator.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the hardware has a vibrator, else false. </para>
				/// </returns>
				/// <java-name>
				/// hasVibrator
				/// </java-name>
				public abstract bool HasVibrator
				{
						[Dot42.DexImport("hasVibrator", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Describes the source of some work that may be done by someone else. Currently the public representation of what a work source is is not defined; this is an opaque container. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/WorkSource
		/// </java-name>
		[Dot42.DexImport("android/os/WorkSource", AccessFlags = 33)]
		public partial class WorkSource : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.OS.WorkSource> CREATOR;
				/// <summary>
				///  <para>Create an empty work source. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WorkSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new WorkSource that is a copy of an existing one. If  <b>orig</b> is null, an empty WorkSource is created. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
				public WorkSource(global::Android.OS.WorkSource orig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear this WorkSource to be empty. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compare this WorkSource with another. </para>        
				/// </summary>
				/// <returns>
				///  <para>If there is a difference, true is returned. </para>
				/// </returns>
				/// <java-name>
				/// diff
				/// </java-name>
				[Dot42.DexImport("diff", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Diff(global::Android.OS.WorkSource other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Replace the current contents of this work source with the given work source. If  <b>other</b> is null, the current work source will be made empty. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.OS.WorkSource other) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Merge the contents of  <b>other</b> WorkSource in to this one.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if any new sources were added. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Add(global::Android.OS.WorkSource other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Android.OS.WorkSource other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

}

