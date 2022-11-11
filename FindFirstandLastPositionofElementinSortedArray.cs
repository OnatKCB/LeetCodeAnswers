/*
Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
If target is not found in the array, return [-1, -1].
You must write an algorithm with O(log n) runtime complexity.
*/
public class Solution {
    public int[] SearchRange(int[] nums, int target) 
    {
        var result = new int[2];
        result[0] = FindFirst(nums, target);
        result[1] = FindLast(nums, target);
        return result;
    }
    
    int FindFirst(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            if(nums[mid] == target)
            {
                if(mid == 0 || nums[mid - 1] != target) return mid;
                right = mid - 1;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
    
    int FindLast(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            if(nums[mid] == target)
            {
                if(mid == nums.Length - 1 || nums[mid + 1] != target) return mid;
                left = mid + 1;
            }
            else if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}