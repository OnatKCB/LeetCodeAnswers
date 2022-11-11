/*
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
*/
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle == null || needle.Length == 0) return 0;
        if(haystack == null || haystack.Length == 0) return -1;
        for(int i = 0; i <= haystack.Length - needle.Length; i++){
            if(haystack[i] == needle[0]){
                var j = 1;
                while(j < needle.Length && haystack[i + j] == needle[j]){
                    j++;
                }
                if(j == needle.Length) return i;
            }
        }
        return -1;
    }
}