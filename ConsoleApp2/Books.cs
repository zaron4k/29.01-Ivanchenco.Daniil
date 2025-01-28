using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Books
    {
        /// <summary>
        /// название книги
        /// </summary>
        public string name="World and piece";
        /// <summary>
        /// автор книги
        /// </summary>       
        public string avtor="Tolstoy";
        /// <summary>
        /// год выпуска
        /// </summary>
        public int year=1863;
        /// <summary>
        /// объем в листах
        /// </summary>
        public int count=1696;
        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Название книги: {name}\nАвтор книги: {avtor}\nГод выпуска: {year}\nОбъем в листах:{count}");
        }
    }
}
