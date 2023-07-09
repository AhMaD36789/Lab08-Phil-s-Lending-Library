using System.Collections;
using Lab08_Phil_s_Lending_Library.Classes;
using Lab08_Phil_s_Lending_Library.interfaces;

namespace Lab08_Phil_s_Lending_Library
{
    public class Program
    {
        static void Main(string[] args)
        {

            Library testLib = new Library();
            testLib.Add("bokokkaav1", "ahmad", "saleh", 300);
            testLib.Add("bokokkaav2", "ahmad", "saleh", 600);
            testLib.Add("bokokkaav3", "ahmad", "saleh", 900);
            testLib.BookPrint();
            Console.WriteLine("\n");
            Console.WriteLine("Book borrowed!");
            Console.WriteLine(testLib.Borrow("bokokkaav1"));
            Console.WriteLine("\n");
            testLib.BookPrint();
            Console.WriteLine("\n");
            Console.WriteLine("Book returned!");
            testLib.Return(new Book("bokokkaav1", "ahmad", "saleh", 300));
            Console.WriteLine("\n");
            testLib.BookPrint();

            Backpack<Book> backpack = new Backpack<Book>();
            backpack.Pack(new Book("bokokkaav1", "ahmad", "saleh", 300));
            backpack.Pack(new Book("bokokkaav2", "ahmad", "saleh", 300));
            backpack.Pack(new Book("bokokkaav3", "ahmad", "saleh", 300));
            Console.WriteLine("\n"); Console.WriteLine("\n");
            Console.WriteLine("\n");
            backpack.print();
            Console.WriteLine("\n");
            Console.WriteLine("item removed!");
            Console.WriteLine(backpack.Unpack(2));
            Console.WriteLine("\n"); Console.WriteLine("\n");
            backpack.print();
        }
    }
}
