public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        int[] res = new int[nums.Length];
        for(int i=0; i<nums.Length;i++){
            res[i] = nums[i+1];
            res[i+1] = nums[i];
            i++;
        }
        return res;
    }
}