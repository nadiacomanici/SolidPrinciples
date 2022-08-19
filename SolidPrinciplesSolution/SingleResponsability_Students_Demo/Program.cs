using System;
using System.IO;
using SingleResponsability_Students_Demo.Logic;

namespace SingleResponsability_Students_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            university.AdmitStudent("Nadia", "Comanici", 9.89);
            university.AdmitStudent("Maria", "Popoviciu", 6.01);
            university.AdmitStudent("Ion", "Ionescu", 7);
            university.AdmitStudent("Vasile", "Pop", 8.86);

            Console.WriteLine($"University has {university.Students.Count} admitted students.");
            Console.WriteLine($"Cea mai mica nota de admitere este: {university.MinAdmissionMark}");
            Console.WriteLine($"Cea mai mare nota de admitere este: {university.MaxAdmissionMark}");
        }
    }
}
