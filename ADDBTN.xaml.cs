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
    /// Логика взаимодействия для ADDBTN.xaml
    /// </summary>
    public partial class ADDBTN : Page
    {
        private RestType _currentModel = new RestType();
        public ADDBTN(RestType selectedModel)
        {
            InitializeComponent();
            if (selectedModel != null)
                _currentModel = selectedModel;
            DataContext = _currentModel;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentModel.Наименование))
                errors.AppendLine("Введите Наименование");
            if (string.IsNullOrWhiteSpace(_currentModel.Описание))
                errors.AppendLine("Введите Описание");
            if (string.IsNullOrWhiteSpace(_currentModel.Ограничения))
                errors.AppendLine("Введите Ограничения");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentModel.Код_вида == 0)
                TravelagencyEntities.GetContext().RestType.Add(_currentModel);

            try
            {
                TravelagencyEntities.GetContext().SaveChanges();
                MessageBox.Show("Saved");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}

