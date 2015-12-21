using System;
using System.Text;
using System.Collections.Generic;

namespace Code
{
    public class Transfer
    {
        static string[] _wSingle = new string[10] { "", " One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine" };
        static string[] _wTeen = new string[10] { " Ten", " Eleven", " Twelve", " Thirteen", " Fourteen", " Fifteen", " Sixteen", " Seventeen", " Eighteen", " Nineteen" };
        static string[] _wTy = new string[8] { " Twenty", " Thirty", " Forty", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };
        static string[] _wScale = new string[4] { "", " Thousand", " Million", " Billion" };


        // 123 -> "One Hundred Twenty Three"
        // 12345 -> "Twelve Thousand Three Hundred Forty Five"
        // 1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            int n = 0, sIdx = 0, s = 0, t = 0;
            StringBuilder sb = new StringBuilder();

            while (num > 0)
            {
                n = num % 1000;
                num = num / 1000;
                if (n > 0)
                {
                    sb.Insert(0, _wScale[sIdx]);

                    s = n % 10;
                    t = (n / 10) % 10;
                    if (t == 1)
                        sb.Insert(0, _wTeen[s]);
                    else
                    {
                        sb.Insert(0, _wSingle[s]);
                        if (t > 1)
                            sb.Insert(0, _wTy[t - 2]);
                    }


                    n = n / 100;
                    if (n > 0)
                    {
                        sb.Insert(0, " Hundred");
                        sb.Insert(0, _wSingle[n]);
                    }
                }
                sIdx += 1;
            }

            return sb.ToString().Trim();
        }
    }
}