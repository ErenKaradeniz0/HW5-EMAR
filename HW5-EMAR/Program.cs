using HW5_EMAR.Forms;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             TODO: HW7
               0 - ana sayfa oluşturma (cari listele cari olutuştur seçeneği olmalı)
               1 - cari kayıtları listeleme özelliğ
                    1.1 - listeden kayıt seçip silme özelliği
                    1.2 - listeden kayıt seçip güncelleme özelliği
               2 - cari oluşturma özelliği
                    2.1 - kayıtları otomatik tutma
             */
            Console.CursorVisible = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            while (true)
            {
                mainForm.ProcessKey(Console.ReadKey(true));
            }
        }
    }
}
