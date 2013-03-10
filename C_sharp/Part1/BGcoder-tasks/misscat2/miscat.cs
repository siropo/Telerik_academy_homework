using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misscat2
{
    class miscat
    {
        static void Main(string[] args)
        {
            int juri = int.Parse(Console.ReadLine());
            int[] cats = new int[11];
            int vote = 0;
            
            for (int i = 0; i < juri; i++)
            {
                vote = int.Parse(Console.ReadLine());
                cats[vote]++;
            }

            int bestCat = 0;
            int bestVotes = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (cats[i] >= bestVotes) {
                    bestCat = i;
                    bestVotes = cats[i];
                }
            }
            Console.WriteLine(bestCat);
        }

    }
}
