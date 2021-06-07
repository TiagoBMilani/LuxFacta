using DesafioLuxfacta.ConsoleApplication.Challenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesafioLuxfacta.UnitTests
{
    public class LuxfactaChallengeTest
    {
        [Fact]
        public void Numbers_Equals()
        {
            var c = new LuxFacta(1);
            Assert.Equal("1", c.Say());

            c = new LuxFacta(2);
            Assert.Equal("2", c.Say());

            c = new LuxFacta(28);
            Assert.Equal("28", c.Say());
        }

        [Fact]
        public void Lux_Equals()
        {
            var c = new LuxFacta(3);
            Assert.Equal("Lux", c.Say());

            c = new LuxFacta(42);
            Assert.Equal("Lux", c.Say());
        }

        [Fact]
        public void Lux_NotEquals()
        {
            var c = new LuxFacta(40);
            Assert.NotEqual("Lux", c.Say());
        }

        [Fact]
        public void Facta_Equals()
        {
            var c = new LuxFacta(5);
            Assert.Equal("Facta", c.Say());

            c = new LuxFacta(20);
            Assert.Equal("Facta", c.Say());
        }

        [Fact]
        public void Facta_NotEquals()
        {
            var c = new LuxFacta(6);
            Assert.NotEqual("Facta", c.Say());
        }

        [Fact]
        public void LuxFacta_Equals()
        {
            var c = new LuxFacta(15);
            Assert.Equal("LuxFacta", c.Say());

            c = new LuxFacta(300);
            Assert.Equal("LuxFacta", c.Say());
        }

        [Fact]
        public void LuxFacta_NotEquals()
        {
            var c = new LuxFacta(30);
            Assert.NotEqual("LuxFacta", c.Say());
        }
    }
}