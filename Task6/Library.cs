using System.Diagnostics;

namespace Task6;


public class Library : Book, ILibrary

{


   List<Book> books= new List<Book>();




    public Library(int id, string title, string author) : base(id, title, author)
    {
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DeleteBook(int id)
    {
       foreach (var item in books)
       {
        if(item.Id==id)
        {
              books.Remove(item);
         }
       }
    }

    public List<Book> DisplayBooks()
    {
        return books;
    }

    public void SearchByTitle(Book name)
    {
         foreach (var item in books)
         {
          if(item.Title==name.Title)

          {

                 System.Console.WriteLine(item.Id);
                      System.Console.WriteLine(item.Title);
                           System.Console.WriteLine(item.Author);
          }

         }

    }

    public void UpdateBook(Book book)
    {
       foreach (var item in books)
         {
          if(item.Title==book.Title)

          {

            item.Id = book.Id;
            item.Title = book.Title;
            item.Author= book.Author;
          }

         }
    }
}
