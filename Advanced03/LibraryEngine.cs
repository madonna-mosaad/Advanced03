using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList ,BookFunctionsPointer fPtr)
        {
            if (bList is not null && fPtr is not null)
            {
                foreach (Book B in bList)
                    Console.WriteLine(fPtr(B));
            }
        }
    }
}
