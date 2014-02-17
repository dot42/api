// Copyright (C) 2014 dot42
//
// Original filename: Android.Accounts.cs
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
namespace Android.Accounts
{
		/// <summary>
		/// <para>Abstract base class for creating AccountAuthenticators. In order to be an authenticator one must extend this class, provider implementations for the abstract methods and write a service that returns the result of getIBinder() in the service's android.app.Service#onBind(android.content.Intent) when invoked with an intent with action AccountManager#ACTION_AUTHENTICATOR_INTENT. This service must specify the following intent filter and metadata tags in its AndroidManifest.xml file <pre>
		///      &lt;intent-filter&gt;
		///        &lt;action android:name="android.accounts.AccountAuthenticator" /&gt;
		///      &lt;/intent-filter&gt;
		///      &lt;meta-data android:name="android.accounts.AccountAuthenticator"
		///                android:resource="@xml/authenticator" /&gt;
		///    </pre> The <code>android:resource</code> attribute must point to a resource that looks like: <pre>
		///    &lt;account-authenticator xmlns:android="http://schemas.android.com/apk/res/android"
		///       android:accountType="typeOfAuthenticator"
		///       android:icon="@drawable/icon"
		///       android:smallIcon="@drawable/miniIcon"
		///       android:label="@string/label"
		///       android:accountPreferences="@xml/account_preferences"
		///    /&gt;
		///    </pre> Replace the icons and labels with your own resources. The <code>android:accountType</code> attribute must be a string that uniquely identifies your authenticator and will be the same string that user will use when making calls on the AccountManager and it also corresponds to Account#type for your accounts. One user of the android:icon is the "Account &amp; Sync" settings page and one user of the android:smallIcon is the Contact Application's tab panels. </para><para>The preferences attribute points to a PreferenceScreen xml hierarchy that contains a list of PreferenceScreens that can be invoked to manage the authenticator. An example is: <pre>
		///    &lt;PreferenceScreen xmlns:android="http://schemas.android.com/apk/res/android"&gt;
		///       &lt;PreferenceCategory android:title="@string/title_fmt" /&gt;
		///       &lt;PreferenceScreen
		///            android:key="key1"
		///            android:title="@string/key1_action"
		///            android:summary="@string/key1_summary"&gt;
		///            &lt;intent
		///                android:action="key1.ACTION"
		///                android:targetPackage="key1.package"
		///                android:targetClass="key1.class" /&gt;
		///        &lt;/PreferenceScreen&gt;
		///    &lt;/PreferenceScreen&gt;
		///    </pre></para><para>The standard pattern for implementing any of the abstract methods is the following: <ul><li><para>If the supplied arguments are enough for the authenticator to fully satisfy the request then it will do so and return a Bundle that contains the results. </para></li><li><para>If the authenticator needs information from the user to satisfy the request then it will create an Intent to an activity that will prompt the user for the information and then carry out the request. This intent must be returned in a Bundle as key AccountManager#KEY_INTENT. </para><para>The activity needs to return the final result when it is complete so the Intent should contain the AccountAuthenticatorResponse as AccountManager#KEY_ACCOUNT_MANAGER_RESPONSE. The activity must then call AccountAuthenticatorResponse#onResult or AccountAuthenticatorResponse#onError when it is complete. </para></li><li><para>If the authenticator cannot synchronously process the request and return a result then it may choose to return null and then use the AccountManagerResponse to send the result when it has completed the request. </para></li></ul></para><para>The following descriptions of each of the abstract authenticator methods will not describe the possible asynchronous nature of the request handling and will instead just describe the input parameters and the expected result. </para><para>When writing an activity to satisfy these requests one must pass in the AccountManagerResponse and return the result via that response when the activity finishes (or whenever else the activity author deems it is the correct time to respond). The AccountAuthenticatorActivity handles this, so one may wish to extend that when writing activities to handle these requests. </para>    
		/// </summary>
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

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the IBinder for the AccountAuthenticator </para>
				/// </returns>
				/// <java-name>
				/// getIBinder
				/// </java-name>
				[Dot42.DexImport("getIBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
				public global::Android.Os.IBinder GetIBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Returns a Bundle that contains the Intent of the activity that can be used to edit the properties. In order to indicate success the activity should call response.setResult() with a non-null Bundle. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle containing the result or the Intent to start to continue the request. If this is null then the request is considered to still be active and the result should sent later using response. </para>
				/// </returns>
				/// <java-name>
				/// editProperties
				/// </java-name>
				[Dot42.DexImport("editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bu" +
    "ndle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle EditProperties(global::Android.Accounts.AccountAuthenticatorResponse response, string accountType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds an account of the specified accountType. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_ACCOUNT_NAME and AccountManager#KEY_ACCOUNT_TYPE of the account that was added, or </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// addAccount
				/// </java-name>
				[Dot42.DexImport("addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/Stri" +
    "ng;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle AddAccount(global::Android.Accounts.AccountAuthenticatorResponse response, string accountType, string authTokenType, string[] requiredFeatures, global::Android.Os.Bundle options) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks that the user knows the credentials of an account. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_BOOLEAN_RESULT, true if the check succeeded, false otherwise </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// confirmCredentials
				/// </java-name>
				[Dot42.DexImport("confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroi" +
    "d/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle ConfirmCredentials(global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, global::Android.Os.Bundle options) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the authtoken for an account. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_ACCOUNT_NAME, AccountManager#KEY_ACCOUNT_TYPE, and AccountManager#KEY_AUTHTOKEN, or </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/l" +
    "ang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle GetAuthToken(global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string authTokenType, global::Android.Os.Bundle options) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Ask the authenticator for a localized label for the given authTokenType. </para>        
				/// </summary>
				/// <returns>
				/// <para>the localized label of the auth token type, may be null if the type isn't known </para>
				/// </returns>
				/// <java-name>
				/// getAuthTokenLabel
				/// </java-name>
				[Dot42.DexImport("getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetAuthTokenLabel(string authTokenType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Update the locally stored credentials for an account. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_ACCOUNT_NAME and AccountManager#KEY_ACCOUNT_TYPE of the account that was added, or </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// updateCredentials
				/// </java-name>
				[Dot42.DexImport("updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/l" +
    "ang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle UpdateCredentials(global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string authTokenType, global::Android.Os.Bundle options) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if the account supports all the specified authenticator specific features. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_BOOLEAN_RESULT, true if the account has all the features, false otherwise </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// hasFeatures
				/// </java-name>
				[Dot42.DexImport("hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/" +
    "lang/String;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.Os.Bundle HasFeatures(global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string[] features) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if the removal of this account is allowed. </para>        
				/// </summary>
				/// <returns>
				/// <para>a Bundle result or null if the result is to be returned via the response. The result will contain either: <ul><li><para>AccountManager#KEY_INTENT, or </para></li><li><para>AccountManager#KEY_BOOLEAN_RESULT, true if the removal of the account is allowed, false otherwise </para></li><li><para>AccountManager#KEY_ERROR_CODE and AccountManager#KEY_ERROR_MESSAGE to indicate an error </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getAccountRemovalAllowed
				/// </java-name>
				[Dot42.DexImport("getAccountRemovalAllowed", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;)Landro" +
    "id/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetAccountRemovalAllowed(global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractAccountAuthenticator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the IBinder for the AccountAuthenticator </para>
				/// </returns>
				/// <java-name>
				/// getIBinder
				/// </java-name>
				public global::Android.Os.IBinder IBinder
				{
				[Dot42.DexImport("getIBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
						get{ return GetIBinder(); }
				}

		}

		/// <summary>
		/// <para>Base class for implementing an Activity that is used to help implement an AbstractAccountAuthenticator. If the AbstractAccountAuthenticator needs to use an activity to handle the request then it can have the activity extend AccountAuthenticatorActivity. The AbstractAccountAuthenticator passes in the response to the intent using the following: <pre>
		///         intent.putExtra(AccountManager#KEY_ACCOUNT_AUTHENTICATOR_RESPONSE, response);
		///    </pre> The activity then sets the result that is to be handed to the response via setAccountAuthenticatorResult(android.os.Bundle). This result will be sent as the result of the request when the activity finishes. If this is never set or if it is set to null then error AccountManager#ERROR_CODE_CANCELED will be called on the response. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Set the result that is to be sent as the result of the request that caused this Activity to be launched. If result is null or this method is never called then the request will be canceled. </para>        
				/// </summary>
				/// <java-name>
				/// setAccountAuthenticatorResult
				/// </java-name>
				[Dot42.DexImport("setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetAccountAuthenticatorResult(global::Android.Os.Bundle result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retreives the AccountAuthenticatorResponse from either the intent of the icicle, if the icicle is non-zero. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.Os.Bundle icicle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sends the result or a Constants.ERROR_CODE_CANCELED error if a result isn't present. </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Value type that represents an Account in the AccountManager. This object is Parcelable and also overrides equals and hashCode, making it suitable for use as the key of a java.util.Map </para>    
		/// </summary>
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
				public Account(string name, string type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public Account(global::Android.Os.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

		/// <summary>
		/// <para>A <code>AccountManagerFuture</code> represents the result of an asynchronous AccountManager call. Methods are provided to check if the computation is complete, to wait for its completion, and to retrieve the result of the computation. The result can only be retrieved using method <code>get</code> when the computation has completed, blocking if necessary until it is ready. Cancellation is performed by the <code>cancel</code> method. Additional methods are provided to determine if the task completed normally or was cancelled. Once a computation has completed, the computation cannot be cancelled. If you would like to use a <code>Future</code> for the sake of cancellability but not provide a usable result, you can declare types of the form <code>Future&lt;?&gt;</code> and return <code>null</code> as a result of the underlying task. </para>    
		/// </summary>
		/// <java-name>
		/// android/accounts/AccountManagerFuture
		/// </java-name>
		[Dot42.DexImport("android/accounts/AccountManagerFuture", AccessFlags = 1537, Signature = "<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IAccountManagerFuture<V>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Attempts to cancel execution of this task. This attempt will fail if the task has already completed, has already been cancelled, or could not be cancelled for some other reason. If successful, and this task has not started when <code>cancel</code> is called, this task should never run. If the task has already started, then the <code>mayInterruptIfRunning</code> parameter determines whether the thread executing this task should be interrupted in an attempt to stop the task.</para><para>After this method returns, subsequent calls to isDone will always return <code>true</code>. Subsequent calls to isCancelled will always return <code>true</code> if this method returned <code>true</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> if the task could not be cancelled, typically because it has already completed normally; <code>true</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Z)Z", AccessFlags = 1025)]
				bool Cancel(bool mayInterruptIfRunning) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>true</code> if this task was cancelled before it completed normally.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this task was cancelled before it completed </para>
				/// </returns>
				/// <java-name>
				/// isCancelled
				/// </java-name>
				[Dot42.DexImport("isCancelled", "()Z", AccessFlags = 1025)]
				bool IsCancelled() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>true</code> if this task completed.</para><para>Completion may be due to normal termination, an exception, or cancellation  in all of these cases, this method will return <code>true</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this task completed </para>
				/// </returns>
				/// <java-name>
				/// isDone
				/// </java-name>
				[Dot42.DexImport("isDone", "()Z", AccessFlags = 1025)]
				bool IsDone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Accessor for the future result the AccountManagerFuture represents. This call will block until the result is available. In order to check if the result is available without blocking, one may call isDone() and isCancelled(). If the request that generated this result fails or is canceled then an exception will be thrown rather than the call returning normally. </para>        
				/// </summary>
				/// <returns>
				/// <para>the actual result </para>
				/// </returns>
				/// <java-name>
				/// getResult
				/// </java-name>
				[Dot42.DexImport("getResult", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TV;")]
				V GetResult() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Accessor for the future result the AccountManagerFuture represents. This call will block until the result is available. In order to check if the result is available without blocking, one may call isDone() and isCancelled(). If the request that generated this result fails or is canceled then an exception will be thrown rather than the call returning normally. If a timeout is specified then the request will automatically be canceled if it does not complete in that amount of time. </para>        
				/// </summary>
				/// <returns>
				/// <para>the actual result </para>
				/// </returns>
				/// <java-name>
				/// getResult
				/// </java-name>
				[Dot42.DexImport("getResult", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(JLjava/util/concurrent/TimeUnit;)TV;")]
				V GetResult(long timeout, global::Java.Util.Concurrent.TimeUnit unit) /* MethodBuilder.Create */ ;

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
				public NetworkErrorException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NetworkErrorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

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
				public AccountsException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AccountsException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A Parcelable value type that contains information about an account authenticator. </para>    
		/// </summary>
		/// <java-name>
		/// android/accounts/AuthenticatorDescription
		/// </java-name>
		[Dot42.DexImport("android/accounts/AuthenticatorDescription", AccessFlags = 33)]
		public partial class AuthenticatorDescription : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The string that uniquely identifies an authenticator </para>        
				/// </summary>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Type;
				/// <summary>
				/// <para>A resource id of a label for the authenticator that is suitable for displaying </para>        
				/// </summary>
				/// <java-name>
				/// labelId
				/// </java-name>
				[Dot42.DexImport("labelId", "I", AccessFlags = 17)]
				public readonly int LabelId;
				/// <summary>
				/// <para>A resource id of a icon for the authenticator </para>        
				/// </summary>
				/// <java-name>
				/// iconId
				/// </java-name>
				[Dot42.DexImport("iconId", "I", AccessFlags = 17)]
				public readonly int IconId;
				/// <summary>
				/// <para>A resource id of a smaller icon for the authenticator </para>        
				/// </summary>
				/// <java-name>
				/// smallIconId
				/// </java-name>
				[Dot42.DexImport("smallIconId", "I", AccessFlags = 17)]
				public readonly int SmallIconId;
				/// <summary>
				/// <para>A resource id for a hierarchy of PreferenceScreen to be added to the settings page for the account. See AbstractAccountAuthenticator for an example. </para>        
				/// </summary>
				/// <java-name>
				/// accountPreferencesId
				/// </java-name>
				[Dot42.DexImport("accountPreferencesId", "I", AccessFlags = 17)]
				public readonly int AccountPreferencesId;
				/// <summary>
				/// <para>The package name that can be used to lookup the resources from above. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string PackageName;
				/// <summary>
				/// <para>Authenticator handles its own token caching and permission screen </para>        
				/// </summary>
				/// <java-name>
				/// customTokens
				/// </java-name>
				[Dot42.DexImport("customTokens", "Z", AccessFlags = 17)]
				public readonly bool CustomTokens;
				/// <summary>
				/// <para>Used to create the object from a parcel. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Accounts.AuthenticatorDescription> CREATOR;
				/// <summary>
				/// <para>A constructor for a full AuthenticatorDescription </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;IIIIZ)V", AccessFlags = 1)]
				public AuthenticatorDescription(string type, string packageName, int labelId, int iconId, int smallIconId, int prefId, bool customTokens) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V", AccessFlags = 1)]
				public AuthenticatorDescription(string type, string packageName, int labelId, int iconId, int smallIconId, int prefId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A factory method for creating an AuthenticatorDescription that can be used as a key to identify the authenticator by its type. </para>        
				/// </summary>
				/// <java-name>
				/// newKey
				/// </java-name>
				[Dot42.DexImport("newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;", AccessFlags = 9)]
				public static global::Android.Accounts.AuthenticatorDescription NewKey(string type) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the hashcode of the type only. </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the type only, suitable for key comparisons. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthenticatorDescription() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An interface that contains the callback used by the AccountManager </para>    
		/// </summary>
		/// <java-name>
		/// android/accounts/OnAccountsUpdateListener
		/// </java-name>
		[Dot42.DexImport("android/accounts/OnAccountsUpdateListener", AccessFlags = 1537)]
		public partial interface IOnAccountsUpdateListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This invoked when the AccountManager starts up and whenever the account set changes. </para>        
				/// </summary>
				/// <java-name>
				/// onAccountsUpdated
				/// </java-name>
				[Dot42.DexImport("onAccountsUpdated", "([Landroid/accounts/Account;)V", AccessFlags = 1025)]
				void OnAccountsUpdated(global::Android.Accounts.Account[] accounts) /* MethodBuilder.Create */ ;

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
				public OperationCanceledException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationCanceledException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
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
				void Run(global::Android.Accounts.IAccountManagerFuture<V> future) /* MethodBuilder.Create */ ;

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
				public AuthenticatorException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AuthenticatorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Object used to communicate responses back to the AccountManager </para>    
		/// </summary>
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
				public virtual void OnResult(global::Android.Os.Bundle result) /* MethodBuilder.Create */ 
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
				public virtual void OnError(int errorCode, string errorMessage) /* MethodBuilder.Create */ 
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AccountAuthenticatorResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides access to a centralized registry of the user's online accounts. The user enters credentials (username and password) once per account, granting applications access to online resources with "one-click" approval.</para><para>Different online services have different ways of handling accounts and authentication, so the account manager uses pluggable <b>authenticator</b> modules for different <b>account types</b>. Authenticators (which may be written by third parties) handle the actual details of validating account credentials and storing account information. For example, Google, Facebook, and Microsoft Exchange each have their own authenticator.</para><para>Many servers support some notion of an <b>authentication token</b>, which can be used to authenticate a request to the server without sending the user's actual password. (Auth tokens are normally created with a separate request which does include the user's credentials.) AccountManager can generate auth tokens for applications, so the application doesn't need to handle passwords directly. Auth tokens are normally reusable and cached by AccountManager, but must be refreshed periodically. It's the responsibility of applications to <b>invalidate</b> auth tokens when they stop working so the AccountManager knows it needs to regenerate them.</para><para>Applications accessing a server normally go through these steps:</para><para><ul><li><para>Get an instance of AccountManager using get(Context).</para><para></para></li><li><para>List the available accounts using getAccountsByType or getAccountsByTypeAndFeatures. Normally applications will only be interested in accounts with one particular <b>type</b>, which identifies the authenticator. Account <b>features</b> are used to identify particular account subtypes and capabilities. Both the account type and features are authenticator-specific strings, and must be known by the application in coordination with its preferred authenticators.</para><para></para></li><li><para>Select one or more of the available accounts, possibly by asking the user for their preference. If no suitable accounts are available, addAccount may be called to prompt the user to create an account of the appropriate type.</para><para></para></li><li><para><b>Important:</b> If the application is using a previously remembered account selection, it must make sure the account is still in the list of accounts returned by getAccountsByType. Requesting an auth token for an account no longer on the device results in an undefined failure.</para><para></para></li><li><para>Request an auth token for the selected account(s) using one of the getAuthToken methods or related helpers. Refer to the description of each method for exact usage and error handling details.</para><para></para></li><li><para>Make the request using the auth token. The form of the auth token, the format of the request, and the protocol used are all specific to the service you are accessing. The application may use whatever network and protocol libraries are useful.</para><para></para></li><li><para><b>Important:</b> If the request fails with an authentication error, it could be that a cached auth token is stale and no longer honored by the server. The application must call invalidateAuthToken to remove the token from the cache, otherwise requests will continue failing! After invalidating the auth token, immediately go back to the "Request an auth   token" step above. If the process fails the second time, then it can be treated as a "genuine" authentication failure and the user notified or other appropriate actions taken. </para></li></ul></para><para>Some AccountManager methods may need to interact with the user to prompt for credentials, present options, or ask the user to add an account. The caller may choose whether to allow AccountManager to directly launch the necessary user interface and wait for the user, or to return an Intent which the caller may use to launch the interface, or (in some cases) to install a notification which the user can select at any time to launch the interface. To have AccountManager launch the interface directly, the caller must supply the current foreground Activity context.</para><para>Many AccountManager methods take AccountManagerCallback and Handler as parameters. These methods return immediately and run asynchronously. If a callback is provided then AccountManagerCallback#run will be invoked on the Handler's thread when the request completes, successfully or not. The result is retrieved by calling AccountManagerFuture#getResult() on the AccountManagerFuture returned by the method (and also passed to the callback). This method waits for the operation to complete (if necessary) and either returns the result or throws an exception if an error occurred during the operation. To make the request synchronously, call AccountManagerFuture#getResult() immediately on receiving the future from the method; no callback need be supplied.</para><para>Requests which may block, including AccountManagerFuture#getResult(), must never be called on the application's main event thread. These operations throw IllegalStateException if they are used on the main thread. </para>    
		/// </summary>
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
				/// <summary>
				/// <para>Bundle key used for the String account name in results from methods which return information about a particular account. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_ACCOUNT_NAME
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_NAME = "authAccount";
				/// <summary>
				/// <para>Bundle key used for the String account type in results from methods which return information about a particular account. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_ACCOUNT_TYPE
				/// </java-name>
				[Dot42.DexImport("KEY_ACCOUNT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_ACCOUNT_TYPE = "accountType";
				/// <summary>
				/// <para>Bundle key used for the auth token value in results from getAuthToken and friends. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_AUTHTOKEN
				/// </java-name>
				[Dot42.DexImport("KEY_AUTHTOKEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_AUTHTOKEN = "authtoken";
				/// <summary>
				/// <para>Bundle key used for an Intent in results from methods that may require the caller to interact with the user. The Intent can be used to start the corresponding user interface activity. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_INTENT
				/// </java-name>
				[Dot42.DexImport("KEY_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_INTENT = "intent";
				/// <summary>
				/// <para>Bundle key used to supply the password directly in options to confirmCredentials, rather than prompting the user with the standard password prompt. </para>        
				/// </summary>
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
				/// <summary>
				/// <para>Authenticators using 'customTokens' option will also get the UID of the caller </para>        
				/// </summary>
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
				/// <summary>
				/// <para>The Android package of the caller will be set in the options bundle by the AccountManager and will be passed to the AccountManagerService and to the AccountAuthenticators. The uid of the caller will be known by the AccountManagerService as well as the AccountAuthenticators so they will be able to verify that the package is consistent with the uid (a uid might be shared by many packages). </para>        
				/// </summary>
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
				/// <summary>
				/// <para>Action sent as a broadcast Intent by the AccountsService when accounts are added, accounts are removed, or an account's credentials (saved password, etc) are changed.</para><para><para>addOnAccountsUpdatedListener </para></para>        
				/// </summary>
				/// <java-name>
				/// LOGIN_ACCOUNTS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("LOGIN_ACCOUNTS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOGIN_ACCOUNTS_CHANGED_ACTION = "android.accounts.LOGIN_ACCOUNTS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccountManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets an AccountManager instance associated with a Context. The Context will be used as long as the AccountManager is active, so make sure to use a Context whose lifetime is commensurate with any listeners registered to addOnAccountsUpdatedListener or similar methods.</para><para>It is safe to call this method from the main thread.</para><para>No permission is required to call this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManager instance </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/content/Context;)Landroid/accounts/AccountManager;", AccessFlags = 9)]
				public static global::Android.Accounts.AccountManager Get(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.AccountManager);
				}

				/// <summary>
				/// <para>Gets the saved password associated with the account. This is intended for authenticators and related code; applications should get an auth token instead.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The account's password, null if none or if the account doesn't exist </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "(Landroid/accounts/Account;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassword(global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the user data named by "key" associated with the account. This is intended for authenticators and related code to store arbitrary metadata along with accounts. The meaning of the keys and values is up to the authenticator for the account.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The user data, null if the account or key doesn't exist </para>
				/// </returns>
				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUserData(global::Android.Accounts.Account account, string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Lists the currently registered authenticators.</para><para>It is safe to call this method from the main thread.</para><para>No permission is required to call this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of AuthenticatorDescription for every authenticator known to the AccountManager service. Empty (never null) if no authenticators are known. </para>
				/// </returns>
				/// <java-name>
				/// getAuthenticatorTypes
				/// </java-name>
				[Dot42.DexImport("getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;", AccessFlags = 1)]
				public virtual global::Android.Accounts.AuthenticatorDescription[] GetAuthenticatorTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.AuthenticatorDescription[]);
				}

				/// <summary>
				/// <para>Lists all accounts of any type registered on the device. Equivalent to getAccountsByType(null).</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of Account, one for each account. Empty (never null) if no accounts have been added. </para>
				/// </returns>
				/// <java-name>
				/// getAccounts
				/// </java-name>
				[Dot42.DexImport("getAccounts", "()[Landroid/accounts/Account;", AccessFlags = 1)]
				public virtual global::Android.Accounts.Account[] GetAccounts() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.Account[]);
				}

				/// <summary>
				/// <para>Lists all accounts of a particular type. The account type is a string token corresponding to the authenticator and useful domain of the account. For example, there are types corresponding to Google and Facebook. The exact string token to use will be published somewhere associated with the authenticator in question.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of Account, one per matching account. Empty (never null) if no accounts of the specified type have been added. </para>
				/// </returns>
				/// <java-name>
				/// getAccountsByType
				/// </java-name>
				[Dot42.DexImport("getAccountsByType", "(Ljava/lang/String;)[Landroid/accounts/Account;", AccessFlags = 1)]
				public virtual global::Android.Accounts.Account[] GetAccountsByType(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.Account[]);
				}

				/// <summary>
				/// <para>Finds out whether a particular account has all the specified features. Account features are authenticator-specific string tokens identifying boolean account properties. For example, features are used to tell whether Google accounts have a particular service (such as Google Calendar or Google Talk) enabled. The feature names and their meanings are published somewhere associated with the authenticator in question.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Boolean, true if the account exists and has all of the specified features. </para>
				/// </returns>
				/// <java-name>
				/// hasFeatures
				/// </java-name>
				[Dot42.DexImport("hasFeatures", "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCal" +
    "lback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;[Ljava/lang/String;Landroid/accounts/AccountManagerCal" +
    "lback<Ljava/lang/Boolean;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<Ljava/lang/Boolean;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<bool?> HasFeatures(global::Android.Accounts.Account account, string[] features, global::Android.Accounts.IAccountManagerCallback<bool?> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<bool?>);
				}

				/// <summary>
				/// <para>Lists all accounts of a type which have certain features. The account type identifies the authenticator (see getAccountsByType). Account features are authenticator-specific string tokens identifying boolean account properties (see hasFeatures).</para><para>Unlike getAccountsByType, this method calls the authenticator, which may contact the server or do other work to check account features, so the method returns an AccountManagerFuture.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to an array of Account, one per account of the specified type which matches the requested features. </para>
				/// </returns>
				/// <java-name>
				/// getAccountsByTypeAndFeatures
				/// </java-name>
				[Dot42.DexImport("getAccountsByTypeAndFeatures", "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback;La" +
    "ndroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Landroid/accounts/AccountManagerCallback<[L" +
    "android/accounts/Account;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<[Landroid/accounts/Account;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Accounts.Account[]> GetAccountsByTypeAndFeatures(string type, string[] features, global::Android.Accounts.IAccountManagerCallback<global::Android.Accounts.Account[]> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Accounts.Account[]>);
				}

				/// <summary>
				/// <para>Adds an account directly to the AccountManager. Normally used by sign-up wizards associated with authenticators, not directly by applications.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the added account's authenticator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the account was successfully added, false if the account already exists, the account is null, or another error occurs. </para>
				/// </returns>
				/// <java-name>
				/// addAccountExplicitly
				/// </java-name>
				[Dot42.DexImport("addAccountExplicitly", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool AddAccountExplicitly(global::Android.Accounts.Account account, string password, global::Android.Os.Bundle userdata) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes an account from the AccountManager. Does nothing if the account does not exist. Does not delete the account from the server. The authenticator may have its own policies preventing account deletion, in which case the account will not be deleted.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Boolean, true if the account has been successfully removed, false if the authenticator forbids deleting this account. </para>
				/// </returns>
				/// <java-name>
				/// removeAccount
				/// </java-name>
				[Dot42.DexImport("removeAccount", "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback;Landroid/os/H" +
    "andler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Landroid/accounts/AccountManagerCallback<Ljava/lang/Bo" +
    "olean;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Ljava/lang/B" +
    "oolean;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<bool?> RemoveAccount(global::Android.Accounts.Account account, global::Android.Accounts.IAccountManagerCallback<bool?> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<bool?>);
				}

				/// <summary>
				/// <para>Removes an auth token from the AccountManager's cache. Does nothing if the auth token is not currently in the cache. Applications must call this method when the auth token is found to have expired or otherwise become invalid for authenticating requests. The AccountManager does not validate or expire cached auth tokens otherwise.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS or android.Manifest.permission#USE_CREDENTIALS</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateAuthToken
				/// </java-name>
				[Dot42.DexImport("invalidateAuthToken", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void InvalidateAuthToken(string accountType, string authToken) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets an auth token from the AccountManager's cache. If no auth token is cached for this account, null will be returned  a new auth token will not be generated, and the server will not be contacted. Intended for use by the authenticator, not directly by applications.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The cached auth token for this account and type, or null if no auth token is cached or the account does not exist. </para>
				/// </returns>
				/// <java-name>
				/// peekAuthToken
				/// </java-name>
				[Dot42.DexImport("peekAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string PeekAuthToken(global::Android.Accounts.Account account, string authTokenType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets or forgets a saved password. This modifies the local copy of the password used to automatically authenticate the user; it does not change the user's account password on the server. Intended for use by the authenticator, not directly by applications.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Landroid/accounts/Account;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPassword(global::Android.Accounts.Account account, string password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Forgets a saved password. This erases the local copy of the password; it does not change the user's account password on the server. Has the same effect as setPassword(account, null) but requires fewer permissions, and may be used by applications or management interfaces to "sign out" from an account.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearPassword
				/// </java-name>
				[Dot42.DexImport("clearPassword", "(Landroid/accounts/Account;)V", AccessFlags = 1)]
				public virtual void ClearPassword(global::Android.Accounts.Account account) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets one userdata key for an account. Intended by use for the authenticator to stash state for itself, not directly by applications. The meaning of the keys and values is up to the authenticator.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUserData
				/// </java-name>
				[Dot42.DexImport("setUserData", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUserData(global::Android.Accounts.Account account, string key, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds an auth token to the AccountManager cache for an account. If the account does not exist then this call has no effect. Replaces any previous auth token for this account and auth token type. Intended for use by the authenticator, not directly by applications.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#AUTHENTICATE_ACCOUNTS and to have the same UID as the account's authenticator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAuthToken
				/// </java-name>
				[Dot42.DexImport("setAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAuthToken(global::Android.Accounts.Account account, string authTokenType, string authToken) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This convenience helper synchronously gets an auth token with getAuthToken(Account, String, boolean, AccountManagerCallback, Handler).</para><para>This method may block while a network request completes, and must never be made from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#USE_CREDENTIALS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An auth token of the specified type for this account, or null if authentication fails or none can be fetched. </para>
				/// </returns>
				/// <java-name>
				/// blockingGetAuthToken
				/// </java-name>
				[Dot42.DexImport("blockingGetAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BlockingGetAuthToken(global::Android.Accounts.Account account, string authTokenType, bool notifyAuthFailure) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Gets an auth token of the specified type for a particular account, optionally raising a notification if the user must enter credentials. This method is intended for background tasks and services where the user should not be immediately interrupted with a password prompt.</para><para>If a previously generated auth token is cached for this account and type, then it is returned. Otherwise, if a saved password is available, it is sent to the server to generate a new auth token. Otherwise, an Intent is returned which, when started, will prompt the user for a password. If the notifyAuthFailure parameter is set, a status bar notification is also created with the same Intent, alerting the user that they need to enter a password at some point.</para><para>In that case, you may need to wait until the user responds, which could take hours or days or forever. When the user does respond and supply a new password, the account manager will broadcast the LOGIN_ACCOUNTS_CHANGED_ACTION Intent, which applications can use to try again.</para><para>If notifyAuthFailure is not set, it is the application's responsibility to launch the returned Intent at some point. Either way, the result from this call will not wait for user action.</para><para>Some authenticators have auth token <b>types</b>, whose value is authenticator-dependent. Some services use different token types to access different functionality  for example, Google uses different auth tokens to access Gmail and Google Calendar for the same account.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#USE_CREDENTIALS.</para><para>(Other authenticator-specific values may be returned.) If the user must enter credentials, the returned Bundle contains only KEY_INTENT with the Intent needed to launch a prompt.</para><para>If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation is canceled for any reason, incluidng the user canceling a credential request </para></li><li><para>IOException if the authenticator experienced an I/O problem creating a new auth token, usually because of network trouble </para></li></ul>If the account is no longer present on the device, the return value is authenticator-dependent. The caller should verify the validity of the account before requesting an auth token. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use String, android.os.Bundle, boolean, AccountManagerCallback, android.os.Handler) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle with at least the following fields on success: <ul><li><para>KEY_ACCOUNT_NAME - the name of the account you supplied </para></li><li><para>KEY_ACCOUNT_TYPE - the type of the account </para></li><li><para>KEY_AUTHTOKEN - the auth token you wanted </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getAuthToken
				/// </java-name>
				[Dot42.DexImport("getAuthToken", "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCal" +
    "lback;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;ZLandroid/accounts/AccountManagerCal" +
    "lback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManager" +
    "Future<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthToken(global::Android.Accounts.Account account, string authTokenType, bool notifyAuthFailure, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Asks the user to add an account of a specified type. The authenticator for this account type processes this request with the appropriate user interface. If the user does elect to create a new account, the account name is returned.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para>If no activity was specified, the returned Bundle contains only KEY_INTENT with the Intent needed to launch the actual account creation process. If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if no authenticator was registered for this account type or the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation was canceled for any reason, including the user canceling the creation process </para></li><li><para>IOException if the authenticator experienced an I/O problem creating a new account, usually because of network trouble </para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle with these fields if activity was specified and an account was created: <ul><li><para>KEY_ACCOUNT_NAME - the name of the account created </para></li><li><para>KEY_ACCOUNT_TYPE - the type of the account </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// addAccount
				/// </java-name>
				[Dot42.DexImport("addAccount", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landro" +
    "id/app/Activity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)La" +
    "ndroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;Landro" +
    "id/app/Activity;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;La" +
    "ndroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> AddAccount(string accountType, string authTokenType, string[] requiredFeatures, global::Android.Os.Bundle addAccountOptions, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <summary>
				/// <para>Confirms that the user knows the password for an account to make extra sure they are the owner of the account. The user-entered password can be supplied directly, otherwise the authenticator for this account type prompts the user with the appropriate interface. This method is intended for applications which want extra assurance; for example, the phone lock screen uses this to let the user unlock the phone with an account password if they forget the lock pattern.</para><para>If the user-entered password matches a saved password for this account, the request is considered valid; otherwise the authenticator verifies the password (usually by contacting the server).</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para>If no activity or password was specified, the returned Bundle contains only KEY_INTENT with the Intent needed to launch the password prompt. If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation was canceled for any reason, including the user canceling the password prompt </para></li><li><para>IOException if the authenticator experienced an I/O problem verifying the password, usually because of network trouble </para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle with these fields if activity or password was supplied and the account was successfully verified: <ul><li><para>KEY_ACCOUNT_NAME - the name of the account created </para></li><li><para>KEY_ACCOUNT_TYPE - the type of the account </para></li><li><para>KEY_BOOLEAN_RESULT - true to indicate success </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// confirmCredentials
				/// </java-name>
				[Dot42.DexImport("confirmCredentials", "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/acco" +
    "unts/AccountManagerCallback;Landroid/os/Handler;)Landroid/accounts/AccountManage" +
    "rFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Landroid/os/Bundle;Landroid/app/Activity;Landroid/acco" +
    "unts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/a" +
    "ccounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> ConfirmCredentials(global::Android.Accounts.Account account, global::Android.Os.Bundle options, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <summary>
				/// <para>Asks the user to enter a new password for an account, updating the saved credentials for the account. Normally this happens automatically when the server rejects credentials during an auth token fetch, but this can be invoked directly to ensure we have the correct credentials stored.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para>If no activity was specified, the returned Bundle contains only KEY_INTENT with the Intent needed to launch the password prompt. If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation was canceled for any reason, including the user canceling the password prompt </para></li><li><para>IOException if the authenticator experienced an I/O problem verifying the password, usually because of network trouble </para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle with these fields if an activity was supplied and the account credentials were successfully updated: <ul><li><para>KEY_ACCOUNT_NAME - the name of the account created </para></li><li><para>KEY_ACCOUNT_TYPE - the type of the account </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// updateCredentials
				/// </java-name>
				[Dot42.DexImport("updateCredentials", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback;Landroid/os/Handler;)Landroid/acco" +
    "unts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Acti" +
    "vity;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/H" +
    "andler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> UpdateCredentials(global::Android.Accounts.Account account, string authTokenType, global::Android.Os.Bundle options, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <summary>
				/// <para>Offers the user an opportunity to change an authenticator's settings. These properties are for the authenticator in general, not a particular account. Not all authenticators support this method.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle which is empty if properties were edited successfully, or if no activity was specified, contains only KEY_INTENT needed to launch the authenticator's settings dialog. If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if no authenticator was registered for this account type or the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation was canceled for any reason, including the user canceling the settings dialog </para></li><li><para>IOException if the authenticator experienced an I/O problem updating settings, usually because of network trouble </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// editProperties
				/// </java-name>
				[Dot42.DexImport("editProperties", "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback" +
    ";Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/app/Activity;Landroid/accounts/AccountManagerCallback" +
    "<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFutur" +
    "e<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> EditProperties(string accountType, global::Android.App.Activity activity, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <summary>
				/// <para>This convenience helper combines the functionality of getAccountsByTypeAndFeatures, getAuthToken, and addAccount.</para><para>This method gets a list of the accounts matching the specified type and feature set; if there is exactly one, it is used; if there are more than one, the user is prompted to pick one; if there are none, the user is prompted to add one. Finally, an auth token is acquired for the chosen account.</para><para>This method may be called from any thread, but the returned AccountManagerFuture must not be used on the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#MANAGE_ACCOUNTS.</para><para>If an error occurred, AccountManagerFuture#getResult() throws: <ul><li><para>AuthenticatorException if no authenticator was registered for this account type or the authenticator failed to respond </para></li><li><para>OperationCanceledException if the operation was canceled for any reason, including the user canceling any operation </para></li><li><para>IOException if the authenticator experienced an I/O problem updating settings, usually because of network trouble </para></li></ul></para>        
				/// </summary>
				/// <returns>
				/// <para>An AccountManagerFuture which resolves to a Bundle with at least the following fields: <ul><li><para>KEY_ACCOUNT_NAME - the name of the account </para></li><li><para>KEY_ACCOUNT_TYPE - the type of the account </para></li><li><para>KEY_AUTHTOKEN - the auth token you wanted </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getAuthTokenByFeatures
				/// </java-name>
				[Dot42.DexImport("getAuthTokenByFeatures", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Lan" +
    "droid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback;Land" +
    "roid/os/Handler;)Landroid/accounts/AccountManagerFuture;", AccessFlags = 1, Signature = @"(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/app/Activity;Landroid/os/Bundle;Landroid/os/Bundle;Landroid/accounts/AccountManagerCallback<Landroid/os/Bundle;>;Landroid/os/Handler;)Landroid/accounts/AccountManagerFuture<Landroid/os/Bundle;>;")]
				public virtual global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle> GetAuthTokenByFeatures(string accountType, string authTokenType, string[] features, global::Android.App.Activity activity, global::Android.Os.Bundle addAccountOptions, global::Android.Os.Bundle getAuthTokenOptions, global::Android.Accounts.IAccountManagerCallback<global::Android.Os.Bundle> callback, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Accounts.IAccountManagerFuture<global::Android.Os.Bundle>);
				}

				/// <summary>
				/// <para>Returns an intent to an Activity that prompts the user to choose from a list of accounts. The caller will then typically start the activity by calling <code>startActivityForResult(intent, ...);</code>. </para><para>On success the activity returns a Bundle with the account name and type specified using keys KEY_ACCOUNT_NAME and KEY_ACCOUNT_TYPE. </para><para>The most common case is to call this with one account type, e.g.: </para><para><pre>  newChooseAccountIntent(null, null, new String[]{"com.google"}, false, null,
				///        null, null, null);</pre> </para>        
				/// </summary>
				/// <returns>
				/// <para>an Intent that can be used to launch the ChooseAccount activity flow. </para>
				/// </returns>
				/// <java-name>
				/// newChooseAccountIntent
				/// </java-name>
				[Dot42.DexImport("newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/St" +
    "ring;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/I" +
    "ntent;", AccessFlags = 9, Signature = "(Landroid/accounts/Account;Ljava/util/ArrayList<Landroid/accounts/Account;>;[Ljav" +
    "a/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/o" +
    "s/Bundle;)Landroid/content/Intent;")]
				public static global::Android.Content.Intent NewChooseAccountIntent(global::Android.Accounts.Account selectedAccount, global::Java.Util.ArrayList<global::Android.Accounts.Account> allowableAccounts, string[] allowableAccountTypes, bool alwaysPromptForAccount, string descriptionOverrideText, string addAccountAuthTokenType, string[] addAccountRequiredFeatures, global::Android.Os.Bundle addAccountOptions) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Adds an OnAccountsUpdateListener to this instance of the AccountManager. This listener will be notified whenever the list of accounts on the device changes.</para><para>As long as this listener is present, the AccountManager instance will not be garbage-collected, and neither will the Context used to retrieve it, which may be a large Activity instance. To avoid memory leaks, you must remove this listener before then. Normally listeners are added in an Activity or Service's Activity#onCreate and removed in Activity#onDestroy.</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addOnAccountsUpdatedListener
				/// </java-name>
				[Dot42.DexImport("addOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;Landroid/os/Handler;Z)V", AccessFlags = 1)]
				public virtual void AddOnAccountsUpdatedListener(global::Android.Accounts.IOnAccountsUpdateListener listener, global::Android.Os.Handler handler, bool updateImmediately) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes an OnAccountsUpdateListener previously registered with addOnAccountsUpdatedListener. The listener will no longer receive notifications of account changes.</para><para>It is safe to call this method from the main thread.</para><para>No permission is required to call this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnAccountsUpdatedListener
				/// </java-name>
				[Dot42.DexImport("removeOnAccountsUpdatedListener", "(Landroid/accounts/OnAccountsUpdateListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnAccountsUpdatedListener(global::Android.Accounts.IOnAccountsUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Lists the currently registered authenticators.</para><para>It is safe to call this method from the main thread.</para><para>No permission is required to call this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of AuthenticatorDescription for every authenticator known to the AccountManager service. Empty (never null) if no authenticators are known. </para>
				/// </returns>
				/// <java-name>
				/// getAuthenticatorTypes
				/// </java-name>
				public global::Android.Accounts.AuthenticatorDescription[] AuthenticatorTypes
				{
				[Dot42.DexImport("getAuthenticatorTypes", "()[Landroid/accounts/AuthenticatorDescription;", AccessFlags = 1)]
						get{ return GetAuthenticatorTypes(); }
				}

				/// <summary>
				/// <para>Lists all accounts of any type registered on the device. Equivalent to getAccountsByType(null).</para><para>It is safe to call this method from the main thread.</para><para>This method requires the caller to hold the permission android.Manifest.permission#GET_ACCOUNTS.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of Account, one for each account. Empty (never null) if no accounts have been added. </para>
				/// </returns>
				/// <java-name>
				/// getAccounts
				/// </java-name>
				public global::Android.Accounts.Account[] Accounts
				{
				[Dot42.DexImport("getAccounts", "()[Landroid/accounts/Account;", AccessFlags = 1)]
						get{ return GetAccounts(); }
				}

		}

}


