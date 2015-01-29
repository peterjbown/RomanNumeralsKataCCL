using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataCCL
{
    public class ArabicToRomanConverter
    {
        private static Dictionary<int, string> _romanNumberStore;
        private StringBuilder _romanNumeralBuilder;
        private int _arabicNumber;

        public ArabicToRomanConverter()
        {
            _romanNumeralBuilder = new StringBuilder();

            _romanNumberStore = new Dictionary<int, string>
            {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" },
            };
        }

        public string Convert(int arabicNumber)
        {
            _arabicNumber = arabicNumber;
            _romanNumeralBuilder.Clear();

            _romanNumberStore
                .Reverse()
                .ToList()
                .ForEach
                (
                    i => romanNumeralAppender(i)
                );

            return _romanNumeralBuilder.ToString();
        }

        private void romanNumeralAppender(KeyValuePair<int, string> keyValuePair)
        {
            while (_arabicNumber >= keyValuePair.Key)
            {
                _arabicNumber -= keyValuePair.Key;
                _romanNumeralBuilder.Append(keyValuePair.Value);
            }
        }
    }
}
