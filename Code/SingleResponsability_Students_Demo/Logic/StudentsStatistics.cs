using System.Collections.Generic;
using System.Linq;

namespace SingleResponsability_Students_Demo.Logic
{
    public class StudentsStatistics
    {
        public double MinAdmissionMark(IEnumerable<Student> students)
        {
            return students.Min(student => student.AdmissionMark);
        }

        public double MaxAdmissionMark(IEnumerable<Student> students)
        {
            return students.Max(student => student.AdmissionMark);
        }
    }
}
