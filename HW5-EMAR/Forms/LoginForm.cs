using HW5_EMAR.Boxes;
using System.Drawing;

namespace HW5_EMAR.Forms
{
    public class LoginForm : Form
    {
        public LoginForm()
        {
            Boxes = new List<Box>()
            {
                new TextBox
                {
                    size = new Size (20 ,3),
                    location = new Point(40, 10),
                },
                new LabelBox
                {
                    size = new Size(20, 3),
                    location = new Point(20, 10),
                    Value = "Username"
                },

                new TextBox
                {
                    size = new Size (20, 3),
                    location = new Point(40, 14),
                },

                new LabelBox
                {
                    size = new Size (20, 3),
                    location = new Point(20, 14),
                    Value = "Password"
                },
            };
        }
    }
}