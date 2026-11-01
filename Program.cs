using System.Numerics;

namespace dragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 selected = new Vector2(1, 1);

            int dragon_HP = 100;
            Console.WriteLine("Dragon has: " + dragon_HP + " HP");

            void X(int x, int y, int length, char font)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(x + i, y + i);
                    Console.Write(font);
                    Console.SetCursorPosition(x - i + length - 1, y + i);
                    Console.Write(font);
                }
            }sss


            while (true)
            {




                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar) X((int)selected.X * 3, (int)selected.Y * 3, 3, 'w');

                    if (key.Key == ConsoleKey.W) selected.Y--;
                    if (key.Key == ConsoleKey.A) selected.X--;
                    if (key.Key == ConsoleKey.S) selected.Y++;
                    if (key.Key == ConsoleKey.D) selected.X++;
                }

                Console.SetCursorPosition((int)selected.X * 3, (int)selected.Y * 3);
                Console.Write("s");
            }
        }
    }
}
