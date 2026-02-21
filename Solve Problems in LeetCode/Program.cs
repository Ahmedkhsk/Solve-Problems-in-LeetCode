public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0, maxLength = 1;
        void ExpandAroundCenter(int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int length = right - left + 1;
                if (length > maxLength)
                {
                    start = left;
                    maxLength = length;
                }
                left--;
                right++;
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            ExpandAroundCenter(i, i); 
            ExpandAroundCenter(i, i + 1); 
        }
        return s.Substring(start, maxLength);
    }

}





public class Program
{
    public static void Main()
    {
        Solution sol = new Solution();
 
        string input = "aaaaasd323babad";
        string result = sol.LongestPalindrome(input);
        Console.WriteLine($"Longest palindromic substring of '{input}' is: '{result}'");
    }
}
