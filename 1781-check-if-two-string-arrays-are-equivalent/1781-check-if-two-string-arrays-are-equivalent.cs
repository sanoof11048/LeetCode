public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word11 = string.Join("",word1);
        string word22 = string.Join("",word2);
        if(word11 == word22){
            return true;
        }
        return false;
    }
}