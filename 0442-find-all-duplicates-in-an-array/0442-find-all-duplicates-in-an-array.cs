public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        HashSet<int> res = new HashSet<int>();
        
        foreach(int i in nums){
            if(Array.IndexOf(nums,i) != Array.LastIndexOf(nums,i)){
                res.Add(i);
            }
        }
        return res.ToList();
    }
}