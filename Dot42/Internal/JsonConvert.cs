// Copyright (C) 2014 dot42
//
// Original filename: JsonConvert.cs
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
using System.Text;
using System.Text.RegularExpressions;
using Org.Json;

namespace Dot42.Internal
{
	internal static class JsonConvert
	{
        public static string ToString(string input)
        {
            return JSONObject.Quote(input);
        }

        public static string Unescape(string escaped)
        {
            var tokenizer = new JSONTokener(escaped);
            return (tokenizer.NextValue().ToString());
        }

        public static string ToString(bool input)
        {
            return input ? "true" : "false";
        }

        public static string ToString(DateTime dateTime)
        {
            var millis = (dateTime.Ticks / TimeSpan.TicksPerMillisecond) - DateTime.EraDifferenceInMs;
            var offset = DateTime.GetUtcOffset();
            return string.Format(@"/Date({0}{1}{2:D2}{3:D2})/", millis.ToString(), offset.Hours >=0? "+" : "-", offset.Hours, offset.Minutes);
        }

        public static DateTime ToDateTime(string input)
        {
            const string pattern = @"/Date\((?<millis>\d+)(?<offset>[+|-]\d+)?\)/";
            var regEx = new Regex(pattern);
            var match = regEx.Match(input);
            if (!match.Success)
            {
               throw new FormatException(string.Format("JSON DateTime '{0}' cannot be parsed", input));  
            }
            var millis = match.Groups["millis"];
            //for now omit the offset.
            //var offset = match.Groups["offset"];

            return new DateTime((long.Parse(millis.Value) + DateTime.EraDifferenceInMs)*TimeSpan.TicksPerMillisecond);
        }

        public static string ToString(TimeSpan timeSpan)
        {
            //ISO8601 format:  [-]PnYnMnDTnHnMnS, where: 
            // nY represents the number of years,
            // nM the number of months, 
            // nD the number of days, 
            // 'T' is the date/time separator, 
            // nH the number of hours,
            // nM the number of minutes and 
            // nS the number of seconds. The number of seconds can include decimal digits to arbitrary precision.

            var builder = new StringBuilder();
            if (timeSpan.Ticks < 0)
            {
                builder.Append('-');
            }
            builder.Append('P');

            builder.Append(Math.Abs(timeSpan.Days));
            builder.Append('D');

            builder.Append('T');

            builder.Append(Math.Abs(timeSpan.Hours));
            builder.Append('H');

            builder.Append(Math.Abs(timeSpan.Minutes));
            builder.Append('M');

            builder.Append(Math.Abs(timeSpan.Seconds));
            builder.Append('.');
            builder.Append(string.Format("{0:D3}", Math.Abs(timeSpan.Milliseconds)));
            builder.Append('S');

            return builder.ToString();
        }

        public static TimeSpan ToTimeSpan(string input)
        {
            const string pattern = @"(?<sign>[+|-])?P((?<years>\d+)Y)?((?<months>\d+)M)?((?<days>\d+)D)?(T((?<hours>\d+)H)?((?<minutes>\d+)M)?((?<seconds>\d+(\.\d+)?)S)?)?";
            var regEx = new Regex(pattern);
            var match = regEx.Match(input);
            if (!match.Success)
            {
                throw new FormatException(string.Format("JSON TimeSpan '{0}' cannot be parsed", input));
            }

            bool neg = false;
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            int milliseconds = 0;

            var sign = match.Groups["sign"];
            if (sign.Success && sign.Value == "-")
            {
                neg = true;
            }

            //currently we do not support years and months (.NET never uses them)
            if (match.Groups["years"].Success || match.Groups["months"].Success) throw new FormatException(string.Format("JSON TimeSpan '{0}' cannot be parsed, year or month included", input));

            var daysGroup = match.Groups["days"];
            if (daysGroup.Success)
            {
                days = int.Parse(daysGroup.Value);
            }

            var hoursGroup = match.Groups["hours"];
            if (hoursGroup.Success)
            {
                hours = int.Parse(hoursGroup.Value);
            }

            var minutesGroup = match.Groups["minutes"];
            if (minutesGroup.Success)
            {
                minutes = int.Parse(minutesGroup.Value);
            }

            var secondsGroup = match.Groups["seconds"];
            if (secondsGroup.Success)
            {
                var secondsAndMillis = double.Parse(secondsGroup.Value);
                seconds = (int) Math.Floor(secondsAndMillis);
                milliseconds = (int) Math.Round(((secondsAndMillis - seconds)*1000));
            }

            var timeSpan = new TimeSpan(days, hours, minutes, seconds, milliseconds);

            return neg ? timeSpan.Negate() : timeSpan;
        }

	}
}

