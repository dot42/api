using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dot42;

namespace System
{
    internal enum ExceptionArgument
    {
        array,
        index,
        info,
        key,
        value,
        dictionary,
        item,
        type
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
        Arg_HTCapacityOverflow,
        InvalidType,
        NotAGenericType,
        InternalError,
        MaximumNumberOfGenericTypesReached,
        WrongNumberOfArguments,
    }


    internal class ThrowHelper
    {
        [Inline]
        public static void ThrowIfArgumentNullException(object arg, string msg)
        {
            if(arg == null)
                ThrowArgumentNullException(msg);
        }

        public static void ThrowArgumentNullException(string msg)
        {
            throw new ArgumentNullException(msg);
        }

        public static void ThrowArgumentNullException(ExceptionArgument arg)
        {
            throw new ArgumentNullException(arg.ToString());
        }

        public static void ThrowArgumentOutOfRangeException(ExceptionArgument arg, ExceptionResource msg)
        {
            throw new ArgumentOutOfRangeException(arg.ToString(), msg.ToString());
        }

        public static void ThrowArgumentOutOfRangeException(ExceptionArgument arg)
        {
            throw new ArgumentOutOfRangeException(arg.ToString());
        }

        public static void ThrowArgumentException(ExceptionResource msg)
        {
            throw new ArgumentException(msg.ToString());
        }

        public static void ThrowArgumentException(string msg, string param)
        {
            throw new ArgumentException(msg, param);
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

        public static void ThrowArgumentException(ExceptionArgument arg)
        {
            throw new ArgumentException("argument error", arg.ToString());
        }
    }
}
