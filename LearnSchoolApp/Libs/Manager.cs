using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LearnSchoolApp
{
    class Manager
    {
        public static Frame frame { get; set; }
    }

    class AppData
    {
        public static SchoolLearn_ShimchenkoEntities2 db = new SchoolLearn_ShimchenkoEntities2();
    }
}
