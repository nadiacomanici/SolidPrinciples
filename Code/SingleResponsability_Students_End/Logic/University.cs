using System.Collections.Generic;
using System.Linq;

namespace SingleResponsability_Students_End.Logic
{
    public class University
    {
        private int nextId;
        private List<Student> admittedStudents;

        public IReadOnlyList<Student> Students
        {
            get
            {
                return admittedStudents.AsReadOnly();
            }
        }
        public University()
        {
            admittedStudents = new List<Student>();
            nextId = 1;
        }

        public University(List<Student> admittedStudents)
        {
            this.admittedStudents = admittedStudents;
            nextId = admittedStudents.Count > 0 ? admittedStudents.Max(s => s.Id) + 1 : 1;
        }

        #region Students list operations

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            Student student = new Student(nextId++, firstName, lastName, admissionMark);
            admittedStudents.Add(student);
            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);
                return true;
            }
            return false;
        }
        #endregion
    }
}
