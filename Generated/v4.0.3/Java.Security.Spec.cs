#pragma warning disable 1717
namespace Java.Security.Spec
{
		/// <java-name>
		/// java/security/spec/DSAParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAParameterSpec", AccessFlags = 33)]
		public partial class DSAParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec, global::Java.Security.Interfaces.IDSAParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DSAParameterSpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

		}

		/// <java-name>
		/// java/security/spec/DSAPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAPrivateKeySpec", AccessFlags = 33)]
		public partial class DSAPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;)V", AccessFlags = 1)]
				public DSAPrivateKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public global::Java.Math.BigInteger X
				{
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetX(); }
				}

		}

		/// <java-name>
		/// java/security/spec/DSAPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/DSAPublicKeySpec", AccessFlags = 33)]
		public partial class DSAPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;)V", AccessFlags = 1)]
				public DSAPublicKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				public global::Java.Math.BigInteger Q
				{
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetQ(); }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public global::Java.Math.BigInteger Y
				{
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetY(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECFieldF2m
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECFieldF2m", AccessFlags = 33)]
		public partial class ECFieldF2m : global::Java.Security.Spec.IECField
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ECFieldF2m(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/math/BigInteger;)V", AccessFlags = 1)]
				public ECFieldF2m(int int32, global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[I)V", AccessFlags = 1)]
				public ECFieldF2m(int int32, int[] int321) /* MethodBuilder.Create */ 
				{
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
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
				public virtual int GetFieldSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getM
				/// </java-name>
				[Dot42.DexImport("getM", "()I", AccessFlags = 1)]
				public virtual int GetM() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMidTermsOfReductionPolynomial
				/// </java-name>
				[Dot42.DexImport("getMidTermsOfReductionPolynomial", "()[I", AccessFlags = 1)]
				public virtual int[] GetMidTermsOfReductionPolynomial() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getReductionPolynomial
				/// </java-name>
				[Dot42.DexImport("getReductionPolynomial", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetReductionPolynomial() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECFieldF2m() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFieldSize
				/// </java-name>
				public int FieldSize
				{
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
						get{ return GetFieldSize(); }
				}

				/// <java-name>
				/// getM
				/// </java-name>
				public int M
				{
				[Dot42.DexImport("getM", "()I", AccessFlags = 1)]
						get{ return GetM(); }
				}

				/// <java-name>
				/// getMidTermsOfReductionPolynomial
				/// </java-name>
				public int[] MidTermsOfReductionPolynomial
				{
				[Dot42.DexImport("getMidTermsOfReductionPolynomial", "()[I", AccessFlags = 1)]
						get{ return GetMidTermsOfReductionPolynomial(); }
				}

				/// <java-name>
				/// getReductionPolynomial
				/// </java-name>
				public global::Java.Math.BigInteger ReductionPolynomial
				{
				[Dot42.DexImport("getReductionPolynomial", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetReductionPolynomial(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECFieldFp
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECFieldFp", AccessFlags = 33)]
		public partial class ECFieldFp : global::Java.Security.Spec.IECField
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public ECFieldFp(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
				public virtual int GetFieldSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECFieldFp() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFieldSize
				/// </java-name>
				public int FieldSize
				{
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1)]
						get{ return GetFieldSize(); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECGenParameterSpec", AccessFlags = 33)]
		public partial class ECGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ECGenParameterSpec(string @string) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECParameterSpec", AccessFlags = 33)]
		public partial class ECParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInte" +
    "ger;I)V", AccessFlags = 1)]
				public ECParameterSpec(global::Java.Security.Spec.EllipticCurve ellipticCurve, global::Java.Security.Spec.ECPoint eCPoint, global::Java.Math.BigInteger bigInteger, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCofactor
				/// </java-name>
				[Dot42.DexImport("getCofactor", "()I", AccessFlags = 1)]
				public virtual int GetCofactor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCurve
				/// </java-name>
				[Dot42.DexImport("getCurve", "()Ljava/security/spec/EllipticCurve;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.EllipticCurve GetCurve() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.EllipticCurve);
				}

				/// <java-name>
				/// getGenerator
				/// </java-name>
				[Dot42.DexImport("getGenerator", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECPoint GetGenerator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECPoint);
				}

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

				/// <java-name>
				/// getCofactor
				/// </java-name>
				public int Cofactor
				{
				[Dot42.DexImport("getCofactor", "()I", AccessFlags = 1)]
						get{ return GetCofactor(); }
				}

				/// <java-name>
				/// getCurve
				/// </java-name>
				public global::Java.Security.Spec.EllipticCurve Curve
				{
				[Dot42.DexImport("getCurve", "()Ljava/security/spec/EllipticCurve;", AccessFlags = 1)]
						get{ return GetCurve(); }
				}

				/// <java-name>
				/// getGenerator
				/// </java-name>
				public global::Java.Security.Spec.ECPoint Generator
				{
				[Dot42.DexImport("getGenerator", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
						get{ return GetGenerator(); }
				}

				/// <java-name>
				/// getOrder
				/// </java-name>
				public global::Java.Math.BigInteger Order
				{
				[Dot42.DexImport("getOrder", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetOrder(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECPoint
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPoint", AccessFlags = 33)]
		public partial class ECPoint
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// POINT_INFINITY
				/// </java-name>
				[Dot42.DexImport("POINT_INFINITY", "Ljava/security/spec/ECPoint;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.ECPoint POINT_INFINITY;
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public ECPoint(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAffineX
				/// </java-name>
				[Dot42.DexImport("getAffineX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetAffineX() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getAffineY
				/// </java-name>
				[Dot42.DexImport("getAffineY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetAffineY() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ECPoint() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAffineX
				/// </java-name>
				public global::Java.Math.BigInteger AffineX
				{
				[Dot42.DexImport("getAffineX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetAffineX(); }
				}

				/// <java-name>
				/// getAffineY
				/// </java-name>
				public global::Java.Math.BigInteger AffineY
				{
				[Dot42.DexImport("getAffineY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetAffineY(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPrivateKeySpec", AccessFlags = 33)]
		public partial class ECPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V", AccessFlags = 1)]
				public ECPrivateKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Security.Spec.ECParameterSpec eCParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECParameterSpec GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECParameterSpec);
				}

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

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Java.Security.Spec.ECParameterSpec Params
				{
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

				/// <java-name>
				/// getS
				/// </java-name>
				public global::Java.Math.BigInteger S
				{
				[Dot42.DexImport("getS", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetS(); }
				}

		}

		/// <java-name>
		/// java/security/spec/ECPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECPublicKeySpec", AccessFlags = 33)]
		public partial class ECPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V", AccessFlags = 1)]
				public ECPublicKeySpec(global::Java.Security.Spec.ECPoint eCPoint, global::Java.Security.Spec.ECParameterSpec eCParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.ECParameterSpec GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.ECParameterSpec);
				}

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

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Java.Security.Spec.ECParameterSpec Params
				{
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

				/// <java-name>
				/// getW
				/// </java-name>
				public global::Java.Security.Spec.ECPoint W
				{
				[Dot42.DexImport("getW", "()Ljava/security/spec/ECPoint;", AccessFlags = 1)]
						get{ return GetW(); }
				}

		}

		/// <java-name>
		/// java/security/spec/EllipticCurve
		/// </java-name>
		[Dot42.DexImport("java/security/spec/EllipticCurve", AccessFlags = 33)]
		public partial class EllipticCurve
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V", AccessFlags = 1)]
				public EllipticCurve(global::Java.Security.Spec.IECField eCField, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EllipticCurve(global::Java.Security.Spec.IECField eCField, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public EllipticCurve(global::Java.Security.Spec.IECField eCField, global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getA
				/// </java-name>
				[Dot42.DexImport("getA", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetA() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getB
				/// </java-name>
				[Dot42.DexImport("getB", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetB() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "()Ljava/security/spec/ECField;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.IECField GetField() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IECField);
				}

				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSeed() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetSeed() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EllipticCurve() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getA
				/// </java-name>
				public global::Java.Math.BigInteger A
				{
				[Dot42.DexImport("getA", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetA(); }
				}

				/// <java-name>
				/// getB
				/// </java-name>
				public global::Java.Math.BigInteger B
				{
				[Dot42.DexImport("getB", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetB(); }
				}

				/// <java-name>
				/// getField
				/// </java-name>
				public global::Java.Security.Spec.IECField Field
				{
				[Dot42.DexImport("getField", "()Ljava/security/spec/ECField;", AccessFlags = 1)]
						get{ return GetField(); }
				}

				/// <java-name>
				/// getSeed
				/// </java-name>
				public byte[] Seed
				{
				[Dot42.DexImport("getSeed", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetSeed(); }
				}

		}

		/// <java-name>
		/// java/security/spec/EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/EncodedKeySpec", AccessFlags = 1057)]
		public abstract partial class EncodedKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public EncodedKeySpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncodedKeySpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetFormat() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EncodedKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetFormat(); }
				}

		}

		/// <java-name>
		/// java/security/spec/AlgorithmParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/AlgorithmParameterSpec", AccessFlags = 1537)]
		public partial interface IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/security/spec/ECField
		/// </java-name>
		[Dot42.DexImport("java/security/spec/ECField", AccessFlags = 1537)]
		public partial interface IECField
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getFieldSize
				/// </java-name>
				[Dot42.DexImport("getFieldSize", "()I", AccessFlags = 1025)]
				int GetFieldSize() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/spec/KeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/KeySpec", AccessFlags = 1537)]
		public partial interface IKeySpec
 /* scope: __dot42__ */ 
		{
		}

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

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidKeySpecException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeySpecException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeySpecException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/spec/InvalidParameterSpecException
		/// </java-name>
		[Dot42.DexImport("java/security/spec/InvalidParameterSpecException", AccessFlags = 33)]
		public partial class InvalidParameterSpecException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidParameterSpecException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidParameterSpecException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/spec/MGF1ParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/MGF1ParameterSpec", AccessFlags = 33)]
		public partial class MGF1ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SHA1
				/// </java-name>
				[Dot42.DexImport("SHA1", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA1;
				/// <java-name>
				/// SHA256
				/// </java-name>
				[Dot42.DexImport("SHA256", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA256;
				/// <java-name>
				/// SHA384
				/// </java-name>
				[Dot42.DexImport("SHA384", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA384;
				/// <java-name>
				/// SHA512
				/// </java-name>
				[Dot42.DexImport("SHA512", "Ljava/security/spec/MGF1ParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.MGF1ParameterSpec SHA512;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MGF1ParameterSpec(string @string) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public string DigestAlgorithm
				{
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDigestAlgorithm(); }
				}

		}

		/// <java-name>
		/// java/security/spec/PKCS8EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/PKCS8EncodedKeySpec", AccessFlags = 33)]
		public partial class PKCS8EncodedKeySpec : global::Java.Security.Spec.EncodedKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public PKCS8EncodedKeySpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PKCS8EncodedKeySpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public override sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

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

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetFormat(); }
				}

		}

		/// <java-name>
		/// java/security/spec/PSSParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/PSSParameterSpec", AccessFlags = 33)]
		public partial class PSSParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Ljava/security/spec/PSSParameterSpec;", AccessFlags = 25)]
				public static readonly global::Java.Security.Spec.PSSParameterSpec DEFAULT;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PSSParameterSpec(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;I" +
    "I)V", AccessFlags = 1)]
				public PSSParameterSpec(string @string, string string1, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSaltLength
				/// </java-name>
				[Dot42.DexImport("getSaltLength", "()I", AccessFlags = 1)]
				public virtual int GetSaltLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDigestAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMGFAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.IAlgorithmParameterSpec GetMGFParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IAlgorithmParameterSpec);
				}

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

				/// <java-name>
				/// getSaltLength
				/// </java-name>
				public int SaltLength
				{
				[Dot42.DexImport("getSaltLength", "()I", AccessFlags = 1)]
						get{ return GetSaltLength(); }
				}

				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public string DigestAlgorithm
				{
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDigestAlgorithm(); }
				}

				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				public string MGFAlgorithm
				{
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMGFAlgorithm(); }
				}

				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				public global::Java.Security.Spec.IAlgorithmParameterSpec MGFParameters
				{
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
						get{ return GetMGFParameters(); }
				}

				/// <java-name>
				/// getTrailerField
				/// </java-name>
				public int TrailerField
				{
				[Dot42.DexImport("getTrailerField", "()I", AccessFlags = 1)]
						get{ return GetTrailerField(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAKeyGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAKeyGenParameterSpec", AccessFlags = 33)]
		public partial class RSAKeyGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// F0
				/// </java-name>
				[Dot42.DexImport("F0", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger F0;
				/// <java-name>
				/// F4
				/// </java-name>
				[Dot42.DexImport("F4", "Ljava/math/BigInteger;", AccessFlags = 25)]
				public static readonly global::Java.Math.BigInteger F4;
				[Dot42.DexImport("<init>", "(ILjava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAKeyGenParameterSpec(int int32, global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeysize
				/// </java-name>
				[Dot42.DexImport("getKeysize", "()I", AccessFlags = 1)]
				public virtual int GetKeysize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getKeysize
				/// </java-name>
				public int Keysize
				{
				[Dot42.DexImport("getKeysize", "()I", AccessFlags = 1)]
						get{ return GetKeysize(); }
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAMultiPrimePrivateCrtKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAMultiPrimePrivateCrtKeySpec", AccessFlags = 33)]
		public partial class RSAMultiPrimePrivateCrtKeySpec : global::Java.Security.Spec.RSAPrivateKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/" +
    "math/BigInteger;[Ljava/security/spec/RSAOtherPrimeInfo;)V", AccessFlags = 1)]
				public RSAMultiPrimePrivateCrtKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3, global::Java.Math.BigInteger bigInteger4, global::Java.Math.BigInteger bigInteger5, global::Java.Math.BigInteger bigInteger6, global::Java.Math.BigInteger bigInteger7, global::Java.Security.Spec.RSAOtherPrimeInfo[] rSAOtherPrimeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.RSAOtherPrimeInfo[] GetOtherPrimeInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.RSAOtherPrimeInfo[]);
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetCrtCoefficient(); }
				}

				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				public global::Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
				{
				[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1)]
						get{ return GetOtherPrimeInfo(); }
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentP
				{
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentP(); }
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentQ
				{
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentQ(); }
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeP
				{
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeP(); }
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeQ
				{
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeQ(); }
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAOtherPrimeInfo
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAOtherPrimeInfo", AccessFlags = 33)]
		public partial class RSAOtherPrimeInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAOtherPrimeInfo(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 17)]
				public global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrime
				/// </java-name>
				[Dot42.DexImport("getPrime", "()Ljava/math/BigInteger;", AccessFlags = 17)]
				public global::Java.Math.BigInteger GetPrime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetCrtCoefficient(); }
				}

				/// <java-name>
				/// getPrime
				/// </java-name>
				public global::Java.Math.BigInteger Prime
				{
				[Dot42.DexImport("getPrime", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetPrime(); }
				}

				/// <java-name>
				/// getExponent
				/// </java-name>
				public global::Java.Math.BigInteger Exponent
				{
				[Dot42.DexImport("getExponent", "()Ljava/math/BigInteger;", AccessFlags = 17)]
						get{ return GetExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAPrivateCrtKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPrivateCrtKeySpec", AccessFlags = 33)]
		public partial class RSAPrivateCrtKeySpec : global::Java.Security.Spec.RSAPrivateKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/Big" +
    "Integer;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/" +
    "math/BigInteger;)V", AccessFlags = 1)]
				public RSAPrivateCrtKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2, global::Java.Math.BigInteger bigInteger3, global::Java.Math.BigInteger bigInteger4, global::Java.Math.BigInteger bigInteger5, global::Java.Math.BigInteger bigInteger6, global::Java.Math.BigInteger bigInteger7) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				public global::Java.Math.BigInteger CrtCoefficient
				{
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetCrtCoefficient(); }
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentP
				{
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentP(); }
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeExponentQ
				{
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeExponentQ(); }
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				public global::Java.Math.BigInteger PrimeP
				{
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeP(); }
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				public global::Java.Math.BigInteger PrimeQ
				{
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrimeQ(); }
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPrivateKeySpec", AccessFlags = 33)]
		public partial class RSAPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAPrivateKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getModulus
				/// </java-name>
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetModulus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getModulus
				/// </java-name>
				public global::Java.Math.BigInteger Modulus
				{
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetModulus(); }
				}

				/// <java-name>
				/// getPrivateExponent
				/// </java-name>
				public global::Java.Math.BigInteger PrivateExponent
				{
				[Dot42.DexImport("getPrivateExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPrivateExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/RSAPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/RSAPublicKeySpec", AccessFlags = 33)]
		public partial class RSAPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public RSAPublicKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getModulus
				/// </java-name>
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetModulus() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

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

				/// <java-name>
				/// getModulus
				/// </java-name>
				public global::Java.Math.BigInteger Modulus
				{
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetModulus(); }
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				public global::Java.Math.BigInteger PublicExponent
				{
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetPublicExponent(); }
				}

		}

		/// <java-name>
		/// java/security/spec/X509EncodedKeySpec
		/// </java-name>
		[Dot42.DexImport("java/security/spec/X509EncodedKeySpec", AccessFlags = 33)]
		public partial class X509EncodedKeySpec : global::Java.Security.Spec.EncodedKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public X509EncodedKeySpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public X509EncodedKeySpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public override sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public override byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

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

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetFormat(); }
				}

		}

}

