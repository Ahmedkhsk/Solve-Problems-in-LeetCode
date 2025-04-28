//3. Longest Substring Without Repeating Characters
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string input = "pwwkew";
        int result = solution.LengthOfLongestSubstring(input);
        Console.WriteLine($"The length of the longest substring without repeating characters in '{input}' is: {result}");
    }
}



