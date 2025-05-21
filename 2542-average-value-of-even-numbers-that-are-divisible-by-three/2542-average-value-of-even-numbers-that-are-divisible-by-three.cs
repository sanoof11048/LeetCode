public class Solution {
    public int AverageValue(int[] nums) {
        int result = 0;
        int count = 0;
        foreach(int i in nums){
            if(i%3==0 && i%2==0){
                result+=i;
                count++;
            }
        }
        return count > 0 ? result / count : 0;
    }
}