// Copyright (C) 2014 dot42
//
// Original filename: Android.Printservice.cs
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
namespace Android.Printservice
{
		/// <java-name>
		/// android/printservice/PrintService
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrintService", AccessFlags = 1057)]
		public abstract partial class PrintService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.printservice.PrintService";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.printservice";
				/// <java-name>
				/// EXTRA_PRINT_JOB_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_PRINT_JOB_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PRINT_JOB_INFO = "android.intent.extra.print.PRINT_JOB_INFO";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PrintService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachBaseContext
				/// </java-name>
				[Dot42.DexImport("attachBaseContext", "(Landroid/content/Context;)V", AccessFlags = 20)]
				protected internal override void AttachBaseContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConnected
				/// </java-name>
				[Dot42.DexImport("onConnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnConnected() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisconnected
				/// </java-name>
				[Dot42.DexImport("onDisconnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnDisconnected() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreatePrinterDiscoverySession
				/// </java-name>
				[Dot42.DexImport("onCreatePrinterDiscoverySession", "()Landroid/printservice/PrinterDiscoverySession;", AccessFlags = 1028)]
				protected internal abstract global::Android.Printservice.PrinterDiscoverySession OnCreatePrinterDiscoverySession() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRequestCancelPrintJob
				/// </java-name>
				[Dot42.DexImport("onRequestCancelPrintJob", "(Landroid/printservice/PrintJob;)V", AccessFlags = 1028)]
				protected internal abstract void OnRequestCancelPrintJob(global::Android.Printservice.PrintJob printJob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onPrintJobQueued
				/// </java-name>
				[Dot42.DexImport("onPrintJobQueued", "(Landroid/printservice/PrintJob;)V", AccessFlags = 1028)]
				protected internal abstract void OnPrintJobQueued(global::Android.Printservice.PrintJob printJob) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getActivePrintJobs
				/// </java-name>
				[Dot42.DexImport("getActivePrintJobs", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/printservice/PrintJob;>;")]
				public global::Java.Util.IList<global::Android.Printservice.PrintJob> GetActivePrintJobs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Printservice.PrintJob>);
				}

				/// <java-name>
				/// generatePrinterId
				/// </java-name>
				[Dot42.DexImport("generatePrinterId", "(Ljava/lang/String;)Landroid/print/PrinterId;", AccessFlags = 17)]
				public global::Android.Print.PrinterId GeneratePrinterId(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrinterId);
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// getActivePrintJobs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Printservice.PrintJob> ActivePrintJobs
				{
				[Dot42.DexImport("getActivePrintJobs", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/printservice/PrintJob;>;")]
						get{ return GetActivePrintJobs(); }
				}

		}

		/// <java-name>
		/// android/printservice/PrintDocument
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrintDocument", AccessFlags = 49)]
		public sealed partial class PrintDocument
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintDocumentInfo;", AccessFlags = 1)]
				public global::Android.Print.PrintDocumentInfo GetInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintDocumentInfo);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public global::Android.Os.ParcelFileDescriptor GetData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintDocumentInfo Info
				{
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintDocumentInfo;", AccessFlags = 1)]
						get{ return GetInfo(); }
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public global::Android.Os.ParcelFileDescriptor Data
				{
				[Dot42.DexImport("getData", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
						get{ return GetData(); }
				}

		}

		/// <java-name>
		/// android/printservice/PrinterDiscoverySession
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrinterDiscoverySession", AccessFlags = 1057)]
		public abstract partial class PrinterDiscoverySession
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PrinterDiscoverySession() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrinters
				/// </java-name>
				[Dot42.DexImport("getPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterInfo;>;")]
				public global::Java.Util.IList<global::Android.Print.PrinterInfo> GetPrinters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Print.PrinterInfo>);
				}

				/// <java-name>
				/// addPrinters
				/// </java-name>
				[Dot42.DexImport("addPrinters", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/print/PrinterInfo;>;)V")]
				public void AddPrinters(global::Java.Util.IList<global::Android.Print.PrinterInfo> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePrinters
				/// </java-name>
				[Dot42.DexImport("removePrinters", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public void RemovePrinters(global::Java.Util.IList<global::Android.Print.PrinterId> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartPrinterDiscovery
				/// </java-name>
				[Dot42.DexImport("onStartPrinterDiscovery", "(Ljava/util/List;)V", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public abstract void OnStartPrinterDiscovery(global::Java.Util.IList<global::Android.Print.PrinterId> list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStopPrinterDiscovery
				/// </java-name>
				[Dot42.DexImport("onStopPrinterDiscovery", "()V", AccessFlags = 1025)]
				public abstract void OnStopPrinterDiscovery() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onValidatePrinters
				/// </java-name>
				[Dot42.DexImport("onValidatePrinters", "(Ljava/util/List;)V", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public abstract void OnValidatePrinters(global::Java.Util.IList<global::Android.Print.PrinterId> list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStartPrinterStateTracking
				/// </java-name>
				[Dot42.DexImport("onStartPrinterStateTracking", "(Landroid/print/PrinterId;)V", AccessFlags = 1025)]
				public abstract void OnStartPrinterStateTracking(global::Android.Print.PrinterId printerId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStopPrinterStateTracking
				/// </java-name>
				[Dot42.DexImport("onStopPrinterStateTracking", "(Landroid/print/PrinterId;)V", AccessFlags = 1025)]
				public abstract void OnStopPrinterStateTracking(global::Android.Print.PrinterId printerId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTrackedPrinters
				/// </java-name>
				[Dot42.DexImport("getTrackedPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterId;>;")]
				public global::Java.Util.IList<global::Android.Print.PrinterId> GetTrackedPrinters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Print.PrinterId>);
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1025)]
				public abstract void OnDestroy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDestroyed
				/// </java-name>
				[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 17)]
				public bool IsDestroyed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isPrinterDiscoveryStarted
				/// </java-name>
				[Dot42.DexImport("isPrinterDiscoveryStarted", "()Z", AccessFlags = 17)]
				public bool IsPrinterDiscoveryStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPrinters
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrinterInfo> Printers
				{
				[Dot42.DexImport("getPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterInfo;>;")]
						get{ return GetPrinters(); }
				}

				/// <java-name>
				/// getTrackedPrinters
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrinterId> TrackedPrinters
				{
				[Dot42.DexImport("getTrackedPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterId;>;")]
						get{ return GetTrackedPrinters(); }
				}

		}

		/// <java-name>
		/// android/printservice/PrintJob
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrintJob", AccessFlags = 49)]
		public sealed partial class PrintJob
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PrintJob() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
				public global::Android.Print.PrintJobId GetId() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJobId);
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
				public global::Android.Print.PrintJobInfo GetInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrintJobInfo);
				}

				/// <java-name>
				/// getDocument
				/// </java-name>
				[Dot42.DexImport("getDocument", "()Landroid/printservice/PrintDocument;", AccessFlags = 1)]
				public global::Android.Printservice.PrintDocument GetDocument() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Printservice.PrintDocument);
				}

				/// <java-name>
				/// isQueued
				/// </java-name>
				[Dot42.DexImport("isQueued", "()Z", AccessFlags = 1)]
				public bool IsQueued() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBlocked
				/// </java-name>
				[Dot42.DexImport("isBlocked", "()Z", AccessFlags = 1)]
				public bool IsBlocked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCompleted
				/// </java-name>
				[Dot42.DexImport("isCompleted", "()Z", AccessFlags = 1)]
				public bool IsCompleted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFailed
				/// </java-name>
				[Dot42.DexImport("isFailed", "()Z", AccessFlags = 1)]
				public bool IsFailed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
				public bool IsCancelled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Z", AccessFlags = 1)]
				public bool Start() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Block(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// complete
				/// </java-name>
				[Dot42.DexImport("complete", "()Z", AccessFlags = 1)]
				public bool Complete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fail
				/// </java-name>
				[Dot42.DexImport("fail", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Fail(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
				public bool Cancel() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTag
				/// </java-name>
				[Dot42.DexImport("setTag", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool SetTag(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetTag() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAdvancedStringOption
				/// </java-name>
				[Dot42.DexImport("getAdvancedStringOption", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetAdvancedStringOption(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasAdvancedOption
				/// </java-name>
				[Dot42.DexImport("hasAdvancedOption", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool HasAdvancedOption(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAdvancedIntOption
				/// </java-name>
				[Dot42.DexImport("getAdvancedIntOption", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetAdvancedIntOption(string @string) /* MethodBuilder.Create */ 
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
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
				[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintJobInfo Info
				{
				[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
						get{ return GetInfo(); }
				}

				/// <java-name>
				/// getDocument
				/// </java-name>
				public global::Android.Printservice.PrintDocument Document
				{
				[Dot42.DexImport("getDocument", "()Landroid/printservice/PrintDocument;", AccessFlags = 1)]
						get{ return GetDocument(); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public string Tag
				{
				[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTag(); }
				}

		}

}


