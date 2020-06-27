using System;
using System.IO;
using SingleResponsability_Students_Demo.Logic;

namespace SingleResponsability_Students_Demo
{
    class Program
    {
        private static string GetFullFilePath()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "University");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return Path.Combine(folder, "university.csv");
        }

        static void Main(string[] args)
        {
            var studentsStatistics = new StudentsStatistics();

            University university = new University(GetFullFilePath(), new UniversityReader(), new UniversityWriter());

            university.AdmitStudent("Nadia", "Comanici", 9.89);
            university.AdmitStudent("Maria", "Popoviciu", 6.01);
            university.AdmitStudent("Ion", "Ionescu", 7);
            university.AdmitStudent("Vasile", "Pop", 8.86);

            Console.WriteLine($"University has {university.Students.Count} admitted students.");
            Console.WriteLine($"Cea mai mica nota de admitere este: {studentsStatistics.MinAdmissionMark(university.Students)}");
            Console.WriteLine($"Cea mai mare nota de admitere este: {studentsStatistics.MaxAdmissionMark(university.Students)}");
        }
    }
}
