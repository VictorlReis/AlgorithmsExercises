namespace AlgorithmsExercises;

public class VeryBigSum
{
    public static long aVeryBigSum(List<long> ar)
    {
        return ar.Aggregate((result, item) => result + item);
    }
}