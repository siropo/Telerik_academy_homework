using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_expression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            decimal N = decimal.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal nom = (N * N) + (1 / (M * P)) + 1337;
            decimal den = N - (128.523123123m * P);

            int modVal = ((int)M) % 180;
            decimal sinVal = (decimal)Math.Sin(modVal);

            decimal result = nom/ den + sinVal;

            Console.WriteLine("{0:0.000000}", result);
        }
    }
}
