namespace AlgorithmsExercises;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var ret = 0;
        var i = 0;

        for (var j = 1; j < prices.Length; j++)
        {
            if (prices[i] >= prices[j]) i = j;
            if (prices[j] - prices[i] > ret) ret = prices[j] - prices[i];
        }

        return ret;
    }
}