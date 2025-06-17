public class Solution {
    public bool DetectCapitalUse(string word) {
int fullUpper = 0;
        for(int i=0;i<word.Length;i++)
        {
            if(char.IsUpper(word[i]))
            {
                fullUpper++;
            }
        }
        if (fullUpper == word.Length)
        return true;
        
        if (fullUpper == 0)
        return true;
        
        if (fullUpper == 1 && char.IsUpper(word[0]))
        return true;
        
        return false;
    }
}