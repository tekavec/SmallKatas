using System.Text;

namespace Katas
{
    public class RomanNumerals
    {
        private readonly string[] _RomanStrings = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        private readonly int[] _ArabicValues = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

        public string GetRomanFromArabic(int arabic)
        {
            var result = new StringBuilder();
            var remains = arabic;
            for (int i = 0; i < _RomanStrings.Length; i++)
            {
                remains = AppendRomanNumerals(remains, result, _RomanStrings[i], _ArabicValues[i]);
            }
            return result.ToString();
        }

        private static int AppendRomanNumerals(
            int remains, 
            StringBuilder result, 
            string romanNumeral, 
            int arabic)
        {
            while (remains >= arabic)
            {
                result.Append(romanNumeral);
                remains -= arabic;
            }
            return remains;
        }
    }
}