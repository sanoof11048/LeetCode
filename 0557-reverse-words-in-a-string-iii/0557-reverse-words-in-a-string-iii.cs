public class Solution {
    public string ReverseWords(string s) {
       StringBuilder result = new StringBuilder();
        foreach(string i in s.Split(" ")){
            string reversed = new string(i.Reverse().ToArray());
            result.Append(reversed + " ");
        }
        return result.ToString().TrimEnd(); 
        
    }
}