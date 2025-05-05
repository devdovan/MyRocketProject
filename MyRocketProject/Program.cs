namespace MyRocketProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocket Project";

            string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

            for (int i = 10; i >= 0; i--)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n" + new string('*', 30) + "My Rocket Project" + new string('*', 30) + "\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It is " + i);
                rocket = "\r\n" + rocket;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(rocket);
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.Beep();
                Thread.Sleep(1000);
            }

            Console.WriteLine("The Rocket has Landed!");
            Console.ReadKey();
        }
    }
}
