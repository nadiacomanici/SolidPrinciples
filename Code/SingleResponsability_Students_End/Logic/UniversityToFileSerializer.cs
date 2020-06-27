using System.Globalization;
using System.IO;

namespace SingleResponsability_Students_End.Logic
{
    public class UniversityToFileSerializer
    {
        public void Serialize(University university, string fullFilePath)
        {
            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in university.Students)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
