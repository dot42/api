// Copyright (C) 2014 dot42
//
// Original filename: Android.Hardware.cs
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
namespace Android.Hardware
{
		/// <summary>
		/// <para>SensorManager lets you access the device's sensors. Get an instance of this class by calling Context.getSystemService() with the argument android.content.Context#SENSOR_SERVICE. </para><para>Always make sure to disable sensors you don't need, especially when your activity is paused. Failing to do so can drain the battery in just a few hours. Note that the system will <b>not</b> disable sensors automatically when the screen turns off. </para><para>Note: Don't use this mechanism with a Trigger Sensor, have a look at TriggerEventListener. Sensor#TYPE_SIGNIFICANT_MOTION is an example of a trigger sensor. </para><para><pre>
		///    public class SensorActivity extends Activity, implements SensorEventListener {
		///        private final SensorManager mSensorManager;
		///        private final Sensor mAccelerometer;
		/// 
		///        public SensorActivity() {
		///            mSensorManager = (SensorManager)getSystemService(SENSOR_SERVICE);
		///            mAccelerometer = mSensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
		///        }
		/// 
		///        protected void onResume() {
		///            super.onResume();
		///            mSensorManager.registerListener(this, mAccelerometer, SensorManager.SENSOR_DELAY_NORMAL);
		///        }
		/// 
		///        protected void onPause() {
		///            super.onPause();
		///            mSensorManager.unregisterListener(this);
		///        }
		/// 
		///        public void onAccuracyChanged(Sensor sensor, int accuracy) {
		///        }
		/// 
		///        public void onSensorChanged(SensorEvent event) {
		///        }
		///    }
		///    </pre></para><para><para>SensorEventListener </para><simplesectsep></simplesectsep><para>SensorEvent </para><simplesectsep></simplesectsep><para>Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorManager", AccessFlags = 33)]
		public partial class SensorManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant describing an orientation sensor. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION = 1;
				/// <summary>
				/// <para>A constant describing an accelerometer. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("SENSOR_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int SENSOR_ACCELEROMETER = 2;
				/// <summary>
				/// <para>A constant describing a temperature sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("SENSOR_TEMPERATURE", "I", AccessFlags = 25)]
				public const int SENSOR_TEMPERATURE = 4;
				/// <summary>
				/// <para>A constant describing a magnetic sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int SENSOR_MAGNETIC_FIELD = 8;
				/// <summary>
				/// <para>A constant describing an ambient light sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_LIGHT
				/// </java-name>
				[Dot42.DexImport("SENSOR_LIGHT", "I", AccessFlags = 25)]
				public const int SENSOR_LIGHT = 16;
				/// <summary>
				/// <para>A constant describing a proximity sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("SENSOR_PROXIMITY", "I", AccessFlags = 25)]
				public const int SENSOR_PROXIMITY = 32;
				/// <summary>
				/// <para>A constant describing a Tricorder See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_TRICORDER
				/// </java-name>
				[Dot42.DexImport("SENSOR_TRICORDER", "I", AccessFlags = 25)]
				public const int SENSOR_TRICORDER = 64;
				/// <summary>
				/// <para>A constant describing an orientation sensor. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ORIENTATION_RAW
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION_RAW", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION_RAW = 128;
				/// <summary>
				/// <para>A constant that includes all sensors</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ALL
				/// </java-name>
				[Dot42.DexImport("SENSOR_ALL", "I", AccessFlags = 25)]
				public const int SENSOR_ALL = 127;
				/// <summary>
				/// <para>Smallest sensor ID</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MIN
				/// </java-name>
				[Dot42.DexImport("SENSOR_MIN", "I", AccessFlags = 25)]
				public const int SENSOR_MIN = 1;
				/// <summary>
				/// <para>Largest sensor ID</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MAX
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAX", "I", AccessFlags = 25)]
				public const int SENSOR_MAX = 64;
				/// <summary>
				/// <para>Index of the X value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_X
				/// </java-name>
				[Dot42.DexImport("DATA_X", "I", AccessFlags = 25)]
				public const int DATA_X = 0;
				/// <summary>
				/// <para>Index of the Y value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_Y
				/// </java-name>
				[Dot42.DexImport("DATA_Y", "I", AccessFlags = 25)]
				public const int DATA_Y = 1;
				/// <summary>
				/// <para>Index of the Z value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_Z
				/// </java-name>
				[Dot42.DexImport("DATA_Z", "I", AccessFlags = 25)]
				public const int DATA_Z = 2;
				/// <summary>
				/// <para>Offset to the untransformed values in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_INDEX
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_INDEX", "I", AccessFlags = 25)]
				public const int RAW_DATA_INDEX = 3;
				/// <summary>
				/// <para>Index of the untransformed X value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_X
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_X", "I", AccessFlags = 25)]
				public const int RAW_DATA_X = 3;
				/// <summary>
				/// <para>Index of the untransformed Y value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_Y
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Y", "I", AccessFlags = 25)]
				public const int RAW_DATA_Y = 4;
				/// <summary>
				/// <para>Index of the untransformed Z value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_Z
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Z", "I", AccessFlags = 25)]
				public const int RAW_DATA_Z = 5;
				/// <summary>
				/// <para>Standard gravity (g) on Earth. This value is equivalent to 1G </para>        
				/// </summary>
				/// <java-name>
				/// STANDARD_GRAVITY
				/// </java-name>
				[Dot42.DexImport("STANDARD_GRAVITY", "F", AccessFlags = 25)]
				public const float STANDARD_GRAVITY = 9.80665F;
				/// <summary>
				/// <para>Sun's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_SUN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SUN", "F", AccessFlags = 25)]
				public const float GRAVITY_SUN = 275F;
				/// <summary>
				/// <para>Mercury's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MERCURY
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MERCURY", "F", AccessFlags = 25)]
				public const float GRAVITY_MERCURY = 3.7F;
				/// <summary>
				/// <para>Venus' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_VENUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_VENUS", "F", AccessFlags = 25)]
				public const float GRAVITY_VENUS = 8.87F;
				/// <summary>
				/// <para>Earth's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_EARTH
				/// </java-name>
				[Dot42.DexImport("GRAVITY_EARTH", "F", AccessFlags = 25)]
				public const float GRAVITY_EARTH = 9.80665F;
				/// <summary>
				/// <para>The Moon's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MOON
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MOON", "F", AccessFlags = 25)]
				public const float GRAVITY_MOON = 1.6F;
				/// <summary>
				/// <para>Mars' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MARS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MARS", "F", AccessFlags = 25)]
				public const float GRAVITY_MARS = 3.71F;
				/// <summary>
				/// <para>Jupiter's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_JUPITER
				/// </java-name>
				[Dot42.DexImport("GRAVITY_JUPITER", "F", AccessFlags = 25)]
				public const float GRAVITY_JUPITER = 23.12F;
				/// <summary>
				/// <para>Saturn's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_SATURN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SATURN", "F", AccessFlags = 25)]
				public const float GRAVITY_SATURN = 8.96F;
				/// <summary>
				/// <para>Uranus' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_URANUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_URANUS", "F", AccessFlags = 25)]
				public const float GRAVITY_URANUS = 8.69F;
				/// <summary>
				/// <para>Neptune's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_NEPTUNE
				/// </java-name>
				[Dot42.DexImport("GRAVITY_NEPTUNE", "F", AccessFlags = 25)]
				public const float GRAVITY_NEPTUNE = 11F;
				/// <summary>
				/// <para>Pluto's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_PLUTO
				/// </java-name>
				[Dot42.DexImport("GRAVITY_PLUTO", "F", AccessFlags = 25)]
				public const float GRAVITY_PLUTO = 0.6F;
				/// <summary>
				/// <para>Gravity (estimate) on the first Death Star in Empire units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_DEATH_STAR_I
				/// </java-name>
				[Dot42.DexImport("GRAVITY_DEATH_STAR_I", "F", AccessFlags = 25)]
				public const float GRAVITY_DEATH_STAR_I = 3.530361E-07F;
				/// <summary>
				/// <para>Gravity on the island </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_THE_ISLAND
				/// </java-name>
				[Dot42.DexImport("GRAVITY_THE_ISLAND", "F", AccessFlags = 25)]
				public const float GRAVITY_THE_ISLAND = 4.815162F;
				/// <summary>
				/// <para>Maximum magnetic field on Earth's surface </para>        
				/// </summary>
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MAX
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MAX", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MAX = 60F;
				/// <summary>
				/// <para>Minimum magnetic field on Earth's surface </para>        
				/// </summary>
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MIN
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MIN", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MIN = 30F;
				/// <summary>
				/// <para>Maximum luminance of sunlight in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNLIGHT_MAX
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT_MAX", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT_MAX = 120000F;
				/// <summary>
				/// <para>luminance of sunlight in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNLIGHT
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT = 110000F;
				/// <summary>
				/// <para>luminance in shade in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SHADE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SHADE", "F", AccessFlags = 25)]
				public const float LIGHT_SHADE = 20000F;
				/// <summary>
				/// <para>luminance under an overcast sky in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_OVERCAST
				/// </java-name>
				[Dot42.DexImport("LIGHT_OVERCAST", "F", AccessFlags = 25)]
				public const float LIGHT_OVERCAST = 10000F;
				/// <summary>
				/// <para>luminance at sunrise in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNRISE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNRISE", "F", AccessFlags = 25)]
				public const float LIGHT_SUNRISE = 400F;
				/// <summary>
				/// <para>luminance under a cloudy sky in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_CLOUDY
				/// </java-name>
				[Dot42.DexImport("LIGHT_CLOUDY", "F", AccessFlags = 25)]
				public const float LIGHT_CLOUDY = 100F;
				/// <summary>
				/// <para>luminance at night with full moon in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_FULLMOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_FULLMOON", "F", AccessFlags = 25)]
				public const float LIGHT_FULLMOON = 0.25F;
				/// <summary>
				/// <para>luminance at night with no moon in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_NO_MOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_NO_MOON", "F", AccessFlags = 25)]
				public const float LIGHT_NO_MOON = 0.001F;
				/// <summary>
				/// <para>get sensor data as fast as possible </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_FASTEST
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_FASTEST", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_FASTEST = 0;
				/// <summary>
				/// <para>rate suitable for games </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_GAME
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_GAME", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_GAME = 1;
				/// <summary>
				/// <para>rate suitable for the user interface </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_UI
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_UI", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_UI = 2;
				/// <summary>
				/// <para>rate (default) suitable for screen orientation changes </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_NORMAL
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_NORMAL", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_NORMAL = 3;
				/// <summary>
				/// <para>The values returned by this sensor cannot be trusted, calibration is needed or the environment doesn't allow readings </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_UNRELIABLE
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_UNRELIABLE", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_UNRELIABLE = 0;
				/// <summary>
				/// <para>This sensor is reporting data with low accuracy, calibration with the environment is needed </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_LOW
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_LOW", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_LOW = 1;
				/// <summary>
				/// <para>This sensor is reporting data with an average level of accuracy, calibration with the environment may improve the readings </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_MEDIUM", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_MEDIUM = 2;
				/// <summary>
				/// <para>This sensor is reporting data with maximum accuracy </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_HIGH
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_HIGH", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_HIGH = 3;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_X", "I", AccessFlags = 25)]
				public const int AXIS_X = 1;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_Y", "I", AccessFlags = 25)]
				public const int AXIS_Y = 2;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_Z", "I", AccessFlags = 25)]
				public const int AXIS_Z = 3;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_X", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_X = 129;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Y", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Y = 130;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Z", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Z = 131;
				/// <summary>
				/// <para>{} </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SensorManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#getSensorList(int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>available sensors. </para>
				/// </returns>
				/// <java-name>
				/// getSensors
				/// </java-name>
				[Dot42.DexImport("getSensors", "()I", AccessFlags = 1)]
				public virtual int GetSensors() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Use this method to get the list of available sensors of a certain type. Make multiple calls to get sensors of different types or use Sensor.TYPE_ALL to get all the sensors.</para><para><para>getDefaultSensor(int) </para><simplesectsep></simplesectsep><para>Sensor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of sensors matching the asked type.</para>
				/// </returns>
				/// <java-name>
				/// getSensorList
				/// </java-name>
				[Dot42.DexImport("getSensorList", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/hardware/Sensor;>;")]
				public virtual global::Java.Util.IList<global::Android.Hardware.Sensor> GetSensorList(int type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Hardware.Sensor>);
				}

				/// <summary>
				/// <para>Use this method to get the default sensor for a given type. Note that the returned sensor could be a composite sensor, and its data could be averaged or filtered. If you need to access the raw sensors use getSensorList.</para><para><para>getSensorList(int) </para><simplesectsep></simplesectsep><para>Sensor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default sensors matching the asked type.</para>
				/// </returns>
				/// <java-name>
				/// getDefaultSensor
				/// </java-name>
				[Dot42.DexImport("getDefaultSensor", "(I)Landroid/hardware/Sensor;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Sensor GetDefaultSensor(int type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Sensor);
				}

				/// <summary>
				/// <para>Registers a listener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener listener, int sensors) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a SensorListener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;II)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener listener, int sensors, int rate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unregisters a listener for the sensors with which it is registered.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener, Sensor) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;I)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener listener, int sensors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for all sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for the sensors with which it is registered.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener, Sensor) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for all sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a SensorListener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensors, int rate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a SensorEventListener for the given sensor.</para><para>Note: Don't use this method with a one shot trigger sensor such as Sensor#TYPE_SIGNIFICANT_MOTION. Use requestTriggerSensor(TriggerEventListener, Sensor) instead. </para><para><para>registerListener(SensorEventListener, Sensor, int) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener, Sensor)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the sensor is supported and successfully enabled.</para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Hand" +
    "ler;)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensor, int rate, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the inclination matrix <b>I</b> as well as the rotation matrix <b>R</b> transforming a vector from the device coordinate system to the world's coordinate system which is defined as a direct orthonormal basis, where: </para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points East). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards the magnetic North Pole. </para></li><li><para>Z points towards the sky and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para><hruler></hruler> </para><para>By definition: </para><para>[0 0 g] = <b>R</b> * <b>gravity</b> (g = magnitude of gravity) </para><para>[0 m 0] = <b>I</b> * <b>R</b> * <b>geomagnetic</b> (m = magnitude of geomagnetic field) </para><para><b>R</b> is the identity matrix when the device is aligned with the world's coordinate system, that is, when the device's X axis points toward East, the Y axis points to the North Pole and the device is facing the sky.</para><para><b>I</b> is a rotation matrix transforming the geomagnetic vector into the same coordinate space as gravity (the world's coordinate space). <b>I</b> is a simple rotation around the X axis. The inclination angle in radians can be computed with getInclination. <hruler></hruler></para><para>Each matrix is returned either as a 3x3 or 4x4 row-major matrix depending on the length of the passed array: </para><para>&lt;u&gt;If the array length is 16:&lt;/u&gt;</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]   M[ 3]  \
				///          |  M[ 4]   M[ 5]   M[ 6]   M[ 7]  |
				///          |  M[ 8]   M[ 9]   M[10]   M[11]  |
				///          \  M[12]   M[13]   M[14]   M[15]  /
				///       </pre></para><para>This matrix is ready to be used by OpenGL ES's glLoadMatrixf(float[], int). </para><para>Note that because OpenGL matrices are column-major matrices you must transpose the matrix before using it. However, since the matrix is a rotation matrix, its transpose is also its inverse, conveniently, it is often the inverse of the rotation that is needed for rendering; it can therefore be used with OpenGL ES directly. </para><para>Also note that the returned matrices always have this form:</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]   0  \
				///          |  M[ 4]   M[ 5]   M[ 6]   0  |
				///          |  M[ 8]   M[ 9]   M[10]   0  |
				///          \      0       0       0   1  /
				///       </pre></para><para>&lt;u&gt;If the array length is 9:&lt;/u&gt;</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]  \
				///          |  M[ 3]   M[ 4]   M[ 5]  |
				///          \  M[ 6]   M[ 7]   M[ 8]  /
				///       </pre></para><para><hruler></hruler> </para><para>The inverse of each matrix can be computed easily by taking its transpose.</para><para>The matrices returned by this function are meaningful only when the device is not free-falling and it is not close to the magnetic north. If the device is accelerating, or placed into a strong magnetic field, the returned matrices may be inaccurate.</para><para></para><para></para><para></para><para><para>getInclination(float[]) </para><simplesectsep></simplesectsep><para>getOrientation(float[], float[]) </para><simplesectsep></simplesectsep><para>remapCoordinateSystem(float[], int, int, float[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> on success, <code>false</code> on failure (for instance, if the device is in free fall). On failure the output matrices are not modified.</para>
				/// </returns>
				/// <java-name>
				/// getRotationMatrix
				/// </java-name>
				[Dot42.DexImport("getRotationMatrix", "([F[F[F[F)Z", AccessFlags = 9)]
				public static bool GetRotationMatrix(float[] R, float[] I, float[] gravity, float[] geomagnetic) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the geomagnetic inclination angle in radians from the inclination matrix <b>I</b> returned by getRotationMatrix.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para><simplesectsep></simplesectsep><para>getOrientation(float[], float[]) </para><simplesectsep></simplesectsep><para>GeomagneticField </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The geomagnetic inclination angle in radians.</para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				[Dot42.DexImport("getInclination", "([F)F", AccessFlags = 9)]
				public static float GetInclination(float[] I) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Rotates the supplied rotation matrix so it is expressed in a different coordinate system. This is typically used when an application needs to compute the three orientation angles of the device (see getOrientation) in a different coordinate system. </para><para>When the rotation matrix is used for drawing (for instance with OpenGL ES), it usually <b>doesn't need</b> to be transformed by this function, unless the screen is physically rotated, in which case you can use Display.getRotation() to retrieve the current rotation of the screen. Note that because the user is generally free to rotate their screen, you often should consider the rotation in deciding the parameters to use here. </para><para>&lt;u&gt;Examples:&lt;/u&gt; </para><para><ul><li><para>Using the camera (Y axis along the camera's axis) for an augmented reality application where the rotation angles are needed:</para><para></para><para><ul><li></li></ul><code>remapCoordinateSystem(inR, AXIS_X, AXIS_Z, outR);</code> </para></li></ul></para><para>Using the device as a mechanical compass when rotation is Surface.ROTATION_90:</para><para><ul><li></li></ul><code>remapCoordinateSystem(inR, AXIS_Y, AXIS_MINUS_X, outR);</code>  </para><para>Beware of the above example. This call is needed only to account for a rotation from its natural orientation when calculating the rotation angles (see getOrientation). If the rotation matrix is also used for rendering, it may not need to be transformed, for instance if your Activity is running in landscape mode. </para><para>Since the resulting coordinate system is orthonormal, only two axes need to be specified.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> on success. <code>false</code> if the input parameters are incorrect, for instance if X and Y define the same axis. Or if inR and outR don't have the same length.</para>
				/// </returns>
				/// <java-name>
				/// remapCoordinateSystem
				/// </java-name>
				[Dot42.DexImport("remapCoordinateSystem", "([FII[F)Z", AccessFlags = 9)]
				public static bool RemapCoordinateSystem(float[] inR, int X, int Y, float[] outR) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the device's orientation based on the rotation matrix. </para><para>When it returns, the array values is filled with the result: <ul><li><para>values[0]: <b>azimuth</b>, rotation around the Z axis. </para></li><li><para>values[1]: <b>pitch</b>, rotation around the X axis. </para></li><li><para>values[2]: <b>roll</b>, rotation around the Y axis. </para></li></ul></para><para>The reference coordinate-system used is different from the world coordinate-system defined for the rotation matrix:</para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points West). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards the magnetic North Pole. </para></li><li><para>Z points towards the center of the Earth and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para>All three angles above are in <b>radians</b> and <b>positive</b> in the <b>counter-clockwise</b> direction.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para><simplesectsep></simplesectsep><para>GeomagneticField </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array values passed as argument.</para>
				/// </returns>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "([F[F)[F", AccessFlags = 9)]
				public static float[] GetOrientation(float[] R, float[] values) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#getSensorList(int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>available sensors. </para>
				/// </returns>
				/// <java-name>
				/// getSensors
				/// </java-name>
				public int Sensors
				{
				[Dot42.DexImport("getSensors", "()I", AccessFlags = 1)]
						get{ return GetSensors(); }
				}

		}

		/// <summary>
		/// <para>The Camera class is used to set image capture settings, start/stop preview, snap pictures, and retrieve frames for encoding for video. This class is a client for the Camera service, which manages the actual camera hardware.</para><para>To access the device camera, you must declare the android.Manifest.permission#CAMERA permission in your Android Manifest. Also be sure to include the  manifest element to declare camera features used by your application. For example, if you use the camera and auto-focus feature, your Manifest should include the following:</para><para><pre> &lt;uses-permission android:name="android.permission.CAMERA" /&gt;
		///    &lt;uses-feature android:name="android.hardware.camera" /&gt;
		///    &lt;uses-feature android:name="android.hardware.camera.autofocus" /&gt;</pre></para><para>To take pictures with this class, use the following steps:</para><para><ol><li><para>Obtain an instance of Camera from open(int).</para><para></para></li><li><para>Get existing (default) settings with getParameters().</para><para></para></li><li><para>If necessary, modify the returned Camera.Parameters object and call setParameters(Camera.Parameters).</para><para></para></li><li><para>If desired, call setDisplayOrientation(int).</para><para></para></li><li><para><b>Important</b>: Pass a fully initialized SurfaceHolder to setPreviewDisplay(SurfaceHolder). Without a surface, the camera will be unable to start the preview.</para><para></para></li><li><para><b>Important</b>: Call startPreview() to start updating the preview surface. Preview must be started before you can take a picture.</para><para></para></li><li><para>When you want, call Camera.PictureCallback, Camera.PictureCallback, Camera.PictureCallback) to capture a photo. Wait for the callbacks to provide the actual image data.</para><para></para></li><li><para>After taking a picture, preview display will have stopped. To take more photos, call startPreview() again first.</para><para></para></li><li><para>Call stopPreview() to stop updating the preview surface.</para><para></para></li><li><para><b>Important:</b> Call release() to release the camera for use by other applications. Applications should release the camera immediately in android.app.Activity#onPause() (and re-open() it in android.app.Activity#onResume()). </para></li></ol></para><para>To quickly switch to video recording mode, use these steps:</para><para><ol><li><para>Obtain and initialize a Camera and start preview as described above.</para><para></para></li><li><para>Call unlock() to allow the media process to access the camera.</para><para></para></li><li><para>Pass the camera to android.media.MediaRecorder#setCamera(Camera). See android.media.MediaRecorder information about video recording.</para><para></para></li><li><para>When finished recording, call reconnect() to re-acquire and re-lock the camera.</para><para></para></li><li><para>If desired, restart preview and take more photos or videos.</para><para></para></li><li><para>Call stopPreview() and release() as described above. </para></li></ol></para><para>This class is not thread-safe, and is meant for use from one event thread. Most long-running operations (preview, focus, photo capture, etc) happen asynchronously and invoke callbacks as necessary. Callbacks will be invoked on the event thread open(int) was called from. This class's methods must never be called from multiple threads at once.</para><para><b>Caution:</b> Different Android-powered devices may have different hardware specifications, such as megapixel ratings and auto-focus capabilities. In order for your application to be compatible with more devices, you should not make assumptions about the device camera specifications.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using cameras, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/Camera
		/// </java-name>
		[Dot42.DexImport("android/hardware/Camera", AccessFlags = 33)]
		public partial class Camera
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Unspecified camera error. <para>Camera.ErrorCallback </para></para>        
				/// </summary>
				/// <java-name>
				/// CAMERA_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_UNKNOWN = 1;
				/// <summary>
				/// <para>Media server died. In this case, the application must release the Camera object and instantiate a new one. <para>Camera.ErrorCallback </para></para>        
				/// </summary>
				/// <java-name>
				/// CAMERA_ERROR_SERVER_DIED
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_SERVER_DIED", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_SERVER_DIED = 100;
				/// <summary>
				/// <para>An empty Camera for testing purpose. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Camera() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new Camera object to access the first back-facing camera on the device. If the device does not have a back-facing camera, this returns null. <para>open(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Landroid/hardware/Camera;", AccessFlags = 9)]
				public static global::Android.Hardware.Camera Open() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Camera() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Disconnects and releases the Camera object resources.</para><para>You must call this as soon as you're done with the Camera object.</para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 17)]
				public void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Re-locks the camera to prevent other processes from accessing it. Camera objects are locked by default unless unlock() is called. Normally reconnect() is used instead.</para><para>Since API level 14, camera is automatically locked for applications in android.media.MediaRecorder#start(). Applications can use the camera (ex: zoom) after recording starts. There is no need to call this after recording starts or stops.</para><para>If you are not recording video, you probably do not need this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 273)]
				public void Lock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unlocks the camera to allow another process to access it. Normally, the camera is locked to the process with an active Camera object until release() is called. To allow rapid handoff between processes, you can call this method to release the camera temporarily for another process to use; once the other process is done you can call reconnect() to reclaim the camera.</para><para>This must be done before calling android.media.MediaRecorder#setCamera(Camera). This cannot be called after recording starts.</para><para>If you are not recording video, you probably do not need this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 273)]
				public void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewDisplay
				/// </java-name>
				[Dot42.DexImport("setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 17)]
				public void SetPreviewDisplay(global::Android.View.ISurfaceHolder surface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts capturing and drawing preview frames to the screen. Preview will not actually start until a surface is supplied with setPreviewDisplay(SurfaceHolder) or setPreviewTexture(SurfaceTexture).</para><para>If setPreviewCallback(Camera.PreviewCallback), setOneShotPreviewCallback(Camera.PreviewCallback), or setPreviewCallbackWithBuffer(Camera.PreviewCallback) were called, Camera.PreviewCallback#onPreviewFrame(byte[], Camera) will be called when preview data becomes available. </para>        
				/// </summary>
				/// <java-name>
				/// startPreview
				/// </java-name>
				[Dot42.DexImport("startPreview", "()V", AccessFlags = 273)]
				public void StartPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops capturing and drawing preview frames to the surface, and resets the camera for a future call to startPreview(). </para>        
				/// </summary>
				/// <java-name>
				/// stopPreview
				/// </java-name>
				[Dot42.DexImport("stopPreview", "()V", AccessFlags = 273)]
				public void StopPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Installs a callback to be invoked for every preview frame in addition to displaying them on the screen. The callback will be repeatedly called for as long as preview is active. This method can be called at any time, even while preview is live. Any other preview callbacks are overridden.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Installs a callback to be invoked for the next preview frame in addition to displaying it on the screen. After one invocation, the callback is cleared. This method can be called any time, even when preview is live. Any other preview callbacks are overridden.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// setOneShotPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetOneShotPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts camera auto-focus and registers a callback function to run when the camera is focused. This method is only valid when preview is active (between startPreview() and before stopPreview()).</para><para>Callers should check android.hardware.Camera.Parameters#getFocusMode() to determine if this method should be called. If the camera does not support auto-focus, it is a no-op and AutoFocusCallback#onAutoFocus(boolean, Camera) callback will be called immediately.</para><para>If your application should not be installed on devices without auto-focus, you must declare that your application uses auto-focus with the  manifest element.</para><para>If the current flash mode is not android.hardware.Camera.Parameters#FLASH_MODE_OFF, flash may be fired during auto-focus, depending on the driver and camera hardware.</para><para>Auto-exposure lock android.hardware.Camera.Parameters#getAutoExposureLock() and auto-white balance locks android.hardware.Camera.Parameters#getAutoWhiteBalanceLock() do not change during and after autofocus. But auto-focus routine may stop auto-exposure and auto-white balance transiently during focusing.</para><para>Stopping preview with stopPreview(), or triggering still image capture with Camera.PictureCallback, Camera.PictureCallback), will not change the the focus position. Applications must call cancelAutoFocus to reset the focus.</para><para>If autofocus is successful, consider using android.media.MediaActionSound to properly play back an autofocus success sound to the user.</para><para><para>cancelAutoFocus() </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoExposureLock(boolean) </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoWhiteBalanceLock(boolean) </para><simplesectsep></simplesectsep><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// autoFocus
				/// </java-name>
				[Dot42.DexImport("autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V", AccessFlags = 17)]
				public void AutoFocus(global::Android.Hardware.Camera.IAutoFocusCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels any auto-focus function in progress. Whether or not auto-focus is currently in progress, this function will return the focus position to the default. If the camera does not support auto-focus, this is a no-op.</para><para><para>autoFocus(Camera.AutoFocusCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// cancelAutoFocus
				/// </java-name>
				[Dot42.DexImport("cancelAutoFocus", "()V", AccessFlags = 17)]
				public void CancelAutoFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Equivalent to takePicture(shutter, raw, null, jpeg).</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutter, global::Android.Hardware.Camera.IPictureCallback raw, global::Android.Hardware.Camera.IPictureCallback jpeg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Triggers an asynchronous image capture. The camera service will initiate a series of callbacks to the application as the image capture progresses. The shutter callback occurs after the image is captured. This can be used to trigger a sound to let the user know that image has been captured. The raw callback occurs when the raw image data is available (NOTE: the data will be null if there is no raw image callback buffer available or the raw image callback buffer is not large enough to hold the raw image). The postview callback occurs when a scaled, fully processed postview image is available (NOTE: not all hardware supports this). The jpeg callback occurs when the compressed image is available. If the application does not need a particular callback, a null can be passed instead of a callback method.</para><para>This method is only valid when preview is active (after startPreview()). Preview will be stopped after the image is taken; callers must call startPreview() again if they want to re-start preview or take more pictures. This should not be called between android.media.MediaRecorder#start() and android.media.MediaRecorder#stop().</para><para>After calling this method, you must not call startPreview() or take another picture until the JPEG callback has returned.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallb" +
    "ack;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutter, global::Android.Hardware.Camera.IPictureCallback raw, global::Android.Hardware.Camera.IPictureCallback postview, global::Android.Hardware.Camera.IPictureCallback jpeg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a callback to be invoked when an error occurs. </para>        
				/// </summary>
				/// <java-name>
				/// setErrorCallback
				/// </java-name>
				[Dot42.DexImport("setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V", AccessFlags = 17)]
				public void SetErrorCallback(global::Android.Hardware.Camera.IErrorCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the settings for this Camera service.</para><para><para>getParameters() </para></para>        
				/// </summary>
				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "(Landroid/hardware/Camera$Parameters;)V", AccessFlags = 1)]
				public virtual void SetParameters(global::Android.Hardware.Camera.Parameters @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current settings for this Camera service. If modifications are made to the returned Parameters, they must be passed to setParameters(Camera.Parameters) to take effect.</para><para><para>setParameters(Camera.Parameters) </para></para>        
				/// </summary>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Landroid/hardware/Camera$Parameters;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Camera.Parameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera.Parameters);
				}

				/// <summary>
				/// <para>Camera service settings.</para><para>To make camera parameters take effect, applications have to call Camera#setParameters(Camera.Parameters). For example, after Camera.Parameters#setWhiteBalance is called, white balance is not actually changed until Camera#setParameters(Camera.Parameters) is called with the changed parameters object.</para><para>Different devices may have different camera capabilities, such as picture size or flash modes. The application should query the camera capabilities before setting parameters. For example, the application should call Camera.Parameters#getSupportedColorEffects() before calling Camera.Parameters#setColorEffect(String). If the camera does not support color effects, Camera.Parameters#getSupportedColorEffects() will return null. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Parameters
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Parameters", AccessFlags = 1)]
				public partial class Parameters
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// WHITE_BALANCE_AUTO
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_AUTO = "auto";
						/// <java-name>
						/// WHITE_BALANCE_INCANDESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_INCANDESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_INCANDESCENT = "incandescent";
						/// <java-name>
						/// WHITE_BALANCE_FLUORESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_FLUORESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_FLUORESCENT = "fluorescent";
						/// <java-name>
						/// WHITE_BALANCE_WARM_FLUORESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_WARM_FLUORESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_WARM_FLUORESCENT = "warm-fluorescent";
						/// <java-name>
						/// WHITE_BALANCE_DAYLIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_DAYLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_DAYLIGHT = "daylight";
						/// <java-name>
						/// WHITE_BALANCE_CLOUDY_DAYLIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_CLOUDY_DAYLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_CLOUDY_DAYLIGHT = "cloudy-daylight";
						/// <java-name>
						/// WHITE_BALANCE_TWILIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_TWILIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_TWILIGHT = "twilight";
						/// <java-name>
						/// WHITE_BALANCE_SHADE
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_SHADE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_SHADE = "shade";
						/// <java-name>
						/// EFFECT_NONE
						/// </java-name>
						[Dot42.DexImport("EFFECT_NONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_NONE = "none";
						/// <java-name>
						/// EFFECT_MONO
						/// </java-name>
						[Dot42.DexImport("EFFECT_MONO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_MONO = "mono";
						/// <java-name>
						/// EFFECT_NEGATIVE
						/// </java-name>
						[Dot42.DexImport("EFFECT_NEGATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_NEGATIVE = "negative";
						/// <java-name>
						/// EFFECT_SOLARIZE
						/// </java-name>
						[Dot42.DexImport("EFFECT_SOLARIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_SOLARIZE = "solarize";
						/// <java-name>
						/// EFFECT_SEPIA
						/// </java-name>
						[Dot42.DexImport("EFFECT_SEPIA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_SEPIA = "sepia";
						/// <java-name>
						/// EFFECT_POSTERIZE
						/// </java-name>
						[Dot42.DexImport("EFFECT_POSTERIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_POSTERIZE = "posterize";
						/// <java-name>
						/// EFFECT_WHITEBOARD
						/// </java-name>
						[Dot42.DexImport("EFFECT_WHITEBOARD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_WHITEBOARD = "whiteboard";
						/// <java-name>
						/// EFFECT_BLACKBOARD
						/// </java-name>
						[Dot42.DexImport("EFFECT_BLACKBOARD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_BLACKBOARD = "blackboard";
						/// <java-name>
						/// EFFECT_AQUA
						/// </java-name>
						[Dot42.DexImport("EFFECT_AQUA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_AQUA = "aqua";
						/// <java-name>
						/// ANTIBANDING_AUTO
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_AUTO = "auto";
						/// <java-name>
						/// ANTIBANDING_50HZ
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_50HZ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_50HZ = "50hz";
						/// <java-name>
						/// ANTIBANDING_60HZ
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_60HZ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_60HZ = "60hz";
						/// <java-name>
						/// ANTIBANDING_OFF
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_OFF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_OFF = "off";
						/// <summary>
						/// <para>Flash will not be fired. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_OFF
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_OFF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_OFF = "off";
						/// <summary>
						/// <para>Flash will be fired automatically when required. The flash may be fired during preview, auto-focus, or snapshot depending on the driver. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Flash will always be fired during snapshot. The flash may also be fired during preview or auto-focus depending on the driver. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_ON
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_ON = "on";
						/// <summary>
						/// <para>Flash will be fired in red-eye reduction mode. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_RED_EYE
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_RED_EYE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_RED_EYE = "red-eye";
						/// <summary>
						/// <para>Constant emission of light during preview, auto-focus and snapshot. This can also be used for video recording. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_TORCH
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_TORCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_TORCH = "torch";
						/// <summary>
						/// <para>Scene mode is off. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Take photos of fast moving objects. Same as SCENE_MODE_SPORTS. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_ACTION
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_ACTION = "action";
						/// <summary>
						/// <para>Take people pictures. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PORTRAIT = "portrait";
						/// <summary>
						/// <para>Take pictures on distant objects. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_LANDSCAPE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_LANDSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_LANDSCAPE = "landscape";
						/// <summary>
						/// <para>Take photos at night. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_NIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT = "night";
						/// <summary>
						/// <para>Take people pictures at night. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_NIGHT_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT_PORTRAIT = "night-portrait";
						/// <summary>
						/// <para>Take photos in a theater. Flash light is off. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_THEATRE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_THEATRE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_THEATRE = "theatre";
						/// <summary>
						/// <para>Take pictures on the beach. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_BEACH
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_BEACH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_BEACH = "beach";
						/// <summary>
						/// <para>Take pictures on the snow. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SNOW
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SNOW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SNOW = "snow";
						/// <summary>
						/// <para>Take sunset photos. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SUNSET
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SUNSET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SUNSET = "sunset";
						/// <summary>
						/// <para>Avoid blurry pictures (for example, due to hand shake). </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_STEADYPHOTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_STEADYPHOTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_STEADYPHOTO = "steadyphoto";
						/// <summary>
						/// <para>For shooting firework displays. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_FIREWORKS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_FIREWORKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_FIREWORKS = "fireworks";
						/// <summary>
						/// <para>Take photos of fast moving objects. Same as SCENE_MODE_ACTION. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SPORTS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SPORTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SPORTS = "sports";
						/// <summary>
						/// <para>Take indoor low-light shot. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_PARTY
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PARTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PARTY = "party";
						/// <summary>
						/// <para>Capture the naturally warm color of scenes lit by candles. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_CANDLELIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_CANDLELIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_CANDLELIGHT = "candlelight";
						/// <summary>
						/// <para>Auto-focus mode. Applications should call autoFocus(AutoFocusCallback) to start the focus in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Focus is set at infinity. Applications should not call autoFocus(AutoFocusCallback) in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_INFINITY
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_INFINITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_INFINITY = "infinity";
						/// <summary>
						/// <para>Macro (close-up) focus mode. Applications should call autoFocus(AutoFocusCallback) to start the focus in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_MACRO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_MACRO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_MACRO = "macro";
						/// <summary>
						/// <para>Focus is fixed. The camera is always in this mode if the focus is not adjustable. If the camera has auto-focus, this mode can fix the focus, which is usually at hyperfocal distance. Applications should not call autoFocus(AutoFocusCallback) in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_FIXED
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_FIXED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_FIXED = "fixed";
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/hardware/Camera;", AccessFlags = 4112)]
						internal readonly global::Android.Hardware.Camera This_0;
						[Dot42.DexImport("<init>", "(Landroid/hardware/Camera;)V", AccessFlags = 0)]
						internal Parameters(global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Creates a single string with all the parameters set in this Parameters object. </para><para>The unflatten(String) method does the reverse.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a String with all values from this Parameters object, in semi-colon delimited key-value pairs </para>
						/// </returns>
						/// <java-name>
						/// flatten
						/// </java-name>
						[Dot42.DexImport("flatten", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Flatten() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Takes a flattened string of parameters and adds each one to this Parameters object. </para><para>The flatten() method does the reverse.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unflatten
						/// </java-name>
						[Dot42.DexImport("unflatten", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Unflatten(string flattened) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// remove
						/// </java-name>
						[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Remove(string key) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Set(string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Ljava/lang/String;I)V", AccessFlags = 1)]
						public virtual void Set(string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the value of a String parameter.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the String value of the parameter </para>
						/// </returns>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Get(string key) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Returns the value of an integer parameter.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the int value of the parameter </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
						public virtual int GetInt(string key) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets the dimensions for preview pictures. If the preview has already started, applications should stop the preview first before changing preview size.</para><para>The sides of width and height are based on camera orientation. That is, the preview size is the size before it is rotated by display orientation. So applications need to consider the display orientation while setting preview size. For example, suppose the camera supports both 480x320 and 320x480 preview sizes. The application wants a 3:2 preview ratio. If the display orientation is set to 0 or 180, preview size should be set to 480x320. If the display orientation is set to 90 or 270, preview size should be set to 320x480. The display orientation should also be considered while setting picture size and thumbnail size.</para><para><para>setDisplayOrientation(int) </para><simplesectsep></simplesectsep><para>getCameraInfo(int, CameraInfo) </para><simplesectsep></simplesectsep><para>setPictureSize(int, int) </para><simplesectsep></simplesectsep><para>setJpegThumbnailSize(int, int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewSize
						/// </java-name>
						[Dot42.DexImport("setPreviewSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPreviewSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions setting for preview pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the width and height setting for the preview picture </para>
						/// </returns>
						/// <java-name>
						/// getPreviewSize
						/// </java-name>
						[Dot42.DexImport("getPreviewSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetPreviewSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Gets the supported preview sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedPreviewSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Sets the dimensions for EXIF thumbnail in Jpeg picture. If applications set both width and height to 0, EXIF will not contain thumbnail.</para><para>Applications need to consider the display orientation. See setPreviewSize(int,int) for reference.</para><para><para>setPreviewSize(int,int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegThumbnailSize
						/// </java-name>
						[Dot42.DexImport("setJpegThumbnailSize", "(II)V", AccessFlags = 1)]
						public virtual void SetJpegThumbnailSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions for EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for the EXIF thumbnails </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailSize
						/// </java-name>
						[Dot42.DexImport("getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetJpegThumbnailSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Sets the quality of the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegThumbnailQuality
						/// </java-name>
						[Dot42.DexImport("setJpegThumbnailQuality", "(I)V", AccessFlags = 1)]
						public virtual void SetJpegThumbnailQuality(int quality) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the quality setting for the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG quality setting of the EXIF thumbnail. </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailQuality
						/// </java-name>
						[Dot42.DexImport("getJpegThumbnailQuality", "()I", AccessFlags = 1)]
						public virtual int GetJpegThumbnailQuality() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets Jpeg quality of captured picture.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegQuality
						/// </java-name>
						[Dot42.DexImport("setJpegQuality", "(I)V", AccessFlags = 1)]
						public virtual void SetJpegQuality(int quality) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the quality setting for the JPEG picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG picture quality setting. </para>
						/// </returns>
						/// <java-name>
						/// getJpegQuality
						/// </java-name>
						[Dot42.DexImport("getJpegQuality", "()I", AccessFlags = 1)]
						public virtual int GetJpegQuality() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by setPreviewFpsRange(int,int) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewFrameRate
						/// </java-name>
						[Dot42.DexImport("setPreviewFrameRate", "(I)V", AccessFlags = 1)]
						public virtual void SetPreviewFrameRate(int fps) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the setting for the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getPreviewFpsRange(int[]) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>the frame rate setting (frames per second) </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFrameRate
						/// </java-name>
						[Dot42.DexImport("getPreviewFrameRate", "()I", AccessFlags = 1)]
						public virtual int GetPreviewFrameRate() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported preview frame rates.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getSupportedPreviewFpsRange() </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview frame rates. null if preview frame rate setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFrameRates
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewFrameRates", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPreviewFrameRates() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the image format for preview pictures. </para><para>If this is never called, the default format will be android.graphics.ImageFormat#NV21, which uses the NV21 encoding format.</para><para>Use Parameters#getSupportedPreviewFormats to get a list of the available preview formats.</para><para>It is strongly recommended that either android.graphics.ImageFormat#NV21 or android.graphics.ImageFormat#YV12 is used, since they are supported by all camera devices.</para><para>For YV12, the image buffer that is received is not necessarily tightly packed, as there may be padding at the end of each row of pixel data, as described in android.graphics.ImageFormat#YV12. For camera callback data, it can be assumed that the stride of the Y and UV data is the smallest possible that meets the alignment requirements. That is, if the preview size is <b>width x height</b>, then the following equations describe the buffer index for the beginning of row <b>y</b> for the Y plane and row <b>c</b> for the U and V planes:</para><para><c>           &lt;pre&gt;           yStride   = (int) ceil(width / 16.0) * 16;           uvStride  = (int) ceil( (yStride / 2) / 16.0) * 16;           ySize     = yStride * height;           uvSize    = uvStride * height / 2;           yRowIndex = yStride * y;           uRowIndex = ySize + uvSize + uvStride * c;           vRowIndex = ySize + uvStride * c;           size      = ySize + uvSize * 2;&lt;/pre&gt;</c></para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::getSupportedPreviewFormats </para></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewFormat
						/// </java-name>
						[Dot42.DexImport("setPreviewFormat", "(I)V", AccessFlags = 1)]
						public virtual void SetPreviewFormat(int pixel_format) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the image format for preview frames got from PreviewCallback.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preview format. </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFormat
						/// </java-name>
						[Dot42.DexImport("getPreviewFormat", "()I", AccessFlags = 1)]
						public virtual int GetPreviewFormat() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported preview formats. android.graphics.ImageFormat#NV21 is always supported. android.graphics.ImageFormat#YV12 is always supported since API level 12.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFormats
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPreviewFormats() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the dimensions for pictures.</para><para>Applications need to consider the display orientation. See setPreviewSize(int,int) for reference.</para><para><para>setPreviewSize(int,int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setPictureSize
						/// </java-name>
						[Dot42.DexImport("setPictureSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPictureSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimension setting for pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for pictures </para>
						/// </returns>
						/// <java-name>
						/// getPictureSize
						/// </java-name>
						[Dot42.DexImport("getPictureSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetPictureSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Gets the supported picture sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported picture sizes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedPictureSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedPictureSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Sets the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <java-name>
						/// setPictureFormat
						/// </java-name>
						[Dot42.DexImport("setPictureFormat", "(I)V", AccessFlags = 1)]
						public virtual void SetPictureFormat(int pixel_format) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the picture format </para>
						/// </returns>
						/// <java-name>
						/// getPictureFormat
						/// </java-name>
						[Dot42.DexImport("getPictureFormat", "()I", AccessFlags = 1)]
						public virtual int GetPictureFormat() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported picture formats.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>supported picture formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureFormats
						/// </java-name>
						[Dot42.DexImport("getSupportedPictureFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPictureFormats() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the clockwise rotation angle in degrees relative to the orientation of the camera. This affects the pictures returned from JPEG PictureCallback. The camera driver may set orientation in the EXIF header without rotating the picture. Or the driver may rotate the picture and the EXIF thumbnail. If the Jpeg picture is rotated, the orientation in the EXIF header will be missing or 1 (row #0 is top and column #0 is left side).</para><para>If applications want to rotate the picture to match the orientation of what users see, apps should use android.view.OrientationEventListener and CameraInfo. The value from OrientationEventListener is relative to the natural orientation of the device. CameraInfo.orientation is the angle between camera orientation and natural device orientation. The sum of the two is the rotation angle for back-facing camera. The difference of the two is the rotation angle for front-facing camera. Note that the JPEG pictures of front-facing cameras are not mirrored as in preview display.</para><para>For example, suppose the natural orientation of the device is portrait. The device is rotated 270 degrees clockwise, so the device orientation is 270. Suppose a back-facing camera sensor is mounted in landscape and the top side of the camera sensor is aligned with the right edge of the display in natural orientation. So the camera orientation is 90. The rotation should be set to 0 (270 + 90).</para><para>The reference code is as follows.</para><para><pre>
						///            public void onOrientationChanged(int orientation) {
						///                if (orientation == ORIENTATION_UNKNOWN) return;
						///                android.hardware.Camera.CameraInfo info =
						///                       new android.hardware.Camera.CameraInfo();
						///                android.hardware.Camera.getCameraInfo(cameraId, info);
						///                orientation = (orientation + 45) / 90 * 90;
						///                int rotation = 0;
						///                if (info.facing == CameraInfo.CAMERA_FACING_FRONT) {
						///                    rotation = (info.orientation - orientation + 360) % 360;
						///                } else {  // back-facing camera
						///                    rotation = (info.orientation + orientation) % 360;
						///                }
						///                mParameters.setRotation(rotation);
						///            }
						///            </pre></para><para><para>android.view.OrientationEventListener </para><simplesectsep></simplesectsep><para>getCameraInfo(int, CameraInfo) </para></para>        
						/// </summary>
						/// <java-name>
						/// setRotation
						/// </java-name>
						[Dot42.DexImport("setRotation", "(I)V", AccessFlags = 1)]
						public virtual void SetRotation(int rotation) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS latitude coordinate. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsLatitude
						/// </java-name>
						[Dot42.DexImport("setGpsLatitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLatitude(double latitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS longitude coordinate. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsLongitude
						/// </java-name>
						[Dot42.DexImport("setGpsLongitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLongitude(double longitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS altitude. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsAltitude
						/// </java-name>
						[Dot42.DexImport("setGpsAltitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsAltitude(double altitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS timestamp. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsTimestamp
						/// </java-name>
						[Dot42.DexImport("setGpsTimestamp", "(J)V", AccessFlags = 1)]
						public virtual void SetGpsTimestamp(long timestamp) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Removes GPS latitude, longitude, altitude, and timestamp from the parameters. </para>        
						/// </summary>
						/// <java-name>
						/// removeGpsData
						/// </java-name>
						[Dot42.DexImport("removeGpsData", "()V", AccessFlags = 1)]
						public virtual void RemoveGpsData() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the current white balance setting.</para><para><para>#WHITE_BALANCE_AUTO </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_INCANDESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_WARM_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_CLOUDY_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_TWILIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_SHADE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getWhiteBalance
						/// </java-name>
						[Dot42.DexImport("getWhiteBalance", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetWhiteBalance() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the white balance. Changing the setting will release the auto-white balance lock. It is recommended not to change white balance and AWB lock at the same time.</para><para><para>getWhiteBalance() </para><simplesectsep></simplesectsep><para>setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// setWhiteBalance
						/// </java-name>
						[Dot42.DexImport("setWhiteBalance", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetWhiteBalance(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported white balance.</para><para><para>getWhiteBalance() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedWhiteBalance
						/// </java-name>
						[Dot42.DexImport("getSupportedWhiteBalance", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedWhiteBalance() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current color effect setting.</para><para><para>#EFFECT_NONE </para><simplesectsep></simplesectsep><para>#EFFECT_MONO </para><simplesectsep></simplesectsep><para>#EFFECT_NEGATIVE </para><simplesectsep></simplesectsep><para>#EFFECT_SOLARIZE </para><simplesectsep></simplesectsep><para>#EFFECT_SEPIA </para><simplesectsep></simplesectsep><para>#EFFECT_POSTERIZE </para><simplesectsep></simplesectsep><para>#EFFECT_WHITEBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_BLACKBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_AQUA </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current color effect. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getColorEffect
						/// </java-name>
						[Dot42.DexImport("getColorEffect", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetColorEffect() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the current color effect setting.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <java-name>
						/// setColorEffect
						/// </java-name>
						[Dot42.DexImport("setColorEffect", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetColorEffect(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported color effects.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported color effects. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedColorEffects
						/// </java-name>
						[Dot42.DexImport("getSupportedColorEffects", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedColorEffects() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current antibanding setting.</para><para><para>#ANTIBANDING_AUTO </para><simplesectsep></simplesectsep><para>#ANTIBANDING_50HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_60HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_OFF </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current antibanding. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getAntibanding
						/// </java-name>
						[Dot42.DexImport("getAntibanding", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetAntibanding() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the antibanding.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <java-name>
						/// setAntibanding
						/// </java-name>
						[Dot42.DexImport("setAntibanding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetAntibanding(string antibanding) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported antibanding values.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported antibanding values. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedAntibanding
						/// </java-name>
						[Dot42.DexImport("getSupportedAntibanding", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedAntibanding() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current scene mode setting.</para><para><para>SCENE_MODE_AUTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_ACTION </para><simplesectsep></simplesectsep><para>SCENE_MODE_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_LANDSCAPE </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_THEATRE </para><simplesectsep></simplesectsep><para>SCENE_MODE_BEACH </para><simplesectsep></simplesectsep><para>SCENE_MODE_SNOW </para><simplesectsep></simplesectsep><para>SCENE_MODE_SUNSET </para><simplesectsep></simplesectsep><para>SCENE_MODE_STEADYPHOTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_FIREWORKS </para><simplesectsep></simplesectsep><para>SCENE_MODE_SPORTS </para><simplesectsep></simplesectsep><para>SCENE_MODE_PARTY </para><simplesectsep></simplesectsep><para>SCENE_MODE_CANDLELIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_BARCODE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>one of SCENE_MODE_XXX string constant. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSceneMode
						/// </java-name>
						[Dot42.DexImport("getSceneMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetSceneMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the scene mode. Changing scene mode may override other parameters (such as flash mode, focus mode, white balance). For example, suppose originally flash mode is on and supported flash modes are on/off. In night scene mode, both flash mode and supported flash mode may be changed to off. After setting scene mode, applications should call getParameters to know if some parameters are changed.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setSceneMode
						/// </java-name>
						[Dot42.DexImport("setSceneMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetSceneMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported scene modes.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported scene modes. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedSceneModes
						/// </java-name>
						[Dot42.DexImport("getSupportedSceneModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedSceneModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current flash mode setting.</para><para><para>FLASH_MODE_OFF </para><simplesectsep></simplesectsep><para>FLASH_MODE_AUTO </para><simplesectsep></simplesectsep><para>FLASH_MODE_ON </para><simplesectsep></simplesectsep><para>FLASH_MODE_RED_EYE </para><simplesectsep></simplesectsep><para>FLASH_MODE_TORCH </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current flash mode. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getFlashMode
						/// </java-name>
						[Dot42.DexImport("getFlashMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetFlashMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the flash mode.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setFlashMode
						/// </java-name>
						[Dot42.DexImport("setFlashMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetFlashMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported flash modes.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported flash modes. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFlashModes
						/// </java-name>
						[Dot42.DexImport("getSupportedFlashModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedFlashModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current focus mode setting.</para><para><para>FOCUS_MODE_AUTO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_INFINITY </para><simplesectsep></simplesectsep><para>FOCUS_MODE_MACRO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_FIXED </para><simplesectsep></simplesectsep><para>FOCUS_MODE_EDOF </para><simplesectsep></simplesectsep><para>FOCUS_MODE_CONTINUOUS_VIDEO </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current focus mode. This method will always return a non-null value. Applications should call autoFocus(AutoFocusCallback) to start the focus if focus mode is FOCUS_MODE_AUTO or FOCUS_MODE_MACRO. </para>
						/// </returns>
						/// <java-name>
						/// getFocusMode
						/// </java-name>
						[Dot42.DexImport("getFocusMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetFocusMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the focus mode.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setFocusMode
						/// </java-name>
						[Dot42.DexImport("setFocusMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetFocusMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported focus modes.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported focus modes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFocusModes
						/// </java-name>
						[Dot42.DexImport("getSupportedFocusModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedFocusModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Parameters() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions setting for preview pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the width and height setting for the preview picture </para>
						/// </returns>
						/// <java-name>
						/// getPreviewSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size PreviewSize
						{
						[Dot42.DexImport("getPreviewSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetPreviewSize(); }
						}

						/// <summary>
						/// <para>Gets the supported preview sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPreviewSizes
						{
						[Dot42.DexImport("getSupportedPreviewSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedPreviewSizes(); }
						}

						/// <summary>
						/// <para>Returns the dimensions for EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for the EXIF thumbnails </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size JpegThumbnailSize
						{
						[Dot42.DexImport("getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetJpegThumbnailSize(); }
						}

						/// <summary>
						/// <para>Returns the quality setting for the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG quality setting of the EXIF thumbnail. </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailQuality
						/// </java-name>
						public int JpegThumbnailQuality
						{
						[Dot42.DexImport("getJpegThumbnailQuality", "()I", AccessFlags = 1)]
								get{ return GetJpegThumbnailQuality(); }
						[Dot42.DexImport("setJpegThumbnailQuality", "(I)V", AccessFlags = 1)]
								set{ SetJpegThumbnailQuality(value); }
						}

						/// <summary>
						/// <para>Returns the quality setting for the JPEG picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG picture quality setting. </para>
						/// </returns>
						/// <java-name>
						/// getJpegQuality
						/// </java-name>
						public int JpegQuality
						{
						[Dot42.DexImport("getJpegQuality", "()I", AccessFlags = 1)]
								get{ return GetJpegQuality(); }
						[Dot42.DexImport("setJpegQuality", "(I)V", AccessFlags = 1)]
								set{ SetJpegQuality(value); }
						}

						/// <summary>
						/// <para>Returns the setting for the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getPreviewFpsRange(int[]) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>the frame rate setting (frames per second) </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFrameRate
						/// </java-name>
						public int PreviewFrameRate
						{
						[Dot42.DexImport("getPreviewFrameRate", "()I", AccessFlags = 1)]
								get{ return GetPreviewFrameRate(); }
						[Dot42.DexImport("setPreviewFrameRate", "(I)V", AccessFlags = 1)]
								set{ SetPreviewFrameRate(value); }
						}

						/// <summary>
						/// <para>Gets the supported preview frame rates.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getSupportedPreviewFpsRange() </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview frame rates. null if preview frame rate setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFrameRates
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPreviewFrameRates
						{
						[Dot42.DexImport("getSupportedPreviewFrameRates", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPreviewFrameRates(); }
						}

						/// <summary>
						/// <para>Returns the image format for preview frames got from PreviewCallback.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preview format. </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFormat
						/// </java-name>
						public int PreviewFormat
						{
						[Dot42.DexImport("getPreviewFormat", "()I", AccessFlags = 1)]
								get{ return GetPreviewFormat(); }
						[Dot42.DexImport("setPreviewFormat", "(I)V", AccessFlags = 1)]
								set{ SetPreviewFormat(value); }
						}

						/// <summary>
						/// <para>Gets the supported preview formats. android.graphics.ImageFormat#NV21 is always supported. android.graphics.ImageFormat#YV12 is always supported since API level 12.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFormats
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPreviewFormats
						{
						[Dot42.DexImport("getSupportedPreviewFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPreviewFormats(); }
						}

						/// <summary>
						/// <para>Returns the dimension setting for pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for pictures </para>
						/// </returns>
						/// <java-name>
						/// getPictureSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size PictureSize
						{
						[Dot42.DexImport("getPictureSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetPictureSize(); }
						}

						/// <summary>
						/// <para>Gets the supported picture sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported picture sizes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPictureSizes
						{
						[Dot42.DexImport("getSupportedPictureSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedPictureSizes(); }
						}

						/// <summary>
						/// <para>Returns the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the picture format </para>
						/// </returns>
						/// <java-name>
						/// getPictureFormat
						/// </java-name>
						public int PictureFormat
						{
						[Dot42.DexImport("getPictureFormat", "()I", AccessFlags = 1)]
								get{ return GetPictureFormat(); }
						[Dot42.DexImport("setPictureFormat", "(I)V", AccessFlags = 1)]
								set{ SetPictureFormat(value); }
						}

						/// <summary>
						/// <para>Gets the supported picture formats.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>supported picture formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureFormats
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPictureFormats
						{
						[Dot42.DexImport("getSupportedPictureFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPictureFormats(); }
						}

						/// <summary>
						/// <para>Gets the current white balance setting.</para><para><para>#WHITE_BALANCE_AUTO </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_INCANDESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_WARM_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_CLOUDY_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_TWILIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_SHADE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getWhiteBalance
						/// </java-name>
						public string WhiteBalance
						{
						[Dot42.DexImport("getWhiteBalance", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetWhiteBalance(); }
						[Dot42.DexImport("setWhiteBalance", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetWhiteBalance(value); }
						}

						/// <summary>
						/// <para>Gets the supported white balance.</para><para><para>getWhiteBalance() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedWhiteBalance
						/// </java-name>
						public global::Java.Util.IList<string> SupportedWhiteBalance
						{
						[Dot42.DexImport("getSupportedWhiteBalance", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedWhiteBalance(); }
						}

						/// <summary>
						/// <para>Gets the current color effect setting.</para><para><para>#EFFECT_NONE </para><simplesectsep></simplesectsep><para>#EFFECT_MONO </para><simplesectsep></simplesectsep><para>#EFFECT_NEGATIVE </para><simplesectsep></simplesectsep><para>#EFFECT_SOLARIZE </para><simplesectsep></simplesectsep><para>#EFFECT_SEPIA </para><simplesectsep></simplesectsep><para>#EFFECT_POSTERIZE </para><simplesectsep></simplesectsep><para>#EFFECT_WHITEBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_BLACKBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_AQUA </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current color effect. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getColorEffect
						/// </java-name>
						public string ColorEffect
						{
						[Dot42.DexImport("getColorEffect", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetColorEffect(); }
						[Dot42.DexImport("setColorEffect", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetColorEffect(value); }
						}

						/// <summary>
						/// <para>Gets the supported color effects.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported color effects. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedColorEffects
						/// </java-name>
						public global::Java.Util.IList<string> SupportedColorEffects
						{
						[Dot42.DexImport("getSupportedColorEffects", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedColorEffects(); }
						}

						/// <summary>
						/// <para>Gets the current antibanding setting.</para><para><para>#ANTIBANDING_AUTO </para><simplesectsep></simplesectsep><para>#ANTIBANDING_50HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_60HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_OFF </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current antibanding. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getAntibanding
						/// </java-name>
						public string Antibanding
						{
						[Dot42.DexImport("getAntibanding", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetAntibanding(); }
						[Dot42.DexImport("setAntibanding", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetAntibanding(value); }
						}

						/// <summary>
						/// <para>Gets the supported antibanding values.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported antibanding values. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedAntibanding
						/// </java-name>
						public global::Java.Util.IList<string> SupportedAntibanding
						{
						[Dot42.DexImport("getSupportedAntibanding", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedAntibanding(); }
						}

						/// <summary>
						/// <para>Gets the current scene mode setting.</para><para><para>SCENE_MODE_AUTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_ACTION </para><simplesectsep></simplesectsep><para>SCENE_MODE_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_LANDSCAPE </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_THEATRE </para><simplesectsep></simplesectsep><para>SCENE_MODE_BEACH </para><simplesectsep></simplesectsep><para>SCENE_MODE_SNOW </para><simplesectsep></simplesectsep><para>SCENE_MODE_SUNSET </para><simplesectsep></simplesectsep><para>SCENE_MODE_STEADYPHOTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_FIREWORKS </para><simplesectsep></simplesectsep><para>SCENE_MODE_SPORTS </para><simplesectsep></simplesectsep><para>SCENE_MODE_PARTY </para><simplesectsep></simplesectsep><para>SCENE_MODE_CANDLELIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_BARCODE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>one of SCENE_MODE_XXX string constant. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSceneMode
						/// </java-name>
						public string SceneMode
						{
						[Dot42.DexImport("getSceneMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetSceneMode(); }
						[Dot42.DexImport("setSceneMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetSceneMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported scene modes.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported scene modes. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedSceneModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedSceneModes
						{
						[Dot42.DexImport("getSupportedSceneModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedSceneModes(); }
						}

						/// <summary>
						/// <para>Gets the current flash mode setting.</para><para><para>FLASH_MODE_OFF </para><simplesectsep></simplesectsep><para>FLASH_MODE_AUTO </para><simplesectsep></simplesectsep><para>FLASH_MODE_ON </para><simplesectsep></simplesectsep><para>FLASH_MODE_RED_EYE </para><simplesectsep></simplesectsep><para>FLASH_MODE_TORCH </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current flash mode. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getFlashMode
						/// </java-name>
						public string FlashMode
						{
						[Dot42.DexImport("getFlashMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetFlashMode(); }
						[Dot42.DexImport("setFlashMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetFlashMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported flash modes.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported flash modes. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFlashModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedFlashModes
						{
						[Dot42.DexImport("getSupportedFlashModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedFlashModes(); }
						}

						/// <summary>
						/// <para>Gets the current focus mode setting.</para><para><para>FOCUS_MODE_AUTO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_INFINITY </para><simplesectsep></simplesectsep><para>FOCUS_MODE_MACRO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_FIXED </para><simplesectsep></simplesectsep><para>FOCUS_MODE_EDOF </para><simplesectsep></simplesectsep><para>FOCUS_MODE_CONTINUOUS_VIDEO </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current focus mode. This method will always return a non-null value. Applications should call autoFocus(AutoFocusCallback) to start the focus if focus mode is FOCUS_MODE_AUTO or FOCUS_MODE_MACRO. </para>
						/// </returns>
						/// <java-name>
						/// getFocusMode
						/// </java-name>
						public string FocusMode
						{
						[Dot42.DexImport("getFocusMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetFocusMode(); }
						[Dot42.DexImport("setFocusMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetFocusMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported focus modes.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported focus modes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFocusModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedFocusModes
						{
						[Dot42.DexImport("getSupportedFocusModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedFocusModes(); }
						}

				}

				/// <summary>
				/// <para>Image size (width and height dimensions). </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Size
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Size", AccessFlags = 1)]
				public partial class Size
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>width of the picture </para>        
						/// </summary>
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						/// <summary>
						/// <para>height of the picture </para>        
						/// </summary>
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 1)]
						public int Height;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/hardware/Camera;", AccessFlags = 4112)]
						internal readonly global::Android.Hardware.Camera This_0;
						[Dot42.DexImport("<init>", "(Landroid/hardware/Camera;II)V", AccessFlags = 1)]
						public Size(global::Android.Hardware.Camera camera, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Size() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				/// <para>Callback interface for camera error notification.</para><para><para>setErrorCallback(ErrorCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$ErrorCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ErrorCallback", AccessFlags = 1545)]
				public partial interface IErrorCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Callback for camera errors. </para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(ILandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnError(int error, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to supply image data from a photo capture.</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$PictureCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PictureCallback", AccessFlags = 1545)]
				public partial interface IPictureCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when image data is available after a picture is taken. The format of the data depends on the context of the callback and Camera.Parameters settings.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onPictureTaken
						/// </java-name>
						[Dot42.DexImport("onPictureTaken", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPictureTaken(sbyte[] data, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to signal the moment of actual image capture.</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$ShutterCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ShutterCallback", AccessFlags = 1545)]
				public partial interface IShutterCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called as near as possible to the moment when a photo is captured from the sensor. This is a good opportunity to play a shutter sound or give other feedback of camera operation. This may be some time after the photo was triggered, but some time before the actual data is available. </para>        
						/// </summary>
						/// <java-name>
						/// onShutter
						/// </java-name>
						[Dot42.DexImport("onShutter", "()V", AccessFlags = 1025)]
						void OnShutter() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to notify on completion of camera auto focus.</para><para>Devices that do not support auto-focus will receive a "fake" callback to this interface. If your application needs auto-focus and should not be installed on devices <b>without</b> auto-focus, you must declare that your app uses the <c> android.hardware.camera.autofocus </c> feature, in the  manifest element.</para><para><para>autoFocus(AutoFocusCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$AutoFocusCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$AutoFocusCallback", AccessFlags = 1545)]
				public partial interface IAutoFocusCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the camera auto focus completes. If the camera does not support auto-focus and autoFocus is called, onAutoFocus will be called immediately with a fake value of <code>success</code> set to <code>true</code>.</para><para>The auto-focus routine does not lock auto-exposure and auto-white balance after it completes.</para><para><para>android.hardware.Camera.Parameters::setAutoExposureLock(boolean) </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// onAutoFocus
						/// </java-name>
						[Dot42.DexImport("onAutoFocus", "(ZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnAutoFocus(bool success, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to deliver copies of preview frames as they are displayed.</para><para><para>setPreviewCallback(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>setOneShotPreviewCallback(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>setPreviewCallbackWithBuffer(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>startPreview() </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$PreviewCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PreviewCallback", AccessFlags = 1545)]
				public partial interface IPreviewCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called as preview frames are displayed. This callback is invoked on the event thread open(int) was called from.</para><para>If using the android.graphics.ImageFormat#YV12 format, refer to the equations in Camera.Parameters#setPreviewFormat for the arrangement of the pixel data in the preview callback buffers.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onPreviewFrame
						/// </java-name>
						[Dot42.DexImport("onPreviewFrame", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPreviewFrame(sbyte[] data, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Used for receiving notifications from the SensorManager when sensor values have changed.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use SensorEventListener instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorListener", AccessFlags = 1537)]
		public partial interface ISensorListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when sensor values have changed. The length and contents of the values array vary depending on which sensor is being monitored. See SensorManager for details on possible sensor types.</para><para>&lt;u&gt;Definition of the coordinate system used below.&lt;/u&gt;</para><para>The X axis refers to the screen's horizontal axis (the small edge in portrait mode, the long edge in landscape mode) and points to the right. </para><para>The Y axis refers to the screen's vertical axis and points towards the top of the screen (the origin is in the lower-left corner). </para><para>The Z axis points toward the sky when the device is lying on its back on a table. </para><para><b>IMPORTANT NOTE:</b> The axis <b>&lt;u&gt;are swapped&lt;/u&gt;</b> when the device's screen orientation changes. To access the unswapped values, use indices 3, 4 and 5 in values[].</para><para>SENSOR_ORIENTATION, SENSOR_ORIENTATION_RAW:</para><para>All values are angles in degrees.</para><para>values[0]: Azimuth, rotation around the Z axis (0&lt;=azimuth&lt;360). 0 = North, 90 = East, 180 = South, 270 = West</para><para>values[1]: Pitch, rotation around X axis (-180&lt;=pitch&lt;=180), with positive values when the z-axis moves toward the y-axis.</para><para>values[2]: Roll, rotation around Y axis (-90&lt;=roll&lt;=90), with positive values when the z-axis moves toward the x-axis.</para><para>Note that this definition of yaw, pitch and roll is different from the traditional definition used in aviation where the X axis is along the long side of the plane (tail to nose).</para><para>SENSOR_ACCELEROMETER:</para><para>All values are in SI units (m/s^2) and measure contact forces.</para><para>values[0]: force applied by the device on the x-axis </para><para>values[1]: force applied by the device on the y-axis </para><para>values[2]: force applied by the device on the z-axis</para><para>&lt;u&gt;Examples&lt;/u&gt;: When the device is pushed on its left side toward the right, the x acceleration value is negative (the device applies a reaction force to the push toward the left)</para><para>When the device lies flat on a table, the acceleration value is -STANDARD_GRAVITY, which correspond to the force the device applies on the table in reaction to gravity.</para><para>SENSOR_MAGNETIC_FIELD:</para><para>All values are in micro-Tesla (uT) and measure the ambient magnetic field in the X, Y and -Z axis. </para><para><b>&lt;u&gt;Note:&lt;/u&gt;</b> the magnetic field's Z axis is inverted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(I[F)V", AccessFlags = 1025)]
				void OnSensorChanged(int sensor, float[] values) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the accuracy of a sensor has changed. See SensorManager for details.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(II)V", AccessFlags = 1025)]
				void OnAccuracyChanged(int sensor, int accuracy) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Class representing a sensor. Use SensorManager#getSensorList to get the list of available Sensors.</para><para><para>SensorManager </para><simplesectsep></simplesectsep><para>SensorEventListener </para><simplesectsep></simplesectsep><para>SensorEvent </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/Sensor
		/// </java-name>
		[Dot42.DexImport("android/hardware/Sensor", AccessFlags = 33)]
		public partial class Sensor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant describing an accelerometer sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("TYPE_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int TYPE_ACCELEROMETER = 1;
				/// <summary>
				/// <para>A constant describing a magnetic field sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("TYPE_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int TYPE_MAGNETIC_FIELD = 2;
				/// <summary>
				/// <para>A constant describing an orientation sensor type. </para><para>See SensorEvent.values for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use SensorManager.getOrientation() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("TYPE_ORIENTATION", "I", AccessFlags = 25)]
				public const int TYPE_ORIENTATION = 3;
				/// <summary>
				/// <para>A constant describing a gyroscope sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GYROSCOPE
				/// </java-name>
				[Dot42.DexImport("TYPE_GYROSCOPE", "I", AccessFlags = 25)]
				public const int TYPE_GYROSCOPE = 4;
				/// <summary>
				/// <para>A constant describing a light sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_LIGHT
				/// </java-name>
				[Dot42.DexImport("TYPE_LIGHT", "I", AccessFlags = 25)]
				public const int TYPE_LIGHT = 5;
				/// <summary>
				/// <para>A constant describing a pressure sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PRESSURE
				/// </java-name>
				[Dot42.DexImport("TYPE_PRESSURE", "I", AccessFlags = 25)]
				public const int TYPE_PRESSURE = 6;
				/// <summary>
				/// <para>A constant describing a temperature sensor type</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor.TYPE_AMBIENT_TEMPERATURE instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEMPERATURE", "I", AccessFlags = 25)]
				public const int TYPE_TEMPERATURE = 7;
				/// <summary>
				/// <para>A constant describing a proximity sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("TYPE_PROXIMITY", "I", AccessFlags = 25)]
				public const int TYPE_PROXIMITY = 8;
				/// <summary>
				/// <para>A constant describing all sensor types. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL", "I", AccessFlags = 25)]
				public const int TYPE_ALL = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Sensor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name string of the sensor. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>vendor string of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getVendor
				/// </java-name>
				[Dot42.DexImport("getVendor", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetVendor() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>generic type of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
				public new virtual int GetType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the sensor's module. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>maximum range of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumRange
				/// </java-name>
				[Dot42.DexImport("getMaximumRange", "()F", AccessFlags = 1)]
				public virtual float GetMaximumRange() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>resolution of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getResolution
				/// </java-name>
				[Dot42.DexImport("getResolution", "()F", AccessFlags = 1)]
				public virtual float GetResolution() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power in mA used by this sensor while in use </para>
				/// </returns>
				/// <java-name>
				/// getPower
				/// </java-name>
				[Dot42.DexImport("getPower", "()F", AccessFlags = 1)]
				public virtual float GetPower() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name string of the sensor. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>vendor string of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getVendor
				/// </java-name>
				public string Vendor
				{
				[Dot42.DexImport("getVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVendor(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>generic type of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the sensor's module. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>maximum range of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumRange
				/// </java-name>
				public float MaximumRange
				{
				[Dot42.DexImport("getMaximumRange", "()F", AccessFlags = 1)]
						get{ return GetMaximumRange(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>resolution of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getResolution
				/// </java-name>
				public float Resolution
				{
				[Dot42.DexImport("getResolution", "()F", AccessFlags = 1)]
						get{ return GetResolution(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power in mA used by this sensor while in use </para>
				/// </returns>
				/// <java-name>
				/// getPower
				/// </java-name>
				public float Power
				{
				[Dot42.DexImport("getPower", "()F", AccessFlags = 1)]
						get{ return GetPower(); }
				}

		}

		/// <summary>
		/// <para>Used for receiving notifications from the SensorManager when sensor values have changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorEventListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEventListener", AccessFlags = 1537)]
		public partial interface ISensorEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when sensor values have changed. </para><para>See SensorManager for details on possible sensor types. </para><para>See also SensorEvent.</para><para><b>NOTE:</b> The application doesn't own the event object passed as a parameter and therefore cannot hold on to it. The object may be part of an internal pool and may be reused by the framework.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", AccessFlags = 1025)]
				void OnSensorChanged(global::Android.Hardware.SensorEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the accuracy of a sensor has changed. </para><para>See SensorManager for details.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", AccessFlags = 1025)]
				void OnAccuracyChanged(global::Android.Hardware.Sensor sensor, int accuracy) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Estimates magnetic field at a given point on Earth, and in particular, to compute the magnetic declination from true north.</para><para>This uses the World Magnetic Model produced by the United States National Geospatial-Intelligence Agency. More details about the model can be found at . This class currently uses WMM-2010 which is valid until 2015, but should produce acceptable results for several years after that. Future versions of Android may use a newer version of the model. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/GeomagneticField
		/// </java-name>
		[Dot42.DexImport("android/hardware/GeomagneticField", AccessFlags = 33)]
		public partial class GeomagneticField
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Estimate the magnetic field at a given point and time.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFJ)V", AccessFlags = 1)]
				public GeomagneticField(float gdLatitudeDeg, float gdLongitudeDeg, float altitudeMeters, long timeMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The X (northward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
				public virtual float GetX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Y (eastward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
				public virtual float GetY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Z (downward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				[Dot42.DexImport("getZ", "()F", AccessFlags = 1)]
				public virtual float GetZ() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The declination of the horizontal component of the magnetic field from true north, in degrees (i.e. positive means the magnetic field is rotated east that much from true north). </para>
				/// </returns>
				/// <java-name>
				/// getDeclination
				/// </java-name>
				[Dot42.DexImport("getDeclination", "()F", AccessFlags = 1)]
				public virtual float GetDeclination() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The inclination of the magnetic field in degrees  positive means the magnetic field is rotated downwards. </para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				[Dot42.DexImport("getInclination", "()F", AccessFlags = 1)]
				public virtual float GetInclination() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Horizontal component of the field strength in nonoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalStrength
				/// </java-name>
				[Dot42.DexImport("getHorizontalStrength", "()F", AccessFlags = 1)]
				public virtual float GetHorizontalStrength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Total field strength in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getFieldStrength
				/// </java-name>
				[Dot42.DexImport("getFieldStrength", "()F", AccessFlags = 1)]
				public virtual float GetFieldStrength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GeomagneticField() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The X (northward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public float X
				{
				[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
						get{ return GetX(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Y (eastward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public float Y
				{
				[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
						get{ return GetY(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Z (downward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				public float Z
				{
				[Dot42.DexImport("getZ", "()F", AccessFlags = 1)]
						get{ return GetZ(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The declination of the horizontal component of the magnetic field from true north, in degrees (i.e. positive means the magnetic field is rotated east that much from true north). </para>
				/// </returns>
				/// <java-name>
				/// getDeclination
				/// </java-name>
				public float Declination
				{
				[Dot42.DexImport("getDeclination", "()F", AccessFlags = 1)]
						get{ return GetDeclination(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The inclination of the magnetic field in degrees  positive means the magnetic field is rotated downwards. </para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				public float Inclination
				{
				[Dot42.DexImport("getInclination", "()F", AccessFlags = 1)]
						get{ return GetInclination(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Horizontal component of the field strength in nonoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalStrength
				/// </java-name>
				public float HorizontalStrength
				{
				[Dot42.DexImport("getHorizontalStrength", "()F", AccessFlags = 1)]
						get{ return GetHorizontalStrength(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Total field strength in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getFieldStrength
				/// </java-name>
				public float FieldStrength
				{
				[Dot42.DexImport("getFieldStrength", "()F", AccessFlags = 1)]
						get{ return GetFieldStrength(); }
				}

		}

		/// <summary>
		/// <para>This class represents a Sensor event and holds informations such as the sensor's type, the time-stamp, accuracy and of course the sensor's data.</para><para>&lt;u&gt;Definition of the coordinate system used by the SensorEvent API.&lt;/u&gt; </para><para>The coordinate-system is defined relative to the screen of the phone in its default orientation. The axes are not swapped when the device's screen orientation changes. </para><para>The X axis is horizontal and points to the right, the Y axis is vertical and points up and the Z axis points towards the outside of the front face of the screen. In this system, coordinates behind the screen have negative Z values. </para><para><center><image></image></center> </para><para><b>Note:</b> This coordinate system is different from the one used in the Android 2D APIs where the origin is in the top-left corner. </para><para><para>SensorManager </para><simplesectsep></simplesectsep><para>SensorEvent </para><simplesectsep></simplesectsep><para>Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorEvent
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEvent", AccessFlags = 33)]
		public partial class SensorEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The length and contents of the values array depends on which sensor type is being monitored (see also SensorEvent for a definition of the coordinate system used). </para><para><h4>android.hardware.Sensor::TYPE_ACCELEROMETER Sensor.TYPE_ACCELEROMETER}:</h4></para><para>All values are in SI units (m/s^2)</para><para><ul><li><para>values[0]: Acceleration minus Gx on the x-axis  </para></li><li><para>values[1]: Acceleration minus Gy on the y-axis  </para></li><li><para>values[2]: Acceleration minus Gz on the z-axis  </para></li></ul></para><para>A sensor of this type measures the acceleration applied to the device (<b>Ad</b>). Conceptually, it does so by measuring forces applied to the sensor itself (<b>Fs</b>) using the relation: </para><para><b><center>Ad = - &amp;#8721;Fs / mass</center></b></para><para>In particular, the force of gravity is always influencing the measured acceleration: </para><para><b><center>Ad = -g - &amp;#8721;F / mass</center></b></para><para>For this reason, when the device is sitting on a table (and obviously not accelerating), the accelerometer reads a magnitude of <b>g</b> = 9.81 m/s^2 </para><para>Similarly, when the device is in free-fall and therefore dangerously accelerating towards to ground at 9.81 m/s^2, its accelerometer reads a magnitude of 0 m/s^2. </para><para>It should be apparent that in order to measure the real acceleration of the device, the contribution of the force of gravity must be eliminated. This can be achieved by applying a <b>high-pass</b> filter. Conversely, a <b>low-pass</b> filter can be used to isolate the force of gravity. </para><para><pre>
				/// <span>public void onSensorChanged(SensorEvent event)
				/// {
				///      // alpha is calculated as t / (t + dT)
				///      // with t, the low-pass filter's time-constant
				///      // and dT, the event delivery rate
				/// 
				///      final float alpha = 0.8;
				/// 
				///      gravity[0] = alpha * gravity[0] + (1 - alpha) * event.values[0];
				///      gravity[1] = alpha * gravity[1] + (1 - alpha) * event.values[1];
				///      gravity[2] = alpha * gravity[2] + (1 - alpha) * event.values[2];
				/// 
				///      linear_acceleration[0] = event.values[0] - gravity[0];
				///      linear_acceleration[1] = event.values[1] - gravity[1];
				///      linear_acceleration[2] = event.values[2] - gravity[2];
				/// }
				/// </span>
				///        </pre></para><para>&lt;u&gt;Examples&lt;/u&gt;: <ul><li><para>When the device lies flat on a table and is pushed on its left side toward the right, the x acceleration value is positive.</para><para></para></li><li><para>When the device lies flat on a table, the acceleration value is +9.81, which correspond to the acceleration of the device (0 m/s^2) minus the force of gravity (-9.81 m/s^2).</para><para></para></li><li><para>When the device lies flat on a table and is pushed toward the sky with an acceleration of A m/s^2, the acceleration value is equal to A+9.81 which correspond to the acceleration of the device (+A m/s^2) minus the force of gravity (-9.81 m/s^2). </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_MAGNETIC_FIELD Sensor.TYPE_MAGNETIC_FIELD}:</h4></para><para>All values are in micro-Tesla (uT) and measure the ambient magnetic field in the X, Y and Z axis.</para><para><h4>android.hardware.Sensor::TYPE_GYROSCOPE Sensor.TYPE_GYROSCOPE}: </h4></para><para>All values are in radians/second and measure the rate of rotation around the device's local X, Y and Z axis. The coordinate system is the same as is used for the acceleration sensor. Rotation is positive in the counter-clockwise direction. That is, an observer looking from some positive location on the x, y or z axis at a device positioned on the origin would report positive rotation if the device appeared to be rotating counter clockwise. Note that this is the standard mathematical definition of positive rotation and does not agree with the definition of roll given earlier. <ul><li><para>values[0]: Angular speed around the x-axis  </para></li><li><para>values[1]: Angular speed around the y-axis  </para></li><li><para>values[2]: Angular speed around the z-axis  </para></li></ul></para><para>Typically the output of the gyroscope is integrated over time to calculate a rotation describing the change of angles over the timestep, for example: </para><para><pre>
				///            private static final float NS2S = 1.0f / 1000000000.0f;
				///            private final float[] deltaRotationVector = new float[4]();
				///            private float timestamp;
				/// 
				///            public void onSensorChanged(SensorEvent event) {
				///                 // This timestep's delta rotation to be multiplied by the current rotation
				///                 // after computing it from the gyro sample data.
				///                 if (timestamp != 0) {
				///                     final float dT = (event.timestamp - timestamp) * NS2S;
				///                     // Axis of the rotation sample, not normalized yet.
				///                     float axisX = event.values[0];
				///                     float axisY = event.values[1];
				///                     float axisZ = event.values[2];
				/// 
				///                     // Calculate the angular speed of the sample
				///                     float omegaMagnitude = sqrt(axisX*axisX + axisY*axisY + axisZ*axisZ);
				/// 
				///                     // Normalize the rotation vector if it's big enough to get the axis
				///                     if (omegaMagnitude &gt; EPSILON) {
				///                         axisX /= omegaMagnitude;
				///                         axisY /= omegaMagnitude;
				///                         axisZ /= omegaMagnitude;
				///                     }
				/// 
				///                     // Integrate around this axis with the angular speed by the timestep
				///                     // in order to get a delta rotation from this sample over the timestep
				///                     // We will convert this axis-angle representation of the delta rotation
				///                     // into a quaternion before turning it into the rotation matrix.
				///                     float thetaOverTwo = omegaMagnitude * dT / 2.0f;
				///                     float sinThetaOverTwo = sin(thetaOverTwo);
				///                     float cosThetaOverTwo = cos(thetaOverTwo);
				///                     deltaRotationVector[0] = sinThetaOverTwo * axisX;
				///                     deltaRotationVector[1] = sinThetaOverTwo * axisY;
				///                     deltaRotationVector[2] = sinThetaOverTwo * axisZ;
				///                     deltaRotationVector[3] = cosThetaOverTwo;
				///                 }
				///                 timestamp = event.timestamp;
				///                 float[] deltaRotationMatrix = new float[9];
				///                 SensorManager.getRotationMatrixFromVector(deltaRotationMatrix, deltaRotationVector);
				///                 // User code should concatenate the delta rotation we computed with the current rotation
				///                 // in order to get the updated rotation.
				///                 // rotationCurrent = rotationCurrent * deltaRotationMatrix;
				///            }
				///        </pre> </para><para>In practice, the gyroscope noise and offset will introduce some errors which need to be compensated for. This is usually done using the information from other sensors, but is beyond the scope of this document. </para><para><h4>android.hardware.Sensor::TYPE_LIGHT Sensor.TYPE_LIGHT}:</h4></para><para><ul><li><para>values[0]: Ambient light level in SI lux units  </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_PRESSURE Sensor.TYPE_PRESSURE}:</h4></para><para><ul><li><para>values[0]: Atmospheric pressure in hPa (millibar)  </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_PROXIMITY Sensor.TYPE_PROXIMITY}: </h4></para><para><ul><li><para>values[0]: Proximity sensor distance measured in centimeters  </para></li></ul></para><para><b>Note:</b> Some proximity sensors only support a binary <b>near</b> or <b>far</b> measurement. In this case, the sensor should report its maximum range value in the <b>far</b> state and a lesser value in the <b>near</b> state. </para><para><h4>android.hardware.Sensor::TYPE_GRAVITY Sensor.TYPE_GRAVITY}:</h4></para><para>A three dimensional vector indicating the direction and magnitude of gravity. Units are m/s^2. The coordinate system is the same as is used by the acceleration sensor.</para><para><b>Note:</b> When the device is at rest, the output of the gravity sensor should be identical to that of the accelerometer.</para><para><h4>android.hardware.Sensor::TYPE_LINEAR_ACCELERATION Sensor.TYPE_LINEAR_ACCELERATION}:</h4></para><para>A three dimensional vector indicating acceleration along each device axis, not including gravity. All values have units of m/s^2. The coordinate system is the same as is used by the acceleration sensor. </para><para>The output of the accelerometer, gravity and linear-acceleration sensors must obey the following relation:</para><para><ul><li></li></ul>= gravity + linear-acceleration</para><para><h4>android.hardware.Sensor::TYPE_ROTATION_VECTOR Sensor.TYPE_ROTATION_VECTOR}:</h4></para><para>The rotation vector represents the orientation of the device as a combination of an <b>angle</b> and an <b>axis</b>, in which the device has rotated through an angle &amp;#952 around an axis &lt;x, y, z&gt;.</para><para>The three elements of the rotation vector are &lt;x*sin(&amp;#952/2), y*sin(&amp;#952/2), z*sin(&amp;#952/2)&gt;, such that the magnitude of the rotation vector is equal to sin(&amp;#952/2), and the direction of the rotation vector is equal to the direction of the axis of rotation.</para><para>The three elements of the rotation vector are equal to the last three components of a <b>unit</b> quaternion &lt;cos(&amp;#952/2), x*sin(&amp;#952/2), y*sin(&amp;#952/2), z*sin(&amp;#952/2)&gt;.</para><para>Elements of the rotation vector are unitless. The x,y, and z axis are defined in the same way as the acceleration sensor.</para><para>The reference coordinate system is defined as a direct orthonormal basis, where: </para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points East). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards magnetic north. </para></li><li><para>Z points towards the sky and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para><ul><li><para>values[0]: x*sin(&amp;#952/2)  </para></li><li><para>values[1]: y*sin(&amp;#952/2)  </para></li><li><para>values[2]: z*sin(&amp;#952/2)  </para></li><li><para>values[3]: cos(&amp;#952/2)  </para></li><li><para>values[4]: estimated heading Accuracy (in radians) (-1 if unavailable) </para></li></ul></para><para>values[3], originally optional, will always be present from SDK Level 18 onwards. values[4] is a new value that has been added in SDK Level 18. </para><para><h4>android.hardware.Sensor::TYPE_ORIENTATION Sensor.TYPE_ORIENTATION}:</h4></para><para>All values are angles in degrees.</para><para><ul><li><para>values[0]: Azimuth, angle between the magnetic north direction and the y-axis, around the z-axis (0 to 359). 0=North, 90=East, 180=South, 270=West </para><para></para><para></para><para>values[1]: Pitch, rotation around x-axis (-180 to 180), with positive values when the z-axis moves <b>toward</b> the y-axis. </para><para></para><para></para><para>values[2]: Roll, rotation around the x-axis (-90 to 90) increasing as the device moves clockwise. </para><para></para></li></ul></para><para><b>Note:</b> This definition is different from <b>yaw, pitch and roll</b> used in aviation where the X axis is along the long side of the plane (tail to nose). </para><para><b>Note:</b> This sensor type exists for legacy reasons, please use getRotationMatrix() in conjunction with remapCoordinateSystem() and getOrientation() to compute these values instead. </para><para><b>Important note:</b> For historical reasons the roll angle is positive in the clockwise direction (mathematically speaking, it should be positive in the counter-clockwise direction). </para><para><h4>android.hardware.Sensor::TYPE_RELATIVE_HUMIDITY Sensor.TYPE_RELATIVE_HUMIDITY}:</h4></para><para><ul><li><para>values[0]: Relative ambient air humidity in percent  </para></li></ul></para><para>When relative ambient air humidity and ambient temperature are measured, the dew point and absolute humidity can be calculated. </para><para>&lt;u&gt;Dew Point&lt;/u&gt; </para><para>The dew point is the temperature to which a given parcel of air must be cooled, at constant barometric pressure, for water vapor to condense into water. </para><para><center><pre>
				///                           ln(RH/100%) + m&amp;#183;t/(T<subscript>n</subscript>+t)
				///        t<subscript>d</subscript>(t,RH) = T<subscript>n</subscript> &amp;#183; 
				///                        m - [ln(RH/100%) + m&amp;#183;t/(T<subscript>n</subscript>+t)]
				///        </pre></center> </para><para>for example:</para><para><pre>
				///        h = Math.log(rh / 100.0) + (17.62 * t) / (243.12 + t);
				///        td = 243.12 * h / (17.62 - h);
				///        </pre> &lt;u&gt;Absolute Humidity&lt;/u&gt; </para><para>The absolute humidity is the mass of water vapor in a particular volume of dry air. The unit is g/m<span>3</span>. </para><para><center><pre>
				///                           RH/100%&amp;#183;A&amp;#183;exp(m&amp;#183;t/(T<subscript>n</subscript>+t))
				///        d<subscript>v</subscript>(t,RH) = 216.7 &amp;#183; -
				///                                  273.15 + t
				///        </pre></center> </para><para>for example:</para><para><pre>
				///        dv = 216.7 *
				///        (rh / 100.0 * 6.112 * Math.exp(17.62 * t / (243.12 + t)) / (273.15 + t));
				///        </pre></para><para><h4>android.hardware.Sensor::TYPE_AMBIENT_TEMPERATURE Sensor.TYPE_AMBIENT_TEMPERATURE}: </h4></para><para><ul><li><para>values[0]: ambient (room) temperature in degree Celsius. </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_MAGNETIC_FIELD_UNCALIBRATED Sensor.TYPE_MAGNETIC_FIELD_UNCALIBRATED}:</h4></para><para>Similar to android.hardware.Sensor#TYPE_MAGNETIC_FIELD, but the hard iron calibration is reported separately instead of being included in the measurement. Factory calibration and temperature compensation will still be applied to the "uncalibrated" measurement. Assumptions that the magnetic field is due to the Earth's poles is avoided. </para><para>The values array is shown below: <ul><li><para>values[0] = x_uncalib  </para></li><li><para>values[1] = y_uncalib  </para></li><li><para>values[2] = z_uncalib  </para></li><li><para>values[3] = x_bias  </para></li><li><para>values[4] = y_bias  </para></li><li><para>values[5] = z_bias  </para></li></ul></para><para>x_uncalib, y_uncalib, z_uncalib are the measured magnetic field in X, Y, Z axes. Soft iron and temperature calibrations are applied. But the hard iron calibration is not applied. The values are in micro-Tesla (uT). </para><para>x_bias, y_bias, z_bias give the iron bias estimated in X, Y, Z axes. Each field is a component of the estimated hard iron calibration. The values are in micro-Tesla (uT). </para><para>Hard iron - These distortions arise due to the magnetized iron, steel or permanenet magnets on the device. Soft iron - These distortions arise due to the interaction with the earth's magentic field. </para><para><h4>android.hardware.Sensor::TYPE_GAME_ROTATION_VECTOR}:</h4></para><para>Identical to android.hardware.Sensor#TYPE_ROTATION_VECTOR except that it doesn't use the geomagnetic field. Therefore the Y axis doesn't point north, but instead to some other reference, that reference is allowed to drift by the same order of magnitude as the gyroscope drift around the Z axis. </para><para>In the ideal case, a phone rotated and returning to the same real-world orientation will report the same game rotation vector (without using the earth's geomagnetic field). However, the orientation may drift somewhat over time. See android.hardware.Sensor#TYPE_ROTATION_VECTOR for a detailed description of the values. This sensor will not have the estimated heading accuracy value. </para><para><h4>android.hardware.Sensor::TYPE_GYROSCOPE_UNCALIBRATED Sensor.TYPE_GYROSCOPE_UNCALIBRATED}:</h4></para><para>All values are in radians/second and measure the rate of rotation around the X, Y and Z axis. An estimation of the drift on each axis is reported as well. </para><para>No gyro-drift compensation is performed. Factory calibration and temperature compensation is still applied to the rate of rotation (angular speeds). </para><para>The coordinate system is the same as is used for the android.hardware.Sensor#TYPE_ACCELEROMETER Rotation is positive in the counter-clockwise direction (right-hand rule). That is, an observer looking from some positive location on the x, y or z axis at a device positioned on the origin would report positive rotation if the device appeared to be rotating counter clockwise. The range would at least be 17.45 rad/s (ie: ~1000 deg/s). <ul><li><para>values[0] : angular speed (w/o drift compensation) around the X axis in rad/s  </para></li><li><para>values[1] : angular speed (w/o drift compensation) around the Y axis in rad/s  </para></li><li><para>values[2] : angular speed (w/o drift compensation) around the Z axis in rad/s  </para></li><li><para>values[3] : estimated drift around X axis in rad/s  </para></li><li><para>values[4] : estimated drift around Y axis in rad/s  </para></li><li><para>values[5] : estimated drift around Z axis in rad/s  </para></li></ul></para><para><b>Pro Tip:</b> Always use the length of the values array while performing operations on it. In earlier versions, this used to be always 3 which has changed now. </para><para><para>GeomagneticField </para></para>        
				/// </summary>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "[F", AccessFlags = 17)]
				public readonly float[] Values;
				/// <summary>
				/// <para>The sensor that generated this event. See SensorManager for details. </para>        
				/// </summary>
				/// <java-name>
				/// sensor
				/// </java-name>
				[Dot42.DexImport("sensor", "Landroid/hardware/Sensor;", AccessFlags = 1)]
				public global::Android.Hardware.Sensor Sensor;
				/// <summary>
				/// <para>The accuracy of this event. See SensorManager for details. </para>        
				/// </summary>
				/// <java-name>
				/// accuracy
				/// </java-name>
				[Dot42.DexImport("accuracy", "I", AccessFlags = 1)]
				public int Accuracy;
				/// <summary>
				/// <para>The time in nanosecond at which the event happened </para>        
				/// </summary>
				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "J", AccessFlags = 1)]
				public long Timestamp;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SensorEvent() /* MethodBuilder.Create */ 
				{
				}

		}

}


