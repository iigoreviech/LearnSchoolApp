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

namespace LearnSchoolApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditServices.xaml
    /// </summary>
    public partial class AddEditServices : Page
    {
        private Service _currentService = new Service();
        public AddEditServices(Service selectedService)
        {
            InitializeComponent();

            if (selectedService != null)
                _currentService = selectedService;

            DataContext = _currentService;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentService.Title))
                errors.AppendLine("Укажите название услуги");
            if (_currentService.Cost < 0 || _currentService.Cost > 100000)
                errors.AppendLine("Укажите корректную цену услуги");
            if (_currentService.Discount < 0 || _currentService.Discount > 0.9)
                errors.AppendLine("Укажите корректную скидку на услугу в десятичной форме");
            if (string.IsNullOrWhiteSpace(_currentService.MainImagePath))
                errors.AppendLine("Укажите путь к изображению");
            if (string.IsNullOrWhiteSpace(tbxDiscount.Text))
                errors.AppendLine("Укажите скидку на услугу");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentService.ID == 0)
                AppData.db.Service.Add(_currentService);

            try
            {
                AppData.db.SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            btnCancel.IsEnabled = false;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new ServicesPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new ServicesPage());
        }
    }
}
