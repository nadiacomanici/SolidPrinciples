using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Students_Penta.Logic
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
