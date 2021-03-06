using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; set; }
    public string Location { get; set; }
    private List<Book> Books { get; set; }
    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    private Book ValidateBook(string selection, List<Book> bookList)
    {
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }

    public void Checkout(string selection)
    {
      Book selectedBook = ValidateUserSelection(selection, AvailableBooks);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection");
        return;
      }
    }

    // constructor:
    public Library(string name, string location)
    {
      Name = name;
      Location = location;
      Books = new List<Book>();
    }
  }
}