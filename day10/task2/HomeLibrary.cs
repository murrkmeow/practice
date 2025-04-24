namespace task2
{
    public class HomeLibrary
    {
        private Book[] books = new Book[10];
        private int count = 0;

        public void AddBook(Book book)
        {
            if (count >= books.Length)
            {
                Array.Resize(ref books, books.Length * 2);
            }
            books[count++] = book;
        }

        public bool RemoveBook(Book book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Equals(book))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[--count] = null;
                    return true;
                }
            }
            return false;
        }

        public Book GetBook(int index)
        {
            if (index >= 0 && index < count)
                return books[index];
            return null;
        }

        public Book[] FindByAuthor(string author)
        {
            return Array.FindAll(books[..count], b => b.Author.ToLower().Contains(author.ToLower()));
        }

        public Book[] FindByYear(int year)
        {
            return Array.FindAll(books[..count], b => b.Year == year);
        }

        public Book[] FindByCategory(string category)
        {
            return Array.FindAll(books[..count], b => b.Category.ToLower().Contains(category.ToLower()));
        }

        public int Count => count;

        public Book[] GetAllBooks()
        {
            Book[] result = new Book[count];
            Array.Copy(books, result, count);
            return result;
        }
    }
}
