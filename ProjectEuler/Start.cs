using System;

namespace ProjectEuler
{
    class Start
    {
        static void Main(string[] args)
        {
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