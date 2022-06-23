namespace AlgorithmsExercises;

public class IsomorphicStrings
{
    private static IEnumerable<int> GetIsomorphic(string s) {
        var indexMapping = new Dictionary<char, int>();
        var list = new List<int>();
    
        for (var i = 0; i < s.Length; i++)
        {
            if(!indexMapping.ContainsKey(s[i])) indexMapping.Add(s[i], i);
            list.Add(indexMapping.GetValueOrDefault(s[i]));
        }

        return list;
    }

    public bool IsIsomorphic(string s, string t)
    {
        var first = GetIsomorphic(s);
        var second = GetIsomorphic(t);

        return first.SequenceEqual(second);
    }
}