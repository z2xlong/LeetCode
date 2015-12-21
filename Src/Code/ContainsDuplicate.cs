namespace Code
{
    using System.Collections.Generic;

    // Given an array of integers, find if the array contains any duplicates. 
	// Your function should return true if any value appears at least twice in the array, 
	// and it should return false if every element is distinct.
    public class ContainsDuplicate
    {
        public bool Test(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return false;

            int i = 0;
            HashSet<int> hash = new HashSet<int>();

            while (i < nums.Length)
            {
                hash.Add(nums[i]);
                if ((i++) > hash.Count)
                    return true;
            }

            return i > hash.Count;
        }
    }
}