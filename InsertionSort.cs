namespace AlgorithmsExercises;

public class InsertionSort
{
    static List<int> insertionSort(List<int> arr)
    {
        for (var i = 0; i < arr.Count - 1; i++)
        {
            for (var j = i + 1; j > 0; j--)
            {
                if (arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;     
    }

}