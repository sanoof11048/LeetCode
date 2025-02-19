public class Solution {
    public int ScoreOfString(string s) {
        int sum=0;
        for(int i=0;i<s.Length-1;i++){
            int sub= s[i]-s[i+1];
            sum+=Math.Abs(sub);
        }
        return sum;
    }
}