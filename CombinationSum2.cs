/*
Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.
Each number in candidates may only be used once in the combination.
Note: The solution set must not contain duplicate combinations.
*/
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        CombinationSum2(candidates, target, 0, new List<int>(), result);
        return result;
    }
    
    private void CombinationSum2(int[] candidates, int target, int start, IList<int> current, IList<IList<int>> result){
        if(target == 0){
            result.Add(new List<int>(current));
            return;
        }
        if(target < 0){
            return;
        }
        for(int i = start; i < candidates.Length; i++){
            if(i > start && candidates[i] == candidates[i-1]){
                continue;
            }
            current.Add(candidates[i]);
            CombinationSum2(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}