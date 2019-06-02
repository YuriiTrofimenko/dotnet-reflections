using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsDemo
{
    class Person
    {
        private int id;
        public string Name { get; set; }

        public Person()
        { }
        public Person(int _id, string _name)
        {
            id = _id;
            Name = _name;
        }

        public void SayHello() {
            Console.WriteLine(Name + ": Hello!");
        }

        public void Say(string _phrase)
        {
            Console.WriteLine($"{Name}: {_phrase}!");
        }

        /* public void Say(int _number)
        {
            Console.WriteLine($"{Name}: {_number}!");
        } */

        public void Say(int[] _number)
        {
            Console.WriteLine($"{Name}: {_number[0]}!");
        }

        public override string ToString()
        {
            return $"Person: id = {id}, Name = {Name}";
        }
    }
}
