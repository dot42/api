// Copyright (C) 2014 dot42
//
// Original filename: Android.Database.Sqlite.cs
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
namespace Android.Database.Sqlite
{
		/// <summary>
		/// <para>A listener for transaction events. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteTransactionListener
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteTransactionListener", AccessFlags = 1537)]
		public partial interface ISQLiteTransactionListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called immediately after the transaction begins. </para>        
				/// </summary>
				/// <java-name>
				/// onBegin
				/// </java-name>
				[Dot42.DexImport("onBegin", "()V", AccessFlags = 1025)]
				void OnBegin() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called immediately before commiting the transaction. </para>        
				/// </summary>
				/// <java-name>
				/// onCommit
				/// </java-name>
				[Dot42.DexImport("onCommit", "()V", AccessFlags = 1025)]
				void OnCommit() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called if the transaction is about to be rolled back. </para>        
				/// </summary>
				/// <java-name>
				/// onRollback
				/// </java-name>
				[Dot42.DexImport("onRollback", "()V", AccessFlags = 1025)]
				void OnRollback() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A base class for compiled SQLite programs. </para><para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteProgram
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteProgram", AccessFlags = 1057)]
		public abstract partial class SQLiteProgram : global::Android.Database.Sqlite.SQLiteClosable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mDatabase
				/// </java-name>
				[Dot42.DexImport("mDatabase", "Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 4)]
				protected internal global::Android.Database.Sqlite.SQLiteDatabase MDatabase;
				/// <java-name>
				/// nHandle
				/// </java-name>
				[Dot42.DexImport("nHandle", "I", AccessFlags = 4)]
				protected internal int NHandle;
				/// <java-name>
				/// nStatement
				/// </java-name>
				[Dot42.DexImport("nStatement", "I", AccessFlags = 4)]
				protected internal int NStatement;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SQLiteProgram() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the last reference to the object was released by a call to releaseReference() or close(). </para>        
				/// </summary>
				/// <java-name>
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 4)]
				protected internal override void OnAllReferencesReleased() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAllReferencesReleasedFromContainer
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleasedFromContainer", "()V", AccessFlags = 4)]
				protected internal override void OnAllReferencesReleasedFromContainer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unimplemented. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated and must not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUniqueId
				/// </java-name>
				[Dot42.DexImport("getUniqueId", "()I", AccessFlags = 17)]
				public int GetUniqueId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;Z)V", AccessFlags = 4)]
				protected internal virtual void Compile(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a NULL value to this statement. The value remains bound until clearBindings is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindNull
				/// </java-name>
				[Dot42.DexImport("bindNull", "(I)V", AccessFlags = 1)]
				public virtual void BindNull(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a long value to this statement. The value remains bound until clearBindings is called. *addToBindArgs </para>        
				/// </summary>
				/// <java-name>
				/// bindLong
				/// </java-name>
				[Dot42.DexImport("bindLong", "(IJ)V", AccessFlags = 1)]
				public virtual void BindLong(int index, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a double value to this statement. The value remains bound until clearBindings is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindDouble
				/// </java-name>
				[Dot42.DexImport("bindDouble", "(ID)V", AccessFlags = 1)]
				public virtual void BindDouble(int index, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a String value to this statement. The value remains bound until clearBindings is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindString
				/// </java-name>
				[Dot42.DexImport("bindString", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void BindString(int index, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a byte array value to this statement. The value remains bound until clearBindings is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindBlob
				/// </java-name>
				[Dot42.DexImport("bindBlob", "(I[B)V", AccessFlags = 1)]
				public virtual void BindBlob(int index, sbyte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a byte array value to this statement. The value remains bound until clearBindings is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindBlob
				/// </java-name>
				[Dot42.DexImport("bindBlob", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void BindBlob(int index, byte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears all existing bindings. Unset bindings are treated as NULL. </para>        
				/// </summary>
				/// <java-name>
				/// clearBindings
				/// </java-name>
				[Dot42.DexImport("clearBindings", "()V", AccessFlags = 1)]
				public virtual void ClearBindings() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Given an array of String bindArgs, this method binds all of them in one single call.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindAllArgsAsStrings
				/// </java-name>
				[Dot42.DexImport("bindAllArgsAsStrings", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void BindAllArgsAsStrings(string[] bindArgs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_compile
				/// </java-name>
				[Dot42.DexImport("native_compile", "(Ljava/lang/String;)V", AccessFlags = 276)]
				protected internal void Native_compile(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_finalize
				/// </java-name>
				[Dot42.DexImport("native_finalize", "()V", AccessFlags = 276)]
				protected internal void Native_finalize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_null
				/// </java-name>
				[Dot42.DexImport("native_bind_null", "(I)V", AccessFlags = 276)]
				protected internal void Native_bind_null(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_long
				/// </java-name>
				[Dot42.DexImport("native_bind_long", "(IJ)V", AccessFlags = 276)]
				protected internal void Native_bind_long(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_double
				/// </java-name>
				[Dot42.DexImport("native_bind_double", "(ID)V", AccessFlags = 276)]
				protected internal void Native_bind_double(int int32, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_string
				/// </java-name>
				[Dot42.DexImport("native_bind_string", "(ILjava/lang/String;)V", AccessFlags = 276)]
				protected internal void Native_bind_string(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_blob
				/// </java-name>
				[Dot42.DexImport("native_bind_blob", "(I[B)V", AccessFlags = 276)]
				protected internal void Native_bind_blob(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// native_bind_blob
				/// </java-name>
				[Dot42.DexImport("native_bind_blob", "(I[B)V", AccessFlags = 276, IgnoreFromJava = true)]
				protected internal void Native_bind_blob(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unimplemented. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated and must not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUniqueId
				/// </java-name>
				public int UniqueId
				{
				[Dot42.DexImport("getUniqueId", "()I", AccessFlags = 17)]
						get{ return GetUniqueId(); }
				}

		}

		/// <summary>
		/// <para>An object created from a SQLiteDatabase that can be closed.</para><para>This class implements a primitive reference counting scheme for database objects. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteClosable
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteClosable", AccessFlags = 1057)]
		public abstract partial class SQLiteClosable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteClosable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the last reference to the object was released by a call to releaseReference() or close(). </para>        
				/// </summary>
				/// <java-name>
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 1028)]
				protected internal abstract void OnAllReferencesReleased() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the last reference to the object was released by a call to releaseReferenceFromContainer().</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onAllReferencesReleasedFromContainer
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleasedFromContainer", "()V", AccessFlags = 4)]
				protected internal virtual void OnAllReferencesReleasedFromContainer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Acquires a reference to the object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// acquireReference
				/// </java-name>
				[Dot42.DexImport("acquireReference", "()V", AccessFlags = 1)]
				public virtual void AcquireReference() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases a reference to the object, closing the object if the last reference was released.</para><para><para>onAllReferencesReleased() </para></para>        
				/// </summary>
				/// <java-name>
				/// releaseReference
				/// </java-name>
				[Dot42.DexImport("releaseReference", "()V", AccessFlags = 1)]
				public virtual void ReleaseReference() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases a reference to the object that was owned by the container of the object, closing the object if the last reference was released.</para><para><para>onAllReferencesReleasedFromContainer() </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// releaseReferenceFromContainer
				/// </java-name>
				[Dot42.DexImport("releaseReferenceFromContainer", "()V", AccessFlags = 1)]
				public virtual void ReleaseReferenceFromContainer() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Exposes methods to manage a SQLite database.</para><para>SQLiteDatabase has methods to create, delete, execute SQL commands, and perform other common database management tasks. </para><para>See the Notepad sample application in the SDK for an example of creating and managing a database. </para><para>Database names must be unique within an application, not across all applications. </para><para><h3>Localized Collation - ORDER BY</h3></para><para>In addition to SQLite's default <code>BINARY</code> collator, Android supplies two more, <code>LOCALIZED</code>, which changes with the system's current locale, and <code>UNICODE</code>, which is the Unicode Collation Algorithm and not tailored to the current locale. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteDatabase
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDatabase", AccessFlags = 33)]
		public partial class SQLiteDatabase : global::Android.Database.Sqlite.SQLiteClosable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>When a constraint violation occurs, an immediate ROLLBACK occurs, thus ending the current transaction, and the command aborts with a return code of SQLITE_CONSTRAINT. If no transaction is active (other than the implied transaction that is created on every command) then this algorithm works the same as ABORT. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_ROLLBACK
				/// </java-name>
				[Dot42.DexImport("CONFLICT_ROLLBACK", "I", AccessFlags = 25)]
				public const int CONFLICT_ROLLBACK = 1;
				/// <summary>
				/// <para>When a constraint violation occurs,no ROLLBACK is executed so changes from prior commands within the same transaction are preserved. This is the default behavior. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_ABORT
				/// </java-name>
				[Dot42.DexImport("CONFLICT_ABORT", "I", AccessFlags = 25)]
				public const int CONFLICT_ABORT = 2;
				/// <summary>
				/// <para>When a constraint violation occurs, the command aborts with a return code SQLITE_CONSTRAINT. But any changes to the database that the command made prior to encountering the constraint violation are preserved and are not backed out. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_FAIL
				/// </java-name>
				[Dot42.DexImport("CONFLICT_FAIL", "I", AccessFlags = 25)]
				public const int CONFLICT_FAIL = 3;
				/// <summary>
				/// <para>When a constraint violation occurs, the one row that contains the constraint violation is not inserted or changed. But the command continues executing normally. Other rows before and after the row that contained the constraint violation continue to be inserted or updated normally. No error is returned. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_IGNORE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_IGNORE", "I", AccessFlags = 25)]
				public const int CONFLICT_IGNORE = 4;
				/// <summary>
				/// <para>When a UNIQUE constraint violation occurs, the pre-existing rows that are causing the constraint violation are removed prior to inserting or updating the current row. Thus the insert or update always occurs. The command continues executing normally. No error is returned. If a NOT NULL constraint violation occurs, the NULL value is replaced by the default value for that column. If the column has no default value, then the ABORT algorithm is used. If a CHECK constraint violation occurs then the IGNORE algorithm is used. When this conflict resolution strategy deletes rows in order to satisfy a constraint, it does not invoke delete triggers on those rows. This behavior might change in a future release. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_REPLACE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_REPLACE", "I", AccessFlags = 25)]
				public const int CONFLICT_REPLACE = 5;
				/// <summary>
				/// <para>Use the following when no conflict action is specified. </para>        
				/// </summary>
				/// <java-name>
				/// CONFLICT_NONE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_NONE", "I", AccessFlags = 25)]
				public const int CONFLICT_NONE = 0;
				/// <summary>
				/// <para>Maximum Length Of A LIKE Or GLOB Pattern The pattern matching algorithm used in the default LIKE and GLOB implementation of SQLite can exhibit O(N^2) performance (where N is the number of characters in the pattern) for certain pathological cases. To avoid denial-of-service attacks the length of the LIKE or GLOB pattern is limited to SQLITE_MAX_LIKE_PATTERN_LENGTH bytes. The default value of this limit is 50000. A modern workstation can evaluate even a pathological LIKE or GLOB pattern of 50000 bytes relatively quickly. The denial of service problem only comes into play when the pattern length gets into millions of bytes. Nevertheless, since most useful LIKE or GLOB patterns are at most a few dozen bytes in length, paranoid application developers may want to reduce this parameter to something in the range of a few hundred if they know that external users are able to generate arbitrary patterns. </para>        
				/// </summary>
				/// <java-name>
				/// SQLITE_MAX_LIKE_PATTERN_LENGTH
				/// </java-name>
				[Dot42.DexImport("SQLITE_MAX_LIKE_PATTERN_LENGTH", "I", AccessFlags = 25)]
				public const int SQLITE_MAX_LIKE_PATTERN_LENGTH = 50000;
				/// <summary>
				/// <para>Open flag: Flag for openDatabase to open the database for reading and writing. If the disk is full, this may fail even before you actually write anything.</para><para>{} Note that the value of this flag is 0, so it is the default. </para>        
				/// </summary>
				/// <java-name>
				/// OPEN_READWRITE
				/// </java-name>
				[Dot42.DexImport("OPEN_READWRITE", "I", AccessFlags = 25)]
				public const int OPEN_READWRITE = 0;
				/// <summary>
				/// <para>Open flag: Flag for openDatabase to open the database for reading only. This is the only reliable way to open a database if the disk may be full. </para>        
				/// </summary>
				/// <java-name>
				/// OPEN_READONLY
				/// </java-name>
				[Dot42.DexImport("OPEN_READONLY", "I", AccessFlags = 25)]
				public const int OPEN_READONLY = 1;
				/// <summary>
				/// <para>Open flag: Flag for openDatabase to open the database without support for localized collators.</para><para>{} This causes the collator <code>LOCALIZED</code> not to be created. You must be consistent when using this flag to use the setting the database was created with. If this is set, setLocale will do nothing. </para>        
				/// </summary>
				/// <java-name>
				/// NO_LOCALIZED_COLLATORS
				/// </java-name>
				[Dot42.DexImport("NO_LOCALIZED_COLLATORS", "I", AccessFlags = 25)]
				public const int NO_LOCALIZED_COLLATORS = 16;
				/// <summary>
				/// <para>Open flag: Flag for openDatabase to create the database file if it does not already exist. </para>        
				/// </summary>
				/// <java-name>
				/// CREATE_IF_NECESSARY
				/// </java-name>
				[Dot42.DexImport("CREATE_IF_NECESSARY", "I", AccessFlags = 25)]
				public const int CREATE_IF_NECESSARY = 268435456;
				/// <summary>
				/// <para>Absolute max value that can be set by setMaxSqlCacheSize(int).</para><para>Each prepared-statement is between 1K - 6K, depending on the complexity of the SQL statement &amp; schema. A large SQL cache may use a significant amount of memory. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_SQL_CACHE_SIZE
				/// </java-name>
				[Dot42.DexImport("MAX_SQL_CACHE_SIZE", "I", AccessFlags = 25)]
				public const int MAX_SQL_CACHE_SIZE = 100;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SQLiteDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the last reference to the object was released by a call to releaseReference() or close(). </para>        
				/// </summary>
				/// <java-name>
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 4)]
				protected internal override void OnAllReferencesReleased() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to release memory that SQLite holds but does not require to operate properly. Typically this memory will come from the page cache.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually released </para>
				/// </returns>
				/// <java-name>
				/// releaseMemory
				/// </java-name>
				[Dot42.DexImport("releaseMemory", "()I", AccessFlags = 265)]
				public static int ReleaseMemory() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Control whether or not the SQLiteDatabase is made thread-safe by using locks around critical sections. This is pretty expensive, so if you know that your DB will only be used by a single thread then you should set this to false. The default is true. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method now does nothing. Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setLockingEnabled
				/// </java-name>
				[Dot42.DexImport("setLockingEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetLockingEnabled(bool lockingEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begins a transaction in EXCLUSIVE mode. </para><para>Transactions can be nested. When the outer transaction is ended all of the work done in that transaction and all of the nested transactions will be committed or rolled back. The changes will be rolled back if any transaction is ended without being marked as clean (by calling setTransactionSuccessful). Otherwise they will be committed. </para><para>Here is the standard idiom for transactions:</para><para><pre>
				///          db.beginTransaction();
				///          try {
				///            ...
				///            db.setTransactionSuccessful();
				///          } finally {
				///            db.endTransaction();
				///          }
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// beginTransaction
				/// </java-name>
				[Dot42.DexImport("beginTransaction", "()V", AccessFlags = 1)]
				public virtual void BeginTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begins a transaction in IMMEDIATE mode. Transactions can be nested. When the outer transaction is ended all of the work done in that transaction and all of the nested transactions will be committed or rolled back. The changes will be rolled back if any transaction is ended without being marked as clean (by calling setTransactionSuccessful). Otherwise they will be committed. </para><para>Here is the standard idiom for transactions:</para><para><pre>
				///          db.beginTransactionNonExclusive();
				///          try {
				///            ...
				///            db.setTransactionSuccessful();
				///          } finally {
				///            db.endTransaction();
				///          }
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// beginTransactionNonExclusive
				/// </java-name>
				[Dot42.DexImport("beginTransactionNonExclusive", "()V", AccessFlags = 1)]
				public virtual void BeginTransactionNonExclusive() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begins a transaction in EXCLUSIVE mode. </para><para>Transactions can be nested. When the outer transaction is ended all of the work done in that transaction and all of the nested transactions will be committed or rolled back. The changes will be rolled back if any transaction is ended without being marked as clean (by calling setTransactionSuccessful). Otherwise they will be committed. </para><para>Here is the standard idiom for transactions:</para><para><pre>
				///          db.beginTransactionWithListener(listener);
				///          try {
				///            ...
				///            db.setTransactionSuccessful();
				///          } finally {
				///            db.endTransaction();
				///          }
				///        </pre></para><para></para>        
				/// </summary>
				/// <java-name>
				/// beginTransactionWithListener
				/// </java-name>
				[Dot42.DexImport("beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V", AccessFlags = 1)]
				public virtual void BeginTransactionWithListener(global::Android.Database.Sqlite.ISQLiteTransactionListener transactionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begins a transaction in IMMEDIATE mode. Transactions can be nested. When the outer transaction is ended all of the work done in that transaction and all of the nested transactions will be committed or rolled back. The changes will be rolled back if any transaction is ended without being marked as clean (by calling setTransactionSuccessful). Otherwise they will be committed. </para><para>Here is the standard idiom for transactions:</para><para><pre>
				///          db.beginTransactionWithListenerNonExclusive(listener);
				///          try {
				///            ...
				///            db.setTransactionSuccessful();
				///          } finally {
				///            db.endTransaction();
				///          }
				///        </pre></para><para></para>        
				/// </summary>
				/// <java-name>
				/// beginTransactionWithListenerNonExclusive
				/// </java-name>
				[Dot42.DexImport("beginTransactionWithListenerNonExclusive", "(Landroid/database/sqlite/SQLiteTransactionListener;)V", AccessFlags = 1)]
				public virtual void BeginTransactionWithListenerNonExclusive(global::Android.Database.Sqlite.ISQLiteTransactionListener transactionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>End a transaction. See beginTransaction for notes about how to use this and when transactions are committed and rolled back. </para>        
				/// </summary>
				/// <java-name>
				/// endTransaction
				/// </java-name>
				[Dot42.DexImport("endTransaction", "()V", AccessFlags = 1)]
				public virtual void EndTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Marks the current transaction as successful. Do not do any more database work between calling this and calling endTransaction. Do as little non-database work as possible in that situation too. If any errors are encountered between this and endTransaction the transaction will still be committed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTransactionSuccessful
				/// </java-name>
				[Dot42.DexImport("setTransactionSuccessful", "()V", AccessFlags = 1)]
				public virtual void SetTransactionSuccessful() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if the current thread has a transaction pending.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the current thread is in a transaction. </para>
				/// </returns>
				/// <java-name>
				/// inTransaction
				/// </java-name>
				[Dot42.DexImport("inTransaction", "()Z", AccessFlags = 1)]
				public virtual bool InTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the current thread is holding an active connection to the database. </para><para>The name of this method comes from a time when having an active connection to the database meant that the thread was holding an actual lock on the database. Nowadays, there is no longer a true "database lock" although threads may block if they cannot acquire a database connection to perform a particular operation. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the current thread is holding an active connection to the database. </para>
				/// </returns>
				/// <java-name>
				/// isDbLockedByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isDbLockedByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsDbLockedByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Always returns false. </para><para>There is no longer the concept of a database lock, so this method always returns false. </para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Always returns false. Do not use this method. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>False. </para>
				/// </returns>
				/// <java-name>
				/// isDbLockedByOtherThreads
				/// </java-name>
				[Dot42.DexImport("isDbLockedByOtherThreads", "()Z", AccessFlags = 1)]
				public virtual bool IsDbLockedByOtherThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Temporarily end the transaction to let other threads run. The transaction is assumed to be successful so far. Do not call setTransactionSuccessful before calling this. When this returns a new transaction will have been created but not marked as successful. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>if the db is locked more than once (becuase of nested transactions) then the lock will not be yielded. Use yieldIfContendedSafely instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the transaction was yielded </para>
				/// </returns>
				/// <java-name>
				/// yieldIfContended
				/// </java-name>
				[Dot42.DexImport("yieldIfContended", "()Z", AccessFlags = 1)]
				public virtual bool YieldIfContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Temporarily end the transaction to let other threads run. The transaction is assumed to be successful so far. Do not call setTransactionSuccessful before calling this. When this returns a new transaction will have been created but not marked as successful. This assumes that there are no nested transactions (beginTransaction has only been called once) and will throw an exception if that is not the case. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the transaction was yielded </para>
				/// </returns>
				/// <java-name>
				/// yieldIfContendedSafely
				/// </java-name>
				[Dot42.DexImport("yieldIfContendedSafely", "()Z", AccessFlags = 1)]
				public virtual bool YieldIfContendedSafely() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Temporarily end the transaction to let other threads run. The transaction is assumed to be successful so far. Do not call setTransactionSuccessful before calling this. When this returns a new transaction will have been created but not marked as successful. This assumes that there are no nested transactions (beginTransaction has only been called once) and will throw an exception if that is not the case. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the transaction was yielded </para>
				/// </returns>
				/// <java-name>
				/// yieldIfContendedSafely
				/// </java-name>
				[Dot42.DexImport("yieldIfContendedSafely", "(J)Z", AccessFlags = 1)]
				public virtual bool YieldIfContendedSafely(long sleepAfterYieldDelay) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Deprecated. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer serves any useful purpose and has been deprecated. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getSyncedTables
				/// </java-name>
				[Dot42.DexImport("getSyncedTables", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				public virtual global::Java.Util.IMap<string, string> GetSyncedTables() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <summary>
				/// <para>Open the database according to the flags OPEN_READWRITE OPEN_READONLY CREATE_IF_NECESSARY and/or NO_LOCALIZED_COLLATORS.</para><para>Sets the locale of the database to the the system's current locale. Call setLocale if you would like something else.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly opened database </para>
				/// </returns>
				/// <java-name>
				/// openDatabase
				/// </java-name>
				[Dot42.DexImport("openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase(string path, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Open the database according to the flags OPEN_READWRITE OPEN_READONLY CREATE_IF_NECESSARY and/or NO_LOCALIZED_COLLATORS.</para><para>Sets the locale of the database to the the system's current locale. Call setLocale if you would like something else.</para><para>Accepts input param: a concrete instance of DatabaseErrorHandler to be used to handle corruption when sqlite reports database corruption.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly opened database </para>
				/// </returns>
				/// <java-name>
				/// openDatabase
				/// </java-name>
				[Dot42.DexImport("openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ILandroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase(string path, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, int flags, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Equivalent to openDatabase(file.getPath(), factory, CREATE_IF_NECESSARY). </para>        
				/// </summary>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/da" +
    "tabase/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(global::Java.Io.File file, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Equivalent to openDatabase(file.getPath(), factory, CREATE_IF_NECESSARY). </para>        
				/// </summary>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroi" +
    "d/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string file, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Equivalent to openDatabase(path, factory, CREATE_IF_NECESSARY, errorHandler). </para>        
				/// </summary>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid" +
    "/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string path, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Create a memory backed SQLite database. Its contents will be destroyed when the database is closed.</para><para>Sets the locale of the database to the the system's current locale. Call setLocale if you would like something else.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a SQLiteDatabase object, or null if the database can't be created </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/" +
    "SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase Create(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the database version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the database version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the database version.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public virtual void SetVersion(int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the maximum size the database may grow to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new maximum database size </para>
				/// </returns>
				/// <java-name>
				/// getMaximumSize
				/// </java-name>
				[Dot42.DexImport("getMaximumSize", "()J", AccessFlags = 1)]
				public virtual long GetMaximumSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the maximum size the database will grow to. The maximum size cannot be set below the current size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new maximum database size </para>
				/// </returns>
				/// <java-name>
				/// setMaximumSize
				/// </java-name>
				[Dot42.DexImport("setMaximumSize", "(J)J", AccessFlags = 1)]
				public virtual long SetMaximumSize(long numBytes) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the current database page size, in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the database page size, in bytes </para>
				/// </returns>
				/// <java-name>
				/// getPageSize
				/// </java-name>
				[Dot42.DexImport("getPageSize", "()J", AccessFlags = 1)]
				public virtual long GetPageSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the database page size. The page size must be a power of two. This method does not work if any data has been written to the database file, and must be called right after the database has been created.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPageSize
				/// </java-name>
				[Dot42.DexImport("setPageSize", "(J)V", AccessFlags = 1)]
				public virtual void SetPageSize(long numBytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Mark this table as syncable. When an update occurs in this table the _sync_dirty field will be set to ensure proper syncing operation.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer serves any useful purpose and has been deprecated. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// markTableSyncable
				/// </java-name>
				[Dot42.DexImport("markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void MarkTableSyncable(string table, string deletedTable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Mark this table as syncable, with the _sync_dirty residing in another table. When an update occurs in this table the _sync_dirty field of the row in updateTable with the _id in foreignKey will be set to ensure proper syncing operation.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer serves any useful purpose and has been deprecated. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// markTableSyncable
				/// </java-name>
				[Dot42.DexImport("markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void MarkTableSyncable(string table, string foreignKey, string updateTable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds the name of the first table, which is editable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first table listed </para>
				/// </returns>
				/// <java-name>
				/// findEditTable
				/// </java-name>
				[Dot42.DexImport("findEditTable", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FindEditTable(string tables) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compiles an SQL statement into a reusable pre-compiled statement object. The parameters are identical to execSQL(String). You may put ?s in the statement and fill in those values with SQLiteProgram#bindString and SQLiteProgram#bindLong each time you want to run the statement. Statements may not return result sets larger than 1x1. </para><para>No two threads should be using the same SQLiteStatement at the same time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A pre-compiled SQLiteStatement object. Note that SQLiteStatements are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// compileStatement
				/// </java-name>
				[Dot42.DexImport("compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;", AccessFlags = 1)]
				public virtual global::Android.Database.Sqlite.SQLiteStatement CompileStatement(string sql) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteStatement);
				}

				/// <summary>
				/// <para>Query the given URL, returning a Cursor over the result set.</para><para><para>Cursor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava" +
    "/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/dat" +
    "abase/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(bool distinct, string table, string[] columns, string selection, string[] selectionArgs, string groupBy, string having, string orderBy, string limit) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Query the given URL, returning a Cursor over the result set.</para><para><para>Cursor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// queryWithFactory
				/// </java-name>
				[Dot42.DexImport("queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/" +
    "lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/St" +
    "ring;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor QueryWithFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, bool distinct, string table, string[] columns, string selection, string[] selectionArgs, string groupBy, string having, string orderBy, string limit) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Query the given table, returning a Cursor over the result set.</para><para><para>Cursor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(string table, string[] columns, string selection, string[] selectionArgs, string groupBy, string having, string orderBy) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Query the given table, returning a Cursor over the result set.</para><para><para>Cursor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/data" +
    "base/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(string table, string[] columns, string selection, string[] selectionArgs, string groupBy, string having, string orderBy, string limit) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Runs the provided SQL and returns a Cursor over the result set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// rawQuery
				/// </java-name>
				[Dot42.DexImport("rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RawQuery(string sql, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Runs the provided SQL and returns a cursor over the result set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Cursor object, which is positioned before the first entry. Note that Cursors are not synchronized, see the documentation for more details. </para>
				/// </returns>
				/// <java-name>
				/// rawQueryWithFactory
				/// </java-name>
				[Dot42.DexImport("rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/l" +
    "ang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RawQueryWithFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, string sql, string[] selectionArgs, string editTable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Convenience method for inserting a row into the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long Insert(string table, string nullColumnHack, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Convenience method for inserting a row into the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
				/// </returns>
				/// <java-name>
				/// insertOrThrow
				/// </java-name>
				[Dot42.DexImport("insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long InsertOrThrow(string table, string nullColumnHack, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Convenience method for replacing a row in the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long Replace(string table, string nullColumnHack, global::Android.Content.ContentValues initialValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Convenience method for replacing a row in the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
				/// </returns>
				/// <java-name>
				/// replaceOrThrow
				/// </java-name>
				[Dot42.DexImport("replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long ReplaceOrThrow(string table, string nullColumnHack, global::Android.Content.ContentValues initialValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>General method for inserting a row into the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the newly inserted row OR the primary key of the existing row if the input param 'conflictAlgorithm' = CONFLICT_IGNORE OR -1 if any error </para>
				/// </returns>
				/// <java-name>
				/// insertWithOnConflict
				/// </java-name>
				[Dot42.DexImport("insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J", AccessFlags = 1)]
				public virtual long InsertWithOnConflict(string table, string nullColumnHack, global::Android.Content.ContentValues initialValues, int conflictAlgorithm) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Convenience method for deleting rows in the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows affected if a whereClause is passed in, 0 otherwise. To remove all rows and get a count pass "1" as the whereClause. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int Delete(string table, string whereClause, string[] whereArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Convenience method for updating rows in the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows affected </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/S" +
    "tring;)I", AccessFlags = 1)]
				public virtual int Update(string table, global::Android.Content.ContentValues values, string whereClause, string[] whereArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Convenience method for updating rows in the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows affected </para>
				/// </returns>
				/// <java-name>
				/// updateWithOnConflict
				/// </java-name>
				[Dot42.DexImport("updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/S" +
    "tring;I)I", AccessFlags = 1)]
				public virtual int UpdateWithOnConflict(string table, global::Android.Content.ContentValues values, string whereClause, string[] whereArgs, int conflictAlgorithm) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Execute a single SQL statement that is NOT a SELECT or any other SQL statement that returns data. </para><para>It has no means to return any data (such as the number of affected rows). Instead, you're encouraged to use insert(String, String, ContentValues), update(String, ContentValues, String, String[]), et al, when possible. </para><para>When using enableWriteAheadLogging(), journal_mode is automatically managed by this class. So, do not set journal_mode using "PRAGMA journal_mode'&lt;value&gt;" statement if your app is using enableWriteAheadLogging() </para><para></para>        
				/// </summary>
				/// <java-name>
				/// execSQL
				/// </java-name>
				[Dot42.DexImport("execSQL", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ExecSQL(string sql) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Execute a single SQL statement that is NOT a SELECT/INSERT/UPDATE/DELETE. </para><para>For INSERT statements, use any of the following instead. <ul><li><para>insert(String, String, ContentValues) </para></li><li><para>insertOrThrow(String, String, ContentValues) </para></li><li><para>insertWithOnConflict(String, String, ContentValues, int) </para></li></ul></para><para>For UPDATE statements, use any of the following instead. <ul><li><para>update(String, ContentValues, String, String[]) </para></li><li><para>updateWithOnConflict(String, ContentValues, String, String[], int) </para></li></ul></para><para>For DELETE statements, use any of the following instead. <ul><li><para>delete(String, String, String[]) </para></li></ul></para><para>For example, the following are good candidates for using this method: <ul><li><para>ALTER TABLE </para></li><li><para>CREATE or DROP table / trigger / view / index / virtual table </para></li><li><para>REINDEX </para></li><li><para>RELEASE </para></li><li><para>SAVEPOINT </para></li><li><para>PRAGMA that returns no data </para></li></ul></para><para>When using enableWriteAheadLogging(), journal_mode is automatically managed by this class. So, do not set journal_mode using "PRAGMA journal_mode'&lt;value&gt;" statement if your app is using enableWriteAheadLogging() </para><para></para>        
				/// </summary>
				/// <java-name>
				/// execSQL
				/// </java-name>
				[Dot42.DexImport("execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void ExecSQL(string sql, object[] bindArgs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SQLiteDatabase() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the database is opened as read only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if database is opened as read only. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the database is currently open.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the database is currently open (has not been closed). </para>
				/// </returns>
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
				public virtual bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the new version code is greater than the current database version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the new version code is greater than the current database version. </para>
				/// </returns>
				/// <java-name>
				/// needUpgrade
				/// </java-name>
				[Dot42.DexImport("needUpgrade", "(I)Z", AccessFlags = 1)]
				public virtual bool NeedUpgrade(int newVersion) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the path to the database file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The path to the database file. </para>
				/// </returns>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the locale for this database. Does nothing if this database has the NO_LOCALIZED_COLLATORS flag set or was opened read only.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the maximum size of the prepared-statement cache for this database. (size of the cache = number of compiled-sql-statements stored in the cache). </para><para>Maximum cache size can ONLY be increased from its current size (default = 10). If this method is called with smaller size than the current maximum value, then IllegalStateException is thrown. </para><para>This method is thread-safe.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxSqlCacheSize
				/// </java-name>
				[Dot42.DexImport("setMaxSqlCacheSize", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxSqlCacheSize(int cacheSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method enables parallel execution of queries from multiple threads on the same database. It does this by opening multiple connections to the database and using a different database connection for each query. The database journal mode is also changed to enable writes to proceed concurrently with reads. </para><para>When write-ahead logging is not enabled (the default), it is not possible for reads and writes to occur on the database at the same time. Before modifying the database, the writer implicitly acquires an exclusive lock on the database which prevents readers from accessing the database until the write is completed. </para><para>In contrast, when write-ahead logging is enabled (by calling this method), write operations occur in a separate log file which allows reads to proceed concurrently. While a write is in progress, readers on other threads will perceive the state of the database as it was before the write began. When the write completes, readers on other threads will then perceive the new state of the database. </para><para>It is a good idea to enable write-ahead logging whenever a database will be concurrently accessed and modified by multiple threads at the same time. However, write-ahead logging uses significantly more memory than ordinary journaling because there are multiple connections to the same database. So if a database will only be used by a single thread, or if optimizing concurrency is not very important, then write-ahead logging should be disabled. </para><para>After calling this method, execution of queries in parallel is enabled as long as the database remains open. To disable execution of queries in parallel, either call disableWriteAheadLogging or close the database and reopen it. </para><para>The maximum number of connections used to execute queries in parallel is dependent upon the device memory and possibly other properties. </para><para>If a query is part of a transaction, then it is executed on the same database handle the transaction was begun. </para><para>Writers should use beginTransactionNonExclusive() or beginTransactionWithListenerNonExclusive(SQLiteTransactionListener) to start a transaction. Non-exclusive mode allows database file to be in readable by other threads executing queries. </para><para>If the database has any attached databases, then execution of queries in parallel is NOT possible. Likewise, write-ahead logging is not supported for read-only databases or memory databases. In such cases, enableWriteAheadLogging returns false. </para><para>The best way to enable write-ahead logging is to pass the ENABLE_WRITE_AHEAD_LOGGING flag to openDatabase. This is more efficient than calling enableWriteAheadLogging. <code><pre>
				///            SQLiteDatabase db = SQLiteDatabase.openDatabase("db_filename", cursorFactory,
				///                    SQLiteDatabase.CREATE_IF_NECESSARY | SQLiteDatabase.ENABLE_WRITE_AHEAD_LOGGING,
				///                    myDatabaseErrorHandler);
				///            db.enableWriteAheadLogging();
				///        </pre></code> </para><para>Another way to enable write-ahead logging is to call enableWriteAheadLogging after opening the database. <code><pre>
				///            SQLiteDatabase db = SQLiteDatabase.openDatabase("db_filename", cursorFactory,
				///                    SQLiteDatabase.CREATE_IF_NECESSARY, myDatabaseErrorHandler);
				///            db.enableWriteAheadLogging();
				///        </pre></code> </para><para>See also  for more details about how write-ahead logging works. </para><para><para>ENABLE_WRITE_AHEAD_LOGGING </para><simplesectsep></simplesectsep><para>disableWriteAheadLogging </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if write-ahead logging is enabled.</para>
				/// </returns>
				/// <java-name>
				/// enableWriteAheadLogging
				/// </java-name>
				[Dot42.DexImport("enableWriteAheadLogging", "()Z", AccessFlags = 1)]
				public virtual bool EnableWriteAheadLogging() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns list of full pathnames of all attached databases including the main database by executing 'pragma database_list' on the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList of pairs of (database name, database file path) or null if the database is not open. </para>
				/// </returns>
				/// <java-name>
				/// getAttachedDbs
				/// </java-name>
				[Dot42.DexImport("getAttachedDbs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/util/Pair<Ljava/lang/String;Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IList<global::Android.Util.Pair<string, string>> GetAttachedDbs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Util.Pair<string, string>>);
				}

				/// <summary>
				/// <para>Runs 'pragma integrity_check' on the given database (and all the attached databases) and returns true if the given database (and all its attached databases) pass integrity_check, false otherwise. </para><para>If the result is false, then this method logs the errors reported by the integrity_check command execution. </para><para>Note that 'pragma integrity_check' on a database can take a long time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the given database (and all its attached databases) pass integrity_check, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDatabaseIntegrityOk
				/// </java-name>
				[Dot42.DexImport("isDatabaseIntegrityOk", "()Z", AccessFlags = 1)]
				public virtual bool IsDatabaseIntegrityOk() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Deprecated. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer serves any useful purpose and has been deprecated. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getSyncedTables
				/// </java-name>
				public global::Java.Util.IMap<string, string> SyncedTables
				{
				[Dot42.DexImport("getSyncedTables", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return GetSyncedTables(); }
				}

				/// <summary>
				/// <para>Gets the database version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the database version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
						set{ SetVersion(value); }
				}

				/// <summary>
				/// <para>Returns the maximum size the database may grow to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new maximum database size </para>
				/// </returns>
				/// <java-name>
				/// getMaximumSize
				/// </java-name>
				public long MaximumSize
				{
				[Dot42.DexImport("getMaximumSize", "()J", AccessFlags = 1)]
						get{ return GetMaximumSize(); }
				}

				/// <summary>
				/// <para>Returns the current database page size, in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the database page size, in bytes </para>
				/// </returns>
				/// <java-name>
				/// getPageSize
				/// </java-name>
				public long PageSize
				{
				[Dot42.DexImport("getPageSize", "()J", AccessFlags = 1)]
						get{ return GetPageSize(); }
				[Dot42.DexImport("setPageSize", "(J)V", AccessFlags = 1)]
						set{ SetPageSize(value); }
				}

				/// <summary>
				/// <para>Gets the path to the database file.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The path to the database file. </para>
				/// </returns>
				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetPath(); }
				}

				/// <summary>
				/// <para>Returns list of full pathnames of all attached databases including the main database by executing 'pragma database_list' on the database.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList of pairs of (database name, database file path) or null if the database is not open. </para>
				/// </returns>
				/// <java-name>
				/// getAttachedDbs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Util.Pair<string, string>> AttachedDbs
				{
				[Dot42.DexImport("getAttachedDbs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/util/Pair<Ljava/lang/String;Ljava/lang/String;>;>;")]
						get{ return GetAttachedDbs(); }
				}

				/// <summary>
				/// <para>Used to allow returning sub-classes of Cursor when calling query. </para>    
				/// </summary>
				/// <java-name>
				/// android/database/sqlite/SQLiteDatabase$CursorFactory
				/// </java-name>
				[Dot42.DexImport("android/database/sqlite/SQLiteDatabase$CursorFactory", AccessFlags = 1545)]
				public partial interface ICursorFactory
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>See SQLiteCursor#SQLiteCursor(SQLiteCursorDriver, String, SQLiteQuery). </para>        
						/// </summary>
						/// <java-name>
						/// newCursor
						/// </java-name>
						[Dot42.DexImport("newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDri" +
    "ver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cu" +
    "rsor;", AccessFlags = 1025)]
						global::Android.Database.ICursor NewCursor(global::Android.Database.Sqlite.SQLiteDatabase db, global::Android.Database.Sqlite.ISQLiteCursorDriver masterQuery, string editTable, global::Android.Database.Sqlite.SQLiteQuery query) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A driver for SQLiteCursors that is used to create them and gets notified by the cursors it creates on significant events in their lifetimes. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteCursorDriver
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteCursorDriver", AccessFlags = 1537)]
		public partial interface ISQLiteCursorDriver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Executes the query returning a Cursor over the result set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Cursor over the result set </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landro" +
    "id/database/Cursor;", AccessFlags = 1025)]
				global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, string[] bindArgs) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by a SQLiteCursor when it is released. </para>        
				/// </summary>
				/// <java-name>
				/// cursorDeactivated
				/// </java-name>
				[Dot42.DexImport("cursorDeactivated", "()V", AccessFlags = 1025)]
				void CursorDeactivated() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by a SQLiteCursor when it is requeried. </para>        
				/// </summary>
				/// <java-name>
				/// cursorRequeried
				/// </java-name>
				[Dot42.DexImport("cursorRequeried", "(Landroid/database/Cursor;)V", AccessFlags = 1025)]
				void CursorRequeried(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by a SQLiteCursor when it it closed to destroy this object as well. </para>        
				/// </summary>
				/// <java-name>
				/// cursorClosed
				/// </java-name>
				[Dot42.DexImport("cursorClosed", "()V", AccessFlags = 1025)]
				void CursorClosed() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set new bind arguments. These will take effect in cursorRequeried(). </para>        
				/// </summary>
				/// <java-name>
				/// setBindArguments
				/// </java-name>
				[Dot42.DexImport("setBindArguments", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetBindArguments(string[] bindArgs) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A SQLite exception that indicates there was an error with SQL parsing or execution. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteException", AccessFlags = 33)]
		public partial class SQLiteException : global::Android.Database.SQLException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteOutOfMemoryException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteOutOfMemoryException", AccessFlags = 33)]
		public partial class SQLiteOutOfMemoryException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteOutOfMemoryException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteOutOfMemoryException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A helper class to manage database creation and version management.</para><para>You create a subclass implementing onCreate, onUpgrade and optionally onOpen, and this class takes care of opening the database if it exists, creating it if it does not, and upgrading it as necessary. Transactions are used to make sure the database is always in a sensible state.</para><para>This class makes it easy for android.content.ContentProvider implementations to defer opening and upgrading the database until first use, to avoid blocking application startup with long-running database upgrades.</para><para>For an example, see the NotePadProvider class in the NotePad sample application, in the <b>samples/</b> directory of the SDK.</para><para><b>Note:</b> this class assumes monotonically increasing version numbers for upgrades.</para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteOpenHelper
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteOpenHelper", AccessFlags = 1057)]
		public abstract partial class SQLiteOpenHelper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a helper object to create, open, and/or manage a database. This method always returns very quickly. The database is not actually created or opened until one of getWritableDatabase or getReadableDatabase is called.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDataba" +
    "se$CursorFactory;I)V", AccessFlags = 1)]
				public SQLiteOpenHelper(global::Android.Content.Context context, string name, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a helper object to create, open, and/or manage a database. The database is not actually created or opened until one of getWritableDatabase or getReadableDatabase is called.</para><para>Accepts input param: a concrete instance of DatabaseErrorHandler to be used to handle corruption when sqlite reports database corruption.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDataba" +
    "se$CursorFactory;ILandroid/database/DatabaseErrorHandler;)V", AccessFlags = 1)]
				public SQLiteOpenHelper(global::Android.Content.Context context, string name, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, int version, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create and/or open a database that will be used for reading and writing. The first time this is called, the database will be opened and onCreate, onUpgrade and/or onOpen will be called.</para><para>Once opened successfully, the database is cached, so you can call this method every time you need to write to the database. (Make sure to call close when you no longer need the database.) Errors such as bad permissions or a full disk may cause this method to fail, but future attempts may succeed if the problem is fixed.</para><para>Database upgrade may take a long time, you should not call this method from the application main thread, including from ContentProvider.onCreate().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read/write database object valid until close is called </para>
				/// </returns>
				/// <java-name>
				/// getWritableDatabase
				/// </java-name>
				[Dot42.DexImport("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetWritableDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Create and/or open a database. This will be the same object returned by getWritableDatabase unless some problem, such as a full disk, requires the database to be opened read-only. In that case, a read-only database object will be returned. If the problem is fixed, a future call to getWritableDatabase may succeed, in which case the read-only database object will be closed and the read/write object will be returned in the future.</para><para>Like getWritableDatabase, this method may take a long time to return, so you should not call it from the application main thread, including from ContentProvider.onCreate().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a database object valid until getWritableDatabase or close is called. </para>
				/// </returns>
				/// <java-name>
				/// getReadableDatabase
				/// </java-name>
				[Dot42.DexImport("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetReadableDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Close any open database object. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the database is created for the first time. This is where the creation of tables and the initial population of the tables should happen.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1025)]
				public abstract void OnCreate(global::Android.Database.Sqlite.SQLiteDatabase db) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the database needs to be upgraded. The implementation should use this method to drop tables, add tables, or do anything else it needs to upgrade to the new schema version.</para><para>The SQLite ALTER TABLE documentation can be found . If you add new columns you can use ALTER TABLE to insert them into a live table. If you rename or remove columns you can use ALTER TABLE to rename the old table, then create the new table and then populate the new table with the contents of the old table. </para><para>This method executes within a transaction. If an exception is thrown, all changes will automatically be rolled back. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// onUpgrade
				/// </java-name>
				[Dot42.DexImport("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", AccessFlags = 1025)]
				public abstract void OnUpgrade(global::Android.Database.Sqlite.SQLiteDatabase db, int oldVersion, int newVersion) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the database needs to be downgraded. This is strictly similar to onUpgrade method, but is called whenever current version is newer than requested one. However, this method is not abstract, so it is not mandatory for a customer to implement it. If not overridden, default implementation will reject downgrade and throws SQLiteException</para><para>This method executes within a transaction. If an exception is thrown, all changes will automatically be rolled back. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDowngrade
				/// </java-name>
				[Dot42.DexImport("onDowngrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", AccessFlags = 1)]
				public virtual void OnDowngrade(global::Android.Database.Sqlite.SQLiteDatabase db, int oldVersion, int newVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the database has been opened. The implementation should check SQLiteDatabase#isReadOnly before updating the database. </para><para>This method is called after the database connection has been configured and after the database schema has been created, upgraded or downgraded as necessary. If the database connection must be configured in some way before the schema is created, upgraded, or downgraded, do it in onConfigure instead. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// onOpen
				/// </java-name>
				[Dot42.DexImport("onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1)]
				public virtual void OnOpen(global::Android.Database.Sqlite.SQLiteDatabase db) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SQLiteOpenHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Create and/or open a database that will be used for reading and writing. The first time this is called, the database will be opened and onCreate, onUpgrade and/or onOpen will be called.</para><para>Once opened successfully, the database is cached, so you can call this method every time you need to write to the database. (Make sure to call close when you no longer need the database.) Errors such as bad permissions or a full disk may cause this method to fail, but future attempts may succeed if the problem is fixed.</para><para>Database upgrade may take a long time, you should not call this method from the application main thread, including from ContentProvider.onCreate().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read/write database object valid until close is called </para>
				/// </returns>
				/// <java-name>
				/// getWritableDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase WritableDatabase
				{
				[Dot42.DexImport("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
						get{ return GetWritableDatabase(); }
				}

				/// <summary>
				/// <para>Create and/or open a database. This will be the same object returned by getWritableDatabase unless some problem, such as a full disk, requires the database to be opened read-only. In that case, a read-only database object will be returned. If the problem is fixed, a future call to getWritableDatabase may succeed, in which case the read-only database object will be closed and the read/write object will be returned in the future.</para><para>Like getWritableDatabase, this method may take a long time to return, so you should not call it from the application main thread, including from ContentProvider.onCreate().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a database object valid until getWritableDatabase or close is called. </para>
				/// </returns>
				/// <java-name>
				/// getReadableDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase ReadableDatabase
				{
				[Dot42.DexImport("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
						get{ return GetReadableDatabase(); }
				}

		}

		/// <summary>
		/// <para>Represents a query that reads the resulting rows into a SQLiteQuery. This class is used by SQLiteCursor and isn't useful itself. </para><para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteQuery
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteQuery", AccessFlags = 33)]
		public partial class SQLiteQuery : global::Android.Database.Sqlite.SQLiteProgram
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SQLiteQuery() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Thrown if the database engine was unable to acquire the database locks it needs to do its job. If the statement is a [COMMIT] or occurs outside of an explicit transaction, then you can retry the statement. If the statement is not a [COMMIT] and occurs within a explicit transaction then you should rollback the transaction before continuing. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteDatabaseLockedException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDatabaseLockedException", AccessFlags = 33)]
		public partial class SQLiteDatabaseLockedException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteDatabaseLockedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteDatabaseLockedException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This error can occur if the application creates a SQLiteStatement object and allows multiple threads in the application use it at the same time. Sqlite returns this error if bind and execute methods on this object occur at the same time from multiple threads, like so: thread # 1: in execute() method of the SQLiteStatement object while thread # 2: is in bind..() on the same object. </para><para>FIX this by NEVER sharing the same SQLiteStatement object between threads. Create a local instance of the SQLiteStatement whenever it is needed, use it and close it ASAP. NEVER make it globally available. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteMisuseException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteMisuseException", AccessFlags = 33)]
		public partial class SQLiteMisuseException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteMisuseException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteMisuseException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteCantOpenDatabaseException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteCantOpenDatabaseException", AccessFlags = 33)]
		public partial class SQLiteCantOpenDatabaseException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteCantOpenDatabaseException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteCantOpenDatabaseException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that an IO error occured while accessing the SQLite database file. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteDiskIOException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDiskIOException", AccessFlags = 33)]
		public partial class SQLiteDiskIOException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteDiskIOException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteDiskIOException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that the SQLite database is full. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteFullException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteFullException", AccessFlags = 33)]
		public partial class SQLiteFullException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteFullException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteFullException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteBlobTooBigException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteBlobTooBigException", AccessFlags = 33)]
		public partial class SQLiteBlobTooBigException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteBlobTooBigException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteBlobTooBigException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that the SQLite program is done. Thrown when an operation that expects a row (such as SQLiteStatement#simpleQueryForString or SQLiteStatement#simpleQueryForLong) does not get one. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteDoneException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDoneException", AccessFlags = 33)]
		public partial class SQLiteDoneException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteDoneException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteDoneException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteReadOnlyDatabaseException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteReadOnlyDatabaseException", AccessFlags = 33)]
		public partial class SQLiteReadOnlyDatabaseException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteReadOnlyDatabaseException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteReadOnlyDatabaseException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents a statement that can be executed against a database. The statement cannot return multiple rows or columns, but single value (1 x 1) result sets are supported. </para><para>This class is not thread-safe. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteStatement
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteStatement", AccessFlags = 33)]
		public partial class SQLiteStatement : global::Android.Database.Sqlite.SQLiteProgram
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SQLiteStatement() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Execute this SQL statement, if it is not a SELECT / INSERT / DELETE / UPDATE, for example CREATE / DROP table, view, trigger, index etc.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1)]
				public virtual void Execute() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Execute this SQL statement, if the the number of rows affected by execution of this SQL statement is of any importance to the caller - for example, UPDATE / DELETE SQL statements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows affected by this SQL statement execution. </para>
				/// </returns>
				/// <java-name>
				/// executeUpdateDelete
				/// </java-name>
				[Dot42.DexImport("executeUpdateDelete", "()I", AccessFlags = 1)]
				public virtual int ExecuteUpdateDelete() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Execute this SQL statement and return the ID of the row inserted due to this call. The SQL statement should be an INSERT for this to be a useful call.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the row ID of the last row inserted, if this insert is successful. -1 otherwise.</para>
				/// </returns>
				/// <java-name>
				/// executeInsert
				/// </java-name>
				[Dot42.DexImport("executeInsert", "()J", AccessFlags = 1)]
				public virtual long ExecuteInsert() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Execute a statement that returns a 1 by 1 table with a numeric value. For example, SELECT COUNT(*) FROM table;</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the query.</para>
				/// </returns>
				/// <java-name>
				/// simpleQueryForLong
				/// </java-name>
				[Dot42.DexImport("simpleQueryForLong", "()J", AccessFlags = 1)]
				public virtual long SimpleQueryForLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Execute a statement that returns a 1 by 1 table with a text value. For example, SELECT COUNT(*) FROM table;</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the query.</para>
				/// </returns>
				/// <java-name>
				/// simpleQueryForString
				/// </java-name>
				[Dot42.DexImport("simpleQueryForString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string SimpleQueryForString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Executes a statement that returns a 1 by 1 table with a blob value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A read-only file descriptor for a copy of the blob value, or <c> null </c> if the value is null or could not be read for some reason.</para>
				/// </returns>
				/// <java-name>
				/// simpleQueryForBlobFileDescriptor
				/// </java-name>
				[Dot42.DexImport("simpleQueryForBlobFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor SimpleQueryForBlobFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

		}

		/// <summary>
		/// <para>This is a convience class that helps build SQL queries to be sent to SQLiteDatabase objects. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteQueryBuilder
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteQueryBuilder", AccessFlags = 33)]
		public partial class SQLiteQueryBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteQueryBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Mark the query as DISTINCT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDistinct
				/// </java-name>
				[Dot42.DexImport("setDistinct", "(Z)V", AccessFlags = 1)]
				public virtual void SetDistinct(bool distinct) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the list of tables being queried</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of tables being queried </para>
				/// </returns>
				/// <java-name>
				/// getTables
				/// </java-name>
				[Dot42.DexImport("getTables", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTables() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the list of tables to query. Multiple tables can be specified to perform a join. For example: setTables("foo, bar") setTables("foo LEFT OUTER JOIN bar ON (foo.id = bar.foo_id)")</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTables
				/// </java-name>
				[Dot42.DexImport("setTables", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTables(string inTables) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Append a chunk to the WHERE clause of the query. All chunks appended are surrounded by parenthesis and ANDed with the selection passed to query. The final WHERE clause looks like:</para><para>WHERE (&lt;append chunk 1&gt;&lt;append chunk2&gt;) AND (&lt;query() selection parameter&gt;)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// appendWhere
				/// </java-name>
				[Dot42.DexImport("appendWhere", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void AppendWhere(global::Java.Lang.ICharSequence inWhere) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Append a chunk to the WHERE clause of the query. All chunks appended are surrounded by parenthesis and ANDed with the selection passed to query. The final WHERE clause looks like:</para><para>WHERE (&lt;append chunk 1&gt;&lt;append chunk2&gt;) AND (&lt;query() selection parameter&gt;)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// appendWhereEscapeString
				/// </java-name>
				[Dot42.DexImport("appendWhereEscapeString", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AppendWhereEscapeString(string inWhere) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the projection map for the query. The projection map maps from column names that the caller passes into query to database column names. This is useful for renaming columns as well as disambiguating column names when doing joins. For example you could map "name" to "people.name". If a projection map is set it must contain all column names the user may request, even if the key and value are the same.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProjectionMap
				/// </java-name>
				[Dot42.DexImport("setProjectionMap", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public virtual void SetProjectionMap(global::Java.Util.IMap<string, string> columnMap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the cursor factory to be used for the query. You can use one factory for all queries on a database but it is normally easier to specify the factory when doing this query.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCursorFactory
				/// </java-name>
				[Dot42.DexImport("setCursorFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)V", AccessFlags = 1)]
				public virtual void SetCursorFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Build an SQL query string from the given clauses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SQL query string </para>
				/// </returns>
				/// <java-name>
				/// buildQueryString
				/// </java-name>
				[Dot42.DexImport("buildQueryString", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string BuildQueryString(bool distinct, string tables, string[] columns, string where, string groupBy, string having, string orderBy, string limit) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Add the names that are non-null in columns to s, separating them with commas. </para>        
				/// </summary>
				/// <java-name>
				/// appendColumns
				/// </java-name>
				[Dot42.DexImport("appendColumns", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AppendColumns(global::System.Text.StringBuilder s, string[] columns) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Perform a query by combining all current settings and the information passed into this method.</para><para><para>android.content.ContentResolver::query(android.net.Uri, String[], String, String[], String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a cursor over the result set </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Lj" +
    "ava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/" +
    "database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase db, string[] projectionIn, string selection, string[] selectionArgs, string groupBy, string having, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Perform a query by combining all current settings and the information passed into this method.</para><para><para>android.content.ContentResolver::query(android.net.Uri, String[], String, String[], String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a cursor over the result set </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Lj" +
    "ava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang" +
    "/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase db, string[] projectionIn, string selection, string[] selectionArgs, string groupBy, string having, string sortOrder, string limit) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Construct a SELECT statement suitable for use in a group of SELECT statements that will be joined through UNION operators in buildUnionQuery.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resulting SQL SELECT statement </para>
				/// </returns>
				/// <java-name>
				/// buildQuery
				/// </java-name>
				[Dot42.DexImport("buildQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildQuery(string[] projectionIn, string selection, string groupBy, string having, string sortOrder, string limit) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method's signature is misleading since no SQL parameter substitution is carried out. The selection arguments parameter does not get used at all. To avoid confusion, call buildQuery(String[], String, String, String, String, String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// buildQuery
				/// </java-name>
				[Dot42.DexImport("buildQuery", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildQuery(string[] projectionIn, string selection, string[] selectionArgs, string groupBy, string having, string sortOrder, string limit) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Construct a SELECT statement suitable for use in a group of SELECT statements that will be joined through UNION operators in buildUnionQuery.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resulting SQL SELECT statement </para>
				/// </returns>
				/// <java-name>
				/// buildUnionSubQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lan" +
    "g/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;ILjava/l" +
    "ang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Str" +
    "ing;")]
				public virtual string BuildUnionSubQuery(string typeDiscriminatorColumn, string[] unionColumns, global::Java.Util.ISet<string> columnsPresentInTable, int computedColumnsOffset, string typeDiscriminatorValue, string selection, string groupBy, string having) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method's signature is misleading since no SQL parameter substitution is carried out. The selection arguments parameter does not get used at all. To avoid confusion, call buildUnionSubQuery instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// buildUnionSubQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lan" +
    "g/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Stri" +
    "ng;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;ILjava/l" +
    "ang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/Str" +
    "ing;)Ljava/lang/String;")]
				public virtual string BuildUnionSubQuery(string typeDiscriminatorColumn, string[] unionColumns, global::Java.Util.ISet<string> columnsPresentInTable, int computedColumnsOffset, string typeDiscriminatorValue, string selection, string[] selectionArgs, string groupBy, string having) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Given a set of subqueries, all of which are SELECT statements, construct a query that returns the union of what those subqueries return. </para>        
				/// </summary>
				/// <returns>
				/// <para>the resulting SQL SELECT statement </para>
				/// </returns>
				/// <java-name>
				/// buildUnionQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildUnionQuery(string[] subQueries, string sortOrder, string limit) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the list of tables being queried</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of tables being queried </para>
				/// </returns>
				/// <java-name>
				/// getTables
				/// </java-name>
				public string Tables
				{
				[Dot42.DexImport("getTables", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTables(); }
				[Dot42.DexImport("setTables", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetTables(value); }
				}

		}

		/// <summary>
		/// <para>Thrown if the the bind or column parameter index is out of range </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteBindOrColumnIndexOutOfRangeException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteBindOrColumnIndexOutOfRangeException", AccessFlags = 33)]
		public partial class SQLiteBindOrColumnIndexOutOfRangeException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteBindOrColumnIndexOutOfRangeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteBindOrColumnIndexOutOfRangeException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that the SQLite program was aborted. This can happen either through a call to ABORT in a trigger, or as the result of using the ABORT conflict clause. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteAbortException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteAbortException", AccessFlags = 33)]
		public partial class SQLiteAbortException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteAbortException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteAbortException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This exception class is used when sqlite can't access the database file due to lack of permissions on the file. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteAccessPermException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteAccessPermException", AccessFlags = 33)]
		public partial class SQLiteAccessPermException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteAccessPermException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteAccessPermException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteTableLockedException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteTableLockedException", AccessFlags = 33)]
		public partial class SQLiteTableLockedException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteTableLockedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteTableLockedException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteDatatypeMismatchException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDatatypeMismatchException", AccessFlags = 33)]
		public partial class SQLiteDatatypeMismatchException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteDatatypeMismatchException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteDatatypeMismatchException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that an integrity constraint was violated. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteConstraintException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteConstraintException", AccessFlags = 33)]
		public partial class SQLiteConstraintException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteConstraintException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteConstraintException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An exception that indicates that the SQLite database file is corrupt. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteDatabaseCorruptException
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDatabaseCorruptException", AccessFlags = 33)]
		public partial class SQLiteDatabaseCorruptException : global::Android.Database.Sqlite.SQLiteException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLiteDatabaseCorruptException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLiteDatabaseCorruptException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A Cursor implementation that exposes results from a query on a SQLiteDatabase.</para><para>SQLiteCursor is not internally synchronized so code using a SQLiteCursor from multiple threads should perform its own synchronization when using the SQLiteCursor. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/sqlite/SQLiteCursor
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteCursor", AccessFlags = 33)]
		public partial class SQLiteCursor : global::Android.Database.AbstractWindowedCursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Execute a query and provide access to its result set through a Cursor interface. For a query such as: <c> SELECT name, birth, phone FROM       myTable WHERE ... LIMIT 1,20 ORDER BY... </c> the column names (name, birth, phone) would be in the projection argument and everything from <c> FROM </c> onward would be in the params argument.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use SQLiteCursor(SQLiteCursorDriver, String, SQLiteQuery) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDri" +
    "ver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V", AccessFlags = 1)]
				public SQLiteCursor(global::Android.Database.Sqlite.SQLiteDatabase db, global::Android.Database.Sqlite.ISQLiteCursorDriver driver, string editTable, global::Android.Database.Sqlite.SQLiteQuery query) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Execute a query and provide access to its result set through a Cursor interface. For a query such as: <c> SELECT name, birth, phone FROM       myTable WHERE ... LIMIT 1,20 ORDER BY... </c> the column names (name, birth, phone) would be in the projection argument and everything from <c> FROM </c> onward would be in the params argument.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/" +
    "sqlite/SQLiteQuery;)V", AccessFlags = 1)]
				public SQLiteCursor(global::Android.Database.Sqlite.ISQLiteCursorDriver driver, string editTable, global::Android.Database.Sqlite.SQLiteQuery query) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public override void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the database that this cursor is associated with. </para>        
				/// </summary>
				/// <returns>
				/// <para>the SQLiteDatabase that this cursor is associated with. </para>
				/// </returns>
				/// <java-name>
				/// getDatabase
				/// </java-name>
				[Dot42.DexImport("getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>This function is called every time the cursor is successfully scrolled to a new position, giving the subclass a chance to update any state it may have. If it returns false the move function will also do so and the cursor will scroll to the beforeFirst position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the move is successful, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public override bool OnMove(int oldPosition, int newPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the numbers of rows in the cursor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public override int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para><para><para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetColumnIndex(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public override void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para><para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public override bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets a new cursor window for the cursor to use. </para><para>The cursor takes ownership of the provided cursor window; the cursor window will be closed when the cursor is closed or when the cursor adopts a new cursor window. </para><para>If the cursor previously had a cursor window, then it is closed when the new cursor window is assigned. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWindow
				/// </java-name>
				[Dot42.DexImport("setWindow", "(Landroid/database/CursorWindow;)V", AccessFlags = 1)]
				public override void SetWindow(global::Android.Database.CursorWindow window) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the selection arguments. The new values take effect after a call to requery(). </para>        
				/// </summary>
				/// <java-name>
				/// setSelectionArguments
				/// </java-name>
				[Dot42.DexImport("setSelectionArguments", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSelectionArguments(string[] selectionArgs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Release the native resources, if they haven't been released yet. </para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SQLiteCursor() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SQLiteCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Get the database that this cursor is associated with. </para>        
				/// </summary>
				/// <returns>
				/// <para>the SQLiteDatabase that this cursor is associated with. </para>
				/// </returns>
				/// <java-name>
				/// getDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase Database
				{
				[Dot42.DexImport("getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
						get{ return GetDatabase(); }
				}

				/// <summary>
				/// <para>Returns the numbers of rows in the cursor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return GetCount(); }
				}

				/// <summary>
				/// <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetColumnNames(); }
				}

		}

}


