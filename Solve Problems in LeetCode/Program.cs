//Group Anagrams
//https://neetcode.io/problems/anagram-groups?list=neetcode150


public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();

        foreach (string str in strs)
        {
            string sorted = new string (str.OrderBy(c => c).ToArray());

            if(!map.ContainsKey(sorted))
            {
                map[sorted] = new List<string>();
            }
            map[sorted].Add(str);
        }
        return map.Values.ToList();
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();



    }
}
