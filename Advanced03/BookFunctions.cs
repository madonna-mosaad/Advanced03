using Advanced03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03
{
    internal class BookFunctions
    {

        public static string GetTitle(Book B)
        {
            return B?.Title ?? " not found ";
        }
        public static string Getauthors(Book B)
        {
            string x = "";
            if (B != null)
            {
                foreach (string item in B.Authors)
                {
                    x += item;
                    x += ", ";
                }
            } 
             
            return x;
        }
        public static string GetPrice(Book B)
        {
            return $"{B?.Price??0}";
        }
    }
}
