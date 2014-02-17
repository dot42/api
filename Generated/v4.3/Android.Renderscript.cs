// Copyright (C) 2014 dot42
//
// Original filename: Android.Renderscript.cs
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
namespace Android.Renderscript
{
		/// <summary>
		/// <para>Class for exposing the native RenderScript rs_matrix4x4 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix4f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix4f", AccessFlags = 33)]
		public partial class Matrix4f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new identity 4x4 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix4f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new matrix and sets its values from the given parameter</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix4f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				/// <para>Returns the value for a given row and column</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>value in the yth row and xth column </para>
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
				/// <para>Sets the value for a given row and column</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values of the matrix to those of the parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix4f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a rotation matrix of certain angle about a given axis</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a translation matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be the result of multiplying two given matrices</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix4f;Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix4f lhs, global::Android.Renderscript.Matrix4f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set current values to be an orthographic projection matrix</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadOrtho
				/// </java-name>
				[Dot42.DexImport("loadOrtho", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadOrtho(float l, float r, float b, float t, float n, float f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set current values to be an orthographic projection matrix with the right and bottom clipping planes set to the given values. Left and top clipping planes are set to 0. Near and far are set to -1, 1 respectively</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadOrthoWindow
				/// </java-name>
				[Dot42.DexImport("loadOrthoWindow", "(II)V", AccessFlags = 1)]
				public virtual void LoadOrthoWindow(int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a perspective projection matrix</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadFrustum
				/// </java-name>
				[Dot42.DexImport("loadFrustum", "(FFFFFF)V", AccessFlags = 1)]
				public virtual void LoadFrustum(float l, float r, float b, float t, float n, float f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a perspective projection matrix</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadPerspective
				/// </java-name>
				[Dot42.DexImport("loadPerspective", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadPerspective(float fovy, float aspect, float near, float far) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper function to set the current values to a perspective projection matrix with aspect ratio defined by the parameters and (near, far), (bottom, top) mapping to (-1, 1) at z = 0</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadProjectionNormalized
				/// </java-name>
				[Dot42.DexImport("loadProjectionNormalized", "(II)V", AccessFlags = 1)]
				public virtual void LoadProjectionNormalized(int w, int h) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Post-multiplies the current matrix by a given parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix4f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a rotation matrix of certain angle about a given axis</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a translation matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FFF)V", AccessFlags = 1)]
				public virtual void Translate(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the current matrix to its inverse </para>        
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
				/// <para>Sets the current matrix to its inverse transpose </para>        
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
				/// <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <summary>
		/// <para>BaseObj is the base class for all RenderScript objects owned by a RS context. It is responsible for lifetime management and resource tracking. This class should not be used by a user application. </para>    
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

				/// <summary>
				/// <para>setName assigns a name to an object. This object can later be looked up by this name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name of the renderscript object </para>
				/// </returns>
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

				/// <summary>
				/// <para>Frees any native resources associated with this object. The primary use is to force immediate cleanup of resources when it is believed the GC will not respond quickly enough. </para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 33)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Calculates the hash code value for a BaseObj.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
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
				/// <para>Compare the current BaseObj with another BaseObj for equality.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean </para>
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
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name of the renderscript object </para>
				/// </returns>
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

		/// <summary>
		/// <para>A Type describes the android.renderscript.Element and dimensions used for an android.renderscript.Allocation or a parallel operation. Types are created through android.renderscript.Type.Builder.</para><para>A Type always includes an android.renderscript.Element and an X dimension. A Type may be multidimensional, up to three dimensions. A nonzero value in the Y or Z dimensions indicates that the dimension is present. Note that a Type with only a given X dimension and a Type with the same X dimension but Y = 1 are not equivalent.</para><para>A Type also supports inclusion of level of detail (LOD) or cube map faces. LOD and cube map faces are booleans to indicate present or not present. </para><para>A Type also supports YUV format information to support an android.renderscript.Allocation in a YUV format. The YUV formats supported are android.graphics.ImageFormat#YV12 and android.graphics.ImageFormat#NV21.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating an application that uses RenderScript, read the  developer guide.</para><para>  </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Return the element associated with this Type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element GetElement() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Return the value of the X dimension.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()I", AccessFlags = 1)]
				public virtual int GetX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the value of the Y dimension or 0 for a 1D allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()I", AccessFlags = 1)]
				public virtual int GetY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the value of the Z dimension or 0 for a 1D or 2D allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				[Dot42.DexImport("getZ", "()I", AccessFlags = 1)]
				public virtual int GetZ() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the YUV format</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getYuv
				/// </java-name>
				[Dot42.DexImport("getYuv", "()I", AccessFlags = 1)]
				public virtual int GetYuv() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return if the Type has a mipmap chain.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// hasMipmaps
				/// </java-name>
				[Dot42.DexImport("hasMipmaps", "()Z", AccessFlags = 1)]
				public virtual bool HasMipmaps() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return if the Type is a cube map.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// hasFaces
				/// </java-name>
				[Dot42.DexImport("hasFaces", "()Z", AccessFlags = 1)]
				public virtual bool HasFaces() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the total number of accessable cells in the Type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public virtual int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the element associated with this Type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				public global::Android.Renderscript.Element Element
				{
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						get{ return GetElement(); }
				}

				/// <summary>
				/// <para>Return the value of the X dimension.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public int X
				{
				[Dot42.DexImport("getX", "()I", AccessFlags = 1)]
						get{ return GetX(); }
				}

				/// <summary>
				/// <para>Return the value of the Y dimension or 0 for a 1D allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public int Y
				{
				[Dot42.DexImport("getY", "()I", AccessFlags = 1)]
						get{ return GetY(); }
				}

				/// <summary>
				/// <para>Return the value of the Z dimension or 0 for a 1D or 2D allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				public int Z
				{
				[Dot42.DexImport("getZ", "()I", AccessFlags = 1)]
						get{ return GetZ(); }
				}

				/// <summary>
				/// <para>Get the YUV format</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getYuv
				/// </java-name>
				public int Yuv
				{
				[Dot42.DexImport("getYuv", "()I", AccessFlags = 1)]
						get{ return GetYuv(); }
				}

				/// <summary>
				/// <para>Return the total number of accessable cells in the Type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return GetCount(); }
				}

				/// <summary>
				/// <para>Builder class for Type. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Add a dimension to the Type.</para><para></para>        
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
						/// setZ
						/// </java-name>
						[Dot42.DexImport("setZ", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetZ(int value) /* MethodBuilder.Create */ 
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
						/// <para>Set the YUV layout for a Type.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setYuvFormat
						/// </java-name>
						[Dot42.DexImport("setYuvFormat", "(I)Landroid/renderscript/Type$Builder;", AccessFlags = 1)]
						public virtual Builder SetYuvFormat(int yuvFormat) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Validate structure and create a new Type.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Type </para>
						/// </returns>
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

				}

		}

		/// <summary>
		/// <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
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

		/// <summary>
		/// <para>Intrinsic for converting an Android YUV buffer to RGB.</para><para>The input allocation is supplied in NV21 format as a U8 element type. The output is RGBA, the alpha channel will be set to 255. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicYuvToRGB
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicYuvToRGB", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicYuvToRGB : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicYuvToRGB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an intrinsic for converting YUV to RGB.</para><para>Supported elements types are Element#U8_4</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicYuvToRGB </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicYuvToRGB;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicYuvToRGB Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicYuvToRGB);
				}

				/// <summary>
				/// <para>Set the input yuv allocation, must be Element#U8.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscript.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Convert the image to RGB.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.FieldID GetFieldID_Input() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.FieldID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscript.Script.FieldID FieldID_Input
				{
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return GetFieldID_Input(); }
				}

		}

		/// <summary>
		/// <para>Intrinsic kernels for blending two android.renderscript.Allocation objects. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicBlend
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicBlend", AccessFlags = 33)]
		public partial class ScriptIntrinsicBlend : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicBlend() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Supported elements types are Element#U8_4</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicBlend </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicBlend;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicBlend Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicBlend);
				}

				/// <summary>
				/// <para>Sets dst = {0, 0, 0, 0}</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachClear
				/// </java-name>
				[Dot42.DexImport("forEachClear", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachClear(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Clear kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDClear
				/// </java-name>
				[Dot42.DexImport("getKernelIDClear", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDClear() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = src</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrc
				/// </java-name>
				[Dot42.DexImport("forEachSrc", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrc(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Src kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrc
				/// </java-name>
				[Dot42.DexImport("getKernelIDSrc", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSrc() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = dst</para><para>This is a NOP.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDst
				/// </java-name>
				[Dot42.DexImport("forEachDst", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDst(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Dst kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDst
				/// </java-name>
				[Dot42.DexImport("getKernelIDDst", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDDst() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = src + dst * (1.0 - src.a)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcOver
				/// </java-name>
				[Dot42.DexImport("forEachSrcOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcOver(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcOver kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOver
				/// </java-name>
				[Dot42.DexImport("getKernelIDSrcOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSrcOver() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = dst + src * (1.0 - dst.a)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstOver
				/// </java-name>
				[Dot42.DexImport("forEachDstOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstOver(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the DstOver kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOver
				/// </java-name>
				[Dot42.DexImport("getKernelIDDstOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDDstOver() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = src * dst.a</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcIn
				/// </java-name>
				[Dot42.DexImport("forEachSrcIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcIn(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcIn kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcIn
				/// </java-name>
				[Dot42.DexImport("getKernelIDSrcIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSrcIn() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = dst * src.a</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstIn
				/// </java-name>
				[Dot42.DexImport("forEachDstIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstIn(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the DstIn kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstIn
				/// </java-name>
				[Dot42.DexImport("getKernelIDDstIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDDstIn() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = src * (1.0 - dst.a)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcOut
				/// </java-name>
				[Dot42.DexImport("forEachSrcOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcOut(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcOut kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOut
				/// </java-name>
				[Dot42.DexImport("getKernelIDSrcOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSrcOut() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = dst * (1.0 - src.a)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstOut
				/// </java-name>
				[Dot42.DexImport("forEachDstOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstOut(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the DstOut kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOut
				/// </java-name>
				[Dot42.DexImport("getKernelIDDstOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDDstOut() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>dst.rgb = src.rgb * dst.a + (1.0 - src.a) * dst.rgb dst.a = dst.a</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSrcAtop
				/// </java-name>
				[Dot42.DexImport("forEachSrcAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSrcAtop(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcAtop kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcAtop
				/// </java-name>
				[Dot42.DexImport("getKernelIDSrcAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSrcAtop() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>dst = dst.rgb * src.a + (1.0 - dst.a) * src.rgb dst.a = src.a</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachDstAtop
				/// </java-name>
				[Dot42.DexImport("forEachDstAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachDstAtop(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the DstAtop kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstAtop
				/// </java-name>
				[Dot42.DexImport("getKernelIDDstAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDDstAtop() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = {src.r ^ dst.r, src.g ^ dst.g, src.b ^ dst.b, src.a ^ dst.a}</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachXor
				/// </java-name>
				[Dot42.DexImport("forEachXor", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachXor(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Xor kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDXor
				/// </java-name>
				[Dot42.DexImport("getKernelIDXor", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDXor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = src * dst</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachMultiply
				/// </java-name>
				[Dot42.DexImport("forEachMultiply", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachMultiply(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Multiply kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDMultiply
				/// </java-name>
				[Dot42.DexImport("getKernelIDMultiply", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDMultiply() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = min(src + dst, 1.0)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachAdd
				/// </java-name>
				[Dot42.DexImport("forEachAdd", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachAdd(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Add kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDAdd
				/// </java-name>
				[Dot42.DexImport("getKernelIDAdd", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDAdd() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Sets dst = max(dst - src, 0.0)</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEachSubtract
				/// </java-name>
				[Dot42.DexImport("forEachSubtract", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void ForEachSubtract(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for the Subtract kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSubtract
				/// </java-name>
				[Dot42.DexImport("getKernelIDSubtract", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Script.KernelID GetKernelIDSubtract() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a KernelID for the Clear kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDClear
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDClear
				{
				[Dot42.DexImport("getKernelIDClear", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDClear(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Src kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrc
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSrc
				{
				[Dot42.DexImport("getKernelIDSrc", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSrc(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Dst kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDst
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDDst
				{
				[Dot42.DexImport("getKernelIDDst", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDDst(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcOver kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOver
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSrcOver
				{
				[Dot42.DexImport("getKernelIDSrcOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSrcOver(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the DstOver kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOver
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDDstOver
				{
				[Dot42.DexImport("getKernelIDDstOver", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDDstOver(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcIn kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcIn
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSrcIn
				{
				[Dot42.DexImport("getKernelIDSrcIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSrcIn(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the DstIn kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstIn
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDDstIn
				{
				[Dot42.DexImport("getKernelIDDstIn", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDDstIn(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcOut kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcOut
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSrcOut
				{
				[Dot42.DexImport("getKernelIDSrcOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSrcOut(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the DstOut kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstOut
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDDstOut
				{
				[Dot42.DexImport("getKernelIDDstOut", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDDstOut(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the SrcAtop kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSrcAtop
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSrcAtop
				{
				[Dot42.DexImport("getKernelIDSrcAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSrcAtop(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the DstAtop kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDDstAtop
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDDstAtop
				{
				[Dot42.DexImport("getKernelIDDstAtop", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDDstAtop(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Xor kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDXor
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDXor
				{
				[Dot42.DexImport("getKernelIDXor", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDXor(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Multiply kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDMultiply
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDMultiply
				{
				[Dot42.DexImport("getKernelIDMultiply", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDMultiply(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Add kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDAdd
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDAdd
				{
				[Dot42.DexImport("getKernelIDAdd", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDAdd(); }
				}

				/// <summary>
				/// <para>Get a KernelID for the Subtract kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelIDSubtract
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelIDSubtract
				{
				[Dot42.DexImport("getKernelIDSubtract", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelIDSubtract(); }
				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript int2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript long2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript long4 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript Short2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript byte2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript double3 type back to the Android system. </para>    
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
		/// <para>The parent class for all executable scripts. This should not be used by applications. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Only to be used by generated reflected classes. </para>        
				/// </summary>
				/// <java-name>
				/// createKernelID
				/// </java-name>
				[Dot42.DexImport("createKernelID", "(IILandroid/renderscript/Element;Landroid/renderscript/Element;)Landroid/rendersc" +
    "ript/Script$KernelID;", AccessFlags = 4)]
				protected internal virtual global::Android.Renderscript.Script.KernelID CreateKernelID(int slot, int sig, global::Android.Renderscript.Element ein, global::Android.Renderscript.Element eout) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Only to be used by generated reflected classes. </para>        
				/// </summary>
				/// <java-name>
				/// createFieldID
				/// </java-name>
				[Dot42.DexImport("createFieldID", "(ILandroid/renderscript/Element;)Landroid/renderscript/Script$FieldID;", AccessFlags = 4)]
				protected internal virtual global::Android.Renderscript.Script.FieldID CreateFieldID(int slot, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.FieldID);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(I)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// invoke
				/// </java-name>
				[Dot42.DexImport("invoke", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void Invoke(int slot, global::Android.Renderscript.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(ILandroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/rend" +
    "erscript/FieldPacker;)V", AccessFlags = 4)]
				protected internal virtual void ForEach(int slot, global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout, global::Android.Renderscript.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(ILandroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/rend" +
    "erscript/FieldPacker;Landroid/renderscript/Script$LaunchOptions;)V", AccessFlags = 4)]
				protected internal virtual void ForEach(int slot, global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout, global::Android.Renderscript.FieldPacker v, global::Android.Renderscript.Script.LaunchOptions sc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// bindAllocation
				/// </java-name>
				[Dot42.DexImport("bindAllocation", "(Landroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void BindAllocation(global::Android.Renderscript.Allocation va, int slot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IF)V", AccessFlags = 1)]
				public virtual void SetVar(int index, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVarF
				/// </java-name>
				[Dot42.DexImport("getVarF", "(I)F", AccessFlags = 1)]
				public virtual float GetVarF(int index) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ID)V", AccessFlags = 1)]
				public virtual void SetVar(int index, double v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVarD
				/// </java-name>
				[Dot42.DexImport("getVarD", "(I)D", AccessFlags = 1)]
				public virtual double GetVarD(int index) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(II)V", AccessFlags = 1)]
				public virtual void SetVar(int index, int v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVarI
				/// </java-name>
				[Dot42.DexImport("getVarI", "(I)I", AccessFlags = 1)]
				public virtual int GetVarI(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IJ)V", AccessFlags = 1)]
				public virtual void SetVar(int index, long v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVarJ
				/// </java-name>
				[Dot42.DexImport("getVarJ", "(I)J", AccessFlags = 1)]
				public virtual long GetVarJ(int index) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(IZ)V", AccessFlags = 1)]
				public virtual void SetVar(int index, bool v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVarB
				/// </java-name>
				[Dot42.DexImport("getVarB", "(I)Z", AccessFlags = 1)]
				public virtual bool GetVarB(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscript.BaseObj v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscript.FieldPacker v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// setVar
				/// </java-name>
				[Dot42.DexImport("setVar", "(ILandroid/renderscript/FieldPacker;Landroid/renderscript/Element;[I)V", AccessFlags = 1)]
				public virtual void SetVar(int index, global::Android.Renderscript.FieldPacker v, global::Android.Renderscript.Element e, int[] dims) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>        
				/// </summary>
				/// <java-name>
				/// getVarV
				/// </java-name>
				[Dot42.DexImport("getVarV", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void GetVarV(int index, global::Android.Renderscript.FieldPacker v) /* MethodBuilder.Create */ 
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
				/// <para>Class used to specify clipping for a kernel launch. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Script$LaunchOptions
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$LaunchOptions", AccessFlags = 25)]
				public sealed partial class LaunchOptions
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LaunchOptions() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Set the X range. If the end value is set to 0 the X dimension is not clipped.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>LaunchOptions </para>
						/// </returns>
						/// <java-name>
						/// setX
						/// </java-name>
						[Dot42.DexImport("setX", "(II)Landroid/renderscript/Script$LaunchOptions;", AccessFlags = 1)]
						public LaunchOptions SetX(int xstartArg, int xendArg) /* MethodBuilder.Create */ 
						{
								return default(LaunchOptions);
						}

						/// <summary>
						/// <para>Set the Y range. If the end value is set to 0 the Y dimension is not clipped.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>LaunchOptions </para>
						/// </returns>
						/// <java-name>
						/// setY
						/// </java-name>
						[Dot42.DexImport("setY", "(II)Landroid/renderscript/Script$LaunchOptions;", AccessFlags = 1)]
						public LaunchOptions SetY(int ystartArg, int yendArg) /* MethodBuilder.Create */ 
						{
								return default(LaunchOptions);
						}

						/// <summary>
						/// <para>Set the Z range. If the end value is set to 0 the Z dimension is not clipped.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>LaunchOptions </para>
						/// </returns>
						/// <java-name>
						/// setZ
						/// </java-name>
						[Dot42.DexImport("setZ", "(II)Landroid/renderscript/Script$LaunchOptions;", AccessFlags = 1)]
						public LaunchOptions SetZ(int zstartArg, int zendArg) /* MethodBuilder.Create */ 
						{
								return default(LaunchOptions);
						}

						/// <summary>
						/// <para>Returns the current X start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getXStart
						/// </java-name>
						[Dot42.DexImport("getXStart", "()I", AccessFlags = 1)]
						public int GetXStart() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current X end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getXEnd
						/// </java-name>
						[Dot42.DexImport("getXEnd", "()I", AccessFlags = 1)]
						public int GetXEnd() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current Y start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getYStart
						/// </java-name>
						[Dot42.DexImport("getYStart", "()I", AccessFlags = 1)]
						public int GetYStart() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current Y end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getYEnd
						/// </java-name>
						[Dot42.DexImport("getYEnd", "()I", AccessFlags = 1)]
						public int GetYEnd() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current Z start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getZStart
						/// </java-name>
						[Dot42.DexImport("getZStart", "()I", AccessFlags = 1)]
						public int GetZStart() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current Z end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getZEnd
						/// </java-name>
						[Dot42.DexImport("getZEnd", "()I", AccessFlags = 1)]
						public int GetZEnd() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the current X start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getXStart
						/// </java-name>
						public int XStart
						{
						[Dot42.DexImport("getXStart", "()I", AccessFlags = 1)]
								get{ return GetXStart(); }
						}

						/// <summary>
						/// <para>Returns the current X end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getXEnd
						/// </java-name>
						public int XEnd
						{
						[Dot42.DexImport("getXEnd", "()I", AccessFlags = 1)]
								get{ return GetXEnd(); }
						}

						/// <summary>
						/// <para>Returns the current Y start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getYStart
						/// </java-name>
						public int YStart
						{
						[Dot42.DexImport("getYStart", "()I", AccessFlags = 1)]
								get{ return GetYStart(); }
						}

						/// <summary>
						/// <para>Returns the current Y end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getYEnd
						/// </java-name>
						public int YEnd
						{
						[Dot42.DexImport("getYEnd", "()I", AccessFlags = 1)]
								get{ return GetYEnd(); }
						}

						/// <summary>
						/// <para>Returns the current Z start</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getZStart
						/// </java-name>
						public int ZStart
						{
						[Dot42.DexImport("getZStart", "()I", AccessFlags = 1)]
								get{ return GetZStart(); }
						}

						/// <summary>
						/// <para>Returns the current Z end</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>int current value </para>
						/// </returns>
						/// <java-name>
						/// getZEnd
						/// </java-name>
						public int ZEnd
						{
						[Dot42.DexImport("getZEnd", "()I", AccessFlags = 1)]
								get{ return GetZEnd(); }
						}

				}

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>    
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
						protected internal virtual void Init(global::Android.Renderscript.RenderScript rs, int dimx) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// init
						/// </java-name>
						[Dot42.DexImport("init", "(Landroid/renderscript/RenderScript;II)V", AccessFlags = 4)]
						protected internal virtual void Init(global::Android.Renderscript.RenderScript rs, int dimx, int usages) /* MethodBuilder.Create */ 
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
						public new virtual global::Android.Renderscript.Type GetType() /* MethodBuilder.Create */ 
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
								get{ return GetType(); }
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

				/// <summary>
				/// <para>Only intended for use by generated reflected code. </para>    
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
				/// <para>FieldID is an identifier for a Script + exported field pair. It is used as an identifier for ScriptGroup creation.</para><para>This class should not be directly created. Instead use the method in the reflected or intrinsic code "getFieldID_funcname()". </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Script$FieldID
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$FieldID", AccessFlags = 25)]
				public sealed partial class FieldID : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal FieldID() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				/// <para>KernelID is an identifier for a Script + root function pair. It is used as an identifier for ScriptGroup creation.</para><para>This class should not be directly created. Instead use the method in the reflected or intrinsic code "getKernelID_funcname()". </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/Script$KernelID
				/// </java-name>
				[Dot42.DexImport("android/renderscript/Script$KernelID", AccessFlags = 25)]
				public sealed partial class KernelID : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal KernelID() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>This class provides access to a RenderScript context, which controls RenderScript initialization, resource management, and teardown. An instance of the RenderScript class must be created before any other RS objects can be created.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating an application that uses RenderScript, read the  developer guide.</para><para>  </para>    
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

				/// <java-name>
				/// setMessageHandler
				/// </java-name>
				[Dot42.DexImport("setMessageHandler", "(Landroid/renderscript/RenderScript$RSMessageHandler;)V", AccessFlags = 1)]
				public virtual void SetMessageHandler(global::Android.Renderscript.RenderScript.RSMessageHandler msg) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Place a message into the message queue to be sent back to the message handler once all previous commands have been executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sendMessage
				/// </java-name>
				[Dot42.DexImport("sendMessage", "(I[I)V", AccessFlags = 1)]
				public virtual void SendMessage(int id, int[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Landroid/renderscript/RenderScript$RSErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Android.Renderscript.RenderScript.RSErrorHandler msg) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Change the priority of the worker threads for this context.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(Landroid/renderscript/RenderScript$Priority;)V", AccessFlags = 1)]
				public virtual void SetPriority(global::Android.Renderscript.RenderScript.Priority p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the application context associated with the RenderScript context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The application context. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 17)]
				public global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <summary>
				/// <para>Create a RenderScript context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>RenderScript </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;)Landroid/renderscript/RenderScript;", AccessFlags = 9)]
				public static global::Android.Renderscript.RenderScript Create(global::Android.Content.Context ctx) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScript);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;Landroid/renderscript/RenderScript$ContextType;)Landroi" +
    "d/renderscript/RenderScript;", AccessFlags = 9)]
				public static global::Android.Renderscript.RenderScript Create(global::Android.Content.Context ctx, global::Android.Renderscript.RenderScript.ContextType sdkVersion) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.RenderScript);
				}

				/// <summary>
				/// <para>Print the currently available debugging information about the state of the RS context to the log. </para>        
				/// </summary>
				/// <java-name>
				/// contextDump
				/// </java-name>
				[Dot42.DexImport("contextDump", "()V", AccessFlags = 1)]
				public virtual void ContextDump() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Wait for any pending asynchronous opeations (such as copies to a RS allocation or RS script executions) to complete. </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Destroys this RenderScript context. Once this function is called, using this context or any objects belonging to this context is illegal. </para>        
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

				/// <summary>
				/// <para>Gets the application context associated with the RenderScript context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The application context. </para>
				/// </returns>
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

				}

				/// <summary>
				/// <para>The runtime error handler base class. An application should derive from this class if it wishes to install an error handler. When errors occur at runtime, the fields in this class will be filled, and the run method will be called. </para>    
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
				/// <para>The base class from which an application should derive in order to receive RS messages from scripts. When a script calls <c>       rsSendToClient </c> , the data fields will be filled, and the run method will be called on a separate thread. This will occur some time after <c> rsSendToClient </c> completes in the script, as <c> rsSendToClient </c> is asynchronous. Message handlers are not guaranteed to have completed when android.renderscript.RenderScript#finish returns. </para>    
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

				/// <java-name>
				/// android/renderscript/RenderScript$ContextType
				/// </java-name>
				[Dot42.DexImport("android/renderscript/RenderScript$ContextType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/renderscript/RenderScript$ContextType;>;")]
				public sealed class ContextType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEBUG
						/// </java-name>
						[Dot42.DexImport("DEBUG", "Landroid/renderscript/RenderScript$ContextType;", AccessFlags = 16409)]
						public static readonly ContextType DEBUG;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/renderscript/RenderScript$ContextType;", AccessFlags = 16409)]
						public static readonly ContextType NORMAL;
						/// <java-name>
						/// PROFILE
						/// </java-name>
						[Dot42.DexImport("PROFILE", "Landroid/renderscript/RenderScript$ContextType;", AccessFlags = 16409)]
						public static readonly ContextType PROFILE;
						private ContextType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
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

		/// <summary>
		/// <para>Class for exposing the native RenderScript int3 type back to the Android system. </para>    
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
		/// <para>This class provides the primary method through which data is passed to and from RenderScript kernels. An Allocation provides the backing store for a given android.renderscript.Type. </para><para>An Allocation also contains a set of usage flags that denote how the Allocation could be used. For example, an Allocation may have usage flags specifying that it can be used from a script as well as input to a android.renderscript.Sampler. A developer must synchronize across these different usages using android.renderscript.Allocation#syncAll in order to ensure that different users of the Allocation have a consistent view of memory. For example, in the case where an Allocation is used as the output of one kernel and as Sampler input in a later kernel, a developer must call syncAll(Allocation.USAGE_SCRIPT) prior to launching the second kernel to ensure correctness.</para><para>An Allocation can be populated with the copyFrom routines. For more complex Element types, the copyFromUnchecked methods can be used to copy from byte arrays or similar constructs.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating an application that uses RenderScript, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Allocation
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Allocation", AccessFlags = 33)]
		public partial class Allocation : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The usage of the Allocation. These signal to RenderScript where to place the Allocation in memory. The Allocation will be bound to and accessed by scripts. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_SCRIPT
				/// </java-name>
				[Dot42.DexImport("USAGE_SCRIPT", "I", AccessFlags = 25)]
				public const int USAGE_SCRIPT = 1;
				/// <summary>
				/// <para>The Allocation will be used as a texture source by one or more graphics programs. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_TEXTURE
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_TEXTURE", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_TEXTURE = 2;
				/// <summary>
				/// <para>The Allocation will be used as a graphics mesh.</para><para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_VERTEX
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_VERTEX", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_VERTEX = 4;
				/// <summary>
				/// <para>The Allocation will be used as the source of shader constants by one or more programs.</para><para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_CONSTANTS
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_CONSTANTS", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_CONSTANTS = 8;
				/// <summary>
				/// <para>The Allocation will be used as a target for offscreen rendering</para><para>This was deprecated in API level 16. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_GRAPHICS_RENDER_TARGET
				/// </java-name>
				[Dot42.DexImport("USAGE_GRAPHICS_RENDER_TARGET", "I", AccessFlags = 25)]
				public const int USAGE_GRAPHICS_RENDER_TARGET = 16;
				/// <summary>
				/// <para>The Allocation will be used as a android.graphics.SurfaceTexture consumer. This usage will cause the Allocation to be created as read-only. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_IO_INPUT
				/// </java-name>
				[Dot42.DexImport("USAGE_IO_INPUT", "I", AccessFlags = 25)]
				public const int USAGE_IO_INPUT = 32;
				/// <summary>
				/// <para>The Allocation will be used as a android.graphics.SurfaceTexture producer. The dimensions and format of the android.graphics.SurfaceTexture will be forced to those of the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// USAGE_IO_OUTPUT
				/// </java-name>
				[Dot42.DexImport("USAGE_IO_OUTPUT", "I", AccessFlags = 25)]
				public const int USAGE_IO_OUTPUT = 64;
				/// <summary>
				/// <para>The Allocation's backing store will be inherited from another object (usually a android.graphics.Bitmap); copying to or from the original source Bitmap will cause a synchronization rather than a full copy. syncAll may also be used to synchronize the Allocation and the source Bitmap.</para><para>This is set by default for allocations created with createFromBitmap in API version 18 and higher.</para>        
				/// </summary>
				/// <java-name>
				/// USAGE_SHARED
				/// </java-name>
				[Dot42.DexImport("USAGE_SHARED", "I", AccessFlags = 25)]
				public const int USAGE_SHARED = 128;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Allocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the android.renderscript.Element of the android.renderscript.Type of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element GetElement() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Get the usage flags of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>usage this Allocation's set of the USAGE_* flags OR'd together </para>
				/// </returns>
				/// <java-name>
				/// getUsage
				/// </java-name>
				[Dot42.DexImport("getUsage", "()I", AccessFlags = 1)]
				public virtual int GetUsage() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the size of the Allocation in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>size of the Allocation in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
				public virtual int GetBytesSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the android.renderscript.Type of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
				public new virtual global::Android.Renderscript.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Type);
				}

				/// <summary>
				/// <para>Propagate changes from one usage of the Allocation to the other usages of the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// syncAll
				/// </java-name>
				[Dot42.DexImport("syncAll", "(I)V", AccessFlags = 1)]
				public virtual void SyncAll(int srcLocation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Send a buffer to the output stream. The contents of the Allocation will be undefined after this operation. This operation is only valid if USAGE_IO_OUTPUT is set on the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// ioSend
				/// </java-name>
				[Dot42.DexImport("ioSend", "()V", AccessFlags = 1)]
				public virtual void IoSend() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive the latest input into the Allocation. This operation is only valid if USAGE_IO_INPUT is set on the Allocation. </para>        
				/// </summary>
				/// <java-name>
				/// ioReceive
				/// </java-name>
				[Dot42.DexImport("ioReceive", "()V", AccessFlags = 1)]
				public virtual void IoReceive() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Renderscript.BaseObj[] d) /* MethodBuilder.Create */ 
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
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([I)V", AccessFlags = 1)]
				public virtual void CopyFrom(int[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([S)V", AccessFlags = 1)]
				public virtual void CopyFrom(short[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1)]
				public virtual void CopyFrom(sbyte[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyFrom(byte[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "([F)V", AccessFlags = 1)]
				public virtual void CopyFrom(float[] d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Graphics.Bitmap d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an array of RS objects to the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public virtual void CopyFrom(global::Android.Renderscript.Allocation d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is only intended to be used by auto-generated code reflected from the RenderScript script files and should not be used by developers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(ILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int xoff, global::Android.Renderscript.FieldPacker fp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is only intended to be used by auto-generated code reflected from the RenderScript script files.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFromFieldPacker
				/// </java-name>
				[Dot42.DexImport("setFromFieldPacker", "(IILandroid/renderscript/FieldPacker;)V", AccessFlags = 1)]
				public virtual void SetFromFieldPacker(int xoff, int component_number, global::Android.Renderscript.FieldPacker fp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generate a mipmap chain. This is only valid if the Type of the Allocation includes mipmaps.</para><para>This function will generate a complete set of mipmaps from the top level LOD and place them into the script memory space.</para><para>If the Allocation is also using other memory spaces, a call to syncAll(Allocation.USAGE_SCRIPT) is required.</para>        
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
				/// <para>Copy part of an Allocation into this Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copy1DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy1DRangeFrom", "(IILandroid/renderscript/Allocation;I)V", AccessFlags = 1)]
				public virtual void Copy1DRangeFrom(int off, int count, global::Android.Renderscript.Allocation data, int dataOff) /* MethodBuilder.Create */ 
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
				/// <para>Copy a rectangular region from an Allocation into a rectangular region in this Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IIIILandroid/renderscript/Allocation;II)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int xoff, int yoff, int w, int h, global::Android.Renderscript.Allocation data, int dataXoff, int dataYoff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy a android.graphics.Bitmap into an Allocation. The height and width of the update will use the height and width of the android.graphics.Bitmap.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copy2DRangeFrom
				/// </java-name>
				[Dot42.DexImport("copy2DRangeFrom", "(IILandroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void Copy2DRangeFrom(int xoff, int yoff, global::Android.Graphics.Bitmap data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void CopyTo(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1)]
				public virtual void CopyTo(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CopyTo(byte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([S)V", AccessFlags = 1)]
				public virtual void CopyTo(short[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([I)V", AccessFlags = 1)]
				public virtual void CopyTo(int[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy from the Allocation into a android.graphics.Bitmap. The bitmap must match the dimensions of the Allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyTo
				/// </java-name>
				[Dot42.DexImport("copyTo", "([F)V", AccessFlags = 1)]
				public virtual void CopyTo(float[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resize a 1D allocation. The contents of the allocation are preserved. If new elements are allocated objects are created with null contents and the new region is otherwise undefined.</para><para>If the new region is smaller the references of any objects outside the new region will be released.</para><para>A new type will be created with the new dimension.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>RenderScript objects should be immutable once created. The replacement is to create a new allocation and copy the contents. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(I)V", AccessFlags = 33)]
				public virtual void Resize(int dimX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new Allocation with the given android.renderscript.Type, mipmap flag, and usage flags.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;Landroid/renderscr" +
    "ipt/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Type type, global::Android.Renderscript.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation with the size specified by the type and no mipmaps generated by default</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;I)Landroid/renders" +
    "cript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Type type, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation for use by scripts with a given android.renderscript.Type and no mipmaps</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createTyped
				/// </java-name>
				[Dot42.DexImport("createTyped", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Type;)Landroid/rendersc" +
    "ript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateTyped(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation with a specified number of given elements</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;II)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateSized(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e, int count, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation with a specified number of given elements</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation </para>
				/// </returns>
				/// <java-name>
				/// createSized
				/// </java-name>
				[Dot42.DexImport("createSized", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;I)Landroid/rend" +
    "erscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateSized(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e, int count) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation from a android.graphics.Bitmap.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Allocation containing bitmap data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmap(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap b, global::Android.Renderscript.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Returns the handle to a raw buffer that is being managed by the screen compositor. This operation is only valid for Allocations with USAGE_IO_INPUT.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Surface object associated with allocation </para>
				/// </returns>
				/// <java-name>
				/// getSurface
				/// </java-name>
				[Dot42.DexImport("getSurface", "()Landroid/view/Surface;", AccessFlags = 1)]
				public virtual global::Android.View.Surface GetSurface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Surface);
				}

				/// <summary>
				/// <para>Associate a android.view.Surface with this Allocation. This operation is only valid for Allocations with USAGE_IO_OUTPUT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSurface
				/// </java-name>
				[Dot42.DexImport("setSurface", "(Landroid/view/Surface;)V", AccessFlags = 1)]
				public virtual void SetSurface(global::Android.View.Surface sur) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an Allocation from a android.graphics.Bitmap.</para><para>With target API version 18 or greater, this Allocation will be created with USAGE_SHARED, USAGE_SCRIPT, and USAGE_GRAPHICS_TEXTURE. With target API version 17 or lower, this Allocation will be created with USAGE_GRAPHICS_TEXTURE.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Allocation containing bitmap data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmap
				/// </java-name>
				[Dot42.DexImport("createFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmap(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates a cubemap Allocation from a android.graphics.Bitmap containing the horizontal list of cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/renderscrip" +
    "t/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromBitmap(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap b, global::Android.Renderscript.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates a non-mipmapped cubemap Allocation for use as a graphics texture from a android.graphics.Bitmap containing the horizontal list of cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromBitmap
				/// </java-name>
				[Dot42.DexImport("createCubemapFromBitmap", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;)Landroid/renderscri" +
    "pt/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromBitmap(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates a cubemap Allocation from 6 android.graphics.Bitmap objects containing the cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", @"(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/renderscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap xpos, global::Android.Graphics.Bitmap xneg, global::Android.Graphics.Bitmap ypos, global::Android.Graphics.Bitmap yneg, global::Android.Graphics.Bitmap zpos, global::Android.Graphics.Bitmap zneg, global::Android.Renderscript.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates a non-mipmapped cubemap Allocation for use as a sampler input from 6 android.graphics.Bitmap objects containing the cube faces. Each face must be a square, have the same size as all other faces, and have a width that is a power of 2.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>allocation containing cubemap data </para>
				/// </returns>
				/// <java-name>
				/// createCubemapFromCubeFaces
				/// </java-name>
				[Dot42.DexImport("createCubemapFromCubeFaces", "(Landroid/renderscript/RenderScript;Landroid/graphics/Bitmap;Landroid/graphics/Bi" +
    "tmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;" +
    "Landroid/graphics/Bitmap;)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateCubemapFromCubeFaces(global::Android.Renderscript.RenderScript rs, global::Android.Graphics.Bitmap xpos, global::Android.Graphics.Bitmap xneg, global::Android.Graphics.Bitmap ypos, global::Android.Graphics.Bitmap yneg, global::Android.Graphics.Bitmap zpos, global::Android.Graphics.Bitmap zneg) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation from the Bitmap referenced by resource ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Allocation containing resource data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;ILandroid/rend" +
    "erscript/Allocation$MipmapControl;I)Landroid/renderscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmapResource(global::Android.Renderscript.RenderScript rs, global::Android.Content.Res.Resources res, int id, global::Android.Renderscript.Allocation.MipmapControl mips, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates a non-mipmapped Allocation to use as a graphics texture from the android.graphics.Bitmap referenced by resource ID.</para><para>With target API version 18 or greater, this allocation will be created with USAGE_SCRIPT and USAGE_GRAPHICS_TEXTURE. With target API version 17 or lower, this allocation will be created with USAGE_GRAPHICS_TEXTURE.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Allocation containing resource data </para>
				/// </returns>
				/// <java-name>
				/// createFromBitmapResource
				/// </java-name>
				[Dot42.DexImport("createFromBitmapResource", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)Landroid/ren" +
    "derscript/Allocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromBitmapResource(global::Android.Renderscript.RenderScript rs, global::Android.Content.Res.Resources res, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Creates an Allocation containing string data encoded in UTF-8 format.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// createFromString
				/// </java-name>
				[Dot42.DexImport("createFromString", "(Landroid/renderscript/RenderScript;Ljava/lang/String;I)Landroid/renderscript/All" +
    "ocation;", AccessFlags = 9)]
				public static global::Android.Renderscript.Allocation CreateFromString(global::Android.Renderscript.RenderScript rs, string str, int usage) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Allocation);
				}

				/// <summary>
				/// <para>Get the android.renderscript.Element of the android.renderscript.Type of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// getElement
				/// </java-name>
				public global::Android.Renderscript.Element Element
				{
				[Dot42.DexImport("getElement", "()Landroid/renderscript/Element;", AccessFlags = 1)]
						get{ return GetElement(); }
				}

				/// <summary>
				/// <para>Get the usage flags of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>usage this Allocation's set of the USAGE_* flags OR'd together </para>
				/// </returns>
				/// <java-name>
				/// getUsage
				/// </java-name>
				public int Usage
				{
				[Dot42.DexImport("getUsage", "()I", AccessFlags = 1)]
						get{ return GetUsage(); }
				}

				/// <summary>
				/// <para>Get the size of the Allocation in bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>size of the Allocation in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				public int BytesSize
				{
				[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
						get{ return GetBytesSize(); }
				}

				/// <summary>
				/// <para>Get the android.renderscript.Type of the Allocation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public global::Android.Renderscript.Type Type
				{
				[Dot42.DexImport("getType", "()Landroid/renderscript/Type;", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <summary>
				/// <para>Returns the handle to a raw buffer that is being managed by the screen compositor. This operation is only valid for Allocations with USAGE_IO_INPUT.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Surface object associated with allocation </para>
				/// </returns>
				/// <java-name>
				/// getSurface
				/// </java-name>
				public global::Android.View.Surface Surface
				{
				[Dot42.DexImport("getSurface", "()Landroid/view/Surface;", AccessFlags = 1)]
						get{ return GetSurface(); }
				[Dot42.DexImport("setSurface", "(Landroid/view/Surface;)V", AccessFlags = 1)]
						set{ SetSurface(value); }
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

				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript byte3 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript rs_matrix3x3 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix3f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix3f", AccessFlags = 33)]
		public partial class Matrix3f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new identity 3x3 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix3f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new matrix and sets its values from the given parameter</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix3f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				/// <para>Returns the value for a given row and column</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>value in the yth row and xth column </para>
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
				/// <para>Sets the value for a given row and column</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values of the matrix to those of the parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix3f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a rotation matrix of certain angle about a given axis</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Makes the upper 2x2 a rotation matrix of the given angle</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Makes the upper 2x2 a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FFF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a translation matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadTranslate
				/// </java-name>
				[Dot42.DexImport("loadTranslate", "(FF)V", AccessFlags = 1)]
				public virtual void LoadTranslate(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be the result of multiplying two given matrices</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix3f;Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix3f lhs, global::Android.Renderscript.Matrix3f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Post-multiplies the current matrix by a given parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix3f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a rotation matrix of certain angle about a given axis</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(FFFF)V", AccessFlags = 1)]
				public virtual void Rotate(float rot, float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the upper 2x2 of the current matrix by post-multiplying it with a rotation matrix of given angle</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the upper 2x2 of the current matrix by post-multiplying it with a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FFF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y, float z) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a translation matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// translate
				/// </java-name>
				[Dot42.DexImport("translate", "(FF)V", AccessFlags = 1)]
				public virtual void Translate(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript long3 type back to the Android system. </para>    
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
		/// <para>The superclass for all user-defined scripts. This is only intended to be used by the generated derived classes. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptC
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptC", AccessFlags = 33)]
		public partial class ScriptC : global::Android.Renderscript.Script
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only intended for use by the generated derived classes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILandroid/renderscript/RenderScript;)V", AccessFlags = 4)]
				protected internal ScriptC(int id, global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Only intended for use by the generated derived classes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;Landroid/content/res/Resources;I)V", AccessFlags = 4)]
				protected internal ScriptC(global::Android.Renderscript.RenderScript rs, global::Android.Content.Res.Resources resources, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScriptC() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Sampler object that defines how Allocations can be read as textures within a kernel. Samplers are used in conjunction with the <c> rsSample </c> runtime function to return values from normalized coordinates.</para><para>Any Allocation used with a Sampler must have been created with android.renderscript.Allocation#USAGE_GRAPHICS_TEXTURE; using a Sampler on an android.renderscript.Allocation that was not created with android.renderscript.Allocation#USAGE_GRAPHICS_TEXTURE is undefined. </para>    
		/// </summary>
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

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>minification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMinification
				/// </java-name>
				[Dot42.DexImport("getMinification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Sampler.Value GetMinification() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler.Value);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>magnification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMagnification
				/// </java-name>
				[Dot42.DexImport("getMagnification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Sampler.Value GetMagnification() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler.Value);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>S wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapS
				/// </java-name>
				[Dot42.DexImport("getWrapS", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Sampler.Value GetWrapS() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler.Value);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>T wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapT
				/// </java-name>
				[Dot42.DexImport("getWrapT", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Sampler.Value GetWrapT() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler.Value);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>anisotropy setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getAnisotropy
				/// </java-name>
				[Dot42.DexImport("getAnisotropy", "()F", AccessFlags = 1)]
				public virtual float GetAnisotropy() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to nearest and wrap modes set to clamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_NEAREST
				/// </java-name>
				[Dot42.DexImport("CLAMP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_NEAREST(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to linear and wrap modes set to clamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with mag set to linear, min linear mipmap linear, and wrap modes set to clamp.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// CLAMP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("CLAMP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler CLAMP_LINEAR_MIP_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to nearest and wrap modes set to wrap.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_NEAREST
				/// </java-name>
				[Dot42.DexImport("WRAP_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_NEAREST(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to linear and wrap modes set to wrap.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with mag set to linear, min linear mipmap linear, and wrap modes set to wrap.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// WRAP_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("WRAP_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler WRAP_LINEAR_MIP_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to nearest and wrap modes set to mirrored repeat.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// MIRRORED_REPEAT_NEAREST
				/// </java-name>
				[Dot42.DexImport("MIRRORED_REPEAT_NEAREST", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler MIRRORED_REPEAT_NEAREST(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to linear and wrap modes set to mirrored repeat.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// MIRRORED_REPEAT_LINEAR
				/// </java-name>
				[Dot42.DexImport("MIRRORED_REPEAT_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler MIRRORED_REPEAT_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para>Retrieve a sampler with min and mag set to linear and wrap modes set to mirrored repeat.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Sampler </para>
				/// </returns>
				/// <java-name>
				/// MIRRORED_REPEAT_LINEAR_MIP_LINEAR
				/// </java-name>
				[Dot42.DexImport("MIRRORED_REPEAT_LINEAR_MIP_LINEAR", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Sampler;", AccessFlags = 9)]
				public static global::Android.Renderscript.Sampler MIRRORED_REPEAT_LINEAR_MIP_LINEAR(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Sampler);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>minification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMinification
				/// </java-name>
				public global::Android.Renderscript.Sampler.Value Minification
				{
				[Dot42.DexImport("getMinification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return GetMinification(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>magnification setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getMagnification
				/// </java-name>
				public global::Android.Renderscript.Sampler.Value Magnification
				{
				[Dot42.DexImport("getMagnification", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return GetMagnification(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>S wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapS
				/// </java-name>
				public global::Android.Renderscript.Sampler.Value WrapS
				{
				[Dot42.DexImport("getWrapS", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return GetWrapS(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>T wrapping mode for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getWrapT
				/// </java-name>
				public global::Android.Renderscript.Sampler.Value WrapT
				{
				[Dot42.DexImport("getWrapT", "()Landroid/renderscript/Sampler$Value;", AccessFlags = 1)]
						get{ return GetWrapT(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>anisotropy setting for the sampler </para>
				/// </returns>
				/// <java-name>
				/// getAnisotropy
				/// </java-name>
				public float Anisotropy
				{
				[Dot42.DexImport("getAnisotropy", "()F", AccessFlags = 1)]
						get{ return GetAnisotropy(); }
				}

				/// <summary>
				/// <para>Builder for creating non-standard samplers. This is only necessary if a Sampler with different min and mag modes is desired. </para>    
				/// </summary>
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
						public virtual void SetMinification(global::Android.Renderscript.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMagnification
						/// </java-name>
						[Dot42.DexImport("setMagnification", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetMagnification(global::Android.Renderscript.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapS
						/// </java-name>
						[Dot42.DexImport("setWrapS", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapS(global::Android.Renderscript.Sampler.Value v) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWrapT
						/// </java-name>
						[Dot42.DexImport("setWrapT", "(Landroid/renderscript/Sampler$Value;)V", AccessFlags = 1)]
						public virtual void SetWrapT(global::Android.Renderscript.Sampler.Value v) /* MethodBuilder.Create */ 
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
						/// MIRRORED_REPEAT
						/// </java-name>
						[Dot42.DexImport("MIRRORED_REPEAT", "Landroid/renderscript/Sampler$Value;", AccessFlags = 16409)]
						public static readonly Value MIRRORED_REPEAT;
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

				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript int4 type back to the Android system. </para>    
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
		/// <para>Base class for all Intrinsic scripts. An intrinsic a script which implements a pre-defined function. Intrinsics are provided to provide effecient implemtations of common operations.</para><para>Not intended for direct use. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsic
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsic", AccessFlags = 1057)]
		public abstract partial class ScriptIntrinsic : global::Android.Renderscript.Script
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsic() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript double2 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript short3 type back to the Android system. </para>    
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
		/// <para>Utility class for packing arguments and structures from Android system objects to RenderScript objects.</para><para>This class is only intended to be used to support the reflected code generated by the RS tool chain. It should not be called directly. </para>    
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

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public FieldPacker(sbyte[] len) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public FieldPacker(byte[] len) /* MethodBuilder.Create */ 
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
				/// subalign
				/// </java-name>
				[Dot42.DexImport("subalign", "(I)V", AccessFlags = 1)]
				public virtual void Subalign(int v) /* MethodBuilder.Create */ 
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
				/// subI8
				/// </java-name>
				[Dot42.DexImport("subI8", "()B", AccessFlags = 1)]
				public virtual sbyte JavaSubI8() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// subI8
				/// </java-name>
				[Dot42.DexImport("subI8", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte SubI8() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(S)V", AccessFlags = 1)]
				public virtual void AddI16(short v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subI16
				/// </java-name>
				[Dot42.DexImport("subI16", "()S", AccessFlags = 1)]
				public virtual short SubI16() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(I)V", AccessFlags = 1)]
				public virtual void AddI32(int v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subI32
				/// </java-name>
				[Dot42.DexImport("subI32", "()I", AccessFlags = 1)]
				public virtual int SubI32() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(J)V", AccessFlags = 1)]
				public virtual void AddI64(long v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subI64
				/// </java-name>
				[Dot42.DexImport("subI64", "()J", AccessFlags = 1)]
				public virtual long SubI64() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				/// subF32
				/// </java-name>
				[Dot42.DexImport("subF32", "()F", AccessFlags = 1)]
				public virtual float SubF32() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(D)V", AccessFlags = 1)]
				public virtual void AddF64(double v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subF64
				/// </java-name>
				[Dot42.DexImport("subF64", "()D", AccessFlags = 1)]
				public virtual double SubF64() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// addObj
				/// </java-name>
				[Dot42.DexImport("addObj", "(Landroid/renderscript/BaseObj;)V", AccessFlags = 1)]
				public virtual void AddObj(global::Android.Renderscript.BaseObj obj) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float2;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float3;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF32
				/// </java-name>
				[Dot42.DexImport("addF32", "(Landroid/renderscript/Float4;)V", AccessFlags = 1)]
				public virtual void AddF32(global::Android.Renderscript.Float4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double2;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double3;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addF64
				/// </java-name>
				[Dot42.DexImport("addF64", "(Landroid/renderscript/Double4;)V", AccessFlags = 1)]
				public virtual void AddF64(global::Android.Renderscript.Double4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte2;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte3;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI8
				/// </java-name>
				[Dot42.DexImport("addI8", "(Landroid/renderscript/Byte4;)V", AccessFlags = 1)]
				public virtual void AddI8(global::Android.Renderscript.Byte4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU8
				/// </java-name>
				[Dot42.DexImport("addU8", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddU8(global::Android.Renderscript.Short4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short2;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short3;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI16
				/// </java-name>
				[Dot42.DexImport("addI16", "(Landroid/renderscript/Short4;)V", AccessFlags = 1)]
				public virtual void AddI16(global::Android.Renderscript.Short4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU16
				/// </java-name>
				[Dot42.DexImport("addU16", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddU16(global::Android.Renderscript.Int4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int2;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int3;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI32
				/// </java-name>
				[Dot42.DexImport("addI32", "(Landroid/renderscript/Int4;)V", AccessFlags = 1)]
				public virtual void AddI32(global::Android.Renderscript.Int4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU32
				/// </java-name>
				[Dot42.DexImport("addU32", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU32(global::Android.Renderscript.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addI64
				/// </java-name>
				[Dot42.DexImport("addI64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddI64(global::Android.Renderscript.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long2;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long2 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long3;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long3 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addU64
				/// </java-name>
				[Dot42.DexImport("addU64", "(Landroid/renderscript/Long4;)V", AccessFlags = 1)]
				public virtual void AddU64(global::Android.Renderscript.Long4 v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subFloat2
				/// </java-name>
				[Dot42.DexImport("subFloat2", "()Landroid/renderscript/Float2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Float2 SubFloat2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Float2);
				}

				/// <java-name>
				/// subFloat3
				/// </java-name>
				[Dot42.DexImport("subFloat3", "()Landroid/renderscript/Float3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Float3 SubFloat3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Float3);
				}

				/// <java-name>
				/// subFloat4
				/// </java-name>
				[Dot42.DexImport("subFloat4", "()Landroid/renderscript/Float4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Float4 SubFloat4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Float4);
				}

				/// <java-name>
				/// subDouble2
				/// </java-name>
				[Dot42.DexImport("subDouble2", "()Landroid/renderscript/Double2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Double2 SubDouble2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Double2);
				}

				/// <java-name>
				/// subDouble3
				/// </java-name>
				[Dot42.DexImport("subDouble3", "()Landroid/renderscript/Double3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Double3 SubDouble3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Double3);
				}

				/// <java-name>
				/// subDouble4
				/// </java-name>
				[Dot42.DexImport("subDouble4", "()Landroid/renderscript/Double4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Double4 SubDouble4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Double4);
				}

				/// <java-name>
				/// subByte2
				/// </java-name>
				[Dot42.DexImport("subByte2", "()Landroid/renderscript/Byte2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Byte2 SubByte2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Byte2);
				}

				/// <java-name>
				/// subByte3
				/// </java-name>
				[Dot42.DexImport("subByte3", "()Landroid/renderscript/Byte3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Byte3 SubByte3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Byte3);
				}

				/// <java-name>
				/// subByte4
				/// </java-name>
				[Dot42.DexImport("subByte4", "()Landroid/renderscript/Byte4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Byte4 SubByte4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Byte4);
				}

				/// <java-name>
				/// subShort2
				/// </java-name>
				[Dot42.DexImport("subShort2", "()Landroid/renderscript/Short2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Short2 SubShort2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Short2);
				}

				/// <java-name>
				/// subShort3
				/// </java-name>
				[Dot42.DexImport("subShort3", "()Landroid/renderscript/Short3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Short3 SubShort3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Short3);
				}

				/// <java-name>
				/// subShort4
				/// </java-name>
				[Dot42.DexImport("subShort4", "()Landroid/renderscript/Short4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Short4 SubShort4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Short4);
				}

				/// <java-name>
				/// subInt2
				/// </java-name>
				[Dot42.DexImport("subInt2", "()Landroid/renderscript/Int2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Int2 SubInt2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Int2);
				}

				/// <java-name>
				/// subInt3
				/// </java-name>
				[Dot42.DexImport("subInt3", "()Landroid/renderscript/Int3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Int3 SubInt3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Int3);
				}

				/// <java-name>
				/// subInt4
				/// </java-name>
				[Dot42.DexImport("subInt4", "()Landroid/renderscript/Int4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Int4 SubInt4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Int4);
				}

				/// <java-name>
				/// subLong2
				/// </java-name>
				[Dot42.DexImport("subLong2", "()Landroid/renderscript/Long2;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Long2 SubLong2() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Long2);
				}

				/// <java-name>
				/// subLong3
				/// </java-name>
				[Dot42.DexImport("subLong3", "()Landroid/renderscript/Long3;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Long3 SubLong3() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Long3);
				}

				/// <java-name>
				/// subLong4
				/// </java-name>
				[Dot42.DexImport("subLong4", "()Landroid/renderscript/Long4;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Long4 SubLong4() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Long4);
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix4f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subMatrix4f
				/// </java-name>
				[Dot42.DexImport("subMatrix4f", "()Landroid/renderscript/Matrix4f;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Matrix4f SubMatrix4f() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Matrix4f);
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix3f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subMatrix3f
				/// </java-name>
				[Dot42.DexImport("subMatrix3f", "()Landroid/renderscript/Matrix3f;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Matrix3f SubMatrix3f() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Matrix3f);
				}

				/// <java-name>
				/// addMatrix
				/// </java-name>
				[Dot42.DexImport("addMatrix", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void AddMatrix(global::Android.Renderscript.Matrix2f v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subMatrix2f
				/// </java-name>
				[Dot42.DexImport("subMatrix2f", "()Landroid/renderscript/Matrix2f;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Matrix2f SubMatrix2f() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Matrix2f);
				}

				/// <java-name>
				/// addBoolean
				/// </java-name>
				[Dot42.DexImport("addBoolean", "(Z)V", AccessFlags = 1)]
				public virtual void AddBoolean(bool v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subBoolean
				/// </java-name>
				[Dot42.DexImport("subBoolean", "()Z", AccessFlags = 1)]
				public virtual bool SubBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
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

		/// <summary>
		/// <para>Class for exposing the native RenderScript byte4 type back to the Android system. </para>    
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
		/// <para>Intrinsic Gausian blur filter. Applies a gaussian blur of the specified radius to all elements of an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicBlur
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicBlur", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicBlur : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicBlur() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an intrinsic for applying a blur to an allocation. The default radius is 5.0.</para><para>Supported elements types are Element#U8_4</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicBlur </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicBlur;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicBlur Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicBlur);
				}

				/// <summary>
				/// <para>Set the input of the blur. Must match the element type supplied during create.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscript.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the radius of the Blur.</para><para>Supported range 0 &lt; radius &lt;= 25</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRadius
				/// </java-name>
				[Dot42.DexImport("setRadius", "(F)V", AccessFlags = 1)]
				public void SetRadius(float radius) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Apply the filter to the input and save to the specified allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.FieldID GetFieldID_Input() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.FieldID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscript.Script.FieldID FieldID_Input
				{
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return GetFieldID_Input(); }
				}

		}

		/// <summary>
		/// <para>ScriptGroup creates a group of kernels that are executed together with one execution call as if they were a single kernel. The kernels may be connected internally or to an external allocation. The intermediate results for internal connections are not observable after the execution of the script. </para><para>External connections are grouped into inputs and outputs. All outputs are produced by a script kernel and placed into a user-supplied allocation. Inputs provide the input of a kernel. Inputs bound to script globals are set directly upon the script. </para><para>A ScriptGroup must contain at least one kernel. A ScriptGroup must contain only a single directed acyclic graph (DAG) of script kernels and connections. Attempting to create a ScriptGroup with multiple DAGs or attempting to create a cycle within a ScriptGroup will throw an exception. </para><para>Currently, all kernels in a ScriptGroup must be from separate Script objects. Attempting to use multiple kernels from the same Script object will result in an android.renderscript.RSInvalidStateException. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptGroup
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptGroup", AccessFlags = 49)]
		public sealed partial class ScriptGroup : global::Android.Renderscript.BaseObj
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets an input of the ScriptGroup. This specifies an Allocation to be used for kernels that require an input Allocation provided from outside of the ScriptGroup.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscript.Script.KernelID s, global::Android.Renderscript.Allocation a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets an output of the ScriptGroup. This specifies an Allocation to be used for the kernels that require an output Allocation visible after the ScriptGroup is executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetOutput(global::Android.Renderscript.Script.KernelID s, global::Android.Renderscript.Allocation a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Execute the ScriptGroup. This will run all the kernels in the ScriptGroup. No internal connection results will be visible after execution of the ScriptGroup. </para>        
				/// </summary>
				/// <java-name>
				/// execute
				/// </java-name>
				[Dot42.DexImport("execute", "()V", AccessFlags = 1)]
				public void Execute() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper class to build a ScriptGroup. A ScriptGroup is created in two steps. </para><para>First, all kernels to be used by the ScriptGroup should be added. </para><para>Second, add connections between kernels. There are two types of connections: kernel to kernel and kernel to field. Kernel to kernel allows a kernel's output to be passed to another kernel as input. Kernel to field allows the output of one kernel to be bound as a script global. Kernel to kernel is higher performance and should be used where possible. </para><para>A ScriptGroup must contain a single directed acyclic graph (DAG); it cannot contain cycles. Currently, all kernels used in a ScriptGroup must come from different Script objects. Additionally, all kernels in a ScriptGroup must have at least one input, output, or internal connection. </para><para>Once all connections are made, a call to create will return the ScriptGroup object. </para>    
				/// </summary>
				/// <java-name>
				/// android/renderscript/ScriptGroup$Builder
				/// </java-name>
				[Dot42.DexImport("android/renderscript/ScriptGroup$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/renderscript/RenderScript;)V", AccessFlags = 1)]
						public Builder(global::Android.Renderscript.RenderScript renderScript) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Adds a Kernel to the group.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Builder Returns this. </para>
						/// </returns>
						/// <java-name>
						/// addKernel
						/// </java-name>
						[Dot42.DexImport("addKernel", "(Landroid/renderscript/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder" +
    ";", AccessFlags = 1)]
						public Builder AddKernel(global::Android.Renderscript.Script.KernelID k) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addConnection
						/// </java-name>
						[Dot42.DexImport("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/render" +
    "script/Script$FieldID;)Landroid/renderscript/ScriptGroup$Builder;", AccessFlags = 1)]
						public Builder AddConnection(global::Android.Renderscript.Type type, global::Android.Renderscript.Script.KernelID kernelID, global::Android.Renderscript.Script.FieldID fieldID) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addConnection
						/// </java-name>
						[Dot42.DexImport("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/render" +
    "script/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder;", AccessFlags = 1)]
						public Builder AddConnection(global::Android.Renderscript.Type type, global::Android.Renderscript.Script.KernelID kernelID, global::Android.Renderscript.Script.KernelID kernelID1) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Creates the Script group.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>ScriptGroup The new ScriptGroup </para>
						/// </returns>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/renderscript/ScriptGroup;", AccessFlags = 1)]
						public global::Android.Renderscript.ScriptGroup Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Renderscript.ScriptGroup);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Intrinsic for applying a 5x5 convolve to an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicConvolve5x5
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicConvolve5x5", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicConvolve5x5 : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicConvolve5x5() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Supported elements types are Element#U8_4</para><para>The default coefficients are. <code> </code></para><para><code> [ 0, 0, 0, 0, 0 ] </code></para><para><code> [ 0, 0, 0, 0, 0 ] </code></para><para><code> [ 0, 0, 1, 0, 0 ] </code></para><para><code> [ 0, 0, 0, 0, 0 ] </code></para><para><code> [ 0, 0, 0, 0, 0 ] </code></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicConvolve5x5 </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicConvolve5x5;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicConvolve5x5 Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicConvolve5x5);
				}

				/// <summary>
				/// <para>Set the input of the blur. Must match the element type supplied during create.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscript.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the coefficients for the convolve.</para><para>The convolve layout is <code> </code></para><para><code> [ 0, 1, 2, 3, 4 ] </code></para><para><code> [ 5, 6, 7, 8, 9 ] </code></para><para><code> [ 10, 11, 12, 13, 14 ] </code></para><para><code> [ 15, 16, 17, 18, 19 ] </code></para><para><code> [ 20, 21, 22, 23, 24 ] </code></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCoefficients
				/// </java-name>
				[Dot42.DexImport("setCoefficients", "([F)V", AccessFlags = 1)]
				public void SetCoefficients(float[] v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Apply the filter to the input and save to the specified allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.FieldID GetFieldID_Input() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.FieldID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscript.Script.FieldID FieldID_Input
				{
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return GetFieldID_Input(); }
				}

		}

		/// <summary>
		/// <para>Base class for all exceptions thrown by the Android RenderScript </para>    
		/// </summary>
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

		/// <summary>
		/// <para>Intrinsic for converting RGB to RGBA by using a 3D lookup table. The incoming r,g,b values are use as normalized x,y,z coordinates into a 3D allocation. The 8 nearest values are sampled and linearly interpolated. The result is placed in the output. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsic3DLUT
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsic3DLUT", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsic3DLUT : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsic3DLUT() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Supported elements types are Element#U8_4</para><para>The defaults tables are identity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsic3DLUT </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsic3DLUT;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsic3DLUT Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsic3DLUT);
				}

				/// <summary>
				/// <para>Sets the android.renderscript.Allocation to be used as the lookup table.</para><para>The lookup table must use the same android.renderscript.Element as the intrinsic. </para>        
				/// </summary>
				/// <java-name>
				/// setLUT
				/// </java-name>
				[Dot42.DexImport("setLUT", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetLUT(global::Android.Renderscript.Allocation lut) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invoke the kernel and apply the lookup to each cell of ain and copy to aout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

		}

		/// <summary>
		/// <para>An Element represents one item within an android.renderscript.Allocation. An Element is roughly equivalent to a C type in a RenderScript kernel. Elements may be basic or complex. Some basic elements are</para><para><ul><li><para>A single float value (equivalent to a float in a kernel) </para></li><li><para>A four-element float vector (equivalent to a float4 in a kernel) </para></li><li><para>An unsigned 32-bit integer (equivalent to an unsigned int in a kernel) </para></li><li><para>A single signed 8-bit integer (equivalent to a char in a kernel) </para></li></ul></para><para>A complex element is roughly equivalent to a C struct and contains a number of basic or complex Elements. From Java code, a complex element contains a list of sub-elements and names that represents a particular data structure. Structs used in RS scripts are available to Java code by using the <c> ScriptField_structname </c> class that is reflected from a particular script.</para><para>Basic Elements are comprised of a android.renderscript.Element.DataType and a android.renderscript.Element.DataKind. The DataType encodes C type information of an Element, while the DataKind encodes how that Element should be interpreted by a android.renderscript.Sampler. Note that android.renderscript.Allocation objects with DataKind android.renderscript.Element.DataKind#USER cannot be used as input for a android.renderscript.Sampler. In general, android.renderscript.Allocation objects that are intended for use with a android.renderscript.Sampler should use bitmap-derived Elements such as android.renderscript.Element#RGBA_8888 or android.renderscript#Element.A_8.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating an application that uses RenderScript, read the  developer guide.</para><para>  </para>    
		/// </summary>
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

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>element size in bytes </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
				public virtual int GetBytesSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of vector components. 2 for float2, 4 for float4, etc. </para>        
				/// </summary>
				/// <returns>
				/// <para>element vector size </para>
				/// </returns>
				/// <java-name>
				/// getVectorSize
				/// </java-name>
				[Dot42.DexImport("getVectorSize", "()I", AccessFlags = 1)]
				public virtual int GetVectorSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return if a element is too complex for use as a data source for a Mesh or a Program.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean </para>
				/// </returns>
				/// <java-name>
				/// isComplex
				/// </java-name>
				[Dot42.DexImport("isComplex", "()Z", AccessFlags = 1)]
				public virtual bool IsComplex() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Elements could be simple, such as an int or a float, or a structure with multiple sub elements, such as a collection of floats, float2, float4. This function returns zero for simple elements or the number of sub-elements otherwise. </para>        
				/// </summary>
				/// <returns>
				/// <para>number of sub-elements in this element </para>
				/// </returns>
				/// <java-name>
				/// getSubElementCount
				/// </java-name>
				[Dot42.DexImport("getSubElementCount", "()I", AccessFlags = 1)]
				public virtual int GetSubElementCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>For complex elements, this function will return the sub-element at index </para>        
				/// </summary>
				/// <returns>
				/// <para>sub-element in this element at given index </para>
				/// </returns>
				/// <java-name>
				/// getSubElement
				/// </java-name>
				[Dot42.DexImport("getSubElement", "(I)Landroid/renderscript/Element;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element GetSubElement(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>For complex elements, this function will return the sub-element name at index </para>        
				/// </summary>
				/// <returns>
				/// <para>sub-element in this element at given index </para>
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
				/// <para>For complex elements, some sub-elements could be statically sized arrays. This function will return the array size for sub-element at index </para>        
				/// </summary>
				/// <returns>
				/// <para>array size of sub-element in this element at given index </para>
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
				/// <para>This function specifies the location of a sub-element within the element </para>        
				/// </summary>
				/// <returns>
				/// <para>offset in bytes of sub-element in this element at given index </para>
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
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>element data type </para>
				/// </returns>
				/// <java-name>
				/// getDataType
				/// </java-name>
				[Dot42.DexImport("getDataType", "()Landroid/renderscript/Element$DataType;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element.DataType GetDataType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element.DataType);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>element data kind </para>
				/// </returns>
				/// <java-name>
				/// getDataKind
				/// </java-name>
				[Dot42.DexImport("getDataKind", "()Landroid/renderscript/Element$DataKind;", AccessFlags = 1)]
				public virtual global::Android.Renderscript.Element.DataKind GetDataKind() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element.DataKind);
				}

				/// <summary>
				/// <para>Utility function for returning an Element containing a single Boolean.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element BOOLEAN(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Utility function for returning an Element containing a single UNSIGNED_8.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// U8
				/// </java-name>
				[Dot42.DexImport("U8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Utility function for returning an Element containing a single SIGNED_8.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// I8
				/// </java-name>
				[Dot42.DexImport("I8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16
				/// </java-name>
				[Dot42.DexImport("U16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16
				/// </java-name>
				[Dot42.DexImport("I16", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32
				/// </java-name>
				[Dot42.DexImport("U32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32
				/// </java-name>
				[Dot42.DexImport("I32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64
				/// </java-name>
				[Dot42.DexImport("U64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64
				/// </java-name>
				[Dot42.DexImport("I64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32
				/// </java-name>
				[Dot42.DexImport("F32", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64
				/// </java-name>
				[Dot42.DexImport("F64", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// ELEMENT
				/// </java-name>
				[Dot42.DexImport("ELEMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element ELEMENT(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element TYPE(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// ALLOCATION
				/// </java-name>
				[Dot42.DexImport("ALLOCATION", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element ALLOCATION(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// SAMPLER
				/// </java-name>
				[Dot42.DexImport("SAMPLER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element SAMPLER(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// SCRIPT
				/// </java-name>
				[Dot42.DexImport("SCRIPT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element SCRIPT(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MESH
				/// </java-name>
				[Dot42.DexImport("MESH", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MESH(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_FRAGMENT
				/// </java-name>
				[Dot42.DexImport("PROGRAM_FRAGMENT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_FRAGMENT(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_VERTEX
				/// </java-name>
				[Dot42.DexImport("PROGRAM_VERTEX", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_VERTEX(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_RASTER
				/// </java-name>
				[Dot42.DexImport("PROGRAM_RASTER", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_RASTER(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// PROGRAM_STORE
				/// </java-name>
				[Dot42.DexImport("PROGRAM_STORE", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element PROGRAM_STORE(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// FONT
				/// </java-name>
				[Dot42.DexImport("FONT", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element FONT(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// A_8
				/// </java-name>
				[Dot42.DexImport("A_8", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element A_8(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGB_565
				/// </java-name>
				[Dot42.DexImport("RGB_565", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGB_565(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGB_888
				/// </java-name>
				[Dot42.DexImport("RGB_888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGB_888(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_5551
				/// </java-name>
				[Dot42.DexImport("RGBA_5551", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_5551(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_4444
				/// </java-name>
				[Dot42.DexImport("RGBA_4444", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_4444(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// RGBA_8888
				/// </java-name>
				[Dot42.DexImport("RGBA_8888", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element RGBA_8888(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_2
				/// </java-name>
				[Dot42.DexImport("F32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_3
				/// </java-name>
				[Dot42.DexImport("F32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F32_4
				/// </java-name>
				[Dot42.DexImport("F32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F32_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_2
				/// </java-name>
				[Dot42.DexImport("F64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_3
				/// </java-name>
				[Dot42.DexImport("F64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// F64_4
				/// </java-name>
				[Dot42.DexImport("F64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element F64_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_2
				/// </java-name>
				[Dot42.DexImport("U8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_3
				/// </java-name>
				[Dot42.DexImport("U8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U8_4
				/// </java-name>
				[Dot42.DexImport("U8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U8_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_2
				/// </java-name>
				[Dot42.DexImport("I8_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_3
				/// </java-name>
				[Dot42.DexImport("I8_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I8_4
				/// </java-name>
				[Dot42.DexImport("I8_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I8_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_2
				/// </java-name>
				[Dot42.DexImport("U16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_3
				/// </java-name>
				[Dot42.DexImport("U16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U16_4
				/// </java-name>
				[Dot42.DexImport("U16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U16_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_2
				/// </java-name>
				[Dot42.DexImport("I16_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_3
				/// </java-name>
				[Dot42.DexImport("I16_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I16_4
				/// </java-name>
				[Dot42.DexImport("I16_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I16_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_2
				/// </java-name>
				[Dot42.DexImport("U32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_3
				/// </java-name>
				[Dot42.DexImport("U32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U32_4
				/// </java-name>
				[Dot42.DexImport("U32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U32_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_2
				/// </java-name>
				[Dot42.DexImport("I32_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_3
				/// </java-name>
				[Dot42.DexImport("I32_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I32_4
				/// </java-name>
				[Dot42.DexImport("I32_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I32_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_2
				/// </java-name>
				[Dot42.DexImport("U64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_3
				/// </java-name>
				[Dot42.DexImport("U64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// U64_4
				/// </java-name>
				[Dot42.DexImport("U64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element U64_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_2
				/// </java-name>
				[Dot42.DexImport("I64_2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_3
				/// </java-name>
				[Dot42.DexImport("I64_3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// I64_4
				/// </java-name>
				[Dot42.DexImport("I64_4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element I64_4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX_4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_4X4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use MATRIX_4X4 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MATRIX4X4
				/// </java-name>
				[Dot42.DexImport("MATRIX4X4", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX4X4(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_3X3
				/// </java-name>
				[Dot42.DexImport("MATRIX_3X3", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_3X3(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <java-name>
				/// MATRIX_2X2
				/// </java-name>
				[Dot42.DexImport("MATRIX_2X2", "(Landroid/renderscript/RenderScript;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element MATRIX_2X2(global::Android.Renderscript.RenderScript rs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Create a custom vector element of the specified DataType and vector size. DataKind will be set to USER. Only primitive types (FLOAT_32, FLOAT_64, SIGNED_8, SIGNED_16, SIGNED_32, SIGNED_64, UNSIGNED_8, UNSIGNED_16, UNSIGNED_32, UNSIGNED_64, BOOLEAN) are supported.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// createVector
				/// </java-name>
				[Dot42.DexImport("createVector", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;I)Land" +
    "roid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element CreateVector(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element.DataType dt, int size) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Create a new pixel Element type. A matching DataType and DataKind must be provided. The DataType and DataKind must contain the same number of components. Vector size will be set to 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Element </para>
				/// </returns>
				/// <java-name>
				/// createPixel
				/// </java-name>
				[Dot42.DexImport("createPixel", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element$DataType;Landro" +
    "id/renderscript/Element$DataKind;)Landroid/renderscript/Element;", AccessFlags = 9)]
				public static global::Android.Renderscript.Element CreatePixel(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element.DataType dt, global::Android.Renderscript.Element.DataKind dk) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Element);
				}

				/// <summary>
				/// <para>Check if the current Element is compatible with another Element. Primitive Elements are compatible if they share the same underlying size and type (i.e. U8 is compatible with A_8). User-defined Elements must be equal in order to be compatible. This requires strict name equivalence for all sub-Elements (in addition to structural equivalence).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean true if the Elements are compatible, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// isCompatible
				/// </java-name>
				[Dot42.DexImport("isCompatible", "(Landroid/renderscript/Element;)Z", AccessFlags = 1)]
				public virtual bool IsCompatible(global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>element size in bytes </para>
				/// </returns>
				/// <java-name>
				/// getBytesSize
				/// </java-name>
				public int BytesSize
				{
				[Dot42.DexImport("getBytesSize", "()I", AccessFlags = 1)]
						get{ return GetBytesSize(); }
				}

				/// <summary>
				/// <para>Returns the number of vector components. 2 for float2, 4 for float4, etc. </para>        
				/// </summary>
				/// <returns>
				/// <para>element vector size </para>
				/// </returns>
				/// <java-name>
				/// getVectorSize
				/// </java-name>
				public int VectorSize
				{
				[Dot42.DexImport("getVectorSize", "()I", AccessFlags = 1)]
						get{ return GetVectorSize(); }
				}

				/// <summary>
				/// <para>Elements could be simple, such as an int or a float, or a structure with multiple sub elements, such as a collection of floats, float2, float4. This function returns zero for simple elements or the number of sub-elements otherwise. </para>        
				/// </summary>
				/// <returns>
				/// <para>number of sub-elements in this element </para>
				/// </returns>
				/// <java-name>
				/// getSubElementCount
				/// </java-name>
				public int SubElementCount
				{
				[Dot42.DexImport("getSubElementCount", "()I", AccessFlags = 1)]
						get{ return GetSubElementCount(); }
				}

				/// <summary>
				/// <para>Builder class for producing complex elements with matching field and name pairs. The builder starts empty. The order in which elements are added is retained for the layout in memory. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Add an array of elements to this element.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;I)Landroid/renderscript/Element$" +
    "Builder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscript.Element element, string name, int arraySize) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Add a single element to this Element.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// add
						/// </java-name>
						[Dot42.DexImport("add", "(Landroid/renderscript/Element;Ljava/lang/String;)Landroid/renderscript/Element$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder Add(global::Android.Renderscript.Element element, string name) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Create the element from this builder.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Element </para>
						/// </returns>
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
						/// PIXEL_YUV
						/// </java-name>
						[Dot42.DexImport("PIXEL_YUV", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind PIXEL_YUV;
						/// <java-name>
						/// USER
						/// </java-name>
						[Dot42.DexImport("USER", "Landroid/renderscript/Element$DataKind;", AccessFlags = 16409)]
						public static readonly DataKind USER;
						private DataKind() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
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

				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript double4 type back to the Android system. </para>    
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
		/// <para>Only intended for use by generated reflected code. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Set the active LOD. The LOD must be within the range for the type being adapted. The base allocation must have mipmaps.</para><para>Because this changes the dimensions of the adapter the current Y and Z will be reset.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLOD
				/// </java-name>
				[Dot42.DexImport("setLOD", "(I)V", AccessFlags = 1)]
				public virtual void SetLOD(int lod) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the active Face. The base allocation must be of a type that includes faces.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFace
				/// </java-name>
				[Dot42.DexImport("setFace", "(Landroid/renderscript/Type$CubemapFace;)V", AccessFlags = 1)]
				public virtual void SetFace(global::Android.Renderscript.Type.CubemapFace cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the active Y. The y value must be within the range for the allocation being adapted. The base allocation must contain the Y dimension.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setY
				/// </java-name>
				[Dot42.DexImport("setY", "(I)V", AccessFlags = 1)]
				public virtual void SetY(int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the active Z. The z value must be within the range for the allocation being adapted. The base allocation must contain the Z dimension.</para><para></para>        
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
				public static global::Android.Renderscript.AllocationAdapter Create1D(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Allocation a) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.AllocationAdapter);
				}

				/// <java-name>
				/// create2D
				/// </java-name>
				[Dot42.DexImport("create2D", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Allocation;)Landroid/re" +
    "nderscript/AllocationAdapter;", AccessFlags = 9)]
				public static global::Android.Renderscript.AllocationAdapter Create2D(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Allocation a) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.AllocationAdapter);
				}

				/// <summary>
				/// <para>Override the Allocation resize. Resizing adapters is not allowed and will throw a RSInvalidStateException.</para><para></para>        
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
		/// <para>Intrinsic for applying a per-channel lookup table. Each channel of the input has an independant lookup table. The tables are 256 entries in size and can cover the full value range of Element#U8_4. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicLUT
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicLUT", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicLUT : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicLUT() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Supported elements types are Element#U8_4</para><para>The defaults tables are identity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicLUT </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicLUT;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicLUT Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicLUT);
				}

				/// <summary>
				/// <para>Set an entry in the red channel lookup table</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRed
				/// </java-name>
				[Dot42.DexImport("setRed", "(II)V", AccessFlags = 1)]
				public void SetRed(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set an entry in the green channel lookup table</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGreen
				/// </java-name>
				[Dot42.DexImport("setGreen", "(II)V", AccessFlags = 1)]
				public void SetGreen(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set an entry in the blue channel lookup table</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBlue
				/// </java-name>
				[Dot42.DexImport("setBlue", "(II)V", AccessFlags = 1)]
				public void SetBlue(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set an entry in the alpha channel lookup table</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(II)V", AccessFlags = 1)]
				public void SetAlpha(int index, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invoke the kernel and apply the lookup to each cell of ain and copy to aout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript rs_matrix2x2 type back to the Android system. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/Matrix2f
		/// </java-name>
		[Dot42.DexImport("android/renderscript/Matrix2f", AccessFlags = 33)]
		public partial class Matrix2f
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new identity 2x2 matrix </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Matrix2f() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new matrix and sets its values from the given parameter</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([F)V", AccessFlags = 1)]
				public Matrix2f(float[] dataArray) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
				public virtual float[] GetArray() /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				/// <para>Returns the value for a given row and column</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>value in the yth row and xth column </para>
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
				/// <para>Sets the value for a given row and column</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IIF)V", AccessFlags = 1)]
				public virtual void Set(int x, int y, float v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the matrix values to identity </para>        
				/// </summary>
				/// <java-name>
				/// loadIdentity
				/// </java-name>
				[Dot42.DexImport("loadIdentity", "()V", AccessFlags = 1)]
				public virtual void LoadIdentity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values of the matrix to those of the parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Load(global::Android.Renderscript.Matrix2f src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a rotation matrix of given angle</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadRotate
				/// </java-name>
				[Dot42.DexImport("loadRotate", "(F)V", AccessFlags = 1)]
				public virtual void LoadRotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadScale
				/// </java-name>
				[Dot42.DexImport("loadScale", "(FF)V", AccessFlags = 1)]
				public virtual void LoadScale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets current values to be the result of multiplying two given matrices</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadMultiply
				/// </java-name>
				[Dot42.DexImport("loadMultiply", "(Landroid/renderscript/Matrix2f;Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void LoadMultiply(global::Android.Renderscript.Matrix2f lhs, global::Android.Renderscript.Matrix2f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Post-multiplies the current matrix by a given parameter</para><para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Landroid/renderscript/Matrix2f;)V", AccessFlags = 1)]
				public virtual void Multiply(global::Android.Renderscript.Matrix2f rhs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a rotation matrix of given angle</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rotate
				/// </java-name>
				[Dot42.DexImport("rotate", "(F)V", AccessFlags = 1)]
				public virtual void Rotate(float rot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Modifies the current matrix by post-multiplying it with a scale matrix of given dimensions</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "(FF)V", AccessFlags = 1)]
				public virtual void Scale(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the current matrix to its transpose </para>        
				/// </summary>
				/// <java-name>
				/// transpose
				/// </java-name>
				[Dot42.DexImport("transpose", "()V", AccessFlags = 1)]
				public virtual void Transpose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a reference to the internal array representing matrix values. Modifying this array will also change the matrix</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>internal array representing the matrix </para>
				/// </returns>
				/// <java-name>
				/// getArray
				/// </java-name>
				public float[] Array
				{
				[Dot42.DexImport("getArray", "()[F", AccessFlags = 1)]
						get{ return GetArray(); }
				}

		}

		/// <summary>
		/// <para>Base class for all exceptions thrown by the Android RenderScript </para>    
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
		/// <para>Intrinsic for applying a color matrix to allocations.</para><para>This has the same effect as loading each element and converting it to a Element#F32_4, multiplying the result by the 4x4 color matrix as performed by rsMatrixMultiply() and writing it to the output after conversion back to Element#U8_4. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicColorMatrix
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicColorMatrix", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicColorMatrix : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicColorMatrix() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an intrinsic for applying a color matrix to an allocation.</para><para>Supported elements types are Element#U8_4</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicColorMatrix </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicColorMatrix;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicColorMatrix Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicColorMatrix);
				}

				/// <summary>
				/// <para>Set the color matrix which will be applied to each cell of the image.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColorMatrix
				/// </java-name>
				[Dot42.DexImport("setColorMatrix", "(Landroid/renderscript/Matrix4f;)V", AccessFlags = 1)]
				public void SetColorMatrix(global::Android.Renderscript.Matrix4f m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the color matrix which will be applied to each cell of the image.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColorMatrix
				/// </java-name>
				[Dot42.DexImport("setColorMatrix", "(Landroid/renderscript/Matrix3f;)V", AccessFlags = 1)]
				public void SetColorMatrix(global::Android.Renderscript.Matrix3f m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set a color matrix to convert from RGB to luminance. The alpha channel will be a copy. </para>        
				/// </summary>
				/// <java-name>
				/// setGreyscale
				/// </java-name>
				[Dot42.DexImport("setGreyscale", "()V", AccessFlags = 1)]
				public void SetGreyscale() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the matrix to convert from YUV to RGB with a direct copy of the 4th channel. </para>        
				/// </summary>
				/// <java-name>
				/// setYUVtoRGB
				/// </java-name>
				[Dot42.DexImport("setYUVtoRGB", "()V", AccessFlags = 1)]
				public void SetYUVtoRGB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the matrix to convert from RGB to YUV with a direct copy of the 4th channel. </para>        
				/// </summary>
				/// <java-name>
				/// setRGBtoYUV
				/// </java-name>
				[Dot42.DexImport("setRGBtoYUV", "()V", AccessFlags = 1)]
				public void SetRGBtoYUV() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invoke the kernel and apply the matrix to each cell of ain and copy to aout.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation ain, global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

		}

		/// <summary>
		/// <para>Intrinsic for applying a 3x3 convolve to an allocation. </para>    
		/// </summary>
		/// <java-name>
		/// android/renderscript/ScriptIntrinsicConvolve3x3
		/// </java-name>
		[Dot42.DexImport("android/renderscript/ScriptIntrinsicConvolve3x3", AccessFlags = 49)]
		public sealed partial class ScriptIntrinsicConvolve3x3 : global::Android.Renderscript.ScriptIntrinsic
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScriptIntrinsicConvolve3x3() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Supported elements types are Element#U8_4</para><para>The default coefficients are.</para><para><code> </code></para><para><code> [ 0, 0, 0 ] </code></para><para><code> [ 0, 1, 0 ] </code></para><para><code> [ 0, 0, 0 ] </code></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ScriptIntrinsicConvolve3x3 </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/rende" +
    "rscript/ScriptIntrinsicConvolve3x3;", AccessFlags = 9)]
				public static global::Android.Renderscript.ScriptIntrinsicConvolve3x3 Create(global::Android.Renderscript.RenderScript rs, global::Android.Renderscript.Element e) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.ScriptIntrinsicConvolve3x3);
				}

				/// <summary>
				/// <para>Set the input of the blur. Must match the element type supplied during create.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void SetInput(global::Android.Renderscript.Allocation ain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the coefficients for the convolve.</para><para>The convolve layout is <code> </code></para><para><code> [ 0, 1, 2 ] </code></para><para><code> [ 3, 4, 5 ] </code></para><para><code> [ 6, 7, 8 ] </code></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCoefficients
				/// </java-name>
				[Dot42.DexImport("setCoefficients", "([F)V", AccessFlags = 1)]
				public void SetCoefficients(float[] v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Apply the filter to the input and save to the specified allocation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forEach
				/// </java-name>
				[Dot42.DexImport("forEach", "(Landroid/renderscript/Allocation;)V", AccessFlags = 1)]
				public void ForEach(global::Android.Renderscript.Allocation aout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.KernelID GetKernelID() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.KernelID);
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
				public global::Android.Renderscript.Script.FieldID GetFieldID_Input() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Renderscript.Script.FieldID);
				}

				/// <summary>
				/// <para>Get a KernelID for this intrinsic kernel.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.KernelID The KernelID object. </para>
				/// </returns>
				/// <java-name>
				/// getKernelID
				/// </java-name>
				public global::Android.Renderscript.Script.KernelID KernelID
				{
				[Dot42.DexImport("getKernelID", "()Landroid/renderscript/Script$KernelID;", AccessFlags = 1)]
						get{ return GetKernelID(); }
				}

				/// <summary>
				/// <para>Get a FieldID for the input field of this intrinsic.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Script.FieldID The FieldID object. </para>
				/// </returns>
				/// <java-name>
				/// getFieldID_Input
				/// </java-name>
				public global::Android.Renderscript.Script.FieldID FieldID_Input
				{
				[Dot42.DexImport("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;", AccessFlags = 1)]
						get{ return GetFieldID_Input(); }
				}

		}

		/// <summary>
		/// <para>Class for exposing the native RenderScript short4 type back to the Android system. </para>    
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
		/// <para>Class for exposing the native RenderScript float2 type back to the Android system. </para>    
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

}


