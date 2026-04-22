using HW5_EMAR.Boxes;
using System;
using System.Drawing;
using System.IO;

namespace HW5_EMAR.Forms
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
        LabelBox InfoLabel;

        public Action OnBack { get; set; }

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

            ButtonBox saveButton = new ButtonBox { size = new Size(20, 3), location = new Point(25, 25), Value = "Kaydet" };
            saveButton.Action += SaveButtonClicked;

            ButtonBox cancelButton = new ButtonBox { size = new Size(20, 3), location = new Point(45, 25), Value = "Iptal" };
            cancelButton.Action += CancelButtonClicked;

            ButtonBox backButton = new ButtonBox { size = new Size(20, 3), location = new Point(65, 25), Value = "Geri dön" };
            backButton.Action += BackButtonClicked;


            InfoLabel = new LabelBox { size = new Size(60, 3), location = new Point(5, 28), Value = "Tab ile ilerle - Space ile butona bas" };

            Boxes.Add(CompanyNameTextBox);
            Boxes.Add(CompanyNameLabel);
            Boxes.Add(CompanyTaxIdTextBox);
            Boxes.Add(CompanyTaxIdLabel);
            Boxes.Add(NameSurnameTextBox);
            Boxes.Add(NameSurnameLabel);
            Boxes.Add(PhoneTextBox);
            Boxes.Add(PhoneLabel);
            Boxes.Add(CityTextBox);
            Boxes.Add(CityLabel);
            Boxes.Add(DistrictTextBox);
            Boxes.Add(DistrictLabel);
            Boxes.Add(AddressTextBox);
            Boxes.Add(AddressLabel);
            Boxes.Add(CategoryTextBox);
            Boxes.Add(CategoryLabel);
            Boxes.Add(saveButton);
            Boxes.Add(cancelButton);
            Boxes.Add(backButton);
            Boxes.Add(InfoLabel);
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

            string record =
                            $"------------------------------\n" +
                            $"Firma Adi: {companyName}\n" +
                            $"Firma VKN: {companyTaxId}\n" +
                            $"Ad Soyad: {nameSurname}\n" +
                            $"Telefon: {phone}\n" +
                            $"Il: {city}\n" +
                            $"Ilce: {district}\n" +
                            $"Adres: {address}\n" +
                            $"Kategori: {category}\n" +
                            $"------------------------------\n";

            File.AppendAllText("records.txt", record);

            InfoLabel.Value = "Kaydedildi";

            CompanyNameTextBox.Value = string.Empty;
            CompanyTaxIdTextBox.Value = string.Empty;
            NameSurnameTextBox.Value = string.Empty;
            PhoneTextBox.Value = string.Empty;
            CityTextBox.Value = string.Empty;
            DistrictTextBox.Value = string.Empty;
            AddressTextBox.Value = string.Empty;
            CategoryTextBox.Value = string.Empty;
        }

        public void CancelButtonClicked()
        {
            //Console.WriteLine("Cancel button clicked");

            CompanyNameTextBox.Value = string.Empty;
            CompanyTaxIdTextBox.Value = string.Empty;
            NameSurnameTextBox.Value = string.Empty;
            PhoneTextBox.Value = string.Empty;
            CityTextBox.Value = string.Empty;
            DistrictTextBox.Value = string.Empty;
            AddressTextBox.Value = string.Empty;
            CategoryTextBox.Value = string.Empty;
        }
        public void BackButtonClicked()
        {
            OnBack?.Invoke();
        }
    }
}
