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
using System.Windows.Shapes;

namespace LearnSchoolApp
{
    /// <summary>
    /// Логика взаимодействия для EnterCodeWnd.xaml
    /// </summary>
    public partial class EnterCodeWnd : Window
    {
        public EnterCodeWnd()
        {
            InitializeComponent();
        }

        private static bool isAdministrator = false;
        public static bool IsAdministrator
        {
            get
            {
                if (!isAdministrator)
                    return Show();
                return isAdministrator;
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private static new bool Show()
        {
            EnterCodeWnd inputDialog = new EnterCodeWnd();
            inputDialog.ShowDialog();
            string text = inputDialog.tbxCode.Text;
            bool result = text == "0000" ? true : false;
            if (!result)
                MessageBox.Show("Неверный код", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                isAdministrator = true;
            return result;
        }
    }
}
