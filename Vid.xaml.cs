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
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class Vid : Page
    {
        public Vid()
        {
            InitializeComponent();
            TravelAgency.ItemsSource = TravelagencyEntities.GetContext().RestType.ToList();
        }

        private void AddBTN(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ADDBTN(null));
        }

        private void DelBTN(object sender, RoutedEventArgs e)
        {
            var ModelsForRemoving = TravelAgency.SelectedItems.Cast<RestType>().ToList();

            if (MessageBox.Show($"A you shure about that? {ModelsForRemoving.Count()} elements", "Warning",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelagencyEntities.GetContext().RestType.RemoveRange(ModelsForRemoving);
                    TravelagencyEntities.GetContext().SaveChanges();
                    MessageBox.Show("Complete");
                    TravelAgency.ItemsSource = TravelagencyEntities.GetContext().RestType.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }


    }
}
