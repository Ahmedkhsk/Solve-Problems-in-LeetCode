//Two Sum
//https://neetcode.io/problems/two-integer-sum?list=neetcode150


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] arr = { };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    arr = new int[2];
                    arr[0] = i;
                    arr[1] = j;
                }
            }
        }
        return arr;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        if (result.Length > 0)
        {
            Console.WriteLine($"Indices of the two numbers that add up to {target} are: {result[0]} and {result[1]}");
        }
        else
        {
            Console.WriteLine("No two numbers add up to the target.");
        }


    }
}
