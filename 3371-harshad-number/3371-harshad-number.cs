public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int sum = 0, n=x ;
        while(n>0){
            sum+=n%10;
            n/=10;
        }
        if(x%sum==0){
            return sum;
        }
        return -1;
    }
}