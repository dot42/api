#pragma warning disable 1717
namespace Android.Database
{
		/// <java-name>
		/// android/database/CharArrayBuffer
		/// </java-name>
		[Dot42.DexImport("android/database/CharArrayBuffer", AccessFlags = 49)]
		public sealed partial class CharArrayBuffer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// data
				/// </java-name>
				[Dot42.DexImport("data", "[C", AccessFlags = 1)]
				public char[] Data;
				/// <java-name>
				/// sizeCopied
				/// </java-name>
				[Dot42.DexImport("sizeCopied", "I", AccessFlags = 1)]
				public int SizeCopied;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CharArrayBuffer(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public CharArrayBuffer(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharArrayBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/database/SQLException
		/// </java-name>
		[Dot42.DexImport("android/database/SQLException", AccessFlags = 33)]
		public partial class SQLException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SQLException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SQLException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/ContentObservable
		/// </java-name>
		[Dot42.DexImport("android/database/ContentObservable", AccessFlags = 33, Signature = "Landroid/database/Observable<Landroid/database/ContentObserver;>;")]
		public partial class ContentObservable : global::Android.Database.Observable<global::Android.Database.ContentObserver>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentObservable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerObserver
				/// </java-name>
				[Dot42.DexImport("registerObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public override void RegisterObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchChange
				/// </java-name>
				[Dot42.DexImport("dispatchChange", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/DatabaseErrorHandler
		/// </java-name>
		[Dot42.DexImport("android/database/DatabaseErrorHandler", AccessFlags = 1537)]
		public partial interface IDatabaseErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onCorruption
				/// </java-name>
				[Dot42.DexImport("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1025)]
				void OnCorruption(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/database/Observable
		/// </java-name>
		[Dot42.DexImport("android/database/Observable", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Observable<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mObservers
				/// </java-name>
				[Dot42.DexImport("mObservers", "Ljava/util/ArrayList;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.ArrayList<T> MObservers;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Observable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerObserver
				/// </java-name>
				[Dot42.DexImport("registerObserver", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void RegisterObserver(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterObserver
				/// </java-name>
				[Dot42.DexImport("unregisterObserver", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void UnregisterObserver(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterAll
				/// </java-name>
				[Dot42.DexImport("unregisterAll", "()V", AccessFlags = 1)]
				public virtual void UnregisterAll() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/DataSetObservable
		/// </java-name>
		[Dot42.DexImport("android/database/DataSetObservable", AccessFlags = 33, Signature = "Landroid/database/Observable<Landroid/database/DataSetObserver;>;")]
		public partial class DataSetObservable : global::Android.Database.Observable<global::Android.Database.DataSetObserver>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DataSetObservable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyChanged
				/// </java-name>
				[Dot42.DexImport("notifyChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyInvalidated() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/DataSetObserver
		/// </java-name>
		[Dot42.DexImport("android/database/DataSetObserver", AccessFlags = 1057)]
		public abstract partial class DataSetObserver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DataSetObserver() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChanged
				/// </java-name>
				[Dot42.DexImport("onChanged", "()V", AccessFlags = 1)]
				public virtual void OnChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInvalidated
				/// </java-name>
				[Dot42.DexImport("onInvalidated", "()V", AccessFlags = 1)]
				public virtual void OnInvalidated() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/CursorWrapper
		/// </java-name>
		[Dot42.DexImport("android/database/CursorWrapper", AccessFlags = 33)]
		public partial class CursorWrapper : global::Android.Database.ICursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CursorWrapper(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWrappedCursor
				/// </java-name>
				[Dot42.DexImport("getWrappedCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor GetWrappedCursor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public virtual int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1)]
				public virtual bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
				public virtual int GetColumnCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public virtual double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public virtual float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public virtual int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public virtual long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public virtual short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
				public virtual bool GetWantsAllOnMoveCalls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1)]
				public virtual bool IsAfterLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsBeforeFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 1)]
				public virtual bool IsLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public virtual bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1)]
				public virtual bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1)]
				public virtual bool Move(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1)]
				public virtual bool MoveToPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1)]
				public virtual bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
				public virtual int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1)]
				public virtual bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle Respond(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getWrappedCursor
				/// </java-name>
				public global::Android.Database.ICursor WrappedCursor
				{
				[Dot42.DexImport("getWrappedCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return GetWrappedCursor(); }
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
				/// getColumnCount
				/// </java-name>
				public int ColumnCount
				{
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return GetColumnCount(); }
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetColumnNames(); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public bool IsWantsAllOnMoveCalls
				{
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return GetWantsAllOnMoveCalls(); }
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return GetPosition(); }
				}

		}

		/// <java-name>
		/// android/database/MatrixCursor
		/// </java-name>
		[Dot42.DexImport("android/database/MatrixCursor", AccessFlags = 33)]
		public partial class MatrixCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;I)V", AccessFlags = 1)]
				public MatrixCursor(string[] @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public MatrixCursor(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newRow
				/// </java-name>
				[Dot42.DexImport("newRow", "()Landroid/database/MatrixCursor$RowBuilder;", AccessFlags = 1)]
				public virtual global::Android.Database.MatrixCursor.RowBuilder NewRow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.MatrixCursor.RowBuilder);
				}

				/// <java-name>
				/// addRow
				/// </java-name>
				[Dot42.DexImport("addRow", "([Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void AddRow(object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRow
				/// </java-name>
				[Dot42.DexImport("addRow", "(Ljava/lang/Iterable;)V", AccessFlags = 1, Signature = "(Ljava/lang/Iterable<*>;)V")]
				public virtual void AddRow(global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
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
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MatrixCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
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

				/// <java-name>
				/// android/database/MatrixCursor$RowBuilder
				/// </java-name>
				[Dot42.DexImport("android/database/MatrixCursor$RowBuilder", AccessFlags = 1)]
				public partial class RowBuilder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/database/MatrixCursor;", AccessFlags = 4112)]
						internal readonly global::Android.Database.MatrixCursor This_0;
						[Dot42.DexImport("<init>", "(Landroid/database/MatrixCursor;)V", AccessFlags = 0)]
						internal RowBuilder(global::Android.Database.MatrixCursor matrixCursor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;", AccessFlags = 1)]
						public virtual RowBuilder Add(object @object) /* MethodBuilder.Create */ 
						{
								return default(RowBuilder);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal RowBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/database/Cursor
		/// </java-name>
		[Dot42.DexImport("android/database/Cursor", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICursorConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FIELD_TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_NULL", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_NULL = 0;
				/// <java-name>
				/// FIELD_TYPE_INTEGER
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_INTEGER", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_INTEGER = 1;
				/// <java-name>
				/// FIELD_TYPE_FLOAT
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_FLOAT", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_FLOAT = 2;
				/// <java-name>
				/// FIELD_TYPE_STRING
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_STRING", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_STRING = 3;
				/// <java-name>
				/// FIELD_TYPE_BLOB
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_BLOB", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_BLOB = 4;
		}

		/// <java-name>
		/// android/database/Cursor
		/// </java-name>
		[Dot42.DexImport("android/database/Cursor", AccessFlags = 1537)]
		public partial interface ICursor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
				int GetCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1025)]
				int GetPosition() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1025)]
				bool Move(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1025)]
				bool MoveToPosition(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1025)]
				bool MoveToFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1025)]
				bool MoveToLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1025)]
				bool MoveToNext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1025)]
				bool MoveToPrevious() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1025)]
				bool IsFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 1025)]
				bool IsLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1025)]
				bool IsBeforeFirst() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1025)]
				bool IsAfterLast() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetColumnIndex(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetColumnIndexOrThrow(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] GetColumnNames() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1025)]
				int GetColumnCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBlob(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1025)]
				void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				short GetShort(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				int GetInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				long GetLong(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				float GetFloat(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				double GetDouble(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1025)]
				int GetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1025)]
				bool IsNull(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1025)]
				void Deactivate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1025)]
				bool Requery() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
				bool IsClosed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1025)]
				void SetNotificationUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1025)]
				bool GetWantsAllOnMoveCalls() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1025)]
				global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				global::Android.Os.Bundle Respond(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/database/MergeCursor
		/// </java-name>
		[Dot42.DexImport("android/database/MergeCursor", AccessFlags = 33)]
		public partial class MergeCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Landroid/database/Cursor;)V", AccessFlags = 1)]
				public MergeCursor(global::Android.Database.ICursor[] cursor) /* MethodBuilder.Create */ 
				{
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
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public override bool OnMove(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public override void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public override void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public override void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public override void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MergeCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
		/// android/database/ContentObserver
		/// </java-name>
		[Dot42.DexImport("android/database/ContentObserver", AccessFlags = 1057)]
		public abstract partial class ContentObserver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public ContentObserver(global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deliverSelfNotifications
				/// </java-name>
				[Dot42.DexImport("deliverSelfNotifications", "()Z", AccessFlags = 1)]
				public virtual bool DeliverSelfNotifications() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onChange
				/// </java-name>
				[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 1)]
				public virtual void OnChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchChange
				/// </java-name>
				[Dot42.DexImport("dispatchChange", "(Z)V", AccessFlags = 17)]
				public void DispatchChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/database/DefaultDatabaseErrorHandler
		/// </java-name>
		[Dot42.DexImport("android/database/DefaultDatabaseErrorHandler", AccessFlags = 49)]
		public sealed partial class DefaultDatabaseErrorHandler : global::Android.Database.IDatabaseErrorHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultDatabaseErrorHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCorruption
				/// </java-name>
				[Dot42.DexImport("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1)]
				public void OnCorruption(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/CrossProcessCursor
		/// </java-name>
		[Dot42.DexImport("android/database/CrossProcessCursor", AccessFlags = 1537)]
		public partial interface ICrossProcessCursor : global::Android.Database.ICursor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1025)]
				global::Android.Database.CursorWindow GetWindow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1025)]
				void FillWindow(int int32, global::Android.Database.CursorWindow cursorWindow) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1025)]
				bool OnMove(int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/database/CursorWindow
		/// </java-name>
		[Dot42.DexImport("android/database/CursorWindow", AccessFlags = 33)]
		public partial class CursorWindow : global::Android.Database.Sqlite.SQLiteClosable, global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Database.CursorWindow> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorWindow(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public CursorWindow(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~CursorWindow() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStartPosition
				/// </java-name>
				[Dot42.DexImport("getStartPosition", "()I", AccessFlags = 1)]
				public virtual int GetStartPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setStartPosition
				/// </java-name>
				[Dot42.DexImport("setStartPosition", "(I)V", AccessFlags = 1)]
				public virtual void SetStartPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumRows
				/// </java-name>
				[Dot42.DexImport("getNumRows", "()I", AccessFlags = 1)]
				public virtual int GetNumRows() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setNumColumns
				/// </java-name>
				[Dot42.DexImport("setNumColumns", "(I)Z", AccessFlags = 1)]
				public virtual bool SetNumColumns(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// allocRow
				/// </java-name>
				[Dot42.DexImport("allocRow", "()Z", AccessFlags = 1)]
				public virtual bool AllocRow() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// freeLastRow
				/// </java-name>
				[Dot42.DexImport("freeLastRow", "()V", AccessFlags = 1)]
				public virtual void FreeLastRow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(II)Z", AccessFlags = 1)]
				public virtual bool IsNull(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBlob
				/// </java-name>
				[Dot42.DexImport("isBlob", "(II)Z", AccessFlags = 1)]
				public virtual bool IsBlob(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLong
				/// </java-name>
				[Dot42.DexImport("isLong", "(II)Z", AccessFlags = 1)]
				public virtual bool IsLong(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFloat
				/// </java-name>
				[Dot42.DexImport("isFloat", "(II)Z", AccessFlags = 1)]
				public virtual bool IsFloat(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isString
				/// </java-name>
				[Dot42.DexImport("isString", "(II)Z", AccessFlags = 1)]
				public virtual bool IsString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(II)I", AccessFlags = 1)]
				public virtual int GetType(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(II)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(II)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int int32, int int321, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(II)J", AccessFlags = 1)]
				public virtual long GetLong(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(II)D", AccessFlags = 1)]
				public virtual double GetDouble(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(II)S", AccessFlags = 1)]
				public virtual short GetShort(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(II)I", AccessFlags = 1)]
				public virtual int GetInt(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(II)F", AccessFlags = 1)]
				public virtual float GetFloat(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// putBlob
				/// </java-name>
				[Dot42.DexImport("putBlob", "([BII)Z", AccessFlags = 1)]
				public virtual bool PutBlob(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putBlob
				/// </java-name>
				[Dot42.DexImport("putBlob", "([BII)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool PutBlob(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;II)Z", AccessFlags = 1)]
				public virtual bool PutString(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(JII)Z", AccessFlags = 1)]
				public virtual bool PutLong(long int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(DII)Z", AccessFlags = 1)]
				public virtual bool PutDouble(double @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// putNull
				/// </java-name>
				[Dot42.DexImport("putNull", "(II)Z", AccessFlags = 1)]
				public virtual bool PutNull(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newFromParcel
				/// </java-name>
				[Dot42.DexImport("newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;", AccessFlags = 9)]
				public static global::Android.Database.CursorWindow NewFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorWindow);
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
				/// onAllReferencesReleased
				/// </java-name>
				[Dot42.DexImport("onAllReferencesReleased", "()V", AccessFlags = 4)]
				protected internal override void OnAllReferencesReleased() /* MethodBuilder.Create */ 
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
				internal CursorWindow() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStartPosition
				/// </java-name>
				public int StartPosition
				{
				[Dot42.DexImport("getStartPosition", "()I", AccessFlags = 1)]
						get{ return GetStartPosition(); }
				[Dot42.DexImport("setStartPosition", "(I)V", AccessFlags = 1)]
						set{ SetStartPosition(value); }
				}

				/// <java-name>
				/// getNumRows
				/// </java-name>
				public int NumRows
				{
				[Dot42.DexImport("getNumRows", "()I", AccessFlags = 1)]
						get{ return GetNumRows(); }
				}

		}

		/// <java-name>
		/// android/database/AbstractWindowedCursor
		/// </java-name>
		[Dot42.DexImport("android/database/AbstractWindowedCursor", AccessFlags = 1057)]
		public abstract partial class AbstractWindowedCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mWindow
				/// </java-name>
				[Dot42.DexImport("mWindow", "Landroid/database/CursorWindow;", AccessFlags = 4)]
				protected internal global::Android.Database.CursorWindow MWindow;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractWindowedCursor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public override void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBlob
				/// </java-name>
				[Dot42.DexImport("isBlob", "(I)Z", AccessFlags = 1)]
				public virtual bool IsBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isString
				/// </java-name>
				[Dot42.DexImport("isString", "(I)Z", AccessFlags = 1)]
				public virtual bool IsString(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLong
				/// </java-name>
				[Dot42.DexImport("isLong", "(I)Z", AccessFlags = 1)]
				public virtual bool IsLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFloat
				/// </java-name>
				[Dot42.DexImport("isFloat", "(I)Z", AccessFlags = 1)]
				public virtual bool IsFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkPosition
				/// </java-name>
				[Dot42.DexImport("checkPosition", "()V", AccessFlags = 4)]
				protected internal override void CheckPosition() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
				public override global::Android.Database.CursorWindow GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorWindow);
				}

				/// <java-name>
				/// setWindow
				/// </java-name>
				[Dot42.DexImport("setWindow", "(Landroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void SetWindow(global::Android.Database.CursorWindow cursorWindow) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasWindow
				/// </java-name>
				[Dot42.DexImport("hasWindow", "()Z", AccessFlags = 1)]
				public virtual bool HasWindow() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.Database.CursorWindow Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

		}

		/// <java-name>
		/// android/database/StaleDataException
		/// </java-name>
		[Dot42.DexImport("android/database/StaleDataException", AccessFlags = 33)]
		public partial class StaleDataException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StaleDataException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StaleDataException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/database/AbstractCursor
		/// </java-name>
		[Dot42.DexImport("android/database/AbstractCursor", AccessFlags = 1057)]
		public abstract partial class AbstractCursor : global::Android.Database.ICrossProcessCursor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mUpdatedRows
				/// </java-name>
				[Dot42.DexImport("mUpdatedRows", "Ljava/util/HashMap;", AccessFlags = 4)]
				protected internal global::Java.Util.HashMap<long?, global::Java.Util.IMap<string, object>> MUpdatedRows;
				/// <java-name>
				/// mRowIdColumnIndex
				/// </java-name>
				[Dot42.DexImport("mRowIdColumnIndex", "I", AccessFlags = 4)]
				protected internal int MRowIdColumnIndex;
				/// <java-name>
				/// mPos
				/// </java-name>
				[Dot42.DexImport("mPos", "I", AccessFlags = 4)]
				protected internal int MPos;
				/// <java-name>
				/// mCurrentRowID
				/// </java-name>
				[Dot42.DexImport("mCurrentRowID", "Ljava/lang/Long;", AccessFlags = 4)]
				protected internal long? MCurrentRowID;
				/// <java-name>
				/// mContentResolver
				/// </java-name>
				[Dot42.DexImport("mContentResolver", "Landroid/content/ContentResolver;", AccessFlags = 4)]
				protected internal global::Android.Content.ContentResolver MContentResolver;
				/// <java-name>
				/// mClosed
				/// </java-name>
				[Dot42.DexImport("mClosed", "Z", AccessFlags = 4)]
				protected internal bool MClosed;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractCursor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
				public virtual int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				public virtual short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				public virtual int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				public virtual long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				public virtual float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				public virtual double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1025)]
				public virtual bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
				public virtual global::Android.Database.CursorWindow GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorWindow);
				}

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
				public virtual int GetColumnCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public virtual bool OnMove(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 17)]
				public int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 17)]
				public bool MoveToPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void FillWindow(int int32, global::Android.Database.CursorWindow cursorWindow) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 17)]
				public bool Move(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 17)]
				public bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 17)]
				public bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 17)]
				public bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 17)]
				public bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 17)]
				public bool IsFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 17)]
				public bool IsLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 17)]
				public bool IsBeforeFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 17)]
				public bool IsAfterLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChange
				/// </java-name>
				[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 4)]
				protected internal virtual void OnChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNotificationUri
				/// </java-name>
				[Dot42.DexImport("getNotificationUri", "()Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetNotificationUri() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
				public virtual bool GetWantsAllOnMoveCalls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle Respond(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// isFieldUpdated
				/// </java-name>
				[Dot42.DexImport("isFieldUpdated", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool IsFieldUpdated(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getUpdatedField
				/// </java-name>
				[Dot42.DexImport("getUpdatedField", "(I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object GetUpdatedField(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// checkPosition
				/// </java-name>
				[Dot42.DexImport("checkPosition", "()V", AccessFlags = 4)]
				protected internal virtual void CheckPosition() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AbstractCursor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
						get{ return GetCount(); }
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetColumnNames(); }
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.Database.CursorWindow Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public int ColumnCount
				{
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return GetColumnCount(); }
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 17)]
						get{ return GetPosition(); }
				}

				/// <java-name>
				/// getNotificationUri
				/// </java-name>
				public global::Android.Net.Uri NotificationUri
				{
				[Dot42.DexImport("getNotificationUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return GetNotificationUri(); }
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public bool IsWantsAllOnMoveCalls
				{
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return GetWantsAllOnMoveCalls(); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <java-name>
				/// android/database/AbstractCursor$SelfContentObserver
				/// </java-name>
				[Dot42.DexImport("android/database/AbstractCursor$SelfContentObserver", AccessFlags = 12)]
				protected internal partial class SelfContentObserver : global::Android.Database.ContentObserver
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/database/AbstractCursor;)V", AccessFlags = 1)]
						public SelfContentObserver(global::Android.Database.AbstractCursor abstractCursor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// deliverSelfNotifications
						/// </java-name>
						[Dot42.DexImport("deliverSelfNotifications", "()Z", AccessFlags = 1)]
						public override bool DeliverSelfNotifications() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onChange
						/// </java-name>
						[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 1)]
						public override void OnChange(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SelfContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/database/DatabaseUtils
		/// </java-name>
		[Dot42.DexImport("android/database/DatabaseUtils", AccessFlags = 33)]
		public partial class DatabaseUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATEMENT_SELECT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_SELECT", "I", AccessFlags = 25)]
				public const int STATEMENT_SELECT = 1;
				/// <java-name>
				/// STATEMENT_UPDATE
				/// </java-name>
				[Dot42.DexImport("STATEMENT_UPDATE", "I", AccessFlags = 25)]
				public const int STATEMENT_UPDATE = 2;
				/// <java-name>
				/// STATEMENT_ATTACH
				/// </java-name>
				[Dot42.DexImport("STATEMENT_ATTACH", "I", AccessFlags = 25)]
				public const int STATEMENT_ATTACH = 3;
				/// <java-name>
				/// STATEMENT_BEGIN
				/// </java-name>
				[Dot42.DexImport("STATEMENT_BEGIN", "I", AccessFlags = 25)]
				public const int STATEMENT_BEGIN = 4;
				/// <java-name>
				/// STATEMENT_COMMIT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_COMMIT", "I", AccessFlags = 25)]
				public const int STATEMENT_COMMIT = 5;
				/// <java-name>
				/// STATEMENT_ABORT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_ABORT", "I", AccessFlags = 25)]
				public const int STATEMENT_ABORT = 6;
				/// <java-name>
				/// STATEMENT_PRAGMA
				/// </java-name>
				[Dot42.DexImport("STATEMENT_PRAGMA", "I", AccessFlags = 25)]
				public const int STATEMENT_PRAGMA = 7;
				/// <java-name>
				/// STATEMENT_DDL
				/// </java-name>
				[Dot42.DexImport("STATEMENT_DDL", "I", AccessFlags = 25)]
				public const int STATEMENT_DDL = 8;
				/// <java-name>
				/// STATEMENT_UNPREPARED
				/// </java-name>
				[Dot42.DexImport("STATEMENT_UNPREPARED", "I", AccessFlags = 25)]
				public const int STATEMENT_UNPREPARED = 9;
				/// <java-name>
				/// STATEMENT_OTHER
				/// </java-name>
				[Dot42.DexImport("STATEMENT_OTHER", "I", AccessFlags = 25)]
				public const int STATEMENT_OTHER = 99;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatabaseUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeExceptionToParcel
				/// </java-name>
				[Dot42.DexImport("writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V", AccessFlags = 25)]
				public static void WriteExceptionToParcel(global::Android.Os.Parcel parcel, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 25)]
				public static void ReadExceptionFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readExceptionWithFileNotFoundExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void ReadExceptionWithFileNotFoundExceptionFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readExceptionWithOperationApplicationExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void ReadExceptionWithOperationApplicationExceptionFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindObjectToProgram
				/// </java-name>
				[Dot42.DexImport("bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V", AccessFlags = 9)]
				public static void BindObjectToProgram(global::Android.Database.Sqlite.SQLiteProgram sQLiteProgram, int int32, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendEscapedSQLString
				/// </java-name>
				[Dot42.DexImport("appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AppendEscapedSQLString(global::System.Text.StringBuilder stringBuilder, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sqlEscapeString
				/// </java-name>
				[Dot42.DexImport("sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string SqlEscapeString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// appendValueToSql
				/// </java-name>
				[Dot42.DexImport("appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V", AccessFlags = 25)]
				public static void AppendValueToSql(global::System.Text.StringBuilder stringBuilder, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// concatenateWhere
				/// </java-name>
				[Dot42.DexImport("concatenateWhere", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ConcatenateWhere(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCollationKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getHexCollationKey
				/// </java-name>
				[Dot42.DexImport("getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetHexCollationKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor, global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor, global::System.Text.StringBuilder stringBuilder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCursorToString
				/// </java-name>
				[Dot42.DexImport("dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DumpCursorToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor, global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor, global::System.Text.StringBuilder stringBuilder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCurrentRowToString
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DumpCurrentRowToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// cursorStringToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorStringToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorStringToInsertHelper
				/// </java-name>
				[Dot42.DexImport("cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$Inser" +
    "tHelper;I)V", AccessFlags = 9)]
				public static void CursorStringToInsertHelper(global::Android.Database.ICursor cursor, string @string, global::Android.Database.DatabaseUtils.InsertHelper insertHelper, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorStringToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorStringToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorIntToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorIntToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorIntToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorIntToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorLongToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorLongToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorLongToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorLongToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorDoubleToCursorValues
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorDoubleToCursorValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorDoubleToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorDoubleToContentValues(global::Android.Database.ICursor cursor, string @string, global::Android.Content.ContentValues contentValues, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorRowToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorRowToContentValues(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;[Lja" +
    "va/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string, string string1, string[] string2) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// longForQuery
				/// </java-name>
				[Dot42.DexImport("longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J", AccessFlags = 9)]
				public static long LongForQuery(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// longForQuery
				/// </java-name>
				[Dot42.DexImport("longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J", AccessFlags = 9)]
				public static long LongForQuery(global::Android.Database.Sqlite.SQLiteStatement sQLiteStatement, string[] @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// stringForQuery
				/// </java-name>
				[Dot42.DexImport("stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Lj" +
    "ava/lang/String;", AccessFlags = 9)]
				public static string StringForQuery(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// stringForQuery
				/// </java-name>
				[Dot42.DexImport("stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StringForQuery(global::Android.Database.Sqlite.SQLiteStatement sQLiteStatement, string[] @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// blobFileDescriptorForQuery
				/// </java-name>
				[Dot42.DexImport("blobFileDescriptorForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)La" +
    "ndroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.Os.ParcelFileDescriptor BlobFileDescriptorForQuery(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// blobFileDescriptorForQuery
				/// </java-name>
				[Dot42.DexImport("blobFileDescriptorForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Landroid/os/ParcelF" +
    "ileDescriptor;", AccessFlags = 9)]
				public static global::Android.Os.ParcelFileDescriptor BlobFileDescriptorForQuery(global::Android.Database.Sqlite.SQLiteStatement sQLiteStatement, string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// cursorStringToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorStringToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorLongToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorLongToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorShortToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorShortToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorShortToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorIntToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorIntToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorFloatToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorFloatToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorFloatToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cursorDoubleToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorDoubleToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues contentValues, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createDbFromSqlStatements
				/// </java-name>
				[Dot42.DexImport("createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 9)]
				public static void CreateDbFromSqlStatements(global::Android.Content.Context context, string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSqlStatementType
				/// </java-name>
				[Dot42.DexImport("getSqlStatementType", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetSqlStatementType(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// appendSelectionArgs
				/// </java-name>
				[Dot42.DexImport("appendSelectionArgs", "([Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] AppendSelectionArgs(string[] @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// android/database/DatabaseUtils$InsertHelper
				/// </java-name>
				[Dot42.DexImport("android/database/DatabaseUtils$InsertHelper", AccessFlags = 9)]
				public partial class InsertHelper
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TABLE_INFO_PRAGMA_DEFAULT_INDEX
						/// </java-name>
						[Dot42.DexImport("TABLE_INFO_PRAGMA_DEFAULT_INDEX", "I", AccessFlags = 25)]
						public const int TABLE_INFO_PRAGMA_DEFAULT_INDEX = 4;
						[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", AccessFlags = 1)]
						public InsertHelper(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getColumnIndex
						/// </java-name>
						[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
						public virtual int GetColumnIndex(string @string) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(ID)V", AccessFlags = 1)]
						public virtual void Bind(int int32, double @double) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IF)V", AccessFlags = 1)]
						public virtual void Bind(int int32, float single) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IJ)V", AccessFlags = 1)]
						public virtual void Bind(int int32, long int64) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(II)V", AccessFlags = 1)]
						public virtual void Bind(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IZ)V", AccessFlags = 1)]
						public virtual void Bind(int int32, bool boolean) /* MethodBuilder.Create */ 
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
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(I[B)V", AccessFlags = 1)]
						public virtual void Bind(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public virtual void Bind(int int32, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void Bind(int int32, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentValues;)J", AccessFlags = 1)]
						public virtual long Insert(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// execute
						/// </java-name>
						[Dot42.DexImport("execute", "()J", AccessFlags = 1)]
						public virtual long Execute() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// prepareForInsert
						/// </java-name>
						[Dot42.DexImport("prepareForInsert", "()V", AccessFlags = 1)]
						public virtual void PrepareForInsert() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// prepareForReplace
						/// </java-name>
						[Dot42.DexImport("prepareForReplace", "()V", AccessFlags = 1)]
						public virtual void PrepareForReplace() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// replace
						/// </java-name>
						[Dot42.DexImport("replace", "(Landroid/content/ContentValues;)J", AccessFlags = 1)]
						public virtual long Replace(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 1)]
						public virtual void Close() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InsertHelper() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/database/CrossProcessCursorWrapper
		/// </java-name>
		[Dot42.DexImport("android/database/CrossProcessCursorWrapper", AccessFlags = 33)]
		public partial class CrossProcessCursorWrapper : global::Android.Database.CursorWrapper, global::Android.Database.ICrossProcessCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CrossProcessCursorWrapper(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void FillWindow(int int32, global::Android.Database.CursorWindow cursorWindow) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
				public virtual global::Android.Database.CursorWindow GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorWindow);
				}

				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public virtual bool OnMove(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CrossProcessCursorWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "getCount", "()I", AccessFlags = 1025)]
				public override int GetCount() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getPosition", "()I", AccessFlags = 1025)]
				public override int GetPosition() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "move", "(I)Z", AccessFlags = 1025)]
				public override bool Move(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToPosition", "(I)Z", AccessFlags = 1025)]
				public override bool MoveToPosition(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToFirst", "()Z", AccessFlags = 1025)]
				public override bool MoveToFirst() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToLast", "()Z", AccessFlags = 1025)]
				public override bool MoveToLast() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToNext", "()Z", AccessFlags = 1025)]
				public override bool MoveToNext() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToPrevious", "()Z", AccessFlags = 1025)]
				public override bool MoveToPrevious() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "isFirst", "()Z", AccessFlags = 1025)]
				public override bool IsFirst() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "isLast", "()Z", AccessFlags = 1025)]
				public override bool IsLast() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "isBeforeFirst", "()Z", AccessFlags = 1025)]
				public override bool IsBeforeFirst() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "isAfterLast", "()Z", AccessFlags = 1025)]
				public override bool IsAfterLast() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetColumnIndex(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetColumnIndexOrThrow(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetColumnName(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public override string[] GetColumnNames() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string[]);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnCount", "()I", AccessFlags = 1025)]
				public override int GetColumnCount() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getBlob", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public override byte[] GetBlob(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				[Dot42.DexImport("android/database/Cursor", "getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetString(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("android/database/Cursor", "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1025)]
				public override void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "getShort", "(I)S", AccessFlags = 1025)]
				public override short GetShort(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(short);
				}

				[Dot42.DexImport("android/database/Cursor", "getInt", "(I)I", AccessFlags = 1025)]
				public override int GetInt(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getLong", "(I)J", AccessFlags = 1025)]
				public override long GetLong(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/database/Cursor", "getFloat", "(I)F", AccessFlags = 1025)]
				public override float GetFloat(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(float);
				}

				[Dot42.DexImport("android/database/Cursor", "getDouble", "(I)D", AccessFlags = 1025)]
				public override double GetDouble(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(double);
				}

				[Dot42.DexImport("android/database/Cursor", "getType", "(I)I", AccessFlags = 1025)]
				public override int GetType(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "isNull", "(I)Z", AccessFlags = 1025)]
				public override bool IsNull(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "deactivate", "()V", AccessFlags = 1025)]
				public override void Deactivate() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "requery", "()Z", AccessFlags = 1025)]
				public override bool Requery() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "close", "()V", AccessFlags = 1025)]
				public override void Close() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "isClosed", "()Z", AccessFlags = 1025)]
				public override bool IsClosed() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				public override void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				public override void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				public override void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				public override void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1025)]
				public override void SetNotificationUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "getWantsAllOnMoveCalls", "()Z", AccessFlags = 1025)]
				public override bool GetWantsAllOnMoveCalls() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "getExtras", "()Landroid/os/Bundle;", AccessFlags = 1025)]
				public override global::Android.Os.Bundle GetExtras() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Os.Bundle);
				}

				[Dot42.DexImport("android/database/Cursor", "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public override global::Android.Os.Bundle Respond(global::Android.Os.Bundle bundle) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.Database.CursorWindow Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

				public int Count
				{
				[Dot42.DexImport("android/database/Cursor", "getCount", "()I", AccessFlags = 1025)]
						get{ return GetCount(); }
				}

				public int Position
				{
				[Dot42.DexImport("android/database/Cursor", "getPosition", "()I", AccessFlags = 1025)]
						get{ return GetPosition(); }
				}

				public string[] ColumnNames
				{
				[Dot42.DexImport("android/database/Cursor", "getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetColumnNames(); }
				}

				public int ColumnCount
				{
				[Dot42.DexImport("android/database/Cursor", "getColumnCount", "()I", AccessFlags = 1025)]
						get{ return GetColumnCount(); }
				}

				public bool IsWantsAllOnMoveCalls
				{
				[Dot42.DexImport("android/database/Cursor", "getWantsAllOnMoveCalls", "()Z", AccessFlags = 1025)]
						get{ return GetWantsAllOnMoveCalls(); }
				}

				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("android/database/Cursor", "getExtras", "()Landroid/os/Bundle;", AccessFlags = 1025)]
						get{ return GetExtras(); }
				}

		}

		/// <java-name>
		/// android/database/CursorIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("android/database/CursorIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class CursorIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public CursorIndexOutOfBoundsException(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorIndexOutOfBoundsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorIndexOutOfBoundsException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/database/CursorJoiner
		/// </java-name>
		[Dot42.DexImport("android/database/CursorJoiner", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Landroid/database/CursorJoiner$Result;>;Lja" +
    "va/lang/Iterable<Landroid/database/CursorJoiner$Result;>;")]
		public sealed partial class CursorJoiner : global::Java.Util.IIterator<global::Android.Database.CursorJoiner.Result>, global::Java.Lang.IIterable<global::Android.Database.CursorJoiner.Result>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang" +
    "/String;)V", AccessFlags = 1)]
				public CursorJoiner(global::Android.Database.ICursor cursor, string[] @string, global::Android.Database.ICursor cursor1, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Landroid/database/CursorJoiner$Result;>;")]
				public global::Java.Util.IIterator<global::Android.Database.CursorJoiner.Result> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::Android.Database.CursorJoiner.Result>);
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Landroid/database/CursorJoiner$Result;", AccessFlags = 1)]
				public global::Android.Database.CursorJoiner.Result Next() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorJoiner.Result);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorJoiner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/database/CursorJoiner$Result
				/// </java-name>
				[Dot42.DexImport("android/database/CursorJoiner$Result", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/database/CursorJoiner$Result;>;")]
				public sealed class Result
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BOTH
						/// </java-name>
						[Dot42.DexImport("BOTH", "Landroid/database/CursorJoiner$Result;", AccessFlags = 16409)]
						public static readonly Result BOTH;
						/// <java-name>
						/// LEFT
						/// </java-name>
						[Dot42.DexImport("LEFT", "Landroid/database/CursorJoiner$Result;", AccessFlags = 16409)]
						public static readonly Result LEFT;
						/// <java-name>
						/// RIGHT
						/// </java-name>
						[Dot42.DexImport("RIGHT", "Landroid/database/CursorJoiner$Result;", AccessFlags = 16409)]
						public static readonly Result RIGHT;
						private Result() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/database/CursorJoiner$Result;", AccessFlags = 9)]
						public static Result[] Values() /* MethodBuilder.Create */ 
						{
								return default(Result[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;", AccessFlags = 9)]
						public static Result ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Result);
						}

				}

		}

}

