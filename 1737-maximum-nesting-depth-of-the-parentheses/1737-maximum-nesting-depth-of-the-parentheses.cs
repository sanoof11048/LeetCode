public class Solution {
    public int MaxDepth(string s) {
        int count = 0;
        int result=0;
        foreach(char i in s){
            if(i=='(') 
            {
                count++;
                Console.Write(count);
                if(count>result){
                    result=count;
                }
            }
            if(i==')') count--;
            
        }
        return result;
    }
}