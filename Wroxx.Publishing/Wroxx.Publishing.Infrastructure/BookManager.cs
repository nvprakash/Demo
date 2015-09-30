using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wroxx.Publishing.Infrastructure
{
    public class BookManager : IBook
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string GetContents()
        {
            // Implementation for reading the contents of the book
            //
            return "This is a statement, and so is this.";
        }
    }
}
