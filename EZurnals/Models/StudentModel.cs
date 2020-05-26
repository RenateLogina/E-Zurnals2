using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EZurnals.Models
{
    public class StudentModel
    {
        public int OStudentId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        [Display(Name = "Vārds: ")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        [Display(Name = "Uzvārds: ")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(4)]
        [Display(Name = "Dzimšanas gads: ")]
        public string BirthYear { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(5)]
        [Display(Name = "Klase: ")]
        public string Klase { get; set; }

        public decimal AverageGrade { get; set; }
        public List<GradeModel> Grades { get; set; }
    }
}
