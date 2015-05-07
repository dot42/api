#pragma warning disable 1717
namespace Java.Math
{
		/// <java-name>
		/// java/math/BigDecimal
		/// </java-name>
		[Dot42.DexImport("java/math/BigDecimal", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigDecimal;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigDecimal : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigDecimal>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ZERO
				/// </java-name>
				[Dot42.DexImport("ZERO", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal ZERO;
				/// <java-name>
				/// ONE
				/// </java-name>
				[Dot42.DexImport("ONE", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal ONE;
				/// <java-name>
				/// TEN
				/// </java-name>
				[Dot42.DexImport("TEN", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal TEN;
				/// <java-name>
				/// ROUND_UP
				/// </java-name>
				[Dot42.DexImport("ROUND_UP", "I", AccessFlags = 25)]
				public const int ROUND_UP = 0;
				/// <java-name>
				/// ROUND_DOWN
				/// </java-name>
				[Dot42.DexImport("ROUND_DOWN", "I", AccessFlags = 25)]
				public const int ROUND_DOWN = 1;
				/// <java-name>
				/// ROUND_CEILING
				/// </java-name>
				[Dot42.DexImport("ROUND_CEILING", "I", AccessFlags = 25)]
				public const int ROUND_CEILING = 2;
				/// <java-name>
				/// ROUND_FLOOR
				/// </java-name>
				[Dot42.DexImport("ROUND_FLOOR", "I", AccessFlags = 25)]
				public const int ROUND_FLOOR = 3;
				/// <java-name>
				/// ROUND_HALF_UP
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_UP", "I", AccessFlags = 25)]
				public const int ROUND_HALF_UP = 4;
				/// <java-name>
				/// ROUND_HALF_DOWN
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_DOWN", "I", AccessFlags = 25)]
				public const int ROUND_HALF_DOWN = 5;
				/// <java-name>
				/// ROUND_HALF_EVEN
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_EVEN", "I", AccessFlags = 25)]
				public const int ROUND_HALF_EVEN = 6;
				/// <java-name>
				/// ROUND_UNNECESSARY
				/// </java-name>
				[Dot42.DexImport("ROUND_UNNECESSARY", "I", AccessFlags = 25)]
				public const int ROUND_UNNECESSARY = 7;
				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public BigDecimal(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CIILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(char[] @char, int int32, int int321, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public BigDecimal(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(char[] @char, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BigDecimal(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(string @string, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public BigDecimal(double @double) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(DLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(double @double, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger bigInteger, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;I)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger bigInteger, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger bigInteger, int int32, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BigDecimal(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(int int32, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public BigDecimal(long int64) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(long int64, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(JI)Ljava/math/BigDecimal;", AccessFlags = 9)]
				public static global::Java.Math.BigDecimal ValueOf(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/math/BigDecimal;", AccessFlags = 9)]
				public static global::Java.Math.BigDecimal ValueOf(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(D)Ljava/math/BigDecimal;", AccessFlags = 9)]
				public static global::Java.Math.BigDecimal ValueOf(double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Add(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Add(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Subtract(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Subtract(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Multiply(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Multiply(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal, int int32, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divideToIntegralValue
				/// </java-name>
				[Dot42.DexImport("divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal DivideToIntegralValue(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divideToIntegralValue
				/// </java-name>
				[Dot42.DexImport("divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal DivideToIntegralValue(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Remainder(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Remainder(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal[] DivideAndRemainder(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal[]);
				}

				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal[] DivideAndRemainder(global::Java.Math.BigDecimal bigDecimal, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal[]);
				}

				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Pow(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Pow(int int32, global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Abs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Abs(global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Negate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Negate(global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// plus
				/// </java-name>
				[Dot42.DexImport("plus", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Plus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// plus
				/// </java-name>
				[Dot42.DexImport("plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Plus(global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "()I", AccessFlags = 1)]
				public virtual int Signum() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "()I", AccessFlags = 1)]
				public virtual int Scale() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// precision
				/// </java-name>
				[Dot42.DexImport("precision", "()I", AccessFlags = 1)]
				public virtual int Precision() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// unscaledValue
				/// </java-name>
				[Dot42.DexImport("unscaledValue", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger UnscaledValue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Round(global::Java.Math.MathContext mathContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int int32, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(II)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// movePointLeft
				/// </java-name>
				[Dot42.DexImport("movePointLeft", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal MovePointLeft(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// movePointRight
				/// </java-name>
				[Dot42.DexImport("movePointRight", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal MovePointRight(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// scaleByPowerOfTen
				/// </java-name>
				[Dot42.DexImport("scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal ScaleByPowerOfTen(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// stripTrailingZeros
				/// </java-name>
				[Dot42.DexImport("stripTrailingZeros", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal StripTrailingZeros() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/math/BigDecimal;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Min(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Max(global::Java.Math.BigDecimal bigDecimal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toEngineeringString
				/// </java-name>
				[Dot42.DexImport("toEngineeringString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToEngineeringString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toPlainString
				/// </java-name>
				[Dot42.DexImport("toPlainString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPlainString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toBigInteger
				/// </java-name>
				[Dot42.DexImport("toBigInteger", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ToBigInteger() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// toBigIntegerExact
				/// </java-name>
				[Dot42.DexImport("toBigIntegerExact", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ToBigIntegerExact() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// longValueExact
				/// </java-name>
				[Dot42.DexImport("longValueExact", "()J", AccessFlags = 1)]
				public virtual long LongValueExact() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValueExact
				/// </java-name>
				[Dot42.DexImport("intValueExact", "()I", AccessFlags = 1)]
				public virtual int IntValueExact() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// shortValueExact
				/// </java-name>
				[Dot42.DexImport("shortValueExact", "()S", AccessFlags = 1)]
				public virtual short ShortValueExact() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// byteValueExact
				/// </java-name>
				[Dot42.DexImport("byteValueExact", "()B", AccessFlags = 1)]
				public virtual sbyte JavaByteValueExact() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// byteValueExact
				/// </java-name>
				[Dot42.DexImport("byteValueExact", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte ByteValueExact() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Ulp() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BigDecimal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An immutable arbitrary-precision signed integer.</para> <para> <h3>Fast Cryptography</h3></para> <para>This implementation is efficient for operations traditionally used in cryptography, such as the generation of large prime numbers and computation of the modular inverse.</para> <para> <h3>Slow Two's Complement Bitwise Operations</h3></para> <para>This API includes operations for bitwise operations in two's complement representation. Two's complement is not the internal representation used by this implementation, so such methods may be inefficient. Use java.util.BitSet for high-performance bitwise operations on arbitrarily-large sequences of bits. </para>    
		/// </summary>
		/// <java-name>
		/// java/math/BigInteger
		/// </java-name>
		[Dot42.DexImport("java/math/BigInteger", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigInteger;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigInteger : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigInteger>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>BigInteger </c> constant 0. </para>        
				/// </summary>
				/// <java-name>
				/// ZERO
				/// </java-name>
				[Dot42.DexImport("ZERO", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ZERO;
				/// <summary>
				///  <para>The <c>BigInteger </c> constant 1. </para>        
				/// </summary>
				/// <java-name>
				/// ONE
				/// </java-name>
				[Dot42.DexImport("ONE", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ONE;
				/// <summary>
				///  <para>The <c>BigInteger </c> constant 10. </para>        
				/// </summary>
				/// <java-name>
				/// TEN
				/// </java-name>
				[Dot42.DexImport("TEN", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger TEN;
				/// <summary>
				///  <para>Constructs a random non-negative <c>BigInteger </c> instance in the range  <c>[0, pow(2, numBits)-1] </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int numBits, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a random <c>BigInteger </c> instance in the range <c> [0,pow(2, bitLength)-1] </c> which is probably prime. The probability that the returned <c>BigInteger </c> is prime is greater than  <c>1 - 1/2&lt;sup&gt;certainty&lt;/sup&gt;) </c> .</para> <para> <b>Note:</b> the <c>Random </c> argument is ignored if  <c>bitLength &gt;= 16 </c> , where this implementation will use OpenSSL's  <c>BN_generate_prime_ex </c> as a source of cryptographically strong pseudo-random numbers.</para> <para> <para> </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int bitLength, int certainty, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BigInteger(string bigInt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a random non-negative <c>BigInteger </c> instance in the range  <c>[0, pow(2, numBits)-1] </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public BigInteger(string numBits, int random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a random non-negative <c>BigInteger </c> instance in the range  <c>[0, pow(2, numBits)-1] </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1)]
				public BigInteger(int numBits, sbyte[] random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a random non-negative <c>BigInteger </c> instance in the range  <c>[0, pow(2, numBits)-1] </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public BigInteger(int numBits, byte[] random) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public BigInteger(sbyte[] bigInt) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public BigInteger(byte[] bigInt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is equal to <c>value </c> . </para>        
				/// </summary>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/math/BigInteger;", AccessFlags = 9)]
				public static global::Java.Math.BigInteger ValueOf(long value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns the two's complement representation of this <c>BigInteger </c> in a byte array. </para>        
				/// </summary>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the two's complement representation of this <c>BigInteger </c> in a byte array. </para>        
				/// </summary>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is the absolute value of <c>this </c> . </para>        
				/// </summary>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Abs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is the <c>-this </c> . </para>        
				/// </summary>
				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Negate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this + value </c> . </para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Add(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this - value </c> . </para>        
				/// </summary>
				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Subtract(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns the sign of this <c>BigInteger </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>-1 </c> if <c>this &lt; 0 </c> , <c>0 </c> if <c>this == 0 </c> ,  <c>1 </c> if <c>this &gt; 0 </c> . </para>
				/// </returns>
				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "()I", AccessFlags = 1)]
				public virtual int Signum() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this &gt;&gt; n </c> . For negative arguments, the result is also negative. The shift distance may be negative which means that <c>this </c> is shifted left.</para> <para> <b>Implementation Note:</b> Usage of this method on negative values is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>this &gt;&gt; n </c> if <c>n &gt;= 0 </c> ; <c>this &lt;&lt; (-n) </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// shiftRight
				/// </java-name>
				[Dot42.DexImport("shiftRight", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ShiftRight(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this &lt;&lt; n </c> . The result is equivalent to <c>this * pow(2, n) </c> if n &gt;= 0. The shift distance may be negative which means that <c>this </c> is shifted right. The result then corresponds to <c>floor(this / pow(2, -n)) </c> .</para> <para> <b>Implementation Note:</b> Usage of this method on negative values is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>this &lt;&lt; n </c> if <c>n &gt;= 0 </c> ; <c>this &gt;&gt; (-n) </c> . otherwise </para>
				/// </returns>
				/// <java-name>
				/// shiftLeft
				/// </java-name>
				[Dot42.DexImport("shiftLeft", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ShiftLeft(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns the length of the value's two's complement representation without leading zeros for positive numbers / without leading ones for negative values.</para> <para>The two's complement representation of <c>this </c> will be at least  <c>bitLength() + 1 </c> bits long.</para> <para>The value will fit into an <c>int </c> if <c>bitLength() &lt; 32 </c> or into a <c>long </c> if <c>bitLength() &lt; 64 </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the length of the minimal two's complement representation for  <c>this </c> without the sign bit. </para>
				/// </returns>
				/// <java-name>
				/// bitLength
				/// </java-name>
				[Dot42.DexImport("bitLength", "()I", AccessFlags = 1)]
				public virtual int BitLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Tests whether the bit at position n in <c>this </c> is set. The result is equivalent to <c>this &amp; pow(2, n) != 0 </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// testBit
				/// </java-name>
				[Dot42.DexImport("testBit", "(I)Z", AccessFlags = 1)]
				public virtual bool TestBit(int n) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> which has the same binary representation as <c>this </c> but with the bit at position n set. The result is equivalent to <c>this | pow(2, n) </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBit
				/// </java-name>
				[Dot42.DexImport("setBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger SetBit(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> which has the same binary representation as <c>this </c> but with the bit at position n cleared. The result is equivalent to <c>this &amp; ~pow(2, n) </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearBit
				/// </java-name>
				[Dot42.DexImport("clearBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ClearBit(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> which has the same binary representation as <c>this </c> but with the bit at position n flipped. The result is equivalent to <c>this ^ pow(2, n) </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flipBit
				/// </java-name>
				[Dot42.DexImport("flipBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger FlipBit(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns the number of bits in the two's complement representation of  <c>this </c> which differ from the sign bit. If <c>this </c> is negative, the result is equivalent to the number of bits set in the two's complement representation of <c>-this - 1 </c> .</para> <para>Use <c>bitLength(0) </c> to find the length of the binary value in bits.</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
				/// </summary>
				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "()I", AccessFlags = 1)]
				public virtual int BitCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>~this </c> . The result of this operation is <c>-this-1 </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
				/// </summary>
				/// <java-name>
				/// not
				/// </java-name>
				[Dot42.DexImport("not", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Not() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this &amp; value </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// and
				/// </java-name>
				[Dot42.DexImport("and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger And(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this | value </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// or
				/// </java-name>
				[Dot42.DexImport("or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Or(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this ^ value </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// xor
				/// </java-name>
				[Dot42.DexImport("xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Xor(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this &amp; ~value </c> . Evaluating <c>x.andNot(value) </c> returns the same result as <c>x.and(value.not()) </c> .</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// andNot
				/// </java-name>
				[Dot42.DexImport("andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger AndNot(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns this <c>BigInteger </c> as an int value. If <c>this </c> is too big to be represented as an int, then <c>this % (1 &lt;&lt; 32) </c> is returned. </para>        
				/// </summary>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns this <c>BigInteger </c> as a long value. If <c>this </c> is too big to be represented as a long, then <c>this % pow(2, 64) </c> is returned. </para>        
				/// </summary>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns this <c>BigInteger </c> as a float. If <c>this </c> is too big to be represented as a float, then <c>Float.POSITIVE_INFINITY </c> or  <c>Float.NEGATIVE_INFINITY </c> is returned. Note that not all integers in the range <c>[-Float.MAX_VALUE, Float.MAX_VALUE] </c> can be exactly represented as a float. </para>        
				/// </summary>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns this <c>BigInteger </c> as a double. If <c>this </c> is too big to be represented as a double, then <c>Double.POSITIVE_INFINITY </c> or  <c>Double.NEGATIVE_INFINITY </c> is returned. Note that not all integers in the range <c>[-Double.MAX_VALUE, Double.MAX_VALUE] </c> can be exactly represented as a double. </para>        
				/// </summary>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Compares this <c>BigInteger </c> with <c>value </c> . Returns <c>-1 </c> if <c>this &lt; value </c> , <c>0 </c> if <c>this == value </c> and <c>1 </c> if <c>this &gt; value </c> , .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/math/BigInteger;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the minimum of this <c>BigInteger </c> and <c>value </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Min(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns the maximum of this <c>BigInteger </c> and <c>value </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Max(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object x) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>BigInteger </c> in decimal form. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a string containing a string representation of this <c>BigInteger </c> with base radix. If <c>radix &lt; Character.MIN_RADIX </c> or  <c>radix &gt; Character.MAX_RADIX </c> then a decimal representation is returned. The characters of the string representation are generated with method <c>Character.forDigit </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int radix) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is greatest common divisor of <c>this </c> and <c>value </c> . If <c>this == 0 </c> and <c>value == 0 </c> then zero is returned, otherwise the result is positive.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// gcd
				/// </java-name>
				[Dot42.DexImport("gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Gcd(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this * value </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Multiply(global::Java.Math.BigInteger value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>pow(this, exp) </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Pow(int exp) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a two element <c>BigInteger </c> array containing  <c>this / divisor </c> at index 0 and <c>this % divisor </c> at index 1.</para> <para> <para>divide </para> <para>remainder </para></para>        
				/// </summary>
				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger[] DivideAndRemainder(global::Java.Math.BigInteger divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger[]);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this / divisor </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>this / divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Divide(global::Java.Math.BigInteger divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this % divisor </c> . Regarding signs this methods has the same behavior as the % operator on ints: the sign of the remainder is the same as the sign of this.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Remainder(global::Java.Math.BigInteger divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>1/this mod m </c> . The modulus <c>m </c> must be positive. The result is guaranteed to be in the interval <c>[0, m) </c> (0 inclusive, m exclusive). If <c>this </c> is not relatively prime to m, then an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// modInverse
				/// </java-name>
				[Dot42.DexImport("modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ModInverse(global::Java.Math.BigInteger m) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>pow(this, exponent) mod modulus </c> . The modulus must be positive. The result is guaranteed to be in the interval <c>[0, modulus) </c> . If the exponent is negative, then  <c>pow(this.modInverse(modulus), -exponent) mod modulus </c> is computed. The inverse of this only exists if <c>this </c> is relatively prime to the modulus, otherwise an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// modPow
				/// </java-name>
				[Dot42.DexImport("modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ModPow(global::Java.Math.BigInteger exponent, global::Java.Math.BigInteger modulus) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a <c>BigInteger </c> whose value is <c>this mod m </c> . The modulus <c>m </c> must be positive. The result is guaranteed to be in the interval <c>[0, m) </c> (0 inclusive, m exclusive). The behavior of this function is not equivalent to the behavior of the % operator defined for the built-in <c>int </c> 's.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>this mod m </c> . </para>
				/// </returns>
				/// <java-name>
				/// mod
				/// </java-name>
				[Dot42.DexImport("mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Mod(global::Java.Math.BigInteger m) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Tests whether this <c>BigInteger </c> is probably prime. If <c>true </c> is returned, then this is prime with a probability greater than  <c>1 - 1/2&lt;sup&gt;certainty&lt;/sup&gt;) </c> . If <c>false </c> is returned, then this is definitely composite. If the argument <c>certainty </c> &lt;= 0, then this method returns true.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> , if <c>this </c> is probably prime, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isProbablePrime
				/// </java-name>
				[Dot42.DexImport("isProbablePrime", "(I)Z", AccessFlags = 1)]
				public virtual bool IsProbablePrime(int certainty) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the smallest integer x &gt; <c>this </c> which is probably prime as a <c>BigInteger </c> instance. The probability that the returned <c>BigInteger </c> is prime is greater than <c>1 - 1/2&lt;sup&gt;100&lt;/sup&gt; </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>smallest integer &gt; <c>this </c> which is probably prime. </para>
				/// </returns>
				/// <java-name>
				/// nextProbablePrime
				/// </java-name>
				[Dot42.DexImport("nextProbablePrime", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger NextProbablePrime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				///  <para>Returns a random positive <c>BigInteger </c> instance in the range <c>[0, pow(2, bitLength)-1] </c> which is probably prime. The probability that the returned <c>BigInteger </c> is prime is greater than <c>1 - 1/2&lt;sup&gt;100&lt;/sup&gt;) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>probably prime random <c>BigInteger </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// probablePrime
				/// </java-name>
				[Dot42.DexImport("probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;", AccessFlags = 9)]
				public static global::Java.Math.BigInteger ProbablePrime(int bitLength, global::System.Random random) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BigInteger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the position of the lowest set bit in the two's complement representation of this <c>BigInteger </c> . If all bits are zero (this==0) then -1 is returned as result.</para> <para> <b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
				/// </summary>
				/// <java-name>
				/// getLowestSetBit
				/// </java-name>
				public virtual int LowestSetBit
				{
						[Dot42.DexImport("getLowestSetBit", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Immutable objects describing settings such as rounding mode and digit precision for the numerical operations provided by class BigDecimal. </para>    
		/// </summary>
		/// <java-name>
		/// java/math/MathContext
		/// </java-name>
		[Dot42.DexImport("java/math/MathContext", AccessFlags = 49)]
		public sealed partial class MathContext : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A <c>MathContext </c> which corresponds to the  quadruple decimal precision format: 34 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL128
				/// </java-name>
				[Dot42.DexImport("DECIMAL128", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL128;
				/// <summary>
				///  <para>A <c>MathContext </c> which corresponds to the  single decimal precision format: 7 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL32
				/// </java-name>
				[Dot42.DexImport("DECIMAL32", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL32;
				/// <summary>
				///  <para>A <c>MathContext </c> which corresponds to the  double decimal precision format: 16 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL64
				/// </java-name>
				[Dot42.DexImport("DECIMAL64", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL64;
				/// <summary>
				///  <para>A <c>MathContext </c> for unlimited precision with RoundingMode#HALF_UP rounding. </para>        
				/// </summary>
				/// <java-name>
				/// UNLIMITED
				/// </java-name>
				[Dot42.DexImport("UNLIMITED", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext UNLIMITED;
				/// <summary>
				///  <para>Constructs a new <c>MathContext </c> with the specified precision and with the rounding mode HALF_UP. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MathContext(int precision) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>MathContext </c> with the specified precision and with the specified rounding mode. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/math/RoundingMode;)V", AccessFlags = 1)]
				public MathContext(int precision, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>MathContext </c> with the specified precision and with the rounding mode HALF_UP. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MathContext(string precision) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if x is a <c>MathContext </c> with the same precision setting and the same rounding mode as this <c>MathContext </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>MathContext </c> instance is equal to the  <c>x </c> argument; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object x) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hash code for this <c>MathContext </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code for this <c>MathContext </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the string representation for this <c>MathContext </c> instance. The string has the form  <c>"precision=&lt;precision&gt; roundingMode=&lt;roundingMode&gt;"</c> where <c>&lt;precision&gt; </c> is an integer describing the number of digits used for operations and <c>&lt;roundingMode&gt; </c> is the string representation of the rounding mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation for this <c>MathContext </c> instance </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MathContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the precision. The precision is the number of digits used for an operation. Results are rounded to this precision. The precision is guaranteed to be non negative. If the precision is zero, then the computations have to be performed exact, results are not rounded in this case.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				public int Precision
				{
						[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the rounding mode. The rounding mode is the strategy to be used to round results. </para> <para>The rounding mode is one of RoundingMode#UP, RoundingMode#DOWN, RoundingMode#CEILING, RoundingMode#FLOOR, RoundingMode#HALF_UP, RoundingMode#HALF_DOWN, RoundingMode#HALF_EVEN, or RoundingMode#UNNECESSARY.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public global::Java.Math.RoundingMode RoundingMode
				{
						[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return default(global::Java.Math.RoundingMode); }
				}

		}

		/// <java-name>
		/// java/math/RoundingMode
		/// </java-name>
		[Dot42.DexImport("java/math/RoundingMode", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Ljava/math/RoundingMode;>;")]
		public sealed class RoundingMode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CEILING
				/// </java-name>
				[Dot42.DexImport("CEILING", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode CEILING;
				/// <java-name>
				/// DOWN
				/// </java-name>
				[Dot42.DexImport("DOWN", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode DOWN;
				/// <java-name>
				/// FLOOR
				/// </java-name>
				[Dot42.DexImport("FLOOR", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode FLOOR;
				/// <java-name>
				/// HALF_DOWN
				/// </java-name>
				[Dot42.DexImport("HALF_DOWN", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode HALF_DOWN;
				/// <java-name>
				/// HALF_EVEN
				/// </java-name>
				[Dot42.DexImport("HALF_EVEN", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode HALF_EVEN;
				/// <java-name>
				/// HALF_UP
				/// </java-name>
				[Dot42.DexImport("HALF_UP", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode HALF_UP;
				/// <java-name>
				/// UNNECESSARY
				/// </java-name>
				[Dot42.DexImport("UNNECESSARY", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode UNNECESSARY;
				/// <java-name>
				/// UP
				/// </java-name>
				[Dot42.DexImport("UP", "Ljava/math/RoundingMode;", AccessFlags = 16409)]
				public static readonly global::Java.Math.RoundingMode UP;
				private RoundingMode() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Ljava/math/RoundingMode;", AccessFlags = 25)]
				public static global::Java.Math.RoundingMode[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;", AccessFlags = 9)]
				public static global::Java.Math.RoundingMode ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Ljava/math/RoundingMode;", AccessFlags = 9)]
				public static global::Java.Math.RoundingMode ValueOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
				}

		}

}

