using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;
using System.Data;
using Kütüphane;
using System.Diagnostics;
using Kütüphane.Classlar;

namespace Kütüphane.Classlar
{
    public class DBbaglanti
    {
        public static string DBadres = @"Data Source=" + Environment.CurrentDirectory + "\\DB\\kitap.db; Version=3;Read Only=False;New=False;Compress=True;";
        public static bool BagDurum;
        public static void VT_Baglan()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBadres))
            {
                try
                {
                    BagDurum = false;
                    if (conn.State==ConnectionState.Closed)
                    {
                        conn.Open();
                        BagDurum = true;
                    }
                }
                catch (Exception error)
                {
                    Hata.hata_durumu(error,true);
                }
            }
        }
    }
}
