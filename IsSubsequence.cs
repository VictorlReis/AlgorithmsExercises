namespace AlgorithmsExercises;

public class IsSubsequence
{
    public bool Subsequence(string s, string t)
    {
        int i = 0, j = 0;

        while (i < s.Length && j < t.Length)
        {
            if(s[i] == t[j]) i++;
            
            j++;
        }

        return i == s.Length;
    }
}