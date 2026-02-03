using Microsoft.VisualBasic;

namespace Topic_1__Printing_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kenzie
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("My name is Kenzie");
            Console.WriteLine();
            Console.Write("Computers");
            Console.WriteLine(" Rule");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.ResetColor();


        }
    }
}
