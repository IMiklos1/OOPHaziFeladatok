using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Book
    {
        private string _title;
        private string _author;
        private readonly string _yearOfAppearance = DateTime.Today.ToString("yyyy");
        private int _price;

        private int _pages; //6.hetihazi
        private string _publisher = "Mora"; //6.hetihazi

        public Book()
        { }

        public Book(string title, string author) //5.hetihazi
        {
            _title = title;
            _author = author;
        }

        public Book(string title, string author, int price) //5.hetihazi
        {
            _title = title;
            _author = author;
            _price = price;
        }

        public Book(string title, string author, int price, int pages, string publisher)
        {
            _title = title;
            _author = author;
            _price = price;
            _pages = pages;
            _publisher = publisher;
        }

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int Price { get => _price; set => _price = value; }

        public string YearOfAppearance => _yearOfAppearance;

        public int Pages { get => _pages; set => _pages = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }

        public int IncreasePrice(int percent)
        {
            return this._price = _price * (1 + percent);
        }

        public void WriteItOut() //4.hazis kiiras
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString() //5. ToString feluldefinialas
        {
            return $"Title: {_title}, Author: {_author}, Appearance: {YearOfAppearance}, Price: {_price} Ft, Pages: {_pages}, Publisher: {_publisher}"; 
        }

        public static Book WhichIsLonger(Book book1, Book book2) //osztalyszintu metodus ami eldonti 2 parameterrol h melyik a hosszabb
        {
            if (book1.Pages > book2.Pages) return book1;
            else return book2;
        }

        public bool OddPages() // olyan metodus ami igazat ad vissza ha a konyv oldalszama paros
        {
            return Pages % 2 == 0;
        }

        public static void LongestBook(Book[] bookArray)
        {
            int max = 0;
            for (int i = 0; i < bookArray.Length; i++)
            {
                if (bookArray[i].Pages > bookArray[max].Pages) max = i;
            }
            bookArray[max].WriteItOut();

            //Book b1 = bookArray.First();
            //foreach (Book book in bookArray.Skip(1))
            //{
            //    if (book.Pages > b1.Pages) b1 = book;
            //}

            //Book b2 = bookArray.Where(b => b.Pages == bookArray.Max(m => m.Pages)).First();
        }

        public static void WriteOutByAuthor(Book[] bookArray)
        {

            List<Book> bookList = new List<Book>(bookArray);
            
        }
    }

}
