namespace AlgorithmsExercises;

public class MiniMaxSum
{
    public static void miniMaxSum(List<int> arr)
    {
        long somaMenor = 0;
        long somaMaior = 0;

        arr.Sort();
        for (int i = 0; i <= arr.Count - 1; i++)
        {
            if(i > 0)
            {
                somaMaior += arr[i];
            }

            if( i < arr.Count -1)
            {
                somaMenor += arr[i];
            }

        }

        Console.WriteLine($"{somaMenor} {somaMaior}");
    }
}