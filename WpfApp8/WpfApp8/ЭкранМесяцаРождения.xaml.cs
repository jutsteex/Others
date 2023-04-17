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
    /// Логика взаимодействия для ЭкранМесяцаРождения.xaml
    /// </summary>
    public partial class ЭкранМесяцаРождения : Window
    {
        public string month;
        public int chisloMonth;
        public ЭкранМесяцаРождения()
        {
            InitializeComponent();

        }
        private void MonthSpisok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            month = MonthSpisok.Text;
            switch (month)
            {
                case "январь":
                    chisloMonth = 1;
                    break;
                case "февраль":
                    chisloMonth = 2;
                    break;
                case "март":
                    chisloMonth = 3;
                    break;
                case "апрель":
                    chisloMonth = 4;
                    break;
                case "май":
                    chisloMonth = 5;
                    break;
                case "июнь":
                    chisloMonth = 6;
                    break;
                case "июль":
                    chisloMonth = 7;
                    break;
                case "август":
                    chisloMonth = 8;
                    break;
                case "сентябрь":
                    chisloMonth = 9;
                    break;
                case "октябрь":
                    chisloMonth = 10;
                    break;
                case "ноябрь":
                    chisloMonth = 11;
                    break;
                case "декабрь":
                    chisloMonth = 12;
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window ЭкранГодаРождения = new Window();
            ЭкранГодаРождения.Show();
            Close();
        }
    }
}
