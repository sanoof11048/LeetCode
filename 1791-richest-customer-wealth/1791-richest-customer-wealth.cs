public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int[] newArr = new int[accounts.Length];
        int count=0;
        foreach (int[] row in accounts)
        {
            int sum = 0;
            foreach (int num in row)
            {
                sum += num;
            }
            newArr[count] = sum;
            count++;
        }
        int result = newArr.Max();
        return result;
    }
}