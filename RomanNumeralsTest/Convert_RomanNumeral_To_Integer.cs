using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumerals.Test
{
    public class Convert_RomanNumeral_To_Integer
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("XIV", 14)]
        [InlineData("XVII", 17)]
        [InlineData("XIX", 19)]
        [InlineData("XXIII", 23)]
        [InlineData("XXIV", 24)]
        [InlineData("XXVI", 26)]
        [InlineData("XXX", 30)]
        public void generator_should_display_one_when_i(string input, int expectedResult)
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();

            //Act -- When
            var actualResult = generator.ToIntenger(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_two_when_ii()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = "II";
            var expectedResult = 2;

            //Act -- When
            var actualResult = generator.ToIntenger(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_three_when_iii()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = "III";
            var expectedResult = 3;

            //Act -- When
            var actualResult = generator.ToIntenger(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_four_when_iv()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = "IV";
            var expectedResult = 4;

            //Act -- When
            var actualResult = generator.ToIntenger(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }


}
