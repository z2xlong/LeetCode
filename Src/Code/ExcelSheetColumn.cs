namespace Code
{
    public class ExcelSheetColumn
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int result = 0, n = 0;

            foreach (char c in s)
            {
                if (c == ' ' || c == '\t')
                    continue;

                if (c >= 'A' && c <= 'Z')
                    n = c - 'A' + 1;
                else if (c >= 'a' && c <= 'z')
                    n = c - 'a' + 1;
                else
                    return 0;

                if (result > (int.MaxValue - n) / 26)
                    return int.MaxValue;

                result = result * 26 + n;
            }

            return result;
        }

        public string NumberToTitle(int n)
        {
            return string.Empty;
        }
    }
}