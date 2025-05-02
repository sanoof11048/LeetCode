public class Solution {
    public int SearchInsert(int[] nums, int target) {
         for(int i=0;i<=nums.Length;i++){
            if(nums.Contains(target+i)){
                return Array.IndexOf(nums,target+i);
            }else if(nums.Contains(target-i)){
                return Array.IndexOf(nums,target-i)+1;
            }
            
        }
        return 0;
    }
}