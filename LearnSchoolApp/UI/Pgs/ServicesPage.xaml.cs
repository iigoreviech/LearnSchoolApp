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
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
            var currentService = AppData.db.Service.ToList();

            UpdateServices();
        }

        public void UpdateServices()
        {
            var services = AppData.db.Service.ToList();

            services = services.Where(p => p.Title.Replace(" ", "").ToLower().Contains(tbxSearch.Text.Replace(" ", "").ToLower())).ToList();

            lvServices.Items.Clear();
            foreach (var service in services)
                lvServices.Items.Add(new UCServices(service));
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                AppData.db.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                lvServices.ItemsSource = AppData.db.Service.ToList();
            }
        }

        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (EnterCodeWnd.IsAdministrator)
                Manager.frame.Navigate(new AddEditServices(null));
        }
    }
}
