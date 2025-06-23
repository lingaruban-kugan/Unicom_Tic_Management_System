using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_Tic_Management_System.Data
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get;set; }
        public string Date { get; set; }
        
    }
}
