using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "George", Age = 19, PhoneNumbers = new List<string>() { "380934578907", "380944678900", "380504578903" } });
            people.Add(new Person() { Name = "Taras", Age = 20, PhoneNumbers = new List<string>() { "380934578922", "380944678907", "38056878999" } });
            people.Add(new Person() { Name = "Michael", Age = 26, PhoneNumbers = new List<string>() { "380934459117", "380345678962", "380504578707" } });
            people.Add(new Person() { Name = "Anna", Age = 18, PhoneNumbers = new List<string>() { "380834575901", "380944678945", "380504509907" } });
            people.Add(new Person() { Name = "Tonny", Age = 24, PhoneNumbers = new List<string>() { "380934578955", "380944678907", "380508878907" } });
            people.Add(new Person() { Name = "Mahmut", Age = 30, PhoneNumbers = new List<string>() { "380934578967", "380900678954", "380784578966" } });

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, { person.Age}");
            }


            Console.ReadLine();
        }
    }
}
