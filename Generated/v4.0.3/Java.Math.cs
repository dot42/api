#pragma warning disable 1717
namespace Java.Math
{
		/// <java-name>
		/// java/math/BigDecimal
		/// </java-name>
		[Dot42.DexImport("java/math/BigDecimal", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigDecimal;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigDecimal : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigDecimal>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
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

		/// <java-name>
		/// java/math/BigInteger
		/// </java-name>
		[Dot42.DexImport("java/math/BigInteger", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigInteger;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigInteger : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigInteger>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ZERO
				/// </java-name>
				[Dot42.DexImport("ZERO", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ZERO;
				/// <java-name>
				/// ONE
				/// </java-name>
				[Dot42.DexImport("ONE", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ONE;
				/// <java-name>
				/// TEN
				/// </java-name>
				[Dot42.DexImport("TEN", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger TEN;
				[Dot42.DexImport("<init>", "(ILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int int32, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int int32, int int321, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BigInteger(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public BigInteger(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1)]
				public BigInteger(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public BigInteger(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public BigInteger(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public BigInteger(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/math/BigInteger;", AccessFlags = 9)]
				public static global::Java.Math.BigInteger ValueOf(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Abs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Negate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Add(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Subtract(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
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
				/// shiftRight
				/// </java-name>
				[Dot42.DexImport("shiftRight", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ShiftRight(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// shiftLeft
				/// </java-name>
				[Dot42.DexImport("shiftLeft", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ShiftLeft(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// bitLength
				/// </java-name>
				[Dot42.DexImport("bitLength", "()I", AccessFlags = 1)]
				public virtual int BitLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// testBit
				/// </java-name>
				[Dot42.DexImport("testBit", "(I)Z", AccessFlags = 1)]
				public virtual bool TestBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBit
				/// </java-name>
				[Dot42.DexImport("setBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger SetBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// clearBit
				/// </java-name>
				[Dot42.DexImport("clearBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ClearBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// flipBit
				/// </java-name>
				[Dot42.DexImport("flipBit", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger FlipBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getLowestSetBit
				/// </java-name>
				[Dot42.DexImport("getLowestSetBit", "()I", AccessFlags = 1)]
				public virtual int GetLowestSetBit() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "()I", AccessFlags = 1)]
				public virtual int BitCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// not
				/// </java-name>
				[Dot42.DexImport("not", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Not() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// and
				/// </java-name>
				[Dot42.DexImport("and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger And(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// or
				/// </java-name>
				[Dot42.DexImport("or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Or(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// xor
				/// </java-name>
				[Dot42.DexImport("xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Xor(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// andNot
				/// </java-name>
				[Dot42.DexImport("andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger AndNot(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
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
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/math/BigInteger;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Min(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Max(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// gcd
				/// </java-name>
				[Dot42.DexImport("gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Gcd(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Multiply(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(I)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Pow(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger[] DivideAndRemainder(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger[]);
				}

				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Divide(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Remainder(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// modInverse
				/// </java-name>
				[Dot42.DexImport("modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ModInverse(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// modPow
				/// </java-name>
				[Dot42.DexImport("modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ModPow(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// mod
				/// </java-name>
				[Dot42.DexImport("mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger Mod(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// isProbablePrime
				/// </java-name>
				[Dot42.DexImport("isProbablePrime", "(I)Z", AccessFlags = 1)]
				public virtual bool IsProbablePrime(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextProbablePrime
				/// </java-name>
				[Dot42.DexImport("nextProbablePrime", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger NextProbablePrime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// probablePrime
				/// </java-name>
				[Dot42.DexImport("probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;", AccessFlags = 9)]
				public static global::Java.Math.BigInteger ProbablePrime(int int32, global::System.Random random) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BigInteger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLowestSetBit
				/// </java-name>
				public int LowestSetBit
				{
				[Dot42.DexImport("getLowestSetBit", "()I", AccessFlags = 1)]
						get{ return GetLowestSetBit(); }
				}

		}

		/// <java-name>
		/// java/math/MathContext
		/// </java-name>
		[Dot42.DexImport("java/math/MathContext", AccessFlags = 49)]
		public sealed partial class MathContext : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DECIMAL128
				/// </java-name>
				[Dot42.DexImport("DECIMAL128", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL128;
				/// <java-name>
				/// DECIMAL32
				/// </java-name>
				[Dot42.DexImport("DECIMAL32", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL32;
				/// <java-name>
				/// DECIMAL64
				/// </java-name>
				[Dot42.DexImport("DECIMAL64", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL64;
				/// <java-name>
				/// UNLIMITED
				/// </java-name>
				[Dot42.DexImport("UNLIMITED", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext UNLIMITED;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MathContext(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/math/RoundingMode;)V", AccessFlags = 1)]
				public MathContext(int int32, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MathContext(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
				public int GetPrecision() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
				public global::Java.Math.RoundingMode GetRoundingMode() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MathContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrecision
				/// </java-name>
				public int Precision
				{
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
						get{ return GetPrecision(); }
				}

				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public global::Java.Math.RoundingMode RoundingMode
				{
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return GetRoundingMode(); }
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
				[Dot42.DexImport("values", "()[Ljava/math/RoundingMode;", AccessFlags = 9)]
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

