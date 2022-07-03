namespace AlgorithmsExercises;

public class CompareTriplets
{
    public static List<int> Compare_Triplets(List<int> a, List<int> b)
    {
        var alice = 0;
        var bob = 0;

        for (var i = 0; i < a.Count; i++)
        {
            if(a[i] > b[i])
            {
                alice++;
            } else if(a[i] < b[i])
            {
                bob++;
            }
        }

        return new List<int> { alice, bob };
    }
}