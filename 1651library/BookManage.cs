using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1651library
{
    internal class BookManage
    {
        public List<Book> BookMng;
        public BookManage() { BookMng = new List<Book>(); }

        public void AddBook()
        {

            Console.WriteLine("How many Book you want to add: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("___________________________________");
                Console.Write("Enter book id: ");
                string bId = Console.ReadLine();

                if (BookMng.Any(book => book.bId == bId))
                {
                    Console.WriteLine("A book with this ID already exists. Please enter a different ID.");
                    i--; // Decrement i to repeat the iteration for the same book
                    continue;
                }

                Console.Write("Enter book name: ");
                string bName = Console.ReadLine();
                Console.Write("Enter author of book: ");
                string author = Console.ReadLine();
                Console.Write("Enter Year of Publication: ");
                int YoP = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Select the book's category number: ");
                Console.WriteLine("1. It");
                Console.WriteLine("2. Graphic Design");
                Console.WriteLine("3. Business");
                Console.Write("Enter Category:");
                string Category = null;

                bool validInput = false;
                while (!validInput)
                {

                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            It it = new It(bId, bName, author, YoP, Category);
                            BookMng.Add(it);
                            validInput = true;
                            Console.WriteLine("Book added successfully!");
                            break;
                        case 2:
                            GraphicDesign gd = new GraphicDesign(bId, bName, author, YoP, Category);
                            BookMng.Add(gd);
                            validInput = true;
                            Console.WriteLine("Book added successfully!");
                            break;
                        case 3:

                            Business bus = new Business(bId, bName, author, YoP, Category);
                            BookMng.Add(bus);
                            validInput = true;
                            Console.WriteLine("Book added successfully!");
                            break;
                        default:
                            Console.WriteLine("Invalid category number. Please try again.");
                            break;
                    }
                }

            }
            Console.WriteLine("___________________________________");
            Console.WriteLine("enter any key to leave");


        }

        public void ShowBook()
        {
            if (BookMng.Count == 0)
            {
                Console.WriteLine("There are no books to show.");
                return;
            }

            Console.WriteLine("All Books:\n");
            foreach (Book book in BookMng)
            {
                Console.WriteLine("!----------------------!");
                book.showBook();
                Console.WriteLine("!----------------------!");
            }
        }

        public void FindBook(string bId)
        {
            bool bookFound = false;
            foreach (Book book in BookMng)
            {
                if (book.bId == bId)
                {
                    Console.WriteLine("!----------------------!");
                    book.showBook();
                    Console.WriteLine("!----------------------!");
                    bookFound = true;
                    break;
                }
            }
            if (!bookFound)
            {
                Console.WriteLine("Book with ID " + bId + " not found.");
            }
        }

        public void UpdateBook(string bId)
        {
            Book book = BookMng.FirstOrDefault(b => b.bId == bId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.Write("Enter new book name: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                book.bName = newName;
            }

            Console.Write("Enter new author of book: ");
            string newAuthor = Console.ReadLine();
            if (!string.IsNullOrEmpty(newAuthor))
            {
                book.author = newAuthor;
            }

            Console.Write("Enter new Year of Publication: ");
            string newYop = Console.ReadLine();
            int yop;
            if (int.TryParse(newYop, out yop))
            {
                book.YoP = yop;
            }
            string Category = null;

            Console.WriteLine("Enter new Category");
            Console.WriteLine("Select the book's category number: ");
            Console.WriteLine("1. It");
            Console.WriteLine("2. Graphic Design");
            Console.WriteLine("3. Business");

            bool validInput = false;
            while (!validInput)
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        book.category = "It";
                        BookMng.Add(it);
                        validInput = true;
                        Console.WriteLine("Book Update successfully!");
                        break;
                    case 2:
                        book.category = "Graphic Design";
                        validInput = true;
                        Console.WriteLine("Book Update successfully!");

                        break;
                    case 3:
                        book.category = "Business";
                        validInput = true;
                        Console.WriteLine("Book Update successfully!");

                        break;
                    default:
                        Console.WriteLine("Invalid category number. Please try again.");
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Enter to Leave!");
        }

        public void DeleteBook(string bId)
        {
            Book bookToDelete = BookMng.Find(b => b.bId == bId);

            if (bookToDelete != null)
            {
                BookMng.Remove(bookToDelete);
                Console.WriteLine($"Book with ID {bId} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Book with ID {bId} does not exist.");
            }
        }
    }

}


