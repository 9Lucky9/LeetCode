﻿namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class MergeTwoSortedListsSolution
    {
        public sealed class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null)
                return list2;
            if (list2 is null)
                return list1;
            var mergedList = new ListNode();
            var current = mergedList;
            do
            {
                if (list1 is not null && list2 is not null)
                {
                    if (list1.val <= list2.val)
                    {
                        current.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        current.next = list2;
                        list2 = list2.next;
                    }
                    current = current.next;
                }
                else
                {
                    current.next = list1 != null ? list1 : list2;
                    return mergedList.next;
                }
            }
            while (true);
        }
    }
}