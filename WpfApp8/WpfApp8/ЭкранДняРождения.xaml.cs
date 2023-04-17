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
        public string day;
        public int chisloDay;
        public ЭкранДняРождения()
        {
            InitializeComponent();
            Day.Content = "Укажите число дня рождения:";
        }

        private void DaySpisok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            day = DaySpisok.Text;
            chisloDay = Convert.ToInt32(day);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Window ЭкранМесяцаРождения = new Window();
            ЭкранМесяцаРождения.Show();
            Close();
        }
    }
}
