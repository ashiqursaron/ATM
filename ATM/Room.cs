using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_96
{
    class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            code = classCode;
            seats = numberOfSeats;
        }
    }
}

