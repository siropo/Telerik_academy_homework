using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class misscat
{
    static void Main()
    {
        int juri = int.Parse(Console.ReadLine());
        int[] result = new int[juri];

        
        int count = 1;
        for (int i = 0; i < juri; i++)
        {
            result[i] = int.Parse(Console.ReadLine());
        }
        int[] maxArr = new int[juri];

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] == result[j])
                {
                    count++;
                }
                maxArr[i] = count;
            }
            count = 1;
        }

        int max = maxArr[0];

        for (int i = 0; i < maxArr.Length; i++)
        {
            if(max < maxArr[i]) 
            {
                max = maxArr[i];
            }
        }
        int[] minCat = new int[1000];

        for (int i = 0; i < result.Length; i++)
        {
            if (maxArr[i] == max)
            {
                minCat[i] = result[i];
            }
        }

        int min = minCat[0];

        for (int i = 0; i < minCat.Length; i++)
        {
            if (min > minCat[i] && minCat[i] > 0)
            {
                min = minCat[i];
            }
            else if (minCat[i] > 0)
            {
                min = minCat[i];
            }
        }

        Console.WriteLine(min);

       
    }
}


