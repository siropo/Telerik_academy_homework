using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_Increasing_Sequance
{
    class MaximalIncreaseSequance
    {
        static void Main(string[] args)
        {
            static int FindMaxNum(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxNum = int.MinValue;
            foreach (int num in list)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            return maxNum;
        }

        static void Main(string[] args)
        {

            List<int> arrayN = new List<int>{2,3,5,5,5,5,5,2,1,7,7,9,9,9,9,9,9};

            int getLengthN = arrayN.Count;

            int start = 1;
            int maxlen = 1;
            List<int> maxArr = new List<int>();

            for (int i = 1; i < getLengthN; i++) {
                if (arrayN[i] - arrayN[i - 1] == 1) {
                    maxlen = 1;
                    maxArr.Add(maxlen);
                } else {
                    start = i - maxlen;
                    maxlen++;
                    maxArr.Add(maxlen);
            
                }
            }
            GetMaxSeq(maxArr, arrayN);
            }

            static void GetMaxSeq(List<int> getArrSeq, List<int> fisrtArr) 
            {   
                int maxLength = getArrSeq.Count;
                int max = FindMaxNum(getArrSeq);

                if (max < 2) {
                    Console.WriteLine("no result");
                } else {
                    Console.Write(" max length is " + max + " in number ");
                    for (int j = 0; j < maxLength; j++) {
                        if (getArrSeq[j] == max)
                        {
                            Console.Write(fisrtArr[j] + "/ ");
                        }
                    }
                }
            }
        }
    }
}
