using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EZurnals.Models
{
    public class SubjectModel
    {
        public int OSubjectId { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [StringLength(150)]
        [Display(Name = "Mācību priekšmets: ")]
        public string Name { get; set; }
    }
}
