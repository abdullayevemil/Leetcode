var solution = new Solution();

var number = 121;

var isPalindrome = solution.IsPalindrome(number);

Console.WriteLine(isPalindrome);

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int reversedNumber = 0;

        int copy = x;

        while (copy != 0)
        {
            reversedNumber = reversedNumber * 10 + copy % 10;

            copy /= 10;
        }

        return x == reversedNumber;
    }
}