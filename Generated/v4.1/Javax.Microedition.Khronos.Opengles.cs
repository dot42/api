// Copyright (C) 2014 dot42
//
// Original filename: Javax.Microedition.Khronos.Opengles.cs
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
namespace Javax.Microedition.Khronos.Opengles
{
		/// <java-name>
		/// javax/microedition/khronos/opengles/GL10Ext
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL10Ext", AccessFlags = 1537)]
		public partial interface IGL10Ext : global::Javax.Microedition.Khronos.Opengles.IGL
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// glQueryMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glQueryMatrixxOES", "([II[II)I", AccessFlags = 1025)]
				int GlQueryMatrixxOES(int[] mantissa, int mantissaOffset, int[] exponent, int exponentOffset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glQueryMatrixxOES
				/// </java-name>
				[Dot42.DexImport("glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I", AccessFlags = 1025)]
				int GlQueryMatrixxOES(global::Java.Nio.IntBuffer mantissa, global::Java.Nio.IntBuffer exponent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11ExtensionPack
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11ExtensionPack", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IGL11ExtensionPackConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_BLEND_DST_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_ALPHA = 32970;
				/// <java-name>
				/// GL_BLEND_DST_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_DST_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_DST_RGB = 32968;
				/// <java-name>
				/// GL_BLEND_EQUATION
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION = 32777;
				/// <java-name>
				/// GL_BLEND_EQUATION_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_ALPHA = 34877;
				/// <java-name>
				/// GL_BLEND_EQUATION_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_EQUATION_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_EQUATION_RGB = 32777;
				/// <java-name>
				/// GL_BLEND_SRC_ALPHA
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_ALPHA", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_ALPHA = 32971;
				/// <java-name>
				/// GL_BLEND_SRC_RGB
				/// </java-name>
				[Dot42.DexImport("GL_BLEND_SRC_RGB", "I", AccessFlags = 25)]
				public const int GL_BLEND_SRC_RGB = 32969;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT0_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT0_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT0_OES = 36064;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT1_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT1_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT1_OES = 36065;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT2_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT2_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT2_OES = 36066;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT3_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT3_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT3_OES = 36067;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT4_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT4_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT4_OES = 36068;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT5_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT5_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT5_OES = 36069;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT6_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT6_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT6_OES = 36070;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT7_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT7_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT7_OES = 36071;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT8_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT8_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT8_OES = 36072;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT9_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT9_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT9_OES = 36073;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT10_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT10_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT10_OES = 36074;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT11_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT11_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT11_OES = 36075;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT12_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT12_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT12_OES = 36076;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT13_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT13_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT13_OES = 36077;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT14_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT14_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT14_OES = 36078;
				/// <java-name>
				/// GL_COLOR_ATTACHMENT15_OES
				/// </java-name>
				[Dot42.DexImport("GL_COLOR_ATTACHMENT15_OES", "I", AccessFlags = 25)]
				public const int GL_COLOR_ATTACHMENT15_OES = 36079;
				/// <java-name>
				/// GL_DECR_WRAP
				/// </java-name>
				[Dot42.DexImport("GL_DECR_WRAP", "I", AccessFlags = 25)]
				public const int GL_DECR_WRAP = 34056;
				/// <java-name>
				/// GL_DEPTH_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_DEPTH_ATTACHMENT_OES = 36096;
				/// <java-name>
				/// GL_DEPTH_COMPONENT
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT = 6402;
				/// <java-name>
				/// GL_DEPTH_COMPONENT16
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT16", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT16 = 33189;
				/// <java-name>
				/// GL_DEPTH_COMPONENT24
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT24", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT24 = 33190;
				/// <java-name>
				/// GL_DEPTH_COMPONENT32
				/// </java-name>
				[Dot42.DexImport("GL_DEPTH_COMPONENT32", "I", AccessFlags = 25)]
				public const int GL_DEPTH_COMPONENT32 = 33191;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 36049;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 36048;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 36051;
				/// <java-name>
				/// GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 36050;
				/// <java-name>
				/// GL_FRAMEBUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_BINDING_OES = 36006;
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
				/// GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 36057;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES = 36059;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 36058;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 36055;
				/// <java-name>
				/// GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES = 36060;
				/// <java-name>
				/// GL_FRAMEBUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_OES = 36160;
				/// <java-name>
				/// GL_FRAMEBUFFER_UNSUPPORTED_OES
				/// </java-name>
				[Dot42.DexImport("GL_FRAMEBUFFER_UNSUPPORTED_OES", "I", AccessFlags = 25)]
				public const int GL_FRAMEBUFFER_UNSUPPORTED_OES = 36061;
				/// <java-name>
				/// GL_FUNC_ADD
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_ADD", "I", AccessFlags = 25)]
				public const int GL_FUNC_ADD = 32774;
				/// <java-name>
				/// GL_FUNC_REVERSE_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_REVERSE_SUBTRACT", "I", AccessFlags = 25)]
				public const int GL_FUNC_REVERSE_SUBTRACT = 32779;
				/// <java-name>
				/// GL_FUNC_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("GL_FUNC_SUBTRACT", "I", AccessFlags = 25)]
				public const int GL_FUNC_SUBTRACT = 32778;
				/// <java-name>
				/// GL_INCR_WRAP
				/// </java-name>
				[Dot42.DexImport("GL_INCR_WRAP", "I", AccessFlags = 25)]
				public const int GL_INCR_WRAP = 34055;
				/// <java-name>
				/// GL_INVALID_FRAMEBUFFER_OPERATION_OES
				/// </java-name>
				[Dot42.DexImport("GL_INVALID_FRAMEBUFFER_OPERATION_OES", "I", AccessFlags = 25)]
				public const int GL_INVALID_FRAMEBUFFER_OPERATION_OES = 1286;
				/// <java-name>
				/// GL_MAX_COLOR_ATTACHMENTS_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_COLOR_ATTACHMENTS_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_COLOR_ATTACHMENTS_OES = 36063;
				/// <java-name>
				/// GL_MAX_CUBE_MAP_TEXTURE_SIZE
				/// </java-name>
				[Dot42.DexImport("GL_MAX_CUBE_MAP_TEXTURE_SIZE", "I", AccessFlags = 25)]
				public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 34076;
				/// <java-name>
				/// GL_MAX_RENDERBUFFER_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_RENDERBUFFER_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_RENDERBUFFER_SIZE_OES = 34024;
				/// <java-name>
				/// GL_MIRRORED_REPEAT
				/// </java-name>
				[Dot42.DexImport("GL_MIRRORED_REPEAT", "I", AccessFlags = 25)]
				public const int GL_MIRRORED_REPEAT = 33648;
				/// <java-name>
				/// GL_NORMAL_MAP
				/// </java-name>
				[Dot42.DexImport("GL_NORMAL_MAP", "I", AccessFlags = 25)]
				public const int GL_NORMAL_MAP = 34065;
				/// <java-name>
				/// GL_REFLECTION_MAP
				/// </java-name>
				[Dot42.DexImport("GL_REFLECTION_MAP", "I", AccessFlags = 25)]
				public const int GL_REFLECTION_MAP = 34066;
				/// <java-name>
				/// GL_RENDERBUFFER_ALPHA_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_ALPHA_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_ALPHA_SIZE_OES = 36179;
				/// <java-name>
				/// GL_RENDERBUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BINDING_OES = 36007;
				/// <java-name>
				/// GL_RENDERBUFFER_BLUE_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_BLUE_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_BLUE_SIZE_OES = 36178;
				/// <java-name>
				/// GL_RENDERBUFFER_DEPTH_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_DEPTH_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_DEPTH_SIZE_OES = 36180;
				/// <java-name>
				/// GL_RENDERBUFFER_GREEN_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_GREEN_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_GREEN_SIZE_OES = 36177;
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
				/// GL_RENDERBUFFER_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_OES = 36161;
				/// <java-name>
				/// GL_RENDERBUFFER_RED_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_RED_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_RED_SIZE_OES = 36176;
				/// <java-name>
				/// GL_RENDERBUFFER_STENCIL_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_STENCIL_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_STENCIL_SIZE_OES = 36181;
				/// <java-name>
				/// GL_RENDERBUFFER_WIDTH_OES
				/// </java-name>
				[Dot42.DexImport("GL_RENDERBUFFER_WIDTH_OES", "I", AccessFlags = 25)]
				public const int GL_RENDERBUFFER_WIDTH_OES = 36162;
				/// <java-name>
				/// GL_RGB5_A1
				/// </java-name>
				[Dot42.DexImport("GL_RGB5_A1", "I", AccessFlags = 25)]
				public const int GL_RGB5_A1 = 32855;
				/// <java-name>
				/// GL_RGB565_OES
				/// </java-name>
				[Dot42.DexImport("GL_RGB565_OES", "I", AccessFlags = 25)]
				public const int GL_RGB565_OES = 36194;
				/// <java-name>
				/// GL_RGB8
				/// </java-name>
				[Dot42.DexImport("GL_RGB8", "I", AccessFlags = 25)]
				public const int GL_RGB8 = 32849;
				/// <java-name>
				/// GL_RGBA4
				/// </java-name>
				[Dot42.DexImport("GL_RGBA4", "I", AccessFlags = 25)]
				public const int GL_RGBA4 = 32854;
				/// <java-name>
				/// GL_RGBA8
				/// </java-name>
				[Dot42.DexImport("GL_RGBA8", "I", AccessFlags = 25)]
				public const int GL_RGBA8 = 32856;
				/// <java-name>
				/// GL_STENCIL_ATTACHMENT_OES
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_ATTACHMENT_OES", "I", AccessFlags = 25)]
				public const int GL_STENCIL_ATTACHMENT_OES = 36128;
				/// <java-name>
				/// GL_STENCIL_INDEX
				/// </java-name>
				[Dot42.DexImport("GL_STENCIL_INDEX", "I", AccessFlags = 25)]
				public const int GL_STENCIL_INDEX = 6401;
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
				/// GL_STR
				/// </java-name>
				[Dot42.DexImport("GL_STR", "I", AccessFlags = 25)]
				public const int GL_STR = -1;
				/// <java-name>
				/// GL_TEXTURE_BINDING_CUBE_MAP
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_BINDING_CUBE_MAP", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_BINDING_CUBE_MAP = 34068;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP = 34067;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_X", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_X
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_X", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 34069;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Y", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;
				/// <java-name>
				/// GL_TEXTURE_CUBE_MAP_POSITIVE_Z
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CUBE_MAP_POSITIVE_Z", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;
				/// <java-name>
				/// GL_TEXTURE_GEN_MODE
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_GEN_MODE", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_GEN_MODE = 9472;
				/// <java-name>
				/// GL_TEXTURE_GEN_STR
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_GEN_STR", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_GEN_STR = 36192;
		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11ExtensionPack
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11ExtensionPack", AccessFlags = 1537)]
		public partial interface IGL11ExtensionPack : global::Javax.Microedition.Khronos.Opengles.IGL
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// glBindFramebufferOES
				/// </java-name>
				[Dot42.DexImport("glBindFramebufferOES", "(II)V", AccessFlags = 1025)]
				void GlBindFramebufferOES(int target, int framebuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBindRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glBindRenderbufferOES", "(II)V", AccessFlags = 1025)]
				void GlBindRenderbufferOES(int target, int renderbuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBindTexture
				/// </java-name>
				[Dot42.DexImport("glBindTexture", "(II)V", AccessFlags = 1025)]
				void GlBindTexture(int target, int texture) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBlendEquation
				/// </java-name>
				[Dot42.DexImport("glBlendEquation", "(I)V", AccessFlags = 1025)]
				void GlBlendEquation(int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBlendEquationSeparate
				/// </java-name>
				[Dot42.DexImport("glBlendEquationSeparate", "(II)V", AccessFlags = 1025)]
				void GlBlendEquationSeparate(int modeRGB, int modeAlpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBlendFuncSeparate
				/// </java-name>
				[Dot42.DexImport("glBlendFuncSeparate", "(IIII)V", AccessFlags = 1025)]
				void GlBlendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCheckFramebufferStatusOES
				/// </java-name>
				[Dot42.DexImport("glCheckFramebufferStatusOES", "(I)I", AccessFlags = 1025)]
				int GlCheckFramebufferStatusOES(int target) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCompressedTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, global::Java.Nio.Buffer data) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCopyTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexImage2D", "(IIIIIIII)V", AccessFlags = 1025)]
				void GlCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffersOES", "(I[II)V", AccessFlags = 1025)]
				void GlDeleteFramebuffersOES(int n, int[] framebuffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDeleteFramebuffersOES(int n, global::Java.Nio.IntBuffer framebuffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffersOES", "(I[II)V", AccessFlags = 1025)]
				void GlDeleteRenderbuffersOES(int n, int[] renderbuffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDeleteRenderbuffersOES(int n, global::Java.Nio.IntBuffer renderbuffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glEnable
				/// </java-name>
				[Dot42.DexImport("glEnable", "(I)V", AccessFlags = 1025)]
				void GlEnable(int cap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFramebufferRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glFramebufferRenderbufferOES", "(IIII)V", AccessFlags = 1025)]
				void GlFramebufferRenderbufferOES(int target, int attachment, int renderbuffertarget, int renderbuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFramebufferTexture2DOES
				/// </java-name>
				[Dot42.DexImport("glFramebufferTexture2DOES", "(IIIII)V", AccessFlags = 1025)]
				void GlFramebufferTexture2DOES(int target, int attachment, int textarget, int texture, int level) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenerateMipmapOES
				/// </java-name>
				[Dot42.DexImport("glGenerateMipmapOES", "(I)V", AccessFlags = 1025)]
				void GlGenerateMipmapOES(int target) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffersOES", "(I[II)V", AccessFlags = 1025)]
				void GlGenFramebuffersOES(int n, int[] framebuffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenFramebuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGenFramebuffersOES(int n, global::Java.Nio.IntBuffer framebuffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffersOES", "(I[II)V", AccessFlags = 1025)]
				void GlGenRenderbuffersOES(int n, int[] renderbuffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenRenderbuffersOES
				/// </java-name>
				[Dot42.DexImport("glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGenRenderbuffersOES(int n, global::Java.Nio.IntBuffer renderbuffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFramebufferAttachmentParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameterivOES", "(III[II)V", AccessFlags = 1025)]
				void GlGetFramebufferAttachmentParameterivOES(int target, int attachment, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFramebufferAttachmentParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetFramebufferAttachmentParameterivOES(int target, int attachment, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(I[II)V", AccessFlags = 1025)]
				void GlGetIntegerv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetIntegerv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetRenderbufferParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameterivOES", "(II[II)V", AccessFlags = 1025)]
				void GlGetRenderbufferParameterivOES(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetRenderbufferParameterivOES
				/// </java-name>
				[Dot42.DexImport("glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetRenderbufferParameterivOES(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGenfv
				/// </java-name>
				[Dot42.DexImport("glGetTexGenfv", "(II[FI)V", AccessFlags = 1025)]
				void GlGetTexGenfv(int coord, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGenfv
				/// </java-name>
				[Dot42.DexImport("glGetTexGenfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetTexGenfv(int coord, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGeniv
				/// </java-name>
				[Dot42.DexImport("glGetTexGeniv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexGeniv(int coord, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGeniv
				/// </java-name>
				[Dot42.DexImport("glGetTexGeniv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexGeniv(int coord, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGenxv
				/// </java-name>
				[Dot42.DexImport("glGetTexGenxv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexGenxv(int coord, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexGenxv
				/// </java-name>
				[Dot42.DexImport("glGetTexGenxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexGenxv(int coord, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glIsFramebufferOES
				/// </java-name>
				[Dot42.DexImport("glIsFramebufferOES", "(I)Z", AccessFlags = 1025)]
				bool GlIsFramebufferOES(int framebuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glIsRenderbufferOES
				/// </java-name>
				[Dot42.DexImport("glIsRenderbufferOES", "(I)Z", AccessFlags = 1025)]
				bool GlIsRenderbufferOES(int renderbuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glRenderbufferStorageOES
				/// </java-name>
				[Dot42.DexImport("glRenderbufferStorageOES", "(IIII)V", AccessFlags = 1025)]
				void GlRenderbufferStorageOES(int target, int internalformat, int width, int height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glStencilOp
				/// </java-name>
				[Dot42.DexImport("glStencilOp", "(III)V", AccessFlags = 1025)]
				void GlStencilOp(int fail, int zfail, int zpass) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvf
				/// </java-name>
				[Dot42.DexImport("glTexEnvf", "(IIF)V", AccessFlags = 1025)]
				void GlTexEnvf(int target, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(II[FI)V", AccessFlags = 1025)]
				void GlTexEnvfv(int target, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlTexEnvfv(int target, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvx
				/// </java-name>
				[Dot42.DexImport("glTexEnvx", "(III)V", AccessFlags = 1025)]
				void GlTexEnvx(int target, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(II[II)V", AccessFlags = 1025)]
				void GlTexEnvxv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexEnvxv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenf
				/// </java-name>
				[Dot42.DexImport("glTexGenf", "(IIF)V", AccessFlags = 1025)]
				void GlTexGenf(int coord, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenfv
				/// </java-name>
				[Dot42.DexImport("glTexGenfv", "(II[FI)V", AccessFlags = 1025)]
				void GlTexGenfv(int coord, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenfv
				/// </java-name>
				[Dot42.DexImport("glTexGenfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlTexGenfv(int coord, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGeni
				/// </java-name>
				[Dot42.DexImport("glTexGeni", "(III)V", AccessFlags = 1025)]
				void GlTexGeni(int coord, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGeniv
				/// </java-name>
				[Dot42.DexImport("glTexGeniv", "(II[II)V", AccessFlags = 1025)]
				void GlTexGeniv(int coord, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGeniv
				/// </java-name>
				[Dot42.DexImport("glTexGeniv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexGeniv(int coord, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenx
				/// </java-name>
				[Dot42.DexImport("glTexGenx", "(III)V", AccessFlags = 1025)]
				void GlTexGenx(int coord, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenxv
				/// </java-name>
				[Dot42.DexImport("glTexGenxv", "(II[II)V", AccessFlags = 1025)]
				void GlTexGenxv(int coord, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexGenxv
				/// </java-name>
				[Dot42.DexImport("glTexGenxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexGenxv(int coord, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterf
				/// </java-name>
				[Dot42.DexImport("glTexParameterf", "(IIF)V", AccessFlags = 1025)]
				void GlTexParameterf(int target, int pname, float param) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IGL11Constants
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
		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11", AccessFlags = 1537)]
		public partial interface IGL11 : global::Javax.Microedition.Khronos.Opengles.IGL10
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// glGetPointerv
				/// </java-name>
				[Dot42.DexImport("glGetPointerv", "(I[Ljava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlGetPointerv(int pname, global::Java.Nio.Buffer[] @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBindBuffer
				/// </java-name>
				[Dot42.DexImport("glBindBuffer", "(II)V", AccessFlags = 1025)]
				void GlBindBuffer(int target, int buffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBufferData
				/// </java-name>
				[Dot42.DexImport("glBufferData", "(IILjava/nio/Buffer;I)V", AccessFlags = 1025)]
				void GlBufferData(int target, int size, global::Java.Nio.Buffer data, int usage) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBufferSubData
				/// </java-name>
				[Dot42.DexImport("glBufferSubData", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlBufferSubData(int target, int offset, int size, global::Java.Nio.Buffer data) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClipPlanef
				/// </java-name>
				[Dot42.DexImport("glClipPlanef", "(I[FI)V", AccessFlags = 1025)]
				void GlClipPlanef(int plane, float[] equation, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClipPlanef
				/// </java-name>
				[Dot42.DexImport("glClipPlanef", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlClipPlanef(int plane, global::Java.Nio.FloatBuffer equation) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClipPlanex
				/// </java-name>
				[Dot42.DexImport("glClipPlanex", "(I[II)V", AccessFlags = 1025)]
				void GlClipPlanex(int plane, int[] equation, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClipPlanex
				/// </java-name>
				[Dot42.DexImport("glClipPlanex", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlClipPlanex(int plane, global::Java.Nio.IntBuffer equation) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColor4ub
				/// </java-name>
				[Dot42.DexImport("glColor4ub", "(BBBB)V", AccessFlags = 1025)]
				void GlColor4ub(sbyte red, sbyte green, sbyte blue, sbyte alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColorPointer
				/// </java-name>
				[Dot42.DexImport("glColorPointer", "(IIII)V", AccessFlags = 1025)]
				void GlColorPointer(int size, int type, int stride, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(I[II)V", AccessFlags = 1025)]
				void GlDeleteBuffers(int n, int[] buffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteBuffers
				/// </java-name>
				[Dot42.DexImport("glDeleteBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDeleteBuffers(int n, global::Java.Nio.IntBuffer buffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIII)V", AccessFlags = 1025)]
				void GlDrawElements(int mode, int count, int type, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(I[II)V", AccessFlags = 1025)]
				void GlGenBuffers(int n, int[] buffers, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenBuffers
				/// </java-name>
				[Dot42.DexImport("glGenBuffers", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGenBuffers(int n, global::Java.Nio.IntBuffer buffers) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(I[ZI)V", AccessFlags = 1025)]
				void GlGetBooleanv(int pname, bool[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetBooleanv
				/// </java-name>
				[Dot42.DexImport("glGetBooleanv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetBooleanv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(II[II)V", AccessFlags = 1025)]
				void GlGetBufferParameteriv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetBufferParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetBufferParameteriv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetClipPlanef
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanef", "(I[FI)V", AccessFlags = 1025)]
				void GlGetClipPlanef(int pname, float[] eqn, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetClipPlanef
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetClipPlanef(int pname, global::Java.Nio.FloatBuffer eqn) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetClipPlanex
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanex", "(I[II)V", AccessFlags = 1025)]
				void GlGetClipPlanex(int pname, int[] eqn, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetClipPlanex
				/// </java-name>
				[Dot42.DexImport("glGetClipPlanex", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetClipPlanex(int pname, global::Java.Nio.IntBuffer eqn) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFixedv
				/// </java-name>
				[Dot42.DexImport("glGetFixedv", "(I[II)V", AccessFlags = 1025)]
				void GlGetFixedv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFixedv
				/// </java-name>
				[Dot42.DexImport("glGetFixedv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetFixedv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(I[FI)V", AccessFlags = 1025)]
				void GlGetFloatv(int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetFloatv
				/// </java-name>
				[Dot42.DexImport("glGetFloatv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetFloatv(int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetLightfv
				/// </java-name>
				[Dot42.DexImport("glGetLightfv", "(II[FI)V", AccessFlags = 1025)]
				void GlGetLightfv(int light, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetLightfv
				/// </java-name>
				[Dot42.DexImport("glGetLightfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetLightfv(int light, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetLightxv
				/// </java-name>
				[Dot42.DexImport("glGetLightxv", "(II[II)V", AccessFlags = 1025)]
				void GlGetLightxv(int light, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetLightxv
				/// </java-name>
				[Dot42.DexImport("glGetLightxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetLightxv(int light, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetMaterialfv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialfv", "(II[FI)V", AccessFlags = 1025)]
				void GlGetMaterialfv(int face, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetMaterialfv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetMaterialfv(int face, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetMaterialxv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxv", "(II[II)V", AccessFlags = 1025)]
				void GlGetMaterialxv(int face, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetMaterialxv
				/// </java-name>
				[Dot42.DexImport("glGetMaterialxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetMaterialxv(int face, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexEnviv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnviv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexEnviv(int env, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexEnviv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnviv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexEnviv(int env, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexEnvxv(int env, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexEnvxv(int env, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(II[FI)V", AccessFlags = 1025)]
				void GlGetTexParameterfv(int target, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlGetTexParameterfv(int target, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexParameteriv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexParameteriv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxv", "(II[II)V", AccessFlags = 1025)]
				void GlGetTexParameterxv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetTexParameterxv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glIsBuffer
				/// </java-name>
				[Dot42.DexImport("glIsBuffer", "(I)Z", AccessFlags = 1025)]
				bool GlIsBuffer(int buffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glIsEnabled
				/// </java-name>
				[Dot42.DexImport("glIsEnabled", "(I)Z", AccessFlags = 1025)]
				bool GlIsEnabled(int cap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glIsTexture
				/// </java-name>
				[Dot42.DexImport("glIsTexture", "(I)Z", AccessFlags = 1025)]
				bool GlIsTexture(int texture) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glNormalPointer
				/// </java-name>
				[Dot42.DexImport("glNormalPointer", "(III)V", AccessFlags = 1025)]
				void GlNormalPointer(int type, int stride, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterf
				/// </java-name>
				[Dot42.DexImport("glPointParameterf", "(IF)V", AccessFlags = 1025)]
				void GlPointParameterf(int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterfv
				/// </java-name>
				[Dot42.DexImport("glPointParameterfv", "(I[FI)V", AccessFlags = 1025)]
				void GlPointParameterfv(int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterfv
				/// </java-name>
				[Dot42.DexImport("glPointParameterfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlPointParameterfv(int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterx
				/// </java-name>
				[Dot42.DexImport("glPointParameterx", "(II)V", AccessFlags = 1025)]
				void GlPointParameterx(int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterxv
				/// </java-name>
				[Dot42.DexImport("glPointParameterxv", "(I[II)V", AccessFlags = 1025)]
				void GlPointParameterxv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointParameterxv
				/// </java-name>
				[Dot42.DexImport("glPointParameterxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlPointParameterxv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointSizePointerOES
				/// </java-name>
				[Dot42.DexImport("glPointSizePointerOES", "(IILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlPointSizePointerOES(int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexCoordPointer
				/// </java-name>
				[Dot42.DexImport("glTexCoordPointer", "(IIII)V", AccessFlags = 1025)]
				void GlTexCoordPointer(int size, int type, int stride, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvi
				/// </java-name>
				[Dot42.DexImport("glTexEnvi", "(III)V", AccessFlags = 1025)]
				void GlTexEnvi(int target, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnviv
				/// </java-name>
				[Dot42.DexImport("glTexEnviv", "(II[II)V", AccessFlags = 1025)]
				void GlTexEnviv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnviv
				/// </java-name>
				[Dot42.DexImport("glTexEnviv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexEnviv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(II[FI)V", AccessFlags = 1025)]
				void GlTexParameterfv(int target, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlTexParameterfv(int target, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameteri
				/// </java-name>
				[Dot42.DexImport("glTexParameteri", "(III)V", AccessFlags = 1025)]
				void GlTexParameteri(int target, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(II[II)V", AccessFlags = 1025)]
				void GlTexParameteriv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameteriv
				/// </java-name>
				[Dot42.DexImport("glTexParameteriv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexParameteriv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glTexParameterxv", "(II[II)V", AccessFlags = 1025)]
				void GlTexParameterxv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterxv
				/// </java-name>
				[Dot42.DexImport("glTexParameterxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexParameterxv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glVertexPointer
				/// </java-name>
				[Dot42.DexImport("glVertexPointer", "(IIII)V", AccessFlags = 1025)]
				void GlVertexPointer(int size, int type, int stride, int offset) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL10
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL10", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IGL10Constants
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
		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL10
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL10", AccessFlags = 1537)]
		public partial interface IGL10 : global::Javax.Microedition.Khronos.Opengles.IGL
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// glActiveTexture
				/// </java-name>
				[Dot42.DexImport("glActiveTexture", "(I)V", AccessFlags = 1025)]
				void GlActiveTexture(int texture) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glAlphaFunc
				/// </java-name>
				[Dot42.DexImport("glAlphaFunc", "(IF)V", AccessFlags = 1025)]
				void GlAlphaFunc(int func, float @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glAlphaFuncx
				/// </java-name>
				[Dot42.DexImport("glAlphaFuncx", "(II)V", AccessFlags = 1025)]
				void GlAlphaFuncx(int func, int @ref) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBindTexture
				/// </java-name>
				[Dot42.DexImport("glBindTexture", "(II)V", AccessFlags = 1025)]
				void GlBindTexture(int target, int texture) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glBlendFunc
				/// </java-name>
				[Dot42.DexImport("glBlendFunc", "(II)V", AccessFlags = 1025)]
				void GlBlendFunc(int sfactor, int dfactor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClear
				/// </java-name>
				[Dot42.DexImport("glClear", "(I)V", AccessFlags = 1025)]
				void GlClear(int mask) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClearColor
				/// </java-name>
				[Dot42.DexImport("glClearColor", "(FFFF)V", AccessFlags = 1025)]
				void GlClearColor(float red, float green, float blue, float alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClearColorx
				/// </java-name>
				[Dot42.DexImport("glClearColorx", "(IIII)V", AccessFlags = 1025)]
				void GlClearColorx(int red, int green, int blue, int alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClearDepthf
				/// </java-name>
				[Dot42.DexImport("glClearDepthf", "(F)V", AccessFlags = 1025)]
				void GlClearDepthf(float depth) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClearDepthx
				/// </java-name>
				[Dot42.DexImport("glClearDepthx", "(I)V", AccessFlags = 1025)]
				void GlClearDepthx(int depth) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClearStencil
				/// </java-name>
				[Dot42.DexImport("glClearStencil", "(I)V", AccessFlags = 1025)]
				void GlClearStencil(int s) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glClientActiveTexture
				/// </java-name>
				[Dot42.DexImport("glClientActiveTexture", "(I)V", AccessFlags = 1025)]
				void GlClientActiveTexture(int texture) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColor4f
				/// </java-name>
				[Dot42.DexImport("glColor4f", "(FFFF)V", AccessFlags = 1025)]
				void GlColor4f(float red, float green, float blue, float alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColor4x
				/// </java-name>
				[Dot42.DexImport("glColor4x", "(IIII)V", AccessFlags = 1025)]
				void GlColor4x(int red, int green, int blue, int alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColorMask
				/// </java-name>
				[Dot42.DexImport("glColorMask", "(ZZZZ)V", AccessFlags = 1025)]
				void GlColorMask(bool red, bool green, bool blue, bool alpha) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glColorPointer
				/// </java-name>
				[Dot42.DexImport("glColorPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlColorPointer(int size, int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCompressedTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, global::Java.Nio.Buffer data) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCompressedTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, global::Java.Nio.Buffer data) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCopyTexImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexImage2D", "(IIIIIIII)V", AccessFlags = 1025)]
				void GlCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCopyTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glCopyTexSubImage2D", "(IIIIIIII)V", AccessFlags = 1025)]
				void GlCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCullFace
				/// </java-name>
				[Dot42.DexImport("glCullFace", "(I)V", AccessFlags = 1025)]
				void GlCullFace(int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(I[II)V", AccessFlags = 1025)]
				void GlDeleteTextures(int n, int[] textures, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDeleteTextures
				/// </java-name>
				[Dot42.DexImport("glDeleteTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDeleteTextures(int n, global::Java.Nio.IntBuffer textures) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDepthFunc
				/// </java-name>
				[Dot42.DexImport("glDepthFunc", "(I)V", AccessFlags = 1025)]
				void GlDepthFunc(int func) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDepthMask
				/// </java-name>
				[Dot42.DexImport("glDepthMask", "(Z)V", AccessFlags = 1025)]
				void GlDepthMask(bool flag) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDepthRangef
				/// </java-name>
				[Dot42.DexImport("glDepthRangef", "(FF)V", AccessFlags = 1025)]
				void GlDepthRangef(float zNear, float zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDepthRangex
				/// </java-name>
				[Dot42.DexImport("glDepthRangex", "(II)V", AccessFlags = 1025)]
				void GlDepthRangex(int zNear, int zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDisable
				/// </java-name>
				[Dot42.DexImport("glDisable", "(I)V", AccessFlags = 1025)]
				void GlDisable(int cap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDisableClientState
				/// </java-name>
				[Dot42.DexImport("glDisableClientState", "(I)V", AccessFlags = 1025)]
				void GlDisableClientState(int array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawArrays
				/// </java-name>
				[Dot42.DexImport("glDrawArrays", "(III)V", AccessFlags = 1025)]
				void GlDrawArrays(int mode, int first, int count) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawElements
				/// </java-name>
				[Dot42.DexImport("glDrawElements", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlDrawElements(int mode, int count, int type, global::Java.Nio.Buffer indices) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glEnable
				/// </java-name>
				[Dot42.DexImport("glEnable", "(I)V", AccessFlags = 1025)]
				void GlEnable(int cap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glEnableClientState
				/// </java-name>
				[Dot42.DexImport("glEnableClientState", "(I)V", AccessFlags = 1025)]
				void GlEnableClientState(int array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFinish
				/// </java-name>
				[Dot42.DexImport("glFinish", "()V", AccessFlags = 1025)]
				void GlFinish() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFlush
				/// </java-name>
				[Dot42.DexImport("glFlush", "()V", AccessFlags = 1025)]
				void GlFlush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogf
				/// </java-name>
				[Dot42.DexImport("glFogf", "(IF)V", AccessFlags = 1025)]
				void GlFogf(int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogfv
				/// </java-name>
				[Dot42.DexImport("glFogfv", "(I[FI)V", AccessFlags = 1025)]
				void GlFogfv(int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogfv
				/// </java-name>
				[Dot42.DexImport("glFogfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlFogfv(int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogx
				/// </java-name>
				[Dot42.DexImport("glFogx", "(II)V", AccessFlags = 1025)]
				void GlFogx(int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogxv
				/// </java-name>
				[Dot42.DexImport("glFogxv", "(I[II)V", AccessFlags = 1025)]
				void GlFogxv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFogxv
				/// </java-name>
				[Dot42.DexImport("glFogxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlFogxv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFrontFace
				/// </java-name>
				[Dot42.DexImport("glFrontFace", "(I)V", AccessFlags = 1025)]
				void GlFrontFace(int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFrustumf
				/// </java-name>
				[Dot42.DexImport("glFrustumf", "(FFFFFF)V", AccessFlags = 1025)]
				void GlFrustumf(float left, float right, float bottom, float top, float zNear, float zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glFrustumx
				/// </java-name>
				[Dot42.DexImport("glFrustumx", "(IIIIII)V", AccessFlags = 1025)]
				void GlFrustumx(int left, int right, int bottom, int top, int zNear, int zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(I[II)V", AccessFlags = 1025)]
				void GlGenTextures(int n, int[] textures, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGenTextures
				/// </java-name>
				[Dot42.DexImport("glGenTextures", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGenTextures(int n, global::Java.Nio.IntBuffer textures) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetError
				/// </java-name>
				[Dot42.DexImport("glGetError", "()I", AccessFlags = 1025)]
				int GlGetError() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(I[II)V", AccessFlags = 1025)]
				void GlGetIntegerv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetIntegerv
				/// </java-name>
				[Dot42.DexImport("glGetIntegerv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlGetIntegerv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glGetString
				/// </java-name>
				[Dot42.DexImport("glGetString", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GlGetString(int name) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glHint
				/// </java-name>
				[Dot42.DexImport("glHint", "(II)V", AccessFlags = 1025)]
				void GlHint(int target, int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelf
				/// </java-name>
				[Dot42.DexImport("glLightModelf", "(IF)V", AccessFlags = 1025)]
				void GlLightModelf(int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelfv
				/// </java-name>
				[Dot42.DexImport("glLightModelfv", "(I[FI)V", AccessFlags = 1025)]
				void GlLightModelfv(int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelfv
				/// </java-name>
				[Dot42.DexImport("glLightModelfv", "(ILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlLightModelfv(int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelx
				/// </java-name>
				[Dot42.DexImport("glLightModelx", "(II)V", AccessFlags = 1025)]
				void GlLightModelx(int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelxv
				/// </java-name>
				[Dot42.DexImport("glLightModelxv", "(I[II)V", AccessFlags = 1025)]
				void GlLightModelxv(int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightModelxv
				/// </java-name>
				[Dot42.DexImport("glLightModelxv", "(ILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlLightModelxv(int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightf
				/// </java-name>
				[Dot42.DexImport("glLightf", "(IIF)V", AccessFlags = 1025)]
				void GlLightf(int light, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightfv
				/// </java-name>
				[Dot42.DexImport("glLightfv", "(II[FI)V", AccessFlags = 1025)]
				void GlLightfv(int light, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightfv
				/// </java-name>
				[Dot42.DexImport("glLightfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlLightfv(int light, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightx
				/// </java-name>
				[Dot42.DexImport("glLightx", "(III)V", AccessFlags = 1025)]
				void GlLightx(int light, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightxv
				/// </java-name>
				[Dot42.DexImport("glLightxv", "(II[II)V", AccessFlags = 1025)]
				void GlLightxv(int light, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLightxv
				/// </java-name>
				[Dot42.DexImport("glLightxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlLightxv(int light, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLineWidth
				/// </java-name>
				[Dot42.DexImport("glLineWidth", "(F)V", AccessFlags = 1025)]
				void GlLineWidth(float width) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLineWidthx
				/// </java-name>
				[Dot42.DexImport("glLineWidthx", "(I)V", AccessFlags = 1025)]
				void GlLineWidthx(int width) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadIdentity
				/// </java-name>
				[Dot42.DexImport("glLoadIdentity", "()V", AccessFlags = 1025)]
				void GlLoadIdentity() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadMatrixf
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixf", "([FI)V", AccessFlags = 1025)]
				void GlLoadMatrixf(float[] m, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadMatrixf
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlLoadMatrixf(global::Java.Nio.FloatBuffer m) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadMatrixx
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixx", "([II)V", AccessFlags = 1025)]
				void GlLoadMatrixx(int[] m, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadMatrixx
				/// </java-name>
				[Dot42.DexImport("glLoadMatrixx", "(Ljava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlLoadMatrixx(global::Java.Nio.IntBuffer m) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLogicOp
				/// </java-name>
				[Dot42.DexImport("glLogicOp", "(I)V", AccessFlags = 1025)]
				void GlLogicOp(int opcode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialf
				/// </java-name>
				[Dot42.DexImport("glMaterialf", "(IIF)V", AccessFlags = 1025)]
				void GlMaterialf(int face, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialfv
				/// </java-name>
				[Dot42.DexImport("glMaterialfv", "(II[FI)V", AccessFlags = 1025)]
				void GlMaterialfv(int face, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialfv
				/// </java-name>
				[Dot42.DexImport("glMaterialfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlMaterialfv(int face, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialx
				/// </java-name>
				[Dot42.DexImport("glMaterialx", "(III)V", AccessFlags = 1025)]
				void GlMaterialx(int face, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialxv
				/// </java-name>
				[Dot42.DexImport("glMaterialxv", "(II[II)V", AccessFlags = 1025)]
				void GlMaterialxv(int face, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMaterialxv
				/// </java-name>
				[Dot42.DexImport("glMaterialxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlMaterialxv(int face, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMatrixMode
				/// </java-name>
				[Dot42.DexImport("glMatrixMode", "(I)V", AccessFlags = 1025)]
				void GlMatrixMode(int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultMatrixf
				/// </java-name>
				[Dot42.DexImport("glMultMatrixf", "([FI)V", AccessFlags = 1025)]
				void GlMultMatrixf(float[] m, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultMatrixf
				/// </java-name>
				[Dot42.DexImport("glMultMatrixf", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlMultMatrixf(global::Java.Nio.FloatBuffer m) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultMatrixx
				/// </java-name>
				[Dot42.DexImport("glMultMatrixx", "([II)V", AccessFlags = 1025)]
				void GlMultMatrixx(int[] m, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultMatrixx
				/// </java-name>
				[Dot42.DexImport("glMultMatrixx", "(Ljava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlMultMatrixx(global::Java.Nio.IntBuffer m) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultiTexCoord4f
				/// </java-name>
				[Dot42.DexImport("glMultiTexCoord4f", "(IFFFF)V", AccessFlags = 1025)]
				void GlMultiTexCoord4f(int target, float s, float t, float r, float q) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMultiTexCoord4x
				/// </java-name>
				[Dot42.DexImport("glMultiTexCoord4x", "(IIIII)V", AccessFlags = 1025)]
				void GlMultiTexCoord4x(int target, int s, int t, int r, int q) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glNormal3f
				/// </java-name>
				[Dot42.DexImport("glNormal3f", "(FFF)V", AccessFlags = 1025)]
				void GlNormal3f(float nx, float ny, float nz) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glNormal3x
				/// </java-name>
				[Dot42.DexImport("glNormal3x", "(III)V", AccessFlags = 1025)]
				void GlNormal3x(int nx, int ny, int nz) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glNormalPointer
				/// </java-name>
				[Dot42.DexImport("glNormalPointer", "(IILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlNormalPointer(int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glOrthof
				/// </java-name>
				[Dot42.DexImport("glOrthof", "(FFFFFF)V", AccessFlags = 1025)]
				void GlOrthof(float left, float right, float bottom, float top, float zNear, float zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glOrthox
				/// </java-name>
				[Dot42.DexImport("glOrthox", "(IIIIII)V", AccessFlags = 1025)]
				void GlOrthox(int left, int right, int bottom, int top, int zNear, int zFar) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPixelStorei
				/// </java-name>
				[Dot42.DexImport("glPixelStorei", "(II)V", AccessFlags = 1025)]
				void GlPixelStorei(int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointSize
				/// </java-name>
				[Dot42.DexImport("glPointSize", "(F)V", AccessFlags = 1025)]
				void GlPointSize(float size) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPointSizex
				/// </java-name>
				[Dot42.DexImport("glPointSizex", "(I)V", AccessFlags = 1025)]
				void GlPointSizex(int size) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPolygonOffset
				/// </java-name>
				[Dot42.DexImport("glPolygonOffset", "(FF)V", AccessFlags = 1025)]
				void GlPolygonOffset(float factor, float units) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPolygonOffsetx
				/// </java-name>
				[Dot42.DexImport("glPolygonOffsetx", "(II)V", AccessFlags = 1025)]
				void GlPolygonOffsetx(int factor, int units) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPopMatrix
				/// </java-name>
				[Dot42.DexImport("glPopMatrix", "()V", AccessFlags = 1025)]
				void GlPopMatrix() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glPushMatrix
				/// </java-name>
				[Dot42.DexImport("glPushMatrix", "()V", AccessFlags = 1025)]
				void GlPushMatrix() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glReadPixels
				/// </java-name>
				[Dot42.DexImport("glReadPixels", "(IIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlReadPixels(int x, int y, int width, int height, int format, int type, global::Java.Nio.Buffer pixels) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glRotatef
				/// </java-name>
				[Dot42.DexImport("glRotatef", "(FFFF)V", AccessFlags = 1025)]
				void GlRotatef(float angle, float x, float y, float z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glRotatex
				/// </java-name>
				[Dot42.DexImport("glRotatex", "(IIII)V", AccessFlags = 1025)]
				void GlRotatex(int angle, int x, int y, int z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glSampleCoverage
				/// </java-name>
				[Dot42.DexImport("glSampleCoverage", "(FZ)V", AccessFlags = 1025)]
				void GlSampleCoverage(float value, bool invert) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glSampleCoveragex
				/// </java-name>
				[Dot42.DexImport("glSampleCoveragex", "(IZ)V", AccessFlags = 1025)]
				void GlSampleCoveragex(int value, bool invert) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glScalef
				/// </java-name>
				[Dot42.DexImport("glScalef", "(FFF)V", AccessFlags = 1025)]
				void GlScalef(float x, float y, float z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glScalex
				/// </java-name>
				[Dot42.DexImport("glScalex", "(III)V", AccessFlags = 1025)]
				void GlScalex(int x, int y, int z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glScissor
				/// </java-name>
				[Dot42.DexImport("glScissor", "(IIII)V", AccessFlags = 1025)]
				void GlScissor(int x, int y, int width, int height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glShadeModel
				/// </java-name>
				[Dot42.DexImport("glShadeModel", "(I)V", AccessFlags = 1025)]
				void GlShadeModel(int mode) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glStencilFunc
				/// </java-name>
				[Dot42.DexImport("glStencilFunc", "(III)V", AccessFlags = 1025)]
				void GlStencilFunc(int func, int @ref, int mask) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glStencilMask
				/// </java-name>
				[Dot42.DexImport("glStencilMask", "(I)V", AccessFlags = 1025)]
				void GlStencilMask(int mask) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glStencilOp
				/// </java-name>
				[Dot42.DexImport("glStencilOp", "(III)V", AccessFlags = 1025)]
				void GlStencilOp(int fail, int zfail, int zpass) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexCoordPointer
				/// </java-name>
				[Dot42.DexImport("glTexCoordPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlTexCoordPointer(int size, int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvf
				/// </java-name>
				[Dot42.DexImport("glTexEnvf", "(IIF)V", AccessFlags = 1025)]
				void GlTexEnvf(int target, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(II[FI)V", AccessFlags = 1025)]
				void GlTexEnvfv(int target, int pname, float[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvfv
				/// </java-name>
				[Dot42.DexImport("glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlTexEnvfv(int target, int pname, global::Java.Nio.FloatBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvx
				/// </java-name>
				[Dot42.DexImport("glTexEnvx", "(III)V", AccessFlags = 1025)]
				void GlTexEnvx(int target, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(II[II)V", AccessFlags = 1025)]
				void GlTexEnvxv(int target, int pname, int[] @params, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexEnvxv
				/// </java-name>
				[Dot42.DexImport("glTexEnvxv", "(IILjava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlTexEnvxv(int target, int pname, global::Java.Nio.IntBuffer @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexImage2D
				/// </java-name>
				[Dot42.DexImport("glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, global::Java.Nio.Buffer pixels) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterf
				/// </java-name>
				[Dot42.DexImport("glTexParameterf", "(IIF)V", AccessFlags = 1025)]
				void GlTexParameterf(int target, int pname, float param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexParameterx
				/// </java-name>
				[Dot42.DexImport("glTexParameterx", "(III)V", AccessFlags = 1025)]
				void GlTexParameterx(int target, int pname, int param) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTexSubImage2D
				/// </java-name>
				[Dot42.DexImport("glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, global::Java.Nio.Buffer pixels) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTranslatef
				/// </java-name>
				[Dot42.DexImport("glTranslatef", "(FFF)V", AccessFlags = 1025)]
				void GlTranslatef(float x, float y, float z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glTranslatex
				/// </java-name>
				[Dot42.DexImport("glTranslatex", "(III)V", AccessFlags = 1025)]
				void GlTranslatex(int x, int y, int z) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glVertexPointer
				/// </java-name>
				[Dot42.DexImport("glVertexPointer", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlVertexPointer(int size, int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glViewport
				/// </java-name>
				[Dot42.DexImport("glViewport", "(IIII)V", AccessFlags = 1025)]
				void GlViewport(int x, int y, int width, int height) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11Ext
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11Ext", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IGL11ExtConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 35742;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_OES = 34884;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_POINTER_OES = 34889;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_SIZE_OES = 34886;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_STRIDE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_STRIDE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 34888;
				/// <java-name>
				/// GL_MATRIX_INDEX_ARRAY_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_INDEX_ARRAY_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_INDEX_ARRAY_TYPE_OES = 34887;
				/// <java-name>
				/// GL_MATRIX_PALETTE_OES
				/// </java-name>
				[Dot42.DexImport("GL_MATRIX_PALETTE_OES", "I", AccessFlags = 25)]
				public const int GL_MATRIX_PALETTE_OES = 34880;
				/// <java-name>
				/// GL_MAX_PALETTE_MATRICES_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_PALETTE_MATRICES_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_PALETTE_MATRICES_OES = 34882;
				/// <java-name>
				/// GL_MAX_VERTEX_UNITS_OES
				/// </java-name>
				[Dot42.DexImport("GL_MAX_VERTEX_UNITS_OES", "I", AccessFlags = 25)]
				public const int GL_MAX_VERTEX_UNITS_OES = 34468;
				/// <java-name>
				/// GL_TEXTURE_CROP_RECT_OES
				/// </java-name>
				[Dot42.DexImport("GL_TEXTURE_CROP_RECT_OES", "I", AccessFlags = 25)]
				public const int GL_TEXTURE_CROP_RECT_OES = 35741;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_BUFFER_BINDING_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 34974;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_OES = 34477;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_POINTER_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_POINTER_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_POINTER_OES = 34476;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_SIZE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_SIZE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_SIZE_OES = 34475;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_STRIDE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_STRIDE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_STRIDE_OES = 34474;
				/// <java-name>
				/// GL_WEIGHT_ARRAY_TYPE_OES
				/// </java-name>
				[Dot42.DexImport("GL_WEIGHT_ARRAY_TYPE_OES", "I", AccessFlags = 25)]
				public const int GL_WEIGHT_ARRAY_TYPE_OES = 34473;
		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL11Ext
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL11Ext", AccessFlags = 1537)]
		public partial interface IGL11Ext : global::Javax.Microedition.Khronos.Opengles.IGL
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// glTexParameterfv
				/// </java-name>
				[Dot42.DexImport("glTexParameterfv", "(II[FI)V", AccessFlags = 1025)]
				void GlTexParameterfv(int target, int pname, float[] param, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glCurrentPaletteMatrixOES
				/// </java-name>
				[Dot42.DexImport("glCurrentPaletteMatrixOES", "(I)V", AccessFlags = 1025)]
				void GlCurrentPaletteMatrixOES(int matrixpaletteindex) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexfOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfOES", "(FFFFF)V", AccessFlags = 1025)]
				void GlDrawTexfOES(float x, float y, float z, float width, float height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexfvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfvOES", "([FI)V", AccessFlags = 1025)]
				void GlDrawTexfvOES(float[] coords, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexfvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V", AccessFlags = 1025)]
				void GlDrawTexfvOES(global::Java.Nio.FloatBuffer coords) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexiOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexiOES", "(IIIII)V", AccessFlags = 1025)]
				void GlDrawTexiOES(int x, int y, int z, int width, int height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexivOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexivOES", "([II)V", AccessFlags = 1025)]
				void GlDrawTexivOES(int[] coords, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexivOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexivOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDrawTexivOES(global::Java.Nio.IntBuffer coords) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexsOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsOES", "(SSSSS)V", AccessFlags = 1025)]
				void GlDrawTexsOES(short x, short y, short z, short width, short height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexsvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsvOES", "([SI)V", AccessFlags = 1025)]
				void GlDrawTexsvOES(short[] coords, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexsvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V", AccessFlags = 1025)]
				void GlDrawTexsvOES(global::Java.Nio.ShortBuffer coords) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexxOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxOES", "(IIIII)V", AccessFlags = 1025)]
				void GlDrawTexxOES(int x, int y, int z, int width, int height) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexxvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxvOES", "([II)V", AccessFlags = 1025)]
				void GlDrawTexxvOES(int[] coords, int offset) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glDrawTexxvOES
				/// </java-name>
				[Dot42.DexImport("glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V", AccessFlags = 1025)]
				void GlDrawTexxvOES(global::Java.Nio.IntBuffer coords) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glEnable
				/// </java-name>
				[Dot42.DexImport("glEnable", "(I)V", AccessFlags = 1025)]
				void GlEnable(int cap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glEnableClientState
				/// </java-name>
				[Dot42.DexImport("glEnableClientState", "(I)V", AccessFlags = 1025)]
				void GlEnableClientState(int array) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glLoadPaletteFromModelViewMatrixOES
				/// </java-name>
				[Dot42.DexImport("glLoadPaletteFromModelViewMatrixOES", "()V", AccessFlags = 1025)]
				void GlLoadPaletteFromModelViewMatrixOES() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMatrixIndexPointerOES
				/// </java-name>
				[Dot42.DexImport("glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlMatrixIndexPointerOES(int size, int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glMatrixIndexPointerOES
				/// </java-name>
				[Dot42.DexImport("glMatrixIndexPointerOES", "(IIII)V", AccessFlags = 1025)]
				void GlMatrixIndexPointerOES(int size, int type, int stride, int pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glWeightPointerOES
				/// </java-name>
				[Dot42.DexImport("glWeightPointerOES", "(IIILjava/nio/Buffer;)V", AccessFlags = 1025)]
				void GlWeightPointerOES(int size, int type, int stride, global::Java.Nio.Buffer pointer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// glWeightPointerOES
				/// </java-name>
				[Dot42.DexImport("glWeightPointerOES", "(IIII)V", AccessFlags = 1025)]
				void GlWeightPointerOES(int size, int type, int stride, int pointer) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/microedition/khronos/opengles/GL
		/// </java-name>
		[Dot42.DexImport("javax/microedition/khronos/opengles/GL", AccessFlags = 1537)]
		public partial interface IGL
 /* scope: __dot42__ */ 
		{
		}

}


