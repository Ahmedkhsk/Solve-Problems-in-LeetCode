//Contains Duplicate
//https://neetcode.io/problems/duplicate-integer?list=neetcode150
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length ; i++)
        {
            if (keyValuePairs.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                keyValuePairs.Add(nums[i], i);
            }
        }

        return false;
    }

}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.hasDuplicate(new int[] { 1, 2, 3, 3, 5 })); // true

    }
}
