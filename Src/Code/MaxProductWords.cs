namespace Code
{
    using System;

    // Maximum Product of Word Lengths
    // Given a string array words, find the maximum value of length(word[i]) * length(word[j]) 
    // where the two words do not share common letters. 
    // You may assume that each word will contain only lower case letters. If no such two words exist, return 0.
    // Example 1:
    // Given ["abcw", "baz", "foo", "bar", "xtfn", "abcdef"]
    // Return 16
    // The two words can be "abcw", "xtfn".
    public class MaxProductWords
    {
        public int MaxProduct(string[] array)
        {
            if (array == null || array.Length < 2)
                return 0;

            int[] ascii = new int[128];
            int prelen = 0, max = 0, cn = 0, j = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                j = i + 1;
                foreach (char c in array[i])
                {
                    cn = (int)c;
                    if (ascii[cn] == j)
                        prelen = 0;
                    ascii[cn] = i;
                }
                max = Math.Max(max, prelen * array[i].Length);
            }

            return max;
        }
    }
}