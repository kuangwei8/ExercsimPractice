using System;
using System.Text;

public class Robot
{
    public string robotID; 
    public string Name
    {
        get
        {
            return robotID; 
        }
    }

    public void Reset()
    {
        string Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder robotID = new StringBuilder();
        Random random = new Random();
        robotID.Append(random.Next(Alphabets.Length));
        robotID.Append(random.Next(Alphabets.Length));
        robotID.Append(random.Next(0, 9));
        robotID.Append(random.Next(0, 9));
        robotID.Append(random.Next(0, 9));

        Console.WriteLine(robotID);
    }

}