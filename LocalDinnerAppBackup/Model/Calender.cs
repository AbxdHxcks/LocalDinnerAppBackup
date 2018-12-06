using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinnerAppBackup.Model
{
    class Calender
    {
        public int Dato { get; set; }
        public int ActualNoOfSeats { get; set; }

        public Calender(int dato, int actualNoOfSeats)
        {
            Dato = dato;
            ActualNoOfSeats = actualNoOfSeats;
        }
    }
}
