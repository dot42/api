// Copyright (C) 2014 dot42
//
// Original filename: Java.Security.Spec.cs
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
namespace Java.Security.Spec
{
		/// <summary>
		/// <para>The key specification of an X.509 encoded key in ASN.1 format. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/X509EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/X509EncodedKeySpec", AccessFlags = 33)]
		public partial class X509EncodedKeySpec : global::Java.Security.Spec.EncodedKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> X509EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public X509EncodedKeySpec(sbyte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> X509EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public X509EncodedKeySpec(byte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public override sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string "X.509". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string GetFormat() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal X509EncodedKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string "X.509". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetFormat(); }
				}

		}

		/// <summary>
		/// <para>An Elliptic Curve with its necessary values. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/EllipticCurve
		/// </java-name>
		[Dot42.DexImport("java/security/spec/EllipticCurve", AccessFlags = 33)]
		public partial class EllipticCurve
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> EllipticCurve </c> with the specified field, coefficients and seed.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V", AccessFlags = 1)]
				public EllipticCurve(global::Java.Security.Spec.IECField field, global::Java.Math.BigInteger a, global::Java.Math.BigInteger b, sbyte[] seed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> EllipticCurve </c> with the specified field, coefficients and seed.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EllipticCurve(global::Java.Security.Spec.IECField field, global::Java.Math.BigInteger a, global::Java.Math.BigInteger b, byte[] seed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> EllipticCurve </c> with the specified field and coefficients.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public EllipticCurve(global::Java.Security.Spec.IECField field, global::Java.Math.BigInteger a, global::Java.Math.BigInteger b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the coefficient <c> a </c> of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the coefficient <c> a </c> of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getA
				/// </java-name>
				[Dot42.DexImport("getA", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetA() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the coefficient <c> b </c> of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the coefficient <c> b </c> of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getB
				/// </java-name>
				[Dot42.DexImport("getB", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetB() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the finite field of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the finite field of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "()Ljava/security/spec/ECField;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.IECField GetField() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IECField);
				}

				/// <summary>
				/// <para>Returns a copy of the seed that was used to generate this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the seed that was used to generate this elliptic curve, or <c> null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSeed() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the seed that was used to generate this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the seed that was used to generate this elliptic curve, or <c> null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetSeed() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns whether the specified object equals to this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this elliptic curve, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hashcode of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EllipticCurve() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the coefficient <c> a </c> of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the coefficient <c> a </c> of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getA
				/// </java-name>
				public global::Java.Math.BigInteger A
				{
				[Dot42.DexImport("getA", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetA(); }
				}

				/// <summary>
				/// <para>Returns the coefficient <c> b </c> of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the coefficient <c> b </c> of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getB
				/// </java-name>
				public global::Java.Math.BigInteger B
				{
				[Dot42.DexImport("getB", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetB(); }
				}

				/// <summary>
				/// <para>Returns the finite field of this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the finite field of this elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				public global::Java.Security.Spec.IECField Field
				{
				[Dot42.DexImport("getField", "()Ljava/security/spec/ECField;", AccessFlags = 1)]
						get{ return GetField(); }
				}

				/// <summary>
				/// <para>Returns a copy of the seed that was used to generate this elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the seed that was used to generate this elliptic curve, or <c> null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getSeed
				/// </java-name>
				public byte[] Seed
				{
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetSeed(); }
				}

		}

		/// <summary>
		/// <para>The parameters specifying a <b>characteristic 2 finite field</b> of an elliptic curve. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECFieldF2m
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECFieldF2m", AccessFlags = 33)]
		public partial class ECFieldF2m : global::Java.Security.Spec.IECField
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ECFieldF2m </c> with <c> 2^m </c> elements with a normal basis.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ECFieldF2m(int m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> ECFieldF2m </c> with <c> 2^m </c> elements with a polynomial basis and the reduction polynomial based on <c> rp </c> . </para><para>The reduction polynomial must be either <b>trinomial</b> or <b>pentanomial</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/math/BigInteger;)V", AccessFlags = 1)]
				public ECFieldF2m(int m, global::Java.Math.BigInteger rp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> ECFieldF2m </c> with <c> 2^m </c> elements with a polynomial basis and the reduction polynomial based on <c> rp </c> . </para><para>The reduction polynomial must be either <b>trinomial</b> or <b>pentanomial</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[I)V", AccessFlags = 1)]
				public ECFieldF2m(int m, int[] rp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the specified object equals to this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this finite field, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the size of this finite field (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of this finite field (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
				public virtual int GetFieldSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the exponent <c> m </c> for this finite field, with <c> 2^m </c> as the number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent <c> m </c> for this finite field </para>
				/// </returns>
				/// <java-name>
				/// getM
				/// </java-name>
				[Dot42.DexImport("getM", "()I", AccessFlags = 1)]
				public virtual int GetM() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a copy of the integer array containing the order of the middle term(s) of the reduction polynomial for a polynomial basis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the integer array containing the order of the middle term(s) of the reduction polynomial for a polynomial basis or <c> null </c> for a normal basis. </para>
				/// </returns>
				/// <java-name>
				/// getMidTermsOfReductionPolynomial
				/// </java-name>
				[Dot42.DexImport("getMidTermsOfReductionPolynomial", "()[I", AccessFlags = 1)]
				public virtual int[] GetMidTermsOfReductionPolynomial() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Returns the base of the reduction polynomial with the n-th bit corresponding to the n-th coefficient of the reduction polynomial for a polynomial basis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base of the reduction polynomial with the n-th bit corresponding to the n-th coefficient of the reduction polynomial for a polynomial basis or <c> null </c> for a normal basis. </para>
				/// </returns>
				/// <java-name>
				/// getReductionPolynomial
				/// </java-name>
				[Dot42.DexImport("getReductionPolynomial", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetReductionPolynomial() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the hashcode value for this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode value for this finite field. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECFieldF2m() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of this finite field (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of this finite field (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				public int FieldSize
				{
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
						get{ return GetFieldSize(); }
				}

				/// <summary>
				/// <para>Returns the exponent <c> m </c> for this finite field, with <c> 2^m </c> as the number of elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent <c> m </c> for this finite field </para>
				/// </returns>
				/// <java-name>
				/// getM
				/// </java-name>
				public int M
				{
				[Dot42.DexImport("getM", "()I", AccessFlags = 1)]
						get{ return GetM(); }
				}

				/// <summary>
				/// <para>Returns a copy of the integer array containing the order of the middle term(s) of the reduction polynomial for a polynomial basis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the integer array containing the order of the middle term(s) of the reduction polynomial for a polynomial basis or <c> null </c> for a normal basis. </para>
				/// </returns>
				/// <java-name>
				/// getMidTermsOfReductionPolynomial
				/// </java-name>
				public int[] MidTermsOfReductionPolynomial
				{
				[Dot42.DexImport("getMidTermsOfReductionPolynomial", "()[I", AccessFlags = 1)]
						get{ return GetMidTermsOfReductionPolynomial(); }
				}

				/// <summary>
				/// <para>Returns the base of the reduction polynomial with the n-th bit corresponding to the n-th coefficient of the reduction polynomial for a polynomial basis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base of the reduction polynomial with the n-th bit corresponding to the n-th coefficient of the reduction polynomial for a polynomial basis or <c> null </c> for a normal basis. </para>
				/// </returns>
				/// <java-name>
				/// getReductionPolynomial
				/// </java-name>
				public global::Java.Math.BigInteger ReductionPolynomial
				{
				[Dot42.DexImport("getReductionPolynomial", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetReductionPolynomial(); }
				}

		}

		/// <summary>
		/// <para>The parameters specifying an Elliptic Curve (EC) public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPublicKeySpec", AccessFlags = 33)]
		public partial class ECPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ECPublicKey </c> with the specified public elliptic curve point and parameter specification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V", AccessFlags = 1)]
				public ECPublicKeySpec(global::Java.Security.Spec.ECPoint w, global::Java.Security.Spec.ECParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the domain parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the domain parameter specification. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECParameterSpec GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECParameterSpec);
				}

				/// <summary>
				/// <para>Returns the public elliptic curve point <c> W </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public elliptic curve point <c> W </c> . </para>
				/// </returns>
				/// <java-name>
				/// getW
				/// </java-name>
				[Dot42.DexImport("getW", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECPoint GetW() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECPoint);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECPublicKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the domain parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the domain parameter specification. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Java.Security.Spec.ECParameterSpec Params
				{
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

				/// <summary>
				/// <para>Returns the public elliptic curve point <c> W </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public elliptic curve point <c> W </c> . </para>
				/// </returns>
				/// <java-name>
				/// getW
				/// </java-name>
				public global::Java.Security.Spec.ECPoint W
				{
				[Dot42.DexImport("getW", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
						get{ return GetW(); }
				}

		}

		/// <summary>
		/// <para>A Point on an Elliptic Curve in barycentric (or affine) coordinates. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECPoint
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPoint", AccessFlags = 33)]
		public partial class ECPoint
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The point on an Elliptic Curve at infinity. </para>        
				/// </summary>
				/// <java-name>
				/// POINT_INFINITY
				/// </java-name>
				[Dot42.DexImport("POINT_INFINITY", "Ljava/security/spec/ECPoint;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.ECPoint POINT_INFINITY;
				/// <summary>
				/// <para>Creates a new point at the specified coordinates.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public ECPoint(global::Java.Math.BigInteger affineX, global::Java.Math.BigInteger affineY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the x-coordinate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the x-coordinate, or <c> null </c> for the infinite point. </para>
				/// </returns>
				/// <java-name>
				/// getAffineX
				/// </java-name>
				[Dot42.DexImport("getAffineX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetAffineX() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the y-coordinate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the y-coordinate, or <c> null </c> fot the infinite point. </para>
				/// </returns>
				/// <java-name>
				/// getAffineY
				/// </java-name>
				[Dot42.DexImport("getAffineY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetAffineY() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns whether the specified object and this elliptic curve point are equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object and this elliptic curve point are equal, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hashcode of this elliptic curve point.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode of this elliptic curve point. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECPoint() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the x-coordinate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the x-coordinate, or <c> null </c> for the infinite point. </para>
				/// </returns>
				/// <java-name>
				/// getAffineX
				/// </java-name>
				public global::Java.Math.BigInteger AffineX
				{
				[Dot42.DexImport("getAffineX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetAffineX(); }
				}

				/// <summary>
				/// <para>Returns the y-coordinate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the y-coordinate, or <c> null </c> fot the infinite point. </para>
				/// </returns>
				/// <java-name>
				/// getAffineY
				/// </java-name>
				public global::Java.Math.BigInteger AffineY
				{
				[Dot42.DexImport("getAffineY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetAffineY(); }
				}

		}

		/// <summary>
		/// <para>The marker interface for algorithm parameter specifications. The purpose is to group parameter specifications for algorithms. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/AlgorithmParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/AlgorithmParameterSpec", AccessFlags = 1537)]
		public partial interface IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>The parameter specification used with Elliptic Curve Cryptography (ECC). </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECParameterSpec", AccessFlags = 33)]
		public partial class ECParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ECParameterSpec </c> with the specified elliptic curve, the base point, the order of the generator (or base point) and the co-factor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInte" +
    "ger;I)V", AccessFlags = 1)]
				public ECParameterSpec(global::Java.Security.Spec.EllipticCurve curve, global::Java.Security.Spec.ECPoint generator, global::Java.Math.BigInteger order, int cofactor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> cofactor </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> cofactor </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCofactor
				/// </java-name>
				[Dot42.DexImport("getCofactor", "()I", AccessFlags = 1)]
				public virtual int GetCofactor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getCurve
				/// </java-name>
				[Dot42.DexImport("getCurve", "()Ljava/security/spec/EllipticCurve;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.EllipticCurve GetCurve() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.EllipticCurve);
				}

				/// <summary>
				/// <para>Returns the generator (or base point).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generator (or base point). </para>
				/// </returns>
				/// <java-name>
				/// getGenerator
				/// </java-name>
				[Dot42.DexImport("getGenerator", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECPoint GetGenerator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECPoint);
				}

				/// <summary>
				/// <para>Returns the order of the generator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the order of the generator. </para>
				/// </returns>
				/// <java-name>
				/// getOrder
				/// </java-name>
				[Dot42.DexImport("getOrder", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetOrder() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <c> cofactor </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> cofactor </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCofactor
				/// </java-name>
				public int Cofactor
				{
				[Dot42.DexImport("getCofactor", "()I", AccessFlags = 1)]
						get{ return GetCofactor(); }
				}

				/// <summary>
				/// <para>Returns the elliptic curve.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the elliptic curve. </para>
				/// </returns>
				/// <java-name>
				/// getCurve
				/// </java-name>
				public global::Java.Security.Spec.EllipticCurve Curve
				{
				[Dot42.DexImport("getCurve", "()Ljava/security/spec/EllipticCurve;", AccessFlags = 1)]
						get{ return GetCurve(); }
				}

				/// <summary>
				/// <para>Returns the generator (or base point).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generator (or base point). </para>
				/// </returns>
				/// <java-name>
				/// getGenerator
				/// </java-name>
				public global::Java.Security.Spec.ECPoint Generator
				{
				[Dot42.DexImport("getGenerator", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
						get{ return GetGenerator(); }
				}

				/// <summary>
				/// <para>Returns the order of the generator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the order of the generator. </para>
				/// </returns>
				/// <java-name>
				/// getOrder
				/// </java-name>
				public global::Java.Math.BigInteger Order
				{
				[Dot42.DexImport("getOrder", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetOrder(); }
				}

		}

		/// <summary>
		/// <para>The key specification of a RSA public key. </para><para>Defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPublicKeySpec", AccessFlags = 33)]
		public partial class RSAPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> RSAPublicKeySpec </c> with the specified modulus and public exponent.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAPublicKeySpec(global::Java.Math.BigInteger modulus, global::Java.Math.BigInteger publicExponent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the modulus <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modulus <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getModulus
				/// </java-name>
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetModulus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the public exponent <c> d </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> d </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAPublicKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the modulus <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modulus <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getModulus
				/// </java-name>
				public global::Java.Math.BigInteger Modulus
				{
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetModulus(); }
				}

				/// <summary>
				/// <para>Returns the public exponent <c> d </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> d </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <summary>
		/// <para>The abstract key specification for a public or a private key in encoded format. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/EncodedKeySpec", AccessFlags = 1057)]
		public abstract partial class EncodedKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public EncodedKeySpec(sbyte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncodedKeySpec(byte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the encoding format of this encoded key specification. </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetFormat() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EncodedKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the encoding format of this encoded key specification. </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetFormat(); }
				}

		}

		/// <summary>
		/// <para>The key specification of a RSA private key. </para><para>Defined in the  standard </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPrivateKeySpec", AccessFlags = 33)]
		public partial class RSAPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> RSAPrivateKeySpec </c> with the specified modulus and private exponent.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAPrivateKeySpec(global::Java.Math.BigInteger modulus, global::Java.Math.BigInteger privateExponent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the modulus <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modulus <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getModulus
				/// </java-name>
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetModulus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the private exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrivateExponent
				/// </java-name>
				[Dot42.DexImport("getPrivateExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrivateExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAPrivateKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the modulus <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modulus <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getModulus
				/// </java-name>
				public global::Java.Math.BigInteger Modulus
				{
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetModulus(); }
				}

				/// <summary>
				/// <para>Returns the private exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrivateExponent
				/// </java-name>
				public global::Java.Math.BigInteger PrivateExponent
				{
				[Dot42.DexImport("getPrivateExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrivateExponent(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an invalid key specification is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/InvalidKeySpecException
		/// </java-name>
		[Dot42.DexImport("java/security/spec/InvalidKeySpecException", AccessFlags = 33)]
		public partial class InvalidKeySpecException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidKeySpecException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> InvalidKeySpecException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidKeySpecException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> InvalidKeySpecException </c> with the specified message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeySpecException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeySpecException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The base interface for a Finite Field of an Elliptic Curve. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECField
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECField", AccessFlags = 1537)]
		public partial interface IECField
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the size of the field (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the field (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1025)]
				int GetFieldSize() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The additional prime information specified as triplet of primes, a prime exponent, and a Chinese Remainder Theorem (CRT) coefficient. </para><para>Defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAOtherPrimeInfo
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAOtherPrimeInfo", AccessFlags = 33)]
		public partial class RSAOtherPrimeInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> RSAOtherPrimeInfo </c> with the specified prime, exponent, and CRT coefficient.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAOtherPrimeInfo(global::Java.Math.BigInteger prime, global::Java.Math.BigInteger primeExponent, global::Java.Math.BigInteger crtCoefficient) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient. </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 17)]
				public global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime factor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor. </para>
				/// </returns>
				/// <java-name>
				/// getPrime
				/// </java-name>
				[Dot42.DexImport("getPrime", "()Ljava/math/BigInteger;", AccessFlags = 17)]
				public global::Java.Math.BigInteger GetPrime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the exponent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent. </para>
				/// </returns>
				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "()Ljava/math/BigInteger;", AccessFlags = 17)]
				public global::Java.Math.BigInteger GetExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAOtherPrimeInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient. </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetCrtCoefficient(); }
				}

				/// <summary>
				/// <para>Returns the prime factor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor. </para>
				/// </returns>
				/// <java-name>
				/// getPrime
				/// </java-name>
				public global::Java.Math.BigInteger Prime
				{
				[Dot42.DexImport("getPrime", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetPrime(); }
				}

				/// <summary>
				/// <para>Returns the exponent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent. </para>
				/// </returns>
				/// <java-name>
				/// getExponent
				/// </java-name>
				public global::Java.Math.BigInteger Exponent
				{
				[Dot42.DexImport("getExponent", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetExponent(); }
				}

		}

		/// <summary>
		/// <para>The key specification of a RSA multi-prime private key with the Chinese Remainder Theorem (CRT) information values used. </para><para>Defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAMultiPrimePrivateCrtKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAMultiPrimePrivateCrtKeySpec", AccessFlags = 33)]
		public partial class RSAMultiPrimePrivateCrtKeySpec : global::Java.Security.Spec.RSAPrivateKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> RSAMultiPrimePrivateCrtKeySpec </c> with the specified modulus, public exponent, private exponent, prime factors, prime exponents, crt coefficient, and additional primes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/" +
    "math/BigInteger;[Ljava/security/spec/RSAOtherPrimeInfo;)V", AccessFlags = 1)]
				public RSAMultiPrimePrivateCrtKeySpec(global::Java.Math.BigInteger modulus, global::Java.Math.BigInteger publicExponent, global::Java.Math.BigInteger privateExponent, global::Java.Math.BigInteger primeP, global::Java.Math.BigInteger primeQ, global::Java.Math.BigInteger primeExponentP, global::Java.Math.BigInteger primeExponentQ, global::Java.Math.BigInteger crtCoefficient, global::Java.Security.Spec.RSAOtherPrimeInfo[] otherPrimeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient, <c> q^-1 mod p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the information for the additional primes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the information for the additional primes, or <c> null </c> if there are only the two primes (<c> p, q </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.RSAOtherPrimeInfo[] GetOtherPrimeInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.RSAOtherPrimeInfo[]);
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAMultiPrimePrivateCrtKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient, <c> q^-1 mod p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetCrtCoefficient(); }
				}

				/// <summary>
				/// <para>Returns the information for the additional primes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the information for the additional primes, or <c> null </c> if there are only the two primes (<c> p, q </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				public global::Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
				{
				[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1)]
						get{ return GetOtherPrimeInfo(); }
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentP
				{
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentP(); }
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentQ
				{
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentQ(); }
				}

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeP
				{
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeP(); }
				}

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeQ
				{
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeQ(); }
				}

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <summary>
		/// <para>The parameter specification for generating an RSA key pair. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAKeyGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAKeyGenParameterSpec", AccessFlags = 33)]
		public partial class RSAKeyGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The value of the public exponent <c> F0 </c> = 3. </para>        
				/// </summary>
				/// <java-name>
				/// F0
				/// </java-name>
				[Dot42.DexImport("F0", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger F0;
				/// <summary>
				/// <para>The value of the public exponent <c> F4 </c> = 65537. </para>        
				/// </summary>
				/// <java-name>
				/// F4
				/// </java-name>
				[Dot42.DexImport("F4", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger F4;
				/// <summary>
				/// <para>Creates a new <c> RSAKeyGenParameterSpec </c> with the specified key size and public exponent.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAKeyGenParameterSpec(int keysize, global::Java.Math.BigInteger publicExponent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the modulus (number of bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the modulus (number of bits). </para>
				/// </returns>
				/// <java-name>
				/// getKeysize
				/// </java-name>
				[Dot42.DexImport("getKeysize", "()I", AccessFlags = 1)]
				public virtual int GetKeysize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value of the public exponent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the public exponent. </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAKeyGenParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the modulus (number of bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the modulus (number of bits). </para>
				/// </returns>
				/// <java-name>
				/// getKeysize
				/// </java-name>
				public int Keysize
				{
				[Dot42.DexImport("getKeysize", "()I", AccessFlags = 1)]
						get{ return GetKeysize(); }
				}

				/// <summary>
				/// <para>Returns the value of the public exponent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the public exponent. </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <summary>
		/// <para>The key specification of a RSA private key using Chinese Remainder Theorem (CRT) values. </para><para>Defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/RSAPrivateCrtKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPrivateCrtKeySpec", AccessFlags = 33)]
		public partial class RSAPrivateCrtKeySpec : global::Java.Security.Spec.RSAPrivateKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> RSAMultiPrimePrivateCrtKeySpec </c> with the specified modulus, public exponent, private exponent, prime factors, prime exponents, crt coefficient, and additional primes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/" +
    "math/BigInteger;)V", AccessFlags = 1)]
				public RSAPrivateCrtKeySpec(global::Java.Math.BigInteger modulus, global::Java.Math.BigInteger publicExponent, global::Java.Math.BigInteger privateExponent, global::Java.Math.BigInteger primeP, global::Java.Math.BigInteger primeQ, global::Java.Math.BigInteger primeExponentP, global::Java.Math.BigInteger primeExponentQ, global::Java.Math.BigInteger crtCoefficient) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient, <c> q^-1 mod p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RSAPrivateCrtKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient, <c> q^-1 mod p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetCrtCoefficient(); }
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentP
				{
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentP(); }
				}

				/// <summary>
				/// <para>Returns the exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentQ
				{
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentQ(); }
				}

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeP
				{
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeP(); }
				}

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeQ
				{
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeQ(); }
				}

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <summary>
		/// <para>The parameter specification for the RSA-PSS Signature scheme. </para><para>Defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/PSSParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/PSSParameterSpec", AccessFlags = 33)]
		public partial class PSSParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default parameter specification. It specifies the following parameters: <ul><li><para>message digest: <c> "SHA-1" </c>  </para></li><li><para>mask generation function (<b>mgf</b>): <c> "MGF1" </c>  </para></li><li><para>parameters for the <b>mgf</b>: MGF1ParameterSpec#SHA1 </para></li><li><para>salt length: <c> 20 </c>  </para></li><li><para>trailer field: <c> -1 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Ljava/security/spec/PSSParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.PSSParameterSpec DEFAULT;
				/// <summary>
				/// <para>Creates a new <c> PSSParameterSpec </c> with the specified salt length and the default values.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PSSParameterSpec(int saltLen) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> PSSParameterSpec </c> with the specified message digest name, mask generation function name, mask generation function parameters, salt length, and trailer field value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;I" +
    "I)V", AccessFlags = 1)]
				public PSSParameterSpec(string mdName, string mgfName, global::Java.Security.Spec.IAlgorithmParameterSpec mgfSpec, int saltLen, int trailerField) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the salt (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the salt (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getSaltLength
				/// </java-name>
				[Dot42.DexImport("getSaltLength", "()I", AccessFlags = 1)]
				public virtual int GetSaltLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the message digest algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the message digest algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDigestAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the mask generation function algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMGFAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the parameter for the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter for the mask generation function algorithm, or <c> null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.IAlgorithmParameterSpec GetMGFParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IAlgorithmParameterSpec);
				}

				/// <summary>
				/// <para>Returns the trailer field value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the trailer field value. </para>
				/// </returns>
				/// <java-name>
				/// getTrailerField
				/// </java-name>
				[Dot42.DexImport("getTrailerField", "()I", AccessFlags = 1)]
				public virtual int GetTrailerField() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PSSParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of the salt (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of the salt (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getSaltLength
				/// </java-name>
				public int SaltLength
				{
				[Dot42.DexImport("getSaltLength", "()I", AccessFlags = 1)]
						get{ return GetSaltLength(); }
				}

				/// <summary>
				/// <para>Returns the name of the message digest algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the message digest algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public string DigestAlgorithm
				{
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDigestAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the name of the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the mask generation function algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				public string MGFAlgorithm
				{
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMGFAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the parameter for the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter for the mask generation function algorithm, or <c> null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				public global::Java.Security.Spec.IAlgorithmParameterSpec MGFParameters
				{
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
						get{ return GetMGFParameters(); }
				}

				/// <summary>
				/// <para>Returns the trailer field value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the trailer field value. </para>
				/// </returns>
				/// <java-name>
				/// getTrailerField
				/// </java-name>
				public int TrailerField
				{
				[Dot42.DexImport("getTrailerField", "()I", AccessFlags = 1)]
						get{ return GetTrailerField(); }
				}

		}

		/// <summary>
		/// <para>The marker interface for key specifications. The purpose is to group key specifications for cryptographic keys. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/KeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/KeySpec", AccessFlags = 1537)]
		public partial interface IKeySpec
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>The parameters specifying a DSA public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/DSAPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAPublicKeySpec", AccessFlags = 33)]
		public partial class DSAPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> DSAPublicKeySpec </c> with the specified public key, prime, sub-prime and base.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;)V", AccessFlags = 1)]
				public DSAPublicKeySpec(global::Java.Math.BigInteger y, global::Java.Math.BigInteger p, global::Java.Math.BigInteger q, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the public key value <c> y </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public key value <c> y </c> . </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetY() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DSAPublicKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

				/// <summary>
				/// <para>Returns the public key value <c> y </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public key value <c> y </c> . </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public global::Java.Math.BigInteger Y
				{
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetY(); }
				}

		}

		/// <summary>
		/// <para>The parameters specifying an Elliptic Curve (EC) private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPrivateKeySpec", AccessFlags = 33)]
		public partial class ECPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ECPrivateKeySpec </c> with the specified private value <c> S </c> and parameter specification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V", AccessFlags = 1)]
				public ECPrivateKeySpec(global::Java.Math.BigInteger s, global::Java.Security.Spec.ECParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the domain parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the domain parameter specification. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECParameterSpec GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECParameterSpec);
				}

				/// <summary>
				/// <para>Returns the private value <c> S </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private value <c> S </c> . </para>
				/// </returns>
				/// <java-name>
				/// getS
				/// </java-name>
				[Dot42.DexImport("getS", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetS() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECPrivateKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the domain parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the domain parameter specification. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Java.Security.Spec.ECParameterSpec Params
				{
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

				/// <summary>
				/// <para>Returns the private value <c> S </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private value <c> S </c> . </para>
				/// </returns>
				/// <java-name>
				/// getS
				/// </java-name>
				public global::Java.Math.BigInteger S
				{
				[Dot42.DexImport("getS", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetS(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an invalid parameter specification is encountered. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/InvalidParameterSpecException
		/// </java-name>
		[Dot42.DexImport("java/security/spec/InvalidParameterSpecException", AccessFlags = 33)]
		public partial class InvalidParameterSpecException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> InvalidParameterSpecException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidParameterSpecException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> InvalidParameterSpecException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidParameterSpecException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The parameters specifying a <b>prime finite field</b> of an elliptic curve. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECFieldFp
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECFieldFp", AccessFlags = 33)]
		public partial class ECFieldFp : global::Java.Security.Spec.IECField
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new prime finite field of an elliptic curve with the specified prime <c> p </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public ECFieldFp(global::Java.Math.BigInteger p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the finite field (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the finite field (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
				public virtual int GetFieldSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the prime value <c> p </c> for this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime value <c> p </c> for this finite field. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns whether the specified object is equal to this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this finite field, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hashcode value for this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode value for this finite field. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECFieldFp() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the finite field (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the finite field (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				public int FieldSize
				{
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
						get{ return GetFieldSize(); }
				}

				/// <summary>
				/// <para>Returns the prime value <c> p </c> for this finite field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime value <c> p </c> for this finite field. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

		}

		/// <summary>
		/// <para>The parameter specification used to generate elliptic curve domain parameters. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/ECGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECGenParameterSpec", AccessFlags = 33)]
		public partial class ECGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ECGenParameterSpec </c> with the specified standard or predefined name of the to-be-generated domain parameter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ECGenParameterSpec(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name (standard or predefined) of the to-be-generated elliptic curve domain parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECGenParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name (standard or predefined) of the to-be-generated elliptic curve domain parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

		}

		/// <summary>
		/// <para>The parameters specifying a DSA private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/DSAPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAPrivateKeySpec", AccessFlags = 33)]
		public partial class DSAPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> DSAPrivateKeySpec </c> with the specified private key, prime, sub-prime and base.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;)V", AccessFlags = 1)]
				public DSAPrivateKeySpec(global::Java.Math.BigInteger x, global::Java.Math.BigInteger p, global::Java.Math.BigInteger q, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the private key <c> x </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private key <c> x </c> . </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetX() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DSAPrivateKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

				/// <summary>
				/// <para>Returns the private key <c> x </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private key <c> x </c> . </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public global::Java.Math.BigInteger X
				{
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetX(); }
				}

		}

		/// <summary>
		/// <para>The key specification for an encoded private key in ASN.1 format as defined in the PKCS#8 standard. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/PKCS8EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/PKCS8EncodedKeySpec", AccessFlags = 33)]
		public partial class PKCS8EncodedKeySpec : global::Java.Security.Spec.EncodedKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> PKCS8EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public PKCS8EncodedKeySpec(sbyte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> PKCS8EncodedKeySpec </c> with the specified encoded key bytes.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PKCS8EncodedKeySpec(byte[] encodedKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public override sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string "PKCS#8". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string GetFormat() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PKCS8EncodedKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the encoded key bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the encoded key bytes. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <summary>
				/// <para>Returns the name of the encoding format of this encoded key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string "PKCS#8". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetFormat(); }
				}

		}

		/// <summary>
		/// <para>The parameter specification for the Mask Generation Function (MGF1) in the RSA-PSS Signature and OAEP Padding scheme. </para><para>Defined in the  standard </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/MGF1ParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/MGF1ParameterSpec", AccessFlags = 33)]
		public partial class MGF1ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The predefined MGF1 parameter specification with an "SHA-1" message digest. </para>        
				/// </summary>
				/// <java-name>
				/// SHA1
				/// </java-name>
				[Dot42.DexImport("SHA1", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA1;
				/// <summary>
				/// <para>The predefined MGF1 parameter specification with an "SHA-256" message digest. </para>        
				/// </summary>
				/// <java-name>
				/// SHA256
				/// </java-name>
				[Dot42.DexImport("SHA256", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA256;
				/// <summary>
				/// <para>The predefined MGF1 parameter specification with an "SHA-384" message digest. </para>        
				/// </summary>
				/// <java-name>
				/// SHA384
				/// </java-name>
				[Dot42.DexImport("SHA384", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA384;
				/// <summary>
				/// <para>The predefined MGF1 parameter specification with an "SHA-512" message digest. </para>        
				/// </summary>
				/// <java-name>
				/// SHA512
				/// </java-name>
				[Dot42.DexImport("SHA512", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA512;
				/// <summary>
				/// <para>Creates a new <c> MGF1ParameterSpec </c> with the specified message digest algorithm name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MGF1ParameterSpec(string mdName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the message digest algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the message digest algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDigestAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MGF1ParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the message digest algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the message digest algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public string DigestAlgorithm
				{
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDigestAlgorithm(); }
				}

		}

		/// <summary>
		/// <para>The parameter specification used with the Digital Signature Algorithm (DSA). </para>    
		/// </summary>
		/// <java-name>
		/// java/security/spec/DSAParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAParameterSpec", AccessFlags = 33)]
		public partial class DSAParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec, global::Java.Security.Interfaces.IDSAParams
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> DSAParameterSpec </c> with the specified prime <c> p </c> , sub-prime <c> q </c> and the base <c> g </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DSAParameterSpec(global::Java.Math.BigInteger p, global::Java.Math.BigInteger q, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DSAParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the base <c> g </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base <c> g </c> . </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <summary>
				/// <para>Returns the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the sub-prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sub-prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

		}

}


