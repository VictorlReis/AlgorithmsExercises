namespace AlgorithmsExercises;

public class RunningSum1dArray
{
    public int[] RunningSum(int[] nums) {
        
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        
        return nums;        
    }
}