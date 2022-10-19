using System;

namespace ProjectEuler
{
    public class Start
    {

        public static void Main()
        {

            Problem11 problem11 = new();
            Problem12 problem12 = new();
            Problem13 problem13 = new();

            Console.WriteLine("Choisissez le numéro du problème à résoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number");

            string userSelection = Console.ReadLine();

            while (!TestUserSelect(userSelection))
            {
                Console.WriteLine("Choisissez le numéro du problème à résoudre:" +
                "\n 11: Largest product in a grid" +
                "\n 12: Highly divisible triangular number");

                userSelection = Console.ReadLine();
            }

            Console.WriteLine("selected " + userSelection);

            switch (int.Parse(userSelection))
            {
                case 11:
                    problem11.LargestProductInAGrid();
                    break;
                
                case 12:
                    problem12.HighlyDivisibleTriangularNumber();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir un nombre de la liste.");
                    //Application.Restart();
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