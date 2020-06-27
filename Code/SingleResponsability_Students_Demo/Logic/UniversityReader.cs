using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SingleResponsability_Students_Demo.Logic
{
    public class UniversityReader
    {
        public List<Student> ReadStudentsFromFile(int nextId, string fullFilePath)
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
            if (admittedStudents.Count > 0)
            {
                nextId = admittedStudents.Max(s => s.Id) + 1;
            }
            else
            {
                nextId = 1;
            }
            return admittedStudents;
        }
    }
}
