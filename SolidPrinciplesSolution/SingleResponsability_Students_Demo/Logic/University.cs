using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SingleResponsability_Students_Demo.Logic
{
    public class University
    {
        private int nextId = 1;
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
            LoadStudentsFromFile();
        }

        #region Students list operations

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            Student student = new Student(nextId++, firstName, lastName, admissionMark);
            admittedStudents.Add(student);
            SaveStudentsToFile();
            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);
                SaveStudentsToFile();
                return true;
            }
            return false;
        }
        #endregion

        #region Statistics

        public double MinAdmissionMark
        {
            get { return admittedStudents.Min(student => student.AdmissionMark); }
        }

        public double MaxAdmissionMark
        {
            get { return admittedStudents.Max(student => student.AdmissionMark); }
        }

        #endregion

        #region Serialization
        private string GetFullFilePath()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "University");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return Path.Combine(folder, "university.csv");
        }

        private void LoadStudentsFromFile()
        {
            string fullFilePath = GetFullFilePath();
            admittedStudents = new List<Student>();
            if (File.Exists(fullFilePath))
            {
                using (var writer = new StreamReader(fullFilePath))
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

        public void SaveStudentsToFile()
        {
            string fullFilePath = GetFullFilePath();

            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in admittedStudents)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }

        #endregion
    }
}
