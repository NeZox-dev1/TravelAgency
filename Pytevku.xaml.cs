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
    /// Логика взаимодействия для Pytevku.xaml
    /// </summary>
    public partial class Pytevku : Page
    {
        public Pytevku()
        {
            InitializeComponent();
            TravelAgency.ItemsSource = TravelagencyEntities.GetContext().Vouchers.ToList();
        }

        private void HotBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Hotel());
        }


    }
}
