using System;
using Xunit;
using System.Linq;
using System.IO;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Prints_String_Reversed()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = "Hej";

            Action<string> reverse = s => System.Console.WriteLine(string.Join("", s.Reverse()));
            reverse(input);

            var actual = writer.GetStringBuilder().ToString().Trim();
            var expected = "jeH";

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Return_Product_Of_Two_Decimals() {
            Func<double, double, double> product = (x, y) => x * y;

            var actual = product(2.5, 3.0);
            var expected = 2.5 * 3.0;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Number_And_String_Is_Numerical_Equal_Return_True() {
            Func<string, int, bool> NumericalEqual = (s, i) => Int32.Parse(s.Trim()) == i;

            var actual = NumericalEqual(" 0042", 42);

            Assert.True(actual);
        }
    }
}
