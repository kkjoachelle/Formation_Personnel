using System;
using System.Linq;

namespace EXTENSION_METHODE
{
    public static class StringExtensions 
    {
        public static string Shorten(this String str ,int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords shouldbe greated than or equal to 0 )");

            if (numberOfWords == 0)
                return " ";

                var words = str.Split(' ');

            if (words.Length <= numberOfWords)

                return str;

           return string.Join(" ", words.Take(numberOfWords))+ "...";
        }
    }
}
