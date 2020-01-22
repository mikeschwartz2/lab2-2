using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABLE OF POWERS");
            int num;
            int square;
            int cube;
            bool again = true;
            
            while (again == true)
            {
                int counter = 0;
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                bool worked = int.TryParse(input, out num);

                while (worked == false || num > 1290 || num <= 0)
                {
                    Console.WriteLine("That wasn't a valid number!");
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                    worked = int.TryParse(input, out num);
                }
                
                Console.WriteLine("{0,10}{1,10}{2,10}","Number","Square","Cube");
                for (int x = 0; x < 30; x++)
                {
                    Console.Write($"=");
                }
                Console.WriteLine();

                while (counter <= num)
                {
                    square = counter * counter;
                    cube = counter * counter * counter;

                    Console.Write("{0,10}{1,10}{2,10}", counter, square, cube);
                    Console.WriteLine();
                    counter++;
                }

                Console.WriteLine("Would you like to continue? y/n");
                input = Console.ReadLine();
                if (input == "y" || input == "yes")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            }
        }
    }
}
