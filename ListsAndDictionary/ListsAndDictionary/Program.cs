using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book() {
                ISBN = "1111",
                Author = "James Potter",
                Title = "Joustling",
                Publisher = "New York Company",
                Copyright = "2/19/2018"
            };

            Book book2 = new Book()
            {
                ISBN = "2222",
                Author = "Jack Koplin",
                Title = "Artmeis Sky",
                Publisher = "Penguin Publishing Company",
                Copyright = "6/22/2020"
            };

            Book book3 = new Book()
            {
                ISBN = "3333",
                Author = "Barley Myers",
                Title = "Horror Mask",
                Publisher = "Pen and Paper Inc.",
                Copyright = "7/2/2007"
            };

            Book book4 = new Book()
            {
                ISBN = "4444",
                Author = "Jason Vinland",
                Title = "Viking Sailing",
                Publisher = "New York Company",
                Copyright = "9/12/2019"
            };

            Book book5 = new Book()
            {
                ISBN = "5555",
                Author = "Lu Miu",
                Title = "Freedom",
                Publisher = "Pen and Paper Inc.",
                Copyright = "12/24/2018"
            };

            List<Book> myList = new List<Book>();
            myList.Add(book1);
            myList.Add(book2);
            myList.Add(book3);
            myList.Add(book4);
            myList.Add(book5);

            foreach(Book novel in myList)
            {
                Console.WriteLine("ISBN: {0}  ||  Author: {1}  ||   Title: {2}   ||   Publisher: {3}  ||   Copyright: {4}",
                    novel.ISBN, novel.Author, novel.Title, novel.Publisher, novel.Copyright);
            }

            Console.WriteLine("--------------------------------------------");

            Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
            myDictionary.Add(book1.ISBN, book1);
            myDictionary.Add(book2.ISBN, book2);
            myDictionary.Add(book3.ISBN, book3);
            myDictionary.Add(book4.ISBN, book4);
            myDictionary.Add(book5.ISBN, book5);

            foreach (Book novel in myList)
            {
                Console.WriteLine("Author: {0}  ||   Title: {1}   ||   Publisher: {2}  ||   Copyright: {3}",
                    novel.Author, novel.Title, novel.Publisher, novel.Copyright);
                Console.WriteLine();
            }

            Console.ReadLine();

        } // End main
    } // End class


    class Book
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Copyright { get; set; }
    } // End class Book

} // End namespace
