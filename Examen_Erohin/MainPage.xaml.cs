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

namespace Examen_Erohin
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        ErohinEntities context;
        public MainPage()
        {
           
            context = new ErohinEntities();
            DGrid.ItemsSource = context.Order.ToList();
            cboxfilter.ItemsSource = context.Order.ToList();
            InitializeComponent();
        }

        private void tboxfilter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cboxfilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_red_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
