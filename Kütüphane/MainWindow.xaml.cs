using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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



        private void Bilgi_Label_Yaz(object sender, RoutedEventArgs e)
        {
            ToggleButton temp_button = new ToggleButton();
            Label temp_label = null;
            Label temp_labelx = null;
            if (sender.GetType() == typeof(ToggleButton))
            {
                temp_button = (ToggleButton)sender;

                if (temp_button != null)
                {
                    if (temp_button.IsChecked == true)
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

            foreach (var test in menu_stackpanel.Children.OfType<FrameworkElement>())
            {
                if (test is ToggleButton)
                {
                    ToggleButton ss = new ToggleButton();
                    ss = (ToggleButton)test;
                    foreach (var fwe in ((DockPanel)ss.Content).Children)
                    {
                        if (fwe is Label)
                        {
                            temp_labelx = (Label)fwe;
                            if(temp_label.Content!=temp_labelx.Content)
                            {
                                ss.IsChecked = false;
                            }
                            
                        }
                    }





                }
            }

        }
    }
}


