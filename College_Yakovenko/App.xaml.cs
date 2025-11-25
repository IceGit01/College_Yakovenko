using College_Yakovenko;
using College_Yakovenko.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace College_Yakovenko
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static College_Yakovenko_KuularEntities context = new College_Yakovenko_KuularEntities();
    }
}
