using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class Book : Product
    {
        public string Author { get; private set; }

        public Book(string title, string author, decimal cost) : base(title, cost)
        {
            this.Author = author;
        }

        public override string GetDescription()
        {
            return "Book " + this.Title; 
        }
    }
}
