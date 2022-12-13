using System;

namespace ProjectEuler
{
    public class Start
    {

        public static void Main()
        {

            Console.WriteLine("Choisissez le numero du probleme a resoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number" +
                "\n 13: Large sum" +
                "\n 14: Longest");

            string userSelection = Console.ReadLine();

            while (!TestUserSelect(userSelection))
            {
                Console.WriteLine("Choisissez le num�ro du probleme a resoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number" +
                "\n 13: Large sum");

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
                case 13:
                    Problem13.LargeSum();
                    break;
                case 14:
                    Problem14.Longest();
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