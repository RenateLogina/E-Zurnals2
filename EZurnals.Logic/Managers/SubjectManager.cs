using EZurnals.Logic.EZurnalsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZurnals.Logic
{
    public class SubjectManager
    {
        public static List<SubjectsDb> GetAll()
        {
            using(var db = new EZurnalsContext())
            {
                return db.SubjectsDb.OrderBy(u => u.Name).ToList();
            }
        }
        public static void Create(string name)//kategorijas saglabāšana
        {
            using (var db = new EZurnalsContext())
            {
                db.SubjectsDb.Add(new SubjectsDb()
                {
                    Name = name,
                });
                db.SaveChanges();
            }
        }
    }
}
