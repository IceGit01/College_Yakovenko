using College_Yakovenko.Model;
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
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();

            JournalLv.ItemsSource = App.context.Journal.ToList();

            SpecialCmb.SelectedValuePath = "Id";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();

            DirectionlCmb.SelectedValuePath = "Id";
            DirectionlCmb.DisplayMemberPath = "Name";
            DirectionlCmb.ItemsSource = App.context.Direction.ToList();

            GrouplCmb.SelectedValuePath = "Id";
            GrouplCmb.DisplayMemberPath="Name";
            GrouplCmb.ItemsSource= App.context.Group.ToList();

            ActivitylCmb.SelectedValuePath = "Id";
            ActivitylCmb.DisplayMemberPath = "Name";
            ActivitylCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(SpecialCmb.Text) && string.IsNullOrEmpty(DirectionlCmb.Text) && string.IsNullOrEmpty(GrouplCmb.Text) && string.IsNullOrEmpty(ActivitylCmb.Text) && string.IsNullOrEmpty(MarkTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Journal journal = new Journal()
                {
                    Date_event = (DateTime)DateEventDp.SelectedDate,
                    Group = GrouplCmb.SelectedItem as Group,
                    Activity = ActivitylCmb.SelectedItem as Activity,
                    Mark = Convert.ToDecimal(MarkTb.Text)
                };
                App.context.Journal.Add(journal);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена");

                JournalLv.ItemsSource = App.context.Journal.ToList();
            } 
        }
    }
}
