namespace task2
{
    public class Book : IComparable<Book>
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }
        public string Category { get; }

        public Book(string title, string author, int year, string category)
        {
            Title = title;
            Author = author;
            Year = year;
            Category = category;
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return Year.CompareTo(other.Year); 
        }

        public static bool operator >(Book a, Book b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(Book a, Book b)
        {
            return a.CompareTo(b) < 0;
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author}, {Year}, Category: {Category}";
        }
    }
}
