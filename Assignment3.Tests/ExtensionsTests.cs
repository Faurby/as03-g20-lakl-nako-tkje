using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Uri_Is_Secure_If_HTTPS()
        {
            Uri url = new Uri("https://www.google.com");

            var actual = url.isSecure();

            Assert.True(actual);
        }

        [Fact]

        public void Uri_Is_Not_Secure_If_HTTP() {
             Uri url = new Uri("http://www.google.com");

            var actual = url.isSecure();

            Assert.False(actual);
        }

        [Fact]

        public void Word_Count_Is_5() {
            var input = "Hej med dig jeg hedder";

            var count = input.WordCount();

            Assert.Equal(5, count);
        }

        [Fact]

        public void Word_Count_Is_6() {
            var input = "Hej med dig jeg hedder Nadja, 89";

            var count = input.WordCount();

            Assert.Equal(6, count);
        }
    }
}
