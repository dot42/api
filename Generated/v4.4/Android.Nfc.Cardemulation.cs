#pragma warning disable 1717
namespace Android.Nfc.Cardemulation
{
		/// <summary>
		///  <para>This class can be used to query the state of NFC card emulation services.</para> <para>For a general introduction into NFC card emulation, please read the .</para> <para>Use of this class requires the PackageManager#FEATURE_NFC_HOST_CARD_EMULATION to be present on the device. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/cardemulation/CardEmulation
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/CardEmulation", AccessFlags = 49)]
		public sealed partial class CardEmulation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity action: ask the user to change the default card emulation service for a certain category. This will show a dialog that asks the user whether he wants to replace the current default service with the service identified with the ComponentName specified in EXTRA_SERVICE_COMPONENT, for the category specified in EXTRA_CATEGORY </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CHANGE_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ACTION_CHANGE_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CHANGE_DEFAULT = "android.nfc.cardemulation.action.ACTION_CHANGE_DEFAULT";
				/// <summary>
				///  <para>The category extra for ACTION_CHANGE_DEFAULT.</para> <para> <para>ACTION_CHANGE_DEFAULT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CATEGORY
				/// </java-name>
				[Dot42.DexImport("EXTRA_CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CATEGORY = "category";
				/// <summary>
				///  <para>The service ComponentName object passed in as an extra for ACTION_CHANGE_DEFAULT.</para> <para> <para>ACTION_CHANGE_DEFAULT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SERVICE_COMPONENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SERVICE_COMPONENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SERVICE_COMPONENT = "component";
				/// <summary>
				///  <para>Category used for NFC payment services. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_PAYMENT
				/// </java-name>
				[Dot42.DexImport("CATEGORY_PAYMENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_PAYMENT = "payment";
				/// <summary>
				///  <para>Category that can be used for all other card emulation services. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_OTHER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_OTHER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_OTHER = "other";
				/// <summary>
				///  <para>Return value for getSelectionModeForCategory(String).</para> <para>In this mode, the user has set a default service for this category.</para> <para>When using ISO-DEP card emulation with HostApduService or OffHostApduService, if a remote NFC device selects any of the Application IDs (AIDs) that the default service has registered in this category, that service will automatically be bound to to handle the transaction. </para>        
				/// </summary>
				/// <java-name>
				/// SELECTION_MODE_PREFER_DEFAULT
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_PREFER_DEFAULT", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_PREFER_DEFAULT = 0;
				/// <summary>
				///  <para>Return value for getSelectionModeForCategory(String).</para> <para>In this mode, when using ISO-DEP card emulation with HostApduService or OffHostApduService, whenever an Application ID (AID) of this category is selected, the user is asked which service he wants to use to handle the transaction, even if there is only one matching service. </para>        
				/// </summary>
				/// <java-name>
				/// SELECTION_MODE_ALWAYS_ASK
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_ALWAYS_ASK", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_ALWAYS_ASK = 1;
				/// <summary>
				///  <para>Return value for getSelectionModeForCategory(String).</para> <para>In this mode, when using ISO-DEP card emulation with HostApduService or OffHostApduService, the user will only be asked to select a service if the Application ID (AID) selected by the reader has been registered by multiple services. If there is only one service that has registered for the AID, that service will be invoked directly. </para>        
				/// </summary>
				/// <java-name>
				/// SELECTION_MODE_ASK_IF_CONFLICT
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_ASK_IF_CONFLICT", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_ASK_IF_CONFLICT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CardEmulation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper to get an instance of this class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para></para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/nfc/NfcAdapter;)Landroid/nfc/cardemulation/CardEmulation;", AccessFlags = 41)]
				public static global::Android.Nfc.Cardemulation.CardEmulation GetInstance(global::Android.Nfc.NfcAdapter adapter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Cardemulation.CardEmulation);
				}

				/// <summary>
				///  <para>Allows an application to query whether a service is currently the default service to handle a card emulation category.</para> <para>Note that if getSelectionModeForCategory(String) returns SELECTION_MODE_ALWAYS_ASK or SELECTION_MODE_ASK_IF_CONFLICT, this method will always return false. That is because in these selection modes a default can't be set at the category level. For categories where the selection mode is SELECTION_MODE_ALWAYS_ASK or SELECTION_MODE_ASK_IF_CONFLICT, use isDefaultServiceForAid(ComponentName, String) to determine whether a service is the default for a specific AID.</para> <para></para> <para>Requires the android.Manifest.permission#NFC permission. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether service is currently the default service for the category.</para>
				/// </returns>
				/// <java-name>
				/// isDefaultServiceForCategory
				/// </java-name>
				[Dot42.DexImport("isDefaultServiceForCategory", "(Landroid/content/ComponentName;Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsDefaultServiceForCategory(global::Android.Content.ComponentName service, string category) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Allows an application to query whether a service is currently the default handler for a specified ISO7816-4 Application ID.</para> <para></para> <para>Requires the android.Manifest.permission#NFC permission. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether the service is the default handler for the specified AID</para>
				/// </returns>
				/// <java-name>
				/// isDefaultServiceForAid
				/// </java-name>
				[Dot42.DexImport("isDefaultServiceForAid", "(Landroid/content/ComponentName;Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsDefaultServiceForAid(global::Android.Content.ComponentName service, string aid) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the service selection mode for the passed in category. Valid return values are: </para> <para>SELECTION_MODE_PREFER_DEFAULT the user has requested a default service for this category, which will be preferred. </para> <para>SELECTION_MODE_ALWAYS_ASK the user has requested to be asked every time what service he would like to use in this category. </para> <para>SELECTION_MODE_ASK_IF_CONFLICT the user will only be asked to pick a service if there is a conflict. </para>        
				/// </summary>
				/// <returns>
				///  <para>the selection mode for the passed in category </para>
				/// </returns>
				/// <java-name>
				/// getSelectionModeForCategory
				/// </java-name>
				[Dot42.DexImport("getSelectionModeForCategory", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetSelectionModeForCategory(string category) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>HostApduService is a convenience Service class that can be extended to emulate an NFC card inside an Android service component.</para> <para>  <h3>Developer Guide</h3></para> <para> For a general introduction into the topic of card emulation, please read the </para> <para> </para> <para> <h3>NFC Protocols</h3></para> <para>Cards emulated by this class are based on the NFC-Forum ISO-DEP protocol (based on ISO/IEC 14443-4) and support processing command Application Protocol Data Units (APDUs) as defined in the ISO/IEC 7816-4 specification.</para> <para> <h3>Service selection</h3></para> <para>When a remote NFC device wants to talk to your service, it sends a so-called "SELECT AID" APDU as defined in the ISO/IEC 7816-4 specification. The AID is an application identifier defined in ISO/IEC 7816-4.</para> <para>The registration procedure for AIDs is defined in the ISO/IEC 7816-5 specification. If you don't want to register an AID, you are free to use AIDs in the proprietary range: bits 8-5 of the first byte must each be set to '1'. For example, "0xF00102030405" is a proprietary AID. If you do use proprietary AIDs, it is recommended to choose an AID of at least 6 bytes, to reduce the risk of collisions with other applications that might be using proprietary AIDs as well.</para> <para> <h3>AID groups</h3></para> <para>In some cases, a service may need to register multiple AIDs to implement a certain application, and it needs to be sure that it is the default handler for all of these AIDs (as opposed to some AIDs in the group going to another service).</para> <para>An AID group is a list of AIDs that should be considered as belonging together by the OS. For all AIDs in an AID group, the OS will guarantee one of the following:  <ul> <li> <para>All AIDs in the group are routed to this service </para></li> <li> <para>No AIDs in the group are routed to this service </para></li></ul>In other words, there is no in-between state, where some AIDs in the group can be routed to this service, and some to another.  <h3>AID groups and categories</h3></para> <para>Each AID group can be associated with a category. This allows the Android OS to classify services, and it allows the user to set defaults at the category level instead of the AID level.</para> <para>You can use CardEmulation#isDefaultServiceForCategory(android.content.ComponentName, String) to determine if your service is the default handler for a category.</para> <para>In this version of the platform, the only known categories are CardEmulation#CATEGORY_PAYMENT and CardEmulation#CATEGORY_OTHER. AID groups without a category, or with a category that is not recognized by the current platform version, will automatically be grouped into the CardEmulation#CATEGORY_OTHER category.  <h3>Service AID registration</h3></para> <para>To tell the platform which AIDs groups are requested by this service, a SERVICE_META_DATA entry must be included in the declaration of the service. An example of a HostApduService manifest declaration is shown below:  <pre> &lt;service android:name=".MyHostApduService" android:exported="true" android:permission="android.permission.BIND_NFC_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.nfc.cardemulation.action.HOST_APDU_SERVICE"/&gt;
		///     &lt;/intent-filter&gt;
		///     &lt;meta-data android:name="android.nfc.cardemulation.host_apdu_ervice" android:resource="@xml/apduservice"/&gt;
		/// &lt;/service&gt;</pre></para> <para>This meta-data tag points to an apduservice.xml file. An example of this file with a single AID group declaration is shown below:  <pre>
		/// &lt;host-apdu-service xmlns:android="http://schemas.android.com/apk/res/android"
		///           android:description="@string/servicedesc" android:requireDeviceUnlock="false"&gt;
		///       &lt;aid-group android:description="@string/aiddescription" android:category="other"&gt;
		///           &lt;aid-filter android:name="F0010203040506"/&gt;
		///           &lt;aid-filter android:name="F0394148148100"/&gt;
		///       &lt;/aid-group&gt;
		/// &lt;/host-apdu-service&gt;
		/// </pre></para> <para>The &lt;host-apdu-service&gt; is required to contain a &lt;android:description&gt; attribute that contains a user-friendly description of the service that may be shown in UI. The &lt;requireDeviceUnlock&gt; attribute can be used to specify that the device must be unlocked before this service can be invoked to handle APDUs. </para> <para>The &lt;host-apdu-service&gt; must contain one or more &lt;aid-group&gt; tags. Each &lt;aid-group&gt; must contain one or more &lt;aid-filter&gt; tags, each of which contains a single AID. The AID must be specified in hexadecimal format, and contain an even number of characters.  <h3>AID conflict resolution</h3></para> <para>Multiple HostApduServices may be installed on a single device, and the same AID can be registered by more than one service. The Android platform resolves AID conflicts depending on which category an AID belongs to. Each category may have a different conflict resolution policy. For example, for some categories the user may be able to select a default service in the Android settings UI. For other categories, to policy may be to always ask the user which service is to be invoked in case of conflict.</para> <para>To query the conflict resolution policy for a certain category, see CardEmulation#getSelectionModeForCategory(String).</para> <para> <h3>Data exchange</h3></para> <para>Once the platform has resolved a "SELECT AID" command APDU to a specific service component, the "SELECT AID" command APDU and all subsequent command APDUs will be sent to that service through processCommandApdu(byte[], Bundle), until either:  <ul> <li> <para>The NFC link is broken </para></li> <li> <para>A "SELECT AID" APDU is received which resolves to another service </para></li></ul>These two scenarios are indicated by a call to onDeactivated(int).</para> <para>Use of this class requires the PackageManager#FEATURE_NFC_HOST_CARD_EMULATION to be present on the device. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/cardemulation/HostApduService
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/HostApduService", AccessFlags = 1057)]
		public abstract partial class HostApduService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Intent action that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.nfc.cardemulation.action.HOST_APDU_SERVICE";
				/// <summary>
				///  <para>The name of the meta-data element that contains more information about this service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.nfc.cardemulation.host_apdu_service";
				/// <summary>
				///  <para>Reason for onDeactivated(int). Indicates deactivation was due to the NFC link being lost. </para>        
				/// </summary>
				/// <java-name>
				/// DEACTIVATION_LINK_LOSS
				/// </java-name>
				[Dot42.DexImport("DEACTIVATION_LINK_LOSS", "I", AccessFlags = 25)]
				public const int DEACTIVATION_LINK_LOSS = 0;
				/// <summary>
				///  <para>Reason for onDeactivated(int).</para> <para>Indicates deactivation was due to a different AID being selected (which implicitly deselects the AID currently active on the logical channel).</para> <para>Note that this next AID may still be resolved to this service, in which case processCommandApdu(byte[], Bundle) will be called again. </para>        
				/// </summary>
				/// <java-name>
				/// DEACTIVATION_DESELECTED
				/// </java-name>
				[Dot42.DexImport("DEACTIVATION_DESELECTED", "I", AccessFlags = 25)]
				public const int DEACTIVATION_DESELECTED = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HostApduService() /* MethodBuilder.Create */ 
				{
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
				///  <para>Sends a response APDU back to the remote device.</para> <para>Note: this method may be called from any thread and will not block. </para>        
				/// </summary>
				/// <java-name>
				/// sendResponseApdu
				/// </java-name>
				[Dot42.DexImport("sendResponseApdu", "([B)V", AccessFlags = 17)]
				public void SendResponseApdu(sbyte[] responseApdu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends a response APDU back to the remote device.</para> <para>Note: this method may be called from any thread and will not block. </para>        
				/// </summary>
				/// <java-name>
				/// sendResponseApdu
				/// </java-name>
				[Dot42.DexImport("sendResponseApdu", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SendResponseApdu(byte[] responseApdu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calling this method allows the service to tell the OS that it won't be able to complete this transaction - for example, because it requires data connectivity that is not present at that moment.</para> <para>The OS may use this indication to give the user a list of alternative applications that can handle the last AID that was selected. If the user would select an application from the list, that action by itself will not cause the default to be changed; the selected application will be invoked for the next tap only.</para> <para>If there are no other applications that can handle this transaction, the OS will show an error dialog indicating your service could not complete the transaction.</para> <para>Note: this method may be called anywhere between the first processCommandApdu(byte[], Bundle) call and a onDeactivated(int) call. </para>        
				/// </summary>
				/// <java-name>
				/// notifyUnhandled
				/// </java-name>
				[Dot42.DexImport("notifyUnhandled", "()V", AccessFlags = 17)]
				public void NotifyUnhandled() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be called when a command APDU has been received from a remote device. A response APDU can be provided directly by returning a byte-array in this method. Note that in general response APDUs must be sent as quickly as possible, given the fact that the user is likely holding his device over an NFC reader when this method is called.</para> <para>If there are multiple services that have registered for the same AIDs in their meta-data entry, you will only get called if the user has explicitly selected your service, either as a default or just for the next tap.</para> <para>This method is running on the main thread of your application. If you cannot return a response APDU immediately, return null and use the sendResponseApdu(byte[]) method later.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte-array containing the response APDU, or null if no response APDU can be sent at this point. </para>
				/// </returns>
				/// <java-name>
				/// processCommandApdu
				/// </java-name>
				[Dot42.DexImport("processCommandApdu", "([BLandroid/os/Bundle;)[B", AccessFlags = 1025)]
				public abstract sbyte[] ProcessCommandApdu(sbyte[] commandApdu, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method will be called when a command APDU has been received from a remote device. A response APDU can be provided directly by returning a byte-array in this method. Note that in general response APDUs must be sent as quickly as possible, given the fact that the user is likely holding his device over an NFC reader when this method is called.</para> <para>If there are multiple services that have registered for the same AIDs in their meta-data entry, you will only get called if the user has explicitly selected your service, either as a default or just for the next tap.</para> <para>This method is running on the main thread of your application. If you cannot return a response APDU immediately, return null and use the sendResponseApdu(byte[]) method later.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte-array containing the response APDU, or null if no response APDU can be sent at this point. </para>
				/// </returns>
				/// <java-name>
				/// processCommandApdu
				/// </java-name>
				[Dot42.DexImport("processCommandApdu", "([BLandroid/os/Bundle;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] ProcessCommandApdu(byte[] commandApdu, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method will be called in two possible scenarios: The NFC link has been deactivated or lost A different AID has been selected and was resolved to a different service component </para>        
				/// </summary>
				/// <java-name>
				/// onDeactivated
				/// </java-name>
				[Dot42.DexImport("onDeactivated", "(I)V", AccessFlags = 1025)]
				public abstract void OnDeactivated(int reason) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>OffHostApduService is a convenience Service class that can be extended to describe one or more NFC applications that are residing off-host, for example on an embedded secure element or a UICC.</para> <para>  <h3>Developer Guide</h3></para> <para> For a general introduction into the topic of card emulation, please read the </para> <para> </para> <para> <h3>NFC Protocols</h3></para> <para>Off-host applications represented by this class are based on the NFC-Forum ISO-DEP protocol (based on ISO/IEC 14443-4) and support processing command Application Protocol Data Units (APDUs) as defined in the ISO/IEC 7816-4 specification.</para> <para> <h3>Service selection</h3></para> <para>When a remote NFC device wants to talk to your off-host NFC application, it sends a so-called "SELECT AID" APDU as defined in the ISO/IEC 7816-4 specification. The AID is an application identifier defined in ISO/IEC 7816-4.</para> <para>The registration procedure for AIDs is defined in the ISO/IEC 7816-5 specification. If you don't want to register an AID, you are free to use AIDs in the proprietary range: bits 8-5 of the first byte must each be set to '1'. For example, "0xF00102030405" is a proprietary AID. If you do use proprietary AIDs, it is recommended to choose an AID of at least 6 bytes, to reduce the risk of collisions with other applications that might be using proprietary AIDs as well.</para> <para> <h3>AID groups</h3></para> <para>In some cases, an off-host environment may need to register multiple AIDs to implement a certain application, and it needs to be sure that it is the default handler for all of these AIDs (as opposed to some AIDs in the group going to another service).</para> <para>An AID group is a list of AIDs that should be considered as belonging together by the OS. For all AIDs in an AID group, the OS will guarantee one of the following:  <ul> <li> <para>All AIDs in the group are routed to the off-host execution environment </para></li> <li> <para>No AIDs in the group are routed to the off-host execution environment </para></li></ul>In other words, there is no in-between state, where some AIDs in the group can be routed to this off-host execution environment, and some to another or a host-based HostApduService.  <h3>AID groups and categories</h3></para> <para>Each AID group can be associated with a category. This allows the Android OS to classify services, and it allows the user to set defaults at the category level instead of the AID level.</para> <para>You can use CardEmulation#isDefaultServiceForCategory(android.content.ComponentName, String) to determine if your off-host service is the default handler for a category.</para> <para>In this version of the platform, the only known categories are CardEmulation#CATEGORY_PAYMENT and CardEmulation#CATEGORY_OTHER. AID groups without a category, or with a category that is not recognized by the current platform version, will automatically be grouped into the CardEmulation#CATEGORY_OTHER category.</para> <para> <h3>Service AID registration</h3></para> <para>To tell the platform which AIDs reside off-host and are managed by this service, a SERVICE_META_DATA entry must be included in the declaration of the service. An example of a OffHostApduService manifest declaration is shown below:  <pre> &lt;service android:name=".MyOffHostApduService" android:exported="true" android:permission="android.permission.BIND_NFC_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.nfc.cardemulation.action.OFF_HOST_APDU_SERVICE"/&gt;
		///     &lt;/intent-filter&gt;
		///     &lt;meta-data android:name="android.nfc.cardemulation.off_host_apdu_ervice" android:resource="@xml/apduservice"/&gt;
		/// &lt;/service&gt;</pre></para> <para>This meta-data tag points to an apduservice.xml file. An example of this file with a single AID group declaration is shown below:  <pre>
		/// &lt;offhost-apdu-service xmlns:android="http://schemas.android.com/apk/res/android"
		///           android:description="@string/servicedesc"&gt;
		///       &lt;aid-group android:description="@string/subscription" android:category="other"&gt;
		///           &lt;aid-filter android:name="F0010203040506"/&gt;
		///           &lt;aid-filter android:name="F0394148148100"/&gt;
		///       &lt;/aid-group&gt;
		/// &lt;/offhost-apdu-service&gt;
		/// </pre></para> <para>The &lt;offhost-apdu-service&gt; is required to contain a &lt;android:description&gt; attribute that contains a user-friendly description of the service that may be shown in UI.</para> <para>The &lt;offhost-apdu-service&gt; must contain one or more &lt;aid-group&gt; tags. Each &lt;aid-group&gt; must contain one or more &lt;aid-filter&gt; tags, each of which contains a single AID. The AID must be specified in hexadecimal format, and contain an even number of characters.</para> <para>This registration will allow the service to be included as an option for being the default handler for categories. The Android OS will take care of correctly routing the AIDs to the off-host execution environment, based on which service the user has selected to be the handler for a certain category.</para> <para>The service may define additional actions outside of the Android namespace that provide further interaction with the off-host execution environment.</para> <para>Use of this class requires the PackageManager#FEATURE_NFC_HOST_CARD_EMULATION to be present on the device. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/cardemulation/OffHostApduService
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/OffHostApduService", AccessFlags = 1057)]
		public abstract partial class OffHostApduService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Intent action that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.nfc.cardemulation.action.OFF_HOST_APDU_SERVICE";
				/// <summary>
				///  <para>The name of the meta-data element that contains more information about this service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.nfc.cardemulation.off_host_apdu_service";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OffHostApduService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The Android platform itself will not bind to this service, but merely uses its declaration to keep track of what AIDs the service is interested in. This information is then used to present the user with a list of applications that can handle an AID, as well as correctly route those AIDs either to the host (in case the user preferred a HostApduService), or to an off-host execution environment (in case the user preferred a OffHostApduService.</para> <para>Implementers may define additional actions outside of the Android namespace that allow further interactions with the off-host execution environment. Such implementations would need to override this method. </para>        
				/// </summary>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1025)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

		}

}

