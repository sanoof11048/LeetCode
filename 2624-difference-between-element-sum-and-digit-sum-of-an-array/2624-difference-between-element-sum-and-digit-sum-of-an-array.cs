public class Solution {
    public int DifferenceOfSum(int[] nums) {
         int sum=0;
        int digitsum=0;
        foreach(int i in nums){
            sum+=i;
            string digits = i.ToString();
            for(int j=0;j<digits.Length;j++){
                digitsum += int.Parse(digits[j].ToString());
            }
        }
        return sum<digitsum? digitsum- sum : sum- digitsum;
    }
}