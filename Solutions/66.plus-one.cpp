/*
 * @lc app=leetcode id=66 lang=cpp
 *
 * [66] Plus One
 */
#include "common_header.hpp";

// @lc code=start
class Solution
{
public:
    vector<int> plusOne(vector<int>& digits)
    {
        bool carry = true;
        for (int i = digits.size() - 1; i >= 0 && carry; i--) {
            int sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
        }

        if (digits[0] == 0) {
            digits.insert(digits.begin(), 1);
        }
        return digits;
    }
};
// @lc code=end
