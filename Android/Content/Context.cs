using System;
using Android.OS;

namespace Android.Content
{
    partial class Context
    {
        /// <summary>
        ///  <para>Launch a new activity. You will not receive any information about when the activity exits.</para> <para>Note that if this method is being called from outside of an android.app.Activity Context, then the Intent must include the Intent#FLAG_ACTIVITY_NEW_TASK launch flag. This is because, without being started from an existing Activity, there is no existing task in which to place the new activity and thus it needs to be placed in its own separate task.</para> <para>This method throws ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivity(Intent) </para> <para>PackageManager::resolveActivity </para></para>        
        /// </summary>
        public void StartActivity(Type activityType)
        {
            StartActivity(new Intent(this, activityType));
        }
    }
}
