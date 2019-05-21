using System.Linq;

namespace SingleResponsability_Students_End.Logic
{
    public class UniversityStatistics
    {
        private University university;

        public UniversityStatistics(University university)
        {
            this.university = university;
        }

        public double MinAdmissionMark
        {
            get { return university.Students.Min(student => student.AdmissionMark); }
        }

        public double MaxAdmissionMark
        {
            get { return university.Students.Max(student => student.AdmissionMark); }
        }
    }
}
