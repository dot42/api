// Copyright (C) 2014 dot42
//
// Original filename: Javax.Microedition.Khronos.Egl.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Javax.Microedition.Khronos.Egl
{
		/// <java-name>
		/// javax/microedition/khronos/egl/EGL
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGL", AccessFlags = 1537)]
		public partial interface IEGL
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGLContext
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGLContext", AccessFlags = 1057)]
		public abstract partial class EGLContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EGLContext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEGL
				/// </java-name>
				[Dot42.DexImport("getEGL", "()Ljavax/microedition/khronos/egl/EGL;", AccessFlags = 9)]
				public static global::Javax.Microedition.Khronos.Egl.IEGL GetEGL() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Microedition.Khronos.Egl.IEGL);
				}

				/// <java-name>
				/// getGL
				/// </java-name>
				[Dot42.DexImport("getGL", "()Ljavax/microedition/khronos/opengles/GL;", AccessFlags = 1025)]
				public abstract global::Javax.Microedition.Khronos.Opengles.IGL GetGL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEGL
				/// </java-name>
				public static global::Javax.Microedition.Khronos.Egl.IEGL EGL
				{
				[Dot42.DexImport("getEGL", "()Ljavax/microedition/khronos/egl/EGL;", AccessFlags = 9)]
						get{ return GetEGL(); }
				}

				/// <java-name>
				/// getGL
				/// </java-name>
				public global::Javax.Microedition.Khronos.Opengles.IGL GL
				{
				[Dot42.DexImport("getGL", "()Ljavax/microedition/khronos/opengles/GL;", AccessFlags = 1025)]
						get{ return GetGL(); }
				}

		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGLConfig
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGLConfig", AccessFlags = 1057)]
		public abstract partial class EGLConfig
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EGLConfig() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGLDisplay
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGLDisplay", AccessFlags = 1057)]
		public abstract partial class EGLDisplay
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EGLDisplay() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGLSurface
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGLSurface", AccessFlags = 1057)]
		public abstract partial class EGLSurface
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EGLSurface() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGL10
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGL10", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IEGL10Constants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EGL_SUCCESS
				/// </java-name>
				[Dot42.DexImport("EGL_SUCCESS", "I", AccessFlags = 25)]
				public const int EGL_SUCCESS = 12288;
				/// <java-name>
				/// EGL_NOT_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("EGL_NOT_INITIALIZED", "I", AccessFlags = 25)]
				public const int EGL_NOT_INITIALIZED = 12289;
				/// <java-name>
				/// EGL_BAD_ACCESS
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_ACCESS", "I", AccessFlags = 25)]
				public const int EGL_BAD_ACCESS = 12290;
				/// <java-name>
				/// EGL_BAD_ALLOC
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_ALLOC", "I", AccessFlags = 25)]
				public const int EGL_BAD_ALLOC = 12291;
				/// <java-name>
				/// EGL_BAD_ATTRIBUTE
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_ATTRIBUTE", "I", AccessFlags = 25)]
				public const int EGL_BAD_ATTRIBUTE = 12292;
				/// <java-name>
				/// EGL_BAD_CONFIG
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_CONFIG", "I", AccessFlags = 25)]
				public const int EGL_BAD_CONFIG = 12293;
				/// <java-name>
				/// EGL_BAD_CONTEXT
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_CONTEXT", "I", AccessFlags = 25)]
				public const int EGL_BAD_CONTEXT = 12294;
				/// <java-name>
				/// EGL_BAD_CURRENT_SURFACE
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_CURRENT_SURFACE", "I", AccessFlags = 25)]
				public const int EGL_BAD_CURRENT_SURFACE = 12295;
				/// <java-name>
				/// EGL_BAD_DISPLAY
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_DISPLAY", "I", AccessFlags = 25)]
				public const int EGL_BAD_DISPLAY = 12296;
				/// <java-name>
				/// EGL_BAD_MATCH
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_MATCH", "I", AccessFlags = 25)]
				public const int EGL_BAD_MATCH = 12297;
				/// <java-name>
				/// EGL_BAD_NATIVE_PIXMAP
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_NATIVE_PIXMAP", "I", AccessFlags = 25)]
				public const int EGL_BAD_NATIVE_PIXMAP = 12298;
				/// <java-name>
				/// EGL_BAD_NATIVE_WINDOW
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_NATIVE_WINDOW", "I", AccessFlags = 25)]
				public const int EGL_BAD_NATIVE_WINDOW = 12299;
				/// <java-name>
				/// EGL_BAD_PARAMETER
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_PARAMETER", "I", AccessFlags = 25)]
				public const int EGL_BAD_PARAMETER = 12300;
				/// <java-name>
				/// EGL_BAD_SURFACE
				/// </java-name>
				[Dot42.DexImport("EGL_BAD_SURFACE", "I", AccessFlags = 25)]
				public const int EGL_BAD_SURFACE = 12301;
				/// <java-name>
				/// EGL_BUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_BUFFER_SIZE", "I", AccessFlags = 25)]
				public const int EGL_BUFFER_SIZE = 12320;
				/// <java-name>
				/// EGL_ALPHA_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_ALPHA_SIZE", "I", AccessFlags = 25)]
				public const int EGL_ALPHA_SIZE = 12321;
				/// <java-name>
				/// EGL_BLUE_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_BLUE_SIZE", "I", AccessFlags = 25)]
				public const int EGL_BLUE_SIZE = 12322;
				/// <java-name>
				/// EGL_GREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_GREEN_SIZE", "I", AccessFlags = 25)]
				public const int EGL_GREEN_SIZE = 12323;
				/// <java-name>
				/// EGL_RED_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_RED_SIZE", "I", AccessFlags = 25)]
				public const int EGL_RED_SIZE = 12324;
				/// <java-name>
				/// EGL_DEPTH_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_DEPTH_SIZE", "I", AccessFlags = 25)]
				public const int EGL_DEPTH_SIZE = 12325;
				/// <java-name>
				/// EGL_STENCIL_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_STENCIL_SIZE", "I", AccessFlags = 25)]
				public const int EGL_STENCIL_SIZE = 12326;
				/// <java-name>
				/// EGL_CONFIG_CAVEAT
				/// </java-name>
				[Dot42.DexImport("EGL_CONFIG_CAVEAT", "I", AccessFlags = 25)]
				public const int EGL_CONFIG_CAVEAT = 12327;
				/// <java-name>
				/// EGL_CONFIG_ID
				/// </java-name>
				[Dot42.DexImport("EGL_CONFIG_ID", "I", AccessFlags = 25)]
				public const int EGL_CONFIG_ID = 12328;
				/// <java-name>
				/// EGL_LEVEL
				/// </java-name>
				[Dot42.DexImport("EGL_LEVEL", "I", AccessFlags = 25)]
				public const int EGL_LEVEL = 12329;
				/// <java-name>
				/// EGL_MAX_PBUFFER_HEIGHT
				/// </java-name>
				[Dot42.DexImport("EGL_MAX_PBUFFER_HEIGHT", "I", AccessFlags = 25)]
				public const int EGL_MAX_PBUFFER_HEIGHT = 12330;
				/// <java-name>
				/// EGL_MAX_PBUFFER_PIXELS
				/// </java-name>
				[Dot42.DexImport("EGL_MAX_PBUFFER_PIXELS", "I", AccessFlags = 25)]
				public const int EGL_MAX_PBUFFER_PIXELS = 12331;
				/// <java-name>
				/// EGL_MAX_PBUFFER_WIDTH
				/// </java-name>
				[Dot42.DexImport("EGL_MAX_PBUFFER_WIDTH", "I", AccessFlags = 25)]
				public const int EGL_MAX_PBUFFER_WIDTH = 12332;
				/// <java-name>
				/// EGL_NATIVE_RENDERABLE
				/// </java-name>
				[Dot42.DexImport("EGL_NATIVE_RENDERABLE", "I", AccessFlags = 25)]
				public const int EGL_NATIVE_RENDERABLE = 12333;
				/// <java-name>
				/// EGL_NATIVE_VISUAL_ID
				/// </java-name>
				[Dot42.DexImport("EGL_NATIVE_VISUAL_ID", "I", AccessFlags = 25)]
				public const int EGL_NATIVE_VISUAL_ID = 12334;
				/// <java-name>
				/// EGL_NATIVE_VISUAL_TYPE
				/// </java-name>
				[Dot42.DexImport("EGL_NATIVE_VISUAL_TYPE", "I", AccessFlags = 25)]
				public const int EGL_NATIVE_VISUAL_TYPE = 12335;
				/// <java-name>
				/// EGL_SAMPLES
				/// </java-name>
				[Dot42.DexImport("EGL_SAMPLES", "I", AccessFlags = 25)]
				public const int EGL_SAMPLES = 12337;
				/// <java-name>
				/// EGL_SAMPLE_BUFFERS
				/// </java-name>
				[Dot42.DexImport("EGL_SAMPLE_BUFFERS", "I", AccessFlags = 25)]
				public const int EGL_SAMPLE_BUFFERS = 12338;
				/// <java-name>
				/// EGL_SURFACE_TYPE
				/// </java-name>
				[Dot42.DexImport("EGL_SURFACE_TYPE", "I", AccessFlags = 25)]
				public const int EGL_SURFACE_TYPE = 12339;
				/// <java-name>
				/// EGL_TRANSPARENT_TYPE
				/// </java-name>
				[Dot42.DexImport("EGL_TRANSPARENT_TYPE", "I", AccessFlags = 25)]
				public const int EGL_TRANSPARENT_TYPE = 12340;
				/// <java-name>
				/// EGL_TRANSPARENT_BLUE_VALUE
				/// </java-name>
				[Dot42.DexImport("EGL_TRANSPARENT_BLUE_VALUE", "I", AccessFlags = 25)]
				public const int EGL_TRANSPARENT_BLUE_VALUE = 12341;
				/// <java-name>
				/// EGL_TRANSPARENT_GREEN_VALUE
				/// </java-name>
				[Dot42.DexImport("EGL_TRANSPARENT_GREEN_VALUE", "I", AccessFlags = 25)]
				public const int EGL_TRANSPARENT_GREEN_VALUE = 12342;
				/// <java-name>
				/// EGL_TRANSPARENT_RED_VALUE
				/// </java-name>
				[Dot42.DexImport("EGL_TRANSPARENT_RED_VALUE", "I", AccessFlags = 25)]
				public const int EGL_TRANSPARENT_RED_VALUE = 12343;
				/// <java-name>
				/// EGL_NONE
				/// </java-name>
				[Dot42.DexImport("EGL_NONE", "I", AccessFlags = 25)]
				public const int EGL_NONE = 12344;
				/// <java-name>
				/// EGL_LUMINANCE_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_LUMINANCE_SIZE", "I", AccessFlags = 25)]
				public const int EGL_LUMINANCE_SIZE = 12349;
				/// <java-name>
				/// EGL_ALPHA_MASK_SIZE
				/// </java-name>
				[Dot42.DexImport("EGL_ALPHA_MASK_SIZE", "I", AccessFlags = 25)]
				public const int EGL_ALPHA_MASK_SIZE = 12350;
				/// <java-name>
				/// EGL_COLOR_BUFFER_TYPE
				/// </java-name>
				[Dot42.DexImport("EGL_COLOR_BUFFER_TYPE", "I", AccessFlags = 25)]
				public const int EGL_COLOR_BUFFER_TYPE = 12351;
				/// <java-name>
				/// EGL_RENDERABLE_TYPE
				/// </java-name>
				[Dot42.DexImport("EGL_RENDERABLE_TYPE", "I", AccessFlags = 25)]
				public const int EGL_RENDERABLE_TYPE = 12352;
				/// <java-name>
				/// EGL_SLOW_CONFIG
				/// </java-name>
				[Dot42.DexImport("EGL_SLOW_CONFIG", "I", AccessFlags = 25)]
				public const int EGL_SLOW_CONFIG = 12368;
				/// <java-name>
				/// EGL_NON_CONFORMANT_CONFIG
				/// </java-name>
				[Dot42.DexImport("EGL_NON_CONFORMANT_CONFIG", "I", AccessFlags = 25)]
				public const int EGL_NON_CONFORMANT_CONFIG = 12369;
				/// <java-name>
				/// EGL_TRANSPARENT_RGB
				/// </java-name>
				[Dot42.DexImport("EGL_TRANSPARENT_RGB", "I", AccessFlags = 25)]
				public const int EGL_TRANSPARENT_RGB = 12370;
				/// <java-name>
				/// EGL_RGB_BUFFER
				/// </java-name>
				[Dot42.DexImport("EGL_RGB_BUFFER", "I", AccessFlags = 25)]
				public const int EGL_RGB_BUFFER = 12430;
				/// <java-name>
				/// EGL_LUMINANCE_BUFFER
				/// </java-name>
				[Dot42.DexImport("EGL_LUMINANCE_BUFFER", "I", AccessFlags = 25)]
				public const int EGL_LUMINANCE_BUFFER = 12431;
				/// <java-name>
				/// EGL_VENDOR
				/// </java-name>
				[Dot42.DexImport("EGL_VENDOR", "I", AccessFlags = 25)]
				public const int EGL_VENDOR = 12371;
				/// <java-name>
				/// EGL_VERSION
				/// </java-name>
				[Dot42.DexImport("EGL_VERSION", "I", AccessFlags = 25)]
				public const int EGL_VERSION = 12372;
				/// <java-name>
				/// EGL_EXTENSIONS
				/// </java-name>
				[Dot42.DexImport("EGL_EXTENSIONS", "I", AccessFlags = 25)]
				public const int EGL_EXTENSIONS = 12373;
				/// <java-name>
				/// EGL_HEIGHT
				/// </java-name>
				[Dot42.DexImport("EGL_HEIGHT", "I", AccessFlags = 25)]
				public const int EGL_HEIGHT = 12374;
				/// <java-name>
				/// EGL_WIDTH
				/// </java-name>
				[Dot42.DexImport("EGL_WIDTH", "I", AccessFlags = 25)]
				public const int EGL_WIDTH = 12375;
				/// <java-name>
				/// EGL_LARGEST_PBUFFER
				/// </java-name>
				[Dot42.DexImport("EGL_LARGEST_PBUFFER", "I", AccessFlags = 25)]
				public const int EGL_LARGEST_PBUFFER = 12376;
				/// <java-name>
				/// EGL_RENDER_BUFFER
				/// </java-name>
				[Dot42.DexImport("EGL_RENDER_BUFFER", "I", AccessFlags = 25)]
				public const int EGL_RENDER_BUFFER = 12422;
				/// <java-name>
				/// EGL_COLORSPACE
				/// </java-name>
				[Dot42.DexImport("EGL_COLORSPACE", "I", AccessFlags = 25)]
				public const int EGL_COLORSPACE = 12423;
				/// <java-name>
				/// EGL_ALPHA_FORMAT
				/// </java-name>
				[Dot42.DexImport("EGL_ALPHA_FORMAT", "I", AccessFlags = 25)]
				public const int EGL_ALPHA_FORMAT = 12424;
				/// <java-name>
				/// EGL_HORIZONTAL_RESOLUTION
				/// </java-name>
				[Dot42.DexImport("EGL_HORIZONTAL_RESOLUTION", "I", AccessFlags = 25)]
				public const int EGL_HORIZONTAL_RESOLUTION = 12432;
				/// <java-name>
				/// EGL_VERTICAL_RESOLUTION
				/// </java-name>
				[Dot42.DexImport("EGL_VERTICAL_RESOLUTION", "I", AccessFlags = 25)]
				public const int EGL_VERTICAL_RESOLUTION = 12433;
				/// <java-name>
				/// EGL_PIXEL_ASPECT_RATIO
				/// </java-name>
				[Dot42.DexImport("EGL_PIXEL_ASPECT_RATIO", "I", AccessFlags = 25)]
				public const int EGL_PIXEL_ASPECT_RATIO = 12434;
				/// <java-name>
				/// EGL_SINGLE_BUFFER
				/// </java-name>
				[Dot42.DexImport("EGL_SINGLE_BUFFER", "I", AccessFlags = 25)]
				public const int EGL_SINGLE_BUFFER = 12421;
				/// <java-name>
				/// EGL_CORE_NATIVE_ENGINE
				/// </java-name>
				[Dot42.DexImport("EGL_CORE_NATIVE_ENGINE", "I", AccessFlags = 25)]
				public const int EGL_CORE_NATIVE_ENGINE = 12379;
				/// <java-name>
				/// EGL_DRAW
				/// </java-name>
				[Dot42.DexImport("EGL_DRAW", "I", AccessFlags = 25)]
				public const int EGL_DRAW = 12377;
				/// <java-name>
				/// EGL_READ
				/// </java-name>
				[Dot42.DexImport("EGL_READ", "I", AccessFlags = 25)]
				public const int EGL_READ = 12378;
				/// <java-name>
				/// EGL_DONT_CARE
				/// </java-name>
				[Dot42.DexImport("EGL_DONT_CARE", "I", AccessFlags = 25)]
				public const int EGL_DONT_CARE = -1;
				/// <java-name>
				/// EGL_PBUFFER_BIT
				/// </java-name>
				[Dot42.DexImport("EGL_PBUFFER_BIT", "I", AccessFlags = 25)]
				public const int EGL_PBUFFER_BIT = 1;
				/// <java-name>
				/// EGL_PIXMAP_BIT
				/// </java-name>
				[Dot42.DexImport("EGL_PIXMAP_BIT", "I", AccessFlags = 25)]
				public const int EGL_PIXMAP_BIT = 2;
				/// <java-name>
				/// EGL_WINDOW_BIT
				/// </java-name>
				[Dot42.DexImport("EGL_WINDOW_BIT", "I", AccessFlags = 25)]
				public const int EGL_WINDOW_BIT = 4;
				/// <java-name>
				/// EGL_DEFAULT_DISPLAY
				/// </java-name>
				[Dot42.DexImport("EGL_DEFAULT_DISPLAY", "Ljava/lang/Object;", AccessFlags = 25)]
				public static readonly object EGL_DEFAULT_DISPLAY;
				/// <java-name>
				/// EGL_NO_DISPLAY
				/// </java-name>
				[Dot42.DexImport("EGL_NO_DISPLAY", "Ljavax/microedition/khronos/egl/EGLDisplay;", AccessFlags = 25)]
				public static readonly global::Javax.Microedition.Khronos.Egl.EGLDisplay EGL_NO_DISPLAY;
				/// <java-name>
				/// EGL_NO_CONTEXT
				/// </java-name>
				[Dot42.DexImport("EGL_NO_CONTEXT", "Ljavax/microedition/khronos/egl/EGLContext;", AccessFlags = 25)]
				public static readonly global::Javax.Microedition.Khronos.Egl.EGLContext EGL_NO_CONTEXT;
				/// <java-name>
				/// EGL_NO_SURFACE
				/// </java-name>
				[Dot42.DexImport("EGL_NO_SURFACE", "Ljavax/microedition/khronos/egl/EGLSurface;", AccessFlags = 25)]
				public static readonly global::Javax.Microedition.Khronos.Egl.EGLSurface EGL_NO_SURFACE;
		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGL10
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGL10", AccessFlags = 1537)]
		public partial interface IEGL10 : global::Javax.Microedition.Khronos.Egl.IEGL
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// eglChooseConfig
				/// </java-name>
				[Dot42.DexImport("eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EG" +
    "LConfig;I[I)Z", AccessFlags = 1025)]
				bool EglChooseConfig(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, int[] attrib_list, global::Javax.Microedition.Khronos.Egl.EGLConfig[] configs, int config_size, int[] num_config) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglCopyBuffers
				/// </java-name>
				[Dot42.DexImport("eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSu" +
    "rface;Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool EglCopyBuffers(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLSurface surface, object native_pixmap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglCreateContext
				/// </java-name>
				[Dot42.DexImport("eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "nfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/e" +
    "gl/EGLContext;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLContext EglCreateContext(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig config, global::Javax.Microedition.Khronos.Egl.EGLContext share_context, int[] attrib_list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglCreatePbufferSurface
				/// </java-name>
				[Dot42.DexImport("eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "nfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLSurface EglCreatePbufferSurface(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig config, int[] attrib_list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglCreatePixmapSurface
				/// </java-name>
				[Dot42.DexImport("eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "nfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLSurface EglCreatePixmapSurface(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig config, object native_pixmap, int[] attrib_list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglCreateWindowSurface
				/// </java-name>
				[Dot42.DexImport("eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "nfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLSurface EglCreateWindowSurface(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig config, object native_window, int[] attrib_list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglDestroyContext
				/// </java-name>
				[Dot42.DexImport("eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "ntext;)Z", AccessFlags = 1025)]
				bool EglDestroyContext(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLContext context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglDestroySurface
				/// </java-name>
				[Dot42.DexImport("eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSu" +
    "rface;)Z", AccessFlags = 1025)]
				bool EglDestroySurface(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLSurface surface) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetConfigAttrib
				/// </java-name>
				[Dot42.DexImport("eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "nfig;I[I)Z", AccessFlags = 1025)]
				bool EglGetConfigAttrib(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig config, int attribute, int[] value) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetConfigs
				/// </java-name>
				[Dot42.DexImport("eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLC" +
    "onfig;I[I)Z", AccessFlags = 1025)]
				bool EglGetConfigs(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLConfig[] configs, int config_size, int[] num_config) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetCurrentContext
				/// </java-name>
				[Dot42.DexImport("eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLContext EglGetCurrentContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetCurrentDisplay
				/// </java-name>
				[Dot42.DexImport("eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLDisplay EglGetCurrentDisplay() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetCurrentSurface
				/// </java-name>
				[Dot42.DexImport("eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLSurface EglGetCurrentSurface(int readdraw) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetDisplay
				/// </java-name>
				[Dot42.DexImport("eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;", AccessFlags = 1025)]
				global::Javax.Microedition.Khronos.Egl.EGLDisplay EglGetDisplay(object native_display) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglGetError
				/// </java-name>
				[Dot42.DexImport("eglGetError", "()I", AccessFlags = 1025)]
				int EglGetError() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglInitialize
				/// </java-name>
				[Dot42.DexImport("eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z", AccessFlags = 1025)]
				bool EglInitialize(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, int[] major_minor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglMakeCurrent
				/// </java-name>
				[Dot42.DexImport("eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSu" +
    "rface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl" +
    "/EGLContext;)Z", AccessFlags = 1025)]
				bool EglMakeCurrent(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLSurface draw, global::Javax.Microedition.Khronos.Egl.EGLSurface read, global::Javax.Microedition.Khronos.Egl.EGLContext context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglQueryContext
				/// </java-name>
				[Dot42.DexImport("eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLCo" +
    "ntext;I[I)Z", AccessFlags = 1025)]
				bool EglQueryContext(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLContext context, int attribute, int[] value) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglQueryString
				/// </java-name>
				[Dot42.DexImport("eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;", AccessFlags = 1025)]
				string EglQueryString(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, int name) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglQuerySurface
				/// </java-name>
				[Dot42.DexImport("eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSu" +
    "rface;I[I)Z", AccessFlags = 1025)]
				bool EglQuerySurface(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLSurface surface, int attribute, int[] value) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglSwapBuffers
				/// </java-name>
				[Dot42.DexImport("eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSu" +
    "rface;)Z", AccessFlags = 1025)]
				bool EglSwapBuffers(global::Javax.Microedition.Khronos.Egl.EGLDisplay display, global::Javax.Microedition.Khronos.Egl.EGLSurface surface) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglTerminate
				/// </java-name>
				[Dot42.DexImport("eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z", AccessFlags = 1025)]
				bool EglTerminate(global::Javax.Microedition.Khronos.Egl.EGLDisplay display) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglWaitGL
				/// </java-name>
				[Dot42.DexImport("eglWaitGL", "()Z", AccessFlags = 1025)]
				bool EglWaitGL() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// eglWaitNative
				/// </java-name>
				[Dot42.DexImport("eglWaitNative", "(ILjava/lang/Object;)Z", AccessFlags = 1025)]
				bool EglWaitNative(int engine, object bindTarget) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGL11
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGL11", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IEGL11Constants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EGL_CONTEXT_LOST
				/// </java-name>
				[Dot42.DexImport("EGL_CONTEXT_LOST", "I", AccessFlags = 25)]
				public const int EGL_CONTEXT_LOST = 12302;
		}

		/// <java-name>
		/// javax/microedition/khronos/egl/EGL11
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/egl/EGL11", AccessFlags = 1537)]
		public partial interface IEGL11 : global::Javax.Microedition.Khronos.Egl.IEGL10
 /* scope: __dot42__ */ 
		{
		}

}


