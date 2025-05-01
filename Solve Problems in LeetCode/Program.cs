//Maximum Number Of Tasks You Can Assign
//https://leetcode.com/problems/maximum-number-of-tasks-you-can-assign/description
public class Solution
{
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);
        Array.Sort(workers);

        int left = 0, right = Math.Min(tasks.Length, workers.Length), result = 0;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (CanAssign(tasks, workers, pills, strength, mid))
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    private bool CanAssign(int[] tasks, int[] workers, int pills, int strength, int k)
    {
        var taskQueue = new Queue<int>(tasks.Take(k).OrderByDescending(t => t));
        var workerList = new List<int>(workers.TakeLast(k)); 

        int pillCount = pills;

        while (taskQueue.Count > 0)
        {
            int task = taskQueue.Dequeue();

            if (workerList.Count == 0) return false;

            if (workerList[workerList.Count - 1] >= task)
            {
                workerList.RemoveAt(workerList.Count - 1);
            }
            else
            {
                if (pillCount == 0) return false;

                int index = workerList.FindIndex(w => w + strength >= task);
                if (index == -1) return false;

                workerList.RemoveAt(index);
                pillCount--;
            }
        }

        return true;
    }
}


public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        int[] tasks = { 10, 15, 30 };
        int[] workers = { 0, 10, 10, 10, 10 };
        int pills = 3;
        int strength = 10;

        Console.WriteLine($"Count of Tasks => {sol.MaxTaskAssign(tasks, workers, pills, strength)}"); 

        Console.ReadLine();
    }
}




