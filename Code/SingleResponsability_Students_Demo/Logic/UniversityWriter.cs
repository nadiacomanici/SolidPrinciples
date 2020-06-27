using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SingleResponsability_Students_Demo.Logic
{
    public class UniversityWriter
    {
        public void SaveStudentsToFile(List<Student> admittedStudents, string fullFilePath)
        {
            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in admittedStudents)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
