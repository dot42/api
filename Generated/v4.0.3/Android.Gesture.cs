#pragma warning disable 1717
namespace Android.Gesture
{
		/// <java-name>
		/// android/gesture/Gesture
		/// </java-name>
		[Dot42.DexImport("android/gesture/Gesture", AccessFlags = 33)]
		public partial class Gesture : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Gesture.Gesture> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Gesture() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getStrokes
				/// </java-name>
				[Dot42.DexImport("getStrokes", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/gesture/GestureStroke;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.GestureStroke> GetStrokes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.GestureStroke>);
				}

				/// <java-name>
				/// getStrokesCount
				/// </java-name>
				[Dot42.DexImport("getStrokesCount", "()I", AccessFlags = 1)]
				public virtual int GetStrokesCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addStroke
				/// </java-name>
				[Dot42.DexImport("addStroke", "(Landroid/gesture/GestureStroke;)V", AccessFlags = 1)]
				public virtual void AddStroke(global::Android.Gesture.GestureStroke gestureStroke) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()F", AccessFlags = 1)]
				public virtual float GetLength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getBoundingBox
				/// </java-name>
				[Dot42.DexImport("getBoundingBox", "()Landroid/graphics/RectF;", AccessFlags = 1)]
				public virtual global::Android.Graphics.RectF GetBoundingBox() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.RectF);
				}

				/// <java-name>
				/// toPath
				/// </java-name>
				[Dot42.DexImport("toPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path ToPath() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// toPath
				/// </java-name>
				[Dot42.DexImport("toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path ToPath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// toPath
				/// </java-name>
				[Dot42.DexImport("toPath", "(IIII)Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path ToPath(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// toPath
				/// </java-name>
				[Dot42.DexImport("toPath", "(Landroid/graphics/Path;IIII)Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path ToPath(global::Android.Graphics.Path path, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// getID
				/// </java-name>
				[Dot42.DexImport("getID", "()J", AccessFlags = 1)]
				public virtual long GetID() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// toBitmap
				/// </java-name>
				[Dot42.DexImport("toBitmap", "(IIIII)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap ToBitmap(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// toBitmap
				/// </java-name>
				[Dot42.DexImport("toBitmap", "(IIII)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap ToBitmap(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStrokes
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Gesture.GestureStroke> Strokes
				{
				[Dot42.DexImport("getStrokes", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/gesture/GestureStroke;>;")]
						get{ return GetStrokes(); }
				}

				/// <java-name>
				/// getStrokesCount
				/// </java-name>
				public int StrokesCount
				{
				[Dot42.DexImport("getStrokesCount", "()I", AccessFlags = 1)]
						get{ return GetStrokesCount(); }
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public float Length
				{
				[Dot42.DexImport("getLength", "()F", AccessFlags = 1)]
						get{ return GetLength(); }
				}

				/// <java-name>
				/// getBoundingBox
				/// </java-name>
				public global::Android.Graphics.RectF BoundingBox
				{
				[Dot42.DexImport("getBoundingBox", "()Landroid/graphics/RectF;", AccessFlags = 1)]
						get{ return GetBoundingBox(); }
				}

				/// <java-name>
				/// getID
				/// </java-name>
				public long ID
				{
				[Dot42.DexImport("getID", "()J", AccessFlags = 1)]
						get{ return GetID(); }
				}

		}

		/// <java-name>
		/// android/gesture/GestureLibraries
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureLibraries", AccessFlags = 49)]
		public sealed partial class GestureLibraries
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GestureLibraries() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fromFile
				/// </java-name>
				[Dot42.DexImport("fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;", AccessFlags = 9)]
				public static global::Android.Gesture.GestureLibrary FromFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.GestureLibrary);
				}

				/// <java-name>
				/// fromFile
				/// </java-name>
				[Dot42.DexImport("fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;", AccessFlags = 9)]
				public static global::Android.Gesture.GestureLibrary FromFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.GestureLibrary);
				}

				/// <java-name>
				/// fromPrivateFile
				/// </java-name>
				[Dot42.DexImport("fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;", AccessFlags = 9)]
				public static global::Android.Gesture.GestureLibrary FromPrivateFile(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.GestureLibrary);
				}

				/// <java-name>
				/// fromRawResource
				/// </java-name>
				[Dot42.DexImport("fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;", AccessFlags = 9)]
				public static global::Android.Gesture.GestureLibrary FromRawResource(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.GestureLibrary);
				}

		}

		/// <java-name>
		/// android/gesture/GestureLibrary
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureLibrary", AccessFlags = 1057)]
		public abstract partial class GestureLibrary
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mStore
				/// </java-name>
				[Dot42.DexImport("mStore", "Landroid/gesture/GestureStore;", AccessFlags = 20)]
				protected internal readonly global::Android.Gesture.GestureStore MStore;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal GestureLibrary() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "()Z", AccessFlags = 1025)]
				public abstract bool Save() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "()Z", AccessFlags = 1025)]
				public abstract bool Load() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOrientationStyle
				/// </java-name>
				[Dot42.DexImport("setOrientationStyle", "(I)V", AccessFlags = 1)]
				public virtual void SetOrientationStyle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOrientationStyle
				/// </java-name>
				[Dot42.DexImport("getOrientationStyle", "()I", AccessFlags = 1)]
				public virtual int GetOrientationStyle() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSequenceType
				/// </java-name>
				[Dot42.DexImport("setSequenceType", "(I)V", AccessFlags = 1)]
				public virtual void SetSequenceType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSequenceType
				/// </java-name>
				[Dot42.DexImport("getSequenceType", "()I", AccessFlags = 1)]
				public virtual int GetSequenceType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGestureEntries
				/// </java-name>
				[Dot42.DexImport("getGestureEntries", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetGestureEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// recognize
				/// </java-name>
				[Dot42.DexImport("recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Landroid/gesture/Gesture;)Ljava/util/ArrayList<Landroid/gesture/Prediction;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.Prediction> Recognize(global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.Prediction>);
				}

				/// <java-name>
				/// addGesture
				/// </java-name>
				[Dot42.DexImport("addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", AccessFlags = 1)]
				public virtual void AddGesture(string @string, global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeGesture
				/// </java-name>
				[Dot42.DexImport("removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", AccessFlags = 1)]
				public virtual void RemoveGesture(string @string, global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeEntry
				/// </java-name>
				[Dot42.DexImport("removeEntry", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveEntry(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestures
				/// </java-name>
				[Dot42.DexImport("getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Landroid/gesture/Gesture;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.Gesture> GetGestures(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.Gesture>);
				}

				/// <java-name>
				/// getOrientationStyle
				/// </java-name>
				public int OrientationStyle
				{
				[Dot42.DexImport("getOrientationStyle", "()I", AccessFlags = 1)]
						get{ return GetOrientationStyle(); }
				[Dot42.DexImport("setOrientationStyle", "(I)V", AccessFlags = 1)]
						set{ SetOrientationStyle(value); }
				}

				/// <java-name>
				/// getSequenceType
				/// </java-name>
				public int SequenceType
				{
				[Dot42.DexImport("getSequenceType", "()I", AccessFlags = 1)]
						get{ return GetSequenceType(); }
				[Dot42.DexImport("setSequenceType", "(I)V", AccessFlags = 1)]
						set{ SetSequenceType(value); }
				}

				/// <java-name>
				/// getGestureEntries
				/// </java-name>
				public global::Java.Util.ISet<string> GestureEntries
				{
				[Dot42.DexImport("getGestureEntries", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return GetGestureEntries(); }
				}

		}

		/// <java-name>
		/// android/gesture/GestureOverlayView
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureOverlayView", AccessFlags = 33)]
		public partial class GestureOverlayView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GESTURE_STROKE_TYPE_SINGLE
				/// </java-name>
				[Dot42.DexImport("GESTURE_STROKE_TYPE_SINGLE", "I", AccessFlags = 25)]
				public const int GESTURE_STROKE_TYPE_SINGLE = 0;
				/// <java-name>
				/// GESTURE_STROKE_TYPE_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("GESTURE_STROKE_TYPE_MULTIPLE", "I", AccessFlags = 25)]
				public const int GESTURE_STROKE_TYPE_MULTIPLE = 1;
				/// <java-name>
				/// ORIENTATION_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_HORIZONTAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_HORIZONTAL = 0;
				/// <java-name>
				/// ORIENTATION_VERTICAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_VERTICAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_VERTICAL = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public GestureOverlayView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GestureOverlayView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public GestureOverlayView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentStroke
				/// </java-name>
				[Dot42.DexImport("getCurrentStroke", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/gesture/GesturePoint;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.GesturePoint> GetCurrentStroke() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.GesturePoint>);
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "()I", AccessFlags = 1)]
				public virtual int GetOrientation() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setOrientation
				/// </java-name>
				[Dot42.DexImport("setOrientation", "(I)V", AccessFlags = 1)]
				public virtual void SetOrientation(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGestureColor
				/// </java-name>
				[Dot42.DexImport("setGestureColor", "(I)V", AccessFlags = 1)]
				public virtual void SetGestureColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUncertainGestureColor
				/// </java-name>
				[Dot42.DexImport("setUncertainGestureColor", "(I)V", AccessFlags = 1)]
				public virtual void SetUncertainGestureColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUncertainGestureColor
				/// </java-name>
				[Dot42.DexImport("getUncertainGestureColor", "()I", AccessFlags = 1)]
				public virtual int GetUncertainGestureColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGestureColor
				/// </java-name>
				[Dot42.DexImport("getGestureColor", "()I", AccessFlags = 1)]
				public virtual int GetGestureColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGestureStrokeWidth
				/// </java-name>
				[Dot42.DexImport("getGestureStrokeWidth", "()F", AccessFlags = 1)]
				public virtual float GetGestureStrokeWidth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setGestureStrokeWidth
				/// </java-name>
				[Dot42.DexImport("setGestureStrokeWidth", "(F)V", AccessFlags = 1)]
				public virtual void SetGestureStrokeWidth(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestureStrokeType
				/// </java-name>
				[Dot42.DexImport("getGestureStrokeType", "()I", AccessFlags = 1)]
				public virtual int GetGestureStrokeType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setGestureStrokeType
				/// </java-name>
				[Dot42.DexImport("setGestureStrokeType", "(I)V", AccessFlags = 1)]
				public virtual void SetGestureStrokeType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestureStrokeLengthThreshold
				/// </java-name>
				[Dot42.DexImport("getGestureStrokeLengthThreshold", "()F", AccessFlags = 1)]
				public virtual float GetGestureStrokeLengthThreshold() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setGestureStrokeLengthThreshold
				/// </java-name>
				[Dot42.DexImport("setGestureStrokeLengthThreshold", "(F)V", AccessFlags = 1)]
				public virtual void SetGestureStrokeLengthThreshold(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestureStrokeSquarenessTreshold
				/// </java-name>
				[Dot42.DexImport("getGestureStrokeSquarenessTreshold", "()F", AccessFlags = 1)]
				public virtual float GetGestureStrokeSquarenessTreshold() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setGestureStrokeSquarenessTreshold
				/// </java-name>
				[Dot42.DexImport("setGestureStrokeSquarenessTreshold", "(F)V", AccessFlags = 1)]
				public virtual void SetGestureStrokeSquarenessTreshold(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestureStrokeAngleThreshold
				/// </java-name>
				[Dot42.DexImport("getGestureStrokeAngleThreshold", "()F", AccessFlags = 1)]
				public virtual float GetGestureStrokeAngleThreshold() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setGestureStrokeAngleThreshold
				/// </java-name>
				[Dot42.DexImport("setGestureStrokeAngleThreshold", "(F)V", AccessFlags = 1)]
				public virtual void SetGestureStrokeAngleThreshold(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEventsInterceptionEnabled
				/// </java-name>
				[Dot42.DexImport("isEventsInterceptionEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEventsInterceptionEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEventsInterceptionEnabled
				/// </java-name>
				[Dot42.DexImport("setEventsInterceptionEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEventsInterceptionEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFadeEnabled
				/// </java-name>
				[Dot42.DexImport("isFadeEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsFadeEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFadeEnabled
				/// </java-name>
				[Dot42.DexImport("setFadeEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetFadeEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGesture
				/// </java-name>
				[Dot42.DexImport("getGesture", "()Landroid/gesture/Gesture;", AccessFlags = 1)]
				public virtual global::Android.Gesture.Gesture GetGesture() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.Gesture);
				}

				/// <java-name>
				/// setGesture
				/// </java-name>
				[Dot42.DexImport("setGesture", "(Landroid/gesture/Gesture;)V", AccessFlags = 1)]
				public virtual void SetGesture(global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGesturePath
				/// </java-name>
				[Dot42.DexImport("getGesturePath", "()Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path GetGesturePath() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// getGesturePath
				/// </java-name>
				[Dot42.DexImport("getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path GetGesturePath(global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// isGestureVisible
				/// </java-name>
				[Dot42.DexImport("isGestureVisible", "()Z", AccessFlags = 1)]
				public virtual bool IsGestureVisible() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setGestureVisible
				/// </java-name>
				[Dot42.DexImport("setGestureVisible", "(Z)V", AccessFlags = 1)]
				public virtual void SetGestureVisible(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFadeOffset
				/// </java-name>
				[Dot42.DexImport("getFadeOffset", "()J", AccessFlags = 1)]
				public virtual long GetFadeOffset() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setFadeOffset
				/// </java-name>
				[Dot42.DexImport("setFadeOffset", "(J)V", AccessFlags = 1)]
				public virtual void SetFadeOffset(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnGestureListener
				/// </java-name>
				[Dot42.DexImport("addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", AccessFlags = 1)]
				public virtual void AddOnGestureListener(global::Android.Gesture.GestureOverlayView.IOnGestureListener onGestureListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnGestureListener
				/// </java-name>
				[Dot42.DexImport("removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnGestureListener(global::Android.Gesture.GestureOverlayView.IOnGestureListener onGestureListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllOnGestureListeners
				/// </java-name>
				[Dot42.DexImport("removeAllOnGestureListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllOnGestureListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnGesturePerformedListener
				/// </java-name>
				[Dot42.DexImport("addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", AccessFlags = 1)]
				public virtual void AddOnGesturePerformedListener(global::Android.Gesture.GestureOverlayView.IOnGesturePerformedListener onGesturePerformedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnGesturePerformedListener
				/// </java-name>
				[Dot42.DexImport("removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnGesturePerformedListener(global::Android.Gesture.GestureOverlayView.IOnGesturePerformedListener onGesturePerformedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllOnGesturePerformedListeners
				/// </java-name>
				[Dot42.DexImport("removeAllOnGesturePerformedListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllOnGesturePerformedListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnGesturingListener
				/// </java-name>
				[Dot42.DexImport("addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", AccessFlags = 1)]
				public virtual void AddOnGesturingListener(global::Android.Gesture.GestureOverlayView.IOnGesturingListener onGesturingListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnGesturingListener
				/// </java-name>
				[Dot42.DexImport("removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnGesturingListener(global::Android.Gesture.GestureOverlayView.IOnGesturingListener onGesturingListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllOnGesturingListeners
				/// </java-name>
				[Dot42.DexImport("removeAllOnGesturingListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllOnGesturingListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isGesturing
				/// </java-name>
				[Dot42.DexImport("isGesturing", "()Z", AccessFlags = 1)]
				public virtual bool IsGesturing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Z)V", AccessFlags = 1)]
				public virtual void Clear(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelClearAnimation
				/// </java-name>
				[Dot42.DexImport("cancelClearAnimation", "()V", AccessFlags = 1)]
				public virtual void CancelClearAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelGesture
				/// </java-name>
				[Dot42.DexImport("cancelGesture", "()V", AccessFlags = 1)]
				public virtual void CancelGesture() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool DispatchTouchEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GestureOverlayView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCurrentStroke
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Gesture.GesturePoint> CurrentStroke
				{
				[Dot42.DexImport("getCurrentStroke", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/gesture/GesturePoint;>;")]
						get{ return GetCurrentStroke(); }
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				public int Orientation
				{
				[Dot42.DexImport("getOrientation", "()I", AccessFlags = 1)]
						get{ return GetOrientation(); }
				[Dot42.DexImport("setOrientation", "(I)V", AccessFlags = 1)]
						set{ SetOrientation(value); }
				}

				/// <java-name>
				/// getUncertainGestureColor
				/// </java-name>
				public int UncertainGestureColor
				{
				[Dot42.DexImport("getUncertainGestureColor", "()I", AccessFlags = 1)]
						get{ return GetUncertainGestureColor(); }
				[Dot42.DexImport("setUncertainGestureColor", "(I)V", AccessFlags = 1)]
						set{ SetUncertainGestureColor(value); }
				}

				/// <java-name>
				/// getGestureColor
				/// </java-name>
				public int GestureColor
				{
				[Dot42.DexImport("getGestureColor", "()I", AccessFlags = 1)]
						get{ return GetGestureColor(); }
				[Dot42.DexImport("setGestureColor", "(I)V", AccessFlags = 1)]
						set{ SetGestureColor(value); }
				}

				/// <java-name>
				/// getGestureStrokeWidth
				/// </java-name>
				public float GestureStrokeWidth
				{
				[Dot42.DexImport("getGestureStrokeWidth", "()F", AccessFlags = 1)]
						get{ return GetGestureStrokeWidth(); }
				[Dot42.DexImport("setGestureStrokeWidth", "(F)V", AccessFlags = 1)]
						set{ SetGestureStrokeWidth(value); }
				}

				/// <java-name>
				/// getGestureStrokeType
				/// </java-name>
				public int GestureStrokeType
				{
				[Dot42.DexImport("getGestureStrokeType", "()I", AccessFlags = 1)]
						get{ return GetGestureStrokeType(); }
				[Dot42.DexImport("setGestureStrokeType", "(I)V", AccessFlags = 1)]
						set{ SetGestureStrokeType(value); }
				}

				/// <java-name>
				/// getGestureStrokeLengthThreshold
				/// </java-name>
				public float GestureStrokeLengthThreshold
				{
				[Dot42.DexImport("getGestureStrokeLengthThreshold", "()F", AccessFlags = 1)]
						get{ return GetGestureStrokeLengthThreshold(); }
				[Dot42.DexImport("setGestureStrokeLengthThreshold", "(F)V", AccessFlags = 1)]
						set{ SetGestureStrokeLengthThreshold(value); }
				}

				/// <java-name>
				/// getGestureStrokeSquarenessTreshold
				/// </java-name>
				public float GestureStrokeSquarenessTreshold
				{
				[Dot42.DexImport("getGestureStrokeSquarenessTreshold", "()F", AccessFlags = 1)]
						get{ return GetGestureStrokeSquarenessTreshold(); }
				[Dot42.DexImport("setGestureStrokeSquarenessTreshold", "(F)V", AccessFlags = 1)]
						set{ SetGestureStrokeSquarenessTreshold(value); }
				}

				/// <java-name>
				/// getGestureStrokeAngleThreshold
				/// </java-name>
				public float GestureStrokeAngleThreshold
				{
				[Dot42.DexImport("getGestureStrokeAngleThreshold", "()F", AccessFlags = 1)]
						get{ return GetGestureStrokeAngleThreshold(); }
				[Dot42.DexImport("setGestureStrokeAngleThreshold", "(F)V", AccessFlags = 1)]
						set{ SetGestureStrokeAngleThreshold(value); }
				}

				/// <java-name>
				/// getGesture
				/// </java-name>
				public global::Android.Gesture.Gesture Gesture
				{
				[Dot42.DexImport("getGesture", "()Landroid/gesture/Gesture;", AccessFlags = 1)]
						get{ return GetGesture(); }
				[Dot42.DexImport("setGesture", "(Landroid/gesture/Gesture;)V", AccessFlags = 1)]
						set{ SetGesture(value); }
				}

				/// <java-name>
				/// getGesturePath
				/// </java-name>
				public global::Android.Graphics.Path GesturePath
				{
				[Dot42.DexImport("getGesturePath", "()Landroid/graphics/Path;", AccessFlags = 1)]
						get{ return GetGesturePath(); }
				}

				/// <java-name>
				/// getFadeOffset
				/// </java-name>
				public long FadeOffset
				{
				[Dot42.DexImport("getFadeOffset", "()J", AccessFlags = 1)]
						get{ return GetFadeOffset(); }
				[Dot42.DexImport("setFadeOffset", "(J)V", AccessFlags = 1)]
						set{ SetFadeOffset(value); }
				}

				/// <java-name>
				/// android/gesture/GestureOverlayView$OnGesturePerformedListener
				/// </java-name>
				[Dot42.DexImport("android/gesture/GestureOverlayView$OnGesturePerformedListener", AccessFlags = 1545)]
				public partial interface IOnGesturePerformedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGesturePerformed
						/// </java-name>
						[Dot42.DexImport("onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V", AccessFlags = 1025)]
						void OnGesturePerformed(global::Android.Gesture.GestureOverlayView gestureOverlayView, global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/gesture/GestureOverlayView$OnGestureListener
				/// </java-name>
				[Dot42.DexImport("android/gesture/GestureOverlayView$OnGestureListener", AccessFlags = 1545)]
				public partial interface IOnGestureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGestureStarted
						/// </java-name>
						[Dot42.DexImport("onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnGestureStarted(global::Android.Gesture.GestureOverlayView gestureOverlayView, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGesture
						/// </java-name>
						[Dot42.DexImport("onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnGesture(global::Android.Gesture.GestureOverlayView gestureOverlayView, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGestureEnded
						/// </java-name>
						[Dot42.DexImport("onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnGestureEnded(global::Android.Gesture.GestureOverlayView gestureOverlayView, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGestureCancelled
						/// </java-name>
						[Dot42.DexImport("onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnGestureCancelled(global::Android.Gesture.GestureOverlayView gestureOverlayView, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/gesture/GestureOverlayView$OnGesturingListener
				/// </java-name>
				[Dot42.DexImport("android/gesture/GestureOverlayView$OnGesturingListener", AccessFlags = 1545)]
				public partial interface IOnGesturingListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGesturingStarted
						/// </java-name>
						[Dot42.DexImport("onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V", AccessFlags = 1025)]
						void OnGesturingStarted(global::Android.Gesture.GestureOverlayView gestureOverlayView) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onGesturingEnded
						/// </java-name>
						[Dot42.DexImport("onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V", AccessFlags = 1025)]
						void OnGesturingEnded(global::Android.Gesture.GestureOverlayView gestureOverlayView) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/gesture/GesturePoint
		/// </java-name>
		[Dot42.DexImport("android/gesture/GesturePoint", AccessFlags = 33)]
		public partial class GesturePoint
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "F", AccessFlags = 17)]
				public readonly float X;
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "F", AccessFlags = 17)]
				public readonly float Y;
				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "J", AccessFlags = 17)]
				public readonly long Timestamp;
				[Dot42.DexImport("<init>", "(FFJ)V", AccessFlags = 1)]
				public GesturePoint(float single, float single1, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GesturePoint() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/gesture/GestureStore
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureStore", AccessFlags = 33)]
		public partial class GestureStore
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SEQUENCE_INVARIANT
				/// </java-name>
				[Dot42.DexImport("SEQUENCE_INVARIANT", "I", AccessFlags = 25)]
				public const int SEQUENCE_INVARIANT = 1;
				/// <java-name>
				/// SEQUENCE_SENSITIVE
				/// </java-name>
				[Dot42.DexImport("SEQUENCE_SENSITIVE", "I", AccessFlags = 25)]
				public const int SEQUENCE_SENSITIVE = 2;
				/// <java-name>
				/// ORIENTATION_INVARIANT
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_INVARIANT", "I", AccessFlags = 25)]
				public const int ORIENTATION_INVARIANT = 1;
				/// <java-name>
				/// ORIENTATION_SENSITIVE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_SENSITIVE", "I", AccessFlags = 25)]
				public const int ORIENTATION_SENSITIVE = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GestureStore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOrientationStyle
				/// </java-name>
				[Dot42.DexImport("setOrientationStyle", "(I)V", AccessFlags = 1)]
				public virtual void SetOrientationStyle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOrientationStyle
				/// </java-name>
				[Dot42.DexImport("getOrientationStyle", "()I", AccessFlags = 1)]
				public virtual int GetOrientationStyle() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSequenceType
				/// </java-name>
				[Dot42.DexImport("setSequenceType", "(I)V", AccessFlags = 1)]
				public virtual void SetSequenceType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSequenceType
				/// </java-name>
				[Dot42.DexImport("getSequenceType", "()I", AccessFlags = 1)]
				public virtual int GetSequenceType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGestureEntries
				/// </java-name>
				[Dot42.DexImport("getGestureEntries", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetGestureEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// recognize
				/// </java-name>
				[Dot42.DexImport("recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Landroid/gesture/Gesture;)Ljava/util/ArrayList<Landroid/gesture/Prediction;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.Prediction> Recognize(global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.Prediction>);
				}

				/// <java-name>
				/// addGesture
				/// </java-name>
				[Dot42.DexImport("addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", AccessFlags = 1)]
				public virtual void AddGesture(string @string, global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeGesture
				/// </java-name>
				[Dot42.DexImport("removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", AccessFlags = 1)]
				public virtual void RemoveGesture(string @string, global::Android.Gesture.Gesture gesture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeEntry
				/// </java-name>
				[Dot42.DexImport("removeEntry", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveEntry(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGestures
				/// </java-name>
				[Dot42.DexImport("getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Landroid/gesture/Gesture;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Gesture.Gesture> GetGestures(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Gesture.Gesture>);
				}

				/// <java-name>
				/// hasChanged
				/// </java-name>
				[Dot42.DexImport("hasChanged", "()Z", AccessFlags = 1)]
				public virtual bool HasChanged() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void Save(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// save
				/// </java-name>
				[Dot42.DexImport("save", "(Ljava/io/OutputStream;Z)V", AccessFlags = 1)]
				public virtual void Save(global::Java.Io.OutputStream outputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void Load(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;Z)V", AccessFlags = 1)]
				public virtual void Load(global::Java.Io.InputStream inputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOrientationStyle
				/// </java-name>
				public int OrientationStyle
				{
				[Dot42.DexImport("getOrientationStyle", "()I", AccessFlags = 1)]
						get{ return GetOrientationStyle(); }
				[Dot42.DexImport("setOrientationStyle", "(I)V", AccessFlags = 1)]
						set{ SetOrientationStyle(value); }
				}

				/// <java-name>
				/// getSequenceType
				/// </java-name>
				public int SequenceType
				{
				[Dot42.DexImport("getSequenceType", "()I", AccessFlags = 1)]
						get{ return GetSequenceType(); }
				[Dot42.DexImport("setSequenceType", "(I)V", AccessFlags = 1)]
						set{ SetSequenceType(value); }
				}

				/// <java-name>
				/// getGestureEntries
				/// </java-name>
				public global::Java.Util.ISet<string> GestureEntries
				{
				[Dot42.DexImport("getGestureEntries", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return GetGestureEntries(); }
				}

		}

		/// <java-name>
		/// android/gesture/GestureStroke
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureStroke", AccessFlags = 33)]
		public partial class GestureStroke
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// boundingBox
				/// </java-name>
				[Dot42.DexImport("boundingBox", "Landroid/graphics/RectF;", AccessFlags = 17)]
				public readonly global::Android.Graphics.RectF BoundingBox;
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "F", AccessFlags = 17)]
				public readonly float Length;
				/// <java-name>
				/// points
				/// </java-name>
				[Dot42.DexImport("points", "[F", AccessFlags = 17)]
				public readonly float[] Points;
				[Dot42.DexImport("<init>", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/gesture/GesturePoint;>;)V")]
				public GestureStroke(global::Java.Util.ArrayList<global::Android.Gesture.GesturePoint> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path GetPath() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// toPath
				/// </java-name>
				[Dot42.DexImport("toPath", "(FFI)Landroid/graphics/Path;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Path ToPath(float single, float single1, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Path);
				}

				/// <java-name>
				/// clearPath
				/// </java-name>
				[Dot42.DexImport("clearPath", "()V", AccessFlags = 1)]
				public virtual void ClearPath() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeOrientedBoundingBox
				/// </java-name>
				[Dot42.DexImport("computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;", AccessFlags = 1)]
				public virtual global::Android.Gesture.OrientedBoundingBox ComputeOrientedBoundingBox() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.OrientedBoundingBox);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GestureStroke() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public global::Android.Graphics.Path Path
				{
				[Dot42.DexImport("getPath", "()Landroid/graphics/Path;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

		}

		/// <java-name>
		/// android/gesture/GestureUtils
		/// </java-name>
		[Dot42.DexImport("android/gesture/GestureUtils", AccessFlags = 49)]
		public sealed partial class GestureUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GestureUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// spatialSampling
				/// </java-name>
				[Dot42.DexImport("spatialSampling", "(Landroid/gesture/Gesture;I)[F", AccessFlags = 9)]
				public static float[] SpatialSampling(global::Android.Gesture.Gesture gesture, int int32) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// spatialSampling
				/// </java-name>
				[Dot42.DexImport("spatialSampling", "(Landroid/gesture/Gesture;IZ)[F", AccessFlags = 9)]
				public static float[] SpatialSampling(global::Android.Gesture.Gesture gesture, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// temporalSampling
				/// </java-name>
				[Dot42.DexImport("temporalSampling", "(Landroid/gesture/GestureStroke;I)[F", AccessFlags = 9)]
				public static float[] TemporalSampling(global::Android.Gesture.GestureStroke gestureStroke, int int32) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// computeOrientedBoundingBox
				/// </java-name>
				[Dot42.DexImport("computeOrientedBoundingBox", "(Ljava/util/ArrayList;)Landroid/gesture/OrientedBoundingBox;", AccessFlags = 9, Signature = "(Ljava/util/ArrayList<Landroid/gesture/GesturePoint;>;)Landroid/gesture/OrientedB" +
    "oundingBox;")]
				public static global::Android.Gesture.OrientedBoundingBox ComputeOrientedBoundingBox(global::Java.Util.ArrayList<global::Android.Gesture.GesturePoint> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.OrientedBoundingBox);
				}

				/// <java-name>
				/// computeOrientedBoundingBox
				/// </java-name>
				[Dot42.DexImport("computeOrientedBoundingBox", "([F)Landroid/gesture/OrientedBoundingBox;", AccessFlags = 9)]
				public static global::Android.Gesture.OrientedBoundingBox ComputeOrientedBoundingBox(float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Gesture.OrientedBoundingBox);
				}

		}

		/// <java-name>
		/// android/gesture/OrientedBoundingBox
		/// </java-name>
		[Dot42.DexImport("android/gesture/OrientedBoundingBox", AccessFlags = 33)]
		public partial class OrientedBoundingBox
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// squareness
				/// </java-name>
				[Dot42.DexImport("squareness", "F", AccessFlags = 17)]
				public readonly float Squareness;
				/// <java-name>
				/// width
				/// </java-name>
				[Dot42.DexImport("width", "F", AccessFlags = 17)]
				public readonly float Width;
				/// <java-name>
				/// height
				/// </java-name>
				[Dot42.DexImport("height", "F", AccessFlags = 17)]
				public readonly float Height;
				/// <java-name>
				/// orientation
				/// </java-name>
				[Dot42.DexImport("orientation", "F", AccessFlags = 17)]
				public readonly float Orientation;
				/// <java-name>
				/// centerX
				/// </java-name>
				[Dot42.DexImport("centerX", "F", AccessFlags = 17)]
				public readonly float CenterX;
				/// <java-name>
				/// centerY
				/// </java-name>
				[Dot42.DexImport("centerY", "F", AccessFlags = 17)]
				public readonly float CenterY;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OrientedBoundingBox() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/gesture/Prediction
		/// </java-name>
		[Dot42.DexImport("android/gesture/Prediction", AccessFlags = 33)]
		public partial class Prediction
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Name;
				/// <java-name>
				/// score
				/// </java-name>
				[Dot42.DexImport("score", "D", AccessFlags = 1)]
				public double Score;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Prediction() /* MethodBuilder.Create */ 
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

}

