﻿namespace AlgorithmsExercises;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode();
        var head = dummy;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val < list2.val)
            {
                dummy.next = list1;
                list1 = list1.next;
            }
            else
            {
                dummy.next = list2;
                list2 = list2.next;
            }

            dummy = dummy.next;
        }

        dummy.next = list1 ?? list2;

        return head.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
