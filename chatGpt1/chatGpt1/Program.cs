using chatGpt1;
public class Program
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library("My Library","A1 Main VS", new List<Book>());

        Book book1 = new Book("Rich Dad Poor Dad", "Robert Kiyosaki", 1997);
        myLibrary.AddBook(book1);
        Book book2 = new Book("4 hour week", "Timothy Ferriss", 2007);
        myLibrary.AddBook(book2);
        Book book3 = new Book("The way of the superior man", "David Deida", 2001);
        myLibrary.AddBook(book3);
        
        myLibrary.RemoveBook("Rich Dad Poor Dad");
        myLibrary.PrintBook();
    }
}