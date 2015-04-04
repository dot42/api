#pragma warning disable 1717
namespace Android.Service.Textservice
{
		/// <java-name>
		/// android/service/textservice/SpellCheckerService
		/// </java-name>
		[Dot42.DexImport("android/service/textservice/SpellCheckerService", AccessFlags = 1057)]
		public abstract partial class SpellCheckerService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.service.textservice.SpellCheckerService";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SpellCheckerService() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// createSession
				/// </java-name>
				[Dot42.DexImport("createSession", "()Landroid/service/textservice/SpellCheckerService$Session;", AccessFlags = 1025)]
				public abstract global::Android.Service.Textservice.SpellCheckerService.Session CreateSession() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/service/textservice/SpellCheckerService$Session
				/// </java-name>
				[Dot42.DexImport("android/service/textservice/SpellCheckerService$Session", AccessFlags = 1033)]
				public abstract partial class Session
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Session() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCreate
						/// </java-name>
						[Dot42.DexImport("onCreate", "()V", AccessFlags = 1025)]
						public abstract void OnCreate() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGetSuggestions
						/// </java-name>
						[Dot42.DexImport("onGetSuggestions", "(Landroid/view/textservice/TextInfo;I)Landroid/view/textservice/SuggestionsInfo;", AccessFlags = 1025)]
						public abstract global::Android.Views.Textservice.SuggestionsInfo OnGetSuggestions(global::Android.Views.Textservice.TextInfo textInfo, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGetSuggestionsMultiple
						/// </java-name>
						[Dot42.DexImport("onGetSuggestionsMultiple", "([Landroid/view/textservice/TextInfo;IZ)[Landroid/view/textservice/SuggestionsInf" +
    "o;", AccessFlags = 1)]
						public virtual global::Android.Views.Textservice.SuggestionsInfo[] OnGetSuggestionsMultiple(global::Android.Views.Textservice.TextInfo[] textInfo, int int32, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Views.Textservice.SuggestionsInfo[]);
						}

						/// <java-name>
						/// onCancel
						/// </java-name>
						[Dot42.DexImport("onCancel", "()V", AccessFlags = 1)]
						public virtual void OnCancel() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onClose
						/// </java-name>
						[Dot42.DexImport("onClose", "()V", AccessFlags = 1)]
						public virtual void OnClose() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getLocale
						/// </java-name>
						[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLocale() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getBundle
						/// </java-name>
						[Dot42.DexImport("getBundle", "()Landroid/os/Bundle;", AccessFlags = 1)]
						public virtual global::Android.OS.Bundle GetBundle() /* MethodBuilder.Create */ 
						{
								return default(global::Android.OS.Bundle);
						}

						/// <java-name>
						/// getLocale
						/// </java-name>
						public string Locale
						{
						[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLocale(); }
						}

						/// <java-name>
						/// getBundle
						/// </java-name>
						public global::Android.OS.Bundle Bundle
						{
						[Dot42.DexImport("getBundle", "()Landroid/os/Bundle;", AccessFlags = 1)]
								get{ return GetBundle(); }
						}

				}

		}

}

