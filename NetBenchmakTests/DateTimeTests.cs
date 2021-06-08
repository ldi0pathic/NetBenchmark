using System;
using NetBenchmark.Benchmarks.DateTime;
using NetBenchmark.Benchmarks.DateTime.Extensions;
using Xunit;

namespace NetBenchmakTests
{
    public class DateTimeTests
    {

        [Fact]
        public void TestTrimDay()
        {
            var date = DateTime.Now;

            var ex1 = date.TrimDay();
            var ex2 = date.Trim2Day();
            var ex3 = date.Trim3Day();

            Assert.Equal(date.Year, ex1.Year);
            Assert.Equal(date.Month, ex1.Month);
            Assert.Equal(date.Day, ex1.Day);

            Assert.Equal(0,ex1.Hour);
            Assert.Equal(0,ex1.Minute);
            Assert.Equal(0,ex1.Second);
            Assert.Equal(0,ex1.Millisecond);

            Assert.Equal(ex1,ex2);
            Assert.Equal(ex1,ex3);
        }

        [Fact]
        public void TestTrimHour()
        {
            var date = DateTime.Now;

            var ex1 = date.TrimHour();
            var ex2 = date.Trim2Hour();
            var ex3 = date.Trim3Hour();

            Assert.Equal(date.Year, ex1.Year);
            Assert.Equal(date.Month, ex1.Month);
            Assert.Equal(date.Day, ex1.Day);
            Assert.Equal(date.Hour, ex1.Hour);

            Assert.Equal(0, ex1.Minute);
            Assert.Equal(0, ex1.Second);
            Assert.Equal(0, ex1.Millisecond);

            Assert.Equal(ex1, ex2);
            Assert.Equal(ex1, ex3);
        }

        [Fact]
        public void TestTrimMinute()
        {
            var date = DateTime.Now;

            var ex1 = date.TrimMinute();
            var ex2 = date.Trim2Minute();
            var ex3 = date.Trim3Minute();

            Assert.Equal(date.Year, ex1.Year);
            Assert.Equal(date.Month, ex1.Month);
            Assert.Equal(date.Day, ex1.Day);
            Assert.Equal(date.Hour, ex1.Hour);
            Assert.Equal(date.Minute, ex1.Minute);

            Assert.Equal(0, ex1.Second);
            Assert.Equal(0, ex1.Millisecond);

            Assert.Equal(ex1, ex2);
            Assert.Equal(ex1, ex3);
        }

        [Fact]
        public void TestTrimSecond()
        {
            var date = DateTime.Now;

            var ex1 = date.TrimSecond();
            var ex2 = date.Trim2Second();
            var ex3 = date.Trim3Second();

            Assert.Equal(date.Year, ex1.Year);
            Assert.Equal(date.Month, ex1.Month);
            Assert.Equal(date.Day, ex1.Day);
            Assert.Equal(date.Hour, ex1.Hour);
            Assert.Equal(date.Minute, ex1.Minute);
            Assert.Equal(date.Second, ex1.Second);

            Assert.Equal(0, ex1.Millisecond);

            Assert.Equal(ex1, ex2);
            Assert.Equal(ex1, ex3);
        }
    }
}
