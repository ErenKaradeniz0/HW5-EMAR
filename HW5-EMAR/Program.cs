using System;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var box1 = new TextBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(5, 0),
                Striped = true
            };
            DrawBox(box1);
            while (true)
            {
                box1.Isle(Console.ReadKey(true));
            }
            Console.ReadLine();

        }

        static void DrawBox(Box box)
        {
            box.Draw();
        }

    }
}
