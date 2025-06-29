public class Solution
{
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        int maxDiagonal = 0;
        int maxArea = 0;

        foreach (var d in dimensions)
        {
            int length = d[0];
            int width = d[1];
            int diagonal = length * length + width * width;
            int area = length * width;

            if (diagonal > maxDiagonal)
            {
                maxDiagonal = diagonal;
                maxArea = area;
            }
            else if (diagonal == maxDiagonal)
            {
                if (area > maxArea)
                    maxArea = area;
            }
        }

        return maxArea;
    }
}
