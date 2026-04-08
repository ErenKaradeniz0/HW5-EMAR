using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_EMAR
{
    public class LabelBox: Box
    {
        public LabelBox()
        {
            Striped = false;
            CanActive = false;
        }
        
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

        public override void Draw()
        {
            base.Draw();
            Console.SetCursorPosition(location.X + 1, location.Y + 1);
            Console.Write(Value);
        }
    }
}
