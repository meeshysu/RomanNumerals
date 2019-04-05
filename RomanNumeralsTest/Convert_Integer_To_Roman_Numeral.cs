using System;
using RomanNumerals;
using Xunit;

namespace RomanNumeralsTest
{
    public class Convert_Integer_To_Roman_Numeral
    {
        [Fact]
        public void generator_should_display_i_when_one()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 1;
            var expectedResult = "I";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_ii_when_two()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 2;
            var expectedResult = "II";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_iii_when_three()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 3;
            var expectedResult = "III";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_iv_when_four()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 4;
            var expectedResult = "IV";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_v_when_five()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 5;
            var expectedResult = "V";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_vi_when_seven()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 7;
            var expectedResult = "VII";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_iv_when_eight()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 8;
            var expectedResult = "VIII";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_iv_when_nine()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 9;
            var expectedResult = "IX";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void generator_should_display_iv_when_ten()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 10;
            var expectedResult = "X";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
