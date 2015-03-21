﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    internal enum ExceptionArgument
    {
        array,
        index,
        info,
        key,
        value,
        dictionary
    }

    internal enum ExceptionResource
    {
        InvalidOperation_EnumOpCantHappen,
        Arg_ArrayPlusOffTooSmall,
        Argument_AddingDuplicate,
        Arg_RankMultiDimNotSupported,
        Argument_InvalidArrayType,
        InvalidOperation_EnumFailedVersion,
        NotSupported_KeyCollectionSet,
        NotSupported_ValueCollectionSet,
        ArgumentOutOfRange_NeedNonNegNum,
        Arg_HTCapacityOverflow
    }


    internal class ThrowHelper
    {
        public static void ThrowArgumentNullException(ExceptionArgument arg)
        {
            throw new ArgumentNullException(arg.ToString());
        }

        public static void ThrowArgumentOutOfRangeException(ExceptionArgument arg, ExceptionResource msg)
        {
            throw new ArgumentOutOfRangeException(arg.ToString(), msg.ToString());
        }

        public static void ThrowArgumentException(ExceptionResource msg)
        {
            throw new ArgumentException(msg.ToString());
        }

        public static void ThrowInvalidOperationException(ExceptionResource msg)
        {
            throw new InvalidOperationException(msg.ToString());
        }

        public static void ThrowKeyNotFoundException()
        {
            throw new KeyNotFoundException();
        }

        public static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument arg)
        {
            if(!typeof(T).IsClass && value == null)
                throw new ArgumentNullException(arg.ToString());
        }

        public static void ThrowWrongValueTypeArgumentException(object value, Type type)
        {
            throw new ArgumentException("wrong value type: " + type.Name);
        }

        public static void ThrowWrongKeyTypeArgumentException(object key, Type type)
        {
            throw new ArgumentException("wrong key type: " + type.Name);
        }

        public static void ThrowNotSupportedException(ExceptionResource msg)
        {
            throw new NotSupportedException(msg.ToString());
        }
    }
}