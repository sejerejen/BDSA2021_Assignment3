using System;
using Xunit;
using System.Linq;
namespace BDSA2020.Assignment02.Tests
{
    public class DelegatesTests
    {

        [Fact]
        public void reverseString()
        {
            // arrange
            string s = "hej";
            var reverseS = s.ToCharArray()
                       .Select(c => c.ToString()).ToArray()
                       .Aggregate((c1,c2) => c2 + c1);
            // act
            var expected = "jeh";
            var actual = reverseS;

            // assert
            Assert.Equal(expected,actual);
        }


        [Fact]
        public void productOfTwoDecimals()
        {
            
            //arrange
            Func<double, double, double> product = (double x1, double x2) => {return (x1 * x2);} ;

            // act
            double actual = product(1.5, 2.7);
            double expected = 1.5 * 2.7;

            // assert
            Assert.Equal(expected,actual);

        }

        [Fact]
        public void compareStringAndIntTrue()
        {
            // arrange 
            Func<string, int, bool> compareStringAndInt = (string s, int i) => {return i.ToString() == s.TrimStart('0');} ;

            // act
            bool actual = compareStringAndInt("00042", 42);

            // assert
            Assert.True(actual);

        }
    }
}
