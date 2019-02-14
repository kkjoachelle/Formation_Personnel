using System;

namespace Reference
{
    public class MyClassRef
    {
        public void MyMethodRef(ref int a1)
        {
            a1 += 2;
            Console.WriteLine("Voici le resultat : " + a1);
        }
    }
}
