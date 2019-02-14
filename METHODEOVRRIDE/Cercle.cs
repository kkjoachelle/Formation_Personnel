using System;

namespace METHODEOVRRIDE
{
    public class Cercle : Shape
    {
        public int Idcer { get; set; }
        public string Rayon { get; set; }

        public override void AfficherNombre()
        {
            Console.WriteLine("Le nombre de Sharp est");
        }

    }
}
