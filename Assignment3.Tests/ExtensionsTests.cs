using System;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData("https://github.com/sejerejen/BDSA2021_Assignment3")]
        [InlineData("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-5.0")]
        [InlineData("https://learnit.itu.dk/my/")]
        public void checkIfUriSchemeIsSecureIsTrue(string s)
        {
            // arrange
            Uri uri = new Uri(s);
        
            // act
            bool actual = uri.IsSecure();

            // assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("http://erdetsnartfredag.dk/")]
        [InlineData("http://www.hvadsigerjakob.dk/")]
        public void checkIfUriSchemeIsSecureIsFalse(string s)
        {
            // arrange
            Uri uri = new Uri(s);
        
            // act
            bool actual = uri.IsSecure();

            // assert
            Assert.False(actual);
        }


        [Theory]
        [InlineData("hej med dig", 3)]
        [InlineData("farvel", 1)]
        [InlineData("         ", 0)]
        [InlineData("he!j med d1ig du er godt nok sej", 6)]
        [InlineData("e e e 1e 11e1 e e1", 4)]
        public void checkWordCount(string s, int expected)
        {
            // arrange
            int count = s.WordCount();
        
            // act
            int actual = count ;
            // assert

            Assert.Equal(expected, actual);
        }


    }
}
