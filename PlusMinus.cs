namespace AlgorithmsExercises;

public class PlusMinus
{
    public static void plusMinus(List<int> arr)
    {
        float positive = 0;
        float negative = 0;
        float zero = 0;

        arr.ForEach(i =>
        {
            switch (i)
            {
                case > 0:
                    positive++;
                    break;
                case < 0:
                    negative++;
                    break;
                case 0:
                    zero++;
                    break;
            }
        });

        var positiveRatio = positive / arr.Count;
        var negativeRatio = negative / arr.Count;
        var zeroRatio = zero / arr.Count;

        Console.WriteLine(positiveRatio);
        Console.WriteLine(negativeRatio);
        Console.WriteLine(zeroRatio);

    }
}