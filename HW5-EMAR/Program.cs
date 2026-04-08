using System;

namespace HW5_EMAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CariForm cariForm = new CariForm();
            cariForm.Show();
            while (true)
            {
                cariForm.ProcessKey(Console.ReadKey(true));
            }
        }
    }
}
