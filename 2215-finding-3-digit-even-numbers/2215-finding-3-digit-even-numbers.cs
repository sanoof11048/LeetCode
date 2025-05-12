public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        HashSet<int> result = new HashSet<int>();
        int n = digits.Length;
        for(int i =0;i<n;i++){
            for(int j =0;j<n;j++){
                if(i==j) continue;
                for(int k =0;k<n;k++){
                    if(i==k|| j==k) continue;
                    int d1= digits[i];
                    int d2= digits[j];
                    int d3= digits[k];
                        if(d1==0 || d3%2!=0) continue;
                    
                    int number = d1*100 + d2*10 + d3;
                    result.Add(number);
                }
            }
        }
        return result.OrderBy(x=>x).ToArray();
    }
}