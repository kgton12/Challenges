namespace LeetCode.Completed;

public static class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new(0);
        ListNode op = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                op.next = list1;
                list1 = list1.next;
            }
            else
            {
                op.next = list2;
                list2 = list2.next;
            }
            op = op.next;
        }

        op.next = list1 ?? list2;
        return dummy.next;
    }
}


public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}