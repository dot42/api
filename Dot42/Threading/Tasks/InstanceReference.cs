// Copyright (C) 2014 dot42
//
// Original filename: InstanceReference.cs
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
using Android.App;

namespace Dot42.Threading.Tasks
{
	public class InstanceReference
	{
        protected internal object Instance { get; private set; }
        protected string InstanceId { get; private set; }

        public InstanceReference(Activity activity)
            :this(activity, null)
        { 
        }

        public InstanceReference(Activity activity, string instanceId)
        {
            if (activity == null) throw new ArgumentNullException("activity");

            Instance = activity;
            InstanceId = instanceId ?? string.Empty;
        }

#if ANDROID_11P
        public InstanceReference(Fragment fragment)
            : this(fragment, null)
        {
        }

        public InstanceReference(Fragment fragment, string instanceId)
        {
            if (fragment == null) throw new ArgumentNullException("fragment");

            Instance = fragment;
            InstanceId = instanceId ?? string.Empty;
        }
#endif

        protected virtual int GetHashCode()
        {
            return Instance.GetType().FullName.GetHashCode() + InstanceId.GetHashCode();
        }
	}
}

