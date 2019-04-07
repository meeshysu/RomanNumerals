using System;
using Integers;
using Xunit;

namespace Convert_Roman_Numeral_To_Integer
{
    public class Convert_RomanNumeral_To_Integer
    {
        [Theory]
        [InlineData("I", 1)]
        public void generator_should_display_one_when_i(string input, int expectedResult)
        {
            //Arrange -- Context -- GIVEN
            var calculator = new IntegersEngine();

            //Act -- Do the thing -- WHEN
            var actualResult = calculator.ToInteger(input);

            //Assert -- Checking the result -- THEN
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
