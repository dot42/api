using Dot42;

namespace System.Reflection
{
    public static class CustomAttributeExtensions
    {
        public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
        {
            var ret = element.GetCustomAttributes(typeof (T), inherit);
            
            if(ret.Length > 0) 
                throw new System.AmbiguousMatchException();

            return (T)ret.FirstOrDefault();
        }
    }
}
