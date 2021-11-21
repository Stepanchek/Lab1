namespace Data.Book
{
    public sealed class Date
    {
        internal int Year { get; }
        internal int Month { get; }
        internal int Day { get; }
        
        public Date(int year, int month, int day)
        {
            Day = day;
            Year = year;
            Month = month;
        }
    }
}