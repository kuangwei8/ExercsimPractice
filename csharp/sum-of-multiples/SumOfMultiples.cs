using System;
using System.Collections.Generic;
using System.Linq; 

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> nums = new HashSet<int>(); 
        foreach(int num in multiples)
        {
            for(int i = 0; i < max; i++)
            {
                if(multiples == null)
                    return 0; 

                else if(num != 0 && i %num == 0 )
                {
                    nums.Add(i); 
                }
            }
            
        }

        return nums.Sum(); 
        
    }
}