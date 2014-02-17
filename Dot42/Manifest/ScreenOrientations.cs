// Copyright (C) 2014 dot42
//
// Original filename: ScreenOrientations.cs
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
namespace Dot42.Manifest
{
    public enum ScreenOrientations
	{
        /// <summary>
        /// Default. System choose the orientation.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Use the users preferred orientation.
        /// </summary>
        User = 1,

        /// <summary>
        /// Uses the same orientation as used by the activity that's immediately beneath it in the activity stack.
        /// </summary>
        Behind = 2,

        /// <summary>
        /// Landscape orientation.
        /// </summary>
        Landscape = 3,

        /// <summary>
        /// Portrait orientation.
        /// </summary>
        Portrait = 4,

        /// <summary>
        /// Landscape orientation in opposite direction from normal landscape.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.3 (Gingerbread)
        /// </remarks>
        [AndroidVersion(9)]
        ReverseLandscape = 5,

        /// <summary>
        /// Portrait orientation in opposite direction from normal portrait.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.3 (Gingerbread)
        /// </remarks>
        [AndroidVersion(9)]
        ReversePortrait = 6,

        /// <summary>
        /// Landscape orientation. Can be normal or reverse based on the device sensor.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.3 (Gingerbread)
        /// </remarks>
        [AndroidVersion(9)]
        SensorLandscape = 7,

        /// <summary>
        /// Portrait orientation. Can be normal or reverse based on the device sensor.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.3 (Gingerbread)
        /// </remarks>
        [AndroidVersion(9)]
        SensorPortrait = 8,

        /// <summary>
        /// Orientation is determined by the device orientation sensor.
        /// Some devices will not rotate to all 4 orientations by default. To allow all 4 orientations, use <see cref="FullSensor"/>.
        /// </summary>
        Sensor = 9,

        /// <summary>
        /// Orientation is determined by the device orientation sensor in all 4 orientations.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.3 (Gingerbread)
        /// </remarks>
        [AndroidVersion(9)]
        FullSensor = 10,

        /// <summary>
        /// Orientation is determined without using the device orientation sensor.
        /// </summary>
        NoSensor = 11
	}
}

