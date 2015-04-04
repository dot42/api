#pragma warning disable 1717
namespace Android.Content.Res
{
		/// <java-name>
		/// android/content/res/AssetFileDescriptor
		/// </java-name>
		[Dot42.DexImport("android/content/res/AssetFileDescriptor", AccessFlags = 33)]
		public partial class AssetFileDescriptor : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
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
				[Dot42.DexImport("<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V", AccessFlags = 1)]
				public AssetFileDescriptor(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParcelFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor GetParcelFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
				public virtual global::Java.Io.FileDescriptor GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <java-name>
				/// getStartOffset
				/// </java-name>
				[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
				public virtual long GetStartOffset() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()J", AccessFlags = 1)]
				public virtual long GetLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getDeclaredLength
				/// </java-name>
				[Dot42.DexImport("getDeclaredLength", "()J", AccessFlags = 1)]
				public virtual long GetDeclaredLength() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// createInputStream
				/// </java-name>
				[Dot42.DexImport("createInputStream", "()Ljava/io/FileInputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.FileInputStream CreateInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileInputStream);
				}

				/// <java-name>
				/// createOutputStream
				/// </java-name>
				[Dot42.DexImport("createOutputStream", "()Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.FileOutputStream CreateOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileOutputStream);
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AssetFileDescriptor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getParcelFileDescriptor
				/// </java-name>
				public global::Android.OS.ParcelFileDescriptor ParcelFileDescriptor
				{
				[Dot42.DexImport("getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
						get{ return GetParcelFileDescriptor(); }
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public global::Java.Io.FileDescriptor FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return GetFileDescriptor(); }
				}

				/// <java-name>
				/// getStartOffset
				/// </java-name>
				public long StartOffset
				{
				[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
						get{ return GetStartOffset(); }
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public long Length
				{
				[Dot42.DexImport("getLength", "()J", AccessFlags = 1)]
						get{ return GetLength(); }
				}

				/// <java-name>
				/// getDeclaredLength
				/// </java-name>
				public long DeclaredLength
				{
				[Dot42.DexImport("getDeclaredLength", "()J", AccessFlags = 1)]
						get{ return GetDeclaredLength(); }
				}

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
						[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
						public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
						public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
						public override void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public override void Write(byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
						public override void Write(int int32) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AutoCloseOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
						public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
						public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
						public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
						public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// skip
						/// </java-name>
						[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
						public override long Skip(long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// mark
						/// </java-name>
						[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
						public override void Mark(int int32) /* MethodBuilder.Create */ 
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
						internal AutoCloseInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/content/res/AssetManager
		/// </java-name>
		[Dot42.DexImport("android/content/res/AssetManager", AccessFlags = 49)]
		public sealed partial class AssetManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACCESS_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ACCESS_UNKNOWN", "I", AccessFlags = 25)]
				public const int ACCESS_UNKNOWN = 0;
				/// <java-name>
				/// ACCESS_RANDOM
				/// </java-name>
				[Dot42.DexImport("ACCESS_RANDOM", "I", AccessFlags = 25)]
				public const int ACCESS_RANDOM = 1;
				/// <java-name>
				/// ACCESS_STREAMING
				/// </java-name>
				[Dot42.DexImport("ACCESS_STREAMING", "I", AccessFlags = 25)]
				public const int ACCESS_STREAMING = 2;
				/// <java-name>
				/// ACCESS_BUFFER
				/// </java-name>
				[Dot42.DexImport("ACCESS_BUFFER", "I", AccessFlags = 25)]
				public const int ACCESS_BUFFER = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AssetManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.Io.InputStream Open(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;I)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.Io.InputStream Open(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openFd
				/// </java-name>
				[Dot42.DexImport("openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenFd(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 273)]
				public string[] List(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openNonAssetFd
				/// </java-name>
				[Dot42.DexImport("openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenNonAssetFd(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openNonAssetFd
				/// </java-name>
				[Dot42.DexImport("openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenNonAssetFd(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openXmlResourceParser
				/// </java-name>
				[Dot42.DexImport("openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;", AccessFlags = 17)]
				public global::Android.Content.Res.IXmlResourceParser OpenXmlResourceParser(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// openXmlResourceParser
				/// </java-name>
				[Dot42.DexImport("openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;", AccessFlags = 17)]
				public global::Android.Content.Res.IXmlResourceParser OpenXmlResourceParser(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AssetManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocales
				/// </java-name>
				[Dot42.DexImport("getLocales", "()[Ljava/lang/String;", AccessFlags = 273)]
				public string[] GetLocales() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getLocales
				/// </java-name>
				public string[] Locales
				{
				[Dot42.DexImport("getLocales", "()[Ljava/lang/String;", AccessFlags = 273)]
						get{ return GetLocales(); }
				}

				/// <java-name>
				/// android/content/res/AssetManager$AssetInputStream
				/// </java-name>
				[Dot42.DexImport("android/content/res/AssetManager$AssetInputStream", AccessFlags = 17)]
				public sealed partial class AssetInputStream : global::Java.Io.InputStream
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
						/// getAssetInt
						/// </java-name>
						[Dot42.DexImport("getAssetInt", "()I", AccessFlags = 17)]
						public int GetAssetInt() /* MethodBuilder.Create */ 
						{
								return default(int);
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
						public override void Mark(int int32) /* MethodBuilder.Create */ 
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
						[Dot42.DexImport("read", "([B)I", AccessFlags = 17)]
						public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
						public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 17)]
						public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// read
						/// </java-name>
						[Dot42.DexImport("read", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
						public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// skip
						/// </java-name>
						[Dot42.DexImport("skip", "(J)J", AccessFlags = 17)]
						public override long Skip(long int64) /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <java-name>
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~AssetInputStream() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AssetInputStream() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getAssetInt
						/// </java-name>
						public int AssetInt
						{
						[Dot42.DexImport("getAssetInt", "()I", AccessFlags = 17)]
								get{ return GetAssetInt(); }
						}

				}

		}

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
				[Dot42.DexImport("<init>", "([[I[I)V", AccessFlags = 1)]
				public ColorStateList(int[][] int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList ValueOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// createFromXml
				/// </java-name>
				[Dot42.DexImport("createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/content/r" +
    "es/ColorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList CreateFromXml(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// withAlpha
				/// </java-name>
				[Dot42.DexImport("withAlpha", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList WithAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public virtual bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getColorForState
				/// </java-name>
				[Dot42.DexImport("getColorForState", "([II)I", AccessFlags = 1)]
				public virtual int GetColorForState(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaultColor
				/// </java-name>
				[Dot42.DexImport("getDefaultColor", "()I", AccessFlags = 1)]
				public virtual int GetDefaultColor() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ColorStateList() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultColor
				/// </java-name>
				public int DefaultColor
				{
				[Dot42.DexImport("getDefaultColor", "()I", AccessFlags = 1)]
						get{ return GetDefaultColor(); }
				}

		}

		/// <java-name>
		/// android/content/res/Configuration
		/// </java-name>
		[Dot42.DexImport("android/content/res/Configuration", AccessFlags = 49, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Comparable<Landroid/content/r" +
    "es/Configuration;>;")]
		public sealed partial class Configuration : global::Android.OS.IParcelable, global::System.IComparable<global::Android.Content.Res.Configuration>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// fontScale
				/// </java-name>
				[Dot42.DexImport("fontScale", "F", AccessFlags = 1)]
				public float FontScale;
				/// <java-name>
				/// mcc
				/// </java-name>
				[Dot42.DexImport("mcc", "I", AccessFlags = 1)]
				public int Mcc;
				/// <java-name>
				/// mnc
				/// </java-name>
				[Dot42.DexImport("mnc", "I", AccessFlags = 1)]
				public int Mnc;
				/// <java-name>
				/// locale
				/// </java-name>
				[Dot42.DexImport("locale", "Ljava/util/Locale;", AccessFlags = 1)]
				public global::Java.Util.Locale Locale;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_MASK
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_MASK", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_MASK = 15;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_UNDEFINED = 0;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_SMALL
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_SMALL", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_SMALL = 1;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_NORMAL
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_NORMAL", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_NORMAL = 2;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_LARGE
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_LARGE", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_LARGE = 3;
				/// <java-name>
				/// SCREENLAYOUT_SIZE_XLARGE
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_SIZE_XLARGE", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_SIZE_XLARGE = 4;
				/// <java-name>
				/// SCREENLAYOUT_LONG_MASK
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_MASK", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_MASK = 48;
				/// <java-name>
				/// SCREENLAYOUT_LONG_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_UNDEFINED = 0;
				/// <java-name>
				/// SCREENLAYOUT_LONG_NO
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_NO", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_NO = 16;
				/// <java-name>
				/// SCREENLAYOUT_LONG_YES
				/// </java-name>
				[Dot42.DexImport("SCREENLAYOUT_LONG_YES", "I", AccessFlags = 25)]
				public const int SCREENLAYOUT_LONG_YES = 32;
				/// <java-name>
				/// screenLayout
				/// </java-name>
				[Dot42.DexImport("screenLayout", "I", AccessFlags = 1)]
				public int ScreenLayout;
				/// <java-name>
				/// TOUCHSCREEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_UNDEFINED = 0;
				/// <java-name>
				/// TOUCHSCREEN_NOTOUCH
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_NOTOUCH", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_NOTOUCH = 1;
				/// <java-name>
				/// TOUCHSCREEN_STYLUS
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_STYLUS", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_STYLUS = 2;
				/// <java-name>
				/// TOUCHSCREEN_FINGER
				/// </java-name>
				[Dot42.DexImport("TOUCHSCREEN_FINGER", "I", AccessFlags = 25)]
				public const int TOUCHSCREEN_FINGER = 3;
				/// <java-name>
				/// touchscreen
				/// </java-name>
				[Dot42.DexImport("touchscreen", "I", AccessFlags = 1)]
				public int Touchscreen;
				/// <java-name>
				/// KEYBOARD_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_UNDEFINED", "I", AccessFlags = 25)]
				public const int KEYBOARD_UNDEFINED = 0;
				/// <java-name>
				/// KEYBOARD_NOKEYS
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_NOKEYS", "I", AccessFlags = 25)]
				public const int KEYBOARD_NOKEYS = 1;
				/// <java-name>
				/// KEYBOARD_QWERTY
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_QWERTY", "I", AccessFlags = 25)]
				public const int KEYBOARD_QWERTY = 2;
				/// <java-name>
				/// KEYBOARD_12KEY
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_12KEY", "I", AccessFlags = 25)]
				public const int KEYBOARD_12KEY = 3;
				/// <java-name>
				/// keyboard
				/// </java-name>
				[Dot42.DexImport("keyboard", "I", AccessFlags = 1)]
				public int Keyboard;
				/// <java-name>
				/// KEYBOARDHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_UNDEFINED = 0;
				/// <java-name>
				/// KEYBOARDHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_NO", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_NO = 1;
				/// <java-name>
				/// KEYBOARDHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("KEYBOARDHIDDEN_YES", "I", AccessFlags = 25)]
				public const int KEYBOARDHIDDEN_YES = 2;
				/// <java-name>
				/// keyboardHidden
				/// </java-name>
				[Dot42.DexImport("keyboardHidden", "I", AccessFlags = 1)]
				public int KeyboardHidden;
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_UNDEFINED = 0;
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_NO", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_NO = 1;
				/// <java-name>
				/// HARDKEYBOARDHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("HARDKEYBOARDHIDDEN_YES", "I", AccessFlags = 25)]
				public const int HARDKEYBOARDHIDDEN_YES = 2;
				/// <java-name>
				/// hardKeyboardHidden
				/// </java-name>
				[Dot42.DexImport("hardKeyboardHidden", "I", AccessFlags = 1)]
				public int HardKeyboardHidden;
				/// <java-name>
				/// NAVIGATION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_UNDEFINED", "I", AccessFlags = 25)]
				public const int NAVIGATION_UNDEFINED = 0;
				/// <java-name>
				/// NAVIGATION_NONAV
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_NONAV", "I", AccessFlags = 25)]
				public const int NAVIGATION_NONAV = 1;
				/// <java-name>
				/// NAVIGATION_DPAD
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_DPAD", "I", AccessFlags = 25)]
				public const int NAVIGATION_DPAD = 2;
				/// <java-name>
				/// NAVIGATION_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_TRACKBALL", "I", AccessFlags = 25)]
				public const int NAVIGATION_TRACKBALL = 3;
				/// <java-name>
				/// NAVIGATION_WHEEL
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_WHEEL", "I", AccessFlags = 25)]
				public const int NAVIGATION_WHEEL = 4;
				/// <java-name>
				/// navigation
				/// </java-name>
				[Dot42.DexImport("navigation", "I", AccessFlags = 1)]
				public int Navigation;
				/// <java-name>
				/// NAVIGATIONHIDDEN_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_UNDEFINED", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_UNDEFINED = 0;
				/// <java-name>
				/// NAVIGATIONHIDDEN_NO
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_NO", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_NO = 1;
				/// <java-name>
				/// NAVIGATIONHIDDEN_YES
				/// </java-name>
				[Dot42.DexImport("NAVIGATIONHIDDEN_YES", "I", AccessFlags = 25)]
				public const int NAVIGATIONHIDDEN_YES = 2;
				/// <java-name>
				/// navigationHidden
				/// </java-name>
				[Dot42.DexImport("navigationHidden", "I", AccessFlags = 1)]
				public int NavigationHidden;
				/// <java-name>
				/// ORIENTATION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNDEFINED", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNDEFINED = 0;
				/// <java-name>
				/// ORIENTATION_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_PORTRAIT", "I", AccessFlags = 25)]
				public const int ORIENTATION_PORTRAIT = 1;
				/// <java-name>
				/// ORIENTATION_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_LANDSCAPE", "I", AccessFlags = 25)]
				public const int ORIENTATION_LANDSCAPE = 2;
				/// <java-name>
				/// ORIENTATION_SQUARE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_SQUARE", "I", AccessFlags = 25)]
				public const int ORIENTATION_SQUARE = 3;
				/// <java-name>
				/// orientation
				/// </java-name>
				[Dot42.DexImport("orientation", "I", AccessFlags = 1)]
				public int Orientation;
				/// <java-name>
				/// UI_MODE_TYPE_MASK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_MASK", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_MASK = 15;
				/// <java-name>
				/// UI_MODE_TYPE_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_UNDEFINED", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_UNDEFINED = 0;
				/// <java-name>
				/// UI_MODE_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_NORMAL = 1;
				/// <java-name>
				/// UI_MODE_TYPE_DESK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_DESK", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_DESK = 2;
				/// <java-name>
				/// UI_MODE_TYPE_CAR
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_CAR", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_CAR = 3;
				/// <java-name>
				/// UI_MODE_TYPE_TELEVISION
				/// </java-name>
				[Dot42.DexImport("UI_MODE_TYPE_TELEVISION", "I", AccessFlags = 25)]
				public const int UI_MODE_TYPE_TELEVISION = 4;
				/// <java-name>
				/// UI_MODE_NIGHT_MASK
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_MASK", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_MASK = 48;
				/// <java-name>
				/// UI_MODE_NIGHT_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_UNDEFINED", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_UNDEFINED = 0;
				/// <java-name>
				/// UI_MODE_NIGHT_NO
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_NO", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_NO = 16;
				/// <java-name>
				/// UI_MODE_NIGHT_YES
				/// </java-name>
				[Dot42.DexImport("UI_MODE_NIGHT_YES", "I", AccessFlags = 25)]
				public const int UI_MODE_NIGHT_YES = 32;
				/// <java-name>
				/// uiMode
				/// </java-name>
				[Dot42.DexImport("uiMode", "I", AccessFlags = 1)]
				public int UiMode;
				/// <java-name>
				/// SCREEN_WIDTH_DP_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREEN_WIDTH_DP_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREEN_WIDTH_DP_UNDEFINED = 0;
				/// <java-name>
				/// screenWidthDp
				/// </java-name>
				[Dot42.DexImport("screenWidthDp", "I", AccessFlags = 1)]
				public int ScreenWidthDp;
				/// <java-name>
				/// SCREEN_HEIGHT_DP_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SCREEN_HEIGHT_DP_UNDEFINED", "I", AccessFlags = 25)]
				public const int SCREEN_HEIGHT_DP_UNDEFINED = 0;
				/// <java-name>
				/// screenHeightDp
				/// </java-name>
				[Dot42.DexImport("screenHeightDp", "I", AccessFlags = 1)]
				public int ScreenHeightDp;
				/// <java-name>
				/// SMALLEST_SCREEN_WIDTH_DP_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("SMALLEST_SCREEN_WIDTH_DP_UNDEFINED", "I", AccessFlags = 25)]
				public const int SMALLEST_SCREEN_WIDTH_DP_UNDEFINED = 0;
				/// <java-name>
				/// smallestScreenWidthDp
				/// </java-name>
				[Dot42.DexImport("smallestScreenWidthDp", "I", AccessFlags = 1)]
				public int SmallestScreenWidthDp;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Res.Configuration> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Configuration() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public Configuration(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLayoutSizeAtLeast
				/// </java-name>
				[Dot42.DexImport("isLayoutSizeAtLeast", "(I)Z", AccessFlags = 1)]
				public bool IsLayoutSizeAtLeast(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public void SetTo(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
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
				/// setToDefaults
				/// </java-name>
				[Dot42.DexImport("setToDefaults", "()V", AccessFlags = 1)]
				public void SetToDefaults() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateFrom
				/// </java-name>
				[Dot42.DexImport("updateFrom", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int UpdateFrom(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// diff
				/// </java-name>
				[Dot42.DexImport("diff", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int Diff(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// needNewResources
				/// </java-name>
				[Dot42.DexImport("needNewResources", "(II)Z", AccessFlags = 9)]
				public static bool NeedNewResources(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
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

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/content/res/Configuration;)I", AccessFlags = 1)]
				public int CompareTo(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Landroid/content/res/Configuration;)Z", AccessFlags = 1)]
				public bool Equals(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
						return default(bool);
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

		}

		/// <java-name>
		/// android/content/res/XmlResourceParser
		/// </java-name>
		[Dot42.DexImport("android/content/res/XmlResourceParser", AccessFlags = 1537)]
		public partial interface IXmlResourceParser : global::Org.Xmlpull.V1.IXmlPullParser, global::Android.Util.IAttributeSet
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/res/ObbInfo
		/// </java-name>
		[Dot42.DexImport("android/content/res/ObbInfo", AccessFlags = 33)]
		public partial class ObbInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OBB_OVERLAY
				/// </java-name>
				[Dot42.DexImport("OBB_OVERLAY", "I", AccessFlags = 25)]
				public const int OBB_OVERLAY = 1;
				/// <java-name>
				/// filename
				/// </java-name>
				[Dot42.DexImport("filename", "Ljava/lang/String;", AccessFlags = 1)]
				public string Filename;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// version
				/// </java-name>
				[Dot42.DexImport("version", "I", AccessFlags = 1)]
				public int Version;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Res.ObbInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ObbInfo() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/res/ObbScanner
		/// </java-name>
		[Dot42.DexImport("android/content/res/ObbScanner", AccessFlags = 33)]
		public partial class ObbScanner
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ObbScanner() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getObbInfo
				/// </java-name>
				[Dot42.DexImport("getObbInfo", "(Ljava/lang/String;)Landroid/content/res/ObbInfo;", AccessFlags = 9)]
				public static global::Android.Content.Res.ObbInfo GetObbInfo(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ObbInfo);
				}

		}

		/// <java-name>
		/// android/content/res/Resources
		/// </java-name>
		[Dot42.DexImport("android/content/res/Resources", AccessFlags = 33)]
		public partial class Resources
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/" +
    "res/Configuration;)V", AccessFlags = 1)]
				public Resources(global::Android.Content.Res.AssetManager assetManager, global::Android.Util.DisplayMetrics displayMetrics, global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystem
				/// </java-name>
				[Dot42.DexImport("getSystem", "()Landroid/content/res/Resources;", AccessFlags = 9)]
				public static global::Android.Content.Res.Resources GetSystem() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getQuantityText
				/// </java-name>
				[Dot42.DexImport("getQuantityText", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetQuantityText(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public virtual string GetString(int int32, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public virtual string GetQuantityString(int int32, int int321, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQuantityString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetTextArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStringArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(I)[I", AccessFlags = 1)]
				public virtual int[] GetIntArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// obtainTypedArray
				/// </java-name>
				[Dot42.DexImport("obtainTypedArray", "(I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.TypedArray ObtainTypedArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(I)F", AccessFlags = 1)]
				public virtual float GetDimension(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(I)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelOffset(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(I)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(III)F", AccessFlags = 1)]
				public virtual float GetFraction(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getDrawableForDensity
				/// </java-name>
				[Dot42.DexImport("getDrawableForDensity", "(II)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawableForDensity(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getMovie
				/// </java-name>
				[Dot42.DexImport("getMovie", "(I)Landroid/graphics/Movie;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Movie GetMovie(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(I)I", AccessFlags = 1)]
				public virtual int GetColor(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList GetColorStateList(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(I)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(I)I", AccessFlags = 1)]
				public virtual int GetInteger(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLayout
				/// </java-name>
				[Dot42.DexImport("getLayout", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetLayout(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetAnimation(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser GetXml(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(I)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream OpenRawResource(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream OpenRawResource(int int32, global::Android.Util.TypedValue typedValue) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openRawResourceFd
				/// </java-name>
				[Dot42.DexImport("openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenRawResourceFd(int int32) /* MethodBuilder.Create */ 
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
				/// getValueForDensity
				/// </java-name>
				[Dot42.DexImport("getValueForDensity", "(IILandroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public virtual void GetValueForDensity(int int32, int int321, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public virtual void GetValue(string @string, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newTheme
				/// </java-name>
				[Dot42.DexImport("newTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 17)]
				public global::Android.Content.Res.Resources.Theme NewTheme() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources.Theme);
				}

				/// <java-name>
				/// obtainAttributes
				/// </java-name>
				[Dot42.DexImport("obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.TypedArray ObtainAttributes(global::Android.Util.IAttributeSet attributeSet, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// updateConfiguration
				/// </java-name>
				[Dot42.DexImport("updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void UpdateConfiguration(global::Android.Content.Res.Configuration configuration, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
				public virtual global::Android.Util.DisplayMetrics GetDisplayMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.DisplayMetrics);
				}

				/// <java-name>
				/// getConfiguration
				/// </java-name>
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.Configuration GetConfiguration() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Configuration);
				}

				/// <java-name>
				/// getIdentifier
				/// </java-name>
				[Dot42.DexImport("getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIdentifier(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getResourceName
				/// </java-name>
				[Dot42.DexImport("getResourceName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourcePackageName
				/// </java-name>
				[Dot42.DexImport("getResourcePackageName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourcePackageName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceTypeName
				/// </java-name>
				[Dot42.DexImport("getResourceTypeName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceTypeName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceEntryName
				/// </java-name>
				[Dot42.DexImport("getResourceEntryName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetResourceEntryName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// parseBundleExtras
				/// </java-name>
				[Dot42.DexImport("parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void ParseBundleExtras(global::Android.Content.Res.IXmlResourceParser xmlResourceParser, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseBundleExtra
				/// </java-name>
				[Dot42.DexImport("parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void ParseBundleExtra(string @string, global::Android.Util.IAttributeSet attributeSet, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetManager GetAssets() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetManager);
				}

				/// <java-name>
				/// flushLayoutCache
				/// </java-name>
				[Dot42.DexImport("flushLayoutCache", "()V", AccessFlags = 17)]
				public void FlushLayoutCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishPreloading
				/// </java-name>
				[Dot42.DexImport("finishPreloading", "()V", AccessFlags = 17)]
				public void FinishPreloading() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Resources() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSystem
				/// </java-name>
				public static global::Android.Content.Res.Resources System
				{
				[Dot42.DexImport("getSystem", "()Landroid/content/res/Resources;", AccessFlags = 9)]
						get{ return GetSystem(); }
				}

				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				public global::Android.Util.DisplayMetrics DisplayMetrics
				{
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
						get{ return GetDisplayMetrics(); }
				}

				/// <java-name>
				/// getConfiguration
				/// </java-name>
				public global::Android.Content.Res.Configuration Configuration
				{
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
						get{ return GetConfiguration(); }
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 17)]
						get{ return GetAssets(); }
				}

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

						/// <java-name>
						/// applyStyle
						/// </java-name>
						[Dot42.DexImport("applyStyle", "(IZ)V", AccessFlags = 1)]
						public void ApplyStyle(int int32, bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setTo
						/// </java-name>
						[Dot42.DexImport("setTo", "(Landroid/content/res/Resources$Theme;)V", AccessFlags = 1)]
						public void SetTo(Theme theme) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int[] int32) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int int32, int[] int321) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <java-name>
						/// obtainStyledAttributes
						/// </java-name>
						[Dot42.DexImport("obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", AccessFlags = 1)]
						public global::Android.Content.Res.TypedArray ObtainStyledAttributes(global::Android.Util.IAttributeSet attributeSet, int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Res.TypedArray);
						}

						/// <java-name>
						/// resolveAttribute
						/// </java-name>
						[Dot42.DexImport("resolveAttribute", "(ILandroid/util/TypedValue;Z)Z", AccessFlags = 1)]
						public bool ResolveAttribute(int int32, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public void Dump(int int32, string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~Theme() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Theme() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndexCount
				/// </java-name>
				[Dot42.DexImport("getIndexCount", "()I", AccessFlags = 1)]
				public virtual int GetIndexCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(I)I", AccessFlags = 1)]
				public virtual int GetIndex(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.Resources GetResources() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// getNonResourceString
				/// </java-name>
				[Dot42.DexImport("getNonResourceString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNonResourceString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(IZ)Z", AccessFlags = 1)]
				public virtual bool GetBoolean(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				[Dot42.DexImport("getFloat", "(IF)F", AccessFlags = 1)]
				public virtual float GetFloat(int int32, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(II)I", AccessFlags = 1)]
				public virtual int GetColor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.ColorStateList GetColorStateList(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(II)I", AccessFlags = 1)]
				public virtual int GetInteger(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(IF)F", AccessFlags = 1)]
				public virtual float GetDimension(int int32, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(II)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelOffset(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(II)I", AccessFlags = 1)]
				public virtual int GetDimensionPixelSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLayoutDimension
				/// </java-name>
				[Dot42.DexImport("getLayoutDimension", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetLayoutDimension(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLayoutDimension
				/// </java-name>
				[Dot42.DexImport("getLayoutDimension", "(II)I", AccessFlags = 1)]
				public virtual int GetLayoutDimension(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(IIIF)F", AccessFlags = 1)]
				public virtual float GetFraction(int int32, int int321, int int322, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getResourceId
				/// </java-name>
				[Dot42.DexImport("getResourceId", "(II)I", AccessFlags = 1)]
				public virtual int GetResourceId(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetTextArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(ILandroid/util/TypedValue;)Z", AccessFlags = 1)]
				public virtual bool GetValue(int int32, global::Android.Util.TypedValue typedValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasValue
				/// </java-name>
				[Dot42.DexImport("hasValue", "(I)Z", AccessFlags = 1)]
				public virtual bool HasValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// peekValue
				/// </java-name>
				[Dot42.DexImport("peekValue", "(I)Landroid/util/TypedValue;", AccessFlags = 1)]
				public virtual global::Android.Util.TypedValue PeekValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.TypedValue);
				}

				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPositionDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

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

				/// <java-name>
				/// getIndexCount
				/// </java-name>
				public int IndexCount
				{
				[Dot42.DexImport("getIndexCount", "()I", AccessFlags = 1)]
						get{ return GetIndexCount(); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return GetResources(); }
				}

				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				public string PositionDescription
				{
				[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPositionDescription(); }
				}

		}

}

