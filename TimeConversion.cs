namespace AlgorithmsExercises;

public class TimeConversion
{
    static string timeConversion(string s)
    {        
        var p = 12;

        var t = s.Split(":");

        var hour = t[0];
        
        if(hour == "12" && s.Contains('A')) {
            s = s.Remove(0, 2);
            s = $"00{s}";        
        }
        
        if(hour != "12" && s.Contains('P'))
        {
            int.TryParse(hour, out var ht);
            var f = p + ht;
            var fs = f.ToString();

            s = s.Remove(0, 2);
            s = $"{fs}{s}";
        }
        
        s = s.Remove(s.Count() -2);

        return s;
    }
}