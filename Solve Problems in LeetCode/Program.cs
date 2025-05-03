//Minimum Domino Rotations For Equal Row
//https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        int length = tops.Length;

        int mostFrequentTops = GetMostFrequent(tops);
        int mostFrequentBottoms = GetMostFrequent(bottoms);

        int result = Math.Min(CountRotations(tops, bottoms, mostFrequentTops),
                              CountRotations(tops, bottoms, mostFrequentBottoms));

        return result == int.MaxValue ? -1 : result;
    }

    private int GetMostFrequent(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        return dict.OrderByDescending(x => x.Value).First().Key;
    }

    private int CountRotations(int[] tops, int[] bottoms, int target)
    {
        int rotationsTops = 0, rotationsBottoms = 0;
        int length = tops.Length;

        for (int i = 0; i < length; i++)
        {
            if (tops[i] != target && bottoms[i] != target)
                return int.MaxValue; 
            else if (tops[i] != target)
                rotationsTops++;
            else if (bottoms[i] != target)
                rotationsBottoms++; 
        }


        return Math.Min(rotationsTops, rotationsBottoms);
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();

        Console.WriteLine($"MinDominoRotations (tops = [2, 1, 2, 4, 2, 2], bottoms = [5, 2, 6, 2, 3, 2]): {sol.MinDominoRotations(new int[] { 2, 1, 2, 4, 2, 2 }, new int[] { 5, 2, 6, 2, 3, 2 })}"); //output -1
        Console.WriteLine($"MinDominoRotations (tops = [1, 2, 1, 1, 1, 2, 2, 2], bottoms = [2, 1, 2, 2, 2, 2, 2, 2]): {sol.MinDominoRotations(new int[] { 1, 2, 1, 1, 1, 2, 2, 2 }, new int[] { 2, 1, 2, 2, 2, 2, 2, 2 })}"); //output 1
        Console.ReadLine();
    }
}
