// Copyright (C) 2014 dot42
//
// Original filename: Java.Math.cs
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
#pragma warning disable 1717
namespace Java.Math
{
		/// <summary>
		/// <para>This class represents immutable integer numbers of arbitrary length. Large numbers are typically used in security applications and therefore BigIntegers offer dedicated functionality like the generation of large prime numbers or the computation of modular inverse. </para><para>Since the class was modeled to offer all the functionality as the Integer class does, it provides even methods that operate bitwise on a two's complement representation of large integers. Note however that the implementations favors an internal representation where magnitude and sign are treated separately. Hence such operations are inefficient and should be discouraged. In simple words: Do NOT implement any bit fields based on BigInteger. </para>    
		/// </summary>
		/// <java-name>
		/// java/math/BigDecimal
		/// </java-name>
		[Dot42.DexImport("java/math/BigDecimal", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigDecimal;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigDecimal : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigDecimal>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Rounding mode where positive values are rounded towards positive infinity and negative values towards negative infinity.</para><para><para>RoundingMode::UP </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_UP
				/// </java-name>
				[Dot42.DexImport("ROUND_UP", "I", AccessFlags = 25)]
				public const int ROUND_UP = 0;
				/// <summary>
				/// <para>Rounding mode where the values are rounded towards zero.</para><para><para>RoundingMode::DOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_DOWN
				/// </java-name>
				[Dot42.DexImport("ROUND_DOWN", "I", AccessFlags = 25)]
				public const int ROUND_DOWN = 1;
				/// <summary>
				/// <para>Rounding mode to round towards positive infinity. For positive values this rounding mode behaves as ROUND_UP, for negative values as ROUND_DOWN.</para><para><para>RoundingMode::CEILING </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_CEILING
				/// </java-name>
				[Dot42.DexImport("ROUND_CEILING", "I", AccessFlags = 25)]
				public const int ROUND_CEILING = 2;
				/// <summary>
				/// <para>Rounding mode to round towards negative infinity. For positive values this rounding mode behaves as ROUND_DOWN, for negative values as ROUND_UP.</para><para><para>RoundingMode::FLOOR </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_FLOOR
				/// </java-name>
				[Dot42.DexImport("ROUND_FLOOR", "I", AccessFlags = 25)]
				public const int ROUND_FLOOR = 3;
				/// <summary>
				/// <para>Rounding mode where values are rounded towards the nearest neighbor. Ties are broken by rounding up.</para><para><para>RoundingMode::HALF_UP </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_HALF_UP
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_UP", "I", AccessFlags = 25)]
				public const int ROUND_HALF_UP = 4;
				/// <summary>
				/// <para>Rounding mode where values are rounded towards the nearest neighbor. Ties are broken by rounding down.</para><para><para>RoundingMode::HALF_DOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_HALF_DOWN
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_DOWN", "I", AccessFlags = 25)]
				public const int ROUND_HALF_DOWN = 5;
				/// <summary>
				/// <para>Rounding mode where values are rounded towards the nearest neighbor. Ties are broken by rounding to the even neighbor.</para><para><para>RoundingMode::HALF_EVEN </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_HALF_EVEN
				/// </java-name>
				[Dot42.DexImport("ROUND_HALF_EVEN", "I", AccessFlags = 25)]
				public const int ROUND_HALF_EVEN = 6;
				/// <summary>
				/// <para>Rounding mode where the rounding operations throws an <c>       ArithmeticException </c> for the case that rounding is necessary, i.e. for the case that the value cannot be represented exactly.</para><para><para>RoundingMode::UNNECESSARY </para></para>        
				/// </summary>
				/// <java-name>
				/// ROUND_UNNECESSARY
				/// </java-name>
				[Dot42.DexImport("ROUND_UNNECESSARY", "I", AccessFlags = 25)]
				public const int ROUND_UNNECESSARY = 7;
				/// <summary>
				/// <para>The constant zero as a <c> BigDecimal </c> . </para>        
				/// </summary>
				/// <java-name>
				/// ZERO
				/// </java-name>
				[Dot42.DexImport("ZERO", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal ZERO;
				/// <summary>
				/// <para>The constant one as a <c> BigDecimal </c> . </para>        
				/// </summary>
				/// <java-name>
				/// ONE
				/// </java-name>
				[Dot42.DexImport("ONE", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal ONE;
				/// <summary>
				/// <para>The constant ten as a <c> BigDecimal </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TEN
				/// </java-name>
				[Dot42.DexImport("TEN", "Ljava/math/BigDecimal;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigDecimal TEN;
				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from a given unscaled value <c> unscaledVal </c> and a given scale. The value of this instance is <c> unscaledVal </c> 10^(-<c> scale </c> ). The result is rounded according to the specified math context.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public BigDecimal(char[] unscaledVal, int scale, int mc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from a string representation given as a character array.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CIILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(char[] @in, int offset, int len, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public BigDecimal(char[] val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(char[] smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BigDecimal(string val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(string smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public BigDecimal(double val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(DLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(double smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;I)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger smallValue, int scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from a given unscaled value <c> unscaledVal </c> and a given scale. The value of this instance is <c> unscaledVal </c> 10^(-<c> scale </c> ). The result is rounded according to the specified math context.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(global::Java.Math.BigInteger unscaledVal, int scale, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BigDecimal(int val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(int smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> BigDecimal </c> instance from the given big integer <c> val </c> . The scale of the result is <c> 0 </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public BigDecimal(long val) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JLjava/math/MathContext;)V", AccessFlags = 1)]
				public BigDecimal(long smallValue, global::Java.Math.MathContext scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance whose value is equal to <c>       unscaledVal </c> 10^(-<c> scale </c> ). The scale of the result is <c>       scale </c> , and its unscaled value is <c> unscaledVal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> BigDecimal </c> instance with the value <c> unscaledVal </c> * 10^(-<c> unscaledVal </c> ). </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(JI)Ljava/math/BigDecimal;", AccessFlags = 9)]
				public static global::Java.Math.BigDecimal ValueOf(long unscaledVal, int scale) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this + augend </c> . The scale of the result is the maximum of the scales of the two arguments.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this + augend </c> . </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Add(global::Java.Math.BigDecimal augend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this + augend </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this + augend </c> . </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Add(global::Java.Math.BigDecimal augend, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this - subtrahend </c> . The scale of the result is the maximum of the scales of the two arguments.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this - subtrahend </c> . </para>
				/// </returns>
				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Subtract(global::Java.Math.BigDecimal subtrahend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this - subtrahend </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this - subtrahend </c> . </para>
				/// </returns>
				/// <java-name>
				/// subtract
				/// </java-name>
				[Dot42.DexImport("subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Subtract(global::Java.Math.BigDecimal subtrahend, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this *       multiplicand </c> . The scale of the result is the sum of the scales of the two arguments.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this * multiplicand </c> . </para>
				/// </returns>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Multiply(global::Java.Math.BigDecimal multiplicand) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this *       multiplicand </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this * multiplicand </c> . </para>
				/// </returns>
				/// <java-name>
				/// multiply
				/// </java-name>
				[Dot42.DexImport("multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Multiply(global::Java.Math.BigDecimal multiplicand, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . As scale of the result the parameter <c> scale </c> is used. If rounding is required to meet the specified scale, then the specified rounding mode <c> roundingMode </c> is applied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> rounded according to the given rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, int scale, int roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . As scale of the result the parameter <c> scale </c> is used. If rounding is required to meet the specified scale, then the specified rounding mode <c> roundingMode </c> is applied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> rounded according to the given rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, int scale, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . The scale of the result is the scale of <c> this </c> . If rounding is required to meet the specified scale, then the specified rounding mode <c> roundingMode </c> is applied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> rounded according to the given rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, int roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . The scale of the result is the scale of <c> this </c> . If rounding is required to meet the specified scale, then the specified rounding mode <c> roundingMode </c> is applied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> rounded according to the given rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . The scale of the result is the difference of the scales of <c> this </c> and <c> divisor </c> . If the exact result requires more digits, then the scale is adjusted accordingly. For example, <c> 1/128 = 0.0078125 </c> which has a scale of <c> 7 </c> and precision <c> 5 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this / divisor </c> . The scale of the result is the scale of <c> this </c> . If rounding is required to meet the specified scale, then the specified rounding mode <c> roundingMode </c> is applied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> rounded according to the given rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// divide
				/// </java-name>
				[Dot42.DexImport("divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, global::Java.Math.MathContext roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the integral part of <c> this / divisor </c> . The quotient is rounded down towards zero to the next integer. For example, <c> 0.5/0.2 = 2 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>integral part of <c> this / divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// divideToIntegralValue
				/// </java-name>
				[Dot42.DexImport("divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal DivideToIntegralValue(global::Java.Math.BigDecimal divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the integral part of <c> this / divisor </c> . The quotient is rounded down towards zero to the next integer. The rounding mode passed with the parameter <c> mc </c> is not considered. But if the precision of <c> mc &gt; 0 </c> and the integral part requires more digits, then an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>integral part of <c> this / divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// divideToIntegralValue
				/// </java-name>
				[Dot42.DexImport("divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal DivideToIntegralValue(global::Java.Math.BigDecimal divisor, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this % divisor </c> . </para><para>The remainder is defined as <c> this -       this.divideToIntegralValue(divisor) * divisor </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this % divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Remainder(global::Java.Math.BigDecimal divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this % divisor </c> . </para><para>The remainder is defined as <c> this -       this.divideToIntegralValue(divisor) * divisor </c> . </para><para>The specified rounding mode <c> mc </c> is used for the division only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this % divisor </c> . </para>
				/// </returns>
				/// <java-name>
				/// remainder
				/// </java-name>
				[Dot42.DexImport("remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Remainder(global::Java.Math.BigDecimal divisor, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a <c> BigDecimal </c> array which contains the integral part of <c> this / divisor </c> at index 0 and the remainder <c> this %       divisor </c> at index 1. The quotient is rounded down towards zero to the next integer.</para><para><para>divideToIntegralValue </para><simplesectsep></simplesectsep><para>remainder </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> [this.divideToIntegralValue(divisor),               this.remainder(divisor)] </c> . </para>
				/// </returns>
				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal[] DivideAndRemainder(global::Java.Math.BigDecimal divisor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal[]);
				}

				/// <summary>
				/// <para>Returns a <c> BigDecimal </c> array which contains the integral part of <c> this / divisor </c> at index 0 and the remainder <c> this %       divisor </c> at index 1. The quotient is rounded down towards zero to the next integer. The rounding mode passed with the parameter <c> mc </c> is not considered. But if the precision of <c> mc &gt; 0 </c> and the integral part requires more digits, then an <c> ArithmeticException </c> is thrown.</para><para><para>divideToIntegralValue </para><simplesectsep></simplesectsep><para>remainder </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> [this.divideToIntegralValue(divisor),               this.remainder(divisor)] </c> . </para>
				/// </returns>
				/// <java-name>
				/// divideAndRemainder
				/// </java-name>
				[Dot42.DexImport("divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal[] DivideAndRemainder(global::Java.Math.BigDecimal divisor, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal[]);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this ^ n </c> . The scale of the result is <c> n </c> times the scales of <c> this </c> . </para><para><c> x.pow(0) </c> returns <c> 1 </c> , even if <c> x == 0 </c> . </para><para>Implementation Note: The implementation is based on the ANSI standard X3.274-1996 algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this ^ n </c> . </para>
				/// </returns>
				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Pow(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this ^ n </c> . The result is rounded according to the passed context <c> mc </c> . </para><para>Implementation Note: The implementation is based on the ANSI standard X3.274-1996 algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this ^ n </c> . </para>
				/// </returns>
				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Pow(int n, global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the absolute value of <c> this </c> . The scale of the result is the same as the scale of this.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> abs(this) </c> </para>
				/// </returns>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Abs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the absolute value of <c> this </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> abs(this) </c> </para>
				/// </returns>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Abs(global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the <c> -this </c> . The scale of the result is the same as the scale of this.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> -this </c> </para>
				/// </returns>
				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Negate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is the <c> -this </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> -this </c> </para>
				/// </returns>
				/// <java-name>
				/// negate
				/// </java-name>
				[Dot42.DexImport("negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Negate(global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> +this </c> . The scale of the result is the same as the scale of this.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// plus
				/// </java-name>
				[Dot42.DexImport("plus", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Plus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> +this </c> . The result is rounded according to the passed context <c> mc </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> , rounded </para>
				/// </returns>
				/// <java-name>
				/// plus
				/// </java-name>
				[Dot42.DexImport("plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Plus(global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns the sign of this <c> BigDecimal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> -1 </c> if <c> this &lt; 0 </c> , <c> 0 </c> if <c> this == 0 </c> , <c> 1 </c> if <c> this &gt; 0 </c> . </para>
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
				/// <para>Returns the scale of this <c> BigDecimal </c> . The scale is the number of digits behind the decimal point. The value of this <c> BigDecimal </c> is the unsignedValue * 10^(-scale). If the scale is negative, then this <c> BigDecimal </c> represents a big integer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scale of this <c> BigDecimal </c> . </para>
				/// </returns>
				/// <java-name>
				/// scale
				/// </java-name>
				[Dot42.DexImport("scale", "()I", AccessFlags = 1)]
				public virtual int Scale() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the precision of this <c> BigDecimal </c> . The precision is the number of decimal digits used to represent this decimal. It is equivalent to the number of digits of the unscaled value. The precision of <c> 0 </c> is <c> 1 </c> (independent of the scale).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the precision of this <c> BigDecimal </c> . </para>
				/// </returns>
				/// <java-name>
				/// precision
				/// </java-name>
				[Dot42.DexImport("precision", "()I", AccessFlags = 1)]
				public virtual int Precision() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the unscaled value (mantissa) of this <c> BigDecimal </c> instance as a <c> BigInteger </c> . The unscaled value can be computed as <c>       this </c> 10^(scale).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>unscaled value (this * 10^(scale)). </para>
				/// </returns>
				/// <java-name>
				/// unscaledValue
				/// </java-name>
				[Dot42.DexImport("unscaledValue", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger UnscaledValue() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this </c> , rounded according to the passed context <c> mc </c> . </para><para>If <c> mc.precision = 0 </c> , then no rounding is performed. </para><para>If <c> mc.precision &gt; 0 </c> and <c> mc.roundingMode == UNNECESSARY </c> , then an <c> ArithmeticException </c> is thrown if the result cannot be represented exactly within the given precision.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> rounded according to the passed context. </para>
				/// </returns>
				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Round(global::Java.Math.MathContext mc) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance with the specified scale. </para><para>If the new scale is greater than the old scale, then additional zeros are added to the unscaled value. In this case no rounding is necessary. </para><para>If the new scale is smaller than the old scale, then trailing digits are removed. If these trailing digits are not zero, then the remaining unscaled value has to be rounded. For this rounding operation the specified rounding mode is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> BigDecimal </c> instance with the specified scale. </para>
				/// </returns>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int newScale, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance with the specified scale. </para><para>If the new scale is greater than the old scale, then additional zeros are added to the unscaled value. In this case no rounding is necessary. </para><para>If the new scale is smaller than the old scale, then trailing digits are removed. If these trailing digits are not zero, then the remaining unscaled value has to be rounded. For this rounding operation the specified rounding mode is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> BigDecimal </c> instance with the specified scale. </para>
				/// </returns>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(II)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int newScale, int roundingMode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance with the specified scale. If the new scale is greater than the old scale, then additional zeros are added to the unscaled value. If the new scale is smaller than the old scale, then trailing zeros are removed. If the trailing digits are not zeros then an ArithmeticException is thrown. </para><para>If no exception is thrown, then the following equation holds: <c>       x.setScale(s).compareTo(x) == 0 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> BigDecimal </c> instance with the specified scale. </para>
				/// </returns>
				/// <java-name>
				/// setScale
				/// </java-name>
				[Dot42.DexImport("setScale", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal SetScale(int newScale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance where the decimal point has been moved <c> n </c> places to the left. If <c> n &lt; 0 </c> then the decimal point is moved <c> -n </c> places to the right. </para><para>The result is obtained by changing its scale. If the scale of the result becomes negative, then its precision is increased such that the scale is zero. </para><para>Note, that <c> movePointLeft(0) </c> returns a result which is mathematically equivalent, but which has <c> scale &gt;= 0 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this * 10^(-n </c> ). </para>
				/// </returns>
				/// <java-name>
				/// movePointLeft
				/// </java-name>
				[Dot42.DexImport("movePointLeft", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal MovePointLeft(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance where the decimal point has been moved <c> n </c> places to the right. If <c> n &lt; 0 </c> then the decimal point is moved <c> -n </c> places to the left. </para><para>The result is obtained by changing its scale. If the scale of the result becomes negative, then its precision is increased such that the scale is zero. </para><para>Note, that <c> movePointRight(0) </c> returns a result which is mathematically equivalent, but which has scale &gt;= 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this * 10^n </c> . </para>
				/// </returns>
				/// <java-name>
				/// movePointRight
				/// </java-name>
				[Dot42.DexImport("movePointRight", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal MovePointRight(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> whose value is <c> this </c> 10^<c> n </c> . The scale of the result is <c> this.scale() </c> - <c> n </c> . The precision of the result is the precision of <c> this </c> . </para><para>This method has the same effect as movePointRight, except that the precision is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this * 10^n </c> </para>
				/// </returns>
				/// <java-name>
				/// scaleByPowerOfTen
				/// </java-name>
				[Dot42.DexImport("scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal ScaleByPowerOfTen(int n) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a new <c> BigDecimal </c> instance with the same value as <c>       this </c> but with a unscaled value where the trailing zeros have been removed. If the unscaled value of <c> this </c> has n trailing zeros, then the scale and the precision of the result has been reduced by n.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> BigDecimal </c> instance equivalent to this where the trailing zeros of the unscaled value have been removed. </para>
				/// </returns>
				/// <java-name>
				/// stripTrailingZeros
				/// </java-name>
				[Dot42.DexImport("stripTrailingZeros", "()Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal StripTrailingZeros() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Compares this <c> BigDecimal </c> with <c> val </c> . Returns one of the three values <c> 1 </c> , <c> 0 </c> , or <c> -1 </c> . The method behaves as if <c> this.subtract(val) </c> is computed. If this difference is &gt; 0 then 1 is returned, if the difference is &lt; 0 then -1 is returned, and if the difference is 0 then 0 is returned. This means, that if two decimal instances are compared which are equal in value but differ in scale, then these two instances are considered as equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> 1 </c> if <c> this &gt; val </c> , <c> -1 </c> if <c> this &lt; val </c> , <c> 0 </c> if <c> this == val </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/math/BigDecimal;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Math.BigDecimal val) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if <c> x </c> is a <c> BigDecimal </c> instance and if this instance is equal to this big decimal. Two big decimals are equal if their unscaled value and their scale is equal. For example, 1.0 (10*10^(-1)) is not equal to 1.00 (100*10^(-2)). Similarly, zero instances are not equal if their scale differs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if <c> x </c> is a <c> BigDecimal </c> and <c> this == x </c> . </para>
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
				/// <para>Returns the minimum of this <c> BigDecimal </c> and <c> val </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> min(this, val </c> . </para>
				/// </returns>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Min(global::Java.Math.BigDecimal val) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns the maximum of this <c> BigDecimal </c> and <c> val </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> max(this, val </c> . </para>
				/// </returns>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", AccessFlags = 1)]
				public virtual global::Java.Math.BigDecimal Max(global::Java.Math.BigDecimal val) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigDecimal);
				}

				/// <summary>
				/// <para>Returns a hash code for this <c> BigDecimal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>hash code for <c> this </c> . </para>
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
				/// <para>Returns a canonical string representation of this <c> BigDecimal </c> . If necessary, scientific notation is used. This representation always prints all significant digits of this value. </para><para>If the scale is negative or if <c> scale - precision &gt;= 6 </c> then scientific notation is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation of <c> this </c> in scientific notation if necessary. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string representation of this <c> BigDecimal </c> . This representation always prints all significant digits of this value. </para><para>If the scale is negative or if <c> scale - precision &gt;= 6 </c> then engineering notation is used. Engineering notation is similar to the scientific notation except that the exponent is made to be a multiple of 3 such that the integer part is &gt;= 1 and &lt; 1000.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation of <c> this </c> in engineering notation if necessary. </para>
				/// </returns>
				/// <java-name>
				/// toEngineeringString
				/// </java-name>
				[Dot42.DexImport("toEngineeringString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToEngineeringString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string representation of this <c> BigDecimal </c> . No scientific notation is used. This methods adds zeros where necessary. </para><para>If this string representation is used to create a new instance, this instance is generally not identical to <c> this </c> as the precision changes. </para><para><c> x.equals(new BigDecimal(x.toPlainString()) </c> usually returns <c> false </c> . </para><para><c> x.compareTo(new BigDecimal(x.toPlainString()) </c> returns <c> 0 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation of <c> this </c> without exponent part. </para>
				/// </returns>
				/// <java-name>
				/// toPlainString
				/// </java-name>
				[Dot42.DexImport("toPlainString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPlainString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a big integer instance. A fractional part is discarded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a big integer instance. </para>
				/// </returns>
				/// <java-name>
				/// toBigInteger
				/// </java-name>
				[Dot42.DexImport("toBigInteger", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ToBigInteger() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a big integer instance if it has no fractional part. If this <c> BigDecimal </c> has a fractional part, i.e. if rounding would be necessary, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a big integer value. </para>
				/// </returns>
				/// <java-name>
				/// toBigIntegerExact
				/// </java-name>
				[Dot42.DexImport("toBigIntegerExact", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ToBigIntegerExact() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as an long value. Any fractional part is discarded. If the integral part of <c> this </c> is too big to be represented as an long, then <c> this </c> % 2^64 is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a long value. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public override long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a long value if it has no fractional part and if its value fits to the int range ([-2^{63}..2^{63}-1]). If these conditions are not met, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a long value. </para>
				/// </returns>
				/// <java-name>
				/// longValueExact
				/// </java-name>
				[Dot42.DexImport("longValueExact", "()J", AccessFlags = 1)]
				public virtual long LongValueExact() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as an int value. Any fractional part is discarded. If the integral part of <c> this </c> is too big to be represented as an int, then <c> this </c> % 2^32 is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a int value. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public override int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a int value if it has no fractional part and if its value fits to the int range ([-2^{31}..2^{31}-1]). If these conditions are not met, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a int value. </para>
				/// </returns>
				/// <java-name>
				/// intValueExact
				/// </java-name>
				[Dot42.DexImport("intValueExact", "()I", AccessFlags = 1)]
				public virtual int IntValueExact() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a short value if it has no fractional part and if its value fits to the short range ([-2^{15}..2^{15}-1]). If these conditions are not met, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a short value. </para>
				/// </returns>
				/// <java-name>
				/// shortValueExact
				/// </java-name>
				[Dot42.DexImport("shortValueExact", "()S", AccessFlags = 1)]
				public virtual short ShortValueExact() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a byte value if it has no fractional part and if its value fits to the byte range ([-128..127]). If these conditions are not met, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a byte value. </para>
				/// </returns>
				/// <java-name>
				/// byteValueExact
				/// </java-name>
				[Dot42.DexImport("byteValueExact", "()B", AccessFlags = 1)]
				public virtual sbyte JavaByteValueExact() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a byte value if it has no fractional part and if its value fits to the byte range ([-128..127]). If these conditions are not met, an <c> ArithmeticException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a byte value. </para>
				/// </returns>
				/// <java-name>
				/// byteValueExact
				/// </java-name>
				[Dot42.DexImport("byteValueExact", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte ByteValueExact() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a float value. If <c> this </c> is too big to be represented as an float, then <c> Float.POSITIVE_INFINITY </c> or <c> Float.NEGATIVE_INFINITY </c> is returned. </para><para>Note, that if the unscaled value has more than 24 significant digits, then this decimal cannot be represented exactly in a float variable. In this case the result is rounded. </para><para>For example, if the instance <c> x1 = new BigDecimal("0.1") </c> cannot be represented exactly as a float, and thus <c> x1.equals(new       BigDecimal(x1.folatValue()) </c> returns <c> false </c> for this case. </para><para>Similarly, if the instance <c> new BigDecimal(16777217) </c> is converted to a float, the result is <c> 1.6777216E </c> 7.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a float value. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public override float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns this <c> BigDecimal </c> as a double value. If <c> this </c> is too big to be represented as an float, then <c> Double.POSITIVE_INFINITY </c> or <c> Double.NEGATIVE_INFINITY </c> is returned. </para><para>Note, that if the unscaled value has more than 53 significant digits, then this decimal cannot be represented exactly in a double variable. In this case the result is rounded. </para><para>For example, if the instance <c> x1 = new BigDecimal("0.1") </c> cannot be represented exactly as a double, and thus <c> x1.equals(new       BigDecimal(x1.doubleValue()) </c> returns <c> false </c> for this case. </para><para>Similarly, if the instance <c> new BigDecimal(9007199254740993L) </c> is converted to a double, the result is <c> 9.007199254740992E15 </c> . </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> BigDecimal </c> as a double value. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public override double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the unit in the last place (ULP) of this <c> BigDecimal </c> instance. An ULP is the distance to the nearest big decimal with the same precision. </para><para>The amount of a rounding error in the evaluation of a floating-point operation is often expressed in ULPs. An error of 1 ULP is often seen as a tolerable error. </para><para>For class <c> BigDecimal </c> , the ULP of a number is simply 10^(-scale). </para><para>For example, <c> new BigDecimal(0.1).ulp() </c> returns <c> 1E-55 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>unit in the last place (ULP) of this <c> BigDecimal </c> instance. </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para>An immutable signed integer of arbitrary magnitude.</para><para><h3>Fast Cryptography</h3></para><para>This implementation is efficient for operations traditionally used in cryptography, such as the generation of large prime numbers and computation of the modular inverse.</para><para><h3>Slow Two's Complement Bitwise Operations</h3></para><para>This API includes operations for bitwise operations in two's complement representation. Two's complement is not the internal representation used by this implementation, so such methods may be inefficient. Use java.util.BitSet for high-performance bitwise operations on arbitrarily-large sequences of bits. </para>    
		/// </summary>
		/// <java-name>
		/// java/math/BigInteger
		/// </java-name>
		[Dot42.DexImport("java/math/BigInteger", AccessFlags = 33, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/math/BigInteger;>;Ljava/io/Serializ" +
    "able;")]
		public partial class BigInteger : global::Java.Lang.Number, global::System.IComparable<global::Java.Math.BigInteger>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The <c> BigInteger </c> constant 0. </para>        
				/// </summary>
				/// <java-name>
				/// ZERO
				/// </java-name>
				[Dot42.DexImport("ZERO", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ZERO;
				/// <summary>
				/// <para>The <c> BigInteger </c> constant 1. </para>        
				/// </summary>
				/// <java-name>
				/// ONE
				/// </java-name>
				[Dot42.DexImport("ONE", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger ONE;
				/// <summary>
				/// <para>The <c> BigInteger </c> constant 10. </para>        
				/// </summary>
				/// <java-name>
				/// TEN
				/// </java-name>
				[Dot42.DexImport("TEN", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger TEN;
				/// <summary>
				/// <para>Constructs a random non-negative <c> BigInteger </c> instance in the range <c> [0, pow(2, numBits)-1] </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int numBits, global::System.Random random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a random <c> BigInteger </c> instance in the range <c> [0,       pow(2, bitLength)-1] </c> which is probably prime. The probability that the returned <c> BigInteger </c> is prime is beyond <c> 1 - 1/pow(2, certainty) </c> .</para><para><b>Implementation Note:</b> the <c> Random </c> argument is ignored. This implementation uses OpenSSL's <c> bn_rand </c> as a source of cryptographically strong pseudo-random numbers.</para><para><para> </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/util/Random;)V", AccessFlags = 1)]
				public BigInteger(int bitLength, int certainty, global::System.Random unused) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BigInteger(string bigInt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a random non-negative <c> BigInteger </c> instance in the range <c> [0, pow(2, numBits)-1] </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public BigInteger(string numBits, int random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a random non-negative <c> BigInteger </c> instance in the range <c> [0, pow(2, numBits)-1] </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1)]
				public BigInteger(int numBits, sbyte[] random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a random non-negative <c> BigInteger </c> instance in the range <c> [0, pow(2, numBits)-1] </c> .</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is equal to <c> value </c> . </para>        
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
				/// <para>Returns the two's complement representation of this <c> BigInteger </c> in a byte array. </para>        
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
				/// <para>Returns the two's complement representation of this <c> BigInteger </c> in a byte array. </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is the absolute value of <c>       this </c> . </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is the <c> -this </c> . </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this + value </c> . </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this - value </c> . </para>        
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
				/// <para>Returns the sign of this <c> BigInteger </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> -1 </c> if <c> this &lt; 0 </c> , <c> 0 </c> if <c> this == 0 </c> , <c> 1 </c> if <c> this &gt; 0 </c> . </para>
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this &gt;&gt; n </c> . For negative arguments, the result is also negative. The shift distance may be negative which means that <c> this </c> is shifted left.</para><para><b>Implementation Note:</b> Usage of this method on negative values is not recommended as the current implementation is not efficient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this &gt;&gt; n </c> if <c> n &gt;= 0 </c> ; <c> this &lt;&lt; (-n) </c> otherwise </para>
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this &lt;&lt; n </c> . The result is equivalent to <c> this * pow(2, n) </c> if n &gt;= 0. The shift distance may be negative which means that <c> this </c> is shifted right. The result then corresponds to <c> floor(this / pow(2, -n)) </c> .</para><para><b>Implementation Note:</b> Usage of this method on negative values is not recommended as the current implementation is not efficient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this &lt;&lt; n </c> if <c> n &gt;= 0 </c> ; <c> this &gt;&gt; (-n) </c> . otherwise </para>
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
				/// <para>Returns the length of the value's two's complement representation without leading zeros for positive numbers / without leading ones for negative values.</para><para>The two's complement representation of <c> this </c> will be at least <c> bitLength() + 1 </c> bits long.</para><para>The value will fit into an <c> int </c> if <c> bitLength() &lt; 32 </c> or into a <c> long </c> if <c> bitLength() &lt; 64 </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the minimal two's complement representation for <c> this </c> without the sign bit. </para>
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
				/// <para>Tests whether the bit at position n in <c> this </c> is set. The result is equivalent to <c> this &amp; pow(2, n) != 0 </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> which has the same binary representation as <c> this </c> but with the bit at position n set. The result is equivalent to <c> this | pow(2, n) </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> which has the same binary representation as <c> this </c> but with the bit at position n cleared. The result is equivalent to <c> this &amp; ~pow(2, n) </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> which has the same binary representation as <c> this </c> but with the bit at position n flipped. The result is equivalent to <c> this ^ pow(2, n) </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns the position of the lowest set bit in the two's complement representation of this <c> BigInteger </c> . If all bits are zero (this==0) then -1 is returned as result.</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
				/// </summary>
				/// <java-name>
				/// getLowestSetBit
				/// </java-name>
				[Dot42.DexImport("getLowestSetBit", "()I", AccessFlags = 1)]
				public virtual int GetLowestSetBit() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of bits in the two's complement representation of <c> this </c> which differ from the sign bit. If <c> this </c> is negative, the result is equivalent to the number of bits set in the two's complement representation of <c> -this - 1 </c> .</para><para>Use <c> bitLength(0) </c> to find the length of the binary value in bits.</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> ~this </c> . The result of this operation is <c> -this-1 </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this &amp; value </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this | value </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this ^ value </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this &amp; ~value </c> . Evaluating <c> x.andNot(value) </c> returns the same result as <c>       x.and(value.not()) </c> .</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient.</para><para></para>        
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
				/// <para>Returns this <c> BigInteger </c> as an int value. If <c> this </c> is too big to be represented as an int, then <c> this % (1 &lt;&lt; 32) </c> is returned. </para>        
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
				/// <para>Returns this <c> BigInteger </c> as a long value. If <c> this </c> is too big to be represented as a long, then <c> this % pow(2, 64) </c> is returned. </para>        
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
				/// <para>Returns this <c> BigInteger </c> as a float. If <c> this </c> is too big to be represented as a float, then <c> Float.POSITIVE_INFINITY </c> or <c> Float.NEGATIVE_INFINITY </c> is returned. Note that not all integers in the range <c> [-Float.MAX_VALUE, Float.MAX_VALUE] </c> can be exactly represented as a float. </para>        
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
				/// <para>Returns this <c> BigInteger </c> as a double. If <c> this </c> is too big to be represented as a double, then <c> Double.POSITIVE_INFINITY </c> or <c> Double.NEGATIVE_INFINITY </c> is returned. Note that not all integers in the range <c> [-Double.MAX_VALUE, Double.MAX_VALUE] </c> can be exactly represented as a double. </para>        
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
				/// <para>Compares this <c> BigInteger </c> with <c> value </c> . Returns <c> -1 </c> if <c> this &lt; value </c> , <c> 0 </c> if <c> this == value </c> and <c> 1 </c> if <c> this &gt; value </c> , .</para><para></para>        
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
				/// <para>Returns the minimum of this <c> BigInteger </c> and <c> value </c> .</para><para></para>        
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
				/// <para>Returns the maximum of this <c> BigInteger </c> and <c> value </c> .</para><para></para>        
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
				/// <para>Returns a string representation of this <c> BigInteger </c> in decimal form. </para>        
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
				/// <para>Returns a string containing a string representation of this <c>       BigInteger </c> with base radix. If <c> radix &lt; Character.MIN_RADIX </c> or <c> radix &gt; Character.MAX_RADIX </c> then a decimal representation is returned. The characters of the string representation are generated with method <c> Character.forDigit </c> .</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is greatest common divisor of <c> this </c> and <c> value </c> . If <c> this == 0 </c> and <c>       value == 0 </c> then zero is returned, otherwise the result is positive.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this * value </c> .</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> pow(this, exp) </c> .</para><para></para>        
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
				/// <para>Returns a two element <c> BigInteger </c> array containing <c> this / divisor </c> at index 0 and <c> this % divisor </c> at index 1.</para><para><para>divide </para><simplesectsep></simplesectsep><para>remainder </para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this / divisor </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this / divisor </c> . </para>
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this % divisor </c> . Regarding signs this methods has the same behavior as the % operator on ints: the sign of the remainder is the same as the sign of this.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c> 1/this mod m </c> . The modulus <c> m </c> must be positive. The result is guaranteed to be in the interval <c> [0, m) </c> (0 inclusive, m exclusive). If <c> this </c> is not relatively prime to m, then an exception is thrown.</para><para></para>        
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
				/// <para>Returns a <c> BigInteger </c> whose value is <c>       pow(this, exponent) mod m </c> . The modulus <c> m </c> must be positive. The result is guaranteed to be in the interval <c> [0, m) </c> (0 inclusive, m exclusive). If the exponent is negative, then <c>       pow(this.modInverse(m), -exponent) mod m </c> is computed. The inverse of this only exists if <c> this </c> is relatively prime to m, otherwise an exception is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// modPow
				/// </java-name>
				[Dot42.DexImport("modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger ModPow(global::Java.Math.BigInteger exponent, global::Java.Math.BigInteger m) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns a <c> BigInteger </c> whose value is <c> this mod m </c> . The modulus <c> m </c> must be positive. The result is guaranteed to be in the interval <c> [0, m) </c> (0 inclusive, m exclusive). The behavior of this function is not equivalent to the behavior of the % operator defined for the built-in <c> int </c> 's.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this mod m </c> . </para>
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
				/// <para>Tests whether this <c> BigInteger </c> is probably prime. If <c> true </c> is returned, then this is prime with a probability beyond <c> 1 - 1/pow(2, certainty) </c> . If <c> false </c> is returned, then this is definitely composite. If the argument <c> certainty </c> &lt;= 0, then this method returns true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> , if <c> this </c> is probably prime, <c> false </c> otherwise. </para>
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
				/// <para>Returns the smallest integer x &gt; <c> this </c> which is probably prime as a <c> BigInteger </c> instance. The probability that the returned <c>       BigInteger </c> is prime is beyond <c> 1 - 1/pow(2, 80) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>smallest integer &gt; <c> this </c> which is probably prime. </para>
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
				/// <para>Returns a random positive <c> BigInteger </c> instance in the range <c>       [0, pow(2, bitLength)-1] </c> which is probably prime. The probability that the returned <c> BigInteger </c> is prime is beyond <c>       1 - 1/pow(2, 80) </c> .</para><para><b>Implementation Note:</b> Currently <c> random </c> is ignored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>probably prime random <c> BigInteger </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// probablePrime
				/// </java-name>
				[Dot42.DexImport("probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;", AccessFlags = 9)]
				public static global::Java.Math.BigInteger ProbablePrime(int bitLength, global::System.Random unused) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BigInteger() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the position of the lowest set bit in the two's complement representation of this <c> BigInteger </c> . If all bits are zero (this==0) then -1 is returned as result.</para><para><b>Implementation Note:</b> Usage of this method is not recommended as the current implementation is not efficient. </para>        
				/// </summary>
				/// <java-name>
				/// getLowestSetBit
				/// </java-name>
				public int LowestSetBit
				{
				[Dot42.DexImport("getLowestSetBit", "()I", AccessFlags = 1)]
						get{ return GetLowestSetBit(); }
				}

		}

		/// <summary>
		/// <para>Immutable objects describing settings such as rounding mode and digit precision for the numerical operations provided by class BigDecimal. </para>    
		/// </summary>
		/// <java-name>
		/// java/math/MathContext
		/// </java-name>
		[Dot42.DexImport("java/math/MathContext", AccessFlags = 49)]
		public sealed partial class MathContext : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A <c> MathContext </c> which corresponds to the  quadruple decimal precision format: 34 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL128
				/// </java-name>
				[Dot42.DexImport("DECIMAL128", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL128;
				/// <summary>
				/// <para>A <c> MathContext </c> which corresponds to the  single decimal precision format: 7 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL32
				/// </java-name>
				[Dot42.DexImport("DECIMAL32", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL32;
				/// <summary>
				/// <para>A <c> MathContext </c> which corresponds to the  double decimal precision format: 16 digit precision and RoundingMode#HALF_EVEN rounding. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL64
				/// </java-name>
				[Dot42.DexImport("DECIMAL64", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext DECIMAL64;
				/// <summary>
				/// <para>A <c> MathContext </c> for unlimited precision with RoundingMode#HALF_UP rounding. </para>        
				/// </summary>
				/// <java-name>
				/// UNLIMITED
				/// </java-name>
				[Dot42.DexImport("UNLIMITED", "Ljava/math/MathContext;", AccessFlags = 25)]
				public static readonly global::Java.Math.MathContext UNLIMITED;
				/// <summary>
				/// <para>Constructs a new <c> MathContext </c> with the specified precision and with the rounding mode HALF_UP. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public MathContext(int precision) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> MathContext </c> with the specified precision and with the specified rounding mode. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/math/RoundingMode;)V", AccessFlags = 1)]
				public MathContext(int precision, global::Java.Math.RoundingMode roundingMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> MathContext </c> with the specified precision and with the rounding mode HALF_UP. If the precision passed is zero, then this implies that the computations have to be performed exact, the rounding mode in this case is irrelevant.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MathContext(string precision) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the precision. The precision is the number of digits used for an operation. Results are rounded to this precision. The precision is guaranteed to be non negative. If the precision is zero, then the computations have to be performed exact, results are not rounded in this case.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
				public int GetPrecision() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the rounding mode. The rounding mode is the strategy to be used to round results. </para><para>The rounding mode is one of RoundingMode#UP, RoundingMode#DOWN, RoundingMode#CEILING, RoundingMode#FLOOR, RoundingMode#HALF_UP, RoundingMode#HALF_DOWN, RoundingMode#HALF_EVEN, or RoundingMode#UNNECESSARY.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
				public global::Java.Math.RoundingMode GetRoundingMode() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.RoundingMode);
				}

				/// <summary>
				/// <para>Returns true if x is a <c> MathContext </c> with the same precision setting and the same rounding mode as this <c> MathContext </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this <c> MathContext </c> instance is equal to the <c> x </c> argument; <c> false </c> otherwise. </para>
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
				/// <para>Returns the hash code for this <c> MathContext </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code for this <c> MathContext </c> . </para>
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
				/// <para>Returns the string representation for this <c> MathContext </c> instance. The string has the form <c>       "precision=&lt;precision&gt; roundingMode=&lt;roundingMode&gt;"</c> where <c> &lt;precision&gt; </c> is an integer describing the number of digits used for operations and <c> &lt;roundingMode&gt; </c> is the string representation of the rounding mode.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representation for this <c> MathContext </c> instance </para>
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
				/// <para>Returns the precision. The precision is the number of digits used for an operation. Results are rounded to this precision. The precision is guaranteed to be non negative. If the precision is zero, then the computations have to be performed exact, results are not rounded in this case.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the precision. </para>
				/// </returns>
				/// <java-name>
				/// getPrecision
				/// </java-name>
				public int Precision
				{
				[Dot42.DexImport("getPrecision", "()I", AccessFlags = 1)]
						get{ return GetPrecision(); }
				}

				/// <summary>
				/// <para>Returns the rounding mode. The rounding mode is the strategy to be used to round results. </para><para>The rounding mode is one of RoundingMode#UP, RoundingMode#DOWN, RoundingMode#CEILING, RoundingMode#FLOOR, RoundingMode#HALF_UP, RoundingMode#HALF_DOWN, RoundingMode#HALF_EVEN, or RoundingMode#UNNECESSARY.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rounding mode. </para>
				/// </returns>
				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public global::Java.Math.RoundingMode RoundingMode
				{
				[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return GetRoundingMode(); }
				}

		}

}


