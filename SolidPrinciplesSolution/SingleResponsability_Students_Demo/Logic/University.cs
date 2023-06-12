using SingleResponsability_Students_Demo.IOManagement;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SingleResponsability_Students_Demo.Logic
{
    public class University
    {
        private CsvFileIOManagement _csvFileIOManagement;

        private int nextId = 1;
        private List<Student> admittedStudents;

        public IReadOnlyList<Student> Students
        {
            get
            {
                return admittedStudents.AsReadOnly();
            }
        }

        public University(CsvFileIOManagement csvFileIOManagement)
        {
            _csvFileIOManagement = csvFileIOManagement;
            admittedStudents = new List<Student>();
            LoadStudentsFromFile();
        }

        #region Students list operations

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            Student student = new Student(nextId++, firstName, lastName, admissionMark);
            admittedStudents.Add(student);
            _csvFileIOManagement.SaveStudentsToFile(admittedStudents);
            //SaveStudentsToFile();
            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);
                _csvFileIOManagement.SaveStudentsToFile(admittedStudents);
                //SaveStudentsToFile();
                return true;
            }
            return false;
        }

        #endregion Students list operations

        #region Statistics

        public double MinAdmissionMark
        {
            get { return admittedStudents.Min(student => student.AdmissionMark); }
        }

        public double MaxAdmissionMark
        {
            get { return admittedStudents.Max(student => student.AdmissionMark); }
        }

        #endregion Statistics

        #region Serialization

        private void LoadStudentsFromFile()
        {
            // new instance of CsvFileIOManagement

            admittedStudents = new List<Student>();
            if (File.Exists(_csvFileIOManagement.GetFullFilePath()))
            {
                using (var writer = new StreamReader(_csvFileIOManagement.GetFullFilePath()))
                {
                    string line = writer.ReadLine();
                    while (line != null)
                    {
                        var chunks = line.Split(',');

                        int id = int.Parse(chunks[0]);
                        string firstName = chunks[1];
                        string lastName = chunks[2];
                        double mark = double.Parse(chunks[3], CultureInfo.InvariantCulture);

                        admittedStudents.Add(new Student(id, firstName, lastName, mark));
                        line = writer.ReadLine();
                    }
                }
            }
            if (admittedStudents.Count > 0)
            {
                nextId = admittedStudents.Max(s => s.Id) + 1;
            }
            else
            {
                nextId = 1;
            }
        }

        #endregion Serialization
    }
}