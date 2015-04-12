using System.Threading;
using Dot42.Internal;

namespace Android.App
{
    public partial class Application
    {
        private static SynchronizationContext synchronizationContext = SynchronizationContext.Current;

        public static void InitializeSynchronizationContext()
        {
            synchronizationContext = new AndroidSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synchronizationContext);
        }

        public static SynchronizationContext SynchronizationContext { get { return synchronizationContext; } }
    }
}
