public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        Span<int> span = nums;
        span.Sort();

        foreach (int num in span) {
            if (num == original) {
                original *= 2;
            } else if (num > original) {
                break;
            }
        }

        return original;
    }
}
