public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int> ();

        int count = 0;
     

        foreach (int number in nums){

            if (!dict.ContainsKey(number)){
                dict.Add(number, 1);
            }
            else {
                dict[number]++;
            }
        }

       int[] result = new int[k];

       for (int i = 0; i < k; i++){
        int maxKey = 0;
        int maxValue = 0;

        foreach (var group in dict){
            if(group.Value > maxValue){
                maxValue = group.Value;
                maxKey = group.Key;
            }
        }

        result[i] = maxKey;
        dict.Remove(maxKey);

       }
       return result;
                   
    }
}
