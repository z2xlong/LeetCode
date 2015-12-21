namespace Code
{
    using System;

    public class RepeatingSubstring
    {
        // Given a string, find the length of the longest substring without repeating characters. 
        //For example, the longest substring without repeating letters for "abcabcbb" is "abc", 
        //which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return 1;

            int[] ascii = new int[128];
            int idx = 0, max = 0, step = 0, tmp = 0;

            for (int i = 0; i < s.Length; i++)
            {
                idx = (int)s[i];
                if (ascii[idx] == 1)
                {
                    max = Math.Max(max, i - step);
                    do
                    {
                        tmp = (int)s[step];
                        ascii[tmp] = 0;
                        step += 1;
                    } while (step < i && tmp != idx);
                }
                ascii[idx] = 1;
            }

            return Math.Max(max, s.Length - step);
        }
    }
}