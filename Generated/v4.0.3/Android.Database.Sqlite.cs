#pragma warning disable 1717
namespace Android.Database.Sqlite
{
		/// <java-name>
		/// android/database/sqlite/SQLiteCursorDriver
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteCursorDriver", AccessFlags = 1537)]
		public partial interface ISQLiteCursorDriver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;[Ljava/lang/String;)Landro" +
    "id/database/Cursor;", AccessFlags = 1025)]
				global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, string[] @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cursorDeactivated
				/// </java-name>
				[Dot42.DexImport("cursorDeactivated", "()V", AccessFlags = 1025)]
				void CursorDeactivated() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cursorRequeried
				/// </java-name>
				[Dot42.DexImport("cursorRequeried", "(Landroid/database/Cursor;)V", AccessFlags = 1025)]
				void CursorRequeried(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cursorClosed
				/// </java-name>
				[Dot42.DexImport("cursorClosed", "()V", AccessFlags = 1025)]
				void CursorClosed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBindArguments
				/// </java-name>
				[Dot42.DexImport("setBindArguments", "([Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetBindArguments(string[] @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteTransactionListener
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteTransactionListener", AccessFlags = 1537)]
		public partial interface ISQLiteTransactionListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onBegin
				/// </java-name>
				[Dot42.DexImport("onBegin", "()V", AccessFlags = 1025)]
				void OnBegin() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onCommit
				/// </java-name>
				[Dot42.DexImport("onCommit", "()V", AccessFlags = 1025)]
				void OnCommit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRollback
				/// </java-name>
				[Dot42.DexImport("onRollback", "()V", AccessFlags = 1025)]
				void OnRollback() /* MethodBuilder.Create */ ;

		}

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
				public SQLiteAbortException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteAccessPermException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteBindOrColumnIndexOutOfRangeException(string @string) /* MethodBuilder.Create */ 
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
				public SQLiteBlobTooBigException(string @string) /* MethodBuilder.Create */ 
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
				public SQLiteCantOpenDatabaseException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 1028)]
				protected internal abstract void OnAllReferencesReleased() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onAllReferencesReleasedFromContainer
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleasedFromContainer", "()V", AccessFlags = 4)]
				protected internal virtual void OnAllReferencesReleasedFromContainer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// acquireReference
				/// </java-name>
				[Dot42.DexImport("acquireReference", "()V", AccessFlags = 1)]
				public virtual void AcquireReference() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// releaseReference
				/// </java-name>
				[Dot42.DexImport("releaseReference", "()V", AccessFlags = 1)]
				public virtual void ReleaseReference() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// releaseReferenceFromContainer
				/// </java-name>
				[Dot42.DexImport("releaseReferenceFromContainer", "()V", AccessFlags = 1)]
				public virtual void ReleaseReferenceFromContainer() /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteConstraintException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteCursor
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteCursor", AccessFlags = 33)]
		public partial class SQLiteCursor : global::Android.Database.AbstractWindowedCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDri" +
    "ver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V", AccessFlags = 1)]
				public SQLiteCursor(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, global::Android.Database.Sqlite.ISQLiteCursorDriver sQLiteCursorDriver, string @string, global::Android.Database.Sqlite.SQLiteQuery sQLiteQuery) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/" +
    "sqlite/SQLiteQuery;)V", AccessFlags = 1)]
				public SQLiteCursor(global::Android.Database.Sqlite.ISQLiteCursorDriver sQLiteCursorDriver, string @string, global::Android.Database.Sqlite.SQLiteQuery sQLiteQuery) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDatabase
				/// </java-name>
				[Dot42.DexImport("getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public override bool OnMove(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public override int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetColumnIndex(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public override void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public override bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWindow
				/// </java-name>
				[Dot42.DexImport("setWindow", "(Landroid/database/CursorWindow;)V", AccessFlags = 1)]
				public override void SetWindow(global::Android.Database.CursorWindow cursorWindow) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectionArguments
				/// </java-name>
				[Dot42.DexImport("setSelectionArguments", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSelectionArguments(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SQLiteCursor() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SQLiteCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase Database
				{
				[Dot42.DexImport("getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
						get{ return GetDatabase(); }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return GetCount(); }
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetColumnNames(); }
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteDatabase
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteDatabase", AccessFlags = 33)]
		public partial class SQLiteDatabase : global::Android.Database.Sqlite.SQLiteClosable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONFLICT_ROLLBACK
				/// </java-name>
				[Dot42.DexImport("CONFLICT_ROLLBACK", "I", AccessFlags = 25)]
				public const int CONFLICT_ROLLBACK = 1;
				/// <java-name>
				/// CONFLICT_ABORT
				/// </java-name>
				[Dot42.DexImport("CONFLICT_ABORT", "I", AccessFlags = 25)]
				public const int CONFLICT_ABORT = 2;
				/// <java-name>
				/// CONFLICT_FAIL
				/// </java-name>
				[Dot42.DexImport("CONFLICT_FAIL", "I", AccessFlags = 25)]
				public const int CONFLICT_FAIL = 3;
				/// <java-name>
				/// CONFLICT_IGNORE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_IGNORE", "I", AccessFlags = 25)]
				public const int CONFLICT_IGNORE = 4;
				/// <java-name>
				/// CONFLICT_REPLACE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_REPLACE", "I", AccessFlags = 25)]
				public const int CONFLICT_REPLACE = 5;
				/// <java-name>
				/// CONFLICT_NONE
				/// </java-name>
				[Dot42.DexImport("CONFLICT_NONE", "I", AccessFlags = 25)]
				public const int CONFLICT_NONE = 0;
				/// <java-name>
				/// SQLITE_MAX_LIKE_PATTERN_LENGTH
				/// </java-name>
				[Dot42.DexImport("SQLITE_MAX_LIKE_PATTERN_LENGTH", "I", AccessFlags = 25)]
				public const int SQLITE_MAX_LIKE_PATTERN_LENGTH = 50000;
				/// <java-name>
				/// OPEN_READWRITE
				/// </java-name>
				[Dot42.DexImport("OPEN_READWRITE", "I", AccessFlags = 25)]
				public const int OPEN_READWRITE = 0;
				/// <java-name>
				/// OPEN_READONLY
				/// </java-name>
				[Dot42.DexImport("OPEN_READONLY", "I", AccessFlags = 25)]
				public const int OPEN_READONLY = 1;
				/// <java-name>
				/// NO_LOCALIZED_COLLATORS
				/// </java-name>
				[Dot42.DexImport("NO_LOCALIZED_COLLATORS", "I", AccessFlags = 25)]
				public const int NO_LOCALIZED_COLLATORS = 16;
				/// <java-name>
				/// CREATE_IF_NECESSARY
				/// </java-name>
				[Dot42.DexImport("CREATE_IF_NECESSARY", "I", AccessFlags = 25)]
				public const int CREATE_IF_NECESSARY = 268435456;
				/// <java-name>
				/// MAX_SQL_CACHE_SIZE
				/// </java-name>
				[Dot42.DexImport("MAX_SQL_CACHE_SIZE", "I", AccessFlags = 25)]
				public const int MAX_SQL_CACHE_SIZE = 100;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SQLiteDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 4)]
				protected internal override void OnAllReferencesReleased() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// releaseMemory
				/// </java-name>
				[Dot42.DexImport("releaseMemory", "()I", AccessFlags = 265)]
				public static int ReleaseMemory() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLockingEnabled
				/// </java-name>
				[Dot42.DexImport("setLockingEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetLockingEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginTransaction
				/// </java-name>
				[Dot42.DexImport("beginTransaction", "()V", AccessFlags = 1)]
				public virtual void BeginTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginTransactionNonExclusive
				/// </java-name>
				[Dot42.DexImport("beginTransactionNonExclusive", "()V", AccessFlags = 1)]
				public virtual void BeginTransactionNonExclusive() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginTransactionWithListener
				/// </java-name>
				[Dot42.DexImport("beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V", AccessFlags = 1)]
				public virtual void BeginTransactionWithListener(global::Android.Database.Sqlite.ISQLiteTransactionListener sQLiteTransactionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginTransactionWithListenerNonExclusive
				/// </java-name>
				[Dot42.DexImport("beginTransactionWithListenerNonExclusive", "(Landroid/database/sqlite/SQLiteTransactionListener;)V", AccessFlags = 1)]
				public virtual void BeginTransactionWithListenerNonExclusive(global::Android.Database.Sqlite.ISQLiteTransactionListener sQLiteTransactionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endTransaction
				/// </java-name>
				[Dot42.DexImport("endTransaction", "()V", AccessFlags = 1)]
				public virtual void EndTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransactionSuccessful
				/// </java-name>
				[Dot42.DexImport("setTransactionSuccessful", "()V", AccessFlags = 1)]
				public virtual void SetTransactionSuccessful() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inTransaction
				/// </java-name>
				[Dot42.DexImport("inTransaction", "()Z", AccessFlags = 1)]
				public virtual bool InTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDbLockedByCurrentThread
				/// </java-name>
				[Dot42.DexImport("isDbLockedByCurrentThread", "()Z", AccessFlags = 1)]
				public virtual bool IsDbLockedByCurrentThread() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDbLockedByOtherThreads
				/// </java-name>
				[Dot42.DexImport("isDbLockedByOtherThreads", "()Z", AccessFlags = 1)]
				public virtual bool IsDbLockedByOtherThreads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// yieldIfContended
				/// </java-name>
				[Dot42.DexImport("yieldIfContended", "()Z", AccessFlags = 1)]
				public virtual bool YieldIfContended() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// yieldIfContendedSafely
				/// </java-name>
				[Dot42.DexImport("yieldIfContendedSafely", "()Z", AccessFlags = 1)]
				public virtual bool YieldIfContendedSafely() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// yieldIfContendedSafely
				/// </java-name>
				[Dot42.DexImport("yieldIfContendedSafely", "(J)Z", AccessFlags = 1)]
				public virtual bool YieldIfContendedSafely(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSyncedTables
				/// </java-name>
				[Dot42.DexImport("getSyncedTables", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				public virtual global::Java.Util.IMap<string, string> GetSyncedTables() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <java-name>
				/// openDatabase
				/// </java-name>
				[Dot42.DexImport("openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase(string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openDatabase
				/// </java-name>
				[Dot42.DexImport("openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ILandroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenDatabase(string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, int int32, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/da" +
    "tabase/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(global::Java.Io.File file, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroi" +
    "d/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid" +
    "/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/" +
    "SQLiteDatabase;", AccessFlags = 9)]
				public static global::Android.Database.Sqlite.SQLiteDatabase Create(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public virtual void SetVersion(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaximumSize
				/// </java-name>
				[Dot42.DexImport("getMaximumSize", "()J", AccessFlags = 1)]
				public virtual long GetMaximumSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setMaximumSize
				/// </java-name>
				[Dot42.DexImport("setMaximumSize", "(J)J", AccessFlags = 1)]
				public virtual long SetMaximumSize(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getPageSize
				/// </java-name>
				[Dot42.DexImport("getPageSize", "()J", AccessFlags = 1)]
				public virtual long GetPageSize() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setPageSize
				/// </java-name>
				[Dot42.DexImport("setPageSize", "(J)V", AccessFlags = 1)]
				public virtual void SetPageSize(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markTableSyncable
				/// </java-name>
				[Dot42.DexImport("markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void MarkTableSyncable(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markTableSyncable
				/// </java-name>
				[Dot42.DexImport("markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void MarkTableSyncable(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findEditTable
				/// </java-name>
				[Dot42.DexImport("findEditTable", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FindEditTable(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// compileStatement
				/// </java-name>
				[Dot42.DexImport("compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;", AccessFlags = 1)]
				public virtual global::Android.Database.Sqlite.SQLiteStatement CompileStatement(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteStatement);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava" +
    "/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/dat" +
    "abase/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(bool boolean, string @string, string[] string1, string string2, string[] string3, string string4, string string5, string string6, string string7) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// queryWithFactory
				/// </java-name>
				[Dot42.DexImport("queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/" +
    "lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/St" +
    "ring;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor QueryWithFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, bool boolean, string @string, string[] string1, string string2, string[] string3, string string4, string string5, string string6, string string7) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(string @string, string[] string1, string string2, string[] string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/data" +
    "base/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(string @string, string[] string1, string string2, string[] string3, string string4, string string5, string string6, string string7) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// rawQuery
				/// </java-name>
				[Dot42.DexImport("rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RawQuery(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// rawQueryWithFactory
				/// </java-name>
				[Dot42.DexImport("rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/l" +
    "ang/String;Ljava/lang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RawQueryWithFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, string @string, string[] string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long Insert(string @string, string string1, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// insertOrThrow
				/// </java-name>
				[Dot42.DexImport("insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long InsertOrThrow(string @string, string string1, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long Replace(string @string, string string1, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// replaceOrThrow
				/// </java-name>
				[Dot42.DexImport("replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", AccessFlags = 1)]
				public virtual long ReplaceOrThrow(string @string, string string1, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// insertWithOnConflict
				/// </java-name>
				[Dot42.DexImport("insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J", AccessFlags = 1)]
				public virtual long InsertWithOnConflict(string @string, string string1, global::Android.Content.ContentValues contentValues, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int Delete(string @string, string string1, string[] string2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/S" +
    "tring;)I", AccessFlags = 1)]
				public virtual int Update(string @string, global::Android.Content.ContentValues contentValues, string string1, string[] string2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// updateWithOnConflict
				/// </java-name>
				[Dot42.DexImport("updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/S" +
    "tring;I)I", AccessFlags = 1)]
				public virtual int UpdateWithOnConflict(string @string, global::Android.Content.ContentValues contentValues, string string1, string[] string2, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// execSQL
				/// </java-name>
				[Dot42.DexImport("execSQL", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ExecSQL(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// execSQL
				/// </java-name>
				[Dot42.DexImport("execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void ExecSQL(string @string, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SQLiteDatabase() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1)]
				public virtual bool IsOpen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// needUpgrade
				/// </java-name>
				[Dot42.DexImport("needUpgrade", "(I)Z", AccessFlags = 1)]
				public virtual bool NeedUpgrade(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxSqlCacheSize
				/// </java-name>
				[Dot42.DexImport("setMaxSqlCacheSize", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxSqlCacheSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableWriteAheadLogging
				/// </java-name>
				[Dot42.DexImport("enableWriteAheadLogging", "()Z", AccessFlags = 1)]
				public virtual bool EnableWriteAheadLogging() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAttachedDbs
				/// </java-name>
				[Dot42.DexImport("getAttachedDbs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/util/Pair<Ljava/lang/String;Ljava/lang/String;>;>;")]
				public virtual global::Java.Util.IList<global::Android.Util.Pair<string, string>> GetAttachedDbs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Util.Pair<string, string>>);
				}

				/// <java-name>
				/// isDatabaseIntegrityOk
				/// </java-name>
				[Dot42.DexImport("isDatabaseIntegrityOk", "()Z", AccessFlags = 1)]
				public virtual bool IsDatabaseIntegrityOk() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSyncedTables
				/// </java-name>
				public global::Java.Util.IMap<string, string> SyncedTables
				{
				[Dot42.DexImport("getSyncedTables", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return GetSyncedTables(); }
				}

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

				/// <java-name>
				/// getMaximumSize
				/// </java-name>
				public long MaximumSize
				{
				[Dot42.DexImport("getMaximumSize", "()J", AccessFlags = 1)]
						get{ return GetMaximumSize(); }
				}

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

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetPath(); }
				}

				/// <java-name>
				/// getAttachedDbs
				/// </java-name>
				public global::Java.Util.IList<global::Android.Util.Pair<string, string>> AttachedDbs
				{
				[Dot42.DexImport("getAttachedDbs", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/util/Pair<Ljava/lang/String;Ljava/lang/String;>;>;")]
						get{ return GetAttachedDbs(); }
				}

				/// <java-name>
				/// android/database/sqlite/SQLiteDatabase$CursorFactory
				/// </java-name>
				[Dot42.DexImport("android/database/sqlite/SQLiteDatabase$CursorFactory", AccessFlags = 1545)]
				public partial interface ICursorFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// newCursor
						/// </java-name>
						[Dot42.DexImport("newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDri" +
    "ver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cu" +
    "rsor;", AccessFlags = 1025)]
						global::Android.Database.ICursor NewCursor(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, global::Android.Database.Sqlite.ISQLiteCursorDriver sQLiteCursorDriver, string @string, global::Android.Database.Sqlite.SQLiteQuery sQLiteQuery) /* MethodBuilder.Create */ ;

				}

		}

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
				public SQLiteDatabaseCorruptException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteDatabaseLockedException(string @string) /* MethodBuilder.Create */ 
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
				public SQLiteDatatypeMismatchException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteDiskIOException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteDoneException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteFullException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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
				public SQLiteMisuseException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/sqlite/SQLiteOpenHelper
		/// </java-name>
		[Dot42.DexImport("android/database/sqlite/SQLiteOpenHelper", AccessFlags = 1057)]
		public abstract partial class SQLiteOpenHelper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDataba" +
    "se$CursorFactory;I)V", AccessFlags = 1)]
				public SQLiteOpenHelper(global::Android.Content.Context context, string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDataba" +
    "se$CursorFactory;ILandroid/database/DatabaseErrorHandler;)V", AccessFlags = 1)]
				public SQLiteOpenHelper(global::Android.Content.Context context, string @string, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, int int32, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDatabaseName
				/// </java-name>
				[Dot42.DexImport("getDatabaseName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDatabaseName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getWritableDatabase
				/// </java-name>
				[Dot42.DexImport("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetWritableDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// getReadableDatabase
				/// </java-name>
				[Dot42.DexImport("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
				public virtual global::Android.Database.Sqlite.SQLiteDatabase GetReadableDatabase() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1025)]
				public abstract void OnCreate(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onUpgrade
				/// </java-name>
				[Dot42.DexImport("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", AccessFlags = 1025)]
				public abstract void OnUpgrade(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onDowngrade
				/// </java-name>
				[Dot42.DexImport("onDowngrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", AccessFlags = 1)]
				public virtual void OnDowngrade(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onOpen
				/// </java-name>
				[Dot42.DexImport("onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1)]
				public virtual void OnOpen(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SQLiteOpenHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDatabaseName
				/// </java-name>
				public string DatabaseName
				{
				[Dot42.DexImport("getDatabaseName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDatabaseName(); }
				}

				/// <java-name>
				/// getWritableDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase WritableDatabase
				{
				[Dot42.DexImport("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
						get{ return GetWritableDatabase(); }
				}

				/// <java-name>
				/// getReadableDatabase
				/// </java-name>
				public global::Android.Database.Sqlite.SQLiteDatabase ReadableDatabase
				{
				[Dot42.DexImport("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 33)]
						get{ return GetReadableDatabase(); }
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
				public SQLiteOutOfMemoryException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// bindNull
				/// </java-name>
				[Dot42.DexImport("bindNull", "(I)V", AccessFlags = 1)]
				public virtual void BindNull(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindLong
				/// </java-name>
				[Dot42.DexImport("bindLong", "(IJ)V", AccessFlags = 1)]
				public virtual void BindLong(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindDouble
				/// </java-name>
				[Dot42.DexImport("bindDouble", "(ID)V", AccessFlags = 1)]
				public virtual void BindDouble(int int32, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindString
				/// </java-name>
				[Dot42.DexImport("bindString", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void BindString(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindBlob
				/// </java-name>
				[Dot42.DexImport("bindBlob", "(I[B)V", AccessFlags = 1)]
				public virtual void BindBlob(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindBlob
				/// </java-name>
				[Dot42.DexImport("bindBlob", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void BindBlob(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// bindAllArgsAsStrings
				/// </java-name>
				[Dot42.DexImport("bindAllArgsAsStrings", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void BindAllArgsAsStrings(string[] @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getUniqueId
				/// </java-name>
				public int UniqueId
				{
				[Dot42.DexImport("getUniqueId", "()I", AccessFlags = 17)]
						get{ return GetUniqueId(); }
				}

		}

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

				/// <java-name>
				/// setDistinct
				/// </java-name>
				[Dot42.DexImport("setDistinct", "(Z)V", AccessFlags = 1)]
				public virtual void SetDistinct(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTables
				/// </java-name>
				[Dot42.DexImport("getTables", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTables() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setTables
				/// </java-name>
				[Dot42.DexImport("setTables", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTables(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendWhere
				/// </java-name>
				[Dot42.DexImport("appendWhere", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void AppendWhere(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendWhereEscapeString
				/// </java-name>
				[Dot42.DexImport("appendWhereEscapeString", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AppendWhereEscapeString(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProjectionMap
				/// </java-name>
				[Dot42.DexImport("setProjectionMap", "(Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public virtual void SetProjectionMap(global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCursorFactory
				/// </java-name>
				[Dot42.DexImport("setCursorFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)V", AccessFlags = 1)]
				public virtual void SetCursorFactory(global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStrict
				/// </java-name>
				[Dot42.DexImport("setStrict", "(Z)V", AccessFlags = 1)]
				public virtual void SetStrict(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// buildQueryString
				/// </java-name>
				[Dot42.DexImport("buildQueryString", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string BuildQueryString(bool boolean, string @string, string[] string1, string string2, string string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// appendColumns
				/// </java-name>
				[Dot42.DexImport("appendColumns", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AppendColumns(global::System.Text.StringBuilder stringBuilder, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Lj" +
    "ava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/" +
    "database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string[] @string, string string1, string[] string2, string string3, string string4, string string5) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Lj" +
    "ava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang" +
    "/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string[] @string, string string1, string[] string2, string string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// buildQuery
				/// </java-name>
				[Dot42.DexImport("buildQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildQuery(string[] @string, string string1, string string2, string string3, string string4, string string5) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// buildQuery
				/// </java-name>
				[Dot42.DexImport("buildQuery", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/" +
    "lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildQuery(string[] @string, string string1, string[] string2, string string3, string string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// buildUnionSubQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lan" +
    "g/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;ILjava/l" +
    "ang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Str" +
    "ing;")]
				public virtual string BuildUnionSubQuery(string @string, string[] string1, global::Java.Util.ISet<string> set, int int32, string string2, string string3, string string4, string string5) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// buildUnionSubQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lan" +
    "g/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Stri" +
    "ng;", AccessFlags = 1, Signature = "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;ILjava/l" +
    "ang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/Str" +
    "ing;)Ljava/lang/String;")]
				public virtual string BuildUnionSubQuery(string @string, string[] string1, global::Java.Util.ISet<string> set, int int32, string string2, string string3, string[] string4, string string5, string string6) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// buildUnionQuery
				/// </java-name>
				[Dot42.DexImport("buildUnionQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string BuildUnionQuery(string[] @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

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
				public SQLiteReadOnlyDatabaseException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1)]
				public virtual void Execute() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// executeUpdateDelete
				/// </java-name>
				[Dot42.DexImport("executeUpdateDelete", "()I", AccessFlags = 1)]
				public virtual int ExecuteUpdateDelete() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// executeInsert
				/// </java-name>
				[Dot42.DexImport("executeInsert", "()J", AccessFlags = 1)]
				public virtual long ExecuteInsert() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// simpleQueryForLong
				/// </java-name>
				[Dot42.DexImport("simpleQueryForLong", "()J", AccessFlags = 1)]
				public virtual long SimpleQueryForLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// simpleQueryForString
				/// </java-name>
				[Dot42.DexImport("simpleQueryForString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string SimpleQueryForString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// simpleQueryForBlobFileDescriptor
				/// </java-name>
				[Dot42.DexImport("simpleQueryForBlobFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor SimpleQueryForBlobFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
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
				public SQLiteTableLockedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

