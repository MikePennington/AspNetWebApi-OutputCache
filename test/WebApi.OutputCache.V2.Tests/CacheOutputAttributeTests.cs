using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApi.OutputCache.V2.Tests
{
    [TestFixture]
    public class CacheOutputAttributeTests
    {
        [Test]
        public void client_timespan_should_convert_units_from_seconds()
        {
            var attr = new CacheOutputAttribute();
            attr.ClientTimeSpanInSeconds = 60 * 60 * 24;

            Assert.AreEqual(60 * 60 * 24, attr.ClientTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ClientTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ClientTimeSpanInHours);
            Assert.AreEqual(1, attr.ClientTimeSpanInDays);
        }

        [Test]
        public void client_timespan_should_convert_units_from_minutes()
        {
            var attr = new CacheOutputAttribute();
            attr.ClientTimeSpanInMinutes = 60 * 24;

            Assert.AreEqual(60 * 60 * 24, attr.ClientTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ClientTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ClientTimeSpanInHours);
            Assert.AreEqual(1, attr.ClientTimeSpanInDays);
        }

        [Test]
        public void client_timespan_should_convert_units_from_hours()
        {
            var attr = new CacheOutputAttribute();
            attr.ClientTimeSpanInHours = 24;

            Assert.AreEqual(60 * 60 * 24, attr.ClientTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ClientTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ClientTimeSpanInHours);
            Assert.AreEqual(1, attr.ClientTimeSpanInDays);
        }

        [Test]
        public void client_timespan_should_convert_units_from_days()
        {
            var attr = new CacheOutputAttribute();
            attr.ClientTimeSpanInDays = 1;

            Assert.AreEqual(60 * 60 * 24, attr.ClientTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ClientTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ClientTimeSpanInHours);
            Assert.AreEqual(1, attr.ClientTimeSpanInDays);
        }

        [Test]
        public void server_timespan_should_convert_units_from_seconds()
        {
            var attr = new CacheOutputAttribute();
            attr.ServerTimeSpanInSeconds = 60 * 60 * 24;

            Assert.AreEqual(60 * 60 * 24, attr.ServerTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ServerTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ServerTimeSpanInHours);
            Assert.AreEqual(1, attr.ServerTimeSpanInDays);
        }

        [Test]
        public void server_timespan_should_convert_units_from_minutes()
        {
            var attr = new CacheOutputAttribute();
            attr.ServerTimeSpanInMinutes = 60 * 24;

            Assert.AreEqual(60 * 60 * 24, attr.ServerTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ServerTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ServerTimeSpanInHours);
            Assert.AreEqual(1, attr.ServerTimeSpanInDays);
        }

        [Test]
        public void server_timespan_should_convert_units_from_hours()
        {
            var attr = new CacheOutputAttribute();
            attr.ServerTimeSpanInHours = 24;

            Assert.AreEqual(60 * 60 * 24, attr.ServerTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ServerTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ServerTimeSpanInHours);
            Assert.AreEqual(1, attr.ServerTimeSpanInDays);
        }

        [Test]
        public void server_timespan_should_convert_units_from_days()
        {
            var attr = new CacheOutputAttribute();
            attr.ServerTimeSpanInDays = 1;

            Assert.AreEqual(60 * 60 * 24, attr.ServerTimeSpanInSeconds);
            Assert.AreEqual(60 * 24, attr.ServerTimeSpanInMinutes);
            Assert.AreEqual(24, attr.ServerTimeSpanInHours);
            Assert.AreEqual(1, attr.ServerTimeSpanInDays);
        }
    }
}
