using HW5_EMAR.Forms;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            CariForm cariForm = new CariForm();
            cariForm.Show();
            while (true)
            {
                cariForm.ProcessKey(Console.ReadKey(true));
            }
        }
    }
}
