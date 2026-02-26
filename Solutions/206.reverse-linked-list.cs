/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

using CommonLibrary;

namespace _206;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) {
            return null;
        }
        if (head.next == null) {
            return head;
        }

        ListNode next_head = this.ReverseList(head.next);
        ListNode temp_tail = head.next;
        head.next = null;
        temp_tail.next = head;

        return next_head;
    }
}
// @lc code=end
