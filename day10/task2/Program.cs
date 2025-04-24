namespace task2
{
    class Program
    {
        static void Main()
        {
            HomeLibrary library = new HomeLibrary();

            library.AddBook(new Book("1984", "George Orwell", 1949, "Dystopia"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960, "Classic"));
            library.AddBook(new Book("The Martian", "Andy Weir", 2011, "Science Fiction"));

            Console.WriteLine("Все книги в библиотеке:");
            foreach (var book in library.GetAllBooks())
                Console.WriteLine(book);

            Console.WriteLine("\nПоиск по автору 'George Orwell':");
            foreach (var book in library.FindByAuthor("George Orwell"))
                Console.WriteLine(book);

            Console.WriteLine("\nПоиск по году 2011:");
            foreach (var book in library.FindByYear(2011))
                Console.WriteLine(book);

            Console.WriteLine("\nСравнение книг по году:");
            Book b1 = library.GetBook(0);
            Book b2 = library.GetBook(1);
            if (b1 != null && b2 != null)
            {
                Console.WriteLine(b1 > b2 ? $"{b1.Title} позже {b2.Title}" : $"{b1.Title} раньше {b2.Title}");
            }
        }
    }
}
