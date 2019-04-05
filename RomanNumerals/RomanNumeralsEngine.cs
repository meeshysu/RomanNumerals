using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    //Using information that already written and tested to refactor code that was becoming too complicated.
    public class RomanNumeralsEngine
    {
        public string ToRomanNumeral(int number)
        {
            //Instead of using just a string, also implement a dictionary to hold all roman numerals.
            Dictionary<int, string> RomanNumerals = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

           var NewRomanNumeralString = new StringBuilder();

           foreach ( var numeral in RomanNumerals)
            {
                while (number >= numeral.Key)
                {
                    NewRomanNumeralString.Append(numeral.Value);
                    number -= numeral.Key;
                }
            }
            return NewRomanNumeralString.ToString();
        }
    }
}


