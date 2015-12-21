namespace Code
{
    public class String2Int
    {
        static int _maxTen = int.MaxValue / 10;
        static int _maxMod = int.MaxValue % 10;

        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int result = 0, i = 0, n = 0;
            bool negative = false;
            char[] chs = str.ToCharArray();

            for (; i < chs.Length; i++)
            {
                if (chs[i] != ' ' && chs[i] != '\t')
                    break;
            }

            if (chs[i] == '-' || chs[i] == '+')
            {
                if (chs[i] == '-')
                    negative = true;
                i += 1;
            }

            for (; i < chs.Length; i++)
            {
                n = (int)chs[i] - 48;
                if (n >= 0 && n <= 9)
                {
                    if (result > _maxTen || (result == _maxTen && n > _maxMod))
                        return negative ? int.MinValue : int.MaxValue;

                    result = result * 10 + n;
                }
                else
                    break;
            }

            return negative ? 0 - result : result;
        }
    }
}