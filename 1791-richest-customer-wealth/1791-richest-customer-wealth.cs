public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int Max = 0;
        foreach (int[] row in accounts)
        {
            int sum = 0;
            foreach (int num in row)
            {
                sum += num;
            }
             if (sum > Max) {
                Max = sum;
            }

        }
        return Max;
    }
}