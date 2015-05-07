#pragma warning disable 1717
namespace Android.Hardware.Input
{
		/// <summary>
		///  <para>Provides information about input devices and available key layouts. </para> <para>Get an instance of this class by calling Context.getSystemService() with the argument android.content.Context#INPUT_SERVICE. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/input/InputManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/input/InputManager", AccessFlags = 49)]
		public sealed partial class InputManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast Action: Query available keyboard layouts. </para> <para>The input manager service locates available keyboard layouts by querying broadcast receivers that are registered for this action. An application can offer additional keyboard layouts to the user by declaring a suitable broadcast receiver in its manifest. </para> <para>Here is an example broadcast receiver declaration that an application might include in its AndroidManifest.xml to advertise keyboard layouts. The meta-data specifies a resource that contains a description of each keyboard layout that is provided by the application.  <pre> <code>
				/// &lt;receiver android:name=".InputDeviceReceiver"
				///         android:label="@string/keyboard_layouts_label"&gt;
				///     &lt;intent-filter&gt;
				///         &lt;action android:name="android.hardware.input.action.QUERY_KEYBOARD_LAYOUTS" /&gt;
				///     &lt;/intent-filter&gt;
				///     &lt;meta-data android:name="android.hardware.input.metadata.KEYBOARD_LAYOUTS"
				///             android:resource="@xml/keyboard_layouts" /&gt;
				/// &lt;/receiver&gt;
				/// </code></pre> </para> <para>In the above example, the  <code>/keyboard_layouts</code> resource refers to an XML resource whose root element is  <code>&lt;keyboard-layouts&gt;</code> that contains zero or more  <code>&lt;keyboard-layout&gt;</code> elements. Each  <code>&lt;keyboard-layout&gt;</code> element specifies the name, label, and location of a key character map for a particular keyboard layout. The label on the receiver is used to name the collection of keyboard layouts provided by this receiver in the keyboard layout settings.  <pre>
				/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
				/// &lt;keyboard-layouts xmlns:android="http://schemas.android.com/apk/res/android"&gt;
				///     &lt;keyboard-layout android:name="keyboard_layout_english_us"
				///             android:label="@string/keyboard_layout_english_us_label"
				///             android:keyboardLayout="@raw/keyboard_layout_english_us" /&gt;
				/// &lt;/keyboard-layouts&gt;
				/// </pre></para> <para> <pre></pre></para> <para> <pre>
				/// The  <code>android:name</code> attribute specifies an identifier by which
				/// the keyboard layout will be known in the package.
				/// The  <code>android:label</code> attributes specifies a human-readable descriptive
				/// label to describe the keyboard layout in the user interface, such as "English (US)".
				/// The  <code>android:keyboardLayout</code> attribute refers to a
				///  resource that defines the keyboard layout.
				/// </pre></para> <para> <pre>
				/// </pre></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_QUERY_KEYBOARD_LAYOUTS
				/// </java-name>
				[Dot42.DexImport("ACTION_QUERY_KEYBOARD_LAYOUTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_QUERY_KEYBOARD_LAYOUTS = "android.hardware.input.action.QUERY_KEYBOARD_LAYOUTS";
				/// <summary>
				///  <para>Metadata Key: Keyboard layout metadata associated with ACTION_QUERY_KEYBOARD_LAYOUTS. </para> <para>Specifies the resource id of a XML resource that describes the keyboard layouts that are provided by the application. </para>        
				/// </summary>
				/// <java-name>
				/// META_DATA_KEYBOARD_LAYOUTS
				/// </java-name>
				[Dot42.DexImport("META_DATA_KEYBOARD_LAYOUTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_KEYBOARD_LAYOUTS = "android.hardware.input.metadata.KEYBOARD_LAYOUTS";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InputManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets information about the input device with the specified id. </para>        
				/// </summary>
				/// <returns>
				///  <para>The input device or null if not found. </para>
				/// </returns>
				/// <java-name>
				/// getInputDevice
				/// </java-name>
				[Dot42.DexImport("getInputDevice", "(I)Landroid/view/InputDevice;", AccessFlags = 1)]
				public global::Android.Views.InputDevice GetInputDevice(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice);
				}

				/// <summary>
				///  <para>Registers an input device listener to receive notifications about when input devices are added, removed or changed.</para> <para> <para>unregisterInputDeviceListener </para></para>        
				/// </summary>
				/// <java-name>
				/// registerInputDeviceListener
				/// </java-name>
				[Dot42.DexImport("registerInputDeviceListener", "(Landroid/hardware/input/InputManager$InputDeviceListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void RegisterInputDeviceListener(global::Android.Hardware.Input.InputManager.IInputDeviceListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregisters an input device listener.</para> <para> <para>registerInputDeviceListener </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterInputDeviceListener
				/// </java-name>
				[Dot42.DexImport("unregisterInputDeviceListener", "(Landroid/hardware/input/InputManager$InputDeviceListener;)V", AccessFlags = 1)]
				public void UnregisterInputDeviceListener(global::Android.Hardware.Input.InputManager.IInputDeviceListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the ids of all input devices in the system. </para>        
				/// </summary>
				/// <returns>
				///  <para>The input device ids. </para>
				/// </returns>
				/// <java-name>
				/// getInputDeviceIds
				/// </java-name>
				public int[] InputDeviceIds
				{
						[Dot42.DexImport("getInputDeviceIds", "()[I", AccessFlags = 1)]
						get{ return default(int[]); }
				}

				/// <summary>
				///  <para>Listens for changes in input devices. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/input/InputManager$InputDeviceListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/input/InputManager$InputDeviceListener", AccessFlags = 1545)]
				public partial interface IInputDeviceListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called whenever an input device has been added to the system. Use InputManager#getInputDevice to get more information about the device.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInputDeviceAdded
						/// </java-name>
						[Dot42.DexImport("onInputDeviceAdded", "(I)V", AccessFlags = 1025)]
						void OnInputDeviceAdded(int deviceId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called whenever an input device has been removed from the system.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInputDeviceRemoved
						/// </java-name>
						[Dot42.DexImport("onInputDeviceRemoved", "(I)V", AccessFlags = 1025)]
						void OnInputDeviceRemoved(int deviceId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called whenever the properties of an input device have changed since they were last queried. Use InputManager#getInputDevice to get a fresh InputDevice object with the new properties.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInputDeviceChanged
						/// </java-name>
						[Dot42.DexImport("onInputDeviceChanged", "(I)V", AccessFlags = 1025)]
						void OnInputDeviceChanged(int deviceId) /* MethodBuilder.Create */ ;

				}

		}

}

