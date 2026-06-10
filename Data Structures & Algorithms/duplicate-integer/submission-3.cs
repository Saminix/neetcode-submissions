public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> list = new List<int>{};

        foreach (int number in nums){
            if(list.Contains(number)){
                return true;
            }
            list.Add(number);
        }
        return false;
    }
}