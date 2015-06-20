﻿using System;
using System.Diagnostics;
using Android.Content;

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
 
        public Application()
        {
            Initialize(this);
        }

        public override void OnLowMemory()
        {
            if (Android.OS.Build.VERSION.SDK_INT < Android.OS.Build.VERSION_CODES.ICE_CREAM_SANDWICH)
                FireReleaseCaches();

            base.OnLowMemory();
        }

        public override void OnTrimMemory(int level)
        {
            Debug.WriteLine("OnTrimMemory {0}", level);

            if (level >= IComponentCallbacks2Constants.TRIM_MEMORY_MODERATE)
                FireReleaseCaches();

            base.OnTrimMemory(level);
        }

        private void FireReleaseCaches()
        {
            Debug.WriteLine("releasing caches");

            var h = ReleaseCaches;
            if (h != null)
                h(this, new EventArgs());
        }

    }
}
