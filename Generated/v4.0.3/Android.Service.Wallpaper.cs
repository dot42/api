// Copyright (C) 2014 dot42
//
// Original filename: Android.Service.Wallpaper.cs
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
namespace Android.Service.Wallpaper
{
		/// <summary>
		/// <para>A wallpaper service is responsible for showing a live wallpaper behind applications that would like to sit on top of it. This service object itself does very little  its only purpose is to generate instances of Engine as needed. Implementing a wallpaper thus involves subclassing from this, subclassing an Engine implementation, and implementing onCreateEngine() to return a new instance of your engine. </para>    
		/// </summary>
		/// <java-name>
		/// android/service/wallpaper/WallpaperService
		/// </java-name>
		[Dot42.DexImport("android/service/wallpaper/WallpaperService", AccessFlags = 1057)]
		public abstract partial class WallpaperService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Intent that must be declared as handled by the service. To be supported, the service must also require the android.Manifest.permission#BIND_WALLPAPER permission so that other applications can not abuse it. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.service.wallpaper.WallpaperService";
				/// <summary>
				/// <para>Name under which a WallpaperService component publishes information about itself. This meta-data must reference an XML resource containing a <code>&lt;wallpaper&gt;</code> tag. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.service.wallpaper";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WallpaperService() /* MethodBuilder.Create */ 
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
				/// <para>Implement to return the implementation of the internal accessibility service interface. Subclasses should not override. </para>        
				/// </summary>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Must be implemented to return a new instance of the wallpaper's engine. Note that multiple instances may be active at the same time, such as when the wallpaper is currently set as the active wallpaper and the user is in the wallpaper picker viewing a preview of it as well. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateEngine
				/// </java-name>
				[Dot42.DexImport("onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;", AccessFlags = 1025)]
				public abstract global::Android.Service.Wallpaper.WallpaperService.Engine OnCreateEngine() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Print the Service's state into the given stream. This gets invoked if you run "adb shell dumpsys activity service &amp;lt;yourservicename&amp;gt;" (note that for this command to work, the service must be running, and you must specify a fully-qualified service name). This is distinct from "dumpsys &amp;lt;servicename&amp;gt;", which only works for named system services and which invokes the IBinder#dump method on the IBinder interface registered with ServiceManager.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fd, global::Java.Io.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The actual implementation of a wallpaper. A wallpaper service may have multiple instances running (for example as a real wallpaper and as a preview), each of which is represented by its own Engine instance. You must implement WallpaperService#onCreateEngine() to return your concrete Engine implementation. </para>    
				/// </summary>
				/// <java-name>
				/// android/service/wallpaper/WallpaperService$Engine
				/// </java-name>
				[Dot42.DexImport("android/service/wallpaper/WallpaperService$Engine", AccessFlags = 1)]
				public partial class Engine
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/service/wallpaper/WallpaperService;", AccessFlags = 4112)]
						internal readonly global::Android.Service.Wallpaper.WallpaperService This_0;
						[Dot42.DexImport("<init>", "(Landroid/service/wallpaper/WallpaperService;)V", AccessFlags = 1)]
						public Engine(global::Android.Service.Wallpaper.WallpaperService wallpaperService) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Provides access to the surface in which this wallpaper is drawn. </para>        
						/// </summary>
						/// <java-name>
						/// getSurfaceHolder
						/// </java-name>
						[Dot42.DexImport("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", AccessFlags = 1)]
						public virtual global::Android.View.ISurfaceHolder GetSurfaceHolder() /* MethodBuilder.Create */ 
						{
								return default(global::Android.View.ISurfaceHolder);
						}

						/// <summary>
						/// <para>Convenience for WallpaperManager.getDesiredMinimumWidth(), returning the width that the system would like this wallpaper to run in. </para>        
						/// </summary>
						/// <java-name>
						/// getDesiredMinimumWidth
						/// </java-name>
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
						public virtual int GetDesiredMinimumWidth() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Convenience for WallpaperManager.getDesiredMinimumHeight(), returning the height that the system would like this wallpaper to run in. </para>        
						/// </summary>
						/// <java-name>
						/// getDesiredMinimumHeight
						/// </java-name>
						[Dot42.DexImport("getDesiredMinimumHeight", "()I", AccessFlags = 1)]
						public virtual int GetDesiredMinimumHeight() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Return whether the wallpaper is currently visible to the user, this is the last value supplied to onVisibilityChanged(boolean). </para>        
						/// </summary>
						/// <java-name>
						/// isVisible
						/// </java-name>
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						public virtual bool IsVisible() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns true if this engine is running in preview mode  that is, it is being shown to the user before they select it as the actual wallpaper. </para>        
						/// </summary>
						/// <java-name>
						/// isPreview
						/// </java-name>
						[Dot42.DexImport("isPreview", "()Z", AccessFlags = 1)]
						public virtual bool IsPreview() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Control whether this wallpaper will receive raw touch events from the window manager as the user interacts with the window that is currently displaying the wallpaper. By default they are turned off. If enabled, the events will be received in onTouchEvent(MotionEvent). </para>        
						/// </summary>
						/// <java-name>
						/// setTouchEventsEnabled
						/// </java-name>
						[Dot42.DexImport("setTouchEventsEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetTouchEventsEnabled(bool enabled) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Control whether this wallpaper will receive notifications when the wallpaper has been scrolled. By default, wallpapers will receive notifications, although the default static image wallpapers do not. It is a performance optimization to set this to false.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setOffsetNotificationsEnabled
						/// </java-name>
						[Dot42.DexImport("setOffsetNotificationsEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetOffsetNotificationsEnabled(bool enabled) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Called once to initialize the engine. After returning, the engine's surface will be created by the framework. </para>        
						/// </summary>
						/// <java-name>
						/// onCreate
						/// </java-name>
						[Dot42.DexImport("onCreate", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnCreate(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Called right before the engine is going away. After this the surface will be destroyed and this Engine object is no longer valid. </para>        
						/// </summary>
						/// <java-name>
						/// onDestroy
						/// </java-name>
						[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
						public virtual void OnDestroy() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Called to inform you of the wallpaper becoming visible or hidden. <b>It is very important that a wallpaper only use CPU while it is visible.</b>. </para>        
						/// </summary>
						/// <java-name>
						/// onVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onVisibilityChanged", "(Z)V", AccessFlags = 1)]
						public virtual void OnVisibilityChanged(bool visible) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Called as the user performs touch-screen interaction with the window that is currently showing this wallpaper. Note that the events you receive here are driven by the actual application the user is interacting with, so if it is slow you will get fewer move events. </para>        
						/// </summary>
						/// <java-name>
						/// onTouchEvent
						/// </java-name>
						[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnTouchEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Called to inform you of the wallpaper's offsets changing within its contain, corresponding to the container's call to WallpaperManager.setWallpaperOffsets(). </para>        
						/// </summary>
						/// <java-name>
						/// onOffsetsChanged
						/// </java-name>
						[Dot42.DexImport("onOffsetsChanged", "(FFFFII)V", AccessFlags = 1)]
						public virtual void OnOffsetsChanged(float xOffset, float yOffset, float xOffsetStep, float yOffsetStep, int xPixelOffset, int yPixelOffset) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Process a command that was sent to the wallpaper with WallpaperManager#sendWallpaperCommand. The default implementation does nothing, and always returns null as the result.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>If returning a result, create a Bundle and place the result data in to it. Otherwise return null. </para>
						/// </returns>
						/// <java-name>
						/// onCommand
						/// </java-name>
						[Dot42.DexImport("onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;", AccessFlags = 1)]
						public virtual global::Android.Os.Bundle OnCommand(string action, int x, int y, int z, global::Android.Os.Bundle extras, bool resultRequested) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Os.Bundle);
						}

						/// <summary>
						/// <para>Called when an application has changed the desired virtual size of the wallpaper. </para>        
						/// </summary>
						/// <java-name>
						/// onDesiredSizeChanged
						/// </java-name>
						[Dot42.DexImport("onDesiredSizeChanged", "(II)V", AccessFlags = 1)]
						public virtual void OnDesiredSizeChanged(int desiredWidth, int desiredHeight) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Convenience for SurfaceHolder.Callback.surfaceChanged(). </para>        
						/// </summary>
						/// <java-name>
						/// onSurfaceChanged
						/// </java-name>
						[Dot42.DexImport("onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
						public virtual void OnSurfaceChanged(global::Android.View.ISurfaceHolder holder, int format, int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Convenience for SurfaceHolder.Callback.surfaceRedrawNeeded(). </para>        
						/// </summary>
						/// <java-name>
						/// onSurfaceRedrawNeeded
						/// </java-name>
						[Dot42.DexImport("onSurfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceRedrawNeeded(global::Android.View.ISurfaceHolder holder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Convenience for SurfaceHolder.Callback.surfaceCreated(). </para>        
						/// </summary>
						/// <java-name>
						/// onSurfaceCreated
						/// </java-name>
						[Dot42.DexImport("onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceCreated(global::Android.View.ISurfaceHolder holder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Convenience for SurfaceHolder.Callback.surfaceDestroyed(). </para>        
						/// </summary>
						/// <java-name>
						/// onSurfaceDestroyed
						/// </java-name>
						[Dot42.DexImport("onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceDestroyed(global::Android.View.ISurfaceHolder holder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 4)]
						protected internal virtual void Dump(string prefix, global::Java.Io.FileDescriptor fd, global::Java.Io.PrintWriter @out, string[] args) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Engine() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Provides access to the surface in which this wallpaper is drawn. </para>        
						/// </summary>
						/// <java-name>
						/// getSurfaceHolder
						/// </java-name>
						public global::Android.View.ISurfaceHolder SurfaceHolder
						{
						[Dot42.DexImport("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", AccessFlags = 1)]
								get{ return GetSurfaceHolder(); }
						}

						/// <summary>
						/// <para>Convenience for WallpaperManager.getDesiredMinimumWidth(), returning the width that the system would like this wallpaper to run in. </para>        
						/// </summary>
						/// <java-name>
						/// getDesiredMinimumWidth
						/// </java-name>
						public int DesiredMinimumWidth
						{
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
								get{ return GetDesiredMinimumWidth(); }
						}

						/// <summary>
						/// <para>Convenience for WallpaperManager.getDesiredMinimumHeight(), returning the height that the system would like this wallpaper to run in. </para>        
						/// </summary>
						/// <java-name>
						/// getDesiredMinimumHeight
						/// </java-name>
						public int DesiredMinimumHeight
						{
						[Dot42.DexImport("getDesiredMinimumHeight", "()I", AccessFlags = 1)]
								get{ return GetDesiredMinimumHeight(); }
						}

				}

		}

}


