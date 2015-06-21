using System;
using System.Diagnostics;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;

namespace Dot42.Internal
{
    /// <summary>
    /// All types deriving from Android.App.Application are redirected
    /// by the compiler to derive from this class, so that we can always
    /// do some initialization.
    /// </summary>
    [IncludeType]
    internal class Application : Android.App.Application
    {
        public static event EventHandler ReleaseCaches;
        public static event EventHandler LocaleChanged;

        public Application()
        {
            Initialize(this);
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            // TODO: find out how to reliable detect locale changes.
            FireLocaleChanged(); 
            
            base.OnConfigurationChanged(newConfig);
        }

        public override void OnLowMemory()
        {
#if ANDROID_14P
            if (Android.OS.Build.VERSION.SDK_INT < Android.OS.Build.VERSION_CODES.ICE_CREAM_SANDWICH)
#endif
                FireReleaseCaches();

            base.OnLowMemory();
        }

#if ANDROID_14P
        public override void OnTrimMemory(int level)
        {
            Debug.WriteLine("OnTrimMemory {0}", level);

            if (level >= IComponentCallbacks2Constants.TRIM_MEMORY_MODERATE)
                FireReleaseCaches();

            base.OnTrimMemory(level);
        }
#endif

        private void FireReleaseCaches()
        {
            Debug.WriteLine("releasing caches");

            var h = ReleaseCaches;
            if (h != null)
                h(this, new EventArgs());
        }

        private static void FireLocaleChanged()
        {
            var handler = LocaleChanged;
            if (handler != null) handler(null, EventArgs.Empty);
        }
    }
}
