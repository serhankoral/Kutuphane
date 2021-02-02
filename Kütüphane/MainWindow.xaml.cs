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
using Kütüphane.Classlar;
using Kütüphane.UserContols;

namespace Kütüphane
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Surukle(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Bilgi_Label_Yaz(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button temp_button = (Button)sender;
                Label temp_label = null;
                if (temp_button != null)
                {
                    if (temp_button.IsFocused)
                        foreach (var fwe in ((DockPanel)temp_button.Content).Children)
                        {
                            if (fwe is Label)
                            {
                                temp_label = (Label)fwe;
                                Islem_Bilgi_Label.Content = temp_label.Content;
                            }
                        }
                }
            }
        }

        private void Menu_Kitap_Listesi_Butonu_Click(object sender, RoutedEventArgs e)
        {
            Uc_Cagir.Uc_Ekle(Menu_icerik, new ucKitapListeleme());            
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                btn_maximize.Content = "□";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                btn_maximize.Content = "□";
            }
        }
    }
}


