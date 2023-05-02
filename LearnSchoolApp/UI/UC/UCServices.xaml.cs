using System;
using LearnSchoolApp.Properties;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Shapes;

namespace LearnSchoolApp
{
    /// <summary>
    /// Логика взаимодействия для UCServices.xaml
    /// </summary>
    public partial class UCServices : UserControl
    {
        public Service Service { get; set; }
        public ImageSource ImageSource { get; set; }
        private const string sourcePrefix = "..\\..\\Data\\ServicesImages\\";
        public UCServices(Service service)
        {
            InitializeComponent();
            Service = service;
            DataContext = this;
            var services = AppData.db.Service.ToList();

            if (Service.Discount == 0)
            {
                tbCost.Text = $"{Math.Floor(Service.Cost)} рублей за {Service.DurationInSeconds / 60} минут";
            }
            else
            {
                Color color = new Color() { R = 231, G = 250, B = 191, A = 255 };
                border.Background = new SolidColorBrush(color);
                tbCost.Text = $"{Math.Floor(((double)Service.Cost)) - Service.Discount * ((double)Service.Cost)} рублей за {Service.DurationInSeconds / 60} минут";
                tbCostDiscount.Visibility = Visibility.Visible;
                tbCostDiscount.Text = Math.Floor(Service.Cost).ToString();
                tbDiscount.Text = $"^ скидка {Service.Discount * 100}%";
            }

            imgServ.Source = Image.SetImage(sourcePrefix + Service.MainImagePath);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!EnterCodeWnd.IsAdministrator)
                return;

            if (MessageBox.Show("Вы точно хотите удалить выбранную услугу?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
                return;
            else
            {
                AppData.db.Service.Remove(Service);
                AppData.db.SaveChanges();
                MessageBox.Show("Услуга удалена");
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (EnterCodeWnd.IsAdministrator)
                Manager.frame.Navigate(new AddEditServices(Service));
        }
    }
}

