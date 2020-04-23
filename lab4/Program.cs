using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            bool run = true;
            while (run == true)
            {
                int n = Verify("Enter an integer: ");

                string s = String.Format("{0, -10} {1, -10} {2, -10} \n\n\n", "Number", "Square", "Cubed");

                for (int i = 1; i <= n; i++)
                    s += String.Format("{0,-10} {1,-10:N0} {2,-10:N0}\n", (i), (i * i), (i * i * i));
                {
                    Console.WriteLine($"\n{s}");
                }
                run = Ask();
            }
        }

        public static bool Ask()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I did not understand that. Please try again.");
                return Ask();
            }
        }


        public static int Verify(string message)
        {
            Console.WriteLine(message);
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x) && x > 0)
            {
                x = int.Parse(input);                
                return x;
            }
            else
            {
                Console.WriteLine("That is not a valid integer.");
                return x;
            }
        }
    }
}
