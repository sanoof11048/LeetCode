public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        int min1 = int.MaxValue, min2 = int.MaxValue;

        foreach (int price in prices)
        {
            if (price < min1)
            {
                min2 = min1;
                min1 = price;
            }
            else if (price < min2)
            {
                min2 = price;
            }
        }

        int total = min1 + min2;

        return total <= money ? money - total : money;
    }
}
