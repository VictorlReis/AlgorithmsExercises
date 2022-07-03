namespace AlgorithmsExercises;

public class BirthdayCakeCandles
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        var higher = 0;
        var cont = 0;

        candles.ForEach(x =>
        {
            if (x < higher) return;
            higher = x;
        });

        candles.ForEach(x =>
        {
            if (x == higher) cont++;
        });
        
        return cont;
    }
}