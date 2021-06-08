using System;

namespace NetBenchmark.Benchmarks.DateTime.Extensions
{
    public static class DateTime3Extension
    {
        private static System.DateTime Trim(this System.DateTime date, long roundTicks)
        {
            return date.AddTicks(-(date.Ticks % roundTicks));
        }

        public static System.DateTime Trim3Day(this System.DateTime date) => date.Trim(TimeSpan.TicksPerDay);

        public static System.DateTime Trim3Hour(this System.DateTime date) => date.Trim(TimeSpan.TicksPerHour);

        public static System.DateTime Trim3Minute(this System.DateTime date) => date.Trim(TimeSpan.TicksPerMinute);

        public static System.DateTime Trim3Second(this System.DateTime date) => date.Trim(TimeSpan.TicksPerSecond);
    }
}
