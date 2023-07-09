using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab08_Phil_s_Lending_Library.Program;
using Lab08_Phil_s_Lending_Library.Classes;
using Lab08_Phil_s_Lending_Library.interfaces;

namespace Lab08_Phil_s_Lending_Library.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int numberOfPages { get; set; }

        public Book(string title, string firstname, string lastname, int numberofpages)
        {
            Title = title;
            firstName = firstname;
            lastName = lastname;
            numberOfPages = numberofpages;
        }

        public override string ToString()
        {
            return $"{Title}, {firstName} {lastName}, {numberOfPages}";
        }
    }
}
