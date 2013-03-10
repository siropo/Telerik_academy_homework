using System;

class increaseNum
{
    static void Main()
    {
        Console.Write("num = ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine(num * 10);
                break;
            case 4:
            case 5:
            case 6: Console.WriteLine(num * 100);
                break;
            case 7:
            case 8:
            case 9: Console.WriteLine(num * 1000);
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}
