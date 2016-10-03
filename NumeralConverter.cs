using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject3
{
    public class NumeralConverter
    {
        private Dictionary<int, string> numerals;

        public NumeralConverter()
        {
            numerals = new Dictionary<int, string>();
            numerals.Add(1000, "M");
            numerals.Add(900, "CM");
            numerals.Add(500, "D");
            numerals.Add(400, "CM");
            numerals.Add(100, "C");
            numerals.Add(90, "XC");
            numerals.Add(50, "L");
            numerals.Add(40, "XL");
            numerals.Add(10, "X");
            numerals.Add(9, "IX");
            numerals.Add(5, "V");
            numerals.Add(4, "IV");
            numerals.Add(1, "I");
        }

        public string ArabicToRoman(int arabic)
        {
            StringBuilder roman = new StringBuilder();
            foreach (var entry in numerals)
            {
                while (arabic >= entry.Key)
                {
                    roman.Append(entry.Value);
                    arabic -= entry.Key;
                }
            }
            return roman.ToString();
        }

        public int RomanTOArabic(string roman)
        {
            int arabic = 0;
            int previousNum = 0;
            int currentNum = 0;
            for (int x = 0; x < roman.Length; x++)
            {
                string RomanCharacter = roman[x].ToString();
                currentNum = numerals.FirstOrDefault(p => p.Value == RomanCharacter).Key;
                if (currentNum > previousNum)
                    arabic -= 2 * previousNum;
                previousNum = currentNum;
                arabic += currentNum;
            }
            return arabic;
        }
    }
}
