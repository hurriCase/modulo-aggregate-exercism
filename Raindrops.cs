using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

public static class Raindrops
{
    private static void Something()
    {
        var stringBuilder = new StringBuilder();
        
    }

    private static readonly IReadOnlyDictionary<int, string> RaindropsSounds = new Dictionary<int, string>()
    {
        {3,"Pling" },
        {5,"Plang" },
        {7,"Plong" }
    };

    public static string Convert(int number) =>
        RaindropsSounds.Aggregate("",
            (result, sound) => 
                number % sound.Key == 0 ?
                    result + sound.Value : result, 
            result => result == string.Empty ? number.ToString() : result);
}