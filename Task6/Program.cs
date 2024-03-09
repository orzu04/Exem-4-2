




using Task6;

var library = new Library(1, "Shohnamo", "Firdavsi");
library.Id=1;
library.Title="Shohnamo";
library.Author="Firdavsi";

var library2 = new Library(2, "Modarnoma", "Firdavsi");
library2.Id=2;
library2.Title="Modarnoma";
library2.Author="Firdavsi";

var library3 = new Library(3, "Javoni raft", "Firdavsi");
library3.Id=3;
library3.Title="Javoni raft";
library3.Author="Firdavsi";

library.AddBook(library);
library.AddBook(library2);
library.AddBook(library3);
library.DisplayBooks();




while (true)
{


    System.Console.WriteLine($"baroi didani kitobho: displayBook");
    System.Console.WriteLine($"baroi kitobi nav ilova kardan: addBook");
    System.Console.WriteLine($"Baroi kitobro horij kardan: deletBook ");
    System.Console.WriteLine($"Baroi aznomash yoftan: searchByTitle");


    string comant = Console.ReadLine();
    if (comant == "addBook")
    {
        var library4 = new Library(4, "Bahor Omad", "Firdavsi");
        library.AddBook(library4);

    }

    else if (comant == "displayBook")
    {

    foreach (var item in library.DisplayBooks())
{
    System.Console.WriteLine(item.Id);
     System.Console.WriteLine(item.Title);
      System.Console.WriteLine(item.Author);
}
    }

    else if(comant=="deletBook")
{

    library.DeleteBook(1);
 

}
break;
 
}