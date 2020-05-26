using System;
using System.Collections.Generic;

namespace EZurnals.Logic.EZurnalsDB
{
    public partial class GradesDb
    {
        public int Id { get; set; }
        public decimal Grade { get; set; }
        public string Comment { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
    }
}
