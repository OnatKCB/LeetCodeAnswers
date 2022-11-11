/*
You are given a string s and an array of strings words. All the strings of words are of the same length.
A concatenated substring in s is a substring that contains all the strings of any permutation of words concatenated.
For example, if words = ["ab","cd","ef"], then "abcdef", "abefcd", "cdabef", "cdefab", "efabcd", and "efcdab" are all concatenated strings. 
"acdbef" is not a concatenated substring because it is not the concatenation of any permutation of words.
Return the starting indices of all the concatenated substrings in s. You can return the answer in any order.
*/
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if(s == null || s.Length == 0 || words == null || words.Length == 0) return result;
        var wordLength = words[0].Length;
        var wordCount = words.Length;
        var wordMap = new Dictionary<string, int>();
        foreach(var word in words){
            if(wordMap.ContainsKey(word)){
                wordMap[word]++;
            }else{
                wordMap.Add(word, 1);
            }
        }
        for(int i = 0; i <= s.Length - wordLength * wordCount; i++){
            var map = new Dictionary<string, int>(wordMap);
            var j = 0;
            while(j < wordCount){
                var word = s.Substring(i + j * wordLength, wordLength);
                if(map.ContainsKey(word)){
                    map[word]--;
                    if(map[word] == 0){
                        map.Remove(word);
                    }
                }else{
                    break;
                }
                j++;
            }
            if(map.Count == 0){
                result.Add(i);
            }
        }
        return result;
    }
}