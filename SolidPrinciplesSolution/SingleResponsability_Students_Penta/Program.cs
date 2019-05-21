using System;
using SingleResponsability_Students_Penta.Logic;

namespace SingleResponsability_Students_Penta
{
    class Program
    {
        static void Main(string[] args)
        {
            var universityRepo = new UniversityRepository();
            University university = universityRepo.Load();

            university.AdmitStudent("Nadia", "Comanici", 9.89);
            university.AdmitStudent("Maria", "Popoviciu", 6.01);
            university.AdmitStudent("Ion", "Ionescu", 7);
            university.AdmitStudent("Vasile", "Pop", 8.86);

            Console.WriteLine($"University has {university.Students.Count} admitted students.");

            var statistics = new UniversityStatistics(university);
            Console.WriteLine($"Cea mai mica nota de admitere este: {statistics.MinAdmissionMark}");
            Console.WriteLine($"Cea mai mare nota de admitere este: {statistics.MaxAdmissionMark}");
        }
    }
}
