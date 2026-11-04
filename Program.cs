using System.Numerics;

namespace dragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int dragon_HP = 100;
            Console.WriteLine("Dragon has: " + dragon_HP + " HP");
            Vector2 selected = new Vector2(1, 1);

            Dictionary<string, int> onboard = new Dictionary<string, int>();



            char[,] borders = { 
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
            };

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.SetCursorPosition(i + 5, j + 3);
                    Console.Write(borders[j, i]);
                }
            }



            void X(int x, int y, int length, char font, ConsoleColor color)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(x + i, y + i);
                    Console.Write(font);
                    Console.SetCursorPosition(x - i + length - 1, y + i);
                    Console.Write(font);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar) X((int)selected.X * 8, (int)selected.Y * 4, 3, 'w', ConsoleColor.Red);

                    if (key.Key == ConsoleKey.W) selected.Y--;
                    if (key.Key == ConsoleKey.A) selected.X--;
                    if (key.Key == ConsoleKey.S) selected.Y++;
                    if (key.Key == ConsoleKey.D) selected.X++;
                }

                Console.SetCursorPosition((int)selected.X * 8, (int)selected.Y * 4);

                Console.Write("s");

                if (key.Key == ConsoleKey.D1)
                {

                }

            }

        }
    }
}
