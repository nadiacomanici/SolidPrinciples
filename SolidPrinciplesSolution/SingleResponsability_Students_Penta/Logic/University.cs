using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SingleResponsability_Students_Penta.Logic
{
    public class University
    {
        private int nextId = 1;
        private List<Student> admittedStudents;

        public List<Student> Students { get { return admittedStudents; } }  

        public University()
        {
            admittedStudents = new List<Student>();
        }

        public University(List<Student> students)
        {
            admittedStudents = students;
            nextId = admittedStudents.Max(s => s.Id) + 1;
        }

        #region Students list operations

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            Student student = new Student(nextId++, firstName, lastName, admissionMark);
            admittedStudents.Add(student);

            var universityRepo = new UniversityRepository();
            universityRepo.Save(this);

            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);

                var universityRepo = new UniversityRepository();
                universityRepo.Save(this);

                return true;
            }
            return false;
        }
        #endregion
    }
}
