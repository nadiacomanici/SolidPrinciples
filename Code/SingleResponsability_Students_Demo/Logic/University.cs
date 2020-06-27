using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsability_Students_Demo.Logic
{
    public class University
    {
        private int nextId = 1;
        private List<Student> admittedStudents;
        private string fullFilePath;
        private UniversityReader reader;
        private UniversityWriter writer;

        public IReadOnlyList<Student> Students
        {
            get
            {
                return admittedStudents.AsReadOnly();
            }
        }

        public University(string fullFilePath, UniversityReader reader, UniversityWriter writer)
        {
            this.fullFilePath = fullFilePath;
            this.reader = reader;
            this.writer = writer;
            admittedStudents = reader.ReadStudentsFromFile(nextId, fullFilePath);
        }

        #region Students list operations

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            Student student = new Student(nextId++, firstName, lastName, admissionMark);
            admittedStudents.Add(student);

            writer.SaveStudentsToFile(admittedStudents, fullFilePath);
            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);
                writer.SaveStudentsToFile(admittedStudents, fullFilePath);
                return true;
            }
            return false;
        }
        #endregion
    }
}
