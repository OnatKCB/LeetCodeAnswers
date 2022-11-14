/*
The set [1, 2, 3, ..., n] contains a total of n! unique permutations.
By listing and labeling all of the permutations in order, we get the following sequence for n = 3:
"123"
"132"
"213"
"231"
"312"
"321"
Given n and k, return the kth permutation sequence.
*/
public class Solution {
    public string GetPermutation(int n, int k) 
    {
        int[] factorial = new int[n + 1];
        factorial[0] = 1;
        for(int i = 1; i <= n; i++)
        {
            factorial[i] = factorial[i - 1] * i;
        }
        k--;
        IList<int> numbers = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        StringBuilder result = new StringBuilder();
        for(int i = 1; i <= n; i++)
        {
            int index = k / factorial[n - i];
            result.Append(numbers[index]);
            numbers.RemoveAt(index);
            k -= index * factorial[n - i];
        }
        return result.ToString();
    }
}