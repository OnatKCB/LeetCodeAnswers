/*
Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.
You should pack your words in a greedy approach; that is, pack as many words as you can in each line. 
Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.
Extra spaces between words should be distributed as evenly as possible. 
If the number of spaces on a line does not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.
For the last line of text, it should be left-justified, and no extra space is inserted between words.
Note:
A word is defined as a character sequence consisting of non-space characters only.
Each word's length is guaranteed to be greater than 0 and not exceed maxWidth.
The input array words contains at least one word.
*/
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) 
    {
        IList<string> result = new List<string>();
        int n = words.Length;
        int index = 0;
        while(index < n)
        {
            int count = words[index].Length;
            int last = index + 1;
            while(last < n)
            {
                if(words[last].Length + count + 1 > maxWidth)
                {
                    break;
                }
                count += words[last].Length + 1;
                last++;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(words[index]);
            int diff = last - index - 1;
            // if last line or number of words in the line is 1, left-justified
            if(last == n || diff == 0)
            {
                for(int i = index + 1; i < last; i++)
                {
                    sb.Append(" ");
                    sb.Append(words[i]);
                }
                for(int i = sb.Length; i < maxWidth; i++)
                {
                    sb.Append(" ");
                }
            }
            else
            {
                // middle justified
                int spaces = (maxWidth - count) / diff;
                int r = (maxWidth - count) % diff;
                for(int i = index + 1; i < last; i++)
                {
                    for(int j = spaces; j > 0; j--)
                    {
                        sb.Append(" ");
                    }
                    if(r > 0)
                    {
                        sb.Append(" ");
                        r--;
                    }
                    sb.Append(" ");
                    sb.Append(words[i]);
                }
            }
            result.Add(sb.ToString());
            index = last;
        }
        return result;
    }
}