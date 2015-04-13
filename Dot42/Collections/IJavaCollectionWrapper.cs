namespace Dot42.Collections
{
    internal interface IJavaCollectionWrapper<T>
    {
        Java.Util.ICollection<T> Collection { get; }
    }
}
