#pragma warning disable 1717
namespace Android.Accounts
{
		/// <java-name>
		/// android/accounts/AccountAuthenticatorResponse
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountAuthenticatorResponse", AccessFlags = 33)]
		public partial class AccountAuthenticatorResponse : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Accounts.AccountAuthenticatorResponse> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AccountAuthenticatorResponse(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResult
				/// </java-name>
				[Dot42.DexImport("onResult", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnResult(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRequestContinued
				/// </java-name>
				[Dot42.DexImport("onRequestContinued", "()V", AccessFlags = 1)]
				public virtual void OnRequestContinued() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onError
				/// </java-name>
				[Dot42.DexImport("onError", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnError(int int32, string @string) /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AccountAuthenticatorResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/AccountManagerFuture
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountManagerFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IAccountManagerFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1025)]
				bool Cancel(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1025)]
				bool IsCancelled() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDone
				/// </java-name>
				[Dot42.DexImport("isDone", "()Z", AccessFlags = 1025)]
				bool IsDone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResult
				/// </java-name>
				[Dot42.DexImport("getResult", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V GetResult() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResult
				/// </java-name>
				[Dot42.DexImport("getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				V GetResult(long int64, global::Java.Util.Concurrent.TimeUnit timeUnit) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/accounts/AccountManager
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountManager", AccessFlags = 33)]
		public partial class AccountManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR_CODE_REMOTE_EXCEPTION
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_REMOTE_EXCEPTION", "I", AccessFlags = 25)]
				public const int ERROR_CODE_REMOTE_EXCEPTION = 1;
				/// <java-name>
				/// ERROR_CODE_NETWORK_ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_NETWORK_ERROR", "I", AccessFlags = 25)]
				public const int ERROR_CODE_NETWORK_ERROR = 3;
				/// <java-name>
				/// ERROR_CODE_CANCELED
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_CANCELED", "I", AccessFlags = 25)]
				public const int ERROR_CODE_CANCELED = 4;
				/// <java-name>
				/// ERROR_CODE_INVALID_RESPONSE
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_INVALID_RESPONSE", "I", AccessFlags = 25)]
				public const int ERROR_CODE_INVALID_RESPONSE = 5;
				/// <java-name>
				/// ERROR_CODE_UNSUPPORTED_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_UNSUPPORTED_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_CODE_UNSUPPORTED_OPERATION = 6;
				/// <java-name>
				/// ERROR_CODE_BAD_ARGUMENTS
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_BAD_ARGUMENTS", "I", AccessFlags = 25)]
				public const int ERROR_CODE_BAD_ARGUMENTS = 7;
				/// <java-name>
				/// ERROR_CODE_BAD_REQUEST
				/// </java-name>
				[Dot42.DexImport("ERROR_CODE_BAD_REQUEST", "I", AccessFlags = 25)]
				public const int ERROR_CODE_BAD_REQUEST = 8;
				/// <java-name>
				/// KEY_ACCOUNT_NAME
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_NAME = "authAccount";
				/// <java-name>
				/// KEY_ACCOUNT_TYPE
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_TYPE = "accountType";
				/// <java-name>
				/// KEY_AUTHTOKEN
				/// </java-name>
				[Dot42.DexImport("KEY_AUTHTOKEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_AUTHTOKEN = "authtoken";
				/// <java-name>
				/// KEY_INTENT
				/// </java-name>
				[Dot42.DexImport("KEY_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_INTENT = "intent";
				/// <java-name>
				/// KEY_PASSWORD
				/// </java-name>
				[Dot42.DexImport("KEY_PASSWORD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_PASSWORD = "password";
				/// <java-name>
				/// KEY_ACCOUNTS
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNTS = "accounts";
				/// <java-name>
				/// KEY_ACCOUNT_AUTHENTICATOR_RESPONSE
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_AUTHENTICATOR_RESPONSE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_AUTHENTICATOR_RESPONSE = "accountAuthenticatorResponse";
				/// <java-name>
				/// KEY_ACCOUNT_MANAGER_RESPONSE
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_MANAGER_RESPONSE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_MANAGER_RESPONSE = "accountManagerResponse";
				/// <java-name>
				/// KEY_AUTHENTICATOR_TYPES
				/// </java-name>
				[Dot42.DexImport("KEY_AUTHENTICATOR_TYPES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_AUTHENTICATOR_TYPES = "authenticator_types";
				/// <java-name>
				/// KEY_AUTH_FAILED_MESSAGE
				/// </java-name>
				[Dot42.DexImport("KEY_AUTH_FAILED_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_AUTH_FAILED_MESSAGE = "authFailedMessage";
				/// <java-name>
				/// KEY_AUTH_TOKEN_LABEL
				/// </java-name>
				[Dot42.DexImport("KEY_AUTH_TOKEN_LABEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_AUTH_TOKEN_LABEL = "authTokenLabelKey";
				/// <java-name>
				/// KEY_BOOLEAN_RESULT
				/// </java-name>
				[Dot42.DexImport("KEY_BOOLEAN_RESULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_BOOLEAN_RESULT = "booleanResult";
				/// <java-name>
				/// KEY_ERROR_CODE
				/// </java-name>
				[Dot42.DexImport("KEY_ERROR_CODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ERROR_CODE = "errorCode";
				/// <java-name>
				/// KEY_ERROR_MESSAGE
				/// </java-name>
				[Dot42.DexImport("KEY_ERROR_MESSAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ERROR_MESSAGE = "errorMessage";
				/// <java-name>
				/// KEY_USERDATA
				/// </java-name>
				[Dot42.DexImport("KEY_USERDATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_USERDATA = "userdata";
				/// <java-name>
				/// KEY_CALLER_UID
				/// </java-name>
				[Dot42.DexImport("KEY_CALLER_UID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_CALLER_UID = "callerUid";
				/// <java-name>
				/// KEY_CALLER_PID
				/// </java-name>
				[Dot42.DexImport("KEY_CALLER_PID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_CALLER_PID = "callerPid";
				/// <java-name>
				/// KEY_ANDROID_PACKAGE_NAME
				/// </java-name>
				[Dot42.DexImport("KEY_ANDROID_PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ANDROID_PACKAGE_NAME = "androidPackageName";
				/// <java-name>
				/// ACTION_AUTHENTICATOR_INTENT
				/// </java-name>
				[Dot42.DexImport("ACTION_AUTHENTICATOR_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AUTHENTICATOR_INTENT = "android.accounts.AccountAuthenticator";
				/// <java-name>
				/// AUTHENTICATOR_META_DATA_NAME
				/// </java-name>
				[Dot42.DexImport("AUTHENTICATOR_META_DATA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHENTICATOR_META_DATA_NAME = "android.accounts.AccountAuthenticator";
				/// <java-name>
				/// AUTHENTICATOR_ATTRIBUTES_NAME
				/// </java-name>
				[Dot42.DexImport("AUTHENTICATOR_ATTRIBUTES_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHENTICATOR_ATTRIBUTES_NAME = "account-authenticator";
				/// <java-name>
				/// LOGIN_ACCOUNTS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("LOGIN_ACCOUNTS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOGIN_ACCOUNTS_CHANGED_ACTION = "android.accounts.LOGIN_ACCOUNTS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccountManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/content/Context;)Landroid/accounts/AccountManager;", AccessFlags = 9)]
				public static global::Android.Accounts.AccountManager Get(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.AccountManager);
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "(Landroid/accounts/Account;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassword(global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUserData(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAuthenticatorTypes
				/// </java-name>
				[Dot42.DexImport("getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;", AccessFlags = 1)]
				public virtual global::Android.Accounts.AuthenticatorDescription[] GetAuthenticatorTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.AuthenticatorDescription[]);
				}

				/// <java-name>
				/// getAccounts
				/// </java-name>
				[Dot42.DexImport("getAccounts", "()[Landroid/accounts/Account;", AccessFlags = 1)]
				public virtual global::Android.Accounts.Account[] GetAccounts() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.Account[]);
				}

				/// <java-name>
				/// getAccountsByType
				/// </java-name>
				[Dot42.DexImport("getAccountsByType", "(Ljava/lang/String;)[Landroid/accounts/Account;", AccessFlags = 1)]
				public virtual global::Android.Accounts.Account[] GetAccountsByType(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.Account[]);
				}

				/// <java-name>
				/// hasFeatures
				/// </java-name>
				[Dot42.DexImport("hasFeatures", "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCal" +
    "lback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCal" +
    "lback<Ljava/lang/Boolean;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<Ljava/lang/Boolean;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<bool?> HasFeatures(global::Android.Accounts.Account account, string[] @string, global::Android.Accounts.IAccountManagerCallback<bool?> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<bool?>);
				}

				/// <java-name>
				/// getAccountsByTypeAndFeatures
				/// </java-name>
				[Dot42.DexImport("getAccountsByTypeAndFeatures", "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;La" +
    "ndroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback<[L" +
    "android/accounts/Account;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<[Landroid/accounts/Account;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Accounts.Account[]> GetAccountsByTypeAndFeatures(string @string, string[] string1, global::Android.Accounts.IAccountManagerCallback<global::Android.Accounts.Account[]> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Accounts.Account[]>);
				}

				/// <java-name>
				/// addAccountExplicitly
				/// </java-name>
				[Dot42.DexImport("addAccountExplicitly", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool AddAccountExplicitly(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAccount
				/// </java-name>
				[Dot42.DexImport("removeAccount", "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback;Landroid/os/H" +
    "andler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback<Ljava/lang/Bo" +
    "olean;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Ljava/lang/B" +
    "oolean;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<bool?> RemoveAccount(global::Android.Accounts.Account account, global::Android.Accounts.IAccountManagerCallback<bool?> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<bool?>);
				}

				/// <java-name>
				/// invalidateAuthToken
				/// </java-name>
				[Dot42.DexImport("invalidateAuthToken", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void InvalidateAuthToken(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// peekAuthToken
				/// </java-name>
				[Dot42.DexImport("peekAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string PeekAuthToken(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Landroid/accounts/Account;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPassword(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearPassword
				/// </java-name>
				[Dot42.DexImport("clearPassword", "(Landroid/accounts/Account;)V", AccessFlags = 1)]
				public virtual void ClearPassword(global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUserData
				/// </java-name>
				[Dot42.DexImport("setUserData", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUserData(global::Android.Accounts.Account account, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuthToken
				/// </java-name>
				[Dot42.DexImport("setAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAuthToken(global::Android.Accounts.Account account, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// blockingGetAuthToken
				/// </java-name>
				[Dot42.DexImport("blockingGetAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BlockingGetAuthToken(global::Android.Accounts.Account account, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/acco" +
    "unts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/H" +
    "andler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthToken(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCal" +
    "lback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCal" +
    "lback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthToken(global::Android.Accounts.Account account, string @string, bool boolean, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;ZLandroid/account" +
    "s/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFu" +
    "ture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;ZLandroid/account" +
    "s/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/acco" +
    "unts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthToken(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle, bool boolean, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// addAccount
				/// </java-name>
				[Dot42.DexImport("addAccount", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landro" +
    "id/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)La" +
    "ndroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landro" +
    "id/app/Activity;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;La" +
    "ndroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> AddAccount(string @string, string string1, string[] string2, global::Android.Os.Bundle bundle, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// confirmCredentials
				/// </java-name>
				[Dot42.DexImport("confirmCredentials", "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/acco" +
    "unts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManage" +
    "rFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/acco" +
    "unts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/a" +
    "ccounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> ConfirmCredentials(global::Android.Accounts.Account account, global::Android.Os.Bundle bundle, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// updateCredentials
				/// </java-name>
				[Dot42.DexImport("updateCredentials", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/acco" +
    "unts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/H" +
    "andler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> UpdateCredentials(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// editProperties
				/// </java-name>
				[Dot42.DexImport("editProperties", "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback" +
    ";Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback" +
    "<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFutur" +
    "e<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> EditProperties(string @string, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// getAuthTokenByFeatures
				/// </java-name>
				[Dot42.DexImport("getAuthTokenByFeatures", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Lan" +
    "droid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback;Land" +
    "roid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = @"(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthTokenByFeatures(string @string, string string1, string[] string2, global::Android.App.Activity activity, global::Android.Os.Bundle bundle, global::Android.Os.Bundle bundle1, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> accountManagerCallback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <java-name>
				/// newChooseAccountIntent
				/// </java-name>
				[Dot42.DexImport("newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/St" +
    "ring;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/I" +
    "ntent;", AccessFlags = 9, Signature = "(Landroid/accounts/Account;Ljava/util/ArrayList<Landroid/accounts/Account;>;[Ljav" +
    "a/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/o" +
    "s/Bundle;)Landroid/content/Intent;")]
				public static global::Android.Content.Intent NewChooseAccountIntent(global::Android.Accounts.Account account, global::Java.Util.ArrayList<global::Android.Accounts.Account> arrayList, string[] @string, bool boolean, string string1, string string2, string[] string3, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// addOnAccountsUpdatedListener
				/// </java-name>
				[Dot42.DexImport("addOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;Landroid/os/Handler;Z)V", AccessFlags = 1)]
				public virtual void AddOnAccountsUpdatedListener(global::Android.Accounts.IOnAccountsUpdateListener onAccountsUpdateListener, global::Android.Os.Handler handler, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnAccountsUpdatedListener
				/// </java-name>
				[Dot42.DexImport("removeOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnAccountsUpdatedListener(global::Android.Accounts.IOnAccountsUpdateListener onAccountsUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAuthenticatorTypes
				/// </java-name>
				public global::Android.Accounts.AuthenticatorDescription[] AuthenticatorTypes
				{
				[Dot42.DexImport("getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;", AccessFlags = 1)]
						get{ return GetAuthenticatorTypes(); }
				}

				/// <java-name>
				/// getAccounts
				/// </java-name>
				public global::Android.Accounts.Account[] Accounts
				{
				[Dot42.DexImport("getAccounts", "()[Landroid/accounts/Account;", AccessFlags = 1)]
						get{ return GetAccounts(); }
				}

		}

		/// <java-name>
		/// android/accounts/NetworkErrorException
		/// </java-name>
		[Dot42.DexImport("android/accounts/NetworkErrorException", AccessFlags = 33)]
		public partial class NetworkErrorException : global::Android.Accounts.AccountsException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetworkErrorException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NetworkErrorException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NetworkErrorException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NetworkErrorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/AuthenticatorException
		/// </java-name>
		[Dot42.DexImport("android/accounts/AuthenticatorException", AccessFlags = 33)]
		public partial class AuthenticatorException : global::Android.Accounts.AccountsException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthenticatorException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthenticatorException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AuthenticatorException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AuthenticatorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/OperationCanceledException
		/// </java-name>
		[Dot42.DexImport("android/accounts/OperationCanceledException", AccessFlags = 33)]
		public partial class OperationCanceledException : global::Android.Accounts.AccountsException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OperationCanceledException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public OperationCanceledException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationCanceledException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationCanceledException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/AuthenticatorDescription
		/// </java-name>
		[Dot42.DexImport("android/accounts/AuthenticatorDescription", AccessFlags = 33)]
		public partial class AuthenticatorDescription : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Type;
				/// <java-name>
				/// labelId
				/// </java-name>
				[Dot42.DexImport("labelId", "I", AccessFlags = 17)]
				public readonly int LabelId;
				/// <java-name>
				/// iconId
				/// </java-name>
				[Dot42.DexImport("iconId", "I", AccessFlags = 17)]
				public readonly int IconId;
				/// <java-name>
				/// smallIconId
				/// </java-name>
				[Dot42.DexImport("smallIconId", "I", AccessFlags = 17)]
				public readonly int SmallIconId;
				/// <java-name>
				/// accountPreferencesId
				/// </java-name>
				[Dot42.DexImport("accountPreferencesId", "I", AccessFlags = 17)]
				public readonly int AccountPreferencesId;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string PackageName;
				/// <java-name>
				/// customTokens
				/// </java-name>
				[Dot42.DexImport("customTokens", "Z", AccessFlags = 17)]
				public readonly bool CustomTokens;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Accounts.AuthenticatorDescription> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;IIIIZ)V", AccessFlags = 1)]
				public AuthenticatorDescription(string @string, string string1, int int32, int int321, int int322, int int323, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V", AccessFlags = 1)]
				public AuthenticatorDescription(string @string, string string1, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newKey
				/// </java-name>
				[Dot42.DexImport("newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;", AccessFlags = 9)]
				public static global::Android.Accounts.AuthenticatorDescription NewKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.AuthenticatorDescription);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthenticatorDescription() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/Account
		/// </java-name>
		[Dot42.DexImport("android/accounts/Account", AccessFlags = 33)]
		public partial class Account : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Name;
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Type;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Accounts.Account> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Account(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public Account(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Account() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/AccountAuthenticatorActivity
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountAuthenticatorActivity", AccessFlags = 33)]
		public partial class AccountAuthenticatorActivity : global::Android.App.Activity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccountAuthenticatorActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAccountAuthenticatorResult
				/// </java-name>
				[Dot42.DexImport("setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetAccountAuthenticatorResult(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/accounts/AbstractAccountAuthenticator
		/// </java-name>
		[Dot42.DexImport("android/accounts/AbstractAccountAuthenticator", AccessFlags = 1057)]
		public abstract partial class AbstractAccountAuthenticator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbstractAccountAuthenticator(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIBinder
				/// </java-name>
				[Dot42.DexImport("getIBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
				public global::Android.Os.IBinder GetIBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// editProperties
				/// </java-name>
				[Dot42.DexImport("editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bu" +
    "ndle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle EditProperties(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addAccount
				/// </java-name>
				[Dot42.DexImport("addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/Stri" +
    "ng;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle AddAccount(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, string @string, string string1, string[] string2, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// confirmCredentials
				/// </java-name>
				[Dot42.DexImport("confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroi" +
    "d/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle ConfirmCredentials(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, global::Android.Accounts.Account account, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/l" +
    "ang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle GetAuthToken(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAuthTokenLabel
				/// </java-name>
				[Dot42.DexImport("getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetAuthTokenLabel(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCredentials
				/// </java-name>
				[Dot42.DexImport("updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/l" +
    "ang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle UpdateCredentials(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasFeatures
				/// </java-name>
				[Dot42.DexImport("hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/" +
    "lang/String;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle HasFeatures(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, global::Android.Accounts.Account account, string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAccountRemovalAllowed
				/// </java-name>
				[Dot42.DexImport("getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landro" +
    "id/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetAccountRemovalAllowed(global::Android.Accounts.AccountAuthenticatorResponse accountAuthenticatorResponse, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractAccountAuthenticator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIBinder
				/// </java-name>
				public global::Android.Os.IBinder IBinder
				{
				[Dot42.DexImport("getIBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
						get{ return GetIBinder(); }
				}

		}

		/// <java-name>
		/// android/accounts/AccountManagerCallback
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountManagerCallback", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IAccountManagerCallback<V>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "(Landroid/accounts/AccountManagerFuture;)V", AccessFlags = 1025, Signature = "(Landroid/accounts/AccountManagerFuture<TV;>;)V")]
				void Run(global::Android.Accounts.IAccountManagerFuture<V> accountManagerFuture) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/accounts/OnAccountsUpdateListener
		/// </java-name>
		[Dot42.DexImport("android/accounts/OnAccountsUpdateListener", AccessFlags = 1537)]
		public partial interface IOnAccountsUpdateListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onAccountsUpdated
				/// </java-name>
				[Dot42.DexImport("onAccountsUpdated", "([Landroid/accounts/Account;)V", AccessFlags = 1025)]
				void OnAccountsUpdated(global::Android.Accounts.Account[] account) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/accounts/AccountsException
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountsException", AccessFlags = 33)]
		public partial class AccountsException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccountsException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AccountsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AccountsException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AccountsException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

}

