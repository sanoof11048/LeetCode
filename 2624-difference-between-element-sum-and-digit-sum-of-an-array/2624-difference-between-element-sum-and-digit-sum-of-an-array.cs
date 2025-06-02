public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum = 0;
        int digitsum = 0;
        foreach (int i in nums) {
            sum += i;
            int num = i;
            while (num > 0) {
                digitsum += num % 10;
                num /= 10;
            }
        }
        return sum<digitsum? digitsum- sum : sum- digitsum;
    }
}