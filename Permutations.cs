/*
Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.
*/

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        PermuteHelper(result, new List<int>(), nums);
        return result;
    }
    
    public void PermuteHelper(IList<IList<int>> result, IList<int> list, int[] nums)
    {
        if(list.Count == nums.Length)
        {
            result.Add(new List<int>(list));
            return;
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(list.Contains(nums[i])) continue;
            list.Add(nums[i]);
            PermuteHelper(result, list, nums);
            list.RemoveAt(list.Count - 1);
        }
    }
}