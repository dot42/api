#pragma warning disable 1717
namespace Android.Hardware.Display
{
		/// <summary>
		///  <para>Manages the properties of attached displays. </para> <para>Get an instance of this class by calling Context.getSystemService() with the argument android.content.Context#DISPLAY_SERVICE. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/display/DisplayManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/display/DisplayManager", AccessFlags = 49)]
		public sealed partial class DisplayManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Display category: Presentation displays. </para> <para>This category can be used to identify secondary displays that are suitable for use as presentation displays such as HDMI or Wireless displays. Applications may automatically project their content to presentation displays to provide richer second screen experiences. </para> <para> <para>android.app.Presentation </para> <para>Display::FLAG_PRESENTATION </para> <para>getDisplays(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_CATEGORY_PRESENTATION
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CATEGORY_PRESENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DISPLAY_CATEGORY_PRESENTATION = "android.hardware.display.category.PRESENTATION";
				/// <summary>
				///  <para>Virtual display flag: Create a public display.</para> <para> <h3>Public virtual displays</h3></para> <para>When this flag is set, the virtual display is public. </para> <para>A public virtual display behaves just like most any other display that is connected to the system such as an HDMI or Wireless display. Applications can open windows on the display and the system may mirror the contents of other displays onto it. </para> <para>Creating a public virtual display requires the android.Manifest.permission#CAPTURE_VIDEO_OUTPUT or android.Manifest.permission#CAPTURE_SECURE_VIDEO_OUTPUT permission. These permissions are reserved for use by system components and are not available to third-party applications. </para> <para> <h3>Private virtual displays</h3></para> <para>When this flag is not set, the virtual display is private as defined by the Display#FLAG_PRIVATE display flag. </para> <para>A private virtual display belongs to the application that created it. Only the a owner of a private virtual display is allowed to place windows upon it. The private virtual display also does not participate in display mirroring: it will neither receive mirrored content from another display nor allow its own content to be mirrored elsewhere. More precisely, the only processes that are allowed to enumerate or interact with the private display are those that have the same UID as the application that originally created the private virtual display. </para> <para> <para>createVirtualDisplay </para></para>        
				/// </summary>
				/// <java-name>
				/// VIRTUAL_DISPLAY_FLAG_PUBLIC
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_DISPLAY_FLAG_PUBLIC", "I", AccessFlags = 25)]
				public const int VIRTUAL_DISPLAY_FLAG_PUBLIC = 1;
				/// <summary>
				///  <para>Virtual display flag: Create a presentation display.</para> <para> <h3>Presentation virtual displays</h3></para> <para>When this flag is set, the virtual display is registered as a presentation display in the presentation display category. Applications may automatically project their content to presentation displays to provide richer second screen experiences. </para> <para> <h3>Non-presentation virtual displays</h3></para> <para>When this flag is not set, the virtual display is not registered as a presentation display. Applications can still project their content on the display but they will typically not do so automatically. This option is appropriate for more special-purpose displays. </para> <para> <para>android.app.Presentation </para> <para>createVirtualDisplay </para> <para>DISPLAY_CATEGORY_PRESENTATION </para> <para>Display::FLAG_PRESENTATION </para></para>        
				/// </summary>
				/// <java-name>
				/// VIRTUAL_DISPLAY_FLAG_PRESENTATION
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_DISPLAY_FLAG_PRESENTATION", "I", AccessFlags = 25)]
				public const int VIRTUAL_DISPLAY_FLAG_PRESENTATION = 2;
				/// <summary>
				///  <para>Virtual display flag: Create a secure display.</para> <para> <h3>Secure virtual displays</h3></para> <para>When this flag is set, the virtual display is considered secure as defined by the Display#FLAG_SECURE display flag. The caller promises to take reasonable measures, such as over-the-air encryption, to prevent the contents of the display from being intercepted or recorded on a persistent medium. </para> <para>Creating a secure virtual display requires the android.Manifest.permission#CAPTURE_SECURE_VIDEO_OUTPUT permission. This permission is reserved for use by system components and is not available to third-party applications. </para> <para> <h3>Non-secure virtual displays</h3></para> <para>When this flag is not set, the virtual display is considered unsecure. The content of secure windows will be blanked if shown on this display. </para> <para> <para>Display::FLAG_SECURE </para> <para>createVirtualDisplay </para></para>        
				/// </summary>
				/// <java-name>
				/// VIRTUAL_DISPLAY_FLAG_SECURE
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_DISPLAY_FLAG_SECURE", "I", AccessFlags = 25)]
				public const int VIRTUAL_DISPLAY_FLAG_SECURE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DisplayManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets information about a logical display.</para> <para>The display metrics may be adjusted to provide compatibility for legacy applications.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The display object, or null if there is no valid display with the given id. </para>
				/// </returns>
				/// <java-name>
				/// getDisplay
				/// </java-name>
				[Dot42.DexImport("getDisplay", "(I)Landroid/view/Display;", AccessFlags = 1)]
				public global::Android.Views.Display GetDisplay(int displayId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Display);
				}

				/// <summary>
				///  <para>Gets all currently valid logical displays of the specified category. </para> <para>When there are multiple displays in a category the returned displays are sorted of preference. For example, if the requested category is DISPLAY_CATEGORY_PRESENTATION and there are multiple presentation displays then the displays are sorted so that the first display in the returned array is the most preferred presentation display. The application may simply use the first display or allow the user to choose. </para> <para> <para>DISPLAY_CATEGORY_PRESENTATION </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array containing all displays sorted by order of preference.</para>
				/// </returns>
				/// <java-name>
				/// getDisplays
				/// </java-name>
				[Dot42.DexImport("getDisplays", "(Ljava/lang/String;)[Landroid/view/Display;", AccessFlags = 1)]
				public global::Android.Views.Display[] GetDisplays(string category) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Display[]);
				}

				/// <summary>
				///  <para>Registers an display listener to receive notifications about when displays are added, removed or changed.</para> <para> <para>unregisterDisplayListener </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDisplayListener
				/// </java-name>
				[Dot42.DexImport("registerDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void RegisterDisplayListener(global::Android.Hardware.Display.DisplayManager.IDisplayListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregisters an input device listener.</para> <para> <para>registerDisplayListener </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDisplayListener
				/// </java-name>
				[Dot42.DexImport("unregisterDisplayListener", "(Landroid/hardware/display/DisplayManager$DisplayListener;)V", AccessFlags = 1)]
				public void UnregisterDisplayListener(global::Android.Hardware.Display.DisplayManager.IDisplayListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a virtual display. </para> <para>The content of a virtual display is rendered to a Surface provided by the application. </para> <para>The virtual display should be released when no longer needed. Because a virtual display renders to a surface provided by the application, it will be released automatically when the process terminates and all remaining windows on it will be forcibly removed. </para> <para>The behavior of the virtual display depends on the flags that are provided to this method. By default, virtual displays are created to be private, non-presentation and unsecure. Permissions may be required to use certain flags. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created virtual display, or null if the application could not create the virtual display.</para>
				/// </returns>
				/// <java-name>
				/// createVirtualDisplay
				/// </java-name>
				[Dot42.DexImport("createVirtualDisplay", "(Ljava/lang/String;IIILandroid/view/Surface;I)Landroid/hardware/display/VirtualDi" +
    "splay;", AccessFlags = 1)]
				public global::Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(string name, int width, int height, int densityDpi, global::Android.Views.Surface surface, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Display.VirtualDisplay);
				}

				/// <summary>
				///  <para>Gets all currently valid logical displays.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array containing all displays. </para>
				/// </returns>
				/// <java-name>
				/// getDisplays
				/// </java-name>
				public global::Android.Views.Display[] Displays
				{
						[Dot42.DexImport("getDisplays", "()[Landroid/view/Display;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Display[]); }
				}

				/// <summary>
				///  <para>Listens for changes in available display devices. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/display/DisplayManager$DisplayListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/display/DisplayManager$DisplayListener", AccessFlags = 1545)]
				public partial interface IDisplayListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called whenever a logical display has been added to the system. Use DisplayManager#getDisplay to get more information about the display.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayAdded
						/// </java-name>
						[Dot42.DexImport("onDisplayAdded", "(I)V", AccessFlags = 1025)]
						void OnDisplayAdded(int displayId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called whenever a logical display has been removed from the system.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayRemoved
						/// </java-name>
						[Dot42.DexImport("onDisplayRemoved", "(I)V", AccessFlags = 1025)]
						void OnDisplayRemoved(int displayId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called whenever the properties of a logical display have changed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDisplayChanged
						/// </java-name>
						[Dot42.DexImport("onDisplayChanged", "(I)V", AccessFlags = 1025)]
						void OnDisplayChanged(int displayId) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Represents a virtual display. The content of a virtual display is rendered to a android.view.Surface that you must provide to createVirtualDisplay(). </para> <para>Because a virtual display renders to a surface provided by the application, it will be released automatically when the process terminates and all remaining windows on it will be forcibly removed. However, you should also explicitly call release when you're done with it.</para> <para> <para>DisplayManager::createVirtualDisplay </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/display/VirtualDisplay
		/// </java-name>
		[Dot42.DexImport("android/hardware/display/VirtualDisplay", AccessFlags = 49)]
		public sealed partial class VirtualDisplay
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VirtualDisplay() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the virtual display and destroys its underlying surface. </para> <para>All remaining windows on the virtual display will be forcibly removed as part of releasing the virtual display. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public void Release() /* MethodBuilder.Create */ 
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
				///  <para>Gets the virtual display. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplay
				/// </java-name>
				public global::Android.Views.Display Display
				{
						[Dot42.DexImport("getDisplay", "()Landroid/view/Display;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Display); }
				}

		}

}

