using System;

namespace METHODEOVRRIDE
{
    public class Shape
    {
        public int Id { get; set; }
        public string NameShap { get; set; }
        public int Nbre { get; set; }

        public virtual void AfficherNombre()
        {
            Console.WriteLine("Le nombre de Sharp est");
        }
        //Console.WriteLine("Hello World!");
    }
}
