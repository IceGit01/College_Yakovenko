using College_Yakovenko.View.Pages;
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

namespace College_Yakovenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AddGroupPage());
        }
        private void AddActivityPage_Click (object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddActivityPage());
        }

        private void AddGroupPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddGroupPage());
        }

        private void JournalPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage());
        }

        private void Report1Page_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report1Page());
        }

        private void Report2Page_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report2Page());
        }
    }
}
