
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_Tic_Management_System.Models
{
    public class Mark
    {
        public int MarkId { get; set; }      // Primary key
        public int StudentId { get; set; }   // Foreign key to Student
        public int ExamId { get; set; }      // Foreign key to Exam
        public int Score { get; set; }       // The actual mark or score
    }
}
