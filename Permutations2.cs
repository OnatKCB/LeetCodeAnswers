/*
Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.
*/
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        PermuteUnique(nums, 0, result);
        return result;
    }
    
    private void PermuteUnique(int[] nums, int start, List<IList<int>> result)
    {
        if (start == nums.Length)
        {
            result.Add(new List<int>(nums));
            return;
        }
        
        var set = new HashSet<int>();
        for (int i = start; i < nums.Length; i++)
        {
            if (set.Contains(nums[i])) continue;
            set.Add(nums[i]);
            Swap(nums, start, i);
            PermuteUnique(nums, start + 1, result);
            Swap(nums, start, i);
        }
    }
    
    private void Swap(int[] nums, int i, int j)
    {
        if (i != j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}