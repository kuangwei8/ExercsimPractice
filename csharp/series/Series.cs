using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> slice = new List<string>();
        if (sliceLength <= 0 || sliceLength > numbers.Length)
        {
            throw new ArgumentException();
        }
        else
        {
            for (int i = 0; i < numbers.Length-sliceLength +1; i++)
            {
                
                slice.Add(numbers.Substring(i,  sliceLength));
            }

        }
            string[] result = slice.ToArray();
            return result;

    }
}