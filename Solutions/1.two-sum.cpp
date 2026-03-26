/*
 * @lc app=leetcode id=1 lang=cpp
 *
 * [1] Two Sum
 */
#include "common_header.hpp"

// @lc code=start
class Solution
{
public:
    vector<int> twoSum(vector<int> &nums, int target)
    {
        unordered_map<int, int> dict(nums.size());
        for (int i = 0; i < nums.size(); i++)
        {
            int complement = target - nums[i];
            if (dict.contains(complement))
            {
                return {dict[complement], i};
            }
            dict[nums[i]] = i;
        }
        return {};
    }
};
// @lc code=end
