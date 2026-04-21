using HW5_EMAR.Boxes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HW5_EMAR.Forms
{
    public class MainForm : Form
    {

        public MainForm()
        {
            InitializeMainFormBoxes();
        }

        private void InitializeMainFormBoxes()
        {
            int xCenter = Console.WindowWidth / 2 - 10;

            LabelBox InfoLabel = new LabelBox { size = new Size(60, 3), location = new Point(xCenter, 5), Value = "Hoşgeldiniz" };

            ButtonBox listCariButton = new ButtonBox { size = new Size(20, 3), location = new Point(xCenter, 10), Value = "Cari Listele" };
            listCariButton.Action += listCariButtonClicked;

            ButtonBox createCariButton = new ButtonBox { size = new Size(20, 3), location = new Point(xCenter, 15), Value = "Cari oluştur" };
            createCariButton.Action += createCariButtonClicked;

            LabelBox InfoLabel2 = new LabelBox { size = new Size(60, 3), location = new Point(xCenter, 20), Value = "Lütfen seçim yapınız" };

            Boxes.Add(InfoLabel);
            Boxes.Add(listCariButton);
            Boxes.Add(createCariButton);
            Boxes.Add(InfoLabel2);
        }

        public void listCariButtonClicked()
        {
            Boxes.Clear();
            
        }

        public void createCariButtonClicked()
        {
            Boxes.Clear();
            Console.Clear();
            activeBoxIndex = 0;
            CariForm cariForm = new CariForm();
            Boxes.AddRange(cariForm.Boxes);
            Show();
        }
    }
}
