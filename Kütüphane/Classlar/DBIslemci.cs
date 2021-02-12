using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kütüphane.Classlar
{
    public class DBIslemci
    {
        public static void GridDoldur(DataGrid grd)
        {
            SQLiteConnection conn = new SQLiteConnection(DBbaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("select * from tbl_KitapListesi",conn);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(com);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            grd.ItemsSource = dt.DefaultView;
            conn.Dispose();
        }
    }
}
