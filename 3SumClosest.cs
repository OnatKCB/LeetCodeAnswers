/*
Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.
*/
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        Array.Sort(nums);
        int result = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int low = i + 1;
            int high = nums.Length - 1;
            while (low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if (Math.Abs(sum - target) < Math.Abs(result - target))
                    result = sum;
                if (sum > target)
                    high--;
                else if (sum < target)
                    low++;
                else
                    return sum;
            }
        }
        return result;
    }
}