using System.Globalization;
using System.Text;
using Dot42;
using Java.Math;

namespace System
{
	/// <summary>
	/// Represents a floating-point decimal data type with up to 29 significant
	/// digits, suitable for financial and commercial calculations.
	/// Based on Javas BigDecimal
	/// </summary>
	[Serializable]
	public struct Decimal: IFormattable, IConvertible, IComparable, IComparable<Decimal>, IEquatable <Decimal>
#if NET_4_0
		, IDeserializationCallback
#endif
	{
		public const decimal MinValue = -79228162514264337593543950335m;
		public const decimal MaxValue =  79228162514264337593543950335m;

		public const decimal MinusOne = -1m;
		public const decimal One = 1m;
		public const decimal Zero = 0m;

        private static readonly decimal _0x8000000000000000 = FromInvariantString("9223372036854775808"); //(decimal)0x8000000000000000UL;
	    private static readonly decimal Scale32Bit = ((long) uint.MaxValue) + 1;

        private const uint MaxScale = 28;
        private const uint SignFlag = 0x80000000;
        private const int ScaleShift = 16;
        private const uint ReservedSs32Bits = 0x7F00FFFF;



        private readonly BigDecimal _val;

        public Decimal (int lo, int mid, int hi, bool isNegative, byte scale)
		{
			_val = FromValues(lo, mid, hi, isNegative, scale);
		}

	    public Decimal (int value) 
		{
			unchecked 
			{
				_val = new BigDecimal(value);
			}
		}

        // Note: Roslyn compiler requires this overload.
        //       it will never be called, but redirected by the dot42 compiler.
        [CLSCompliant(false)]
        [DexNative]
        public Decimal (uint value)
        {
            //_val = new BigDecimal((long)value);

            var ensureImplicitOpIncluded = (decimal)value; // make sure the implicit operator is included
            throw new NotImplementedException(); // but see implicit operator below.
		}

		public Decimal (long value) 
		{
            _val = new BigDecimal(value);
		}

        // Note: Roslyn compiler requires this overload.
        //       it will never be called, but redirected by the dot42 compiler.
        [CLSCompliant(false)]
        [DexNative]
		public Decimal (ulong value) 
		{
            var ensureImplicitOpIncluded = (decimal)value; // make sure the implicit operator is included
			throw new NotImplementedException(); // but see implicit operator below.
		}

        public Decimal (float value)
        {
            var str = value.ToString("R", CultureInfo.InvariantCulture);
            _val = new BigDecimal(str);
        }

	    public Decimal (double value)
	    {
            var str = value.ToString("R", CultureInfo.InvariantCulture);
            _val = new BigDecimal(str);
            //_val = new BigDecimal(value);
	    }

	    public Decimal(BigDecimal value)
        {
            _val = value;
        }

        public Decimal(int[] bits)
        {
            if (bits == null)
            {
                throw new ArgumentNullException("bits is a null reference");
            }

            if (bits.Length != 4)
            {
                throw new ArgumentException("bits does not contain four values");
            }

            unchecked
            {
                int lo = bits[0];
                int mid = bits[1];
                int hi = bits[2];
                int flags = bits[3];
                byte scale = (byte)(flags >> ScaleShift);
                if (scale > MaxScale || (flags & ReservedSs32Bits) != 0)
                {
                    throw new ArgumentException("Invalid bits[3]");
                }
                _val = FromValues(lo, mid, hi, (flags & SignFlag) != 0, scale);
            }
        }

        //public static decimal FromOACurrency (long cy)
        //{
        //    return (decimal)cy / (decimal)10000;
        //}

        public static int[] GetBits(Decimal d)
        {
            unchecked
            {
                if(d._val == null)
                    return new int[] { 0, 0, 0, 0 };
                throw new NotImplementedException();
                
                //uint lo = d.To
                //return new int[] { (int)d.lo, (int)d.mid, (int)d.hi, (int)d.flags };
            }
        }

        private BigDecimal Val { get { return _val ?? new BigDecimal(0); } }

		public static Decimal Negate (Decimal d) 
		{
            return d._val == null? null : d.Val.Negate(MathContext.DECIMAL128);
		}

		public static Decimal Add (Decimal d1, Decimal d2)
		{
		    return d1._val == null? d2._val : d1.Val.Add(d2.Val, MathContext.DECIMAL128);
        }

		public static Decimal Subtract (Decimal d1, Decimal d2) 
		{
            return d1._val == null? d2.Val.Negate() : d1.Val.Subtract(d2.Val, MathContext.DECIMAL128);
		}

		public override int GetHashCode ()
		{
		    return Val.GetHashCode();
		}

		public static Decimal operator + (Decimal d1, Decimal d2)
		{
			return Add (d1, d2);
		}

		public static Decimal operator -- (Decimal d) 
		{
			return Add(d, MinusOne);
		}

		public static Decimal operator ++ (Decimal d) 
		{
			return Add (d, One);
		}

		public static Decimal operator - (Decimal d1, Decimal d2) 
		{
			return Subtract (d1, d2);
		}

		public static Decimal operator - (Decimal d) 
		{
			return Negate (d);
		}

		public static Decimal operator + (Decimal d) 
		{
			return d;
		}

		public static Decimal operator * (Decimal d1, Decimal d2)
		{
			return Multiply (d1, d2);
		}
		
		public static Decimal operator / (Decimal d1, Decimal d2) 
		{
			return Divide (d1, d2);
		}
		
		public static Decimal operator % (Decimal d1, Decimal d2) 
		{
			return Remainder (d1, d2);
		}

		public static explicit operator byte (Decimal value)
		{
			return checked (value.Val.ByteValueExact());
		}

		[CLSCompliant (false)]
		public static explicit operator sbyte (Decimal value)
		{
            return checked((sbyte)value.Val.IntValue());
		}

		public static explicit operator char (Decimal value) 
		{
            return checked((char)value.Val.IntValue());
		}

		public static explicit operator short (Decimal value) 
		{
            return value.Val.ShortValueExact();
		}

		[CLSCompliant (false)]
		public static explicit operator ushort (Decimal value) 
		{
            return checked((ushort)value.Val.IntValue());
		}

		public static explicit operator int (Decimal value) 
		{
            return checked(value.Val.IntValue());
		}

		[CLSCompliant(false)]
		public static explicit operator uint (Decimal value) 
		{
            return checked((uint)value.Val.LongValue());
		}

		public static explicit operator long (Decimal value) 
		{
            return checked(value.Val.LongValue());
		}

		[CLSCompliant(false)]
		public static explicit operator ulong (Decimal value) 
		{
            return checked((ulong)value.Val.LongValue());
		}

		public static implicit operator Decimal (byte value) 
		{
			return new Decimal ((int)value);
		}

		[CLSCompliant(false)]
		public static implicit operator Decimal (sbyte value) 
		{
            return new Decimal((int)value);
		}

		public static implicit operator Decimal (short value) 
		{
            return new Decimal((int)value);
		}

		[CLSCompliant(false)]
		public static implicit operator Decimal (ushort value) 
		{
            return new Decimal((int)value);
		}

		public static implicit operator Decimal (char value) 
		{
            return new Decimal((int)value);
		}

		public static implicit operator Decimal (int value) 
		{
			return new Decimal (value);
		}

		[CLSCompliant(false)]
        [Include] // include, as the constructor-redirection code depends on this. This should better be handled somewhere else.
		public static implicit operator Decimal (uint value) 
		{
			return new Decimal ((long)value);
		}

		public static implicit operator Decimal (long value) 
		{
			return new Decimal (value);
		}

		[CLSCompliant(false)]
        [Include] // include, as the constructor-redirection code depends on this. This should better be handled somewhere else.
        public static implicit operator Decimal (ulong value)
		{
		    unchecked
		    {
		        ulong valWithoutHighestBit = (value & ~0x8000000000000000UL);

                if(valWithoutHighestBit == value)
                    return new Decimal((long) value);

                // add value for highest bit to the value with removed highest bit.
                return new Decimal((long)valWithoutHighestBit) + _0x8000000000000000; 
		    }
		}

		public static explicit operator Decimal (float value) 
		{
			return new Decimal (value);
		}

		public static explicit operator Decimal (double value)
		{
			return new Decimal (value);
		}

		public static explicit operator float (Decimal value)
		{
			return (float) (double) value;
		}

		public static explicit operator double (Decimal value)
		{
			return value.Val.DoubleValue();
		}

		public static bool operator != (Decimal d1, Decimal d2) 
		{
			return !Equals (d1, d2);
		}

		public static bool operator == (Decimal d1, Decimal d2) 
		{
			return Equals (d1, d2);
		}

		public static bool operator > (Decimal d1, Decimal d2) 
		{
			return Compare (d1, d2) > 0;
		}

		public static bool operator >= (Decimal d1, Decimal d2) 
		{
			return Compare (d1, d2) >= 0;
		}

		public static bool operator < (Decimal d1, Decimal d2) 
		{
			return Compare (d1, d2) < 0;
		}

		public static bool operator <= (Decimal d1, Decimal d2) 
		{
			return Compare (d1, d2) <= 0;
		}

		public static bool Equals (Decimal d1, Decimal d2) 
		{
			return d1.Val.CompareTo(d2.Val) == 0;
		}

		public override bool Equals (object value) 
		{
			if (!(value is Decimal))
				return false;

			return Equals ((Decimal) value, this);
		}

		public static Decimal Floor (Decimal d) 
		{
            return d.Val.SetScale(0, RoundingMode.FLOOR);
		}

		public static Decimal Truncate (Decimal d)
		{
		    return d.Val.SetScale(0, RoundingMode.DOWN);
			
		}

		public static Decimal Round (Decimal d, int decimals) 
		{
			return Round (d, decimals, MidpointRounding.ToEven);
		}

		public static Decimal Round (Decimal d, int decimals, MidpointRounding mode) 
		{
            var roundMode = mode == MidpointRounding.ToEven ? RoundingMode.HALF_EVEN
                                                            : RoundingMode.DOWN;
            return d.Val.SetScale(decimals, roundMode);
		}

		public static Decimal Round (Decimal d)
		{
		    return d.Val.SetScale(0, RoundingMode.HALF_EVEN);
		}

		public static Decimal Round (Decimal d, MidpointRounding mode)
		{
		    var mathContext = mode == MidpointRounding.ToEven?new MathContext(0, RoundingMode.HALF_EVEN)
                                                             :new MathContext(0, RoundingMode.DOWN);
		    return d.Val.Round(mathContext);
		}

		public static Decimal Multiply (Decimal d1, Decimal d2)
		{
		    return d1.Val.Multiply(d2.Val, MathContext.DECIMAL128);
		}

		public static Decimal Divide (Decimal d1, Decimal d2)
		{
		    return d1.Val.Divide(d2, MathContext.DECIMAL128);
		}

		public static Decimal Remainder (Decimal d1, Decimal d2)
		{
		    return d1.Val.Remainder(d2.Val);
		}

        internal int Sign()
        {
            if (_val == null) return 0;
            return _val.Signum();
        }

        internal decimal Abs()
        {
            if (_val == null) return this;
            return _val.Abs();
        }


		//[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
		public static int Compare (Decimal d1, Decimal d2)
		{
		    return d1.Val.CompareTo(d2.Val);
		}

		public int CompareTo (object value)
		{
			if (value == null)
				return 1;

			if (!(value is Decimal))
				throw new ArgumentException ("Value is not a System.Decimal");

			return Compare (this, (Decimal)value);
		}

		public int CompareTo (Decimal value)
		{
			return Compare (this, value);
		}

		public bool Equals (Decimal value) 
		{
			return Equals (value, this);
		}

		public static Decimal Ceiling (Decimal d)
		{
		    if (d._val == null) return d;
		    return d._val.SetScale(0, RoundingMode.CEILING);
		}

		public static Decimal Parse (string s) 
		{
			return Parse (s, NumberStyles.Number, null);
		}

		public static Decimal Parse (string s, NumberStyles style) 
		{
			return Parse (s, style, null);
		}

		public static Decimal Parse (string s, IFormatProvider provider) 
		{
			return Parse (s, NumberStyles.Number, provider);
		}

		static void ThrowAtPos (int pos)
		{
			throw new FormatException (String.Format ("Invalid character at position {0}", pos));
		}

		static void ThrowInvalidExp ()
		{
			throw new FormatException ("Invalid exponent");
		}

		private static string StripStyles (string s, NumberStyles style, NumberFormatInfo nfi, 
		      out int decPos, out bool isNegative, out bool expFlag, out int exp, bool throwex)
		{
			isNegative = false;
			expFlag = false;
			exp = 0;
			decPos = -1;

			bool hasSign = false;
			bool hasOpeningParentheses = false;
			bool hasDecimalPoint = false;
			bool allowedLeadingWhiteSpace = ((style & NumberStyles.AllowLeadingWhite) != 0);
			bool allowedTrailingWhiteSpace = ((style & NumberStyles.AllowTrailingWhite) != 0);
			bool allowedLeadingSign = ((style & NumberStyles.AllowLeadingSign) != 0);
			bool allowedTrailingSign = ((style & NumberStyles.AllowTrailingSign) != 0);
			bool allowedParentheses = ((style & NumberStyles.AllowParentheses) != 0);
			bool allowedThousands = ((style & NumberStyles.AllowThousands) != 0);
			bool allowedDecimalPoint = ((style & NumberStyles.AllowDecimalPoint) != 0);
			bool allowedExponent = ((style & NumberStyles.AllowExponent) != 0);

			/* get rid of currency symbol */
			bool hasCurrency = false;
			if ((style & NumberStyles.AllowCurrencySymbol) != 0)
			{
				int index = s.IndexOf (nfi.CurrencySymbol);
				if (index >= 0) 
				{
					s = s.Remove (index, nfi.CurrencySymbol.Length);
					hasCurrency = true;
				}
			}

			string decimalSep = (hasCurrency) ? nfi.CurrencyDecimalSeparator : nfi.NumberDecimalSeparator;
			string groupSep = (hasCurrency) ? nfi.CurrencyGroupSeparator : nfi.NumberGroupSeparator;
			string negativeSign = nfi.NegativeSign;
			string positiveSign = nfi.PositiveSign;

			// If we don't have a group separator defined, it has the same effect as if it wasn't allowed.
			if (string.IsNullOrEmpty(groupSep)) allowedThousands = false;

			int pos = 0;
			int len = s.Length;

			StringBuilder sb = new StringBuilder (len);

			// leading
			while (pos < len) 
			{
				char ch = s[pos];
				if (Char.IsDigit (ch))
				{
					break; // end of leading
				}
				else if (allowedLeadingWhiteSpace && Char.IsWhiteSpace (ch))
				{
					pos++;
				}
				else if (allowedParentheses && ch == '(' && !hasSign && !hasOpeningParentheses) 
				{
					hasOpeningParentheses = true;
					hasSign = true;
					isNegative = true;
					pos++;
				}
				else if (allowedLeadingSign && !string.IsNullOrEmpty (negativeSign) && ch == negativeSign[0] && !hasSign)
				{
					int slen = negativeSign.Length;
					if (slen == 1 || s.IndexOf (negativeSign, pos, slen) == pos)
					{
						hasSign = true;
						isNegative = true;
						pos += slen;
					}
				}
				else if (allowedLeadingSign && !string.IsNullOrEmpty (positiveSign) && ch == positiveSign[0] && !hasSign)
				{
					int slen = positiveSign.Length;
					if (slen == 1 || s.IndexOf (positiveSign, pos, slen) == pos)
					{
						hasSign = true;
						pos += slen;
					}
				}
				else if (allowedDecimalPoint && ch == decimalSep[0])
				{
					int slen = decimalSep.Length;
					if (slen != 1 && s.IndexOf (decimalSep, pos, slen) != pos) 
					{
						if (throwex)
							ThrowAtPos (pos);
						else
							return null;
					}
					break;
				}
				else
				{
					if (throwex)
						ThrowAtPos (pos);
					else
						return null;
				}
			}

			if (pos == len) {
				if (throwex)
					throw new FormatException ("No digits found");
				else
					return null;
			}

			// digits 
			while (pos < len)
			{
				char ch = s[pos];
				if (Char.IsDigit (ch)) 
				{
					sb.Append(ch);
					pos++;
				}
				else if (allowedThousands && ch == groupSep[0] && ch != decimalSep [0]) 
				{
					int slen = groupSep.Length;
					if (slen != 1 && s.IndexOf(groupSep, pos, slen) != pos) 
					{
						if (throwex)
							ThrowAtPos (pos);
						else
							return null;
					}
					pos += slen;
				}
				else if (allowedDecimalPoint && ch == decimalSep[0] && !hasDecimalPoint)
				{
					int slen = decimalSep.Length;
					if (slen == 1 || s.IndexOf(decimalSep, pos, slen) == pos) 
					{
						decPos = sb.Length;
						hasDecimalPoint = true;
						pos += slen;
					}
				}
				else
				{
					break;
				}
			}

			// exponent
			if (pos < len)
			{
				char ch = s[pos];
				if (allowedExponent && Char.ToUpperInvariant (ch) == 'E')
				{
					expFlag = true;
					pos++;
					if (pos >= len){
						if (throwex)
							ThrowInvalidExp ();
						else
							return null;
					}
					ch = s[pos];
					bool isNegativeExp = false;
					if (!string.IsNullOrEmpty (positiveSign) && ch == positiveSign[0])
					{
						int slen = positiveSign.Length;
						if (slen == 1 || s.IndexOf (positiveSign, pos, slen) == pos)
						{
							pos += slen;
							if (pos >= len) {
								if (throwex)
									ThrowInvalidExp ();
								else
									return null;
							}
						}
					}
					else if (!string.IsNullOrEmpty (negativeSign) && ch == negativeSign[0])
					{
						int slen = negativeSign.Length;
						if (slen == 1 || s.IndexOf (negativeSign, pos, slen) == pos)
						{
							pos += slen;
							if (pos >= len) {
								if (throwex)
									ThrowInvalidExp ();
								else
									return null;
							}
							isNegativeExp = true;
						}
					}
					ch = s[pos];
					if (!Char.IsDigit(ch)) {
						if (throwex)
							ThrowInvalidExp ();
						else
							return null;
					}

					exp = ch - '0';
					pos++;
					while (pos < len && Char.IsDigit (s[pos])) 
					{
						exp *= 10;
						exp += s[pos] - '0';
						pos++;
					}
					if (isNegativeExp) exp *= -1;
				}
			}

			// trailing
			while (pos < len)
			{
				char ch = s[pos];
				if (allowedTrailingWhiteSpace && Char.IsWhiteSpace (ch)) 
				{
					pos++;
				}
				else if (allowedParentheses && ch == ')' && hasOpeningParentheses) 
				{
					hasOpeningParentheses = false;
					pos++;
				}
				else if (allowedTrailingSign && !string.IsNullOrWhiteSpace (negativeSign) && ch == negativeSign[0] && !hasSign)
				{
					int slen = negativeSign.Length;
					if (slen == 1 || s.IndexOf(negativeSign, pos, slen) == pos)
					{
						hasSign = true;
						isNegative = true;
						pos += slen;
					}
				}
				else if (allowedTrailingSign && !string.IsNullOrWhiteSpace (positiveSign) && ch == positiveSign[0] && !hasSign)
				{
					int slen = positiveSign.Length;
					if (slen == 1 || s.IndexOf (positiveSign, pos, slen) == pos)
					{
						hasSign = true;
						pos += slen;
					}
				}
				else
				{
					// trailing zero characters are allowed
					if (ch == 0){
						while (++pos < len && s [pos] == 0)
							;
						if (pos == len)
							break;
					}
					
					if (throwex)
						ThrowAtPos (pos);
					else
						return null;
				}
			}

			if (hasOpeningParentheses) {
				if (throwex)
					throw new FormatException ("Closing Parentheses not found");
				else
					return null;
			}

			if (!hasDecimalPoint)
				decPos = sb.Length;

			return sb.ToString ();
		}

		public static Decimal Parse (string s, NumberStyles style, IFormatProvider provider) 
		{
			if (s == null)
				throw new ArgumentNullException ("s");

			if ((style & NumberStyles.AllowHexSpecifier) != 0)
				throw new ArgumentException ("Decimal.TryParse does not accept AllowHexSpecifier", "style");

			Decimal result;
			PerformParse (s, style, provider, out result, true);
			return result;
		}
	
		public static bool TryParse (string s, out Decimal result)
		{
			if (s == null){
				result = (decimal)0;
				return false;
			}
			return PerformParse (s, NumberStyles.Number, null, out result, false);
		}

		public static bool TryParse (string s, NumberStyles style, IFormatProvider provider, out decimal result)
		{
			if (s == null || (style & NumberStyles.AllowHexSpecifier) != 0){
				result = (decimal)0;
				return false;
			}

			return PerformParse (s, style, provider, out result, false);
		}

		static bool PerformParse (string s, NumberStyles style, IFormatProvider provider, out Decimal res, bool throwex)
		{
		    var nfi = provider.ToNumberFormatInfo();

		    try
		    {
		        int decPos;
		        bool isNegative;
		        bool expFlag;
		        int exp;

		        var stripped = StripStyles(s, style, nfi, out decPos, out isNegative, out expFlag, out exp, throwex);

		        var b = new BigDecimal(stripped)
		            .MovePointLeft(stripped.Length - decPos)
		            .ScaleByPowerOfTen(exp);

		        if (isNegative)
		            b = b.Negate();

		        res = b;
                return true;
		    }
		    catch (Exception)
		    {
                if(throwex)
		            throw;
		        res = default(decimal);
		        return false;
		    }
		}

		public TypeCode GetTypeCode ()
		{
			return TypeCode.Decimal;
		}

		public static byte ToByte (decimal value)
		{
			if (value > Byte.MaxValue || value < Byte.MinValue)
				throw new OverflowException ("Value is greater than Byte.MaxValue or less than Byte.MinValue");

			// return truncated value
			return (byte)(Decimal.Truncate (value));
		}

		public static double ToDouble (decimal d)
		{
			return Convert.ToDouble (d);
		}

		public static short ToInt16 (decimal value)
		{
			if (value > Int16.MaxValue || value < Int16.MinValue)
				throw new OverflowException ("Value is greater than Int16.MaxValue or less than Int16.MinValue");

			// return truncated value
			return (Int16)(Decimal.Truncate (value));
		}

		public static int ToInt32 (decimal d)
		{
			if (d > Int32.MaxValue || d < Int32.MinValue)
				throw new OverflowException ("Value is greater than Int32.MaxValue or less than Int32.MinValue");

			// return truncated value
			return (Int32)(Decimal.Truncate (d));
		}
	
		public static long ToInt64 (decimal d)
		{
			if (d > Int64.MaxValue || d < Int64.MinValue)
				throw new OverflowException ("Value is greater than Int64.MaxValue or less than Int64.MinValue");

			// return truncated value
			return (Int64)(Decimal.Truncate (d));
		}

		public static long ToOACurrency (decimal value)
		{
			return (long) (value * 10000);
		}

		[CLSCompliant(false)]
		public static sbyte ToSByte (decimal value)
		{
			if (value > SByte.MaxValue || value < SByte.MinValue)
				throw new OverflowException ("Value is greater than SByte.MaxValue or less than SByte.MinValue");

			// return truncated value
			return (SByte)(Decimal.Truncate (value));
		}
	
		public static float ToSingle (decimal d)
		{
			return Convert.ToSingle (d);
		}

		[CLSCompliant(false)]
		public static ushort ToUInt16 (decimal value)
		{
			if (value > UInt16.MaxValue || value < UInt16.MinValue)
				throw new OverflowException ("Value is greater than UInt16.MaxValue or less than UInt16.MinValue");

			// return truncated value
			return (UInt16)(Decimal.Truncate (value));
		}

		[CLSCompliant(false)]
		public static uint ToUInt32 (decimal d)
		{
			if (d > UInt32.MaxValue || d < UInt32.MinValue)
				throw new OverflowException ("Value is greater than UInt32.MaxValue or less than UInt32.MinValue");

			// return truncated value
			return (UInt32)(Decimal.Truncate (d));
		}

		[CLSCompliant(false)]
		public static ulong ToUInt64 (decimal d)
		{
			if (d > UInt64.MaxValue || d < UInt64.MinValue)
				throw new OverflowException ("Value is greater than UInt64.MaxValue or less than UInt64.MinValue");

			// return truncated value
			return (UInt64)(Decimal.Truncate (d));
		}

		object IConvertible.ToType (Type targetType, IFormatProvider provider)
		{
			if (targetType == null)
				throw new ArgumentNullException ("targetType");
			return Convert.ToType (this, targetType, provider, false);
		}

		bool IConvertible.ToBoolean (IFormatProvider provider)
		{
			return Convert.ToBoolean (this);
		}

		byte IConvertible.ToByte (IFormatProvider provider)
		{
			return Convert.ToByte (this);
		}

		char IConvertible.ToChar (IFormatProvider provider)
		{
			throw new InvalidCastException ();
		}

		DateTime IConvertible.ToDateTime (IFormatProvider provider)
		{
			throw new InvalidCastException ();
		}

		decimal IConvertible.ToDecimal (IFormatProvider provider)
		{
			return this;
		}

		double IConvertible.ToDouble (IFormatProvider provider)
		{
			return Convert.ToDouble (this);
		}

		short IConvertible.ToInt16 (IFormatProvider provider)
		{
			return Convert.ToInt16 (this);
		}

		int IConvertible.ToInt32 (IFormatProvider provider)
		{
			return Convert.ToInt32 (this);
		}

		long IConvertible.ToInt64 (IFormatProvider provider)
		{
			return Convert.ToInt64 (this);
		}

		sbyte IConvertible.ToSByte (IFormatProvider provider)
		{
			return Convert.ToSByte (this);
		}

		float IConvertible.ToSingle (IFormatProvider provider)
		{
			return Convert.ToSingle (this);
		}

		ushort IConvertible.ToUInt16 (IFormatProvider provider)
		{
			return Convert.ToUInt16 (this);
		}

		uint IConvertible.ToUInt32 (IFormatProvider provider)
		{
			return Convert.ToUInt32 (this);
		}

		ulong IConvertible.ToUInt64 (IFormatProvider provider)
		{
			return Convert.ToUInt64 (this);
		}

		public string ToString (string format, IFormatProvider provider)
		{
		    var ni = provider.ToNumberFormatInfo();

		    string s;

            var val = Val.Abs();

            bool group = false;
            string decimalDigit = ni.NumberDecimalSeparator;
            string groupingDigit = null;
            int[] groupingSize = null;
		    bool covertEToLower = false;
		    char formatChar = 'G';

		    if (string.IsNullOrEmpty(format))
		    {
		        s = val.ToString();
		    }
		    else
		    {
		        formatChar = format[0];
                covertEToLower = !char.IsUpper(formatChar);
                formatChar = char.ToUpperInvariant(formatChar);

		        int len;
		        if (!int.TryParse(format.Substring(1), out len))
		            len = -1;

		        switch (formatChar)
		        {
		            case 'E':
		                s = val.SetScale(len == -1 ? 6 : len, RoundingMode.HALF_UP)
		                    .ToEngineeringString();
		                break;
		            case 'C':
		                s = val.SetScale(len == -1 ? ni.CurrencyDecimalDigits : len, RoundingMode.HALF_UP)
		                    .ToPlainString();
		                group = true;
		                decimalDigit = ni.CurrencyDecimalSeparator;
		                groupingDigit = ni.CurrencyGroupSeparator;
		                groupingSize = ni.CurrencyGroupSizes;
		                break;
		            case 'N':
		                s = val.SetScale(len == -1 ? ni.NumberDecimalDigits : len, RoundingMode.HALF_UP)
		                    .ToPlainString();
		                group = true;
		                decimalDigit = ni.NumberDecimalSeparator;
		                groupingDigit = ni.NumberGroupSeparator;
		                groupingSize = ni.NumberGroupSizes;
		                break;
		            case 'F':
		                s = val.SetScale(len == -1 ? ni.NumberDecimalDigits : len, RoundingMode.HALF_UP)
		                    .ToPlainString();
		                break;
		            case 'G':
		                s = ((len == -1) ? val : val.SetScale(ni.NumberDecimalDigits, RoundingMode.HALF_UP))
		                    .ToString();
		                break;
		            case 'P':
		                s =
		                    val.Multiply(new BigDecimal(100))
		                        .SetScale(len == -1 ? ni.PercentDecimalDigits : len, RoundingMode.HALF_UP)
		                        .ToString();
		                group = true;
		                decimalDigit = ni.PercentDecimalSeparator;
		                groupingDigit = ni.PercentGroupSeparator;
		                groupingSize = ni.PercentGroupSizes;
		                break;
		            default:
                        // TODO: support custom formats.
		                throw new NotImplementedException("format: " + format);
		        }
		    }

            StringBuilder b = new StringBuilder(s.Length + 10);

            if (this < Zero)
                b.Append(ni.NegativeSign);

            if (decimalDigit != ".")
		    {
		        s = s.Replace(".", decimalDigit);
		    }

		    if (group)
		    {
		        // todo: find the decimal separator, split the string and assemble everything again.
		    }

            if (covertEToLower)
		    {
		        s = s.Replace('E', 'e');
		    }

		    b.Append(s);

		    if (formatChar == 'P')
		    {
		        b.Append(" ");
		        b.Append(ni.PercentSymbol);
		    }
		    else if (formatChar == 'C')
		    {
		        b.Append(" ");
		        b.Append(ni.CurrencySymbol);
		    }

		    return b.ToString();
		}

		public override string ToString () 
		{
			return ToString ("G", null);
		}

		public string ToString (string format) 
		{
			return ToString (format, null);
		}

		public string ToString (IFormatProvider provider) 
		{
			return ToString ("G", provider);
		}

        public static implicit operator decimal(BigDecimal d)
	    {
            return new decimal(d);
	    }

        public static implicit operator BigDecimal (decimal d)
        {
            return d.Val;
        }


        private static BigDecimal FromValues(int lo, int mid, int hi, bool isNegative, byte scale)
        {
            BigDecimal d;
            unchecked
            {
                var dlo = new BigDecimal((long)(ulong)lo, MathContext.DECIMAL128);
                var dmid = new BigDecimal((long)(ulong)mid, MathContext.DECIMAL128);
                var dhi = new BigDecimal((long)(ulong)hi, MathContext.DECIMAL128);

                d = dhi.Multiply(Scale32Bit.Val).Add(dmid).Multiply(Scale32Bit.Val).Add(dlo);
                d = d.MovePointLeft((int)scale);

                if (scale > 28)
                    throw new ArgumentOutOfRangeException("scale must be between 0 and 28");

                if (isNegative)
                    d = d.Negate(MathContext.DECIMAL128);
            }
            return d;
        }

        [Include]
	    internal static decimal FromInvariantString(string s)
	    {
	        return new BigDecimal(s);
	    }

	}
}

