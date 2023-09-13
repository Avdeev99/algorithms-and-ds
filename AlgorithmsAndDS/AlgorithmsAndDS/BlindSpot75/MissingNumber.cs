namespace ConsoleApp1.BlindSpot75;

public static class MissingNumber
{
    public static int FindMissingNumber(int[] nums)
    {
        var start = 0;
        var length = nums.Length;

        while (start < length)
        {
            if (nums[start] < length && nums[start] != start)
            {
                (nums[start], nums[nums[start]]) = (nums[nums[start]], nums[start]);
            }
            else
            {
                start++;
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }

        return length;
    }
    
    public static int missingNumber2(int[] nums)
    {
        int sum = 0;
        foreach(int num in nums)
            sum += num;
            
        return (nums.Length * (nums.Length + 1) )/ 2 - sum;
    }
}