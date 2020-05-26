using EZurnals.Logic.EZurnalsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZurnals.Logic
{
    public class StudentManager
    {
        public static List<StudentsDb> GetAll()
        {
            using(var db = new EZurnalsContext())
            {
                return db.StudentsDb.OrderBy(u => u.Surname).ThenBy(u =>u.Name).ToList();
            }
        }
        public static StudentsDb GetGrades(int oStudentId)
        {
            //katra studenta atzīmju saraksts
            using(var db = new EZurnalsContext())
            {
                return db.StudentsDb.Find(oStudentId);
            }
        }
        public static void Create(string name, string surname, string klase, string birthYear)
        {
            using(var db = new EZurnalsContext())
            {
                db.StudentsDb.Add(new StudentsDb()
                {
                    Name = name,
                    Surname = surname,
                    Klase = klase,
                    BirthYear = birthYear,
                });
                db.SaveChanges();
            }
        }
    }
}
