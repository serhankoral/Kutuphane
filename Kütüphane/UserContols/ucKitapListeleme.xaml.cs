using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kütüphane.UserContols
{
    /// <summary>
    /// ucKitapListeleme.xaml etkileşim mantığı
    /// </summary>
    public partial class ucKitapListeleme : UserControl
    {
        public ucKitapListeleme()
        {
            InitializeComponent();
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void Kitap_Ekle_Button_Click(object sender, RoutedEventArgs e)
        {
            Win_Kitap_Ekle temp_kitap_ekle = new Win_Kitap_Ekle();
            temp_kitap_ekle.Owner = gk;
            gk.Opacity = 0.3;
            temp_kitap_ekle.ShowDialog();
        }
    }
}
