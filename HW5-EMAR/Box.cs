using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HW5_EMAR
{
    public class Box
    {
        protected char leftTopEdge = '╔',
            RightTopEdge = '╗',

            VerticalEdge = '║',

            HorizontalEdge = '═',

            LeftBottomEdge = '╚',

            RightBottomEdge = '╝';
        public Size size { get; set; }
        public Point location { get; set; }
        protected bool Striped { get; set; }
        
        public bool CanActive { get; protected set; }
        protected bool IsActive { get; set; }

        public virtual void Draw()
        {

            if (Striped)
            {
                Console.SetCursorPosition(location.X, location.Y);
                Console.Write(leftTopEdge);
                Console.Write(new string(HorizontalEdge, size.Width - 2));
                Console.Write(RightTopEdge);
                Console.SetCursorPosition(location.X, location.Y + 1);


                for (int i = 0; i < size.Height - 2; i++)
                {
                    Console.SetCursorPosition(location.X, location.Y + i + 1);
                    Console.Write(VerticalEdge);
                    Console.Write(new string(' ', size.Width - 2));
                    Console.WriteLine(VerticalEdge);
                }

                Console.SetCursorPosition(location.X, location.Y + size.Height - 1);
                Console.Write(LeftBottomEdge);
                Console.Write(new string(HorizontalEdge, size.Width - 2));
                Console.Write(RightBottomEdge);
                Console.SetCursorPosition(location.X + 1, location.Y + 1);

            }
        }

        public virtual void Isle(ConsoleKeyInfo keyInfo)
        {

        }
        public virtual void Activate()
        {
            if (CanActive)
            {
                Console.SetCursorPosition(location.X + 1, location.Y + 1);
                IsActive = true;
            }
        }
        public virtual void Deactivate()
        {
            IsActive = false;
             
        }
    }
}
