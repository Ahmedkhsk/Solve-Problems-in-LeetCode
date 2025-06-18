//Valid Anagram
//https://neetcode.io/problems/is-anagram?list=neetcode150
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        string sortedS = new string(s.OrderBy(c => c).ToArray());
        string sortedT = new string(t.OrderBy(c => c).ToArray());

        return sortedS.SequenceEqual(sortedT);
        
    }
}
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.IsAnagram("racecar", "carrace"));

    }
}
