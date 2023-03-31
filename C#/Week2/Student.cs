namespace Delegates
{
    public class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

        public Student(string name, string department, int age, int id)
        {
            Name = name; Department = department; Age = age; Id = id;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Department} {Id} ";
        }


    }
}
