/*
Given an integer array nums, find the subarray which has the largest sum and return its sum.
*/
public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        int max = nums[0];
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(sum > max)
            {
                max = sum;
            }
            if(sum < 0)
            {
                sum = 0;
            }
        }
        return max;
    }
}