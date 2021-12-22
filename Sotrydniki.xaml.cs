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
    /// Логика взаимодействия для Sotrydniki.xaml
    /// </summary>
    public partial class Sotrydniki : Page
    {
        public Sotrydniki()
        {
            InitializeComponent();
            TravelAgency.ItemsSource = TravelagencyEntities.GetContext().Employees.ToList();
        }

        private void DolzBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Dolznosti());
        }
    }
}
