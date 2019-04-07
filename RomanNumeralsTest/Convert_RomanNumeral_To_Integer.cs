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
        [InlineData("XLVII", 47)]
        [InlineData("XLIX", 49)]
        [InlineData("L", 50)]
        [InlineData("LVIII", 58)]
        [InlineData("LIX", 59)]
        [InlineData("LXIV", 64)]
        [InlineData("LXXVIII", 78)]
        [InlineData("MMMCMXCIX", 3999)]
        public void generator_should_display_one_when_i(string input, int expectedResult)
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();

            //Act -- When
            var actualResult = generator.ToIntenger(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }


}
