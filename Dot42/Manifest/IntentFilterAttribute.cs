// Copyright (C) 2014 dot42
//
// Original filename: IntentFilterAttribute.cs
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
using System;

namespace Dot42.Manifest
{
    /// <summary>
    /// Used to specify manifest information about the types of intents an activity, service or broadcast receiver can respond to.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class IntentFilterAttribute : Attribute
    {
        /// <summary>
        /// User readable label for the activity, service or broadcast receiver when that component is
        /// presented to the user as having a specific capability.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for the activity, service or broadcast receiver when that component is
        /// presented to the user as having a specific capability.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The priority that should be given to the activity or broadcast receiver wiuth regard to handling the intent.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Names of allowed intent actions.
        /// <see cref="Android.Content.Intent"/>.
        /// </summary>
        public string[] Actions { get; set; }

        /// <summary>
        /// Names of allowed intent categories.
        /// <see cref="Android.Content.Intent"/>.
        /// </summary>
        public string[] Categories { get; set; }

        /// <summary>
        /// A MIME media type, such as image/jpeg or audio/mpeg4-generic. The subtype can be the asterisk wildcard (*) to indicate that any subtype matches.
        /// <para>
        /// It's common for an intent filter to declare a &lt;data&gt; that includes only the android:mimeType attribute.
        /// </para><para>
        /// Note: MIME type matching in the Android framework is case-sensitive, unlike formal RFC MIME types. As a result, you should always specify MIME types using lowercase letters.
        /// </para>
        /// </summary>
        public string DataMimeType { get; set; }

        /// <summary>
        /// The scheme part of a URI. This is the minimal essential attribute for specifying a URI; at least one scheme attribute must be set for the filter, or none of the other URI attributes are meaningful.
        /// <para>
        /// A scheme is specified without the trailing colon (for example, http, rather than http:).
        /// </para><para>
        /// If the filter has a data type set (the mimeType attribute) but no scheme, the content: and file: schemes are assumed.
        /// </para>
        /// Note: Scheme matching in the Android framework is case-sensitive, unlike the RFC. As a result, you should always specify schemes using lowercase letters.
        /// </summary>
        public string DataScheme { get; set; }

        /// <summary>
        /// The host part of a URI authority. This attribute is meaningless unless a scheme attribute is also specified for the filter.
        /// <para>
        /// Note: host name matching in the Android framework is case-sensitive, unlike the formal RFC. As a result, you should always specify host names using lowercase letters.
        /// </para>
        /// </summary>
        public string DataHost { get; set; }

        /// <summary>
        /// The port part of a URI authority. This attribute is meaningful only if the scheme and host attributes are also specified for the filter.
        /// </summary>
        public string DataPort { get; set; }

        public string DataPath { get; set; }
        public string DataPathPattern { get; set; }
        public string DataPathPrefix { get; set; }


    }
}

