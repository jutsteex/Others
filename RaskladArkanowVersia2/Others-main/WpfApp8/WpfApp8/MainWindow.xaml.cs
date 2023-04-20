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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //"Приветсвуем Вас! Здесь вы можете рассчитать свой аркан. Арканы Таро это главные карты, каждая из которых имеет свое значение. Каждый человек рождается под своим арканом, узнав который вы сможете узнать о себе или своих друзьях что то новое.";
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window ЭкранДняРождения = new Window();
            ЭкранДняРождения.Show();
            Close();
        }
    }
}
