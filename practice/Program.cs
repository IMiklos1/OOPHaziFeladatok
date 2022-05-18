using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new("konyvcime", "irojaa");
            //book1.Title = "konyvcime";
            //book1.Author = "irojaa";
            //book1.Price = 2500;
            //Console.WriteLine(book1.ToString());        //4.gyakhazi    

            //Console.Write("Adja meg hany konyvet szeretne beolvasni: ");
            //string s = Console.ReadLine();
            //int n;
            //while (!Int32.TryParse(s, out n));

            Book[] book = new Book[3];
            //for(int i = 0; i < n; i++)
            //{
                //int price, pages;
                //Console.Write("Adja meg a konyv cimet: ");
                //string name = Console.ReadLine();
                //Console.Write("Adja meg a konyv szerzojet: ");
                //string author = Console.ReadLine();
                //Console.Write("Adja meg a konyv arat: ");
                //while (!Int32.TryParse(Console.ReadLine(), out price));
                //Console.Write("Adja meg hany oldalas a konyv: ");
                //while (!Int32.TryParse(Console.ReadLine(), out pages));
                //Console.Write("Adja meg a konyv kiadojat: ");
                //string publisher = Console.ReadLine();
                //book[i] = new Book(name, author, price, pages, publisher);
                //book[i].WriteItOut();

                book[0] = new Book("name1", "author1", 2000, 40, "publisher1");
                book[0].WriteItOut();
                book[1] = new Book("name2", "author2", 8000, 20, "publisher2");
                book[1].WriteItOut();
                book[2] = new Book("name3", "author3", 11000, 25, "publisher3");
                book[2].WriteItOut();
            //}

            Book.LongestBook(book);


        }
    }
}
