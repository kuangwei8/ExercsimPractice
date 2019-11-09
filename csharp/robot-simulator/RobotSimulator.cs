using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    //constructor 
    public RobotSimulator(Direction direction, int x, int y)
    {
        Direction = direction;
        X = x;
        Y = y; 
    }
    //properties 
    public Direction Direction{ get;set; }
    public int X { get; set; }
    public int Y { get; set; }
   
    // method 
    public void Move(string instructions)
    {
        int tempDirection = (int)Direction;
        foreach (char c in instructions)
        {
            if(c == 'R')
            {
                tempDirection += 1; 
            }
            if (c == 'L')
            {
                tempDirection -= 1; 
            }
        }


        //if (tempDirection == 4)
        //{
        //    // north, x, y+1
        //    tempDirection = 0;
        //}

        //if (tempDirection == -1)
        //{
        //    //east, x+1, y
        //    tempDirection = 3;
        //}
    }
}