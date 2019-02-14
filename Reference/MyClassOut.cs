using System;

namespace Reference
{
    public class MyClassOut
    {
        public void MyMethodOut(out int r)
        {
            r = 2;
            Console.WriteLine("Voici le resultat : " + r);
        }
    }
}
