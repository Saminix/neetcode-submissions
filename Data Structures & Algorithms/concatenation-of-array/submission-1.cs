public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] newArray = new int[nums.Length * 2];
        

        for(int i = 0; i < nums.Length; i++)
        {
            newArray[i] = nums[i];
            
        }

        for(int i = 0; i < nums.Length; i++)
        {
            newArray[nums.Length + i] = nums[i];
            
        }

        
    return newArray;

    }
}