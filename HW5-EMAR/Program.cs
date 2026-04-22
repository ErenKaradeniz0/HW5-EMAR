using HW5_EMAR.Forms;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             TODO: HW7
                1.1 - listeden kayıt seçip silme özelliği
                1.2 - listeden kayıt seçip güncelleme özelliği
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
