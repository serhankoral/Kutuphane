using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kütüphane.Classlar
{
    class Hata
    {
        public static void hata_durumu(Exception error, bool program_kapama)
        {
            MessageBox.Show(error.Message + "\n" + "Program Yöneticisine Başvurun.");
            if (program_kapama)
            {
                foreach (var process in Process.GetProcessesByName("Kütüphane"))
                {
                    process.Kill();
                }
            }
        }
    }
}
