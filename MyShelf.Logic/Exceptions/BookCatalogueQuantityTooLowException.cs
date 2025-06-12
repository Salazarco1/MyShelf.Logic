using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.Logic.Exceptions
{
    public class BookCatalogueQuantityTooLowException: Exception
    {
        public readonly string BCQTLMessage = "Book Catalogue Quantity Too Low, Please Add More Books Before Proceeding";
        public BookCatalogueQuantityTooLowException() { }
    }
}
