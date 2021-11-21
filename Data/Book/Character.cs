using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Book
{
    public sealed class Character : IEquatable<Character>
    {
        public ERole Role { get; }
        public List<string> Books { get; }
        public List<string> Names { get; }

        public Character(ERole role, List<string> books, List<string> names)
        {
            Role = role;
            Books = books;
            Names = names;
        }
        
        public bool Equals(Character? other)
        {
            if (ReferenceEquals(this, other))
                return true;
            
            var areTheSameNames = other?.Names.Intersect(Names).Count() == Names.Count;
            var areTheSameBooks = other?.Books.Intersect(Books).Count() == Names.Count;

            return areTheSameBooks && areTheSameNames;
        }
    }
}