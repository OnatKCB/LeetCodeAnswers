/*
You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].
Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at nums[i], you can jump to any nums[i + j] where:
0 <= j <= nums[i] and
i + j < n
Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].
*/
public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        for(int i = 1; i < n; i++){
            dp[i] = int.MaxValue;
        }
        for(int i = 0; i < n; i++){
            for(int j = 1; j <= nums[i] && i + j < n; j++){
                dp[i + j] = Math.Min(dp[i + j], dp[i] + 1);
            }
        }
        return dp[n - 1];
    }
}