/*
You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
Merge all the linked-lists into one sorted linked-list and return it.
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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0) return null;
        return Merge(lists, 0, lists.Length - 1);
    }
    
    private ListNode Merge(ListNode[] lists, int start, int end){
        if(start == end) return lists[start];
        int mid = start + (end - start) / 2;
        var left = Merge(lists, start, mid);
        var right = Merge(lists, mid + 1, end);
        return MergeTwoLists(left, right);
    }
    
    private ListNode MergeTwoLists(ListNode left, ListNode right){
        if(left == null) return right;
        if(right == null) return left;
        if(left.val < right.val){
            left.next = MergeTwoLists(left.next, right);
            return left;
        }else{
            right.next = MergeTwoLists(left, right.next);
            return right;
        }
    }
}