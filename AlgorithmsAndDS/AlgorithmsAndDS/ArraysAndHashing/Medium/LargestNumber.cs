using System;
using System.Linq;

namespace ConsoleApp1.ArraysAndHashing.Medium;

public class LargestNumber
{
    // Time complexity: O(nlog(n)); Space complexity: O(n).
    public string GetLargestNumber(int[] nums)
    {
        var numStrs = nums
            .Select(num => num.ToString())
            .ToArray();

        Array.Sort(numStrs, (num1, num2) =>
        {
            var opt1 = num1 + num2;
            var opt2 = num2 + num1;

            return opt2.CompareTo(opt1);
        });

        var result = string.Join("", numStrs);

        if (result[0] == '0' && result.Length > 0)
            return "0";

        return result;
    }
}