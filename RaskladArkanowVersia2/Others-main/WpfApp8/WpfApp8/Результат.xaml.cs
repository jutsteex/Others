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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для Результат.xaml
    /// </summary>
    public partial class Результат : Window
    {
        public int rez;
        public Результат()
        {
            InitializeComponent();
            результат.Content = "ПОЗДРАВЛЯЕМ!";
        }
        public void Rezultat(object sender, RoutedEventArgs e)
        {
            rez = chisloDay + chisloMonth + chisloYear;
        }
    }
}
