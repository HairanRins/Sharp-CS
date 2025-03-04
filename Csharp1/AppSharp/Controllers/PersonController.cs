using AppSharp.Models;

namespace AppSharp.Controllers;

public class PersonController
{
    public Person CreerPersonne(string name, int age)
    {
        return new Person(name, age);
    }
}