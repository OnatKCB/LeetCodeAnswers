/*
Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
k is a positive integer and is less than or equal to the length of the linked list. 
If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
You may not alter the values in the list's nodes, only nodes themselves may be changed.
*/
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
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode();
        dummy.next = head;
        var current = dummy;
        while(current != null){
            current = Reverse(current, k);
        }
        return dummy.next;
    }
    
    private ListNode Reverse(ListNode head, int k){
        var current = head;
        for(int i = 0; i < k; i++){
            current = current.next;
            if(current == null) return null;
        }
        var first = head.next;
        var last = current;
        var prev = last.next;
        ReverseList(first, last);
        first.next = prev;
        head.next = last;
        return first;
    }
    
    private void ReverseList(ListNode first, ListNode last){
        ListNode prev = null;
        var current = first;
        while(current != last){
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        current.next = prev;
    }
}