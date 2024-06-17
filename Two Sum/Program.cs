var solution = new Solution();

var numbers = new int[] { 3, 3 };

var target = 6;

var indexes = solution.TwoSum(numbers, target);

foreach (var index in indexes)
{
    System.Console.WriteLine(index);
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { };
    }
}