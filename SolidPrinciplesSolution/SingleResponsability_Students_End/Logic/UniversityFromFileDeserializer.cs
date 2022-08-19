using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SingleResponsability_Students_End.Logic
{
    public class UniversityFromFileDeserializer
    {
        public University Deserialize(string fullFilePath)
        {
            var admittedStudents = new List<Student>();

            if (File.Exists(fullFilePath))
            {
                using (var writer = new StreamReader(fullFilePath))
                {
                    string line = writer.ReadLine();
                    while (line != null)
                    {
                        var chunks = line.Split(',');

                        int id = int.Parse(chunks[0]);
                        string firstName = chunks[1];
                        string lastName = chunks[2];
                        double mark = double.Parse(chunks[3], CultureInfo.InvariantCulture);

                        admittedStudents.Add(new Student(id, firstName, lastName, mark));
                        line = writer.ReadLine();
                    }
                }
            }

            return new University(admittedStudents);
        }
    }
}
