using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "dr":
                    OptionsManager.DevideRemainder(a, b);
                    break;
                case "ex":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    Console.ReadKey(intercept: true);
                    return;
            }

            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);

            bool isAuthorized = CheckCredentials();

            if (!isAuthorized)
            {
                Console.WriteLine("Access denied.");
                Console.ReadKey(intercept: true);
                return;
            }

            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string(c: '-', count: 15));

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "d":
                    OptionsManager.Divide(a, b);
                    break;
                case "sabs":
                    OptionsManager.SubtractAbs(a, b);
                    break;
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string(c: '-', count: 15));

                Console.Write("a =");

            }
        }
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();

            return password == Password;
        }

        private const string Password = "abcd1234";

    }
}
