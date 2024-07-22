using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop05.objectThree
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration duration)
            {
                return Hours == duration.Hours && Minutes == duration.Minutes && Seconds == duration.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds1 - totalSeconds2);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static  bool operator >=(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }

        public static explicit operator bool(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}
