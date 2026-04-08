using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace HW5_EMAR
{
    public class CariForm : Form
    {
        TextBox NameSurnameTextBox;
        TextBox AddressTextBox;
        TextBox PhoneTextBox;

        public CariForm()
        {
            NameSurnameTextBox = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 0),
            };
            AddressTextBox = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 4),
            };
            PhoneTextBox = new TextBox
            {
                size = new Size (20, 3),
                location = new Point(25, 8),
            };
            LabelBox NameSurnameLabel = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 0),
                Value = "Name Surname"
            };
            LabelBox AddressLabel = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 4),
                Value = "Address"
            };
            LabelBox PhoneLabel = new LabelBox
            {
                size = new Size (20, 3),
                location = new Point(5, 8),
                Value = "Phone"
            };
            ButtonBox saveButton = new ButtonBox
            {
                size = new Size (20, 3),
                location = new Point(25, 14),
                Value = "Submit"
            };
            saveButton.IslemYap += SaveButtonClicked;

            ButtonBox cancelButton = new ButtonBox
            {
                size = new Size(20, 3),
                location = new Point(45, 14),
                Value = "Cancel"
            };
            cancelButton.IslemYap += CancelButtonClicked;
            Boxes.Add(NameSurnameTextBox);
            Boxes.Add(AddressTextBox);
            Boxes.Add(PhoneTextBox);
            Boxes.Add(NameSurnameLabel);
            Boxes.Add(AddressLabel);
            Boxes.Add(PhoneLabel);
            Boxes.Add(saveButton);
            Boxes.Add(cancelButton);
        }
    
        public void SaveButtonClicked()
        {
            //Console.WriteLine("Save button clicked");
            var nameSurname = NameSurnameTextBox.Value;
            var adress = AddressTextBox.Value;

        }
        public void CancelButtonClicked()
        {
            Console.WriteLine("Cancel button clicked");
        }
    }
}
