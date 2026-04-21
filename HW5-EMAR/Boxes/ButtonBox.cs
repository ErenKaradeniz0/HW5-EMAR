namespace HW5_EMAR.Boxes
{
    public class ButtonBox : Box
    {
        public delegate void ActionDelegate();
        public event ActionDelegate Action;
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

        public ButtonBox()
        {
            Value = string.Empty;
            CanActive = true;
            Striped = true;
        }
        public override void Draw()
        {

            leftTopEdge = IsActive ? '╔' : '┌';
            RightTopEdge = IsActive ? '╗' : '┐';
            LeftBottomEdge = IsActive ? '╚' : '└';
            RightBottomEdge = IsActive ? '╝' : '┘';
            HorizontalEdge = IsActive ? '═' : '─';
            VerticalEdge = IsActive ? '║' : '│';
            base.Draw();
            Console.SetCursorPosition(location.X + size.Width / 2 - Value.Length / 2, location.Y + 1);
            Console.Write(Value);
        }
        public override void Activate()
        {
            base.Activate();
            Draw();
            Console.CursorVisible = false;
        }
        public override void Deactivate()
        {
            base.Deactivate();
            Draw();
        }
        public override void Process(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                Action?.Invoke();
            }
        }
    }
}
