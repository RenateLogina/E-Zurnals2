using System;
using System.Collections.Generic;

namespace EZurnals.Logic.EZurnalsDB
{
    public partial class StudentsDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthYear { get; set; }
        public string Klase { get; set; }
    }
}
