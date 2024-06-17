var solution = new Solution();

var index = solution.StrStr("sadbutsad", "sad");

Console.WriteLine(index);

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (needle == haystack.Substring(i, needle.Length))
            {
                return i;
            }
        }

        return -1;
    }
}