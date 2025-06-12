using MyShelf.Logic.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.Logic.Models
{
    public class Book
    {
        //Book Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; } = 1;
        public DateTime PublishedDate { get; set; }
        public decimal RetailPrice { get; set; }
        
        //Check-in/out Properties
        public Queue<MSClient>? WaitList { get; set; } = new Queue<MSClient>();
        public TimeSpan BorrowDurationLimit { get; set; } = TimeSpan.FromDays(14);
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public TimeSpan LendDuration { get; set; } = new TimeSpan();
        public decimal FeeRate { get; set; } = 1.50m;
        public Book(string title, string author, long isbn, int pageCount, string genre, string description, int quantity, DateTime publishedDate, decimal retailPrice)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PageCount = pageCount;
            Genre = genre;
            Description = description;
            Quantity = quantity;
            PublishedDate = publishedDate;
            RetailPrice = retailPrice;
        }

        public bool CheckBookOverdue()
        {
            LendDuration = ReturnDate - BorrowDate;

            if(LendDuration.Days > BorrowDurationLimit.Days)
            {
                return true;
            }
            return false;
        }

        public decimal CalculateFees()
        {
            var isOverdue = CheckBookOverdue();

            if (isOverdue == true)
            {
                LendDuration = ReturnDate - BorrowDate;

                if (LendDuration.Days > BorrowDurationLimit.Days)
                {
                    var overdueDays = LendDuration.TotalDays - BorrowDurationLimit.TotalDays;

                    decimal fees = (decimal)overdueDays * FeeRate;

                    return fees;
                }
            }
            return 0;
        }

        public TimeSpan CheckLendDuration()
        {
            return LendDuration = ReturnDate.Date - BorrowDate.Date;
        }

        public string CheckOutBookInfo()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}";
        }
    }
}
