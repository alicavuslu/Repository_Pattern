using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using EF.Business;
//using EF.Data;

namespace EF.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Tüm Personelimiz Listeler
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Repository<Personel> ds = new Repository<Personel>();

            //dataGrid1.ItemsSource = ds.Listele();
        }

        // Tüm Şirketleri Listeler
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Repository<Sirket> ds = new Repository<Sirket>();
            //dataGrid1.ItemsSource = ds.Listele();
        }

        // Gelen  Sorgulara Göre Listeleme Yapar
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Repository<Personel> ps = new Repository<Personel>();

            int sirketid = Convert.ToInt32(textBox1.Text);

            //dataGrid1.ItemsSource = ps.SorguyaGoreListele(p => p.Sirketid == sirketid);
        }
    }
}