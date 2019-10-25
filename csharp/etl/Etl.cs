using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> expected = new Dictionary<string, int> { };


        foreach (KeyValuePair<int, string[]>item in old)
        {
            for(int i = 0; i<item.Value.Length; i++)
            {
                expected.Add(item.Value[i].ToLower(), item.Key); 
            }

        }

        return expected; 
    }
}