using System.Collections.Generic;
using Data.Book;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new BookDatabase();

            var firstCharacter = new Character(ERole.Main, new List<string>()
            {
                "Dog"
            }, new List<string>()
            {
                "Jesse"
            });
            
            var secondCharacter = new Character(ERole.Main, new List<string>()
            {
                "Cat"
            }, new List<string>()
            {
                "Jesse"
            });
            
            var thirdCharacter = new Character(ERole.Main, new List<string>()
            {
                "Whale"
            }, new List<string>()
            {
                "Tom"
            });

            var firstBook = new Book("Dog", new List<string>()
            {
                "Jesse"
            }, new Date(2014, 6, 2), 300, "", new List<Character>()
            {
                firstCharacter
            });
            
            var secondBook = new Book("Cat", new List<string>()
            {
                "Tom"
            }, new Date(2013, 6, 2), 300, "", new List<Character>()
            {
                secondCharacter, thirdCharacter
            });
            
            var thirdBook = new Book("Whale", new List<string>()
            {
                "Timmy"
            }, new Date(2017, 6, 2), 300, "", new List<Character>()
            {
                thirdCharacter
            });
            
            database.AddBook(firstBook);
            database.AddBook(secondBook);
            database.AddBook(thirdBook);

            var books = database.GetGroup(secondBook);
            var books2 = database.FindByAuthor("Jesse");
            var books3 = database.FindByCharacter(thirdCharacter);
        }
    }
}