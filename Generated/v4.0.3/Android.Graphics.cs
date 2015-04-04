#pragma warning disable 1717
namespace Android.Graphics
{
		/// <java-name>
		/// android/graphics/AvoidXfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/AvoidXfermode", AccessFlags = 33)]
		public partial class AvoidXfermode : global::Android.Graphics.Xfermode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V", AccessFlags = 1)]
				public AvoidXfermode(int int32, int int321, global::Android.Graphics.AvoidXfermode.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AvoidXfermode() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/graphics/AvoidXfermode$Mode
				/// </java-name>
				[Dot42.DexImport("android/graphics/AvoidXfermode$Mode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/AvoidXfermode$Mode;>;")]
				public sealed class Mode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// AVOID
						/// </java-name>
						[Dot42.DexImport("AVOID", "Landroid/graphics/AvoidXfermode$Mode;", AccessFlags = 16409)]
						public static readonly Mode AVOID;
						/// <java-name>
						/// TARGET
						/// </java-name>
						[Dot42.DexImport("TARGET", "Landroid/graphics/AvoidXfermode$Mode;", AccessFlags = 16409)]
						public static readonly Mode TARGET;
						private Mode() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/AvoidXfermode$Mode;", AccessFlags = 9)]
						public static Mode[] Values() /* MethodBuilder.Create */ 
						{
								return default(Mode[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/AvoidXfermode$Mode;", AccessFlags = 9)]
						public static Mode ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Mode);
						}

				}

		}

		/// <java-name>
		/// android/graphics/Bitmap
		/// </java-name>
		[Dot42.DexImport("android/graphics/Bitmap", AccessFlags = 49)]
		public sealed partial class Bitmap : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DENSITY_NONE
				/// </java-name>
				[Dot42.DexImport("DENSITY_NONE", "I", AccessFlags = 25)]
				public const int DENSITY_NONE = 0;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.Bitmap> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Bitmap() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
				public int GetDensity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDensity
				/// </java-name>
				[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
				public void SetDensity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRecycled
				/// </java-name>
				[Dot42.DexImport("isRecycled", "()Z", AccessFlags = 17)]
				public bool IsRecycled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getGenerationId
				/// </java-name>
				[Dot42.DexImport("getGenerationId", "()I", AccessFlags = 1)]
				public int GetGenerationId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// copyPixelsToBuffer
				/// </java-name>
				[Dot42.DexImport("copyPixelsToBuffer", "(Ljava/nio/Buffer;)V", AccessFlags = 1)]
				public void CopyPixelsToBuffer(global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyPixelsFromBuffer
				/// </java-name>
				[Dot42.DexImport("copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V", AccessFlags = 1)]
				public void CopyPixelsFromBuffer(global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap Copy(global::Android.Graphics.Bitmap.Config config, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createScaledBitmap
				/// </java-name>
				[Dot42.DexImport("createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateScaledBitmap(global::Android.Graphics.Bitmap bitmap, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(global::Android.Graphics.Bitmap bitmap, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap" +
    ";", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(global::Android.Graphics.Bitmap bitmap, int int32, int int321, int int322, int int323, global::Android.Graphics.Matrix matrix, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(int int32, int int321, global::Android.Graphics.Bitmap.Config config) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(int[] int32, int int321, int int322, int int323, int int324, global::Android.Graphics.Bitmap.Config config) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(int[] int32, int int321, int int322, global::Android.Graphics.Bitmap.Config config) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("getNinePatchChunk", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetNinePatchChunk() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("getNinePatchChunk", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetNinePatchChunk() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// compress
				/// </java-name>
				[Dot42.DexImport("compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z", AccessFlags = 1)]
				public bool Compress(global::Android.Graphics.Bitmap.CompressFormat compressFormat, int int32, global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMutable
				/// </java-name>
				[Dot42.DexImport("isMutable", "()Z", AccessFlags = 17)]
				public bool IsMutable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
				public int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 17)]
				public int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(Landroid/graphics/Canvas;)I", AccessFlags = 1)]
				public int GetScaledWidth(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(Landroid/graphics/Canvas;)I", AccessFlags = 1)]
				public int GetScaledHeight(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(Landroid/util/DisplayMetrics;)I", AccessFlags = 1)]
				public int GetScaledWidth(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(Landroid/util/DisplayMetrics;)I", AccessFlags = 1)]
				public int GetScaledHeight(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(I)I", AccessFlags = 1)]
				public int GetScaledWidth(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(I)I", AccessFlags = 1)]
				public int GetScaledHeight(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRowBytes
				/// </java-name>
				[Dot42.DexImport("getRowBytes", "()I", AccessFlags = 17)]
				public int GetRowBytes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getByteCount
				/// </java-name>
				[Dot42.DexImport("getByteCount", "()I", AccessFlags = 17)]
				public int GetByteCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConfig
				/// </java-name>
				[Dot42.DexImport("getConfig", "()Landroid/graphics/Bitmap$Config;", AccessFlags = 17)]
				public global::Android.Graphics.Bitmap.Config GetConfig() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap.Config);
				}

				/// <java-name>
				/// hasAlpha
				/// </java-name>
				[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 17)]
				public bool HasAlpha() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setHasAlpha
				/// </java-name>
				[Dot42.DexImport("setHasAlpha", "(Z)V", AccessFlags = 1)]
				public void SetHasAlpha(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// eraseColor
				/// </java-name>
				[Dot42.DexImport("eraseColor", "(I)V", AccessFlags = 1)]
				public void EraseColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPixel
				/// </java-name>
				[Dot42.DexImport("getPixel", "(II)I", AccessFlags = 1)]
				public int GetPixel(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPixels
				/// </java-name>
				[Dot42.DexImport("getPixels", "([IIIIIII)V", AccessFlags = 1)]
				public void GetPixels(int[] int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPixel
				/// </java-name>
				[Dot42.DexImport("setPixel", "(III)V", AccessFlags = 1)]
				public void SetPixel(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPixels
				/// </java-name>
				[Dot42.DexImport("setPixels", "([IIIIIII)V", AccessFlags = 1)]
				public void SetPixels(int[] int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
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
				/// extractAlpha
				/// </java-name>
				[Dot42.DexImport("extractAlpha", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap ExtractAlpha() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// extractAlpha
				/// </java-name>
				[Dot42.DexImport("extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap ExtractAlpha(global::Android.Graphics.Paint paint, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// sameAs
				/// </java-name>
				[Dot42.DexImport("sameAs", "(Landroid/graphics/Bitmap;)Z", AccessFlags = 1)]
				public bool SameAs(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// prepareToDraw
				/// </java-name>
				[Dot42.DexImport("prepareToDraw", "()V", AccessFlags = 1)]
				public void PrepareToDraw() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				public int Density
				{
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return GetDensity(); }
				[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
						set{ SetDensity(value); }
				}

				/// <java-name>
				/// getGenerationId
				/// </java-name>
				public int GenerationId
				{
				[Dot42.DexImport("getGenerationId", "()I", AccessFlags = 1)]
						get{ return GetGenerationId(); }
				}

				/// <java-name>
				/// getNinePatchChunk
				/// </java-name>
				public byte[] NinePatchChunk
				{
				[Dot42.DexImport("getNinePatchChunk", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetNinePatchChunk(); }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 17)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getRowBytes
				/// </java-name>
				public int RowBytes
				{
				[Dot42.DexImport("getRowBytes", "()I", AccessFlags = 17)]
						get{ return GetRowBytes(); }
				}

				/// <java-name>
				/// getByteCount
				/// </java-name>
				public int ByteCount
				{
				[Dot42.DexImport("getByteCount", "()I", AccessFlags = 17)]
						get{ return GetByteCount(); }
				}

				/// <java-name>
				/// android/graphics/Bitmap$CompressFormat
				/// </java-name>
				[Dot42.DexImport("android/graphics/Bitmap$CompressFormat", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Bitmap$CompressFormat;>;")]
				public sealed class CompressFormat
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// JPEG
						/// </java-name>
						[Dot42.DexImport("JPEG", "Landroid/graphics/Bitmap$CompressFormat;", AccessFlags = 16409)]
						public static readonly CompressFormat JPEG;
						/// <java-name>
						/// PNG
						/// </java-name>
						[Dot42.DexImport("PNG", "Landroid/graphics/Bitmap$CompressFormat;", AccessFlags = 16409)]
						public static readonly CompressFormat PNG;
						/// <java-name>
						/// WEBP
						/// </java-name>
						[Dot42.DexImport("WEBP", "Landroid/graphics/Bitmap$CompressFormat;", AccessFlags = 16409)]
						public static readonly CompressFormat WEBP;
						private CompressFormat() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Bitmap$CompressFormat;", AccessFlags = 9)]
						public static CompressFormat[] Values() /* MethodBuilder.Create */ 
						{
								return default(CompressFormat[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;", AccessFlags = 9)]
						public static CompressFormat ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(CompressFormat);
						}

				}

				/// <java-name>
				/// android/graphics/Bitmap$Config
				/// </java-name>
				[Dot42.DexImport("android/graphics/Bitmap$Config", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Bitmap$Config;>;")]
				public sealed class Config
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ALPHA_8
						/// </java-name>
						[Dot42.DexImport("ALPHA_8", "Landroid/graphics/Bitmap$Config;", AccessFlags = 16409)]
						public static readonly Config ALPHA_8;
						/// <java-name>
						/// ARGB_4444
						/// </java-name>
						[Dot42.DexImport("ARGB_4444", "Landroid/graphics/Bitmap$Config;", AccessFlags = 16409)]
						public static readonly Config ARGB_4444;
						/// <java-name>
						/// ARGB_8888
						/// </java-name>
						[Dot42.DexImport("ARGB_8888", "Landroid/graphics/Bitmap$Config;", AccessFlags = 16409)]
						public static readonly Config ARGB_8888;
						/// <java-name>
						/// RGB_565
						/// </java-name>
						[Dot42.DexImport("RGB_565", "Landroid/graphics/Bitmap$Config;", AccessFlags = 16409)]
						public static readonly Config RGB_565;
						private Config() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Bitmap$Config;", AccessFlags = 9)]
						public static Config[] Values() /* MethodBuilder.Create */ 
						{
								return default(Config[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;", AccessFlags = 9)]
						public static Config ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Config);
						}

				}

		}

		/// <java-name>
		/// android/graphics/BitmapFactory
		/// </java-name>
		[Dot42.DexImport("android/graphics/BitmapFactory", AccessFlags = 33)]
		public partial class BitmapFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BitmapFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bit" +
    "map;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFile(string @string, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeResourceStream
				/// </java-name>
				[Dot42.DexImport("decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lan" +
    "droid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/B" +
    "itmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResourceStream(global::Android.Content.Res.Resources resources, global::Android.Util.TypedValue typedValue, global::Java.Io.InputStream inputStream, global::Android.Graphics.Rect rect, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeResource
				/// </java-name>
				[Dot42.DexImport("decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroi" +
    "d/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResource(global::Android.Content.Res.Resources resources, int int32, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeResource
				/// </java-name>
				[Dot42.DexImport("decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResource(global::Android.Content.Res.Resources resources, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(sbyte[] sByte, int int32, int int321, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(byte[] @byte, int int32, int int321, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Bitmap;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Opti" +
    "ons;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeStream(global::Java.Io.InputStream inputStream, global::Android.Graphics.Rect rect, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$O" +
    "ptions;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFileDescriptor(global::Java.Io.FileDescriptor fileDescriptor, global::Android.Graphics.Rect rect, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// decodeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFileDescriptor(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// android/graphics/BitmapFactory$Options
				/// </java-name>
				[Dot42.DexImport("android/graphics/BitmapFactory$Options", AccessFlags = 9)]
				public partial class Options
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// inBitmap
						/// </java-name>
						[Dot42.DexImport("inBitmap", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap InBitmap;
						/// <java-name>
						/// inMutable
						/// </java-name>
						[Dot42.DexImport("inMutable", "Z", AccessFlags = 1)]
						public bool InMutable;
						/// <java-name>
						/// inJustDecodeBounds
						/// </java-name>
						[Dot42.DexImport("inJustDecodeBounds", "Z", AccessFlags = 1)]
						public bool InJustDecodeBounds;
						/// <java-name>
						/// inSampleSize
						/// </java-name>
						[Dot42.DexImport("inSampleSize", "I", AccessFlags = 1)]
						public int InSampleSize;
						/// <java-name>
						/// inPreferredConfig
						/// </java-name>
						[Dot42.DexImport("inPreferredConfig", "Landroid/graphics/Bitmap$Config;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap.Config InPreferredConfig;
						/// <java-name>
						/// inDither
						/// </java-name>
						[Dot42.DexImport("inDither", "Z", AccessFlags = 1)]
						public bool InDither;
						/// <java-name>
						/// inDensity
						/// </java-name>
						[Dot42.DexImport("inDensity", "I", AccessFlags = 1)]
						public int InDensity;
						/// <java-name>
						/// inTargetDensity
						/// </java-name>
						[Dot42.DexImport("inTargetDensity", "I", AccessFlags = 1)]
						public int InTargetDensity;
						/// <java-name>
						/// inScreenDensity
						/// </java-name>
						[Dot42.DexImport("inScreenDensity", "I", AccessFlags = 1)]
						public int InScreenDensity;
						/// <java-name>
						/// inScaled
						/// </java-name>
						[Dot42.DexImport("inScaled", "Z", AccessFlags = 1)]
						public bool InScaled;
						/// <java-name>
						/// inPurgeable
						/// </java-name>
						[Dot42.DexImport("inPurgeable", "Z", AccessFlags = 1)]
						public bool InPurgeable;
						/// <java-name>
						/// inInputShareable
						/// </java-name>
						[Dot42.DexImport("inInputShareable", "Z", AccessFlags = 1)]
						public bool InInputShareable;
						/// <java-name>
						/// inPreferQualityOverSpeed
						/// </java-name>
						[Dot42.DexImport("inPreferQualityOverSpeed", "Z", AccessFlags = 1)]
						public bool InPreferQualityOverSpeed;
						/// <java-name>
						/// outWidth
						/// </java-name>
						[Dot42.DexImport("outWidth", "I", AccessFlags = 1)]
						public int OutWidth;
						/// <java-name>
						/// outHeight
						/// </java-name>
						[Dot42.DexImport("outHeight", "I", AccessFlags = 1)]
						public int OutHeight;
						/// <java-name>
						/// outMimeType
						/// </java-name>
						[Dot42.DexImport("outMimeType", "Ljava/lang/String;", AccessFlags = 1)]
						public string OutMimeType;
						/// <java-name>
						/// inTempStorage
						/// </java-name>
						[Dot42.DexImport("inTempStorage", "[B", AccessFlags = 1)]
						public sbyte[] InTempStorage;
						/// <java-name>
						/// mCancel
						/// </java-name>
						[Dot42.DexImport("mCancel", "Z", AccessFlags = 1)]
						public bool MCancel;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Options() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// requestCancelDecode
						/// </java-name>
						[Dot42.DexImport("requestCancelDecode", "()V", AccessFlags = 1)]
						public virtual void RequestCancelDecode() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/graphics/BitmapRegionDecoder
		/// </java-name>
		[Dot42.DexImport("android/graphics/BitmapRegionDecoder", AccessFlags = 49)]
		public sealed partial class BitmapRegionDecoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BitmapRegionDecoder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([BIIZ)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(sbyte[] sByte, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([BIIZ)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(byte[] @byte, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/io/FileDescriptor;Z)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(global::Java.Io.FileDescriptor fileDescriptor, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/io/InputStream;Z)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(global::Java.Io.InputStream inputStream, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Z)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// decodeRegion
				/// </java-name>
				[Dot42.DexImport("decodeRegion", "(Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphic" +
    "s/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap DecodeRegion(global::Android.Graphics.Rect rect, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
				public int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRecycled
				/// </java-name>
				[Dot42.DexImport("isRecycled", "()Z", AccessFlags = 17)]
				public bool IsRecycled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~BitmapRegionDecoder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/BitmapShader
		/// </java-name>
		[Dot42.DexImport("android/graphics/BitmapShader", AccessFlags = 33)]
		public partial class BitmapShader : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Sha" +
    "der$TileMode;)V", AccessFlags = 1)]
				public BitmapShader(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Shader.TileMode tileMode, global::Android.Graphics.Shader.TileMode tileMode1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BitmapShader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/BlurMaskFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/BlurMaskFilter", AccessFlags = 33)]
		public partial class BlurMaskFilter : global::Android.Graphics.MaskFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V", AccessFlags = 1)]
				public BlurMaskFilter(float single, global::Android.Graphics.BlurMaskFilter.Blur blur) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BlurMaskFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/graphics/BlurMaskFilter$Blur
				/// </java-name>
				[Dot42.DexImport("android/graphics/BlurMaskFilter$Blur", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/BlurMaskFilter$Blur;>;")]
				public sealed class Blur
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// INNER
						/// </java-name>
						[Dot42.DexImport("INNER", "Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 16409)]
						public static readonly Blur INNER;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 16409)]
						public static readonly Blur NORMAL;
						/// <java-name>
						/// OUTER
						/// </java-name>
						[Dot42.DexImport("OUTER", "Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 16409)]
						public static readonly Blur OUTER;
						/// <java-name>
						/// SOLID
						/// </java-name>
						[Dot42.DexImport("SOLID", "Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 16409)]
						public static readonly Blur SOLID;
						private Blur() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 9)]
						public static Blur[] Values() /* MethodBuilder.Create */ 
						{
								return default(Blur[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/BlurMaskFilter$Blur;", AccessFlags = 9)]
						public static Blur ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Blur);
						}

				}

		}

		/// <java-name>
		/// android/graphics/Camera
		/// </java-name>
		[Dot42.DexImport("android/graphics/Camera", AccessFlags = 33)]
		public partial class Camera
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Camera() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "()V", AccessFlags = 257)]
				public virtual void Save() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "()V", AccessFlags = 257)]
				public virtual void Restore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FFF)V", AccessFlags = 257)]
				public virtual void Translate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotateX
				/// </java-name>
				[Dot42.DexImport("rotateX", "(F)V", AccessFlags = 257)]
				public virtual void RotateX(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotateY
				/// </java-name>
				[Dot42.DexImport("rotateY", "(F)V", AccessFlags = 257)]
				public virtual void RotateY(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotateZ
				/// </java-name>
				[Dot42.DexImport("rotateZ", "(F)V", AccessFlags = 257)]
				public virtual void RotateZ(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFF)V", AccessFlags = 257)]
				public virtual void Rotate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocation
				/// </java-name>
				[Dot42.DexImport("setLocation", "(FFF)V", AccessFlags = 257)]
				public virtual void SetLocation(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void GetMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyToCanvas
				/// </java-name>
				[Dot42.DexImport("applyToCanvas", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void ApplyToCanvas(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dotWithNormal
				/// </java-name>
				[Dot42.DexImport("dotWithNormal", "(FFF)F", AccessFlags = 257)]
				public virtual float DotWithNormal(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Camera() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/Canvas
		/// </java-name>
		[Dot42.DexImport("android/graphics/Canvas", AccessFlags = 33)]
		public partial class Canvas
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MATRIX_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("MATRIX_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int MATRIX_SAVE_FLAG = 1;
				/// <java-name>
				/// CLIP_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("CLIP_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int CLIP_SAVE_FLAG = 2;
				/// <java-name>
				/// HAS_ALPHA_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("HAS_ALPHA_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int HAS_ALPHA_LAYER_SAVE_FLAG = 4;
				/// <java-name>
				/// FULL_COLOR_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("FULL_COLOR_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int FULL_COLOR_LAYER_SAVE_FLAG = 8;
				/// <java-name>
				/// CLIP_TO_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("CLIP_TO_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int CLIP_TO_LAYER_SAVE_FLAG = 16;
				/// <java-name>
				/// ALL_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("ALL_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int ALL_SAVE_FLAG = 31;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Canvas() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public Canvas(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isHardwareAccelerated
				/// </java-name>
				[Dot42.DexImport("isHardwareAccelerated", "()Z", AccessFlags = 1)]
				public virtual bool IsHardwareAccelerated() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 257)]
				public virtual bool IsOpaque() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
				public virtual int GetDensity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDensity
				/// </java-name>
				[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
				public virtual void SetDensity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaximumBitmapWidth
				/// </java-name>
				[Dot42.DexImport("getMaximumBitmapWidth", "()I", AccessFlags = 1)]
				public virtual int GetMaximumBitmapWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaximumBitmapHeight
				/// </java-name>
				[Dot42.DexImport("getMaximumBitmapHeight", "()I", AccessFlags = 1)]
				public virtual int GetMaximumBitmapHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "()I", AccessFlags = 257)]
				public virtual int Save() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(I)I", AccessFlags = 257)]
				public virtual int Save(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// saveLayer
				/// </java-name>
				[Dot42.DexImport("saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I", AccessFlags = 1)]
				public virtual int SaveLayer(global::Android.Graphics.RectF rectF, global::Android.Graphics.Paint paint, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// saveLayer
				/// </java-name>
				[Dot42.DexImport("saveLayer", "(FFFFLandroid/graphics/Paint;I)I", AccessFlags = 1)]
				public virtual int SaveLayer(float single, float single1, float single2, float single3, global::Android.Graphics.Paint paint, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// saveLayerAlpha
				/// </java-name>
				[Dot42.DexImport("saveLayerAlpha", "(Landroid/graphics/RectF;II)I", AccessFlags = 1)]
				public virtual int SaveLayerAlpha(global::Android.Graphics.RectF rectF, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// saveLayerAlpha
				/// </java-name>
				[Dot42.DexImport("saveLayerAlpha", "(FFFFII)I", AccessFlags = 1)]
				public virtual int SaveLayerAlpha(float single, float single1, float single2, float single3, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "()V", AccessFlags = 257)]
				public virtual void Restore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSaveCount
				/// </java-name>
				[Dot42.DexImport("getSaveCount", "()I", AccessFlags = 257)]
				public virtual int GetSaveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// restoreToCount
				/// </java-name>
				[Dot42.DexImport("restoreToCount", "(I)V", AccessFlags = 257)]
				public virtual void RestoreToCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FF)V", AccessFlags = 257)]
				public virtual void Translate(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 257)]
				public virtual void Scale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFFF)V", AccessFlags = 17)]
				public void Scale(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 257)]
				public virtual void Rotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFF)V", AccessFlags = 17)]
				public void Rotate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skew
				/// </java-name>
				[Dot42.DexImport("skew", "(FF)V", AccessFlags = 257)]
				public virtual void Skew(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void Concat(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMatrix
				/// </java-name>
				[Dot42.DexImport("setMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void SetMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void GetMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 17)]
				public global::Android.Graphics.Matrix GetMatrix() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Matrix);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/RectF;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRect(global::Android.Graphics.RectF rectF, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRect(global::Android.Graphics.Rect rect, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 257)]
				public virtual bool ClipRect(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 257)]
				public virtual bool ClipRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(FFFFLandroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRect(float single, float single1, float single2, float single3, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(FFFF)Z", AccessFlags = 257)]
				public virtual bool ClipRect(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(IIII)Z", AccessFlags = 257)]
				public virtual bool ClipRect(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipPath
				/// </java-name>
				[Dot42.DexImport("clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipPath(global::Android.Graphics.Path path, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipPath
				/// </java-name>
				[Dot42.DexImport("clipPath", "(Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool ClipPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRegion
				/// </java-name>
				[Dot42.DexImport("clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRegion(global::Android.Graphics.Region region, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clipRegion
				/// </java-name>
				[Dot42.DexImport("clipRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool ClipRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDrawFilter
				/// </java-name>
				[Dot42.DexImport("getDrawFilter", "()Landroid/graphics/DrawFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.DrawFilter GetDrawFilter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.DrawFilter);
				}

				/// <java-name>
				/// setDrawFilter
				/// </java-name>
				[Dot42.DexImport("setDrawFilter", "(Landroid/graphics/DrawFilter;)V", AccessFlags = 1)]
				public virtual void SetDrawFilter(global::Android.Graphics.DrawFilter drawFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/RectF;Landroid/graphics/Canvas$EdgeType;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(global::Android.Graphics.RectF rectF, global::Android.Graphics.Canvas.EdgeType edgeType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/Path;Landroid/graphics/Canvas$EdgeType;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(global::Android.Graphics.Path path, global::Android.Graphics.Canvas.EdgeType edgeType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(float single, float single1, float single2, float single3, global::Android.Graphics.Canvas.EdgeType edgeType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getClipBounds
				/// </java-name>
				[Dot42.DexImport("getClipBounds", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetClipBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getClipBounds
				/// </java-name>
				[Dot42.DexImport("getClipBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
				public global::Android.Graphics.Rect GetClipBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// drawRGB
				/// </java-name>
				[Dot42.DexImport("drawRGB", "(III)V", AccessFlags = 1)]
				public virtual void DrawRGB(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawARGB
				/// </java-name>
				[Dot42.DexImport("drawARGB", "(IIII)V", AccessFlags = 1)]
				public virtual void DrawARGB(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawColor
				/// </java-name>
				[Dot42.DexImport("drawColor", "(I)V", AccessFlags = 1)]
				public virtual void DrawColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawColor
				/// </java-name>
				[Dot42.DexImport("drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public virtual void DrawColor(int int32, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPaint
				/// </java-name>
				[Dot42.DexImport("drawPaint", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPaint(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPoints
				/// </java-name>
				[Dot42.DexImport("drawPoints", "([FIILandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawPoints(float[] single, int int32, int int321, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPoints
				/// </java-name>
				[Dot42.DexImport("drawPoints", "([FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPoints(float[] single, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPoint
				/// </java-name>
				[Dot42.DexImport("drawPoint", "(FFLandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawPoint(float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawLine
				/// </java-name>
				[Dot42.DexImport("drawLine", "(FFFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawLine(float single, float single1, float single2, float single3, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawLines
				/// </java-name>
				[Dot42.DexImport("drawLines", "([FIILandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawLines(float[] single, int int32, int int321, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawLines
				/// </java-name>
				[Dot42.DexImport("drawLines", "([FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawLines(float[] single, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(global::Android.Graphics.RectF rectF, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(global::Android.Graphics.Rect rect, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(FFFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(float single, float single1, float single2, float single3, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawOval
				/// </java-name>
				[Dot42.DexImport("drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawOval(global::Android.Graphics.RectF rectF, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawCircle
				/// </java-name>
				[Dot42.DexImport("drawCircle", "(FFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawCircle(float single, float single1, float single2, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawArc
				/// </java-name>
				[Dot42.DexImport("drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawArc(global::Android.Graphics.RectF rectF, float single, float single1, bool boolean, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawRoundRect
				/// </java-name>
				[Dot42.DexImport("drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRoundRect(global::Android.Graphics.RectF rectF, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPath
				/// </java-name>
				[Dot42.DexImport("drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPath(global::Android.Graphics.Path path, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid" +
    "/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Rect rect, global::Android.Graphics.RectF rectF, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/" +
    "graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Rect rect, global::Android.Graphics.Rect rect1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "([IIIFFIIZLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(int[] int32, int int321, int int322, float single, float single1, int int323, int int324, bool boolean, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "([IIIIIIIZLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(int[] int32, int int321, int int322, int int323, int int324, int int325, int int326, bool boolean, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Matrix matrix, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawBitmapMesh
				/// </java-name>
				[Dot42.DexImport("drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmapMesh(global::Android.Graphics.Bitmap bitmap, int int32, int int321, float[] single, int int322, int[] int323, int int324, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawVertices
				/// </java-name>
				[Dot42.DexImport("drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawVertices(global::Android.Graphics.Canvas.VertexMode vertexMode, int int32, float[] single, int int321, float[] single1, int int322, int[] int323, int int324, short[] int16, int int325, int int326, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "([CIIFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(char[] @char, int int32, int int321, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(string @string, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "(Ljava/lang/String;IIFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(string @string, int int32, int int321, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "(Ljava/lang/CharSequence;IIFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(global::Java.Lang.ICharSequence charSequence, int int32, int int321, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPosText
				/// </java-name>
				[Dot42.DexImport("drawPosText", "([CII[FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPosText(char[] @char, int int32, int int321, float[] single, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPosText
				/// </java-name>
				[Dot42.DexImport("drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPosText(string @string, float[] single, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawTextOnPath
				/// </java-name>
				[Dot42.DexImport("drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawTextOnPath(char[] @char, int int32, int int321, global::Android.Graphics.Path path, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawTextOnPath
				/// </java-name>
				[Dot42.DexImport("drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawTextOnPath(string @string, global::Android.Graphics.Path path, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture, global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				public int Density
				{
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return GetDensity(); }
				[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
						set{ SetDensity(value); }
				}

				/// <java-name>
				/// getMaximumBitmapWidth
				/// </java-name>
				public int MaximumBitmapWidth
				{
				[Dot42.DexImport("getMaximumBitmapWidth", "()I", AccessFlags = 1)]
						get{ return GetMaximumBitmapWidth(); }
				}

				/// <java-name>
				/// getMaximumBitmapHeight
				/// </java-name>
				public int MaximumBitmapHeight
				{
				[Dot42.DexImport("getMaximumBitmapHeight", "()I", AccessFlags = 1)]
						get{ return GetMaximumBitmapHeight(); }
				}

				/// <java-name>
				/// getSaveCount
				/// </java-name>
				public int SaveCount
				{
				[Dot42.DexImport("getSaveCount", "()I", AccessFlags = 257)]
						get{ return GetSaveCount(); }
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				public global::Android.Graphics.Matrix Matrix
				{
				[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 17)]
						get{ return GetMatrix(); }
				[Dot42.DexImport("setMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
						set{ SetMatrix(value); }
				}

				/// <java-name>
				/// getDrawFilter
				/// </java-name>
				public global::Android.Graphics.DrawFilter DrawFilter
				{
				[Dot42.DexImport("getDrawFilter", "()Landroid/graphics/DrawFilter;", AccessFlags = 1)]
						get{ return GetDrawFilter(); }
				[Dot42.DexImport("setDrawFilter", "(Landroid/graphics/DrawFilter;)V", AccessFlags = 1)]
						set{ SetDrawFilter(value); }
				}

				/// <java-name>
				/// getClipBounds
				/// </java-name>
				public global::Android.Graphics.Rect ClipBounds
				{
				[Dot42.DexImport("getClipBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
						get{ return GetClipBounds(); }
				}

				/// <java-name>
				/// android/graphics/Canvas$VertexMode
				/// </java-name>
				[Dot42.DexImport("android/graphics/Canvas$VertexMode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Canvas$VertexMode;>;")]
				public sealed class VertexMode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TRIANGLES
						/// </java-name>
						[Dot42.DexImport("TRIANGLES", "Landroid/graphics/Canvas$VertexMode;", AccessFlags = 16409)]
						public static readonly VertexMode TRIANGLES;
						/// <java-name>
						/// TRIANGLE_FAN
						/// </java-name>
						[Dot42.DexImport("TRIANGLE_FAN", "Landroid/graphics/Canvas$VertexMode;", AccessFlags = 16409)]
						public static readonly VertexMode TRIANGLE_FAN;
						/// <java-name>
						/// TRIANGLE_STRIP
						/// </java-name>
						[Dot42.DexImport("TRIANGLE_STRIP", "Landroid/graphics/Canvas$VertexMode;", AccessFlags = 16409)]
						public static readonly VertexMode TRIANGLE_STRIP;
						private VertexMode() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Canvas$VertexMode;", AccessFlags = 9)]
						public static VertexMode[] Values() /* MethodBuilder.Create */ 
						{
								return default(VertexMode[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$VertexMode;", AccessFlags = 9)]
						public static VertexMode ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(VertexMode);
						}

				}

				/// <java-name>
				/// android/graphics/Canvas$EdgeType
				/// </java-name>
				[Dot42.DexImport("android/graphics/Canvas$EdgeType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Canvas$EdgeType;>;")]
				public sealed class EdgeType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// AA
						/// </java-name>
						[Dot42.DexImport("AA", "Landroid/graphics/Canvas$EdgeType;", AccessFlags = 16409)]
						public static readonly EdgeType AA;
						/// <java-name>
						/// BW
						/// </java-name>
						[Dot42.DexImport("BW", "Landroid/graphics/Canvas$EdgeType;", AccessFlags = 16409)]
						public static readonly EdgeType BW;
						private EdgeType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Canvas$EdgeType;", AccessFlags = 9)]
						public static EdgeType[] Values() /* MethodBuilder.Create */ 
						{
								return default(EdgeType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Canvas$EdgeType;", AccessFlags = 9)]
						public static EdgeType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(EdgeType);
						}

				}

		}

		/// <java-name>
		/// android/graphics/Color
		/// </java-name>
		[Dot42.DexImport("android/graphics/Color", AccessFlags = 33)]
		public partial class Color
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BLACK
				/// </java-name>
				[Dot42.DexImport("BLACK", "I", AccessFlags = 25)]
				public const int BLACK = -16777216;
				/// <java-name>
				/// DKGRAY
				/// </java-name>
				[Dot42.DexImport("DKGRAY", "I", AccessFlags = 25)]
				public const int DKGRAY = -12303292;
				/// <java-name>
				/// GRAY
				/// </java-name>
				[Dot42.DexImport("GRAY", "I", AccessFlags = 25)]
				public const int GRAY = -7829368;
				/// <java-name>
				/// LTGRAY
				/// </java-name>
				[Dot42.DexImport("LTGRAY", "I", AccessFlags = 25)]
				public const int LTGRAY = -3355444;
				/// <java-name>
				/// WHITE
				/// </java-name>
				[Dot42.DexImport("WHITE", "I", AccessFlags = 25)]
				public const int WHITE = -1;
				/// <java-name>
				/// RED
				/// </java-name>
				[Dot42.DexImport("RED", "I", AccessFlags = 25)]
				public const int RED = -65536;
				/// <java-name>
				/// GREEN
				/// </java-name>
				[Dot42.DexImport("GREEN", "I", AccessFlags = 25)]
				public const int GREEN = -16711936;
				/// <java-name>
				/// BLUE
				/// </java-name>
				[Dot42.DexImport("BLUE", "I", AccessFlags = 25)]
				public const int BLUE = -16776961;
				/// <java-name>
				/// YELLOW
				/// </java-name>
				[Dot42.DexImport("YELLOW", "I", AccessFlags = 25)]
				public const int YELLOW = -256;
				/// <java-name>
				/// CYAN
				/// </java-name>
				[Dot42.DexImport("CYAN", "I", AccessFlags = 25)]
				public const int CYAN = -16711681;
				/// <java-name>
				/// MAGENTA
				/// </java-name>
				[Dot42.DexImport("MAGENTA", "I", AccessFlags = 25)]
				public const int MAGENTA = -65281;
				/// <java-name>
				/// TRANSPARENT
				/// </java-name>
				[Dot42.DexImport("TRANSPARENT", "I", AccessFlags = 25)]
				public const int TRANSPARENT = 0;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Color() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// alpha
				/// </java-name>
				[Dot42.DexImport("alpha", "(I)I", AccessFlags = 9)]
				public static int Alpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// red
				/// </java-name>
				[Dot42.DexImport("red", "(I)I", AccessFlags = 9)]
				public static int Red(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// green
				/// </java-name>
				[Dot42.DexImport("green", "(I)I", AccessFlags = 9)]
				public static int Green(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// blue
				/// </java-name>
				[Dot42.DexImport("blue", "(I)I", AccessFlags = 9)]
				public static int Blue(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// rgb
				/// </java-name>
				[Dot42.DexImport("rgb", "(III)I", AccessFlags = 9)]
				public static int Rgb(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// argb
				/// </java-name>
				[Dot42.DexImport("argb", "(IIII)I", AccessFlags = 9)]
				public static int Argb(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// parseColor
				/// </java-name>
				[Dot42.DexImport("parseColor", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int ParseColor(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// RGBToHSV
				/// </java-name>
				[Dot42.DexImport("RGBToHSV", "(III[F)V", AccessFlags = 9)]
				public static void RGBToHSV(int int32, int int321, int int322, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// colorToHSV
				/// </java-name>
				[Dot42.DexImport("colorToHSV", "(I[F)V", AccessFlags = 9)]
				public static void ColorToHSV(int int32, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// HSVToColor
				/// </java-name>
				[Dot42.DexImport("HSVToColor", "([F)I", AccessFlags = 9)]
				public static int HSVToColor(float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// HSVToColor
				/// </java-name>
				[Dot42.DexImport("HSVToColor", "(I[F)I", AccessFlags = 9)]
				public static int HSVToColor(int int32, float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/graphics/ColorFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/ColorFilter", AccessFlags = 33)]
		public partial class ColorFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ColorFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ColorFilter() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/ColorMatrix
		/// </java-name>
		[Dot42.DexImport("android/graphics/ColorMatrix", AccessFlags = 33)]
		public partial class ColorMatrix
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ColorMatrix() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public ColorMatrix(float[] single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public ColorMatrix(global::Android.Graphics.ColorMatrix colorMatrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 17)]
				public float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.ColorMatrix colorMatrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "([F)V", AccessFlags = 1)]
				public virtual void Set(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetScale(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(IF)V", AccessFlags = 1)]
				public virtual void SetRotate(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConcat
				/// </java-name>
				[Dot42.DexImport("setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void SetConcat(global::Android.Graphics.ColorMatrix colorMatrix, global::Android.Graphics.ColorMatrix colorMatrix1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// preConcat
				/// </java-name>
				[Dot42.DexImport("preConcat", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void PreConcat(global::Android.Graphics.ColorMatrix colorMatrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postConcat
				/// </java-name>
				[Dot42.DexImport("postConcat", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void PostConcat(global::Android.Graphics.ColorMatrix colorMatrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSaturation
				/// </java-name>
				[Dot42.DexImport("setSaturation", "(F)V", AccessFlags = 1)]
				public virtual void SetSaturation(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRGB2YUV
				/// </java-name>
				[Dot42.DexImport("setRGB2YUV", "()V", AccessFlags = 1)]
				public virtual void SetRGB2YUV() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setYUV2RGB
				/// </java-name>
				[Dot42.DexImport("setYUV2RGB", "()V", AccessFlags = 1)]
				public virtual void SetYUV2RGB() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 17)]
						get{ return GetArray(); }
				}

		}

		/// <java-name>
		/// android/graphics/ColorMatrixColorFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/ColorMatrixColorFilter", AccessFlags = 33)]
		public partial class ColorMatrixColorFilter : global::Android.Graphics.ColorFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public ColorMatrixColorFilter(global::Android.Graphics.ColorMatrix colorMatrix) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public ColorMatrixColorFilter(float[] single) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ColorMatrixColorFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/ComposePathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/ComposePathEffect", AccessFlags = 33)]
		public partial class ComposePathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V", AccessFlags = 1)]
				public ComposePathEffect(global::Android.Graphics.PathEffect pathEffect, global::Android.Graphics.PathEffect pathEffect1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComposePathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/ComposeShader
		/// </java-name>
		[Dot42.DexImport("android/graphics/ComposeShader", AccessFlags = 33)]
		public partial class ComposeShader : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/Xfermode;)V", AccessFlags = 1)]
				public ComposeShader(global::Android.Graphics.Shader shader, global::Android.Graphics.Shader shader1, global::Android.Graphics.Xfermode xfermode) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/PorterDuff$M" +
    "ode;)V", AccessFlags = 1)]
				public ComposeShader(global::Android.Graphics.Shader shader, global::Android.Graphics.Shader shader1, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComposeShader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/CornerPathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/CornerPathEffect", AccessFlags = 33)]
		public partial class CornerPathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public CornerPathEffect(float single) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CornerPathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/DashPathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/DashPathEffect", AccessFlags = 33)]
		public partial class DashPathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([FF)V", AccessFlags = 1)]
				public DashPathEffect(float[] single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DashPathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/DiscretePathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/DiscretePathEffect", AccessFlags = 33)]
		public partial class DiscretePathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public DiscretePathEffect(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DiscretePathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/DrawFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/DrawFilter", AccessFlags = 33)]
		public partial class DrawFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrawFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~DrawFilter() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/EmbossMaskFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/EmbossMaskFilter", AccessFlags = 33)]
		public partial class EmbossMaskFilter : global::Android.Graphics.MaskFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([FFFF)V", AccessFlags = 1)]
				public EmbossMaskFilter(float[] single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EmbossMaskFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/ImageFormat
		/// </java-name>
		[Dot42.DexImport("android/graphics/ImageFormat", AccessFlags = 33)]
		public partial class ImageFormat
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNKNOWN
				/// </java-name>
				[Dot42.DexImport("UNKNOWN", "I", AccessFlags = 25)]
				public const int UNKNOWN = 0;
				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "I", AccessFlags = 25)]
				public const int RGB_565 = 4;
				/// <java-name>
				/// YV12
				/// </java-name>
				[Dot42.DexImport("YV12", "I", AccessFlags = 25)]
				public const int YV12 = 842094169;
				/// <java-name>
				/// NV16
				/// </java-name>
				[Dot42.DexImport("NV16", "I", AccessFlags = 25)]
				public const int NV16 = 16;
				/// <java-name>
				/// NV21
				/// </java-name>
				[Dot42.DexImport("NV21", "I", AccessFlags = 25)]
				public const int NV21 = 17;
				/// <java-name>
				/// YUY2
				/// </java-name>
				[Dot42.DexImport("YUY2", "I", AccessFlags = 25)]
				public const int YUY2 = 20;
				/// <java-name>
				/// JPEG
				/// </java-name>
				[Dot42.DexImport("JPEG", "I", AccessFlags = 25)]
				public const int JPEG = 256;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ImageFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBitsPerPixel
				/// </java-name>
				[Dot42.DexImport("getBitsPerPixel", "(I)I", AccessFlags = 9)]
				public static int GetBitsPerPixel(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/graphics/Interpolator
		/// </java-name>
		[Dot42.DexImport("android/graphics/Interpolator", AccessFlags = 33)]
		public partial class Interpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Interpolator(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Interpolator(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(I)V", AccessFlags = 1)]
				public virtual void Reset(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(II)V", AccessFlags = 1)]
				public virtual void Reset(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyFrameCount
				/// </java-name>
				[Dot42.DexImport("getKeyFrameCount", "()I", AccessFlags = 17)]
				public int GetKeyFrameCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getValueCount
				/// </java-name>
				[Dot42.DexImport("getValueCount", "()I", AccessFlags = 17)]
				public int GetValueCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeyFrame
				/// </java-name>
				[Dot42.DexImport("setKeyFrame", "(II[F)V", AccessFlags = 1)]
				public virtual void SetKeyFrame(int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeyFrame
				/// </java-name>
				[Dot42.DexImport("setKeyFrame", "(II[F[F)V", AccessFlags = 1)]
				public virtual void SetKeyFrame(int int32, int int321, float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRepeatMirror
				/// </java-name>
				[Dot42.DexImport("setRepeatMirror", "(FZ)V", AccessFlags = 1)]
				public virtual void SetRepeatMirror(float single, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// timeToValues
				/// </java-name>
				[Dot42.DexImport("timeToValues", "([F)Landroid/graphics/Interpolator$Result;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Interpolator.Result TimeToValues(float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Interpolator.Result);
				}

				/// <java-name>
				/// timeToValues
				/// </java-name>
				[Dot42.DexImport("timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Interpolator.Result TimeToValues(int int32, float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Interpolator.Result);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Interpolator() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Interpolator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKeyFrameCount
				/// </java-name>
				public int KeyFrameCount
				{
				[Dot42.DexImport("getKeyFrameCount", "()I", AccessFlags = 17)]
						get{ return GetKeyFrameCount(); }
				}

				/// <java-name>
				/// getValueCount
				/// </java-name>
				public int ValueCount
				{
				[Dot42.DexImport("getValueCount", "()I", AccessFlags = 17)]
						get{ return GetValueCount(); }
				}

				/// <java-name>
				/// android/graphics/Interpolator$Result
				/// </java-name>
				[Dot42.DexImport("android/graphics/Interpolator$Result", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Interpolator$Result;>;")]
				public sealed class Result
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FREEZE_END
						/// </java-name>
						[Dot42.DexImport("FREEZE_END", "Landroid/graphics/Interpolator$Result;", AccessFlags = 16409)]
						public static readonly Result FREEZE_END;
						/// <java-name>
						/// FREEZE_START
						/// </java-name>
						[Dot42.DexImport("FREEZE_START", "Landroid/graphics/Interpolator$Result;", AccessFlags = 16409)]
						public static readonly Result FREEZE_START;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/graphics/Interpolator$Result;", AccessFlags = 16409)]
						public static readonly Result NORMAL;
						private Result() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Interpolator$Result;", AccessFlags = 9)]
						public static Result[] Values() /* MethodBuilder.Create */ 
						{
								return default(Result[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;", AccessFlags = 9)]
						public static Result ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Result);
						}

				}

		}

		/// <java-name>
		/// android/graphics/LayerRasterizer
		/// </java-name>
		[Dot42.DexImport("android/graphics/LayerRasterizer", AccessFlags = 33)]
		public partial class LayerRasterizer : global::Android.Graphics.Rasterizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LayerRasterizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLayer
				/// </java-name>
				[Dot42.DexImport("addLayer", "(Landroid/graphics/Paint;FF)V", AccessFlags = 1)]
				public virtual void AddLayer(global::Android.Graphics.Paint paint, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLayer
				/// </java-name>
				[Dot42.DexImport("addLayer", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void AddLayer(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/LightingColorFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/LightingColorFilter", AccessFlags = 33)]
		public partial class LightingColorFilter : global::Android.Graphics.ColorFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public LightingColorFilter(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LightingColorFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/LinearGradient
		/// </java-name>
		[Dot42.DexImport("android/graphics/LinearGradient", AccessFlags = 33)]
		public partial class LinearGradient : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FFFF[I[FLandroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public LinearGradient(float single, float single1, float single2, float single3, int[] int32, float[] single4, global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFFIILandroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public LinearGradient(float single, float single1, float single2, float single3, int int32, int int321, global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LinearGradient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/MaskFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/MaskFilter", AccessFlags = 33)]
		public partial class MaskFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MaskFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MaskFilter() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/Matrix
		/// </java-name>
		[Dot42.DexImport("android/graphics/Matrix", AccessFlags = 33)]
		public partial class Matrix
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MSCALE_X
				/// </java-name>
				[Dot42.DexImport("MSCALE_X", "I", AccessFlags = 25)]
				public const int MSCALE_X = 0;
				/// <java-name>
				/// MSKEW_X
				/// </java-name>
				[Dot42.DexImport("MSKEW_X", "I", AccessFlags = 25)]
				public const int MSKEW_X = 1;
				/// <java-name>
				/// MTRANS_X
				/// </java-name>
				[Dot42.DexImport("MTRANS_X", "I", AccessFlags = 25)]
				public const int MTRANS_X = 2;
				/// <java-name>
				/// MSKEW_Y
				/// </java-name>
				[Dot42.DexImport("MSKEW_Y", "I", AccessFlags = 25)]
				public const int MSKEW_Y = 3;
				/// <java-name>
				/// MSCALE_Y
				/// </java-name>
				[Dot42.DexImport("MSCALE_Y", "I", AccessFlags = 25)]
				public const int MSCALE_Y = 4;
				/// <java-name>
				/// MTRANS_Y
				/// </java-name>
				[Dot42.DexImport("MTRANS_Y", "I", AccessFlags = 25)]
				public const int MTRANS_Y = 5;
				/// <java-name>
				/// MPERSP_0
				/// </java-name>
				[Dot42.DexImport("MPERSP_0", "I", AccessFlags = 25)]
				public const int MPERSP_0 = 6;
				/// <java-name>
				/// MPERSP_1
				/// </java-name>
				[Dot42.DexImport("MPERSP_1", "I", AccessFlags = 25)]
				public const int MPERSP_1 = 7;
				/// <java-name>
				/// MPERSP_2
				/// </java-name>
				[Dot42.DexImport("MPERSP_2", "I", AccessFlags = 25)]
				public const int MPERSP_2 = 8;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public Matrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isIdentity
				/// </java-name>
				[Dot42.DexImport("isIdentity", "()Z", AccessFlags = 1)]
				public virtual bool IsIdentity() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// rectStaysRect
				/// </java-name>
				[Dot42.DexImport("rectStaysRect", "()Z", AccessFlags = 1)]
				public virtual bool RectStaysRect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTranslate
				/// </java-name>
				[Dot42.DexImport("setTranslate", "(FF)V", AccessFlags = 1)]
				public virtual void SetTranslate(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetScale(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FF)V", AccessFlags = 1)]
				public virtual void SetScale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(FFF)V", AccessFlags = 1)]
				public virtual void SetRotate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(F)V", AccessFlags = 1)]
				public virtual void SetRotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSinCos
				/// </java-name>
				[Dot42.DexImport("setSinCos", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetSinCos(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSinCos
				/// </java-name>
				[Dot42.DexImport("setSinCos", "(FF)V", AccessFlags = 1)]
				public virtual void SetSinCos(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSkew
				/// </java-name>
				[Dot42.DexImport("setSkew", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetSkew(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSkew
				/// </java-name>
				[Dot42.DexImport("setSkew", "(FF)V", AccessFlags = 1)]
				public virtual void SetSkew(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConcat
				/// </java-name>
				[Dot42.DexImport("setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool SetConcat(global::Android.Graphics.Matrix matrix, global::Android.Graphics.Matrix matrix1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preTranslate
				/// </java-name>
				[Dot42.DexImport("preTranslate", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreTranslate(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preScale
				/// </java-name>
				[Dot42.DexImport("preScale", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PreScale(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preScale
				/// </java-name>
				[Dot42.DexImport("preScale", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreScale(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preRotate
				/// </java-name>
				[Dot42.DexImport("preRotate", "(FFF)Z", AccessFlags = 1)]
				public virtual bool PreRotate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preRotate
				/// </java-name>
				[Dot42.DexImport("preRotate", "(F)Z", AccessFlags = 1)]
				public virtual bool PreRotate(float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preSkew
				/// </java-name>
				[Dot42.DexImport("preSkew", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PreSkew(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preSkew
				/// </java-name>
				[Dot42.DexImport("preSkew", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreSkew(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preConcat
				/// </java-name>
				[Dot42.DexImport("preConcat", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool PreConcat(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postTranslate
				/// </java-name>
				[Dot42.DexImport("postTranslate", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostTranslate(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postScale
				/// </java-name>
				[Dot42.DexImport("postScale", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PostScale(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postScale
				/// </java-name>
				[Dot42.DexImport("postScale", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostScale(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postRotate
				/// </java-name>
				[Dot42.DexImport("postRotate", "(FFF)Z", AccessFlags = 1)]
				public virtual bool PostRotate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postRotate
				/// </java-name>
				[Dot42.DexImport("postRotate", "(F)Z", AccessFlags = 1)]
				public virtual bool PostRotate(float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postSkew
				/// </java-name>
				[Dot42.DexImport("postSkew", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PostSkew(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postSkew
				/// </java-name>
				[Dot42.DexImport("postSkew", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostSkew(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postConcat
				/// </java-name>
				[Dot42.DexImport("postConcat", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool PostConcat(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setRectToRect
				/// </java-name>
				[Dot42.DexImport("setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleTo" +
    "Fit;)Z", AccessFlags = 1)]
				public virtual bool SetRectToRect(global::Android.Graphics.RectF rectF, global::Android.Graphics.RectF rectF1, global::Android.Graphics.Matrix.ScaleToFit scaleToFit) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPolyToPoly
				/// </java-name>
				[Dot42.DexImport("setPolyToPoly", "([FI[FII)Z", AccessFlags = 1)]
				public virtual bool SetPolyToPoly(float[] single, int int32, float[] single1, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// invert
				/// </java-name>
				[Dot42.DexImport("invert", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool Invert(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([FI[FII)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] single, int int32, float[] single1, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([FI[FII)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] single, int int32, float[] single1, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([F[F)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([F[F)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([F)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([F)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapRect
				/// </java-name>
				[Dot42.DexImport("mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool MapRect(global::Android.Graphics.RectF rectF, global::Android.Graphics.RectF rectF1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mapRect
				/// </java-name>
				[Dot42.DexImport("mapRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool MapRect(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mapRadius
				/// </java-name>
				[Dot42.DexImport("mapRadius", "(F)F", AccessFlags = 1)]
				public virtual float MapRadius(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "([F)V", AccessFlags = 1)]
				public virtual void GetValues(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setValues
				/// </java-name>
				[Dot42.DexImport("setValues", "([F)V", AccessFlags = 1)]
				public virtual void SetValues(float[] single) /* MethodBuilder.Create */ 
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
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Matrix() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/graphics/Matrix$ScaleToFit
				/// </java-name>
				[Dot42.DexImport("android/graphics/Matrix$ScaleToFit", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Matrix$ScaleToFit;>;")]
				public sealed class ScaleToFit
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CENTER
						/// </java-name>
						[Dot42.DexImport("CENTER", "Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 16409)]
						public static readonly ScaleToFit CENTER;
						/// <java-name>
						/// END
						/// </java-name>
						[Dot42.DexImport("END", "Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 16409)]
						public static readonly ScaleToFit END;
						/// <java-name>
						/// FILL
						/// </java-name>
						[Dot42.DexImport("FILL", "Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 16409)]
						public static readonly ScaleToFit FILL;
						/// <java-name>
						/// START
						/// </java-name>
						[Dot42.DexImport("START", "Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 16409)]
						public static readonly ScaleToFit START;
						private ScaleToFit() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 9)]
						public static ScaleToFit[] Values() /* MethodBuilder.Create */ 
						{
								return default(ScaleToFit[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Matrix$ScaleToFit;", AccessFlags = 9)]
						public static ScaleToFit ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(ScaleToFit);
						}

				}

		}

		/// <java-name>
		/// android/graphics/Movie
		/// </java-name>
		[Dot42.DexImport("android/graphics/Movie", AccessFlags = 33)]
		public partial class Movie
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Movie() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "()I", AccessFlags = 257)]
				public virtual int Width() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "()I", AccessFlags = 257)]
				public virtual int Height() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 257)]
				public virtual bool IsOpaque() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// duration
				/// </java-name>
				[Dot42.DexImport("duration", "()I", AccessFlags = 257)]
				public virtual int Duration() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(I)Z", AccessFlags = 257)]
				public virtual bool SetTime(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;FF)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;", AccessFlags = 265)]
				public static global::Android.Graphics.Movie DecodeStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Movie;", AccessFlags = 265)]
				public static global::Android.Graphics.Movie DecodeByteArray(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Movie;", AccessFlags = 265, IgnoreFromJava = true)]
				public static global::Android.Graphics.Movie DecodeByteArray(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;", AccessFlags = 9)]
				public static global::Android.Graphics.Movie DecodeFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Movie() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/NinePatch
		/// </java-name>
		[Dot42.DexImport("android/graphics/NinePatch", AccessFlags = 33)]
		public partial class NinePatch
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V", AccessFlags = 1)]
				public NinePatch(global::Android.Graphics.Bitmap bitmap, sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatch(global::Android.Graphics.Bitmap bitmap, byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPaint
				/// </java-name>
				[Dot42.DexImport("setPaint", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void SetPaint(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Rect rect, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
				public virtual int GetDensity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasAlpha
				/// </java-name>
				[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 17)]
				public bool HasAlpha() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;", AccessFlags = 17)]
				public global::Android.Graphics.Region GetTransparentRegion(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <java-name>
				/// isNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("isNinePatchChunk", "([B)Z", AccessFlags = 265)]
				public static bool IsNinePatchChunk(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("isNinePatchChunk", "([B)Z", AccessFlags = 265, IgnoreFromJava = true)]
				public static bool IsNinePatchChunk(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NinePatch() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				public int Density
				{
				[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return GetDensity(); }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/Paint
		/// </java-name>
		[Dot42.DexImport("android/graphics/Paint", AccessFlags = 33)]
		public partial class Paint
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ANTI_ALIAS_FLAG
				/// </java-name>
				[Dot42.DexImport("ANTI_ALIAS_FLAG", "I", AccessFlags = 25)]
				public const int ANTI_ALIAS_FLAG = 1;
				/// <java-name>
				/// FILTER_BITMAP_FLAG
				/// </java-name>
				[Dot42.DexImport("FILTER_BITMAP_FLAG", "I", AccessFlags = 25)]
				public const int FILTER_BITMAP_FLAG = 2;
				/// <java-name>
				/// DITHER_FLAG
				/// </java-name>
				[Dot42.DexImport("DITHER_FLAG", "I", AccessFlags = 25)]
				public const int DITHER_FLAG = 4;
				/// <java-name>
				/// UNDERLINE_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int UNDERLINE_TEXT_FLAG = 8;
				/// <java-name>
				/// STRIKE_THRU_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("STRIKE_THRU_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int STRIKE_THRU_TEXT_FLAG = 16;
				/// <java-name>
				/// FAKE_BOLD_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("FAKE_BOLD_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int FAKE_BOLD_TEXT_FLAG = 32;
				/// <java-name>
				/// LINEAR_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("LINEAR_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int LINEAR_TEXT_FLAG = 64;
				/// <java-name>
				/// SUBPIXEL_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("SUBPIXEL_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int SUBPIXEL_TEXT_FLAG = 128;
				/// <java-name>
				/// DEV_KERN_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("DEV_KERN_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int DEV_KERN_TEXT_FLAG = 256;
				/// <java-name>
				/// HINTING_OFF
				/// </java-name>
				[Dot42.DexImport("HINTING_OFF", "I", AccessFlags = 25)]
				public const int HINTING_OFF = 0;
				/// <java-name>
				/// HINTING_ON
				/// </java-name>
				[Dot42.DexImport("HINTING_ON", "I", AccessFlags = 25)]
				public const int HINTING_ON = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Paint() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Paint(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public Paint(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()I", AccessFlags = 257)]
				public virtual int GetFlags() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(I)V", AccessFlags = 257)]
				public virtual void SetFlags(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHinting
				/// </java-name>
				[Dot42.DexImport("getHinting", "()I", AccessFlags = 257)]
				public virtual int GetHinting() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setHinting
				/// </java-name>
				[Dot42.DexImport("setHinting", "(I)V", AccessFlags = 257)]
				public virtual void SetHinting(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAntiAlias
				/// </java-name>
				[Dot42.DexImport("isAntiAlias", "()Z", AccessFlags = 17)]
				public bool IsAntiAlias() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAntiAlias
				/// </java-name>
				[Dot42.DexImport("setAntiAlias", "(Z)V", AccessFlags = 257)]
				public virtual void SetAntiAlias(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDither
				/// </java-name>
				[Dot42.DexImport("isDither", "()Z", AccessFlags = 17)]
				public bool IsDither() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 257)]
				public virtual void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLinearText
				/// </java-name>
				[Dot42.DexImport("isLinearText", "()Z", AccessFlags = 17)]
				public bool IsLinearText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLinearText
				/// </java-name>
				[Dot42.DexImport("setLinearText", "(Z)V", AccessFlags = 257)]
				public virtual void SetLinearText(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSubpixelText
				/// </java-name>
				[Dot42.DexImport("isSubpixelText", "()Z", AccessFlags = 17)]
				public bool IsSubpixelText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSubpixelText
				/// </java-name>
				[Dot42.DexImport("setSubpixelText", "(Z)V", AccessFlags = 257)]
				public virtual void SetSubpixelText(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isUnderlineText
				/// </java-name>
				[Dot42.DexImport("isUnderlineText", "()Z", AccessFlags = 17)]
				public bool IsUnderlineText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUnderlineText
				/// </java-name>
				[Dot42.DexImport("setUnderlineText", "(Z)V", AccessFlags = 257)]
				public virtual void SetUnderlineText(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStrikeThruText
				/// </java-name>
				[Dot42.DexImport("isStrikeThruText", "()Z", AccessFlags = 17)]
				public bool IsStrikeThruText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setStrikeThruText
				/// </java-name>
				[Dot42.DexImport("setStrikeThruText", "(Z)V", AccessFlags = 257)]
				public virtual void SetStrikeThruText(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFakeBoldText
				/// </java-name>
				[Dot42.DexImport("isFakeBoldText", "()Z", AccessFlags = 17)]
				public bool IsFakeBoldText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFakeBoldText
				/// </java-name>
				[Dot42.DexImport("setFakeBoldText", "(Z)V", AccessFlags = 257)]
				public virtual void SetFakeBoldText(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFilterBitmap
				/// </java-name>
				[Dot42.DexImport("isFilterBitmap", "()Z", AccessFlags = 17)]
				public bool IsFilterBitmap() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 257)]
				public virtual void SetFilterBitmap(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStyle
				/// </java-name>
				[Dot42.DexImport("getStyle", "()Landroid/graphics/Paint$Style;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.Style GetStyle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.Style);
				}

				/// <java-name>
				/// setStyle
				/// </java-name>
				[Dot42.DexImport("setStyle", "(Landroid/graphics/Paint$Style;)V", AccessFlags = 1)]
				public virtual void SetStyle(global::Android.Graphics.Paint.Style style) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "()I", AccessFlags = 257)]
				public virtual int GetColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setColor
				/// </java-name>
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 257)]
				public virtual void SetColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				[Dot42.DexImport("getAlpha", "()I", AccessFlags = 257)]
				public virtual int GetAlpha() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 257)]
				public virtual void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setARGB
				/// </java-name>
				[Dot42.DexImport("setARGB", "(IIII)V", AccessFlags = 1)]
				public virtual void SetARGB(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrokeWidth
				/// </java-name>
				[Dot42.DexImport("getStrokeWidth", "()F", AccessFlags = 257)]
				public virtual float GetStrokeWidth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setStrokeWidth
				/// </java-name>
				[Dot42.DexImport("setStrokeWidth", "(F)V", AccessFlags = 257)]
				public virtual void SetStrokeWidth(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrokeMiter
				/// </java-name>
				[Dot42.DexImport("getStrokeMiter", "()F", AccessFlags = 257)]
				public virtual float GetStrokeMiter() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setStrokeMiter
				/// </java-name>
				[Dot42.DexImport("setStrokeMiter", "(F)V", AccessFlags = 257)]
				public virtual void SetStrokeMiter(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrokeCap
				/// </java-name>
				[Dot42.DexImport("getStrokeCap", "()Landroid/graphics/Paint$Cap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.Cap GetStrokeCap() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.Cap);
				}

				/// <java-name>
				/// setStrokeCap
				/// </java-name>
				[Dot42.DexImport("setStrokeCap", "(Landroid/graphics/Paint$Cap;)V", AccessFlags = 1)]
				public virtual void SetStrokeCap(global::Android.Graphics.Paint.Cap cap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrokeJoin
				/// </java-name>
				[Dot42.DexImport("getStrokeJoin", "()Landroid/graphics/Paint$Join;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.Join GetStrokeJoin() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.Join);
				}

				/// <java-name>
				/// setStrokeJoin
				/// </java-name>
				[Dot42.DexImport("setStrokeJoin", "(Landroid/graphics/Paint$Join;)V", AccessFlags = 1)]
				public virtual void SetStrokeJoin(global::Android.Graphics.Paint.Join join) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFillPath
				/// </java-name>
				[Dot42.DexImport("getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool GetFillPath(global::Android.Graphics.Path path, global::Android.Graphics.Path path1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getShader
				/// </java-name>
				[Dot42.DexImport("getShader", "()Landroid/graphics/Shader;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader GetShader() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader);
				}

				/// <java-name>
				/// setShader
				/// </java-name>
				[Dot42.DexImport("setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader SetShader(global::Android.Graphics.Shader shader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader);
				}

				/// <java-name>
				/// getColorFilter
				/// </java-name>
				[Dot42.DexImport("getColorFilter", "()Landroid/graphics/ColorFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.ColorFilter GetColorFilter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.ColorFilter);
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.ColorFilter SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.ColorFilter);
				}

				/// <java-name>
				/// getXfermode
				/// </java-name>
				[Dot42.DexImport("getXfermode", "()Landroid/graphics/Xfermode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Xfermode GetXfermode() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Xfermode);
				}

				/// <java-name>
				/// setXfermode
				/// </java-name>
				[Dot42.DexImport("setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Xfermode SetXfermode(global::Android.Graphics.Xfermode xfermode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Xfermode);
				}

				/// <java-name>
				/// getPathEffect
				/// </java-name>
				[Dot42.DexImport("getPathEffect", "()Landroid/graphics/PathEffect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.PathEffect GetPathEffect() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.PathEffect);
				}

				/// <java-name>
				/// setPathEffect
				/// </java-name>
				[Dot42.DexImport("setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.PathEffect SetPathEffect(global::Android.Graphics.PathEffect pathEffect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.PathEffect);
				}

				/// <java-name>
				/// getMaskFilter
				/// </java-name>
				[Dot42.DexImport("getMaskFilter", "()Landroid/graphics/MaskFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.MaskFilter GetMaskFilter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.MaskFilter);
				}

				/// <java-name>
				/// setMaskFilter
				/// </java-name>
				[Dot42.DexImport("setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.MaskFilter SetMaskFilter(global::Android.Graphics.MaskFilter maskFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.MaskFilter);
				}

				/// <java-name>
				/// getTypeface
				/// </java-name>
				[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Typeface GetTypeface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// setTypeface
				/// </java-name>
				[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Typeface SetTypeface(global::Android.Graphics.Typeface typeface) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// getRasterizer
				/// </java-name>
				[Dot42.DexImport("getRasterizer", "()Landroid/graphics/Rasterizer;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rasterizer GetRasterizer() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rasterizer);
				}

				/// <java-name>
				/// setRasterizer
				/// </java-name>
				[Dot42.DexImport("setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rasterizer SetRasterizer(global::Android.Graphics.Rasterizer rasterizer) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rasterizer);
				}

				/// <java-name>
				/// setShadowLayer
				/// </java-name>
				[Dot42.DexImport("setShadowLayer", "(FFFI)V", AccessFlags = 1)]
				public virtual void SetShadowLayer(float single, float single1, float single2, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearShadowLayer
				/// </java-name>
				[Dot42.DexImport("clearShadowLayer", "()V", AccessFlags = 1)]
				public virtual void ClearShadowLayer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextAlign
				/// </java-name>
				[Dot42.DexImport("getTextAlign", "()Landroid/graphics/Paint$Align;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.Align GetTextAlign() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.Align);
				}

				/// <java-name>
				/// setTextAlign
				/// </java-name>
				[Dot42.DexImport("setTextAlign", "(Landroid/graphics/Paint$Align;)V", AccessFlags = 1)]
				public virtual void SetTextAlign(global::Android.Graphics.Paint.Align align) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextSize
				/// </java-name>
				[Dot42.DexImport("getTextSize", "()F", AccessFlags = 257)]
				public virtual float GetTextSize() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setTextSize
				/// </java-name>
				[Dot42.DexImport("setTextSize", "(F)V", AccessFlags = 257)]
				public virtual void SetTextSize(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextScaleX
				/// </java-name>
				[Dot42.DexImport("getTextScaleX", "()F", AccessFlags = 257)]
				public virtual float GetTextScaleX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setTextScaleX
				/// </java-name>
				[Dot42.DexImport("setTextScaleX", "(F)V", AccessFlags = 257)]
				public virtual void SetTextScaleX(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextSkewX
				/// </java-name>
				[Dot42.DexImport("getTextSkewX", "()F", AccessFlags = 257)]
				public virtual float GetTextSkewX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setTextSkewX
				/// </java-name>
				[Dot42.DexImport("setTextSkewX", "(F)V", AccessFlags = 257)]
				public virtual void SetTextSkewX(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ascent
				/// </java-name>
				[Dot42.DexImport("ascent", "()F", AccessFlags = 257)]
				public virtual float Ascent() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// descent
				/// </java-name>
				[Dot42.DexImport("descent", "()F", AccessFlags = 257)]
				public virtual float Descent() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getFontMetrics
				/// </java-name>
				[Dot42.DexImport("getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F", AccessFlags = 257)]
				public virtual float GetFontMetrics(global::Android.Graphics.Paint.FontMetrics fontMetrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getFontMetrics
				/// </java-name>
				[Dot42.DexImport("getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.FontMetrics GetFontMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.FontMetrics);
				}

				/// <java-name>
				/// getFontMetricsInt
				/// </java-name>
				[Dot42.DexImport("getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I", AccessFlags = 257)]
				public virtual int GetFontMetricsInt(global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFontMetricsInt
				/// </java-name>
				[Dot42.DexImport("getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.FontMetricsInt GetFontMetricsInt() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.FontMetricsInt);
				}

				/// <java-name>
				/// getFontSpacing
				/// </java-name>
				[Dot42.DexImport("getFontSpacing", "()F", AccessFlags = 1)]
				public virtual float GetFontSpacing() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// measureText
				/// </java-name>
				[Dot42.DexImport("measureText", "([CII)F", AccessFlags = 1)]
				public virtual float MeasureText(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// measureText
				/// </java-name>
				[Dot42.DexImport("measureText", "(Ljava/lang/String;II)F", AccessFlags = 1)]
				public virtual float MeasureText(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// measureText
				/// </java-name>
				[Dot42.DexImport("measureText", "(Ljava/lang/String;)F", AccessFlags = 1)]
				public virtual float MeasureText(string @string) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// measureText
				/// </java-name>
				[Dot42.DexImport("measureText", "(Ljava/lang/CharSequence;II)F", AccessFlags = 1)]
				public virtual float MeasureText(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "([CIIF[F)I", AccessFlags = 1)]
				public virtual int BreakText(char[] @char, int int32, int int321, float single, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "(Ljava/lang/CharSequence;IIZF[F)I", AccessFlags = 1)]
				public virtual int BreakText(global::Java.Lang.ICharSequence charSequence, int int32, int int321, bool boolean, float single, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "(Ljava/lang/String;ZF[F)I", AccessFlags = 1)]
				public virtual int BreakText(string @string, bool boolean, float single, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTextWidths
				/// </java-name>
				[Dot42.DexImport("getTextWidths", "([CII[F)I", AccessFlags = 1)]
				public virtual int GetTextWidths(char[] @char, int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTextWidths
				/// </java-name>
				[Dot42.DexImport("getTextWidths", "(Ljava/lang/CharSequence;II[F)I", AccessFlags = 1)]
				public virtual int GetTextWidths(global::Java.Lang.ICharSequence charSequence, int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTextWidths
				/// </java-name>
				[Dot42.DexImport("getTextWidths", "(Ljava/lang/String;II[F)I", AccessFlags = 1)]
				public virtual int GetTextWidths(string @string, int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTextWidths
				/// </java-name>
				[Dot42.DexImport("getTextWidths", "(Ljava/lang/String;[F)I", AccessFlags = 1)]
				public virtual int GetTextWidths(string @string, float[] single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTextPath
				/// </java-name>
				[Dot42.DexImport("getTextPath", "([CIIFFLandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void GetTextPath(char[] @char, int int32, int int321, float single, float single1, global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextPath
				/// </java-name>
				[Dot42.DexImport("getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void GetTextPath(string @string, int int32, int int321, float single, float single1, global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextBounds
				/// </java-name>
				[Dot42.DexImport("getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetTextBounds(string @string, int int32, int int321, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextBounds
				/// </java-name>
				[Dot42.DexImport("getTextBounds", "([CIILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetTextBounds(char[] @char, int int32, int int321, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Paint() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFlags
				/// </java-name>
				public int Flags
				{
				[Dot42.DexImport("getFlags", "()I", AccessFlags = 257)]
						get{ return GetFlags(); }
				[Dot42.DexImport("setFlags", "(I)V", AccessFlags = 257)]
						set{ SetFlags(value); }
				}

				/// <java-name>
				/// getHinting
				/// </java-name>
				public int Hinting
				{
				[Dot42.DexImport("getHinting", "()I", AccessFlags = 257)]
						get{ return GetHinting(); }
				[Dot42.DexImport("setHinting", "(I)V", AccessFlags = 257)]
						set{ SetHinting(value); }
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				public int Color
				{
				[Dot42.DexImport("getColor", "()I", AccessFlags = 257)]
						get{ return GetColor(); }
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 257)]
						set{ SetColor(value); }
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				public int Alpha
				{
				[Dot42.DexImport("getAlpha", "()I", AccessFlags = 257)]
						get{ return GetAlpha(); }
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 257)]
						set{ SetAlpha(value); }
				}

				/// <java-name>
				/// getStrokeWidth
				/// </java-name>
				public float StrokeWidth
				{
				[Dot42.DexImport("getStrokeWidth", "()F", AccessFlags = 257)]
						get{ return GetStrokeWidth(); }
				[Dot42.DexImport("setStrokeWidth", "(F)V", AccessFlags = 257)]
						set{ SetStrokeWidth(value); }
				}

				/// <java-name>
				/// getStrokeMiter
				/// </java-name>
				public float StrokeMiter
				{
				[Dot42.DexImport("getStrokeMiter", "()F", AccessFlags = 257)]
						get{ return GetStrokeMiter(); }
				[Dot42.DexImport("setStrokeMiter", "(F)V", AccessFlags = 257)]
						set{ SetStrokeMiter(value); }
				}

				/// <java-name>
				/// getStrokeCap
				/// </java-name>
				public global::Android.Graphics.Paint.Cap StrokeCap
				{
				[Dot42.DexImport("getStrokeCap", "()Landroid/graphics/Paint$Cap;", AccessFlags = 1)]
						get{ return GetStrokeCap(); }
				[Dot42.DexImport("setStrokeCap", "(Landroid/graphics/Paint$Cap;)V", AccessFlags = 1)]
						set{ SetStrokeCap(value); }
				}

				/// <java-name>
				/// getStrokeJoin
				/// </java-name>
				public global::Android.Graphics.Paint.Join StrokeJoin
				{
				[Dot42.DexImport("getStrokeJoin", "()Landroid/graphics/Paint$Join;", AccessFlags = 1)]
						get{ return GetStrokeJoin(); }
				[Dot42.DexImport("setStrokeJoin", "(Landroid/graphics/Paint$Join;)V", AccessFlags = 1)]
						set{ SetStrokeJoin(value); }
				}

				/// <java-name>
				/// getShader
				/// </java-name>
				public global::Android.Graphics.Shader Shader
				{
				[Dot42.DexImport("getShader", "()Landroid/graphics/Shader;", AccessFlags = 1)]
						get{ return GetShader(); }
				}

				/// <java-name>
				/// getColorFilter
				/// </java-name>
				public global::Android.Graphics.ColorFilter ColorFilter
				{
				[Dot42.DexImport("getColorFilter", "()Landroid/graphics/ColorFilter;", AccessFlags = 1)]
						get{ return GetColorFilter(); }
				}

				/// <java-name>
				/// getXfermode
				/// </java-name>
				public global::Android.Graphics.Xfermode Xfermode
				{
				[Dot42.DexImport("getXfermode", "()Landroid/graphics/Xfermode;", AccessFlags = 1)]
						get{ return GetXfermode(); }
				}

				/// <java-name>
				/// getPathEffect
				/// </java-name>
				public global::Android.Graphics.PathEffect PathEffect
				{
				[Dot42.DexImport("getPathEffect", "()Landroid/graphics/PathEffect;", AccessFlags = 1)]
						get{ return GetPathEffect(); }
				}

				/// <java-name>
				/// getMaskFilter
				/// </java-name>
				public global::Android.Graphics.MaskFilter MaskFilter
				{
				[Dot42.DexImport("getMaskFilter", "()Landroid/graphics/MaskFilter;", AccessFlags = 1)]
						get{ return GetMaskFilter(); }
				}

				/// <java-name>
				/// getTypeface
				/// </java-name>
				public global::Android.Graphics.Typeface Typeface
				{
				[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
						get{ return GetTypeface(); }
				}

				/// <java-name>
				/// getRasterizer
				/// </java-name>
				public global::Android.Graphics.Rasterizer Rasterizer
				{
				[Dot42.DexImport("getRasterizer", "()Landroid/graphics/Rasterizer;", AccessFlags = 1)]
						get{ return GetRasterizer(); }
				}

				/// <java-name>
				/// getTextAlign
				/// </java-name>
				public global::Android.Graphics.Paint.Align TextAlign
				{
				[Dot42.DexImport("getTextAlign", "()Landroid/graphics/Paint$Align;", AccessFlags = 1)]
						get{ return GetTextAlign(); }
				[Dot42.DexImport("setTextAlign", "(Landroid/graphics/Paint$Align;)V", AccessFlags = 1)]
						set{ SetTextAlign(value); }
				}

				/// <java-name>
				/// getTextSize
				/// </java-name>
				public float TextSize
				{
				[Dot42.DexImport("getTextSize", "()F", AccessFlags = 257)]
						get{ return GetTextSize(); }
				[Dot42.DexImport("setTextSize", "(F)V", AccessFlags = 257)]
						set{ SetTextSize(value); }
				}

				/// <java-name>
				/// getTextScaleX
				/// </java-name>
				public float TextScaleX
				{
				[Dot42.DexImport("getTextScaleX", "()F", AccessFlags = 257)]
						get{ return GetTextScaleX(); }
				[Dot42.DexImport("setTextScaleX", "(F)V", AccessFlags = 257)]
						set{ SetTextScaleX(value); }
				}

				/// <java-name>
				/// getTextSkewX
				/// </java-name>
				public float TextSkewX
				{
				[Dot42.DexImport("getTextSkewX", "()F", AccessFlags = 257)]
						get{ return GetTextSkewX(); }
				[Dot42.DexImport("setTextSkewX", "(F)V", AccessFlags = 257)]
						set{ SetTextSkewX(value); }
				}

				/// <java-name>
				/// getFontSpacing
				/// </java-name>
				public float FontSpacing
				{
				[Dot42.DexImport("getFontSpacing", "()F", AccessFlags = 1)]
						get{ return GetFontSpacing(); }
				}

				/// <java-name>
				/// android/graphics/Paint$FontMetricsInt
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$FontMetricsInt", AccessFlags = 9)]
				public partial class FontMetricsInt
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// top
						/// </java-name>
						[Dot42.DexImport("top", "I", AccessFlags = 1)]
						public int Top;
						/// <java-name>
						/// ascent
						/// </java-name>
						[Dot42.DexImport("ascent", "I", AccessFlags = 1)]
						public int Ascent;
						/// <java-name>
						/// descent
						/// </java-name>
						[Dot42.DexImport("descent", "I", AccessFlags = 1)]
						public int Descent;
						/// <java-name>
						/// bottom
						/// </java-name>
						[Dot42.DexImport("bottom", "I", AccessFlags = 1)]
						public int Bottom;
						/// <java-name>
						/// leading
						/// </java-name>
						[Dot42.DexImport("leading", "I", AccessFlags = 1)]
						public int Leading;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public FontMetricsInt() /* MethodBuilder.Create */ 
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

				}

				/// <java-name>
				/// android/graphics/Paint$FontMetrics
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$FontMetrics", AccessFlags = 9)]
				public partial class FontMetrics
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// top
						/// </java-name>
						[Dot42.DexImport("top", "F", AccessFlags = 1)]
						public float Top;
						/// <java-name>
						/// ascent
						/// </java-name>
						[Dot42.DexImport("ascent", "F", AccessFlags = 1)]
						public float Ascent;
						/// <java-name>
						/// descent
						/// </java-name>
						[Dot42.DexImport("descent", "F", AccessFlags = 1)]
						public float Descent;
						/// <java-name>
						/// bottom
						/// </java-name>
						[Dot42.DexImport("bottom", "F", AccessFlags = 1)]
						public float Bottom;
						/// <java-name>
						/// leading
						/// </java-name>
						[Dot42.DexImport("leading", "F", AccessFlags = 1)]
						public float Leading;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public FontMetrics() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/graphics/Paint$Align
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$Align", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Paint$Align;>;")]
				public sealed class Align
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CENTER
						/// </java-name>
						[Dot42.DexImport("CENTER", "Landroid/graphics/Paint$Align;", AccessFlags = 16409)]
						public static readonly Align CENTER;
						/// <java-name>
						/// LEFT
						/// </java-name>
						[Dot42.DexImport("LEFT", "Landroid/graphics/Paint$Align;", AccessFlags = 16409)]
						public static readonly Align LEFT;
						/// <java-name>
						/// RIGHT
						/// </java-name>
						[Dot42.DexImport("RIGHT", "Landroid/graphics/Paint$Align;", AccessFlags = 16409)]
						public static readonly Align RIGHT;
						private Align() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Paint$Align;", AccessFlags = 9)]
						public static Align[] Values() /* MethodBuilder.Create */ 
						{
								return default(Align[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;", AccessFlags = 9)]
						public static Align ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Align);
						}

				}

				/// <java-name>
				/// android/graphics/Paint$Join
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$Join", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Paint$Join;>;")]
				public sealed class Join
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BEVEL
						/// </java-name>
						[Dot42.DexImport("BEVEL", "Landroid/graphics/Paint$Join;", AccessFlags = 16409)]
						public static readonly Join BEVEL;
						/// <java-name>
						/// MITER
						/// </java-name>
						[Dot42.DexImport("MITER", "Landroid/graphics/Paint$Join;", AccessFlags = 16409)]
						public static readonly Join MITER;
						/// <java-name>
						/// ROUND
						/// </java-name>
						[Dot42.DexImport("ROUND", "Landroid/graphics/Paint$Join;", AccessFlags = 16409)]
						public static readonly Join ROUND;
						private Join() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Paint$Join;", AccessFlags = 9)]
						public static Join[] Values() /* MethodBuilder.Create */ 
						{
								return default(Join[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;", AccessFlags = 9)]
						public static Join ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Join);
						}

				}

				/// <java-name>
				/// android/graphics/Paint$Cap
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$Cap", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Paint$Cap;>;")]
				public sealed class Cap
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BUTT
						/// </java-name>
						[Dot42.DexImport("BUTT", "Landroid/graphics/Paint$Cap;", AccessFlags = 16409)]
						public static readonly Cap BUTT;
						/// <java-name>
						/// ROUND
						/// </java-name>
						[Dot42.DexImport("ROUND", "Landroid/graphics/Paint$Cap;", AccessFlags = 16409)]
						public static readonly Cap ROUND;
						/// <java-name>
						/// SQUARE
						/// </java-name>
						[Dot42.DexImport("SQUARE", "Landroid/graphics/Paint$Cap;", AccessFlags = 16409)]
						public static readonly Cap SQUARE;
						private Cap() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Paint$Cap;", AccessFlags = 9)]
						public static Cap[] Values() /* MethodBuilder.Create */ 
						{
								return default(Cap[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;", AccessFlags = 9)]
						public static Cap ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Cap);
						}

				}

				/// <java-name>
				/// android/graphics/Paint$Style
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$Style", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Paint$Style;>;")]
				public sealed class Style
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FILL
						/// </java-name>
						[Dot42.DexImport("FILL", "Landroid/graphics/Paint$Style;", AccessFlags = 16409)]
						public static readonly Style FILL;
						/// <java-name>
						/// FILL_AND_STROKE
						/// </java-name>
						[Dot42.DexImport("FILL_AND_STROKE", "Landroid/graphics/Paint$Style;", AccessFlags = 16409)]
						public static readonly Style FILL_AND_STROKE;
						/// <java-name>
						/// STROKE
						/// </java-name>
						[Dot42.DexImport("STROKE", "Landroid/graphics/Paint$Style;", AccessFlags = 16409)]
						public static readonly Style STROKE;
						private Style() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Paint$Style;", AccessFlags = 9)]
						public static Style[] Values() /* MethodBuilder.Create */ 
						{
								return default(Style[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;", AccessFlags = 9)]
						public static Style ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Style);
						}

				}

		}

		/// <java-name>
		/// android/graphics/PaintFlagsDrawFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/PaintFlagsDrawFilter", AccessFlags = 33)]
		public partial class PaintFlagsDrawFilter : global::Android.Graphics.DrawFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PaintFlagsDrawFilter(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PaintFlagsDrawFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Path
		/// </java-name>
		[Dot42.DexImport("android/graphics/Path", AccessFlags = 33)]
		public partial class Path
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Path() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public Path(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rewind
				/// </java-name>
				[Dot42.DexImport("rewind", "()V", AccessFlags = 1)]
				public virtual void Rewind() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFillType
				/// </java-name>
				[Dot42.DexImport("getFillType", "()Landroid/graphics/Path$FillType;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path.FillType GetFillType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path.FillType);
				}

				/// <java-name>
				/// setFillType
				/// </java-name>
				[Dot42.DexImport("setFillType", "(Landroid/graphics/Path$FillType;)V", AccessFlags = 1)]
				public virtual void SetFillType(global::Android.Graphics.Path.FillType fillType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isInverseFillType
				/// </java-name>
				[Dot42.DexImport("isInverseFillType", "()Z", AccessFlags = 1)]
				public virtual bool IsInverseFillType() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toggleInverseFillType
				/// </java-name>
				[Dot42.DexImport("toggleInverseFillType", "()V", AccessFlags = 1)]
				public virtual void ToggleInverseFillType() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isRect
				/// </java-name>
				[Dot42.DexImport("isRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool IsRect(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeBounds
				/// </java-name>
				[Dot42.DexImport("computeBounds", "(Landroid/graphics/RectF;Z)V", AccessFlags = 1)]
				public virtual void ComputeBounds(global::Android.Graphics.RectF rectF, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incReserve
				/// </java-name>
				[Dot42.DexImport("incReserve", "(I)V", AccessFlags = 1)]
				public virtual void IncReserve(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// moveTo
				/// </java-name>
				[Dot42.DexImport("moveTo", "(FF)V", AccessFlags = 1)]
				public virtual void MoveTo(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rMoveTo
				/// </java-name>
				[Dot42.DexImport("rMoveTo", "(FF)V", AccessFlags = 1)]
				public virtual void RMoveTo(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lineTo
				/// </java-name>
				[Dot42.DexImport("lineTo", "(FF)V", AccessFlags = 1)]
				public virtual void LineTo(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rLineTo
				/// </java-name>
				[Dot42.DexImport("rLineTo", "(FF)V", AccessFlags = 1)]
				public virtual void RLineTo(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// quadTo
				/// </java-name>
				[Dot42.DexImport("quadTo", "(FFFF)V", AccessFlags = 1)]
				public virtual void QuadTo(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rQuadTo
				/// </java-name>
				[Dot42.DexImport("rQuadTo", "(FFFF)V", AccessFlags = 1)]
				public virtual void RQuadTo(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cubicTo
				/// </java-name>
				[Dot42.DexImport("cubicTo", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void CubicTo(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rCubicTo
				/// </java-name>
				[Dot42.DexImport("rCubicTo", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void RCubicTo(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// arcTo
				/// </java-name>
				[Dot42.DexImport("arcTo", "(Landroid/graphics/RectF;FFZ)V", AccessFlags = 1)]
				public virtual void ArcTo(global::Android.Graphics.RectF rectF, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// arcTo
				/// </java-name>
				[Dot42.DexImport("arcTo", "(Landroid/graphics/RectF;FF)V", AccessFlags = 1)]
				public virtual void ArcTo(global::Android.Graphics.RectF rectF, float single, float single1) /* MethodBuilder.Create */ 
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
				/// addRect
				/// </java-name>
				[Dot42.DexImport("addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRect(global::Android.Graphics.RectF rectF, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRect
				/// </java-name>
				[Dot42.DexImport("addRect", "(FFFFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRect(float single, float single1, float single2, float single3, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOval
				/// </java-name>
				[Dot42.DexImport("addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddOval(global::Android.Graphics.RectF rectF, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCircle
				/// </java-name>
				[Dot42.DexImport("addCircle", "(FFFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddCircle(float single, float single1, float single2, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addArc
				/// </java-name>
				[Dot42.DexImport("addArc", "(Landroid/graphics/RectF;FF)V", AccessFlags = 1)]
				public virtual void AddArc(global::Android.Graphics.RectF rectF, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRoundRect
				/// </java-name>
				[Dot42.DexImport("addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRoundRect(global::Android.Graphics.RectF rectF, float single, float single1, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addRoundRect
				/// </java-name>
				[Dot42.DexImport("addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRoundRect(global::Android.Graphics.RectF rectF, float[] single, global::Android.Graphics.Path.Direction direction) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;FF)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path path, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path path, global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FFLandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Offset(float single, float single1, global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FF)V", AccessFlags = 1)]
				public virtual void Offset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLastPoint
				/// </java-name>
				[Dot42.DexImport("setLastPoint", "(FF)V", AccessFlags = 1)]
				public virtual void SetLastPoint(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Transform(global::Android.Graphics.Matrix matrix, global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void Transform(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Path() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/graphics/Path$Direction
				/// </java-name>
				[Dot42.DexImport("android/graphics/Path$Direction", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Path$Direction;>;")]
				public sealed class Direction
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CCW
						/// </java-name>
						[Dot42.DexImport("CCW", "Landroid/graphics/Path$Direction;", AccessFlags = 16409)]
						public static readonly Direction CCW;
						/// <java-name>
						/// CW
						/// </java-name>
						[Dot42.DexImport("CW", "Landroid/graphics/Path$Direction;", AccessFlags = 16409)]
						public static readonly Direction CW;
						private Direction() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Path$Direction;", AccessFlags = 9)]
						public static Direction[] Values() /* MethodBuilder.Create */ 
						{
								return default(Direction[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$Direction;", AccessFlags = 9)]
						public static Direction ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Direction);
						}

				}

				/// <java-name>
				/// android/graphics/Path$FillType
				/// </java-name>
				[Dot42.DexImport("android/graphics/Path$FillType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Path$FillType;>;")]
				public sealed class FillType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EVEN_ODD
						/// </java-name>
						[Dot42.DexImport("EVEN_ODD", "Landroid/graphics/Path$FillType;", AccessFlags = 16409)]
						public static readonly FillType EVEN_ODD;
						/// <java-name>
						/// INVERSE_EVEN_ODD
						/// </java-name>
						[Dot42.DexImport("INVERSE_EVEN_ODD", "Landroid/graphics/Path$FillType;", AccessFlags = 16409)]
						public static readonly FillType INVERSE_EVEN_ODD;
						/// <java-name>
						/// INVERSE_WINDING
						/// </java-name>
						[Dot42.DexImport("INVERSE_WINDING", "Landroid/graphics/Path$FillType;", AccessFlags = 16409)]
						public static readonly FillType INVERSE_WINDING;
						/// <java-name>
						/// WINDING
						/// </java-name>
						[Dot42.DexImport("WINDING", "Landroid/graphics/Path$FillType;", AccessFlags = 16409)]
						public static readonly FillType WINDING;
						private FillType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Path$FillType;", AccessFlags = 9)]
						public static FillType[] Values() /* MethodBuilder.Create */ 
						{
								return default(FillType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Path$FillType;", AccessFlags = 9)]
						public static FillType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(FillType);
						}

				}

		}

		/// <java-name>
		/// android/graphics/PathDashPathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/PathDashPathEffect", AccessFlags = 33)]
		public partial class PathDashPathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;FFLandroid/graphics/PathDashPathEffect$Style;)V", AccessFlags = 1)]
				public PathDashPathEffect(global::Android.Graphics.Path path, float single, float single1, global::Android.Graphics.PathDashPathEffect.Style style) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PathDashPathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/graphics/PathDashPathEffect$Style
				/// </java-name>
				[Dot42.DexImport("android/graphics/PathDashPathEffect$Style", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/PathDashPathEffect$Style;>;")]
				public sealed class Style
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MORPH
						/// </java-name>
						[Dot42.DexImport("MORPH", "Landroid/graphics/PathDashPathEffect$Style;", AccessFlags = 16409)]
						public static readonly Style MORPH;
						/// <java-name>
						/// ROTATE
						/// </java-name>
						[Dot42.DexImport("ROTATE", "Landroid/graphics/PathDashPathEffect$Style;", AccessFlags = 16409)]
						public static readonly Style ROTATE;
						/// <java-name>
						/// TRANSLATE
						/// </java-name>
						[Dot42.DexImport("TRANSLATE", "Landroid/graphics/PathDashPathEffect$Style;", AccessFlags = 16409)]
						public static readonly Style TRANSLATE;
						private Style() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/PathDashPathEffect$Style;", AccessFlags = 9)]
						public static Style[] Values() /* MethodBuilder.Create */ 
						{
								return default(Style[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/PathDashPathEffect$Style;", AccessFlags = 9)]
						public static Style ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Style);
						}

				}

		}

		/// <java-name>
		/// android/graphics/PathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/PathEffect", AccessFlags = 33)]
		public partial class PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PathEffect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~PathEffect() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/PathMeasure
		/// </java-name>
		[Dot42.DexImport("android/graphics/PathMeasure", AccessFlags = 33)]
		public partial class PathMeasure
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// POSITION_MATRIX_FLAG
				/// </java-name>
				[Dot42.DexImport("POSITION_MATRIX_FLAG", "I", AccessFlags = 25)]
				public const int POSITION_MATRIX_FLAG = 1;
				/// <java-name>
				/// TANGENT_MATRIX_FLAG
				/// </java-name>
				[Dot42.DexImport("TANGENT_MATRIX_FLAG", "I", AccessFlags = 25)]
				public const int TANGENT_MATRIX_FLAG = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PathMeasure() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;Z)V", AccessFlags = 1)]
				public PathMeasure(global::Android.Graphics.Path path, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Landroid/graphics/Path;Z)V", AccessFlags = 1)]
				public virtual void SetPath(global::Android.Graphics.Path path, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()F", AccessFlags = 1)]
				public virtual float GetLength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getPosTan
				/// </java-name>
				[Dot42.DexImport("getPosTan", "(F[F[F)Z", AccessFlags = 1)]
				public virtual bool GetPosTan(float single, float[] single1, float[] single2) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(FLandroid/graphics/Matrix;I)Z", AccessFlags = 1)]
				public virtual bool GetMatrix(float single, global::Android.Graphics.Matrix matrix, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSegment
				/// </java-name>
				[Dot42.DexImport("getSegment", "(FFLandroid/graphics/Path;Z)Z", AccessFlags = 1)]
				public virtual bool GetSegment(float single, float single1, global::Android.Graphics.Path path, bool boolean) /* MethodBuilder.Create */ 
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
				/// nextContour
				/// </java-name>
				[Dot42.DexImport("nextContour", "()Z", AccessFlags = 1)]
				public virtual bool NextContour() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~PathMeasure() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				public float Length
				{
				[Dot42.DexImport("getLength", "()F", AccessFlags = 1)]
						get{ return GetLength(); }
				}

		}

		/// <java-name>
		/// android/graphics/Picture
		/// </java-name>
		[Dot42.DexImport("android/graphics/Picture", AccessFlags = 33)]
		public partial class Picture
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Picture() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public Picture(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginRecording
				/// </java-name>
				[Dot42.DexImport("beginRecording", "(II)Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas BeginRecording(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <java-name>
				/// endRecording
				/// </java-name>
				[Dot42.DexImport("endRecording", "()V", AccessFlags = 1)]
				public virtual void EndRecording() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFromStream
				/// </java-name>
				[Dot42.DexImport("createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;", AccessFlags = 9)]
				public static global::Android.Graphics.Picture CreateFromStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <java-name>
				/// writeToStream
				/// </java-name>
				[Dot42.DexImport("writeToStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteToStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Picture() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
						get{ return GetHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/PixelFormat
		/// </java-name>
		[Dot42.DexImport("android/graphics/PixelFormat", AccessFlags = 33)]
		public partial class PixelFormat
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNKNOWN
				/// </java-name>
				[Dot42.DexImport("UNKNOWN", "I", AccessFlags = 25)]
				public const int UNKNOWN = 0;
				/// <java-name>
				/// TRANSLUCENT
				/// </java-name>
				[Dot42.DexImport("TRANSLUCENT", "I", AccessFlags = 25)]
				public const int TRANSLUCENT = -3;
				/// <java-name>
				/// TRANSPARENT
				/// </java-name>
				[Dot42.DexImport("TRANSPARENT", "I", AccessFlags = 25)]
				public const int TRANSPARENT = -2;
				/// <java-name>
				/// OPAQUE
				/// </java-name>
				[Dot42.DexImport("OPAQUE", "I", AccessFlags = 25)]
				public const int OPAQUE = -1;
				/// <java-name>
				/// RGBA_8888
				/// </java-name>
				[Dot42.DexImport("RGBA_8888", "I", AccessFlags = 25)]
				public const int RGBA_8888 = 1;
				/// <java-name>
				/// RGBX_8888
				/// </java-name>
				[Dot42.DexImport("RGBX_8888", "I", AccessFlags = 25)]
				public const int RGBX_8888 = 2;
				/// <java-name>
				/// RGB_888
				/// </java-name>
				[Dot42.DexImport("RGB_888", "I", AccessFlags = 25)]
				public const int RGB_888 = 3;
				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "I", AccessFlags = 25)]
				public const int RGB_565 = 4;
				/// <java-name>
				/// RGBA_5551
				/// </java-name>
				[Dot42.DexImport("RGBA_5551", "I", AccessFlags = 25)]
				public const int RGBA_5551 = 6;
				/// <java-name>
				/// RGBA_4444
				/// </java-name>
				[Dot42.DexImport("RGBA_4444", "I", AccessFlags = 25)]
				public const int RGBA_4444 = 7;
				/// <java-name>
				/// A_8
				/// </java-name>
				[Dot42.DexImport("A_8", "I", AccessFlags = 25)]
				public const int A_8 = 8;
				/// <java-name>
				/// L_8
				/// </java-name>
				[Dot42.DexImport("L_8", "I", AccessFlags = 25)]
				public const int L_8 = 9;
				/// <java-name>
				/// LA_88
				/// </java-name>
				[Dot42.DexImport("LA_88", "I", AccessFlags = 25)]
				public const int LA_88 = 10;
				/// <java-name>
				/// RGB_332
				/// </java-name>
				[Dot42.DexImport("RGB_332", "I", AccessFlags = 25)]
				public const int RGB_332 = 11;
				/// <java-name>
				/// YCbCr_422_SP
				/// </java-name>
				[Dot42.DexImport("YCbCr_422_SP", "I", AccessFlags = 25)]
				public const int YCbCr_422_SP = 16;
				/// <java-name>
				/// YCbCr_420_SP
				/// </java-name>
				[Dot42.DexImport("YCbCr_420_SP", "I", AccessFlags = 25)]
				public const int YCbCr_420_SP = 17;
				/// <java-name>
				/// YCbCr_422_I
				/// </java-name>
				[Dot42.DexImport("YCbCr_422_I", "I", AccessFlags = 25)]
				public const int YCbCr_422_I = 20;
				/// <java-name>
				/// JPEG
				/// </java-name>
				[Dot42.DexImport("JPEG", "I", AccessFlags = 25)]
				public const int JPEG = 256;
				/// <java-name>
				/// bytesPerPixel
				/// </java-name>
				[Dot42.DexImport("bytesPerPixel", "I", AccessFlags = 1)]
				public int BytesPerPixel;
				/// <java-name>
				/// bitsPerPixel
				/// </java-name>
				[Dot42.DexImport("bitsPerPixel", "I", AccessFlags = 1)]
				public int BitsPerPixel;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PixelFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPixelFormatInfo
				/// </java-name>
				[Dot42.DexImport("getPixelFormatInfo", "(ILandroid/graphics/PixelFormat;)V", AccessFlags = 265)]
				public static void GetPixelFormatInfo(int int32, global::Android.Graphics.PixelFormat pixelFormat) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatHasAlpha
				/// </java-name>
				[Dot42.DexImport("formatHasAlpha", "(I)Z", AccessFlags = 9)]
				public static bool FormatHasAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/graphics/PixelXorXfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/PixelXorXfermode", AccessFlags = 33)]
		public partial class PixelXorXfermode : global::Android.Graphics.Xfermode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PixelXorXfermode(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PixelXorXfermode() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Point
		/// </java-name>
		[Dot42.DexImport("android/graphics/Point", AccessFlags = 33)]
		public partial class Point : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "I", AccessFlags = 1)]
				public int X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "I", AccessFlags = 1)]
				public int Y;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.Point> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Point() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Point(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Point;)V", AccessFlags = 1)]
				public Point(global::Android.Graphics.Point point) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()V", AccessFlags = 17)]
				public void Negate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(II)V", AccessFlags = 17)]
				public void Offset(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(II)Z", AccessFlags = 17)]
				public bool Equals(int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/PointF
		/// </java-name>
		[Dot42.DexImport("android/graphics/PointF", AccessFlags = 33)]
		public partial class PointF : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "F", AccessFlags = 1)]
				public float X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "F", AccessFlags = 1)]
				public float Y;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.PointF> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PointF() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public PointF(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Point;)V", AccessFlags = 1)]
				public PointF(global::Android.Graphics.Point point) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(FF)V", AccessFlags = 17)]
				public void Set(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/PointF;)V", AccessFlags = 17)]
				public void Set(global::Android.Graphics.PointF pointF) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()V", AccessFlags = 17)]
				public void Negate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FF)V", AccessFlags = 17)]
				public void Offset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(FF)Z", AccessFlags = 17)]
				public bool Equals(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()F", AccessFlags = 17)]
				public float Length() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "(FF)F", AccessFlags = 9)]
				public static float Length(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
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

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/PorterDuff
		/// </java-name>
		[Dot42.DexImport("android/graphics/PorterDuff", AccessFlags = 33)]
		public partial class PorterDuff
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PorterDuff() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/graphics/PorterDuff$Mode
				/// </java-name>
				[Dot42.DexImport("android/graphics/PorterDuff$Mode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/PorterDuff$Mode;>;")]
				public sealed class Mode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ADD
						/// </java-name>
						[Dot42.DexImport("ADD", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode ADD;
						/// <java-name>
						/// CLEAR
						/// </java-name>
						[Dot42.DexImport("CLEAR", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode CLEAR;
						/// <java-name>
						/// DARKEN
						/// </java-name>
						[Dot42.DexImport("DARKEN", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DARKEN;
						/// <java-name>
						/// DST
						/// </java-name>
						[Dot42.DexImport("DST", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DST;
						/// <java-name>
						/// DST_ATOP
						/// </java-name>
						[Dot42.DexImport("DST_ATOP", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DST_ATOP;
						/// <java-name>
						/// DST_IN
						/// </java-name>
						[Dot42.DexImport("DST_IN", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DST_IN;
						/// <java-name>
						/// DST_OUT
						/// </java-name>
						[Dot42.DexImport("DST_OUT", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DST_OUT;
						/// <java-name>
						/// DST_OVER
						/// </java-name>
						[Dot42.DexImport("DST_OVER", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode DST_OVER;
						/// <java-name>
						/// LIGHTEN
						/// </java-name>
						[Dot42.DexImport("LIGHTEN", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode LIGHTEN;
						/// <java-name>
						/// MULTIPLY
						/// </java-name>
						[Dot42.DexImport("MULTIPLY", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode MULTIPLY;
						/// <java-name>
						/// OVERLAY
						/// </java-name>
						[Dot42.DexImport("OVERLAY", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode OVERLAY;
						/// <java-name>
						/// SCREEN
						/// </java-name>
						[Dot42.DexImport("SCREEN", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SCREEN;
						/// <java-name>
						/// SRC
						/// </java-name>
						[Dot42.DexImport("SRC", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SRC;
						/// <java-name>
						/// SRC_ATOP
						/// </java-name>
						[Dot42.DexImport("SRC_ATOP", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SRC_ATOP;
						/// <java-name>
						/// SRC_IN
						/// </java-name>
						[Dot42.DexImport("SRC_IN", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SRC_IN;
						/// <java-name>
						/// SRC_OUT
						/// </java-name>
						[Dot42.DexImport("SRC_OUT", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SRC_OUT;
						/// <java-name>
						/// SRC_OVER
						/// </java-name>
						[Dot42.DexImport("SRC_OVER", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode SRC_OVER;
						/// <java-name>
						/// XOR
						/// </java-name>
						[Dot42.DexImport("XOR", "Landroid/graphics/PorterDuff$Mode;", AccessFlags = 16409)]
						public static readonly Mode XOR;
						private Mode() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/PorterDuff$Mode;", AccessFlags = 9)]
						public static Mode[] Values() /* MethodBuilder.Create */ 
						{
								return default(Mode[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;", AccessFlags = 9)]
						public static Mode ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Mode);
						}

				}

		}

		/// <java-name>
		/// android/graphics/PorterDuffColorFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/PorterDuffColorFilter", AccessFlags = 33)]
		public partial class PorterDuffColorFilter : global::Android.Graphics.ColorFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public PorterDuffColorFilter(int int32, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PorterDuffColorFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/PorterDuffXfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/PorterDuffXfermode", AccessFlags = 33)]
		public partial class PorterDuffXfermode : global::Android.Graphics.Xfermode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public PorterDuffXfermode(global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PorterDuffXfermode() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/RadialGradient
		/// </java-name>
		[Dot42.DexImport("android/graphics/RadialGradient", AccessFlags = 33)]
		public partial class RadialGradient : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FFF[I[FLandroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public RadialGradient(float single, float single1, float single2, int[] int32, float[] single3, global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFIILandroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public RadialGradient(float single, float single1, float single2, int int32, int int321, global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RadialGradient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Rasterizer
		/// </java-name>
		[Dot42.DexImport("android/graphics/Rasterizer", AccessFlags = 33)]
		public partial class Rasterizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Rasterizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Rasterizer() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/Rect
		/// </java-name>
		[Dot42.DexImport("android/graphics/Rect", AccessFlags = 49)]
		public sealed partial class Rect : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "I", AccessFlags = 1)]
				public int Left;
				/// <java-name>
				/// top
				/// </java-name>
				[Dot42.DexImport("top", "I", AccessFlags = 1)]
				public int Top;
				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "I", AccessFlags = 1)]
				public int Right;
				/// <java-name>
				/// bottom
				/// </java-name>
				[Dot42.DexImport("bottom", "I", AccessFlags = 1)]
				public int Bottom;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.Rect> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Rect() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
				public Rect(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public Rect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// flattenToString
				/// </java-name>
				[Dot42.DexImport("flattenToString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// unflattenFromString
				/// </java-name>
				[Dot42.DexImport("unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;", AccessFlags = 9)]
				public static global::Android.Graphics.Rect UnflattenFromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 17)]
				public bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "()I", AccessFlags = 17)]
				public int Width() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "()I", AccessFlags = 17)]
				public int Height() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// centerX
				/// </java-name>
				[Dot42.DexImport("centerX", "()I", AccessFlags = 17)]
				public int CenterX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// centerY
				/// </java-name>
				[Dot42.DexImport("centerY", "()I", AccessFlags = 17)]
				public int CenterY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// exactCenterX
				/// </java-name>
				[Dot42.DexImport("exactCenterX", "()F", AccessFlags = 17)]
				public float ExactCenterX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// exactCenterY
				/// </java-name>
				[Dot42.DexImport("exactCenterY", "()F", AccessFlags = 17)]
				public float ExactCenterY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIII)V", AccessFlags = 1)]
				public void Set(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public void Set(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(II)V", AccessFlags = 1)]
				public void Offset(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offsetTo
				/// </java-name>
				[Dot42.DexImport("offsetTo", "(II)V", AccessFlags = 1)]
				public void OffsetTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inset
				/// </java-name>
				[Dot42.DexImport("inset", "(II)V", AccessFlags = 1)]
				public void Inset(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(II)Z", AccessFlags = 1)]
				public bool Contains(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(IIII)Z", AccessFlags = 1)]
				public bool Contains(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool Contains(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(IIII)Z", AccessFlags = 1)]
				public bool Intersect(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool Intersect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setIntersect
				/// </java-name>
				[Dot42.DexImport("setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool SetIntersect(global::Android.Graphics.Rect rect, global::Android.Graphics.Rect rect1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(IIII)Z", AccessFlags = 1)]
				public bool Intersects(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", AccessFlags = 9)]
				public static bool Intersects(global::Android.Graphics.Rect rect, global::Android.Graphics.Rect rect1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(IIII)V", AccessFlags = 1)]
				public void Union(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public void Union(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(II)V", AccessFlags = 1)]
				public void Union(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "()V", AccessFlags = 1)]
				public void Sort() /* MethodBuilder.Create */ 
				{
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

		}

		/// <java-name>
		/// android/graphics/RectF
		/// </java-name>
		[Dot42.DexImport("android/graphics/RectF", AccessFlags = 33)]
		public partial class RectF : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "F", AccessFlags = 1)]
				public float Left;
				/// <java-name>
				/// top
				/// </java-name>
				[Dot42.DexImport("top", "F", AccessFlags = 1)]
				public float Top;
				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "F", AccessFlags = 1)]
				public float Right;
				/// <java-name>
				/// bottom
				/// </java-name>
				[Dot42.DexImport("bottom", "F", AccessFlags = 1)]
				public float Bottom;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.RectF> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RectF() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public RectF(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public RectF(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public RectF(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
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
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 17)]
				public bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "()F", AccessFlags = 17)]
				public float Width() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "()F", AccessFlags = 17)]
				public float Height() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// centerX
				/// </java-name>
				[Dot42.DexImport("centerX", "()F", AccessFlags = 17)]
				public float CenterX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// centerY
				/// </java-name>
				[Dot42.DexImport("centerY", "()F", AccessFlags = 17)]
				public float CenterY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public virtual void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(FFFF)V", AccessFlags = 1)]
				public virtual void Set(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FF)V", AccessFlags = 1)]
				public virtual void Offset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offsetTo
				/// </java-name>
				[Dot42.DexImport("offsetTo", "(FF)V", AccessFlags = 1)]
				public virtual void OffsetTo(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inset
				/// </java-name>
				[Dot42.DexImport("inset", "(FF)V", AccessFlags = 1)]
				public virtual void Inset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(FF)Z", AccessFlags = 1)]
				public virtual bool Contains(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Contains(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool Contains(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Intersect(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool Intersect(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setIntersect
				/// </java-name>
				[Dot42.DexImport("setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool SetIntersect(global::Android.Graphics.RectF rectF, global::Android.Graphics.RectF rectF1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Intersects(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 9)]
				public static bool Intersects(global::Android.Graphics.RectF rectF, global::Android.Graphics.RectF rectF1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Round(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// roundOut
				/// </java-name>
				[Dot42.DexImport("roundOut", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void RoundOut(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(FFFF)V", AccessFlags = 1)]
				public virtual void Union(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Union(global::Android.Graphics.RectF rectF) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(FF)V", AccessFlags = 1)]
				public virtual void Union(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "()V", AccessFlags = 1)]
				public virtual void Sort() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Region
		/// </java-name>
		[Dot42.DexImport("android/graphics/Region", AccessFlags = 33)]
		public partial class Region : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Graphics.Region> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Region() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Region;)V", AccessFlags = 1)]
				public Region(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public Region(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
				public Region(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public virtual void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool Set(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool Set(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIII)Z", AccessFlags = 1)]
				public virtual bool Set(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool SetPath(global::Android.Graphics.Path path, global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 257)]
				public virtual bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isRect
				/// </java-name>
				[Dot42.DexImport("isRect", "()Z", AccessFlags = 257)]
				public virtual bool IsRect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isComplex
				/// </java-name>
				[Dot42.DexImport("isComplex", "()Z", AccessFlags = 257)]
				public virtual bool IsComplex() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rect GetBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBoundaryPath
				/// </java-name>
				[Dot42.DexImport("getBoundaryPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path GetBoundaryPath() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// getBoundaryPath
				/// </java-name>
				[Dot42.DexImport("getBoundaryPath", "(Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool GetBoundaryPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(II)Z", AccessFlags = 257)]
				public virtual bool Contains(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickContains
				/// </java-name>
				[Dot42.DexImport("quickContains", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool QuickContains(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickContains
				/// </java-name>
				[Dot42.DexImport("quickContains", "(IIII)Z", AccessFlags = 257)]
				public virtual bool QuickContains(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(IIII)Z", AccessFlags = 257)]
				public virtual bool QuickReject(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/Region;)Z", AccessFlags = 257)]
				public virtual bool QuickReject(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(II)V", AccessFlags = 1)]
				public virtual void Translate(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(IILandroid/graphics/Region;)V", AccessFlags = 257)]
				public virtual void Translate(int int32, int int321, global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool Union(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool Op(global::Android.Graphics.Rect rect, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(IIIILandroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool Op(int int32, int int321, int int322, int int323, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool Op(global::Android.Graphics.Region region, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool Op(global::Android.Graphics.Rect rect, global::Android.Graphics.Region region, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z" +
    "", AccessFlags = 1)]
				public virtual bool Op(global::Android.Graphics.Region region, global::Android.Graphics.Region region1, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Region() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBounds
				/// </java-name>
				public global::Android.Graphics.Rect Bounds
				{
				[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return GetBounds(); }
				}

				/// <java-name>
				/// getBoundaryPath
				/// </java-name>
				public global::Android.Graphics.Path BoundaryPath
				{
				[Dot42.DexImport("getBoundaryPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
						get{ return GetBoundaryPath(); }
				}

				/// <java-name>
				/// android/graphics/Region$Op
				/// </java-name>
				[Dot42.DexImport("android/graphics/Region$Op", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Region$Op;>;")]
				public sealed class JavaOp
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DIFFERENCE
						/// </java-name>
						[Dot42.DexImport("DIFFERENCE", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp DIFFERENCE;
						/// <java-name>
						/// INTERSECT
						/// </java-name>
						[Dot42.DexImport("INTERSECT", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp INTERSECT;
						/// <java-name>
						/// REPLACE
						/// </java-name>
						[Dot42.DexImport("REPLACE", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp REPLACE;
						/// <java-name>
						/// REVERSE_DIFFERENCE
						/// </java-name>
						[Dot42.DexImport("REVERSE_DIFFERENCE", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp REVERSE_DIFFERENCE;
						/// <java-name>
						/// UNION
						/// </java-name>
						[Dot42.DexImport("UNION", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp UNION;
						/// <java-name>
						/// XOR
						/// </java-name>
						[Dot42.DexImport("XOR", "Landroid/graphics/Region$Op;", AccessFlags = 16409)]
						public static readonly JavaOp XOR;
						private JavaOp() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Region$Op;", AccessFlags = 9)]
						public static JavaOp[] Values() /* MethodBuilder.Create */ 
						{
								return default(JavaOp[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;", AccessFlags = 9)]
						public static JavaOp ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(JavaOp);
						}

				}

		}

		/// <java-name>
		/// android/graphics/RegionIterator
		/// </java-name>
		[Dot42.DexImport("android/graphics/RegionIterator", AccessFlags = 33)]
		public partial class RegionIterator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Region;)V", AccessFlags = 1)]
				public RegionIterator(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool Next(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~RegionIterator() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RegionIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Shader
		/// </java-name>
		[Dot42.DexImport("android/graphics/Shader", AccessFlags = 33)]
		public partial class Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Shader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalMatrix
				/// </java-name>
				[Dot42.DexImport("getLocalMatrix", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool GetLocalMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLocalMatrix
				/// </java-name>
				[Dot42.DexImport("setLocalMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void SetLocalMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Shader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/graphics/Shader$TileMode
				/// </java-name>
				[Dot42.DexImport("android/graphics/Shader$TileMode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/Shader$TileMode;>;")]
				public sealed class TileMode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLAMP
						/// </java-name>
						[Dot42.DexImport("CLAMP", "Landroid/graphics/Shader$TileMode;", AccessFlags = 16409)]
						public static readonly TileMode CLAMP;
						/// <java-name>
						/// MIRROR
						/// </java-name>
						[Dot42.DexImport("MIRROR", "Landroid/graphics/Shader$TileMode;", AccessFlags = 16409)]
						public static readonly TileMode MIRROR;
						/// <java-name>
						/// REPEAT
						/// </java-name>
						[Dot42.DexImport("REPEAT", "Landroid/graphics/Shader$TileMode;", AccessFlags = 16409)]
						public static readonly TileMode REPEAT;
						private TileMode() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/Shader$TileMode;", AccessFlags = 9)]
						public static TileMode[] Values() /* MethodBuilder.Create */ 
						{
								return default(TileMode[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;", AccessFlags = 9)]
						public static TileMode ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(TileMode);
						}

				}

		}

		/// <java-name>
		/// android/graphics/SumPathEffect
		/// </java-name>
		[Dot42.DexImport("android/graphics/SumPathEffect", AccessFlags = 33)]
		public partial class SumPathEffect : global::Android.Graphics.PathEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V", AccessFlags = 1)]
				public SumPathEffect(global::Android.Graphics.PathEffect pathEffect, global::Android.Graphics.PathEffect pathEffect1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SumPathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/SurfaceTexture
		/// </java-name>
		[Dot42.DexImport("android/graphics/SurfaceTexture", AccessFlags = 33)]
		public partial class SurfaceTexture
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SurfaceTexture(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnFrameAvailableListener
				/// </java-name>
				[Dot42.DexImport("setOnFrameAvailableListener", "(Landroid/graphics/SurfaceTexture$OnFrameAvailableListener;)V", AccessFlags = 1)]
				public virtual void SetOnFrameAvailableListener(global::Android.Graphics.SurfaceTexture.IOnFrameAvailableListener onFrameAvailableListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultBufferSize
				/// </java-name>
				[Dot42.DexImport("setDefaultBufferSize", "(II)V", AccessFlags = 1)]
				public virtual void SetDefaultBufferSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateTexImage
				/// </java-name>
				[Dot42.DexImport("updateTexImage", "()V", AccessFlags = 1)]
				public virtual void UpdateTexImage() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTransformMatrix
				/// </java-name>
				[Dot42.DexImport("getTransformMatrix", "([F)V", AccessFlags = 1)]
				public virtual void GetTransformMatrix(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "()J", AccessFlags = 1)]
				public virtual long GetTimestamp() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SurfaceTexture() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SurfaceTexture() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				public long Timestamp
				{
				[Dot42.DexImport("getTimestamp", "()J", AccessFlags = 1)]
						get{ return GetTimestamp(); }
				}

				/// <java-name>
				/// android/graphics/SurfaceTexture$OutOfResourcesException
				/// </java-name>
				[Dot42.DexImport("android/graphics/SurfaceTexture$OutOfResourcesException", AccessFlags = 9)]
				public partial class OutOfResourcesException : global::System.Exception
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public OutOfResourcesException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public OutOfResourcesException(string @string) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/graphics/SurfaceTexture$OnFrameAvailableListener
				/// </java-name>
				[Dot42.DexImport("android/graphics/SurfaceTexture$OnFrameAvailableListener", AccessFlags = 1545)]
				public partial interface IOnFrameAvailableListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onFrameAvailable
						/// </java-name>
						[Dot42.DexImport("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 1025)]
						void OnFrameAvailable(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/graphics/SweepGradient
		/// </java-name>
		[Dot42.DexImport("android/graphics/SweepGradient", AccessFlags = 33)]
		public partial class SweepGradient : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FF[I[F)V", AccessFlags = 1)]
				public SweepGradient(float single, float single1, int[] int32, float[] single2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFII)V", AccessFlags = 1)]
				public SweepGradient(float single, float single1, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SweepGradient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/Typeface
		/// </java-name>
		[Dot42.DexImport("android/graphics/Typeface", AccessFlags = 33)]
		public partial class Typeface
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface DEFAULT;
				/// <java-name>
				/// DEFAULT_BOLD
				/// </java-name>
				[Dot42.DexImport("DEFAULT_BOLD", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface DEFAULT_BOLD;
				/// <java-name>
				/// SANS_SERIF
				/// </java-name>
				[Dot42.DexImport("SANS_SERIF", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface SANS_SERIF;
				/// <java-name>
				/// SERIF
				/// </java-name>
				[Dot42.DexImport("SERIF", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface SERIF;
				/// <java-name>
				/// MONOSPACE
				/// </java-name>
				[Dot42.DexImport("MONOSPACE", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface MONOSPACE;
				/// <java-name>
				/// NORMAL
				/// </java-name>
				[Dot42.DexImport("NORMAL", "I", AccessFlags = 25)]
				public const int NORMAL = 0;
				/// <java-name>
				/// BOLD
				/// </java-name>
				[Dot42.DexImport("BOLD", "I", AccessFlags = 25)]
				public const int BOLD = 1;
				/// <java-name>
				/// ITALIC
				/// </java-name>
				[Dot42.DexImport("ITALIC", "I", AccessFlags = 25)]
				public const int ITALIC = 2;
				/// <java-name>
				/// BOLD_ITALIC
				/// </java-name>
				[Dot42.DexImport("BOLD_ITALIC", "I", AccessFlags = 25)]
				public const int BOLD_ITALIC = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Typeface() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStyle
				/// </java-name>
				[Dot42.DexImport("getStyle", "()I", AccessFlags = 1)]
				public virtual int GetStyle() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isBold
				/// </java-name>
				[Dot42.DexImport("isBold", "()Z", AccessFlags = 17)]
				public bool IsBold() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isItalic
				/// </java-name>
				[Dot42.DexImport("isItalic", "()Z", AccessFlags = 17)]
				public bool IsItalic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface Create(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface Create(global::Android.Graphics.Typeface typeface, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// defaultFromStyle
				/// </java-name>
				[Dot42.DexImport("defaultFromStyle", "(I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface DefaultFromStyle(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;" +
    "", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromAsset(global::Android.Content.Res.AssetManager assetManager, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Typeface() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStyle
				/// </java-name>
				public int Style
				{
				[Dot42.DexImport("getStyle", "()I", AccessFlags = 1)]
						get{ return GetStyle(); }
				}

		}

		/// <java-name>
		/// android/graphics/Xfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/Xfermode", AccessFlags = 33)]
		public partial class Xfermode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Xfermode() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Xfermode() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/YuvImage
		/// </java-name>
		[Dot42.DexImport("android/graphics/YuvImage", AccessFlags = 33)]
		public partial class YuvImage
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([BIII[I)V", AccessFlags = 1)]
				public YuvImage(sbyte[] sByte, int int32, int int321, int int322, int[] int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIII[I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public YuvImage(byte[] @byte, int int32, int int321, int int322, int[] int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compressToJpeg
				/// </java-name>
				[Dot42.DexImport("compressToJpeg", "(Landroid/graphics/Rect;ILjava/io/OutputStream;)Z", AccessFlags = 1)]
				public virtual bool CompressToJpeg(global::Android.Graphics.Rect rect, int int32, global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getYuvData
				/// </java-name>
				[Dot42.DexImport("getYuvData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetYuvData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getYuvData
				/// </java-name>
				[Dot42.DexImport("getYuvData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetYuvData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getYuvFormat
				/// </java-name>
				[Dot42.DexImport("getYuvFormat", "()I", AccessFlags = 1)]
				public virtual int GetYuvFormat() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStrides
				/// </java-name>
				[Dot42.DexImport("getStrides", "()[I", AccessFlags = 1)]
				public virtual int[] GetStrides() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal YuvImage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getYuvData
				/// </java-name>
				public byte[] YuvData
				{
				[Dot42.DexImport("getYuvData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetYuvData(); }
				}

				/// <java-name>
				/// getYuvFormat
				/// </java-name>
				public int YuvFormat
				{
				[Dot42.DexImport("getYuvFormat", "()I", AccessFlags = 1)]
						get{ return GetYuvFormat(); }
				}

				/// <java-name>
				/// getStrides
				/// </java-name>
				public int[] Strides
				{
				[Dot42.DexImport("getStrides", "()[I", AccessFlags = 1)]
						get{ return GetStrides(); }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

		}

}

