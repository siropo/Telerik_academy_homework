using System;

class ConvertToUnicode
{
    static void Main()
    {
        string str = "yoyoyoy!";

        foreach (var symbol in str)
        {
            Console.WriteLine("\\u{0:X4}", (int)symbol);
        }
    }
}