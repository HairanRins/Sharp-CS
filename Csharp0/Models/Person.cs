namespace Csharp0.Models 
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Nom : {Name}, Âge : {Age}";
        }
    }
}