using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sheets
{

    static void Main()
    {
        int cut = int.Parse(Console.ReadLine());
        int[] sum = new int[11];

        int[] paperPartsNum = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2047};
        string[] paperPartsString = {"A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0"};

        for (int i = 0; i < paperPartsNum.Length; i++)
        {
            if (cut == paperPartsNum[i] || (cut > paperPartsNum[i] && cut < paperPartsNum[i + 1]))
            {
                cut -= paperPartsNum[i];

                paperPartsNum = paperPartsNum.Where(num => num != paperPartsNum[i]).ToArray();
                paperPartsString = paperPartsString.Where(val => val != paperPartsString[i]).ToArray();

                if (cut != 0)
                {
                    i = -1;
                }
            }
        }

        for (int i = 0; i < paperPartsString.Length; i++)
        {
            Console.WriteLine(paperPartsString[i]);
            
        }
        
    }
}

