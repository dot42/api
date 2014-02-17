// Copyright (C) 2014 dot42
//
// Original filename: Android.Telephony.Cdma.cs
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
namespace Android.Telephony.Cdma
{
		/// <summary>
		/// <para>Represents the cell location on a CDMA phone. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/cdma/CdmaCellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/cdma/CdmaCellLocation", AccessFlags = 33)]
		public partial class CdmaCellLocation : global::Android.Telephony.CellLocation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Empty constructor. Initializes the BID, SID, NID and base station latitude and longitude to invalid values. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CdmaCellLocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initialize the object from a bundle. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public CdmaCellLocation(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationId
				/// </java-name>
				[Dot42.DexImport("getBaseStationId", "()I", AccessFlags = 1)]
				public virtual int GetBaseStationId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Latitude is a decimal number as specified in 3GPP2 C.S0005-A v6.0. () It is represented in units of 0.25 seconds and ranges from -1296000 to 1296000, both values inclusive (corresponding to a range of -90 to +90 degrees). Integer.MAX_VALUE is considered invalid value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station latitude in units of 0.25 seconds, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationLatitude
				/// </java-name>
				[Dot42.DexImport("getBaseStationLatitude", "()I", AccessFlags = 1)]
				public virtual int GetBaseStationLatitude() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Longitude is a decimal number as specified in 3GPP2 C.S0005-A v6.0. () It is represented in units of 0.25 seconds and ranges from -2592000 to 2592000, both values inclusive (corresponding to a range of -180 to +180 degrees). Integer.MAX_VALUE is considered invalid value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station longitude in units of 0.25 seconds, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationLongitude
				/// </java-name>
				[Dot42.DexImport("getBaseStationLongitude", "()I", AccessFlags = 1)]
				public virtual int GetBaseStationLongitude() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma system identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()I", AccessFlags = 1)]
				public virtual int GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma network identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getNetworkId
				/// </java-name>
				[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
				public virtual int GetNetworkId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Invalidate this object. The cell location data is set to invalid values. </para>        
				/// </summary>
				/// <java-name>
				/// setStateInvalid
				/// </java-name>
				[Dot42.DexImport("setStateInvalid", "()V", AccessFlags = 1)]
				public virtual void SetStateInvalid() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the cell location data. </para>        
				/// </summary>
				/// <java-name>
				/// setCellLocationData
				/// </java-name>
				[Dot42.DexImport("setCellLocationData", "(III)V", AccessFlags = 1)]
				public virtual void SetCellLocationData(int baseStationId, int baseStationLatitude, int baseStationLongitude) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the cell location data. </para>        
				/// </summary>
				/// <java-name>
				/// setCellLocationData
				/// </java-name>
				[Dot42.DexImport("setCellLocationData", "(IIIII)V", AccessFlags = 1)]
				public virtual void SetCellLocationData(int baseStationId, int baseStationLatitude, int baseStationLongitude, int systemId, int networkId) /* MethodBuilder.Create */ 
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
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Fill the cell location data into the intent notifier Bundle based on service state</para><para></para>        
				/// </summary>
				/// <java-name>
				/// fillInNotifierBundle
				/// </java-name>
				[Dot42.DexImport("fillInNotifierBundle", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void FillInNotifierBundle(global::Android.Os.Bundle bundleToFill) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationId
				/// </java-name>
				public int BaseStationId
				{
				[Dot42.DexImport("getBaseStationId", "()I", AccessFlags = 1)]
						get{ return GetBaseStationId(); }
				}

				/// <summary>
				/// <para>Latitude is a decimal number as specified in 3GPP2 C.S0005-A v6.0. () It is represented in units of 0.25 seconds and ranges from -1296000 to 1296000, both values inclusive (corresponding to a range of -90 to +90 degrees). Integer.MAX_VALUE is considered invalid value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station latitude in units of 0.25 seconds, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationLatitude
				/// </java-name>
				public int BaseStationLatitude
				{
				[Dot42.DexImport("getBaseStationLatitude", "()I", AccessFlags = 1)]
						get{ return GetBaseStationLatitude(); }
				}

				/// <summary>
				/// <para>Longitude is a decimal number as specified in 3GPP2 C.S0005-A v6.0. () It is represented in units of 0.25 seconds and ranges from -2592000 to 2592000, both values inclusive (corresponding to a range of -180 to +180 degrees). Integer.MAX_VALUE is considered invalid value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma base station longitude in units of 0.25 seconds, Integer.MAX_VALUE if unknown </para>
				/// </returns>
				/// <java-name>
				/// getBaseStationLongitude
				/// </java-name>
				public int BaseStationLongitude
				{
				[Dot42.DexImport("getBaseStationLongitude", "()I", AccessFlags = 1)]
						get{ return GetBaseStationLongitude(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma system identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public int SystemId
				{
				[Dot42.DexImport("getSystemId", "()I", AccessFlags = 1)]
						get{ return GetSystemId(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>cdma network identification number, -1 if unknown </para>
				/// </returns>
				/// <java-name>
				/// getNetworkId
				/// </java-name>
				public int NetworkId
				{
				[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
						get{ return GetNetworkId(); }
				}

		}

}


