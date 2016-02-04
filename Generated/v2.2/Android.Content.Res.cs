#pragma warning disable 1717
namespace Android.Content.Res
{
		/// <summary>
		///  <para>File descriptor of an entry in the AssetManager. This provides your own opened FileDescriptor that can be used to read the data, as well as the offset and length of that entry's data in the file. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/AssetFileDescriptor
		/// </java-name>
		[Dot42.DexImport("android/content/res/AssetFileDescriptor", AccessFlags = 33)]
		public partial class AssetFileDescriptor : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Length used with AssetFileDescriptor(ParcelFileDescriptor, long, long) and getDeclaredLength when a length has not been declared. This means the data extends to the end of the file. </para>        
				/// </summary>
				/// <java-name>
				/// UNKNOWN_LENGTH
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_LENGTH", "J", AccessFlags = 25)]
				public const long UNKNOWN_LENGTH = -1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Res.AssetFileDescriptor> CREATOR;
				/// <summary>
				///  <para>Create a new AssetFileDescriptor from the given values.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V", AccessFlags = 1)]
				public AssetFileDescriptor(global::Android.OS.ParcelFileDescriptor fd, long startOffset, long length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling  <code>getParcelFileDescriptor().close()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create and return a new auto-close input stream for this asset. This will either return a full asset AutoCloseInputStream, or an underlying ParcelFileDescriptor.AutoCloseInputStream depending on whether the the object represents a complete file or sub-section of a file. You should only call this once for a particular asset. </para>        
				/// </summary>
				/// <java-name>
				/// createInputStream
				/// </java-name>
				[Dot42.DexImport("createInputStream", "()Ljava/io/FileInputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.FileInputStream CreateInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileInputStream);
				}

				/// <summary>
				///  <para>Create and return a new auto-close output stream for this asset. This will either return a full asset AutoCloseOutputStream, or an underlying ParcelFileDescriptor.AutoCloseOutputStream depending on whether the the object represents a complete file or sub-section of a file. You should only call this once for a particular asset. </para>        
				/// </summary>
				/// <java-name>
				/// createOutputStream
				/// </java-name>
				[Dot42.DexImport("createOutputStream", "()Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.FileOutputStream CreateOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileOutputStream);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AssetFileDescriptor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>The AssetFileDescriptor contains its own ParcelFileDescriptor, which in addition to the normal FileDescriptor object also allows you to close the descriptor when you are done with it. </para>        
				/// </summary>
				/// <java-name>
				/// getParcelFileDescriptor
				/// </java-name>
				public virtual global::Android.OS.ParcelFileDescriptor ParcelFileDescriptor
				{
						[Dot42.DexImport("getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Android.OS.ParcelFileDescriptor); }
				}

				/// <summary>
				///  <para>Returns the FileDescriptor that can be used to read the data in the file. </para>        
				/// </summary>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

				/// <summary>
				///  <para>Returns the byte offset where this asset entry's data starts. </para>        
				/// </summary>
				/// <java-name>
				/// getStartOffset
				/// </java-name>
				public virtual long StartOffset
				{
						[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes of this asset entry's data. May be UNKNOWN_LENGTH if the asset extends to the end of the file. If the AssetFileDescriptor was constructed with UNKNOWN_LENGTH, this will use ParcelFileDescriptor.getStatSize() to find the total size of the file, returning that number if found or UNKNOWN_LENGTH if it could not be determined.</para> <para> <para>getDeclaredLength() </para></para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				public virtual long Length
				{
						[Dot42.DexImport("getLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return the actual number of bytes that were declared when the AssetFileDescriptor was constructed. Will be UNKNOWN_LENGTH if the length was not declared, meaning data should be read to the end of the file.</para> <para> <para>getDeclaredLength() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredLength
				/// </java-name>
				public virtual long DeclaredLength
				{
						[Dot42.DexImport("getDeclaredLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>An OutputStream you can create on a ParcelFileDescriptor, which will take care of calling ParcelFileDescritor.close() for you when the stream is closed. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/res/AssetFileDescriptor$AutoCloseOutputStream
				/// </java-name>
				[Dot42.DexImport("android/content/res/AssetFileDescriptor$AutoCloseOutputStream", AccessFlags = 9)]
				public partial class AutoCloseOutputStream : global::Android.OS.ParcelFileDescriptor.AutoCloseOutputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/res/AssetFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseOutputStream(global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
						public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
						public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
						public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
						public override void Write(int oneByte) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AutoCloseOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>An InputStream you can create on a ParcelFileDescriptor, which will take care of calling ParcelFileDescritor.close() for you when the stream is closed. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/res/AssetFileDescriptor$AutoCloseInputStream
				/// </java-name>
				[Dot42.DexImport("android/content/res/AssetFileDescriptor$AutoCloseInputStream", AccessFlags = 9)]
				public partial class AutoCloseInputStream : global::Android.OS.ParcelFileDescriptor.AutoCloseInputStream
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/res/AssetFileDescriptor;)V", AccessFlags = 1)]
						public AutoCloseInputStream(global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// available
						/// </java-name>
						[Dot42.DexImport("available", "()I", AccessFlags = 1)]
						public override int Available() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "()I", AccessFlags = 1)]
						public override int Read() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
						public override int Read(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
						public override int Read(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
						public override int Read(sbyte[] buffer) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
						public override int Read(byte[] buffer) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// skip
						/// </java-name>
						[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
						public override long Skip(long count) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// mark
						/// </java-name>
						[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
						public override void Mark(int readlimit) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// markSupported
						/// </java-name>
						[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
						public override bool MarkSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
						public override void Reset() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AutoCloseInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Provides access to an application's raw asset files; see Resources for the way most applications will want to retrieve their resource data. This class presents a lower-level API that allows you to open and read raw files that have been bundled with the application as a simple stream of bytes. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/AssetManager
		/// </java-name>
		[Dot42.DexImport("android/content/res/AssetManager", AccessFlags = 49)]
		public sealed partial class AssetManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Mode for open(String, int): no specific information about how data will be accessed. </para>        
				/// </summary>
				/// <java-name>
				/// ACCESS_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ACCESS_UNKNOWN", "I", AccessFlags = 25)]
				public const int ACCESS_UNKNOWN = 0;
				/// <summary>
				///  <para>Mode for open(String, int): Read chunks, and seek forward and backward. </para>        
				/// </summary>
				/// <java-name>
				/// ACCESS_RANDOM
				/// </java-name>
				[Dot42.DexImport("ACCESS_RANDOM", "I", AccessFlags = 25)]
				public const int ACCESS_RANDOM = 1;
				/// <summary>
				///  <para>Mode for open(String, int): Read sequentially, with an occasional forward seek. </para>        
				/// </summary>
				/// <java-name>
				/// ACCESS_STREAMING
				/// </java-name>
				[Dot42.DexImport("ACCESS_STREAMING", "I", AccessFlags = 25)]
				public const int ACCESS_STREAMING = 2;
				/// <summary>
				///  <para>Mode for open(String, int): Attempt to load contents into memory, for fast small reads. </para>        
				/// </summary>
				/// <java-name>
				/// ACCESS_BUFFER
				/// </java-name>
				[Dot42.DexImport("ACCESS_BUFFER", "I", AccessFlags = 25)]
				public const int ACCESS_BUFFER = 3;
				/// <summary>
				///  <para>Create a new AssetManager containing only the basic system assets. Applications will not generally use this method, instead retrieving the appropriate asset manager with Resources#getAssets. Not for use by applications. {} </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AssetManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Close this asset manager. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Open an asset using ACCESS_STREAMING mode. This provides access to files that have been bundled with an application as assets  that is, files placed in to the "assets" directory.</para> <para> <para>open(String, int) </para> <para>list </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.IO.InputStream Open(string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Open an asset using an explicit access mode, returning an InputStream to read its contents. This provides access to files that have been bundled with an application as assets  that is, files placed in to the "assets" directory.</para> <para> <para>ACCESS_UNKNOWN </para> <para>ACCESS_STREAMING </para> <para>ACCESS_RANDOM </para> <para>ACCESS_BUFFER </para> <para>open(String) </para> <para>list </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;I)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.IO.InputStream Open(string fileName, int accessMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <java-name>
				/// openFd
				/// </java-name>
				[Dot42.DexImport("openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenFd(string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>Return a String array of all the assets at the given path.</para> <para> <para>open </para></para>        
				/// </summary>
				/// <returns>
				///  <para>String[] Array of strings, one for each asset. These file names are relative to 'path'. You can open the file by concatenating 'path' and a name in the returned string (via File) and passing that to open().</para>
				/// </returns>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 273)]
				public string[] List(string path) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openNonAssetFd
				/// </java-name>
				[Dot42.DexImport("openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenNonAssetFd(string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openNonAssetFd
				/// </java-name>
				[Dot42.DexImport("openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenNonAssetFd(int cookie, string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>Retrieve a parser for a compiled XML file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// openXmlResourceParser
				/// </java-name>
				[Dot42.DexImport("openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;", AccessFlags = 17)]
				public global::Android.Content.Res.IXmlResourceParser OpenXmlResourceParser(string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				///  <para>Retrieve a parser for a compiled XML file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// openXmlResourceParser
				/// </java-name>
				[Dot42.DexImport("openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;", AccessFlags = 17)]
				public global::Android.Content.Res.IXmlResourceParser OpenXmlResourceParser(int cookie, string fileName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AssetManager() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the locales that this asset manager contains data for. </para>        
				/// </summary>
				/// <java-name>
				/// getLocales
				/// </java-name>
				public string[] Locales
				{
						[Dot42.DexImport("getLocales", "()[Ljava/lang/String;", AccessFlags = 273)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// android/content/res/AssetManager$AssetInputStream
				/// </java-name>
				[Dot42.DexImport("android/content/res/AssetManager$AssetInputStream", AccessFlags = 17)]
				public sealed partial class AssetInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/content/res/AssetManager;", AccessFlags = 4112)]
						internal readonly global::Android.Content.Res.AssetManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/content/res/AssetManager;)V", AccessFlags = 0)]
						internal AssetInputStream(global::Android.Content.Res.AssetManager assetManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "()I", AccessFlags = 17)]
						public override int Read() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// markSupported
						/// </java-name>
						[Dot42.DexImport("markSupported", "()Z", AccessFlags = 17)]
						public override bool MarkSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// available
						/// </java-name>
						[Dot42.DexImport("available", "()I", AccessFlags = 17)]
						public override int Available() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
						/// </summary>
						/// <java-name>
						/// close
						/// </java-name>
						[Dot42.DexImport("close", "()V", AccessFlags = 17)]
						public override void Close() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// mark
						/// </java-name>
						[Dot42.DexImport("mark", "(I)V", AccessFlags = 17)]
						public override void Mark(int readlimit) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "()V", AccessFlags = 17)]
						public override void Reset() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
						public override int Read(sbyte[] b) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 17)]
						public override int Read(byte[] b) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
						public override int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 17)]
						public override int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// skip
						/// </java-name>
						[Dot42.DexImport("skip", "(J)J", AccessFlags = 17)]
						public override long Skip(long n) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~AssetInputStream() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AssetInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getAssetInt
						/// </java-name>
						public int AssetInt
						{
								[Dot42.DexImport("getAssetInt", "()I", AccessFlags = 17)]
								get{ return default(int); }
						}

				}

		}

		/// <summary>
		///  <para>Lets you map android.view.View state sets to colors.</para> <para>android.content.res.ColorStateLists are created from XML resource files defined in the "color" subdirectory directory of an application's resource directory. The XML file contains a single "selector" element with a number of "item" elements inside. For example:</para> <para> <pre>
		/// &lt;selector xmlns:android="http://schemas.android.com/apk/res/android"&gt;
		///   &lt;item android:state_focused="true" android:color="@color/testcolor1"/&gt;
		///   &lt;item android:state_pressed="true" android:state_enabled="false" android:color="@color/testcolor2" /&gt;
		///   &lt;item android:state_enabled="false" android:color="@color/testcolor3" /&gt;
		///   &lt;item android:color="@color/testcolor5"/&gt;
		/// &lt;/selector&gt;
		/// </pre></para> <para>This defines a set of state spec / color pairs where each state spec specifies a set of states that a view must either be in or not be in and the color specifies the color associated with that spec. The list of state specs will be processed in order of the items in the XML file. An item with no state spec is considered to match any set of states and is generally useful as a final item to be used as a default. Note that if you have such an item before any other items in the list then any subsequent items will end up being ignored. </para> <para>For more information, see the guide to .</para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/ColorStateList
		/// </java-name>
		[Dot42.DexImport("android/content/res/ColorStateList", AccessFlags = 33)]
		public partial class ColorStateList : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Res.ColorStateList> CREATOR;
				/// <summary>
				///  <para>Creates a ColorStateList that returns the specified mapping from states to colors. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([[I[I)V", AccessFlags = 1)]
				public ColorStateList(int[][] states, int[] colors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates or retrieves a ColorStateList that always returns a single color. </para>        
				/// </summary>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList ValueOf(int color) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Create a ColorStateList from an XML document, given a set of Resources. </para>        
				/// </summary>
				/// <java-name>
				/// createFromXml
				/// </java-name>
				[Dot42.DexImport("createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/r" +
    "es/ColorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList CreateFromXml(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Creates a new ColorStateList that has the same states and colors as this one but where each color has the specified alpha value (0-255). </para>        
				/// </summary>
				/// <java-name>
				/// withAlpha
				/// </java-name>
				[Dot42.DexImport("withAlpha", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList WithAlpha(int alpha) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Return the color associated with the given set of android.view.View states.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the color associated with that set of states in this ColorStateList. </para>
				/// </returns>
				/// <java-name>
				/// getColorForState
				/// </java-name>
				[Dot42.DexImport("getColorForState", "([II)I", AccessFlags = 1)]
				public virtual int GetColorForState(int[] stateSet, int defaultColor) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ColorStateList() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				public virtual bool IsStateful
				{
						[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the default color in this ColorStateList.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default color in this ColorStateList. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultColor
				/// </java-name>
				public virtual int DefaultColor
				{
						[Dot42.DexImport("getDefaultColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class describes all device configuration information that can impact the resources the application retrieves. This includes both user-specified configuration options (locale and scaling) as well as device configurations (such as input modes, screen size and screen orientation). </para> <para>You can acquire this object from Resources, using Resources#getConfiguration. Thus, from an activity, you can get it by chaining the request with android.app.Activity#getResources:</para> <para> <pre>Configuration config = getResources().getConfiguration();</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/Configuration
		/// </java-name>
		[Dot42.DexImport("android/content/res/Configuration", AccessFlags = 49, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Comparable<Landroid/content/r" +
    "es/Configuration;>;")]
		public sealed partial class Configuration : global::Android.OS.IParcelable, global::System.IComparable<global::Android.Content.Res.Configuration>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Current user preference for the scaling factor for fonts, relative to the base density scaling. </para>        
				/// </summary>
				/// <java-name>
				/// fontScale
				/// </java-name>
				[Dot42.DexImport("fontScale", "F", AccessFlags = 1)]
				public float FontScale;
				/// <summary>
				///  <para>IMSI MCC (Mobile Country Code), corresponding to  resource qualifier. 0 if undefined. </para>        
				/// </summary>
				/// <java-name>
				/// mcc
				/// </java-name>
				[Dot42.DexImport("mcc", "I", AccessFlags = 1)]
				public int Mcc;
				/// <summary>
				///  <para>IMSI MNC (Mobile Network Code), corresponding to  resource qualifier. 0 if undefined. Note that the actual MNC may be 0; in order to check for this use the MNC_ZERO symbol. </para>        
				/// </summary>
				/// <java-name>
				/// mnc
				/// </java-name>
				[Dot42.DexImport("mnc", "I", AccessFlags = 1)]
				public int Mnc;
				/// <summary>
				///  <para>Current user preference for the locale, corresponding to  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale;
				/// <summary>
				///  <para>Constant for screenLayout: bits that encode the size. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_SIZE_MASK
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_MASK", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_MASK = 15;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_SIZE_MASK value indicating that no size has been set. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_SIZE_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_SIZE_MASK value indicating the screen is at least approximately 320x426 dp units, corresponds to the  resource qualifier. See  for more information. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_SIZE_SMALL
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_SMALL", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_SMALL = 1;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_SIZE_MASK value indicating the screen is at least approximately 320x470 dp units, corresponds to the  resource qualifier. See  for more information. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_SIZE_NORMAL
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_NORMAL", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_NORMAL = 2;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_SIZE_MASK value indicating the screen is at least approximately 480x640 dp units, corresponds to the  resource qualifier. See  for more information. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_SIZE_LARGE
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_LARGE", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_LARGE = 3;
				/// <summary>
				///  <para>Constant for screenLayout: bits that encode the aspect ratio. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_LONG_MASK
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_MASK", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_MASK = 48;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_LONG_MASK value indicating that no size has been set. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_LONG_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_LONG_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_LONG_NO
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_NO", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_NO = 16;
				/// <summary>
				///  <para>Constant for screenLayout: a SCREENLAYOUT_LONG_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// SCREENLAYOUT_LONG_YES
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_YES", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_YES = 32;
				/// <summary>
				///  <para>Bit mask of overall layout of the screen. Currently there are two fields: </para> <para>The SCREENLAYOUT_SIZE_MASK bits define the overall size of the screen. They may be one of SCREENLAYOUT_SIZE_SMALL, SCREENLAYOUT_SIZE_NORMAL, SCREENLAYOUT_SIZE_LARGE, or SCREENLAYOUT_SIZE_XLARGE.</para> <para>The SCREENLAYOUT_LONG_MASK defines whether the screen is wider/taller than normal. They may be one of SCREENLAYOUT_LONG_NO or SCREENLAYOUT_LONG_YES.</para> <para>The SCREENLAYOUT_LAYOUTDIR_MASK defines whether the screen layout is either LTR or RTL. They may be one of SCREENLAYOUT_LAYOUTDIR_LTR or SCREENLAYOUT_LAYOUTDIR_RTL.</para> <para>See  for more information. </para>        
				/// </summary>
				/// <java-name>
				/// screenLayout
				/// </java-name>
				[Dot42.DexImport("screenLayout", "I", AccessFlags = 1)]
				public int ScreenLayout;
				/// <summary>
				///  <para>Constant for touchscreen: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// TOUCHSCREEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for touchscreen, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// TOUCHSCREEN_NOTOUCH
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_NOTOUCH", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_NOTOUCH = 1;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Not currently supported or used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TOUCHSCREEN_STYLUS
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_STYLUS", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_STYLUS = 2;
				/// <summary>
				///  <para>Constant for touchscreen, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// TOUCHSCREEN_FINGER
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_FINGER", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_FINGER = 3;
				/// <summary>
				///  <para>The kind of touch screen attached to the device. One of: TOUCHSCREEN_NOTOUCH, TOUCHSCREEN_FINGER. </para>        
				/// </summary>
				/// <java-name>
				/// touchscreen
				/// </java-name>
				[Dot42.DexImport("touchscreen", "I", AccessFlags = 1)]
				public int Touchscreen;
				/// <summary>
				///  <para>Constant for keyboard: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_UNDEFINED", "I", AccessFlags = 25)]
				public const int KEYBOARD_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for keyboard, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_NOKEYS
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_NOKEYS", "I", AccessFlags = 25)]
				public const int KEYBOARD_NOKEYS = 1;
				/// <summary>
				///  <para>Constant for keyboard, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_QWERTY
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_QWERTY", "I", AccessFlags = 25)]
				public const int KEYBOARD_QWERTY = 2;
				/// <summary>
				///  <para>Constant for keyboard, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_12KEY
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_12KEY", "I", AccessFlags = 25)]
				public const int KEYBOARD_12KEY = 3;
				/// <summary>
				///  <para>The kind of keyboard attached to the device. One of: KEYBOARD_NOKEYS, KEYBOARD_QWERTY, KEYBOARD_12KEY. </para>        
				/// </summary>
				/// <java-name>
				/// keyboard
				/// </java-name>
				[Dot42.DexImport("keyboard", "I", AccessFlags = 1)]
				public int Keyboard;
				/// <summary>
				///  <para>Constant for keyboardHidden: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARDHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for keyboardHidden, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARDHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_NO", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_NO = 1;
				/// <summary>
				///  <para>Constant for keyboardHidden, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARDHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_YES", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_YES = 2;
				/// <summary>
				///  <para>A flag indicating whether any keyboard is available. Unlike hardKeyboardHidden, this also takes into account a soft keyboard, so if the hard keyboard is hidden but there is soft keyboard available, it will be set to NO. Value is one of: KEYBOARDHIDDEN_NO, KEYBOARDHIDDEN_YES. </para>        
				/// </summary>
				/// <java-name>
				/// keyboardHidden
				/// </java-name>
				[Dot42.DexImport("keyboardHidden", "I", AccessFlags = 1)]
				public int KeyboardHidden;
				/// <summary>
				///  <para>Constant for hardKeyboardHidden: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for hardKeyboardHidden, value corresponding to the physical keyboard being exposed. </para>        
				/// </summary>
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_NO", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_NO = 1;
				/// <summary>
				///  <para>Constant for hardKeyboardHidden, value corresponding to the physical keyboard being hidden. </para>        
				/// </summary>
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_YES", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_YES = 2;
				/// <summary>
				///  <para>A flag indicating whether the hard keyboard has been hidden. This will be set on a device with a mechanism to hide the keyboard from the user, when that mechanism is closed. One of: HARDKEYBOARDHIDDEN_NO, HARDKEYBOARDHIDDEN_YES. </para>        
				/// </summary>
				/// <java-name>
				/// hardKeyboardHidden
				/// </java-name>
				[Dot42.DexImport("hardKeyboardHidden", "I", AccessFlags = 1)]
				public int HardKeyboardHidden;
				/// <summary>
				///  <para>Constant for navigation: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_UNDEFINED", "I", AccessFlags = 25)]
				public const int NAVIGATION_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for navigation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_NONAV
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_NONAV", "I", AccessFlags = 25)]
				public const int NAVIGATION_NONAV = 1;
				/// <summary>
				///  <para>Constant for navigation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_DPAD
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_DPAD", "I", AccessFlags = 25)]
				public const int NAVIGATION_DPAD = 2;
				/// <summary>
				///  <para>Constant for navigation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_TRACKBALL", "I", AccessFlags = 25)]
				public const int NAVIGATION_TRACKBALL = 3;
				/// <summary>
				///  <para>Constant for navigation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_WHEEL
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_WHEEL", "I", AccessFlags = 25)]
				public const int NAVIGATION_WHEEL = 4;
				/// <summary>
				///  <para>The kind of navigation method available on the device. One of: NAVIGATION_NONAV, NAVIGATION_DPAD, NAVIGATION_TRACKBALL, NAVIGATION_WHEEL. </para>        
				/// </summary>
				/// <java-name>
				/// navigation
				/// </java-name>
				[Dot42.DexImport("navigation", "I", AccessFlags = 1)]
				public int Navigation;
				/// <summary>
				///  <para>Constant for navigationHidden: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATIONHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for navigationHidden, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATIONHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_NO", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_NO = 1;
				/// <summary>
				///  <para>Constant for navigationHidden, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATIONHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_YES", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_YES = 2;
				/// <summary>
				///  <para>A flag indicating whether any 5-way or DPAD navigation available. This will be set on a device with a mechanism to hide the navigation controls from the user, when that mechanism is closed. One of: NAVIGATIONHIDDEN_NO, NAVIGATIONHIDDEN_YES. </para>        
				/// </summary>
				/// <java-name>
				/// navigationHidden
				/// </java-name>
				[Dot42.DexImport("navigationHidden", "I", AccessFlags = 1)]
				public int NavigationHidden;
				/// <summary>
				///  <para>Constant for orientation: a value indicating that no value has been set. </para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNDEFINED", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for orientation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_PORTRAIT", "I", AccessFlags = 25)]
				public const int ORIENTATION_PORTRAIT = 1;
				/// <summary>
				///  <para>Constant for orientation, value corresponding to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_LANDSCAPE", "I", AccessFlags = 25)]
				public const int ORIENTATION_LANDSCAPE = 2;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Not currently supported or used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_SQUARE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_SQUARE", "I", AccessFlags = 25)]
				public const int ORIENTATION_SQUARE = 3;
				/// <summary>
				///  <para>Overall orientation of the screen. May be one of ORIENTATION_LANDSCAPE, ORIENTATION_PORTRAIT. </para>        
				/// </summary>
				/// <java-name>
				/// orientation
				/// </java-name>
				[Dot42.DexImport("orientation", "I", AccessFlags = 1)]
				public int Orientation;
				/// <summary>
				///  <para>Constant for uiMode: bits that encode the mode type. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_TYPE_MASK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_MASK", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_MASK = 15;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_TYPE_MASK value indicating that no mode type has been set. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_TYPE_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_UNDEFINED", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_TYPE_MASK value that corresponds to  resource qualifier specified. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_NORMAL = 1;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_TYPE_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_TYPE_DESK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_DESK", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_DESK = 2;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_TYPE_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_TYPE_CAR
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_CAR", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_CAR = 3;
				/// <summary>
				///  <para>Constant for uiMode: bits that encode the night mode. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_NIGHT_MASK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_MASK", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_MASK = 48;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_NIGHT_MASK value indicating that no mode type has been set. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_NIGHT_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_UNDEFINED", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_UNDEFINED = 0;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_NIGHT_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_NIGHT_NO
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_NO", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_NO = 16;
				/// <summary>
				///  <para>Constant for uiMode: a UI_MODE_NIGHT_MASK value that corresponds to the  resource qualifier. </para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_NIGHT_YES
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_YES", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_YES = 32;
				/// <summary>
				///  <para>Bit mask of the ui mode. Currently there are two fields: </para> <para>The UI_MODE_TYPE_MASK bits define the overall ui mode of the device. They may be one of UI_MODE_TYPE_UNDEFINED, UI_MODE_TYPE_NORMAL, UI_MODE_TYPE_DESK, UI_MODE_TYPE_CAR, UI_MODE_TYPE_TELEVISION, or UI_MODE_TYPE_APPLIANCE.</para> <para>The UI_MODE_NIGHT_MASK defines whether the screen is in a special mode. They may be one of UI_MODE_NIGHT_UNDEFINED, UI_MODE_NIGHT_NO or UI_MODE_NIGHT_YES. </para>        
				/// </summary>
				/// <java-name>
				/// uiMode
				/// </java-name>
				[Dot42.DexImport("uiMode", "I", AccessFlags = 1)]
				public int UiMode;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Res.Configuration> CREATOR;
				/// <summary>
				///  <para>Construct an invalid Configuration. You must call setToDefaults for this object to be valid. {} </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Configuration() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes a deep copy suitable for modification. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public Configuration(global::Android.Content.Res.Configuration o) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public void SetTo(global::Android.Content.Res.Configuration o) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Set this object to the system defaults. </para>        
				/// </summary>
				/// <java-name>
				/// setToDefaults
				/// </java-name>
				[Dot42.DexImport("setToDefaults", "()V", AccessFlags = 1)]
				public void SetToDefaults() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the fields from delta into this Configuration object, keeping track of which ones have changed. Any undefined fields in  <b>delta</b> are ignored and not copied in to the current Configuration. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a bit mask of the changed fields, as per diff. </para>
				/// </returns>
				/// <java-name>
				/// updateFrom
				/// </java-name>
				[Dot42.DexImport("updateFrom", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int UpdateFrom(global::Android.Content.Res.Configuration delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a bit mask of the differences between this Configuration object and the given one. Does not change the values of either. Any undefined fields in  <b>delta</b> are ignored. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a bit mask indicating which configuration values has changed, containing any combination of PackageManager.ActivityInfo.CONFIG_FONT_SCALE, PackageManager.ActivityInfo.CONFIG_MCC, PackageManager.ActivityInfo.CONFIG_MNC, PackageManager.ActivityInfo.CONFIG_LOCALE, PackageManager.ActivityInfo.CONFIG_TOUCHSCREEN, PackageManager.ActivityInfo.CONFIG_KEYBOARD, PackageManager.ActivityInfo.CONFIG_NAVIGATION, PackageManager.ActivityInfo.CONFIG_ORIENTATION, PackageManager.ActivityInfo.CONFIG_SCREEN_LAYOUT, or PackageManager.ActivityInfo.CONFIG_SCREEN_SIZE, or PackageManager.ActivityInfo.CONFIG_SMALLEST_SCREEN_SIZE. PackageManager.ActivityInfo.CONFIG_LAYOUT_DIRECTION. </para>
				/// </returns>
				/// <java-name>
				/// diff
				/// </java-name>
				[Dot42.DexImport("diff", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int Diff(global::Android.Content.Res.Configuration delta) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Determine if a new resource needs to be loaded from the bit set of configuration changes returned by updateFrom(Configuration).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if the resource needs to be loaded, else false. </para>
				/// </returns>
				/// <java-name>
				/// needNewResources
				/// </java-name>
				[Dot42.DexImport("needNewResources", "(II)Z", AccessFlags = 9)]
				public static bool NeedNewResources(int configChanges, int interestingChanges) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Parcelable methods </para>        
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
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int CompareTo(global::Android.Content.Res.Configuration that) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Landroid/content/res/Configuration;)Z", AccessFlags = 1)]
				public bool Equals(global::Android.Content.Res.Configuration that) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object that) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>The XML parsing interface returned for an XML resource. This is a standard XmlPullParser interface, as well as an extended AttributeSet interface and an additional close() method on this interface for the client to indicate when it is done reading the resource. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/XmlResourceParser
		/// </java-name>
		[Dot42.DexImport("android/content/res/XmlResourceParser", AccessFlags = 1537)]
		public partial interface IXmlResourceParser : global::Org.Xmlpull.V1.IXmlPullParser, global::Android.Util.IAttributeSet
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Close this interface to the resource. Calls on the interface are no longer value after this call. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Class for accessing an application's resources. This sits on top of the asset manager of the application (accessible through getAssets) and provides a high-level API for getting typed data from the assets.</para> <para>The Android resource system keeps track of all non-code assets associated with an application. You can use this class to access your application's resources. You can generally acquire the android.content.res.Resources instance associated with your application with getResources().</para> <para>The Android SDK tools compile your application's resources into the application binary at build time. To use a resource, you must install it correctly in the source tree (inside your project's <c>res/ </c> directory) and build your application. As part of the build process, the SDK tools generate symbols for each resource, which you can use in your application code to access the resources.</para> <para>Using application resources makes it easy to update various characteristics of your application without modifying code, andby providing sets of alternative resourcesenables you to optimize your application for a variety of device configurations (such as for different languages and screen sizes). This is an important aspect of developing Android applications that are compatible on different types of devices.</para> <para>For more information about using resources, see the documentation about .</para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/Resources
		/// </java-name>
		[Dot42.DexImport("android/content/res/Resources", AccessFlags = 33)]
		public partial class Resources
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new Resources object on top of an existing set of assets in an AssetManager.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/" +
    "res/Configuration;)V", AccessFlags = 1)]
				public Resources(global::Android.Content.Res.AssetManager assets, global::Android.Util.DisplayMetrics metrics, global::Android.Content.Res.Configuration config) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the string value associated with a particular resource ID. The returned object will be a String if this is a plain string; it will be some other type of CharSequence if it is styled. {}</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence The string data associated with the resource, plus possibly styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Returns the character sequence necessary for grammatically correct pluralization of the given resource ID for the given quantity. Note that the character sequence is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence The string data associated with the resource, plus possibly styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityText
				/// </java-name>
				[Dot42.DexImport("getQuantityText", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetQuantityText(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Return the string value associated with a particular resource ID. It will be stripped of any styled text information. {}</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int id) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the string value associated with a particular resource ID, substituting the format arguments as defined in java.util.Formatter and java.lang.String#format. It will be stripped of any styled text information. {}</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public virtual string GetString(int id, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Formats the string necessary for grammatically correct pluralization of the given resource ID for the given quantity, using the given arguments. Note that the string is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para> <para>Substitution of format arguments works as if using java.util.Formatter and java.lang.String#format. The resulting string will be stripped of any styled text information.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public virtual string GetQuantityString(int id, int quantity, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the string necessary for grammatically correct pluralization of the given resource ID for the given quantity. Note that the string is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQuantityString(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the string value associated with a particular resource ID. The returned object will be a String if this is a plain string; it will be some other type of CharSequence if it is styled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence The string data associated with the resource, plus possibly styled text information, or def if id is 0 or not found. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int id, global::Java.Lang.ICharSequence def) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Return the styled text array associated with a particular resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The styled text array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetTextArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				///  <para>Return the string array associated with a particular resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The string array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStringArray(int id) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Return the int array associated with a particular resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The int array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(I)[I", AccessFlags = 1)]
				public virtual int[] GetIntArray(int id) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Return an array of heterogeneous values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a TypedArray holding an array of the array values. Be sure to call TypedArray.recycle() when done with it. </para>
				/// </returns>
				/// <java-name>
				/// obtainTypedArray
				/// </java-name>
				[Dot42.DexImport("obtainTypedArray", "(I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.TypedArray ObtainTypedArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				///  <para>Retrieve a dimensional for a particular resource ID. Unit conversions are based on the current DisplayMetrics associated with the resources.</para> <para> <para>getDimensionPixelOffset </para> <para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resource dimension value multiplied by the appropriate metric.</para>
				/// </returns>
				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(I)F", AccessFlags = 1)]
				public virtual float GetDimension(int id) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve a dimensional for a particular resource ID for use as an offset in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for you. An offset conversion involves simply truncating the base value to an integer.</para> <para> <para>getDimension </para> <para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resource dimension value multiplied by the appropriate metric and truncated to integer pixels.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(I)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelOffset(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve a dimensional for a particular resource ID for use as a size in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for use as a size. A size conversion involves rounding the base value, and ensuring that a non-zero base value is at least one pixel in size.</para> <para> <para>getDimension </para> <para>getDimensionPixelOffset </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resource dimension value multiplied by the appropriate metric and truncated to integer pixels.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(I)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelSize(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve a fractional unit for a particular resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute fractional value multiplied by the appropriate base value.</para>
				/// </returns>
				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(III)F", AccessFlags = 1)]
				public virtual float GetFraction(int id, int @base, int pbase) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return a drawable object associated with a particular resource ID. Various types of objects will be returned depending on the underlying resource  for example, a solid color, PNG image, scalable image, etc. The Drawable API hides these implementation details.</para> <para> <b>Note:</b> Prior to android.os.Build.VERSION_CODES#JELLY_BEAN, this function would not correctly retrieve the final configuration density when the resource ID passed here is an alias to another Drawable resource. This means that if the density configuration of the alias resource is different than the actual resource, the density of the returned Drawable would be incorrect, resulting in bad scaling. To work around this, you can instead retrieve the Drawable through TypedArray.getDrawable. Use Context.obtainStyledAttributes with an array containing the resource ID of interest to create the TypedArray.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Drawable An object that can be used to draw this resource. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable GetDrawable(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Return a movie object associated with the particular resource ID. </para>        
				/// </summary>
				/// <java-name>
				/// getMovie
				/// </java-name>
				[Dot42.DexImport("getMovie", "(I)Landroid/graphics/Movie;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Movie GetMovie(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <summary>
				///  <para>Return a color integer associated with a particular resource ID. If the resource holds a complex android.content.res.ColorStateList, then the default color from the set is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a single color value in the form 0xAARRGGBB. </para>
				/// </returns>
				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(I)I", AccessFlags = 1)]
				public virtual int GetColor(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a color state list associated with a particular resource ID. The resource may contain either a single raw color value, or a complex android.content.res.ColorStateList holding multiple possible colors.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a ColorStateList object containing either a single solid color or multiple colors that can be selected based on a state. </para>
				/// </returns>
				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList GetColorStateList(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Return a boolean associated with a particular resource ID. This can be used with any integral resource value, and will return true if it is non-zero.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the boolean value contained in the resource. </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an integer associated with a particular resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the integer value contained in the resource. </para>
				/// </returns>
				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(I)I", AccessFlags = 1)]
				public virtual int GetInteger(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return an XmlResourceParser through which you can read a view layout description for the given resource ID. This parser has limited functionality  in particular, you can't change its input, and only the high-level events are available.</para> <para>This function is really a simple wrapper for calling getXml with a layout resource.</para> <para> <para>getXml </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getLayout
				/// </java-name>
				[Dot42.DexImport("getLayout", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetLayout(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				///  <para>Return an XmlResourceParser through which you can read an animation description for the given resource ID. This parser has limited functionality  in particular, you can't change its input, and only the high-level events are available.</para> <para>This function is really a simple wrapper for calling getXml with an animation resource.</para> <para> <para>getXml </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetAnimation(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				///  <para>Return an XmlResourceParser through which you can read a generic XML resource for the given resource ID.</para> <para>The XmlPullParser implementation returned here has some limited functionality. In particular, you can't change its input, and only high-level parsing events are available (since the document was pre-parsed for you at build time, which involved merging text and stripping comments).</para> <para> <para>android.util.AttributeSet </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetXml(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				///  <para>Open a data stream for reading a raw resource. This can only be used with resources whose value is the name of an asset files  that is, it can be used to open drawable, sound, and raw resources; it will fail on string and color resources.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>InputStream Access to the resource data.</para>
				/// </returns>
				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(I)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.InputStream OpenRawResource(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Open a data stream for reading a raw resource. This can only be used with resources whose value is the name of an asset file  that is, it can be used to open drawable, sound, and raw resources; it will fail on string and color resources.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>InputStream Access to the resource data.</para>
				/// </returns>
				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.InputStream OpenRawResource(int id, global::Android.Util.TypedValue value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Open a file descriptor for reading a raw resource. This can only be used with resources whose value is the name of an asset files  that is, it can be used to open drawable, sound, and raw resources; it will fail on string and color resources.</para> <para>This function only works for resources that are stored in the package as uncompressed data, which typically includes things like mp3 files and png images.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>AssetFileDescriptor A new file descriptor you can use to read the resource. This includes the file descriptor itself, as well as the offset and length of data where the resource appears in the file. A null is returned if the file exists but is compressed.</para>
				/// </returns>
				/// <java-name>
				/// openRawResourceFd
				/// </java-name>
				[Dot42.DexImport("openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenRawResourceFd(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(ILandroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public virtual void GetValue(int int32, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public virtual void GetValue(string @string, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generate a new Theme object for this set of Resources. It initially starts out empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Theme The newly created Theme container. </para>
				/// </returns>
				/// <java-name>
				/// newTheme
				/// </java-name>
				[Dot42.DexImport("newTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 17)]
				public global::Android.Content.Res.Resources.Theme NewTheme() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources.Theme);
				}

				/// <summary>
				///  <para>Retrieve a set of basic attribute values from an AttributeSet, not performing styling of them using a theme and/or style resources.</para> <para> <para>Theme::obtainStyledAttributes(AttributeSet, int[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a TypedArray holding an array of the attribute values. Be sure to call TypedArray.recycle() when done with it.</para>
				/// </returns>
				/// <java-name>
				/// obtainAttributes
				/// </java-name>
				[Dot42.DexImport("obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.TypedArray ObtainAttributes(global::Android.Util.IAttributeSet set, int[] attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				///  <para>Store the newly updated configuration. </para>        
				/// </summary>
				/// <java-name>
				/// updateConfiguration
				/// </java-name>
				[Dot42.DexImport("updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void UpdateConfiguration(global::Android.Content.Res.Configuration config, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a resource identifier for the given resource name. A fully qualified resource name is of the form "package:type/entry". The first two components (package and type) are optional if defType and defPackage, respectively, are specified here.</para> <para>Note: use of this function is discouraged. It is much more efficient to retrieve resources by identifier than by name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int The associated resource identifier. Returns 0 if no such resource was found. (0 is not a valid resource ID.) </para>
				/// </returns>
				/// <java-name>
				/// getIdentifier
				/// </java-name>
				[Dot42.DexImport("getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIdentifier(string name, string defType, string defPackage) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the full name for a given resource identifier. This name is a single string of the form "package:type/entry".</para> <para> <para>getResourcePackageName </para> <para>getResourceTypeName </para> <para>getResourceEntryName </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string holding the name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceName
				/// </java-name>
				[Dot42.DexImport("getResourceName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the package name for a given resource identifier.</para> <para> <para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string holding the package name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourcePackageName
				/// </java-name>
				[Dot42.DexImport("getResourcePackageName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourcePackageName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the type name for a given resource identifier.</para> <para> <para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string holding the type name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceTypeName
				/// </java-name>
				[Dot42.DexImport("getResourceTypeName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceTypeName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the entry name for a given resource identifier.</para> <para> <para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string holding the entry name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceEntryName
				/// </java-name>
				[Dot42.DexImport("getResourceEntryName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceEntryName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Parse a series of &lt;extra&gt; tags from an XML file. You call this when you are at the parent tag of the extra tags, and it will return once all of the child tags have been parsed. This will call parseBundleExtra for each extra tag encountered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// parseBundleExtras
				/// </java-name>
				[Dot42.DexImport("parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void ParseBundleExtras(global::Android.Content.Res.IXmlResourceParser parser, global::Android.OS.Bundle outBundle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse a name/value pair out of an XML tag holding that data. The AttributeSet must be holding the data defined by android.R.styleable#Extra. The following value types are supported:  <ul> <li> <para>TypedValue#TYPE_STRING: Bundle.putCharSequence() </para></li> <li> <para>TypedValue#TYPE_INT_BOOLEAN: Bundle.putBoolean() </para></li> <li> <para>TypedValue#TYPE_FIRST_INT-TypedValue#TYPE_LAST_INT: Bundle.putBoolean() </para></li> <li> <para>TypedValue#TYPE_FLOAT: Bundle.putFloat() </para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// parseBundleExtra
				/// </java-name>
				[Dot42.DexImport("parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void ParseBundleExtra(string tagName, global::Android.Util.IAttributeSet attrs, global::Android.OS.Bundle outBundle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this to remove all cached loaded layout resources from the Resources object. Only intended for use with performance testing tools. </para>        
				/// </summary>
				/// <java-name>
				/// flushLayoutCache
				/// </java-name>
				[Dot42.DexImport("flushLayoutCache", "()V", AccessFlags = 17)]
				public void FlushLayoutCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by zygote when it is done preloading resources, to change back to normal Resources operation. </para>        
				/// </summary>
				/// <java-name>
				/// finishPreloading
				/// </java-name>
				[Dot42.DexImport("finishPreloading", "()V", AccessFlags = 17)]
				public void FinishPreloading() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Resources() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return a global shared Resources object that provides access to only system resources (no application resources), and is not configured for the current screen (can not use dimension units, does not change based on orientation, etc). </para>        
				/// </summary>
				/// <java-name>
				/// getSystem
				/// </java-name>
				public static global::Android.Content.Res.Resources System
				{
						[Dot42.DexImport("getSystem", "()Landroid/content/res/Resources;", AccessFlags = 9)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <summary>
				///  <para>Return the current display metrics that are in effect for this resource object. The returned object should be treated as read-only.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resource's current display metrics. </para>
				/// </returns>
				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				public virtual global::Android.Util.DisplayMetrics DisplayMetrics
				{
						[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
						get{ return default(global::Android.Util.DisplayMetrics); }
				}

				/// <summary>
				///  <para>Return the current configuration that is in effect for this resource object. The returned object should be treated as read-only.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resource's current configuration. </para>
				/// </returns>
				/// <java-name>
				/// getConfiguration
				/// </java-name>
				public virtual global::Android.Content.Res.Configuration Configuration
				{
						[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Configuration); }
				}

				/// <summary>
				///  <para>Retrieve underlying AssetManager storage for these resources. </para>        
				/// </summary>
				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
						[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.AssetManager); }
				}

				/// <summary>
				///  <para>This class holds the current attribute values for a particular theme. In other words, a Theme is a set of values for resource attributes; these are used in conjunction with TypedArray to resolve the final value for an attribute.</para> <para>The Theme's attributes come into play in two ways: (1) a styled attribute can explicit reference a value in the theme through the "?themeAttribute" syntax; (2) if no value has been defined for a particular styled attribute, as a last resort we will try to find that attribute's value in the Theme.</para> <para>You will normally use the obtainStyledAttributes APIs to retrieve XML attributes with style and theme information applied. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/res/Resources$Theme
				/// </java-name>
				[Dot42.DexImport("android/content/res/Resources$Theme", AccessFlags = 17)]
				public sealed partial class Theme
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/content/res/Resources;", AccessFlags = 4112)]
						internal readonly global::Android.Content.Res.Resources This_0;
						[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;)V", AccessFlags = 0)]
						internal Theme(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Place new attribute values into the theme. The style resource specified by  <b>resid</b> will be retrieved from this Theme's resources, its values placed into the Theme object.</para> <para>The semantics of this function depends on the  <b>force</b> argument: If false, only values that are not already defined in the theme will be copied from the system resource; otherwise, if any of the style's attributes are already defined in the theme, the current values in the theme will be overwritten.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// applyStyle
						/// </java-name>
						[Dot42.DexImport("applyStyle", "(IZ)V", AccessFlags = 1)]
						public void ApplyStyle(int resid, bool force) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set this theme to hold the same contents as the theme  <b>other</b>. If both of these themes are from the same Resources object, they will be identical after this function returns. If they are from different Resources, only the resources they have in common will be set in this theme.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setTo
						/// </java-name>
						[Dot42.DexImport("setTo", "(Landroid/content/res/Resources$Theme;)V", AccessFlags = 1)]
						public void SetTo(Theme other) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Return a TypedArray holding the values defined by  <b>Theme</b> which are listed in  <b>attrs</b>.</para> <para>Be sure to call TypedArray.recycle() when you are done with the array.</para> <para> <para>Resources::obtainAttributes </para> <para>obtainStyledAttributes(int, int[]) </para> <para>obtainStyledAttributes(AttributeSet, int[], int, int) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>Returns a TypedArray holding an array of the attribute values. Be sure to call TypedArray.recycle() when done with it.</para>
						/// </returns>
						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int[] attrs) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <summary>
						///  <para>Return a TypedArray holding the values defined by the style resource  <b>resid</b> which are listed in  <b>attrs</b>.</para> <para>Be sure to call TypedArray.recycle() when you are done with the array.</para> <para> <para>Resources::obtainAttributes </para> <para>obtainStyledAttributes(int[]) </para> <para>obtainStyledAttributes(AttributeSet, int[], int, int) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>Returns a TypedArray holding an array of the attribute values. Be sure to call TypedArray.recycle() when done with it.</para>
						/// </returns>
						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int resid, int[] attrs) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <summary>
						///  <para>Return a TypedArray holding the attribute values in  <b>set</b> that are listed in  <b>attrs</b>. In addition, if the given AttributeSet specifies a style class (through the "style" attribute), that style will be applied on top of the base attributes it defines.</para> <para>Be sure to call TypedArray.recycle() when you are done with the array.</para> <para>When determining the final value of a particular attribute, there are four inputs that come into play:</para> <para> <ol> <li> <para>Any attribute values in the given AttributeSet. </para></li> <li> <para>The style resource specified in the AttributeSet (named "style"). </para></li> <li> <para>The default style specified by  <b>defStyleAttr</b> and  <b>defStyleRes</b> </para></li> <li> <para>The base values in this theme. </para></li></ol></para> <para>Each of these inputs is considered in-order, with the first listed taking precedence over the following ones. In other words, if in the AttributeSet you have supplied  <code>&lt;Button textColor="#ff000000"&gt;</code>, then the button's text will  <b>always</b> be black, regardless of what is specified in any of the styles.</para> <para> <para>Resources::obtainAttributes </para> <para>obtainStyledAttributes(int[]) </para> <para>obtainStyledAttributes(int, int[]) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>Returns a TypedArray holding an array of the attribute values. Be sure to call TypedArray.recycle() when done with it.</para>
						/// </returns>
						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(global::Android.Util.IAttributeSet set, int[] attrs, int defStyleAttr, int defStyleRes) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <summary>
						///  <para>Retrieve the value of an attribute in the Theme. The contents of  <b>outValue</b> are ultimately filled in by Resources#getValue.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Returns true if the attribute was found and  <b>outValue</b> is valid, else false. </para>
						/// </returns>
						/// <java-name>
						/// resolveAttribute
						/// </java-name>
						[Dot42.DexImport("resolveAttribute", "(ILandroid/util/TypedValue;Z)Z", AccessFlags = 1)]
						public bool ResolveAttribute(int resid, global::Android.Util.TypedValue outValue, bool resolveRefs) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Print contents of this theme out to the log. For debugging only.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public void Dump(int priority, string tag, string prefix) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~Theme() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal Theme() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>This exception is thrown by the resource APIs when a requested resource can not be found. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/res/Resources$NotFoundException
				/// </java-name>
				[Dot42.DexImport("android/content/res/Resources$NotFoundException", AccessFlags = 9)]
				public partial class NotFoundException : global::System.SystemException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public NotFoundException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public NotFoundException(string @string) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Container for an array of values that were retrieved with Resources.Theme#obtainStyledAttributes(AttributeSet, int[], int, int) or Resources#obtainAttributes. Be sure to call recycle when done with them.</para> <para>The indices used to retrieve values from this structure correspond to the positions of the attributes given to obtainStyledAttributes. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/res/TypedArray
		/// </java-name>
		[Dot42.DexImport("android/content/res/TypedArray", AccessFlags = 33)]
		public partial class TypedArray
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TypedArray() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of values in this array. </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return an index in the array that has data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The index at the given offset, which can be used with getValue and related APIs. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(I)I", AccessFlags = 1)]
				public virtual int GetIndex(int at) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve the styled string value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence holding string data. May be styled. Returns null if the attribute is not defined. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Retrieve the string value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String holding string data. Any styling information is removed. Returns null if the attribute is not defined. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieve the string value for the attribute at  <b>index</b>, but only if that string comes from an immediate value in an XML file. That is, this does not allow references to string resources, string attributes, or conversions from other types. As such, this method will only return strings for TypedArray objects that come from attributes in an XML file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String holding string data. Any styling information is removed. Returns null if the attribute is not defined or is not an immediate string value. </para>
				/// </returns>
				/// <java-name>
				/// getNonResourceString
				/// </java-name>
				[Dot42.DexImport("getNonResourceString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNonResourceString(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieve the boolean value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute boolean value, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(IZ)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(int index, bool defValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieve the integer value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute int value, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(II)I", AccessFlags = 1)]
				public virtual int GetInt(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve the float value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute float value, or defValue if not defined.. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(IF)F", AccessFlags = 1)]
				public virtual float GetFloat(int index, float defValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve the color value for the attribute at  <b>index</b>. If the attribute references a color resource holding a complex android.content.res.ColorStateList, then the default color from the set is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute color value, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(II)I", AccessFlags = 1)]
				public virtual int GetColor(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve the ColorStateList for the attribute at  <b>index</b>. The value may be either a single solid color or a reference to a color or complex android.content.res.ColorStateList description.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ColorStateList for the attribute, or null if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList GetColorStateList(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Retrieve the integer value for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute integer value, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(II)I", AccessFlags = 1)]
				public virtual int GetInteger(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve a dimensional unit attribute at  <b>index</b>. Unit conversions are based on the current DisplayMetrics associated with the resources this TypedArray object came from.</para> <para> <para>getDimensionPixelOffset </para> <para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute dimension value multiplied by the appropriate metric, or defValue if not defined.</para>
				/// </returns>
				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(IF)F", AccessFlags = 1)]
				public virtual float GetDimension(int index, float defValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve a dimensional unit attribute at  <b>index</b> for use as an offset in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for you. An offset conversion involves simply truncating the base value to an integer.</para> <para> <para>getDimension </para> <para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute dimension value multiplied by the appropriate metric and truncated to integer pixels, or defValue if not defined.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(II)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelOffset(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve a dimensional unit attribute at  <b>index</b> for use as a size in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for use as a size. A size conversion involves rounding the base value, and ensuring that a non-zero base value is at least one pixel in size.</para> <para> <para>getDimension </para> <para>getDimensionPixelOffset </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute dimension value multiplied by the appropriate metric and truncated to integer pixels, or defValue if not defined.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(II)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelSize(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Special version of getDimensionPixelSize for retrieving android.view.ViewGroup's layout_width and layout_height attributes. This is only here for performance reasons; applications should use getDimensionPixelSize.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute dimension value multiplied by the appropriate metric and truncated to integer pixels. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutDimension
				/// </java-name>
				[Dot42.DexImport("getLayoutDimension", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetLayoutDimension(int index, string defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Special version of getDimensionPixelSize for retrieving android.view.ViewGroup's layout_width and layout_height attributes. This is only here for performance reasons; applications should use getDimensionPixelSize.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute dimension value multiplied by the appropriate metric and truncated to integer pixels. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutDimension
				/// </java-name>
				[Dot42.DexImport("getLayoutDimension", "(II)I", AccessFlags = 1)]
				public virtual int GetLayoutDimension(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve a fractional unit attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute fractional value multiplied by the appropriate base value, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(IIIF)F", AccessFlags = 1)]
				public virtual float GetFraction(int index, int @base, int pbase, float defValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve the resource identifier for the attribute at  <b>index</b>. Note that attribute resource as resolved when the overall TypedArray object is retrieved. As a result, this function will return the resource identifier of the final resource value that was found,  <b>not</b> necessarily the original resource that was specified by the attribute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Attribute resource identifier, or defValue if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getResourceId
				/// </java-name>
				[Dot42.DexImport("getResourceId", "(II)I", AccessFlags = 1)]
				public virtual int GetResourceId(int index, int defValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve the Drawable for the attribute at  <b>index</b>. This gets the resource ID of the selected attribute, and uses Resources.getDrawable of the owning Resources object to retrieve its Drawable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Drawable for the attribute, or null if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable GetDrawable(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Retrieve the CharSequence[] for the attribute at  <b>index</b>. This gets the resource ID of the selected attribute, and uses Resources.getTextArray of the owning Resources object to retrieve its String[].</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence[] for the attribute, or null if not defined. </para>
				/// </returns>
				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetTextArray(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				///  <para>Retrieve the raw TypedValue for the attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the value was retrieved, else false. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(ILandroid/util/TypedValue;)Z", AccessFlags = 1)]
				public virtual bool GetValue(int index, global::Android.Util.TypedValue outValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Determines whether there is an attribute at  <b>index</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the attribute has a value, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasValue
				/// </java-name>
				[Dot42.DexImport("hasValue", "(I)Z", AccessFlags = 1)]
				public virtual bool HasValue(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieve the raw TypedValue for the attribute at  <b>index</b> and return a temporary object holding its data. This object is only valid until the next call on to TypedArray.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a TypedValue object if the attribute is defined, containing its data; otherwise returns null. (You will not receive a TypedValue whose type is TYPE_NULL.) </para>
				/// </returns>
				/// <java-name>
				/// peekValue
				/// </java-name>
				[Dot42.DexImport("peekValue", "(I)Landroid/util/TypedValue;", AccessFlags = 1)]
				public virtual global::Android.Util.TypedValue PeekValue(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.TypedValue);
				}

				/// <summary>
				///  <para>Give back a previously retrieved array, for later re-use. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public virtual void Recycle() /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Return the number of indices in the array that actually have data. </para>        
				/// </summary>
				/// <java-name>
				/// getIndexCount
				/// </java-name>
				public virtual int IndexCount
				{
						[Dot42.DexImport("getIndexCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the Resources object this array was loaded from. </para>        
				/// </summary>
				/// <java-name>
				/// getResources
				/// </java-name>
				public virtual global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <summary>
				///  <para>Returns a message about the parser state suitable for printing error messages. </para>        
				/// </summary>
				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				public virtual string PositionDescription
				{
						[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

