// Copyright (C) 2014 dot42
//
// Original filename: IConvertible.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Runtime.InteropServices;

namespace System
{

    [ComVisible(true)]
    [CLSCompliant(false)]
    public interface IConvertible
    {
        TypeCode GetTypeCode();

        bool ToBoolean(IFormatProvider provider);
        byte ToByte(IFormatProvider provider);
        char ToChar(IFormatProvider provider);
        DateTime ToDateTime(IFormatProvider provider);
        decimal ToDecimal(IFormatProvider provider);
        double ToDouble(IFormatProvider provider);
        short ToInt16(IFormatProvider provider);
        int ToInt32(IFormatProvider provider);
        long ToInt64(IFormatProvider provider);
        sbyte ToSByte(IFormatProvider provider);
        float ToSingle(IFormatProvider provider);
        string ToString(IFormatProvider provider);
        object ToType(Type conversionType, IFormatProvider provider);
        ushort ToUInt16(IFormatProvider provider);
        uint ToUInt32(IFormatProvider provider);
        ulong ToUInt64(IFormatProvider provider);
    }
}

