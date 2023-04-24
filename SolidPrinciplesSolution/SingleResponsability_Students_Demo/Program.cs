using System;
using Microsoft.Extensions.DependencyInjection;
using SingleResponsability_Students_Demo.Entities;
using SingleResponsability_Students_Demo.Services;
using SingleResponsability_Students_Demo.Services.Interfaces;

namespace SingleResponsability_Students_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFileService, FileService>()
                .AddSingleton<IStudentRepo, StudentRepo>()
            .BuildServiceProvider();

            // TODO: move admit student to a UniversityService
            var studentRepo = serviceProvider.GetService<IStudentRepo>();
            studentRepo.AdmitStudent("Nadia", "Comanici", 9.89);
            studentRepo.AdmitStudent("Maria", "Popoviciu", 6.01);
            studentRepo.AdmitStudent("Ion", "Ionescu", 7);
            studentRepo.AdmitStudent("Vasile", "Pop", 8.86);
            
            var admittedStudents = studentRepo.LoadStudentsFromFile();

            University university = new University(admittedStudents);

            // TODO: not sure if we need to move Min and Max to a statistics service as this might be properties of the University.
            Console.WriteLine($"University has {university.Students.Count} admitted students.");
            Console.WriteLine($"Cea mai mica nota de admitere este: {university.MinAdmissionMark}");
            Console.WriteLine($"Cea mai mare nota de admitere este: {university.MaxAdmissionMark}");

            Console.ReadKey();
        }
    }
}
