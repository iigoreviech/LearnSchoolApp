using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LearnSchoolApp
{
    internal class Image
    {
        private static string unknownImagePath = "..\\..\\Data\\ServicesImages\\Unknown.jpg";
        public static BitmapSource SetImage(string path)
        {
            BitmapImage bi = new BitmapImage();
            try
            {
                bi.BeginInit();
                bi.UriSource = new Uri(System.IO.Path.GetFullPath(path));
                bi.EndInit();
                return bi;
            }
            catch
            {
                bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(System.IO.Path.GetFullPath(unknownImagePath));
                bi.EndInit();
                return bi;
            }
        }
    }
}
