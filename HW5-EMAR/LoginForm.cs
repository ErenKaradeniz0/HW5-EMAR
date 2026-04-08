using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HW5_EMAR
{
    public class LoginForm : Form
    {
        public LoginForm()
        {
            TextBox box1 = new TextBox
            {
                size = new Size (20 ,3),
                location = new Point(40, 10),
            };
            LabelBox label1 = new LabelBox
            {
                size = new Size(20, 3),
                location = new Point(20, 10),
                Value = "Username"
            };

            TextBox box2 = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(40, 14),
            };

            LabelBox label2 = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(20, 14),
                Value = "Password"
            };

            Boxes.Add(box1);
            Boxes.Add(box2);
            Boxes.Add(label1);
            Boxes.Add(label2);
        }
    }
}
