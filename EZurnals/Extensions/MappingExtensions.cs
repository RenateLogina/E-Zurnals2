using EZurnals.Logic;
using EZurnals.Logic.EZurnalsDB;
using EZurnals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZurnals
{
    public static class MappingExtensions
    {
        public static SubjectModel ToModel(this SubjectsDb sub)
        {
            return new SubjectModel()
            {
                Name = sub.Name,
            };
        }
        public static StudentModel ToModel(this StudentsDb stu)
        {
            return new StudentModel()
            {
                OStudentId = stu.Id,
                Name = stu.Name,
                Surname = stu.Surname,
                BirthYear = stu.BirthYear,
                Klase = stu.Klase,
            };
        }
        public static GradeModel ToModel(this GradesDb gra)
        {
            return new GradeModel()
            {
                StudentName = StudentManager.GetAll().FirstOrDefault(c => c.Id == gra.StudentId).Name,
                StudentSurname = StudentManager.GetAll().FirstOrDefault(c => c.Id == gra.StudentId).Surname,
                SubjectName = SubjectManager.GetAll().FirstOrDefault(c => c.Id == gra.SubjectId).Name,
                OGradeId = gra.Id,
                Grade = gra.Grade,
                Comment = gra.Comment,
                Subject = new SubjectModel()
                {
                    OSubjectId = gra.SubjectId,
                },
                Student = new StudentModel()
                {
                    OStudentId = gra.StudentId,
                },
            };
        }
    }
}
