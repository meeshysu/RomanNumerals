using System;
using RomanNumerals;
using Xunit;

namespace RomanNumeralsTest
{
    public class Convert_Integer_To_Roman_Numeral
    {
        [Theory]
        [InlineData(74, "LXXIV")]
        [InlineData(77, "LXXVII")]
        [InlineData(80, "LXXX")]
        [InlineData(84, "LXXXIV")]
        [InlineData(89, "LXXXIX")]
        [InlineData(94, "XCIV")]
        [InlineData(97, "XCVII")]
        [InlineData(104, "CIV")]
        [InlineData(507, "DVII")]
        [InlineData(1257, "MCCLVII")]
        [InlineData(2589, "MMDLXXXIX")]
        [InlineData(3999, "MMMCMXCIX")]
        public void generator_should_display_i_when_one(int input, string expectedResult)
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();

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
        public void generator_should_display_vii_when_seven()
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
        public void generator_should_display_viii_when_eight()
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
        public void generator_should_display_IX_when_nine()
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
        public void generator_should_display_x_when_ten()
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

        [Fact]
        public void generator_should_display_xi_when_eleven()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 11;
            var expectedResult = "XI";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xii_when_twelve()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 12;
            var expectedResult = "XII";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xiii_when_thirteen()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 13;
            var expectedResult = "XIII";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xiv_when_fourteen()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 14;
            var expectedResult = "XIV";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xvi_when_sixteen()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 16;
            var expectedResult = "XVI";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xix_when_nineteen()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 19;
            var expectedResult = "XIX";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xvi_when_twentyeight()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 16;
            var expectedResult = "XVI";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_xvi_when_fortynine()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 49;
            var expectedResult = "XLIX";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_L_when_fifty()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 50;
            var expectedResult = "L";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_LX_when_sixty()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 60;
            var expectedResult = "LX";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void generator_should_display_LXX_when_seventy()
        {
            //Arrange -- Given -- Context
            var generator = new RomanNumeralsEngine();
            var input = 70;
            var expectedResult = "LXX";

            //Act -- When
            var actualResult = generator.ToRomanNumeral(input);

            //Assert -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
