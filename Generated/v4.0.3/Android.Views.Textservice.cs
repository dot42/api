#pragma warning disable 1717
namespace Android.Views.Textservice
{
		/// <java-name>
		/// android/view/textservice/SpellCheckerInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerInfo", AccessFlags = 49)]
		public sealed partial class SpellCheckerInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Textservice.SpellCheckerInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpellCheckerInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getSubtypeAt
				/// </java-name>
				[Dot42.DexImport("getSubtypeAt", "(I)Landroid/view/textservice/SpellCheckerSubtype;", AccessFlags = 1)]
				public global::Android.Views.Textservice.SpellCheckerSubtype GetSubtypeAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Textservice.SpellCheckerSubtype);
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
				/// getId
				/// </java-name>
				public string Id
				{
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
						[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.PM.ServiceInfo ServiceInfo
				{
						[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ServiceInfo); }
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
						[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubtypeCount
				/// </java-name>
				public int SubtypeCount
				{
						[Dot42.DexImport("getSubtypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/view/textservice/SpellCheckerSession
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerSession", AccessFlags = 33)]
		public partial class SpellCheckerSession
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.view.textservice.scs";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpellCheckerSession() /* MethodBuilder.Create */ 
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
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSuggestions
				/// </java-name>
				[Dot42.DexImport("getSuggestions", "(Landroid/view/textservice/TextInfo;I)V", AccessFlags = 1)]
				public virtual void GetSuggestions(global::Android.Views.Textservice.TextInfo textInfo, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSuggestions
				/// </java-name>
				[Dot42.DexImport("getSuggestions", "([Landroid/view/textservice/TextInfo;IZ)V", AccessFlags = 1)]
				public virtual void GetSuggestions(global::Android.Views.Textservice.TextInfo[] textInfo, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SpellCheckerSession() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSessionDisconnected
				/// </java-name>
				public virtual bool IsSessionDisconnected
				{
						[Dot42.DexImport("isSessionDisconnected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSpellChecker
				/// </java-name>
				public virtual global::Android.Views.Textservice.SpellCheckerInfo SpellChecker
				{
						[Dot42.DexImport("getSpellChecker", "()Landroid/view/textservice/SpellCheckerInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Textservice.SpellCheckerInfo); }
				}

				/// <java-name>
				/// android/view/textservice/SpellCheckerSession$SpellCheckerSessionListener
				/// </java-name>
				[Dot42.DexImport("android/view/textservice/SpellCheckerSession$SpellCheckerSessionListener", AccessFlags = 1545)]
				public partial interface ISpellCheckerSessionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGetSuggestions
						/// </java-name>
						[Dot42.DexImport("onGetSuggestions", "([Landroid/view/textservice/SuggestionsInfo;)V", AccessFlags = 1025)]
						void OnGetSuggestions(global::Android.Views.Textservice.SuggestionsInfo[] suggestionsInfo) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/textservice/SpellCheckerSubtype
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SpellCheckerSubtype", AccessFlags = 49)]
		public sealed partial class SpellCheckerSubtype : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Textservice.SpellCheckerSubtype> CREATOR;
				[Dot42.DexImport("<init>", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SpellCheckerSubtype(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
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
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Landroid/content/Context;Ljava/lang/String;Landroid/content/pm/ApplicationInfo;)" +
    "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetDisplayName(global::Android.Content.Context context, string @string, global::Android.Content.PM.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				internal SpellCheckerSubtype() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNameResId
				/// </java-name>
				public int NameResId
				{
						[Dot42.DexImport("getNameResId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public string Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getExtraValue
				/// </java-name>
				public string ExtraValue
				{
						[Dot42.DexImport("getExtraValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/view/textservice/SuggestionsInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/SuggestionsInfo", AccessFlags = 49)]
		public sealed partial class SuggestionsInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RESULT_ATTR_IN_THE_DICTIONARY
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_IN_THE_DICTIONARY", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_IN_THE_DICTIONARY = 1;
				/// <java-name>
				/// RESULT_ATTR_LOOKS_LIKE_TYPO
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_LOOKS_LIKE_TYPO", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_LOOKS_LIKE_TYPO = 2;
				/// <java-name>
				/// RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS
				/// </java-name>
				[Dot42.DexImport("RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS", "I", AccessFlags = 25)]
				public const int RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS = 4;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Textservice.SuggestionsInfo> CREATOR;
				[Dot42.DexImport("<init>", "(I[Ljava/lang/String;)V", AccessFlags = 1)]
				public SuggestionsInfo(int int32, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[Ljava/lang/String;II)V", AccessFlags = 1)]
				public SuggestionsInfo(int int32, string[] @string, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SuggestionsInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookieAndSequence
				/// </java-name>
				[Dot42.DexImport("setCookieAndSequence", "(II)V", AccessFlags = 1)]
				public void SetCookieAndSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSuggestionAt
				/// </java-name>
				[Dot42.DexImport("getSuggestionAt", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string GetSuggestionAt(int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SuggestionsInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCookie
				/// </java-name>
				public int Cookie
				{
						[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSequence
				/// </java-name>
				public int Sequence
				{
						[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSuggestionsAttributes
				/// </java-name>
				public int SuggestionsAttributes
				{
						[Dot42.DexImport("getSuggestionsAttributes", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSuggestionsCount
				/// </java-name>
				public int SuggestionsCount
				{
						[Dot42.DexImport("getSuggestionsCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/view/textservice/TextInfo
		/// </java-name>
		[Dot42.DexImport("android/view/textservice/TextInfo", AccessFlags = 49)]
		public sealed partial class TextInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Textservice.TextInfo> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TextInfo(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public TextInfo(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TextInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getText
				/// </java-name>
				public string Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCookie
				/// </java-name>
				public int Cookie
				{
						[Dot42.DexImport("getCookie", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSequence
				/// </java-name>
				public int Sequence
				{
						[Dot42.DexImport("getSequence", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

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

				/// <java-name>
				/// newSpellCheckerSession
				/// </java-name>
				[Dot42.DexImport("newSpellCheckerSession", "(Landroid/os/Bundle;Ljava/util/Locale;Landroid/view/textservice/SpellCheckerSessi" +
    "on$SpellCheckerSessionListener;Z)Landroid/view/textservice/SpellCheckerSession;", AccessFlags = 1)]
				public global::Android.Views.Textservice.SpellCheckerSession NewSpellCheckerSession(global::Android.OS.Bundle bundle, global::Java.Util.Locale locale, global::Android.Views.Textservice.SpellCheckerSession.ISpellCheckerSessionListener spellCheckerSessionListener, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Textservice.SpellCheckerSession);
				}

		}

}

