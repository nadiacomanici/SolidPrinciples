namespace SingleResponsability_Students_Penta.Logic
{
    public class Student
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double AdmissionMark { get; private set; }

        public Student(int id, string firstName, string lastName, double admissionMark)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdmissionMark = admissionMark;
        }
    }
}
