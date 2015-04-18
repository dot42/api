using System.ComponentModel;
using System.Threading;
using Android.Content;
using Dot42.Internal;

namespace Android.App
{
    public partial class Application
    {
        private static SynchronizationContext _synchronizationContext;
        private static Context _context;

        public static SynchronizationContext SynchronizationContext { get { return _synchronizationContext; } }
        public static Context Context { get { return _context; } }

        /// <summary>
        /// This method will setup the <see cref="Context"/> and <see cref="SynchronizationContext"/>
        /// properties. This method will usually be called automatically during application startup.
        /// </summary>
        /// <param name="ctx"></param>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static void Initialize(Context ctx)
        {
            _context = ctx;

            _synchronizationContext = new AndroidSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(_synchronizationContext);
        }

    }
}
