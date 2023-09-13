using System.Collections.Generic;

namespace ConsoleApp1.BlindSpot75
{
    public static class TwoSum
    {
        public static int[] TwoSum1(int[] nums, int target) {
            var dictionary = new Dictionary<int, int>();
            var result = new int[2];
        
            for (var i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                var difference = target - number;
                var isInDictionary = dictionary.ContainsKey(difference);
            
                if (isInDictionary)
                {
                    result = new int[] { dictionary[difference], i };
                    return result;
                }
                else
                {
                    if (!dictionary.ContainsKey(number))
                    {
                        dictionary.Add(number, i);
                    }
                }
            }
        
            return result;
        }
    }
}