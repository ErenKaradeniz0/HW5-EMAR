using HW5_EMAR.Boxes;

namespace HW5_EMAR.Forms
{
    public class Form
    {
        public List<Box> Boxes { get; set; }
        public int activeBoxIndex = 0;
        public Box ActiveBox
        {
            get
            {
                return Boxes[activeBoxIndex];
            }
        }
        public Form()
        {
            Boxes = new List<Box>();
        }

        public void Show()
        {
            foreach (var box in Boxes)
            {
                box.Draw();
            }

            ActiveBox.Activate();
        }

        public virtual void ProcessKey(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.Tab || info.Key == ConsoleKey.Enter)
            {
                var oldActiveBox = ActiveBox;
                while (true)
                {
                    activeBoxIndex = (activeBoxIndex + 1) % Boxes.Count;
                    if (ActiveBox.CanActive)
                    {
                        oldActiveBox.Deactivate();
                        ActiveBox.Activate();
                        break;
                    }
                }

            }
            else
            {
                ActiveBox.Process(info);
            }
        }
    }
}
