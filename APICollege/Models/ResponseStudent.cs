using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICollege.Models
{
    public class ResponseStudent
    {
        public ResponseStudent(Student student)
        {
            StudentId = student.Id_Student;
            StudentName = student.Name;
            StudentSurname = student.Surname;
            StudentBirthday = Convert.ToString(student.Birthday);
            StudentGender = student.Gender;
            StudentPhone = student.Tel;
            StudentEmail = student.Mail;
            StudentClass = student.Class;

        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentBirthday { get; set; }
        public string StudentGender { get; set; }
        public int StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public string StudentClass { get; set; }
    }
}