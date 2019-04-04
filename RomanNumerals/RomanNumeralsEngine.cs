using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsEngine
    {
        //public static List<string> romanNumerals = new List<string>() { "I" };
        //public static List<int> numerals = new List<int>() { 1 };

        public string ToRomanNumeral(int number)
        {
            //var index = number - 1;
            //return romanNumerals[index];

            var result = "";
            //reset the counter
            var counter = number;

            if (counter >= 9 && counter < 19)
            {
                counter -= 10;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "X";
            }

            if (counter >= 4 && counter < 9)
            {
                counter = counter - 5;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "V";
                while (counter > 0)
                {
                    result += "I";
                    counter -= 1;
                }
            }

            if (counter >= 9)
            {
                counter -= 10;
                result += "X";
            }

            if (counter <= 3)
            {
                while (counter > 0)
                {
                    result += "I";
                    counter -= 1;
                }
            }
            return result;
        }
    }
}
