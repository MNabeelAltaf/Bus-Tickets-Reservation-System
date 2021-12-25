using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VP_project
{
    /// <summary>
    /// Interaction logic for historyTickets.xaml
    /// </summary>
    public partial class historyTickets : Window
    {
        public historyTickets()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(searchPhone.Text))
            {
                MessageBox.Show("Enter registered phone number", "Blank Field", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }

            if (!(searchPhone.Text.Length == 11))
            {
                MessageBox.Show("Phone number invalid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;

            }
        }

        private void searchPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void searchPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            //x
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ScheduleWindow sw = new ScheduleWindow();
            sw.Show();
            this.Close();
        }
    }
}
