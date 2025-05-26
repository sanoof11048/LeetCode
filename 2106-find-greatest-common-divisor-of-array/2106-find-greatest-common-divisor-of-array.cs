public class Solution
{
    public int FindGCD(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];

        foreach (int num in nums)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return GCD(min, max);
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
