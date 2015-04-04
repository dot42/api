#pragma warning disable 1717
namespace Android.Service.Wallpaper
{
		/// <java-name>
		/// android/service/wallpaper/WallpaperService
		/// </java-name>
		[Dot42.DexImport("android/service/wallpaper/WallpaperService", AccessFlags = 1057)]
		public abstract partial class WallpaperService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.service.wallpaper.WallpaperService";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.service.wallpaper";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WallpaperService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// onCreateEngine
				/// </java-name>
				[Dot42.DexImport("onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;", AccessFlags = 1025)]
				public abstract global::Android.Service.Wallpaper.WallpaperService.Engine OnCreateEngine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] @string) /* MethodBuilder.Create */ 
				{
				}

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

						/// <java-name>
						/// getSurfaceHolder
						/// </java-name>
						[Dot42.DexImport("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", AccessFlags = 1)]
						public virtual global::Android.View.ISurfaceHolder GetSurfaceHolder() /* MethodBuilder.Create */ 
						{
								return default(global::Android.View.ISurfaceHolder);
						}

						/// <java-name>
						/// getDesiredMinimumWidth
						/// </java-name>
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
						public virtual int GetDesiredMinimumWidth() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getDesiredMinimumHeight
						/// </java-name>
						[Dot42.DexImport("getDesiredMinimumHeight", "()I", AccessFlags = 1)]
						public virtual int GetDesiredMinimumHeight() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// isVisible
						/// </java-name>
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						public virtual bool IsVisible() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// isPreview
						/// </java-name>
						[Dot42.DexImport("isPreview", "()Z", AccessFlags = 1)]
						public virtual bool IsPreview() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// setTouchEventsEnabled
						/// </java-name>
						[Dot42.DexImport("setTouchEventsEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetTouchEventsEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setOffsetNotificationsEnabled
						/// </java-name>
						[Dot42.DexImport("setOffsetNotificationsEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetOffsetNotificationsEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCreate
						/// </java-name>
						[Dot42.DexImport("onCreate", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnCreate(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onDestroy
						/// </java-name>
						[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
						public virtual void OnDestroy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onVisibilityChanged", "(Z)V", AccessFlags = 1)]
						public virtual void OnVisibilityChanged(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onTouchEvent
						/// </java-name>
						[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnTouchEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onOffsetsChanged
						/// </java-name>
						[Dot42.DexImport("onOffsetsChanged", "(FFFFII)V", AccessFlags = 1)]
						public virtual void OnOffsetsChanged(float single, float single1, float single2, float single3, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCommand
						/// </java-name>
						[Dot42.DexImport("onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;", AccessFlags = 1)]
						public virtual global::Android.OS.Bundle OnCommand(string @string, int int32, int int321, int int322, global::Android.OS.Bundle bundle, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Android.OS.Bundle);
						}

						/// <java-name>
						/// onDesiredSizeChanged
						/// </java-name>
						[Dot42.DexImport("onDesiredSizeChanged", "(II)V", AccessFlags = 1)]
						public virtual void OnDesiredSizeChanged(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onSurfaceChanged
						/// </java-name>
						[Dot42.DexImport("onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
						public virtual void OnSurfaceChanged(global::Android.View.ISurfaceHolder surfaceHolder, int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onSurfaceRedrawNeeded
						/// </java-name>
						[Dot42.DexImport("onSurfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceRedrawNeeded(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onSurfaceCreated
						/// </java-name>
						[Dot42.DexImport("onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceCreated(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onSurfaceDestroyed
						/// </java-name>
						[Dot42.DexImport("onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
						public virtual void OnSurfaceDestroyed(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 4)]
						protected internal virtual void Dump(string @string, global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Engine() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getSurfaceHolder
						/// </java-name>
						public global::Android.View.ISurfaceHolder SurfaceHolder
						{
						[Dot42.DexImport("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", AccessFlags = 1)]
								get{ return GetSurfaceHolder(); }
						}

						/// <java-name>
						/// getDesiredMinimumWidth
						/// </java-name>
						public int DesiredMinimumWidth
						{
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
								get{ return GetDesiredMinimumWidth(); }
						}

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

