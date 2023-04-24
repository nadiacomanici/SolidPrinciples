using SingleResponsability_Students_Demo.Entities;
using SingleResponsability_Students_Demo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Students_Demo.Services
{
    public class StudentRepo : IStudentRepo
    {
        private readonly IFileService _fileService;

        public StudentRepo(IFileService fileService)
        {
            _fileService = fileService;
        }

        public List<Student> LoadStudentsFromFile()
        {
            string fullFilePath = _fileService.GetFullFilePath();
            var admittedStudents = new List<Student>();
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

            return admittedStudents;
        }

        public Student AdmitStudent(string firstName, string lastName, double admissionMark)
        {
            var nextId = GetNextId();
            Student student = new Student(nextId, firstName, lastName, admissionMark);
            AppendStudentToFile(student);
            return student;
        }

        public bool DeleteStudentById(int id)
        {
            var admittedStudents = LoadStudentsFromFile();
            var student = admittedStudents.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                admittedStudents.Remove(student);
                SaveStudentsToFile(admittedStudents);
                return true;
            }
            return false;
        }

        private void SaveStudentsToFile(List<Student> admittedStudents)
        {
            string fullFilePath = _fileService.GetFullFilePath();

            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in admittedStudents)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }

        private void AppendStudentToFile(Student student)
        {
            string fullFilePath = _fileService.GetFullFilePath();

            using (var writer = new StreamWriter(fullFilePath, true))
            {
                writer.WriteLine($"{student.Id},{student.FirstName},{student.LastName},{student.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
            }
        }

        private int GetNextId()
        {
            var nextId = 1;

            var admittedStudents = LoadStudentsFromFile();

            if (admittedStudents.Count > 0)
            {
                nextId = admittedStudents.Max(s => s.Id) + 1;
            }

            return nextId;
        }
    }
}
