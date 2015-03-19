// ==++==
// 
//   Copyright(c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
// <OWNER>[....]</OWNER>
// 
using System;
using System.Collections.Generic;
//using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
    public enum ParameterAttributes
    {
        None = 0,
        In = 1,
        Out = 2,
        Lcid = 4,
        Retval = 8,
        Optional = 16,
        HasDefault = 4096,
        HasFieldMarshal = 8192,
    }

    [Serializable]
    //[ClassInterface(ClassInterfaceType.None)]
    public class ParameterInfo : ICustomAttributeProvider
    {
        private readonly MemberInfo _member;
        private readonly string _name;
        private readonly Type _parameterType;
        private readonly int _position;

        #region Constructor
        internal ParameterInfo(MemberInfo member, string name, Type parameterType, int position)
        {
            _member = member;
            _name = name;
            _parameterType = parameterType;
            _position = position;
        }

        #endregion

   
        public virtual Type ParameterType { get { return _parameterType; } }
        public virtual String Name { get { return _name; } }

        public virtual bool HasDefaultValue { get { throw new NotImplementedException(); } }

        public virtual Object DefaultValue { get { throw new NotImplementedException(); } }
        public virtual Object RawDefaultValue { get { throw new NotImplementedException(); } }

        public virtual int Position { get { return _position; } }
        public virtual ParameterAttributes Attributes { get { return ParameterAttributes.None; } }

        public virtual MemberInfo Member { get { return _member; } }

        public bool IsIn { get { return ((Attributes & ParameterAttributes.In) != 0); } }
        public bool IsOut { get { return ((Attributes & ParameterAttributes.Out) != 0); } }
#if FEATURE_USE_LCID        
        public bool IsLcid { get { return((Attributes & ParameterAttributes.Lcid) != 0); } }        
#endif
        public bool IsRetval { get { return ((Attributes & ParameterAttributes.Retval) != 0); } }
        public bool IsOptional { get { return ((Attributes & ParameterAttributes.Optional) != 0); } }

        //public virtual int MetadataToken
        //{
        //    get
        //    {
        //        // This API was made virtual in V4. Code compiled against V2 might use
        //        // "call" rather than "callvirt" to call it.
        //        // This makes sure those code still works.
        //        RuntimeParameterInfo rtParam = this as RuntimeParameterInfo;
        //        if (rtParam != null)
        //            return rtParam.MetadataToken;

        //        // return a null token
        //        return (int)MetadataTokenType.ParamDef;
        //    }
        //}

        //public virtual Type[] GetRequiredCustomModifiers()
        //{
        //    return EmptyArray<Type>.Value;
        //}

        //public virtual Type[] GetOptionalCustomModifiers()
        //{
        //    return EmptyArray<Type>.Value;
        //}


        public override String ToString()
        {
            return ParameterType.Name + " " + Name;
        }

        //public virtual IEnumerable<CustomAttributeData> CustomAttributes
        //{
        //    get
        //    {
        //        return GetCustomAttributesData();
        //    }
        //}

        public virtual Object[] GetCustomAttributes(bool inherit)
        {
            return new object[0];
            //return EmptyArray<Object>.Value;
        }

        public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            if (attributeType == null)
                throw new ArgumentNullException("attributeType");
            //Contract.EndContractBlock();

            return new object[0];
            //return EmptyArray<Object>.Value;
        }

        public virtual bool IsDefined(Type attributeType, bool inherit)
        {
            if (attributeType == null)
                throw new ArgumentNullException("attributeType");
            //Contract.EndContractBlock();

            return false;
        }

        //public virtual IList<CustomAttributeData> GetCustomAttributesData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}