using System.Collections.Generic;

namespace Data.Book
{
    public sealed class Book
    {
        public string Name { get; }
        public List<string> Authors { get; }
        public Date Date { get; }
        public int Pages { get; }
        public string Description { get; }
        public List<Character> Characters { get; }


        public Book(string name, List<string> authors, Date date, int pages, string description, List<Character> characters)
        {
            Name = name;
            Authors = authors;
            Date = date;
            Pages = pages;
            Description = description;
            Characters = characters;
        }
    }
}