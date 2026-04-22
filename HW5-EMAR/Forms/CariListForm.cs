using HW5_EMAR.Boxes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;

namespace HW5_EMAR.Forms
{
    public class CariListForm : Form
    {

        public Action OnBack { get; set; }

        public CariListForm()
        {
            int xCenter = Console.WindowWidth / 2 - 10;
            LabelBox infoLabel = new LabelBox { size = new Size(60, 3), location = new Point(xCenter - 10, 2), Value = "Cari Listesi" };
            Boxes.Add(infoLabel);

            ButtonBox backButton = new ButtonBox { size = new Size(20, 3), location = new Point(xCenter + 10, 2), Value = "Geri don" };
            backButton.Action += BackButtonClicked;
            Boxes.Add(backButton);
            int rowY = 6;
            if (File.Exists("records.txt"))
            {
                var lines = File.ReadAllLines("records.txt");
                if (lines.Length == 0)
                {
                    Boxes.Add(new LabelBox { size = new Size(80, 3), location = new Point(5, rowY), Value = "Kayit bulunamadi" });
                    rowY += 1;
                }
                else
                {
                    foreach (var line in lines)
                    {

                        Boxes.Add(new LabelBox { size = new Size(80, 3), location = new Point(5, rowY), Value = line });
                        rowY += 1;
                    }
                }
            }
            else
            {
                Boxes.Add(new LabelBox { size = new Size(80, 3), location = new Point(5, rowY), Value = "records.txt bulunamadi" });
                rowY += 3;
            }


        }

        public void BackButtonClicked()
        {
            OnBack?.Invoke();
        }
    }
}
