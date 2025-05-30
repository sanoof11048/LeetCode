public class Solution {
    public bool JudgeCircle(string moves) {
        int[] axis = {0,0};
        foreach(char i in moves){
            if(i=='U'){
                axis[1]++;
            }else if(i=='D'){
                axis[1]--;
            }else if(i=='L'){
                axis[0]--;
            }else if(i=='R'){
                axis[0]++;
            }
        }
        if(axis[0] == 0 && axis[1] == 0){
            return true;
        }
        return false;
    }
}