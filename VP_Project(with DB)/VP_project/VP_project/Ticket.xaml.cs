using System;
using System.Collections.Generic;
using System.Data;
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


namespace VP_project
{
    /// <summary>
    /// Interaction logic for Ticket.xaml
    /// </summary>
    public partial class Ticket : Window
    {

        ProjectDBEntities db = new ProjectDBEntities();

        public Ticket()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ScheduleWindow sw = new ScheduleWindow();
            sw.Show();
        
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            historyTickets ht = new historyTickets();
            ht.Show();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // int max = db.Tables.Max(p => p.Id);


            //=====================For displaying (ALL USER) specific information of user in one Data Grid=========

            //var res = from t1 in db.Tables
            //          join t2 in db.Table2
            //          on t1.Id equals t2.Id

            //          select new
            //          {
            //              id = t1.Id,

            //              FullName = t1.First_Name + " " + t1.Last_Name,
            //              CNIC_No = t1.CNIC,
            //              CurrentCity = t1.City,
            //              PhoneNumber = t1.Phone_Number,
            //              DepartureCity = t2.Departure_City,
            //              DestinationCity = t2.Destination_City,
            //              BusClass = t2.Bus_Class,
            //              DepartureTiming = t2.Timing,

            //          };


            // first remove tickets2 data grid 

            // tickets.ItemsSource = res.ToList();

            //================================================================


            //-----------------------------Rough work-------------------
            //int max1 = db.Tables.Max(p => p.Id);


            //int max2 = db.Table2.Max(p => p.Id);


            //var res1 = (from t1 in db.Tables
            //            select t1);


            //var res2 = (from t2 in db.Table2

            //           select t2);


            //-----------------------------Rough work-------------------





            var tb1 = db.Tables.OrderByDescending(o => o.Id).Take(1);
            var tb2 = db.Table2.OrderByDescending(o => o.Id).Take(1);

            tickets.ItemsSource = tb1.ToList();

            tickets2.ItemsSource = tb2.ToList();


        }
    }
}
