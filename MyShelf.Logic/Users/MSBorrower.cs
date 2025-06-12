using MyShelf.Logic.Exceptions;
using MyShelf.Logic.Interfaces;
using MyShelf.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.Logic.Users
{
    public class MSBorrower : User
    {
        public string Nickname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public bool HasOverdueBooks { get; set; } = false;
        public decimal OutstandingFees { get; set; } = 0.0m;
        public List<Book>? CheckedOutBooks { get; set; } = new List<Book>();
        public List<Book>? WishList { get; set; } = new List<Book>();

        public MSBorrower(int id, string username, string password, string name, string nickname,string address, string phoneNumber, string email) : base(id, name, username, password)
        {
            Nickname = nickname;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            MembershipStartDate = DateTime.Now;
            CheckedOutBooks.Capacity = 5;
        }

        public long CheckoutBook(Book book)
        {
            if (book != null && CheckedOutBooks.Count < 5 && !CheckedOutBooks.Contains(book) && book.Quantity > 0 && !HasOverdueBooks)
            {
                CheckedOutBooks.Add(book);
                book.Quantity--;
                book.BorrowDate = DateTime.Now;
                return book.ISBN;
            }
            else if(book.Quantity <= 0)
            {
                throw new BookHasBeenCheckedOutException();
            }
            return 0;
        }

        public long ReturnBook(Book book)
        {
            if (book != null && CheckedOutBooks.Contains(book))
            {
                CheckedOutBooks.Remove(book);
                book.Quantity++;
                book.ReturnDate = DateTime.Now;
                HasOverdueBooks = book.CheckBookOverdue();
                OutstandingFees = book.CalculateFees();
                return book.ISBN;
            }
            return 0;
        }

        public bool PayFees(decimal amount) // needs work
        {
            if (amount > 0 && OutstandingFees > 0 && HasOverdueBooks == true)
            {
                OutstandingFees -= amount;
                if (OutstandingFees < 0) OutstandingFees = 0;
                return true;
            }
            return false;
        }

        public void AddToWishList(Book book)
        {
            if (book != null && !WishList.Contains(book))
            {
                WishList.Add(book);
            }
        }

        public void RemoveFromWishList(Book book)
        {
            if (book != null && WishList.Contains(book))
            {
                WishList.Remove(book);
            }
        }
    }
}
