using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        var romanToIntMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        
        for(int i =0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && romanToIntMap[s[i]] < romanToIntMap[s[i + 1]])
            {
                total -= romanToIntMap[s[i]];
            }
            else
            {
                total += romanToIntMap[s[i]];
            }

        }
        return total;
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();

        // Example usage
        string romanNumeral = "III"; // Example Roman numeral
        int result = sol.RomanToInt(romanNumeral);
        Console.WriteLine($"The integer value of the Roman numeral {romanNumeral} is: {result}");

    }
}
