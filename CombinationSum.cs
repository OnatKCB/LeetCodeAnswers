/*
Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. 
You may return the combinations in any order.
The same number may be chosen from candidates an unlimited number of times. 
Two combinations are unique if the frequency of at least one of the chosen numbers is different.
The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
*/
public class Solution {
    List<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        List<int> cur = new List<int>();
        CombinationSum(candidates, target, 0, cur);
        return ans;
    }
    
    void CombinationSum(int[] candidates, int target, int index, List<int> cur){
        if(target == 0){
            ans.Add(new List<int>(cur));
            return;
        }
        for(int i = index; i < candidates.Length && candidates[i] <= target; i++){
            cur.Add(candidates[i]);
            CombinationSum(candidates, target - candidates[i], i, cur);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}