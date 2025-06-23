using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_Tic_Management_System.Data
{
    public class Timetable
    {
        public int TimetableId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }  // Display Subject Name
        public string TimeSlot { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }  // Display Room Name
    }

}
