public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int sumNonDivisible = 0;
        int sumDivisible = 0;
        for(int i=1;i<=n;i++){
            if (i % m == 0)
                sumDivisible += i;
            else
                sumNonDivisible += i;
        }
        return sumNonDivisible-sumDivisible;
    }
}