using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wroxx.Publishing.Infrastructure;

namespace Wroxx.Publishing.Domain
{
    public class Author
    {
        private IBook _myBooks;
        public Author(IBook book)
        {
            _myBooks = book;
        }
       
        public IEnumerable<IGrouping<string, string>> GetRepeatedWordInfo()
        {
            //get the contents from a book and return the count of each words
            var contents = _myBooks.GetContents();

            var words = Regex.Split(contents, @"\W").Where(s => s != String.Empty);

            return words.GroupBy(x => x.ToLower());
        }

        public List<Tuple<string,int>> GetRepeatedWordCount()
        {
            return GetRepeatedWordInfo().Select(y=> new Tuple<string,int>(y.Key,y.Count())).ToList();
        }
    }
}
