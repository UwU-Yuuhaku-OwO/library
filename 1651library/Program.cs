using _1651library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManage bookManage = new BookManage();

            int option;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" Menu ");

                        Console.WriteLine("======================================");
                        Console.WriteLine("| 1: Add book information          |");
                        Console.WriteLine("| 2: Show all Book.                |");
                        Console.WriteLine("| 3: Search book information by ID |");
                        Console.WriteLine("| 4: Update information by ID      |");
                        Console.WriteLine("| 5: Delete information by ID      |");
                        Console.WriteLine("| 0: Exit                          |");

                        Console.WriteLine("======================================");
                        Console.Write("Choose your menu option: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1: //Add Book
                                Console.Clear();
                                bookManage.AddBook();
                                Console.ReadKey();
                                break;

                            case 2: //Show Book
                                Console.Clear();
                                bookManage.ShowBook();
                                Console.ReadKey();
                                break;

                            case 3: //Find Book
                                Console.Clear();
                                Console.Write("Enter book id: ");
                                string bId = Console.ReadLine();
                                bookManage.FindBook(bId);
                                Console.ReadKey();
                                break;

                            case 4: // Update Book
                                Console.Clear();
                                Console.Write("Enter book ID to update: ");
                                string updateBookId = Console.ReadLine();
                                bookManage.UpdateBook(updateBookId);
                                Console.ReadKey();
                                break;

                            case 5: //Delete Book
                                Console.Clear();
                                Console.Write("Enter Book ID: ");
                                string delId = Console.ReadLine();
                                bookManage.DeleteBook(delId);
                                Console.ReadKey();
                                break;

                            case 0:
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please enter a number between 0 and 5.");
                                Console.ReadKey();
                                break;
                        }
                    } while (option != 0);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number. Please write option");
                }
            }
        }
    }
}
