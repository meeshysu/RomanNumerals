using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsEngine
    {
        public static List<string> romanNumerals = new List<string>() { "I" };
        public static List<int> numerals = new List<int>() { 1 };

        public string ToRomanNumeral(int number)
        {
            var index = number - 1;
            return romanNumerals[index];
        }
    }
}

