//Number of Equivalent Domino Pairs
//https://leetcode.com/problems/number-of-equivalent-domino-pairs/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dict = new Dictionary<(int, int),int>();
        int result = 0;

        foreach (var domino in dominoes)
        {
            int min = Math.Min(domino[0], domino[1]);
            int max = Math.Max(domino[0],domino[1]);

            var key = (min, max);

            if (dict.ContainsKey(key))
            {
                result += dict[key];
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }

        }
        
        
            
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();

        var result = sol.NumEquivDominoPairs(new int[][] {
            new int[] {1,2},
            new int[] {2,1},
            new int[] {3,4},
            new int[] {5,6}
        });

        Console.WriteLine(result); // Output: 1

    }
}
