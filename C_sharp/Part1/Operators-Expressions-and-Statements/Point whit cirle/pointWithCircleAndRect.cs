using System;

class pointWithCircleAndRect
{
    static void Main()
    {
        byte pointX = 6;
        byte pointY = 8;

        if ((pointX > -2 && pointX < 4) && ((pointY > 1 && pointY < 4) || (pointY < -1 && pointY > -2)))
        {
            Console.WriteLine("The point is in the circle K");
        }
        else if ((pointX >= 4 || pointX <= -2) || (pointY >= 4 || pointY <= -2))
        {
            Console.WriteLine("The point is out of the circle K");
        }
        else
        {
            Console.WriteLine("Point found in rect R");
        }
    }
}

