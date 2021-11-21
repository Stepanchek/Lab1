using System.Collections.Generic;
using System.Linq;

namespace Data.Book
{
    public sealed class BookDatabase
    {
        private List<Book> _books = new();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public List<Book> GetGroup(Book book)
        {
            var result = _books.Where(x => x.Characters.Intersect(book.Characters).Any()).ToList();
            
            result.Sort((x, y) =>
            {
                var firstDate = x.Date;
                var secondDate = y.Date;

                return (firstDate.Year - secondDate.Year) * 100 + 
                    (firstDate.Month - firstDate.Month) * 10 + 
                    (firstDate.Day - firstDate.Day);
            });

            return result;
        }

        public List<Book> FindByAuthor(string author)
        {
            return _books.Where(x => x.Authors.Contains(author)).ToList();
        }

        public List<Book> FindByCharacter(Character character)
        {
            return _books.Where(x => x.Characters.Contains(character)).ToList();
        }
    }
}