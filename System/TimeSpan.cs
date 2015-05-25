// Copyright (C) 2014 dot42
//
// Original filename: TimeSpan.cs
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

using System.Globalization;
using System.Net;
using System.Text;
using Dot42.Internal;

namespace System
{
    // Summary:
    //     Represents a time interval.
    [Serializable]
    public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable
    {
        public const long TicksPerDay = 864000000000;
        public const long TicksPerHour = 36000000000;
        public const long TicksPerMillisecond = 10000L;
        public const long TicksPerMinute = 600000000L;
        public const long TicksPerSecond = 10000000L;

        public static readonly TimeSpan MaxValue = new TimeSpan(long.MaxValue);
        public static readonly TimeSpan MinValue = new TimeSpan(long.MinValue);
        public static readonly TimeSpan Zero = new TimeSpan(0L);

        private readonly long ticks;

        /// <summary>
        /// Create a new TimeSpan with a number of ticks specified 
        /// </summary>
        /// <param name="ticks">number of ticks (100-nanosecond units = 10.000 ticks/ms)</param>
        public TimeSpan(long ticks)
        {
            this.ticks = ticks;
        }

        public TimeSpan(int hours, int minutes, int seconds)
        {
            this.ticks = CalculateTicks(0, hours, minutes, seconds, 0);
        }

        public TimeSpan(int days, int hours, int minutes, int seconds)
        {
            this.ticks = CalculateTicks(days, hours, minutes, seconds, 0);
        }
       
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
        {
            this.ticks = CalculateTicks(days, hours, minutes, seconds, milliseconds);
        }

        internal static long CalculateTicks(int days, int hours, int minutes, int seconds, int milliseconds)
        {            
            // there's no overflow checks for hours, minutes, ...
            // so big hours/minutes values can overflow at some point and change expected values
            int hrssec = (hours * 3600); // break point at (Int32.MaxValue - 596523)
            int minsec = (minutes * 60);
            long t = ((long)(hrssec + minsec + seconds) * 1000L + (long)milliseconds);
            t *= 10000;

            bool overflow = false;
            // days is problematic because it can overflow but that overflow can be 
            // "legal" (i.e. temporary) (e.g. if other parameters are negative) or 
            // illegal (e.g. sign change).
            if (days > 0)
            {
                long td = TicksPerDay * days;
                if (t < 0)
                {
                    long ticks = t;
                    t += td;
                    // positive days -> total ticks should be lower
                    overflow = (ticks > t);
                }
                else
                {
                    t += td;
                    // positive + positive != negative result
                    overflow = (t < 0);
                }
            }
            else if (days < 0)
            {
                long td = TicksPerDay * days;
                if (t <= 0)
                {
                    t += td;
                    // negative + negative != positive result
                    overflow = (t > 0);
                }
                else
                {
                    long ticks = t;
                    t += td;
                    // negative days -> total ticks should be lower
                    overflow = (t > ticks);
                }
            }

            if (overflow)
            {
               throw new ArgumentOutOfRangeException("The TimeSpan is too big or too small.");
            }

            return t;
        }

        // Summary:
        //     Returns a System.TimeSpan whose value is the negated value of the specified
        //     instance.
        //
        // Parameters:
        //   t:
        //     The time interval to be negated.
        //
        // Returns:
        //     An object that has the same numeric value as this instance, but the opposite
        //     sign.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The negated value of this instance cannot be represented by a System.TimeSpan;
        //     that is, the value of this instance is System.TimeSpan.MinValue.
        public static TimeSpan operator -(TimeSpan t)
        {
            return t.Negate();
        }

        //
        // Summary:
        //     Subtracts a specified System.TimeSpan from another specified System.TimeSpan.
        //
        // Parameters:
        //   t1:
        //     The minuend.
        //
        //   t2:
        //     The subtrahend.
        //
        // Returns:
        //     An object whose value is the result of the value of t1 minus the value of
        //     t2.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The return value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
        {
            return t1.Subtract(t2);
        }

        //
        // Summary:
        //     Indicates whether two System.TimeSpan instances are not equal.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the values of t1 and t2 are not equal; otherwise, false.
        public static bool operator !=(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks != t2.ticks;
        }
        //
        // Summary:
        //     Returns the specified instance of System.TimeSpan.
        //
        // Parameters:
        //   t:
        //     The time interval to return.
        //
        // Returns:
        //     The time interval specified by t.
        public static TimeSpan operator +(TimeSpan t)
        {
            return t;
        }
        //
        // Summary:
        //     Adds two specified System.TimeSpan instances.
        //
        // Parameters:
        //   t1:
        //     The first time interval to add.
        //
        //   t2:
        //     The second time interval to add.
        //
        // Returns:
        //     An object whose value is the sum of the values of t1 and t2.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The resulting System.TimeSpan is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.
        public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
        {
            return t1.Add(t2);
        }
        //
        // Summary:
        //     Indicates whether a specified System.TimeSpan is less than another specified
        //     System.TimeSpan.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the value of t1 is less than the value of t2; otherwise, false.
        public static bool operator <(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks < t2.ticks;
        }
        //
        // Summary:
        //     Indicates whether a specified System.TimeSpan is less than or equal to another
        //     specified System.TimeSpan.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the value of t1 is less than or equal to the value of t2; otherwise,
        //     false.
        public static bool operator <=(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks <= t2.ticks;
        }
        //
        // Summary:
        //     Indicates whether two System.TimeSpan instances are equal.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the values of t1 and t2 are equal; otherwise, false.
        public static bool operator ==(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks == t2.ticks;
        }
        //
        // Summary:
        //     Indicates whether a specified System.TimeSpan is greater than another specified
        //     System.TimeSpan.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the value of t1 is greater than the value of t2; otherwise, false.
        public static bool operator >(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks > t2.ticks;
        }
        //
        // Summary:
        //     Indicates whether a specified System.TimeSpan is greater than or equal to
        //     another specified System.TimeSpan.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the value of t1 is greater than or equal to the value of t2; otherwise,
        //     false.
        public static bool operator >=(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks >= t2.ticks;
        }

        // Summary:
        //     Gets the days component of the time interval represented by the current System.TimeSpan
        //     structure.
        //
        // Returns:
        //     The day component of this instance. The return value can be positive or negative.
        public int Days { get { return (int)(ticks / TicksPerDay); } }
        //
        // Summary:
        //     Gets the hours component of the time interval represented by the current
        //     System.TimeSpan structure.
        //
        // Returns:
        //     The hour component of the current System.TimeSpan structure. The return value
        //     ranges from -23 through 23.
        public int Hours { get { return (int)(ticks % TicksPerDay / TicksPerHour); } }
        //
        // Summary:
        //     Gets the milliseconds component of the time interval represented by the current
        //     System.TimeSpan structure.
        //
        // Returns:
        //     The millisecond component of the current System.TimeSpan structure. The return
        //     value ranges from -999 through 999.
        public int Milliseconds { get { return (int)(ticks % TicksPerSecond / TicksPerMillisecond); } }
        //
        // Summary:
        //     Gets the minutes component of the time interval represented by the current
        //     System.TimeSpan structure.
        //
        // Returns:
        //     The minute component of the current System.TimeSpan structure. The return
        //     value ranges from -59 through 59.
        public int Minutes { get { return (int)(ticks % TicksPerHour / TicksPerMinute); } }
        //
        // Summary:
        //     Gets the seconds component of the time interval represented by the current
        //     System.TimeSpan structure.
        //
        // Returns:
        //     The second component of the current System.TimeSpan structure. The return
        //     value ranges from -59 through 59.
        public int Seconds { get { return (int)(ticks % TicksPerMinute / TicksPerSecond); } }
        //
        // Summary:
        //     Gets the number of ticks that represent the value of the current System.TimeSpan
        //     structure.
        //
        // Returns:
        //     The number of ticks contained in this instance.
        public long Ticks { get { return ticks; } }
        //
        // Summary:
        //     Gets the value of the current System.TimeSpan structure expressed in whole
        //     and fractional days.
        //
        // Returns:
        //     The total number of days represented by this instance.
        public double TotalDays { get { return (double)ticks / TicksPerDay; } }
        //
        // Summary:
        //     Gets the value of the current System.TimeSpan structure expressed in whole
        //     and fractional hours.
        //
        // Returns:
        //     The total number of hours represented by this instance.
        public double TotalHours { get { return (double)ticks / TicksPerHour; } }
        //
        // Summary:
        //     Gets the value of the current System.TimeSpan structure expressed in whole
        //     and fractional milliseconds.
        //
        // Returns:
        //     The total number of milliseconds represented by this instance.
        public double TotalMilliseconds { get { return (double)ticks / TicksPerMillisecond; } }
        //
        // Summary:
        //     Gets the value of the current System.TimeSpan structure expressed in whole
        //     and fractional minutes.
        //
        // Returns:
        //     The total number of minutes represented by this instance.
        public double TotalMinutes { get { return (double)ticks / TicksPerMinute; } }
        //
        // Summary:
        //     Gets the value of the current System.TimeSpan structure expressed in whole
        //     and fractional seconds.
        //
        // Returns:
        //     The total number of seconds represented by this instance.
        public double TotalSeconds { get { return (double)ticks / TicksPerSecond; } }

        // Summary:
        //     Returns a new System.TimeSpan object whose value is the sum of the specified
        //     System.TimeSpan object and this instance.
        //
        // Parameters:
        //   ts:
        //     The time interval to add.
        //
        // Returns:
        //     A new object that represents the value of this instance plus the value of
        //     ts.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The resulting System.TimeSpan is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.
        public TimeSpan Add(TimeSpan ts)
        {
            return new TimeSpan(ticks + ts.Ticks);
        }
        //
        // Summary:
        //     Compares two System.TimeSpan values and returns an integer that indicates
        //     whether the first value is shorter than, equal to, or longer than the second
        //     value.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     One of the following values.Value Description -1 t1 is shorter than t2. 0
        //     t1 is equal to t2. 1 t1 is longer than t2.
        public static int Compare(TimeSpan t1, TimeSpan t2)
        {
            if (t1.Ticks < t2.Ticks)
                return -1;
            if (t1.Ticks > t2.Ticks)
                return 1;
            return 0;
        }
        //
        // Summary:
        //     Compares this instance to a specified object and returns an integer that
        //     indicates whether this instance is shorter than, equal to, or longer than
        //     the specified object.
        //
        // Parameters:
        //   value:
        //     An object to compare, or null.
        //
        // Returns:
        //     One of the following values.Value Description -1 This instance is shorter
        //     than value. 0 This instance is equal to value. 1 This instance is longer
        //     than value.-or- value is null.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     value is not a System.TimeSpan.
        public int CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (!(value is TimeSpan))
            {
                throw new ArgumentException("Argument has to be a TimeSpan.", "value");
            }

            return Compare(this, (TimeSpan)value);
        }
        //
        // Summary:
        //     Compares this instance to a specified System.TimeSpan object and returns
        //     an integer that indicates whether this instance is shorter than, equal to,
        //     or longer than the System.TimeSpan object.
        //
        // Parameters:
        //   value:
        //     An object to compare to this instance.
        //
        // Returns:
        //     A signed number indicating the relative values of this instance and value.Value
        //     Description A negative integer This instance is shorter than value. Zero
        //     This instance is equal to value. A positive integer This instance is longer
        //     than value.
        public int CompareTo(TimeSpan value)
        {
            return Compare(this, value);
        }

        //
        // Summary:
        //     Returns a new System.TimeSpan object whose value is the absolute value of
        //     the current System.TimeSpan object.
        //
        // Returns:
        //     A new object whose value is the absolute value of the current System.TimeSpan
        //     object.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The value of this instance is System.TimeSpan.MinValue.
        public TimeSpan Duration()
        {
            return new TimeSpan(Math.Abs(ticks));
        }
        //
        // Summary:
        //     Returns a value indicating whether this instance is equal to a specified
        //     object.
        //
        // Parameters:
        //   value:
        //     An object to compare with this instance.
        //
        // Returns:
        //     true if value is a System.TimeSpan object that represents the same time interval
        //     as the current System.TimeSpan structure; otherwise, false.
        public override bool Equals(object value)
        {
            if (!(value is TimeSpan))
                return false;

            return ticks == ((TimeSpan)value).ticks;
        }
        //
        // Summary:
        //     Returns a value indicating whether this instance is equal to a specified
        //     System.TimeSpan object.
        //
        // Parameters:
        //   obj:
        //     An object to compare with this instance.
        //
        // Returns:
        //     true if obj represents the same time interval as this instance; otherwise,
        //     false.
        public bool Equals(TimeSpan obj)
        {
            return obj.ticks == ticks;
        }
        //
        // Summary:
        //     Returns a value that indicates whether two specified instances of System.TimeSpan
        //     are equal.
        //
        // Parameters:
        //   t1:
        //     The first time interval to compare.
        //
        //   t2:
        //     The second time interval to compare.
        //
        // Returns:
        //     true if the values of t1 and t2 are equal; otherwise, false.
        public static bool Equals(TimeSpan t1, TimeSpan t2)
        {
            return t1.ticks == t2.ticks;
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of days, where
        //     the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of days, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.
        //
        //   System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromDays(double value)
        {
            return From(value, TicksPerDay);
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of hours, where
        //     the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of hours accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.
        //
        //   System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromHours(double value)
        {
            return From(value, TicksPerHour);
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of milliseconds.
        //
        // Parameters:
        //   value:
        //     A number of milliseconds.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value
        //     is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.
        //
        //   System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromMilliseconds(double value)
        {
            return From (value, TicksPerMillisecond);
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of minutes,
        //     where the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of minutes, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value
        //     is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.
        //
        //   System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromMinutes(double value)
        {
            return From(value, TicksPerMinute);
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of seconds,
        //     where the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of seconds, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value
        //     is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.
        //
        //   System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromSeconds(double value)
        {
            return From(value, TicksPerSecond);
        }

        private static TimeSpan From(double value, long tickMultiplicator)
        {
            if (Double.IsNaN(value))
                throw new ArgumentException("Value cannot be NaN.", "value");

            if (Double.IsInfinity(value) || (value < MinValue.Ticks) || (value > MaxValue.Ticks))
                throw new OverflowException("Outside range [MinValue,MaxValue]");

            try
            {
                value = (value * (tickMultiplicator / TicksPerMillisecond));

                long val = (long)Math.Round(value, MidpointRounding.AwayFromZero);
                return new TimeSpan(val * TicksPerMillisecond);
            }
            catch (OverflowException)
            {
                throw new OverflowException("Resulting timespan is too big.");
            }
        }
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified time, where the specification
        //     is in units of ticks.
        //
        // Parameters:
        //   value:
        //     A number of ticks that represent a time.
        //
        // Returns:
        //     An object that represents value.
        public static TimeSpan FromTicks(long value)
        {
            return new TimeSpan(value);
        }
        //
        // Summary:
        //     Returns a hash code for this instance.
        //
        // Returns:
        //     A 32-bit signed integer hash code.
        public override int GetHashCode()
        {
            return ticks.GetHashCode();
        }
        //
        // Summary:
        //     Returns a new System.TimeSpan object whose value is the negated value of
        //     this instance.
        //
        // Returns:
        //     A new object with the same numeric value as this instance, but with the opposite
        //     sign.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The negated value of this instance cannot be represented by a System.TimeSpan;
        //     that is, the value of this instance is System.TimeSpan.MinValue.
        public TimeSpan Negate()
        {
            if (ticks == MinValue.Ticks)
                throw new OverflowException("This TimeSpan value is MinValue and cannot be negated.");
            
            return new TimeSpan(-ticks);
        }
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent.
        //
        // Parameters:
        //   s:
        //     A string that specifies the time interval to convert.
        //
        // Returns:
        //     A time interval that corresponds to s.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     s is null.
        //
        //   System.FormatException:
        //     s has an invalid format.
        //
        //   System.OverflowException:
        //     s represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components is outside its valid range.
        public static TimeSpan Parse(string s)
        {
            throw new NotImplementedException("System.TimeSpan.Parse");
        }

#if DOTNET_4
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified culture-specific format information.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formatProvider:
        //     An object that supplies culture-specific formatting information.
        //
        // Returns:
        //     A time interval that corresponds to input, as specified by formatProvider.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     input is null.
        //
        //   System.FormatException:
        //     input has an invalid format.
        //
        //   System.OverflowException:
        //     input represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components in input is outside its valid range.
        public static TimeSpan Parse(string input, IFormatProvider formatProvider);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified format and culture-specific format information.
        //     The format of the string representation must match the specified format exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   format:
        //     A standard or custom format string that defines the required format of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        // Returns:
        //     A time interval that corresponds to input, as specified by format and formatProvider.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     input is null.
        //
        //   System.FormatException:
        //     input has an invalid format.
        //
        //   System.OverflowException:
        //     input represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components in input is outside its valid range.
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified array of format strings and culture-specific
        //     format information. The format of the string representation must match one
        //     of the specified formats exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formats:
        //     A array of standard or custom format strings that defines the required format
        //     of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        // Returns:
        //     A time interval that corresponds to input, as specified by formats and formatProvider.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     input is null.
        //
        //   System.FormatException:
        //     input has an invalid format.
        //
        //   System.OverflowException:
        //     input represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components in input is outside its valid range.
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified format, culture-specific format information,
        //     and styles. The format of the string representation must match the specified
        //     format exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   format:
        //     A standard or custom format string that defines the required format of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        //   styles:
        //     A bitwise combination of enumeration values that defines the style elements
        //     that may be present in input.
        //
        // Returns:
        //     A time interval that corresponds to input, as specified by format, formatProvider,
        //     and styles.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     styles is an invalid System.Globalization.TimeSpanStyles value.
        //
        //   System.ArgumentNullException:
        //     input is null.
        //
        //   System.FormatException:
        //     input has an invalid format.
        //
        //   System.OverflowException:
        //     input represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components in input is outside its valid range.
        public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified formats, culture-specific format information,
        //     and styles. The format of the string representation must match one of the
        //     specified formats exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formats:
        //     A array of standard or custom format strings that define the required format
        //     of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        //   styles:
        //     A bitwise combination of enumeration values that defines the style elements
        //     that may be present in input.
        //
        // Returns:
        //     A time interval that corresponds to input, as specified by formats, formatProvider,
        //     and styles.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     styles is an invalid System.Globalization.TimeSpanStyles value.
        //
        //   System.ArgumentNullException:
        //     input is null.
        //
        //   System.FormatException:
        //     input has an invalid format.
        //
        //   System.OverflowException:
        //     input represents a number that is less than System.TimeSpan.MinValue or greater
        //     than System.TimeSpan.MaxValue.-or- At least one of the days, hours, minutes,
        //     or seconds components in input is outside its valid range.
        public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles);
        //
        // Summary:
        //     Returns a new System.TimeSpan object whose value is the difference between
        //     the specified System.TimeSpan object and this instance.
        //
        // Parameters:
        //   ts:
        //     The time interval to be subtracted.
        //
        // Returns:
        //     A new time interval whose value is the result of the value of this instance
        //     minus the value of ts.
        //
        // Exceptions:
        //   System.OverflowException:
        //     The return value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
#endif
        public TimeSpan Subtract(TimeSpan ts)
        {
            return new TimeSpan(ticks - ts.Ticks);
        }
        //
        // Summary:
        //     Converts the value of the current System.TimeSpan object to its equivalent
        //     string representation.
        //
        // Returns:
        //     The string representation of the current System.TimeSpan value.
        public override string ToString()
        {
            return ToString(null);
        }

        public string ToString(IFormatProvider formatProvider)
        {
            StringBuilder sb = new StringBuilder(14);

            if (ticks < 0)
                sb.Append('-');

            if (Days != 0)
            {
                sb.Append(Math.Abs(Days));
                sb.Append('.');
            }

            sb.Append(Math.Abs(Hours).ToString("D2", formatProvider));
            sb.Append(':');
            sb.Append(Math.Abs(Minutes).ToString("D2", formatProvider));
            sb.Append(':');
            sb.Append(Math.Abs(Seconds).ToString("D2", formatProvider));

            int fractional = (int)Math.Abs(ticks % TicksPerSecond);
            if (fractional != 0)
            {
                sb.Append('.');
                sb.Append(fractional.ToString("D7"));
            }

            return sb.ToString();
            
        }

        private static readonly string[] Zeros = { "", "D1", "D2", "D3", "D4", "D5", "D6", "D7" };

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null || format.IsEmpty || format == "g")
                return ToString(formatProvider);

            if (format == "c")
            {
                return ToString(CultureInfo.InvariantCulture);
            }

            StringBuilder sb = new StringBuilder(14);

            if (format == "G")
            {
                if (ticks < 0)
                    sb.Append('-');
                format = "dd':'hh':'mm':'ss'.'fffffff";
            }

            var ts = this;

            DateTimeFormatting.TokenizeFormatString(format, (val, isQuote) =>
            {
                if (isQuote)
                {
                    sb.Append(val);
                }
                else
                {
                    //if (val[0] == '-')
                    //{
                    //    if (ts.ticks < 0)
                    //        sb.Append('-');
                    //    return;
                    //}

                    if (val[0] == 'f')
                    {
                        int fractional = (int) Math.Abs(ts.ticks%TicksPerSecond);
                        sb.Append(Math.Abs(fractional).ToString("D7", formatProvider).Substring(0, val.Length));
                        return;
                    }
                    if (val[0] == 'F')
                    {
                        int fractional = (int) Math.Abs(ts.ticks%TicksPerSecond);
                        if (fractional != 0)
                            sb.Append(Math.Abs(fractional).ToString("D7", formatProvider).Substring(0, val.Length));
                        return;
                    }

                    if (val[0] == 'd')
                    {
                        var zeroes = val.Length > Zeros.Length ? Zeros[val.Length - 1] : Zeros[val.Length];
                        sb.Append(Math.Abs(ts.Days).ToString(zeroes, formatProvider));
                        return;
                    }

                    if(val.Length > 2)
                        throw new FormatException();

                    if (val[0] == 'h')
                    {
                        sb.Append(Math.Abs(ts.Hours).ToString(Zeros[val.Length], formatProvider));
                        return;
                    }
                    if (val[0] == 'm')
                    {
                        sb.Append(Math.Abs(ts.Minutes).ToString(Zeros[val.Length], formatProvider));
                        return;
                    }
                    if (val[0] == 's')
                    {
                        sb.Append(Math.Abs(ts.Seconds).ToString(Zeros[val.Length], formatProvider));
                        return;
                    }

                    throw new FormatException();
                }
            });
            return sb.ToString();
        }

#if DOTNET_4
        //
        // Summary:
        //     Converts the value of the current System.TimeSpan object to its equivalent
        //     string representation by using the specified format.
        //
        // Parameters:
        //   format:
        //     A standard or custom System.TimeSpan format string.
        //
        // Returns:
        //     The string representation of the current System.TimeSpan value in the format
        //     specified by the format parameter.
        //
        // Exceptions:
        //   System.FormatException:
        //     The format parameter is not recognized or is not supported.
        public string ToString(string format);
        //
        // Summary:
        //     Converts the value of the current System.TimeSpan object to its equivalent
        //     string representation by using the specified format and culture-specific
        //     formatting information.
        //
        // Parameters:
        //   format:
        //     A standard or custom System.TimeSpan format string.
        //
        //   formatProvider:
        //     An object that supplies culture-specific formatting information.
        //
        // Returns:
        //     The string representation of the current System.TimeSpan value, as specified
        //     by format and formatProvider.
        //
        // Exceptions:
        //   System.FormatException:
        //     The format parameter is not recognized or is not supported.
        public string ToString(string format, IFormatProvider formatProvider);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent and returns a value that indicates whether the conversion succeeded.
        //
        // Parameters:
        //   s:
        //     A string that specifies the time interval to convert.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by s, or System.TimeSpan.Zero if the conversion failed. This parameter
        //     is passed uninitialized.
        //
        // Returns:
        //     true if s was converted successfully; otherwise, false. This operation returns
        //     false if the s parameter is null or System.String.Empty, has an invalid format,
        //     represents a time interval that is less than System.TimeSpan.MinValue or
        //     greater than System.TimeSpan.MaxValue, or has at least one days, hours, minutes,
        //     or seconds component outside its valid range.
        public static bool TryParse(string s, out TimeSpan result);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified culture-specific formatting information,
        //     and returns a value that indicates whether the conversion succeeded.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formatProvider:
        //     An object that supplies culture-specific formatting information.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by input, or System.TimeSpan.Zero if the conversion failed. This
        //     parameter is passed uninitialized.
        //
        // Returns:
        //     true if input was converted successfully; otherwise, false. This operation
        //     returns false if the input parameter is null or System.String.Empty, has
        //     an invalid format, represents a time interval that is less than System.TimeSpan.MinValue
        //     or greater than System.TimeSpan.MaxValue, or has at least one days, hours,
        //     minutes, or seconds component outside its valid range.
        public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified format and culture-specific format information,
        //     and returns a value that indicates whether the conversion succeeded. The
        //     format of the string representation must match the specified format exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   format:
        //     A standard or custom format string that defines the required format of input.
        //
        //   formatProvider:
        //     An object that supplies culture-specific formatting information.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by input, or System.TimeSpan.Zero if the conversion failed. This
        //     parameter is passed uninitialized.
        //
        // Returns:
        //     true if input was converted successfully; otherwise, false.
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result);
        //
        // Summary:
        //     Converts the specified string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified formats and culture-specific format information,
        //     and returns a value that indicates whether the conversion succeeded. The
        //     format of the string representation must match one of the specified formats
        //     exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formats:
        //     A array of standard or custom format strings that define the acceptable formats
        //     of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by input, or System.TimeSpan.Zero if the conversion failed. This
        //     parameter is passed uninitialized.
        //
        // Returns:
        //     true if input was converted successfully; otherwise, false.
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out TimeSpan result);
        //
        // Summary:
        //     Converts the string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified format, culture-specific format information,
        //     and styles, and returns a value that indicates whether the conversion succeeded.
        //     The format of the string representation must match the specified format exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   format:
        //     A standard or custom format string that defines the required format of input.
        //
        //   formatProvider:
        //     An object that provides culture-specific formatting information.
        //
        //   styles:
        //     One or more enumeration values that indicate the style of input.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by input, or System.TimeSpan.Zero if the conversion failed. This
        //     parameter is passed uninitialized.
        //
        // Returns:
        //     true if input was converted successfully; otherwise, false.
        public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
        //
        // Summary:
        //     Converts the specified string representation of a time interval to its System.TimeSpan
        //     equivalent by using the specified formats, culture-specific format information,
        //     and styles, and returns a value that indicates whether the conversion succeeded.
        //     The format of the string representation must match one of the specified formats
        //     exactly.
        //
        // Parameters:
        //   input:
        //     A string that specifies the time interval to convert.
        //
        //   formats:
        //     A array of standard or custom format strings that define the acceptable formats
        //     of input.
        //
        //   formatProvider:
        //     An object that supplies culture-specific formatting information.
        //
        //   styles:
        //     One or more enumeration values that indicate the style of input.
        //
        //   result:
        //     When this method returns, contains an object that represents the time interval
        //     specified by input, or System.TimeSpan.Zero if the conversion failed. This
        //     parameter is passed uninitialized.
        //
        // Returns:
        //     true if input was converted successfully; otherwise, false.
        public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result);
#endif
    }
}

