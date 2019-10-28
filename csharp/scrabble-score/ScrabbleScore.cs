using System;
using System.Collections.Generic;
using System.Linq; 


public static class ScrabbleScore
{
    enum Alphabets
    {
        AEIOULNRST = 1,
        DG = 2,
        BCMP = 3,
        FHVWY =4, 
        K =5,  
        JX =8,            
        QZ=10
    }
    public static int Score(string input)
    {
        string inputUpper = input.ToUpper();
        int sum = 0; 
        foreach(char c in inputUpper)
        {
            foreach (string item in Enum.GetNames(typeof(Alphabets)))
            {
                if (item.Contains(c))
                {
                    Enum.TryParse(item, out Alphabets myValue);
                    sum += (int)myValue; 

                }
            }
        }
        return sum;



        //List<int> sumIndex = new List<int>();
        //string[] alphabets = new string[]
        //{
        //    "0",
        //    "AEIOULNRST",
        //    "DG",
        //    "BCMP",
        //    "FHVWY",
        //    "K",
        //    "0",
        //    "0",
        //    "JX",
        //    "0",
        //    "QZ"
        //};

        //string inputUpper = input.ToUpper();

        //foreach(char c in inputUpper )
        //{
        //    for (int i = 0; i < alphabets.Length; i++)
        //    {
        //        if(alphabets[i].Contains(c))
        //        {
        //            sumIndex.Add(i); 
        //        }
        //    }
        //}

        //return sumIndex.Sum(); 

    }
}