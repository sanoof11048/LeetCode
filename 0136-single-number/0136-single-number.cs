public class Solution {
    public int SingleNumber(int[] nums) {
           for(int i=0;i<nums.Length;i++){
        int count = 0;
        foreach(int j in nums){
            if(j==nums[i]){
                count++;
            }
        }
        if(count==1){
            return nums[i];
        }
    }
    return 0;
    }
}