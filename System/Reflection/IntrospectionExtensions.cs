namespace System.Reflection
{
    public static class IntrospectionExtensions
    {
        public static TypeInfo GetTypeInfo(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return new TypeInfo(type);
        }
    }
}
