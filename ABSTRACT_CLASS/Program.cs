using System;

namespace ABSTRACT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            //on ne peut pas instancier une classe abstraitte
           // var sharpe = new Sharpe();
          //-----------------------------------------------//
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
