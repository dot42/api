#pragma warning disable 1717
namespace Android.Printservice
{
		/// <summary>
		///  <para>This class represents a printed document from the perspective of a print service. It exposes APIs to query the document and obtain its data. </para> <para> <b>Note: </b> All methods of this class must be executed on the main application thread. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Gets the PrintDocumentInfo that describes this document.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The document info. </para>
				/// </returns>
				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintDocumentInfo Info
				{
						[Dot42.DexImport("getInfo", "()Landroid/print/PrintDocumentInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintDocumentInfo); }
				}

				/// <summary>
				///  <para>Gets the data associated with this document. </para> <para> <b>Note: </b> It is a responsibility of the client to open a stream to the returned file descriptor, fully read the data, and close the file descriptor. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A file descriptor for reading the data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public global::Android.OS.ParcelFileDescriptor Data
				{
						[Dot42.DexImport("getData", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Android.OS.ParcelFileDescriptor); }
				}

		}

		/// <summary>
		///  <para>This class encapsulates the interaction between a print service and the system during printer discovery. During printer discovery you are responsible for adding discovered printers, removing previously added printers that disappeared, and updating already added printers. </para> <para>During the lifetime of this session you may be asked to start and stop performing printer discovery multiple times. You will receive a call to PrinterDiscoverySession#onStartPrinterDiscovery(List) to start printer discovery and a call to PrinterDiscoverySession#onStopPrinterDiscovery() to stop printer discovery. When the system is no longer interested in printers discovered by this session you will receive a call to onDestroy() at which point the system will no longer call into the session and all the session methods will do nothing. </para> <para>Discovered printers are added by invoking PrinterDiscoverySession#addPrinters(List). Added printers that disappeared are removed by invoking PrinterDiscoverySession#removePrinters(List). Added printers whose properties or capabilities changed are updated through a call to PrinterDiscoverySession#addPrinters(List). The printers added in this session can be acquired via getPrinters() where the returned printers will be an up-to-date snapshot of the printers that you reported during the session. Printers are  <b>not</b> persisted across sessions. </para> <para>The system will make a call to onValidatePrinters(List) if you need to update some printers. It is possible that you add a printer without specifying its capabilities. This enables you to avoid querying all discovered printers for their capabilities, rather querying the capabilities of a printer only if necessary. For example, the system will request that you update a printer if it gets selected by the user. When validating printers you do not need to provide the printers' capabilities but may do so. </para> <para>If the system is interested in being constantly updated for the state of a printer you will receive a call to onStartPrinterStateTracking(PrinterId) after which you will have to do a best effort to keep the system updated for changes in the printer state and capabilities. You also  <b>must</b> update the printer capabilities if you did not provide them when adding it, or the printer will be ignored. When the system is no longer interested in getting updates for a printer you will receive a call to PrinterId). </para> <para> <b>Note: </b> All callbacks in this class are executed on the main application thread. You also have to invoke any method of this class on the main application thread. </para>    
		/// </summary>
		/// <java-name>
		/// android/printservice/PrinterDiscoverySession
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrinterDiscoverySession", AccessFlags = 1057)]
		public abstract partial class PrinterDiscoverySession
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PrinterDiscoverySession() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds discovered printers. Adding an already added printer updates it. Removed printers can be added again. You can call this method multiple times during the life of this session. Duplicates will be ignored. </para> <para> <b>Note: </b> Calls to this method after the session is destroyed, that is after the onDestroy() callback, will be ignored. </para> <para> <para>#removePrinters(List) </para> <para>getPrinters() </para> <para>isDestroyed() </para></para>        
				/// </summary>
				/// <java-name>
				/// addPrinters
				/// </java-name>
				[Dot42.DexImport("addPrinters", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/print/PrinterInfo;>;)V")]
				public void AddPrinters(global::Java.Util.IList<global::Android.Print.PrinterInfo> printers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes added printers. Removing an already removed or never added printer has no effect. Removed printers can be added again. You can call this method multiple times during the lifetime of this session. </para> <para> <b>Note: </b> Calls to this method after the session is destroyed, that is after the onDestroy() callback, will be ignored. </para> <para> <para>#addPrinters(List) </para> <para>getPrinters() </para> <para>isDestroyed() </para></para>        
				/// </summary>
				/// <java-name>
				/// removePrinters
				/// </java-name>
				[Dot42.DexImport("removePrinters", "(Ljava/util/List;)V", AccessFlags = 17, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public void RemovePrinters(global::Java.Util.IList<global::Android.Print.PrinterId> printerIds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback asking you to start printer discovery. Discovered printers should be added via calling addPrinters(List). Added printers that disappeared should be removed via calling removePrinters(List). Added printers whose properties or capabilities changed should be updated via calling addPrinters(List). You will receive a call to onStopPrinterDiscovery() when you should stop printer discovery. </para> <para>During the lifetime of this session all printers that are known to your print service have to be added. The system does not retain any printers across sessions. However, if you were asked to start and then stop performing printer discovery in this session, then a subsequent discovering should not re-discover already discovered printers. You can get the printers reported during this session by calling getPrinters(). </para> <para> <b>Note: </b>You are also given a list of printers whose availability has to be checked first. For example, these printers could be the user's favorite ones, therefore they have to be verified first. You do  <b>not need</b> to provide the capabilities of the printers, rather verify whether they exist similarly to onValidatePrinters(List). </para> <para> <para>onStopPrinterDiscovery() </para> <para>#addPrinters(List) </para> <para>#removePrinters(List) </para> <para>isPrinterDiscoveryStarted() </para></para>        
				/// </summary>
				/// <java-name>
				/// onStartPrinterDiscovery
				/// </java-name>
				[Dot42.DexImport("onStartPrinterDiscovery", "(Ljava/util/List;)V", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public abstract void OnStartPrinterDiscovery(global::Java.Util.IList<global::Android.Print.PrinterId> priorityList) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback notifying you that you should stop printer discovery.</para> <para> <para>#onStartPrinterDiscovery(List) </para> <para>isPrinterDiscoveryStarted() </para></para>        
				/// </summary>
				/// <java-name>
				/// onStopPrinterDiscovery
				/// </java-name>
				[Dot42.DexImport("onStopPrinterDiscovery", "()V", AccessFlags = 1025)]
				public abstract void OnStopPrinterDiscovery() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback asking you to validate that the given printers are valid, that is they exist. You are responsible for checking whether these printers exist and for the ones that do exist notify the system via calling addPrinters(List). </para> <para> <b>Note: </b> You are  <b>not required</b> to provide the printer capabilities when updating the printers that do exist. </para> <para> <para>PrinterInfo.Builder::setCapabilities(PrinterCapabilitiesInfo) PrinterInfo.Builder.setCapabilities(PrinterCapabilitiesInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// onValidatePrinters
				/// </java-name>
				[Dot42.DexImport("onValidatePrinters", "(Ljava/util/List;)V", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/print/PrinterId;>;)V")]
				public abstract void OnValidatePrinters(global::Java.Util.IList<global::Android.Print.PrinterId> printerIds) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback asking you to start tracking the state of a printer. Tracking the state means that you should do a best effort to observe the state of this printer and notify the system if that state changes via calling addPrinters(List). </para> <para> <b>Note: </b> A printer can be initially added without its capabilities to avoid polling printers that the user will not select. However, after this method is called you are expected to update the printer  <b>including</b> its capabilities. Otherwise, the printer will be ignored. </para> <para>A scenario when you may be requested to track a printer's state is if the user selects that printer and the system has to present print options UI based on the printer's capabilities. In this case the user should be promptly informed if, for example, the printer becomes unavailable. </para> <para> <para>onStopPrinterStateTracking(PrinterId) </para> <para>PrinterInfo.Builder::setCapabilities(PrinterCapabilitiesInfo) PrinterInfo.Builder.setCapabilities(PrinterCapabilitiesInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// onStartPrinterStateTracking
				/// </java-name>
				[Dot42.DexImport("onStartPrinterStateTracking", "(Landroid/print/PrinterId;)V", AccessFlags = 1025)]
				public abstract void OnStartPrinterStateTracking(global::Android.Print.PrinterId printerId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback asking you to stop tracking the state of a printer. The passed in printer id is the one for which you received a call to onStartPrinterStateTracking(PrinterId).</para> <para> <para>onStartPrinterStateTracking(PrinterId) </para></para>        
				/// </summary>
				/// <java-name>
				/// onStopPrinterStateTracking
				/// </java-name>
				[Dot42.DexImport("onStopPrinterStateTracking", "(Landroid/print/PrinterId;)V", AccessFlags = 1025)]
				public abstract void OnStopPrinterStateTracking(global::Android.Print.PrinterId printerId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Notifies you that the session is destroyed. After this callback is invoked any calls to the methods of this class will be ignored, isDestroyed() will return true and you will also no longer receive callbacks.</para> <para> <para>isDestroyed() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1025)]
				public abstract void OnDestroy() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the printers reported in this session. For example, if you add two printers and remove one of them, the returned list will contain only the printer that was added but not removed. </para> <para> <b>Note: </b> Calls to this method after the session is destroyed, that is after the onDestroy() callback, will be ignored. </para> <para> <para>#addPrinters(List) </para> <para>#removePrinters(List) </para> <para>isDestroyed() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The printers.</para>
				/// </returns>
				/// <java-name>
				/// getPrinters
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrinterInfo> Printers
				{
						[Dot42.DexImport("getPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Print.PrinterInfo>); }
				}

				/// <summary>
				///  <para>Gets the printers that should be tracked. These are printers that are important to the user and for which you received a call to onStartPrinterStateTracking(PrinterId) asking you to observer their state and reporting it to the system via addPrinters(List). You will receive a call to onStopPrinterStateTracking(PrinterId) if you should stop tracking a printer. </para> <para> <b>Note: </b> Calls to this method after the session is destroyed, that is after the onDestroy() callback, will be ignored. </para> <para> <para>onStartPrinterStateTracking(PrinterId) </para> <para>onStopPrinterStateTracking(PrinterId) </para> <para>isDestroyed() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The printers.</para>
				/// </returns>
				/// <java-name>
				/// getTrackedPrinters
				/// </java-name>
				public global::Java.Util.IList<global::Android.Print.PrinterId> TrackedPrinters
				{
						[Dot42.DexImport("getTrackedPrinters", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/print/PrinterId;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Print.PrinterId>); }
				}

				/// <summary>
				///  <para>Gets whether the session is destroyed.</para> <para> <para>onDestroy() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the session is destroyed.</para>
				/// </returns>
				/// <java-name>
				/// isDestroyed
				/// </java-name>
				public bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether printer discovery is started.</para> <para> <para>#onStartPrinterDiscovery(List) </para> <para>onStopPrinterDiscovery() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether printer discovery is destroyed.</para>
				/// </returns>
				/// <java-name>
				/// isPrinterDiscoveryStarted
				/// </java-name>
				public bool IsPrinterDiscoveryStarted
				{
						[Dot42.DexImport("isPrinterDiscoveryStarted", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>This class represents a print job from the perspective of a print service. It provides APIs for observing the print job state and performing operations on the print job. </para> <para> <b>Note: </b> All methods of this class must be invoked on the main application thread. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Starts the print job. You should call this method if isQueued() or isBlocked() returns true and you started resumed printing.</para> <para> <para>isQueued() </para> <para>isBlocked() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the job was started.</para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Z", AccessFlags = 1)]
				public bool Start() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Blocks the print job. You should call this method if isStarted() or isBlocked() returns true and you need to block the print job. For example, the user has to add some paper to continue printing. To resume the print job call start().</para> <para> <para>isStarted() </para> <para>isBlocked() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the job was blocked.</para>
				/// </returns>
				/// <java-name>
				/// block
				/// </java-name>
				[Dot42.DexImport("block", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Block(string reason) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Completes the print job. You should call this method if isStarted() returns true and you are done printing.</para> <para> <para>isStarted() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the job as completed.</para>
				/// </returns>
				/// <java-name>
				/// complete
				/// </java-name>
				[Dot42.DexImport("complete", "()Z", AccessFlags = 1)]
				public bool Complete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Fails the print job. You should call this method if isQueued() or isStarted() or isBlocked() returns true you failed while printing.</para> <para> <para>isQueued() </para> <para>isStarted() </para> <para>isBlocked() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the job was failed.</para>
				/// </returns>
				/// <java-name>
				/// fail
				/// </java-name>
				[Dot42.DexImport("fail", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Fail(string error) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Cancels the print job. You should call this method if isQueued() or or #isBlocked() returns true and you canceled the print job as a response to a call to PrintService#onRequestCancelPrintJob(PrintJob).</para> <para> <para>isStarted() </para> <para>isQueued() </para> <para>isBlocked() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the job is canceled.</para>
				/// </returns>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
				public bool Cancel() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets a tag that is valid in the context of a PrintService and is not interpreted by the system. For example, a print service may set as a tag the key of the print job returned by a remote print server, if the printing is off handed to a cloud based service.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the tag was set, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// setTag
				/// </java-name>
				[Dot42.DexImport("setTag", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool SetTag(string tag) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the value of an advanced (printer specific) print option.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The option value. </para>
				/// </returns>
				/// <java-name>
				/// getAdvancedStringOption
				/// </java-name>
				[Dot42.DexImport("getAdvancedStringOption", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetAdvancedStringOption(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets whether this job has a given advanced (printer specific) print option.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the option is present. </para>
				/// </returns>
				/// <java-name>
				/// hasAdvancedOption
				/// </java-name>
				[Dot42.DexImport("hasAdvancedOption", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool HasAdvancedOption(string key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the value of an advanced (printer specific) print option.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The option value. </para>
				/// </returns>
				/// <java-name>
				/// getAdvancedIntOption
				/// </java-name>
				[Dot42.DexImport("getAdvancedIntOption", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetAdvancedIntOption(string key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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
				///  <para>Gets the unique print job id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public global::Android.Print.PrintJobId Id
				{
						[Dot42.DexImport("getId", "()Landroid/print/PrintJobId;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintJobId); }
				}

				/// <summary>
				///  <para>Gets the PrintJobInfo that describes this job. </para> <para> <b>Node:</b>The returned info object is a snapshot of the current print job state. Every call to this method returns a fresh info object that reflects the current print job state. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The print job info. </para>
				/// </returns>
				/// <java-name>
				/// getInfo
				/// </java-name>
				public global::Android.Print.PrintJobInfo Info
				{
						[Dot42.DexImport("getInfo", "()Landroid/print/PrintJobInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Print.PrintJobInfo); }
				}

				/// <summary>
				///  <para>Gets the printed document.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The document. </para>
				/// </returns>
				/// <java-name>
				/// getDocument
				/// </java-name>
				public global::Android.Printservice.PrintDocument Document
				{
						[Dot42.DexImport("getDocument", "()Landroid/printservice/PrintDocument;", AccessFlags = 1)]
						get{ return default(global::Android.Printservice.PrintDocument); }
				}

				/// <summary>
				///  <para>Gets whether this print job is queued. Such a print job is ready to be printed and can be started or cancelled.</para> <para> <para>start() </para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is queued.</para>
				/// </returns>
				/// <java-name>
				/// isQueued
				/// </java-name>
				public bool IsQueued
				{
						[Dot42.DexImport("isQueued", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is started. Such a print job is being printed and can be completed or canceled or failed.</para> <para> <para>complete() </para> <para>cancel() </para> <para>#fail(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is started.</para>
				/// </returns>
				/// <java-name>
				/// isStarted
				/// </java-name>
				public bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is blocked. Such a print job is halted due to an abnormal condition and can be started or canceled or failed.</para> <para> <para>start() </para> <para>cancel() </para> <para>#fail(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is blocked.</para>
				/// </returns>
				/// <java-name>
				/// isBlocked
				/// </java-name>
				public bool IsBlocked
				{
						[Dot42.DexImport("isBlocked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is completed. Such a print job is successfully printed. This is a final state.</para> <para> <para>complete() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is completed.</para>
				/// </returns>
				/// <java-name>
				/// isCompleted
				/// </java-name>
				public bool IsCompleted
				{
						[Dot42.DexImport("isCompleted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is failed. Such a print job is not successfully printed due to an error. This is a final state.</para> <para> <para>#fail(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is failed.</para>
				/// </returns>
				/// <java-name>
				/// isFailed
				/// </java-name>
				public bool IsFailed
				{
						[Dot42.DexImport("isFailed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets whether this print job is cancelled. Such a print job was cancelled as a result of a user request. This is a final state.</para> <para> <para>cancel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the print job is cancelled.</para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				public bool IsCancelled
				{
						[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the print job tag.</para> <para> <para>setTag(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The tag or null.</para>
				/// </returns>
				/// <java-name>
				/// getTag
				/// </java-name>
				public string Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>This is the base class for implementing print services. A print service knows how to discover and interact one or more printers via one or more protocols. </para> <para> <h3>Printer discovery</h3></para> <para>A print service is responsible for discovering printers, adding discovered printers, removing added printers, and updating added printers. When the system is interested in printers managed by your service it will call onCreatePrinterDiscoverySession() from which you must return a new PrinterDiscoverySession instance. The returned session encapsulates the interaction between the system and your service during printer discovery. For description of this interaction refer to the documentation for PrinterDiscoverySession. </para> <para>For every printer discovery session all printers have to be added since system does not retain printers across sessions. Hence, each printer known to this print service should be added only once during a discovery session. Only an already added printer can be removed or updated. Removed printers can be added again. </para> <para> <h3>Print jobs</h3></para> <para>When a new print job targeted to a printer managed by this print service is is queued, i.e. ready for processing by the print service, you will receive a call to onPrintJobQueued(PrintJob). The print service may handle the print job immediately or schedule that for an appropriate time in the future. The list of all active print jobs for this service is obtained by calling getActivePrintJobs(). Active print jobs are ones that are queued or started. </para> <para>A print service is responsible for setting a print job's state as appropriate while processing it. Initially, a print job is queued, i.e. PrintJob.isQueued() returns true, which means that the document to be printed is spooled by the system and the print service can begin processing it. You can obtain the printed document by calling PrintJob.getDocument() whose data is accessed via PrintDocument.getData(). After the print service starts printing the data it should set the print job's state to started by calling PrintJob#start() after which PrintJob.isStarted() would return true. Upon successful completion, the print job should be marked as completed by calling PrintJob.complete() after which PrintJob.isCompleted() would return true. In case of a failure, the print job should be marked as failed by calling PrintJob.fail( String) after which PrintJob.isFailed() would return true. </para> <para>If a print job is queued or started and the user requests to cancel it, the print service will receive a call to onRequestCancelPrintJob(PrintJob) which requests from the service to do best effort in canceling the job. In case the job is successfully canceled, its state has to be marked as cancelled by calling PrintJob.cancel() after which PrintJob.isCacnelled() would return true. </para> <para> <h3>Lifecycle</h3></para> <para>The lifecycle of a print service is managed exclusively by the system and follows the established service lifecycle. Additionally, starting or stopping a print service is triggered exclusively by an explicit user action through enabling or disabling it in the device settings. After the system binds to a print service, it calls onConnected(). This method can be overriden by clients to perform post binding setup. Also after the system unbinds from a print service, it calls onDisconnected(). This method can be overriden by clients to perform post unbinding cleanup. Your should not do any work after the system disconnected from your print service since the service can be killed at any time to reclaim memory. The system will not disconnect from a print service if there are active print jobs for the printers managed by it. </para> <para> <h3>Declaration</h3></para> <para>A print service is declared as any other service in an AndroidManifest.xml but it must also specify that it handles the android.content.Intent with action android.printservice.PrintService. Failure to declare this intent will cause the system to ignore the print service. Additionally, a print service must request the android.permission.BIND_PRINT_SERVICE permission to ensure that only the system can bind to it. Failure to declare this intent will cause the system to ignore the print service. Following is an example declaration: </para> <para> <pre>
		/// &lt;service android:name=".MyPrintService"
		///         android:permission="android.permission.BIND_PRINT_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.printservice.PrintService" /&gt;
		///     &lt;/intent-filter&gt;
		///     . . .
		/// &lt;/service&gt;
		/// </pre>  <h3>Configuration</h3></para> <para>A print service can be configured by specifying an optional settings activity which exposes service specific settings, an optional add printers activity which is used for manual addition of printers, vendor name ,etc. It is a responsibility of the system to launch the settings and add printers activities when appropriate. </para> <para>A print service is configured by providing a meta-data entry in the manifest when declaring the service. A service declaration with a meta-data tag is presented below:  <pre> &lt;service android:name=".MyPrintService"
		///         android:permission="android.permission.BIND_PRINT_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.printservice.PrintService" /&gt;
		///     &lt;/intent-filter&gt;
		///     &lt;meta-data android:name="android.printservice" android:resource="@xml/printservice" /&gt;
		/// &lt;/service&gt;</pre> </para> <para>For more details for how to configure your print service via the meta-data refer to SERVICE_META_DATA and  <code>&lt;print-service&gt;</code>. </para> <para> <b>Note: </b> All callbacks in this class are executed on the main application thread. You should also invoke any method of this class on the main application thread. </para>    
		/// </summary>
		/// <java-name>
		/// android/printservice/PrintService
		/// </java-name>
		[Dot42.DexImport("android/printservice/PrintService", AccessFlags = 1057)]
		public abstract partial class PrintService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Intent action that must be declared as handled by a service in its manifest for the system to recognize it as a print service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.printservice.PrintService";
				/// <summary>
				///  <para>Name under which a PrintService component publishes additional information about itself. This meta-data must reference a XML resource containing a  <code> &lt;print-service&gt;</code> tag. This is a sample XML file configuring a print service:  <pre> &lt;print-service
				///     android:vendor="SomeVendor"
				///     android:settingsActivity="foo.bar.MySettingsActivity"
				///     andorid:addPrintersActivity="foo.bar.MyAddPrintersActivity."
				///     . . .
				/// /&gt;</pre> </para> <para>For detailed configuration options that can be specified via the meta-data refer to android.R.styleable.PrintService. </para> <para>If you declare a settings or add a printers activity, they have to be exported, by setting the android.R.attr#exported activity attribute to  <code>true </code>. Also in case you want only the system to be able to start any of these activities you can specify that they request the android.permission .START_PRINT_SERVICE_CONFIG_ACTIVITY permission by setting the android.R.attr#permission activity attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.printservice";
				/// <summary>
				///  <para>If you declared an optional activity with advanced print options via the advancedPrintOptionsActivity attribute, this extra is used to pass in the currently constructed PrintJobInfo to your activity allowing you to modify it. After you are done, you must return the modified PrintJobInfo via the same extra. </para> <para>You cannot modify the passed in PrintJobInfo directly, rather you should build another one using the PrintJobInfo.Builder class. You can specify any standard properties and add advanced, printer specific, ones via PrintJobInfo.Builder#putAdvancedOption(String, String) and PrintJobInfo.Builder#putAdvancedOption(String, int). The advanced options are not interpreted by the system, they will not be visible to applications, and can only be accessed by your print service via PrintJob.getAdvancedStringOption(String) and PrintJob.getAdvancedIntOption(String). </para> <para>If the advanced print options activity offers changes to the standard print options, you can get the current android.print.PrinterInfo using the "android.intent.extra.print.EXTRA_PRINTER_INFO" extra which will allow you to present the user with UI options supported by the current printer. For example, if the current printer does not support a give media size, you should not offer it in the advanced print options dialog. </para>        
				/// </summary>
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
				protected internal override void AttachBaseContext(global::Android.Content.Context @base) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The system has connected to this service. </para>        
				/// </summary>
				/// <java-name>
				/// onConnected
				/// </java-name>
				[Dot42.DexImport("onConnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnConnected() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The system has disconnected from this service. </para>        
				/// </summary>
				/// <java-name>
				/// onDisconnected
				/// </java-name>
				[Dot42.DexImport("onDisconnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnDisconnected() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback asking you to create a new PrinterDiscoverySession.</para> <para> <para>PrinterDiscoverySession </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreatePrinterDiscoverySession
				/// </java-name>
				[Dot42.DexImport("onCreatePrinterDiscoverySession", "()Landroid/printservice/PrinterDiscoverySession;", AccessFlags = 1028)]
				protected internal abstract global::Android.Printservice.PrinterDiscoverySession OnCreatePrinterDiscoverySession() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when cancellation of a print job is requested. The service should do best effort to fulfill the request. After the cancellation is performed, the print job should be marked as cancelled state by calling PrintJob#cancel().</para> <para> <para>PrintJob::cancel() PrintJob.cancel() </para> <para>PrintJob::isCancelled() PrintJob.isCancelled() </para></para>        
				/// </summary>
				/// <java-name>
				/// onRequestCancelPrintJob
				/// </java-name>
				[Dot42.DexImport("onRequestCancelPrintJob", "(Landroid/printservice/PrintJob;)V", AccessFlags = 1028)]
				protected internal abstract void OnRequestCancelPrintJob(global::Android.Printservice.PrintJob printJob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when there is a queued print job for one of the printers managed by this print service.</para> <para> <para>PrintJob::isQueued() PrintJob.isQueued() </para> <para>getActivePrintJobs() </para></para>        
				/// </summary>
				/// <java-name>
				/// onPrintJobQueued
				/// </java-name>
				[Dot42.DexImport("onPrintJobQueued", "(Landroid/printservice/PrintJob;)V", AccessFlags = 1028)]
				protected internal abstract void OnPrintJobQueued(global::Android.Printservice.PrintJob printJob) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates a global printer id given the printer's locally unique one.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Global printer id. </para>
				/// </returns>
				/// <java-name>
				/// generatePrinterId
				/// </java-name>
				[Dot42.DexImport("generatePrinterId", "(Ljava/lang/String;)Landroid/print/PrinterId;", AccessFlags = 17)]
				public global::Android.Print.PrinterId GeneratePrinterId(string localId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Print.PrinterId);
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Gets the active print jobs for the printers managed by this service. Active print jobs are ones that are not in a final state, i.e. whose state is queued or started.</para> <para> <para>PrintJob::isQueued() PrintJob.isQueued() </para> <para>PrintJob::isStarted() PrintJob.isStarted() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The active print jobs.</para>
				/// </returns>
				/// <java-name>
				/// getActivePrintJobs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Printservice.PrintJob> ActivePrintJobs
				{
						[Dot42.DexImport("getActivePrintJobs", "()Ljava/util/List;", AccessFlags = 17, Signature = "()Ljava/util/List<Landroid/printservice/PrintJob;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Printservice.PrintJob>); }
				}

		}

}

