using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.Logic.Exceptions
{
    public class BookHasBeenCheckedOutException : Exception
    {
        public readonly string BHBCOMessage = "Book Has Been Checked Out, Please Check Availability Before Proceeding";
        public BookHasBeenCheckedOutException() { }
    }
}
