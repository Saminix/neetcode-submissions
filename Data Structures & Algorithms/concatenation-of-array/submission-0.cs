public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] newArray = new int[nums.Length * 2];
        List<int> list = new List<int>{};

        for(int i = 0; i < nums.Length; i++){
            list.Add(nums[i]);
        }
        foreach (int number in nums) {
            list.Add(number);
        }
        int j = 0;
        foreach (int numb in list){
            newArray[j] = numb;
            j++;

        }
    return newArray;

    }
}