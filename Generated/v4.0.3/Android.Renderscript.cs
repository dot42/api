#pragma warning disable 1717
namespace Android.Renderscript
{
		/// <java-name>
		/// android/renderscript/Allocation
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Allocation", AccessFlags = 33)]
		public partial class Allocation : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// USAGE_SCRIPT
				/// </java-name>
				[Dot42.DexImport("USAGE_SCRIPT", "I", AccessFlags = 25)]
				public const int USAGE_SCRIPT = 1;
				/// <java-name>
				/// USAGE_GRAPHICS_TEXTURE
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_TEXTURE", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_TEXTURE = 2;
				/// <java-name>
				/// USAGE_GRAPHICS_VERTEX
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_VERTEX", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_VERTEX = 4;
				/// <java-name>
				/// USAGE_GRAPHICS_CONSTANTS
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_CONSTANTS", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_CONSTANTS = 8;
				/// <java-name>
				/// USAGE_GRAPHICS_RENDER_TARGET
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_RENDER_TARGET", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_RENDER_TARGET = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Allocation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Type GetTypeJava() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Type);
				}

				/// <java-name>
				/// syncAll
				/// </java-name>
				[Dot42.DexImport("syncAll", "(I)V", AccessFlags = 1)]
				public virtual void SyncAll(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Renderscript.BaseObj[] baseObj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copyFromUnchecked", "([I)V", AccessFlags = 1)]
				public virtual void CopyFromUnchecked(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copyFromUnchecked", "([S)V", AccessFlags = 1)]
				public virtual void CopyFromUnchecked(short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copyFromUnchecked", "([B)V", AccessFlags = 1)]
				public virtual void CopyFromUnchecked(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copyFromUnchecked", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyFromUnchecked(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copyFromUnchecked", "([F)V", AccessFlags = 1)]
				public virtual void CopyFromUnchecked(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([I)V", AccessFlags = 1)]
				public virtual void CopyFrom(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([S)V", AccessFlags = 1)]
				public virtual void CopyFrom(short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1)]
				public virtual void CopyFrom(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyFrom(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([F)V", AccessFlags = 1)]
				public virtual void CopyFrom(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int int32, global::Android.Renderscript.FieldPacker fieldPacker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(IILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int int32, int int321, global::Android.Renderscript.FieldPacker fieldPacker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateMipmaps
				/// </java-name>
				[Dot42.DexImport("generateMipmaps", "()V", AccessFlags = 1)]
				public virtual void GenerateMipmaps() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFromUnchecked", "(II[I)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFromUnchecked(int int32, int int321, int[] int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFromUnchecked", "(II[S)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFromUnchecked(int int32, int int321, short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFromUnchecked", "(II[B)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFromUnchecked(int int32, int int321, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFromUnchecked", "(II[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Copy1DRangeFromUnchecked(int int32, int int321, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFromUnchecked
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFromUnchecked", "(II[F)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFromUnchecked(int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(II[I)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int int32, int int321, int[] int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(II[S)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int int32, int int321, short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(II[B)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int int32, int int321, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(II[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Copy1DRangeFrom(int int32, int int321, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(II[F)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int int32, int int321, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(IILandroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int int32, int int321, global::Android.Renderscript.Allocation allocation, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIII[B)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIII[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIII[S)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIII[I)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, int[] int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIII[F)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIIILandroid/renderscript/Allocation;II)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, int int322, int int323, global::Android.Renderscript.Allocation allocation, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IILandroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int int32, int int321, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyTo(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1)]
				public virtual void CopyTo(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyTo(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([S)V", AccessFlags = 1)]
				public virtual void CopyTo(short[] int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([I)V", AccessFlags = 1)]
				public virtual void CopyTo(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([F)V", AccessFlags = 1)]
				public virtual void CopyTo(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(I)V", AccessFlags = 33)]
				public virtual void Resize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;Landroid/renderscr" +
    "ipt/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Type type, global::Android.Renderscript.Allocation.MipmapControl mipmapControl, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;I)Landroid/renders" +
    "cript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Type type, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;)Landroid/rendersc" +
    "ript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;II)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateSized(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Element element, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;I)Landroid/rend" +
    "erscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateSized(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Element element, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmap(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap, global::Android.Renderscript.Allocation.MipmapControl mipmapControl, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmap(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromBitmap(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap, global::Android.Renderscript.Allocation.MipmapControl mipmapControl, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromBitmap(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", @"(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/renderscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Bitmap bitmap1, global::Android.Graphics.Bitmap bitmap2, global::Android.Graphics.Bitmap bitmap3, global::Android.Graphics.Bitmap bitmap4, global::Android.Graphics.Bitmap bitmap5, global::Android.Renderscript.Allocation.MipmapControl mipmapControl, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bi" +
    "tmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;" +
    "Landroid/graphics/Bitmap;)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscript.RenderScript renderScript, global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Bitmap bitmap1, global::Android.Graphics.Bitmap bitmap2, global::Android.Graphics.Bitmap bitmap3, global::Android.Graphics.Bitmap bitmap4, global::Android.Graphics.Bitmap bitmap5) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;ILandroid/rend" +
    "erscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmapResource(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, int int32, global::Android.Renderscript.Allocation.MipmapControl mipmapControl, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmapResource(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// createFromString
				/// </java-name>
				[Dot42.DexImport("createFromString", "(Landroid/renderscript/RenderScript;Ljava/lang/String;I)Landroid/renderscript/All" +
    "ocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromString(global::Android.Renderscript.RenderScript renderScript, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public global::Android.Renderscript.Type Type
				{
				[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						get{ return GetTypeJava(); }
				}

				/// <java-name>
				/// android/renderscript/Allocation$MipmapControl
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Allocation$MipmapControl", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Allocation$MipmapControl;>;")]
				public sealed class MipmapControl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MIPMAP_FULL
						/// </java-name>
						[Dot42.DexImport("MIPMAP_FULL", "Landroid/renderscript/Allocation$MipmapControl;", AccessFlags = 16409)]
						public static readonly MipmapControl MIPMAP_FULL;
						/// <java-name>
						/// MIPMAP_NONE
						/// </java-name>
						[Dot42.DexImport("MIPMAP_NONE", "Landroid/renderscript/Allocation$MipmapControl;", AccessFlags = 16409)]
						public static readonly MipmapControl MIPMAP_NONE;
						/// <java-name>
						/// MIPMAP_ON_SYNC_TO_TEXTURE
						/// </java-name>
						[Dot42.DexImport("MIPMAP_ON_SYNC_TO_TEXTURE", "Landroid/renderscript/Allocation$MipmapControl;", AccessFlags = 16409)]
						public static readonly MipmapControl MIPMAP_ON_SYNC_TO_TEXTURE;
						private MipmapControl() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Allocation$MipmapControl;", AccessFlags = 9)]
						public static MipmapControl[] Values() /* MethodBuilder.Create */ 
						{
								return default(MipmapControl[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Allocation$MipmapControl;", AccessFlags = 9)]
						public static MipmapControl ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(MipmapControl);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/AllocationAdapter
		/// </java-name>
		[Dot42.DexImport("android/renderscript/AllocationAdapter", AccessFlags = 33)]
		public partial class AllocationAdapter : global::Android.Renderscript.Allocation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AllocationAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLOD
				/// </java-name>
				[Dot42.DexImport("setLOD", "(I)V", AccessFlags = 1)]
				public virtual void SetLOD(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFace
				/// </java-name>
				[Dot42.DexImport("setFace", "(Landroid/renderscript/Type$CubemapFace;)V", AccessFlags = 1)]
				public virtual void SetFace(global::Android.Renderscript.Type.CubemapFace cubemapFace) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setY
				/// </java-name>
				[Dot42.DexImport("setY", "(I)V", AccessFlags = 1)]
				public virtual void SetY(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZ
				/// </java-name>
				[Dot42.DexImport("setZ", "(I)V", AccessFlags = 1)]
				public virtual void SetZ(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// create1D
				/// </java-name>
				[Dot42.DexImport("create1D", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Allocation;)Landroid/re" +
    "nderscript/AllocationAdapter;", AccessFlags = 9)]
				public static global::Android.Renderscript.AllocationAdapter Create1D(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Allocation allocation) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.AllocationAdapter);
				}

				/// <java-name>
				/// create2D
				/// </java-name>
				[Dot42.DexImport("create2D", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Allocation;)Landroid/re" +
    "nderscript/AllocationAdapter;", AccessFlags = 9)]
				public static global::Android.Renderscript.AllocationAdapter Create2D(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Allocation allocation) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.AllocationAdapter);
				}

				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(I)V", AccessFlags = 33)]
				public override void Resize(int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/BaseObj
		/// </java-name>
		[Dot42.DexImport("android/renderscript/BaseObj", AccessFlags = 33)]
		public partial class BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BaseObj() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~BaseObj() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 33)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
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
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetName(value); }
				}

		}

		/// <java-name>
		/// android/renderscript/Byte2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Byte2", AccessFlags = 33)]
		public partial class Byte2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "B", AccessFlags = 1)]
				public sbyte X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "B", AccessFlags = 1)]
				public sbyte Y;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Byte2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BB)V", AccessFlags = 1)]
				public Byte2(sbyte sByte, sbyte sByte1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte2(byte @byte, byte byte1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Byte3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Byte3", AccessFlags = 33)]
		public partial class Byte3
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "B", AccessFlags = 1)]
				public sbyte X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "B", AccessFlags = 1)]
				public sbyte Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "B", AccessFlags = 1)]
				public sbyte Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Byte3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBB)V", AccessFlags = 1)]
				public Byte3(sbyte sByte, sbyte sByte1, sbyte sByte2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte3(byte @byte, byte byte1, byte byte2) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Byte4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Byte4", AccessFlags = 33)]
		public partial class Byte4
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "B", AccessFlags = 1)]
				public sbyte X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "B", AccessFlags = 1)]
				public sbyte Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "B", AccessFlags = 1)]
				public sbyte Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "B", AccessFlags = 1)]
				public sbyte W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Byte4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBBB)V", AccessFlags = 1)]
				public Byte4(sbyte sByte, sbyte sByte1, sbyte sByte2, sbyte sByte3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBBB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte4(byte @byte, byte byte1, byte byte2, byte byte3) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Double2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Double2", AccessFlags = 33)]
		public partial class Double2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "D", AccessFlags = 1)]
				public double X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "D", AccessFlags = 1)]
				public double Y;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Double2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(DD)V", AccessFlags = 1)]
				public Double2(double @double, double double1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Double3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Double3", AccessFlags = 33)]
		public partial class Double3
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "D", AccessFlags = 1)]
				public double X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "D", AccessFlags = 1)]
				public double Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "D", AccessFlags = 1)]
				public double Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Double3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(DDD)V", AccessFlags = 1)]
				public Double3(double @double, double double1, double double2) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Double4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Double4", AccessFlags = 33)]
		public partial class Double4
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "D", AccessFlags = 1)]
				public double X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "D", AccessFlags = 1)]
				public double Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "D", AccessFlags = 1)]
				public double Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "D", AccessFlags = 1)]
				public double W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Double4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(DDDD)V", AccessFlags = 1)]
				public Double4(double @double, double double1, double double2, double double3) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Element
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Element", AccessFlags = 33)]
		public partial class Element : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Element() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isComplex
				/// </java-name>
				[Dot42.DexImport("isComplex", "()Z", AccessFlags = 1)]
				public virtual bool IsComplex() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element BOOLEAN(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8
				/// </java-name>
				[Dot42.DexImport("U8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8
				/// </java-name>
				[Dot42.DexImport("I8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16
				/// </java-name>
				[Dot42.DexImport("U16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16
				/// </java-name>
				[Dot42.DexImport("I16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32
				/// </java-name>
				[Dot42.DexImport("U32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32
				/// </java-name>
				[Dot42.DexImport("I32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64
				/// </java-name>
				[Dot42.DexImport("U64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64
				/// </java-name>
				[Dot42.DexImport("I64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32
				/// </java-name>
				[Dot42.DexImport("F32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64
				/// </java-name>
				[Dot42.DexImport("F64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// ELEMENT
				/// </java-name>
				[Dot42.DexImport("ELEMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element ELEMENT(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element TYPE(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// ALLOCATION
				/// </java-name>
				[Dot42.DexImport("ALLOCATION", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element ALLOCATION(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// SAMPLER
				/// </java-name>
				[Dot42.DexImport("SAMPLER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element SAMPLER(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// SCRIPT
				/// </java-name>
				[Dot42.DexImport("SCRIPT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element SCRIPT(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MESH
				/// </java-name>
				[Dot42.DexImport("MESH", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MESH(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_FRAGMENT
				/// </java-name>
				[Dot42.DexImport("PROGRAM_FRAGMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_FRAGMENT(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_VERTEX
				/// </java-name>
				[Dot42.DexImport("PROGRAM_VERTEX", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_VERTEX(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_RASTER
				/// </java-name>
				[Dot42.DexImport("PROGRAM_RASTER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_RASTER(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_STORE
				/// </java-name>
				[Dot42.DexImport("PROGRAM_STORE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_STORE(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// A_8
				/// </java-name>
				[Dot42.DexImport("A_8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element A_8(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGB_565(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGB_888
				/// </java-name>
				[Dot42.DexImport("RGB_888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGB_888(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_5551
				/// </java-name>
				[Dot42.DexImport("RGBA_5551", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_5551(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_4444
				/// </java-name>
				[Dot42.DexImport("RGBA_4444", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_4444(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_8888
				/// </java-name>
				[Dot42.DexImport("RGBA_8888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_8888(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_2
				/// </java-name>
				[Dot42.DexImport("F32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_3
				/// </java-name>
				[Dot42.DexImport("F32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_4
				/// </java-name>
				[Dot42.DexImport("F32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_2
				/// </java-name>
				[Dot42.DexImport("F64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_3
				/// </java-name>
				[Dot42.DexImport("F64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_4
				/// </java-name>
				[Dot42.DexImport("F64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_2
				/// </java-name>
				[Dot42.DexImport("U8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_3
				/// </java-name>
				[Dot42.DexImport("U8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_4
				/// </java-name>
				[Dot42.DexImport("U8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_2
				/// </java-name>
				[Dot42.DexImport("I8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_3
				/// </java-name>
				[Dot42.DexImport("I8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_4
				/// </java-name>
				[Dot42.DexImport("I8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_2
				/// </java-name>
				[Dot42.DexImport("U16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_3
				/// </java-name>
				[Dot42.DexImport("U16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_4
				/// </java-name>
				[Dot42.DexImport("U16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_2
				/// </java-name>
				[Dot42.DexImport("I16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_3
				/// </java-name>
				[Dot42.DexImport("I16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_4
				/// </java-name>
				[Dot42.DexImport("I16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_2
				/// </java-name>
				[Dot42.DexImport("U32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_3
				/// </java-name>
				[Dot42.DexImport("U32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_4
				/// </java-name>
				[Dot42.DexImport("U32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_2
				/// </java-name>
				[Dot42.DexImport("I32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_3
				/// </java-name>
				[Dot42.DexImport("I32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_4
				/// </java-name>
				[Dot42.DexImport("I32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_2
				/// </java-name>
				[Dot42.DexImport("U64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_3
				/// </java-name>
				[Dot42.DexImport("U64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_4
				/// </java-name>
				[Dot42.DexImport("U64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_2
				/// </java-name>
				[Dot42.DexImport("I64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_3
				/// </java-name>
				[Dot42.DexImport("I64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_4
				/// </java-name>
				[Dot42.DexImport("I64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX_4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_4X4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX4X4(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_3X3
				/// </java-name>
				[Dot42.DexImport("MATRIX_3X3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_3X3(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_2X2
				/// </java-name>
				[Dot42.DexImport("MATRIX_2X2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_2X2(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// createVector
				/// </java-name>
				[Dot42.DexImport("createVector", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;I)Land" +
    "roid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element CreateVector(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Element.DataType dataType, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// createPixel
				/// </java-name>
				[Dot42.DexImport("createPixel", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;Landro" +
    "id/renderscript/Element$DataKind;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element CreatePixel(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Element.DataType dataType, global::Android.Renderscript.Element.DataKind dataKind) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// isCompatible
				/// </java-name>
				[Dot42.DexImport("isCompatible", "(Landroid/renderscript/Element;)Z", AccessFlags = 1)]
				public virtual bool IsCompatible(global::Android.Renderscript.Element element) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// android/renderscript/Element$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Element$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;I)Landroid/renderscript/Element$" +
    "Builder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscript.Element element, string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;)Landroid/renderscript/Element$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscript.Element element, string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Element Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Element);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/Element$DataKind
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Element$DataKind", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Element$DataKind;>;")]
				public sealed class DataKind
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PIXEL_A
						/// </java-name>
						[Dot42.DexImport("PIXEL_A", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_A;
						/// <java-name>
						/// PIXEL_DEPTH
						/// </java-name>
						[Dot42.DexImport("PIXEL_DEPTH", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_DEPTH;
						/// <java-name>
						/// PIXEL_L
						/// </java-name>
						[Dot42.DexImport("PIXEL_L", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_L;
						/// <java-name>
						/// PIXEL_LA
						/// </java-name>
						[Dot42.DexImport("PIXEL_LA", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_LA;
						/// <java-name>
						/// PIXEL_RGB
						/// </java-name>
						[Dot42.DexImport("PIXEL_RGB", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_RGB;
						/// <java-name>
						/// PIXEL_RGBA
						/// </java-name>
						[Dot42.DexImport("PIXEL_RGBA", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_RGBA;
						/// <java-name>
						/// USER
						/// </java-name>
						[Dot42.DexImport("USER", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind USER;
						private DataKind() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Element$DataKind;", AccessFlags = 9)]
						public static DataKind[] Values() /* MethodBuilder.Create */ 
						{
								return default(DataKind[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Element$DataKind;", AccessFlags = 9)]
						public static DataKind ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(DataKind);
						}

				}

				/// <java-name>
				/// android/renderscript/Element$DataType
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Element$DataType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Element$DataType;>;")]
				public sealed class DataType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BOOLEAN
						/// </java-name>
						[Dot42.DexImport("BOOLEAN", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType BOOLEAN;
						/// <java-name>
						/// FLOAT_32
						/// </java-name>
						[Dot42.DexImport("FLOAT_32", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType FLOAT_32;
						/// <java-name>
						/// FLOAT_64
						/// </java-name>
						[Dot42.DexImport("FLOAT_64", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType FLOAT_64;
						/// <java-name>
						/// MATRIX_2X2
						/// </java-name>
						[Dot42.DexImport("MATRIX_2X2", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType MATRIX_2X2;
						/// <java-name>
						/// MATRIX_3X3
						/// </java-name>
						[Dot42.DexImport("MATRIX_3X3", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType MATRIX_3X3;
						/// <java-name>
						/// MATRIX_4X4
						/// </java-name>
						[Dot42.DexImport("MATRIX_4X4", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType MATRIX_4X4;
						/// <java-name>
						/// RS_ALLOCATION
						/// </java-name>
						[Dot42.DexImport("RS_ALLOCATION", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_ALLOCATION;
						/// <java-name>
						/// RS_ELEMENT
						/// </java-name>
						[Dot42.DexImport("RS_ELEMENT", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_ELEMENT;
						/// <java-name>
						/// RS_MESH
						/// </java-name>
						[Dot42.DexImport("RS_MESH", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_MESH;
						/// <java-name>
						/// RS_PROGRAM_FRAGMENT
						/// </java-name>
						[Dot42.DexImport("RS_PROGRAM_FRAGMENT", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_PROGRAM_FRAGMENT;
						/// <java-name>
						/// RS_PROGRAM_RASTER
						/// </java-name>
						[Dot42.DexImport("RS_PROGRAM_RASTER", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_PROGRAM_RASTER;
						/// <java-name>
						/// RS_PROGRAM_STORE
						/// </java-name>
						[Dot42.DexImport("RS_PROGRAM_STORE", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_PROGRAM_STORE;
						/// <java-name>
						/// RS_PROGRAM_VERTEX
						/// </java-name>
						[Dot42.DexImport("RS_PROGRAM_VERTEX", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_PROGRAM_VERTEX;
						/// <java-name>
						/// RS_SAMPLER
						/// </java-name>
						[Dot42.DexImport("RS_SAMPLER", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_SAMPLER;
						/// <java-name>
						/// RS_SCRIPT
						/// </java-name>
						[Dot42.DexImport("RS_SCRIPT", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_SCRIPT;
						/// <java-name>
						/// RS_TYPE
						/// </java-name>
						[Dot42.DexImport("RS_TYPE", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_TYPE;
						/// <java-name>
						/// SIGNED_16
						/// </java-name>
						[Dot42.DexImport("SIGNED_16", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType SIGNED_16;
						/// <java-name>
						/// SIGNED_32
						/// </java-name>
						[Dot42.DexImport("SIGNED_32", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType SIGNED_32;
						/// <java-name>
						/// SIGNED_64
						/// </java-name>
						[Dot42.DexImport("SIGNED_64", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType SIGNED_64;
						/// <java-name>
						/// SIGNED_8
						/// </java-name>
						[Dot42.DexImport("SIGNED_8", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType SIGNED_8;
						/// <java-name>
						/// UNSIGNED_16
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_16", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_16;
						/// <java-name>
						/// UNSIGNED_32
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_32", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_32;
						/// <java-name>
						/// UNSIGNED_4_4_4_4
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_4_4_4_4", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_4_4_4_4;
						/// <java-name>
						/// UNSIGNED_5_5_5_1
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_5_5_5_1", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_5_5_5_1;
						/// <java-name>
						/// UNSIGNED_5_6_5
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_5_6_5", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_5_6_5;
						/// <java-name>
						/// UNSIGNED_64
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_64", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_64;
						/// <java-name>
						/// UNSIGNED_8
						/// </java-name>
						[Dot42.DexImport("UNSIGNED_8", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType UNSIGNED_8;
						private DataType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Element$DataType;", AccessFlags = 9)]
						public static DataType[] Values() /* MethodBuilder.Create */ 
						{
								return default(DataType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Element$DataType;", AccessFlags = 9)]
						public static DataType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(DataType);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/FieldPacker
		/// </java-name>
		[Dot42.DexImport("android/renderscript/FieldPacker", AccessFlags = 33)]
		public partial class FieldPacker
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public FieldPacker(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// align
				/// </java-name>
				[Dot42.DexImport("align", "(I)V", AccessFlags = 1)]
				public virtual void Align(int int32) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(I)V", AccessFlags = 1)]
				public virtual void Reset(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(I)V", AccessFlags = 1)]
				public virtual void Skip(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(B)V", AccessFlags = 1)]
				public virtual void AddI8(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddI8(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(S)V", AccessFlags = 1)]
				public virtual void AddI16(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(I)V", AccessFlags = 1)]
				public virtual void AddI32(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(J)V", AccessFlags = 1)]
				public virtual void AddI64(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(S)V", AccessFlags = 1)]
				public virtual void AddU8(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(I)V", AccessFlags = 1)]
				public virtual void AddU16(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(J)V", AccessFlags = 1)]
				public virtual void AddU32(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(J)V", AccessFlags = 1)]
				public virtual void AddU64(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(F)V", AccessFlags = 1)]
				public virtual void AddF32(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(D)V", AccessFlags = 1)]
				public virtual void AddF64(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addObj
				/// </java-name>
				[Dot42.DexImport("addObj", "(Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void AddObj(global::Android.Renderscript.BaseObj baseObj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float2;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float2 float2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float3;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float3 float3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float4;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float4 float4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double2;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double2 double2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double3;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double3 double3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double4;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double4 double4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte2;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte2 byte2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte3;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte3 byte3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte4;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte4 byte4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short2 short2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short3 short3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short4 short4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short2 short2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short3 short3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short4 short4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int2 int2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int3 int3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int4 int4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int2 int2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int3 int3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int4 int4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long2 long2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long3 long3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long4 long4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long2 long2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long3 long3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long4 long4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long2 long2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long3 long3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long4 long4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix3f matrix3f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix2f matrix2f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addBoolean
				/// </java-name>
				[Dot42.DexImport("addBoolean", "(Z)V", AccessFlags = 1)]
				public virtual void AddBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FieldPacker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public byte[] Data
				{
				[Dot42.DexImport("getData", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return GetData(); }
				}

		}

		/// <java-name>
		/// android/renderscript/FileA3D
		/// </java-name>
		[Dot42.DexImport("android/renderscript/FileA3D", AccessFlags = 33)]
		public partial class FileA3D : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FileA3D() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIndexEntryCount
				/// </java-name>
				[Dot42.DexImport("getIndexEntryCount", "()I", AccessFlags = 1)]
				public virtual int GetIndexEntryCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndexEntry
				/// </java-name>
				[Dot42.DexImport("getIndexEntry", "(I)Landroid/renderscript/FileA3D$IndexEntry;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.FileA3D.IndexEntry GetIndexEntry(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.FileA3D.IndexEntry);
				}

				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/renderscript/RenderScript;Landroid/content/res/AssetManager;Ljava/lang/" +
    "String;)Landroid/renderscript/FileA3D;", AccessFlags = 9)]
				public static global::Android.Renderscript.FileA3D CreateFromAsset(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.AssetManager assetManager, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.FileA3D);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Ljava/lang/String;)Landroid/renderscript/File" +
    "A3D;", AccessFlags = 9)]
				public static global::Android.Renderscript.FileA3D CreateFromFile(global::Android.Renderscript.RenderScript renderScript, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.FileA3D);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Ljava/io/File;)Landroid/renderscript/FileA3D;" +
    "", AccessFlags = 9)]
				public static global::Android.Renderscript.FileA3D CreateFromFile(global::Android.Renderscript.RenderScript renderScript, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.FileA3D);
				}

				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)Landroid/ren" +
    "derscript/FileA3D;", AccessFlags = 9)]
				public static global::Android.Renderscript.FileA3D CreateFromResource(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.FileA3D);
				}

				/// <java-name>
				/// getIndexEntryCount
				/// </java-name>
				public int IndexEntryCount
				{
				[Dot42.DexImport("getIndexEntryCount", "()I", AccessFlags = 1)]
						get{ return GetIndexEntryCount(); }
				}

				/// <java-name>
				/// android/renderscript/FileA3D$IndexEntry
				/// </java-name>
				[Dot42.DexImport("android/renderscript/FileA3D$IndexEntry", AccessFlags = 9)]
				public partial class IndexEntry
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal IndexEntry() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getName
						/// </java-name>
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getEntryType
						/// </java-name>
						[Dot42.DexImport("getEntryType", "()Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.FileA3D.EntryType GetEntryType() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.FileA3D.EntryType);
						}

						/// <java-name>
						/// getObject
						/// </java-name>
						[Dot42.DexImport("getObject", "()Landroid/renderscript/BaseObj;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.BaseObj GetObject() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.BaseObj);
						}

						/// <java-name>
						/// getMesh
						/// </java-name>
						[Dot42.DexImport("getMesh", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Mesh GetMesh() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Mesh);
						}

						/// <java-name>
						/// getName
						/// </java-name>
						public string Name
						{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetName(); }
						}

						/// <java-name>
						/// getEntryType
						/// </java-name>
						public global::Android.Renderscript.FileA3D.EntryType EntryType
						{
						[Dot42.DexImport("getEntryType", "()Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 1)]
								get{ return GetEntryType(); }
						}

						/// <java-name>
						/// getObject
						/// </java-name>
						public global::Android.Renderscript.BaseObj Object
						{
						[Dot42.DexImport("getObject", "()Landroid/renderscript/BaseObj;", AccessFlags = 1)]
								get{ return GetObject(); }
						}

						/// <java-name>
						/// getMesh
						/// </java-name>
						public global::Android.Renderscript.Mesh Mesh
						{
						[Dot42.DexImport("getMesh", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
								get{ return GetMesh(); }
						}

				}

				/// <java-name>
				/// android/renderscript/FileA3D$EntryType
				/// </java-name>
				[Dot42.DexImport("android/renderscript/FileA3D$EntryType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/FileA3D$EntryType;>;")]
				public sealed class EntryType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MESH
						/// </java-name>
						[Dot42.DexImport("MESH", "Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 16409)]
						public static readonly EntryType MESH;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 16409)]
						public static readonly EntryType UNKNOWN;
						private EntryType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 9)]
						public static EntryType[] Values() /* MethodBuilder.Create */ 
						{
								return default(EntryType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 9)]
						public static EntryType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(EntryType);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/Float2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Float2", AccessFlags = 33)]
		public partial class Float2
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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Float2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public Float2(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Float3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Float3", AccessFlags = 33)]
		public partial class Float3
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
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "F", AccessFlags = 1)]
				public float Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Float3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFF)V", AccessFlags = 1)]
				public Float3(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Float4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Float4", AccessFlags = 33)]
		public partial class Float4
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
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "F", AccessFlags = 1)]
				public float Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "F", AccessFlags = 1)]
				public float W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Float4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public Float4(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Font
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Font", AccessFlags = 33)]
		public partial class Font : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Font() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/lang/Str" +
    "ing;F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscript.Font CreateFromFile(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Font);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/io/File;" +
    "F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscript.Font CreateFromFile(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, global::Java.Io.File file, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Font);
				}

				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/lang/Str" +
    "ing;F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscript.Font CreateFromAsset(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Font);
				}

				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;IF)Landroid/re" +
    "nderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscript.Font CreateFromResource(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, int int32, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Font);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/lang/Str" +
    "ing;Landroid/renderscript/Font$Style;F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscript.Font Create(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, string @string, global::Android.Renderscript.Font.Style style, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Font);
				}

				/// <java-name>
				/// android/renderscript/Font$Style
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Font$Style", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Font$Style;>;")]
				public sealed class Style
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BOLD
						/// </java-name>
						[Dot42.DexImport("BOLD", "Landroid/renderscript/Font$Style;", AccessFlags = 16409)]
						public static readonly Style BOLD;
						/// <java-name>
						/// BOLD_ITALIC
						/// </java-name>
						[Dot42.DexImport("BOLD_ITALIC", "Landroid/renderscript/Font$Style;", AccessFlags = 16409)]
						public static readonly Style BOLD_ITALIC;
						/// <java-name>
						/// ITALIC
						/// </java-name>
						[Dot42.DexImport("ITALIC", "Landroid/renderscript/Font$Style;", AccessFlags = 16409)]
						public static readonly Style ITALIC;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/renderscript/Font$Style;", AccessFlags = 16409)]
						public static readonly Style NORMAL;
						private Style() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Font$Style;", AccessFlags = 9)]
						public static Style[] Values() /* MethodBuilder.Create */ 
						{
								return default(Style[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Font$Style;", AccessFlags = 9)]
						public static Style ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Style);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/Int2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Int2", AccessFlags = 33)]
		public partial class Int2
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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Int2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Int2(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Int3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Int3", AccessFlags = 33)]
		public partial class Int3
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
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "I", AccessFlags = 1)]
				public int Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Int3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Int3(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Int4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Int4", AccessFlags = 33)]
		public partial class Int4
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
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "I", AccessFlags = 1)]
				public int Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "I", AccessFlags = 1)]
				public int W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Int4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
				public Int4(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Long2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Long2", AccessFlags = 33)]
		public partial class Long2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "J", AccessFlags = 1)]
				public long X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "J", AccessFlags = 1)]
				public long Y;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Long2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJ)V", AccessFlags = 1)]
				public Long2(long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Long3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Long3", AccessFlags = 33)]
		public partial class Long3
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "J", AccessFlags = 1)]
				public long X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "J", AccessFlags = 1)]
				public long Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "J", AccessFlags = 1)]
				public long Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Long3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJJ)V", AccessFlags = 1)]
				public Long3(long int64, long int641, long int642) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Long4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Long4", AccessFlags = 33)]
		public partial class Long4
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "J", AccessFlags = 1)]
				public long X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "J", AccessFlags = 1)]
				public long Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "J", AccessFlags = 1)]
				public long Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "J", AccessFlags = 1)]
				public long W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Long4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJJJ)V", AccessFlags = 1)]
				public Long4(long int64, long int641, long int642, long int643) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Matrix2f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix2f", AccessFlags = 33)]
		public partial class Matrix2f
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix2f() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix2f(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix2f matrix2f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix2f;Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix2f matrix2f, global::Android.Renderscript.Matrix2f matrix2f1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix2f matrix2f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <java-name>
		/// android/renderscript/Matrix3f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix3f", AccessFlags = 33)]
		public partial class Matrix3f
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix3f() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix3f(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix3f matrix3f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix3f;Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix3f matrix3f, global::Android.Renderscript.Matrix3f matrix3f1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix3f matrix3f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FF)V", AccessFlags = 1)]
				public virtual void Translate(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <java-name>
		/// android/renderscript/Matrix4f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix4f", AccessFlags = 33)]
		public partial class Matrix4f
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix4f() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix4f(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix4f;Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix4f matrix4f, global::Android.Renderscript.Matrix4f matrix4f1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadOrtho
				/// </java-name>
				[Dot42.DexImport("loadOrtho", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadOrtho(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadOrthoWindow
				/// </java-name>
				[Dot42.DexImport("loadOrthoWindow", "(II)V", AccessFlags = 1)]
				public virtual void LoadOrthoWindow(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadFrustum
				/// </java-name>
				[Dot42.DexImport("loadFrustum", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadFrustum(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadPerspective
				/// </java-name>
				[Dot42.DexImport("loadPerspective", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadPerspective(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadProjectionNormalized
				/// </java-name>
				[Dot42.DexImport("loadProjectionNormalized", "(II)V", AccessFlags = 1)]
				public virtual void LoadProjectionNormalized(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FFF)V", AccessFlags = 1)]
				public virtual void Translate(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inverse
				/// </java-name>
				[Dot42.DexImport("inverse", "()Z", AccessFlags = 1)]
				public virtual bool Inverse() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inverseTranspose
				/// </java-name>
				[Dot42.DexImport("inverseTranspose", "()Z", AccessFlags = 1)]
				public virtual bool InverseTranspose() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <java-name>
		/// android/renderscript/Mesh
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Mesh", AccessFlags = 33)]
		public partial class Mesh : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Mesh() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVertexAllocationCount
				/// </java-name>
				[Dot42.DexImport("getVertexAllocationCount", "()I", AccessFlags = 1)]
				public virtual int GetVertexAllocationCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVertexAllocation
				/// </java-name>
				[Dot42.DexImport("getVertexAllocation", "(I)Landroid/renderscript/Allocation;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Allocation GetVertexAllocation(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// getPrimitiveCount
				/// </java-name>
				[Dot42.DexImport("getPrimitiveCount", "()I", AccessFlags = 1)]
				public virtual int GetPrimitiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndexSetAllocation
				/// </java-name>
				[Dot42.DexImport("getIndexSetAllocation", "(I)Landroid/renderscript/Allocation;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Allocation GetIndexSetAllocation(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <java-name>
				/// getPrimitive
				/// </java-name>
				[Dot42.DexImport("getPrimitive", "(I)Landroid/renderscript/Mesh$Primitive;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Mesh.Primitive GetPrimitive(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Mesh.Primitive);
				}

				/// <java-name>
				/// getVertexAllocationCount
				/// </java-name>
				public int VertexAllocationCount
				{
				[Dot42.DexImport("getVertexAllocationCount", "()I", AccessFlags = 1)]
						get{ return GetVertexAllocationCount(); }
				}

				/// <java-name>
				/// getPrimitiveCount
				/// </java-name>
				public int PrimitiveCount
				{
				[Dot42.DexImport("getPrimitiveCount", "()I", AccessFlags = 1)]
						get{ return GetPrimitiveCount(); }
				}

				/// <java-name>
				/// android/renderscript/Mesh$TriangleMeshBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$TriangleMeshBuilder", AccessFlags = 9)]
				public partial class TriangleMeshBuilder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// COLOR
						/// </java-name>
						[Dot42.DexImport("COLOR", "I", AccessFlags = 25)]
						public const int COLOR = 1;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "I", AccessFlags = 25)]
						public const int NORMAL = 2;
						/// <java-name>
						/// TEXTURE_0
						/// </java-name>
						[Dot42.DexImport("TEXTURE_0", "I", AccessFlags = 25)]
						public const int TEXTURE_0 = 256;
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;II)V", AccessFlags = 1)]
						public TriangleMeshBuilder(global::Android.Renderscript.RenderScript renderScript, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addVertex
						/// </java-name>
						[Dot42.DexImport("addVertex", "(FF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddVertex(float single, float single1) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// addVertex
						/// </java-name>
						[Dot42.DexImport("addVertex", "(FFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddVertex(float single, float single1, float single2) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(FF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetTexture(float single, float single1) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// setNormal
						/// </java-name>
						[Dot42.DexImport("setNormal", "(FFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetNormal(float single, float single1, float single2) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// setColor
						/// </java-name>
						[Dot42.DexImport("setColor", "(FFFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetColor(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// addTriangle
						/// </java-name>
						[Dot42.DexImport("addTriangle", "(III)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddTriangle(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "(Z)Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Mesh Create(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal TriangleMeshBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/Mesh$AllocationBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$AllocationBuilder", AccessFlags = 9)]
				public partial class AllocationBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public AllocationBuilder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentVertexTypeIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentIndexSetIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// addVertexAllocation
						/// </java-name>
						[Dot42.DexImport("addVertexAllocation", "(Landroid/renderscript/Allocation;)Landroid/renderscript/Mesh$AllocationBuilder;", AccessFlags = 1)]
						public virtual AllocationBuilder AddVertexAllocation(global::Android.Renderscript.Allocation allocation) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <java-name>
						/// addIndexSetAllocation
						/// </java-name>
						[Dot42.DexImport("addIndexSetAllocation", "(Landroid/renderscript/Allocation;Landroid/renderscript/Mesh$Primitive;)Landroid/" +
    "renderscript/Mesh$AllocationBuilder;", AccessFlags = 1)]
						public virtual AllocationBuilder AddIndexSetAllocation(global::Android.Renderscript.Allocation allocation, global::Android.Renderscript.Mesh.Primitive primitive) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Mesh$Primitive;)Landroid/renderscript/Mesh$AllocationBuild" +
    "er;", AccessFlags = 1)]
						public virtual AllocationBuilder AddIndexSetType(global::Android.Renderscript.Mesh.Primitive primitive) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Mesh Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AllocationBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						public int CurrentVertexTypeIndex
						{
						[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentVertexTypeIndex(); }
						}

						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						public int CurrentIndexSetIndex
						{
						[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentIndexSetIndex(); }
						}

				}

				/// <java-name>
				/// android/renderscript/Mesh$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;I)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentVertexTypeIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentIndexSetIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// addVertexType
						/// </java-name>
						[Dot42.DexImport("addVertexType", "(Landroid/renderscript/Type;)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddVertexType(global::Android.Renderscript.Type type) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addVertexType
						/// </java-name>
						[Dot42.DexImport("addVertexType", "(Landroid/renderscript/Element;I)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddVertexType(global::Android.Renderscript.Element element, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Type;Landroid/renderscript/Mesh$Primitive;)Landroid/render" +
    "script/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscript.Type type, global::Android.Renderscript.Mesh.Primitive primitive) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Mesh$Primitive;)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscript.Mesh.Primitive primitive) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Element;ILandroid/renderscript/Mesh$Primitive;)Landroid/re" +
    "nderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscript.Element element, int int32, global::Android.Renderscript.Mesh.Primitive primitive) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Mesh Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						public int CurrentVertexTypeIndex
						{
						[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentVertexTypeIndex(); }
						}

						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						public int CurrentIndexSetIndex
						{
						[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentIndexSetIndex(); }
						}

				}

				/// <java-name>
				/// android/renderscript/Mesh$Primitive
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$Primitive", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Mesh$Primitive;>;")]
				public sealed class Primitive
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LINE
						/// </java-name>
						[Dot42.DexImport("LINE", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive LINE;
						/// <java-name>
						/// LINE_STRIP
						/// </java-name>
						[Dot42.DexImport("LINE_STRIP", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive LINE_STRIP;
						/// <java-name>
						/// POINT
						/// </java-name>
						[Dot42.DexImport("POINT", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive POINT;
						/// <java-name>
						/// TRIANGLE
						/// </java-name>
						[Dot42.DexImport("TRIANGLE", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive TRIANGLE;
						/// <java-name>
						/// TRIANGLE_FAN
						/// </java-name>
						[Dot42.DexImport("TRIANGLE_FAN", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive TRIANGLE_FAN;
						/// <java-name>
						/// TRIANGLE_STRIP
						/// </java-name>
						[Dot42.DexImport("TRIANGLE_STRIP", "Landroid/renderscript/Mesh$Primitive;", AccessFlags = 16409)]
						public static readonly Primitive TRIANGLE_STRIP;
						private Primitive() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Mesh$Primitive;", AccessFlags = 9)]
						public static Primitive[] Values() /* MethodBuilder.Create */ 
						{
								return default(Primitive[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Mesh$Primitive;", AccessFlags = 9)]
						public static Primitive ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Primitive);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/Program
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Program", AccessFlags = 33)]
		public partial class Program : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Program() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindConstants
				/// </java-name>
				[Dot42.DexImport("bindConstants", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindConstants(global::Android.Renderscript.Allocation allocation, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindTexture
				/// </java-name>
				[Dot42.DexImport("bindTexture", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindTexture(global::Android.Renderscript.Allocation allocation, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindSampler
				/// </java-name>
				[Dot42.DexImport("bindSampler", "(Landroid/renderscript/Sampler;I)V", AccessFlags = 1)]
				public virtual void BindSampler(global::Android.Renderscript.Sampler sampler, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/Program$BaseProgramBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Program$BaseProgramBuilder", AccessFlags = 9)]
				public partial class BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 4)]
						protected internal BaseProgramBuilder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setShader
						/// </java-name>
						[Dot42.DexImport("setShader", "(Ljava/lang/String;)Landroid/renderscript/Program$BaseProgramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder SetShader(string @string) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <java-name>
						/// setShader
						/// </java-name>
						[Dot42.DexImport("setShader", "(Landroid/content/res/Resources;I)Landroid/renderscript/Program$BaseProgramBuilde" +
    "r;", AccessFlags = 1)]
						public virtual BaseProgramBuilder SetShader(global::Android.Content.Res.Resources resources, int int32) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <java-name>
						/// getCurrentConstantIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentConstantIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentConstantIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getCurrentTextureIndex
						/// </java-name>
						[Dot42.DexImport("getCurrentTextureIndex", "()I", AccessFlags = 1)]
						public virtual int GetCurrentTextureIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// addConstant
						/// </java-name>
						[Dot42.DexImport("addConstant", "(Landroid/renderscript/Type;)Landroid/renderscript/Program$BaseProgramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder AddConstant(global::Android.Renderscript.Type type) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <java-name>
						/// addTexture
						/// </java-name>
						[Dot42.DexImport("addTexture", "(Landroid/renderscript/Program$TextureType;)Landroid/renderscript/Program$BasePro" +
    "gramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder AddTexture(global::Android.Renderscript.Program.TextureType textureType) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <java-name>
						/// initProgram
						/// </java-name>
						[Dot42.DexImport("initProgram", "(Landroid/renderscript/Program;)V", AccessFlags = 4)]
						protected internal virtual void InitProgram(global::Android.Renderscript.Program program) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal BaseProgramBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCurrentConstantIndex
						/// </java-name>
						public int CurrentConstantIndex
						{
						[Dot42.DexImport("getCurrentConstantIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentConstantIndex(); }
						}

						/// <java-name>
						/// getCurrentTextureIndex
						/// </java-name>
						public int CurrentTextureIndex
						{
						[Dot42.DexImport("getCurrentTextureIndex", "()I", AccessFlags = 1)]
								get{ return GetCurrentTextureIndex(); }
						}

				}

				/// <java-name>
				/// android/renderscript/Program$TextureType
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Program$TextureType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Program$TextureType;>;")]
				public sealed class TextureType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// TEXTURE_2D
						/// </java-name>
						[Dot42.DexImport("TEXTURE_2D", "Landroid/renderscript/Program$TextureType;", AccessFlags = 16409)]
						public static readonly TextureType TEXTURE_2D;
						/// <java-name>
						/// TEXTURE_CUBE
						/// </java-name>
						[Dot42.DexImport("TEXTURE_CUBE", "Landroid/renderscript/Program$TextureType;", AccessFlags = 16409)]
						public static readonly TextureType TEXTURE_CUBE;
						private TextureType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Program$TextureType;", AccessFlags = 9)]
						public static TextureType[] Values() /* MethodBuilder.Create */ 
						{
								return default(TextureType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Program$TextureType;", AccessFlags = 9)]
						public static TextureType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(TextureType);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramFragment
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramFragment", AccessFlags = 33)]
		public partial class ProgramFragment : global::Android.Renderscript.Program
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/ProgramFragment$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramFragment$Builder", AccessFlags = 9)]
				public partial class Builder : global::Android.Renderscript.Program.BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramFragment;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramFragment Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramFragment);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramFragmentFixedFunction
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction", AccessFlags = 33)]
		public partial class ProgramFragmentFixedFunction : global::Android.Renderscript.ProgramFragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramFragmentFixedFunction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/ProgramFragmentFixedFunction$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MAX_TEXTURE
						/// </java-name>
						[Dot42.DexImport("MAX_TEXTURE", "I", AccessFlags = 25)]
						public const int MAX_TEXTURE = 2;
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;Landroid/rend" +
    "erscript/ProgramFragmentFixedFunction$Builder$Format;I)Landroid/renderscript/Pro" +
    "gramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetTexture(Builder.EnvMode envMode, Builder.Format format, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setPointSpriteTexCoordinateReplacement
						/// </java-name>
						[Dot42.DexImport("setPointSpriteTexCoordinateReplacement", "(Z)Landroid/renderscript/ProgramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetPointSpriteTexCoordinateReplacement(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setVaryingColor
						/// </java-name>
						[Dot42.DexImport("setVaryingColor", "(Z)Landroid/renderscript/ProgramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetVaryingColor(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramFragmentFixedFunction;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramFragmentFixedFunction Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramFragmentFixedFunction);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// android/renderscript/ProgramFragmentFixedFunction$Builder$Format
						/// </java-name>
						[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction$Builder$Format", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format" +
    ";>;")]
						public sealed class Format
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// ALPHA
								/// </java-name>
								[Dot42.DexImport("ALPHA", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format;", AccessFlags = 16409)]
								public static readonly Format ALPHA;
								/// <java-name>
								/// LUMINANCE_ALPHA
								/// </java-name>
								[Dot42.DexImport("LUMINANCE_ALPHA", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format;", AccessFlags = 16409)]
								public static readonly Format LUMINANCE_ALPHA;
								/// <java-name>
								/// RGB
								/// </java-name>
								[Dot42.DexImport("RGB", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format;", AccessFlags = 16409)]
								public static readonly Format RGB;
								/// <java-name>
								/// RGBA
								/// </java-name>
								[Dot42.DexImport("RGBA", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format;", AccessFlags = 16409)]
								public static readonly Format RGBA;
								private Format() /* TypeBuilder.AddPrivateDefaultCtor */ 
								{
								}

								/// <java-name>
								/// values
								/// </java-name>
								[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Format;", AccessFlags = 9)]
								public static Format[] Values() /* MethodBuilder.Create */ 
								{
										return default(Format[]);
								}

								/// <java-name>
								/// valueOf
								/// </java-name>
								[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramFragmentFixedFunction$Builder$Fo" +
    "rmat;", AccessFlags = 9)]
								public static Format ValueOf(string @string) /* MethodBuilder.Create */ 
								{
										return default(Format);
								}

						}

						/// <java-name>
						/// android/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode
						/// </java-name>
						[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMod" +
    "e;>;")]
						public sealed class EnvMode
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// DECAL
								/// </java-name>
								[Dot42.DexImport("DECAL", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;", AccessFlags = 16409)]
								public static readonly EnvMode DECAL;
								/// <java-name>
								/// MODULATE
								/// </java-name>
								[Dot42.DexImport("MODULATE", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;", AccessFlags = 16409)]
								public static readonly EnvMode MODULATE;
								/// <java-name>
								/// REPLACE
								/// </java-name>
								[Dot42.DexImport("REPLACE", "Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;", AccessFlags = 16409)]
								public static readonly EnvMode REPLACE;
								private EnvMode() /* TypeBuilder.AddPrivateDefaultCtor */ 
								{
								}

								/// <java-name>
								/// values
								/// </java-name>
								[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;", AccessFlags = 9)]
								public static EnvMode[] Values() /* MethodBuilder.Create */ 
								{
										return default(EnvMode[]);
								}

								/// <java-name>
								/// valueOf
								/// </java-name>
								[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramFragmentFixedFunction$Builder$En" +
    "vMode;", AccessFlags = 9)]
								public static EnvMode ValueOf(string @string) /* MethodBuilder.Create */ 
								{
										return default(EnvMode);
								}

						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramRaster
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramRaster", AccessFlags = 33)]
		public partial class ProgramRaster : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramRaster() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// CULL_BACK
				/// </java-name>
				[Dot42.DexImport("CULL_BACK", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramRaster CULL_BACK(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramRaster);
				}

				/// <java-name>
				/// CULL_FRONT
				/// </java-name>
				[Dot42.DexImport("CULL_FRONT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramRaster CULL_FRONT(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramRaster);
				}

				/// <java-name>
				/// CULL_NONE
				/// </java-name>
				[Dot42.DexImport("CULL_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramRaster CULL_NONE(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramRaster);
				}

				/// <java-name>
				/// android/renderscript/ProgramRaster$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramRaster$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setPointSpriteEnabled
						/// </java-name>
						[Dot42.DexImport("setPointSpriteEnabled", "(Z)Landroid/renderscript/ProgramRaster$Builder;", AccessFlags = 1)]
						public virtual Builder SetPointSpriteEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setCullMode
						/// </java-name>
						[Dot42.DexImport("setCullMode", "(Landroid/renderscript/ProgramRaster$CullMode;)Landroid/renderscript/ProgramRaste" +
    "r$Builder;", AccessFlags = 1)]
						public virtual Builder SetCullMode(global::Android.Renderscript.ProgramRaster.CullMode cullMode) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramRaster;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramRaster Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramRaster);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/ProgramRaster$CullMode
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramRaster$CullMode", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramRaster$CullMode;>;")]
				public sealed class CullMode
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BACK
						/// </java-name>
						[Dot42.DexImport("BACK", "Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 16409)]
						public static readonly CullMode BACK;
						/// <java-name>
						/// FRONT
						/// </java-name>
						[Dot42.DexImport("FRONT", "Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 16409)]
						public static readonly CullMode FRONT;
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 16409)]
						public static readonly CullMode NONE;
						private CullMode() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 9)]
						public static CullMode[] Values() /* MethodBuilder.Create */ 
						{
								return default(CullMode[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 9)]
						public static CullMode ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(CullMode);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramStore
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramStore", AccessFlags = 33)]
		public partial class ProgramStore : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramStore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// BLEND_NONE_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("BLEND_NONE_DEPTH_TEST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramStore BLEND_NONE_DEPTH_TEST(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramStore);
				}

				/// <java-name>
				/// BLEND_NONE_DEPTH_NONE
				/// </java-name>
				[Dot42.DexImport("BLEND_NONE_DEPTH_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramStore BLEND_NONE_DEPTH_NONE(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramStore);
				}

				/// <java-name>
				/// BLEND_ALPHA_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("BLEND_ALPHA_DEPTH_TEST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramStore BLEND_ALPHA_DEPTH_TEST(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramStore);
				}

				/// <java-name>
				/// BLEND_ALPHA_DEPTH_NONE
				/// </java-name>
				[Dot42.DexImport("BLEND_ALPHA_DEPTH_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscript.ProgramStore BLEND_ALPHA_DEPTH_NONE(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ProgramStore);
				}

				/// <java-name>
				/// android/renderscript/ProgramStore$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramStore$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setDepthFunc
						/// </java-name>
						[Dot42.DexImport("setDepthFunc", "(Landroid/renderscript/ProgramStore$DepthFunc;)Landroid/renderscript/ProgramStore" +
    "$Builder;", AccessFlags = 1)]
						public virtual Builder SetDepthFunc(global::Android.Renderscript.ProgramStore.DepthFunc depthFunc) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDepthMaskEnabled
						/// </java-name>
						[Dot42.DexImport("setDepthMaskEnabled", "(Z)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetDepthMaskEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setColorMaskEnabled
						/// </java-name>
						[Dot42.DexImport("setColorMaskEnabled", "(ZZZZ)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetColorMaskEnabled(bool boolean, bool boolean1, bool boolean2, bool boolean3) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setBlendFunc
						/// </java-name>
						[Dot42.DexImport("setBlendFunc", "(Landroid/renderscript/ProgramStore$BlendSrcFunc;Landroid/renderscript/ProgramSto" +
    "re$BlendDstFunc;)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetBlendFunc(global::Android.Renderscript.ProgramStore.BlendSrcFunc blendSrcFunc, global::Android.Renderscript.ProgramStore.BlendDstFunc blendDstFunc) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDitherEnabled
						/// </java-name>
						[Dot42.DexImport("setDitherEnabled", "(Z)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetDitherEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramStore;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramStore Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramStore);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/ProgramStore$BlendDstFunc
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramStore$BlendDstFunc", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramStore$BlendDstFunc;>;")]
				public sealed class BlendDstFunc
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DST_ALPHA
						/// </java-name>
						[Dot42.DexImport("DST_ALPHA", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc DST_ALPHA;
						/// <java-name>
						/// ONE
						/// </java-name>
						[Dot42.DexImport("ONE", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc ONE;
						/// <java-name>
						/// ONE_MINUS_DST_ALPHA
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_DST_ALPHA", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc ONE_MINUS_DST_ALPHA;
						/// <java-name>
						/// ONE_MINUS_SRC_ALPHA
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_SRC_ALPHA", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc ONE_MINUS_SRC_ALPHA;
						/// <java-name>
						/// ONE_MINUS_SRC_COLOR
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_SRC_COLOR", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc ONE_MINUS_SRC_COLOR;
						/// <java-name>
						/// SRC_ALPHA
						/// </java-name>
						[Dot42.DexImport("SRC_ALPHA", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc SRC_ALPHA;
						/// <java-name>
						/// SRC_COLOR
						/// </java-name>
						[Dot42.DexImport("SRC_COLOR", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc SRC_COLOR;
						/// <java-name>
						/// ZERO
						/// </java-name>
						[Dot42.DexImport("ZERO", "Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 16409)]
						public static readonly BlendDstFunc ZERO;
						private BlendDstFunc() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 9)]
						public static BlendDstFunc[] Values() /* MethodBuilder.Create */ 
						{
								return default(BlendDstFunc[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 9)]
						public static BlendDstFunc ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(BlendDstFunc);
						}

				}

				/// <java-name>
				/// android/renderscript/ProgramStore$BlendSrcFunc
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramStore$BlendSrcFunc", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramStore$BlendSrcFunc;>;")]
				public sealed class BlendSrcFunc
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DST_ALPHA
						/// </java-name>
						[Dot42.DexImport("DST_ALPHA", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc DST_ALPHA;
						/// <java-name>
						/// DST_COLOR
						/// </java-name>
						[Dot42.DexImport("DST_COLOR", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc DST_COLOR;
						/// <java-name>
						/// ONE
						/// </java-name>
						[Dot42.DexImport("ONE", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc ONE;
						/// <java-name>
						/// ONE_MINUS_DST_ALPHA
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_DST_ALPHA", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc ONE_MINUS_DST_ALPHA;
						/// <java-name>
						/// ONE_MINUS_DST_COLOR
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_DST_COLOR", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc ONE_MINUS_DST_COLOR;
						/// <java-name>
						/// ONE_MINUS_SRC_ALPHA
						/// </java-name>
						[Dot42.DexImport("ONE_MINUS_SRC_ALPHA", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc ONE_MINUS_SRC_ALPHA;
						/// <java-name>
						/// SRC_ALPHA
						/// </java-name>
						[Dot42.DexImport("SRC_ALPHA", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc SRC_ALPHA;
						/// <java-name>
						/// SRC_ALPHA_SATURATE
						/// </java-name>
						[Dot42.DexImport("SRC_ALPHA_SATURATE", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc SRC_ALPHA_SATURATE;
						/// <java-name>
						/// ZERO
						/// </java-name>
						[Dot42.DexImport("ZERO", "Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 16409)]
						public static readonly BlendSrcFunc ZERO;
						private BlendSrcFunc() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 9)]
						public static BlendSrcFunc[] Values() /* MethodBuilder.Create */ 
						{
								return default(BlendSrcFunc[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 9)]
						public static BlendSrcFunc ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(BlendSrcFunc);
						}

				}

				/// <java-name>
				/// android/renderscript/ProgramStore$DepthFunc
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramStore$DepthFunc", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/ProgramStore$DepthFunc;>;")]
				public sealed class DepthFunc
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ALWAYS
						/// </java-name>
						[Dot42.DexImport("ALWAYS", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc ALWAYS;
						/// <java-name>
						/// EQUAL
						/// </java-name>
						[Dot42.DexImport("EQUAL", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc EQUAL;
						/// <java-name>
						/// GREATER
						/// </java-name>
						[Dot42.DexImport("GREATER", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc GREATER;
						/// <java-name>
						/// GREATER_OR_EQUAL
						/// </java-name>
						[Dot42.DexImport("GREATER_OR_EQUAL", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc GREATER_OR_EQUAL;
						/// <java-name>
						/// LESS
						/// </java-name>
						[Dot42.DexImport("LESS", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc LESS;
						/// <java-name>
						/// LESS_OR_EQUAL
						/// </java-name>
						[Dot42.DexImport("LESS_OR_EQUAL", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc LESS_OR_EQUAL;
						/// <java-name>
						/// NOT_EQUAL
						/// </java-name>
						[Dot42.DexImport("NOT_EQUAL", "Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 16409)]
						public static readonly DepthFunc NOT_EQUAL;
						private DepthFunc() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 9)]
						public static DepthFunc[] Values() /* MethodBuilder.Create */ 
						{
								return default(DepthFunc[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 9)]
						public static DepthFunc ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(DepthFunc);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramVertex
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramVertex", AccessFlags = 33)]
		public partial class ProgramVertex : global::Android.Renderscript.Program
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramVertex() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/ProgramVertex$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertex$Builder", AccessFlags = 9)]
				public partial class Builder : global::Android.Renderscript.Program.BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addInput
						/// </java-name>
						[Dot42.DexImport("addInput", "(Landroid/renderscript/Element;)Landroid/renderscript/ProgramVertex$Builder;", AccessFlags = 1)]
						public virtual Builder AddInput(global::Android.Renderscript.Element element) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramVertex;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramVertex Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramVertex);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ProgramVertexFixedFunction
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction", AccessFlags = 33)]
		public partial class ProgramVertexFixedFunction : global::Android.Renderscript.ProgramVertex
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramVertexFixedFunction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindConstants
				/// </java-name>
				[Dot42.DexImport("bindConstants", "(Landroid/renderscript/ProgramVertexFixedFunction$Constants;)V", AccessFlags = 1)]
				public virtual void BindConstants(global::Android.Renderscript.ProgramVertexFixedFunction.Constants constants) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/ProgramVertexFixedFunction$Constants
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction$Constants", AccessFlags = 9)]
				public partial class Constants
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Constants(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// destroy
						/// </java-name>
						[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
						public virtual void Destroy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setModelview
						/// </java-name>
						[Dot42.DexImport("setModelview", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetModelview(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setProjection
						/// </java-name>
						[Dot42.DexImport("setProjection", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetProjection(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetTexture(global::Android.Renderscript.Matrix4f matrix4f) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Constants() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/ProgramVertexFixedFunction$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setTextureMatrixEnable
						/// </java-name>
						[Dot42.DexImport("setTextureMatrixEnable", "(Z)Landroid/renderscript/ProgramVertexFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetTextureMatrixEnable(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramVertexFixedFunction;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.ProgramVertexFixedFunction Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ProgramVertexFixedFunction);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/RenderScript
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RenderScript", AccessFlags = 33)]
		public partial class RenderScript
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RenderScript() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMessageHandler
				/// </java-name>
				[Dot42.DexImport("setMessageHandler", "(Landroid/renderscript/RenderScript$RSMessageHandler;)V", AccessFlags = 1)]
				public virtual void SetMessageHandler(global::Android.Renderscript.RenderScript.RSMessageHandler rSMessageHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessageHandler
				/// </java-name>
				[Dot42.DexImport("getMessageHandler", "()Landroid/renderscript/RenderScript$RSMessageHandler;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScript.RSMessageHandler GetMessageHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScript.RSMessageHandler);
				}

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Landroid/renderscript/RenderScript$RSErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Android.Renderscript.RenderScript.RSErrorHandler rSErrorHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Landroid/renderscript/RenderScript$RSErrorHandler;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScript.RSErrorHandler GetErrorHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScript.RSErrorHandler);
				}

				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(Landroid/renderscript/RenderScript$Priority;)V", AccessFlags = 1)]
				public virtual void SetPriority(global::Android.Renderscript.RenderScript.Priority priority) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 17)]
				public global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;)Landroid/renderscript/RenderScript;", AccessFlags = 9)]
				public static global::Android.Renderscript.RenderScript Create(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScript);
				}

				/// <java-name>
				/// contextDump
				/// </java-name>
				[Dot42.DexImport("contextDump", "()V", AccessFlags = 1)]
				public virtual void ContextDump() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessageHandler
				/// </java-name>
				public global::Android.Renderscript.RenderScript.RSMessageHandler MessageHandler
				{
				[Dot42.DexImport("getMessageHandler", "()Landroid/renderscript/RenderScript$RSMessageHandler;", AccessFlags = 1)]
						get{ return GetMessageHandler(); }
				[Dot42.DexImport("setMessageHandler", "(Landroid/renderscript/RenderScript$RSMessageHandler;)V", AccessFlags = 1)]
						set{ SetMessageHandler(value); }
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Android.Renderscript.RenderScript.RSErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Landroid/renderscript/RenderScript$RSErrorHandler;", AccessFlags = 1)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Landroid/renderscript/RenderScript$RSErrorHandler;)V", AccessFlags = 1)]
						set{ SetErrorHandler(value); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return GetApplicationContext(); }
				}

				/// <java-name>
				/// android/renderscript/RenderScript$Priority
				/// </java-name>
				[Dot42.DexImport("android/renderscript/RenderScript$Priority", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/RenderScript$Priority;>;")]
				public sealed class Priority
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LOW
						/// </java-name>
						[Dot42.DexImport("LOW", "Landroid/renderscript/RenderScript$Priority;", AccessFlags = 16409)]
						public static readonly Priority LOW;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/renderscript/RenderScript$Priority;", AccessFlags = 16409)]
						public static readonly Priority NORMAL;
						private Priority() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/RenderScript$Priority;", AccessFlags = 9)]
						public static Priority[] Values() /* MethodBuilder.Create */ 
						{
								return default(Priority[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/RenderScript$Priority;", AccessFlags = 9)]
						public static Priority ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Priority);
						}

				}

				/// <java-name>
				/// android/renderscript/RenderScript$RSErrorHandler
				/// </java-name>
				[Dot42.DexImport("android/renderscript/RenderScript$RSErrorHandler", AccessFlags = 9)]
				public partial class RSErrorHandler : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mErrorMessage
						/// </java-name>
						[Dot42.DexImport("mErrorMessage", "Ljava/lang/String;", AccessFlags = 4)]
						protected internal string MErrorMessage;
						/// <java-name>
						/// mErrorNum
						/// </java-name>
						[Dot42.DexImport("mErrorNum", "I", AccessFlags = 4)]
						protected internal int MErrorNum;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RSErrorHandler() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// run
						/// </java-name>
						[Dot42.DexImport("run", "()V", AccessFlags = 1)]
						public virtual void Run() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/RenderScript$RSMessageHandler
				/// </java-name>
				[Dot42.DexImport("android/renderscript/RenderScript$RSMessageHandler", AccessFlags = 9)]
				public partial class RSMessageHandler : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mData
						/// </java-name>
						[Dot42.DexImport("mData", "[I", AccessFlags = 4)]
						protected internal int[] MData;
						/// <java-name>
						/// mID
						/// </java-name>
						[Dot42.DexImport("mID", "I", AccessFlags = 4)]
						protected internal int MID;
						/// <java-name>
						/// mLength
						/// </java-name>
						[Dot42.DexImport("mLength", "I", AccessFlags = 4)]
						protected internal int MLength;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RSMessageHandler() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// run
						/// </java-name>
						[Dot42.DexImport("run", "()V", AccessFlags = 1)]
						public virtual void Run() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/RenderScriptGL
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RenderScriptGL", AccessFlags = 33)]
		public partial class RenderScriptGL : global::Android.Renderscript.RenderScript
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/renderscript/RenderScriptGL$SurfaceConfig;)V", AccessFlags = 1)]
				public RenderScriptGL(global::Android.Content.Context context, global::Android.Renderscript.RenderScriptGL.SurfaceConfig surfaceConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSurface
				/// </java-name>
				[Dot42.DexImport("setSurface", "(Landroid/view/SurfaceHolder;II)V", AccessFlags = 1)]
				public virtual void SetSurface(global::Android.Views.ISurfaceHolder surfaceHolder, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSurfaceTexture
				/// </java-name>
				[Dot42.DexImport("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void SetSurfaceTexture(global::Android.Graphics.SurfaceTexture surfaceTexture, int int32, int int321) /* MethodBuilder.Create */ 
				{
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
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
				public virtual int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindRootScript
				/// </java-name>
				[Dot42.DexImport("bindRootScript", "(Landroid/renderscript/Script;)V", AccessFlags = 1)]
				public virtual void BindRootScript(global::Android.Renderscript.Script script) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindProgramStore
				/// </java-name>
				[Dot42.DexImport("bindProgramStore", "(Landroid/renderscript/ProgramStore;)V", AccessFlags = 1)]
				public virtual void BindProgramStore(global::Android.Renderscript.ProgramStore programStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindProgramFragment
				/// </java-name>
				[Dot42.DexImport("bindProgramFragment", "(Landroid/renderscript/ProgramFragment;)V", AccessFlags = 1)]
				public virtual void BindProgramFragment(global::Android.Renderscript.ProgramFragment programFragment) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindProgramRaster
				/// </java-name>
				[Dot42.DexImport("bindProgramRaster", "(Landroid/renderscript/ProgramRaster;)V", AccessFlags = 1)]
				public virtual void BindProgramRaster(global::Android.Renderscript.ProgramRaster programRaster) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindProgramVertex
				/// </java-name>
				[Dot42.DexImport("bindProgramVertex", "(Landroid/renderscript/ProgramVertex;)V", AccessFlags = 1)]
				public virtual void BindProgramVertex(global::Android.Renderscript.ProgramVertex programVertex) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RenderScriptGL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
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
				/// android/renderscript/RenderScriptGL$SurfaceConfig
				/// </java-name>
				[Dot42.DexImport("android/renderscript/RenderScriptGL$SurfaceConfig", AccessFlags = 9)]
				public partial class SurfaceConfig
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SurfaceConfig() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScriptGL$SurfaceConfig;)V", AccessFlags = 1)]
						public SurfaceConfig(SurfaceConfig surfaceConfig) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setColor
						/// </java-name>
						[Dot42.DexImport("setColor", "(II)V", AccessFlags = 1)]
						public virtual void SetColor(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setAlpha
						/// </java-name>
						[Dot42.DexImport("setAlpha", "(II)V", AccessFlags = 1)]
						public virtual void SetAlpha(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setDepth
						/// </java-name>
						[Dot42.DexImport("setDepth", "(II)V", AccessFlags = 1)]
						public virtual void SetDepth(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setSamples
						/// </java-name>
						[Dot42.DexImport("setSamples", "(IIF)V", AccessFlags = 1)]
						public virtual void SetSamples(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/RSDriverException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSDriverException", AccessFlags = 33)]
		public partial class RSDriverException : global::Android.Renderscript.RSRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RSDriverException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSDriverException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/RSIllegalArgumentException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSIllegalArgumentException", AccessFlags = 33)]
		public partial class RSIllegalArgumentException : global::Android.Renderscript.RSRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RSIllegalArgumentException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSIllegalArgumentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/RSInvalidStateException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSInvalidStateException", AccessFlags = 33)]
		public partial class RSInvalidStateException : global::Android.Renderscript.RSRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RSInvalidStateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSInvalidStateException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/RSRuntimeException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSRuntimeException", AccessFlags = 33)]
		public partial class RSRuntimeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RSRuntimeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSRuntimeException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/RSSurfaceView
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSSurfaceView", AccessFlags = 33)]
		public partial class RSSurfaceView : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RSSurfaceView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RSSurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceCreated(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceDestroyed(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
				public virtual void SurfaceChanged(global::Android.Views.ISurfaceHolder surfaceHolder, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("createRenderScriptGL", "(Landroid/renderscript/RenderScriptGL$SurfaceConfig;)Landroid/renderscript/Render" +
    "ScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScriptGL CreateRenderScriptGL(global::Android.Renderscript.RenderScriptGL.SurfaceConfig surfaceConfig) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScriptGL);
				}

				/// <java-name>
				/// destroyRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("destroyRenderScriptGL", "()V", AccessFlags = 1)]
				public virtual void DestroyRenderScriptGL() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
				public virtual void SetRenderScriptGL(global::Android.Renderscript.RenderScriptGL renderScriptGL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScriptGL GetRenderScriptGL() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScriptGL);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSSurfaceView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				public global::Android.Renderscript.RenderScriptGL RenderScriptGL
				{
				[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
						get{ return GetRenderScriptGL(); }
				[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
						set{ SetRenderScriptGL(value); }
				}

		}

		/// <java-name>
		/// android/renderscript/RSTextureView
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSTextureView", AccessFlags = 33)]
		public partial class RSTextureView : global::Android.Views.TextureView, global::Android.Views.TextureView.ISurfaceTextureListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RSTextureView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RSTextureView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSurfaceTextureAvailable
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureAvailable(global::Android.Graphics.SurfaceTexture surfaceTexture, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSurfaceTextureSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureSizeChanged(global::Android.Graphics.SurfaceTexture surfaceTexture, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSurfaceTextureDestroyed
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", AccessFlags = 1)]
				public virtual bool OnSurfaceTextureDestroyed(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSurfaceTextureUpdated
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureUpdated(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("createRenderScriptGL", "(Landroid/renderscript/RenderScriptGL$SurfaceConfig;)Landroid/renderscript/Render" +
    "ScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScriptGL CreateRenderScriptGL(global::Android.Renderscript.RenderScriptGL.SurfaceConfig surfaceConfig) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScriptGL);
				}

				/// <java-name>
				/// destroyRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("destroyRenderScriptGL", "()V", AccessFlags = 1)]
				public virtual void DestroyRenderScriptGL() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
				public virtual void SetRenderScriptGL(global::Android.Renderscript.RenderScriptGL renderScriptGL) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.RenderScriptGL GetRenderScriptGL() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScriptGL);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSTextureView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				public global::Android.Renderscript.RenderScriptGL RenderScriptGL
				{
				[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
						get{ return GetRenderScriptGL(); }
				[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
						set{ SetRenderScriptGL(value); }
				}

		}

		/// <java-name>
		/// android/renderscript/Sampler
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Sampler", AccessFlags = 33)]
		public partial class Sampler : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Sampler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// CLAMP_NEAREST
				/// </java-name>
				[Dot42.DexImport("CLAMP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_NEAREST(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// CLAMP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_LINEAR(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// CLAMP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_LINEAR_MIP_LINEAR(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// WRAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("WRAP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_NEAREST(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// WRAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_LINEAR(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// WRAP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_LINEAR_MIP_LINEAR(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <java-name>
				/// android/renderscript/Sampler$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Sampler$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMinification
						/// </java-name>
						[Dot42.DexImport("setMinification", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetMinification(global::Android.Renderscript.Sampler.Value value) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMagnification
						/// </java-name>
						[Dot42.DexImport("setMagnification", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetMagnification(global::Android.Renderscript.Sampler.Value value) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapS
						/// </java-name>
						[Dot42.DexImport("setWrapS", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapS(global::Android.Renderscript.Sampler.Value value) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapT
						/// </java-name>
						[Dot42.DexImport("setWrapT", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapT(global::Android.Renderscript.Sampler.Value value) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setAnisotropy
						/// </java-name>
						[Dot42.DexImport("setAnisotropy", "(F)V", AccessFlags = 1)]
						public virtual void SetAnisotropy(float single) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Sampler;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Sampler Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Sampler);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/Sampler$Value
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Sampler$Value", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Sampler$Value;>;")]
				public sealed class Value
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLAMP
						/// </java-name>
						[Dot42.DexImport("CLAMP", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value CLAMP;
						/// <java-name>
						/// LINEAR
						/// </java-name>
						[Dot42.DexImport("LINEAR", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value LINEAR;
						/// <java-name>
						/// LINEAR_MIP_LINEAR
						/// </java-name>
						[Dot42.DexImport("LINEAR_MIP_LINEAR", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value LINEAR_MIP_LINEAR;
						/// <java-name>
						/// LINEAR_MIP_NEAREST
						/// </java-name>
						[Dot42.DexImport("LINEAR_MIP_NEAREST", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value LINEAR_MIP_NEAREST;
						/// <java-name>
						/// NEAREST
						/// </java-name>
						[Dot42.DexImport("NEAREST", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value NEAREST;
						/// <java-name>
						/// WRAP
						/// </java-name>
						[Dot42.DexImport("WRAP", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value WRAP;
						private Value() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Sampler$Value;", AccessFlags = 9)]
						public static Value[] Values() /* MethodBuilder.Create */ 
						{
								return default(Value[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Sampler$Value;", AccessFlags = 9)]
						public static Value ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Value);
						}

				}

		}

		/// <java-name>
		/// android/renderscript/Script
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Script", AccessFlags = 33)]
		public partial class Script : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Script() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(I)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int int32, global::Android.Renderscript.FieldPacker fieldPacker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(ILandroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/rend" +
    "erscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void ForEach(int int32, global::Android.Renderscript.Allocation allocation, global::Android.Renderscript.Allocation allocation1, global::Android.Renderscript.FieldPacker fieldPacker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindAllocation
				/// </java-name>
				[Dot42.DexImport("bindAllocation", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindAllocation(global::Android.Renderscript.Allocation allocation, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IF)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ID)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(II)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IJ)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IZ)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, global::Android.Renderscript.BaseObj baseObj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetVar(int int32, global::Android.Renderscript.FieldPacker fieldPacker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/renderscript/Script$FieldBase
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$FieldBase", AccessFlags = 9)]
				public partial class FieldBase
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mElement
						/// </java-name>
						[Dot42.DexImport("mElement", "Landroid/renderscript/Element;", AccessFlags = 4)]
						protected internal global::Android.Renderscript.Element MElement;
						/// <java-name>
						/// mAllocation
						/// </java-name>
						[Dot42.DexImport("mAllocation", "Landroid/renderscript/Allocation;", AccessFlags = 4)]
						protected internal global::Android.Renderscript.Allocation MAllocation;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal FieldBase() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// init
						/// </java-name>
						[Dot42.DexImport("init", "(Landroid/renderscript/RenderScript;I)V", AccessFlags = 4)]
						protected internal virtual void Init(global::Android.Renderscript.RenderScript renderScript, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// init
						/// </java-name>
						[Dot42.DexImport("init", "(Landroid/renderscript/RenderScript;II)V", AccessFlags = 4)]
						protected internal virtual void Init(global::Android.Renderscript.RenderScript renderScript, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getElement
						/// </java-name>
						[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Element GetElement() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Element);
						}

						/// <java-name>
						/// getType
						/// </java-name>
						[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Type GetTypeJava() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Type);
						}

						/// <java-name>
						/// getAllocation
						/// </java-name>
						[Dot42.DexImport("getAllocation", "()Landroid/renderscript/Allocation;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Allocation GetAllocation() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Allocation);
						}

						/// <java-name>
						/// updateAllocation
						/// </java-name>
						[Dot42.DexImport("updateAllocation", "()V", AccessFlags = 1)]
						public virtual void UpdateAllocation() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getElement
						/// </java-name>
						public global::Android.Renderscript.Element Element
						{
						[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
								get{ return GetElement(); }
						}

						/// <java-name>
						/// getType
						/// </java-name>
						public global::Android.Renderscript.Type Type
						{
						[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
								get{ return GetTypeJava(); }
						}

						/// <java-name>
						/// getAllocation
						/// </java-name>
						public global::Android.Renderscript.Allocation Allocation
						{
						[Dot42.DexImport("getAllocation", "()Landroid/renderscript/Allocation;", AccessFlags = 1)]
								get{ return GetAllocation(); }
						}

				}

				/// <java-name>
				/// android/renderscript/Script$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Builder() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/renderscript/ScriptC
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptC", AccessFlags = 33)]
		public partial class ScriptC : global::Android.Renderscript.Script
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(ILandroid/renderscript/RenderScript;)V", AccessFlags = 4)]
				protected internal ScriptC(int int32, global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)V", AccessFlags = 4)]
				protected internal ScriptC(global::Android.Renderscript.RenderScript renderScript, global::Android.Content.Res.Resources resources, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScriptC() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Short2
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Short2", AccessFlags = 33)]
		public partial class Short2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "S", AccessFlags = 1)]
				public short X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "S", AccessFlags = 1)]
				public short Y;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Short2() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(SS)V", AccessFlags = 1)]
				public Short2(short int16, short int161) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Short3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Short3", AccessFlags = 33)]
		public partial class Short3
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "S", AccessFlags = 1)]
				public short X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "S", AccessFlags = 1)]
				public short Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "S", AccessFlags = 1)]
				public short Z;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Short3() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(SSS)V", AccessFlags = 1)]
				public Short3(short int16, short int161, short int162) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Short4
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Short4", AccessFlags = 33)]
		public partial class Short4
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "S", AccessFlags = 1)]
				public short X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "S", AccessFlags = 1)]
				public short Y;
				/// <java-name>
				/// z
				/// </java-name>
				[Dot42.DexImport("z", "S", AccessFlags = 1)]
				public short Z;
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "S", AccessFlags = 1)]
				public short W;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Short4() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(SSSS)V", AccessFlags = 1)]
				public Short4(short int16, short int161, short int162, short int163) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/renderscript/Type
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Type", AccessFlags = 33)]
		public partial class Type : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Type() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getElement
				/// </java-name>
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element GetElement() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()I", AccessFlags = 1)]
				public virtual int GetX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()I", AccessFlags = 1)]
				public virtual int GetY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getZ
				/// </java-name>
				[Dot42.DexImport("getZ", "()I", AccessFlags = 1)]
				public virtual int GetZ() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasMipmaps
				/// </java-name>
				[Dot42.DexImport("hasMipmaps", "()Z", AccessFlags = 1)]
				public virtual bool HasMipmaps() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasFaces
				/// </java-name>
				[Dot42.DexImport("hasFaces", "()Z", AccessFlags = 1)]
				public virtual bool HasFaces() /* MethodBuilder.Create */ 
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
				/// getElement
				/// </java-name>
				public global::Android.Renderscript.Element Element
				{
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						get{ return GetElement(); }
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public int X
				{
				[Dot42.DexImport("getX", "()I", AccessFlags = 1)]
						get{ return GetX(); }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public int Y
				{
				[Dot42.DexImport("getY", "()I", AccessFlags = 1)]
						get{ return GetY(); }
				}

				/// <java-name>
				/// getZ
				/// </java-name>
				public int Z
				{
				[Dot42.DexImport("getZ", "()I", AccessFlags = 1)]
						get{ return GetZ(); }
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
				/// android/renderscript/Type$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Type$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript, global::Android.Renderscript.Element element) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setX
						/// </java-name>
						[Dot42.DexImport("setX", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetX(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setY
						/// </java-name>
						[Dot42.DexImport("setY", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetY(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMipmaps
						/// </java-name>
						[Dot42.DexImport("setMipmaps", "(Z)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetMipmaps(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setFaces
						/// </java-name>
						[Dot42.DexImport("setFaces", "(Z)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetFaces(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						public virtual global::Android.Renderscript.Type Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.Type);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/renderscript/Type$CubemapFace
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Type$CubemapFace", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/Type$CubemapFace;>;")]
				public sealed class CubemapFace
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NEGATIVE_X
						/// </java-name>
						[Dot42.DexImport("NEGATIVE_X", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace NEGATIVE_X;
						/// <java-name>
						/// NEGATIVE_Y
						/// </java-name>
						[Dot42.DexImport("NEGATIVE_Y", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace NEGATIVE_Y;
						/// <java-name>
						/// NEGATIVE_Z
						/// </java-name>
						[Dot42.DexImport("NEGATIVE_Z", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace NEGATIVE_Z;
						/// <java-name>
						/// POSITIVE_X
						/// </java-name>
						[Dot42.DexImport("POSITIVE_X", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITIVE_X;
						/// <java-name>
						/// POSITIVE_Y
						/// </java-name>
						[Dot42.DexImport("POSITIVE_Y", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITIVE_Y;
						/// <java-name>
						/// POSITIVE_Z
						/// </java-name>
						[Dot42.DexImport("POSITIVE_Z", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITIVE_Z;
						/// <java-name>
						/// POSITVE_X
						/// </java-name>
						[Dot42.DexImport("POSITVE_X", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITVE_X;
						/// <java-name>
						/// POSITVE_Y
						/// </java-name>
						[Dot42.DexImport("POSITVE_Y", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITVE_Y;
						/// <java-name>
						/// POSITVE_Z
						/// </java-name>
						[Dot42.DexImport("POSITVE_Z", "Landroid/renderscript/Type$CubemapFace;", AccessFlags = 16409)]
						public static readonly CubemapFace POSITVE_Z;
						private CubemapFace() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/renderscript/Type$CubemapFace;", AccessFlags = 9)]
						public static CubemapFace[] Values() /* MethodBuilder.Create */ 
						{
								return default(CubemapFace[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/renderscript/Type$CubemapFace;", AccessFlags = 9)]
						public static CubemapFace ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(CubemapFace);
						}

				}

		}

}

