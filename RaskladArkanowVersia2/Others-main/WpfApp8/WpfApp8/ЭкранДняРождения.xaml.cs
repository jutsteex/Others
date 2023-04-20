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
    /// Логика взаимодействия для ЭкранДняРождения.xaml
    /// </summary>
    public partial class ЭкранДняРождения : Window
    {
        public int day;
        public int chisloDay;
        public ЭкранДняРождения()
        {
            InitializeComponent();
            Day.Content = "Укажите число дня рождения:";
        }

        private void DaySpisok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            day = Convert.ToInt32(DaySpisok.Text);
            switch (day)
            {
                case 1:
                    chisloDay = 1;
                    break;
                case 2:
                    chisloDay = 2;
                    break;
                case 3:
                    chisloDay = 3;
                    break;
                case 4:
                    chisloDay = 4;
                    break;
                case 5:
                    chisloDay = 5;
                    break;
                case 6:
                    chisloDay = 6;
                    break;
                case 7:
                    chisloDay = 7;
                    break;
                case 8:
                    chisloDay = 8;
                    break;
                case 9:
                    chisloDay = 9;
                    break;
                case 10:
                    chisloDay = 1;
                    break;
                case 11:
                    chisloDay = 2;
                    break;
                case 12:
                    chisloDay = 3;
                    break;
                case 13:
                    chisloDay = 4;
                    break;
                case 14:
                    chisloDay = 5;
                    break;
                case 15:
                    chisloDay = 6;
                    break;
                case 16:
                    chisloDay = 7;
                    break;
                case 17:
                    chisloDay = 8;
                    break;
                case 18:
                    chisloDay = 9;
                    break;
                case 19:
                    chisloDay = 10;
                    break;
                case 20:
                    chisloDay = 2;
                    break;
                case 21:
                    chisloDay = 3;
                    break;
                case 22:
                    chisloDay = 4;
                    break;
                case 23:
                    chisloDay = 5;
                    break;
                case 24:
                    chisloDay = 6;
                    break;
                case 25:
                    chisloDay = 7;
                    break;
                case 26:
                    chisloDay = 8;
                    break;
                case 27:
                    chisloDay = 9;
                    break;
                case 28:
                    chisloDay = 10;
                    break;
                case 29:
                    chisloDay = 11;
                    break;
                case 30:
                    chisloDay = 3;
                    break;
                case 31:
                    chisloDay = 4;
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Window ЭкранМесяцаРождения = new Window();
            ЭкранМесяцаРождения.Show();
            Close();
        }
    }
}
