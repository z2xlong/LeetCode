using System.Collections.Generic;

namespace Code
{
    public class Transfer
    {
        string[] _wSingle, _wTeen, _wTy, _wScale;

        public Transfer()
        {
            _wSingle = new string[10] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            _wTeen = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            _wTy = new string[8] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            _wScale = new string[4] { "", "Thousand", "Million", "Billion" };
        }

        // 123 -> "One Hundred Twenty Three"
        // 12345 -> "Twelve Thousand Three Hundred Forty Five"
        // 1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
        public string NumberToWords(int num)
        {
            if (num < 0)
                return "";
            if (num == 0)
                return "Zero";
            if (num < 10)
                return _wSingle[num];
            if (num < 20)
                return _wTeen[num - 10];

            string words = string.Empty, tmp = string.Empty;
            int sIdx = -1, n = 0, m1 = 0, mod = 0;

            for (int len = 1; num > 0; len++, num = num / 10)
            {
                n = num % 10;
                mod = len % 3;

                if (mod == 0)
                {
                    if (n != 0)
                        tmp = ConcatWords(string.Format("{0} Hundred", _wSingle[n]), tmp);
                    if (!string.IsNullOrEmpty(tmp))
                        tmp = ConcatWords(tmp, _wScale[sIdx]);
                    words = ConcatWords(tmp, words);
                    tmp = string.Empty;
                }
                else if (mod == 1)
                {
                    sIdx += 1;
                    m1 = n;
                    tmp = _wSingle[m1];
                }
                else if (mod == 2)
                {
                    tmp = this.CombineTenAndSingle(n, m1);
                }
            }

            if (!string.IsNullOrEmpty(tmp))
                words = ConcatWords(ConcatWords(tmp, _wScale[sIdx]), words);
            return words;
        }

        private string ConcatWords(string w1, string w2)
        {
            string sep = !string.IsNullOrEmpty(w1) && !string.IsNullOrEmpty(w2) ? " " : "";
            return string.Format("{0}{1}{2}", w1, sep, w2);
        }

        private string CombineTenAndSingle(int ten, int single)
        {
            if (ten < 1)
            {
                if (single == 0)
                    return "";
                return _wSingle[single];
            }
            else if (ten == 1)
            {
                return _wTeen[single];
            }
            else
            {
                return ConcatWords(_wTy[ten - 2], _wSingle[single]);
            }
        }
    }
}