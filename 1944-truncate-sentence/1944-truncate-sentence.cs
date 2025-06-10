public class Solution {
    public string TruncateSentence(string s, int k) {
        StringBuilder result = new StringBuilder(); 
        int count = 0;
        foreach(string i in s.Split(" ")){
            if(count<k){
                result.Append(i+ " ");
            }
            count++;
        }
        return result.ToString().TrimEnd();
    }
}