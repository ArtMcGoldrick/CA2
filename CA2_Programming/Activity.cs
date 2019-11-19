using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_Programming
{
    //Enum for activity types
    public enum ActivityType
    {
        Air,
        Water,
        Land
    }
    class Activity : IComparable
    {
        //Properties
        public string Name { get; set; }
        public decimal Cost { get; set; }
        private string _description { get; set; }
        public ActivityType TypeOfActivity { get; set; }
        public DateTime ActivityDate { get; set; }

        //Long hand approach
        public string Description
        {
            get { return _description; }
            set { _description = Description; }
        }

        //Empty constructor
        public Activity() { }

        public Activity(string name, decimal cost, string description, ActivityType typeOfActivity, DateTime activityDate)
        {
            name = Name;
            cost = Cost;
            description = Description;
            typeOfActivity = TypeOfActivity;
            activityDate = ActivityDate;
        }


        /*
        public DateTime Kayaking { get; set; }
        public DateTime Parachuting { get; set; }
        public DateTime MountainBiking { get; set; }
        public DateTime HangGliding { get; set; }
        public DateTime Abseiling { get; set; }
        public DateTime Sailing { get; set; }
        public DateTime HelicoptorTour { get; set; }
        */
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
