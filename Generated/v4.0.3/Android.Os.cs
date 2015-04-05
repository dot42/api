#pragma warning disable 1717
namespace Android.OS
{
		/// <java-name>
		/// android/os/AsyncTask
		/// </java-name>
		[Dot42.DexImport("android/os/AsyncTask", AccessFlags = 1057, Signature = "<Params:Ljava/lang/Object;Progress:Ljava/lang/Object;Result:Ljava/lang/Object;>Lj" +
    "ava/lang/Object;")]
		public abstract partial class AsyncTask<Params, Progress, Result>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// THREAD_POOL_EXECUTOR
				/// </java-name>
				[Dot42.DexImport("THREAD_POOL_EXECUTOR", "Ljava/util/concurrent/Executor;", AccessFlags = 25)]
				public static readonly global::Java.Util.Concurrent.IExecutor THREAD_POOL_EXECUTOR;
				/// <java-name>
				/// SERIAL_EXECUTOR
				/// </java-name>
				[Dot42.DexImport("SERIAL_EXECUTOR", "Ljava/util/concurrent/Executor;", AccessFlags = 25)]
				public static readonly global::Java.Util.Concurrent.IExecutor SERIAL_EXECUTOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AsyncTask() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()Landroid/os/AsyncTask$Status;", AccessFlags = 17)]
				public global::Android.OS.AsyncTask<Params, Progress, Result>.Status GetStatus() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.AsyncTask<Params, Progress, Result>.Status);
				}

				/// <java-name>
				/// doInBackground
				/// </java-name>
				[Dot42.DexImport("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1156, Signature = "([TParams;)TResult;")]
				protected internal abstract Result DoInBackground(params Params[] p) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onPreExecute
				/// </java-name>
				[Dot42.DexImport("onPreExecute", "()V", AccessFlags = 4)]
				protected internal virtual void OnPreExecute() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPostExecute
				/// </java-name>
				[Dot42.DexImport("onPostExecute", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TResult;)V")]
				protected internal virtual void OnPostExecute(Result result) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onProgressUpdate
				/// </java-name>
				[Dot42.DexImport("onProgressUpdate", "([Ljava/lang/Object;)V", AccessFlags = 132, Signature = "([TProgress;)V")]
				protected internal virtual void OnProgressUpdate(params Progress[] p) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCancelled
				/// </java-name>
				[Dot42.DexImport("onCancelled", "(Ljava/lang/Object;)V", AccessFlags = 4, Signature = "(TResult;)V")]
				protected internal virtual void OnCancelled(Result result) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCancelled
				/// </java-name>
				[Dot42.DexImport("onCancelled", "()V", AccessFlags = 4)]
				protected internal virtual void OnCancelled() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 17)]
				public bool Cancel(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 17, Signature = "()TResult;")]
				public Result Get() /* MethodBuilder.Create */ 
				{
						return default(Result);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 17, Signature = "(JLjava/util/concurrent/TimeUnit;)TResult;")]
				public Result Get(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// executeOnExecutor
				/// </java-name>
				[Dot42.DexImport("executeOnExecutor", "(Ljava/util/concurrent/Executor;[Ljava/lang/Object;)Landroid/os/AsyncTask;", AccessFlags = 145, Signature = "(Ljava/util/concurrent/Executor;[TParams;)Landroid/os/AsyncTask<TParams;TProgress" +
    ";TResult;>;")]
				public global::Android.OS.AsyncTask<Params, Progress, Result> ExecuteOnExecutor(global::Java.Util.Concurrent.IExecutor executor, params Params[] p) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// publishProgress
				/// </java-name>
				[Dot42.DexImport("publishProgress", "([Ljava/lang/Object;)V", AccessFlags = 148, Signature = "([TProgress;)V")]
				protected internal void PublishProgress(params Progress[] p) /* MethodBuilder.Create */ 
				{
				}

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
				internal BadParcelableException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/os/BatteryManager
		/// </java-name>
		[Dot42.DexImport("android/os/BatteryManager", AccessFlags = 33)]
		public partial class BatteryManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_STATUS
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATUS = "status";
				/// <java-name>
				/// EXTRA_HEALTH
				/// </java-name>
				[Dot42.DexImport("EXTRA_HEALTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_HEALTH = "health";
				/// <java-name>
				/// EXTRA_PRESENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_PRESENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PRESENT = "present";
				/// <java-name>
				/// EXTRA_LEVEL
				/// </java-name>
				[Dot42.DexImport("EXTRA_LEVEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LEVEL = "level";
				/// <java-name>
				/// EXTRA_SCALE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCALE = "scale";
				/// <java-name>
				/// EXTRA_ICON_SMALL
				/// </java-name>
				[Dot42.DexImport("EXTRA_ICON_SMALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ICON_SMALL = "icon-small";
				/// <java-name>
				/// EXTRA_PLUGGED
				/// </java-name>
				[Dot42.DexImport("EXTRA_PLUGGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PLUGGED = "plugged";
				/// <java-name>
				/// EXTRA_VOLTAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOLTAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOLTAGE = "voltage";
				/// <java-name>
				/// EXTRA_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEMPERATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEMPERATURE = "temperature";
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
				/// <java-name>
				/// BATTERY_PLUGGED_AC
				/// </java-name>
				[Dot42.DexImport("BATTERY_PLUGGED_AC", "I", AccessFlags = 25)]
				public const int BATTERY_PLUGGED_AC = 1;
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

		/// <java-name>
		/// android/os/Binder
		/// </java-name>
		[Dot42.DexImport("android/os/Binder", AccessFlags = 33)]
		public partial class Binder : global::Android.OS.IBinder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Binder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCallingIdentity
				/// </java-name>
				[Dot42.DexImport("clearCallingIdentity", "()J", AccessFlags = 281)]
				public static long ClearCallingIdentity() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// restoreCallingIdentity
				/// </java-name>
				[Dot42.DexImport("restoreCallingIdentity", "(J)V", AccessFlags = 281)]
				public static void RestoreCallingIdentity(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flushPendingCommands
				/// </java-name>
				[Dot42.DexImport("flushPendingCommands", "()V", AccessFlags = 281)]
				public static void FlushPendingCommands() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// joinThreadPool
				/// </java-name>
				[Dot42.DexImport("joinThreadPool", "()V", AccessFlags = 281)]
				public static void JoinThreadPool() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachInterface
				/// </java-name>
				[Dot42.DexImport("attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AttachInterface(global::Android.OS.IInterface @interface, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pingBinder
				/// </java-name>
				[Dot42.DexImport("pingBinder", "()Z", AccessFlags = 1)]
				public virtual bool PingBinder() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queryLocalInterface
				/// </java-name>
				[Dot42.DexImport("queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", AccessFlags = 1)]
				public virtual global::Android.OS.IInterface QueryLocalInterface(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IInterface);
				}

				/// <java-name>
				/// onTransact
				/// </java-name>
				[Dot42.DexImport("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 4)]
				protected internal virtual bool OnTransact(int int32, global::Android.OS.Parcel parcel, global::Android.OS.Parcel parcel1, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Java.Io.FileDescriptor fileDescriptor, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpAsync
				/// </java-name>
				[Dot42.DexImport("dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void DumpAsync(global::Java.Io.FileDescriptor fileDescriptor, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void Dump(global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transact
				/// </java-name>
				[Dot42.DexImport("transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 17)]
				public bool Transact(int int32, global::Android.OS.Parcel parcel, global::Android.OS.Parcel parcel1, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// linkToDeath
				/// </java-name>
				[Dot42.DexImport("linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", AccessFlags = 1)]
				public virtual void LinkToDeath(global::Android.OS.IBinder_IDeathRecipient binder_IDeathRecipient, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unlinkToDeath
				/// </java-name>
				[Dot42.DexImport("unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", AccessFlags = 1)]
				public virtual bool UnlinkToDeath(global::Android.OS.IBinder_IDeathRecipient binder_IDeathRecipient, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Binder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCallingPid
				/// </java-name>
				public static int CallingPid
				{
						[Dot42.DexImport("getCallingPid", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCallingUid
				/// </java-name>
				public static int CallingUid
				{
						[Dot42.DexImport("getCallingUid", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getInterfaceDescriptor
				/// </java-name>
				public virtual string InterfaceDescriptor
				{
						[Dot42.DexImport("getInterfaceDescriptor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isBinderAlive
				/// </java-name>
				public virtual bool IsBinderAlive
				{
						[Dot42.DexImport("isBinderAlive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/os/Build
		/// </java-name>
		[Dot42.DexImport("android/os/Build", AccessFlags = 33)]
		public partial class Build
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNKNOWN
				/// </java-name>
				[Dot42.DexImport("UNKNOWN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNKNOWN = "unknown";
				/// <java-name>
				/// ID
				/// </java-name>
				[Dot42.DexImport("ID", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ID;
				/// <java-name>
				/// DISPLAY
				/// </java-name>
				[Dot42.DexImport("DISPLAY", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DISPLAY;
				/// <java-name>
				/// PRODUCT
				/// </java-name>
				[Dot42.DexImport("PRODUCT", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string PRODUCT;
				/// <java-name>
				/// DEVICE
				/// </java-name>
				[Dot42.DexImport("DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string DEVICE;
				/// <java-name>
				/// BOARD
				/// </java-name>
				[Dot42.DexImport("BOARD", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BOARD;
				/// <java-name>
				/// CPU_ABI
				/// </java-name>
				[Dot42.DexImport("CPU_ABI", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string CPU_ABI;
				/// <java-name>
				/// CPU_ABI2
				/// </java-name>
				[Dot42.DexImport("CPU_ABI2", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string CPU_ABI2;
				/// <java-name>
				/// MANUFACTURER
				/// </java-name>
				[Dot42.DexImport("MANUFACTURER", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string MANUFACTURER;
				/// <java-name>
				/// BRAND
				/// </java-name>
				[Dot42.DexImport("BRAND", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BRAND;
				/// <java-name>
				/// MODEL
				/// </java-name>
				[Dot42.DexImport("MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string MODEL;
				/// <java-name>
				/// BOOTLOADER
				/// </java-name>
				[Dot42.DexImport("BOOTLOADER", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string BOOTLOADER;
				/// <java-name>
				/// RADIO
				/// </java-name>
				[Dot42.DexImport("RADIO", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string RADIO;
				/// <java-name>
				/// HARDWARE
				/// </java-name>
				[Dot42.DexImport("HARDWARE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string HARDWARE;
				/// <java-name>
				/// SERIAL
				/// </java-name>
				[Dot42.DexImport("SERIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string SERIAL;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string TYPE;
				/// <java-name>
				/// TAGS
				/// </java-name>
				[Dot42.DexImport("TAGS", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string TAGS;
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

				/// <java-name>
				/// getRadioVersion
				/// </java-name>
				public static string RadioVersion
				{
						[Dot42.DexImport("getRadioVersion", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/os/Build$VERSION_CODES
				/// </java-name>
				[Dot42.DexImport("android/os/Build$VERSION_CODES", AccessFlags = 9)]
				public partial class VERSION_CODES
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CUR_DEVELOPMENT
						/// </java-name>
						[Dot42.DexImport("CUR_DEVELOPMENT", "I", AccessFlags = 25)]
						public const int CUR_DEVELOPMENT = 10000;
						/// <java-name>
						/// BASE
						/// </java-name>
						[Dot42.DexImport("BASE", "I", AccessFlags = 25)]
						public const int BASE = 1;
						/// <java-name>
						/// BASE_1_1
						/// </java-name>
						[Dot42.DexImport("BASE_1_1", "I", AccessFlags = 25)]
						public const int BASE_1_1 = 2;
						/// <java-name>
						/// CUPCAKE
						/// </java-name>
						[Dot42.DexImport("CUPCAKE", "I", AccessFlags = 25)]
						public const int CUPCAKE = 3;
						/// <java-name>
						/// DONUT
						/// </java-name>
						[Dot42.DexImport("DONUT", "I", AccessFlags = 25)]
						public const int DONUT = 4;
						/// <java-name>
						/// ECLAIR
						/// </java-name>
						[Dot42.DexImport("ECLAIR", "I", AccessFlags = 25)]
						public const int ECLAIR = 5;
						/// <java-name>
						/// ECLAIR_0_1
						/// </java-name>
						[Dot42.DexImport("ECLAIR_0_1", "I", AccessFlags = 25)]
						public const int ECLAIR_0_1 = 6;
						/// <java-name>
						/// ECLAIR_MR1
						/// </java-name>
						[Dot42.DexImport("ECLAIR_MR1", "I", AccessFlags = 25)]
						public const int ECLAIR_MR1 = 7;
						/// <java-name>
						/// FROYO
						/// </java-name>
						[Dot42.DexImport("FROYO", "I", AccessFlags = 25)]
						public const int FROYO = 8;
						/// <java-name>
						/// GINGERBREAD
						/// </java-name>
						[Dot42.DexImport("GINGERBREAD", "I", AccessFlags = 25)]
						public const int GINGERBREAD = 9;
						/// <java-name>
						/// GINGERBREAD_MR1
						/// </java-name>
						[Dot42.DexImport("GINGERBREAD_MR1", "I", AccessFlags = 25)]
						public const int GINGERBREAD_MR1 = 10;
						/// <java-name>
						/// HONEYCOMB
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB", "I", AccessFlags = 25)]
						public const int HONEYCOMB = 11;
						/// <java-name>
						/// HONEYCOMB_MR1
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB_MR1", "I", AccessFlags = 25)]
						public const int HONEYCOMB_MR1 = 12;
						/// <java-name>
						/// HONEYCOMB_MR2
						/// </java-name>
						[Dot42.DexImport("HONEYCOMB_MR2", "I", AccessFlags = 25)]
						public const int HONEYCOMB_MR2 = 13;
						/// <java-name>
						/// ICE_CREAM_SANDWICH
						/// </java-name>
						[Dot42.DexImport("ICE_CREAM_SANDWICH", "I", AccessFlags = 25)]
						public const int ICE_CREAM_SANDWICH = 14;
						/// <java-name>
						/// ICE_CREAM_SANDWICH_MR1
						/// </java-name>
						[Dot42.DexImport("ICE_CREAM_SANDWICH_MR1", "I", AccessFlags = 25)]
						public const int ICE_CREAM_SANDWICH_MR1 = 15;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public VERSION_CODES() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/os/Build$VERSION
				/// </java-name>
				[Dot42.DexImport("android/os/Build$VERSION", AccessFlags = 9)]
				public partial class VERSION
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// INCREMENTAL
						/// </java-name>
						[Dot42.DexImport("INCREMENTAL", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string INCREMENTAL;
						/// <java-name>
						/// RELEASE
						/// </java-name>
						[Dot42.DexImport("RELEASE", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string RELEASE;
						/// <java-name>
						/// SDK
						/// </java-name>
						[Dot42.DexImport("SDK", "Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string SDK;
						/// <java-name>
						/// SDK_INT
						/// </java-name>
						[Dot42.DexImport("SDK_INT", "I", AccessFlags = 25)]
						public static readonly int SDK_INT;
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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Bundle() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public Bundle(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Bundle(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public Bundle(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Remove(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void PutAll(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public void PutBoolean(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByte
				/// </java-name>
				[Dot42.DexImport("putByte", "(Ljava/lang/String;B)V", AccessFlags = 1)]
				public void PutByte(string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByte
				/// </java-name>
				[Dot42.DexImport("putByte", "(Ljava/lang/String;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void PutByte(string @string, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(Ljava/lang/String;C)V", AccessFlags = 1)]
				public void PutChar(string @string, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(Ljava/lang/String;S)V", AccessFlags = 1)]
				public void PutShort(string @string, short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void PutInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public void PutLong(string @string, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)V", AccessFlags = 1)]
				public void PutFloat(string @string, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(Ljava/lang/String;D)V", AccessFlags = 1)]
				public void PutDouble(string @string, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutString(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putCharSequence
				/// </java-name>
				[Dot42.DexImport("putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void PutCharSequence(string @string, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putParcelable
				/// </java-name>
				[Dot42.DexImport("putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public void PutParcelable(string @string, global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putParcelableArray
				/// </java-name>
				[Dot42.DexImport("putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public void PutParcelableArray(string @string, global::Android.OS.IParcelable[] parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putParcelableArrayList
				/// </java-name>
				[Dot42.DexImport("putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<+Landroid/os/Parcelable;>;)V")]
				public void PutParcelableArrayList(string @string, global::Java.Util.ArrayList<global::Android.OS.IParcelable> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putSparseParcelableArray
				/// </java-name>
				[Dot42.DexImport("putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/util/SparseArray<+Landroid/os/Parcelable;>;)V")]
				public void PutSparseParcelableArray(string @string, global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putIntegerArrayList
				/// </java-name>
				[Dot42.DexImport("putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/Integer;>;)V")]
				public void PutIntegerArrayList(string @string, global::Java.Util.ArrayList<int?> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putStringArrayList
				/// </java-name>
				[Dot42.DexImport("putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;)V")]
				public void PutStringArrayList(string @string, global::Java.Util.ArrayList<string> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putCharSequenceArrayList
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/CharSequence;>;)V")]
				public void PutCharSequenceArrayList(string @string, global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putSerializable
				/// </java-name>
				[Dot42.DexImport("putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V", AccessFlags = 1)]
				public void PutSerializable(string @string, global::Java.Io.ISerializable serializable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putBooleanArray
				/// </java-name>
				[Dot42.DexImport("putBooleanArray", "(Ljava/lang/String;[Z)V", AccessFlags = 1)]
				public void PutBooleanArray(string @string, bool[] boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public void PutByteArray(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putByteArray
				/// </java-name>
				[Dot42.DexImport("putByteArray", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void PutByteArray(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putShortArray
				/// </java-name>
				[Dot42.DexImport("putShortArray", "(Ljava/lang/String;[S)V", AccessFlags = 1)]
				public void PutShortArray(string @string, short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putCharArray
				/// </java-name>
				[Dot42.DexImport("putCharArray", "(Ljava/lang/String;[C)V", AccessFlags = 1)]
				public void PutCharArray(string @string, char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putIntArray
				/// </java-name>
				[Dot42.DexImport("putIntArray", "(Ljava/lang/String;[I)V", AccessFlags = 1)]
				public void PutIntArray(string @string, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putLongArray
				/// </java-name>
				[Dot42.DexImport("putLongArray", "(Ljava/lang/String;[J)V", AccessFlags = 1)]
				public void PutLongArray(string @string, long[] int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putFloatArray
				/// </java-name>
				[Dot42.DexImport("putFloatArray", "(Ljava/lang/String;[F)V", AccessFlags = 1)]
				public void PutFloatArray(string @string, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putDoubleArray
				/// </java-name>
				[Dot42.DexImport("putDoubleArray", "(Ljava/lang/String;[D)V", AccessFlags = 1)]
				public void PutDoubleArray(string @string, double[] @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putStringArray
				/// </java-name>
				[Dot42.DexImport("putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutStringArray(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putCharSequenceArray
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void PutCharSequenceArray(string @string, global::Java.Lang.ICharSequence[] charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putBundle
				/// </java-name>
				[Dot42.DexImport("putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void PutBundle(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool GetBoolean(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public bool GetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1)]
				public sbyte JavaGetByte(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;)B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte GetByte(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", AccessFlags = 1)]
				public sbyte? GetByte(string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// getByte
				/// </java-name>
				[Dot42.DexImport("getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte? GetByte(string @string, byte @byte) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/String;)C", AccessFlags = 1)]
				public char GetChar(string @string) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(Ljava/lang/String;C)C", AccessFlags = 1)]
				public char GetChar(string @string, char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;)S", AccessFlags = 1)]
				public short GetShort(string @string) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(Ljava/lang/String;S)S", AccessFlags = 1)]
				public short GetShort(string @string, short int16) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetInt(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int GetInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)J", AccessFlags = 1)]
				public long GetLong(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public long GetLong(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;)F", AccessFlags = 1)]
				public float GetFloat(string @string) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public float GetFloat(string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;)D", AccessFlags = 1)]
				public double GetDouble(string @string) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public double GetDouble(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetString(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCharSequence
				/// </java-name>
				[Dot42.DexImport("getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetCharSequence(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getCharSequence
				/// </java-name>
				[Dot42.DexImport("getCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetCharSequence(string @string, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getBundle
				/// </java-name>
				[Dot42.DexImport("getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle GetBundle(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// getParcelable
				/// </java-name>
				[Dot42.DexImport("getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)TT;")]
				public T GetParcelable<T>(string @string) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getParcelableArray
				/// </java-name>
				[Dot42.DexImport("getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;", AccessFlags = 1)]
				public global::Android.OS.IParcelable[] GetParcelableArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable[]);
				}

				/// <java-name>
				/// getParcelableArrayList
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Ljava/util/ArrayList<TT;>;")]
				public global::Java.Util.ArrayList<T> GetParcelableArrayList<T>(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <java-name>
				/// getSparseParcelableArray
				/// </java-name>
				[Dot42.DexImport("getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Landroid/util/SparseArray<TT;>;")]
				public global::Android.Util.SparseArray<T> GetSparseParcelableArray<T>(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseArray<T>);
				}

				/// <java-name>
				/// getSerializable
				/// </java-name>
				[Dot42.DexImport("getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;", AccessFlags = 1)]
				public global::Java.Io.ISerializable GetSerializable(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ISerializable);
				}

				/// <java-name>
				/// getIntegerArrayList
				/// </java-name>
				[Dot42.DexImport("getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/Integer;>;")]
				public global::Java.Util.ArrayList<int?> GetIntegerArrayList(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<int?>);
				}

				/// <java-name>
				/// getStringArrayList
				/// </java-name>
				[Dot42.DexImport("getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> GetStringArrayList(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <java-name>
				/// getCharSequenceArrayList
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/CharSequence;>;")]
				public global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> GetCharSequenceArrayList(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Java.Lang.ICharSequence>);
				}

				/// <java-name>
				/// getBooleanArray
				/// </java-name>
				[Dot42.DexImport("getBooleanArray", "(Ljava/lang/String;)[Z", AccessFlags = 1)]
				public bool[] GetBooleanArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetByteArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getByteArray
				/// </java-name>
				[Dot42.DexImport("getByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetByteArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getShortArray
				/// </java-name>
				[Dot42.DexImport("getShortArray", "(Ljava/lang/String;)[S", AccessFlags = 1)]
				public short[] GetShortArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <java-name>
				/// getCharArray
				/// </java-name>
				[Dot42.DexImport("getCharArray", "(Ljava/lang/String;)[C", AccessFlags = 1)]
				public char[] GetCharArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public int[] GetIntArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getLongArray
				/// </java-name>
				[Dot42.DexImport("getLongArray", "(Ljava/lang/String;)[J", AccessFlags = 1)]
				public long[] GetLongArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <java-name>
				/// getFloatArray
				/// </java-name>
				[Dot42.DexImport("getFloatArray", "(Ljava/lang/String;)[F", AccessFlags = 1)]
				public float[] GetFloatArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// getDoubleArray
				/// </java-name>
				[Dot42.DexImport("getDoubleArray", "(Ljava/lang/String;)[D", AccessFlags = 1)]
				public double[] GetDoubleArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] GetStringArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getCharSequenceArray
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence[] GetCharSequenceArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				public bool HasFileDescriptors
				{
						[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/os/ConditionVariable
		/// </java-name>
		[Dot42.DexImport("android/os/ConditionVariable", AccessFlags = 33)]
		public partial class ConditionVariable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConditionVariable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ConditionVariable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()V", AccessFlags = 1)]
				public virtual void Open() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "()V", AccessFlags = 1)]
				public virtual void Block() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "(J)Z", AccessFlags = 1)]
				public virtual bool Block(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/os/CountDownTimer
		/// </java-name>
		[Dot42.DexImport("android/os/CountDownTimer", AccessFlags = 1057)]
		public abstract partial class CountDownTimer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(JJ)V", AccessFlags = 1)]
				public CountDownTimer(long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Landroid/os/CountDownTimer;", AccessFlags = 49)]
				public global::Android.OS.CountDownTimer Start() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.CountDownTimer);
				}

				/// <java-name>
				/// onTick
				/// </java-name>
				[Dot42.DexImport("onTick", "(J)V", AccessFlags = 1025)]
				public abstract void OnTick(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onFinish
				/// </java-name>
				[Dot42.DexImport("onFinish", "()V", AccessFlags = 1025)]
				public abstract void OnFinish() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CountDownTimer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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

		/// <java-name>
		/// android/os/Debug
		/// </java-name>
		[Dot42.DexImport("android/os/Debug", AccessFlags = 49)]
		public sealed partial class Debug
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRACE_COUNT_ALLOCS
				/// </java-name>
				[Dot42.DexImport("TRACE_COUNT_ALLOCS", "I", AccessFlags = 25)]
				public const int TRACE_COUNT_ALLOCS = 1;
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

				/// <java-name>
				/// waitForDebugger
				/// </java-name>
				[Dot42.DexImport("waitForDebugger", "()V", AccessFlags = 9)]
				public static void WaitForDebugger() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// waitingForDebugger
				/// </java-name>
				[Dot42.DexImport("waitingForDebugger", "()Z", AccessFlags = 9)]
				public static bool WaitingForDebugger() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// changeDebugPort
				/// </java-name>
				[Dot42.DexImport("changeDebugPort", "(I)V", AccessFlags = 9)]
				public static void ChangeDebugPort(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startNativeTracing
				/// </java-name>
				[Dot42.DexImport("startNativeTracing", "()V", AccessFlags = 9)]
				public static void StartNativeTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopNativeTracing
				/// </java-name>
				[Dot42.DexImport("stopNativeTracing", "()V", AccessFlags = 9)]
				public static void StopNativeTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableEmulatorTraceOutput
				/// </java-name>
				[Dot42.DexImport("enableEmulatorTraceOutput", "()V", AccessFlags = 9)]
				public static void EnableEmulatorTraceOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "()V", AccessFlags = 9)]
				public static void StartMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void StartMethodTracing(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;I)V", AccessFlags = 9)]
				public static void StartMethodTracing(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startMethodTracing
				/// </java-name>
				[Dot42.DexImport("startMethodTracing", "(Ljava/lang/String;II)V", AccessFlags = 9)]
				public static void StartMethodTracing(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopMethodTracing
				/// </java-name>
				[Dot42.DexImport("stopMethodTracing", "()V", AccessFlags = 9)]
				public static void StopMethodTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// threadCpuTimeNanos
				/// </java-name>
				[Dot42.DexImport("threadCpuTimeNanos", "()J", AccessFlags = 9)]
				public static long ThreadCpuTimeNanos() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// startAllocCounting
				/// </java-name>
				[Dot42.DexImport("startAllocCounting", "()V", AccessFlags = 9)]
				public static void StartAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopAllocCounting
				/// </java-name>
				[Dot42.DexImport("stopAllocCounting", "()V", AccessFlags = 9)]
				public static void StopAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalFreedCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalFreedCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalFreedCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalFreedSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalFreedSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalFreedSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalClassInitCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalClassInitCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalClassInitCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalClassInitTime
				/// </java-name>
				[Dot42.DexImport("resetGlobalClassInitTime", "()V", AccessFlags = 9)]
				public static void ResetGlobalClassInitTime() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalExternalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalExternalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalExternalFreedCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalFreedCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalFreedCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalExternalFreedSize
				/// </java-name>
				[Dot42.DexImport("resetGlobalExternalFreedSize", "()V", AccessFlags = 9)]
				public static void ResetGlobalExternalFreedSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetGlobalGcInvocationCount
				/// </java-name>
				[Dot42.DexImport("resetGlobalGcInvocationCount", "()V", AccessFlags = 9)]
				public static void ResetGlobalGcInvocationCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetThreadAllocCount
				/// </java-name>
				[Dot42.DexImport("resetThreadAllocCount", "()V", AccessFlags = 9)]
				public static void ResetThreadAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetThreadAllocSize
				/// </java-name>
				[Dot42.DexImport("resetThreadAllocSize", "()V", AccessFlags = 9)]
				public static void ResetThreadAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetThreadExternalAllocCount
				/// </java-name>
				[Dot42.DexImport("resetThreadExternalAllocCount", "()V", AccessFlags = 9)]
				public static void ResetThreadExternalAllocCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetThreadExternalAllocSize
				/// </java-name>
				[Dot42.DexImport("resetThreadExternalAllocSize", "()V", AccessFlags = 9)]
				public static void ResetThreadExternalAllocSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetThreadGcInvocationCount
				/// </java-name>
				[Dot42.DexImport("resetThreadGcInvocationCount", "()V", AccessFlags = 9)]
				public static void ResetThreadGcInvocationCount() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetAllCounts
				/// </java-name>
				[Dot42.DexImport("resetAllCounts", "()V", AccessFlags = 9)]
				public static void ResetAllCounts() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V", AccessFlags = 265)]
				public static void GetMemoryInfo(global::Android.OS.Debug.MemoryInfo memoryInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setAllocationLimit", "(I)I", AccessFlags = 9)]
				public static int SetAllocationLimit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setGlobalAllocationLimit
				/// </java-name>
				[Dot42.DexImport("setGlobalAllocationLimit", "(I)I", AccessFlags = 9)]
				public static int SetGlobalAllocationLimit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// printLoadedClasses
				/// </java-name>
				[Dot42.DexImport("printLoadedClasses", "(I)V", AccessFlags = 9)]
				public static void PrintLoadedClasses(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpHprofData
				/// </java-name>
				[Dot42.DexImport("dumpHprofData", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DumpHprofData(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpService
				/// </java-name>
				[Dot42.DexImport("dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool DumpService(string @string, global::Java.Io.FileDescriptor fileDescriptor, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDebuggerConnected
				/// </java-name>
				public static bool IsDebuggerConnected
				{
						[Dot42.DexImport("isDebuggerConnected", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getGlobalAllocCount
				/// </java-name>
				public static int GlobalAllocCount
				{
						[Dot42.DexImport("getGlobalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalAllocSize
				/// </java-name>
				public static int GlobalAllocSize
				{
						[Dot42.DexImport("getGlobalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalFreedCount
				/// </java-name>
				public static int GlobalFreedCount
				{
						[Dot42.DexImport("getGlobalFreedCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalFreedSize
				/// </java-name>
				public static int GlobalFreedSize
				{
						[Dot42.DexImport("getGlobalFreedSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalClassInitCount
				/// </java-name>
				public static int GlobalClassInitCount
				{
						[Dot42.DexImport("getGlobalClassInitCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalClassInitTime
				/// </java-name>
				public static int GlobalClassInitTime
				{
						[Dot42.DexImport("getGlobalClassInitTime", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalExternalAllocCount
				/// </java-name>
				public static int GlobalExternalAllocCount
				{
						[Dot42.DexImport("getGlobalExternalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalExternalAllocSize
				/// </java-name>
				public static int GlobalExternalAllocSize
				{
						[Dot42.DexImport("getGlobalExternalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalExternalFreedCount
				/// </java-name>
				public static int GlobalExternalFreedCount
				{
						[Dot42.DexImport("getGlobalExternalFreedCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalExternalFreedSize
				/// </java-name>
				public static int GlobalExternalFreedSize
				{
						[Dot42.DexImport("getGlobalExternalFreedSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGlobalGcInvocationCount
				/// </java-name>
				public static int GlobalGcInvocationCount
				{
						[Dot42.DexImport("getGlobalGcInvocationCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getThreadAllocCount
				/// </java-name>
				public static int ThreadAllocCount
				{
						[Dot42.DexImport("getThreadAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getThreadAllocSize
				/// </java-name>
				public static int ThreadAllocSize
				{
						[Dot42.DexImport("getThreadAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getThreadExternalAllocCount
				/// </java-name>
				public static int ThreadExternalAllocCount
				{
						[Dot42.DexImport("getThreadExternalAllocCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getThreadExternalAllocSize
				/// </java-name>
				public static int ThreadExternalAllocSize
				{
						[Dot42.DexImport("getThreadExternalAllocSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getThreadGcInvocationCount
				/// </java-name>
				public static int ThreadGcInvocationCount
				{
						[Dot42.DexImport("getThreadGcInvocationCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getNativeHeapSize
				/// </java-name>
				public static long NativeHeapSize
				{
						[Dot42.DexImport("getNativeHeapSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getNativeHeapAllocatedSize
				/// </java-name>
				public static long NativeHeapAllocatedSize
				{
						[Dot42.DexImport("getNativeHeapAllocatedSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getNativeHeapFreeSize
				/// </java-name>
				public static long NativeHeapFreeSize
				{
						[Dot42.DexImport("getNativeHeapFreeSize", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getPss
				/// </java-name>
				public static long Pss
				{
						[Dot42.DexImport("getPss", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getLoadedClassCount
				/// </java-name>
				public static int LoadedClassCount
				{
						[Dot42.DexImport("getLoadedClassCount", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBinderSentTransactions
				/// </java-name>
				public static int BinderSentTransactions
				{
						[Dot42.DexImport("getBinderSentTransactions", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBinderReceivedTransactions
				/// </java-name>
				public static int BinderReceivedTransactions
				{
						[Dot42.DexImport("getBinderReceivedTransactions", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBinderLocalObjectCount
				/// </java-name>
				public static int BinderLocalObjectCount
				{
						[Dot42.DexImport("getBinderLocalObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBinderProxyObjectCount
				/// </java-name>
				public static int BinderProxyObjectCount
				{
						[Dot42.DexImport("getBinderProxyObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBinderDeathObjectCount
				/// </java-name>
				public static int BinderDeathObjectCount
				{
						[Dot42.DexImport("getBinderDeathObjectCount", "()I", AccessFlags = 281)]
						get{ return default(int); }
				}

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

						/// <java-name>
						/// resetAndStart
						/// </java-name>
						[Dot42.DexImport("resetAndStart", "()Z", AccessFlags = 1)]
						public virtual bool ResetAndStart() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// collect
						/// </java-name>
						[Dot42.DexImport("collect", "()Z", AccessFlags = 1)]
						public virtual bool Collect() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// globalTotal
						/// </java-name>
						[Dot42.DexImport("globalTotal", "()I", AccessFlags = 1)]
						public virtual int GlobalTotal() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// globalMethodInvocations
						/// </java-name>
						[Dot42.DexImport("globalMethodInvocations", "()I", AccessFlags = 1)]
						public virtual int GlobalMethodInvocations() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

				}

				/// <java-name>
				/// android/os/Debug$MemoryInfo
				/// </java-name>
				[Dot42.DexImport("android/os/Debug$MemoryInfo", AccessFlags = 9)]
				public partial class MemoryInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// dalvikPss
						/// </java-name>
						[Dot42.DexImport("dalvikPss", "I", AccessFlags = 1)]
						public int DalvikPss;
						/// <java-name>
						/// dalvikPrivateDirty
						/// </java-name>
						[Dot42.DexImport("dalvikPrivateDirty", "I", AccessFlags = 1)]
						public int DalvikPrivateDirty;
						/// <java-name>
						/// dalvikSharedDirty
						/// </java-name>
						[Dot42.DexImport("dalvikSharedDirty", "I", AccessFlags = 1)]
						public int DalvikSharedDirty;
						/// <java-name>
						/// nativePss
						/// </java-name>
						[Dot42.DexImport("nativePss", "I", AccessFlags = 1)]
						public int NativePss;
						/// <java-name>
						/// nativePrivateDirty
						/// </java-name>
						[Dot42.DexImport("nativePrivateDirty", "I", AccessFlags = 1)]
						public int NativePrivateDirty;
						/// <java-name>
						/// nativeSharedDirty
						/// </java-name>
						[Dot42.DexImport("nativeSharedDirty", "I", AccessFlags = 1)]
						public int NativeSharedDirty;
						/// <java-name>
						/// otherPss
						/// </java-name>
						[Dot42.DexImport("otherPss", "I", AccessFlags = 1)]
						public int OtherPss;
						/// <java-name>
						/// otherPrivateDirty
						/// </java-name>
						[Dot42.DexImport("otherPrivateDirty", "I", AccessFlags = 1)]
						public int OtherPrivateDirty;
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
						public virtual int GetOtherPss(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherPrivateDirty
						/// </java-name>
						[Dot42.DexImport("getOtherPrivateDirty", "(I)I", AccessFlags = 1)]
						public virtual int GetOtherPrivateDirty(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherSharedDirty
						/// </java-name>
						[Dot42.DexImport("getOtherSharedDirty", "(I)I", AccessFlags = 1)]
						public virtual int GetOtherSharedDirty(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOtherLabel
						/// </java-name>
						[Dot42.DexImport("getOtherLabel", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string GetOtherLabel(int int32) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getTotalPss
						/// </java-name>
						public virtual int TotalPss
						{
								[Dot42.DexImport("getTotalPss", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getTotalPrivateDirty
						/// </java-name>
						public virtual int TotalPrivateDirty
						{
								[Dot42.DexImport("getTotalPrivateDirty", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

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

		/// <java-name>
		/// android/os/DropBoxManager
		/// </java-name>
		[Dot42.DexImport("android/os/DropBoxManager", AccessFlags = 33)]
		public partial class DropBoxManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// IS_EMPTY
				/// </java-name>
				[Dot42.DexImport("IS_EMPTY", "I", AccessFlags = 25)]
				public const int IS_EMPTY = 1;
				/// <java-name>
				/// IS_TEXT
				/// </java-name>
				[Dot42.DexImport("IS_TEXT", "I", AccessFlags = 25)]
				public const int IS_TEXT = 2;
				/// <java-name>
				/// IS_GZIPPED
				/// </java-name>
				[Dot42.DexImport("IS_GZIPPED", "I", AccessFlags = 25)]
				public const int IS_GZIPPED = 4;
				/// <java-name>
				/// ACTION_DROPBOX_ENTRY_ADDED
				/// </java-name>
				[Dot42.DexImport("ACTION_DROPBOX_ENTRY_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DROPBOX_ENTRY_ADDED = "android.intent.action.DROPBOX_ENTRY_ADDED";
				/// <java-name>
				/// EXTRA_TAG
				/// </java-name>
				[Dot42.DexImport("EXTRA_TAG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TAG = "tag";
				/// <java-name>
				/// EXTRA_TIME
				/// </java-name>
				[Dot42.DexImport("EXTRA_TIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TIME = "time";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DropBoxManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addText
				/// </java-name>
				[Dot42.DexImport("addText", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddText(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addData
				/// </java-name>
				[Dot42.DexImport("addData", "(Ljava/lang/String;[BI)V", AccessFlags = 1)]
				public virtual void AddData(string @string, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addData
				/// </java-name>
				[Dot42.DexImport("addData", "(Ljava/lang/String;[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddData(string @string, byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFile
				/// </java-name>
				[Dot42.DexImport("addFile", "(Ljava/lang/String;Ljava/io/File;I)V", AccessFlags = 1)]
				public virtual void AddFile(string @string, global::Java.Io.File file, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isTagEnabled
				/// </java-name>
				[Dot42.DexImport("isTagEnabled", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsTagEnabled(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getNextEntry
				/// </java-name>
				[Dot42.DexImport("getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;", AccessFlags = 1)]
				public virtual global::Android.OS.DropBoxManager.Entry GetNextEntry(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.DropBoxManager.Entry);
				}

				/// <java-name>
				/// android/os/DropBoxManager$Entry
				/// </java-name>
				[Dot42.DexImport("android/os/DropBoxManager$Entry", AccessFlags = 9)]
				public partial class Entry : global::Android.OS.IParcelable, global::Java.Io.ICloseable
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

						[Dot42.DexImport("<init>", "(Ljava/lang/String;J[BI)V", AccessFlags = 1)]
						public Entry(string @string, long int64, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;J[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
						public Entry(string @string, long int64, byte[] @byte, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V", AccessFlags = 1)]
						public Entry(string @string, long int64, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;JLjava/io/File;I)V", AccessFlags = 1)]
						public Entry(string @string, long int64, global::Java.Io.File file, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public virtual void Close() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getText
						/// </java-name>
						[Dot42.DexImport("getText", "(I)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetText(int int32) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Entry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						public virtual string Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <java-name>
						/// getTimeMillis
						/// </java-name>
						public virtual long TimeMillis
						{
								[Dot42.DexImport("getTimeMillis", "()J", AccessFlags = 1)]
								get{ return default(long); }
						}

						/// <java-name>
						/// getFlags
						/// </java-name>
						public virtual int Flags
						{
								[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getInputStream
						/// </java-name>
						public virtual global::Java.Io.InputStream InputStream
						{
								[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
								get{ return default(global::Java.Io.InputStream); }
						}

				}

		}

		/// <java-name>
		/// android/os/Environment
		/// </java-name>
		[Dot42.DexImport("android/os/Environment", AccessFlags = 33)]
		public partial class Environment
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DIRECTORY_MUSIC
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_MUSIC", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_MUSIC;
				/// <java-name>
				/// DIRECTORY_PODCASTS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PODCASTS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_PODCASTS;
				/// <java-name>
				/// DIRECTORY_RINGTONES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_RINGTONES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_RINGTONES;
				/// <java-name>
				/// DIRECTORY_ALARMS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_ALARMS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_ALARMS;
				/// <java-name>
				/// DIRECTORY_NOTIFICATIONS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_NOTIFICATIONS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_NOTIFICATIONS;
				/// <java-name>
				/// DIRECTORY_PICTURES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_PICTURES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_PICTURES;
				/// <java-name>
				/// DIRECTORY_MOVIES
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_MOVIES", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_MOVIES;
				/// <java-name>
				/// DIRECTORY_DOWNLOADS
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_DOWNLOADS", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_DOWNLOADS;
				/// <java-name>
				/// DIRECTORY_DCIM
				/// </java-name>
				[Dot42.DexImport("DIRECTORY_DCIM", "Ljava/lang/String;", AccessFlags = 9)]
				public static string DIRECTORY_DCIM;
				/// <java-name>
				/// MEDIA_REMOVED
				/// </java-name>
				[Dot42.DexImport("MEDIA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_REMOVED = "removed";
				/// <java-name>
				/// MEDIA_UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("MEDIA_UNMOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_UNMOUNTED = "unmounted";
				/// <java-name>
				/// MEDIA_CHECKING
				/// </java-name>
				[Dot42.DexImport("MEDIA_CHECKING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_CHECKING = "checking";
				/// <java-name>
				/// MEDIA_NOFS
				/// </java-name>
				[Dot42.DexImport("MEDIA_NOFS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_NOFS = "nofs";
				/// <java-name>
				/// MEDIA_MOUNTED
				/// </java-name>
				[Dot42.DexImport("MEDIA_MOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_MOUNTED = "mounted";
				/// <java-name>
				/// MEDIA_MOUNTED_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("MEDIA_MOUNTED_READ_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_MOUNTED_READ_ONLY = "mounted_ro";
				/// <java-name>
				/// MEDIA_SHARED
				/// </java-name>
				[Dot42.DexImport("MEDIA_SHARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_SHARED = "shared";
				/// <java-name>
				/// MEDIA_BAD_REMOVAL
				/// </java-name>
				[Dot42.DexImport("MEDIA_BAD_REMOVAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_BAD_REMOVAL = "bad_removal";
				/// <java-name>
				/// MEDIA_UNMOUNTABLE
				/// </java-name>
				[Dot42.DexImport("MEDIA_UNMOUNTABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_UNMOUNTABLE = "unmountable";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Environment() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExternalStoragePublicDirectory
				/// </java-name>
				[Dot42.DexImport("getExternalStoragePublicDirectory", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File GetExternalStoragePublicDirectory(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getRootDirectory
				/// </java-name>
				public static global::Java.Io.File RootDirectory
				{
						[Dot42.DexImport("getRootDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.Io.File); }
				}

				/// <java-name>
				/// getDataDirectory
				/// </java-name>
				public static global::Java.Io.File DataDirectory
				{
						[Dot42.DexImport("getDataDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.Io.File); }
				}

				/// <java-name>
				/// getExternalStorageDirectory
				/// </java-name>
				public static global::Java.Io.File ExternalStorageDirectory
				{
						[Dot42.DexImport("getExternalStorageDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.Io.File); }
				}

				/// <java-name>
				/// getDownloadCacheDirectory
				/// </java-name>
				public static global::Java.Io.File DownloadCacheDirectory
				{
						[Dot42.DexImport("getDownloadCacheDirectory", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return default(global::Java.Io.File); }
				}

				/// <java-name>
				/// getExternalStorageState
				/// </java-name>
				public static string ExternalStorageState
				{
						[Dot42.DexImport("getExternalStorageState", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isExternalStorageRemovable
				/// </java-name>
				public static bool IsExternalStorageRemovable
				{
						[Dot42.DexImport("isExternalStorageRemovable", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isExternalStorageEmulated
				/// </java-name>
				public static bool IsExternalStorageEmulated
				{
						[Dot42.DexImport("isExternalStorageEmulated", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/os/FileObserver
		/// </java-name>
		[Dot42.DexImport("android/os/FileObserver", AccessFlags = 1057)]
		public abstract partial class FileObserver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACCESS
				/// </java-name>
				[Dot42.DexImport("ACCESS", "I", AccessFlags = 25)]
				public const int ACCESS = 1;
				/// <java-name>
				/// MODIFY
				/// </java-name>
				[Dot42.DexImport("MODIFY", "I", AccessFlags = 25)]
				public const int MODIFY = 2;
				/// <java-name>
				/// ATTRIB
				/// </java-name>
				[Dot42.DexImport("ATTRIB", "I", AccessFlags = 25)]
				public const int ATTRIB = 4;
				/// <java-name>
				/// CLOSE_WRITE
				/// </java-name>
				[Dot42.DexImport("CLOSE_WRITE", "I", AccessFlags = 25)]
				public const int CLOSE_WRITE = 8;
				/// <java-name>
				/// CLOSE_NOWRITE
				/// </java-name>
				[Dot42.DexImport("CLOSE_NOWRITE", "I", AccessFlags = 25)]
				public const int CLOSE_NOWRITE = 16;
				/// <java-name>
				/// OPEN
				/// </java-name>
				[Dot42.DexImport("OPEN", "I", AccessFlags = 25)]
				public const int OPEN = 32;
				/// <java-name>
				/// MOVED_FROM
				/// </java-name>
				[Dot42.DexImport("MOVED_FROM", "I", AccessFlags = 25)]
				public const int MOVED_FROM = 64;
				/// <java-name>
				/// MOVED_TO
				/// </java-name>
				[Dot42.DexImport("MOVED_TO", "I", AccessFlags = 25)]
				public const int MOVED_TO = 128;
				/// <java-name>
				/// CREATE
				/// </java-name>
				[Dot42.DexImport("CREATE", "I", AccessFlags = 25)]
				public const int CREATE = 256;
				/// <java-name>
				/// DELETE
				/// </java-name>
				[Dot42.DexImport("DELETE", "I", AccessFlags = 25)]
				public const int DELETE = 512;
				/// <java-name>
				/// DELETE_SELF
				/// </java-name>
				[Dot42.DexImport("DELETE_SELF", "I", AccessFlags = 25)]
				public const int DELETE_SELF = 1024;
				/// <java-name>
				/// MOVE_SELF
				/// </java-name>
				[Dot42.DexImport("MOVE_SELF", "I", AccessFlags = 25)]
				public const int MOVE_SELF = 2048;
				/// <java-name>
				/// ALL_EVENTS
				/// </java-name>
				[Dot42.DexImport("ALL_EVENTS", "I", AccessFlags = 25)]
				public const int ALL_EVENTS = 4095;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileObserver(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public FileObserver(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileObserver() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startWatching
				/// </java-name>
				[Dot42.DexImport("startWatching", "()V", AccessFlags = 1)]
				public virtual void StartWatching() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopWatching
				/// </java-name>
				[Dot42.DexImport("stopWatching", "()V", AccessFlags = 1)]
				public virtual void StopWatching() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onEvent
				/// </java-name>
				[Dot42.DexImport("onEvent", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnEvent(int int32, string @string) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileObserver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/os/Handler
		/// </java-name>
		[Dot42.DexImport("android/os/Handler", AccessFlags = 33)]
		public partial class Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Handler() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Handler$Callback;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Handler.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Looper;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V", AccessFlags = 1)]
				public Handler(global::Android.OS.Looper looper, global::Android.OS.Handler.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleMessage
				/// </java-name>
				[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void HandleMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchMessage
				/// </java-name>
				[Dot42.DexImport("dispatchMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void DispatchMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessageName
				/// </java-name>
				[Dot42.DexImport("getMessageName", "(Landroid/os/Message;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMessageName(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "()Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(I)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(III)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtainMessage
				/// </java-name>
				[Dot42.DexImport("obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 17)]
				public global::Android.OS.Message ObtainMessage(int int32, int int321, int int322, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// post
				/// </java-name>
				[Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 17)]
				public bool Post(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postAtTime
				/// </java-name>
				[Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17)]
				public bool PostAtTime(global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postAtTime
				/// </java-name>
				[Dot42.DexImport("postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z", AccessFlags = 17)]
				public bool PostAtTime(global::Java.Lang.IRunnable runnable, object @object, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postDelayed
				/// </java-name>
				[Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 17)]
				public bool PostDelayed(global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postAtFrontOfQueue
				/// </java-name>
				[Dot42.DexImport("postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", AccessFlags = 17)]
				public bool PostAtFrontOfQueue(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)V", AccessFlags = 17)]
				public void RemoveCallbacks(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveCallbacks(global::Java.Lang.IRunnable runnable, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendMessage
				/// </java-name>
				[Dot42.DexImport("sendMessage", "(Landroid/os/Message;)Z", AccessFlags = 17)]
				public bool SendMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendEmptyMessage
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessage", "(I)Z", AccessFlags = 17)]
				public bool SendEmptyMessage(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendEmptyMessageDelayed
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessageDelayed", "(IJ)Z", AccessFlags = 17)]
				public bool SendEmptyMessageDelayed(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendEmptyMessageAtTime
				/// </java-name>
				[Dot42.DexImport("sendEmptyMessageAtTime", "(IJ)Z", AccessFlags = 17)]
				public bool SendEmptyMessageAtTime(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendMessageDelayed
				/// </java-name>
				[Dot42.DexImport("sendMessageDelayed", "(Landroid/os/Message;J)Z", AccessFlags = 17)]
				public bool SendMessageDelayed(global::Android.OS.Message message, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendMessageAtTime
				/// </java-name>
				[Dot42.DexImport("sendMessageAtTime", "(Landroid/os/Message;J)Z", AccessFlags = 1)]
				public virtual bool SendMessageAtTime(global::Android.OS.Message message, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendMessageAtFrontOfQueue
				/// </java-name>
				[Dot42.DexImport("sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z", AccessFlags = 17)]
				public bool SendMessageAtFrontOfQueue(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeMessages
				/// </java-name>
				[Dot42.DexImport("removeMessages", "(I)V", AccessFlags = 17)]
				public void RemoveMessages(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeMessages
				/// </java-name>
				[Dot42.DexImport("removeMessages", "(ILjava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveMessages(int int32, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeCallbacksAndMessages
				/// </java-name>
				[Dot42.DexImport("removeCallbacksAndMessages", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void RemoveCallbacksAndMessages(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasMessages
				/// </java-name>
				[Dot42.DexImport("hasMessages", "(I)Z", AccessFlags = 17)]
				public bool HasMessages(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasMessages
				/// </java-name>
				[Dot42.DexImport("hasMessages", "(ILjava/lang/Object;)Z", AccessFlags = 17)]
				public bool HasMessages(int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 17)]
				public void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
						bool HandleMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/os/HandlerThread
		/// </java-name>
		[Dot42.DexImport("android/os/HandlerThread", AccessFlags = 33)]
		public partial class HandlerThread : global::System.Threading.Thread
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HandlerThread(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HandlerThread(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// quit
				/// </java-name>
				[Dot42.DexImport("quit", "()Z", AccessFlags = 1)]
				public virtual bool Quit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HandlerThread() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLooper
				/// </java-name>
				public virtual global::Android.OS.Looper Looper
				{
						[Dot42.DexImport("getLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <java-name>
				/// getThreadId
				/// </java-name>
				public virtual int ThreadId
				{
						[Dot42.DexImport("getThreadId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/os/IBinder
		/// </java-name>
		[Dot42.DexImport("android/os/IBinder", AccessFlags = 1537)]
		public partial interface IBinder
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// pingBinder
				/// </java-name>
				[Dot42.DexImport("pingBinder", "()Z", AccessFlags = 1025)]
				bool PingBinder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// queryLocalInterface
				/// </java-name>
				[Dot42.DexImport("queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", AccessFlags = 1025)]
				global::Android.OS.IInterface QueryLocalInterface(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void Dump(global::Java.Io.FileDescriptor fileDescriptor, string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dumpAsync
				/// </java-name>
				[Dot42.DexImport("dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", AccessFlags = 1025)]
				void DumpAsync(global::Java.Io.FileDescriptor fileDescriptor, string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// transact
				/// </java-name>
				[Dot42.DexImport("transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", AccessFlags = 1025)]
				bool Transact(int int32, global::Android.OS.Parcel parcel, global::Android.OS.Parcel parcel1, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// linkToDeath
				/// </java-name>
				[Dot42.DexImport("linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", AccessFlags = 1025)]
				void LinkToDeath(global::Android.OS.IBinder_IDeathRecipient binder_IDeathRecipient, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unlinkToDeath
				/// </java-name>
				[Dot42.DexImport("unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", AccessFlags = 1025)]
				bool UnlinkToDeath(global::Android.OS.IBinder_IDeathRecipient binder_IDeathRecipient, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInterfaceDescriptor
				/// </java-name>
				string InterfaceDescriptor
				{
						[Dot42.DexImport("getInterfaceDescriptor", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isBinderAlive
				/// </java-name>
				bool IsBinderAlive
				{
						[Dot42.DexImport("isBinderAlive", "()Z", AccessFlags = 1025)]
						get;
				}

		}

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

		/// <java-name>
		/// android/os/IBinder
		/// </java-name>
		[Dot42.DexImport("android/os/IBinder", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBinderConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FIRST_CALL_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("FIRST_CALL_TRANSACTION", "I", AccessFlags = 25)]
				public const int FIRST_CALL_TRANSACTION = 1;
				/// <java-name>
				/// LAST_CALL_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("LAST_CALL_TRANSACTION", "I", AccessFlags = 25)]
				public const int LAST_CALL_TRANSACTION = 16777215;
				/// <java-name>
				/// PING_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("PING_TRANSACTION", "I", AccessFlags = 25)]
				public const int PING_TRANSACTION = 1599098439;
				/// <java-name>
				/// DUMP_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("DUMP_TRANSACTION", "I", AccessFlags = 25)]
				public const int DUMP_TRANSACTION = 1598311760;
				/// <java-name>
				/// INTERFACE_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("INTERFACE_TRANSACTION", "I", AccessFlags = 25)]
				public const int INTERFACE_TRANSACTION = 1598968902;
				/// <java-name>
				/// TWEET_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("TWEET_TRANSACTION", "I", AccessFlags = 25)]
				public const int TWEET_TRANSACTION = 1599362900;
				/// <java-name>
				/// LIKE_TRANSACTION
				/// </java-name>
				[Dot42.DexImport("LIKE_TRANSACTION", "I", AccessFlags = 25)]
				public const int LIKE_TRANSACTION = 1598835019;
				/// <java-name>
				/// FLAG_ONEWAY
				/// </java-name>
				[Dot42.DexImport("FLAG_ONEWAY", "I", AccessFlags = 25)]
				public const int FLAG_ONEWAY = 1;
		}

		/// <java-name>
		/// android/os/IInterface
		/// </java-name>
		[Dot42.DexImport("android/os/IInterface", AccessFlags = 1537)]
		public partial interface IInterface
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// asBinder
				/// </java-name>
				[Dot42.DexImport("asBinder", "()Landroid/os/IBinder;", AccessFlags = 1025)]
				global::Android.OS.IBinder AsBinder() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/os/Parcelable
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable", AccessFlags = 1537)]
		public partial interface IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1025)]
				int DescribeContents() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/os/Parcelable$ClassLoaderCreator
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable$ClassLoaderCreator", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;Landroid/os/Parcelable$Creator<TT;>;")]
		public partial interface IParcelable_IClassLoaderCreator<T> : global::Android.OS.IParcelable_ICreator<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createFromParcel
				/// </java-name>
				[Dot42.DexImport("createFromParcel", "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)TT;")]
				T CreateFromParcel(global::Android.OS.Parcel parcel, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/os/Parcelable$Creator
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable$Creator", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IParcelable_ICreator<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createFromParcel
				/// </java-name>
				[Dot42.DexImport("createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(Landroid/os/Parcel;)TT;")]
				T CreateFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newArray
				/// </java-name>
				[Dot42.DexImport("newArray", "(I)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "(I)[TT;")]
				T[] NewArray(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/os/Parcelable
		/// </java-name>
		[Dot42.DexImport("android/os/Parcelable", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IParcelableConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARCELABLE_WRITE_RETURN_VALUE
				/// </java-name>
				[Dot42.DexImport("PARCELABLE_WRITE_RETURN_VALUE", "I", AccessFlags = 25)]
				public const int PARCELABLE_WRITE_RETURN_VALUE = 1;
				/// <java-name>
				/// CONTENTS_FILE_DESCRIPTOR
				/// </java-name>
				[Dot42.DexImport("CONTENTS_FILE_DESCRIPTOR", "I", AccessFlags = 25)]
				public const int CONTENTS_FILE_DESCRIPTOR = 1;
		}

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

				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 9)]
				public static void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepareMainLooper
				/// </java-name>
				[Dot42.DexImport("prepareMainLooper", "()V", AccessFlags = 9)]
				public static void PrepareMainLooper() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loop
				/// </java-name>
				[Dot42.DexImport("loop", "()V", AccessFlags = 9)]
				public static void Loop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// myLooper
				/// </java-name>
				[Dot42.DexImport("myLooper", "()Landroid/os/Looper;", AccessFlags = 9)]
				public static global::Android.OS.Looper MyLooper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Looper);
				}

				/// <java-name>
				/// setMessageLogging
				/// </java-name>
				[Dot42.DexImport("setMessageLogging", "(Landroid/util/Printer;)V", AccessFlags = 1)]
				public virtual void SetMessageLogging(global::Android.Util.IPrinter printer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// myQueue
				/// </java-name>
				[Dot42.DexImport("myQueue", "()Landroid/os/MessageQueue;", AccessFlags = 9)]
				public static global::Android.OS.MessageQueue MyQueue() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.MessageQueue);
				}

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
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// getMainLooper
				/// </java-name>
				public static global::Android.OS.Looper MainLooper
				{
						[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 41)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <java-name>
				/// getThread
				/// </java-name>
				public virtual global::System.Threading.Thread Thread
				{
						[Dot42.DexImport("getThread", "()Ljava/lang/Thread;", AccessFlags = 1)]
						get{ return default(global::System.Threading.Thread); }
				}

		}

		/// <java-name>
		/// android/os/MemoryFile
		/// </java-name>
		[Dot42.DexImport("android/os/MemoryFile", AccessFlags = 33)]
		public partial class MemoryFile
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public MemoryFile(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// allowPurging
				/// </java-name>
				[Dot42.DexImport("allowPurging", "(Z)Z", AccessFlags = 33)]
				public virtual bool AllowPurging(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "([BIII)I", AccessFlags = 1)]
				public virtual int ReadBytes(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readBytes
				/// </java-name>
				[Dot42.DexImport("readBytes", "([BIII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ReadBytes(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([BIII)V", AccessFlags = 1)]
				public virtual void WriteBytes(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "([BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void WriteBytes(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MemoryFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isPurgingAllowed
				/// </java-name>
				public virtual bool IsPurgingAllowed
				{
						[Dot42.DexImport("isPurgingAllowed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.Io.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.InputStream); }
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.Io.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.OutputStream); }
				}

		}

		/// <java-name>
		/// android/os/Message
		/// </java-name>
		[Dot42.DexImport("android/os/Message", AccessFlags = 49)]
		public sealed partial class Message : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// what
				/// </java-name>
				[Dot42.DexImport("what", "I", AccessFlags = 1)]
				public int What;
				/// <java-name>
				/// arg1
				/// </java-name>
				[Dot42.DexImport("arg1", "I", AccessFlags = 1)]
				public int Arg1;
				/// <java-name>
				/// arg2
				/// </java-name>
				[Dot42.DexImport("arg2", "I", AccessFlags = 1)]
				public int Arg2;
				/// <java-name>
				/// obj
				/// </java-name>
				[Dot42.DexImport("obj", "Ljava/lang/Object;", AccessFlags = 1)]
				public object Obj;
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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Message() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Message;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;I)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler, int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;III)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;", AccessFlags = 9)]
				public static global::Android.OS.Message Obtain(global::Android.OS.Handler handler, int int32, int int321, int int322, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Message);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public void CopyFrom(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// peekData
				/// </java-name>
				[Dot42.DexImport("peekData", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle PeekData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWhen
				/// </java-name>
				public long When
				{
						[Dot42.DexImport("getWhen", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

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

				/// <java-name>
				/// getCallback
				/// </java-name>
				public global::Java.Lang.IRunnable Callback
				{
						[Dot42.DexImport("getCallback", "()Ljava/lang/Runnable;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.IRunnable); }
				}

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

				/// <java-name>
				/// addIdleHandler
				/// </java-name>
				[Dot42.DexImport("addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", AccessFlags = 17)]
				public void AddIdleHandler(global::Android.OS.MessageQueue.IIdleHandler idleHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeIdleHandler
				/// </java-name>
				[Dot42.DexImport("removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", AccessFlags = 17)]
				public void RemoveIdleHandler(global::Android.OS.MessageQueue.IIdleHandler idleHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MessageQueue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/os/MessageQueue$IdleHandler
				/// </java-name>
				[Dot42.DexImport("android/os/MessageQueue$IdleHandler", AccessFlags = 1545)]
				public partial interface IIdleHandler
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// queueIdle
						/// </java-name>
						[Dot42.DexImport("queueIdle", "()Z", AccessFlags = 1025)]
						bool QueueIdle() /* MethodBuilder.Create */ ;

				}

		}

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
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public Messenger(global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public Messenger(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public void Send(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeMessengerOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteMessengerOrNullToParcel(global::Android.OS.Messenger messenger, global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readMessengerOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;", AccessFlags = 9)]
				public static global::Android.OS.Messenger ReadMessengerOrNullFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Messenger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Messenger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBinder
				/// </java-name>
				public global::Android.OS.IBinder Binder
				{
						[Dot42.DexImport("getBinder", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

		}

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

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/os/Parcel;", AccessFlags = 9)]
				public static global::Android.OS.Parcel Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Parcel);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 17)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dataSize
				/// </java-name>
				[Dot42.DexImport("dataSize", "()I", AccessFlags = 273)]
				public int DataSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dataAvail
				/// </java-name>
				[Dot42.DexImport("dataAvail", "()I", AccessFlags = 273)]
				public int DataAvail() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dataPosition
				/// </java-name>
				[Dot42.DexImport("dataPosition", "()I", AccessFlags = 273)]
				public int DataPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dataCapacity
				/// </java-name>
				[Dot42.DexImport("dataCapacity", "()I", AccessFlags = 273)]
				public int DataCapacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDataSize
				/// </java-name>
				[Dot42.DexImport("setDataSize", "(I)V", AccessFlags = 273)]
				public void SetDataSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataPosition
				/// </java-name>
				[Dot42.DexImport("setDataPosition", "(I)V", AccessFlags = 273)]
				public void SetDataPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataCapacity
				/// </java-name>
				[Dot42.DexImport("setDataCapacity", "(I)V", AccessFlags = 273)]
				public void SetDataCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// marshall
				/// </java-name>
				[Dot42.DexImport("marshall", "()[B", AccessFlags = 273)]
				public sbyte[] JavaMarshall() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// marshall
				/// </java-name>
				[Dot42.DexImport("marshall", "()[B", AccessFlags = 273, IgnoreFromJava = true)]
				public byte[] Marshall() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// unmarshall
				/// </java-name>
				[Dot42.DexImport("unmarshall", "([BII)V", AccessFlags = 273)]
				public void Unmarshall(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unmarshall
				/// </java-name>
				[Dot42.DexImport("unmarshall", "([BII)V", AccessFlags = 273, IgnoreFromJava = true)]
				public void Unmarshall(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendFrom
				/// </java-name>
				[Dot42.DexImport("appendFrom", "(Landroid/os/Parcel;II)V", AccessFlags = 273)]
				public void AppendFrom(global::Android.OS.Parcel parcel, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeInterfaceToken
				/// </java-name>
				[Dot42.DexImport("writeInterfaceToken", "(Ljava/lang/String;)V", AccessFlags = 273)]
				public void WriteInterfaceToken(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceInterface
				/// </java-name>
				[Dot42.DexImport("enforceInterface", "(Ljava/lang/String;)V", AccessFlags = 273)]
				public void EnforceInterface(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([B)V", AccessFlags = 17)]
				public void WriteByteArray(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByteArray(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([BII)V", AccessFlags = 17)]
				public void WriteByteArray(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByteArray
				/// </java-name>
				[Dot42.DexImport("writeByteArray", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByteArray(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 273)]
				public void WriteInt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 273)]
				public void WriteLong(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 273)]
				public void WriteFloat(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 273)]
				public void WriteDouble(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeString
				/// </java-name>
				[Dot42.DexImport("writeString", "(Ljava/lang/String;)V", AccessFlags = 273)]
				public void WriteString(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStrongBinder
				/// </java-name>
				[Dot42.DexImport("writeStrongBinder", "(Landroid/os/IBinder;)V", AccessFlags = 273)]
				public void WriteStrongBinder(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStrongInterface
				/// </java-name>
				[Dot42.DexImport("writeStrongInterface", "(Landroid/os/IInterface;)V", AccessFlags = 17)]
				public void WriteStrongInterface(global::Android.OS.IInterface @interface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("writeFileDescriptor", "(Ljava/io/FileDescriptor;)V", AccessFlags = 273)]
				public void WriteFileDescriptor(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 17)]
				public void WriteByte(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void WriteByte(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeMap
				/// </java-name>
				[Dot42.DexImport("writeMap", "(Ljava/util/Map;)V", AccessFlags = 17)]
				public void WriteMap(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBundle
				/// </java-name>
				[Dot42.DexImport("writeBundle", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void WriteBundle(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeList
				/// </java-name>
				[Dot42.DexImport("writeList", "(Ljava/util/List;)V", AccessFlags = 17)]
				public void WriteList(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeArray
				/// </java-name>
				[Dot42.DexImport("writeArray", "([Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteArray(object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeSparseArray
				/// </java-name>
				[Dot42.DexImport("writeSparseArray", "(Landroid/util/SparseArray;)V", AccessFlags = 17, Signature = "(Landroid/util/SparseArray<Ljava/lang/Object;>;)V")]
				public void WriteSparseArray(global::Android.Util.SparseArray<object> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeSparseBooleanArray
				/// </java-name>
				[Dot42.DexImport("writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V", AccessFlags = 17)]
				public void WriteSparseBooleanArray(global::Android.Util.SparseBooleanArray sparseBooleanArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBooleanArray
				/// </java-name>
				[Dot42.DexImport("writeBooleanArray", "([Z)V", AccessFlags = 17)]
				public void WriteBooleanArray(bool[] boolean) /* MethodBuilder.Create */ 
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
				public void ReadBooleanArray(bool[] boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeCharArray
				/// </java-name>
				[Dot42.DexImport("writeCharArray", "([C)V", AccessFlags = 17)]
				public void WriteCharArray(char[] @char) /* MethodBuilder.Create */ 
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
				public void ReadCharArray(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeIntArray
				/// </java-name>
				[Dot42.DexImport("writeIntArray", "([I)V", AccessFlags = 17)]
				public void WriteIntArray(int[] int32) /* MethodBuilder.Create */ 
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
				public void ReadIntArray(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLongArray
				/// </java-name>
				[Dot42.DexImport("writeLongArray", "([J)V", AccessFlags = 17)]
				public void WriteLongArray(long[] int64) /* MethodBuilder.Create */ 
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
				public void ReadLongArray(long[] int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloatArray
				/// </java-name>
				[Dot42.DexImport("writeFloatArray", "([F)V", AccessFlags = 17)]
				public void WriteFloatArray(float[] single) /* MethodBuilder.Create */ 
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
				public void ReadFloatArray(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDoubleArray
				/// </java-name>
				[Dot42.DexImport("writeDoubleArray", "([D)V", AccessFlags = 17)]
				public void WriteDoubleArray(double[] @double) /* MethodBuilder.Create */ 
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
				public void ReadDoubleArray(double[] @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStringArray
				/// </java-name>
				[Dot42.DexImport("writeStringArray", "([Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteStringArray(string[] @string) /* MethodBuilder.Create */ 
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
				public void ReadStringArray(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBinderArray
				/// </java-name>
				[Dot42.DexImport("writeBinderArray", "([Landroid/os/IBinder;)V", AccessFlags = 17)]
				public void WriteBinderArray(global::Android.OS.IBinder[] binder) /* MethodBuilder.Create */ 
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
				public void ReadBinderArray(global::Android.OS.IBinder[] binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTypedList
				/// </java-name>
				[Dot42.DexImport("writeTypedList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>(Ljava/util/List<TT;>;)V")]
				public void WriteTypedList<T>(global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStringList
				/// </java-name>
				[Dot42.DexImport("writeStringList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public void WriteStringList(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBinderList
				/// </java-name>
				[Dot42.DexImport("writeBinderList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/os/IBinder;>;)V")]
				public void WriteBinderList(global::Java.Util.IList<global::Android.OS.IBinder> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTypedArray
				/// </java-name>
				[Dot42.DexImport("writeTypedArray", "([Landroid/os/Parcelable;I)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>([TT;I)V")]
				public void WriteTypedArray<T>(T[] p, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeValue
				/// </java-name>
				[Dot42.DexImport("writeValue", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteValue(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeParcelable
				/// </java-name>
				[Dot42.DexImport("writeParcelable", "(Landroid/os/Parcelable;I)V", AccessFlags = 17)]
				public void WriteParcelable(global::Android.OS.IParcelable parcelable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeSerializable
				/// </java-name>
				[Dot42.DexImport("writeSerializable", "(Ljava/io/Serializable;)V", AccessFlags = 17)]
				public void WriteSerializable(global::Java.Io.ISerializable serializable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeException
				/// </java-name>
				[Dot42.DexImport("writeException", "(Ljava/lang/Exception;)V", AccessFlags = 17)]
				public void WriteException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeNoException
				/// </java-name>
				[Dot42.DexImport("writeNoException", "()V", AccessFlags = 17)]
				public void WriteNoException() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readException
				/// </java-name>
				[Dot42.DexImport("readException", "()V", AccessFlags = 17)]
				public void ReadException() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readException
				/// </java-name>
				[Dot42.DexImport("readException", "(ILjava/lang/String;)V", AccessFlags = 17)]
				public void ReadException(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 273)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 273)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 273)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 273)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// readString
				/// </java-name>
				[Dot42.DexImport("readString", "()Ljava/lang/String;", AccessFlags = 273)]
				public string ReadString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readStrongBinder
				/// </java-name>
				[Dot42.DexImport("readStrongBinder", "()Landroid/os/IBinder;", AccessFlags = 273)]
				public global::Android.OS.IBinder ReadStrongBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// readFileDescriptor
				/// </java-name>
				[Dot42.DexImport("readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 17)]
				public global::Android.OS.ParcelFileDescriptor ReadFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// readMap
				/// </java-name>
				[Dot42.DexImport("readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V", AccessFlags = 17)]
				public void ReadMap(global::Java.Util.IMap<object, object> map, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readList
				/// </java-name>
				[Dot42.DexImport("readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V", AccessFlags = 17)]
				public void ReadList(global::Java.Util.IList<object> list, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readHashMap
				/// </java-name>
				[Dot42.DexImport("readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;", AccessFlags = 17)]
				public global::Java.Util.HashMap<object, object> ReadHashMap(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.HashMap<object, object>);
				}

				/// <java-name>
				/// readBundle
				/// </java-name>
				[Dot42.DexImport("readBundle", "()Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle ReadBundle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// readBundle
				/// </java-name>
				[Dot42.DexImport("readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle ReadBundle(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// createByteArray
				/// </java-name>
				[Dot42.DexImport("createByteArray", "()[B", AccessFlags = 273)]
				public sbyte[] JavaCreateByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// createByteArray
				/// </java-name>
				[Dot42.DexImport("createByteArray", "()[B", AccessFlags = 273, IgnoreFromJava = true)]
				public byte[] CreateByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// readByteArray
				/// </java-name>
				[Dot42.DexImport("readByteArray", "([B)V", AccessFlags = 17)]
				public void ReadByteArray(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readByteArray
				/// </java-name>
				[Dot42.DexImport("readByteArray", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadByteArray(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readArrayList
				/// </java-name>
				[Dot42.DexImport("readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;", AccessFlags = 17)]
				public global::Java.Util.ArrayList<object> ReadArrayList(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<object>);
				}

				/// <java-name>
				/// readArray
				/// </java-name>
				[Dot42.DexImport("readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;", AccessFlags = 17)]
				public object[] ReadArray(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// readSparseArray
				/// </java-name>
				[Dot42.DexImport("readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;", AccessFlags = 17)]
				public global::Android.Util.SparseArray<object> ReadSparseArray(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseArray<object>);
				}

				/// <java-name>
				/// readSparseBooleanArray
				/// </java-name>
				[Dot42.DexImport("readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;", AccessFlags = 17)]
				public global::Android.Util.SparseBooleanArray ReadSparseBooleanArray() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.SparseBooleanArray);
				}

				/// <java-name>
				/// createTypedArrayList
				/// </java-name>
				[Dot42.DexImport("createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Landroid/os/Parcelable$Creator<TT;>;)Ljava/util/ArrayList<" +
    "TT;>;")]
				public global::Java.Util.ArrayList<T> CreateTypedArrayList<T>(global::Android.OS.IParcelable_ICreator<T> parcelable_ICreator) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <java-name>
				/// readTypedList
				/// </java-name>
				[Dot42.DexImport("readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;Landroid/os/Parcelable$Creator<TT;>;)" +
    "V")]
				public void ReadTypedList<T>(global::Java.Util.IList<T> list, global::Android.OS.IParcelable_ICreator<T> parcelable_ICreator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createStringArrayList
				/// </java-name>
				[Dot42.DexImport("createStringArrayList", "()Ljava/util/ArrayList;", AccessFlags = 17, Signature = "()Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> CreateStringArrayList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <java-name>
				/// createBinderArrayList
				/// </java-name>
				[Dot42.DexImport("createBinderArrayList", "()Ljava/util/ArrayList;", AccessFlags = 17, Signature = "()Ljava/util/ArrayList<Landroid/os/IBinder;>;")]
				public global::Java.Util.ArrayList<global::Android.OS.IBinder> CreateBinderArrayList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.OS.IBinder>);
				}

				/// <java-name>
				/// readStringList
				/// </java-name>
				[Dot42.DexImport("readStringList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public void ReadStringList(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readBinderList
				/// </java-name>
				[Dot42.DexImport("readBinderList", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/os/IBinder;>;)V")]
				public void ReadBinderList(global::Java.Util.IList<global::Android.OS.IBinder> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createTypedArray
				/// </java-name>
				[Dot42.DexImport("createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>(Landroid/os/Parcelable$Creator<TT;>;)[TT;")]
				public T[] CreateTypedArray<T>(global::Android.OS.IParcelable_ICreator<T> parcelable_ICreator) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// readTypedArray
				/// </java-name>
				[Dot42.DexImport("readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V", AccessFlags = 17, Signature = "<T:Ljava/lang/Object;>([TT;Landroid/os/Parcelable$Creator<TT;>;)V")]
				public void ReadTypedArray<T>(T[] p, global::Android.OS.IParcelable_ICreator<T> parcelable_ICreator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeParcelableArray
				/// </java-name>
				[Dot42.DexImport("writeParcelableArray", "([Landroid/os/Parcelable;I)V", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>([TT;I)V")]
				public void WriteParcelableArray<T>(T[] p, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readValue
				/// </java-name>
				[Dot42.DexImport("readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;", AccessFlags = 17)]
				public object ReadValue(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// readParcelable
				/// </java-name>
				[Dot42.DexImport("readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;", AccessFlags = 17, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/ClassLoader;)TT;")]
				public T ReadParcelable<T>(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// readParcelableArray
				/// </java-name>
				[Dot42.DexImport("readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;", AccessFlags = 17)]
				public global::Android.OS.IParcelable[] ReadParcelableArray(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable[]);
				}

				/// <java-name>
				/// readSerializable
				/// </java-name>
				[Dot42.DexImport("readSerializable", "()Ljava/io/Serializable;", AccessFlags = 17)]
				public global::Java.Io.ISerializable ReadSerializable() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ISerializable);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/os/Parcel;", AccessFlags = 28)]
				internal static global::Android.OS.Parcel Obtain(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Parcel);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Parcel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				public bool HasFileDescriptors
				{
						[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 273)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/os/ParcelFileDescriptor
		/// </java-name>
		[Dot42.DexImport("android/os/ParcelFileDescriptor", AccessFlags = 33)]
		public partial class ParcelFileDescriptor : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_WORLD_READABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_READABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_READABLE = 1;
				/// <java-name>
				/// MODE_WORLD_WRITEABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_WRITEABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_WRITEABLE = 2;
				/// <java-name>
				/// MODE_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_READ_ONLY", "I", AccessFlags = 25)]
				public const int MODE_READ_ONLY = 268435456;
				/// <java-name>
				/// MODE_WRITE_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_WRITE_ONLY", "I", AccessFlags = 25)]
				public const int MODE_WRITE_ONLY = 536870912;
				/// <java-name>
				/// MODE_READ_WRITE
				/// </java-name>
				[Dot42.DexImport("MODE_READ_WRITE", "I", AccessFlags = 25)]
				public const int MODE_READ_WRITE = 805306368;
				/// <java-name>
				/// MODE_CREATE
				/// </java-name>
				[Dot42.DexImport("MODE_CREATE", "I", AccessFlags = 25)]
				public const int MODE_CREATE = 134217728;
				/// <java-name>
				/// MODE_TRUNCATE
				/// </java-name>
				[Dot42.DexImport("MODE_TRUNCATE", "I", AccessFlags = 25)]
				public const int MODE_TRUNCATE = 67108864;
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
				[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public ParcelFileDescriptor(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/io/File;I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor Open(global::Java.Io.File file, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// dup
				/// </java-name>
				[Dot42.DexImport("dup", "(Ljava/io/FileDescriptor;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor Dup(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// dup
				/// </java-name>
				[Dot42.DexImport("dup", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor Dup() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// fromFd
				/// </java-name>
				[Dot42.DexImport("fromFd", "(I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromFd(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// adoptFd
				/// </java-name>
				[Dot42.DexImport("adoptFd", "(I)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor AdoptFd(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// fromSocket
				/// </java-name>
				[Dot42.DexImport("fromSocket", "(Ljava/net/Socket;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromSocket(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// fromDatagramSocket
				/// </java-name>
				[Dot42.DexImport("fromDatagramSocket", "(Ljava/net/DatagramSocket;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor FromDatagramSocket(global::Java.Net.DatagramSocket datagramSocket) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// createPipe
				/// </java-name>
				[Dot42.DexImport("createPipe", "()[Landroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor[] CreatePipe() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor[]);
				}

				/// <java-name>
				/// detachFd
				/// </java-name>
				[Dot42.DexImport("detachFd", "()I", AccessFlags = 1)]
				public virtual int DetachFd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParcelFileDescriptor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.Io.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.Io.FileDescriptor); }
				}

				/// <java-name>
				/// getStatSize
				/// </java-name>
				public virtual long StatSize
				{
						[Dot42.DexImport("getStatSize", "()J", AccessFlags = 257)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getFd
				/// </java-name>
				public virtual int Fd
				{
						[Dot42.DexImport("getFd", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/os/ParcelFileDescriptor$AutoCloseOutputStream
				/// </java-name>
				[Dot42.DexImport("android/os/ParcelFileDescriptor$AutoCloseOutputStream", AccessFlags = 9)]
				public partial class AutoCloseOutputStream : global::Java.Io.FileOutputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseOutputStream(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public override void Close() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AutoCloseOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/os/ParcelFileDescriptor$AutoCloseInputStream
				/// </java-name>
				[Dot42.DexImport("android/os/ParcelFileDescriptor$AutoCloseInputStream", AccessFlags = 9)]
				public partial class AutoCloseInputStream : global::Java.Io.FileInputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseInputStream(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public override void Close() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AutoCloseInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

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
				public ParcelFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				[Dot42.DexImport("<init>", "(Ljava/util/UUID;)V", AccessFlags = 1)]
				public ParcelUuid(global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fromString
				/// </java-name>
				[Dot42.DexImport("fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;", AccessFlags = 9)]
				public static global::Android.OS.ParcelUuid FromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelUuid);
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParcelUuid() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUuid
				/// </java-name>
				public global::Java.Util.UUID Uuid
				{
						[Dot42.DexImport("getUuid", "()Ljava/util/UUID;", AccessFlags = 1)]
						get{ return default(global::Java.Util.UUID); }
				}

		}

		/// <java-name>
		/// android/os/PatternMatcher
		/// </java-name>
		[Dot42.DexImport("android/os/PatternMatcher", AccessFlags = 33)]
		public partial class PatternMatcher : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PATTERN_LITERAL
				/// </java-name>
				[Dot42.DexImport("PATTERN_LITERAL", "I", AccessFlags = 25)]
				public const int PATTERN_LITERAL = 0;
				/// <java-name>
				/// PATTERN_PREFIX
				/// </java-name>
				[Dot42.DexImport("PATTERN_PREFIX", "I", AccessFlags = 25)]
				public const int PATTERN_PREFIX = 1;
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
				public PatternMatcher(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PatternMatcher(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Match(string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PatternMatcher() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// android/os/PowerManager
		/// </java-name>
		[Dot42.DexImport("android/os/PowerManager", AccessFlags = 33)]
		public partial class PowerManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARTIAL_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("PARTIAL_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int PARTIAL_WAKE_LOCK = 1;
				/// <java-name>
				/// FULL_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("FULL_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int FULL_WAKE_LOCK = 26;
				/// <java-name>
				/// SCREEN_BRIGHT_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("SCREEN_BRIGHT_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int SCREEN_BRIGHT_WAKE_LOCK = 10;
				/// <java-name>
				/// SCREEN_DIM_WAKE_LOCK
				/// </java-name>
				[Dot42.DexImport("SCREEN_DIM_WAKE_LOCK", "I", AccessFlags = 25)]
				public const int SCREEN_DIM_WAKE_LOCK = 6;
				/// <java-name>
				/// ACQUIRE_CAUSES_WAKEUP
				/// </java-name>
				[Dot42.DexImport("ACQUIRE_CAUSES_WAKEUP", "I", AccessFlags = 25)]
				public const int ACQUIRE_CAUSES_WAKEUP = 268435456;
				/// <java-name>
				/// ON_AFTER_RELEASE
				/// </java-name>
				[Dot42.DexImport("ON_AFTER_RELEASE", "I", AccessFlags = 25)]
				public const int ON_AFTER_RELEASE = 536870912;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PowerManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newWakeLock
				/// </java-name>
				[Dot42.DexImport("newWakeLock", "(ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;", AccessFlags = 1)]
				public virtual global::Android.OS.PowerManager.WakeLock NewWakeLock(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.PowerManager.WakeLock);
				}

				/// <java-name>
				/// userActivity
				/// </java-name>
				[Dot42.DexImport("userActivity", "(JZ)V", AccessFlags = 1)]
				public virtual void UserActivity(long int64, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// goToSleep
				/// </java-name>
				[Dot42.DexImport("goToSleep", "(J)V", AccessFlags = 1)]
				public virtual void GoToSleep(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reboot
				/// </java-name>
				[Dot42.DexImport("reboot", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Reboot(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isScreenOn
				/// </java-name>
				public virtual bool IsScreenOn
				{
						[Dot42.DexImport("isScreenOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

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

						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "(J)V", AccessFlags = 1)]
						public virtual void Acquire(long int64) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWorkSource
						/// </java-name>
						[Dot42.DexImport("setWorkSource", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
						public virtual void SetWorkSource(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
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
						internal WakeLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

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

		/// <java-name>
		/// android/os/Process
		/// </java-name>
		[Dot42.DexImport("android/os/Process", AccessFlags = 33)]
		public partial class Process
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SYSTEM_UID
				/// </java-name>
				[Dot42.DexImport("SYSTEM_UID", "I", AccessFlags = 25)]
				public const int SYSTEM_UID = 1000;
				/// <java-name>
				/// PHONE_UID
				/// </java-name>
				[Dot42.DexImport("PHONE_UID", "I", AccessFlags = 25)]
				public const int PHONE_UID = 1001;
				/// <java-name>
				/// FIRST_APPLICATION_UID
				/// </java-name>
				[Dot42.DexImport("FIRST_APPLICATION_UID", "I", AccessFlags = 25)]
				public const int FIRST_APPLICATION_UID = 10000;
				/// <java-name>
				/// LAST_APPLICATION_UID
				/// </java-name>
				[Dot42.DexImport("LAST_APPLICATION_UID", "I", AccessFlags = 25)]
				public const int LAST_APPLICATION_UID = 99999;
				/// <java-name>
				/// BLUETOOTH_GID
				/// </java-name>
				[Dot42.DexImport("BLUETOOTH_GID", "I", AccessFlags = 25)]
				public const int BLUETOOTH_GID = 2000;
				/// <java-name>
				/// THREAD_PRIORITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_DEFAULT", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_DEFAULT = 0;
				/// <java-name>
				/// THREAD_PRIORITY_LOWEST
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_LOWEST", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_LOWEST = 19;
				/// <java-name>
				/// THREAD_PRIORITY_BACKGROUND
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_BACKGROUND", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_BACKGROUND = 10;
				/// <java-name>
				/// THREAD_PRIORITY_FOREGROUND
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_FOREGROUND", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_FOREGROUND = -2;
				/// <java-name>
				/// THREAD_PRIORITY_DISPLAY
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_DISPLAY", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_DISPLAY = -4;
				/// <java-name>
				/// THREAD_PRIORITY_URGENT_DISPLAY
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_URGENT_DISPLAY", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_URGENT_DISPLAY = -8;
				/// <java-name>
				/// THREAD_PRIORITY_AUDIO
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_AUDIO", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_AUDIO = -16;
				/// <java-name>
				/// THREAD_PRIORITY_URGENT_AUDIO
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_URGENT_AUDIO", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_URGENT_AUDIO = -19;
				/// <java-name>
				/// THREAD_PRIORITY_MORE_FAVORABLE
				/// </java-name>
				[Dot42.DexImport("THREAD_PRIORITY_MORE_FAVORABLE", "I", AccessFlags = 25)]
				public const int THREAD_PRIORITY_MORE_FAVORABLE = -1;
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

				/// <java-name>
				/// myPid
				/// </java-name>
				[Dot42.DexImport("myPid", "()I", AccessFlags = 281)]
				public static int MyPid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// myTid
				/// </java-name>
				[Dot42.DexImport("myTid", "()I", AccessFlags = 281)]
				public static int MyTid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// myUid
				/// </java-name>
				[Dot42.DexImport("myUid", "()I", AccessFlags = 281)]
				public static int MyUid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUidForName
				/// </java-name>
				[Dot42.DexImport("getUidForName", "(Ljava/lang/String;)I", AccessFlags = 281)]
				public static int GetUidForName(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGidForName
				/// </java-name>
				[Dot42.DexImport("getGidForName", "(Ljava/lang/String;)I", AccessFlags = 281)]
				public static int GetGidForName(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setThreadPriority
				/// </java-name>
				[Dot42.DexImport("setThreadPriority", "(II)V", AccessFlags = 281)]
				public static void SetThreadPriority(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setThreadPriority
				/// </java-name>
				[Dot42.DexImport("setThreadPriority", "(I)V", AccessFlags = 281)]
				public static void SetThreadPriority(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThreadPriority
				/// </java-name>
				[Dot42.DexImport("getThreadPriority", "(I)I", AccessFlags = 281)]
				public static int GetThreadPriority(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// supportsProcesses
				/// </java-name>
				[Dot42.DexImport("supportsProcesses", "()Z", AccessFlags = 25)]
				public static bool SupportsProcesses() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// killProcess
				/// </java-name>
				[Dot42.DexImport("killProcess", "(I)V", AccessFlags = 25)]
				public static void KillProcess(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendSignal
				/// </java-name>
				[Dot42.DexImport("sendSignal", "(II)V", AccessFlags = 281)]
				public static void SendSignal(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getElapsedCpuTime
				/// </java-name>
				public static long ElapsedCpuTime
				{
						[Dot42.DexImport("getElapsedCpuTime", "()J", AccessFlags = 281)]
						get{ return default(long); }
				}

		}

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

				/// <java-name>
				/// verifyPackage
				/// </java-name>
				[Dot42.DexImport("verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V", AccessFlags = 9)]
				public static void VerifyPackage(global::Java.Io.File file, global::Android.OS.RecoverySystem.IProgressListener progressListener, global::Java.Io.File file1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// installPackage
				/// </java-name>
				[Dot42.DexImport("installPackage", "(Landroid/content/Context;Ljava/io/File;)V", AccessFlags = 9)]
				public static void InstallPackage(global::Android.Content.Context context, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rebootWipeUserData
				/// </java-name>
				[Dot42.DexImport("rebootWipeUserData", "(Landroid/content/Context;)V", AccessFlags = 9)]
				public static void RebootWipeUserData(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rebootWipeCache
				/// </java-name>
				[Dot42.DexImport("rebootWipeCache", "(Landroid/content/Context;)V", AccessFlags = 9)]
				public static void RebootWipeCache(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/os/RecoverySystem$ProgressListener
				/// </java-name>
				[Dot42.DexImport("android/os/RecoverySystem$ProgressListener", AccessFlags = 1545)]
				public partial interface IProgressListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onProgress
						/// </java-name>
						[Dot42.DexImport("onProgress", "(I)V", AccessFlags = 1025)]
						void OnProgress(int int32) /* MethodBuilder.Create */ ;

				}

		}

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

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/os/IInterface;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Register(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z", AccessFlags = 1, Signature = "(TE;Ljava/lang/Object;)Z")]
				public virtual bool Register(E e, object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Landroid/os/IInterface;)Z", AccessFlags = 1, Signature = "(TE;)Z")]
				public virtual bool Unregister(E e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// kill
				/// </java-name>
				[Dot42.DexImport("kill", "()V", AccessFlags = 1)]
				public virtual void Kill() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCallbackDied
				/// </java-name>
				[Dot42.DexImport("onCallbackDied", "(Landroid/os/IInterface;)V", AccessFlags = 1, Signature = "(TE;)V")]
				public virtual void OnCallbackDied(E e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCallbackDied
				/// </java-name>
				[Dot42.DexImport("onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TE;Ljava/lang/Object;)V")]
				public virtual void OnCallbackDied(E e, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginBroadcast
				/// </java-name>
				[Dot42.DexImport("beginBroadcast", "()I", AccessFlags = 1)]
				public virtual int BeginBroadcast() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBroadcastItem
				/// </java-name>
				[Dot42.DexImport("getBroadcastItem", "(I)Landroid/os/IInterface;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E GetBroadcastItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <java-name>
				/// getBroadcastCookie
				/// </java-name>
				[Dot42.DexImport("getBroadcastCookie", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetBroadcastCookie(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// finishBroadcast
				/// </java-name>
				[Dot42.DexImport("finishBroadcast", "()V", AccessFlags = 1)]
				public virtual void FinishBroadcast() /* MethodBuilder.Create */ 
				{
				}

		}

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
				public RemoteException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public ResultReceiver(global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void Send(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceiveResult
				/// </java-name>
				[Dot42.DexImport("onReceiveResult", "(ILandroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnReceiveResult(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ResultReceiver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/os/StatFs
		/// </java-name>
		[Dot42.DexImport("android/os/StatFs", AccessFlags = 33)]
		public partial class StatFs
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StatFs(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restat
				/// </java-name>
				[Dot42.DexImport("restat", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Restat(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~StatFs() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StatFs() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBlockSize
				/// </java-name>
				public virtual int BlockSize
				{
						[Dot42.DexImport("getBlockSize", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBlockCount
				/// </java-name>
				public virtual int BlockCount
				{
						[Dot42.DexImport("getBlockCount", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFreeBlocks
				/// </java-name>
				public virtual int FreeBlocks
				{
						[Dot42.DexImport("getFreeBlocks", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAvailableBlocks
				/// </java-name>
				public virtual int AvailableBlocks
				{
						[Dot42.DexImport("getAvailableBlocks", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

		}

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

				/// <java-name>
				/// setThreadPolicy
				/// </java-name>
				[Dot42.DexImport("setThreadPolicy", "(Landroid/os/StrictMode$ThreadPolicy;)V", AccessFlags = 9)]
				public static void SetThreadPolicy(global::Android.OS.StrictMode.ThreadPolicy threadPolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThreadPolicy
				/// </java-name>
				[Dot42.DexImport("getThreadPolicy", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy GetThreadPolicy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <java-name>
				/// allowThreadDiskWrites
				/// </java-name>
				[Dot42.DexImport("allowThreadDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy AllowThreadDiskWrites() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <java-name>
				/// allowThreadDiskReads
				/// </java-name>
				[Dot42.DexImport("allowThreadDiskReads", "()Landroid/os/StrictMode$ThreadPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.ThreadPolicy AllowThreadDiskReads() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.ThreadPolicy);
				}

				/// <java-name>
				/// setVmPolicy
				/// </java-name>
				[Dot42.DexImport("setVmPolicy", "(Landroid/os/StrictMode$VmPolicy;)V", AccessFlags = 9)]
				public static void SetVmPolicy(global::Android.OS.StrictMode.VmPolicy vmPolicy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVmPolicy
				/// </java-name>
				[Dot42.DexImport("getVmPolicy", "()Landroid/os/StrictMode$VmPolicy;", AccessFlags = 9)]
				public static global::Android.OS.StrictMode.VmPolicy GetVmPolicy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.StrictMode.VmPolicy);
				}

				/// <java-name>
				/// enableDefaults
				/// </java-name>
				[Dot42.DexImport("enableDefaults", "()V", AccessFlags = 9)]
				public static void EnableDefaults() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// noteSlowCall
				/// </java-name>
				[Dot42.DexImport("noteSlowCall", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void NoteSlowCall(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/os/StrictMode$VmPolicy
				/// </java-name>
				[Dot42.DexImport("android/os/StrictMode$VmPolicy", AccessFlags = 25)]
				public sealed partial class VmPolicy
 /* scope: __dot42__ */ 
				{
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

								/// <java-name>
								/// setClassInstanceLimit
								/// </java-name>
								[Dot42.DexImport("setClassInstanceLimit", "(Ljava/lang/Class;I)Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder SetClassInstanceLimit(global::System.Type type, int int32) /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectActivityLeaks
								/// </java-name>
								[Dot42.DexImport("detectActivityLeaks", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectActivityLeaks() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectAll
								/// </java-name>
								[Dot42.DexImport("detectAll", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectLeakedSqlLiteObjects
								/// </java-name>
								[Dot42.DexImport("detectLeakedSqlLiteObjects", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectLeakedSqlLiteObjects() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectLeakedClosableObjects
								/// </java-name>
								[Dot42.DexImport("detectLeakedClosableObjects", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectLeakedClosableObjects() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDeath
								/// </java-name>
								[Dot42.DexImport("penaltyDeath", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeath() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyLog
								/// </java-name>
								[Dot42.DexImport("penaltyLog", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyLog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDropBox
								/// </java-name>
								[Dot42.DexImport("penaltyDropBox", "()Landroid/os/StrictMode$VmPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDropBox() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

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

				/// <java-name>
				/// android/os/StrictMode$ThreadPolicy
				/// </java-name>
				[Dot42.DexImport("android/os/StrictMode$ThreadPolicy", AccessFlags = 25)]
				public sealed partial class ThreadPolicy
 /* scope: __dot42__ */ 
				{
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

								/// <java-name>
								/// detectAll
								/// </java-name>
								[Dot42.DexImport("detectAll", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// permitAll
								/// </java-name>
								[Dot42.DexImport("permitAll", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitAll() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectNetwork
								/// </java-name>
								[Dot42.DexImport("detectNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// permitNetwork
								/// </java-name>
								[Dot42.DexImport("permitNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectDiskReads
								/// </java-name>
								[Dot42.DexImport("detectDiskReads", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectDiskReads() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// permitDiskReads
								/// </java-name>
								[Dot42.DexImport("permitDiskReads", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitDiskReads() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectCustomSlowCalls
								/// </java-name>
								[Dot42.DexImport("detectCustomSlowCalls", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectCustomSlowCalls() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// permitCustomSlowCalls
								/// </java-name>
								[Dot42.DexImport("permitCustomSlowCalls", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitCustomSlowCalls() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// detectDiskWrites
								/// </java-name>
								[Dot42.DexImport("detectDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder DetectDiskWrites() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// permitDiskWrites
								/// </java-name>
								[Dot42.DexImport("permitDiskWrites", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PermitDiskWrites() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDialog
								/// </java-name>
								[Dot42.DexImport("penaltyDialog", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDialog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDeath
								/// </java-name>
								[Dot42.DexImport("penaltyDeath", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeath() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDeathOnNetwork
								/// </java-name>
								[Dot42.DexImport("penaltyDeathOnNetwork", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDeathOnNetwork() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyFlashScreen
								/// </java-name>
								[Dot42.DexImport("penaltyFlashScreen", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyFlashScreen() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyLog
								/// </java-name>
								[Dot42.DexImport("penaltyLog", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyLog() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

								/// <java-name>
								/// penaltyDropBox
								/// </java-name>
								[Dot42.DexImport("penaltyDropBox", "()Landroid/os/StrictMode$ThreadPolicy$Builder;", AccessFlags = 1)]
								public Builder PenaltyDropBox() /* MethodBuilder.Create */ 
								{
										return default(Builder);
								}

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

		/// <java-name>
		/// android/os/SystemClock
		/// </java-name>
		[Dot42.DexImport("android/os/SystemClock", AccessFlags = 49)]
		public sealed partial class SystemClock
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SystemClock() /* MethodBuilder.Create */ 
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
				/// setCurrentTimeMillis
				/// </java-name>
				[Dot42.DexImport("setCurrentTimeMillis", "(J)Z", AccessFlags = 265)]
				public static bool SetCurrentTimeMillis(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// uptimeMillis
				/// </java-name>
				[Dot42.DexImport("uptimeMillis", "()J", AccessFlags = 265)]
				public static long UptimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// elapsedRealtime
				/// </java-name>
				[Dot42.DexImport("elapsedRealtime", "()J", AccessFlags = 265)]
				public static long ElapsedRealtime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// currentThreadTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentThreadTimeMillis", "()J", AccessFlags = 265)]
				public static long CurrentThreadTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// android/os/TokenWatcher
		/// </java-name>
		[Dot42.DexImport("android/os/TokenWatcher", AccessFlags = 1057)]
		public abstract partial class TokenWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;Ljava/lang/String;)V", AccessFlags = 1)]
				public TokenWatcher(global::Android.OS.Handler handler, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquired
				/// </java-name>
				[Dot42.DexImport("acquired", "()V", AccessFlags = 1025)]
				public abstract void Acquired() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// released
				/// </java-name>
				[Dot42.DexImport("released", "()V", AccessFlags = 1025)]
				public abstract void Released() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// acquire
				/// </java-name>
				[Dot42.DexImport("acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Acquire(global::Android.OS.IBinder binder, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cleanup
				/// </java-name>
				[Dot42.DexImport("cleanup", "(Landroid/os/IBinder;Z)V", AccessFlags = 1)]
				public virtual void Cleanup(global::Android.OS.IBinder binder, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void Release(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "()V", AccessFlags = 1)]
				public virtual void Dump() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TokenWatcher() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// android/os/Vibrator
		/// </java-name>
		[Dot42.DexImport("android/os/Vibrator", AccessFlags = 33)]
		public partial class Vibrator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Vibrator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "(J)V", AccessFlags = 1)]
				public virtual void Vibrate(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "([JI)V", AccessFlags = 1)]
				public virtual void Vibrate(long[] int64, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasVibrator
				/// </java-name>
				public virtual bool HasVibrator
				{
						[Dot42.DexImport("hasVibrator", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WorkSource() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
				public WorkSource(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// diff
				/// </java-name>
				[Dot42.DexImport("diff", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Diff(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Add(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Landroid/os/WorkSource;)Z", AccessFlags = 1)]
				public virtual bool Remove(global::Android.OS.WorkSource workSource) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

}

