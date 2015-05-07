#pragma warning disable 1717
namespace Android.Graphics
{
		/// <summary>
		///  <para>AvoidXfermode xfermode will draw the src everywhere except on top of the opColor or, depending on the Mode, draw only on top of the opColor. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/AvoidXfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/AvoidXfermode", AccessFlags = 33)]
		public partial class AvoidXfermode : global::Android.Graphics.Xfermode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This xfermode draws, or doesn't draw, based on the destination's distance from an op-color.</para> <para>There are two modes, and each mode interprets a tolerance value.</para> <para>Avoid: In this mode, drawing is allowed only on destination pixels that are different from the op-color. Tolerance near 0: avoid any colors even remotely similar to the op-color Tolerance near 255: avoid only colors nearly identical to the op-color</para> <para>Target: In this mode, drawing only occurs on destination pixels that are similar to the op-color Tolerance near 0: draw only on colors that are nearly identical to the op-color Tolerance near 255: draw on any colors even remotely similar to the op-color </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V", AccessFlags = 1)]
				public AvoidXfermode(int opColor, int tolerance, global::Android.Graphics.AvoidXfermode.Mode mode) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Indicates that the bitmap was created for an unknown pixel density.</para> <para> <para>Bitmap::getDensity() </para> <para>Bitmap::setDensity(int) </para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Free the native object associated with this bitmap, and clear the reference to the pixel data. This will not free the pixel data synchronously; it simply allows it to be garbage collected if there are no other references. The bitmap is marked as "dead", meaning it will throw an exception if getPixels() or setPixels() is called, and will draw nothing. This operation cannot be reversed, so it should only be called if you are sure there are no further uses for the bitmap. This is an advanced call, and normally need not be called, since the normal GC process will free up this memory when there are no more references to this bitmap. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the bitmap's pixels into the specified buffer (allocated by the caller). An exception is thrown if the buffer is not large enough to hold all of the pixels (taking into account the number of bytes per pixel) or if the Buffer subclass is not one of the support types (ByteBuffer, ShortBuffer, IntBuffer).</para> <para>The content of the bitmap is copied into the buffer as-is. This means that if this bitmap stores its pixels pre-multiplied (see isPremultiplied(), the values in the buffer will also be pre-multiplied.</para> <para>After this method returns, the current position of the buffer is updated: the position is incremented by the number of elements written in the buffer.</para>        
				/// </summary>
				/// <java-name>
				/// copyPixelsToBuffer
				/// </java-name>
				[Dot42.DexImport("copyPixelsToBuffer", "(Ljava/nio/Buffer;)V", AccessFlags = 1)]
				public void CopyPixelsToBuffer(global::Java.Nio.Buffer dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the pixels from the buffer, beginning at the current position, overwriting the bitmap's pixels. The data in the buffer is not changed in any way (unlike setPixels(), which converts from unpremultipled 32bit to whatever the bitmap's native format is.</para> <para>After this method returns, the current position of the buffer is updated: the position is incremented by the number of elements read from the buffer. If you need to read the bitmap from the buffer again you must first rewind the buffer.</para>        
				/// </summary>
				/// <java-name>
				/// copyPixelsFromBuffer
				/// </java-name>
				[Dot42.DexImport("copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V", AccessFlags = 1)]
				public void CopyPixelsFromBuffer(global::Java.Nio.Buffer src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tries to make a new bitmap based on the dimensions of this bitmap, setting the new bitmap's config to the one specified, and then copying this bitmap's pixels into the new bitmap. If the conversion is not supported, or the allocator fails, then this returns NULL. The returned bitmap initially has the same density as the original.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new bitmap, or null if the copy could not be made. </para>
				/// </returns>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap Copy(global::Android.Graphics.Bitmap.Config config, bool isMutable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Creates a new bitmap, scaled from an existing bitmap, when possible. If the specified width and height are the same as the current width and height of the source bitmap, the source bitmap is returned and no new bitmap is created.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new scaled bitmap or the source bitmap if no scaling is required. </para>
				/// </returns>
				/// <java-name>
				/// createScaledBitmap
				/// </java-name>
				[Dot42.DexImport("createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateScaledBitmap(global::Android.Graphics.Bitmap src, int dstWidth, int dstHeight, bool filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Returns an immutable bitmap from the source bitmap. The new bitmap may be the same object as source, or a copy may have been made. It is initialized with the same density as the original bitmap. </para>        
				/// </summary>
				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(global::Android.Graphics.Bitmap src) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Returns an immutable bitmap from the specified subset of the source bitmap. The new bitmap may be the same object as source, or a copy may have been made. It is initialized with the same density as the original bitmap.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A copy of a subset of the source bitmap or the source bitmap itself. </para>
				/// </returns>
				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(global::Android.Graphics.Bitmap source, int x, int y, int width, int height) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns a mutable bitmap with the specified width and height. Its initial density is as per getDensity.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(int width, int height, global::Android.Graphics.Bitmap.Config config) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Returns a immutable bitmap with the specified width and height, with each pixel value set to the corresponding value in the colors array. Its initial density is as per getDensity.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createBitmap
				/// </java-name>
				[Dot42.DexImport("createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateBitmap(int[] colors, int offset, int stride, int width, int height, global::Android.Graphics.Bitmap.Config config) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns an optional array of private data, used by the UI system for some bitmaps. Not intended to be called by applications. </para>        
				/// </summary>
				/// <java-name>
				/// getNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("getNinePatchChunk", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetNinePatchChunk() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Write a compressed version of the bitmap to the specified outputstream. If this returns true, the bitmap can be reconstructed by passing a corresponding inputstream to BitmapFactory.decodeStream(). Note: not all Formats support all bitmap configs directly, so it is possible that the returned bitmap from BitmapFactory could be in a different bitdepth, and/or may have lost per-pixel alpha (e.g. JPEG only supports opaque pixels).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if successfully compressed to the specified stream. </para>
				/// </returns>
				/// <java-name>
				/// compress
				/// </java-name>
				[Dot42.DexImport("compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z", AccessFlags = 1)]
				public bool Compress(global::Android.Graphics.Bitmap.CompressFormat format, int quality, global::Java.IO.OutputStream stream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledWidth(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(Landroid/graphics/Canvas;)I", AccessFlags = 1)]
				public int GetScaledWidth(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledHeight(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(Landroid/graphics/Canvas;)I", AccessFlags = 1)]
				public int GetScaledHeight(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledWidth(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(Landroid/util/DisplayMetrics;)I", AccessFlags = 1)]
				public int GetScaledWidth(global::Android.Util.DisplayMetrics canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledHeight(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(Landroid/util/DisplayMetrics;)I", AccessFlags = 1)]
				public int GetScaledHeight(global::Android.Util.DisplayMetrics canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledWidth(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledWidth
				/// </java-name>
				[Dot42.DexImport("getScaledWidth", "(I)I", AccessFlags = 1)]
				public int GetScaledWidth(int canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for calling getScaledHeight(int) with the target density of the given Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// getScaledHeight
				/// </java-name>
				[Dot42.DexImport("getScaledHeight", "(I)I", AccessFlags = 1)]
				public int GetScaledHeight(int canvas) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>If the bitmap's internal config is in one of the public formats, return that config, otherwise return null. </para>        
				/// </summary>
				/// <java-name>
				/// getConfig
				/// </java-name>
				[Dot42.DexImport("getConfig", "()Landroid/graphics/Bitmap$Config;", AccessFlags = 17)]
				public global::Android.Graphics.Bitmap.Config GetConfig() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap.Config);
				}

				/// <summary>
				///  <para>Tell the bitmap if all of the pixels are known to be opaque (false) or if some of the pixels may contain non-opaque alpha values (true). Note, for some configs (e.g. RGB_565) this call is ignored, since it does not support per-pixel alpha values.</para> <para>This is meant as a drawing hint, as in some cases a bitmap that is known to be opaque can take a faster drawing case than one that may have non-opaque per-pixel alpha values. </para>        
				/// </summary>
				/// <java-name>
				/// setHasAlpha
				/// </java-name>
				[Dot42.DexImport("setHasAlpha", "(Z)V", AccessFlags = 1)]
				public void SetHasAlpha(bool hasAlpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fills the bitmap's pixels with the specified Color.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// eraseColor
				/// </java-name>
				[Dot42.DexImport("eraseColor", "(I)V", AccessFlags = 1)]
				public void EraseColor(int c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the Color at the specified location. Throws an exception if x or y are out of bounds (negative or &gt;= to the width or height respectively). The returned color is a non-premultiplied ARGB value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The argb Color at the specified coordinate </para>
				/// </returns>
				/// <java-name>
				/// getPixel
				/// </java-name>
				[Dot42.DexImport("getPixel", "(II)I", AccessFlags = 1)]
				public int GetPixel(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns in pixels[] a copy of the data in the bitmap. Each value is a packed int representing a Color. The stride parameter allows the caller to allow for gaps in the returned pixels array between rows. For normal packed results, just pass width for the stride value. The returned colors are non-premultiplied ARGB values.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getPixels
				/// </java-name>
				[Dot42.DexImport("getPixels", "([IIIIIII)V", AccessFlags = 1)]
				public void GetPixels(int[] pixels, int offset, int stride, int x, int y, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write the specified Color into the bitmap (assuming it is mutable) at the x,y coordinate. The color must be a non-premultiplied ARGB value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPixel
				/// </java-name>
				[Dot42.DexImport("setPixel", "(III)V", AccessFlags = 1)]
				public void SetPixel(int x, int y, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Replace pixels in the bitmap with the colors in the array. Each element in the array is a packed int prepresenting a non-premultiplied ARGB Color.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPixels
				/// </java-name>
				[Dot42.DexImport("setPixels", "([IIIIIII)V", AccessFlags = 1)]
				public void SetPixels(int[] pixels, int offset, int stride, int x, int y, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>No special parcel contents. </para>        
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
				///  <para>Write the bitmap and its pixels to the parcel. The bitmap can be rebuilt from the parcel by calling CREATOR.createFromParcel(). </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel p, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new bitmap that captures the alpha values of the original. This may be drawn with Canvas.drawBitmap(), where the color(s) will be taken from the paint that is passed to the draw call.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>new bitmap containing the alpha channel of the original bitmap. </para>
				/// </returns>
				/// <java-name>
				/// extractAlpha
				/// </java-name>
				[Dot42.DexImport("extractAlpha", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap ExtractAlpha() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Returns a new bitmap that captures the alpha values of the original. These values may be affected by the optional Paint parameter, which can contain its own alpha, and may also contain a MaskFilter which could change the actual dimensions of the resulting bitmap (e.g. a blur maskfilter might enlarge the resulting bitmap). If offsetXY is not null, it returns the amount to offset the returned bitmap so that it will logically align with the original. For example, if the paint contains a blur of radius 2, then offsetXY[] would contains -2, -2, so that drawing the alpha bitmap offset by (-2, -2) and then drawing the original would result in the blur visually aligning with the original.</para> <para>The initial density of the returned bitmap is the same as the original's.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>new bitmap containing the (optionally modified by paint) alpha channel of the original bitmap. This may be drawn with Canvas.drawBitmap(), where the color(s) will be taken from the paint that is passed to the draw call. </para>
				/// </returns>
				/// <java-name>
				/// extractAlpha
				/// </java-name>
				[Dot42.DexImport("extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap ExtractAlpha(global::Android.Graphics.Paint paint, int[] offsetXY) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Given another bitmap, return true if it has the same dimensions, config, and pixel data as this bitmap. If any of those differ, return false. If other is null, return false. </para>        
				/// </summary>
				/// <java-name>
				/// sameAs
				/// </java-name>
				[Dot42.DexImport("sameAs", "(Landroid/graphics/Bitmap;)Z", AccessFlags = 1)]
				public bool SameAs(global::Android.Graphics.Bitmap other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Rebuilds any caches associated with the bitmap that are used for drawing it. In the case of purgeable bitmaps, this call will attempt to ensure that the pixels have been decoded. If this is called on more than one bitmap in sequence, the priority is given in LRU order (i.e. the last bitmap called will be given highest priority).</para> <para>For bitmaps with no associated caches, this call is effectively a no-op, and therefore is harmless. </para>        
				/// </summary>
				/// <java-name>
				/// prepareToDraw
				/// </java-name>
				[Dot42.DexImport("prepareToDraw", "()V", AccessFlags = 1)]
				public void PrepareToDraw() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the density for this bitmap.</para> <para>The default density is the same density as the current display, unless the current application does not support different screen densities in which case it is android.util.DisplayMetrics#DENSITY_DEFAULT. Note that compatibility mode is determined by the application that was initially loaded into a process  applications that share the same process should all have the same compatibility, or ensure they explicitly set the density of their bitmaps appropriately.</para> <para> <para>setDensity(int) </para> <para>android.util.DisplayMetrics::DENSITY_DEFAULT </para> <para>android.util.DisplayMetrics::densityDpi </para> <para>DENSITY_NONE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A scaling factor of the default density or DENSITY_NONE if the scaling factor is unknown.</para>
				/// </returns>
				/// <java-name>
				/// getDensity
				/// </java-name>
				public int Density
				{
						[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns true if this bitmap has been recycled. If so, then it is an error to try to access its pixels, and the bitmap will not draw.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the bitmap has been recycled </para>
				/// </returns>
				/// <java-name>
				/// isRecycled
				/// </java-name>
				public bool IsRecycled
				{
						[Dot42.DexImport("isRecycled", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the generation ID of this bitmap. The generation ID changes whenever the bitmap is modified. This can be used as an efficient way to check if a bitmap has changed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current generation ID for this bitmap. </para>
				/// </returns>
				/// <java-name>
				/// getGenerationId
				/// </java-name>
				public int GenerationId
				{
						[Dot42.DexImport("getGenerationId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns an optional array of private data, used by the UI system for some bitmaps. Not intended to be called by applications. </para>        
				/// </summary>
				/// <java-name>
				/// getNinePatchChunk
				/// </java-name>
				public byte[] NinePatchChunk
				{
						[Dot42.DexImport("getNinePatchChunk", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns true if the bitmap is marked as mutable (i.e. can be drawn into) </para>        
				/// </summary>
				/// <java-name>
				/// isMutable
				/// </java-name>
				public bool IsMutable
				{
						[Dot42.DexImport("isMutable", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the bitmap's width </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the bitmap's height </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the number of bytes between rows in the bitmap's pixels. Note that this refers to the pixels as stored natively by the bitmap. If you call getPixels() or setPixels(), then the pixels are uniformly treated as 32bit values, packed according to the Color class.</para> <para>As of android.os.Build.VERSION_CODES#KITKAT, this method should not be used to calculate the memory usage of the bitmap. Instead, see getAllocationByteCount().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of bytes between rows of the native bitmap pixels. </para>
				/// </returns>
				/// <java-name>
				/// getRowBytes
				/// </java-name>
				public int RowBytes
				{
						[Dot42.DexImport("getRowBytes", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the minimum number of bytes that can be used to store this bitmap's pixels.</para> <para>As of android.os.Build.VERSION_CODES#KITKAT, the result of this method can no longer be used to determine memory usage of a bitmap. See getAllocationByteCount().</para>        
				/// </summary>
				/// <java-name>
				/// getByteCount
				/// </java-name>
				public int ByteCount
				{
						[Dot42.DexImport("getByteCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns true if the bitmap's config supports per-pixel alpha, and if the pixels may contain non-opaque alpha values. For some configs, this is always false (e.g. RGB_565), since they do not support per-pixel alpha. However, for configs that do, the bitmap may be flagged to be known that all of its pixels are opaque. In this case hasAlpha() will also return false. If a config such as ARGB_8888 is not so flagged, it will return true by default. </para>        
				/// </summary>
				/// <java-name>
				/// hasAlpha
				/// </java-name>
				public bool HasAlpha
				{
						[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
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

		/// <summary>
		///  <para>Creates Bitmap objects from various sources, including files, streams, and byte-arrays. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Decode a file path into a bitmap. If the specified file name is null, or cannot be decoded into a bitmap, the function returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded, or, if opts is non-null, if opts requested only the size be returned (in opts.outWidth and opts.outHeight) </para>
				/// </returns>
				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bit" +
    "map;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFile(string pathName, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode a file path into a bitmap. If the specified file name is null, or cannot be decoded into a bitmap, the function returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the resulting decoded bitmap, or null if it could not be decoded. </para>
				/// </returns>
				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFile(string pathName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode a new Bitmap from an InputStream. This InputStream was obtained from resources, which we pass to be able to scale the bitmap accordingly. </para>        
				/// </summary>
				/// <java-name>
				/// decodeResourceStream
				/// </java-name>
				[Dot42.DexImport("decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lan" +
    "droid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/B" +
    "itmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResourceStream(global::Android.Content.Res.Resources res, global::Android.Util.TypedValue value, global::Java.IO.InputStream @is, global::Android.Graphics.Rect pad, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Synonym for opening the given resource and calling decodeResourceStream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded, or, if opts is non-null, if opts requested only the size be returned (in opts.outWidth and opts.outHeight) </para>
				/// </returns>
				/// <java-name>
				/// decodeResource
				/// </java-name>
				[Dot42.DexImport("decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroi" +
    "d/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResource(global::Android.Content.Res.Resources res, int id, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Synonym for decodeResource(Resources, int, android.graphics.BitmapFactory.Options) will null Options.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image could not be decode. </para>
				/// </returns>
				/// <java-name>
				/// decodeResource
				/// </java-name>
				[Dot42.DexImport("decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeResource(global::Android.Content.Res.Resources res, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an immutable bitmap from the specified byte array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded, or, if opts is non-null, if opts requested only the size be returned (in opts.outWidth and opts.outHeight) </para>
				/// </returns>
				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(sbyte[] data, int offset, int length, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an immutable bitmap from the specified byte array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded, or, if opts is non-null, if opts requested only the size be returned (in opts.outWidth and opts.outHeight) </para>
				/// </returns>
				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(byte[] data, int offset, int length, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an immutable bitmap from the specified byte array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image could not be decode. </para>
				/// </returns>
				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(sbyte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an immutable bitmap from the specified byte array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image could not be decode. </para>
				/// </returns>
				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Bitmap;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.Bitmap DecodeByteArray(byte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an input stream into a bitmap. If the input stream is null, or cannot be used to decode a bitmap, the function returns null. The stream's position will be where ever it was after the encoded data was read.</para> <para></para> <para>Prior to android.os.Build.VERSION_CODES#KITKAT, if is.markSupported() returns true,  <code>is.mark(1024)</code> would be called. As of android.os.Build.VERSION_CODES#KITKAT, this is no longer the case.</para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded, or, if opts is non-null, if opts requested only the size be returned (in opts.outWidth and opts.outHeight)</para>
				/// </returns>
				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Opti" +
    "ons;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeStream(global::Java.IO.InputStream @is, global::Android.Graphics.Rect outPadding, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode an input stream into a bitmap. If the input stream is null, or cannot be used to decode a bitmap, the function returns null. The stream's position will be where ever it was after the encoded data was read.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded. </para>
				/// </returns>
				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeStream(global::Java.IO.InputStream @is) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode a bitmap from the file descriptor. If the bitmap cannot be decoded return null. The position within the descriptor will not be changed when this returns, so the descriptor can be used again as-is.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded bitmap, or null </para>
				/// </returns>
				/// <java-name>
				/// decodeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$O" +
    "ptions;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFileDescriptor(global::Java.IO.FileDescriptor fd, global::Android.Graphics.Rect outPadding, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Decode a bitmap from the file descriptor. If the bitmap cannot be decoded return null. The position within the descriptor will not be changed when this returns, so the descriptor can be used again as is.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded bitmap, or null </para>
				/// </returns>
				/// <java-name>
				/// decodeFileDescriptor
				/// </java-name>
				[Dot42.DexImport("decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap DecodeFileDescriptor(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
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
						/// <summary>
						///  <para>If set, decode methods that take the Options object will attempt to reuse this bitmap when loading content. If the decode operation cannot use this bitmap, the decode method will return  <code>null</code> and will throw an IllegalArgumentException. The current implementation necessitates that the reused bitmap be mutable, and the resulting reused bitmap will continue to remain mutable even when decoding a resource which would normally result in an immutable bitmap.</para> <para>You should still always use the returned Bitmap of the decode method and not assume that reusing the bitmap worked, due to the constraints outlined above and failure situations that can occur. Checking whether the return value matches the value of the inBitmap set in the Options structure will indicate if the bitmap was reused, but in all cases you should use the Bitmap returned by the decoding function to ensure that you are using the bitmap that was used as the decode destination.</para> <para> <h3>Usage with BitmapFactory</h3></para> <para>As of android.os.Build.VERSION_CODES#KITKAT, any mutable bitmap can be reused by BitmapFactory to decode any other bitmaps as long as the resulting byte count of the decoded bitmap is less than or equal to the allocated byte count of the reused bitmap. This can be because the intrinsic size is smaller, or its size post scaling (for density / sample size) is smaller.</para> <para>Prior to android.os.Build.VERSION_CODES#KITKAT additional constraints apply: The image being decoded (whether as a resource or as a stream) must be in jpeg or png format. Only equal sized bitmaps are supported, with inSampleSize set to 1. Additionally, the configuration of the reused bitmap will override the setting of inPreferredConfig, if set.</para> <para> <h3>Usage with BitmapRegionDecoder</h3></para> <para>BitmapRegionDecoder will draw its requested content into the Bitmap provided, clipping if the output content size (post scaling) is larger than the provided Bitmap. The provided Bitmap's width, height, and Bitmap.Config will not be changed.</para> <para>BitmapRegionDecoder support for inBitmap was introduced in android.os.Build.VERSION_CODES#JELLY_BEAN. All formats supported by BitmapRegionDecoder support Bitmap reuse via inBitmap.</para> <para> <para>Bitmap::reconfigure(int,int, android.graphics.Bitmap.Config) </para></para>        
						/// </summary>
						/// <java-name>
						/// inBitmap
						/// </java-name>
						[Dot42.DexImport("inBitmap", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap InBitmap;
						/// <summary>
						///  <para>If set, decode methods will always return a mutable Bitmap instead of an immutable one. This can be used for instance to programmatically apply effects to a Bitmap loaded through BitmapFactory. </para>        
						/// </summary>
						/// <java-name>
						/// inMutable
						/// </java-name>
						[Dot42.DexImport("inMutable", "Z", AccessFlags = 1)]
						public bool InMutable;
						/// <summary>
						///  <para>If set to true, the decoder will return null (no bitmap), but the out... fields will still be set, allowing the caller to query the bitmap without having to allocate the memory for its pixels. </para>        
						/// </summary>
						/// <java-name>
						/// inJustDecodeBounds
						/// </java-name>
						[Dot42.DexImport("inJustDecodeBounds", "Z", AccessFlags = 1)]
						public bool InJustDecodeBounds;
						/// <summary>
						///  <para>If set to a value &gt; 1, requests the decoder to subsample the original image, returning a smaller image to save memory. The sample size is the number of pixels in either dimension that correspond to a single pixel in the decoded bitmap. For example, inSampleSize == 4 returns an image that is 1/4 the width/height of the original, and 1/16 the number of pixels. Any value &lt;= 1 is treated the same as 1. Note: the decoder uses a final value based on powers of 2, any other value will be rounded down to the nearest power of 2. </para>        
						/// </summary>
						/// <java-name>
						/// inSampleSize
						/// </java-name>
						[Dot42.DexImport("inSampleSize", "I", AccessFlags = 1)]
						public int InSampleSize;
						/// <summary>
						///  <para>If this is non-null, the decoder will try to decode into this internal configuration. If it is null, or the request cannot be met, the decoder will try to pick the best matching config based on the system's screen depth, and characteristics of the original image such as if it has per-pixel alpha (requiring a config that also does).</para> <para>Image are loaded with the Bitmap.Config#ARGB_8888 config by default. </para>        
						/// </summary>
						/// <java-name>
						/// inPreferredConfig
						/// </java-name>
						[Dot42.DexImport("inPreferredConfig", "Landroid/graphics/Bitmap$Config;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap.Config InPreferredConfig;
						/// <summary>
						///  <para>If dither is true, the decoder will attempt to dither the decoded image. </para>        
						/// </summary>
						/// <java-name>
						/// inDither
						/// </java-name>
						[Dot42.DexImport("inDither", "Z", AccessFlags = 1)]
						public bool InDither;
						/// <summary>
						///  <para>The pixel density to use for the bitmap. This will always result in the returned bitmap having a density set for it (see Bitmap.setDensity(int)). In addition, if inScaled is set (which it is by default} and this density does not match inTargetDensity, then the bitmap will be scaled to the target density before being returned.</para> <para>If this is 0, BitmapFactory#decodeResource(Resources, int), BitmapFactory#decodeResource(Resources, int, android.graphics.BitmapFactory.Options), and BitmapFactory#decodeResourceStream will fill in the density associated with the resource. The other functions will leave it as-is and no density will be applied.</para> <para> <para>inTargetDensity </para> <para>inScreenDensity </para> <para>inScaled </para> <para>Bitmap::setDensity(int) </para> <para>android.util.DisplayMetrics::densityDpi </para></para>        
						/// </summary>
						/// <java-name>
						/// inDensity
						/// </java-name>
						[Dot42.DexImport("inDensity", "I", AccessFlags = 1)]
						public int InDensity;
						/// <summary>
						///  <para>The pixel density of the destination this bitmap will be drawn to. This is used in conjunction with inDensity and inScaled to determine if and how to scale the bitmap before returning it.</para> <para>If this is 0, BitmapFactory#decodeResource(Resources, int), BitmapFactory#decodeResource(Resources, int, android.graphics.BitmapFactory.Options), and BitmapFactory#decodeResourceStream will fill in the density associated the Resources object's DisplayMetrics. The other functions will leave it as-is and no scaling for density will be performed.</para> <para> <para>inDensity </para> <para>inScreenDensity </para> <para>inScaled </para> <para>android.util.DisplayMetrics::densityDpi </para></para>        
						/// </summary>
						/// <java-name>
						/// inTargetDensity
						/// </java-name>
						[Dot42.DexImport("inTargetDensity", "I", AccessFlags = 1)]
						public int InTargetDensity;
						/// <summary>
						///  <para>The pixel density of the actual screen that is being used. This is purely for applications running in density compatibility code, where inTargetDensity is actually the density the application sees rather than the real screen density.</para> <para>By setting this, you allow the loading code to avoid scaling a bitmap that is currently in the screen density up/down to the compatibility density. Instead, if inDensity is the same as inScreenDensity, the bitmap will be left as-is. Anything using the resulting bitmap must also used Bitmap.getScaledWidth and Bitmap.getScaledHeight to account for any different between the bitmap's density and the target's density.</para> <para>This is never set automatically for the caller by BitmapFactory itself. It must be explicitly set, since the caller must deal with the resulting bitmap in a density-aware way.</para> <para> <para>inDensity </para> <para>inTargetDensity </para> <para>inScaled </para> <para>android.util.DisplayMetrics::densityDpi </para></para>        
						/// </summary>
						/// <java-name>
						/// inScreenDensity
						/// </java-name>
						[Dot42.DexImport("inScreenDensity", "I", AccessFlags = 1)]
						public int InScreenDensity;
						/// <summary>
						///  <para>When this flag is set, if inDensity and inTargetDensity are not 0, the bitmap will be scaled to match inTargetDensity when loaded, rather than relying on the graphics system scaling it each time it is drawn to a Canvas.</para> <para>BitmapRegionDecoder ignores this flag, and will not scale output based on density. (though inSampleSize is supported)</para> <para>This flag is turned on by default and should be turned off if you need a non-scaled version of the bitmap. Nine-patch bitmaps ignore this flag and are always scaled. </para>        
						/// </summary>
						/// <java-name>
						/// inScaled
						/// </java-name>
						[Dot42.DexImport("inScaled", "Z", AccessFlags = 1)]
						public bool InScaled;
						/// <summary>
						///  <para>If this is set to true, then the resulting bitmap will allocate its pixels such that they can be purged if the system needs to reclaim memory. In that instance, when the pixels need to be accessed again (e.g. the bitmap is drawn, getPixels() is called), they will be automatically re-decoded.</para> <para>For the re-decode to happen, the bitmap must have access to the encoded data, either by sharing a reference to the input or by making a copy of it. This distinction is controlled by inInputShareable. If this is true, then the bitmap may keep a shallow reference to the input. If this is false, then the bitmap will explicitly make a copy of the input data, and keep that. Even if sharing is allowed, the implementation may still decide to make a deep copy of the input data.</para> <para>While inPurgeable can help avoid big Dalvik heap allocations (from API level 11 onward), it sacrifices performance predictability since any image that the view system tries to draw may incur a decode delay which can lead to dropped frames. Therefore, most apps should avoid using inPurgeable to allow for a fast and fluid UI. To minimize Dalvik heap allocations use the inBitmap flag instead.</para> <para> <b>Note:</b> This flag is ignored when used with int, android.graphics.BitmapFactory.Options) or android.graphics.BitmapFactory.Options).</para>        
						/// </summary>
						/// <java-name>
						/// inPurgeable
						/// </java-name>
						[Dot42.DexImport("inPurgeable", "Z", AccessFlags = 1)]
						public bool InPurgeable;
						/// <summary>
						///  <para>This field works in conjuction with inPurgeable. If inPurgeable is false, then this field is ignored. If inPurgeable is true, then this field determines whether the bitmap can share a reference to the input data (inputstream, array, etc.) or if it must make a deep copy. </para>        
						/// </summary>
						/// <java-name>
						/// inInputShareable
						/// </java-name>
						[Dot42.DexImport("inInputShareable", "Z", AccessFlags = 1)]
						public bool InInputShareable;
						/// <summary>
						///  <para>If inPreferQualityOverSpeed is set to true, the decoder will try to decode the reconstructed image to a higher quality even at the expense of the decoding speed. Currently the field only affects JPEG decode, in the case of which a more accurate, but slightly slower, IDCT method will be used instead. </para>        
						/// </summary>
						/// <java-name>
						/// inPreferQualityOverSpeed
						/// </java-name>
						[Dot42.DexImport("inPreferQualityOverSpeed", "Z", AccessFlags = 1)]
						public bool InPreferQualityOverSpeed;
						/// <summary>
						///  <para>The resulting width of the bitmap, set independent of the state of inJustDecodeBounds. However, if there is an error trying to decode, outWidth will be set to -1. </para>        
						/// </summary>
						/// <java-name>
						/// outWidth
						/// </java-name>
						[Dot42.DexImport("outWidth", "I", AccessFlags = 1)]
						public int OutWidth;
						/// <summary>
						///  <para>The resulting height of the bitmap, set independent of the state of inJustDecodeBounds. However, if there is an error trying to decode, outHeight will be set to -1. </para>        
						/// </summary>
						/// <java-name>
						/// outHeight
						/// </java-name>
						[Dot42.DexImport("outHeight", "I", AccessFlags = 1)]
						public int OutHeight;
						/// <summary>
						///  <para>If known, this string is set to the mimetype of the decoded image. If not know, or there is an error, it is set to null. </para>        
						/// </summary>
						/// <java-name>
						/// outMimeType
						/// </java-name>
						[Dot42.DexImport("outMimeType", "Ljava/lang/String;", AccessFlags = 1)]
						public string OutMimeType;
						/// <summary>
						///  <para>Temp storage to use for decoding. Suggest 16K or so. </para>        
						/// </summary>
						/// <java-name>
						/// inTempStorage
						/// </java-name>
						[Dot42.DexImport("inTempStorage", "[B", AccessFlags = 1)]
						public sbyte[] InTempStorage;
						/// <summary>
						///  <para>Flag to indicate that cancel has been called on this object. This is useful if there's an intermediary that wants to first decode the bounds and then decode the image. In that case the intermediary can check, inbetween the bounds decode and the image decode, to see if the operation is canceled. </para>        
						/// </summary>
						/// <java-name>
						/// mCancel
						/// </java-name>
						[Dot42.DexImport("mCancel", "Z", AccessFlags = 1)]
						public bool MCancel;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Options() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>This can be called from another thread while this options object is inside a decode... call. Calling this will notify the decoder that it should cancel its operation. This is not guaranteed to cancel the decode, but if it does, the decoder... operation will return null, or if inJustDecodeBounds is true, will set outWidth/outHeight to -1 </para>        
						/// </summary>
						/// <java-name>
						/// requestCancelDecode
						/// </java-name>
						[Dot42.DexImport("requestCancelDecode", "()V", AccessFlags = 1)]
						public virtual void RequestCancelDecode() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>BitmapRegionDecoder can be used to decode a rectangle region from an image. BitmapRegionDecoder is particularly useful when an original image is large and you only need parts of the image.</para> <para>To create a BitmapRegionDecoder, call newInstance(...). Given a BitmapRegionDecoder, users can call decodeRegion() repeatedly to get a decoded Bitmap of the specified region. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Create a BitmapRegionDecoder from the specified byte array. Currently only the JPEG and PNG formats are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>BitmapRegionDecoder, or null if the image data could not be decoded. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([BIIZ)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(sbyte[] data, int offset, int length, bool isShareable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <summary>
				///  <para>Create a BitmapRegionDecoder from the specified byte array. Currently only the JPEG and PNG formats are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>BitmapRegionDecoder, or null if the image data could not be decoded. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "([BIIZ)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(byte[] data, int offset, int length, bool isShareable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/io/FileDescriptor;Z)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(global::Java.IO.FileDescriptor fileDescriptor, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.BitmapRegionDecoder);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/io/InputStream;Z)Landroid/graphics/BitmapRegionDecoder;", AccessFlags = 9)]
				public static global::Android.Graphics.BitmapRegionDecoder NewInstance(global::Java.IO.InputStream inputStream, bool boolean) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Decodes a rectangle region in the image specified by rect.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The decoded bitmap, or null if the image data could not be decoded. </para>
				/// </returns>
				/// <java-name>
				/// decodeRegion
				/// </java-name>
				[Dot42.DexImport("decodeRegion", "(Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphic" +
    "s/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap DecodeRegion(global::Android.Graphics.Rect rect, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Frees up the memory associated with this region decoder, and mark the region decoder as "dead", meaning it will throw an exception if decodeRegion(), getWidth() or getHeight() is called.</para> <para>This operation cannot be reversed, so it should only be called if you are sure there are no further uses for the region decoder. This is an advanced call, and normally need not be called, since the normal GC process will free up this memory when there are no more references to this region decoder. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~BitmapRegionDecoder() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the original image's width </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the original image's height </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns true if this region decoder has been recycled. If so, then it is an error to try use its method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the region decoder has been recycled </para>
				/// </returns>
				/// <java-name>
				/// isRecycled
				/// </java-name>
				public bool IsRecycled
				{
						[Dot42.DexImport("isRecycled", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Shader used to draw a bitmap as a texture. The bitmap can be repeated or mirrored by setting the tiling mode. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/BitmapShader
		/// </java-name>
		[Dot42.DexImport("android/graphics/BitmapShader", AccessFlags = 33)]
		public partial class BitmapShader : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Call this to create a new shader that will draw with a bitmap.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Sha" +
    "der$TileMode;)V", AccessFlags = 1)]
				public BitmapShader(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Shader.TileMode tileX, global::Android.Graphics.Shader.TileMode tileY) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BitmapShader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This takes a mask, and blurs its edge by the specified radius. Whether or or not to include the original mask, and whether the blur goes outside, inside, or straddles, the original mask's border, is controlled by the Blur enum. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/BlurMaskFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/BlurMaskFilter", AccessFlags = 33)]
		public partial class BlurMaskFilter : global::Android.Graphics.MaskFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a blur maskfilter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new blur maskfilter </para>
				/// </returns>
				[Dot42.DexImport("<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V", AccessFlags = 1)]
				public BlurMaskFilter(float radius, global::Android.Graphics.BlurMaskFilter.Blur style) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>A camera instance can be used to compute 3D transformations and generate a matrix that can be applied, for instance, on a Canvas. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Camera
		/// </java-name>
		[Dot42.DexImport("android/graphics/Camera", AccessFlags = 33)]
		public partial class Camera
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new camera, with empty transformations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Camera() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Saves the camera state. Each save should be balanced with a call to restore().</para> <para> <para>save() </para></para>        
				/// </summary>
				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "()V", AccessFlags = 257)]
				public virtual void Save() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Restores the saved state, if any.</para> <para> <para>restore() </para></para>        
				/// </summary>
				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "()V", AccessFlags = 257)]
				public virtual void Restore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies a translation transform on all three axis.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FFF)V", AccessFlags = 257)]
				public virtual void Translate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies a rotation transform around the X axis.</para> <para> <para>rotateY(float) </para> <para>rotateZ(float) </para> <para>rotate(float, float, float) </para></para>        
				/// </summary>
				/// <java-name>
				/// rotateX
				/// </java-name>
				[Dot42.DexImport("rotateX", "(F)V", AccessFlags = 257)]
				public virtual void RotateX(float deg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies a rotation transform around the Y axis.</para> <para> <para>rotateX(float) </para> <para>rotateZ(float) </para> <para>rotate(float, float, float) </para></para>        
				/// </summary>
				/// <java-name>
				/// rotateY
				/// </java-name>
				[Dot42.DexImport("rotateY", "(F)V", AccessFlags = 257)]
				public virtual void RotateY(float deg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies a rotation transform around the Z axis.</para> <para> <para>rotateX(float) </para> <para>rotateY(float) </para> <para>rotate(float, float, float) </para></para>        
				/// </summary>
				/// <java-name>
				/// rotateZ
				/// </java-name>
				[Dot42.DexImport("rotateZ", "(F)V", AccessFlags = 257)]
				public virtual void RotateZ(float deg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies a rotation transform around all three axis.</para> <para> <para>rotateX(float) </para> <para>rotateY(float) </para> <para>rotateZ(float) </para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFF)V", AccessFlags = 257)]
				public virtual void Rotate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the location of the camera. The default location is set at 0, 0, -8.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLocation
				/// </java-name>
				[Dot42.DexImport("setLocation", "(FFF)V", AccessFlags = 257)]
				public virtual void SetLocation(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes the matrix corresponding to the current transformation and copies it to the supplied matrix object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void GetMatrix(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes the matrix corresponding to the current transformation and applies it to the specified Canvas.</para> <para></para>        
				/// </summary>
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
				public virtual float DotWithNormal(float dx, float dy, float dz) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Camera() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The Canvas class holds the "draw" calls. To draw something, you need 4 basic components: A Bitmap to hold the pixels, a Canvas to host the draw calls (writing into the bitmap), a drawing primitive (e.g. Rect, Path, text, Bitmap), and a paint (to describe the colors and styles for the drawing).</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about how to use Canvas, read the  developer guide.</para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Canvas
		/// </java-name>
		[Dot42.DexImport("android/graphics/Canvas", AccessFlags = 33)]
		public partial class Canvas
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>restore the current matrix when restore() is called </para>        
				/// </summary>
				/// <java-name>
				/// MATRIX_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("MATRIX_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int MATRIX_SAVE_FLAG = 1;
				/// <summary>
				///  <para>restore the current clip when restore() is called </para>        
				/// </summary>
				/// <java-name>
				/// CLIP_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("CLIP_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int CLIP_SAVE_FLAG = 2;
				/// <summary>
				///  <para>the layer needs to per-pixel alpha </para>        
				/// </summary>
				/// <java-name>
				/// HAS_ALPHA_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("HAS_ALPHA_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int HAS_ALPHA_LAYER_SAVE_FLAG = 4;
				/// <summary>
				///  <para>the layer needs to 8-bits per color component </para>        
				/// </summary>
				/// <java-name>
				/// FULL_COLOR_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("FULL_COLOR_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int FULL_COLOR_LAYER_SAVE_FLAG = 8;
				/// <summary>
				///  <para>clip against the layer's bounds </para>        
				/// </summary>
				/// <java-name>
				/// CLIP_TO_LAYER_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("CLIP_TO_LAYER_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int CLIP_TO_LAYER_SAVE_FLAG = 16;
				/// <summary>
				///  <para>restore everything when restore() is called </para>        
				/// </summary>
				/// <java-name>
				/// ALL_SAVE_FLAG
				/// </java-name>
				[Dot42.DexImport("ALL_SAVE_FLAG", "I", AccessFlags = 25)]
				public const int ALL_SAVE_FLAG = 31;
				/// <summary>
				///  <para>Construct an empty raster canvas. Use setBitmap() to specify a bitmap to draw into. The initial target density is Bitmap#DENSITY_NONE; this will typically be replaced when a target bitmap is set for the canvas. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Canvas() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a canvas with the specified bitmap to draw into. The bitmap must be mutable.</para> <para>The initial target density of the canvas is the same as the given bitmap's density.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public Canvas(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specify a bitmap for the canvas to draw into. All canvas state such as layers, filters, and the save/restore stack are reset with the exception of the current matrix and clip stack. Additionally, as a side-effect the canvas' target density is updated to match that of the bitmap.</para> <para> <para>setDensity(int) </para> <para>getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Saves the current matrix and clip onto a private stack. Subsequent calls to translate,scale,rotate,skew,concat or clipRect,clipPath will all operate as usual, but when the balancing call to restore() is made, those calls will be forgotten, and the settings that existed before the save() will be reinstated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value to pass to restoreToCount() to balance this save() </para>
				/// </returns>
				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "()I", AccessFlags = 257)]
				public virtual int Save() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Based on saveFlags, can save the current matrix and clip onto a private stack. Subsequent calls to translate,scale,rotate,skew,concat or clipRect,clipPath will all operate as usual, but when the balancing call to restore() is made, those calls will be forgotten, and the settings that existed before the save() will be reinstated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value to pass to restoreToCount() to balance this save() </para>
				/// </returns>
				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(I)I", AccessFlags = 257)]
				public virtual int Save(int saveFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>This behaves the same as save(), but in addition it allocates an offscreen bitmap. All drawing calls are directed there, and only when the balancing call to restore() is made is that offscreen transfered to the canvas (or the previous layer). Subsequent calls to translate, scale, rotate, skew, concat or clipRect, clipPath all operate on this copy. When the balancing call to restore() is made, this copy is deleted and the previous matrix/clip state is restored.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value to pass to restoreToCount() to balance this save() </para>
				/// </returns>
				/// <java-name>
				/// saveLayer
				/// </java-name>
				[Dot42.DexImport("saveLayer", "(Landroid/graphics/RectF;Landroid/graphics/Paint;I)I", AccessFlags = 1)]
				public virtual int SaveLayer(global::Android.Graphics.RectF bounds, global::Android.Graphics.Paint paint, int saveFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Helper version of saveLayer() that takes 4 values rather than a RectF. </para>        
				/// </summary>
				/// <java-name>
				/// saveLayer
				/// </java-name>
				[Dot42.DexImport("saveLayer", "(FFFFLandroid/graphics/Paint;I)I", AccessFlags = 1)]
				public virtual int SaveLayer(float left, float top, float right, float bottom, global::Android.Graphics.Paint paint, int saveFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>This behaves the same as save(), but in addition it allocates an offscreen bitmap. All drawing calls are directed there, and only when the balancing call to restore() is made is that offscreen transfered to the canvas (or the previous layer). Subsequent calls to translate, scale, rotate, skew, concat or clipRect, clipPath all operate on this copy. When the balancing call to restore() is made, this copy is deleted and the previous matrix/clip state is restored.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value to pass to restoreToCount() to balance this call </para>
				/// </returns>
				/// <java-name>
				/// saveLayerAlpha
				/// </java-name>
				[Dot42.DexImport("saveLayerAlpha", "(Landroid/graphics/RectF;II)I", AccessFlags = 1)]
				public virtual int SaveLayerAlpha(global::Android.Graphics.RectF bounds, int alpha, int saveFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Helper for saveLayerAlpha() that takes 4 values instead of a RectF. </para>        
				/// </summary>
				/// <java-name>
				/// saveLayerAlpha
				/// </java-name>
				[Dot42.DexImport("saveLayerAlpha", "(FFFFII)I", AccessFlags = 1)]
				public virtual int SaveLayerAlpha(float left, float top, float right, float bottom, int alpha, int saveFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>This call balances a previous call to save(), and is used to remove all modifications to the matrix/clip state since the last save call. It is an error to call restore() more times than save() was called. </para>        
				/// </summary>
				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "()V", AccessFlags = 257)]
				public virtual void Restore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Efficient way to pop any calls to save() that happened after the save count reached saveCount. It is an error for saveCount to be less than 1.</para> <para>Example: int count = canvas.save(); ... // more calls potentially to save() canvas.restoreToCount(count); // now the canvas is back in the same state it was before the initial // call to save().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// restoreToCount
				/// </java-name>
				[Dot42.DexImport("restoreToCount", "(I)V", AccessFlags = 257)]
				public virtual void RestoreToCount(int saveCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified translation</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FF)V", AccessFlags = 257)]
				public virtual void Translate(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified scale.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 257)]
				public virtual void Scale(float sx, float sy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified scale.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFFF)V", AccessFlags = 17)]
				public void Scale(float sx, float sy, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified rotation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 257)]
				public virtual void Rotate(float degrees) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified rotation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFF)V", AccessFlags = 17)]
				public void Rotate(float degrees, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified skew.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// skew
				/// </java-name>
				[Dot42.DexImport("skew", "(FF)V", AccessFlags = 257)]
				public virtual void Skew(float sx, float sy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Preconcat the current matrix with the specified matrix. If the specified matrix is null, this method does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void Concat(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return, in ctm, the current transformation matrix. This does not alter the matrix in the canvas, but just returns a copy of it. </para>        
				/// </summary>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void GetMatrix(global::Android.Graphics.Matrix ctm) /* MethodBuilder.Create */ 
				{
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

				/// <summary>
				///  <para>Intersect the current clip with the specified rectangle, which is expressed in local coordinates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting clip is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 257)]
				public virtual bool ClipRect(global::Android.Graphics.RectF rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Intersect the current clip with the specified rectangle, which is expressed in local coordinates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting clip is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 257)]
				public virtual bool ClipRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Modify the current clip with the specified rectangle, which is expressed in local coordinates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting clip is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(FFFFLandroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRect(float left, float top, float right, float bottom, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Intersect the current clip with the specified rectangle, which is expressed in local coordinates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting clip is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(FFFF)Z", AccessFlags = 257)]
				public virtual bool ClipRect(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Intersect the current clip with the specified rectangle, which is expressed in local coordinates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting clip is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRect
				/// </java-name>
				[Dot42.DexImport("clipRect", "(IIII)Z", AccessFlags = 257)]
				public virtual bool ClipRect(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Modify the current clip with the specified path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipPath
				/// </java-name>
				[Dot42.DexImport("clipPath", "(Landroid/graphics/Path;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipPath(global::Android.Graphics.Path path, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Intersect the current clip with the specified path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipPath
				/// </java-name>
				[Dot42.DexImport("clipPath", "(Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool ClipPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Modify the current clip with the specified region. Note that unlike clipRect() and clipPath() which transform their arguments by the current matrix, clipRegion() assumes its argument is already in the coordinate system of the current layer's bitmap, and so not transformation is performed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRegion
				/// </java-name>
				[Dot42.DexImport("clipRegion", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool ClipRegion(global::Android.Graphics.Region region, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Intersect the current clip with the specified region. Note that unlike clipRect() and clipPath() which transform their arguments by the current matrix, clipRegion() assumes its argument is already in the coordinate system of the current layer's bitmap, and so not transformation is performed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting is non-empty </para>
				/// </returns>
				/// <java-name>
				/// clipRegion
				/// </java-name>
				[Dot42.DexImport("clipRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool ClipRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
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

				/// <summary>
				///  <para>Return true if the specified rectangle, after being transformed by the current matrix, would lie completely outside of the current clip. Call this to check if an area you intend to draw into is clipped out (and therefore you can skip making the draw calls).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the rect (transformed by the canvas' matrix) does not intersect with the canvas' clip </para>
				/// </returns>
				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(FFFFLandroid/graphics/Canvas$EdgeType;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(float left, float top, float right, float bottom, global::Android.Graphics.Canvas.EdgeType type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the bounds of the current clip (in local coordinates) in the bounds parameter, and return true if it is non-empty. This can be useful in a way similar to quickReject, in that it tells you that drawing outside of these bounds will be clipped out.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the current clip is non-empty. </para>
				/// </returns>
				/// <java-name>
				/// getClipBounds
				/// </java-name>
				[Dot42.DexImport("getClipBounds", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetClipBounds(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Fill the entire canvas' bitmap (restricted to the current clip) with the specified RGB color, using srcover porterduff mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawRGB
				/// </java-name>
				[Dot42.DexImport("drawRGB", "(III)V", AccessFlags = 1)]
				public virtual void DrawRGB(int r, int g, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill the entire canvas' bitmap (restricted to the current clip) with the specified ARGB color, using srcover porterduff mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawARGB
				/// </java-name>
				[Dot42.DexImport("drawARGB", "(IIII)V", AccessFlags = 1)]
				public virtual void DrawARGB(int a, int r, int g, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill the entire canvas' bitmap (restricted to the current clip) with the specified color, using srcover porterduff mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawColor
				/// </java-name>
				[Dot42.DexImport("drawColor", "(I)V", AccessFlags = 1)]
				public virtual void DrawColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill the entire canvas' bitmap (restricted to the current clip) with the specified color and porter-duff xfermode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawColor
				/// </java-name>
				[Dot42.DexImport("drawColor", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public virtual void DrawColor(int color, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill the entire canvas' bitmap (restricted to the current clip) with the specified paint. This is equivalent (but faster) to drawing an infinitely large rectangle with the specified paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPaint
				/// </java-name>
				[Dot42.DexImport("drawPaint", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPaint(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw a series of points. Each point is centered at the coordinate specified by pts[], and its diameter is specified by the paint's stroke width (as transformed by the canvas' CTM), with special treatment for a stroke width of 0, which always draws exactly 1 pixel (or at most 4 if antialiasing is enabled). The shape of the point is controlled by the paint's Cap type. The shape is a square, unless the cap type is Round, in which case the shape is a circle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPoints
				/// </java-name>
				[Dot42.DexImport("drawPoints", "([FIILandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawPoints(float[] pts, int offset, int count, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper for drawPoints() that assumes you want to draw the entire array </para>        
				/// </summary>
				/// <java-name>
				/// drawPoints
				/// </java-name>
				[Dot42.DexImport("drawPoints", "([FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPoints(float[] pts, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper for drawPoints() for drawing a single point. </para>        
				/// </summary>
				/// <java-name>
				/// drawPoint
				/// </java-name>
				[Dot42.DexImport("drawPoint", "(FFLandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawPoint(float x, float y, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw a line segment with the specified start and stop x,y coordinates, using the specified paint.</para> <para>Note that since a line is always "framed", the Style is ignored in the paint.</para> <para>Degenerate lines (length is 0) will not be drawn.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLine
				/// </java-name>
				[Dot42.DexImport("drawLine", "(FFFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawLine(float startX, float startY, float stopX, float stopY, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw a series of lines. Each line is taken from 4 consecutive values in the pts array. Thus to draw 1 line, the array must contain at least 4 values. This is logically the same as drawing the array as follows: drawLine(pts[0], pts[1], pts[2], pts[3]) followed by drawLine(pts[4], pts[5], pts[6], pts[7]) and so on.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLines
				/// </java-name>
				[Dot42.DexImport("drawLines", "([FIILandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void DrawLines(float[] pts, int offset, int count, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawLines
				/// </java-name>
				[Dot42.DexImport("drawLines", "([FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawLines(float[] pts, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified Rect using the specified paint. The rectangle will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(global::Android.Graphics.RectF rect, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified Rect using the specified paint. The rectangle will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(Landroid/graphics/Rect;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(global::Android.Graphics.Rect rect, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified Rect using the specified paint. The rectangle will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawRect
				/// </java-name>
				[Dot42.DexImport("drawRect", "(FFFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRect(float left, float top, float right, float bottom, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified oval using the specified paint. The oval will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawOval
				/// </java-name>
				[Dot42.DexImport("drawOval", "(Landroid/graphics/RectF;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawOval(global::Android.Graphics.RectF oval, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified circle using the specified paint. If radius is &lt;= 0, then nothing will be drawn. The circle will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawCircle
				/// </java-name>
				[Dot42.DexImport("drawCircle", "(FFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawCircle(float cx, float cy, float radius, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified arc, which will be scaled to fit inside the specified oval.</para> <para>If the start angle is negative or &gt;= 360, the start angle is treated as start angle modulo 360.</para> <para>If the sweep angle is &gt;= 360, then the oval is drawn completely. Note that this differs slightly from SkPath::arcTo, which treats the sweep angle modulo 360. If the sweep angle is negative, the sweep angle is treated as sweep angle modulo 360</para> <para>The arc is drawn clockwise. An angle of 0 degrees correspond to the geometric angle of 0 degrees (3 o'clock on a watch.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawArc
				/// </java-name>
				[Dot42.DexImport("drawArc", "(Landroid/graphics/RectF;FFZLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawArc(global::Android.Graphics.RectF oval, float startAngle, float sweepAngle, bool useCenter, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified round-rect using the specified paint. The roundrect will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawRoundRect
				/// </java-name>
				[Dot42.DexImport("drawRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawRoundRect(global::Android.Graphics.RectF rect, float rx, float ry, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified path using the specified paint. The path will be filled or framed based on the Style in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPath
				/// </java-name>
				[Dot42.DexImport("drawPath", "(Landroid/graphics/Path;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPath(global::Android.Graphics.Path path, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified bitmap, scaling/translating automatically to fill the destination rectangle. If the source rectangle is not null, it specifies the subset of the bitmap to draw.</para> <para>Note: if the paint contains a maskfilter that generates a mask which extends beyond the bitmap's original width/height (e.g. BlurMaskFilter), then the bitmap will be drawn as if it were in a Shader with CLAMP mode. Thus the color outside of the original width/height will be the edge color replicated.</para> <para>This function  <b>ignores the density associated with the bitmap</b>. This is because the source and destination rectangle coordinate spaces are in their respective densities, so must already have the appropriate scaling factor applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, float src, float dst, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified bitmap, scaling/translating automatically to fill the destination rectangle. If the source rectangle is not null, it specifies the subset of the bitmap to draw.</para> <para>Note: if the paint contains a maskfilter that generates a mask which extends beyond the bitmap's original width/height (e.g. BlurMaskFilter), then the bitmap will be drawn as if it were in a Shader with CLAMP mode. Thus the color outside of the original width/height will be the edge color replicated.</para> <para>This function  <b>ignores the density associated with the bitmap</b>. This is because the source and destination rectangle coordinate spaces are in their respective densities, so must already have the appropriate scaling factor applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/RectF;Landroid" +
    "/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Rect src, global::Android.Graphics.RectF dst, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the specified bitmap, scaling/translating automatically to fill the destination rectangle. If the source rectangle is not null, it specifies the subset of the bitmap to draw.</para> <para>Note: if the paint contains a maskfilter that generates a mask which extends beyond the bitmap's original width/height (e.g. BlurMaskFilter), then the bitmap will be drawn as if it were in a Shader with CLAMP mode. Thus the color outside of the original width/height will be the edge color replicated.</para> <para>This function  <b>ignores the density associated with the bitmap</b>. This is because the source and destination rectangle coordinate spaces are in their respective densities, so must already have the appropriate scaling factor applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/" +
    "graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Rect src, global::Android.Graphics.Rect dst, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Draw the bitmap using the specified matrix.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawBitmap
				/// </java-name>
				[Dot42.DexImport("drawBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmap(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Matrix matrix, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the bitmap through the mesh, where mesh vertices are evenly distributed across the bitmap. There are meshWidth+1 vertices across, and meshHeight+1 vertices down. The verts array is accessed in row-major order, so that the first meshWidth+1 vertices are distributed across the top of the bitmap from left to right. A more general version of this method is drawVertices().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawBitmapMesh
				/// </java-name>
				[Dot42.DexImport("drawBitmapMesh", "(Landroid/graphics/Bitmap;II[FI[IILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawBitmapMesh(global::Android.Graphics.Bitmap bitmap, int meshWidth, int meshHeight, float[] verts, int vertOffset, int[] colors, int colorOffset, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the array of vertices, interpreted as triangles (based on mode). The verts array is required, and specifies the x,y pairs for each vertex. If texs is non-null, then it is used to specify the coordinate in shader coordinates to use at each vertex (the paint must have a shader in this case). If there is no texs array, but there is a color array, then each color is interpolated across its corresponding triangle in a gradient. If both texs and colors arrays are present, then they behave as before, but the resulting color at each pixels is the result of multiplying the colors from the shader and the color-gradient together. The indices array is optional, but if it is present, then it is used to specify the index of each triangle, rather than just walking through the arrays in order.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawVertices
				/// </java-name>
				[Dot42.DexImport("drawVertices", "(Landroid/graphics/Canvas$VertexMode;I[FI[FI[II[SIILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawVertices(global::Android.Graphics.Canvas.VertexMode mode, int vertexCount, float[] verts, int vertOffset, float[] texs, int texOffset, int[] colors, int colorOffset, short[] indices, int indexOffset, int indexCount, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "([CIIFFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(char[] @char, int int32, int int321, float single, float single1, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the text, with origin at (x,y), using the specified paint. The origin is interpreted based on the Align setting in the paint.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawText
				/// </java-name>
				[Dot42.DexImport("drawText", "(Ljava/lang/String;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawText(string text, float x, float y, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Draw the text in the array, with each character's origin specified by the pos array.</para> <para>This method does not support glyph composition and decomposition and should therefore not be used to render complex scripts.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPosText
				/// </java-name>
				[Dot42.DexImport("drawPosText", "([CII[FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPosText(char[] text, int index, int count, float[] pos, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the text in the array, with each character's origin specified by the pos array.</para> <para>This method does not support glyph composition and decomposition and should therefore not be used to render complex scripts.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPosText
				/// </java-name>
				[Dot42.DexImport("drawPosText", "(Ljava/lang/String;[FLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawPosText(string text, float[] pos, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the text, with origin at (x,y), using the specified paint, along the specified path. The paint's Align setting determins where along the path to start the text.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawTextOnPath
				/// </java-name>
				[Dot42.DexImport("drawTextOnPath", "([CIILandroid/graphics/Path;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawTextOnPath(char[] text, int index, int count, global::Android.Graphics.Path path, float hOffset, float vOffset, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the text, with origin at (x,y), using the specified paint, along the specified path. The paint's Align setting determins where along the path to start the text.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawTextOnPath
				/// </java-name>
				[Dot42.DexImport("drawTextOnPath", "(Ljava/lang/String;Landroid/graphics/Path;FFLandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void DrawTextOnPath(string text, global::Android.Graphics.Path path, float hOffset, float vOffset, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Save the canvas state, draw the picture, and restore the canvas state. This differs from picture.draw(canvas), which does not perform any save/restore.</para> <para> <b>Note:</b> This forces the picture to internally call Picture#endRecording in order to prepare for playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the picture, stretched to fit into the dst rectangle. </para>        
				/// </summary>
				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture, global::Android.Graphics.RectF dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw the picture, stretched to fit into the dst rectangle. </para>        
				/// </summary>
				/// <java-name>
				/// drawPicture
				/// </java-name>
				[Dot42.DexImport("drawPicture", "(Landroid/graphics/Picture;Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void DrawPicture(global::Android.Graphics.Picture picture, global::Android.Graphics.Rect dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this Canvas uses hardware acceleration.</para> <para>Note that this method does not define what type of hardware acceleration may or may not be used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if drawing operations are hardware accelerated, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isHardwareAccelerated
				/// </java-name>
				public virtual bool IsHardwareAccelerated
				{
						[Dot42.DexImport("isHardwareAccelerated", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the device that the current layer draws into is opaque (i.e. does not support per-pixel alpha).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the device that the current layer draws into is opaque </para>
				/// </returns>
				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the width of the current drawing layer</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the width of the current drawing layer </para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the height of the current drawing layer</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the height of the current drawing layer </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the target density of the canvas. The default density is derived from the density of its backing bitmap, or Bitmap#DENSITY_NONE if there is not one.</para> <para> <para>setDensity(int) </para> <para>Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current target density of the canvas, which is used to determine the scaling factor when drawing a bitmap into it.</para>
				/// </returns>
				/// <java-name>
				/// getDensity
				/// </java-name>
				public virtual int Density
				{
						[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDensity", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the number of matrix/clip states on the Canvas' private stack. This will equal # save() calls - # restore() calls. </para>        
				/// </summary>
				/// <java-name>
				/// getSaveCount
				/// </java-name>
				public virtual int SaveCount
				{
						[Dot42.DexImport("getSaveCount", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return a new matrix with a copy of the canvas' current transformation matrix. </para>        
				/// </summary>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				public virtual global::Android.Graphics.Matrix Matrix
				{
						[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 17)]
						get{ return default(global::Android.Graphics.Matrix); }
						[Dot42.DexImport("setMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDrawFilter
				/// </java-name>
				public virtual global::Android.Graphics.DrawFilter DrawFilter
				{
						[Dot42.DexImport("getDrawFilter", "()Landroid/graphics/DrawFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.DrawFilter); }
						[Dot42.DexImport("setDrawFilter", "(Landroid/graphics/DrawFilter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Retrieve the bounds of the current clip (in local coordinates).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the clip bounds, or [0, 0, 0, 0] if the clip is empty. </para>
				/// </returns>
				/// <java-name>
				/// getClipBounds
				/// </java-name>
				public global::Android.Graphics.Rect ClipBounds
				{
						[Dot42.DexImport("getClipBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
						get{ return default(global::Android.Graphics.Rect); }
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

		/// <summary>
		///  <para>The Color class defines methods for creating and converting color ints. Colors are represented as packed ints, made up of 4 bytes: alpha, red, green, blue. The values are unpremultiplied, meaning any transparency is stored solely in the alpha component, and not in the color components. The components are stored as follows (alpha &lt;&lt; 24) | (red &lt;&lt; 16) | (green &lt;&lt; 8) | blue. Each component ranges between 0..255 with 0 meaning no contribution for that component, and 255 meaning 100% contribution. Thus opaque-black would be 0xFF000000 (100% opaque but no contributions from red, green, or blue), and opaque-white would be 0xFFFFFFFF </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Return the alpha component of a color int. This is the same as saying color &gt;&gt;&gt; 24 </para>        
				/// </summary>
				/// <java-name>
				/// alpha
				/// </java-name>
				[Dot42.DexImport("alpha", "(I)I", AccessFlags = 9)]
				public static int Alpha(int color) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the red component of a color int. This is the same as saying (color &gt;&gt; 16) &amp; 0xFF </para>        
				/// </summary>
				/// <java-name>
				/// red
				/// </java-name>
				[Dot42.DexImport("red", "(I)I", AccessFlags = 9)]
				public static int Red(int color) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the green component of a color int. This is the same as saying (color &gt;&gt; 8) &amp; 0xFF </para>        
				/// </summary>
				/// <java-name>
				/// green
				/// </java-name>
				[Dot42.DexImport("green", "(I)I", AccessFlags = 9)]
				public static int Green(int color) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the blue component of a color int. This is the same as saying color &amp; 0xFF </para>        
				/// </summary>
				/// <java-name>
				/// blue
				/// </java-name>
				[Dot42.DexImport("blue", "(I)I", AccessFlags = 9)]
				public static int Blue(int color) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a color-int from red, green, blue components. The alpha component is implicity 255 (fully opaque). These component values should be [0..255], but there is no range check performed, so if they are out of range, the returned color is undefined. </para>        
				/// </summary>
				/// <java-name>
				/// rgb
				/// </java-name>
				[Dot42.DexImport("rgb", "(III)I", AccessFlags = 9)]
				public static int Rgb(int red, int green, int blue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a color-int from alpha, red, green, blue components. These component values should be [0..255], but there is no range check performed, so if they are out of range, the returned color is undefined. </para>        
				/// </summary>
				/// <java-name>
				/// argb
				/// </java-name>
				[Dot42.DexImport("argb", "(IIII)I", AccessFlags = 9)]
				public static int Argb(int alpha, int red, int green, int blue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Parse the color string, and return the corresponding color-int. If the string cannot be parsed, throws an IllegalArgumentException exception. Supported formats are: #RRGGBB #AARRGGBB 'red', 'blue', 'green', 'black', 'white', 'gray', 'cyan', 'magenta', 'yellow', 'lightgray', 'darkgray', 'grey', 'lightgrey', 'darkgrey', 'aqua', 'fuschia', 'lime', 'maroon', 'navy', 'olive', 'purple', 'silver', 'teal' </para>        
				/// </summary>
				/// <java-name>
				/// parseColor
				/// </java-name>
				[Dot42.DexImport("parseColor", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int ParseColor(string colorString) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convert RGB components to HSV. hsv[0] is Hue [0 .. 360) hsv[1] is Saturation [0...1] hsv[2] is Value [0...1] </para>        
				/// </summary>
				/// <java-name>
				/// RGBToHSV
				/// </java-name>
				[Dot42.DexImport("RGBToHSV", "(III[F)V", AccessFlags = 9)]
				public static void RGBToHSV(int red, int green, int blue, float[] hsv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convert the argb color to its HSV components. hsv[0] is Hue [0 .. 360) hsv[1] is Saturation [0...1] hsv[2] is Value [0...1] </para>        
				/// </summary>
				/// <java-name>
				/// colorToHSV
				/// </java-name>
				[Dot42.DexImport("colorToHSV", "(I[F)V", AccessFlags = 9)]
				public static void ColorToHSV(int color, float[] hsv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convert HSV components to an ARGB color. Alpha set to 0xFF. hsv[0] is Hue [0 .. 360) hsv[1] is Saturation [0...1] hsv[2] is Value [0...1] If hsv values are out of range, they are pinned. </para>        
				/// </summary>
				/// <returns>
				///  <para>the resulting argb color </para>
				/// </returns>
				/// <java-name>
				/// HSVToColor
				/// </java-name>
				[Dot42.DexImport("HSVToColor", "([F)I", AccessFlags = 9)]
				public static int HSVToColor(float[] hsv) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convert HSV components to an ARGB color. The alpha component is passed through unchanged. hsv[0] is Hue [0 .. 360) hsv[1] is Saturation [0...1] hsv[2] is Value [0...1] If hsv values are out of range, they are pinned. </para>        
				/// </summary>
				/// <returns>
				///  <para>the resulting argb color </para>
				/// </returns>
				/// <java-name>
				/// HSVToColor
				/// </java-name>
				[Dot42.DexImport("HSVToColor", "(I[F)I", AccessFlags = 9)]
				public static int HSVToColor(int alpha, float[] hsv) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>5x4 matrix for transforming the color+alpha components of a Bitmap. The matrix is stored in a single array, and its treated as follows: [ a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t ]</para> <para>When applied to a color [r, g, b, a], the resulting color is computed as (after clamping) R' = a*R + b*G + c*B + d*A + e; G' = f*R + g*G + h*B + i*A + j; B' = k*R + l*G + m*B + n*A + o; A' = p*R + q*G + r*B + s*A + t; </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/ColorMatrix
		/// </java-name>
		[Dot42.DexImport("android/graphics/ColorMatrix", AccessFlags = 33)]
		public partial class ColorMatrix
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new colormatrix initialized to identity (as if reset() had been called). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ColorMatrix() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new colormatrix initialized with the specified colormatrix. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public ColorMatrix(float[] src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new colormatrix initialized with the specified colormatrix. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public ColorMatrix(global::Android.Graphics.ColorMatrix src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set this colormatrix to identity: [ 1 0 0 0 0 - red vector 0 1 0 0 0 - green vector 0 0 1 0 0 - blue vector 0 0 0 1 0 ] - alpha vector </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign the src colormatrix into this matrix, copying all of its values. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.ColorMatrix src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign the src colormatrix into this matrix, copying all of its values. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "([F)V", AccessFlags = 1)]
				public virtual void Set(float[] src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set this colormatrix to scale by the specified values. </para>        
				/// </summary>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetScale(float rScale, float gScale, float bScale, float aScale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the rotation on a color axis by the specified values. axis=0 correspond to a rotation around the RED color axis=1 correspond to a rotation around the GREEN color axis=2 correspond to a rotation around the BLUE color </para>        
				/// </summary>
				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(IF)V", AccessFlags = 1)]
				public virtual void SetRotate(int axis, float degrees) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set this colormatrix to the concatenation of the two specified colormatrices, such that the resulting colormatrix has the same effect as applying matB and then applying matA. It is legal for either matA or matB to be the same colormatrix as this. </para>        
				/// </summary>
				/// <java-name>
				/// setConcat
				/// </java-name>
				[Dot42.DexImport("setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void SetConcat(global::Android.Graphics.ColorMatrix matA, global::Android.Graphics.ColorMatrix matB) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Concat this colormatrix with the specified prematrix. This is logically the same as calling setConcat(this, prematrix); </para>        
				/// </summary>
				/// <java-name>
				/// preConcat
				/// </java-name>
				[Dot42.DexImport("preConcat", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void PreConcat(global::Android.Graphics.ColorMatrix prematrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Concat this colormatrix with the specified postmatrix. This is logically the same as calling setConcat(postmatrix, this); </para>        
				/// </summary>
				/// <java-name>
				/// postConcat
				/// </java-name>
				[Dot42.DexImport("postConcat", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public virtual void PostConcat(global::Android.Graphics.ColorMatrix postmatrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to affect the saturation of colors. A value of 0 maps the color to gray-scale. 1 is identity. </para>        
				/// </summary>
				/// <java-name>
				/// setSaturation
				/// </java-name>
				[Dot42.DexImport("setSaturation", "(F)V", AccessFlags = 1)]
				public virtual void SetSaturation(float sat) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to convert RGB to YUV </para>        
				/// </summary>
				/// <java-name>
				/// setRGB2YUV
				/// </java-name>
				[Dot42.DexImport("setRGB2YUV", "()V", AccessFlags = 1)]
				public virtual void SetRGB2YUV() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to convert from YUV to RGB </para>        
				/// </summary>
				/// <java-name>
				/// setYUV2RGB
				/// </java-name>
				[Dot42.DexImport("setYUV2RGB", "()V", AccessFlags = 1)]
				public virtual void SetYUV2RGB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the array of floats representing this colormatrix. </para>        
				/// </summary>
				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
						[Dot42.DexImport("getArray", "()[F", AccessFlags = 17)]
						get{ return default(float[]); }
				}

		}

		/// <java-name>
		/// android/graphics/ColorMatrixColorFilter
		/// </java-name>
		[Dot42.DexImport("android/graphics/ColorMatrixColorFilter", AccessFlags = 33)]
		public partial class ColorMatrixColorFilter : global::Android.Graphics.ColorFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a colorfilter that transforms colors through a 4x5 color matrix.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/ColorMatrix;)V", AccessFlags = 1)]
				public ColorMatrixColorFilter(global::Android.Graphics.ColorMatrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a colorfilter that transforms colors through a 4x5 color matrix.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public ColorMatrixColorFilter(float[] matrix) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Construct a PathEffect whose effect is to apply first the inner effect and the the outer pathEffect (e.g. outer(inner(path))). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V", AccessFlags = 1)]
				public ComposePathEffect(global::Android.Graphics.PathEffect outerpe, global::Android.Graphics.PathEffect innerpe) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComposePathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A subclass of shader that returns the composition of two other shaders, combined by an android.graphics.Xfermode subclass. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/ComposeShader
		/// </java-name>
		[Dot42.DexImport("android/graphics/ComposeShader", AccessFlags = 33)]
		public partial class ComposeShader : global::Android.Graphics.Shader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new compose shader, given shaders A, B, and a combining mode. When the mode is applied, it will be given the result from shader A as its "dst", and the result from shader B as its "src". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/Xfermode;)V", AccessFlags = 1)]
				public ComposeShader(global::Android.Graphics.Shader shaderA, global::Android.Graphics.Shader shaderB, global::Android.Graphics.Xfermode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new compose shader, given shaders A, B, and a combining mode. When the mode is applied, it will be given the result from shader A as its "dst", and the result from shader B as its "src". </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/PorterDuff$M" +
    "ode;)V", AccessFlags = 1)]
				public ComposeShader(global::Android.Graphics.Shader shaderA, global::Android.Graphics.Shader shaderB, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Transforms geometries that are drawn (either STROKE or FILL styles) by replacing any sharp angles between line segments into rounded angles of the specified radius. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public CornerPathEffect(float radius) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>The intervals array must contain an even number of entries (&gt;=2), with the even indices specifying the "on" intervals, and the odd indices specifying the "off" intervals. phase is an offset into the intervals array (mod the sum of all of the intervals). The intervals array controls the length of the dashes. The paint's strokeWidth controls the thickness of the dashes. Note: this patheffect only affects drawing with the paint's style is set to STROKE or FILL_AND_STROKE. It is ignored if the drawing is done with style == FILL. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([FF)V", AccessFlags = 1)]
				public DashPathEffect(float[] intervals, float phase) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Chop the path into lines of segmentLength, randomly deviating from the original path by deviation. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public DiscretePathEffect(float segmentLength, float deviation) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DiscretePathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A DrawFilter subclass can be installed in a Canvas. When it is present, it can modify the paint that is used to draw (temporarily). With this, a filter can disable/enable antialiasing, or change the color for everything this is drawn. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Create an emboss maskfilter</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the emboss maskfilter </para>
				/// </returns>
				[Dot42.DexImport("<init>", "([FFFF)V", AccessFlags = 1)]
				public EmbossMaskFilter(float[] direction, float ambient, float specular, float blurRadius) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>RGB format used for pictures encoded as RGB_565. See android.hardware.Camera.Parameters#setPictureFormat(int). </para>        
				/// </summary>
				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "I", AccessFlags = 25)]
				public const int RGB_565 = 4;
				/// <summary>
				///  <para>Android YUV format.</para> <para>This format is exposed to software decoders and applications.</para> <para>YV12 is a 4:2:0 YCrCb planar format comprised of a WxH Y plane followed by (W/2) x (H/2) Cr and Cb planes.</para> <para>This format assumes  <ul> <li> <para>an even width </para></li> <li> <para>an even height </para></li> <li> <para>a horizontal stride multiple of 16 pixels </para></li> <li> <para>a vertical stride equal to the height </para></li></ul></para> <para> <pre> y_size = stride * height
				/// c_stride = ALIGN(stride/2, 16)
				/// c_size = c_stride * height/2
				/// size = y_size + c_size * 2
				/// cr_offset = y_size
				/// cb_offset = y_size + c_size</pre></para> <para>This format is guaranteed to be supported for camera preview images since API level 12; for earlier API versions, check android.hardware.Camera.Parameters#getSupportedPreviewFormats().</para> <para>Note that for camera preview callback use (see android.hardware.Camera#setPreviewCallback), the  <b>stride</b> value is the smallest possible; that is, it is equal to:</para> <para> <pre>stride = ALIGN(width, 16)</pre></para> <para> <para>android.hardware.Camera.Parameters::setPreviewCallback </para> <para>android.hardware.Camera.Parameters::setPreviewFormat </para> <para>android.hardware.Camera.Parameters::getSupportedPreviewFormats </para></para>        
				/// </summary>
				/// <java-name>
				/// YV12
				/// </java-name>
				[Dot42.DexImport("YV12", "I", AccessFlags = 25)]
				public const int YV12 = 842094169;
				/// <summary>
				///  <para>YCbCr format, used for video. Whether this format is supported by the camera hardware can be determined by android.hardware.Camera.Parameters#getSupportedPreviewFormats(). </para>        
				/// </summary>
				/// <java-name>
				/// NV16
				/// </java-name>
				[Dot42.DexImport("NV16", "I", AccessFlags = 25)]
				public const int NV16 = 16;
				/// <summary>
				///  <para>YCrCb format used for images, which uses the NV21 encoding format. This is the default format for camera preview images, when not otherwise set with android.hardware.Camera.Parameters#setPreviewFormat(int). </para>        
				/// </summary>
				/// <java-name>
				/// NV21
				/// </java-name>
				[Dot42.DexImport("NV21", "I", AccessFlags = 25)]
				public const int NV21 = 17;
				/// <summary>
				///  <para>YCbCr format used for images, which uses YUYV (YUY2) encoding format. This is an alternative format for camera preview images. Whether this format is supported by the camera hardware can be determined by android.hardware.Camera.Parameters#getSupportedPreviewFormats(). </para>        
				/// </summary>
				/// <java-name>
				/// YUY2
				/// </java-name>
				[Dot42.DexImport("YUY2", "I", AccessFlags = 25)]
				public const int YUY2 = 20;
				/// <summary>
				///  <para>Encoded formats. These are not necessarily supported by the hardware. </para>        
				/// </summary>
				/// <java-name>
				/// JPEG
				/// </java-name>
				[Dot42.DexImport("JPEG", "I", AccessFlags = 25)]
				public const int JPEG = 256;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ImageFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use this function to retrieve the number of bits per pixel of an ImageFormat.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bits per pixel of the given format or -1 if the format doesn't exist or is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getBitsPerPixel
				/// </java-name>
				[Dot42.DexImport("getBitsPerPixel", "(I)I", AccessFlags = 9)]
				public static int GetBitsPerPixel(int format) /* MethodBuilder.Create */ 
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
				public Interpolator(int valueCount) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Interpolator(int valueCount, int frameCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the Interpolator to have the specified number of values and an implicit keyFrame count of 2 (just a start and end). After this call the values for each keyFrame must be assigned using setKeyFrame(). </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(I)V", AccessFlags = 1)]
				public virtual void Reset(int valueCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the Interpolator to have the specified number of values and keyFrames. After this call the values for each keyFrame must be assigned using setKeyFrame(). </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(II)V", AccessFlags = 1)]
				public virtual void Reset(int valueCount, int frameCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign the keyFrame (specified by index) a time value and an array of key values (with an implicity blend array of [0, 0, 1, 1] giving linear transition to the next set of key values).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyFrame
				/// </java-name>
				[Dot42.DexImport("setKeyFrame", "(II[F)V", AccessFlags = 1)]
				public virtual void SetKeyFrame(int index, int msec, float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign the keyFrame (specified by index) a time value and an array of key values and blend array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyFrame
				/// </java-name>
				[Dot42.DexImport("setKeyFrame", "(II[F[F)V", AccessFlags = 1)]
				public virtual void SetKeyFrame(int index, int msec, float[] values, float[] blend) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a repeat count (which may be fractional) for the interpolator, and whether the interpolator should mirror its repeats. The default settings are repeatCount = 1, and mirror = false. </para>        
				/// </summary>
				/// <java-name>
				/// setRepeatMirror
				/// </java-name>
				[Dot42.DexImport("setRepeatMirror", "(FZ)V", AccessFlags = 1)]
				public virtual void SetRepeatMirror(float repeatCount, bool mirror) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calls timeToValues(msec, values) with the msec set to now (by calling (int)SystemClock.uptimeMillis().) </para>        
				/// </summary>
				/// <java-name>
				/// timeToValues
				/// </java-name>
				[Dot42.DexImport("timeToValues", "([F)Landroid/graphics/Interpolator$Result;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Interpolator.Result TimeToValues(float[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Interpolator.Result);
				}

				/// <summary>
				///  <para>Given a millisecond time value (msec), return the interpolated values and return whether the specified time was within the range of key times (NORMAL), was before the first key time (FREEZE_START) or after the last key time (FREEZE_END). In any event, computed values are always returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>how the values were computed (even if values == null) </para>
				/// </returns>
				/// <java-name>
				/// timeToValues
				/// </java-name>
				[Dot42.DexImport("timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Interpolator.Result TimeToValues(int msec, float[] values) /* MethodBuilder.Create */ 
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
						get{ return default(int); }
				}

				/// <java-name>
				/// getValueCount
				/// </java-name>
				public int ValueCount
				{
						[Dot42.DexImport("getValueCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
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

				/// <summary>
				///  <para>Add a new layer (above any previous layers) to the rasterizer. The layer will extract those fields that affect the mask from the specified paint, but will not retain a reference to the paint object itself, so it may be reused without danger of side-effects. </para>        
				/// </summary>
				/// <java-name>
				/// addLayer
				/// </java-name>
				[Dot42.DexImport("addLayer", "(Landroid/graphics/Paint;FF)V", AccessFlags = 1)]
				public virtual void AddLayer(global::Android.Graphics.Paint paint, float dx, float dy) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Create a colorfilter that multiplies the RGB channels by one color, and then adds a second color, pinning the result for each component to [0..255]. The alpha components of the mul and add arguments are ignored. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public LightingColorFilter(int mul, int add) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>MaskFilter is the base class for object that perform transformations on an alpha-channel mask before drawing it. A subclass of MaskFilter may be installed into a Paint. Blur and emboss are implemented as subclasses of MaskFilter. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>The Matrix class holds a 3x3 matrix for transforming coordinates. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Create an identity matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a matrix that is a (deep) copy of src </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public Matrix(global::Android.Graphics.Matrix src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if will map a rectangle to another rectangle. This can be true if the matrix is identity, scale-only, or rotates a multiple of 90 degrees. </para>        
				/// </summary>
				/// <java-name>
				/// rectStaysRect
				/// </java-name>
				[Dot42.DexImport("rectStaysRect", "()Z", AccessFlags = 1)]
				public virtual bool RectStaysRect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>(deep) copy the src matrix into this matrix. If src is null, reset this matrix to the identity matrix. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Matrix src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true iff obj is a Matrix and its values equal our values. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the matrix to identity </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to translate by (dx, dy). </para>        
				/// </summary>
				/// <java-name>
				/// setTranslate
				/// </java-name>
				[Dot42.DexImport("setTranslate", "(FF)V", AccessFlags = 1)]
				public virtual void SetTranslate(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to scale by sx and sy, with a pivot point at (px, py). The pivot point is the coordinate that should remain unchanged by the specified transformation. </para>        
				/// </summary>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetScale(float sx, float sy, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to scale by sx and sy. </para>        
				/// </summary>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(FF)V", AccessFlags = 1)]
				public virtual void SetScale(float sx, float sy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to rotate by the specified number of degrees, with a pivot point at (px, py). The pivot point is the coordinate that should remain unchanged by the specified transformation. </para>        
				/// </summary>
				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(FFF)V", AccessFlags = 1)]
				public virtual void SetRotate(float degrees, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to rotate about (0,0) by the specified number of degrees. </para>        
				/// </summary>
				/// <java-name>
				/// setRotate
				/// </java-name>
				[Dot42.DexImport("setRotate", "(F)V", AccessFlags = 1)]
				public virtual void SetRotate(float degrees) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to rotate by the specified sine and cosine values, with a pivot point at (px, py). The pivot point is the coordinate that should remain unchanged by the specified transformation. </para>        
				/// </summary>
				/// <java-name>
				/// setSinCos
				/// </java-name>
				[Dot42.DexImport("setSinCos", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetSinCos(float sinValue, float cosValue, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to rotate by the specified sine and cosine values. </para>        
				/// </summary>
				/// <java-name>
				/// setSinCos
				/// </java-name>
				[Dot42.DexImport("setSinCos", "(FF)V", AccessFlags = 1)]
				public virtual void SetSinCos(float sinValue, float cosValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to skew by sx and sy, with a pivot point at (px, py). The pivot point is the coordinate that should remain unchanged by the specified transformation. </para>        
				/// </summary>
				/// <java-name>
				/// setSkew
				/// </java-name>
				[Dot42.DexImport("setSkew", "(FFFF)V", AccessFlags = 1)]
				public virtual void SetSkew(float kx, float ky, float px, float py) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to skew by sx and sy. </para>        
				/// </summary>
				/// <java-name>
				/// setSkew
				/// </java-name>
				[Dot42.DexImport("setSkew", "(FF)V", AccessFlags = 1)]
				public virtual void SetSkew(float kx, float ky) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to the concatenation of the two specified matrices, returning true if the the result can be represented. Either of the two matrices may also be the target matrix. this = a * b </para>        
				/// </summary>
				/// <java-name>
				/// setConcat
				/// </java-name>
				[Dot42.DexImport("setConcat", "(Landroid/graphics/Matrix;Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool SetConcat(global::Android.Graphics.Matrix a, global::Android.Graphics.Matrix b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified translation. M' = M * T(dx, dy) </para>        
				/// </summary>
				/// <java-name>
				/// preTranslate
				/// </java-name>
				[Dot42.DexImport("preTranslate", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreTranslate(float dx, float dy) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified scale. M' = M * S(sx, sy, px, py) </para>        
				/// </summary>
				/// <java-name>
				/// preScale
				/// </java-name>
				[Dot42.DexImport("preScale", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PreScale(float sx, float sy, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified scale. M' = M * S(sx, sy) </para>        
				/// </summary>
				/// <java-name>
				/// preScale
				/// </java-name>
				[Dot42.DexImport("preScale", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreScale(float sx, float sy) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified rotation. M' = M * R(degrees, px, py) </para>        
				/// </summary>
				/// <java-name>
				/// preRotate
				/// </java-name>
				[Dot42.DexImport("preRotate", "(FFF)Z", AccessFlags = 1)]
				public virtual bool PreRotate(float degrees, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified rotation. M' = M * R(degrees) </para>        
				/// </summary>
				/// <java-name>
				/// preRotate
				/// </java-name>
				[Dot42.DexImport("preRotate", "(F)Z", AccessFlags = 1)]
				public virtual bool PreRotate(float degrees) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified skew. M' = M * K(kx, ky, px, py) </para>        
				/// </summary>
				/// <java-name>
				/// preSkew
				/// </java-name>
				[Dot42.DexImport("preSkew", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PreSkew(float kx, float ky, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified skew. M' = M * K(kx, ky) </para>        
				/// </summary>
				/// <java-name>
				/// preSkew
				/// </java-name>
				[Dot42.DexImport("preSkew", "(FF)Z", AccessFlags = 1)]
				public virtual bool PreSkew(float kx, float ky) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Preconcats the matrix with the specified matrix. M' = M * other </para>        
				/// </summary>
				/// <java-name>
				/// preConcat
				/// </java-name>
				[Dot42.DexImport("preConcat", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool PreConcat(global::Android.Graphics.Matrix other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified translation. M' = T(dx, dy) * M </para>        
				/// </summary>
				/// <java-name>
				/// postTranslate
				/// </java-name>
				[Dot42.DexImport("postTranslate", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostTranslate(float dx, float dy) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified scale. M' = S(sx, sy, px, py) * M </para>        
				/// </summary>
				/// <java-name>
				/// postScale
				/// </java-name>
				[Dot42.DexImport("postScale", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PostScale(float sx, float sy, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified scale. M' = S(sx, sy) * M </para>        
				/// </summary>
				/// <java-name>
				/// postScale
				/// </java-name>
				[Dot42.DexImport("postScale", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostScale(float sx, float sy) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified rotation. M' = R(degrees, px, py) * M </para>        
				/// </summary>
				/// <java-name>
				/// postRotate
				/// </java-name>
				[Dot42.DexImport("postRotate", "(FFF)Z", AccessFlags = 1)]
				public virtual bool PostRotate(float degrees, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified rotation. M' = R(degrees) * M </para>        
				/// </summary>
				/// <java-name>
				/// postRotate
				/// </java-name>
				[Dot42.DexImport("postRotate", "(F)Z", AccessFlags = 1)]
				public virtual bool PostRotate(float degrees) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified skew. M' = K(kx, ky, px, py) * M </para>        
				/// </summary>
				/// <java-name>
				/// postSkew
				/// </java-name>
				[Dot42.DexImport("postSkew", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool PostSkew(float kx, float ky, float px, float py) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified skew. M' = K(kx, ky) * M </para>        
				/// </summary>
				/// <java-name>
				/// postSkew
				/// </java-name>
				[Dot42.DexImport("postSkew", "(FF)Z", AccessFlags = 1)]
				public virtual bool PostSkew(float kx, float ky) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Postconcats the matrix with the specified matrix. M' = other * M </para>        
				/// </summary>
				/// <java-name>
				/// postConcat
				/// </java-name>
				[Dot42.DexImport("postConcat", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool PostConcat(global::Android.Graphics.Matrix other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the matrix to the scale and translate values that map the source rectangle to the destination rectangle, returning true if the the result can be represented.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the matrix can be represented by the rectangle mapping. </para>
				/// </returns>
				/// <java-name>
				/// setRectToRect
				/// </java-name>
				[Dot42.DexImport("setRectToRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;Landroid/graphics/Matrix$ScaleTo" +
    "Fit;)Z", AccessFlags = 1)]
				public virtual bool SetRectToRect(global::Android.Graphics.RectF src, global::Android.Graphics.RectF dst, global::Android.Graphics.Matrix.ScaleToFit stf) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the matrix such that the specified src points would map to the specified dst points. The "points" are represented as an array of floats, order [x0, y0, x1, y1, ...], where each "point" is 2 float values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the matrix was set to the specified transformation </para>
				/// </returns>
				/// <java-name>
				/// setPolyToPoly
				/// </java-name>
				[Dot42.DexImport("setPolyToPoly", "([FI[FII)Z", AccessFlags = 1)]
				public virtual bool SetPolyToPoly(float[] src, int srcIndex, float[] dst, int dstIndex, int pointCount) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If this matrix can be inverted, return true and if inverse is not null, set inverse to be the inverse of this matrix. If this matrix cannot be inverted, ignore inverse and return false. </para>        
				/// </summary>
				/// <java-name>
				/// invert
				/// </java-name>
				[Dot42.DexImport("invert", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool Invert(global::Android.Graphics.Matrix inverse) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D points specified by src, and write the transformed points into the array of points specified by dst. The two arrays represent their "points" as pairs of floats [x, y].</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([FI[FII)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] dst, int dstIndex, float[] src, int srcIndex, int pointCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D vectors specified by src, and write the transformed vectors into the array of vectors specified by dst. The two arrays represent their "vectors" as pairs of floats [x, y].</para> <para>Note: this method does not apply the translation associated with the matrix. Use Matrix#mapPoints(float[], int, float[], int, int) if you want the translation to be applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([FI[FII)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] dst, int dstIndex, float[] src, int srcIndex, int vectorCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D points specified by src, and write the transformed points into the array of points specified by dst. The two arrays represent their "points" as pairs of floats [x, y].</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([F[F)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] dst, float[] src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D vectors specified by src, and write the transformed vectors into the array of vectors specified by dst. The two arrays represent their "vectors" as pairs of floats [x, y].</para> <para>Note: this method does not apply the translation associated with the matrix. Use Matrix#mapPoints(float[], float[]) if you want the translation to be applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([F[F)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] dst, float[] src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D points, and write the transformed points back into the array</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapPoints
				/// </java-name>
				[Dot42.DexImport("mapPoints", "([F)V", AccessFlags = 1)]
				public virtual void MapPoints(float[] pts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the array of 2D vectors, and write the transformed vectors back into the array.</para> <para>Note: this method does not apply the translation associated with the matrix. Use Matrix#mapPoints(float[]) if you want the translation to be applied.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mapVectors
				/// </java-name>
				[Dot42.DexImport("mapVectors", "([F)V", AccessFlags = 1)]
				public virtual void MapVectors(float[] vecs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply this matrix to the src rectangle, and write the transformed rectangle into dst. This is accomplished by transforming the 4 corners of src, and then setting dst to the bounds of those points.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result of calling rectStaysRect() </para>
				/// </returns>
				/// <java-name>
				/// mapRect
				/// </java-name>
				[Dot42.DexImport("mapRect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool MapRect(global::Android.Graphics.RectF dst, global::Android.Graphics.RectF src) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Apply this matrix to the rectangle, and write the transformed rectangle back into it. This is accomplished by transforming the 4 corners of rect, and then setting it to the bounds of those points</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result of calling rectStaysRect() </para>
				/// </returns>
				/// <java-name>
				/// mapRect
				/// </java-name>
				[Dot42.DexImport("mapRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool MapRect(global::Android.Graphics.RectF rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the mean radius of a circle after it has been mapped by this matrix. NOTE: in perspective this value assumes the circle has its center at the origin. </para>        
				/// </summary>
				/// <java-name>
				/// mapRadius
				/// </java-name>
				[Dot42.DexImport("mapRadius", "(F)F", AccessFlags = 1)]
				public virtual float MapRadius(float radius) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Copy 9 values from the matrix into the array. </para>        
				/// </summary>
				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "([F)V", AccessFlags = 1)]
				public virtual void GetValues(float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy 9 values from the array into the matrix. Depending on the implementation of Matrix, these may be transformed into 16.16 integers in the Matrix, such that a subsequent call to getValues() will not yield exactly the same values. </para>        
				/// </summary>
				/// <java-name>
				/// setValues
				/// </java-name>
				[Dot42.DexImport("setValues", "([F)V", AccessFlags = 1)]
				public virtual void SetValues(float[] values) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns true if the matrix is identity. This maybe faster than testing if (getType() == 0) </para>        
				/// </summary>
				/// <java-name>
				/// isIdentity
				/// </java-name>
				public virtual bool IsIdentity
				{
						[Dot42.DexImport("isIdentity", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

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
				public virtual bool SetTime(int relativeMilliseconds) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V", AccessFlags = 257)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, float x, float y, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;FF)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decodeStream
				/// </java-name>
				[Dot42.DexImport("decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;", AccessFlags = 265)]
				public static global::Android.Graphics.Movie DecodeStream(global::Java.IO.InputStream @is) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Movie;", AccessFlags = 265)]
				public static global::Android.Graphics.Movie DecodeByteArray(sbyte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeByteArray
				/// </java-name>
				[Dot42.DexImport("decodeByteArray", "([BII)Landroid/graphics/Movie;", AccessFlags = 265, IgnoreFromJava = true)]
				public static global::Android.Graphics.Movie DecodeByteArray(byte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// decodeFile
				/// </java-name>
				[Dot42.DexImport("decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;", AccessFlags = 9)]
				public static global::Android.Graphics.Movie DecodeFile(string pathName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>The NinePatch class permits drawing a bitmap in nine or more sections. Essentially, it allows the creation of custom graphics that will scale the way that you define, when content added within the image exceeds the normal bounds of the graphic. For a thorough explanation of a NinePatch image, read the discussion in the  document. </para> <para>The  tool offers an extremely handy way to create your NinePatch images, using a WYSIWYG graphics editor. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/NinePatch
		/// </java-name>
		[Dot42.DexImport("android/graphics/NinePatch", AccessFlags = 33)]
		public partial class NinePatch
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a drawable projection from a bitmap to nine patches.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V", AccessFlags = 1)]
				public NinePatch(global::Android.Graphics.Bitmap bitmap, sbyte[] chunk, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a drawable projection from a bitmap to nine patches.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatch(global::Android.Graphics.Bitmap bitmap, byte[] chunk, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the paint to use when drawing the NinePatch.</para> <para> <para>getPaint() </para> <para>draw(Canvas, Rect) </para> <para>draw(Canvas, RectF) </para></para>        
				/// </summary>
				/// <java-name>
				/// setPaint
				/// </java-name>
				[Dot42.DexImport("setPaint", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void SetPaint(global::Android.Graphics.Paint p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draws the NinePatch. This method will use the paint returned by getPaint().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.RectF location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draws the NinePatch. This method will use the paint returned by getPaint().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Rect location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draws the NinePatch. This method will ignore the paint returned by getPaint() and use the specified paint instead.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Rect location, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a Region representing the parts of the NinePatch that are completely transparent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>null if the NinePatch has no transparent region to report, else a Region holding the parts of the specified bounds that are transparent. </para>
				/// </returns>
				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;", AccessFlags = 17)]
				public global::Android.Graphics.Region GetTransparentRegion(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <summary>
				///  <para>Verifies that the specified byte array is a valid 9-patch data chunk.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the specified byte array represents a 9-patch data chunk, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("isNinePatchChunk", "([B)Z", AccessFlags = 265)]
				public static bool IsNinePatchChunk(sbyte[] chunk) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Verifies that the specified byte array is a valid 9-patch data chunk.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the specified byte array represents a 9-patch data chunk, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNinePatchChunk
				/// </java-name>
				[Dot42.DexImport("isNinePatchChunk", "([B)Z", AccessFlags = 265, IgnoreFromJava = true)]
				public static bool IsNinePatchChunk(byte[] chunk) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NinePatch() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the underlying bitmap's density, as per Bitmap.getDensity(). </para>        
				/// </summary>
				/// <java-name>
				/// getDensity
				/// </java-name>
				public virtual int Density
				{
						[Dot42.DexImport("getDensity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the intrinsic width, in pixels, of this NinePatch. This is equivalent to querying the width of the underlying bitmap returned by getBitmap(). </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the intrinsic height, in pixels, of this NinePatch. This is equivalent to querying the height of the underlying bitmap returned by getBitmap(). </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether this NinePatch contains transparent or translucent pixels. This is equivalent to calling  <code>getBitmap().hasAlpha()</code> on this NinePatch. </para>        
				/// </summary>
				/// <java-name>
				/// hasAlpha
				/// </java-name>
				public bool HasAlpha
				{
						[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>The Paint class holds the style and color information about how to draw geometries, text and bitmaps. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Paint
		/// </java-name>
		[Dot42.DexImport("android/graphics/Paint", AccessFlags = 33)]
		public partial class Paint
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Paint flag that enables antialiasing when drawing.</para> <para>Enabling this flag will cause all draw operations that support antialiasing to use it.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// ANTI_ALIAS_FLAG
				/// </java-name>
				[Dot42.DexImport("ANTI_ALIAS_FLAG", "I", AccessFlags = 25)]
				public const int ANTI_ALIAS_FLAG = 1;
				/// <summary>
				///  <para>Paint flag that enables bilinear sampling on scaled bitmaps.</para> <para>If cleared, scaled bitmaps will be drawn with nearest neighbor sampling, likely resulting in artifacts. This should generally be on when drawing bitmaps, unless performance-bound (rendering to software canvas) or preferring pixelation artifacts to blurriness when scaling significantly.</para> <para>If bitmaps are scaled for device density at creation time (as resource bitmaps often are) the filtering will already have been done.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FILTER_BITMAP_FLAG
				/// </java-name>
				[Dot42.DexImport("FILTER_BITMAP_FLAG", "I", AccessFlags = 25)]
				public const int FILTER_BITMAP_FLAG = 2;
				/// <summary>
				///  <para>Paint flag that enables dithering when blitting.</para> <para>Enabling this flag applies a dither to any blit operation where the target's colour space is more constrained than the source.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DITHER_FLAG
				/// </java-name>
				[Dot42.DexImport("DITHER_FLAG", "I", AccessFlags = 25)]
				public const int DITHER_FLAG = 4;
				/// <summary>
				///  <para>Paint flag that applies an underline decoration to drawn text.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int UNDERLINE_TEXT_FLAG = 8;
				/// <summary>
				///  <para>Paint flag that applies a strike-through decoration to drawn text.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// STRIKE_THRU_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("STRIKE_THRU_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int STRIKE_THRU_TEXT_FLAG = 16;
				/// <summary>
				///  <para>Paint flag that applies a synthetic bolding effect to drawn text.</para> <para>Enabling this flag will cause text draw operations to apply a simulated bold effect when drawing a Typeface that is not already bold.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FAKE_BOLD_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("FAKE_BOLD_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int FAKE_BOLD_TEXT_FLAG = 32;
				/// <summary>
				///  <para>Paint flag that enables smooth linear scaling of text.</para> <para>Enabling this flag does not actually scale text, but rather adjusts text draw operations to deal gracefully with smooth adjustment of scale. When this flag is enabled, font hinting is disabled to prevent shape deformation between scale factors, and glyph caching is disabled due to the large number of glyph images that will be generated.</para> <para>SUBPIXEL_TEXT_FLAG should be used in conjunction with this flag to prevent glyph positions from snapping to whole pixel values as scale factor is adjusted.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// LINEAR_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("LINEAR_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int LINEAR_TEXT_FLAG = 64;
				/// <summary>
				///  <para>Paint flag that enables subpixel positioning of text.</para> <para>Enabling this flag causes glyph advances to be computed with subpixel accuracy.</para> <para>This can be used with LINEAR_TEXT_FLAG to prevent text from jittering during smooth scale transitions.</para> <para> <para>Paint(int) </para> <para>setFlags(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// SUBPIXEL_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("SUBPIXEL_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int SUBPIXEL_TEXT_FLAG = 128;
				/// <summary>
				///  <para>Legacy Paint flag, no longer used. </para>        
				/// </summary>
				/// <java-name>
				/// DEV_KERN_TEXT_FLAG
				/// </java-name>
				[Dot42.DexImport("DEV_KERN_TEXT_FLAG", "I", AccessFlags = 25)]
				public const int DEV_KERN_TEXT_FLAG = 256;
				/// <summary>
				///  <para>Create a new paint with default settings. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Paint() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new paint with the specified flags. Use setFlags() to change these after the paint is created.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Paint(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new paint with the specified flags. Use setFlags() to change these after the paint is created.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public Paint(global::Android.Graphics.Paint flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Restores the paint to its default settings. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the fields from src into this paint. This is equivalent to calling get() on all of the src fields, and calling the corresponding set() methods on this. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Paint src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the paint's style, used for controlling how primitives' geometries are interpreted (except for drawBitmap, which always assumes FILL_STYLE).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's style setting (Fill, Stroke, StrokeAndFill) </para>
				/// </returns>
				/// <java-name>
				/// getStyle
				/// </java-name>
				[Dot42.DexImport("getStyle", "()Landroid/graphics/Paint$Style;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.Style GetStyle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.Style);
				}

				/// <summary>
				///  <para>Set the paint's style, used for controlling how primitives' geometries are interpreted (except for drawBitmap, which always assumes Fill).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStyle
				/// </java-name>
				[Dot42.DexImport("setStyle", "(Landroid/graphics/Paint$Style;)V", AccessFlags = 1)]
				public virtual void SetStyle(global::Android.Graphics.Paint.Style style) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper to setColor(), that takes a,r,g,b and constructs the color int</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setARGB
				/// </java-name>
				[Dot42.DexImport("setARGB", "(IIII)V", AccessFlags = 1)]
				public virtual void SetARGB(int a, int r, int g, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Applies any/all effects (patheffect, stroking) to src, returning the result in dst. The result is that drawing src with this paint will be the same as drawing dst with a default paint (at least from the geometric perspective).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the path should be filled, or false if it should be drawn with a hairline (width == 0) </para>
				/// </returns>
				/// <java-name>
				/// getFillPath
				/// </java-name>
				[Dot42.DexImport("getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool GetFillPath(global::Android.Graphics.Path src, global::Android.Graphics.Path dst) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set or clear the shader object. </para> <para>Pass null to clear any previous shader. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>shader </para>
				/// </returns>
				/// <java-name>
				/// setShader
				/// </java-name>
				[Dot42.DexImport("setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader SetShader(global::Android.Graphics.Shader shader) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader);
				}

				/// <summary>
				///  <para>Set or clear the paint's colorfilter, returning the parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>filter </para>
				/// </returns>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.ColorFilter SetColorFilter(global::Android.Graphics.ColorFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.ColorFilter);
				}

				/// <summary>
				///  <para>Set or clear the xfermode object. </para> <para>Pass null to clear any previous xfermode. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>xfermode </para>
				/// </returns>
				/// <java-name>
				/// setXfermode
				/// </java-name>
				[Dot42.DexImport("setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Xfermode SetXfermode(global::Android.Graphics.Xfermode xfermode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Xfermode);
				}

				/// <summary>
				///  <para>Set or clear the patheffect object. </para> <para>Pass null to clear any previous patheffect. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>effect </para>
				/// </returns>
				/// <java-name>
				/// setPathEffect
				/// </java-name>
				[Dot42.DexImport("setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.PathEffect SetPathEffect(global::Android.Graphics.PathEffect effect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.PathEffect);
				}

				/// <summary>
				///  <para>Set or clear the maskfilter object. </para> <para>Pass null to clear any previous maskfilter. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>maskfilter </para>
				/// </returns>
				/// <java-name>
				/// setMaskFilter
				/// </java-name>
				[Dot42.DexImport("setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;", AccessFlags = 1)]
				public virtual global::Android.Graphics.MaskFilter SetMaskFilter(global::Android.Graphics.MaskFilter maskfilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.MaskFilter);
				}

				/// <summary>
				///  <para>Set or clear the typeface object. </para> <para>Pass null to clear any previous typeface. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>typeface </para>
				/// </returns>
				/// <java-name>
				/// setTypeface
				/// </java-name>
				[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Typeface SetTypeface(global::Android.Graphics.Typeface typeface) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Set or clear the rasterizer object. </para> <para>Pass null to clear any previous rasterizer. As a convenience, the parameter passed is also returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>rasterizer </para>
				/// </returns>
				/// <java-name>
				/// setRasterizer
				/// </java-name>
				[Dot42.DexImport("setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rasterizer SetRasterizer(global::Android.Graphics.Rasterizer rasterizer) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rasterizer);
				}

				/// <summary>
				///  <para>This draws a shadow layer below the main layer, with the specified offset and color, and blur radius. If radius is 0, then the shadow layer is removed. </para>        
				/// </summary>
				/// <java-name>
				/// setShadowLayer
				/// </java-name>
				[Dot42.DexImport("setShadowLayer", "(FFFI)V", AccessFlags = 1)]
				public virtual void SetShadowLayer(float radius, float dx, float dy, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear the shadow layer. </para>        
				/// </summary>
				/// <java-name>
				/// clearShadowLayer
				/// </java-name>
				[Dot42.DexImport("clearShadowLayer", "()V", AccessFlags = 1)]
				public virtual void ClearShadowLayer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the distance above (negative) the baseline (ascent) based on the current typeface and text size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the distance above (negative) the baseline (ascent) based on the current typeface and text size. </para>
				/// </returns>
				/// <java-name>
				/// ascent
				/// </java-name>
				[Dot42.DexImport("ascent", "()F", AccessFlags = 257)]
				public virtual float Ascent() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return the distance below (positive) the baseline (descent) based on the current typeface and text size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the distance below (positive) the baseline (descent) based on the current typeface and text size. </para>
				/// </returns>
				/// <java-name>
				/// descent
				/// </java-name>
				[Dot42.DexImport("descent", "()F", AccessFlags = 257)]
				public virtual float Descent() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return the font's recommended interline spacing, given the Paint's settings for typeface, textSize, etc. If metrics is not null, return the fontmetric values in it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the font's recommended interline spacing. </para>
				/// </returns>
				/// <java-name>
				/// getFontMetrics
				/// </java-name>
				[Dot42.DexImport("getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F", AccessFlags = 257)]
				public virtual float GetFontMetrics(global::Android.Graphics.Paint.FontMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Allocates a new FontMetrics object, and then calls getFontMetrics(fm) with it, returning the object. </para>        
				/// </summary>
				/// <java-name>
				/// getFontMetrics
				/// </java-name>
				[Dot42.DexImport("getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint.FontMetrics GetFontMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint.FontMetrics);
				}

				/// <summary>
				///  <para>Return the font's interline spacing, given the Paint's settings for typeface, textSize, etc. If metrics is not null, return the fontmetric values in it. Note: all values have been converted to integers from floats, in such a way has to make the answers useful for both spacing and clipping. If you want more control over the rounding, call getFontMetrics().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the font's interline spacing. </para>
				/// </returns>
				/// <java-name>
				/// getFontMetricsInt
				/// </java-name>
				[Dot42.DexImport("getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I", AccessFlags = 257)]
				public virtual int GetFontMetricsInt(global::Android.Graphics.Paint.FontMetricsInt fmi) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Return the width of the text.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The width of the text </para>
				/// </returns>
				/// <java-name>
				/// measureText
				/// </java-name>
				[Dot42.DexImport("measureText", "(Ljava/lang/String;)F", AccessFlags = 1)]
				public virtual float MeasureText(string text) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Measure the text, stopping early if the measured width exceeds maxWidth. Return the number of chars that were measured, and if measuredWidth is not null, return in it the actual width measured.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of chars that were measured. Will always be &lt;= abs(count). </para>
				/// </returns>
				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "([CIIF[F)I", AccessFlags = 1)]
				public virtual int BreakText(char[] text, int index, int count, float maxWidth, float[] measuredWidth) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Measure the text, stopping early if the measured width exceeds maxWidth. Return the number of chars that were measured, and if measuredWidth is not null, return in it the actual width measured.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of chars that were measured. Will always be &lt;= abs(end - start). </para>
				/// </returns>
				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "(Ljava/lang/CharSequence;IIZF[F)I", AccessFlags = 1)]
				public virtual int BreakText(global::Java.Lang.ICharSequence text, int start, int end, bool measureForwards, float maxWidth, float[] measuredWidth) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Measure the text, stopping early if the measured width exceeds maxWidth. Return the number of chars that were measured, and if measuredWidth is not null, return in it the actual width measured.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of chars that were measured. Will always be &lt;= abs(count). </para>
				/// </returns>
				/// <java-name>
				/// breakText
				/// </java-name>
				[Dot42.DexImport("breakText", "(Ljava/lang/String;ZF[F)I", AccessFlags = 1)]
				public virtual int BreakText(string text, bool measureForwards, float maxWidth, float[] measuredWidth) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Return the advance widths for the characters in the string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of unichars in the specified text. </para>
				/// </returns>
				/// <java-name>
				/// getTextWidths
				/// </java-name>
				[Dot42.DexImport("getTextWidths", "(Ljava/lang/String;[F)I", AccessFlags = 1)]
				public virtual int GetTextWidths(string text, float[] widths) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Return the paint's flags. Use the Flag enum to test flag values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's flags (see enums ending in _Flag for bit masks) </para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 257)]
						get{ return default(int); }
						[Dot42.DexImport("setFlags", "(I)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if ANTI_ALIAS_FLAG bit is set AntiAliasing smooths out the edges of what is being drawn, but is has no impact on the interior of the shape. See setDither() and setFilterBitmap() to affect how colors are treated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the antialias bit is set in the paint's flags. </para>
				/// </returns>
				/// <java-name>
				/// isAntiAlias
				/// </java-name>
				public virtual bool IsAntiAlias
				{
						[Dot42.DexImport("isAntiAlias", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setAntiAlias", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if DITHER_FLAG bit is set Dithering affects how colors that are higher precision than the device are down-sampled. No dithering is generally faster, but higher precision colors are just truncated down (e.g. 8888 -&gt; 565). Dithering tries to distribute the error inherent in this process, to reduce the visual artifacts.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the dithering bit is set in the paint's flags. </para>
				/// </returns>
				/// <java-name>
				/// isDither
				/// </java-name>
				public virtual bool IsDither
				{
						[Dot42.DexImport("isDither", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if LINEAR_TEXT_FLAG bit is set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the lineartext bit is set in the paint's flags </para>
				/// </returns>
				/// <java-name>
				/// isLinearText
				/// </java-name>
				public virtual bool IsLinearText
				{
						[Dot42.DexImport("isLinearText", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setLinearText", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if SUBPIXEL_TEXT_FLAG bit is set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the subpixel bit is set in the paint's flags </para>
				/// </returns>
				/// <java-name>
				/// isSubpixelText
				/// </java-name>
				public virtual bool IsSubpixelText
				{
						[Dot42.DexImport("isSubpixelText", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setSubpixelText", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if UNDERLINE_TEXT_FLAG bit is set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the underlineText bit is set in the paint's flags. </para>
				/// </returns>
				/// <java-name>
				/// isUnderlineText
				/// </java-name>
				public virtual bool IsUnderlineText
				{
						[Dot42.DexImport("isUnderlineText", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setUnderlineText", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if STRIKE_THRU_TEXT_FLAG bit is set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the strikeThruText bit is set in the paint's flags. </para>
				/// </returns>
				/// <java-name>
				/// isStrikeThruText
				/// </java-name>
				public virtual bool IsStrikeThruText
				{
						[Dot42.DexImport("isStrikeThruText", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setStrikeThruText", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper for getFlags(), returning true if FAKE_BOLD_TEXT_FLAG bit is set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the fakeBoldText bit is set in the paint's flags. </para>
				/// </returns>
				/// <java-name>
				/// isFakeBoldText
				/// </java-name>
				public virtual bool IsFakeBoldText
				{
						[Dot42.DexImport("isFakeBoldText", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setFakeBoldText", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Whether or not the bitmap filter is activated. Filtering affects the sampling of bitmaps when they are transformed. Filtering does not affect how the colors in the bitmap are converted into device pixels. That is dependent on dithering and xfermodes.</para> <para> <para>setFilterBitmap(boolean) setFilterBitmap() </para></para>        
				/// </summary>
				/// <java-name>
				/// isFilterBitmap
				/// </java-name>
				public virtual bool IsFilterBitmap
				{
						[Dot42.DexImport("isFilterBitmap", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's color. Note that the color is a 32bit value containing alpha as well as r,g,b. This 32bit value is not premultiplied, meaning that its alpha can be any value, regardless of the values of r,g,b. See the Color class for more details.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's color (and alpha). </para>
				/// </returns>
				/// <java-name>
				/// getColor
				/// </java-name>
				public virtual int Color
				{
						[Dot42.DexImport("getColor", "()I", AccessFlags = 257)]
						get{ return default(int); }
						[Dot42.DexImport("setColor", "(I)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Helper to getColor() that just returns the color's alpha value. This is the same as calling getColor() &gt;&gt;&gt; 24. It always returns a value between 0 (completely transparent) and 255 (completely opaque).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the alpha component of the paint's color. </para>
				/// </returns>
				/// <java-name>
				/// getAlpha
				/// </java-name>
				public virtual int Alpha
				{
						[Dot42.DexImport("getAlpha", "()I", AccessFlags = 257)]
						get{ return default(int); }
						[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the width for stroking. </para> <para>A value of 0 strokes in hairline mode. Hairlines always draws a single pixel independent of the canva's matrix.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's stroke width, used whenever the paint's style is Stroke or StrokeAndFill. </para>
				/// </returns>
				/// <java-name>
				/// getStrokeWidth
				/// </java-name>
				public virtual float StrokeWidth
				{
						[Dot42.DexImport("getStrokeWidth", "()F", AccessFlags = 257)]
						get{ return default(float); }
						[Dot42.DexImport("setStrokeWidth", "(F)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's stroke miter value. Used to control the behavior of miter joins when the joins angle is sharp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's miter limit, used whenever the paint's style is Stroke or StrokeAndFill. </para>
				/// </returns>
				/// <java-name>
				/// getStrokeMiter
				/// </java-name>
				public virtual float StrokeMiter
				{
						[Dot42.DexImport("getStrokeMiter", "()F", AccessFlags = 257)]
						get{ return default(float); }
						[Dot42.DexImport("setStrokeMiter", "(F)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's Cap, controlling how the start and end of stroked lines and paths are treated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the line cap style for the paint, used whenever the paint's style is Stroke or StrokeAndFill. </para>
				/// </returns>
				/// <java-name>
				/// getStrokeCap
				/// </java-name>
				public virtual global::Android.Graphics.Paint.Cap StrokeCap
				{
						[Dot42.DexImport("getStrokeCap", "()Landroid/graphics/Paint$Cap;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Paint.Cap); }
						[Dot42.DexImport("setStrokeCap", "(Landroid/graphics/Paint$Cap;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's stroke join type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's Join. </para>
				/// </returns>
				/// <java-name>
				/// getStrokeJoin
				/// </java-name>
				public virtual global::Android.Graphics.Paint.Join StrokeJoin
				{
						[Dot42.DexImport("getStrokeJoin", "()Landroid/graphics/Paint$Join;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Paint.Join); }
						[Dot42.DexImport("setStrokeJoin", "(Landroid/graphics/Paint$Join;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the paint's shader object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's shader (or null) </para>
				/// </returns>
				/// <java-name>
				/// getShader
				/// </java-name>
				public virtual global::Android.Graphics.Shader Shader
				{
						[Dot42.DexImport("getShader", "()Landroid/graphics/Shader;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Shader); }
				}

				/// <summary>
				///  <para>Get the paint's colorfilter (maybe be null).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's colorfilter (maybe be null) </para>
				/// </returns>
				/// <java-name>
				/// getColorFilter
				/// </java-name>
				public virtual global::Android.Graphics.ColorFilter ColorFilter
				{
						[Dot42.DexImport("getColorFilter", "()Landroid/graphics/ColorFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.ColorFilter); }
				}

				/// <summary>
				///  <para>Get the paint's xfermode object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's xfermode (or null) </para>
				/// </returns>
				/// <java-name>
				/// getXfermode
				/// </java-name>
				public virtual global::Android.Graphics.Xfermode Xfermode
				{
						[Dot42.DexImport("getXfermode", "()Landroid/graphics/Xfermode;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Xfermode); }
				}

				/// <summary>
				///  <para>Get the paint's patheffect object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's patheffect (or null) </para>
				/// </returns>
				/// <java-name>
				/// getPathEffect
				/// </java-name>
				public virtual global::Android.Graphics.PathEffect PathEffect
				{
						[Dot42.DexImport("getPathEffect", "()Landroid/graphics/PathEffect;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.PathEffect); }
				}

				/// <summary>
				///  <para>Get the paint's maskfilter object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's maskfilter (or null) </para>
				/// </returns>
				/// <java-name>
				/// getMaskFilter
				/// </java-name>
				public virtual global::Android.Graphics.MaskFilter MaskFilter
				{
						[Dot42.DexImport("getMaskFilter", "()Landroid/graphics/MaskFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.MaskFilter); }
				}

				/// <summary>
				///  <para>Get the paint's typeface object. </para> <para>The typeface object identifies which font to use when drawing or measuring text.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's typeface (or null) </para>
				/// </returns>
				/// <java-name>
				/// getTypeface
				/// </java-name>
				public virtual global::Android.Graphics.Typeface Typeface
				{
						[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Typeface); }
				}

				/// <summary>
				///  <para>Get the paint's rasterizer (or null). </para> <para>The raster controls/modifies how paths/text are turned into alpha masks.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's rasterizer (or null) </para>
				/// </returns>
				/// <java-name>
				/// getRasterizer
				/// </java-name>
				public virtual global::Android.Graphics.Rasterizer Rasterizer
				{
						[Dot42.DexImport("getRasterizer", "()Landroid/graphics/Rasterizer;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Rasterizer); }
				}

				/// <summary>
				///  <para>Return the paint's Align value for drawing text. This controls how the text is positioned relative to its origin. LEFT align means that all of the text will be drawn to the right of its origin (i.e. the origin specifieds the LEFT edge of the text) and so on.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's Align value for drawing text. </para>
				/// </returns>
				/// <java-name>
				/// getTextAlign
				/// </java-name>
				public virtual global::Android.Graphics.Paint.Align TextAlign
				{
						[Dot42.DexImport("getTextAlign", "()Landroid/graphics/Paint$Align;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Paint.Align); }
						[Dot42.DexImport("setTextAlign", "(Landroid/graphics/Paint$Align;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's text size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's text size. </para>
				/// </returns>
				/// <java-name>
				/// getTextSize
				/// </java-name>
				public virtual float TextSize
				{
						[Dot42.DexImport("getTextSize", "()F", AccessFlags = 257)]
						get{ return default(float); }
						[Dot42.DexImport("setTextSize", "(F)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's horizontal scale factor for text. The default value is 1.0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's scale factor in X for drawing/measuring text </para>
				/// </returns>
				/// <java-name>
				/// getTextScaleX
				/// </java-name>
				public virtual float TextScaleX
				{
						[Dot42.DexImport("getTextScaleX", "()F", AccessFlags = 257)]
						get{ return default(float); }
						[Dot42.DexImport("setTextScaleX", "(F)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the paint's horizontal skew factor for text. The default value is 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the paint's skew factor in X for drawing text. </para>
				/// </returns>
				/// <java-name>
				/// getTextSkewX
				/// </java-name>
				public virtual float TextSkewX
				{
						[Dot42.DexImport("getTextSkewX", "()F", AccessFlags = 257)]
						get{ return default(float); }
						[Dot42.DexImport("setTextSkewX", "(F)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Return the recommend line spacing based on the current typeface and text size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>recommend line spacing based on the current typeface and text size. </para>
				/// </returns>
				/// <java-name>
				/// getFontSpacing
				/// </java-name>
				public virtual float FontSpacing
				{
						[Dot42.DexImport("getFontSpacing", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Convenience method for callers that want to have FontMetrics values as integers. </para>    
				/// </summary>
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

				/// <summary>
				///  <para>Class that describes the various metrics for a font at a given text size. Remember, Y values increase going down, so those values will be positive, and values that measure distances going up will be negative. This class is returned by getFontMetrics(). </para>    
				/// </summary>
				/// <java-name>
				/// android/graphics/Paint$FontMetrics
				/// </java-name>
				[Dot42.DexImport("android/graphics/Paint$FontMetrics", AccessFlags = 9)]
				public partial class FontMetrics
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The maximum distance above the baseline for the tallest glyph in the font at a given text size. </para>        
						/// </summary>
						/// <java-name>
						/// top
						/// </java-name>
						[Dot42.DexImport("top", "F", AccessFlags = 1)]
						public float Top;
						/// <summary>
						///  <para>The recommended distance above the baseline for singled spaced text. </para>        
						/// </summary>
						/// <java-name>
						/// ascent
						/// </java-name>
						[Dot42.DexImport("ascent", "F", AccessFlags = 1)]
						public float Ascent;
						/// <summary>
						///  <para>The recommended distance below the baseline for singled spaced text. </para>        
						/// </summary>
						/// <java-name>
						/// descent
						/// </java-name>
						[Dot42.DexImport("descent", "F", AccessFlags = 1)]
						public float Descent;
						/// <summary>
						///  <para>The maximum distance below the baseline for the lowest glyph in the font at a given text size. </para>        
						/// </summary>
						/// <java-name>
						/// bottom
						/// </java-name>
						[Dot42.DexImport("bottom", "F", AccessFlags = 1)]
						public float Bottom;
						/// <summary>
						///  <para>The recommended additional space to add between lines of text. </para>        
						/// </summary>
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
				/// <summary>
				///  <para>Subclass of DrawFilter that affects every paint by first clearing the specified clearBits in the paint's flags, and then setting the specified setBits in the paint's flags.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PaintFlagsDrawFilter(int clearBits, int setBits) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PaintFlagsDrawFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The Path class encapsulates compound (multiple contour) geometric paths consisting of straight line segments, quadratic curves, and cubic curves. It can be drawn with canvas.drawPath(path, paint), either filled or stroked (based on the paint's Style), or it can be used for clipping or to draw text on a path. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Path
		/// </java-name>
		[Dot42.DexImport("android/graphics/Path", AccessFlags = 33)]
		public partial class Path
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create an empty path </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Path() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new path, copying the contents from the src path.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public Path(global::Android.Graphics.Path src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear any lines and curves from the path, making it empty. This does NOT change the fill-type setting. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Rewinds the path: clears any lines and curves from the path but keeps the internal data structure for faster reuse. </para>        
				/// </summary>
				/// <java-name>
				/// rewind
				/// </java-name>
				[Dot42.DexImport("rewind", "()V", AccessFlags = 1)]
				public virtual void Rewind() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Replace the contents of this with the contents of src. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Path src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the path's fill type. This defines how "inside" is computed. The default value is WINDING.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the path's fill type </para>
				/// </returns>
				/// <java-name>
				/// getFillType
				/// </java-name>
				[Dot42.DexImport("getFillType", "()Landroid/graphics/Path$FillType;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path.FillType GetFillType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path.FillType);
				}

				/// <summary>
				///  <para>Set the path's fill type. This defines how "inside" is computed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFillType
				/// </java-name>
				[Dot42.DexImport("setFillType", "(Landroid/graphics/Path$FillType;)V", AccessFlags = 1)]
				public virtual void SetFillType(global::Android.Graphics.Path.FillType ft) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Toggles the INVERSE state of the filltype </para>        
				/// </summary>
				/// <java-name>
				/// toggleInverseFillType
				/// </java-name>
				[Dot42.DexImport("toggleInverseFillType", "()V", AccessFlags = 1)]
				public virtual void ToggleInverseFillType() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the path specifies a rectangle. If so, and if rect is not null, set rect to the bounds of the path. If the path does not specify a rectangle, return false and ignore rect.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the path specifies a rectangle </para>
				/// </returns>
				/// <java-name>
				/// isRect
				/// </java-name>
				[Dot42.DexImport("isRect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool IsRect(global::Android.Graphics.RectF rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Compute the bounds of the control points of the path, and write the answer into bounds. If the path contains 0 or 1 points, the bounds is set to (0,0,0,0)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// computeBounds
				/// </java-name>
				[Dot42.DexImport("computeBounds", "(Landroid/graphics/RectF;Z)V", AccessFlags = 1)]
				public virtual void ComputeBounds(global::Android.Graphics.RectF bounds, bool exact) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hint to the path to prepare for adding more points. This can allow the path to more efficiently allocate its storage.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// incReserve
				/// </java-name>
				[Dot42.DexImport("incReserve", "(I)V", AccessFlags = 1)]
				public virtual void IncReserve(int extraPtCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the beginning of the next contour to the point (x,y).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// moveTo
				/// </java-name>
				[Dot42.DexImport("moveTo", "(FF)V", AccessFlags = 1)]
				public virtual void MoveTo(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the beginning of the next contour relative to the last point on the previous contour. If there is no previous contour, this is treated the same as moveTo().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rMoveTo
				/// </java-name>
				[Dot42.DexImport("rMoveTo", "(FF)V", AccessFlags = 1)]
				public virtual void RMoveTo(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a line from the last point to the specified point (x,y). If no moveTo() call has been made for this contour, the first point is automatically set to (0,0).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// lineTo
				/// </java-name>
				[Dot42.DexImport("lineTo", "(FF)V", AccessFlags = 1)]
				public virtual void LineTo(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as lineTo, but the coordinates are considered relative to the last point on this contour. If there is no previous point, then a moveTo(0,0) is inserted automatically.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rLineTo
				/// </java-name>
				[Dot42.DexImport("rLineTo", "(FF)V", AccessFlags = 1)]
				public virtual void RLineTo(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a quadratic bezier from the last point, approaching control point (x1,y1), and ending at (x2,y2). If no moveTo() call has been made for this contour, the first point is automatically set to (0,0).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// quadTo
				/// </java-name>
				[Dot42.DexImport("quadTo", "(FFFF)V", AccessFlags = 1)]
				public virtual void QuadTo(float x1, float y1, float x2, float y2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as quadTo, but the coordinates are considered relative to the last point on this contour. If there is no previous point, then a moveTo(0,0) is inserted automatically.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rQuadTo
				/// </java-name>
				[Dot42.DexImport("rQuadTo", "(FFFF)V", AccessFlags = 1)]
				public virtual void RQuadTo(float dx1, float dy1, float dx2, float dy2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a cubic bezier from the last point, approaching control points (x1,y1) and (x2,y2), and ending at (x3,y3). If no moveTo() call has been made for this contour, the first point is automatically set to (0,0).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cubicTo
				/// </java-name>
				[Dot42.DexImport("cubicTo", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void CubicTo(float x1, float y1, float x2, float y2, float x3, float y3) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as cubicTo, but the coordinates are considered relative to the current point on this contour. If there is no previous point, then a moveTo(0,0) is inserted automatically. </para>        
				/// </summary>
				/// <java-name>
				/// rCubicTo
				/// </java-name>
				[Dot42.DexImport("rCubicTo", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void RCubicTo(float x1, float y1, float x2, float y2, float x3, float y3) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Append the specified arc to the path as a new contour. If the start of the path is different from the path's current last point, then an automatic lineTo() is added to connect the current contour to the start of the arc. However, if the path is empty, then we call moveTo() with the first point of the arc. The sweep angle is tread mod 360.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// arcTo
				/// </java-name>
				[Dot42.DexImport("arcTo", "(Landroid/graphics/RectF;FFZ)V", AccessFlags = 1)]
				public virtual void ArcTo(global::Android.Graphics.RectF oval, float startAngle, float sweepAngle, bool forceMoveTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Append the specified arc to the path as a new contour. If the start of the path is different from the path's current last point, then an automatic lineTo() is added to connect the current contour to the start of the arc. However, if the path is empty, then we call moveTo() with the first point of the arc.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// arcTo
				/// </java-name>
				[Dot42.DexImport("arcTo", "(Landroid/graphics/RectF;FF)V", AccessFlags = 1)]
				public virtual void ArcTo(global::Android.Graphics.RectF oval, float startAngle, float sweepAngle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Close the current contour. If the current point is not equal to the first point of the contour, a line segment is automatically added. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed rectangle contour to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addRect
				/// </java-name>
				[Dot42.DexImport("addRect", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRect(global::Android.Graphics.RectF rect, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed rectangle contour to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addRect
				/// </java-name>
				[Dot42.DexImport("addRect", "(FFFFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRect(float left, float top, float right, float bottom, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed oval contour to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOval
				/// </java-name>
				[Dot42.DexImport("addOval", "(Landroid/graphics/RectF;Landroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddOval(global::Android.Graphics.RectF oval, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed circle contour to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCircle
				/// </java-name>
				[Dot42.DexImport("addCircle", "(FFFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddCircle(float x, float y, float radius, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add the specified arc to the path as a new contour.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addArc
				/// </java-name>
				[Dot42.DexImport("addArc", "(Landroid/graphics/RectF;FF)V", AccessFlags = 1)]
				public virtual void AddArc(global::Android.Graphics.RectF oval, float startAngle, float sweepAngle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed round-rectangle contour to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addRoundRect
				/// </java-name>
				[Dot42.DexImport("addRoundRect", "(Landroid/graphics/RectF;FFLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRoundRect(global::Android.Graphics.RectF rect, float rx, float ry, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a closed round-rectangle contour to the path. Each corner receives two radius values [X, Y]. The corners are ordered top-left, top-right, bottom-right, bottom-left</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addRoundRect
				/// </java-name>
				[Dot42.DexImport("addRoundRect", "(Landroid/graphics/RectF;[FLandroid/graphics/Path$Direction;)V", AccessFlags = 1)]
				public virtual void AddRoundRect(global::Android.Graphics.RectF rect, float[] radii, global::Android.Graphics.Path.Direction dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a copy of src to the path, offset by (dx,dy)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;FF)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path src, float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a copy of src to the path</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a copy of src to the path, transformed by matrix</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPath
				/// </java-name>
				[Dot42.DexImport("addPath", "(Landroid/graphics/Path;Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void AddPath(global::Android.Graphics.Path src, global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the path by (dx,dy), returning true on success</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FFLandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Offset(float dx, float dy, global::Android.Graphics.Path dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the path by (dx,dy), returning true on success</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FF)V", AccessFlags = 1)]
				public virtual void Offset(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the last point of the path.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLastPoint
				/// </java-name>
				[Dot42.DexImport("setLastPoint", "(FF)V", AccessFlags = 1)]
				public virtual void SetLastPoint(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Transform the points in this path by matrix, and write the answer into dst. If dst is null, then the the original path is modified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void Transform(global::Android.Graphics.Matrix matrix, global::Android.Graphics.Path dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Transform the points in this path by matrix.</para> <para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns true if the filltype is one of the INVERSE variants</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the filltype is one of the INVERSE variants </para>
				/// </returns>
				/// <java-name>
				/// isInverseFillType
				/// </java-name>
				public virtual bool IsInverseFillType
				{
						[Dot42.DexImport("isInverseFillType", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if the path is empty (contains no lines or curves)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the path is empty (contains no lines or curves) </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

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
				/// <summary>
				///  <para>Dash the drawn path by stamping it with the specified shape. This only applies to drawings when the paint's style is STROKE or STROKE_AND_FILL. If the paint's style is FILL, then this effect is ignored. The paint's strokeWidth does not affect the results. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;FFLandroid/graphics/PathDashPathEffect$Style;)V", AccessFlags = 1)]
				public PathDashPathEffect(global::Android.Graphics.Path shape, float advance, float phase, global::Android.Graphics.PathDashPathEffect.Style style) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>PathEffect is the base class for objects in the Paint that affect the geometry of a drawing primitive before it is transformed by the canvas' matrix and drawn. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Create an empty PathMeasure object. To uses this to measure the length of a path, and/or to find the position and tangent along it, call setPath.</para> <para>Note that once a path is associated with the measure object, it is undefined if the path is subsequently modified and the the measure object is used. If the path is modified, you must call setPath with the path. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PathMeasure() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a PathMeasure object associated with the specified path object (already created and specified). The meansure object can now return the path's length, and the position and tangent of any position along the path.</para> <para>Note that once a path is associated with the measure object, it is undefined if the path is subsequently modified and the the measure object is used. If the path is modified, you must call setPath with the path.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;Z)V", AccessFlags = 1)]
				public PathMeasure(global::Android.Graphics.Path path, bool forceClosed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign a new path, or null to have none. </para>        
				/// </summary>
				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Landroid/graphics/Path;Z)V", AccessFlags = 1)]
				public virtual void SetPath(global::Android.Graphics.Path path, bool forceClosed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pins distance to 0 &lt;= distance &lt;= getLength(), and then computes the corresponding position and tangent. Returns false if there is no path, or a zero-length path was specified, in which case position and tangent are unchanged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>false if there was no path associated with this measure object </para>
				/// </returns>
				/// <java-name>
				/// getPosTan
				/// </java-name>
				[Dot42.DexImport("getPosTan", "(F[F[F)Z", AccessFlags = 1)]
				public virtual bool GetPosTan(float distance, float[] pos, float[] tan) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Pins distance to 0 &lt;= distance &lt;= getLength(), and then computes the corresponding matrix. Returns false if there is no path, or a zero-length path was specified, in which case matrix is unchanged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "(FLandroid/graphics/Matrix;I)Z", AccessFlags = 1)]
				public virtual bool GetMatrix(float distance, global::Android.Graphics.Matrix matrix, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Given a start and stop distance, return in dst the intervening segment(s). If the segment is zero-length, return false, else return true. startD and stopD are pinned to legal values (0..getLength()). If startD &lt;= stopD then return false (and leave dst untouched). Begin the segment with a moveTo if startWithMoveTo is true </para>        
				/// </summary>
				/// <java-name>
				/// getSegment
				/// </java-name>
				[Dot42.DexImport("getSegment", "(FFLandroid/graphics/Path;Z)Z", AccessFlags = 1)]
				public virtual bool GetSegment(float startD, float stopD, global::Android.Graphics.Path dst, bool startWithMoveTo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move to the next contour in the path. Return true if one exists, or false if we're done with the path. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Return the total length of the current contour, or 0 if no path is associated with this measure object. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				public virtual float Length
				{
						[Dot42.DexImport("getLength", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return true if the current contour is closed() </para>        
				/// </summary>
				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A Picture records drawing calls (via the canvas returned by beginRecording) and can then play them back into Canvas (via Picture#draw(Canvas) or Canvas#drawPicture(Picture)).For most content (e.g. text, lines, rectangles), drawing a sequence from a picture can be faster than the equivalent API calls, since the picture performs its playback without incurring any method-call overhead. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Picture
		/// </java-name>
		[Dot42.DexImport("android/graphics/Picture", AccessFlags = 33)]
		public partial class Picture
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an empty picture that is ready to record. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Picture() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a picture by making a copy of what has already been recorded in src. The contents of src are unchanged, and if src changes later, those changes will not be reflected in this picture. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public Picture(global::Android.Graphics.Picture src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>To record a picture, call beginRecording() and then draw into the Canvas that is returned. Nothing we appear on screen, but all of the draw commands (e.g. Canvas#drawRect(Rect, Paint)) will be recorded. To stop recording, call endRecording(). After endRecording() the Canvas that was returned must no longer be used, and nothing should be drawn into it. </para>        
				/// </summary>
				/// <java-name>
				/// beginRecording
				/// </java-name>
				[Dot42.DexImport("beginRecording", "(II)Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas BeginRecording(int width, int height) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <summary>
				///  <para>Call endRecording when the picture is built. After this call, the picture may be drawn, but the canvas that was returned by beginRecording must not be used anymore. This is automatically called if Picture#draw or Canvas#drawPicture(Picture) is called. </para>        
				/// </summary>
				/// <java-name>
				/// endRecording
				/// </java-name>
				[Dot42.DexImport("endRecording", "()V", AccessFlags = 1)]
				public virtual void EndRecording() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw this picture on the canvas. The picture may have the side effect of changing the matrix and clip of the canvas.</para> <para> <b>Note:</b> This forces the picture to internally call Picture#endRecording() in order to prepare for playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new picture (already recorded) from the data in the stream. This data was generated by a previous call to writeToStream(). Pictures that have been persisted across device restarts are not guaranteed to decode properly and are highly discouraged.</para> <para> <b>Note:</b> a picture created from an input stream cannot be replayed on a hardware accelerated canvas.</para> <para> <para>writeToStream(java.io.OutputStream) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The recommended alternative is to not use writeToStream and instead draw the picture into a Bitmap from which you can persist it as raw or compressed pixels. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createFromStream
				/// </java-name>
				[Dot42.DexImport("createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;", AccessFlags = 9)]
				public static global::Android.Graphics.Picture CreateFromStream(global::Java.IO.InputStream stream) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <summary>
				///  <para>Write the picture contents to a stream. The data can be used to recreate the picture in this or another process by calling createFromStream(...) The resulting stream is NOT to be persisted across device restarts as there is no guarantee that the Picture can be successfully reconstructed.</para> <para> <b>Note:</b> a picture created from an input stream cannot be replayed on a hardware accelerated canvas.</para> <para> <para>createFromStream(java.io.InputStream) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The recommended alternative is to draw the picture into a Bitmap from which you can persist it as raw or compressed pixels. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// writeToStream
				/// </java-name>
				[Dot42.DexImport("writeToStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteToStream(global::Java.IO.OutputStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Picture() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the width of the picture as passed to beginRecording. This does not reflect (per se) the content of the picture. </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the height of the picture as passed to beginRecording. This does not reflect (per se) the content of the picture. </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
						get{ return default(int); }
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
				/// <summary>
				///  <para>System chooses a format that supports translucency (many alpha bits) </para>        
				/// </summary>
				/// <java-name>
				/// TRANSLUCENT
				/// </java-name>
				[Dot42.DexImport("TRANSLUCENT", "I", AccessFlags = 25)]
				public const int TRANSLUCENT = -3;
				/// <summary>
				///  <para>System chooses a format that supports transparency (at least 1 alpha bit) </para>        
				/// </summary>
				/// <java-name>
				/// TRANSPARENT
				/// </java-name>
				[Dot42.DexImport("TRANSPARENT", "I", AccessFlags = 25)]
				public const int TRANSPARENT = -2;
				/// <summary>
				///  <para>System chooses an opaque format (no alpha bits required) </para>        
				/// </summary>
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
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ImageFormat.NV16 instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// YCbCr_422_SP
				/// </java-name>
				[Dot42.DexImport("YCbCr_422_SP", "I", AccessFlags = 25)]
				public const int YCbCr_422_SP = 16;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ImageFormat.NV21 instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// YCbCr_420_SP
				/// </java-name>
				[Dot42.DexImport("YCbCr_420_SP", "I", AccessFlags = 25)]
				public const int YCbCr_420_SP = 17;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ImageFormat.YUY2 instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// YCbCr_422_I
				/// </java-name>
				[Dot42.DexImport("YCbCr_422_I", "I", AccessFlags = 25)]
				public const int YCbCr_422_I = 20;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ImageFormat.JPEG instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
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
				public static void GetPixelFormatInfo(int format, global::Android.Graphics.PixelFormat info) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatHasAlpha
				/// </java-name>
				[Dot42.DexImport("formatHasAlpha", "(I)Z", AccessFlags = 9)]
				public static bool FormatHasAlpha(int format) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>PixelXorXfermode implements a simple pixel xor (op ^ src ^ dst). This transformation does not follow premultiplied conventions, therefore this mode *always* returns an opaque color (alpha == 255). Thus it is not really usefull for operating on blended colors. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/PixelXorXfermode
		/// </java-name>
		[Dot42.DexImport("android/graphics/PixelXorXfermode", AccessFlags = 33)]
		public partial class PixelXorXfermode : global::Android.Graphics.Xfermode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PixelXorXfermode(int opColor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PixelXorXfermode() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Point holds two integer coordinates </para>    
		/// </summary>
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
				public Point(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Point;)V", AccessFlags = 1)]
				public Point(global::Android.Graphics.Point src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the point's x and y coordinates </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(II)V", AccessFlags = 1)]
				public virtual void Set(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Negate the point's coordinates </para>        
				/// </summary>
				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()V", AccessFlags = 17)]
				public void Negate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the point's coordinates by dx, dy </para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(II)V", AccessFlags = 17)]
				public void Offset(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the point's coordinates equal (x,y) </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(II)Z", AccessFlags = 17)]
				public bool Equals(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(bool);
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Parcelable interface methods </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Write this point to the specified parcel. To restore a point from a parcel, use readFromParcel() </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the point's coordinates from the data stored in the specified parcel. To write a point to a parcel, call writeToParcel().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>PointF holds two float coordinates </para>    
		/// </summary>
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
				public PointF(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Point;)V", AccessFlags = 1)]
				public PointF(global::Android.Graphics.Point p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the point's x and y coordinates </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(FF)V", AccessFlags = 17)]
				public void Set(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the point's x and y coordinates to the coordinates of p </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/PointF;)V", AccessFlags = 17)]
				public void Set(global::Android.Graphics.PointF p) /* MethodBuilder.Create */ 
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
				public void Offset(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the point's coordinates equal (x,y) </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(FF)Z", AccessFlags = 17)]
				public bool Equals(float x, float y) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the euclidian distance from (0,0) to the point </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()F", AccessFlags = 17)]
				public float Length() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the euclidian distance from (0,0) to (x,y) </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "(FF)F", AccessFlags = 9)]
				public static float Length(float x, float y) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Parcelable interface methods </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Write this point to the specified parcel. To restore a point from a parcel, use readFromParcel() </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the point's coordinates from the data stored in the specified parcel. To write a point to a parcel, call writeToParcel().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Create a colorfilter that uses the specified color and porter-duff mode.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public PorterDuffColorFilter(int srcColor, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Create an xfermode that uses the specified porter-duff mode.</para> <para></para>        
				/// </summary>
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

		/// <summary>
		///  <para>Rect holds four integer coordinates for a rectangle. The rectangle is represented by the coordinates of its 4 edges (left, top, right bottom). These fields can be accessed directly. Use width() and height() to retrieve the rectangle's width and height. Note: most methods do not check to see that the coordinates are sorted correctly (i.e. left &lt;= right and top &lt;= bottom). </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Create a new empty Rect. All coordinates are initialized to 0. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Rect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new rectangle with the specified coordinates. Note: no range checking is performed, so the caller must ensure that left &lt;= right and top &lt;= bottom.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
				public Rect(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new rectangle, initialized with the values in the specified rectangle (which is left unmodified).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public Rect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return a string representation of the rectangle in a compact form. </para>        
				/// </summary>
				/// <java-name>
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return a string representation of the rectangle in a well-defined format.</para> <para>You can later recover the Rect from this string through unflattenFromString(String).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new String of the form "left top right bottom" </para>
				/// </returns>
				/// <java-name>
				/// flattenToString
				/// </java-name>
				[Dot42.DexImport("flattenToString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a Rect from a string of the form returned by flattenToString, or null if the string is not of that form. </para>        
				/// </summary>
				/// <java-name>
				/// unflattenFromString
				/// </java-name>
				[Dot42.DexImport("unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;", AccessFlags = 9)]
				public static global::Android.Graphics.Rect UnflattenFromString(string str) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the rectangle's width. This does not check for a valid rectangle (i.e. left &lt;= right) so the result may be negative. </para>
				/// </returns>
				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "()I", AccessFlags = 17)]
				public int Width() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the rectangle's height. This does not check for a valid rectangle (i.e. top &lt;= bottom) so the result may be negative. </para>
				/// </returns>
				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "()I", AccessFlags = 17)]
				public int Height() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the horizontal center of the rectangle. If the computed value is fractional, this method returns the largest integer that is less than the computed value. </para>
				/// </returns>
				/// <java-name>
				/// centerX
				/// </java-name>
				[Dot42.DexImport("centerX", "()I", AccessFlags = 17)]
				public int CenterX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the vertical center of the rectangle. If the computed value is fractional, this method returns the largest integer that is less than the computed value. </para>
				/// </returns>
				/// <java-name>
				/// centerY
				/// </java-name>
				[Dot42.DexImport("centerY", "()I", AccessFlags = 17)]
				public int CenterY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exact horizontal center of the rectangle as a float. </para>
				/// </returns>
				/// <java-name>
				/// exactCenterX
				/// </java-name>
				[Dot42.DexImport("exactCenterX", "()F", AccessFlags = 17)]
				public float ExactCenterX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exact vertical center of the rectangle as a float. </para>
				/// </returns>
				/// <java-name>
				/// exactCenterY
				/// </java-name>
				[Dot42.DexImport("exactCenterY", "()F", AccessFlags = 17)]
				public float ExactCenterY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Set the rectangle to (0,0,0,0) </para>        
				/// </summary>
				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the rectangle's coordinates to the specified values. Note: no range checking is performed, so it is up to the caller to ensure that left &lt;= right and top &lt;= bottom.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIII)V", AccessFlags = 1)]
				public void Set(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the coordinates from src into this rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public void Set(global::Android.Graphics.Rect src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the rectangle by adding dx to its left and right coordinates, and adding dy to its top and bottom coordinates.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(II)V", AccessFlags = 1)]
				public void Offset(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the rectangle to a specific (left, top) position, keeping its width and height the same.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offsetTo
				/// </java-name>
				[Dot42.DexImport("offsetTo", "(II)V", AccessFlags = 1)]
				public void OffsetTo(int newLeft, int newTop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inset the rectangle by (dx,dy). If dx is positive, then the sides are moved inwards, making the rectangle narrower. If dx is negative, then the sides are moved outwards, making the rectangle wider. The same holds true for dy and the top and bottom.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// inset
				/// </java-name>
				[Dot42.DexImport("inset", "(II)V", AccessFlags = 1)]
				public void Inset(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if (x,y) is inside the rectangle. The left and top are considered to be inside, while the right and bottom are not. This means that for a x,y to be contained: left &lt;= x &lt; right and top &lt;= y &lt; bottom. An empty rectangle never contains any point.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff (x,y) are contained by the rectangle, where containment means left &lt;= x &lt; right and top &lt;= y &lt; bottom </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(II)Z", AccessFlags = 1)]
				public bool Contains(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the 4 specified sides of a rectangle are inside or equal to this rectangle. i.e. is this rectangle a superset of the specified rectangle. An empty rectangle never contains another rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the the 4 specified sides of a rectangle are inside or equal to this rectangle </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(IIII)Z", AccessFlags = 1)]
				public bool Contains(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the specified rectangle r is inside or equal to this rectangle. An empty rectangle never contains another rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the specified rectangle r is inside or equal to this rectangle </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool Contains(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If the rectangle specified by left,top,right,bottom intersects this rectangle, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. Note: To just test for intersection, use intersects(Rect, Rect).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the specified rectangle and this rectangle intersect (and this rectangle is then set to that intersection) else return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(IIII)Z", AccessFlags = 1)]
				public bool Intersect(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If the specified rectangle intersects this rectangle, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. To just test for intersection, use intersects()</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the specified rectangle and this rectangle intersect (and this rectangle is then set to that intersection) else return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool Intersect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If rectangles a and b intersect, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. To just test for intersection, use intersects()</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the two specified rectangles intersect. If they do, set this rectangle to that intersection. If they do not, return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// setIntersect
				/// </java-name>
				[Dot42.DexImport("setIntersect", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public bool SetIntersect(global::Android.Graphics.Rect a, global::Android.Graphics.Rect b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if this rectangle intersects the specified rectangle. In no event is this rectangle modified. No check is performed to see if either rectangle is empty. To record the intersection, use intersect() or setIntersect().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the specified rectangle intersects this rectangle. In no event is this rectangle modified. </para>
				/// </returns>
				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(IIII)Z", AccessFlags = 1)]
				public bool Intersects(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the two specified rectangles intersect. In no event are either of the rectangles modified. To record the intersection, use intersect(Rect) or setIntersect(Rect, Rect).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the two specified rectangles intersect. In no event are either of the rectangles modified. </para>
				/// </returns>
				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Landroid/graphics/Rect;Landroid/graphics/Rect;)Z", AccessFlags = 9)]
				public static bool Intersects(global::Android.Graphics.Rect a, global::Android.Graphics.Rect b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the specified rectangle. If the specified rectangle is empty, nothing is done. If this rectangle is empty it is set to the specified rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(IIII)V", AccessFlags = 1)]
				public void Union(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the specified rectangle. If the specified rectangle is empty, nothing is done. If this rectangle is empty it is set to the specified rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public void Union(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the [x,y] coordinate. There is no check to see that this rectangle is non-empty.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(II)V", AccessFlags = 1)]
				public void Union(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Swap top/bottom or left/right if there are flipped (i.e. left &gt; right and/or top &gt; bottom). This can be called if the edges are computed separately, and may have crossed over each other. If the edges are already correct (i.e. left &lt;= right and top &lt;= bottom) then nothing is done. </para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "()V", AccessFlags = 1)]
				public void Sort() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parcelable interface methods </para>        
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
				///  <para>Write this rectangle to the specified parcel. To restore a rectangle from a parcel, use readFromParcel() </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the rectangle's coordinates from the data stored in the specified parcel. To write a rectangle to a parcel, call writeToParcel().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the rectangle is empty (left &gt;= right or top &gt;= bottom) </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>RectF holds four float coordinates for a rectangle. The rectangle is represented by the coordinates of its 4 edges (left, top, right bottom). These fields can be accessed directly. Use width() and height() to retrieve the rectangle's width and height. Note: most methods do not check to see that the coordinates are sorted correctly (i.e. left &lt;= right and top &lt;= bottom). </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Create a new empty RectF. All coordinates are initialized to 0. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RectF() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new rectangle with the specified coordinates. Note: no range checking is performed, so the caller must ensure that left &lt;= right and top &lt;= bottom.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public RectF(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new rectangle, initialized with the values in the specified rectangle (which is left unmodified).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public RectF(global::Android.Graphics.RectF r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new rectangle, initialized with the values in the specified rectangle (which is left unmodified).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public RectF(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
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
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the rectangle's width. This does not check for a valid rectangle (i.e. left &lt;= right) so the result may be negative. </para>
				/// </returns>
				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "()F", AccessFlags = 17)]
				public float Width() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the rectangle's height. This does not check for a valid rectangle (i.e. top &lt;= bottom) so the result may be negative. </para>
				/// </returns>
				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "()F", AccessFlags = 17)]
				public float Height() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the horizontal center of the rectangle. This does not check for a valid rectangle (i.e. left &lt;= right) </para>
				/// </returns>
				/// <java-name>
				/// centerX
				/// </java-name>
				[Dot42.DexImport("centerX", "()F", AccessFlags = 17)]
				public float CenterX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the vertical center of the rectangle. This does not check for a valid rectangle (i.e. top &lt;= bottom) </para>
				/// </returns>
				/// <java-name>
				/// centerY
				/// </java-name>
				[Dot42.DexImport("centerY", "()F", AccessFlags = 17)]
				public float CenterY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Set the rectangle to (0,0,0,0) </para>        
				/// </summary>
				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public virtual void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the rectangle's coordinates to the specified values. Note: no range checking is performed, so it is up to the caller to ensure that left &lt;= right and top &lt;= bottom.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(FFFF)V", AccessFlags = 1)]
				public virtual void Set(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the coordinates from src into this rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.RectF src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the coordinates from src into this rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Graphics.Rect src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the rectangle by adding dx to its left and right coordinates, and adding dy to its top and bottom coordinates.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "(FF)V", AccessFlags = 1)]
				public virtual void Offset(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset the rectangle to a specific (left, top) position, keeping its width and height the same.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offsetTo
				/// </java-name>
				[Dot42.DexImport("offsetTo", "(FF)V", AccessFlags = 1)]
				public virtual void OffsetTo(float newLeft, float newTop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inset the rectangle by (dx,dy). If dx is positive, then the sides are moved inwards, making the rectangle narrower. If dx is negative, then the sides are moved outwards, making the rectangle wider. The same holds true for dy and the top and bottom.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// inset
				/// </java-name>
				[Dot42.DexImport("inset", "(FF)V", AccessFlags = 1)]
				public virtual void Inset(float dx, float dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if (x,y) is inside the rectangle. The left and top are considered to be inside, while the right and bottom are not. This means that for a x,y to be contained: left &lt;= x &lt; right and top &lt;= y &lt; bottom. An empty rectangle never contains any point.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff (x,y) are contained by the rectangle, where containment means left &lt;= x &lt; right and top &lt;= y &lt; bottom </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(FF)Z", AccessFlags = 1)]
				public virtual bool Contains(float x, float y) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the 4 specified sides of a rectangle are inside or equal to this rectangle. i.e. is this rectangle a superset of the specified rectangle. An empty rectangle never contains another rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the the 4 specified sides of a rectangle are inside or equal to this rectangle </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Contains(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the specified rectangle r is inside or equal to this rectangle. An empty rectangle never contains another rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the specified rectangle r is inside or equal to this rectangle </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool Contains(global::Android.Graphics.RectF r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If the rectangle specified by left,top,right,bottom intersects this rectangle, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. Note: To just test for intersection, use intersects()</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the specified rectangle and this rectangle intersect (and this rectangle is then set to that intersection) else return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Intersect(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If the specified rectangle intersects this rectangle, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. To just test for intersection, use intersects()</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the specified rectangle and this rectangle intersect (and this rectangle is then set to that intersection) else return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// intersect
				/// </java-name>
				[Dot42.DexImport("intersect", "(Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool Intersect(global::Android.Graphics.RectF r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If rectangles a and b intersect, return true and set this rectangle to that intersection, otherwise return false and do not change this rectangle. No check is performed to see if either rectangle is empty. To just test for intersection, use intersects()</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the two specified rectangles intersect. If they do, set this rectangle to that intersection. If they do not, return false and do not change this rectangle. </para>
				/// </returns>
				/// <java-name>
				/// setIntersect
				/// </java-name>
				[Dot42.DexImport("setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 1)]
				public virtual bool SetIntersect(global::Android.Graphics.RectF a, global::Android.Graphics.RectF b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if this rectangle intersects the specified rectangle. In no event is this rectangle modified. No check is performed to see if either rectangle is empty. To record the intersection, use intersect() or setIntersect().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the specified rectangle intersects this rectangle. In no event is this rectangle modified. </para>
				/// </returns>
				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(FFFF)Z", AccessFlags = 1)]
				public virtual bool Intersects(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true iff the two specified rectangles intersect. In no event are either of the rectangles modified. To record the intersection, use intersect() or setIntersect().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true iff the two specified rectangles intersect. In no event are either of the rectangles modified. </para>
				/// </returns>
				/// <java-name>
				/// intersects
				/// </java-name>
				[Dot42.DexImport("intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z", AccessFlags = 9)]
				public static bool Intersects(global::Android.Graphics.RectF a, global::Android.Graphics.RectF b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the dst integer Rect by rounding this rectangle's coordinates to their nearest integer values. </para>        
				/// </summary>
				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Round(global::Android.Graphics.Rect dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the dst integer Rect by rounding "out" this rectangle, choosing the floor of top and left, and the ceiling of right and bottom. </para>        
				/// </summary>
				/// <java-name>
				/// roundOut
				/// </java-name>
				[Dot42.DexImport("roundOut", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void RoundOut(global::Android.Graphics.Rect dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the specified rectangle. If the specified rectangle is empty, nothing is done. If this rectangle is empty it is set to the specified rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(FFFF)V", AccessFlags = 1)]
				public virtual void Union(float left, float top, float right, float bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the specified rectangle. If the specified rectangle is empty, nothing is done. If this rectangle is empty it is set to the specified rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/RectF;)V", AccessFlags = 1)]
				public virtual void Union(global::Android.Graphics.RectF r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this Rect to enclose itself and the [x,y] coordinate. There is no check to see that this rectangle is non-empty.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(FF)V", AccessFlags = 1)]
				public virtual void Union(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Swap top/bottom or left/right if there are flipped (i.e. left &gt; right and/or top &gt; bottom). This can be called if the edges are computed separately, and may have crossed over each other. If the edges are already correct (i.e. left &lt;= right and top &lt;= bottom) then nothing is done. </para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "()V", AccessFlags = 1)]
				public virtual void Sort() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parcelable interface methods </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Write this rectangle to the specified parcel. To restore a rectangle from a parcel, use readFromParcel() </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the rectangle's coordinates from the data stored in the specified parcel. To write a rectangle to a parcel, call writeToParcel().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the rectangle is empty (left &gt;= right or top &gt;= bottom) </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
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
				/// <summary>
				///  <para>Create an empty region </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Region() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a copy of the specified region </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Region;)V", AccessFlags = 1)]
				public Region(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a copy of the specified region </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public Region(global::Android.Graphics.Rect region) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a region set to the specified rectangle </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
				public Region(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the region to the empty region </para>        
				/// </summary>
				/// <java-name>
				/// setEmpty
				/// </java-name>
				[Dot42.DexImport("setEmpty", "()V", AccessFlags = 1)]
				public virtual void SetEmpty() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the region to the specified region. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool Set(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the region to the specified region. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool Set(global::Android.Graphics.Rect region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the region to the specified rectangle </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIII)Z", AccessFlags = 1)]
				public virtual bool Set(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the region to the area described by the path and clip. Return true if the resulting region is non-empty. This produces a region that is identical to the pixels that would be drawn by the path (with no antialiasing). </para>        
				/// </summary>
				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool SetPath(global::Android.Graphics.Path path, global::Android.Graphics.Region clip) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the Rect to the bounds of the region. If the region is empty, the Rect will be set to [0, 0, 0, 0] </para>        
				/// </summary>
				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetBounds(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the path to the boundary of the region. If the region is empty, the path will also be empty. </para>        
				/// </summary>
				/// <java-name>
				/// getBoundaryPath
				/// </java-name>
				[Dot42.DexImport("getBoundaryPath", "(Landroid/graphics/Path;)Z", AccessFlags = 1)]
				public virtual bool GetBoundaryPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region contains the specified point </para>        
				/// </summary>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(II)Z", AccessFlags = 257)]
				public virtual bool Contains(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region is a single rectangle (not complex) and it contains the specified rectangle. Returning false is not a guarantee that the rectangle is not contained by this region, but return true is a guarantee that the rectangle is contained by this region. </para>        
				/// </summary>
				/// <java-name>
				/// quickContains
				/// </java-name>
				[Dot42.DexImport("quickContains", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool QuickContains(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region is a single rectangle (not complex) and it contains the specified rectangle. Returning false is not a guarantee that the rectangle is not contained by this region, but return true is a guarantee that the rectangle is contained by this region. </para>        
				/// </summary>
				/// <java-name>
				/// quickContains
				/// </java-name>
				[Dot42.DexImport("quickContains", "(IIII)Z", AccessFlags = 257)]
				public virtual bool QuickContains(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region is empty, or if the specified rectangle does not intersect the region. Returning false is not a guarantee that they intersect, but returning true is a guarantee that they do not. </para>        
				/// </summary>
				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool QuickReject(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region is empty, or if the specified rectangle does not intersect the region. Returning false is not a guarantee that they intersect, but returning true is a guarantee that they do not. </para>        
				/// </summary>
				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(IIII)Z", AccessFlags = 257)]
				public virtual bool QuickReject(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the region is empty, or if the specified rectangle does not intersect the region. Returning false is not a guarantee that they intersect, but returning true is a guarantee that they do not. </para>        
				/// </summary>
				/// <java-name>
				/// quickReject
				/// </java-name>
				[Dot42.DexImport("quickReject", "(Landroid/graphics/Region;)Z", AccessFlags = 257)]
				public virtual bool QuickReject(global::Android.Graphics.Region r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Translate the region by [dx, dy]. If the region is empty, do nothing. </para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(II)V", AccessFlags = 1)]
				public virtual void Translate(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the dst region to the result of translating this region by [dx, dy]. If this region is empty, then dst will be set to empty. </para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(IILandroid/graphics/Region;)V", AccessFlags = 257)]
				public virtual void Translate(int dx, int dy, global::Android.Graphics.Region dst) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// union
				/// </java-name>
				[Dot42.DexImport("union", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool Union(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Perform the specified Op on this region and the specified rect. Return true if the result of the op is not empty. </para>        
				/// </summary>
				/// <java-name>
				/// op
				/// </java-name>
				[Dot42.DexImport("op", "(IIIILandroid/graphics/Region$Op;)Z", AccessFlags = 1)]
				public virtual bool Op(int left, int top, int right, int bottom, global::Android.Graphics.Region.JavaOp op) /* MethodBuilder.Create */ 
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
				///  <para>Write the region and its pixels to the parcel. The region can be rebuilt from the parcel by calling CREATOR.createFromParcel(). </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel p, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Region() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return true if this region is empty </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the region contains a single rectangle </para>        
				/// </summary>
				/// <java-name>
				/// isRect
				/// </java-name>
				public virtual bool IsRect
				{
						[Dot42.DexImport("isRect", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the region contains more than one rectangle </para>        
				/// </summary>
				/// <java-name>
				/// isComplex
				/// </java-name>
				public virtual bool IsComplex
				{
						[Dot42.DexImport("isComplex", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return a new Rect set to the bounds of the region. If the region is empty, the Rect will be set to [0, 0, 0, 0] </para>        
				/// </summary>
				/// <java-name>
				/// getBounds
				/// </java-name>
				public virtual global::Android.Graphics.Rect Bounds
				{
						[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Rect); }
				}

				/// <summary>
				///  <para>Return the boundary of the region as a new Path. If the region is empty, the path will also be empty. </para>        
				/// </summary>
				/// <java-name>
				/// getBoundaryPath
				/// </java-name>
				public virtual global::Android.Graphics.Path BoundaryPath
				{
						[Dot42.DexImport("getBoundaryPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Path); }
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
				/// <summary>
				///  <para>Construct an iterator for all of the rectangles in a region. This effectively makes a private copy of the region, so any subsequent edits to region will not affect the iterator.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Region;)V", AccessFlags = 1)]
				public RegionIterator(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the next rectangle in the region. If there are no more rectangles this returns false and r is unchanged. If there is at least one more, this returns true and r is set to that rectangle. </para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool Next(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Shader is the based class for objects that return horizontal spans of colors during drawing. A subclass of Shader is installed in a Paint calling paint.setShader(shader). After that any object (other than a bitmap) that is drawn with that paint will get its color(s) from the shader. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Return true if the shader has a non-identity local matrix. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the shader has a non-identity local matrix </para>
				/// </returns>
				/// <java-name>
				/// getLocalMatrix
				/// </java-name>
				[Dot42.DexImport("getLocalMatrix", "(Landroid/graphics/Matrix;)Z", AccessFlags = 1)]
				public virtual bool GetLocalMatrix(global::Android.Graphics.Matrix localM) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the shader's local matrix. Passing null will reset the shader's matrix to identity </para>        
				/// </summary>
				/// <java-name>
				/// setLocalMatrix
				/// </java-name>
				[Dot42.DexImport("setLocalMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void SetLocalMatrix(global::Android.Graphics.Matrix localM) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>Construct a PathEffect whose effect is to apply two effects, in sequence. (e.g. first(path) + second(path)) </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V", AccessFlags = 1)]
				public SumPathEffect(global::Android.Graphics.PathEffect first, global::Android.Graphics.PathEffect second) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SumPathEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Captures frames from an image stream as an OpenGL ES texture.</para> <para>The image stream may come from either camera preview or video decode. A SurfaceTexture may be used in place of a SurfaceHolder when specifying the output destination of a android.hardware.Camera or android.media.MediaPlayer object. Doing so will cause all the frames from the image stream to be sent to the SurfaceTexture object rather than to the device's display. When updateTexImage is called, the contents of the texture object specified when the SurfaceTexture was created are updated to contain the most recent image from the image stream. This may cause some frames of the stream to be skipped.</para> <para>When sampling from the texture one should first transform the texture coordinates using the matrix queried via getTransformMatrix(float[]). The transform matrix may change each time updateTexImage is called, so it should be re-queried each time the texture image is updated. This matrix transforms traditional 2D OpenGL ES texture coordinate column vectors of the form (s, t, 0, 1) where s and t are on the inclusive interval [0, 1] to the proper sampling location in the streamed texture. This transform compensates for any properties of the image stream source that cause it to appear different from a traditional OpenGL ES texture. For example, sampling from the bottom left corner of the image can be accomplished by transforming the column vector (0, 0, 0, 1) using the queried matrix, while sampling from the top right corner of the image can be done by transforming (1, 1, 0, 1).</para> <para>The texture object uses the GL_TEXTURE_EXTERNAL_OES texture target, which is defined by the  OpenGL ES extension. This limits how the texture may be used. Each time the texture is bound it must be bound to the GL_TEXTURE_EXTERNAL_OES target rather than the GL_TEXTURE_2D target. Additionally, any OpenGL ES 2.0 shader that samples from the texture must declare its use of this extension using, for example, an "#extensionGL_OES_EGL_image_external : require" directive. Such shaders must also access the texture using the samplerExternalOES GLSL sampler type.</para> <para>SurfaceTexture objects may be created on any thread. updateTexImage may only be called on the thread with the OpenGL ES context that contains the texture object. The frame-available callback is called on an arbitrary thread, so unless special care is taken updateTexImage should not be called directly from the callback. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/SurfaceTexture
		/// </java-name>
		[Dot42.DexImport("android/graphics/SurfaceTexture", AccessFlags = 33)]
		public partial class SurfaceTexture
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a new SurfaceTexture to stream images to a given OpenGL texture.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SurfaceTexture(int texName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a new image frame becomes available to the SurfaceTexture. Note that this callback may be called on an arbitrary thread, so it is not safe to call updateTexImage without first binding the OpenGL ES context to the thread invoking the callback. </para>        
				/// </summary>
				/// <java-name>
				/// setOnFrameAvailableListener
				/// </java-name>
				[Dot42.DexImport("setOnFrameAvailableListener", "(Landroid/graphics/SurfaceTexture$OnFrameAvailableListener;)V", AccessFlags = 1)]
				public virtual void SetOnFrameAvailableListener(global::Android.Graphics.SurfaceTexture.IOnFrameAvailableListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update the texture image to the most recent frame from the image stream. This may only be called while the OpenGL ES context that owns the texture is current on the calling thread. It will implicitly bind its texture to the GL_TEXTURE_EXTERNAL_OES texture target. </para>        
				/// </summary>
				/// <java-name>
				/// updateTexImage
				/// </java-name>
				[Dot42.DexImport("updateTexImage", "()V", AccessFlags = 1)]
				public virtual void UpdateTexImage() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the 4x4 texture coordinate transform matrix associated with the texture image set by the most recent call to updateTexImage.</para> <para>This transform matrix maps 2D homogeneous texture coordinates of the form (s, t, 0, 1) with s and t in the inclusive range [0, 1] to the texture coordinate that should be used to sample that location from the texture. Sampling the texture outside of the range of this transform is undefined.</para> <para>The matrix is stored in column-major order so that it may be passed directly to OpenGL ES via the glLoadMatrixf or glUniformMatrix4fv functions.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getTransformMatrix
				/// </java-name>
				[Dot42.DexImport("getTransformMatrix", "([F)V", AccessFlags = 1)]
				public virtual void GetTransformMatrix(float[] mtx) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Exception thrown when a SurfaceTexture couldn't be created or resized.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>No longer thrown. Surface.OutOfResourcesException is used instead. </para></xrefdescription></xrefsect></para>    
				/// </summary>
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

				/// <summary>
				///  <para>Callback interface for being notified that a new stream frame is available. </para>    
				/// </summary>
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

		/// <summary>
		///  <para>The Typeface class specifies the typeface and intrinsic style of a font. This is used in the paint, along with optionally Paint settings like textSize, textSkewX, textScaleX to specify how text appears when drawn (and measured). </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/Typeface
		/// </java-name>
		[Dot42.DexImport("android/graphics/Typeface", AccessFlags = 33)]
		public partial class Typeface
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The default NORMAL typeface object </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface DEFAULT;
				/// <summary>
				///  <para>The default BOLD typeface object. Note: this may be not actually be bold, depending on what fonts are installed. Call getStyle() to know for sure. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_BOLD
				/// </java-name>
				[Dot42.DexImport("DEFAULT_BOLD", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface DEFAULT_BOLD;
				/// <summary>
				///  <para>The NORMAL style of the default sans serif typeface. </para>        
				/// </summary>
				/// <java-name>
				/// SANS_SERIF
				/// </java-name>
				[Dot42.DexImport("SANS_SERIF", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface SANS_SERIF;
				/// <summary>
				///  <para>The NORMAL style of the default serif typeface. </para>        
				/// </summary>
				/// <java-name>
				/// SERIF
				/// </java-name>
				[Dot42.DexImport("SERIF", "Landroid/graphics/Typeface;", AccessFlags = 25)]
				public static readonly global::Android.Graphics.Typeface SERIF;
				/// <summary>
				///  <para>The NORMAL style of the default monospace typeface. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Create a typeface object that best matches the specified existing typeface and the specified Style. Use this call if you want to pick a new style from the same family of an existing typeface object. If family is null, this selects from the default font's family.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The best matching typeface. </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface Create(string family, int style) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Create a typeface object that best matches the specified existing typeface and the specified Style. Use this call if you want to pick a new style from the same family of an existing typeface object. If family is null, this selects from the default font's family.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The best matching typeface. </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface Create(global::Android.Graphics.Typeface family, int style) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Returns one of the default typeface objects, based on the specified style</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default typeface that corresponds to the style </para>
				/// </returns>
				/// <java-name>
				/// defaultFromStyle
				/// </java-name>
				[Dot42.DexImport("defaultFromStyle", "(I)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface DefaultFromStyle(int style) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Create a new typeface from the specified font data. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new typeface. </para>
				/// </returns>
				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;" +
    "", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromAsset(global::Android.Content.Res.AssetManager mgr, string path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Create a new typeface from the specified font file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new typeface. </para>
				/// </returns>
				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromFile(global::Java.IO.File path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <summary>
				///  <para>Create a new typeface from the specified font file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new typeface. </para>
				/// </returns>
				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;", AccessFlags = 9)]
				public static global::Android.Graphics.Typeface CreateFromFile(string path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Typeface);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Typeface() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the typeface's intrinsic style attributes </para>        
				/// </summary>
				/// <java-name>
				/// getStyle
				/// </java-name>
				public virtual int Style
				{
						[Dot42.DexImport("getStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns true if getStyle() has the BOLD bit set. </para>        
				/// </summary>
				/// <java-name>
				/// isBold
				/// </java-name>
				public bool IsBold
				{
						[Dot42.DexImport("isBold", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if getStyle() has the ITALIC bit set. </para>        
				/// </summary>
				/// <java-name>
				/// isItalic
				/// </java-name>
				public bool IsItalic
				{
						[Dot42.DexImport("isItalic", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Xfermode is the base class for objects that are called to implement custom "transfer-modes" in the drawing pipeline. The static function Create(Modes) can be called to return an instance of any of the predefined subclasses as specified in the Modes enum. When an Xfermode is assigned to an Paint, then objects drawn with that paint have the xfermode applied. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>YuvImage contains YUV data and provides a method that compresses a region of the YUV data to a Jpeg. The YUV data should be provided as a single byte array irrespective of the number of image planes in it. Currently only ImageFormat.NV21 and ImageFormat.YUY2 are supported.</para> <para>To compress a rectangle region in the YUV data, users have to specify the region by left, top, width and height. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/YuvImage
		/// </java-name>
		[Dot42.DexImport("android/graphics/YuvImage", AccessFlags = 33)]
		public partial class YuvImage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct an YuvImage.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIII[I)V", AccessFlags = 1)]
				public YuvImage(sbyte[] yuv, int format, int width, int height, int[] strides) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an YuvImage.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIII[I)V", AccessFlags = 1, IgnoreFromJava = true)]
				public YuvImage(byte[] yuv, int format, int width, int height, int[] strides) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compress a rectangle region in the YuvImage to a jpeg. Only ImageFormat.NV21 and ImageFormat.YUY2 are supported for now.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the compression is successful. </para>
				/// </returns>
				/// <java-name>
				/// compressToJpeg
				/// </java-name>
				[Dot42.DexImport("compressToJpeg", "(Landroid/graphics/Rect;ILjava/io/OutputStream;)Z", AccessFlags = 1)]
				public virtual bool CompressToJpeg(global::Android.Graphics.Rect rectangle, int quality, global::Java.IO.OutputStream stream) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the YUV data. </para>
				/// </returns>
				/// <java-name>
				/// getYuvData
				/// </java-name>
				[Dot42.DexImport("getYuvData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetYuvData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal YuvImage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the YUV data. </para>
				/// </returns>
				/// <java-name>
				/// getYuvData
				/// </java-name>
				public virtual byte[] YuvData
				{
						[Dot42.DexImport("getYuvData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the YUV format as defined in ImageFormat. </para>
				/// </returns>
				/// <java-name>
				/// getYuvFormat
				/// </java-name>
				public virtual int YuvFormat
				{
						[Dot42.DexImport("getYuvFormat", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of row bytes in each image plane. </para>
				/// </returns>
				/// <java-name>
				/// getStrides
				/// </java-name>
				public virtual int[] Strides
				{
						[Dot42.DexImport("getStrides", "()[I", AccessFlags = 1)]
						get{ return default(int[]); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the width of the image. </para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the height of the image. </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

