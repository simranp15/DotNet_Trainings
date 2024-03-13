using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Books
    {
        // ----------------------Answer1---------
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookname, string authorname)
        {
            BookName = bookname;
            AuthorName = authorname;
        }
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}");
            Console.WriteLine($"Author Name: {AuthorName}");
        }
    }
    class BookShelf
    {
        private Books[] books = new Books[5];

        // Indexer
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

    }
       class Books_Display
    {
        static void Main(string[] args)
        {
            
            BookShelf bk = new BookShelf();


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Book {i + 1} Name: ");
                string bookname = Console.ReadLine();

                Console.Write($"Enter Author Name for {bookname}: ");
                string authorname = Console.ReadLine();

                bk[i] = new Books(bookname, authorname);
            }

            Console.WriteLine("\nBook Details:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i + 1}:");
                bk[i].Display();
               Console.ReadLine();
            }
        }
    }
}
