//Count the Number of Arrays with K Matching Adjacent Elements
//https://leetcode.com/problems/count-the-number-of-arrays-with-k-matching-adjacent-elements/description
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    const int MOD = 1_000_000_007;
    const int MAX = 100005;

    long[] fact = new long[MAX];
    long[] invFact = new long[MAX];

    public Solution()
    {
        fact[0] = invFact[0] = 1;

        for (int i = 1; i < MAX; i++)
            fact[i] = (fact[i - 1] * i) % MOD;

        invFact[MAX - 1] = ModInverse(fact[MAX - 1]);
        for (int i = MAX - 2; i >= 1; i--)
            invFact[i] = (invFact[i + 1] * (i + 1)) % MOD;
    }

    long ModInverse(long x) => ModPow(x, MOD - 2);

    long ModPow(long a, int b)
    {
        long res = 1;
        while (b > 0)
        {
            if ((b & 1) == 1)
                res = (res * a) % MOD;
            a = (a * a) % MOD;
            b >>= 1;
        }
        return res;
    }

    long Comb(int n, int k)
    {
        if (k < 0 || k > n) return 0;
        return (((fact[n] * invFact[k]) % MOD) * invFact[n - k]) % MOD;
    }

    public int CountGoodArrays(int n, int m, int k)
    {
        long comb = Comb(n - 1, k);
        long pow = ModPow(m - 1, n - 1 - k);
        long result = ((comb * pow) % MOD * m) % MOD;
        return (int)result;
    }
}

public class Program
{
    public static void Main()
    {
        var sol = new Solution();
        int n = 4, m = 2, k = 2;

        Console.WriteLine(sol.CountGoodArrays(n,m,k));


    }
}
