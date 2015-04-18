namespace Dot42.Internal
{
    /// <summary>
    /// All types deriving from Android.App.Application are redirected
    /// by the compiler to derive from this class, so that we can capture
    /// the ApplicationContext, and set up the UI-Thread SynchronizationContext.
    /// </summary>
    [IncludeType]
    internal class Application : Android.App.Application
    {
        public Application()
        {
            Initialize(this);
        }
    }
}
