//Maximum manhattan distance after K changes
//https://leetcode.com/problems/maximum-manhattan-distance-after-k-changes/description


public class Solution
{
    public int MaxDistance(string s, int k)
    {
        int maxD = 0 , prevD = 0 , currentD = 0 , x = 0, y = 0 , step;
        List<int> steps = new List<int>();

        foreach (char c in s)
        {
            prevD = Math.Abs(x) + Math.Abs(y);

            if (c == 'N') y++;
            else if (c == 'S') y--;
            else if (c == 'E') x++;
            else if (c == 'W') x--;

            currentD = Math.Abs(x) + Math.Abs(y);
            maxD = Math.Max(maxD, currentD);
        }
        
        step = currentD - prevD;
        if(step > 0)
            steps.Add(step);
        else
            steps.Add(-step);
        

    }
}


public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

    }
}
