public class Solution {
    public int NumberOfPairs(int[][] points) {
        int n = points.Length;
        int count = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == j) continue;

                int x1 = points[i][0], y1 = points[i][1];
                int x2 = points[j][0], y2 = points[j][1];

                // A must be on the upper-left side of B:
                // x1 <= x2 and y1 >= y2 (points on same row or same column allowed)
                if (x1 <= x2 && y1 >= y2) {
                    bool valid = true;

                    // rectangle x range: [x1, x2], y range: [y2, y1]
                    for (int k = 0; k < n; k++) {
                        if (k == i || k == j) continue;

                        int xk = points[k][0], yk = points[k][1];

                        // If any other point lies inside or on the border -> invalid
                        if (x1 <= xk && xk <= x2 && y2 <= yk && yk <= y1) {
                            valid = false;
                            break;
                        }
                    }

                    if (valid) count++;
                }
            }
        }

        return count;
    }
}
