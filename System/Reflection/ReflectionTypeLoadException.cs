namespace System.Reflection
{
    public class ReflectionTypeLoadException :Exception
    {
        public ReflectionTypeLoadException(Exception innerException)
            :base(innerException)
        {
        }
    }
}
