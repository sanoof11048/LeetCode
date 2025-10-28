public class Solution
{
    public int CountValidSelections(int[] nums)
    {
        int n = nums.Length;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0)
            {
                if (CanMakeAllZero(nums, i, -1)) count++;
                if (CanMakeAllZero(nums, i, 1)) count++;
            }
        }

        return count;
    }

    private bool CanMakeAllZero(int[] nums, int start, int dir)
    {
        int[] arr = (int[])nums.Clone();
        int curr = start;
        int n = arr.Length;

        while (curr >= 0 && curr < n)
        {
            if (arr[curr] == 0)
            {
                curr += dir;
            }
            else
            {
                arr[curr]--;
                dir = -dir; 
                curr += dir;
            }
        }

        foreach (int x in arr)
            if (x != 0) return false;

        return true;
    }
}
