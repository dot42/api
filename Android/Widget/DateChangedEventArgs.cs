// Copyright (C) 2014 dot42
//
// Original filename: DateChangedEventArgs.cs
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

namespace Android.Widget
{
	public class DateChangedEventArgs : EventArgs
	{
	    public DateChangedEventArgs(int year, int monthOfYear, int dayOfMonth)
	    {
	        DayOfMonth = dayOfMonth;
	        MonthOfYear = monthOfYear;
	        Year = year;
	    }

        /// <summary>
        /// The year that was set.
        /// </summary>
	    public int Year { get; private set; }

        /// <summary>
        /// The month that was set (0-11) for compatibility with Calendar.
        /// </summary>
        public int MonthOfYear { get; private set; }

        /// <summary>
        /// The day of the month that was set.
        /// </summary>
        public int DayOfMonth { get; private set; }
    }
}

