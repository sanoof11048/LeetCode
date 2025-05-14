public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder newWord= new StringBuilder();
        
        foreach(char i in s){
            if(char.IsLetterOrDigit(i)){
                newWord.Append(char.ToLower(i));
            }
        }
        char[] CharArr = newWord.ToString().ToCharArray();
        Array.Reverse(CharArr);
        string result = string.Join("", CharArr);
        bool isTrue =  newWord.ToString() == result? true : false;
        return isTrue;

    }
}