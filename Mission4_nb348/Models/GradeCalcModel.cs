using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_nb348.Models
{
    public class GradeCalcModel
    {
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")] // Data Validation
        public int Assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public int Quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public int Group { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public int Intex { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public int Exam { get; set; }
    }
}
