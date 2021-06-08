using System;

namespace NetBenchmark.Benchmarks.DateTime.Extensions
{
    public static class DateTimeExtension
    {
        private static System.DateTime Trim(this System.DateTime date, long roundTicks)
        {
            return new System.DateTime(date.Ticks - date.Ticks % roundTicks, date.Kind);
        }

        public static System.DateTime TrimDay(this System.DateTime date) => date.Trim(TimeSpan.TicksPerDay);

        public static System.DateTime TrimHour(this System.DateTime date) => date.Trim(TimeSpan.TicksPerHour);

        public static System.DateTime TrimMinute(this System.DateTime date) => date.Trim(TimeSpan.TicksPerMinute);

        public static System.DateTime TrimSecond(this System.DateTime date) => date.Trim(TimeSpan.TicksPerSecond);
    }
}
