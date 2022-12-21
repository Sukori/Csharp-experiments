using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problem14
    {
        public static void LongestCollatz()
        {
            Dictionary<int, int> chains = new();

            int countSteps;
            long result; //result may go far above 1 000 000 :) #neverforget

           for(int i = 1; i < 1000000; i++)
           {
                result = i;
                countSteps = 0;

                while (result > 1)
                {
                    //ne pas calculer jusqu'au bout si on tombe sur une key déjà vue. ça fait gagner beaucoup de temps.
                    if (chains.ContainsKey((int)result))
                    {
                        countSteps += chains[(int)result];
                        break;
                    }

                    if (result % 2 == 0)
                    {
                        result /= 2;
                    }
                    else
                    {
                        result = (3 * result + 1);
                    }
                    countSteps++;
                }
                chains.Add(i, countSteps);
            }

            int maxNumber = 0;
            int maxValue = 0;

            foreach (var kvp in chains)
            {
                if (kvp.Value > maxValue)
                {
                    maxNumber = kvp.Key;
                    maxValue = kvp.Value;
                }
            }
            Console.WriteLine("Le nombre qui a la plus grande chaine est " + maxNumber + " avec " + maxValue + " pas.");
        }
    }
}
