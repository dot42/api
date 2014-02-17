// Copyright (C) 2014 dot42
//
// Original filename: Android.Inputmethodservice.cs
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
namespace Android.Inputmethodservice
{
		/// <summary>
		/// <para>Loads an XML description of a keyboard and stores the attributes of the keys. A keyboard consists of rows of keys. </para><para>The layout file for a keyboard contains XML that looks like the following snippet:</para><para><pre>
		///    &lt;Keyboard
		///            android:keyWidth="%10p"
		///            android:keyHeight="50px"
		///            android:horizontalGap="2px"
		///            android:verticalGap="2px" &gt;
		///        &lt;Row android:keyWidth="32px" &gt;
		///            &lt;Key android:keyLabel="A" /&gt;
		///            ...
		///        &lt;/Row&gt;
		///        ...
		///    &lt;/Keyboard&gt;
		///    </pre>  ref android.R.styleable::Keyboard_keyWidth  ref android.R.styleable::Keyboard_keyHeight  ref android.R.styleable::Keyboard_horizontalGap  ref android.R.styleable::Keyboard_verticalGap </para>    
		/// </summary>
		/// <java-name>
		/// android/inputmethodservice/Keyboard
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/Keyboard", AccessFlags = 33)]
		public partial class Keyboard
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EDGE_LEFT
				/// </java-name>
				[Dot42.DexImport("EDGE_LEFT", "I", AccessFlags = 25)]
				public const int EDGE_LEFT = 1;
				/// <java-name>
				/// EDGE_RIGHT
				/// </java-name>
				[Dot42.DexImport("EDGE_RIGHT", "I", AccessFlags = 25)]
				public const int EDGE_RIGHT = 2;
				/// <java-name>
				/// EDGE_TOP
				/// </java-name>
				[Dot42.DexImport("EDGE_TOP", "I", AccessFlags = 25)]
				public const int EDGE_TOP = 4;
				/// <java-name>
				/// EDGE_BOTTOM
				/// </java-name>
				[Dot42.DexImport("EDGE_BOTTOM", "I", AccessFlags = 25)]
				public const int EDGE_BOTTOM = 8;
				/// <java-name>
				/// KEYCODE_SHIFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT = -1;
				/// <java-name>
				/// KEYCODE_MODE_CHANGE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MODE_CHANGE", "I", AccessFlags = 25)]
				public const int KEYCODE_MODE_CHANGE = -2;
				/// <java-name>
				/// KEYCODE_CANCEL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CANCEL", "I", AccessFlags = 25)]
				public const int KEYCODE_CANCEL = -3;
				/// <java-name>
				/// KEYCODE_DONE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DONE", "I", AccessFlags = 25)]
				public const int KEYCODE_DONE = -4;
				/// <java-name>
				/// KEYCODE_DELETE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DELETE", "I", AccessFlags = 25)]
				public const int KEYCODE_DELETE = -5;
				/// <java-name>
				/// KEYCODE_ALT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT = -6;
				/// <summary>
				/// <para>Creates a keyboard from the given xml key layout file. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int xmlLayoutResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a keyboard from the given xml key layout file. Weeds out rows that have a keyboard mode defined but don't match the specified mode. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;IIII)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int xmlLayoutResId, int modeId, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a keyboard from the given xml key layout file. Weeds out rows that have a keyboard mode defined but don't match the specified mode. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int xmlLayoutResId, int modeId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a keyboard from the given xml key layout file. Weeds out rows that have a keyboard mode defined but don't match the specified mode. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int xmlLayoutResId, global::Java.Lang.ICharSequence modeId, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				[Dot42.DexImport("getKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
				public virtual global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> GetKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key>);
				}

				/// <java-name>
				/// getModifierKeys
				/// </java-name>
				[Dot42.DexImport("getModifierKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
				public virtual global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> GetModifierKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key>);
				}

				/// <java-name>
				/// getHorizontalGap
				/// </java-name>
				[Dot42.DexImport("getHorizontalGap", "()I", AccessFlags = 4)]
				protected internal virtual int GetHorizontalGap() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setHorizontalGap
				/// </java-name>
				[Dot42.DexImport("setHorizontalGap", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetHorizontalGap(int gap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVerticalGap
				/// </java-name>
				[Dot42.DexImport("getVerticalGap", "()I", AccessFlags = 4)]
				protected internal virtual int GetVerticalGap() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVerticalGap
				/// </java-name>
				[Dot42.DexImport("setVerticalGap", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetVerticalGap(int gap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyHeight
				/// </java-name>
				[Dot42.DexImport("getKeyHeight", "()I", AccessFlags = 4)]
				protected internal virtual int GetKeyHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeyHeight
				/// </java-name>
				[Dot42.DexImport("setKeyHeight", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetKeyHeight(int height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyWidth
				/// </java-name>
				[Dot42.DexImport("getKeyWidth", "()I", AccessFlags = 4)]
				protected internal virtual int GetKeyWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeyWidth
				/// </java-name>
				[Dot42.DexImport("setKeyWidth", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetKeyWidth(int width) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the total height of the keyboard </para>        
				/// </summary>
				/// <returns>
				/// <para>the total height of the keyboard </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinWidth
				/// </java-name>
				[Dot42.DexImport("getMinWidth", "()I", AccessFlags = 1)]
				public virtual int GetMinWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setShifted
				/// </java-name>
				[Dot42.DexImport("setShifted", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetShifted(bool shiftState) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isShifted
				/// </java-name>
				[Dot42.DexImport("isShifted", "()Z", AccessFlags = 1)]
				public virtual bool IsShifted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getShiftKeyIndex
				/// </java-name>
				[Dot42.DexImport("getShiftKeyIndex", "()I", AccessFlags = 1)]
				public virtual int GetShiftKeyIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the indices of the keys that are closest to the given point. </para>        
				/// </summary>
				/// <returns>
				/// <para>the array of integer indices for the nearest keys to the given point. If the given point is out of range, then an array of size zero is returned. </para>
				/// </returns>
				/// <java-name>
				/// getNearestKeys
				/// </java-name>
				[Dot42.DexImport("getNearestKeys", "(II)[I", AccessFlags = 1)]
				public virtual int[] GetNearestKeys(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// createRowFromXml
				/// </java-name>
				[Dot42.DexImport("createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/" +
    "inputmethodservice/Keyboard$Row;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.Keyboard.Row CreateRowFromXml(global::Android.Content.Res.Resources res, global::Android.Content.Res.IXmlResourceParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard.Row);
				}

				/// <java-name>
				/// createKeyFromXml
				/// </java-name>
				[Dot42.DexImport("createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandro" +
    "id/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.Keyboard.Key CreateKeyFromXml(global::Android.Content.Res.Resources res, global::Android.Inputmethodservice.Keyboard.Row parent, int x, int y, global::Android.Content.Res.IXmlResourceParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard.Key);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Keyboard() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				public global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> Keys
				{
				[Dot42.DexImport("getKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
						get{ return GetKeys(); }
				}

				/// <java-name>
				/// getModifierKeys
				/// </java-name>
				public global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> ModifierKeys
				{
				[Dot42.DexImport("getModifierKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
						get{ return GetModifierKeys(); }
				}

				/// <java-name>
				/// getHorizontalGap
				/// </java-name>
				protected internal int HorizontalGap
				{
				[Dot42.DexImport("getHorizontalGap", "()I", AccessFlags = 4)]
						get{ return GetHorizontalGap(); }
				[Dot42.DexImport("setHorizontalGap", "(I)V", AccessFlags = 4)]
						set{ SetHorizontalGap(value); }
				}

				/// <java-name>
				/// getVerticalGap
				/// </java-name>
				protected internal int VerticalGap
				{
				[Dot42.DexImport("getVerticalGap", "()I", AccessFlags = 4)]
						get{ return GetVerticalGap(); }
				[Dot42.DexImport("setVerticalGap", "(I)V", AccessFlags = 4)]
						set{ SetVerticalGap(value); }
				}

				/// <java-name>
				/// getKeyHeight
				/// </java-name>
				protected internal int KeyHeight
				{
				[Dot42.DexImport("getKeyHeight", "()I", AccessFlags = 4)]
						get{ return GetKeyHeight(); }
				[Dot42.DexImport("setKeyHeight", "(I)V", AccessFlags = 4)]
						set{ SetKeyHeight(value); }
				}

				/// <java-name>
				/// getKeyWidth
				/// </java-name>
				protected internal int KeyWidth
				{
				[Dot42.DexImport("getKeyWidth", "()I", AccessFlags = 4)]
						get{ return GetKeyWidth(); }
				[Dot42.DexImport("setKeyWidth", "(I)V", AccessFlags = 4)]
						set{ SetKeyWidth(value); }
				}

				/// <summary>
				/// <para>Returns the total height of the keyboard </para>        
				/// </summary>
				/// <returns>
				/// <para>the total height of the keyboard </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getMinWidth
				/// </java-name>
				public int MinWidth
				{
				[Dot42.DexImport("getMinWidth", "()I", AccessFlags = 1)]
						get{ return GetMinWidth(); }
				}

				/// <java-name>
				/// getShiftKeyIndex
				/// </java-name>
				public int ShiftKeyIndex
				{
				[Dot42.DexImport("getShiftKeyIndex", "()I", AccessFlags = 1)]
						get{ return GetShiftKeyIndex(); }
				}

				/// <summary>
				/// <para>Class for describing the position and characteristics of a single key in the keyboard.</para><para>ref android.R.styleable::Keyboard_keyWidth  ref android.R.styleable::Keyboard_keyHeight  ref android.R.styleable::Keyboard_horizontalGap  ref android.R.styleable::Keyboard_Key_codes  ref android.R.styleable::Keyboard_Key_keyIcon  ref android.R.styleable::Keyboard_Key_keyLabel  ref android.R.styleable::Keyboard_Key_iconPreview  ref android.R.styleable::Keyboard_Key_isSticky  ref android.R.styleable::Keyboard_Key_isRepeatable  ref android.R.styleable::Keyboard_Key_isModifier  ref android.R.styleable::Keyboard_Key_popupKeyboard  ref android.R.styleable::Keyboard_Key_popupCharacters  ref android.R.styleable::Keyboard_Key_keyOutputText  ref android.R.styleable::Keyboard_Key_keyEdgeFlags </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/Keyboard$Key
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/Keyboard$Key", AccessFlags = 9)]
				public partial class Key
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>All the key codes (unicode or custom code) that this key could generate, zero'th being the most important. </para>        
						/// </summary>
						/// <java-name>
						/// codes
						/// </java-name>
						[Dot42.DexImport("codes", "[I", AccessFlags = 1)]
						public int[] Codes;
						/// <summary>
						/// <para>Label to display </para>        
						/// </summary>
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Label;
						/// <summary>
						/// <para>Icon to display instead of a label. Icon takes precedence over a label </para>        
						/// </summary>
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public global::Android.Graphics.Drawable.Drawable Icon;
						/// <summary>
						/// <para>Preview version of the icon, for the preview popup </para>        
						/// </summary>
						/// <java-name>
						/// iconPreview
						/// </java-name>
						[Dot42.DexImport("iconPreview", "Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public global::Android.Graphics.Drawable.Drawable IconPreview;
						/// <summary>
						/// <para>Width of the key, not including the gap </para>        
						/// </summary>
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						/// <summary>
						/// <para>Height of the key, not including the gap </para>        
						/// </summary>
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 1)]
						public int Height;
						/// <summary>
						/// <para>The horizontal gap before this key </para>        
						/// </summary>
						/// <java-name>
						/// gap
						/// </java-name>
						[Dot42.DexImport("gap", "I", AccessFlags = 1)]
						public int Gap;
						/// <summary>
						/// <para>Whether this key is sticky, i.e., a toggle key </para>        
						/// </summary>
						/// <java-name>
						/// sticky
						/// </java-name>
						[Dot42.DexImport("sticky", "Z", AccessFlags = 1)]
						public bool Sticky;
						/// <summary>
						/// <para>X coordinate of the key in the keyboard layout </para>        
						/// </summary>
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "I", AccessFlags = 1)]
						public int X;
						/// <summary>
						/// <para>Y coordinate of the key in the keyboard layout </para>        
						/// </summary>
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "I", AccessFlags = 1)]
						public int Y;
						/// <summary>
						/// <para>The current pressed state of this key </para>        
						/// </summary>
						/// <java-name>
						/// pressed
						/// </java-name>
						[Dot42.DexImport("pressed", "Z", AccessFlags = 1)]
						public bool Pressed;
						/// <summary>
						/// <para>If this is a sticky key, is it on? </para>        
						/// </summary>
						/// <java-name>
						/// on
						/// </java-name>
						[Dot42.DexImport("on", "Z", AccessFlags = 1)]
						public bool On;
						/// <summary>
						/// <para>Text to output when pressed. This can be multiple characters, like ".com" </para>        
						/// </summary>
						/// <java-name>
						/// text
						/// </java-name>
						[Dot42.DexImport("text", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Text;
						/// <summary>
						/// <para>Popup characters </para>        
						/// </summary>
						/// <java-name>
						/// popupCharacters
						/// </java-name>
						[Dot42.DexImport("popupCharacters", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence PopupCharacters;
						/// <summary>
						/// <para>Flags that specify the anchoring to edges of the keyboard for detecting touch events that are just out of the boundary of the key. This is a bit mask of Keyboard#EDGE_LEFT, Keyboard#EDGE_RIGHT, Keyboard#EDGE_TOP and Keyboard#EDGE_BOTTOM. </para>        
						/// </summary>
						/// <java-name>
						/// edgeFlags
						/// </java-name>
						[Dot42.DexImport("edgeFlags", "I", AccessFlags = 1)]
						public int EdgeFlags;
						/// <summary>
						/// <para>Whether this is a modifier key, such as Shift or Alt </para>        
						/// </summary>
						/// <java-name>
						/// modifier
						/// </java-name>
						[Dot42.DexImport("modifier", "Z", AccessFlags = 1)]
						public bool Modifier;
						/// <summary>
						/// <para>If this key pops up a mini keyboard, this is the resource id for the XML layout for that keyboard. </para>        
						/// </summary>
						/// <java-name>
						/// popupResId
						/// </java-name>
						[Dot42.DexImport("popupResId", "I", AccessFlags = 1)]
						public int PopupResId;
						/// <summary>
						/// <para>Whether this key repeats itself when held down </para>        
						/// </summary>
						/// <java-name>
						/// repeatable
						/// </java-name>
						[Dot42.DexImport("repeatable", "Z", AccessFlags = 1)]
						public bool Repeatable;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V", AccessFlags = 1)]
						public Key(global::Android.Inputmethodservice.Keyboard.Row row) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandro" +
    "id/content/res/XmlResourceParser;)V", AccessFlags = 1)]
						public Key(global::Android.Content.Res.Resources resources, global::Android.Inputmethodservice.Keyboard.Row row, int int32, int int321, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Informs the key that it has been pressed, in case it needs to change its appearance or state. <para>onReleased(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// onPressed
						/// </java-name>
						[Dot42.DexImport("onPressed", "()V", AccessFlags = 1)]
						public virtual void OnPressed() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Changes the pressed state of the key. If it is a sticky key, it will also change the toggled state of the key if the finger was release inside. <para>onPressed() </para></para>        
						/// </summary>
						/// <java-name>
						/// onReleased
						/// </java-name>
						[Dot42.DexImport("onReleased", "(Z)V", AccessFlags = 1)]
						public virtual void OnReleased(bool inside) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Detects if a point falls inside this key. </para>        
						/// </summary>
						/// <returns>
						/// <para>whether or not the point falls inside the key. If the key is attached to an edge, it will assume that all points between the key and the edge are considered to be inside the key. </para>
						/// </returns>
						/// <java-name>
						/// isInside
						/// </java-name>
						[Dot42.DexImport("isInside", "(II)Z", AccessFlags = 1)]
						public virtual bool IsInside(int x, int y) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns the square of the distance between the center of the key and the given point. </para>        
						/// </summary>
						/// <returns>
						/// <para>the square of the distance of the point from the center of the key </para>
						/// </returns>
						/// <java-name>
						/// squaredDistanceFrom
						/// </java-name>
						[Dot42.DexImport("squaredDistanceFrom", "(II)I", AccessFlags = 1)]
						public virtual int SquaredDistanceFrom(int x, int y) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the drawable state for the key, based on the current state and type of the key. <para>android.graphics.drawable.StateListDrawable::setState(int[]) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the drawable state of the key. </para>
						/// </returns>
						/// <java-name>
						/// getCurrentDrawableState
						/// </java-name>
						[Dot42.DexImport("getCurrentDrawableState", "()[I", AccessFlags = 1)]
						public virtual int[] GetCurrentDrawableState() /* MethodBuilder.Create */ 
						{
								return default(int[]);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Key() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns the drawable state for the key, based on the current state and type of the key. <para>android.graphics.drawable.StateListDrawable::setState(int[]) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the drawable state of the key. </para>
						/// </returns>
						/// <java-name>
						/// getCurrentDrawableState
						/// </java-name>
						public int[] CurrentDrawableState
						{
						[Dot42.DexImport("getCurrentDrawableState", "()[I", AccessFlags = 1)]
								get{ return GetCurrentDrawableState(); }
						}

				}

				/// <summary>
				/// <para>Container for keys in the keyboard. All keys in a row are at the same Y-coordinate. Some of the key size defaults can be overridden per row from what the Keyboard defines.  ref android.R.styleable::Keyboard_keyWidth  ref android.R.styleable::Keyboard_keyHeight  ref android.R.styleable::Keyboard_horizontalGap  ref android.R.styleable::Keyboard_verticalGap  ref android.R.styleable::Keyboard_Row_rowEdgeFlags  ref android.R.styleable::Keyboard_Row_keyboardMode </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/Keyboard$Row
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/Keyboard$Row", AccessFlags = 9)]
				public partial class Row
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Default width of a key in this row. </para>        
						/// </summary>
						/// <java-name>
						/// defaultWidth
						/// </java-name>
						[Dot42.DexImport("defaultWidth", "I", AccessFlags = 1)]
						public int DefaultWidth;
						/// <summary>
						/// <para>Default height of a key in this row. </para>        
						/// </summary>
						/// <java-name>
						/// defaultHeight
						/// </java-name>
						[Dot42.DexImport("defaultHeight", "I", AccessFlags = 1)]
						public int DefaultHeight;
						/// <summary>
						/// <para>Default horizontal gap between keys in this row. </para>        
						/// </summary>
						/// <java-name>
						/// defaultHorizontalGap
						/// </java-name>
						[Dot42.DexImport("defaultHorizontalGap", "I", AccessFlags = 1)]
						public int DefaultHorizontalGap;
						/// <summary>
						/// <para>Vertical gap following this row. </para>        
						/// </summary>
						/// <java-name>
						/// verticalGap
						/// </java-name>
						[Dot42.DexImport("verticalGap", "I", AccessFlags = 1)]
						public int VerticalGap;
						/// <summary>
						/// <para>Edge flags for this row of keys. Possible values that can be assigned are EDGE_TOP and EDGE_BOTTOM </para>        
						/// </summary>
						/// <java-name>
						/// rowEdgeFlags
						/// </java-name>
						[Dot42.DexImport("rowEdgeFlags", "I", AccessFlags = 1)]
						public int RowEdgeFlags;
						/// <summary>
						/// <para>The keyboard mode for this row </para>        
						/// </summary>
						/// <java-name>
						/// mode
						/// </java-name>
						[Dot42.DexImport("mode", "I", AccessFlags = 1)]
						public int Mode;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
						public Row(global::Android.Inputmethodservice.Keyboard keyboard) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/con" +
    "tent/res/XmlResourceParser;)V", AccessFlags = 1)]
						public Row(global::Android.Content.Res.Resources resources, global::Android.Inputmethodservice.Keyboard keyboard, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Row() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>A view that renders a virtual Keyboard. It handles rendering of keys and detecting key presses and touch movements.</para><para>ref android.R.styleable::KeyboardView_keyBackground  ref android.R.styleable::KeyboardView_keyPreviewLayout  ref android.R.styleable::KeyboardView_keyPreviewOffset  ref android.R.styleable::KeyboardView_labelTextSize  ref android.R.styleable::KeyboardView_keyTextSize  ref android.R.styleable::KeyboardView_keyTextColor  ref android.R.styleable::KeyboardView_verticalCorrection  ref android.R.styleable::KeyboardView_popupLayout </para>    
		/// </summary>
		/// <java-name>
		/// android/inputmethodservice/KeyboardView
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/KeyboardView", AccessFlags = 33)]
		public partial class KeyboardView : global::Android.View.View, global::Android.View.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public KeyboardView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public KeyboardView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyboardActionListener(global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the OnKeyboardActionListener object. </para>        
				/// </summary>
				/// <returns>
				/// <para>the listener attached to this keyboard </para>
				/// </returns>
				/// <java-name>
				/// getOnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener GetOnKeyboardActionListener() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener);
				}

				/// <summary>
				/// <para>Attaches a keyboard to this view. The keyboard can be switched at any time and the view will re-layout itself to accommodate the keyboard. <para>Keyboard </para><simplesectsep></simplesectsep><para>getKeyboard() </para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyboard
				/// </java-name>
				[Dot42.DexImport("setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
				public virtual void SetKeyboard(global::Android.Inputmethodservice.Keyboard keyboard) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current keyboard being displayed by this view. <para>setKeyboard(Keyboard) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currently attached keyboard </para>
				/// </returns>
				/// <java-name>
				/// getKeyboard
				/// </java-name>
				[Dot42.DexImport("getKeyboard", "()Landroid/inputmethodservice/Keyboard;", AccessFlags = 1)]
				public virtual global::Android.Inputmethodservice.Keyboard GetKeyboard() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard);
				}

				/// <summary>
				/// <para>Sets the state of the shift key of the keyboard, if any. <para>KeyboardView::isShifted() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the shift key state changed, false if there was no change </para>
				/// </returns>
				/// <java-name>
				/// setShifted
				/// </java-name>
				[Dot42.DexImport("setShifted", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetShifted(bool shifted) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the state of the shift key of the keyboard, if any. <para>KeyboardView::setShifted(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the shift is in a pressed state, false otherwise. If there is no shift key on the keyboard or there is no keyboard attached, it returns false. </para>
				/// </returns>
				/// <java-name>
				/// isShifted
				/// </java-name>
				[Dot42.DexImport("isShifted", "()Z", AccessFlags = 1)]
				public virtual bool IsShifted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Enables or disables the key feedback popup. This is a popup that shows a magnified version of the depressed key. By default the preview is enabled. <para>isPreviewEnabled() </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewEnabled
				/// </java-name>
				[Dot42.DexImport("setPreviewEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetPreviewEnabled(bool previewEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the enabled state of the key feedback popup. <para>setPreviewEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether or not the key feedback popup is enabled </para>
				/// </returns>
				/// <java-name>
				/// isPreviewEnabled
				/// </java-name>
				[Dot42.DexImport("isPreviewEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsPreviewEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVerticalCorrection
				/// </java-name>
				[Dot42.DexImport("setVerticalCorrection", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalCorrection(int verticalOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPopupParent
				/// </java-name>
				[Dot42.DexImport("setPopupParent", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetPopupParent(global::Android.View.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPopupOffset
				/// </java-name>
				[Dot42.DexImport("setPopupOffset", "(II)V", AccessFlags = 1)]
				public virtual void SetPopupOffset(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When enabled, calls to OnKeyboardActionListener#onKey will include key codes for adjacent keys. When disabled, only the primary key code will be reported. </para>        
				/// </summary>
				/// <java-name>
				/// setProximityCorrectionEnabled
				/// </java-name>
				[Dot42.DexImport("setProximityCorrectionEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetProximityCorrectionEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if proximity correction is enabled. </para>        
				/// </summary>
				/// <java-name>
				/// isProximityCorrectionEnabled
				/// </java-name>
				[Dot42.DexImport("isProximityCorrectionEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsProximityCorrectionEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Measure the view and its content to determine the measured width and the measured height. This method is invoked by measure(int, int) and should be overriden by subclasses to provide accurate and efficient measurement of their contents. </para><para><b>CONTRACT:</b> When overriding this method, you <b>must</b> call setMeasuredDimension(int, int) to store the measured width and height of this view. Failure to do so will trigger an <code>IllegalStateException</code>, thrown by measure(int, int). Calling the superclass' onMeasure(int, int) is a valid use. </para><para>The base class implementation of measure defaults to the background size, unless a larger size is allowed by the MeasureSpec. Subclasses should override onMeasure(int, int) to provide better measurements of their content. </para><para>If this method is overridden, it is the subclass's responsibility to make sure the measured height and width are at least the view's minimum height and width (getSuggestedMinimumHeight() and getSuggestedMinimumWidth()). </para><para><para>getMeasuredWidth() </para><simplesectsep></simplesectsep><para>getMeasuredHeight() </para><simplesectsep></simplesectsep><para>setMeasuredDimension(int, int) </para><simplesectsep></simplesectsep><para>getSuggestedMinimumHeight() </para><simplesectsep></simplesectsep><para>getSuggestedMinimumWidth() </para><simplesectsep></simplesectsep><para>android.view.View.MeasureSpec::getMode(int) </para><simplesectsep></simplesectsep><para>android.view.View.MeasureSpec::getSize(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 1)]
				public new virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called during layout when the size of this view has changed. If you were just added to the view hierarchy, you're called with the old values of 0.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 1)]
				public new virtual void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement this to do your drawing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public new virtual void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests a redraw of the entire keyboard. Calling invalidate is not sufficient because the keyboard renders the keys to an off-screen buffer and an invalidate() only draws the cached buffer. <para>invalidateKey(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateAllKeys
				/// </java-name>
				[Dot42.DexImport("invalidateAllKeys", "()V", AccessFlags = 1)]
				public virtual void InvalidateAllKeys() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invalidates a key so that it will be redrawn on the next repaint. Use this method if only one key is changing it's content. Any changes that affect the position or size of the key may not be honored. <para>invalidateAllKeys </para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateKey
				/// </java-name>
				[Dot42.DexImport("invalidateKey", "(I)V", AccessFlags = 1)]
				public virtual void InvalidateKey(int keyIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a key is long pressed. By default this will open any popup keyboard associated with this key through the attributes popupLayout and popupCharacters. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the long press is handled, false otherwise. Subclasses should call the method on the base class if the subclass doesn't wish to handle the call. </para>
				/// </returns>
				/// <java-name>
				/// onLongPress
				/// </java-name>
				[Dot42.DexImport("onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z", AccessFlags = 4)]
				protected internal virtual bool OnLongPress(global::Android.Inputmethodservice.Keyboard.Key popupKey) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this method to handle hover events. </para><para>This method is called whenever a pointer is hovering into, over, or out of the bounds of a view and the view is not currently being touched. Hover events are represented as pointer events with action MotionEvent#ACTION_HOVER_ENTER, MotionEvent#ACTION_HOVER_MOVE, or MotionEvent#ACTION_HOVER_EXIT. </para><para><ul><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_ENTER when the pointer enters the bounds of the view. </para></li><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_MOVE when the pointer has already entered the bounds of the view and has moved. </para></li><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_EXIT when the pointer has exited the bounds of the view or when the pointer is about to go down due to a button click, tap, or similar user action that causes the view to be touched. </para></li></ul></para><para>The view should implement this method to return true to indicate that it is handling the hover event, such as by changing its drawable state. </para><para>The default implementation calls setHovered to update the hovered state of the view when a hover enter or hover exit event is received, if the view is enabled and is clickable. The default implementation also sends hover accessibility events. </para><para><para>isHovered </para><simplesectsep></simplesectsep><para>setHovered </para><simplesectsep></simplesectsep><para>onHoverChanged </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the view handled the hover event.</para>
				/// </returns>
				/// <java-name>
				/// onHoverEvent
				/// </java-name>
				[Dot42.DexImport("onHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnHoverEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this method to handle touch screen motion events.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// swipeRight
				/// </java-name>
				[Dot42.DexImport("swipeRight", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeRight() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeLeft
				/// </java-name>
				[Dot42.DexImport("swipeLeft", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeLeft() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeUp
				/// </java-name>
				[Dot42.DexImport("swipeUp", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeDown
				/// </java-name>
				[Dot42.DexImport("swipeDown", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closing
				/// </java-name>
				[Dot42.DexImport("closing", "()V", AccessFlags = 1)]
				public virtual void Closing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the view is detached from a window. At this point it no longer has a surface for drawing.</para><para><para>onAttachedToWindow() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public new virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleBack
				/// </java-name>
				[Dot42.DexImport("handleBack", "()Z", AccessFlags = 1)]
				public virtual bool HandleBack() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Popup keyboard close button clicked.  </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.View.View v) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyboardView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the OnKeyboardActionListener object. </para>        
				/// </summary>
				/// <returns>
				/// <para>the listener attached to this keyboard </para>
				/// </returns>
				/// <java-name>
				/// getOnKeyboardActionListener
				/// </java-name>
				protected internal global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener OnKeyboardActionListener
				{
				[Dot42.DexImport("getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", AccessFlags = 4)]
						get{ return GetOnKeyboardActionListener(); }
				[Dot42.DexImport("setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", AccessFlags = 1)]
						set{ SetOnKeyboardActionListener(value); }
				}

				/// <summary>
				/// <para>Returns the current keyboard being displayed by this view. <para>setKeyboard(Keyboard) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the currently attached keyboard </para>
				/// </returns>
				/// <java-name>
				/// getKeyboard
				/// </java-name>
				public global::Android.Inputmethodservice.Keyboard Keyboard
				{
				[Dot42.DexImport("getKeyboard", "()Landroid/inputmethodservice/Keyboard;", AccessFlags = 1)]
						get{ return GetKeyboard(); }
				[Dot42.DexImport("setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
						set{ SetKeyboard(value); }
				}

				/// <summary>
				/// <para>Listener for virtual keyboard events. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/KeyboardView$OnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/KeyboardView$OnKeyboardActionListener", AccessFlags = 1545)]
				public partial interface IOnKeyboardActionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the user presses a key. This is sent before the onKey is called. For keys that repeat, this is only called once. </para>        
						/// </summary>
						/// <java-name>
						/// onPress
						/// </java-name>
						[Dot42.DexImport("onPress", "(I)V", AccessFlags = 1025)]
						void OnPress(int primaryCode) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called when the user releases a key. This is sent after the onKey is called. For keys that repeat, this is only called once. </para>        
						/// </summary>
						/// <java-name>
						/// onRelease
						/// </java-name>
						[Dot42.DexImport("onRelease", "(I)V", AccessFlags = 1025)]
						void OnRelease(int primaryCode) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Send a key press to the listener. </para>        
						/// </summary>
						/// <java-name>
						/// onKey
						/// </java-name>
						[Dot42.DexImport("onKey", "(I[I)V", AccessFlags = 1025)]
						void OnKey(int primaryCode, int[] keyCodes) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Sends a sequence of characters to the listener. </para>        
						/// </summary>
						/// <java-name>
						/// onText
						/// </java-name>
						[Dot42.DexImport("onText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						void OnText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called when the user quickly moves the finger from right to left. </para>        
						/// </summary>
						/// <java-name>
						/// swipeLeft
						/// </java-name>
						[Dot42.DexImport("swipeLeft", "()V", AccessFlags = 1025)]
						void SwipeLeft() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called when the user quickly moves the finger from left to right. </para>        
						/// </summary>
						/// <java-name>
						/// swipeRight
						/// </java-name>
						[Dot42.DexImport("swipeRight", "()V", AccessFlags = 1025)]
						void SwipeRight() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called when the user quickly moves the finger from up to down. </para>        
						/// </summary>
						/// <java-name>
						/// swipeDown
						/// </java-name>
						[Dot42.DexImport("swipeDown", "()V", AccessFlags = 1025)]
						void SwipeDown() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called when the user quickly moves the finger from down to up. </para>        
						/// </summary>
						/// <java-name>
						/// swipeUp
						/// </java-name>
						[Dot42.DexImport("swipeUp", "()V", AccessFlags = 1025)]
						void SwipeUp() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>InputMethodService provides a standard implementation of an InputMethod, which final implementations can derive from and customize. See the base class AbstractInputMethodService and the InputMethod interface for more information on the basics of writing input methods.</para><para>In addition to the normal Service lifecycle methods, this class introduces some new specific callbacks that most subclasses will want to make use of:</para><para><ul><li><para>onInitializeInterface() for user-interface initialization, in particular to deal with configuration changes while the service is running. </para></li><li><para>onBindInput to find out about switching to a new client. </para></li><li><para>onStartInput to deal with an input session starting with the client. </para></li><li><para>onCreateInputView(), onCreateCandidatesView(), and onCreateExtractTextView() for non-demand generation of the UI. </para></li><li><para>onStartInputView(EditorInfo, boolean) to deal with input starting within the input area of the IME. </para></li></ul></para><para>An input method has significant discretion in how it goes about its work: the android.inputmethodservice.InputMethodService provides a basic framework for standard UI elements (input view, candidates view, and running in fullscreen mode), but it is up to a particular implementor to decide how to use them. For example, one input method could implement an input area with a keyboard, another could allow the user to draw text, while a third could have no input area (and thus not be visible to the user) but instead listen to audio and perform text to speech conversion.</para><para>In the implementation provided here, all of these elements are placed together in a single window managed by the InputMethodService. It will execute callbacks as it needs information about them, and provides APIs for programmatic control over them. They layout of these elements is explicitly defined:</para><para><ul><li><para>The soft input view, if available, is placed at the bottom of the screen. </para></li><li><para>The candidates view, if currently shown, is placed above the soft input view. </para></li><li><para>If not running fullscreen, the application is moved or resized to be above these views; if running fullscreen, the window will completely cover the application and its top part will contain the extract text of what is currently being edited by the application. </para></li></ul></para><para> <h3>Soft Input View</h3></para><para>Central to most input methods is the soft input view. This is where most user interaction occurs: pressing on soft keys, drawing characters, or however else your input method wants to generate text. Most implementations will simply have their own view doing all of this work, and return a new instance of it when onCreateInputView() is called. At that point, as long as the input view is visible, you will see user interaction in that view and can call back on the InputMethodService to interact with the application as appropriate.</para><para>There are some situations where you want to decide whether or not your soft input view should be shown to the user. This is done by implementing the onEvaluateInputViewShown() to return true or false based on whether it should be shown in the current environment. If any of your state has changed that may impact this, call updateInputViewShown() to have it re-evaluated. The default implementation always shows the input view unless there is a hard keyboard available, which is the appropriate behavior for most input methods.</para><para> <h3>Candidates View</h3></para><para>Often while the user is generating raw text, an input method wants to provide them with a list of possible interpretations of that text that can be selected for use. This is accomplished with the candidates view, and like the soft input view you implement onCreateCandidatesView() to instantiate your own view implementing your candidates UI.</para><para>Management of the candidates view is a little different than the input view, because the candidates view tends to be more transient, being shown only when there are possible candidates for the current text being entered by the user. To control whether the candidates view is shown, you use setCandidatesViewShown(boolean). Note that because the candidate view tends to be shown and hidden a lot, it does not impact the application UI in the same way as the soft input view: it will never cause application windows to resize, only cause them to be panned if needed for the user to see the current focus.</para><para> <h3>Fullscreen Mode</h3></para><para>Sometimes your input method UI is too large to integrate with the application UI, so you just want to take over the screen. This is accomplished by switching to full-screen mode, causing the input method window to fill the entire screen and add its own "extracted text" editor showing the user the text that is being typed. Unlike the other UI elements, there is a standard implementation for the extract editor that you should not need to change. The editor is placed at the top of the IME, above the input and candidates views.</para><para>Similar to the input view, you control whether the IME is running in fullscreen mode by implementing onEvaluateFullscreenMode() to return true or false based on whether it should be fullscreen in the current environment. If any of your state has changed that may impact this, call updateFullscreenMode() to have it re-evaluated. The default implementation selects fullscreen mode when the screen is in a landscape orientation, which is appropriate behavior for most input methods that have a significant input area.</para><para>When in fullscreen mode, you have some special requirements because the user can not see the application UI. In particular, you should implement onDisplayCompletions(CompletionInfo[]) to show completions generated by your application, typically in your candidates view like you would normally show candidates.</para><para> <h3>Generating Text</h3></para><para>The key part of an IME is of course generating text for the application. This is done through calls to the android.view.inputmethod.InputConnection interface to the application, which can be retrieved from getCurrentInputConnection(). This interface allows you to generate raw key events or, if the target supports it, directly edit in strings of candidates and committed text.</para><para>Information about what the target is expected and supports can be found through the android.view.inputmethod.EditorInfo class, which is retrieved with getCurrentInputEditorInfo() method. The most important part of this is EditorInfo.inputType; in particular, if this is EditorInfo.TYPE_NULL, then the target does not support complex edits and you need to only deliver raw key events to it. An input method will also want to look at other values here, to for example detect password mode, auto complete text views, phone number entry, etc.</para><para>When the user switches between input targets, you will receive calls to onFinishInput() and onStartInput(EditorInfo, boolean). You can use these to reset and initialize your input state for the current target. For example, you will often want to clear any input state, and update a soft keyboard to be appropriate for the new inputType.</para><para>ref android.R.styleable::InputMethodService_imeFullscreenBackground  ref android.R.styleable::InputMethodService_imeExtractEnterAnimation  ref android.R.styleable::InputMethodService_imeExtractExitAnimation </para>    
		/// </summary>
		/// <java-name>
		/// android/inputmethodservice/InputMethodService
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/InputMethodService", AccessFlags = 33)]
		public partial class InputMethodService : global::Android.Inputmethodservice.AbstractInputMethodService
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The back button will close the input window. </para>        
				/// </summary>
				/// <java-name>
				/// BACK_DISPOSITION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_DEFAULT", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_DEFAULT = 0;
				/// <summary>
				/// <para>This input method will not consume the back key. </para>        
				/// </summary>
				/// <java-name>
				/// BACK_DISPOSITION_WILL_NOT_DISMISS
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_WILL_NOT_DISMISS", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_WILL_NOT_DISMISS = 1;
				/// <summary>
				/// <para>This input method will consume the back key. </para>        
				/// </summary>
				/// <java-name>
				/// BACK_DISPOSITION_WILL_DISMISS
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_WILL_DISMISS", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_WILL_DISMISS = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputMethodService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>You can call this to customize the theme used by your IME's window. This theme should typically be one that derives from android.R.style#Theme_InputMethod, which is the default theme you will get. This must be set before onCreate, so you will typically call it in your constructor with the resource ID of your custom theme. </para>        
				/// </summary>
				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int theme) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by the system when the service is first created. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is a hook that subclasses can use to perform initialization of their interface. It is called for you prior to any of your UI objects being created, both after the service is first created and after a configuration change happens. </para>        
				/// </summary>
				/// <java-name>
				/// onInitializeInterface
				/// </java-name>
				[Dot42.DexImport("onInitializeInterface", "()V", AccessFlags = 1)]
				public virtual void OnInitializeInterface() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by the system to notify a Service that it is no longer used and is being removed. The service should clean up any resources it holds (threads, registered receivers, etc) at this point. Upon return, there will be no more calls in to this Service object and it is effectively dead. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Take care of handling configuration changes. Subclasses of InputMethodService generally don't need to deal directly with this on their own; the standard implementation here takes care of regenerating the input method UI as a result of the configuration change, so you can rely on your onCreateInputView and other methods being called as appropriate due to a configuration change.</para><para>When a configuration change does happen, onInitializeInterface() is guaranteed to be called the next time prior to any of the other input or UI creation callbacks. The following will be called immediately depending if appropriate for current state: onStartInput if input is active, and onCreateInputView and onStartInputView and related appropriate functions if the UI is displayed. </para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement to return our standard InputMethodImpl. Subclasses can override to provide their own customized version. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputMethodInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;" +
    "", AccessFlags = 1)]
				public override global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl OnCreateInputMethodInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl);
				}

				/// <summary>
				/// <para>Implement to return our standard InputMethodSessionImpl. Subclasses can override to provide their own customized version. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputMethodSessionInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessi" +
    "onImpl;", AccessFlags = 1)]
				public override global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl OnCreateInputMethodSessionInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl);
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
				public virtual global::Android.View.LayoutInflater GetLayoutInflater() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.LayoutInflater);
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/app/Dialog;", AccessFlags = 1)]
				public virtual global::Android.App.Dialog GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// setBackDisposition
				/// </java-name>
				[Dot42.DexImport("setBackDisposition", "(I)V", AccessFlags = 1)]
				public virtual void SetBackDisposition(int disposition) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBackDisposition
				/// </java-name>
				[Dot42.DexImport("getBackDisposition", "()I", AccessFlags = 1)]
				public virtual int GetBackDisposition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the maximum width, in pixels, available the input method. Input methods are positioned at the bottom of the screen and, unless running in fullscreen, will generally want to be as short as possible so should compute their height based on their contents. However, they can stretch as much as needed horizontally. The function returns to you the maximum amount of space available horizontally, which you can use if needed for UI placement.</para><para>In many cases this is not needed, you can just rely on the normal view layout mechanisms to position your views within the full horizontal space given to the input method.</para><para>Note that this value can change dynamically, in particular when the screen orientation changes. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxWidth
				/// </java-name>
				[Dot42.DexImport("getMaxWidth", "()I", AccessFlags = 1)]
				public virtual int GetMaxWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the currently active InputBinding for the input method, or null if there is none. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentInputBinding
				/// </java-name>
				[Dot42.DexImport("getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.InputBinding GetCurrentInputBinding() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.InputBinding);
				}

				/// <summary>
				/// <para>Retrieve the currently active InputConnection that is bound to the input method, or null if there is none. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentInputConnection
				/// </java-name>
				[Dot42.DexImport("getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.IInputConnection GetCurrentInputConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// getCurrentInputStarted
				/// </java-name>
				[Dot42.DexImport("getCurrentInputStarted", "()Z", AccessFlags = 1)]
				public virtual bool GetCurrentInputStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCurrentInputEditorInfo
				/// </java-name>
				[Dot42.DexImport("getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.EditorInfo GetCurrentInputEditorInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.EditorInfo);
				}

				/// <summary>
				/// <para>Re-evaluate whether the input method should be running in fullscreen mode, and update its UI if this has changed since the last time it was evaluated. This will call onEvaluateFullscreenMode() to determine whether it should currently run in fullscreen mode. You can use isFullscreenMode() to determine if the input method is currently running in fullscreen mode. </para>        
				/// </summary>
				/// <java-name>
				/// updateFullscreenMode
				/// </java-name>
				[Dot42.DexImport("updateFullscreenMode", "()V", AccessFlags = 1)]
				public virtual void UpdateFullscreenMode() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Update the given window's parameters for the given mode. This is called when the window is first displayed and each time the fullscreen or candidates only mode changes.</para><para>The default implementation makes the layout for the window MATCH_PARENT x MATCH_PARENT when in fullscreen mode, and MATCH_PARENT x WRAP_CONTENT when in non-fullscreen mode.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigureWindow
				/// </java-name>
				[Dot42.DexImport("onConfigureWindow", "(Landroid/view/Window;ZZ)V", AccessFlags = 1)]
				public virtual void OnConfigureWindow(global::Android.View.Window win, bool isFullscreen, bool isCandidatesOnly) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return whether the input method is <b>currently</b> running in fullscreen mode. This is the mode that was last determined and applied by updateFullscreenMode(). </para>        
				/// </summary>
				/// <java-name>
				/// isFullscreenMode
				/// </java-name>
				[Dot42.DexImport("isFullscreenMode", "()Z", AccessFlags = 1)]
				public virtual bool IsFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this to control when the input method should run in fullscreen mode. The default implementation runs in fullsceen only when the screen is in landscape mode. If you change what this returns, you will need to call updateFullscreenMode() yourself whenever the returned value may have changed to have it re-evaluated and applied. </para>        
				/// </summary>
				/// <java-name>
				/// onEvaluateFullscreenMode
				/// </java-name>
				[Dot42.DexImport("onEvaluateFullscreenMode", "()Z", AccessFlags = 1)]
				public virtual bool OnEvaluateFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Controls the visibility of the extracted text area. This only applies when the input method is in fullscreen mode, and thus showing extracted text. When false, the extracted text will not be shown, allowing some of the application to be seen behind. This is normally set for you by onUpdateExtractingVisibility. This controls the visibility of both the extracted text and candidate view; the latter since it is not useful if there is no text to see. </para>        
				/// </summary>
				/// <java-name>
				/// setExtractViewShown
				/// </java-name>
				[Dot42.DexImport("setExtractViewShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetExtractViewShown(bool shown) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return whether the fullscreen extract view is shown. This will only return true if isFullscreenMode() returns true, and in that case its value depends on the last call to setExtractViewShown(boolean). This effectively lets you determine if the application window is entirely covered (when this returns true) or if some part of it may be shown (if this returns false, though if isFullscreenMode() returns true in that case then it is probably only a sliver of the application). </para>        
				/// </summary>
				/// <java-name>
				/// isExtractViewShown
				/// </java-name>
				[Dot42.DexImport("isExtractViewShown", "()Z", AccessFlags = 1)]
				public virtual bool IsExtractViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compute the interesting insets into your UI. The default implementation uses the top of the candidates frame for the visible insets, and the top of the input frame for the content insets. The default touchable insets are Insets#TOUCHABLE_INSETS_VISIBLE.</para><para>Note that this method is not called when isExtractViewShown returns true, since in that case the application is left as-is behind the input method and not impacted by anything in its UI.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onComputeInsets
				/// </java-name>
				[Dot42.DexImport("onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V", AccessFlags = 1)]
				public virtual void OnComputeInsets(global::Android.Inputmethodservice.InputMethodService.Insets outInsets) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Re-evaluate whether the soft input area should currently be shown, and update its UI if this has changed since the last time it was evaluated. This will call onEvaluateInputViewShown() to determine whether the input view should currently be shown. You can use isInputViewShown() to determine if the input view is currently shown. </para>        
				/// </summary>
				/// <java-name>
				/// updateInputViewShown
				/// </java-name>
				[Dot42.DexImport("updateInputViewShown", "()V", AccessFlags = 1)]
				public virtual void UpdateInputViewShown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if we have been asked to show our input view. </para>        
				/// </summary>
				/// <java-name>
				/// isShowInputRequested
				/// </java-name>
				[Dot42.DexImport("isShowInputRequested", "()Z", AccessFlags = 1)]
				public virtual bool IsShowInputRequested() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return whether the soft input view is <b>currently</b> shown to the user. This is the state that was last determined and applied by updateInputViewShown(). </para>        
				/// </summary>
				/// <java-name>
				/// isInputViewShown
				/// </java-name>
				[Dot42.DexImport("isInputViewShown", "()Z", AccessFlags = 1)]
				public virtual bool IsInputViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this to control when the soft input area should be shown to the user. The default implementation only shows the input view when there is no hard keyboard or the keyboard is hidden. If you change what this returns, you will need to call updateInputViewShown() yourself whenever the returned value may have changed to have it re-evaluated and applied. </para>        
				/// </summary>
				/// <java-name>
				/// onEvaluateInputViewShown
				/// </java-name>
				[Dot42.DexImport("onEvaluateInputViewShown", "()Z", AccessFlags = 1)]
				public virtual bool OnEvaluateInputViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Controls the visibility of the candidates display area. By default it is hidden. </para>        
				/// </summary>
				/// <java-name>
				/// setCandidatesViewShown
				/// </java-name>
				[Dot42.DexImport("setCandidatesViewShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetCandidatesViewShown(bool shown) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the visibility mode (either View.INVISIBLE or View.GONE) of the candidates view when it is not shown. The default implementation returns GONE when isExtractViewShown returns true, otherwise VISIBLE. Be careful if you change this to return GONE in other situations  if showing or hiding the candidates view causes your window to resize, this can cause temporary drawing artifacts as the resize takes place. </para>        
				/// </summary>
				/// <java-name>
				/// getCandidatesHiddenVisibility
				/// </java-name>
				[Dot42.DexImport("getCandidatesHiddenVisibility", "()I", AccessFlags = 1)]
				public virtual int GetCandidatesHiddenVisibility() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// showStatusIcon
				/// </java-name>
				[Dot42.DexImport("showStatusIcon", "(I)V", AccessFlags = 1)]
				public virtual void ShowStatusIcon(int iconResId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideStatusIcon
				/// </java-name>
				[Dot42.DexImport("hideStatusIcon", "()V", AccessFlags = 1)]
				public virtual void HideStatusIcon() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Force switch to a new input method, as identified by <b>id</b>. This input method will be destroyed, and the requested one started on the current input field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// switchInputMethod
				/// </java-name>
				[Dot42.DexImport("switchInputMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SwitchInputMethod(string id) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExtractView
				/// </java-name>
				[Dot42.DexImport("setExtractView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetExtractView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces the current candidates view with a new one. You only need to call this when dynamically changing the view; normally, you should implement onCreateCandidatesView() and create your view when first needed by the input method. </para>        
				/// </summary>
				/// <java-name>
				/// setCandidatesView
				/// </java-name>
				[Dot42.DexImport("setCandidatesView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetCandidatesView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces the current input view with a new one. You only need to call this when dynamically changing the view; normally, you should implement onCreateInputView() and create your view when first needed by the input method. </para>        
				/// </summary>
				/// <java-name>
				/// setInputView
				/// </java-name>
				[Dot42.DexImport("setInputView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetInputView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by the framework to create the layout for showing extacted text. Only called when in fullscreen mode. The returned view hierarchy must have an ExtractEditText whose ID is android.R.id#inputExtractEditText. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateExtractTextView
				/// </java-name>
				[Dot42.DexImport("onCreateExtractTextView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateExtractTextView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Create and return the view hierarchy used to show candidates. This will be called once, when the candidates are first displayed. You can return null to have no candidates view; the default implementation returns null.</para><para>To control when the candidates view is displayed, use setCandidatesViewShown(boolean). To change the candidates view after the first one is created by this function, use setCandidatesView(View). </para>        
				/// </summary>
				/// <java-name>
				/// onCreateCandidatesView
				/// </java-name>
				[Dot42.DexImport("onCreateCandidatesView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateCandidatesView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Create and return the view hierarchy used for the input area (such as a soft keyboard). This will be called once, when the input area is first displayed. You can return null to have no input area; the default implementation returns null.</para><para>To control when the input view is displayed, implement onEvaluateInputViewShown(). To change the input view after the first one is created by this function, use setInputView(View). </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputView
				/// </java-name>
				[Dot42.DexImport("onCreateInputView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateInputView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Called when the input view is being shown and input has started on a new editor. This will always be called after onStartInput, allowing you to do your general setup there and just view-specific setup here. You are guaranteed that onCreateInputView() will have been called some time before this function is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onStartInputView
				/// </java-name>
				[Dot42.DexImport("onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartInputView(global::Android.View.Inputmethod.EditorInfo info, bool restarting) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the input view is being hidden from the user. This will be called either prior to hiding the window, or prior to switching to another target for editing.</para><para>The default implementation uses the InputConnection to clear any active composing text; you can override this (not calling the base class implementation) to perform whatever behavior you would like.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onFinishInputView
				/// </java-name>
				[Dot42.DexImport("onFinishInputView", "(Z)V", AccessFlags = 1)]
				public virtual void OnFinishInputView(bool finishingInput) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when only the candidates view has been shown for showing processing as the user enters text through a hard keyboard. This will always be called after onStartInput, allowing you to do your general setup there and just view-specific setup here. You are guaranteed that onCreateCandidatesView() will have been called some time before this function is called.</para><para>Note that this will <b>not</b> be called when the input method is running in full editing mode, and thus receiving onStartInputView to initiate that operation. This is only for the case when candidates are being shown while the input method editor is hidden but wants to show its candidates UI as text is entered through some other mechanism.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onStartCandidatesView
				/// </java-name>
				[Dot42.DexImport("onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartCandidatesView(global::Android.View.Inputmethod.EditorInfo info, bool restarting) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the candidates view is being hidden from the user. This will be called either prior to hiding the window, or prior to switching to another target for editing.</para><para>The default implementation uses the InputConnection to clear any active composing text; you can override this (not calling the base class implementation) to perform whatever behavior you would like.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onFinishCandidatesView
				/// </java-name>
				[Dot42.DexImport("onFinishCandidatesView", "(Z)V", AccessFlags = 1)]
				public virtual void OnFinishCandidatesView(bool finishingInput) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The system has decided that it may be time to show your input method. This is called due to a corresponding call to your InputMethod.showSoftInput() method. The default implementation uses onEvaluateInputViewShown(), onEvaluateFullscreenMode(), and the current configuration to decide whether the input view should be shown at this point.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true to indicate that the window should be shown. </para>
				/// </returns>
				/// <java-name>
				/// onShowInputRequested
				/// </java-name>
				[Dot42.DexImport("onShowInputRequested", "(IZ)Z", AccessFlags = 1)]
				public virtual bool OnShowInputRequested(int flags, bool configChange) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showWindow
				/// </java-name>
				[Dot42.DexImport("showWindow", "(Z)V", AccessFlags = 1)]
				public virtual void ShowWindow(bool showInput) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideWindow
				/// </java-name>
				[Dot42.DexImport("hideWindow", "()V", AccessFlags = 1)]
				public virtual void HideWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the input method window has been shown to the user, after previously not being visible. This is done after all of the UI setup for the window has occurred (creating its views etc). </para>        
				/// </summary>
				/// <java-name>
				/// onWindowShown
				/// </java-name>
				[Dot42.DexImport("onWindowShown", "()V", AccessFlags = 1)]
				public virtual void OnWindowShown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the input method window has been hidden from the user, after previously being visible. </para>        
				/// </summary>
				/// <java-name>
				/// onWindowHidden
				/// </java-name>
				[Dot42.DexImport("onWindowHidden", "()V", AccessFlags = 1)]
				public virtual void OnWindowHidden() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a new client has bound to the input method. This may be followed by a series of onStartInput(EditorInfo, boolean) and onFinishInput() calls as the user navigates through its UI. Upon this call you know that getCurrentInputBinding and getCurrentInputConnection return valid objects. </para>        
				/// </summary>
				/// <java-name>
				/// onBindInput
				/// </java-name>
				[Dot42.DexImport("onBindInput", "()V", AccessFlags = 1)]
				public virtual void OnBindInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the previous bound client is no longer associated with the input method. After returning getCurrentInputBinding and getCurrentInputConnection will no longer return valid objects. </para>        
				/// </summary>
				/// <java-name>
				/// onUnbindInput
				/// </java-name>
				[Dot42.DexImport("onUnbindInput", "()V", AccessFlags = 1)]
				public virtual void OnUnbindInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to inform the input method that text input has started in an editor. You should use this callback to initialize the state of your input to match the state of the editor given to it.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onStartInput
				/// </java-name>
				[Dot42.DexImport("onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartInput(global::Android.View.Inputmethod.EditorInfo attribute, bool restarting) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to inform the input method that text input has finished in the last editor. At this point there may be a call to onStartInput(EditorInfo, boolean) to perform input in a new editor, or the input method may be left idle. This method is <b>not</b> called when input restarts in the same editor.</para><para>The default implementation uses the InputConnection to clear any active composing text; you can override this (not calling the base class implementation) to perform whatever behavior you would like. </para>        
				/// </summary>
				/// <java-name>
				/// onFinishInput
				/// </java-name>
				[Dot42.DexImport("onFinishInput", "()V", AccessFlags = 1)]
				public virtual void OnFinishInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the application has reported auto-completion candidates that it would like to have the input method displayed. Typically these are only used when an input method is running in full-screen mode, since otherwise the user can see and interact with the pop-up window of completions shown by the application.</para><para>The default implementation here does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// onDisplayCompletions
				/// </java-name>
				[Dot42.DexImport("onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public virtual void OnDisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the application has reported new extracted text to be shown due to changes in its current text state. The default implementation here places the new text in the extract edit text, when the input method is running in fullscreen mode. </para>        
				/// </summary>
				/// <java-name>
				/// onUpdateExtractedText
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractedText(int token, global::Android.View.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the application has reported a new selection region of the text. This is called whether or not the input method has requested extracted text updates, although if so it will not receive this call if the extracted text has changed as well.</para><para>The default implementation takes care of updating the cursor in the extract text, if it is being shown. </para>        
				/// </summary>
				/// <java-name>
				/// onUpdateSelection
				/// </java-name>
				[Dot42.DexImport("onUpdateSelection", "(IIIIII)V", AccessFlags = 1)]
				public virtual void OnUpdateSelection(int oldSelStart, int oldSelEnd, int newSelStart, int newSelEnd, int candidatesStart, int candidatesEnd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the user tapped or clicked a text view. IMEs can't rely on this method being called because this was not part of the original IME protocol, so applications with custom text editing written before this method appeared will not call to inform the IME of this interaction. </para>        
				/// </summary>
				/// <java-name>
				/// onViewClicked
				/// </java-name>
				[Dot42.DexImport("onViewClicked", "(Z)V", AccessFlags = 1)]
				public virtual void OnViewClicked(bool focusChanged) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the application has reported a new location of its text cursor. This is only called if explicitly requested by the input method. The default implementation does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// onUpdateCursor
				/// </java-name>
				[Dot42.DexImport("onUpdateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnUpdateCursor(global::Android.Graphics.Rect newCursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Close this input method's soft input area, removing it from the display. The input method will continue running, but the user can no longer use it to generate input by touching the screen. </para>        
				/// </summary>
				/// <java-name>
				/// requestHideSelf
				/// </java-name>
				[Dot42.DexImport("requestHideSelf", "(I)V", AccessFlags = 1)]
				public virtual void RequestHideSelf(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this to intercept key down events before they are processed by the application. If you return true, the application will not process the event itself. If you return false, the normal application processing will occur as if the IME had not seen the event at all.</para><para>The default implementation intercepts KeyEvent.KEYCODE_BACK if the IME is currently shown, to possibly hide it when the key goes up (if not canceled or long pressed). In addition, in fullscreen mode only, it will consume DPAD movement events to move the cursor in the extracted text view, not allowing them to perform navigation in the underlying application. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation of KeyEvent.Callback.onKeyLongPress(): always returns false (doesn't handle the event). </para>        
				/// </summary>
				/// <java-name>
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyLongPress(int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this to intercept special key multiple events before they are processed by the application. If you return true, the application will not itself process the event. If you return false, the normal application processing will occur as if the IME had not seen the event at all.</para><para>The default implementation always returns false, except when in fullscreen mode, where it will consume DPAD movement events to move the cursor in the extracted text view, not allowing them to perform navigation in the underlying application. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int keyCode, int count, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this to intercept key up events before they are processed by the application. If you return true, the application will not itself process the event. If you return false, the normal application processing will occur as if the IME had not seen the event at all.</para><para>The default implementation intercepts KeyEvent.KEYCODE_BACK to hide the current IME UI if it is shown. In addition, in fullscreen mode only, it will consume DPAD movement events to move the cursor in the extracted text view, not allowing them to perform navigation in the underlying application. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this to intercept trackball motion events before they are processed by the application. If you return true, the application will not itself process the event. If you return false, the normal application processing will occur as if the IME had not seen the event at all. </para>        
				/// </summary>
				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onAppPrivateCommand
				/// </java-name>
				[Dot42.DexImport("onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnAppPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Send the given key event code (as defined by KeyEvent) to the current input connection is a key down + key up event pair. The sent events have KeyEvent.FLAG_SOFT_KEYBOARD set, so that the recipient can identify them as coming from a software input method, and KeyEvent.FLAG_KEEP_TOUCH_MODE, so that they don't impact the current touch mode of the UI.</para><para>Note that it's discouraged to send such key events in normal operation; this is mainly for use with android.text.InputType#TYPE_NULL type text fields, or for non-rich input methods. A reasonably capable software input method should use the android.view.inputmethod.InputConnection#commitText family of methods to send text to an application, rather than sending key events.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sendDownUpKeyEvents
				/// </java-name>
				[Dot42.DexImport("sendDownUpKeyEvents", "(I)V", AccessFlags = 1)]
				public virtual void SendDownUpKeyEvents(int keyEventCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ask the input target to execute its default action via InputConnection.performEditorAction().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a boolean indicating whether an action has been sent. If false, either the editor did not specify a default action or it does not want an action from the enter key. If true, the action was sent (or there was no input connection at all). </para>
				/// </returns>
				/// <java-name>
				/// sendDefaultEditorAction
				/// </java-name>
				[Dot42.DexImport("sendDefaultEditorAction", "(Z)Z", AccessFlags = 1)]
				public virtual bool SendDefaultEditorAction(bool fromEnterKey) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Send the given UTF-16 character to the current input connection. Most characters will be delivered simply by calling InputConnection.commitText() with the character; some, however, may be handled different. In particular, the enter character ('<br></br>') will either be delivered as an action code or a raw key event, as appropriate. Consider this as a convenience method for IMEs that do not have a full implementation of actions; a fully complying IME will decide of the right action for each event and will likely never call this method except maybe to handle events coming from an actual hardware keyboard.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// sendKeyChar
				/// </java-name>
				[Dot42.DexImport("sendKeyChar", "(C)V", AccessFlags = 1)]
				public virtual void SendKeyChar(char charCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the user has moved the cursor in the extracted text view, when running in fullsreen mode. The default implementation performs the corresponding selection change on the underlying text editor. </para>        
				/// </summary>
				/// <java-name>
				/// onExtractedSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onExtractedSelectionChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnExtractedSelectionChanged(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the user has clicked on the extracted text view, when running in fullscreen mode. The default implementation hides the candidates view when this happens, but only if the extracted text editor has a vertical scroll bar because its text doesn't fit. Re-implement this to provide whatever behavior you want. </para>        
				/// </summary>
				/// <java-name>
				/// onExtractedTextClicked
				/// </java-name>
				[Dot42.DexImport("onExtractedTextClicked", "()V", AccessFlags = 1)]
				public virtual void OnExtractedTextClicked() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the user has performed a cursor movement in the extracted text view, when it is running in fullscreen mode. The default implementation hides the candidates view when a vertical movement happens, but only if the extracted text editor has a vertical scroll bar because its text doesn't fit. Re-implement this to provide whatever behavior you want. </para>        
				/// </summary>
				/// <java-name>
				/// onExtractedCursorMovement
				/// </java-name>
				[Dot42.DexImport("onExtractedCursorMovement", "(II)V", AccessFlags = 1)]
				public virtual void OnExtractedCursorMovement(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the user has selected a context menu item from the extracted text view, when running in fullscreen mode. The default implementation sends this action to the current InputConnection's InputConnection#performContextMenuAction(int), for it to be processed in underlying "real" editor. Re-implement this to provide whatever behavior you want. </para>        
				/// </summary>
				/// <java-name>
				/// onExtractTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onExtractTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public virtual bool OnExtractTextContextMenuItem(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return text that can be used as a button label for the given EditorInfo.imeOptions. Returns null if there is no action requested. Note that there is no guarantee that the returned text will be relatively short, so you probably do not want to use it as text on a soft keyboard key label.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getTextForImeAction
				/// </java-name>
				[Dot42.DexImport("getTextForImeAction", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextForImeAction(int imeOptions) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Called when the fullscreen-mode extracting editor info has changed, to determine whether the extracting (extract text and candidates) portion of the UI should be shown. The standard implementation hides or shows the extract area depending on whether it makes sense for the current editor. In particular, a InputType#TYPE_NULL input type or EditorInfo#IME_FLAG_NO_EXTRACT_UI flag will turn off the extract area since there is no text to be shown. </para>        
				/// </summary>
				/// <java-name>
				/// onUpdateExtractingVisibility
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractingVisibility(global::Android.View.Inputmethod.EditorInfo ei) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the fullscreen-mode extracting editor info has changed, to update the state of its UI such as the action buttons shown. You do not need to deal with this if you are using the standard full screen extract UI. If replacing it, you will need to re-implement this to put the appropriate action button in your own UI and handle it, and perform any other changes.</para><para>The standard implementation turns on or off its accessory area depending on whether there is an action button, and hides or shows the entire extract area depending on whether it makes sense for the current editor. In particular, a InputType#TYPE_NULL or InputType#TYPE_TEXT_VARIATION_FILTER input type will turn off the extract area since there is no text to be shown. </para>        
				/// </summary>
				/// <java-name>
				/// onUpdateExtractingViews
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractingViews(global::Android.View.Inputmethod.EditorInfo ei) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when, while currently displayed in extract mode, the current input target changes. The default implementation will auto-hide the IME if the new target is not a full editor, since this can be a confusing experience for the user. </para>        
				/// </summary>
				/// <java-name>
				/// onExtractingInputChanged
				/// </java-name>
				[Dot42.DexImport("onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnExtractingInputChanged(global::Android.View.Inputmethod.EditorInfo ei) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the subtype was changed. </para>        
				/// </summary>
				/// <java-name>
				/// onCurrentInputMethodSubtypeChanged
				/// </java-name>
				[Dot42.DexImport("onCurrentInputMethodSubtypeChanged", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 4)]
				protected internal virtual void OnCurrentInputMethodSubtypeChanged(global::Android.View.Inputmethod.InputMethodSubtype newSubtype) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs a dump of the InputMethodService's internal state. Override to add your own information to the dump. </para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fd, global::Java.Io.PrintWriter fout, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public global::Android.View.LayoutInflater LayoutInflater
				{
				[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
						get{ return GetLayoutInflater(); }
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.App.Dialog Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

				/// <java-name>
				/// getBackDisposition
				/// </java-name>
				public int BackDisposition
				{
				[Dot42.DexImport("getBackDisposition", "()I", AccessFlags = 1)]
						get{ return GetBackDisposition(); }
				[Dot42.DexImport("setBackDisposition", "(I)V", AccessFlags = 1)]
						set{ SetBackDisposition(value); }
				}

				/// <summary>
				/// <para>Return the maximum width, in pixels, available the input method. Input methods are positioned at the bottom of the screen and, unless running in fullscreen, will generally want to be as short as possible so should compute their height based on their contents. However, they can stretch as much as needed horizontally. The function returns to you the maximum amount of space available horizontally, which you can use if needed for UI placement.</para><para>In many cases this is not needed, you can just rely on the normal view layout mechanisms to position your views within the full horizontal space given to the input method.</para><para>Note that this value can change dynamically, in particular when the screen orientation changes. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxWidth
				/// </java-name>
				public int MaxWidth
				{
				[Dot42.DexImport("getMaxWidth", "()I", AccessFlags = 1)]
						get{ return GetMaxWidth(); }
				}

				/// <summary>
				/// <para>Return the currently active InputBinding for the input method, or null if there is none. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentInputBinding
				/// </java-name>
				public global::Android.View.Inputmethod.InputBinding CurrentInputBinding
				{
				[Dot42.DexImport("getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;", AccessFlags = 1)]
						get{ return GetCurrentInputBinding(); }
				}

				/// <summary>
				/// <para>Retrieve the currently active InputConnection that is bound to the input method, or null if there is none. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentInputConnection
				/// </java-name>
				public global::Android.View.Inputmethod.IInputConnection CurrentInputConnection
				{
				[Dot42.DexImport("getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
						get{ return GetCurrentInputConnection(); }
				}

				/// <java-name>
				/// getCurrentInputStarted
				/// </java-name>
				public bool IsCurrentInputStarted
				{
				[Dot42.DexImport("getCurrentInputStarted", "()Z", AccessFlags = 1)]
						get{ return GetCurrentInputStarted(); }
				}

				/// <java-name>
				/// getCurrentInputEditorInfo
				/// </java-name>
				public global::Android.View.Inputmethod.EditorInfo CurrentInputEditorInfo
				{
				[Dot42.DexImport("getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;", AccessFlags = 1)]
						get{ return GetCurrentInputEditorInfo(); }
				}

				/// <summary>
				/// <para>Returns the visibility mode (either View.INVISIBLE or View.GONE) of the candidates view when it is not shown. The default implementation returns GONE when isExtractViewShown returns true, otherwise VISIBLE. Be careful if you change this to return GONE in other situations  if showing or hiding the candidates view causes your window to resize, this can cause temporary drawing artifacts as the resize takes place. </para>        
				/// </summary>
				/// <java-name>
				/// getCandidatesHiddenVisibility
				/// </java-name>
				public int CandidatesHiddenVisibility
				{
				[Dot42.DexImport("getCandidatesHiddenVisibility", "()I", AccessFlags = 1)]
						get{ return GetCandidatesHiddenVisibility(); }
				}

				/// <summary>
				/// <para>Information about where interesting parts of the input method UI appear. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/InputMethodService$Insets
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$Insets", AccessFlags = 25)]
				public sealed partial class Insets
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>This is the top part of the UI that is the main content. It is used to determine the basic space needed, to resize/pan the application behind. It is assumed that this inset does not change very much, since any change will cause a full resize/pan of the application behind. This value is relative to the top edge of the input method window. </para>        
						/// </summary>
						/// <java-name>
						/// contentTopInsets
						/// </java-name>
						[Dot42.DexImport("contentTopInsets", "I", AccessFlags = 1)]
						public int ContentTopInsets;
						/// <summary>
						/// <para>This is the top part of the UI that is visibly covering the application behind it. This provides finer-grained control over visibility, allowing you to change it relatively frequently (such as hiding or showing candidates) without disrupting the underlying UI too much. For example, this will never resize the application UI, will only pan if needed to make the current focus visible, and will not aggressively move the pan position when this changes unless needed to make the focus visible. This value is relative to the top edge of the input method window. </para>        
						/// </summary>
						/// <java-name>
						/// visibleTopInsets
						/// </java-name>
						[Dot42.DexImport("visibleTopInsets", "I", AccessFlags = 1)]
						public int VisibleTopInsets;
						/// <summary>
						/// <para>This is the region of the UI that is touchable. It is used when touchableInsets is set to TOUCHABLE_INSETS_REGION. The region should be specified relative to the origin of the window frame. </para>        
						/// </summary>
						/// <java-name>
						/// touchableRegion
						/// </java-name>
						[Dot42.DexImport("touchableRegion", "Landroid/graphics/Region;", AccessFlags = 17)]
						public readonly global::Android.Graphics.Region TouchableRegion;
						/// <summary>
						/// <para>Option for touchableInsets: the entire window frame can be touched. </para>        
						/// </summary>
						/// <java-name>
						/// TOUCHABLE_INSETS_FRAME
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_FRAME", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_FRAME = 0;
						/// <summary>
						/// <para>Option for touchableInsets: the area inside of the content insets can be touched. </para>        
						/// </summary>
						/// <java-name>
						/// TOUCHABLE_INSETS_CONTENT
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_CONTENT", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_CONTENT = 1;
						/// <summary>
						/// <para>Option for touchableInsets: the area inside of the visible insets can be touched. </para>        
						/// </summary>
						/// <java-name>
						/// TOUCHABLE_INSETS_VISIBLE
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_VISIBLE", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_VISIBLE = 2;
						/// <summary>
						/// <para>Option for touchableInsets: the region specified by touchableRegion can be touched. </para>        
						/// </summary>
						/// <java-name>
						/// TOUCHABLE_INSETS_REGION
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_REGION", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_REGION = 3;
						/// <summary>
						/// <para>Determine which area of the window is touchable by the user. May be one of: TOUCHABLE_INSETS_FRAME, TOUCHABLE_INSETS_CONTENT, TOUCHABLE_INSETS_VISIBLE, or TOUCHABLE_INSETS_REGION. </para>        
						/// </summary>
						/// <java-name>
						/// touchableInsets
						/// </java-name>
						[Dot42.DexImport("touchableInsets", "I", AccessFlags = 1)]
						public int TouchableInsets;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Insets() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				/// <para>Concrete implementation of AbstractInputMethodService.AbstractInputMethodSessionImpl that provides all of the standard behavior for an input method session. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/InputMethodService$InputMethodSessionImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$InputMethodSessionImpl", AccessFlags = 1)]
				public partial class InputMethodSessionImpl : global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/InputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.InputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/InputMethodService;)V", AccessFlags = 1)]
						public InputMethodSessionImpl(global::Android.Inputmethodservice.InputMethodService inputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>This method is called when the application would like to stop receiving text input. </para>        
						/// </summary>
						/// <java-name>
						/// finishInput
						/// </java-name>
						[Dot42.DexImport("finishInput", "()V", AccessFlags = 1)]
						public override void FinishInput() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Call InputMethodService.onDisplayCompletions(). </para>        
						/// </summary>
						/// <java-name>
						/// displayCompletions
						/// </java-name>
						[Dot42.DexImport("displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
						public override void DisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completions) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Call InputMethodService.onUpdateExtractedText(). </para>        
						/// </summary>
						/// <java-name>
						/// updateExtractedText
						/// </java-name>
						[Dot42.DexImport("updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
						public override void UpdateExtractedText(int token, global::Android.View.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Call InputMethodService.onUpdateSelection(). </para>        
						/// </summary>
						/// <java-name>
						/// updateSelection
						/// </java-name>
						[Dot42.DexImport("updateSelection", "(IIIIII)V", AccessFlags = 1)]
						public override void UpdateSelection(int oldSelStart, int oldSelEnd, int newSelStart, int newSelEnd, int candidatesStart, int candidatesEnd) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>This method is called when the user tapped a text view. IMEs can't rely on this method being called because this was not part of the original IME protocol, so applications with custom text editing written before this method appeared will not call to inform the IME of this interaction. </para>        
						/// </summary>
						/// <java-name>
						/// viewClicked
						/// </java-name>
						[Dot42.DexImport("viewClicked", "(Z)V", AccessFlags = 1)]
						public override void ViewClicked(bool focusChanged) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Call InputMethodService.onUpdateCursor(). </para>        
						/// </summary>
						/// <java-name>
						/// updateCursor
						/// </java-name>
						[Dot42.DexImport("updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
						public override void UpdateCursor(global::Android.Graphics.Rect newCursor) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Call InputMethodService.onAppPrivateCommand(). </para>        
						/// </summary>
						/// <java-name>
						/// appPrivateCommand
						/// </java-name>
						[Dot42.DexImport("appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
						public override void AppPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Toggle the soft input window. Applications can toggle the state of the soft input window. </para>        
						/// </summary>
						/// <java-name>
						/// toggleSoftInput
						/// </java-name>
						[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1)]
						public override void ToggleSoftInput(int showFlags, int hideFlags) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InputMethodSessionImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				/// <para>Concrete implementation of AbstractInputMethodService.AbstractInputMethodImpl that provides all of the standard behavior for an input method. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/InputMethodService$InputMethodImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$InputMethodImpl", AccessFlags = 1)]
				public partial class InputMethodImpl : global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/InputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.InputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/InputMethodService;)V", AccessFlags = 1)]
						public InputMethodImpl(global::Android.Inputmethodservice.InputMethodService inputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Take care of attaching the given window token provided by the system. </para>        
						/// </summary>
						/// <java-name>
						/// attachToken
						/// </java-name>
						[Dot42.DexImport("attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
						public override void AttachToken(global::Android.Os.IBinder token) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Handle a new input binding, calling InputMethodService.onBindInput() when done. </para>        
						/// </summary>
						/// <java-name>
						/// bindInput
						/// </java-name>
						[Dot42.DexImport("bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1)]
						public override void BindInput(global::Android.View.Inputmethod.InputBinding binding) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Clear the current input binding. </para>        
						/// </summary>
						/// <java-name>
						/// unbindInput
						/// </java-name>
						[Dot42.DexImport("unbindInput", "()V", AccessFlags = 1)]
						public override void UnbindInput() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// startInput
						/// </java-name>
						[Dot42.DexImport("startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1)]
						public override void StartInput(global::Android.View.Inputmethod.IInputConnection ic, global::Android.View.Inputmethod.EditorInfo attribute) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// restartInput
						/// </java-name>
						[Dot42.DexImport("restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1)]
						public override void RestartInput(global::Android.View.Inputmethod.IInputConnection ic, global::Android.View.Inputmethod.EditorInfo attribute) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Handle a request by the system to hide the soft input area. </para>        
						/// </summary>
						/// <java-name>
						/// hideSoftInput
						/// </java-name>
						[Dot42.DexImport("hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1)]
						public override void HideSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Handle a request by the system to show the soft input area. </para>        
						/// </summary>
						/// <java-name>
						/// showSoftInput
						/// </java-name>
						[Dot42.DexImport("showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1)]
						public override void ShowSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// changeInputMethodSubtype
						/// </java-name>
						[Dot42.DexImport("changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1)]
						public override void ChangeInputMethodSubtype(global::Android.View.Inputmethod.InputMethodSubtype subtype) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InputMethodImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>AbstractInputMethodService provides a abstract base class for input methods. Normal input method implementations will not derive from this directly, instead building on top of InputMethodService or another more complete base class. Be sure to read InputMethod for more information on the basics of writing input methods.</para><para>This class combines a Service (representing the input method component to the system with the InputMethod interface that input methods must implement. This base class takes care of reporting your InputMethod from the service when clients bind to it, but provides no standard implementation of the InputMethod interface itself. Derived classes must implement that interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/inputmethodservice/AbstractInputMethodService
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService", AccessFlags = 1057)]
		public abstract partial class AbstractInputMethodService : global::Android.App.Service, global::Android.View.KeyEvent.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractInputMethodService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the global KeyEvent.DispatcherState for used for processing events from the target application. Normally you will not need to use this directly, but just use the standard high-level event callbacks like onKeyDown. </para>        
				/// </summary>
				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
				public virtual global::Android.View.KeyEvent.DispatcherState GetKeyDispatcherState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.KeyEvent.DispatcherState);
				}

				/// <summary>
				/// <para>Called by the framework during initialization, when the InputMethod interface for this service needs to be created. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputMethodInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;" +
    "", AccessFlags = 1025)]
				public abstract global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl OnCreateInputMethodInterface() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by the framework when a new InputMethodSession interface is needed for a new client of the input method. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputMethodSessionInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessi" +
    "onImpl;", AccessFlags = 1025)]
				public abstract global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl OnCreateInputMethodSessionInterface() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Implement this to handle Binder.dump() calls on your input method. </para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fd, global::Java.Io.PrintWriter fout, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the communication channel to the service. May return null if clients can not bind to the service. The returned android.os.IBinder is usually for a complex interface that has been .</para><para><b>Note that unlike other application components, calls on to the IBinder interface returned here may not happen on the main thread of the process</b>. More information about the main thread can be found in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Return an IBinder through which clients can call on to the service. </para>
				/// </returns>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Implement this to handle trackball events on your input method.</para><para><para>View::onTrackballEvent </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled in this function, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyDown(int keyCode, global::Android.View.KeyEvent @event) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyLongPress(int keyCode, global::Android.View.KeyEvent @event) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyUp(int keyCode, global::Android.View.KeyEvent @event) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyMultiple(int keyCode, int count, global::Android.View.KeyEvent @event) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the global KeyEvent.DispatcherState for used for processing events from the target application. Normally you will not need to use this directly, but just use the standard high-level event callbacks like onKeyDown. </para>        
				/// </summary>
				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				public global::Android.View.KeyEvent.DispatcherState KeyDispatcherState
				{
				[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
						get{ return GetKeyDispatcherState(); }
				}

				/// <summary>
				/// <para>Base class for derived classes to implement their InputMethodSession interface. This takes care of basic maintenance of the session, but most behavior must be implemented in a derived class. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionI" +
    "mpl", AccessFlags = 1025)]
				public abstract partial class AbstractInputMethodSessionImpl : global::Android.View.Inputmethod.IInputMethodSession
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/AbstractInputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.AbstractInputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V", AccessFlags = 1)]
						public AbstractInputMethodSessionImpl(global::Android.Inputmethodservice.AbstractInputMethodService abstractInputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Check whether this session has been enabled by the system. If not enabled, you should not execute any calls on to it. </para>        
						/// </summary>
						/// <java-name>
						/// isEnabled
						/// </java-name>
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						public virtual bool IsEnabled() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Check whether this session has been revoked by the system. Revoked session is also always disabled, so there is generally no need to explicitly check for this. </para>        
						/// </summary>
						/// <java-name>
						/// isRevoked
						/// </java-name>
						[Dot42.DexImport("isRevoked", "()Z", AccessFlags = 1)]
						public virtual bool IsRevoked() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Change the enabled state of the session. This only works if the session has not been revoked. </para>        
						/// </summary>
						/// <java-name>
						/// setEnabled
						/// </java-name>
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetEnabled(bool enabled) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Revoke the session from the client. This disabled the session, and prevents it from ever being enabled again. </para>        
						/// </summary>
						/// <java-name>
						/// revokeSelf
						/// </java-name>
						[Dot42.DexImport("revokeSelf", "()V", AccessFlags = 1)]
						public virtual void RevokeSelf() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Take care of dispatching incoming key events to the appropriate callbacks on the service, and tell the client when this is done. </para>        
						/// </summary>
						/// <java-name>
						/// dispatchKeyEvent
						/// </java-name>
						[Dot42.DexImport("dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallba" +
    "ck;)V", AccessFlags = 1)]
						public virtual void DispatchKeyEvent(int seq, global::Android.View.KeyEvent @event, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback callback) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Take care of dispatching incoming trackball events to the appropriate callbacks on the service, and tell the client when this is done. </para>        
						/// </summary>
						/// <java-name>
						/// dispatchTrackballEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCal" +
    "lback;)V", AccessFlags = 1)]
						public virtual void DispatchTrackballEvent(int seq, global::Android.View.MotionEvent @event, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback callback) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AbstractInputMethodSessionImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "finishInput", "()V", AccessFlags = 1025)]
						public virtual void FinishInput() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateSelection", "(IIIIII)V", AccessFlags = 1025)]
						public virtual void UpdateSelection(int oldSelStart, int oldSelEnd, int newSelStart, int newSelEnd, int candidatesStart, int candidatesEnd) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "viewClicked", "(Z)V", AccessFlags = 1025)]
						public virtual void ViewClicked(bool focusChanged) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1025)]
						public virtual void UpdateCursor(global::Android.Graphics.Rect newCursor) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1025)]
						public virtual void DisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completions) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1025)]
						public virtual void UpdateExtractedText(int token, global::Android.View.Inputmethod.ExtractedText text) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
						public virtual void AppPrivateCommand(string action, global::Android.Os.Bundle data) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "toggleSoftInput", "(II)V", AccessFlags = 1025)]
						public virtual void ToggleSoftInput(int showFlags, int hideFlags) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

				}

				/// <summary>
				/// <para>Base class for derived classes to implement their InputMethod interface. This takes care of basic maintenance of the input method, but most behavior must be implemented in a derived class. </para>    
				/// </summary>
				/// <java-name>
				/// android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl", AccessFlags = 1025)]
				public abstract partial class AbstractInputMethodImpl : global::Android.View.Inputmethod.IInputMethod
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/AbstractInputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.AbstractInputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V", AccessFlags = 1)]
						public AbstractInputMethodImpl(global::Android.Inputmethodservice.AbstractInputMethodService abstractInputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Instantiate a new client session for the input method, by calling back to AbstractInputMethodService.onCreateInputMethodSessionInterface(). </para>        
						/// </summary>
						/// <java-name>
						/// createSession
						/// </java-name>
						[Dot42.DexImport("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", AccessFlags = 1)]
						public virtual void CreateSession(global::Android.View.Inputmethod.IInputMethod_ISessionCallback callback) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Take care of enabling or disabling an existing session by calling its AbstractInputMethodSessionImpl.setEnabled() method. </para>        
						/// </summary>
						/// <java-name>
						/// setSessionEnabled
						/// </java-name>
						[Dot42.DexImport("setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", AccessFlags = 1)]
						public virtual void SetSessionEnabled(global::Android.View.Inputmethod.IInputMethodSession session, bool enabled) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Take care of killing an existing session by calling its AbstractInputMethodSessionImpl.revokeSelf() method. </para>        
						/// </summary>
						/// <java-name>
						/// revokeSession
						/// </java-name>
						[Dot42.DexImport("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", AccessFlags = 1)]
						public virtual void RevokeSession(global::Android.View.Inputmethod.IInputMethodSession session) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AbstractInputMethodImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1025)]
						public virtual void AttachToken(global::Android.Os.IBinder token) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1025)]
						public virtual void BindInput(global::Android.View.Inputmethod.InputBinding binding) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "unbindInput", "()V", AccessFlags = 1025)]
						public virtual void UnbindInput() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
						public virtual void StartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo info) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
						public virtual void RestartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo attribute) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
						public virtual void ShowSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
						public virtual void HideSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1025)]
						public virtual void ChangeInputMethodSubtype(global::Android.View.Inputmethod.InputMethodSubtype subtype) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/inputmethodservice/ExtractEditText
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/ExtractEditText", AccessFlags = 33)]
		public partial class ExtractEditText : global::Android.Widget.EditText
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start making changes that will not be reported to the client. That is, onSelectionChanged(int, int) will not result in sending the new selection to the client </para>        
				/// </summary>
				/// <java-name>
				/// startInternalChanges
				/// </java-name>
				[Dot42.DexImport("startInternalChanges", "()V", AccessFlags = 1)]
				public virtual void StartInternalChanges() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finish making changes that will not be reported to the client. That is, onSelectionChanged(int, int) will not result in sending the new selection to the client </para>        
				/// </summary>
				/// <java-name>
				/// finishInternalChanges
				/// </java-name>
				[Dot42.DexImport("finishInternalChanges", "()V", AccessFlags = 1)]
				public virtual void FinishInternalChanges() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement just to keep track of when we are setting text from the client (vs. seeing changes in ourself from the user). </para>        
				/// </summary>
				/// <java-name>
				/// setExtractedText
				/// </java-name>
				[Dot42.DexImport("setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public override void SetExtractedText(global::Android.View.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report to the underlying text editor about selection changes. </para>        
				/// </summary>
				/// <java-name>
				/// onSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onSelectionChanged", "(II)V", AccessFlags = 4)]
				protected internal override void OnSelectionChanged(int selStart, int selEnd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Redirect clicks to the IME for handling there. First allows any on click handler to run, though. </para>        
				/// </summary>
				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public override bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called when a context menu option for the text view is selected. Currently this will be one of android.R.id#selectAll, android.R.id#cut, android.R.id#copy or android.R.id#paste.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the context menu item action was performed. </para>
				/// </returns>
				/// <java-name>
				/// onTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public override bool OnTextContextMenuItem(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>We are always considered to be an input method target. </para>        
				/// </summary>
				/// <java-name>
				/// isInputMethodTarget
				/// </java-name>
				[Dot42.DexImport("isInputMethodTarget", "()Z", AccessFlags = 1)]
				public override bool IsInputMethodTarget() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return true if the edit text is currently showing a scroll bar. </para>        
				/// </summary>
				/// <java-name>
				/// hasVerticalScrollBar
				/// </java-name>
				[Dot42.DexImport("hasVerticalScrollBar", "()Z", AccessFlags = 1)]
				public virtual bool HasVerticalScrollBar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Pretend like the window this view is in always has focus, so its highlight and cursor will be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// hasWindowFocus
				/// </java-name>
				[Dot42.DexImport("hasWindowFocus", "()Z", AccessFlags = 1)]
				public override bool HasWindowFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Pretend like this view always has focus, so its highlight and cursor will be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// isFocused
				/// </java-name>
				[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
				public override bool IsFocused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Pretend like this view always has focus, so its highlight and cursor will be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// hasFocus
				/// </java-name>
				[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
				public override bool HasFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExtractEditText() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


