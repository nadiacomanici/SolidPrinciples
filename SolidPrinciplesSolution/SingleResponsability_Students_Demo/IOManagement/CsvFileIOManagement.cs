using SingleResponsability_Students_Demo.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SingleResponsability_Students_Demo.IOManagement
{
    public class CsvFileIOManagement
    {
        private const string folderName = "University";
        private const string fileName = "university.csv";

        public void SaveStudentsToFile(List<Student> admittedStudents)
        {
            string fullFilePath = GetFullFilePath();

            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var student in admittedStudents)
                {
                    writer.WriteLine($"{student.Id},{student.FirstName},{student.LastName},{student.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }

        public string GetFullFilePath()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), folderName);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return Path.Combine(folder, fileName);
        }
    }
}