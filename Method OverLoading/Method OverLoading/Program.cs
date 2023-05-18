using System;

namespace MethodOverLoading
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);
            Console.WriteLine("Name: " + person.Name + ", Age: " + person.Age);
        }
    }
}