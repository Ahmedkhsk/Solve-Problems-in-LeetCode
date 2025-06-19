//Partition Array Such That Maximum Difference Is K
//https://leetcode.com/problems/partition-array-such-that-maximum-difference-is-k/description


public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);
        int count = 1; 
        int start = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] - nums[start] > k) 
            {
                count++;
                start = i;
            }
        }

        return count;
    }
}


public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.PartitionArray(new int[] { 3, 6, 1, 2, 5 }, 2));
        Console.WriteLine(solution.PartitionArray(new int[] { 1, 2, 3 }, 1));
        Console.WriteLine(solution.PartitionArray(new int[] { 2, 2, 4, 5 }, 0));

    }
}
