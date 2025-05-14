public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder newWord= new StringBuilder();
        
        foreach(char i in s){
            if(char.IsLetterOrDigit(i)){
                newWord.Append(char.ToLower(i));
            }
        }
        string filtered = newWord.ToString();
        int left = 0;
        int right = filtered.Length - 1;
        while (left < right) {
            if (filtered[left] != filtered[right])
                return false;
            left++;
            right--;
        }

        return true;

    }
}