using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var expected = new Dictionary<char, int>();
        expected.Add('A', 0);
        expected.Add('C', 0);
        expected.Add('G', 0);
        expected.Add('T', 0);

        for( int i = 0; i < sequence.Length; i++)
        {
            if (expected.ContainsKey(sequence[i]))
            {
                expected[sequence[i]] += 1;
            }
            if(!expected.ContainsKey(sequence[i]))
            {
                throw new ArgumentException("Invalid input!");
            }
        }
            return expected;  
        
    }
}