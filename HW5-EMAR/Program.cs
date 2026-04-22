using HW5_EMAR.Forms;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
