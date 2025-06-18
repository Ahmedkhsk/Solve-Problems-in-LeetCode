//Divide Array Into Arrays With Max Difference
//https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/description/


public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);
        int n = nums.Length;
        List<int[]> result = new List<int[]>();

        for (int i = 0; i < n; i += 3)
        {
            int a = nums[i];
            int b = nums[i + 1];
            int c = nums[i + 2];

            if (c - a > k)
            {
                return new int[0][];
            }

            result.Add(new int[] { a, b, c });
        }

        return result.ToArray();
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        int[][] arr = solution.DivideArray(new int[] { 1, 2, 3, 4, 5, 6 }, 2);

        if (arr.Length == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            foreach (var subArray in arr)
            {
                Console.WriteLine($"[{string.Join(", ", subArray)}]");
            }
        }

    }
}
