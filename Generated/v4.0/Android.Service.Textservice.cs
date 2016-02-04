#pragma warning disable 1717
namespace Android.Service.Textservice
{
		/// <summary>
		///  <para>SpellCheckerService provides an abstract base class for a spell checker. This class combines a service to the system with the spell checker service interface that spell checker must implement.</para> <para>In addition to the normal Service lifecycle methods, this class introduces a new specific callback that subclasses should override createSession() to provide a spell checker session that is corresponding to requested language and so on. The spell checker session returned by this method should extend SpellCheckerService.Session. </para> <para> <h3>Returning spell check results</h3></para> <para>SpellCheckerService.Session#onGetSuggestions(TextInfo, int) should return spell check results. It receives android.view.textservice.TextInfo and returns android.view.textservice.SuggestionsInfo for the input. You may want to override SpellCheckerService.Session#onGetSuggestionsMultiple(TextInfo[], int, boolean) for better performance and quality. </para> <para>Please note that SpellCheckerService.Session#getLocale() does not return a valid locale before SpellCheckerService.Session#onCreate() </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Implement to return the implementation of the internal spell checker service interface. Subclasses should not override. </para>        
				/// </summary>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Factory method to create a spell checker session impl </para>        
				/// </summary>
				/// <returns>
				///  <para>SpellCheckerSessionImpl which should be overridden by a concrete implementation. </para>
				/// </returns>
				/// <java-name>
				/// createSession
				/// </java-name>
				[Dot42.DexImport("createSession", "()Landroid/service/textservice/SpellCheckerService$Session;", AccessFlags = 1025)]
				public abstract global::Android.Service.Textservice.SpellCheckerService.Session CreateSession() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This abstract class should be overridden by a concrete implementation of a spell checker. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>This is called after the class is initialized, at which point it knows it can call getLocale() etc... </para>        
						/// </summary>
						/// <java-name>
						/// onCreate
						/// </java-name>
						[Dot42.DexImport("onCreate", "()V", AccessFlags = 1025)]
						public abstract void OnCreate() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Get suggestions for specified text in TextInfo. This function will run on the incoming IPC thread. So, this is not called on the main thread, but will be called in series on another thread. </para>        
						/// </summary>
						/// <returns>
						///  <para>SuggestionsInfo which contains suggestions for textInfo </para>
						/// </returns>
						/// <java-name>
						/// onGetSuggestions
						/// </java-name>
						[Dot42.DexImport("onGetSuggestions", "(Landroid/view/textservice/TextInfo;I)Landroid/view/textservice/SuggestionsInfo;", AccessFlags = 1025)]
						public abstract global::Android.Views.Textservice.SuggestionsInfo OnGetSuggestions(global::Android.Views.Textservice.TextInfo textInfo, int suggestionsLimit) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>A batch process of onGetSuggestions. This function will run on the incoming IPC thread. So, this is not called on the main thread, but will be called in series on another thread. </para>        
						/// </summary>
						/// <returns>
						///  <para>an array of SentenceSuggestionsInfo returned by SpellCheckerService.Session#onGetSuggestions(TextInfo, int) </para>
						/// </returns>
						/// <java-name>
						/// onGetSuggestionsMultiple
						/// </java-name>
						[Dot42.DexImport("onGetSuggestionsMultiple", "([Landroid/view/textservice/TextInfo;IZ)[Landroid/view/textservice/SuggestionsInf" +
    "o;", AccessFlags = 1)]
						public virtual global::Android.Views.Textservice.SuggestionsInfo[] OnGetSuggestionsMultiple(global::Android.Views.Textservice.TextInfo[] textInfos, int suggestionsLimit, bool sequentialWords) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Views.Textservice.SuggestionsInfo[]);
						}

						/// <summary>
						///  <para>Request to abort all tasks executed in SpellChecker. This function will run on the incoming IPC thread. So, this is not called on the main thread, but will be called in series on another thread. </para>        
						/// </summary>
						/// <java-name>
						/// onCancel
						/// </java-name>
						[Dot42.DexImport("onCancel", "()V", AccessFlags = 1)]
						public virtual void OnCancel() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Locale for this session </para>
						/// </returns>
						/// <java-name>
						/// getLocale
						/// </java-name>
						public virtual string Locale
						{
								[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Bundle for this session </para>
						/// </returns>
						/// <java-name>
						/// getBundle
						/// </java-name>
						public virtual global::Android.OS.Bundle Bundle
						{
								[Dot42.DexImport("getBundle", "()Landroid/os/Bundle;", AccessFlags = 1)]
								get{ return default(global::Android.OS.Bundle); }
						}

				}

		}

}

