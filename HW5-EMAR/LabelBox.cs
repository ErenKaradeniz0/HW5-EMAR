using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_EMAR
{
    public class LabelBox: Box
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
                Draw();
            }
        }

        public LabelBox()
        {
            Value = string.Empty;
            CanActive = false;
            Striped = false;
        }

        public override void Draw()
        {
            base.Draw();
            Console.SetCursorPosition(location.X + 1, location.Y + 1);
            Console.Write(Value);
        }
    }
}
