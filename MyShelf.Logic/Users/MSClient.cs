using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShelf.Logic.Interfaces;
using MyShelf.Logic.Models;

namespace MyShelf.Logic.Users
{
    public class MSClient : User
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public List<BookCatalogue>? Catalogues { get; set; } = new List<BookCatalogue>();
        public PersonalLibrary? PersonalLibrary { get; set; }
        public MSClient(int id, string name, string username, string password, string address, string phoneNumber, string email) : base(id, name,username, password)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            DateJoined = DateTime.Now;
        }
    }
}
