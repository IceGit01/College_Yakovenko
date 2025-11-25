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

namespace College_Yakovenko.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report1Page.xaml
    /// </summary>
    public partial class Report1Page : Page
    {
        public Report1Page()
        {
            InitializeComponent();
            TakeCmb.DisplayMemberPath = "Name";
            TakeCmb.SelectedValuePath = "ID";
            TakeCmb.ItemsSource = App.context.Group.ToList();
            
            ReportDG.ItemsSource = App.context.Journal.ToList();
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(DateStartDp.Text) && string.IsNullOrEmpty(DateFinishDp.Text) && string.IsNullOrEmpty(TakeCmb.Text))  
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                int chouseGroup = Convert.ToInt32(TakeCmb.SelectedValue);
                var a = (DateTime)DateStartDp.SelectedDate;
                var b = (DateTime)DateFinishDp.SelectedDate;
                ReportDG.ItemsSource = App.context.Journal
                    .Where(j=> j.id_Group == chouseGroup)
                    .Where(o=> o.Date_event >= a && o.Date_event <= b)
                    .ToList();
            }
        }

      
    }
}
