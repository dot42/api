// Copyright (C) 2014 dot42
//
// Original filename: Android.Nfc.Cardemulation.cs
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
namespace Android.Nfc.Cardemulation
{
		/// <java-name>
		/// android/nfc/cardemulation/CardEmulation
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/CardEmulation", AccessFlags = 49)]
		public sealed partial class CardEmulation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_CHANGE_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ACTION_CHANGE_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CHANGE_DEFAULT = "android.nfc.cardemulation.action.ACTION_CHANGE_DEFAULT";
				/// <java-name>
				/// EXTRA_CATEGORY
				/// </java-name>
				[Dot42.DexImport("EXTRA_CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CATEGORY = "category";
				/// <java-name>
				/// EXTRA_SERVICE_COMPONENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SERVICE_COMPONENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SERVICE_COMPONENT = "component";
				/// <java-name>
				/// CATEGORY_PAYMENT
				/// </java-name>
				[Dot42.DexImport("CATEGORY_PAYMENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_PAYMENT = "payment";
				/// <java-name>
				/// CATEGORY_OTHER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_OTHER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_OTHER = "other";
				/// <java-name>
				/// SELECTION_MODE_PREFER_DEFAULT
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_PREFER_DEFAULT", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_PREFER_DEFAULT = 0;
				/// <java-name>
				/// SELECTION_MODE_ALWAYS_ASK
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_ALWAYS_ASK", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_ALWAYS_ASK = 1;
				/// <java-name>
				/// SELECTION_MODE_ASK_IF_CONFLICT
				/// </java-name>
				[Dot42.DexImport("SELECTION_MODE_ASK_IF_CONFLICT", "I", AccessFlags = 25)]
				public const int SELECTION_MODE_ASK_IF_CONFLICT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CardEmulation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/nfc/NfcAdapter;)Landroid/nfc/cardemulation/CardEmulation;", AccessFlags = 41)]
				public static global::Android.Nfc.Cardemulation.CardEmulation GetInstance(global::Android.Nfc.NfcAdapter nfcAdapter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Cardemulation.CardEmulation);
				}

				/// <java-name>
				/// isDefaultServiceForCategory
				/// </java-name>
				[Dot42.DexImport("isDefaultServiceForCategory", "(Landroid/content/ComponentName;Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsDefaultServiceForCategory(global::Android.Content.ComponentName componentName, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDefaultServiceForAid
				/// </java-name>
				[Dot42.DexImport("isDefaultServiceForAid", "(Landroid/content/ComponentName;Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsDefaultServiceForAid(global::Android.Content.ComponentName componentName, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSelectionModeForCategory
				/// </java-name>
				[Dot42.DexImport("getSelectionModeForCategory", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int GetSelectionModeForCategory(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/nfc/cardemulation/HostApduService
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/HostApduService", AccessFlags = 1057)]
		public abstract partial class HostApduService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.nfc.cardemulation.action.HOST_APDU_SERVICE";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.nfc.cardemulation.host_apdu_service";
				/// <java-name>
				/// DEACTIVATION_LINK_LOSS
				/// </java-name>
				[Dot42.DexImport("DEACTIVATION_LINK_LOSS", "I", AccessFlags = 25)]
				public const int DEACTIVATION_LINK_LOSS = 0;
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
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// sendResponseApdu
				/// </java-name>
				[Dot42.DexImport("sendResponseApdu", "([B)V", AccessFlags = 17)]
				public void SendResponseApdu(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendResponseApdu
				/// </java-name>
				[Dot42.DexImport("sendResponseApdu", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SendResponseApdu(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyUnhandled
				/// </java-name>
				[Dot42.DexImport("notifyUnhandled", "()V", AccessFlags = 17)]
				public void NotifyUnhandled() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processCommandApdu
				/// </java-name>
				[Dot42.DexImport("processCommandApdu", "([BLandroid/os/Bundle;)[B", AccessFlags = 1025)]
				public abstract sbyte[] ProcessCommandApdu(sbyte[] sByte, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// processCommandApdu
				/// </java-name>
				[Dot42.DexImport("processCommandApdu", "([BLandroid/os/Bundle;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] ProcessCommandApdu(byte[] @byte, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onDeactivated
				/// </java-name>
				[Dot42.DexImport("onDeactivated", "(I)V", AccessFlags = 1025)]
				public abstract void OnDeactivated(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/nfc/cardemulation/OffHostApduService
		/// </java-name>
		[Dot42.DexImport("android/nfc/cardemulation/OffHostApduService", AccessFlags = 1057)]
		public abstract partial class OffHostApduService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.nfc.cardemulation.action.OFF_HOST_APDU_SERVICE";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.nfc.cardemulation.off_host_apdu_service";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OffHostApduService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1025)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

		}

}


