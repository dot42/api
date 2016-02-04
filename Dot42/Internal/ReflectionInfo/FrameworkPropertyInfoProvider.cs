using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Java.Util;

namespace Dot42.Internal.ReflectionInfo
{
    [Include(TypeCondition = typeof(IncludeFrameworkProperties))]
    internal class FrameworkPropertyInfoProvider : PropertyInfoProvider
    {
        private Hashtable<string, IProperty[]> _properties;

        public PropertyInfo[] BuildProperties(Type definingType, Type declaringType)
        {
            if (_properties == null)
                EnsurePropertyMap();

            Debug.Assert(_properties != null);

            string signature = "L" + definingType.JavaGetName().Replace('.', '/') + ";";
            
            IProperty[] props = _properties.Get(signature);
            if (props == null)
                return None;

            return PropertyInfoProvider.BuildProperties(definingType, declaringType, props, "get", "set");
        }

        private void EnsurePropertyMap()
        {
            lock (this)
            {
                if (_properties == null)
                {
                    _properties = new Hashtable<string, IProperty[]>();
                    var props = GetType().GetAnnotation<IProperties>(typeof (IProperties));
                    if (props == null) 
                        return;
                    string currentSignature = null;
                    ArrayList<IProperty> list = new ArrayList<IProperty>();
                    var empty = new IProperty[0];

                    foreach (var property in props.Properties())
                    {
                        var signature = property.DeclaringTypeDescriptor();

                        if (currentSignature != signature)
                        {
                            if(currentSignature != null)
                                _properties.Put(currentSignature, list.ToArray(empty));

                            currentSignature = signature;
                            list.Clear();
                        }

                        list.Add(property);
                    }

                    if (currentSignature != null)
                        _properties.Put(currentSignature, list.ToArray(empty));

                }
            }
        }
    }
}
