using System;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BOX_COUNT = 3;
            int width = 20;
            int height = 3;

            DrawBox(width, height, BOX_COUNT);
            Console.SetCursorPosition(1, 2);
            int[] cursorPositions = new int[BOX_COUNT];
            for (int i = 0; i < BOX_COUNT; i++) cursorPositions[i] = 1;

            int currentBox = 0;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Tab)
                {
                    cursorPositions[currentBox] = Console.GetCursorPosition().Left;
                    int currentTop = Console.GetCursorPosition().Top;
                    currentBox = (currentBox + 1) % BOX_COUNT;

                    int newTop = (currentBox == 0)
                        ? 2
                        : currentTop + height + 1;

                    Console.SetCursorPosition(cursorPositions[currentBox], newTop);
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if(Console.GetCursorPosition().Left > 1)
                    {
                        Console.SetCursorPosition(Console.GetCursorPosition().Left - 1, Console.GetCursorPosition().Top);
                        Console.Write(' ');
                        Console.SetCursorPosition(Console.GetCursorPosition().Left - 1, Console.GetCursorPosition().Top);
                    }
                }
                else if (Console.GetCursorPosition().Left <= width)
                {
                    Console.Write(key.KeyChar);

                }
            }
        }

        // DRAW METHODS
        static void DrawBox(int width, int height, int BOX_COUNT)
        {
            foreach (var i in Enumerable.Range(0, BOX_COUNT))
            {
                Console.WriteLine();
                DrawTop(width);
                Console.WriteLine();
                DrawMiddle(width, height);
                DrawBottom(width);
                Console.WriteLine();
            }
        }

        static void DrawTop(int width)
        {
            Console.Write('╔');
            Console.Write(new string('═', width));
            Console.Write('╗');
        }

        static void DrawMiddle(int width, int height)
        {
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write('║');
                Console.Write(new string(' ', width));
                Console.WriteLine('║');
            }
        }
        static void DrawBottom(int width)
        {
            Console.Write('╚');
            Console.Write(new string('═', width));
            Console.Write('╝');
        }
    }
}
