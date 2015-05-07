#pragma warning disable 1717
namespace Android.Renderscripts
{
		/// <summary>
		///  <para>This class provides the primary method through which data is passed to and from RenderScript kernels. An Allocation provides the backing store for a given android.renderscript.Type. </para> <para>An Allocation also contains a set of usage flags that denote how the Allocation could be used. For example, an Allocation may have usage flags specifying that it can be used from a script as well as input to a android.renderscript.Sampler. A developer must synchronize across these different usages using android.renderscript.Allocation#syncAll in order to ensure that different users of the Allocation have a consistent view of memory. For example, in the case where an Allocation is used as the output of one kernel and as Sampler input in a later kernel, a developer must call syncAll(Allocation.USAGE_SCRIPT) prior to launching the second kernel to ensure correctness.</para> <para>An Allocation can be populated with the copyFrom routines. For more complex Element types, the copyFromUnchecked methods can be used to copy from byte arrays or similar constructs.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Allocation
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Allocation", AccessFlags = 33)]
		public partial class Allocation : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The usage of the Allocation. These signal to RenderScript where to place the Allocation in memory. The Allocation will be bound to and accessed by scripts. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_SCRIPT
				/// </java-name>
				[Dot42.DexImport("USAGE_SCRIPT", "I", AccessFlags = 25)]
				public const int USAGE_SCRIPT = 1;
				/// <summary>
				///  <para>The Allocation will be used as a texture source by one or more graphics programs. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_TEXTURE
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_TEXTURE", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_TEXTURE = 2;
				/// <summary>
				///  <para>The Allocation will be used as a graphics mesh.</para> <para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_VERTEX
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_VERTEX", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_VERTEX = 4;
				/// <summary>
				///  <para>The Allocation will be used as the source of shader constants by one or more programs.</para> <para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_CONSTANTS
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_CONSTANTS", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_CONSTANTS = 8;
				/// <summary>
				///  <para>The Allocation will be used as a target for offscreen rendering</para> <para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_RENDER_TARGET
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_RENDER_TARGET", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_RENDER_TARGET = 16;
				/// <summary>
				///  <para>The Allocation will be used as a android.graphics.SurfaceTexture consumer. This usage will cause the Allocation to be created as read-only. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_IO_INPUT
				/// </java-name>
				[Dot42.DexImport("USAGE_IO_INPUT", "I", AccessFlags = 25)]
				public const int USAGE_IO_INPUT = 32;
				/// <summary>
				///  <para>The Allocation will be used as a android.graphics.SurfaceTexture producer. The dimensions and format of the android.graphics.SurfaceTexture will be forced to those of the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_IO_OUTPUT
				/// </java-name>
				[Dot42.DexImport("USAGE_IO_OUTPUT", "I", AccessFlags = 25)]
				public const int USAGE_IO_OUTPUT = 64;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Allocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Propagate changes from one usage of the Allocation to the other usages of the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// syncAll
				/// </java-name>
				[Dot42.DexImport("syncAll", "(I)V", AccessFlags = 1)]
				public virtual void SyncAll(int srcLocation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a buffer to the output stream. The contents of the Allocation will be undefined after this operation. This operation is only valid if USAGE_IO_OUTPUT is set on the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// ioSend
				/// </java-name>
				[Dot42.DexImport("ioSend", "()V", AccessFlags = 1)]
				public virtual void IoSend() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Receive the latest input into the Allocation. This operation is only valid if USAGE_IO_INPUT is set on the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// ioReceive
				/// </java-name>
				[Dot42.DexImport("ioReceive", "()V", AccessFlags = 1)]
				public virtual void IoReceive() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Renderscripts.BaseObj[] d) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([I)V", AccessFlags = 1)]
				public virtual void CopyFrom(int[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([S)V", AccessFlags = 1)]
				public virtual void CopyFrom(short[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1)]
				public virtual void CopyFrom(sbyte[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyFrom(byte[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([F)V", AccessFlags = 1)]
				public virtual void CopyFrom(float[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an array of RS objects to the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Graphics.Bitmap d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is only intended to be used by auto-generated code reflected from the RenderScript script files and should not be used by developers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int xoff, global::Android.Renderscripts.FieldPacker fp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is only intended to be used by auto-generated code reflected from the RenderScript script files.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(IILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int xoff, int component_number, global::Android.Renderscripts.FieldPacker fp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generate a mipmap chain. This is only valid if the Type of the Allocation includes mipmaps.</para> <para>This function will generate a complete set of mipmaps from the top level LOD and place them into the script memory space.</para> <para>If the Allocation is also using other memory spaces, a call to syncAll(Allocation.USAGE_SCRIPT) is required.</para>        
				/// </summary>
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

				/// <summary>
				///  <para>Copy part of an Allocation into this Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(IILandroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int off, int count, global::Android.Renderscripts.Allocation data, int dataOff) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Copy a rectangular region from an Allocation into a rectangular region in this Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIIILandroid/renderscript/Allocation;II)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int xoff, int yoff, int w, int h, global::Android.Renderscripts.Allocation data, int dataXoff, int dataYoff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy a android.graphics.Bitmap into an Allocation. The height and width of the update will use the height and width of the android.graphics.Bitmap.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IILandroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int xoff, int yoff, global::Android.Graphics.Bitmap data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyTo(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1)]
				public virtual void CopyTo(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyTo(byte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([S)V", AccessFlags = 1)]
				public virtual void CopyTo(short[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([I)V", AccessFlags = 1)]
				public virtual void CopyTo(int[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([F)V", AccessFlags = 1)]
				public virtual void CopyTo(float[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resize a 1D allocation. The contents of the allocation are preserved. If new elements are allocated objects are created with null contents and the new region is otherwise undefined.</para> <para>If the new region is smaller the references of any objects outside the new region will be released.</para> <para>A new type will be created with the new dimension.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>RenderScript objects should be immutable once created. The replacement is to create a new allocation and copy the contents. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(I)V", AccessFlags = 33)]
				public virtual void Resize(int dimX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new Allocation with the given android.renderscript.Type, mipmap flag, and usage flags.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;Landroid/renderscr" +
    "ipt/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateTyped(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Type type, global::Android.Renderscripts.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation with the size specified by the type and no mipmaps generated by default</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;I)Landroid/renders" +
    "cript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateTyped(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Type type, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation for use by scripts with a given android.renderscript.Type and no mipmaps</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;)Landroid/rendersc" +
    "ript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateTyped(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation with a specified number of given elements</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;II)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateSized(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e, int count, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation with a specified number of given elements</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;I)Landroid/rend" +
    "erscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateSized(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e, int count) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation from a android.graphics.Bitmap.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Allocation containing bitmap data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateFromBitmap(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap b, global::Android.Renderscripts.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation from a android.graphics.Bitmap.</para> <para>With target API version 18 or greater, this Allocation will be created with USAGE_SHARED, USAGE_SCRIPT, and USAGE_GRAPHICS_TEXTURE. With target API version 17 or lower, this Allocation will be created with USAGE_GRAPHICS_TEXTURE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Allocation containing bitmap data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateFromBitmap(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates a cubemap Allocation from a android.graphics.Bitmap containing the horizontal list of cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateCubemapFromBitmap(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap b, global::Android.Renderscripts.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates a non-mipmapped cubemap Allocation for use as a graphics texture from a android.graphics.Bitmap containing the horizontal list of cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateCubemapFromBitmap(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates a cubemap Allocation from 6 android.graphics.Bitmap objects containing the cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", @"(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/renderscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap xpos, global::Android.Graphics.Bitmap xneg, global::Android.Graphics.Bitmap ypos, global::Android.Graphics.Bitmap yneg, global::Android.Graphics.Bitmap zpos, global::Android.Graphics.Bitmap zneg, global::Android.Renderscripts.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates a non-mipmapped cubemap Allocation for use as a sampler input from 6 android.graphics.Bitmap objects containing the cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bi" +
    "tmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;" +
    "Landroid/graphics/Bitmap;)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscripts.RenderScript rs, global::Android.Graphics.Bitmap xpos, global::Android.Graphics.Bitmap xneg, global::Android.Graphics.Bitmap ypos, global::Android.Graphics.Bitmap yneg, global::Android.Graphics.Bitmap zpos, global::Android.Graphics.Bitmap zneg) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation from the Bitmap referenced by resource ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Allocation containing resource data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;ILandroid/rend" +
    "erscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateFromBitmapResource(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, int id, global::Android.Renderscripts.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates a non-mipmapped Allocation to use as a graphics texture from the android.graphics.Bitmap referenced by resource ID.</para> <para>With target API version 18 or greater, this allocation will be created with USAGE_SCRIPT and USAGE_GRAPHICS_TEXTURE. With target API version 17 or lower, this allocation will be created with USAGE_GRAPHICS_TEXTURE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Allocation containing resource data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateFromBitmapResource(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Creates an Allocation containing string data encoded in UTF-8 format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createFromString
				/// </java-name>
				[Dot42.DexImport("createFromString", "(Landroid/renderscript/RenderScript;Ljava/lang/String;I)Landroid/renderscript/All" +
    "ocation;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Allocation CreateFromString(global::Android.Renderscripts.RenderScript rs, string str, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para>Get the android.renderscript.Element of the android.renderscript.Type of the Allocation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				public virtual global::Android.Renderscripts.Element Element
				{
						[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Element); }
				}

				/// <summary>
				///  <para>Get the usage flags of the Allocation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>usage this Allocation's set of the USAGE_* flags OR'd together </para>
				/// </returns>
				/// <java-name>
				/// getUsage
				/// </java-name>
				public virtual int Usage
				{
						[Dot42.DexImport("getUsage", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the size of the Allocation in bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>size of the Allocation in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				public virtual int BytesSize
				{
						[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the android.renderscript.Type of the Allocation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual global::Android.Renderscripts.Type Type
				{
						[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Type); }
				}

				/// <summary>
				///  <para>Returns the handle to a raw buffer that is being managed by the screen compositor. This operation is only valid for Allocations with USAGE_IO_INPUT.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Surface object associated with allocation </para>
				/// </returns>
				/// <java-name>
				/// getSurface
				/// </java-name>
				public virtual global::Android.Views.Surface Surface
				{
						[Dot42.DexImport("getSurface", "()Landroid/view/Surface;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Surface); }
						[Dot42.DexImport("setSurface", "(Landroid/view/Surface;)V", AccessFlags = 1)]
						set{ }
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

		/// <summary>
		///  <para>Only intended for use by generated reflected code. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/AllocationAdapter
		/// </java-name>
		[Dot42.DexImport("android/renderscript/AllocationAdapter", AccessFlags = 33)]
		public partial class AllocationAdapter : global::Android.Renderscripts.Allocation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AllocationAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the active LOD. The LOD must be within the range for the type being adapted. The base allocation must have mipmaps.</para> <para>Because this changes the dimensions of the adapter the current Y and Z will be reset.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLOD
				/// </java-name>
				[Dot42.DexImport("setLOD", "(I)V", AccessFlags = 1)]
				public virtual void SetLOD(int lod) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the active Face. The base allocation must be of a type that includes faces.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFace
				/// </java-name>
				[Dot42.DexImport("setFace", "(Landroid/renderscript/Type$CubemapFace;)V", AccessFlags = 1)]
				public virtual void SetFace(global::Android.Renderscripts.Type.CubemapFace cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the active Y. The y value must be within the range for the allocation being adapted. The base allocation must contain the Y dimension.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setY
				/// </java-name>
				[Dot42.DexImport("setY", "(I)V", AccessFlags = 1)]
				public virtual void SetY(int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the active Z. The z value must be within the range for the allocation being adapted. The base allocation must contain the Z dimension.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setZ
				/// </java-name>
				[Dot42.DexImport("setZ", "(I)V", AccessFlags = 1)]
				public virtual void SetZ(int z) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// create1D
				/// </java-name>
				[Dot42.DexImport("create1D", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Allocation;)Landroid/re" +
    "nderscript/AllocationAdapter;", AccessFlags = 9)]
				public static global::Android.Renderscripts.AllocationAdapter Create1D(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Allocation a) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.AllocationAdapter);
				}

				/// <java-name>
				/// create2D
				/// </java-name>
				[Dot42.DexImport("create2D", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Allocation;)Landroid/re" +
    "nderscript/AllocationAdapter;", AccessFlags = 9)]
				public static global::Android.Renderscripts.AllocationAdapter Create2D(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Allocation a) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.AllocationAdapter);
				}

				/// <summary>
				///  <para>Override the Allocation resize. Resizing adapters is not allowed and will throw a RSInvalidStateException.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(I)V", AccessFlags = 33)]
				public override void Resize(int dimX) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>BaseObj is the base class for all RenderScript objects owned by a RS context. It is responsible for lifetime management and resource tracking. This class should not be used by a user application. </para>    
		/// </summary>
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~BaseObj() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Frees any native resources associated with this object. The primary use is to force immediate cleanup of resources when it is believed the GC will not respond quickly enough. </para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 33)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calculates the hash code value for a BaseObj.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compare the current BaseObj with another BaseObj for equality.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>name of the renderscript object </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript byte2 type back to the Android system. </para>    
		/// </summary>
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
				public Byte2(sbyte initX, sbyte initY) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte2(byte initX, byte initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript byte3 type back to the Android system. </para>    
		/// </summary>
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
				public Byte3(sbyte initX, sbyte initY, sbyte initZ) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte3(byte initX, byte initY, byte initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript byte4 type back to the Android system. </para>    
		/// </summary>
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
				public Byte4(sbyte initX, sbyte initY, sbyte initZ, sbyte initW) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(BBBB)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Byte4(byte initX, byte initY, byte initZ, byte initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript double2 type back to the Android system. </para>    
		/// </summary>
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
				public Double2(double initX, double initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript double3 type back to the Android system. </para>    
		/// </summary>
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
				public Double3(double initX, double initY, double initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript double4 type back to the Android system. </para>    
		/// </summary>
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
				public Double4(double initX, double initY, double initZ, double initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An Element represents one item within an android.renderscript.Allocation. An Element is roughly equivalent to a C type in a RenderScript kernel. Elements may be basic or complex. Some basic elements are</para> <para> <ul> <li> <para>A single float value (equivalent to a float in a kernel) </para></li> <li> <para>A four-element float vector (equivalent to a float4 in a kernel) </para></li> <li> <para>An unsigned 32-bit integer (equivalent to an unsigned int in a kernel) </para></li> <li> <para>A single signed 8-bit integer (equivalent to a char in a kernel) </para></li></ul></para> <para>A complex element is roughly equivalent to a C struct and contains a number of basic or complex Elements. From Java code, a complex element contains a list of sub-elements and names that represents a particular data structure. Structs used in RS scripts are available to Java code by using the <c>ScriptField_structname </c> class that is reflected from a particular script.</para> <para>Basic Elements are comprised of a android.renderscript.Element.DataType and a android.renderscript.Element.DataKind. The DataType encodes C type information of an Element, while the DataKind encodes how that Element should be interpreted by a android.renderscript.Sampler. Note that android.renderscript.Allocation objects with DataKind android.renderscript.Element.DataKind#USER cannot be used as input for a android.renderscript.Sampler. In general, android.renderscript.Allocation objects that are intended for use with a android.renderscript.Sampler should use bitmap-derived Elements such as android.renderscript.Element#RGBA_8888 or android.renderscript#Element.A_8.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Element
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Element", AccessFlags = 33)]
		public partial class Element : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Element() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For complex elements, this function will return the sub-element at index </para>        
				/// </summary>
				/// <returns>
				///  <para>sub-element in this element at given index </para>
				/// </returns>
				/// <java-name>
				/// getSubElement
				/// </java-name>
				[Dot42.DexImport("getSubElement", "(I)Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Element GetSubElement(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>For complex elements, this function will return the sub-element name at index </para>        
				/// </summary>
				/// <returns>
				///  <para>sub-element in this element at given index </para>
				/// </returns>
				/// <java-name>
				/// getSubElementName
				/// </java-name>
				[Dot42.DexImport("getSubElementName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubElementName(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>For complex elements, some sub-elements could be statically sized arrays. This function will return the array size for sub-element at index </para>        
				/// </summary>
				/// <returns>
				///  <para>array size of sub-element in this element at given index </para>
				/// </returns>
				/// <java-name>
				/// getSubElementArraySize
				/// </java-name>
				[Dot42.DexImport("getSubElementArraySize", "(I)I", AccessFlags = 1)]
				public virtual int GetSubElementArraySize(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>This function specifies the location of a sub-element within the element </para>        
				/// </summary>
				/// <returns>
				///  <para>offset in bytes of sub-element in this element at given index </para>
				/// </returns>
				/// <java-name>
				/// getSubElementOffsetBytes
				/// </java-name>
				[Dot42.DexImport("getSubElementOffsetBytes", "(I)I", AccessFlags = 1)]
				public virtual int GetSubElementOffsetBytes(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>element data type </para>
				/// </returns>
				/// <java-name>
				/// getDataType
				/// </java-name>
				[Dot42.DexImport("getDataType", "()Landroid/renderscript/Element$DataType;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Element.DataType GetDataType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element.DataType);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>element data kind </para>
				/// </returns>
				/// <java-name>
				/// getDataKind
				/// </java-name>
				[Dot42.DexImport("getDataKind", "()Landroid/renderscript/Element$DataKind;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Element.DataKind GetDataKind() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element.DataKind);
				}

				/// <summary>
				///  <para>Utility function for returning an Element containing a single Boolean.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element BOOLEAN(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>Utility function for returning an Element containing a single UNSIGNED_8.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// U8
				/// </java-name>
				[Dot42.DexImport("U8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U8(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>Utility function for returning an Element containing a single SIGNED_8.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// I8
				/// </java-name>
				[Dot42.DexImport("I8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I8(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U16
				/// </java-name>
				[Dot42.DexImport("U16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U16(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I16
				/// </java-name>
				[Dot42.DexImport("I16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I16(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U32
				/// </java-name>
				[Dot42.DexImport("U32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U32(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I32
				/// </java-name>
				[Dot42.DexImport("I32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I32(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U64
				/// </java-name>
				[Dot42.DexImport("U64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U64(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I64
				/// </java-name>
				[Dot42.DexImport("I64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I64(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F32
				/// </java-name>
				[Dot42.DexImport("F32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F32(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F64
				/// </java-name>
				[Dot42.DexImport("F64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F64(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// ELEMENT
				/// </java-name>
				[Dot42.DexImport("ELEMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element ELEMENT(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element TYPE(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// ALLOCATION
				/// </java-name>
				[Dot42.DexImport("ALLOCATION", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element ALLOCATION(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// SAMPLER
				/// </java-name>
				[Dot42.DexImport("SAMPLER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element SAMPLER(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// SCRIPT
				/// </java-name>
				[Dot42.DexImport("SCRIPT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element SCRIPT(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// MESH
				/// </java-name>
				[Dot42.DexImport("MESH", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element MESH(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// PROGRAM_FRAGMENT
				/// </java-name>
				[Dot42.DexImport("PROGRAM_FRAGMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element PROGRAM_FRAGMENT(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// PROGRAM_VERTEX
				/// </java-name>
				[Dot42.DexImport("PROGRAM_VERTEX", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element PROGRAM_VERTEX(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// PROGRAM_RASTER
				/// </java-name>
				[Dot42.DexImport("PROGRAM_RASTER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element PROGRAM_RASTER(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// PROGRAM_STORE
				/// </java-name>
				[Dot42.DexImport("PROGRAM_STORE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element PROGRAM_STORE(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// FONT
				/// </java-name>
				[Dot42.DexImport("FONT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element FONT(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// A_8
				/// </java-name>
				[Dot42.DexImport("A_8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element A_8(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element RGB_565(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// RGB_888
				/// </java-name>
				[Dot42.DexImport("RGB_888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element RGB_888(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// RGBA_5551
				/// </java-name>
				[Dot42.DexImport("RGBA_5551", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element RGBA_5551(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// RGBA_4444
				/// </java-name>
				[Dot42.DexImport("RGBA_4444", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element RGBA_4444(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// RGBA_8888
				/// </java-name>
				[Dot42.DexImport("RGBA_8888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element RGBA_8888(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F32_2
				/// </java-name>
				[Dot42.DexImport("F32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F32_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F32_3
				/// </java-name>
				[Dot42.DexImport("F32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F32_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F32_4
				/// </java-name>
				[Dot42.DexImport("F32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F32_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F64_2
				/// </java-name>
				[Dot42.DexImport("F64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F64_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F64_3
				/// </java-name>
				[Dot42.DexImport("F64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F64_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// F64_4
				/// </java-name>
				[Dot42.DexImport("F64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element F64_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U8_2
				/// </java-name>
				[Dot42.DexImport("U8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U8_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U8_3
				/// </java-name>
				[Dot42.DexImport("U8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U8_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U8_4
				/// </java-name>
				[Dot42.DexImport("U8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U8_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I8_2
				/// </java-name>
				[Dot42.DexImport("I8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I8_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I8_3
				/// </java-name>
				[Dot42.DexImport("I8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I8_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I8_4
				/// </java-name>
				[Dot42.DexImport("I8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I8_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U16_2
				/// </java-name>
				[Dot42.DexImport("U16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U16_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U16_3
				/// </java-name>
				[Dot42.DexImport("U16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U16_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U16_4
				/// </java-name>
				[Dot42.DexImport("U16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U16_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I16_2
				/// </java-name>
				[Dot42.DexImport("I16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I16_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I16_3
				/// </java-name>
				[Dot42.DexImport("I16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I16_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I16_4
				/// </java-name>
				[Dot42.DexImport("I16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I16_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U32_2
				/// </java-name>
				[Dot42.DexImport("U32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U32_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U32_3
				/// </java-name>
				[Dot42.DexImport("U32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U32_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U32_4
				/// </java-name>
				[Dot42.DexImport("U32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U32_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I32_2
				/// </java-name>
				[Dot42.DexImport("I32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I32_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I32_3
				/// </java-name>
				[Dot42.DexImport("I32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I32_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I32_4
				/// </java-name>
				[Dot42.DexImport("I32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I32_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U64_2
				/// </java-name>
				[Dot42.DexImport("U64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U64_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U64_3
				/// </java-name>
				[Dot42.DexImport("U64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U64_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// U64_4
				/// </java-name>
				[Dot42.DexImport("U64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element U64_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I64_2
				/// </java-name>
				[Dot42.DexImport("I64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I64_2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I64_3
				/// </java-name>
				[Dot42.DexImport("I64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I64_3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// I64_4
				/// </java-name>
				[Dot42.DexImport("I64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element I64_4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// MATRIX_4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX_4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element MATRIX_4X4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use MATRIX_4X4 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MATRIX4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element MATRIX4X4(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// MATRIX_3X3
				/// </java-name>
				[Dot42.DexImport("MATRIX_3X3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element MATRIX_3X3(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <java-name>
				/// MATRIX_2X2
				/// </java-name>
				[Dot42.DexImport("MATRIX_2X2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element MATRIX_2X2(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>Create a custom vector element of the specified DataType and vector size. DataKind will be set to USER. Only primitive types (FLOAT_32, FLOAT_64, SIGNED_8, SIGNED_16, SIGNED_32, SIGNED_64, UNSIGNED_8, UNSIGNED_16, UNSIGNED_32, UNSIGNED_64, BOOLEAN) are supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// createVector
				/// </java-name>
				[Dot42.DexImport("createVector", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;I)Land" +
    "roid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element CreateVector(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element.DataType dt, int size) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>Create a new pixel Element type. A matching DataType and DataKind must be provided. The DataType and DataKind must contain the same number of components. Vector size will be set to 1.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// createPixel
				/// </java-name>
				[Dot42.DexImport("createPixel", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;Landro" +
    "id/renderscript/Element$DataKind;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Element CreatePixel(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element.DataType dt, global::Android.Renderscripts.Element.DataKind dk) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para>Check if the current Element is compatible with another Element. Primitive Elements are compatible if they share the same underlying size and type (i.e. U8 is compatible with A_8). User-defined Elements must be equal in order to be compatible. This requires strict name equivalence for all sub-Elements (in addition to structural equivalence).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean true if the Elements are compatible, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isCompatible
				/// </java-name>
				[Dot42.DexImport("isCompatible", "(Landroid/renderscript/Element;)Z", AccessFlags = 1)]
				public virtual bool IsCompatible(global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>element size in bytes </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				public virtual int BytesSize
				{
						[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of vector components. 2 for float2, 4 for float4, etc. </para>        
				/// </summary>
				/// <returns>
				///  <para>element vector size </para>
				/// </returns>
				/// <java-name>
				/// getVectorSize
				/// </java-name>
				public virtual int VectorSize
				{
						[Dot42.DexImport("getVectorSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return if a element is too complex for use as a data source for a Mesh or a Program.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// isComplex
				/// </java-name>
				public virtual bool IsComplex
				{
						[Dot42.DexImport("isComplex", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Elements could be simple, such as an int or a float, or a structure with multiple sub elements, such as a collection of floats, float2, float4. This function returns zero for simple elements or the number of sub-elements otherwise. </para>        
				/// </summary>
				/// <returns>
				///  <para>number of sub-elements in this element </para>
				/// </returns>
				/// <java-name>
				/// getSubElementCount
				/// </java-name>
				public virtual int SubElementCount
				{
						[Dot42.DexImport("getSubElementCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Builder class for producing complex elements with matching field and name pairs. The builder starts empty. The order in which elements are added is retained for the layout in memory. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Element$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Element$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Add an array of elements to this element.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;I)Landroid/renderscript/Element$" +
    "Builder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscripts.Element element, string name, int arraySize) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add a single element to this Element.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;)Landroid/renderscript/Element$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscripts.Element element, string name) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Create the element from this builder.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Element </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Element Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Element);
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
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType NONE;
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
						/// RS_FONT
						/// </java-name>
						[Dot42.DexImport("RS_FONT", "Landroid/renderscript/Element$DataType;", AccessFlags = 16409)]
						public static readonly DataType RS_FONT;
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

		/// <summary>
		///  <para>Utility class for packing arguments and structures from Android system objects to RenderScript objects.</para> <para>This class is only intended to be used to support the reflected code generated by the RS tool chain. It should not be called directly. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/FieldPacker
		/// </java-name>
		[Dot42.DexImport("android/renderscript/FieldPacker", AccessFlags = 33)]
		public partial class FieldPacker
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public FieldPacker(int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// align
				/// </java-name>
				[Dot42.DexImport("align", "(I)V", AccessFlags = 1)]
				public virtual void Align(int v) /* MethodBuilder.Create */ 
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
				public virtual void Reset(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(I)V", AccessFlags = 1)]
				public virtual void Skip(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(B)V", AccessFlags = 1)]
				public virtual void AddI8(sbyte v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddI8(byte v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(S)V", AccessFlags = 1)]
				public virtual void AddI16(short v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(I)V", AccessFlags = 1)]
				public virtual void AddI32(int v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(J)V", AccessFlags = 1)]
				public virtual void AddI64(long v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(S)V", AccessFlags = 1)]
				public virtual void AddU8(short v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(I)V", AccessFlags = 1)]
				public virtual void AddU16(int v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(J)V", AccessFlags = 1)]
				public virtual void AddU32(long v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(J)V", AccessFlags = 1)]
				public virtual void AddU64(long v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(F)V", AccessFlags = 1)]
				public virtual void AddF32(float v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(D)V", AccessFlags = 1)]
				public virtual void AddF64(double v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addObj
				/// </java-name>
				[Dot42.DexImport("addObj", "(Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void AddObj(global::Android.Renderscripts.BaseObj obj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float2;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscripts.Float2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float3;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscripts.Float3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float4;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscripts.Float4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double2;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscripts.Double2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double3;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscripts.Double3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double4;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscripts.Double4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte2;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscripts.Byte2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte3;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscripts.Byte3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte4;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscripts.Byte4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscripts.Short2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscripts.Short3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscripts.Short4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscripts.Short2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscripts.Short3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscripts.Short4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscripts.Int2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscripts.Int3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscripts.Int4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscripts.Int2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscripts.Int3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscripts.Int4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscripts.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscripts.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscripts.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscripts.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscripts.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscripts.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscripts.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscripts.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscripts.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscripts.Matrix4f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscripts.Matrix3f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscripts.Matrix2f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addBoolean
				/// </java-name>
				[Dot42.DexImport("addBoolean", "(Z)V", AccessFlags = 1)]
				public virtual void AddBoolean(bool v) /* MethodBuilder.Create */ 
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
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 FileA3D allows users to load RenderScript objects from files or resources stored on disk. It could be used to load items such as 3D geometry data converted to a RenderScript format from content creation tools. Currently only meshes are supported in FileA3D.</para></xrefdescription></xrefsect></para> <para>When successfully loaded, FileA3D will contain a list of index entries for all the objects stored inside it. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/FileA3D
		/// </java-name>
		[Dot42.DexImport("android/renderscript/FileA3D", AccessFlags = 33)]
		public partial class FileA3D : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FileA3D() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Returns an index entry from the list of all objects inside FileA3D</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>entry in the a3d file described by the index </para>
				/// </returns>
				/// <java-name>
				/// getIndexEntry
				/// </java-name>
				[Dot42.DexImport("getIndexEntry", "(I)Landroid/renderscript/FileA3D$IndexEntry;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.FileA3D.IndexEntry GetIndexEntry(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.FileA3D.IndexEntry);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates a FileA3D object from an asset stored on disk</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a3d file containing renderscript objects </para>
				/// </returns>
				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/renderscript/RenderScript;Landroid/content/res/AssetManager;Ljava/lang/" +
    "String;)Landroid/renderscript/FileA3D;", AccessFlags = 9)]
				public static global::Android.Renderscripts.FileA3D CreateFromAsset(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.AssetManager mgr, string path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.FileA3D);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates a FileA3D object from a file stored on disk</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a3d file containing renderscript objects </para>
				/// </returns>
				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Ljava/lang/String;)Landroid/renderscript/File" +
    "A3D;", AccessFlags = 9)]
				public static global::Android.Renderscripts.FileA3D CreateFromFile(global::Android.Renderscripts.RenderScript rs, string path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.FileA3D);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates a FileA3D object from a file stored on disk</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a3d file containing renderscript objects </para>
				/// </returns>
				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Ljava/io/File;)Landroid/renderscript/FileA3D;" +
    "", AccessFlags = 9)]
				public static global::Android.Renderscripts.FileA3D CreateFromFile(global::Android.Renderscripts.RenderScript rs, global::Java.IO.File path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.FileA3D);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates a FileA3D object from an application resource</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a3d file containing renderscript objects </para>
				/// </returns>
				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)Landroid/ren" +
    "derscript/FileA3D;", AccessFlags = 9)]
				public static global::Android.Renderscripts.FileA3D CreateFromResource(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.FileA3D);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Returns the number of objects stored inside the a3d file</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of objects stored inside the a3d file </para>
				/// </returns>
				/// <java-name>
				/// getIndexEntryCount
				/// </java-name>
				public virtual int IndexEntryCount
				{
						[Dot42.DexImport("getIndexEntryCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 IndexEntry contains information about one of the RenderScript objects inside the file's index. It could be used to query the object's type and also name and load the object itself if necessary. </para></xrefdescription></xrefsect></para>    
				/// </summary>
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

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Returns the name of a renderscript object the index entry describes</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>name of a renderscript object the index entry describes </para>
						/// </returns>
						/// <java-name>
						/// getName
						/// </java-name>
						public virtual string Name
						{
								[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Returns the type of a renderscript object the index entry describes </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>type of a renderscript object the index entry describes </para>
						/// </returns>
						/// <java-name>
						/// getEntryType
						/// </java-name>
						public virtual global::Android.Renderscripts.FileA3D.EntryType EntryType
						{
								[Dot42.DexImport("getEntryType", "()Landroid/renderscript/FileA3D$EntryType;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.FileA3D.EntryType); }
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Used to load the object described by the index entry </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>base renderscript object described by the entry </para>
						/// </returns>
						/// <java-name>
						/// getObject
						/// </java-name>
						public virtual global::Android.Renderscripts.BaseObj Object
						{
								[Dot42.DexImport("getObject", "()Landroid/renderscript/BaseObj;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.BaseObj); }
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Used to load the mesh described by the index entry, object described by the index entry must be a renderscript mesh</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>renderscript mesh object described by the entry </para>
						/// </returns>
						/// <java-name>
						/// getMesh
						/// </java-name>
						public virtual global::Android.Renderscripts.Mesh Mesh
						{
								[Dot42.DexImport("getMesh", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.Mesh); }
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

		/// <summary>
		///  <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
		/// </summary>
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
				public Float2(float initX, float initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
		/// </summary>
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
				public Float3(float initX, float initY, float initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
		/// </summary>
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
				public Float4(float initX, float initY, float initZ, float initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para> <para>This class gives users a simple way to draw hardware accelerated text. Internally, the glyphs are rendered using the Freetype library and an internal cache of rendered glyph bitmaps is maintained. Each font object represents a combination of a typeface, and point size. You can create multiple font objects to represent styles such as bold or italic text, faces, and different font sizes. During creation, the Android system quieries device's screen DPI to ensure proper sizing across multiple device configurations.</para> <para>Fonts are rendered using screen-space positions and no state setup beyond binding a font to the RenderScript is required. A note of caution on performance, though the state changes are transparent to the user, they do happen internally, and it is more efficient to render large batches of text in sequence. It is also more efficient to render multiple characters at once instead of one by one to improve draw call batching.</para> <para>Font color and transparency are not part of the font object and you can freely modify them in the script to suit the user's rendering needs. Font colors work as a state machine. Every new call to draw text uses the last color set in the script.</para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Font
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Font", AccessFlags = 33)]
		public partial class Font : global::Android.Renderscripts.BaseObj
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
				public static global::Android.Renderscripts.Font CreateFromFile(global::Android.Renderscripts.RenderScript renderScript, global::Android.Content.Res.Resources resources, string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Font);
				}

				/// <java-name>
				/// createFromFile
				/// </java-name>
				[Dot42.DexImport("createFromFile", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/io/File;" +
    "F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Font CreateFromFile(global::Android.Renderscripts.RenderScript renderScript, global::Android.Content.Res.Resources resources, global::Java.IO.File file, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Font);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createFromAsset
				/// </java-name>
				[Dot42.DexImport("createFromAsset", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/lang/Str" +
    "ing;F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Font CreateFromAsset(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, string path, float pointSize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Font);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;IF)Landroid/re" +
    "nderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Font CreateFromResource(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, int id, float pointSize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Font);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Accepts one of the following family names as an argument and will attempt to produce the best match with a system font:</para></xrefdescription></xrefsect></para> <para>"sans-serif" "arial" "helvetica" "tahoma" "verdana" "serif" "times" "times new roman" "palatino" "georgia" "baskerville" "goudy" "fantasy" "cursive" "ITC Stone Serif" "monospace" "courier" "courier new" "monaco"</para> <para>Returns default font if no match could be found. </para>        
				/// </summary>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;Ljava/lang/Str" +
    "ing;Landroid/renderscript/Font$Style;F)Landroid/renderscript/Font;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Font Create(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources res, string familyName, global::Android.Renderscripts.Font.Style fontStyle, float pointSize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Font);
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

		/// <summary>
		///  <para>Class for exposing the native RenderScript int2 type back to the Android system. </para>    
		/// </summary>
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
				public Int2(int initX, int initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript int3 type back to the Android system. </para>    
		/// </summary>
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
				public Int3(int initX, int initY, int initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript int4 type back to the Android system. </para>    
		/// </summary>
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
				public Int4(int initX, int initY, int initZ, int initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript long2 type back to the Android system. </para>    
		/// </summary>
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
				public Long2(long initX, long initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript long3 type back to the Android system. </para>    
		/// </summary>
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
				public Long3(long initX, long initY, long initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript long4 type back to the Android system. </para>    
		/// </summary>
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
				public Long4(long initX, long initY, long initZ, long initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript rs_matrix2x2 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix2f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix2f", AccessFlags = 33)]
		public partial class Matrix2f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new identity 2x2 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix2f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new matrix and sets its values from the given parameter</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix2f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value in the yth row and xth column </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Sets the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the values of the matrix to those of the parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscripts.Matrix2f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a rotation matrix of given angle</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be the result of multiplying two given matrices</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix2f;Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscripts.Matrix2f lhs, global::Android.Renderscripts.Matrix2f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Post-multiplies the current matrix by a given parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscripts.Matrix2f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a rotation matrix of given angle</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public virtual float[] Array
				{
						[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return default(float[]); }
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript rs_matrix3x3 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix3f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix3f", AccessFlags = 33)]
		public partial class Matrix3f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new identity 3x3 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix3f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new matrix and sets its values from the given parameter</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix3f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value in the yth row and xth column </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Sets the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the values of the matrix to those of the parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscripts.Matrix3f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a rotation matrix of certain angle about a given axis</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the upper 2x2 a rotation matrix of the given angle</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the upper 2x2 a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a translation matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be the result of multiplying two given matrices</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix3f;Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscripts.Matrix3f lhs, global::Android.Renderscripts.Matrix3f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Post-multiplies the current matrix by a given parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscripts.Matrix3f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a rotation matrix of certain angle about a given axis</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the upper 2x2 of the current matrix by post-multiplying it with a rotation matrix of given angle</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the upper 2x2 of the current matrix by post-multiplying it with a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a translation matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FF)V", AccessFlags = 1)]
				public virtual void Translate(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public virtual float[] Array
				{
						[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return default(float[]); }
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript rs_matrix4x4 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix4f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix4f", AccessFlags = 33)]
		public partial class Matrix4f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new identity 4x4 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix4f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new matrix and sets its values from the given parameter</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix4f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value in the yth row and xth column </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)F", AccessFlags = 1)]
				public virtual float Get(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Sets the value for a given row and column</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the values of the matrix to those of the parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscripts.Matrix4f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a rotation matrix of certain angle about a given axis</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a translation matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be the result of multiplying two given matrices</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix4f;Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscripts.Matrix4f lhs, global::Android.Renderscripts.Matrix4f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set current values to be an orthographic projection matrix</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadOrtho
				/// </java-name>
				[Dot42.DexImport("loadOrtho", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadOrtho(float l, float r, float b, float t, float n, float f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set current values to be an orthographic projection matrix with the right and bottom clipping planes set to the given values. Left and top clipping planes are set to 0. Near and far are set to -1, 1 respectively</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadOrthoWindow
				/// </java-name>
				[Dot42.DexImport("loadOrthoWindow", "(II)V", AccessFlags = 1)]
				public virtual void LoadOrthoWindow(int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a perspective projection matrix</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadFrustum
				/// </java-name>
				[Dot42.DexImport("loadFrustum", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadFrustum(float l, float r, float b, float t, float n, float f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets current values to be a perspective projection matrix</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadPerspective
				/// </java-name>
				[Dot42.DexImport("loadPerspective", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadPerspective(float fovy, float aspect, float near, float far) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper function to set the current values to a perspective projection matrix with aspect ratio defined by the parameters and (near, far), (bottom, top) mapping to (-1, 1) at z = 0</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadProjectionNormalized
				/// </java-name>
				[Dot42.DexImport("loadProjectionNormalized", "(II)V", AccessFlags = 1)]
				public virtual void LoadProjectionNormalized(int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Post-multiplies the current matrix by a given parameter</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscripts.Matrix4f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a rotation matrix of certain angle about a given axis</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Modifies the current matrix by post-multiplying it with a translation matrix of given dimensions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FFF)V", AccessFlags = 1)]
				public virtual void Translate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current matrix to its inverse </para>        
				/// </summary>
				/// <java-name>
				/// inverse
				/// </java-name>
				[Dot42.DexImport("inverse", "()Z", AccessFlags = 1)]
				public virtual bool Inverse() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the current matrix to its inverse transpose </para>        
				/// </summary>
				/// <java-name>
				/// inverseTranspose
				/// </java-name>
				[Dot42.DexImport("inverseTranspose", "()Z", AccessFlags = 1)]
				public virtual bool InverseTranspose() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public virtual float[] Array
				{
						[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return default(float[]); }
				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para> <para>This class is a container for geometric data displayed with RenderScript. Internally, a mesh is a collection of allocations that represent vertex data (positions, normals, texture coordinates) and index data such as triangles and lines. </para> <para>Vertex data could either be interleaved within one allocation that is provided separately, as multiple allocation objects, or done as a combination of both. When a vertex channel name matches an input in the vertex program, RenderScript automatically connects the two together. </para> <para>Parts of the mesh can be rendered with either explicit index sets or primitive types. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Mesh
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Mesh", AccessFlags = 33)]
		public partial class Mesh : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Mesh() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>vertex data allocation at the given index</para>
				/// </returns>
				/// <java-name>
				/// getVertexAllocation
				/// </java-name>
				[Dot42.DexImport("getVertexAllocation", "(I)Landroid/renderscript/Allocation;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Allocation GetVertexAllocation(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>allocation containing primtive index data or null if the index data is not specified explicitly</para>
				/// </returns>
				/// <java-name>
				/// getIndexSetAllocation
				/// </java-name>
				[Dot42.DexImport("getIndexSetAllocation", "(I)Landroid/renderscript/Allocation;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Allocation GetIndexSetAllocation(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Allocation);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>index set primitive type</para>
				/// </returns>
				/// <java-name>
				/// getPrimitive
				/// </java-name>
				[Dot42.DexImport("getPrimitive", "(I)Landroid/renderscript/Mesh$Primitive;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Mesh.Primitive GetPrimitive(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Mesh.Primitive);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>number of allocations containing vertex data</para>
				/// </returns>
				/// <java-name>
				/// getVertexAllocationCount
				/// </java-name>
				public virtual int VertexAllocationCount
				{
						[Dot42.DexImport("getVertexAllocationCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>number of primitives or index sets in the mesh</para>
				/// </returns>
				/// <java-name>
				/// getPrimitiveCount
				/// </java-name>
				public virtual int PrimitiveCount
				{
						[Dot42.DexImport("getPrimitiveCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Builder that allows creation of a mesh object point by point and triangle by triangle</para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Mesh$TriangleMeshBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$TriangleMeshBuilder", AccessFlags = 9)]
				public partial class TriangleMeshBuilder
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// COLOR
						/// </java-name>
						[Dot42.DexImport("COLOR", "I", AccessFlags = 25)]
						public const int COLOR = 1;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "I", AccessFlags = 25)]
						public const int NORMAL = 2;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// TEXTURE_0
						/// </java-name>
						[Dot42.DexImport("TEXTURE_0", "I", AccessFlags = 25)]
						public const int TEXTURE_0 = 256;
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;II)V", AccessFlags = 1)]
						public TriangleMeshBuilder(global::Android.Renderscripts.RenderScript renderScript, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a float2 vertex to the mesh</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addVertex
						/// </java-name>
						[Dot42.DexImport("addVertex", "(FF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddVertex(float x, float y) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a float3 vertex to the mesh</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addVertex
						/// </java-name>
						[Dot42.DexImport("addVertex", "(FFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddVertex(float x, float y, float z) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the texture coordinate for the vertices that are added after this method call.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(FF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetTexture(float s, float t) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the normal vector for the vertices that are added after this method call.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setNormal
						/// </java-name>
						[Dot42.DexImport("setNormal", "(FFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetNormal(float x, float y, float z) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the color for the vertices that are added after this method call.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setColor
						/// </java-name>
						[Dot42.DexImport("setColor", "(FFFF)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder SetColor(float r, float g, float b, float a) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a new triangle to the mesh builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addTriangle
						/// </java-name>
						[Dot42.DexImport("addTriangle", "(III)Landroid/renderscript/Mesh$TriangleMeshBuilder;", AccessFlags = 1)]
						public virtual TriangleMeshBuilder AddTriangle(int idx1, int idx2, int idx3) /* MethodBuilder.Create */ 
						{
								return default(TriangleMeshBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates the mesh object from the current state of the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "(Z)Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Mesh Create(bool uploadToBufferObject) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal TriangleMeshBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Mesh builder object. It starts empty and requires the user to add all the vertex and index allocations that comprise the mesh</para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Mesh$AllocationBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$AllocationBuilder", AccessFlags = 9)]
				public partial class AllocationBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public AllocationBuilder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an allocation containing vertex buffer data to the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addVertexAllocation
						/// </java-name>
						[Dot42.DexImport("addVertexAllocation", "(Landroid/renderscript/Allocation;)Landroid/renderscript/Mesh$AllocationBuilder;", AccessFlags = 1)]
						public virtual AllocationBuilder AddVertexAllocation(global::Android.Renderscripts.Allocation a) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an allocation containing index buffer data and index type to the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addIndexSetAllocation
						/// </java-name>
						[Dot42.DexImport("addIndexSetAllocation", "(Landroid/renderscript/Allocation;Landroid/renderscript/Mesh$Primitive;)Landroid/" +
    "renderscript/Mesh$AllocationBuilder;", AccessFlags = 1)]
						public virtual AllocationBuilder AddIndexSetAllocation(global::Android.Renderscripts.Allocation a, global::Android.Renderscripts.Mesh.Primitive p) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an index set type to the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Mesh$Primitive;)Landroid/renderscript/Mesh$AllocationBuild" +
    "er;", AccessFlags = 1)]
						public virtual AllocationBuilder AddIndexSetType(global::Android.Renderscripts.Mesh.Primitive p) /* MethodBuilder.Create */ 
						{
								return default(AllocationBuilder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Create a Mesh object from the current state of the builder</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Mesh Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AllocationBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>internal index of the last vertex buffer type added to builder </para>
						/// </returns>
						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						public virtual int CurrentVertexTypeIndex
						{
								[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>internal index of the last index set added to the builder </para>
						/// </returns>
						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						public virtual int CurrentIndexSetIndex
						{
								[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Mesh builder object. It starts empty and requires you to add the types necessary to create vertex and index allocations.</para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Mesh$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Mesh$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;I)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a vertex data type to the builder object</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addVertexType
						/// </java-name>
						[Dot42.DexImport("addVertexType", "(Landroid/renderscript/Type;)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddVertexType(global::Android.Renderscripts.Type t) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a vertex data type to the builder object</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addVertexType
						/// </java-name>
						[Dot42.DexImport("addVertexType", "(Landroid/renderscript/Element;I)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddVertexType(global::Android.Renderscripts.Element e, int size) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an index set data type to the builder object</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Type;Landroid/renderscript/Mesh$Primitive;)Landroid/render" +
    "script/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscripts.Type t, global::Android.Renderscripts.Mesh.Primitive p) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an index set primitive type to the builder object</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Mesh$Primitive;)Landroid/renderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscripts.Mesh.Primitive p) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds an index set data type to the builder object</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// addIndexSetType
						/// </java-name>
						[Dot42.DexImport("addIndexSetType", "(Landroid/renderscript/Element;ILandroid/renderscript/Mesh$Primitive;)Landroid/re" +
    "nderscript/Mesh$Builder;", AccessFlags = 1)]
						public virtual Builder AddIndexSetType(global::Android.Renderscripts.Element e, int size, global::Android.Renderscripts.Mesh.Primitive p) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Create a Mesh object from the current state of the builder</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Mesh;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Mesh Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Mesh);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>internal index of the last vertex buffer type added to builder </para>
						/// </returns>
						/// <java-name>
						/// getCurrentVertexTypeIndex
						/// </java-name>
						public virtual int CurrentVertexTypeIndex
						{
								[Dot42.DexImport("getCurrentVertexTypeIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>internal index of the last index set added to the builder </para>
						/// </returns>
						/// <java-name>
						/// getCurrentIndexSetIndex
						/// </java-name>
						public virtual int CurrentIndexSetIndex
						{
								[Dot42.DexImport("getCurrentIndexSetIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
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

		/// <summary>
		///  <para>Program is a base class for all the objects that modify various stages of the graphics pipeline </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Program
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Program", AccessFlags = 33)]
		public partial class Program : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Program() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the type of the constant buffer used in the program object. It could be used to query internal elements or create an allocation to store constant data. </para>        
				/// </summary>
				/// <returns>
				///  <para>constant input type </para>
				/// </returns>
				/// <java-name>
				/// getConstant
				/// </java-name>
				[Dot42.DexImport("getConstant", "(I)Landroid/renderscript/Type;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Type GetConstant(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Type);
				}

				/// <summary>
				///  <para>Returns the type of texture at a given slot. e.g. 2D or Cube </para>        
				/// </summary>
				/// <returns>
				///  <para>texture input type </para>
				/// </returns>
				/// <java-name>
				/// getTextureType
				/// </java-name>
				[Dot42.DexImport("getTextureType", "(I)Landroid/renderscript/Program$TextureType;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Program.TextureType GetTextureType(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Program.TextureType);
				}

				/// <summary>
				///  <para>Returns the name of the texture input at a given slot. e.g. tex0, diffuse, spec </para>        
				/// </summary>
				/// <returns>
				///  <para>texture input name </para>
				/// </returns>
				/// <java-name>
				/// getTextureName
				/// </java-name>
				[Dot42.DexImport("getTextureName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTextureName(int slot) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Binds a constant buffer to be used as uniform inputs to the program</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindConstants
				/// </java-name>
				[Dot42.DexImport("bindConstants", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindConstants(global::Android.Renderscripts.Allocation a, int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Binds a texture to be used in the program</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindTexture
				/// </java-name>
				[Dot42.DexImport("bindTexture", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindTexture(global::Android.Renderscripts.Allocation va, int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Binds an object that describes how a texture at the corresponding location is sampled</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindSampler
				/// </java-name>
				[Dot42.DexImport("bindSampler", "(Landroid/renderscript/Sampler;I)V", AccessFlags = 1)]
				public virtual void BindSampler(global::Android.Renderscripts.Sampler vs, int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Program object can have zero or more constant allocations associated with it. This method returns the total count. </para>        
				/// </summary>
				/// <returns>
				///  <para>number of constant input types </para>
				/// </returns>
				/// <java-name>
				/// getConstantCount
				/// </java-name>
				public virtual int ConstantCount
				{
						[Dot42.DexImport("getConstantCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the number of textures used in this program object </para>        
				/// </summary>
				/// <returns>
				///  <para>number of texture inputs </para>
				/// </returns>
				/// <java-name>
				/// getTextureCount
				/// </java-name>
				public virtual int TextureCount
				{
						[Dot42.DexImport("getTextureCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/renderscript/Program$BaseProgramBuilder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Program$BaseProgramBuilder", AccessFlags = 9)]
				public partial class BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 4)]
						protected internal BaseProgramBuilder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the GLSL shader code to be used in the program</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// setShader
						/// </java-name>
						[Dot42.DexImport("setShader", "(Ljava/lang/String;)Landroid/renderscript/Program$BaseProgramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder SetShader(string s) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <summary>
						///  <para>Sets the GLSL shader code to be used in the program</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// setShader
						/// </java-name>
						[Dot42.DexImport("setShader", "(Landroid/content/res/Resources;I)Landroid/renderscript/Program$BaseProgramBuilde" +
    "r;", AccessFlags = 1)]
						public virtual BaseProgramBuilder SetShader(global::Android.Content.Res.Resources resources, int resourceID) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <summary>
						///  <para>Adds constant (uniform) inputs to the program</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// addConstant
						/// </java-name>
						[Dot42.DexImport("addConstant", "(Landroid/renderscript/Type;)Landroid/renderscript/Program$BaseProgramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder AddConstant(global::Android.Renderscripts.Type t) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <summary>
						///  <para>Adds a texture input to the Program</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// addTexture
						/// </java-name>
						[Dot42.DexImport("addTexture", "(Landroid/renderscript/Program$TextureType;)Landroid/renderscript/Program$BasePro" +
    "gramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder AddTexture(global::Android.Renderscripts.Program.TextureType texType) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <summary>
						///  <para>Adds a texture input to the Program</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// addTexture
						/// </java-name>
						[Dot42.DexImport("addTexture", "(Landroid/renderscript/Program$TextureType;Ljava/lang/String;)Landroid/renderscri" +
    "pt/Program$BaseProgramBuilder;", AccessFlags = 1)]
						public virtual BaseProgramBuilder AddTexture(global::Android.Renderscripts.Program.TextureType texType, string texName) /* MethodBuilder.Create */ 
						{
								return default(BaseProgramBuilder);
						}

						/// <java-name>
						/// initProgram
						/// </java-name>
						[Dot42.DexImport("initProgram", "(Landroid/renderscript/Program;)V", AccessFlags = 4)]
						protected internal virtual void InitProgram(global::Android.Renderscripts.Program p) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal BaseProgramBuilder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Queries the index of the last added constant buffer type </para>        
						/// </summary>
						/// <java-name>
						/// getCurrentConstantIndex
						/// </java-name>
						public virtual int CurrentConstantIndex
						{
								[Dot42.DexImport("getCurrentConstantIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Queries the index of the last added texture type </para>        
						/// </summary>
						/// <java-name>
						/// getCurrentTextureIndex
						/// </java-name>
						public virtual int CurrentTextureIndex
						{
								[Dot42.DexImport("getCurrentTextureIndex", "()I", AccessFlags = 1)]
								get{ return default(int); }
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

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para> <para>The RenderScript fragment program, also known as fragment shader is responsible for manipulating pixel data in a user defined way. It's constructed from a GLSL shader string containing the program body, textures inputs, and a Type object that describes the constants used by the program. Similar to the vertex programs, when an allocation with constant input values is bound to the shader, its values are sent to the graphics program automatically.</para> <para>The values inside the allocation are not explicitly tracked. If they change between two draw calls using the same program object, the runtime needs to be notified of that change by calling rsgAllocationSyncAll so it could send the new values to hardware. Communication between the vertex and fragment programs is handled internally in the GLSL code. For example, if the fragment program is expecting a varying input called varTex0, the GLSL code inside the program vertex must provide it. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramFragment
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramFragment", AccessFlags = 33)]
		public partial class ProgramFragment : global::Android.Renderscripts.Program
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramFragment$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramFragment$Builder", AccessFlags = 9)]
				public partial class Builder : global::Android.Renderscripts.Program.BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates ProgramFragment from the current state of the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>ProgramFragment </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramFragment;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramFragment Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramFragment);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para> <para>ProgramFragmentFixedFunction is a helper class that provides a way to make a simple fragment shader without writing any GLSL code. This class allows for display of constant color, interpolated color from the vertex shader, or combinations of the both blended with results of up to two texture lookups.&lt;/p </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramFragmentFixedFunction
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction", AccessFlags = 33)]
		public partial class ProgramFragmentFixedFunction : global::Android.Renderscripts.ProgramFragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramFragmentFixedFunction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramFragmentFixedFunction$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramFragmentFixedFunction$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// MAX_TEXTURE
						/// </java-name>
						[Dot42.DexImport("MAX_TEXTURE", "I", AccessFlags = 25)]
						public const int MAX_TEXTURE = 2;
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Adds a texture to be fetched as part of the fixed function fragment program</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(Landroid/renderscript/ProgramFragmentFixedFunction$Builder$EnvMode;Landroid/rend" +
    "erscript/ProgramFragmentFixedFunction$Builder$Format;I)Landroid/renderscript/Pro" +
    "gramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetTexture(Builder.EnvMode env, Builder.Format fmt, int slot) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Specifies whether the texture coordinate passed from the vertex program is replaced with an openGL internal point sprite texture coordinate</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPointSpriteTexCoordinateReplacement
						/// </java-name>
						[Dot42.DexImport("setPointSpriteTexCoordinateReplacement", "(Z)Landroid/renderscript/ProgramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetPointSpriteTexCoordinateReplacement(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Specifies whether the varying color passed from the vertex program or the constant color set on the fragment program is used in the final color calculation in the fixed function fragment shader</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setVaryingColor
						/// </java-name>
						[Dot42.DexImport("setVaryingColor", "(Z)Landroid/renderscript/ProgramFragmentFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetVaryingColor(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates the fixed function fragment program from the current state of the builder.</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramFragmentFixedFunction;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramFragmentFixedFunction Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramFragmentFixedFunction);
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

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Program raster is primarily used to specify whether point sprites are enabled and to control the culling mode. By default, back faces are culled. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramRaster
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramRaster", AccessFlags = 33)]
		public partial class ProgramRaster : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramRaster() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Specifies how triangles are culled based on their orientation </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>cull mode </para>
				/// </returns>
				/// <java-name>
				/// getCullMode
				/// </java-name>
				[Dot42.DexImport("getCullMode", "()Landroid/renderscript/ProgramRaster$CullMode;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.ProgramRaster.CullMode GetCullMode() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramRaster.CullMode);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CULL_BACK
				/// </java-name>
				[Dot42.DexImport("CULL_BACK", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramRaster CULL_BACK(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramRaster);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CULL_FRONT
				/// </java-name>
				[Dot42.DexImport("CULL_FRONT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramRaster CULL_FRONT(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramRaster);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CULL_NONE
				/// </java-name>
				[Dot42.DexImport("CULL_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramRaster;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramRaster CULL_NONE(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramRaster);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Specifies whether vertices are rendered as screen aligned elements of a specified size </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>whether point sprites are enabled </para>
				/// </returns>
				/// <java-name>
				/// isPointSpriteEnabled
				/// </java-name>
				public virtual bool IsPointSpriteEnabled
				{
						[Dot42.DexImport("isPointSpriteEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramRaster$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramRaster$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPointSpriteEnabled
						/// </java-name>
						[Dot42.DexImport("setPointSpriteEnabled", "(Z)Landroid/renderscript/ProgramRaster$Builder;", AccessFlags = 1)]
						public virtual Builder SetPointSpriteEnabled(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setCullMode
						/// </java-name>
						[Dot42.DexImport("setCullMode", "(Landroid/renderscript/ProgramRaster$CullMode;)Landroid/renderscript/ProgramRaste" +
    "r$Builder;", AccessFlags = 1)]
						public virtual Builder SetCullMode(global::Android.Renderscripts.ProgramRaster.CullMode m) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramRaster;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramRaster Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramRaster);
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

		/// <summary>
		///  <para>ProgramStore contains a set of parameters that control how the graphics hardware handles writes to the framebuffer. It could be used to:</para> <para> <ul> <li> <para>enable/disable depth testing </para></li> <li> <para>specify wheather depth writes are performed </para></li> <li> <para>setup various blending modes for use in effects like transparency </para></li> <li> <para>define write masks for color components written into the framebuffer </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramStore
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramStore", AccessFlags = 33)]
		public partial class ProgramStore : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramStore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the function used to test writing into the depth buffer </para>        
				/// </summary>
				/// <returns>
				///  <para>depth function </para>
				/// </returns>
				/// <java-name>
				/// getDepthFunc
				/// </java-name>
				[Dot42.DexImport("getDepthFunc", "()Landroid/renderscript/ProgramStore$DepthFunc;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.ProgramStore.DepthFunc GetDepthFunc() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore.DepthFunc);
				}

				/// <summary>
				///  <para>Specifies how the source blending factor is computed </para>        
				/// </summary>
				/// <returns>
				///  <para>source blend function </para>
				/// </returns>
				/// <java-name>
				/// getBlendSrcFunc
				/// </java-name>
				[Dot42.DexImport("getBlendSrcFunc", "()Landroid/renderscript/ProgramStore$BlendSrcFunc;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.ProgramStore.BlendSrcFunc GetBlendSrcFunc() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore.BlendSrcFunc);
				}

				/// <summary>
				///  <para>Specifies how the destination blending factor is computed </para>        
				/// </summary>
				/// <returns>
				///  <para>destination blend function </para>
				/// </returns>
				/// <java-name>
				/// getBlendDstFunc
				/// </java-name>
				[Dot42.DexImport("getBlendDstFunc", "()Landroid/renderscript/ProgramStore$BlendDstFunc;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.ProgramStore.BlendDstFunc GetBlendDstFunc() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore.BlendDstFunc);
				}

				/// <summary>
				///  <para>Returns a pre-defined program store object with the following characteristics: <ul> <li> <para>incoming pixels are drawn if their depth value is less than the stored value in the depth buffer. If the pixel is drawn, its value is also stored in the depth buffer</para></li> <li> <para>incoming pixels override the value stored in the color buffer if it passes the depth test</para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// BLEND_NONE_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("BLEND_NONE_DEPTH_TEST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramStore BLEND_NONE_DEPTH_TEST(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore);
				}

				/// <summary>
				///  <para>Returns a pre-defined program store object with the following characteristics: <ul> <li> <para>incoming pixels always pass the depth test and their value is not stored in the depth buffer</para></li> <li> <para>incoming pixels override the value stored in the color buffer</para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// BLEND_NONE_DEPTH_NONE
				/// </java-name>
				[Dot42.DexImport("BLEND_NONE_DEPTH_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramStore BLEND_NONE_DEPTH_NONE(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore);
				}

				/// <summary>
				///  <para>Returns a pre-defined program store object with the following characteristics: <ul> <li> <para>incoming pixels are drawn if their depth value is less than the stored value in the depth buffer. If the pixel is drawn, its value is also stored in the depth buffer</para></li> <li> <para>if the incoming (Source) pixel passes depth test, its value is combined with the stored color (Dest) using the following formula Final.RGB = Source.RGB * Source.A + Dest.RGB * (1 - Source.A)</para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// BLEND_ALPHA_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("BLEND_ALPHA_DEPTH_TEST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramStore BLEND_ALPHA_DEPTH_TEST(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore);
				}

				/// <summary>
				///  <para>Returns a pre-defined program store object with the following characteristics: <ul> <li> <para>incoming pixels always pass the depth test and their value is not stored in the depth buffer</para></li> <li> <para>incoming pixel's value is combined with the stored color (Dest) using the following formula Final.RGB = Source.RGB * Source.A + Dest.RGB * (1 - Source.A)</para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// BLEND_ALPHA_DEPTH_NONE
				/// </java-name>
				[Dot42.DexImport("BLEND_ALPHA_DEPTH_NONE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/ProgramStore;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ProgramStore BLEND_ALPHA_DEPTH_NONE(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ProgramStore);
				}

				/// <summary>
				///  <para>Queries whether writes are enabled into the depth buffer </para>        
				/// </summary>
				/// <returns>
				///  <para>depth mask </para>
				/// </returns>
				/// <java-name>
				/// isDepthMaskEnabled
				/// </java-name>
				public virtual bool IsDepthMaskEnabled
				{
						[Dot42.DexImport("isDepthMaskEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Queries whether red channel is written </para>        
				/// </summary>
				/// <returns>
				///  <para>red color channel mask </para>
				/// </returns>
				/// <java-name>
				/// isColorMaskRedEnabled
				/// </java-name>
				public virtual bool IsColorMaskRedEnabled
				{
						[Dot42.DexImport("isColorMaskRedEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Queries whether green channel is written </para>        
				/// </summary>
				/// <returns>
				///  <para>green color channel mask </para>
				/// </returns>
				/// <java-name>
				/// isColorMaskGreenEnabled
				/// </java-name>
				public virtual bool IsColorMaskGreenEnabled
				{
						[Dot42.DexImport("isColorMaskGreenEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Queries whether blue channel is written </para>        
				/// </summary>
				/// <returns>
				///  <para>blue color channel mask </para>
				/// </returns>
				/// <java-name>
				/// isColorMaskBlueEnabled
				/// </java-name>
				public virtual bool IsColorMaskBlueEnabled
				{
						[Dot42.DexImport("isColorMaskBlueEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Queries whether alpha channel is written </para>        
				/// </summary>
				/// <returns>
				///  <para>alpha channel mask </para>
				/// </returns>
				/// <java-name>
				/// isColorMaskAlphaEnabled
				/// </java-name>
				public virtual bool IsColorMaskAlphaEnabled
				{
						[Dot42.DexImport("isColorMaskAlphaEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Specifies whether colors are dithered before writing into the framebuffer </para>        
				/// </summary>
				/// <returns>
				///  <para>whether dither is enabled </para>
				/// </returns>
				/// <java-name>
				/// isDitherEnabled
				/// </java-name>
				public virtual bool IsDitherEnabled
				{
						[Dot42.DexImport("isDitherEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Builder class for ProgramStore object. If the builder is left empty, the equivalent of BLEND_NONE_DEPTH_NONE would be returned </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramStore$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramStore$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Specifies the depth testing behavior</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setDepthFunc
						/// </java-name>
						[Dot42.DexImport("setDepthFunc", "(Landroid/renderscript/ProgramStore$DepthFunc;)Landroid/renderscript/ProgramStore" +
    "$Builder;", AccessFlags = 1)]
						public virtual Builder SetDepthFunc(global::Android.Renderscripts.ProgramStore.DepthFunc func) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Enables writes into the depth buffer</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setDepthMaskEnabled
						/// </java-name>
						[Dot42.DexImport("setDepthMaskEnabled", "(Z)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetDepthMaskEnabled(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Enables writes into the color buffer</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setColorMaskEnabled
						/// </java-name>
						[Dot42.DexImport("setColorMaskEnabled", "(ZZZZ)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetColorMaskEnabled(bool r, bool g, bool b, bool a) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Specifies how incoming pixels are combined with the pixels stored in the framebuffer</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setBlendFunc
						/// </java-name>
						[Dot42.DexImport("setBlendFunc", "(Landroid/renderscript/ProgramStore$BlendSrcFunc;Landroid/renderscript/ProgramSto" +
    "re$BlendDstFunc;)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetBlendFunc(global::Android.Renderscripts.ProgramStore.BlendSrcFunc src, global::Android.Renderscripts.ProgramStore.BlendDstFunc dst) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Enables dithering</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this </para>
						/// </returns>
						/// <java-name>
						/// setDitherEnabled
						/// </java-name>
						[Dot42.DexImport("setDitherEnabled", "(Z)Landroid/renderscript/ProgramStore$Builder;", AccessFlags = 1)]
						public virtual Builder SetDitherEnabled(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates a program store from the current state of the builder </para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramStore;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramStore Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramStore);
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

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 ProgramVertex, also know as a vertex shader, describes a stage in the graphics pipeline responsible for manipulating geometric data in a user-defined way.</para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramVertex
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramVertex", AccessFlags = 33)]
		public partial class ProgramVertex : global::Android.Renderscripts.Program
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramVertex() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>input attribute element </para>
				/// </returns>
				/// <java-name>
				/// getInput
				/// </java-name>
				[Dot42.DexImport("getInput", "(I)Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.Element GetInput(int slot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Element);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>number of input attribute elements </para>
				/// </returns>
				/// <java-name>
				/// getInputCount
				/// </java-name>
				public virtual int InputCount
				{
						[Dot42.DexImport("getInputCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Builder class for creating ProgramVertex objects. The builder starts empty and the user must minimally provide the GLSL shader code, and the varying inputs. Constant, or uniform parameters to the shader may optionally be provided as well.</para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramVertex$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertex$Builder", AccessFlags = 9)]
				public partial class Builder : global::Android.Renderscripts.Program.BaseProgramBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Add varying inputs to the program</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>self </para>
						/// </returns>
						/// <java-name>
						/// addInput
						/// </java-name>
						[Dot42.DexImport("addInput", "(Landroid/renderscript/Element;)Landroid/renderscript/ProgramVertex$Builder;", AccessFlags = 1)]
						public virtual Builder AddInput(global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates ProgramVertex from the current state of the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>ProgramVertex </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramVertex;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramVertex Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramVertex);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 ProgramVertexFixedFunction is a helper class that provides a simple way to create a fixed function emulation vertex shader without writing any GLSL code.</para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ProgramVertexFixedFunction
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction", AccessFlags = 33)]
		public partial class ProgramVertexFixedFunction : global::Android.Renderscripts.ProgramVertex
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProgramVertexFixedFunction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Binds the constant buffer containing fixed function emulation matrices</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindConstants
				/// </java-name>
				[Dot42.DexImport("bindConstants", "(Landroid/renderscript/ProgramVertexFixedFunction$Constants;)V", AccessFlags = 1)]
				public virtual void BindConstants(global::Android.Renderscripts.ProgramVertexFixedFunction.Constants va) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Helper class to store modelview, projection and texture matrices for ProgramVertexFixedFunction</para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramVertexFixedFunction$Constants
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction$Constants", AccessFlags = 9)]
				public partial class Constants
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Constants(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Forces deallocation of memory backing the contant matrices. Normally, this is unnecessary and will be garbage collected</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// destroy
						/// </java-name>
						[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
						public virtual void Destroy() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the modelview matrix in the fixed function matrix buffer</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setModelview
						/// </java-name>
						[Dot42.DexImport("setModelview", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetModelview(global::Android.Renderscripts.Matrix4f m) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the projection matrix in the fixed function matrix buffer</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setProjection
						/// </java-name>
						[Dot42.DexImport("setProjection", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetProjection(global::Android.Renderscripts.Matrix4f m) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Sets the texture matrix in the fixed function matrix buffer. Texture matrix must be enabled in the ProgramVertexFixedFunction builder for the shader to utilize it.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setTexture
						/// </java-name>
						[Dot42.DexImport("setTexture", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
						public virtual void SetTexture(global::Android.Renderscripts.Matrix4f m) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Constants() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ProgramVertexFixedFunction$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ProgramVertexFixedFunction$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Specifies whether texture matrix calculations are to be added to the shader</para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setTextureMatrixEnable
						/// </java-name>
						[Dot42.DexImport("setTextureMatrixEnable", "(Z)Landroid/renderscript/ProgramVertexFixedFunction$Builder;", AccessFlags = 1)]
						public virtual Builder SetTextureMatrixEnable(bool enable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Creates ProgramVertexFixedFunction from the current state of the builder</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Fixed function emulation ProgramVertex </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ProgramVertexFixedFunction;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.ProgramVertexFixedFunction Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ProgramVertexFixedFunction);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class provides access to a RenderScript context, which controls RenderScript initialization, resource management, and teardown. An instance of the RenderScript class must be created before any other RS objects can be created.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Change the priority of the worker threads for this context.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(Landroid/renderscript/RenderScript$Priority;)V", AccessFlags = 1)]
				public virtual void SetPriority(global::Android.Renderscripts.RenderScript.Priority p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a RenderScript context.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>RenderScript </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;)Landroid/renderscript/RenderScript;", AccessFlags = 9)]
				public static global::Android.Renderscripts.RenderScript Create(global::Android.Content.Context ctx) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.RenderScript);
				}

				/// <summary>
				///  <para>Print the currently available debugging information about the state of the RS context to the log. </para>        
				/// </summary>
				/// <java-name>
				/// contextDump
				/// </java-name>
				[Dot42.DexImport("contextDump", "()V", AccessFlags = 1)]
				public virtual void ContextDump() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Wait for any pending asynchronous opeations (such as copies to a RS allocation or RS script executions) to complete. </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Destroys this RenderScript context. Once this function is called, using this context or any objects belonging to this context is illegal. </para>        
				/// </summary>
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
				public virtual global::Android.Renderscripts.RenderScript.RSMessageHandler MessageHandler
				{
						[Dot42.DexImport("getMessageHandler", "()Landroid/renderscript/RenderScript$RSMessageHandler;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.RenderScript.RSMessageHandler); }
						[Dot42.DexImport("setMessageHandler", "(Landroid/renderscript/RenderScript$RSMessageHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public virtual global::Android.Renderscripts.RenderScript.RSErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Landroid/renderscript/RenderScript$RSErrorHandler;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.RenderScript.RSErrorHandler); }
						[Dot42.DexImport("setErrorHandler", "(Landroid/renderscript/RenderScript$RSErrorHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the application context associated with the RenderScript context.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The application context. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
						[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
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

				/// <summary>
				///  <para>The runtime error handler base class. An application should derive from this class if it wishes to install an error handler. When errors occur at runtime, the fields in this class will be filled, and the run method will be called. </para>    
				/// </summary>
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

				/// <summary>
				///  <para>The base class from which an application should derive in order to receive RS messages from scripts. When a script calls <c>rsSendToClient </c> , the data fields will be filled, and the run method will be called on a separate thread. This will occur some time after <c>rsSendToClient </c> completes in the script, as <c>rsSendToClient </c> is asynchronous. Message handlers are not guaranteed to have completed when android.renderscript.RenderScript#finish returns. </para>    
				/// </summary>
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

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 The Graphics derivitive of RenderScript. Extends the basic context to add a root script which is the display window for graphical output. When the system needs to update the display the currently bound root script will be called. This script is expected to issue the rendering commands to repaint the screen.</para></xrefdescription></xrefsect></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RenderScriptGL
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RenderScriptGL", AccessFlags = 33)]
		public partial class RenderScriptGL : global::Android.Renderscripts.RenderScript
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Construct a new RenderScriptGL context.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/renderscript/RenderScriptGL$SurfaceConfig;)V", AccessFlags = 1)]
				public RenderScriptGL(global::Android.Content.Context ctx, global::Android.Renderscripts.RenderScriptGL.SurfaceConfig sc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Bind an os surface</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSurface
				/// </java-name>
				[Dot42.DexImport("setSurface", "(Landroid/view/SurfaceHolder;II)V", AccessFlags = 1)]
				public virtual void SetSurface(global::Android.Views.ISurfaceHolder sur, int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Bind an os surface</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSurfaceTexture
				/// </java-name>
				[Dot42.DexImport("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void SetSurfaceTexture(global::Android.Graphics.SurfaceTexture sur, int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Temporarly halt calls to the root rendering script.</para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Resume calls to the root rendering script.</para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the script to handle calls to render the primary surface.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindRootScript
				/// </java-name>
				[Dot42.DexImport("bindRootScript", "(Landroid/renderscript/Script;)V", AccessFlags = 1)]
				public virtual void BindRootScript(global::Android.Renderscripts.Script s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the default ProgramStore object seen as the parent state by the root rendering script.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindProgramStore
				/// </java-name>
				[Dot42.DexImport("bindProgramStore", "(Landroid/renderscript/ProgramStore;)V", AccessFlags = 1)]
				public virtual void BindProgramStore(global::Android.Renderscripts.ProgramStore p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the default ProgramFragment object seen as the parent state by the root rendering script.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindProgramFragment
				/// </java-name>
				[Dot42.DexImport("bindProgramFragment", "(Landroid/renderscript/ProgramFragment;)V", AccessFlags = 1)]
				public virtual void BindProgramFragment(global::Android.Renderscripts.ProgramFragment p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the default ProgramRaster object seen as the parent state by the root rendering script.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindProgramRaster
				/// </java-name>
				[Dot42.DexImport("bindProgramRaster", "(Landroid/renderscript/ProgramRaster;)V", AccessFlags = 1)]
				public virtual void BindProgramRaster(global::Android.Renderscripts.ProgramRaster p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the default ProgramVertex object seen as the parent state by the root rendering script.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindProgramVertex
				/// </java-name>
				[Dot42.DexImport("bindProgramVertex", "(Landroid/renderscript/ProgramVertex;)V", AccessFlags = 1)]
				public virtual void BindProgramVertex(global::Android.Renderscripts.ProgramVertex p) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RenderScriptGL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 return the height of the last set surface.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 return the width of the last set surface.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
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
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Class which is used to describe a pixel format for a graphical buffer. This is used to describe the intended format of the display surface.</para></xrefdescription></xrefsect></para> <para>The configuration is described by pairs of minimum and preferred bit depths for each component within the config and additional structural information. </para>    
				/// </summary>
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

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the per-component bit depth for color (red, green, blue). This configures the surface for an unsigned integer buffer type.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setColor
						/// </java-name>
						[Dot42.DexImport("setColor", "(II)V", AccessFlags = 1)]
						public virtual void SetColor(int minimum, int preferred) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the bit depth for alpha. This configures the surface for an unsigned integer buffer type.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setAlpha
						/// </java-name>
						[Dot42.DexImport("setAlpha", "(II)V", AccessFlags = 1)]
						public virtual void SetAlpha(int minimum, int preferred) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Set the bit depth for the depth buffer. This configures the surface for an unsigned integer buffer type. If a minimum of 0 is specified then its possible no depth buffer will be allocated.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setDepth
						/// </java-name>
						[Dot42.DexImport("setDepth", "(II)V", AccessFlags = 1)]
						public virtual void SetDepth(int minimum, int preferred) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Configure the multisample rendering.</para></xrefdescription></xrefsect></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setSamples
						/// </java-name>
						[Dot42.DexImport("setSamples", "(IIF)V", AccessFlags = 1)]
						public virtual void SetSamples(int minimum, int preferred, float Q) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RSDriverException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSDriverException", AccessFlags = 33)]
		public partial class RSDriverException : global::Android.Renderscripts.RSRuntimeException
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

		/// <summary>
		///  <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RSIllegalArgumentException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSIllegalArgumentException", AccessFlags = 33)]
		public partial class RSIllegalArgumentException : global::Android.Renderscripts.RSRuntimeException
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

		/// <summary>
		///  <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RSInvalidStateException
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSInvalidStateException", AccessFlags = 33)]
		public partial class RSInvalidStateException : global::Android.Renderscripts.RSRuntimeException
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

		/// <summary>
		///  <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
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

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 The Surface View for a graphics renderscript (RenderScriptGL) to draw on.</para></xrefdescription></xrefsect></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RSSurfaceView
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSSurfaceView", AccessFlags = 33)]
		public partial class RSSurfaceView : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Standard View constructor. In order to render something, you must call android.opengl.GLSurfaceView#setRenderer to register a renderer. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RSSurfaceView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Standard View constructor. In order to render something, you must call android.opengl.GLSurfaceView#setRenderer to register a renderer. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RSSurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 This method is part of the SurfaceHolder.Callback interface, and is not normally called or subclassed by clients of RSSurfaceView. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceCreated(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 This method is part of the SurfaceHolder.Callback interface, and is not normally called or subclassed by clients of RSSurfaceView. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceDestroyed(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 This method is part of the SurfaceHolder.Callback interface, and is not normally called or subclassed by clients of RSSurfaceView. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
				public virtual void SurfaceChanged(global::Android.Views.ISurfaceHolder holder, int format, int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Inform the view that the activity is paused. The owner of this view must call this method when the activity is paused. Calling this method will pause the rendering thread. Must not be called before a renderer has been set. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Inform the view that the activity is resumed. The owner of this view must call this method when the activity is resumed. Calling this method will recreate the OpenGL display and resume the rendering thread. Must not be called before a renderer has been set. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("createRenderScriptGL", "(Landroid/renderscript/RenderScriptGL$SurfaceConfig;)Landroid/renderscript/Render" +
    "ScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.RenderScriptGL CreateRenderScriptGL(global::Android.Renderscripts.RenderScriptGL.SurfaceConfig sc) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.RenderScriptGL);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// destroyRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("destroyRenderScriptGL", "()V", AccessFlags = 1)]
				public virtual void DestroyRenderScriptGL() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSSurfaceView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				public virtual global::Android.Renderscripts.RenderScriptGL RenderScriptGL
				{
						[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.RenderScriptGL); }
						[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 The Texture View for a graphics renderscript (RenderScriptGL) to draw on.</para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/RSTextureView
		/// </java-name>
		[Dot42.DexImport("android/renderscript/RSTextureView", AccessFlags = 33)]
		public partial class RSTextureView : global::Android.Views.TextureView, global::Android.Views.TextureView.ISurfaceTextureListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Standard View constructor. In order to render something, you must call android.opengl.GLSurfaceView#setRenderer to register a renderer. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RSTextureView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Standard View constructor. In order to render something, you must call android.opengl.GLSurfaceView#setRenderer to register a renderer. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RSTextureView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onSurfaceTextureAvailable
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureAvailable(global::Android.Graphics.SurfaceTexture surface, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onSurfaceTextureSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureSizeChanged(global::Android.Graphics.SurfaceTexture surface, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onSurfaceTextureDestroyed
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", AccessFlags = 1)]
				public virtual bool OnSurfaceTextureDestroyed(global::Android.Graphics.SurfaceTexture surface) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onSurfaceTextureUpdated
				/// </java-name>
				[Dot42.DexImport("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 1)]
				public virtual void OnSurfaceTextureUpdated(global::Android.Graphics.SurfaceTexture surface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Inform the view that the activity is paused. The owner of this view must call this method when the activity is paused. Calling this method will pause the rendering thread. Must not be called before a renderer has been set. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Inform the view that the activity is resumed. The owner of this view must call this method when the activity is resumed. Calling this method will recreate the OpenGL display and resume the rendering thread. Must not be called before a renderer has been set. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Create a new RenderScriptGL object and attach it to the TextureView if present.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>RenderScriptGL The new object created. </para>
				/// </returns>
				/// <java-name>
				/// createRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("createRenderScriptGL", "(Landroid/renderscript/RenderScriptGL$SurfaceConfig;)Landroid/renderscript/Render" +
    "ScriptGL;", AccessFlags = 1)]
				public virtual global::Android.Renderscripts.RenderScriptGL CreateRenderScriptGL(global::Android.Renderscripts.RenderScriptGL.SurfaceConfig sc) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.RenderScriptGL);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Destroy the RenderScriptGL object associated with this TextureView. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// destroyRenderScriptGL
				/// </java-name>
				[Dot42.DexImport("destroyRenderScriptGL", "()V", AccessFlags = 1)]
				public virtual void DestroyRenderScriptGL() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSTextureView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>in API 16 Returns the previously set RenderScriptGL object.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>RenderScriptGL </para>
				/// </returns>
				/// <java-name>
				/// getRenderScriptGL
				/// </java-name>
				public virtual global::Android.Renderscripts.RenderScriptGL RenderScriptGL
				{
						[Dot42.DexImport("getRenderScriptGL", "()Landroid/renderscript/RenderScriptGL;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.RenderScriptGL); }
						[Dot42.DexImport("setRenderScriptGL", "(Landroid/renderscript/RenderScriptGL;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Sampler object that defines how Allocations can be read as textures within a kernel. Samplers are used in conjunction with the <c>rsSample </c> runtime function to return values from normalized coordinates.</para> <para>Any Allocation used with a Sampler must have been created with android.renderscript.Allocation#USAGE_GRAPHICS_TEXTURE; using a Sampler on an android.renderscript.Allocation that was not created with android.renderscript.Allocation#USAGE_GRAPHICS_TEXTURE is undefined. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Sampler
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Sampler", AccessFlags = 33)]
		public partial class Sampler : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Sampler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve a sampler with min and mag set to nearest and wrap modes set to clamp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_NEAREST
				/// </java-name>
				[Dot42.DexImport("CLAMP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler CLAMP_NEAREST(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para>Retrieve a sampler with min and mag set to linear and wrap modes set to clamp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler CLAMP_LINEAR(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para>Retrieve a sampler with mag set to linear, min linear mipmap linear, and wrap modes set to clamp.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler CLAMP_LINEAR_MIP_LINEAR(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para>Retrieve a sampler with min and mag set to nearest and wrap modes set to wrap.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("WRAP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler WRAP_NEAREST(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para>Retrieve a sampler with min and mag set to linear and wrap modes set to wrap.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler WRAP_LINEAR(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para>Retrieve a sampler with mag set to linear, min linear mipmap linear, and wrap modes set to wrap.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscripts.Sampler WRAP_LINEAR_MIP_LINEAR(global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Sampler);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>minification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMinification
				/// </java-name>
				public virtual global::Android.Renderscripts.Sampler.Value Minification
				{
						[Dot42.DexImport("getMinification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Sampler.Value); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>magnification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMagnification
				/// </java-name>
				public virtual global::Android.Renderscripts.Sampler.Value Magnification
				{
						[Dot42.DexImport("getMagnification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Sampler.Value); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>S wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapS
				/// </java-name>
				public virtual global::Android.Renderscripts.Sampler.Value WrapS
				{
						[Dot42.DexImport("getWrapS", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Sampler.Value); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>T wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapT
				/// </java-name>
				public virtual global::Android.Renderscripts.Sampler.Value WrapT
				{
						[Dot42.DexImport("getWrapT", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Sampler.Value); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>anisotropy setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getAnisotropy
				/// </java-name>
				public virtual float Anisotropy
				{
						[Dot42.DexImport("getAnisotropy", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Builder for creating non-standard samplers. This is only necessary if a Sampler with different min and mag modes is desired. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Sampler$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Sampler$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMinification
						/// </java-name>
						[Dot42.DexImport("setMinification", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetMinification(global::Android.Renderscripts.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMagnification
						/// </java-name>
						[Dot42.DexImport("setMagnification", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetMagnification(global::Android.Renderscripts.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapS
						/// </java-name>
						[Dot42.DexImport("setWrapS", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapS(global::Android.Renderscripts.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapT
						/// </java-name>
						[Dot42.DexImport("setWrapT", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapT(global::Android.Renderscripts.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setAnisotropy
						/// </java-name>
						[Dot42.DexImport("setAnisotropy", "(F)V", AccessFlags = 1)]
						public virtual void SetAnisotropy(float v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Sampler;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Sampler Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Sampler);
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

		/// <summary>
		///  <para>The parent class for all executable scripts. This should not be used by applications. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Script
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Script", AccessFlags = 33)]
		public partial class Script : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Script() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only to be used by generated reflected classes. </para>        
				/// </summary>
				/// <java-name>
				/// createKernelID
				/// </java-name>
				[Dot42.DexImport("createKernelID", "(IILandroid/renderscript/Element;Landroid/renderscript/Element;)Landroid/rendersc" +
    "ript/Script$KernelID;", AccessFlags = 4)]
				protected internal virtual global::Android.Renderscripts.Script.KernelID CreateKernelID(int slot, int sig, global::Android.Renderscripts.Element ein, global::Android.Renderscripts.Element eout) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Script.KernelID);
				}

				/// <summary>
				///  <para>Only to be used by generated reflected classes. </para>        
				/// </summary>
				/// <java-name>
				/// createFieldID
				/// </java-name>
				[Dot42.DexImport("createFieldID", "(ILandroid/renderscript/Element;)Landroid/renderscript/Script$FieldID;", AccessFlags = 4)]
				protected internal virtual global::Android.Renderscripts.Script.FieldID CreateFieldID(int slot, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.Script.FieldID);
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(I)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int slot, global::Android.Renderscripts.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(ILandroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/rend" +
    "erscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void ForEach(int slot, global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout, global::Android.Renderscripts.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// bindAllocation
				/// </java-name>
				[Dot42.DexImport("bindAllocation", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindAllocation(global::Android.Renderscripts.Allocation va, int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IF)V", AccessFlags = 1)]
				public virtual void SetVar(int index, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ID)V", AccessFlags = 1)]
				public virtual void SetVar(int index, double v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(II)V", AccessFlags = 1)]
				public virtual void SetVar(int index, int v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IJ)V", AccessFlags = 1)]
				public virtual void SetVar(int index, long v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IZ)V", AccessFlags = 1)]
				public virtual void SetVar(int index, bool v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscripts.BaseObj v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscripts.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/FieldPacker;Landroid/renderscript/Element;[I)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscripts.FieldPacker v, global::Android.Renderscripts.Element e, int[] dims) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(string timeZone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>    
				/// </summary>
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
						protected internal global::Android.Renderscripts.Element MElement;
						/// <java-name>
						/// mAllocation
						/// </java-name>
						[Dot42.DexImport("mAllocation", "Landroid/renderscript/Allocation;", AccessFlags = 4)]
						protected internal global::Android.Renderscripts.Allocation MAllocation;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal FieldBase() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// init
						/// </java-name>
						[Dot42.DexImport("init", "(Landroid/renderscript/RenderScript;I)V", AccessFlags = 4)]
						protected internal virtual void Init(global::Android.Renderscripts.RenderScript rs, int dimx) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// init
						/// </java-name>
						[Dot42.DexImport("init", "(Landroid/renderscript/RenderScript;II)V", AccessFlags = 4)]
						protected internal virtual void Init(global::Android.Renderscripts.RenderScript rs, int dimx, int usages) /* MethodBuilder.Create */ 
						{
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
						public virtual global::Android.Renderscripts.Element Element
						{
								[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.Element); }
						}

						/// <java-name>
						/// getType
						/// </java-name>
						public virtual global::Android.Renderscripts.Type Type
						{
								[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.Type); }
						}

						/// <java-name>
						/// getAllocation
						/// </java-name>
						public virtual global::Android.Renderscripts.Allocation Allocation
						{
								[Dot42.DexImport("getAllocation", "()Landroid/renderscript/Allocation;", AccessFlags = 1)]
								get{ return default(global::Android.Renderscripts.Allocation); }
						}

				}

				/// <summary>
				///  <para>Only intended for use by generated reflected code. </para>    
				/// </summary>
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

				/// <summary>
				///  <para>FieldID is an identifier for a Script + exported field pair. It is used as an identifier for ScriptGroup creation.</para> <para>This class should not be directly created. Instead use the method in the reflected or intrinsic code "getFieldID_funcname()". </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Script$FieldID
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$FieldID", AccessFlags = 25)]
				public sealed partial class FieldID : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal FieldID() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>KernelID is an identifier for a Script + root function pair. It is used as an identifier for ScriptGroup creation.</para> <para>This class should not be directly created. Instead use the method in the reflected or intrinsic code "getKernelID_funcname()". </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Script$KernelID
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$KernelID", AccessFlags = 25)]
				public sealed partial class KernelID : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal KernelID() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>The superclass for all user-defined scripts. This is only intended to be used by the generated derived classes. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptC
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptC", AccessFlags = 33)]
		public partial class ScriptC : global::Android.Renderscripts.Script
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Only intended for use by the generated derived classes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILandroid/renderscript/RenderScript;)V", AccessFlags = 4)]
				protected internal ScriptC(int id, global::Android.Renderscripts.RenderScript rs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only intended for use by the generated derived classes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)V", AccessFlags = 4)]
				protected internal ScriptC(global::Android.Renderscripts.RenderScript rs, global::Android.Content.Res.Resources resources, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScriptC() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>ScriptGroup creates a group of kernels that are executed together with one execution call as if they were a single kernel. The kernels may be connected internally or to an external allocation. The intermediate results for internal connections are not observable after the execution of the script. </para> <para>External connections are grouped into inputs and outputs. All outputs are produced by a script kernel and placed into a user-supplied allocation. Inputs provide the input of a kernel. Inputs bound to script globals are set directly upon the script. </para> <para>A ScriptGroup must contain at least one kernel. A ScriptGroup must contain only a single directed acyclic graph (DAG) of script kernels and connections. Attempting to create a ScriptGroup with multiple DAGs or attempting to create a cycle within a ScriptGroup will throw an exception. </para> <para>Currently, all kernels in a ScriptGroup must be from separate Script objects. Attempting to use multiple kernels from the same Script object will result in an android.renderscript.RSInvalidStateException. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptGroup
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptGroup", AccessFlags = 49)]
		public sealed partial class ScriptGroup : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets an input of the ScriptGroup. This specifies an Allocation to be used for kernels that require an input Allocation provided from outside of the ScriptGroup.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscripts.Script.KernelID s, global::Android.Renderscripts.Allocation a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets an output of the ScriptGroup. This specifies an Allocation to be used for the kernels that require an output Allocation visible after the ScriptGroup is executed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetOutput(global::Android.Renderscripts.Script.KernelID s, global::Android.Renderscripts.Allocation a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Execute the ScriptGroup. This will run all the kernels in the ScriptGroup. No internal connection results will be visible after execution of the ScriptGroup. </para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1)]
				public void Execute() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper class to build a ScriptGroup. A ScriptGroup is created in two steps. </para> <para>First, all kernels to be used by the ScriptGroup should be added. </para> <para>Second, add connections between kernels. There are two types of connections: kernel to kernel and kernel to field. Kernel to kernel allows a kernel's output to be passed to another kernel as input. Kernel to field allows the output of one kernel to be bound as a script global. Kernel to kernel is higher performance and should be used where possible. </para> <para>A ScriptGroup must contain a single directed acyclic graph (DAG); it cannot contain cycles. Currently, all kernels used in a ScriptGroup must come from different Script objects. Additionally, all kernels in a ScriptGroup must have at least one input, output, or internal connection. </para> <para>Once all connections are made, a call to create will return the ScriptGroup object. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ScriptGroup$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ScriptGroup$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Adds a Kernel to the group.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Builder Returns this. </para>
						/// </returns>
						/// <java-name>
						/// addKernel
						/// </java-name>
						[Dot42.DexImport("addKernel", "(Landroid/renderscript/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder" +
    ";", AccessFlags = 1)]
						public Builder AddKernel(global::Android.Renderscripts.Script.KernelID k) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addConnection
						/// </java-name>
						[Dot42.DexImport("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/render" +
    "script/Script$FieldID;)Landroid/renderscript/ScriptGroup$Builder;", AccessFlags = 1)]
						public Builder AddConnection(global::Android.Renderscripts.Type type, global::Android.Renderscripts.Script.KernelID kernelID, global::Android.Renderscripts.Script.FieldID fieldID) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addConnection
						/// </java-name>
						[Dot42.DexImport("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/render" +
    "script/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder;", AccessFlags = 1)]
						public Builder AddConnection(global::Android.Renderscripts.Type type, global::Android.Renderscripts.Script.KernelID kernelID, global::Android.Renderscripts.Script.KernelID kernelID1) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates the Script group.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>ScriptGroup The new ScriptGroup </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ScriptGroup;", AccessFlags = 1)]
						public global::Android.Renderscripts.ScriptGroup Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.ScriptGroup);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Base class for all Intrinsic scripts. An intrinsic a script which implements a pre-defined function. Intrinsics are provided to provide effecient implemtations of common operations.</para> <para>Not intended for direct use. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsic
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsic", AccessFlags = 1057)]
		public abstract partial class ScriptIntrinsic : global::Android.Renderscripts.Script
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsic() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Intrinsic kernels for blending two android.renderscript.Allocation objects. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicBlend
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicBlend", AccessFlags = 33)]
		public partial class ScriptIntrinsicBlend : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicBlend() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Supported elements types are Element#U8_4</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicBlend </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicBlend;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicBlend Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicBlend);
				}

				/// <summary>
				///  <para>Sets dst = {0, 0, 0, 0}</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachClear
				/// </java-name>
				[Dot42.DexImport("forEachClear", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachClear(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = src</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrc
				/// </java-name>
				[Dot42.DexImport("forEachSrc", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrc(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = dst</para> <para>This is a NOP.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDst
				/// </java-name>
				[Dot42.DexImport("forEachDst", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDst(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = src + dst * (1.0 - src.a)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcOver
				/// </java-name>
				[Dot42.DexImport("forEachSrcOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcOver(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = dst + src * (1.0 - dst.a)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstOver
				/// </java-name>
				[Dot42.DexImport("forEachDstOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstOver(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = src * dst.a</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcIn
				/// </java-name>
				[Dot42.DexImport("forEachSrcIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcIn(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = dst * src.a</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstIn
				/// </java-name>
				[Dot42.DexImport("forEachDstIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstIn(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = src * (1.0 - dst.a)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcOut
				/// </java-name>
				[Dot42.DexImport("forEachSrcOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcOut(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = dst * (1.0 - src.a)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstOut
				/// </java-name>
				[Dot42.DexImport("forEachDstOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstOut(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>dst.rgb = src.rgb * dst.a + (1.0 - src.a) * dst.rgb dst.a = dst.a</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcAtop
				/// </java-name>
				[Dot42.DexImport("forEachSrcAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcAtop(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>dst = dst.rgb * src.a + (1.0 - dst.a) * src.rgb dst.a = src.a</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstAtop
				/// </java-name>
				[Dot42.DexImport("forEachDstAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstAtop(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = {src.r ^ dst.r, src.g ^ dst.g, src.b ^ dst.b, src.a ^ dst.a}</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachXor
				/// </java-name>
				[Dot42.DexImport("forEachXor", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachXor(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = src * dst</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachMultiply
				/// </java-name>
				[Dot42.DexImport("forEachMultiply", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachMultiply(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = min(src + dst, 1.0)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachAdd
				/// </java-name>
				[Dot42.DexImport("forEachAdd", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachAdd(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets dst = max(dst - src, 0.0)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSubtract
				/// </java-name>
				[Dot42.DexImport("forEachSubtract", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSubtract(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for the Clear kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDClear
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDClear
				{
						[Dot42.DexImport("getKernelIDClear", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Src kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrc
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSrc
				{
						[Dot42.DexImport("getKernelIDSrc", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Dst kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDst
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDDst
				{
						[Dot42.DexImport("getKernelIDDst", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the SrcOver kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOver
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSrcOver
				{
						[Dot42.DexImport("getKernelIDSrcOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the DstOver kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOver
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDDstOver
				{
						[Dot42.DexImport("getKernelIDDstOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the SrcIn kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcIn
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSrcIn
				{
						[Dot42.DexImport("getKernelIDSrcIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the DstIn kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstIn
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDDstIn
				{
						[Dot42.DexImport("getKernelIDDstIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the SrcOut kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOut
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSrcOut
				{
						[Dot42.DexImport("getKernelIDSrcOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the DstOut kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOut
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDDstOut
				{
						[Dot42.DexImport("getKernelIDDstOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the SrcAtop kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcAtop
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSrcAtop
				{
						[Dot42.DexImport("getKernelIDSrcAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the DstAtop kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstAtop
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDDstAtop
				{
						[Dot42.DexImport("getKernelIDDstAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Xor kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDXor
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDXor
				{
						[Dot42.DexImport("getKernelIDXor", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Multiply kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDMultiply
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDMultiply
				{
						[Dot42.DexImport("getKernelIDMultiply", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Add kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDAdd
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDAdd
				{
						[Dot42.DexImport("getKernelIDAdd", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a KernelID for the Subtract kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSubtract
				/// </java-name>
				public virtual global::Android.Renderscripts.Script.KernelID KernelIDSubtract
				{
						[Dot42.DexImport("getKernelIDSubtract", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic Gausian blur filter. Applies a gaussian blur of the specified radius to all elements of an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicBlur
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicBlur", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicBlur : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicBlur() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an intrinsic for applying a blur to an allocation. The default radius is 5.0.</para> <para>Supported elements types are Element#U8_4</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicBlur </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicBlur;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicBlur Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicBlur);
				}

				/// <summary>
				///  <para>Set the input of the blur. Must match the element type supplied during create.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscripts.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the radius of the Blur.</para> <para>Supported range 0 &lt; radius &lt;= 25</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRadius
				/// </java-name>
				[Dot42.DexImport("setRadius", "(F)V", AccessFlags = 1)]
				public void SetRadius(float radius) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply the filter to the input and save to the specified allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a FieldID for the input field of this intrinsic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscripts.Script.FieldID FieldID_Input
				{
						[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.FieldID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic for applying a color matrix to allocations.</para> <para>If the element type is Element.DataType#UNSIGNED_8, it is converted to Element.DataType#FLOAT_32 and normalized from (0-255) to (0-1). If the incoming vector size is less than four, a Element#F32_4 is created by filling the missing vector channels with zero. This value is then multiplied by the 4x4 color matrix as performed by rsMatrixMultiply(), adding a Element#F32_4, and then writing it to the output Allocation.</para> <para>If the ouptut type is unsigned, the value is normalized from (0-1) to (0-255) and converted. If the output vector size is less than four, the unused channels are discarded.</para> <para>Supported elements types are Element#U8, Element#U8_2, Element#U8_3, Element#U8_4, Element#F32, Element#F32_2, Element#F32_3, and Element#F32_4. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicColorMatrix
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicColorMatrix", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicColorMatrix : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicColorMatrix() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an intrinsic for applying a color matrix to an allocation.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the single argument version as Element is now ignored.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicColorMatrix </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicColorMatrix;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicColorMatrix Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicColorMatrix);
				}

				/// <summary>
				///  <para>Set the color matrix which will be applied to each cell of the image.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setColorMatrix
				/// </java-name>
				[Dot42.DexImport("setColorMatrix", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public void SetColorMatrix(global::Android.Renderscripts.Matrix4f m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the color matrix which will be applied to each cell of the image.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setColorMatrix
				/// </java-name>
				[Dot42.DexImport("setColorMatrix", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public void SetColorMatrix(global::Android.Renderscripts.Matrix3f m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a color matrix to convert from RGB to luminance. The alpha channel will be a copy. </para>        
				/// </summary>
				/// <java-name>
				/// setGreyscale
				/// </java-name>
				[Dot42.DexImport("setGreyscale", "()V", AccessFlags = 1)]
				public void SetGreyscale() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to convert from YUV to RGB with a direct copy of the 4th channel. </para>        
				/// </summary>
				/// <java-name>
				/// setYUVtoRGB
				/// </java-name>
				[Dot42.DexImport("setYUVtoRGB", "()V", AccessFlags = 1)]
				public void SetYUVtoRGB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the matrix to convert from RGB to YUV with a direct copy of the 4th channel. </para>        
				/// </summary>
				/// <java-name>
				/// setRGBtoYUV
				/// </java-name>
				[Dot42.DexImport("setRGBtoYUV", "()V", AccessFlags = 1)]
				public void SetRGBtoYUV() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoke the kernel and apply the matrix to each cell of input Allocation and copy to the output Allocation.</para> <para>If the vector size of the input is less than four, the remaining components are treated as zero for the matrix multiply.</para> <para>If the output vector size is less than four, the unused vector components are discarded.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic for applying a 3x3 convolve to an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicConvolve3x3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicConvolve3x3", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicConvolve3x3 : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicConvolve3x3() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Supported elements types are Element#U8, Element#U8_2, Element#U8_3, Element#U8_4, Element#F32, Element#F32_2, Element#F32_3, and Element#F32_4</para> <para>The default coefficients are.</para> <para> <code> </code></para> <para> <code> [ 0, 0, 0 ] </code></para> <para> <code> [ 0, 1, 0 ] </code></para> <para> <code> [ 0, 0, 0 ] </code></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicConvolve3x3 </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicConvolve3x3;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicConvolve3x3 Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicConvolve3x3);
				}

				/// <summary>
				///  <para>Set the input of the blur. Must match the element type supplied during create.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscripts.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the coefficients for the convolve.</para> <para>The convolve layout is  <code> </code></para> <para> <code> [ 0, 1, 2 ] </code></para> <para> <code> [ 3, 4, 5 ] </code></para> <para> <code> [ 6, 7, 8 ] </code></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCoefficients
				/// </java-name>
				[Dot42.DexImport("setCoefficients", "([F)V", AccessFlags = 1)]
				public void SetCoefficients(float[] v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply the filter to the input and save to the specified allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a FieldID for the input field of this intrinsic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscripts.Script.FieldID FieldID_Input
				{
						[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.FieldID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic for applying a 5x5 convolve to an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicConvolve5x5
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicConvolve5x5", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicConvolve5x5 : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicConvolve5x5() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Supported elements types are Element#U8, Element#U8_2, Element#U8_3, Element#U8_4, Element#F32, Element#F32_2, Element#F32_3, and Element#F32_4</para> <para>The default coefficients are.  <code> </code></para> <para> <code> [ 0, 0, 0, 0, 0 ] </code></para> <para> <code> [ 0, 0, 0, 0, 0 ] </code></para> <para> <code> [ 0, 0, 1, 0, 0 ] </code></para> <para> <code> [ 0, 0, 0, 0, 0 ] </code></para> <para> <code> [ 0, 0, 0, 0, 0 ] </code></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicConvolve5x5 </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicConvolve5x5;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicConvolve5x5 Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicConvolve5x5);
				}

				/// <summary>
				///  <para>Set the input of the blur. Must match the element type supplied during create.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscripts.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the coefficients for the convolve.</para> <para>The convolve layout is  <code> </code></para> <para> <code> [ 0, 1, 2, 3, 4 ] </code></para> <para> <code> [ 5, 6, 7, 8, 9 ] </code></para> <para> <code> [ 10, 11, 12, 13, 14 ] </code></para> <para> <code> [ 15, 16, 17, 18, 19 ] </code></para> <para> <code> [ 20, 21, 22, 23, 24 ] </code></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCoefficients
				/// </java-name>
				[Dot42.DexImport("setCoefficients", "([F)V", AccessFlags = 1)]
				public void SetCoefficients(float[] v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply the filter to the input and save to the specified allocation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a FieldID for the input field of this intrinsic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscripts.Script.FieldID FieldID_Input
				{
						[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.FieldID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic for applying a per-channel lookup table. Each channel of the input has an independant lookup table. The tables are 256 entries in size and can cover the full value range of Element#U8_4. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicLUT
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicLUT", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicLUT : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicLUT() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Supported elements types are Element#U8_4</para> <para>The defaults tables are identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicLUT </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicLUT;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicLUT Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicLUT);
				}

				/// <summary>
				///  <para>Set an entry in the red channel lookup table</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRed
				/// </java-name>
				[Dot42.DexImport("setRed", "(II)V", AccessFlags = 1)]
				public void SetRed(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an entry in the green channel lookup table</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setGreen
				/// </java-name>
				[Dot42.DexImport("setGreen", "(II)V", AccessFlags = 1)]
				public void SetGreen(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an entry in the blue channel lookup table</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBlue
				/// </java-name>
				[Dot42.DexImport("setBlue", "(II)V", AccessFlags = 1)]
				public void SetBlue(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an entry in the alpha channel lookup table</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(II)V", AccessFlags = 1)]
				public void SetAlpha(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoke the kernel and apply the lookup to each cell of ain and copy to aout.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation ain, global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

		}

		/// <summary>
		///  <para>Intrinsic for converting an Android YUV buffer to RGB.</para> <para>The input allocation should be supplied in a supported YUV format as a YUV element Allocation. The output is RGBA; the alpha channel will be set to 255. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicYuvToRGB
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicYuvToRGB", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicYuvToRGB : global::Android.Renderscripts.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicYuvToRGB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an intrinsic for converting YUV to RGB.</para> <para>Supported elements types are Element#U8_4</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ScriptIntrinsicYuvToRGB </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicYuvToRGB;", AccessFlags = 9)]
				public static global::Android.Renderscripts.ScriptIntrinsicYuvToRGB Create(global::Android.Renderscripts.RenderScript rs, global::Android.Renderscripts.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscripts.ScriptIntrinsicYuvToRGB);
				}

				/// <summary>
				///  <para>Set the input yuv allocation, must be Element#U8.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscripts.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convert the image to RGB.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscripts.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a KernelID for this intrinsic kernel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscripts.Script.KernelID KernelID
				{
						[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.KernelID); }
				}

				/// <summary>
				///  <para>Get a FieldID for the input field of this intrinsic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscripts.Script.FieldID FieldID_Input
				{
						[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Script.FieldID); }
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript Short2 type back to the Android system. </para>    
		/// </summary>
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
				public Short2(short initX, short initY) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript short3 type back to the Android system. </para>    
		/// </summary>
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
				public Short3(short initX, short initY, short initZ) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Class for exposing the native RenderScript short4 type back to the Android system. </para>    
		/// </summary>
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
				public Short4(short initX, short initY, short initZ, short initW) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A Type describes the android.renderscript.Element and dimensions used for an android.renderscript.Allocation or a parallel operation. Types are created through android.renderscript.Type.Builder.</para> <para>A Type always includes an android.renderscript.Element and an X dimension. A Type may be multidimensional, up to three dimensions. A nonzero value in the Y or Z dimensions indicates that the dimension is present. Note that a Type with only a given X dimension and a Type with the same X dimension but Y = 1 are not equivalent.</para> <para>A Type also supports inclusion of level of detail (LOD) or cube map faces. LOD and cube map faces are booleans to indicate present or not present. </para> <para>A Type also supports YUV format information to support an android.renderscript.Allocation in a YUV format. The YUV formats supported are android.graphics.ImageFormat#YV12, android.graphics.ImageFormat#NV21, and android.graphics.ImageFormat#YUV_420_888</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating an application that uses RenderScript, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Type
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Type", AccessFlags = 33)]
		public partial class Type : global::Android.Renderscripts.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Type() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the element associated with this Type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				public virtual global::Android.Renderscripts.Element Element
				{
						[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						get{ return default(global::Android.Renderscripts.Element); }
				}

				/// <summary>
				///  <para>Return the value of the X dimension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public virtual int X
				{
						[Dot42.DexImport("getX", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the value of the Y dimension or 0 for a 1D allocation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public virtual int Y
				{
						[Dot42.DexImport("getY", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the value of the Z dimension or 0 for a 1D or 2D allocation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				public virtual int Z
				{
						[Dot42.DexImport("getZ", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return if the Type has a mipmap chain.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// hasMipmaps
				/// </java-name>
				public virtual bool HasMipmaps
				{
						[Dot42.DexImport("hasMipmaps", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return if the Type is a cube map.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// hasFaces
				/// </java-name>
				public virtual bool HasFaces
				{
						[Dot42.DexImport("hasFaces", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the total number of accessable cells in the Type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int </para>
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
				///  <para>Builder class for Type. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Type$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Type$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscripts.RenderScript renderScript, global::Android.Renderscripts.Element element) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Add a dimension to the Type.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setX
						/// </java-name>
						[Dot42.DexImport("setX", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetX(int value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setY
						/// </java-name>
						[Dot42.DexImport("setY", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetY(int value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMipmaps
						/// </java-name>
						[Dot42.DexImport("setMipmaps", "(Z)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetMipmaps(bool value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setFaces
						/// </java-name>
						[Dot42.DexImport("setFaces", "(Z)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetFaces(bool value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Validate structure and create a new Type.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Type </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						public virtual global::Android.Renderscripts.Type Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscripts.Type);
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

