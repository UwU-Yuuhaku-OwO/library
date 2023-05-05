using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651library
{
    internal class Book
    {
        public string bId;
        public string bName;
        public string author;
        public int YoP;
        public string Category;

        public Book(string bId, string bName, string author, int yoP, string category)
        {
            this.bId = bId;
            this.bName = bName;
            this.author = author;
            YoP = yoP;
            this.Category = category; 
        }

        public Book() { }

        public string BId
        {
            get { return bId; }
            set { bId = value; }
        }

        public string Author { get { return author; } set { author = value; } }
        public string BName { get { return bName; } set { bName = value; } }
        public string category { get { return Category; } set { Category = value; } }
        public int YOP { get { return YOP; } set { YOP = value; } }

        public virtual void showBook()
        {

            Console.WriteLine("ID of Book: " + bId);
            Console.WriteLine("Name of Book: " + bName);
            Console.WriteLine("Author of Book: " + author);
            Console.WriteLine("Year of Publication: " + YoP);
            Console.WriteLine("Category: " + category);

        }


    }
}
