using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.Logic.Models
{
    public class BookCatalogue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int MinReqBooks { get; set; } = 3;
        public List<Book>? Books { get; set; } = new List<Book>();
        public BookCatalogue(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public bool CheckCatalgueMeetsRequirements()
        {
            if (Books.Count >= MinReqBooks)
            {
                return true;
            }
            return false;
        }
    }
}
