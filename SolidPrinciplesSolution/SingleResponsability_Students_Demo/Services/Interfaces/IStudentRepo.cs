using SingleResponsability_Students_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Students_Demo.Services.Interfaces
{
    public interface IStudentRepo
    {
        List<Student> LoadStudentsFromFile();

        Student AdmitStudent(string firstName, string lastName, double admissionMark);

        bool DeleteStudentById(int id);
    }
}
