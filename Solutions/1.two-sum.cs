/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

namespace _1;

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dict.TryGetValue(complement, out int value)) {
                return [value, i];
            }
            dict[nums[i]] = i;
        }
        return [];
    }
}
// @lc code=end
