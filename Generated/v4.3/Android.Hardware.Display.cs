// Copyright (C) 2014 dot42
//
// Original filename: Android.Hardware.Display.cs
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
namespace Android.Hardware.Display
{
		/// <summary>
		/// <para>Manages the properties of attached displays. </para><para>Get an instance of this class by calling Context.getSystemService() with the argument android.content.Context#DISPLAY_SERVICE. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/display/DisplayManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/display/DisplayManager", AccessFlags = 49)]
		public sealed partial class DisplayManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Display category: Presentation displays. </para><para>This category can be used to identify secondary displays that are suitable for use as presentation displays. </para><para><para>android.app.Presentation for information about presenting content on secondary displays. </para><simplesectsep></simplesectsep><para>getDisplays(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_CATEGORY_PRESENTATION
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CATEGORY_PRESENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DISPLAY_CATEGORY_PRESENTATION = "android.hardware.display.category.PRESENTATION";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DisplayManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets information about a logical display.</para><para>The display metrics may be adjusted to provide compatibility for legacy applications.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The display object, or null if there is no valid display with the given id. </para>
				/// </returns>
				/// <java-name>
				/// getDisplay
				/// </java-name>
				[Dot42.DexImport("getDisplay", "(I)Landroid/view/Display;", AccessFlags = 1)]
				public global::Android.View.Display GetDisplay(int displayId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Display);
				}

				/// <summary>
				/// <para>Gets all currently valid logical displays.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array containing all displays. </para>
				/// </returns>
				/// <java-name>
				/// getDisplays
				/// </java-name>
				[Dot42.DexImport("getDisplays", "()[Landroid/view/Display;", AccessFlags = 1)]
				public global::Android.View.Display[] GetDisplays() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Display[]);
				}

				/// <summary>
				/// <para>Gets all currently valid logical displays of the specified category. </para><para>When there are multiple displays in a category the returned displays are sorted of preference. For example, if the requested category is DISPLAY_CATEGORY_PRESENTATION and there are multiple presentation displays then the displays are sorted so that the first display in the returned array is the most preferred presentation display. The application may simply use the first display or allow the user to choose. </para><para><para>DISPLAY_CATEGORY_PRESENTATION </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array containing all displays sorted by order of preference.</para>
				/// </returns>
				/// <java-name>
				/// getDisplays
				/// </java-name>
				[Dot42.DexImport("getDisplays", "(Ljava/lang/String;)[Landroid/view/Display;", AccessFlags = 1)]
				public global::Android.View.Display[] GetDisplays(string category) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Display[]);
				}

				/// <summary>
				/// <para>Registers an display listener to receive notifications about when displays are added, removed or changed.</para><para><para>unregisterDisplayListener </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDisplayListener
				/// </java-name>
				[Dot42.DexImport("registerDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void RegisterDisplayListener(global::Android.Hardware.Display.DisplayManager.IDisplayListener listener, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters an input device listener.</para><para><para>registerDisplayListener </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDisplayListener
				/// </java-name>
				[Dot42.DexImport("unregisterDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;)V", AccessFlags = 1)]
				public void UnregisterDisplayListener(global::Android.Hardware.Display.DisplayManager.IDisplayListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets all currently valid logical displays.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array containing all displays. </para>
				/// </returns>
				/// <java-name>
				/// getDisplays
				/// </java-name>
				public global::Android.View.Display[] Displays
				{
				[Dot42.DexImport("getDisplays", "()[Landroid/view/Display;", AccessFlags = 1)]
						get{ return GetDisplays(); }
				}

				/// <summary>
				/// <para>Listens for changes in available display devices. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/display/DisplayManager$DisplayListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/display/DisplayManager$DisplayListener", AccessFlags = 1545)]
				public partial interface IDisplayListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called whenever a logical display has been added to the system. Use DisplayManager#getDisplay to get more information about the display.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayAdded
						/// </java-name>
						[Dot42.DexImport("onDisplayAdded", "(I)V", AccessFlags = 1025)]
						void OnDisplayAdded(int displayId) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called whenever a logical display has been removed from the system.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayRemoved
						/// </java-name>
						[Dot42.DexImport("onDisplayRemoved", "(I)V", AccessFlags = 1025)]
						void OnDisplayRemoved(int displayId) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Called whenever the properties of a logical display have changed.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayChanged
						/// </java-name>
						[Dot42.DexImport("onDisplayChanged", "(I)V", AccessFlags = 1025)]
						void OnDisplayChanged(int displayId) /* MethodBuilder.Create */ ;

				}

		}

}


