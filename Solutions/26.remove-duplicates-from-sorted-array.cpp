/*
 * @lc app=leetcode id=26 lang=cpp
 *
 * [26] Remove Duplicates from Sorted Array
 */
#include "common_header.hpp"

// @lc code=start
class Solution
{
public:
    int removeDuplicates(vector<int>& nums)
    {
        int k = 1;
        int last = nums[0];
        for (int i = 1; i < nums.size(); i++) {
            if (nums[i] == last) {
                continue;
            }

            nums[k++] = nums[i];
            last = nums[i];
        }
        return k;
    }
};
// @lc code=end
