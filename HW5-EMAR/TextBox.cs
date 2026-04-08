using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_EMAR
{
    public class TextBox : Box
    {
        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public TextBox()
        {
            Value = string.Empty;
        }

        public override void Draw()
        {
            base.Draw();
            Console.SetCursorPosition(location.X + 1, location.Y + 1);
        }

        public override void Isle(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.Backspace)
            {
                Value = Value.Remove(Value.Length - 1);
            }
            else if (Value.Length < size.Width - 2)
            {
                Value += keyInfo.KeyChar;
            }
            Console.SetCursorPosition(location.X + 1, location.Y + 1);
            Console.Write(Value);
        }
    }
}
