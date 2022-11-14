/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);
            if(!dict.ContainsKey(key))
            {
                dict.Add(key, new List<string>());
            }
            dict[key].Add(str);
        }
        IList<IList<string>> result = new List<IList<string>>();
        foreach(var item in dict)
        {
            result.Add(item.Value);
        }
        return result;
    }
}