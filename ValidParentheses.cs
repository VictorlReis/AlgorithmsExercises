namespace AlgorithmsExercises;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var b1 = "{}";
        var b2 = "[]";
        var b3 = "()";

        int v1 = 0, v2 = 0, v3 = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == b1[0])
            {
                v1 = 1;
                continue;
            }
            if (s[i] == b1[1] && v1 == 0) return false;
            
            if (s[i] == b2[0])
            {
                v2 = 1;
                continue;
            }
            if (s[i] == b2[1] && v2 == 0) return false;
            
            if (s[i] == b3[0])
            {
                v3 = 1;
                continue;
            }
            if (s[i] == b3[1] && v3 == 0) return false;
        }

        return true;
    }
}
