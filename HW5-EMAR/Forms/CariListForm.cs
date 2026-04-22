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
        private const string RecordsFilePath = "records.txt";

        public Action OnBack { get; set; }
        public Action OnReload { get; set; }

        public CariListForm()
        {
            int xCenter = Console.WindowWidth / 2 - 10;
            LabelBox infoLabel = new LabelBox { size = new Size(60, 3), location = new Point(xCenter - 10, 2), Value = "Cari Listesi" };
            Boxes.Add(infoLabel);

            ButtonBox backButton = new ButtonBox { size = new Size(20, 3), location = new Point(xCenter + 10, 2), Value = "Geri don" };
            backButton.Action += BackButtonClicked;
            Boxes.Add(backButton);

            var records = LoadRecords();
            int rowY = 6;

            if (records.Count == 0)
            {
                Boxes.Add(new LabelBox { size = new Size(80, 3), location = new Point(5, rowY), Value = "Kayit bulunamadi" });
                return;
            }

            for (int i = 0; i < records.Count; i++)
            {
                var record = records[i];
                int recordIndex = i;

                Boxes.Add(new LabelBox
                {
                    size = new Size(80, 3),
                    location = new Point(5, rowY),
                    Value = $"{i + 1}. {record.CompanyName} | {record.NameSurname} | {record.Phone}"
                });

                var updateButton = new ButtonBox
                {
                    size = new Size(14, 3),
                    location = new Point(88, rowY),
                    Value = "Guncelle"
                };
                updateButton.Action += () => UpdateRecord(recordIndex);
                Boxes.Add(updateButton);

                var deleteButton = new ButtonBox
                {
                    size = new Size(10, 3),
                    location = new Point(103, rowY),
                    Value = "Sil"
                };
                deleteButton.Action += () => DeleteRecord(recordIndex);
                Boxes.Add(deleteButton);

                rowY += 3;
                if (rowY >= Console.WindowHeight - 4)
                {
                    break;
                }
            }
        }

        private void DeleteRecord(int index)
        {
            var records = LoadRecords();
            if (index < 0 || index >= records.Count)
            {
                return;
            }

            records.RemoveAt(index);
            SaveRecords(records);
            OnReload?.Invoke();
        }

        private void UpdateRecord(int index)
        {
            var records = LoadRecords();
            if (index < 0 || index >= records.Count)
            {
                return;
            }

            var record = records[index];

            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("Kayit guncelle (bos birakirsan mevcut deger korunur)");
            Console.WriteLine();

            record.CompanyName = Prompt("Firma Adi", record.CompanyName);
            record.CompanyTaxId = Prompt("Firma VKN", record.CompanyTaxId);
            record.NameSurname = Prompt("Ad Soyad", record.NameSurname);
            record.Phone = Prompt("Telefon", record.Phone);
            record.City = Prompt("Il", record.City);
            record.District = Prompt("Ilce", record.District);
            record.Address = Prompt("Adres", record.Address);
            record.Category = Prompt("Kategori", record.Category);

            records[index] = record;
            SaveRecords(records);
            Console.CursorVisible = false;
            OnReload?.Invoke();
        }

        private static string Prompt(string fieldName, string currentValue)
        {
            Console.Write($"{fieldName} ({currentValue}): ");
            var input = Console.ReadLine();
            return string.IsNullOrWhiteSpace(input) ? currentValue : input.Trim();
        }

        private static List<CariRecord> LoadRecords()
        {
            var records = new List<CariRecord>();
            if (!File.Exists(RecordsFilePath))
            {
                return records;
            }

            var lines = File.ReadAllLines(RecordsFilePath);
            CariRecord current = null;

            foreach (var rawLine in lines)
            {
                var line = rawLine.Trim();
                if (line.StartsWith("Firma Adi:"))
                {
                    current = new CariRecord();
                    current.CompanyName = GetValue(line);
                }
                else if (line.StartsWith("Firma VKN:") && current != null)
                {
                    current.CompanyTaxId = GetValue(line);
                }
                else if (line.StartsWith("Ad Soyad:") && current != null)
                {
                    current.NameSurname = GetValue(line);
                }
                else if (line.StartsWith("Telefon:") && current != null)
                {
                    current.Phone = GetValue(line);
                }
                else if (line.StartsWith("Il:") && current != null)
                {
                    current.City = GetValue(line);
                }
                else if (line.StartsWith("Ilce:") && current != null)
                {
                    current.District = GetValue(line);
                }
                else if (line.StartsWith("Adres:") && current != null)
                {
                    current.Address = GetValue(line);
                }
                else if (line.StartsWith("Kategori:") && current != null)
                {
                    current.Category = GetValue(line);
                    records.Add(current);
                    current = null;
                }
            }

            return records;
        }

        private static void SaveRecords(List<CariRecord> records)
        {
            var sb = new StringBuilder();
            foreach (var record in records)
            {
                sb.AppendLine("------------------------------");
                sb.AppendLine($"Firma Adi: {record.CompanyName}");
                sb.AppendLine($"Firma VKN: {record.CompanyTaxId}");
                sb.AppendLine($"Ad Soyad: {record.NameSurname}");
                sb.AppendLine($"Telefon: {record.Phone}");
                sb.AppendLine($"Il: {record.City}");
                sb.AppendLine($"Ilce: {record.District}");
                sb.AppendLine($"Adres: {record.Address}");
                sb.AppendLine($"Kategori: {record.Category}");
                sb.AppendLine("------------------------------");
            }

            File.WriteAllText(RecordsFilePath, sb.ToString());
        }

        private static string GetValue(string line)
        {
            var separatorIndex = line.IndexOf(':');
            if (separatorIndex < 0 || separatorIndex + 1 >= line.Length)
            {
                return string.Empty;
            }

            return line.Substring(separatorIndex + 1).Trim();
        }

        public void BackButtonClicked()
        {
            OnBack?.Invoke();
        }

        private class CariRecord
        {
            public string CompanyName { get; set; } = string.Empty;
            public string CompanyTaxId { get; set; } = string.Empty;
            public string NameSurname { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string District { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
        }
    }
}
