using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace lab17zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] f;

            if (!File.Exists("D:\\Stytsun.txt"))
            {
                MessageBox.Show("Файл кентами 404.\n\n3читування неможливо", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            f = File.ReadAllLines("D:\\Stytsun.txt");

            string res = "";

            for (int i = 0; i < f.Length; i++)
                res += (i + 1).ToString() + ". " + f[i] + "\n";

            MessageBox.Show($"Перелік кентов:\n{res}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
