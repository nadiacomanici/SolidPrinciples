using System;
using System.IO;
using SingleResponsability_Students_End.Logic;

namespace SingleResponsability_Students_End
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
            var deserializer = new UniversityFromFileDeserializer();
            University university = deserializer.Deserialize(GetFullFilePath());

            university.AdmitStudent("Nadia", "Comanici", 9.89);
            university.AdmitStudent("Maria", "Popoviciu", 6.01);
            university.AdmitStudent("Ion", "Ionescu", 7);
            university.AdmitStudent("Vasile", "Pop", 8.86);

            var serializer = new UniversityToFileSerializer();
            serializer.Serialize(university, GetFullFilePath());

            Console.WriteLine($"University has {university.Students.Count} admitted students.");

            var statistics = new UniversityStatistics(university);
            Console.WriteLine($"Cea mai mica nota de admitere este: {statistics.MinAdmissionMark}");
            Console.WriteLine($"Cea mai mare nota de admitere este: {statistics.MaxAdmissionMark}");
        }
    }
}
