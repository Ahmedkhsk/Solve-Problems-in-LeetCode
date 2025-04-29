//Palindrome Number
//https://leetcode.com/problems/palindrome-number/description/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        List<int> numbers = new List<int>();

        if (x < 0 || (x != 0 && x % 10 == 0))
            return false;

        while (x > 0)
        {
            numbers.Add(x % 10);
            x /= 10;
        }

        for(int i = 0; i<numbers.Count / 2; i++)
        {
            if (numbers[i] != numbers[numbers.Count - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
              
    }
}



