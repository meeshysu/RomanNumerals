using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsEngine
    {

        public static List<string> romanNumerals = new List<string>()
            {
                "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"
            };
        public static List<int> integers = new List<int>()
            {
                1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1
            };

        public string ToRomanNumeral(int number)
        {
            var NewRomanNumeralString = "";
            while (number > 0)
            {
                //find the biggest numeral that is less than or equal to our number
                var index = integers.FindIndex(x => x <= number);
                //subtract it's value from the number
                number -= integers[index];
                //put it on to the end of your roman numeral
                NewRomanNumeralString += romanNumerals[index];
            }
            //return the new empty string that now has been filled with our answer
            return NewRomanNumeralString.ToString();
        }

        public int ToIntenger(string romanNumeral)
        {
            Dictionary<char, int> RomanNumeralToIntegers = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            var totalNumbers = 0;
            var previousNumbers = 0;

            foreach (var character in romanNumeral)
            {
                var currentNumber = RomanNumeralToIntegers[character];
                totalNumbers += currentNumber;

                if(previousNumbers !=0 && previousNumbers < currentNumber)
                {
                    if (previousNumbers == 1 && (currentNumber == 5 || currentNumber == 10)
                        || previousNumbers == 10 && (currentNumber == 50 || currentNumber == 100)
                        || previousNumbers == 100 && (currentNumber == 1000))
                    {
                        totalNumbers -= 2 * previousNumbers;
                    }
                    else return 0;
                }
                previousNumbers = currentNumber;
            }
            return totalNumbers;
        }
    }

}








