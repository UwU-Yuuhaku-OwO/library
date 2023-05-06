using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1651library
{
    internal class GraphicDesign : Book
    {
        public GraphicDesign(string bId, string bName, string author, int yoP, string category) : base(bId, bName, author, yoP, category)
        {
            this.category = "Graphic Design";
        } 
    }
}
