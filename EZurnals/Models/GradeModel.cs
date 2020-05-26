using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EZurnals.Models
{
    public class GradeModel
    {
        public int OGradeId { get; set; }


        [Required]
        [Display(Name = "Vērtējums: ")]
        public decimal Grade { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Apraksts: ")]
        public string Comment { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Display(Name = "Priekšmets: ")]
        public string SubjectName { get; set; }

        public SubjectModel Subject { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Display(Name = "Skolēna uzvārds: ")]
        public string StudentSurname { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Display(Name = "Skolēna vārds: ")]
        public string StudentName { get; set; }

        public StudentModel Student { get; set; }
    }
}
