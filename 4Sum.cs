/*
Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:

0 <= a, b, c, d < n
a, b, c, and d are distinct.
nums[a] + nums[b] + nums[c] + nums[d] == target
You may return the answer in any order.
*/
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        if(nums.Length < 4) return result;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 3; i++){
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1; j < nums.Length - 2; j++){
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;
                var start = j + 1;
                var end = nums.Length - 1;
                while(start < end){
                    var sum = nums[i] + nums[j] + nums[start] + nums[end];
                    if(sum == target){
                        var list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[start]);
                        list.Add(nums[end]);
                        result.Add(list);
                        start++;
                        end--;
                        while(start < end && nums[start] == nums[start - 1]) start++;
                        while(start < end && nums[end] == nums[end + 1]) end--;
                    }else if(sum < target){
                        start++;
                    }else{
                        end--;
                    }
                }
            }
        }
        return result;
    }
}