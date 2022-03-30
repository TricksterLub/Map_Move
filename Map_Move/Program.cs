using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-         -");
            Console.WriteLine("-----------");
            Console.SetCursorPosition(5, 5);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    {
                        Console.SetCursorPosition(5, 4);
                        break;
                    }
                case ConsoleKey.A:
                    {
                        Console.SetCursorPosition(4, 5);
                        break;
                    }
                case ConsoleKey.S:
                    {
                        Console.SetCursorPosition(5, 6);
                        break;
                    }
                case ConsoleKey.D:
                    {
                        Console.SetCursorPosition(6, 5);
                        break;
                    }
            }
            
            Console.ReadLine();
        }
    }
}