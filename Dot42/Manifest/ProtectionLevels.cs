// Copyright (C) 2014 dot42
//
// Original filename: ProtectionLevels.cs
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
	public enum ProtectionLevels
	{
        /// <summary>
        /// The default value. A lower-risk permission that gives requesting applications access to isolated application-level features, 
        /// with minimal risk to other applications, the system, or the user. The system automatically grants this type of permission to 
        /// a requesting application at installation, without asking for the user's explicit approval (though the user always has the option 
        /// to review these permissions before installing).
        /// </summary>
        Normal = 0,

        /// <summary>
        /// A higher-risk permission that would give a requesting application access to private user data or control over the device that can
        /// negatively impact the user. Because this type of permission introduces potential risk, the system may not automatically grant it 
        /// to the requesting application. For example, any dangerous permissions requested by an application may be displayed to the user and 
        /// require confirmation before proceeding, or some other approach may be taken to avoid the user automatically allowing the use of such facilities.
        /// </summary>
        Dangerous = 1,

        /// <summary>
        /// A permission that the system grants only if the requesting application is signed with the same certificate as the application that 
        /// declared the permission. If the certificates match, the system automatically grants the permission without notifying the user or 
        /// asking for the user's explicit approval.
        /// </summary>
        Signature = 2,

        /// <summary>
        /// A permission that the system grants only to applications that are in the Android system image or that are signed with the same certificates 
        /// as those in the system image. Please avoid using this option, as the <see cref="Signature"/> protection level should be sufficient for most needs and 
        /// works regardless of exactly where applications are installed. This permission is used for certain special situations 
        /// where multiple vendors have applications built into a system image and need to share specific features explicitly because they are being
        /// built together.
        /// </summary>
        SignatureOrSystem = 3
	}
}

