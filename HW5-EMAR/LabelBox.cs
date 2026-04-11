namespace HW5_EMAR
{
    public class LabelBox : Box
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
            var text = Value ?? string.Empty;
            var max = Math.Max(0, size.Width - 2);
            if (text.Length > max) text = text.Substring(0, max);
            Console.Write(text.PadRight(max));
        }
    }
}
