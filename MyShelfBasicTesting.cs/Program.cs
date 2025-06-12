using MyShelf.Logic.Models;
using MyShelf.Logic.Users;
class Program
{
    static MSClient MSClient { get; set; } = new MSClient(1, "Coby", "coby123", "Coby", "123 Main St", "555-1234", "Email@You.com");
    static PersonalLibrary PersonalLibrary { get; set; }
    static BookCatalogue BookCatalogue { get; set; }
    static List<MSBorrower> Borrowers { get; set; }
    static void Main()
    {
        Console.WriteLine("MyShelf Basic Testing\n");
        BookCatalogueTest();
        BorrowerTest();
        PersonalLibraryTest();
    }

    static void BookCatalogueTest()
    {
        BookCatalogue = new BookCatalogue(1, "Catalogue1", "Empty Description");

        BookCatalogue.Books.Add(new Book("1984", "George Orwell", 9780451524935, 328, "Dystopian", "A novel about totalitarianism and surveillance.", 3, new DateTime(1949, 6, 8), 9.99m));
        BookCatalogue.Books.Add(new Book("To Kill a Mockingbird", "Harper Lee", 9780061120084, 281, "Fiction", "A novel about racial injustice in the Deep South.", 3, new DateTime(1960, 7, 11), 7.99m));
        BookCatalogue.Books.Add(new Book("Pride and Prejudice", "Jane Austen", 9780141040349, 279, "Romance", "A novel about love and social class in early 19th century England.", 3, new DateTime(1813, 1, 28), 6.99m));
    }

    static void BorrowerTest()
    {
        Borrowers = new List<MSBorrower>();

        Borrowers.Add(new MSBorrower(1, "john_doe", "password123", "John Doe", "John","123 Main St", "555-1234", "Email@You.com"));
        Borrowers.Add(new MSBorrower(2, "jane_smith", "password456", "Jane Smith", "Jane", "456 Elm St", "555-5678", "Email@You.com"));
        Borrowers.Add(new MSBorrower(3, "alice_jones", "password789", "Alice Jones", "Alice", "789 Oak St", "555-9012", "Email@You.com"));
    }

    static void PersonalLibraryTest()
    {
        PersonalLibrary = new PersonalLibrary(1,"My Personal Library", BookCatalogue);

        PersonalLibrary.Borrowers = Borrowers;

        MSClient.PersonalLibrary = PersonalLibrary;

        Console.WriteLine("Personal Library Information Before Check Out\n");

        DisplayPersonalLibraryInfo();

        Console.WriteLine("Personal Library Catalogues:\n");
        DisplayCatalogueInfo(MSClient.PersonalLibrary.Catalogues[0]);

        Console.WriteLine("Borrowers in Personal Library:\n");
        foreach (var borrower in MSClient.PersonalLibrary.Borrowers)
        {
            DisplayBorrowerInfo(borrower);
        }

        for (int i = 0; i < MSClient.PersonalLibrary.Borrowers.Count; i++)
        {
            MSClient.PersonalLibrary.Borrowers[i].CheckoutBook(MSClient.PersonalLibrary.Catalogues[0].Books[i]);
        }

        Console.WriteLine("Personal Library after Checkout\n");

        DisplayCatalogueInfo(MSClient.PersonalLibrary.Catalogues[0]);

        Console.WriteLine("Borrowers in Personal Library after Checkout:\n");
        foreach (var borrower in MSClient.PersonalLibrary.Borrowers)
        {
            DisplayBorrowerInfo(borrower);
        }

        Console.WriteLine("Personal Library Information After Book Returns\n");

        for (int i = 0; i < MSClient.PersonalLibrary.Borrowers.Count; i++)
        {
            MSClient.PersonalLibrary.Borrowers[i].ReturnBook(MSClient.PersonalLibrary.Catalogues[0].Books[i]);
        }

        DisplayCatalogueInfo(MSClient.PersonalLibrary.Catalogues[0]);

        Console.WriteLine("Borrowers in Personal Library after Returns:\n");
        foreach (var borrower in MSClient.PersonalLibrary.Borrowers)
        {
            DisplayBorrowerInfo(borrower);
        }
    }

    static void DisplayPersonalLibraryInfo()
    {
        Console.WriteLine($"Personal Library ID: {PersonalLibrary.Id}");
        Console.WriteLine($"Personal Library Name: {PersonalLibrary.Name}");
        Console.WriteLine($"Total Catalogues: {PersonalLibrary.Catalogues.Count}");
        Console.WriteLine($"Total Borrowers: {PersonalLibrary.Borrowers.Count}\n");
    }

    static void DisplayCatalogueInfo(BookCatalogue catalogue)
    {
        Console.WriteLine($"Catalogue ID: {catalogue.Id}");
        Console.WriteLine($"Catalogue Name: {catalogue.Name}");
        Console.WriteLine($"Catalogue Description: {catalogue.Description}");
        Console.WriteLine($"Catalogue Book Count: {catalogue.Books.Count}");

        Console.WriteLine("Books in Catalogue:\n");
        foreach (var book in catalogue.Books)
        {
            Console.WriteLine("        Book Information:");
            Console.WriteLine($"        Title: {book.Title}");
            Console.WriteLine($"        Author: {book.Author}");
            Console.WriteLine($"        ISBN: {book.ISBN}");
            Console.WriteLine($"        Quantity: {book.Quantity}\n");
        }
    }

    static void DisplayBorrowerInfo(MSBorrower borrower)
    {
        Console.WriteLine("Borrower Information:");
        Console.WriteLine($"ID: {borrower.Id}");
        Console.WriteLine($"Name: {borrower.Name}");
        Console.WriteLine($"Checked-Out Books: {borrower.CheckedOutBooks.Count}\n");

        foreach (var book in borrower.CheckedOutBooks)
        {
            Console.WriteLine($"    Checked Out Book: {book.Title} by {book.Author}");
            Console.WriteLine($"    Borrow Date: {book.BorrowDate}\n");
        }
    }
}