#pragma warning disable 1717
namespace Android.Util
{
		/// <summary>
		///  <para>Base class for all checked exceptions thrown by the Android frameworks. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/AndroidException
		/// </java-name>
		[Dot42.DexImport("android/util/AndroidException", AccessFlags = 33)]
		public partial class AndroidException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AndroidException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public AndroidException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Base class for all unchecked exceptions thrown by the Android frameworks. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/AndroidRuntimeException
		/// </java-name>
		[Dot42.DexImport("android/util/AndroidRuntimeException", AccessFlags = 33)]
		public partial class AndroidRuntimeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidRuntimeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AndroidRuntimeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public AndroidRuntimeException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Utilities for encoding and decoding the Base64 representation of binary data. See RFCs  and . </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Base64
		/// </java-name>
		[Dot42.DexImport("android/util/Base64", AccessFlags = 33)]
		public partial class Base64
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default values for encoder/decoder flags. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 0;
				/// <summary>
				///  <para>Encoder flag bit to omit the padding '=' characters at the end of the output (if any). </para>        
				/// </summary>
				/// <java-name>
				/// NO_PADDING
				/// </java-name>
				[Dot42.DexImport("NO_PADDING", "I", AccessFlags = 25)]
				public const int NO_PADDING = 1;
				/// <summary>
				///  <para>Encoder flag bit to omit all line terminators (i.e., the output will be on one long line). </para>        
				/// </summary>
				/// <java-name>
				/// NO_WRAP
				/// </java-name>
				[Dot42.DexImport("NO_WRAP", "I", AccessFlags = 25)]
				public const int NO_WRAP = 2;
				/// <summary>
				///  <para>Encoder flag bit to indicate lines should be terminated with a CRLF pair instead of just an LF. Has no effect if <c>NO_WRAP </c> is specified as well. </para>        
				/// </summary>
				/// <java-name>
				/// CRLF
				/// </java-name>
				[Dot42.DexImport("CRLF", "I", AccessFlags = 25)]
				public const int CRLF = 4;
				/// <summary>
				///  <para>Encoder/decoder flag bit to indicate using the "URL andfilename safe" variant of Base64 (see RFC 3548 section 4) where  <c>- </c> and <c>_ </c> are used in place of <c>+ </c> and  <c>/ </c> . </para>        
				/// </summary>
				/// <java-name>
				/// URL_SAFE
				/// </java-name>
				[Dot42.DexImport("URL_SAFE", "I", AccessFlags = 25)]
				public const int URL_SAFE = 8;
				/// <summary>
				///  <para>Flag to pass to Base64OutputStream to indicate that it should not close the output stream it is wrapping when it itself is closed. </para>        
				/// </summary>
				/// <java-name>
				/// NO_CLOSE
				/// </java-name>
				[Dot42.DexImport("NO_CLOSE", "I", AccessFlags = 25)]
				public const int NO_CLOSE = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Base64() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;I)[B", AccessFlags = 9)]
				public static sbyte[] JavaDecode(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;I)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BI)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BI)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Decode the Base64-encoded data in input and return the data in a new byte array.</para> <para>The padding '=' characters at the end are considered optional, but if any are present, there must be the correct number of them.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BIII)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Decode the Base64-encoded data in input and return the data in a new byte array.</para> <para>The padding '=' characters at the end are considered optional, but if any are present, there must be the correct number of them.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([BIII)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated String with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BI)Ljava/lang/String;", AccessFlags = 9)]
				public static string EncodeToString(sbyte[] input, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated String with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BI)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string EncodeToString(byte[] input, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated String with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BIII)Ljava/lang/String;", AccessFlags = 9)]
				public static string EncodeToString(sbyte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated String with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encodeToString
				/// </java-name>
				[Dot42.DexImport("encodeToString", "([BIII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string EncodeToString(byte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated byte[] with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BI)[B", AccessFlags = 9)]
				public static sbyte[] Encode(sbyte[] input, int flags) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated byte[] with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BI)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Encode(byte[] input, int flags) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated byte[] with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BIII)[B", AccessFlags = 9)]
				public static sbyte[] Encode(sbyte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Base64-encode the given data and return a newly allocated byte[] with the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "([BIII)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Encode(byte[] input, int offset, int len, int flags) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

		}

		/// <summary>
		///  <para>An InputStream that does Base64 decoding on the data read through it. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Base64InputStream
		/// </java-name>
		[Dot42.DexImport("android/util/Base64InputStream", AccessFlags = 33)]
		public partial class Base64InputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An InputStream that performs Base64 decoding on the data read from the wrapped stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public Base64InputStream(global::Java.IO.InputStream @in, int flags) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
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
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long n) /* MethodBuilder.Create */ 
				{
						return default(long);
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
				public override int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Base64InputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An OutputStream that does Base64 encoding on the data written to it, writing the resulting data to another OutputStream. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Base64OutputStream
		/// </java-name>
		[Dot42.DexImport("android/util/Base64OutputStream", AccessFlags = 33)]
		public partial class Base64OutputStream : global::Java.IO.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Performs Base64 encoding on the data written to the stream, writing the encoded data to another OutputStream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public Base64OutputStream(global::Java.IO.OutputStream @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Base64OutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This class is not useful, it just returns the same value for all constants, and has always done this. Do not use it. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/util/Config
		/// </java-name>
		[Dot42.DexImport("android/util/Config", AccessFlags = 49)]
		public sealed partial class Config
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DEBUG
				/// </java-name>
				[Dot42.DexImport("DEBUG", "Z", AccessFlags = 25)]
				public static readonly bool DEBUG;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always true. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RELEASE
				/// </java-name>
				[Dot42.DexImport("RELEASE", "Z", AccessFlags = 25)]
				public static readonly bool RELEASE;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// PROFILE
				/// </java-name>
				[Dot42.DexImport("PROFILE", "Z", AccessFlags = 25)]
				public const bool PROFILE = false;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LOGV
				/// </java-name>
				[Dot42.DexImport("LOGV", "Z", AccessFlags = 25)]
				public const bool LOGV = false;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Always true. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LOGD
				/// </java-name>
				[Dot42.DexImport("LOGD", "Z", AccessFlags = 25)]
				public const bool LOGD = true;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Config() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Various utilities for debugging and logging.</para>    
		/// </summary>
		/// <java-name>
		/// android/util/DebugUtils
		/// </java-name>
		[Dot42.DexImport("android/util/DebugUtils", AccessFlags = 33)]
		public partial class DebugUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DebugUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Filters objects against the  <code>ANDROID_OBJECT_FILTER</code> environment variable. This environment variable can filter objects based on their class name and attribute values.</para> <para>Here is the syntax for  <code>ANDROID_OBJECT_FILTER</code>:</para> <para> <code>ClassName=value1=value2...</code></para> <para>Examples:</para> <para> <ul> <li> <para>Select TextView instances:  <code>TextView</code> </para></li> <li> <para>Select TextView instances of text "Loading" and bottom offset of 22:  <code>TextView=Loading.*=22</code> </para></li></ul></para> <para>The class name and the values are regular expressions.</para> <para>This class is useful for debugging and logging purpose:</para> <para> <pre>
				/// if (DEBUG) {
				///   if (DebugUtils.isObjectSelected(childView) &amp;&amp; LOGV_ENABLED) {
				///     Log.v(TAG, "Object " + childView + " logged!");
				///   }
				/// }
				/// </pre></para> <para> <b>NOTE</b>: This method is very expensive as it relies heavily on regular expressions and reflection. Calls to this method should always be stripped out of the release binaries and avoided as much as possible in debug mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if object is selected by the ANDROID_OBJECT_FILTER environment variable, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isObjectSelected
				/// </java-name>
				[Dot42.DexImport("isObjectSelected", "(Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsObjectSelected(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>A structure describing general information about a display, such as its size, density, and font scaling. </para> <para>To access the DisplayMetrics members, initialize an object like this:</para> <para> <pre> DisplayMetrics metrics = new DisplayMetrics();
		/// getWindowManager().getDefaultDisplay().getMetrics(metrics);</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/util/DisplayMetrics
		/// </java-name>
		[Dot42.DexImport("android/util/DisplayMetrics", AccessFlags = 33)]
		public partial class DisplayMetrics
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Standard quantized DPI for low-density screens. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_LOW
				/// </java-name>
				[Dot42.DexImport("DENSITY_LOW", "I", AccessFlags = 25)]
				public const int DENSITY_LOW = 120;
				/// <summary>
				///  <para>Standard quantized DPI for medium-density screens. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("DENSITY_MEDIUM", "I", AccessFlags = 25)]
				public const int DENSITY_MEDIUM = 160;
				/// <summary>
				///  <para>Standard quantized DPI for high-density screens. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_HIGH
				/// </java-name>
				[Dot42.DexImport("DENSITY_HIGH", "I", AccessFlags = 25)]
				public const int DENSITY_HIGH = 240;
				/// <summary>
				///  <para>Standard quantized DPI for extra-high-density screens. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_XHIGH
				/// </java-name>
				[Dot42.DexImport("DENSITY_XHIGH", "I", AccessFlags = 25)]
				public const int DENSITY_XHIGH = 320;
				/// <summary>
				///  <para>The reference density used throughout the system. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("DENSITY_DEFAULT", "I", AccessFlags = 25)]
				public const int DENSITY_DEFAULT = 160;
				/// <summary>
				///  <para>The absolute width of the display in pixels. </para>        
				/// </summary>
				/// <java-name>
				/// widthPixels
				/// </java-name>
				[Dot42.DexImport("widthPixels", "I", AccessFlags = 1)]
				public int WidthPixels;
				/// <summary>
				///  <para>The absolute height of the display in pixels. </para>        
				/// </summary>
				/// <java-name>
				/// heightPixels
				/// </java-name>
				[Dot42.DexImport("heightPixels", "I", AccessFlags = 1)]
				public int HeightPixels;
				/// <summary>
				///  <para>The logical density of the display. This is a scaling factor for the Density Independent Pixel unit, where one DIP is one pixel on an approximately 160 dpi screen (for example a 240x320, 1.5"x2" screen), providing the baseline of the system's display. Thus on a 160dpi screen this density value will be 1; on a 120 dpi screen it would be .75; etc.</para> <para>This value does not exactly follow the real screen size (as given by xdpi and ydpi, but rather is used to scale the size of the overall UI in steps based on gross changes in the display dpi. For example, a 240x320 screen will have a density of 1 even if its width is 1.8", 1.3", etc. However, if the screen resolution is increased to 320x480 but the screen size remained 1.5"x2" then the density would be increased (probably to 1.5).</para> <para> <para>DENSITY_DEFAULT </para></para>        
				/// </summary>
				/// <java-name>
				/// density
				/// </java-name>
				[Dot42.DexImport("density", "F", AccessFlags = 1)]
				public float Density;
				/// <summary>
				///  <para>The screen density expressed as dots-per-inch. May be either DENSITY_LOW, DENSITY_MEDIUM, or DENSITY_HIGH. </para>        
				/// </summary>
				/// <java-name>
				/// densityDpi
				/// </java-name>
				[Dot42.DexImport("densityDpi", "I", AccessFlags = 1)]
				public int DensityDpi;
				/// <summary>
				///  <para>A scaling factor for fonts displayed on the display. This is the same as density, except that it may be adjusted in smaller increments at runtime based on a user preference for the font size. </para>        
				/// </summary>
				/// <java-name>
				/// scaledDensity
				/// </java-name>
				[Dot42.DexImport("scaledDensity", "F", AccessFlags = 1)]
				public float ScaledDensity;
				/// <summary>
				///  <para>The exact physical pixels per inch of the screen in the X dimension. </para>        
				/// </summary>
				/// <java-name>
				/// xdpi
				/// </java-name>
				[Dot42.DexImport("xdpi", "F", AccessFlags = 1)]
				public float Xdpi;
				/// <summary>
				///  <para>The exact physical pixels per inch of the screen in the Y dimension. </para>        
				/// </summary>
				/// <java-name>
				/// ydpi
				/// </java-name>
				[Dot42.DexImport("ydpi", "F", AccessFlags = 1)]
				public float Ydpi;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DisplayMetrics() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTo(global::Android.Util.DisplayMetrics o) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setToDefaults
				/// </java-name>
				[Dot42.DexImport("setToDefaults", "()V", AccessFlags = 1)]
				public virtual void SetToDefaults() /* MethodBuilder.Create */ 
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
		///  <para>Access to the system diagnostic event record. System diagnostic events are used to record certain system-level events (such as garbage collection, activity manager state, system watchdogs, and other low level activity), which may be automatically collected and analyzed during system development.</para> <para>This is  <b>not</b> the main "logcat" debugging log (android.util.Log)! These diagnostic events are for system integrators, not application authors.</para> <para>Events use integer tag codes corresponding to /system/etc/event-log-tags. They carry a payload of one or more int, long, or String values. The event-log-tags file defines the payload contents for each type code. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/EventLog
		/// </java-name>
		[Dot42.DexImport("android/util/EventLog", AccessFlags = 33)]
		public partial class EventLog
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EventLog() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Record an event log message. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(II)I", AccessFlags = 265)]
				public static int WriteEvent(int tag, int value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Record an event log message. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(IJ)I", AccessFlags = 265)]
				public static int WriteEvent(int tag, long value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Record an event log message. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(ILjava/lang/String;)I", AccessFlags = 265)]
				public static int WriteEvent(int tag, string value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Record an event log message. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEvent
				/// </java-name>
				[Dot42.DexImport("writeEvent", "(I[Ljava/lang/Object;)I", AccessFlags = 393)]
				public static int WriteEvent(int tag, params object[] value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Read events from the log, filtered by type. </para>        
				/// </summary>
				/// <java-name>
				/// readEvents
				/// </java-name>
				[Dot42.DexImport("readEvents", "([ILjava/util/Collection;)V", AccessFlags = 265, Signature = "([ILjava/util/Collection<Landroid/util/EventLog$Event;>;)V")]
				public static void ReadEvents(int[] tags, global::Java.Util.ICollection<global::Android.Util.EventLog.Event> output) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the name associated with an event type tag code. </para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the tag, or null if no tag has that number </para>
				/// </returns>
				/// <java-name>
				/// getTagName
				/// </java-name>
				[Dot42.DexImport("getTagName", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetTagName(int tag) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Get the event type tag code associated with an event name. </para>        
				/// </summary>
				/// <returns>
				///  <para>the tag code, or -1 if no tag has that name </para>
				/// </returns>
				/// <java-name>
				/// getTagCode
				/// </java-name>
				[Dot42.DexImport("getTagCode", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetTagCode(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>A previously logged event read from the logs. </para>    
				/// </summary>
				/// <java-name>
				/// android/util/EventLog$Event
				/// </java-name>
				[Dot42.DexImport("android/util/EventLog$Event", AccessFlags = 25)]
				public sealed partial class Event
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Event() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the process ID which wrote the log entry </para>
						/// </returns>
						/// <java-name>
						/// getProcessId
						/// </java-name>
						public int ProcessId
						{
								[Dot42.DexImport("getProcessId", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the thread ID which wrote the log entry </para>
						/// </returns>
						/// <java-name>
						/// getThreadId
						/// </java-name>
						public int ThreadId
						{
								[Dot42.DexImport("getThreadId", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the wall clock time when the entry was written </para>
						/// </returns>
						/// <java-name>
						/// getTimeNanos
						/// </java-name>
						public long TimeNanos
						{
								[Dot42.DexImport("getTimeNanos", "()J", AccessFlags = 1)]
								get{ return default(long); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the type tag code of the entry </para>
						/// </returns>
						/// <java-name>
						/// getTag
						/// </java-name>
						public int Tag
						{
								[Dot42.DexImport("getTag", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>one of Integer, Long, String, null, or Object[] of same. </para>
						/// </returns>
						/// <java-name>
						/// getData
						/// </java-name>
						public object Data
						{
								[Dot42.DexImport("getData", "()Ljava/lang/Object;", AccessFlags = 33)]
								get{ return default(object); }
						}

				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This class is no longer functional. Use android.util.EventLog instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/util/EventLogTags
		/// </java-name>
		[Dot42.DexImport("android/util/EventLogTags", AccessFlags = 33)]
		public partial class EventLogTags
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EventLogTags() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/BufferedReader;)V", AccessFlags = 1)]
				public EventLogTags(global::Java.IO.BufferedReader input) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Landroid/util/EventLogTags$Description;", AccessFlags = 1)]
				public virtual global::Android.Util.EventLogTags.Description Get(string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.EventLogTags.Description);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Landroid/util/EventLogTags$Description;", AccessFlags = 1)]
				public virtual global::Android.Util.EventLogTags.Description Get(int tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.EventLogTags.Description);
				}

				/// <java-name>
				/// android/util/EventLogTags$Description
				/// </java-name>
				[Dot42.DexImport("android/util/EventLogTags$Description", AccessFlags = 9)]
				public partial class Description
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mTag
						/// </java-name>
						[Dot42.DexImport("mTag", "I", AccessFlags = 17)]
						public readonly int MTag;
						/// <java-name>
						/// mName
						/// </java-name>
						[Dot42.DexImport("mName", "Ljava/lang/String;", AccessFlags = 17)]
						public readonly string MName;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Description() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Math routines similar to those found in java.lang.Math. On versions of Android with a JIT, these are significantly slower than the equivalent <c>Math </c> functions, which should be used in preference to these. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/FloatMath
		/// </java-name>
		[Dot42.DexImport("android/util/FloatMath", AccessFlags = 33)]
		public partial class FloatMath
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Prevents instantiation. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FloatMath() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the float conversion of the most positive (i.e. closest to positive infinity) integer value which is less than the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the floor of value </para>
				/// </returns>
				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(F)F", AccessFlags = 265)]
				public static float Floor(float value) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the float conversion of the most negative (i.e. closest to negative infinity) integer value which is greater than the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ceiling of value </para>
				/// </returns>
				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(F)F", AccessFlags = 265)]
				public static float Ceil(float value) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the closest float approximation of the sine of the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the sine of angle </para>
				/// </returns>
				/// <java-name>
				/// sin
				/// </java-name>
				[Dot42.DexImport("sin", "(F)F", AccessFlags = 265)]
				public static float Sin(float angle) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the closest float approximation of the cosine of the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cosine of angle </para>
				/// </returns>
				/// <java-name>
				/// cos
				/// </java-name>
				[Dot42.DexImport("cos", "(F)F", AccessFlags = 265)]
				public static float Cos(float angle) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the closest float approximation of the square root of the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the square root of value </para>
				/// </returns>
				/// <java-name>
				/// sqrt
				/// </java-name>
				[Dot42.DexImport("sqrt", "(F)F", AccessFlags = 265)]
				public static float Sqrt(float value) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		///  <para>A collection of attributes, as found associated with a tag in an XML document. Often you will not want to use this interface directly, instead passing it to Resources.Theme.obtainStyledAttributes() which will take care of parsing the attributes for you. In particular, the Resources API will convert resource references (attribute values such as "@string/my_label" in the original XML) to the desired type for you; if you use AttributeSet directly then you will need to manually check for resource references (with getAttributeResourceValue(int, int)) and do the resource lookup yourself if needed. Direct use of AttributeSet also prevents the application of themes and styles when retrieving attribute values.</para> <para>This interface provides an efficient mechanism for retrieving data from compiled XML files, which can be retrieved for a particular XmlPullParser through Xml.asAttributeSet(). Normally this will return an implementation of the interface that works on top of a generic XmlPullParser, however it is more useful in conjunction with compiled XML resources:</para> <para> <pre>
		/// XmlPullParser parser = resources.getXml(myResouce);
		/// AttributeSet attributes = Xml.asAttributeSet(parser);</pre></para> <para>The implementation returned here, unlike using the implementation on top of a generic XmlPullParser, is highly optimized by retrieving pre-computed information that was generated by aapt when compiling your resources. For example, the getAttributeFloatValue(int, float) method returns a floating point number previous stored in the compiled resource instead of parsing at runtime the string originally in the XML file.</para> <para>This interface also provides additional information contained in the compiled XML resource that is not available in a normal XML file, such as getAttributeNameResource(int) which returns the resource identifier associated with a particular XML attribute name. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/AttributeSet
		/// </java-name>
		[Dot42.DexImport("android/util/AttributeSet", AccessFlags = 1537)]
		public partial interface IAttributeSet
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the name of the specified attribute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String containing the name of the attribute, or null if the attribute cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeName
				/// </java-name>
				[Dot42.DexImport("getAttributeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeName(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified attribute as a string representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String containing the value of the attribute, or null if the attribute cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the value of the specified attribute as a string representation. The lookup is performed using the attribute name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String containing the value of the attribute, or null if the attribute cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(string @namespace, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the resource ID associated with the given attribute name. This will be the identifier for an attribute resource, which can be used by styles. Returns 0 if there is no resource associated with this attribute.</para> <para>Note that this is different than getAttributeResourceValue in that it returns a resource identifier for the attribute name; the other method returns this attribute's value as a resource identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resource identifier, 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeNameResource
				/// </java-name>
				[Dot42.DexImport("getAttributeNameResource", "(I)I", AccessFlags = 1025)]
				int GetAttributeNameResource(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the index of the value of 'attribute' in the list 'options'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Index in to 'options' or defaultValue. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeListValue
				/// </java-name>
				[Dot42.DexImport("getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeListValue(string @namespace, string attribute, string[] options, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the boolean value of 'attribute'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeBooleanValue
				/// </java-name>
				[Dot42.DexImport("getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetAttributeBooleanValue(string @namespace, string attribute, bool defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the value of 'attribute' as a resource identifier.</para> <para>Note that this is different than getAttributeNameResource in that it returns the value contained in this attribute as a resource identifier (i.e., a value originally of the form "@package:type/resource"); the other method returns a resource identifier that identifies the name of the attribute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeResourceValue(string @namespace, string attribute, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the integer value of 'attribute'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeIntValue(string @namespace, string attribute, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the boolean value of 'attribute' that is formatted as an unsigned value. In particular, the formats 0xn...n and #n...n are handled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeUnsignedIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeUnsignedIntValue(string @namespace, string attribute, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the float value of 'attribute'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeFloatValue
				/// </java-name>
				[Dot42.DexImport("getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F", AccessFlags = 1025)]
				float GetAttributeFloatValue(string @namespace, string attribute, float defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the index of the value of attribute at 'index' in the list 'options'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Index in to 'options' or defaultValue. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeListValue
				/// </java-name>
				[Dot42.DexImport("getAttributeListValue", "(I[Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetAttributeListValue(int index, string[] options, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the boolean value of attribute at 'index'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeBooleanValue
				/// </java-name>
				[Dot42.DexImport("getAttributeBooleanValue", "(IZ)Z", AccessFlags = 1025)]
				bool GetAttributeBooleanValue(int index, bool defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the value of attribute at 'index' as a resource identifier.</para> <para>Note that this is different than getAttributeNameResource in that it returns the value contained in this attribute as a resource identifier (i.e., a value originally of the form "@package:type/resource"); the other method returns a resource identifier that identifies the name of the attribute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getAttributeResourceValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeResourceValue(int index, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the integer value of attribute at 'index'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeIntValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeIntValue(int index, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the integer value of attribute at 'index' that is formatted as an unsigned value. In particular, the formats 0xn...n and #n...n are handled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeUnsignedIntValue
				/// </java-name>
				[Dot42.DexImport("getAttributeUnsignedIntValue", "(II)I", AccessFlags = 1025)]
				int GetAttributeUnsignedIntValue(int index, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the float value of attribute at 'index'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeFloatValue
				/// </java-name>
				[Dot42.DexImport("getAttributeFloatValue", "(IF)F", AccessFlags = 1025)]
				float GetAttributeFloatValue(int index, float defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the integer value of the "id" attribute or defaultValue if there is none. Equivalent to getAttributeResourceValue(null, "id", defaultValue);</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int Resulting value. </para>
				/// </returns>
				/// <java-name>
				/// getIdAttributeResourceValue
				/// </java-name>
				[Dot42.DexImport("getIdAttributeResourceValue", "(I)I", AccessFlags = 1025)]
				int GetIdAttributeResourceValue(int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of attributes available in the set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A positive integer, or 0 if the set is empty. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeCount
				/// </java-name>
				int AttributeCount
				{
						[Dot42.DexImport("getAttributeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a description of the current position of the attribute set. For instance, if the attribute set is loaded from an XML document, the position description could indicate the current line number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string representation of the current position in the set, may be null. </para>
				/// </returns>
				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				string PositionDescription
				{
						[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the value of the "id" attribute or null if there is not one. Equivalent to getAttributeValue(null, "id").</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id attribute's value or null. </para>
				/// </returns>
				/// <java-name>
				/// getIdAttribute
				/// </java-name>
				string IdAttribute
				{
						[Dot42.DexImport("getIdAttribute", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the value of the "class" attribute or null if there is not one. Equivalent to getAttributeValue(null, "class").</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The class attribute's value or null. </para>
				/// </returns>
				/// <java-name>
				/// getClassAttribute
				/// </java-name>
				string ClassAttribute
				{
						[Dot42.DexImport("getClassAttribute", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the value of the "style" attribute or 0 if there is not one. Equivalent to getAttributeResourceValue(null, "style").</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The style attribute's resource identifier or 0. </para>
				/// </returns>
				/// <java-name>
				/// getStyleAttribute
				/// </java-name>
				int StyleAttribute
				{
						[Dot42.DexImport("getStyleAttribute", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Simple interface for printing text, allowing redirection to various targets. Standard implementations are android.util.LogPrinter, android.util.StringBuilderPrinter, and android.util.PrintWriterPrinter. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Printer
		/// </java-name>
		[Dot42.DexImport("android/util/Printer", AccessFlags = 1537)]
		public partial interface IPrinter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Write a line of text to the output. There is no need to terminate the given string with a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Println(string x) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>API for sending log output.</para> <para>Generally, use the Log.v() Log.d() Log.i() Log.w() and Log.e() methods.</para> <para>The order in terms of verbosity, from least to most is ERROR, WARN, INFO, DEBUG, VERBOSE. Verbose should never be compiled into an application except during development. Debug logs are compiled in but stripped at runtime. Error, warning and info logs are always kept.</para> <para> <b>Tip:</b> A good convention is to declare a  <code>TAG</code> constant in your class:</para> <para> <pre>private static final String TAG = "MyActivity";</pre></para> <para>and use that in subsequent calls to the log methods. </para> <para> <b>Tip:</b> Don't forget that when you make a call like  <pre>Log.v(TAG, "index=" + i);</pre> that when you're building the string to pass into Log.d, the compiler uses a StringBuilder and at least three allocations occur: the StringBuilder itself, the buffer, and the String object. Realistically, there is also another buffer allocation and copy, and even more pressure on the gc. That means that if your log message is filtered out, you might be doing significant work and incurring significant overhead. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Log
		/// </java-name>
		[Dot42.DexImport("android/util/Log", AccessFlags = 49)]
		public sealed partial class Log
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Priority constant for the println method; use Log.v. </para>        
				/// </summary>
				/// <java-name>
				/// VERBOSE
				/// </java-name>
				[Dot42.DexImport("VERBOSE", "I", AccessFlags = 25)]
				public const int VERBOSE = 2;
				/// <summary>
				///  <para>Priority constant for the println method; use Log.d. </para>        
				/// </summary>
				/// <java-name>
				/// DEBUG
				/// </java-name>
				[Dot42.DexImport("DEBUG", "I", AccessFlags = 25)]
				public const int DEBUG = 3;
				/// <summary>
				///  <para>Priority constant for the println method; use Log.i. </para>        
				/// </summary>
				/// <java-name>
				/// INFO
				/// </java-name>
				[Dot42.DexImport("INFO", "I", AccessFlags = 25)]
				public const int INFO = 4;
				/// <summary>
				///  <para>Priority constant for the println method; use Log.w. </para>        
				/// </summary>
				/// <java-name>
				/// WARN
				/// </java-name>
				[Dot42.DexImport("WARN", "I", AccessFlags = 25)]
				public const int WARN = 5;
				/// <summary>
				///  <para>Priority constant for the println method; use Log.e. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = 6;
				/// <summary>
				///  <para>Priority constant for the println method. </para>        
				/// </summary>
				/// <java-name>
				/// ASSERT
				/// </java-name>
				[Dot42.DexImport("ASSERT", "I", AccessFlags = 25)]
				public const int ASSERT = 7;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Log() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a VERBOSE log message. </para>        
				/// </summary>
				/// <java-name>
				/// v
				/// </java-name>
				[Dot42.DexImport("v", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int V(string tag, string msg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a VERBOSE log message and log the exception. </para>        
				/// </summary>
				/// <java-name>
				/// v
				/// </java-name>
				[Dot42.DexImport("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int V(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a DEBUG log message. </para>        
				/// </summary>
				/// <java-name>
				/// d
				/// </java-name>
				[Dot42.DexImport("d", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int D(string tag, string msg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a DEBUG log message and log the exception. </para>        
				/// </summary>
				/// <java-name>
				/// d
				/// </java-name>
				[Dot42.DexImport("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int D(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send an INFO log message. </para>        
				/// </summary>
				/// <java-name>
				/// i
				/// </java-name>
				[Dot42.DexImport("i", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int I(string tag, string msg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a INFO log message and log the exception. </para>        
				/// </summary>
				/// <java-name>
				/// i
				/// </java-name>
				[Dot42.DexImport("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int I(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int W(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a WARN log message and log the exception. </para>        
				/// </summary>
				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int W(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Checks to see whether or not a log for the specified tag is loggable at the specified level.</para> <para>The default level of any tag is set to INFO. This means that any level above and including INFO will be logged. Before you make any calls to a logging method you should check to see if your tag should be logged. You can change the default level by setting a system property: 'setprop log.tag.&lt;YOUR_LOG_TAG&gt; &lt;LEVEL&gt;' Where level is either VERBOSE, DEBUG, INFO, WARN, ERROR, ASSERT, or SUPPRESS. SUPPRESS will turn off all logging for your tag. You can also create a local.prop file that with the following in it: 'log.tag.&lt;YOUR_LOG_TAG&gt;=&lt;LEVEL&gt;' and place that in /data/local.prop.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether or not that this is allowed to be logged. </para>
				/// </returns>
				/// <java-name>
				/// isLoggable
				/// </java-name>
				[Dot42.DexImport("isLoggable", "(Ljava/lang/String;I)Z", AccessFlags = 265)]
				public static bool IsLoggable(string tag, int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// w
				/// </java-name>
				[Dot42.DexImport("w", "(Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int W(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send an ERROR log message. </para>        
				/// </summary>
				/// <java-name>
				/// e
				/// </java-name>
				[Dot42.DexImport("e", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int E(string tag, string msg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Send a ERROR log message and log the exception. </para>        
				/// </summary>
				/// <java-name>
				/// e
				/// </java-name>
				[Dot42.DexImport("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int E(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int Wtf(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int Wtf(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>What a Terrible Failure: Report an exception that should never happen. Similar to wtf(String, Throwable), with a message as well. </para>        
				/// </summary>
				/// <java-name>
				/// wtf
				/// </java-name>
				[Dot42.DexImport("wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I", AccessFlags = 9)]
				public static int Wtf(string tag, string msg, global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Handy function to get a loggable stack trace from a Throwable </para>        
				/// </summary>
				/// <java-name>
				/// getStackTraceString
				/// </java-name>
				[Dot42.DexImport("getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetStackTraceString(global::System.Exception tr) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Low-level logging call. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of bytes written. </para>
				/// </returns>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(ILjava/lang/String;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int Println(int priority, string tag, string msg) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Implementation of a android.util.Printer that sends its output to the system log. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/LogPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/LogPrinter", AccessFlags = 33)]
		public partial class LogPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new Printer that sends to the log with the given priority and tag.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public LogPrinter(int priority, string tag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a line of text to the output. There is no need to terminate the given string with a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string x) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LogPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Helps answer common questions that come up when displaying a month in a 6 row calendar grid format.</para> <para>Not thread safe. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/MonthDisplayHelper
		/// </java-name>
		[Dot42.DexImport("android/util/MonthDisplayHelper", AccessFlags = 33)]
		public partial class MonthDisplayHelper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public MonthDisplayHelper(int year, int month, int weekStartDay) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public MonthDisplayHelper(int year, int month) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the digits of the month to display in one of the 6 rows of a calendar month display. </para>
				/// </returns>
				/// <java-name>
				/// getDigitsForRow
				/// </java-name>
				[Dot42.DexImport("getDigitsForRow", "(I)[I", AccessFlags = 1)]
				public virtual int[] GetDigitsForRow(int row) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The day at a particular row, column </para>
				/// </returns>
				/// <java-name>
				/// getDayAt
				/// </java-name>
				[Dot42.DexImport("getDayAt", "(II)I", AccessFlags = 1)]
				public virtual int GetDayAt(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Which row day is in. </para>
				/// </returns>
				/// <java-name>
				/// getRowOf
				/// </java-name>
				[Dot42.DexImport("getRowOf", "(I)I", AccessFlags = 1)]
				public virtual int GetRowOf(int day) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Which column day is in. </para>
				/// </returns>
				/// <java-name>
				/// getColumnOf
				/// </java-name>
				[Dot42.DexImport("getColumnOf", "(I)I", AccessFlags = 1)]
				public virtual int GetColumnOf(int day) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Decrement the month. </para>        
				/// </summary>
				/// <java-name>
				/// previousMonth
				/// </java-name>
				[Dot42.DexImport("previousMonth", "()V", AccessFlags = 1)]
				public virtual void PreviousMonth() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Increment the month. </para>        
				/// </summary>
				/// <java-name>
				/// nextMonth
				/// </java-name>
				[Dot42.DexImport("nextMonth", "()V", AccessFlags = 1)]
				public virtual void NextMonth() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the row and column fall within the month. </para>
				/// </returns>
				/// <java-name>
				/// isWithinCurrentMonth
				/// </java-name>
				[Dot42.DexImport("isWithinCurrentMonth", "(II)Z", AccessFlags = 1)]
				public virtual bool IsWithinCurrentMonth(int row, int column) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MonthDisplayHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public virtual int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public virtual int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWeekStartDay
				/// </java-name>
				public virtual int WeekStartDay
				{
						[Dot42.DexImport("getWeekStartDay", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The first day of the month using a constants such as java.util.Calendar#SUNDAY. </para>
				/// </returns>
				/// <java-name>
				/// getFirstDayOfMonth
				/// </java-name>
				public virtual int FirstDayOfMonth
				{
						[Dot42.DexImport("getFirstDayOfMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of days in the month. </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfDaysInMonth
				/// </java-name>
				public virtual int NumberOfDaysInMonth
				{
						[Dot42.DexImport("getNumberOfDaysInMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The offset from displaying everything starting on the very first box. For example, if the calendar is set to display the first day of the week as Sunday, and the month starts on a Wednesday, the offset is 3. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				public virtual int Offset
				{
						[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Container to ease passing around a tuple of two objects. This object provides a sensible implementation of equals(), returning true if equals() is true on each of the contained objects. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Pair
		/// </java-name>
		[Dot42.DexImport("android/util/Pair", AccessFlags = 33, Signature = "<F:Ljava/lang/Object;S:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Pair<F, S>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "Ljava/lang/Object;", AccessFlags = 17)]
				public readonly F First;
				/// <java-name>
				/// second
				/// </java-name>
				[Dot42.DexImport("second", "Ljava/lang/Object;", AccessFlags = 17)]
				public readonly S Second;
				/// <summary>
				///  <para>Constructor for a Pair.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TF;TS;)V")]
				public Pair(F first, S second) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks the two objects for equality by delegating to their respective Object#equals(Object) methods.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the underlying objects of the Pair are both considered equal </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Compute a hash code using the hash codes of the underlying objects</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a hashcode of the Pair </para>
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
				///  <para>Convenience method for creating an appropriately typed pair. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Pair that is templatized with the types of a and b </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroid/util/Pair;", AccessFlags = 9, Signature = "<A:Ljava/lang/Object;B:Ljava/lang/Object;>(TA;TB;)Landroid/util/Pair<TA;TB;>;")]
				public static global::Android.Util.Pair<A, B> Create<A, B>(A a, B b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.Pair<A, B>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Pair() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Commonly used regular expression patterns. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Patterns
		/// </java-name>
		[Dot42.DexImport("android/util/Patterns", AccessFlags = 33)]
		public partial class Patterns
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Regular expression to match all IANA top-level domains. List accurate as of 2011/07/18. List taken from:  This pattern is auto-generated by frameworks/ex/common/tools/make-iana-tld-pattern.py </para>        
				/// </summary>
				/// <java-name>
				/// TOP_LEVEL_DOMAIN_STR
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN_STR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TOP_LEVEL_DOMAIN_STR = @"((aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(biz|b[abdefghijmnorstvwyz])|(cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(edu|e[cegrstu])|f[ijkmor]|(gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(info|int|i[delmnoqrst])|(jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(name|net|n[acefgilopruz])|(org|om)|(pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(xn\-\-0zwm56d|xn\-\-11b5bs3a9aj6g|xn\-\-80akhbyknj4f|xn\-\-9t4b11yi5a|xn\-\-deba0ad|xn\-\-g6w251d|xn\-\-hgbk6aj7f53bba|xn\-\-hlcj6aya9esc7a|xn\-\-jxalpdlp|xn\-\-kgbechtv|xn\-\-zckzah)|y[etu]|z[amw])";
				/// <summary>
				///  <para>Regular expression pattern to match all IANA top-level domains. </para>        
				/// </summary>
				/// <java-name>
				/// TOP_LEVEL_DOMAIN
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern TOP_LEVEL_DOMAIN;
				/// <summary>
				///  <para>Regular expression to match all IANA top-level domains for WEB_URL. List accurate as of 2011/07/18. List taken from:  This pattern is auto-generated by frameworks/ex/common/tools/make-iana-tld-pattern.py </para>        
				/// </summary>
				/// <java-name>
				/// TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL
				/// </java-name>
				[Dot42.DexImport("TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL = @"(?:(?:aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(?:biz|b[abdefghijmnorstvwyz])|(?:cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(?:edu|e[cegrstu])|f[ijkmor]|(?:gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(?:info|int|i[delmnoqrst])|(?:jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(?:mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(?:name|net|n[acefgilopruz])|(?:org|om)|(?:pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(?:tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(?:xn\-\-0zwm56d|xn\-\-11b5bs3a9aj6g|xn\-\-80akhbyknj4f|xn\-\-9t4b11yi5a|xn\-\-deba0ad|xn\-\-g6w251d|xn\-\-hgbk6aj7f53bba|xn\-\-hlcj6aya9esc7a|xn\-\-jxalpdlp|xn\-\-kgbechtv|xn\-\-zckzah)|y[etu]|z[amw]))";
				/// <summary>
				///  <para>Good characters for Internationalized Resource Identifiers (IRI). This comprises most common used Unicode characters allowed in IRI as detailed in RFC 3987. Specifically, those two byte Unicode characters are not included. </para>        
				/// </summary>
				/// <java-name>
				/// GOOD_IRI_CHAR
				/// </java-name>
				[Dot42.DexImport("GOOD_IRI_CHAR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GOOD_IRI_CHAR = "a-zA-Z0-9 -퟿豈-﷏ﷰ-￯";
				/// <summary>
				///  <para>Regular expression pattern to match most part of RFC 3987 Internationalized URLs, aka IRIs. Commonly used Unicode characters are added. </para>        
				/// </summary>
				/// <java-name>
				/// WEB_URL
				/// </java-name>
				[Dot42.DexImport("WEB_URL", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern WEB_URL;
				/// <java-name>
				/// IP_ADDRESS
				/// </java-name>
				[Dot42.DexImport("IP_ADDRESS", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern IP_ADDRESS;
				/// <java-name>
				/// DOMAIN_NAME
				/// </java-name>
				[Dot42.DexImport("DOMAIN_NAME", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern DOMAIN_NAME;
				/// <java-name>
				/// EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("EMAIL_ADDRESS", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern EMAIL_ADDRESS;
				/// <summary>
				///  <para>This pattern is intended for searching for things that look like they might be phone numbers in arbitrary text, not for validating whether something is in fact a phone number. It will miss many things that are legitimate phone numbers.</para> <para>The pattern matches the following:  <ul> <li> <para>Optionally, a + sign followed immediately by one or more digits. Spaces, dots, or dashes may follow. </para></li> <li> <para>Optionally, sets of digits in parentheses, separated by spaces, dots, or dashes. </para></li> <li> <para>A string starting and ending with a digit, containing digits, spaces, dots, and/or dashes. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// PHONE
				/// </java-name>
				[Dot42.DexImport("PHONE", "Ljava/util/regex/Pattern;", AccessFlags = 25)]
				public static readonly global::Java.Util.Regex.Pattern PHONE;
				/// <summary>
				///  <para>Do not create this static utility class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Patterns() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to take all of the non-null matching groups in a regex Matcher and return them as a concatenated string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String comprising all of the non-null matched groups concatenated together </para>
				/// </returns>
				/// <java-name>
				/// concatGroups
				/// </java-name>
				[Dot42.DexImport("concatGroups", "(Ljava/util/regex/Matcher;)Ljava/lang/String;", AccessFlags = 25)]
				public static string ConcatGroups(global::Java.Util.Regex.Matcher matcher) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Convenience method to return only the digits and plus signs in the matching string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A String comprising all of the digits and plus in the match </para>
				/// </returns>
				/// <java-name>
				/// digitsAndPlusOnly
				/// </java-name>
				[Dot42.DexImport("digitsAndPlusOnly", "(Ljava/util/regex/Matcher;)Ljava/lang/String;", AccessFlags = 25)]
				public static string DigitsAndPlusOnly(global::Java.Util.Regex.Matcher matcher) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>Implementation of a android.util.Printer that sends its output to a java.io.PrintStream. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/PrintStreamPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/PrintStreamPrinter", AccessFlags = 33)]
		public partial class PrintStreamPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new Printer that sends to a PrintWriter object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public PrintStreamPrinter(global::Java.IO.PrintStream pw) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a line of text to the output. There is no need to terminate the given string with a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string x) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintStreamPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Implementation of a android.util.Printer that sends its output to a java.io.PrintWriter. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/PrintWriterPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/PrintWriterPrinter", AccessFlags = 33)]
		public partial class PrintWriterPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new Printer that sends to a PrintWriter object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public PrintWriterPrinter(global::Java.IO.PrintWriter pw) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a line of text to the output. There is no need to terminate the given string with a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string x) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintWriterPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>SparseArrays map integers to Objects. Unlike a normal array of Objects, there can be gaps in the indices. It is intended to be more memory efficient than using a HashMap to map Integers to Objects, both because it avoids auto-boxing keys and its data structure doesn't rely on an extra entry object for each mapping.</para> <para>Note that this container keeps its mappings in an array data structure, using a binary search to find keys. The implementation is not intended to be appropriate for data structures that may contain large numbers of items. It is generally slower than a traditional HashMap, since lookups require a binary search and adds and removes require inserting and deleting entries in the array. For containers holding up to hundreds of items, the performance difference is not significant, less than 50%.</para> <para>To help with performance, the container includes an optimization when removing keys: instead of compacting its array immediately, it leaves the removed entry marked as deleted. The entry can then be re-used for the same key, or compacted later in a single garbage collection step of all removed entries. This garbage collection will need to be performed at any time the array needs to be grown or the the map size or entry values are retrieved.</para> <para>It is possible to iterate over the items in this container using keyAt(int) and valueAt(int). Iterating over the keys using  <code>keyAt(int)</code> with ascending values of the index will return the keys in ascending order, or the values corresponding to the keys in ascending order in the case of  <code>valueAt(int) <code>.</code></code></para> <para> <code> <code> </code></code></para>    
		/// </summary>
		/// <java-name>
		/// android/util/SparseArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseArray", AccessFlags = 33, Signature = "<E:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class SparseArray<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new SparseArray containing no mappings. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseArray() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SparseArray containing no mappings that will not require any additional memory allocation to store the specified number of mappings. If you supply an initial capacity of 0, the sparse array will be initialized with a light-weight representation not requiring any additional array allocations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseArray(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the Object mapped from the specified key, or  <code>null</code> if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E Get(int key) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Gets the Object mapped from the specified key, or the specified Object if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(ILjava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(ITE;)TE;")]
				public virtual E Get(int key, E valueIfKeyNotFound) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Removes the mapping from the specified key, if there was any. </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Alias for delete(int). </para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(I)V", AccessFlags = 1)]
				public virtual void Remove(int key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a mapping from the specified key to the specified value, replacing the previous mapping from the specified key if there was one. </para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Put(int key, E value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of key-value mappings that this SparseArray currently stores. </para>        
				/// </summary>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the key from the  <code>index</code>th key-value mapping that this SparseArray stores.</para> <para>The keys corresponding to indices in ascending order are guaranteed to be in ascending order, e.g.,  <code>keyAt(0)</code> will return the smallest key and  <code>keyAt(size()-1)</code> will return the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the value from the  <code>index</code>th key-value mapping that this SparseArray stores.</para> <para>The values corresponding to indices in ascending order are guaranteed to be associated with keys in ascending order, e.g.,  <code>valueAt(0)</code> will return the value associated with the smallest key and  <code>valueAt(size()-1)</code> will return the value associated with the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TE;")]
				public virtual E ValueAt(int index) /* MethodBuilder.Create */ 
				{
						return default(E);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, sets a new value for the  <code>index</code>th key-value mapping that this SparseArray stores. </para>        
				/// </summary>
				/// <java-name>
				/// setValueAt
				/// </java-name>
				[Dot42.DexImport("setValueAt", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void SetValueAt(int index, E value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the index for which keyAt would return the specified key, or a negative number if the specified key is not mapped. </para>        
				/// </summary>
				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an index for which valueAt would return the specified key, or a negative number if no keys map to the specified value. </para> <para>Beware that this is a linear search, unlike lookups by key, and that multiple keys can map to the same value and this will find only one of them. </para> <para>Note also that unlike most collections' <c>indexOf </c> methods, this method compares values using <c>== </c> rather than <c>equals </c> . </para>        
				/// </summary>
				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TE;)I")]
				public virtual int IndexOfValue(E value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all key-value mappings from this SparseArray. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Puts a key/value pair into the array, optimizing for the case where the key is greater than all existing keys in the array. </para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(ILjava/lang/Object;)V", AccessFlags = 1, Signature = "(ITE;)V")]
				public virtual void Append(int key, E value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>SparseBooleanArrays map integers to booleans. Unlike a normal array of booleans there can be gaps in the indices. It is intended to be more memory efficient than using a HashMap to map Integers to Booleans, both because it avoids auto-boxing keys and values and its data structure doesn't rely on an extra entry object for each mapping.</para> <para>Note that this container keeps its mappings in an array data structure, using a binary search to find keys. The implementation is not intended to be appropriate for data structures that may contain large numbers of items. It is generally slower than a traditional HashMap, since lookups require a binary search and adds and removes require inserting and deleting entries in the array. For containers holding up to hundreds of items, the performance difference is not significant, less than 50%.</para> <para>It is possible to iterate over the items in this container using keyAt(int) and valueAt(int). Iterating over the keys using  <code>keyAt(int)</code> with ascending values of the index will return the keys in ascending order, or the values corresponding to the keys in ascending order in the case of  <code>valueAt(int) <code>.</code></code></para> <para> <code> <code> </code></code></para>    
		/// </summary>
		/// <java-name>
		/// android/util/SparseBooleanArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseBooleanArray", AccessFlags = 33)]
		public partial class SparseBooleanArray
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new SparseBooleanArray containing no mappings. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseBooleanArray() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SparseBooleanArray containing no mappings that will not require any additional memory allocation to store the specified number of mappings. If you supply an initial capacity of 0, the sparse array will be initialized with a light-weight representation not requiring any additional array allocations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseBooleanArray(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the boolean mapped from the specified key, or  <code>false</code> if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Z", AccessFlags = 1)]
				public virtual bool Get(int key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the boolean mapped from the specified key, or the specified value if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(IZ)Z", AccessFlags = 1)]
				public virtual bool Get(int key, bool valueIfKeyNotFound) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes the mapping from the specified key, if there was any. </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a mapping from the specified key to the specified value, replacing the previous mapping from the specified key if there was one. </para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IZ)V", AccessFlags = 1)]
				public virtual void Put(int key, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of key-value mappings that this SparseBooleanArray currently stores. </para>        
				/// </summary>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the key from the  <code>index</code>th key-value mapping that this SparseBooleanArray stores.</para> <para>The keys corresponding to indices in ascending order are guaranteed to be in ascending order, e.g.,  <code>keyAt(0)</code> will return the smallest key and  <code>keyAt(size()-1)</code> will return the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the value from the  <code>index</code>th key-value mapping that this SparseBooleanArray stores.</para> <para>The values corresponding to indices in ascending order are guaranteed to be associated with keys in ascending order, e.g.,  <code>valueAt(0)</code> will return the value associated with the smallest key and  <code>valueAt(size()-1)</code> will return the value associated with the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)Z", AccessFlags = 1)]
				public virtual bool ValueAt(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the index for which keyAt would return the specified key, or a negative number if the specified key is not mapped. </para>        
				/// </summary>
				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an index for which valueAt would return the specified key, or a negative number if no keys map to the specified value. Beware that this is a linear search, unlike lookups by key, and that multiple keys can map to the same value and this will find only one of them. </para>        
				/// </summary>
				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(Z)I", AccessFlags = 1)]
				public virtual int IndexOfValue(bool value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all key-value mappings from this SparseBooleanArray. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Puts a key/value pair into the array, optimizing for the case where the key is greater than all existing keys in the array. </para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(IZ)V", AccessFlags = 1)]
				public virtual void Append(int key, bool value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>SparseIntArrays map integers to integers. Unlike a normal array of integers, there can be gaps in the indices. It is intended to be more memory efficient than using a HashMap to map Integers to Integers, both because it avoids auto-boxing keys and values and its data structure doesn't rely on an extra entry object for each mapping.</para> <para>Note that this container keeps its mappings in an array data structure, using a binary search to find keys. The implementation is not intended to be appropriate for data structures that may contain large numbers of items. It is generally slower than a traditional HashMap, since lookups require a binary search and adds and removes require inserting and deleting entries in the array. For containers holding up to hundreds of items, the performance difference is not significant, less than 50%.</para> <para>It is possible to iterate over the items in this container using keyAt(int) and valueAt(int). Iterating over the keys using  <code>keyAt(int)</code> with ascending values of the index will return the keys in ascending order, or the values corresponding to the keys in ascending order in the case of  <code>valueAt(int) <code>.</code></code></para> <para> <code> <code> </code></code></para>    
		/// </summary>
		/// <java-name>
		/// android/util/SparseIntArray
		/// </java-name>
		[Dot42.DexImport("android/util/SparseIntArray", AccessFlags = 33)]
		public partial class SparseIntArray
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new SparseIntArray containing no mappings. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SparseIntArray() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SparseIntArray containing no mappings that will not require any additional memory allocation to store the specified number of mappings. If you supply an initial capacity of 0, the sparse array will be initialized with a light-weight representation not requiring any additional array allocations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SparseIntArray(int initialCapacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the int mapped from the specified key, or  <code>0</code> if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1)]
				public virtual int Get(int key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the int mapped from the specified key, or the specified value if no such mapping has been made. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)I", AccessFlags = 1)]
				public virtual int Get(int key, int valueIfKeyNotFound) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes the mapping from the specified key, if there was any. </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(I)V", AccessFlags = 1)]
				public virtual void Delete(int key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the mapping at the given index. </para>        
				/// </summary>
				/// <java-name>
				/// removeAt
				/// </java-name>
				[Dot42.DexImport("removeAt", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAt(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a mapping from the specified key to the specified value, replacing the previous mapping from the specified key if there was one. </para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(II)V", AccessFlags = 1)]
				public virtual void Put(int key, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of key-value mappings that this SparseIntArray currently stores. </para>        
				/// </summary>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the key from the  <code>index</code>th key-value mapping that this SparseIntArray stores.</para> <para>The keys corresponding to indices in ascending order are guaranteed to be in ascending order, e.g.,  <code>keyAt(0)</code> will return the smallest key and  <code>keyAt(size()-1)</code> will return the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// keyAt
				/// </java-name>
				[Dot42.DexImport("keyAt", "(I)I", AccessFlags = 1)]
				public virtual int KeyAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given an index in the range  <code>0...size()-1</code>, returns the value from the  <code>index</code>th key-value mapping that this SparseIntArray stores.</para> <para>The values corresponding to indices in ascending order are guaranteed to be associated with keys in ascending order, e.g.,  <code>valueAt(0)</code> will return the value associated with the smallest key and  <code>valueAt(size()-1)</code> will return the value associated with the largest key.</para>        
				/// </summary>
				/// <java-name>
				/// valueAt
				/// </java-name>
				[Dot42.DexImport("valueAt", "(I)I", AccessFlags = 1)]
				public virtual int ValueAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the index for which keyAt would return the specified key, or a negative number if the specified key is not mapped. </para>        
				/// </summary>
				/// <java-name>
				/// indexOfKey
				/// </java-name>
				[Dot42.DexImport("indexOfKey", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfKey(int key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns an index for which valueAt would return the specified key, or a negative number if no keys map to the specified value. Beware that this is a linear search, unlike lookups by key, and that multiple keys can map to the same value and this will find only one of them. </para>        
				/// </summary>
				/// <java-name>
				/// indexOfValue
				/// </java-name>
				[Dot42.DexImport("indexOfValue", "(I)I", AccessFlags = 1)]
				public virtual int IndexOfValue(int value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all key-value mappings from this SparseIntArray. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Puts a key/value pair into the array, optimizing for the case where the key is greater than all existing keys in the array. </para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(II)V", AccessFlags = 1)]
				public virtual void Append(int key, int value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>State sets are arrays of positive ints where each element represents the state of a android.view.View (e.g. focused, selected, visible, etc.). A android.view.View may be in one or more of those states.</para> <para>A state spec is an array of signed ints where each element represents a required (if positive) or an undesired (if negative) android.view.View state.</para> <para>Utils dealing with state sets.</para> <para>In theory we could encapsulate the state set and state spec arrays and not have static methods here but there is some concern about performance since these methods are called during view drawing. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/StateSet
		/// </java-name>
		[Dot42.DexImport("android/util/StateSet", AccessFlags = 33)]
		public partial class StateSet
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// WILD_CARD
				/// </java-name>
				[Dot42.DexImport("WILD_CARD", "[I", AccessFlags = 25)]
				public static readonly int[] WILD_CARD;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StateSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return whether the stateSetOrSpec is matched by all StateSets.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// isWildCard
				/// </java-name>
				[Dot42.DexImport("isWildCard", "([I)Z", AccessFlags = 9)]
				public static bool IsWildCard(int[] stateSetOrSpec) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stateSetMatches
				/// </java-name>
				[Dot42.DexImport("stateSetMatches", "([I[I)Z", AccessFlags = 9)]
				public static bool StateSetMatches(int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stateSetMatches
				/// </java-name>
				[Dot42.DexImport("stateSetMatches", "([II)Z", AccessFlags = 9)]
				public static bool StateSetMatches(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// trimStateSet
				/// </java-name>
				[Dot42.DexImport("trimStateSet", "([II)[I", AccessFlags = 9)]
				public static int[] TrimStateSet(int[] states, int newSize) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "([I)Ljava/lang/String;", AccessFlags = 9)]
				public static string Dump(int[] states) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>Implementation of a android.util.Printer that sends its output to a StringBuilder. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/StringBuilderPrinter
		/// </java-name>
		[Dot42.DexImport("android/util/StringBuilderPrinter", AccessFlags = 33)]
		public partial class StringBuilderPrinter : global::Android.Util.IPrinter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new Printer that sends to a StringBuilder object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuilder;)V", AccessFlags = 1)]
				public StringBuilderPrinter(global::System.Text.StringBuilder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write a line of text to the output. There is no need to terminate the given string with a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string x) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringBuilderPrinter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/util/TimeFormatException
		/// </java-name>
		[Dot42.DexImport("android/util/TimeFormatException", AccessFlags = 33)]
		public partial class TimeFormatException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TimeFormatException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A class containing utility methods related to time zones. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/TimeUtils
		/// </java-name>
		[Dot42.DexImport("android/util/TimeUtils", AccessFlags = 33)]
		public partial class TimeUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tries to return a time zone that would have had the specified offset and DST value at the specified moment in the specified country. Returns null if no suitable zone could be found. </para>        
				/// </summary>
				/// <java-name>
				/// getTimeZone
				/// </java-name>
				[Dot42.DexImport("getTimeZone", "(IZJLjava/lang/String;)Ljava/util/TimeZone;", AccessFlags = 9)]
				public static global::Java.Util.TimeZone GetTimeZone(int offset, bool dst, long when, string country) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.TimeZone);
				}

				/// <summary>
				///  <para>Returns a String indicating the version of the time zone database currently in use. The format of the string is dependent on the underlying time zone database implementation, but will typically contain the year in which the database was updated plus a letter from a to z indicating changes made within that year.</para> <para>Time zone database updates should be expected to occur periodically due to political and legal changes that cannot be anticipated in advance. Therefore, when computing the UTC time for a future event, applications should be aware that the results may differ following a time zone database update. This method allows applications to detect that a database change has occurred, and to recalculate any cached times accordingly.</para> <para>The time zone database may be assumed to change only when the device runtime is restarted. Therefore, it is not necessary to re-query the database version during the lifetime of an activity. </para>        
				/// </summary>
				/// <java-name>
				/// getTimeZoneDatabaseVersion
				/// </java-name>
				public static string TimeZoneDatabaseVersion
				{
						[Dot42.DexImport("getTimeZoneDatabaseVersion", "()Ljava/lang/String;", AccessFlags = 9)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A utility class to help log timings splits throughout a method call. Typical usage is:</para> <para> <pre>
		///     TimingLogger timings = new TimingLogger(TAG, "methodA");
		///     // ... do some work A ...
		///     timings.addSplit("work A");
		///     // ... do some work B ...
		///     timings.addSplit("work B");
		///     // ... do some work C ...
		///     timings.addSplit("work C");
		///     timings.dumpToLog();
		/// </pre></para> <para>The dumpToLog call would add the following to the log:</para> <para> <pre>
		///     D/TAG     ( 3459): methodA: begin
		///     D/TAG     ( 3459): methodA:      9 ms, work A
		///     D/TAG     ( 3459): methodA:      1 ms, work B
		///     D/TAG     ( 3459): methodA:      6 ms, work C
		///     D/TAG     ( 3459): methodA: end, 16 ms
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/util/TimingLogger
		/// </java-name>
		[Dot42.DexImport("android/util/TimingLogger", AccessFlags = 33)]
		public partial class TimingLogger
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create and initialize a TimingLogger object that will log using the specific tag. If the Log.isLoggable is not enabled to at least the Log.VERBOSE level for that tag at creation time then the addSplit and dumpToLog call will do nothing. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public TimingLogger(string tag, string label) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear and initialize a TimingLogger object that will log using the specific tag. If the Log.isLoggable is not enabled to at least the Log.VERBOSE level for that tag at creation time then the addSplit and dumpToLog call will do nothing. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Reset(string tag, string label) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear and initialize a TimingLogger object that will log using the tag and label that was specified previously, either via the constructor or a call to reset(tag, label). If the Log.isLoggable is not enabled to at least the Log.VERBOSE level for that tag at creation time then the addSplit and dumpToLog call will do nothing. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a split for the current time, labeled with splitLabel. If Log.isLoggable was not enabled to at least the Log.VERBOSE for the specified tag at construction or reset() time then this call does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// addSplit
				/// </java-name>
				[Dot42.DexImport("addSplit", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddSplit(string splitLabel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dumps the timings to the log using Log.d(). If Log.isLoggable was not enabled to at least the Log.VERBOSE for the specified tag at construction or reset() time then this call does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// dumpToLog
				/// </java-name>
				[Dot42.DexImport("dumpToLog", "()V", AccessFlags = 1)]
				public virtual void DumpToLog() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TimingLogger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Container for a dynamically typed data value. Primarily used with android.content.res.Resources for holding resource values. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/TypedValue
		/// </java-name>
		[Dot42.DexImport("android/util/TypedValue", AccessFlags = 33)]
		public partial class TypedValue
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The value contains no data. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("TYPE_NULL", "I", AccessFlags = 25)]
				public const int TYPE_NULL = 0;
				/// <summary>
				///  <para>The  <b>data</b> field holds a resource identifier. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_REFERENCE
				/// </java-name>
				[Dot42.DexImport("TYPE_REFERENCE", "I", AccessFlags = 25)]
				public const int TYPE_REFERENCE = 1;
				/// <summary>
				///  <para>The  <b>data</b> field holds an attribute resource identifier (referencing an attribute in the current theme style, not a resource entry). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ATTRIBUTE
				/// </java-name>
				[Dot42.DexImport("TYPE_ATTRIBUTE", "I", AccessFlags = 25)]
				public const int TYPE_ATTRIBUTE = 2;
				/// <summary>
				///  <para>The  <b>string</b> field holds string data. In addition, if  <b>data</b> is non-zero then it is the string block index of the string and  <b>assetCookie</b> is the set of assets the string came from. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_STRING
				/// </java-name>
				[Dot42.DexImport("TYPE_STRING", "I", AccessFlags = 25)]
				public const int TYPE_STRING = 3;
				/// <summary>
				///  <para>The  <b>data</b> field holds an IEEE 754 floating point number. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_FLOAT
				/// </java-name>
				[Dot42.DexImport("TYPE_FLOAT", "I", AccessFlags = 25)]
				public const int TYPE_FLOAT = 4;
				/// <summary>
				///  <para>The  <b>data</b> field holds a complex number encoding a dimension value. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_DIMENSION
				/// </java-name>
				[Dot42.DexImport("TYPE_DIMENSION", "I", AccessFlags = 25)]
				public const int TYPE_DIMENSION = 5;
				/// <summary>
				///  <para>The  <b>data</b> field holds a complex number encoding a fraction of a container. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_FRACTION
				/// </java-name>
				[Dot42.DexImport("TYPE_FRACTION", "I", AccessFlags = 25)]
				public const int TYPE_FRACTION = 6;
				/// <summary>
				///  <para>Identifies the start of plain integer values. Any type value from this to TYPE_LAST_INT means the  <b>data</b> field holds a generic integer value. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_FIRST_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_FIRST_INT", "I", AccessFlags = 25)]
				public const int TYPE_FIRST_INT = 16;
				/// <summary>
				///  <para>The  <b>data</b> field holds a number that was originally specified in decimal. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_DEC
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_DEC", "I", AccessFlags = 25)]
				public const int TYPE_INT_DEC = 16;
				/// <summary>
				///  <para>The  <b>data</b> field holds a number that was originally specified in hexadecimal (0xn). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_HEX
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_HEX", "I", AccessFlags = 25)]
				public const int TYPE_INT_HEX = 17;
				/// <summary>
				///  <para>The  <b>data</b> field holds 0 or 1 that was originally specified as "false" or "true". </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_BOOLEAN", "I", AccessFlags = 25)]
				public const int TYPE_INT_BOOLEAN = 18;
				/// <summary>
				///  <para>Identifies the start of integer values that were specified as color constants (starting with '#'). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_FIRST_COLOR_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_FIRST_COLOR_INT", "I", AccessFlags = 25)]
				public const int TYPE_FIRST_COLOR_INT = 28;
				/// <summary>
				///  <para>The  <b>data</b> field holds a color that was originally specified as #aarrggbb. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_COLOR_ARGB8
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_ARGB8", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_ARGB8 = 28;
				/// <summary>
				///  <para>The  <b>data</b> field holds a color that was originally specified as #rrggbb. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_COLOR_RGB8
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_RGB8", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_RGB8 = 29;
				/// <summary>
				///  <para>The  <b>data</b> field holds a color that was originally specified as #argb. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_COLOR_ARGB4
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_ARGB4", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_ARGB4 = 30;
				/// <summary>
				///  <para>The  <b>data</b> field holds a color that was originally specified as #rgb. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INT_COLOR_RGB4
				/// </java-name>
				[Dot42.DexImport("TYPE_INT_COLOR_RGB4", "I", AccessFlags = 25)]
				public const int TYPE_INT_COLOR_RGB4 = 31;
				/// <summary>
				///  <para>Identifies the end of integer values that were specified as color constants. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_LAST_COLOR_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_LAST_COLOR_INT", "I", AccessFlags = 25)]
				public const int TYPE_LAST_COLOR_INT = 31;
				/// <summary>
				///  <para>Identifies the end of plain integer values. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_LAST_INT
				/// </java-name>
				[Dot42.DexImport("TYPE_LAST_INT", "I", AccessFlags = 25)]
				public const int TYPE_LAST_INT = 31;
				/// <summary>
				///  <para>Complex data: bit location of unit information. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_SHIFT = 0;
				/// <summary>
				///  <para>Complex data: mask to extract unit information (after shifting by COMPLEX_UNIT_SHIFT). This gives us 16 possible types, as defined below. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_MASK = 15;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is raw pixels. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_PX
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_PX", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_PX = 0;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is Device Independent Pixels. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_DIP
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_DIP", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_DIP = 1;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is a scaled pixel. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_SP
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_SP", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_SP = 2;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is in points. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_PT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_PT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_PT = 3;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is in inches. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_IN
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_IN", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_IN = 4;
				/// <summary>
				///  <para>TYPE_DIMENSION complex unit: Value is in millimeters. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_MM
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_MM", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_MM = 5;
				/// <summary>
				///  <para>TYPE_FRACTION complex unit: A basic fraction of the overall size. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_FRACTION
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_FRACTION", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_FRACTION = 0;
				/// <summary>
				///  <para>TYPE_FRACTION complex unit: A fraction of the parent size. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_UNIT_FRACTION_PARENT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_UNIT_FRACTION_PARENT", "I", AccessFlags = 25)]
				public const int COMPLEX_UNIT_FRACTION_PARENT = 1;
				/// <summary>
				///  <para>Complex data: where the radix information is, telling where the decimal place appears in the mantissa. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_SHIFT = 4;
				/// <summary>
				///  <para>Complex data: mask to extract radix information (after shifting by COMPLEX_RADIX_SHIFT). This give us 4 possible fixed point representations as defined below. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_MASK = 3;
				/// <summary>
				///  <para>Complex data: the mantissa is an integral number  i.e., 0xnnnnnn.0 </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_23p0
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_23p0", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_23p0 = 0;
				/// <summary>
				///  <para>Complex data: the mantissa magnitude is 16 bits  i.e, 0xnnnn.nn </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_16p7
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_16p7", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_16p7 = 1;
				/// <summary>
				///  <para>Complex data: the mantissa magnitude is 8 bits  i.e, 0xnn.nnnn </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_8p15
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_8p15", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_8p15 = 2;
				/// <summary>
				///  <para>Complex data: the mantissa magnitude is 0 bits  i.e, 0x0.nnnnnn </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_RADIX_0p23
				/// </java-name>
				[Dot42.DexImport("COMPLEX_RADIX_0p23", "I", AccessFlags = 25)]
				public const int COMPLEX_RADIX_0p23 = 3;
				/// <summary>
				///  <para>Complex data: bit location of mantissa information. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_MANTISSA_SHIFT
				/// </java-name>
				[Dot42.DexImport("COMPLEX_MANTISSA_SHIFT", "I", AccessFlags = 25)]
				public const int COMPLEX_MANTISSA_SHIFT = 8;
				/// <summary>
				///  <para>Complex data: mask to extract mantissa information (after shifting by COMPLEX_MANTISSA_SHIFT). This gives us 23 bits of precision; the top bit is the sign. </para>        
				/// </summary>
				/// <java-name>
				/// COMPLEX_MANTISSA_MASK
				/// </java-name>
				[Dot42.DexImport("COMPLEX_MANTISSA_MASK", "I", AccessFlags = 25)]
				public const int COMPLEX_MANTISSA_MASK = 16777215;
				/// <summary>
				///  <para>If density is equal to this value, then the density should be treated as the system's default density value: DisplayMetrics#DENSITY_DEFAULT. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("DENSITY_DEFAULT", "I", AccessFlags = 25)]
				public const int DENSITY_DEFAULT = 0;
				/// <summary>
				///  <para>If density is equal to this value, then there is no density associated with the resource and it should not be scaled. </para>        
				/// </summary>
				/// <java-name>
				/// DENSITY_NONE
				/// </java-name>
				[Dot42.DexImport("DENSITY_NONE", "I", AccessFlags = 25)]
				public const int DENSITY_NONE = 65535;
				/// <summary>
				///  <para>The type held by this value, as defined by the constants here. This tells you how to interpret the other fields in the object. </para>        
				/// </summary>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <summary>
				///  <para>If the value holds a string, this is it. </para>        
				/// </summary>
				/// <java-name>
				/// string
				/// </java-name>
				[Dot42.DexImport("string", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence String;
				/// <summary>
				///  <para>Basic data in the value, interpreted according to type </para>        
				/// </summary>
				/// <java-name>
				/// data
				/// </java-name>
				[Dot42.DexImport("data", "I", AccessFlags = 1)]
				public int Data;
				/// <summary>
				///  <para>Additional information about where the value came from; only set for strings. </para>        
				/// </summary>
				/// <java-name>
				/// assetCookie
				/// </java-name>
				[Dot42.DexImport("assetCookie", "I", AccessFlags = 1)]
				public int AssetCookie;
				/// <summary>
				///  <para>If Value came from a resource, this holds the corresponding resource id. </para>        
				/// </summary>
				/// <java-name>
				/// resourceId
				/// </java-name>
				[Dot42.DexImport("resourceId", "I", AccessFlags = 1)]
				public int ResourceId;
				/// <summary>
				///  <para>If Value came from a resource, these are the configurations for which its contents can change. </para>        
				/// </summary>
				/// <java-name>
				/// changingConfigurations
				/// </java-name>
				[Dot42.DexImport("changingConfigurations", "I", AccessFlags = 1)]
				public int ChangingConfigurations;
				/// <summary>
				///  <para>If the Value came from a resource, this holds the corresponding pixel density. </para>        
				/// </summary>
				/// <java-name>
				/// density
				/// </java-name>
				[Dot42.DexImport("density", "I", AccessFlags = 1)]
				public int Density;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TypedValue() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the base value from a complex data integer. This uses the COMPLEX_MANTISSA_MASK and COMPLEX_RADIX_MASK fields of the data to compute a floating point representation of the number they describe. The units are ignored.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A floating point value corresponding to the complex data. </para>
				/// </returns>
				/// <java-name>
				/// complexToFloat
				/// </java-name>
				[Dot42.DexImport("complexToFloat", "(I)F", AccessFlags = 9)]
				public static float ComplexToFloat(int complex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Converts a complex data value holding a dimension to its final floating point value. The given  <b>data</b> must be structured as a TYPE_DIMENSION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The complex floating point value multiplied by the appropriate metrics depending on its unit. </para>
				/// </returns>
				/// <java-name>
				/// complexToDimension
				/// </java-name>
				[Dot42.DexImport("complexToDimension", "(ILandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ComplexToDimension(int data, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Converts a complex data value holding a dimension to its final value as an integer pixel offset. This is the same as complexToDimension, except the raw floating point value is truncated to an integer (pixel) value. The given  <b>data</b> must be structured as a TYPE_DIMENSION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of pixels specified by the data and its desired multiplier and units. </para>
				/// </returns>
				/// <java-name>
				/// complexToDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("complexToDimensionPixelOffset", "(ILandroid/util/DisplayMetrics;)I", AccessFlags = 9)]
				public static int ComplexToDimensionPixelOffset(int data, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Converts a complex data value holding a dimension to its final value as an integer pixel size. This is the same as complexToDimension, except the raw floating point value is converted to an integer (pixel) value for use as a size. A size conversion involves rounding the base value, and ensuring that a non-zero base value is at least one pixel in size. The given  <b>data</b> must be structured as a TYPE_DIMENSION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of pixels specified by the data and its desired multiplier and units. </para>
				/// </returns>
				/// <java-name>
				/// complexToDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("complexToDimensionPixelSize", "(ILandroid/util/DisplayMetrics;)I", AccessFlags = 9)]
				public static int ComplexToDimensionPixelSize(int data, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// complexToDimensionNoisy
				/// </java-name>
				[Dot42.DexImport("complexToDimensionNoisy", "(ILandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ComplexToDimensionNoisy(int data, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Converts an unpacked complex data value holding a dimension to its final floating point value. The two parameters  <b>unit</b> and  <b>value</b> are as in TYPE_DIMENSION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The complex floating point value multiplied by the appropriate metrics depending on its unit. </para>
				/// </returns>
				/// <java-name>
				/// applyDimension
				/// </java-name>
				[Dot42.DexImport("applyDimension", "(IFLandroid/util/DisplayMetrics;)F", AccessFlags = 9)]
				public static float ApplyDimension(int unit, float value, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return the data for this value as a dimension. Only use for values whose type is TYPE_DIMENSION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The complex floating point value multiplied by the appropriate metrics depending on its unit. </para>
				/// </returns>
				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(Landroid/util/DisplayMetrics;)F", AccessFlags = 1)]
				public virtual float GetDimension(global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Converts a complex data value holding a fraction to its final floating point value. The given  <b>data</b> must be structured as a TYPE_FRACTION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The complex floating point value multiplied by the appropriate base value depending on its unit. </para>
				/// </returns>
				/// <java-name>
				/// complexToFraction
				/// </java-name>
				[Dot42.DexImport("complexToFraction", "(IFF)F", AccessFlags = 9)]
				public static float ComplexToFraction(int data, float @base, float pbase) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return the data for this value as a fraction. Only use for values whose type is TYPE_FRACTION.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The complex floating point value multiplied by the appropriate base value depending on its unit. </para>
				/// </returns>
				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "(FF)F", AccessFlags = 1)]
				public virtual float GetFraction(float @base, float pbase) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Regardless of the actual type of the value, try to convert it to a string value. For example, a color type will be converted to a string of the form #aarrggbb.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>CharSequence The coerced string value. If the value is null or the type is not known, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// coerceToString
				/// </java-name>
				[Dot42.DexImport("coerceToString", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence CoerceToString() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Perform type conversion as per coerceToString() on an explicitly supplied type and data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The coerced string value. If the value is null or the type is not known, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// coerceToString
				/// </java-name>
				[Dot42.DexImport("coerceToString", "(II)Ljava/lang/String;", AccessFlags = 25)]
				public static string CoerceToString(int type, int data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setTo
				/// </java-name>
				[Dot42.DexImport("setTo", "(Landroid/util/TypedValue;)V", AccessFlags = 1)]
				public virtual void SetTo(global::Android.Util.TypedValue other) /* MethodBuilder.Create */ 
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
				///  <para>Return the data for this value as a float. Only use for values whose type is TYPE_FLOAT. </para>        
				/// </summary>
				/// <java-name>
				/// getFloat
				/// </java-name>
				public float Float
				{
						[Dot42.DexImport("getFloat", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

		}

		/// <summary>
		///  <para>XML utility methods. </para>    
		/// </summary>
		/// <java-name>
		/// android/util/Xml
		/// </java-name>
		[Dot42.DexImport("android/util/Xml", AccessFlags = 33)]
		public partial class Xml
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>org.xmlpull.v1.XmlPullParser "relaxed" feature name.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_RELAXED
				/// </java-name>
				[Dot42.DexImport("FEATURE_RELAXED", "Ljava/lang/String;", AccessFlags = 9)]
				public static string FEATURE_RELAXED;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Xml() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses xml from the given reader and fires events on the given SAX handler. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(string @in, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses xml from the given reader and fires events on the given SAX handler. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(global::Java.IO.Reader @in, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses xml from the given input stream and fires events on the given SAX handler. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V", AccessFlags = 9)]
				public static void Parse(global::Java.IO.InputStream @in, global::Android.Util.Xml.Encoding encoding, global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new pull parser with namespace support. </para>        
				/// </summary>
				/// <java-name>
				/// newPullParser
				/// </java-name>
				[Dot42.DexImport("newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.IXmlPullParser NewPullParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlPullParser);
				}

				/// <summary>
				///  <para>Creates a new xml serializer. </para>        
				/// </summary>
				/// <java-name>
				/// newSerializer
				/// </java-name>
				[Dot42.DexImport("newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.IXmlSerializer NewSerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlSerializer);
				}

				/// <summary>
				///  <para>Finds an encoding by name. Returns UTF-8 if you pass <c>null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// findEncodingByName
				/// </java-name>
				[Dot42.DexImport("findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;", AccessFlags = 9)]
				public static global::Android.Util.Xml.Encoding FindEncodingByName(string encodingName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.Xml.Encoding);
				}

				/// <summary>
				///  <para>Return an AttributeSet interface for use with the given XmlPullParser. If the given parser itself implements AttributeSet, that implementation is simply returned. Otherwise a wrapper class is instantiated on top of the XmlPullParser, as a proxy for retrieving its attributes, and returned to you.</para> <para> <para>AttributeSet </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An AttributeSet you can use to retrieve the attribute values at each of the tags as the parser moves through its XML document.</para>
				/// </returns>
				/// <java-name>
				/// asAttributeSet
				/// </java-name>
				[Dot42.DexImport("asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;", AccessFlags = 9)]
				public static global::Android.Util.IAttributeSet AsAttributeSet(global::Org.Xmlpull.V1.IXmlPullParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.IAttributeSet);
				}

				/// <java-name>
				/// android/util/Xml$Encoding
				/// </java-name>
				[Dot42.DexImport("android/util/Xml$Encoding", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/util/Xml$Encoding;>;")]
				public sealed class Encoding
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ISO_8859_1
						/// </java-name>
						[Dot42.DexImport("ISO_8859_1", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding ISO_8859_1;
						/// <java-name>
						/// US_ASCII
						/// </java-name>
						[Dot42.DexImport("US_ASCII", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding US_ASCII;
						/// <java-name>
						/// UTF_16
						/// </java-name>
						[Dot42.DexImport("UTF_16", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding UTF_16;
						/// <java-name>
						/// UTF_8
						/// </java-name>
						[Dot42.DexImport("UTF_8", "Landroid/util/Xml$Encoding;", AccessFlags = 16409)]
						public static readonly Encoding UTF_8;
						private Encoding() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/util/Xml$Encoding;", AccessFlags = 9)]
						public static Encoding[] Values() /* MethodBuilder.Create */ 
						{
								return default(Encoding[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;", AccessFlags = 9)]
						public static Encoding ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Encoding);
						}

				}

		}

}

