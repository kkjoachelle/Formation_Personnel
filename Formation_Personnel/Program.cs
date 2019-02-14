using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation_Personnel
{
    class Program
    {
        static void Main(string[] args)
        {
           // Person person = new Person();
            var person = new Person();
            person.Name = "koudio joachim";
            person.Introduction("KOFFI");

            //Person.Perse("kko");

            Console.ReadKey();
            
        }
    }
    //////////////////////();
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public float Height { get; set; }
        public byte Weight { get; set; }
        //constructors
        public Person(string name, byte age, float height, byte weight)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }
        //
        public Person()
        {

        }
        public void Introduction(string val)
        {
            Console.WriteLine("ho {0}, my name is {1}",val, Name);
        }
       
        //public static Person Perse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;
        //    return person;
        //}
        public void Walk()
        {

        }
        //
        public void Tlk()
        {
        }
        //
        public void Eat()
        {
        }
        //
        public void Sleep()
        {
        }

    }
}
