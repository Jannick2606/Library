using System;
using System.Linq;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book hp = new Book("Harry Potter", 1, true, "J.K. Rowling");
            Book er = new Book("Eragon", 2, true, "Christopher Paolini");
            Book lr = new Book("Lord of the Rings", 3, true, "J.R.R Tolkien");
            Book gt = new Book("Game of Thrones", 4, true, "George R.R. Martin");

            List<Book> books = new List<Book>() { hp, er, lr, gt };
            Stack<Book> userLoan = new Stack<Book>() { };
            string remove = "y";
            while (books.Count > 0 && remove.Contains("y"))
            {
                Console.WriteLine("Available books:");
                for (int i = 0; i < books.Count; i++)
                {
                    if (books.ElementAt(i).Available == true)
                    {
                        Console.WriteLine(books.ElementAt(i).Title);
                    }
                }
                Console.WriteLine("Write the title on the book you want to borrow");
                string toStack = Console.ReadLine().ToLower();
                if (toStack == "harry potter")
                {
                    books.Remove(hp);
                    userLoan.Push(hp);
                }
                else if (toStack == "eragon")
                {
                    books.Remove(er);
                    userLoan.Push(er);
                }
                else if (toStack == "lord of the rings")
                {
                    books.Remove(lr);
                    userLoan.Push(lr);
                }
                else if (toStack == "game of thrones")
                {
                    books.Remove(gt);
                    userLoan.Push(gt);
                }
                else
                {
                    Console.WriteLine("This book doesn't exist in our library");
                }
                Console.Clear();
                Console.WriteLine("Your stack:");
                for (int i = 0; i < userLoan.Count; i++)
                {
                    Console.WriteLine(userLoan.ElementAt(i).Title);
                }
                if (books.Count > 0)
                {
                    Console.WriteLine("Do you want to borrow another book?");
                    remove = Console.ReadLine().ToLower();
                }
                Console.Clear();
            }
            for (int i = 0; i < userLoan.Count; i++)
            {
                Console.WriteLine($"You have borrowed {userLoan.Peek().Title} from the library");
                userLoan.Pop();
                i = -1;
            }
        }
    }
}
