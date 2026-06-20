public class Solution {
    public int MaxProfit(int[] prices) {
        int[] final = new int[prices.Length];

        for (int i = 0; i< prices.Length; i++){
            int profit = -1 * prices[i];
            int maxProfitForThisDay = 0;
            for (int j = i + 1; j < prices.Length; j ++){
                int currentProfit = profit + prices[j]; 
                if (currentProfit > maxProfitForThisDay){
                    maxProfitForThisDay = currentProfit;
                }
            }
            final[i] = maxProfitForThisDay;
        }

        int highest = 0;
        foreach(int number in final){
            if (number > highest){
                highest = number;
            }
        }

        return highest;
        
    }
}
