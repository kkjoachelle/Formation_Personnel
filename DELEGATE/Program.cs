using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            //
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBirghtness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;

            processor.Processor("photo.jpg", filterHandler);

            
            Console.ReadKey();
        }
    }
}
