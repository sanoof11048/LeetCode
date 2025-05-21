public class Solution {
    public void SetZeroes(int[][] matrix) {
              
    var zeroIndices = matrix
        .SelectMany((row, i) => row
        .Select((value, j) => new { i, j, value }))
        .Where(cell => cell.value == 0)
        .Select(cell => (cell.i, cell.j))
        .ToArray();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                foreach(var num in zeroIndices){
                    if(i==num.i || j== num.j){
                        matrix[i][j]=0;
                    }
                }
            }
        }
    }
}