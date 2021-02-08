using Kütüphane.Classlar;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Kütüphane
{
    /// <summary>
    /// Win_Kitap_Ekle.xaml etkileşim mantığı
    /// </summary>
    public partial class Win_Kitap_Ekle : Window
    {
        public Win_Kitap_Ekle()
        {
            InitializeComponent();
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void kitap_stok_adeti_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            { e.Handled = true; }
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {

            gk.Opacity = 1;
            this.Close();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bonus.PopupShow(test_popup);
        }
    }
}
