// Copyright (C) 2014 dot42
//
// Original filename: Android.Graphics.Drawable.Shapes.cs
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
namespace Android.Graphics.Drawable.Shapes
{
		/// <summary>
		/// <para>Defines a rectangle shape. The rectangle can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass the RectShape to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/RectShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/RectShape", AccessFlags = 33)]
		public partial class RectShape : global::Android.Graphics.Drawable.Shapes.Shape
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>RectShape constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RectShape() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Callback method called when resize(float,float) is executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float width, float height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the RectF that defines this rectangle's bounds. </para>        
				/// </summary>
				/// <java-name>
				/// rect
				/// </java-name>
				[Dot42.DexImport("rect", "()Landroid/graphics/RectF;", AccessFlags = 20)]
				protected internal global::Android.Graphics.RectF Rect() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.RectF);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/RectShape;", AccessFlags = 1)]
				public new virtual global::Android.Graphics.Drawable.Shapes.RectShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.RectShape);
				}

		}

		/// <summary>
		/// <para>Defines an oval shape. The oval can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass the OvalShape to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/OvalShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/OvalShape", AccessFlags = 33)]
		public partial class OvalShape : global::Android.Graphics.Drawable.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>OvalShape constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OvalShape() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Creates a rounded-corner rectangle. Optionally, an inset (rounded) rectangle can be included (to make a sort of "O" shape). The rounded rectangle can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass the RoundRectShape to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/RoundRectShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/RoundRectShape", AccessFlags = 33)]
		public partial class RoundRectShape : global::Android.Graphics.Drawable.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>RoundRectShape constructor. Specifies an outer (round)rect and an optional inner (round)rect.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([FLandroid/graphics/RectF;[F)V", AccessFlags = 1)]
				public RoundRectShape(float[] outerRadii, global::Android.Graphics.RectF inset, float[] innerRadii) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Callback method called when resize(float,float) is executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float width, float height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;", AccessFlags = 1)]
				public new virtual global::Android.Graphics.Drawable.Shapes.RoundRectShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.RoundRectShape);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RoundRectShape() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Creates geometric paths, utilizing the android.graphics.Path class. The path can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass the PathShape to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/PathShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/PathShape", AccessFlags = 33)]
		public partial class PathShape : global::Android.Graphics.Drawable.Shapes.Shape
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>PathShape constructor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;FF)V", AccessFlags = 1)]
				public PathShape(global::Android.Graphics.Path path, float stdWidth, float stdHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Callback method called when resize(float,float) is executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float width, float height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/PathShape;", AccessFlags = 1)]
				public new virtual global::Android.Graphics.Drawable.Shapes.PathShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.PathShape);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PathShape() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines a generic graphical "shape." Any Shape can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass it to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/Shape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/Shape", AccessFlags = 1057)]
		public abstract partial class Shape : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Shape() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the width of the Shape. </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()F", AccessFlags = 17)]
				public float GetWidth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the height of the Shape. </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()F", AccessFlags = 17)]
				public float GetHeight() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Resizes the dimensions of this shape. Must be called before draw(Canvas,Paint).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(FF)V", AccessFlags = 17)]
				public void Resize(float width, float height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether the Shape is opaque. Default impl returns true. Override if your subclass can be opaque.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if any part of the drawable is <b>not</b> opaque. </para>
				/// </returns>
				/// <java-name>
				/// hasAlpha
				/// </java-name>
				[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 1)]
				public virtual bool HasAlpha() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Callback method called when resize(float,float) is executed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal virtual void OnResize(float width, float height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/Shape;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Shapes.Shape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.Shape);
				}

				/// <summary>
				/// <para>Returns the width of the Shape. </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public float Width
				{
				[Dot42.DexImport("getWidth", "()F", AccessFlags = 17)]
						get{ return GetWidth(); }
				}

				/// <summary>
				/// <para>Returns the height of the Shape. </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public float Height
				{
				[Dot42.DexImport("getHeight", "()F", AccessFlags = 17)]
						get{ return GetHeight(); }
				}

		}

		/// <summary>
		/// <para>Creates an arc shape. The arc shape starts at a specified angle and sweeps clockwise, drawing slices of pie. The arc can be drawn to a Canvas with its own draw() method, but more graphical control is available if you instead pass the ArcShape to a android.graphics.drawable.ShapeDrawable. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/shapes/ArcShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/ArcShape", AccessFlags = 33)]
		public partial class ArcShape : global::Android.Graphics.Drawable.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>ArcShape constructor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public ArcShape(float startAngle, float sweepAngle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw this shape into the provided Canvas, with the provided Paint. Before calling this, you must call resize(float,float).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ArcShape() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


