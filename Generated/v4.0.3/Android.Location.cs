#pragma warning disable 1717
namespace Android.Location
{
		/// <java-name>
		/// android/location/Address
		/// </java-name>
		[Dot42.DexImport("android/location/Address", AccessFlags = 33)]
		public partial class Address : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Location.Address> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public Address(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// getMaxAddressLineIndex
				/// </java-name>
				[Dot42.DexImport("getMaxAddressLineIndex", "()I", AccessFlags = 1)]
				public virtual int GetMaxAddressLineIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAddressLine
				/// </java-name>
				[Dot42.DexImport("getAddressLine", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAddressLine(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setAddressLine
				/// </java-name>
				[Dot42.DexImport("setAddressLine", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAddressLine(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFeatureName
				/// </java-name>
				[Dot42.DexImport("getFeatureName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFeatureName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setFeatureName
				/// </java-name>
				[Dot42.DexImport("setFeatureName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetFeatureName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAdminArea
				/// </java-name>
				[Dot42.DexImport("getAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAdminArea() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setAdminArea
				/// </java-name>
				[Dot42.DexImport("setAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAdminArea(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSubAdminArea
				/// </java-name>
				[Dot42.DexImport("getSubAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubAdminArea() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSubAdminArea
				/// </java-name>
				[Dot42.DexImport("setSubAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubAdminArea(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocality
				/// </java-name>
				[Dot42.DexImport("getLocality", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocality() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setLocality
				/// </java-name>
				[Dot42.DexImport("setLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetLocality(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSubLocality
				/// </java-name>
				[Dot42.DexImport("getSubLocality", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubLocality() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSubLocality
				/// </java-name>
				[Dot42.DexImport("setSubLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubLocality(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getThoroughfare
				/// </java-name>
				[Dot42.DexImport("getThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetThoroughfare() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setThoroughfare
				/// </java-name>
				[Dot42.DexImport("setThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetThoroughfare(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSubThoroughfare
				/// </java-name>
				[Dot42.DexImport("getSubThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSubThoroughfare() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSubThoroughfare
				/// </java-name>
				[Dot42.DexImport("setSubThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubThoroughfare(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPremises
				/// </java-name>
				[Dot42.DexImport("getPremises", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPremises() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPremises
				/// </java-name>
				[Dot42.DexImport("setPremises", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPremises(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPostalCode
				/// </java-name>
				[Dot42.DexImport("getPostalCode", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPostalCode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPostalCode
				/// </java-name>
				[Dot42.DexImport("setPostalCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPostalCode(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCountryCode
				/// </java-name>
				[Dot42.DexImport("getCountryCode", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCountryCode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCountryCode
				/// </java-name>
				[Dot42.DexImport("setCountryCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCountryCode(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCountryName
				/// </java-name>
				[Dot42.DexImport("getCountryName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCountryName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCountryName
				/// </java-name>
				[Dot42.DexImport("setCountryName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCountryName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasLatitude
				/// </java-name>
				[Dot42.DexImport("hasLatitude", "()Z", AccessFlags = 1)]
				public virtual bool HasLatitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
				public virtual double GetLatitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setLatitude
				/// </java-name>
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLatitude(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearLatitude
				/// </java-name>
				[Dot42.DexImport("clearLatitude", "()V", AccessFlags = 1)]
				public virtual void ClearLatitude() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasLongitude
				/// </java-name>
				[Dot42.DexImport("hasLongitude", "()Z", AccessFlags = 1)]
				public virtual bool HasLongitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
				public virtual double GetLongitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setLongitude
				/// </java-name>
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLongitude(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearLongitude
				/// </java-name>
				[Dot42.DexImport("clearLongitude", "()V", AccessFlags = 1)]
				public virtual void ClearLongitude() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPhone
				/// </java-name>
				[Dot42.DexImport("getPhone", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPhone() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPhone
				/// </java-name>
				[Dot42.DexImport("setPhone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPhone(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setUrl
				/// </java-name>
				[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUrl(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// setExtras
				/// </java-name>
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetExtras(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Address() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				}

				/// <java-name>
				/// getMaxAddressLineIndex
				/// </java-name>
				public int MaxAddressLineIndex
				{
				[Dot42.DexImport("getMaxAddressLineIndex", "()I", AccessFlags = 1)]
						get{ return GetMaxAddressLineIndex(); }
				}

				/// <java-name>
				/// getFeatureName
				/// </java-name>
				public string FeatureName
				{
				[Dot42.DexImport("getFeatureName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFeatureName(); }
				[Dot42.DexImport("setFeatureName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetFeatureName(value); }
				}

				/// <java-name>
				/// getAdminArea
				/// </java-name>
				public string AdminArea
				{
				[Dot42.DexImport("getAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAdminArea(); }
				[Dot42.DexImport("setAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetAdminArea(value); }
				}

				/// <java-name>
				/// getSubAdminArea
				/// </java-name>
				public string SubAdminArea
				{
				[Dot42.DexImport("getSubAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubAdminArea(); }
				[Dot42.DexImport("setSubAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubAdminArea(value); }
				}

				/// <java-name>
				/// getLocality
				/// </java-name>
				public string Locality
				{
				[Dot42.DexImport("getLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocality(); }
				[Dot42.DexImport("setLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetLocality(value); }
				}

				/// <java-name>
				/// getSubLocality
				/// </java-name>
				public string SubLocality
				{
				[Dot42.DexImport("getSubLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubLocality(); }
				[Dot42.DexImport("setSubLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubLocality(value); }
				}

				/// <java-name>
				/// getThoroughfare
				/// </java-name>
				public string Thoroughfare
				{
				[Dot42.DexImport("getThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetThoroughfare(); }
				[Dot42.DexImport("setThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetThoroughfare(value); }
				}

				/// <java-name>
				/// getSubThoroughfare
				/// </java-name>
				public string SubThoroughfare
				{
				[Dot42.DexImport("getSubThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSubThoroughfare(); }
				[Dot42.DexImport("setSubThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSubThoroughfare(value); }
				}

				/// <java-name>
				/// getPremises
				/// </java-name>
				public string Premises
				{
				[Dot42.DexImport("getPremises", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPremises(); }
				[Dot42.DexImport("setPremises", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPremises(value); }
				}

				/// <java-name>
				/// getPostalCode
				/// </java-name>
				public string PostalCode
				{
				[Dot42.DexImport("getPostalCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPostalCode(); }
				[Dot42.DexImport("setPostalCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPostalCode(value); }
				}

				/// <java-name>
				/// getCountryCode
				/// </java-name>
				public string CountryCode
				{
				[Dot42.DexImport("getCountryCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountryCode(); }
				[Dot42.DexImport("setCountryCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCountryCode(value); }
				}

				/// <java-name>
				/// getCountryName
				/// </java-name>
				public string CountryName
				{
				[Dot42.DexImport("getCountryName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountryName(); }
				[Dot42.DexImport("setCountryName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetCountryName(value); }
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				public double Latitude
				{
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return GetLatitude(); }
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ SetLatitude(value); }
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				public double Longitude
				{
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return GetLongitude(); }
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ SetLongitude(value); }
				}

				/// <java-name>
				/// getPhone
				/// </java-name>
				public string Phone
				{
				[Dot42.DexImport("getPhone", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPhone(); }
				[Dot42.DexImport("setPhone", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPhone(value); }
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetUrl(value); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.OS.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ SetExtras(value); }
				}

		}

		/// <java-name>
		/// android/location/Criteria
		/// </java-name>
		[Dot42.DexImport("android/location/Criteria", AccessFlags = 33)]
		public partial class Criteria : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_REQUIREMENT
				/// </java-name>
				[Dot42.DexImport("NO_REQUIREMENT", "I", AccessFlags = 25)]
				public const int NO_REQUIREMENT = 0;
				/// <java-name>
				/// POWER_LOW
				/// </java-name>
				[Dot42.DexImport("POWER_LOW", "I", AccessFlags = 25)]
				public const int POWER_LOW = 1;
				/// <java-name>
				/// POWER_MEDIUM
				/// </java-name>
				[Dot42.DexImport("POWER_MEDIUM", "I", AccessFlags = 25)]
				public const int POWER_MEDIUM = 2;
				/// <java-name>
				/// POWER_HIGH
				/// </java-name>
				[Dot42.DexImport("POWER_HIGH", "I", AccessFlags = 25)]
				public const int POWER_HIGH = 3;
				/// <java-name>
				/// ACCURACY_FINE
				/// </java-name>
				[Dot42.DexImport("ACCURACY_FINE", "I", AccessFlags = 25)]
				public const int ACCURACY_FINE = 1;
				/// <java-name>
				/// ACCURACY_COARSE
				/// </java-name>
				[Dot42.DexImport("ACCURACY_COARSE", "I", AccessFlags = 25)]
				public const int ACCURACY_COARSE = 2;
				/// <java-name>
				/// ACCURACY_LOW
				/// </java-name>
				[Dot42.DexImport("ACCURACY_LOW", "I", AccessFlags = 25)]
				public const int ACCURACY_LOW = 1;
				/// <java-name>
				/// ACCURACY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("ACCURACY_MEDIUM", "I", AccessFlags = 25)]
				public const int ACCURACY_MEDIUM = 2;
				/// <java-name>
				/// ACCURACY_HIGH
				/// </java-name>
				[Dot42.DexImport("ACCURACY_HIGH", "I", AccessFlags = 25)]
				public const int ACCURACY_HIGH = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Location.Criteria> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Criteria() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/location/Criteria;)V", AccessFlags = 1)]
				public Criteria(global::Android.Location.Criteria criteria) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalAccuracy
				/// </java-name>
				[Dot42.DexImport("setHorizontalAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalAccuracy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHorizontalAccuracy
				/// </java-name>
				[Dot42.DexImport("getHorizontalAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetHorizontalAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVerticalAccuracy
				/// </java-name>
				[Dot42.DexImport("setVerticalAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalAccuracy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVerticalAccuracy
				/// </java-name>
				[Dot42.DexImport("getVerticalAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetVerticalAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSpeedAccuracy
				/// </java-name>
				[Dot42.DexImport("setSpeedAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetSpeedAccuracy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpeedAccuracy
				/// </java-name>
				[Dot42.DexImport("getSpeedAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetSpeedAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setBearingAccuracy
				/// </java-name>
				[Dot42.DexImport("setBearingAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetBearingAccuracy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBearingAccuracy
				/// </java-name>
				[Dot42.DexImport("getBearingAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetBearingAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAccuracy
				/// </java-name>
				[Dot42.DexImport("setAccuracy", "(I)V", AccessFlags = 1)]
				public virtual void SetAccuracy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1)]
				public virtual int GetAccuracy() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPowerRequirement
				/// </java-name>
				[Dot42.DexImport("setPowerRequirement", "(I)V", AccessFlags = 1)]
				public virtual void SetPowerRequirement(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1)]
				public virtual int GetPowerRequirement() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCostAllowed
				/// </java-name>
				[Dot42.DexImport("setCostAllowed", "(Z)V", AccessFlags = 1)]
				public virtual void SetCostAllowed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isCostAllowed
				/// </java-name>
				[Dot42.DexImport("isCostAllowed", "()Z", AccessFlags = 1)]
				public virtual bool IsCostAllowed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAltitudeRequired
				/// </java-name>
				[Dot42.DexImport("setAltitudeRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetAltitudeRequired(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAltitudeRequired
				/// </java-name>
				[Dot42.DexImport("isAltitudeRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsAltitudeRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSpeedRequired
				/// </java-name>
				[Dot42.DexImport("setSpeedRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetSpeedRequired(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSpeedRequired
				/// </java-name>
				[Dot42.DexImport("isSpeedRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsSpeedRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBearingRequired
				/// </java-name>
				[Dot42.DexImport("setBearingRequired", "(Z)V", AccessFlags = 1)]
				public virtual void SetBearingRequired(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isBearingRequired
				/// </java-name>
				[Dot42.DexImport("isBearingRequired", "()Z", AccessFlags = 1)]
				public virtual bool IsBearingRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHorizontalAccuracy
				/// </java-name>
				public int HorizontalAccuracy
				{
				[Dot42.DexImport("getHorizontalAccuracy", "()I", AccessFlags = 1)]
						get{ return GetHorizontalAccuracy(); }
				[Dot42.DexImport("setHorizontalAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetHorizontalAccuracy(value); }
				}

				/// <java-name>
				/// getVerticalAccuracy
				/// </java-name>
				public int VerticalAccuracy
				{
				[Dot42.DexImport("getVerticalAccuracy", "()I", AccessFlags = 1)]
						get{ return GetVerticalAccuracy(); }
				[Dot42.DexImport("setVerticalAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetVerticalAccuracy(value); }
				}

				/// <java-name>
				/// getSpeedAccuracy
				/// </java-name>
				public int SpeedAccuracy
				{
				[Dot42.DexImport("getSpeedAccuracy", "()I", AccessFlags = 1)]
						get{ return GetSpeedAccuracy(); }
				[Dot42.DexImport("setSpeedAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetSpeedAccuracy(value); }
				}

				/// <java-name>
				/// getBearingAccuracy
				/// </java-name>
				public int BearingAccuracy
				{
				[Dot42.DexImport("getBearingAccuracy", "()I", AccessFlags = 1)]
						get{ return GetBearingAccuracy(); }
				[Dot42.DexImport("setBearingAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetBearingAccuracy(value); }
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public int Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1)]
						get{ return GetAccuracy(); }
				[Dot42.DexImport("setAccuracy", "(I)V", AccessFlags = 1)]
						set{ SetAccuracy(value); }
				}

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public int PowerRequirement
				{
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1)]
						get{ return GetPowerRequirement(); }
				[Dot42.DexImport("setPowerRequirement", "(I)V", AccessFlags = 1)]
						set{ SetPowerRequirement(value); }
				}

		}

		/// <java-name>
		/// android/location/Geocoder
		/// </java-name>
		[Dot42.DexImport("android/location/Geocoder", AccessFlags = 49)]
		public sealed partial class Geocoder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/Locale;)V", AccessFlags = 1)]
				public Geocoder(global::Android.Content.Context context, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Geocoder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPresent
				/// </java-name>
				[Dot42.DexImport("isPresent", "()Z", AccessFlags = 9)]
				public static bool IsPresent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFromLocation
				/// </java-name>
				[Dot42.DexImport("getFromLocation", "(DDI)Ljava/util/List;", AccessFlags = 1, Signature = "(DDI)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocation(double @double, double double1, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				/// <java-name>
				/// getFromLocationName
				/// </java-name>
				[Dot42.DexImport("getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocationName(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				/// <java-name>
				/// getFromLocationName
				/// </java-name>
				[Dot42.DexImport("getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;IDDDD)Ljava/util/List<Landroid/location/Address;>;")]
				public global::Java.Util.IList<global::Android.Location.Address> GetFromLocationName(string @string, int int32, double @double, double double1, double double2, double double3) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Location.Address>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Geocoder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/location/GpsSatellite
		/// </java-name>
		[Dot42.DexImport("android/location/GpsSatellite", AccessFlags = 49)]
		public sealed partial class GpsSatellite
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GpsSatellite() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrn
				/// </java-name>
				[Dot42.DexImport("getPrn", "()I", AccessFlags = 1)]
				public int GetPrn() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSnr
				/// </java-name>
				[Dot42.DexImport("getSnr", "()F", AccessFlags = 1)]
				public float GetSnr() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getElevation
				/// </java-name>
				[Dot42.DexImport("getElevation", "()F", AccessFlags = 1)]
				public float GetElevation() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getAzimuth
				/// </java-name>
				[Dot42.DexImport("getAzimuth", "()F", AccessFlags = 1)]
				public float GetAzimuth() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hasEphemeris
				/// </java-name>
				[Dot42.DexImport("hasEphemeris", "()Z", AccessFlags = 1)]
				public bool HasEphemeris() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasAlmanac
				/// </java-name>
				[Dot42.DexImport("hasAlmanac", "()Z", AccessFlags = 1)]
				public bool HasAlmanac() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// usedInFix
				/// </java-name>
				[Dot42.DexImport("usedInFix", "()Z", AccessFlags = 1)]
				public bool UsedInFix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPrn
				/// </java-name>
				public int Prn
				{
				[Dot42.DexImport("getPrn", "()I", AccessFlags = 1)]
						get{ return GetPrn(); }
				}

				/// <java-name>
				/// getSnr
				/// </java-name>
				public float Snr
				{
				[Dot42.DexImport("getSnr", "()F", AccessFlags = 1)]
						get{ return GetSnr(); }
				}

				/// <java-name>
				/// getElevation
				/// </java-name>
				public float Elevation
				{
				[Dot42.DexImport("getElevation", "()F", AccessFlags = 1)]
						get{ return GetElevation(); }
				}

				/// <java-name>
				/// getAzimuth
				/// </java-name>
				public float Azimuth
				{
				[Dot42.DexImport("getAzimuth", "()F", AccessFlags = 1)]
						get{ return GetAzimuth(); }
				}

		}

		/// <java-name>
		/// android/location/GpsStatus
		/// </java-name>
		[Dot42.DexImport("android/location/GpsStatus", AccessFlags = 49)]
		public sealed partial class GpsStatus
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GPS_EVENT_STARTED
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_STARTED", "I", AccessFlags = 25)]
				public const int GPS_EVENT_STARTED = 1;
				/// <java-name>
				/// GPS_EVENT_STOPPED
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_STOPPED", "I", AccessFlags = 25)]
				public const int GPS_EVENT_STOPPED = 2;
				/// <java-name>
				/// GPS_EVENT_FIRST_FIX
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_FIRST_FIX", "I", AccessFlags = 25)]
				public const int GPS_EVENT_FIRST_FIX = 3;
				/// <java-name>
				/// GPS_EVENT_SATELLITE_STATUS
				/// </java-name>
				[Dot42.DexImport("GPS_EVENT_SATELLITE_STATUS", "I", AccessFlags = 25)]
				public const int GPS_EVENT_SATELLITE_STATUS = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GpsStatus() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTimeToFirstFix
				/// </java-name>
				[Dot42.DexImport("getTimeToFirstFix", "()I", AccessFlags = 1)]
				public int GetTimeToFirstFix() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSatellites
				/// </java-name>
				[Dot42.DexImport("getSatellites", "()Ljava/lang/Iterable;", AccessFlags = 1, Signature = "()Ljava/lang/Iterable<Landroid/location/GpsSatellite;>;")]
				public global::Java.Lang.IIterable<global::Android.Location.GpsSatellite> GetSatellites() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.IIterable<global::Android.Location.GpsSatellite>);
				}

				/// <java-name>
				/// getMaxSatellites
				/// </java-name>
				[Dot42.DexImport("getMaxSatellites", "()I", AccessFlags = 1)]
				public int GetMaxSatellites() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTimeToFirstFix
				/// </java-name>
				public int TimeToFirstFix
				{
				[Dot42.DexImport("getTimeToFirstFix", "()I", AccessFlags = 1)]
						get{ return GetTimeToFirstFix(); }
				}

				/// <java-name>
				/// getSatellites
				/// </java-name>
				public global::Java.Lang.IIterable<global::Android.Location.GpsSatellite> Satellites
				{
				[Dot42.DexImport("getSatellites", "()Ljava/lang/Iterable;", AccessFlags = 1, Signature = "()Ljava/lang/Iterable<Landroid/location/GpsSatellite;>;")]
						get{ return GetSatellites(); }
				}

				/// <java-name>
				/// getMaxSatellites
				/// </java-name>
				public int MaxSatellites
				{
				[Dot42.DexImport("getMaxSatellites", "()I", AccessFlags = 1)]
						get{ return GetMaxSatellites(); }
				}

				/// <java-name>
				/// android/location/GpsStatus$NmeaListener
				/// </java-name>
				[Dot42.DexImport("android/location/GpsStatus$NmeaListener", AccessFlags = 1545)]
				public partial interface INmeaListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onNmeaReceived
						/// </java-name>
						[Dot42.DexImport("onNmeaReceived", "(JLjava/lang/String;)V", AccessFlags = 1025)]
						void OnNmeaReceived(long int64, string @string) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/location/GpsStatus$Listener
				/// </java-name>
				[Dot42.DexImport("android/location/GpsStatus$Listener", AccessFlags = 1545)]
				public partial interface IListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGpsStatusChanged
						/// </java-name>
						[Dot42.DexImport("onGpsStatusChanged", "(I)V", AccessFlags = 1025)]
						void OnGpsStatusChanged(int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/location/LocationListener
		/// </java-name>
		[Dot42.DexImport("android/location/LocationListener", AccessFlags = 1537)]
		public partial interface ILocationListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onLocationChanged
				/// </java-name>
				[Dot42.DexImport("onLocationChanged", "(Landroid/location/Location;)V", AccessFlags = 1025)]
				void OnLocationChanged(global::Android.Location.Location location) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStatusChanged
				/// </java-name>
				[Dot42.DexImport("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnStatusChanged(string @string, int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onProviderEnabled
				/// </java-name>
				[Dot42.DexImport("onProviderEnabled", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnProviderEnabled(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onProviderDisabled
				/// </java-name>
				[Dot42.DexImport("onProviderDisabled", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnProviderDisabled(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/location/Location
		/// </java-name>
		[Dot42.DexImport("android/location/Location", AccessFlags = 33)]
		public partial class Location : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FORMAT_DEGREES
				/// </java-name>
				[Dot42.DexImport("FORMAT_DEGREES", "I", AccessFlags = 25)]
				public const int FORMAT_DEGREES = 0;
				/// <java-name>
				/// FORMAT_MINUTES
				/// </java-name>
				[Dot42.DexImport("FORMAT_MINUTES", "I", AccessFlags = 25)]
				public const int FORMAT_MINUTES = 1;
				/// <java-name>
				/// FORMAT_SECONDS
				/// </java-name>
				[Dot42.DexImport("FORMAT_SECONDS", "I", AccessFlags = 25)]
				public const int FORMAT_SECONDS = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Location.Location> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Location(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/location/Location;)V", AccessFlags = 1)]
				public Location(global::Android.Location.Location location) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/location/Location;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Location.Location location) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// convert
				/// </java-name>
				[Dot42.DexImport("convert", "(DI)Ljava/lang/String;", AccessFlags = 9)]
				public static string Convert(double @double, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// convert
				/// </java-name>
				[Dot42.DexImport("convert", "(Ljava/lang/String;)D", AccessFlags = 9)]
				public static double Convert(string @string) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// distanceBetween
				/// </java-name>
				[Dot42.DexImport("distanceBetween", "(DDDD[F)V", AccessFlags = 9)]
				public static void DistanceBetween(double @double, double double1, double double2, double double3, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// distanceTo
				/// </java-name>
				[Dot42.DexImport("distanceTo", "(Landroid/location/Location;)F", AccessFlags = 1)]
				public virtual float DistanceTo(global::Android.Location.Location location) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// bearingTo
				/// </java-name>
				[Dot42.DexImport("bearingTo", "(Landroid/location/Location;)F", AccessFlags = 1)]
				public virtual float BearingTo(global::Android.Location.Location location) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProvider() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setProvider
				/// </java-name>
				[Dot42.DexImport("setProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProvider(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
				public virtual long GetTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public virtual void SetTime(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
				public virtual double GetLatitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setLatitude
				/// </java-name>
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLatitude(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
				public virtual double GetLongitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setLongitude
				/// </java-name>
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
				public virtual void SetLongitude(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasAltitude
				/// </java-name>
				[Dot42.DexImport("hasAltitude", "()Z", AccessFlags = 1)]
				public virtual bool HasAltitude() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "()D", AccessFlags = 1)]
				public virtual double GetAltitude() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setAltitude
				/// </java-name>
				[Dot42.DexImport("setAltitude", "(D)V", AccessFlags = 1)]
				public virtual void SetAltitude(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAltitude
				/// </java-name>
				[Dot42.DexImport("removeAltitude", "()V", AccessFlags = 1)]
				public virtual void RemoveAltitude() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasSpeed
				/// </java-name>
				[Dot42.DexImport("hasSpeed", "()Z", AccessFlags = 1)]
				public virtual bool HasSpeed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSpeed
				/// </java-name>
				[Dot42.DexImport("getSpeed", "()F", AccessFlags = 1)]
				public virtual float GetSpeed() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setSpeed
				/// </java-name>
				[Dot42.DexImport("setSpeed", "(F)V", AccessFlags = 1)]
				public virtual void SetSpeed(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeSpeed
				/// </java-name>
				[Dot42.DexImport("removeSpeed", "()V", AccessFlags = 1)]
				public virtual void RemoveSpeed() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasBearing
				/// </java-name>
				[Dot42.DexImport("hasBearing", "()Z", AccessFlags = 1)]
				public virtual bool HasBearing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBearing
				/// </java-name>
				[Dot42.DexImport("getBearing", "()F", AccessFlags = 1)]
				public virtual float GetBearing() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setBearing
				/// </java-name>
				[Dot42.DexImport("setBearing", "(F)V", AccessFlags = 1)]
				public virtual void SetBearing(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeBearing
				/// </java-name>
				[Dot42.DexImport("removeBearing", "()V", AccessFlags = 1)]
				public virtual void RemoveBearing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasAccuracy
				/// </java-name>
				[Dot42.DexImport("hasAccuracy", "()Z", AccessFlags = 1)]
				public virtual bool HasAccuracy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()F", AccessFlags = 1)]
				public virtual float GetAccuracy() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// setAccuracy
				/// </java-name>
				[Dot42.DexImport("setAccuracy", "(F)V", AccessFlags = 1)]
				public virtual void SetAccuracy(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAccuracy
				/// </java-name>
				[Dot42.DexImport("removeAccuracy", "()V", AccessFlags = 1)]
				public virtual void RemoveAccuracy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// setExtras
				/// </java-name>
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetExtras(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Location() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public string Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProvider(); }
				[Dot42.DexImport("setProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetProvider(value); }
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				public long Time
				{
				[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return GetTime(); }
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ SetTime(value); }
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				public double Latitude
				{
				[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return GetLatitude(); }
				[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ SetLatitude(value); }
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				public double Longitude
				{
				[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return GetLongitude(); }
				[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ SetLongitude(value); }
				}

				/// <java-name>
				/// getAltitude
				/// </java-name>
				public double Altitude
				{
				[Dot42.DexImport("getAltitude", "()D", AccessFlags = 1)]
						get{ return GetAltitude(); }
				[Dot42.DexImport("setAltitude", "(D)V", AccessFlags = 1)]
						set{ SetAltitude(value); }
				}

				/// <java-name>
				/// getSpeed
				/// </java-name>
				public float Speed
				{
				[Dot42.DexImport("getSpeed", "()F", AccessFlags = 1)]
						get{ return GetSpeed(); }
				[Dot42.DexImport("setSpeed", "(F)V", AccessFlags = 1)]
						set{ SetSpeed(value); }
				}

				/// <java-name>
				/// getBearing
				/// </java-name>
				public float Bearing
				{
				[Dot42.DexImport("getBearing", "()F", AccessFlags = 1)]
						get{ return GetBearing(); }
				[Dot42.DexImport("setBearing", "(F)V", AccessFlags = 1)]
						set{ SetBearing(value); }
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public float Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()F", AccessFlags = 1)]
						get{ return GetAccuracy(); }
				[Dot42.DexImport("setAccuracy", "(F)V", AccessFlags = 1)]
						set{ SetAccuracy(value); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.OS.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ SetExtras(value); }
				}

		}

		/// <java-name>
		/// android/location/LocationManager
		/// </java-name>
		[Dot42.DexImport("android/location/LocationManager", AccessFlags = 33)]
		public partial class LocationManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NETWORK_PROVIDER
				/// </java-name>
				[Dot42.DexImport("NETWORK_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_PROVIDER = "network";
				/// <java-name>
				/// GPS_PROVIDER
				/// </java-name>
				[Dot42.DexImport("GPS_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string GPS_PROVIDER = "gps";
				/// <java-name>
				/// PASSIVE_PROVIDER
				/// </java-name>
				[Dot42.DexImport("PASSIVE_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PASSIVE_PROVIDER = "passive";
				/// <java-name>
				/// KEY_PROXIMITY_ENTERING
				/// </java-name>
				[Dot42.DexImport("KEY_PROXIMITY_ENTERING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_PROXIMITY_ENTERING = "entering";
				/// <java-name>
				/// KEY_STATUS_CHANGED
				/// </java-name>
				[Dot42.DexImport("KEY_STATUS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_STATUS_CHANGED = "status";
				/// <java-name>
				/// KEY_PROVIDER_ENABLED
				/// </java-name>
				[Dot42.DexImport("KEY_PROVIDER_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_PROVIDER_ENABLED = "providerEnabled";
				/// <java-name>
				/// KEY_LOCATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("KEY_LOCATION_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_LOCATION_CHANGED = "location";
				/// <java-name>
				/// PROVIDERS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("PROVIDERS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROVIDERS_CHANGED_ACTION = "android.location.PROVIDERS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LocationManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAllProviders
				/// </java-name>
				[Dot42.DexImport("getAllProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetAllProviders() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Z)Ljava/util/List;", AccessFlags = 1, Signature = "(Z)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetProviders(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;", AccessFlags = 1)]
				public virtual global::Android.Location.LocationProvider GetProvider(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.LocationProvider);
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/location/Criteria;Z)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetProviders(global::Android.Location.Criteria criteria, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// getBestProvider
				/// </java-name>
				[Dot42.DexImport("getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetBestProvider(global::Android.Location.Criteria criteria, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string @string, long int64, float single, global::Android.Location.ILocationListener locationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string @string, long int64, float single, global::Android.Location.ILocationListener locationListener, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(JFLandroid/location/Criteria;Landroid/location/LocationListener;Landroid/os/Loop" +
    "er;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(long int64, float single, global::Android.Location.Criteria criteria, global::Android.Location.ILocationListener locationListener, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(string @string, long int64, float single, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdates
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdates", "(JFLandroid/location/Criteria;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestLocationUpdates(long int64, float single, global::Android.Location.Criteria criteria, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Ljava/lang/String;Landroid/location/LocationListener;Landroid/os/Looper;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(string @string, global::Android.Location.ILocationListener locationListener, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Landroid/location/Criteria;Landroid/location/LocationListener;Landroid/os/Looper" +
    ";)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(global::Android.Location.Criteria criteria, global::Android.Location.ILocationListener locationListener, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Ljava/lang/String;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(string @string, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestSingleUpdate
				/// </java-name>
				[Dot42.DexImport("requestSingleUpdate", "(Landroid/location/Criteria;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestSingleUpdate(global::Android.Location.Criteria criteria, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeUpdates
				/// </java-name>
				[Dot42.DexImport("removeUpdates", "(Landroid/location/LocationListener;)V", AccessFlags = 1)]
				public virtual void RemoveUpdates(global::Android.Location.ILocationListener locationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeUpdates
				/// </java-name>
				[Dot42.DexImport("removeUpdates", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RemoveUpdates(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addProximityAlert
				/// </java-name>
				[Dot42.DexImport("addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void AddProximityAlert(double @double, double double1, float single, long int64, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeProximityAlert
				/// </java-name>
				[Dot42.DexImport("removeProximityAlert", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RemoveProximityAlert(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isProviderEnabled
				/// </java-name>
				[Dot42.DexImport("isProviderEnabled", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsProviderEnabled(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLastKnownLocation
				/// </java-name>
				[Dot42.DexImport("getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;", AccessFlags = 1)]
				public virtual global::Android.Location.Location GetLastKnownLocation(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.Location);
				}

				/// <java-name>
				/// addTestProvider
				/// </java-name>
				[Dot42.DexImport("addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V", AccessFlags = 1)]
				public virtual void AddTestProvider(string @string, bool boolean, bool boolean1, bool boolean2, bool boolean3, bool boolean4, bool boolean5, bool boolean6, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeTestProvider
				/// </java-name>
				[Dot42.DexImport("removeTestProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveTestProvider(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTestProviderLocation
				/// </java-name>
				[Dot42.DexImport("setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V", AccessFlags = 1)]
				public virtual void SetTestProviderLocation(string @string, global::Android.Location.Location location) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearTestProviderLocation
				/// </java-name>
				[Dot42.DexImport("clearTestProviderLocation", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderLocation(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTestProviderEnabled
				/// </java-name>
				[Dot42.DexImport("setTestProviderEnabled", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetTestProviderEnabled(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearTestProviderEnabled
				/// </java-name>
				[Dot42.DexImport("clearTestProviderEnabled", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderEnabled(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTestProviderStatus
				/// </java-name>
				[Dot42.DexImport("setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V", AccessFlags = 1)]
				public virtual void SetTestProviderStatus(string @string, int int32, global::Android.OS.Bundle bundle, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearTestProviderStatus
				/// </java-name>
				[Dot42.DexImport("clearTestProviderStatus", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ClearTestProviderStatus(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addGpsStatusListener
				/// </java-name>
				[Dot42.DexImport("addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z", AccessFlags = 1)]
				public virtual bool AddGpsStatusListener(global::Android.Location.GpsStatus.IListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeGpsStatusListener
				/// </java-name>
				[Dot42.DexImport("removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V", AccessFlags = 1)]
				public virtual void RemoveGpsStatusListener(global::Android.Location.GpsStatus.IListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addNmeaListener
				/// </java-name>
				[Dot42.DexImport("addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z", AccessFlags = 1)]
				public virtual bool AddNmeaListener(global::Android.Location.GpsStatus.INmeaListener nmeaListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeNmeaListener
				/// </java-name>
				[Dot42.DexImport("removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V", AccessFlags = 1)]
				public virtual void RemoveNmeaListener(global::Android.Location.GpsStatus.INmeaListener nmeaListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGpsStatus
				/// </java-name>
				[Dot42.DexImport("getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;", AccessFlags = 1)]
				public virtual global::Android.Location.GpsStatus GetGpsStatus(global::Android.Location.GpsStatus gpsStatus) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Location.GpsStatus);
				}

				/// <java-name>
				/// sendExtraCommand
				/// </java-name>
				[Dot42.DexImport("sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool SendExtraCommand(string @string, string string1, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAllProviders
				/// </java-name>
				public global::Java.Util.IList<string> AllProviders
				{
				[Dot42.DexImport("getAllProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetAllProviders(); }
				}

		}

		/// <java-name>
		/// android/location/LocationProvider
		/// </java-name>
		[Dot42.DexImport("android/location/LocationProvider", AccessFlags = 1057)]
		public abstract partial class LocationProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OUT_OF_SERVICE
				/// </java-name>
				[Dot42.DexImport("OUT_OF_SERVICE", "I", AccessFlags = 25)]
				public const int OUT_OF_SERVICE = 0;
				/// <java-name>
				/// TEMPORARILY_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("TEMPORARILY_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int TEMPORARILY_UNAVAILABLE = 1;
				/// <java-name>
				/// AVAILABLE
				/// </java-name>
				[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
				public const int AVAILABLE = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LocationProvider() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// meetsCriteria
				/// </java-name>
				[Dot42.DexImport("meetsCriteria", "(Landroid/location/Criteria;)Z", AccessFlags = 1)]
				public virtual bool MeetsCriteria(global::Android.Location.Criteria criteria) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requiresNetwork
				/// </java-name>
				[Dot42.DexImport("requiresNetwork", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresNetwork() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requiresSatellite
				/// </java-name>
				[Dot42.DexImport("requiresSatellite", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresSatellite() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requiresCell
				/// </java-name>
				[Dot42.DexImport("requiresCell", "()Z", AccessFlags = 1025)]
				public abstract bool RequiresCell() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasMonetaryCost
				/// </java-name>
				[Dot42.DexImport("hasMonetaryCost", "()Z", AccessFlags = 1025)]
				public abstract bool HasMonetaryCost() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsAltitude
				/// </java-name>
				[Dot42.DexImport("supportsAltitude", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsAltitude() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsSpeed
				/// </java-name>
				[Dot42.DexImport("supportsSpeed", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsSpeed() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// supportsBearing
				/// </java-name>
				[Dot42.DexImport("supportsBearing", "()Z", AccessFlags = 1025)]
				public abstract bool SupportsBearing() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1025)]
				public abstract int GetPowerRequirement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1025)]
				public abstract int GetAccuracy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public int PowerRequirement
				{
				[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1025)]
						get{ return GetPowerRequirement(); }
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public int Accuracy
				{
				[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1025)]
						get{ return GetAccuracy(); }
				}

		}

}

