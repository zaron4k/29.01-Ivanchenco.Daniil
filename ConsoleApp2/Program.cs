using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Books books = new Books();
            books.Print();
            Console.WriteLine();
            //2
            string nameBooks = books.name;
            string avtorBooks = books.avtor;
            int yearBooks=books.year;
            int countBooks=books.count;
            Console.WriteLine($"Название книги: {nameBooks}\nАвтор книги: {avtorBooks}\nГод выпуска: {yearBooks}\nОбъем в листах:{countBooks}");
            Console.WriteLine();
            //3
            books.name = "Преступление и наказание";
            books.avtor = "Dostoevskii";
            books.year = 2023;
            books.count = 400;
            books.Print();
            Console.WriteLine();
            //4
            Console.Write("Название книги : ");
            books.name =Console.ReadLine();
            Console.Write("Автор книги : ");
            books.avtor = Console.ReadLine();
            Console.Write("Год выпуска : ");
                books.year=int.Parse(Console.ReadLine());
            Console.Write("Объем в листах : ");
                books.count = int.Parse(Console.ReadLine());
            books.Print();
            Console.Read();
        }
    }
}
