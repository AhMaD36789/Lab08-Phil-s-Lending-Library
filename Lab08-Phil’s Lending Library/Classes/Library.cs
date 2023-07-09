using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab08_Phil_s_Lending_Library.Program;
using Lab08_Phil_s_Lending_Library.Classes;
using Lab08_Phil_s_Lending_Library.interfaces;

namespace Lab08_Phil_s_Lending_Library.Classes
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> LibraryBooks;

        public Library()
        {
            LibraryBooks = new Dictionary<string, Book>();
        }
        public int Count => LibraryBooks.Count;
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            LibraryBooks.Add(title, book);

        }

        public Book Borrow(string title)
        {
            foreach (var item in LibraryBooks)
            {
                if (item.Key == title)
                {
                    Book b = item.Value;
                    LibraryBooks.Remove(item.Key);
                    return b;
                }
            }
            return null;
        }

        public void BookPrint()
        {
            Console.WriteLine("List of available books:");
            foreach (var item in LibraryBooks)
            {
                Console.WriteLine(item.Key + "\t" + item.Value.firstName + " " + item.Value.lastName + "\t" + item.Value.numberOfPages);
            }
        }

        public void Return(Book book)
        {
            Console.WriteLine(book.Title + "\t" + book.firstName + " " + book.lastName + "\t" + book.numberOfPages);
            LibraryBooks.Add(book.Title, book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return LibraryBooks.Values.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
