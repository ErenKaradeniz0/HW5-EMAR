using System.Drawing;

namespace HW5_EMAR
{
    public class CariForm : Form
    {
        TextBox CompanyNameTextBox;
        TextBox CompanyTaxIdTextBox;
        TextBox NameSurnameTextBox;
        TextBox PhoneTextBox;
        TextBox CityTextBox;
        TextBox DistrictTextBox;
        TextBox AddressTextBox;
        TextBox CategoryTextBox;

        public CariForm()
        {
            LabelBox CompanyNameLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 0), Value = "Firma Adi" };
            CompanyNameTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 0) };

            LabelBox CompanyTaxIdLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 3), Value = "Firma VKN" };
            CompanyTaxIdTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 3) };

            LabelBox NameSurnameLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 6), Value = "Ad Soyad" };
            NameSurnameTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 6) };

            LabelBox PhoneLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 9), Value = "Telefon" };
            PhoneTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 9) };

            LabelBox CityLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 12), Value = "Il" };
            CityTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 12) };

            LabelBox DistrictLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 15), Value = "Ilce" };
            DistrictTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 15) };

            LabelBox AddressLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 18), Value = "Adres" };
            AddressTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 18) };

            LabelBox CategoryLabel = new LabelBox { size = new Size(20, 3), location = new Point(5, 21), Value = "Kategori" };
            CategoryTextBox = new TextBox { size = new Size(20, 3), location = new Point(25, 21) };

            ButtonBox saveButton = new ButtonBox { size = new Size(20, 3), location = new Point(25, 25), Value = "Submit" };
            saveButton.Action += SaveButtonClicked;

            ButtonBox cancelButton = new ButtonBox { size = new Size(20, 3), location = new Point(45, 25), Value = "Cancel" };
            cancelButton.Action += CancelButtonClicked;

            Boxes.Add(CompanyNameLabel);
            Boxes.Add(CompanyNameTextBox);
            Boxes.Add(CompanyTaxIdLabel);
            Boxes.Add(CompanyTaxIdTextBox);
            Boxes.Add(NameSurnameLabel);
            Boxes.Add(NameSurnameTextBox);
            Boxes.Add(PhoneLabel);
            Boxes.Add(PhoneTextBox);
            Boxes.Add(CityLabel);
            Boxes.Add(CityTextBox);
            Boxes.Add(DistrictLabel);
            Boxes.Add(DistrictTextBox);
            Boxes.Add(AddressLabel);
            Boxes.Add(AddressTextBox);
            Boxes.Add(CategoryLabel);
            Boxes.Add(CategoryTextBox);
            Boxes.Add(saveButton);
            Boxes.Add(cancelButton);
        }

        public void SaveButtonClicked()
        {
            //Console.WriteLine("Save button clicked");
            var companyName = CompanyNameTextBox.Value;
            var companyTaxId = CompanyTaxIdTextBox.Value;
            var nameSurname = NameSurnameTextBox.Value;
            var phone = PhoneTextBox.Value;
            var city = CityTextBox.Value;
            var district = DistrictTextBox.Value;
            var address = AddressTextBox.Value;
            var category = CategoryTextBox.Value;
        }

        public void CancelButtonClicked()
        {
            Console.WriteLine("Cancel button clicked");
        }
    }
}
