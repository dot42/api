// Copyright (C) 2014 dot42
//
// Original filename: Android.View.Textservice.cs
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
namespace Android.View.Textservice
{
		/// <summary>
		/// <para>This class is used to specify meta information of a subtype contained in a spell checker. Subtype can describe locale (e.g. en_US, fr_FR...) used for settings. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/SpellCheckerSubtype
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerSubtype", AccessFlags = 49)]
		public sealed partial class SpellCheckerSubtype : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Textservice.SpellCheckerSubtype> CREATOR;
				/// <summary>
				/// <para>Constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SpellCheckerSubtype(int nameId, string locale, string extraValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getNameResId
				/// </java-name>
				[Dot42.DexImport("getNameResId", "()I", AccessFlags = 1)]
				public int GetNameResId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLocale() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extra value of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getExtraValue
				/// </java-name>
				[Dot42.DexImport("getExtraValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetExtraValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>The string of ExtraValue in subtype should be defined as follows: example: key0,key1=value1,key2,key3,key4=value4 </para>        
				/// </summary>
				/// <returns>
				/// <para>the subtype contains specified the extra value </para>
				/// </returns>
				/// <java-name>
				/// containsExtraValueKey
				/// </java-name>
				[Dot42.DexImport("containsExtraValueKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsExtraValueKey(string key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The string of ExtraValue in subtype should be defined as follows: example: key0,key1=value1,key2,key3,key4=value4 </para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the specified key </para>
				/// </returns>
				/// <java-name>
				/// getExtraValueOf
				/// </java-name>
				[Dot42.DexImport("getExtraValueOf", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetExtraValueOf(string key) /* MethodBuilder.Create */ 
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
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>a display name for this subtype. The string resource of the label (mSubtypeNameResId) can have only one s in it. If there is, the s part will be replaced with the locale's display name by the formatter. If there is not, this method simply returns the string specified by mSubtypeNameResId. If mSubtypeNameResId is not specified (== 0), it's up to the framework to generate an appropriate display name. </para>
				/// </returns>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Landroid/content/Context;Ljava/lang/String;Landroid/content/pm/ApplicationInfo;)" +
    "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetDisplayName(global::Android.Content.Context context, string packageName, global::Android.Content.Pm.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SpellCheckerSubtype() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getNameResId
				/// </java-name>
				public int NameResId
				{
				[Dot42.DexImport("getNameResId", "()I", AccessFlags = 1)]
						get{ return GetNameResId(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public string Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocale(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extra value of the subtype </para>
				/// </returns>
				/// <java-name>
				/// getExtraValue
				/// </java-name>
				public string ExtraValue
				{
				[Dot42.DexImport("getExtraValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetExtraValue(); }
				}

		}

		/// <summary>
		/// <para>This class contains a metadata of the input of TextService </para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/TextInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/TextInfo", AccessFlags = 49)]
		public sealed partial class TextInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Textservice.TextInfo> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TextInfo(string source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public TextInfo(string text, int cookie, int sequence) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TextInfo(global::Android.Os.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text which is an input of a text service </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetText() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie of TextInfo </para>
				/// </returns>
				/// <java-name>
				/// getCookie
				/// </java-name>
				[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
				public int GetCookie() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sequence of TextInfo </para>
				/// </returns>
				/// <java-name>
				/// getSequence
				/// </java-name>
				[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
				public int GetSequence() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text which is an input of a text service </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				public string Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetText(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie of TextInfo </para>
				/// </returns>
				/// <java-name>
				/// getCookie
				/// </java-name>
				public int Cookie
				{
				[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
						get{ return GetCookie(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sequence of TextInfo </para>
				/// </returns>
				/// <java-name>
				/// getSequence
				/// </java-name>
				public int Sequence
				{
				[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
						get{ return GetSequence(); }
				}

		}

		/// <summary>
		/// <para>This class is used to specify meta information of a spell checker. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/SpellCheckerInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerInfo", AccessFlags = 49)]
		public sealed partial class SpellCheckerInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Textservice.SpellCheckerInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpellCheckerInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a unique ID for this spell checker. The ID is generated from the package and class name implementing the method. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the component of the service that implements. </para>        
				/// </summary>
				/// <java-name>
				/// getComponent
				/// </java-name>
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName GetComponent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				/// <para>Return the .apk package that implements this. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Load the user-displayed label for this spell checker.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Load the user-displayed icon for this spell checker.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return the raw information about the Service implementing this spell checker. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ServiceInfo GetServiceInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ServiceInfo);
				}

				/// <summary>
				/// <para>Return the class name of an activity that provides a settings UI. You can launch this activity be starting it with an android.content.Intent whose action is MAIN and with an explicit android.content.ComponentName composed of getPackageName and the class name returned here.</para><para>A null will be returned if there is no settings activity. </para>        
				/// </summary>
				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSettingsActivity() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the count of the subtypes. </para>        
				/// </summary>
				/// <java-name>
				/// getSubtypeCount
				/// </java-name>
				[Dot42.DexImport("getSubtypeCount", "()I", AccessFlags = 1)]
				public int GetSubtypeCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the subtype at the specified index.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getSubtypeAt
				/// </java-name>
				[Dot42.DexImport("getSubtypeAt", "(I)Landroid/view/textservice/SpellCheckerSubtype;", AccessFlags = 1)]
				public global::Android.View.Textservice.SpellCheckerSubtype GetSubtypeAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Textservice.SpellCheckerSubtype);
				}

				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
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
				/// <para>Return a unique ID for this spell checker. The ID is generated from the package and class name implementing the method. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public string Id
				{
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <summary>
				/// <para>Return the component of the service that implements. </para>        
				/// </summary>
				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return GetComponent(); }
				}

				/// <summary>
				/// <para>Return the .apk package that implements this. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <summary>
				/// <para>Return the raw information about the Service implementing this spell checker. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.Pm.ServiceInfo ServiceInfo
				{
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return GetServiceInfo(); }
				}

				/// <summary>
				/// <para>Return the class name of an activity that provides a settings UI. You can launch this activity be starting it with an android.content.Intent whose action is MAIN and with an explicit android.content.ComponentName composed of getPackageName and the class name returned here.</para><para>A null will be returned if there is no settings activity. </para>        
				/// </summary>
				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSettingsActivity(); }
				}

				/// <summary>
				/// <para>Return the count of the subtypes. </para>        
				/// </summary>
				/// <java-name>
				/// getSubtypeCount
				/// </java-name>
				public int SubtypeCount
				{
				[Dot42.DexImport("getSubtypeCount", "()I", AccessFlags = 1)]
						get{ return GetSubtypeCount(); }
				}

		}

		/// <summary>
		/// <para>The SpellCheckerSession interface provides the per client functionality of SpellCheckerService.</para><para> <h3>Applications</h3></para><para>In most cases, applications that are using the standard android.widget.TextView or its subclasses will have little they need to do to work well with spell checker services. The main things you need to be aware of are:</para><para><ul><li><para>Properly set the android.R.attr#inputType in your editable text views, so that the spell checker will have enough context to help the user in editing text in them. </para></li></ul></para><para>For the rare people amongst us writing client applications that use the spell checker service directly, you will need to use getSuggestions(TextInfo, int) or getSuggestions(TextInfo[], int, boolean) for obtaining results from the spell checker service by yourself.</para><para><h3>Security</h3></para><para>There are a lot of security issues associated with spell checkers, since they could monitor all the text being sent to them through, for instance, android.widget.TextView. The Android spell checker framework also allows arbitrary third party spell checkers, so care must be taken to restrict their selection and interactions.</para><para>Here are some key points about the security architecture behind the spell checker framework:</para><para><ul><li><para>Only the system is allowed to directly access a spell checker framework's android.service.textservice.SpellCheckerService interface, via the android.Manifest.permission#BIND_TEXT_SERVICE permission. This is enforced in the system by not binding to a spell checker service that does not require this permission.</para><para></para></li><li><para>The user must explicitly enable a new spell checker in settings before they can be enabled, to confirm with the system that they know about it and want to make it available for use. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/SpellCheckerSession
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerSession", AccessFlags = 33)]
		public partial class SpellCheckerSession
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Name under which a SpellChecker service component publishes information about itself. This meta-data must reference an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.view.textservice.scs";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpellCheckerSession() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the connection to a text service of this session is disconnected and not alive. </para>
				/// </returns>
				/// <java-name>
				/// isSessionDisconnected
				/// </java-name>
				[Dot42.DexImport("isSessionDisconnected", "()Z", AccessFlags = 1)]
				public virtual bool IsSessionDisconnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Get the spell checker service info this spell checker session has. </para>        
				/// </summary>
				/// <returns>
				/// <para>SpellCheckerInfo for the specified locale. </para>
				/// </returns>
				/// <java-name>
				/// getSpellChecker
				/// </java-name>
				[Dot42.DexImport("getSpellChecker", "()Landroid/view/textservice/SpellCheckerInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Textservice.SpellCheckerInfo GetSpellChecker() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Textservice.SpellCheckerInfo);
				}

				/// <summary>
				/// <para>Cancel pending and running spell check tasks </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finish this session and allow TextServicesManagerService to disconnect the bound spell checker. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get suggestions from the specified sentences </para>        
				/// </summary>
				/// <java-name>
				/// getSentenceSuggestions
				/// </java-name>
				[Dot42.DexImport("getSentenceSuggestions", "([Landroid/view/textservice/TextInfo;I)V", AccessFlags = 1)]
				public virtual void GetSentenceSuggestions(global::Android.View.Textservice.TextInfo[] textInfos, int suggestionsLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get candidate strings for a substring of the specified text. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use SpellCheckerSession#getSentenceSuggestions(TextInfo[], int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getSuggestions
				/// </java-name>
				[Dot42.DexImport("getSuggestions", "(Landroid/view/textservice/TextInfo;I)V", AccessFlags = 1)]
				public virtual void GetSuggestions(global::Android.View.Textservice.TextInfo textInfo, int suggestionsLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A batch process of getSuggestions <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use SpellCheckerSession#getSentenceSuggestions(TextInfo[], int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getSuggestions
				/// </java-name>
				[Dot42.DexImport("getSuggestions", "([Landroid/view/textservice/TextInfo;IZ)V", AccessFlags = 1)]
				public virtual void GetSuggestions(global::Android.View.Textservice.TextInfo[] textInfos, int suggestionsLimit, bool sequentialWords) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SpellCheckerSession() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the spell checker service info this spell checker session has. </para>        
				/// </summary>
				/// <returns>
				/// <para>SpellCheckerInfo for the specified locale. </para>
				/// </returns>
				/// <java-name>
				/// getSpellChecker
				/// </java-name>
				public global::Android.View.Textservice.SpellCheckerInfo SpellChecker
				{
				[Dot42.DexImport("getSpellChecker", "()Landroid/view/textservice/SpellCheckerInfo;", AccessFlags = 1)]
						get{ return GetSpellChecker(); }
				}

				/// <summary>
				/// <para>Callback for getting results from text services </para>    
				/// </summary>
				/// <java-name>
				/// android/view/textservice/SpellCheckerSession$SpellCheckerSessionListener
				/// </java-name>
				[Dot42.DexImport("android/view/textservice/SpellCheckerSession$SpellCheckerSessionListener", AccessFlags = 1545)]
				public partial interface ISpellCheckerSessionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Callback for SpellCheckerSession#getSuggestions(TextInfo, int) and SpellCheckerSession#getSuggestions(TextInfo[], int, boolean) </para>        
						/// </summary>
						/// <java-name>
						/// onGetSuggestions
						/// </java-name>
						[Dot42.DexImport("onGetSuggestions", "([Landroid/view/textservice/SuggestionsInfo;)V", AccessFlags = 1025)]
						void OnGetSuggestions(global::Android.View.Textservice.SuggestionsInfo[] results) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Callback for SpellCheckerSession#getSentenceSuggestions(TextInfo[], int) </para>        
						/// </summary>
						/// <java-name>
						/// onGetSentenceSuggestions
						/// </java-name>
						[Dot42.DexImport("onGetSentenceSuggestions", "([Landroid/view/textservice/SentenceSuggestionsInfo;)V", AccessFlags = 1025)]
						void OnGetSentenceSuggestions(global::Android.View.Textservice.SentenceSuggestionsInfo[] results) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>This class contains a metadata of suggestions from the text service </para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/SuggestionsInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SuggestionsInfo", AccessFlags = 49)]
		public sealed partial class SuggestionsInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Flag of the attributes of the suggestions that can be obtained by getSuggestionsAttributes: this tells that the requested word was found in the dictionary in the text service. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ATTR_IN_THE_DICTIONARY
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_IN_THE_DICTIONARY", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_IN_THE_DICTIONARY = 1;
				/// <summary>
				/// <para>Flag of the attributes of the suggestions that can be obtained by getSuggestionsAttributes: this tells that the text service thinks the requested word looks like a typo. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ATTR_LOOKS_LIKE_TYPO
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_LOOKS_LIKE_TYPO", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_LOOKS_LIKE_TYPO = 2;
				/// <summary>
				/// <para>Flag of the attributes of the suggestions that can be obtained by getSuggestionsAttributes: this tells that the text service thinks the result suggestions include highly recommended ones. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS = 4;
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Textservice.SuggestionsInfo> CREATOR;
				/// <summary>
				/// <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[Ljava/lang/String;)V", AccessFlags = 1)]
				public SuggestionsInfo(int suggestionsAttributes, string[] suggestions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[Ljava/lang/String;II)V", AccessFlags = 1)]
				public SuggestionsInfo(int suggestionsAttributes, string[] suggestions, int cookie, int sequence) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SuggestionsInfo(global::Android.Os.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the cookie and the sequence of SuggestionsInfo which are set to TextInfo from a client application </para>        
				/// </summary>
				/// <java-name>
				/// setCookieAndSequence
				/// </java-name>
				[Dot42.DexImport("setCookieAndSequence", "(II)V", AccessFlags = 1)]
				public void SetCookieAndSequence(int cookie, int sequence) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie which may be set by a client application </para>
				/// </returns>
				/// <java-name>
				/// getCookie
				/// </java-name>
				[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
				public int GetCookie() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sequence which may be set by a client application </para>
				/// </returns>
				/// <java-name>
				/// getSequence
				/// </java-name>
				[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
				public int GetSequence() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of suggestions. This includes whether the spell checker has the word in its dictionary or not and whether the spell checker has confident suggestions for the word or not. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsAttributes
				/// </java-name>
				[Dot42.DexImport("getSuggestionsAttributes", "()I", AccessFlags = 1)]
				public int GetSuggestionsAttributes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the count of the suggestions. If there's no suggestions at all, this method returns -1. Even if this method returns 0, it doesn't necessarily mean that there are no suggestions for the requested word. For instance, the caller could have been asked to limit the maximum number of suggestions returned. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsCount
				/// </java-name>
				[Dot42.DexImport("getSuggestionsCount", "()I", AccessFlags = 1)]
				public int GetSuggestionsCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the suggestion at the specified id </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionAt
				/// </java-name>
				[Dot42.DexImport("getSuggestionAt", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string GetSuggestionAt(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SuggestionsInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cookie which may be set by a client application </para>
				/// </returns>
				/// <java-name>
				/// getCookie
				/// </java-name>
				public int Cookie
				{
				[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
						get{ return GetCookie(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sequence which may be set by a client application </para>
				/// </returns>
				/// <java-name>
				/// getSequence
				/// </java-name>
				public int Sequence
				{
				[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
						get{ return GetSequence(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the attributes of suggestions. This includes whether the spell checker has the word in its dictionary or not and whether the spell checker has confident suggestions for the word or not. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsAttributes
				/// </java-name>
				public int SuggestionsAttributes
				{
				[Dot42.DexImport("getSuggestionsAttributes", "()I", AccessFlags = 1)]
						get{ return GetSuggestionsAttributes(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the count of the suggestions. If there's no suggestions at all, this method returns -1. Even if this method returns 0, it doesn't necessarily mean that there are no suggestions for the requested word. For instance, the caller could have been asked to limit the maximum number of suggestions returned. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsCount
				/// </java-name>
				public int SuggestionsCount
				{
				[Dot42.DexImport("getSuggestionsCount", "()I", AccessFlags = 1)]
						get{ return GetSuggestionsCount(); }
				}

		}

		/// <summary>
		/// <para>System API to the overall text services, which arbitrates interaction between applications and text services. You can retrieve an instance of this interface with Context.getSystemService().</para><para>The user can change the current text services in Settings. And also applications can specify the target text services.</para><para><h3>Architecture Overview</h3></para><para>There are three primary parties involved in the text services framework (TSF) architecture:</para><para><ul><li><para>The <b>text services manager</b> as expressed by this class is the central point of the system that manages interaction between all other parts. It is expressed as the client-side API here which exists in each application context and communicates with a global system service that manages the interaction across all processes. </para></li><li><para>A <b>text service</b> implements a particular interaction model allowing the client application to retrieve information of text. The system binds to the current text service that is in use, causing it to be created and run. </para></li><li><para>Multiple <b>client applications</b> arbitrate with the text service manager for connections to text services. </para></li></ul></para><para><h3>Text services sessions</h3></para><para><ul><li><para>The <b>spell checker session</b> is one of the text services. android.view.textservice.SpellCheckerSession </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/TextServicesManager
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/TextServicesManager", AccessFlags = 49)]
		public sealed partial class TextServicesManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TextServicesManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a spell checker session for the specified spell checker </para>        
				/// </summary>
				/// <returns>
				/// <para>the spell checker session of the spell checker </para>
				/// </returns>
				/// <java-name>
				/// newSpellCheckerSession
				/// </java-name>
				[Dot42.DexImport("newSpellCheckerSession", "(Landroid/os/Bundle;Ljava/util/Locale;Landroid/view/textservice/SpellCheckerSessi" +
    "on$SpellCheckerSessionListener;Z)Landroid/view/textservice/SpellCheckerSession;", AccessFlags = 1)]
				public global::Android.View.Textservice.SpellCheckerSession NewSpellCheckerSession(global::Android.Os.Bundle bundle, global::Java.Util.Locale locale, global::Android.View.Textservice.SpellCheckerSession.ISpellCheckerSessionListener listener, bool referToSpellCheckerLanguageSettings) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Textservice.SpellCheckerSession);
				}

		}

		/// <summary>
		/// <para>This class contains a metadata of suggestions returned from a text service (e.g. android.service.textservice.SpellCheckerService). The text service uses this class to return the suggestions for a sentence. See SuggestionsInfo which is used for suggestions for a word. This class extends the functionality of SuggestionsInfo as far as this class enables you to put multiple SuggestionsInfos on a sentence with the offsets and the lengths of all SuggestionsInfos. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/textservice/SentenceSuggestionsInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SentenceSuggestionsInfo", AccessFlags = 49)]
		public sealed partial class SentenceSuggestionsInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Textservice.SentenceSuggestionsInfo> CREATOR;
				/// <summary>
				/// <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Landroid/view/textservice/SuggestionsInfo;[I[I)V", AccessFlags = 1)]
				public SentenceSuggestionsInfo(global::Android.View.Textservice.SuggestionsInfo[] suggestionsInfos, int[] offsets, int[] lengths) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SentenceSuggestionsInfo(global::Android.Os.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the count of SuggestionsInfos this instance holds. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsCount
				/// </java-name>
				[Dot42.DexImport("getSuggestionsCount", "()I", AccessFlags = 1)]
				public int GetSuggestionsCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>a SuggestionsInfo at the specified id </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsInfoAt
				/// </java-name>
				[Dot42.DexImport("getSuggestionsInfoAt", "(I)Landroid/view/textservice/SuggestionsInfo;", AccessFlags = 1)]
				public global::Android.View.Textservice.SuggestionsInfo GetSuggestionsInfoAt(int i) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Textservice.SuggestionsInfo);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset of the specified SuggestionsInfo </para>
				/// </returns>
				/// <java-name>
				/// getOffsetAt
				/// </java-name>
				[Dot42.DexImport("getOffsetAt", "(I)I", AccessFlags = 1)]
				public int GetOffsetAt(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the specified SuggestionsInfo </para>
				/// </returns>
				/// <java-name>
				/// getLengthAt
				/// </java-name>
				[Dot42.DexImport("getLengthAt", "(I)I", AccessFlags = 1)]
				public int GetLengthAt(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SentenceSuggestionsInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the count of SuggestionsInfos this instance holds. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestionsCount
				/// </java-name>
				public int SuggestionsCount
				{
				[Dot42.DexImport("getSuggestionsCount", "()I", AccessFlags = 1)]
						get{ return GetSuggestionsCount(); }
				}

		}

}


