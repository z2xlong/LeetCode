namespace Code
{
    public class Transfer
    {
        string[] _wSingle, _wTens, _wLarge;

        public Transfer()
        {
            _wSingle = new string[20] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                                "Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
            _wTens = new string[8] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            _wLarge = new string[4] { "Hundred", "Thousand", "Million", "Billion" };
        }

        // 123 -> "One Hundred Twenty Three"
        // 12345 -> "Twelve Thousand Three Hundred Forty Five"
        // 1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
        public string NumberToWords(int num)
        {
            if (num < 0)
                return "";
            if (num < _wSingle.Length)
                return _wSingle[num];

            string words = string.Empty;
            int len = 1, tenNum = 0;

            while (num > 0)
            {
                tenNum = tenNum + num % 10;

                len += 1;
                num = num / 10;
            }

            return words;
        }
    }
}