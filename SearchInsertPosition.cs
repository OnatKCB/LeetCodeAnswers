/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.
You must write an algorithm with O(log n) runtime complexity.
*/
public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        var left = 0;
        var right = nums.Length - 1;
        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            if(nums[mid] == target) return mid;
            if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}