namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 169. Majority Element
public class MajorityElement
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetMajorityElement(int[] nums)
    {
        var major = nums[0];
        var count = 1;

        for(var i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                count++;
                major = nums[i];
            }
            else if (major == nums[i])
            {
                count++;
            }
            else count--;
            
        }
        
        return major;
    }
}