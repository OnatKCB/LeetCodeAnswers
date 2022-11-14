/*
Given the head of a linked list, rotate the list to the right by k places.
*/
public class Solution 
{
    public ListNode RotateRight(ListNode head, int k) 
    {
        if(head == null)
        {
            return null;
        }
        int length = 1;
        ListNode tail = head;
        while(tail.next != null)
        {
            tail = tail.next;
            length++;
        }
        k = k % length;
        if(k == 0)
        {
            return head;
        }
        tail.next = head;
        for(int i = 0; i < length - k; i++)
        {
            tail = tail.next;
        }
        ListNode newHead = tail.next;
        tail.next = null;
        return newHead;
    }
}