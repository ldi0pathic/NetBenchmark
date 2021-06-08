namespace NetBenchmark.Benchmarks.DateTime.Extensions
{
    public static class DateTime2Extension
    {
        public static System.DateTime Trim2Day(this System.DateTime date) => new System.DateTime(date.Year, date.Month, date.Day);

        public static System.DateTime Trim2Hour(this System.DateTime date) => new System.DateTime(date.Year, date.Month, date.Day, date.Hour, 0,0);

        public static System.DateTime Trim2Minute(this System.DateTime date) => new System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);

        public static System.DateTime Trim2Second(this System.DateTime date) => new System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute,  date.Second);

    }
}
