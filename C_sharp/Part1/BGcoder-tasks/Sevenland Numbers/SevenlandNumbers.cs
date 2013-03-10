using System;

class SevenlandNumbers
{
    static void Main()
    {
        string getInput = Console.ReadLine();
        int Num;
        bool result = Int32.TryParse(getInput, out Num);

        if (getInput.Length < 3 && getInput[getInput.Length - 1].ToString() == "6")
            {
                if (getInput != "66")
                {
                    Num += 4;
                }
                else
                {
                    Num += 34;
                }
            }
            else if (getInput.Length == 3 && getInput[getInput.Length - 1].ToString() == "6")
            {
                if (getInput != "666")
                {
                    if (getInput[getInput.Length - 1].ToString() == "6" && getInput[getInput.Length - 2].ToString() != "6")
                    {
                        Num += 4;
                    }
                    else
                    {
                        Num += 34;
                    }
                }
                else
                {
                    Num += 334;
                }
            }
            else
            {
                Num += 1;
            }

        Console.WriteLine(Num);
    }
}

