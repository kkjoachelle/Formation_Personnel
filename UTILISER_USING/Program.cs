using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILISER_USING
{
    class Program
    {
        static void Main(string[] args)
        {
            /////var rectangle = new Rectangl( );
            ///
            Rectangle rect = new Rectangle();
            var re = new Rectangle();
            
            


            try
            {
                using ()
                {
                    rect.Resultat();

                }

            }
            catch (Exception)
            {

                Console.WriteLine("hoooooooooop");
            }


            Console.ReadKey();
        }
    }
}
