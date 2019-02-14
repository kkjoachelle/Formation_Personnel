using System;

namespace DELEGATE
{
    public class PhotoFilters
    {
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("APPLY CONTRasT");
        }

        public void ApplyBirghtness(Photo photo)
        {
            Console.WriteLine("APPLY Birghtness");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("APPLY Resize photo");
        }
    }
}