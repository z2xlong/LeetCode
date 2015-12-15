namespace Code
{
    public class Transfer
    {
        string[] _wSingle, _wTeen, _wTy, _wLarge;

        public Transfer()
        {
            _wSingle = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            _wTeen = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            _wTy = new string[8] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            _wLarge = new string[3] { "Thousand", "Million", "Billion" };
        }

        // 123 -> "One Hundred Twenty Three"
        // 12345 -> "Twelve Thousand Three Hundred Forty Five"
        // 1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
        public string NumberToWords(int num)
        {
            if (num < 0)
                return "";
            if (num < 10)
                return _wSingle[num];
            if (num < 20)
                return _wTeen[num];

            string words = string.Empty;
            int single = 0, lgIdx = 0, n = 0;

            for (int len = 1; num > 0; len++, single = n)
            {
                n = num % 10;
                num = num / 10;
                if (n == 0)
                    continue;

                if (len % 3 == 0)
                {
                    words = string.Format("{0} Hundred {1}", _wSingle[n], words);
                }
                else if (len % 3 == 1 && len > 1)
                {
                    words = string.Format("{0}{1} {2}", num > 0 ? "" : _wSingle[n]+" ", _wLarge[lgIdx], words);
                    lgIdx += 1;
                }
                else if (len % 3 == 2)
                    words = string.Format("{0} {1}", this.CombineTenAndSingle(n, single), words);
            }

            return words;
        }

        private string CombineTenAndSingle(int ten, int single)
        {
            if (ten < 1)
            {
                if (single == 0)
                    return "";
                return "and " + _wSingle[single];
            }
            else if (ten == 1)
            {
                return _wTeen[single];
            }
            else
            {
                return string.Format("{0} {1}", _wTy[ten - 2], _wSingle[single]);
            }
        }
    }
}