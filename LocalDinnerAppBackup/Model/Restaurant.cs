using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinnerAppBackup.Model
{
    class Restaurant
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int NoOfSeats { get; set; }
        #endregion

        #region Constructor
        public Restaurant(int id, string name, string city, string category, int noOfSeats)
        {
            Id = id;
            Name = name;
            City = city;
            Category = category;
            NoOfSeats = noOfSeats;
        }
        #endregion

        #region ToString

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(City)}: {City}, {nameof(Category)}: {Category}, {nameof(NoOfSeats)}: {NoOfSeats}";
        }
        #endregion 
    }
}
