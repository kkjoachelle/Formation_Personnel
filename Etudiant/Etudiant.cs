using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant
{
    public class Etudiant
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public float Height { get; set; }
        public byte Weight { get; set; }
        //constructors
        //public Etudiant(string name = " ", int age = "", float height =" " ,byte weight = " ")
        //{
        //    //this.Name = name;
        //    //this.Age = age;
        //    //this.Height = height;
        //    //this.Weight = weight;
        //}
        public int add(int[] tab)
        {
            int som = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                som = som + tab[i];
            }
            return som;
        }
    }
}
