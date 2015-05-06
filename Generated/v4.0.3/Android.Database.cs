#pragma warning disable 1717
namespace Android.Database
{
		/// <summary>
		///  <para>This is an abstract cursor class that handles a lot of the common code that all cursors need to deal with and is provided for convenience reasons. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/AbstractCursor
		/// </java-name>
		[Dot42.DexImport("android/database/AbstractCursor", AccessFlags = 1057)]
		public abstract partial class AbstractCursor : global::Android.Database.ICrossProcessCursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This is never updated by this class and should not be used </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// mUpdatedRows
				/// </java-name>
				[Dot42.DexImport("mUpdatedRows", "Ljava/util/HashMap;", AccessFlags = 4)]
				protected internal global::Java.Util.HashMap<long?, global::Java.Util.IMap<string, object>> MUpdatedRows;
				/// <summary>
				///  <para>This must be set to the index of the row ID column by any subclass that wishes to support updates.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This field should not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
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
				/// <summary>
				///  <para>If mRowIdColumnIndex is not -1 this contains contains the value of the column at mRowIdColumnIndex for the current row this cursor is pointing at.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This field should not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				public virtual short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				public virtual int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				public virtual long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				public virtual float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				public virtual double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1025)]
				public virtual bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para> <para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function is called every time the cursor is successfully scrolled to a new position, giving the subclass a chance to update any state it may have. If it returns false the move function will also do so and the cursor will scroll to the beforeFirst position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the move is successful, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public virtual bool OnMove(int oldPosition, int newPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the cursor to an absolute position. The valid range of values is -1 &lt;= position &lt;= count.</para> <para>This method will return true if the request destination was reachable, otherwise, it returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 17)]
				public bool MoveToPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Copies cursor data into the window. </para> <para>Clears the window and fills it with data beginning at the requested row position until all of the data in the cursor is exhausted or the window runs out of space. </para> <para>The filled window uses the same row indices as the original cursor. For example, if you fill a window starting from row 5 from the cursor, you can query the contents of row 5 from the window just by asking it for row 5 because there is a direct correspondence between the row indices used by the cursor and the window. </para> <para>The current position of the cursor, as returned by getPosition, is not changed by this method. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void FillWindow(int position, global::Android.Database.CursorWindow window) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the cursor by a relative amount, forward or backward, from the current position. Positive offsets move forwards, negative offsets move backwards. If the final position is outside of the bounds of the result set then the resultant position will be pinned to -1 or count() depending on whether the value is off the front or end of the set, respectively.</para> <para>This method will return true if the requested destination was reachable, otherwise, it returns false. For example, if the cursor is at currently on the second entry in the result set and move(-5) is called, the position will be pinned at -1, and false will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 17)]
				public bool Move(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the first row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 17)]
				public bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the last row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 17)]
				public bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the next row.</para> <para>This method will return false if the cursor is already past the last entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 17)]
				public bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the previous row.</para> <para>This method will return false if the cursor is already before the first entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 17)]
				public bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para> <para> <para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or throws IllegalArgumentException if the column doesn't exist. If you're not sure if a column will exist or not use getColumnIndex(String) and check for -1, which is more efficient than catching the exceptions.</para> <para> <para>getColumnIndex(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the column name at the given zero-based column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column name for the given column index. </para>
				/// </returns>
				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para> <para> <para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para> <para> <para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must call this method when they finish committing updates to notify all observers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onChange
				/// </java-name>
				[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 4)]
				protected internal virtual void OnChange(bool selfChange) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies a content URI to watch for changes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri notifyUri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is an out-of-band way for the the user of a cursor to communicate with the cursor. The structure of each bundle is entirely defined by the cursor.</para> <para>One use of this is to tell a cursor that it should retry its network request after it reported an error. </para>        
				/// </summary>
				/// <returns>
				///  <para>extra values, or Bundle.EMPTY. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle Respond(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always returns false since Cursors do not support updating rows </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isFieldUpdated
				/// </java-name>
				[Dot42.DexImport("isFieldUpdated", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool IsFieldUpdated(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always returns null since Cursors do not support updating rows </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUpdatedField
				/// </java-name>
				[Dot42.DexImport("getUpdatedField", "(I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object GetUpdatedField(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>This function throws CursorIndexOutOfBoundsException if the cursor position is out of bounds. Subclass implementations of the get functions should call this before attempting to retrieve data.</para> <para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public virtual string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>If the cursor is backed by a CursorWindow, returns a pre-filled window with the contents of the cursor, otherwise null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The pre-filled window that backs this cursor, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Database.CursorWindow Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return default(global::Android.Database.CursorWindow); }
				}

				/// <summary>
				///  <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				///  <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public virtual int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>return true if the cursor is closed </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the cursor is closed. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
						[Dot42.DexImport("getPosition", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the first entry. </para>
				/// </returns>
				/// <java-name>
				/// isFirst
				/// </java-name>
				public bool IsFirst
				{
						[Dot42.DexImport("isFirst", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the last entry. </para>
				/// </returns>
				/// <java-name>
				/// isLast
				/// </java-name>
				public bool IsLast
				{
						[Dot42.DexImport("isLast", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position before the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is before the first result. </para>
				/// </returns>
				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				public bool IsBeforeFirst
				{
						[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position after the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is after the last result. </para>
				/// </returns>
				/// <java-name>
				/// isAfterLast
				/// </java-name>
				public bool IsAfterLast
				{
						[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the URI at which notifications of changes in this Cursor's data will be delivered, as previously set by setNotificationUri. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a URI that can be used with ContentResolver.registerContentObserver to find out about changes to this Cursor's data. May be null if no notification URI has been set. </para>
				/// </returns>
				/// <java-name>
				/// getNotificationUri
				/// </java-name>
				public virtual global::Android.Net.Uri NotificationUri
				{
						[Dot42.DexImport("getNotificationUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Uri); }
				}

				/// <summary>
				///  <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public virtual bool WantsAllOnMoveCalls
				{
						[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para> <para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				///  <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>Cursors use this class to track changes others make to their URI. </para>    
				/// </summary>
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
						public override void OnChange(bool selfChange) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SelfContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A base class for Cursors that store their data in CursorWindows. </para> <para>The cursor owns the cursor window it uses. When the cursor is closed, its window is also closed. Likewise, when the window used by the cursor is changed, its old window is closed. This policy of strict ownership ensures that cursor windows are not leaked. </para> <para>Subclasses are responsible for filling the cursor window with data during onMove(int, int), allocating a new cursor window if necessary. During requery(), the existing cursor window should be cleared and filled with new data. </para> <para>If the contents of the cursor change or become invalid, the old window must be closed (because it is owned by the cursor) and set to null. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/AbstractWindowedCursor
		/// </java-name>
		[Dot42.DexImport("android/database/AbstractWindowedCursor", AccessFlags = 1057)]
		public abstract partial class AbstractWindowedCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The cursor window owned by this cursor. </para>        
				/// </summary>
				/// <java-name>
				/// mWindow
				/// </java-name>
				[Dot42.DexImport("mWindow", "Landroid/database/CursorWindow;", AccessFlags = 4)]
				protected internal global::Android.Database.CursorWindow MWindow;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractWindowedCursor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public override void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isBlob
				/// </java-name>
				[Dot42.DexImport("isBlob", "(I)Z", AccessFlags = 1)]
				public virtual bool IsBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isString
				/// </java-name>
				[Dot42.DexImport("isString", "(I)Z", AccessFlags = 1)]
				public virtual bool IsString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isLong
				/// </java-name>
				[Dot42.DexImport("isLong", "(I)Z", AccessFlags = 1)]
				public virtual bool IsLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isFloat
				/// </java-name>
				[Dot42.DexImport("isFloat", "(I)Z", AccessFlags = 1)]
				public virtual bool IsFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int columnIndex) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Sets a new cursor window for the cursor to use. </para> <para>The cursor takes ownership of the provided cursor window; the cursor window will be closed when the cursor is closed or when the cursor adopts a new cursor window. </para> <para>If the cursor previously had a cursor window, then it is closed when the new cursor window is assigned. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWindow
				/// </java-name>
				[Dot42.DexImport("setWindow", "(Landroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void SetWindow(global::Android.Database.CursorWindow window) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a pre-filled window that contains the data within this cursor. </para> <para>In particular, the window contains the row indicated by Cursor#getPosition. The window's contents are automatically scrolled whenever the current row moved outside the range covered by the window. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The pre-filled window, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public override global::Android.Database.CursorWindow Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return default(global::Android.Database.CursorWindow); }
				}

				/// <summary>
				///  <para>Returns true if the cursor has an associated cursor window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the cursor has an associated cursor window. </para>
				/// </returns>
				/// <java-name>
				/// hasWindow
				/// </java-name>
				public virtual bool HasWindow
				{
						[Dot42.DexImport("hasWindow", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>This is used for Cursor#copyStringToBuffer </para>    
		/// </summary>
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
				public CharArrayBuffer(int size) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public CharArrayBuffer(char[] size) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharArrayBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialization of Observable for ContentObserver that provides methods for sending notifications to a list of ContentObserver objects. </para>    
		/// </summary>
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
				public override void RegisterObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invokes ContentObserver#dispatchChange(boolean) on each observer. </para> <para>If  <code>selfChange</code> is true, only delivers the notification to the observer if it has indicated that it wants to receive self-change notifications by implementing ContentObserver#deliverSelfNotifications to return true. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use dispatchChange(boolean, Uri) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dispatchChange
				/// </java-name>
				[Dot42.DexImport("dispatchChange", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchChange(bool selfChange) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invokes ContentObserver#onChange on each observer.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use dispatchChange instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyChange(bool selfChange) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Receives call backs for changes to content. Must be implemented by objects which are added to a ContentObservable. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/ContentObserver
		/// </java-name>
		[Dot42.DexImport("android/database/ContentObserver", AccessFlags = 1057)]
		public abstract partial class ContentObserver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a content observer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Handler;)V", AccessFlags = 1)]
				public ContentObserver(global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if this observer is interested receiving self-change notifications.</para> <para>Subclasses should override this method to indicate whether the observer is interested in receiving notifications for changes that it made to the content itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if self-change notifications should be delivered to the observer. </para>
				/// </returns>
				/// <java-name>
				/// deliverSelfNotifications
				/// </java-name>
				[Dot42.DexImport("deliverSelfNotifications", "()Z", AccessFlags = 1)]
				public virtual bool DeliverSelfNotifications() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method is called when a content change occurs. </para> <para>Subclasses should override this method to handle content changes. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onChange
				/// </java-name>
				[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 1)]
				public virtual void OnChange(bool selfChange) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatches a change notification to the observer. </para> <para>If a Handler was supplied to the ContentObserver constructor, then a call to the onChange method is posted to the handler's message queue. Otherwise, the onChange method is invoked immediately on this thread. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use dispatchChange(boolean, Uri) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dispatchChange
				/// </java-name>
				[Dot42.DexImport("dispatchChange", "(Z)V", AccessFlags = 17)]
				public void DispatchChange(bool selfChange) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Cursor wrapper that implements CrossProcessCursor. </para> <para>If the wrapped cursor implements CrossProcessCursor, then the wrapper delegates fillWindow, getWindow() and onMove to it. Otherwise, the wrapper provides default implementations of these methods that traverse the contents of the cursor similar to AbstractCursor#fillWindow. </para> <para>This wrapper can be used to adapt an ordinary Cursor into a CrossProcessCursor. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CrossProcessCursorWrapper
		/// </java-name>
		[Dot42.DexImport("android/database/CrossProcessCursorWrapper", AccessFlags = 33)]
		public partial class CrossProcessCursorWrapper : global::Android.Database.CursorWrapper, global::Android.Database.ICrossProcessCursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a cross process cursor wrapper. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CrossProcessCursorWrapper(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies cursor data into the window. </para> <para>Clears the window and fills it with data beginning at the requested row position until all of the data in the cursor is exhausted or the window runs out of space. </para> <para>The filled window uses the same row indices as the original cursor. For example, if you fill a window starting from row 5 from the cursor, you can query the contents of row 5 from the window just by asking it for row 5 because there is a direct correspondence between the row indices used by the cursor and the window. </para> <para>The current position of the cursor, as returned by getPosition, is not changed by this method. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1)]
				public virtual void FillWindow(int position, global::Android.Database.CursorWindow window) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function is called every time the cursor is successfully scrolled to a new position, giving the subclass a chance to update any state it may have. If it returns false the move function will also do so and the cursor will scroll to the beforeFirst position. </para> <para>This function should be called by methods such as moveToPosition(int), so it will typically not be called from outside of the cursor class itself. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the move is successful, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1)]
				public virtual bool OnMove(int oldPosition, int newPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CrossProcessCursorWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "move", "(I)Z", AccessFlags = 1025)]
				public override bool Move(int offset) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/database/Cursor", "moveToPosition", "(I)Z", AccessFlags = 1025)]
				public override bool MoveToPosition(int position) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("android/database/Cursor", "getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetColumnIndex(string columnName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetColumnIndexOrThrow(string columnName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetColumnName(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("android/database/Cursor", "getBlob", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public override byte[] GetBlob(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				[Dot42.DexImport("android/database/Cursor", "getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetString(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("android/database/Cursor", "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1025)]
				public override void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "getShort", "(I)S", AccessFlags = 1025)]
				public override short GetShort(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(short);
				}

				[Dot42.DexImport("android/database/Cursor", "getInt", "(I)I", AccessFlags = 1025)]
				public override int GetInt(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "getLong", "(I)J", AccessFlags = 1025)]
				public override long GetLong(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/database/Cursor", "getFloat", "(I)F", AccessFlags = 1025)]
				public override float GetFloat(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(float);
				}

				[Dot42.DexImport("android/database/Cursor", "getDouble", "(I)D", AccessFlags = 1025)]
				public override double GetDouble(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(double);
				}

				[Dot42.DexImport("android/database/Cursor", "getType", "(I)I", AccessFlags = 1025)]
				public override int GetType(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/database/Cursor", "isNull", "(I)Z", AccessFlags = 1025)]
				public override bool IsNull(int columnIndex) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				[Dot42.DexImport("android/database/Cursor", "registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				public override void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				public override void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				public override void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				public override void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1025)]
				public override void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/database/Cursor", "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				public override global::Android.OS.Bundle Respond(global::Android.OS.Bundle extras) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Returns a pre-filled window that contains the data within this cursor. </para> <para>In particular, the window contains the row indicated by Cursor#getPosition. The window's contents are automatically scrolled whenever the current row moved outside the range covered by the window. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The pre-filled window, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Database.CursorWindow Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1)]
						get{ return default(global::Android.Database.CursorWindow); }
				}

				public override int Count
				{
						[Dot42.DexImport("android/database/Cursor", "getCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public override int Position
				{
						[Dot42.DexImport("android/database/Cursor", "getPosition", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public override bool IsFirst
				{
						[Dot42.DexImport("android/database/Cursor", "isFirst", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override bool IsLast
				{
						[Dot42.DexImport("android/database/Cursor", "isLast", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override bool IsBeforeFirst
				{
						[Dot42.DexImport("android/database/Cursor", "isBeforeFirst", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override bool IsAfterLast
				{
						[Dot42.DexImport("android/database/Cursor", "isAfterLast", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override string[] ColumnNames
				{
						[Dot42.DexImport("android/database/Cursor", "getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string[]); }
				}

				public override int ColumnCount
				{
						[Dot42.DexImport("android/database/Cursor", "getColumnCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public override bool IsClosed
				{
						[Dot42.DexImport("android/database/Cursor", "isClosed", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override bool WantsAllOnMoveCalls
				{
						[Dot42.DexImport("android/database/Cursor", "getWantsAllOnMoveCalls", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public override global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("android/database/Cursor", "getExtras", "()Landroid/os/Bundle;", AccessFlags = 1025)]
						get{ return default(global::Android.OS.Bundle); }
				}

		}

		/// <summary>
		///  <para>An exception indicating that a cursor is out of bounds. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CursorIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("android/database/CursorIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class CursorIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public CursorIndexOutOfBoundsException(int index, int size) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorIndexOutOfBoundsException(string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorIndexOutOfBoundsException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Does a join on two cursors using the specified columns. The cursors must already be sorted on each of the specified columns in ascending order. This joiner only supports the case where the tuple of key column values is unique. </para> <para>Typical usage:</para> <para> <pre>
		/// CursorJoiner joiner = new CursorJoiner(cursorA, keyColumnsofA, cursorB, keyColumnsofB);
		/// for (CursorJointer.Result joinerResult : joiner) {
		///     switch (joinerResult) {
		///         case LEFT:
		///             // handle case where a row in cursorA is unique
		///             break;
		///         case RIGHT:
		///             // handle case where a row in cursorB is unique
		///             break;
		///         case BOTH:
		///             // handle case where a row with the same key is in both cursors
		///             break;
		///     }
		/// }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CursorJoiner
		/// </java-name>
		[Dot42.DexImport("android/database/CursorJoiner", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Landroid/database/CursorJoiner$Result;>;Lja" +
    "va/lang/Iterable<Landroid/database/CursorJoiner$Result;>;")]
		public sealed partial class CursorJoiner : global::Java.Util.IIterator<global::Android.Database.CursorJoiner.Result>, global::Java.Lang.IIterable<global::Android.Database.CursorJoiner.Result>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Initializes the CursorJoiner and resets the cursors to the first row. The left and right column name arrays must have the same number of columns. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang" +
    "/String;)V", AccessFlags = 1)]
				public CursorJoiner(global::Android.Database.ICursor cursorLeft, string[] columnNamesLeft, global::Android.Database.ICursor cursorRight, string[] columnNamesRight) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the comparison result of the next row from each cursor. If one cursor has no more rows but the other does then subsequent calls to this will indicate that the remaining rows are unique. </para> <para>The caller must check that hasNext() returns true before calling this. </para> <para>Once next() has been called the cursors specified in the result of the call to next() are guaranteed to point to the row that was indicated. Reading values from the cursor that was not indicated in the call to next() will result in undefined behavior. </para>        
				/// </summary>
				/// <returns>
				///  <para>LEFT, if the row pointed to by the left cursor is unique, RIGHT if the row pointed to by the right cursor is unique, BOTH if the rows in both cursors are the same. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Landroid/database/CursorJoiner$Result;", AccessFlags = 1)]
				public global::Android.Database.CursorJoiner.Result Next() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorJoiner.Result);
				}

				/// <summary>
				///  <para>Removes the last object returned by <c>next </c> from the collection. This method can only be called once between each call to <c>next </c> .</para> <para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns whether or not there are more rows to compare using next(). </para>        
				/// </summary>
				/// <returns>
				///  <para>true if there are more rows to compare </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				public bool HasNext
				{
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
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

		/// <summary>
		///  <para>A buffer containing multiple cursor rows. </para> <para>A CursorWindow is read-write when initially created and used locally. When sent to a remote process (by writing it to a Parcel), the remote process receives a read-only view of the cursor window. Typically the cursor window will be allocated by the producer, filled with data, and then sent to the consumer for reading. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CursorWindow
		/// </java-name>
		[Dot42.DexImport("android/database/CursorWindow", AccessFlags = 33)]
		public partial class CursorWindow : global::Android.Database.Sqlite.SQLiteClosable, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Database.CursorWindow> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorWindow(string source) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public CursorWindow(bool source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Clears out the existing contents of the window, making it safe to reuse for new data. </para> <para>The start position (getStartPosition()), number of rows (getNumRows()), and number of columns in the cursor are all reset to zero. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the number of columns in this window. </para> <para>This method must be called before any rows are added to the window, otherwise it will fail to set the number of columns if it differs from the current number of columns. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// setNumColumns
				/// </java-name>
				[Dot42.DexImport("setNumColumns", "(I)Z", AccessFlags = 1)]
				public virtual bool SetNumColumns(int columnNum) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Allocates a new row at the end of this cursor window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful, false if the cursor window is out of memory. </para>
				/// </returns>
				/// <java-name>
				/// allocRow
				/// </java-name>
				[Dot42.DexImport("allocRow", "()Z", AccessFlags = 1)]
				public virtual bool AllocRow() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Frees the last row in this cursor window. </para>        
				/// </summary>
				/// <java-name>
				/// freeLastRow
				/// </java-name>
				[Dot42.DexImport("freeLastRow", "()V", AccessFlags = 1)]
				public virtual void FreeLastRow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the field at the specified row and column index has type Cursor#FIELD_TYPE_NULL.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType(int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the field has type Cursor#FIELD_TYPE_NULL. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(II)Z", AccessFlags = 1)]
				public virtual bool IsNull(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the field at the specified row and column index has type Cursor#FIELD_TYPE_BLOB or Cursor#FIELD_TYPE_NULL.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType(int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the field has type Cursor#FIELD_TYPE_BLOB or Cursor#FIELD_TYPE_NULL. </para>
				/// </returns>
				/// <java-name>
				/// isBlob
				/// </java-name>
				[Dot42.DexImport("isBlob", "(II)Z", AccessFlags = 1)]
				public virtual bool IsBlob(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the field at the specified row and column index has type Cursor#FIELD_TYPE_INTEGER.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType(int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the field has type Cursor#FIELD_TYPE_INTEGER. </para>
				/// </returns>
				/// <java-name>
				/// isLong
				/// </java-name>
				[Dot42.DexImport("isLong", "(II)Z", AccessFlags = 1)]
				public virtual bool IsLong(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the field at the specified row and column index has type Cursor#FIELD_TYPE_FLOAT.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType(int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the field has type Cursor#FIELD_TYPE_FLOAT. </para>
				/// </returns>
				/// <java-name>
				/// isFloat
				/// </java-name>
				[Dot42.DexImport("isFloat", "(II)Z", AccessFlags = 1)]
				public virtual bool IsFloat(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the field at the specified row and column index has type Cursor#FIELD_TYPE_STRING or Cursor#FIELD_TYPE_NULL.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getType(int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the field has type Cursor#FIELD_TYPE_STRING or Cursor#FIELD_TYPE_NULL. </para>
				/// </returns>
				/// <java-name>
				/// isString
				/// </java-name>
				[Dot42.DexImport("isString", "(II)Z", AccessFlags = 1)]
				public virtual bool IsString(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the type of the field at the specified row and column index. </para> <para>The returned field types are:  <ul> <li> <para>Cursor#FIELD_TYPE_NULL </para></li> <li> <para>Cursor#FIELD_TYPE_INTEGER </para></li> <li> <para>Cursor#FIELD_TYPE_FLOAT </para></li> <li> <para>Cursor#FIELD_TYPE_STRING </para></li> <li> <para>Cursor#FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The field type. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(II)I", AccessFlags = 1)]
				public virtual int GetType(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a byte array. </para> <para>The result is determined as follows:  <ul> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the result is  <code>null</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then the result is the blob value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the result is the array of bytes that make up the internal representation of the string value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER or Cursor#FIELD_TYPE_FLOAT, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(II)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a byte array. </para> <para>The result is determined as follows:  <ul> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the result is  <code>null</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then the result is the blob value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the result is the array of bytes that make up the internal representation of the string value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER or Cursor#FIELD_TYPE_FLOAT, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(II)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a string. </para> <para>The result is determined as follows:  <ul> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the result is  <code>null</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the result is the string value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER, then the result is a string representation of the integer in decimal, obtained by formatting the value with the  <code>printf</code> family of functions using format specifier  <code>lld</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_FLOAT, then the result is a string representation of the floating-point value in decimal, obtained by formatting the value with the  <code>printf</code> family of functions using format specifier  <code>g</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a string. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Copies the text of the field at the specified row and column index into a CharArrayBuffer. </para> <para>The buffer is populated as follows:  <ul> <li> <para>If the buffer is too small for the value to be copied, then it is automatically resized. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the buffer is set to an empty string. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the buffer is set to the contents of the string. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER, then the buffer is set to a string representation of the integer in decimal, obtained by formatting the value with the  <code>printf</code> family of functions using format specifier  <code>lld</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_FLOAT, then the buffer is set to a string representation of the floating-point value in decimal, obtained by formatting the value with the  <code>printf</code> family of functions using format specifier  <code>g</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int row, int column, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a  <code>long</code>. </para> <para>The result is determined as follows:  <ul> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the result is  <code>0L</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the result is the value obtained by parsing the string value with  <code>strtoll</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER, then the result is the  <code>long</code> value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_FLOAT, then the result is the floating-point value converted to a  <code>long</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a  <code>long</code>. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(II)J", AccessFlags = 1)]
				public virtual long GetLong(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a  <code>double</code>. </para> <para>The result is determined as follows:  <ul> <li> <para>If the field is of type Cursor#FIELD_TYPE_NULL, then the result is  <code>0.0</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_STRING, then the result is the value obtained by parsing the string value with  <code>strtod</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_INTEGER, then the result is the integer value converted to a  <code>double</code>. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_FLOAT, then the result is the  <code>double</code> value. </para></li> <li> <para>If the field is of type Cursor#FIELD_TYPE_BLOB, then a SQLiteException is thrown. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a  <code>double</code>. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(II)D", AccessFlags = 1)]
				public virtual double GetDouble(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a  <code>short</code>. </para> <para>The result is determined by invoking getLong and converting the result to  <code>short</code>. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as a  <code>short</code>. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(II)S", AccessFlags = 1)]
				public virtual short GetShort(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as an  <code>int</code>. </para> <para>The result is determined by invoking getLong and converting the result to  <code>int</code>. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as an  <code>int</code>. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(II)I", AccessFlags = 1)]
				public virtual int GetInt(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the value of the field at the specified row and column index as a  <code>float</code>. </para> <para>The result is determined by invoking getDouble and converting the result to  <code>float</code>. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the field as an  <code>float</code>. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(II)F", AccessFlags = 1)]
				public virtual float GetFloat(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Copies a byte array into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putBlob
				/// </java-name>
				[Dot42.DexImport("putBlob", "([BII)Z", AccessFlags = 1)]
				public virtual bool PutBlob(sbyte[] value, int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Copies a byte array into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putBlob
				/// </java-name>
				[Dot42.DexImport("putBlob", "([BII)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool PutBlob(byte[] value, int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Copies a string into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;II)Z", AccessFlags = 1)]
				public virtual bool PutString(string value, int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Puts a long integer into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(JII)Z", AccessFlags = 1)]
				public virtual bool PutLong(long value, int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Puts a double-precision floating point value into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(DII)Z", AccessFlags = 1)]
				public virtual bool PutDouble(double value, int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Puts a null value into the field at the specified row and column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if successful. </para>
				/// </returns>
				/// <java-name>
				/// putNull
				/// </java-name>
				[Dot42.DexImport("putNull", "(II)Z", AccessFlags = 1)]
				public virtual bool PutNull(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newFromParcel
				/// </java-name>
				[Dot42.DexImport("newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;", AccessFlags = 9)]
				public static global::Android.Database.CursorWindow NewFromParcel(global::Android.OS.Parcel p) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.CursorWindow);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Gets the start position of this cursor window. </para> <para>The start position is the zero-based index of the first row that this window contains relative to the entire result set of the Cursor. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The zero-based start position. </para>
				/// </returns>
				/// <java-name>
				/// getStartPosition
				/// </java-name>
				public virtual int StartPosition
				{
						[Dot42.DexImport("getStartPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStartPosition", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the number of rows in this window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of rows in this cursor window. </para>
				/// </returns>
				/// <java-name>
				/// getNumRows
				/// </java-name>
				public virtual int NumRows
				{
						[Dot42.DexImport("getNumRows", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Wrapper class for Cursor that delegates all calls to the actual cursor object. The primary use for this class is to extend a cursor while overriding only a subset of its methods. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CursorWrapper
		/// </java-name>
		[Dot42.DexImport("android/database/CursorWrapper", AccessFlags = 33)]
		public partial class CursorWrapper : global::Android.Database.ICursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a cursor wrapper. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CursorWrapper(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the cursor to the first row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1)]
				public virtual bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para> <para> <para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or throws IllegalArgumentException if the column doesn't exist. If you're not sure if a column will exist or not use getColumnIndex(String) and check for -1, which is more efficient than catching the exceptions.</para> <para> <para>getColumnIndex(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the column name at the given zero-based column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column name for the given column index. </para>
				/// </returns>
				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public virtual double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public virtual float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public virtual int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public virtual long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public virtual short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public virtual bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the last row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1)]
				public virtual bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor by a relative amount, forward or backward, from the current position. Positive offsets move forwards, negative offsets move backwards. If the final position is outside of the bounds of the result set then the resultant position will be pinned to -1 or count() depending on whether the value is off the front or end of the set, respectively.</para> <para>This method will return true if the requested destination was reachable, otherwise, it returns false. For example, if the cursor is at currently on the second entry in the result set and move(-5) is called, the position will be pinned at -1, and false will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1)]
				public virtual bool Move(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to an absolute position. The valid range of values is -1 &lt;= position &lt;= count.</para> <para>This method will return true if the request destination was reachable, otherwise, it returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1)]
				public virtual bool MoveToPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the next row.</para> <para>This method will return false if the cursor is already past the last entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1)]
				public virtual bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the previous row.</para> <para>This method will return false if the cursor is already before the first entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1)]
				public virtual bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para> <para> <para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para> <para> <para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para> <para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This is an out-of-band way for the the user of a cursor to communicate with the cursor. The structure of each bundle is entirely defined by the cursor.</para> <para>One use of this is to tell a cursor that it should retry its network request after it reported an error. </para>        
				/// </summary>
				/// <returns>
				///  <para>extra values, or Bundle.EMPTY. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle Respond(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Register to watch a content URI for changes. This can be the URI of a specific data row (for example, "content://my_provider_type/23"), or a a generic URI for a content type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the underlying cursor that is wrapped by this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The wrapped cursor. </para>
				/// </returns>
				/// <java-name>
				/// getWrappedCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor WrappedCursor
				{
						[Dot42.DexImport("getWrappedCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

				/// <summary>
				///  <para>return true if the cursor is closed </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the cursor is closed. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				///  <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public virtual int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public virtual string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para> <para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				///  <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public virtual bool WantsAllOnMoveCalls
				{
						[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position after the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is after the last result. </para>
				/// </returns>
				/// <java-name>
				/// isAfterLast
				/// </java-name>
				public virtual bool IsAfterLast
				{
						[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position before the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is before the first result. </para>
				/// </returns>
				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				public virtual bool IsBeforeFirst
				{
						[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the first entry. </para>
				/// </returns>
				/// <java-name>
				/// isFirst
				/// </java-name>
				public virtual bool IsFirst
				{
						[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the last entry. </para>
				/// </returns>
				/// <java-name>
				/// isLast
				/// </java-name>
				public virtual bool IsLast
				{
						[Dot42.DexImport("isLast", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				public virtual int Position
				{
						[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Static utility methods for dealing with databases and Cursors. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/DatabaseUtils
		/// </java-name>
		[Dot42.DexImport("android/database/DatabaseUtils", AccessFlags = 33)]
		public partial class DatabaseUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_SELECT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_SELECT", "I", AccessFlags = 25)]
				public const int STATEMENT_SELECT = 1;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_UPDATE
				/// </java-name>
				[Dot42.DexImport("STATEMENT_UPDATE", "I", AccessFlags = 25)]
				public const int STATEMENT_UPDATE = 2;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_ATTACH
				/// </java-name>
				[Dot42.DexImport("STATEMENT_ATTACH", "I", AccessFlags = 25)]
				public const int STATEMENT_ATTACH = 3;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_BEGIN
				/// </java-name>
				[Dot42.DexImport("STATEMENT_BEGIN", "I", AccessFlags = 25)]
				public const int STATEMENT_BEGIN = 4;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_COMMIT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_COMMIT", "I", AccessFlags = 25)]
				public const int STATEMENT_COMMIT = 5;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_ABORT
				/// </java-name>
				[Dot42.DexImport("STATEMENT_ABORT", "I", AccessFlags = 25)]
				public const int STATEMENT_ABORT = 6;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_PRAGMA
				/// </java-name>
				[Dot42.DexImport("STATEMENT_PRAGMA", "I", AccessFlags = 25)]
				public const int STATEMENT_PRAGMA = 7;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_DDL
				/// </java-name>
				[Dot42.DexImport("STATEMENT_DDL", "I", AccessFlags = 25)]
				public const int STATEMENT_DDL = 8;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_UNPREPARED
				/// </java-name>
				[Dot42.DexImport("STATEMENT_UNPREPARED", "I", AccessFlags = 25)]
				public const int STATEMENT_UNPREPARED = 9;
				/// <summary>
				///  <para>One of the values returned by getSqlStatementType(String). </para>        
				/// </summary>
				/// <java-name>
				/// STATEMENT_OTHER
				/// </java-name>
				[Dot42.DexImport("STATEMENT_OTHER", "I", AccessFlags = 25)]
				public const int STATEMENT_OTHER = 99;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DatabaseUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Special function for writing an exception result at the header of a parcel, to be used when returning an exception from a transaction. exception will be re-thrown by the function in another process  <para>Parcel::writeNoException </para> <para>Parcel::writeException </para></para>        
				/// </summary>
				/// <java-name>
				/// writeExceptionToParcel
				/// </java-name>
				[Dot42.DexImport("writeExceptionToParcel", "(Landroid/os/Parcel;Ljava/lang/Exception;)V", AccessFlags = 25)]
				public static void WriteExceptionToParcel(global::Android.OS.Parcel reply, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Special function for reading an exception result from the header of a parcel, to be used after receiving the result of a transaction. This will throw the exception for you if it had been written to the Parcel, otherwise return and let you read the normal result data from the Parcel.  <para>Parcel::writeNoException </para> <para>Parcel::readException </para></para>        
				/// </summary>
				/// <java-name>
				/// readExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 25)]
				public static void ReadExceptionFromParcel(global::Android.OS.Parcel reply) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readExceptionWithFileNotFoundExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionWithFileNotFoundExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void ReadExceptionWithFileNotFoundExceptionFromParcel(global::Android.OS.Parcel reply) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readExceptionWithOperationApplicationExceptionFromParcel
				/// </java-name>
				[Dot42.DexImport("readExceptionWithOperationApplicationExceptionFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void ReadExceptionWithOperationApplicationExceptionFromParcel(global::Android.OS.Parcel reply) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Binds the given Object to the given SQLiteProgram using the proper typing. For example, bind numbers as longs/doubles, and everything else as a string by call toString() on it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindObjectToProgram
				/// </java-name>
				[Dot42.DexImport("bindObjectToProgram", "(Landroid/database/sqlite/SQLiteProgram;ILjava/lang/Object;)V", AccessFlags = 9)]
				public static void BindObjectToProgram(global::Android.Database.Sqlite.SQLiteProgram prog, int index, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Appends an SQL string to the given StringBuilder, including the opening and closing single quotes. Any single quotes internal to sqlString will be escaped.</para> <para>This method is deprecated because we want to encourage everyone to use the "?" binding form. However, when implementing a ContentProvider, one may want to add WHERE clauses that were not provided by the caller. Since "?" is a positional form, using it in this case could break the caller because the indexes would be shifted to accomodate the ContentProvider's internal bindings. In that case, it may be necessary to construct a WHERE clause manually. This method is useful for those cases.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// appendEscapedSQLString
				/// </java-name>
				[Dot42.DexImport("appendEscapedSQLString", "(Ljava/lang/StringBuilder;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void AppendEscapedSQLString(global::System.Text.StringBuilder sb, string sqlString) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>SQL-escape a string. </para>        
				/// </summary>
				/// <java-name>
				/// sqlEscapeString
				/// </java-name>
				[Dot42.DexImport("sqlEscapeString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string SqlEscapeString(string value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Appends an Object to an SQL string with the proper escaping, etc. </para>        
				/// </summary>
				/// <java-name>
				/// appendValueToSql
				/// </java-name>
				[Dot42.DexImport("appendValueToSql", "(Ljava/lang/StringBuilder;Ljava/lang/Object;)V", AccessFlags = 25)]
				public static void AppendValueToSql(global::System.Text.StringBuilder sql, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Concatenates two SQL WHERE clauses, handling empty or null values. </para>        
				/// </summary>
				/// <java-name>
				/// concatenateWhere
				/// </java-name>
				[Dot42.DexImport("concatenateWhere", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ConcatenateWhere(string a, string b) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>return the collation key </para>        
				/// </summary>
				/// <returns>
				///  <para>the collation key </para>
				/// </returns>
				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCollationKey(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>return the collation key in hex format </para>        
				/// </summary>
				/// <returns>
				///  <para>the collation key in hex format </para>
				/// </returns>
				/// <java-name>
				/// getHexCollationKey
				/// </java-name>
				[Dot42.DexImport("getHexCollationKey", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetHexCollationKey(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor to System.out. The position is restored after printing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor to a PrintSteam. The position is restored after printing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor, global::Java.IO.PrintStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor to a PrintSteam. The position is restored after printing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCursor
				/// </java-name>
				[Dot42.DexImport("dumpCursor", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V", AccessFlags = 9)]
				public static void DumpCursor(global::Android.Database.ICursor cursor, global::System.Text.StringBuilder stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor to a String. The position is restored after printing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String that contains the dumped cursor </para>
				/// </returns>
				/// <java-name>
				/// dumpCursorToString
				/// </java-name>
				[Dot42.DexImport("dumpCursorToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DumpCursorToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor's current row to System.out.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor's current row to a PrintSteam.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor, global::Java.IO.PrintStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the contents of a Cursor's current row to a PrintSteam.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dumpCurrentRow
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRow", "(Landroid/database/Cursor;Ljava/lang/StringBuilder;)V", AccessFlags = 9)]
				public static void DumpCurrentRow(global::Android.Database.ICursor cursor, global::System.Text.StringBuilder stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dump the contents of a Cursor's current row to a String.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String that contains the dumped cursor row </para>
				/// </returns>
				/// <java-name>
				/// dumpCurrentRowToString
				/// </java-name>
				[Dot42.DexImport("dumpCurrentRowToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 9)]
				public static string DumpCurrentRowToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a String out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorStringToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorStringToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a String out of a field in a Cursor and writes it to an InsertHelper.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorStringToInsertHelper
				/// </java-name>
				[Dot42.DexImport("cursorStringToInsertHelper", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/database/DatabaseUtils$Inser" +
    "tHelper;I)V", AccessFlags = 9)]
				public static void CursorStringToInsertHelper(global::Android.Database.ICursor cursor, string field, global::Android.Database.DatabaseUtils.InsertHelper inserter, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a String out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorStringToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorStringToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values, string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads an Integer out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorIntToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorIntToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Integer out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorIntToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorIntToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values, string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Long out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorLongToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorLongToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Long out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorLongToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorLongToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values, string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Double out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorDoubleToCursorValues
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToCursorValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorDoubleToCursorValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Double out of a field in a Cursor and writes it to a Map.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorDoubleToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToContentValues", "(Landroid/database/Cursor;Ljava/lang/String;Landroid/content/ContentValues;Ljava/" +
    "lang/String;)V", AccessFlags = 9)]
				public static void CursorDoubleToContentValues(global::Android.Database.ICursor cursor, string field, global::Android.Content.ContentValues values, string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read the entire contents of a cursor row and store them in a ContentValues.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorRowToContentValues
				/// </java-name>
				[Dot42.DexImport("cursorRowToContentValues", "(Landroid/database/Cursor;Landroid/content/ContentValues;)V", AccessFlags = 9)]
				public static void CursorRowToContentValues(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Query the table for the number of rows in the table. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the table </para>
				/// </returns>
				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase db, string table) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Query the table for the number of rows in the table. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the table filtered by the selection </para>
				/// </returns>
				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase db, string table, string selection) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Query the table for the number of rows in the table. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the table filtered by the selection </para>
				/// </returns>
				/// <java-name>
				/// queryNumEntries
				/// </java-name>
				[Dot42.DexImport("queryNumEntries", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;[Lja" +
    "va/lang/String;)J", AccessFlags = 9)]
				public static long QueryNumEntries(global::Android.Database.Sqlite.SQLiteDatabase db, string table, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Utility method to run the query on the db and return the value in the first column of the first row. </para>        
				/// </summary>
				/// <java-name>
				/// longForQuery
				/// </java-name>
				[Dot42.DexImport("longForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)J", AccessFlags = 9)]
				public static long LongForQuery(global::Android.Database.Sqlite.SQLiteDatabase db, string query, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Utility method to run the pre-compiled query and return the value in the first column of the first row. </para>        
				/// </summary>
				/// <java-name>
				/// longForQuery
				/// </java-name>
				[Dot42.DexImport("longForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)J", AccessFlags = 9)]
				public static long LongForQuery(global::Android.Database.Sqlite.SQLiteStatement prog, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Utility method to run the query on the db and return the value in the first column of the first row. </para>        
				/// </summary>
				/// <java-name>
				/// stringForQuery
				/// </java-name>
				[Dot42.DexImport("stringForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)Lj" +
    "ava/lang/String;", AccessFlags = 9)]
				public static string StringForQuery(global::Android.Database.Sqlite.SQLiteDatabase db, string query, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Utility method to run the pre-compiled query and return the value in the first column of the first row. </para>        
				/// </summary>
				/// <java-name>
				/// stringForQuery
				/// </java-name>
				[Dot42.DexImport("stringForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StringForQuery(global::Android.Database.Sqlite.SQLiteStatement prog, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Utility method to run the query on the db and return the blob value in the first column of the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A read-only file descriptor for a copy of the blob value. </para>
				/// </returns>
				/// <java-name>
				/// blobFileDescriptorForQuery
				/// </java-name>
				[Dot42.DexImport("blobFileDescriptorForQuery", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;[Ljava/lang/String;)La" +
    "ndroid/os/ParcelFileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor BlobFileDescriptorForQuery(global::Android.Database.Sqlite.SQLiteDatabase db, string query, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Utility method to run the pre-compiled query and return the blob value in the first column of the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A read-only file descriptor for a copy of the blob value. </para>
				/// </returns>
				/// <java-name>
				/// blobFileDescriptorForQuery
				/// </java-name>
				[Dot42.DexImport("blobFileDescriptorForQuery", "(Landroid/database/sqlite/SQLiteStatement;[Ljava/lang/String;)Landroid/os/ParcelF" +
    "ileDescriptor;", AccessFlags = 9)]
				public static global::Android.OS.ParcelFileDescriptor BlobFileDescriptorForQuery(global::Android.Database.Sqlite.SQLiteStatement prog, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Reads a String out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorStringToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorStringToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorStringToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Long out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorLongToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorLongToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorLongToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Short out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorShortToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorShortToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorShortToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Integer out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorIntToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorIntToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorIntToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Float out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorFloatToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorFloatToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorFloatToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a Double out of a column in a Cursor and writes it to a ContentValues. Adds nothing to the ContentValues if the column isn't present or if its value is null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cursorDoubleToContentValuesIfPresent
				/// </java-name>
				[Dot42.DexImport("cursorDoubleToContentValuesIfPresent", "(Landroid/database/Cursor;Landroid/content/ContentValues;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CursorDoubleToContentValuesIfPresent(global::Android.Database.ICursor cursor, global::Android.Content.ContentValues values, string column) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a db and populates it with the sql statements in sqlStatements.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createDbFromSqlStatements
				/// </java-name>
				[Dot42.DexImport("createDbFromSqlStatements", "(Landroid/content/Context;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 9)]
				public static void CreateDbFromSqlStatements(global::Android.Content.Context context, string dbName, int dbVersion, string sqlStatements) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns one of the following which represent the type of the given SQL statement.  <ol> <li> <para>STATEMENT_SELECT </para></li> <li> <para>STATEMENT_UPDATE </para></li> <li> <para>STATEMENT_ATTACH </para></li> <li> <para>STATEMENT_BEGIN </para></li> <li> <para>STATEMENT_COMMIT </para></li> <li> <para>STATEMENT_ABORT </para></li> <li> <para>STATEMENT_OTHER </para></li></ol></para>        
				/// </summary>
				/// <returns>
				///  <para>one of the values listed above </para>
				/// </returns>
				/// <java-name>
				/// getSqlStatementType
				/// </java-name>
				[Dot42.DexImport("getSqlStatementType", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetSqlStatementType(string sql) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Appends one set of selection args to another. This is useful when adding a selection argument to a user provided set. </para>        
				/// </summary>
				/// <java-name>
				/// appendSelectionArgs
				/// </java-name>
				[Dot42.DexImport("appendSelectionArgs", "([Ljava/lang/String;[Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] AppendSelectionArgs(string[] originalValues, string[] newValues) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>This class allows users to do multiple inserts into a table using the same statement. </para> <para>This class is not thread-safe. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use SQLiteStatement instead. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/database/DatabaseUtils$InsertHelper
				/// </java-name>
				[Dot42.DexImport("android/database/DatabaseUtils$InsertHelper", AccessFlags = 9)]
				public partial class InsertHelper
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This field was accidentally exposed in earlier versions of the platform so we can hide it but we can't remove it.</para>        
						/// </summary>
						/// <java-name>
						/// TABLE_INFO_PRAGMA_DEFAULT_INDEX
						/// </java-name>
						[Dot42.DexImport("TABLE_INFO_PRAGMA_DEFAULT_INDEX", "I", AccessFlags = 25)]
						public const int TABLE_INFO_PRAGMA_DEFAULT_INDEX = 4;
						[Dot42.DexImport("<init>", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)V", AccessFlags = 1)]
						public InsertHelper(global::Android.Database.Sqlite.SQLiteDatabase sQLiteDatabase, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Returns the index of the specified column. This is index is suitagble for use in calls to bind(). </para>        
						/// </summary>
						/// <returns>
						///  <para>the index of the column </para>
						/// </returns>
						/// <java-name>
						/// getColumnIndex
						/// </java-name>
						[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
						public virtual int GetColumnIndex(string key) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(ID)V", AccessFlags = 1)]
						public virtual void Bind(int index, double value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IF)V", AccessFlags = 1)]
						public virtual void Bind(int index, float value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IJ)V", AccessFlags = 1)]
						public virtual void Bind(int index, long value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(II)V", AccessFlags = 1)]
						public virtual void Bind(int index, int value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(IZ)V", AccessFlags = 1)]
						public virtual void Bind(int index, bool value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind null to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bindNull
						/// </java-name>
						[Dot42.DexImport("bindNull", "(I)V", AccessFlags = 1)]
						public virtual void BindNull(int index) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(I[B)V", AccessFlags = 1)]
						public virtual void Bind(int index, sbyte[] value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public virtual void Bind(int index, byte[] value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Bind the value to an index. A prepareForInsert() or prepareForReplace() without a matching execute() must have already have been called. </para>        
						/// </summary>
						/// <java-name>
						/// bind
						/// </java-name>
						[Dot42.DexImport("bind", "(ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void Bind(int index, string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Performs an insert, adding a new row with the given values. If the table contains conflicting rows, an error is returned.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
						/// </returns>
						/// <java-name>
						/// insert
						/// </java-name>
						[Dot42.DexImport("insert", "(Landroid/content/ContentValues;)J", AccessFlags = 1)]
						public virtual long Insert(global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Execute the previously prepared insert or replace using the bound values since the last call to prepareForInsert or prepareForReplace.</para> <para>Note that calling bind() and then execute() is not thread-safe. The only thread-safe way to use this class is to call insert() or replace().</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
						/// </returns>
						/// <java-name>
						/// execute
						/// </java-name>
						[Dot42.DexImport("execute", "()J", AccessFlags = 1)]
						public virtual long Execute() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Prepare the InsertHelper for an insert. The pattern for this is:  <ul> <li> <para>prepareForInsert() </para></li> <li> <para>bind(index, value); </para></li> <li> <para>bind(index, value); </para></li> <li> <para>... </para></li> <li> <para>bind(index, value); </para></li> <li> <para>execute(); </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// prepareForInsert
						/// </java-name>
						[Dot42.DexImport("prepareForInsert", "()V", AccessFlags = 1)]
						public virtual void PrepareForInsert() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Prepare the InsertHelper for a replace. The pattern for this is:  <ul> <li> <para>prepareForReplace() </para></li> <li> <para>bind(index, value); </para></li> <li> <para>bind(index, value); </para></li> <li> <para>... </para></li> <li> <para>bind(index, value); </para></li> <li> <para>execute(); </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// prepareForReplace
						/// </java-name>
						[Dot42.DexImport("prepareForReplace", "()V", AccessFlags = 1)]
						public virtual void PrepareForReplace() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Performs an insert, adding a new row with the given values. If the table contains conflicting rows, they are deleted and replaced with the new row.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the row ID of the newly inserted row, or -1 if an error occurred </para>
						/// </returns>
						/// <java-name>
						/// replace
						/// </java-name>
						[Dot42.DexImport("replace", "(Landroid/content/ContentValues;)J", AccessFlags = 1)]
						public virtual long Replace(global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						///  <para>Close this object and release any resources associated with it. The behavior of calling  <code>insert()</code> after calling this method is undefined. </para>        
						/// </summary>
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

		/// <summary>
		///  <para>A specialization of Observable for DataSetObserver that provides methods for sending notifications to a list of DataSetObserver objects. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Invokes DataSetObserver#onChanged on each observer. Called when the contents of the data set have changed. The recipient will obtain the new contents the next time it queries the data set. </para>        
				/// </summary>
				/// <java-name>
				/// notifyChanged
				/// </java-name>
				[Dot42.DexImport("notifyChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invokes DataSetObserver#onInvalidated on each observer. Called when the data set is no longer valid and cannot be queried again, such as when the data set has been closed. </para>        
				/// </summary>
				/// <java-name>
				/// notifyInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyInvalidated() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Receives call backs when a data set has been changed, or made invalid. The typically data sets that are observed are Cursors or android.widget.Adapters. DataSetObserver must be implemented by objects which are added to a DataSetObservable. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>This method is called when the entire data set has changed, most likely through a call to Cursor#requery() on a Cursor. </para>        
				/// </summary>
				/// <java-name>
				/// onChanged
				/// </java-name>
				[Dot42.DexImport("onChanged", "()V", AccessFlags = 1)]
				public virtual void OnChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the entire data becomes invalid, most likely through a call to Cursor#deactivate() or Cursor#close() on a Cursor. </para>        
				/// </summary>
				/// <java-name>
				/// onInvalidated
				/// </java-name>
				[Dot42.DexImport("onInvalidated", "()V", AccessFlags = 1)]
				public virtual void OnInvalidated() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Default class used to define the actions to take when the database corruption is reported by sqlite. </para> <para>An application can specify an implementation of DatabaseErrorHandler on the following:  <ul> <li> <para>android.database.sqlite.SQLiteDatabase.CursorFactory, DatabaseErrorHandler) </para></li> <li> <para>android.database.sqlite.SQLiteDatabase.CursorFactory, int, DatabaseErrorHandler) </para></li></ul>The specified DatabaseErrorHandler is used to handle database corruption errors, if they occur. </para> <para>If null is specified for DatabaeErrorHandler param in the above calls, then this class is used as the default DatabaseErrorHandler. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>defines the default method to be invoked when database corruption is detected. </para>        
				/// </summary>
				/// <java-name>
				/// onCorruption
				/// </java-name>
				[Dot42.DexImport("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1)]
				public void OnCorruption(global::Android.Database.Sqlite.SQLiteDatabase dbObj) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A cross process cursor is an extension of a Cursor that also supports usage from remote processes. </para> <para>The contents of a cross process cursor are marshalled to the remote process by filling CursorWindow objects using fillWindow. As an optimization, the cursor can provide a pre-filled window to use via getWindow thereby obviating the need to copy the data to yet another cursor window. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/CrossProcessCursor
		/// </java-name>
		[Dot42.DexImport("android/database/CrossProcessCursor", AccessFlags = 1537)]
		public partial interface ICrossProcessCursor : global::Android.Database.ICursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Copies cursor data into the window. </para> <para>Clears the window and fills it with data beginning at the requested row position until all of the data in the cursor is exhausted or the window runs out of space. </para> <para>The filled window uses the same row indices as the original cursor. For example, if you fill a window starting from row 5 from the cursor, you can query the contents of row 5 from the window just by asking it for row 5 because there is a direct correspondence between the row indices used by the cursor and the window. </para> <para>The current position of the cursor, as returned by getPosition, is not changed by this method. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fillWindow
				/// </java-name>
				[Dot42.DexImport("fillWindow", "(ILandroid/database/CursorWindow;)V", AccessFlags = 1025)]
				void FillWindow(int position, global::Android.Database.CursorWindow window) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This function is called every time the cursor is successfully scrolled to a new position, giving the subclass a chance to update any state it may have. If it returns false the move function will also do so and the cursor will scroll to the beforeFirst position. </para> <para>This function should be called by methods such as moveToPosition(int), so it will typically not be called from outside of the cursor class itself. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the move is successful, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onMove
				/// </java-name>
				[Dot42.DexImport("onMove", "(II)Z", AccessFlags = 1025)]
				bool OnMove(int oldPosition, int newPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a pre-filled window that contains the data within this cursor. </para> <para>In particular, the window contains the row indicated by Cursor#getPosition. The window's contents are automatically scrolled whenever the current row moved outside the range covered by the window. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The pre-filled window, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				global::Android.Database.CursorWindow Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/database/CursorWindow;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface provides random read-write access to the result set returned by a database query. </para> <para>Cursor implementations are not required to be synchronized so code using a Cursor from multiple threads should perform its own synchronization when using the Cursor. </para> <para>Implementations should subclass AbstractCursor. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/Cursor
		/// </java-name>
		[Dot42.DexImport("android/database/Cursor", AccessFlags = 1537)]
		public partial interface ICursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Move the cursor by a relative amount, forward or backward, from the current position. Positive offsets move forwards, negative offsets move backwards. If the final position is outside of the bounds of the result set then the resultant position will be pinned to -1 or count() depending on whether the value is off the front or end of the set, respectively.</para> <para>This method will return true if the requested destination was reachable, otherwise, it returns false. For example, if the cursor is at currently on the second entry in the result set and move(-5) is called, the position will be pinned at -1, and false will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1025)]
				bool Move(int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Move the cursor to an absolute position. The valid range of values is -1 &lt;= position &lt;= count.</para> <para>This method will return true if the request destination was reachable, otherwise, it returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1025)]
				bool MoveToPosition(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Move the cursor to the first row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1025)]
				bool MoveToFirst() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Move the cursor to the last row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1025)]
				bool MoveToLast() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Move the cursor to the next row.</para> <para>This method will return false if the cursor is already past the last entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1025)]
				bool MoveToNext() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Move the cursor to the previous row.</para> <para>This method will return false if the cursor is already before the first entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1025)]
				bool MoveToPrevious() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para> <para> <para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetColumnIndex(string columnName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or throws IllegalArgumentException if the column doesn't exist. If you're not sure if a column will exist or not use getColumnIndex(String) and check for -1, which is more efficient than catching the exceptions.</para> <para> <para>getColumnIndex(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetColumnIndexOrThrow(string columnName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the column name at the given zero-based column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column name for the given column index. </para>
				/// </returns>
				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetColumnName(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1025)]
				void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				short GetShort(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				int GetInt(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				long GetLong(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				float GetFloat(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				double GetDouble(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1025)]
				int GetType(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1025)]
				bool IsNull(int columnIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1025)]
				void Deactivate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para> <para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1025)]
				bool Requery() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para> <para> <para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1025)]
				void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para> <para> <para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register to watch a content URI for changes. This can be the URI of a specific data row (for example, "content://my_provider_type/23"), or a a generic URI for a content type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1025)]
				void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This is an out-of-band way for the the user of a cursor to communicate with the cursor. The structure of each bundle is entirely defined by the cursor.</para> <para>One use of this is to tell a cursor that it should retry its network request after it reported an error. </para>        
				/// </summary>
				/// <returns>
				///  <para>extra values, or Bundle.EMPTY. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1025)]
				global::Android.OS.Bundle Respond(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				int Position
				{
						[Dot42.DexImport("getPosition", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the first entry. </para>
				/// </returns>
				/// <java-name>
				/// isFirst
				/// </java-name>
				bool IsFirst
				{
						[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the last entry. </para>
				/// </returns>
				/// <java-name>
				/// isLast
				/// </java-name>
				bool IsLast
				{
						[Dot42.DexImport("isLast", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position before the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is before the first result. </para>
				/// </returns>
				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				bool IsBeforeFirst
				{
						[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position after the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is after the last result. </para>
				/// </returns>
				/// <java-name>
				/// isAfterLast
				/// </java-name>
				bool IsAfterLast
				{
						[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				///  <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>return true if the cursor is closed </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the cursor is closed. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				bool WantsAllOnMoveCalls
				{
						[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para> <para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				///  <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface provides random read-write access to the result set returned by a database query. </para> <para>Cursor implementations are not required to be synchronized so code using a Cursor from multiple threads should perform its own synchronization when using the Cursor. </para> <para>Implementations should subclass AbstractCursor. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/Cursor
		/// </java-name>
		[Dot42.DexImport("android/database/Cursor", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICursorConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Value returned by getType(int) if the specified column is null </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_NULL", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_NULL = 0;
				/// <summary>
				///  <para>Value returned by getType(int) if the specified column type is integer </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_TYPE_INTEGER
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_INTEGER", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_INTEGER = 1;
				/// <summary>
				///  <para>Value returned by getType(int) if the specified column type is float </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_TYPE_FLOAT
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_FLOAT", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_FLOAT = 2;
				/// <summary>
				///  <para>Value returned by getType(int) if the specified column type is string </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_TYPE_STRING
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_STRING", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_STRING = 3;
				/// <summary>
				///  <para>Value returned by getType(int) if the specified column type is blob </para>        
				/// </summary>
				/// <java-name>
				/// FIELD_TYPE_BLOB
				/// </java-name>
				[Dot42.DexImport("FIELD_TYPE_BLOB", "I", AccessFlags = 25)]
				public const int FIELD_TYPE_BLOB = 4;
		}

		/// <summary>
		///  <para>An interface to let the apps define the actions to take when the following errors are detected database corruption </para>    
		/// </summary>
		/// <java-name>
		/// android/database/DatabaseErrorHandler
		/// </java-name>
		[Dot42.DexImport("android/database/DatabaseErrorHandler", AccessFlags = 1537)]
		public partial interface IDatabaseErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>defines the method to be invoked when database corruption is detected. </para>        
				/// </summary>
				/// <java-name>
				/// onCorruption
				/// </java-name>
				[Dot42.DexImport("onCorruption", "(Landroid/database/sqlite/SQLiteDatabase;)V", AccessFlags = 1025)]
				void OnCorruption(global::Android.Database.Sqlite.SQLiteDatabase dbObj) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A mutable cursor implementation backed by an array of <c>Object </c> s. Use newRow() to add rows. Automatically expands internal capacity as needed. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/MatrixCursor
		/// </java-name>
		[Dot42.DexImport("android/database/MatrixCursor", AccessFlags = 33)]
		public partial class MatrixCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new cursor with the given initial capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;I)V", AccessFlags = 1)]
				public MatrixCursor(string[] columnNames, int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new cursor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public MatrixCursor(string[] columnNames) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a new row to the end and returns a builder for that row. Not safe for concurrent use.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>builder which can be used to set the column values for the new row </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MatrixCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public override string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>Builds a row of values using either of these approaches:  <ul> <li> <para>Values can be added with explicit column ordering using add(Object), which starts from the left-most column and adds one column value at a time. This follows the same ordering as the column names specified at cursor construction time. </para></li> <li> <para>Column and value pairs can be offered for possible inclusion using add(String, Object). If the cursor includes the given column, the value will be set for that column, otherwise the value is ignored. This approach is useful when matching data to a custom projection. </para></li></ul>Undefined values are left as <c>null </c> . </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Sets the next column value in this row.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder to support chaining </para>
						/// </returns>
						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;", AccessFlags = 1)]
						public virtual RowBuilder Add(object columnValue) /* MethodBuilder.Create */ 
						{
								return default(RowBuilder);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal RowBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A convience class that lets you present an array of Cursors as a single linear Cursor. The schema of the cursors presented is entirely up to the creator of the MergeCursor, and may be different if that is desired. Calls to getColumns, getColumnIndex, etc will return the value for the row that the MergeCursor is currently pointing at. </para>    
		/// </summary>
		/// <java-name>
		/// android/database/MergeCursor
		/// </java-name>
		[Dot42.DexImport("android/database/MergeCursor", AccessFlags = 33)]
		public partial class MergeCursor : global::Android.Database.AbstractCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Landroid/database/Cursor;)V", AccessFlags = 1)]
				public MergeCursor(global::Android.Database.ICursor[] cursors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function is called every time the cursor is successfully scrolled to a new position, giving the subclass a chance to update any state it may have. If it returns false the move function will also do so and the cursor will scroll to the beforeFirst position. </para> <para>This function should be called by methods such as moveToPosition(int), so it will typically not be called from outside of the cursor class itself. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the move is successful, false otherwise. </para>
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
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public override short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public override int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public override long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public override float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public override double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public override int GetType(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public override bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public override sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public override void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para> <para> <para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public override void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public override void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para> <para> <para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public override void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public override void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para> <para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public override string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

		}

		/// <summary>
		///  <para>Provides methods for registering or unregistering arbitrary observers in an ArrayList.</para> <para>This abstract class is intended to be subclassed and specialized to maintain a registry of observers of specific types and dispatch notifications to them.</para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/database/Observable
		/// </java-name>
		[Dot42.DexImport("android/database/Observable", AccessFlags = 1057, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public abstract partial class Observable<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The list of observers. An observer can be in the list at most once and will never be null. </para>        
				/// </summary>
				/// <java-name>
				/// mObservers
				/// </java-name>
				[Dot42.DexImport("mObservers", "Ljava/util/ArrayList;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.ArrayList<T> MObservers;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Observable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds an observer to the list. The observer cannot be null and it must not already be registered. </para>        
				/// </summary>
				/// <java-name>
				/// registerObserver
				/// </java-name>
				[Dot42.DexImport("registerObserver", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void RegisterObserver(T observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a previously registered observer. The observer must not be null and it must already have been registered. </para>        
				/// </summary>
				/// <java-name>
				/// unregisterObserver
				/// </java-name>
				[Dot42.DexImport("unregisterObserver", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void UnregisterObserver(T observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all registered observers. </para>        
				/// </summary>
				/// <java-name>
				/// unregisterAll
				/// </java-name>
				[Dot42.DexImport("unregisterAll", "()V", AccessFlags = 1)]
				public virtual void UnregisterAll() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An exception that indicates there was an error with SQL parsing or execution. </para>    
		/// </summary>
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
				public SQLException(string error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This exception is thrown when a Cursor contains stale data and must be requeried before being used again. </para>    
		/// </summary>
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
				public StaleDataException(string description) /* MethodBuilder.Create */ 
				{
				}

		}

}

