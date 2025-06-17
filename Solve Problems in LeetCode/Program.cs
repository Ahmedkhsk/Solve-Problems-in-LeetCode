//Count Subarrays of Length Three With a Condition
//https://leetcode.com/problems/count-subarrays-of-length-three-with-a-condition/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int CountSubarrays(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (i + 2 >= nums.Length)
                break;

            if (2 * (nums[i] + nums[i + 2]) == nums[i + 1])
                count++;

        }
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        int[] arr = [1, 2, 1, 4, 1];

        Console.WriteLine(sol.CountSubarrays(arr));


    }
}
