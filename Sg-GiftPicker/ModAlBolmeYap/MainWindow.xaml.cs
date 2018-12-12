using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace ModAlBolmeYap
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Random_Bt_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int degerMax, degerF, degerMin;

                if (Random_Min_Tb.Text != "")
                {
                    degerMin = Convert.ToInt32(Random_Min_Tb.Text);
                }
                else
                {
                    degerMin = 0;
                }
                degerMax = Convert.ToInt32(Random_Max_Tb.Text);
                degerF = rnd.Next(degerMin, degerMax + 1);
                Sayi1_Tb.Text = degerF.ToString();
            }
            catch (Exception exception)
            {
                this.ShowMessageAsync("Error !",exception.Message);
            }
            
        }

        private void Action_Bt_OnClick(object sender, RoutedEventArgs e)
        {
            int sayi1, sayi2, bolum, mod;
            try
            {
                sayi1 = Convert.ToInt32(Sayi1_Tb.Text);
                sayi2 = Convert.ToInt32(Sayi2_Tb.Text);
                bolum = sayi1 / sayi2;
                mod = sayi1 % sayi2;

                if (mod != 0)
                {
                    Sonuc_Tb.Text = "Page : " + (bolum + 1) + Environment.NewLine + "Item : " + mod;
                }
                else
                {
                    Sonuc_Tb.Text = "Page : " + bolum + Environment.NewLine + "Item : " + 12;
                }
            }
            catch (Exception exception)
            {
                this.ShowMessageAsync("Error !", exception.Message);
            }
        }

        private void Random_Max_Tb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Random_Min_Tb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Sayi1_Tb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Sayi2_Tb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
