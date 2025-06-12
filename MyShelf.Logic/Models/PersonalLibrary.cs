using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShelf.Logic.Users;
using MyShelf.Logic.Exceptions;

namespace MyShelf.Logic.Models
{
    public class PersonalLibrary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCatalogue>? Catalogues { get; set; } = new List<BookCatalogue>();
        public List<MSBorrower>? Borrowers { get; set; } = new List<MSBorrower>();
        public PersonalLibrary(int id, string name, BookCatalogue initialCatalogue)
        {
            Id = id;
            Name = name;
            Catalogues.Add(initialCatalogue);
        }
    }
}
