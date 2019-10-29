using System;
using System.Collections.Generic;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string numbers = "0123456789";
        List<char> cleanPhoneNumber = new List<char>();

        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if(numbers.Contains(phoneNumber[i]))
            {
                cleanPhoneNumber.Add(phoneNumber[i]);
            }
        }
        string result = String.Join("", cleanPhoneNumber);

        if (result.Length == 10 && result[0] > '1' && result[3] > '1')
        {
            return result;
        }
        else if (result.Length == 11 && result[0] == '1' && result[1] > '1' && result[4] >'1')
        {
            cleanPhoneNumber.RemoveAt(0);
            return String.Join("", cleanPhoneNumber);
        }
       else
        {
            throw new ArgumentException();
        }
    }
}