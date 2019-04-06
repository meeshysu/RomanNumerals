using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    //Using information that already written and tested to refactor code that was becoming too complicated.
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
    }

}








