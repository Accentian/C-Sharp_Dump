using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> myBooks = new List<Book>()
            {
                new Book() { ISBN = "1234-45-34-3939", Title = "The Long Road", Publisher = "New York", Price = 25.00, Copyright = 2016 },
                new Book() { ISBN = "988-65-34-9012", Title = "The Warrior", Publisher = "McGraw", Price = 55.00, Copyright = 2013 },
                new Book() { ISBN = "8712-45-84-2539", Title = "Yesterday", Publisher = "New York", Price = 67.00, Copyright = 2016 },
                new Book() { ISBN = "1234-78-99-3478", Title = "Programming Essentials", Publisher = "Dalton", Price = 35.00, Copyright = 2015 },
                new Book() { ISBN = "8356-89-33-3251", Title = "Hello World", Publisher = "Chicago Press", Price = 115.00, Copyright = 2016 }
            };

            // Show books published by New York
            var pubNY = myBooks.Where(b => b.Publisher == "New York");
            foreach (var book in pubNY)
            {
                Console.WriteLine("{0} {1} {2}", book.ISBN, book.Title, book.Publisher);
            }

            // Display books in Descending order by Copyright
            var desCopyright = myBooks.OrderByDescending(b => b.Copyright);

            Console.WriteLine("__________________________________");
            foreach(var book in desCopyright)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", book.ISBN, book.Title, 
                    book.Publisher, book.Price, book.Copyright);
            }

            // Display in Descending order by Copyright published by New York
            var nyCopyright = myBooks.OrderByDescending
                (b => b.Copyright).Where(b => b.Publisher == "New York");

            Console.WriteLine("__________________________________");
            foreach (var book in nyCopyright)
            {
                Console.WriteLine("{0} {1} {2} {3:C} {4}", book.ISBN, book.Title,
                    book.Publisher, book.Price, book.Copyright);
            }

            // Display books with Copyright greater than 2015
            var greaterCopyright = myBooks.OrderByDescending
                (b => b.Copyright).Where(b => b.Copyright > 2015);
            
            Console.WriteLine("__________________________________");
            foreach(var books in greaterCopyright)
            {
                Console.WriteLine("{0} {1}", books.ISBN, books.Title);
            }


            // Sort by title in Descending order and display first book only
            var firstTitle = myBooks.OrderByDescending(b => b.Title).First();
            
            Console.WriteLine("__________________________________");
            Console.WriteLine("{0} {1}", firstTitle.ISBN, firstTitle.Title);

            // LINQ to sum and find average cost for all books
            var avg = myBooks.Average(b => b.Price);

            Console.WriteLine("__________________________________");
            Console.WriteLine("{0:C}", avg);


            // LINQ markup price for each book
            myBooks.ForEach(p => p.Price += p.Price * 0.03);

            Console.WriteLine("__________________________________");
            myBooks.ForEach(b => Console.WriteLine("{0} {1:C}", b.Title, b.Price));

            Console.ReadLine();

        } // End main
    } // End class

    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Copyright { get; set; }
    }

} // End namespace
