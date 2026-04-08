using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace HW5_EMAR
{
    public class CariForm : Form
    {
        public CariForm()
        {
            TextBox box1 = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 0),
            };
            TextBox box2 = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 4),
            };
            TextBox box3 = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 8),
            };
            LabelBox label1 = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 0),
                Value = "Name Surname"
            };
            LabelBox label2 = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 4),
                Value = "Address"
            };
            LabelBox label3 = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 8),
                Value = "Phone"
            };
            Boxes.Add(box1);
            Boxes.Add(box2);
            Boxes.Add(box3);
            Boxes.Add(label1);
            Boxes.Add(label2);
            Boxes.Add(label3);
        }
    }
}
