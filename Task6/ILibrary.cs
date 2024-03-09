namespace Task6;

public interface ILibrary
{

void AddBook(Book book);
List<Book>   DisplayBooks();

 void  DeleteBook(int id);

void  SearchByTitle (Book name);

void UpdateBook(Book book);

}
