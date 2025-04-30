//Find Numbers with Even Number of Digits
//https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int count = 0;
        foreach(var num in nums)
        {
            int digitCount = 0, n = num;
            while(n > 0)
            {
                n /= 10;
                digitCount++;
            }
            if (digitCount % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
              
    }
}



