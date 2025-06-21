using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_Tic_Management_System.Data
{
    internal class Timetable
    {
        public int TimetableId { get; set; }
        public int SubjectId { get; set; }
        public string TimeSlot { get; set; }
        public int RoomId { get; set; }
   
    }
}
