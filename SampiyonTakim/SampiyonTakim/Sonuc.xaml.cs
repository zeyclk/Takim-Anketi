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

namespace SampiyonTakim
{
    /// <summary>
    /// Interaction logic for Sonuc.xaml
    /// </summary>
    public partial class Sonuc : Window
    {
        public Sonuc()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //"s" ile başlayan değişkenlere oy sayılarının yüzdesini attık. Yanına ise "%" işareti ekledik.
            double s1=(App.takimOySayilari[0] / App.toplam) * 100;
            txtr1.Text = ((int)s1).ToString() + "%";

            double s2 = (App.takimOySayilari[1] / App.toplam) * 100;
            txtr2.Text = ((int)s2).ToString() + "%";

            double s3 = (App.takimOySayilari[2] / App.toplam) * 100;
            txtr3.Text = ((int)s3).ToString() + "%";

            double s4 = (App.takimOySayilari[3] / App.toplam) * 100;
            txtr4.Text = ((int)s4).ToString() + "%";

            //Genişliği her neyse 2 katı kadar büyütmesini istedik.
            r1.Width = s1 * 2;
            r2.Width = s2 * 2;
            r3.Width = s3 * 2;
            r4.Width = s4 * 2;
        }
    }
}
