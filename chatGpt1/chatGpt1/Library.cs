namespace chatGpt1;

public class Library
{
        public string Name;
        public string Location;
        public List<Book> Books;

        public Library(string name, string location, List<Book> books)
        {
            this.Name = name;
            this.Location = location;
            this.Books = books;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);  
        }

        public void RemoveBook(string title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == title)
                {
                    Books.RemoveAt(i);
                    break;
                }
            }
        }

        public void PrintBook()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }  
        }
    
}