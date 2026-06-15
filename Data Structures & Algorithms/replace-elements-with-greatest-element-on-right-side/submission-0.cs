public class Solution {
    public int[] ReplaceElements(int[] arr) {
       
        int[] newA = new int[arr.Length];
        List<int> newArray = new List<int> { };

        int n = arr.Length; 
        int rightest = -1;
        int maxValue = arr[n-1]; 
        newArray.Add(-1);
 
        for(int i = (arr.Length - 1) - 1; i >= 0; i--){
            newArray.Add(maxValue);
            if (arr[i] > maxValue){
                maxValue = arr[i];
            } 
        }

        newArray.Reverse();

        for(int i = 0; i < newArray.Count; i++){
            newA[i] = newArray[i];
        }

        return newA;
     
    }
}