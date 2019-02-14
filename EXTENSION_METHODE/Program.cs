using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EXTENSION_METHODE
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = ("This is supposed to be a very long long post blah , blah blah ..");
            var shortenPost = post.Shorten(7);

            Console.WriteLine(shortenPost);

            Console.ReadKey();
        }
    }
}
