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
                location = new System.Drawing.Point(25, 0),
            };
            var box2 = new TextBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(25, 4),
            };
            var box3 = new TextBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(25, 8),
            };
            var label1 = new LabelBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(5, 0),
                Value = "Name Surname"
            };
            var label2 = new LabelBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(5, 4),
                Value = "Address"
            };
            var label3 = new LabelBox
            {
                size = new System.Drawing.Size { Width = 20, Height = 3 },
                location = new System.Drawing.Point(5, 8),
                Value = "Phone"
            };

            label1.Draw();
            label2.Draw();
            label3.Draw();
            DrawBox(box1);
            box2.Draw();
            box3.Draw();
            
            TextBox activeBox = box1;
            activeBox.Activate();
            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Tab || keyInfo.Key == ConsoleKey.Enter)
                {
                    if (activeBox == box1)
                        activeBox = box2;
                    else if (activeBox == box2)
                        activeBox = box3;
                    else
                        activeBox = box1;
                    activeBox.Activate();
                }
                else
                {
                    activeBox.Isle(keyInfo);
                }
            }
        }

        static void DrawBox(Box box)
        {
            box.Draw();
        }

    }
}
