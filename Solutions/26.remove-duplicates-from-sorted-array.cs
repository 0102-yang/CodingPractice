/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
namespace _26;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        int last = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == last) {
                continue;
            }

            nums[k++] = nums[i];
            last = nums[i];
        }
        return k;
    }
}
// @lc code=end
