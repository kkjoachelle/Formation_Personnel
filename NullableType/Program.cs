using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------------------------------------------
            /*
             DateTime? date = null;
            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue : " + date.HasValue);
            
            //Console.WriteLine("  "+date.Value);*/
            //---------------------------------------------------------------------
            /*
            DateTime? date = null; 
            DateTime date2;
           if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;
              
             Console.WriteLine("My date is "+  date2);
             */
            //---------------------------------------------------------------------
            // ou
            //---------------------------------------------------------------------
            /*
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;
            Console.WriteLine("My date is "+  date2);
            */
            //---------------------------------------------------------------------
            // ou
            //---------------------------------------------------------------------

            /*
            DateTime? date = null;
            DateTime date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine("My date is :  " + date2);
            */

            //---------------------------------------------------------------------
            // ou
            //---------------------------------------------------------------------

            DateTime? date = null;
            DateTime date2 = date  ?? date.GetValueOrDefault() ;
            Console.WriteLine("My date is :  " + date2);

            Console.ReadKey();
        }
    }
}
