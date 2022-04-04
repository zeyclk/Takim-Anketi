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

namespace SampiyonTakim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.toplam = 0;
            App.takimOySayilari = new double[4];
        }

        int glt=0;
        int fb=0;
        int bjk=0;
        int diger=0;


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
            App.toplam ++;

            //Galatasaraya oy verenleri saymak için
            if (rb1.IsChecked == true)
            {
                
                glt ++;
            }
            
            //Fenerbahçeye oy verenleri saymak için
            else if (rb2.IsChecked == true)
            {
                
                fb ++;
            }

            //Beşiktaşa oy verenleri saymak için
            else if (rb3.IsChecked == true)
            {
                
                bjk ++;
            }

            //Diğer takıma oy verenleri saymak için
            else if (rb4.IsChecked == true)
            {
                
                diger ++;
            }

            App.takimOySayilari[0] = glt;
            App.takimOySayilari[1] = fb;
            App.takimOySayilari[2] = bjk;
            App.takimOySayilari[3] = diger;
            
            //Oy için teşekkürler
            MessageBox.Show("Anketimize katıldığınız için teşekkürler.","Şampiyon",MessageBoxButton.OK,MessageBoxImage.Information);
        }




        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //Yeni pencereye aktarmak için
            Sonuc snc = new Sonuc();
            snc.Show();

        }


    }
}
