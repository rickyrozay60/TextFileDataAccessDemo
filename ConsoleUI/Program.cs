using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\Richard\source\repos\test.txt";
                     

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.URL = entries[2];

                people.Add(newPerson);
            }

            Console.WriteLine("Read from a text file");
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }: { person.URL }");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", URL = "www.msn.com" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{ person.FirstName }, { person.LastName }, { person.URL }");
            }

            Console.WriteLine("Writing to text file");
            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");
            Console.ReadLine();  
        }
    }
}
