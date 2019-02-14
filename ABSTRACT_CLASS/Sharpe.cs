using System;
namespace ABSTRACT_CLASS
{
    public abstract class Sharpe
    {
        public int Weidth { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy Sharp to cliboard");
        }


    }
}
