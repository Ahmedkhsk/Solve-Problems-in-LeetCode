//Count Largest Group
//https://leetcode.com/problems/count-largest-group/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        Dictionary<int, int> groupCounts = new Dictionary<int, int>();

        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            int num = i;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (groupCounts.ContainsKey(sum))
                groupCounts[sum]++;
            else
                groupCounts[sum] = 1;
        }

        int maxSize = groupCounts.Values.Max();

        int count = groupCounts.Values.Count(v => v == maxSize);

        return count;
    }

}
public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        int num = 13;

        Console.WriteLine(sol.CountLargestGroup(num));


    }
}
