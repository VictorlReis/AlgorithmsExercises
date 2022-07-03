namespace AlgorithmsExercises;

public class DiagonalDifference
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        var somaDiagional01 = 0;
        var somaDiagional02 = 0;


        for (var i = 0; i < arr.Count(); i++)
        {
            for (var j = 0; j < arr.ElementAt(i).Count; j++)
            {
                if (i == j)
                {
                    somaDiagional01 += arr.ElementAt(i).ElementAt(j);
                }

                if (i + j == arr.Count - 1)
                {
                    somaDiagional02 += arr.ElementAt(i).ElementAt(j);
                }
            }
        }

        return Math.Abs(somaDiagional01 - somaDiagional02);

    }
}