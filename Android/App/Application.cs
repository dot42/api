using System.Threading;

namespace Android.App
{
    public partial class Application
    {
        private static readonly SynchronizationContext synchronizationContext = SynchronizationContext.Current;

        public static SynchronizationContext SynchronizationContext { get { return synchronizationContext; } }
    }
}
