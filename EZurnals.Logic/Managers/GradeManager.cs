using EZurnals.Logic.EZurnalsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZurnals.Logic
{
    public class GradeManager
    {
        public static List<GradesDb> GetAll()
        {
            using (var db = new EZurnalsContext())
            {
                return db.GradesDb.OrderByDescending(g => g.Grade).ToList();
            }
        }

        public static List<GradesDb> GetSubjectGrades(string name)
        {
            using(var db = new EZurnalsContext())
            {
                var subject = db.SubjectsDb.FirstOrDefault(c => c.Name == name);
                return db.GradesDb.Where(i => i.SubjectId == subject.Id).ToList();
            }
        }

        //varbūt arī Tabulā jāpārsauc Id kaut kā specifiskāk?
        public static void Create(decimal grade, string comment, int oStudentId, int oSubjectId)
        {
            using (var db = new EZurnalsContext())
            {
                db.GradesDb.Add(new GradesDb()
                {
                    Grade = grade,
                    Comment = comment,
                    StudentId = oStudentId,
                    SubjectId = oSubjectId,
                });
                db.SaveChanges();
            }
        }

    }
}
