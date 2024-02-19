namespace AlgorithmsAndDS.BlindSpot75
{
    public static class ThreeSum
    {
        public static IList<IList<int>> ThreeSum2(int[] nums)
        {
            var result = new List<IList<int>>();

            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i-1])
                {
                    continue;
                }

                var l = i + 1;
                var r = nums.Length - 1;

                while (l < r)
                {
                    var sum = nums[i] + nums[l] + nums[r];

                    if (sum > 0)
                    {
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        result.Add(new int[] { nums[i], nums[l], nums[r] });
                        r--;

                        while (l < r && nums[r] == nums[r + 1]) r--;
                    }
                }
            }

            return result;
        }
    }
}