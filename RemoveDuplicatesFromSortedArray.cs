public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        //give an integer array that names "sorted" in non-decreasing order
        //remove duplicates in-place such that each element appear only once and return the new length
        //do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory
        
        //if the array is null or empty, return 0
        if(nums == null || nums.Length == 0)
        {
            return 0;
        }
        
        //if the array has only one element, return 1
        if(nums.Length == 1)
        {
            return 1;
        }
        
        //use a pointer to point to the first element
        int pointer = 0;
        
        //use a for loop to traverse the array
        for(int i = 0; i < nums.Length; i++)
        {
            //if the element is not equal to the previous element
            if(nums[i] != nums[pointer])
            {
                //move the pointer to the next position
                pointer++;
                
                //assign the element to the position pointed by the pointer
                nums[pointer] = nums[i];
            }
        }
        
        //return the length of the array
        return pointer + 1;
        
        
    }
}