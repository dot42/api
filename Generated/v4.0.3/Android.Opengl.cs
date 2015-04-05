#pragma warning disable 1717
namespace Android.Opengl
{
		/// <java-name>
		/// android/opengl/ETC1
		/// </java-name>
		[Dot42.DexImport("android/opengl/ETC1", AccessFlags = 33)]
		public partial class ETC1
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ENCODED_BLOCK_SIZE
				/// </java-name>
				[Dot42.DexImport("ENCODED_BLOCK_SIZE", "I", AccessFlags = 25)]
				public const int ENCODED_BLOCK_SIZE = 8;
				/// <java-name>
				/// DECODED_BLOCK_SIZE
				/// </java-name>
				[Dot42.DexImport("DECODED_BLOCK_SIZE", "I", AccessFlags = 25)]
				public const int DECODED_BLOCK_SIZE = 48;
				/// <java-name>
				/// ETC_PKM_HEADER_SIZE
				/// </java-name>
				[Dot42.DexImport("ETC_PKM_HEADER_SIZE", "I", AccessFlags = 25)]
				public const int ETC_PKM_HEADER_SIZE = 16;
				/// <java-name>
				/// ETC1_RGB8_OES
				/// </java-name>
				[Dot42.DexImport("ETC1_RGB8_OES", "I", AccessFlags = 25)]
				public const int ETC1_RGB8_OES = 36196;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ETC1() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// encodeBlock
				/// </java-name>
				[Dot42.DexImport("encodeBlock", "(Ljava/nio/Buffer;ILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void EncodeBlock(global::Java.Nio.Buffer buffer, int int32, global::Java.Nio.Buffer buffer1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decodeBlock
				/// </java-name>
				[Dot42.DexImport("decodeBlock", "(Ljava/nio/Buffer;Ljava/nio/Buffer;)V", AccessFlags = 265)]
				public static void DecodeBlock(global::Java.Nio.Buffer buffer, global::Java.Nio.Buffer buffer1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncodedDataSize
				/// </java-name>
				[Dot42.DexImport("getEncodedDataSize", "(II)I", AccessFlags = 265)]
				public static int GetEncodedDataSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// encodeImage
				/// </java-name>
				[Dot42.DexImport("encodeImage", "(Ljava/nio/Buffer;IIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void EncodeImage(global::Java.Nio.Buffer buffer, int int32, int int321, int int322, int int323, global::Java.Nio.Buffer buffer1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decodeImage
				/// </java-name>
				[Dot42.DexImport("decodeImage", "(Ljava/nio/Buffer;Ljava/nio/Buffer;IIII)V", AccessFlags = 265)]
				public static void DecodeImage(global::Java.Nio.Buffer buffer, global::Java.Nio.Buffer buffer1, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Ljava/nio/Buffer;II)V", AccessFlags = 265)]
				public static void FormatHeader(global::Java.Nio.Buffer buffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "(Ljava/nio/Buffer;)Z", AccessFlags = 265)]
				public static bool IsValid(global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "(Ljava/nio/Buffer;)I", AccessFlags = 265)]
				public static int GetWidth(global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "(Ljava/nio/Buffer;)I", AccessFlags = 265)]
				public static int GetHeight(global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/opengl/ETC1Util
		/// </java-name>
		[Dot42.DexImport("android/opengl/ETC1Util", AccessFlags = 33)]
		public partial class ETC1Util
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ETC1Util() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadTexture
				/// </java-name>
				[Dot42.DexImport("loadTexture", "(IIIIILjava/io/InputStream;)V", AccessFlags = 9)]
				public static void LoadTexture(int int32, int int321, int int322, int int323, int int324, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadTexture
				/// </java-name>
				[Dot42.DexImport("loadTexture", "(IIIIILandroid/opengl/ETC1Util$ETC1Texture;)V", AccessFlags = 9)]
				public static void LoadTexture(int int32, int int321, int int322, int int323, int int324, global::Android.Opengl.ETC1Util.ETC1Texture eTC1Texture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createTexture
				/// </java-name>
				[Dot42.DexImport("createTexture", "(Ljava/io/InputStream;)Landroid/opengl/ETC1Util$ETC1Texture;", AccessFlags = 9)]
				public static global::Android.Opengl.ETC1Util.ETC1Texture CreateTexture(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Opengl.ETC1Util.ETC1Texture);
				}

				/// <java-name>
				/// compressTexture
				/// </java-name>
				[Dot42.DexImport("compressTexture", "(Ljava/nio/Buffer;IIII)Landroid/opengl/ETC1Util$ETC1Texture;", AccessFlags = 9)]
				public static global::Android.Opengl.ETC1Util.ETC1Texture CompressTexture(global::Java.Nio.Buffer buffer, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Opengl.ETC1Util.ETC1Texture);
				}

				/// <java-name>
				/// writeTexture
				/// </java-name>
				[Dot42.DexImport("writeTexture", "(Landroid/opengl/ETC1Util$ETC1Texture;Ljava/io/OutputStream;)V", AccessFlags = 9)]
				public static void WriteTexture(global::Android.Opengl.ETC1Util.ETC1Texture eTC1Texture, global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isETC1Supported
				/// </java-name>
				public static bool IsETC1Supported
				{
						[Dot42.DexImport("isETC1Supported", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/opengl/ETC1Util$ETC1Texture
				/// </java-name>
				[Dot42.DexImport("android/opengl/ETC1Util$ETC1Texture", AccessFlags = 9)]
				public partial class ETC1Texture
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(IILjava/nio/ByteBuffer;)V", AccessFlags = 1)]
						public ETC1Texture(int int32, int int321, global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ETC1Texture() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getWidth
						/// </java-name>
						public virtual int Width
						{
								[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getHeight
						/// </java-name>
						public virtual int Height
						{
								[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getData
						/// </java-name>
						public virtual global::Java.Nio.ByteBuffer Data
						{
								[Dot42.DexImport("getData", "()Ljava/nio/ByteBuffer;", AccessFlags = 1)]
								get{ return default(global::Java.Nio.ByteBuffer); }
						}

				}

		}

		/// <java-name>
		/// android/opengl/GLDebugHelper
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLDebugHelper", AccessFlags = 33)]
		public partial class GLDebugHelper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONFIG_CHECK_GL_ERROR
				/// </java-name>
				[Dot42.DexImport("CONFIG_CHECK_GL_ERROR", "I", AccessFlags = 25)]
				public const int CONFIG_CHECK_GL_ERROR = 1;
				/// <java-name>
				/// CONFIG_CHECK_THREAD
				/// </java-name>
				[Dot42.DexImport("CONFIG_CHECK_THREAD", "I", AccessFlags = 25)]
				public const int CONFIG_CHECK_THREAD = 2;
				/// <java-name>
				/// CONFIG_LOG_ARGUMENT_NAMES
				/// </java-name>
				[Dot42.DexImport("CONFIG_LOG_ARGUMENT_NAMES", "I", AccessFlags = 25)]
				public const int CONFIG_LOG_ARGUMENT_NAMES = 4;
				/// <java-name>
				/// ERROR_WRONG_THREAD
				/// </java-name>
				[Dot42.DexImport("ERROR_WRONG_THREAD", "I", AccessFlags = 25)]
				public const int ERROR_WRONG_THREAD = 28672;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLDebugHelper() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljavax/microedition/khronos/opengles/GL;ILjava/io/Writer;)Ljavax/microedition/kh" +
    "ronos/opengles/GL;", AccessFlags = 9)]
				public static global::Javax.Microedition.Khronos.Opengles.IGL Wrap(global::Javax.Microedition.Khronos.Opengles.IGL gL, int int32, global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Microedition.Khronos.Opengles.IGL);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljavax/microedition/khronos/egl/EGL;ILjava/io/Writer;)Ljavax/microedition/khrono" +
    "s/egl/EGL;", AccessFlags = 9)]
				public static global::Javax.Microedition.Khronos.Egl.IEGL Wrap(global::Javax.Microedition.Khronos.Egl.IEGL eGL, int int32, global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Microedition.Khronos.Egl.IEGL);
				}

		}

		/// <java-name>
		/// android/opengl/GLES10
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLES10", AccessFlags = 33)]
		public partial class GLES10
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_ADD
				/// </java-name>
				[Dot42.DexImport("GL_ADD", "I", AccessFlags = 25)]
				public const int GL_ADD = 260;
				/// <java-name>
				/// GL_ALIASED_LINE_WIDTH_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_ALIASED_LINE_WIDTH_RANGE", "I", AccessFlags = 25)]
				public const int GL_ALIASED_LINE_WIDTH_RANGE = 33902;
				/// <java-name>
				/// GL_ALIASED_POINT_SIZE_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_ALIASED_POINT_SIZE_RANGE", "I", AccessFlags = 25)]
				public const int GL_ALIASED_POINT_SIZE_RANGE = 33901;
				/// <java-name>
				/// GL_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ALPHA = 6406;
				/// <java-name>
				/// GL_ALPHA_BITS
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_BITS", "I", AccessFlags = 25)]
				public const int GL_ALPHA_BITS = 3413;
				/// <java-name>
				/// GL_ALPHA_TEST
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_TEST", "I", AccessFlags = 25)]
				public const int GL_ALPHA_TEST = 3008;
				/// <java-name>
				/// GL_ALWAYS
				/// </java-name>
				[Dot42.DexImport("GL_ALWAYS", "I", AccessFlags = 25)]
				public const int GL_ALWAYS = 519;
				/// <java-name>
				/// GL_AMBIENT
				/// </java-name>
				[Dot42.DexImport("GL_AMBIENT", "I", AccessFlags = 25)]
				public const int GL_AMBIENT = 4608;
				/// <java-name>
				/// GL_AMBIENT_AND_DIFFUSE
				/// </java-name>
				[Dot42.DexImport("GL_AMBIENT_AND_DIFFUSE", "I", AccessFlags = 25)]
				public const int GL_AMBIENT_AND_DIFFUSE = 5634;
				/// <java-name>
				/// GL_AND
				/// </java-name>
				[Dot42.DexImport("GL_AND", "I", AccessFlags = 25)]
				public const int GL_AND = 5377;
				/// <java-name>
				/// GL_AND_INVERTED
				/// </java-name>
				[Dot42.DexImport("GL_AND_INVERTED", "I", AccessFlags = 25)]
				public const int GL_AND_INVERTED = 5380;
				/// <java-name>
				/// GL_AND_REVERSE
				/// </java-name>
				[Dot42.DexImport("GL_AND_REVERSE", "I", AccessFlags = 25)]
				public const int GL_AND_REVERSE = 5378;
				/// <java-name>
				/// GL_BACK
				/// </java-name>
				[Dot42.DexImport("GL_BACK", "I", AccessFlags = 25)]
				public const int GL_BACK = 1029;
				/// <java-name>
				/// GL_BLEND
				/// </java-name>
				[Dot42.DexImport("GL_BLEND", "I", AccessFlags = 25)]
				public const int GL_BLEND = 3042;
				/// <java-name>
				/// GL_BLUE_BITS
				/// </java-name>
				[Dot42.DexImport("GL_BLUE_BITS", "I", AccessFlags = 25)]
				public const int GL_BLUE_BITS = 3412;
				/// <java-name>
				/// GL_BYTE
				/// </java-name>
				[Dot42.DexImport("GL_BYTE", "I", AccessFlags = 25)]
				public const int GL_BYTE = 5120;
				/// <java-name>
				/// GL_CCW
				/// </java-name>
				[Dot42.DexImport("GL_CCW", "I", AccessFlags = 25)]
				public const int GL_CCW = 2305;
				/// <java-name>
				/// GL_CLAMP_TO_EDGE
				/// </java-name>
				[Dot42.DexImport("GL_CLAMP_TO_EDGE", "I", AccessFlags = 25)]
				public const int GL_CLAMP_TO_EDGE = 33071;
				/// <java-name>
				/// GL_CLEAR
				/// </java-name>
				[Dot42.DexImport("GL_CLEAR", "I", AccessFlags = 25)]
				public const int GL_CLEAR = 5376;
				/// <java-name>
				/// GL_COLOR_ARRAY
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY = 32886;
				/// <java-name>
				/// GL_COLOR_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_COLOR_BUFFER_BIT = 16384;
				/// <java-name>
				/// GL_COLOR_LOGIC_OP
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_LOGIC_OP", "I", AccessFlags = 25)]
				public const int GL_COLOR_LOGIC_OP = 3058;
				/// <java-name>
				/// GL_COLOR_MATERIAL
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_MATERIAL", "I", AccessFlags = 25)]
				public const int GL_COLOR_MATERIAL = 2903;
				/// <java-name>
				/// GL_COMPRESSED_TEXTURE_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_COMPRESSED_TEXTURE_FORMATS", "I", AccessFlags = 25)]
				public const int GL_COMPRESSED_TEXTURE_FORMATS = 34467;
				/// <java-name>
				/// GL_CONSTANT_ATTENUATION
				/// </java-name>
				[Dot42.DexImport("GL_CONSTANT_ATTENUATION", "I", AccessFlags = 25)]
				public const int GL_CONSTANT_ATTENUATION = 4615;
				/// <java-name>
				/// GL_COPY
				/// </java-name>
				[Dot42.DexImport("GL_COPY", "I", AccessFlags = 25)]
				public const int GL_COPY = 5379;
				/// <java-name>
				/// GL_COPY_INVERTED
				/// </java-name>
				[Dot42.DexImport("GL_COPY_INVERTED", "I", AccessFlags = 25)]
				public const int GL_COPY_INVERTED = 5388;
				/// <java-name>
				/// GL_CULL_FACE
				/// </java-name>
				[Dot42.DexImport("GL_CULL_FACE", "I", AccessFlags = 25)]
				public const int GL_CULL_FACE = 2884;
				/// <java-name>
				/// GL_CW
				/// </java-name>
				[Dot42.DexImport("GL_CW", "I", AccessFlags = 25)]
				public const int GL_CW = 2304;
				/// <java-name>
				/// GL_DECAL
				/// </java-name>
				[Dot42.DexImport("GL_DECAL", "I", AccessFlags = 25)]
				public const int GL_DECAL = 8449;
				/// <java-name>
				/// GL_DECR
				/// </java-name>
				[Dot42.DexImport("GL_DECR", "I", AccessFlags = 25)]
				public const int GL_DECR = 7683;
				/// <java-name>
				/// GL_DEPTH_BITS
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_BITS", "I", AccessFlags = 25)]
				public const int GL_DEPTH_BITS = 3414;
				/// <java-name>
				/// GL_DEPTH_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_DEPTH_BUFFER_BIT = 256;
				/// <java-name>
				/// GL_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_TEST", "I", AccessFlags = 25)]
				public const int GL_DEPTH_TEST = 2929;
				/// <java-name>
				/// GL_DIFFUSE
				/// </java-name>
				[Dot42.DexImport("GL_DIFFUSE", "I", AccessFlags = 25)]
				public const int GL_DIFFUSE = 4609;
				/// <java-name>
				/// GL_DITHER
				/// </java-name>
				[Dot42.DexImport("GL_DITHER", "I", AccessFlags = 25)]
				public const int GL_DITHER = 3024;
				/// <java-name>
				/// GL_DONT_CARE
				/// </java-name>
				[Dot42.DexImport("GL_DONT_CARE", "I", AccessFlags = 25)]
				public const int GL_DONT_CARE = 4352;
				/// <java-name>
				/// GL_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_DST_ALPHA = 772;
				/// <java-name>
				/// GL_DST_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_DST_COLOR", "I", AccessFlags = 25)]
				public const int GL_DST_COLOR = 774;
				/// <java-name>
				/// GL_EMISSION
				/// </java-name>
				[Dot42.DexImport("GL_EMISSION", "I", AccessFlags = 25)]
				public const int GL_EMISSION = 5632;
				/// <java-name>
				/// GL_EQUAL
				/// </java-name>
				[Dot42.DexImport("GL_EQUAL", "I", AccessFlags = 25)]
				public const int GL_EQUAL = 514;
				/// <java-name>
				/// GL_EQUIV
				/// </java-name>
				[Dot42.DexImport("GL_EQUIV", "I", AccessFlags = 25)]
				public const int GL_EQUIV = 5385;
				/// <java-name>
				/// GL_EXP
				/// </java-name>
				[Dot42.DexImport("GL_EXP", "I", AccessFlags = 25)]
				public const int GL_EXP = 2048;
				/// <java-name>
				/// GL_EXP2
				/// </java-name>
				[Dot42.DexImport("GL_EXP2", "I", AccessFlags = 25)]
				public const int GL_EXP2 = 2049;
				/// <java-name>
				/// GL_EXTENSIONS
				/// </java-name>
				[Dot42.DexImport("GL_EXTENSIONS", "I", AccessFlags = 25)]
				public const int GL_EXTENSIONS = 7939;
				/// <java-name>
				/// GL_FALSE
				/// </java-name>
				[Dot42.DexImport("GL_FALSE", "I", AccessFlags = 25)]
				public const int GL_FALSE = 0;
				/// <java-name>
				/// GL_FASTEST
				/// </java-name>
				[Dot42.DexImport("GL_FASTEST", "I", AccessFlags = 25)]
				public const int GL_FASTEST = 4353;
				/// <java-name>
				/// GL_FIXED
				/// </java-name>
				[Dot42.DexImport("GL_FIXED", "I", AccessFlags = 25)]
				public const int GL_FIXED = 5132;
				/// <java-name>
				/// GL_FLAT
				/// </java-name>
				[Dot42.DexImport("GL_FLAT", "I", AccessFlags = 25)]
				public const int GL_FLAT = 7424;
				/// <java-name>
				/// GL_FLOAT
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT", "I", AccessFlags = 25)]
				public const int GL_FLOAT = 5126;
				/// <java-name>
				/// GL_FOG
				/// </java-name>
				[Dot42.DexImport("GL_FOG", "I", AccessFlags = 25)]
				public const int GL_FOG = 2912;
				/// <java-name>
				/// GL_FOG_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_FOG_COLOR", "I", AccessFlags = 25)]
				public const int GL_FOG_COLOR = 2918;
				/// <java-name>
				/// GL_FOG_DENSITY
				/// </java-name>
				[Dot42.DexImport("GL_FOG_DENSITY", "I", AccessFlags = 25)]
				public const int GL_FOG_DENSITY = 2914;
				/// <java-name>
				/// GL_FOG_END
				/// </java-name>
				[Dot42.DexImport("GL_FOG_END", "I", AccessFlags = 25)]
				public const int GL_FOG_END = 2916;
				/// <java-name>
				/// GL_FOG_HINT
				/// </java-name>
				[Dot42.DexImport("GL_FOG_HINT", "I", AccessFlags = 25)]
				public const int GL_FOG_HINT = 3156;
				/// <java-name>
				/// GL_FOG_MODE
				/// </java-name>
				[Dot42.DexImport("GL_FOG_MODE", "I", AccessFlags = 25)]
				public const int GL_FOG_MODE = 2917;
				/// <java-name>
				/// GL_FOG_START
				/// </java-name>
				[Dot42.DexImport("GL_FOG_START", "I", AccessFlags = 25)]
				public const int GL_FOG_START = 2915;
				/// <java-name>
				/// GL_FRONT
				/// </java-name>
				[Dot42.DexImport("GL_FRONT", "I", AccessFlags = 25)]
				public const int GL_FRONT = 1028;
				/// <java-name>
				/// GL_FRONT_AND_BACK
				/// </java-name>
				[Dot42.DexImport("GL_FRONT_AND_BACK", "I", AccessFlags = 25)]
				public const int GL_FRONT_AND_BACK = 1032;
				/// <java-name>
				/// GL_GEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_GEQUAL", "I", AccessFlags = 25)]
				public const int GL_GEQUAL = 518;
				/// <java-name>
				/// GL_GREATER
				/// </java-name>
				[Dot42.DexImport("GL_GREATER", "I", AccessFlags = 25)]
				public const int GL_GREATER = 516;
				/// <java-name>
				/// GL_GREEN_BITS
				/// </java-name>
				[Dot42.DexImport("GL_GREEN_BITS", "I", AccessFlags = 25)]
				public const int GL_GREEN_BITS = 3411;
				/// <java-name>
				/// GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES
				/// </java-name>
				[Dot42.DexImport("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES", "I", AccessFlags = 25)]
				public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 35739;
				/// <java-name>
				/// GL_IMPLEMENTATION_COLOR_READ_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 35738;
				/// <java-name>
				/// GL_INCR
				/// </java-name>
				[Dot42.DexImport("GL_INCR", "I", AccessFlags = 25)]
				public const int GL_INCR = 7682;
				/// <java-name>
				/// GL_INVALID_ENUM
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_ENUM", "I", AccessFlags = 25)]
				public const int GL_INVALID_ENUM = 1280;
				/// <java-name>
				/// GL_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int GL_INVALID_OPERATION = 1282;
				/// <java-name>
				/// GL_INVALID_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_VALUE", "I", AccessFlags = 25)]
				public const int GL_INVALID_VALUE = 1281;
				/// <java-name>
				/// GL_INVERT
				/// </java-name>
				[Dot42.DexImport("GL_INVERT", "I", AccessFlags = 25)]
				public const int GL_INVERT = 5386;
				/// <java-name>
				/// GL_KEEP
				/// </java-name>
				[Dot42.DexImport("GL_KEEP", "I", AccessFlags = 25)]
				public const int GL_KEEP = 7680;
				/// <java-name>
				/// GL_LEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_LEQUAL", "I", AccessFlags = 25)]
				public const int GL_LEQUAL = 515;
				/// <java-name>
				/// GL_LESS
				/// </java-name>
				[Dot42.DexImport("GL_LESS", "I", AccessFlags = 25)]
				public const int GL_LESS = 513;
				/// <java-name>
				/// GL_LIGHT_MODEL_AMBIENT
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT_MODEL_AMBIENT", "I", AccessFlags = 25)]
				public const int GL_LIGHT_MODEL_AMBIENT = 2899;
				/// <java-name>
				/// GL_LIGHT_MODEL_TWO_SIDE
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT_MODEL_TWO_SIDE", "I", AccessFlags = 25)]
				public const int GL_LIGHT_MODEL_TWO_SIDE = 2898;
				/// <java-name>
				/// GL_LIGHT0
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT0", "I", AccessFlags = 25)]
				public const int GL_LIGHT0 = 16384;
				/// <java-name>
				/// GL_LIGHT1
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT1", "I", AccessFlags = 25)]
				public const int GL_LIGHT1 = 16385;
				/// <java-name>
				/// GL_LIGHT2
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT2", "I", AccessFlags = 25)]
				public const int GL_LIGHT2 = 16386;
				/// <java-name>
				/// GL_LIGHT3
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT3", "I", AccessFlags = 25)]
				public const int GL_LIGHT3 = 16387;
				/// <java-name>
				/// GL_LIGHT4
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT4", "I", AccessFlags = 25)]
				public const int GL_LIGHT4 = 16388;
				/// <java-name>
				/// GL_LIGHT5
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT5", "I", AccessFlags = 25)]
				public const int GL_LIGHT5 = 16389;
				/// <java-name>
				/// GL_LIGHT6
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT6", "I", AccessFlags = 25)]
				public const int GL_LIGHT6 = 16390;
				/// <java-name>
				/// GL_LIGHT7
				/// </java-name>
				[Dot42.DexImport("GL_LIGHT7", "I", AccessFlags = 25)]
				public const int GL_LIGHT7 = 16391;
				/// <java-name>
				/// GL_LIGHTING
				/// </java-name>
				[Dot42.DexImport("GL_LIGHTING", "I", AccessFlags = 25)]
				public const int GL_LIGHTING = 2896;
				/// <java-name>
				/// GL_LINE_LOOP
				/// </java-name>
				[Dot42.DexImport("GL_LINE_LOOP", "I", AccessFlags = 25)]
				public const int GL_LINE_LOOP = 2;
				/// <java-name>
				/// GL_LINE_SMOOTH
				/// </java-name>
				[Dot42.DexImport("GL_LINE_SMOOTH", "I", AccessFlags = 25)]
				public const int GL_LINE_SMOOTH = 2848;
				/// <java-name>
				/// GL_LINE_SMOOTH_HINT
				/// </java-name>
				[Dot42.DexImport("GL_LINE_SMOOTH_HINT", "I", AccessFlags = 25)]
				public const int GL_LINE_SMOOTH_HINT = 3154;
				/// <java-name>
				/// GL_LINE_STRIP
				/// </java-name>
				[Dot42.DexImport("GL_LINE_STRIP", "I", AccessFlags = 25)]
				public const int GL_LINE_STRIP = 3;
				/// <java-name>
				/// GL_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR", "I", AccessFlags = 25)]
				public const int GL_LINEAR = 9729;
				/// <java-name>
				/// GL_LINEAR_ATTENUATION
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR_ATTENUATION", "I", AccessFlags = 25)]
				public const int GL_LINEAR_ATTENUATION = 4616;
				/// <java-name>
				/// GL_LINEAR_MIPMAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR_MIPMAP_LINEAR", "I", AccessFlags = 25)]
				public const int GL_LINEAR_MIPMAP_LINEAR = 9987;
				/// <java-name>
				/// GL_LINEAR_MIPMAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR_MIPMAP_NEAREST", "I", AccessFlags = 25)]
				public const int GL_LINEAR_MIPMAP_NEAREST = 9985;
				/// <java-name>
				/// GL_LINES
				/// </java-name>
				[Dot42.DexImport("GL_LINES", "I", AccessFlags = 25)]
				public const int GL_LINES = 1;
				/// <java-name>
				/// GL_LUMINANCE
				/// </java-name>
				[Dot42.DexImport("GL_LUMINANCE", "I", AccessFlags = 25)]
				public const int GL_LUMINANCE = 6409;
				/// <java-name>
				/// GL_LUMINANCE_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_LUMINANCE_ALPHA", "I", AccessFlags = 25)]
				public const int GL_LUMINANCE_ALPHA = 6410;
				/// <java-name>
				/// GL_MAX_ELEMENTS_INDICES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_ELEMENTS_INDICES", "I", AccessFlags = 25)]
				public const int GL_MAX_ELEMENTS_INDICES = 33001;
				/// <java-name>
				/// GL_MAX_ELEMENTS_VERTICES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_ELEMENTS_VERTICES", "I", AccessFlags = 25)]
				public const int GL_MAX_ELEMENTS_VERTICES = 33000;
				/// <java-name>
				/// GL_MAX_LIGHTS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_LIGHTS", "I", AccessFlags = 25)]
				public const int GL_MAX_LIGHTS = 3377;
				/// <java-name>
				/// GL_MAX_MODELVIEW_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_MAX_MODELVIEW_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_MAX_MODELVIEW_STACK_DEPTH = 3382;
				/// <java-name>
				/// GL_MAX_PROJECTION_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_MAX_PROJECTION_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_MAX_PROJECTION_STACK_DEPTH = 3384;
				/// <java-name>
				/// GL_MAX_TEXTURE_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_SIZE", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_SIZE = 3379;
				/// <java-name>
				/// GL_MAX_TEXTURE_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_STACK_DEPTH = 3385;
				/// <java-name>
				/// GL_MAX_TEXTURE_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_UNITS", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_UNITS = 34018;
				/// <java-name>
				/// GL_MAX_VIEWPORT_DIMS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VIEWPORT_DIMS", "I", AccessFlags = 25)]
				public const int GL_MAX_VIEWPORT_DIMS = 3386;
				/// <java-name>
				/// GL_MODELVIEW
				/// </java-name>
				[Dot42.DexImport("GL_MODELVIEW", "I", AccessFlags = 25)]
				public const int GL_MODELVIEW = 5888;
				/// <java-name>
				/// GL_MODULATE
				/// </java-name>
				[Dot42.DexImport("GL_MODULATE", "I", AccessFlags = 25)]
				public const int GL_MODULATE = 8448;
				/// <java-name>
				/// GL_MULTISAMPLE
				/// </java-name>
				[Dot42.DexImport("GL_MULTISAMPLE", "I", AccessFlags = 25)]
				public const int GL_MULTISAMPLE = 32925;
				/// <java-name>
				/// GL_NAND
				/// </java-name>
				[Dot42.DexImport("GL_NAND", "I", AccessFlags = 25)]
				public const int GL_NAND = 5390;
				/// <java-name>
				/// GL_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST", "I", AccessFlags = 25)]
				public const int GL_NEAREST = 9728;
				/// <java-name>
				/// GL_NEAREST_MIPMAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST_MIPMAP_LINEAR", "I", AccessFlags = 25)]
				public const int GL_NEAREST_MIPMAP_LINEAR = 9986;
				/// <java-name>
				/// GL_NEAREST_MIPMAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST_MIPMAP_NEAREST", "I", AccessFlags = 25)]
				public const int GL_NEAREST_MIPMAP_NEAREST = 9984;
				/// <java-name>
				/// GL_NEVER
				/// </java-name>
				[Dot42.DexImport("GL_NEVER", "I", AccessFlags = 25)]
				public const int GL_NEVER = 512;
				/// <java-name>
				/// GL_NICEST
				/// </java-name>
				[Dot42.DexImport("GL_NICEST", "I", AccessFlags = 25)]
				public const int GL_NICEST = 4354;
				/// <java-name>
				/// GL_NO_ERROR
				/// </java-name>
				[Dot42.DexImport("GL_NO_ERROR", "I", AccessFlags = 25)]
				public const int GL_NO_ERROR = 0;
				/// <java-name>
				/// GL_NOOP
				/// </java-name>
				[Dot42.DexImport("GL_NOOP", "I", AccessFlags = 25)]
				public const int GL_NOOP = 5381;
				/// <java-name>
				/// GL_NOR
				/// </java-name>
				[Dot42.DexImport("GL_NOR", "I", AccessFlags = 25)]
				public const int GL_NOR = 5384;
				/// <java-name>
				/// GL_NORMAL_ARRAY
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_ARRAY", "I", AccessFlags = 25)]
				public const int GL_NORMAL_ARRAY = 32885;
				/// <java-name>
				/// GL_NORMALIZE
				/// </java-name>
				[Dot42.DexImport("GL_NORMALIZE", "I", AccessFlags = 25)]
				public const int GL_NORMALIZE = 2977;
				/// <java-name>
				/// GL_NOTEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_NOTEQUAL", "I", AccessFlags = 25)]
				public const int GL_NOTEQUAL = 517;
				/// <java-name>
				/// GL_NUM_COMPRESSED_TEXTURE_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_NUM_COMPRESSED_TEXTURE_FORMATS", "I", AccessFlags = 25)]
				public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 34466;
				/// <java-name>
				/// GL_ONE
				/// </java-name>
				[Dot42.DexImport("GL_ONE", "I", AccessFlags = 25)]
				public const int GL_ONE = 1;
				/// <java-name>
				/// GL_ONE_MINUS_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_DST_ALPHA = 773;
				/// <java-name>
				/// GL_ONE_MINUS_DST_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_DST_COLOR", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_DST_COLOR = 775;
				/// <java-name>
				/// GL_ONE_MINUS_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_SRC_ALPHA = 771;
				/// <java-name>
				/// GL_ONE_MINUS_SRC_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_SRC_COLOR", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_SRC_COLOR = 769;
				/// <java-name>
				/// GL_OR
				/// </java-name>
				[Dot42.DexImport("GL_OR", "I", AccessFlags = 25)]
				public const int GL_OR = 5383;
				/// <java-name>
				/// GL_OR_INVERTED
				/// </java-name>
				[Dot42.DexImport("GL_OR_INVERTED", "I", AccessFlags = 25)]
				public const int GL_OR_INVERTED = 5389;
				/// <java-name>
				/// GL_OR_REVERSE
				/// </java-name>
				[Dot42.DexImport("GL_OR_REVERSE", "I", AccessFlags = 25)]
				public const int GL_OR_REVERSE = 5387;
				/// <java-name>
				/// GL_OUT_OF_MEMORY
				/// </java-name>
				[Dot42.DexImport("GL_OUT_OF_MEMORY", "I", AccessFlags = 25)]
				public const int GL_OUT_OF_MEMORY = 1285;
				/// <java-name>
				/// GL_PACK_ALIGNMENT
				/// </java-name>
				[Dot42.DexImport("GL_PACK_ALIGNMENT", "I", AccessFlags = 25)]
				public const int GL_PACK_ALIGNMENT = 3333;
				/// <java-name>
				/// GL_PALETTE4_R5_G6_B5_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE4_R5_G6_B5_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE4_R5_G6_B5_OES = 35730;
				/// <java-name>
				/// GL_PALETTE4_RGB5_A1_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE4_RGB5_A1_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE4_RGB5_A1_OES = 35732;
				/// <java-name>
				/// GL_PALETTE4_RGB8_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE4_RGB8_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE4_RGB8_OES = 35728;
				/// <java-name>
				/// GL_PALETTE4_RGBA4_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE4_RGBA4_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE4_RGBA4_OES = 35731;
				/// <java-name>
				/// GL_PALETTE4_RGBA8_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE4_RGBA8_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE4_RGBA8_OES = 35729;
				/// <java-name>
				/// GL_PALETTE8_R5_G6_B5_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE8_R5_G6_B5_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE8_R5_G6_B5_OES = 35735;
				/// <java-name>
				/// GL_PALETTE8_RGB5_A1_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE8_RGB5_A1_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE8_RGB5_A1_OES = 35737;
				/// <java-name>
				/// GL_PALETTE8_RGB8_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE8_RGB8_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE8_RGB8_OES = 35733;
				/// <java-name>
				/// GL_PALETTE8_RGBA4_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE8_RGBA4_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE8_RGBA4_OES = 35736;
				/// <java-name>
				/// GL_PALETTE8_RGBA8_OES
				/// </java-name>
				[Dot42.DexImport("GL_PALETTE8_RGBA8_OES", "I", AccessFlags = 25)]
				public const int GL_PALETTE8_RGBA8_OES = 35734;
				/// <java-name>
				/// GL_PERSPECTIVE_CORRECTION_HINT
				/// </java-name>
				[Dot42.DexImport("GL_PERSPECTIVE_CORRECTION_HINT", "I", AccessFlags = 25)]
				public const int GL_PERSPECTIVE_CORRECTION_HINT = 3152;
				/// <java-name>
				/// GL_POINT_SMOOTH
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SMOOTH", "I", AccessFlags = 25)]
				public const int GL_POINT_SMOOTH = 2832;
				/// <java-name>
				/// GL_POINT_SMOOTH_HINT
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SMOOTH_HINT", "I", AccessFlags = 25)]
				public const int GL_POINT_SMOOTH_HINT = 3153;
				/// <java-name>
				/// GL_POINTS
				/// </java-name>
				[Dot42.DexImport("GL_POINTS", "I", AccessFlags = 25)]
				public const int GL_POINTS = 0;
				/// <java-name>
				/// GL_POINT_FADE_THRESHOLD_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_POINT_FADE_THRESHOLD_SIZE", "I", AccessFlags = 25)]
				public const int GL_POINT_FADE_THRESHOLD_SIZE = 33064;
				/// <java-name>
				/// GL_POINT_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE = 2833;
				/// <java-name>
				/// GL_POLYGON_OFFSET_FILL
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_FILL", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_FILL = 32823;
				/// <java-name>
				/// GL_POLYGON_SMOOTH_HINT
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_SMOOTH_HINT", "I", AccessFlags = 25)]
				public const int GL_POLYGON_SMOOTH_HINT = 3155;
				/// <java-name>
				/// GL_POSITION
				/// </java-name>
				[Dot42.DexImport("GL_POSITION", "I", AccessFlags = 25)]
				public const int GL_POSITION = 4611;
				/// <java-name>
				/// GL_PROJECTION
				/// </java-name>
				[Dot42.DexImport("GL_PROJECTION", "I", AccessFlags = 25)]
				public const int GL_PROJECTION = 5889;
				/// <java-name>
				/// GL_QUADRATIC_ATTENUATION
				/// </java-name>
				[Dot42.DexImport("GL_QUADRATIC_ATTENUATION", "I", AccessFlags = 25)]
				public const int GL_QUADRATIC_ATTENUATION = 4617;
				/// <java-name>
				/// GL_RED_BITS
				/// </java-name>
				[Dot42.DexImport("GL_RED_BITS", "I", AccessFlags = 25)]
				public const int GL_RED_BITS = 3410;
				/// <java-name>
				/// GL_RENDERER
				/// </java-name>
				[Dot42.DexImport("GL_RENDERER", "I", AccessFlags = 25)]
				public const int GL_RENDERER = 7937;
				/// <java-name>
				/// GL_REPEAT
				/// </java-name>
				[Dot42.DexImport("GL_REPEAT", "I", AccessFlags = 25)]
				public const int GL_REPEAT = 10497;
				/// <java-name>
				/// GL_REPLACE
				/// </java-name>
				[Dot42.DexImport("GL_REPLACE", "I", AccessFlags = 25)]
				public const int GL_REPLACE = 7681;
				/// <java-name>
				/// GL_RESCALE_NORMAL
				/// </java-name>
				[Dot42.DexImport("GL_RESCALE_NORMAL", "I", AccessFlags = 25)]
				public const int GL_RESCALE_NORMAL = 32826;
				/// <java-name>
				/// GL_RGB
				/// </java-name>
				[Dot42.DexImport("GL_RGB", "I", AccessFlags = 25)]
				public const int GL_RGB = 6407;
				/// <java-name>
				/// GL_RGBA
				/// </java-name>
				[Dot42.DexImport("GL_RGBA", "I", AccessFlags = 25)]
				public const int GL_RGBA = 6408;
				/// <java-name>
				/// GL_SAMPLE_ALPHA_TO_COVERAGE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_ALPHA_TO_COVERAGE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 32926;
				/// <java-name>
				/// GL_SAMPLE_ALPHA_TO_ONE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_ALPHA_TO_ONE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_ALPHA_TO_ONE = 32927;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE = 32928;
				/// <java-name>
				/// GL_SCISSOR_TEST
				/// </java-name>
				[Dot42.DexImport("GL_SCISSOR_TEST", "I", AccessFlags = 25)]
				public const int GL_SCISSOR_TEST = 3089;
				/// <java-name>
				/// GL_SET
				/// </java-name>
				[Dot42.DexImport("GL_SET", "I", AccessFlags = 25)]
				public const int GL_SET = 5391;
				/// <java-name>
				/// GL_SHININESS
				/// </java-name>
				[Dot42.DexImport("GL_SHININESS", "I", AccessFlags = 25)]
				public const int GL_SHININESS = 5633;
				/// <java-name>
				/// GL_SHORT
				/// </java-name>
				[Dot42.DexImport("GL_SHORT", "I", AccessFlags = 25)]
				public const int GL_SHORT = 5122;
				/// <java-name>
				/// GL_SMOOTH
				/// </java-name>
				[Dot42.DexImport("GL_SMOOTH", "I", AccessFlags = 25)]
				public const int GL_SMOOTH = 7425;
				/// <java-name>
				/// GL_SMOOTH_LINE_WIDTH_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_SMOOTH_LINE_WIDTH_RANGE", "I", AccessFlags = 25)]
				public const int GL_SMOOTH_LINE_WIDTH_RANGE = 2850;
				/// <java-name>
				/// GL_SMOOTH_POINT_SIZE_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_SMOOTH_POINT_SIZE_RANGE", "I", AccessFlags = 25)]
				public const int GL_SMOOTH_POINT_SIZE_RANGE = 2834;
				/// <java-name>
				/// GL_SPECULAR
				/// </java-name>
				[Dot42.DexImport("GL_SPECULAR", "I", AccessFlags = 25)]
				public const int GL_SPECULAR = 4610;
				/// <java-name>
				/// GL_SPOT_CUTOFF
				/// </java-name>
				[Dot42.DexImport("GL_SPOT_CUTOFF", "I", AccessFlags = 25)]
				public const int GL_SPOT_CUTOFF = 4614;
				/// <java-name>
				/// GL_SPOT_DIRECTION
				/// </java-name>
				[Dot42.DexImport("GL_SPOT_DIRECTION", "I", AccessFlags = 25)]
				public const int GL_SPOT_DIRECTION = 4612;
				/// <java-name>
				/// GL_SPOT_EXPONENT
				/// </java-name>
				[Dot42.DexImport("GL_SPOT_EXPONENT", "I", AccessFlags = 25)]
				public const int GL_SPOT_EXPONENT = 4613;
				/// <java-name>
				/// GL_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_SRC_ALPHA = 770;
				/// <java-name>
				/// GL_SRC_ALPHA_SATURATE
				/// </java-name>
				[Dot42.DexImport("GL_SRC_ALPHA_SATURATE", "I", AccessFlags = 25)]
				public const int GL_SRC_ALPHA_SATURATE = 776;
				/// <java-name>
				/// GL_SRC_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_SRC_COLOR", "I", AccessFlags = 25)]
				public const int GL_SRC_COLOR = 768;
				/// <java-name>
				/// GL_STACK_OVERFLOW
				/// </java-name>
				[Dot42.DexImport("GL_STACK_OVERFLOW", "I", AccessFlags = 25)]
				public const int GL_STACK_OVERFLOW = 1283;
				/// <java-name>
				/// GL_STACK_UNDERFLOW
				/// </java-name>
				[Dot42.DexImport("GL_STACK_UNDERFLOW", "I", AccessFlags = 25)]
				public const int GL_STACK_UNDERFLOW = 1284;
				/// <java-name>
				/// GL_STENCIL_BITS
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BITS", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BITS = 3415;
				/// <java-name>
				/// GL_STENCIL_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BUFFER_BIT = 1024;
				/// <java-name>
				/// GL_STENCIL_TEST
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_TEST", "I", AccessFlags = 25)]
				public const int GL_STENCIL_TEST = 2960;
				/// <java-name>
				/// GL_SUBPIXEL_BITS
				/// </java-name>
				[Dot42.DexImport("GL_SUBPIXEL_BITS", "I", AccessFlags = 25)]
				public const int GL_SUBPIXEL_BITS = 3408;
				/// <java-name>
				/// GL_TEXTURE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE = 5890;
				/// <java-name>
				/// GL_TEXTURE_2D
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_2D", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_2D = 3553;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY = 32888;
				/// <java-name>
				/// GL_TEXTURE_ENV
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_ENV", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_ENV = 8960;
				/// <java-name>
				/// GL_TEXTURE_ENV_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_ENV_COLOR", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_ENV_COLOR = 8705;
				/// <java-name>
				/// GL_TEXTURE_ENV_MODE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_ENV_MODE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_ENV_MODE = 8704;
				/// <java-name>
				/// GL_TEXTURE_MAG_FILTER
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MAG_FILTER", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MAG_FILTER = 10240;
				/// <java-name>
				/// GL_TEXTURE_MIN_FILTER
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MIN_FILTER", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MIN_FILTER = 10241;
				/// <java-name>
				/// GL_TEXTURE_WRAP_S
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_WRAP_S", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_WRAP_S = 10242;
				/// <java-name>
				/// GL_TEXTURE_WRAP_T
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_WRAP_T", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_WRAP_T = 10243;
				/// <java-name>
				/// GL_TEXTURE0
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE0", "I", AccessFlags = 25)]
				public const int GL_TEXTURE0 = 33984;
				/// <java-name>
				/// GL_TEXTURE1
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE1", "I", AccessFlags = 25)]
				public const int GL_TEXTURE1 = 33985;
				/// <java-name>
				/// GL_TEXTURE2
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE2", "I", AccessFlags = 25)]
				public const int GL_TEXTURE2 = 33986;
				/// <java-name>
				/// GL_TEXTURE3
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE3", "I", AccessFlags = 25)]
				public const int GL_TEXTURE3 = 33987;
				/// <java-name>
				/// GL_TEXTURE4
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE4", "I", AccessFlags = 25)]
				public const int GL_TEXTURE4 = 33988;
				/// <java-name>
				/// GL_TEXTURE5
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE5", "I", AccessFlags = 25)]
				public const int GL_TEXTURE5 = 33989;
				/// <java-name>
				/// GL_TEXTURE6
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE6", "I", AccessFlags = 25)]
				public const int GL_TEXTURE6 = 33990;
				/// <java-name>
				/// GL_TEXTURE7
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE7", "I", AccessFlags = 25)]
				public const int GL_TEXTURE7 = 33991;
				/// <java-name>
				/// GL_TEXTURE8
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE8", "I", AccessFlags = 25)]
				public const int GL_TEXTURE8 = 33992;
				/// <java-name>
				/// GL_TEXTURE9
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE9", "I", AccessFlags = 25)]
				public const int GL_TEXTURE9 = 33993;
				/// <java-name>
				/// GL_TEXTURE10
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE10", "I", AccessFlags = 25)]
				public const int GL_TEXTURE10 = 33994;
				/// <java-name>
				/// GL_TEXTURE11
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE11", "I", AccessFlags = 25)]
				public const int GL_TEXTURE11 = 33995;
				/// <java-name>
				/// GL_TEXTURE12
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE12", "I", AccessFlags = 25)]
				public const int GL_TEXTURE12 = 33996;
				/// <java-name>
				/// GL_TEXTURE13
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE13", "I", AccessFlags = 25)]
				public const int GL_TEXTURE13 = 33997;
				/// <java-name>
				/// GL_TEXTURE14
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE14", "I", AccessFlags = 25)]
				public const int GL_TEXTURE14 = 33998;
				/// <java-name>
				/// GL_TEXTURE15
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE15", "I", AccessFlags = 25)]
				public const int GL_TEXTURE15 = 33999;
				/// <java-name>
				/// GL_TEXTURE16
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE16", "I", AccessFlags = 25)]
				public const int GL_TEXTURE16 = 34000;
				/// <java-name>
				/// GL_TEXTURE17
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE17", "I", AccessFlags = 25)]
				public const int GL_TEXTURE17 = 34001;
				/// <java-name>
				/// GL_TEXTURE18
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE18", "I", AccessFlags = 25)]
				public const int GL_TEXTURE18 = 34002;
				/// <java-name>
				/// GL_TEXTURE19
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE19", "I", AccessFlags = 25)]
				public const int GL_TEXTURE19 = 34003;
				/// <java-name>
				/// GL_TEXTURE20
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE20", "I", AccessFlags = 25)]
				public const int GL_TEXTURE20 = 34004;
				/// <java-name>
				/// GL_TEXTURE21
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE21", "I", AccessFlags = 25)]
				public const int GL_TEXTURE21 = 34005;
				/// <java-name>
				/// GL_TEXTURE22
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE22", "I", AccessFlags = 25)]
				public const int GL_TEXTURE22 = 34006;
				/// <java-name>
				/// GL_TEXTURE23
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE23", "I", AccessFlags = 25)]
				public const int GL_TEXTURE23 = 34007;
				/// <java-name>
				/// GL_TEXTURE24
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE24", "I", AccessFlags = 25)]
				public const int GL_TEXTURE24 = 34008;
				/// <java-name>
				/// GL_TEXTURE25
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE25", "I", AccessFlags = 25)]
				public const int GL_TEXTURE25 = 34009;
				/// <java-name>
				/// GL_TEXTURE26
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE26", "I", AccessFlags = 25)]
				public const int GL_TEXTURE26 = 34010;
				/// <java-name>
				/// GL_TEXTURE27
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE27", "I", AccessFlags = 25)]
				public const int GL_TEXTURE27 = 34011;
				/// <java-name>
				/// GL_TEXTURE28
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE28", "I", AccessFlags = 25)]
				public const int GL_TEXTURE28 = 34012;
				/// <java-name>
				/// GL_TEXTURE29
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE29", "I", AccessFlags = 25)]
				public const int GL_TEXTURE29 = 34013;
				/// <java-name>
				/// GL_TEXTURE30
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE30", "I", AccessFlags = 25)]
				public const int GL_TEXTURE30 = 34014;
				/// <java-name>
				/// GL_TEXTURE31
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE31", "I", AccessFlags = 25)]
				public const int GL_TEXTURE31 = 34015;
				/// <java-name>
				/// GL_TRIANGLE_FAN
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLE_FAN", "I", AccessFlags = 25)]
				public const int GL_TRIANGLE_FAN = 6;
				/// <java-name>
				/// GL_TRIANGLE_STRIP
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLE_STRIP", "I", AccessFlags = 25)]
				public const int GL_TRIANGLE_STRIP = 5;
				/// <java-name>
				/// GL_TRIANGLES
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLES", "I", AccessFlags = 25)]
				public const int GL_TRIANGLES = 4;
				/// <java-name>
				/// GL_TRUE
				/// </java-name>
				[Dot42.DexImport("GL_TRUE", "I", AccessFlags = 25)]
				public const int GL_TRUE = 1;
				/// <java-name>
				/// GL_UNPACK_ALIGNMENT
				/// </java-name>
				[Dot42.DexImport("GL_UNPACK_ALIGNMENT", "I", AccessFlags = 25)]
				public const int GL_UNPACK_ALIGNMENT = 3317;
				/// <java-name>
				/// GL_UNSIGNED_BYTE
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_BYTE", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_BYTE = 5121;
				/// <java-name>
				/// GL_UNSIGNED_SHORT
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT = 5123;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_4_4_4_4
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_4_4_4_4", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_4_4_4_4 = 32819;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_5_5_5_1
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_5_5_5_1", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_5_5_5_1 = 32820;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_5_6_5
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_5_6_5", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_5_6_5 = 33635;
				/// <java-name>
				/// GL_VENDOR
				/// </java-name>
				[Dot42.DexImport("GL_VENDOR", "I", AccessFlags = 25)]
				public const int GL_VENDOR = 7936;
				/// <java-name>
				/// GL_VERSION
				/// </java-name>
				[Dot42.DexImport("GL_VERSION", "I", AccessFlags = 25)]
				public const int GL_VERSION = 7938;
				/// <java-name>
				/// GL_VERTEX_ARRAY
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY = 32884;
				/// <java-name>
				/// GL_XOR
				/// </java-name>
				[Dot42.DexImport("GL_XOR", "I", AccessFlags = 25)]
				public const int GL_XOR = 5382;
				/// <java-name>
				/// GL_ZERO
				/// </java-name>
				[Dot42.DexImport("GL_ZERO", "I", AccessFlags = 25)]
				public const int GL_ZERO = 0;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLES10() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glActiveTexture
				/// </java-name>
				[Dot42.DexImport("glActiveTexture", "(I)V", AccessFlags = 265)]
				public static void GlActiveTexture(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glAlphaFunc
				/// </java-name>
				[Dot42.DexImport("glAlphaFunc", "(IF)V", AccessFlags = 265)]
				public static void GlAlphaFunc(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glAlphaFuncx
				/// </java-name>
				[Dot42.DexImport("glAlphaFuncx", "(II)V", AccessFlags = 265)]
				public static void GlAlphaFuncx(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindTexture
				/// </java-name>
				[Dot42.DexImport("glBindTexture", "(II)V", AccessFlags = 265)]
				public static void GlBindTexture(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendFunc
				/// </java-name>
				[Dot42.DexImport("glBlendFunc", "(II)V", AccessFlags = 265)]
				public static void GlBlendFunc(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClear
				/// </java-name>
				[Dot42.DexImport("glClear", "(I)V", AccessFlags = 265)]
				public static void GlClear(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearColor
				/// </java-name>
				[Dot42.DexImport("glClearColor", "(FFFF)V", AccessFlags = 265)]
				public static void GlClearColor(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearColorx
				/// </java-name>
				[Dot42.DexImport("glClearColorx", "(IIII)V", AccessFlags = 265)]
				public static void GlClearColorx(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearDepthf
				/// </java-name>
				[Dot42.DexImport("glClearDepthf", "(F)V", AccessFlags = 265)]
				public static void GlClearDepthf(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearDepthx
				/// </java-name>
				[Dot42.DexImport("glClearDepthx", "(I)V", AccessFlags = 265)]
				public static void GlClearDepthx(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearStencil
				/// </java-name>
				[Dot42.DexImport("glClearStencil", "(I)V", AccessFlags = 265)]
				public static void GlClearStencil(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClientActiveTexture
				/// </java-name>
				[Dot42.DexImport("glClientActiveTexture", "(I)V", AccessFlags = 265)]
				public static void GlClientActiveTexture(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColor4f
				/// </java-name>
				[Dot42.DexImport("glColor4f", "(FFFF)V", AccessFlags = 265)]
				public static void GlColor4f(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColor4x
				/// </java-name>
				[Dot42.DexImport("glColor4x", "(IIII)V", AccessFlags = 265)]
				public static void GlColor4x(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColorMask
				/// </java-name>
				[Dot42.DexImport("glColorMask", "(ZZZZ)V", AccessFlags = 265)]
				public static void GlColorMask(bool boolean, bool boolean1, bool boolean2, bool boolean3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColorPointer
				/// </java-name>
				[Dot42.DexImport("glColorPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlColorPointer(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCompressedTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlCompressedTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCompressedTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlCompressedTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCopyTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexImage2D", "(IIIIIIII)V", AccessFlags = 265)]
				public static void GlCopyTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCopyTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexSubImage2D", "(IIIIIIII)V", AccessFlags = 265)]
				public static void GlCopyTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCullFace
				/// </java-name>
				[Dot42.DexImport("glCullFace", "(I)V", AccessFlags = 265)]
				public static void GlCullFace(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteTextures(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteTextures(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthFunc
				/// </java-name>
				[Dot42.DexImport("glDepthFunc", "(I)V", AccessFlags = 265)]
				public static void GlDepthFunc(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthMask
				/// </java-name>
				[Dot42.DexImport("glDepthMask", "(Z)V", AccessFlags = 265)]
				public static void GlDepthMask(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthRangef
				/// </java-name>
				[Dot42.DexImport("glDepthRangef", "(FF)V", AccessFlags = 265)]
				public static void GlDepthRangef(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthRangex
				/// </java-name>
				[Dot42.DexImport("glDepthRangex", "(II)V", AccessFlags = 265)]
				public static void GlDepthRangex(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDisable
				/// </java-name>
				[Dot42.DexImport("glDisable", "(I)V", AccessFlags = 265)]
				public static void GlDisable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDisableClientState
				/// </java-name>
				[Dot42.DexImport("glDisableClientState", "(I)V", AccessFlags = 265)]
				public static void GlDisableClientState(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawArrays
				/// </java-name>
				[Dot42.DexImport("glDrawArrays", "(III)V", AccessFlags = 265)]
				public static void GlDrawArrays(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlDrawElements(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEnable
				/// </java-name>
				[Dot42.DexImport("glEnable", "(I)V", AccessFlags = 265)]
				public static void GlEnable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEnableClientState
				/// </java-name>
				[Dot42.DexImport("glEnableClientState", "(I)V", AccessFlags = 265)]
				public static void GlEnableClientState(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFinish
				/// </java-name>
				[Dot42.DexImport("glFinish", "()V", AccessFlags = 265)]
				public static void GlFinish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFlush
				/// </java-name>
				[Dot42.DexImport("glFlush", "()V", AccessFlags = 265)]
				public static void GlFlush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogf
				/// </java-name>
				[Dot42.DexImport("glFogf", "(IF)V", AccessFlags = 265)]
				public static void GlFogf(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogfv
				/// </java-name>
				[Dot42.DexImport("glFogfv", "(I[FI)V", AccessFlags = 265)]
				public static void GlFogfv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogfv
				/// </java-name>
				[Dot42.DexImport("glFogfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlFogfv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogx
				/// </java-name>
				[Dot42.DexImport("glFogx", "(II)V", AccessFlags = 265)]
				public static void GlFogx(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogxv
				/// </java-name>
				[Dot42.DexImport("glFogxv", "(I[II)V", AccessFlags = 265)]
				public static void GlFogxv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogxv
				/// </java-name>
				[Dot42.DexImport("glFogxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlFogxv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrontFace
				/// </java-name>
				[Dot42.DexImport("glFrontFace", "(I)V", AccessFlags = 265)]
				public static void GlFrontFace(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrustumf
				/// </java-name>
				[Dot42.DexImport("glFrustumf", "(FFFFFF)V", AccessFlags = 265)]
				public static void GlFrustumf(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrustumx
				/// </java-name>
				[Dot42.DexImport("glFrustumx", "(IIIIII)V", AccessFlags = 265)]
				public static void GlFrustumx(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(I[II)V", AccessFlags = 265)]
				public static void GlGenTextures(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenTextures(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetError
				/// </java-name>
				[Dot42.DexImport("glGetError", "()I", AccessFlags = 265)]
				public static int GlGetError() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(I[II)V", AccessFlags = 265)]
				public static void GlGetIntegerv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetIntegerv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetString
				/// </java-name>
				[Dot42.DexImport("glGetString", "(I)Ljava/lang/String;", AccessFlags = 265)]
				public static string GlGetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// glHint
				/// </java-name>
				[Dot42.DexImport("glHint", "(II)V", AccessFlags = 265)]
				public static void GlHint(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelf
				/// </java-name>
				[Dot42.DexImport("glLightModelf", "(IF)V", AccessFlags = 265)]
				public static void GlLightModelf(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelfv
				/// </java-name>
				[Dot42.DexImport("glLightModelfv", "(I[FI)V", AccessFlags = 265)]
				public static void GlLightModelfv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelfv
				/// </java-name>
				[Dot42.DexImport("glLightModelfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlLightModelfv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelx
				/// </java-name>
				[Dot42.DexImport("glLightModelx", "(II)V", AccessFlags = 265)]
				public static void GlLightModelx(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelxv
				/// </java-name>
				[Dot42.DexImport("glLightModelxv", "(I[II)V", AccessFlags = 265)]
				public static void GlLightModelxv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelxv
				/// </java-name>
				[Dot42.DexImport("glLightModelxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLightModelxv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightf
				/// </java-name>
				[Dot42.DexImport("glLightf", "(IIF)V", AccessFlags = 265)]
				public static void GlLightf(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightfv
				/// </java-name>
				[Dot42.DexImport("glLightfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlLightfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightfv
				/// </java-name>
				[Dot42.DexImport("glLightfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlLightfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightx
				/// </java-name>
				[Dot42.DexImport("glLightx", "(III)V", AccessFlags = 265)]
				public static void GlLightx(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightxv
				/// </java-name>
				[Dot42.DexImport("glLightxv", "(II[II)V", AccessFlags = 265)]
				public static void GlLightxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightxv
				/// </java-name>
				[Dot42.DexImport("glLightxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLightxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLineWidth
				/// </java-name>
				[Dot42.DexImport("glLineWidth", "(F)V", AccessFlags = 265)]
				public static void GlLineWidth(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLineWidthx
				/// </java-name>
				[Dot42.DexImport("glLineWidthx", "(I)V", AccessFlags = 265)]
				public static void GlLineWidthx(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadIdentity
				/// </java-name>
				[Dot42.DexImport("glLoadIdentity", "()V", AccessFlags = 265)]
				public static void GlLoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixf
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixf", "([FI)V", AccessFlags = 265)]
				public static void GlLoadMatrixf(float[] single, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixf
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlLoadMatrixf(global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixx
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixx", "([II)V", AccessFlags = 265)]
				public static void GlLoadMatrixx(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixx
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixx", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLoadMatrixx(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLogicOp
				/// </java-name>
				[Dot42.DexImport("glLogicOp", "(I)V", AccessFlags = 265)]
				public static void GlLogicOp(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialf
				/// </java-name>
				[Dot42.DexImport("glMaterialf", "(IIF)V", AccessFlags = 265)]
				public static void GlMaterialf(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialfv
				/// </java-name>
				[Dot42.DexImport("glMaterialfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlMaterialfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialfv
				/// </java-name>
				[Dot42.DexImport("glMaterialfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlMaterialfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialx
				/// </java-name>
				[Dot42.DexImport("glMaterialx", "(III)V", AccessFlags = 265)]
				public static void GlMaterialx(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialxv
				/// </java-name>
				[Dot42.DexImport("glMaterialxv", "(II[II)V", AccessFlags = 265)]
				public static void GlMaterialxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialxv
				/// </java-name>
				[Dot42.DexImport("glMaterialxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlMaterialxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMatrixMode
				/// </java-name>
				[Dot42.DexImport("glMatrixMode", "(I)V", AccessFlags = 265)]
				public static void GlMatrixMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixf
				/// </java-name>
				[Dot42.DexImport("glMultMatrixf", "([FI)V", AccessFlags = 265)]
				public static void GlMultMatrixf(float[] single, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixf
				/// </java-name>
				[Dot42.DexImport("glMultMatrixf", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlMultMatrixf(global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixx
				/// </java-name>
				[Dot42.DexImport("glMultMatrixx", "([II)V", AccessFlags = 265)]
				public static void GlMultMatrixx(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixx
				/// </java-name>
				[Dot42.DexImport("glMultMatrixx", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlMultMatrixx(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultiTexCoord4f
				/// </java-name>
				[Dot42.DexImport("glMultiTexCoord4f", "(IFFFF)V", AccessFlags = 265)]
				public static void GlMultiTexCoord4f(int int32, float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultiTexCoord4x
				/// </java-name>
				[Dot42.DexImport("glMultiTexCoord4x", "(IIIII)V", AccessFlags = 265)]
				public static void GlMultiTexCoord4x(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glNormal3f
				/// </java-name>
				[Dot42.DexImport("glNormal3f", "(FFF)V", AccessFlags = 265)]
				public static void GlNormal3f(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glNormal3x
				/// </java-name>
				[Dot42.DexImport("glNormal3x", "(III)V", AccessFlags = 265)]
				public static void GlNormal3x(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glNormalPointer
				/// </java-name>
				[Dot42.DexImport("glNormalPointer", "(IILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlNormalPointer(int int32, int int321, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glOrthof
				/// </java-name>
				[Dot42.DexImport("glOrthof", "(FFFFFF)V", AccessFlags = 265)]
				public static void GlOrthof(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glOrthox
				/// </java-name>
				[Dot42.DexImport("glOrthox", "(IIIIII)V", AccessFlags = 265)]
				public static void GlOrthox(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPixelStorei
				/// </java-name>
				[Dot42.DexImport("glPixelStorei", "(II)V", AccessFlags = 265)]
				public static void GlPixelStorei(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointSize
				/// </java-name>
				[Dot42.DexImport("glPointSize", "(F)V", AccessFlags = 265)]
				public static void GlPointSize(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointSizex
				/// </java-name>
				[Dot42.DexImport("glPointSizex", "(I)V", AccessFlags = 265)]
				public static void GlPointSizex(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPolygonOffset
				/// </java-name>
				[Dot42.DexImport("glPolygonOffset", "(FF)V", AccessFlags = 265)]
				public static void GlPolygonOffset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPolygonOffsetx
				/// </java-name>
				[Dot42.DexImport("glPolygonOffsetx", "(II)V", AccessFlags = 265)]
				public static void GlPolygonOffsetx(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPopMatrix
				/// </java-name>
				[Dot42.DexImport("glPopMatrix", "()V", AccessFlags = 265)]
				public static void GlPopMatrix() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPushMatrix
				/// </java-name>
				[Dot42.DexImport("glPushMatrix", "()V", AccessFlags = 265)]
				public static void GlPushMatrix() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glReadPixels
				/// </java-name>
				[Dot42.DexImport("glReadPixels", "(IIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlReadPixels(int int32, int int321, int int322, int int323, int int324, int int325, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glRotatef
				/// </java-name>
				[Dot42.DexImport("glRotatef", "(FFFF)V", AccessFlags = 265)]
				public static void GlRotatef(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glRotatex
				/// </java-name>
				[Dot42.DexImport("glRotatex", "(IIII)V", AccessFlags = 265)]
				public static void GlRotatex(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glSampleCoverage
				/// </java-name>
				[Dot42.DexImport("glSampleCoverage", "(FZ)V", AccessFlags = 265)]
				public static void GlSampleCoverage(float single, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glSampleCoveragex
				/// </java-name>
				[Dot42.DexImport("glSampleCoveragex", "(IZ)V", AccessFlags = 265)]
				public static void GlSampleCoveragex(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glScalef
				/// </java-name>
				[Dot42.DexImport("glScalef", "(FFF)V", AccessFlags = 265)]
				public static void GlScalef(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glScalex
				/// </java-name>
				[Dot42.DexImport("glScalex", "(III)V", AccessFlags = 265)]
				public static void GlScalex(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glScissor
				/// </java-name>
				[Dot42.DexImport("glScissor", "(IIII)V", AccessFlags = 265)]
				public static void GlScissor(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glShadeModel
				/// </java-name>
				[Dot42.DexImport("glShadeModel", "(I)V", AccessFlags = 265)]
				public static void GlShadeModel(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilFunc
				/// </java-name>
				[Dot42.DexImport("glStencilFunc", "(III)V", AccessFlags = 265)]
				public static void GlStencilFunc(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilMask
				/// </java-name>
				[Dot42.DexImport("glStencilMask", "(I)V", AccessFlags = 265)]
				public static void GlStencilMask(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilOp
				/// </java-name>
				[Dot42.DexImport("glStencilOp", "(III)V", AccessFlags = 265)]
				public static void GlStencilOp(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexCoordPointer
				/// </java-name>
				[Dot42.DexImport("glTexCoordPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlTexCoordPointer(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvf
				/// </java-name>
				[Dot42.DexImport("glTexEnvf", "(IIF)V", AccessFlags = 265)]
				public static void GlTexEnvf(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlTexEnvfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlTexEnvfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvx
				/// </java-name>
				[Dot42.DexImport("glTexEnvx", "(III)V", AccessFlags = 265)]
				public static void GlTexEnvx(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(II[II)V", AccessFlags = 265)]
				public static void GlTexEnvxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexEnvxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexImage2D
				/// </java-name>
				[Dot42.DexImport("glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterf
				/// </java-name>
				[Dot42.DexImport("glTexParameterf", "(IIF)V", AccessFlags = 265)]
				public static void GlTexParameterf(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterx
				/// </java-name>
				[Dot42.DexImport("glTexParameterx", "(III)V", AccessFlags = 265)]
				public static void GlTexParameterx(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTranslatef
				/// </java-name>
				[Dot42.DexImport("glTranslatef", "(FFF)V", AccessFlags = 265)]
				public static void GlTranslatef(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTranslatex
				/// </java-name>
				[Dot42.DexImport("glTranslatex", "(III)V", AccessFlags = 265)]
				public static void GlTranslatex(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexPointer
				/// </java-name>
				[Dot42.DexImport("glVertexPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlVertexPointer(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glViewport
				/// </java-name>
				[Dot42.DexImport("glViewport", "(IIII)V", AccessFlags = 265)]
				public static void GlViewport(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/GLES10Ext
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLES10Ext", AccessFlags = 33)]
		public partial class GLES10Ext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLES10Ext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glQueryMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glQueryMatrixxOES", "([II[II)I", AccessFlags = 265)]
				public static int GlQueryMatrixxOES(int[] int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glQueryMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I", AccessFlags = 265)]
				public static int GlQueryMatrixxOES(global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/opengl/GLES11
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLES11", AccessFlags = 33)]
		public partial class GLES11 : global::Android.Opengl.GLES10
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_ACTIVE_TEXTURE
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_TEXTURE", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_TEXTURE = 34016;
				/// <java-name>
				/// GL_ADD_SIGNED
				/// </java-name>
				[Dot42.DexImport("GL_ADD_SIGNED", "I", AccessFlags = 25)]
				public const int GL_ADD_SIGNED = 34164;
				/// <java-name>
				/// GL_ALPHA_SCALE
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_SCALE", "I", AccessFlags = 25)]
				public const int GL_ALPHA_SCALE = 3356;
				/// <java-name>
				/// GL_ALPHA_TEST_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_TEST_FUNC", "I", AccessFlags = 25)]
				public const int GL_ALPHA_TEST_FUNC = 3009;
				/// <java-name>
				/// GL_ALPHA_TEST_REF
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_TEST_REF", "I", AccessFlags = 25)]
				public const int GL_ALPHA_TEST_REF = 3010;
				/// <java-name>
				/// GL_ARRAY_BUFFER
				/// </java-name>
				[Dot42.DexImport("GL_ARRAY_BUFFER", "I", AccessFlags = 25)]
				public const int GL_ARRAY_BUFFER = 34962;
				/// <java-name>
				/// GL_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_ARRAY_BUFFER_BINDING = 34964;
				/// <java-name>
				/// GL_BLEND_DST
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST = 3040;
				/// <java-name>
				/// GL_BLEND_SRC
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC = 3041;
				/// <java-name>
				/// GL_BUFFER_ACCESS
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_ACCESS", "I", AccessFlags = 25)]
				public const int GL_BUFFER_ACCESS = 35003;
				/// <java-name>
				/// GL_BUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_SIZE", "I", AccessFlags = 25)]
				public const int GL_BUFFER_SIZE = 34660;
				/// <java-name>
				/// GL_BUFFER_USAGE
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_USAGE", "I", AccessFlags = 25)]
				public const int GL_BUFFER_USAGE = 34661;
				/// <java-name>
				/// GL_CLIENT_ACTIVE_TEXTURE
				/// </java-name>
				[Dot42.DexImport("GL_CLIENT_ACTIVE_TEXTURE", "I", AccessFlags = 25)]
				public const int GL_CLIENT_ACTIVE_TEXTURE = 34017;
				/// <java-name>
				/// GL_CLIP_PLANE0
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE0", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE0 = 12288;
				/// <java-name>
				/// GL_CLIP_PLANE1
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE1", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE1 = 12289;
				/// <java-name>
				/// GL_CLIP_PLANE2
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE2", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE2 = 12290;
				/// <java-name>
				/// GL_CLIP_PLANE3
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE3", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE3 = 12291;
				/// <java-name>
				/// GL_CLIP_PLANE4
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE4", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE4 = 12292;
				/// <java-name>
				/// GL_CLIP_PLANE5
				/// </java-name>
				[Dot42.DexImport("GL_CLIP_PLANE5", "I", AccessFlags = 25)]
				public const int GL_CLIP_PLANE5 = 12293;
				/// <java-name>
				/// GL_COLOR_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY_BUFFER_BINDING = 34968;
				/// <java-name>
				/// GL_COLOR_ARRAY_POINTER
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY_POINTER", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY_POINTER = 32912;
				/// <java-name>
				/// GL_COLOR_ARRAY_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY_SIZE", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY_SIZE = 32897;
				/// <java-name>
				/// GL_COLOR_ARRAY_STRIDE
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY_STRIDE", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY_STRIDE = 32899;
				/// <java-name>
				/// GL_COLOR_ARRAY_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ARRAY_TYPE", "I", AccessFlags = 25)]
				public const int GL_COLOR_ARRAY_TYPE = 32898;
				/// <java-name>
				/// GL_COLOR_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_COLOR_CLEAR_VALUE = 3106;
				/// <java-name>
				/// GL_COLOR_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_COLOR_WRITEMASK = 3107;
				/// <java-name>
				/// GL_COMBINE
				/// </java-name>
				[Dot42.DexImport("GL_COMBINE", "I", AccessFlags = 25)]
				public const int GL_COMBINE = 34160;
				/// <java-name>
				/// GL_COMBINE_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_COMBINE_ALPHA", "I", AccessFlags = 25)]
				public const int GL_COMBINE_ALPHA = 34162;
				/// <java-name>
				/// GL_COMBINE_RGB
				/// </java-name>
				[Dot42.DexImport("GL_COMBINE_RGB", "I", AccessFlags = 25)]
				public const int GL_COMBINE_RGB = 34161;
				/// <java-name>
				/// GL_CONSTANT
				/// </java-name>
				[Dot42.DexImport("GL_CONSTANT", "I", AccessFlags = 25)]
				public const int GL_CONSTANT = 34166;
				/// <java-name>
				/// GL_COORD_REPLACE_OES
				/// </java-name>
				[Dot42.DexImport("GL_COORD_REPLACE_OES", "I", AccessFlags = 25)]
				public const int GL_COORD_REPLACE_OES = 34914;
				/// <java-name>
				/// GL_CULL_FACE_MODE
				/// </java-name>
				[Dot42.DexImport("GL_CULL_FACE_MODE", "I", AccessFlags = 25)]
				public const int GL_CULL_FACE_MODE = 2885;
				/// <java-name>
				/// GL_CURRENT_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_COLOR", "I", AccessFlags = 25)]
				public const int GL_CURRENT_COLOR = 2816;
				/// <java-name>
				/// GL_CURRENT_NORMAL
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_NORMAL", "I", AccessFlags = 25)]
				public const int GL_CURRENT_NORMAL = 2818;
				/// <java-name>
				/// GL_CURRENT_TEXTURE_COORDS
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_TEXTURE_COORDS", "I", AccessFlags = 25)]
				public const int GL_CURRENT_TEXTURE_COORDS = 2819;
				/// <java-name>
				/// GL_DEPTH_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_DEPTH_CLEAR_VALUE = 2931;
				/// <java-name>
				/// GL_DEPTH_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_FUNC", "I", AccessFlags = 25)]
				public const int GL_DEPTH_FUNC = 2932;
				/// <java-name>
				/// GL_DEPTH_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_RANGE", "I", AccessFlags = 25)]
				public const int GL_DEPTH_RANGE = 2928;
				/// <java-name>
				/// GL_DEPTH_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_DEPTH_WRITEMASK = 2930;
				/// <java-name>
				/// GL_DOT3_RGB
				/// </java-name>
				[Dot42.DexImport("GL_DOT3_RGB", "I", AccessFlags = 25)]
				public const int GL_DOT3_RGB = 34478;
				/// <java-name>
				/// GL_DOT3_RGBA
				/// </java-name>
				[Dot42.DexImport("GL_DOT3_RGBA", "I", AccessFlags = 25)]
				public const int GL_DOT3_RGBA = 34479;
				/// <java-name>
				/// GL_DYNAMIC_DRAW
				/// </java-name>
				[Dot42.DexImport("GL_DYNAMIC_DRAW", "I", AccessFlags = 25)]
				public const int GL_DYNAMIC_DRAW = 35048;
				/// <java-name>
				/// GL_ELEMENT_ARRAY_BUFFER
				/// </java-name>
				[Dot42.DexImport("GL_ELEMENT_ARRAY_BUFFER", "I", AccessFlags = 25)]
				public const int GL_ELEMENT_ARRAY_BUFFER = 34963;
				/// <java-name>
				/// GL_ELEMENT_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_ELEMENT_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 34965;
				/// <java-name>
				/// GL_FRONT_FACE
				/// </java-name>
				[Dot42.DexImport("GL_FRONT_FACE", "I", AccessFlags = 25)]
				public const int GL_FRONT_FACE = 2886;
				/// <java-name>
				/// GL_GENERATE_MIPMAP
				/// </java-name>
				[Dot42.DexImport("GL_GENERATE_MIPMAP", "I", AccessFlags = 25)]
				public const int GL_GENERATE_MIPMAP = 33169;
				/// <java-name>
				/// GL_GENERATE_MIPMAP_HINT
				/// </java-name>
				[Dot42.DexImport("GL_GENERATE_MIPMAP_HINT", "I", AccessFlags = 25)]
				public const int GL_GENERATE_MIPMAP_HINT = 33170;
				/// <java-name>
				/// GL_INTERPOLATE
				/// </java-name>
				[Dot42.DexImport("GL_INTERPOLATE", "I", AccessFlags = 25)]
				public const int GL_INTERPOLATE = 34165;
				/// <java-name>
				/// GL_LINE_WIDTH
				/// </java-name>
				[Dot42.DexImport("GL_LINE_WIDTH", "I", AccessFlags = 25)]
				public const int GL_LINE_WIDTH = 2849;
				/// <java-name>
				/// GL_LOGIC_OP_MODE
				/// </java-name>
				[Dot42.DexImport("GL_LOGIC_OP_MODE", "I", AccessFlags = 25)]
				public const int GL_LOGIC_OP_MODE = 3056;
				/// <java-name>
				/// GL_MATRIX_MODE
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_MODE", "I", AccessFlags = 25)]
				public const int GL_MATRIX_MODE = 2976;
				/// <java-name>
				/// GL_MAX_CLIP_PLANES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_CLIP_PLANES", "I", AccessFlags = 25)]
				public const int GL_MAX_CLIP_PLANES = 3378;
				/// <java-name>
				/// GL_MODELVIEW_MATRIX
				/// </java-name>
				[Dot42.DexImport("GL_MODELVIEW_MATRIX", "I", AccessFlags = 25)]
				public const int GL_MODELVIEW_MATRIX = 2982;
				/// <java-name>
				/// GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 35213;
				/// <java-name>
				/// GL_MODELVIEW_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_MODELVIEW_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_MODELVIEW_STACK_DEPTH = 2979;
				/// <java-name>
				/// GL_NORMAL_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 34967;
				/// <java-name>
				/// GL_NORMAL_ARRAY_POINTER
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_ARRAY_POINTER", "I", AccessFlags = 25)]
				public const int GL_NORMAL_ARRAY_POINTER = 32911;
				/// <java-name>
				/// GL_NORMAL_ARRAY_STRIDE
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_ARRAY_STRIDE", "I", AccessFlags = 25)]
				public const int GL_NORMAL_ARRAY_STRIDE = 32895;
				/// <java-name>
				/// GL_NORMAL_ARRAY_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_ARRAY_TYPE", "I", AccessFlags = 25)]
				public const int GL_NORMAL_ARRAY_TYPE = 32894;
				/// <java-name>
				/// GL_OPERAND0_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND0_ALPHA", "I", AccessFlags = 25)]
				public const int GL_OPERAND0_ALPHA = 34200;
				/// <java-name>
				/// GL_OPERAND0_RGB
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND0_RGB", "I", AccessFlags = 25)]
				public const int GL_OPERAND0_RGB = 34192;
				/// <java-name>
				/// GL_OPERAND1_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND1_ALPHA", "I", AccessFlags = 25)]
				public const int GL_OPERAND1_ALPHA = 34201;
				/// <java-name>
				/// GL_OPERAND1_RGB
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND1_RGB", "I", AccessFlags = 25)]
				public const int GL_OPERAND1_RGB = 34193;
				/// <java-name>
				/// GL_OPERAND2_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND2_ALPHA", "I", AccessFlags = 25)]
				public const int GL_OPERAND2_ALPHA = 34202;
				/// <java-name>
				/// GL_OPERAND2_RGB
				/// </java-name>
				[Dot42.DexImport("GL_OPERAND2_RGB", "I", AccessFlags = 25)]
				public const int GL_OPERAND2_RGB = 34194;
				/// <java-name>
				/// GL_POINT_DISTANCE_ATTENUATION
				/// </java-name>
				[Dot42.DexImport("GL_POINT_DISTANCE_ATTENUATION", "I", AccessFlags = 25)]
				public const int GL_POINT_DISTANCE_ATTENUATION = 33065;
				/// <java-name>
				/// GL_POINT_FADE_THRESHOLD_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_POINT_FADE_THRESHOLD_SIZE", "I", AccessFlags = 25)]
				public const int GL_POINT_FADE_THRESHOLD_SIZE = 33064;
				/// <java-name>
				/// GL_POINT_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE = 2833;
				/// <java-name>
				/// GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 35743;
				/// <java-name>
				/// GL_POINT_SIZE_ARRAY_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_ARRAY_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_ARRAY_OES = 35740;
				/// <java-name>
				/// GL_POINT_SIZE_ARRAY_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_ARRAY_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_ARRAY_POINTER_OES = 35212;
				/// <java-name>
				/// GL_POINT_SIZE_ARRAY_STRIDE_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_ARRAY_STRIDE_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_ARRAY_STRIDE_OES = 35211;
				/// <java-name>
				/// GL_POINT_SIZE_ARRAY_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_ARRAY_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_ARRAY_TYPE_OES = 35210;
				/// <java-name>
				/// GL_POINT_SIZE_MAX
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_MAX", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_MAX = 33063;
				/// <java-name>
				/// GL_POINT_SIZE_MIN
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SIZE_MIN", "I", AccessFlags = 25)]
				public const int GL_POINT_SIZE_MIN = 33062;
				/// <java-name>
				/// GL_POINT_SPRITE_OES
				/// </java-name>
				[Dot42.DexImport("GL_POINT_SPRITE_OES", "I", AccessFlags = 25)]
				public const int GL_POINT_SPRITE_OES = 34913;
				/// <java-name>
				/// GL_POLYGON_OFFSET_FACTOR
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_FACTOR", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_FACTOR = 32824;
				/// <java-name>
				/// GL_POLYGON_OFFSET_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_UNITS", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_UNITS = 10752;
				/// <java-name>
				/// GL_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("GL_PREVIOUS", "I", AccessFlags = 25)]
				public const int GL_PREVIOUS = 34168;
				/// <java-name>
				/// GL_PRIMARY_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_PRIMARY_COLOR", "I", AccessFlags = 25)]
				public const int GL_PRIMARY_COLOR = 34167;
				/// <java-name>
				/// GL_PROJECTION_MATRIX
				/// </java-name>
				[Dot42.DexImport("GL_PROJECTION_MATRIX", "I", AccessFlags = 25)]
				public const int GL_PROJECTION_MATRIX = 2983;
				/// <java-name>
				/// GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 35214;
				/// <java-name>
				/// GL_PROJECTION_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_PROJECTION_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_PROJECTION_STACK_DEPTH = 2980;
				/// <java-name>
				/// GL_RGB_SCALE
				/// </java-name>
				[Dot42.DexImport("GL_RGB_SCALE", "I", AccessFlags = 25)]
				public const int GL_RGB_SCALE = 34163;
				/// <java-name>
				/// GL_SAMPLE_BUFFERS
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_BUFFERS", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_BUFFERS = 32936;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE_INVERT
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE_INVERT", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE_INVERT = 32939;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE_VALUE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE_VALUE = 32938;
				/// <java-name>
				/// GL_SAMPLES
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLES", "I", AccessFlags = 25)]
				public const int GL_SAMPLES = 32937;
				/// <java-name>
				/// GL_SCISSOR_BOX
				/// </java-name>
				[Dot42.DexImport("GL_SCISSOR_BOX", "I", AccessFlags = 25)]
				public const int GL_SCISSOR_BOX = 3088;
				/// <java-name>
				/// GL_SHADE_MODEL
				/// </java-name>
				[Dot42.DexImport("GL_SHADE_MODEL", "I", AccessFlags = 25)]
				public const int GL_SHADE_MODEL = 2900;
				/// <java-name>
				/// GL_SRC0_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_SRC0_ALPHA", "I", AccessFlags = 25)]
				public const int GL_SRC0_ALPHA = 34184;
				/// <java-name>
				/// GL_SRC0_RGB
				/// </java-name>
				[Dot42.DexImport("GL_SRC0_RGB", "I", AccessFlags = 25)]
				public const int GL_SRC0_RGB = 34176;
				/// <java-name>
				/// GL_SRC1_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_SRC1_ALPHA", "I", AccessFlags = 25)]
				public const int GL_SRC1_ALPHA = 34185;
				/// <java-name>
				/// GL_SRC1_RGB
				/// </java-name>
				[Dot42.DexImport("GL_SRC1_RGB", "I", AccessFlags = 25)]
				public const int GL_SRC1_RGB = 34177;
				/// <java-name>
				/// GL_SRC2_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_SRC2_ALPHA", "I", AccessFlags = 25)]
				public const int GL_SRC2_ALPHA = 34186;
				/// <java-name>
				/// GL_SRC2_RGB
				/// </java-name>
				[Dot42.DexImport("GL_SRC2_RGB", "I", AccessFlags = 25)]
				public const int GL_SRC2_RGB = 34178;
				/// <java-name>
				/// GL_STATIC_DRAW
				/// </java-name>
				[Dot42.DexImport("GL_STATIC_DRAW", "I", AccessFlags = 25)]
				public const int GL_STATIC_DRAW = 35044;
				/// <java-name>
				/// GL_STENCIL_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_STENCIL_CLEAR_VALUE = 2961;
				/// <java-name>
				/// GL_STENCIL_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_FAIL = 2964;
				/// <java-name>
				/// GL_STENCIL_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_FUNC", "I", AccessFlags = 25)]
				public const int GL_STENCIL_FUNC = 2962;
				/// <java-name>
				/// GL_STENCIL_PASS_DEPTH_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_PASS_DEPTH_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_PASS_DEPTH_FAIL = 2965;
				/// <java-name>
				/// GL_STENCIL_PASS_DEPTH_PASS
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_PASS_DEPTH_PASS", "I", AccessFlags = 25)]
				public const int GL_STENCIL_PASS_DEPTH_PASS = 2966;
				/// <java-name>
				/// GL_STENCIL_REF
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_REF", "I", AccessFlags = 25)]
				public const int GL_STENCIL_REF = 2967;
				/// <java-name>
				/// GL_STENCIL_VALUE_MASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_VALUE_MASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_VALUE_MASK = 2963;
				/// <java-name>
				/// GL_STENCIL_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_WRITEMASK = 2968;
				/// <java-name>
				/// GL_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("GL_SUBTRACT", "I", AccessFlags = 25)]
				public const int GL_SUBTRACT = 34023;
				/// <java-name>
				/// GL_TEXTURE_BINDING_2D
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_2D", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_2D = 32873;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 34970;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY_POINTER
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY_POINTER", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY_POINTER = 32914;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY_SIZE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY_SIZE = 32904;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY_STRIDE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY_STRIDE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 32906;
				/// <java-name>
				/// GL_TEXTURE_COORD_ARRAY_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_COORD_ARRAY_TYPE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_COORD_ARRAY_TYPE = 32905;
				/// <java-name>
				/// GL_TEXTURE_MATRIX
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MATRIX", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MATRIX = 2984;
				/// <java-name>
				/// GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 35215;
				/// <java-name>
				/// GL_TEXTURE_STACK_DEPTH
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_STACK_DEPTH", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_STACK_DEPTH = 2981;
				/// <java-name>
				/// GL_VERTEX_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 34966;
				/// <java-name>
				/// GL_VERTEX_ARRAY_POINTER
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY_POINTER", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY_POINTER = 32910;
				/// <java-name>
				/// GL_VERTEX_ARRAY_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY_SIZE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY_SIZE = 32890;
				/// <java-name>
				/// GL_VERTEX_ARRAY_STRIDE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY_STRIDE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY_STRIDE = 32892;
				/// <java-name>
				/// GL_VERTEX_ARRAY_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ARRAY_TYPE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ARRAY_TYPE = 32891;
				/// <java-name>
				/// GL_VIEWPORT
				/// </java-name>
				[Dot42.DexImport("GL_VIEWPORT", "I", AccessFlags = 25)]
				public const int GL_VIEWPORT = 2978;
				/// <java-name>
				/// GL_WRITE_ONLY
				/// </java-name>
				[Dot42.DexImport("GL_WRITE_ONLY", "I", AccessFlags = 25)]
				public const int GL_WRITE_ONLY = 35001;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLES11() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindBuffer
				/// </java-name>
				[Dot42.DexImport("glBindBuffer", "(II)V", AccessFlags = 265)]
				public static void GlBindBuffer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBufferData
				/// </java-name>
				[Dot42.DexImport("glBufferData", "(IILjava/nio/Buffer;I)V", AccessFlags = 265)]
				public static void GlBufferData(int int32, int int321, global::Java.Nio.Buffer buffer, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBufferSubData
				/// </java-name>
				[Dot42.DexImport("glBufferSubData", "(IIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlBufferSubData(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanef
				/// </java-name>
				[Dot42.DexImport("glClipPlanef", "(I[FI)V", AccessFlags = 265)]
				public static void GlClipPlanef(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanef
				/// </java-name>
				[Dot42.DexImport("glClipPlanef", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlClipPlanef(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanex
				/// </java-name>
				[Dot42.DexImport("glClipPlanex", "(I[II)V", AccessFlags = 265)]
				public static void GlClipPlanex(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanex
				/// </java-name>
				[Dot42.DexImport("glClipPlanex", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlClipPlanex(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColor4ub
				/// </java-name>
				[Dot42.DexImport("glColor4ub", "(BBBB)V", AccessFlags = 265)]
				public static void GlColor4ub(sbyte sByte, sbyte sByte1, sbyte sByte2, sbyte sByte3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColor4ub
				/// </java-name>
				[Dot42.DexImport("glColor4ub", "(BBBB)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlColor4ub(byte @byte, byte byte1, byte byte2, byte byte3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColorPointer
				/// </java-name>
				[Dot42.DexImport("glColorPointer", "(IIII)V", AccessFlags = 265)]
				public static void GlColorPointer(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteBuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteBuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIII)V", AccessFlags = 265)]
				public static void GlDrawElements(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlGenBuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenBuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(I[ZI)V", AccessFlags = 265)]
				public static void GlGetBooleanv(int int32, bool[] boolean, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetBooleanv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetBufferParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetBufferParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanef
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanef", "(I[FI)V", AccessFlags = 265)]
				public static void GlGetClipPlanef(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanef
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetClipPlanef(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanex
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanex", "(I[II)V", AccessFlags = 265)]
				public static void GlGetClipPlanex(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanex
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanex", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetClipPlanex(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFixedv
				/// </java-name>
				[Dot42.DexImport("glGetFixedv", "(I[II)V", AccessFlags = 265)]
				public static void GlGetFixedv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFixedv
				/// </java-name>
				[Dot42.DexImport("glGetFixedv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetFixedv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(I[FI)V", AccessFlags = 265)]
				public static void GlGetFloatv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetFloatv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightfv
				/// </java-name>
				[Dot42.DexImport("glGetLightfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetLightfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightfv
				/// </java-name>
				[Dot42.DexImport("glGetLightfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetLightfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightxv
				/// </java-name>
				[Dot42.DexImport("glGetLightxv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetLightxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightxv
				/// </java-name>
				[Dot42.DexImport("glGetLightxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetLightxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialfv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetMaterialfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialfv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetMaterialfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialxv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetMaterialxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialxv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetMaterialxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetTexEnvfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexEnvfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnviv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnviv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexEnviv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnviv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnviv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexEnviv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexEnvxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexEnvxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetTexParameterfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameterfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexParameterxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameterxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glIsBuffer
				/// </java-name>
				[Dot42.DexImport("glIsBuffer", "(I)Z", AccessFlags = 265)]
				public static bool GlIsBuffer(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsEnabled
				/// </java-name>
				[Dot42.DexImport("glIsEnabled", "(I)Z", AccessFlags = 265)]
				public static bool GlIsEnabled(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsTexture
				/// </java-name>
				[Dot42.DexImport("glIsTexture", "(I)Z", AccessFlags = 265)]
				public static bool GlIsTexture(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glNormalPointer
				/// </java-name>
				[Dot42.DexImport("glNormalPointer", "(III)V", AccessFlags = 265)]
				public static void GlNormalPointer(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterf
				/// </java-name>
				[Dot42.DexImport("glPointParameterf", "(IF)V", AccessFlags = 265)]
				public static void GlPointParameterf(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterfv
				/// </java-name>
				[Dot42.DexImport("glPointParameterfv", "(I[FI)V", AccessFlags = 265)]
				public static void GlPointParameterfv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterfv
				/// </java-name>
				[Dot42.DexImport("glPointParameterfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlPointParameterfv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterx
				/// </java-name>
				[Dot42.DexImport("glPointParameterx", "(II)V", AccessFlags = 265)]
				public static void GlPointParameterx(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterxv
				/// </java-name>
				[Dot42.DexImport("glPointParameterxv", "(I[II)V", AccessFlags = 265)]
				public static void GlPointParameterxv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterxv
				/// </java-name>
				[Dot42.DexImport("glPointParameterxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlPointParameterxv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointSizePointerOES
				/// </java-name>
				[Dot42.DexImport("glPointSizePointerOES", "(IILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlPointSizePointerOES(int int32, int int321, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexCoordPointer
				/// </java-name>
				[Dot42.DexImport("glTexCoordPointer", "(IIII)V", AccessFlags = 265)]
				public static void GlTexCoordPointer(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvi
				/// </java-name>
				[Dot42.DexImport("glTexEnvi", "(III)V", AccessFlags = 265)]
				public static void GlTexEnvi(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnviv
				/// </java-name>
				[Dot42.DexImport("glTexEnviv", "(II[II)V", AccessFlags = 265)]
				public static void GlTexEnviv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnviv
				/// </java-name>
				[Dot42.DexImport("glTexEnviv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexEnviv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlTexParameterfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameterfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteri
				/// </java-name>
				[Dot42.DexImport("glTexParameteri", "(III)V", AccessFlags = 265)]
				public static void GlTexParameteri(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlTexParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glTexParameterxv", "(II[II)V", AccessFlags = 265)]
				public static void GlTexParameterxv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glTexParameterxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameterxv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexPointer
				/// </java-name>
				[Dot42.DexImport("glVertexPointer", "(IIII)V", AccessFlags = 265)]
				public static void GlVertexPointer(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/GLES11Ext
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLES11Ext", AccessFlags = 33)]
		public partial class GLES11Ext
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_BLEND_EQUATION_RGB_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_RGB_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_RGB_OES = 32777;
				/// <java-name>
				/// GL_BLEND_EQUATION_ALPHA_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_ALPHA_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_ALPHA_OES = 34877;
				/// <java-name>
				/// GL_BLEND_DST_RGB_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_RGB_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_RGB_OES = 32968;
				/// <java-name>
				/// GL_BLEND_SRC_RGB_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_RGB_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_RGB_OES = 32969;
				/// <java-name>
				/// GL_BLEND_DST_ALPHA_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_ALPHA_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_ALPHA_OES = 32970;
				/// <java-name>
				/// GL_BLEND_SRC_ALPHA_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_ALPHA_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_ALPHA_OES = 32971;
				/// <java-name>
				/// GL_BLEND_EQUATION_OES
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_OES", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_OES = 32777;
				/// <java-name>
				/// GL_FUNC_ADD_OES
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_ADD_OES", "I", AccessFlags = 25)]
				public const int GL_FUNC_ADD_OES = 32774;
				/// <java-name>
				/// GL_FUNC_SUBTRACT_OES
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_SUBTRACT_OES", "I", AccessFlags = 25)]
				public const int GL_FUNC_SUBTRACT_OES = 32778;
				/// <java-name>
				/// GL_FUNC_REVERSE_SUBTRACT_OES
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_REVERSE_SUBTRACT_OES", "I", AccessFlags = 25)]
				public const int GL_FUNC_REVERSE_SUBTRACT_OES = 32779;
				/// <java-name>
				/// GL_ETC1_RGB8_OES
				/// </java-name>
				[Dot42.DexImport("GL_ETC1_RGB8_OES", "I", AccessFlags = 25)]
				public const int GL_ETC1_RGB8_OES = 36196;
				/// <java-name>
				/// GL_DEPTH_COMPONENT24_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT24_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT24_OES = 33190;
				/// <java-name>
				/// GL_DEPTH_COMPONENT32_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT32_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT32_OES = 33191;
				/// <java-name>
				/// GL_TEXTURE_CROP_RECT_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CROP_RECT_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CROP_RECT_OES = 35741;
				/// <java-name>
				/// GL_FIXED_OES
				/// </java-name>
				[Dot42.DexImport("GL_FIXED_OES", "I", AccessFlags = 25)]
				public const int GL_FIXED_OES = 5132;
				/// <java-name>
				/// GL_NONE_OES
				/// </java-name>
				[Dot42.DexImport("GL_NONE_OES", "I", AccessFlags = 25)]
				public const int GL_NONE_OES = 0;
				/// <java-name>
				/// GL_FRAMEBUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_OES = 36160;
				/// <java-name>
				/// GL_RENDERBUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_OES = 36161;
				/// <java-name>
				/// GL_RGBA4_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGBA4_OES", "I", AccessFlags = 25)]
				public const int GL_RGBA4_OES = 32854;
				/// <java-name>
				/// GL_RGB5_A1_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGB5_A1_OES", "I", AccessFlags = 25)]
				public const int GL_RGB5_A1_OES = 32855;
				/// <java-name>
				/// GL_RGB565_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGB565_OES", "I", AccessFlags = 25)]
				public const int GL_RGB565_OES = 36194;
				/// <java-name>
				/// GL_DEPTH_COMPONENT16_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT16_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT16_OES = 33189;
				/// <java-name>
				/// GL_RENDERBUFFER_WIDTH_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_WIDTH_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_WIDTH_OES = 36162;
				/// <java-name>
				/// GL_RENDERBUFFER_HEIGHT_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_HEIGHT_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_HEIGHT_OES = 36163;
				/// <java-name>
				/// GL_RENDERBUFFER_INTERNAL_FORMAT_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_INTERNAL_FORMAT_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 36164;
				/// <java-name>
				/// GL_RENDERBUFFER_RED_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_RED_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_RED_SIZE_OES = 36176;
				/// <java-name>
				/// GL_RENDERBUFFER_GREEN_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_GREEN_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_GREEN_SIZE_OES = 36177;
				/// <java-name>
				/// GL_RENDERBUFFER_BLUE_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BLUE_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BLUE_SIZE_OES = 36178;
				/// <java-name>
				/// GL_RENDERBUFFER_ALPHA_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_ALPHA_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_ALPHA_SIZE_OES = 36179;
				/// <java-name>
				/// GL_RENDERBUFFER_DEPTH_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_DEPTH_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_DEPTH_SIZE_OES = 36180;
				/// <java-name>
				/// GL_RENDERBUFFER_STENCIL_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_STENCIL_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_STENCIL_SIZE_OES = 36181;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 36048;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 36049;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 36050;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 36051;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT0_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT0_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT0_OES = 36064;
				/// <java-name>
				/// GL_DEPTH_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_ATTACHMENT_OES = 36096;
				/// <java-name>
				/// GL_STENCIL_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_STENCIL_ATTACHMENT_OES = 36128;
				/// <java-name>
				/// GL_FRAMEBUFFER_COMPLETE_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_COMPLETE_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_COMPLETE_OES = 36053;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 36054;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 36055;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 36057;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 36058;
				/// <java-name>
				/// GL_FRAMEBUFFER_UNSUPPORTED_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_UNSUPPORTED_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_UNSUPPORTED_OES = 36061;
				/// <java-name>
				/// GL_FRAMEBUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_BINDING_OES = 36006;
				/// <java-name>
				/// GL_RENDERBUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BINDING_OES = 36007;
				/// <java-name>
				/// GL_MAX_RENDERBUFFER_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_RENDERBUFFER_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_RENDERBUFFER_SIZE_OES = 34024;
				/// <java-name>
				/// GL_INVALID_FRAMEBUFFER_OPERATION_OES
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_FRAMEBUFFER_OPERATION_OES", "I", AccessFlags = 25)]
				public const int GL_INVALID_FRAMEBUFFER_OPERATION_OES = 1286;
				/// <java-name>
				/// GL_WRITE_ONLY_OES
				/// </java-name>
				[Dot42.DexImport("GL_WRITE_ONLY_OES", "I", AccessFlags = 25)]
				public const int GL_WRITE_ONLY_OES = 35001;
				/// <java-name>
				/// GL_BUFFER_ACCESS_OES
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_ACCESS_OES", "I", AccessFlags = 25)]
				public const int GL_BUFFER_ACCESS_OES = 35003;
				/// <java-name>
				/// GL_BUFFER_MAPPED_OES
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_MAPPED_OES", "I", AccessFlags = 25)]
				public const int GL_BUFFER_MAPPED_OES = 35004;
				/// <java-name>
				/// GL_BUFFER_MAP_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_MAP_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_BUFFER_MAP_POINTER_OES = 35005;
				/// <java-name>
				/// GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 35213;
				/// <java-name>
				/// GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 35214;
				/// <java-name>
				/// GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 35215;
				/// <java-name>
				/// GL_MAX_VERTEX_UNITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VERTEX_UNITS_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_VERTEX_UNITS_OES = 34468;
				/// <java-name>
				/// GL_MAX_PALETTE_MATRICES_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_PALETTE_MATRICES_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_PALETTE_MATRICES_OES = 34882;
				/// <java-name>
				/// GL_MATRIX_PALETTE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_PALETTE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_PALETTE_OES = 34880;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_OES = 34884;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_OES = 34477;
				/// <java-name>
				/// GL_CURRENT_PALETTE_MATRIX_OES
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_PALETTE_MATRIX_OES", "I", AccessFlags = 25)]
				public const int GL_CURRENT_PALETTE_MATRIX_OES = 34883;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_SIZE_OES = 34886;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_TYPE_OES = 34887;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_STRIDE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_STRIDE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 34888;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_POINTER_OES = 34889;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 35742;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_SIZE_OES = 34475;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_TYPE_OES = 34473;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_STRIDE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_STRIDE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_STRIDE_OES = 34474;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_POINTER_OES = 34476;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_BUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 34974;
				/// <java-name>
				/// GL_DEPTH_STENCIL_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_STENCIL_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_STENCIL_OES = 34041;
				/// <java-name>
				/// GL_UNSIGNED_INT_24_8_OES
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_INT_24_8_OES", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_INT_24_8_OES = 34042;
				/// <java-name>
				/// GL_DEPTH24_STENCIL8_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH24_STENCIL8_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH24_STENCIL8_OES = 35056;
				/// <java-name>
				/// GL_RGB8_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGB8_OES", "I", AccessFlags = 25)]
				public const int GL_RGB8_OES = 32849;
				/// <java-name>
				/// GL_RGBA8_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGBA8_OES", "I", AccessFlags = 25)]
				public const int GL_RGBA8_OES = 32856;
				/// <java-name>
				/// GL_STENCIL_INDEX1_OES
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX1_OES", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX1_OES = 36166;
				/// <java-name>
				/// GL_STENCIL_INDEX4_OES
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX4_OES", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX4_OES = 36167;
				/// <java-name>
				/// GL_STENCIL_INDEX8_OES
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX8_OES", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX8_OES = 36168;
				/// <java-name>
				/// GL_INCR_WRAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_INCR_WRAP_OES", "I", AccessFlags = 25)]
				public const int GL_INCR_WRAP_OES = 34055;
				/// <java-name>
				/// GL_DECR_WRAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_DECR_WRAP_OES", "I", AccessFlags = 25)]
				public const int GL_DECR_WRAP_OES = 34056;
				/// <java-name>
				/// GL_NORMAL_MAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_MAP_OES", "I", AccessFlags = 25)]
				public const int GL_NORMAL_MAP_OES = 34065;
				/// <java-name>
				/// GL_REFLECTION_MAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_REFLECTION_MAP_OES", "I", AccessFlags = 25)]
				public const int GL_REFLECTION_MAP_OES = 34066;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_OES = 34067;
				/// <java-name>
				/// GL_TEXTURE_BINDING_CUBE_MAP_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_CUBE_MAP_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_CUBE_MAP_OES = 34068;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 34069;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 34070;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 34071;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 34072;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 34073;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 34074;
				/// <java-name>
				/// GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 34076;
				/// <java-name>
				/// GL_TEXTURE_GEN_MODE_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_GEN_MODE_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_GEN_MODE_OES = 9472;
				/// <java-name>
				/// GL_TEXTURE_GEN_STR_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_GEN_STR_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_GEN_STR_OES = 36192;
				/// <java-name>
				/// GL_MIRRORED_REPEAT_OES
				/// </java-name>
				[Dot42.DexImport("GL_MIRRORED_REPEAT_OES", "I", AccessFlags = 25)]
				public const int GL_MIRRORED_REPEAT_OES = 33648;
				/// <java-name>
				/// GL_3DC_X_AMD
				/// </java-name>
				[Dot42.DexImport("GL_3DC_X_AMD", "I", AccessFlags = 25)]
				public const int GL_3DC_X_AMD = 34809;
				/// <java-name>
				/// GL_3DC_XY_AMD
				/// </java-name>
				[Dot42.DexImport("GL_3DC_XY_AMD", "I", AccessFlags = 25)]
				public const int GL_3DC_XY_AMD = 34810;
				/// <java-name>
				/// GL_ATC_RGB_AMD
				/// </java-name>
				[Dot42.DexImport("GL_ATC_RGB_AMD", "I", AccessFlags = 25)]
				public const int GL_ATC_RGB_AMD = 35986;
				/// <java-name>
				/// GL_ATC_RGBA_EXPLICIT_ALPHA_AMD
				/// </java-name>
				[Dot42.DexImport("GL_ATC_RGBA_EXPLICIT_ALPHA_AMD", "I", AccessFlags = 25)]
				public const int GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 35987;
				/// <java-name>
				/// GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD
				/// </java-name>
				[Dot42.DexImport("GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD", "I", AccessFlags = 25)]
				public const int GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 34798;
				/// <java-name>
				/// GL_TEXTURE_MAX_ANISOTROPY_EXT
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MAX_ANISOTROPY_EXT", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MAX_ANISOTROPY_EXT = 34046;
				/// <java-name>
				/// GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 34047;
				/// <java-name>
				/// GL_BGRA
				/// </java-name>
				[Dot42.DexImport("GL_BGRA", "I", AccessFlags = 25)]
				public const int GL_BGRA = 32993;
				/// <java-name>
				/// GL_TEXTURE_EXTERNAL_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_EXTERNAL_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_EXTERNAL_OES = 36197;
				/// <java-name>
				/// GL_SAMPLER_EXTERNAL_OES
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLER_EXTERNAL_OES", "I", AccessFlags = 25)]
				public const int GL_SAMPLER_EXTERNAL_OES = 36198;
				/// <java-name>
				/// GL_TEXTURE_BINDING_EXTERNAL_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_EXTERNAL_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_EXTERNAL_OES = 36199;
				/// <java-name>
				/// GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES", "I", AccessFlags = 25)]
				public const int GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 36200;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLES11Ext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendEquationSeparateOES
				/// </java-name>
				[Dot42.DexImport("glBlendEquationSeparateOES", "(II)V", AccessFlags = 265)]
				public static void GlBlendEquationSeparateOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendFuncSeparateOES
				/// </java-name>
				[Dot42.DexImport("glBlendFuncSeparateOES", "(IIII)V", AccessFlags = 265)]
				public static void GlBlendFuncSeparateOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendEquationOES
				/// </java-name>
				[Dot42.DexImport("glBlendEquationOES", "(I)V", AccessFlags = 265)]
				public static void GlBlendEquationOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexsOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsOES", "(SSSSS)V", AccessFlags = 265)]
				public static void GlDrawTexsOES(short int16, short int161, short int162, short int163, short int164) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexiOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexiOES", "(IIIII)V", AccessFlags = 265)]
				public static void GlDrawTexiOES(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexxOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxOES", "(IIIII)V", AccessFlags = 265)]
				public static void GlDrawTexxOES(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexsvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsvOES", "([SI)V", AccessFlags = 265)]
				public static void GlDrawTexsvOES(short[] int16, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexsvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V", AccessFlags = 265)]
				public static void GlDrawTexsvOES(global::Java.Nio.ShortBuffer shortBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexivOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexivOES", "([II)V", AccessFlags = 265)]
				public static void GlDrawTexivOES(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexivOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexivOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDrawTexivOES(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexxvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxvOES", "([II)V", AccessFlags = 265)]
				public static void GlDrawTexxvOES(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexxvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDrawTexxvOES(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexfOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfOES", "(FFFFF)V", AccessFlags = 265)]
				public static void GlDrawTexfOES(float single, float single1, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexfvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfvOES", "([FI)V", AccessFlags = 265)]
				public static void GlDrawTexfvOES(float[] single, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawTexfvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlDrawTexfvOES(global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEGLImageTargetTexture2DOES
				/// </java-name>
				[Dot42.DexImport("glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlEGLImageTargetTexture2DOES(int int32, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEGLImageTargetRenderbufferStorageOES
				/// </java-name>
				[Dot42.DexImport("glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlEGLImageTargetRenderbufferStorageOES(int int32, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glAlphaFuncxOES
				/// </java-name>
				[Dot42.DexImport("glAlphaFuncxOES", "(II)V", AccessFlags = 265)]
				public static void GlAlphaFuncxOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearColorxOES
				/// </java-name>
				[Dot42.DexImport("glClearColorxOES", "(IIII)V", AccessFlags = 265)]
				public static void GlClearColorxOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearDepthxOES
				/// </java-name>
				[Dot42.DexImport("glClearDepthxOES", "(I)V", AccessFlags = 265)]
				public static void GlClearDepthxOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanexOES
				/// </java-name>
				[Dot42.DexImport("glClipPlanexOES", "(I[II)V", AccessFlags = 265)]
				public static void GlClipPlanexOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanexOES
				/// </java-name>
				[Dot42.DexImport("glClipPlanexOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlClipPlanexOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColor4xOES
				/// </java-name>
				[Dot42.DexImport("glColor4xOES", "(IIII)V", AccessFlags = 265)]
				public static void GlColor4xOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthRangexOES
				/// </java-name>
				[Dot42.DexImport("glDepthRangexOES", "(II)V", AccessFlags = 265)]
				public static void GlDepthRangexOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogxOES
				/// </java-name>
				[Dot42.DexImport("glFogxOES", "(II)V", AccessFlags = 265)]
				public static void GlFogxOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogxvOES
				/// </java-name>
				[Dot42.DexImport("glFogxvOES", "(I[II)V", AccessFlags = 265)]
				public static void GlFogxvOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFogxvOES
				/// </java-name>
				[Dot42.DexImport("glFogxvOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlFogxvOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrustumxOES
				/// </java-name>
				[Dot42.DexImport("glFrustumxOES", "(IIIIII)V", AccessFlags = 265)]
				public static void GlFrustumxOES(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanexOES
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanexOES", "(I[II)V", AccessFlags = 265)]
				public static void GlGetClipPlanexOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanexOES
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetClipPlanexOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFixedvOES
				/// </java-name>
				[Dot42.DexImport("glGetFixedvOES", "(I[II)V", AccessFlags = 265)]
				public static void GlGetFixedvOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFixedvOES
				/// </java-name>
				[Dot42.DexImport("glGetFixedvOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetFixedvOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightxvOES
				/// </java-name>
				[Dot42.DexImport("glGetLightxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetLightxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetLightxvOES
				/// </java-name>
				[Dot42.DexImport("glGetLightxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetLightxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialxvOES
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetMaterialxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetMaterialxvOES
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetMaterialxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexEnvxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexEnvxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexEnvxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexParameterxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameterxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelxOES
				/// </java-name>
				[Dot42.DexImport("glLightModelxOES", "(II)V", AccessFlags = 265)]
				public static void GlLightModelxOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelxvOES
				/// </java-name>
				[Dot42.DexImport("glLightModelxvOES", "(I[II)V", AccessFlags = 265)]
				public static void GlLightModelxvOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightModelxvOES
				/// </java-name>
				[Dot42.DexImport("glLightModelxvOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLightModelxvOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightxOES
				/// </java-name>
				[Dot42.DexImport("glLightxOES", "(III)V", AccessFlags = 265)]
				public static void GlLightxOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightxvOES
				/// </java-name>
				[Dot42.DexImport("glLightxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlLightxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLightxvOES
				/// </java-name>
				[Dot42.DexImport("glLightxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLightxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLineWidthxOES
				/// </java-name>
				[Dot42.DexImport("glLineWidthxOES", "(I)V", AccessFlags = 265)]
				public static void GlLineWidthxOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixxOES", "([II)V", AccessFlags = 265)]
				public static void GlLoadMatrixxOES(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlLoadMatrixxOES(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialxOES
				/// </java-name>
				[Dot42.DexImport("glMaterialxOES", "(III)V", AccessFlags = 265)]
				public static void GlMaterialxOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialxvOES
				/// </java-name>
				[Dot42.DexImport("glMaterialxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlMaterialxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMaterialxvOES
				/// </java-name>
				[Dot42.DexImport("glMaterialxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlMaterialxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glMultMatrixxOES", "([II)V", AccessFlags = 265)]
				public static void GlMultMatrixxOES(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlMultMatrixxOES(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMultiTexCoord4xOES
				/// </java-name>
				[Dot42.DexImport("glMultiTexCoord4xOES", "(IIIII)V", AccessFlags = 265)]
				public static void GlMultiTexCoord4xOES(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glNormal3xOES
				/// </java-name>
				[Dot42.DexImport("glNormal3xOES", "(III)V", AccessFlags = 265)]
				public static void GlNormal3xOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glOrthoxOES
				/// </java-name>
				[Dot42.DexImport("glOrthoxOES", "(IIIIII)V", AccessFlags = 265)]
				public static void GlOrthoxOES(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterxOES
				/// </java-name>
				[Dot42.DexImport("glPointParameterxOES", "(II)V", AccessFlags = 265)]
				public static void GlPointParameterxOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glPointParameterxvOES", "(I[II)V", AccessFlags = 265)]
				public static void GlPointParameterxvOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlPointParameterxvOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPointSizexOES
				/// </java-name>
				[Dot42.DexImport("glPointSizexOES", "(I)V", AccessFlags = 265)]
				public static void GlPointSizexOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPolygonOffsetxOES
				/// </java-name>
				[Dot42.DexImport("glPolygonOffsetxOES", "(II)V", AccessFlags = 265)]
				public static void GlPolygonOffsetxOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glRotatexOES
				/// </java-name>
				[Dot42.DexImport("glRotatexOES", "(IIII)V", AccessFlags = 265)]
				public static void GlRotatexOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glSampleCoveragexOES
				/// </java-name>
				[Dot42.DexImport("glSampleCoveragexOES", "(IZ)V", AccessFlags = 265)]
				public static void GlSampleCoveragexOES(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glScalexOES
				/// </java-name>
				[Dot42.DexImport("glScalexOES", "(III)V", AccessFlags = 265)]
				public static void GlScalexOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvxOES
				/// </java-name>
				[Dot42.DexImport("glTexEnvxOES", "(III)V", AccessFlags = 265)]
				public static void GlTexEnvxOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvxvOES
				/// </java-name>
				[Dot42.DexImport("glTexEnvxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlTexEnvxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexEnvxvOES
				/// </java-name>
				[Dot42.DexImport("glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexEnvxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterxOES
				/// </java-name>
				[Dot42.DexImport("glTexParameterxOES", "(III)V", AccessFlags = 265)]
				public static void GlTexParameterxOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glTexParameterxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlTexParameterxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterxvOES
				/// </java-name>
				[Dot42.DexImport("glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameterxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTranslatexOES
				/// </java-name>
				[Dot42.DexImport("glTranslatexOES", "(III)V", AccessFlags = 265)]
				public static void GlTranslatexOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glIsRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glIsRenderbufferOES", "(I)Z", AccessFlags = 265)]
				public static bool GlIsRenderbufferOES(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glBindRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glBindRenderbufferOES", "(II)V", AccessFlags = 265)]
				public static void GlBindRenderbufferOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffersOES", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteRenderbuffersOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteRenderbuffersOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffersOES", "(I[II)V", AccessFlags = 265)]
				public static void GlGenRenderbuffersOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenRenderbuffersOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glRenderbufferStorageOES
				/// </java-name>
				[Dot42.DexImport("glRenderbufferStorageOES", "(IIII)V", AccessFlags = 265)]
				public static void GlRenderbufferStorageOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetRenderbufferParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameterivOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetRenderbufferParameterivOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetRenderbufferParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetRenderbufferParameterivOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glIsFramebufferOES
				/// </java-name>
				[Dot42.DexImport("glIsFramebufferOES", "(I)Z", AccessFlags = 265)]
				public static bool GlIsFramebufferOES(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glBindFramebufferOES
				/// </java-name>
				[Dot42.DexImport("glBindFramebufferOES", "(II)V", AccessFlags = 265)]
				public static void GlBindFramebufferOES(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffersOES", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteFramebuffersOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteFramebuffersOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffersOES", "(I[II)V", AccessFlags = 265)]
				public static void GlGenFramebuffersOES(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenFramebuffersOES(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCheckFramebufferStatusOES
				/// </java-name>
				[Dot42.DexImport("glCheckFramebufferStatusOES", "(I)I", AccessFlags = 265)]
				public static int GlCheckFramebufferStatusOES(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glFramebufferRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glFramebufferRenderbufferOES", "(IIII)V", AccessFlags = 265)]
				public static void GlFramebufferRenderbufferOES(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFramebufferTexture2DOES
				/// </java-name>
				[Dot42.DexImport("glFramebufferTexture2DOES", "(IIIII)V", AccessFlags = 265)]
				public static void GlFramebufferTexture2DOES(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFramebufferAttachmentParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameterivOES", "(III[II)V", AccessFlags = 265)]
				public static void GlGetFramebufferAttachmentParameterivOES(int int32, int int321, int int322, int[] int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFramebufferAttachmentParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetFramebufferAttachmentParameterivOES(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenerateMipmapOES
				/// </java-name>
				[Dot42.DexImport("glGenerateMipmapOES", "(I)V", AccessFlags = 265)]
				public static void GlGenerateMipmapOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCurrentPaletteMatrixOES
				/// </java-name>
				[Dot42.DexImport("glCurrentPaletteMatrixOES", "(I)V", AccessFlags = 265)]
				public static void GlCurrentPaletteMatrixOES(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLoadPaletteFromModelViewMatrixOES
				/// </java-name>
				[Dot42.DexImport("glLoadPaletteFromModelViewMatrixOES", "()V", AccessFlags = 265)]
				public static void GlLoadPaletteFromModelViewMatrixOES() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glMatrixIndexPointerOES
				/// </java-name>
				[Dot42.DexImport("glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlMatrixIndexPointerOES(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glWeightPointerOES
				/// </java-name>
				[Dot42.DexImport("glWeightPointerOES", "(IIILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlWeightPointerOES(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthRangefOES
				/// </java-name>
				[Dot42.DexImport("glDepthRangefOES", "(FF)V", AccessFlags = 265)]
				public static void GlDepthRangefOES(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrustumfOES
				/// </java-name>
				[Dot42.DexImport("glFrustumfOES", "(FFFFFF)V", AccessFlags = 265)]
				public static void GlFrustumfOES(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glOrthofOES
				/// </java-name>
				[Dot42.DexImport("glOrthofOES", "(FFFFFF)V", AccessFlags = 265)]
				public static void GlOrthofOES(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanefOES
				/// </java-name>
				[Dot42.DexImport("glClipPlanefOES", "(I[FI)V", AccessFlags = 265)]
				public static void GlClipPlanefOES(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClipPlanefOES
				/// </java-name>
				[Dot42.DexImport("glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlClipPlanefOES(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanefOES
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanefOES", "(I[FI)V", AccessFlags = 265)]
				public static void GlGetClipPlanefOES(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetClipPlanefOES
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetClipPlanefOES(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearDepthfOES
				/// </java-name>
				[Dot42.DexImport("glClearDepthfOES", "(F)V", AccessFlags = 265)]
				public static void GlClearDepthfOES(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenfOES
				/// </java-name>
				[Dot42.DexImport("glTexGenfOES", "(IIF)V", AccessFlags = 265)]
				public static void GlTexGenfOES(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenfvOES
				/// </java-name>
				[Dot42.DexImport("glTexGenfvOES", "(II[FI)V", AccessFlags = 265)]
				public static void GlTexGenfvOES(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenfvOES
				/// </java-name>
				[Dot42.DexImport("glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlTexGenfvOES(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGeniOES
				/// </java-name>
				[Dot42.DexImport("glTexGeniOES", "(III)V", AccessFlags = 265)]
				public static void GlTexGeniOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenivOES
				/// </java-name>
				[Dot42.DexImport("glTexGenivOES", "(II[II)V", AccessFlags = 265)]
				public static void GlTexGenivOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenivOES
				/// </java-name>
				[Dot42.DexImport("glTexGenivOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexGenivOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenxOES
				/// </java-name>
				[Dot42.DexImport("glTexGenxOES", "(III)V", AccessFlags = 265)]
				public static void GlTexGenxOES(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenxvOES
				/// </java-name>
				[Dot42.DexImport("glTexGenxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlTexGenxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexGenxvOES
				/// </java-name>
				[Dot42.DexImport("glTexGenxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexGenxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenfvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenfvOES", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetTexGenfvOES(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenfvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexGenfvOES(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenivOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenivOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexGenivOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenivOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexGenivOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenxvOES", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexGenxvOES(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexGenxvOES
				/// </java-name>
				[Dot42.DexImport("glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexGenxvOES(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/GLES20
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLES20", AccessFlags = 33)]
		public partial class GLES20
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_ACTIVE_TEXTURE
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_TEXTURE", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_TEXTURE = 34016;
				/// <java-name>
				/// GL_DEPTH_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_DEPTH_BUFFER_BIT = 256;
				/// <java-name>
				/// GL_STENCIL_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BUFFER_BIT = 1024;
				/// <java-name>
				/// GL_COLOR_BUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_BUFFER_BIT", "I", AccessFlags = 25)]
				public const int GL_COLOR_BUFFER_BIT = 16384;
				/// <java-name>
				/// GL_FALSE
				/// </java-name>
				[Dot42.DexImport("GL_FALSE", "I", AccessFlags = 25)]
				public const int GL_FALSE = 0;
				/// <java-name>
				/// GL_TRUE
				/// </java-name>
				[Dot42.DexImport("GL_TRUE", "I", AccessFlags = 25)]
				public const int GL_TRUE = 1;
				/// <java-name>
				/// GL_POINTS
				/// </java-name>
				[Dot42.DexImport("GL_POINTS", "I", AccessFlags = 25)]
				public const int GL_POINTS = 0;
				/// <java-name>
				/// GL_LINES
				/// </java-name>
				[Dot42.DexImport("GL_LINES", "I", AccessFlags = 25)]
				public const int GL_LINES = 1;
				/// <java-name>
				/// GL_LINE_LOOP
				/// </java-name>
				[Dot42.DexImport("GL_LINE_LOOP", "I", AccessFlags = 25)]
				public const int GL_LINE_LOOP = 2;
				/// <java-name>
				/// GL_LINE_STRIP
				/// </java-name>
				[Dot42.DexImport("GL_LINE_STRIP", "I", AccessFlags = 25)]
				public const int GL_LINE_STRIP = 3;
				/// <java-name>
				/// GL_TRIANGLES
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLES", "I", AccessFlags = 25)]
				public const int GL_TRIANGLES = 4;
				/// <java-name>
				/// GL_TRIANGLE_STRIP
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLE_STRIP", "I", AccessFlags = 25)]
				public const int GL_TRIANGLE_STRIP = 5;
				/// <java-name>
				/// GL_TRIANGLE_FAN
				/// </java-name>
				[Dot42.DexImport("GL_TRIANGLE_FAN", "I", AccessFlags = 25)]
				public const int GL_TRIANGLE_FAN = 6;
				/// <java-name>
				/// GL_ZERO
				/// </java-name>
				[Dot42.DexImport("GL_ZERO", "I", AccessFlags = 25)]
				public const int GL_ZERO = 0;
				/// <java-name>
				/// GL_ONE
				/// </java-name>
				[Dot42.DexImport("GL_ONE", "I", AccessFlags = 25)]
				public const int GL_ONE = 1;
				/// <java-name>
				/// GL_SRC_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_SRC_COLOR", "I", AccessFlags = 25)]
				public const int GL_SRC_COLOR = 768;
				/// <java-name>
				/// GL_ONE_MINUS_SRC_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_SRC_COLOR", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_SRC_COLOR = 769;
				/// <java-name>
				/// GL_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_SRC_ALPHA = 770;
				/// <java-name>
				/// GL_ONE_MINUS_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_SRC_ALPHA = 771;
				/// <java-name>
				/// GL_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_DST_ALPHA = 772;
				/// <java-name>
				/// GL_ONE_MINUS_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_DST_ALPHA = 773;
				/// <java-name>
				/// GL_DST_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_DST_COLOR", "I", AccessFlags = 25)]
				public const int GL_DST_COLOR = 774;
				/// <java-name>
				/// GL_ONE_MINUS_DST_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_DST_COLOR", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_DST_COLOR = 775;
				/// <java-name>
				/// GL_SRC_ALPHA_SATURATE
				/// </java-name>
				[Dot42.DexImport("GL_SRC_ALPHA_SATURATE", "I", AccessFlags = 25)]
				public const int GL_SRC_ALPHA_SATURATE = 776;
				/// <java-name>
				/// GL_FUNC_ADD
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_ADD", "I", AccessFlags = 25)]
				public const int GL_FUNC_ADD = 32774;
				/// <java-name>
				/// GL_BLEND_EQUATION
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION = 32777;
				/// <java-name>
				/// GL_BLEND_EQUATION_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_RGB = 32777;
				/// <java-name>
				/// GL_BLEND_EQUATION_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_ALPHA = 34877;
				/// <java-name>
				/// GL_FUNC_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_SUBTRACT", "I", AccessFlags = 25)]
				public const int GL_FUNC_SUBTRACT = 32778;
				/// <java-name>
				/// GL_FUNC_REVERSE_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_REVERSE_SUBTRACT", "I", AccessFlags = 25)]
				public const int GL_FUNC_REVERSE_SUBTRACT = 32779;
				/// <java-name>
				/// GL_BLEND_DST_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_RGB = 32968;
				/// <java-name>
				/// GL_BLEND_SRC_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_RGB = 32969;
				/// <java-name>
				/// GL_BLEND_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_ALPHA = 32970;
				/// <java-name>
				/// GL_BLEND_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_ALPHA = 32971;
				/// <java-name>
				/// GL_CONSTANT_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_CONSTANT_COLOR", "I", AccessFlags = 25)]
				public const int GL_CONSTANT_COLOR = 32769;
				/// <java-name>
				/// GL_ONE_MINUS_CONSTANT_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_CONSTANT_COLOR", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_CONSTANT_COLOR = 32770;
				/// <java-name>
				/// GL_CONSTANT_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_CONSTANT_ALPHA", "I", AccessFlags = 25)]
				public const int GL_CONSTANT_ALPHA = 32771;
				/// <java-name>
				/// GL_ONE_MINUS_CONSTANT_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ONE_MINUS_CONSTANT_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ONE_MINUS_CONSTANT_ALPHA = 32772;
				/// <java-name>
				/// GL_BLEND_COLOR
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_COLOR", "I", AccessFlags = 25)]
				public const int GL_BLEND_COLOR = 32773;
				/// <java-name>
				/// GL_ARRAY_BUFFER
				/// </java-name>
				[Dot42.DexImport("GL_ARRAY_BUFFER", "I", AccessFlags = 25)]
				public const int GL_ARRAY_BUFFER = 34962;
				/// <java-name>
				/// GL_ELEMENT_ARRAY_BUFFER
				/// </java-name>
				[Dot42.DexImport("GL_ELEMENT_ARRAY_BUFFER", "I", AccessFlags = 25)]
				public const int GL_ELEMENT_ARRAY_BUFFER = 34963;
				/// <java-name>
				/// GL_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_ARRAY_BUFFER_BINDING = 34964;
				/// <java-name>
				/// GL_ELEMENT_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_ELEMENT_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 34965;
				/// <java-name>
				/// GL_STREAM_DRAW
				/// </java-name>
				[Dot42.DexImport("GL_STREAM_DRAW", "I", AccessFlags = 25)]
				public const int GL_STREAM_DRAW = 35040;
				/// <java-name>
				/// GL_STATIC_DRAW
				/// </java-name>
				[Dot42.DexImport("GL_STATIC_DRAW", "I", AccessFlags = 25)]
				public const int GL_STATIC_DRAW = 35044;
				/// <java-name>
				/// GL_DYNAMIC_DRAW
				/// </java-name>
				[Dot42.DexImport("GL_DYNAMIC_DRAW", "I", AccessFlags = 25)]
				public const int GL_DYNAMIC_DRAW = 35048;
				/// <java-name>
				/// GL_BUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_SIZE", "I", AccessFlags = 25)]
				public const int GL_BUFFER_SIZE = 34660;
				/// <java-name>
				/// GL_BUFFER_USAGE
				/// </java-name>
				[Dot42.DexImport("GL_BUFFER_USAGE", "I", AccessFlags = 25)]
				public const int GL_BUFFER_USAGE = 34661;
				/// <java-name>
				/// GL_CURRENT_VERTEX_ATTRIB
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_VERTEX_ATTRIB", "I", AccessFlags = 25)]
				public const int GL_CURRENT_VERTEX_ATTRIB = 34342;
				/// <java-name>
				/// GL_FRONT
				/// </java-name>
				[Dot42.DexImport("GL_FRONT", "I", AccessFlags = 25)]
				public const int GL_FRONT = 1028;
				/// <java-name>
				/// GL_BACK
				/// </java-name>
				[Dot42.DexImport("GL_BACK", "I", AccessFlags = 25)]
				public const int GL_BACK = 1029;
				/// <java-name>
				/// GL_FRONT_AND_BACK
				/// </java-name>
				[Dot42.DexImport("GL_FRONT_AND_BACK", "I", AccessFlags = 25)]
				public const int GL_FRONT_AND_BACK = 1032;
				/// <java-name>
				/// GL_TEXTURE_2D
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_2D", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_2D = 3553;
				/// <java-name>
				/// GL_CULL_FACE
				/// </java-name>
				[Dot42.DexImport("GL_CULL_FACE", "I", AccessFlags = 25)]
				public const int GL_CULL_FACE = 2884;
				/// <java-name>
				/// GL_BLEND
				/// </java-name>
				[Dot42.DexImport("GL_BLEND", "I", AccessFlags = 25)]
				public const int GL_BLEND = 3042;
				/// <java-name>
				/// GL_DITHER
				/// </java-name>
				[Dot42.DexImport("GL_DITHER", "I", AccessFlags = 25)]
				public const int GL_DITHER = 3024;
				/// <java-name>
				/// GL_STENCIL_TEST
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_TEST", "I", AccessFlags = 25)]
				public const int GL_STENCIL_TEST = 2960;
				/// <java-name>
				/// GL_DEPTH_TEST
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_TEST", "I", AccessFlags = 25)]
				public const int GL_DEPTH_TEST = 2929;
				/// <java-name>
				/// GL_SCISSOR_TEST
				/// </java-name>
				[Dot42.DexImport("GL_SCISSOR_TEST", "I", AccessFlags = 25)]
				public const int GL_SCISSOR_TEST = 3089;
				/// <java-name>
				/// GL_POLYGON_OFFSET_FILL
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_FILL", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_FILL = 32823;
				/// <java-name>
				/// GL_SAMPLE_ALPHA_TO_COVERAGE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_ALPHA_TO_COVERAGE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 32926;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE = 32928;
				/// <java-name>
				/// GL_NO_ERROR
				/// </java-name>
				[Dot42.DexImport("GL_NO_ERROR", "I", AccessFlags = 25)]
				public const int GL_NO_ERROR = 0;
				/// <java-name>
				/// GL_INVALID_ENUM
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_ENUM", "I", AccessFlags = 25)]
				public const int GL_INVALID_ENUM = 1280;
				/// <java-name>
				/// GL_INVALID_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_VALUE", "I", AccessFlags = 25)]
				public const int GL_INVALID_VALUE = 1281;
				/// <java-name>
				/// GL_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int GL_INVALID_OPERATION = 1282;
				/// <java-name>
				/// GL_OUT_OF_MEMORY
				/// </java-name>
				[Dot42.DexImport("GL_OUT_OF_MEMORY", "I", AccessFlags = 25)]
				public const int GL_OUT_OF_MEMORY = 1285;
				/// <java-name>
				/// GL_CW
				/// </java-name>
				[Dot42.DexImport("GL_CW", "I", AccessFlags = 25)]
				public const int GL_CW = 2304;
				/// <java-name>
				/// GL_CCW
				/// </java-name>
				[Dot42.DexImport("GL_CCW", "I", AccessFlags = 25)]
				public const int GL_CCW = 2305;
				/// <java-name>
				/// GL_LINE_WIDTH
				/// </java-name>
				[Dot42.DexImport("GL_LINE_WIDTH", "I", AccessFlags = 25)]
				public const int GL_LINE_WIDTH = 2849;
				/// <java-name>
				/// GL_ALIASED_POINT_SIZE_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_ALIASED_POINT_SIZE_RANGE", "I", AccessFlags = 25)]
				public const int GL_ALIASED_POINT_SIZE_RANGE = 33901;
				/// <java-name>
				/// GL_ALIASED_LINE_WIDTH_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_ALIASED_LINE_WIDTH_RANGE", "I", AccessFlags = 25)]
				public const int GL_ALIASED_LINE_WIDTH_RANGE = 33902;
				/// <java-name>
				/// GL_CULL_FACE_MODE
				/// </java-name>
				[Dot42.DexImport("GL_CULL_FACE_MODE", "I", AccessFlags = 25)]
				public const int GL_CULL_FACE_MODE = 2885;
				/// <java-name>
				/// GL_FRONT_FACE
				/// </java-name>
				[Dot42.DexImport("GL_FRONT_FACE", "I", AccessFlags = 25)]
				public const int GL_FRONT_FACE = 2886;
				/// <java-name>
				/// GL_DEPTH_RANGE
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_RANGE", "I", AccessFlags = 25)]
				public const int GL_DEPTH_RANGE = 2928;
				/// <java-name>
				/// GL_DEPTH_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_DEPTH_WRITEMASK = 2930;
				/// <java-name>
				/// GL_DEPTH_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_DEPTH_CLEAR_VALUE = 2931;
				/// <java-name>
				/// GL_DEPTH_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_FUNC", "I", AccessFlags = 25)]
				public const int GL_DEPTH_FUNC = 2932;
				/// <java-name>
				/// GL_STENCIL_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_STENCIL_CLEAR_VALUE = 2961;
				/// <java-name>
				/// GL_STENCIL_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_FUNC", "I", AccessFlags = 25)]
				public const int GL_STENCIL_FUNC = 2962;
				/// <java-name>
				/// GL_STENCIL_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_FAIL = 2964;
				/// <java-name>
				/// GL_STENCIL_PASS_DEPTH_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_PASS_DEPTH_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_PASS_DEPTH_FAIL = 2965;
				/// <java-name>
				/// GL_STENCIL_PASS_DEPTH_PASS
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_PASS_DEPTH_PASS", "I", AccessFlags = 25)]
				public const int GL_STENCIL_PASS_DEPTH_PASS = 2966;
				/// <java-name>
				/// GL_STENCIL_REF
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_REF", "I", AccessFlags = 25)]
				public const int GL_STENCIL_REF = 2967;
				/// <java-name>
				/// GL_STENCIL_VALUE_MASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_VALUE_MASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_VALUE_MASK = 2963;
				/// <java-name>
				/// GL_STENCIL_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_WRITEMASK = 2968;
				/// <java-name>
				/// GL_STENCIL_BACK_FUNC
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_FUNC", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_FUNC = 34816;
				/// <java-name>
				/// GL_STENCIL_BACK_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_FAIL = 34817;
				/// <java-name>
				/// GL_STENCIL_BACK_PASS_DEPTH_FAIL
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_PASS_DEPTH_FAIL", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 34818;
				/// <java-name>
				/// GL_STENCIL_BACK_PASS_DEPTH_PASS
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_PASS_DEPTH_PASS", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 34819;
				/// <java-name>
				/// GL_STENCIL_BACK_REF
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_REF", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_REF = 36003;
				/// <java-name>
				/// GL_STENCIL_BACK_VALUE_MASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_VALUE_MASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_VALUE_MASK = 36004;
				/// <java-name>
				/// GL_STENCIL_BACK_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BACK_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BACK_WRITEMASK = 36005;
				/// <java-name>
				/// GL_VIEWPORT
				/// </java-name>
				[Dot42.DexImport("GL_VIEWPORT", "I", AccessFlags = 25)]
				public const int GL_VIEWPORT = 2978;
				/// <java-name>
				/// GL_SCISSOR_BOX
				/// </java-name>
				[Dot42.DexImport("GL_SCISSOR_BOX", "I", AccessFlags = 25)]
				public const int GL_SCISSOR_BOX = 3088;
				/// <java-name>
				/// GL_COLOR_CLEAR_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_CLEAR_VALUE", "I", AccessFlags = 25)]
				public const int GL_COLOR_CLEAR_VALUE = 3106;
				/// <java-name>
				/// GL_COLOR_WRITEMASK
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_WRITEMASK", "I", AccessFlags = 25)]
				public const int GL_COLOR_WRITEMASK = 3107;
				/// <java-name>
				/// GL_UNPACK_ALIGNMENT
				/// </java-name>
				[Dot42.DexImport("GL_UNPACK_ALIGNMENT", "I", AccessFlags = 25)]
				public const int GL_UNPACK_ALIGNMENT = 3317;
				/// <java-name>
				/// GL_PACK_ALIGNMENT
				/// </java-name>
				[Dot42.DexImport("GL_PACK_ALIGNMENT", "I", AccessFlags = 25)]
				public const int GL_PACK_ALIGNMENT = 3333;
				/// <java-name>
				/// GL_MAX_TEXTURE_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_SIZE", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_SIZE = 3379;
				/// <java-name>
				/// GL_MAX_VIEWPORT_DIMS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VIEWPORT_DIMS", "I", AccessFlags = 25)]
				public const int GL_MAX_VIEWPORT_DIMS = 3386;
				/// <java-name>
				/// GL_SUBPIXEL_BITS
				/// </java-name>
				[Dot42.DexImport("GL_SUBPIXEL_BITS", "I", AccessFlags = 25)]
				public const int GL_SUBPIXEL_BITS = 3408;
				/// <java-name>
				/// GL_RED_BITS
				/// </java-name>
				[Dot42.DexImport("GL_RED_BITS", "I", AccessFlags = 25)]
				public const int GL_RED_BITS = 3410;
				/// <java-name>
				/// GL_GREEN_BITS
				/// </java-name>
				[Dot42.DexImport("GL_GREEN_BITS", "I", AccessFlags = 25)]
				public const int GL_GREEN_BITS = 3411;
				/// <java-name>
				/// GL_BLUE_BITS
				/// </java-name>
				[Dot42.DexImport("GL_BLUE_BITS", "I", AccessFlags = 25)]
				public const int GL_BLUE_BITS = 3412;
				/// <java-name>
				/// GL_ALPHA_BITS
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA_BITS", "I", AccessFlags = 25)]
				public const int GL_ALPHA_BITS = 3413;
				/// <java-name>
				/// GL_DEPTH_BITS
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_BITS", "I", AccessFlags = 25)]
				public const int GL_DEPTH_BITS = 3414;
				/// <java-name>
				/// GL_STENCIL_BITS
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_BITS", "I", AccessFlags = 25)]
				public const int GL_STENCIL_BITS = 3415;
				/// <java-name>
				/// GL_POLYGON_OFFSET_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_UNITS", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_UNITS = 10752;
				/// <java-name>
				/// GL_POLYGON_OFFSET_FACTOR
				/// </java-name>
				[Dot42.DexImport("GL_POLYGON_OFFSET_FACTOR", "I", AccessFlags = 25)]
				public const int GL_POLYGON_OFFSET_FACTOR = 32824;
				/// <java-name>
				/// GL_TEXTURE_BINDING_2D
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_2D", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_2D = 32873;
				/// <java-name>
				/// GL_SAMPLE_BUFFERS
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_BUFFERS", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_BUFFERS = 32936;
				/// <java-name>
				/// GL_SAMPLES
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLES", "I", AccessFlags = 25)]
				public const int GL_SAMPLES = 32937;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE_VALUE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE_VALUE", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE_VALUE = 32938;
				/// <java-name>
				/// GL_SAMPLE_COVERAGE_INVERT
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLE_COVERAGE_INVERT", "I", AccessFlags = 25)]
				public const int GL_SAMPLE_COVERAGE_INVERT = 32939;
				/// <java-name>
				/// GL_NUM_COMPRESSED_TEXTURE_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_NUM_COMPRESSED_TEXTURE_FORMATS", "I", AccessFlags = 25)]
				public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 34466;
				/// <java-name>
				/// GL_COMPRESSED_TEXTURE_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_COMPRESSED_TEXTURE_FORMATS", "I", AccessFlags = 25)]
				public const int GL_COMPRESSED_TEXTURE_FORMATS = 34467;
				/// <java-name>
				/// GL_DONT_CARE
				/// </java-name>
				[Dot42.DexImport("GL_DONT_CARE", "I", AccessFlags = 25)]
				public const int GL_DONT_CARE = 4352;
				/// <java-name>
				/// GL_FASTEST
				/// </java-name>
				[Dot42.DexImport("GL_FASTEST", "I", AccessFlags = 25)]
				public const int GL_FASTEST = 4353;
				/// <java-name>
				/// GL_NICEST
				/// </java-name>
				[Dot42.DexImport("GL_NICEST", "I", AccessFlags = 25)]
				public const int GL_NICEST = 4354;
				/// <java-name>
				/// GL_GENERATE_MIPMAP_HINT
				/// </java-name>
				[Dot42.DexImport("GL_GENERATE_MIPMAP_HINT", "I", AccessFlags = 25)]
				public const int GL_GENERATE_MIPMAP_HINT = 33170;
				/// <java-name>
				/// GL_BYTE
				/// </java-name>
				[Dot42.DexImport("GL_BYTE", "I", AccessFlags = 25)]
				public const int GL_BYTE = 5120;
				/// <java-name>
				/// GL_UNSIGNED_BYTE
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_BYTE", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_BYTE = 5121;
				/// <java-name>
				/// GL_SHORT
				/// </java-name>
				[Dot42.DexImport("GL_SHORT", "I", AccessFlags = 25)]
				public const int GL_SHORT = 5122;
				/// <java-name>
				/// GL_UNSIGNED_SHORT
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT = 5123;
				/// <java-name>
				/// GL_INT
				/// </java-name>
				[Dot42.DexImport("GL_INT", "I", AccessFlags = 25)]
				public const int GL_INT = 5124;
				/// <java-name>
				/// GL_UNSIGNED_INT
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_INT", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_INT = 5125;
				/// <java-name>
				/// GL_FLOAT
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT", "I", AccessFlags = 25)]
				public const int GL_FLOAT = 5126;
				/// <java-name>
				/// GL_FIXED
				/// </java-name>
				[Dot42.DexImport("GL_FIXED", "I", AccessFlags = 25)]
				public const int GL_FIXED = 5132;
				/// <java-name>
				/// GL_DEPTH_COMPONENT
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT = 6402;
				/// <java-name>
				/// GL_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_ALPHA", "I", AccessFlags = 25)]
				public const int GL_ALPHA = 6406;
				/// <java-name>
				/// GL_RGB
				/// </java-name>
				[Dot42.DexImport("GL_RGB", "I", AccessFlags = 25)]
				public const int GL_RGB = 6407;
				/// <java-name>
				/// GL_RGBA
				/// </java-name>
				[Dot42.DexImport("GL_RGBA", "I", AccessFlags = 25)]
				public const int GL_RGBA = 6408;
				/// <java-name>
				/// GL_LUMINANCE
				/// </java-name>
				[Dot42.DexImport("GL_LUMINANCE", "I", AccessFlags = 25)]
				public const int GL_LUMINANCE = 6409;
				/// <java-name>
				/// GL_LUMINANCE_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_LUMINANCE_ALPHA", "I", AccessFlags = 25)]
				public const int GL_LUMINANCE_ALPHA = 6410;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_4_4_4_4
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_4_4_4_4", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_4_4_4_4 = 32819;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_5_5_5_1
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_5_5_5_1", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_5_5_5_1 = 32820;
				/// <java-name>
				/// GL_UNSIGNED_SHORT_5_6_5
				/// </java-name>
				[Dot42.DexImport("GL_UNSIGNED_SHORT_5_6_5", "I", AccessFlags = 25)]
				public const int GL_UNSIGNED_SHORT_5_6_5 = 33635;
				/// <java-name>
				/// GL_FRAGMENT_SHADER
				/// </java-name>
				[Dot42.DexImport("GL_FRAGMENT_SHADER", "I", AccessFlags = 25)]
				public const int GL_FRAGMENT_SHADER = 35632;
				/// <java-name>
				/// GL_VERTEX_SHADER
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_SHADER", "I", AccessFlags = 25)]
				public const int GL_VERTEX_SHADER = 35633;
				/// <java-name>
				/// GL_MAX_VERTEX_ATTRIBS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VERTEX_ATTRIBS", "I", AccessFlags = 25)]
				public const int GL_MAX_VERTEX_ATTRIBS = 34921;
				/// <java-name>
				/// GL_MAX_VERTEX_UNIFORM_VECTORS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VERTEX_UNIFORM_VECTORS", "I", AccessFlags = 25)]
				public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 36347;
				/// <java-name>
				/// GL_MAX_VARYING_VECTORS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VARYING_VECTORS", "I", AccessFlags = 25)]
				public const int GL_MAX_VARYING_VECTORS = 36348;
				/// <java-name>
				/// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS", "I", AccessFlags = 25)]
				public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;
				/// <java-name>
				/// GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS", "I", AccessFlags = 25)]
				public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;
				/// <java-name>
				/// GL_MAX_TEXTURE_IMAGE_UNITS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_TEXTURE_IMAGE_UNITS", "I", AccessFlags = 25)]
				public const int GL_MAX_TEXTURE_IMAGE_UNITS = 34930;
				/// <java-name>
				/// GL_MAX_FRAGMENT_UNIFORM_VECTORS
				/// </java-name>
				[Dot42.DexImport("GL_MAX_FRAGMENT_UNIFORM_VECTORS", "I", AccessFlags = 25)]
				public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 36349;
				/// <java-name>
				/// GL_SHADER_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_SHADER_TYPE", "I", AccessFlags = 25)]
				public const int GL_SHADER_TYPE = 35663;
				/// <java-name>
				/// GL_DELETE_STATUS
				/// </java-name>
				[Dot42.DexImport("GL_DELETE_STATUS", "I", AccessFlags = 25)]
				public const int GL_DELETE_STATUS = 35712;
				/// <java-name>
				/// GL_LINK_STATUS
				/// </java-name>
				[Dot42.DexImport("GL_LINK_STATUS", "I", AccessFlags = 25)]
				public const int GL_LINK_STATUS = 35714;
				/// <java-name>
				/// GL_VALIDATE_STATUS
				/// </java-name>
				[Dot42.DexImport("GL_VALIDATE_STATUS", "I", AccessFlags = 25)]
				public const int GL_VALIDATE_STATUS = 35715;
				/// <java-name>
				/// GL_ATTACHED_SHADERS
				/// </java-name>
				[Dot42.DexImport("GL_ATTACHED_SHADERS", "I", AccessFlags = 25)]
				public const int GL_ATTACHED_SHADERS = 35717;
				/// <java-name>
				/// GL_ACTIVE_UNIFORMS
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_UNIFORMS", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_UNIFORMS = 35718;
				/// <java-name>
				/// GL_ACTIVE_UNIFORM_MAX_LENGTH
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_UNIFORM_MAX_LENGTH", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 35719;
				/// <java-name>
				/// GL_ACTIVE_ATTRIBUTES
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_ATTRIBUTES", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_ATTRIBUTES = 35721;
				/// <java-name>
				/// GL_ACTIVE_ATTRIBUTE_MAX_LENGTH
				/// </java-name>
				[Dot42.DexImport("GL_ACTIVE_ATTRIBUTE_MAX_LENGTH", "I", AccessFlags = 25)]
				public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 35722;
				/// <java-name>
				/// GL_SHADING_LANGUAGE_VERSION
				/// </java-name>
				[Dot42.DexImport("GL_SHADING_LANGUAGE_VERSION", "I", AccessFlags = 25)]
				public const int GL_SHADING_LANGUAGE_VERSION = 35724;
				/// <java-name>
				/// GL_CURRENT_PROGRAM
				/// </java-name>
				[Dot42.DexImport("GL_CURRENT_PROGRAM", "I", AccessFlags = 25)]
				public const int GL_CURRENT_PROGRAM = 35725;
				/// <java-name>
				/// GL_NEVER
				/// </java-name>
				[Dot42.DexImport("GL_NEVER", "I", AccessFlags = 25)]
				public const int GL_NEVER = 512;
				/// <java-name>
				/// GL_LESS
				/// </java-name>
				[Dot42.DexImport("GL_LESS", "I", AccessFlags = 25)]
				public const int GL_LESS = 513;
				/// <java-name>
				/// GL_EQUAL
				/// </java-name>
				[Dot42.DexImport("GL_EQUAL", "I", AccessFlags = 25)]
				public const int GL_EQUAL = 514;
				/// <java-name>
				/// GL_LEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_LEQUAL", "I", AccessFlags = 25)]
				public const int GL_LEQUAL = 515;
				/// <java-name>
				/// GL_GREATER
				/// </java-name>
				[Dot42.DexImport("GL_GREATER", "I", AccessFlags = 25)]
				public const int GL_GREATER = 516;
				/// <java-name>
				/// GL_NOTEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_NOTEQUAL", "I", AccessFlags = 25)]
				public const int GL_NOTEQUAL = 517;
				/// <java-name>
				/// GL_GEQUAL
				/// </java-name>
				[Dot42.DexImport("GL_GEQUAL", "I", AccessFlags = 25)]
				public const int GL_GEQUAL = 518;
				/// <java-name>
				/// GL_ALWAYS
				/// </java-name>
				[Dot42.DexImport("GL_ALWAYS", "I", AccessFlags = 25)]
				public const int GL_ALWAYS = 519;
				/// <java-name>
				/// GL_KEEP
				/// </java-name>
				[Dot42.DexImport("GL_KEEP", "I", AccessFlags = 25)]
				public const int GL_KEEP = 7680;
				/// <java-name>
				/// GL_REPLACE
				/// </java-name>
				[Dot42.DexImport("GL_REPLACE", "I", AccessFlags = 25)]
				public const int GL_REPLACE = 7681;
				/// <java-name>
				/// GL_INCR
				/// </java-name>
				[Dot42.DexImport("GL_INCR", "I", AccessFlags = 25)]
				public const int GL_INCR = 7682;
				/// <java-name>
				/// GL_DECR
				/// </java-name>
				[Dot42.DexImport("GL_DECR", "I", AccessFlags = 25)]
				public const int GL_DECR = 7683;
				/// <java-name>
				/// GL_INVERT
				/// </java-name>
				[Dot42.DexImport("GL_INVERT", "I", AccessFlags = 25)]
				public const int GL_INVERT = 5386;
				/// <java-name>
				/// GL_INCR_WRAP
				/// </java-name>
				[Dot42.DexImport("GL_INCR_WRAP", "I", AccessFlags = 25)]
				public const int GL_INCR_WRAP = 34055;
				/// <java-name>
				/// GL_DECR_WRAP
				/// </java-name>
				[Dot42.DexImport("GL_DECR_WRAP", "I", AccessFlags = 25)]
				public const int GL_DECR_WRAP = 34056;
				/// <java-name>
				/// GL_VENDOR
				/// </java-name>
				[Dot42.DexImport("GL_VENDOR", "I", AccessFlags = 25)]
				public const int GL_VENDOR = 7936;
				/// <java-name>
				/// GL_RENDERER
				/// </java-name>
				[Dot42.DexImport("GL_RENDERER", "I", AccessFlags = 25)]
				public const int GL_RENDERER = 7937;
				/// <java-name>
				/// GL_VERSION
				/// </java-name>
				[Dot42.DexImport("GL_VERSION", "I", AccessFlags = 25)]
				public const int GL_VERSION = 7938;
				/// <java-name>
				/// GL_EXTENSIONS
				/// </java-name>
				[Dot42.DexImport("GL_EXTENSIONS", "I", AccessFlags = 25)]
				public const int GL_EXTENSIONS = 7939;
				/// <java-name>
				/// GL_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST", "I", AccessFlags = 25)]
				public const int GL_NEAREST = 9728;
				/// <java-name>
				/// GL_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR", "I", AccessFlags = 25)]
				public const int GL_LINEAR = 9729;
				/// <java-name>
				/// GL_NEAREST_MIPMAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST_MIPMAP_NEAREST", "I", AccessFlags = 25)]
				public const int GL_NEAREST_MIPMAP_NEAREST = 9984;
				/// <java-name>
				/// GL_LINEAR_MIPMAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR_MIPMAP_NEAREST", "I", AccessFlags = 25)]
				public const int GL_LINEAR_MIPMAP_NEAREST = 9985;
				/// <java-name>
				/// GL_NEAREST_MIPMAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_NEAREST_MIPMAP_LINEAR", "I", AccessFlags = 25)]
				public const int GL_NEAREST_MIPMAP_LINEAR = 9986;
				/// <java-name>
				/// GL_LINEAR_MIPMAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("GL_LINEAR_MIPMAP_LINEAR", "I", AccessFlags = 25)]
				public const int GL_LINEAR_MIPMAP_LINEAR = 9987;
				/// <java-name>
				/// GL_TEXTURE_MAG_FILTER
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MAG_FILTER", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MAG_FILTER = 10240;
				/// <java-name>
				/// GL_TEXTURE_MIN_FILTER
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_MIN_FILTER", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_MIN_FILTER = 10241;
				/// <java-name>
				/// GL_TEXTURE_WRAP_S
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_WRAP_S", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_WRAP_S = 10242;
				/// <java-name>
				/// GL_TEXTURE_WRAP_T
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_WRAP_T", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_WRAP_T = 10243;
				/// <java-name>
				/// GL_TEXTURE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE = 5890;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP = 34067;
				/// <java-name>
				/// GL_TEXTURE_BINDING_CUBE_MAP
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_CUBE_MAP", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_CUBE_MAP = 34068;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_X
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_X", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 34069;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_X", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Y", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Z
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Z", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;
				/// <java-name>
				/// GL_MAX_CUBE_MAP_TEXTURE_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_MAX_CUBE_MAP_TEXTURE_SIZE", "I", AccessFlags = 25)]
				public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 34076;
				/// <java-name>
				/// GL_TEXTURE0
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE0", "I", AccessFlags = 25)]
				public const int GL_TEXTURE0 = 33984;
				/// <java-name>
				/// GL_TEXTURE1
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE1", "I", AccessFlags = 25)]
				public const int GL_TEXTURE1 = 33985;
				/// <java-name>
				/// GL_TEXTURE2
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE2", "I", AccessFlags = 25)]
				public const int GL_TEXTURE2 = 33986;
				/// <java-name>
				/// GL_TEXTURE3
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE3", "I", AccessFlags = 25)]
				public const int GL_TEXTURE3 = 33987;
				/// <java-name>
				/// GL_TEXTURE4
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE4", "I", AccessFlags = 25)]
				public const int GL_TEXTURE4 = 33988;
				/// <java-name>
				/// GL_TEXTURE5
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE5", "I", AccessFlags = 25)]
				public const int GL_TEXTURE5 = 33989;
				/// <java-name>
				/// GL_TEXTURE6
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE6", "I", AccessFlags = 25)]
				public const int GL_TEXTURE6 = 33990;
				/// <java-name>
				/// GL_TEXTURE7
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE7", "I", AccessFlags = 25)]
				public const int GL_TEXTURE7 = 33991;
				/// <java-name>
				/// GL_TEXTURE8
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE8", "I", AccessFlags = 25)]
				public const int GL_TEXTURE8 = 33992;
				/// <java-name>
				/// GL_TEXTURE9
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE9", "I", AccessFlags = 25)]
				public const int GL_TEXTURE9 = 33993;
				/// <java-name>
				/// GL_TEXTURE10
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE10", "I", AccessFlags = 25)]
				public const int GL_TEXTURE10 = 33994;
				/// <java-name>
				/// GL_TEXTURE11
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE11", "I", AccessFlags = 25)]
				public const int GL_TEXTURE11 = 33995;
				/// <java-name>
				/// GL_TEXTURE12
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE12", "I", AccessFlags = 25)]
				public const int GL_TEXTURE12 = 33996;
				/// <java-name>
				/// GL_TEXTURE13
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE13", "I", AccessFlags = 25)]
				public const int GL_TEXTURE13 = 33997;
				/// <java-name>
				/// GL_TEXTURE14
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE14", "I", AccessFlags = 25)]
				public const int GL_TEXTURE14 = 33998;
				/// <java-name>
				/// GL_TEXTURE15
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE15", "I", AccessFlags = 25)]
				public const int GL_TEXTURE15 = 33999;
				/// <java-name>
				/// GL_TEXTURE16
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE16", "I", AccessFlags = 25)]
				public const int GL_TEXTURE16 = 34000;
				/// <java-name>
				/// GL_TEXTURE17
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE17", "I", AccessFlags = 25)]
				public const int GL_TEXTURE17 = 34001;
				/// <java-name>
				/// GL_TEXTURE18
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE18", "I", AccessFlags = 25)]
				public const int GL_TEXTURE18 = 34002;
				/// <java-name>
				/// GL_TEXTURE19
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE19", "I", AccessFlags = 25)]
				public const int GL_TEXTURE19 = 34003;
				/// <java-name>
				/// GL_TEXTURE20
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE20", "I", AccessFlags = 25)]
				public const int GL_TEXTURE20 = 34004;
				/// <java-name>
				/// GL_TEXTURE21
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE21", "I", AccessFlags = 25)]
				public const int GL_TEXTURE21 = 34005;
				/// <java-name>
				/// GL_TEXTURE22
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE22", "I", AccessFlags = 25)]
				public const int GL_TEXTURE22 = 34006;
				/// <java-name>
				/// GL_TEXTURE23
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE23", "I", AccessFlags = 25)]
				public const int GL_TEXTURE23 = 34007;
				/// <java-name>
				/// GL_TEXTURE24
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE24", "I", AccessFlags = 25)]
				public const int GL_TEXTURE24 = 34008;
				/// <java-name>
				/// GL_TEXTURE25
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE25", "I", AccessFlags = 25)]
				public const int GL_TEXTURE25 = 34009;
				/// <java-name>
				/// GL_TEXTURE26
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE26", "I", AccessFlags = 25)]
				public const int GL_TEXTURE26 = 34010;
				/// <java-name>
				/// GL_TEXTURE27
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE27", "I", AccessFlags = 25)]
				public const int GL_TEXTURE27 = 34011;
				/// <java-name>
				/// GL_TEXTURE28
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE28", "I", AccessFlags = 25)]
				public const int GL_TEXTURE28 = 34012;
				/// <java-name>
				/// GL_TEXTURE29
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE29", "I", AccessFlags = 25)]
				public const int GL_TEXTURE29 = 34013;
				/// <java-name>
				/// GL_TEXTURE30
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE30", "I", AccessFlags = 25)]
				public const int GL_TEXTURE30 = 34014;
				/// <java-name>
				/// GL_TEXTURE31
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE31", "I", AccessFlags = 25)]
				public const int GL_TEXTURE31 = 34015;
				/// <java-name>
				/// GL_REPEAT
				/// </java-name>
				[Dot42.DexImport("GL_REPEAT", "I", AccessFlags = 25)]
				public const int GL_REPEAT = 10497;
				/// <java-name>
				/// GL_CLAMP_TO_EDGE
				/// </java-name>
				[Dot42.DexImport("GL_CLAMP_TO_EDGE", "I", AccessFlags = 25)]
				public const int GL_CLAMP_TO_EDGE = 33071;
				/// <java-name>
				/// GL_MIRRORED_REPEAT
				/// </java-name>
				[Dot42.DexImport("GL_MIRRORED_REPEAT", "I", AccessFlags = 25)]
				public const int GL_MIRRORED_REPEAT = 33648;
				/// <java-name>
				/// GL_FLOAT_VEC2
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_VEC2", "I", AccessFlags = 25)]
				public const int GL_FLOAT_VEC2 = 35664;
				/// <java-name>
				/// GL_FLOAT_VEC3
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_VEC3", "I", AccessFlags = 25)]
				public const int GL_FLOAT_VEC3 = 35665;
				/// <java-name>
				/// GL_FLOAT_VEC4
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_VEC4", "I", AccessFlags = 25)]
				public const int GL_FLOAT_VEC4 = 35666;
				/// <java-name>
				/// GL_INT_VEC2
				/// </java-name>
				[Dot42.DexImport("GL_INT_VEC2", "I", AccessFlags = 25)]
				public const int GL_INT_VEC2 = 35667;
				/// <java-name>
				/// GL_INT_VEC3
				/// </java-name>
				[Dot42.DexImport("GL_INT_VEC3", "I", AccessFlags = 25)]
				public const int GL_INT_VEC3 = 35668;
				/// <java-name>
				/// GL_INT_VEC4
				/// </java-name>
				[Dot42.DexImport("GL_INT_VEC4", "I", AccessFlags = 25)]
				public const int GL_INT_VEC4 = 35669;
				/// <java-name>
				/// GL_BOOL
				/// </java-name>
				[Dot42.DexImport("GL_BOOL", "I", AccessFlags = 25)]
				public const int GL_BOOL = 35670;
				/// <java-name>
				/// GL_BOOL_VEC2
				/// </java-name>
				[Dot42.DexImport("GL_BOOL_VEC2", "I", AccessFlags = 25)]
				public const int GL_BOOL_VEC2 = 35671;
				/// <java-name>
				/// GL_BOOL_VEC3
				/// </java-name>
				[Dot42.DexImport("GL_BOOL_VEC3", "I", AccessFlags = 25)]
				public const int GL_BOOL_VEC3 = 35672;
				/// <java-name>
				/// GL_BOOL_VEC4
				/// </java-name>
				[Dot42.DexImport("GL_BOOL_VEC4", "I", AccessFlags = 25)]
				public const int GL_BOOL_VEC4 = 35673;
				/// <java-name>
				/// GL_FLOAT_MAT2
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_MAT2", "I", AccessFlags = 25)]
				public const int GL_FLOAT_MAT2 = 35674;
				/// <java-name>
				/// GL_FLOAT_MAT3
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_MAT3", "I", AccessFlags = 25)]
				public const int GL_FLOAT_MAT3 = 35675;
				/// <java-name>
				/// GL_FLOAT_MAT4
				/// </java-name>
				[Dot42.DexImport("GL_FLOAT_MAT4", "I", AccessFlags = 25)]
				public const int GL_FLOAT_MAT4 = 35676;
				/// <java-name>
				/// GL_SAMPLER_2D
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLER_2D", "I", AccessFlags = 25)]
				public const int GL_SAMPLER_2D = 35678;
				/// <java-name>
				/// GL_SAMPLER_CUBE
				/// </java-name>
				[Dot42.DexImport("GL_SAMPLER_CUBE", "I", AccessFlags = 25)]
				public const int GL_SAMPLER_CUBE = 35680;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_ENABLED
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_ENABLED", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 34338;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_SIZE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 34339;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_STRIDE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_STRIDE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 34340;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_TYPE", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 34341;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_POINTER
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_POINTER", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 34373;
				/// <java-name>
				/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;
				/// <java-name>
				/// GL_IMPLEMENTATION_COLOR_READ_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_IMPLEMENTATION_COLOR_READ_TYPE", "I", AccessFlags = 25)]
				public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 35738;
				/// <java-name>
				/// GL_IMPLEMENTATION_COLOR_READ_FORMAT
				/// </java-name>
				[Dot42.DexImport("GL_IMPLEMENTATION_COLOR_READ_FORMAT", "I", AccessFlags = 25)]
				public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 35739;
				/// <java-name>
				/// GL_COMPILE_STATUS
				/// </java-name>
				[Dot42.DexImport("GL_COMPILE_STATUS", "I", AccessFlags = 25)]
				public const int GL_COMPILE_STATUS = 35713;
				/// <java-name>
				/// GL_INFO_LOG_LENGTH
				/// </java-name>
				[Dot42.DexImport("GL_INFO_LOG_LENGTH", "I", AccessFlags = 25)]
				public const int GL_INFO_LOG_LENGTH = 35716;
				/// <java-name>
				/// GL_SHADER_SOURCE_LENGTH
				/// </java-name>
				[Dot42.DexImport("GL_SHADER_SOURCE_LENGTH", "I", AccessFlags = 25)]
				public const int GL_SHADER_SOURCE_LENGTH = 35720;
				/// <java-name>
				/// GL_SHADER_COMPILER
				/// </java-name>
				[Dot42.DexImport("GL_SHADER_COMPILER", "I", AccessFlags = 25)]
				public const int GL_SHADER_COMPILER = 36346;
				/// <java-name>
				/// GL_SHADER_BINARY_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_SHADER_BINARY_FORMATS", "I", AccessFlags = 25)]
				public const int GL_SHADER_BINARY_FORMATS = 36344;
				/// <java-name>
				/// GL_NUM_SHADER_BINARY_FORMATS
				/// </java-name>
				[Dot42.DexImport("GL_NUM_SHADER_BINARY_FORMATS", "I", AccessFlags = 25)]
				public const int GL_NUM_SHADER_BINARY_FORMATS = 36345;
				/// <java-name>
				/// GL_LOW_FLOAT
				/// </java-name>
				[Dot42.DexImport("GL_LOW_FLOAT", "I", AccessFlags = 25)]
				public const int GL_LOW_FLOAT = 36336;
				/// <java-name>
				/// GL_MEDIUM_FLOAT
				/// </java-name>
				[Dot42.DexImport("GL_MEDIUM_FLOAT", "I", AccessFlags = 25)]
				public const int GL_MEDIUM_FLOAT = 36337;
				/// <java-name>
				/// GL_HIGH_FLOAT
				/// </java-name>
				[Dot42.DexImport("GL_HIGH_FLOAT", "I", AccessFlags = 25)]
				public const int GL_HIGH_FLOAT = 36338;
				/// <java-name>
				/// GL_LOW_INT
				/// </java-name>
				[Dot42.DexImport("GL_LOW_INT", "I", AccessFlags = 25)]
				public const int GL_LOW_INT = 36339;
				/// <java-name>
				/// GL_MEDIUM_INT
				/// </java-name>
				[Dot42.DexImport("GL_MEDIUM_INT", "I", AccessFlags = 25)]
				public const int GL_MEDIUM_INT = 36340;
				/// <java-name>
				/// GL_HIGH_INT
				/// </java-name>
				[Dot42.DexImport("GL_HIGH_INT", "I", AccessFlags = 25)]
				public const int GL_HIGH_INT = 36341;
				/// <java-name>
				/// GL_FRAMEBUFFER
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER = 36160;
				/// <java-name>
				/// GL_RENDERBUFFER
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER = 36161;
				/// <java-name>
				/// GL_RGBA4
				/// </java-name>
				[Dot42.DexImport("GL_RGBA4", "I", AccessFlags = 25)]
				public const int GL_RGBA4 = 32854;
				/// <java-name>
				/// GL_RGB5_A1
				/// </java-name>
				[Dot42.DexImport("GL_RGB5_A1", "I", AccessFlags = 25)]
				public const int GL_RGB5_A1 = 32855;
				/// <java-name>
				/// GL_RGB565
				/// </java-name>
				[Dot42.DexImport("GL_RGB565", "I", AccessFlags = 25)]
				public const int GL_RGB565 = 36194;
				/// <java-name>
				/// GL_DEPTH_COMPONENT16
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT16", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT16 = 33189;
				/// <java-name>
				/// GL_STENCIL_INDEX
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX = 6401;
				/// <java-name>
				/// GL_STENCIL_INDEX8
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX8", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX8 = 36168;
				/// <java-name>
				/// GL_RENDERBUFFER_WIDTH
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_WIDTH", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_WIDTH = 36162;
				/// <java-name>
				/// GL_RENDERBUFFER_HEIGHT
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_HEIGHT", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_HEIGHT = 36163;
				/// <java-name>
				/// GL_RENDERBUFFER_INTERNAL_FORMAT
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_INTERNAL_FORMAT", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 36164;
				/// <java-name>
				/// GL_RENDERBUFFER_RED_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_RED_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_RED_SIZE = 36176;
				/// <java-name>
				/// GL_RENDERBUFFER_GREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_GREEN_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_GREEN_SIZE = 36177;
				/// <java-name>
				/// GL_RENDERBUFFER_BLUE_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BLUE_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BLUE_SIZE = 36178;
				/// <java-name>
				/// GL_RENDERBUFFER_ALPHA_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_ALPHA_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_ALPHA_SIZE = 36179;
				/// <java-name>
				/// GL_RENDERBUFFER_DEPTH_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_DEPTH_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_DEPTH_SIZE = 36180;
				/// <java-name>
				/// GL_RENDERBUFFER_STENCIL_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_STENCIL_SIZE", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_STENCIL_SIZE = 36181;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 36048;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 36049;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 36050;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 36051;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT0
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT0", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT0 = 36064;
				/// <java-name>
				/// GL_DEPTH_ATTACHMENT
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_ATTACHMENT", "I", AccessFlags = 25)]
				public const int GL_DEPTH_ATTACHMENT = 36096;
				/// <java-name>
				/// GL_STENCIL_ATTACHMENT
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_ATTACHMENT", "I", AccessFlags = 25)]
				public const int GL_STENCIL_ATTACHMENT = 36128;
				/// <java-name>
				/// GL_NONE
				/// </java-name>
				[Dot42.DexImport("GL_NONE", "I", AccessFlags = 25)]
				public const int GL_NONE = 0;
				/// <java-name>
				/// GL_FRAMEBUFFER_COMPLETE
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_COMPLETE", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_COMPLETE = 36053;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 36054;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 36055;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 36057;
				/// <java-name>
				/// GL_FRAMEBUFFER_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_UNSUPPORTED", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_UNSUPPORTED = 36061;
				/// <java-name>
				/// GL_FRAMEBUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_BINDING = 36006;
				/// <java-name>
				/// GL_RENDERBUFFER_BINDING
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BINDING", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BINDING = 36007;
				/// <java-name>
				/// GL_MAX_RENDERBUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_MAX_RENDERBUFFER_SIZE", "I", AccessFlags = 25)]
				public const int GL_MAX_RENDERBUFFER_SIZE = 34024;
				/// <java-name>
				/// GL_INVALID_FRAMEBUFFER_OPERATION
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_FRAMEBUFFER_OPERATION", "I", AccessFlags = 25)]
				public const int GL_INVALID_FRAMEBUFFER_OPERATION = 1286;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLES20() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glActiveTexture
				/// </java-name>
				[Dot42.DexImport("glActiveTexture", "(I)V", AccessFlags = 265)]
				public static void GlActiveTexture(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glAttachShader
				/// </java-name>
				[Dot42.DexImport("glAttachShader", "(II)V", AccessFlags = 265)]
				public static void GlAttachShader(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindAttribLocation
				/// </java-name>
				[Dot42.DexImport("glBindAttribLocation", "(IILjava/lang/String;)V", AccessFlags = 265)]
				public static void GlBindAttribLocation(int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindBuffer
				/// </java-name>
				[Dot42.DexImport("glBindBuffer", "(II)V", AccessFlags = 265)]
				public static void GlBindBuffer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindFramebuffer
				/// </java-name>
				[Dot42.DexImport("glBindFramebuffer", "(II)V", AccessFlags = 265)]
				public static void GlBindFramebuffer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindRenderbuffer
				/// </java-name>
				[Dot42.DexImport("glBindRenderbuffer", "(II)V", AccessFlags = 265)]
				public static void GlBindRenderbuffer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBindTexture
				/// </java-name>
				[Dot42.DexImport("glBindTexture", "(II)V", AccessFlags = 265)]
				public static void GlBindTexture(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendColor
				/// </java-name>
				[Dot42.DexImport("glBlendColor", "(FFFF)V", AccessFlags = 265)]
				public static void GlBlendColor(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendEquation
				/// </java-name>
				[Dot42.DexImport("glBlendEquation", "(I)V", AccessFlags = 265)]
				public static void GlBlendEquation(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendEquationSeparate
				/// </java-name>
				[Dot42.DexImport("glBlendEquationSeparate", "(II)V", AccessFlags = 265)]
				public static void GlBlendEquationSeparate(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendFunc
				/// </java-name>
				[Dot42.DexImport("glBlendFunc", "(II)V", AccessFlags = 265)]
				public static void GlBlendFunc(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBlendFuncSeparate
				/// </java-name>
				[Dot42.DexImport("glBlendFuncSeparate", "(IIII)V", AccessFlags = 265)]
				public static void GlBlendFuncSeparate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBufferData
				/// </java-name>
				[Dot42.DexImport("glBufferData", "(IILjava/nio/Buffer;I)V", AccessFlags = 265)]
				public static void GlBufferData(int int32, int int321, global::Java.Nio.Buffer buffer, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glBufferSubData
				/// </java-name>
				[Dot42.DexImport("glBufferSubData", "(IIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlBufferSubData(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCheckFramebufferStatus
				/// </java-name>
				[Dot42.DexImport("glCheckFramebufferStatus", "(I)I", AccessFlags = 265)]
				public static int GlCheckFramebufferStatus(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glClear
				/// </java-name>
				[Dot42.DexImport("glClear", "(I)V", AccessFlags = 265)]
				public static void GlClear(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearColor
				/// </java-name>
				[Dot42.DexImport("glClearColor", "(FFFF)V", AccessFlags = 265)]
				public static void GlClearColor(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearDepthf
				/// </java-name>
				[Dot42.DexImport("glClearDepthf", "(F)V", AccessFlags = 265)]
				public static void GlClearDepthf(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glClearStencil
				/// </java-name>
				[Dot42.DexImport("glClearStencil", "(I)V", AccessFlags = 265)]
				public static void GlClearStencil(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glColorMask
				/// </java-name>
				[Dot42.DexImport("glColorMask", "(ZZZZ)V", AccessFlags = 265)]
				public static void GlColorMask(bool boolean, bool boolean1, bool boolean2, bool boolean3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCompileShader
				/// </java-name>
				[Dot42.DexImport("glCompileShader", "(I)V", AccessFlags = 265)]
				public static void GlCompileShader(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCompressedTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlCompressedTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCompressedTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlCompressedTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCopyTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexImage2D", "(IIIIIIII)V", AccessFlags = 265)]
				public static void GlCopyTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCopyTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexSubImage2D", "(IIIIIIII)V", AccessFlags = 265)]
				public static void GlCopyTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glCreateProgram
				/// </java-name>
				[Dot42.DexImport("glCreateProgram", "()I", AccessFlags = 265)]
				public static int GlCreateProgram() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glCreateShader
				/// </java-name>
				[Dot42.DexImport("glCreateShader", "(I)I", AccessFlags = 265)]
				public static int GlCreateShader(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glCullFace
				/// </java-name>
				[Dot42.DexImport("glCullFace", "(I)V", AccessFlags = 265)]
				public static void GlCullFace(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteBuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteBuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteFramebuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteFramebuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteFramebuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteFramebuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteProgram
				/// </java-name>
				[Dot42.DexImport("glDeleteProgram", "(I)V", AccessFlags = 265)]
				public static void GlDeleteProgram(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteRenderbuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteRenderbuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteRenderbuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteRenderbuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteShader
				/// </java-name>
				[Dot42.DexImport("glDeleteShader", "(I)V", AccessFlags = 265)]
				public static void GlDeleteShader(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(I[II)V", AccessFlags = 265)]
				public static void GlDeleteTextures(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlDeleteTextures(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthFunc
				/// </java-name>
				[Dot42.DexImport("glDepthFunc", "(I)V", AccessFlags = 265)]
				public static void GlDepthFunc(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthMask
				/// </java-name>
				[Dot42.DexImport("glDepthMask", "(Z)V", AccessFlags = 265)]
				public static void GlDepthMask(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDepthRangef
				/// </java-name>
				[Dot42.DexImport("glDepthRangef", "(FF)V", AccessFlags = 265)]
				public static void GlDepthRangef(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDetachShader
				/// </java-name>
				[Dot42.DexImport("glDetachShader", "(II)V", AccessFlags = 265)]
				public static void GlDetachShader(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDisable
				/// </java-name>
				[Dot42.DexImport("glDisable", "(I)V", AccessFlags = 265)]
				public static void GlDisable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDisableVertexAttribArray
				/// </java-name>
				[Dot42.DexImport("glDisableVertexAttribArray", "(I)V", AccessFlags = 265)]
				public static void GlDisableVertexAttribArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawArrays
				/// </java-name>
				[Dot42.DexImport("glDrawArrays", "(III)V", AccessFlags = 265)]
				public static void GlDrawArrays(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIII)V", AccessFlags = 265)]
				public static void GlDrawElements(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlDrawElements(int int32, int int321, int int322, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEnable
				/// </java-name>
				[Dot42.DexImport("glEnable", "(I)V", AccessFlags = 265)]
				public static void GlEnable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glEnableVertexAttribArray
				/// </java-name>
				[Dot42.DexImport("glEnableVertexAttribArray", "(I)V", AccessFlags = 265)]
				public static void GlEnableVertexAttribArray(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFinish
				/// </java-name>
				[Dot42.DexImport("glFinish", "()V", AccessFlags = 265)]
				public static void GlFinish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFlush
				/// </java-name>
				[Dot42.DexImport("glFlush", "()V", AccessFlags = 265)]
				public static void GlFlush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFramebufferRenderbuffer
				/// </java-name>
				[Dot42.DexImport("glFramebufferRenderbuffer", "(IIII)V", AccessFlags = 265)]
				public static void GlFramebufferRenderbuffer(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFramebufferTexture2D
				/// </java-name>
				[Dot42.DexImport("glFramebufferTexture2D", "(IIIII)V", AccessFlags = 265)]
				public static void GlFramebufferTexture2D(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glFrontFace
				/// </java-name>
				[Dot42.DexImport("glFrontFace", "(I)V", AccessFlags = 265)]
				public static void GlFrontFace(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlGenBuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenBuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenerateMipmap
				/// </java-name>
				[Dot42.DexImport("glGenerateMipmap", "(I)V", AccessFlags = 265)]
				public static void GlGenerateMipmap(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenFramebuffers
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlGenFramebuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenFramebuffers
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenFramebuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenRenderbuffers
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffers", "(I[II)V", AccessFlags = 265)]
				public static void GlGenRenderbuffers(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenRenderbuffers
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenRenderbuffers(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(I[II)V", AccessFlags = 265)]
				public static void GlGenTextures(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGenTextures(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveAttrib
				/// </java-name>
				[Dot42.DexImport("glGetActiveAttrib", "(III[II[II[II[BI)V", AccessFlags = 265)]
				public static void GlGetActiveAttrib(int int32, int int321, int int322, int[] int323, int int324, int[] int325, int int326, int[] int327, int int328, sbyte[] sByte, int int329) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveAttrib
				/// </java-name>
				[Dot42.DexImport("glGetActiveAttrib", "(III[II[II[II[BI)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetActiveAttrib(int int32, int int321, int int322, int[] int323, int int324, int[] int325, int int326, int[] int327, int int328, byte[] @byte, int int329) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveAttrib
				/// </java-name>
				[Dot42.DexImport("glGetActiveAttrib", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V", AccessFlags = 265)]
				public static void GlGetActiveAttrib(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1, global::Java.Nio.IntBuffer intBuffer2, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveAttrib
				/// </java-name>
				[Dot42.DexImport("glGetActiveAttrib", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetActiveAttrib(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1, global::Java.Nio.IntBuffer intBuffer2, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveUniform
				/// </java-name>
				[Dot42.DexImport("glGetActiveUniform", "(III[II[II[II[BI)V", AccessFlags = 265)]
				public static void GlGetActiveUniform(int int32, int int321, int int322, int[] int323, int int324, int[] int325, int int326, int[] int327, int int328, sbyte[] sByte, int int329) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveUniform
				/// </java-name>
				[Dot42.DexImport("glGetActiveUniform", "(III[II[II[II[BI)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetActiveUniform(int int32, int int321, int int322, int[] int323, int int324, int[] int325, int int326, int[] int327, int int328, byte[] @byte, int int329) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveUniform
				/// </java-name>
				[Dot42.DexImport("glGetActiveUniform", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V", AccessFlags = 265)]
				public static void GlGetActiveUniform(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1, global::Java.Nio.IntBuffer intBuffer2, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetActiveUniform
				/// </java-name>
				[Dot42.DexImport("glGetActiveUniform", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetActiveUniform(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1, global::Java.Nio.IntBuffer intBuffer2, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetAttachedShaders
				/// </java-name>
				[Dot42.DexImport("glGetAttachedShaders", "(II[II[II)V", AccessFlags = 265)]
				public static void GlGetAttachedShaders(int int32, int int321, int[] int322, int int323, int[] int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetAttachedShaders
				/// </java-name>
				[Dot42.DexImport("glGetAttachedShaders", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetAttachedShaders(int int32, int int321, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetAttribLocation
				/// </java-name>
				[Dot42.DexImport("glGetAttribLocation", "(ILjava/lang/String;)I", AccessFlags = 265)]
				public static int GlGetAttribLocation(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(I[ZI)V", AccessFlags = 265)]
				public static void GlGetBooleanv(int int32, bool[] boolean, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetBooleanv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetBufferParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetBufferParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetError
				/// </java-name>
				[Dot42.DexImport("glGetError", "()I", AccessFlags = 265)]
				public static int GlGetError() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(I[FI)V", AccessFlags = 265)]
				public static void GlGetFloatv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetFloatv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFramebufferAttachmentParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameteriv", "(III[II)V", AccessFlags = 265)]
				public static void GlGetFramebufferAttachmentParameteriv(int int32, int int321, int int322, int[] int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetFramebufferAttachmentParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameteriv", "(IIILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetFramebufferAttachmentParameteriv(int int32, int int321, int int322, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(I[II)V", AccessFlags = 265)]
				public static void GlGetIntegerv(int int32, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetIntegerv(int int32, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetProgramiv
				/// </java-name>
				[Dot42.DexImport("glGetProgramiv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetProgramiv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetProgramiv
				/// </java-name>
				[Dot42.DexImport("glGetProgramiv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetProgramiv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetProgramInfoLog
				/// </java-name>
				[Dot42.DexImport("glGetProgramInfoLog", "(I)Ljava/lang/String;", AccessFlags = 265)]
				public static string GlGetProgramInfoLog(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// glGetRenderbufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetRenderbufferParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetRenderbufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetRenderbufferParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderiv
				/// </java-name>
				[Dot42.DexImport("glGetShaderiv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetShaderiv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderiv
				/// </java-name>
				[Dot42.DexImport("glGetShaderiv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetShaderiv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderInfoLog
				/// </java-name>
				[Dot42.DexImport("glGetShaderInfoLog", "(I)Ljava/lang/String;", AccessFlags = 265)]
				public static string GlGetShaderInfoLog(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// glGetShaderPrecisionFormat
				/// </java-name>
				[Dot42.DexImport("glGetShaderPrecisionFormat", "(II[II[II)V", AccessFlags = 265)]
				public static void GlGetShaderPrecisionFormat(int int32, int int321, int[] int322, int int323, int[] int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderPrecisionFormat
				/// </java-name>
				[Dot42.DexImport("glGetShaderPrecisionFormat", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetShaderPrecisionFormat(int int32, int int321, global::Java.Nio.IntBuffer intBuffer, global::Java.Nio.IntBuffer intBuffer1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderSource
				/// </java-name>
				[Dot42.DexImport("glGetShaderSource", "(II[II[BI)V", AccessFlags = 265)]
				public static void GlGetShaderSource(int int32, int int321, int[] int322, int int323, sbyte[] sByte, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderSource
				/// </java-name>
				[Dot42.DexImport("glGetShaderSource", "(II[II[BI)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetShaderSource(int int32, int int321, int[] int322, int int323, byte[] @byte, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderSource
				/// </java-name>
				[Dot42.DexImport("glGetShaderSource", "(IILjava/nio/IntBuffer;B)V", AccessFlags = 265)]
				public static void GlGetShaderSource(int int32, int int321, global::Java.Nio.IntBuffer intBuffer, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetShaderSource
				/// </java-name>
				[Dot42.DexImport("glGetShaderSource", "(IILjava/nio/IntBuffer;B)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GlGetShaderSource(int int32, int int321, global::Java.Nio.IntBuffer intBuffer, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetString
				/// </java-name>
				[Dot42.DexImport("glGetString", "(I)Ljava/lang/String;", AccessFlags = 265)]
				public static string GlGetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetTexParameterfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameterfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetTexParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetTexParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetUniformfv
				/// </java-name>
				[Dot42.DexImport("glGetUniformfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetUniformfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetUniformfv
				/// </java-name>
				[Dot42.DexImport("glGetUniformfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetUniformfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetUniformiv
				/// </java-name>
				[Dot42.DexImport("glGetUniformiv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetUniformiv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetUniformiv
				/// </java-name>
				[Dot42.DexImport("glGetUniformiv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetUniformiv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetUniformLocation
				/// </java-name>
				[Dot42.DexImport("glGetUniformLocation", "(ILjava/lang/String;)I", AccessFlags = 265)]
				public static int GlGetUniformLocation(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// glGetVertexAttribfv
				/// </java-name>
				[Dot42.DexImport("glGetVertexAttribfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlGetVertexAttribfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetVertexAttribfv
				/// </java-name>
				[Dot42.DexImport("glGetVertexAttribfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlGetVertexAttribfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetVertexAttribiv
				/// </java-name>
				[Dot42.DexImport("glGetVertexAttribiv", "(II[II)V", AccessFlags = 265)]
				public static void GlGetVertexAttribiv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glGetVertexAttribiv
				/// </java-name>
				[Dot42.DexImport("glGetVertexAttribiv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlGetVertexAttribiv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glHint
				/// </java-name>
				[Dot42.DexImport("glHint", "(II)V", AccessFlags = 265)]
				public static void GlHint(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glIsBuffer
				/// </java-name>
				[Dot42.DexImport("glIsBuffer", "(I)Z", AccessFlags = 265)]
				public static bool GlIsBuffer(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsEnabled
				/// </java-name>
				[Dot42.DexImport("glIsEnabled", "(I)Z", AccessFlags = 265)]
				public static bool GlIsEnabled(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsFramebuffer
				/// </java-name>
				[Dot42.DexImport("glIsFramebuffer", "(I)Z", AccessFlags = 265)]
				public static bool GlIsFramebuffer(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsProgram
				/// </java-name>
				[Dot42.DexImport("glIsProgram", "(I)Z", AccessFlags = 265)]
				public static bool GlIsProgram(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsRenderbuffer
				/// </java-name>
				[Dot42.DexImport("glIsRenderbuffer", "(I)Z", AccessFlags = 265)]
				public static bool GlIsRenderbuffer(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsShader
				/// </java-name>
				[Dot42.DexImport("glIsShader", "(I)Z", AccessFlags = 265)]
				public static bool GlIsShader(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glIsTexture
				/// </java-name>
				[Dot42.DexImport("glIsTexture", "(I)Z", AccessFlags = 265)]
				public static bool GlIsTexture(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// glLineWidth
				/// </java-name>
				[Dot42.DexImport("glLineWidth", "(F)V", AccessFlags = 265)]
				public static void GlLineWidth(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glLinkProgram
				/// </java-name>
				[Dot42.DexImport("glLinkProgram", "(I)V", AccessFlags = 265)]
				public static void GlLinkProgram(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPixelStorei
				/// </java-name>
				[Dot42.DexImport("glPixelStorei", "(II)V", AccessFlags = 265)]
				public static void GlPixelStorei(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glPolygonOffset
				/// </java-name>
				[Dot42.DexImport("glPolygonOffset", "(FF)V", AccessFlags = 265)]
				public static void GlPolygonOffset(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glReadPixels
				/// </java-name>
				[Dot42.DexImport("glReadPixels", "(IIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlReadPixels(int int32, int int321, int int322, int int323, int int324, int int325, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glReleaseShaderCompiler
				/// </java-name>
				[Dot42.DexImport("glReleaseShaderCompiler", "()V", AccessFlags = 265)]
				public static void GlReleaseShaderCompiler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glRenderbufferStorage
				/// </java-name>
				[Dot42.DexImport("glRenderbufferStorage", "(IIII)V", AccessFlags = 265)]
				public static void GlRenderbufferStorage(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glSampleCoverage
				/// </java-name>
				[Dot42.DexImport("glSampleCoverage", "(FZ)V", AccessFlags = 265)]
				public static void GlSampleCoverage(float single, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glScissor
				/// </java-name>
				[Dot42.DexImport("glScissor", "(IIII)V", AccessFlags = 265)]
				public static void GlScissor(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glShaderBinary
				/// </java-name>
				[Dot42.DexImport("glShaderBinary", "(I[IIILjava/nio/Buffer;I)V", AccessFlags = 265)]
				public static void GlShaderBinary(int int32, int[] int321, int int322, int int323, global::Java.Nio.Buffer buffer, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glShaderBinary
				/// </java-name>
				[Dot42.DexImport("glShaderBinary", "(ILjava/nio/IntBuffer;ILjava/nio/Buffer;I)V", AccessFlags = 265)]
				public static void GlShaderBinary(int int32, global::Java.Nio.IntBuffer intBuffer, int int321, global::Java.Nio.Buffer buffer, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glShaderSource
				/// </java-name>
				[Dot42.DexImport("glShaderSource", "(ILjava/lang/String;)V", AccessFlags = 265)]
				public static void GlShaderSource(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilFunc
				/// </java-name>
				[Dot42.DexImport("glStencilFunc", "(III)V", AccessFlags = 265)]
				public static void GlStencilFunc(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilFuncSeparate
				/// </java-name>
				[Dot42.DexImport("glStencilFuncSeparate", "(IIII)V", AccessFlags = 265)]
				public static void GlStencilFuncSeparate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilMask
				/// </java-name>
				[Dot42.DexImport("glStencilMask", "(I)V", AccessFlags = 265)]
				public static void GlStencilMask(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilMaskSeparate
				/// </java-name>
				[Dot42.DexImport("glStencilMaskSeparate", "(II)V", AccessFlags = 265)]
				public static void GlStencilMaskSeparate(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilOp
				/// </java-name>
				[Dot42.DexImport("glStencilOp", "(III)V", AccessFlags = 265)]
				public static void GlStencilOp(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glStencilOpSeparate
				/// </java-name>
				[Dot42.DexImport("glStencilOpSeparate", "(IIII)V", AccessFlags = 265)]
				public static void GlStencilOpSeparate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexImage2D
				/// </java-name>
				[Dot42.DexImport("glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlTexImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterf
				/// </java-name>
				[Dot42.DexImport("glTexParameterf", "(IIF)V", AccessFlags = 265)]
				public static void GlTexParameterf(int int32, int int321, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(II[FI)V", AccessFlags = 265)]
				public static void GlTexParameterfv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameterfv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteri
				/// </java-name>
				[Dot42.DexImport("glTexParameteri", "(III)V", AccessFlags = 265)]
				public static void GlTexParameteri(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(II[II)V", AccessFlags = 265)]
				public static void GlTexParameteriv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlTexParameteriv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 265)]
				public static void GlTexSubImage2D(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1f
				/// </java-name>
				[Dot42.DexImport("glUniform1f", "(IF)V", AccessFlags = 265)]
				public static void GlUniform1f(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1fv
				/// </java-name>
				[Dot42.DexImport("glUniform1fv", "(II[FI)V", AccessFlags = 265)]
				public static void GlUniform1fv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1fv
				/// </java-name>
				[Dot42.DexImport("glUniform1fv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniform1fv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1i
				/// </java-name>
				[Dot42.DexImport("glUniform1i", "(II)V", AccessFlags = 265)]
				public static void GlUniform1i(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1iv
				/// </java-name>
				[Dot42.DexImport("glUniform1iv", "(II[II)V", AccessFlags = 265)]
				public static void GlUniform1iv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform1iv
				/// </java-name>
				[Dot42.DexImport("glUniform1iv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlUniform1iv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2f
				/// </java-name>
				[Dot42.DexImport("glUniform2f", "(IFF)V", AccessFlags = 265)]
				public static void GlUniform2f(int int32, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2fv
				/// </java-name>
				[Dot42.DexImport("glUniform2fv", "(II[FI)V", AccessFlags = 265)]
				public static void GlUniform2fv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2fv
				/// </java-name>
				[Dot42.DexImport("glUniform2fv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniform2fv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2i
				/// </java-name>
				[Dot42.DexImport("glUniform2i", "(III)V", AccessFlags = 265)]
				public static void GlUniform2i(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2iv
				/// </java-name>
				[Dot42.DexImport("glUniform2iv", "(II[II)V", AccessFlags = 265)]
				public static void GlUniform2iv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform2iv
				/// </java-name>
				[Dot42.DexImport("glUniform2iv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlUniform2iv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3f
				/// </java-name>
				[Dot42.DexImport("glUniform3f", "(IFFF)V", AccessFlags = 265)]
				public static void GlUniform3f(int int32, float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3fv
				/// </java-name>
				[Dot42.DexImport("glUniform3fv", "(II[FI)V", AccessFlags = 265)]
				public static void GlUniform3fv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3fv
				/// </java-name>
				[Dot42.DexImport("glUniform3fv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniform3fv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3i
				/// </java-name>
				[Dot42.DexImport("glUniform3i", "(IIII)V", AccessFlags = 265)]
				public static void GlUniform3i(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3iv
				/// </java-name>
				[Dot42.DexImport("glUniform3iv", "(II[II)V", AccessFlags = 265)]
				public static void GlUniform3iv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform3iv
				/// </java-name>
				[Dot42.DexImport("glUniform3iv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlUniform3iv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4f
				/// </java-name>
				[Dot42.DexImport("glUniform4f", "(IFFFF)V", AccessFlags = 265)]
				public static void GlUniform4f(int int32, float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4fv
				/// </java-name>
				[Dot42.DexImport("glUniform4fv", "(II[FI)V", AccessFlags = 265)]
				public static void GlUniform4fv(int int32, int int321, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4fv
				/// </java-name>
				[Dot42.DexImport("glUniform4fv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniform4fv(int int32, int int321, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4i
				/// </java-name>
				[Dot42.DexImport("glUniform4i", "(IIIII)V", AccessFlags = 265)]
				public static void GlUniform4i(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4iv
				/// </java-name>
				[Dot42.DexImport("glUniform4iv", "(II[II)V", AccessFlags = 265)]
				public static void GlUniform4iv(int int32, int int321, int[] int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniform4iv
				/// </java-name>
				[Dot42.DexImport("glUniform4iv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 265)]
				public static void GlUniform4iv(int int32, int int321, global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix2fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix2fv", "(IIZ[FI)V", AccessFlags = 265)]
				public static void GlUniformMatrix2fv(int int32, int int321, bool boolean, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix2fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix2fv", "(IIZLjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniformMatrix2fv(int int32, int int321, bool boolean, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix3fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix3fv", "(IIZ[FI)V", AccessFlags = 265)]
				public static void GlUniformMatrix3fv(int int32, int int321, bool boolean, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix3fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix3fv", "(IIZLjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniformMatrix3fv(int int32, int int321, bool boolean, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix4fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix4fv", "(IIZ[FI)V", AccessFlags = 265)]
				public static void GlUniformMatrix4fv(int int32, int int321, bool boolean, float[] single, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUniformMatrix4fv
				/// </java-name>
				[Dot42.DexImport("glUniformMatrix4fv", "(IIZLjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlUniformMatrix4fv(int int32, int int321, bool boolean, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glUseProgram
				/// </java-name>
				[Dot42.DexImport("glUseProgram", "(I)V", AccessFlags = 265)]
				public static void GlUseProgram(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glValidateProgram
				/// </java-name>
				[Dot42.DexImport("glValidateProgram", "(I)V", AccessFlags = 265)]
				public static void GlValidateProgram(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib1f
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib1f", "(IF)V", AccessFlags = 265)]
				public static void GlVertexAttrib1f(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib1fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib1fv", "(I[FI)V", AccessFlags = 265)]
				public static void GlVertexAttrib1fv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib1fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib1fv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlVertexAttrib1fv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib2f
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib2f", "(IFF)V", AccessFlags = 265)]
				public static void GlVertexAttrib2f(int int32, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib2fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib2fv", "(I[FI)V", AccessFlags = 265)]
				public static void GlVertexAttrib2fv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib2fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib2fv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlVertexAttrib2fv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib3f
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib3f", "(IFFF)V", AccessFlags = 265)]
				public static void GlVertexAttrib3f(int int32, float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib3fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib3fv", "(I[FI)V", AccessFlags = 265)]
				public static void GlVertexAttrib3fv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib3fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib3fv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlVertexAttrib3fv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib4f
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib4f", "(IFFFF)V", AccessFlags = 265)]
				public static void GlVertexAttrib4f(int int32, float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib4fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib4fv", "(I[FI)V", AccessFlags = 265)]
				public static void GlVertexAttrib4fv(int int32, float[] single, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttrib4fv
				/// </java-name>
				[Dot42.DexImport("glVertexAttrib4fv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 265)]
				public static void GlVertexAttrib4fv(int int32, global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttribPointer
				/// </java-name>
				[Dot42.DexImport("glVertexAttribPointer", "(IIIZII)V", AccessFlags = 265)]
				public static void GlVertexAttribPointer(int int32, int int321, int int322, bool boolean, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glVertexAttribPointer
				/// </java-name>
				[Dot42.DexImport("glVertexAttribPointer", "(IIIZILjava/nio/Buffer;)V", AccessFlags = 9)]
				public static void GlVertexAttribPointer(int int32, int int321, int int322, bool boolean, int int323, global::Java.Nio.Buffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// glViewport
				/// </java-name>
				[Dot42.DexImport("glViewport", "(IIII)V", AccessFlags = 265)]
				public static void GlViewport(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/GLException
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLException", AccessFlags = 33)]
		public partial class GLException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public GLException(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public GLException(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GLException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/GLSurfaceView
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLSurfaceView", AccessFlags = 33)]
		public partial class GLSurfaceView : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RENDERMODE_WHEN_DIRTY
				/// </java-name>
				[Dot42.DexImport("RENDERMODE_WHEN_DIRTY", "I", AccessFlags = 25)]
				public const int RENDERMODE_WHEN_DIRTY = 0;
				/// <java-name>
				/// RENDERMODE_CONTINUOUSLY
				/// </java-name>
				[Dot42.DexImport("RENDERMODE_CONTINUOUSLY", "I", AccessFlags = 25)]
				public const int RENDERMODE_CONTINUOUSLY = 1;
				/// <java-name>
				/// DEBUG_CHECK_GL_ERROR
				/// </java-name>
				[Dot42.DexImport("DEBUG_CHECK_GL_ERROR", "I", AccessFlags = 25)]
				public const int DEBUG_CHECK_GL_ERROR = 1;
				/// <java-name>
				/// DEBUG_LOG_GL_CALLS
				/// </java-name>
				[Dot42.DexImport("DEBUG_LOG_GL_CALLS", "I", AccessFlags = 25)]
				public const int DEBUG_LOG_GL_CALLS = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public GLSurfaceView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GLSurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGLWrapper
				/// </java-name>
				[Dot42.DexImport("setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V", AccessFlags = 1)]
				public virtual void SetGLWrapper(global::Android.Opengl.GLSurfaceView.IGLWrapper gLWrapper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRenderer
				/// </java-name>
				[Dot42.DexImport("setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V", AccessFlags = 1)]
				public virtual void SetRenderer(global::Android.Opengl.GLSurfaceView.IRenderer renderer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLContextFactory
				/// </java-name>
				[Dot42.DexImport("setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V", AccessFlags = 1)]
				public virtual void SetEGLContextFactory(global::Android.Opengl.GLSurfaceView.IEGLContextFactory eGLContextFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLWindowSurfaceFactory
				/// </java-name>
				[Dot42.DexImport("setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V", AccessFlags = 1)]
				public virtual void SetEGLWindowSurfaceFactory(global::Android.Opengl.GLSurfaceView.IEGLWindowSurfaceFactory eGLWindowSurfaceFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLConfigChooser
				/// </java-name>
				[Dot42.DexImport("setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V", AccessFlags = 1)]
				public virtual void SetEGLConfigChooser(global::Android.Opengl.GLSurfaceView.IEGLConfigChooser eGLConfigChooser) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLConfigChooser
				/// </java-name>
				[Dot42.DexImport("setEGLConfigChooser", "(Z)V", AccessFlags = 1)]
				public virtual void SetEGLConfigChooser(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLConfigChooser
				/// </java-name>
				[Dot42.DexImport("setEGLConfigChooser", "(IIIIII)V", AccessFlags = 1)]
				public virtual void SetEGLConfigChooser(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEGLContextClientVersion
				/// </java-name>
				[Dot42.DexImport("setEGLContextClientVersion", "(I)V", AccessFlags = 1)]
				public virtual void SetEGLContextClientVersion(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestRender
				/// </java-name>
				[Dot42.DexImport("requestRender", "()V", AccessFlags = 1)]
				public virtual void RequestRender() /* MethodBuilder.Create */ 
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
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// queueEvent
				/// </java-name>
				[Dot42.DexImport("queueEvent", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void QueueEvent(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GLSurfaceView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDebugFlags
				/// </java-name>
				public virtual int DebugFlags
				{
						[Dot42.DexImport("getDebugFlags", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDebugFlags", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPreserveEGLContextOnPause
				/// </java-name>
				public virtual bool IsPreserveEGLContextOnPause
				{
						[Dot42.DexImport("getPreserveEGLContextOnPause", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPreserveEGLContextOnPause", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRenderMode
				/// </java-name>
				public virtual int RenderMode
				{
						[Dot42.DexImport("getRenderMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRenderMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/opengl/GLSurfaceView$EGLConfigChooser
				/// </java-name>
				[Dot42.DexImport("android/opengl/GLSurfaceView$EGLConfigChooser", AccessFlags = 1545)]
				public partial interface IEGLConfigChooser
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// chooseConfig
						/// </java-name>
						[Dot42.DexImport("chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay" +
    ";)Ljavax/microedition/khronos/egl/EGLConfig;", AccessFlags = 1025)]
						global::Javax.Microedition.Khronos.Egl.EGLConfig ChooseConfig(global::Javax.Microedition.Khronos.Egl.IEGL10 eGL10, global::Javax.Microedition.Khronos.Egl.EGLDisplay eGLDisplay) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/opengl/GLSurfaceView$EGLWindowSurfaceFactory
				/// </java-name>
				[Dot42.DexImport("android/opengl/GLSurfaceView$EGLWindowSurfaceFactory", AccessFlags = 1545)]
				public partial interface IEGLWindowSurfaceFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// createWindowSurface
						/// </java-name>
						[Dot42.DexImport("createWindowSurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay" +
    ";Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;)Ljavax/microeditio" +
    "n/khronos/egl/EGLSurface;", AccessFlags = 1025)]
						global::Javax.Microedition.Khronos.Egl.EGLSurface CreateWindowSurface(global::Javax.Microedition.Khronos.Egl.IEGL10 eGL10, global::Javax.Microedition.Khronos.Egl.EGLDisplay eGLDisplay, global::Javax.Microedition.Khronos.Egl.EGLConfig eGLConfig, object @object) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// destroySurface
						/// </java-name>
						[Dot42.DexImport("destroySurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay" +
    ";Ljavax/microedition/khronos/egl/EGLSurface;)V", AccessFlags = 1025)]
						void DestroySurface(global::Javax.Microedition.Khronos.Egl.IEGL10 eGL10, global::Javax.Microedition.Khronos.Egl.EGLDisplay eGLDisplay, global::Javax.Microedition.Khronos.Egl.EGLSurface eGLSurface) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/opengl/GLSurfaceView$EGLContextFactory
				/// </java-name>
				[Dot42.DexImport("android/opengl/GLSurfaceView$EGLContextFactory", AccessFlags = 1545)]
				public partial interface IEGLContextFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// createContext
						/// </java-name>
						[Dot42.DexImport("createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay" +
    ";Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLC" +
    "ontext;", AccessFlags = 1025)]
						global::Javax.Microedition.Khronos.Egl.EGLContext CreateContext(global::Javax.Microedition.Khronos.Egl.IEGL10 eGL10, global::Javax.Microedition.Khronos.Egl.EGLDisplay eGLDisplay, global::Javax.Microedition.Khronos.Egl.EGLConfig eGLConfig) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// destroyContext
						/// </java-name>
						[Dot42.DexImport("destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay" +
    ";Ljavax/microedition/khronos/egl/EGLContext;)V", AccessFlags = 1025)]
						void DestroyContext(global::Javax.Microedition.Khronos.Egl.IEGL10 eGL10, global::Javax.Microedition.Khronos.Egl.EGLDisplay eGLDisplay, global::Javax.Microedition.Khronos.Egl.EGLContext eGLContext) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/opengl/GLSurfaceView$Renderer
				/// </java-name>
				[Dot42.DexImport("android/opengl/GLSurfaceView$Renderer", AccessFlags = 1545)]
				public partial interface IRenderer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSurfaceCreated
						/// </java-name>
						[Dot42.DexImport("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLCon" +
    "fig;)V", AccessFlags = 1025)]
						void OnSurfaceCreated(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10, global::Javax.Microedition.Khronos.Egl.EGLConfig eGLConfig) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSurfaceChanged
						/// </java-name>
						[Dot42.DexImport("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", AccessFlags = 1025)]
						void OnSurfaceChanged(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10, int int32, int int321) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDrawFrame
						/// </java-name>
						[Dot42.DexImport("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", AccessFlags = 1025)]
						void OnDrawFrame(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/opengl/GLSurfaceView$GLWrapper
				/// </java-name>
				[Dot42.DexImport("android/opengl/GLSurfaceView$GLWrapper", AccessFlags = 1545)]
				public partial interface IGLWrapper
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// wrap
						/// </java-name>
						[Dot42.DexImport("wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL" +
    ";", AccessFlags = 1025)]
						global::Javax.Microedition.Khronos.Opengles.IGL Wrap(global::Javax.Microedition.Khronos.Opengles.IGL gL) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/opengl/GLU
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLU", AccessFlags = 33)]
		public partial class GLU
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GLU() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gluErrorString
				/// </java-name>
				[Dot42.DexImport("gluErrorString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GluErrorString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// gluLookAt
				/// </java-name>
				[Dot42.DexImport("gluLookAt", "(Ljavax/microedition/khronos/opengles/GL10;FFFFFFFFF)V", AccessFlags = 9)]
				public static void GluLookAt(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10, float single, float single1, float single2, float single3, float single4, float single5, float single6, float single7, float single8) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gluOrtho2D
				/// </java-name>
				[Dot42.DexImport("gluOrtho2D", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V", AccessFlags = 9)]
				public static void GluOrtho2D(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10, float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gluPerspective
				/// </java-name>
				[Dot42.DexImport("gluPerspective", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V", AccessFlags = 9)]
				public static void GluPerspective(global::Javax.Microedition.Khronos.Opengles.IGL10 gL10, float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gluProject
				/// </java-name>
				[Dot42.DexImport("gluProject", "(FFF[FI[FI[II[FI)I", AccessFlags = 9)]
				public static int GluProject(float single, float single1, float single2, float[] single3, int int32, float[] single4, int int321, int[] int322, int int323, float[] single5, int int324) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// gluUnProject
				/// </java-name>
				[Dot42.DexImport("gluUnProject", "(FFF[FI[FI[II[FI)I", AccessFlags = 9)]
				public static int GluUnProject(float single, float single1, float single2, float[] single3, int int32, float[] single4, int int321, int[] int322, int int323, float[] single5, int int324) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/opengl/GLUtils
		/// </java-name>
		[Dot42.DexImport("android/opengl/GLUtils", AccessFlags = 49)]
		public sealed partial class GLUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GLUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInternalFormat
				/// </java-name>
				[Dot42.DexImport("getInternalFormat", "(Landroid/graphics/Bitmap;)I", AccessFlags = 9)]
				public static int GetInternalFormat(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/graphics/Bitmap;)I", AccessFlags = 9)]
				public static int GetType(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// texImage2D
				/// </java-name>
				[Dot42.DexImport("texImage2D", "(IIILandroid/graphics/Bitmap;I)V", AccessFlags = 9)]
				public static void TexImage2D(int int32, int int321, int int322, global::Android.Graphics.Bitmap bitmap, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// texImage2D
				/// </java-name>
				[Dot42.DexImport("texImage2D", "(IIILandroid/graphics/Bitmap;II)V", AccessFlags = 9)]
				public static void TexImage2D(int int32, int int321, int int322, global::Android.Graphics.Bitmap bitmap, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// texImage2D
				/// </java-name>
				[Dot42.DexImport("texImage2D", "(IILandroid/graphics/Bitmap;I)V", AccessFlags = 9)]
				public static void TexImage2D(int int32, int int321, global::Android.Graphics.Bitmap bitmap, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// texSubImage2D
				/// </java-name>
				[Dot42.DexImport("texSubImage2D", "(IIIILandroid/graphics/Bitmap;)V", AccessFlags = 9)]
				public static void TexSubImage2D(int int32, int int321, int int322, int int323, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// texSubImage2D
				/// </java-name>
				[Dot42.DexImport("texSubImage2D", "(IIIILandroid/graphics/Bitmap;II)V", AccessFlags = 9)]
				public static void TexSubImage2D(int int32, int int321, int int322, int int323, global::Android.Graphics.Bitmap bitmap, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEGLErrorString
				/// </java-name>
				[Dot42.DexImport("getEGLErrorString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetEGLErrorString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/opengl/Matrix
		/// </java-name>
		[Dot42.DexImport("android/opengl/Matrix", AccessFlags = 33)]
		public partial class Matrix
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// multiplyMM
				/// </java-name>
				[Dot42.DexImport("multiplyMM", "([FI[FI[FI)V", AccessFlags = 265)]
				public static void MultiplyMM(float[] single, int int32, float[] single1, int int321, float[] single2, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// multiplyMV
				/// </java-name>
				[Dot42.DexImport("multiplyMV", "([FI[FI[FI)V", AccessFlags = 265)]
				public static void MultiplyMV(float[] single, int int32, float[] single1, int int321, float[] single2, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transposeM
				/// </java-name>
				[Dot42.DexImport("transposeM", "([FI[FI)V", AccessFlags = 9)]
				public static void TransposeM(float[] single, int int32, float[] single1, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invertM
				/// </java-name>
				[Dot42.DexImport("invertM", "([FI[FI)Z", AccessFlags = 9)]
				public static bool InvertM(float[] single, int int32, float[] single1, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// orthoM
				/// </java-name>
				[Dot42.DexImport("orthoM", "([FIFFFFFF)V", AccessFlags = 9)]
				public static void OrthoM(float[] single, int int32, float single1, float single2, float single3, float single4, float single5, float single6) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// frustumM
				/// </java-name>
				[Dot42.DexImport("frustumM", "([FIFFFFFF)V", AccessFlags = 9)]
				public static void FrustumM(float[] single, int int32, float single1, float single2, float single3, float single4, float single5, float single6) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// perspectiveM
				/// </java-name>
				[Dot42.DexImport("perspectiveM", "([FIFFFF)V", AccessFlags = 9)]
				public static void PerspectiveM(float[] single, int int32, float single1, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "(FFF)F", AccessFlags = 9)]
				public static float Length(float single, float single1, float single2) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setIdentityM
				/// </java-name>
				[Dot42.DexImport("setIdentityM", "([FI)V", AccessFlags = 9)]
				public static void SetIdentityM(float[] single, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scaleM
				/// </java-name>
				[Dot42.DexImport("scaleM", "([FI[FIFFF)V", AccessFlags = 9)]
				public static void ScaleM(float[] single, int int32, float[] single1, int int321, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scaleM
				/// </java-name>
				[Dot42.DexImport("scaleM", "([FIFFF)V", AccessFlags = 9)]
				public static void ScaleM(float[] single, int int32, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translateM
				/// </java-name>
				[Dot42.DexImport("translateM", "([FI[FIFFF)V", AccessFlags = 9)]
				public static void TranslateM(float[] single, int int32, float[] single1, int int321, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// translateM
				/// </java-name>
				[Dot42.DexImport("translateM", "([FIFFF)V", AccessFlags = 9)]
				public static void TranslateM(float[] single, int int32, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotateM
				/// </java-name>
				[Dot42.DexImport("rotateM", "([FI[FIFFFF)V", AccessFlags = 9)]
				public static void RotateM(float[] single, int int32, float[] single1, int int321, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// rotateM
				/// </java-name>
				[Dot42.DexImport("rotateM", "([FIFFFF)V", AccessFlags = 9)]
				public static void RotateM(float[] single, int int32, float single1, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRotateM
				/// </java-name>
				[Dot42.DexImport("setRotateM", "([FIFFFF)V", AccessFlags = 9)]
				public static void SetRotateM(float[] single, int int32, float single1, float single2, float single3, float single4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRotateEulerM
				/// </java-name>
				[Dot42.DexImport("setRotateEulerM", "([FIFFF)V", AccessFlags = 9)]
				public static void SetRotateEulerM(float[] single, int int32, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLookAtM
				/// </java-name>
				[Dot42.DexImport("setLookAtM", "([FIFFFFFFFFF)V", AccessFlags = 9)]
				public static void SetLookAtM(float[] single, int int32, float single1, float single2, float single3, float single4, float single5, float single6, float single7, float single8, float single9) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/opengl/Visibility
		/// </java-name>
		[Dot42.DexImport("android/opengl/Visibility", AccessFlags = 33)]
		public partial class Visibility
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Visibility() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// visibilityTest
				/// </java-name>
				[Dot42.DexImport("visibilityTest", "([FI[FI[CII)I", AccessFlags = 265)]
				public static int VisibilityTest(float[] single, int int32, float[] single1, int int321, char[] @char, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// frustumCullSpheres
				/// </java-name>
				[Dot42.DexImport("frustumCullSpheres", "([FI[FII[III)I", AccessFlags = 265)]
				public static int FrustumCullSpheres(float[] single, int int32, float[] single1, int int321, int int322, int[] int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeBoundingSphere
				/// </java-name>
				[Dot42.DexImport("computeBoundingSphere", "([FII[FI)V", AccessFlags = 265)]
				public static void ComputeBoundingSphere(float[] single, int int32, int int321, float[] single1, int int322) /* MethodBuilder.Create */ 
				{
				}

		}

}

