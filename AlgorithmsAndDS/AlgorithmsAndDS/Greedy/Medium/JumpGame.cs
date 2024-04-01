namespace AlgorithmsAndDS.Greedy.Medium;

// 55. Jump Game
public class JumpGame
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool CanJump(int[] nums)
    {
        var goal = nums.Length - 1;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            var canReach = (i + nums[i]) >= goal;

            if (canReach)
                goal = i;
        }

        return goal == 0;
    }

    // Time complexity: O(n^2); Space complexity: O(n).
    public bool CanJump2(int[] nums) {
        var visited = new HashSet<int>();

        bool Dfs(int i)
        {
            if (i == nums.Length - 1)
                return true;

            if (visited.Contains(i))
                return false;

            visited.Add(i);

            var jump = 1;

            while (jump <= nums[i])
            {
                var attempt = Dfs(i + jump);

                if (attempt)
                    return true;

                jump++;
            }

            return false;
        }

        return Dfs(0);
    }
}