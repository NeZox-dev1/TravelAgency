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
    /// Логика взаимодействия для Zastavka.xaml
    /// </summary>
    public partial class Zastavka : Page
    {
        public Zastavka()
        {
            InitializeComponent();
          
        }

        private void PytBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pytevku());
        }

        private void VidBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Vid());
        }
    }
}
