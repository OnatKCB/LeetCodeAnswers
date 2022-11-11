//, return indices of the two numbers such that they add up to target.
public class Solution 
{
    //Write an array of integers nums and an integer target
    public int[] TwoSum(int[] nums, int target) 
    {
        //if the array is null or empty, return null
        if(nums == null || nums.Length == 0)
        {
            return null;
        }
        
        //use a dictionary to store the element and its index
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        //use a for loop to traverse the array
        for(int i = 0; i < nums.Length; i++)
        {
            //if the dictionary contains the key of the target minus the element
            if(dict.ContainsKey(target - nums[i]))
            {
                //return the index of the element and the index of the target minus the element
                return new int[] {dict[target - nums[i]], i};
            }
            
            //if the dictionary does not contain the key of the target minus the element
            else
            {
                //if the dictionary contains the key of the element
                if(dict.ContainsKey(nums[i]))
                {
                    //continue
                    continue;
                }
                
                //if the dictionary does not contain the key of the element
                else
                {
                    //add the element and its index to the dictionary
                    dict.Add(nums[i], i);
                }
            }
        }
        
        //return null
        return null;
    }
}