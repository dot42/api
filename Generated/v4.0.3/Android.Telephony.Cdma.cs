#pragma warning disable 1717
namespace Android.Telephony.Cdma
{
		/// <java-name>
		/// android/telephony/cdma/CdmaCellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/cdma/CdmaCellLocation", AccessFlags = 33)]
		public partial class CdmaCellLocation : global::Android.Telephony.CellLocation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CdmaCellLocation() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public CdmaCellLocation(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStateInvalid
				/// </java-name>
				[Dot42.DexImport("setStateInvalid", "()V", AccessFlags = 1)]
				public virtual void SetStateInvalid() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCellLocationData
				/// </java-name>
				[Dot42.DexImport("setCellLocationData", "(III)V", AccessFlags = 1)]
				public virtual void SetCellLocationData(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCellLocationData
				/// </java-name>
				[Dot42.DexImport("setCellLocationData", "(IIIII)V", AccessFlags = 1)]
				public virtual void SetCellLocationData(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
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
				/// fillInNotifierBundle
				/// </java-name>
				[Dot42.DexImport("fillInNotifierBundle", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void FillInNotifierBundle(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBaseStationId
				/// </java-name>
				public virtual int BaseStationId
				{
						[Dot42.DexImport("getBaseStationId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaseStationLatitude
				/// </java-name>
				public virtual int BaseStationLatitude
				{
						[Dot42.DexImport("getBaseStationLatitude", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaseStationLongitude
				/// </java-name>
				public virtual int BaseStationLongitude
				{
						[Dot42.DexImport("getBaseStationLongitude", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual int SystemId
				{
						[Dot42.DexImport("getSystemId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getNetworkId
				/// </java-name>
				public virtual int NetworkId
				{
						[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

