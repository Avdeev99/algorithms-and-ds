namespace ConsoleApp1.BlindSpot75;

public static class RemoveDuplicates
{
    public static int Remove(int[] nums) {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        var id = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[id++] = nums[i];
            }
        }

        return id;
    }
}