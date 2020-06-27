namespace OpenClosedPrinciple_Museum_Begin.Logic
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
