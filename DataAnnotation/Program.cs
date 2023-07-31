using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation
{
    class Person
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Range(10, 100, ErrorMessage = "Age Must be between 18 and 100.")]
        public int Age { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 12;

            Console.WriteLine(person.Age);
            Console.ReadLine();
        }   
    }
}
