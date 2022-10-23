using System;

namespace ProjectEuler
{
    public class Start
    {

        public static void Main()
        {
            //Besoin de ça maintenant?
            Problem11 problem11 = new();
            Problem12 problem12 = new();
            Problem13 problem13 = new();

            Console.WriteLine("Choisissez le numero du probleme a resoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number");

            string userSelection = Console.ReadLine();

            while (!TestUserSelect(userSelection))
            {
                Console.WriteLine("Choisissez le num�ro du probleme a resoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number");

                userSelection = Console.ReadLine();
            }

            Console.WriteLine("\nselected " + userSelection + "\n");

            switch (int.Parse(userSelection))
            {
                case 11:
                    Problem11.LargestProductInAGrid();
                    break;
                
                case 12:
                    Problem12.HighlyDivisibleTriangularNumber();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir un nombre de la liste.");
                    break;
            }
        }

        static bool TestUserSelect(string input)
        {
            try
            {
                int.Parse(input);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}