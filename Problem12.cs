using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem12
    {
        public static void HighlyDivisibleTriangularNumber()
        {
            List<int> primeFactors = new List<int>() { 2, 3 };
            int divCount = 1;
            int[] triangular = new int[2] { 0, 0 };
            int triangularStep = 1;
            int result;
            int divCountTrig1, divCountTrig2;


            while (divCount < 500)
            {
                triangularStep++;
                triangular = MakeNombre(triangularStep);

                divCountTrig1 = CountDivisors(primeFactors, triangular[0], 0, 1);
                divCountTrig2 = CountDivisors(primeFactors, triangular[1], 0, 1);
                divCount = (divCountTrig1) * (divCountTrig2);
            }

            result = triangular[0] * triangular[1];

            Console.WriteLine($"On a fini pour {result} composé par {triangular[0]} x {triangular[1]} qui est le {triangularStep} ieme triangular et qui a {divCount} diviseurs");
        }

        private static int[] MakeNombre(int n)
        {
            if (n % 2 == 0) { return new int[] { n / 2, n + 1 }; }
            else { return new int[] { n, (n + 1) / 2 }; }
        }

        private static int CountDivisors(List<int> primeFactors, int n, int listPosition, int countFactors)
        {
            int currentCount = 0;
            while (n > 1 && listPosition < primeFactors.Count)
            {
                if (n % primeFactors[listPosition] == 0)
                {
                    currentCount++;
                    n /= primeFactors[listPosition];
                }
                else
                {
                    listPosition++;
                    countFactors *= currentCount + 1;
                    currentCount = 0;
                }
            }

            if (n > 1)
            {
                primeFactors.Add(n);
            }

            return countFactors *= 2;
        }
    }
}
