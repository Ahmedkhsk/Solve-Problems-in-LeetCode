//Push Dominoes
//https://leetcode.com/problems/push-dominoes/description
public class Solution
{
    public string PushDominoes(string dominoes)
    {
        int n = dominoes.Length;
        int[] forces = new int[n];
        int force = 0;

        for (int i = 0; i < n; i++)
        {
            if (dominoes[i] == 'R')
            {
                force = n;
            }
            else if (dominoes[i] == 'L')
            {
                force = 0;
            }
            else
            {
                force = Math.Max(force - 1, 0);
            }
            forces[i] += force;
        }

        force = 0;
        
        for (int i = n-1 ; i >= 0; i--)
        {
            if (dominoes[i] == 'L')
            {
                force = n;
            }
            else if (dominoes[i] == 'R')
            {
                force = 0;
            }
            else
            {
                force = Math.Max(force - 1, 0);
            }
            forces[i] -= force;
        }

        char[] result = new char[n];

        for (int i = 0; i < n ; i++)
        {
            if (forces[i] > 0)
                result[i] = 'R';
            else if(forces[i] < 0)
                result[i] = 'L';
            else
                result[i] = '.';
        }

        return new string(result);
    }

}


public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        
        Console.WriteLine($"result of LL.RR.LLRRLL.. is {sol.PushDominoes("LL.RR.LLRRLL..")}");

        Console.ReadLine();
    }
}




