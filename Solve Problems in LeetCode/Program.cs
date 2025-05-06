//Build Array from Permutation
//https://leetcode.com/problems/build-array-from-permutation/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            nums[i] = nums[i] + n * (nums[nums[i]] % n);
        }
        for (int i = 0; i < n; i++)
        {
            nums[i] = nums[i] / n;
        }
        return nums;
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();

        int[] nums = { 0, 2, 1, 5, 3, 4 };
        int[] result = sol.BuildArray(nums);
        Console.WriteLine(string.Join(", ", result)); // Output: [0, 1, 2, 4, 5, 3]


    }
}
