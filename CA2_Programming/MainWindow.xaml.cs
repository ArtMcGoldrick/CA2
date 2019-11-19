using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CA2_Programming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating list outside of evrything 
        ObservableCollection<Activity> activitys;

        public MainWindow()
        {
            InitializeComponent();
        }

        //This method will run when window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create 3 expense objects
            Activity a1 = new Activity() { Name = "Kayaking", Cost = 12.50m, Description = "Instructor teaches kayaking", TypeOfActivity = ActivityType.Water, ActivityDate=new DateTime(2019, 6, 1)};
            Activity a2 = new Activity() { Name = "Parachuting", Cost = 15.00m, Description = "Instructor teaches parachuting", TypeOfActivity = ActivityType.Air, ActivityDate = new DateTime(2019, 6, 1) };
            Activity a3 = new Activity() { Name = "Mountain Biking", Cost = 10.00m, Description = "Instructor teaches mountain biking", TypeOfActivity = ActivityType.Land, ActivityDate = new DateTime(2019, 6, 2) };

            //Add those to a list
            activitys = new ObservableCollection<Activity>();
            activitys.Add(a1);
            activitys.Add(a2);
            activitys.Add(a3);

            //Display list in listbox
            listBox.ItemsSource = activitys;

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            return;
        }
    }
}
