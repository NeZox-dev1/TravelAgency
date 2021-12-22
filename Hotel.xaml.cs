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

namespace TravelAgency
{
    /// <summary>
    /// Логика взаимодействия для Hotel.xaml
    /// </summary>
    public partial class Hotel : Page
    {
        public Hotel()
        {
            InitializeComponent();
            TravelAgency.ItemsSource = TravelagencyEntities.GetContext().Hotels.ToList();
          
        }

        private void SotBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Sotrydniki());
        }

        private void YslBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Yslygi());
        }
    }
}
