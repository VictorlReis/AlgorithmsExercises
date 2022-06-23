namespace AlgorithmsExercises;

public class FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0, leftsum = 0;
        foreach (var x in nums)
        {
            sum += x;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftsum == sum - leftsum - nums[i]) return i;
            leftsum += nums[i];
        }

        return -1;
    }
}