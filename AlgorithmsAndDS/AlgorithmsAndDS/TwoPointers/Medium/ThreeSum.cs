using System;
using System.Collections.Generic;

namespace ConsoleApp1.TwoPointers.Medium;

// 15. 3Sum
public class ThreeSum
{
    // Time complexity: O(n^2); Space complexity: O(1).
    public IList<IList<int>> GetThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i-1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum < 0)
                    left++;
                else if (sum > 0)
                    right--;
                else
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    left++;
                    while(left < right && nums[left] == nums[left-1]){
                        left++;
                    }
                }
            }
        }

        return res;
    }
}