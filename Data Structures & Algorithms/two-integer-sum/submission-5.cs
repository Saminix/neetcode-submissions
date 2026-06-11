public class Solution {
     public int[] TwoSum(int[] nums, int target) {
  
        Dictionary<int,int> hashmap = new Dictionary<int,int>();
      
        for (int i = 0; i < nums.Length; i++){
            hashmap[nums[i]] = i;
            //assigns key to the value
        }

        for (int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if (hashmap.ContainsKey(diff) && hashmap[diff] != i){
                return [i, hashmap[diff]];
            }
        }
        return[];
    
     }

     
    public int[] TwoSum1(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++){
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] + nums[j] == target && i != j){
                    if (i < j){
                        return [i,j];
                    }
                    return [j,i];
                }
            }
        }
        return [];
    }
}
