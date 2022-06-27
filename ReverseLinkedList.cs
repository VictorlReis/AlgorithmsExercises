namespace AlgorithmsExercises;

public class ReverseLinkedList
{
    ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        while (head is not null)
        {
            var control = head.next;
            head.next = prev;
            prev = head;
            head = control;
        }

        return prev;
    }

    //ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null))))));
}