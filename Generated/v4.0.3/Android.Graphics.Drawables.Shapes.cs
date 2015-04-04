#pragma warning disable 1717
namespace Android.Graphics.Drawables.Shapes
{
		/// <java-name>
		/// android/graphics/drawable/shapes/ArcShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/ArcShape", AccessFlags = 33)]
		public partial class ArcShape : global::Android.Graphics.Drawables.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public ArcShape(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// android/graphics/drawable/shapes/OvalShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/OvalShape", AccessFlags = 33)]
		public partial class OvalShape : global::Android.Graphics.Drawables.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OvalShape() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/drawable/shapes/PathShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/PathShape", AccessFlags = 33)]
		public partial class PathShape : global::Android.Graphics.Drawables.Shapes.Shape
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Path;FF)V", AccessFlags = 1)]
				public PathShape(global::Android.Graphics.Path path, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/PathShape;", AccessFlags = 1)]
				public new virtual global::Android.Graphics.Drawables.Shapes.PathShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Shapes.PathShape);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PathShape() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/drawable/shapes/RectShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/RectShape", AccessFlags = 33)]
		public partial class RectShape : global::Android.Graphics.Drawables.Shapes.Shape
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RectShape() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

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
				public new virtual global::Android.Graphics.Drawables.Shapes.RectShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Shapes.RectShape);
				}

		}

		/// <java-name>
		/// android/graphics/drawable/shapes/RoundRectShape
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/shapes/RoundRectShape", AccessFlags = 33)]
		public partial class RoundRectShape : global::Android.Graphics.Drawables.Shapes.RectShape
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([FLandroid/graphics/RectF;[F)V", AccessFlags = 1)]
				public RoundRectShape(float[] single, global::Android.Graphics.RectF rectF, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal override void OnResize(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;", AccessFlags = 1)]
				public new virtual global::Android.Graphics.Drawables.Shapes.RoundRectShape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Shapes.RoundRectShape);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RoundRectShape() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()F", AccessFlags = 17)]
				public float GetWidth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()F", AccessFlags = 17)]
				public float GetHeight() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resize
				/// </java-name>
				[Dot42.DexImport("resize", "(FF)V", AccessFlags = 17)]
				public void Resize(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasAlpha
				/// </java-name>
				[Dot42.DexImport("hasAlpha", "()Z", AccessFlags = 1)]
				public virtual bool HasAlpha() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onResize
				/// </java-name>
				[Dot42.DexImport("onResize", "(FF)V", AccessFlags = 4)]
				protected internal virtual void OnResize(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/graphics/drawable/shapes/Shape;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Shapes.Shape Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Shapes.Shape);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public float Width
				{
				[Dot42.DexImport("getWidth", "()F", AccessFlags = 17)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public float Height
				{
				[Dot42.DexImport("getHeight", "()F", AccessFlags = 17)]
						get{ return GetHeight(); }
				}

		}

}

