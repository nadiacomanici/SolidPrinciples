using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SingleResponsability_Students_Penta.Logic
{
    public class UniversityRepository
    {
        public void Save(University university)
        {
            SaveStudents(university.Students);
        }

        public University Load()
        {
            return new University(LoadStudents());
        }

        private void SaveStudents(List<Student> students)
        {
            string fullFilePath = FileHelper.GetFullFilePath("University", "university.csv");

            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in students)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }

        private List<Student> LoadStudents()
        {
            string fullFilePath = FileHelper.GetFullFilePath("University", "university.csv");
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
    }

}
