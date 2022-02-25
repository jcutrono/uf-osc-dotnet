using System;
using System.Collections.Generic;
using System.Linq;
using static cli.Program;

namespace cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Person, string> prettyPrint = x => x + Environment.NewLine;

            var people = new List<Person> {
                new Person { FirstName = "Rebecca", LastName = "Smith", Major = Major.CompSci },
                new Person { FirstName = "Jay", LastName = "Smith", Major = Major.CompSci },
                new Person { FirstName = "Susan", LastName = "Smith", Major = Major.CompSci },
                new Person { FirstName = "Linda", LastName = "Smith", Major = Major.CompSci },
            };

            Console.WriteLine(CountCompSci(people));
            Console.WriteLine(people.Count(x => x.Major == Major.CompSci));
        }

        public static int CountCompSci(IEnumerable<Person> people)
        {
            var count = 0;
            foreach (var person in people)
            {
                if (person.Major == Major.CompSci)
                {
                    count++;
                }
            }
            return count;
        }       
    }

    public enum Major{
            CompSci,
            Business,
            Marketing
        }

    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }

        public Major Major { get; set; }

        public override string ToString()
        {
            return $"Hello my name is {FirstName} {LastName}";
        }
    }

}
