using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
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
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "George", Age = 19, PhoneNumbers = new List<string>() { "380934578907", "380944678900", "380504578903" } });
            people.Add(new Person() { Name = "Taras", Age = 20, PhoneNumbers = new List<string>() { "380934578922", "380944678907", "380568789990" } });
            people.Add(new Person() { Name = "Michael", Age = 26, PhoneNumbers = new List<string>() { "380934459117", "380345678962", "380504578707" } });
            people.Add(new Person() { Name = "Anna", Age = 18, PhoneNumbers = new List<string>() { "380834575901", "380944678945", "380504509907" } });
            people.Add(new Person() { Name = "Tonny", Age = 24, PhoneNumbers = new List<string>() { "380934578955", "380944678907", "380508878907" } });
            people.Add(new Person() { Name = "Mahmut", Age = 30, PhoneNumbers = new List<string>() { "380934578967", "380900678954", "380784578966" } });

            List<Person> somepeople = new List<Person>();
            somepeople.Add(new Person() { Name = "Angela", Age = 25, PhoneNumbers = new List<string>() { "380784578950", "380955578955", "380508878808" } });
            somepeople.Add(new Person() { Name = "Sara", Age = 22, PhoneNumbers = new List<string>() { "380924578966", "380900678474", "380774570933" } });

            people.AddRange(somepeople);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}:");
                foreach (string number in person.PhoneNumbers)
                Console.WriteLine($" {number} ");
            }


            Console.ReadLine();
        }
    }
}
