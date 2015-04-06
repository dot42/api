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
				/// clearLatitude
				/// </java-name>
				[Dot42.DexImport("clearLatitude", "()V", AccessFlags = 1)]
				public virtual void ClearLatitude() /* MethodBuilder.Create */ 
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
				public virtual global::Java.Util.Locale Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
				}

				/// <java-name>
				/// getMaxAddressLineIndex
				/// </java-name>
				public virtual int MaxAddressLineIndex
				{
						[Dot42.DexImport("getMaxAddressLineIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFeatureName
				/// </java-name>
				public virtual string FeatureName
				{
						[Dot42.DexImport("getFeatureName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setFeatureName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAdminArea
				/// </java-name>
				public virtual string AdminArea
				{
						[Dot42.DexImport("getAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubAdminArea
				/// </java-name>
				public virtual string SubAdminArea
				{
						[Dot42.DexImport("getSubAdminArea", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSubAdminArea", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLocality
				/// </java-name>
				public virtual string Locality
				{
						[Dot42.DexImport("getLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubLocality
				/// </java-name>
				public virtual string SubLocality
				{
						[Dot42.DexImport("getSubLocality", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSubLocality", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getThoroughfare
				/// </java-name>
				public virtual string Thoroughfare
				{
						[Dot42.DexImport("getThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubThoroughfare
				/// </java-name>
				public virtual string SubThoroughfare
				{
						[Dot42.DexImport("getSubThoroughfare", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSubThoroughfare", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPremises
				/// </java-name>
				public virtual string Premises
				{
						[Dot42.DexImport("getPremises", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPremises", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPostalCode
				/// </java-name>
				public virtual string PostalCode
				{
						[Dot42.DexImport("getPostalCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPostalCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCountryCode
				/// </java-name>
				public virtual string CountryCode
				{
						[Dot42.DexImport("getCountryCode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setCountryCode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCountryName
				/// </java-name>
				public virtual string CountryName
				{
						[Dot42.DexImport("getCountryName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setCountryName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasLatitude
				/// </java-name>
				public virtual bool HasLatitude
				{
						[Dot42.DexImport("hasLatitude", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				public virtual double Latitude
				{
						[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
						[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasLongitude
				/// </java-name>
				public virtual bool HasLongitude
				{
						[Dot42.DexImport("hasLongitude", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				public virtual double Longitude
				{
						[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
						[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPhone
				/// </java-name>
				public virtual string Phone
				{
						[Dot42.DexImport("getPhone", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPhone", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getUrl
				/// </java-name>
				public virtual string Url
				{
						[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
						[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ }
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
				public virtual int HorizontalAccuracy
				{
						[Dot42.DexImport("getHorizontalAccuracy", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHorizontalAccuracy", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getVerticalAccuracy
				/// </java-name>
				public virtual int VerticalAccuracy
				{
						[Dot42.DexImport("getVerticalAccuracy", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setVerticalAccuracy", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSpeedAccuracy
				/// </java-name>
				public virtual int SpeedAccuracy
				{
						[Dot42.DexImport("getSpeedAccuracy", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSpeedAccuracy", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBearingAccuracy
				/// </java-name>
				public virtual int BearingAccuracy
				{
						[Dot42.DexImport("getBearingAccuracy", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBearingAccuracy", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public virtual int Accuracy
				{
						[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAccuracy", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public virtual int PowerRequirement
				{
						[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPowerRequirement", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isCostAllowed
				/// </java-name>
				public virtual bool IsCostAllowed
				{
						[Dot42.DexImport("isCostAllowed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setCostAllowed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isAltitudeRequired
				/// </java-name>
				public virtual bool IsAltitudeRequired
				{
						[Dot42.DexImport("isAltitudeRequired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAltitudeRequired", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSpeedRequired
				/// </java-name>
				public virtual bool IsSpeedRequired
				{
						[Dot42.DexImport("isSpeedRequired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSpeedRequired", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isBearingRequired
				/// </java-name>
				public virtual bool IsBearingRequired
				{
						[Dot42.DexImport("isBearingRequired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBearingRequired", "(Z)V", AccessFlags = 1)]
						set{ }
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

				/// <java-name>
				/// isPresent
				/// </java-name>
				public static bool IsPresent
				{
						[Dot42.DexImport("isPresent", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
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
						get{ return default(int); }
				}

				/// <java-name>
				/// getSnr
				/// </java-name>
				public float Snr
				{
						[Dot42.DexImport("getSnr", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getElevation
				/// </java-name>
				public float Elevation
				{
						[Dot42.DexImport("getElevation", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getAzimuth
				/// </java-name>
				public float Azimuth
				{
						[Dot42.DexImport("getAzimuth", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// hasEphemeris
				/// </java-name>
				public bool HasEphemeris
				{
						[Dot42.DexImport("hasEphemeris", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasAlmanac
				/// </java-name>
				public bool HasAlmanac
				{
						[Dot42.DexImport("hasAlmanac", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
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
				public int TimeToFirstFix
				{
						[Dot42.DexImport("getTimeToFirstFix", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSatellites
				/// </java-name>
				public global::Java.Lang.IIterable<global::Android.Location.GpsSatellite> Satellites
				{
						[Dot42.DexImport("getSatellites", "()Ljava/lang/Iterable;", AccessFlags = 1, Signature = "()Ljava/lang/Iterable<Landroid/location/GpsSatellite;>;")]
						get{ return default(global::Java.Lang.IIterable<global::Android.Location.GpsSatellite>); }
				}

				/// <java-name>
				/// getMaxSatellites
				/// </java-name>
				public int MaxSatellites
				{
						[Dot42.DexImport("getMaxSatellites", "()I", AccessFlags = 1)]
						get{ return default(int); }
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
				/// removeAltitude
				/// </java-name>
				[Dot42.DexImport("removeAltitude", "()V", AccessFlags = 1)]
				public virtual void RemoveAltitude() /* MethodBuilder.Create */ 
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
				/// removeBearing
				/// </java-name>
				[Dot42.DexImport("removeBearing", "()V", AccessFlags = 1)]
				public virtual void RemoveBearing() /* MethodBuilder.Create */ 
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
				public virtual string Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTime
				/// </java-name>
				public virtual long Time
				{
						[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLatitude
				/// </java-name>
				public virtual double Latitude
				{
						[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
						[Dot42.DexImport("setLatitude", "(D)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLongitude
				/// </java-name>
				public virtual double Longitude
				{
						[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
						[Dot42.DexImport("setLongitude", "(D)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasAltitude
				/// </java-name>
				public virtual bool HasAltitude
				{
						[Dot42.DexImport("hasAltitude", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAltitude
				/// </java-name>
				public virtual double Altitude
				{
						[Dot42.DexImport("getAltitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
						[Dot42.DexImport("setAltitude", "(D)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasSpeed
				/// </java-name>
				public virtual bool HasSpeed
				{
						[Dot42.DexImport("hasSpeed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSpeed
				/// </java-name>
				public virtual float Speed
				{
						[Dot42.DexImport("getSpeed", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setSpeed", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasBearing
				/// </java-name>
				public virtual bool HasBearing
				{
						[Dot42.DexImport("hasBearing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getBearing
				/// </java-name>
				public virtual float Bearing
				{
						[Dot42.DexImport("getBearing", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setBearing", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasAccuracy
				/// </java-name>
				public virtual bool HasAccuracy
				{
						[Dot42.DexImport("hasAccuracy", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public virtual float Accuracy
				{
						[Dot42.DexImport("getAccuracy", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setAccuracy", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
						[Dot42.DexImport("setExtras", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ }
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
				public virtual global::Java.Util.IList<string> AllProviders
				{
						[Dot42.DexImport("getAllProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
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
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// hasMonetaryCost
				/// </java-name>
				public abstract bool HasMonetaryCost
				{
						[Dot42.DexImport("hasMonetaryCost", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPowerRequirement
				/// </java-name>
				public abstract int PowerRequirement
				{
						[Dot42.DexImport("getPowerRequirement", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAccuracy
				/// </java-name>
				public abstract int Accuracy
				{
						[Dot42.DexImport("getAccuracy", "()I", AccessFlags = 1025)]
						get;
				}

		}

}

