var solution = new Solution();

var roman = "LVIII";

var integer = solution.RomanToInt(roman);

System.Console.WriteLine(integer);

public class Solution
{
    public int GetValue(char digit)
    {
        if (digit == 'I') return 1;

        if (digit == 'V') return 5;

        if (digit == 'X') return 10;

        if (digit == 'L') return 50;

        if (digit == 'C') return 100;

        if (digit == 'D') return 500;

        if (digit == 'M') return 1000;

        return -1;
    }

    public int RomanToInt(string s)
    {
        var number = 0;

        for (var i = 0; i < s.Length - 1; i++)
        {
            var value = GetValue(s[i]);

            var nextValue = GetValue(s[i + 1]);

            if (value < nextValue)
            {
                number -= value;
            }
            else
            {

                number += value;
            }
        }

        number += GetValue(s.Last());

        return number;
    }
}