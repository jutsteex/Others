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
    /// Логика взаимодействия для ЭкранГодаРождения.xaml
    /// </summary>
    public partial class ЭкранГодаРождения : Window
    {
        public int year;
        public int chisloYear;
        public ЭкранГодаРождения()
        {
            InitializeComponent();
        }

        private void YearhSpisok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            year = Convert.ToInt32(YearhSpisok.Text);
            switch (year)
            {
                case 1990:
                    chisloYear = 10;
                    break;
                case 1991:
                    chisloYear = 2;
                    break;
                case 1992:
                    chisloYear = 3;
                    break;
                case 1993:
                    chisloYear = 4;
                    break;
                case 1994:
                    chisloYear = 5;
                    break;
                case 1995:
                    chisloYear = 6;
                    break;
                case 1996:
                    chisloYear = 7;
                    break;
                case 1997:
                    chisloYear = 8;
                    break;
                case 1998:
                    chisloYear = 10;
                    break;
                case 1999:
                    chisloYear = 10;
                    break;
                case 2000:
                    chisloYear = 2;
                    break;
                case 2001:
                    chisloYear = 3;
                    break;
                case 2002:
                    chisloYear = 4;
                    break;
                case 2003:
                    chisloYear = 5;
                    break;
                case 2004:
                    chisloYear = 6;
                    break;
                case 2005:
                    chisloYear = 7;
                    break;
                case 2006:
                    chisloYear = 8;
                    break;
                case 2007:
                    chisloYear = 9;
                    break;
                case 2008:
                    chisloYear = 10;
                    break;
                case 2009:
                    chisloYear = 2;
                    break;
                case 2010:
                    chisloYear = 3;
                    break;
                case 2011:
                    chisloYear = 4;
                    break;
                case 2012:
                    chisloYear = 5;
                    break;
                case 2013:
                    chisloYear = 6;
                    break;
                case 2014:
                    chisloYear = 7;
                    break;
                case 2015:
                    chisloYear = 8;
                    break;
                case 2016:
                    chisloYear = 9;
                    break;
                case 2017:
                    chisloYear = 10;
                    break;
                case 2018:
                    chisloYear = 2;
                    break;
                case 2019:
                    chisloYear = 3;
                    break;
                case 2020:
                    chisloYear = 4;
                    break;
                case 2021:
                    chisloYear = 5;
                    break;
                case 2022:
                    chisloYear = 6;
                    break;
                case 2023:
                    chisloYear = 7;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Результат = new Window();
            Результат.Show();
            Close();
        }
    }
}
